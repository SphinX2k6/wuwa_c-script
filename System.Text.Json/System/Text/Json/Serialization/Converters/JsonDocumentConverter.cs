using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000146 RID: 326
	internal sealed class JsonDocumentConverter : JsonConverter<JsonDocument>
	{
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00037E3D File Offset: 0x0003603D
		public override JsonDocument Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonDocument.ParseValue(ref reader);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00037E45 File Offset: 0x00036045
		public override void Write(Utf8JsonWriter writer, JsonDocument value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			value.WriteTo(writer);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000351AA File Offset: 0x000333AA
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return JsonSchema.CreateTrueSchema();
		}
	}
}
