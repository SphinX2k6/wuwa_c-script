using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA0 RID: 3744
	[UnrealObjectPath("/Script/Engine.MeshBuildSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMeshBuildSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C9F7 RID: 51703 RVA: 0x00126066 File Offset: 0x00124266
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBuildSettings._ScriptStructPtr != 0) ? FMeshBuildSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshBuildSettings", ref FMeshBuildSettings._ScriptStructPtr);
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x0012608A File Offset: 0x0012428A
		// (set) Token: 0x0600C9F9 RID: 51705 RVA: 0x001260A3 File Offset: 0x001242A3
		public unsafe bool bHasKuroUVUnwrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) & FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroUVUnwrap) & ~FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap) | (value ? FMeshBuildSettings.__PropertyMask_bHasKuroUVUnwrap : 0));
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x001260D3 File Offset: 0x001242D3
		// (set) Token: 0x0600C9FB RID: 51707 RVA: 0x001260EC File Offset: 0x001242EC
		public unsafe bool bHasKuroInsideCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) & FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bHasKuroInsideCulling) & ~FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling) | (value ? FMeshBuildSettings.__PropertyMask_bHasKuroInsideCulling : 0));
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600C9FC RID: 51708 RVA: 0x0012611C File Offset: 0x0012431C
		// (set) Token: 0x0600C9FD RID: 51709 RVA: 0x00126135 File Offset: 0x00124335
		public unsafe bool bKuroKeepRawMeshPrimIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) & FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bKuroKeepRawMeshPrimIndex) & ~FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex) | (value ? FMeshBuildSettings.__PropertyMask_bKuroKeepRawMeshPrimIndex : 0));
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600C9FE RID: 51710 RVA: 0x00126165 File Offset: 0x00124365
		// (set) Token: 0x0600C9FF RID: 51711 RVA: 0x0012617E File Offset: 0x0012437E
		public unsafe bool bUseMikkTSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & FMeshBuildSettings.__PropertyMask_bUseMikkTSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseMikkTSpace) & ~FMeshBuildSettings.__PropertyMask_bUseMikkTSpace) | (value ? FMeshBuildSettings.__PropertyMask_bUseMikkTSpace : 0));
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600CA00 RID: 51712 RVA: 0x001261AE File Offset: 0x001243AE
		// (set) Token: 0x0600CA01 RID: 51713 RVA: 0x001261C7 File Offset: 0x001243C7
		public unsafe bool bRecomputeNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & FMeshBuildSettings.__PropertyMask_bRecomputeNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeNormals) & ~FMeshBuildSettings.__PropertyMask_bRecomputeNormals) | (value ? FMeshBuildSettings.__PropertyMask_bRecomputeNormals : 0));
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600CA02 RID: 51714 RVA: 0x001261F7 File Offset: 0x001243F7
		// (set) Token: 0x0600CA03 RID: 51715 RVA: 0x00126210 File Offset: 0x00124410
		public unsafe bool bRecomputeTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & FMeshBuildSettings.__PropertyMask_bRecomputeTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRecomputeTangents) & ~FMeshBuildSettings.__PropertyMask_bRecomputeTangents) | (value ? FMeshBuildSettings.__PropertyMask_bRecomputeTangents : 0));
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600CA04 RID: 51716 RVA: 0x00126240 File Offset: 0x00124440
		// (set) Token: 0x0600CA05 RID: 51717 RVA: 0x00126259 File Offset: 0x00124459
		public unsafe bool bComputeWeightedNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bComputeWeightedNormals) & ~FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals) | (value ? FMeshBuildSettings.__PropertyMask_bComputeWeightedNormals : 0));
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600CA06 RID: 51718 RVA: 0x00126289 File Offset: 0x00124489
		// (set) Token: 0x0600CA07 RID: 51719 RVA: 0x001262A2 File Offset: 0x001244A2
		public unsafe bool bRemoveDegenerates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & FMeshBuildSettings.__PropertyMask_bRemoveDegenerates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bRemoveDegenerates) & ~FMeshBuildSettings.__PropertyMask_bRemoveDegenerates) | (value ? FMeshBuildSettings.__PropertyMask_bRemoveDegenerates : 0));
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600CA08 RID: 51720 RVA: 0x001262D2 File Offset: 0x001244D2
		// (set) Token: 0x0600CA09 RID: 51721 RVA: 0x001262EB File Offset: 0x001244EB
		public unsafe bool bBuildAdjacencyBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildAdjacencyBuffer) & ~FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer) | (value ? FMeshBuildSettings.__PropertyMask_bBuildAdjacencyBuffer : 0));
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600CA0A RID: 51722 RVA: 0x0012631B File Offset: 0x0012451B
		// (set) Token: 0x0600CA0B RID: 51723 RVA: 0x00126334 File Offset: 0x00124534
		public unsafe bool bBuildReversedIndexBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) & FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bBuildReversedIndexBuffer) & ~FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer) | (value ? FMeshBuildSettings.__PropertyMask_bBuildReversedIndexBuffer : 0));
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600CA0C RID: 51724 RVA: 0x00126364 File Offset: 0x00124564
		// (set) Token: 0x0600CA0D RID: 51725 RVA: 0x0012637D File Offset: 0x0012457D
		public unsafe bool bUseHighPrecisionTangentBasis
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseHighPrecisionTangentBasis) & ~FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis) | (value ? FMeshBuildSettings.__PropertyMask_bUseHighPrecisionTangentBasis : 0));
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x001263AD File Offset: 0x001245AD
		// (set) Token: 0x0600CA0F RID: 51727 RVA: 0x001263C6 File Offset: 0x001245C6
		public unsafe bool bUseFullPrecisionUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseFullPrecisionUVs) & ~FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs) | (value ? FMeshBuildSettings.__PropertyMask_bUseFullPrecisionUVs : 0));
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600CA10 RID: 51728 RVA: 0x001263F6 File Offset: 0x001245F6
		// (set) Token: 0x0600CA11 RID: 51729 RVA: 0x0012640F File Offset: 0x0012460F
		public unsafe bool bGenerateLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) & FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateLightmapUVs) & ~FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs) | (value ? FMeshBuildSettings.__PropertyMask_bGenerateLightmapUVs : 0));
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600CA12 RID: 51730 RVA: 0x0012643F File Offset: 0x0012463F
		// (set) Token: 0x0600CA13 RID: 51731 RVA: 0x00126458 File Offset: 0x00124658
		public unsafe bool bUseKuroUVUnwrap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) & FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bUseKuroUVUnwrap) & ~FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap) | (value ? FMeshBuildSettings.__PropertyMask_bUseKuroUVUnwrap : 0));
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x00126488 File Offset: 0x00124688
		// (set) Token: 0x0600CA15 RID: 51733 RVA: 0x001264A1 File Offset: 0x001246A1
		public unsafe bool bGenerateDistanceFieldAsIfTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bGenerateDistanceFieldAsIfTwoSided) & ~FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided) | (value ? FMeshBuildSettings.__PropertyMask_bGenerateDistanceFieldAsIfTwoSided : 0));
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x001264D1 File Offset: 0x001246D1
		// (set) Token: 0x0600CA17 RID: 51735 RVA: 0x001264EA File Offset: 0x001246EA
		public unsafe bool bSupportFaceRemap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) & FMeshBuildSettings.__PropertyMask_bSupportFaceRemap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) = ((*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_bSupportFaceRemap) & ~FMeshBuildSettings.__PropertyMask_bSupportFaceRemap) | (value ? FMeshBuildSettings.__PropertyMask_bSupportFaceRemap : 0));
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x0012651A File Offset: 0x0012471A
		// (set) Token: 0x0600CA19 RID: 51737 RVA: 0x0012652A File Offset: 0x0012472A
		public unsafe int MinLightmapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_MinLightmapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_MinLightmapResolution) = value;
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x0012653B File Offset: 0x0012473B
		// (set) Token: 0x0600CA1B RID: 51739 RVA: 0x0012654B File Offset: 0x0012474B
		public unsafe int SrcLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_SrcLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_SrcLightmapIndex) = value;
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x0012655C File Offset: 0x0012475C
		// (set) Token: 0x0600CA1D RID: 51741 RVA: 0x0012656C File Offset: 0x0012476C
		public unsafe int DstLightmapIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DstLightmapIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DstLightmapIndex) = value;
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600CA1E RID: 51742 RVA: 0x0012657D File Offset: 0x0012477D
		// (set) Token: 0x0600CA1F RID: 51743 RVA: 0x0012658D File Offset: 0x0012478D
		public unsafe float BuildScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale_DEPRECATED) = value;
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600CA20 RID: 51744 RVA: 0x0012659E File Offset: 0x0012479E
		// (set) Token: 0x0600CA21 RID: 51745 RVA: 0x001265B2 File Offset: 0x001247B2
		public unsafe FVector BuildScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_BuildScale3D) = value;
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600CA22 RID: 51746 RVA: 0x001265C7 File Offset: 0x001247C7
		// (set) Token: 0x0600CA23 RID: 51747 RVA: 0x001265D7 File Offset: 0x001247D7
		public unsafe float DistanceFieldResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DistanceFieldResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBuildSettings.__PropertyOffset_DistanceFieldResolutionScale) = value;
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0600CA24 RID: 51748 RVA: 0x001265E8 File Offset: 0x001247E8
		// (set) Token: 0x0600CA25 RID: 51749 RVA: 0x001265FC File Offset: 0x001247FC
		[Nullable(2)]
		public unsafe UStaticMesh DistanceFieldReplacementMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FMeshBuildSettings.__PropertyOffset_DistanceFieldReplacementMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMeshBuildSettings.__PropertyOffset_DistanceFieldReplacementMesh, value);
			}
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x00126611 File Offset: 0x00124811
		public FMeshBuildSettings()
		{
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x0012661C File Offset: 0x0012481C
		[NullableContext(1)]
		public FMeshBuildSettings(bool bHasKuroUVUnwrap, bool bHasKuroInsideCulling, bool bKuroKeepRawMeshPrimIndex, bool bUseMikkTSpace, bool bRecomputeNormals, bool bRecomputeTangents, bool bComputeWeightedNormals, bool bRemoveDegenerates, bool bBuildAdjacencyBuffer, bool bBuildReversedIndexBuffer, bool bUseHighPrecisionTangentBasis, bool bUseFullPrecisionUVs, bool bGenerateLightmapUVs, bool bUseKuroUVUnwrap, bool bGenerateDistanceFieldAsIfTwoSided, bool bSupportFaceRemap, int MinLightmapResolution, int SrcLightmapIndex, int DstLightmapIndex, float BuildScale_DEPRECATED, FVector BuildScale3D, float DistanceFieldResolutionScale, float DistanceFieldBias_DEPRECATED, UStaticMesh DistanceFieldReplacementMesh)
		{
			this.bHasKuroUVUnwrap = bHasKuroUVUnwrap;
			this.bHasKuroInsideCulling = bHasKuroInsideCulling;
			this.bKuroKeepRawMeshPrimIndex = bKuroKeepRawMeshPrimIndex;
			this.bUseMikkTSpace = bUseMikkTSpace;
			this.bRecomputeNormals = bRecomputeNormals;
			this.bRecomputeTangents = bRecomputeTangents;
			this.bComputeWeightedNormals = bComputeWeightedNormals;
			this.bRemoveDegenerates = bRemoveDegenerates;
			this.bBuildAdjacencyBuffer = bBuildAdjacencyBuffer;
			this.bBuildReversedIndexBuffer = bBuildReversedIndexBuffer;
			this.bUseHighPrecisionTangentBasis = bUseHighPrecisionTangentBasis;
			this.bUseFullPrecisionUVs = bUseFullPrecisionUVs;
			this.bGenerateLightmapUVs = bGenerateLightmapUVs;
			this.bUseKuroUVUnwrap = bUseKuroUVUnwrap;
			this.bGenerateDistanceFieldAsIfTwoSided = bGenerateDistanceFieldAsIfTwoSided;
			this.bSupportFaceRemap = bSupportFaceRemap;
			this.MinLightmapResolution = MinLightmapResolution;
			this.SrcLightmapIndex = SrcLightmapIndex;
			this.DstLightmapIndex = DstLightmapIndex;
			this.BuildScale_DEPRECATED = BuildScale_DEPRECATED;
			this.BuildScale3D = BuildScale3D;
			this.DistanceFieldResolutionScale = DistanceFieldResolutionScale;
			this.DistanceFieldReplacementMesh = DistanceFieldReplacementMesh;
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x001266E4 File Offset: 0x001248E4
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBuildSettings.StaticStruct();
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x001266F0 File Offset: 0x001248F0
		[NullableContext(2)]
		public FMeshBuildSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x001266FA File Offset: 0x001248FA
		public FMeshBuildSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x00126705 File Offset: 0x00124905
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBuildSettings(Pointer, false, true);
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x0012670F File Offset: 0x0012490F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBuildSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006CB3 RID: 27827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MeshBuildSettings";

		// Token: 0x04006CB4 RID: 27828
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006CB5 RID: 27829
		internal static int __PropertyOffset_bHasKuroUVUnwrap;

		// Token: 0x04006CB6 RID: 27830
		internal static byte __PropertyMask_bHasKuroUVUnwrap;

		// Token: 0x04006CB7 RID: 27831
		internal static int __PropertyOffset_bHasKuroInsideCulling;

		// Token: 0x04006CB8 RID: 27832
		internal static byte __PropertyMask_bHasKuroInsideCulling;

		// Token: 0x04006CB9 RID: 27833
		internal static int __PropertyOffset_bKuroKeepRawMeshPrimIndex;

		// Token: 0x04006CBA RID: 27834
		internal static byte __PropertyMask_bKuroKeepRawMeshPrimIndex;

		// Token: 0x04006CBB RID: 27835
		internal static int __PropertyOffset_bUseMikkTSpace;

		// Token: 0x04006CBC RID: 27836
		internal static byte __PropertyMask_bUseMikkTSpace;

		// Token: 0x04006CBD RID: 27837
		internal static int __PropertyOffset_bRecomputeNormals;

		// Token: 0x04006CBE RID: 27838
		internal static byte __PropertyMask_bRecomputeNormals;

		// Token: 0x04006CBF RID: 27839
		internal static int __PropertyOffset_bRecomputeTangents;

		// Token: 0x04006CC0 RID: 27840
		internal static byte __PropertyMask_bRecomputeTangents;

		// Token: 0x04006CC1 RID: 27841
		internal static int __PropertyOffset_bComputeWeightedNormals;

		// Token: 0x04006CC2 RID: 27842
		internal static byte __PropertyMask_bComputeWeightedNormals;

		// Token: 0x04006CC3 RID: 27843
		internal static int __PropertyOffset_bRemoveDegenerates;

		// Token: 0x04006CC4 RID: 27844
		internal static byte __PropertyMask_bRemoveDegenerates;

		// Token: 0x04006CC5 RID: 27845
		internal static int __PropertyOffset_bBuildAdjacencyBuffer;

		// Token: 0x04006CC6 RID: 27846
		internal static byte __PropertyMask_bBuildAdjacencyBuffer;

		// Token: 0x04006CC7 RID: 27847
		internal static int __PropertyOffset_bBuildReversedIndexBuffer;

		// Token: 0x04006CC8 RID: 27848
		internal static byte __PropertyMask_bBuildReversedIndexBuffer;

		// Token: 0x04006CC9 RID: 27849
		internal static int __PropertyOffset_bUseHighPrecisionTangentBasis;

		// Token: 0x04006CCA RID: 27850
		internal static byte __PropertyMask_bUseHighPrecisionTangentBasis;

		// Token: 0x04006CCB RID: 27851
		internal static int __PropertyOffset_bUseFullPrecisionUVs;

		// Token: 0x04006CCC RID: 27852
		internal static byte __PropertyMask_bUseFullPrecisionUVs;

		// Token: 0x04006CCD RID: 27853
		internal static int __PropertyOffset_bGenerateLightmapUVs;

		// Token: 0x04006CCE RID: 27854
		internal static byte __PropertyMask_bGenerateLightmapUVs;

		// Token: 0x04006CCF RID: 27855
		internal static int __PropertyOffset_bUseKuroUVUnwrap;

		// Token: 0x04006CD0 RID: 27856
		internal static byte __PropertyMask_bUseKuroUVUnwrap;

		// Token: 0x04006CD1 RID: 27857
		internal static int __PropertyOffset_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x04006CD2 RID: 27858
		internal static byte __PropertyMask_bGenerateDistanceFieldAsIfTwoSided;

		// Token: 0x04006CD3 RID: 27859
		internal static int __PropertyOffset_bSupportFaceRemap;

		// Token: 0x04006CD4 RID: 27860
		internal static byte __PropertyMask_bSupportFaceRemap;

		// Token: 0x04006CD5 RID: 27861
		internal static int __PropertyOffset_MinLightmapResolution;

		// Token: 0x04006CD6 RID: 27862
		internal static int __PropertyOffset_SrcLightmapIndex;

		// Token: 0x04006CD7 RID: 27863
		internal static int __PropertyOffset_DstLightmapIndex;

		// Token: 0x04006CD8 RID: 27864
		internal static int __PropertyOffset_BuildScale_DEPRECATED;

		// Token: 0x04006CD9 RID: 27865
		internal static int __PropertyOffset_BuildScale3D;

		// Token: 0x04006CDA RID: 27866
		internal static int __PropertyOffset_DistanceFieldResolutionScale;

		// Token: 0x04006CDB RID: 27867
		internal static int __PropertyOffset_DistanceFieldReplacementMesh;
	}
}
