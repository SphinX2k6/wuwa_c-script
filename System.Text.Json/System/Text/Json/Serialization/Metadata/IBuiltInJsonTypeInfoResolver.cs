using System;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C2 RID: 194
	internal interface IBuiltInJsonTypeInfoResolver
	{
		// Token: 0x06000A5F RID: 2655
		bool IsCompatibleWithOptions(JsonSerializerOptions options);
	}
}
