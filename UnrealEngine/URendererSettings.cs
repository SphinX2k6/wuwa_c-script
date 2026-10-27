using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001080 RID: 4224
	[UnrealObjectPath("/Script/Engine.RendererSettings")]
	[UnrealStructLayout(992, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class URendererSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F041 RID: 61505 RVA: 0x0016423F File Offset: 0x0016243F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URendererSettings._ClassPtr;
		}

		// Token: 0x0600F042 RID: 61506 RVA: 0x0016424C File Offset: 0x0016244C
		public URendererSettings() : this(BuiltinUtils.AllocNativeUObject(URendererSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F043 RID: 61507 RVA: 0x00164274 File Offset: 0x00162474
		[NullableContext(1)]
		public URendererSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URendererSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600F044 RID: 61508 RVA: 0x001642A7 File Offset: 0x001624A7
		// (set) Token: 0x0600F045 RID: 61509 RVA: 0x001642C0 File Offset: 0x001624C0
		public unsafe bool bMobileDisableVertexFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDisableVertexFog) & URendererSettings.__PropertyMask_bMobileDisableVertexFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDisableVertexFog) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDisableVertexFog) & ~URendererSettings.__PropertyMask_bMobileDisableVertexFog) | (value ? URendererSettings.__PropertyMask_bMobileDisableVertexFog : 0));
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600F046 RID: 61510 RVA: 0x001642F0 File Offset: 0x001624F0
		// (set) Token: 0x0600F047 RID: 61511 RVA: 0x00164300 File Offset: 0x00162500
		public unsafe int MaxMobileCascades
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MaxMobileCascades);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MaxMobileCascades) = value;
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600F048 RID: 61512 RVA: 0x00164311 File Offset: 0x00162511
		// (set) Token: 0x0600F049 RID: 61513 RVA: 0x00164325 File Offset: 0x00162525
		public unsafe TEnumAsByte<EMobileMSAASampleCount> MobileMSAASampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobileMSAASampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobileMSAASampleCount) = value;
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600F04A RID: 61514 RVA: 0x0016433A File Offset: 0x0016253A
		// (set) Token: 0x0600F04B RID: 61515 RVA: 0x00164353 File Offset: 0x00162553
		public unsafe bool bMobileAllowDitheredLODTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDitheredLODTransition) & URendererSettings.__PropertyMask_bMobileAllowDitheredLODTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDitheredLODTransition) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDitheredLODTransition) & ~URendererSettings.__PropertyMask_bMobileAllowDitheredLODTransition) | (value ? URendererSettings.__PropertyMask_bMobileAllowDitheredLODTransition : 0));
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600F04C RID: 61516 RVA: 0x00164383 File Offset: 0x00162583
		// (set) Token: 0x0600F04D RID: 61517 RVA: 0x0016439C File Offset: 0x0016259C
		public unsafe bool bAllowSoftwareOcclusionCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowSoftwareOcclusionCulling) & URendererSettings.__PropertyMask_bAllowSoftwareOcclusionCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowSoftwareOcclusionCulling) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowSoftwareOcclusionCulling) & ~URendererSettings.__PropertyMask_bAllowSoftwareOcclusionCulling) | (value ? URendererSettings.__PropertyMask_bAllowSoftwareOcclusionCulling : 0));
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600F04E RID: 61518 RVA: 0x001643CC File Offset: 0x001625CC
		// (set) Token: 0x0600F04F RID: 61519 RVA: 0x001643E5 File Offset: 0x001625E5
		public unsafe bool bMobileVirtualTextures
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileVirtualTextures) & URendererSettings.__PropertyMask_bMobileVirtualTextures) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileVirtualTextures) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileVirtualTextures) & ~URendererSettings.__PropertyMask_bMobileVirtualTextures) | (value ? URendererSettings.__PropertyMask_bMobileVirtualTextures : 0));
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600F050 RID: 61520 RVA: 0x00164415 File Offset: 0x00162615
		// (set) Token: 0x0600F051 RID: 61521 RVA: 0x0016442E File Offset: 0x0016262E
		public unsafe bool bDiscardUnusedQualityLevels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDiscardUnusedQualityLevels) & URendererSettings.__PropertyMask_bDiscardUnusedQualityLevels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDiscardUnusedQualityLevels) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDiscardUnusedQualityLevels) & ~URendererSettings.__PropertyMask_bDiscardUnusedQualityLevels) | (value ? URendererSettings.__PropertyMask_bDiscardUnusedQualityLevels : 0));
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600F052 RID: 61522 RVA: 0x0016445E File Offset: 0x0016265E
		// (set) Token: 0x0600F053 RID: 61523 RVA: 0x00164477 File Offset: 0x00162677
		public unsafe bool bOcclusionCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bOcclusionCulling) & URendererSettings.__PropertyMask_bOcclusionCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bOcclusionCulling) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bOcclusionCulling) & ~URendererSettings.__PropertyMask_bOcclusionCulling) | (value ? URendererSettings.__PropertyMask_bOcclusionCulling : 0));
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600F054 RID: 61524 RVA: 0x001644A7 File Offset: 0x001626A7
		// (set) Token: 0x0600F055 RID: 61525 RVA: 0x001644B7 File Offset: 0x001626B7
		public unsafe float MinScreenRadiusForLights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MinScreenRadiusForLights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MinScreenRadiusForLights) = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600F056 RID: 61526 RVA: 0x001644C8 File Offset: 0x001626C8
		// (set) Token: 0x0600F057 RID: 61527 RVA: 0x001644D8 File Offset: 0x001626D8
		public unsafe float MinScreenRadiusForCSMdepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MinScreenRadiusForCSMdepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MinScreenRadiusForCSMdepth) = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600F058 RID: 61528 RVA: 0x001644E9 File Offset: 0x001626E9
		// (set) Token: 0x0600F059 RID: 61529 RVA: 0x00164502 File Offset: 0x00162702
		public unsafe bool bPrecomputedVisibilityWarning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bPrecomputedVisibilityWarning) & URendererSettings.__PropertyMask_bPrecomputedVisibilityWarning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bPrecomputedVisibilityWarning) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bPrecomputedVisibilityWarning) & ~URendererSettings.__PropertyMask_bPrecomputedVisibilityWarning) | (value ? URendererSettings.__PropertyMask_bPrecomputedVisibilityWarning : 0));
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600F05A RID: 61530 RVA: 0x00164532 File Offset: 0x00162732
		// (set) Token: 0x0600F05B RID: 61531 RVA: 0x0016454B File Offset: 0x0016274B
		public unsafe bool bTextureStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTextureStreaming) & URendererSettings.__PropertyMask_bTextureStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTextureStreaming) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTextureStreaming) & ~URendererSettings.__PropertyMask_bTextureStreaming) | (value ? URendererSettings.__PropertyMask_bTextureStreaming : 0));
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0600F05C RID: 61532 RVA: 0x0016457B File Offset: 0x0016277B
		// (set) Token: 0x0600F05D RID: 61533 RVA: 0x00164594 File Offset: 0x00162794
		public unsafe bool bUseDXT5NormalMaps
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseDXT5NormalMaps) & URendererSettings.__PropertyMask_bUseDXT5NormalMaps) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseDXT5NormalMaps) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseDXT5NormalMaps) & ~URendererSettings.__PropertyMask_bUseDXT5NormalMaps) | (value ? URendererSettings.__PropertyMask_bUseDXT5NormalMaps : 0));
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600F05E RID: 61534 RVA: 0x001645C4 File Offset: 0x001627C4
		// (set) Token: 0x0600F05F RID: 61535 RVA: 0x001645DD File Offset: 0x001627DD
		public unsafe bool bVirtualTextures
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextures) & URendererSettings.__PropertyMask_bVirtualTextures) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextures) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextures) & ~URendererSettings.__PropertyMask_bVirtualTextures) | (value ? URendererSettings.__PropertyMask_bVirtualTextures : 0));
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600F060 RID: 61536 RVA: 0x0016460D File Offset: 0x0016280D
		// (set) Token: 0x0600F061 RID: 61537 RVA: 0x00164626 File Offset: 0x00162826
		public unsafe bool bVirtualTexturedLightmaps
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTexturedLightmaps) & URendererSettings.__PropertyMask_bVirtualTexturedLightmaps) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTexturedLightmaps) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTexturedLightmaps) & ~URendererSettings.__PropertyMask_bVirtualTexturedLightmaps) | (value ? URendererSettings.__PropertyMask_bVirtualTexturedLightmaps : 0));
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600F062 RID: 61538 RVA: 0x00164656 File Offset: 0x00162856
		// (set) Token: 0x0600F063 RID: 61539 RVA: 0x0016466F File Offset: 0x0016286F
		public unsafe bool bEnableVirtualTextureOpacityMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableVirtualTextureOpacityMask) & URendererSettings.__PropertyMask_bEnableVirtualTextureOpacityMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableVirtualTextureOpacityMask) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableVirtualTextureOpacityMask) & ~URendererSettings.__PropertyMask_bEnableVirtualTextureOpacityMask) | (value ? URendererSettings.__PropertyMask_bEnableVirtualTextureOpacityMask : 0));
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600F064 RID: 61540 RVA: 0x0016469F File Offset: 0x0016289F
		// (set) Token: 0x0600F065 RID: 61541 RVA: 0x001646AF File Offset: 0x001628AF
		public unsafe uint VirtualTextureTileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureTileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureTileSize) = (int)value;
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600F066 RID: 61542 RVA: 0x001646C0 File Offset: 0x001628C0
		// (set) Token: 0x0600F067 RID: 61543 RVA: 0x001646D0 File Offset: 0x001628D0
		public unsafe uint VirtualTextureTileBorderSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureTileBorderSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureTileBorderSize) = (int)value;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600F068 RID: 61544 RVA: 0x001646E1 File Offset: 0x001628E1
		// (set) Token: 0x0600F069 RID: 61545 RVA: 0x001646F1 File Offset: 0x001628F1
		public unsafe uint VirtualTextureFeedbackFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureFeedbackFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VirtualTextureFeedbackFactor) = (int)value;
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600F06A RID: 61546 RVA: 0x00164702 File Offset: 0x00162902
		// (set) Token: 0x0600F06B RID: 61547 RVA: 0x0016471B File Offset: 0x0016291B
		public unsafe bool bVirtualTextureEnableCompressZlib
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressZlib) & URendererSettings.__PropertyMask_bVirtualTextureEnableCompressZlib) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressZlib) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressZlib) & ~URendererSettings.__PropertyMask_bVirtualTextureEnableCompressZlib) | (value ? URendererSettings.__PropertyMask_bVirtualTextureEnableCompressZlib : 0));
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x0016474B File Offset: 0x0016294B
		// (set) Token: 0x0600F06D RID: 61549 RVA: 0x00164764 File Offset: 0x00162964
		public unsafe bool bVirtualTextureEnableCompressCrunch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressCrunch) & URendererSettings.__PropertyMask_bVirtualTextureEnableCompressCrunch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressCrunch) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVirtualTextureEnableCompressCrunch) & ~URendererSettings.__PropertyMask_bVirtualTextureEnableCompressCrunch) | (value ? URendererSettings.__PropertyMask_bVirtualTextureEnableCompressCrunch : 0));
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600F06E RID: 61550 RVA: 0x00164794 File Offset: 0x00162994
		// (set) Token: 0x0600F06F RID: 61551 RVA: 0x001647AD File Offset: 0x001629AD
		public unsafe bool bClearCoatEnableSecondNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bClearCoatEnableSecondNormal) & URendererSettings.__PropertyMask_bClearCoatEnableSecondNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bClearCoatEnableSecondNormal) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bClearCoatEnableSecondNormal) & ~URendererSettings.__PropertyMask_bClearCoatEnableSecondNormal) | (value ? URendererSettings.__PropertyMask_bClearCoatEnableSecondNormal : 0));
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600F070 RID: 61552 RVA: 0x001647DD File Offset: 0x001629DD
		// (set) Token: 0x0600F071 RID: 61553 RVA: 0x001647ED File Offset: 0x001629ED
		public unsafe int ReflectionCaptureResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ReflectionCaptureResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ReflectionCaptureResolution) = value;
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600F072 RID: 61554 RVA: 0x001647FE File Offset: 0x001629FE
		// (set) Token: 0x0600F073 RID: 61555 RVA: 0x00164817 File Offset: 0x00162A17
		public unsafe bool bReflectionCaptureCompression
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bReflectionCaptureCompression) & URendererSettings.__PropertyMask_bReflectionCaptureCompression) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bReflectionCaptureCompression) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bReflectionCaptureCompression) & ~URendererSettings.__PropertyMask_bReflectionCaptureCompression) | (value ? URendererSettings.__PropertyMask_bReflectionCaptureCompression : 0));
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600F074 RID: 61556 RVA: 0x00164847 File Offset: 0x00162A47
		// (set) Token: 0x0600F075 RID: 61557 RVA: 0x00164860 File Offset: 0x00162A60
		public unsafe bool ReflectionEnvironmentLightmapMixBasedOnRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ReflectionEnvironmentLightmapMixBasedOnRoughness) & URendererSettings.__PropertyMask_ReflectionEnvironmentLightmapMixBasedOnRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ReflectionEnvironmentLightmapMixBasedOnRoughness) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ReflectionEnvironmentLightmapMixBasedOnRoughness) & ~URendererSettings.__PropertyMask_ReflectionEnvironmentLightmapMixBasedOnRoughness) | (value ? URendererSettings.__PropertyMask_ReflectionEnvironmentLightmapMixBasedOnRoughness : 0));
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600F076 RID: 61558 RVA: 0x00164890 File Offset: 0x00162A90
		// (set) Token: 0x0600F077 RID: 61559 RVA: 0x001648A9 File Offset: 0x00162AA9
		public unsafe bool bForwardShading
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bForwardShading) & URendererSettings.__PropertyMask_bForwardShading) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bForwardShading) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bForwardShading) & ~URendererSettings.__PropertyMask_bForwardShading) | (value ? URendererSettings.__PropertyMask_bForwardShading : 0));
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600F078 RID: 61560 RVA: 0x001648D9 File Offset: 0x00162AD9
		// (set) Token: 0x0600F079 RID: 61561 RVA: 0x001648F2 File Offset: 0x00162AF2
		public unsafe bool bVertexFoggingForOpaque
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexFoggingForOpaque) & URendererSettings.__PropertyMask_bVertexFoggingForOpaque) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexFoggingForOpaque) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexFoggingForOpaque) & ~URendererSettings.__PropertyMask_bVertexFoggingForOpaque) | (value ? URendererSettings.__PropertyMask_bVertexFoggingForOpaque : 0));
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600F07A RID: 61562 RVA: 0x00164922 File Offset: 0x00162B22
		// (set) Token: 0x0600F07B RID: 61563 RVA: 0x0016493B File Offset: 0x00162B3B
		public unsafe bool bAllowStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowStaticLighting) & URendererSettings.__PropertyMask_bAllowStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowStaticLighting) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bAllowStaticLighting) & ~URendererSettings.__PropertyMask_bAllowStaticLighting) | (value ? URendererSettings.__PropertyMask_bAllowStaticLighting : 0));
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0600F07C RID: 61564 RVA: 0x0016496B File Offset: 0x00162B6B
		// (set) Token: 0x0600F07D RID: 61565 RVA: 0x00164984 File Offset: 0x00162B84
		public unsafe bool bUseNormalMapsForStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseNormalMapsForStaticLighting) & URendererSettings.__PropertyMask_bUseNormalMapsForStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseNormalMapsForStaticLighting) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseNormalMapsForStaticLighting) & ~URendererSettings.__PropertyMask_bUseNormalMapsForStaticLighting) | (value ? URendererSettings.__PropertyMask_bUseNormalMapsForStaticLighting : 0));
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600F07E RID: 61566 RVA: 0x001649B4 File Offset: 0x00162BB4
		// (set) Token: 0x0600F07F RID: 61567 RVA: 0x001649CD File Offset: 0x00162BCD
		public unsafe bool bGenerateMeshDistanceFields
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateMeshDistanceFields) & URendererSettings.__PropertyMask_bGenerateMeshDistanceFields) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateMeshDistanceFields) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateMeshDistanceFields) & ~URendererSettings.__PropertyMask_bGenerateMeshDistanceFields) | (value ? URendererSettings.__PropertyMask_bGenerateMeshDistanceFields : 0));
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x001649FD File Offset: 0x00162BFD
		// (set) Token: 0x0600F081 RID: 61569 RVA: 0x00164A16 File Offset: 0x00162C16
		public unsafe bool bEightBitMeshDistanceFields
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEightBitMeshDistanceFields) & URendererSettings.__PropertyMask_bEightBitMeshDistanceFields) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEightBitMeshDistanceFields) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEightBitMeshDistanceFields) & ~URendererSettings.__PropertyMask_bEightBitMeshDistanceFields) | (value ? URendererSettings.__PropertyMask_bEightBitMeshDistanceFields : 0));
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600F082 RID: 61570 RVA: 0x00164A46 File Offset: 0x00162C46
		// (set) Token: 0x0600F083 RID: 61571 RVA: 0x00164A5F File Offset: 0x00162C5F
		public unsafe bool bGenerateLandscapeGIData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateLandscapeGIData) & URendererSettings.__PropertyMask_bGenerateLandscapeGIData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateLandscapeGIData) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGenerateLandscapeGIData) & ~URendererSettings.__PropertyMask_bGenerateLandscapeGIData) | (value ? URendererSettings.__PropertyMask_bGenerateLandscapeGIData : 0));
			}
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600F084 RID: 61572 RVA: 0x00164A8F File Offset: 0x00162C8F
		// (set) Token: 0x0600F085 RID: 61573 RVA: 0x00164AA8 File Offset: 0x00162CA8
		public unsafe bool bCompressMeshDistanceFields
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCompressMeshDistanceFields) & URendererSettings.__PropertyMask_bCompressMeshDistanceFields) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCompressMeshDistanceFields) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCompressMeshDistanceFields) & ~URendererSettings.__PropertyMask_bCompressMeshDistanceFields) | (value ? URendererSettings.__PropertyMask_bCompressMeshDistanceFields : 0));
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600F086 RID: 61574 RVA: 0x00164AD8 File Offset: 0x00162CD8
		// (set) Token: 0x0600F087 RID: 61575 RVA: 0x00164AE8 File Offset: 0x00162CE8
		public unsafe float TessellationAdaptivePixelsPerTriangle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TessellationAdaptivePixelsPerTriangle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TessellationAdaptivePixelsPerTriangle) = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600F088 RID: 61576 RVA: 0x00164AF9 File Offset: 0x00162CF9
		// (set) Token: 0x0600F089 RID: 61577 RVA: 0x00164B12 File Offset: 0x00162D12
		public unsafe bool bSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSeparateTranslucency) & URendererSettings.__PropertyMask_bSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSeparateTranslucency) & ~URendererSettings.__PropertyMask_bSeparateTranslucency) | (value ? URendererSettings.__PropertyMask_bSeparateTranslucency : 0));
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600F08A RID: 61578 RVA: 0x00164B42 File Offset: 0x00162D42
		// (set) Token: 0x0600F08B RID: 61579 RVA: 0x00164B56 File Offset: 0x00162D56
		public unsafe TEnumAsByte<ETranslucentSortPolicy> TranslucentSortPolicy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TranslucentSortPolicy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TranslucentSortPolicy) = value;
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600F08C RID: 61580 RVA: 0x00164B6B File Offset: 0x00162D6B
		// (set) Token: 0x0600F08D RID: 61581 RVA: 0x00164B7F File Offset: 0x00162D7F
		public unsafe FVector TranslucentSortAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TranslucentSortAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_TranslucentSortAxis) = value;
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600F08E RID: 61582 RVA: 0x00164B94 File Offset: 0x00162D94
		// (set) Token: 0x0600F08F RID: 61583 RVA: 0x00164BAD File Offset: 0x00162DAD
		public unsafe bool bLocalFogVolumeApplyOnTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLocalFogVolumeApplyOnTranslucent) & URendererSettings.__PropertyMask_bLocalFogVolumeApplyOnTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLocalFogVolumeApplyOnTranslucent) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLocalFogVolumeApplyOnTranslucent) & ~URendererSettings.__PropertyMask_bLocalFogVolumeApplyOnTranslucent) | (value ? URendererSettings.__PropertyMask_bLocalFogVolumeApplyOnTranslucent : 0));
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600F090 RID: 61584 RVA: 0x00164BDD File Offset: 0x00162DDD
		// (set) Token: 0x0600F091 RID: 61585 RVA: 0x00164BF1 File Offset: 0x00162DF1
		public unsafe TEnumAsByte<EFixedFoveationLevels> HMDFixedFoveationLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_HMDFixedFoveationLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_HMDFixedFoveationLevel) = value;
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600F092 RID: 61586 RVA: 0x00164C06 File Offset: 0x00162E06
		// (set) Token: 0x0600F093 RID: 61587 RVA: 0x00164C1F File Offset: 0x00162E1F
		public unsafe bool bHMDFixedFoveationDynamic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bHMDFixedFoveationDynamic) & URendererSettings.__PropertyMask_bHMDFixedFoveationDynamic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bHMDFixedFoveationDynamic) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bHMDFixedFoveationDynamic) & ~URendererSettings.__PropertyMask_bHMDFixedFoveationDynamic) | (value ? URendererSettings.__PropertyMask_bHMDFixedFoveationDynamic : 0));
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600F094 RID: 61588 RVA: 0x00164C4F File Offset: 0x00162E4F
		// (set) Token: 0x0600F095 RID: 61589 RVA: 0x00164C63 File Offset: 0x00162E63
		public unsafe TEnumAsByte<ECustomDepthStencil> CustomDepthStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_CustomDepthStencil);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_CustomDepthStencil) = value;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600F096 RID: 61590 RVA: 0x00164C78 File Offset: 0x00162E78
		// (set) Token: 0x0600F097 RID: 61591 RVA: 0x00164C91 File Offset: 0x00162E91
		public unsafe bool bCustomDepthTaaJitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCustomDepthTaaJitter) & URendererSettings.__PropertyMask_bCustomDepthTaaJitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCustomDepthTaaJitter) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bCustomDepthTaaJitter) & ~URendererSettings.__PropertyMask_bCustomDepthTaaJitter) | (value ? URendererSettings.__PropertyMask_bCustomDepthTaaJitter : 0));
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600F098 RID: 61592 RVA: 0x00164CC1 File Offset: 0x00162EC1
		// (set) Token: 0x0600F099 RID: 61593 RVA: 0x00164CD5 File Offset: 0x00162ED5
		public unsafe TEnumAsByte<EAlphaChannelMode> bEnableAlphaChannelInPostProcessing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableAlphaChannelInPostProcessing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableAlphaChannelInPostProcessing) = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600F09A RID: 61594 RVA: 0x00164CEA File Offset: 0x00162EEA
		// (set) Token: 0x0600F09B RID: 61595 RVA: 0x00164D03 File Offset: 0x00162F03
		public unsafe bool bDefaultFeatureBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureBloom) & URendererSettings.__PropertyMask_bDefaultFeatureBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureBloom) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureBloom) & ~URendererSettings.__PropertyMask_bDefaultFeatureBloom) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureBloom : 0));
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600F09C RID: 61596 RVA: 0x00164D33 File Offset: 0x00162F33
		// (set) Token: 0x0600F09D RID: 61597 RVA: 0x00164D4C File Offset: 0x00162F4C
		public unsafe bool bDefaultFeatureAmbientOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusion) & URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusion) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusion) & ~URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusion) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusion : 0));
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600F09E RID: 61598 RVA: 0x00164D7C File Offset: 0x00162F7C
		// (set) Token: 0x0600F09F RID: 61599 RVA: 0x00164D95 File Offset: 0x00162F95
		public unsafe bool bDefaultFeatureAmbientOcclusionStaticFraction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusionStaticFraction) & URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusionStaticFraction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusionStaticFraction) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAmbientOcclusionStaticFraction) & ~URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusionStaticFraction) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureAmbientOcclusionStaticFraction : 0));
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600F0A0 RID: 61600 RVA: 0x00164DC5 File Offset: 0x00162FC5
		// (set) Token: 0x0600F0A1 RID: 61601 RVA: 0x00164DDE File Offset: 0x00162FDE
		public unsafe bool bDefaultFeatureAutoExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAutoExposure) & URendererSettings.__PropertyMask_bDefaultFeatureAutoExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAutoExposure) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureAutoExposure) & ~URendererSettings.__PropertyMask_bDefaultFeatureAutoExposure) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureAutoExposure : 0));
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600F0A2 RID: 61602 RVA: 0x00164E0E File Offset: 0x0016300E
		// (set) Token: 0x0600F0A3 RID: 61603 RVA: 0x00164E22 File Offset: 0x00163022
		public unsafe TEnumAsByte<EAutoExposureMethodUI> DefaultFeatureAutoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAutoExposure);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAutoExposure) = value;
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600F0A4 RID: 61604 RVA: 0x00164E37 File Offset: 0x00163037
		// (set) Token: 0x0600F0A5 RID: 61605 RVA: 0x00164E47 File Offset: 0x00163047
		public unsafe float DefaultFeatureAutoExposureBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAutoExposureBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAutoExposureBias) = value;
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600F0A6 RID: 61606 RVA: 0x00164E58 File Offset: 0x00163058
		// (set) Token: 0x0600F0A7 RID: 61607 RVA: 0x00164E71 File Offset: 0x00163071
		public unsafe bool bExtendDefaultLuminanceRangeInAutoExposureSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bExtendDefaultLuminanceRangeInAutoExposureSettings) & URendererSettings.__PropertyMask_bExtendDefaultLuminanceRangeInAutoExposureSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bExtendDefaultLuminanceRangeInAutoExposureSettings) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bExtendDefaultLuminanceRangeInAutoExposureSettings) & ~URendererSettings.__PropertyMask_bExtendDefaultLuminanceRangeInAutoExposureSettings) | (value ? URendererSettings.__PropertyMask_bExtendDefaultLuminanceRangeInAutoExposureSettings : 0));
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x00164EA1 File Offset: 0x001630A1
		// (set) Token: 0x0600F0A9 RID: 61609 RVA: 0x00164EBA File Offset: 0x001630BA
		public unsafe bool bUsePreExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUsePreExposure) & URendererSettings.__PropertyMask_bUsePreExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUsePreExposure) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUsePreExposure) & ~URendererSettings.__PropertyMask_bUsePreExposure) | (value ? URendererSettings.__PropertyMask_bUsePreExposure : 0));
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600F0AA RID: 61610 RVA: 0x00164EEA File Offset: 0x001630EA
		// (set) Token: 0x0600F0AB RID: 61611 RVA: 0x00164F03 File Offset: 0x00163103
		public unsafe bool bEnablePreExposureOnlyInTheEditor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnablePreExposureOnlyInTheEditor) & URendererSettings.__PropertyMask_bEnablePreExposureOnlyInTheEditor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnablePreExposureOnlyInTheEditor) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnablePreExposureOnlyInTheEditor) & ~URendererSettings.__PropertyMask_bEnablePreExposureOnlyInTheEditor) | (value ? URendererSettings.__PropertyMask_bEnablePreExposureOnlyInTheEditor : 0));
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600F0AC RID: 61612 RVA: 0x00164F33 File Offset: 0x00163133
		// (set) Token: 0x0600F0AD RID: 61613 RVA: 0x00164F4C File Offset: 0x0016314C
		public unsafe bool bDefaultFeatureMotionBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureMotionBlur) & URendererSettings.__PropertyMask_bDefaultFeatureMotionBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureMotionBlur) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureMotionBlur) & ~URendererSettings.__PropertyMask_bDefaultFeatureMotionBlur) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureMotionBlur : 0));
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x00164F7C File Offset: 0x0016317C
		// (set) Token: 0x0600F0AF RID: 61615 RVA: 0x00164F95 File Offset: 0x00163195
		public unsafe bool bDefaultFeatureLensFlare
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureLensFlare) & URendererSettings.__PropertyMask_bDefaultFeatureLensFlare) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureLensFlare) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultFeatureLensFlare) & ~URendererSettings.__PropertyMask_bDefaultFeatureLensFlare) | (value ? URendererSettings.__PropertyMask_bDefaultFeatureLensFlare : 0));
			}
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x00164FC5 File Offset: 0x001631C5
		// (set) Token: 0x0600F0B1 RID: 61617 RVA: 0x00164FDE File Offset: 0x001631DE
		public unsafe bool bTemporalUpsampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTemporalUpsampling) & URendererSettings.__PropertyMask_bTemporalUpsampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTemporalUpsampling) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bTemporalUpsampling) & ~URendererSettings.__PropertyMask_bTemporalUpsampling) | (value ? URendererSettings.__PropertyMask_bTemporalUpsampling : 0));
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600F0B2 RID: 61618 RVA: 0x0016500E File Offset: 0x0016320E
		// (set) Token: 0x0600F0B3 RID: 61619 RVA: 0x00165027 File Offset: 0x00163227
		public unsafe bool bSSGI
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSSGI) & URendererSettings.__PropertyMask_bSSGI) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSSGI) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSSGI) & ~URendererSettings.__PropertyMask_bSSGI) | (value ? URendererSettings.__PropertyMask_bSSGI : 0));
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600F0B4 RID: 61620 RVA: 0x00165057 File Offset: 0x00163257
		// (set) Token: 0x0600F0B5 RID: 61621 RVA: 0x0016506B File Offset: 0x0016326B
		public unsafe TEnumAsByte<EAntiAliasingMethod> DefaultFeatureAntiAliasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAntiAliasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultFeatureAntiAliasing) = value;
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600F0B6 RID: 61622 RVA: 0x00165080 File Offset: 0x00163280
		// (set) Token: 0x0600F0B7 RID: 61623 RVA: 0x00165099 File Offset: 0x00163299
		public unsafe bool bEnableKuroFogRendering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroFogRendering) & URendererSettings.__PropertyMask_bEnableKuroFogRendering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroFogRendering) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroFogRendering) & ~URendererSettings.__PropertyMask_bEnableKuroFogRendering) | (value ? URendererSettings.__PropertyMask_bEnableKuroFogRendering : 0));
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600F0B8 RID: 61624 RVA: 0x001650C9 File Offset: 0x001632C9
		// (set) Token: 0x0600F0B9 RID: 61625 RVA: 0x001650E2 File Offset: 0x001632E2
		public unsafe bool bEnableKuroMobileGGX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroMobileGGX) & URendererSettings.__PropertyMask_bEnableKuroMobileGGX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroMobileGGX) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableKuroMobileGGX) & ~URendererSettings.__PropertyMask_bEnableKuroMobileGGX) | (value ? URendererSettings.__PropertyMask_bEnableKuroMobileGGX : 0));
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600F0BA RID: 61626 RVA: 0x00165112 File Offset: 0x00163312
		// (set) Token: 0x0600F0BB RID: 61627 RVA: 0x0016512B File Offset: 0x0016332B
		public unsafe bool KuroRenderSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroRenderSwitch) & URendererSettings.__PropertyMask_KuroRenderSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroRenderSwitch) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroRenderSwitch) & ~URendererSettings.__PropertyMask_KuroRenderSwitch) | (value ? URendererSettings.__PropertyMask_KuroRenderSwitch : 0));
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600F0BC RID: 61628 RVA: 0x0016515B File Offset: 0x0016335B
		// (set) Token: 0x0600F0BD RID: 61629 RVA: 0x0016516F File Offset: 0x0016336F
		public unsafe FVector4 KuroLightCullDistanceType1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType1) = value;
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600F0BE RID: 61630 RVA: 0x00165184 File Offset: 0x00163384
		// (set) Token: 0x0600F0BF RID: 61631 RVA: 0x00165198 File Offset: 0x00163398
		public unsafe FVector4 KuroLightCullDistanceType2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType2) = value;
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600F0C0 RID: 61632 RVA: 0x001651AD File Offset: 0x001633AD
		// (set) Token: 0x0600F0C1 RID: 61633 RVA: 0x001651C1 File Offset: 0x001633C1
		public unsafe FVector4 KuroLightCullDistanceType3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType3) = value;
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600F0C2 RID: 61634 RVA: 0x001651D6 File Offset: 0x001633D6
		// (set) Token: 0x0600F0C3 RID: 61635 RVA: 0x001651EA File Offset: 0x001633EA
		public unsafe FVector4 KuroLightCullDistanceType4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType4) = value;
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600F0C4 RID: 61636 RVA: 0x001651FF File Offset: 0x001633FF
		// (set) Token: 0x0600F0C5 RID: 61637 RVA: 0x00165213 File Offset: 0x00163413
		public unsafe FVector4 KuroLightCullDistanceType5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroLightCullDistanceType5) = value;
			}
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600F0C6 RID: 61638 RVA: 0x00165228 File Offset: 0x00163428
		// (set) Token: 0x0600F0C7 RID: 61639 RVA: 0x0016523C File Offset: 0x0016343C
		public unsafe FVector4 KuroMobileLightCullDistanceType1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType1) = value;
			}
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600F0C8 RID: 61640 RVA: 0x00165251 File Offset: 0x00163451
		// (set) Token: 0x0600F0C9 RID: 61641 RVA: 0x00165265 File Offset: 0x00163465
		public unsafe FVector4 KuroMobileLightCullDistanceType2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType2) = value;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600F0CA RID: 61642 RVA: 0x0016527A File Offset: 0x0016347A
		// (set) Token: 0x0600F0CB RID: 61643 RVA: 0x0016528E File Offset: 0x0016348E
		public unsafe FVector4 KuroMobileLightCullDistanceType3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType3) = value;
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600F0CC RID: 61644 RVA: 0x001652A3 File Offset: 0x001634A3
		// (set) Token: 0x0600F0CD RID: 61645 RVA: 0x001652B7 File Offset: 0x001634B7
		public unsafe FVector4 KuroMobileLightCullDistanceType4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType4) = value;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600F0CE RID: 61646 RVA: 0x001652CC File Offset: 0x001634CC
		// (set) Token: 0x0600F0CF RID: 61647 RVA: 0x001652E0 File Offset: 0x001634E0
		public unsafe FVector4 KuroMobileLightCullDistanceType5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroMobileLightCullDistanceType5) = value;
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600F0D0 RID: 61648 RVA: 0x001652F5 File Offset: 0x001634F5
		// (set) Token: 0x0600F0D1 RID: 61649 RVA: 0x00165309 File Offset: 0x00163509
		public unsafe FVector4 KuroCGModeLightCullDistanceType1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType1) = value;
			}
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0600F0D2 RID: 61650 RVA: 0x0016531E File Offset: 0x0016351E
		// (set) Token: 0x0600F0D3 RID: 61651 RVA: 0x00165332 File Offset: 0x00163532
		public unsafe FVector4 KuroCGModeLightCullDistanceType2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType2) = value;
			}
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600F0D4 RID: 61652 RVA: 0x00165347 File Offset: 0x00163547
		// (set) Token: 0x0600F0D5 RID: 61653 RVA: 0x0016535B File Offset: 0x0016355B
		public unsafe FVector4 KuroCGModeLightCullDistanceType3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType3) = value;
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x00165370 File Offset: 0x00163570
		// (set) Token: 0x0600F0D7 RID: 61655 RVA: 0x00165384 File Offset: 0x00163584
		public unsafe FVector4 KuroCGModeLightCullDistanceType4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType4) = value;
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600F0D8 RID: 61656 RVA: 0x00165399 File Offset: 0x00163599
		// (set) Token: 0x0600F0D9 RID: 61657 RVA: 0x001653AD File Offset: 0x001635AD
		public unsafe FVector4 KuroCGModeLightCullDistanceType5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroCGModeLightCullDistanceType5) = value;
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600F0DA RID: 61658 RVA: 0x001653C2 File Offset: 0x001635C2
		// (set) Token: 0x0600F0DB RID: 61659 RVA: 0x001653D2 File Offset: 0x001635D2
		public unsafe float EnableKuroFoliageCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_EnableKuroFoliageCulling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_EnableKuroFoliageCulling) = value;
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600F0DC RID: 61660 RVA: 0x001653E3 File Offset: 0x001635E3
		// (set) Token: 0x0600F0DD RID: 61661 RVA: 0x001653F3 File Offset: 0x001635F3
		public unsafe float KuroFoliageNearCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageNearCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageNearCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600F0DE RID: 61662 RVA: 0x00165404 File Offset: 0x00163604
		// (set) Token: 0x0600F0DF RID: 61663 RVA: 0x00165414 File Offset: 0x00163614
		public unsafe float KuroFoliageNearCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageNearCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageNearCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600F0E0 RID: 61664 RVA: 0x00165425 File Offset: 0x00163625
		// (set) Token: 0x0600F0E1 RID: 61665 RVA: 0x00165435 File Offset: 0x00163635
		public unsafe float KuroFoliageMobileNearCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileNearCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileNearCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600F0E2 RID: 61666 RVA: 0x00165446 File Offset: 0x00163646
		// (set) Token: 0x0600F0E3 RID: 61667 RVA: 0x00165456 File Offset: 0x00163656
		public unsafe float KuroFoliageMobileNearCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileNearCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileNearCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600F0E4 RID: 61668 RVA: 0x00165467 File Offset: 0x00163667
		// (set) Token: 0x0600F0E5 RID: 61669 RVA: 0x00165477 File Offset: 0x00163677
		public unsafe float KuroFoliageMiddleCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMiddleCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMiddleCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600F0E6 RID: 61670 RVA: 0x00165488 File Offset: 0x00163688
		// (set) Token: 0x0600F0E7 RID: 61671 RVA: 0x00165498 File Offset: 0x00163698
		public unsafe float KuroFoliageMiddleCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMiddleCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMiddleCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0600F0E8 RID: 61672 RVA: 0x001654A9 File Offset: 0x001636A9
		// (set) Token: 0x0600F0E9 RID: 61673 RVA: 0x001654B9 File Offset: 0x001636B9
		public unsafe float KuroFoliageMobileMiddleCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileMiddleCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileMiddleCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600F0EA RID: 61674 RVA: 0x001654CA File Offset: 0x001636CA
		// (set) Token: 0x0600F0EB RID: 61675 RVA: 0x001654DA File Offset: 0x001636DA
		public unsafe float KuroFoliageMobileMiddleCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileMiddleCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileMiddleCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x001654EB File Offset: 0x001636EB
		// (set) Token: 0x0600F0ED RID: 61677 RVA: 0x001654FB File Offset: 0x001636FB
		public unsafe float KuroFoliageFarCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageFarCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageFarCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600F0EE RID: 61678 RVA: 0x0016550C File Offset: 0x0016370C
		// (set) Token: 0x0600F0EF RID: 61679 RVA: 0x0016551C File Offset: 0x0016371C
		public unsafe float KuroFoliageFarCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageFarCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageFarCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600F0F0 RID: 61680 RVA: 0x0016552D File Offset: 0x0016372D
		// (set) Token: 0x0600F0F1 RID: 61681 RVA: 0x0016553D File Offset: 0x0016373D
		public unsafe float KuroFoliageMobileFarCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileFarCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileFarCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600F0F2 RID: 61682 RVA: 0x0016554E File Offset: 0x0016374E
		// (set) Token: 0x0600F0F3 RID: 61683 RVA: 0x0016555E File Offset: 0x0016375E
		public unsafe float KuroFoliageMobileFarCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileFarCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileFarCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600F0F4 RID: 61684 RVA: 0x0016556F File Offset: 0x0016376F
		// (set) Token: 0x0600F0F5 RID: 61685 RVA: 0x0016557F File Offset: 0x0016377F
		public unsafe float KuroFoliageSuperFarCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageSuperFarCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageSuperFarCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600F0F6 RID: 61686 RVA: 0x00165590 File Offset: 0x00163790
		// (set) Token: 0x0600F0F7 RID: 61687 RVA: 0x001655A0 File Offset: 0x001637A0
		public unsafe float KuroFoliageSuperFarCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageSuperFarCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageSuperFarCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600F0F8 RID: 61688 RVA: 0x001655B1 File Offset: 0x001637B1
		// (set) Token: 0x0600F0F9 RID: 61689 RVA: 0x001655C1 File Offset: 0x001637C1
		public unsafe float KuroFoliageMobileSuperFarCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600F0FA RID: 61690 RVA: 0x001655D2 File Offset: 0x001637D2
		// (set) Token: 0x0600F0FB RID: 61691 RVA: 0x001655E2 File Offset: 0x001637E2
		public unsafe float KuroFoliageMobileSuperFarCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600F0FC RID: 61692 RVA: 0x001655F3 File Offset: 0x001637F3
		// (set) Token: 0x0600F0FD RID: 61693 RVA: 0x00165603 File Offset: 0x00163803
		public unsafe float KuroImpostorFoliageCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorFoliageCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorFoliageCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600F0FE RID: 61694 RVA: 0x00165614 File Offset: 0x00163814
		// (set) Token: 0x0600F0FF RID: 61695 RVA: 0x00165624 File Offset: 0x00163824
		public unsafe float KuroImpostorFoliageCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorFoliageCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorFoliageCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600F100 RID: 61696 RVA: 0x00165635 File Offset: 0x00163835
		// (set) Token: 0x0600F101 RID: 61697 RVA: 0x00165645 File Offset: 0x00163845
		public unsafe float KuroImpostorMobileFoliageCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorMobileFoliageCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorMobileFoliageCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600F102 RID: 61698 RVA: 0x00165656 File Offset: 0x00163856
		// (set) Token: 0x0600F103 RID: 61699 RVA: 0x00165666 File Offset: 0x00163866
		public unsafe float KuroImpostorMobileFoliageCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorMobileFoliageCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroImpostorMobileFoliageCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600F104 RID: 61700 RVA: 0x00165677 File Offset: 0x00163877
		// (set) Token: 0x0600F105 RID: 61701 RVA: 0x00165687 File Offset: 0x00163887
		public unsafe float KuroGrassFoliageCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassFoliageCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassFoliageCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600F106 RID: 61702 RVA: 0x00165698 File Offset: 0x00163898
		// (set) Token: 0x0600F107 RID: 61703 RVA: 0x001656A8 File Offset: 0x001638A8
		public unsafe float KuroGrassFoliageCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassFoliageCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassFoliageCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600F108 RID: 61704 RVA: 0x001656B9 File Offset: 0x001638B9
		// (set) Token: 0x0600F109 RID: 61705 RVA: 0x001656C9 File Offset: 0x001638C9
		public unsafe float KuroGrassMobileFoliageCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassMobileFoliageCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassMobileFoliageCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600F10A RID: 61706 RVA: 0x001656DA File Offset: 0x001638DA
		// (set) Token: 0x0600F10B RID: 61707 RVA: 0x001656EA File Offset: 0x001638EA
		public unsafe float KuroGrassMobileFoliageCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassMobileFoliageCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroGrassMobileFoliageCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600F10C RID: 61708 RVA: 0x001656FB File Offset: 0x001638FB
		// (set) Token: 0x0600F10D RID: 61709 RVA: 0x0016570B File Offset: 0x0016390B
		public unsafe float KuroPcgCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600F10E RID: 61710 RVA: 0x0016571C File Offset: 0x0016391C
		// (set) Token: 0x0600F10F RID: 61711 RVA: 0x0016572C File Offset: 0x0016392C
		public unsafe float KuroPcgCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600F110 RID: 61712 RVA: 0x0016573D File Offset: 0x0016393D
		// (set) Token: 0x0600F111 RID: 61713 RVA: 0x0016574D File Offset: 0x0016394D
		public unsafe float KuroPcgMobileCullDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgMobileCullDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgMobileCullDistanceMin) = value;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600F112 RID: 61714 RVA: 0x0016575E File Offset: 0x0016395E
		// (set) Token: 0x0600F113 RID: 61715 RVA: 0x0016576E File Offset: 0x0016396E
		public unsafe float KuroPcgMobileCullDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgMobileCullDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroPcgMobileCullDistanceMax) = value;
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600F114 RID: 61716 RVA: 0x00165780 File Offset: 0x00163980
		// (set) Token: 0x0600F115 RID: 61717 RVA: 0x001657B9 File Offset: 0x001639B9
		[Nullable(1)]
		public FSoftObjectPath VolumeNoisePath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._VolumeNoisePath) == null)
				{
					result = (this._VolumeNoisePath = new FSoftObjectPath(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VolumeNoisePath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VolumeNoisePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x001657DA File Offset: 0x001639DA
		// (set) Token: 0x0600F117 RID: 61719 RVA: 0x001657EA File Offset: 0x001639EA
		public unsafe float WaveLengthHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthHigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthHigh) = value;
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x001657FB File Offset: 0x001639FB
		// (set) Token: 0x0600F119 RID: 61721 RVA: 0x0016580B File Offset: 0x00163A0B
		public unsafe float WaveLengthMedium
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthMedium);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthMedium) = value;
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600F11A RID: 61722 RVA: 0x0016581C File Offset: 0x00163A1C
		// (set) Token: 0x0600F11B RID: 61723 RVA: 0x0016582C File Offset: 0x00163A2C
		public unsafe float WaveLengthLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WaveLengthLow) = value;
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600F11C RID: 61724 RVA: 0x0016583D File Offset: 0x00163A3D
		// (set) Token: 0x0600F11D RID: 61725 RVA: 0x0016584D File Offset: 0x00163A4D
		public unsafe float KuroVolumetricCloudPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroVolumetricCloudPhaseG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_KuroVolumetricCloudPhaseG) = value;
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600F11E RID: 61726 RVA: 0x0016585E File Offset: 0x00163A5E
		// (set) Token: 0x0600F11F RID: 61727 RVA: 0x0016586E File Offset: 0x00163A6E
		public unsafe ELightUnits DefaultLightUnits
		{
			get
			{
				return (ELightUnits)(*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultLightUnits));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultLightUnits) = (byte)value;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600F120 RID: 61728 RVA: 0x0016587F File Offset: 0x00163A7F
		// (set) Token: 0x0600F121 RID: 61729 RVA: 0x00165893 File Offset: 0x00163A93
		public unsafe TEnumAsByte<EDefaultBackBufferPixelFormat> DefaultBackBufferPixelFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultBackBufferPixelFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultBackBufferPixelFormat) = value;
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600F122 RID: 61730 RVA: 0x001658A8 File Offset: 0x00163AA8
		// (set) Token: 0x0600F123 RID: 61731 RVA: 0x001658C1 File Offset: 0x00163AC1
		public unsafe bool bRenderUnbuiltPreviewShadowsInGame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRenderUnbuiltPreviewShadowsInGame) & URendererSettings.__PropertyMask_bRenderUnbuiltPreviewShadowsInGame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRenderUnbuiltPreviewShadowsInGame) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRenderUnbuiltPreviewShadowsInGame) & ~URendererSettings.__PropertyMask_bRenderUnbuiltPreviewShadowsInGame) | (value ? URendererSettings.__PropertyMask_bRenderUnbuiltPreviewShadowsInGame : 0));
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600F124 RID: 61732 RVA: 0x001658F1 File Offset: 0x00163AF1
		// (set) Token: 0x0600F125 RID: 61733 RVA: 0x0016590A File Offset: 0x00163B0A
		public unsafe bool bStencilForLODDither
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bStencilForLODDither) & URendererSettings.__PropertyMask_bStencilForLODDither) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bStencilForLODDither) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bStencilForLODDither) & ~URendererSettings.__PropertyMask_bStencilForLODDither) | (value ? URendererSettings.__PropertyMask_bStencilForLODDither : 0));
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600F126 RID: 61734 RVA: 0x0016593A File Offset: 0x00163B3A
		// (set) Token: 0x0600F127 RID: 61735 RVA: 0x0016594E File Offset: 0x00163B4E
		public unsafe TEnumAsByte<EEarlyZPass> EarlyZPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_EarlyZPass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_EarlyZPass) = value;
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600F128 RID: 61736 RVA: 0x00165963 File Offset: 0x00163B63
		// (set) Token: 0x0600F129 RID: 61737 RVA: 0x0016597C File Offset: 0x00163B7C
		public unsafe bool bEarlyZPassOnlyMaterialMasking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEarlyZPassOnlyMaterialMasking) & URendererSettings.__PropertyMask_bEarlyZPassOnlyMaterialMasking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEarlyZPassOnlyMaterialMasking) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEarlyZPassOnlyMaterialMasking) & ~URendererSettings.__PropertyMask_bEarlyZPassOnlyMaterialMasking) | (value ? URendererSettings.__PropertyMask_bEarlyZPassOnlyMaterialMasking : 0));
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x001659AC File Offset: 0x00163BAC
		// (set) Token: 0x0600F12B RID: 61739 RVA: 0x001659C5 File Offset: 0x00163BC5
		public unsafe bool bDBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDBuffer) & URendererSettings.__PropertyMask_bDBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDBuffer) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDBuffer) & ~URendererSettings.__PropertyMask_bDBuffer) | (value ? URendererSettings.__PropertyMask_bDBuffer : 0));
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600F12C RID: 61740 RVA: 0x001659F5 File Offset: 0x00163BF5
		// (set) Token: 0x0600F12D RID: 61741 RVA: 0x00165A09 File Offset: 0x00163C09
		public unsafe TEnumAsByte<EClearSceneOptions> ClearSceneMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ClearSceneMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_ClearSceneMethod) = value;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600F12E RID: 61742 RVA: 0x00165A1E File Offset: 0x00163C1E
		// (set) Token: 0x0600F12F RID: 61743 RVA: 0x00165A37 File Offset: 0x00163C37
		public unsafe bool bBasePassOutputsVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bBasePassOutputsVelocity) & URendererSettings.__PropertyMask_bBasePassOutputsVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bBasePassOutputsVelocity) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bBasePassOutputsVelocity) & ~URendererSettings.__PropertyMask_bBasePassOutputsVelocity) | (value ? URendererSettings.__PropertyMask_bBasePassOutputsVelocity : 0));
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600F130 RID: 61744 RVA: 0x00165A67 File Offset: 0x00163C67
		// (set) Token: 0x0600F131 RID: 61745 RVA: 0x00165A80 File Offset: 0x00163C80
		public unsafe bool bVertexDeformationOutputsVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexDeformationOutputsVelocity) & URendererSettings.__PropertyMask_bVertexDeformationOutputsVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexDeformationOutputsVelocity) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bVertexDeformationOutputsVelocity) & ~URendererSettings.__PropertyMask_bVertexDeformationOutputsVelocity) | (value ? URendererSettings.__PropertyMask_bVertexDeformationOutputsVelocity : 0));
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600F132 RID: 61746 RVA: 0x00165AB0 File Offset: 0x00163CB0
		// (set) Token: 0x0600F133 RID: 61747 RVA: 0x00165AC9 File Offset: 0x00163CC9
		public unsafe bool bSelectiveBasePassOutputs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSelectiveBasePassOutputs) & URendererSettings.__PropertyMask_bSelectiveBasePassOutputs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSelectiveBasePassOutputs) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSelectiveBasePassOutputs) & ~URendererSettings.__PropertyMask_bSelectiveBasePassOutputs) | (value ? URendererSettings.__PropertyMask_bSelectiveBasePassOutputs : 0));
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600F134 RID: 61748 RVA: 0x00165AF9 File Offset: 0x00163CF9
		// (set) Token: 0x0600F135 RID: 61749 RVA: 0x00165B12 File Offset: 0x00163D12
		public unsafe bool bDefaultParticleCutouts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultParticleCutouts) & URendererSettings.__PropertyMask_bDefaultParticleCutouts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultParticleCutouts) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDefaultParticleCutouts) & ~URendererSettings.__PropertyMask_bDefaultParticleCutouts) | (value ? URendererSettings.__PropertyMask_bDefaultParticleCutouts : 0));
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x00165B42 File Offset: 0x00163D42
		// (set) Token: 0x0600F137 RID: 61751 RVA: 0x00165B52 File Offset: 0x00163D52
		public unsafe int GPUSimulationTextureSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GPUSimulationTextureSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GPUSimulationTextureSizeX) = value;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600F138 RID: 61752 RVA: 0x00165B63 File Offset: 0x00163D63
		// (set) Token: 0x0600F139 RID: 61753 RVA: 0x00165B73 File Offset: 0x00163D73
		public unsafe int GPUSimulationTextureSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GPUSimulationTextureSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GPUSimulationTextureSizeY) = value;
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600F13A RID: 61754 RVA: 0x00165B84 File Offset: 0x00163D84
		// (set) Token: 0x0600F13B RID: 61755 RVA: 0x00165B9D File Offset: 0x00163D9D
		public unsafe bool bGlobalClipPlane
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGlobalClipPlane) & URendererSettings.__PropertyMask_bGlobalClipPlane) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGlobalClipPlane) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGlobalClipPlane) & ~URendererSettings.__PropertyMask_bGlobalClipPlane) | (value ? URendererSettings.__PropertyMask_bGlobalClipPlane : 0));
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600F13C RID: 61756 RVA: 0x00165BCD File Offset: 0x00163DCD
		// (set) Token: 0x0600F13D RID: 61757 RVA: 0x00165BE1 File Offset: 0x00163DE1
		public unsafe TEnumAsByte<EGBufferFormat> GBufferFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GBufferFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_GBufferFormat) = value;
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600F13E RID: 61758 RVA: 0x00165BF6 File Offset: 0x00163DF6
		// (set) Token: 0x0600F13F RID: 61759 RVA: 0x00165C0F File Offset: 0x00163E0F
		public unsafe bool bUseGPUMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseGPUMorphTargets) & URendererSettings.__PropertyMask_bUseGPUMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseGPUMorphTargets) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseGPUMorphTargets) & ~URendererSettings.__PropertyMask_bUseGPUMorphTargets) | (value ? URendererSettings.__PropertyMask_bUseGPUMorphTargets : 0));
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600F140 RID: 61760 RVA: 0x00165C3F File Offset: 0x00163E3F
		// (set) Token: 0x0600F141 RID: 61761 RVA: 0x00165C58 File Offset: 0x00163E58
		public unsafe bool bNvidiaAftermathEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bNvidiaAftermathEnabled) & URendererSettings.__PropertyMask_bNvidiaAftermathEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bNvidiaAftermathEnabled) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bNvidiaAftermathEnabled) & ~URendererSettings.__PropertyMask_bNvidiaAftermathEnabled) | (value ? URendererSettings.__PropertyMask_bNvidiaAftermathEnabled : 0));
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600F142 RID: 61762 RVA: 0x00165C88 File Offset: 0x00163E88
		// (set) Token: 0x0600F143 RID: 61763 RVA: 0x00165CA1 File Offset: 0x00163EA1
		public unsafe bool bMultiView
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMultiView) & URendererSettings.__PropertyMask_bMultiView) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMultiView) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMultiView) & ~URendererSettings.__PropertyMask_bMultiView) | (value ? URendererSettings.__PropertyMask_bMultiView : 0));
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600F144 RID: 61764 RVA: 0x00165CD1 File Offset: 0x00163ED1
		// (set) Token: 0x0600F145 RID: 61765 RVA: 0x00165CEA File Offset: 0x00163EEA
		public unsafe bool bMobilePostProcessing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobilePostProcessing) & URendererSettings.__PropertyMask_bMobilePostProcessing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobilePostProcessing) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobilePostProcessing) & ~URendererSettings.__PropertyMask_bMobilePostProcessing) | (value ? URendererSettings.__PropertyMask_bMobilePostProcessing : 0));
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600F146 RID: 61766 RVA: 0x00165D1A File Offset: 0x00163F1A
		// (set) Token: 0x0600F147 RID: 61767 RVA: 0x00165D33 File Offset: 0x00163F33
		public unsafe bool bMobileMultiView
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileMultiView) & URendererSettings.__PropertyMask_bMobileMultiView) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileMultiView) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileMultiView) & ~URendererSettings.__PropertyMask_bMobileMultiView) | (value ? URendererSettings.__PropertyMask_bMobileMultiView : 0));
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600F148 RID: 61768 RVA: 0x00165D63 File Offset: 0x00163F63
		// (set) Token: 0x0600F149 RID: 61769 RVA: 0x00165D7C File Offset: 0x00163F7C
		public unsafe bool bMobileUseHWsRGBEncoding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileUseHWsRGBEncoding) & URendererSettings.__PropertyMask_bMobileUseHWsRGBEncoding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileUseHWsRGBEncoding) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileUseHWsRGBEncoding) & ~URendererSettings.__PropertyMask_bMobileUseHWsRGBEncoding) | (value ? URendererSettings.__PropertyMask_bMobileUseHWsRGBEncoding : 0));
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600F14A RID: 61770 RVA: 0x00165DAC File Offset: 0x00163FAC
		// (set) Token: 0x0600F14B RID: 61771 RVA: 0x00165DC5 File Offset: 0x00163FC5
		public unsafe bool bRoundRobinOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRoundRobinOcclusion) & URendererSettings.__PropertyMask_bRoundRobinOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRoundRobinOcclusion) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bRoundRobinOcclusion) & ~URendererSettings.__PropertyMask_bRoundRobinOcclusion) | (value ? URendererSettings.__PropertyMask_bRoundRobinOcclusion : 0));
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600F14C RID: 61772 RVA: 0x00165DF5 File Offset: 0x00163FF5
		// (set) Token: 0x0600F14D RID: 61773 RVA: 0x00165E0E File Offset: 0x0016400E
		public unsafe bool bODSCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bODSCapture) & URendererSettings.__PropertyMask_bODSCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bODSCapture) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bODSCapture) & ~URendererSettings.__PropertyMask_bODSCapture) | (value ? URendererSettings.__PropertyMask_bODSCapture : 0));
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600F14E RID: 61774 RVA: 0x00165E3E File Offset: 0x0016403E
		// (set) Token: 0x0600F14F RID: 61775 RVA: 0x00165E57 File Offset: 0x00164057
		public unsafe bool bMeshStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMeshStreaming) & URendererSettings.__PropertyMask_bMeshStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMeshStreaming) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMeshStreaming) & ~URendererSettings.__PropertyMask_bMeshStreaming) | (value ? URendererSettings.__PropertyMask_bMeshStreaming : 0));
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600F150 RID: 61776 RVA: 0x00165E87 File Offset: 0x00164087
		// (set) Token: 0x0600F151 RID: 61777 RVA: 0x00165E97 File Offset: 0x00164097
		public unsafe float WireframeCullThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WireframeCullThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_WireframeCullThreshold) = value;
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600F152 RID: 61778 RVA: 0x00165EA8 File Offset: 0x001640A8
		// (set) Token: 0x0600F153 RID: 61779 RVA: 0x00165EC1 File Offset: 0x001640C1
		public unsafe bool bEnableMegaLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableMegaLights) & URendererSettings.__PropertyMask_bEnableMegaLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableMegaLights) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableMegaLights) & ~URendererSettings.__PropertyMask_bEnableMegaLights) | (value ? URendererSettings.__PropertyMask_bEnableMegaLights : 0));
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600F154 RID: 61780 RVA: 0x00165EF1 File Offset: 0x001640F1
		// (set) Token: 0x0600F155 RID: 61781 RVA: 0x00165F0A File Offset: 0x0016410A
		public unsafe bool bEnableRayTracingShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingShadows) & URendererSettings.__PropertyMask_bEnableRayTracingShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingShadows) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingShadows) & ~URendererSettings.__PropertyMask_bEnableRayTracingShadows) | (value ? URendererSettings.__PropertyMask_bEnableRayTracingShadows : 0));
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600F156 RID: 61782 RVA: 0x00165F3A File Offset: 0x0016413A
		// (set) Token: 0x0600F157 RID: 61783 RVA: 0x00165F53 File Offset: 0x00164153
		public unsafe bool bEnableRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracing) & URendererSettings.__PropertyMask_bEnableRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracing) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracing) & ~URendererSettings.__PropertyMask_bEnableRayTracing) | (value ? URendererSettings.__PropertyMask_bEnableRayTracing : 0));
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600F158 RID: 61784 RVA: 0x00165F83 File Offset: 0x00164183
		// (set) Token: 0x0600F159 RID: 61785 RVA: 0x00165F9C File Offset: 0x0016419C
		public unsafe bool bEnableRayTracingTextureLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingTextureLOD) & URendererSettings.__PropertyMask_bEnableRayTracingTextureLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingTextureLOD) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bEnableRayTracingTextureLOD) & ~URendererSettings.__PropertyMask_bEnableRayTracingTextureLOD) | (value ? URendererSettings.__PropertyMask_bEnableRayTracingTextureLOD : 0));
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600F15A RID: 61786 RVA: 0x00165FCC File Offset: 0x001641CC
		// (set) Token: 0x0600F15B RID: 61787 RVA: 0x00165FE5 File Offset: 0x001641E5
		public unsafe bool bSupportStationarySkylight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportStationarySkylight) & URendererSettings.__PropertyMask_bSupportStationarySkylight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportStationarySkylight) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportStationarySkylight) & ~URendererSettings.__PropertyMask_bSupportStationarySkylight) | (value ? URendererSettings.__PropertyMask_bSupportStationarySkylight : 0));
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600F15C RID: 61788 RVA: 0x00166015 File Offset: 0x00164215
		// (set) Token: 0x0600F15D RID: 61789 RVA: 0x0016602E File Offset: 0x0016422E
		public unsafe bool bSupportLowQualityLightmaps
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportLowQualityLightmaps) & URendererSettings.__PropertyMask_bSupportLowQualityLightmaps) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportLowQualityLightmaps) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportLowQualityLightmaps) & ~URendererSettings.__PropertyMask_bSupportLowQualityLightmaps) | (value ? URendererSettings.__PropertyMask_bSupportLowQualityLightmaps : 0));
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600F15E RID: 61790 RVA: 0x0016605E File Offset: 0x0016425E
		// (set) Token: 0x0600F15F RID: 61791 RVA: 0x00166077 File Offset: 0x00164277
		public unsafe bool bSupportPointLightWholeSceneShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportPointLightWholeSceneShadows) & URendererSettings.__PropertyMask_bSupportPointLightWholeSceneShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportPointLightWholeSceneShadows) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportPointLightWholeSceneShadows) & ~URendererSettings.__PropertyMask_bSupportPointLightWholeSceneShadows) | (value ? URendererSettings.__PropertyMask_bSupportPointLightWholeSceneShadows : 0));
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600F160 RID: 61792 RVA: 0x001660A7 File Offset: 0x001642A7
		// (set) Token: 0x0600F161 RID: 61793 RVA: 0x001660C0 File Offset: 0x001642C0
		public unsafe bool bSupportAtmosphericFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportAtmosphericFog) & URendererSettings.__PropertyMask_bSupportAtmosphericFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportAtmosphericFog) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportAtmosphericFog) & ~URendererSettings.__PropertyMask_bSupportAtmosphericFog) | (value ? URendererSettings.__PropertyMask_bSupportAtmosphericFog : 0));
			}
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600F162 RID: 61794 RVA: 0x001660F0 File Offset: 0x001642F0
		// (set) Token: 0x0600F163 RID: 61795 RVA: 0x00166109 File Offset: 0x00164309
		public unsafe bool bSupportSkyAtmosphere
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphere) & URendererSettings.__PropertyMask_bSupportSkyAtmosphere) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphere) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphere) & ~URendererSettings.__PropertyMask_bSupportSkyAtmosphere) | (value ? URendererSettings.__PropertyMask_bSupportSkyAtmosphere : 0));
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600F164 RID: 61796 RVA: 0x00166139 File Offset: 0x00164339
		// (set) Token: 0x0600F165 RID: 61797 RVA: 0x00166152 File Offset: 0x00164352
		public unsafe bool bSupportSkyAtmosphereAffectsHeightFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphereAffectsHeightFog) & URendererSettings.__PropertyMask_bSupportSkyAtmosphereAffectsHeightFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphereAffectsHeightFog) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkyAtmosphereAffectsHeightFog) & ~URendererSettings.__PropertyMask_bSupportSkyAtmosphereAffectsHeightFog) | (value ? URendererSettings.__PropertyMask_bSupportSkyAtmosphereAffectsHeightFog : 0));
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0600F166 RID: 61798 RVA: 0x00166182 File Offset: 0x00164382
		// (set) Token: 0x0600F167 RID: 61799 RVA: 0x0016619B File Offset: 0x0016439B
		public unsafe bool bSupportSkinCacheShaders
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkinCacheShaders) & URendererSettings.__PropertyMask_bSupportSkinCacheShaders) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkinCacheShaders) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportSkinCacheShaders) & ~URendererSettings.__PropertyMask_bSupportSkinCacheShaders) | (value ? URendererSettings.__PropertyMask_bSupportSkinCacheShaders : 0));
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600F168 RID: 61800 RVA: 0x001661CB File Offset: 0x001643CB
		// (set) Token: 0x0600F169 RID: 61801 RVA: 0x001661DB File Offset: 0x001643DB
		public unsafe ESkinCacheDefaultBehavior DefaultSkinCacheBehavior
		{
			get
			{
				return (ESkinCacheDefaultBehavior)(*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultSkinCacheBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_DefaultSkinCacheBehavior) = (byte)value;
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600F16A RID: 61802 RVA: 0x001661EC File Offset: 0x001643EC
		// (set) Token: 0x0600F16B RID: 61803 RVA: 0x001661FC File Offset: 0x001643FC
		public unsafe float SkinCacheSceneMemoryLimitInMB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_SkinCacheSceneMemoryLimitInMB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_SkinCacheSceneMemoryLimitInMB) = value;
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600F16C RID: 61804 RVA: 0x0016620D File Offset: 0x0016440D
		// (set) Token: 0x0600F16D RID: 61805 RVA: 0x00166226 File Offset: 0x00164426
		public unsafe bool bMobileEnableStaticAndCSMShadowReceivers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableStaticAndCSMShadowReceivers) & URendererSettings.__PropertyMask_bMobileEnableStaticAndCSMShadowReceivers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableStaticAndCSMShadowReceivers) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableStaticAndCSMShadowReceivers) & ~URendererSettings.__PropertyMask_bMobileEnableStaticAndCSMShadowReceivers) | (value ? URendererSettings.__PropertyMask_bMobileEnableStaticAndCSMShadowReceivers : 0));
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600F16E RID: 61806 RVA: 0x00166256 File Offset: 0x00164456
		// (set) Token: 0x0600F16F RID: 61807 RVA: 0x0016626F File Offset: 0x0016446F
		public unsafe bool bMobileEnableMovableLightCSMShaderCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableMovableLightCSMShaderCulling) & URendererSettings.__PropertyMask_bMobileEnableMovableLightCSMShaderCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableMovableLightCSMShaderCulling) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileEnableMovableLightCSMShaderCulling) & ~URendererSettings.__PropertyMask_bMobileEnableMovableLightCSMShaderCulling) | (value ? URendererSettings.__PropertyMask_bMobileEnableMovableLightCSMShaderCulling : 0));
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600F170 RID: 61808 RVA: 0x0016629F File Offset: 0x0016449F
		// (set) Token: 0x0600F171 RID: 61809 RVA: 0x001662B8 File Offset: 0x001644B8
		public unsafe bool bMobileAllowDistanceFieldShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDistanceFieldShadows) & URendererSettings.__PropertyMask_bMobileAllowDistanceFieldShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDistanceFieldShadows) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowDistanceFieldShadows) & ~URendererSettings.__PropertyMask_bMobileAllowDistanceFieldShadows) | (value ? URendererSettings.__PropertyMask_bMobileAllowDistanceFieldShadows : 0));
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600F172 RID: 61810 RVA: 0x001662E8 File Offset: 0x001644E8
		// (set) Token: 0x0600F173 RID: 61811 RVA: 0x00166301 File Offset: 0x00164501
		public unsafe bool bMobileAllowMovableDirectionalLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableDirectionalLights) & URendererSettings.__PropertyMask_bMobileAllowMovableDirectionalLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableDirectionalLights) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableDirectionalLights) & ~URendererSettings.__PropertyMask_bMobileAllowMovableDirectionalLights) | (value ? URendererSettings.__PropertyMask_bMobileAllowMovableDirectionalLights : 0));
			}
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600F174 RID: 61812 RVA: 0x00166331 File Offset: 0x00164531
		// (set) Token: 0x0600F175 RID: 61813 RVA: 0x00166341 File Offset: 0x00164541
		public unsafe uint MobileNumDynamicPointLights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobileNumDynamicPointLights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobileNumDynamicPointLights) = (int)value;
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600F176 RID: 61814 RVA: 0x00166352 File Offset: 0x00164552
		// (set) Token: 0x0600F177 RID: 61815 RVA: 0x0016636B File Offset: 0x0016456B
		public unsafe bool bMobileDynamicPointLightsUseStaticBranch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDynamicPointLightsUseStaticBranch) & URendererSettings.__PropertyMask_bMobileDynamicPointLightsUseStaticBranch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDynamicPointLightsUseStaticBranch) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileDynamicPointLightsUseStaticBranch) & ~URendererSettings.__PropertyMask_bMobileDynamicPointLightsUseStaticBranch) | (value ? URendererSettings.__PropertyMask_bMobileDynamicPointLightsUseStaticBranch : 0));
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600F178 RID: 61816 RVA: 0x0016639B File Offset: 0x0016459B
		// (set) Token: 0x0600F179 RID: 61817 RVA: 0x001663B4 File Offset: 0x001645B4
		public unsafe bool bMobileAllowMovableSpotlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlights) & URendererSettings.__PropertyMask_bMobileAllowMovableSpotlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlights) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlights) & ~URendererSettings.__PropertyMask_bMobileAllowMovableSpotlights) | (value ? URendererSettings.__PropertyMask_bMobileAllowMovableSpotlights : 0));
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600F17A RID: 61818 RVA: 0x001663E4 File Offset: 0x001645E4
		// (set) Token: 0x0600F17B RID: 61819 RVA: 0x001663FD File Offset: 0x001645FD
		public unsafe bool bMobileAllowMovableSpotlightShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlightShadows) & URendererSettings.__PropertyMask_bMobileAllowMovableSpotlightShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlightShadows) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAllowMovableSpotlightShadows) & ~URendererSettings.__PropertyMask_bMobileAllowMovableSpotlightShadows) | (value ? URendererSettings.__PropertyMask_bMobileAllowMovableSpotlightShadows : 0));
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600F17C RID: 61820 RVA: 0x0016642D File Offset: 0x0016462D
		// (set) Token: 0x0600F17D RID: 61821 RVA: 0x00166446 File Offset: 0x00164646
		public unsafe bool bSupport16BitBoneIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupport16BitBoneIndex) & URendererSettings.__PropertyMask_bSupport16BitBoneIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupport16BitBoneIndex) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupport16BitBoneIndex) & ~URendererSettings.__PropertyMask_bSupport16BitBoneIndex) | (value ? URendererSettings.__PropertyMask_bSupport16BitBoneIndex : 0));
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600F17E RID: 61822 RVA: 0x00166476 File Offset: 0x00164676
		// (set) Token: 0x0600F17F RID: 61823 RVA: 0x0016648F File Offset: 0x0016468F
		public unsafe bool bGPUSkinLimit2BoneInfluences
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGPUSkinLimit2BoneInfluences) & URendererSettings.__PropertyMask_bGPUSkinLimit2BoneInfluences) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGPUSkinLimit2BoneInfluences) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bGPUSkinLimit2BoneInfluences) & ~URendererSettings.__PropertyMask_bGPUSkinLimit2BoneInfluences) | (value ? URendererSettings.__PropertyMask_bGPUSkinLimit2BoneInfluences : 0));
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600F180 RID: 61824 RVA: 0x001664BF File Offset: 0x001646BF
		// (set) Token: 0x0600F181 RID: 61825 RVA: 0x001664D8 File Offset: 0x001646D8
		public unsafe bool bSupportDepthOnlyIndexBuffers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportDepthOnlyIndexBuffers) & URendererSettings.__PropertyMask_bSupportDepthOnlyIndexBuffers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportDepthOnlyIndexBuffers) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportDepthOnlyIndexBuffers) & ~URendererSettings.__PropertyMask_bSupportDepthOnlyIndexBuffers) | (value ? URendererSettings.__PropertyMask_bSupportDepthOnlyIndexBuffers : 0));
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600F182 RID: 61826 RVA: 0x00166508 File Offset: 0x00164708
		// (set) Token: 0x0600F183 RID: 61827 RVA: 0x00166521 File Offset: 0x00164721
		public unsafe bool bSupportReversedIndexBuffers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportReversedIndexBuffers) & URendererSettings.__PropertyMask_bSupportReversedIndexBuffers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportReversedIndexBuffers) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bSupportReversedIndexBuffers) & ~URendererSettings.__PropertyMask_bSupportReversedIndexBuffers) | (value ? URendererSettings.__PropertyMask_bSupportReversedIndexBuffers : 0));
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600F184 RID: 61828 RVA: 0x00166551 File Offset: 0x00164751
		// (set) Token: 0x0600F185 RID: 61829 RVA: 0x0016656A File Offset: 0x0016476A
		public unsafe bool bLPV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLPV) & URendererSettings.__PropertyMask_bLPV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLPV) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bLPV) & ~URendererSettings.__PropertyMask_bLPV) | (value ? URendererSettings.__PropertyMask_bLPV : 0));
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600F186 RID: 61830 RVA: 0x0016659A File Offset: 0x0016479A
		// (set) Token: 0x0600F187 RID: 61831 RVA: 0x001665B3 File Offset: 0x001647B3
		public unsafe bool bMobileAmbientOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAmbientOcclusion) & URendererSettings.__PropertyMask_bMobileAmbientOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAmbientOcclusion) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bMobileAmbientOcclusion) & ~URendererSettings.__PropertyMask_bMobileAmbientOcclusion) | (value ? URendererSettings.__PropertyMask_bMobileAmbientOcclusion : 0));
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600F188 RID: 61832 RVA: 0x001665E3 File Offset: 0x001647E3
		// (set) Token: 0x0600F189 RID: 61833 RVA: 0x001665FC File Offset: 0x001647FC
		public unsafe bool bUseUnlimitedBoneInfluences
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseUnlimitedBoneInfluences) & URendererSettings.__PropertyMask_bUseUnlimitedBoneInfluences) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseUnlimitedBoneInfluences) = ((*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bUseUnlimitedBoneInfluences) & ~URendererSettings.__PropertyMask_bUseUnlimitedBoneInfluences) | (value ? URendererSettings.__PropertyMask_bUseUnlimitedBoneInfluences : 0));
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600F18A RID: 61834 RVA: 0x0016662C File Offset: 0x0016482C
		// (set) Token: 0x0600F18B RID: 61835 RVA: 0x0016663C File Offset: 0x0016483C
		public unsafe int UnlimitedBonInfluencesThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_UnlimitedBonInfluencesThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_UnlimitedBonInfluencesThreshold) = value;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600F18C RID: 61836 RVA: 0x0016664D File Offset: 0x0016484D
		// (set) Token: 0x0600F18D RID: 61837 RVA: 0x00166661 File Offset: 0x00164861
		public unsafe TEnumAsByte<EMobilePlanarReflectionMode> MobilePlanarReflectionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobilePlanarReflectionMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_MobilePlanarReflectionMode) = value;
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600F18E RID: 61838 RVA: 0x00166678 File Offset: 0x00164878
		// (set) Token: 0x0600F18F RID: 61839 RVA: 0x001666B1 File Offset: 0x001648B1
		[Nullable(1)]
		public FPerPlatformBool bStreamSkeletalMeshLODs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._bStreamSkeletalMeshLODs) == null)
				{
					result = (this._bStreamSkeletalMeshLODs = new FPerPlatformBool(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bStreamSkeletalMeshLODs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bStreamSkeletalMeshLODs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600F190 RID: 61840 RVA: 0x001666D4 File Offset: 0x001648D4
		// (set) Token: 0x0600F191 RID: 61841 RVA: 0x0016670D File Offset: 0x0016490D
		[Nullable(1)]
		public FPerPlatformBool bDiscardSkeletalMeshOptionalLODs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._bDiscardSkeletalMeshOptionalLODs) == null)
				{
					result = (this._bDiscardSkeletalMeshOptionalLODs = new FPerPlatformBool(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDiscardSkeletalMeshOptionalLODs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_bDiscardSkeletalMeshOptionalLODs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600F192 RID: 61842 RVA: 0x00166730 File Offset: 0x00164930
		// (set) Token: 0x0600F193 RID: 61843 RVA: 0x00166769 File Offset: 0x00164969
		[Nullable(1)]
		public FSoftObjectPath VisualizeCalibrationColorMaterialPath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._VisualizeCalibrationColorMaterialPath) == null)
				{
					result = (this._VisualizeCalibrationColorMaterialPath = new FSoftObjectPath(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationColorMaterialPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationColorMaterialPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600F194 RID: 61844 RVA: 0x0016678C File Offset: 0x0016498C
		// (set) Token: 0x0600F195 RID: 61845 RVA: 0x001667C5 File Offset: 0x001649C5
		[Nullable(1)]
		public FSoftObjectPath VisualizeCalibrationCustomMaterialPath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._VisualizeCalibrationCustomMaterialPath) == null)
				{
					result = (this._VisualizeCalibrationCustomMaterialPath = new FSoftObjectPath(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationCustomMaterialPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationCustomMaterialPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0600F196 RID: 61846 RVA: 0x001667E8 File Offset: 0x001649E8
		// (set) Token: 0x0600F197 RID: 61847 RVA: 0x00166821 File Offset: 0x00164A21
		[Nullable(1)]
		public FSoftObjectPath VisualizeCalibrationGrayscaleMaterialPath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._VisualizeCalibrationGrayscaleMaterialPath) == null)
				{
					result = (this._VisualizeCalibrationGrayscaleMaterialPath = new FSoftObjectPath(base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationGrayscaleMaterialPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)URendererSettings.__PropertyOffset_VisualizeCalibrationGrayscaleMaterialPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600F198 RID: 61848 RVA: 0x00166842 File Offset: 0x00164A42
		static URendererSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RendererSettings");
		}

		// Token: 0x0600F199 RID: 61849 RVA: 0x00166850 File Offset: 0x00164A50
		protected URendererSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081F7 RID: 33271
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RendererSettings";

		// Token: 0x040081F8 RID: 33272
		private static IntPtr _ClassPtr;

		// Token: 0x040081F9 RID: 33273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081FA RID: 33274
		internal static int __PropertyOffset_bMobileDisableVertexFog;

		// Token: 0x040081FB RID: 33275
		internal static byte __PropertyMask_bMobileDisableVertexFog;

		// Token: 0x040081FC RID: 33276
		internal static int __PropertyOffset_MaxMobileCascades;

		// Token: 0x040081FD RID: 33277
		internal static int __PropertyOffset_MobileMSAASampleCount;

		// Token: 0x040081FE RID: 33278
		internal static int __PropertyOffset_bMobileAllowDitheredLODTransition;

		// Token: 0x040081FF RID: 33279
		internal static byte __PropertyMask_bMobileAllowDitheredLODTransition;

		// Token: 0x04008200 RID: 33280
		internal static int __PropertyOffset_bAllowSoftwareOcclusionCulling;

		// Token: 0x04008201 RID: 33281
		internal static byte __PropertyMask_bAllowSoftwareOcclusionCulling;

		// Token: 0x04008202 RID: 33282
		internal static int __PropertyOffset_bMobileVirtualTextures;

		// Token: 0x04008203 RID: 33283
		internal static byte __PropertyMask_bMobileVirtualTextures;

		// Token: 0x04008204 RID: 33284
		internal static int __PropertyOffset_bDiscardUnusedQualityLevels;

		// Token: 0x04008205 RID: 33285
		internal static byte __PropertyMask_bDiscardUnusedQualityLevels;

		// Token: 0x04008206 RID: 33286
		internal static int __PropertyOffset_bOcclusionCulling;

		// Token: 0x04008207 RID: 33287
		internal static byte __PropertyMask_bOcclusionCulling;

		// Token: 0x04008208 RID: 33288
		internal static int __PropertyOffset_MinScreenRadiusForLights;

		// Token: 0x04008209 RID: 33289
		internal static int __PropertyOffset_MinScreenRadiusForCSMdepth;

		// Token: 0x0400820A RID: 33290
		internal static int __PropertyOffset_bPrecomputedVisibilityWarning;

		// Token: 0x0400820B RID: 33291
		internal static byte __PropertyMask_bPrecomputedVisibilityWarning;

		// Token: 0x0400820C RID: 33292
		internal static int __PropertyOffset_bTextureStreaming;

		// Token: 0x0400820D RID: 33293
		internal static byte __PropertyMask_bTextureStreaming;

		// Token: 0x0400820E RID: 33294
		internal static int __PropertyOffset_bUseDXT5NormalMaps;

		// Token: 0x0400820F RID: 33295
		internal static byte __PropertyMask_bUseDXT5NormalMaps;

		// Token: 0x04008210 RID: 33296
		internal static int __PropertyOffset_bVirtualTextures;

		// Token: 0x04008211 RID: 33297
		internal static byte __PropertyMask_bVirtualTextures;

		// Token: 0x04008212 RID: 33298
		internal static int __PropertyOffset_bVirtualTexturedLightmaps;

		// Token: 0x04008213 RID: 33299
		internal static byte __PropertyMask_bVirtualTexturedLightmaps;

		// Token: 0x04008214 RID: 33300
		internal static int __PropertyOffset_bEnableVirtualTextureOpacityMask;

		// Token: 0x04008215 RID: 33301
		internal static byte __PropertyMask_bEnableVirtualTextureOpacityMask;

		// Token: 0x04008216 RID: 33302
		internal static int __PropertyOffset_VirtualTextureTileSize;

		// Token: 0x04008217 RID: 33303
		internal static int __PropertyOffset_VirtualTextureTileBorderSize;

		// Token: 0x04008218 RID: 33304
		internal static int __PropertyOffset_VirtualTextureFeedbackFactor;

		// Token: 0x04008219 RID: 33305
		internal static int __PropertyOffset_bVirtualTextureEnableCompressZlib;

		// Token: 0x0400821A RID: 33306
		internal static byte __PropertyMask_bVirtualTextureEnableCompressZlib;

		// Token: 0x0400821B RID: 33307
		internal static int __PropertyOffset_bVirtualTextureEnableCompressCrunch;

		// Token: 0x0400821C RID: 33308
		internal static byte __PropertyMask_bVirtualTextureEnableCompressCrunch;

		// Token: 0x0400821D RID: 33309
		internal static int __PropertyOffset_bClearCoatEnableSecondNormal;

		// Token: 0x0400821E RID: 33310
		internal static byte __PropertyMask_bClearCoatEnableSecondNormal;

		// Token: 0x0400821F RID: 33311
		internal static int __PropertyOffset_ReflectionCaptureResolution;

		// Token: 0x04008220 RID: 33312
		internal static int __PropertyOffset_bReflectionCaptureCompression;

		// Token: 0x04008221 RID: 33313
		internal static byte __PropertyMask_bReflectionCaptureCompression;

		// Token: 0x04008222 RID: 33314
		internal static int __PropertyOffset_ReflectionEnvironmentLightmapMixBasedOnRoughness;

		// Token: 0x04008223 RID: 33315
		internal static byte __PropertyMask_ReflectionEnvironmentLightmapMixBasedOnRoughness;

		// Token: 0x04008224 RID: 33316
		internal static int __PropertyOffset_bForwardShading;

		// Token: 0x04008225 RID: 33317
		internal static byte __PropertyMask_bForwardShading;

		// Token: 0x04008226 RID: 33318
		internal static int __PropertyOffset_bVertexFoggingForOpaque;

		// Token: 0x04008227 RID: 33319
		internal static byte __PropertyMask_bVertexFoggingForOpaque;

		// Token: 0x04008228 RID: 33320
		internal static int __PropertyOffset_bAllowStaticLighting;

		// Token: 0x04008229 RID: 33321
		internal static byte __PropertyMask_bAllowStaticLighting;

		// Token: 0x0400822A RID: 33322
		internal static int __PropertyOffset_bUseNormalMapsForStaticLighting;

		// Token: 0x0400822B RID: 33323
		internal static byte __PropertyMask_bUseNormalMapsForStaticLighting;

		// Token: 0x0400822C RID: 33324
		internal static int __PropertyOffset_bGenerateMeshDistanceFields;

		// Token: 0x0400822D RID: 33325
		internal static byte __PropertyMask_bGenerateMeshDistanceFields;

		// Token: 0x0400822E RID: 33326
		internal static int __PropertyOffset_bEightBitMeshDistanceFields;

		// Token: 0x0400822F RID: 33327
		internal static byte __PropertyMask_bEightBitMeshDistanceFields;

		// Token: 0x04008230 RID: 33328
		internal static int __PropertyOffset_bGenerateLandscapeGIData;

		// Token: 0x04008231 RID: 33329
		internal static byte __PropertyMask_bGenerateLandscapeGIData;

		// Token: 0x04008232 RID: 33330
		internal static int __PropertyOffset_bCompressMeshDistanceFields;

		// Token: 0x04008233 RID: 33331
		internal static byte __PropertyMask_bCompressMeshDistanceFields;

		// Token: 0x04008234 RID: 33332
		internal static int __PropertyOffset_TessellationAdaptivePixelsPerTriangle;

		// Token: 0x04008235 RID: 33333
		internal static int __PropertyOffset_bSeparateTranslucency;

		// Token: 0x04008236 RID: 33334
		internal static byte __PropertyMask_bSeparateTranslucency;

		// Token: 0x04008237 RID: 33335
		internal static int __PropertyOffset_TranslucentSortPolicy;

		// Token: 0x04008238 RID: 33336
		internal static int __PropertyOffset_TranslucentSortAxis;

		// Token: 0x04008239 RID: 33337
		internal static int __PropertyOffset_bLocalFogVolumeApplyOnTranslucent;

		// Token: 0x0400823A RID: 33338
		internal static byte __PropertyMask_bLocalFogVolumeApplyOnTranslucent;

		// Token: 0x0400823B RID: 33339
		internal static int __PropertyOffset_HMDFixedFoveationLevel;

		// Token: 0x0400823C RID: 33340
		internal static int __PropertyOffset_bHMDFixedFoveationDynamic;

		// Token: 0x0400823D RID: 33341
		internal static byte __PropertyMask_bHMDFixedFoveationDynamic;

		// Token: 0x0400823E RID: 33342
		internal static int __PropertyOffset_CustomDepthStencil;

		// Token: 0x0400823F RID: 33343
		internal static int __PropertyOffset_bCustomDepthTaaJitter;

		// Token: 0x04008240 RID: 33344
		internal static byte __PropertyMask_bCustomDepthTaaJitter;

		// Token: 0x04008241 RID: 33345
		internal static int __PropertyOffset_bEnableAlphaChannelInPostProcessing;

		// Token: 0x04008242 RID: 33346
		internal static int __PropertyOffset_bDefaultFeatureBloom;

		// Token: 0x04008243 RID: 33347
		internal static byte __PropertyMask_bDefaultFeatureBloom;

		// Token: 0x04008244 RID: 33348
		internal static int __PropertyOffset_bDefaultFeatureAmbientOcclusion;

		// Token: 0x04008245 RID: 33349
		internal static byte __PropertyMask_bDefaultFeatureAmbientOcclusion;

		// Token: 0x04008246 RID: 33350
		internal static int __PropertyOffset_bDefaultFeatureAmbientOcclusionStaticFraction;

		// Token: 0x04008247 RID: 33351
		internal static byte __PropertyMask_bDefaultFeatureAmbientOcclusionStaticFraction;

		// Token: 0x04008248 RID: 33352
		internal static int __PropertyOffset_bDefaultFeatureAutoExposure;

		// Token: 0x04008249 RID: 33353
		internal static byte __PropertyMask_bDefaultFeatureAutoExposure;

		// Token: 0x0400824A RID: 33354
		internal static int __PropertyOffset_DefaultFeatureAutoExposure;

		// Token: 0x0400824B RID: 33355
		internal static int __PropertyOffset_DefaultFeatureAutoExposureBias;

		// Token: 0x0400824C RID: 33356
		internal static int __PropertyOffset_bExtendDefaultLuminanceRangeInAutoExposureSettings;

		// Token: 0x0400824D RID: 33357
		internal static byte __PropertyMask_bExtendDefaultLuminanceRangeInAutoExposureSettings;

		// Token: 0x0400824E RID: 33358
		internal static int __PropertyOffset_bUsePreExposure;

		// Token: 0x0400824F RID: 33359
		internal static byte __PropertyMask_bUsePreExposure;

		// Token: 0x04008250 RID: 33360
		internal static int __PropertyOffset_bEnablePreExposureOnlyInTheEditor;

		// Token: 0x04008251 RID: 33361
		internal static byte __PropertyMask_bEnablePreExposureOnlyInTheEditor;

		// Token: 0x04008252 RID: 33362
		internal static int __PropertyOffset_bDefaultFeatureMotionBlur;

		// Token: 0x04008253 RID: 33363
		internal static byte __PropertyMask_bDefaultFeatureMotionBlur;

		// Token: 0x04008254 RID: 33364
		internal static int __PropertyOffset_bDefaultFeatureLensFlare;

		// Token: 0x04008255 RID: 33365
		internal static byte __PropertyMask_bDefaultFeatureLensFlare;

		// Token: 0x04008256 RID: 33366
		internal static int __PropertyOffset_bTemporalUpsampling;

		// Token: 0x04008257 RID: 33367
		internal static byte __PropertyMask_bTemporalUpsampling;

		// Token: 0x04008258 RID: 33368
		internal static int __PropertyOffset_bSSGI;

		// Token: 0x04008259 RID: 33369
		internal static byte __PropertyMask_bSSGI;

		// Token: 0x0400825A RID: 33370
		internal static int __PropertyOffset_DefaultFeatureAntiAliasing;

		// Token: 0x0400825B RID: 33371
		internal static int __PropertyOffset_bEnableKuroFogRendering;

		// Token: 0x0400825C RID: 33372
		internal static byte __PropertyMask_bEnableKuroFogRendering;

		// Token: 0x0400825D RID: 33373
		internal static int __PropertyOffset_bEnableKuroMobileGGX;

		// Token: 0x0400825E RID: 33374
		internal static byte __PropertyMask_bEnableKuroMobileGGX;

		// Token: 0x0400825F RID: 33375
		internal static int __PropertyOffset_KuroRenderSwitch;

		// Token: 0x04008260 RID: 33376
		internal static byte __PropertyMask_KuroRenderSwitch;

		// Token: 0x04008261 RID: 33377
		internal static int __PropertyOffset_KuroLightCullDistanceType1;

		// Token: 0x04008262 RID: 33378
		internal static int __PropertyOffset_KuroLightCullDistanceType2;

		// Token: 0x04008263 RID: 33379
		internal static int __PropertyOffset_KuroLightCullDistanceType3;

		// Token: 0x04008264 RID: 33380
		internal static int __PropertyOffset_KuroLightCullDistanceType4;

		// Token: 0x04008265 RID: 33381
		internal static int __PropertyOffset_KuroLightCullDistanceType5;

		// Token: 0x04008266 RID: 33382
		internal static int __PropertyOffset_KuroMobileLightCullDistanceType1;

		// Token: 0x04008267 RID: 33383
		internal static int __PropertyOffset_KuroMobileLightCullDistanceType2;

		// Token: 0x04008268 RID: 33384
		internal static int __PropertyOffset_KuroMobileLightCullDistanceType3;

		// Token: 0x04008269 RID: 33385
		internal static int __PropertyOffset_KuroMobileLightCullDistanceType4;

		// Token: 0x0400826A RID: 33386
		internal static int __PropertyOffset_KuroMobileLightCullDistanceType5;

		// Token: 0x0400826B RID: 33387
		internal static int __PropertyOffset_KuroCGModeLightCullDistanceType1;

		// Token: 0x0400826C RID: 33388
		internal static int __PropertyOffset_KuroCGModeLightCullDistanceType2;

		// Token: 0x0400826D RID: 33389
		internal static int __PropertyOffset_KuroCGModeLightCullDistanceType3;

		// Token: 0x0400826E RID: 33390
		internal static int __PropertyOffset_KuroCGModeLightCullDistanceType4;

		// Token: 0x0400826F RID: 33391
		internal static int __PropertyOffset_KuroCGModeLightCullDistanceType5;

		// Token: 0x04008270 RID: 33392
		internal static int __PropertyOffset_EnableKuroFoliageCulling;

		// Token: 0x04008271 RID: 33393
		internal static int __PropertyOffset_KuroFoliageNearCullDistanceMin;

		// Token: 0x04008272 RID: 33394
		internal static int __PropertyOffset_KuroFoliageNearCullDistanceMax;

		// Token: 0x04008273 RID: 33395
		internal static int __PropertyOffset_KuroFoliageMobileNearCullDistanceMin;

		// Token: 0x04008274 RID: 33396
		internal static int __PropertyOffset_KuroFoliageMobileNearCullDistanceMax;

		// Token: 0x04008275 RID: 33397
		internal static int __PropertyOffset_KuroFoliageMiddleCullDistanceMin;

		// Token: 0x04008276 RID: 33398
		internal static int __PropertyOffset_KuroFoliageMiddleCullDistanceMax;

		// Token: 0x04008277 RID: 33399
		internal static int __PropertyOffset_KuroFoliageMobileMiddleCullDistanceMin;

		// Token: 0x04008278 RID: 33400
		internal static int __PropertyOffset_KuroFoliageMobileMiddleCullDistanceMax;

		// Token: 0x04008279 RID: 33401
		internal static int __PropertyOffset_KuroFoliageFarCullDistanceMin;

		// Token: 0x0400827A RID: 33402
		internal static int __PropertyOffset_KuroFoliageFarCullDistanceMax;

		// Token: 0x0400827B RID: 33403
		internal static int __PropertyOffset_KuroFoliageMobileFarCullDistanceMin;

		// Token: 0x0400827C RID: 33404
		internal static int __PropertyOffset_KuroFoliageMobileFarCullDistanceMax;

		// Token: 0x0400827D RID: 33405
		internal static int __PropertyOffset_KuroFoliageSuperFarCullDistanceMin;

		// Token: 0x0400827E RID: 33406
		internal static int __PropertyOffset_KuroFoliageSuperFarCullDistanceMax;

		// Token: 0x0400827F RID: 33407
		internal static int __PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMin;

		// Token: 0x04008280 RID: 33408
		internal static int __PropertyOffset_KuroFoliageMobileSuperFarCullDistanceMax;

		// Token: 0x04008281 RID: 33409
		internal static int __PropertyOffset_KuroImpostorFoliageCullDistanceMin;

		// Token: 0x04008282 RID: 33410
		internal static int __PropertyOffset_KuroImpostorFoliageCullDistanceMax;

		// Token: 0x04008283 RID: 33411
		internal static int __PropertyOffset_KuroImpostorMobileFoliageCullDistanceMin;

		// Token: 0x04008284 RID: 33412
		internal static int __PropertyOffset_KuroImpostorMobileFoliageCullDistanceMax;

		// Token: 0x04008285 RID: 33413
		internal static int __PropertyOffset_KuroGrassFoliageCullDistanceMin;

		// Token: 0x04008286 RID: 33414
		internal static int __PropertyOffset_KuroGrassFoliageCullDistanceMax;

		// Token: 0x04008287 RID: 33415
		internal static int __PropertyOffset_KuroGrassMobileFoliageCullDistanceMin;

		// Token: 0x04008288 RID: 33416
		internal static int __PropertyOffset_KuroGrassMobileFoliageCullDistanceMax;

		// Token: 0x04008289 RID: 33417
		internal static int __PropertyOffset_KuroPcgCullDistanceMin;

		// Token: 0x0400828A RID: 33418
		internal static int __PropertyOffset_KuroPcgCullDistanceMax;

		// Token: 0x0400828B RID: 33419
		internal static int __PropertyOffset_KuroPcgMobileCullDistanceMin;

		// Token: 0x0400828C RID: 33420
		internal static int __PropertyOffset_KuroPcgMobileCullDistanceMax;

		// Token: 0x0400828D RID: 33421
		internal static int __PropertyOffset_VolumeNoisePath;

		// Token: 0x0400828E RID: 33422
		[Nullable(2)]
		private FSoftObjectPath _VolumeNoisePath;

		// Token: 0x0400828F RID: 33423
		internal static int __PropertyOffset_WaveLengthHigh;

		// Token: 0x04008290 RID: 33424
		internal static int __PropertyOffset_WaveLengthMedium;

		// Token: 0x04008291 RID: 33425
		internal static int __PropertyOffset_WaveLengthLow;

		// Token: 0x04008292 RID: 33426
		internal static int __PropertyOffset_KuroVolumetricCloudPhaseG;

		// Token: 0x04008293 RID: 33427
		internal static int __PropertyOffset_DefaultLightUnits;

		// Token: 0x04008294 RID: 33428
		internal static int __PropertyOffset_DefaultBackBufferPixelFormat;

		// Token: 0x04008295 RID: 33429
		internal static int __PropertyOffset_bRenderUnbuiltPreviewShadowsInGame;

		// Token: 0x04008296 RID: 33430
		internal static byte __PropertyMask_bRenderUnbuiltPreviewShadowsInGame;

		// Token: 0x04008297 RID: 33431
		internal static int __PropertyOffset_bStencilForLODDither;

		// Token: 0x04008298 RID: 33432
		internal static byte __PropertyMask_bStencilForLODDither;

		// Token: 0x04008299 RID: 33433
		internal static int __PropertyOffset_EarlyZPass;

		// Token: 0x0400829A RID: 33434
		internal static int __PropertyOffset_bEarlyZPassOnlyMaterialMasking;

		// Token: 0x0400829B RID: 33435
		internal static byte __PropertyMask_bEarlyZPassOnlyMaterialMasking;

		// Token: 0x0400829C RID: 33436
		internal static int __PropertyOffset_bDBuffer;

		// Token: 0x0400829D RID: 33437
		internal static byte __PropertyMask_bDBuffer;

		// Token: 0x0400829E RID: 33438
		internal static int __PropertyOffset_ClearSceneMethod;

		// Token: 0x0400829F RID: 33439
		internal static int __PropertyOffset_bBasePassOutputsVelocity;

		// Token: 0x040082A0 RID: 33440
		internal static byte __PropertyMask_bBasePassOutputsVelocity;

		// Token: 0x040082A1 RID: 33441
		internal static int __PropertyOffset_bVertexDeformationOutputsVelocity;

		// Token: 0x040082A2 RID: 33442
		internal static byte __PropertyMask_bVertexDeformationOutputsVelocity;

		// Token: 0x040082A3 RID: 33443
		internal static int __PropertyOffset_bSelectiveBasePassOutputs;

		// Token: 0x040082A4 RID: 33444
		internal static byte __PropertyMask_bSelectiveBasePassOutputs;

		// Token: 0x040082A5 RID: 33445
		internal static int __PropertyOffset_bDefaultParticleCutouts;

		// Token: 0x040082A6 RID: 33446
		internal static byte __PropertyMask_bDefaultParticleCutouts;

		// Token: 0x040082A7 RID: 33447
		internal static int __PropertyOffset_GPUSimulationTextureSizeX;

		// Token: 0x040082A8 RID: 33448
		internal static int __PropertyOffset_GPUSimulationTextureSizeY;

		// Token: 0x040082A9 RID: 33449
		internal static int __PropertyOffset_bGlobalClipPlane;

		// Token: 0x040082AA RID: 33450
		internal static byte __PropertyMask_bGlobalClipPlane;

		// Token: 0x040082AB RID: 33451
		internal static int __PropertyOffset_GBufferFormat;

		// Token: 0x040082AC RID: 33452
		internal static int __PropertyOffset_bUseGPUMorphTargets;

		// Token: 0x040082AD RID: 33453
		internal static byte __PropertyMask_bUseGPUMorphTargets;

		// Token: 0x040082AE RID: 33454
		internal static int __PropertyOffset_bNvidiaAftermathEnabled;

		// Token: 0x040082AF RID: 33455
		internal static byte __PropertyMask_bNvidiaAftermathEnabled;

		// Token: 0x040082B0 RID: 33456
		internal static int __PropertyOffset_bMultiView;

		// Token: 0x040082B1 RID: 33457
		internal static byte __PropertyMask_bMultiView;

		// Token: 0x040082B2 RID: 33458
		internal static int __PropertyOffset_bMobilePostProcessing;

		// Token: 0x040082B3 RID: 33459
		internal static byte __PropertyMask_bMobilePostProcessing;

		// Token: 0x040082B4 RID: 33460
		internal static int __PropertyOffset_bMobileMultiView;

		// Token: 0x040082B5 RID: 33461
		internal static byte __PropertyMask_bMobileMultiView;

		// Token: 0x040082B6 RID: 33462
		internal static int __PropertyOffset_bMobileUseHWsRGBEncoding;

		// Token: 0x040082B7 RID: 33463
		internal static byte __PropertyMask_bMobileUseHWsRGBEncoding;

		// Token: 0x040082B8 RID: 33464
		internal static int __PropertyOffset_bRoundRobinOcclusion;

		// Token: 0x040082B9 RID: 33465
		internal static byte __PropertyMask_bRoundRobinOcclusion;

		// Token: 0x040082BA RID: 33466
		internal static int __PropertyOffset_bODSCapture;

		// Token: 0x040082BB RID: 33467
		internal static byte __PropertyMask_bODSCapture;

		// Token: 0x040082BC RID: 33468
		internal static int __PropertyOffset_bMeshStreaming;

		// Token: 0x040082BD RID: 33469
		internal static byte __PropertyMask_bMeshStreaming;

		// Token: 0x040082BE RID: 33470
		internal static int __PropertyOffset_WireframeCullThreshold;

		// Token: 0x040082BF RID: 33471
		internal static int __PropertyOffset_bEnableMegaLights;

		// Token: 0x040082C0 RID: 33472
		internal static byte __PropertyMask_bEnableMegaLights;

		// Token: 0x040082C1 RID: 33473
		internal static int __PropertyOffset_bEnableRayTracingShadows;

		// Token: 0x040082C2 RID: 33474
		internal static byte __PropertyMask_bEnableRayTracingShadows;

		// Token: 0x040082C3 RID: 33475
		internal static int __PropertyOffset_bEnableRayTracing;

		// Token: 0x040082C4 RID: 33476
		internal static byte __PropertyMask_bEnableRayTracing;

		// Token: 0x040082C5 RID: 33477
		internal static int __PropertyOffset_bEnableRayTracingTextureLOD;

		// Token: 0x040082C6 RID: 33478
		internal static byte __PropertyMask_bEnableRayTracingTextureLOD;

		// Token: 0x040082C7 RID: 33479
		internal static int __PropertyOffset_bSupportStationarySkylight;

		// Token: 0x040082C8 RID: 33480
		internal static byte __PropertyMask_bSupportStationarySkylight;

		// Token: 0x040082C9 RID: 33481
		internal static int __PropertyOffset_bSupportLowQualityLightmaps;

		// Token: 0x040082CA RID: 33482
		internal static byte __PropertyMask_bSupportLowQualityLightmaps;

		// Token: 0x040082CB RID: 33483
		internal static int __PropertyOffset_bSupportPointLightWholeSceneShadows;

		// Token: 0x040082CC RID: 33484
		internal static byte __PropertyMask_bSupportPointLightWholeSceneShadows;

		// Token: 0x040082CD RID: 33485
		internal static int __PropertyOffset_bSupportAtmosphericFog;

		// Token: 0x040082CE RID: 33486
		internal static byte __PropertyMask_bSupportAtmosphericFog;

		// Token: 0x040082CF RID: 33487
		internal static int __PropertyOffset_bSupportSkyAtmosphere;

		// Token: 0x040082D0 RID: 33488
		internal static byte __PropertyMask_bSupportSkyAtmosphere;

		// Token: 0x040082D1 RID: 33489
		internal static int __PropertyOffset_bSupportSkyAtmosphereAffectsHeightFog;

		// Token: 0x040082D2 RID: 33490
		internal static byte __PropertyMask_bSupportSkyAtmosphereAffectsHeightFog;

		// Token: 0x040082D3 RID: 33491
		internal static int __PropertyOffset_bSupportSkinCacheShaders;

		// Token: 0x040082D4 RID: 33492
		internal static byte __PropertyMask_bSupportSkinCacheShaders;

		// Token: 0x040082D5 RID: 33493
		internal static int __PropertyOffset_DefaultSkinCacheBehavior;

		// Token: 0x040082D6 RID: 33494
		internal static int __PropertyOffset_SkinCacheSceneMemoryLimitInMB;

		// Token: 0x040082D7 RID: 33495
		internal static int __PropertyOffset_bMobileEnableStaticAndCSMShadowReceivers;

		// Token: 0x040082D8 RID: 33496
		internal static byte __PropertyMask_bMobileEnableStaticAndCSMShadowReceivers;

		// Token: 0x040082D9 RID: 33497
		internal static int __PropertyOffset_bMobileEnableMovableLightCSMShaderCulling;

		// Token: 0x040082DA RID: 33498
		internal static byte __PropertyMask_bMobileEnableMovableLightCSMShaderCulling;

		// Token: 0x040082DB RID: 33499
		internal static int __PropertyOffset_bMobileAllowDistanceFieldShadows;

		// Token: 0x040082DC RID: 33500
		internal static byte __PropertyMask_bMobileAllowDistanceFieldShadows;

		// Token: 0x040082DD RID: 33501
		internal static int __PropertyOffset_bMobileAllowMovableDirectionalLights;

		// Token: 0x040082DE RID: 33502
		internal static byte __PropertyMask_bMobileAllowMovableDirectionalLights;

		// Token: 0x040082DF RID: 33503
		internal static int __PropertyOffset_MobileNumDynamicPointLights;

		// Token: 0x040082E0 RID: 33504
		internal static int __PropertyOffset_bMobileDynamicPointLightsUseStaticBranch;

		// Token: 0x040082E1 RID: 33505
		internal static byte __PropertyMask_bMobileDynamicPointLightsUseStaticBranch;

		// Token: 0x040082E2 RID: 33506
		internal static int __PropertyOffset_bMobileAllowMovableSpotlights;

		// Token: 0x040082E3 RID: 33507
		internal static byte __PropertyMask_bMobileAllowMovableSpotlights;

		// Token: 0x040082E4 RID: 33508
		internal static int __PropertyOffset_bMobileAllowMovableSpotlightShadows;

		// Token: 0x040082E5 RID: 33509
		internal static byte __PropertyMask_bMobileAllowMovableSpotlightShadows;

		// Token: 0x040082E6 RID: 33510
		internal static int __PropertyOffset_bSupport16BitBoneIndex;

		// Token: 0x040082E7 RID: 33511
		internal static byte __PropertyMask_bSupport16BitBoneIndex;

		// Token: 0x040082E8 RID: 33512
		internal static int __PropertyOffset_bGPUSkinLimit2BoneInfluences;

		// Token: 0x040082E9 RID: 33513
		internal static byte __PropertyMask_bGPUSkinLimit2BoneInfluences;

		// Token: 0x040082EA RID: 33514
		internal static int __PropertyOffset_bSupportDepthOnlyIndexBuffers;

		// Token: 0x040082EB RID: 33515
		internal static byte __PropertyMask_bSupportDepthOnlyIndexBuffers;

		// Token: 0x040082EC RID: 33516
		internal static int __PropertyOffset_bSupportReversedIndexBuffers;

		// Token: 0x040082ED RID: 33517
		internal static byte __PropertyMask_bSupportReversedIndexBuffers;

		// Token: 0x040082EE RID: 33518
		internal static int __PropertyOffset_bLPV;

		// Token: 0x040082EF RID: 33519
		internal static byte __PropertyMask_bLPV;

		// Token: 0x040082F0 RID: 33520
		internal static int __PropertyOffset_bMobileAmbientOcclusion;

		// Token: 0x040082F1 RID: 33521
		internal static byte __PropertyMask_bMobileAmbientOcclusion;

		// Token: 0x040082F2 RID: 33522
		internal static int __PropertyOffset_bUseUnlimitedBoneInfluences;

		// Token: 0x040082F3 RID: 33523
		internal static byte __PropertyMask_bUseUnlimitedBoneInfluences;

		// Token: 0x040082F4 RID: 33524
		internal static int __PropertyOffset_UnlimitedBonInfluencesThreshold;

		// Token: 0x040082F5 RID: 33525
		internal static int __PropertyOffset_MobilePlanarReflectionMode;

		// Token: 0x040082F6 RID: 33526
		internal static int __PropertyOffset_bStreamSkeletalMeshLODs;

		// Token: 0x040082F7 RID: 33527
		[Nullable(2)]
		private FPerPlatformBool _bStreamSkeletalMeshLODs;

		// Token: 0x040082F8 RID: 33528
		internal static int __PropertyOffset_bDiscardSkeletalMeshOptionalLODs;

		// Token: 0x040082F9 RID: 33529
		[Nullable(2)]
		private FPerPlatformBool _bDiscardSkeletalMeshOptionalLODs;

		// Token: 0x040082FA RID: 33530
		internal static int __PropertyOffset_VisualizeCalibrationColorMaterialPath;

		// Token: 0x040082FB RID: 33531
		[Nullable(2)]
		private FSoftObjectPath _VisualizeCalibrationColorMaterialPath;

		// Token: 0x040082FC RID: 33532
		internal static int __PropertyOffset_VisualizeCalibrationCustomMaterialPath;

		// Token: 0x040082FD RID: 33533
		[Nullable(2)]
		private FSoftObjectPath _VisualizeCalibrationCustomMaterialPath;

		// Token: 0x040082FE RID: 33534
		internal static int __PropertyOffset_VisualizeCalibrationGrayscaleMaterialPath;

		// Token: 0x040082FF RID: 33535
		[Nullable(2)]
		private FSoftObjectPath _VisualizeCalibrationGrayscaleMaterialPath;
	}
}
