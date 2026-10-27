using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0B RID: 2827
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleCollisionMode")]
	public enum EParticleCollisionMode
	{
		// Token: 0x04004D72 RID: 19826
		SceneDepth,
		// Token: 0x04004D73 RID: 19827
		DistanceField,
		// Token: 0x04004D74 RID: 19828
		EParticleCollisionMode_MAX
	}
}
