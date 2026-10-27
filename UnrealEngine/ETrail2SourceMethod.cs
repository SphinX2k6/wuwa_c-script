using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B99 RID: 2969
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETrail2SourceMethod")]
	public enum ETrail2SourceMethod
	{
		// Token: 0x040051C9 RID: 20937
		PET2SRCM_Default,
		// Token: 0x040051CA RID: 20938
		PET2SRCM_Particle,
		// Token: 0x040051CB RID: 20939
		PET2SRCM_Actor,
		// Token: 0x040051CC RID: 20940
		PET2SRCM_MAX
	}
}
