using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000147 RID: 327
	internal sealed class JsonElementConverter : JsonConverter<JsonElement>
	{
		// Token: 0x06000E88 RID: 3720 RVA: 0x00037E60 File Offset: 0x00036060
		public override JsonElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonElement.ParseValue(ref reader);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00037E68 File Offset: 0x00036068
		public override void Write(Utf8JsonWriter writer, JsonElement value, JsonSerializerOptions options)
		{
			value.WriteTo(writer);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000351AA File Offset: 0x000333AA
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return JsonSchema.CreateTrueSchema();
		}
	}
}
