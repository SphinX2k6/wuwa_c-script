using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F5D RID: 8029
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeLayerBlendType")]
	public enum ELandscapeLayerBlendType
	{
		// Token: 0x0401076A RID: 67434
		LB_WeightBlend,
		// Token: 0x0401076B RID: 67435
		LB_AlphaBlend,
		// Token: 0x0401076C RID: 67436
		LB_HeightBlend,
		// Token: 0x0401076D RID: 67437
		LB_AlphaHeightBlend,
		// Token: 0x0401076E RID: 67438
		LB_MAX
	}
}
