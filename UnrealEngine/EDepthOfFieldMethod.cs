using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A44 RID: 2628
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDepthOfFieldMethod")]
	public enum EDepthOfFieldMethod
	{
		// Token: 0x0400465D RID: 18013
		DOFM_BokehDOF,
		// Token: 0x0400465E RID: 18014
		DOFM_Gaussian,
		// Token: 0x0400465F RID: 18015
		DOFM_CircleDOF,
		// Token: 0x04004660 RID: 18016
		DOFM_MAX
	}
}
