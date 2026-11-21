using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000152 RID: 338
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class UnsupportedTypeConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x00038598 File Offset: 0x00036798
		public override bool CanConvert(Type type)
		{
			return typeof(MemberInfo).IsAssignableFrom(type) || type == typeof(SerializationInfo) || type == typeof(IntPtr) || type == typeof(UIntPtr) || typeof(Delegate).IsAssignableFrom(type);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000385FF File Offset: 0x000367FF
		public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
		{
			return UnsupportedTypeConverterFactory.CreateUnsupportedConverterForType(type, null);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00038608 File Offset: 0x00036808
		internal static JsonConverter CreateUnsupportedConverterForType(Type type, string errorMessage = null)
		{
			return (JsonConverter)Activator.CreateInstance(typeof(UnsupportedTypeConverter<>).MakeGenericType(new Type[]
			{
				type
			}), BindingFlags.Instance | BindingFlags.Public, null, new object[]
			{
				errorMessage
			}, null);
		}
	}
}
