using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B15 RID: 2837
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSystemOcclusionBoundsMethod")]
	public enum EParticleSystemOcclusionBoundsMethod
	{
		// Token: 0x04004DB7 RID: 19895
		EPSOBM_None,
		// Token: 0x04004DB8 RID: 19896
		EPSOBM_ParticleBounds,
		// Token: 0x04004DB9 RID: 19897
		EPSOBM_CustomBounds,
		// Token: 0x04004DBA RID: 19898
		EPSOBM_MAX
	}
}
