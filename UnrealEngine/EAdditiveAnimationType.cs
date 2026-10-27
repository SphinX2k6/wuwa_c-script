using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E3 RID: 2531
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAdditiveAnimationType")]
	public enum EAdditiveAnimationType
	{
		// Token: 0x040043F2 RID: 17394
		AAT_None,
		// Token: 0x040043F3 RID: 17395
		AAT_LocalSpaceBase,
		// Token: 0x040043F4 RID: 17396
		AAT_RotationOffsetMeshSpace,
		// Token: 0x040043F5 RID: 17397
		AAT_MAX
	}
}
