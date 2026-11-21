using System;
using System.Text.Json.Nodes;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000129 RID: 297
	internal sealed class JsonNodeConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x000351BC File Offset: 0x000333BC
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			if (typeof(JsonValue).IsAssignableFrom(typeToConvert))
			{
				return JsonNodeConverter.ValueConverter;
			}
			if (typeof(JsonObject) == typeToConvert)
			{
				return JsonNodeConverter.ObjectConverter;
			}
			if (typeof(JsonArray) == typeToConvert)
			{
				return JsonNodeConverter.ArrayConverter;
			}
			return JsonNodeConverter.Instance;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00035216 File Offset: 0x00033416
		public override bool CanConvert(Type typeToConvert)
		{
			return typeof(JsonNode).IsAssignableFrom(typeToConvert);
		}
	}
}
