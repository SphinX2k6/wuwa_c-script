using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F9 RID: 1017
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARTrackingQualityReason")]
	public enum EARTrackingQualityReason : byte
	{
		// Token: 0x040018F3 RID: 6387
		None,
		// Token: 0x040018F4 RID: 6388
		Initializing,
		// Token: 0x040018F5 RID: 6389
		Relocalizing,
		// Token: 0x040018F6 RID: 6390
		ExcessiveMotion,
		// Token: 0x040018F7 RID: 6391
		InsufficientFeatures,
		// Token: 0x040018F8 RID: 6392
		InsufficientLight,
		// Token: 0x040018F9 RID: 6393
		BadState,
		// Token: 0x040018FA RID: 6394
		EARTrackingQualityReason_MAX
	}
}
