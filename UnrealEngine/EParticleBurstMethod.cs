using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B08 RID: 2824
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleBurstMethod")]
	public enum EParticleBurstMethod
	{
		// Token: 0x04004D61 RID: 19809
		EPBM_Instant,
		// Token: 0x04004D62 RID: 19810
		EPBM_Interpolated,
		// Token: 0x04004D63 RID: 19811
		EPBM_MAX
	}
}
