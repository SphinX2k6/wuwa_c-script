using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000274 RID: 628
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkCollisionChannel")]
	public enum EAkCollisionChannel
	{
		// Token: 0x04000CEB RID: 3307
		EAKCC_WorldStatic,
		// Token: 0x04000CEC RID: 3308
		EAKCC_WorldDynamic,
		// Token: 0x04000CED RID: 3309
		EAKCC_Pawn,
		// Token: 0x04000CEE RID: 3310
		EAKCC_Visibility,
		// Token: 0x04000CEF RID: 3311
		EAKCC_Camera,
		// Token: 0x04000CF0 RID: 3312
		EAKCC_PhysicsBody,
		// Token: 0x04000CF1 RID: 3313
		EAKCC_Vehicle,
		// Token: 0x04000CF2 RID: 3314
		EAKCC_Destructible,
		// Token: 0x04000CF3 RID: 3315
		EAKCC_UseIntegrationSettingsDefault,
		// Token: 0x04000CF4 RID: 3316
		EAKCC_MAX
	}
}
