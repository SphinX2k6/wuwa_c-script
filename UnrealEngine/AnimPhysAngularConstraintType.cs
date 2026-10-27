using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000309 RID: 777
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysAngularConstraintType")]
	public enum AnimPhysAngularConstraintType : byte
	{
		// Token: 0x04001291 RID: 4753
		Angular,
		// Token: 0x04001292 RID: 4754
		Cone,
		// Token: 0x04001293 RID: 4755
		AnimPhysAngularConstraintType_MAX
	}
}
