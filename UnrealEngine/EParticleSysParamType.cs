using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B13 RID: 2835
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSysParamType")]
	public enum EParticleSysParamType
	{
		// Token: 0x04004DA5 RID: 19877
		PSPT_None,
		// Token: 0x04004DA6 RID: 19878
		PSPT_Scalar,
		// Token: 0x04004DA7 RID: 19879
		PSPT_ScalarRand,
		// Token: 0x04004DA8 RID: 19880
		PSPT_Vector,
		// Token: 0x04004DA9 RID: 19881
		PSPT_VectorRand,
		// Token: 0x04004DAA RID: 19882
		PSPT_Color,
		// Token: 0x04004DAB RID: 19883
		PSPT_Actor,
		// Token: 0x04004DAC RID: 19884
		PSPT_Material,
		// Token: 0x04004DAD RID: 19885
		PSPT_VectorUnitRand,
		// Token: 0x04004DAE RID: 19886
		PSPT_MAX
	}
}
