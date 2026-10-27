using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001680 RID: 5760
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.SightLockMode")]
	public enum SightLockMode : byte
	{
		// Token: 0x0400B634 RID: 46644
		None,
		// Token: 0x0400B635 RID: 46645
		SightBoneFirst,
		// Token: 0x0400B636 RID: 46646
		Ratio,
		// Token: 0x0400B637 RID: 46647
		Shooting,
		// Token: 0x0400B638 RID: 46648
		SightLockMode_MAX
	}
}
