using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA5 RID: 3749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshMergingSettings")]
	[UnrealStructLayout(176, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FMeshMergingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CA72 RID: 51826 RVA: 0x00126C6A File Offset: 0x00124E6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshMergingSettings._ScriptStructPtr != 0) ? FMeshMergingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshMergingSettings", ref FMeshMergingSettings._ScriptStructPtr);
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x00126C8E File Offset: 0x00124E8E
		// (set) Token: 0x0600CA74 RID: 51828 RVA: 0x00126C9E File Offset: 0x00124E9E
		public unsafe int TargetLightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_TargetLightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_TargetLightMapResolution) = value;
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600CA75 RID: 51829 RVA: 0x00126CB0 File Offset: 0x00124EB0
		// (set) Token: 0x0600CA76 RID: 51830 RVA: 0x00126CF4 File Offset: 0x00124EF4
		public TFixedArray<EUVOutput> OutputUVs
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<EUVOutput> result;
				if ((result = this._OutputUVs) == null)
				{
					result = (this._OutputUVs = new TFixedArray<EUVOutput>(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_OutputUVs, 8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutputUVs.CopyAssign(value);
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600CA77 RID: 51831 RVA: 0x00126D04 File Offset: 0x00124F04
		// (set) Token: 0x0600CA78 RID: 51832 RVA: 0x00126D47 File Offset: 0x00124F47
		public FMaterialProxySettings MaterialSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialProxySettings result;
				if ((result = this._MaterialSettings) == null)
				{
					result = (this._MaterialSettings = new FMaterialProxySettings(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_MaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialProxySettings.StaticStruct(), base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_MaterialSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600CA79 RID: 51833 RVA: 0x00126D68 File Offset: 0x00124F68
		// (set) Token: 0x0600CA7A RID: 51834 RVA: 0x00126D78 File Offset: 0x00124F78
		public unsafe int GutterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_GutterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_GutterSize) = value;
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600CA7B RID: 51835 RVA: 0x00126D89 File Offset: 0x00124F89
		// (set) Token: 0x0600CA7C RID: 51836 RVA: 0x00126D99 File Offset: 0x00124F99
		public unsafe int SpecificLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_SpecificLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_SpecificLOD) = value;
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x00126DAA File Offset: 0x00124FAA
		// (set) Token: 0x0600CA7E RID: 51838 RVA: 0x00126DBA File Offset: 0x00124FBA
		public unsafe EMeshLODSelectionType LODSelectionType
		{
			get
			{
				return (EMeshLODSelectionType)(*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_LODSelectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_LODSelectionType) = (byte)value;
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600CA7F RID: 51839 RVA: 0x00126DCB File Offset: 0x00124FCB
		// (set) Token: 0x0600CA80 RID: 51840 RVA: 0x00126DE4 File Offset: 0x00124FE4
		public unsafe bool bGenerateLightMapUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bGenerateLightMapUV) & FMeshMergingSettings.__PropertyMask_bGenerateLightMapUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bGenerateLightMapUV) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bGenerateLightMapUV) & ~FMeshMergingSettings.__PropertyMask_bGenerateLightMapUV) | (value ? FMeshMergingSettings.__PropertyMask_bGenerateLightMapUV : 0));
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x00126E14 File Offset: 0x00125014
		// (set) Token: 0x0600CA82 RID: 51842 RVA: 0x00126E2D File Offset: 0x0012502D
		public unsafe bool bComputedLightMapResolution
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bComputedLightMapResolution) & FMeshMergingSettings.__PropertyMask_bComputedLightMapResolution) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bComputedLightMapResolution) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bComputedLightMapResolution) & ~FMeshMergingSettings.__PropertyMask_bComputedLightMapResolution) | (value ? FMeshMergingSettings.__PropertyMask_bComputedLightMapResolution : 0));
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600CA83 RID: 51843 RVA: 0x00126E5D File Offset: 0x0012505D
		// (set) Token: 0x0600CA84 RID: 51844 RVA: 0x00126E76 File Offset: 0x00125076
		public unsafe bool bPivotPointAtZero
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bPivotPointAtZero) & FMeshMergingSettings.__PropertyMask_bPivotPointAtZero) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bPivotPointAtZero) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bPivotPointAtZero) & ~FMeshMergingSettings.__PropertyMask_bPivotPointAtZero) | (value ? FMeshMergingSettings.__PropertyMask_bPivotPointAtZero : 0));
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x00126EA6 File Offset: 0x001250A6
		// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x00126EBF File Offset: 0x001250BF
		public unsafe bool bMergePhysicsData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergePhysicsData) & FMeshMergingSettings.__PropertyMask_bMergePhysicsData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergePhysicsData) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergePhysicsData) & ~FMeshMergingSettings.__PropertyMask_bMergePhysicsData) | (value ? FMeshMergingSettings.__PropertyMask_bMergePhysicsData : 0));
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600CA87 RID: 51847 RVA: 0x00126EEF File Offset: 0x001250EF
		// (set) Token: 0x0600CA88 RID: 51848 RVA: 0x00126F08 File Offset: 0x00125108
		public unsafe bool bMergeMaterials
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeMaterials) & FMeshMergingSettings.__PropertyMask_bMergeMaterials) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeMaterials) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeMaterials) & ~FMeshMergingSettings.__PropertyMask_bMergeMaterials) | (value ? FMeshMergingSettings.__PropertyMask_bMergeMaterials : 0));
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x00126F38 File Offset: 0x00125138
		// (set) Token: 0x0600CA8A RID: 51850 RVA: 0x00126F51 File Offset: 0x00125151
		public unsafe bool bCreateMergedMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bCreateMergedMaterial) & FMeshMergingSettings.__PropertyMask_bCreateMergedMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bCreateMergedMaterial) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bCreateMergedMaterial) & ~FMeshMergingSettings.__PropertyMask_bCreateMergedMaterial) | (value ? FMeshMergingSettings.__PropertyMask_bCreateMergedMaterial : 0));
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600CA8B RID: 51851 RVA: 0x00126F81 File Offset: 0x00125181
		// (set) Token: 0x0600CA8C RID: 51852 RVA: 0x00126F9A File Offset: 0x0012519A
		public unsafe bool bBakeVertexDataToMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bBakeVertexDataToMesh) & FMeshMergingSettings.__PropertyMask_bBakeVertexDataToMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bBakeVertexDataToMesh) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bBakeVertexDataToMesh) & ~FMeshMergingSettings.__PropertyMask_bBakeVertexDataToMesh) | (value ? FMeshMergingSettings.__PropertyMask_bBakeVertexDataToMesh : 0));
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x00126FCA File Offset: 0x001251CA
		// (set) Token: 0x0600CA8E RID: 51854 RVA: 0x00126FE3 File Offset: 0x001251E3
		public unsafe bool bUseVertexDataForBakingMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseVertexDataForBakingMaterial) & FMeshMergingSettings.__PropertyMask_bUseVertexDataForBakingMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseVertexDataForBakingMaterial) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseVertexDataForBakingMaterial) & ~FMeshMergingSettings.__PropertyMask_bUseVertexDataForBakingMaterial) | (value ? FMeshMergingSettings.__PropertyMask_bUseVertexDataForBakingMaterial : 0));
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600CA8F RID: 51855 RVA: 0x00127013 File Offset: 0x00125213
		// (set) Token: 0x0600CA90 RID: 51856 RVA: 0x0012702C File Offset: 0x0012522C
		public unsafe bool bUseTextureBinning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseTextureBinning) & FMeshMergingSettings.__PropertyMask_bUseTextureBinning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseTextureBinning) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseTextureBinning) & ~FMeshMergingSettings.__PropertyMask_bUseTextureBinning) | (value ? FMeshMergingSettings.__PropertyMask_bUseTextureBinning : 0));
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x0012705C File Offset: 0x0012525C
		// (set) Token: 0x0600CA92 RID: 51858 RVA: 0x00127075 File Offset: 0x00125275
		public unsafe bool bReuseMeshLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bReuseMeshLightmapUVs) & FMeshMergingSettings.__PropertyMask_bReuseMeshLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bReuseMeshLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bReuseMeshLightmapUVs) & ~FMeshMergingSettings.__PropertyMask_bReuseMeshLightmapUVs) | (value ? FMeshMergingSettings.__PropertyMask_bReuseMeshLightmapUVs : 0));
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x001270A5 File Offset: 0x001252A5
		// (set) Token: 0x0600CA94 RID: 51860 RVA: 0x001270BE File Offset: 0x001252BE
		public unsafe bool bMergeEquivalentMaterials
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeEquivalentMaterials) & FMeshMergingSettings.__PropertyMask_bMergeEquivalentMaterials) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeEquivalentMaterials) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bMergeEquivalentMaterials) & ~FMeshMergingSettings.__PropertyMask_bMergeEquivalentMaterials) | (value ? FMeshMergingSettings.__PropertyMask_bMergeEquivalentMaterials : 0));
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x001270EE File Offset: 0x001252EE
		// (set) Token: 0x0600CA96 RID: 51862 RVA: 0x00127107 File Offset: 0x00125307
		public unsafe bool bUseLandscapeCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseLandscapeCulling) & FMeshMergingSettings.__PropertyMask_bUseLandscapeCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseLandscapeCulling) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bUseLandscapeCulling) & ~FMeshMergingSettings.__PropertyMask_bUseLandscapeCulling) | (value ? FMeshMergingSettings.__PropertyMask_bUseLandscapeCulling : 0));
			}
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x00127137 File Offset: 0x00125337
		// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x00127150 File Offset: 0x00125350
		public unsafe bool bIncludeImposters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bIncludeImposters) & FMeshMergingSettings.__PropertyMask_bIncludeImposters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bIncludeImposters) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bIncludeImposters) & ~FMeshMergingSettings.__PropertyMask_bIncludeImposters) | (value ? FMeshMergingSettings.__PropertyMask_bIncludeImposters : 0));
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x00127180 File Offset: 0x00125380
		// (set) Token: 0x0600CA9A RID: 51866 RVA: 0x00127199 File Offset: 0x00125399
		public unsafe bool bAllowDistanceField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bAllowDistanceField) & FMeshMergingSettings.__PropertyMask_bAllowDistanceField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bAllowDistanceField) = ((*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_bAllowDistanceField) & ~FMeshMergingSettings.__PropertyMask_bAllowDistanceField) | (value ? FMeshMergingSettings.__PropertyMask_bAllowDistanceField : 0));
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600CA9B RID: 51867 RVA: 0x001271C9 File Offset: 0x001253C9
		// (set) Token: 0x0600CA9C RID: 51868 RVA: 0x001271D9 File Offset: 0x001253D9
		public unsafe EHLODBakeDiffuseToVertexColorMode BakeDiffuseToVertexColorMode
		{
			get
			{
				return (EHLODBakeDiffuseToVertexColorMode)(*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_BakeDiffuseToVertexColorMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshMergingSettings.__PropertyOffset_BakeDiffuseToVertexColorMode) = (byte)value;
			}
		}

		// Token: 0x0600CA9D RID: 51869 RVA: 0x001271EA File Offset: 0x001253EA
		public FMeshMergingSettings()
		{
		}

		// Token: 0x0600CA9E RID: 51870 RVA: 0x001271F4 File Offset: 0x001253F4
		public FMeshMergingSettings(int TargetLightMapResolution, TFixedArray<EUVOutput> OutputUVs, FMaterialProxySettings MaterialSettings, int GutterSize, int SpecificLOD, EMeshLODSelectionType LODSelectionType, bool bGenerateLightMapUV, bool bComputedLightMapResolution, bool bPivotPointAtZero, bool bMergePhysicsData, bool bMergeMaterials, bool bCreateMergedMaterial, bool bBakeVertexDataToMesh, bool bUseVertexDataForBakingMaterial, bool bUseTextureBinning, bool bReuseMeshLightmapUVs, bool bMergeEquivalentMaterials, bool bUseLandscapeCulling, bool bIncludeImposters, bool bAllowDistanceField, EHLODBakeDiffuseToVertexColorMode BakeDiffuseToVertexColorMode, bool bImportVertexColors_DEPRECATED, bool bCalculateCorrectLODModel_DEPRECATED, bool bExportNormalMap_DEPRECATED, bool bExportMetallicMap_DEPRECATED, bool bExportRoughnessMap_DEPRECATED, bool bExportSpecularMap_DEPRECATED, int MergedMaterialAtlasResolution_DEPRECATED, int ExportSpecificLOD_DEPRECATED)
		{
			this.TargetLightMapResolution = TargetLightMapResolution;
			this.OutputUVs = OutputUVs;
			this.MaterialSettings = MaterialSettings;
			this.GutterSize = GutterSize;
			this.SpecificLOD = SpecificLOD;
			this.LODSelectionType = LODSelectionType;
			this.bGenerateLightMapUV = bGenerateLightMapUV;
			this.bComputedLightMapResolution = bComputedLightMapResolution;
			this.bPivotPointAtZero = bPivotPointAtZero;
			this.bMergePhysicsData = bMergePhysicsData;
			this.bMergeMaterials = bMergeMaterials;
			this.bCreateMergedMaterial = bCreateMergedMaterial;
			this.bBakeVertexDataToMesh = bBakeVertexDataToMesh;
			this.bUseVertexDataForBakingMaterial = bUseVertexDataForBakingMaterial;
			this.bUseTextureBinning = bUseTextureBinning;
			this.bReuseMeshLightmapUVs = bReuseMeshLightmapUVs;
			this.bMergeEquivalentMaterials = bMergeEquivalentMaterials;
			this.bUseLandscapeCulling = bUseLandscapeCulling;
			this.bIncludeImposters = bIncludeImposters;
			this.bAllowDistanceField = bAllowDistanceField;
			this.BakeDiffuseToVertexColorMode = BakeDiffuseToVertexColorMode;
		}

		// Token: 0x0600CA9F RID: 51871 RVA: 0x001272AC File Offset: 0x001254AC
		protected override IntPtr GetUStructPtr()
		{
			return FMeshMergingSettings.StaticStruct();
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x001272B8 File Offset: 0x001254B8
		[NullableContext(2)]
		public FMeshMergingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x001272C2 File Offset: 0x001254C2
		public FMeshMergingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x001272CD File Offset: 0x001254CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshMergingSettings(Pointer, false, true);
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x001272D7 File Offset: 0x001254D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshMergingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006CFA RID: 27898
		public const string __ObjectPath = "/Script/Engine.MeshMergingSettings";

		// Token: 0x04006CFB RID: 27899
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006CFC RID: 27900
		internal static int __PropertyOffset_TargetLightMapResolution;

		// Token: 0x04006CFD RID: 27901
		internal static int __PropertyOffset_OutputUVs;

		// Token: 0x04006CFE RID: 27902
		[Nullable(2)]
		private TFixedArray<EUVOutput> _OutputUVs;

		// Token: 0x04006CFF RID: 27903
		internal static int __PropertyOffset_MaterialSettings;

		// Token: 0x04006D00 RID: 27904
		[Nullable(2)]
		private FMaterialProxySettings _MaterialSettings;

		// Token: 0x04006D01 RID: 27905
		internal static int __PropertyOffset_GutterSize;

		// Token: 0x04006D02 RID: 27906
		internal static int __PropertyOffset_SpecificLOD;

		// Token: 0x04006D03 RID: 27907
		internal static int __PropertyOffset_LODSelectionType;

		// Token: 0x04006D04 RID: 27908
		internal static int __PropertyOffset_bGenerateLightMapUV;

		// Token: 0x04006D05 RID: 27909
		internal static byte __PropertyMask_bGenerateLightMapUV;

		// Token: 0x04006D06 RID: 27910
		internal static int __PropertyOffset_bComputedLightMapResolution;

		// Token: 0x04006D07 RID: 27911
		internal static byte __PropertyMask_bComputedLightMapResolution;

		// Token: 0x04006D08 RID: 27912
		internal static int __PropertyOffset_bPivotPointAtZero;

		// Token: 0x04006D09 RID: 27913
		internal static byte __PropertyMask_bPivotPointAtZero;

		// Token: 0x04006D0A RID: 27914
		internal static int __PropertyOffset_bMergePhysicsData;

		// Token: 0x04006D0B RID: 27915
		internal static byte __PropertyMask_bMergePhysicsData;

		// Token: 0x04006D0C RID: 27916
		internal static int __PropertyOffset_bMergeMaterials;

		// Token: 0x04006D0D RID: 27917
		internal static byte __PropertyMask_bMergeMaterials;

		// Token: 0x04006D0E RID: 27918
		internal static int __PropertyOffset_bCreateMergedMaterial;

		// Token: 0x04006D0F RID: 27919
		internal static byte __PropertyMask_bCreateMergedMaterial;

		// Token: 0x04006D10 RID: 27920
		internal static int __PropertyOffset_bBakeVertexDataToMesh;

		// Token: 0x04006D11 RID: 27921
		internal static byte __PropertyMask_bBakeVertexDataToMesh;

		// Token: 0x04006D12 RID: 27922
		internal static int __PropertyOffset_bUseVertexDataForBakingMaterial;

		// Token: 0x04006D13 RID: 27923
		internal static byte __PropertyMask_bUseVertexDataForBakingMaterial;

		// Token: 0x04006D14 RID: 27924
		internal static int __PropertyOffset_bUseTextureBinning;

		// Token: 0x04006D15 RID: 27925
		internal static byte __PropertyMask_bUseTextureBinning;

		// Token: 0x04006D16 RID: 27926
		internal static int __PropertyOffset_bReuseMeshLightmapUVs;

		// Token: 0x04006D17 RID: 27927
		internal static byte __PropertyMask_bReuseMeshLightmapUVs;

		// Token: 0x04006D18 RID: 27928
		internal static int __PropertyOffset_bMergeEquivalentMaterials;

		// Token: 0x04006D19 RID: 27929
		internal static byte __PropertyMask_bMergeEquivalentMaterials;

		// Token: 0x04006D1A RID: 27930
		internal static int __PropertyOffset_bUseLandscapeCulling;

		// Token: 0x04006D1B RID: 27931
		internal static byte __PropertyMask_bUseLandscapeCulling;

		// Token: 0x04006D1C RID: 27932
		internal static int __PropertyOffset_bIncludeImposters;

		// Token: 0x04006D1D RID: 27933
		internal static byte __PropertyMask_bIncludeImposters;

		// Token: 0x04006D1E RID: 27934
		internal static int __PropertyOffset_bAllowDistanceField;

		// Token: 0x04006D1F RID: 27935
		internal static byte __PropertyMask_bAllowDistanceField;

		// Token: 0x04006D20 RID: 27936
		internal static int __PropertyOffset_BakeDiffuseToVertexColorMode;
	}
}
