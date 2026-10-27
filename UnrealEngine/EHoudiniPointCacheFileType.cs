using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001513 RID: 5395
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniNiagara.EHoudiniPointCacheFileType")]
	public enum EHoudiniPointCacheFileType : byte
	{
		// Token: 0x0400A9AD RID: 43437
		Invalid,
		// Token: 0x0400A9AE RID: 43438
		CSV,
		// Token: 0x0400A9AF RID: 43439
		JSON,
		// Token: 0x0400A9B0 RID: 43440
		BJSON,
		// Token: 0x0400A9B1 RID: 43441
		EHoudiniPointCacheFileType_MAX
	}
}
