using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA6 RID: 3750
	[UnrealObjectPath("/Script/Engine.MeshProxySettings")]
	[UnrealStructLayout(180, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 180)]
	public class FMeshProxySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CAA4 RID: 51876 RVA: 0x001272E0 File Offset: 0x001254E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshProxySettings._ScriptStructPtr != 0) ? FMeshProxySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshProxySettings", ref FMeshProxySettings._ScriptStructPtr);
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x00127304 File Offset: 0x00125504
		// (set) Token: 0x0600CAA6 RID: 51878 RVA: 0x00127314 File Offset: 0x00125514
		public unsafe int ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_ScreenSize) = value;
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x00127325 File Offset: 0x00125525
		// (set) Token: 0x0600CAA8 RID: 51880 RVA: 0x00127335 File Offset: 0x00125535
		public unsafe float VoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_VoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_VoxelSize) = value;
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x00127348 File Offset: 0x00125548
		// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x0012738B File Offset: 0x0012558B
		[Nullable(1)]
		public FMaterialProxySettings MaterialSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMaterialProxySettings result;
				if ((result = this._MaterialSettings) == null)
				{
					result = (this._MaterialSettings = new FMaterialProxySettings(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialProxySettings.StaticStruct(), base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MaterialSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x001273AC File Offset: 0x001255AC
		// (set) Token: 0x0600CAAC RID: 51884 RVA: 0x001273BC File Offset: 0x001255BC
		public unsafe float MergeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MergeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MergeDistance) = value;
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x001273CD File Offset: 0x001255CD
		// (set) Token: 0x0600CAAE RID: 51886 RVA: 0x001273E1 File Offset: 0x001255E1
		public unsafe FColor UnresolvedGeometryColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_UnresolvedGeometryColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_UnresolvedGeometryColor) = value;
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x001273F6 File Offset: 0x001255F6
		// (set) Token: 0x0600CAB0 RID: 51888 RVA: 0x00127406 File Offset: 0x00125606
		public unsafe float MaxRayCastDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MaxRayCastDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_MaxRayCastDist) = value;
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x00127417 File Offset: 0x00125617
		// (set) Token: 0x0600CAB2 RID: 51890 RVA: 0x00127427 File Offset: 0x00125627
		public unsafe float HardAngleThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_HardAngleThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_HardAngleThreshold) = value;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600CAB3 RID: 51891 RVA: 0x00127438 File Offset: 0x00125638
		// (set) Token: 0x0600CAB4 RID: 51892 RVA: 0x00127448 File Offset: 0x00125648
		public unsafe int LightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_LightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_LightMapResolution) = value;
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x00127459 File Offset: 0x00125659
		// (set) Token: 0x0600CAB6 RID: 51894 RVA: 0x0012746D File Offset: 0x0012566D
		public unsafe TEnumAsByte<EProxyNormalComputationMethod> NormalCalculationMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_NormalCalculationMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_NormalCalculationMethod) = value;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x00127482 File Offset: 0x00125682
		// (set) Token: 0x0600CAB8 RID: 51896 RVA: 0x00127496 File Offset: 0x00125696
		public unsafe TEnumAsByte<ELandscapeCullingPrecision> LandscapeCullingPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_LandscapeCullingPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_LandscapeCullingPrecision) = value;
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x001274AB File Offset: 0x001256AB
		// (set) Token: 0x0600CABA RID: 51898 RVA: 0x001274C4 File Offset: 0x001256C4
		public unsafe bool bCalculateCorrectLODModel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCalculateCorrectLODModel) & FMeshProxySettings.__PropertyMask_bCalculateCorrectLODModel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCalculateCorrectLODModel) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCalculateCorrectLODModel) & ~FMeshProxySettings.__PropertyMask_bCalculateCorrectLODModel) | (value ? FMeshProxySettings.__PropertyMask_bCalculateCorrectLODModel : 0));
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600CABB RID: 51899 RVA: 0x001274F4 File Offset: 0x001256F4
		// (set) Token: 0x0600CABC RID: 51900 RVA: 0x0012750D File Offset: 0x0012570D
		public unsafe bool bUseMaxLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseMaxLod) & FMeshProxySettings.__PropertyMask_bUseMaxLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseMaxLod) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseMaxLod) & ~FMeshProxySettings.__PropertyMask_bUseMaxLod) | (value ? FMeshProxySettings.__PropertyMask_bUseMaxLod : 0));
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600CABD RID: 51901 RVA: 0x0012753D File Offset: 0x0012573D
		// (set) Token: 0x0600CABE RID: 51902 RVA: 0x00127556 File Offset: 0x00125756
		public unsafe bool bUseZeroLod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseZeroLod) & FMeshProxySettings.__PropertyMask_bUseZeroLod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseZeroLod) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseZeroLod) & ~FMeshProxySettings.__PropertyMask_bUseZeroLod) | (value ? FMeshProxySettings.__PropertyMask_bUseZeroLod : 0));
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600CABF RID: 51903 RVA: 0x00127586 File Offset: 0x00125786
		// (set) Token: 0x0600CAC0 RID: 51904 RVA: 0x0012759F File Offset: 0x0012579F
		public unsafe bool bOverrideVoxelSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideVoxelSize) & FMeshProxySettings.__PropertyMask_bOverrideVoxelSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideVoxelSize) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideVoxelSize) & ~FMeshProxySettings.__PropertyMask_bOverrideVoxelSize) | (value ? FMeshProxySettings.__PropertyMask_bOverrideVoxelSize : 0));
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x001275CF File Offset: 0x001257CF
		// (set) Token: 0x0600CAC2 RID: 51906 RVA: 0x001275E8 File Offset: 0x001257E8
		public unsafe bool bOverrideTransferDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideTransferDistance) & FMeshProxySettings.__PropertyMask_bOverrideTransferDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideTransferDistance) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bOverrideTransferDistance) & ~FMeshProxySettings.__PropertyMask_bOverrideTransferDistance) | (value ? FMeshProxySettings.__PropertyMask_bOverrideTransferDistance : 0));
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x00127618 File Offset: 0x00125818
		// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x00127631 File Offset: 0x00125831
		public unsafe bool bUseHardAngleThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseHardAngleThreshold) & FMeshProxySettings.__PropertyMask_bUseHardAngleThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseHardAngleThreshold) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseHardAngleThreshold) & ~FMeshProxySettings.__PropertyMask_bUseHardAngleThreshold) | (value ? FMeshProxySettings.__PropertyMask_bUseHardAngleThreshold : 0));
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x00127661 File Offset: 0x00125861
		// (set) Token: 0x0600CAC6 RID: 51910 RVA: 0x0012767A File Offset: 0x0012587A
		public unsafe bool bComputeLightMapResolution
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bComputeLightMapResolution) & FMeshProxySettings.__PropertyMask_bComputeLightMapResolution) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bComputeLightMapResolution) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bComputeLightMapResolution) & ~FMeshProxySettings.__PropertyMask_bComputeLightMapResolution) | (value ? FMeshProxySettings.__PropertyMask_bComputeLightMapResolution : 0));
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0600CAC7 RID: 51911 RVA: 0x001276AA File Offset: 0x001258AA
		// (set) Token: 0x0600CAC8 RID: 51912 RVA: 0x001276C3 File Offset: 0x001258C3
		public unsafe bool bRecalculateNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bRecalculateNormals) & FMeshProxySettings.__PropertyMask_bRecalculateNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bRecalculateNormals) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bRecalculateNormals) & ~FMeshProxySettings.__PropertyMask_bRecalculateNormals) | (value ? FMeshProxySettings.__PropertyMask_bRecalculateNormals : 0));
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x001276F3 File Offset: 0x001258F3
		// (set) Token: 0x0600CACA RID: 51914 RVA: 0x0012770C File Offset: 0x0012590C
		public unsafe bool bUseLandscapeCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseLandscapeCulling) & FMeshProxySettings.__PropertyMask_bUseLandscapeCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseLandscapeCulling) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bUseLandscapeCulling) & ~FMeshProxySettings.__PropertyMask_bUseLandscapeCulling) | (value ? FMeshProxySettings.__PropertyMask_bUseLandscapeCulling : 0));
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600CACB RID: 51915 RVA: 0x0012773C File Offset: 0x0012593C
		// (set) Token: 0x0600CACC RID: 51916 RVA: 0x00127755 File Offset: 0x00125955
		public unsafe bool bAllowAdjacency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowAdjacency) & FMeshProxySettings.__PropertyMask_bAllowAdjacency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowAdjacency) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowAdjacency) & ~FMeshProxySettings.__PropertyMask_bAllowAdjacency) | (value ? FMeshProxySettings.__PropertyMask_bAllowAdjacency : 0));
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600CACD RID: 51917 RVA: 0x00127785 File Offset: 0x00125985
		// (set) Token: 0x0600CACE RID: 51918 RVA: 0x0012779E File Offset: 0x0012599E
		public unsafe bool bAllowDistanceField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowDistanceField) & FMeshProxySettings.__PropertyMask_bAllowDistanceField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowDistanceField) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowDistanceField) & ~FMeshProxySettings.__PropertyMask_bAllowDistanceField) | (value ? FMeshProxySettings.__PropertyMask_bAllowDistanceField : 0));
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x001277CE File Offset: 0x001259CE
		// (set) Token: 0x0600CAD0 RID: 51920 RVA: 0x001277E7 File Offset: 0x001259E7
		public unsafe bool bReuseMeshLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bReuseMeshLightmapUVs) & FMeshProxySettings.__PropertyMask_bReuseMeshLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bReuseMeshLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bReuseMeshLightmapUVs) & ~FMeshProxySettings.__PropertyMask_bReuseMeshLightmapUVs) | (value ? FMeshProxySettings.__PropertyMask_bReuseMeshLightmapUVs : 0));
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600CAD1 RID: 51921 RVA: 0x00127817 File Offset: 0x00125A17
		// (set) Token: 0x0600CAD2 RID: 51922 RVA: 0x00127830 File Offset: 0x00125A30
		public unsafe bool bCreateCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCreateCollision) & FMeshProxySettings.__PropertyMask_bCreateCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCreateCollision) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bCreateCollision) & ~FMeshProxySettings.__PropertyMask_bCreateCollision) | (value ? FMeshProxySettings.__PropertyMask_bCreateCollision : 0));
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x00127860 File Offset: 0x00125A60
		// (set) Token: 0x0600CAD4 RID: 51924 RVA: 0x00127879 File Offset: 0x00125A79
		public unsafe bool bAllowVertexColors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowVertexColors) & FMeshProxySettings.__PropertyMask_bAllowVertexColors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowVertexColors) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bAllowVertexColors) & ~FMeshProxySettings.__PropertyMask_bAllowVertexColors) | (value ? FMeshProxySettings.__PropertyMask_bAllowVertexColors : 0));
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x001278A9 File Offset: 0x00125AA9
		// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x001278C2 File Offset: 0x00125AC2
		public unsafe bool bGenerateLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bGenerateLightmapUVs) & FMeshProxySettings.__PropertyMask_bGenerateLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bGenerateLightmapUVs) = ((*(base.NativePtr + (IntPtr)FMeshProxySettings.__PropertyOffset_bGenerateLightmapUVs) & ~FMeshProxySettings.__PropertyMask_bGenerateLightmapUVs) | (value ? FMeshProxySettings.__PropertyMask_bGenerateLightmapUVs : 0));
			}
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001278F2 File Offset: 0x00125AF2
		public FMeshProxySettings()
		{
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x001278FC File Offset: 0x00125AFC
		public FMeshProxySettings(int ScreenSize, float VoxelSize, [Nullable(1)] FMaterialProxySettings MaterialSettings, int TextureWidth_DEPRECATED, int TextureHeight_DEPRECATED, bool bExportNormalMap_DEPRECATED, bool bExportMetallicMap_DEPRECATED, bool bExportRoughnessMap_DEPRECATED, bool bExportSpecularMap_DEPRECATED, bool bBakeVertexData_DEPRECATED, float MergeDistance, FColor UnresolvedGeometryColor, float MaxRayCastDist, float HardAngleThreshold, int LightMapResolution, TEnumAsByte<EProxyNormalComputationMethod> NormalCalculationMethod, TEnumAsByte<ELandscapeCullingPrecision> LandscapeCullingPrecision, bool bCalculateCorrectLODModel, bool bUseMaxLod, bool bUseZeroLod, bool bOverrideVoxelSize, bool bOverrideTransferDistance, bool bUseHardAngleThreshold, bool bComputeLightMapResolution, bool bRecalculateNormals, bool bUseLandscapeCulling, bool bAllowAdjacency, bool bAllowDistanceField, bool bReuseMeshLightmapUVs, bool bCreateCollision, bool bAllowVertexColors, bool bGenerateLightmapUVs)
		{
			this.ScreenSize = ScreenSize;
			this.VoxelSize = VoxelSize;
			this.MaterialSettings = MaterialSettings;
			this.MergeDistance = MergeDistance;
			this.UnresolvedGeometryColor = UnresolvedGeometryColor;
			this.MaxRayCastDist = MaxRayCastDist;
			this.HardAngleThreshold = HardAngleThreshold;
			this.LightMapResolution = LightMapResolution;
			this.NormalCalculationMethod = NormalCalculationMethod;
			this.LandscapeCullingPrecision = LandscapeCullingPrecision;
			this.bCalculateCorrectLODModel = bCalculateCorrectLODModel;
			this.bUseMaxLod = bUseMaxLod;
			this.bUseZeroLod = bUseZeroLod;
			this.bOverrideVoxelSize = bOverrideVoxelSize;
			this.bOverrideTransferDistance = bOverrideTransferDistance;
			this.bUseHardAngleThreshold = bUseHardAngleThreshold;
			this.bComputeLightMapResolution = bComputeLightMapResolution;
			this.bRecalculateNormals = bRecalculateNormals;
			this.bUseLandscapeCulling = bUseLandscapeCulling;
			this.bAllowAdjacency = bAllowAdjacency;
			this.bAllowDistanceField = bAllowDistanceField;
			this.bReuseMeshLightmapUVs = bReuseMeshLightmapUVs;
			this.bCreateCollision = bCreateCollision;
			this.bAllowVertexColors = bAllowVertexColors;
			this.bGenerateLightmapUVs = bGenerateLightmapUVs;
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x001279D4 File Offset: 0x00125BD4
		protected override IntPtr GetUStructPtr()
		{
			return FMeshProxySettings.StaticStruct();
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x001279E0 File Offset: 0x00125BE0
		[NullableContext(2)]
		public FMeshProxySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CADB RID: 51931 RVA: 0x001279EA File Offset: 0x00125BEA
		public FMeshProxySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x001279F5 File Offset: 0x00125BF5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshProxySettings(Pointer, false, true);
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x001279FF File Offset: 0x00125BFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshProxySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006D21 RID: 27937
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MeshProxySettings";

		// Token: 0x04006D22 RID: 27938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D23 RID: 27939
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x04006D24 RID: 27940
		internal static int __PropertyOffset_VoxelSize;

		// Token: 0x04006D25 RID: 27941
		internal static int __PropertyOffset_MaterialSettings;

		// Token: 0x04006D26 RID: 27942
		[Nullable(2)]
		private FMaterialProxySettings _MaterialSettings;

		// Token: 0x04006D27 RID: 27943
		internal static int __PropertyOffset_MergeDistance;

		// Token: 0x04006D28 RID: 27944
		internal static int __PropertyOffset_UnresolvedGeometryColor;

		// Token: 0x04006D29 RID: 27945
		internal static int __PropertyOffset_MaxRayCastDist;

		// Token: 0x04006D2A RID: 27946
		internal static int __PropertyOffset_HardAngleThreshold;

		// Token: 0x04006D2B RID: 27947
		internal static int __PropertyOffset_LightMapResolution;

		// Token: 0x04006D2C RID: 27948
		internal static int __PropertyOffset_NormalCalculationMethod;

		// Token: 0x04006D2D RID: 27949
		internal static int __PropertyOffset_LandscapeCullingPrecision;

		// Token: 0x04006D2E RID: 27950
		internal static int __PropertyOffset_bCalculateCorrectLODModel;

		// Token: 0x04006D2F RID: 27951
		internal static byte __PropertyMask_bCalculateCorrectLODModel;

		// Token: 0x04006D30 RID: 27952
		internal static int __PropertyOffset_bUseMaxLod;

		// Token: 0x04006D31 RID: 27953
		internal static byte __PropertyMask_bUseMaxLod;

		// Token: 0x04006D32 RID: 27954
		internal static int __PropertyOffset_bUseZeroLod;

		// Token: 0x04006D33 RID: 27955
		internal static byte __PropertyMask_bUseZeroLod;

		// Token: 0x04006D34 RID: 27956
		internal static int __PropertyOffset_bOverrideVoxelSize;

		// Token: 0x04006D35 RID: 27957
		internal static byte __PropertyMask_bOverrideVoxelSize;

		// Token: 0x04006D36 RID: 27958
		internal static int __PropertyOffset_bOverrideTransferDistance;

		// Token: 0x04006D37 RID: 27959
		internal static byte __PropertyMask_bOverrideTransferDistance;

		// Token: 0x04006D38 RID: 27960
		internal static int __PropertyOffset_bUseHardAngleThreshold;

		// Token: 0x04006D39 RID: 27961
		internal static byte __PropertyMask_bUseHardAngleThreshold;

		// Token: 0x04006D3A RID: 27962
		internal static int __PropertyOffset_bComputeLightMapResolution;

		// Token: 0x04006D3B RID: 27963
		internal static byte __PropertyMask_bComputeLightMapResolution;

		// Token: 0x04006D3C RID: 27964
		internal static int __PropertyOffset_bRecalculateNormals;

		// Token: 0x04006D3D RID: 27965
		internal static byte __PropertyMask_bRecalculateNormals;

		// Token: 0x04006D3E RID: 27966
		internal static int __PropertyOffset_bUseLandscapeCulling;

		// Token: 0x04006D3F RID: 27967
		internal static byte __PropertyMask_bUseLandscapeCulling;

		// Token: 0x04006D40 RID: 27968
		internal static int __PropertyOffset_bAllowAdjacency;

		// Token: 0x04006D41 RID: 27969
		internal static byte __PropertyMask_bAllowAdjacency;

		// Token: 0x04006D42 RID: 27970
		internal static int __PropertyOffset_bAllowDistanceField;

		// Token: 0x04006D43 RID: 27971
		internal static byte __PropertyMask_bAllowDistanceField;

		// Token: 0x04006D44 RID: 27972
		internal static int __PropertyOffset_bReuseMeshLightmapUVs;

		// Token: 0x04006D45 RID: 27973
		internal static byte __PropertyMask_bReuseMeshLightmapUVs;

		// Token: 0x04006D46 RID: 27974
		internal static int __PropertyOffset_bCreateCollision;

		// Token: 0x04006D47 RID: 27975
		internal static byte __PropertyMask_bCreateCollision;

		// Token: 0x04006D48 RID: 27976
		internal static int __PropertyOffset_bAllowVertexColors;

		// Token: 0x04006D49 RID: 27977
		internal static byte __PropertyMask_bAllowVertexColors;

		// Token: 0x04006D4A RID: 27978
		internal static int __PropertyOffset_bGenerateLightmapUVs;

		// Token: 0x04006D4B RID: 27979
		internal static byte __PropertyMask_bGenerateLightmapUVs;
	}
}
