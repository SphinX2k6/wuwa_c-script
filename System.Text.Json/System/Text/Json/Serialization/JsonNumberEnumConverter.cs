using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000097 RID: 151
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class JsonNumberEnumConverter<[Nullable(0)] TEnum> : JsonConverterFactory where TEnum : struct, Enum
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x000281E0 File Offset: 0x000263E0
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(TEnum);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000281F2 File Offset: 0x000263F2
		[return: Nullable(2)]
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			if (typeToConvert != typeof(TEnum))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_JsonConverterFactory_TypeNotSupported(typeToConvert);
			}
			return EnumConverterFactory.Create<TEnum>(EnumConverterOptions.AllowNumbers, options, null);
		}
	}
}
