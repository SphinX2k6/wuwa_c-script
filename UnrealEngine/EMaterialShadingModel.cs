using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ABF RID: 2751
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialShadingModel")]
	public enum EMaterialShadingModel
	{
		// Token: 0x04004A00 RID: 18944
		MSM_Unlit,
		// Token: 0x04004A01 RID: 18945
		MSM_DefaultLit,
		// Token: 0x04004A02 RID: 18946
		MSM_Subsurface,
		// Token: 0x04004A03 RID: 18947
		MSM_PreintegratedSkin,
		// Token: 0x04004A04 RID: 18948
		MSM_ClearCoat,
		// Token: 0x04004A05 RID: 18949
		MSM_SubsurfaceProfile,
		// Token: 0x04004A06 RID: 18950
		MSM_TwoSidedFoliage,
		// Token: 0x04004A07 RID: 18951
		MSM_SpecularFoliage,
		// Token: 0x04004A08 RID: 18952
		MSM_DefaultLitMobileSSR,
		// Token: 0x04004A09 RID: 18953
		MSM_SceneHLOD,
		// Token: 0x04004A0A RID: 18954
		MSM_SingleLayerWater,
		// Token: 0x04004A0B RID: 18955
		MSM_ThinTranslucent,
		// Token: 0x04004A0C RID: 18956
		MSM_ToonCommon,
		// Token: 0x04004A0D RID: 18957
		MSM_ToonOutline,
		// Token: 0x04004A0E RID: 18958
		MSM_ToonFace,
		// Token: 0x04004A0F RID: 18959
		MSM_ToonHair,
		// Token: 0x04004A10 RID: 18960
		MSM_NUM,
		// Token: 0x04004A11 RID: 18961
		MSM_FromMaterialExpression,
		// Token: 0x04004A12 RID: 18962
		MSM_MAX
	}
}
