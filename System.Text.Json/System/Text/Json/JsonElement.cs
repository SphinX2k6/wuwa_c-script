using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text.Json
{
	// Token: 0x02000028 RID: 40
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly struct JsonElement
	{
		// Token: 0x06000291 RID: 657 RVA: 0x00009701 File Offset: 0x00007901
		internal JsonElement(JsonDocument parent, int idx)
		{
			this._parent = parent;
			this._idx = idx;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00009711 File Offset: 0x00007911
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private JsonTokenType TokenType
		{
			get
			{
				JsonDocument parent = this._parent;
				if (parent == null)
				{
					return JsonTokenType.None;
				}
				return parent.GetJsonTokenType(this._idx);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000972A File Offset: 0x0000792A
		public JsonValueKind ValueKind
		{
			get
			{
				return this.TokenType.ToValueKind();
			}
		}

		// Token: 0x170000FA RID: 250
		public JsonElement this[int index]
		{
			get
			{
				this.CheckValidInstance();
				return this._parent.GetArrayIndexElement(this._idx, index);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00009751 File Offset: 0x00007951
		public int GetArrayLength()
		{
			this.CheckValidInstance();
			return this._parent.GetArrayLength(this._idx);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000976A File Offset: 0x0000796A
		public int GetPropertyCount()
		{
			this.CheckValidInstance();
			return this._parent.GetPropertyCount(this._idx);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009784 File Offset: 0x00007984
		[NullableContext(1)]
		public JsonElement GetProperty(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			JsonElement result;
			if (this.TryGetProperty(propertyName, out result))
			{
				return result;
			}
			throw new KeyNotFoundException();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000097B0 File Offset: 0x000079B0
		public JsonElement GetProperty(ReadOnlySpan<char> propertyName)
		{
			JsonElement result;
			if (this.TryGetProperty(propertyName, out result))
			{
				return result;
			}
			throw new KeyNotFoundException();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000097D0 File Offset: 0x000079D0
		public JsonElement GetProperty(ReadOnlySpan<byte> utf8PropertyName)
		{
			JsonElement result;
			if (this.TryGetProperty(utf8PropertyName, out result))
			{
				return result;
			}
			throw new KeyNotFoundException();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000097EF File Offset: 0x000079EF
		[NullableContext(1)]
		public bool TryGetProperty(string propertyName, out JsonElement value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			return this.TryGetProperty(propertyName.AsSpan(), out value);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000980B File Offset: 0x00007A0B
		public bool TryGetProperty(ReadOnlySpan<char> propertyName, out JsonElement value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetNamedPropertyValue(this._idx, propertyName, out value);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009826 File Offset: 0x00007A26
		public bool TryGetProperty(ReadOnlySpan<byte> utf8PropertyName, out JsonElement value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetNamedPropertyValue(this._idx, utf8PropertyName, out value);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00009844 File Offset: 0x00007A44
		public bool GetBoolean()
		{
			JsonTokenType tokenType = this.TokenType;
			return tokenType == JsonTokenType.True || (tokenType != JsonTokenType.False && JsonElement.<GetBoolean>g__ThrowJsonElementWrongTypeException|18_0(tokenType));
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000986C File Offset: 0x00007A6C
		[NullableContext(2)]
		public string GetString()
		{
			this.CheckValidInstance();
			return this._parent.GetString(this._idx, JsonTokenType.String);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00009886 File Offset: 0x00007A86
		[NullableContext(2)]
		public bool TryGetBytesFromBase64([NotNullWhen(true)] out byte[] value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000098A0 File Offset: 0x00007AA0
		[NullableContext(1)]
		public byte[] GetBytesFromBase64()
		{
			byte[] result;
			if (!this.TryGetBytesFromBase64(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000098BD File Offset: 0x00007ABD
		[CLSCompliant(false)]
		public bool TryGetSByte(out sbyte value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000098D8 File Offset: 0x00007AD8
		[CLSCompliant(false)]
		public sbyte GetSByte()
		{
			sbyte result;
			if (this.TryGetSByte(out result))
			{
				return result;
			}
			throw new FormatException();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000098F6 File Offset: 0x00007AF6
		public bool TryGetByte(out byte value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009910 File Offset: 0x00007B10
		public byte GetByte()
		{
			byte result;
			if (this.TryGetByte(out result))
			{
				return result;
			}
			throw new FormatException();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000992E File Offset: 0x00007B2E
		public bool TryGetInt16(out short value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009948 File Offset: 0x00007B48
		public short GetInt16()
		{
			short result;
			if (this.TryGetInt16(out result))
			{
				return result;
			}
			throw new FormatException();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009966 File Offset: 0x00007B66
		[CLSCompliant(false)]
		public bool TryGetUInt16(out ushort value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009980 File Offset: 0x00007B80
		[CLSCompliant(false)]
		public ushort GetUInt16()
		{
			ushort result;
			if (this.TryGetUInt16(out result))
			{
				return result;
			}
			throw new FormatException();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000999E File Offset: 0x00007B9E
		public bool TryGetInt32(out int value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000099B8 File Offset: 0x00007BB8
		public int GetInt32()
		{
			int result;
			if (!this.TryGetInt32(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000099D5 File Offset: 0x00007BD5
		[CLSCompliant(false)]
		public bool TryGetUInt32(out uint value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000099F0 File Offset: 0x00007BF0
		[CLSCompliant(false)]
		public uint GetUInt32()
		{
			uint result;
			if (!this.TryGetUInt32(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00009A0D File Offset: 0x00007C0D
		public bool TryGetInt64(out long value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00009A28 File Offset: 0x00007C28
		public long GetInt64()
		{
			long result;
			if (!this.TryGetInt64(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009A45 File Offset: 0x00007C45
		[CLSCompliant(false)]
		public bool TryGetUInt64(out ulong value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00009A60 File Offset: 0x00007C60
		[CLSCompliant(false)]
		public ulong GetUInt64()
		{
			ulong result;
			if (!this.TryGetUInt64(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00009A7D File Offset: 0x00007C7D
		public bool TryGetDouble(out double value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00009A98 File Offset: 0x00007C98
		public double GetDouble()
		{
			double result;
			if (!this.TryGetDouble(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009AB5 File Offset: 0x00007CB5
		public bool TryGetSingle(out float value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00009AD0 File Offset: 0x00007CD0
		public float GetSingle()
		{
			float result;
			if (!this.TryGetSingle(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00009AED File Offset: 0x00007CED
		public bool TryGetDecimal(out decimal value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009B08 File Offset: 0x00007D08
		public decimal GetDecimal()
		{
			decimal result;
			if (!this.TryGetDecimal(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00009B25 File Offset: 0x00007D25
		public bool TryGetDateTime(out DateTime value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00009B40 File Offset: 0x00007D40
		public DateTime GetDateTime()
		{
			DateTime result;
			if (!this.TryGetDateTime(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00009B5D File Offset: 0x00007D5D
		public bool TryGetDateTimeOffset(out DateTimeOffset value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009B78 File Offset: 0x00007D78
		public DateTimeOffset GetDateTimeOffset()
		{
			DateTimeOffset result;
			if (!this.TryGetDateTimeOffset(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009B95 File Offset: 0x00007D95
		public bool TryGetGuid(out Guid value)
		{
			this.CheckValidInstance();
			return this._parent.TryGetValue(this._idx, out value);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public Guid GetGuid()
		{
			Guid result;
			if (!this.TryGetGuid(out result))
			{
				ThrowHelper.ThrowFormatException();
			}
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00009BCD File Offset: 0x00007DCD
		internal string GetPropertyName()
		{
			this.CheckValidInstance();
			return this._parent.GetNameOfPropertyValue(this._idx);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009BE6 File Offset: 0x00007DE6
		internal ReadOnlySpan<byte> GetPropertyNameRaw()
		{
			this.CheckValidInstance();
			return this._parent.GetPropertyNameRaw(this._idx);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009BFF File Offset: 0x00007DFF
		[NullableContext(1)]
		public string GetRawText()
		{
			this.CheckValidInstance();
			return this._parent.GetRawValueAsString(this._idx);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009C18 File Offset: 0x00007E18
		internal ReadOnlyMemory<byte> GetRawValue()
		{
			this.CheckValidInstance();
			return this._parent.GetRawValue(this._idx, true);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009C32 File Offset: 0x00007E32
		internal string GetPropertyRawText()
		{
			this.CheckValidInstance();
			return this._parent.GetPropertyRawValueAsString(this._idx);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00009C4B File Offset: 0x00007E4B
		internal bool ValueIsEscaped
		{
			get
			{
				this.CheckValidInstance();
				return this._parent.ValueIsEscaped(this._idx, false);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00009C68 File Offset: 0x00007E68
		internal ReadOnlySpan<byte> ValueSpan
		{
			get
			{
				this.CheckValidInstance();
				return this._parent.GetRawValue(this._idx, false).Span;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009C98 File Offset: 0x00007E98
		public static bool DeepEquals(JsonElement element1, JsonElement element2)
		{
			if (!StackHelper.TryEnsureSufficientExecutionStack())
			{
				ThrowHelper.ThrowInsufficientExecutionStackException_JsonElementDeepEqualsInsufficientExecutionStack();
			}
			element1.CheckValidInstance();
			element2.CheckValidInstance();
			JsonValueKind valueKind = element1.ValueKind;
			if (valueKind != element2.ValueKind)
			{
				return false;
			}
			switch (valueKind)
			{
			case JsonValueKind.Array:
			{
				if (element1.GetArrayLength() != element2.GetArrayLength())
				{
					return false;
				}
				JsonElement.ArrayEnumerator arrayEnumerator = element2.EnumerateArray();
				foreach (JsonElement element3 in element1.EnumerateArray())
				{
					arrayEnumerator.MoveNext();
					if (!JsonElement.DeepEquals(element3, arrayEnumerator.Current))
					{
						return false;
					}
				}
				return true;
			}
			case JsonValueKind.String:
				if (element2.ValueIsEscaped)
				{
					if (element1.ValueIsEscaped)
					{
						return JsonReaderHelper.UnescapeAndCompareBothInputs(element1.ValueSpan, element2.ValueSpan);
					}
					JsonElement jsonElement = element2;
					element2 = element1;
					element1 = jsonElement;
				}
				return element1.ValueEquals(element2.ValueSpan);
			case JsonValueKind.Number:
				return JsonHelpers.AreEqualJsonNumbers(element1.GetRawValue().Span, element2.GetRawValue().Span);
			case JsonValueKind.True:
			case JsonValueKind.False:
			case JsonValueKind.Null:
				return true;
			default:
			{
				int num = element1.GetPropertyCount();
				if (num != element2.GetPropertyCount())
				{
					return false;
				}
				JsonElement.ObjectEnumerator objectEnumerator = element1.EnumerateObject();
				JsonElement.ObjectEnumerator objectEnumerator2 = element2.EnumerateObject();
				while (objectEnumerator.MoveNext())
				{
					objectEnumerator2.MoveNext();
					JsonProperty left = objectEnumerator.Current;
					JsonProperty right = objectEnumerator2.Current;
					if (!JsonElement.<DeepEquals>g__NameEquals|59_1(left, right))
					{
						return JsonElement.<DeepEquals>g__UnorderedObjectDeepEquals|59_0(objectEnumerator, objectEnumerator2, num);
					}
					if (!JsonElement.DeepEquals(left.Value, right.Value))
					{
						return false;
					}
					num--;
				}
				return true;
			}
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009E58 File Offset: 0x00008058
		[NullableContext(2)]
		public bool ValueEquals(string text)
		{
			if (this.TokenType == JsonTokenType.Null)
			{
				return text == null;
			}
			return this.TextEqualsHelper(text.AsSpan(), false);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009E76 File Offset: 0x00008076
		public bool ValueEquals(ReadOnlySpan<byte> utf8Text)
		{
			if (this.TokenType == JsonTokenType.Null)
			{
				return Unsafe.IsNullRef<byte>(MemoryMarshal.GetReference<byte>(utf8Text));
			}
			return this.TextEqualsHelper(utf8Text, false, true);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009E97 File Offset: 0x00008097
		public bool ValueEquals(ReadOnlySpan<char> text)
		{
			if (this.TokenType == JsonTokenType.Null)
			{
				return Unsafe.IsNullRef<char>(MemoryMarshal.GetReference<char>(text));
			}
			return this.TextEqualsHelper(text, false);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009EB7 File Offset: 0x000080B7
		internal bool TextEqualsHelper(ReadOnlySpan<byte> utf8Text, bool isPropertyName, bool shouldUnescape)
		{
			this.CheckValidInstance();
			return this._parent.TextEquals(this._idx, utf8Text, isPropertyName, shouldUnescape);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00009ED3 File Offset: 0x000080D3
		internal bool TextEqualsHelper(ReadOnlySpan<char> text, bool isPropertyName)
		{
			this.CheckValidInstance();
			return this._parent.TextEquals(this._idx, text, isPropertyName);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009EEE File Offset: 0x000080EE
		internal bool ValueIsEscapedHelper(bool isPropertyName)
		{
			this.CheckValidInstance();
			return this._parent.ValueIsEscaped(this._idx, isPropertyName);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009F08 File Offset: 0x00008108
		[NullableContext(1)]
		public void WriteTo(Utf8JsonWriter writer)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			this.CheckValidInstance();
			this._parent.WriteElementTo(this._idx, writer);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00009F2F File Offset: 0x0000812F
		internal void WritePropertyNameTo(Utf8JsonWriter writer)
		{
			this.CheckValidInstance();
			this._parent.WritePropertyName(this._idx, writer);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00009F4C File Offset: 0x0000814C
		public JsonElement.ArrayEnumerator EnumerateArray()
		{
			this.CheckValidInstance();
			JsonTokenType tokenType = this.TokenType;
			if (tokenType != JsonTokenType.StartArray)
			{
				ThrowHelper.ThrowJsonElementWrongTypeException(JsonTokenType.StartArray, tokenType);
			}
			return new JsonElement.ArrayEnumerator(this);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00009F7C File Offset: 0x0000817C
		public JsonElement.ObjectEnumerator EnumerateObject()
		{
			this.CheckValidInstance();
			JsonTokenType tokenType = this.TokenType;
			if (tokenType != JsonTokenType.StartObject)
			{
				ThrowHelper.ThrowJsonElementWrongTypeException(JsonTokenType.StartObject, tokenType);
			}
			return new JsonElement.ObjectEnumerator(this);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009FAC File Offset: 0x000081AC
		[NullableContext(1)]
		public override string ToString()
		{
			switch (this.TokenType)
			{
			case JsonTokenType.None:
			case JsonTokenType.Null:
				return string.Empty;
			case JsonTokenType.StartObject:
			case JsonTokenType.StartArray:
			case JsonTokenType.Number:
				return this._parent.GetRawValueAsString(this._idx);
			case JsonTokenType.String:
				return this.GetString();
			case JsonTokenType.True:
				return bool.TrueString;
			case JsonTokenType.False:
				return bool.FalseString;
			}
			return string.Empty;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A028 File Offset: 0x00008228
		public JsonElement Clone()
		{
			this.CheckValidInstance();
			if (!this._parent.IsDisposable)
			{
				return this;
			}
			return this._parent.CloneElement(this._idx);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A055 File Offset: 0x00008255
		private void CheckValidInstance()
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000A068 File Offset: 0x00008268
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("ValueKind = ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(this.ValueKind);
				defaultInterpolatedStringHandler.AppendLiteral(" : \"");
				defaultInterpolatedStringHandler.AppendFormatted(this.ToString());
				defaultInterpolatedStringHandler.AppendLiteral("\"");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000A0CC File Offset: 0x000082CC
		public static JsonElement ParseValue(ref Utf8JsonReader reader)
		{
			JsonDocument jsonDocument;
			JsonDocument.TryParseValue(ref reader, out jsonDocument, true, false);
			return jsonDocument.RootElement;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000A0EA File Offset: 0x000082EA
		internal static JsonElement ParseValue(Stream utf8Json, JsonDocumentOptions options)
		{
			return JsonDocument.ParseValue(utf8Json, options).RootElement;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000A0F8 File Offset: 0x000082F8
		internal static JsonElement ParseValue(ReadOnlySpan<byte> utf8Json, JsonDocumentOptions options)
		{
			return JsonDocument.ParseValue(utf8Json, options).RootElement;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000A106 File Offset: 0x00008306
		internal static JsonElement ParseValue(string json, JsonDocumentOptions options)
		{
			return JsonDocument.ParseValue(json, options).RootElement;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000A114 File Offset: 0x00008314
		public static bool TryParseValue(ref Utf8JsonReader reader, [NotNullWhen(true)] out JsonElement? element)
		{
			JsonDocument jsonDocument;
			bool result = JsonDocument.TryParseValue(ref reader, out jsonDocument, false, false);
			element = ((jsonDocument != null) ? new JsonElement?(jsonDocument.RootElement) : null);
			return result;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000A14A File Offset: 0x0000834A
		[CompilerGenerated]
		internal static bool <GetBoolean>g__ThrowJsonElementWrongTypeException|18_0(JsonTokenType actualType)
		{
			throw ThrowHelper.GetJsonElementWrongTypeException("Boolean", actualType.ToValueKind());
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000A15C File Offset: 0x0000835C
		[CompilerGenerated]
		internal static bool <DeepEquals>g__UnorderedObjectDeepEquals|59_0(JsonElement.ObjectEnumerator objectEnumerator1, JsonElement.ObjectEnumerator objectEnumerator2, int remainingProps)
		{
			Dictionary<string, ValueQueue<JsonElement>> dictionary = new Dictionary<string, ValueQueue<JsonElement>>(remainingProps, StringComparer.Ordinal);
			do
			{
				JsonProperty jsonProperty = objectEnumerator2.Current;
				bool flag;
				CollectionsMarshal.GetValueRefOrAddDefault<string, ValueQueue<JsonElement>>(dictionary, jsonProperty.Name, out flag).Enqueue(jsonProperty.Value);
			}
			while (objectEnumerator2.MoveNext());
			for (;;)
			{
				JsonProperty jsonProperty2 = objectEnumerator1.Current;
				bool flag2;
				ref ValueQueue<JsonElement> valueRefOrAddDefault = ref CollectionsMarshal.GetValueRefOrAddDefault<string, ValueQueue<JsonElement>>(dictionary, jsonProperty2.Name, out flag2);
				JsonElement element;
				if (!flag2 || !valueRefOrAddDefault.TryDequeue(out element) || !JsonElement.DeepEquals(jsonProperty2.Value, element))
				{
					break;
				}
				if (!objectEnumerator1.MoveNext())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000A1E5 File Offset: 0x000083E5
		[CompilerGenerated]
		internal static bool <DeepEquals>g__NameEquals|59_1(JsonProperty left, JsonProperty right)
		{
			if (right.NameIsEscaped)
			{
				if (left.NameIsEscaped)
				{
					return JsonReaderHelper.UnescapeAndCompareBothInputs(left.NameSpan, right.NameSpan);
				}
				JsonProperty jsonProperty = right;
				right = left;
				left = jsonProperty;
			}
			return left.NameEquals(right.NameSpan);
		}

		// Token: 0x04000063 RID: 99
		private readonly JsonDocument _parent;

		// Token: 0x04000064 RID: 100
		private readonly int _idx;

		// Token: 0x02000029 RID: 41
		[DebuggerDisplay("{Current,nq}")]
		public struct ArrayEnumerator : IEnumerable<JsonElement>, IEnumerable, IEnumerator<JsonElement>, IEnumerator, IDisposable
		{
			// Token: 0x060002DB RID: 731 RVA: 0x0000A221 File Offset: 0x00008421
			internal ArrayEnumerator(JsonElement target)
			{
				this._target = target;
				this._curIdx = -1;
				this._endIdxOrVersion = target._parent.GetEndIndex(this._target._idx, false);
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060002DC RID: 732 RVA: 0x0000A250 File Offset: 0x00008450
			public JsonElement Current
			{
				get
				{
					if (this._curIdx < 0)
					{
						return default(JsonElement);
					}
					return new JsonElement(this._target._parent, this._curIdx);
				}
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0000A288 File Offset: 0x00008488
			public JsonElement.ArrayEnumerator GetEnumerator()
			{
				JsonElement.ArrayEnumerator result = this;
				result._curIdx = -1;
				return result;
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000A2A5 File Offset: 0x000084A5
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0000A2A5 File Offset: 0x000084A5
			IEnumerator<JsonElement> IEnumerable<JsonElement>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x0000A2B2 File Offset: 0x000084B2
			public void Dispose()
			{
				this._curIdx = this._endIdxOrVersion;
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0000A2C0 File Offset: 0x000084C0
			public void Reset()
			{
				this._curIdx = -1;
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000A2C9 File Offset: 0x000084C9
			[Nullable(1)]
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000A2D8 File Offset: 0x000084D8
			public bool MoveNext()
			{
				if (this._curIdx >= this._endIdxOrVersion)
				{
					return false;
				}
				if (this._curIdx < 0)
				{
					this._curIdx = this._target._idx + 12;
				}
				else
				{
					this._curIdx = this._target._parent.GetEndIndex(this._curIdx, true);
				}
				return this._curIdx < this._endIdxOrVersion;
			}

			// Token: 0x04000065 RID: 101
			private readonly JsonElement _target;

			// Token: 0x04000066 RID: 102
			private int _curIdx;

			// Token: 0x04000067 RID: 103
			private readonly int _endIdxOrVersion;
		}

		// Token: 0x0200002A RID: 42
		[DebuggerDisplay("{Current,nq}")]
		public struct ObjectEnumerator : IEnumerable<JsonProperty>, IEnumerable, IEnumerator<JsonProperty>, IEnumerator, IDisposable
		{
			// Token: 0x060002E4 RID: 740 RVA: 0x0000A33F File Offset: 0x0000853F
			internal ObjectEnumerator(JsonElement target)
			{
				this._target = target;
				this._curIdx = -1;
				this._endIdxOrVersion = target._parent.GetEndIndex(this._target._idx, false);
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000A36C File Offset: 0x0000856C
			public JsonProperty Current
			{
				get
				{
					if (this._curIdx < 0)
					{
						return default(JsonProperty);
					}
					return new JsonProperty(new JsonElement(this._target._parent, this._curIdx));
				}
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000A3A8 File Offset: 0x000085A8
			public JsonElement.ObjectEnumerator GetEnumerator()
			{
				JsonElement.ObjectEnumerator result = this;
				result._curIdx = -1;
				return result;
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000A3C5 File Offset: 0x000085C5
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000A3C5 File Offset: 0x000085C5
			IEnumerator<JsonProperty> IEnumerable<JsonProperty>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000A3D2 File Offset: 0x000085D2
			public void Dispose()
			{
				this._curIdx = this._endIdxOrVersion;
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0000A3E0 File Offset: 0x000085E0
			public void Reset()
			{
				this._curIdx = -1;
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000A3E9 File Offset: 0x000085E9
			[Nullable(1)]
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000A3F8 File Offset: 0x000085F8
			public bool MoveNext()
			{
				if (this._curIdx >= this._endIdxOrVersion)
				{
					return false;
				}
				if (this._curIdx < 0)
				{
					this._curIdx = this._target._idx + 12;
				}
				else
				{
					this._curIdx = this._target._parent.GetEndIndex(this._curIdx, true);
				}
				this._curIdx += 12;
				return this._curIdx < this._endIdxOrVersion;
			}

			// Token: 0x04000068 RID: 104
			private readonly JsonElement _target;

			// Token: 0x04000069 RID: 105
			private int _curIdx;

			// Token: 0x0400006A RID: 106
			private readonly int _endIdxOrVersion;
		}
	}
}
