using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A2B RID: 2603
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EClothMassMode")]
	public enum EClothMassMode : byte
	{
		// Token: 0x04004592 RID: 17810
		UniformMass,
		// Token: 0x04004593 RID: 17811
		TotalMass,
		// Token: 0x04004594 RID: 17812
		Density,
		// Token: 0x04004595 RID: 17813
		MaxClothMassMode,
		// Token: 0x04004596 RID: 17814
		EClothMassMode_MAX
	}
}
