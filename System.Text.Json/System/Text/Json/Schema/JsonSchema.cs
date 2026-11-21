using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;

namespace System.Text.Json.Schema
{
	// Token: 0x0200005F RID: 95
	internal sealed class JsonSchema
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00022DF4 File Offset: 0x00020FF4
		public static JsonSchema CreateFalseSchema()
		{
			return new JsonSchema(false);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00022DFC File Offset: 0x00020FFC
		public static JsonSchema CreateTrueSchema()
		{
			return new JsonSchema(true);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0000527B File Offset: 0x0000347B
		public JsonSchema()
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00022E04 File Offset: 0x00021004
		private JsonSchema(bool trueOrFalse)
		{
			this._trueOrFalse = new bool?(trueOrFalse);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00022E18 File Offset: 0x00021018
		public bool IsTrue
		{
			get
			{
				return this._trueOrFalse ?? false;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00022E3E File Offset: 0x0002103E
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00022E46 File Offset: 0x00021046
		public string Ref
		{
			get
			{
				return this._ref;
			}
			set
			{
				this.VerifyMutable();
				this._ref = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00022E55 File Offset: 0x00021055
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00022E5D File Offset: 0x0002105D
		public string Comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				this.VerifyMutable();
				this._comment = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00022E6C File Offset: 0x0002106C
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00022E74 File Offset: 0x00021074
		public JsonSchemaType Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this.VerifyMutable();
				this._type = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00022E83 File Offset: 0x00021083
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00022E8B File Offset: 0x0002108B
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this.VerifyMutable();
				this._format = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00022E9A File Offset: 0x0002109A
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00022EA2 File Offset: 0x000210A2
		public string Pattern
		{
			get
			{
				return this._pattern;
			}
			set
			{
				this.VerifyMutable();
				this._pattern = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00022EB1 File Offset: 0x000210B1
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00022EB9 File Offset: 0x000210B9
		public JsonNode Constant
		{
			get
			{
				return this._constant;
			}
			set
			{
				this.VerifyMutable();
				this._constant = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00022EC8 File Offset: 0x000210C8
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00022ED0 File Offset: 0x000210D0
		public List<KeyValuePair<string, JsonSchema>> Properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this.VerifyMutable();
				this._properties = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00022EDF File Offset: 0x000210DF
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00022EE7 File Offset: 0x000210E7
		public List<string> Required
		{
			get
			{
				return this._required;
			}
			set
			{
				this.VerifyMutable();
				this._required = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00022EF6 File Offset: 0x000210F6
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00022EFE File Offset: 0x000210FE
		public JsonSchema Items
		{
			get
			{
				return this._items;
			}
			set
			{
				this.VerifyMutable();
				this._items = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00022F0D File Offset: 0x0002110D
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00022F15 File Offset: 0x00021115
		public JsonSchema AdditionalProperties
		{
			get
			{
				return this._additionalProperties;
			}
			set
			{
				this.VerifyMutable();
				this._additionalProperties = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00022F24 File Offset: 0x00021124
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00022F2C File Offset: 0x0002112C
		public JsonArray Enum
		{
			get
			{
				return this._enum;
			}
			set
			{
				this.VerifyMutable();
				this._enum = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00022F3B File Offset: 0x0002113B
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00022F43 File Offset: 0x00021143
		public JsonSchema Not
		{
			get
			{
				return this._not;
			}
			set
			{
				this.VerifyMutable();
				this._not = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00022F52 File Offset: 0x00021152
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00022F5A File Offset: 0x0002115A
		public List<JsonSchema> AnyOf
		{
			get
			{
				return this._anyOf;
			}
			set
			{
				this.VerifyMutable();
				this._anyOf = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00022F69 File Offset: 0x00021169
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00022F71 File Offset: 0x00021171
		public bool HasDefaultValue
		{
			get
			{
				return this._hasDefaultValue;
			}
			set
			{
				this.VerifyMutable();
				this._hasDefaultValue = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00022F80 File Offset: 0x00021180
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00022F88 File Offset: 0x00021188
		public JsonNode DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				this.VerifyMutable();
				this._defaultValue = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00022F97 File Offset: 0x00021197
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00022F9F File Offset: 0x0002119F
		public int? MinLength
		{
			get
			{
				return this._minLength;
			}
			set
			{
				this.VerifyMutable();
				this._minLength = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00022FAE File Offset: 0x000211AE
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00022FB6 File Offset: 0x000211B6
		public int? MaxLength
		{
			get
			{
				return this._maxLength;
			}
			set
			{
				this.VerifyMutable();
				this._maxLength = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00022FC5 File Offset: 0x000211C5
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00022FCD File Offset: 0x000211CD
		public JsonSchemaExporterContext? ExporterContext { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00022FD8 File Offset: 0x000211D8
		public int KeywordCount
		{
			get
			{
				if (this._trueOrFalse != null)
				{
					return 0;
				}
				JsonSchema.<>c__DisplayClass98_0 CS$<>8__locals1;
				CS$<>8__locals1.count = 0;
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Ref != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Comment != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Type > JsonSchemaType.Any, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Format != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Pattern != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Constant != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Properties != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Required != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Items != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.AdditionalProperties != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Enum != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.Not != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.AnyOf != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.HasDefaultValue, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.MinLength != null, ref CS$<>8__locals1);
				JsonSchema.<get_KeywordCount>g__Count|98_0(this.MaxLength != null, ref CS$<>8__locals1);
				return CS$<>8__locals1.count;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00023109 File Offset: 0x00021309
		public void MakeNullable()
		{
			if (this._trueOrFalse != null)
			{
				return;
			}
			if (this.Type != JsonSchemaType.Any)
			{
				this.Type |= JsonSchemaType.Null;
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00023130 File Offset: 0x00021330
		public JsonNode ToJsonNode(JsonSchemaExporterOptions options)
		{
			JsonSchema.<>c__DisplayClass100_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.options = options;
			bool? trueOrFalse = this._trueOrFalse;
			if (trueOrFalse != null)
			{
				bool valueOrDefault = trueOrFalse.GetValueOrDefault();
				return this.<ToJsonNode>g__CompleteSchema|100_0(valueOrDefault, ref CS$<>8__locals1);
			}
			JsonObject jsonObject = new JsonObject(null);
			if (this.Ref != null)
			{
				jsonObject.Add("$ref", this.Ref);
			}
			if (this.Comment != null)
			{
				jsonObject.Add("$comment", this.Comment);
			}
			JsonNode jsonNode = JsonSchema.MapSchemaType(this.Type);
			if (jsonNode != null)
			{
				jsonObject.Add("type", jsonNode);
			}
			if (this.Format != null)
			{
				jsonObject.Add("format", this.Format);
			}
			if (this.Pattern != null)
			{
				jsonObject.Add("pattern", this.Pattern);
			}
			if (this.Constant != null)
			{
				jsonObject.Add("const", this.Constant);
			}
			if (this.Properties != null)
			{
				JsonObject jsonObject2 = new JsonObject(null);
				foreach (KeyValuePair<string, JsonSchema> keyValuePair in this.Properties)
				{
					jsonObject2.Add(keyValuePair.Key, keyValuePair.Value.ToJsonNode(CS$<>8__locals1.options));
				}
				jsonObject.Add("properties", jsonObject2);
			}
			if (this.Required != null)
			{
				JsonArray jsonArray = new JsonArray(null);
				foreach (string value in this.Required)
				{
					jsonArray.Add(value);
				}
				jsonObject.Add("required", jsonArray);
			}
			if (this.Items != null)
			{
				jsonObject.Add("items", this.Items.ToJsonNode(CS$<>8__locals1.options));
			}
			if (this.AdditionalProperties != null)
			{
				jsonObject.Add("additionalProperties", this.AdditionalProperties.ToJsonNode(CS$<>8__locals1.options));
			}
			if (this.Enum != null)
			{
				jsonObject.Add("enum", this.Enum);
			}
			if (this.Not != null)
			{
				jsonObject.Add("not", this.Not.ToJsonNode(CS$<>8__locals1.options));
			}
			if (this.AnyOf != null)
			{
				JsonArray jsonArray2 = new JsonArray(null);
				foreach (JsonSchema jsonSchema in this.AnyOf)
				{
					jsonArray2.Add(jsonSchema.ToJsonNode(CS$<>8__locals1.options));
				}
				jsonObject.Add("anyOf", jsonArray2);
			}
			if (this.HasDefaultValue)
			{
				jsonObject.Add("default", this.DefaultValue);
			}
			int? num = this.MinLength;
			if (num != null)
			{
				int valueOrDefault2 = num.GetValueOrDefault();
				jsonObject.Add("minLength", valueOrDefault2);
			}
			num = this.MaxLength;
			if (num != null)
			{
				int valueOrDefault3 = num.GetValueOrDefault();
				jsonObject.Add("maxLength", valueOrDefault3);
			}
			return this.<ToJsonNode>g__CompleteSchema|100_0(jsonObject, ref CS$<>8__locals1);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000234A0 File Offset: 0x000216A0
		public static void EnsureMutable(ref JsonSchema schema)
		{
			bool? trueOrFalse = schema._trueOrFalse;
			if (trueOrFalse != null)
			{
				if (!trueOrFalse.GetValueOrDefault())
				{
					schema = new JsonSchema
					{
						Not = JsonSchema.CreateTrueSchema()
					};
					return;
				}
				schema = new JsonSchema();
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x000234E1 File Offset: 0x000216E1
		private static ReadOnlySpan<JsonSchemaType> s_schemaValues
		{
			get
			{
				return RuntimeHelpers.CreateSpan<JsonSchemaType>(fieldof(<PrivateImplementationDetails>.BC308CC8478F56D6B93E287CF1CADBE6F297C5AF89914899F8ACB21206B84FC24).FieldHandle);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000234F0 File Offset: 0x000216F0
		private void VerifyMutable()
		{
			if (this._trueOrFalse != null)
			{
				JsonSchema.<VerifyMutable>g__Throw|104_0();
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00023514 File Offset: 0x00021714
		public unsafe static JsonNode MapSchemaType(JsonSchemaType schemaType)
		{
			if (schemaType == JsonSchemaType.Any)
			{
				return null;
			}
			string text = JsonSchema.<MapSchemaType>g__ToIdentifier|105_0(schemaType);
			if (text != null)
			{
				return text;
			}
			JsonArray jsonArray = new JsonArray(null);
			ReadOnlySpan<JsonSchemaType> s_schemaValues = JsonSchema.s_schemaValues;
			for (int i = 0; i < s_schemaValues.Length; i++)
			{
				JsonSchemaType jsonSchemaType = (JsonSchemaType)(*s_schemaValues[i]);
				if ((schemaType & jsonSchemaType) != JsonSchemaType.Any)
				{
					jsonArray.Add(JsonSchema.<MapSchemaType>g__ToIdentifier|105_0(jsonSchemaType));
				}
			}
			return jsonArray;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00023587 File Offset: 0x00021787
		[CompilerGenerated]
		internal static void <get_KeywordCount>g__Count|98_0(bool isKeywordSpecified, ref JsonSchema.<>c__DisplayClass98_0 A_1)
		{
			A_1.count += ((isKeywordSpecified > false) ? 1 : 0);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0002359C File Offset: 0x0002179C
		[CompilerGenerated]
		private JsonNode <ToJsonNode>g__CompleteSchema|100_0(JsonNode schema, ref JsonSchema.<>c__DisplayClass100_0 A_2)
		{
			JsonSchemaExporterContext? exporterContext = this.ExporterContext;
			if (exporterContext != null)
			{
				JsonSchemaExporterContext valueOrDefault = exporterContext.GetValueOrDefault();
				return A_2.options.TransformSchemaNode(valueOrDefault, schema);
			}
			return schema;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000235D5 File Offset: 0x000217D5
		[CompilerGenerated]
		internal static void <VerifyMutable>g__Throw|104_0()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000235DC File Offset: 0x000217DC
		[CompilerGenerated]
		internal static string <MapSchemaType>g__ToIdentifier|105_0(JsonSchemaType schemaType)
		{
			if (schemaType <= JsonSchemaType.Number)
			{
				switch (schemaType)
				{
				case JsonSchemaType.Null:
					return "null";
				case JsonSchemaType.Boolean:
					return "boolean";
				case JsonSchemaType.Null | JsonSchemaType.Boolean:
					break;
				case JsonSchemaType.Integer:
					return "integer";
				default:
					if (schemaType == JsonSchemaType.Number)
					{
						return "number";
					}
					break;
				}
			}
			else
			{
				if (schemaType == JsonSchemaType.String)
				{
					return "string";
				}
				if (schemaType == JsonSchemaType.Object)
				{
					return "object";
				}
				if (schemaType == JsonSchemaType.Array)
				{
					return "array";
				}
			}
			return null;
		}

		// Token: 0x040001FC RID: 508
		private readonly bool? _trueOrFalse;

		// Token: 0x040001FD RID: 509
		private string _ref;

		// Token: 0x040001FE RID: 510
		private string _comment;

		// Token: 0x040001FF RID: 511
		private JsonSchemaType _type;

		// Token: 0x04000200 RID: 512
		private string _format;

		// Token: 0x04000201 RID: 513
		private string _pattern;

		// Token: 0x04000202 RID: 514
		private JsonNode _constant;

		// Token: 0x04000203 RID: 515
		private List<KeyValuePair<string, JsonSchema>> _properties;

		// Token: 0x04000204 RID: 516
		private List<string> _required;

		// Token: 0x04000205 RID: 517
		private JsonSchema _items;

		// Token: 0x04000206 RID: 518
		private JsonSchema _additionalProperties;

		// Token: 0x04000207 RID: 519
		private JsonArray _enum;

		// Token: 0x04000208 RID: 520
		private JsonSchema _not;

		// Token: 0x04000209 RID: 521
		private List<JsonSchema> _anyOf;

		// Token: 0x0400020A RID: 522
		private bool _hasDefaultValue;

		// Token: 0x0400020B RID: 523
		private JsonNode _defaultValue;

		// Token: 0x0400020C RID: 524
		private int? _minLength;

		// Token: 0x0400020D RID: 525
		private int? _maxLength;
	}
}
