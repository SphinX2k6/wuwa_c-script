using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000FB RID: 251
	internal sealed class StackOrQueueConverterWithReflection<TCollection> : StackOrQueueConverter<TCollection> where TCollection : IEnumerable
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x00032A7A File Offset: 0x00030C7A
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public StackOrQueueConverterWithReflection()
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00032A82 File Offset: 0x00030C82
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal override void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			jsonTypeInfo.AddMethodDelegate = DefaultJsonTypeInfoResolver.MemberAccessor.CreateAddMethodDelegate<TCollection>();
		}
	}
}
