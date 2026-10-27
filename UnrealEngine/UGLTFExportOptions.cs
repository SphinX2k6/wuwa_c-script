using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001447 RID: 5191
	[UnrealObjectPath("/Script/GLTFExporter.GLTFExportOptions")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UGLTFExportOptions : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012F8B RID: 77707 RVA: 0x001BE56E File Offset: 0x001BC76E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFExportOptions._ClassPtr;
		}

		// Token: 0x06012F8C RID: 77708 RVA: 0x001BE57C File Offset: 0x001BC77C
		public UGLTFExportOptions() : this(BuiltinUtils.AllocNativeUObject(UGLTFExportOptions.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012F8D RID: 77709 RVA: 0x001BE5A4 File Offset: 0x001BC7A4
		[NullableContext(1)]
		public UGLTFExportOptions(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFExportOptions.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x06012F8E RID: 77710 RVA: 0x001BE5D7 File Offset: 0x001BC7D7
		// (set) Token: 0x06012F8F RID: 77711 RVA: 0x001BE5E7 File Offset: 0x001BC7E7
		public unsafe float ExportUniformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportUniformScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportUniformScale) = value;
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x06012F90 RID: 77712 RVA: 0x001BE5F8 File Offset: 0x001BC7F8
		// (set) Token: 0x06012F91 RID: 77713 RVA: 0x001BE608 File Offset: 0x001BC808
		public unsafe bool bExportPreviewMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportPreviewMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportPreviewMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x06012F92 RID: 77714 RVA: 0x001BE619 File Offset: 0x001BC819
		// (set) Token: 0x06012F93 RID: 77715 RVA: 0x001BE629 File Offset: 0x001BC829
		public unsafe bool bStrictCompliance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bStrictCompliance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bStrictCompliance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x06012F94 RID: 77716 RVA: 0x001BE63A File Offset: 0x001BC83A
		// (set) Token: 0x06012F95 RID: 77717 RVA: 0x001BE64A File Offset: 0x001BC84A
		public unsafe bool bSkipNearDefaultValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bSkipNearDefaultValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bSkipNearDefaultValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x06012F96 RID: 77718 RVA: 0x001BE65B File Offset: 0x001BC85B
		// (set) Token: 0x06012F97 RID: 77719 RVA: 0x001BE66B File Offset: 0x001BC86B
		public unsafe bool bIncludeGeneratorVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bIncludeGeneratorVersion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bIncludeGeneratorVersion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x06012F98 RID: 77720 RVA: 0x001BE67C File Offset: 0x001BC87C
		// (set) Token: 0x06012F99 RID: 77721 RVA: 0x001BE68C File Offset: 0x001BC88C
		public unsafe bool bExportProxyMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportProxyMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportProxyMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x06012F9A RID: 77722 RVA: 0x001BE69D File Offset: 0x001BC89D
		// (set) Token: 0x06012F9B RID: 77723 RVA: 0x001BE6AD File Offset: 0x001BC8AD
		public unsafe bool bExportUnlitMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportUnlitMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportUnlitMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x06012F9C RID: 77724 RVA: 0x001BE6BE File Offset: 0x001BC8BE
		// (set) Token: 0x06012F9D RID: 77725 RVA: 0x001BE6CE File Offset: 0x001BC8CE
		public unsafe bool bExportClearCoatMaterials
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportClearCoatMaterials) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportClearCoatMaterials) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x06012F9E RID: 77726 RVA: 0x001BE6DF File Offset: 0x001BC8DF
		// (set) Token: 0x06012F9F RID: 77727 RVA: 0x001BE6EF File Offset: 0x001BC8EF
		public unsafe bool bExportExtraBlendModes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportExtraBlendModes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportExtraBlendModes) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x06012FA0 RID: 77728 RVA: 0x001BE700 File Offset: 0x001BC900
		// (set) Token: 0x06012FA1 RID: 77729 RVA: 0x001BE710 File Offset: 0x001BC910
		public unsafe EGLTFMaterialBakeMode BakeMaterialInputs
		{
			get
			{
				return (EGLTFMaterialBakeMode)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_BakeMaterialInputs));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_BakeMaterialInputs) = (byte)value;
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x06012FA2 RID: 77730 RVA: 0x001BE721 File Offset: 0x001BC921
		// (set) Token: 0x06012FA3 RID: 77731 RVA: 0x001BE731 File Offset: 0x001BC931
		public unsafe EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize
		{
			get
			{
				return (EGLTFMaterialBakeSizePOT)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeSize) = (byte)value;
			}
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x06012FA4 RID: 77732 RVA: 0x001BE742 File Offset: 0x001BC942
		// (set) Token: 0x06012FA5 RID: 77733 RVA: 0x001BE756 File Offset: 0x001BC956
		public unsafe TEnumAsByte<TextureFilter> DefaultMaterialBakeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeFilter) = value;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x06012FA6 RID: 77734 RVA: 0x001BE76B File Offset: 0x001BC96B
		// (set) Token: 0x06012FA7 RID: 77735 RVA: 0x001BE77F File Offset: 0x001BC97F
		public unsafe TEnumAsByte<TextureAddress> DefaultMaterialBakeTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultMaterialBakeTiling) = value;
			}
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x06012FA8 RID: 77736 RVA: 0x001BE794 File Offset: 0x001BC994
		// (set) Token: 0x06012FA9 RID: 77737 RVA: 0x001BE7CD File Offset: 0x001BC9CD
		[Nullable(1)]
		public TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> result;
				if ((result = this._DefaultInputBakeSettings) == null)
				{
					result = (this._DefaultInputBakeSettings = new TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings>(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultInputBakeSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DefaultInputBakeSettings.CopyAssign(value);
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x06012FAA RID: 77738 RVA: 0x001BE7DB File Offset: 0x001BC9DB
		// (set) Token: 0x06012FAB RID: 77739 RVA: 0x001BE7EB File Offset: 0x001BC9EB
		public unsafe int DefaultLevelOfDetail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultLevelOfDetail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_DefaultLevelOfDetail) = value;
			}
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x06012FAC RID: 77740 RVA: 0x001BE7FC File Offset: 0x001BC9FC
		// (set) Token: 0x06012FAD RID: 77741 RVA: 0x001BE80C File Offset: 0x001BCA0C
		public unsafe bool bExportVertexColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVertexColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVertexColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x06012FAE RID: 77742 RVA: 0x001BE81D File Offset: 0x001BCA1D
		// (set) Token: 0x06012FAF RID: 77743 RVA: 0x001BE82D File Offset: 0x001BCA2D
		public unsafe bool bExportVertexSkinWeights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVertexSkinWeights) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVertexSkinWeights) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x06012FB0 RID: 77744 RVA: 0x001BE83E File Offset: 0x001BCA3E
		// (set) Token: 0x06012FB1 RID: 77745 RVA: 0x001BE84E File Offset: 0x001BCA4E
		public unsafe bool bUseMeshQuantization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bUseMeshQuantization) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bUseMeshQuantization) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x06012FB2 RID: 77746 RVA: 0x001BE85F File Offset: 0x001BCA5F
		// (set) Token: 0x06012FB3 RID: 77747 RVA: 0x001BE86F File Offset: 0x001BCA6F
		public unsafe bool bExportLevelSequences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportLevelSequences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportLevelSequences) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x06012FB4 RID: 77748 RVA: 0x001BE880 File Offset: 0x001BCA80
		// (set) Token: 0x06012FB5 RID: 77749 RVA: 0x001BE890 File Offset: 0x001BCA90
		public unsafe bool bExportAnimationSequences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportAnimationSequences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportAnimationSequences) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06012FB6 RID: 77750 RVA: 0x001BE8A1 File Offset: 0x001BCAA1
		// (set) Token: 0x06012FB7 RID: 77751 RVA: 0x001BE8B1 File Offset: 0x001BCAB1
		public unsafe bool bExportPlaybackSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportPlaybackSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportPlaybackSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06012FB8 RID: 77752 RVA: 0x001BE8C2 File Offset: 0x001BCAC2
		// (set) Token: 0x06012FB9 RID: 77753 RVA: 0x001BE8D2 File Offset: 0x001BCAD2
		public unsafe EGLTFTextureImageFormat TextureImageFormat
		{
			get
			{
				return (EGLTFTextureImageFormat)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureImageFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureImageFormat) = (byte)value;
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06012FBA RID: 77754 RVA: 0x001BE8E3 File Offset: 0x001BCAE3
		// (set) Token: 0x06012FBB RID: 77755 RVA: 0x001BE8F3 File Offset: 0x001BCAF3
		public unsafe int TextureImageQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureImageQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureImageQuality) = value;
			}
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06012FBC RID: 77756 RVA: 0x001BE904 File Offset: 0x001BCB04
		// (set) Token: 0x06012FBD RID: 77757 RVA: 0x001BE914 File Offset: 0x001BCB14
		public unsafe int NoLossyImageFormatFor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_NoLossyImageFormatFor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_NoLossyImageFormatFor) = value;
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06012FBE RID: 77758 RVA: 0x001BE925 File Offset: 0x001BCB25
		// (set) Token: 0x06012FBF RID: 77759 RVA: 0x001BE935 File Offset: 0x001BCB35
		public unsafe bool bExportTextureTransforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportTextureTransforms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportTextureTransforms) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x06012FC0 RID: 77760 RVA: 0x001BE946 File Offset: 0x001BCB46
		// (set) Token: 0x06012FC1 RID: 77761 RVA: 0x001BE956 File Offset: 0x001BCB56
		public unsafe bool bExportLightmaps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportLightmaps) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportLightmaps) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x06012FC2 RID: 77762 RVA: 0x001BE967 File Offset: 0x001BCB67
		// (set) Token: 0x06012FC3 RID: 77763 RVA: 0x001BE977 File Offset: 0x001BCB77
		public unsafe EGLTFTextureHDREncoding TextureHDREncoding
		{
			get
			{
				return (EGLTFTextureHDREncoding)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureHDREncoding));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_TextureHDREncoding) = (byte)value;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x06012FC4 RID: 77764 RVA: 0x001BE988 File Offset: 0x001BCB88
		// (set) Token: 0x06012FC5 RID: 77765 RVA: 0x001BE998 File Offset: 0x001BCB98
		public unsafe bool bAdjustNormalmaps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bAdjustNormalmaps) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bAdjustNormalmaps) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x06012FC6 RID: 77766 RVA: 0x001BE9A9 File Offset: 0x001BCBA9
		// (set) Token: 0x06012FC7 RID: 77767 RVA: 0x001BE9B9 File Offset: 0x001BCBB9
		public unsafe bool bExportHiddenInGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportHiddenInGame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportHiddenInGame) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x06012FC8 RID: 77768 RVA: 0x001BE9CA File Offset: 0x001BCBCA
		// (set) Token: 0x06012FC9 RID: 77769 RVA: 0x001BE9DA File Offset: 0x001BCBDA
		public unsafe int ExportLights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportLights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportLights) = value;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06012FCA RID: 77770 RVA: 0x001BE9EB File Offset: 0x001BCBEB
		// (set) Token: 0x06012FCB RID: 77771 RVA: 0x001BE9FB File Offset: 0x001BCBFB
		public unsafe bool bExportCameras
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportCameras) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportCameras) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x06012FCC RID: 77772 RVA: 0x001BEA0C File Offset: 0x001BCC0C
		// (set) Token: 0x06012FCD RID: 77773 RVA: 0x001BEA1C File Offset: 0x001BCC1C
		public unsafe bool bExportCameraControls
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportCameraControls) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportCameraControls) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x06012FCE RID: 77774 RVA: 0x001BEA2D File Offset: 0x001BCC2D
		// (set) Token: 0x06012FCF RID: 77775 RVA: 0x001BEA3D File Offset: 0x001BCC3D
		public unsafe bool bExportAnimationHotspots
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportAnimationHotspots) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportAnimationHotspots) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x06012FD0 RID: 77776 RVA: 0x001BEA4E File Offset: 0x001BCC4E
		// (set) Token: 0x06012FD1 RID: 77777 RVA: 0x001BEA5E File Offset: 0x001BCC5E
		public unsafe bool bExportHDRIBackdrops
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportHDRIBackdrops) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportHDRIBackdrops) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x06012FD2 RID: 77778 RVA: 0x001BEA6F File Offset: 0x001BCC6F
		// (set) Token: 0x06012FD3 RID: 77779 RVA: 0x001BEA7F File Offset: 0x001BCC7F
		public unsafe bool bExportSkySpheres
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportSkySpheres) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportSkySpheres) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x06012FD4 RID: 77780 RVA: 0x001BEA90 File Offset: 0x001BCC90
		// (set) Token: 0x06012FD5 RID: 77781 RVA: 0x001BEAA0 File Offset: 0x001BCCA0
		public unsafe EGLTFVariantSetsMode VariantSetsMode
		{
			get
			{
				return (EGLTFVariantSetsMode)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_VariantSetsMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_VariantSetsMode) = (byte)value;
			}
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x06012FD6 RID: 77782 RVA: 0x001BEAB1 File Offset: 0x001BCCB1
		// (set) Token: 0x06012FD7 RID: 77783 RVA: 0x001BEAC1 File Offset: 0x001BCCC1
		public unsafe EGLTFMaterialVariantMode ExportMaterialVariants
		{
			get
			{
				return (EGLTFMaterialVariantMode)(*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportMaterialVariants));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_ExportMaterialVariants) = (byte)value;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x06012FD8 RID: 77784 RVA: 0x001BEAD2 File Offset: 0x001BCCD2
		// (set) Token: 0x06012FD9 RID: 77785 RVA: 0x001BEAE2 File Offset: 0x001BCCE2
		public unsafe bool bExportMeshVariants
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportMeshVariants) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportMeshVariants) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x06012FDA RID: 77786 RVA: 0x001BEAF3 File Offset: 0x001BCCF3
		// (set) Token: 0x06012FDB RID: 77787 RVA: 0x001BEB03 File Offset: 0x001BCD03
		public unsafe bool bExportVisibilityVariants
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVisibilityVariants) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGLTFExportOptions.__PropertyOffset_bExportVisibilityVariants) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012FDC RID: 77788 RVA: 0x001BEB14 File Offset: 0x001BCD14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetToDefault()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGLTFExportOptions.__ResetToDefault_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06012FDD RID: 77789 RVA: 0x001BEB29 File Offset: 0x001BCD29
		static UGLTFExportOptions()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFExportOptions");
		}

		// Token: 0x06012FDE RID: 77790 RVA: 0x001BEB37 File Offset: 0x001BCD37
		protected UGLTFExportOptions(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A255 RID: 41557
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFExportOptions";

		// Token: 0x0400A256 RID: 41558
		private static IntPtr _ClassPtr;

		// Token: 0x0400A257 RID: 41559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A258 RID: 41560
		internal static int __PropertyOffset_ExportUniformScale;

		// Token: 0x0400A259 RID: 41561
		internal static int __PropertyOffset_bExportPreviewMesh;

		// Token: 0x0400A25A RID: 41562
		internal static int __PropertyOffset_bStrictCompliance;

		// Token: 0x0400A25B RID: 41563
		internal static int __PropertyOffset_bSkipNearDefaultValues;

		// Token: 0x0400A25C RID: 41564
		internal static int __PropertyOffset_bIncludeGeneratorVersion;

		// Token: 0x0400A25D RID: 41565
		internal static int __PropertyOffset_bExportProxyMaterials;

		// Token: 0x0400A25E RID: 41566
		internal static int __PropertyOffset_bExportUnlitMaterials;

		// Token: 0x0400A25F RID: 41567
		internal static int __PropertyOffset_bExportClearCoatMaterials;

		// Token: 0x0400A260 RID: 41568
		internal static int __PropertyOffset_bExportExtraBlendModes;

		// Token: 0x0400A261 RID: 41569
		internal static int __PropertyOffset_BakeMaterialInputs;

		// Token: 0x0400A262 RID: 41570
		internal static int __PropertyOffset_DefaultMaterialBakeSize;

		// Token: 0x0400A263 RID: 41571
		internal static int __PropertyOffset_DefaultMaterialBakeFilter;

		// Token: 0x0400A264 RID: 41572
		internal static int __PropertyOffset_DefaultMaterialBakeTiling;

		// Token: 0x0400A265 RID: 41573
		internal static int __PropertyOffset_DefaultInputBakeSettings;

		// Token: 0x0400A266 RID: 41574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> _DefaultInputBakeSettings;

		// Token: 0x0400A267 RID: 41575
		internal static int __PropertyOffset_DefaultLevelOfDetail;

		// Token: 0x0400A268 RID: 41576
		internal static int __PropertyOffset_bExportVertexColors;

		// Token: 0x0400A269 RID: 41577
		internal static int __PropertyOffset_bExportVertexSkinWeights;

		// Token: 0x0400A26A RID: 41578
		internal static int __PropertyOffset_bUseMeshQuantization;

		// Token: 0x0400A26B RID: 41579
		internal static int __PropertyOffset_bExportLevelSequences;

		// Token: 0x0400A26C RID: 41580
		internal static int __PropertyOffset_bExportAnimationSequences;

		// Token: 0x0400A26D RID: 41581
		internal static int __PropertyOffset_bExportPlaybackSettings;

		// Token: 0x0400A26E RID: 41582
		internal static int __PropertyOffset_TextureImageFormat;

		// Token: 0x0400A26F RID: 41583
		internal static int __PropertyOffset_TextureImageQuality;

		// Token: 0x0400A270 RID: 41584
		internal static int __PropertyOffset_NoLossyImageFormatFor;

		// Token: 0x0400A271 RID: 41585
		internal static int __PropertyOffset_bExportTextureTransforms;

		// Token: 0x0400A272 RID: 41586
		internal static int __PropertyOffset_bExportLightmaps;

		// Token: 0x0400A273 RID: 41587
		internal static int __PropertyOffset_TextureHDREncoding;

		// Token: 0x0400A274 RID: 41588
		internal static int __PropertyOffset_bAdjustNormalmaps;

		// Token: 0x0400A275 RID: 41589
		internal static int __PropertyOffset_bExportHiddenInGame;

		// Token: 0x0400A276 RID: 41590
		internal static int __PropertyOffset_ExportLights;

		// Token: 0x0400A277 RID: 41591
		internal static int __PropertyOffset_bExportCameras;

		// Token: 0x0400A278 RID: 41592
		internal static int __PropertyOffset_bExportCameraControls;

		// Token: 0x0400A279 RID: 41593
		internal static int __PropertyOffset_bExportAnimationHotspots;

		// Token: 0x0400A27A RID: 41594
		internal static int __PropertyOffset_bExportHDRIBackdrops;

		// Token: 0x0400A27B RID: 41595
		internal static int __PropertyOffset_bExportSkySpheres;

		// Token: 0x0400A27C RID: 41596
		internal static int __PropertyOffset_VariantSetsMode;

		// Token: 0x0400A27D RID: 41597
		internal static int __PropertyOffset_ExportMaterialVariants;

		// Token: 0x0400A27E RID: 41598
		internal static int __PropertyOffset_bExportMeshVariants;

		// Token: 0x0400A27F RID: 41599
		internal static int __PropertyOffset_bExportVisibilityVariants;

		// Token: 0x0400A280 RID: 41600
		private static IntPtr __ResetToDefault_NativeFunctionPtr;
	}
}
