using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A40 RID: 2624
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDecalBlendMode")]
	public enum EDecalBlendMode
	{
		// Token: 0x0400462E RID: 17966
		DBM_Translucent,
		// Token: 0x0400462F RID: 17967
		DBM_Stain,
		// Token: 0x04004630 RID: 17968
		DBM_Normal,
		// Token: 0x04004631 RID: 17969
		DBM_ColorRoughness,
		// Token: 0x04004632 RID: 17970
		DBM_Emissive,
		// Token: 0x04004633 RID: 17971
		DBM_KuroLight,
		// Token: 0x04004634 RID: 17972
		DBM_DBuffer_ColorNormalRoughness,
		// Token: 0x04004635 RID: 17973
		DBM_DBuffer_Color,
		// Token: 0x04004636 RID: 17974
		DBM_DBuffer_ColorNormal,
		// Token: 0x04004637 RID: 17975
		DBM_DBuffer_ColorRoughness,
		// Token: 0x04004638 RID: 17976
		DBM_DBuffer_Normal,
		// Token: 0x04004639 RID: 17977
		DBM_DBuffer_NormalRoughness,
		// Token: 0x0400463A RID: 17978
		DBM_DBuffer_Roughness,
		// Token: 0x0400463B RID: 17979
		DBM_DBuffer_Emissive,
		// Token: 0x0400463C RID: 17980
		DBM_DBuffer_AlphaComposite,
		// Token: 0x0400463D RID: 17981
		DBM_DBuffer_EmissiveAlphaComposite,
		// Token: 0x0400463E RID: 17982
		DBM_Volumetric_DistanceFunction,
		// Token: 0x0400463F RID: 17983
		DBM_AlphaComposite,
		// Token: 0x04004640 RID: 17984
		DBM_AmbientOcclusion,
		// Token: 0x04004641 RID: 17985
		DBM_CustomShadow,
		// Token: 0x04004642 RID: 17986
		DBM_InteriorFactor,
		// Token: 0x04004643 RID: 17987
		DBM_ToonShadow,
		// Token: 0x04004644 RID: 17988
		DBM_PreMulBeforeTranslucent,
		// Token: 0x04004645 RID: 17989
		DBM_Translucent_GbufferC,
		// Token: 0x04004646 RID: 17990
		DBM_AfterTranslucent,
		// Token: 0x04004647 RID: 17991
		DBM_MAX
	}
}
