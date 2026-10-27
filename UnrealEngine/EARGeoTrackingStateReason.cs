using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E9 RID: 1001
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARGeoTrackingStateReason")]
	public enum EARGeoTrackingStateReason : byte
	{
		// Token: 0x0400187C RID: 6268
		None,
		// Token: 0x0400187D RID: 6269
		NotAvailableAtLocation,
		// Token: 0x0400187E RID: 6270
		NeedLocationPermissions,
		// Token: 0x0400187F RID: 6271
		DevicePointedTooLow,
		// Token: 0x04001880 RID: 6272
		WorldTrackingUnstable,
		// Token: 0x04001881 RID: 6273
		WaitingForLocation,
		// Token: 0x04001882 RID: 6274
		GeoDataNotLoaded,
		// Token: 0x04001883 RID: 6275
		VisualLocalizationFailed,
		// Token: 0x04001884 RID: 6276
		WaitingForAvailabilityCheck,
		// Token: 0x04001885 RID: 6277
		EARGeoTrackingStateReason_MAX
	}
}
