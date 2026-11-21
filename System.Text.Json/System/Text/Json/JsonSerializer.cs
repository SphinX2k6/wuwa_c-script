using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Converters;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json
{
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonSerializer
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00011D24 File Offset: 0x0000FF24
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>([Nullable(1)] this JsonDocument document, JsonSerializerOptions options = null)
		{
			if (document == null)
			{
				ThrowHelper.ThrowArgumentNullException("document");
			}
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromSpan<TValue>(document.GetRootRawValue().Span, typeInfo, null);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00011D64 File Offset: 0x0000FF64
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(2)]
		public static object Deserialize(this JsonDocument document, Type returnType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (document == null)
			{
				ThrowHelper.ThrowArgumentNullException("document");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromSpanAsObject(document.GetRootRawValue().Span, typeInfo, null);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		[return: Nullable(2)]
		public static TValue Deserialize<[Nullable(2)] TValue>(this JsonDocument document, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (document == null)
			{
				ThrowHelper.ThrowArgumentNullException("document");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpan<TValue>(document.GetRootRawValue().Span, jsonTypeInfo, null);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00011DFC File Offset: 0x0000FFFC
		[return: Nullable(2)]
		public static object Deserialize(this JsonDocument document, JsonTypeInfo jsonTypeInfo)
		{
			if (document == null)
			{
				ThrowHelper.ThrowArgumentNullException("document");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpanAsObject(document.GetRootRawValue().Span, jsonTypeInfo, null);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00011E48 File Offset: 0x00010048
		[return: Nullable(2)]
		public static object Deserialize(this JsonDocument document, Type returnType, JsonSerializerContext context)
		{
			if (document == null)
			{
				ThrowHelper.ThrowArgumentNullException("document");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, returnType);
			return JsonSerializer.ReadFromSpanAsObject(document.GetRootRawValue().Span, typeInfo, null);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00011EA4 File Offset: 0x000100A4
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>(this JsonElement element, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromSpan<TValue>(element.GetRawValue().Span, typeInfo, null);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00011ED8 File Offset: 0x000100D8
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static object Deserialize(this JsonElement element, [Nullable(1)] Type returnType, JsonSerializerOptions options = null)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromSpanAsObject(element.GetRawValue().Span, typeInfo, null);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00011F18 File Offset: 0x00010118
		[NullableContext(2)]
		public static TValue Deserialize<TValue>(this JsonElement element, [Nullable(1)] JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpan<TValue>(element.GetRawValue().Span, jsonTypeInfo, null);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00011F58 File Offset: 0x00010158
		[return: Nullable(2)]
		public static object Deserialize(this JsonElement element, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpanAsObject(element.GetRawValue().Span, jsonTypeInfo, null);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00011F98 File Offset: 0x00010198
		[return: Nullable(2)]
		public static object Deserialize(this JsonElement element, Type returnType, JsonSerializerContext context)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, returnType);
			return JsonSerializer.ReadFromSpanAsObject(element.GetRawValue().Span, typeInfo, null);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00011FE8 File Offset: 0x000101E8
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>(this JsonNode node, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromNode<TValue>(node, typeInfo);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00012004 File Offset: 0x00010204
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static object Deserialize(this JsonNode node, [Nullable(1)] Type returnType, JsonSerializerOptions options = null)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromNodeAsObject(node, typeInfo);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001202D File Offset: 0x0001022D
		[NullableContext(2)]
		public static TValue Deserialize<TValue>(this JsonNode node, [Nullable(1)] JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromNode<TValue>(node, jsonTypeInfo);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00012049 File Offset: 0x00010249
		[NullableContext(2)]
		public static object Deserialize(this JsonNode node, [Nullable(1)] JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromNodeAsObject(node, jsonTypeInfo);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00012068 File Offset: 0x00010268
		[return: Nullable(2)]
		public static object Deserialize([Nullable(2)] this JsonNode node, Type returnType, JsonSerializerContext context)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, returnType);
			return JsonSerializer.ReadFromNodeAsObject(node, typeInfo);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000120A0 File Offset: 0x000102A0
		private static TValue ReadFromNode<TValue>(JsonNode node, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			TValue result;
			using (PooledByteBufferWriter pooledByteBufferWriter = new PooledByteBufferWriter(options.DefaultBufferSize))
			{
				using (Utf8JsonWriter utf8JsonWriter = new Utf8JsonWriter(pooledByteBufferWriter, options.GetWriterOptions()))
				{
					if (node == null)
					{
						utf8JsonWriter.WriteNullValue();
					}
					else
					{
						node.WriteTo(utf8JsonWriter, options);
					}
				}
				result = JsonSerializer.ReadFromSpan<TValue>(pooledByteBufferWriter.WrittenMemory.Span, jsonTypeInfo, null);
			}
			return result;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00012138 File Offset: 0x00010338
		private static object ReadFromNodeAsObject(JsonNode node, JsonTypeInfo jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			object result;
			using (PooledByteBufferWriter pooledByteBufferWriter = new PooledByteBufferWriter(options.DefaultBufferSize))
			{
				using (Utf8JsonWriter utf8JsonWriter = new Utf8JsonWriter(pooledByteBufferWriter, options.GetWriterOptions()))
				{
					if (node == null)
					{
						utf8JsonWriter.WriteNullValue();
					}
					else
					{
						node.WriteTo(utf8JsonWriter, options);
					}
				}
				result = JsonSerializer.ReadFromSpanAsObject(pooledByteBufferWriter.WrittenMemory.Span, jsonTypeInfo, null);
			}
			return result;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000121D0 File Offset: 0x000103D0
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonDocument SerializeToDocument<[Nullable(2)] TValue>(TValue value, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.WriteDocument<TValue>(value, typeInfo);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000121EC File Offset: 0x000103EC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonDocument SerializeToDocument([Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, inputType);
			return JsonSerializer.WriteDocumentAsObject(value, typeInfo);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001220F File Offset: 0x0001040F
		public static JsonDocument SerializeToDocument<[Nullable(2)] TValue>(TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteDocument<TValue>(value, jsonTypeInfo);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001222C File Offset: 0x0001042C
		public static JsonDocument SerializeToDocument([Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteDocumentAsObject(value, jsonTypeInfo);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00012248 File Offset: 0x00010448
		public static JsonDocument SerializeToDocument([Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			return JsonSerializer.WriteDocumentAsObject(value, JsonSerializer.GetTypeInfo(context, inputType));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001226C File Offset: 0x0001046C
		private static JsonDocument WriteDocument<TValue>(in TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter = new PooledByteBufferWriter(options.DefaultBufferSize);
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriter(options, pooledByteBufferWriter);
			JsonDocument result;
			try
			{
				jsonTypeInfo.Serialize(writer, value, null);
				result = JsonDocument.ParseRented(pooledByteBufferWriter, options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriter(writer);
			}
			return result;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000122C4 File Offset: 0x000104C4
		private static JsonDocument WriteDocumentAsObject(object value, JsonTypeInfo jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter = new PooledByteBufferWriter(options.DefaultBufferSize);
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriter(options, pooledByteBufferWriter);
			JsonDocument result;
			try
			{
				jsonTypeInfo.SerializeAsObject(writer, value);
				result = JsonDocument.ParseRented(pooledByteBufferWriter, options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriter(writer);
			}
			return result;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001231C File Offset: 0x0001051C
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonElement SerializeToElement<TValue>([Nullable(1)] TValue value, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.WriteElement<TValue>(value, typeInfo);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00012338 File Offset: 0x00010538
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonElement SerializeToElement(object value, [Nullable(1)] Type inputType, JsonSerializerOptions options = null)
		{
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, inputType);
			return JsonSerializer.WriteElementAsObject(value, typeInfo);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001235B File Offset: 0x0001055B
		public static JsonElement SerializeToElement<[Nullable(2)] TValue>(TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteElement<TValue>(value, jsonTypeInfo);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00012378 File Offset: 0x00010578
		public static JsonElement SerializeToElement([Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteElementAsObject(value, jsonTypeInfo);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00012394 File Offset: 0x00010594
		public static JsonElement SerializeToElement([Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, inputType);
			return JsonSerializer.WriteElementAsObject(value, typeInfo);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000123C4 File Offset: 0x000105C4
		private static JsonElement WriteElement<TValue>(in TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			JsonElement result;
			try
			{
				jsonTypeInfo.Serialize(writer, value, null);
				result = JsonElement.ParseValue(pooledByteBufferWriter.WrittenMemory.Span, options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00012428 File Offset: 0x00010628
		private static JsonElement WriteElementAsObject(object value, JsonTypeInfo jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			JsonElement result;
			try
			{
				jsonTypeInfo.SerializeAsObject(writer, value);
				result = JsonElement.ParseValue(pooledByteBufferWriter.WrittenMemory.Span, options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001248C File Offset: 0x0001068C
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonNode SerializeToNode<TValue>([Nullable(1)] TValue value, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.WriteNode<TValue>(value, typeInfo);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000124A8 File Offset: 0x000106A8
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonNode SerializeToNode(object value, [Nullable(1)] Type inputType, JsonSerializerOptions options = null)
		{
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, inputType);
			return JsonSerializer.WriteNodeAsObject(value, typeInfo);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000124CB File Offset: 0x000106CB
		[return: Nullable(2)]
		public static JsonNode SerializeToNode<[Nullable(2)] TValue>(TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteNode<TValue>(value, jsonTypeInfo);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000124E8 File Offset: 0x000106E8
		[NullableContext(2)]
		public static JsonNode SerializeToNode(object value, [Nullable(1)] JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteNodeAsObject(value, jsonTypeInfo);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00012504 File Offset: 0x00010704
		[return: Nullable(2)]
		public static JsonNode SerializeToNode([Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, inputType);
			return JsonSerializer.WriteNodeAsObject(value, typeInfo);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00012534 File Offset: 0x00010734
		private static JsonNode WriteNode<TValue>(in TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			JsonNode result;
			try
			{
				jsonTypeInfo.Serialize(writer, value, null);
				result = JsonNode.Parse(pooledByteBufferWriter.WrittenMemory.Span, new JsonNodeOptions?(options.GetNodeOptions()), options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000125A4 File Offset: 0x000107A4
		private static JsonNode WriteNodeAsObject(object value, JsonTypeInfo jsonTypeInfo)
		{
			JsonSerializerOptions options = jsonTypeInfo.Options;
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			JsonNode result;
			try
			{
				jsonTypeInfo.SerializeAsObject(writer, value);
				result = JsonNode.Parse(pooledByteBufferWriter.WrittenMemory.Span, new JsonNodeOptions?(options.GetNodeOptions()), options.GetDocumentOptions());
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00012610 File Offset: 0x00010810
		public static bool IsReflectionEnabledByDefault { get; }

		// Token: 0x06000428 RID: 1064 RVA: 0x00012617 File Offset: 0x00010817
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonTypeInfo GetTypeInfo(JsonSerializerOptions options, Type inputType)
		{
			if (options == null)
			{
				options = JsonSerializerOptions.Default;
			}
			options.MakeReadOnly(true);
			if (!(inputType == JsonTypeInfo.ObjectType))
			{
				return options.GetTypeInfoForRootType(inputType, false);
			}
			return options.ObjectTypeInfo;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00012646 File Offset: 0x00010846
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonTypeInfo<T> GetTypeInfo<T>(JsonSerializerOptions options)
		{
			return (JsonTypeInfo<T>)JsonSerializer.GetTypeInfo(options, typeof(T));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001265D File Offset: 0x0001085D
		private static JsonTypeInfo GetTypeInfo(JsonSerializerContext context, Type inputType)
		{
			JsonTypeInfo typeInfo = context.GetTypeInfo(inputType);
			if (typeInfo == null)
			{
				ThrowHelper.ThrowInvalidOperationException_NoMetadataForType(inputType, context);
			}
			typeInfo.EnsureConfigured();
			return typeInfo;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00012678 File Offset: 0x00010878
		private static void ValidateInputType(object value, Type inputType)
		{
			if (inputType == null)
			{
				ThrowHelper.ThrowArgumentNullException("inputType");
			}
			if (value != null)
			{
				Type type = value.GetType();
				if (!inputType.IsAssignableFrom(type))
				{
					ThrowHelper.ThrowArgumentException_DeserializeWrongType(inputType, value);
				}
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000126AC File Offset: 0x000108AC
		internal static bool IsValidNumberHandlingValue(JsonNumberHandling handling)
		{
			return JsonHelpers.IsInRangeInclusive((int)handling, 0, 7);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000126B8 File Offset: 0x000108B8
		internal static bool IsValidCreationHandlingValue(JsonObjectCreationHandling handling)
		{
			return handling <= JsonObjectCreationHandling.Populate;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000126D0 File Offset: 0x000108D0
		internal static bool IsValidUnmappedMemberHandlingValue(JsonUnmappedMemberHandling handling)
		{
			return handling <= JsonUnmappedMemberHandling.Disallow;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000126E8 File Offset: 0x000108E8
		[return: NotNullIfNotNull("value")]
		internal static T UnboxOnRead<T>(object value)
		{
			if (value == null)
			{
				if (default(T) != null)
				{
					JsonSerializer.<UnboxOnRead>g__ThrowUnableToCastValue|50_0<T>(value);
				}
				return default(T);
			}
			if (value is T)
			{
				return (T)((object)value);
			}
			JsonSerializer.<UnboxOnRead>g__ThrowUnableToCastValue|50_0<T>(value);
			return default(T);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00012738 File Offset: 0x00010938
		[return: NotNullIfNotNull("value")]
		internal static T UnboxOnWrite<T>(object value)
		{
			if (default(T) != null && value == null)
			{
				ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(typeof(T));
			}
			return (T)((object)value);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00012770 File Offset: 0x00010970
		internal static bool TryReadMetadata(JsonConverter converter, JsonTypeInfo jsonTypeInfo, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			bool allowOutOfOrderMetadataProperties = jsonTypeInfo.Options.AllowOutOfOrderMetadataProperties;
			bool flag = false;
			Utf8JsonReader utf8JsonReader;
			if (allowOutOfOrderMetadataProperties && !reader.IsFinalBlock)
			{
				utf8JsonReader = reader;
				if (!ref utf8JsonReader.TrySkipPartial())
				{
					return false;
				}
			}
			else
			{
				utf8JsonReader = default(Utf8JsonReader);
			}
			for (;;)
			{
				if (state.Current.PropertyState == StackFramePropertyState.None)
				{
					if (!reader.Read())
					{
						break;
					}
					state.Current.PropertyState = StackFramePropertyState.ReadName;
				}
				MetadataPropertyName metadataPropertyName;
				if (state.Current.PropertyState < StackFramePropertyState.Name)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						goto IL_3FB;
					}
					if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Ref) != MetadataPropertyName.None)
					{
						ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(ref reader.GetUnescapedSpan(), ref state);
					}
					ReadOnlySpan<byte> unescapedSpan = ref reader.GetUnescapedSpan();
					metadataPropertyName = (state.Current.LatestMetadataPropertyName = JsonSerializer.GetMetadataPropertyName(unescapedSpan, jsonTypeInfo.PolymorphicTypeResolver));
					switch (metadataPropertyName)
					{
					case MetadataPropertyName.Values:
						state.Current.JsonPropertyName = JsonSerializer.s_valuesPropertyName;
						if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Values) != MetadataPropertyName.None)
						{
							ThrowHelper.ThrowJsonException_DuplicateMetadataProperty(JsonSerializer.s_valuesPropertyName);
						}
						if (flag)
						{
							ThrowHelper.ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(ref state, jsonTypeInfo.Type, reader);
						}
						break;
					case MetadataPropertyName.Id:
						state.Current.JsonPropertyName = JsonSerializer.s_idPropertyName;
						if (state.ReferenceResolver == null)
						{
							ThrowHelper.ThrowJsonException_MetadataUnexpectedProperty(unescapedSpan, ref state);
						}
						if ((state.Current.MetadataPropertyNames & (MetadataPropertyName.Id | MetadataPropertyName.Ref)) != MetadataPropertyName.None)
						{
							ThrowHelper.ThrowJsonException_MetadataIdCannotBeCombinedWithRef(unescapedSpan, ref state);
						}
						if (!converter.CanHaveMetadata)
						{
							ThrowHelper.ThrowJsonException_MetadataCannotParsePreservedObjectIntoImmutable(converter.Type);
						}
						break;
					case MetadataPropertyName.Values | MetadataPropertyName.Id:
						goto IL_218;
					case MetadataPropertyName.Ref:
						state.Current.JsonPropertyName = JsonSerializer.s_refPropertyName;
						if (state.ReferenceResolver == null)
						{
							ThrowHelper.ThrowJsonException_MetadataUnexpectedProperty(unescapedSpan, ref state);
						}
						if (converter.IsValueType)
						{
							ThrowHelper.ThrowJsonException_MetadataInvalidReferenceToValueType(converter.Type);
						}
						if (state.Current.MetadataPropertyNames > MetadataPropertyName.None || flag)
						{
							ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(ref reader.GetUnescapedSpan(), ref state);
						}
						break;
					default:
					{
						if (metadataPropertyName != MetadataPropertyName.Type)
						{
							goto IL_218;
						}
						PolymorphicTypeResolver polymorphicTypeResolver = jsonTypeInfo.PolymorphicTypeResolver;
						state.Current.JsonPropertyName = (((polymorphicTypeResolver != null) ? polymorphicTypeResolver.CustomTypeDiscriminatorPropertyNameUtf8 : null) ?? JsonSerializer.s_typePropertyName);
						if (jsonTypeInfo.PolymorphicTypeResolver == null)
						{
							ThrowHelper.ThrowJsonException_MetadataUnexpectedProperty(unescapedSpan, ref state);
						}
						if (state.PolymorphicTypeDiscriminator != null)
						{
							ThrowHelper.ThrowJsonException_DuplicateMetadataProperty(state.Current.JsonPropertyName);
						}
						break;
					}
					}
					IL_257:
					state.Current.PropertyState = StackFramePropertyState.Name;
					goto IL_263;
					IL_218:
					if (!allowOutOfOrderMetadataProperties)
					{
						goto IL_3FB;
					}
					if (!flag)
					{
						flag = true;
						utf8JsonReader = reader;
					}
					if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Values) != MetadataPropertyName.None)
					{
						ThrowHelper.ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(ref state, jsonTypeInfo.Type, reader);
					}
					if (JsonSerializer.IsMetadataPropertyName(unescapedSpan, null))
					{
						ThrowHelper.ThrowUnexpectedMetadataException(unescapedSpan, ref reader, ref state);
						goto IL_257;
					}
					goto IL_257;
				}
				IL_263:
				if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
				{
					if (!reader.Read())
					{
						return false;
					}
					state.Current.PropertyState = StackFramePropertyState.ReadValue;
				}
				metadataPropertyName = state.Current.LatestMetadataPropertyName;
				switch (metadataPropertyName)
				{
				case MetadataPropertyName.Values:
					if (reader.TokenType != JsonTokenType.StartArray)
					{
						ThrowHelper.ThrowJsonException_MetadataValuesInvalidToken(reader.TokenType);
					}
					if (!allowOutOfOrderMetadataProperties)
					{
						goto IL_3A0;
					}
					flag = true;
					utf8JsonReader = reader;
					ref reader.SkipWithVerify();
					break;
				case MetadataPropertyName.Id:
					if (reader.TokenType != JsonTokenType.String)
					{
						ThrowHelper.ThrowJsonException_MetadataValueWasNotString(reader.TokenType);
					}
					if (state.ReferenceId != null)
					{
						ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
					}
					state.ReferenceId = reader.GetString();
					break;
				case MetadataPropertyName.Values | MetadataPropertyName.Id:
					goto IL_3BE;
				case MetadataPropertyName.Ref:
					if (reader.TokenType != JsonTokenType.String)
					{
						ThrowHelper.ThrowJsonException_MetadataValueWasNotString(reader.TokenType);
					}
					if (state.ReferenceId != null)
					{
						ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
					}
					state.ReferenceId = reader.GetString();
					break;
				default:
				{
					if (metadataPropertyName != MetadataPropertyName.Type)
					{
						goto IL_3BE;
					}
					JsonTokenType tokenType = reader.TokenType;
					if (tokenType != JsonTokenType.String)
					{
						if (tokenType != JsonTokenType.Number)
						{
							ThrowHelper.ThrowJsonException_MetadataValueWasNotString(reader.TokenType);
						}
						else
						{
							state.PolymorphicTypeDiscriminator = reader.GetInt32();
						}
					}
					else
					{
						state.PolymorphicTypeDiscriminator = reader.GetString();
					}
					break;
				}
				}
				IL_3C4:
				state.Current.MetadataPropertyNames = (state.Current.MetadataPropertyNames | state.Current.LatestMetadataPropertyName);
				state.Current.PropertyState = StackFramePropertyState.None;
				state.Current.JsonPropertyName = null;
				continue;
				IL_3BE:
				ref reader.SkipWithVerify();
				goto IL_3C4;
			}
			return false;
			IL_3A0:
			state.Current.MetadataPropertyNames = (state.Current.MetadataPropertyNames | MetadataPropertyName.Values);
			state.Current.PropertyState = StackFramePropertyState.None;
			IL_3FB:
			if (state.Current.MetadataPropertyNames == MetadataPropertyName.Values)
			{
				ThrowHelper.ThrowJsonException_MetadataStandaloneValuesProperty(ref state, JsonSerializer.s_valuesPropertyName);
			}
			if (flag)
			{
				reader = utf8JsonReader;
			}
			return true;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00012BA4 File Offset: 0x00010DA4
		internal unsafe static bool IsMetadataPropertyName(ReadOnlySpan<byte> propertyName, PolymorphicTypeResolver resolver)
		{
			if (propertyName.Length > 0 && *propertyName[0] == 36)
			{
				return true;
			}
			if (resolver == null)
			{
				return false;
			}
			byte[] customTypeDiscriminatorPropertyNameUtf = resolver.CustomTypeDiscriminatorPropertyNameUtf8;
			return ((customTypeDiscriminatorPropertyNameUtf != null) ? new bool?(customTypeDiscriminatorPropertyNameUtf.AsSpan<byte>().SequenceEqual(propertyName)) : null).GetValueOrDefault();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00012BFC File Offset: 0x00010DFC
		internal unsafe static MetadataPropertyName GetMetadataPropertyName(ReadOnlySpan<byte> propertyName, PolymorphicTypeResolver resolver)
		{
			if (propertyName.Length > 0 && *propertyName[0] == 36)
			{
				switch (propertyName.Length)
				{
				case 3:
					if (propertyName.SequenceEqual(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F630228BD37E08E6923D5691940E6DFEEDB75FB8BC0780EE1ABA98C0C1A49778), 3)))
					{
						return MetadataPropertyName.Id;
					}
					break;
				case 4:
					if (propertyName.SequenceEqual(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.84499CE395D80E3A7694D419919F5383E3C8B46E4B78F0FA291576406ECE3FA2), 4)))
					{
						return MetadataPropertyName.Ref;
					}
					break;
				case 5:
					if (((resolver != null) ? resolver.CustomTypeDiscriminatorPropertyNameUtf8 : null) == null && propertyName.SequenceEqual(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.AB50C59D4F64B05ABA854F60FD7DA6C6EB8F4715BCCE00520E5ACA886CB5B92C), 5)))
					{
						return MetadataPropertyName.Type;
					}
					break;
				case 7:
					if (propertyName.SequenceEqual(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F2CBFF984BEDEC6EBB2619964766BBE0A2EF28F9A3E5FF81ED9B35C90A9E1C70), 7)))
					{
						return MetadataPropertyName.Values;
					}
					break;
				}
			}
			byte[] array = (resolver != null) ? resolver.CustomTypeDiscriminatorPropertyNameUtf8 : null;
			if (array != null && propertyName.SequenceEqual(array))
			{
				return MetadataPropertyName.Type;
			}
			return MetadataPropertyName.None;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00012CD0 File Offset: 0x00010ED0
		internal static bool TryHandleReferenceFromJsonElement(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonElement element, [NotNullWhen(true)] out object referenceValue)
		{
			bool flag = false;
			referenceValue = null;
			if (element.ValueKind == JsonValueKind.Object)
			{
				int num = 0;
				foreach (JsonProperty jsonProperty in element.EnumerateObject())
				{
					num++;
					if (flag)
					{
						ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties();
					}
					else
					{
						if (jsonProperty.EscapedNameEquals(JsonSerializer.s_idPropertyName))
						{
							if (state.ReferenceId != null)
							{
								ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
							}
							if (jsonProperty.Value.ValueKind != JsonValueKind.String)
							{
								ThrowHelper.ThrowJsonException_MetadataValueWasNotString(jsonProperty.Value.ValueKind);
							}
							object obj = element;
							state.ReferenceResolver.AddReference(jsonProperty.Value.GetString(), obj);
							referenceValue = obj;
							return true;
						}
						if (jsonProperty.EscapedNameEquals(JsonSerializer.s_refPropertyName))
						{
							if (state.ReferenceId != null)
							{
								ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
							}
							if (num > 1)
							{
								ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties();
							}
							if (jsonProperty.Value.ValueKind != JsonValueKind.String)
							{
								ThrowHelper.ThrowJsonException_MetadataValueWasNotString(jsonProperty.Value.ValueKind);
							}
							referenceValue = state.ReferenceResolver.ResolveReference(jsonProperty.Value.GetString());
							flag = true;
						}
					}
				}
				return flag;
			}
			return flag;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00012E60 File Offset: 0x00011060
		internal static bool TryHandleReferenceFromJsonNode(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonNode jsonNode, [NotNullWhen(true)] out object referenceValue)
		{
			bool flag = false;
			referenceValue = null;
			JsonObject jsonObject = jsonNode as JsonObject;
			if (jsonObject != null)
			{
				int num = 0;
				foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
				{
					num++;
					if (flag)
					{
						ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties();
					}
					else
					{
						if (keyValuePair.Key == "$id")
						{
							if (state.ReferenceId != null)
							{
								ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
							}
							string referenceId = JsonSerializer.<TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(keyValuePair.Value);
							state.ReferenceResolver.AddReference(referenceId, jsonNode);
							referenceValue = jsonNode;
							return true;
						}
						if (keyValuePair.Key == "$ref")
						{
							if (state.ReferenceId != null)
							{
								ThrowHelper.ThrowNotSupportedException_ObjectWithParameterizedCtorRefMetadataNotSupported(JsonSerializer.s_refPropertyName, ref reader, ref state);
							}
							if (num > 1)
							{
								ThrowHelper.ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties();
							}
							string referenceId2 = JsonSerializer.<TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(keyValuePair.Value);
							referenceValue = state.ReferenceResolver.ResolveReference(referenceId2);
							flag = true;
						}
					}
				}
				return flag;
			}
			return flag;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00012F78 File Offset: 0x00011178
		internal static void ValidateMetadataForObjectConverter(ref ReadStack state)
		{
			if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Values) != MetadataPropertyName.None)
			{
				ThrowHelper.ThrowJsonException_MetadataUnexpectedProperty(JsonSerializer.s_valuesPropertyName, ref state);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00012F9C File Offset: 0x0001119C
		internal static void ValidateMetadataForArrayConverter(JsonConverter converter, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType != JsonTokenType.EndObject)
			{
				if (tokenType != JsonTokenType.StartArray)
				{
					ThrowHelper.ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(ref state, converter.Type, reader);
				}
			}
			else if (state.Current.MetadataPropertyNames != MetadataPropertyName.Ref)
			{
				ThrowHelper.ThrowJsonException_MetadataPreservedArrayValuesNotFound(ref state, converter.Type);
				return;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00012FE4 File Offset: 0x000111E4
		internal static T ResolveReferenceId<T>(ref ReadStack state)
		{
			string referenceId = state.ReferenceId;
			object obj = state.ReferenceResolver.ResolveReference(referenceId);
			state.ReferenceId = null;
			T result;
			try
			{
				result = (T)((object)obj);
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowInvalidOperationException_MetadataReferenceOfTypeCannotBeAssignedToType(referenceId, obj.GetType(), typeof(T));
				result = default(T);
			}
			return result;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001304C File Offset: 0x0001124C
		internal static JsonPropertyInfo LookupProperty(object obj, ReadOnlySpan<byte> unescapedPropertyName, ref ReadStack state, JsonSerializerOptions options, out bool useExtensionProperty, bool createExtensionProperty = true)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			useExtensionProperty = false;
			byte[] jsonPropertyName;
			JsonPropertyInfo jsonPropertyInfo = jsonTypeInfo.GetProperty(unescapedPropertyName, ref state.Current, out jsonPropertyName);
			state.Current.PropertyIndex = state.Current.PropertyIndex + 1;
			state.Current.JsonPropertyName = jsonPropertyName;
			if (jsonPropertyInfo == null)
			{
				if (jsonTypeInfo.EffectiveUnmappedMemberHandling == JsonUnmappedMemberHandling.Disallow)
				{
					string unmappedPropertyName = JsonHelpers.Utf8GetString(unescapedPropertyName);
					ThrowHelper.ThrowJsonException_UnmappedJsonProperty(jsonTypeInfo.Type, unmappedPropertyName);
				}
				JsonPropertyInfo extensionDataProperty = jsonTypeInfo.ExtensionDataProperty;
				if (extensionDataProperty != null && extensionDataProperty.HasGetter && extensionDataProperty.HasSetter)
				{
					state.Current.JsonPropertyNameAsString = JsonHelpers.Utf8GetString(unescapedPropertyName);
					if (createExtensionProperty)
					{
						JsonSerializer.CreateExtensionDataProperty(obj, extensionDataProperty, options);
					}
					jsonPropertyInfo = extensionDataProperty;
					useExtensionProperty = true;
				}
				else
				{
					jsonPropertyInfo = JsonPropertyInfo.s_missingProperty;
				}
			}
			state.Current.JsonPropertyInfo = jsonPropertyInfo;
			state.Current.NumberHandling = jsonPropertyInfo.EffectiveNumberHandling;
			return jsonPropertyInfo;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001311C File Offset: 0x0001131C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ReadOnlySpan<byte> GetPropertyName([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options, out bool isAlreadyReadMetadataProperty)
		{
			ReadOnlySpan<byte> unescapedSpan = ref reader.GetUnescapedSpan();
			isAlreadyReadMetadataProperty = false;
			if (state.Current.CanContainMetadata && JsonSerializer.IsMetadataPropertyName(unescapedSpan, state.Current.BaseJsonTypeInfo.PolymorphicTypeResolver))
			{
				if (options.AllowOutOfOrderMetadataProperties)
				{
					isAlreadyReadMetadataProperty = true;
				}
				else
				{
					ThrowHelper.ThrowUnexpectedMetadataException(unescapedSpan, ref reader, ref state);
				}
			}
			return unescapedSpan;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00013170 File Offset: 0x00011370
		internal static void CreateExtensionDataProperty(object obj, JsonPropertyInfo jsonPropertyInfo, JsonSerializerOptions options)
		{
			if (jsonPropertyInfo.GetValueAsObject(obj) == null)
			{
				Func<object> func = jsonPropertyInfo.JsonTypeInfo.CreateObject ?? jsonPropertyInfo.JsonTypeInfo.CreateObjectForExtensionDataProperty;
				if (func == null)
				{
					if (jsonPropertyInfo.PropertyType.FullName == "System.Text.Json.Nodes.JsonObject")
					{
						ThrowHelper.ThrowInvalidOperationException_NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty();
					}
					else
					{
						ThrowHelper.ThrowNotSupportedException_SerializationNotSupported(jsonPropertyInfo.PropertyType);
					}
				}
				object arg = func();
				jsonPropertyInfo.Set(obj, arg);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000131E4 File Offset: 0x000113E4
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>([Nullable(0)] ReadOnlySpan<byte> utf8Json, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromSpan<TValue>(utf8Json, typeInfo, null);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00013208 File Offset: 0x00011408
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static object Deserialize([Nullable(0)] ReadOnlySpan<byte> utf8Json, [Nullable(1)] Type returnType, JsonSerializerOptions options = null)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromSpanAsObject(utf8Json, typeInfo, null);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001323C File Offset: 0x0001143C
		[NullableContext(2)]
		public static TValue Deserialize<TValue>([Nullable(0)] ReadOnlySpan<byte> utf8Json, [Nullable(1)] JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpan<TValue>(utf8Json, jsonTypeInfo, null);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001326C File Offset: 0x0001146C
		[NullableContext(0)]
		[return: Nullable(2)]
		public static object Deserialize(ReadOnlySpan<byte> utf8Json, [Nullable(1)] JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpanAsObject(utf8Json, jsonTypeInfo, null);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001329C File Offset: 0x0001149C
		[return: Nullable(2)]
		public static object Deserialize([Nullable(0)] ReadOnlySpan<byte> utf8Json, Type returnType, JsonSerializerContext context)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			return JsonSerializer.ReadFromSpanAsObject(utf8Json, JsonSerializer.GetTypeInfo(context, returnType), null);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000132DC File Offset: 0x000114DC
		private static TValue ReadFromSpan<TValue>(ReadOnlySpan<byte> utf8Json, JsonTypeInfo<TValue> jsonTypeInfo, int? actualByteCount = null)
		{
			JsonReaderState state = new JsonReaderState(jsonTypeInfo.Options.GetReaderOptions());
			Utf8JsonReader utf8JsonReader = new Utf8JsonReader(utf8Json, true, state);
			ReadStack readStack = default(ReadStack);
			readStack.Initialize(jsonTypeInfo, false);
			return jsonTypeInfo.Deserialize(ref utf8JsonReader, ref readStack);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00013320 File Offset: 0x00011520
		private static object ReadFromSpanAsObject(ReadOnlySpan<byte> utf8Json, JsonTypeInfo jsonTypeInfo, int? actualByteCount = null)
		{
			JsonReaderState state = new JsonReaderState(jsonTypeInfo.Options.GetReaderOptions());
			Utf8JsonReader utf8JsonReader = new Utf8JsonReader(utf8Json, true, state);
			ReadStack readStack = default(ReadStack);
			readStack.Initialize(jsonTypeInfo, false);
			return jsonTypeInfo.DeserializeAsObject(ref utf8JsonReader, ref readStack);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00013364 File Offset: 0x00011564
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTask<TValue> DeserializeAsync<TValue>([Nullable(1)] Stream utf8Json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonSerializer.GetTypeInfo<TValue>(options).DeserializeAsync(utf8Json, cancellationToken);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00013380 File Offset: 0x00011580
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>([Nullable(1)] Stream utf8Json, JsonSerializerOptions options = null)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonSerializer.GetTypeInfo<TValue>(options).Deserialize(utf8Json);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001339B File Offset: 0x0001159B
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTask<object> DeserializeAsync(Stream utf8Json, Type returnType, [Nullable(2)] JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			return JsonSerializer.GetTypeInfo(options, returnType).DeserializeAsObjectAsync(utf8Json, cancellationToken);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000133C5 File Offset: 0x000115C5
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(2)]
		public static object Deserialize(Stream utf8Json, Type returnType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			return JsonSerializer.GetTypeInfo(options, returnType).DeserializeAsObject(utf8Json);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000133EE File Offset: 0x000115EE
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTask<TValue> DeserializeAsync<[Nullable(2)] TValue>(Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.DeserializeAsync(utf8Json, cancellationToken);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00013418 File Offset: 0x00011618
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTask<object> DeserializeAsync(Stream utf8Json, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.DeserializeAsObjectAsync(utf8Json, cancellationToken);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00013442 File Offset: 0x00011642
		[return: Nullable(2)]
		public static TValue Deserialize<[Nullable(2)] TValue>(Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.Deserialize(utf8Json);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001346B File Offset: 0x0001166B
		[return: Nullable(2)]
		public static object Deserialize(Stream utf8Json, JsonTypeInfo jsonTypeInfo)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.DeserializeAsObject(utf8Json);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00013494 File Offset: 0x00011694
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTask<object> DeserializeAsync(Stream utf8Json, Type returnType, JsonSerializerContext context, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			return JsonSerializer.GetTypeInfo(context, returnType).DeserializeAsObjectAsync(utf8Json, cancellationToken);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000134CB File Offset: 0x000116CB
		[return: Nullable(2)]
		public static object Deserialize(Stream utf8Json, Type returnType, JsonSerializerContext context)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			return JsonSerializer.GetTypeInfo(context, returnType).DeserializeAsObject(utf8Json);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00013501 File Offset: 0x00011701
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static IAsyncEnumerable<TValue> DeserializeAsyncEnumerable<TValue>([Nullable(1)] Stream utf8Json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JsonSerializer.DeserializeAsyncEnumerable<TValue>(utf8Json, false, options, cancellationToken);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001350C File Offset: 0x0001170C
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static IAsyncEnumerable<TValue> DeserializeAsyncEnumerable<TValue>([Nullable(1)] Stream utf8Json, bool topLevelValues, JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.DeserializeAsyncEnumerableCore<TValue>(utf8Json, typeInfo, topLevelValues, cancellationToken);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00013536 File Offset: 0x00011736
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static IAsyncEnumerable<TValue> DeserializeAsyncEnumerable<[Nullable(2)] TValue>(Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JsonSerializer.DeserializeAsyncEnumerable<TValue>(utf8Json, jsonTypeInfo, false, cancellationToken);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00013541 File Offset: 0x00011741
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static IAsyncEnumerable<TValue> DeserializeAsyncEnumerable<[Nullable(2)] TValue>(Stream utf8Json, JsonTypeInfo<TValue> jsonTypeInfo, bool topLevelValues, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.DeserializeAsyncEnumerableCore<TValue>(utf8Json, jsonTypeInfo, topLevelValues, cancellationToken);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001356C File Offset: 0x0001176C
		private static IAsyncEnumerable<T> DeserializeAsyncEnumerableCore<T>(Stream utf8Json, JsonTypeInfo<T> jsonTypeInfo, bool topLevelValues, CancellationToken cancellationToken)
		{
			JsonReaderOptions readerOptions = jsonTypeInfo.Options.GetReaderOptions();
			JsonTypeInfo<List<T>> listTypeInfo;
			if (topLevelValues)
			{
				listTypeInfo = JsonSerializer.<DeserializeAsyncEnumerableCore>g__GetOrAddListTypeInfoForRootLevelValueMode|92_2<T>(jsonTypeInfo);
				readerOptions.AllowMultipleValues = true;
			}
			else
			{
				listTypeInfo = JsonSerializer.<DeserializeAsyncEnumerableCore>g__GetOrAddListTypeInfoForArrayMode|92_1<T>(jsonTypeInfo);
			}
			return JsonSerializer.<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0<T>(utf8Json, listTypeInfo, readerOptions, cancellationToken);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000135AC File Offset: 0x000117AC
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>([Nullable(1)] [StringSyntax("Json")] string json, JsonSerializerOptions options = null)
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromSpan<TValue>(json.AsSpan(), typeInfo);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000135DC File Offset: 0x000117DC
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>([Nullable(0)] [StringSyntax("Json")] ReadOnlySpan<char> json, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.ReadFromSpan<TValue>(json, typeInfo);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000135F8 File Offset: 0x000117F8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[return: Nullable(2)]
		public static object Deserialize([StringSyntax("Json")] string json, Type returnType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromSpanAsObject(json.AsSpan(), typeInfo);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00013634 File Offset: 0x00011834
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static object Deserialize([Nullable(0)] [StringSyntax("Json")] ReadOnlySpan<char> json, [Nullable(1)] Type returnType, JsonSerializerOptions options = null)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadFromSpanAsObject(json, typeInfo);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001365D File Offset: 0x0001185D
		[return: Nullable(2)]
		public static TValue Deserialize<[Nullable(2)] TValue>([StringSyntax("Json")] string json, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpan<TValue>(json.AsSpan(), jsonTypeInfo);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001368B File Offset: 0x0001188B
		[NullableContext(2)]
		public static TValue Deserialize<TValue>([Nullable(0)] [StringSyntax("Json")] ReadOnlySpan<char> json, [Nullable(1)] JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpan<TValue>(json, jsonTypeInfo);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000136A7 File Offset: 0x000118A7
		[return: Nullable(2)]
		public static object Deserialize([StringSyntax("Json")] string json, JsonTypeInfo jsonTypeInfo)
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpanAsObject(json.AsSpan(), jsonTypeInfo);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000136D5 File Offset: 0x000118D5
		[NullableContext(0)]
		[return: Nullable(2)]
		public static object Deserialize([StringSyntax("Json")] ReadOnlySpan<char> json, [Nullable(1)] JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadFromSpanAsObject(json, jsonTypeInfo);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000136F4 File Offset: 0x000118F4
		[return: Nullable(2)]
		public static object Deserialize([StringSyntax("Json")] string json, Type returnType, JsonSerializerContext context)
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, returnType);
			return JsonSerializer.ReadFromSpanAsObject(json.AsSpan(), typeInfo);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001373C File Offset: 0x0001193C
		[return: Nullable(2)]
		public static object Deserialize([Nullable(0)] [StringSyntax("Json")] ReadOnlySpan<char> json, Type returnType, JsonSerializerContext context)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, returnType);
			return JsonSerializer.ReadFromSpanAsObject(json, typeInfo);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00013774 File Offset: 0x00011974
		private unsafe static TValue ReadFromSpan<TValue>(ReadOnlySpan<char> json, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			byte[] array = null;
			Span<byte> span;
			if (json.Length <= 85)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (((long)json.Length <= 357913941L) ? (array = ArrayPool<byte>.Shared.Rent(json.Length * 3)) : new byte[JsonReaderHelper.GetUtf8ByteCount(json)]);
			}
			Span<byte> span2 = span;
			TValue result;
			try
			{
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(json, span2);
				span2 = span2.Slice(0, utf8FromText);
				result = JsonSerializer.ReadFromSpan<TValue>(span2, jsonTypeInfo, new int?(utf8FromText));
			}
			finally
			{
				if (array != null)
				{
					span2.Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return result;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00013830 File Offset: 0x00011A30
		private unsafe static object ReadFromSpanAsObject(ReadOnlySpan<char> json, JsonTypeInfo jsonTypeInfo)
		{
			byte[] array = null;
			Span<byte> span;
			if (json.Length <= 85)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (((long)json.Length <= 357913941L) ? (array = ArrayPool<byte>.Shared.Rent(json.Length * 3)) : new byte[JsonReaderHelper.GetUtf8ByteCount(json)]);
			}
			Span<byte> span2 = span;
			object result;
			try
			{
				int utf8FromText = JsonReaderHelper.GetUtf8FromText(json, span2);
				span2 = span2.Slice(0, utf8FromText);
				result = JsonSerializer.ReadFromSpanAsObject(span2, jsonTypeInfo, new int?(utf8FromText));
			}
			finally
			{
				if (array != null)
				{
					span2.Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return result;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000138EC File Offset: 0x00011AEC
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static TValue Deserialize<TValue>(ref Utf8JsonReader reader, JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.Read<TValue>(ref reader, typeInfo);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00013908 File Offset: 0x00011B08
		[NullableContext(2)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static object Deserialize(ref Utf8JsonReader reader, [Nullable(1)] Type returnType, JsonSerializerOptions options = null)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, returnType);
			return JsonSerializer.ReadAsObject(ref reader, typeInfo);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00013931 File Offset: 0x00011B31
		[NullableContext(2)]
		public static TValue Deserialize<TValue>(ref Utf8JsonReader reader, [Nullable(1)] JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.Read<TValue>(ref reader, jsonTypeInfo);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001394D File Offset: 0x00011B4D
		[return: Nullable(2)]
		public static object Deserialize(ref Utf8JsonReader reader, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.ReadAsObject(ref reader, jsonTypeInfo);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00013969 File Offset: 0x00011B69
		[return: Nullable(2)]
		public static object Deserialize(ref Utf8JsonReader reader, Type returnType, JsonSerializerContext context)
		{
			if (returnType == null)
			{
				ThrowHelper.ThrowArgumentNullException("returnType");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			return JsonSerializer.ReadAsObject(ref reader, JsonSerializer.GetTypeInfo(context, returnType));
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00013994 File Offset: 0x00011B94
		private static TValue Read<TValue>(ref Utf8JsonReader reader, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (reader.CurrentState.Options.CommentHandling == JsonCommentHandling.Allow)
			{
				ThrowHelper.ThrowArgumentException_SerializerDoesNotSupportComments("reader");
			}
			ReadStack readStack = default(ReadStack);
			readStack.Initialize(jsonTypeInfo, false);
			Utf8JsonReader utf8JsonReader = reader;
			TValue result;
			try
			{
				Utf8JsonReader readerScopedToNextValue = JsonSerializer.GetReaderScopedToNextValue(ref reader, ref readStack);
				result = jsonTypeInfo.Deserialize(ref readerScopedToNextValue, ref readStack);
			}
			catch (JsonException)
			{
				reader = utf8JsonReader;
				throw;
			}
			return result;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00013A10 File Offset: 0x00011C10
		private static object ReadAsObject(ref Utf8JsonReader reader, JsonTypeInfo jsonTypeInfo)
		{
			if (reader.CurrentState.Options.CommentHandling == JsonCommentHandling.Allow)
			{
				ThrowHelper.ThrowArgumentException_SerializerDoesNotSupportComments("reader");
			}
			ReadStack readStack = default(ReadStack);
			readStack.Initialize(jsonTypeInfo, false);
			Utf8JsonReader utf8JsonReader = reader;
			object result;
			try
			{
				Utf8JsonReader readerScopedToNextValue = JsonSerializer.GetReaderScopedToNextValue(ref reader, ref readStack);
				result = jsonTypeInfo.DeserializeAsObject(ref readerScopedToNextValue, ref readStack);
			}
			catch (JsonException)
			{
				reader = utf8JsonReader;
				throw;
			}
			return result;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00013A8C File Offset: 0x00011C8C
		private unsafe static Utf8JsonReader GetReaderScopedToNextValue(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			ReadOnlySpan<byte> jsonData = default(ReadOnlySpan<byte>);
			ReadOnlySequence<byte> jsonData2 = default(ReadOnlySequence<byte>);
			try
			{
				JsonTokenType tokenType = reader.TokenType;
				if ((tokenType == JsonTokenType.None || tokenType == JsonTokenType.PropertyName) && !reader.Read())
				{
					ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.ExpectedOneCompleteToken, 0, default(ReadOnlySpan<byte>));
				}
				switch (reader.TokenType)
				{
				case JsonTokenType.StartObject:
				case JsonTokenType.StartArray:
				{
					long tokenStartIndex = reader.TokenStartIndex;
					if (!reader.TrySkip())
					{
						ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.NotEnoughData, 0, default(ReadOnlySpan<byte>));
					}
					long num = reader.BytesConsumed - tokenStartIndex;
					ReadOnlySequence<byte> originalSequence = reader.OriginalSequence;
					if (originalSequence.IsEmpty)
					{
						jsonData = checked(reader.OriginalSpan.Slice((int)tokenStartIndex, (int)num));
						goto IL_1D4;
					}
					jsonData2 = originalSequence.Slice(tokenStartIndex, num);
					goto IL_1D4;
				}
				case JsonTokenType.String:
				{
					ReadOnlySequence<byte> originalSequence2 = reader.OriginalSequence;
					if (originalSequence2.IsEmpty)
					{
						int length = reader.ValueSpan.Length + 2;
						jsonData = reader.OriginalSpan.Slice((int)reader.TokenStartIndex, length);
						goto IL_1D4;
					}
					long length2 = reader.HasValueSequence ? (reader.ValueSequence.Length + 2L) : ((long)(reader.ValueSpan.Length + 2));
					jsonData2 = originalSequence2.Slice(reader.TokenStartIndex, length2);
					goto IL_1D4;
				}
				case JsonTokenType.Number:
				case JsonTokenType.True:
				case JsonTokenType.False:
				case JsonTokenType.Null:
					if (reader.HasValueSequence)
					{
						jsonData2 = reader.ValueSequence;
						goto IL_1D4;
					}
					jsonData = reader.ValueSpan;
					goto IL_1D4;
				}
				byte nextByte = reader.HasValueSequence ? (*reader.ValueSequence.First.Span[0]) : (*reader.ValueSpan[0]);
				ThrowHelper.ThrowJsonReaderException(ref reader, ExceptionResource.ExpectedStartOfValueNotFound, nextByte, default(ReadOnlySpan<byte>));
				IL_1D4:;
			}
			catch (JsonReaderException ex)
			{
				ThrowHelper.ReThrowWithPath(ref state, ex);
			}
			if (!jsonData.IsEmpty)
			{
				return new Utf8JsonReader(jsonData, reader.CurrentState.Options);
			}
			return new Utf8JsonReader(jsonData2, reader.CurrentState.Options);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00013CCC File Offset: 0x00011ECC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static byte[] SerializeToUtf8Bytes<[Nullable(2)] TValue>(TValue value, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.WriteBytes<TValue>(value, typeInfo);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00013CE8 File Offset: 0x00011EE8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static byte[] SerializeToUtf8Bytes([Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, inputType);
			return JsonSerializer.WriteBytesAsObject(value, typeInfo);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00013D0B File Offset: 0x00011F0B
		public static byte[] SerializeToUtf8Bytes<[Nullable(2)] TValue>(TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteBytes<TValue>(value, jsonTypeInfo);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00013D28 File Offset: 0x00011F28
		public static byte[] SerializeToUtf8Bytes([Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteBytesAsObject(value, jsonTypeInfo);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00013D44 File Offset: 0x00011F44
		public static byte[] SerializeToUtf8Bytes([Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, inputType);
			return JsonSerializer.WriteBytesAsObject(value, typeInfo);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00013D74 File Offset: 0x00011F74
		private static byte[] WriteBytes<TValue>(in TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			byte[] result;
			try
			{
				jsonTypeInfo.Serialize(writer, value, null);
				result = pooledByteBufferWriter.WrittenMemory.ToArray();
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00013DC4 File Offset: 0x00011FC4
		private static byte[] WriteBytesAsObject(object value, JsonTypeInfo jsonTypeInfo)
		{
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			byte[] result;
			try
			{
				jsonTypeInfo.SerializeAsObject(writer, value);
				result = pooledByteBufferWriter.WrittenMemory.ToArray();
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00013E14 File Offset: 0x00012014
		internal static MetadataPropertyName WriteMetadataForObject(JsonConverter jsonConverter, ref WriteStack state, Utf8JsonWriter writer)
		{
			MetadataPropertyName metadataPropertyName = MetadataPropertyName.None;
			if (state.NewReferenceId != null)
			{
				writer.WriteString(JsonSerializer.s_metadataId, state.NewReferenceId);
				metadataPropertyName |= MetadataPropertyName.Id;
				state.NewReferenceId = null;
			}
			object polymorphicTypeDiscriminator = state.PolymorphicTypeDiscriminator;
			if (polymorphicTypeDiscriminator != null)
			{
				JsonEncodedText? customTypeDiscriminatorPropertyNameJsonEncoded = state.PolymorphicTypeResolver.CustomTypeDiscriminatorPropertyNameJsonEncoded;
				JsonEncodedText jsonEncodedText;
				if (customTypeDiscriminatorPropertyNameJsonEncoded != null)
				{
					JsonEncodedText valueOrDefault = customTypeDiscriminatorPropertyNameJsonEncoded.GetValueOrDefault();
					jsonEncodedText = valueOrDefault;
				}
				else
				{
					jsonEncodedText = JsonSerializer.s_metadataType;
				}
				JsonEncodedText propertyName = jsonEncodedText;
				string text = polymorphicTypeDiscriminator as string;
				if (text != null)
				{
					writer.WriteString(propertyName, text);
				}
				else
				{
					writer.WriteNumber(propertyName, (int)polymorphicTypeDiscriminator);
				}
				metadataPropertyName |= MetadataPropertyName.Type;
				state.PolymorphicTypeDiscriminator = null;
			}
			return metadataPropertyName;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00013EAA File Offset: 0x000120AA
		internal static MetadataPropertyName WriteMetadataForCollection(JsonConverter jsonConverter, ref WriteStack state, Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			MetadataPropertyName result = JsonSerializer.WriteMetadataForObject(jsonConverter, ref state, writer);
			writer.WritePropertyName(JsonSerializer.s_metadataValues);
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00013EC8 File Offset: 0x000120C8
		internal static bool TryGetReferenceForValue(object currentValue, ref WriteStack state, Utf8JsonWriter writer)
		{
			bool flag;
			string reference = state.ReferenceResolver.GetReference(currentValue, out flag);
			if (flag)
			{
				writer.WriteStartObject();
				writer.WriteString(JsonSerializer.s_metadataRef, reference);
				writer.WriteEndObject();
				state.PolymorphicTypeDiscriminator = null;
				state.PolymorphicTypeResolver = null;
			}
			else
			{
				state.NewReferenceId = reference;
			}
			return flag;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00013F17 File Offset: 0x00012117
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static Task SerializeAsync<[Nullable(2)] TValue>(Stream utf8Json, TValue value, [Nullable(2)] JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonSerializer.GetTypeInfo<TValue>(options).SerializeAsync(utf8Json, value, cancellationToken, null);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00013F35 File Offset: 0x00012135
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static void Serialize<[Nullable(2)] TValue>(Stream utf8Json, TValue value, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			JsonSerializer.GetTypeInfo<TValue>(options).Serialize(utf8Json, value, null);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00013F53 File Offset: 0x00012153
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static Task SerializeAsync(Stream utf8Json, [Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			return JsonSerializer.GetTypeInfo(options, inputType).SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00013F79 File Offset: 0x00012179
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static void Serialize(Stream utf8Json, [Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonSerializer.GetTypeInfo(options, inputType).SerializeAsObject(utf8Json, value);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00013F9D File Offset: 0x0001219D
		public static Task SerializeAsync<[Nullable(2)] TValue>(Stream utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.SerializeAsync(utf8Json, value, cancellationToken, null);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00013FC9 File Offset: 0x000121C9
		public static void Serialize<[Nullable(2)] TValue>(Stream utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			jsonTypeInfo.Serialize(utf8Json, value, null);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00013FF5 File Offset: 0x000121F5
		public static Task SerializeAsync(Stream utf8Json, [Nullable(2)] object value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00014020 File Offset: 0x00012220
		public static void Serialize(Stream utf8Json, [Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			jsonTypeInfo.SerializeAsObject(utf8Json, value);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001404A File Offset: 0x0001224A
		public static Task SerializeAsync(Stream utf8Json, [Nullable(2)] object value, Type inputType, JsonSerializerContext context, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			return JsonSerializer.GetTypeInfo(context, inputType).SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001407D File Offset: 0x0001227D
		public static void Serialize(Stream utf8Json, [Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonSerializer.GetTypeInfo(context, inputType).SerializeAsObject(utf8Json, value);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000140B0 File Offset: 0x000122B0
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static string Serialize<[Nullable(2)] TValue>(TValue value, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonTypeInfo<TValue> typeInfo = JsonSerializer.GetTypeInfo<TValue>(options);
			return JsonSerializer.WriteString<TValue>(value, typeInfo);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000140CC File Offset: 0x000122CC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static string Serialize([Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(options, inputType);
			return JsonSerializer.WriteStringAsObject(value, typeInfo);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000140EF File Offset: 0x000122EF
		public static string Serialize<[Nullable(2)] TValue>(TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteString<TValue>(value, jsonTypeInfo);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001410C File Offset: 0x0001230C
		public static string Serialize([Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return JsonSerializer.WriteStringAsObject(value, jsonTypeInfo);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00014128 File Offset: 0x00012328
		public static string Serialize([Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonTypeInfo typeInfo = JsonSerializer.GetTypeInfo(context, inputType);
			return JsonSerializer.WriteStringAsObject(value, typeInfo);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00014158 File Offset: 0x00012358
		private static string WriteString<TValue>(in TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			string result;
			try
			{
				jsonTypeInfo.Serialize(writer, value, null);
				result = JsonReaderHelper.TranscodeHelper(pooledByteBufferWriter.WrittenMemory.Span);
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000141AC File Offset: 0x000123AC
		private static string WriteStringAsObject(object value, JsonTypeInfo jsonTypeInfo)
		{
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter writer = Utf8JsonWriterCache.RentWriterAndBuffer(jsonTypeInfo.Options, out pooledByteBufferWriter);
			string result;
			try
			{
				jsonTypeInfo.SerializeAsObject(writer, value);
				result = JsonReaderHelper.TranscodeHelper(pooledByteBufferWriter.WrittenMemory.Span);
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(writer, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00014200 File Offset: 0x00012400
		public static Task SerializeAsync<[Nullable(2)] TValue>(PipeWriter utf8Json, TValue value, JsonTypeInfo<TValue> jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.SerializeAsync(utf8Json, value, cancellationToken, null);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001422C File Offset: 0x0001242C
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static Task SerializeAsync<[Nullable(2)] TValue>(PipeWriter utf8Json, TValue value, [Nullable(2)] JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonSerializer.GetTypeInfo<TValue>(options).SerializeAsync(utf8Json, value, cancellationToken, null);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001424A File Offset: 0x0001244A
		public static Task SerializeAsync(PipeWriter utf8Json, [Nullable(2)] object value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			return jsonTypeInfo.SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00014275 File Offset: 0x00012475
		public static Task SerializeAsync(PipeWriter utf8Json, [Nullable(2)] object value, Type inputType, JsonSerializerContext context, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			return JsonSerializer.GetTypeInfo(context, inputType).SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000142A8 File Offset: 0x000124A8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static Task SerializeAsync(PipeWriter utf8Json, [Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			return JsonSerializer.GetTypeInfo(options, inputType).SerializeAsObjectAsync(utf8Json, value, cancellationToken);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000142CE File Offset: 0x000124CE
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static void Serialize<[Nullable(2)] TValue>(Utf8JsonWriter writer, TValue value, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			JsonSerializer.GetTypeInfo<TValue>(options).Serialize(writer, value, null);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000142EC File Offset: 0x000124EC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static void Serialize(Utf8JsonWriter writer, [Nullable(2)] object value, Type inputType, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonSerializer.GetTypeInfo(options, inputType).SerializeAsObject(writer, value);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00014310 File Offset: 0x00012510
		public static void Serialize<[Nullable(2)] TValue>(Utf8JsonWriter writer, TValue value, JsonTypeInfo<TValue> jsonTypeInfo)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			jsonTypeInfo.Serialize(writer, value, null);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001433C File Offset: 0x0001253C
		public static void Serialize(Utf8JsonWriter writer, [Nullable(2)] object value, JsonTypeInfo jsonTypeInfo)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			jsonTypeInfo.EnsureConfigured();
			jsonTypeInfo.SerializeAsObject(writer, value);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00014366 File Offset: 0x00012566
		public static void Serialize(Utf8JsonWriter writer, [Nullable(2)] object value, Type inputType, JsonSerializerContext context)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			if (context == null)
			{
				ThrowHelper.ThrowArgumentNullException("context");
			}
			JsonSerializer.ValidateInputType(value, inputType);
			JsonSerializer.GetTypeInfo(context, inputType).SerializeAsObject(writer, value);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00014398 File Offset: 0x00012598
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static JsonSerializer()
		{
			bool flag;
			JsonSerializer.IsReflectionEnabledByDefault = (!AppContext.TryGetSwitch("System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault", out flag) || flag);
			JsonSerializer.s_idPropertyName = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F630228BD37E08E6923D5691940E6DFEEDB75FB8BC0780EE1ABA98C0C1A49778), 3).ToArray();
			JsonSerializer.s_refPropertyName = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.84499CE395D80E3A7694D419919F5383E3C8B46E4B78F0FA291576406ECE3FA2), 4).ToArray();
			JsonSerializer.s_typePropertyName = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.AB50C59D4F64B05ABA854F60FD7DA6C6EB8F4715BCCE00520E5ACA886CB5B92C), 5).ToArray();
			JsonSerializer.s_valuesPropertyName = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F2CBFF984BEDEC6EBB2619964766BBE0A2EF28F9A3E5FF81ED9B35C90A9E1C70), 7).ToArray();
			JsonSerializer.s_metadataId = JsonEncodedText.Encode("$id", null);
			JsonSerializer.s_metadataRef = JsonEncodedText.Encode("$ref", null);
			JsonSerializer.s_metadataType = JsonEncodedText.Encode("$type", null);
			JsonSerializer.s_metadataValues = JsonEncodedText.Encode("$values", null);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001445C File Offset: 0x0001265C
		[CompilerGenerated]
		internal static void <UnboxOnRead>g__ThrowUnableToCastValue|50_0<T>(object value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowInvalidOperationException_DeserializeUnableToAssignNull(typeof(T));
				return;
			}
			ThrowHelper.ThrowInvalidCastException_DeserializeUnableToAssignValue(value.GetType(), typeof(T));
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00014488 File Offset: 0x00012688
		[CompilerGenerated]
		internal static string <TryHandleReferenceFromJsonNode>g__ReadAsStringMetadataValue|64_0(JsonNode jsonNode)
		{
			JsonValue jsonValue = jsonNode as JsonValue;
			string text;
			if (jsonValue != null && jsonValue.TryGetValue<string>(out text) && text != null)
			{
				return text;
			}
			ThrowHelper.ThrowJsonException_MetadataValueWasNotString((jsonNode != null) ? jsonNode.GetValueKind() : JsonValueKind.Null);
			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000144C0 File Offset: 0x000126C0
		[AsyncIteratorStateMachine(typeof(JsonSerializer.<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d<>))]
		[CompilerGenerated]
		internal static IAsyncEnumerable<T> <DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0<T>(Stream utf8Json, JsonTypeInfo<List<T>> listTypeInfo, JsonReaderOptions readerOptions, [EnumeratorCancellation] CancellationToken cancellationToken)
		{
			JsonSerializer.<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d<T> <<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d = new JsonSerializer.<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d<T>(-2);
			<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d.<>3__utf8Json = utf8Json;
			<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d.<>3__listTypeInfo = listTypeInfo;
			<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d.<>3__readerOptions = readerOptions;
			<<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d.<>3__cancellationToken = cancellationToken;
			return <<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerableFromArray|92_0>d;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000144E8 File Offset: 0x000126E8
		[CompilerGenerated]
		internal static JsonTypeInfo<List<T>> <DeserializeAsyncEnumerableCore>g__GetOrAddListTypeInfoForArrayMode|92_1<T>(JsonTypeInfo<T> elementTypeInfo)
		{
			if (elementTypeInfo._asyncEnumerableArrayTypeInfo != null)
			{
				return (JsonTypeInfo<List<T>>)elementTypeInfo._asyncEnumerableArrayTypeInfo;
			}
			JsonTypeInfo<List<T>> jsonTypeInfo = new JsonTypeInfo<List<T>>(new ListOfTConverter<List<T>, T>(), elementTypeInfo.Options);
			jsonTypeInfo.CreateObject = (() => new List<T>());
			jsonTypeInfo.ElementTypeInfo = elementTypeInfo;
			JsonTypeInfo<List<T>> jsonTypeInfo2 = jsonTypeInfo;
			jsonTypeInfo2.EnsureConfigured();
			elementTypeInfo._asyncEnumerableArrayTypeInfo = jsonTypeInfo2;
			return jsonTypeInfo2;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00014554 File Offset: 0x00012754
		[CompilerGenerated]
		internal static JsonTypeInfo<List<T>> <DeserializeAsyncEnumerableCore>g__GetOrAddListTypeInfoForRootLevelValueMode|92_2<T>(JsonTypeInfo<T> elementTypeInfo)
		{
			if (elementTypeInfo._asyncEnumerableRootLevelValueTypeInfo != null)
			{
				return (JsonTypeInfo<List<T>>)elementTypeInfo._asyncEnumerableRootLevelValueTypeInfo;
			}
			JsonTypeInfo<List<T>> jsonTypeInfo = new JsonTypeInfo<List<T>>(new RootLevelListConverter<T>(elementTypeInfo), elementTypeInfo.Options)
			{
				ElementTypeInfo = elementTypeInfo
			};
			jsonTypeInfo.EnsureConfigured();
			elementTypeInfo._asyncEnumerableRootLevelValueTypeInfo = jsonTypeInfo;
			return jsonTypeInfo;
		}

		// Token: 0x040000C9 RID: 201
		private static readonly byte[] s_idPropertyName;

		// Token: 0x040000CA RID: 202
		private static readonly byte[] s_refPropertyName;

		// Token: 0x040000CB RID: 203
		private static readonly byte[] s_typePropertyName;

		// Token: 0x040000CC RID: 204
		private static readonly byte[] s_valuesPropertyName;

		// Token: 0x040000CD RID: 205
		internal static readonly JsonEncodedText s_metadataId;

		// Token: 0x040000CE RID: 206
		internal static readonly JsonEncodedText s_metadataRef;

		// Token: 0x040000CF RID: 207
		internal static readonly JsonEncodedText s_metadataType;

		// Token: 0x040000D0 RID: 208
		internal static readonly JsonEncodedText s_metadataValues;
	}
}
