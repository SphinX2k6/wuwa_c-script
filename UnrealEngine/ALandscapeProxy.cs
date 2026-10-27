using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F85 RID: 8069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeProxy")]
	[UnrealStructLayout(2560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2560)]
	public abstract class ALandscapeProxy : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E9A7 RID: 125351 RVA: 0x002D7B1B File Offset: 0x002D5D1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeProxy._ClassPtr;
		}

		// Token: 0x170079C1 RID: 31169
		// (get) Token: 0x0601E9A8 RID: 125352 RVA: 0x002D7B27 File Offset: 0x002D5D27
		// (set) Token: 0x0601E9A9 RID: 125353 RVA: 0x002D7B3B File Offset: 0x002D5D3B
		[Nullable(2)]
		public unsafe ULandscapeSplinesComponent SplineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeSplinesComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_SplineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x170079C2 RID: 31170
		// (get) Token: 0x0601E9AA RID: 125354 RVA: 0x002D7B50 File Offset: 0x002D5D50
		// (set) Token: 0x0601E9AB RID: 125355 RVA: 0x002D7B64 File Offset: 0x002D5D64
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

		// Token: 0x170079C3 RID: 31171
		// (get) Token: 0x0601E9AC RID: 125356 RVA: 0x002D7B79 File Offset: 0x002D5D79
		// (set) Token: 0x0601E9AD RID: 125357 RVA: 0x002D7B8D File Offset: 0x002D5D8D
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

		// Token: 0x170079C4 RID: 31172
		// (get) Token: 0x0601E9AE RID: 125358 RVA: 0x002D7BA2 File Offset: 0x002D5DA2
		// (set) Token: 0x0601E9AF RID: 125359 RVA: 0x002D7BB2 File Offset: 0x002D5DB2
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

		// Token: 0x170079C5 RID: 31173
		// (get) Token: 0x0601E9B0 RID: 125360 RVA: 0x002D7BC3 File Offset: 0x002D5DC3
		// (set) Token: 0x0601E9B1 RID: 125361 RVA: 0x002D7BD3 File Offset: 0x002D5DD3
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

		// Token: 0x170079C6 RID: 31174
		// (get) Token: 0x0601E9B2 RID: 125362 RVA: 0x002D7BE4 File Offset: 0x002D5DE4
		// (set) Token: 0x0601E9B3 RID: 125363 RVA: 0x002D7BF8 File Offset: 0x002D5DF8
		[Nullable(0)]
		public unsafe TEnumAsByte<ELandscapeLODFalloff> LODFalloff_DEPRECATED
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODFalloff_DEPRECATED);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LODFalloff_DEPRECATED) = value;
			}
		}

		// Token: 0x170079C7 RID: 31175
		// (get) Token: 0x0601E9B4 RID: 125364 RVA: 0x002D7C0D File Offset: 0x002D5E0D
		// (set) Token: 0x0601E9B5 RID: 125365 RVA: 0x002D7C1D File Offset: 0x002D5E1D
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

		// Token: 0x170079C8 RID: 31176
		// (get) Token: 0x0601E9B6 RID: 125366 RVA: 0x002D7C2E File Offset: 0x002D5E2E
		// (set) Token: 0x0601E9B7 RID: 125367 RVA: 0x002D7C3E File Offset: 0x002D5E3E
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

		// Token: 0x170079C9 RID: 31177
		// (get) Token: 0x0601E9B8 RID: 125368 RVA: 0x002D7C4F File Offset: 0x002D5E4F
		// (set) Token: 0x0601E9B9 RID: 125369 RVA: 0x002D7C5F File Offset: 0x002D5E5F
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

		// Token: 0x170079CA RID: 31178
		// (get) Token: 0x0601E9BA RID: 125370 RVA: 0x002D7C70 File Offset: 0x002D5E70
		// (set) Token: 0x0601E9BB RID: 125371 RVA: 0x002D7C80 File Offset: 0x002D5E80
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

		// Token: 0x170079CB RID: 31179
		// (get) Token: 0x0601E9BC RID: 125372 RVA: 0x002D7C91 File Offset: 0x002D5E91
		// (set) Token: 0x0601E9BD RID: 125373 RVA: 0x002D7CA1 File Offset: 0x002D5EA1
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

		// Token: 0x170079CC RID: 31180
		// (get) Token: 0x0601E9BE RID: 125374 RVA: 0x002D7CB2 File Offset: 0x002D5EB2
		// (set) Token: 0x0601E9BF RID: 125375 RVA: 0x002D7CC2 File Offset: 0x002D5EC2
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

		// Token: 0x170079CD RID: 31181
		// (get) Token: 0x0601E9C0 RID: 125376 RVA: 0x002D7CD3 File Offset: 0x002D5ED3
		// (set) Token: 0x0601E9C1 RID: 125377 RVA: 0x002D7CE3 File Offset: 0x002D5EE3
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

		// Token: 0x170079CE RID: 31182
		// (get) Token: 0x0601E9C2 RID: 125378 RVA: 0x002D7CF4 File Offset: 0x002D5EF4
		// (set) Token: 0x0601E9C3 RID: 125379 RVA: 0x002D7D04 File Offset: 0x002D5F04
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

		// Token: 0x170079CF RID: 31183
		// (get) Token: 0x0601E9C4 RID: 125380 RVA: 0x002D7D15 File Offset: 0x002D5F15
		// (set) Token: 0x0601E9C5 RID: 125381 RVA: 0x002D7D25 File Offset: 0x002D5F25
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

		// Token: 0x170079D0 RID: 31184
		// (get) Token: 0x0601E9C6 RID: 125382 RVA: 0x002D7D36 File Offset: 0x002D5F36
		// (set) Token: 0x0601E9C7 RID: 125383 RVA: 0x002D7D4A File Offset: 0x002D5F4A
		[Nullable(2)]
		public unsafe UPhysicalMaterial DefaultPhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_DefaultPhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_DefaultPhysMaterial, value);
			}
		}

		// Token: 0x170079D1 RID: 31185
		// (get) Token: 0x0601E9C8 RID: 125384 RVA: 0x002D7D5F File Offset: 0x002D5F5F
		// (set) Token: 0x0601E9C9 RID: 125385 RVA: 0x002D7D6F File Offset: 0x002D5F6F
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

		// Token: 0x170079D2 RID: 31186
		// (get) Token: 0x0601E9CA RID: 125386 RVA: 0x002D7D80 File Offset: 0x002D5F80
		// (set) Token: 0x0601E9CB RID: 125387 RVA: 0x002D7D94 File Offset: 0x002D5F94
		[Nullable(2)]
		public unsafe UMaterialInterface LandscapeMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeMaterial, value);
			}
		}

		// Token: 0x170079D3 RID: 31187
		// (get) Token: 0x0601E9CC RID: 125388 RVA: 0x002D7DAC File Offset: 0x002D5FAC
		// (set) Token: 0x0601E9CD RID: 125389 RVA: 0x002D7DE5 File Offset: 0x002D5FE5
		public TArray<FVector4> LandscapeLayerParams
		{
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
			set
			{
				this.LandscapeLayerParams.CopyAssign(value);
			}
		}

		// Token: 0x170079D4 RID: 31188
		// (get) Token: 0x0601E9CE RID: 125390 RVA: 0x002D7DF3 File Offset: 0x002D5FF3
		// (set) Token: 0x0601E9CF RID: 125391 RVA: 0x002D7E0C File Offset: 0x002D600C
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

		// Token: 0x170079D5 RID: 31189
		// (get) Token: 0x0601E9D0 RID: 125392 RVA: 0x002D7E3C File Offset: 0x002D603C
		// (set) Token: 0x0601E9D1 RID: 125393 RVA: 0x002D7E50 File Offset: 0x002D6050
		[Nullable(2)]
		public unsafe UTexture2D KuroColormapTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_KuroColormapTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_KuroColormapTexture, value);
			}
		}

		// Token: 0x170079D6 RID: 31190
		// (get) Token: 0x0601E9D2 RID: 125394 RVA: 0x002D7E65 File Offset: 0x002D6065
		// (set) Token: 0x0601E9D3 RID: 125395 RVA: 0x002D7E79 File Offset: 0x002D6079
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

		// Token: 0x170079D7 RID: 31191
		// (get) Token: 0x0601E9D4 RID: 125396 RVA: 0x002D7E8E File Offset: 0x002D608E
		// (set) Token: 0x0601E9D5 RID: 125397 RVA: 0x002D7EA2 File Offset: 0x002D60A2
		[Nullable(2)]
		public unsafe UMaterialInterface LandscapeHoleMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeHoleMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeHoleMaterial, value);
			}
		}

		// Token: 0x170079D8 RID: 31192
		// (get) Token: 0x0601E9D6 RID: 125398 RVA: 0x002D7EB8 File Offset: 0x002D60B8
		// (set) Token: 0x0601E9D7 RID: 125399 RVA: 0x002D7EF1 File Offset: 0x002D60F1
		public TArray<FLandscapeProxyMaterialOverride> LandscapeMaterialsOverride
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeProxyMaterialOverride> result;
				if ((result = this._LandscapeMaterialsOverride) == null)
				{
					result = (this._LandscapeMaterialsOverride = new TArray<FLandscapeProxyMaterialOverride>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeMaterialsOverride, this));
				}
				return result;
			}
			set
			{
				this.LandscapeMaterialsOverride.CopyAssign(value);
			}
		}

		// Token: 0x170079D9 RID: 31193
		// (get) Token: 0x0601E9D8 RID: 125400 RVA: 0x002D7F00 File Offset: 0x002D6100
		// (set) Token: 0x0601E9D9 RID: 125401 RVA: 0x002D7F39 File Offset: 0x002D6139
		public TArray<FLandscapeProxyCustomLayerPhysicalMaterial> CustomLayerPhysicalMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeProxyCustomLayerPhysicalMaterial> result;
				if ((result = this._CustomLayerPhysicalMaterial) == null)
				{
					result = (this._CustomLayerPhysicalMaterial = new TArray<FLandscapeProxyCustomLayerPhysicalMaterial>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CustomLayerPhysicalMaterial, this));
				}
				return result;
			}
			set
			{
				this.CustomLayerPhysicalMaterial.CopyAssign(value);
			}
		}

		// Token: 0x170079DA RID: 31194
		// (get) Token: 0x0601E9DA RID: 125402 RVA: 0x002D7F47 File Offset: 0x002D6147
		// (set) Token: 0x0601E9DB RID: 125403 RVA: 0x002D7F57 File Offset: 0x002D6157
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

		// Token: 0x170079DB RID: 31195
		// (get) Token: 0x0601E9DC RID: 125404 RVA: 0x002D7F68 File Offset: 0x002D6168
		// (set) Token: 0x0601E9DD RID: 125405 RVA: 0x002D7F78 File Offset: 0x002D6178
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

		// Token: 0x170079DC RID: 31196
		// (get) Token: 0x0601E9DE RID: 125406 RVA: 0x002D7F8C File Offset: 0x002D618C
		// (set) Token: 0x0601E9DF RID: 125407 RVA: 0x002D7FC5 File Offset: 0x002D61C5
		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URuntimeVirtualTexture> result;
				if ((result = this._RuntimeVirtualTextures) == null)
				{
					result = (this._RuntimeVirtualTextures = new TArray<URuntimeVirtualTexture>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_RuntimeVirtualTextures, this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextures.CopyAssign(value);
			}
		}

		// Token: 0x170079DD RID: 31197
		// (get) Token: 0x0601E9E0 RID: 125408 RVA: 0x002D7FD3 File Offset: 0x002D61D3
		// (set) Token: 0x0601E9E1 RID: 125409 RVA: 0x002D7FE3 File Offset: 0x002D61E3
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

		// Token: 0x170079DE RID: 31198
		// (get) Token: 0x0601E9E2 RID: 125410 RVA: 0x002D7FF4 File Offset: 0x002D61F4
		// (set) Token: 0x0601E9E3 RID: 125411 RVA: 0x002D8004 File Offset: 0x002D6204
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

		// Token: 0x170079DF RID: 31199
		// (get) Token: 0x0601E9E4 RID: 125412 RVA: 0x002D8015 File Offset: 0x002D6215
		// (set) Token: 0x0601E9E5 RID: 125413 RVA: 0x002D8025 File Offset: 0x002D6225
		public unsafe ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
		{
			get
			{
				return (ERuntimeVirtualTextureMainPassType)(*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureRenderPassType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_VirtualTextureRenderPassType) = (byte)value;
			}
		}

		// Token: 0x170079E0 RID: 31200
		// (get) Token: 0x0601E9E6 RID: 125414 RVA: 0x002D8036 File Offset: 0x002D6236
		// (set) Token: 0x0601E9E7 RID: 125415 RVA: 0x002D8046 File Offset: 0x002D6246
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

		// Token: 0x170079E1 RID: 31201
		// (get) Token: 0x0601E9E8 RID: 125416 RVA: 0x002D8057 File Offset: 0x002D6257
		// (set) Token: 0x0601E9E9 RID: 125417 RVA: 0x002D8067 File Offset: 0x002D6267
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

		// Token: 0x170079E2 RID: 31202
		// (get) Token: 0x0601E9EA RID: 125418 RVA: 0x002D8078 File Offset: 0x002D6278
		// (set) Token: 0x0601E9EB RID: 125419 RVA: 0x002D80B1 File Offset: 0x002D62B1
		public TArray<ULandscapeComponent> LandscapeComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeComponent> result;
				if ((result = this._LandscapeComponents) == null)
				{
					result = (this._LandscapeComponents = new TArray<ULandscapeComponent>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LandscapeComponents, this));
				}
				return result;
			}
			set
			{
				this.LandscapeComponents.CopyAssign(value);
			}
		}

		// Token: 0x170079E3 RID: 31203
		// (get) Token: 0x0601E9EC RID: 125420 RVA: 0x002D80BF File Offset: 0x002D62BF
		// (set) Token: 0x0601E9ED RID: 125421 RVA: 0x002D80D3 File Offset: 0x002D62D3
		[Nullable(2)]
		public unsafe ULandscapeBatchComponent LandscapeBatch
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeBatchComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeBatch);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeProxy.__PropertyOffset_LandscapeBatch, value);
			}
		}

		// Token: 0x170079E4 RID: 31204
		// (get) Token: 0x0601E9EE RID: 125422 RVA: 0x002D80E8 File Offset: 0x002D62E8
		// (set) Token: 0x0601E9EF RID: 125423 RVA: 0x002D8121 File Offset: 0x002D6321
		public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents
		{
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
			set
			{
				this.CollisionComponents.CopyAssign(value);
			}
		}

		// Token: 0x170079E5 RID: 31205
		// (get) Token: 0x0601E9F0 RID: 125424 RVA: 0x002D8130 File Offset: 0x002D6330
		// (set) Token: 0x0601E9F1 RID: 125425 RVA: 0x002D8169 File Offset: 0x002D6369
		public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHierarchicalInstancedStaticMeshComponent> result;
				if ((result = this._FoliageComponents) == null)
				{
					result = (this._FoliageComponents = new TArray<UHierarchicalInstancedStaticMeshComponent>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_FoliageComponents, this));
				}
				return result;
			}
			set
			{
				this.FoliageComponents.CopyAssign(value);
			}
		}

		// Token: 0x170079E6 RID: 31206
		// (get) Token: 0x0601E9F2 RID: 125426 RVA: 0x002D8177 File Offset: 0x002D6377
		// (set) Token: 0x0601E9F3 RID: 125427 RVA: 0x002D8187 File Offset: 0x002D6387
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

		// Token: 0x170079E7 RID: 31207
		// (get) Token: 0x0601E9F4 RID: 125428 RVA: 0x002D8198 File Offset: 0x002D6398
		// (set) Token: 0x0601E9F5 RID: 125429 RVA: 0x002D81A8 File Offset: 0x002D63A8
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

		// Token: 0x170079E8 RID: 31208
		// (get) Token: 0x0601E9F6 RID: 125430 RVA: 0x002D81B9 File Offset: 0x002D63B9
		// (set) Token: 0x0601E9F7 RID: 125431 RVA: 0x002D81D2 File Offset: 0x002D63D2
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

		// Token: 0x170079E9 RID: 31209
		// (get) Token: 0x0601E9F8 RID: 125432 RVA: 0x002D8202 File Offset: 0x002D6402
		// (set) Token: 0x0601E9F9 RID: 125433 RVA: 0x002D821B File Offset: 0x002D641B
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

		// Token: 0x170079EA RID: 31210
		// (get) Token: 0x0601E9FA RID: 125434 RVA: 0x002D824B File Offset: 0x002D644B
		// (set) Token: 0x0601E9FB RID: 125435 RVA: 0x002D8264 File Offset: 0x002D6464
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

		// Token: 0x170079EB RID: 31211
		// (get) Token: 0x0601E9FC RID: 125436 RVA: 0x002D8294 File Offset: 0x002D6494
		// (set) Token: 0x0601E9FD RID: 125437 RVA: 0x002D82AD File Offset: 0x002D64AD
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

		// Token: 0x170079EC RID: 31212
		// (get) Token: 0x0601E9FE RID: 125438 RVA: 0x002D82DD File Offset: 0x002D64DD
		// (set) Token: 0x0601E9FF RID: 125439 RVA: 0x002D82F6 File Offset: 0x002D64F6
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

		// Token: 0x170079ED RID: 31213
		// (get) Token: 0x0601EA00 RID: 125440 RVA: 0x002D8326 File Offset: 0x002D6526
		// (set) Token: 0x0601EA01 RID: 125441 RVA: 0x002D833F File Offset: 0x002D653F
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

		// Token: 0x170079EE RID: 31214
		// (get) Token: 0x0601EA02 RID: 125442 RVA: 0x002D836F File Offset: 0x002D656F
		// (set) Token: 0x0601EA03 RID: 125443 RVA: 0x002D8388 File Offset: 0x002D6588
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

		// Token: 0x170079EF RID: 31215
		// (get) Token: 0x0601EA04 RID: 125444 RVA: 0x002D83B8 File Offset: 0x002D65B8
		// (set) Token: 0x0601EA05 RID: 125445 RVA: 0x002D83D1 File Offset: 0x002D65D1
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

		// Token: 0x170079F0 RID: 31216
		// (get) Token: 0x0601EA06 RID: 125446 RVA: 0x002D8401 File Offset: 0x002D6601
		// (set) Token: 0x0601EA07 RID: 125447 RVA: 0x002D841A File Offset: 0x002D661A
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

		// Token: 0x170079F1 RID: 31217
		// (get) Token: 0x0601EA08 RID: 125448 RVA: 0x002D844A File Offset: 0x002D664A
		// (set) Token: 0x0601EA09 RID: 125449 RVA: 0x002D8463 File Offset: 0x002D6663
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

		// Token: 0x170079F2 RID: 31218
		// (get) Token: 0x0601EA0A RID: 125450 RVA: 0x002D8494 File Offset: 0x002D6694
		// (set) Token: 0x0601EA0B RID: 125451 RVA: 0x002D84CD File Offset: 0x002D66CD
		public FLightingChannels LightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LightingChannels, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170079F3 RID: 31219
		// (get) Token: 0x0601EA0C RID: 125452 RVA: 0x002D84EE File Offset: 0x002D66EE
		// (set) Token: 0x0601EA0D RID: 125453 RVA: 0x002D8507 File Offset: 0x002D6707
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

		// Token: 0x170079F4 RID: 31220
		// (get) Token: 0x0601EA0E RID: 125454 RVA: 0x002D8537 File Offset: 0x002D6737
		// (set) Token: 0x0601EA0F RID: 125455 RVA: 0x002D8550 File Offset: 0x002D6750
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

		// Token: 0x170079F5 RID: 31221
		// (get) Token: 0x0601EA10 RID: 125456 RVA: 0x002D8580 File Offset: 0x002D6780
		// (set) Token: 0x0601EA11 RID: 125457 RVA: 0x002D8590 File Offset: 0x002D6790
		public unsafe ERendererStencilMask CustomDepthStencilWriteMask
		{
			get
			{
				return (ERendererStencilMask)(*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CustomDepthStencilWriteMask));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_CustomDepthStencilWriteMask) = (byte)value;
			}
		}

		// Token: 0x170079F6 RID: 31222
		// (get) Token: 0x0601EA12 RID: 125458 RVA: 0x002D85A1 File Offset: 0x002D67A1
		// (set) Token: 0x0601EA13 RID: 125459 RVA: 0x002D85B1 File Offset: 0x002D67B1
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

		// Token: 0x170079F7 RID: 31223
		// (get) Token: 0x0601EA14 RID: 125460 RVA: 0x002D85C2 File Offset: 0x002D67C2
		// (set) Token: 0x0601EA15 RID: 125461 RVA: 0x002D85D2 File Offset: 0x002D67D2
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

		// Token: 0x170079F8 RID: 31224
		// (get) Token: 0x0601EA16 RID: 125462 RVA: 0x002D85E3 File Offset: 0x002D67E3
		// (set) Token: 0x0601EA17 RID: 125463 RVA: 0x002D85F3 File Offset: 0x002D67F3
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

		// Token: 0x170079F9 RID: 31225
		// (get) Token: 0x0601EA18 RID: 125464 RVA: 0x002D8604 File Offset: 0x002D6804
		// (set) Token: 0x0601EA19 RID: 125465 RVA: 0x002D8614 File Offset: 0x002D6814
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

		// Token: 0x170079FA RID: 31226
		// (get) Token: 0x0601EA1A RID: 125466 RVA: 0x002D8625 File Offset: 0x002D6825
		// (set) Token: 0x0601EA1B RID: 125467 RVA: 0x002D8635 File Offset: 0x002D6835
		public unsafe EKuroForceClassify KuroForceClassifyPC
		{
			get
			{
				return (EKuroForceClassify)(*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroForceClassifyPC));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroForceClassifyPC) = (byte)value;
			}
		}

		// Token: 0x170079FB RID: 31227
		// (get) Token: 0x0601EA1C RID: 125468 RVA: 0x002D8646 File Offset: 0x002D6846
		// (set) Token: 0x0601EA1D RID: 125469 RVA: 0x002D8656 File Offset: 0x002D6856
		public unsafe EKuroForceClassify KuroForceClassifyMobile
		{
			get
			{
				return (EKuroForceClassify)(*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroForceClassifyMobile));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_KuroForceClassifyMobile) = (byte)value;
			}
		}

		// Token: 0x170079FC RID: 31228
		// (get) Token: 0x0601EA1E RID: 125470 RVA: 0x002D8668 File Offset: 0x002D6868
		// (set) Token: 0x0601EA1F RID: 125471 RVA: 0x002D86A1 File Offset: 0x002D68A1
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLightmassPrimitiveSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassPrimitiveSettings(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassPrimitiveSettings.StaticStruct(), base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170079FD RID: 31229
		// (get) Token: 0x0601EA20 RID: 125472 RVA: 0x002D86C2 File Offset: 0x002D68C2
		// (set) Token: 0x0601EA21 RID: 125473 RVA: 0x002D86D2 File Offset: 0x002D68D2
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

		// Token: 0x170079FE RID: 31230
		// (get) Token: 0x0601EA22 RID: 125474 RVA: 0x002D86E3 File Offset: 0x002D68E3
		// (set) Token: 0x0601EA23 RID: 125475 RVA: 0x002D86F3 File Offset: 0x002D68F3
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

		// Token: 0x170079FF RID: 31231
		// (get) Token: 0x0601EA24 RID: 125476 RVA: 0x002D8704 File Offset: 0x002D6904
		// (set) Token: 0x0601EA25 RID: 125477 RVA: 0x002D8714 File Offset: 0x002D6914
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

		// Token: 0x17007A00 RID: 31232
		// (get) Token: 0x0601EA26 RID: 125478 RVA: 0x002D8728 File Offset: 0x002D6928
		// (set) Token: 0x0601EA27 RID: 125479 RVA: 0x002D8761 File Offset: 0x002D6961
		public FBodyInstance BodyInstance
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_BodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A01 RID: 31233
		// (get) Token: 0x0601EA28 RID: 125480 RVA: 0x002D8782 File Offset: 0x002D6982
		// (set) Token: 0x0601EA29 RID: 125481 RVA: 0x002D879B File Offset: 0x002D699B
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

		// Token: 0x17007A02 RID: 31234
		// (get) Token: 0x0601EA2A RID: 125482 RVA: 0x002D87CB File Offset: 0x002D69CB
		// (set) Token: 0x0601EA2B RID: 125483 RVA: 0x002D87E4 File Offset: 0x002D69E4
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

		// Token: 0x17007A03 RID: 31235
		// (get) Token: 0x0601EA2C RID: 125484 RVA: 0x002D8814 File Offset: 0x002D6A14
		// (set) Token: 0x0601EA2D RID: 125485 RVA: 0x002D8824 File Offset: 0x002D6A24
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

		// Token: 0x17007A04 RID: 31236
		// (get) Token: 0x0601EA2E RID: 125486 RVA: 0x002D8835 File Offset: 0x002D6A35
		// (set) Token: 0x0601EA2F RID: 125487 RVA: 0x002D8845 File Offset: 0x002D6A45
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

		// Token: 0x17007A05 RID: 31237
		// (get) Token: 0x0601EA30 RID: 125488 RVA: 0x002D8856 File Offset: 0x002D6A56
		// (set) Token: 0x0601EA31 RID: 125489 RVA: 0x002D8866 File Offset: 0x002D6A66
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

		// Token: 0x17007A06 RID: 31238
		// (get) Token: 0x0601EA32 RID: 125490 RVA: 0x002D8877 File Offset: 0x002D6A77
		// (set) Token: 0x0601EA33 RID: 125491 RVA: 0x002D8890 File Offset: 0x002D6A90
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

		// Token: 0x17007A07 RID: 31239
		// (get) Token: 0x0601EA34 RID: 125492 RVA: 0x002D88C0 File Offset: 0x002D6AC0
		// (set) Token: 0x0601EA35 RID: 125493 RVA: 0x002D88D9 File Offset: 0x002D6AD9
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

		// Token: 0x17007A08 RID: 31240
		// (get) Token: 0x0601EA36 RID: 125494 RVA: 0x002D8909 File Offset: 0x002D6B09
		// (set) Token: 0x0601EA37 RID: 125495 RVA: 0x002D8919 File Offset: 0x002D6B19
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

		// Token: 0x17007A09 RID: 31241
		// (get) Token: 0x0601EA38 RID: 125496 RVA: 0x002D892A File Offset: 0x002D6B2A
		// (set) Token: 0x0601EA39 RID: 125497 RVA: 0x002D893A File Offset: 0x002D6B3A
		public unsafe ENavDataGatheringMode NavigationGeometryGatheringMode
		{
			get
			{
				return (ENavDataGatheringMode)(*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NavigationGeometryGatheringMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_NavigationGeometryGatheringMode) = (byte)value;
			}
		}

		// Token: 0x17007A0A RID: 31242
		// (get) Token: 0x0601EA3A RID: 125498 RVA: 0x002D894B File Offset: 0x002D6B4B
		// (set) Token: 0x0601EA3B RID: 125499 RVA: 0x002D895B File Offset: 0x002D6B5B
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

		// Token: 0x17007A0B RID: 31243
		// (get) Token: 0x0601EA3C RID: 125500 RVA: 0x002D896C File Offset: 0x002D6B6C
		// (set) Token: 0x0601EA3D RID: 125501 RVA: 0x002D897C File Offset: 0x002D6B7C
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

		// Token: 0x17007A0C RID: 31244
		// (get) Token: 0x0601EA3E RID: 125502 RVA: 0x002D8990 File Offset: 0x002D6B90
		// (set) Token: 0x0601EA3F RID: 125503 RVA: 0x002D89C9 File Offset: 0x002D6BC9
		public TMap<UTexture2D, ULandscapeWeightmapUsage> WeightmapUsageMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UTexture2D, ULandscapeWeightmapUsage> result;
				if ((result = this._WeightmapUsageMap) == null)
				{
					result = (this._WeightmapUsageMap = new TMap<UTexture2D, ULandscapeWeightmapUsage>(base.NativePtr + (IntPtr)ALandscapeProxy.__PropertyOffset_WeightmapUsageMap, this));
				}
				return result;
			}
			set
			{
				this.WeightmapUsageMap.CopyAssign(value);
			}
		}

		// Token: 0x0601EA40 RID: 125504 RVA: 0x002D89D7 File Offset: 0x002D6BD7
		public void SetLandscapeMaterialVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialVectorParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x0601EA41 RID: 125505 RVA: 0x002D89E6 File Offset: 0x002D6BE6
		[NullableContext(2)]
		public void SetLandscapeMaterialTextureParameterValue(FName ParameterName, UTexture Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialTextureParameterValue_Internal(base.NativePtr, ParameterName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601EA42 RID: 125506 RVA: 0x002D8A04 File Offset: 0x002D6C04
		public void SetLandscapeMaterialScalarParameterValue(FName ParameterName, float Value)
		{
			ALandscapeProxy.__SetLandscapeMaterialScalarParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x0601EA43 RID: 125507 RVA: 0x002D8A14 File Offset: 0x002D6C14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetKuroLandscapeFOVFactorByCamera(float InFOVFactor)
		{
			ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams* ptr = stackalloc ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFOVFactor = InFOVFactor;
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA44 RID: 125508 RVA: 0x002D8A5C File Offset: 0x002D6C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetKuroLandscapeFOVFactor(float InFOVFactor)
		{
			ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__SetKuroLandscapeFOVFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__SetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InFOVFactor = InFOVFactor;
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__SetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA45 RID: 125509 RVA: 0x002D8AA4 File Offset: 0x002D6CA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel = false, bool InExportLandscapeProxies = true)
		{
			ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams* ptr = stackalloc ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InRenderTarget = ((InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
			ptr->InExportHeightIntoRGChannel = InExportHeightIntoRGChannel;
			ptr->InExportLandscapeProxies = InExportLandscapeProxies;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601EA46 RID: 125510 RVA: 0x002D8B10 File Offset: 0x002D6D10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float GetKuroLandscapeFOVFactorByCamera()
		{
			ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams* ptr = stackalloc ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601EA47 RID: 125511 RVA: 0x002D8B58 File Offset: 0x002D6D58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float GetKuroLandscapeFOVFactor()
		{
			ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__GetKuroLandscapeFOVFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__GetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(ALandscapeProxy._ClassDefaultObjectPtr, ALandscapeProxy.__GetKuroLandscapeFOVFactor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601EA48 RID: 125512 RVA: 0x002D8B9D File Offset: 0x002D6D9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void GenerateLandscapeLayerParams()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__GenerateLandscapeLayerParams_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601EA49 RID: 125513 RVA: 0x002D8BB4 File Offset: 0x002D6DB4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial)
		{
			ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams* ptr = stackalloc ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ALandscapeProxy.__EditorSetLandscapeMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__EditorSetLandscapeMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewLandscapeMaterial = ((NewLandscapeMaterial != null) ? NewLandscapeMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__EditorSetLandscapeMaterial_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4A RID: 125514 RVA: 0x002D8C0C File Offset: 0x002D6E0C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EditorSetKuroColormapTexture(UTexture2D NewKuroColormapTexture)
		{
			ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams* ptr = stackalloc ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ALandscapeProxy.__EditorSetKuroColormapTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__EditorSetKuroColormapTexture_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewKuroColormapTexture = ((NewKuroColormapTexture != null) ? NewKuroColormapTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__EditorSetKuroColormapTexture_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4B RID: 125515 RVA: 0x002D8C64 File Offset: 0x002D6E64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EditorApplySpline(USplineComponent InSplineComponent, float StartWidth = 200f, float EndWidth = 200f, float StartSideFalloff = 200f, float EndSideFalloff = 200f, float StartRoll = 0f, float EndRoll = 0f, int NumSubdivisions = 20, bool bRaiseHeights = true, bool bLowerHeights = true, ULandscapeLayerInfoObject PaintLayer = null, FName? EditLayerName = null)
		{
			ALandscapeProxy.__EditorApplySpline_FunctionParams* ptr = stackalloc ALandscapeProxy.__EditorApplySpline_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(ALandscapeProxy.__EditorApplySpline_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__EditorApplySpline_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSplineComponent = ((InSplineComponent != null) ? InSplineComponent.NativePtr : IntPtr.Zero);
			ptr->StartWidth = StartWidth;
			ptr->EndWidth = EndWidth;
			ptr->StartSideFalloff = StartSideFalloff;
			ptr->EndSideFalloff = EndSideFalloff;
			ptr->StartRoll = StartRoll;
			ptr->EndRoll = EndRoll;
			ptr->NumSubdivisions = NumSubdivisions;
			ptr->bRaiseHeights = bRaiseHeights;
			ptr->bLowerHeights = bLowerHeights;
			ptr->PaintLayer = ((PaintLayer != null) ? PaintLayer.NativePtr : IntPtr.Zero);
			ptr->EditLayerName = (EditLayerName ?? new FName("Layer"));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__EditorApplySpline_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4C RID: 125516 RVA: 0x002D8D40 File Offset: 0x002D6F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ChangeUseTessellationComponentScreenSizeFalloff(bool InComponentScreenSizeToUseSubSections)
		{
			ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InComponentScreenSizeToUseSubSections = InComponentScreenSizeToUseSubSections;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4D RID: 125517 RVA: 0x002D8D88 File Offset: 0x002D6F88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ChangeTessellationComponentScreenSizeFalloff(float InUseTessellationComponentScreenSizeFalloff)
		{
			ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InUseTessellationComponentScreenSizeFalloff = InUseTessellationComponentScreenSizeFalloff;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4E RID: 125518 RVA: 0x002D8DD0 File Offset: 0x002D6FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ChangeTessellationComponentScreenSize(float InTessellationComponentScreenSize)
		{
			ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeTessellationComponentScreenSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeTessellationComponentScreenSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTessellationComponentScreenSize = InTessellationComponentScreenSize;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeTessellationComponentScreenSize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA4F RID: 125519 RVA: 0x002D8E18 File Offset: 0x002D7018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ChangeLODDistanceFactor(float InLODDistanceFactor)
		{
			ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeLODDistanceFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeLODDistanceFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLODDistanceFactor = InLODDistanceFactor;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeLODDistanceFactor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA50 RID: 125520 RVA: 0x002D8E60 File Offset: 0x002D7060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)
		{
			ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams* ptr = stackalloc ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InComponentScreenSizeToUseSubSections = InComponentScreenSizeToUseSubSections;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ALandscapeProxy.__ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EA51 RID: 125521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialVectorParameterValue_Internal(IntPtr @this, FName ParameterName, FLinearColor Value);

		// Token: 0x0601EA52 RID: 125522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialTextureParameterValue_Internal(IntPtr @this, FName ParameterName, IntPtr Value);

		// Token: 0x0601EA53 RID: 125523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeMaterialScalarParameterValue_Internal(IntPtr @this, FName ParameterName, float Value);

		// Token: 0x0601EA54 RID: 125524 RVA: 0x002D8EA7 File Offset: 0x002D70A7
		static ALandscapeProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeProxy");
		}

		// Token: 0x0601EA55 RID: 125525 RVA: 0x002D8EB8 File Offset: 0x002D70B8
		protected ALandscapeProxy() : this(BuiltinUtils.AllocNativeUObject(ALandscapeProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EA56 RID: 125526 RVA: 0x002D8EE0 File Offset: 0x002D70E0
		protected ALandscapeProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401089C RID: 67740
		public new const string __ObjectPath = "/Script/Landscape.LandscapeProxy";

		// Token: 0x0401089D RID: 67741
		private static IntPtr _ClassPtr;

		// Token: 0x0401089E RID: 67742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401089F RID: 67743
		internal static int __PropertyOffset_SplineComponent;

		// Token: 0x040108A0 RID: 67744
		internal static int __PropertyOffset_LandscapeGuid;

		// Token: 0x040108A1 RID: 67745
		internal static int __PropertyOffset_LandscapeSectionOffset;

		// Token: 0x040108A2 RID: 67746
		internal static int __PropertyOffset_MaxLODLevel;

		// Token: 0x040108A3 RID: 67747
		internal static int __PropertyOffset_LODDistanceFactor_DEPRECATED;

		// Token: 0x040108A4 RID: 67748
		internal static int __PropertyOffset_LODFalloff_DEPRECATED;

		// Token: 0x040108A5 RID: 67749
		internal static int __PropertyOffset_ComponentScreenSizeToUseSubSections;

		// Token: 0x040108A6 RID: 67750
		internal static int __PropertyOffset_LOD0ScreenSize;

		// Token: 0x040108A7 RID: 67751
		internal static int __PropertyOffset_LOD0DistributionSetting;

		// Token: 0x040108A8 RID: 67752
		internal static int __PropertyOffset_LODDistributionSetting;

		// Token: 0x040108A9 RID: 67753
		internal static int __PropertyOffset_TessellationComponentScreenSize;

		// Token: 0x040108AA RID: 67754
		internal static int __PropertyOffset_UseTessellationComponentScreenSizeFalloff;

		// Token: 0x040108AB RID: 67755
		internal static int __PropertyOffset_TessellationComponentScreenSizeFalloff;

		// Token: 0x040108AC RID: 67756
		internal static int __PropertyOffset_OccluderGeometryLOD;

		// Token: 0x040108AD RID: 67757
		internal static int __PropertyOffset_StaticLightingLOD;

		// Token: 0x040108AE RID: 67758
		internal static int __PropertyOffset_DefaultPhysMaterial;

		// Token: 0x040108AF RID: 67759
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x040108B0 RID: 67760
		internal static int __PropertyOffset_LandscapeMaterial;

		// Token: 0x040108B1 RID: 67761
		internal static int __PropertyOffset_LandscapeLayerParams;

		// Token: 0x040108B2 RID: 67762
		[Nullable(2)]
		private TArray<FVector4> _LandscapeLayerParams;

		// Token: 0x040108B3 RID: 67763
		internal static int __PropertyOffset_UseLandscapeColormap;

		// Token: 0x040108B4 RID: 67764
		internal static byte __PropertyMask_UseLandscapeColormap;

		// Token: 0x040108B5 RID: 67765
		internal static int __PropertyOffset_KuroColormapTexture;

		// Token: 0x040108B6 RID: 67766
		internal static int __PropertyOffset_SectionBaseMinAndRange;

		// Token: 0x040108B7 RID: 67767
		internal static int __PropertyOffset_LandscapeHoleMaterial;

		// Token: 0x040108B8 RID: 67768
		internal static int __PropertyOffset_LandscapeMaterialsOverride;

		// Token: 0x040108B9 RID: 67769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeProxyMaterialOverride> _LandscapeMaterialsOverride;

		// Token: 0x040108BA RID: 67770
		internal static int __PropertyOffset_CustomLayerPhysicalMaterial;

		// Token: 0x040108BB RID: 67771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeProxyCustomLayerPhysicalMaterial> _CustomLayerPhysicalMaterial;

		// Token: 0x040108BC RID: 67772
		internal static int __PropertyOffset_bMeshHoles;

		// Token: 0x040108BD RID: 67773
		internal static int __PropertyOffset_MeshHolesMaxLod;

		// Token: 0x040108BE RID: 67774
		internal static int __PropertyOffset_RuntimeVirtualTextures;

		// Token: 0x040108BF RID: 67775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URuntimeVirtualTexture> _RuntimeVirtualTextures;

		// Token: 0x040108C0 RID: 67776
		internal static int __PropertyOffset_VirtualTextureNumLods;

		// Token: 0x040108C1 RID: 67777
		internal static int __PropertyOffset_VirtualTextureLodBias;

		// Token: 0x040108C2 RID: 67778
		internal static int __PropertyOffset_VirtualTextureRenderPassType;

		// Token: 0x040108C3 RID: 67779
		internal static int __PropertyOffset_NegativeZBoundsExtension;

		// Token: 0x040108C4 RID: 67780
		internal static int __PropertyOffset_PositiveZBoundsExtension;

		// Token: 0x040108C5 RID: 67781
		internal static int __PropertyOffset_LandscapeComponents;

		// Token: 0x040108C6 RID: 67782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeComponent> _LandscapeComponents;

		// Token: 0x040108C7 RID: 67783
		internal static int __PropertyOffset_LandscapeBatch;

		// Token: 0x040108C8 RID: 67784
		internal static int __PropertyOffset_CollisionComponents;

		// Token: 0x040108C9 RID: 67785
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeHeightfieldCollisionComponent> _CollisionComponents;

		// Token: 0x040108CA RID: 67786
		internal static int __PropertyOffset_FoliageComponents;

		// Token: 0x040108CB RID: 67787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHierarchicalInstancedStaticMeshComponent> _FoliageComponents;

		// Token: 0x040108CC RID: 67788
		internal static int __PropertyOffset_bHasLandscapeGrass;

		// Token: 0x040108CD RID: 67789
		internal static int __PropertyOffset_StaticLightingResolution;

		// Token: 0x040108CE RID: 67790
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x040108CF RID: 67791
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x040108D0 RID: 67792
		internal static int __PropertyOffset_MobileCastShadow;

		// Token: 0x040108D1 RID: 67793
		internal static byte __PropertyMask_MobileCastShadow;

		// Token: 0x040108D2 RID: 67794
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x040108D3 RID: 67795
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x040108D4 RID: 67796
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x040108D5 RID: 67797
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x040108D6 RID: 67798
		internal static int __PropertyOffset_bCastFarShadow;

		// Token: 0x040108D7 RID: 67799
		internal static byte __PropertyMask_bCastFarShadow;

		// Token: 0x040108D8 RID: 67800
		internal static int __PropertyOffset_bCastFarShadowOnMobile;

		// Token: 0x040108D9 RID: 67801
		internal static byte __PropertyMask_bCastFarShadowOnMobile;

		// Token: 0x040108DA RID: 67802
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x040108DB RID: 67803
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x040108DC RID: 67804
		internal static int __PropertyOffset_bCastHiddenShadow;

		// Token: 0x040108DD RID: 67805
		internal static byte __PropertyMask_bCastHiddenShadow;

		// Token: 0x040108DE RID: 67806
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x040108DF RID: 67807
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x040108E0 RID: 67808
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x040108E1 RID: 67809
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x040108E2 RID: 67810
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x040108E3 RID: 67811
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x040108E4 RID: 67812
		internal static int __PropertyOffset_bUseMaterialPositionOffsetInStaticLighting;

		// Token: 0x040108E5 RID: 67813
		internal static byte __PropertyMask_bUseMaterialPositionOffsetInStaticLighting;

		// Token: 0x040108E6 RID: 67814
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x040108E7 RID: 67815
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x040108E8 RID: 67816
		internal static int __PropertyOffset_CustomDepthStencilWriteMask;

		// Token: 0x040108E9 RID: 67817
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x040108EA RID: 67818
		internal static int __PropertyOffset_LDMaxDrawDistance;

		// Token: 0x040108EB RID: 67819
		internal static int __PropertyOffset_KuroRenderingLODBias;

		// Token: 0x040108EC RID: 67820
		internal static int __PropertyOffset_bKuroSkipPakLevelCook;

		// Token: 0x040108ED RID: 67821
		internal static int __PropertyOffset_KuroForceClassifyPC;

		// Token: 0x040108EE RID: 67822
		internal static int __PropertyOffset_KuroForceClassifyMobile;

		// Token: 0x040108EF RID: 67823
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x040108F0 RID: 67824
		[Nullable(2)]
		private FLightmassPrimitiveSettings _LightmassSettings;

		// Token: 0x040108F1 RID: 67825
		internal static int __PropertyOffset_CollisionMipLevel;

		// Token: 0x040108F2 RID: 67826
		internal static int __PropertyOffset_SimpleCollisionMipLevel;

		// Token: 0x040108F3 RID: 67827
		internal static int __PropertyOffset_CollisionThickness;

		// Token: 0x040108F4 RID: 67828
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x040108F5 RID: 67829
		[Nullable(2)]
		private FBodyInstance _BodyInstance;

		// Token: 0x040108F6 RID: 67830
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x040108F7 RID: 67831
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x040108F8 RID: 67832
		internal static int __PropertyOffset_bBakeMaterialPositionOffsetIntoCollision;

		// Token: 0x040108F9 RID: 67833
		internal static byte __PropertyMask_bBakeMaterialPositionOffsetIntoCollision;

		// Token: 0x040108FA RID: 67834
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x040108FB RID: 67835
		internal static int __PropertyOffset_SubsectionSizeQuads;

		// Token: 0x040108FC RID: 67836
		internal static int __PropertyOffset_NumSubsections;

		// Token: 0x040108FD RID: 67837
		internal static int __PropertyOffset_bUsedForNavigation;

		// Token: 0x040108FE RID: 67838
		internal static byte __PropertyMask_bUsedForNavigation;

		// Token: 0x040108FF RID: 67839
		internal static int __PropertyOffset_bFillCollisionUnderLandscapeForNavmesh;

		// Token: 0x04010900 RID: 67840
		internal static byte __PropertyMask_bFillCollisionUnderLandscapeForNavmesh;

		// Token: 0x04010901 RID: 67841
		internal static int __PropertyOffset_bUseDynamicMaterialInstance;

		// Token: 0x04010902 RID: 67842
		internal static int __PropertyOffset_NavigationGeometryGatheringMode;

		// Token: 0x04010903 RID: 67843
		internal static int __PropertyOffset_bUseLandscapeForCullingInvisibleHLODVertices;

		// Token: 0x04010904 RID: 67844
		internal static int __PropertyOffset_bHasLayersContent;

		// Token: 0x04010905 RID: 67845
		internal static int __PropertyOffset_WeightmapUsageMap;

		// Token: 0x04010906 RID: 67846
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UTexture2D, ULandscapeWeightmapUsage> _WeightmapUsageMap;

		// Token: 0x04010907 RID: 67847
		private static IntPtr __SetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr;

		// Token: 0x04010908 RID: 67848
		private static IntPtr __SetKuroLandscapeFOVFactor_NativeFunctionPtr;

		// Token: 0x04010909 RID: 67849
		private static IntPtr __LandscapeExportHeightmapToRenderTarget_NativeFunctionPtr;

		// Token: 0x0401090A RID: 67850
		private static IntPtr __GetKuroLandscapeFOVFactorByCamera_NativeFunctionPtr;

		// Token: 0x0401090B RID: 67851
		private static IntPtr __GetKuroLandscapeFOVFactor_NativeFunctionPtr;

		// Token: 0x0401090C RID: 67852
		private static IntPtr __GenerateLandscapeLayerParams_NativeFunctionPtr;

		// Token: 0x0401090D RID: 67853
		private static IntPtr __EditorSetLandscapeMaterial_NativeFunctionPtr;

		// Token: 0x0401090E RID: 67854
		private static IntPtr __EditorSetKuroColormapTexture_NativeFunctionPtr;

		// Token: 0x0401090F RID: 67855
		private static IntPtr __EditorApplySpline_NativeFunctionPtr;

		// Token: 0x04010910 RID: 67856
		private static IntPtr __ChangeUseTessellationComponentScreenSizeFalloff_NativeFunctionPtr;

		// Token: 0x04010911 RID: 67857
		private static IntPtr __ChangeTessellationComponentScreenSizeFalloff_NativeFunctionPtr;

		// Token: 0x04010912 RID: 67858
		private static IntPtr __ChangeTessellationComponentScreenSize_NativeFunctionPtr;

		// Token: 0x04010913 RID: 67859
		private static IntPtr __ChangeLODDistanceFactor_NativeFunctionPtr;

		// Token: 0x04010914 RID: 67860
		private static IntPtr __ChangeComponentScreenSizeToUseSubSections_NativeFunctionPtr;

		// Token: 0x0200340F RID: 13327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroLandscapeFOVFactorByCamera_FunctionParams
		{
			// Token: 0x040173DA RID: 95194
			[FieldOffset(0)]
			public float InFOVFactor;
		}

		// Token: 0x02003410 RID: 13328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetKuroLandscapeFOVFactor_FunctionParams
		{
			// Token: 0x040173DB RID: 95195
			[FieldOffset(0)]
			public float InFOVFactor;
		}

		// Token: 0x02003411 RID: 13329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LandscapeExportHeightmapToRenderTarget_FunctionParams
		{
			// Token: 0x040173DC RID: 95196
			[FieldOffset(0)]
			public IntPtr InRenderTarget;

			// Token: 0x040173DD RID: 95197
			[FieldOffset(8)]
			public bool InExportHeightIntoRGChannel;

			// Token: 0x040173DE RID: 95198
			[FieldOffset(9)]
			public bool InExportLandscapeProxies;

			// Token: 0x040173DF RID: 95199
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02003412 RID: 13330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroLandscapeFOVFactorByCamera_FunctionParams
		{
			// Token: 0x040173E0 RID: 95200
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02003413 RID: 13331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKuroLandscapeFOVFactor_FunctionParams
		{
			// Token: 0x040173E1 RID: 95201
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02003414 RID: 13332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EditorSetLandscapeMaterial_FunctionParams
		{
			// Token: 0x040173E2 RID: 95202
			[FieldOffset(0)]
			public IntPtr NewLandscapeMaterial;
		}

		// Token: 0x02003415 RID: 13333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EditorSetKuroColormapTexture_FunctionParams
		{
			// Token: 0x040173E3 RID: 95203
			[FieldOffset(0)]
			public IntPtr NewKuroColormapTexture;
		}

		// Token: 0x02003416 RID: 13334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EditorApplySpline_FunctionParams
		{
			// Token: 0x040173E4 RID: 95204
			[FieldOffset(0)]
			public IntPtr InSplineComponent;

			// Token: 0x040173E5 RID: 95205
			[FieldOffset(8)]
			public float StartWidth;

			// Token: 0x040173E6 RID: 95206
			[FieldOffset(12)]
			public float EndWidth;

			// Token: 0x040173E7 RID: 95207
			[FieldOffset(16)]
			public float StartSideFalloff;

			// Token: 0x040173E8 RID: 95208
			[FieldOffset(20)]
			public float EndSideFalloff;

			// Token: 0x040173E9 RID: 95209
			[FieldOffset(24)]
			public float StartRoll;

			// Token: 0x040173EA RID: 95210
			[FieldOffset(28)]
			public float EndRoll;

			// Token: 0x040173EB RID: 95211
			[FieldOffset(32)]
			public int NumSubdivisions;

			// Token: 0x040173EC RID: 95212
			[FieldOffset(36)]
			public bool bRaiseHeights;

			// Token: 0x040173ED RID: 95213
			[FieldOffset(37)]
			public bool bLowerHeights;

			// Token: 0x040173EE RID: 95214
			[FieldOffset(40)]
			public IntPtr PaintLayer;

			// Token: 0x040173EF RID: 95215
			[FieldOffset(48)]
			public FName EditLayerName;
		}

		// Token: 0x02003417 RID: 13335
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ChangeUseTessellationComponentScreenSizeFalloff_FunctionParams
		{
			// Token: 0x040173F0 RID: 95216
			[FieldOffset(0)]
			public bool InComponentScreenSizeToUseSubSections;
		}

		// Token: 0x02003418 RID: 13336
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeTessellationComponentScreenSizeFalloff_FunctionParams
		{
			// Token: 0x040173F1 RID: 95217
			[FieldOffset(0)]
			public float InUseTessellationComponentScreenSizeFalloff;
		}

		// Token: 0x02003419 RID: 13337
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeTessellationComponentScreenSize_FunctionParams
		{
			// Token: 0x040173F2 RID: 95218
			[FieldOffset(0)]
			public float InTessellationComponentScreenSize;
		}

		// Token: 0x0200341A RID: 13338
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeLODDistanceFactor_FunctionParams
		{
			// Token: 0x040173F3 RID: 95219
			[FieldOffset(0)]
			public float InLODDistanceFactor;
		}

		// Token: 0x0200341B RID: 13339
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ChangeComponentScreenSizeToUseSubSections_FunctionParams
		{
			// Token: 0x040173F4 RID: 95220
			[FieldOffset(0)]
			public float InComponentScreenSizeToUseSubSections;
		}
	}
}
