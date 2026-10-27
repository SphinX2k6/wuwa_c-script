using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F4 RID: 1268
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERBFQuatDistanceType")]
	public enum ERBFQuatDistanceType : byte
	{
		// Token: 0x0400205A RID: 8282
		Euclidean,
		// Token: 0x0400205B RID: 8283
		ArcLength,
		// Token: 0x0400205C RID: 8284
		SwingAngle,
		// Token: 0x0400205D RID: 8285
		TwistAngle,
		// Token: 0x0400205E RID: 8286
		ERBFQuatDistanceType_MAX
	}
}
