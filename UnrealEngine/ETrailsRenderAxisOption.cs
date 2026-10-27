using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B9A RID: 2970
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETrailsRenderAxisOption")]
	public enum ETrailsRenderAxisOption
	{
		// Token: 0x040051CE RID: 20942
		Trails_CameraUp,
		// Token: 0x040051CF RID: 20943
		Trails_SourceUp,
		// Token: 0x040051D0 RID: 20944
		Trails_WorldUp,
		// Token: 0x040051D1 RID: 20945
		Trails_MAX
	}
}
