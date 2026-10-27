using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0C RID: 2828
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleCollisionResponse")]
	public enum EParticleCollisionResponse
	{
		// Token: 0x04004D76 RID: 19830
		Bounce,
		// Token: 0x04004D77 RID: 19831
		Stop,
		// Token: 0x04004D78 RID: 19832
		Kill,
		// Token: 0x04004D79 RID: 19833
		EParticleCollisionResponse_MAX
	}
}
