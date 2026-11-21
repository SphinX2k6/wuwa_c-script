using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Schema
{
	// Token: 0x02000062 RID: 98
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonSchemaExporter
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00023657 File Offset: 0x00021857
		public static JsonNode GetJsonSchemaAsNode(this JsonSerializerOptions options, Type type, [Nullable(2)] JsonSchemaExporterOptions exporterOptions = null)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException("type");
			}
			JsonSchemaExporter.ValidateOptions(options);
			return options.GetTypeInfoInternal(type, true, new bool?(true), false, false).GetJsonSchemaAsNode(exporterOptions);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00023690 File Offset: 0x00021890
		public static JsonNode GetJsonSchemaAsNode(this JsonTypeInfo typeInfo, [Nullable(2)] JsonSchemaExporterOptions exporterOptions = null)
		{
			if (typeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("typeInfo");
			}
			JsonSchemaExporter.ValidateOptions(typeInfo.Options);
			if (exporterOptions == null)
			{
				exporterOptions = JsonSchemaExporterOptions.Default;
			}
			typeInfo.EnsureConfigured();
			JsonSchemaExporter.GenerationState generationState = new JsonSchemaExporter.GenerationState(typeInfo.Options, exporterOptions);
			return JsonSchemaExporter.MapJsonSchemaCore(ref generationState, typeInfo, null, null, null, null, false, false, null, true).ToJsonNode(exporterOptions);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000236FC File Offset: 0x000218FC
		private unsafe static JsonSchema MapJsonSchemaCore(ref JsonSchemaExporter.GenerationState state, JsonTypeInfo typeInfo, JsonPropertyInfo propertyInfo = null, JsonConverter customConverter = null, JsonNumberHandling? customNumberHandling = null, JsonTypeInfo parentPolymorphicTypeInfo = null, bool parentPolymorphicTypeContainsTypesWithoutDiscriminator = false, bool parentPolymorphicTypeIsNonNullable = false, KeyValuePair<string, JsonSchema>? typeDiscriminator = null, bool cacheResult = true)
		{
			JsonSchemaExporter.<>c__DisplayClass2_0 CS$<>8__locals1;
			CS$<>8__locals1.propertyInfo = propertyInfo;
			CS$<>8__locals1.typeInfo = typeInfo;
			CS$<>8__locals1.parentPolymorphicTypeIsNonNullable = parentPolymorphicTypeIsNonNullable;
			CS$<>8__locals1.exporterContext = state.CreateContext(CS$<>8__locals1.typeInfo, CS$<>8__locals1.propertyInfo, parentPolymorphicTypeInfo);
			string @ref;
			if (cacheResult && CS$<>8__locals1.typeInfo.Kind != JsonTypeInfoKind.None && state.TryGetExistingJsonPointer(CS$<>8__locals1.exporterContext, out @ref))
			{
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, new JsonSchema
				{
					Ref = @ref
				}, ref CS$<>8__locals1);
			}
			JsonConverter jsonConverter = customConverter ?? CS$<>8__locals1.typeInfo.Converter;
			JsonNumberHandling jsonNumberHandling = customNumberHandling ?? (CS$<>8__locals1.typeInfo.NumberHandling ?? CS$<>8__locals1.typeInfo.Options.NumberHandling);
			JsonSchema jsonSchema = jsonConverter.GetSchema(jsonNumberHandling);
			if (jsonSchema != null)
			{
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, jsonSchema, ref CS$<>8__locals1);
			}
			if (parentPolymorphicTypeInfo == null)
			{
				JsonPolymorphismOptions polymorphismOptions = CS$<>8__locals1.typeInfo.PolymorphismOptions;
				if (polymorphismOptions != null)
				{
					IList<JsonDerivedType> derivedTypes2 = polymorphismOptions.DerivedTypes;
					if (derivedTypes2 != null && derivedTypes2.Count > 0)
					{
						string typeDiscriminatorPropertyName = polymorphismOptions.TypeDiscriminatorPropertyName;
						List<JsonDerivedType> list = new List<JsonDerivedType>(polymorphismOptions.DerivedTypes);
						if (!CS$<>8__locals1.typeInfo.Type.IsAbstract && !JsonSchemaExporter.IsPolymorphicTypeThatSpecifiesItselfAsDerivedType(CS$<>8__locals1.typeInfo))
						{
							list.Add(new JsonDerivedType(CS$<>8__locals1.typeInfo.Type));
						}
						bool flag = list.Exists((JsonDerivedType derivedTypes) => derivedTypes.TypeDiscriminator == null);
						JsonSchemaType jsonSchemaType = JsonSchemaType.Any;
						List<JsonSchema> list2 = new List<JsonSchema>(list.Count);
						state.PushSchemaNode("anyOf");
						foreach (JsonDerivedType jsonDerivedType in list)
						{
							KeyValuePair<string, JsonSchema>? keyValuePair = null;
							object typeDiscriminator2 = jsonDerivedType.TypeDiscriminator;
							if (typeDiscriminator2 != null)
							{
								string text = typeDiscriminator2 as string;
								JsonNode jsonNode;
								if (text != null)
								{
									jsonNode = text;
								}
								else
								{
									jsonNode = (int)typeDiscriminator2;
								}
								JsonNode constant = jsonNode;
								JsonSchema value = new JsonSchema
								{
									Constant = constant
								};
								keyValuePair = new KeyValuePair<string, JsonSchema>?(new KeyValuePair<string, JsonSchema>(typeDiscriminatorPropertyName, value));
							}
							JsonTypeInfo typeInfoInternal = CS$<>8__locals1.typeInfo.Options.GetTypeInfoInternal(jsonDerivedType.DerivedType, true, new bool?(true), false, false);
							state.PushSchemaNode(list2.Count.ToString(CultureInfo.InvariantCulture));
							JsonTypeInfo typeInfo2 = typeInfoInternal;
							JsonPropertyInfo propertyInfo2 = null;
							JsonConverter customConverter2 = null;
							JsonTypeInfo typeInfo3 = CS$<>8__locals1.typeInfo;
							KeyValuePair<string, JsonSchema>? typeDiscriminator3 = keyValuePair;
							bool parentPolymorphicTypeContainsTypesWithoutDiscriminator2 = flag;
							bool flag2 = CS$<>8__locals1.propertyInfo != null && !CS$<>8__locals1.propertyInfo.IsGetNullable && !CS$<>8__locals1.propertyInfo.IsSetNullable;
							JsonSchema jsonSchema2 = JsonSchemaExporter.MapJsonSchemaCore(ref state, typeInfo2, propertyInfo2, customConverter2, null, typeInfo3, parentPolymorphicTypeContainsTypesWithoutDiscriminator2, flag2, typeDiscriminator3, false);
							state.PopSchemaNode();
							if (list2.Count == 0)
							{
								jsonSchemaType = jsonSchema2.Type;
							}
							else if (jsonSchemaType != jsonSchema2.Type)
							{
								jsonSchemaType = JsonSchemaType.Any;
							}
							list2.Add(jsonSchema2);
						}
						state.PopSchemaNode();
						if (jsonSchemaType != JsonSchemaType.Any)
						{
							foreach (JsonSchema jsonSchema3 in list2)
							{
								jsonSchema3.Type = JsonSchemaType.Any;
								if (jsonSchema3.KeywordCount == 0)
								{
									list2 = null;
									break;
								}
							}
						}
						JsonSchema jsonSchema4 = new JsonSchema();
						jsonSchema4.Type = jsonSchemaType;
						jsonSchema4.AnyOf = list2;
						List<string> required;
						if (!flag)
						{
							int num = 1;
							List<string> list3 = new List<string>(num);
							CollectionsMarshal.SetCount<string>(list3, num);
							required = list3;
							Span<string> span = CollectionsMarshal.AsSpan<string>(list3);
							int num2 = 0;
							*span[num2] = typeDiscriminatorPropertyName;
							num2++;
						}
						else
						{
							required = null;
						}
						jsonSchema4.Required = required;
						return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, jsonSchema4, ref CS$<>8__locals1);
					}
				}
			}
			JsonConverter nullableElementConverter = jsonConverter.NullableElementConverter;
			if (nullableElementConverter != null)
			{
				JsonTypeInfo typeInfo4 = CS$<>8__locals1.typeInfo.Options.GetTypeInfo(nullableElementConverter.Type);
				jsonSchema = JsonSchemaExporter.MapJsonSchemaCore(ref state, typeInfo4, null, nullableElementConverter, null, null, false, false, null, false);
				if (jsonSchema.Enum != null)
				{
					jsonSchema.Enum.Add(null);
				}
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, jsonSchema, ref CS$<>8__locals1);
			}
			switch (CS$<>8__locals1.typeInfo.Kind)
			{
			case JsonTypeInfoKind.Object:
			{
				List<KeyValuePair<string, JsonSchema>> list4 = null;
				List<string> list5 = null;
				JsonSchema additionalProperties = null;
				if ((CS$<>8__locals1.typeInfo.UnmappedMemberHandling ?? CS$<>8__locals1.typeInfo.Options.UnmappedMemberHandling) == JsonUnmappedMemberHandling.Disallow)
				{
					additionalProperties = JsonSchema.CreateFalseSchema();
				}
				if (typeDiscriminator != null)
				{
					KeyValuePair<string, JsonSchema> valueOrDefault = typeDiscriminator.GetValueOrDefault();
					List<KeyValuePair<string, JsonSchema>> list6;
					if ((list6 = list4) == null)
					{
						list6 = (list4 = new List<KeyValuePair<string, JsonSchema>>());
					}
					list6.Add(valueOrDefault);
					if (parentPolymorphicTypeContainsTypesWithoutDiscriminator)
					{
						List<string> list7;
						if ((list7 = list5) == null)
						{
							list7 = (list5 = new List<string>());
						}
						list7.Add(valueOrDefault.Key);
					}
				}
				state.PushSchemaNode("properties");
				foreach (JsonPropertyInfo jsonPropertyInfo in CS$<>8__locals1.typeInfo.Properties)
				{
					if (jsonPropertyInfo == null || ((jsonPropertyInfo.Get != null || jsonPropertyInfo.Set != null) && !jsonPropertyInfo.IsExtensionData))
					{
						state.PushSchemaNode(jsonPropertyInfo.Name);
						JsonSchema jsonSchema5 = JsonSchemaExporter.MapJsonSchemaCore(ref state, jsonPropertyInfo.JsonTypeInfo, jsonPropertyInfo, jsonPropertyInfo.EffectiveConverter, jsonPropertyInfo.EffectiveNumberHandling, null, false, false, null, true);
						state.PopSchemaNode();
						JsonParameterInfo associatedParameter = jsonPropertyInfo.AssociatedParameter;
						if (associatedParameter != null && associatedParameter.HasDefaultValue)
						{
							JsonSchema.EnsureMutable(ref jsonSchema5);
							jsonSchema5.DefaultValue = JsonSerializer.SerializeToNode(associatedParameter.DefaultValue, jsonPropertyInfo.JsonTypeInfo);
							jsonSchema5.HasDefaultValue = true;
						}
						List<KeyValuePair<string, JsonSchema>> list8;
						if ((list8 = list4) == null)
						{
							list8 = (list4 = new List<KeyValuePair<string, JsonSchema>>());
						}
						list8.Add(new KeyValuePair<string, JsonSchema>(jsonPropertyInfo.Name, jsonSchema5));
						if (jsonPropertyInfo == null)
						{
							goto IL_5D5;
						}
						if (!jsonPropertyInfo.IsRequired)
						{
							JsonParameterInfo associatedParameter2 = jsonPropertyInfo.AssociatedParameter;
							if (associatedParameter2 == null || !associatedParameter2.IsRequiredParameter)
							{
								goto IL_5D5;
							}
						}
						bool flag2 = true;
						IL_5D8:
						if (flag2)
						{
							List<string> list9;
							if ((list9 = list5) == null)
							{
								list9 = (list5 = new List<string>());
							}
							list9.Add(jsonPropertyInfo.Name);
							continue;
						}
						continue;
						IL_5D5:
						flag2 = false;
						goto IL_5D8;
					}
				}
				state.PopSchemaNode();
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, new JsonSchema
				{
					Type = JsonSchemaType.Object,
					Properties = list4,
					Required = list5,
					AdditionalProperties = additionalProperties
				}, ref CS$<>8__locals1);
			}
			case JsonTypeInfoKind.Enumerable:
			{
				if (typeDiscriminator == null)
				{
					state.PushSchemaNode("items");
					JsonSchema jsonSchema6 = JsonSchemaExporter.MapJsonSchemaCore(ref state, CS$<>8__locals1.typeInfo.ElementTypeInfo, null, null, new JsonNumberHandling?(jsonNumberHandling), null, false, false, null, true);
					state.PopSchemaNode();
					return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, new JsonSchema
					{
						Type = JsonSchemaType.Array,
						Items = (jsonSchema6.IsTrue ? null : jsonSchema6)
					}, ref CS$<>8__locals1);
				}
				state.PushSchemaNode("properties");
				state.PushSchemaNode("$values");
				state.PushSchemaNode("items");
				JsonSchema jsonSchema7 = JsonSchemaExporter.MapJsonSchemaCore(ref state, CS$<>8__locals1.typeInfo.ElementTypeInfo, null, null, new JsonNumberHandling?(jsonNumberHandling), null, false, false, null, true);
				state.PopSchemaNode();
				state.PopSchemaNode();
				state.PopSchemaNode();
				JsonSchema jsonSchema8 = new JsonSchema();
				jsonSchema8.Type = JsonSchemaType.Object;
				int num2 = 2;
				List<KeyValuePair<string, JsonSchema>> list10 = new List<KeyValuePair<string, JsonSchema>>(num2);
				CollectionsMarshal.SetCount<KeyValuePair<string, JsonSchema>>(list10, num2);
				Span<KeyValuePair<string, JsonSchema>> span2 = CollectionsMarshal.AsSpan<KeyValuePair<string, JsonSchema>>(list10);
				int num = 0;
				*span2[num] = typeDiscriminator.Value;
				num++;
				*span2[num] = new KeyValuePair<string, JsonSchema>("$values", new JsonSchema
				{
					Type = JsonSchemaType.Array,
					Items = (jsonSchema7.IsTrue ? null : jsonSchema7)
				});
				num++;
				jsonSchema8.Properties = list10;
				List<string> required2;
				if (!parentPolymorphicTypeContainsTypesWithoutDiscriminator)
				{
					required2 = null;
				}
				else
				{
					num = 1;
					List<string> list11 = new List<string>(num);
					CollectionsMarshal.SetCount<string>(list11, num);
					required2 = list11;
					Span<string> span = CollectionsMarshal.AsSpan<string>(list11);
					num2 = 0;
					*span[num2] = typeDiscriminator.Value.Key;
					num2++;
				}
				jsonSchema8.Required = required2;
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, jsonSchema8, ref CS$<>8__locals1);
			}
			case JsonTypeInfoKind.Dictionary:
			{
				List<KeyValuePair<string, JsonSchema>> properties = null;
				List<string> required3 = null;
				if (typeDiscriminator != null)
				{
					KeyValuePair<string, JsonSchema> valueOrDefault2 = typeDiscriminator.GetValueOrDefault();
					int num2 = 1;
					List<KeyValuePair<string, JsonSchema>> list12 = new List<KeyValuePair<string, JsonSchema>>(num2);
					CollectionsMarshal.SetCount<KeyValuePair<string, JsonSchema>>(list12, num2);
					Span<KeyValuePair<string, JsonSchema>> span2 = CollectionsMarshal.AsSpan<KeyValuePair<string, JsonSchema>>(list12);
					int num = 0;
					*span2[num] = valueOrDefault2;
					num++;
					properties = list12;
					if (parentPolymorphicTypeContainsTypesWithoutDiscriminator)
					{
						num = 1;
						List<string> list13 = new List<string>(num);
						CollectionsMarshal.SetCount<string>(list13, num);
						Span<string> span = CollectionsMarshal.AsSpan<string>(list13);
						num2 = 0;
						*span[num2] = valueOrDefault2.Key;
						num2++;
						required3 = list13;
					}
				}
				state.PushSchemaNode("additionalProperties");
				JsonSchema jsonSchema9 = JsonSchemaExporter.MapJsonSchemaCore(ref state, CS$<>8__locals1.typeInfo.ElementTypeInfo, null, null, new JsonNumberHandling?(jsonNumberHandling), null, false, false, null, true);
				state.PopSchemaNode();
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, new JsonSchema
				{
					Type = JsonSchemaType.Object,
					Properties = properties,
					Required = required3,
					AdditionalProperties = (jsonSchema9.IsTrue ? null : jsonSchema9)
				}, ref CS$<>8__locals1);
			}
			default:
				return JsonSchemaExporter.<MapJsonSchemaCore>g__CompleteSchema|2_0(ref state, JsonSchema.CreateTrueSchema(), ref CS$<>8__locals1);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00024048 File Offset: 0x00022248
		private static void ValidateOptions(JsonSerializerOptions options)
		{
			if (options.ReferenceHandler == ReferenceHandler.Preserve)
			{
				ThrowHelper.ThrowNotSupportedException_JsonSchemaExporterDoesNotSupportReferenceHandlerPreserve();
			}
			options.MakeReadOnly();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00024064 File Offset: 0x00022264
		private static bool IsPolymorphicTypeThatSpecifiesItselfAsDerivedType(JsonTypeInfo typeInfo)
		{
			foreach (JsonDerivedType jsonDerivedType in typeInfo.PolymorphismOptions.DerivedTypes)
			{
				if (jsonDerivedType.DerivedType == typeInfo.Type)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000240CC File Offset: 0x000222CC
		[CompilerGenerated]
		internal static JsonSchema <MapJsonSchemaCore>g__CompleteSchema|2_0(ref JsonSchemaExporter.GenerationState state, JsonSchema schema, ref JsonSchemaExporter.<>c__DisplayClass2_0 A_2)
		{
			if (schema.Ref == null && ((A_2.propertyInfo != null) ? (A_2.propertyInfo.IsGetNullable || A_2.propertyInfo.IsSetNullable) : (A_2.typeInfo.CanBeNull && !A_2.parentPolymorphicTypeIsNonNullable && !state.ExporterOptions.TreatNullObliviousAsNonNullable)))
			{
				schema.MakeNullable();
			}
			if (state.ExporterOptions.TransformSchemaNode != null)
			{
				schema.ExporterContext = new JsonSchemaExporterContext?(A_2.exporterContext);
			}
			return schema;
		}

		// Token: 0x02000063 RID: 99
		[CompilerFeatureRequired("RefStructs")]
		private readonly ref struct GenerationState
		{
			// Token: 0x06000752 RID: 1874 RVA: 0x00024153 File Offset: 0x00022353
			public GenerationState(JsonSerializerOptions options, JsonSchemaExporterOptions exporterOptions)
			{
				this._currentPath = new List<string>();
				this._generated = new Dictionary<ValueTuple<JsonTypeInfo, JsonPropertyInfo>, string[]>();
				this.Options = options;
				this.ExporterOptions = exporterOptions;
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000753 RID: 1875 RVA: 0x00024179 File Offset: 0x00022379
			public int CurrentDepth
			{
				get
				{
					return this._currentPath.Count;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x00024186 File Offset: 0x00022386
			public JsonSerializerOptions Options { get; }

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000755 RID: 1877 RVA: 0x0002418E File Offset: 0x0002238E
			public JsonSchemaExporterOptions ExporterOptions { get; }

			// Token: 0x06000756 RID: 1878 RVA: 0x00024196 File Offset: 0x00022396
			public void PushSchemaNode(string nodeId)
			{
				if (this.CurrentDepth == this.Options.EffectiveMaxDepth)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonSchemaExporterDepthTooLarge();
				}
				this._currentPath.Add(nodeId);
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x000241BC File Offset: 0x000223BC
			public void PopSchemaNode()
			{
				this._currentPath.RemoveAt(this._currentPath.Count - 1);
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x000241D8 File Offset: 0x000223D8
			public bool TryGetExistingJsonPointer(in JsonSchemaExporterContext context, [NotNullWhen(true)] out string existingJsonPointer)
			{
				ValueTuple<JsonTypeInfo, JsonPropertyInfo> key = new ValueTuple<JsonTypeInfo, JsonPropertyInfo>(context.TypeInfo, context.PropertyInfo);
				bool flag;
				ref string[] valueRefOrAddDefault = ref CollectionsMarshal.GetValueRefOrAddDefault<ValueTuple<JsonTypeInfo, JsonPropertyInfo>, string[]>(this._generated, key, out flag);
				if (flag)
				{
					existingJsonPointer = JsonSchemaExporter.GenerationState.FormatJsonPointer(valueRefOrAddDefault);
					return true;
				}
				valueRefOrAddDefault = context._path;
				existingJsonPointer = null;
				return false;
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x00024226 File Offset: 0x00022426
			public JsonSchemaExporterContext CreateContext(JsonTypeInfo typeInfo, JsonPropertyInfo propertyInfo, JsonTypeInfo baseTypeInfo)
			{
				return new JsonSchemaExporterContext(typeInfo, propertyInfo, baseTypeInfo, this._currentPath.ToArray());
			}

			// Token: 0x0600075A RID: 1882 RVA: 0x0002423C File Offset: 0x0002243C
			private unsafe static string FormatJsonPointer(ReadOnlySpan<string> path)
			{
				if (path.IsEmpty)
				{
					return "#";
				}
				string result;
				using (ValueStringBuilder valueStringBuilder = new ValueStringBuilder(path.Length * 10))
				{
					valueStringBuilder.Append('#');
					ReadOnlySpan<string> readOnlySpan = path;
					int i = 0;
					while (i < readOnlySpan.Length)
					{
						ReadOnlySpan<char> readOnlySpan2 = (*readOnlySpan[i]).AsSpan();
						valueStringBuilder.Append('/');
						do
						{
							int num = readOnlySpan2.IndexOfAny('~', '/');
							if (num < 0)
							{
								goto Block_4;
							}
							valueStringBuilder.Append(readOnlySpan2.Slice(0, num));
							if (*readOnlySpan2[num] == 126)
							{
								valueStringBuilder.Append("~0");
							}
							else
							{
								valueStringBuilder.Append("~1");
							}
							readOnlySpan2 = readOnlySpan2.Slice(num + 1);
						}
						while (!readOnlySpan2.IsEmpty);
						IL_B3:
						i++;
						continue;
						Block_4:
						valueStringBuilder.Append(readOnlySpan2);
						goto IL_B3;
					}
					result = valueStringBuilder.ToString();
				}
				return result;
			}

			// Token: 0x04000212 RID: 530
			private readonly List<string> _currentPath;

			// Token: 0x04000213 RID: 531
			private readonly Dictionary<ValueTuple<JsonTypeInfo, JsonPropertyInfo>, string[]> _generated;
		}
	}
}
