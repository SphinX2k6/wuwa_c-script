using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB1 RID: 2993
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EViewModeIndex")]
	public enum EViewModeIndex
	{
		// Token: 0x04005257 RID: 21079
		VMI_BrushWireframe,
		// Token: 0x04005258 RID: 21080
		VMI_Wireframe,
		// Token: 0x04005259 RID: 21081
		VMI_Unlit,
		// Token: 0x0400525A RID: 21082
		VMI_Lit,
		// Token: 0x0400525B RID: 21083
		VMI_Lit_DetailLighting,
		// Token: 0x0400525C RID: 21084
		VMI_LightingOnly,
		// Token: 0x0400525D RID: 21085
		VMI_LightComplexity,
		// Token: 0x0400525E RID: 21086
		VMI_ShaderComplexity = 8,
		// Token: 0x0400525F RID: 21087
		VMI_LightmapDensity,
		// Token: 0x04005260 RID: 21088
		VMI_LitLightmapDensity,
		// Token: 0x04005261 RID: 21089
		VMI_ReflectionOverride,
		// Token: 0x04005262 RID: 21090
		VMI_VisualizeBuffer,
		// Token: 0x04005263 RID: 21091
		VMI_StationaryLightOverlap = 14,
		// Token: 0x04005264 RID: 21092
		VMI_CollisionPawn,
		// Token: 0x04005265 RID: 21093
		VMI_CollisionVisibility,
		// Token: 0x04005266 RID: 21094
		VMI_LODColoration = 18,
		// Token: 0x04005267 RID: 21095
		VMI_QuadOverdraw,
		// Token: 0x04005268 RID: 21096
		VMI_PrimitiveDistanceAccuracy,
		// Token: 0x04005269 RID: 21097
		VMI_MeshUVDensityAccuracy,
		// Token: 0x0400526A RID: 21098
		VMI_ShaderComplexityWithQuadOverdraw,
		// Token: 0x0400526B RID: 21099
		VMI_HLODColoration,
		// Token: 0x0400526C RID: 21100
		VMI_GroupLODColoration,
		// Token: 0x0400526D RID: 21101
		VMI_MaterialTextureScaleAccuracy,
		// Token: 0x0400526E RID: 21102
		VMI_RequiredTextureResolution,
		// Token: 0x0400526F RID: 21103
		VMI_PathTracing,
		// Token: 0x04005270 RID: 21104
		VMI_RayTracingDebug,
		// Token: 0x04005271 RID: 21105
		VMI_Generate2DMapMode,
		// Token: 0x04005272 RID: 21106
		VMI_TextureUsage,
		// Token: 0x04005273 RID: 21107
		VMI_CollisionNormal,
		// Token: 0x04005274 RID: 21108
		VMI_TexelDensity,
		// Token: 0x04005275 RID: 21109
		VMI_VertexColor,
		// Token: 0x04005276 RID: 21110
		VMI_Overdraw,
		// Token: 0x04005277 RID: 21111
		VMI_SequenceDebug,
		// Token: 0x04005278 RID: 21112
		VMI_BackFaceRendering = 38,
		// Token: 0x04005279 RID: 21113
		VMI_PixelOverdraw,
		// Token: 0x0400527A RID: 21114
		VMI_MultiPlatformRendering,
		// Token: 0x0400527B RID: 21115
		VMI_MobilityRendering,
		// Token: 0x0400527C RID: 21116
		VMI_QualityTieringColoration,
		// Token: 0x0400527D RID: 21117
		VMI_Max,
		// Token: 0x0400527E RID: 21118
		VMI_Unknown = 255,
		// Token: 0x0400527F RID: 21119
		VMI_MAX
	}
}
