using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly struct JsonProperty
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000A46E File Offset: 0x0000866E
		public JsonElement Value { get; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000A476 File Offset: 0x00008676
		[Nullable(2)]
		private string _name { get; }

		// Token: 0x060002EF RID: 751 RVA: 0x0000A47E File Offset: 0x0000867E
		internal JsonProperty(JsonElement value)
		{
			this._name = null;
			this.Value = value;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000A490 File Offset: 0x00008690
		public string Name
		{
			get
			{
				return this._name ?? this.Value.GetPropertyName();
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A4B5 File Offset: 0x000086B5
		[NullableContext(2)]
		public bool NameEquals(string text)
		{
			return this.NameEquals(text.AsSpan());
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000A4C4 File Offset: 0x000086C4
		[NullableContext(0)]
		public bool NameEquals(ReadOnlySpan<byte> utf8Text)
		{
			return this.Value.TextEqualsHelper(utf8Text, true, true);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000A4E4 File Offset: 0x000086E4
		[NullableContext(0)]
		public bool NameEquals(ReadOnlySpan<char> text)
		{
			return this.Value.TextEqualsHelper(text, true);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000A504 File Offset: 0x00008704
		internal bool EscapedNameEquals(ReadOnlySpan<byte> utf8Text)
		{
			return this.Value.TextEqualsHelper(utf8Text, true, false);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000A524 File Offset: 0x00008724
		internal bool NameIsEscaped
		{
			get
			{
				return this.Value.ValueIsEscapedHelper(true);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000A540 File Offset: 0x00008740
		[Nullable(0)]
		internal ReadOnlySpan<byte> NameSpan
		{
			get
			{
				return this.Value.GetPropertyNameRaw();
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000A55C File Offset: 0x0000875C
		public void WriteTo(Utf8JsonWriter writer)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			if (this._name == null)
			{
				this.Value.WritePropertyNameTo(writer);
			}
			else
			{
				writer.WritePropertyName(this._name);
			}
			this.Value.WriteTo(writer);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A5AC File Offset: 0x000087AC
		public override string ToString()
		{
			return this.Value.GetPropertyRawText();
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000A5C8 File Offset: 0x000087C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				if (this.Value.ValueKind != JsonValueKind.Undefined)
				{
					return "\"" + this.ToString() + "\"";
				}
				return "<Undefined>";
			}
		}
	}
}
