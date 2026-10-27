using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F6 RID: 1014
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARSessionType")]
	public enum EARSessionType : byte
	{
		// Token: 0x040018DA RID: 6362
		None,
		// Token: 0x040018DB RID: 6363
		Orientation,
		// Token: 0x040018DC RID: 6364
		World,
		// Token: 0x040018DD RID: 6365
		Face,
		// Token: 0x040018DE RID: 6366
		Image,
		// Token: 0x040018DF RID: 6367
		ObjectScanning,
		// Token: 0x040018E0 RID: 6368
		PoseTracking,
		// Token: 0x040018E1 RID: 6369
		GeoTracking,
		// Token: 0x040018E2 RID: 6370
		EARSessionType_MAX
	}
}
