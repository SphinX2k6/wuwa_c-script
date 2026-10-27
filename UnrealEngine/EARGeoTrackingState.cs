using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E8 RID: 1000
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARGeoTrackingState")]
	public enum EARGeoTrackingState : byte
	{
		// Token: 0x04001876 RID: 6262
		Initializing,
		// Token: 0x04001877 RID: 6263
		Localized,
		// Token: 0x04001878 RID: 6264
		Localizing,
		// Token: 0x04001879 RID: 6265
		NotAvailable,
		// Token: 0x0400187A RID: 6266
		EARGeoTrackingState_MAX
	}
}
