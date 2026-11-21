using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json
{
	// Token: 0x0200005B RID: 91
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public sealed class Utf8JsonWriter : IDisposable, IAsyncDisposable
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001853E File Offset: 0x0001673E
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00018546 File Offset: 0x00016746
		public int BytesPending { get; private set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001854F File Offset: 0x0001674F
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00018557 File Offset: 0x00016757
		public long BytesCommitted { get; private set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00018560 File Offset: 0x00016760
		public JsonWriterOptions Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00018568 File Offset: 0x00016768
		private int Indentation
		{
			get
			{
				return this.CurrentDepth * this._indentLength;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00018577 File Offset: 0x00016777
		internal JsonTokenType TokenType
		{
			get
			{
				return this._tokenType;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001857F File Offset: 0x0001677F
		public int CurrentDepth
		{
			get
			{
				return this._currentDepth & int.MaxValue;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000527B File Offset: 0x0000347B
		private Utf8JsonWriter()
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001858D File Offset: 0x0001678D
		[NullableContext(1)]
		public Utf8JsonWriter(IBufferWriter<byte> bufferWriter, JsonWriterOptions options = default(JsonWriterOptions))
		{
			if (bufferWriter == null)
			{
				ThrowHelper.ThrowArgumentNullException("bufferWriter");
			}
			this._output = bufferWriter;
			this.SetOptions(options);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000185B0 File Offset: 0x000167B0
		[NullableContext(1)]
		public Utf8JsonWriter(Stream utf8Json, JsonWriterOptions options = default(JsonWriterOptions))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (!utf8Json.CanWrite)
			{
				throw new ArgumentException(SR.StreamNotWritable);
			}
			this._stream = utf8Json;
			this.SetOptions(options);
			this._arrayBufferWriter = new ArrayBufferWriter<byte>();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000185FC File Offset: 0x000167FC
		private void SetOptions(JsonWriterOptions options)
		{
			this._options = options;
			this._indentByte = (byte)this._options.IndentCharacter;
			this._indentLength = options.IndentSize;
			this._newLineLength = options.NewLine.Length;
			if (this._options.MaxDepth == 0)
			{
				this._options.MaxDepth = 1000;
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001865E File Offset: 0x0001685E
		public void Reset()
		{
			this.CheckNotDisposed();
			ArrayBufferWriter<byte> arrayBufferWriter = this._arrayBufferWriter;
			if (arrayBufferWriter != null)
			{
				arrayBufferWriter.Clear();
			}
			this.ResetHelper();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00018680 File Offset: 0x00016880
		[NullableContext(1)]
		public void Reset(Stream utf8Json)
		{
			this.CheckNotDisposed();
			if (utf8Json == null)
			{
				throw new ArgumentNullException("utf8Json");
			}
			if (!utf8Json.CanWrite)
			{
				throw new ArgumentException(SR.StreamNotWritable);
			}
			this._stream = utf8Json;
			if (this._arrayBufferWriter == null)
			{
				this._arrayBufferWriter = new ArrayBufferWriter<byte>();
			}
			else
			{
				this._arrayBufferWriter.Clear();
			}
			this._output = null;
			this.ResetHelper();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000186E8 File Offset: 0x000168E8
		[NullableContext(1)]
		public void Reset(IBufferWriter<byte> bufferWriter)
		{
			this.CheckNotDisposed();
			if (bufferWriter == null)
			{
				throw new ArgumentNullException("bufferWriter");
			}
			this._output = bufferWriter;
			this._stream = null;
			this._arrayBufferWriter = null;
			this.ResetHelper();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001871A File Offset: 0x0001691A
		internal void ResetAllStateForCacheReuse()
		{
			this.ResetHelper();
			this._stream = null;
			this._arrayBufferWriter = null;
			this._output = null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018737 File Offset: 0x00016937
		internal void Reset(IBufferWriter<byte> bufferWriter, JsonWriterOptions options)
		{
			this._output = bufferWriter;
			this.SetOptions(options);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00018747 File Offset: 0x00016947
		internal static Utf8JsonWriter CreateEmptyInstanceForCaching()
		{
			return new Utf8JsonWriter();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00018750 File Offset: 0x00016950
		private void ResetHelper()
		{
			this.BytesPending = 0;
			this.BytesCommitted = 0L;
			this._memory = default(Memory<byte>);
			this._inObject = false;
			this._tokenType = JsonTokenType.None;
			this._commentAfterNoneOrPropertyName = false;
			this._currentDepth = 0;
			this._bitStack = default(BitStack);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000187A0 File Offset: 0x000169A0
		private void CheckNotDisposed()
		{
			if (this._stream == null && this._output == null)
			{
				ThrowHelper.ThrowObjectDisposedException_Utf8JsonWriter();
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000187B8 File Offset: 0x000169B8
		public void Flush()
		{
			this.CheckNotDisposed();
			this._memory = default(Memory<byte>);
			if (this._stream != null)
			{
				if (this.BytesPending != 0)
				{
					this._arrayBufferWriter.Advance(this.BytesPending);
					this.BytesPending = 0;
					this._stream.Write(this._arrayBufferWriter.WrittenSpan);
					this.BytesCommitted += (long)this._arrayBufferWriter.WrittenCount;
					this._arrayBufferWriter.Clear();
				}
				this._stream.Flush();
				return;
			}
			if (this.BytesPending != 0)
			{
				this._output.Advance(this.BytesPending);
				this.BytesCommitted += (long)this.BytesPending;
				this.BytesPending = 0;
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00018879 File Offset: 0x00016A79
		public void Dispose()
		{
			if (this._stream == null && this._output == null)
			{
				return;
			}
			this.Flush();
			this.ResetHelper();
			this._stream = null;
			this._arrayBufferWriter = null;
			this._output = null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000188B0 File Offset: 0x00016AB0
		public ValueTask DisposeAsync()
		{
			Utf8JsonWriter.<DisposeAsync>d__45 <DisposeAsync>d__;
			<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsync>d__.<>4__this = this;
			<DisposeAsync>d__.<>1__state = -1;
			<DisposeAsync>d__.<>t__builder.Start<Utf8JsonWriter.<DisposeAsync>d__45>(ref <DisposeAsync>d__);
			return <DisposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000188F4 File Offset: 0x00016AF4
		[NullableContext(1)]
		public Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			Utf8JsonWriter.<FlushAsync>d__46 <FlushAsync>d__;
			<FlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsync>d__.<>4__this = this;
			<FlushAsync>d__.cancellationToken = cancellationToken;
			<FlushAsync>d__.<>1__state = -1;
			<FlushAsync>d__.<>t__builder.Start<Utf8JsonWriter.<FlushAsync>d__46>(ref <FlushAsync>d__);
			return <FlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001893F File Offset: 0x00016B3F
		public void WriteStartArray()
		{
			this.WriteStart(91);
			this._tokenType = JsonTokenType.StartArray;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00018950 File Offset: 0x00016B50
		public void WriteStartObject()
		{
			this.WriteStart(123);
			this._tokenType = JsonTokenType.StartObject;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00018964 File Offset: 0x00016B64
		private void WriteStart(byte token)
		{
			if (this.CurrentDepth >= this._options.MaxDepth)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.DepthTooLarge, this._currentDepth, this._options.MaxDepth, 0, JsonTokenType.None);
			}
			if (this._options.IndentedOrNotSkipValidation)
			{
				this.WriteStartSlow(token);
			}
			else
			{
				this.WriteStartMinimized(token);
			}
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000189DC File Offset: 0x00016BDC
		private unsafe void WriteStartMinimized(byte token)
		{
			if (this._memory.Length - this.BytesPending < 2)
			{
				this.Grow(2);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00018A50 File Offset: 0x00016C50
		private void WriteStartSlow(byte token)
		{
			if (this._options.Indented)
			{
				if (!this._options.SkipValidation)
				{
					this.ValidateStart();
					this.UpdateBitStackOnStart(token);
				}
				this.WriteStartIndented(token);
				return;
			}
			this.ValidateStart();
			this.UpdateBitStackOnStart(token);
			this.WriteStartMinimized(token);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00018AA0 File Offset: 0x00016CA0
		private void ValidateStart()
		{
			if (this._inObject)
			{
				if (this._tokenType != JsonTokenType.PropertyName)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotStartObjectArrayWithoutProperty, 0, this._options.MaxDepth, 0, this._tokenType);
					return;
				}
			}
			else if (this.CurrentDepth == 0 && this._tokenType != JsonTokenType.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotStartObjectArrayAfterPrimitiveOrClose, 0, this._options.MaxDepth, 0, this._tokenType);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00018B04 File Offset: 0x00016D04
		private unsafe void WriteStartIndented(byte token)
		{
			int indentation = this.Indentation;
			int num = indentation + 1 + 3;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			JsonTokenType tokenType = this._tokenType;
			if ((tokenType != JsonTokenType.PropertyName && tokenType != JsonTokenType.None) || this._commentAfterNoneOrPropertyName)
			{
				this.WriteNewLine(span);
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00018BC7 File Offset: 0x00016DC7
		public void WriteStartArray(JsonEncodedText propertyName)
		{
			this.WriteStartHelper(propertyName.EncodedUtf8Bytes, 91);
			this._tokenType = JsonTokenType.StartArray;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00018BDF File Offset: 0x00016DDF
		public void WriteStartObject(JsonEncodedText propertyName)
		{
			this.WriteStartHelper(propertyName.EncodedUtf8Bytes, 123);
			this._tokenType = JsonTokenType.StartObject;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00018BF7 File Offset: 0x00016DF7
		private void WriteStartHelper(ReadOnlySpan<byte> utf8PropertyName, byte token)
		{
			this.ValidateDepth();
			this.WriteStartByOptions(utf8PropertyName, token);
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00018C27 File Offset: 0x00016E27
		public void WriteStartArray(ReadOnlySpan<byte> utf8PropertyName)
		{
			this.ValidatePropertyNameAndDepth(utf8PropertyName);
			this.WriteStartEscape(utf8PropertyName, 91);
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
			this._tokenType = JsonTokenType.StartArray;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00018C60 File Offset: 0x00016E60
		public void WriteStartObject(ReadOnlySpan<byte> utf8PropertyName)
		{
			this.ValidatePropertyNameAndDepth(utf8PropertyName);
			this.WriteStartEscape(utf8PropertyName, 123);
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
			this._tokenType = JsonTokenType.StartObject;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00018C9C File Offset: 0x00016E9C
		private void WriteStartEscape(ReadOnlySpan<byte> utf8PropertyName, byte token)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStartEscapeProperty(utf8PropertyName, token, num);
				return;
			}
			this.WriteStartByOptions(utf8PropertyName, token);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00018CD1 File Offset: 0x00016ED1
		private void WriteStartByOptions(ReadOnlySpan<byte> utf8PropertyName, byte token)
		{
			this.ValidateWritingProperty(token);
			if (this._options.Indented)
			{
				this.WritePropertyNameIndented(utf8PropertyName, token);
				return;
			}
			this.WritePropertyNameMinimized(utf8PropertyName, token);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00018CF8 File Offset: 0x00016EF8
		private unsafe void WriteStartEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, byte token, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStartByOptions(destination.Slice(0, length), token);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00018D83 File Offset: 0x00016F83
		[NullableContext(1)]
		public void WriteStartArray(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteStartArray(propertyName.AsSpan());
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00018D9E File Offset: 0x00016F9E
		[NullableContext(1)]
		public void WriteStartObject(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteStartObject(propertyName.AsSpan());
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00018DB9 File Offset: 0x00016FB9
		public void WriteStartArray(ReadOnlySpan<char> propertyName)
		{
			this.ValidatePropertyNameAndDepth(propertyName);
			this.WriteStartEscape(propertyName, 91);
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
			this._tokenType = JsonTokenType.StartArray;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00018DF2 File Offset: 0x00016FF2
		public void WriteStartObject(ReadOnlySpan<char> propertyName)
		{
			this.ValidatePropertyNameAndDepth(propertyName);
			this.WriteStartEscape(propertyName, 123);
			this._currentDepth &= int.MaxValue;
			this._currentDepth++;
			this._tokenType = JsonTokenType.StartObject;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018E2C File Offset: 0x0001702C
		private void WriteStartEscape(ReadOnlySpan<char> propertyName, byte token)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStartEscapeProperty(propertyName, token, num);
				return;
			}
			this.WriteStartByOptions(propertyName, token);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00018E61 File Offset: 0x00017061
		private void WriteStartByOptions(ReadOnlySpan<char> propertyName, byte token)
		{
			this.ValidateWritingProperty(token);
			if (this._options.Indented)
			{
				this.WritePropertyNameIndented(propertyName, token);
				return;
			}
			this.WritePropertyNameMinimized(propertyName, token);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00018E88 File Offset: 0x00017088
		private unsafe void WriteStartEscapeProperty(ReadOnlySpan<char> propertyName, byte token, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStartByOptions(destination.Slice(0, length), token);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00018F13 File Offset: 0x00017113
		public void WriteEndArray()
		{
			this.WriteEnd(93);
			this._tokenType = JsonTokenType.EndArray;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00018F24 File Offset: 0x00017124
		public void WriteEndObject()
		{
			this.WriteEnd(125);
			this._tokenType = JsonTokenType.EndObject;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00018F35 File Offset: 0x00017135
		private void WriteEnd(byte token)
		{
			if (this._options.IndentedOrNotSkipValidation)
			{
				this.WriteEndSlow(token);
			}
			else
			{
				this.WriteEndMinimized(token);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			if (this.CurrentDepth != 0)
			{
				this._currentDepth--;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00018F70 File Offset: 0x00017170
		private unsafe void WriteEndMinimized(byte token)
		{
			if (this._memory.Length - this.BytesPending < 1)
			{
				this.Grow(1);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00018FBF File Offset: 0x000171BF
		private void WriteEndSlow(byte token)
		{
			if (this._options.Indented)
			{
				if (!this._options.SkipValidation)
				{
					this.ValidateEnd(token);
				}
				this.WriteEndIndented(token);
				return;
			}
			this.ValidateEnd(token);
			this.WriteEndMinimized(token);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00018FF8 File Offset: 0x000171F8
		private void ValidateEnd(byte token)
		{
			if (this._bitStack.CurrentDepth <= 0 || this._tokenType == JsonTokenType.PropertyName)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.MismatchedObjectArray, 0, this._options.MaxDepth, token, this._tokenType);
			}
			if (token == 93)
			{
				if (this._inObject)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.MismatchedObjectArray, 0, this._options.MaxDepth, token, this._tokenType);
				}
			}
			else if (!this._inObject)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.MismatchedObjectArray, 0, this._options.MaxDepth, token, this._tokenType);
			}
			this._inObject = this._bitStack.Pop();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00019094 File Offset: 0x00017294
		private unsafe void WriteEndIndented(byte token)
		{
			if (this._tokenType == JsonTokenType.StartObject || this._tokenType == JsonTokenType.StartArray)
			{
				this.WriteEndMinimized(token);
				return;
			}
			int num = this.Indentation;
			if (num != 0)
			{
				num -= this._indentLength;
			}
			int num2 = num + 3;
			if (this._memory.Length - this.BytesPending < num2)
			{
				this.Grow(num2);
			}
			Span<byte> span = this._memory.Span;
			this.WriteNewLine(span);
			this.WriteIndentation(span.Slice(this.BytesPending), num);
			this.BytesPending += num;
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00019140 File Offset: 0x00017340
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteNewLine(Span<byte> output)
		{
			int bytesPending;
			if (this._newLineLength == 2)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*output[bytesPending] = 13;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*output[bytesPending] = 10;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001918C File Offset: 0x0001738C
		private void WriteIndentation(Span<byte> buffer, int indent)
		{
			JsonWriterHelper.WriteIndentation(buffer, indent, this._indentByte);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001919B File Offset: 0x0001739B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UpdateBitStackOnStart(byte token)
		{
			if (token == 91)
			{
				this._bitStack.PushFalse();
				this._inObject = false;
				return;
			}
			this._bitStack.PushTrue();
			this._inObject = true;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000191C8 File Offset: 0x000173C8
		private void Grow(int requiredSize)
		{
			if (this._memory.Length == 0)
			{
				this.FirstCallToGetMemory(requiredSize);
				return;
			}
			int num = Math.Max(4096, requiredSize);
			if (this._stream != null)
			{
				int num2 = this.BytesPending + num;
				JsonHelpers.ValidateInt32MaxArrayLength((uint)num2);
				this._memory = this._arrayBufferWriter.GetMemory(num2);
				return;
			}
			this._output.Advance(this.BytesPending);
			this.BytesCommitted += (long)this.BytesPending;
			this.BytesPending = 0;
			this._memory = this._output.GetMemory(num);
			if (this._memory.Length < num)
			{
				ThrowHelper.ThrowInvalidOperationException_NeedLargerSpan();
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00019274 File Offset: 0x00017474
		private void FirstCallToGetMemory(int requiredSize)
		{
			int num = Math.Max(256, requiredSize);
			if (this._stream != null)
			{
				this._memory = this._arrayBufferWriter.GetMemory(num);
				return;
			}
			this._memory = this._output.GetMemory(num);
			if (this._memory.Length < num)
			{
				ThrowHelper.ThrowInvalidOperationException_NeedLargerSpan();
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000192CD File Offset: 0x000174CD
		private void SetFlagToAddListSeparatorBeforeNextItem()
		{
			this._currentDepth |= int.MinValue;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000192E4 File Offset: 0x000174E4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 3);
				defaultInterpolatedStringHandler.AppendLiteral("BytesCommitted = ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BytesCommitted);
				defaultInterpolatedStringHandler.AppendLiteral(" BytesPending = ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.BytesPending);
				defaultInterpolatedStringHandler.AppendLiteral(" CurrentDepth = ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentDepth);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00019350 File Offset: 0x00017550
		public void WriteBase64String(JsonEncodedText propertyName, ReadOnlySpan<byte> bytes)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteBase64ByOptions(encodedUtf8Bytes, bytes);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001937A File Offset: 0x0001757A
		public void WriteBase64String([Nullable(1)] string propertyName, ReadOnlySpan<byte> bytes)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteBase64String(propertyName.AsSpan(), bytes);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00019396 File Offset: 0x00017596
		public void WriteBase64String(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> bytes)
		{
			JsonWriterHelper.ValidatePropertyNameLength(propertyName);
			this.WriteBase64Escape(propertyName, bytes);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000193B3 File Offset: 0x000175B3
		public void WriteBase64String(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> bytes)
		{
			JsonWriterHelper.ValidatePropertyNameLength(utf8PropertyName);
			this.WriteBase64Escape(utf8PropertyName, bytes);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000193D0 File Offset: 0x000175D0
		private void WriteBase64Escape(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> bytes)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteBase64EscapeProperty(propertyName, bytes, num);
				return;
			}
			this.WriteBase64ByOptions(propertyName, bytes);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00019408 File Offset: 0x00017608
		private void WriteBase64Escape(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> bytes)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteBase64EscapeProperty(utf8PropertyName, bytes, num);
				return;
			}
			this.WriteBase64ByOptions(utf8PropertyName, bytes);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00019440 File Offset: 0x00017640
		private unsafe void WriteBase64EscapeProperty(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> bytes, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteBase64ByOptions(destination.Slice(0, length), bytes);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000194CC File Offset: 0x000176CC
		private unsafe void WriteBase64EscapeProperty(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> bytes, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteBase64ByOptions(destination.Slice(0, length), bytes);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00019557 File Offset: 0x00017757
		private void WriteBase64ByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> bytes)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteBase64Indented(propertyName, bytes);
				return;
			}
			this.WriteBase64Minimized(propertyName, bytes);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001957D File Offset: 0x0001777D
		private void WriteBase64ByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> bytes)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteBase64Indented(utf8PropertyName, bytes);
				return;
			}
			this.WriteBase64Minimized(utf8PropertyName, bytes);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000195A4 File Offset: 0x000177A4
		private unsafe void WriteBase64Minimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> bytes)
		{
			int maxEncodedToUtf8Length = Base64.GetMaxEncodedToUtf8Length(bytes.Length);
			int num = escapedPropertyName.Length * 3 + maxEncodedToUtf8Length + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000196B0 File Offset: 0x000178B0
		private unsafe void WriteBase64Minimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> bytes)
		{
			int maxEncodedToUtf8Length = Base64.GetMaxEncodedToUtf8Length(bytes.Length);
			int num = escapedPropertyName.Length + maxEncodedToUtf8Length + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000197DC File Offset: 0x000179DC
		private unsafe void WriteBase64Indented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> bytes)
		{
			int indentation = this.Indentation;
			int maxEncodedToUtf8Length = Base64.GetMaxEncodedToUtf8Length(bytes.Length);
			int num = indentation + escapedPropertyName.Length * 3 + maxEncodedToUtf8Length + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00019958 File Offset: 0x00017B58
		private unsafe void WriteBase64Indented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> bytes)
		{
			int indentation = this.Indentation;
			int maxEncodedToUtf8Length = Base64.GetMaxEncodedToUtf8Length(bytes.Length);
			int num = indentation + escapedPropertyName.Length + maxEncodedToUtf8Length + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00019AF4 File Offset: 0x00017CF4
		public void WriteString(JsonEncodedText propertyName, DateTime value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteStringByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00019B1E File Offset: 0x00017D1E
		[NullableContext(1)]
		public void WriteString(string propertyName, DateTime value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), value);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00019B3A File Offset: 0x00017D3A
		public void WriteString(ReadOnlySpan<char> propertyName, DateTime value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteStringEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00019B57 File Offset: 0x00017D57
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, DateTime value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteStringEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00019B74 File Offset: 0x00017D74
		private void WriteStringEscape(ReadOnlySpan<char> propertyName, DateTime value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteStringByOptions(propertyName, value);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00019BAC File Offset: 0x00017DAC
		private void WriteStringEscape(ReadOnlySpan<byte> utf8PropertyName, DateTime value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteStringByOptions(utf8PropertyName, value);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00019BE4 File Offset: 0x00017DE4
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<char> propertyName, DateTime value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00019C70 File Offset: 0x00017E70
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, DateTime value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00019CFB File Offset: 0x00017EFB
		private void WriteStringByOptions(ReadOnlySpan<char> propertyName, DateTime value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(propertyName, value);
				return;
			}
			this.WriteStringMinimized(propertyName, value);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00019D21 File Offset: 0x00017F21
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, DateTime value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8PropertyName, value);
				return;
			}
			this.WriteStringMinimized(utf8PropertyName, value);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00019D48 File Offset: 0x00017F48
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, DateTime value)
		{
			int num = escapedPropertyName.Length * 3 + 33 + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00019E64 File Offset: 0x00018064
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, DateTime value)
		{
			int num = escapedPropertyName.Length + 33 + 5 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00019FA0 File Offset: 0x000181A0
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, DateTime value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 33 + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001A12C File Offset: 0x0001832C
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, DateTime value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 33 + 6 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001A2D8 File Offset: 0x000184D8
		internal unsafe void WritePropertyName(DateTime value)
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)33], 33);
			int length;
			JsonWriterHelper.WriteDateTimeTrimmed(buffer, value, out length);
			this.WritePropertyNameUnescaped(buffer.Slice(0, length));
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001A310 File Offset: 0x00018510
		public void WriteString(JsonEncodedText propertyName, DateTimeOffset value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteStringByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001A33A File Offset: 0x0001853A
		[NullableContext(1)]
		public void WriteString(string propertyName, DateTimeOffset value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), value);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001A356 File Offset: 0x00018556
		public void WriteString(ReadOnlySpan<char> propertyName, DateTimeOffset value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteStringEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001A373 File Offset: 0x00018573
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, DateTimeOffset value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteStringEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001A390 File Offset: 0x00018590
		private void WriteStringEscape(ReadOnlySpan<char> propertyName, DateTimeOffset value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteStringByOptions(propertyName, value);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001A3C8 File Offset: 0x000185C8
		private void WriteStringEscape(ReadOnlySpan<byte> utf8PropertyName, DateTimeOffset value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteStringByOptions(utf8PropertyName, value);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001A400 File Offset: 0x00018600
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<char> propertyName, DateTimeOffset value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001A48C File Offset: 0x0001868C
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, DateTimeOffset value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001A517 File Offset: 0x00018717
		private void WriteStringByOptions(ReadOnlySpan<char> propertyName, DateTimeOffset value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(propertyName, value);
				return;
			}
			this.WriteStringMinimized(propertyName, value);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001A53D File Offset: 0x0001873D
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, DateTimeOffset value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8PropertyName, value);
				return;
			}
			this.WriteStringMinimized(utf8PropertyName, value);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001A564 File Offset: 0x00018764
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, DateTimeOffset value)
		{
			int num = escapedPropertyName.Length * 3 + 33 + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001A680 File Offset: 0x00018880
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, DateTimeOffset value)
		{
			int num = escapedPropertyName.Length + 33 + 5 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001A7BC File Offset: 0x000189BC
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, DateTimeOffset value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 33 + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001A948 File Offset: 0x00018B48
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, DateTimeOffset value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 33 + 6 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		internal unsafe void WritePropertyName(DateTimeOffset value)
		{
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)33], 33);
			int length;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(buffer, value, out length);
			this.WritePropertyNameUnescaped(buffer.Slice(0, length));
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public void WriteNumber(JsonEncodedText propertyName, decimal value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteNumberByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001AB56 File Offset: 0x00018D56
		[NullableContext(1)]
		public void WriteNumber(string propertyName, decimal value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), value);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001AB72 File Offset: 0x00018D72
		public void WriteNumber(ReadOnlySpan<char> propertyName, decimal value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteNumberEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001AB8F File Offset: 0x00018D8F
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, decimal value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteNumberEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001ABAC File Offset: 0x00018DAC
		private void WriteNumberEscape(ReadOnlySpan<char> propertyName, decimal value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(propertyName, value);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		private void WriteNumberEscape(ReadOnlySpan<byte> utf8PropertyName, decimal value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001AC1C File Offset: 0x00018E1C
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, decimal value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, decimal value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001AD33 File Offset: 0x00018F33
		private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, decimal value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(propertyName, value);
				return;
			}
			this.WriteNumberMinimized(propertyName, value);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001AD59 File Offset: 0x00018F59
		private void WriteNumberByOptions(ReadOnlySpan<byte> utf8PropertyName, decimal value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(utf8PropertyName, value);
				return;
			}
			this.WriteNumberMinimized(utf8PropertyName, value);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001AD80 File Offset: 0x00018F80
		private unsafe void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, decimal value)
		{
			int num = escapedPropertyName.Length * 3 + 31 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001AE70 File Offset: 0x00019070
		private unsafe void WriteNumberMinimized(ReadOnlySpan<byte> escapedPropertyName, decimal value)
		{
			int num = escapedPropertyName.Length + 31 + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001AF80 File Offset: 0x00019180
		private unsafe void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, decimal value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 31 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001B0DC File Offset: 0x000192DC
		private unsafe void WriteNumberIndented(ReadOnlySpan<byte> escapedPropertyName, decimal value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 31 + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001B258 File Offset: 0x00019458
		internal unsafe void WritePropertyName(decimal value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)31], 31);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001B29C File Offset: 0x0001949C
		public void WriteNumber(JsonEncodedText propertyName, double value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			JsonWriterHelper.ValidateDouble(value);
			this.WriteNumberByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001B2CC File Offset: 0x000194CC
		[NullableContext(1)]
		public void WriteNumber(string propertyName, double value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), value);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001B2E8 File Offset: 0x000194E8
		public void WriteNumber(ReadOnlySpan<char> propertyName, double value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			JsonWriterHelper.ValidateDouble(value);
			this.WriteNumberEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001B30B File Offset: 0x0001950B
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, double value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			JsonWriterHelper.ValidateDouble(value);
			this.WriteNumberEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001B330 File Offset: 0x00019530
		private void WriteNumberEscape(ReadOnlySpan<char> propertyName, double value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(propertyName, value);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001B368 File Offset: 0x00019568
		private void WriteNumberEscape(ReadOnlySpan<byte> utf8PropertyName, double value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001B3A0 File Offset: 0x000195A0
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, double value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001B42C File Offset: 0x0001962C
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, double value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001B4B7 File Offset: 0x000196B7
		private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, double value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(propertyName, value);
				return;
			}
			this.WriteNumberMinimized(propertyName, value);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001B4DD File Offset: 0x000196DD
		private void WriteNumberByOptions(ReadOnlySpan<byte> utf8PropertyName, double value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(utf8PropertyName, value);
				return;
			}
			this.WriteNumberMinimized(utf8PropertyName, value);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001B504 File Offset: 0x00019704
		private unsafe void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, double value)
		{
			int num = escapedPropertyName.Length * 3 + 128 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001B5EC File Offset: 0x000197EC
		private unsafe void WriteNumberMinimized(ReadOnlySpan<byte> escapedPropertyName, double value)
		{
			int num = escapedPropertyName.Length + 128 + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001B6F4 File Offset: 0x000198F4
		private unsafe void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, double value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 128 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0001B848 File Offset: 0x00019A48
		private unsafe void WriteNumberIndented(ReadOnlySpan<byte> escapedPropertyName, double value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 128 + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001B9BC File Offset: 0x00019BBC
		internal unsafe void WritePropertyName(double value)
		{
			JsonWriterHelper.ValidateDouble(value);
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			int length;
			Utf8JsonWriter.TryFormatDouble(value, destination, out length);
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001BA00 File Offset: 0x00019C00
		public void WriteNumber(JsonEncodedText propertyName, float value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			JsonWriterHelper.ValidateSingle(value);
			this.WriteNumberByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001BA30 File Offset: 0x00019C30
		[NullableContext(1)]
		public void WriteNumber(string propertyName, float value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), value);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001BA4C File Offset: 0x00019C4C
		public void WriteNumber(ReadOnlySpan<char> propertyName, float value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			JsonWriterHelper.ValidateSingle(value);
			this.WriteNumberEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001BA6F File Offset: 0x00019C6F
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, float value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			JsonWriterHelper.ValidateSingle(value);
			this.WriteNumberEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001BA94 File Offset: 0x00019C94
		private void WriteNumberEscape(ReadOnlySpan<char> propertyName, float value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(propertyName, value);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001BACC File Offset: 0x00019CCC
		private void WriteNumberEscape(ReadOnlySpan<byte> utf8PropertyName, float value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001BB04 File Offset: 0x00019D04
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, float value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001BB90 File Offset: 0x00019D90
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, float value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001BC1B File Offset: 0x00019E1B
		private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, float value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(propertyName, value);
				return;
			}
			this.WriteNumberMinimized(propertyName, value);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001BC41 File Offset: 0x00019E41
		private void WriteNumberByOptions(ReadOnlySpan<byte> utf8PropertyName, float value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(utf8PropertyName, value);
				return;
			}
			this.WriteNumberMinimized(utf8PropertyName, value);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001BC68 File Offset: 0x00019E68
		private unsafe void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, float value)
		{
			int num = escapedPropertyName.Length * 3 + 128 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001BD50 File Offset: 0x00019F50
		private unsafe void WriteNumberMinimized(ReadOnlySpan<byte> escapedPropertyName, float value)
		{
			int num = escapedPropertyName.Length + 128 + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001BE58 File Offset: 0x0001A058
		private unsafe void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, float value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 128 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001BFAC File Offset: 0x0001A1AC
		private unsafe void WriteNumberIndented(ReadOnlySpan<byte> escapedPropertyName, float value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 128 + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001C120 File Offset: 0x0001A320
		internal unsafe void WritePropertyName(float value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			int length;
			Utf8JsonWriter.TryFormatSingle(value, destination, out length);
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001C160 File Offset: 0x0001A360
		public void WriteString(JsonEncodedText propertyName, Guid value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteStringByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001C18A File Offset: 0x0001A38A
		[NullableContext(1)]
		public void WriteString(string propertyName, Guid value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), value);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001C1A6 File Offset: 0x0001A3A6
		public void WriteString(ReadOnlySpan<char> propertyName, Guid value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteStringEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001C1C3 File Offset: 0x0001A3C3
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, Guid value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteStringEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001C1E0 File Offset: 0x0001A3E0
		private void WriteStringEscape(ReadOnlySpan<char> propertyName, Guid value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteStringByOptions(propertyName, value);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001C218 File Offset: 0x0001A418
		private void WriteStringEscape(ReadOnlySpan<byte> utf8PropertyName, Guid value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteStringByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001C250 File Offset: 0x0001A450
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<char> propertyName, Guid value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		private unsafe void WriteStringEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, Guid value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001C367 File Offset: 0x0001A567
		private void WriteStringByOptions(ReadOnlySpan<char> propertyName, Guid value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(propertyName, value);
				return;
			}
			this.WriteStringMinimized(propertyName, value);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001C38D File Offset: 0x0001A58D
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, Guid value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8PropertyName, value);
				return;
			}
			this.WriteStringMinimized(utf8PropertyName, value);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, Guid value)
		{
			int num = escapedPropertyName.Length * 3 + 36 + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, Guid value)
		{
			int num = escapedPropertyName.Length + 36 + 5 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001C624 File Offset: 0x0001A824
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, Guid value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 36 + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001C7BC File Offset: 0x0001A9BC
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, Guid value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 36 + 6 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001C974 File Offset: 0x0001AB74
		internal unsafe void WritePropertyName(Guid value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)36], 36);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001C9B5 File Offset: 0x0001ABB5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ValidatePropertyNameAndDepth(ReadOnlySpan<char> propertyName)
		{
			if (propertyName.Length > 166666666 || this.CurrentDepth >= this._options.MaxDepth)
			{
				ThrowHelper.ThrowInvalidOperationOrArgumentException(propertyName, this._currentDepth, this._options.MaxDepth);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001C9EF File Offset: 0x0001ABEF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ValidatePropertyNameAndDepth(ReadOnlySpan<byte> utf8PropertyName)
		{
			if (utf8PropertyName.Length > 166666666 || this.CurrentDepth >= this._options.MaxDepth)
			{
				ThrowHelper.ThrowInvalidOperationOrArgumentException(utf8PropertyName, this._currentDepth, this._options.MaxDepth);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001CA29 File Offset: 0x0001AC29
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ValidateDepth()
		{
			if (this.CurrentDepth >= this._options.MaxDepth)
			{
				ThrowHelper.ThrowInvalidOperationException(this._currentDepth, this._options.MaxDepth);
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001CA54 File Offset: 0x0001AC54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ValidateWritingProperty()
		{
			if (!this._options.SkipValidation && (!this._inObject || this._tokenType == JsonTokenType.PropertyName))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotWritePropertyWithinArray, 0, this._options.MaxDepth, 0, this._tokenType);
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001CA90 File Offset: 0x0001AC90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ValidateWritingProperty(byte token)
		{
			if (!this._options.SkipValidation)
			{
				if (!this._inObject || this._tokenType == JsonTokenType.PropertyName)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotWritePropertyWithinArray, 0, this._options.MaxDepth, 0, this._tokenType);
				}
				this.UpdateBitStackOnStart(token);
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001CADC File Offset: 0x0001ACDC
		private unsafe void WritePropertyNameMinimized(ReadOnlySpan<byte> escapedPropertyName, byte token)
		{
			int num = escapedPropertyName.Length + 4 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		private unsafe void WritePropertyNameIndented(ReadOnlySpan<byte> escapedPropertyName, byte token)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 5 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001CD28 File Offset: 0x0001AF28
		private unsafe void WritePropertyNameMinimized(ReadOnlySpan<char> escapedPropertyName, byte token)
		{
			int num = escapedPropertyName.Length * 3 + 5;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001CE00 File Offset: 0x0001B000
		private unsafe void WritePropertyNameIndented(ReadOnlySpan<char> escapedPropertyName, byte token)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 6 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = token;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001CF34 File Offset: 0x0001B134
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void TranscodeAndWrite(ReadOnlySpan<char> escapedPropertyName, Span<byte> output)
		{
			int num;
			JsonWriterHelper.ToUtf8(escapedPropertyName, output.Slice(this.BytesPending), out num);
			this.BytesPending += num;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001CF65 File Offset: 0x0001B165
		public void WriteNull(JsonEncodedText propertyName)
		{
			this.WriteLiteralHelper(propertyName.EncodedUtf8Bytes, JsonConstants.NullValue);
			this._tokenType = JsonTokenType.Null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001CF84 File Offset: 0x0001B184
		internal void WriteNullSection(ReadOnlySpan<byte> escapedPropertyNameSection)
		{
			if (this._options.Indented)
			{
				ReadOnlySpan<byte> utf8PropertyName = escapedPropertyNameSection.Slice(1, escapedPropertyNameSection.Length - 3);
				this.WriteLiteralHelper(utf8PropertyName, JsonConstants.NullValue);
				this._tokenType = JsonTokenType.Null;
				return;
			}
			ReadOnlySpan<byte> nullValue = JsonConstants.NullValue;
			this.WriteLiteralSection(escapedPropertyNameSection, nullValue);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001CFE1 File Offset: 0x0001B1E1
		private void WriteLiteralHelper(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value)
		{
			this.WriteLiteralByOptions(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001CFF1 File Offset: 0x0001B1F1
		[NullableContext(1)]
		public void WriteNull(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNull(propertyName.AsSpan());
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001D00C File Offset: 0x0001B20C
		public void WriteNull(ReadOnlySpan<char> propertyName)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			ReadOnlySpan<byte> nullValue = JsonConstants.NullValue;
			this.WriteLiteralEscape(propertyName, nullValue);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001D03C File Offset: 0x0001B23C
		public void WriteNull(ReadOnlySpan<byte> utf8PropertyName)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			ReadOnlySpan<byte> nullValue = JsonConstants.NullValue;
			this.WriteLiteralEscape(utf8PropertyName, nullValue);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001D06B File Offset: 0x0001B26B
		public void WriteBoolean(JsonEncodedText propertyName, bool value)
		{
			if (value)
			{
				this.WriteLiteralHelper(propertyName.EncodedUtf8Bytes, JsonConstants.TrueValue);
				this._tokenType = JsonTokenType.True;
				return;
			}
			this.WriteLiteralHelper(propertyName.EncodedUtf8Bytes, JsonConstants.FalseValue);
			this._tokenType = JsonTokenType.False;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001D0A5 File Offset: 0x0001B2A5
		[NullableContext(1)]
		public void WriteBoolean(string propertyName, bool value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteBoolean(propertyName.AsSpan(), value);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		public void WriteBoolean(ReadOnlySpan<char> propertyName, bool value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			ReadOnlySpan<byte> value2 = value ? JsonConstants.TrueValue : JsonConstants.FalseValue;
			this.WriteLiteralEscape(propertyName, value2);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = (value ? JsonTokenType.True : JsonTokenType.False);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001D104 File Offset: 0x0001B304
		public void WriteBoolean(ReadOnlySpan<byte> utf8PropertyName, bool value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			ReadOnlySpan<byte> value2 = value ? JsonConstants.TrueValue : JsonConstants.FalseValue;
			this.WriteLiteralEscape(utf8PropertyName, value2);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = (value ? JsonTokenType.True : JsonTokenType.False);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001D144 File Offset: 0x0001B344
		private void WriteLiteralEscape(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteLiteralEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteLiteralByOptions(propertyName, value);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001D17C File Offset: 0x0001B37C
		private void WriteLiteralEscape(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteLiteralEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteLiteralByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		private unsafe void WriteLiteralEscapeProperty(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteLiteralByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001D240 File Offset: 0x0001B440
		private unsafe void WriteLiteralEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteLiteralByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001D2CB File Offset: 0x0001B4CB
		private void WriteLiteralByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteLiteralIndented(propertyName, value);
				return;
			}
			this.WriteLiteralMinimized(propertyName, value);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001D2F1 File Offset: 0x0001B4F1
		private void WriteLiteralByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteLiteralIndented(utf8PropertyName, value);
				return;
			}
			this.WriteLiteralMinimized(utf8PropertyName, value);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001D318 File Offset: 0x0001B518
		private unsafe void WriteLiteralMinimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> value)
		{
			int num = escapedPropertyName.Length * 3 + value.Length + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += value.Length;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001D408 File Offset: 0x0001B608
		private unsafe void WriteLiteralMinimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> value)
		{
			int num = escapedPropertyName.Length + value.Length + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += value.Length;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001D518 File Offset: 0x0001B718
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteLiteralSection(ReadOnlySpan<byte> escapedPropertyNameSection, ReadOnlySpan<byte> value)
		{
			int num = escapedPropertyNameSection.Length + value.Length + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			escapedPropertyNameSection.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyNameSection.Length;
			value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += value.Length;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
		private unsafe void WriteLiteralIndented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + value.Length + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += value.Length;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001D720 File Offset: 0x0001B920
		private unsafe void WriteLiteralIndented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + value.Length + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += value.Length;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001D88C File Offset: 0x0001BA8C
		internal unsafe void WritePropertyName(bool value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)5], 5);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001D8CC File Offset: 0x0001BACC
		public void WriteNumber(JsonEncodedText propertyName, long value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteNumberByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001D8F6 File Offset: 0x0001BAF6
		[NullableContext(1)]
		public void WriteNumber(string propertyName, long value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), value);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001D912 File Offset: 0x0001BB12
		public void WriteNumber(ReadOnlySpan<char> propertyName, long value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteNumberEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001D92F File Offset: 0x0001BB2F
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, long value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteNumberEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001D94C File Offset: 0x0001BB4C
		public void WriteNumber(JsonEncodedText propertyName, int value)
		{
			this.WriteNumber(propertyName, (long)value);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001D957 File Offset: 0x0001BB57
		[NullableContext(1)]
		public void WriteNumber(string propertyName, int value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), (long)value);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001D974 File Offset: 0x0001BB74
		public void WriteNumber(ReadOnlySpan<char> propertyName, int value)
		{
			this.WriteNumber(propertyName, (long)value);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001D97F File Offset: 0x0001BB7F
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, int value)
		{
			this.WriteNumber(utf8PropertyName, (long)value);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001D98C File Offset: 0x0001BB8C
		private void WriteNumberEscape(ReadOnlySpan<char> propertyName, long value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(propertyName, value);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		private void WriteNumberEscape(ReadOnlySpan<byte> utf8PropertyName, long value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(utf8PropertyName, value);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, long value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001DA88 File Offset: 0x0001BC88
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, long value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001DB13 File Offset: 0x0001BD13
		private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, long value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(propertyName, value);
				return;
			}
			this.WriteNumberMinimized(propertyName, value);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001DB39 File Offset: 0x0001BD39
		private void WriteNumberByOptions(ReadOnlySpan<byte> utf8PropertyName, long value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(utf8PropertyName, value);
				return;
			}
			this.WriteNumberMinimized(utf8PropertyName, value);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001DB60 File Offset: 0x0001BD60
		private unsafe void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, long value)
		{
			int num = escapedPropertyName.Length * 3 + 20 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001DC50 File Offset: 0x0001BE50
		private unsafe void WriteNumberMinimized(ReadOnlySpan<byte> escapedPropertyName, long value)
		{
			int num = escapedPropertyName.Length + 20 + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001DD60 File Offset: 0x0001BF60
		private unsafe void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, long value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 20 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		private unsafe void WriteNumberIndented(ReadOnlySpan<byte> escapedPropertyName, long value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 20 + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001E036 File Offset: 0x0001C236
		internal void WritePropertyName(int value)
		{
			this.WritePropertyName((long)value);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001E040 File Offset: 0x0001C240
		internal unsafe void WritePropertyName(long value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001E081 File Offset: 0x0001C281
		public void WritePropertyName(JsonEncodedText propertyName)
		{
			this.WritePropertyNameHelper(propertyName.EncodedUtf8Bytes);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001E090 File Offset: 0x0001C290
		internal void WritePropertyNameSection(ReadOnlySpan<byte> escapedPropertyNameSection)
		{
			if (this._options.Indented)
			{
				ReadOnlySpan<byte> utf8PropertyName = escapedPropertyNameSection.Slice(1, escapedPropertyNameSection.Length - 3);
				this.WritePropertyNameHelper(utf8PropertyName);
				return;
			}
			this.WriteStringPropertyNameSection(escapedPropertyNameSection);
			this._currentDepth &= int.MaxValue;
			this._tokenType = JsonTokenType.PropertyName;
			this._commentAfterNoneOrPropertyName = false;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001E0EB File Offset: 0x0001C2EB
		private void WritePropertyNameHelper(ReadOnlySpan<byte> utf8PropertyName)
		{
			this.WriteStringByOptionsPropertyName(utf8PropertyName);
			this._currentDepth &= int.MaxValue;
			this._tokenType = JsonTokenType.PropertyName;
			this._commentAfterNoneOrPropertyName = false;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001E114 File Offset: 0x0001C314
		[NullableContext(1)]
		public void WritePropertyName(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WritePropertyName(propertyName.AsSpan());
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001E130 File Offset: 0x0001C330
		public void WritePropertyName(ReadOnlySpan<char> propertyName)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(propertyName, num);
			}
			else
			{
				this.WriteStringByOptionsPropertyName(propertyName);
			}
			this._currentDepth &= int.MaxValue;
			this._tokenType = JsonTokenType.PropertyName;
			this._commentAfterNoneOrPropertyName = false;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001E18C File Offset: 0x0001C38C
		private unsafe void WriteStringEscapeProperty([ScopedRef] ReadOnlySpan<char> propertyName, int firstEscapeIndexProp)
		{
			char[] array = null;
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
				Span<char> destination;
				if (maxEscapedLength > 128)
				{
					array = ArrayPool<char>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				}
				int length;
				JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
				propertyName = destination.Slice(0, length);
			}
			this.WriteStringByOptionsPropertyName(propertyName);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001E218 File Offset: 0x0001C418
		private void WriteStringByOptionsPropertyName(ReadOnlySpan<char> propertyName)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndentedPropertyName(propertyName);
				return;
			}
			this.WriteStringMinimizedPropertyName(propertyName);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001E23C File Offset: 0x0001C43C
		private unsafe void WriteStringMinimizedPropertyName(ReadOnlySpan<char> escapedPropertyName)
		{
			int num = escapedPropertyName.Length * 3 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		private unsafe void WriteStringIndentedPropertyName(ReadOnlySpan<char> escapedPropertyName)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001E418 File Offset: 0x0001C618
		public void WritePropertyName(ReadOnlySpan<byte> utf8PropertyName)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeProperty(utf8PropertyName, num);
			}
			else
			{
				this.WriteStringByOptionsPropertyName(utf8PropertyName);
			}
			this._currentDepth &= int.MaxValue;
			this._tokenType = JsonTokenType.PropertyName;
			this._commentAfterNoneOrPropertyName = false;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0001E472 File Offset: 0x0001C672
		private void WritePropertyNameUnescaped(ReadOnlySpan<byte> utf8PropertyName)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteStringByOptionsPropertyName(utf8PropertyName);
			this._currentDepth &= int.MaxValue;
			this._tokenType = JsonTokenType.PropertyName;
			this._commentAfterNoneOrPropertyName = false;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		private unsafe void WriteStringEscapeProperty([ScopedRef] ReadOnlySpan<byte> utf8PropertyName, int firstEscapeIndexProp)
		{
			byte[] array = null;
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
				Span<byte> destination;
				if (maxEscapedLength > 256)
				{
					array = ArrayPool<byte>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				int length;
				JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
				utf8PropertyName = destination.Slice(0, length);
			}
			this.WriteStringByOptionsPropertyName(utf8PropertyName);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001E530 File Offset: 0x0001C730
		private void WriteStringByOptionsPropertyName(ReadOnlySpan<byte> utf8PropertyName)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndentedPropertyName(utf8PropertyName);
				return;
			}
			this.WriteStringMinimizedPropertyName(utf8PropertyName);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001E554 File Offset: 0x0001C754
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteStringMinimizedPropertyName(ReadOnlySpan<byte> escapedPropertyName)
		{
			int num = escapedPropertyName.Length + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001E634 File Offset: 0x0001C834
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteStringPropertyNameSection(ReadOnlySpan<byte> escapedPropertyNameSection)
		{
			int num = escapedPropertyNameSection.Length + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			escapedPropertyNameSection.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyNameSection.Length;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteStringIndentedPropertyName(ReadOnlySpan<byte> escapedPropertyName)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001E7FA File Offset: 0x0001C9FA
		public void WriteString(JsonEncodedText propertyName, JsonEncodedText value)
		{
			this.WriteStringHelper(propertyName.EncodedUtf8Bytes, value.EncodedUtf8Bytes);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001E810 File Offset: 0x0001CA10
		private void WriteStringHelper(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			this.WriteStringByOptions(utf8PropertyName, utf8Value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001E827 File Offset: 0x0001CA27
		[NullableContext(1)]
		public void WriteString(string propertyName, JsonEncodedText value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), value);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001E843 File Offset: 0x0001CA43
		[NullableContext(1)]
		public void WriteString(string propertyName, [Nullable(2)] string value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			if (value == null)
			{
				this.WriteNull(propertyName.AsSpan());
				return;
			}
			this.WriteString(propertyName.AsSpan(), value.AsSpan());
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001E874 File Offset: 0x0001CA74
		public void WriteString(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value)
		{
			JsonWriterHelper.ValidatePropertyAndValue(propertyName, value);
			this.WriteStringEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001E892 File Offset: 0x0001CA92
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidatePropertyAndValue(utf8PropertyName, utf8Value);
			this.WriteStringEscape(utf8PropertyName, utf8Value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		[NullableContext(2)]
		public void WriteString(JsonEncodedText propertyName, string value)
		{
			if (value == null)
			{
				this.WriteNull(propertyName);
				return;
			}
			this.WriteString(propertyName, value.AsSpan());
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001E8CA File Offset: 0x0001CACA
		public void WriteString(JsonEncodedText propertyName, ReadOnlySpan<char> value)
		{
			this.WriteStringHelperEscapeValue(propertyName.EncodedUtf8Bytes, value);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001E8DC File Offset: 0x0001CADC
		private void WriteStringHelperEscapeValue(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value)
		{
			JsonWriterHelper.ValidateValue(value);
			int num = JsonWriterHelper.NeedsEscaping(value, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeValueOnly(utf8PropertyName, value, num);
			}
			else
			{
				this.WriteStringByOptions(utf8PropertyName, value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001E925 File Offset: 0x0001CB25
		public void WriteString([Nullable(1)] string propertyName, ReadOnlySpan<char> value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), value);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001E941 File Offset: 0x0001CB41
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value)
		{
			JsonWriterHelper.ValidatePropertyAndValue(utf8PropertyName, value);
			this.WriteStringEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001E95F File Offset: 0x0001CB5F
		public void WriteString(JsonEncodedText propertyName, ReadOnlySpan<byte> utf8Value)
		{
			this.WriteStringHelperEscapeValue(propertyName.EncodedUtf8Bytes, utf8Value);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001E970 File Offset: 0x0001CB70
		private void WriteStringHelperEscapeValue(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidateValue(utf8Value);
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeValueOnly(utf8PropertyName, utf8Value, num);
			}
			else
			{
				this.WriteStringByOptions(utf8PropertyName, utf8Value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001E9B9 File Offset: 0x0001CBB9
		public void WriteString([Nullable(1)] string propertyName, ReadOnlySpan<byte> utf8Value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteString(propertyName.AsSpan(), utf8Value);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001E9D5 File Offset: 0x0001CBD5
		public void WriteString(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidatePropertyAndValue(propertyName, utf8Value);
			this.WriteStringEscape(propertyName, utf8Value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001E9F3 File Offset: 0x0001CBF3
		public void WriteString(ReadOnlySpan<char> propertyName, JsonEncodedText value)
		{
			this.WriteStringHelperEscapeProperty(propertyName, value.EncodedUtf8Bytes);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001EA04 File Offset: 0x0001CC04
		private void WriteStringHelperEscapeProperty(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapePropertyOnly(propertyName, utf8Value, num);
			}
			else
			{
				this.WriteStringByOptions(propertyName, utf8Value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001EA4D File Offset: 0x0001CC4D
		public void WriteString(ReadOnlySpan<char> propertyName, [Nullable(2)] string value)
		{
			if (value == null)
			{
				this.WriteNull(propertyName);
				return;
			}
			this.WriteString(propertyName, value.AsSpan());
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001EA67 File Offset: 0x0001CC67
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, JsonEncodedText value)
		{
			this.WriteStringHelperEscapeProperty(utf8PropertyName, value.EncodedUtf8Bytes);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001EA78 File Offset: 0x0001CC78
		private void WriteStringHelperEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapePropertyOnly(utf8PropertyName, utf8Value, num);
			}
			else
			{
				this.WriteStringByOptions(utf8PropertyName, utf8Value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001EAC1 File Offset: 0x0001CCC1
		public void WriteString(ReadOnlySpan<byte> utf8PropertyName, [Nullable(2)] string value)
		{
			if (value == null)
			{
				this.WriteNull(utf8PropertyName);
				return;
			}
			this.WriteString(utf8PropertyName, value.AsSpan());
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001EADC File Offset: 0x0001CCDC
		private unsafe void WriteStringEscapeValueOnly(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> utf8Value, int firstEscapeIndex)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndex);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndex, this._options.Encoder, out length);
			this.WriteStringByOptions(escapedPropertyName, destination.Slice(0, length));
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001EB68 File Offset: 0x0001CD68
		private unsafe void WriteStringEscapeValueOnly(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> value, int firstEscapeIndex)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(value.Length, firstEscapeIndex);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(value, destination, firstEscapeIndex, this._options.Encoder, out length);
			this.WriteStringByOptions(escapedPropertyName, destination.Slice(0, length));
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001EBF4 File Offset: 0x0001CDF4
		private unsafe void WriteStringEscapePropertyOnly(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> escapedValue, int firstEscapeIndex)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndex);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndex, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), escapedValue);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001EC80 File Offset: 0x0001CE80
		private unsafe void WriteStringEscapePropertyOnly(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> escapedValue, int firstEscapeIndex)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndex);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndex, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length), escapedValue);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001ED0C File Offset: 0x0001CF0C
		private void WriteStringEscape(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value)
		{
			int num = JsonWriterHelper.NeedsEscaping(value, this._options.Encoder);
			int num2 = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num + num2 != -2)
			{
				this.WriteStringEscapePropertyOrValue(propertyName, value, num2, num);
				return;
			}
			this.WriteStringByOptions(propertyName, value);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001ED58 File Offset: 0x0001CF58
		private void WriteStringEscape(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, this._options.Encoder);
			int num2 = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num + num2 != -2)
			{
				this.WriteStringEscapePropertyOrValue(utf8PropertyName, utf8Value, num2, num);
				return;
			}
			this.WriteStringByOptions(utf8PropertyName, utf8Value);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		private void WriteStringEscape(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> utf8Value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, this._options.Encoder);
			int num2 = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num + num2 != -2)
			{
				this.WriteStringEscapePropertyOrValue(propertyName, utf8Value, num2, num);
				return;
			}
			this.WriteStringByOptions(propertyName, utf8Value);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
		private void WriteStringEscape(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value)
		{
			int num = JsonWriterHelper.NeedsEscaping(value, this._options.Encoder);
			int num2 = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num + num2 != -2)
			{
				this.WriteStringEscapePropertyOrValue(utf8PropertyName, value, num2, num);
				return;
			}
			this.WriteStringByOptions(utf8PropertyName, value);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001EE3C File Offset: 0x0001D03C
		private unsafe void WriteStringEscapePropertyOrValue([ScopedRef] ReadOnlySpan<char> propertyName, [ScopedRef] ReadOnlySpan<char> value, int firstEscapeIndexProp, int firstEscapeIndexVal)
		{
			char[] array = null;
			char[] array2 = null;
			if (firstEscapeIndexVal != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(value.Length, firstEscapeIndexVal);
				Span<char> destination;
				if (maxEscapedLength > 128)
				{
					array = ArrayPool<char>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				}
				int length;
				JsonWriterHelper.EscapeString(value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
				value = destination.Slice(0, length);
			}
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength2 = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
				Span<char> destination2;
				if (maxEscapedLength2 > 128)
				{
					array2 = ArrayPool<char>.Shared.Rent(maxEscapedLength2);
					destination2 = array2;
				}
				else
				{
					destination2 = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				}
				int length2;
				JsonWriterHelper.EscapeString(propertyName, destination2, firstEscapeIndexProp, this._options.Encoder, out length2);
				propertyName = destination2.Slice(0, length2);
			}
			this.WriteStringByOptions(propertyName, value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			if (array2 != null)
			{
				ArrayPool<char>.Shared.Return(array2, false);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001EF4C File Offset: 0x0001D14C
		private unsafe void WriteStringEscapePropertyOrValue([ScopedRef] ReadOnlySpan<byte> utf8PropertyName, [ScopedRef] ReadOnlySpan<byte> utf8Value, int firstEscapeIndexProp, int firstEscapeIndexVal)
		{
			byte[] array = null;
			byte[] array2 = null;
			if (firstEscapeIndexVal != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndexVal);
				Span<byte> destination;
				if (maxEscapedLength > 256)
				{
					array = ArrayPool<byte>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				int length;
				JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
				utf8Value = destination.Slice(0, length);
			}
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength2 = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
				Span<byte> destination2;
				if (maxEscapedLength2 > 256)
				{
					array2 = ArrayPool<byte>.Shared.Rent(maxEscapedLength2);
					destination2 = array2;
				}
				else
				{
					destination2 = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				int length2;
				JsonWriterHelper.EscapeString(utf8PropertyName, destination2, firstEscapeIndexProp, this._options.Encoder, out length2);
				utf8PropertyName = destination2.Slice(0, length2);
			}
			this.WriteStringByOptions(utf8PropertyName, utf8Value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (array2 != null)
			{
				ArrayPool<byte>.Shared.Return(array2, false);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001F05C File Offset: 0x0001D25C
		private unsafe void WriteStringEscapePropertyOrValue([ScopedRef] ReadOnlySpan<char> propertyName, [ScopedRef] ReadOnlySpan<byte> utf8Value, int firstEscapeIndexProp, int firstEscapeIndexVal)
		{
			byte[] array = null;
			char[] array2 = null;
			if (firstEscapeIndexVal != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndexVal);
				Span<byte> destination;
				if (maxEscapedLength > 256)
				{
					array = ArrayPool<byte>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				int length;
				JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
				utf8Value = destination.Slice(0, length);
			}
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength2 = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
				Span<char> destination2;
				if (maxEscapedLength2 > 128)
				{
					array2 = ArrayPool<char>.Shared.Rent(maxEscapedLength2);
					destination2 = array2;
				}
				else
				{
					destination2 = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				}
				int length2;
				JsonWriterHelper.EscapeString(propertyName, destination2, firstEscapeIndexProp, this._options.Encoder, out length2);
				propertyName = destination2.Slice(0, length2);
			}
			this.WriteStringByOptions(propertyName, utf8Value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (array2 != null)
			{
				ArrayPool<char>.Shared.Return(array2, false);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001F16C File Offset: 0x0001D36C
		private unsafe void WriteStringEscapePropertyOrValue([ScopedRef] ReadOnlySpan<byte> utf8PropertyName, [ScopedRef] ReadOnlySpan<char> value, int firstEscapeIndexProp, int firstEscapeIndexVal)
		{
			char[] array = null;
			byte[] array2 = null;
			if (firstEscapeIndexVal != -1)
			{
				int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(value.Length, firstEscapeIndexVal);
				Span<char> destination;
				if (maxEscapedLength > 128)
				{
					array = ArrayPool<char>.Shared.Rent(maxEscapedLength);
					destination = array;
				}
				else
				{
					destination = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
				}
				int length;
				JsonWriterHelper.EscapeString(value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
				value = destination.Slice(0, length);
			}
			if (firstEscapeIndexProp != -1)
			{
				int maxEscapedLength2 = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
				Span<byte> destination2;
				if (maxEscapedLength2 > 256)
				{
					array2 = ArrayPool<byte>.Shared.Rent(maxEscapedLength2);
					destination2 = array2;
				}
				else
				{
					destination2 = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
				}
				int length2;
				JsonWriterHelper.EscapeString(utf8PropertyName, destination2, firstEscapeIndexProp, this._options.Encoder, out length2);
				utf8PropertyName = destination2.Slice(0, length2);
			}
			this.WriteStringByOptions(utf8PropertyName, value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			if (array2 != null)
			{
				ArrayPool<byte>.Shared.Return(array2, false);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001F27C File Offset: 0x0001D47C
		private void WriteStringByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(propertyName, value);
				return;
			}
			this.WriteStringMinimized(propertyName, value);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001F2A2 File Offset: 0x0001D4A2
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<byte> utf8Value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8PropertyName, utf8Value);
				return;
			}
			this.WriteStringMinimized(utf8PropertyName, utf8Value);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001F2C8 File Offset: 0x0001D4C8
		private void WriteStringByOptions(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> utf8Value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(propertyName, utf8Value);
				return;
			}
			this.WriteStringMinimized(propertyName, utf8Value);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001F2EE File Offset: 0x0001D4EE
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8PropertyName, ReadOnlySpan<char> value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8PropertyName, value);
				return;
			}
			this.WriteStringMinimized(utf8PropertyName, value);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001F314 File Offset: 0x0001D514
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<char> escapedValue)
		{
			int num = (escapedPropertyName.Length + escapedValue.Length) * 3 + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001F418 File Offset: 0x0001D618
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> escapedValue)
		{
			int num = escapedPropertyName.Length + escapedValue.Length + 5 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001F55C File Offset: 0x0001D75C
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> escapedValue)
		{
			int num = escapedPropertyName.Length * 3 + escapedValue.Length + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001F680 File Offset: 0x0001D880
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> escapedValue)
		{
			int num = escapedValue.Length * 3 + escapedPropertyName.Length + 6;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<char> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + (escapedPropertyName.Length + escapedValue.Length) * 3 + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001F904 File Offset: 0x0001DB04
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<byte> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + escapedValue.Length + 6 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedPropertyName, ReadOnlySpan<byte> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + escapedValue.Length + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001FC24 File Offset: 0x0001DE24
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedPropertyName, ReadOnlySpan<char> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedValue.Length * 3 + escapedPropertyName.Length + 7 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		[CLSCompliant(false)]
		public void WriteNumber(JsonEncodedText propertyName, ulong value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = propertyName.EncodedUtf8Bytes;
			this.WriteNumberByOptions(encodedUtf8Bytes, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001FDCE File Offset: 0x0001DFCE
		[NullableContext(1)]
		[CLSCompliant(false)]
		public void WriteNumber(string propertyName, ulong value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), value);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001FDEA File Offset: 0x0001DFEA
		[CLSCompliant(false)]
		public void WriteNumber(ReadOnlySpan<char> propertyName, ulong value)
		{
			JsonWriterHelper.ValidateProperty(propertyName);
			this.WriteNumberEscape(propertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001FE07 File Offset: 0x0001E007
		[CLSCompliant(false)]
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, ulong value)
		{
			JsonWriterHelper.ValidateProperty(utf8PropertyName);
			this.WriteNumberEscape(utf8PropertyName, value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001FE24 File Offset: 0x0001E024
		[CLSCompliant(false)]
		public void WriteNumber(JsonEncodedText propertyName, uint value)
		{
			this.WriteNumber(propertyName, (ulong)value);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001FE2F File Offset: 0x0001E02F
		[NullableContext(1)]
		[CLSCompliant(false)]
		public void WriteNumber(string propertyName, uint value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.WriteNumber(propertyName.AsSpan(), (ulong)value);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001FE4C File Offset: 0x0001E04C
		[CLSCompliant(false)]
		public void WriteNumber(ReadOnlySpan<char> propertyName, uint value)
		{
			this.WriteNumber(propertyName, (ulong)value);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001FE57 File Offset: 0x0001E057
		[CLSCompliant(false)]
		public void WriteNumber(ReadOnlySpan<byte> utf8PropertyName, uint value)
		{
			this.WriteNumber(utf8PropertyName, (ulong)value);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001FE64 File Offset: 0x0001E064
		private void WriteNumberEscape(ReadOnlySpan<char> propertyName, ulong value)
		{
			int num = JsonWriterHelper.NeedsEscaping(propertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(propertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(propertyName, value);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001FE9C File Offset: 0x0001E09C
		private void WriteNumberEscape(ReadOnlySpan<byte> utf8PropertyName, ulong value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8PropertyName, this._options.Encoder);
			if (num != -1)
			{
				this.WriteNumberEscapeProperty(utf8PropertyName, value, num);
				return;
			}
			this.WriteNumberByOptions(utf8PropertyName, value);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<char> propertyName, ulong value, int firstEscapeIndexProp)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(propertyName.Length, firstEscapeIndexProp);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(propertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001FF60 File Offset: 0x0001E160
		private unsafe void WriteNumberEscapeProperty(ReadOnlySpan<byte> utf8PropertyName, ulong value, int firstEscapeIndexProp)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8PropertyName.Length, firstEscapeIndexProp);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8PropertyName, destination, firstEscapeIndexProp, this._options.Encoder, out length);
			this.WriteNumberByOptions(destination.Slice(0, length), value);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001FFEB File Offset: 0x0001E1EB
		private void WriteNumberByOptions(ReadOnlySpan<char> propertyName, ulong value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(propertyName, value);
				return;
			}
			this.WriteNumberMinimized(propertyName, value);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00020011 File Offset: 0x0001E211
		private void WriteNumberByOptions(ReadOnlySpan<byte> utf8PropertyName, ulong value)
		{
			this.ValidateWritingProperty();
			if (this._options.Indented)
			{
				this.WriteNumberIndented(utf8PropertyName, value);
				return;
			}
			this.WriteNumberMinimized(utf8PropertyName, value);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00020038 File Offset: 0x0001E238
		private unsafe void WriteNumberMinimized(ReadOnlySpan<char> escapedPropertyName, ulong value)
		{
			int num = escapedPropertyName.Length * 3 + 20 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00020128 File Offset: 0x0001E328
		private unsafe void WriteNumberMinimized(ReadOnlySpan<byte> escapedPropertyName, ulong value)
		{
			int num = escapedPropertyName.Length + 20 + 3 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00020238 File Offset: 0x0001E438
		private unsafe void WriteNumberIndented(ReadOnlySpan<char> escapedPropertyName, ulong value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length * 3 + 20 + 5 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedPropertyName, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00020394 File Offset: 0x0001E594
		private unsafe void WriteNumberIndented(ReadOnlySpan<byte> escapedPropertyName, ulong value)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedPropertyName.Length + 20 + 4 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.None)
			{
				this.WriteNewLine(span);
			}
			this.WriteIndentation(span.Slice(this.BytesPending), indentation);
			this.BytesPending += indentation;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedPropertyName.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedPropertyName.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 58;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 32;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002050E File Offset: 0x0001E70E
		internal void WritePropertyName(uint value)
		{
			this.WritePropertyName((ulong)value);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00020518 File Offset: 0x0001E718
		internal unsafe void WritePropertyName(ulong value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WritePropertyNameUnescaped(destination.Slice(0, length));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00020559 File Offset: 0x0001E759
		public void WriteBase64StringValue(ReadOnlySpan<byte> bytes)
		{
			this.WriteBase64ByOptions(bytes);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0002056F File Offset: 0x0001E76F
		private void WriteBase64ByOptions(ReadOnlySpan<byte> bytes)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteBase64Indented(bytes);
				return;
			}
			this.WriteBase64Minimized(bytes);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000205A0 File Offset: 0x0001E7A0
		private unsafe void WriteBase64Minimized(ReadOnlySpan<byte> bytes)
		{
			if (bytes.Length > 1610612733)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge((long)bytes.Length);
			}
			int num = Base64.GetMaxEncodedToUtf8Length(bytes.Length) + 3;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00020664 File Offset: 0x0001E864
		private unsafe void WriteBase64Indented(ReadOnlySpan<byte> bytes)
		{
			int indentation = this.Indentation;
			int num = indentation + 3 + this._newLineLength;
			int num2 = 1610612733 - num;
			if (bytes.Length > num2)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge((long)bytes.Length);
			}
			int num3 = Base64.GetMaxEncodedToUtf8Length(bytes.Length) + num;
			if (this._memory.Length - this.BytesPending < num3)
			{
				this.Grow(num3);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.Base64EncodeAndWrite(bytes, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00020781 File Offset: 0x0001E981
		private unsafe static ReadOnlySpan<byte> SingleLineCommentDelimiterUtf8
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.BCCD0BA7F848775347BA9B64603DDEAC80563D9BFC8FB67AF20A7FB468DF6FD4), 2);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002078E File Offset: 0x0001E98E
		[NullableContext(1)]
		public void WriteCommentValue(string value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			this.WriteCommentValue(value.AsSpan());
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000207AC File Offset: 0x0001E9AC
		public void WriteCommentValue(ReadOnlySpan<char> value)
		{
			JsonWriterHelper.ValidateValue(value);
			if (value.IndexOf(Utf8JsonWriter.s_singleLineCommentDelimiter) != -1)
			{
				ThrowHelper.ThrowArgumentException_InvalidCommentValue();
			}
			this.WriteCommentByOptions(value);
			JsonTokenType tokenType = this._tokenType;
			bool flag = tokenType == JsonTokenType.None || tokenType == JsonTokenType.PropertyName;
			if (flag)
			{
				this._commentAfterNoneOrPropertyName = true;
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000207FC File Offset: 0x0001E9FC
		private void WriteCommentByOptions(ReadOnlySpan<char> value)
		{
			if (this._options.Indented)
			{
				this.WriteCommentIndented(value);
				return;
			}
			this.WriteCommentMinimized(value);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002081C File Offset: 0x0001EA1C
		private unsafe void WriteCommentMinimized(ReadOnlySpan<char> value)
		{
			int num = value.Length * 3 + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			int num2;
			if (JsonWriterHelper.ToUtf8(value, span.Slice(this.BytesPending), out num2) == OperationStatus.InvalidData)
			{
				ThrowHelper.ThrowArgumentException_InvalidUTF16((int)(*value[num2]));
			}
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00020900 File Offset: 0x0001EB00
		private unsafe void WriteCommentIndented(ReadOnlySpan<char> value)
		{
			int indentation = this.Indentation;
			int num = indentation + value.Length * 3 + 4 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._tokenType != JsonTokenType.None || this._commentAfterNoneOrPropertyName)
			{
				this.WriteNewLine(span);
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			int num2;
			if (JsonWriterHelper.ToUtf8(value, span.Slice(this.BytesPending), out num2) == OperationStatus.InvalidData)
			{
				ThrowHelper.ThrowArgumentException_InvalidUTF16((int)(*value[num2]));
			}
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00020A38 File Offset: 0x0001EC38
		public void WriteCommentValue(ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidateValue(utf8Value);
			if (utf8Value.IndexOf(Utf8JsonWriter.SingleLineCommentDelimiterUtf8) != -1)
			{
				ThrowHelper.ThrowArgumentException_InvalidCommentValue();
			}
			if (!JsonWriterHelper.IsValidUtf8String(utf8Value))
			{
				ThrowHelper.ThrowArgumentException_InvalidUTF8(utf8Value);
			}
			this.WriteCommentByOptions(utf8Value);
			JsonTokenType tokenType = this._tokenType;
			bool flag = tokenType == JsonTokenType.None || tokenType == JsonTokenType.PropertyName;
			if (flag)
			{
				this._commentAfterNoneOrPropertyName = true;
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00020A91 File Offset: 0x0001EC91
		private void WriteCommentByOptions(ReadOnlySpan<byte> utf8Value)
		{
			if (this._options.Indented)
			{
				this.WriteCommentIndented(utf8Value);
				return;
			}
			this.WriteCommentMinimized(utf8Value);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		private unsafe void WriteCommentMinimized(ReadOnlySpan<byte> utf8Value)
		{
			int num = utf8Value.Length + 4;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00020B84 File Offset: 0x0001ED84
		private unsafe void WriteCommentIndented(ReadOnlySpan<byte> utf8Value)
		{
			int indentation = this.Indentation;
			int num = indentation + utf8Value.Length + 4 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._tokenType != JsonTokenType.None || this._commentAfterNoneOrPropertyName)
			{
				this.WriteNewLine(span);
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 42;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 47;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		public void WriteStringValue(DateTime value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteStringValueIndented(value);
			}
			else
			{
				this.WriteStringValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00020CE0 File Offset: 0x0001EEE0
		private unsafe void WriteStringValueMinimized(DateTime value)
		{
			int num = 36;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00020D98 File Offset: 0x0001EF98
		private unsafe void WriteStringValueIndented(DateTime value)
		{
			int indentation = this.Indentation;
			int num = indentation + 33 + 3 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00020EA2 File Offset: 0x0001F0A2
		public void WriteStringValue(DateTimeOffset value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteStringValueIndented(value);
			}
			else
			{
				this.WriteStringValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00020EE4 File Offset: 0x0001F0E4
		private unsafe void WriteStringValueMinimized(DateTimeOffset value)
		{
			int num = 36;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00020F9C File Offset: 0x0001F19C
		private unsafe void WriteStringValueIndented(DateTimeOffset value)
		{
			int indentation = this.Indentation;
			int num = indentation + 33 + 3 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			JsonWriterHelper.WriteDateTimeOffsetTrimmed(span.Slice(this.BytesPending), value, out num2);
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000210A6 File Offset: 0x0001F2A6
		public void WriteNumberValue(decimal value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(value);
			}
			else
			{
				this.WriteNumberValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000210E8 File Offset: 0x0001F2E8
		private unsafe void WriteNumberValueMinimized(decimal value)
		{
			int num = 32;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00021174 File Offset: 0x0001F374
		private unsafe void WriteNumberValueIndented(decimal value)
		{
			int indentation = this.Indentation;
			int num = indentation + 31 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00021250 File Offset: 0x0001F450
		internal unsafe void WriteNumberValueAsString(decimal value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)31], 31);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WriteNumberValueAsStringUnescaped(destination.Slice(0, length));
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00021294 File Offset: 0x0001F494
		public void WriteNumberValue(double value)
		{
			JsonWriterHelper.ValidateDouble(value);
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(value);
			}
			else
			{
				this.WriteNumberValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000212E4 File Offset: 0x0001F4E4
		private unsafe void WriteNumberValueMinimized(double value)
		{
			int num = 129;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00021368 File Offset: 0x0001F568
		private unsafe void WriteNumberValueIndented(double value)
		{
			int indentation = this.Indentation;
			int num = indentation + 128 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int num2;
			Utf8JsonWriter.TryFormatDouble(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0002143C File Offset: 0x0001F63C
		private static bool TryFormatDouble(double value, Span<byte> destination, out int bytesWritten)
		{
			return Utf8Formatter.TryFormat(value, destination, out bytesWritten, default(StandardFormat));
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002145C File Offset: 0x0001F65C
		internal unsafe void WriteNumberValueAsString(double value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			int length;
			Utf8JsonWriter.TryFormatDouble(value, destination, out length);
			this.WriteNumberValueAsStringUnescaped(destination.Slice(0, length));
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002149C File Offset: 0x0001F69C
		internal void WriteFloatingPointConstant(double value)
		{
			if (double.IsNaN(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.NaNValue);
				return;
			}
			if (double.IsPositiveInfinity(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.PositiveInfinityValue);
				return;
			}
			if (double.IsNegativeInfinity(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.NegativeInfinityValue);
				return;
			}
			this.WriteNumberValue(value);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000214EC File Offset: 0x0001F6EC
		public void WriteNumberValue(float value)
		{
			JsonWriterHelper.ValidateSingle(value);
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(value);
			}
			else
			{
				this.WriteNumberValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002153C File Offset: 0x0001F73C
		private unsafe void WriteNumberValueMinimized(float value)
		{
			int num = 129;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000215C0 File Offset: 0x0001F7C0
		private unsafe void WriteNumberValueIndented(float value)
		{
			int indentation = this.Indentation;
			int num = indentation + 128 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int num2;
			Utf8JsonWriter.TryFormatSingle(value, span.Slice(this.BytesPending), out num2);
			this.BytesPending += num2;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00021694 File Offset: 0x0001F894
		private static bool TryFormatSingle(float value, Span<byte> destination, out int bytesWritten)
		{
			return Utf8Formatter.TryFormat(value, destination, out bytesWritten, default(StandardFormat));
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000216B4 File Offset: 0x0001F8B4
		internal unsafe void WriteNumberValueAsString(float value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)128], 128);
			int length;
			Utf8JsonWriter.TryFormatSingle(value, destination, out length);
			this.WriteNumberValueAsStringUnescaped(destination.Slice(0, length));
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000216F4 File Offset: 0x0001F8F4
		internal void WriteFloatingPointConstant(float value)
		{
			if (float.IsNaN(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.NaNValue);
				return;
			}
			if (float.IsPositiveInfinity(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.PositiveInfinityValue);
				return;
			}
			if (float.IsNegativeInfinity(value))
			{
				this.WriteNumberValueAsStringUnescaped(JsonConstants.NegativeInfinityValue);
				return;
			}
			this.WriteNumberValue(value);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00021744 File Offset: 0x0001F944
		internal void WriteNumberValue(ReadOnlySpan<byte> utf8FormattedNumber)
		{
			JsonWriterHelper.ValidateValue(utf8FormattedNumber);
			JsonWriterHelper.ValidateNumber(utf8FormattedNumber);
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(utf8FormattedNumber);
			}
			else
			{
				this.WriteNumberValueMinimized(utf8FormattedNumber);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0002179C File Offset: 0x0001F99C
		private unsafe void WriteNumberValueMinimized(ReadOnlySpan<byte> utf8Value)
		{
			int num = utf8Value.Length + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00021828 File Offset: 0x0001FA28
		private unsafe void WriteNumberValueIndented(ReadOnlySpan<byte> utf8Value)
		{
			int indentation = this.Indentation;
			int num = indentation + utf8Value.Length + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000218FD File Offset: 0x0001FAFD
		public void WriteStringValue(Guid value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteStringValueIndented(value);
			}
			else
			{
				this.WriteStringValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0002193C File Offset: 0x0001FB3C
		private unsafe void WriteStringValueMinimized(Guid value)
		{
			int num = 39;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000219FC File Offset: 0x0001FBFC
		private unsafe void WriteStringValueIndented(Guid value)
		{
			int indentation = this.Indentation;
			int num = indentation + 36 + 3 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00021B14 File Offset: 0x0001FD14
		private void ValidateWritingValue()
		{
			if (this._inObject)
			{
				if (this._tokenType != JsonTokenType.PropertyName)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotWriteValueWithinObject, 0, this._options.MaxDepth, 0, this._tokenType);
					return;
				}
			}
			else if (this.CurrentDepth == 0 && this._tokenType != JsonTokenType.None)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.CannotWriteValueAfterPrimitiveOrClose, 0, this._options.MaxDepth, 0, this._tokenType);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00021B78 File Offset: 0x0001FD78
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void Base64EncodeAndWrite(ReadOnlySpan<byte> bytes, Span<byte> output)
		{
			Span<byte> utf = output.Slice(this.BytesPending);
			int num;
			int num2;
			Base64.EncodeToUtf8(bytes, utf, out num, out num2, true);
			this.BytesPending += num2;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00021BAE File Offset: 0x0001FDAE
		public void WriteNullValue()
		{
			this.WriteLiteralByOptions(JsonConstants.NullValue);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00021BC9 File Offset: 0x0001FDC9
		public void WriteBooleanValue(bool value)
		{
			if (value)
			{
				this.WriteLiteralByOptions(JsonConstants.TrueValue);
				this._tokenType = JsonTokenType.True;
			}
			else
			{
				this.WriteLiteralByOptions(JsonConstants.FalseValue);
				this._tokenType = JsonTokenType.False;
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00021BFC File Offset: 0x0001FDFC
		private void WriteLiteralByOptions(ReadOnlySpan<byte> utf8Value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteLiteralIndented(utf8Value);
				return;
			}
			this.WriteLiteralMinimized(utf8Value);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00021C30 File Offset: 0x0001FE30
		private unsafe void WriteLiteralMinimized(ReadOnlySpan<byte> utf8Value)
		{
			int num = utf8Value.Length + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00021CBC File Offset: 0x0001FEBC
		private unsafe void WriteLiteralIndented(ReadOnlySpan<byte> utf8Value)
		{
			int indentation = this.Indentation;
			int num = indentation + utf8Value.Length + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			utf8Value.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += utf8Value.Length;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00021D91 File Offset: 0x0001FF91
		[NullableContext(1)]
		public void WriteRawValue([StringSyntax("Json")] string json, bool skipInputValidation = false)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (json == null)
			{
				throw new ArgumentNullException("json");
			}
			this.TranscodeAndWriteRawValue(json.AsSpan(), skipInputValidation);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00021DC1 File Offset: 0x0001FFC1
		public void WriteRawValue([StringSyntax("Json")] ReadOnlySpan<char> json, bool skipInputValidation = false)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			this.TranscodeAndWriteRawValue(json, skipInputValidation);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00021DDE File Offset: 0x0001FFDE
		public void WriteRawValue(ReadOnlySpan<byte> utf8Json, bool skipInputValidation = false)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (utf8Json.Length == 2147483647)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge(2147483647L);
			}
			this.WriteRawValueCore(utf8Json, skipInputValidation);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00021E14 File Offset: 0x00020014
		public unsafe void WriteRawValue(ReadOnlySequence<byte> utf8Json, bool skipInputValidation = false)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			long length = utf8Json.Length;
			if (length == 0L)
			{
				ThrowHelper.ThrowArgumentException(SR.ExpectedJsonTokens);
			}
			if (length >= 2147483647L)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge(length);
			}
			if (skipInputValidation)
			{
				this._tokenType = JsonTokenType.String;
			}
			else
			{
				Utf8JsonReader utf8JsonReader = new Utf8JsonReader(utf8Json, default(JsonReaderOptions));
				while (utf8JsonReader.Read())
				{
				}
				this._tokenType = utf8JsonReader.TokenType;
			}
			int num = (int)length;
			int num2 = num + 1;
			if (this._memory.Length - this.BytesPending < num2)
			{
				this.Grow(num2);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			utf8Json.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += num;
			this.SetFlagToAddListSeparatorBeforeNextItem();
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00021F0C File Offset: 0x0002010C
		private unsafe void TranscodeAndWriteRawValue(ReadOnlySpan<char> json, bool skipInputValidation)
		{
			if (json.Length > 715827882)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge((long)json.Length);
			}
			byte[] array = null;
			Span<byte> span;
			if (json.Length <= 85)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (((long)json.Length <= 357913941L) ? (array = ArrayPool<byte>.Shared.Rent(json.Length * 3)) : new byte[JsonReaderHelper.GetUtf8ByteCount(json)]);
			}
			Span<byte> span2 = span;
			try
			{
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(json, span2);
				span2 = span2.Slice(0, utf8FromText);
				this.WriteRawValueCore(span2, skipInputValidation);
			}
			finally
			{
				if (array != null)
				{
					span2.Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00021FD8 File Offset: 0x000201D8
		private unsafe void WriteRawValueCore(ReadOnlySpan<byte> utf8Json, bool skipInputValidation)
		{
			int length = utf8Json.Length;
			if (length == 0)
			{
				ThrowHelper.ThrowArgumentException(SR.ExpectedJsonTokens);
			}
			if (skipInputValidation)
			{
				this._tokenType = JsonTokenType.String;
			}
			else
			{
				Utf8JsonReader utf8JsonReader = new Utf8JsonReader(utf8Json, default(JsonReaderOptions));
				while (utf8JsonReader.Read())
				{
				}
				this._tokenType = utf8JsonReader.TokenType;
			}
			int num = length + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			utf8Json.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += length;
			this.SetFlagToAddListSeparatorBeforeNextItem();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000220A9 File Offset: 0x000202A9
		public void WriteNumberValue(int value)
		{
			this.WriteNumberValue((long)value);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000220B3 File Offset: 0x000202B3
		public void WriteNumberValue(long value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(value);
			}
			else
			{
				this.WriteNumberValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000220F4 File Offset: 0x000202F4
		private unsafe void WriteNumberValueMinimized(long value)
		{
			int num = 21;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00022180 File Offset: 0x00020380
		private unsafe void WriteNumberValueIndented(long value)
		{
			int indentation = this.Indentation;
			int num = indentation + 20 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002225C File Offset: 0x0002045C
		internal unsafe void WriteNumberValueAsString(long value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WriteNumberValueAsStringUnescaped(destination.Slice(0, length));
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000222A0 File Offset: 0x000204A0
		public void WriteStringValue(JsonEncodedText value)
		{
			ReadOnlySpan<byte> encodedUtf8Bytes = value.EncodedUtf8Bytes;
			this.WriteStringByOptions(encodedUtf8Bytes);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000222C9 File Offset: 0x000204C9
		[NullableContext(2)]
		public void WriteStringValue(string value)
		{
			if (value == null)
			{
				this.WriteNullValue();
				return;
			}
			this.WriteStringValue(value.AsSpan());
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000222E1 File Offset: 0x000204E1
		public void WriteStringValue(ReadOnlySpan<char> value)
		{
			JsonWriterHelper.ValidateValue(value);
			this.WriteStringEscape(value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00022300 File Offset: 0x00020500
		private void WriteStringEscape(ReadOnlySpan<char> value)
		{
			int num = JsonWriterHelper.NeedsEscaping(value, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeValue(value, num);
				return;
			}
			this.WriteStringByOptions(value);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00022333 File Offset: 0x00020533
		private void WriteStringByOptions(ReadOnlySpan<char> value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteStringIndented(value);
				return;
			}
			this.WriteStringMinimized(value);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00022364 File Offset: 0x00020564
		private unsafe void WriteStringMinimized(ReadOnlySpan<char> escapedValue)
		{
			int num = escapedValue.Length * 3 + 3;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00022408 File Offset: 0x00020608
		private unsafe void WriteStringIndented(ReadOnlySpan<char> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedValue.Length * 3 + 3 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			this.TranscodeAndWrite(escapedValue, span);
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000224F8 File Offset: 0x000206F8
		private unsafe void WriteStringEscapeValue(ReadOnlySpan<char> value, int firstEscapeIndexVal)
		{
			char[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(value.Length, firstEscapeIndexVal);
			Span<char> span;
			if (maxEscapedLength <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(maxEscapedLength));
			}
			Span<char> destination = span;
			int length;
			JsonWriterHelper.EscapeString(value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length));
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00022582 File Offset: 0x00020782
		public void WriteStringValue(ReadOnlySpan<byte> utf8Value)
		{
			JsonWriterHelper.ValidateValue(utf8Value);
			this.WriteStringEscape(utf8Value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000225A0 File Offset: 0x000207A0
		private void WriteStringEscape(ReadOnlySpan<byte> utf8Value)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, this._options.Encoder);
			if (num != -1)
			{
				this.WriteStringEscapeValue(utf8Value, num);
				return;
			}
			this.WriteStringByOptions(utf8Value);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000225D3 File Offset: 0x000207D3
		private void WriteStringByOptions(ReadOnlySpan<byte> utf8Value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteStringIndented(utf8Value);
				return;
			}
			this.WriteStringMinimized(utf8Value);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00022604 File Offset: 0x00020804
		private unsafe void WriteStringMinimized(ReadOnlySpan<byte> escapedValue)
		{
			int num = escapedValue.Length + 2 + 1;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000226C8 File Offset: 0x000208C8
		private unsafe void WriteStringIndented(ReadOnlySpan<byte> escapedValue)
		{
			int indentation = this.Indentation;
			int num = indentation + escapedValue.Length + 2 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			int bytesPending;
			if (this._currentDepth < 0)
			{
				bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
			escapedValue.CopyTo(span.Slice(this.BytesPending));
			this.BytesPending += escapedValue.Length;
			bytesPending = this.BytesPending;
			this.BytesPending = bytesPending + 1;
			*span[bytesPending] = 34;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000227D8 File Offset: 0x000209D8
		private unsafe void WriteStringEscapeValue(ReadOnlySpan<byte> utf8Value, int firstEscapeIndexVal)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndexVal);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndexVal, this._options.Encoder, out length);
			this.WriteStringByOptions(destination.Slice(0, length));
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00022862 File Offset: 0x00020A62
		internal void WriteNumberValueAsStringUnescaped(ReadOnlySpan<byte> utf8Value)
		{
			this.WriteStringByOptions(utf8Value);
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.String;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00022878 File Offset: 0x00020A78
		[CLSCompliant(false)]
		public void WriteNumberValue(uint value)
		{
			this.WriteNumberValue((ulong)value);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00022882 File Offset: 0x00020A82
		[CLSCompliant(false)]
		public void WriteNumberValue(ulong value)
		{
			if (!this._options.SkipValidation)
			{
				this.ValidateWritingValue();
			}
			if (this._options.Indented)
			{
				this.WriteNumberValueIndented(value);
			}
			else
			{
				this.WriteNumberValueMinimized(value);
			}
			this.SetFlagToAddListSeparatorBeforeNextItem();
			this._tokenType = JsonTokenType.Number;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000228C4 File Offset: 0x00020AC4
		private unsafe void WriteNumberValueMinimized(ulong value)
		{
			int num = 21;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00022950 File Offset: 0x00020B50
		private unsafe void WriteNumberValueIndented(ulong value)
		{
			int indentation = this.Indentation;
			int num = indentation + 20 + 1 + this._newLineLength;
			if (this._memory.Length - this.BytesPending < num)
			{
				this.Grow(num);
			}
			Span<byte> span = this._memory.Span;
			if (this._currentDepth < 0)
			{
				int bytesPending = this.BytesPending;
				this.BytesPending = bytesPending + 1;
				*span[bytesPending] = 44;
			}
			if (this._tokenType != JsonTokenType.PropertyName)
			{
				if (this._tokenType != JsonTokenType.None)
				{
					this.WriteNewLine(span);
				}
				this.WriteIndentation(span.Slice(this.BytesPending), indentation);
				this.BytesPending += indentation;
			}
			int num2;
			Utf8Formatter.TryFormat(value, span.Slice(this.BytesPending), out num2, default(StandardFormat));
			this.BytesPending += num2;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00022A2C File Offset: 0x00020C2C
		internal unsafe void WriteNumberValueAsString(ulong value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, default(StandardFormat));
			this.WriteNumberValueAsStringUnescaped(destination.Slice(0, length));
		}

		// Token: 0x040001E2 RID: 482
		private IBufferWriter<byte> _output;

		// Token: 0x040001E3 RID: 483
		private Stream _stream;

		// Token: 0x040001E4 RID: 484
		private ArrayBufferWriter<byte> _arrayBufferWriter;

		// Token: 0x040001E5 RID: 485
		private Memory<byte> _memory;

		// Token: 0x040001E6 RID: 486
		private bool _inObject;

		// Token: 0x040001E7 RID: 487
		private bool _commentAfterNoneOrPropertyName;

		// Token: 0x040001E8 RID: 488
		private JsonTokenType _tokenType;

		// Token: 0x040001E9 RID: 489
		private BitStack _bitStack;

		// Token: 0x040001EA RID: 490
		private int _currentDepth;

		// Token: 0x040001EB RID: 491
		private JsonWriterOptions _options;

		// Token: 0x040001EC RID: 492
		private byte _indentByte;

		// Token: 0x040001ED RID: 493
		private int _indentLength;

		// Token: 0x040001EE RID: 494
		private int _newLineLength;

		// Token: 0x040001F1 RID: 497
		private static readonly char[] s_singleLineCommentDelimiter = new char[]
		{
			'*',
			'/'
		};
	}
}
