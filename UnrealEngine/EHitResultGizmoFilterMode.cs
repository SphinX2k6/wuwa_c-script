using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A53 RID: 10835
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ViewportInteraction.EHitResultGizmoFilterMode")]
	public enum EHitResultGizmoFilterMode : byte
	{
		// Token: 0x04015F26 RID: 89894
		All,
		// Token: 0x04015F27 RID: 89895
		NoGizmos,
		// Token: 0x04015F28 RID: 89896
		GizmosOnly,
		// Token: 0x04015F29 RID: 89897
		EHitResultGizmoFilterMode_MAX
	}
}
