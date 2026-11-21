using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200063D RID: 1597
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeProxy")]
	[UnrealStructLayout(2640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2640)]
	public abstract class ALandscapeProxy : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C03 RID: 35843 RVA: 0x000D2A03 File Offset: 0x000D0C03
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeProxy._ClassPtr;
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06008C04 RID: 35844 RVA: 0x000D2A0F File Offset: 0x000D0C0F
		// (set) Token: 0x06008C05 RID: 35845 RVA: 0x000D2A23 File Offset: 0x000D0C23
		public unsafe FGuid LandscapeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeGuid) = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06008C06 RID: 35846 RVA: 0x000D2A38 File Offset: 0x000D0C38
		// (set) Token: 0x06008C07 RID: 35847 RVA: 0x000D2A4C File Offset: 0x000D0C4C
		public unsafe FIntPoint LandscapeSectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeSectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeSectionOffset) = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06008C08 RID: 35848 RVA: 0x000D2A61 File Offset: 0x000D0C61
		// (set) Token: 0x06008C09 RID: 35849 RVA: 0x000D2A71 File Offset: 0x000D0C71
		public unsafe int MaxLODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MaxLODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MaxLODLevel) = value;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x000D2A82 File Offset: 0x000D0C82
		// (set) Token: 0x06008C0B RID: 35851 RVA: 0x000D2A92 File Offset: 0x000D0C92
		public unsafe float LODDistanceFactor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODDistanceFactor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODDistanceFactor_DEPRECATED) = value;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06008C0C RID: 35852 RVA: 0x000D2AA3 File Offset: 0x000D0CA3
		// (set) Token: 0x06008C0D RID: 35853 RVA: 0x000D2AB3 File Offset: 0x000D0CB3
		public unsafe float ComponentScreenSizeToUseSubSections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_ComponentScreenSizeToUseSubSections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_ComponentScreenSizeToUseSubSections) = value;
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06008C0E RID: 35854 RVA: 0x000D2AC4 File Offset: 0x000D0CC4
		// (set) Token: 0x06008C0F RID: 35855 RVA: 0x000D2AD4 File Offset: 0x000D0CD4
		public unsafe float LOD0ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LOD0ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LOD0ScreenSize) = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06008C10 RID: 35856 RVA: 0x000D2AE5 File Offset: 0x000D0CE5
		// (set) Token: 0x06008C11 RID: 35857 RVA: 0x000D2AF5 File Offset: 0x000D0CF5
		public unsafe float LOD0DistributionSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LOD0DistributionSetting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LOD0DistributionSetting) = value;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06008C12 RID: 35858 RVA: 0x000D2B06 File Offset: 0x000D0D06
		// (set) Token: 0x06008C13 RID: 35859 RVA: 0x000D2B16 File Offset: 0x000D0D16
		public unsafe float LODDistributionSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODDistributionSetting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODDistributionSetting) = value;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06008C14 RID: 35860 RVA: 0x000D2B27 File Offset: 0x000D0D27
		// (set) Token: 0x06008C15 RID: 35861 RVA: 0x000D2B37 File Offset: 0x000D0D37
		public unsafe float TessellationComponentScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_TessellationComponentScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_TessellationComponentScreenSize) = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06008C16 RID: 35862 RVA: 0x000D2B48 File Offset: 0x000D0D48
		// (set) Token: 0x06008C17 RID: 35863 RVA: 0x000D2B58 File Offset: 0x000D0D58
		public unsafe bool UseTessellationComponentScreenSizeFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_UseTessellationComponentScreenSizeFalloff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_UseTessellationComponentScreenSizeFalloff) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06008C18 RID: 35864 RVA: 0x000D2B69 File Offset: 0x000D0D69
		// (set) Token: 0x06008C19 RID: 35865 RVA: 0x000D2B79 File Offset: 0x000D0D79
		public unsafe float TessellationComponentScreenSizeFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_TessellationComponentScreenSizeFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_TessellationComponentScreenSizeFalloff) = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06008C1A RID: 35866 RVA: 0x000D2B8A File Offset: 0x000D0D8A
		// (set) Token: 0x06008C1B RID: 35867 RVA: 0x000D2B9A File Offset: 0x000D0D9A
		public unsafe int OccluderGeometryLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_OccluderGeometryLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_OccluderGeometryLOD) = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06008C1C RID: 35868 RVA: 0x000D2BAB File Offset: 0x000D0DAB
		// (set) Token: 0x06008C1D RID: 35869 RVA: 0x000D2BBB File Offset: 0x000D0DBB
		public unsafe int StaticLightingLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StaticLightingLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StaticLightingLOD) = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008C1E RID: 35870 RVA: 0x000D2BCC File Offset: 0x000D0DCC
		// (set) Token: 0x06008C1F RID: 35871 RVA: 0x000D2BE0 File Offset: 0x000D0DE0
		public unsafe UPhysicalMaterial DefaultPhysMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_DefaultPhysMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_DefaultPhysMaterial, value);
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008C20 RID: 35872 RVA: 0x000D2BF5 File Offset: 0x000D0DF5
		// (set) Token: 0x06008C21 RID: 35873 RVA: 0x000D2C05 File Offset: 0x000D0E05
		public unsafe float StreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008C22 RID: 35874 RVA: 0x000D2C16 File Offset: 0x000D0E16
		// (set) Token: 0x06008C23 RID: 35875 RVA: 0x000D2C2A File Offset: 0x000D0E2A
		public unsafe UMaterialInterface LandscapeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeMaterial, value);
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06008C24 RID: 35876 RVA: 0x000D2C40 File Offset: 0x000D0E40
		// (set) Token: 0x06008C25 RID: 35877 RVA: 0x000D2C79 File Offset: 0x000D0E79
		[Nullable(1)]
		public TArray<FVector4> LandscapeLayerParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._LandscapeLayerParams) == null)
				{
					result = (this._LandscapeLayerParams = new TArray<FVector4>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeLayerParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LandscapeLayerParams.CopyAssign(value);
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06008C26 RID: 35878 RVA: 0x000D2C87 File Offset: 0x000D0E87
		// (set) Token: 0x06008C27 RID: 35879 RVA: 0x000D2CA0 File Offset: 0x000D0EA0
		public unsafe bool UseLandscapeColormap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_UseLandscapeColormap) & ALandscapeProxy.__PropertyMask_UseLandscapeColormap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_UseLandscapeColormap) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_UseLandscapeColormap) & ~ALandscapeProxy.__PropertyMask_UseLandscapeColormap) | (value ? ALandscapeProxy.__PropertyMask_UseLandscapeColormap : 0));
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06008C28 RID: 35880 RVA: 0x000D2CD0 File Offset: 0x000D0ED0
		// (set) Token: 0x06008C29 RID: 35881 RVA: 0x000D2CE4 File Offset: 0x000D0EE4
		public unsafe UTexture2D KuroColormapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_KuroColormapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_KuroColormapTexture, value);
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06008C2A RID: 35882 RVA: 0x000D2CF9 File Offset: 0x000D0EF9
		// (set) Token: 0x06008C2B RID: 35883 RVA: 0x000D2D0D File Offset: 0x000D0F0D
		public unsafe FVector4 SectionBaseMinAndRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SectionBaseMinAndRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SectionBaseMinAndRange) = value;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06008C2C RID: 35884 RVA: 0x000D2D22 File Offset: 0x000D0F22
		// (set) Token: 0x06008C2D RID: 35885 RVA: 0x000D2D36 File Offset: 0x000D0F36
		public unsafe UMaterialInterface LandscapeHoleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeHoleMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeHoleMaterial, value);
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008C2E RID: 35886 RVA: 0x000D2D4B File Offset: 0x000D0F4B
		// (set) Token: 0x06008C2F RID: 35887 RVA: 0x000D2D5B File Offset: 0x000D0F5B
		public unsafe bool bMeshHoles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bMeshHoles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bMeshHoles) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06008C30 RID: 35888 RVA: 0x000D2D6C File Offset: 0x000D0F6C
		// (set) Token: 0x06008C31 RID: 35889 RVA: 0x000D2D7C File Offset: 0x000D0F7C
		public unsafe byte MeshHolesMaxLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MeshHolesMaxLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MeshHolesMaxLod) = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06008C32 RID: 35890 RVA: 0x000D2D8D File Offset: 0x000D0F8D
		// (set) Token: 0x06008C33 RID: 35891 RVA: 0x000D2D9D File Offset: 0x000D0F9D
		public unsafe int VirtualTextureNumLods
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureNumLods);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureNumLods) = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06008C34 RID: 35892 RVA: 0x000D2DAE File Offset: 0x000D0FAE
		// (set) Token: 0x06008C35 RID: 35893 RVA: 0x000D2DBE File Offset: 0x000D0FBE
		public unsafe int VirtualTextureLodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureLodBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureLodBias) = value;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x000D2DCF File Offset: 0x000D0FCF
		// (set) Token: 0x06008C37 RID: 35895 RVA: 0x000D2DDF File Offset: 0x000D0FDF
		public unsafe float NegativeZBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NegativeZBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NegativeZBoundsExtension) = value;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06008C38 RID: 35896 RVA: 0x000D2DF0 File Offset: 0x000D0FF0
		// (set) Token: 0x06008C39 RID: 35897 RVA: 0x000D2E00 File Offset: 0x000D1000
		public unsafe float PositiveZBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_PositiveZBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_PositiveZBoundsExtension) = value;
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06008C3A RID: 35898 RVA: 0x000D2E14 File Offset: 0x000D1014
		// (set) Token: 0x06008C3B RID: 35899 RVA: 0x000D2E4D File Offset: 0x000D104D
		[Nullable(1)]
		public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeHeightfieldCollisionComponent> result;
				if ((result = this._CollisionComponents) == null)
				{
					result = (this._CollisionComponents = new TArray<ULandscapeHeightfieldCollisionComponent>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CollisionComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CollisionComponents.CopyAssign(value);
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06008C3C RID: 35900 RVA: 0x000D2E5B File Offset: 0x000D105B
		// (set) Token: 0x06008C3D RID: 35901 RVA: 0x000D2E6B File Offset: 0x000D106B
		public unsafe bool bHasLandscapeGrass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bHasLandscapeGrass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bHasLandscapeGrass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06008C3E RID: 35902 RVA: 0x000D2E7C File Offset: 0x000D107C
		// (set) Token: 0x06008C3F RID: 35903 RVA: 0x000D2E8C File Offset: 0x000D108C
		public unsafe float StaticLightingResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StaticLightingResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_StaticLightingResolution) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06008C40 RID: 35904 RVA: 0x000D2E9D File Offset: 0x000D109D
		// (set) Token: 0x06008C41 RID: 35905 RVA: 0x000D2EB6 File Offset: 0x000D10B6
		public unsafe bool CastShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CastShadow) & ALandscapeProxy.__PropertyMask_CastShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CastShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CastShadow) & ~ALandscapeProxy.__PropertyMask_CastShadow) | (value ? ALandscapeProxy.__PropertyMask_CastShadow : 0));
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06008C42 RID: 35906 RVA: 0x000D2EE6 File Offset: 0x000D10E6
		// (set) Token: 0x06008C43 RID: 35907 RVA: 0x000D2EFF File Offset: 0x000D10FF
		public unsafe bool MobileCastShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MobileCastShadow) & ALandscapeProxy.__PropertyMask_MobileCastShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MobileCastShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_MobileCastShadow) & ~ALandscapeProxy.__PropertyMask_MobileCastShadow) | (value ? ALandscapeProxy.__PropertyMask_MobileCastShadow : 0));
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06008C44 RID: 35908 RVA: 0x000D2F2F File Offset: 0x000D112F
		// (set) Token: 0x06008C45 RID: 35909 RVA: 0x000D2F48 File Offset: 0x000D1148
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastDynamicShadow) & ALandscapeProxy.__PropertyMask_bCastDynamicShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastDynamicShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastDynamicShadow) & ~ALandscapeProxy.__PropertyMask_bCastDynamicShadow) | (value ? ALandscapeProxy.__PropertyMask_bCastDynamicShadow : 0));
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06008C46 RID: 35910 RVA: 0x000D2F78 File Offset: 0x000D1178
		// (set) Token: 0x06008C47 RID: 35911 RVA: 0x000D2F91 File Offset: 0x000D1191
		public unsafe bool bCastStaticShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastStaticShadow) & ALandscapeProxy.__PropertyMask_bCastStaticShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastStaticShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastStaticShadow) & ~ALandscapeProxy.__PropertyMask_bCastStaticShadow) | (value ? ALandscapeProxy.__PropertyMask_bCastStaticShadow : 0));
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06008C48 RID: 35912 RVA: 0x000D2FC1 File Offset: 0x000D11C1
		// (set) Token: 0x06008C49 RID: 35913 RVA: 0x000D2FDA File Offset: 0x000D11DA
		public unsafe bool bCastFarShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadow) & ALandscapeProxy.__PropertyMask_bCastFarShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadow) & ~ALandscapeProxy.__PropertyMask_bCastFarShadow) | (value ? ALandscapeProxy.__PropertyMask_bCastFarShadow : 0));
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x000D300A File Offset: 0x000D120A
		// (set) Token: 0x06008C4B RID: 35915 RVA: 0x000D3023 File Offset: 0x000D1223
		public unsafe bool bCastFarShadowOnMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadowOnMobile) & ALandscapeProxy.__PropertyMask_bCastFarShadowOnMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadowOnMobile) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastFarShadowOnMobile) & ~ALandscapeProxy.__PropertyMask_bCastFarShadowOnMobile) | (value ? ALandscapeProxy.__PropertyMask_bCastFarShadowOnMobile : 0));
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06008C4C RID: 35916 RVA: 0x000D3053 File Offset: 0x000D1253
		// (set) Token: 0x06008C4D RID: 35917 RVA: 0x000D306C File Offset: 0x000D126C
		public unsafe bool bCastContactShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastContactShadow) & ALandscapeProxy.__PropertyMask_bCastContactShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastContactShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastContactShadow) & ~ALandscapeProxy.__PropertyMask_bCastContactShadow) | (value ? ALandscapeProxy.__PropertyMask_bCastContactShadow : 0));
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06008C4E RID: 35918 RVA: 0x000D309C File Offset: 0x000D129C
		// (set) Token: 0x06008C4F RID: 35919 RVA: 0x000D30B5 File Offset: 0x000D12B5
		public unsafe bool bCastHiddenShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastHiddenShadow) & ALandscapeProxy.__PropertyMask_bCastHiddenShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastHiddenShadow) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastHiddenShadow) & ~ALandscapeProxy.__PropertyMask_bCastHiddenShadow) | (value ? ALandscapeProxy.__PropertyMask_bCastHiddenShadow : 0));
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06008C50 RID: 35920 RVA: 0x000D30E5 File Offset: 0x000D12E5
		// (set) Token: 0x06008C51 RID: 35921 RVA: 0x000D30FE File Offset: 0x000D12FE
		public unsafe bool bCastShadowAsTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastShadowAsTwoSided) & ALandscapeProxy.__PropertyMask_bCastShadowAsTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastShadowAsTwoSided) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bCastShadowAsTwoSided) & ~ALandscapeProxy.__PropertyMask_bCastShadowAsTwoSided) | (value ? ALandscapeProxy.__PropertyMask_bCastShadowAsTwoSided : 0));
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06008C52 RID: 35922 RVA: 0x000D312E File Offset: 0x000D132E
		// (set) Token: 0x06008C53 RID: 35923 RVA: 0x000D3147 File Offset: 0x000D1347
		public unsafe bool bAffectDistanceFieldLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bAffectDistanceFieldLighting) & ALandscapeProxy.__PropertyMask_bAffectDistanceFieldLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bAffectDistanceFieldLighting) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bAffectDistanceFieldLighting) & ~ALandscapeProxy.__PropertyMask_bAffectDistanceFieldLighting) | (value ? ALandscapeProxy.__PropertyMask_bAffectDistanceFieldLighting : 0));
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06008C54 RID: 35924 RVA: 0x000D3177 File Offset: 0x000D1377
		// (set) Token: 0x06008C55 RID: 35925 RVA: 0x000D3190 File Offset: 0x000D1390
		public unsafe bool bUseMaterialPositionOffsetInStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseMaterialPositionOffsetInStaticLighting) & ALandscapeProxy.__PropertyMask_bUseMaterialPositionOffsetInStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseMaterialPositionOffsetInStaticLighting) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseMaterialPositionOffsetInStaticLighting) & ~ALandscapeProxy.__PropertyMask_bUseMaterialPositionOffsetInStaticLighting) | (value ? ALandscapeProxy.__PropertyMask_bUseMaterialPositionOffsetInStaticLighting : 0));
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06008C56 RID: 35926 RVA: 0x000D31C0 File Offset: 0x000D13C0
		// (set) Token: 0x06008C57 RID: 35927 RVA: 0x000D31D9 File Offset: 0x000D13D9
		public unsafe bool bRenderCustomDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bRenderCustomDepth) & ALandscapeProxy.__PropertyMask_bRenderCustomDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bRenderCustomDepth) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bRenderCustomDepth) & ~ALandscapeProxy.__PropertyMask_bRenderCustomDepth) | (value ? ALandscapeProxy.__PropertyMask_bRenderCustomDepth : 0));
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06008C58 RID: 35928 RVA: 0x000D3209 File Offset: 0x000D1409
		// (set) Token: 0x06008C59 RID: 35929 RVA: 0x000D3219 File Offset: 0x000D1419
		public unsafe int CustomDepthStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CustomDepthStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CustomDepthStencilValue) = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06008C5A RID: 35930 RVA: 0x000D322A File Offset: 0x000D142A
		// (set) Token: 0x06008C5B RID: 35931 RVA: 0x000D323A File Offset: 0x000D143A
		public unsafe float LDMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LDMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LDMaxDrawDistance) = value;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06008C5C RID: 35932 RVA: 0x000D324B File Offset: 0x000D144B
		// (set) Token: 0x06008C5D RID: 35933 RVA: 0x000D325B File Offset: 0x000D145B
		public unsafe int KuroRenderingLODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroRenderingLODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroRenderingLODBias) = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06008C5E RID: 35934 RVA: 0x000D326C File Offset: 0x000D146C
		// (set) Token: 0x06008C5F RID: 35935 RVA: 0x000D327C File Offset: 0x000D147C
		public unsafe bool bKuroSkipPakLevelCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bKuroSkipPakLevelCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bKuroSkipPakLevelCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x000D328D File Offset: 0x000D148D
		// (set) Token: 0x06008C61 RID: 35937 RVA: 0x000D329D File Offset: 0x000D149D
		public unsafe int CollisionMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CollisionMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CollisionMipLevel) = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x000D32AE File Offset: 0x000D14AE
		// (set) Token: 0x06008C63 RID: 35939 RVA: 0x000D32BE File Offset: 0x000D14BE
		public unsafe int SimpleCollisionMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SimpleCollisionMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SimpleCollisionMipLevel) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06008C64 RID: 35940 RVA: 0x000D32CF File Offset: 0x000D14CF
		// (set) Token: 0x06008C65 RID: 35941 RVA: 0x000D32DF File Offset: 0x000D14DF
		public unsafe float CollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CollisionThickness) = value;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06008C66 RID: 35942 RVA: 0x000D32F0 File Offset: 0x000D14F0
		// (set) Token: 0x06008C67 RID: 35943 RVA: 0x000D3329 File Offset: 0x000D1529
		[Nullable(1)]
		public FBodyInstance BodyInstance
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._BodyInstance) == null)
				{
					result = (this._BodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_BodyInstance, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_BodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06008C68 RID: 35944 RVA: 0x000D334A File Offset: 0x000D154A
		// (set) Token: 0x06008C69 RID: 35945 RVA: 0x000D3363 File Offset: 0x000D1563
		public unsafe bool bGenerateOverlapEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bGenerateOverlapEvents) & ALandscapeProxy.__PropertyMask_bGenerateOverlapEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bGenerateOverlapEvents) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bGenerateOverlapEvents) & ~ALandscapeProxy.__PropertyMask_bGenerateOverlapEvents) | (value ? ALandscapeProxy.__PropertyMask_bGenerateOverlapEvents : 0));
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06008C6A RID: 35946 RVA: 0x000D3393 File Offset: 0x000D1593
		// (set) Token: 0x06008C6B RID: 35947 RVA: 0x000D33AC File Offset: 0x000D15AC
		public unsafe bool bBakeMaterialPositionOffsetIntoCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bBakeMaterialPositionOffsetIntoCollision) & ALandscapeProxy.__PropertyMask_bBakeMaterialPositionOffsetIntoCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bBakeMaterialPositionOffsetIntoCollision) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bBakeMaterialPositionOffsetIntoCollision) & ~ALandscapeProxy.__PropertyMask_bBakeMaterialPositionOffsetIntoCollision) | (value ? ALandscapeProxy.__PropertyMask_bBakeMaterialPositionOffsetIntoCollision : 0));
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06008C6C RID: 35948 RVA: 0x000D33DC File Offset: 0x000D15DC
		// (set) Token: 0x06008C6D RID: 35949 RVA: 0x000D33EC File Offset: 0x000D15EC
		public unsafe int ComponentSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_ComponentSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_ComponentSizeQuads) = value;
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x000D33FD File Offset: 0x000D15FD
		// (set) Token: 0x06008C6F RID: 35951 RVA: 0x000D340D File Offset: 0x000D160D
		public unsafe int SubsectionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SubsectionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_SubsectionSizeQuads) = value;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x000D341E File Offset: 0x000D161E
		// (set) Token: 0x06008C71 RID: 35953 RVA: 0x000D342E File Offset: 0x000D162E
		public unsafe int NumSubsections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NumSubsections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NumSubsections) = value;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x000D343F File Offset: 0x000D163F
		// (set) Token: 0x06008C73 RID: 35955 RVA: 0x000D3458 File Offset: 0x000D1658
		public unsafe bool bUsedForNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUsedForNavigation) & ALandscapeProxy.__PropertyMask_bUsedForNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUsedForNavigation) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUsedForNavigation) & ~ALandscapeProxy.__PropertyMask_bUsedForNavigation) | (value ? ALandscapeProxy.__PropertyMask_bUsedForNavigation : 0));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x000D3488 File Offset: 0x000D1688
		// (set) Token: 0x06008C75 RID: 35957 RVA: 0x000D34A1 File Offset: 0x000D16A1
		public unsafe bool bFillCollisionUnderLandscapeForNavmesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bFillCollisionUnderLandscapeForNavmesh) & ALandscapeProxy.__PropertyMask_bFillCollisionUnderLandscapeForNavmesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bFillCollisionUnderLandscapeForNavmesh) = ((*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bFillCollisionUnderLandscapeForNavmesh) & ~ALandscapeProxy.__PropertyMask_bFillCollisionUnderLandscapeForNavmesh) | (value ? ALandscapeProxy.__PropertyMask_bFillCollisionUnderLandscapeForNavmesh : 0));
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x000D34D1 File Offset: 0x000D16D1
		// (set) Token: 0x06008C77 RID: 35959 RVA: 0x000D34E1 File Offset: 0x000D16E1
		public unsafe bool bUseDynamicMaterialInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseDynamicMaterialInstance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseDynamicMaterialInstance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x000D34F2 File Offset: 0x000D16F2
		// (set) Token: 0x06008C79 RID: 35961 RVA: 0x000D3502 File Offset: 0x000D1702
		public unsafe bool bUseLandscapeForCullingInvisibleHLODVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseLandscapeForCullingInvisibleHLODVertices) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bUseLandscapeForCullingInvisibleHLODVertices) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06008C7A RID: 35962 RVA: 0x000D3513 File Offset: 0x000D1713
		// (set) Token: 0x06008C7B RID: 35963 RVA: 0x000D3523 File Offset: 0x000D1723
		public unsafe bool bHasLayersContent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bHasLayersContent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_bHasLayersContent) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x000D3534 File Offset: 0x000D1734
		public void SetLandscapeMaterialVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialVectorParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x000D3543 File Offset: 0x000D1743
		public void SetLandscapeMaterialTextureParameterValue(FName ParameterName, UTexture Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialTextureParameterValue_Internal(base.NativePtr, ParameterName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x000D3561 File Offset: 0x000D1761
		public void SetLandscapeMaterialScalarParameterValue(FName ParameterName, float Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialScalarParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x000D3570 File Offset: 0x000D1770
		[SkipLocalsInit]
		public unsafe static void SetKuroLandscapeFOVFactorByCamera(float InFOVFactor)
		{
			ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams* ptr = stackalloc ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFOVFactor = InFOVFactor;
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x000D35B8 File Offset: 0x000D17B8
		[SkipLocalsInit]
		public unsafe static void SetKuroLandscapeFOVFactor(float InFOVFactor)
		{
			ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__SetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFOVFactor = InFOVFactor;
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__SetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x000D3600 File Offset: 0x000D1800
		[SkipLocalsInit]
		public unsafe bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel = false, bool InExportLandscapeProxies = true)
		{
			ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams* ptr = stackalloc ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRenderTarget = ((InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
			ptr->InExportHeightIntoRGChannel = InExportHeightIntoRGChannel;
			ptr->InExportLandscapeProxies = InExportLandscapeProxies;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x000D366C File Offset: 0x000D186C
		[SkipLocalsInit]
		public unsafe static float GetKuroLandscapeFOVFactorByCamera()
		{
			ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams* ptr = stackalloc ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x000D36B0 File Offset: 0x000D18B0
		[SkipLocalsInit]
		public unsafe static float GetKuroLandscapeFOVFactor()
		{
			ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__GetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__GetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x000D36F4 File Offset: 0x000D18F4
		[SkipLocalsInit]
		public void GenerateLandscapeLayerParams()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__GenerateLandscapeLayerParams_NativeFunctionPtr, null);
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x000D3708 File Offset: 0x000D1908
		[SkipLocalsInit]
		public unsafe void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial)
		{
			ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams* ptr = stackalloc ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__EditorSetLandscapeMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewLandscapeMaterial = ((NewLandscapeMaterial != null) ? NewLandscapeMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__EditorSetLandscapeMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x000D3760 File Offset: 0x000D1960
		[SkipLocalsInit]
		public unsafe void EditorSetKuroColormapTexture(UTexture2D NewKuroColormapTexture)
		{
			ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams* ptr = stackalloc ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__EditorSetKuroColormapTexture_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewKuroColormapTexture = ((NewKuroColormapTexture != null) ? NewKuroColormapTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__EditorSetKuroColormapTexture_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x000D37B8 File Offset: 0x000D19B8
		[SkipLocalsInit]
		public unsafe void ChangeUseTessellationComponentScreenSizeFalloff(bool InComponentScreenSizeToUseSubSections)
		{
			ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InComponentScreenSizeToUseSubSections = InComponentScreenSizeToUseSubSections;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x000D3800 File Offset: 0x000D1A00
		[SkipLocalsInit]
		public unsafe void ChangeTessellationComponentScreenSizeFalloff(float InUseTessellationComponentScreenSizeFalloff)
		{
			ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InUseTessellationComponentScreenSizeFalloff = InUseTessellationComponentScreenSizeFalloff;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x000D3848 File Offset: 0x000D1A48
		[SkipLocalsInit]
		public unsafe void ChangeTessellationComponentScreenSize(float InTessellationComponentScreenSize)
		{
			ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeTessellationComponentScreenSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTessellationComponentScreenSize = InTessellationComponentScreenSize;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeTessellationComponentScreenSize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x000D3890 File Offset: 0x000D1A90
		[SkipLocalsInit]
		public unsafe void ChangeLODDistanceFactor(float InLODDistanceFactor)
		{
			ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeLODDistanceFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLODDistanceFactor = InLODDistanceFactor;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeLODDistanceFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x000D38D8 File Offset: 0x000D1AD8
		[SkipLocalsInit]
		public unsafe void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)
		{
			ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InComponentScreenSizeToUseSubSections = InComponentScreenSizeToUseSubSections;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008C8C RID: 35980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialVectorParameterValue_Internal(IntPtr @this, FName ParameterName, FLinearColor Value);

		// Token: 0x06008C8D RID: 35981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialTextureParameterValue_Internal(IntPtr @this, FName ParameterName, IntPtr Value);

		// Token: 0x06008C8E RID: 35982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialScalarParameterValue_Internal(IntPtr @this, FName ParameterName, float Value);

		// Token: 0x06008C8F RID: 35983 RVA: 0x000D391E File Offset: 0x000D1B1E
		static ALandscapeProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeProxy");
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x000D392C File Offset: 0x000D1B2C
		protected ALandscapeProxy() : this(BuiltinUtils.AllocNativeUObject(ALandscapeProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x000D3954 File Offset: 0x000D1B54
		protected ALandscapeProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CDC RID: 15580
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeProxy";

		// Token: 0x04003CDD RID: 15581
		private static IntPtr _ClassPtr;

		// Token: 0x04003CDE RID: 15582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CDF RID: 15583
		internal static int __PropertyOffset_LandscapeGuid;

		// Token: 0x04003CE0 RID: 15584
		internal static int __PropertyOffset_LandscapeSectionOffset;

		// Token: 0x04003CE1 RID: 15585
		internal static int __PropertyOffset_MaxLODLevel;

		// Token: 0x04003CE2 RID: 15586
		internal static int __PropertyOffset_LODDistanceFactor_DEPRECATED;

		// Token: 0x04003CE3 RID: 15587
		internal static int __PropertyOffset_ComponentScreenSizeToUseSubSections;

		// Token: 0x04003CE4 RID: 15588
		internal static int __PropertyOffset_LOD0ScreenSize;

		// Token: 0x04003CE5 RID: 15589
		internal static int __PropertyOffset_LOD0DistributionSetting;

		// Token: 0x04003CE6 RID: 15590
		internal static int __PropertyOffset_LODDistributionSetting;

		// Token: 0x04003CE7 RID: 15591
		internal static int __PropertyOffset_TessellationComponentScreenSize;

		// Token: 0x04003CE8 RID: 15592
		internal static int __PropertyOffset_UseTessellationComponentScreenSizeFalloff;

		// Token: 0x04003CE9 RID: 15593
		internal static int __PropertyOffset_TessellationComponentScreenSizeFalloff;

		// Token: 0x04003CEA RID: 15594
		internal static int __PropertyOffset_OccluderGeometryLOD;

		// Token: 0x04003CEB RID: 15595
		internal static int __PropertyOffset_StaticLightingLOD;

		// Token: 0x04003CEC RID: 15596
		internal static int __PropertyOffset_DefaultPhysMaterial;

		// Token: 0x04003CED RID: 15597
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x04003CEE RID: 15598
		internal static int __PropertyOffset_LandscapeMaterial;

		// Token: 0x04003CEF RID: 15599
		internal static int __PropertyOffset_LandscapeLayerParams;

		// Token: 0x04003CF0 RID: 15600
		private TArray<FVector4> _LandscapeLayerParams;

		// Token: 0x04003CF1 RID: 15601
		internal static int __PropertyOffset_UseLandscapeColormap;

		// Token: 0x04003CF2 RID: 15602
		internal static byte __PropertyMask_UseLandscapeColormap;

		// Token: 0x04003CF3 RID: 15603
		internal static int __PropertyOffset_KuroColormapTexture;

		// Token: 0x04003CF4 RID: 15604
		internal static int __PropertyOffset_SectionBaseMinAndRange;

		// Token: 0x04003CF5 RID: 15605
		internal static int __PropertyOffset_LandscapeHoleMaterial;

		// Token: 0x04003CF6 RID: 15606
		internal static int __PropertyOffset_bMeshHoles;

		// Token: 0x04003CF7 RID: 15607
		internal static int __PropertyOffset_MeshHolesMaxLod;

		// Token: 0x04003CF8 RID: 15608
		internal static int __PropertyOffset_VirtualTextureNumLods;

		// Token: 0x04003CF9 RID: 15609
		internal static int __PropertyOffset_VirtualTextureLodBias;

		// Token: 0x04003CFA RID: 15610
		internal static int __PropertyOffset_NegativeZBoundsExtension;

		// Token: 0x04003CFB RID: 15611
		internal static int __PropertyOffset_PositiveZBoundsExtension;

		// Token: 0x04003CFC RID: 15612
		internal static int __PropertyOffset_CollisionComponents;

		// Token: 0x04003CFD RID: 15613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeHeightfieldCollisionComponent> _CollisionComponents;

		// Token: 0x04003CFE RID: 15614
		internal static int __PropertyOffset_bHasLandscapeGrass;

		// Token: 0x04003CFF RID: 15615
		internal static int __PropertyOffset_StaticLightingResolution;

		// Token: 0x04003D00 RID: 15616
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x04003D01 RID: 15617
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x04003D02 RID: 15618
		internal static int __PropertyOffset_MobileCastShadow;

		// Token: 0x04003D03 RID: 15619
		internal static byte __PropertyMask_MobileCastShadow;

		// Token: 0x04003D04 RID: 15620
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x04003D05 RID: 15621
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x04003D06 RID: 15622
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x04003D07 RID: 15623
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x04003D08 RID: 15624
		internal static int __PropertyOffset_bCastFarShadow;

		// Token: 0x04003D09 RID: 15625
		internal static byte __PropertyMask_bCastFarShadow;

		// Token: 0x04003D0A RID: 15626
		internal static int __PropertyOffset_bCastFarShadowOnMobile;

		// Token: 0x04003D0B RID: 15627
		internal static byte __PropertyMask_bCastFarShadowOnMobile;

		// Token: 0x04003D0C RID: 15628
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x04003D0D RID: 15629
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x04003D0E RID: 15630
		internal static int __PropertyOffset_bCastHiddenShadow;

		// Token: 0x04003D0F RID: 15631
		internal static byte __PropertyMask_bCastHiddenShadow;

		// Token: 0x04003D10 RID: 15632
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x04003D11 RID: 15633
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x04003D12 RID: 15634
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x04003D13 RID: 15635
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x04003D14 RID: 15636
		internal static int __PropertyOffset_bUseMaterialPositionOffsetInStaticLighting;

		// Token: 0x04003D15 RID: 15637
		internal static byte __PropertyMask_bUseMaterialPositionOffsetInStaticLighting;

		// Token: 0x04003D16 RID: 15638
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x04003D17 RID: 15639
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x04003D18 RID: 15640
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x04003D19 RID: 15641
		internal static int __PropertyOffset_LDMaxDrawDistance;

		// Token: 0x04003D1A RID: 15642
		internal static int __PropertyOffset_KuroRenderingLODBias;

		// Token: 0x04003D1B RID: 15643
		internal static int __PropertyOffset_bKuroSkipPakLevelCook;

		// Token: 0x04003D1C RID: 15644
		internal static int __PropertyOffset_CollisionMipLevel;

		// Token: 0x04003D1D RID: 15645
		internal static int __PropertyOffset_SimpleCollisionMipLevel;

		// Token: 0x04003D1E RID: 15646
		internal static int __PropertyOffset_CollisionThickness;

		// Token: 0x04003D1F RID: 15647
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x04003D20 RID: 15648
		private FBodyInstance _BodyInstance;

		// Token: 0x04003D21 RID: 15649
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x04003D22 RID: 15650
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x04003D23 RID: 15651
		internal static int __PropertyOffset_bBakeMaterialPositionOffsetIntoCollision;

		// Token: 0x04003D24 RID: 15652
		internal static byte __PropertyMask_bBakeMaterialPositionOffsetIntoCollision;

		// Token: 0x04003D25 RID: 15653
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x04003D26 RID: 15654
		internal static int __PropertyOffset_SubsectionSizeQuads;

		// Token: 0x04003D27 RID: 15655
		internal static int __PropertyOffset_NumSubsections;

		// Token: 0x04003D28 RID: 15656
		internal static int __PropertyOffset_bUsedForNavigation;

		// Token: 0x04003D29 RID: 15657
		internal static byte __PropertyMask_bUsedForNavigation;

		// Token: 0x04003D2A RID: 15658
		internal static int __PropertyOffset_bFillCollisionUnderLandscapeForNavmesh;

		// Token: 0x04003D2B RID: 15659
		internal static byte __PropertyMask_bFillCollisionUnderLandscapeForNavmesh;

		// Token: 0x04003D2C RID: 15660
		internal static int __PropertyOffset_bUseDynamicMaterialInstance;

		// Token: 0x04003D2D RID: 15661
		internal static int __PropertyOffset_bUseLandscapeForCullingInvisibleHLODVertices;

		// Token: 0x04003D2E RID: 15662
		internal static int __PropertyOffset_bHasLayersContent;

		// Token: 0x04003D2F RID: 15663
		private static IntPtr __SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr;

		// Token: 0x04003D30 RID: 15664
		private static IntPtr __SetKuroLandscapeFOVFactor_NativeFunctionPtr;

		// Token: 0x04003D31 RID: 15665
		private static IntPtr __LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr;

		// Token: 0x04003D32 RID: 15666
		private static IntPtr __GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr;

		// Token: 0x04003D33 RID: 15667
		private static IntPtr __GetKuroLandscapeFOVFactor_NativeFunctionPtr;

		// Token: 0x04003D34 RID: 15668
		private static IntPtr __GenerateLandscapeLayerParams_NativeFunctionPtr;

		// Token: 0x04003D35 RID: 15669
		private static IntPtr __EditorSetLandscapeMaterial_NativeFunctionPtr;

		// Token: 0x04003D36 RID: 15670
		private static IntPtr __EditorSetKuroColormapTexture_NativeFunctionPtr;

		// Token: 0x04003D37 RID: 15671
		private static IntPtr __ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr;

		// Token: 0x04003D38 RID: 15672
		private static IntPtr __ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr;

		// Token: 0x04003D39 RID: 15673
		private static IntPtr __ChangeTessellationComponentScreenSize_NativeFunctionPtr;

		// Token: 0x04003D3A RID: 15674
		private static IntPtr __ChangeLODDistanceFactor_NativeFunctionPtr;

		// Token: 0x04003D3B RID: 15675
		private static IntPtr __ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr;

		// Token: 0x02000E56 RID: 3670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroLandscapeFOVFactorByCamera_FunctionParams
		{
			// Token: 0x040061F8 RID: 25080
			[FieldOffset(0)]
			public float InFOVFactor;
		}

		// Token: 0x02000E57 RID: 3671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroLandscapeFOVFactor_FunctionParams
		{
			// Token: 0x040061F9 RID: 25081
			[FieldOffset(0)]
			public float InFOVFactor;
		}

		// Token: 0x02000E58 RID: 3672
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LandscapeExportHeightmapToRenderTarget_FunctionParams
		{
			// Token: 0x040061FA RID: 25082
			[FieldOffset(0)]
			public IntPtr InRenderTarget;

			// Token: 0x040061FB RID: 25083
			[FieldOffset(8)]
			public bool InExportHeightIntoRGChannel;

			// Token: 0x040061FC RID: 25084
			[FieldOffset(9)]
			public bool InExportLandscapeProxies;

			// Token: 0x040061FD RID: 25085
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02000E59 RID: 3673
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroLandscapeFOVFactorByCamera_FunctionParams
		{
			// Token: 0x040061FE RID: 25086
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000E5A RID: 3674
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroLandscapeFOVFactor_FunctionParams
		{
			// Token: 0x040061FF RID: 25087
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000E5B RID: 3675
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EditorSetLandscapeMaterial_FunctionParams
		{
			// Token: 0x04006200 RID: 25088
			[FieldOffset(0)]
			public IntPtr NewLandscapeMaterial;
		}

		// Token: 0x02000E5C RID: 3676
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EditorSetKuroColormapTexture_FunctionParams
		{
			// Token: 0x04006201 RID: 25089
			[FieldOffset(0)]
			public IntPtr NewKuroColormapTexture;
		}

		// Token: 0x02000E5D RID: 3677
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams
		{
			// Token: 0x04006202 RID: 25090
			[FieldOffset(0)]
			public bool InComponentScreenSizeToUseSubSections;
		}

		// Token: 0x02000E5E RID: 3678
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeTessellationComponentScreenSizeFalloff_FunctionParams
		{
			// Token: 0x04006203 RID: 25091
			[FieldOffset(0)]
			public float InUseTessellationComponentScreenSizeFalloff;
		}

		// Token: 0x02000E5F RID: 3679
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeTessellationComponentScreenSize_FunctionParams
		{
			// Token: 0x04006204 RID: 25092
			[FieldOffset(0)]
			public float InTessellationComponentScreenSize;
		}

		// Token: 0x02000E60 RID: 3680
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeLODDistanceFactor_FunctionParams
		{
			// Token: 0x04006205 RID: 25093
			[FieldOffset(0)]
			public float InLODDistanceFactor;
		}

		// Token: 0x02000E61 RID: 3681
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeComponentScreenSizeToUseSubSections_FunctionParams
		{
			// Token: 0x04006206 RID: 25094
			[FieldOffset(0)]
			public float InComponentScreenSizeToUseSubSections;
		}
	}
}
