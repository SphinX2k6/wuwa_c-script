using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004EE RID: 1262
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ECRSimConstraintType")]
	public enum ECRSimConstraintType : byte
	{
		// Token: 0x0400203C RID: 8252
		Distance,
		// Token: 0x0400203D RID: 8253
		DistanceFromA,
		// Token: 0x0400203E RID: 8254
		DistanceFromB,
		// Token: 0x0400203F RID: 8255
		Plane,
		// Token: 0x04002040 RID: 8256
		ECRSimConstraintType_MAX
	}
}
