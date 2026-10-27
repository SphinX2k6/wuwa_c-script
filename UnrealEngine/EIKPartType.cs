using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163F RID: 5695
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EIKPartType")]
	public enum EIKPartType : byte
	{
		// Token: 0x0400B344 RID: 45892
		None,
		// Token: 0x0400B345 RID: 45893
		LeftLeg,
		// Token: 0x0400B346 RID: 45894
		RightLeg,
		// Token: 0x0400B347 RID: 45895
		LeftArm,
		// Token: 0x0400B348 RID: 45896
		RightArm,
		// Token: 0x0400B349 RID: 45897
		EIKPartType_MAX
	}
}
