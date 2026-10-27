using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200030B RID: 779
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysLinearConstraintType")]
	public enum AnimPhysLinearConstraintType : byte
	{
		// Token: 0x040012A3 RID: 4771
		Free,
		// Token: 0x040012A4 RID: 4772
		Limited,
		// Token: 0x040012A5 RID: 4773
		AnimPhysLinearConstraintType_MAX
	}
}
