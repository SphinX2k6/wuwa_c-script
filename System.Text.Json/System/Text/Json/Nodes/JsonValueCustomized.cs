using System;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Nodes
{
	// Token: 0x02000075 RID: 117
	internal sealed class JsonValueCustomized<TValue> : JsonValue<TValue>
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x00027148 File Offset: 0x00025348
		public JsonValueCustomized(TValue value, JsonTypeInfo<TValue> jsonTypeInfo, JsonNodeOptions? options = null) : base(value, options)
		{
			this._jsonTypeInfo = jsonTypeInfo;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002715C File Offset: 0x0002535C
		private protected override JsonValueKind GetValueKindCore()
		{
			JsonValueKind jsonValueKind = this._valueKind.GetValueOrDefault();
			if (this._valueKind == null)
			{
				jsonValueKind = this.ComputeValueKind();
				this._valueKind = new JsonValueKind?(jsonValueKind);
				return jsonValueKind;
			}
			return jsonValueKind;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00027198 File Offset: 0x00025398
		internal override JsonNode DeepCloneCore()
		{
			return JsonSerializer.SerializeToNode<TValue>(this.Value, this._jsonTypeInfo);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000271AC File Offset: 0x000253AC
		public override void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			JsonTypeInfo<TValue> jsonTypeInfo = this._jsonTypeInfo;
			if (options != null && options != jsonTypeInfo.Options)
			{
				options.MakeReadOnly();
				jsonTypeInfo = (JsonTypeInfo<TValue>)options.GetTypeInfoInternal(typeof(TValue), true, new bool?(true), false, false);
			}
			jsonTypeInfo.Serialize(writer, this.Value, null);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002720C File Offset: 0x0002540C
		private JsonValueKind ComputeValueKind()
		{
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter utf8JsonWriter = Utf8JsonWriterCache.RentWriterAndBuffer(default(JsonWriterOptions), 16384, out pooledByteBufferWriter);
			JsonValueKind result;
			try
			{
				this.WriteTo(utf8JsonWriter, null);
				utf8JsonWriter.Flush();
				Utf8JsonReader utf8JsonReader = new Utf8JsonReader(pooledByteBufferWriter.WrittenMemory.Span, default(JsonReaderOptions));
				utf8JsonReader.Read();
				result = utf8JsonReader.TokenType.ToValueKind();
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(utf8JsonWriter, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x04000247 RID: 583
		private readonly JsonTypeInfo<TValue> _jsonTypeInfo;

		// Token: 0x04000248 RID: 584
		private JsonValueKind? _valueKind;
	}
}
