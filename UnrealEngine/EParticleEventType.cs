using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0D RID: 2829
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleEventType")]
	public enum EParticleEventType
	{
		// Token: 0x04004D7B RID: 19835
		EPET_Any,
		// Token: 0x04004D7C RID: 19836
		EPET_Spawn,
		// Token: 0x04004D7D RID: 19837
		EPET_Death,
		// Token: 0x04004D7E RID: 19838
		EPET_Collision,
		// Token: 0x04004D7F RID: 19839
		EPET_Burst,
		// Token: 0x04004D80 RID: 19840
		EPET_Blueprint,
		// Token: 0x04004D81 RID: 19841
		EPET_MAX
	}
}
