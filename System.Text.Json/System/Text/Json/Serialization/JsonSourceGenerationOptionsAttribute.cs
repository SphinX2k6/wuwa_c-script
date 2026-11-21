using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000083 RID: 131
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class JsonSourceGenerationOptionsAttribute : JsonAttribute
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x00027E1C File Offset: 0x0002601C
		public JsonSourceGenerationOptionsAttribute()
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00027E46 File Offset: 0x00026046
		public JsonSourceGenerationOptionsAttribute(JsonSerializerDefaults defaults)
		{
			if (defaults == JsonSerializerDefaults.Web)
			{
				this.PropertyNameCaseInsensitive = true;
				this.PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase;
				this.NumberHandling = JsonNumberHandling.AllowReadingFromString;
				return;
			}
			if (defaults != JsonSerializerDefaults.General)
			{
				throw new ArgumentOutOfRangeException("defaults");
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00027E76 File Offset: 0x00026076
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00027E7E File Offset: 0x0002607E
		public bool AllowOutOfOrderMetadataProperties { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00027E87 File Offset: 0x00026087
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00027E8F File Offset: 0x0002608F
		public bool AllowTrailingCommas { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00027E98 File Offset: 0x00026098
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00027EA0 File Offset: 0x000260A0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Type[] Converters { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00027EA9 File Offset: 0x000260A9
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00027EB1 File Offset: 0x000260B1
		public int DefaultBufferSize { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00027EBA File Offset: 0x000260BA
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00027EC2 File Offset: 0x000260C2
		public JsonIgnoreCondition DefaultIgnoreCondition { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00027ECB File Offset: 0x000260CB
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00027ED3 File Offset: 0x000260D3
		public JsonKnownNamingPolicy DictionaryKeyPolicy { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00027EDC File Offset: 0x000260DC
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00027EE4 File Offset: 0x000260E4
		public bool IgnoreReadOnlyFields { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00027EED File Offset: 0x000260ED
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00027EF5 File Offset: 0x000260F5
		public bool IgnoreReadOnlyProperties { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00027EFE File Offset: 0x000260FE
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00027F06 File Offset: 0x00026106
		public bool IncludeFields { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00027F0F File Offset: 0x0002610F
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00027F17 File Offset: 0x00026117
		public int MaxDepth { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00027F20 File Offset: 0x00026120
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00027F28 File Offset: 0x00026128
		public JsonNumberHandling NumberHandling { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00027F31 File Offset: 0x00026131
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00027F39 File Offset: 0x00026139
		public JsonObjectCreationHandling PreferredObjectCreationHandling { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00027F42 File Offset: 0x00026142
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00027F4A File Offset: 0x0002614A
		public bool PropertyNameCaseInsensitive { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00027F53 File Offset: 0x00026153
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00027F5B File Offset: 0x0002615B
		public JsonKnownNamingPolicy PropertyNamingPolicy { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00027F64 File Offset: 0x00026164
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00027F6C File Offset: 0x0002616C
		public JsonCommentHandling ReadCommentHandling { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00027F75 File Offset: 0x00026175
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00027F7D File Offset: 0x0002617D
		public bool RespectNullableAnnotations { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00027F86 File Offset: 0x00026186
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00027F8E File Offset: 0x0002618E
		public bool RespectRequiredConstructorParameters { get; set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00027F97 File Offset: 0x00026197
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00027F9F File Offset: 0x0002619F
		public JsonUnknownTypeHandling UnknownTypeHandling { get; set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00027FA8 File Offset: 0x000261A8
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00027FB0 File Offset: 0x000261B0
		public JsonUnmappedMemberHandling UnmappedMemberHandling { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00027FB9 File Offset: 0x000261B9
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00027FC1 File Offset: 0x000261C1
		public bool WriteIndented { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00027FCA File Offset: 0x000261CA
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00027FD2 File Offset: 0x000261D2
		public char IndentCharacter { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00027FDB File Offset: 0x000261DB
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00027FE3 File Offset: 0x000261E3
		public int IndentSize { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00027FEC File Offset: 0x000261EC
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00027FF4 File Offset: 0x000261F4
		public JsonSourceGenerationMode GenerationMode { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00027FFD File Offset: 0x000261FD
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00028005 File Offset: 0x00026205
		public bool UseStringEnumConverter { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0002800E File Offset: 0x0002620E
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00028016 File Offset: 0x00026216
		public string NewLine { get; set; }
	}
}
