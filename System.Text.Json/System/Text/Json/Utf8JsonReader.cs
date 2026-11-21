using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x02000036 RID: 54
	[CompilerFeatureRequired("RefStructs")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public ref struct Utf8JsonReader
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000B89A File Offset: 0x00009A9A
		private readonly bool IsLastSpan
		{
			get
			{
				return this._isFinalBlock && (!this._isMultiSegment || this._isLastSegment);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000B8B6 File Offset: 0x00009AB6
		internal readonly ReadOnlySequence<byte> OriginalSequence
		{
			get
			{
				return this._sequence;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		internal readonly ReadOnlySpan<byte> OriginalSpan
		{
			get
			{
				if (!this._sequence.IsEmpty)
				{
					return default(ReadOnlySpan<byte>);
				}
				return this._buffer;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000B8EC File Offset: 0x00009AEC
		internal readonly int ValueLength
		{
			get
			{
				if (!this.HasValueSequence)
				{
					return this.ValueSpan.Length;
				}
				return checked((int)this.ValueSequence.Length);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000B91F File Offset: 0x00009B1F
		internal readonly bool AllowMultipleValues
		{
			get
			{
				return this._readerOptions.AllowMultipleValues;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000B92C File Offset: 0x00009B2C
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000B934 File Offset: 0x00009B34
		public ReadOnlySpan<byte> ValueSpan { readonly get; private set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000B93D File Offset: 0x00009B3D
		public readonly long BytesConsumed
		{
			get
			{
				return this._totalConsumed + (long)this._consumed;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000B94D File Offset: 0x00009B4D
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0000B955 File Offset: 0x00009B55
		public long TokenStartIndex { readonly get; private set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000B960 File Offset: 0x00009B60
		public readonly int CurrentDepth
		{
			get
			{
				BitStack bitStack = this._bitStack;
				int num = bitStack.CurrentDepth;
				JsonTokenType tokenType = this.TokenType;
				bool flag = tokenType == JsonTokenType.StartObject || tokenType == JsonTokenType.StartArray;
				if (flag)
				{
					num--;
				}
				return num;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000B999 File Offset: 0x00009B99
		internal readonly bool IsInArray
		{
			get
			{
				return !this._inObject;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public readonly JsonTokenType TokenType
		{
			get
			{
				return this._tokenType;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000B9AC File Offset: 0x00009BAC
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		public bool HasValueSequence { readonly get; private set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000B9BD File Offset: 0x00009BBD
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000B9C5 File Offset: 0x00009BC5
		public bool ValueIsEscaped { readonly get; private set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000B9CE File Offset: 0x00009BCE
		public readonly bool IsFinalBlock
		{
			get
			{
				return this._isFinalBlock;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000B9D6 File Offset: 0x00009BD6
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000B9DE File Offset: 0x00009BDE
		public ReadOnlySequence<byte> ValueSequence { readonly get; private set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public readonly SequencePosition Position
		{
			get
			{
				if (this._isInputSequence)
				{
					return this._sequence.GetPosition((long)this._consumed, this._currentPosition);
				}
				return default(SequencePosition);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000BA20 File Offset: 0x00009C20
		public readonly JsonReaderState CurrentState
		{
			get
			{
				return new JsonReaderState(this._lineNumber, this._bytePositionInLine, this._inObject, this._isNotPrimitive, this.ValueIsEscaped, this._trailingCommaBeforeComment, this._tokenType, this._previousTokenType, this._readerOptions, this._bitStack);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000BA70 File Offset: 0x00009C70
		public Utf8JsonReader(ReadOnlySpan<byte> jsonData, bool isFinalBlock, JsonReaderState state)
		{
			this._buffer = jsonData;
			this._isFinalBlock = isFinalBlock;
			this._isInputSequence = false;
			this._lineNumber = state._lineNumber;
			this._bytePositionInLine = state._bytePositionInLine;
			this._inObject = state._inObject;
			this._isNotPrimitive = state._isNotPrimitive;
			this.ValueIsEscaped = state._valueIsEscaped;
			this._trailingCommaBeforeComment = state._trailingCommaBeforeComment;
			this._tokenType = state._tokenType;
			this._previousTokenType = state._previousTokenType;
			this._readerOptions = state._readerOptions;
			if (this._readerOptions.MaxDepth == 0)
			{
				this._readerOptions.MaxDepth = 64;
			}
			this._bitStack = state._bitStack;
			this._consumed = 0;
			this.TokenStartIndex = 0L;
			this._totalConsumed = 0L;
			this._isLastSegment = this._isFinalBlock;
			this._isMultiSegment = false;
			this.ValueSpan = ReadOnlySpan<byte>.Empty;
			this._currentPosition = default(SequencePosition);
			this._nextPosition = default(SequencePosition);
			this._sequence = default(ReadOnlySequence<byte>);
			this.HasValueSequence = false;
			this.ValueSequence = ReadOnlySequence<byte>.Empty;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000BB8F File Offset: 0x00009D8F
		public Utf8JsonReader(ReadOnlySpan<byte> jsonData, JsonReaderOptions options = default(JsonReaderOptions))
		{
			this = new Utf8JsonReader(jsonData, true, new JsonReaderState(options));
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		public bool Read()
		{
			bool flag = this._isMultiSegment ? this.ReadMultiSegment() : this.ReadSingleSegment();
			if (!flag && this._isFinalBlock && this.TokenType == JsonTokenType.None && !this._readerOptions.AllowMultipleValues)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedJsonTokens, 0, default(ReadOnlySpan<byte>));
			}
			return flag;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000BBF6 File Offset: 0x00009DF6
		public void Skip()
		{
			if (!this._isFinalBlock)
			{
				ThrowHelper.ThrowInvalidOperationException_CannotSkipOnPartial();
			}
			this.SkipHelper();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000BC0C File Offset: 0x00009E0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SkipHelper()
		{
			if (this.TokenType == JsonTokenType.PropertyName)
			{
				this.Read();
			}
			JsonTokenType tokenType = this.TokenType;
			bool flag = tokenType == JsonTokenType.StartObject || tokenType == JsonTokenType.StartArray;
			if (flag)
			{
				int currentDepth = this.CurrentDepth;
				do
				{
					this.Read();
				}
				while (currentDepth < this.CurrentDepth);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000BC58 File Offset: 0x00009E58
		public bool TrySkip()
		{
			if (this._isFinalBlock)
			{
				this.SkipHelper();
				return true;
			}
			Utf8JsonReader utf8JsonReader = this;
			bool flag = this.TrySkipPartial(this.CurrentDepth);
			if (!flag)
			{
				this = utf8JsonReader;
			}
			return flag;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000BC94 File Offset: 0x00009E94
		internal bool TrySkipPartial(int targetDepth)
		{
			if (targetDepth == this.CurrentDepth)
			{
				if (this.TokenType == JsonTokenType.PropertyName && !this.Read())
				{
					return false;
				}
				JsonTokenType tokenType = this.TokenType;
				if (tokenType != JsonTokenType.StartObject && tokenType != JsonTokenType.StartArray)
				{
					return true;
				}
			}
			while (this.Read())
			{
				if (targetDepth >= this.CurrentDepth)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000BCEB File Offset: 0x00009EEB
		public readonly bool ValueTextEquals(ReadOnlySpan<byte> utf8Text)
		{
			if (!Utf8JsonReader.IsTokenTypeString(this.TokenType))
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedStringComparison(this.TokenType);
			}
			return this.TextEqualsHelper(utf8Text);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000BD0C File Offset: 0x00009F0C
		[NullableContext(2)]
		public readonly bool ValueTextEquals(string text)
		{
			return this.ValueTextEquals(text.AsSpan());
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000BD1A File Offset: 0x00009F1A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private readonly bool TextEqualsHelper(ReadOnlySpan<byte> otherUtf8Text)
		{
			if (this.HasValueSequence)
			{
				return this.CompareToSequence(otherUtf8Text);
			}
			if (this.ValueIsEscaped)
			{
				return this.UnescapeAndCompare(otherUtf8Text);
			}
			return otherUtf8Text.SequenceEqual(this.ValueSpan);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000BD48 File Offset: 0x00009F48
		public unsafe readonly bool ValueTextEquals(ReadOnlySpan<char> text)
		{
			if (!Utf8JsonReader.IsTokenTypeString(this.TokenType))
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedStringComparison(this.TokenType);
			}
			if (this.MatchNotPossible(text.Length))
			{
				return false;
			}
			byte[] array = null;
			int num = checked(text.Length * 3);
			Span<byte> destination;
			if (num > 256)
			{
				array = ArrayPool<byte>.Shared.Rent(num);
				destination = array;
			}
			else
			{
				destination = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			int length;
			bool result = JsonWriterHelper.ToUtf8(text, destination, out length) != OperationStatus.InvalidData && this.TextEqualsHelper(destination.Slice(0, length));
			if (array != null)
			{
				destination.Slice(0, length).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BE04 File Offset: 0x0000A004
		private readonly bool CompareToSequence(ReadOnlySpan<byte> other)
		{
			if (this.ValueIsEscaped)
			{
				return this.UnescapeSequenceAndCompare(other);
			}
			ReadOnlySequence<byte> valueSequence = this.ValueSequence;
			if (valueSequence.Length != (long)other.Length)
			{
				return false;
			}
			int num = 0;
			foreach (ReadOnlyMemory<byte> readOnlyMemory in valueSequence)
			{
				ReadOnlySpan<byte> span = readOnlyMemory.Span;
				if (!other.Slice(num).StartsWith(span))
				{
					return false;
				}
				num += span.Length;
			}
			return true;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000BE84 File Offset: 0x0000A084
		private readonly bool UnescapeAndCompare(ReadOnlySpan<byte> other)
		{
			ReadOnlySpan<byte> valueSpan = this.ValueSpan;
			if (valueSpan.Length < other.Length || valueSpan.Length / 6 > other.Length)
			{
				return false;
			}
			int num = valueSpan.IndexOf(92);
			return other.StartsWith(valueSpan.Slice(0, num)) && JsonReaderHelper.UnescapeAndCompare(valueSpan.Slice(num), other.Slice(num));
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		private readonly bool UnescapeSequenceAndCompare(ReadOnlySpan<byte> other)
		{
			ReadOnlySequence<byte> utf8Source = this.ValueSequence;
			long length = utf8Source.Length;
			if (length < (long)other.Length || length / 6L > (long)other.Length)
			{
				return false;
			}
			int num = 0;
			bool result = false;
			foreach (ReadOnlyMemory<byte> readOnlyMemory in utf8Source)
			{
				ReadOnlySpan<byte> span = readOnlyMemory.Span;
				int num2 = span.IndexOf(92);
				if (num2 != -1)
				{
					if (!other.Slice(num).StartsWith(span.Slice(0, num2)))
					{
						break;
					}
					num += num2;
					other = other.Slice(num);
					utf8Source = utf8Source.Slice((long)num);
					if (utf8Source.IsSingleSegment)
					{
						result = JsonReaderHelper.UnescapeAndCompare(utf8Source.First.Span, other);
						break;
					}
					result = JsonReaderHelper.UnescapeAndCompare(utf8Source, other);
					break;
				}
				else
				{
					if (!other.Slice(num).StartsWith(span))
					{
						break;
					}
					num += span.Length;
				}
			}
			return result;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000BFE1 File Offset: 0x0000A1E1
		private static bool IsTokenTypeString(JsonTokenType tokenType)
		{
			return tokenType == JsonTokenType.PropertyName || tokenType == JsonTokenType.String;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private readonly bool MatchNotPossible(int charTextLength)
		{
			if (this.HasValueSequence)
			{
				return this.MatchNotPossibleSequence(charTextLength);
			}
			int length = this.ValueSpan.Length;
			return length < charTextLength || length / (this.ValueIsEscaped ? 6 : 3) > charTextLength;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000C034 File Offset: 0x0000A234
		[MethodImpl(MethodImplOptions.NoInlining)]
		private readonly bool MatchNotPossibleSequence(int charTextLength)
		{
			long length = this.ValueSequence.Length;
			return length < (long)charTextLength || length / (this.ValueIsEscaped ? 6L : 3L) > (long)charTextLength;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000C06C File Offset: 0x0000A26C
		private void StartObject()
		{
			if (this._bitStack.CurrentDepth >= this._readerOptions.MaxDepth)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ObjectDepthTooLarge, 0, default(ReadOnlySpan<byte>));
			}
			this._bitStack.PushTrue();
			this.ValueSpan = this._buffer.Slice(this._consumed, 1);
			this._consumed++;
			this._bytePositionInLine += 1L;
			this._tokenType = JsonTokenType.StartObject;
			this._inObject = true;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		private void EndObject()
		{
			if (!this._inObject || this._bitStack.CurrentDepth <= 0)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.MismatchedObjectArray, 125, default(ReadOnlySpan<byte>));
			}
			if (this._trailingCommaBeforeComment)
			{
				if (!this._readerOptions.AllowTrailingCommas)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
				}
				this._trailingCommaBeforeComment = false;
			}
			this._tokenType = JsonTokenType.EndObject;
			this.ValueSpan = this._buffer.Slice(this._consumed, 1);
			this.UpdateBitStackOnEndToken();
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000C180 File Offset: 0x0000A380
		private void StartArray()
		{
			if (this._bitStack.CurrentDepth >= this._readerOptions.MaxDepth)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ArrayDepthTooLarge, 0, default(ReadOnlySpan<byte>));
			}
			this._bitStack.PushFalse();
			this.ValueSpan = this._buffer.Slice(this._consumed, 1);
			this._consumed++;
			this._bytePositionInLine += 1L;
			this._tokenType = JsonTokenType.StartArray;
			this._inObject = false;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000C204 File Offset: 0x0000A404
		private void EndArray()
		{
			if (this._inObject || this._bitStack.CurrentDepth <= 0)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.MismatchedObjectArray, 93, default(ReadOnlySpan<byte>));
			}
			if (this._trailingCommaBeforeComment)
			{
				if (!this._readerOptions.AllowTrailingCommas)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
				}
				this._trailingCommaBeforeComment = false;
			}
			this._tokenType = JsonTokenType.EndArray;
			this.ValueSpan = this._buffer.Slice(this._consumed, 1);
			this.UpdateBitStackOnEndToken();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000C28D File Offset: 0x0000A48D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UpdateBitStackOnEndToken()
		{
			this._consumed++;
			this._bytePositionInLine += 1L;
			this._inObject = this._bitStack.Pop();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		private unsafe bool ReadSingleSegment()
		{
			bool flag = false;
			this.ValueSpan = default(ReadOnlySpan<byte>);
			this.ValueIsEscaped = false;
			if (this.HasMoreData())
			{
				byte b = *this._buffer[this._consumed];
				if (b <= 32)
				{
					this.SkipWhiteSpace();
					if (!this.HasMoreData())
					{
						return flag;
					}
					b = *this._buffer[this._consumed];
				}
				this.TokenStartIndex = (long)this._consumed;
				if (this._tokenType != JsonTokenType.None)
				{
					if (b == 47)
					{
						flag = this.ConsumeNextTokenOrRollback(b);
					}
					else
					{
						if (this._tokenType == JsonTokenType.StartObject)
						{
							if (b == 125)
							{
								this.EndObject();
							}
							else
							{
								if (b != 34)
								{
									ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
								}
								int consumed = this._consumed;
								long bytePositionInLine = this._bytePositionInLine;
								long lineNumber = this._lineNumber;
								flag = this.ConsumePropertyName();
								if (!flag)
								{
									this._consumed = consumed;
									this._tokenType = JsonTokenType.StartObject;
									this._bytePositionInLine = bytePositionInLine;
									this._lineNumber = lineNumber;
									return flag;
								}
								return flag;
							}
						}
						else if (this._tokenType == JsonTokenType.StartArray)
						{
							if (b != 93)
							{
								return this.ConsumeValue(b);
							}
							this.EndArray();
						}
						else
						{
							if (this._tokenType == JsonTokenType.PropertyName)
							{
								return this.ConsumeValue(b);
							}
							return this.ConsumeNextTokenOrRollback(b);
						}
						flag = true;
					}
				}
				else
				{
					flag = this.ReadFirstToken(b);
				}
			}
			return flag;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000C414 File Offset: 0x0000A614
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HasMoreData()
		{
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this._isNotPrimitive && this.IsLastSpan)
				{
					if (this._bitStack.CurrentDepth != 0)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ZeroDepthAtEnd, 0, default(ReadOnlySpan<byte>));
					}
					if (this._readerOptions.CommentHandling == JsonCommentHandling.Allow && this._tokenType == JsonTokenType.Comment)
					{
						return false;
					}
					JsonTokenType tokenType = this._tokenType;
					if (tokenType != JsonTokenType.EndArray && tokenType != JsonTokenType.EndObject)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidEndOfJsonNonPrimitive, 0, default(ReadOnlySpan<byte>));
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HasMoreData(ExceptionResource resource)
		{
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this.IsLastSpan)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, resource, 0, default(ReadOnlySpan<byte>));
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		private bool ReadFirstToken(byte first)
		{
			if (first == 123)
			{
				this._bitStack.SetFirstBit();
				this._tokenType = JsonTokenType.StartObject;
				this.ValueSpan = this._buffer.Slice(this._consumed, 1);
				this._consumed++;
				this._bytePositionInLine += 1L;
				this._inObject = true;
				this._isNotPrimitive = true;
			}
			else if (first == 91)
			{
				this._bitStack.ResetFirstBit();
				this._tokenType = JsonTokenType.StartArray;
				this.ValueSpan = this._buffer.Slice(this._consumed, 1);
				this._consumed++;
				this._bytePositionInLine += 1L;
				this._isNotPrimitive = true;
			}
			else
			{
				ReadOnlySpan<byte> buffer = this._buffer;
				if (JsonHelpers.IsDigit(first) || first == 45)
				{
					int num;
					if (!this.TryGetNumber(buffer.Slice(this._consumed), out num))
					{
						return false;
					}
					this._tokenType = JsonTokenType.Number;
					this._consumed += num;
					this._bytePositionInLine += (long)num;
				}
				else if (!this.ConsumeValue(first))
				{
					return false;
				}
				JsonTokenType tokenType = this._tokenType;
				bool isNotPrimitive = tokenType == JsonTokenType.StartObject || tokenType == JsonTokenType.StartArray;
				this._isNotPrimitive = isNotPrimitive;
			}
			return true;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000C620 File Offset: 0x0000A820
		private unsafe void SkipWhiteSpace()
		{
			ReadOnlySpan<byte> buffer = this._buffer;
			while (this._consumed < buffer.Length)
			{
				byte b = *buffer[this._consumed];
				if (b != 32 && b != 13 && b != 10 && b != 9)
				{
					break;
				}
				if (b == 10)
				{
					this._lineNumber += 1L;
					this._bytePositionInLine = 0L;
				}
				else
				{
					this._bytePositionInLine += 1L;
				}
				this._consumed++;
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		private unsafe bool ConsumeValue(byte marker)
		{
			for (;;)
			{
				this._trailingCommaBeforeComment = false;
				if (marker == 34)
				{
					break;
				}
				if (marker == 123)
				{
					goto Block_1;
				}
				if (marker == 91)
				{
					goto Block_2;
				}
				if (JsonHelpers.IsDigit(marker) || marker == 45)
				{
					goto IL_40;
				}
				if (marker == 102)
				{
					goto Block_4;
				}
				if (marker == 116)
				{
					goto Block_5;
				}
				if (marker == 110)
				{
					goto Block_6;
				}
				JsonCommentHandling commentHandling = this._readerOptions.CommentHandling;
				if (commentHandling == JsonCommentHandling.Disallow)
				{
					goto IL_154;
				}
				if (commentHandling == JsonCommentHandling.Allow)
				{
					goto Block_8;
				}
				if (marker != 47)
				{
					goto IL_154;
				}
				if (!this.SkipComment())
				{
					return false;
				}
				if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
				{
					goto Block_12;
				}
				marker = *this._buffer[this._consumed];
				if (marker <= 32)
				{
					this.SkipWhiteSpace();
					if (!this.HasMoreData())
					{
						return false;
					}
					marker = *this._buffer[this._consumed];
				}
				this.TokenStartIndex = (long)this._consumed;
			}
			return this.ConsumeString();
			Block_1:
			this.StartObject();
			return true;
			Block_2:
			this.StartArray();
			return true;
			IL_40:
			return this.ConsumeNumber();
			Block_4:
			return this.ConsumeLiteral(JsonConstants.FalseValue, JsonTokenType.False);
			Block_5:
			return this.ConsumeLiteral(JsonConstants.TrueValue, JsonTokenType.True);
			Block_6:
			return this.ConsumeLiteral(JsonConstants.NullValue, JsonTokenType.Null);
			Block_8:
			if (marker == 47)
			{
				return this.ConsumeComment();
			}
			goto IL_154;
			Block_12:
			if (this._isNotPrimitive && this.IsLastSpan && this._tokenType != JsonTokenType.EndArray && this._tokenType != JsonTokenType.EndObject)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidEndOfJsonNonPrimitive, 0, default(ReadOnlySpan<byte>));
			}
			return false;
			IL_154:
			ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfValueNotFound, marker, default(ReadOnlySpan<byte>));
			return true;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000C818 File Offset: 0x0000AA18
		private bool ConsumeLiteral(ReadOnlySpan<byte> literal, JsonTokenType tokenType)
		{
			ReadOnlySpan<byte> span = this._buffer.Slice(this._consumed);
			if (!span.StartsWith(literal))
			{
				return this.CheckLiteral(span, literal);
			}
			this.ValueSpan = span.Slice(0, literal.Length);
			this._tokenType = tokenType;
			this._consumed += literal.Length;
			this._bytePositionInLine += (long)literal.Length;
			return true;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000C890 File Offset: 0x0000AA90
		private unsafe bool CheckLiteral(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal)
		{
			int num = 0;
			for (int i = 1; i < literal.Length; i++)
			{
				if (span.Length <= i)
				{
					num = i;
					break;
				}
				if (*span[i] != *literal[i])
				{
					this._bytePositionInLine += (long)i;
					this.ThrowInvalidLiteral(span);
				}
			}
			if (this.IsLastSpan)
			{
				this._bytePositionInLine += (long)num;
				this.ThrowInvalidLiteral(span);
			}
			return false;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000C90C File Offset: 0x0000AB0C
		private unsafe void ThrowInvalidLiteral(ReadOnlySpan<byte> span)
		{
			byte b = *span[0];
			ExceptionResource resource;
			if (b != 102)
			{
				if (b == 116)
				{
					resource = ExceptionResource.ExpectedTrue;
				}
				else
				{
					resource = ExceptionResource.ExpectedNull;
				}
			}
			else
			{
				resource = ExceptionResource.ExpectedFalse;
			}
			ThrowHelper.ThrowJsonReaderException(ref this, resource, 0, span);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000C944 File Offset: 0x0000AB44
		private unsafe bool ConsumeNumber()
		{
			int num;
			if (!this.TryGetNumber(this._buffer.Slice(this._consumed), out num))
			{
				return false;
			}
			this._tokenType = JsonTokenType.Number;
			this._consumed += num;
			this._bytePositionInLine += (long)num;
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length) && this._isNotPrimitive)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, *this._buffer[this._consumed - 1], default(ReadOnlySpan<byte>));
			}
			return true;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		private unsafe bool ConsumePropertyName()
		{
			this._trailingCommaBeforeComment = false;
			if (!this.ConsumeString())
			{
				return false;
			}
			if (!this.HasMoreData(ExceptionResource.ExpectedValueAfterPropertyNameNotFound))
			{
				return false;
			}
			byte b = *this._buffer[this._consumed];
			if (b <= 32)
			{
				this.SkipWhiteSpace();
				if (!this.HasMoreData(ExceptionResource.ExpectedValueAfterPropertyNameNotFound))
				{
					return false;
				}
				b = *this._buffer[this._consumed];
			}
			if (b != 58)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedSeparatorAfterPropertyNameNotFound, b, default(ReadOnlySpan<byte>));
			}
			this._consumed++;
			this._bytePositionInLine += 1L;
			this._tokenType = JsonTokenType.PropertyName;
			return true;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000CA78 File Offset: 0x0000AC78
		private unsafe bool ConsumeString()
		{
			ReadOnlySpan<byte> readOnlySpan = this._buffer.Slice(this._consumed + 1);
			int num = readOnlySpan.IndexOfQuoteOrAnyControlOrBackSlash();
			if (num < 0)
			{
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)(readOnlySpan.Length + 1);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
				}
				return false;
			}
			if (*readOnlySpan[num] == 34)
			{
				this._bytePositionInLine += (long)(num + 2);
				this.ValueSpan = readOnlySpan.Slice(0, num);
				this.ValueIsEscaped = false;
				this._tokenType = JsonTokenType.String;
				this._consumed += num + 2;
				return true;
			}
			return this.ConsumeStringAndValidate(readOnlySpan, num);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		private unsafe bool ConsumeStringAndValidate(ReadOnlySpan<byte> data, int idx)
		{
			long bytePositionInLine = this._bytePositionInLine;
			long lineNumber = this._lineNumber;
			this._bytePositionInLine += (long)(idx + 1);
			bool flag = false;
			while (idx < data.Length)
			{
				byte b = *data[idx];
				if (b == 34)
				{
					if (!flag)
					{
						IL_112:
						this._bytePositionInLine += 1L;
						this.ValueSpan = data.Slice(0, idx);
						this.ValueIsEscaped = true;
						this._tokenType = JsonTokenType.String;
						this._consumed += idx + 2;
						return true;
					}
					flag = false;
				}
				else if (b == 92)
				{
					flag = !flag;
				}
				else if (flag)
				{
					if (JsonConstants.EscapableChars.IndexOf(b) == -1)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterAfterEscapeWithinString, b, default(ReadOnlySpan<byte>));
					}
					if (b == 117)
					{
						this._bytePositionInLine += 1L;
						if (!this.ValidateHexDigits(data, idx + 1))
						{
							idx = data.Length;
							break;
						}
						idx += 4;
					}
					flag = false;
				}
				else if (b < 32)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterWithinString, b, default(ReadOnlySpan<byte>));
				}
				this._bytePositionInLine += 1L;
				idx++;
			}
			if (idx >= data.Length)
			{
				if (this.IsLastSpan)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
				}
				this._lineNumber = lineNumber;
				this._bytePositionInLine = bytePositionInLine;
				return false;
			}
			goto IL_112;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000CC88 File Offset: 0x0000AE88
		private unsafe bool ValidateHexDigits(ReadOnlySpan<byte> data, int idx)
		{
			for (int i = idx; i < data.Length; i++)
			{
				byte nextByte = *data[i];
				if (!JsonReaderHelper.IsHexDigit(nextByte))
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidHexCharacterWithinString, nextByte, default(ReadOnlySpan<byte>));
				}
				if (i - idx >= 3)
				{
					return true;
				}
				this._bytePositionInLine += 1L;
			}
			return false;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		private unsafe bool TryGetNumber(ReadOnlySpan<byte> data, out int consumed)
		{
			consumed = 0;
			int num = 0;
			if (this.ConsumeNegativeSign(ref data, ref num) == ConsumeNumberResult.NeedMoreData)
			{
				return false;
			}
			byte b = *data[num];
			if (b == 48)
			{
				ConsumeNumberResult consumeNumberResult = this.ConsumeZero(ref data, ref num);
				if (consumeNumberResult == ConsumeNumberResult.NeedMoreData)
				{
					return false;
				}
				if (consumeNumberResult == ConsumeNumberResult.Success)
				{
					goto IL_14B;
				}
				b = *data[num];
			}
			else
			{
				num++;
				ConsumeNumberResult consumeNumberResult2 = this.ConsumeIntegerDigits(ref data, ref num);
				if (consumeNumberResult2 == ConsumeNumberResult.NeedMoreData)
				{
					return false;
				}
				if (consumeNumberResult2 == ConsumeNumberResult.Success)
				{
					goto IL_14B;
				}
				b = *data[num];
				if (b != 46 && b != 69 && b != 101)
				{
					this._bytePositionInLine += (long)num;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, b, default(ReadOnlySpan<byte>));
				}
			}
			if (b == 46)
			{
				num++;
				ConsumeNumberResult consumeNumberResult3 = this.ConsumeDecimalDigits(ref data, ref num);
				if (consumeNumberResult3 == ConsumeNumberResult.NeedMoreData)
				{
					return false;
				}
				if (consumeNumberResult3 == ConsumeNumberResult.Success)
				{
					goto IL_14B;
				}
				b = *data[num];
				if (b != 69 && b != 101)
				{
					this._bytePositionInLine += (long)num;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedNextDigitEValueNotFound, b, default(ReadOnlySpan<byte>));
				}
			}
			num++;
			if (this.ConsumeSign(ref data, ref num) == ConsumeNumberResult.NeedMoreData)
			{
				return false;
			}
			num++;
			ConsumeNumberResult consumeNumberResult4 = this.ConsumeIntegerDigits(ref data, ref num);
			if (consumeNumberResult4 == ConsumeNumberResult.NeedMoreData)
			{
				return false;
			}
			if (consumeNumberResult4 != ConsumeNumberResult.Success)
			{
				this._bytePositionInLine += (long)num;
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, *data[num], default(ReadOnlySpan<byte>));
			}
			IL_14B:
			this.ValueSpan = data.Slice(0, num);
			consumed = num;
			return true;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000CE50 File Offset: 0x0000B050
		private unsafe ConsumeNumberResult ConsumeNegativeSign(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			byte b = *data[i];
			if (b == 45)
			{
				i++;
				if (i >= data.Length)
				{
					if (this.IsLastSpan)
					{
						this._bytePositionInLine += (long)i;
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					return ConsumeNumberResult.NeedMoreData;
				}
				b = *data[i];
				if (!JsonHelpers.IsDigit(b))
				{
					this._bytePositionInLine += (long)i;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterSign, b, default(ReadOnlySpan<byte>));
				}
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000CEDC File Offset: 0x0000B0DC
		private unsafe ConsumeNumberResult ConsumeZero(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			i++;
			if (i < data.Length)
			{
				byte b = *data[i];
				if (JsonConstants.Delimiters.IndexOf(b) >= 0)
				{
					return ConsumeNumberResult.Success;
				}
				b = *data[i];
				if (b != 46 && b != 69 && b != 101)
				{
					this._bytePositionInLine += (long)i;
					ThrowHelper.ThrowJsonReaderException(ref this, JsonHelpers.IsInRangeInclusive((int)b, 48, 57) ? ExceptionResource.InvalidLeadingZeroInNumber : ExceptionResource.ExpectedEndOfDigitNotFound, b, default(ReadOnlySpan<byte>));
				}
				return ConsumeNumberResult.OperationIncomplete;
			}
			else
			{
				if (this.IsLastSpan)
				{
					return ConsumeNumberResult.Success;
				}
				return ConsumeNumberResult.NeedMoreData;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000CF6C File Offset: 0x0000B16C
		private unsafe ConsumeNumberResult ConsumeIntegerDigits(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			byte value = 0;
			while (i < data.Length)
			{
				value = *data[i];
				if (!JsonHelpers.IsDigit(value))
				{
					break;
				}
				i++;
			}
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					return ConsumeNumberResult.Success;
				}
				return ConsumeNumberResult.NeedMoreData;
			}
			else
			{
				if (JsonConstants.Delimiters.IndexOf(value) >= 0)
				{
					return ConsumeNumberResult.Success;
				}
				return ConsumeNumberResult.OperationIncomplete;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		private unsafe ConsumeNumberResult ConsumeDecimalDigits(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)i;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
				}
				return ConsumeNumberResult.NeedMoreData;
			}
			byte b = *data[i];
			if (!JsonHelpers.IsDigit(b))
			{
				this._bytePositionInLine += (long)i;
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterDecimal, b, default(ReadOnlySpan<byte>));
			}
			i++;
			return this.ConsumeIntegerDigits(ref data, ref i);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000D04C File Offset: 0x0000B24C
		private unsafe ConsumeNumberResult ConsumeSign(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)i;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
				}
				return ConsumeNumberResult.NeedMoreData;
			}
			byte b = *data[i];
			if (b == 43 || b == 45)
			{
				i++;
				if (i >= data.Length)
				{
					if (this.IsLastSpan)
					{
						this._bytePositionInLine += (long)i;
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					return ConsumeNumberResult.NeedMoreData;
				}
				b = *data[i];
			}
			if (!JsonHelpers.IsDigit(b))
			{
				this._bytePositionInLine += (long)i;
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterSign, b, default(ReadOnlySpan<byte>));
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000D114 File Offset: 0x0000B314
		private bool ConsumeNextTokenOrRollback(byte marker)
		{
			int consumed = this._consumed;
			long bytePositionInLine = this._bytePositionInLine;
			long lineNumber = this._lineNumber;
			JsonTokenType tokenType = this._tokenType;
			bool trailingCommaBeforeComment = this._trailingCommaBeforeComment;
			ConsumeTokenResult consumeTokenResult = this.ConsumeNextToken(marker);
			if (consumeTokenResult == ConsumeTokenResult.Success)
			{
				return true;
			}
			if (consumeTokenResult == ConsumeTokenResult.NotEnoughDataRollBackState)
			{
				this._consumed = consumed;
				this._tokenType = tokenType;
				this._bytePositionInLine = bytePositionInLine;
				this._lineNumber = lineNumber;
				this._trailingCommaBeforeComment = trailingCommaBeforeComment;
			}
			return false;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000D180 File Offset: 0x0000B380
		private unsafe ConsumeTokenResult ConsumeNextToken(byte marker)
		{
			if (this._readerOptions.CommentHandling != JsonCommentHandling.Disallow)
			{
				if (this._readerOptions.CommentHandling != JsonCommentHandling.Allow)
				{
					return this.ConsumeNextTokenUntilAfterAllCommentsAreSkipped(marker);
				}
				if (marker == 47)
				{
					if (!this.ConsumeComment())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					return ConsumeTokenResult.Success;
				}
				else if (this._tokenType == JsonTokenType.Comment)
				{
					return this.ConsumeNextTokenFromLastNonCommentToken();
				}
			}
			if (this._bitStack.CurrentDepth == 0)
			{
				if (this._readerOptions.AllowMultipleValues)
				{
					if (!this.ReadFirstToken(marker))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					return ConsumeTokenResult.Success;
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, marker, default(ReadOnlySpan<byte>));
				}
			}
			if (marker != 44)
			{
				if (marker == 125)
				{
					this.EndObject();
				}
				else if (marker == 93)
				{
					this.EndArray();
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.FoundInvalidCharacter, marker, default(ReadOnlySpan<byte>));
				}
				return ConsumeTokenResult.Success;
			}
			this._consumed++;
			this._bytePositionInLine += 1L;
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this.IsLastSpan)
				{
					this._consumed--;
					this._bytePositionInLine -= 1L;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
				}
				return ConsumeTokenResult.NotEnoughDataRollBackState;
			}
			byte b = *this._buffer[this._consumed];
			if (b <= 32)
			{
				this.SkipWhiteSpace();
				if (!this.HasMoreData(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				b = *this._buffer[this._consumed];
			}
			this.TokenStartIndex = (long)this._consumed;
			if (this._readerOptions.CommentHandling == JsonCommentHandling.Allow && b == 47)
			{
				this._trailingCommaBeforeComment = true;
				if (!this.ConsumeComment())
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			else if (this._inObject)
			{
				if (b != 34)
				{
					if (b == 125)
					{
						if (this._readerOptions.AllowTrailingCommas)
						{
							this.EndObject();
							return ConsumeTokenResult.Success;
						}
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
					}
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
				}
				if (!this.ConsumePropertyName())
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			else
			{
				if (b == 93)
				{
					if (this._readerOptions.AllowTrailingCommas)
					{
						this.EndArray();
						return ConsumeTokenResult.Success;
					}
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.ConsumeValue(b))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		private unsafe ConsumeTokenResult ConsumeNextTokenFromLastNonCommentToken()
		{
			if (JsonReaderHelper.IsTokenTypePrimitive(this._previousTokenType))
			{
				this._tokenType = (this._inObject ? JsonTokenType.StartObject : JsonTokenType.StartArray);
			}
			else
			{
				this._tokenType = this._previousTokenType;
			}
			if (this.HasMoreData())
			{
				byte b = *this._buffer[this._consumed];
				if (b <= 32)
				{
					this.SkipWhiteSpace();
					if (!this.HasMoreData())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					b = *this._buffer[this._consumed];
				}
				if (this._bitStack.CurrentDepth == 0 && this._tokenType != JsonTokenType.None)
				{
					if (this._readerOptions.AllowMultipleValues)
					{
						if (!this.ReadFirstToken(b))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, b, default(ReadOnlySpan<byte>));
					}
				}
				this.TokenStartIndex = (long)this._consumed;
				if (b == 44)
				{
					if (this._previousTokenType <= JsonTokenType.StartObject || this._previousTokenType == JsonTokenType.StartArray || this._trailingCommaBeforeComment)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueAfterComment, b, default(ReadOnlySpan<byte>));
					}
					this._consumed++;
					this._bytePositionInLine += 1L;
					if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
					{
						if (this.IsLastSpan)
						{
							this._consumed--;
							this._bytePositionInLine -= 1L;
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					else
					{
						b = *this._buffer[this._consumed];
						if (b <= 32)
						{
							this.SkipWhiteSpace();
							if (!this.HasMoreData(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
							{
								return ConsumeTokenResult.NotEnoughDataRollBackState;
							}
							b = *this._buffer[this._consumed];
						}
						this.TokenStartIndex = (long)this._consumed;
						if (b == 47)
						{
							this._trailingCommaBeforeComment = true;
							if (!this.ConsumeComment())
							{
								return ConsumeTokenResult.NotEnoughDataRollBackState;
							}
						}
						else if (this._inObject)
						{
							if (b != 34)
							{
								if (b == 125)
								{
									if (this._readerOptions.AllowTrailingCommas)
									{
										this.EndObject();
										return ConsumeTokenResult.Success;
									}
									ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
								}
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
							}
							if (!this.ConsumePropertyName())
							{
								return ConsumeTokenResult.NotEnoughDataRollBackState;
							}
						}
						else
						{
							if (b == 93)
							{
								if (this._readerOptions.AllowTrailingCommas)
								{
									this.EndArray();
									return ConsumeTokenResult.Success;
								}
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
							}
							if (!this.ConsumeValue(b))
							{
								return ConsumeTokenResult.NotEnoughDataRollBackState;
							}
						}
					}
				}
				else if (b == 125)
				{
					this.EndObject();
				}
				else if (b == 93)
				{
					this.EndArray();
				}
				else if (this._tokenType == JsonTokenType.None)
				{
					if (!this.ReadFirstToken(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.StartObject)
				{
					if (b != 34)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
					}
					int consumed = this._consumed;
					long bytePositionInLine = this._bytePositionInLine;
					long lineNumber = this._lineNumber;
					if (!this.ConsumePropertyName())
					{
						this._consumed = consumed;
						this._tokenType = JsonTokenType.StartObject;
						this._bytePositionInLine = bytePositionInLine;
						this._lineNumber = lineNumber;
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.StartArray)
				{
					if (!this.ConsumeValue(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.PropertyName)
				{
					if (!this.ConsumeValue(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._inObject)
				{
					if (b != 34)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
					}
					if (!this.ConsumePropertyName())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (!this.ConsumeValue(b))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			return ConsumeTokenResult.NotEnoughDataRollBackState;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000D718 File Offset: 0x0000B918
		private unsafe bool SkipAllComments([ScopedRef] ref byte marker)
		{
			while (marker == 47)
			{
				if (this.SkipComment() && this.HasMoreData())
				{
					marker = *this._buffer[this._consumed];
					if (marker > 32)
					{
						continue;
					}
					this.SkipWhiteSpace();
					if (this.HasMoreData())
					{
						marker = *this._buffer[this._consumed];
						continue;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000D77C File Offset: 0x0000B97C
		private unsafe bool SkipAllComments([ScopedRef] ref byte marker, ExceptionResource resource)
		{
			while (marker == 47)
			{
				if (this.SkipComment() && this.HasMoreData(resource))
				{
					marker = *this._buffer[this._consumed];
					if (marker > 32)
					{
						continue;
					}
					this.SkipWhiteSpace();
					if (this.HasMoreData(resource))
					{
						marker = *this._buffer[this._consumed];
						continue;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		private unsafe ConsumeTokenResult ConsumeNextTokenUntilAfterAllCommentsAreSkipped(byte marker)
		{
			if (this.SkipAllComments(ref marker))
			{
				this.TokenStartIndex = (long)this._consumed;
				if (this._tokenType == JsonTokenType.StartObject)
				{
					if (marker == 125)
					{
						this.EndObject();
					}
					else
					{
						if (marker != 34)
						{
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, marker, default(ReadOnlySpan<byte>));
						}
						int consumed = this._consumed;
						long bytePositionInLine = this._bytePositionInLine;
						long lineNumber = this._lineNumber;
						if (!this.ConsumePropertyName())
						{
							this._consumed = consumed;
							this._tokenType = JsonTokenType.StartObject;
							this._bytePositionInLine = bytePositionInLine;
							this._lineNumber = lineNumber;
							return ConsumeTokenResult.IncompleteNoRollBackNecessary;
						}
					}
				}
				else if (this._tokenType == JsonTokenType.StartArray)
				{
					if (marker == 93)
					{
						this.EndArray();
					}
					else if (!this.ConsumeValue(marker))
					{
						return ConsumeTokenResult.IncompleteNoRollBackNecessary;
					}
				}
				else if (this._tokenType == JsonTokenType.PropertyName)
				{
					if (!this.ConsumeValue(marker))
					{
						return ConsumeTokenResult.IncompleteNoRollBackNecessary;
					}
				}
				else if (this._bitStack.CurrentDepth == 0)
				{
					if (this._readerOptions.AllowMultipleValues)
					{
						if (!this.ReadFirstToken(marker))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, marker, default(ReadOnlySpan<byte>));
					}
				}
				else if (marker == 44)
				{
					this._consumed++;
					this._bytePositionInLine += 1L;
					if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
					{
						if (this.IsLastSpan)
						{
							this._consumed--;
							this._bytePositionInLine -= 1L;
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
						}
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					marker = *this._buffer[this._consumed];
					if (marker <= 32)
					{
						this.SkipWhiteSpace();
						if (!this.HasMoreData(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						marker = *this._buffer[this._consumed];
					}
					if (!this.SkipAllComments(ref marker, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					this.TokenStartIndex = (long)this._consumed;
					if (this._inObject)
					{
						if (marker != 34)
						{
							if (marker == 125)
							{
								if (this._readerOptions.AllowTrailingCommas)
								{
									this.EndObject();
									return ConsumeTokenResult.Success;
								}
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, marker, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumePropertyName())
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						if (marker == 93)
						{
							if (this._readerOptions.AllowTrailingCommas)
							{
								this.EndArray();
								return ConsumeTokenResult.Success;
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumeValue(marker))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
				}
				else if (marker == 125)
				{
					this.EndObject();
				}
				else if (marker == 93)
				{
					this.EndArray();
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.FoundInvalidCharacter, marker, default(ReadOnlySpan<byte>));
				}
				return ConsumeTokenResult.Success;
			}
			return ConsumeTokenResult.IncompleteNoRollBackNecessary;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000DA90 File Offset: 0x0000BC90
		private unsafe bool SkipComment()
		{
			ReadOnlySpan<byte> readOnlySpan = this._buffer.Slice(this._consumed + 1);
			if (readOnlySpan.Length > 0)
			{
				byte b = *readOnlySpan[0];
				if (b == 47)
				{
					int num;
					return this.SkipSingleLineComment(readOnlySpan.Slice(1), out num);
				}
				if (b == 42)
				{
					int num;
					return this.SkipMultiLineComment(readOnlySpan.Slice(1), out num);
				}
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfValueNotFound, 47, default(ReadOnlySpan<byte>));
			}
			if (this.IsLastSpan)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfValueNotFound, 47, default(ReadOnlySpan<byte>));
			}
			return false;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000DB20 File Offset: 0x0000BD20
		private unsafe bool SkipSingleLineComment(ReadOnlySpan<byte> localBuffer, out int idx)
		{
			idx = this.FindLineSeparator(localBuffer);
			int num;
			if (idx != -1)
			{
				num = idx;
				if (*localBuffer[idx] != 10)
				{
					if (idx < localBuffer.Length - 1)
					{
						if (*localBuffer[idx + 1] == 10)
						{
							num++;
						}
					}
					else if (!this.IsLastSpan)
					{
						return false;
					}
				}
				num++;
				this._bytePositionInLine = 0L;
				this._lineNumber += 1L;
			}
			else
			{
				if (!this.IsLastSpan)
				{
					return false;
				}
				idx = localBuffer.Length;
				num = idx;
				this._bytePositionInLine += (long)(2 + localBuffer.Length);
			}
			this._consumed += 2 + num;
			return true;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		private unsafe int FindLineSeparator(ReadOnlySpan<byte> localBuffer)
		{
			int num = 0;
			for (;;)
			{
				int num2 = localBuffer.IndexOfAny(10, 13, 226);
				if (num2 == -1)
				{
					break;
				}
				num += num2;
				if (*localBuffer[num2] != 226)
				{
					return num;
				}
				num++;
				localBuffer = localBuffer.Slice(num2 + 1);
				this.ThrowOnDangerousLineSeparator(localBuffer);
			}
			return -1;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000DC28 File Offset: 0x0000BE28
		private unsafe void ThrowOnDangerousLineSeparator(ReadOnlySpan<byte> localBuffer)
		{
			if (localBuffer.Length < 2)
			{
				return;
			}
			byte b = *localBuffer[1];
			if (*localBuffer[0] == 128 && (b == 168 || b == 169))
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfLineSeparator, 0, default(ReadOnlySpan<byte>));
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		private unsafe bool SkipMultiLineComment(ReadOnlySpan<byte> localBuffer, out int idx)
		{
			idx = 0;
			int num;
			for (;;)
			{
				num = localBuffer.Slice(idx).IndexOf(47);
				if (num == -1)
				{
					break;
				}
				if (num != 0 && *localBuffer[num + idx - 1] == 42)
				{
					goto Block_4;
				}
				idx += num + 1;
			}
			if (this.IsLastSpan)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfCommentNotFound, 0, default(ReadOnlySpan<byte>));
			}
			return false;
			Block_4:
			idx += num - 1;
			this._consumed += 4 + idx;
			ValueTuple<int, int> valueTuple = JsonReaderHelper.CountNewLines(localBuffer.Slice(0, idx));
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			this._lineNumber += (long)item;
			if (item2 != -1)
			{
				this._bytePositionInLine = (long)(idx - item2 + 1);
			}
			else
			{
				this._bytePositionInLine += (long)(4 + idx);
			}
			return true;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000DD48 File Offset: 0x0000BF48
		private unsafe bool ConsumeComment()
		{
			ReadOnlySpan<byte> readOnlySpan = this._buffer.Slice(this._consumed + 1);
			if (readOnlySpan.Length > 0)
			{
				byte b = *readOnlySpan[0];
				if (b == 47)
				{
					return this.ConsumeSingleLineComment(readOnlySpan.Slice(1), this._consumed);
				}
				if (b == 42)
				{
					return this.ConsumeMultiLineComment(readOnlySpan.Slice(1), this._consumed);
				}
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterAtStartOfComment, b, default(ReadOnlySpan<byte>));
			}
			if (this.IsLastSpan)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
			}
			return false;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		private bool ConsumeSingleLineComment(ReadOnlySpan<byte> localBuffer, int previousConsumed)
		{
			int length;
			if (!this.SkipSingleLineComment(localBuffer, out length))
			{
				return false;
			}
			this.ValueSpan = this._buffer.Slice(previousConsumed + 2, length);
			if (this._tokenType != JsonTokenType.Comment)
			{
				this._previousTokenType = this._tokenType;
			}
			this._tokenType = JsonTokenType.Comment;
			return true;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000DE2C File Offset: 0x0000C02C
		private bool ConsumeMultiLineComment(ReadOnlySpan<byte> localBuffer, int previousConsumed)
		{
			int length;
			if (!this.SkipMultiLineComment(localBuffer, out length))
			{
				return false;
			}
			this.ValueSpan = this._buffer.Slice(previousConsumed + 2, length);
			if (this._tokenType != JsonTokenType.Comment)
			{
				this._previousTokenType = this._tokenType;
			}
			this._tokenType = JsonTokenType.Comment;
			return true;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
				defaultInterpolatedStringHandler.AppendLiteral("TokenType = ");
				defaultInterpolatedStringHandler.AppendFormatted(this.DebugTokenType);
				defaultInterpolatedStringHandler.AppendLiteral(", TokenStartIndex = ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.TokenStartIndex);
				defaultInterpolatedStringHandler.AppendLiteral(", Consumed = ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BytesConsumed);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		[Nullable(1)]
		private string DebugTokenType
		{
			get
			{
				string result;
				switch (this.TokenType)
				{
				case JsonTokenType.None:
					result = "None";
					break;
				case JsonTokenType.StartObject:
					result = "StartObject";
					break;
				case JsonTokenType.EndObject:
					result = "EndObject";
					break;
				case JsonTokenType.StartArray:
					result = "StartArray";
					break;
				case JsonTokenType.EndArray:
					result = "EndArray";
					break;
				case JsonTokenType.PropertyName:
					result = "PropertyName";
					break;
				case JsonTokenType.Comment:
					result = "Comment";
					break;
				case JsonTokenType.String:
					result = "String";
					break;
				case JsonTokenType.Number:
					result = "Number";
					break;
				case JsonTokenType.True:
					result = "True";
					break;
				case JsonTokenType.False:
					result = "False";
					break;
				case JsonTokenType.Null:
					result = "Null";
					break;
				default:
					result = ((byte)this.TokenType).ToString();
					break;
				}
				return result;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		private ReadOnlySpan<byte> GetUnescapedSpan()
		{
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			if (this.ValueIsEscaped)
			{
				readOnlySpan2 = JsonReaderHelper.GetUnescapedSpan(readOnlySpan2);
			}
			return readOnlySpan2;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		public Utf8JsonReader(ReadOnlySequence<byte> jsonData, bool isFinalBlock, JsonReaderState state)
		{
			ReadOnlyMemory<byte> first = jsonData.First;
			this._buffer = first.Span;
			this._isFinalBlock = isFinalBlock;
			this._isInputSequence = true;
			this._lineNumber = state._lineNumber;
			this._bytePositionInLine = state._bytePositionInLine;
			this._inObject = state._inObject;
			this._isNotPrimitive = state._isNotPrimitive;
			this.ValueIsEscaped = state._valueIsEscaped;
			this._trailingCommaBeforeComment = state._trailingCommaBeforeComment;
			this._tokenType = state._tokenType;
			this._previousTokenType = state._previousTokenType;
			this._readerOptions = state._readerOptions;
			if (this._readerOptions.MaxDepth == 0)
			{
				this._readerOptions.MaxDepth = 64;
			}
			this._bitStack = state._bitStack;
			this._consumed = 0;
			this.TokenStartIndex = 0L;
			this._totalConsumed = 0L;
			this.ValueSpan = ReadOnlySpan<byte>.Empty;
			this._sequence = jsonData;
			this.HasValueSequence = false;
			this.ValueSequence = ReadOnlySequence<byte>.Empty;
			if (jsonData.IsSingleSegment)
			{
				this._nextPosition = default(SequencePosition);
				this._currentPosition = jsonData.Start;
				this._isLastSegment = isFinalBlock;
				this._isMultiSegment = false;
				return;
			}
			this._currentPosition = jsonData.Start;
			this._nextPosition = this._currentPosition;
			bool flag = this._buffer.Length == 0;
			if (flag)
			{
				SequencePosition nextPosition = this._nextPosition;
				ReadOnlyMemory<byte> readOnlyMemory;
				while (jsonData.TryGet(ref this._nextPosition, out readOnlyMemory, true))
				{
					this._currentPosition = nextPosition;
					if (readOnlyMemory.Length != 0)
					{
						this._buffer = readOnlyMemory.Span;
						break;
					}
					nextPosition = this._nextPosition;
				}
			}
			this._isLastSegment = (!jsonData.TryGet(ref this._nextPosition, out first, !flag) && isFinalBlock);
			this._isMultiSegment = true;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E1A3 File Offset: 0x0000C3A3
		public Utf8JsonReader(ReadOnlySequence<byte> jsonData, JsonReaderOptions options = default(JsonReaderOptions))
		{
			this = new Utf8JsonReader(jsonData, true, new JsonReaderState(options));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		private unsafe bool ReadMultiSegment()
		{
			bool flag = false;
			this.HasValueSequence = false;
			this.ValueIsEscaped = false;
			this.ValueSpan = default(ReadOnlySpan<byte>);
			this.ValueSequence = default(ReadOnlySequence<byte>);
			if (this.HasMoreDataMultiSegment())
			{
				byte b = *this._buffer[this._consumed];
				if (b <= 32)
				{
					this.SkipWhiteSpaceMultiSegment();
					if (!this.HasMoreDataMultiSegment())
					{
						return flag;
					}
					b = *this._buffer[this._consumed];
				}
				this.TokenStartIndex = this.BytesConsumed;
				if (this._tokenType != JsonTokenType.None)
				{
					if (b == 47)
					{
						flag = this.ConsumeNextTokenOrRollbackMultiSegment(b);
					}
					else
					{
						if (this._tokenType == JsonTokenType.StartObject)
						{
							if (b == 125)
							{
								this.EndObject();
							}
							else
							{
								if (b != 34)
								{
									ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
								}
								long totalConsumed = this._totalConsumed;
								int consumed = this._consumed;
								long bytePositionInLine = this._bytePositionInLine;
								long lineNumber = this._lineNumber;
								SequencePosition currentPosition = this._currentPosition;
								flag = this.ConsumePropertyNameMultiSegment();
								if (!flag)
								{
									this._consumed = consumed;
									this._tokenType = JsonTokenType.StartObject;
									this._bytePositionInLine = bytePositionInLine;
									this._lineNumber = lineNumber;
									this._totalConsumed = totalConsumed;
									this._currentPosition = currentPosition;
									return flag;
								}
								return flag;
							}
						}
						else if (this._tokenType == JsonTokenType.StartArray)
						{
							if (b != 93)
							{
								return this.ConsumeValueMultiSegment(b);
							}
							this.EndArray();
						}
						else
						{
							if (this._tokenType == JsonTokenType.PropertyName)
							{
								return this.ConsumeValueMultiSegment(b);
							}
							return this.ConsumeNextTokenOrRollbackMultiSegment(b);
						}
						flag = true;
					}
				}
				else
				{
					flag = this.ReadFirstTokenMultiSegment(b);
				}
			}
			return flag;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000E340 File Offset: 0x0000C540
		private bool ValidateStateAtEndOfData()
		{
			if (this._bitStack.CurrentDepth != 0)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ZeroDepthAtEnd, 0, default(ReadOnlySpan<byte>));
			}
			if (this._readerOptions.CommentHandling == JsonCommentHandling.Allow && this._tokenType == JsonTokenType.Comment)
			{
				return false;
			}
			if (this._tokenType != JsonTokenType.EndArray && this._tokenType != JsonTokenType.EndObject)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidEndOfJsonNonPrimitive, 0, default(ReadOnlySpan<byte>));
			}
			return true;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HasMoreDataMultiSegment()
		{
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this._isNotPrimitive && this.IsLastSpan && !this.ValidateStateAtEndOfData())
				{
					return false;
				}
				if (!this.GetNextSpan())
				{
					if (this._isNotPrimitive && this.IsLastSpan)
					{
						this.ValidateStateAtEndOfData();
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E40C File Offset: 0x0000C60C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HasMoreDataMultiSegment(ExceptionResource resource)
		{
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this.IsLastSpan)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, resource, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, resource, 0, default(ReadOnlySpan<byte>));
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000E46C File Offset: 0x0000C66C
		private bool GetNextSpan()
		{
			SequencePosition currentPosition;
			ReadOnlyMemory<byte> readOnlyMemory;
			for (;;)
			{
				currentPosition = this._currentPosition;
				this._currentPosition = this._nextPosition;
				if (!this._sequence.TryGet(ref this._nextPosition, out readOnlyMemory, true))
				{
					break;
				}
				if (readOnlyMemory.Length != 0)
				{
					goto IL_4E;
				}
				this._currentPosition = currentPosition;
			}
			this._currentPosition = currentPosition;
			this._isLastSegment = true;
			return false;
			IL_4E:
			if (this._isFinalBlock)
			{
				ReadOnlyMemory<byte> readOnlyMemory2;
				this._isLastSegment = !this._sequence.TryGet(ref this._nextPosition, out readOnlyMemory2, false);
			}
			this._buffer = readOnlyMemory.Span;
			this._totalConsumed += (long)this._consumed;
			this._consumed = 0;
			return true;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000E518 File Offset: 0x0000C718
		private bool ReadFirstTokenMultiSegment(byte first)
		{
			if (first == 123)
			{
				this._bitStack.SetFirstBit();
				this._tokenType = JsonTokenType.StartObject;
				this.ValueSpan = this._buffer.Slice(this._consumed, 1);
				this._consumed++;
				this._bytePositionInLine += 1L;
				this._inObject = true;
				this._isNotPrimitive = true;
			}
			else if (first == 91)
			{
				this._bitStack.ResetFirstBit();
				this._tokenType = JsonTokenType.StartArray;
				this.ValueSpan = this._buffer.Slice(this._consumed, 1);
				this._consumed++;
				this._bytePositionInLine += 1L;
				this._isNotPrimitive = true;
			}
			else
			{
				if (JsonHelpers.IsDigit(first) || first == 45)
				{
					int num;
					if (!this.TryGetNumberMultiSegment(this._buffer.Slice(this._consumed), out num))
					{
						return false;
					}
					this._tokenType = JsonTokenType.Number;
					this._consumed += num;
				}
				else if (!this.ConsumeValueMultiSegment(first))
				{
					return false;
				}
				JsonTokenType tokenType = this._tokenType;
				bool isNotPrimitive = tokenType == JsonTokenType.StartObject || tokenType == JsonTokenType.StartArray;
				this._isNotPrimitive = isNotPrimitive;
			}
			return true;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000E642 File Offset: 0x0000C842
		private void SkipWhiteSpaceMultiSegment()
		{
			do
			{
				this.SkipWhiteSpace();
			}
			while (this._consumed >= this._buffer.Length && this.GetNextSpan());
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000E668 File Offset: 0x0000C868
		private unsafe bool ConsumeValueMultiSegment(byte marker)
		{
			SequencePosition currentPosition;
			for (;;)
			{
				this._trailingCommaBeforeComment = false;
				if (marker == 34)
				{
					break;
				}
				if (marker == 123)
				{
					goto Block_1;
				}
				if (marker == 91)
				{
					goto Block_2;
				}
				if (JsonHelpers.IsDigit(marker) || marker == 45)
				{
					goto IL_40;
				}
				if (marker == 102)
				{
					goto Block_4;
				}
				if (marker == 116)
				{
					goto Block_5;
				}
				if (marker == 110)
				{
					goto Block_6;
				}
				JsonCommentHandling commentHandling = this._readerOptions.CommentHandling;
				if (commentHandling == JsonCommentHandling.Disallow)
				{
					goto IL_1C2;
				}
				if (commentHandling == JsonCommentHandling.Allow)
				{
					goto Block_8;
				}
				if (marker != 47)
				{
					goto IL_1C2;
				}
				currentPosition = this._currentPosition;
				int num;
				if (!this.SkipCommentMultiSegment(out num))
				{
					goto IL_1B9;
				}
				if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
				{
					if (this._isNotPrimitive && this.IsLastSpan && this._tokenType != JsonTokenType.EndArray && this._tokenType != JsonTokenType.EndObject)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidEndOfJsonNonPrimitive, 0, default(ReadOnlySpan<byte>));
					}
					if (!this.GetNextSpan())
					{
						goto Block_18;
					}
				}
				marker = *this._buffer[this._consumed];
				if (marker <= 32)
				{
					this.SkipWhiteSpaceMultiSegment();
					if (!this.HasMoreDataMultiSegment())
					{
						goto Block_24;
					}
					marker = *this._buffer[this._consumed];
				}
				this.TokenStartIndex = this.BytesConsumed;
			}
			return this.ConsumeStringMultiSegment();
			Block_1:
			this.StartObject();
			return true;
			Block_2:
			this.StartArray();
			return true;
			IL_40:
			return this.ConsumeNumberMultiSegment();
			Block_4:
			return this.ConsumeLiteralMultiSegment(JsonConstants.FalseValue, JsonTokenType.False);
			Block_5:
			return this.ConsumeLiteralMultiSegment(JsonConstants.TrueValue, JsonTokenType.True);
			Block_6:
			return this.ConsumeLiteralMultiSegment(JsonConstants.NullValue, JsonTokenType.Null);
			Block_8:
			if (marker != 47)
			{
				goto IL_1C2;
			}
			SequencePosition currentPosition2 = this._currentPosition;
			if (!this.SkipOrConsumeCommentMultiSegmentWithRollback())
			{
				this._currentPosition = currentPosition2;
				return false;
			}
			return true;
			Block_18:
			if (this._isNotPrimitive && this.IsLastSpan && this._tokenType != JsonTokenType.EndArray && this._tokenType != JsonTokenType.EndObject)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidEndOfJsonNonPrimitive, 0, default(ReadOnlySpan<byte>));
			}
			this._currentPosition = currentPosition;
			return false;
			Block_24:
			this._currentPosition = currentPosition;
			return false;
			IL_1B9:
			this._currentPosition = currentPosition;
			return false;
			IL_1C2:
			ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfValueNotFound, marker, default(ReadOnlySpan<byte>));
			return true;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000E84C File Offset: 0x0000CA4C
		private bool ConsumeLiteralMultiSegment(ReadOnlySpan<byte> literal, JsonTokenType tokenType)
		{
			ReadOnlySpan<byte> span = this._buffer.Slice(this._consumed);
			int length = literal.Length;
			if (!span.StartsWith(literal))
			{
				int consumed = this._consumed;
				if (!this.CheckLiteralMultiSegment(span, literal, out length))
				{
					this._consumed = consumed;
					return false;
				}
			}
			else
			{
				this.ValueSpan = span.Slice(0, literal.Length);
				this.HasValueSequence = false;
			}
			this._tokenType = tokenType;
			this._consumed += length;
			this._bytePositionInLine += (long)length;
			return true;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000E8DC File Offset: 0x0000CADC
		private unsafe bool CheckLiteralMultiSegment(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal, out int consumed)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)5], 5);
			int num = 0;
			long totalConsumed = this._totalConsumed;
			SequencePosition currentPosition = this._currentPosition;
			if (span.Length >= literal.Length || this.IsLastSpan)
			{
				this._bytePositionInLine += (long)Utf8JsonReader.FindMismatch(span, literal);
				int num2 = Math.Min(span.Length, (int)this._bytePositionInLine + 1);
				span.Slice(0, num2).CopyTo(destination);
				num += num2;
			}
			else if (!literal.StartsWith(span))
			{
				this._bytePositionInLine += (long)Utf8JsonReader.FindMismatch(span, literal);
				int num3 = Math.Min(span.Length, (int)this._bytePositionInLine + 1);
				span.Slice(0, num3).CopyTo(destination);
				num += num3;
			}
			else
			{
				ReadOnlySpan<byte> readOnlySpan = literal.Slice(span.Length);
				SequencePosition currentPosition2 = this._currentPosition;
				int consumed2 = this._consumed;
				int num4 = literal.Length - readOnlySpan.Length;
				int num5;
				for (;;)
				{
					this._totalConsumed += (long)num4;
					this._bytePositionInLine += (long)num4;
					if (!this.GetNextSpan())
					{
						break;
					}
					num5 = Math.Min(span.Length, destination.Length - num);
					span.Slice(0, num5).CopyTo(destination.Slice(num));
					num += num5;
					span = this._buffer;
					if (span.StartsWith(readOnlySpan))
					{
						goto Block_5;
					}
					if (!readOnlySpan.StartsWith(span))
					{
						goto Block_6;
					}
					readOnlySpan = readOnlySpan.Slice(span.Length);
					num4 = span.Length;
				}
				this._totalConsumed = totalConsumed;
				consumed = 0;
				this._currentPosition = currentPosition;
				if (!this.IsLastSpan)
				{
					return false;
				}
				goto IL_26B;
				Block_5:
				this.HasValueSequence = true;
				SequencePosition start = new SequencePosition(currentPosition2.GetObject(), currentPosition2.GetInteger() + consumed2);
				SequencePosition end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + readOnlySpan.Length);
				this.ValueSequence = this._sequence.Slice(start, end);
				consumed = readOnlySpan.Length;
				return true;
				Block_6:
				this._bytePositionInLine += (long)Utf8JsonReader.FindMismatch(span, readOnlySpan);
				num5 = Math.Min(span.Length, (int)this._bytePositionInLine + 1);
				span.Slice(0, num5).CopyTo(destination.Slice(num));
				num += num5;
			}
			IL_26B:
			this._totalConsumed = totalConsumed;
			consumed = 0;
			this._currentPosition = currentPosition;
			throw this.GetInvalidLiteralMultiSegment(destination.Slice(0, num).ToArray());
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000EB82 File Offset: 0x0000CD82
		private static int FindMismatch(ReadOnlySpan<byte> span, ReadOnlySpan<byte> literal)
		{
			return span.CommonPrefixLength(literal);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		private unsafe JsonException GetInvalidLiteralMultiSegment(ReadOnlySpan<byte> span)
		{
			byte b = *span[0];
			ExceptionResource resource;
			if (b != 102)
			{
				if (b == 116)
				{
					resource = ExceptionResource.ExpectedTrue;
				}
				else
				{
					resource = ExceptionResource.ExpectedNull;
				}
			}
			else
			{
				resource = ExceptionResource.ExpectedFalse;
			}
			return ThrowHelper.GetJsonReaderException(ref this, resource, 0, span);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		private unsafe bool ConsumeNumberMultiSegment()
		{
			int num;
			if (!this.TryGetNumberMultiSegment(this._buffer.Slice(this._consumed), out num))
			{
				return false;
			}
			this._tokenType = JsonTokenType.Number;
			this._consumed += num;
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length) && this._isNotPrimitive)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, *this._buffer[this._consumed - 1], default(ReadOnlySpan<byte>));
			}
			return true;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000EC48 File Offset: 0x0000CE48
		private unsafe bool ConsumePropertyNameMultiSegment()
		{
			this._trailingCommaBeforeComment = false;
			if (!this.ConsumeStringMultiSegment())
			{
				return false;
			}
			if (!this.HasMoreDataMultiSegment(ExceptionResource.ExpectedValueAfterPropertyNameNotFound))
			{
				return false;
			}
			byte b = *this._buffer[this._consumed];
			if (b <= 32)
			{
				this.SkipWhiteSpaceMultiSegment();
				if (!this.HasMoreDataMultiSegment(ExceptionResource.ExpectedValueAfterPropertyNameNotFound))
				{
					return false;
				}
				b = *this._buffer[this._consumed];
			}
			if (b != 58)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedSeparatorAfterPropertyNameNotFound, b, default(ReadOnlySpan<byte>));
			}
			this._consumed++;
			this._bytePositionInLine += 1L;
			this._tokenType = JsonTokenType.PropertyName;
			return true;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		private unsafe bool ConsumeStringMultiSegment()
		{
			ReadOnlySpan<byte> readOnlySpan = this._buffer.Slice(this._consumed + 1);
			int num = readOnlySpan.IndexOfQuoteOrAnyControlOrBackSlash();
			if (num < 0)
			{
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)(readOnlySpan.Length + 1);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
				}
				return this.ConsumeStringNextSegment();
			}
			if (*readOnlySpan[num] == 34)
			{
				this._bytePositionInLine += (long)(num + 2);
				this.ValueSpan = readOnlySpan.Slice(0, num);
				this.HasValueSequence = false;
				this.ValueIsEscaped = false;
				this._tokenType = JsonTokenType.String;
				this._consumed += num + 2;
				return true;
			}
			return this.ConsumeStringAndValidateMultiSegment(readOnlySpan, num);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		private unsafe bool ConsumeStringNextSegment()
		{
			Utf8JsonReader.PartialStateForRollback partialStateForRollback = this.CaptureState();
			this.HasValueSequence = true;
			int num = this._buffer.Length - this._consumed;
			while (this.GetNextSpan())
			{
				ReadOnlySpan<byte> buffer = this._buffer;
				int num2 = buffer.IndexOfQuoteOrAnyControlOrBackSlash();
				if (num2 >= 0)
				{
					SequencePosition end;
					if (*buffer[num2] == 34)
					{
						end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + num2);
						this._bytePositionInLine += (long)(num + num2 + 1);
						this._totalConsumed += (long)num;
						this._consumed = num2 + 1;
						this.ValueIsEscaped = false;
					}
					else
					{
						this._bytePositionInLine += (long)(num + num2);
						this.ValueIsEscaped = true;
						bool flag = false;
						for (;;)
						{
							if (num2 >= buffer.Length)
							{
								if (!this.GetNextSpan())
								{
									goto Block_18;
								}
								this._totalConsumed += (long)buffer.Length;
								buffer = this._buffer;
								num2 = 0;
							}
							else
							{
								byte b = *buffer[num2];
								if (b == 34)
								{
									if (!flag)
									{
										goto IL_2F6;
									}
									flag = false;
								}
								else if (b == 92)
								{
									flag = !flag;
								}
								else if (flag)
								{
									if (JsonConstants.EscapableChars.IndexOf(b) == -1)
									{
										this.RollBackState(partialStateForRollback, true);
										ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterAfterEscapeWithinString, b, default(ReadOnlySpan<byte>));
									}
									if (b == 117)
									{
										this._bytePositionInLine += 1L;
										int num3 = 0;
										int num4 = num2 + 1;
										for (;;)
										{
											if (num4 >= buffer.Length)
											{
												if (!this.GetNextSpan())
												{
													goto Block_14;
												}
												this._totalConsumed += (long)buffer.Length;
												buffer = this._buffer;
												num4 = 0;
											}
											else
											{
												byte nextByte = *buffer[num4];
												if (!JsonReaderHelper.IsHexDigit(nextByte))
												{
													this.RollBackState(partialStateForRollback, true);
													ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidHexCharacterWithinString, nextByte, default(ReadOnlySpan<byte>));
												}
												num3++;
												this._bytePositionInLine += 1L;
												if (num3 >= 4)
												{
													break;
												}
												num4++;
											}
										}
										flag = false;
										num2 = num4 + 1;
										continue;
									}
									flag = false;
								}
								else if (b < 32)
								{
									this.RollBackState(partialStateForRollback, true);
									ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterWithinString, b, default(ReadOnlySpan<byte>));
								}
								this._bytePositionInLine += 1L;
								num2++;
							}
						}
						Block_14:
						if (this.IsLastSpan)
						{
							this.RollBackState(partialStateForRollback, true);
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
						}
						this.RollBackState(partialStateForRollback, false);
						return false;
						Block_18:
						if (this.IsLastSpan)
						{
							this.RollBackState(partialStateForRollback, true);
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
						}
						this.RollBackState(partialStateForRollback, false);
						return false;
						IL_2F6:
						this._bytePositionInLine += 1L;
						this._consumed = num2 + 1;
						this._totalConsumed += (long)num;
						end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + num2);
					}
					SequencePosition startPosition = partialStateForRollback.GetStartPosition(1);
					this.ValueSequence = this._sequence.Slice(startPosition, end);
					this._tokenType = JsonTokenType.String;
					return true;
				}
				this._totalConsumed += (long)buffer.Length;
				this._bytePositionInLine += (long)buffer.Length;
			}
			if (this.IsLastSpan)
			{
				this._bytePositionInLine += (long)num;
				this.RollBackState(partialStateForRollback, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
			}
			this.RollBackState(partialStateForRollback, false);
			return false;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000F14C File Offset: 0x0000D34C
		private unsafe bool ConsumeStringAndValidateMultiSegment(ReadOnlySpan<byte> data, int idx)
		{
			Utf8JsonReader.PartialStateForRollback partialStateForRollback = this.CaptureState();
			this.HasValueSequence = false;
			int num = this._buffer.Length - this._consumed;
			this._bytePositionInLine += (long)(idx + 1);
			bool flag = false;
			for (;;)
			{
				if (idx >= data.Length)
				{
					if (!this.GetNextSpan())
					{
						goto Block_15;
					}
					if (this.HasValueSequence)
					{
						this._totalConsumed += (long)data.Length;
					}
					data = this._buffer;
					idx = 0;
					this.HasValueSequence = true;
				}
				else
				{
					byte b = *data[idx];
					if (b == 34)
					{
						if (!flag)
						{
							goto IL_23B;
						}
						flag = false;
					}
					else if (b == 92)
					{
						flag = !flag;
					}
					else if (flag)
					{
						if (JsonConstants.EscapableChars.IndexOf(b) == -1)
						{
							this.RollBackState(partialStateForRollback, true);
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterAfterEscapeWithinString, b, default(ReadOnlySpan<byte>));
						}
						if (b == 117)
						{
							this._bytePositionInLine += 1L;
							int num2 = 0;
							int num3 = idx + 1;
							for (;;)
							{
								if (num3 >= data.Length)
								{
									if (!this.GetNextSpan())
									{
										goto Block_10;
									}
									if (this.HasValueSequence)
									{
										this._totalConsumed += (long)data.Length;
									}
									data = this._buffer;
									num3 = 0;
									this.HasValueSequence = true;
								}
								else
								{
									byte nextByte = *data[num3];
									if (!JsonReaderHelper.IsHexDigit(nextByte))
									{
										this.RollBackState(partialStateForRollback, true);
										ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidHexCharacterWithinString, nextByte, default(ReadOnlySpan<byte>));
									}
									num2++;
									this._bytePositionInLine += 1L;
									if (num2 >= 4)
									{
										break;
									}
									num3++;
								}
							}
							flag = false;
							idx = num3 + 1;
							continue;
						}
						flag = false;
					}
					else if (b < 32)
					{
						this.RollBackState(partialStateForRollback, true);
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterWithinString, b, default(ReadOnlySpan<byte>));
					}
					this._bytePositionInLine += 1L;
					idx++;
				}
			}
			Block_10:
			if (this.IsLastSpan)
			{
				this.RollBackState(partialStateForRollback, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
			}
			this.RollBackState(partialStateForRollback, false);
			return false;
			Block_15:
			if (this.IsLastSpan)
			{
				this.RollBackState(partialStateForRollback, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.EndOfStringNotFound, 0, default(ReadOnlySpan<byte>));
			}
			this.RollBackState(partialStateForRollback, false);
			return false;
			IL_23B:
			if (this.HasValueSequence)
			{
				this._bytePositionInLine += 1L;
				this._consumed = idx + 1;
				this._totalConsumed += (long)num;
				SequencePosition end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + idx);
				SequencePosition startPosition = partialStateForRollback.GetStartPosition(1);
				this.ValueSequence = this._sequence.Slice(startPosition, end);
			}
			else
			{
				this._bytePositionInLine += 1L;
				this._consumed += idx + 2;
				this.ValueSpan = data.Slice(0, idx);
			}
			this.ValueIsEscaped = true;
			this._tokenType = JsonTokenType.String;
			return true;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000F43F File Offset: 0x0000D63F
		private void RollBackState([ScopedRef] in Utf8JsonReader.PartialStateForRollback state, bool isError = false)
		{
			this._totalConsumed = state._prevTotalConsumed;
			if (!isError)
			{
				this._bytePositionInLine = state._prevBytePositionInLine;
			}
			this._consumed = state._prevConsumed;
			this._currentPosition = state._prevCurrentPosition;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000F474 File Offset: 0x0000D674
		private unsafe bool TryGetNumberMultiSegment(ReadOnlySpan<byte> data, out int consumed)
		{
			Utf8JsonReader.PartialStateForRollback partialStateForRollback = this.CaptureState();
			consumed = 0;
			int num = 0;
			if (this.ConsumeNegativeSignMultiSegment(ref data, ref num, partialStateForRollback) == ConsumeNumberResult.NeedMoreData)
			{
				this.RollBackState(partialStateForRollback, false);
				return false;
			}
			byte b = *data[num];
			if (b == 48)
			{
				ConsumeNumberResult consumeNumberResult = this.ConsumeZeroMultiSegment(ref data, ref num, partialStateForRollback);
				if (consumeNumberResult == ConsumeNumberResult.NeedMoreData)
				{
					this.RollBackState(partialStateForRollback, false);
					return false;
				}
				if (consumeNumberResult == ConsumeNumberResult.Success)
				{
					goto IL_1AA;
				}
				b = *data[num];
			}
			else
			{
				ConsumeNumberResult consumeNumberResult2 = this.ConsumeIntegerDigitsMultiSegment(ref data, ref num);
				if (consumeNumberResult2 == ConsumeNumberResult.NeedMoreData)
				{
					this.RollBackState(partialStateForRollback, false);
					return false;
				}
				if (consumeNumberResult2 == ConsumeNumberResult.Success)
				{
					goto IL_1AA;
				}
				b = *data[num];
				if (b != 46 && b != 69 && b != 101)
				{
					this.RollBackState(partialStateForRollback, true);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, b, default(ReadOnlySpan<byte>));
				}
			}
			if (b == 46)
			{
				num++;
				this._bytePositionInLine += 1L;
				ConsumeNumberResult consumeNumberResult3 = this.ConsumeDecimalDigitsMultiSegment(ref data, ref num, partialStateForRollback);
				if (consumeNumberResult3 == ConsumeNumberResult.NeedMoreData)
				{
					this.RollBackState(partialStateForRollback, false);
					return false;
				}
				if (consumeNumberResult3 == ConsumeNumberResult.Success)
				{
					goto IL_1AA;
				}
				b = *data[num];
				if (b != 69 && b != 101)
				{
					this.RollBackState(partialStateForRollback, true);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedNextDigitEValueNotFound, b, default(ReadOnlySpan<byte>));
				}
			}
			num++;
			this._bytePositionInLine += 1L;
			if (this.ConsumeSignMultiSegment(ref data, ref num, partialStateForRollback) == ConsumeNumberResult.NeedMoreData)
			{
				this.RollBackState(partialStateForRollback, false);
				return false;
			}
			num++;
			this._bytePositionInLine += 1L;
			ConsumeNumberResult consumeNumberResult4 = this.ConsumeIntegerDigitsMultiSegment(ref data, ref num);
			if (consumeNumberResult4 == ConsumeNumberResult.NeedMoreData)
			{
				this.RollBackState(partialStateForRollback, false);
				return false;
			}
			if (consumeNumberResult4 != ConsumeNumberResult.Success)
			{
				this.RollBackState(partialStateForRollback, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndOfDigitNotFound, *data[num], default(ReadOnlySpan<byte>));
			}
			IL_1AA:
			if (this.HasValueSequence)
			{
				SequencePosition startPosition = partialStateForRollback.GetStartPosition(0);
				SequencePosition end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + num);
				this.ValueSequence = this._sequence.Slice(startPosition, end);
				consumed = num;
			}
			else
			{
				this.ValueSpan = data.Slice(0, num);
				consumed = num;
			}
			return true;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000F68C File Offset: 0x0000D88C
		private unsafe ConsumeNumberResult ConsumeNegativeSignMultiSegment(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i, [ScopedRef] in Utf8JsonReader.PartialStateForRollback rollBackState)
		{
			byte b = *data[i];
			if (b == 45)
			{
				i++;
				this._bytePositionInLine += 1L;
				if (i >= data.Length)
				{
					if (this.IsLastSpan)
					{
						this.RollBackState(rollBackState, true);
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					if (!this.GetNextSpan())
					{
						if (this.IsLastSpan)
						{
							this.RollBackState(rollBackState, true);
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
						}
						return ConsumeNumberResult.NeedMoreData;
					}
					this._totalConsumed += (long)i;
					this.HasValueSequence = true;
					i = 0;
					data = this._buffer;
				}
				b = *data[i];
				if (!JsonHelpers.IsDigit(b))
				{
					this.RollBackState(rollBackState, true);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterSign, b, default(ReadOnlySpan<byte>));
				}
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000F768 File Offset: 0x0000D968
		private unsafe ConsumeNumberResult ConsumeZeroMultiSegment(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i, [ScopedRef] in Utf8JsonReader.PartialStateForRollback rollBackState)
		{
			i++;
			this._bytePositionInLine += 1L;
			byte b;
			if (i < data.Length)
			{
				b = *data[i];
				if (JsonConstants.Delimiters.IndexOf(b) >= 0)
				{
					return ConsumeNumberResult.Success;
				}
			}
			else
			{
				if (this.IsLastSpan)
				{
					return ConsumeNumberResult.Success;
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						return ConsumeNumberResult.Success;
					}
					return ConsumeNumberResult.NeedMoreData;
				}
				else
				{
					this._totalConsumed += (long)i;
					this.HasValueSequence = true;
					i = 0;
					data = this._buffer;
					b = *data[i];
					if (JsonConstants.Delimiters.IndexOf(b) >= 0)
					{
						return ConsumeNumberResult.Success;
					}
				}
			}
			b = *data[i];
			if (b != 46 && b != 69 && b != 101)
			{
				this.RollBackState(rollBackState, true);
				ThrowHelper.ThrowJsonReaderException(ref this, JsonHelpers.IsInRangeInclusive((int)b, 48, 57) ? ExceptionResource.InvalidLeadingZeroInNumber : ExceptionResource.ExpectedEndOfDigitNotFound, b, default(ReadOnlySpan<byte>));
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000F850 File Offset: 0x0000DA50
		private unsafe ConsumeNumberResult ConsumeIntegerDigitsMultiSegment(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i)
		{
			byte value = 0;
			int num = 0;
			while (i < data.Length)
			{
				value = *data[i];
				if (!JsonHelpers.IsDigit(value))
				{
					break;
				}
				num++;
				i++;
			}
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)num;
					return ConsumeNumberResult.Success;
				}
				while (this.GetNextSpan())
				{
					this._totalConsumed += (long)i;
					this._bytePositionInLine += (long)num;
					num = 0;
					this.HasValueSequence = true;
					i = 0;
					data = this._buffer;
					while (i < data.Length)
					{
						value = *data[i];
						if (!JsonHelpers.IsDigit(value))
						{
							break;
						}
						i++;
					}
					this._bytePositionInLine += (long)i;
					if (i < data.Length)
					{
						goto IL_106;
					}
					if (this.IsLastSpan)
					{
						return ConsumeNumberResult.Success;
					}
				}
				if (this.IsLastSpan)
				{
					this._bytePositionInLine += (long)num;
					return ConsumeNumberResult.Success;
				}
				return ConsumeNumberResult.NeedMoreData;
			}
			else
			{
				this._bytePositionInLine += (long)num;
			}
			IL_106:
			if (JsonConstants.Delimiters.IndexOf(value) >= 0)
			{
				return ConsumeNumberResult.Success;
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000F974 File Offset: 0x0000DB74
		private unsafe ConsumeNumberResult ConsumeDecimalDigitsMultiSegment(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i, [ScopedRef] in Utf8JsonReader.PartialStateForRollback rollBackState)
		{
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					this.RollBackState(rollBackState, true);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						this.RollBackState(rollBackState, true);
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					return ConsumeNumberResult.NeedMoreData;
				}
				this._totalConsumed += (long)i;
				this.HasValueSequence = true;
				i = 0;
				data = this._buffer;
			}
			byte b = *data[i];
			if (!JsonHelpers.IsDigit(b))
			{
				this.RollBackState(rollBackState, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterDecimal, b, default(ReadOnlySpan<byte>));
			}
			i++;
			this._bytePositionInLine += 1L;
			return this.ConsumeIntegerDigitsMultiSegment(ref data, ref i);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000FA48 File Offset: 0x0000DC48
		private unsafe ConsumeNumberResult ConsumeSignMultiSegment(ref ReadOnlySpan<byte> data, [ScopedRef] ref int i, [ScopedRef] in Utf8JsonReader.PartialStateForRollback rollBackState)
		{
			if (i >= data.Length)
			{
				if (this.IsLastSpan)
				{
					this.RollBackState(rollBackState, true);
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						this.RollBackState(rollBackState, true);
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					return ConsumeNumberResult.NeedMoreData;
				}
				this._totalConsumed += (long)i;
				this.HasValueSequence = true;
				i = 0;
				data = this._buffer;
			}
			byte b = *data[i];
			if (b == 43 || b == 45)
			{
				i++;
				this._bytePositionInLine += 1L;
				if (i >= data.Length)
				{
					if (this.IsLastSpan)
					{
						this.RollBackState(rollBackState, true);
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
					}
					if (!this.GetNextSpan())
					{
						if (this.IsLastSpan)
						{
							this.RollBackState(rollBackState, true);
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundEndOfData, 0, default(ReadOnlySpan<byte>));
						}
						return ConsumeNumberResult.NeedMoreData;
					}
					this._totalConsumed += (long)i;
					this.HasValueSequence = true;
					i = 0;
					data = this._buffer;
				}
				b = *data[i];
			}
			if (!JsonHelpers.IsDigit(b))
			{
				this.RollBackState(rollBackState, true);
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.RequiredDigitNotFoundAfterSign, b, default(ReadOnlySpan<byte>));
			}
			return ConsumeNumberResult.OperationIncomplete;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		private bool ConsumeNextTokenOrRollbackMultiSegment(byte marker)
		{
			long totalConsumed = this._totalConsumed;
			int consumed = this._consumed;
			long bytePositionInLine = this._bytePositionInLine;
			long lineNumber = this._lineNumber;
			JsonTokenType tokenType = this._tokenType;
			SequencePosition currentPosition = this._currentPosition;
			bool trailingCommaBeforeComment = this._trailingCommaBeforeComment;
			ConsumeTokenResult consumeTokenResult = this.ConsumeNextTokenMultiSegment(marker);
			if (consumeTokenResult == ConsumeTokenResult.Success)
			{
				return true;
			}
			if (consumeTokenResult == ConsumeTokenResult.NotEnoughDataRollBackState)
			{
				this._consumed = consumed;
				this._tokenType = tokenType;
				this._bytePositionInLine = bytePositionInLine;
				this._lineNumber = lineNumber;
				this._totalConsumed = totalConsumed;
				this._currentPosition = currentPosition;
				this._trailingCommaBeforeComment = trailingCommaBeforeComment;
			}
			return false;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000FC34 File Offset: 0x0000DE34
		private unsafe ConsumeTokenResult ConsumeNextTokenMultiSegment(byte marker)
		{
			if (this._readerOptions.CommentHandling != JsonCommentHandling.Disallow)
			{
				if (this._readerOptions.CommentHandling != JsonCommentHandling.Allow)
				{
					return this.ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(marker);
				}
				if (marker == 47)
				{
					if (!this.SkipOrConsumeCommentMultiSegmentWithRollback())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					return ConsumeTokenResult.Success;
				}
				else if (this._tokenType == JsonTokenType.Comment)
				{
					return this.ConsumeNextTokenFromLastNonCommentTokenMultiSegment();
				}
			}
			if (this._bitStack.CurrentDepth == 0)
			{
				if (this._readerOptions.AllowMultipleValues)
				{
					if (!this.ReadFirstTokenMultiSegment(marker))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					return ConsumeTokenResult.Success;
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, marker, default(ReadOnlySpan<byte>));
				}
			}
			if (marker != 44)
			{
				if (marker == 125)
				{
					this.EndObject();
				}
				else if (marker == 93)
				{
					this.EndArray();
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.FoundInvalidCharacter, marker, default(ReadOnlySpan<byte>));
				}
				return ConsumeTokenResult.Success;
			}
			this._consumed++;
			this._bytePositionInLine += 1L;
			if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
			{
				if (this.IsLastSpan)
				{
					this._consumed--;
					this._bytePositionInLine -= 1L;
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						this._consumed--;
						this._bytePositionInLine -= 1L;
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
					}
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
			}
			byte b = *this._buffer[this._consumed];
			if (b <= 32)
			{
				this.SkipWhiteSpaceMultiSegment();
				if (!this.HasMoreDataMultiSegment(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				b = *this._buffer[this._consumed];
			}
			this.TokenStartIndex = this.BytesConsumed;
			if (this._readerOptions.CommentHandling == JsonCommentHandling.Allow && b == 47)
			{
				this._trailingCommaBeforeComment = true;
				if (!this.SkipOrConsumeCommentMultiSegmentWithRollback())
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			else if (this._inObject)
			{
				if (b != 34)
				{
					if (b == 125)
					{
						if (this._readerOptions.AllowTrailingCommas)
						{
							this.EndObject();
							return ConsumeTokenResult.Success;
						}
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
					}
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
				}
				if (!this.ConsumePropertyNameMultiSegment())
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			else
			{
				if (b == 93)
				{
					if (this._readerOptions.AllowTrailingCommas)
					{
						this.EndArray();
						return ConsumeTokenResult.Success;
					}
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.ConsumeValueMultiSegment(b))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000FE9C File Offset: 0x0000E09C
		private unsafe ConsumeTokenResult ConsumeNextTokenFromLastNonCommentTokenMultiSegment()
		{
			if (JsonReaderHelper.IsTokenTypePrimitive(this._previousTokenType))
			{
				this._tokenType = (this._inObject ? JsonTokenType.StartObject : JsonTokenType.StartArray);
			}
			else
			{
				this._tokenType = this._previousTokenType;
			}
			if (this.HasMoreDataMultiSegment())
			{
				byte b = *this._buffer[this._consumed];
				if (b <= 32)
				{
					this.SkipWhiteSpaceMultiSegment();
					if (!this.HasMoreDataMultiSegment())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					b = *this._buffer[this._consumed];
				}
				if (this._bitStack.CurrentDepth == 0 && this._tokenType != JsonTokenType.None)
				{
					if (this._readerOptions.AllowMultipleValues)
					{
						if (!this.ReadFirstTokenMultiSegment(b))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, b, default(ReadOnlySpan<byte>));
					}
				}
				this.TokenStartIndex = this.BytesConsumed;
				if (b == 44)
				{
					if (this._previousTokenType <= JsonTokenType.StartObject || this._previousTokenType == JsonTokenType.StartArray || this._trailingCommaBeforeComment)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueAfterComment, b, default(ReadOnlySpan<byte>));
					}
					this._consumed++;
					this._bytePositionInLine += 1L;
					if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
					{
						if (this.IsLastSpan)
						{
							this._consumed--;
							this._bytePositionInLine -= 1L;
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
						}
						if (!this.GetNextSpan())
						{
							if (this.IsLastSpan)
							{
								this._consumed--;
								this._bytePositionInLine -= 1L;
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
								return ConsumeTokenResult.NotEnoughDataRollBackState;
							}
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
					}
					b = *this._buffer[this._consumed];
					if (b <= 32)
					{
						this.SkipWhiteSpaceMultiSegment();
						if (!this.HasMoreDataMultiSegment(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						b = *this._buffer[this._consumed];
					}
					this.TokenStartIndex = this.BytesConsumed;
					if (b == 47)
					{
						this._trailingCommaBeforeComment = true;
						if (!this.SkipOrConsumeCommentMultiSegmentWithRollback())
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
					}
					else if (this._inObject)
					{
						if (b != 34)
						{
							if (b == 125)
							{
								if (this._readerOptions.AllowTrailingCommas)
								{
									this.EndObject();
									return ConsumeTokenResult.Success;
								}
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumePropertyNameMultiSegment())
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
					}
					else
					{
						if (b == 93)
						{
							if (this._readerOptions.AllowTrailingCommas)
							{
								this.EndArray();
								return ConsumeTokenResult.Success;
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumeValueMultiSegment(b))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
					}
				}
				else if (b == 125)
				{
					this.EndObject();
				}
				else if (b == 93)
				{
					this.EndArray();
				}
				else if (this._tokenType == JsonTokenType.None)
				{
					if (!this.ReadFirstTokenMultiSegment(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.StartObject)
				{
					if (b != 34)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
					}
					long totalConsumed = this._totalConsumed;
					int consumed = this._consumed;
					long bytePositionInLine = this._bytePositionInLine;
					long lineNumber = this._lineNumber;
					if (!this.ConsumePropertyNameMultiSegment())
					{
						this._consumed = consumed;
						this._tokenType = JsonTokenType.StartObject;
						this._bytePositionInLine = bytePositionInLine;
						this._lineNumber = lineNumber;
						this._totalConsumed = totalConsumed;
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.StartArray)
				{
					if (!this.ConsumeValueMultiSegment(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._tokenType == JsonTokenType.PropertyName)
				{
					if (!this.ConsumeValueMultiSegment(b))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (this._inObject)
				{
					if (b != 34)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, b, default(ReadOnlySpan<byte>));
					}
					if (!this.ConsumePropertyNameMultiSegment())
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
				}
				else if (!this.ConsumeValueMultiSegment(b))
				{
					return ConsumeTokenResult.NotEnoughDataRollBackState;
				}
				return ConsumeTokenResult.Success;
			}
			return ConsumeTokenResult.NotEnoughDataRollBackState;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00010258 File Offset: 0x0000E458
		private unsafe bool SkipAllCommentsMultiSegment([ScopedRef] ref byte marker)
		{
			while (marker == 47)
			{
				if (this.SkipOrConsumeCommentMultiSegmentWithRollback() && this.HasMoreDataMultiSegment())
				{
					marker = *this._buffer[this._consumed];
					if (marker > 32)
					{
						continue;
					}
					this.SkipWhiteSpaceMultiSegment();
					if (this.HasMoreDataMultiSegment())
					{
						marker = *this._buffer[this._consumed];
						continue;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000102BC File Offset: 0x0000E4BC
		private unsafe bool SkipAllCommentsMultiSegment([ScopedRef] ref byte marker, ExceptionResource resource)
		{
			while (marker == 47)
			{
				if (this.SkipOrConsumeCommentMultiSegmentWithRollback() && this.HasMoreDataMultiSegment(resource))
				{
					marker = *this._buffer[this._consumed];
					if (marker > 32)
					{
						continue;
					}
					this.SkipWhiteSpaceMultiSegment();
					if (this.HasMoreDataMultiSegment(resource))
					{
						marker = *this._buffer[this._consumed];
						continue;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00010324 File Offset: 0x0000E524
		private unsafe ConsumeTokenResult ConsumeNextTokenUntilAfterAllCommentsAreSkippedMultiSegment(byte marker)
		{
			if (this.SkipAllCommentsMultiSegment(ref marker))
			{
				this.TokenStartIndex = this.BytesConsumed;
				if (this._tokenType == JsonTokenType.StartObject)
				{
					if (marker == 125)
					{
						this.EndObject();
					}
					else
					{
						if (marker != 34)
						{
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, marker, default(ReadOnlySpan<byte>));
						}
						long totalConsumed = this._totalConsumed;
						int consumed = this._consumed;
						long bytePositionInLine = this._bytePositionInLine;
						long lineNumber = this._lineNumber;
						SequencePosition currentPosition = this._currentPosition;
						if (!this.ConsumePropertyNameMultiSegment())
						{
							this._consumed = consumed;
							this._tokenType = JsonTokenType.StartObject;
							this._bytePositionInLine = bytePositionInLine;
							this._lineNumber = lineNumber;
							this._totalConsumed = totalConsumed;
							this._currentPosition = currentPosition;
							return ConsumeTokenResult.IncompleteNoRollBackNecessary;
						}
					}
				}
				else if (this._tokenType == JsonTokenType.StartArray)
				{
					if (marker == 93)
					{
						this.EndArray();
					}
					else if (!this.ConsumeValueMultiSegment(marker))
					{
						return ConsumeTokenResult.IncompleteNoRollBackNecessary;
					}
				}
				else if (this._tokenType == JsonTokenType.PropertyName)
				{
					if (!this.ConsumeValueMultiSegment(marker))
					{
						return ConsumeTokenResult.IncompleteNoRollBackNecessary;
					}
				}
				else if (this._bitStack.CurrentDepth == 0)
				{
					if (this._readerOptions.AllowMultipleValues)
					{
						if (!this.ReadFirstTokenMultiSegment(marker))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedEndAfterSingleJson, marker, default(ReadOnlySpan<byte>));
					}
				}
				else if (marker == 44)
				{
					this._consumed++;
					this._bytePositionInLine += 1L;
					if ((long)this._consumed >= (long)((ulong)this._buffer.Length))
					{
						if (this.IsLastSpan)
						{
							this._consumed--;
							this._bytePositionInLine -= 1L;
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
						}
						if (!this.GetNextSpan())
						{
							if (this.IsLastSpan)
							{
								this._consumed--;
								this._bytePositionInLine -= 1L;
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound, 0, default(ReadOnlySpan<byte>));
							}
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
					}
					marker = *this._buffer[this._consumed];
					if (marker <= 32)
					{
						this.SkipWhiteSpaceMultiSegment();
						if (!this.HasMoreDataMultiSegment(ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						marker = *this._buffer[this._consumed];
					}
					if (!this.SkipAllCommentsMultiSegment(ref marker, ExceptionResource.ExpectedStartOfPropertyOrValueNotFound))
					{
						return ConsumeTokenResult.NotEnoughDataRollBackState;
					}
					this.TokenStartIndex = this.BytesConsumed;
					if (this._inObject)
					{
						if (marker != 34)
						{
							if (marker == 125)
							{
								if (this._readerOptions.AllowTrailingCommas)
								{
									this.EndObject();
									return ConsumeTokenResult.Success;
								}
								ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeObjectEnd, 0, default(ReadOnlySpan<byte>));
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.ExpectedStartOfPropertyNotFound, marker, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumePropertyNameMultiSegment())
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
					else
					{
						if (marker == 93)
						{
							if (this._readerOptions.AllowTrailingCommas)
							{
								this.EndArray();
								return ConsumeTokenResult.Success;
							}
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.TrailingCommaNotAllowedBeforeArrayEnd, 0, default(ReadOnlySpan<byte>));
						}
						if (!this.ConsumeValueMultiSegment(marker))
						{
							return ConsumeTokenResult.NotEnoughDataRollBackState;
						}
						return ConsumeTokenResult.Success;
					}
				}
				else if (marker == 125)
				{
					this.EndObject();
				}
				else if (marker == 93)
				{
					this.EndArray();
				}
				else
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.FoundInvalidCharacter, marker, default(ReadOnlySpan<byte>));
				}
				return ConsumeTokenResult.Success;
			}
			return ConsumeTokenResult.IncompleteNoRollBackNecessary;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00010638 File Offset: 0x0000E838
		private bool SkipOrConsumeCommentMultiSegmentWithRollback()
		{
			long bytesConsumed = this.BytesConsumed;
			SequencePosition start = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + this._consumed);
			int num;
			bool flag = this.SkipCommentMultiSegment(out num);
			if (flag)
			{
				if (this._readerOptions.CommentHandling == JsonCommentHandling.Allow)
				{
					SequencePosition end = new SequencePosition(this._currentPosition.GetObject(), this._currentPosition.GetInteger() + this._consumed);
					ReadOnlySequence<byte> valueSequence = this._sequence.Slice(start, end);
					valueSequence = valueSequence.Slice(2L, valueSequence.Length - 2L - (long)num);
					this.HasValueSequence = !valueSequence.IsSingleSegment;
					if (this.HasValueSequence)
					{
						this.ValueSequence = valueSequence;
					}
					else
					{
						this.ValueSpan = valueSequence.First.Span;
					}
					if (this._tokenType != JsonTokenType.Comment)
					{
						this._previousTokenType = this._tokenType;
					}
					this._tokenType = JsonTokenType.Comment;
					return flag;
				}
			}
			else
			{
				this._totalConsumed = bytesConsumed;
				this._consumed = 0;
			}
			return flag;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00010740 File Offset: 0x0000E940
		private unsafe bool SkipCommentMultiSegment(out int tailBytesToIgnore)
		{
			this._consumed++;
			this._bytePositionInLine += 1L;
			ReadOnlySpan<byte> localBuffer = this._buffer.Slice(this._consumed);
			if (localBuffer.Length == 0)
			{
				if (this.IsLastSpan)
				{
					ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
				}
				if (!this.GetNextSpan())
				{
					if (this.IsLastSpan)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
					}
					tailBytesToIgnore = 0;
					return false;
				}
				localBuffer = this._buffer;
			}
			byte b = *localBuffer[0];
			if (b != 47 && b != 42)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.InvalidCharacterAtStartOfComment, b, default(ReadOnlySpan<byte>));
			}
			bool flag = b == 42;
			this._consumed++;
			this._bytePositionInLine += 1L;
			localBuffer = localBuffer.Slice(1);
			if (localBuffer.Length == 0)
			{
				if (this.IsLastSpan)
				{
					tailBytesToIgnore = 0;
					if (flag)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
					}
					return true;
				}
				if (!this.GetNextSpan())
				{
					tailBytesToIgnore = 0;
					if (this.IsLastSpan)
					{
						if (flag)
						{
							ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
						}
						return true;
					}
					return false;
				}
				else
				{
					localBuffer = this._buffer;
				}
			}
			if (flag)
			{
				tailBytesToIgnore = 2;
				return this.SkipMultiLineCommentMultiSegment(localBuffer);
			}
			return this.SkipSingleLineCommentMultiSegment(localBuffer, out tailBytesToIgnore);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00010894 File Offset: 0x0000EA94
		private unsafe bool SkipSingleLineCommentMultiSegment(ReadOnlySpan<byte> localBuffer, out int tailBytesToSkip)
		{
			bool flag = false;
			int num = 0;
			tailBytesToSkip = 0;
			while (!flag)
			{
				int num2 = this.FindLineSeparatorMultiSegment(localBuffer, ref num);
				if (num2 != -1)
				{
					tailBytesToSkip++;
					this._consumed += num2 + 1;
					this._bytePositionInLine += (long)(num2 + 1);
					if (*localBuffer[num2] == 10)
					{
						goto IL_119;
					}
					if (num2 < localBuffer.Length - 1)
					{
						if (*localBuffer[num2 + 1] == 10)
						{
							tailBytesToSkip++;
							this._consumed++;
							this._bytePositionInLine += 1L;
							goto IL_119;
						}
						goto IL_119;
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					this._consumed += localBuffer.Length;
					this._bytePositionInLine += (long)localBuffer.Length;
				}
				if (this.IsLastSpan)
				{
					if (!flag)
					{
						return true;
					}
				}
				else
				{
					if (this.GetNextSpan())
					{
						localBuffer = this._buffer;
						continue;
					}
					if (!this.IsLastSpan)
					{
						return false;
					}
					if (!flag)
					{
						return true;
					}
				}
				IL_119:
				this._bytePositionInLine = 0L;
				this._lineNumber += 1L;
				return true;
			}
			if (*localBuffer[0] == 10)
			{
				tailBytesToSkip++;
				this._consumed++;
				goto IL_119;
			}
			goto IL_119;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000109D4 File Offset: 0x0000EBD4
		private unsafe int FindLineSeparatorMultiSegment(ReadOnlySpan<byte> localBuffer, [ScopedRef] ref int dangerousLineSeparatorBytesConsumed)
		{
			if (dangerousLineSeparatorBytesConsumed != 0)
			{
				this.ThrowOnDangerousLineSeparatorMultiSegment(localBuffer, ref dangerousLineSeparatorBytesConsumed);
				if (dangerousLineSeparatorBytesConsumed != 0)
				{
					return -1;
				}
			}
			int num = 0;
			int num2;
			for (;;)
			{
				num2 = localBuffer.IndexOfAny(10, 13, 226);
				dangerousLineSeparatorBytesConsumed = 0;
				if (num2 == -1)
				{
					break;
				}
				if (*localBuffer[num2] != 226)
				{
					goto Block_4;
				}
				int num3 = num2 + 1;
				localBuffer = localBuffer.Slice(num3);
				num += num3;
				dangerousLineSeparatorBytesConsumed++;
				this.ThrowOnDangerousLineSeparatorMultiSegment(localBuffer, ref dangerousLineSeparatorBytesConsumed);
				if (dangerousLineSeparatorBytesConsumed != 0)
				{
					return -1;
				}
			}
			return -1;
			Block_4:
			return num + num2;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00010A48 File Offset: 0x0000EC48
		private unsafe void ThrowOnDangerousLineSeparatorMultiSegment(ReadOnlySpan<byte> localBuffer, [ScopedRef] ref int dangerousLineSeparatorBytesConsumed)
		{
			if (localBuffer.IsEmpty)
			{
				return;
			}
			if (dangerousLineSeparatorBytesConsumed == 1)
			{
				if (*localBuffer[0] != 128)
				{
					dangerousLineSeparatorBytesConsumed = 0;
					return;
				}
				localBuffer = localBuffer.Slice(1);
				dangerousLineSeparatorBytesConsumed++;
				if (localBuffer.IsEmpty)
				{
					return;
				}
			}
			if (dangerousLineSeparatorBytesConsumed != 2)
			{
				return;
			}
			byte b = *localBuffer[0];
			if (b == 168 || b == 169)
			{
				ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfLineSeparator, 0, default(ReadOnlySpan<byte>));
				return;
			}
			dangerousLineSeparatorBytesConsumed = 0;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		private unsafe bool SkipMultiLineCommentMultiSegment(ReadOnlySpan<byte> localBuffer)
		{
			bool flag = false;
			bool flag2 = false;
			for (;;)
			{
				if (flag)
				{
					if (*localBuffer[0] == 47)
					{
						break;
					}
					flag = false;
				}
				if (flag2)
				{
					if (*localBuffer[0] == 10)
					{
						this._consumed++;
						localBuffer = localBuffer.Slice(1);
					}
					flag2 = false;
				}
				int num = localBuffer.IndexOfAny(42, 10, 13);
				if (num != -1)
				{
					int num2 = num + 1;
					byte b = *localBuffer[num];
					localBuffer = localBuffer.Slice(num2);
					this._consumed += num2;
					if (b != 10)
					{
						if (b == 42)
						{
							flag = true;
							this._bytePositionInLine += (long)num2;
						}
						else
						{
							this._bytePositionInLine = 0L;
							this._lineNumber += 1L;
							flag2 = true;
						}
					}
					else
					{
						this._bytePositionInLine = 0L;
						this._lineNumber += 1L;
					}
				}
				else
				{
					this._consumed += localBuffer.Length;
					this._bytePositionInLine += (long)localBuffer.Length;
					localBuffer = ReadOnlySpan<byte>.Empty;
				}
				if (localBuffer.IsEmpty)
				{
					if (this.IsLastSpan)
					{
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
					}
					if (!this.GetNextSpan())
					{
						if (!this.IsLastSpan)
						{
							return false;
						}
						ThrowHelper.ThrowJsonReaderException(ref this, ExceptionResource.UnexpectedEndOfDataWhileReadingComment, 0, default(ReadOnlySpan<byte>));
					}
					localBuffer = this._buffer;
				}
			}
			this._consumed++;
			this._bytePositionInLine += 1L;
			return true;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00010C49 File Offset: 0x0000EE49
		private Utf8JsonReader.PartialStateForRollback CaptureState()
		{
			return new Utf8JsonReader.PartialStateForRollback(this._totalConsumed, this._bytePositionInLine, this._consumed, this._currentPosition);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00010C68 File Offset: 0x0000EE68
		[NullableContext(2)]
		public string GetString()
		{
			if (this.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			if (this.TokenType != JsonTokenType.String && this.TokenType != JsonTokenType.PropertyName)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			if (this.ValueIsEscaped)
			{
				return JsonReaderHelper.GetUnescapedString(readOnlySpan2);
			}
			return JsonReaderHelper.TranscodeHelper(readOnlySpan2);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00010CD8 File Offset: 0x0000EED8
		public readonly int CopyString(Span<byte> utf8Destination)
		{
			JsonTokenType tokenType = this._tokenType;
			if (tokenType != JsonTokenType.PropertyName && tokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this._tokenType);
			}
			return this.CopyValue(utf8Destination);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00010D10 File Offset: 0x0000EF10
		internal readonly int CopyValue(Span<byte> utf8Destination)
		{
			int num;
			if (this.ValueIsEscaped)
			{
				if (!this.TryCopyEscapedString(utf8Destination, out num))
				{
					utf8Destination.Slice(0, num).Clear();
					ThrowHelper.ThrowArgumentException_DestinationTooShort();
				}
			}
			else if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				valueSequence.CopyTo(utf8Destination);
				num = (int)valueSequence.Length;
			}
			else
			{
				ReadOnlySpan<byte> valueSpan = this.ValueSpan;
				valueSpan.CopyTo(utf8Destination);
				num = valueSpan.Length;
			}
			JsonReaderHelper.ValidateUtf8(utf8Destination.Slice(0, num));
			return num;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00010D98 File Offset: 0x0000EF98
		public readonly int CopyString(Span<char> destination)
		{
			JsonTokenType tokenType = this._tokenType;
			if (tokenType != JsonTokenType.PropertyName && tokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this._tokenType);
			}
			return this.CopyValue(destination);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		internal unsafe readonly int CopyValue(Span<char> destination)
		{
			byte[] array = null;
			ReadOnlySpan<byte> utf8Unescaped;
			if (this.ValueIsEscaped)
			{
				int num = this.ValueLength;
				Span<byte> span;
				if (num <= 256)
				{
					span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				else
				{
					span = (array = ArrayPool<byte>.Shared.Rent(num));
				}
				Span<byte> destination2 = span;
				int length;
				this.TryCopyEscapedString(destination2, out length);
				utf8Unescaped = destination2.Slice(0, length);
			}
			else if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				int num = checked((int)valueSequence.Length);
				Span<byte> span;
				if (num <= 256)
				{
					span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				else
				{
					span = (array = ArrayPool<byte>.Shared.Rent(num));
				}
				Span<byte> destination3 = span;
				valueSequence.CopyTo(destination3);
				utf8Unescaped = destination3.Slice(0, num);
			}
			else
			{
				utf8Unescaped = this.ValueSpan;
			}
			int result = JsonReaderHelper.TranscodeHelper(utf8Unescaped, destination);
			if (array != null)
			{
				new Span<byte>(array, 0, utf8Unescaped.Length).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00010EDC File Offset: 0x0000F0DC
		private unsafe readonly bool TryCopyEscapedString(Span<byte> destination, out int bytesWritten)
		{
			byte[] array = null;
			ReadOnlySpan<byte> source;
			if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				int num = checked((int)valueSequence.Length);
				Span<byte> span;
				if (num <= 256)
				{
					span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				else
				{
					span = (array = ArrayPool<byte>.Shared.Rent(num));
				}
				Span<byte> destination2 = span;
				valueSequence.CopyTo(destination2);
				source = destination2.Slice(0, num);
			}
			else
			{
				source = this.ValueSpan;
			}
			bool result = JsonReaderHelper.TryUnescape(source, destination, out bytesWritten);
			if (array != null)
			{
				new Span<byte>(array, 0, source.Length).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00010F88 File Offset: 0x0000F188
		[NullableContext(1)]
		public string GetComment()
		{
			if (this.TokenType != JsonTokenType.Comment)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedComment(this.TokenType);
			}
			ReadOnlySpan<byte> utf8Unescaped;
			if (!this.HasValueSequence)
			{
				utf8Unescaped = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				utf8Unescaped = valueSequence.ToArray<byte>();
			}
			return JsonReaderHelper.TranscodeHelper(utf8Unescaped);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		public bool GetBoolean()
		{
			JsonTokenType tokenType = this.TokenType;
			if (tokenType == JsonTokenType.True)
			{
				return true;
			}
			if (tokenType != JsonTokenType.False)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedBoolean(this.TokenType);
			}
			return false;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00011000 File Offset: 0x0000F200
		[NullableContext(1)]
		public byte[] GetBytesFromBase64()
		{
			byte[] result;
			if (!this.TryGetBytesFromBase64(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.Base64String);
			}
			return result;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00011020 File Offset: 0x0000F220
		public byte GetByte()
		{
			byte result;
			if (!this.TryGetByte(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Byte);
			}
			return result;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00011040 File Offset: 0x0000F240
		internal byte GetByteWithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			byte result;
			if (!Utf8JsonReader.TryGetByteCore(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.Byte);
			}
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00011068 File Offset: 0x0000F268
		[CLSCompliant(false)]
		public sbyte GetSByte()
		{
			sbyte result;
			if (!this.TryGetSByte(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.SByte);
			}
			return result;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00011088 File Offset: 0x0000F288
		internal sbyte GetSByteWithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			sbyte result;
			if (!Utf8JsonReader.TryGetSByteCore(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.SByte);
			}
			return result;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000110B0 File Offset: 0x0000F2B0
		public short GetInt16()
		{
			short result;
			if (!this.TryGetInt16(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int16);
			}
			return result;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000110D0 File Offset: 0x0000F2D0
		internal short GetInt16WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			short result;
			if (!Utf8JsonReader.TryGetInt16Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int16);
			}
			return result;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public int GetInt32()
		{
			int result;
			if (!this.TryGetInt32(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int32);
			}
			return result;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00011118 File Offset: 0x0000F318
		internal int GetInt32WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			int result;
			if (!Utf8JsonReader.TryGetInt32Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int32);
			}
			return result;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00011140 File Offset: 0x0000F340
		public long GetInt64()
		{
			long result;
			if (!this.TryGetInt64(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int64);
			}
			return result;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00011160 File Offset: 0x0000F360
		internal long GetInt64WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			long result;
			if (!Utf8JsonReader.TryGetInt64Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int64);
			}
			return result;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00011188 File Offset: 0x0000F388
		[CLSCompliant(false)]
		public ushort GetUInt16()
		{
			ushort result;
			if (!this.TryGetUInt16(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt16);
			}
			return result;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000111A8 File Offset: 0x0000F3A8
		internal ushort GetUInt16WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			ushort result;
			if (!Utf8JsonReader.TryGetUInt16Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt16);
			}
			return result;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000111D0 File Offset: 0x0000F3D0
		[CLSCompliant(false)]
		public uint GetUInt32()
		{
			uint result;
			if (!this.TryGetUInt32(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt32);
			}
			return result;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000111F0 File Offset: 0x0000F3F0
		internal uint GetUInt32WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			uint result;
			if (!Utf8JsonReader.TryGetUInt32Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt32);
			}
			return result;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00011218 File Offset: 0x0000F418
		[CLSCompliant(false)]
		public ulong GetUInt64()
		{
			ulong result;
			if (!this.TryGetUInt64(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt64);
			}
			return result;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00011238 File Offset: 0x0000F438
		internal ulong GetUInt64WithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			ulong result;
			if (!Utf8JsonReader.TryGetUInt64Core(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt64);
			}
			return result;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00011260 File Offset: 0x0000F460
		public float GetSingle()
		{
			float result;
			if (!this.TryGetSingle(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Single);
			}
			return result;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00011280 File Offset: 0x0000F480
		internal float GetSingleWithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			float num;
			if (JsonReaderHelper.TryGetFloatingPointConstant(unescapedSpan, out num))
			{
				return num;
			}
			int num2;
			if (!Utf8Parser.TryParse(unescapedSpan, out num, out num2, '\0') || unescapedSpan.Length != num2 || !JsonHelpers.IsFinite(num))
			{
				ThrowHelper.ThrowFormatException(NumericType.Single);
			}
			return num;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000112C8 File Offset: 0x0000F4C8
		internal float GetSingleFloatingPointConstant()
		{
			float result;
			if (!JsonReaderHelper.TryGetFloatingPointConstant(this.GetUnescapedSpan(), out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Single);
			}
			return result;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000112EC File Offset: 0x0000F4EC
		public double GetDouble()
		{
			double result;
			if (!this.TryGetDouble(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Double);
			}
			return result;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001130C File Offset: 0x0000F50C
		internal double GetDoubleWithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			double num;
			if (JsonReaderHelper.TryGetFloatingPointConstant(unescapedSpan, out num))
			{
				return num;
			}
			int num2;
			if (!Utf8Parser.TryParse(unescapedSpan, out num, out num2, '\0') || unescapedSpan.Length != num2 || !JsonHelpers.IsFinite(num))
			{
				ThrowHelper.ThrowFormatException(NumericType.Double);
			}
			return num;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00011354 File Offset: 0x0000F554
		internal double GetDoubleFloatingPointConstant()
		{
			double result;
			if (!JsonReaderHelper.TryGetFloatingPointConstant(this.GetUnescapedSpan(), out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Double);
			}
			return result;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00011378 File Offset: 0x0000F578
		public decimal GetDecimal()
		{
			decimal result;
			if (!this.TryGetDecimal(out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Decimal);
			}
			return result;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00011398 File Offset: 0x0000F598
		internal decimal GetDecimalWithQuotes()
		{
			ReadOnlySpan<byte> unescapedSpan = this.GetUnescapedSpan();
			decimal result;
			if (!Utf8JsonReader.TryGetDecimalCore(out result, unescapedSpan))
			{
				ThrowHelper.ThrowFormatException(NumericType.Decimal);
			}
			return result;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000113C0 File Offset: 0x0000F5C0
		public DateTime GetDateTime()
		{
			DateTime result;
			if (!this.TryGetDateTime(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.DateTime);
			}
			return result;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000113E0 File Offset: 0x0000F5E0
		internal DateTime GetDateTimeNoValidation()
		{
			DateTime result;
			if (!this.TryGetDateTimeCore(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.DateTime);
			}
			return result;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00011400 File Offset: 0x0000F600
		public DateTimeOffset GetDateTimeOffset()
		{
			DateTimeOffset result;
			if (!this.TryGetDateTimeOffset(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.DateTimeOffset);
			}
			return result;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00011420 File Offset: 0x0000F620
		internal DateTimeOffset GetDateTimeOffsetNoValidation()
		{
			DateTimeOffset result;
			if (!this.TryGetDateTimeOffsetCore(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.DateTimeOffset);
			}
			return result;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00011440 File Offset: 0x0000F640
		public Guid GetGuid()
		{
			Guid result;
			if (!this.TryGetGuid(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.Guid);
			}
			return result;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00011460 File Offset: 0x0000F660
		internal Guid GetGuidNoValidation()
		{
			Guid result;
			if (!this.TryGetGuidCore(out result))
			{
				ThrowHelper.ThrowFormatException(DataType.Guid);
			}
			return result;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00011480 File Offset: 0x0000F680
		[NullableContext(2)]
		public bool TryGetBytesFromBase64([NotNullWhen(true)] out byte[] value)
		{
			if (this.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			if (this.ValueIsEscaped)
			{
				return JsonReaderHelper.TryGetUnescapedBase64Bytes(readOnlySpan2, out value);
			}
			return JsonReaderHelper.TryDecodeBase64(readOnlySpan2, out value);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000114DC File Offset: 0x0000F6DC
		public bool TryGetByte(out byte value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetByteCore(out value, span);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00011528 File Offset: 0x0000F728
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetByteCore(out byte value, ReadOnlySpan<byte> span)
		{
			byte b;
			int num;
			if (Utf8Parser.TryParse(span, out b, out num, '\0') && span.Length == num)
			{
				value = b;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00011558 File Offset: 0x0000F758
		[CLSCompliant(false)]
		public bool TryGetSByte(out sbyte value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetSByteCore(out value, span);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000115A4 File Offset: 0x0000F7A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetSByteCore(out sbyte value, ReadOnlySpan<byte> span)
		{
			sbyte b;
			int num;
			if (Utf8Parser.TryParse(span, out b, out num, '\0') && span.Length == num)
			{
				value = b;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000115D4 File Offset: 0x0000F7D4
		public bool TryGetInt16(out short value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetInt16Core(out value, span);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00011620 File Offset: 0x0000F820
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetInt16Core(out short value, ReadOnlySpan<byte> span)
		{
			short num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00011650 File Offset: 0x0000F850
		public bool TryGetInt32(out int value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetInt32Core(out value, span);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001169C File Offset: 0x0000F89C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetInt32Core(out int value, ReadOnlySpan<byte> span)
		{
			int num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000116CC File Offset: 0x0000F8CC
		public bool TryGetInt64(out long value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetInt64Core(out value, span);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00011718 File Offset: 0x0000F918
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetInt64Core(out long value, ReadOnlySpan<byte> span)
		{
			long num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0L;
			return false;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00011748 File Offset: 0x0000F948
		[CLSCompliant(false)]
		public bool TryGetUInt16(out ushort value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetUInt16Core(out value, span);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00011794 File Offset: 0x0000F994
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetUInt16Core(out ushort value, ReadOnlySpan<byte> span)
		{
			ushort num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000117C4 File Offset: 0x0000F9C4
		[CLSCompliant(false)]
		public bool TryGetUInt32(out uint value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetUInt32Core(out value, span);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00011810 File Offset: 0x0000FA10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetUInt32Core(out uint value, ReadOnlySpan<byte> span)
		{
			uint num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0U;
			return false;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00011840 File Offset: 0x0000FA40
		[CLSCompliant(false)]
		public bool TryGetUInt64(out ulong value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetUInt64Core(out value, span);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001188C File Offset: 0x0000FA8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetUInt64Core(out ulong value, ReadOnlySpan<byte> span)
		{
			ulong num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0UL;
			return false;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000118BC File Offset: 0x0000FABC
		public bool TryGetSingle(out float value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> source = readOnlySpan;
			float num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && source.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00011928 File Offset: 0x0000FB28
		public bool TryGetDouble(out double value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> source = readOnlySpan;
			double num;
			int num2;
			if (Utf8Parser.TryParse(source, out num, out num2, '\0') && source.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0.0;
			return false;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00011998 File Offset: 0x0000FB98
		public bool TryGetDecimal(out decimal value)
		{
			if (this.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(this.TokenType);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!this.HasValueSequence)
			{
				readOnlySpan = this.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> span = readOnlySpan;
			return Utf8JsonReader.TryGetDecimalCore(out value, span);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000119E4 File Offset: 0x0000FBE4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryGetDecimalCore(out decimal value, ReadOnlySpan<byte> span)
		{
			decimal num;
			int num2;
			if (Utf8Parser.TryParse(span, out num, out num2, '\0') && span.Length == num2)
			{
				value = num;
				return true;
			}
			value = 0m;
			return false;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00011A19 File Offset: 0x0000FC19
		public bool TryGetDateTime(out DateTime value)
		{
			if (this.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this.TokenType);
			}
			return this.TryGetDateTimeCore(out value);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00011A38 File Offset: 0x0000FC38
		internal unsafe bool TryGetDateTimeCore(out DateTime value)
		{
			ReadOnlySpan<byte> source;
			if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				long length = valueSequence.Length;
				if (!JsonHelpers.IsInRangeInclusive(length, 10L, 252L))
				{
					value = default(DateTime);
					return false;
				}
				Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)252], 252);
				valueSequence = this.ValueSequence;
				valueSequence.CopyTo(destination);
				source = destination.Slice(0, (int)length);
			}
			else
			{
				if (!JsonHelpers.IsInRangeInclusive(this.ValueSpan.Length, 10, 252))
				{
					value = default(DateTime);
					return false;
				}
				source = this.ValueSpan;
			}
			if (this.ValueIsEscaped)
			{
				return JsonReaderHelper.TryGetEscapedDateTime(source, out value);
			}
			DateTime dateTime;
			if (JsonHelpers.TryParseAsISO(source, out dateTime))
			{
				value = dateTime;
				return true;
			}
			value = default(DateTime);
			return false;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00011B04 File Offset: 0x0000FD04
		public bool TryGetDateTimeOffset(out DateTimeOffset value)
		{
			if (this.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this.TokenType);
			}
			return this.TryGetDateTimeOffsetCore(out value);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00011B24 File Offset: 0x0000FD24
		internal unsafe bool TryGetDateTimeOffsetCore(out DateTimeOffset value)
		{
			ReadOnlySpan<byte> source;
			if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				long length = valueSequence.Length;
				if (!JsonHelpers.IsInRangeInclusive(length, 10L, 252L))
				{
					value = default(DateTimeOffset);
					return false;
				}
				Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)252], 252);
				valueSequence = this.ValueSequence;
				valueSequence.CopyTo(destination);
				source = destination.Slice(0, (int)length);
			}
			else
			{
				if (!JsonHelpers.IsInRangeInclusive(this.ValueSpan.Length, 10, 252))
				{
					value = default(DateTimeOffset);
					return false;
				}
				source = this.ValueSpan;
			}
			if (this.ValueIsEscaped)
			{
				return JsonReaderHelper.TryGetEscapedDateTimeOffset(source, out value);
			}
			DateTimeOffset dateTimeOffset;
			if (JsonHelpers.TryParseAsISO(source, out dateTimeOffset))
			{
				value = dateTimeOffset;
				return true;
			}
			value = default(DateTimeOffset);
			return false;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		public bool TryGetGuid(out Guid value)
		{
			if (this.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(this.TokenType);
			}
			return this.TryGetGuidCore(out value);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00011C10 File Offset: 0x0000FE10
		internal unsafe bool TryGetGuidCore(out Guid value)
		{
			ReadOnlySpan<byte> source;
			if (this.HasValueSequence)
			{
				ReadOnlySequence<byte> valueSequence = this.ValueSequence;
				long length = valueSequence.Length;
				if (length > 216L)
				{
					value = default(Guid);
					return false;
				}
				Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)216], 216);
				valueSequence = this.ValueSequence;
				valueSequence.CopyTo(destination);
				source = destination.Slice(0, (int)length);
			}
			else
			{
				if (this.ValueSpan.Length > 216)
				{
					value = default(Guid);
					return false;
				}
				source = this.ValueSpan;
			}
			if (this.ValueIsEscaped)
			{
				return JsonReaderHelper.TryGetEscapedGuid(source, out value);
			}
			Guid guid;
			int num;
			if (source.Length == 36 && Utf8Parser.TryParse(source, out guid, out num, 'D'))
			{
				value = guid;
				return true;
			}
			value = default(Guid);
			return false;
		}

		// Token: 0x040000A3 RID: 163
		private ReadOnlySpan<byte> _buffer;

		// Token: 0x040000A4 RID: 164
		private readonly bool _isFinalBlock;

		// Token: 0x040000A5 RID: 165
		private readonly bool _isInputSequence;

		// Token: 0x040000A6 RID: 166
		private long _lineNumber;

		// Token: 0x040000A7 RID: 167
		private long _bytePositionInLine;

		// Token: 0x040000A8 RID: 168
		private int _consumed;

		// Token: 0x040000A9 RID: 169
		private bool _inObject;

		// Token: 0x040000AA RID: 170
		private bool _isNotPrimitive;

		// Token: 0x040000AB RID: 171
		private JsonTokenType _tokenType;

		// Token: 0x040000AC RID: 172
		private JsonTokenType _previousTokenType;

		// Token: 0x040000AD RID: 173
		private JsonReaderOptions _readerOptions;

		// Token: 0x040000AE RID: 174
		private BitStack _bitStack;

		// Token: 0x040000AF RID: 175
		private long _totalConsumed;

		// Token: 0x040000B0 RID: 176
		private bool _isLastSegment;

		// Token: 0x040000B1 RID: 177
		private readonly bool _isMultiSegment;

		// Token: 0x040000B2 RID: 178
		private bool _trailingCommaBeforeComment;

		// Token: 0x040000B3 RID: 179
		private SequencePosition _nextPosition;

		// Token: 0x040000B4 RID: 180
		private SequencePosition _currentPosition;

		// Token: 0x040000B5 RID: 181
		private readonly ReadOnlySequence<byte> _sequence;

		// Token: 0x02000037 RID: 55
		private readonly struct PartialStateForRollback
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00011CDC File Offset: 0x0000FEDC
			public PartialStateForRollback(long totalConsumed, long bytePositionInLine, int consumed, SequencePosition currentPosition)
			{
				this._prevTotalConsumed = totalConsumed;
				this._prevBytePositionInLine = bytePositionInLine;
				this._prevConsumed = consumed;
				this._prevCurrentPosition = currentPosition;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00011CFB File Offset: 0x0000FEFB
			public SequencePosition GetStartPosition(int offset = 0)
			{
				return new SequencePosition(this._prevCurrentPosition.GetObject(), this._prevCurrentPosition.GetInteger() + this._prevConsumed + offset);
			}

			// Token: 0x040000BB RID: 187
			public readonly long _prevTotalConsumed;

			// Token: 0x040000BC RID: 188
			public readonly long _prevBytePositionInLine;

			// Token: 0x040000BD RID: 189
			public readonly int _prevConsumed;

			// Token: 0x040000BE RID: 190
			public readonly SequencePosition _prevCurrentPosition;
		}
	}
}
