using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0A RID: 2826
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleCollisionComplete")]
	public enum EParticleCollisionComplete
	{
		// Token: 0x04004D6A RID: 19818
		EPCC_Kill,
		// Token: 0x04004D6B RID: 19819
		EPCC_Freeze,
		// Token: 0x04004D6C RID: 19820
		EPCC_HaltCollisions,
		// Token: 0x04004D6D RID: 19821
		EPCC_FreezeTranslation,
		// Token: 0x04004D6E RID: 19822
		EPCC_FreezeRotation,
		// Token: 0x04004D6F RID: 19823
		EPCC_FreezeMovement,
		// Token: 0x04004D70 RID: 19824
		EPCC_MAX
	}
}
