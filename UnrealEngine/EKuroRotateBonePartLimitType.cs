using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001643 RID: 5699
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EKuroRotateBonePartLimitType")]
	public enum EKuroRotateBonePartLimitType
	{
		// Token: 0x0400B357 RID: 45911
		Angle,
		// Token: 0x0400B358 RID: 45912
		PitchAndYaw,
		// Token: 0x0400B359 RID: 45913
		PitchAndYawSquare,
		// Token: 0x0400B35A RID: 45914
		EKuroRotateBonePartLimitType_MAX
	}
}
