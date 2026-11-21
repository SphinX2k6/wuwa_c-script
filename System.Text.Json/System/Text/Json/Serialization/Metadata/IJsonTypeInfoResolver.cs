using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000B6 RID: 182
	[NullableContext(1)]
	public interface IJsonTypeInfoResolver
	{
		// Token: 0x06000A19 RID: 2585
		[return: Nullable(2)]
		JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options);
	}
}
