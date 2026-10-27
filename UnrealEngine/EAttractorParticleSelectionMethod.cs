using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FA RID: 2554
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttractorParticleSelectionMethod")]
	public enum EAttractorParticleSelectionMethod
	{
		// Token: 0x0400447C RID: 17532
		EAPSM_Random,
		// Token: 0x0400447D RID: 17533
		EAPSM_Sequential,
		// Token: 0x0400447E RID: 17534
		EAPSM_MAX
	}
}
