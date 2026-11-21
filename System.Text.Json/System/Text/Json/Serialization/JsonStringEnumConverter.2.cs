using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A9 RID: 169
	[NullableContext(1)]
	[Nullable(0)]
	[RequiresDynamicCode("JsonStringEnumConverter cannot be statically analyzed and requires runtime code generation. Applications should use the generic JsonStringEnumConverter<TEnum> instead.")]
	public class JsonStringEnumConverter : JsonConverterFactory
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x0002A41E File Offset: 0x0002861E
		public JsonStringEnumConverter() : this(null, true)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0002A428 File Offset: 0x00028628
		[NullableContext(2)]
		public JsonStringEnumConverter(JsonNamingPolicy namingPolicy = null, bool allowIntegerValues = true)
		{
			this._namingPolicy = namingPolicy;
			this._converterOptions = (allowIntegerValues ? (EnumConverterOptions.AllowStrings | EnumConverterOptions.AllowNumbers) : EnumConverterOptions.AllowStrings);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0002A444 File Offset: 0x00028644
		public sealed override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert.IsEnum;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0002A44C File Offset: 0x0002864C
		public sealed override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			if (!typeToConvert.IsEnum)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_JsonConverterFactory_TypeNotSupported(typeToConvert);
			}
			return EnumConverterFactory.Create(typeToConvert, this._converterOptions, this._namingPolicy, options);
		}

		// Token: 0x040002B2 RID: 690
		private readonly JsonNamingPolicy _namingPolicy;

		// Token: 0x040002B3 RID: 691
		private readonly EnumConverterOptions _converterOptions;
	}
}
