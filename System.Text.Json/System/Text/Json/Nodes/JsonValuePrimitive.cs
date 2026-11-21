using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace System.Text.Json.Nodes
{
	// Token: 0x02000078 RID: 120
	internal sealed class JsonValuePrimitive<TValue> : JsonValue<TValue>
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x000275AF File Offset: 0x000257AF
		public JsonValuePrimitive(TValue value, JsonConverter<TValue> converter, JsonNodeOptions? options) : base(value, options)
		{
			this._converter = converter;
			this._valueKind = JsonValue<TValue>.DetermineValueKind(value);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000275CC File Offset: 0x000257CC
		private protected override JsonValueKind GetValueKindCore()
		{
			return this._valueKind;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000275D4 File Offset: 0x000257D4
		internal override JsonNode DeepCloneCore()
		{
			return new JsonValuePrimitive<TValue>(this.Value, this._converter, base.Options);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000275F0 File Offset: 0x000257F0
		internal override bool DeepEqualsCore(JsonNode otherNode)
		{
			JsonValue jsonValue = otherNode as JsonValue;
			TValue y;
			if (jsonValue != null && jsonValue.TryGetValue<TValue>(out y))
			{
				return EqualityComparer<TValue>.Default.Equals(this.Value, y);
			}
			return base.DeepEqualsCore(otherNode);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0002762C File Offset: 0x0002582C
		public override void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			JsonConverter<TValue> converter = this._converter;
			if (options == null)
			{
				options = JsonNode.s_defaultOptions;
			}
			if (converter.IsInternalConverterForNumberType)
			{
				converter.WriteNumberWithCustomHandling(writer, this.Value, options.NumberHandling);
				return;
			}
			converter.Write(writer, this.Value, options);
		}

		// Token: 0x0400024C RID: 588
		private readonly JsonConverter<TValue> _converter;

		// Token: 0x0400024D RID: 589
		private readonly JsonValueKind _valueKind;
	}
}
