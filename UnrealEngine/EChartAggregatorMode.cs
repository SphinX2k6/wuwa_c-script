using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002788 RID: 10120
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EChartAggregatorMode")]
	public enum EChartAggregatorMode : byte
	{
		// Token: 0x040149C0 RID: 84416
		TextureSizeProportions,
		// Token: 0x040149C1 RID: 84417
		SurfaceArea,
		// Token: 0x040149C2 RID: 84418
		OriginalPixelDensity,
		// Token: 0x040149C3 RID: 84419
		UVSizeProportions,
		// Token: 0x040149C4 RID: 84420
		EChartAggregatorMode_MAX
	}
}
