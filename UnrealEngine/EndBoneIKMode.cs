using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001645 RID: 5701
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EndBoneIKMode")]
	public enum EndBoneIKMode : byte
	{
		// Token: 0x0400B363 RID: 45923
		None,
		// Token: 0x0400B364 RID: 45924
		AxisModeLockX,
		// Token: 0x0400B365 RID: 45925
		AxisModeLockY,
		// Token: 0x0400B366 RID: 45926
		NewAxisModeLockX,
		// Token: 0x0400B367 RID: 45927
		NewAxisModeLockY,
		// Token: 0x0400B368 RID: 45928
		LockXAndLimitByAxis,
		// Token: 0x0400B369 RID: 45929
		LockYAndLimitByAxis,
		// Token: 0x0400B36A RID: 45930
		FullRotationMode,
		// Token: 0x0400B36B RID: 45931
		EndBoneIKMode_MAX
	}
}
