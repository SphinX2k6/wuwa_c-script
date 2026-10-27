using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F8 RID: 1016
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARTrackingQuality")]
	public enum EARTrackingQuality : byte
	{
		// Token: 0x040018EE RID: 6382
		NotTracking,
		// Token: 0x040018EF RID: 6383
		OrientationOnly,
		// Token: 0x040018F0 RID: 6384
		OrientationAndPosition,
		// Token: 0x040018F1 RID: 6385
		EARTrackingQuality_MAX
	}
}
