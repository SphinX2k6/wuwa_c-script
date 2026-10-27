using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A56 RID: 10838
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VolumeGIEditor.EProbeVisualizeType")]
	public enum EProbeVisualizeType : byte
	{
		// Token: 0x04015F3C RID: 89916
		PVT_None,
		// Token: 0x04015F3D RID: 89917
		PVT_Probe,
		// Token: 0x04015F3E RID: 89918
		PVT_ProbeGrid,
		// Token: 0x04015F3F RID: 89919
		PVT_IrradianceVolume,
		// Token: 0x04015F40 RID: 89920
		PVT_AmbientLight,
		// Token: 0x04015F41 RID: 89921
		PVT_MAX
	}
}
