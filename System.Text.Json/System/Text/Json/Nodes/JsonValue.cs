using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Nodes
{
	// Token: 0x02000074 RID: 116
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class JsonValue : JsonNode
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x00026BA2 File Offset: 0x00024DA2
		[NullableContext(1)]
		public static JsonValue Create(bool value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<bool>(value, JsonMetadataServices.BooleanConverter, options);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00026BB0 File Offset: 0x00024DB0
		public static JsonValue Create(bool? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<bool>(value.Value, JsonMetadataServices.BooleanConverter, options);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00026BCF File Offset: 0x00024DCF
		[NullableContext(1)]
		public static JsonValue Create(byte value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<byte>(value, JsonMetadataServices.ByteConverter, options);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00026BDD File Offset: 0x00024DDD
		public static JsonValue Create(byte? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<byte>(value.Value, JsonMetadataServices.ByteConverter, options);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00026BFC File Offset: 0x00024DFC
		[NullableContext(1)]
		public static JsonValue Create(char value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<char>(value, JsonMetadataServices.CharConverter, options);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00026C0A File Offset: 0x00024E0A
		public static JsonValue Create(char? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<char>(value.Value, JsonMetadataServices.CharConverter, options);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00026C29 File Offset: 0x00024E29
		[NullableContext(1)]
		public static JsonValue Create(DateTime value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<DateTime>(value, JsonMetadataServices.DateTimeConverter, options);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00026C37 File Offset: 0x00024E37
		public static JsonValue Create(DateTime? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<DateTime>(value.Value, JsonMetadataServices.DateTimeConverter, options);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00026C56 File Offset: 0x00024E56
		[NullableContext(1)]
		public static JsonValue Create(DateTimeOffset value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<DateTimeOffset>(value, JsonMetadataServices.DateTimeOffsetConverter, options);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00026C64 File Offset: 0x00024E64
		public static JsonValue Create(DateTimeOffset? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<DateTimeOffset>(value.Value, JsonMetadataServices.DateTimeOffsetConverter, options);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00026C83 File Offset: 0x00024E83
		[NullableContext(1)]
		public static JsonValue Create(decimal value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<decimal>(value, JsonMetadataServices.DecimalConverter, options);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00026C91 File Offset: 0x00024E91
		public static JsonValue Create(decimal? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<decimal>(value.Value, JsonMetadataServices.DecimalConverter, options);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00026CB0 File Offset: 0x00024EB0
		[NullableContext(1)]
		public static JsonValue Create(double value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<double>(value, JsonMetadataServices.DoubleConverter, options);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00026CBE File Offset: 0x00024EBE
		public static JsonValue Create(double? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<double>(value.Value, JsonMetadataServices.DoubleConverter, options);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00026CDD File Offset: 0x00024EDD
		[NullableContext(1)]
		public static JsonValue Create(Guid value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<Guid>(value, JsonMetadataServices.GuidConverter, options);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00026CEB File Offset: 0x00024EEB
		public static JsonValue Create(Guid? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<Guid>(value.Value, JsonMetadataServices.GuidConverter, options);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00026D0A File Offset: 0x00024F0A
		[NullableContext(1)]
		public static JsonValue Create(short value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<short>(value, JsonMetadataServices.Int16Converter, options);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00026D18 File Offset: 0x00024F18
		public static JsonValue Create(short? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<short>(value.Value, JsonMetadataServices.Int16Converter, options);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00026D37 File Offset: 0x00024F37
		[NullableContext(1)]
		public static JsonValue Create(int value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<int>(value, JsonMetadataServices.Int32Converter, options);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00026D45 File Offset: 0x00024F45
		public static JsonValue Create(int? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<int>(value.Value, JsonMetadataServices.Int32Converter, options);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00026D64 File Offset: 0x00024F64
		[NullableContext(1)]
		public static JsonValue Create(long value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<long>(value, JsonMetadataServices.Int64Converter, options);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00026D72 File Offset: 0x00024F72
		public static JsonValue Create(long? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<long>(value.Value, JsonMetadataServices.Int64Converter, options);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00026D91 File Offset: 0x00024F91
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static JsonValue Create(sbyte value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<sbyte>(value, JsonMetadataServices.SByteConverter, options);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00026D9F File Offset: 0x00024F9F
		[CLSCompliant(false)]
		public static JsonValue Create(sbyte? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<sbyte>(value.Value, JsonMetadataServices.SByteConverter, options);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00026DBE File Offset: 0x00024FBE
		[NullableContext(1)]
		public static JsonValue Create(float value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<float>(value, JsonMetadataServices.SingleConverter, options);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00026DCC File Offset: 0x00024FCC
		public static JsonValue Create(float? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<float>(value.Value, JsonMetadataServices.SingleConverter, options);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00026DEB File Offset: 0x00024FEB
		[return: NotNullIfNotNull("value")]
		public static JsonValue Create(string value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<string>(value, JsonMetadataServices.StringConverter, options);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00026DFE File Offset: 0x00024FFE
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static JsonValue Create(ushort value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<ushort>(value, JsonMetadataServices.UInt16Converter, options);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00026E0C File Offset: 0x0002500C
		[CLSCompliant(false)]
		public static JsonValue Create(ushort? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<ushort>(value.Value, JsonMetadataServices.UInt16Converter, options);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00026E2B File Offset: 0x0002502B
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static JsonValue Create(uint value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<uint>(value, JsonMetadataServices.UInt32Converter, options);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00026E39 File Offset: 0x00025039
		[CLSCompliant(false)]
		public static JsonValue Create(uint? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<uint>(value.Value, JsonMetadataServices.UInt32Converter, options);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00026E58 File Offset: 0x00025058
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static JsonValue Create(ulong value, JsonNodeOptions? options = null)
		{
			return new JsonValuePrimitive<ulong>(value, JsonMetadataServices.UInt64Converter, options);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00026E66 File Offset: 0x00025066
		[CLSCompliant(false)]
		public static JsonValue Create(ulong? value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			return new JsonValuePrimitive<ulong>(value.Value, JsonMetadataServices.UInt64Converter, options);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00026E85 File Offset: 0x00025085
		public static JsonValue Create(JsonElement value, JsonNodeOptions? options = null)
		{
			return JsonValue.CreateFromElement(ref value, options);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00026E90 File Offset: 0x00025090
		public static JsonValue Create(JsonElement? value, JsonNodeOptions? options = null)
		{
			if (value != null)
			{
				JsonElement valueOrDefault = value.GetValueOrDefault();
				return JsonValue.CreateFromElement(ref valueOrDefault, options);
			}
			return null;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000243D1 File Offset: 0x000225D1
		private protected JsonValue(JsonNodeOptions? options) : base(options)
		{
		}

		// Token: 0x06000869 RID: 2153
		public abstract bool TryGetValue<T>([NotNullWhen(true)] out T value);

		// Token: 0x0600086A RID: 2154 RVA: 0x00026EBC File Offset: 0x000250BC
		[RequiresUnreferencedCode("Creating JsonValue instances with non-primitive types is not compatible with trimming. It can result in non-primitive types being serialized, which may have their members trimmed. Use the overload that takes a JsonTypeInfo, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("Creating JsonValue instances with non-primitive types requires generating code at runtime.")]
		public static JsonValue Create<T>(T value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			if (value is JsonNode)
			{
				ThrowHelper.ThrowArgumentException_NodeValueNotAllowed("value");
			}
			if (value is JsonElement)
			{
				JsonElement jsonElement = value as JsonElement;
				return JsonValue.CreateFromElement(ref jsonElement, options);
			}
			JsonTypeInfo<T> jsonTypeInfo = (JsonTypeInfo<T>)JsonSerializerOptions.Default.GetTypeInfo(typeof(T));
			return JsonValue.CreateFromTypeInfo<T>(value, jsonTypeInfo, options);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00026F34 File Offset: 0x00025134
		public static JsonValue Create<T>(T value, [Nullable(1)] JsonTypeInfo<T> jsonTypeInfo, JsonNodeOptions? options = null)
		{
			if (jsonTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("jsonTypeInfo");
			}
			if (value == null)
			{
				return null;
			}
			if (value is JsonNode)
			{
				ThrowHelper.ThrowArgumentException_NodeValueNotAllowed("value");
			}
			jsonTypeInfo.EnsureConfigured();
			if (value is JsonElement)
			{
				JsonElement jsonElement = value as JsonElement;
				if (jsonTypeInfo.EffectiveConverter.IsInternalConverter)
				{
					return JsonValue.CreateFromElement(ref jsonElement, options);
				}
			}
			return JsonValue.CreateFromTypeInfo<T>(value, jsonTypeInfo, options);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00026FB4 File Offset: 0x000251B4
		internal override bool DeepEqualsCore(JsonNode otherNode)
		{
			if (base.GetValueKind() != otherNode.GetValueKind())
			{
				return false;
			}
			JsonDocument jsonDocument;
			JsonElement element = JsonValue.<DeepEqualsCore>g__ToJsonElement|41_0(this, out jsonDocument);
			JsonDocument jsonDocument2;
			JsonElement element2 = JsonValue.<DeepEqualsCore>g__ToJsonElement|41_0(otherNode, out jsonDocument2);
			bool result;
			try
			{
				result = JsonElement.DeepEquals(element, element2);
			}
			finally
			{
				if (jsonDocument != null)
				{
					jsonDocument.Dispose();
				}
				if (jsonDocument2 != null)
				{
					jsonDocument2.Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00027014 File Offset: 0x00025214
		internal sealed override void GetPath(ref ValueStringBuilder path, JsonNode child)
		{
			JsonNode parent = base.Parent;
			if (parent == null)
			{
				return;
			}
			parent.GetPath(ref path, this);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00027028 File Offset: 0x00025228
		internal static JsonValue CreateFromTypeInfo<T>(T value, JsonTypeInfo<T> jsonTypeInfo, JsonNodeOptions? options = null)
		{
			if (JsonValue<T>.TypeIsSupportedPrimitive && jsonTypeInfo != null)
			{
				JsonConverter<T> effectiveConverter = jsonTypeInfo.EffectiveConverter;
				if (effectiveConverter != null && effectiveConverter.IsInternalConverter && (jsonTypeInfo.EffectiveNumberHandling & JsonNumberHandling.WriteAsString) == JsonNumberHandling.Strict)
				{
					return new JsonValuePrimitive<T>(value, jsonTypeInfo.EffectiveConverter, options);
				}
			}
			return new JsonValueCustomized<T>(value, jsonTypeInfo, options);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00027074 File Offset: 0x00025274
		internal static JsonValue CreateFromElement([RequiresLocation] [In] ref JsonElement element, JsonNodeOptions? options = null)
		{
			JsonValueKind valueKind = element.ValueKind;
			if (valueKind - JsonValueKind.Object <= 1)
			{
				ThrowHelper.ThrowInvalidOperationException_NodeElementCannotBeObjectOrArray();
				return null;
			}
			if (valueKind == JsonValueKind.Null)
			{
				return null;
			}
			return new JsonValueOfElement(element, options);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000270A8 File Offset: 0x000252A8
		[CompilerGenerated]
		internal static JsonElement <DeepEqualsCore>g__ToJsonElement|41_0(JsonNode node, out JsonDocument backingDocument)
		{
			JsonElement? underlyingElement = node.UnderlyingElement;
			if (underlyingElement != null)
			{
				JsonElement valueOrDefault = underlyingElement.GetValueOrDefault();
				backingDocument = null;
				return valueOrDefault;
			}
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter utf8JsonWriter = Utf8JsonWriterCache.RentWriterAndBuffer(default(JsonWriterOptions), 16384, out pooledByteBufferWriter);
			JsonElement rootElement;
			try
			{
				node.WriteTo(utf8JsonWriter, null);
				utf8JsonWriter.Flush();
				Utf8JsonReader utf8JsonReader = new Utf8JsonReader(pooledByteBufferWriter.WrittenMemory.Span, default(JsonReaderOptions));
				backingDocument = JsonDocument.ParseValue(ref utf8JsonReader);
				rootElement = backingDocument.RootElement;
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(utf8JsonWriter, pooledByteBufferWriter);
			}
			return rootElement;
		}

		// Token: 0x04000245 RID: 581
		internal const string CreateUnreferencedCodeMessage = "Creating JsonValue instances with non-primitive types is not compatible with trimming. It can result in non-primitive types being serialized, which may have their members trimmed.";

		// Token: 0x04000246 RID: 582
		internal const string CreateDynamicCodeMessage = "Creating JsonValue instances with non-primitive types requires generating code at runtime.";
	}
}
