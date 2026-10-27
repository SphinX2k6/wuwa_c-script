using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A8A RID: 2698
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKinematicBonesUpdateToPhysics")]
	public enum EKinematicBonesUpdateToPhysics
	{
		// Token: 0x0400484D RID: 18509
		SkipSimulatingBones,
		// Token: 0x0400484E RID: 18510
		SkipAllBones,
		// Token: 0x0400484F RID: 18511
		EKinematicBonesUpdateToPhysics_MAX
	}
}
