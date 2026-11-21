using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200012A RID: 298
	internal sealed class JsonObjectConverter : JsonConverter<JsonObject>
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00035228 File Offset: 0x00033428
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			jsonTypeInfo.CreateObjectForExtensionDataProperty = (() => new JsonObject(new JsonNodeOptions?(options.GetNodeOptions())));
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00035254 File Offset: 0x00033454
		internal override void ReadElementAndSetProperty(object obj, string propertyName, ref Utf8JsonReader reader, JsonSerializerOptions options, [ScopedRef] ref ReadStack state)
		{
			JsonNode jsonNode;
			bool flag;
			JsonNodeConverter.Instance.TryRead(ref reader, typeof(JsonNode), options, ref state, out jsonNode, out flag);
			JsonNode jsonNode2 = (JsonObject)obj;
			JsonNode value = jsonNode;
			jsonNode2[propertyName] = value;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0003501C File Offset: 0x0003321C
		public override void Write(Utf8JsonWriter writer, JsonObject value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			value.WriteTo(writer, options);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00035290 File Offset: 0x00033490
		public override JsonObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType == JsonTokenType.StartObject)
			{
				return JsonObjectConverter.ReadObject(ref reader, new JsonNodeOptions?(options.GetNodeOptions()));
			}
			if (tokenType != JsonTokenType.Null)
			{
				throw ThrowHelper.GetInvalidOperationException_ExpectedObject(reader.TokenType);
			}
			return null;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000352CE File Offset: 0x000334CE
		public static JsonObject ReadObject(ref Utf8JsonReader reader, JsonNodeOptions? options)
		{
			return new JsonObject(JsonElement.ParseValue(ref reader), options);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000352DC File Offset: 0x000334DC
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.Object
			};
		}
	}
}
