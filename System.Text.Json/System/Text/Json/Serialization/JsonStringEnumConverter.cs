using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonStringEnumConverter<[Nullable(0)] TEnum> : JsonConverterFactory where TEnum : struct, Enum
	{
		// Token: 0x060009C8 RID: 2504 RVA: 0x0002A3CC File Offset: 0x000285CC
		public JsonStringEnumConverter() : this(null, true)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002A3D6 File Offset: 0x000285D6
		[NullableContext(2)]
		public JsonStringEnumConverter(JsonNamingPolicy namingPolicy = null, bool allowIntegerValues = true)
		{
			this._namingPolicy = namingPolicy;
			this._converterOptions = (allowIntegerValues ? (EnumConverterOptions.AllowStrings | EnumConverterOptions.AllowNumbers) : EnumConverterOptions.AllowStrings);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000281E0 File Offset: 0x000263E0
		public sealed override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(TEnum);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0002A3F2 File Offset: 0x000285F2
		[return: Nullable(2)]
		public sealed override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			if (typeToConvert != typeof(TEnum))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_JsonConverterFactory_TypeNotSupported(typeToConvert);
			}
			return EnumConverterFactory.Create<TEnum>(this._converterOptions, options, this._namingPolicy);
		}

		// Token: 0x040002B0 RID: 688
		private readonly JsonNamingPolicy _namingPolicy;

		// Token: 0x040002B1 RID: 689
		private readonly EnumConverterOptions _converterOptions;
	}
}
