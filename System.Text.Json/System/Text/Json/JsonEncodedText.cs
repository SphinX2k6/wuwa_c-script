using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace System.Text.Json
{
	// Token: 0x0200002D RID: 45
	public readonly struct JsonEncodedText : IEquatable<JsonEncodedText>
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000A606 File Offset: 0x00008806
		public ReadOnlySpan<byte> EncodedUtf8Bytes
		{
			get
			{
				return this._utf8Value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000A613 File Offset: 0x00008813
		[Nullable(1)]
		public string Value
		{
			[NullableContext(1)]
			get
			{
				return this._value ?? string.Empty;
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A624 File Offset: 0x00008824
		private JsonEncodedText(byte[] utf8Value)
		{
			this._value = JsonReaderHelper.GetTextFromUtf8(utf8Value);
			this._utf8Value = utf8Value;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A63E File Offset: 0x0000883E
		[NullableContext(1)]
		public static JsonEncodedText Encode(string value, [Nullable(2)] JavaScriptEncoder encoder = null)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			return JsonEncodedText.Encode(value.AsSpan(), encoder);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000A659 File Offset: 0x00008859
		public static JsonEncodedText Encode(ReadOnlySpan<char> value, [Nullable(2)] JavaScriptEncoder encoder = null)
		{
			if (value.Length == 0)
			{
				return new JsonEncodedText(Array.Empty<byte>());
			}
			return JsonEncodedText.TranscodeAndEncode(value, encoder);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000A678 File Offset: 0x00008878
		private unsafe static JsonEncodedText TranscodeAndEncode(ReadOnlySpan<char> value, JavaScriptEncoder encoder)
		{
			JsonWriterHelper.ValidateValue(value);
			int utf8ByteCount = JsonReaderHelper.GetUtf8ByteCount(value);
			byte[] array = null;
			Span<byte> span;
			if (utf8ByteCount <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(utf8ByteCount));
			}
			Span<byte> span2 = span;
			int utf8FromText = JsonReaderHelper.GetUtf8FromText(value, span2);
			span2 = span2.Slice(0, utf8FromText);
			JsonEncodedText result = JsonEncodedText.EncodeHelper(span2, encoder);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000A6FD File Offset: 0x000088FD
		public static JsonEncodedText Encode(ReadOnlySpan<byte> utf8Value, [Nullable(2)] JavaScriptEncoder encoder = null)
		{
			if (utf8Value.Length == 0)
			{
				return new JsonEncodedText(Array.Empty<byte>());
			}
			JsonWriterHelper.ValidateValue(utf8Value);
			return JsonEncodedText.EncodeHelper(utf8Value, encoder);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000A720 File Offset: 0x00008920
		private static JsonEncodedText EncodeHelper(ReadOnlySpan<byte> utf8Value, JavaScriptEncoder encoder)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, encoder);
			if (num != -1)
			{
				return new JsonEncodedText(JsonHelpers.EscapeValue(utf8Value, num, encoder));
			}
			return new JsonEncodedText(utf8Value.ToArray());
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000A753 File Offset: 0x00008953
		public bool Equals(JsonEncodedText other)
		{
			if (this._value == null)
			{
				return other._value == null;
			}
			return this._value.Equals(other._value);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A778 File Offset: 0x00008978
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is JsonEncodedText)
			{
				JsonEncodedText other = (JsonEncodedText)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000A613 File Offset: 0x00008813
		[NullableContext(1)]
		public override string ToString()
		{
			return this._value ?? string.Empty;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000A79D File Offset: 0x0000899D
		public override int GetHashCode()
		{
			if (this._value != null)
			{
				return this._value.GetHashCode();
			}
			return 0;
		}

		// Token: 0x04000076 RID: 118
		internal readonly byte[] _utf8Value;

		// Token: 0x04000077 RID: 119
		internal readonly string _value;
	}
}
