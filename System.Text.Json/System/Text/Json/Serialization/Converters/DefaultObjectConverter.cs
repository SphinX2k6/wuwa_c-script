using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200012F RID: 303
	internal sealed class DefaultObjectConverter : ObjectConverter
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x000353ED File Offset: 0x000335ED
		public DefaultObjectConverter()
		{
			base.RequiresReadAhead = true;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000353FC File Offset: 0x000335FC
		public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (options.UnknownTypeHandling == JsonUnknownTypeHandling.JsonElement)
			{
				return JsonElement.ParseValue(ref reader);
			}
			return JsonNodeConverter.Instance.Read(ref reader, typeToConvert, options);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00035420 File Offset: 0x00033620
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value)
		{
			object obj;
			if (options.UnknownTypeHandling == JsonUnknownTypeHandling.JsonElement)
			{
				JsonElement jsonElement = JsonElement.ParseValue(ref reader);
				if (options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.Preserve && JsonSerializer.TryHandleReferenceFromJsonElement(ref reader, ref state, jsonElement, out obj))
				{
					value = obj;
				}
				else
				{
					value = jsonElement;
				}
				return true;
			}
			JsonNode jsonNode = JsonNodeConverter.Instance.Read(ref reader, typeToConvert, options);
			if (options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.Preserve && JsonSerializer.TryHandleReferenceFromJsonNode(ref reader, ref state, jsonNode, out obj))
			{
				value = obj;
			}
			else
			{
				value = jsonNode;
			}
			return true;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000351AA File Offset: 0x000333AA
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return JsonSchema.CreateTrueSchema();
		}
	}
}
