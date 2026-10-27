using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A71 RID: 2673
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFontCacheType")]
	public enum EFontCacheType : byte
	{
		// Token: 0x040047B6 RID: 18358
		Offline,
		// Token: 0x040047B7 RID: 18359
		Runtime,
		// Token: 0x040047B8 RID: 18360
		EFontCacheType_MAX
	}
}
