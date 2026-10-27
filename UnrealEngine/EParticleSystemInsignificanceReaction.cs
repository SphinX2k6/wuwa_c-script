using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B14 RID: 2836
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSystemInsignificanceReaction")]
	public enum EParticleSystemInsignificanceReaction : byte
	{
		// Token: 0x04004DB0 RID: 19888
		Auto,
		// Token: 0x04004DB1 RID: 19889
		Complete,
		// Token: 0x04004DB2 RID: 19890
		DisableTick,
		// Token: 0x04004DB3 RID: 19891
		DisableTickAndKill,
		// Token: 0x04004DB4 RID: 19892
		Num,
		// Token: 0x04004DB5 RID: 19893
		EParticleSystemInsignificanceReaction_MAX
	}
}
