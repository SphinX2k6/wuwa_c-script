using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A52 RID: 2642
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDistributionVectorMirrorFlags")]
	public enum EDistributionVectorMirrorFlags
	{
		// Token: 0x040046F0 RID: 18160
		EDVMF_Same,
		// Token: 0x040046F1 RID: 18161
		EDVMF_Different,
		// Token: 0x040046F2 RID: 18162
		EDVMF_Mirror,
		// Token: 0x040046F3 RID: 18163
		EDVMF_MAX
	}
}
