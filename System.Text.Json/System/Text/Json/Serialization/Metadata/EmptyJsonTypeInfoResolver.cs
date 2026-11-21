using System;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C1 RID: 193
	internal sealed class EmptyJsonTypeInfoResolver : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
	{
		// Token: 0x06000A5C RID: 2652 RVA: 0x00028060 File Offset: 0x00026260
		public JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00003363 File Offset: 0x00001563
		public bool IsCompatibleWithOptions(JsonSerializerOptions _)
		{
			return true;
		}
	}
}
