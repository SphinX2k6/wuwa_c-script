using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001838 RID: 6200
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.ETrackMethod")]
	public enum ETrackMethod : byte
	{
		// Token: 0x0400C6DA RID: 50906
		Prediction,
		// Token: 0x0400C6DB RID: 50907
		SolvingEquations,
		// Token: 0x0400C6DC RID: 50908
		Custom,
		// Token: 0x0400C6DD RID: 50909
		ETrackMethod_MAX
	}
}
