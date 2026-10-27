using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F7 RID: 1015
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARTextureType")]
	public enum EARTextureType : byte
	{
		// Token: 0x040018E4 RID: 6372
		Unknown,
		// Token: 0x040018E5 RID: 6373
		CameraImage,
		// Token: 0x040018E6 RID: 6374
		CameraDepth,
		// Token: 0x040018E7 RID: 6375
		EnvironmentCapture,
		// Token: 0x040018E8 RID: 6376
		PersonSegmentationImage,
		// Token: 0x040018E9 RID: 6377
		PersonSegmentationDepth,
		// Token: 0x040018EA RID: 6378
		SceneDepthMap,
		// Token: 0x040018EB RID: 6379
		SceneDepthConfidenceMap,
		// Token: 0x040018EC RID: 6380
		EARTextureType_MAX
	}
}
