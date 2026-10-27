using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AB2 RID: 2738
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialExposedViewProperty")]
	public enum EMaterialExposedViewProperty
	{
		// Token: 0x04004982 RID: 18818
		MEVP_BufferSize,
		// Token: 0x04004983 RID: 18819
		MEVP_FieldOfView,
		// Token: 0x04004984 RID: 18820
		MEVP_TanHalfFieldOfView,
		// Token: 0x04004985 RID: 18821
		MEVP_ViewSize,
		// Token: 0x04004986 RID: 18822
		MEVP_WorldSpaceViewPosition,
		// Token: 0x04004987 RID: 18823
		MEVP_WorldSpaceCameraPosition,
		// Token: 0x04004988 RID: 18824
		MEVP_ViewportOffset,
		// Token: 0x04004989 RID: 18825
		MEVP_TemporalSampleCount,
		// Token: 0x0400498A RID: 18826
		MEVP_TemporalSampleIndex,
		// Token: 0x0400498B RID: 18827
		MEVP_TemporalSampleOffset,
		// Token: 0x0400498C RID: 18828
		MEVP_RuntimeVirtualTextureOutputLevel,
		// Token: 0x0400498D RID: 18829
		MEVP_RuntimeVirtualTextureOutputDerivative,
		// Token: 0x0400498E RID: 18830
		MEVP_PreExposure,
		// Token: 0x0400498F RID: 18831
		MEVP_RuntimeVirtualTextureMaxLevel,
		// Token: 0x04004990 RID: 18832
		MEVP_KuroLetterboxUVMinMax,
		// Token: 0x04004991 RID: 18833
		MEVP_MAX
	}
}
