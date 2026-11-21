using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000383 RID: 899
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.ETrackMethod")]
	public enum ETrackMethod : byte
	{
		// Token: 0x0400258B RID: 9611
		Prediction,
		// Token: 0x0400258C RID: 9612
		SolvingEquations,
		// Token: 0x0400258D RID: 9613
		Custom,
		// Token: 0x0400258E RID: 9614
		ETrackMethod_MAX
	}
}
