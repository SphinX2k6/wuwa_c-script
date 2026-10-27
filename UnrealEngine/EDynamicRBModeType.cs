using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163B RID: 5691
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EDynamicRBModeType")]
	public enum EDynamicRBModeType : byte
	{
		// Token: 0x0400B327 RID: 45863
		Ragdoll,
		// Token: 0x0400B328 RID: 45864
		AnimPhysics,
		// Token: 0x0400B329 RID: 45865
		EDynamicRBModeType_MAX
	}
}
