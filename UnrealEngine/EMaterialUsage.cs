using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC3 RID: 2755
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialUsage")]
	public enum EMaterialUsage
	{
		// Token: 0x04004A30 RID: 18992
		MATUSAGE_SkeletalMesh,
		// Token: 0x04004A31 RID: 18993
		MATUSAGE_BakedBoneMesh,
		// Token: 0x04004A32 RID: 18994
		MATUSAGE_ExpandedTexcoordsSkeletalMesh,
		// Token: 0x04004A33 RID: 18995
		MATUSAGE_ParticleSprites,
		// Token: 0x04004A34 RID: 18996
		MATUSAGE_BeamTrails,
		// Token: 0x04004A35 RID: 18997
		MATUSAGE_MeshParticles,
		// Token: 0x04004A36 RID: 18998
		MATUSAGE_StaticLighting,
		// Token: 0x04004A37 RID: 18999
		MATUSAGE_MorphTargets,
		// Token: 0x04004A38 RID: 19000
		MATUSAGE_SplineMesh,
		// Token: 0x04004A39 RID: 19001
		MATUSAGE_InstancedStaticMeshes,
		// Token: 0x04004A3A RID: 19002
		MATUSAGE_GeometryCollections,
		// Token: 0x04004A3B RID: 19003
		MATUSAGE_Clothing,
		// Token: 0x04004A3C RID: 19004
		MATUSAGE_NiagaraSprites,
		// Token: 0x04004A3D RID: 19005
		MATUSAGE_NiagaraRibbons,
		// Token: 0x04004A3E RID: 19006
		MATUSAGE_NiagaraMeshParticles,
		// Token: 0x04004A3F RID: 19007
		MATUSAGE_GeometryCache,
		// Token: 0x04004A40 RID: 19008
		MATUSAGE_Water,
		// Token: 0x04004A41 RID: 19009
		MATUSAGE_HairStrands,
		// Token: 0x04004A42 RID: 19010
		MATUSAGE_LidarPointCloud,
		// Token: 0x04004A43 RID: 19011
		MATUSAGE_VirtualHeightfieldMesh,
		// Token: 0x04004A44 RID: 19012
		MATUSAGE_MarchingCubes,
		// Token: 0x04004A45 RID: 19013
		MATUSAGE_Nanite,
		// Token: 0x04004A46 RID: 19014
		MATUSAGE_VolumetricCloud,
		// Token: 0x04004A47 RID: 19015
		MATUSAGE_HeterogeneousVolumes,
		// Token: 0x04004A48 RID: 19016
		MATUSAGE_TranslucentPreDepth,
		// Token: 0x04004A49 RID: 19017
		MATUSAGE_DataDistortion,
		// Token: 0x04004A4A RID: 19018
		MATUSAGE_Outline,
		// Token: 0x04004A4B RID: 19019
		MATUSAGE_StencilOnlyWrite,
		// Token: 0x04004A4C RID: 19020
		MATUSAGE_FaceShadowMesh,
		// Token: 0x04004A4D RID: 19021
		MATUSAGE_Empty,
		// Token: 0x04004A4E RID: 19022
		MATUSAGE_HLODVertexCompression,
		// Token: 0x04004A4F RID: 19023
		MATUSAGE_Transvoxel,
		// Token: 0x04004A50 RID: 19024
		MATUSAGE_MAX
	}
}
