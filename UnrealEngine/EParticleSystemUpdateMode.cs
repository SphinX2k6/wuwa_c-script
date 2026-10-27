using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B16 RID: 2838
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSystemUpdateMode")]
	public enum EParticleSystemUpdateMode
	{
		// Token: 0x04004DBC RID: 19900
		EPSUM_RealTime,
		// Token: 0x04004DBD RID: 19901
		EPSUM_FixedTime,
		// Token: 0x04004DBE RID: 19902
		EPSUM_MAX
	}
}
