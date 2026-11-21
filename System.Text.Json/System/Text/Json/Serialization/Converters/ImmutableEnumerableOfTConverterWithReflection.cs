using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000F7 RID: 247
	internal sealed class ImmutableEnumerableOfTConverterWithReflection<TCollection, TElement> : ImmutableEnumerableOfTConverter<TCollection, TElement> where TCollection : IEnumerable<TElement>
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x00032763 File Offset: 0x00030963
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		public ImmutableEnumerableOfTConverterWithReflection()
		{
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003276B File Offset: 0x0003096B
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		internal override void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			jsonTypeInfo.CreateObjectWithArgs = DefaultJsonTypeInfoResolver.MemberAccessor.CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>();
		}
	}
}
