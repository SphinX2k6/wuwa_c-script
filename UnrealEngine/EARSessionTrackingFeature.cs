using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F5 RID: 1013
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARSessionTrackingFeature")]
	public enum EARSessionTrackingFeature : byte
	{
		// Token: 0x040018D2 RID: 6354
		None,
		// Token: 0x040018D3 RID: 6355
		PoseDetection2D,
		// Token: 0x040018D4 RID: 6356
		PersonSegmentation,
		// Token: 0x040018D5 RID: 6357
		PersonSegmentationWithDepth,
		// Token: 0x040018D6 RID: 6358
		SceneDepth,
		// Token: 0x040018D7 RID: 6359
		SmoothedSceneDepth,
		// Token: 0x040018D8 RID: 6360
		EARSessionTrackingFeature_MAX
	}
}
