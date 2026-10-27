using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB9 RID: 3001
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVolumeLightingMethod")]
	public enum EVolumeLightingMethod
	{
		// Token: 0x040052A8 RID: 21160
		VLM_VolumetricLightmap,
		// Token: 0x040052A9 RID: 21161
		VLM_SparseVolumeLightingSamples,
		// Token: 0x040052AA RID: 21162
		VLM_OptimizedVolumetricLightmap,
		// Token: 0x040052AB RID: 21163
		VLM_MAX
	}
}
