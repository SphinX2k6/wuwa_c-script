using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B01 RID: 2817
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOpacitySourceMode")]
	public enum EOpacitySourceMode
	{
		// Token: 0x04004D38 RID: 19768
		OSM_Alpha,
		// Token: 0x04004D39 RID: 19769
		OSM_ColorBrightness,
		// Token: 0x04004D3A RID: 19770
		OSM_RedChannel,
		// Token: 0x04004D3B RID: 19771
		OSM_GreenChannel,
		// Token: 0x04004D3C RID: 19772
		OSM_BlueChannel,
		// Token: 0x04004D3D RID: 19773
		OSM_MAX
	}
}
