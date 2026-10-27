using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001511 RID: 5393
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngine.EPackageMode")]
	public enum EPackageMode : sbyte
	{
		// Token: 0x0400A9A4 RID: 43428
		CookToLevel_Invalid,
		// Token: 0x0400A9A5 RID: 43429
		CookToTemp,
		// Token: 0x0400A9A6 RID: 43430
		Bake,
		// Token: 0x0400A9A7 RID: 43431
		EPackageMode_MAX
	}
}
