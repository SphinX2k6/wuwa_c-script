using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E7 RID: 999
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARGeoTrackingAccuracy")]
	public enum EARGeoTrackingAccuracy : byte
	{
		// Token: 0x04001870 RID: 6256
		Undetermined,
		// Token: 0x04001871 RID: 6257
		Low,
		// Token: 0x04001872 RID: 6258
		Medium,
		// Token: 0x04001873 RID: 6259
		High,
		// Token: 0x04001874 RID: 6260
		EARGeoTrackingAccuracy_MAX
	}
}
