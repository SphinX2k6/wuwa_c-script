using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E8B RID: 3723
	[UnrealObjectPath("/Script/Engine.MaterialInstanceBasePropertyOverrides")]
	[UnrealStructLayout(96, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMaterialInstanceBasePropertyOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C6C5 RID: 50885 RVA: 0x001201BE File Offset: 0x0011E3BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialInstanceBasePropertyOverrides._ScriptStructPtr != 0) ? FMaterialInstanceBasePropertyOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialInstanceBasePropertyOverrides", ref FMaterialInstanceBasePropertyOverrides._ScriptStructPtr);
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x001201E2 File Offset: 0x0011E3E2
		// (set) Token: 0x0600C6C7 RID: 50887 RVA: 0x001201FB File Offset: 0x0011E3FB
		public unsafe bool bOverride_OpacityMaskClipValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_OpacityMaskClipValue) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_OpacityMaskClipValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_OpacityMaskClipValue) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_OpacityMaskClipValue) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_OpacityMaskClipValue) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_OpacityMaskClipValue : 0));
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x0012022B File Offset: 0x0011E42B
		// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00120244 File Offset: 0x0011E444
		public unsafe bool bOverride_BlendMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_BlendMode) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_BlendMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_BlendMode) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_BlendMode) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_BlendMode) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_BlendMode : 0));
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00120274 File Offset: 0x0011E474
		// (set) Token: 0x0600C6CB RID: 50891 RVA: 0x0012028D File Offset: 0x0011E48D
		public unsafe bool bOverride_ShadingModel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ShadingModel) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ShadingModel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ShadingModel) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ShadingModel) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ShadingModel) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ShadingModel : 0));
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x001202BD File Offset: 0x0011E4BD
		// (set) Token: 0x0600C6CD RID: 50893 RVA: 0x001202D6 File Offset: 0x0011E4D6
		public unsafe bool bOverride_DitheredLODTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DitheredLODTransition) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DitheredLODTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DitheredLODTransition) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DitheredLODTransition) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DitheredLODTransition) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DitheredLODTransition : 0));
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0600C6CE RID: 50894 RVA: 0x00120306 File Offset: 0x0011E506
		// (set) Token: 0x0600C6CF RID: 50895 RVA: 0x0012031F File Offset: 0x0011E51F
		public unsafe bool bOverride_CastDynamicShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastDynamicShadowAsMasked) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastDynamicShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastDynamicShadowAsMasked) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastDynamicShadowAsMasked) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastDynamicShadowAsMasked) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastDynamicShadowAsMasked : 0));
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x0012034F File Offset: 0x0011E54F
		// (set) Token: 0x0600C6D1 RID: 50897 RVA: 0x00120368 File Offset: 0x0011E568
		public unsafe bool bOverride_TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TwoSided) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TwoSided) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TwoSided) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TwoSided) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TwoSided : 0));
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x00120398 File Offset: 0x0011E598
		// (set) Token: 0x0600C6D3 RID: 50899 RVA: 0x001203B1 File Offset: 0x0011E5B1
		public unsafe bool bOverride_KuroWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroWater) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroWater) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroWater) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroWater) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroWater : 0));
			}
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600C6D4 RID: 50900 RVA: 0x001203E1 File Offset: 0x0011E5E1
		// (set) Token: 0x0600C6D5 RID: 50901 RVA: 0x001203FA File Offset: 0x0011E5FA
		public unsafe bool bOverride_bSceneDissolveEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneDissolveEnable) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneDissolveEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneDissolveEnable) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneDissolveEnable) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneDissolveEnable) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneDissolveEnable : 0));
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600C6D6 RID: 50902 RVA: 0x0012042A File Offset: 0x0011E62A
		// (set) Token: 0x0600C6D7 RID: 50903 RVA: 0x00120443 File Offset: 0x0011E643
		public unsafe bool bOverride_bSceneColorClearEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneColorClearEnable) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneColorClearEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneColorClearEnable) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bSceneColorClearEnable) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneColorClearEnable) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bSceneColorClearEnable : 0));
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600C6D8 RID: 50904 RVA: 0x00120473 File Offset: 0x0011E673
		// (set) Token: 0x0600C6D9 RID: 50905 RVA: 0x0012048C File Offset: 0x0011E68C
		public unsafe bool TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_TwoSided) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_TwoSided) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_TwoSided) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_TwoSided) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_TwoSided : 0));
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600C6DA RID: 50906 RVA: 0x001204BC File Offset: 0x0011E6BC
		// (set) Token: 0x0600C6DB RID: 50907 RVA: 0x001204D5 File Offset: 0x0011E6D5
		public unsafe bool KuroWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_KuroWater) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_KuroWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_KuroWater) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_KuroWater) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_KuroWater) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_KuroWater : 0));
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600C6DC RID: 50908 RVA: 0x00120505 File Offset: 0x0011E705
		// (set) Token: 0x0600C6DD RID: 50909 RVA: 0x0012051E File Offset: 0x0011E71E
		public unsafe bool bSceneDissolveEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneDissolveEnable) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneDissolveEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneDissolveEnable) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneDissolveEnable) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneDissolveEnable) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneDissolveEnable : 0));
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x0012054E File Offset: 0x0011E74E
		// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x00120567 File Offset: 0x0011E767
		public unsafe bool bSceneColorClearEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneColorClearEnable) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneColorClearEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneColorClearEnable) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSceneColorClearEnable) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneColorClearEnable) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSceneColorClearEnable : 0));
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x00120597 File Offset: 0x0011E797
		// (set) Token: 0x0600C6E1 RID: 50913 RVA: 0x001205B0 File Offset: 0x0011E7B0
		public unsafe bool bOverride_EnableSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableSeparateTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableSeparateTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableSeparateTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableSeparateTranslucency : 0));
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600C6E2 RID: 50914 RVA: 0x001205E0 File Offset: 0x0011E7E0
		// (set) Token: 0x0600C6E3 RID: 50915 RVA: 0x001205F9 File Offset: 0x0011E7F9
		public unsafe bool bEnableSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableSeparateTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableSeparateTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableSeparateTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableSeparateTranslucency : 0));
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600C6E4 RID: 50916 RVA: 0x00120629 File Offset: 0x0011E829
		// (set) Token: 0x0600C6E5 RID: 50917 RVA: 0x00120642 File Offset: 0x0011E842
		public unsafe bool bOverride_bMaskedRenderInPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth : 0));
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600C6E6 RID: 50918 RVA: 0x00120672 File Offset: 0x0011E872
		// (set) Token: 0x0600C6E7 RID: 50919 RVA: 0x0012068B File Offset: 0x0011E88B
		public unsafe bool bMaskedRenderInPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth : 0));
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600C6E8 RID: 50920 RVA: 0x001206BB File Offset: 0x0011E8BB
		// (set) Token: 0x0600C6E9 RID: 50921 RVA: 0x001206D4 File Offset: 0x0011E8D4
		public unsafe bool bOverride_bMaskedRenderInPreDepth_PC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth_PC) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth_PC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth_PC) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bMaskedRenderInPreDepth_PC) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth_PC) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bMaskedRenderInPreDepth_PC : 0));
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600C6EA RID: 50922 RVA: 0x00120704 File Offset: 0x0011E904
		// (set) Token: 0x0600C6EB RID: 50923 RVA: 0x0012071D File Offset: 0x0011E91D
		public unsafe bool bMaskedRenderInPreDepth_PC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth_PC) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth_PC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth_PC) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bMaskedRenderInPreDepth_PC) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth_PC) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bMaskedRenderInPreDepth_PC : 0));
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600C6EC RID: 50924 RVA: 0x0012074D File Offset: 0x0011E94D
		// (set) Token: 0x0600C6ED RID: 50925 RVA: 0x00120766 File Offset: 0x0011E966
		public unsafe bool bOverride_TessellationMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TessellationMode) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TessellationMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TessellationMode) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_TessellationMode) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TessellationMode) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_TessellationMode : 0));
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600C6EE RID: 50926 RVA: 0x00120796 File Offset: 0x0011E996
		// (set) Token: 0x0600C6EF RID: 50927 RVA: 0x001207AA File Offset: 0x0011E9AA
		public unsafe TEnumAsByte<EMaterialTessellationMode> TessellationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_TessellationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_TessellationMode) = value;
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x001207BF File Offset: 0x0011E9BF
		// (set) Token: 0x0600C6F1 RID: 50929 RVA: 0x001207D8 File Offset: 0x0011E9D8
		public unsafe bool bOverride_bEnableCrackFreeDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableCrackFreeDisplacement) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableCrackFreeDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableCrackFreeDisplacement) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableCrackFreeDisplacement) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableCrackFreeDisplacement) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableCrackFreeDisplacement : 0));
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600C6F2 RID: 50930 RVA: 0x00120808 File Offset: 0x0011EA08
		// (set) Token: 0x0600C6F3 RID: 50931 RVA: 0x00120821 File Offset: 0x0011EA21
		public unsafe bool bEnableCrackFreeDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableCrackFreeDisplacement) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableCrackFreeDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableCrackFreeDisplacement) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableCrackFreeDisplacement) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableCrackFreeDisplacement) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableCrackFreeDisplacement : 0));
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x00120851 File Offset: 0x0011EA51
		// (set) Token: 0x0600C6F5 RID: 50933 RVA: 0x0012086A File Offset: 0x0011EA6A
		public unsafe bool bOverride_bEnableAdaptiveTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableAdaptiveTessellation) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableAdaptiveTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableAdaptiveTessellation) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bEnableAdaptiveTessellation) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableAdaptiveTessellation) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bEnableAdaptiveTessellation : 0));
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600C6F6 RID: 50934 RVA: 0x0012089A File Offset: 0x0011EA9A
		// (set) Token: 0x0600C6F7 RID: 50935 RVA: 0x001208B3 File Offset: 0x0011EAB3
		public unsafe bool bEnableAdaptiveTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableAdaptiveTessellation) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableAdaptiveTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableAdaptiveTessellation) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableAdaptiveTessellation) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableAdaptiveTessellation) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableAdaptiveTessellation : 0));
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600C6F8 RID: 50936 RVA: 0x001208E3 File Offset: 0x0011EAE3
		// (set) Token: 0x0600C6F9 RID: 50937 RVA: 0x001208FC File Offset: 0x0011EAFC
		public unsafe bool bOverride_bDisableTessellationInShadowPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bDisableTessellationInShadowPass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bDisableTessellationInShadowPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bDisableTessellationInShadowPass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bDisableTessellationInShadowPass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bDisableTessellationInShadowPass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bDisableTessellationInShadowPass : 0));
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600C6FA RID: 50938 RVA: 0x0012092C File Offset: 0x0011EB2C
		// (set) Token: 0x0600C6FB RID: 50939 RVA: 0x00120945 File Offset: 0x0011EB45
		public unsafe bool bDisableTessellationInShadowPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableTessellationInShadowPass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableTessellationInShadowPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableTessellationInShadowPass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableTessellationInShadowPass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableTessellationInShadowPass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableTessellationInShadowPass : 0));
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600C6FC RID: 50940 RVA: 0x00120975 File Offset: 0x0011EB75
		// (set) Token: 0x0600C6FD RID: 50941 RVA: 0x0012098E File Offset: 0x0011EB8E
		public unsafe bool bOverride_bRenderInCustomCapturePass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bRenderInCustomCapturePass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bRenderInCustomCapturePass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bRenderInCustomCapturePass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bRenderInCustomCapturePass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bRenderInCustomCapturePass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bRenderInCustomCapturePass : 0));
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600C6FE RID: 50942 RVA: 0x001209BE File Offset: 0x0011EBBE
		// (set) Token: 0x0600C6FF RID: 50943 RVA: 0x001209D7 File Offset: 0x0011EBD7
		public unsafe bool bRenderInCustomCapturePass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderInCustomCapturePass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRenderInCustomCapturePass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderInCustomCapturePass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderInCustomCapturePass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRenderInCustomCapturePass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRenderInCustomCapturePass : 0));
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600C700 RID: 50944 RVA: 0x00120A07 File Offset: 0x0011EC07
		// (set) Token: 0x0600C701 RID: 50945 RVA: 0x00120A20 File Offset: 0x0011EC20
		public unsafe bool bOverride_bUsedWithKuroCSInteractiveObject
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bUsedWithKuroCSInteractiveObject) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bUsedWithKuroCSInteractiveObject) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bUsedWithKuroCSInteractiveObject) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_bUsedWithKuroCSInteractiveObject) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bUsedWithKuroCSInteractiveObject) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_bUsedWithKuroCSInteractiveObject : 0));
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600C702 RID: 50946 RVA: 0x00120A50 File Offset: 0x0011EC50
		// (set) Token: 0x0600C703 RID: 50947 RVA: 0x00120A69 File Offset: 0x0011EC69
		public unsafe bool bUsedWithKuroCSInteractiveObject
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithKuroCSInteractiveObject) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithKuroCSInteractiveObject) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithKuroCSInteractiveObject) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithKuroCSInteractiveObject : 0));
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600C704 RID: 50948 RVA: 0x00120A99 File Offset: 0x0011EC99
		// (set) Token: 0x0600C705 RID: 50949 RVA: 0x00120AA9 File Offset: 0x0011ECA9
		public unsafe bool bOverride_ShadingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ShadingRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ShadingRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600C706 RID: 50950 RVA: 0x00120ABA File Offset: 0x0011ECBA
		// (set) Token: 0x0600C707 RID: 50951 RVA: 0x00120ACE File Offset: 0x0011ECCE
		public unsafe TEnumAsByte<EMaterialShadingRate> ShadingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ShadingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ShadingRate) = value;
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600C708 RID: 50952 RVA: 0x00120AE3 File Offset: 0x0011ECE3
		// (set) Token: 0x0600C709 RID: 50953 RVA: 0x00120AFC File Offset: 0x0011ECFC
		public unsafe bool bOverride_PipelineStateCreationHint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_PipelineStateCreationHint) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_PipelineStateCreationHint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_PipelineStateCreationHint) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_PipelineStateCreationHint) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_PipelineStateCreationHint) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_PipelineStateCreationHint : 0));
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600C70A RID: 50954 RVA: 0x00120B2C File Offset: 0x0011ED2C
		// (set) Token: 0x0600C70B RID: 50955 RVA: 0x00120B40 File Offset: 0x0011ED40
		public unsafe TEnumAsByte<EMaterialPipelineStateCreationHint> PipelineStateCreationHint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_PipelineStateCreationHint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_PipelineStateCreationHint) = value;
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600C70C RID: 50956 RVA: 0x00120B55 File Offset: 0x0011ED55
		// (set) Token: 0x0600C70D RID: 50957 RVA: 0x00120B6E File Offset: 0x0011ED6E
		public unsafe bool DitheredLODTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_DitheredLODTransition) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_DitheredLODTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_DitheredLODTransition) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_DitheredLODTransition) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_DitheredLODTransition) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_DitheredLODTransition : 0));
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600C70E RID: 50958 RVA: 0x00120B9E File Offset: 0x0011ED9E
		// (set) Token: 0x0600C70F RID: 50959 RVA: 0x00120BB7 File Offset: 0x0011EDB7
		public unsafe bool bCastDynamicShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastDynamicShadowAsMasked) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastDynamicShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastDynamicShadowAsMasked) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastDynamicShadowAsMasked) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastDynamicShadowAsMasked) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastDynamicShadowAsMasked : 0));
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600C710 RID: 50960 RVA: 0x00120BE7 File Offset: 0x0011EDE7
		// (set) Token: 0x0600C711 RID: 50961 RVA: 0x00120BFB File Offset: 0x0011EDFB
		public unsafe TEnumAsByte<EBlendMode> BlendMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_BlendMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_BlendMode) = value;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600C712 RID: 50962 RVA: 0x00120C10 File Offset: 0x0011EE10
		// (set) Token: 0x0600C713 RID: 50963 RVA: 0x00120C24 File Offset: 0x0011EE24
		public unsafe TEnumAsByte<EMaterialShadingModel> ShadingModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ShadingModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ShadingModel) = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600C714 RID: 50964 RVA: 0x00120C39 File Offset: 0x0011EE39
		// (set) Token: 0x0600C715 RID: 50965 RVA: 0x00120C49 File Offset: 0x0011EE49
		public unsafe float OpacityMaskClipValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_OpacityMaskClipValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_OpacityMaskClipValue) = value;
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600C716 RID: 50966 RVA: 0x00120C5A File Offset: 0x0011EE5A
		// (set) Token: 0x0600C717 RID: 50967 RVA: 0x00120C73 File Offset: 0x0011EE73
		public unsafe bool bOverride_RenderQueue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderQueue) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderQueue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderQueue) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderQueue) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderQueue) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderQueue : 0));
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600C718 RID: 50968 RVA: 0x00120CA3 File Offset: 0x0011EEA3
		// (set) Token: 0x0600C719 RID: 50969 RVA: 0x00120CB3 File Offset: 0x0011EEB3
		public unsafe ushort RenderQueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_RenderQueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_RenderQueue) = (short)value;
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600C71A RID: 50970 RVA: 0x00120CC4 File Offset: 0x0011EEC4
		// (set) Token: 0x0600C71B RID: 50971 RVA: 0x00120CD4 File Offset: 0x0011EED4
		public unsafe bool bOverride_MaterialDesktopGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_MaterialDesktopGameQualityShoulderRender) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_MaterialDesktopGameQualityShoulderRender) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600C71C RID: 50972 RVA: 0x00120CE5 File Offset: 0x0011EEE5
		// (set) Token: 0x0600C71D RID: 50973 RVA: 0x00120CF9 File Offset: 0x0011EEF9
		public unsafe TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialDesktopGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_MaterialDesktopGameQualityShoulderRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_MaterialDesktopGameQualityShoulderRender) = value;
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600C71E RID: 50974 RVA: 0x00120D0E File Offset: 0x0011EF0E
		// (set) Token: 0x0600C71F RID: 50975 RVA: 0x00120D1E File Offset: 0x0011EF1E
		public unsafe bool bOverride_MaterialMobileGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_MaterialMobileGameQualityShoulderRender) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_MaterialMobileGameQualityShoulderRender) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600C720 RID: 50976 RVA: 0x00120D2F File Offset: 0x0011EF2F
		// (set) Token: 0x0600C721 RID: 50977 RVA: 0x00120D43 File Offset: 0x0011EF43
		public unsafe TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialMobileGameQualityShoulderRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_MaterialMobileGameQualityShoulderRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_MaterialMobileGameQualityShoulderRender) = value;
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600C722 RID: 50978 RVA: 0x00120D58 File Offset: 0x0011EF58
		// (set) Token: 0x0600C723 RID: 50979 RVA: 0x00120D71 File Offset: 0x0011EF71
		public unsafe bool bOverride_CustomAlphaTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomAlphaTest) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomAlphaTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomAlphaTest) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomAlphaTest) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomAlphaTest) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomAlphaTest : 0));
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600C724 RID: 50980 RVA: 0x00120DA1 File Offset: 0x0011EFA1
		// (set) Token: 0x0600C725 RID: 50981 RVA: 0x00120DBA File Offset: 0x0011EFBA
		public unsafe bool bCustomAlphaTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCustomAlphaTest) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCustomAlphaTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCustomAlphaTest) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCustomAlphaTest) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCustomAlphaTest) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCustomAlphaTest : 0));
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600C726 RID: 50982 RVA: 0x00120DEA File Offset: 0x0011EFEA
		// (set) Token: 0x0600C727 RID: 50983 RVA: 0x00120E03 File Offset: 0x0011F003
		public unsafe bool bOverride_EnableBattle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattle) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattle) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattle) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattle) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattle : 0));
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600C728 RID: 50984 RVA: 0x00120E33 File Offset: 0x0011F033
		// (set) Token: 0x0600C729 RID: 50985 RVA: 0x00120E4C File Offset: 0x0011F04C
		public unsafe bool bEnableBattle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattle) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattle) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattle) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattle) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattle : 0));
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600C72A RID: 50986 RVA: 0x00120E7C File Offset: 0x0011F07C
		// (set) Token: 0x0600C72B RID: 50987 RVA: 0x00120E95 File Offset: 0x0011F095
		public unsafe bool bOverride_EnableBattleMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattleMask) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattleMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattleMask) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EnableBattleMask) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattleMask) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EnableBattleMask : 0));
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600C72C RID: 50988 RVA: 0x00120EC5 File Offset: 0x0011F0C5
		// (set) Token: 0x0600C72D RID: 50989 RVA: 0x00120EDE File Offset: 0x0011F0DE
		public unsafe bool bEnableBattleMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattleMask) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattleMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattleMask) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEnableBattleMask) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattleMask) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bEnableBattleMask : 0));
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600C72E RID: 50990 RVA: 0x00120F0E File Offset: 0x0011F10E
		// (set) Token: 0x0600C72F RID: 50991 RVA: 0x00120F27 File Offset: 0x0011F127
		public unsafe bool bOverride_IsCharacterHairMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHairMat) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHairMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHairMat) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHairMat) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHairMat) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHairMat : 0));
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600C730 RID: 50992 RVA: 0x00120F57 File Offset: 0x0011F157
		// (set) Token: 0x0600C731 RID: 50993 RVA: 0x00120F70 File Offset: 0x0011F170
		public unsafe bool bIsCharacterHairMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHairMat) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHairMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHairMat) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHairMat) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHairMat) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHairMat : 0));
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600C732 RID: 50994 RVA: 0x00120FA0 File Offset: 0x0011F1A0
		// (set) Token: 0x0600C733 RID: 50995 RVA: 0x00120FB9 File Offset: 0x0011F1B9
		public unsafe bool bOverride_IsCharacterHETMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHETMat) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHETMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHETMat) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsCharacterHETMat) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHETMat) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsCharacterHETMat : 0));
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600C734 RID: 50996 RVA: 0x00120FE9 File Offset: 0x0011F1E9
		// (set) Token: 0x0600C735 RID: 50997 RVA: 0x00121002 File Offset: 0x0011F202
		public unsafe bool bIsCharacterHETMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHETMat) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHETMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHETMat) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsCharacterHETMat) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHETMat) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsCharacterHETMat : 0));
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600C736 RID: 50998 RVA: 0x00121032 File Offset: 0x0011F232
		// (set) Token: 0x0600C737 RID: 50999 RVA: 0x0012104B File Offset: 0x0011F24B
		public unsafe bool bOverride_HETMatOnlyUsedPlayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HETMatOnlyUsedPlayer) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HETMatOnlyUsedPlayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HETMatOnlyUsedPlayer) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HETMatOnlyUsedPlayer) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HETMatOnlyUsedPlayer) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HETMatOnlyUsedPlayer : 0));
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600C738 RID: 51000 RVA: 0x0012107B File Offset: 0x0011F27B
		// (set) Token: 0x0600C739 RID: 51001 RVA: 0x0012108B File Offset: 0x0011F28B
		public unsafe bool bHETMatOnlyUsedPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHETMatOnlyUsedPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHETMatOnlyUsedPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600C73A RID: 51002 RVA: 0x0012109C File Offset: 0x0011F29C
		// (set) Token: 0x0600C73B RID: 51003 RVA: 0x001210B5 File Offset: 0x0011F2B5
		public unsafe bool bOverride_IsUsedWithWriteStencil
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithWriteStencil) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithWriteStencil) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithWriteStencil) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithWriteStencil) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithWriteStencil) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithWriteStencil : 0));
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x001210E5 File Offset: 0x0011F2E5
		// (set) Token: 0x0600C73D RID: 51005 RVA: 0x001210F5 File Offset: 0x0011F2F5
		public unsafe bool bIsUsedWithWriteStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsedWithWriteStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsedWithWriteStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600C73E RID: 51006 RVA: 0x00121106 File Offset: 0x0011F306
		// (set) Token: 0x0600C73F RID: 51007 RVA: 0x0012111F File Offset: 0x0011F31F
		public unsafe bool bOverride_ExtendedHETDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ExtendedHETDistance) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ExtendedHETDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ExtendedHETDistance) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ExtendedHETDistance) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ExtendedHETDistance) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ExtendedHETDistance : 0));
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600C740 RID: 51008 RVA: 0x0012114F File Offset: 0x0011F34F
		// (set) Token: 0x0600C741 RID: 51009 RVA: 0x0012115F File Offset: 0x0011F35F
		public unsafe float ExtendedHETDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ExtendedHETDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ExtendedHETDistance) = value;
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600C742 RID: 51010 RVA: 0x00121170 File Offset: 0x0011F370
		// (set) Token: 0x0600C743 RID: 51011 RVA: 0x00121189 File Offset: 0x0011F389
		public unsafe bool bOverride_RenderTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderTranslucentOpacity) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderTranslucentOpacity) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderTranslucentOpacity) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600C744 RID: 51012 RVA: 0x001211B9 File Offset: 0x0011F3B9
		// (set) Token: 0x0600C745 RID: 51013 RVA: 0x001211C9 File Offset: 0x0011F3C9
		public unsafe bool RenderTranslucentOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_RenderTranslucentOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_RenderTranslucentOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600C746 RID: 51014 RVA: 0x001211DA File Offset: 0x0011F3DA
		// (set) Token: 0x0600C747 RID: 51015 RVA: 0x001211F3 File Offset: 0x0011F3F3
		public unsafe bool bOverride_RenderToonFFT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderToonFFT) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderToonFFT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderToonFFT) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderToonFFT) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderToonFFT) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderToonFFT : 0));
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600C748 RID: 51016 RVA: 0x00121223 File Offset: 0x0011F423
		// (set) Token: 0x0600C749 RID: 51017 RVA: 0x00121233 File Offset: 0x0011F433
		public unsafe bool bRenderToonFFT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderToonFFT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderToonFFT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600C74A RID: 51018 RVA: 0x00121244 File Offset: 0x0011F444
		// (set) Token: 0x0600C74B RID: 51019 RVA: 0x0012125D File Offset: 0x0011F45D
		public unsafe bool bOverride_ForceSceneTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceSceneTranslucentOpacity) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceSceneTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceSceneTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceSceneTranslucentOpacity) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceSceneTranslucentOpacity) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceSceneTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600C74C RID: 51020 RVA: 0x0012128D File Offset: 0x0011F48D
		// (set) Token: 0x0600C74D RID: 51021 RVA: 0x0012129D File Offset: 0x0011F49D
		public unsafe bool ForceSceneTranslucentOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ForceSceneTranslucentOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ForceSceneTranslucentOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600C74E RID: 51022 RVA: 0x001212AE File Offset: 0x0011F4AE
		// (set) Token: 0x0600C74F RID: 51023 RVA: 0x001212C7 File Offset: 0x0011F4C7
		public unsafe bool bOverride_ForceFightTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceFightTranslucentOpacity) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceFightTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceFightTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ForceFightTranslucentOpacity) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceFightTranslucentOpacity) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ForceFightTranslucentOpacity : 0));
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600C750 RID: 51024 RVA: 0x001212F7 File Offset: 0x0011F4F7
		// (set) Token: 0x0600C751 RID: 51025 RVA: 0x00121307 File Offset: 0x0011F507
		public unsafe bool ForceFightTranslucentOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ForceFightTranslucentOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ForceFightTranslucentOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600C752 RID: 51026 RVA: 0x00121318 File Offset: 0x0011F518
		// (set) Token: 0x0600C753 RID: 51027 RVA: 0x00121331 File Offset: 0x0011F531
		public unsafe bool bOverride_HasTranslucentPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasTranslucentPreDepth) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasTranslucentPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasTranslucentPreDepth) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasTranslucentPreDepth) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasTranslucentPreDepth) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasTranslucentPreDepth : 0));
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600C754 RID: 51028 RVA: 0x00121361 File Offset: 0x0011F561
		// (set) Token: 0x0600C755 RID: 51029 RVA: 0x0012137A File Offset: 0x0011F57A
		public unsafe bool bHasTranslucentPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasTranslucentPreDepth) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasTranslucentPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasTranslucentPreDepth) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasTranslucentPreDepth) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasTranslucentPreDepth) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasTranslucentPreDepth : 0));
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600C756 RID: 51030 RVA: 0x001213AA File Offset: 0x0011F5AA
		// (set) Token: 0x0600C757 RID: 51031 RVA: 0x001213C3 File Offset: 0x0011F5C3
		public unsafe bool bOverride_KuroTranslucencyWaterMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroTranslucencyWaterMasked) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroTranslucencyWaterMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroTranslucencyWaterMasked) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroTranslucencyWaterMasked) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroTranslucencyWaterMasked) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroTranslucencyWaterMasked : 0));
			}
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600C758 RID: 51032 RVA: 0x001213F3 File Offset: 0x0011F5F3
		// (set) Token: 0x0600C759 RID: 51033 RVA: 0x0012140C File Offset: 0x0011F60C
		public unsafe bool bKuroTranslucencyWaterMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroTranslucencyWaterMasked) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroTranslucencyWaterMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroTranslucencyWaterMasked) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroTranslucencyWaterMasked) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroTranslucencyWaterMasked) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroTranslucencyWaterMasked : 0));
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600C75A RID: 51034 RVA: 0x0012143C File Offset: 0x0011F63C
		// (set) Token: 0x0600C75B RID: 51035 RVA: 0x00121455 File Offset: 0x0011F655
		public unsafe bool bOverride_CompileRuntimeVirtualTextureVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CompileRuntimeVirtualTextureVariant) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CompileRuntimeVirtualTextureVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CompileRuntimeVirtualTextureVariant) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CompileRuntimeVirtualTextureVariant) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CompileRuntimeVirtualTextureVariant) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CompileRuntimeVirtualTextureVariant : 0));
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600C75C RID: 51036 RVA: 0x00121485 File Offset: 0x0011F685
		// (set) Token: 0x0600C75D RID: 51037 RVA: 0x0012149E File Offset: 0x0011F69E
		public unsafe bool bCompileRuntimeVirtualTextureVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCompileRuntimeVirtualTextureVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCompileRuntimeVirtualTextureVariant) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCompileRuntimeVirtualTextureVariant : 0));
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600C75E RID: 51038 RVA: 0x001214CE File Offset: 0x0011F6CE
		// (set) Token: 0x0600C75F RID: 51039 RVA: 0x001214E7 File Offset: 0x0011F6E7
		public unsafe bool bOverride_KuroSceneTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroSceneTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroSceneTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroSceneTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroSceneTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroSceneTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroSceneTranslucency : 0));
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x00121517 File Offset: 0x0011F717
		// (set) Token: 0x0600C761 RID: 51041 RVA: 0x00121530 File Offset: 0x0011F730
		public unsafe bool bKuroSceneTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroSceneTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroSceneTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroSceneTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroSceneTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroSceneTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroSceneTranslucency : 0));
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600C762 RID: 51042 RVA: 0x00121560 File Offset: 0x0011F760
		// (set) Token: 0x0600C763 RID: 51043 RVA: 0x00121579 File Offset: 0x0011F779
		public unsafe bool bOverride_KuroDownsampleTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroDownsampleTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroDownsampleTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroDownsampleTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroDownsampleTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroDownsampleTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroDownsampleTranslucency : 0));
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x001215A9 File Offset: 0x0011F7A9
		// (set) Token: 0x0600C765 RID: 51045 RVA: 0x001215C2 File Offset: 0x0011F7C2
		public unsafe bool bKuroDownsampleTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroDownsampleTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroDownsampleTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroDownsampleTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroDownsampleTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroDownsampleTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroDownsampleTranslucency : 0));
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600C766 RID: 51046 RVA: 0x001215F2 File Offset: 0x0011F7F2
		// (set) Token: 0x0600C767 RID: 51047 RVA: 0x0012160B File Offset: 0x0011F80B
		public unsafe bool bOverride_HasDataDistortionPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasDataDistortionPass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasDataDistortionPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasDataDistortionPass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasDataDistortionPass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasDataDistortionPass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasDataDistortionPass : 0));
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600C768 RID: 51048 RVA: 0x0012163B File Offset: 0x0011F83B
		// (set) Token: 0x0600C769 RID: 51049 RVA: 0x00121654 File Offset: 0x0011F854
		public unsafe bool bHasDataDistortionPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasDataDistortionPass) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasDataDistortionPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasDataDistortionPass) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasDataDistortionPass) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasDataDistortionPass) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bHasDataDistortionPass : 0));
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600C76A RID: 51050 RVA: 0x00121684 File Offset: 0x0011F884
		// (set) Token: 0x0600C76B RID: 51051 RVA: 0x0012169D File Offset: 0x0011F89D
		public unsafe bool bOverride_CastRayTracedShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRayTracedShadows) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRayTracedShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRayTracedShadows) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRayTracedShadows) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRayTracedShadows) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRayTracedShadows : 0));
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600C76C RID: 51052 RVA: 0x001216CD File Offset: 0x0011F8CD
		// (set) Token: 0x0600C76D RID: 51053 RVA: 0x001216E6 File Offset: 0x0011F8E6
		public unsafe bool bCastRayTracedShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRayTracedShadows) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRayTracedShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRayTracedShadows) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRayTracedShadows) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRayTracedShadows) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRayTracedShadows : 0));
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600C76E RID: 51054 RVA: 0x00121716 File Offset: 0x0011F916
		// (set) Token: 0x0600C76F RID: 51055 RVA: 0x0012172F File Offset: 0x0011F92F
		public unsafe bool bOverride_CastRasterShadowsInRaytracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRasterShadowsInRaytracing) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRasterShadowsInRaytracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRasterShadowsInRaytracing) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CastRasterShadowsInRaytracing) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRasterShadowsInRaytracing) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CastRasterShadowsInRaytracing : 0));
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600C770 RID: 51056 RVA: 0x0012175F File Offset: 0x0011F95F
		// (set) Token: 0x0600C771 RID: 51057 RVA: 0x00121778 File Offset: 0x0011F978
		public unsafe bool bCastRasterShadowsInRaytracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRasterShadowsInRaytracing) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRasterShadowsInRaytracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRasterShadowsInRaytracing) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bCastRasterShadowsInRaytracing) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRasterShadowsInRaytracing) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bCastRasterShadowsInRaytracing : 0));
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600C772 RID: 51058 RVA: 0x001217A8 File Offset: 0x0011F9A8
		// (set) Token: 0x0600C773 RID: 51059 RVA: 0x001217C1 File Offset: 0x0011F9C1
		public unsafe bool bOverride_IsOnlyForSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsOnlyForSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsOnlyForSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsOnlyForSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsOnlyForSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsOnlyForSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsOnlyForSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600C774 RID: 51060 RVA: 0x001217F1 File Offset: 0x0011F9F1
		// (set) Token: 0x0600C775 RID: 51061 RVA: 0x0012180A File Offset: 0x0011FA0A
		public unsafe bool bIsOnlyForSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsOnlyForSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsOnlyForSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsOnlyForSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsOnlyForSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsOnlyForSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsOnlyForSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600C776 RID: 51062 RVA: 0x0012183A File Offset: 0x0011FA3A
		// (set) Token: 0x0600C777 RID: 51063 RVA: 0x00121853 File Offset: 0x0011FA53
		public unsafe bool bOverride_DisableCastDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DisableCastDynamicShadows) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DisableCastDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DisableCastDynamicShadows) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_DisableCastDynamicShadows) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DisableCastDynamicShadows) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_DisableCastDynamicShadows : 0));
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600C778 RID: 51064 RVA: 0x00121883 File Offset: 0x0011FA83
		// (set) Token: 0x0600C779 RID: 51065 RVA: 0x0012189C File Offset: 0x0011FA9C
		public unsafe bool bDisableCastDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableCastDynamicShadows) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableCastDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableCastDynamicShadows) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bDisableCastDynamicShadows) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableCastDynamicShadows) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bDisableCastDynamicShadows : 0));
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600C77A RID: 51066 RVA: 0x001218CC File Offset: 0x0011FACC
		// (set) Token: 0x0600C77B RID: 51067 RVA: 0x001218E5 File Offset: 0x0011FAE5
		public unsafe bool bOverride_IsUsedWithStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithStaticLighting) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithStaticLighting) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsedWithStaticLighting) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithStaticLighting) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsedWithStaticLighting : 0));
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x00121915 File Offset: 0x0011FB15
		// (set) Token: 0x0600C77D RID: 51069 RVA: 0x0012192E File Offset: 0x0011FB2E
		public unsafe bool bIsUsedWithStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsedWithStaticLighting) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsUsedWithStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsedWithStaticLighting) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsedWithStaticLighting) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsUsedWithStaticLighting) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsUsedWithStaticLighting : 0));
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0600C77E RID: 51070 RVA: 0x0012195E File Offset: 0x0011FB5E
		// (set) Token: 0x0600C77F RID: 51071 RVA: 0x00121977 File Offset: 0x0011FB77
		public unsafe bool bOverride_UsedWithSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600C780 RID: 51072 RVA: 0x001219A7 File Offset: 0x0011FBA7
		// (set) Token: 0x0600C781 RID: 51073 RVA: 0x001219C0 File Offset: 0x0011FBC0
		public unsafe bool bUsedWithSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600C782 RID: 51074 RVA: 0x001219F0 File Offset: 0x0011FBF0
		// (set) Token: 0x0600C783 RID: 51075 RVA: 0x00121A09 File Offset: 0x0011FC09
		public unsafe bool bOverride_UsedWithBakedBoneMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBakedBoneMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBakedBoneMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBakedBoneMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBakedBoneMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBakedBoneMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBakedBoneMesh : 0));
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600C784 RID: 51076 RVA: 0x00121A39 File Offset: 0x0011FC39
		// (set) Token: 0x0600C785 RID: 51077 RVA: 0x00121A52 File Offset: 0x0011FC52
		public unsafe bool bUsedWithBakedBoneMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBakedBoneMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBakedBoneMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBakedBoneMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBakedBoneMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBakedBoneMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBakedBoneMesh : 0));
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600C786 RID: 51078 RVA: 0x00121A82 File Offset: 0x0011FC82
		// (set) Token: 0x0600C787 RID: 51079 RVA: 0x00121A9B File Offset: 0x0011FC9B
		public unsafe bool bOverride_UsedWithExpandedTexcoordsSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithExpandedTexcoordsSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithExpandedTexcoordsSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithExpandedTexcoordsSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithExpandedTexcoordsSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithExpandedTexcoordsSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithExpandedTexcoordsSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600C788 RID: 51080 RVA: 0x00121ACB File Offset: 0x0011FCCB
		// (set) Token: 0x0600C789 RID: 51081 RVA: 0x00121AE4 File Offset: 0x0011FCE4
		public unsafe bool bUsedWithExpandedTexcoordsSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh : 0));
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600C78A RID: 51082 RVA: 0x00121B14 File Offset: 0x0011FD14
		// (set) Token: 0x0600C78B RID: 51083 RVA: 0x00121B2D File Offset: 0x0011FD2D
		public unsafe bool bOverride_SupportsUBInstancing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_SupportsUBInstancing) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_SupportsUBInstancing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_SupportsUBInstancing) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_SupportsUBInstancing) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_SupportsUBInstancing) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_SupportsUBInstancing : 0));
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600C78C RID: 51084 RVA: 0x00121B5D File Offset: 0x0011FD5D
		// (set) Token: 0x0600C78D RID: 51085 RVA: 0x00121B76 File Offset: 0x0011FD76
		public unsafe bool bSupportsUBInstancing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSupportsUBInstancing) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSupportsUBInstancing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSupportsUBInstancing) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bSupportsUBInstancing) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSupportsUBInstancing) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bSupportsUBInstancing : 0));
			}
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600C78E RID: 51086 RVA: 0x00121BA6 File Offset: 0x0011FDA6
		// (set) Token: 0x0600C78F RID: 51087 RVA: 0x00121BBF File Offset: 0x0011FDBF
		public unsafe bool bOverride_UsedWithParticleSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithParticleSprites) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithParticleSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithParticleSprites) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithParticleSprites) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithParticleSprites) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithParticleSprites : 0));
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600C790 RID: 51088 RVA: 0x00121BEF File Offset: 0x0011FDEF
		// (set) Token: 0x0600C791 RID: 51089 RVA: 0x00121C08 File Offset: 0x0011FE08
		public unsafe bool bUsedWithParticleSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithParticleSprites) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithParticleSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithParticleSprites) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithParticleSprites) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithParticleSprites) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithParticleSprites : 0));
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600C792 RID: 51090 RVA: 0x00121C38 File Offset: 0x0011FE38
		// (set) Token: 0x0600C793 RID: 51091 RVA: 0x00121C51 File Offset: 0x0011FE51
		public unsafe bool bOverride_UsedWithBeamTrails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBeamTrails) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBeamTrails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBeamTrails) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithBeamTrails) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBeamTrails) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithBeamTrails : 0));
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x00121C81 File Offset: 0x0011FE81
		// (set) Token: 0x0600C795 RID: 51093 RVA: 0x00121C9A File Offset: 0x0011FE9A
		public unsafe bool bUsedWithBeamTrails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBeamTrails) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBeamTrails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBeamTrails) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithBeamTrails) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBeamTrails) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithBeamTrails : 0));
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600C796 RID: 51094 RVA: 0x00121CCA File Offset: 0x0011FECA
		// (set) Token: 0x0600C797 RID: 51095 RVA: 0x00121CE3 File Offset: 0x0011FEE3
		public unsafe bool bOverride_UsedWithMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMeshParticles) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMeshParticles) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMeshParticles) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMeshParticles) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMeshParticles : 0));
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x00121D13 File Offset: 0x0011FF13
		// (set) Token: 0x0600C799 RID: 51097 RVA: 0x00121D2C File Offset: 0x0011FF2C
		public unsafe bool bUsedWithMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMeshParticles) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMeshParticles) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMeshParticles) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMeshParticles) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMeshParticles : 0));
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x00121D5C File Offset: 0x0011FF5C
		// (set) Token: 0x0600C79B RID: 51099 RVA: 0x00121D75 File Offset: 0x0011FF75
		public unsafe bool bOverride_UsedWithNiagaraSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraSprites) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraSprites) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraSprites) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraSprites) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraSprites : 0));
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600C79C RID: 51100 RVA: 0x00121DA5 File Offset: 0x0011FFA5
		// (set) Token: 0x0600C79D RID: 51101 RVA: 0x00121DBE File Offset: 0x0011FFBE
		public unsafe bool bUsedWithNiagaraSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraSprites) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraSprites) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraSprites) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraSprites) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraSprites : 0));
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600C79E RID: 51102 RVA: 0x00121DEE File Offset: 0x0011FFEE
		// (set) Token: 0x0600C79F RID: 51103 RVA: 0x00121E07 File Offset: 0x00120007
		public unsafe bool bOverride_UsedWithNiagaraRibbons
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraRibbons) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraRibbons) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraRibbons) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraRibbons) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraRibbons) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraRibbons : 0));
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600C7A0 RID: 51104 RVA: 0x00121E37 File Offset: 0x00120037
		// (set) Token: 0x0600C7A1 RID: 51105 RVA: 0x00121E50 File Offset: 0x00120050
		public unsafe bool bUsedWithNiagaraRibbons
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraRibbons) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraRibbons) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraRibbons) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraRibbons) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraRibbons) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraRibbons : 0));
			}
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x00121E80 File Offset: 0x00120080
		// (set) Token: 0x0600C7A3 RID: 51107 RVA: 0x00121E99 File Offset: 0x00120099
		public unsafe bool bOverride_UsedWithNiagaraMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraMeshParticles) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraMeshParticles) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithNiagaraMeshParticles) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraMeshParticles) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithNiagaraMeshParticles : 0));
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x00121EC9 File Offset: 0x001200C9
		// (set) Token: 0x0600C7A5 RID: 51109 RVA: 0x00121EE2 File Offset: 0x001200E2
		public unsafe bool bUsedWithNiagaraMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraMeshParticles) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraMeshParticles) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithNiagaraMeshParticles) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraMeshParticles) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithNiagaraMeshParticles : 0));
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x00121F12 File Offset: 0x00120112
		// (set) Token: 0x0600C7A7 RID: 51111 RVA: 0x00121F2B File Offset: 0x0012012B
		public unsafe bool bOverride_UsedWithGeometryCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCache) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCache) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCache) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCache) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCache : 0));
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600C7A8 RID: 51112 RVA: 0x00121F5B File Offset: 0x0012015B
		// (set) Token: 0x0600C7A9 RID: 51113 RVA: 0x00121F74 File Offset: 0x00120174
		public unsafe bool bUsedWithGeometryCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCache) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCache) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCache) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCache) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCache : 0));
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600C7AA RID: 51114 RVA: 0x00121FA4 File Offset: 0x001201A4
		// (set) Token: 0x0600C7AB RID: 51115 RVA: 0x00121FBD File Offset: 0x001201BD
		public unsafe bool bOverride_UsedWithMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMorphTargets) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMorphTargets) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithMorphTargets) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMorphTargets) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithMorphTargets : 0));
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00121FED File Offset: 0x001201ED
		// (set) Token: 0x0600C7AD RID: 51117 RVA: 0x00122006 File Offset: 0x00120206
		public unsafe bool bUsedWithMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMorphTargets) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMorphTargets) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithMorphTargets) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMorphTargets) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithMorphTargets : 0));
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x00122036 File Offset: 0x00120236
		// (set) Token: 0x0600C7AF RID: 51119 RVA: 0x0012204F File Offset: 0x0012024F
		public unsafe bool bOverride_UsedWithSplineMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSplineMeshes) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSplineMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSplineMeshes) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithSplineMeshes) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSplineMeshes) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithSplineMeshes : 0));
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x0012207F File Offset: 0x0012027F
		// (set) Token: 0x0600C7B1 RID: 51121 RVA: 0x00122098 File Offset: 0x00120298
		public unsafe bool bUsedWithSplineMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSplineMeshes) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSplineMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSplineMeshes) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithSplineMeshes) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSplineMeshes) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithSplineMeshes : 0));
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x001220C8 File Offset: 0x001202C8
		// (set) Token: 0x0600C7B3 RID: 51123 RVA: 0x001220E1 File Offset: 0x001202E1
		public unsafe bool bOverride_UsedWithInstancedStaticMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithInstancedStaticMeshes) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithInstancedStaticMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithInstancedStaticMeshes) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithInstancedStaticMeshes) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithInstancedStaticMeshes) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithInstancedStaticMeshes : 0));
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600C7B4 RID: 51124 RVA: 0x00122111 File Offset: 0x00120311
		// (set) Token: 0x0600C7B5 RID: 51125 RVA: 0x0012212A File Offset: 0x0012032A
		public unsafe bool bUsedWithInstancedStaticMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithInstancedStaticMeshes) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithInstancedStaticMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithInstancedStaticMeshes) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithInstancedStaticMeshes) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithInstancedStaticMeshes) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithInstancedStaticMeshes : 0));
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600C7B6 RID: 51126 RVA: 0x0012215A File Offset: 0x0012035A
		// (set) Token: 0x0600C7B7 RID: 51127 RVA: 0x00122173 File Offset: 0x00120373
		public unsafe bool bOverride_UsedWithGeometryCollections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCollections) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCollections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCollections) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithGeometryCollections) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCollections) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithGeometryCollections : 0));
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600C7B8 RID: 51128 RVA: 0x001221A3 File Offset: 0x001203A3
		// (set) Token: 0x0600C7B9 RID: 51129 RVA: 0x001221BC File Offset: 0x001203BC
		public unsafe bool bUsedWithGeometryCollections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCollections) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCollections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCollections) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithGeometryCollections) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCollections) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithGeometryCollections : 0));
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600C7BA RID: 51130 RVA: 0x001221EC File Offset: 0x001203EC
		// (set) Token: 0x0600C7BB RID: 51131 RVA: 0x00122205 File Offset: 0x00120405
		public unsafe bool bOverride_UsedWithWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithWater) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithWater) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithWater) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithWater) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithWater : 0));
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600C7BC RID: 51132 RVA: 0x00122235 File Offset: 0x00120435
		// (set) Token: 0x0600C7BD RID: 51133 RVA: 0x0012224E File Offset: 0x0012044E
		public unsafe bool bUsedWithWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithWater) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithWater) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithWater) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithWater) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithWater : 0));
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600C7BE RID: 51134 RVA: 0x0012227E File Offset: 0x0012047E
		// (set) Token: 0x0600C7BF RID: 51135 RVA: 0x00122297 File Offset: 0x00120497
		public unsafe bool bOverride_UsedWithHairStrands
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithHairStrands) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithHairStrands) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithHairStrands) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithHairStrands) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithHairStrands) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithHairStrands : 0));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600C7C0 RID: 51136 RVA: 0x001222C7 File Offset: 0x001204C7
		// (set) Token: 0x0600C7C1 RID: 51137 RVA: 0x001222E0 File Offset: 0x001204E0
		public unsafe bool bUsedWithHairStrands
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithHairStrands) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithHairStrands) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithHairStrands) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithHairStrands) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithHairStrands) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithHairStrands : 0));
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600C7C2 RID: 51138 RVA: 0x00122310 File Offset: 0x00120510
		// (set) Token: 0x0600C7C3 RID: 51139 RVA: 0x00122329 File Offset: 0x00120529
		public unsafe bool bOverride_UsedWithLidarPointCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithLidarPointCloud) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithLidarPointCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithLidarPointCloud) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithLidarPointCloud) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithLidarPointCloud) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithLidarPointCloud : 0));
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600C7C4 RID: 51140 RVA: 0x00122359 File Offset: 0x00120559
		// (set) Token: 0x0600C7C5 RID: 51141 RVA: 0x00122372 File Offset: 0x00120572
		public unsafe bool bUsedWithLidarPointCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithLidarPointCloud) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithLidarPointCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithLidarPointCloud) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithLidarPointCloud) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithLidarPointCloud) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithLidarPointCloud : 0));
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600C7C6 RID: 51142 RVA: 0x001223A2 File Offset: 0x001205A2
		// (set) Token: 0x0600C7C7 RID: 51143 RVA: 0x001223BB File Offset: 0x001205BB
		public unsafe bool bOverride_UsedWithVirtualHeightfieldMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithVirtualHeightfieldMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithVirtualHeightfieldMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithVirtualHeightfieldMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithVirtualHeightfieldMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithVirtualHeightfieldMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithVirtualHeightfieldMesh : 0));
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600C7C8 RID: 51144 RVA: 0x001223EB File Offset: 0x001205EB
		// (set) Token: 0x0600C7C9 RID: 51145 RVA: 0x00122404 File Offset: 0x00120604
		public unsafe bool bUsedWithVirtualHeightfieldMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithVirtualHeightfieldMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithVirtualHeightfieldMesh) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithVirtualHeightfieldMesh : 0));
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600C7CA RID: 51146 RVA: 0x00122434 File Offset: 0x00120634
		// (set) Token: 0x0600C7CB RID: 51147 RVA: 0x0012244D File Offset: 0x0012064D
		public unsafe bool bOverride_RemoveLocalVertexFactory
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RemoveLocalVertexFactory) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RemoveLocalVertexFactory) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RemoveLocalVertexFactory) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RemoveLocalVertexFactory) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RemoveLocalVertexFactory) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RemoveLocalVertexFactory : 0));
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600C7CC RID: 51148 RVA: 0x0012247D File Offset: 0x0012067D
		// (set) Token: 0x0600C7CD RID: 51149 RVA: 0x00122496 File Offset: 0x00120696
		public unsafe bool bRemoveLocalVertexFactory
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRemoveLocalVertexFactory) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRemoveLocalVertexFactory) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRemoveLocalVertexFactory) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRemoveLocalVertexFactory) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRemoveLocalVertexFactory) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bRemoveLocalVertexFactory : 0));
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x001224C6 File Offset: 0x001206C6
		// (set) Token: 0x0600C7CF RID: 51151 RVA: 0x001224DF File Offset: 0x001206DF
		public unsafe bool bOverride_IsDisableWuYinQuLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWuYinQuLayer) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWuYinQuLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWuYinQuLayer) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWuYinQuLayer) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWuYinQuLayer) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWuYinQuLayer : 0));
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600C7D0 RID: 51152 RVA: 0x0012250F File Offset: 0x0012070F
		// (set) Token: 0x0600C7D1 RID: 51153 RVA: 0x00122528 File Offset: 0x00120728
		public unsafe bool bIsDisableWuYinQuLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWuYinQuLayer) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWuYinQuLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWuYinQuLayer) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWuYinQuLayer) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWuYinQuLayer) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWuYinQuLayer : 0));
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600C7D2 RID: 51154 RVA: 0x00122558 File Offset: 0x00120758
		// (set) Token: 0x0600C7D3 RID: 51155 RVA: 0x00122571 File Offset: 0x00120771
		public unsafe bool bOverride_IsDisableWetLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWetLayer) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWetLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWetLayer) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsDisableWetLayer) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWetLayer) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsDisableWetLayer : 0));
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x001225A1 File Offset: 0x001207A1
		// (set) Token: 0x0600C7D5 RID: 51157 RVA: 0x001225BA File Offset: 0x001207BA
		public unsafe bool bIsDisableWetLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWetLayer) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWetLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWetLayer) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsDisableWetLayer) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWetLayer) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsDisableWetLayer : 0));
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600C7D6 RID: 51158 RVA: 0x001225EA File Offset: 0x001207EA
		// (set) Token: 0x0600C7D7 RID: 51159 RVA: 0x00122603 File Offset: 0x00120803
		public unsafe bool bOverride_IsNoWaterForToon
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsNoWaterForToon) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsNoWaterForToon) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsNoWaterForToon) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsNoWaterForToon) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsNoWaterForToon) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsNoWaterForToon : 0));
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x00122633 File Offset: 0x00120833
		// (set) Token: 0x0600C7D9 RID: 51161 RVA: 0x0012264C File Offset: 0x0012084C
		public unsafe bool bIsNoWaterForToon
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsNoWaterForToon) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsNoWaterForToon) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsNoWaterForToon) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsNoWaterForToon) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsNoWaterForToon) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsNoWaterForToon : 0));
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600C7DA RID: 51162 RVA: 0x0012267C File Offset: 0x0012087C
		// (set) Token: 0x0600C7DB RID: 51163 RVA: 0x00122695 File Offset: 0x00120895
		public unsafe bool bOverride_UsedWithShadowSVT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithShadowSVT) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithShadowSVT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithShadowSVT) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UsedWithShadowSVT) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithShadowSVT) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UsedWithShadowSVT : 0));
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600C7DC RID: 51164 RVA: 0x001226C5 File Offset: 0x001208C5
		// (set) Token: 0x0600C7DD RID: 51165 RVA: 0x001226DE File Offset: 0x001208DE
		public unsafe bool bUsedWithShadowSVT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithShadowSVT) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithShadowSVT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithShadowSVT) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUsedWithShadowSVT) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithShadowSVT) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUsedWithShadowSVT : 0));
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600C7DE RID: 51166 RVA: 0x0012270E File Offset: 0x0012090E
		// (set) Token: 0x0600C7DF RID: 51167 RVA: 0x00122727 File Offset: 0x00120927
		public unsafe bool bOverride_StencilRefValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_StencilRefValue) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_StencilRefValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_StencilRefValue) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_StencilRefValue) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_StencilRefValue) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_StencilRefValue : 0));
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600C7E0 RID: 51168 RVA: 0x00122757 File Offset: 0x00120957
		// (set) Token: 0x0600C7E1 RID: 51169 RVA: 0x00122767 File Offset: 0x00120967
		public unsafe byte StencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_StencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_StencilRefValue) = value;
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600C7E2 RID: 51170 RVA: 0x00122778 File Offset: 0x00120978
		// (set) Token: 0x0600C7E3 RID: 51171 RVA: 0x00122791 File Offset: 0x00120991
		public unsafe bool bOverride_IsMobileOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsMobileOutputVelocity) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsMobileOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsMobileOutputVelocity) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsMobileOutputVelocity) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsMobileOutputVelocity) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsMobileOutputVelocity : 0));
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600C7E4 RID: 51172 RVA: 0x001227C1 File Offset: 0x001209C1
		// (set) Token: 0x0600C7E5 RID: 51173 RVA: 0x001227DA File Offset: 0x001209DA
		public unsafe bool bIsMobileOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsMobileOutputVelocity) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsMobileOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsMobileOutputVelocity) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsMobileOutputVelocity) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsMobileOutputVelocity) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsMobileOutputVelocity : 0));
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x0012280A File Offset: 0x00120A0A
		// (set) Token: 0x0600C7E7 RID: 51175 RVA: 0x00122823 File Offset: 0x00120A23
		public unsafe bool bOverride_KuroBlendWaterTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroBlendWaterTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroBlendWaterTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroBlendWaterTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_KuroBlendWaterTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroBlendWaterTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_KuroBlendWaterTranslucency : 0));
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600C7E8 RID: 51176 RVA: 0x00122853 File Offset: 0x00120A53
		// (set) Token: 0x0600C7E9 RID: 51177 RVA: 0x0012286C File Offset: 0x00120A6C
		public unsafe bool bKuroBlendWaterTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroBlendWaterTranslucency) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroBlendWaterTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroBlendWaterTranslucency) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bKuroBlendWaterTranslucency) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroBlendWaterTranslucency) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bKuroBlendWaterTranslucency : 0));
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600C7EA RID: 51178 RVA: 0x0012289C File Offset: 0x00120A9C
		// (set) Token: 0x0600C7EB RID: 51179 RVA: 0x001228B5 File Offset: 0x00120AB5
		public unsafe bool bOverride_IsBackFace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsBackFace) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsBackFace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsBackFace) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsBackFace) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsBackFace) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsBackFace : 0));
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x001228E5 File Offset: 0x00120AE5
		// (set) Token: 0x0600C7ED RID: 51181 RVA: 0x001228FE File Offset: 0x00120AFE
		public unsafe bool bIsBackFace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsBackFace) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsBackFace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsBackFace) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsBackFace) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsBackFace) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsBackFace : 0));
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x0012292E File Offset: 0x00120B2E
		// (set) Token: 0x0600C7EF RID: 51183 RVA: 0x00122947 File Offset: 0x00120B47
		public unsafe bool bOverride_UseMobileDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseMobileDistortion) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseMobileDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseMobileDistortion) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseMobileDistortion) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseMobileDistortion) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseMobileDistortion : 0));
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600C7F0 RID: 51184 RVA: 0x00122977 File Offset: 0x00120B77
		// (set) Token: 0x0600C7F1 RID: 51185 RVA: 0x00122990 File Offset: 0x00120B90
		public unsafe bool bUseMobileDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseMobileDistortion) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseMobileDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseMobileDistortion) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseMobileDistortion) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseMobileDistortion) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseMobileDistortion : 0));
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600C7F2 RID: 51186 RVA: 0x001229C0 File Offset: 0x00120BC0
		// (set) Token: 0x0600C7F3 RID: 51187 RVA: 0x001229D9 File Offset: 0x00120BD9
		public unsafe bool bOverride_IsLGUIMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsLGUIMaterial) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsLGUIMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsLGUIMaterial) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsLGUIMaterial) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsLGUIMaterial) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsLGUIMaterial : 0));
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x00122A09 File Offset: 0x00120C09
		// (set) Token: 0x0600C7F5 RID: 51189 RVA: 0x00122A22 File Offset: 0x00120C22
		public unsafe bool bIsLGUIMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsLGUIMaterial) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsLGUIMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsLGUIMaterial) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsLGUIMaterial) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsLGUIMaterial) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bIsLGUIMaterial : 0));
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600C7F6 RID: 51190 RVA: 0x00122A52 File Offset: 0x00120C52
		// (set) Token: 0x0600C7F7 RID: 51191 RVA: 0x00122A6B File Offset: 0x00120C6B
		public unsafe bool bOverride_UseNormalDither
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseNormalDither) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseNormalDither) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseNormalDither) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseNormalDither) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseNormalDither) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseNormalDither : 0));
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600C7F8 RID: 51192 RVA: 0x00122A9B File Offset: 0x00120C9B
		// (set) Token: 0x0600C7F9 RID: 51193 RVA: 0x00122AB4 File Offset: 0x00120CB4
		public unsafe bool bUseNormalDither
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseNormalDither) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseNormalDither) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseNormalDither) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseNormalDither) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseNormalDither) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseNormalDither : 0));
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x00122AE4 File Offset: 0x00120CE4
		// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x00122AFD File Offset: 0x00120CFD
		public unsafe bool bOverride_NormalDitherScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_NormalDitherScale) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_NormalDitherScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_NormalDitherScale) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_NormalDitherScale) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_NormalDitherScale) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_NormalDitherScale : 0));
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x00122B2D File Offset: 0x00120D2D
		// (set) Token: 0x0600C7FD RID: 51197 RVA: 0x00122B3D File Offset: 0x00120D3D
		public unsafe float NormalDitherScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_NormalDitherScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_NormalDitherScale) = value;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00122B4E File Offset: 0x00120D4E
		// (set) Token: 0x0600C7FF RID: 51199 RVA: 0x00122B67 File Offset: 0x00120D67
		public unsafe bool bOverride_WPORTCullDistScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_WPORTCullDistScale) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_WPORTCullDistScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_WPORTCullDistScale) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_WPORTCullDistScale) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_WPORTCullDistScale) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_WPORTCullDistScale : 0));
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x00122B97 File Offset: 0x00120D97
		// (set) Token: 0x0600C801 RID: 51201 RVA: 0x00122BA7 File Offset: 0x00120DA7
		public unsafe float WPORTCullDistScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_WPORTCullDistScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_WPORTCullDistScale) = value;
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600C802 RID: 51202 RVA: 0x00122BB8 File Offset: 0x00120DB8
		// (set) Token: 0x0600C803 RID: 51203 RVA: 0x00122BD1 File Offset: 0x00120DD1
		public unsafe bool bOverride_ToonCustomStencilBit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ToonCustomStencilBit) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ToonCustomStencilBit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ToonCustomStencilBit) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_ToonCustomStencilBit) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ToonCustomStencilBit) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_ToonCustomStencilBit : 0));
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x00122C01 File Offset: 0x00120E01
		// (set) Token: 0x0600C805 RID: 51205 RVA: 0x00122C11 File Offset: 0x00120E11
		public unsafe byte ToonCustomStencilBit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ToonCustomStencilBit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_ToonCustomStencilBit) = value;
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x00122C22 File Offset: 0x00120E22
		// (set) Token: 0x0600C807 RID: 51207 RVA: 0x00122C3B File Offset: 0x00120E3B
		public unsafe bool bOverride_RenderInKuroVolumetricLightColorMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderInKuroVolumetricLightColorMask) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderInKuroVolumetricLightColorMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderInKuroVolumetricLightColorMask) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_RenderInKuroVolumetricLightColorMask) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderInKuroVolumetricLightColorMask) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_RenderInKuroVolumetricLightColorMask : 0));
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x00122C6B File Offset: 0x00120E6B
		// (set) Token: 0x0600C809 RID: 51209 RVA: 0x00122C7B File Offset: 0x00120E7B
		public unsafe bool bRenderInKuroVolumetricLightColorMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x00122C8C File Offset: 0x00120E8C
		// (set) Token: 0x0600C80B RID: 51211 RVA: 0x00122CA5 File Offset: 0x00120EA5
		public unsafe bool bOverride_HasCustomWPOVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasCustomWPOVariant) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasCustomWPOVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasCustomWPOVariant) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_HasCustomWPOVariant) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasCustomWPOVariant) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_HasCustomWPOVariant : 0));
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600C80C RID: 51212 RVA: 0x00122CD5 File Offset: 0x00120ED5
		// (set) Token: 0x0600C80D RID: 51213 RVA: 0x00122CE5 File Offset: 0x00120EE5
		public unsafe bool bHasCustomWPOVariant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasCustomWPOVariant) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bHasCustomWPOVariant) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600C80E RID: 51214 RVA: 0x00122CF6 File Offset: 0x00120EF6
		// (set) Token: 0x0600C80F RID: 51215 RVA: 0x00122D0F File Offset: 0x00120F0F
		public unsafe bool bOverride_EffectSpaceWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceWrite) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceWrite) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceWrite) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceWrite) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceWrite : 0));
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600C810 RID: 51216 RVA: 0x00122D3F File Offset: 0x00120F3F
		// (set) Token: 0x0600C811 RID: 51217 RVA: 0x00122D4F File Offset: 0x00120F4F
		public unsafe bool bEffectSpaceWrite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEffectSpaceWrite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEffectSpaceWrite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x00122D60 File Offset: 0x00120F60
		// (set) Token: 0x0600C813 RID: 51219 RVA: 0x00122D79 File Offset: 0x00120F79
		public unsafe bool bOverride_EffectSpaceRead
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceRead) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceRead) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceRead) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_EffectSpaceRead) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceRead) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_EffectSpaceRead : 0));
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600C814 RID: 51220 RVA: 0x00122DA9 File Offset: 0x00120FA9
		// (set) Token: 0x0600C815 RID: 51221 RVA: 0x00122DB9 File Offset: 0x00120FB9
		public unsafe bool bEffectSpaceRead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEffectSpaceRead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bEffectSpaceRead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600C816 RID: 51222 RVA: 0x00122DCA File Offset: 0x00120FCA
		// (set) Token: 0x0600C817 RID: 51223 RVA: 0x00122DE3 File Offset: 0x00120FE3
		public unsafe bool bOverride_XRayStencilWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_XRayStencilWrite) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_XRayStencilWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_XRayStencilWrite) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_XRayStencilWrite) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_XRayStencilWrite) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_XRayStencilWrite : 0));
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600C818 RID: 51224 RVA: 0x00122E13 File Offset: 0x00121013
		// (set) Token: 0x0600C819 RID: 51225 RVA: 0x00122E23 File Offset: 0x00121023
		public unsafe bool bXRayStencilWrite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bXRayStencilWrite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bXRayStencilWrite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600C81A RID: 51226 RVA: 0x00122E34 File Offset: 0x00121034
		// (set) Token: 0x0600C81B RID: 51227 RVA: 0x00122E4D File Offset: 0x0012104D
		public unsafe bool bOverride_IsUsingCustomStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilTest) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilTest) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilTest) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilTest) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilTest : 0));
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600C81C RID: 51228 RVA: 0x00122E7D File Offset: 0x0012107D
		// (set) Token: 0x0600C81D RID: 51229 RVA: 0x00122E8D File Offset: 0x0012108D
		public unsafe bool bIsUsingCustomStencilTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsingCustomStencilTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsingCustomStencilTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600C81E RID: 51230 RVA: 0x00122E9E File Offset: 0x0012109E
		// (set) Token: 0x0600C81F RID: 51231 RVA: 0x00122EB7 File Offset: 0x001210B7
		public unsafe bool bOverride_IsUsingCustomStencilDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilDepthTest) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilDepthTest) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_IsUsingCustomStencilDepthTest) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilDepthTest) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_IsUsingCustomStencilDepthTest : 0));
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600C820 RID: 51232 RVA: 0x00122EE7 File Offset: 0x001210E7
		// (set) Token: 0x0600C821 RID: 51233 RVA: 0x00122EF7 File Offset: 0x001210F7
		public unsafe bool bIsUsingCustomStencilDepthTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsingCustomStencilDepthTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bIsUsingCustomStencilDepthTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600C822 RID: 51234 RVA: 0x00122F08 File Offset: 0x00121108
		// (set) Token: 0x0600C823 RID: 51235 RVA: 0x00122F21 File Offset: 0x00121121
		public unsafe bool bOverride_CustomStencilRefValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomStencilRefValue) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomStencilRefValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomStencilRefValue) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_CustomStencilRefValue) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomStencilRefValue) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_CustomStencilRefValue : 0));
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x00122F51 File Offset: 0x00121151
		// (set) Token: 0x0600C825 RID: 51237 RVA: 0x00122F61 File Offset: 0x00121161
		public unsafe byte CustomStencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_CustomStencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_CustomStencilRefValue) = value;
			}
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x00122F72 File Offset: 0x00121172
		// (set) Token: 0x0600C827 RID: 51239 RVA: 0x00122F8B File Offset: 0x0012118B
		public unsafe bool bOverride_UseFullPrecision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecision) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecision) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecision) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecision) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecision : 0));
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x00122FBB File Offset: 0x001211BB
		// (set) Token: 0x0600C829 RID: 51241 RVA: 0x00122FD4 File Offset: 0x001211D4
		public unsafe bool bUseFullPrecision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecision) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecision) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecision) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecision) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecision : 0));
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x00123004 File Offset: 0x00121204
		// (set) Token: 0x0600C82B RID: 51243 RVA: 0x0012301D File Offset: 0x0012121D
		public unsafe bool bOverride_FullPrecisionPlatform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionPlatform) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionPlatform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionPlatform) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionPlatform) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionPlatform) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionPlatform : 0));
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x0012304D File Offset: 0x0012124D
		// (set) Token: 0x0600C82D RID: 51245 RVA: 0x00123061 File Offset: 0x00121261
		public unsafe TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_FullPrecisionPlatform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_FullPrecisionPlatform) = value;
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x00123076 File Offset: 0x00121276
		// (set) Token: 0x0600C82F RID: 51247 RVA: 0x0012308F File Offset: 0x0012128F
		public unsafe bool bOverride_UseFullPrecisionParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecisionParams) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecisionParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecisionParams) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_UseFullPrecisionParams) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecisionParams) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_UseFullPrecisionParams : 0));
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600C830 RID: 51248 RVA: 0x001230BF File Offset: 0x001212BF
		// (set) Token: 0x0600C831 RID: 51249 RVA: 0x001230D8 File Offset: 0x001212D8
		public unsafe bool bUseFullPrecisionParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecisionParams) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecisionParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecisionParams) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bUseFullPrecisionParams) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecisionParams) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bUseFullPrecisionParams : 0));
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600C832 RID: 51250 RVA: 0x00123108 File Offset: 0x00121308
		// (set) Token: 0x0600C833 RID: 51251 RVA: 0x00123121 File Offset: 0x00121321
		public unsafe bool bOverride_FullPrecisionParamsPlatform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionParamsPlatform) & FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionParamsPlatform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionParamsPlatform) = ((*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_bOverride_FullPrecisionParamsPlatform) & ~FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionParamsPlatform) | (value ? FMaterialInstanceBasePropertyOverrides.__PropertyMask_bOverride_FullPrecisionParamsPlatform : 0));
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600C834 RID: 51252 RVA: 0x00123151 File Offset: 0x00121351
		// (set) Token: 0x0600C835 RID: 51253 RVA: 0x00123165 File Offset: 0x00121365
		public unsafe TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionParamsPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_FullPrecisionParamsPlatform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInstanceBasePropertyOverrides.__PropertyOffset_FullPrecisionParamsPlatform) = value;
			}
		}

		// Token: 0x0600C836 RID: 51254 RVA: 0x0012317A File Offset: 0x0012137A
		public FMaterialInstanceBasePropertyOverrides()
		{
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x00123184 File Offset: 0x00121384
		public FMaterialInstanceBasePropertyOverrides(bool bOverride_OpacityMaskClipValue, bool bOverride_BlendMode, bool bOverride_ShadingModel, bool bOverride_DitheredLODTransition, bool bOverride_CastDynamicShadowAsMasked, bool bOverride_TwoSided, bool bOverride_KuroWater, bool bOverride_bSceneDissolveEnable, bool bOverride_bSceneColorClearEnable, bool TwoSided, bool KuroWater, bool bSceneDissolveEnable, bool bSceneColorClearEnable, bool bOverride_EnableSeparateTranslucency, bool bEnableSeparateTranslucency, bool bOverride_bMaskedRenderInPreDepth, bool bMaskedRenderInPreDepth, bool bOverride_bMaskedRenderInPreDepth_PC, bool bMaskedRenderInPreDepth_PC, bool bOverride_TessellationMode, TEnumAsByte<EMaterialTessellationMode> TessellationMode, bool bOverride_bEnableCrackFreeDisplacement, bool bEnableCrackFreeDisplacement, bool bOverride_bEnableAdaptiveTessellation, bool bEnableAdaptiveTessellation, bool bOverride_bDisableTessellationInShadowPass, bool bDisableTessellationInShadowPass, bool bOverride_bRenderInCustomCapturePass, bool bRenderInCustomCapturePass, bool bOverride_bUsedWithKuroCSInteractiveObject, bool bUsedWithKuroCSInteractiveObject, bool bOverride_ShadingRate, TEnumAsByte<EMaterialShadingRate> ShadingRate, bool bOverride_PipelineStateCreationHint, TEnumAsByte<EMaterialPipelineStateCreationHint> PipelineStateCreationHint, bool DitheredLODTransition, bool bCastDynamicShadowAsMasked, TEnumAsByte<EBlendMode> BlendMode, TEnumAsByte<EMaterialShadingModel> ShadingModel, float OpacityMaskClipValue, bool bOverride_RenderQueue, ushort RenderQueue, bool bOverride_MaterialDesktopGameQualityShoulderRender, TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialDesktopGameQualityShoulderRender, bool bOverride_MaterialMobileGameQualityShoulderRender, TEnumAsByte<EMaterialGameQualityShoulderRender> MaterialMobileGameQualityShoulderRender, bool bOverride_CustomAlphaTest, bool bCustomAlphaTest, bool bOverride_EnableBattle, bool bEnableBattle, bool bOverride_EnableBattleMask, bool bEnableBattleMask, bool bOverride_IsCharacterHairMat, bool bIsCharacterHairMat, bool bOverride_IsCharacterHETMat, bool bIsCharacterHETMat, bool bOverride_HETMatOnlyUsedPlayer, bool bHETMatOnlyUsedPlayer, bool bOverride_IsUsedWithWriteStencil, bool bIsUsedWithWriteStencil, bool bOverride_ExtendedHETDistance, float ExtendedHETDistance, bool bOverride_RenderTranslucentOpacity, bool RenderTranslucentOpacity, bool bOverride_RenderToonFFT, bool bRenderToonFFT, bool bOverride_ForceSceneTranslucentOpacity, bool ForceSceneTranslucentOpacity, bool bOverride_ForceFightTranslucentOpacity, bool ForceFightTranslucentOpacity, bool bOverride_HasTranslucentPreDepth, bool bHasTranslucentPreDepth, bool bOverride_KuroTranslucencyWaterMasked, bool bKuroTranslucencyWaterMasked, bool bOverride_CompileRuntimeVirtualTextureVariant, bool bCompileRuntimeVirtualTextureVariant, bool bOverride_KuroSceneTranslucency, bool bKuroSceneTranslucency, bool bOverride_KuroDownsampleTranslucency, bool bKuroDownsampleTranslucency, bool bOverride_HasDataDistortionPass, bool bHasDataDistortionPass, bool bOverride_CastRayTracedShadows, bool bCastRayTracedShadows, bool bOverride_CastRasterShadowsInRaytracing, bool bCastRasterShadowsInRaytracing, bool bOverride_IsOnlyForSkeletalMesh, bool bIsOnlyForSkeletalMesh, bool bOverride_DisableCastDynamicShadows, bool bDisableCastDynamicShadows, bool bOverride_IsUsedWithStaticLighting, bool bIsUsedWithStaticLighting, bool bOverride_UsedWithSkeletalMesh, bool bUsedWithSkeletalMesh, bool bOverride_UsedWithBakedBoneMesh, bool bUsedWithBakedBoneMesh, bool bOverride_UsedWithExpandedTexcoordsSkeletalMesh, bool bUsedWithExpandedTexcoordsSkeletalMesh, bool bOverride_SupportsUBInstancing, bool bSupportsUBInstancing, bool bOverride_UsedWithParticleSprites, bool bUsedWithParticleSprites, bool bOverride_UsedWithBeamTrails, bool bUsedWithBeamTrails, bool bOverride_UsedWithMeshParticles, bool bUsedWithMeshParticles, bool bOverride_UsedWithNiagaraSprites, bool bUsedWithNiagaraSprites, bool bOverride_UsedWithNiagaraRibbons, bool bUsedWithNiagaraRibbons, bool bOverride_UsedWithNiagaraMeshParticles, bool bUsedWithNiagaraMeshParticles, bool bOverride_UsedWithGeometryCache, bool bUsedWithGeometryCache, bool bOverride_UsedWithMorphTargets, bool bUsedWithMorphTargets, bool bOverride_UsedWithSplineMeshes, bool bUsedWithSplineMeshes, bool bOverride_UsedWithInstancedStaticMeshes, bool bUsedWithInstancedStaticMeshes, bool bOverride_UsedWithGeometryCollections, bool bUsedWithGeometryCollections, bool bOverride_UsedWithWater, bool bUsedWithWater, bool bOverride_UsedWithHairStrands, bool bUsedWithHairStrands, bool bOverride_UsedWithLidarPointCloud, bool bUsedWithLidarPointCloud, bool bOverride_UsedWithVirtualHeightfieldMesh, bool bUsedWithVirtualHeightfieldMesh, bool bOverride_RemoveLocalVertexFactory, bool bRemoveLocalVertexFactory, bool bOverride_IsDisableWuYinQuLayer, bool bIsDisableWuYinQuLayer, bool bOverride_IsDisableWetLayer, bool bIsDisableWetLayer, bool bOverride_IsNoWaterForToon, bool bIsNoWaterForToon, bool bOverride_UsedWithShadowSVT, bool bUsedWithShadowSVT, bool bOverride_StencilRefValue, byte StencilRefValue, bool bOverride_IsMobileOutputVelocity, bool bIsMobileOutputVelocity, bool bOverride_KuroBlendWaterTranslucency, bool bKuroBlendWaterTranslucency, bool bOverride_IsBackFace, bool bIsBackFace, bool bOverride_UseMobileDistortion, bool bUseMobileDistortion, bool bOverride_IsLGUIMaterial, bool bIsLGUIMaterial, bool bOverride_UseNormalDither, bool bUseNormalDither, bool bOverride_NormalDitherScale, float NormalDitherScale, bool bOverride_WPORTCullDistScale, float WPORTCullDistScale, bool bOverride_ToonCustomStencilBit, byte ToonCustomStencilBit, bool bOverride_RenderInKuroVolumetricLightColorMask, bool bRenderInKuroVolumetricLightColorMask, bool bOverride_HasCustomWPOVariant, bool bHasCustomWPOVariant, bool bOverride_EffectSpaceWrite, bool bEffectSpaceWrite, bool bOverride_EffectSpaceRead, bool bEffectSpaceRead, bool bOverride_XRayStencilWrite, bool bXRayStencilWrite, bool bOverride_IsUsingCustomStencilTest, bool bIsUsingCustomStencilTest, bool bOverride_IsUsingCustomStencilDepthTest, bool bIsUsingCustomStencilDepthTest, bool bOverride_CustomStencilRefValue, byte CustomStencilRefValue, bool bOverride_UseFullPrecision, bool bUseFullPrecision, bool bOverride_FullPrecisionPlatform, TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionPlatform, bool bOverride_UseFullPrecisionParams, bool bUseFullPrecisionParams, bool bOverride_FullPrecisionParamsPlatform, TEnumAsByte<EUseFullPrecisionPlatform> FullPrecisionParamsPlatform)
		{
			this.bOverride_OpacityMaskClipValue = bOverride_OpacityMaskClipValue;
			this.bOverride_BlendMode = bOverride_BlendMode;
			this.bOverride_ShadingModel = bOverride_ShadingModel;
			this.bOverride_DitheredLODTransition = bOverride_DitheredLODTransition;
			this.bOverride_CastDynamicShadowAsMasked = bOverride_CastDynamicShadowAsMasked;
			this.bOverride_TwoSided = bOverride_TwoSided;
			this.bOverride_KuroWater = bOverride_KuroWater;
			this.bOverride_bSceneDissolveEnable = bOverride_bSceneDissolveEnable;
			this.bOverride_bSceneColorClearEnable = bOverride_bSceneColorClearEnable;
			this.TwoSided = TwoSided;
			this.KuroWater = KuroWater;
			this.bSceneDissolveEnable = bSceneDissolveEnable;
			this.bSceneColorClearEnable = bSceneColorClearEnable;
			this.bOverride_EnableSeparateTranslucency = bOverride_EnableSeparateTranslucency;
			this.bEnableSeparateTranslucency = bEnableSeparateTranslucency;
			this.bOverride_bMaskedRenderInPreDepth = bOverride_bMaskedRenderInPreDepth;
			this.bMaskedRenderInPreDepth = bMaskedRenderInPreDepth;
			this.bOverride_bMaskedRenderInPreDepth_PC = bOverride_bMaskedRenderInPreDepth_PC;
			this.bMaskedRenderInPreDepth_PC = bMaskedRenderInPreDepth_PC;
			this.bOverride_TessellationMode = bOverride_TessellationMode;
			this.TessellationMode = TessellationMode;
			this.bOverride_bEnableCrackFreeDisplacement = bOverride_bEnableCrackFreeDisplacement;
			this.bEnableCrackFreeDisplacement = bEnableCrackFreeDisplacement;
			this.bOverride_bEnableAdaptiveTessellation = bOverride_bEnableAdaptiveTessellation;
			this.bEnableAdaptiveTessellation = bEnableAdaptiveTessellation;
			this.bOverride_bDisableTessellationInShadowPass = bOverride_bDisableTessellationInShadowPass;
			this.bDisableTessellationInShadowPass = bDisableTessellationInShadowPass;
			this.bOverride_bRenderInCustomCapturePass = bOverride_bRenderInCustomCapturePass;
			this.bRenderInCustomCapturePass = bRenderInCustomCapturePass;
			this.bOverride_bUsedWithKuroCSInteractiveObject = bOverride_bUsedWithKuroCSInteractiveObject;
			this.bUsedWithKuroCSInteractiveObject = bUsedWithKuroCSInteractiveObject;
			this.bOverride_ShadingRate = bOverride_ShadingRate;
			this.ShadingRate = ShadingRate;
			this.bOverride_PipelineStateCreationHint = bOverride_PipelineStateCreationHint;
			this.PipelineStateCreationHint = PipelineStateCreationHint;
			this.DitheredLODTransition = DitheredLODTransition;
			this.bCastDynamicShadowAsMasked = bCastDynamicShadowAsMasked;
			this.BlendMode = BlendMode;
			this.ShadingModel = ShadingModel;
			this.OpacityMaskClipValue = OpacityMaskClipValue;
			this.bOverride_RenderQueue = bOverride_RenderQueue;
			this.RenderQueue = RenderQueue;
			this.bOverride_MaterialDesktopGameQualityShoulderRender = bOverride_MaterialDesktopGameQualityShoulderRender;
			this.MaterialDesktopGameQualityShoulderRender = MaterialDesktopGameQualityShoulderRender;
			this.bOverride_MaterialMobileGameQualityShoulderRender = bOverride_MaterialMobileGameQualityShoulderRender;
			this.MaterialMobileGameQualityShoulderRender = MaterialMobileGameQualityShoulderRender;
			this.bOverride_CustomAlphaTest = bOverride_CustomAlphaTest;
			this.bCustomAlphaTest = bCustomAlphaTest;
			this.bOverride_EnableBattle = bOverride_EnableBattle;
			this.bEnableBattle = bEnableBattle;
			this.bOverride_EnableBattleMask = bOverride_EnableBattleMask;
			this.bEnableBattleMask = bEnableBattleMask;
			this.bOverride_IsCharacterHairMat = bOverride_IsCharacterHairMat;
			this.bIsCharacterHairMat = bIsCharacterHairMat;
			this.bOverride_IsCharacterHETMat = bOverride_IsCharacterHETMat;
			this.bIsCharacterHETMat = bIsCharacterHETMat;
			this.bOverride_HETMatOnlyUsedPlayer = bOverride_HETMatOnlyUsedPlayer;
			this.bHETMatOnlyUsedPlayer = bHETMatOnlyUsedPlayer;
			this.bOverride_IsUsedWithWriteStencil = bOverride_IsUsedWithWriteStencil;
			this.bIsUsedWithWriteStencil = bIsUsedWithWriteStencil;
			this.bOverride_ExtendedHETDistance = bOverride_ExtendedHETDistance;
			this.ExtendedHETDistance = ExtendedHETDistance;
			this.bOverride_RenderTranslucentOpacity = bOverride_RenderTranslucentOpacity;
			this.RenderTranslucentOpacity = RenderTranslucentOpacity;
			this.bOverride_RenderToonFFT = bOverride_RenderToonFFT;
			this.bRenderToonFFT = bRenderToonFFT;
			this.bOverride_ForceSceneTranslucentOpacity = bOverride_ForceSceneTranslucentOpacity;
			this.ForceSceneTranslucentOpacity = ForceSceneTranslucentOpacity;
			this.bOverride_ForceFightTranslucentOpacity = bOverride_ForceFightTranslucentOpacity;
			this.ForceFightTranslucentOpacity = ForceFightTranslucentOpacity;
			this.bOverride_HasTranslucentPreDepth = bOverride_HasTranslucentPreDepth;
			this.bHasTranslucentPreDepth = bHasTranslucentPreDepth;
			this.bOverride_KuroTranslucencyWaterMasked = bOverride_KuroTranslucencyWaterMasked;
			this.bKuroTranslucencyWaterMasked = bKuroTranslucencyWaterMasked;
			this.bOverride_CompileRuntimeVirtualTextureVariant = bOverride_CompileRuntimeVirtualTextureVariant;
			this.bCompileRuntimeVirtualTextureVariant = bCompileRuntimeVirtualTextureVariant;
			this.bOverride_KuroSceneTranslucency = bOverride_KuroSceneTranslucency;
			this.bKuroSceneTranslucency = bKuroSceneTranslucency;
			this.bOverride_KuroDownsampleTranslucency = bOverride_KuroDownsampleTranslucency;
			this.bKuroDownsampleTranslucency = bKuroDownsampleTranslucency;
			this.bOverride_HasDataDistortionPass = bOverride_HasDataDistortionPass;
			this.bHasDataDistortionPass = bHasDataDistortionPass;
			this.bOverride_CastRayTracedShadows = bOverride_CastRayTracedShadows;
			this.bCastRayTracedShadows = bCastRayTracedShadows;
			this.bOverride_CastRasterShadowsInRaytracing = bOverride_CastRasterShadowsInRaytracing;
			this.bCastRasterShadowsInRaytracing = bCastRasterShadowsInRaytracing;
			this.bOverride_IsOnlyForSkeletalMesh = bOverride_IsOnlyForSkeletalMesh;
			this.bIsOnlyForSkeletalMesh = bIsOnlyForSkeletalMesh;
			this.bOverride_DisableCastDynamicShadows = bOverride_DisableCastDynamicShadows;
			this.bDisableCastDynamicShadows = bDisableCastDynamicShadows;
			this.bOverride_IsUsedWithStaticLighting = bOverride_IsUsedWithStaticLighting;
			this.bIsUsedWithStaticLighting = bIsUsedWithStaticLighting;
			this.bOverride_UsedWithSkeletalMesh = bOverride_UsedWithSkeletalMesh;
			this.bUsedWithSkeletalMesh = bUsedWithSkeletalMesh;
			this.bOverride_UsedWithBakedBoneMesh = bOverride_UsedWithBakedBoneMesh;
			this.bUsedWithBakedBoneMesh = bUsedWithBakedBoneMesh;
			this.bOverride_UsedWithExpandedTexcoordsSkeletalMesh = bOverride_UsedWithExpandedTexcoordsSkeletalMesh;
			this.bUsedWithExpandedTexcoordsSkeletalMesh = bUsedWithExpandedTexcoordsSkeletalMesh;
			this.bOverride_SupportsUBInstancing = bOverride_SupportsUBInstancing;
			this.bSupportsUBInstancing = bSupportsUBInstancing;
			this.bOverride_UsedWithParticleSprites = bOverride_UsedWithParticleSprites;
			this.bUsedWithParticleSprites = bUsedWithParticleSprites;
			this.bOverride_UsedWithBeamTrails = bOverride_UsedWithBeamTrails;
			this.bUsedWithBeamTrails = bUsedWithBeamTrails;
			this.bOverride_UsedWithMeshParticles = bOverride_UsedWithMeshParticles;
			this.bUsedWithMeshParticles = bUsedWithMeshParticles;
			this.bOverride_UsedWithNiagaraSprites = bOverride_UsedWithNiagaraSprites;
			this.bUsedWithNiagaraSprites = bUsedWithNiagaraSprites;
			this.bOverride_UsedWithNiagaraRibbons = bOverride_UsedWithNiagaraRibbons;
			this.bUsedWithNiagaraRibbons = bUsedWithNiagaraRibbons;
			this.bOverride_UsedWithNiagaraMeshParticles = bOverride_UsedWithNiagaraMeshParticles;
			this.bUsedWithNiagaraMeshParticles = bUsedWithNiagaraMeshParticles;
			this.bOverride_UsedWithGeometryCache = bOverride_UsedWithGeometryCache;
			this.bUsedWithGeometryCache = bUsedWithGeometryCache;
			this.bOverride_UsedWithMorphTargets = bOverride_UsedWithMorphTargets;
			this.bUsedWithMorphTargets = bUsedWithMorphTargets;
			this.bOverride_UsedWithSplineMeshes = bOverride_UsedWithSplineMeshes;
			this.bUsedWithSplineMeshes = bUsedWithSplineMeshes;
			this.bOverride_UsedWithInstancedStaticMeshes = bOverride_UsedWithInstancedStaticMeshes;
			this.bUsedWithInstancedStaticMeshes = bUsedWithInstancedStaticMeshes;
			this.bOverride_UsedWithGeometryCollections = bOverride_UsedWithGeometryCollections;
			this.bUsedWithGeometryCollections = bUsedWithGeometryCollections;
			this.bOverride_UsedWithWater = bOverride_UsedWithWater;
			this.bUsedWithWater = bUsedWithWater;
			this.bOverride_UsedWithHairStrands = bOverride_UsedWithHairStrands;
			this.bUsedWithHairStrands = bUsedWithHairStrands;
			this.bOverride_UsedWithLidarPointCloud = bOverride_UsedWithLidarPointCloud;
			this.bUsedWithLidarPointCloud = bUsedWithLidarPointCloud;
			this.bOverride_UsedWithVirtualHeightfieldMesh = bOverride_UsedWithVirtualHeightfieldMesh;
			this.bUsedWithVirtualHeightfieldMesh = bUsedWithVirtualHeightfieldMesh;
			this.bOverride_RemoveLocalVertexFactory = bOverride_RemoveLocalVertexFactory;
			this.bRemoveLocalVertexFactory = bRemoveLocalVertexFactory;
			this.bOverride_IsDisableWuYinQuLayer = bOverride_IsDisableWuYinQuLayer;
			this.bIsDisableWuYinQuLayer = bIsDisableWuYinQuLayer;
			this.bOverride_IsDisableWetLayer = bOverride_IsDisableWetLayer;
			this.bIsDisableWetLayer = bIsDisableWetLayer;
			this.bOverride_IsNoWaterForToon = bOverride_IsNoWaterForToon;
			this.bIsNoWaterForToon = bIsNoWaterForToon;
			this.bOverride_UsedWithShadowSVT = bOverride_UsedWithShadowSVT;
			this.bUsedWithShadowSVT = bUsedWithShadowSVT;
			this.bOverride_StencilRefValue = bOverride_StencilRefValue;
			this.StencilRefValue = StencilRefValue;
			this.bOverride_IsMobileOutputVelocity = bOverride_IsMobileOutputVelocity;
			this.bIsMobileOutputVelocity = bIsMobileOutputVelocity;
			this.bOverride_KuroBlendWaterTranslucency = bOverride_KuroBlendWaterTranslucency;
			this.bKuroBlendWaterTranslucency = bKuroBlendWaterTranslucency;
			this.bOverride_IsBackFace = bOverride_IsBackFace;
			this.bIsBackFace = bIsBackFace;
			this.bOverride_UseMobileDistortion = bOverride_UseMobileDistortion;
			this.bUseMobileDistortion = bUseMobileDistortion;
			this.bOverride_IsLGUIMaterial = bOverride_IsLGUIMaterial;
			this.bIsLGUIMaterial = bIsLGUIMaterial;
			this.bOverride_UseNormalDither = bOverride_UseNormalDither;
			this.bUseNormalDither = bUseNormalDither;
			this.bOverride_NormalDitherScale = bOverride_NormalDitherScale;
			this.NormalDitherScale = NormalDitherScale;
			this.bOverride_WPORTCullDistScale = bOverride_WPORTCullDistScale;
			this.WPORTCullDistScale = WPORTCullDistScale;
			this.bOverride_ToonCustomStencilBit = bOverride_ToonCustomStencilBit;
			this.ToonCustomStencilBit = ToonCustomStencilBit;
			this.bOverride_RenderInKuroVolumetricLightColorMask = bOverride_RenderInKuroVolumetricLightColorMask;
			this.bRenderInKuroVolumetricLightColorMask = bRenderInKuroVolumetricLightColorMask;
			this.bOverride_HasCustomWPOVariant = bOverride_HasCustomWPOVariant;
			this.bHasCustomWPOVariant = bHasCustomWPOVariant;
			this.bOverride_EffectSpaceWrite = bOverride_EffectSpaceWrite;
			this.bEffectSpaceWrite = bEffectSpaceWrite;
			this.bOverride_EffectSpaceRead = bOverride_EffectSpaceRead;
			this.bEffectSpaceRead = bEffectSpaceRead;
			this.bOverride_XRayStencilWrite = bOverride_XRayStencilWrite;
			this.bXRayStencilWrite = bXRayStencilWrite;
			this.bOverride_IsUsingCustomStencilTest = bOverride_IsUsingCustomStencilTest;
			this.bIsUsingCustomStencilTest = bIsUsingCustomStencilTest;
			this.bOverride_IsUsingCustomStencilDepthTest = bOverride_IsUsingCustomStencilDepthTest;
			this.bIsUsingCustomStencilDepthTest = bIsUsingCustomStencilDepthTest;
			this.bOverride_CustomStencilRefValue = bOverride_CustomStencilRefValue;
			this.CustomStencilRefValue = CustomStencilRefValue;
			this.bOverride_UseFullPrecision = bOverride_UseFullPrecision;
			this.bUseFullPrecision = bUseFullPrecision;
			this.bOverride_FullPrecisionPlatform = bOverride_FullPrecisionPlatform;
			this.FullPrecisionPlatform = FullPrecisionPlatform;
			this.bOverride_UseFullPrecisionParams = bOverride_UseFullPrecisionParams;
			this.bUseFullPrecisionParams = bUseFullPrecisionParams;
			this.bOverride_FullPrecisionParamsPlatform = bOverride_FullPrecisionParamsPlatform;
			this.FullPrecisionParamsPlatform = FullPrecisionParamsPlatform;
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x00123754 File Offset: 0x00121954
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialInstanceBasePropertyOverrides.StaticStruct();
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x00123760 File Offset: 0x00121960
		[NullableContext(2)]
		public FMaterialInstanceBasePropertyOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C83A RID: 51258 RVA: 0x0012376A File Offset: 0x0012196A
		public FMaterialInstanceBasePropertyOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x00123775 File Offset: 0x00121975
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialInstanceBasePropertyOverrides(Pointer, false, true);
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x0012377F File Offset: 0x0012197F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialInstanceBasePropertyOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x04006A7C RID: 27260
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialInstanceBasePropertyOverrides";

		// Token: 0x04006A7D RID: 27261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006A7E RID: 27262
		internal static int __PropertyOffset_bOverride_OpacityMaskClipValue;

		// Token: 0x04006A7F RID: 27263
		internal static byte __PropertyMask_bOverride_OpacityMaskClipValue;

		// Token: 0x04006A80 RID: 27264
		internal static int __PropertyOffset_bOverride_BlendMode;

		// Token: 0x04006A81 RID: 27265
		internal static byte __PropertyMask_bOverride_BlendMode;

		// Token: 0x04006A82 RID: 27266
		internal static int __PropertyOffset_bOverride_ShadingModel;

		// Token: 0x04006A83 RID: 27267
		internal static byte __PropertyMask_bOverride_ShadingModel;

		// Token: 0x04006A84 RID: 27268
		internal static int __PropertyOffset_bOverride_DitheredLODTransition;

		// Token: 0x04006A85 RID: 27269
		internal static byte __PropertyMask_bOverride_DitheredLODTransition;

		// Token: 0x04006A86 RID: 27270
		internal static int __PropertyOffset_bOverride_CastDynamicShadowAsMasked;

		// Token: 0x04006A87 RID: 27271
		internal static byte __PropertyMask_bOverride_CastDynamicShadowAsMasked;

		// Token: 0x04006A88 RID: 27272
		internal static int __PropertyOffset_bOverride_TwoSided;

		// Token: 0x04006A89 RID: 27273
		internal static byte __PropertyMask_bOverride_TwoSided;

		// Token: 0x04006A8A RID: 27274
		internal static int __PropertyOffset_bOverride_KuroWater;

		// Token: 0x04006A8B RID: 27275
		internal static byte __PropertyMask_bOverride_KuroWater;

		// Token: 0x04006A8C RID: 27276
		internal static int __PropertyOffset_bOverride_bSceneDissolveEnable;

		// Token: 0x04006A8D RID: 27277
		internal static byte __PropertyMask_bOverride_bSceneDissolveEnable;

		// Token: 0x04006A8E RID: 27278
		internal static int __PropertyOffset_bOverride_bSceneColorClearEnable;

		// Token: 0x04006A8F RID: 27279
		internal static byte __PropertyMask_bOverride_bSceneColorClearEnable;

		// Token: 0x04006A90 RID: 27280
		internal static int __PropertyOffset_TwoSided;

		// Token: 0x04006A91 RID: 27281
		internal static byte __PropertyMask_TwoSided;

		// Token: 0x04006A92 RID: 27282
		internal static int __PropertyOffset_KuroWater;

		// Token: 0x04006A93 RID: 27283
		internal static byte __PropertyMask_KuroWater;

		// Token: 0x04006A94 RID: 27284
		internal static int __PropertyOffset_bSceneDissolveEnable;

		// Token: 0x04006A95 RID: 27285
		internal static byte __PropertyMask_bSceneDissolveEnable;

		// Token: 0x04006A96 RID: 27286
		internal static int __PropertyOffset_bSceneColorClearEnable;

		// Token: 0x04006A97 RID: 27287
		internal static byte __PropertyMask_bSceneColorClearEnable;

		// Token: 0x04006A98 RID: 27288
		internal static int __PropertyOffset_bOverride_EnableSeparateTranslucency;

		// Token: 0x04006A99 RID: 27289
		internal static byte __PropertyMask_bOverride_EnableSeparateTranslucency;

		// Token: 0x04006A9A RID: 27290
		internal static int __PropertyOffset_bEnableSeparateTranslucency;

		// Token: 0x04006A9B RID: 27291
		internal static byte __PropertyMask_bEnableSeparateTranslucency;

		// Token: 0x04006A9C RID: 27292
		internal static int __PropertyOffset_bOverride_bMaskedRenderInPreDepth;

		// Token: 0x04006A9D RID: 27293
		internal static byte __PropertyMask_bOverride_bMaskedRenderInPreDepth;

		// Token: 0x04006A9E RID: 27294
		internal static int __PropertyOffset_bMaskedRenderInPreDepth;

		// Token: 0x04006A9F RID: 27295
		internal static byte __PropertyMask_bMaskedRenderInPreDepth;

		// Token: 0x04006AA0 RID: 27296
		internal static int __PropertyOffset_bOverride_bMaskedRenderInPreDepth_PC;

		// Token: 0x04006AA1 RID: 27297
		internal static byte __PropertyMask_bOverride_bMaskedRenderInPreDepth_PC;

		// Token: 0x04006AA2 RID: 27298
		internal static int __PropertyOffset_bMaskedRenderInPreDepth_PC;

		// Token: 0x04006AA3 RID: 27299
		internal static byte __PropertyMask_bMaskedRenderInPreDepth_PC;

		// Token: 0x04006AA4 RID: 27300
		internal static int __PropertyOffset_bOverride_TessellationMode;

		// Token: 0x04006AA5 RID: 27301
		internal static byte __PropertyMask_bOverride_TessellationMode;

		// Token: 0x04006AA6 RID: 27302
		internal static int __PropertyOffset_TessellationMode;

		// Token: 0x04006AA7 RID: 27303
		internal static int __PropertyOffset_bOverride_bEnableCrackFreeDisplacement;

		// Token: 0x04006AA8 RID: 27304
		internal static byte __PropertyMask_bOverride_bEnableCrackFreeDisplacement;

		// Token: 0x04006AA9 RID: 27305
		internal static int __PropertyOffset_bEnableCrackFreeDisplacement;

		// Token: 0x04006AAA RID: 27306
		internal static byte __PropertyMask_bEnableCrackFreeDisplacement;

		// Token: 0x04006AAB RID: 27307
		internal static int __PropertyOffset_bOverride_bEnableAdaptiveTessellation;

		// Token: 0x04006AAC RID: 27308
		internal static byte __PropertyMask_bOverride_bEnableAdaptiveTessellation;

		// Token: 0x04006AAD RID: 27309
		internal static int __PropertyOffset_bEnableAdaptiveTessellation;

		// Token: 0x04006AAE RID: 27310
		internal static byte __PropertyMask_bEnableAdaptiveTessellation;

		// Token: 0x04006AAF RID: 27311
		internal static int __PropertyOffset_bOverride_bDisableTessellationInShadowPass;

		// Token: 0x04006AB0 RID: 27312
		internal static byte __PropertyMask_bOverride_bDisableTessellationInShadowPass;

		// Token: 0x04006AB1 RID: 27313
		internal static int __PropertyOffset_bDisableTessellationInShadowPass;

		// Token: 0x04006AB2 RID: 27314
		internal static byte __PropertyMask_bDisableTessellationInShadowPass;

		// Token: 0x04006AB3 RID: 27315
		internal static int __PropertyOffset_bOverride_bRenderInCustomCapturePass;

		// Token: 0x04006AB4 RID: 27316
		internal static byte __PropertyMask_bOverride_bRenderInCustomCapturePass;

		// Token: 0x04006AB5 RID: 27317
		internal static int __PropertyOffset_bRenderInCustomCapturePass;

		// Token: 0x04006AB6 RID: 27318
		internal static byte __PropertyMask_bRenderInCustomCapturePass;

		// Token: 0x04006AB7 RID: 27319
		internal static int __PropertyOffset_bOverride_bUsedWithKuroCSInteractiveObject;

		// Token: 0x04006AB8 RID: 27320
		internal static byte __PropertyMask_bOverride_bUsedWithKuroCSInteractiveObject;

		// Token: 0x04006AB9 RID: 27321
		internal static int __PropertyOffset_bUsedWithKuroCSInteractiveObject;

		// Token: 0x04006ABA RID: 27322
		internal static byte __PropertyMask_bUsedWithKuroCSInteractiveObject;

		// Token: 0x04006ABB RID: 27323
		internal static int __PropertyOffset_bOverride_ShadingRate;

		// Token: 0x04006ABC RID: 27324
		internal static int __PropertyOffset_ShadingRate;

		// Token: 0x04006ABD RID: 27325
		internal static int __PropertyOffset_bOverride_PipelineStateCreationHint;

		// Token: 0x04006ABE RID: 27326
		internal static byte __PropertyMask_bOverride_PipelineStateCreationHint;

		// Token: 0x04006ABF RID: 27327
		internal static int __PropertyOffset_PipelineStateCreationHint;

		// Token: 0x04006AC0 RID: 27328
		internal static int __PropertyOffset_DitheredLODTransition;

		// Token: 0x04006AC1 RID: 27329
		internal static byte __PropertyMask_DitheredLODTransition;

		// Token: 0x04006AC2 RID: 27330
		internal static int __PropertyOffset_bCastDynamicShadowAsMasked;

		// Token: 0x04006AC3 RID: 27331
		internal static byte __PropertyMask_bCastDynamicShadowAsMasked;

		// Token: 0x04006AC4 RID: 27332
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x04006AC5 RID: 27333
		internal static int __PropertyOffset_ShadingModel;

		// Token: 0x04006AC6 RID: 27334
		internal static int __PropertyOffset_OpacityMaskClipValue;

		// Token: 0x04006AC7 RID: 27335
		internal static int __PropertyOffset_bOverride_RenderQueue;

		// Token: 0x04006AC8 RID: 27336
		internal static byte __PropertyMask_bOverride_RenderQueue;

		// Token: 0x04006AC9 RID: 27337
		internal static int __PropertyOffset_RenderQueue;

		// Token: 0x04006ACA RID: 27338
		internal static int __PropertyOffset_bOverride_MaterialDesktopGameQualityShoulderRender;

		// Token: 0x04006ACB RID: 27339
		internal static int __PropertyOffset_MaterialDesktopGameQualityShoulderRender;

		// Token: 0x04006ACC RID: 27340
		internal static int __PropertyOffset_bOverride_MaterialMobileGameQualityShoulderRender;

		// Token: 0x04006ACD RID: 27341
		internal static int __PropertyOffset_MaterialMobileGameQualityShoulderRender;

		// Token: 0x04006ACE RID: 27342
		internal static int __PropertyOffset_bOverride_CustomAlphaTest;

		// Token: 0x04006ACF RID: 27343
		internal static byte __PropertyMask_bOverride_CustomAlphaTest;

		// Token: 0x04006AD0 RID: 27344
		internal static int __PropertyOffset_bCustomAlphaTest;

		// Token: 0x04006AD1 RID: 27345
		internal static byte __PropertyMask_bCustomAlphaTest;

		// Token: 0x04006AD2 RID: 27346
		internal static int __PropertyOffset_bOverride_EnableBattle;

		// Token: 0x04006AD3 RID: 27347
		internal static byte __PropertyMask_bOverride_EnableBattle;

		// Token: 0x04006AD4 RID: 27348
		internal static int __PropertyOffset_bEnableBattle;

		// Token: 0x04006AD5 RID: 27349
		internal static byte __PropertyMask_bEnableBattle;

		// Token: 0x04006AD6 RID: 27350
		internal static int __PropertyOffset_bOverride_EnableBattleMask;

		// Token: 0x04006AD7 RID: 27351
		internal static byte __PropertyMask_bOverride_EnableBattleMask;

		// Token: 0x04006AD8 RID: 27352
		internal static int __PropertyOffset_bEnableBattleMask;

		// Token: 0x04006AD9 RID: 27353
		internal static byte __PropertyMask_bEnableBattleMask;

		// Token: 0x04006ADA RID: 27354
		internal static int __PropertyOffset_bOverride_IsCharacterHairMat;

		// Token: 0x04006ADB RID: 27355
		internal static byte __PropertyMask_bOverride_IsCharacterHairMat;

		// Token: 0x04006ADC RID: 27356
		internal static int __PropertyOffset_bIsCharacterHairMat;

		// Token: 0x04006ADD RID: 27357
		internal static byte __PropertyMask_bIsCharacterHairMat;

		// Token: 0x04006ADE RID: 27358
		internal static int __PropertyOffset_bOverride_IsCharacterHETMat;

		// Token: 0x04006ADF RID: 27359
		internal static byte __PropertyMask_bOverride_IsCharacterHETMat;

		// Token: 0x04006AE0 RID: 27360
		internal static int __PropertyOffset_bIsCharacterHETMat;

		// Token: 0x04006AE1 RID: 27361
		internal static byte __PropertyMask_bIsCharacterHETMat;

		// Token: 0x04006AE2 RID: 27362
		internal static int __PropertyOffset_bOverride_HETMatOnlyUsedPlayer;

		// Token: 0x04006AE3 RID: 27363
		internal static byte __PropertyMask_bOverride_HETMatOnlyUsedPlayer;

		// Token: 0x04006AE4 RID: 27364
		internal static int __PropertyOffset_bHETMatOnlyUsedPlayer;

		// Token: 0x04006AE5 RID: 27365
		internal static int __PropertyOffset_bOverride_IsUsedWithWriteStencil;

		// Token: 0x04006AE6 RID: 27366
		internal static byte __PropertyMask_bOverride_IsUsedWithWriteStencil;

		// Token: 0x04006AE7 RID: 27367
		internal static int __PropertyOffset_bIsUsedWithWriteStencil;

		// Token: 0x04006AE8 RID: 27368
		internal static int __PropertyOffset_bOverride_ExtendedHETDistance;

		// Token: 0x04006AE9 RID: 27369
		internal static byte __PropertyMask_bOverride_ExtendedHETDistance;

		// Token: 0x04006AEA RID: 27370
		internal static int __PropertyOffset_ExtendedHETDistance;

		// Token: 0x04006AEB RID: 27371
		internal static int __PropertyOffset_bOverride_RenderTranslucentOpacity;

		// Token: 0x04006AEC RID: 27372
		internal static byte __PropertyMask_bOverride_RenderTranslucentOpacity;

		// Token: 0x04006AED RID: 27373
		internal static int __PropertyOffset_RenderTranslucentOpacity;

		// Token: 0x04006AEE RID: 27374
		internal static int __PropertyOffset_bOverride_RenderToonFFT;

		// Token: 0x04006AEF RID: 27375
		internal static byte __PropertyMask_bOverride_RenderToonFFT;

		// Token: 0x04006AF0 RID: 27376
		internal static int __PropertyOffset_bRenderToonFFT;

		// Token: 0x04006AF1 RID: 27377
		internal static int __PropertyOffset_bOverride_ForceSceneTranslucentOpacity;

		// Token: 0x04006AF2 RID: 27378
		internal static byte __PropertyMask_bOverride_ForceSceneTranslucentOpacity;

		// Token: 0x04006AF3 RID: 27379
		internal static int __PropertyOffset_ForceSceneTranslucentOpacity;

		// Token: 0x04006AF4 RID: 27380
		internal static int __PropertyOffset_bOverride_ForceFightTranslucentOpacity;

		// Token: 0x04006AF5 RID: 27381
		internal static byte __PropertyMask_bOverride_ForceFightTranslucentOpacity;

		// Token: 0x04006AF6 RID: 27382
		internal static int __PropertyOffset_ForceFightTranslucentOpacity;

		// Token: 0x04006AF7 RID: 27383
		internal static int __PropertyOffset_bOverride_HasTranslucentPreDepth;

		// Token: 0x04006AF8 RID: 27384
		internal static byte __PropertyMask_bOverride_HasTranslucentPreDepth;

		// Token: 0x04006AF9 RID: 27385
		internal static int __PropertyOffset_bHasTranslucentPreDepth;

		// Token: 0x04006AFA RID: 27386
		internal static byte __PropertyMask_bHasTranslucentPreDepth;

		// Token: 0x04006AFB RID: 27387
		internal static int __PropertyOffset_bOverride_KuroTranslucencyWaterMasked;

		// Token: 0x04006AFC RID: 27388
		internal static byte __PropertyMask_bOverride_KuroTranslucencyWaterMasked;

		// Token: 0x04006AFD RID: 27389
		internal static int __PropertyOffset_bKuroTranslucencyWaterMasked;

		// Token: 0x04006AFE RID: 27390
		internal static byte __PropertyMask_bKuroTranslucencyWaterMasked;

		// Token: 0x04006AFF RID: 27391
		internal static int __PropertyOffset_bOverride_CompileRuntimeVirtualTextureVariant;

		// Token: 0x04006B00 RID: 27392
		internal static byte __PropertyMask_bOverride_CompileRuntimeVirtualTextureVariant;

		// Token: 0x04006B01 RID: 27393
		internal static int __PropertyOffset_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04006B02 RID: 27394
		internal static byte __PropertyMask_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04006B03 RID: 27395
		internal static int __PropertyOffset_bOverride_KuroSceneTranslucency;

		// Token: 0x04006B04 RID: 27396
		internal static byte __PropertyMask_bOverride_KuroSceneTranslucency;

		// Token: 0x04006B05 RID: 27397
		internal static int __PropertyOffset_bKuroSceneTranslucency;

		// Token: 0x04006B06 RID: 27398
		internal static byte __PropertyMask_bKuroSceneTranslucency;

		// Token: 0x04006B07 RID: 27399
		internal static int __PropertyOffset_bOverride_KuroDownsampleTranslucency;

		// Token: 0x04006B08 RID: 27400
		internal static byte __PropertyMask_bOverride_KuroDownsampleTranslucency;

		// Token: 0x04006B09 RID: 27401
		internal static int __PropertyOffset_bKuroDownsampleTranslucency;

		// Token: 0x04006B0A RID: 27402
		internal static byte __PropertyMask_bKuroDownsampleTranslucency;

		// Token: 0x04006B0B RID: 27403
		internal static int __PropertyOffset_bOverride_HasDataDistortionPass;

		// Token: 0x04006B0C RID: 27404
		internal static byte __PropertyMask_bOverride_HasDataDistortionPass;

		// Token: 0x04006B0D RID: 27405
		internal static int __PropertyOffset_bHasDataDistortionPass;

		// Token: 0x04006B0E RID: 27406
		internal static byte __PropertyMask_bHasDataDistortionPass;

		// Token: 0x04006B0F RID: 27407
		internal static int __PropertyOffset_bOverride_CastRayTracedShadows;

		// Token: 0x04006B10 RID: 27408
		internal static byte __PropertyMask_bOverride_CastRayTracedShadows;

		// Token: 0x04006B11 RID: 27409
		internal static int __PropertyOffset_bCastRayTracedShadows;

		// Token: 0x04006B12 RID: 27410
		internal static byte __PropertyMask_bCastRayTracedShadows;

		// Token: 0x04006B13 RID: 27411
		internal static int __PropertyOffset_bOverride_CastRasterShadowsInRaytracing;

		// Token: 0x04006B14 RID: 27412
		internal static byte __PropertyMask_bOverride_CastRasterShadowsInRaytracing;

		// Token: 0x04006B15 RID: 27413
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04006B16 RID: 27414
		internal static byte __PropertyMask_bCastRasterShadowsInRaytracing;

		// Token: 0x04006B17 RID: 27415
		internal static int __PropertyOffset_bOverride_IsOnlyForSkeletalMesh;

		// Token: 0x04006B18 RID: 27416
		internal static byte __PropertyMask_bOverride_IsOnlyForSkeletalMesh;

		// Token: 0x04006B19 RID: 27417
		internal static int __PropertyOffset_bIsOnlyForSkeletalMesh;

		// Token: 0x04006B1A RID: 27418
		internal static byte __PropertyMask_bIsOnlyForSkeletalMesh;

		// Token: 0x04006B1B RID: 27419
		internal static int __PropertyOffset_bOverride_DisableCastDynamicShadows;

		// Token: 0x04006B1C RID: 27420
		internal static byte __PropertyMask_bOverride_DisableCastDynamicShadows;

		// Token: 0x04006B1D RID: 27421
		internal static int __PropertyOffset_bDisableCastDynamicShadows;

		// Token: 0x04006B1E RID: 27422
		internal static byte __PropertyMask_bDisableCastDynamicShadows;

		// Token: 0x04006B1F RID: 27423
		internal static int __PropertyOffset_bOverride_IsUsedWithStaticLighting;

		// Token: 0x04006B20 RID: 27424
		internal static byte __PropertyMask_bOverride_IsUsedWithStaticLighting;

		// Token: 0x04006B21 RID: 27425
		internal static int __PropertyOffset_bIsUsedWithStaticLighting;

		// Token: 0x04006B22 RID: 27426
		internal static byte __PropertyMask_bIsUsedWithStaticLighting;

		// Token: 0x04006B23 RID: 27427
		internal static int __PropertyOffset_bOverride_UsedWithSkeletalMesh;

		// Token: 0x04006B24 RID: 27428
		internal static byte __PropertyMask_bOverride_UsedWithSkeletalMesh;

		// Token: 0x04006B25 RID: 27429
		internal static int __PropertyOffset_bUsedWithSkeletalMesh;

		// Token: 0x04006B26 RID: 27430
		internal static byte __PropertyMask_bUsedWithSkeletalMesh;

		// Token: 0x04006B27 RID: 27431
		internal static int __PropertyOffset_bOverride_UsedWithBakedBoneMesh;

		// Token: 0x04006B28 RID: 27432
		internal static byte __PropertyMask_bOverride_UsedWithBakedBoneMesh;

		// Token: 0x04006B29 RID: 27433
		internal static int __PropertyOffset_bUsedWithBakedBoneMesh;

		// Token: 0x04006B2A RID: 27434
		internal static byte __PropertyMask_bUsedWithBakedBoneMesh;

		// Token: 0x04006B2B RID: 27435
		internal static int __PropertyOffset_bOverride_UsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006B2C RID: 27436
		internal static byte __PropertyMask_bOverride_UsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006B2D RID: 27437
		internal static int __PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006B2E RID: 27438
		internal static byte __PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04006B2F RID: 27439
		internal static int __PropertyOffset_bOverride_SupportsUBInstancing;

		// Token: 0x04006B30 RID: 27440
		internal static byte __PropertyMask_bOverride_SupportsUBInstancing;

		// Token: 0x04006B31 RID: 27441
		internal static int __PropertyOffset_bSupportsUBInstancing;

		// Token: 0x04006B32 RID: 27442
		internal static byte __PropertyMask_bSupportsUBInstancing;

		// Token: 0x04006B33 RID: 27443
		internal static int __PropertyOffset_bOverride_UsedWithParticleSprites;

		// Token: 0x04006B34 RID: 27444
		internal static byte __PropertyMask_bOverride_UsedWithParticleSprites;

		// Token: 0x04006B35 RID: 27445
		internal static int __PropertyOffset_bUsedWithParticleSprites;

		// Token: 0x04006B36 RID: 27446
		internal static byte __PropertyMask_bUsedWithParticleSprites;

		// Token: 0x04006B37 RID: 27447
		internal static int __PropertyOffset_bOverride_UsedWithBeamTrails;

		// Token: 0x04006B38 RID: 27448
		internal static byte __PropertyMask_bOverride_UsedWithBeamTrails;

		// Token: 0x04006B39 RID: 27449
		internal static int __PropertyOffset_bUsedWithBeamTrails;

		// Token: 0x04006B3A RID: 27450
		internal static byte __PropertyMask_bUsedWithBeamTrails;

		// Token: 0x04006B3B RID: 27451
		internal static int __PropertyOffset_bOverride_UsedWithMeshParticles;

		// Token: 0x04006B3C RID: 27452
		internal static byte __PropertyMask_bOverride_UsedWithMeshParticles;

		// Token: 0x04006B3D RID: 27453
		internal static int __PropertyOffset_bUsedWithMeshParticles;

		// Token: 0x04006B3E RID: 27454
		internal static byte __PropertyMask_bUsedWithMeshParticles;

		// Token: 0x04006B3F RID: 27455
		internal static int __PropertyOffset_bOverride_UsedWithNiagaraSprites;

		// Token: 0x04006B40 RID: 27456
		internal static byte __PropertyMask_bOverride_UsedWithNiagaraSprites;

		// Token: 0x04006B41 RID: 27457
		internal static int __PropertyOffset_bUsedWithNiagaraSprites;

		// Token: 0x04006B42 RID: 27458
		internal static byte __PropertyMask_bUsedWithNiagaraSprites;

		// Token: 0x04006B43 RID: 27459
		internal static int __PropertyOffset_bOverride_UsedWithNiagaraRibbons;

		// Token: 0x04006B44 RID: 27460
		internal static byte __PropertyMask_bOverride_UsedWithNiagaraRibbons;

		// Token: 0x04006B45 RID: 27461
		internal static int __PropertyOffset_bUsedWithNiagaraRibbons;

		// Token: 0x04006B46 RID: 27462
		internal static byte __PropertyMask_bUsedWithNiagaraRibbons;

		// Token: 0x04006B47 RID: 27463
		internal static int __PropertyOffset_bOverride_UsedWithNiagaraMeshParticles;

		// Token: 0x04006B48 RID: 27464
		internal static byte __PropertyMask_bOverride_UsedWithNiagaraMeshParticles;

		// Token: 0x04006B49 RID: 27465
		internal static int __PropertyOffset_bUsedWithNiagaraMeshParticles;

		// Token: 0x04006B4A RID: 27466
		internal static byte __PropertyMask_bUsedWithNiagaraMeshParticles;

		// Token: 0x04006B4B RID: 27467
		internal static int __PropertyOffset_bOverride_UsedWithGeometryCache;

		// Token: 0x04006B4C RID: 27468
		internal static byte __PropertyMask_bOverride_UsedWithGeometryCache;

		// Token: 0x04006B4D RID: 27469
		internal static int __PropertyOffset_bUsedWithGeometryCache;

		// Token: 0x04006B4E RID: 27470
		internal static byte __PropertyMask_bUsedWithGeometryCache;

		// Token: 0x04006B4F RID: 27471
		internal static int __PropertyOffset_bOverride_UsedWithMorphTargets;

		// Token: 0x04006B50 RID: 27472
		internal static byte __PropertyMask_bOverride_UsedWithMorphTargets;

		// Token: 0x04006B51 RID: 27473
		internal static int __PropertyOffset_bUsedWithMorphTargets;

		// Token: 0x04006B52 RID: 27474
		internal static byte __PropertyMask_bUsedWithMorphTargets;

		// Token: 0x04006B53 RID: 27475
		internal static int __PropertyOffset_bOverride_UsedWithSplineMeshes;

		// Token: 0x04006B54 RID: 27476
		internal static byte __PropertyMask_bOverride_UsedWithSplineMeshes;

		// Token: 0x04006B55 RID: 27477
		internal static int __PropertyOffset_bUsedWithSplineMeshes;

		// Token: 0x04006B56 RID: 27478
		internal static byte __PropertyMask_bUsedWithSplineMeshes;

		// Token: 0x04006B57 RID: 27479
		internal static int __PropertyOffset_bOverride_UsedWithInstancedStaticMeshes;

		// Token: 0x04006B58 RID: 27480
		internal static byte __PropertyMask_bOverride_UsedWithInstancedStaticMeshes;

		// Token: 0x04006B59 RID: 27481
		internal static int __PropertyOffset_bUsedWithInstancedStaticMeshes;

		// Token: 0x04006B5A RID: 27482
		internal static byte __PropertyMask_bUsedWithInstancedStaticMeshes;

		// Token: 0x04006B5B RID: 27483
		internal static int __PropertyOffset_bOverride_UsedWithGeometryCollections;

		// Token: 0x04006B5C RID: 27484
		internal static byte __PropertyMask_bOverride_UsedWithGeometryCollections;

		// Token: 0x04006B5D RID: 27485
		internal static int __PropertyOffset_bUsedWithGeometryCollections;

		// Token: 0x04006B5E RID: 27486
		internal static byte __PropertyMask_bUsedWithGeometryCollections;

		// Token: 0x04006B5F RID: 27487
		internal static int __PropertyOffset_bOverride_UsedWithWater;

		// Token: 0x04006B60 RID: 27488
		internal static byte __PropertyMask_bOverride_UsedWithWater;

		// Token: 0x04006B61 RID: 27489
		internal static int __PropertyOffset_bUsedWithWater;

		// Token: 0x04006B62 RID: 27490
		internal static byte __PropertyMask_bUsedWithWater;

		// Token: 0x04006B63 RID: 27491
		internal static int __PropertyOffset_bOverride_UsedWithHairStrands;

		// Token: 0x04006B64 RID: 27492
		internal static byte __PropertyMask_bOverride_UsedWithHairStrands;

		// Token: 0x04006B65 RID: 27493
		internal static int __PropertyOffset_bUsedWithHairStrands;

		// Token: 0x04006B66 RID: 27494
		internal static byte __PropertyMask_bUsedWithHairStrands;

		// Token: 0x04006B67 RID: 27495
		internal static int __PropertyOffset_bOverride_UsedWithLidarPointCloud;

		// Token: 0x04006B68 RID: 27496
		internal static byte __PropertyMask_bOverride_UsedWithLidarPointCloud;

		// Token: 0x04006B69 RID: 27497
		internal static int __PropertyOffset_bUsedWithLidarPointCloud;

		// Token: 0x04006B6A RID: 27498
		internal static byte __PropertyMask_bUsedWithLidarPointCloud;

		// Token: 0x04006B6B RID: 27499
		internal static int __PropertyOffset_bOverride_UsedWithVirtualHeightfieldMesh;

		// Token: 0x04006B6C RID: 27500
		internal static byte __PropertyMask_bOverride_UsedWithVirtualHeightfieldMesh;

		// Token: 0x04006B6D RID: 27501
		internal static int __PropertyOffset_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x04006B6E RID: 27502
		internal static byte __PropertyMask_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x04006B6F RID: 27503
		internal static int __PropertyOffset_bOverride_RemoveLocalVertexFactory;

		// Token: 0x04006B70 RID: 27504
		internal static byte __PropertyMask_bOverride_RemoveLocalVertexFactory;

		// Token: 0x04006B71 RID: 27505
		internal static int __PropertyOffset_bRemoveLocalVertexFactory;

		// Token: 0x04006B72 RID: 27506
		internal static byte __PropertyMask_bRemoveLocalVertexFactory;

		// Token: 0x04006B73 RID: 27507
		internal static int __PropertyOffset_bOverride_IsDisableWuYinQuLayer;

		// Token: 0x04006B74 RID: 27508
		internal static byte __PropertyMask_bOverride_IsDisableWuYinQuLayer;

		// Token: 0x04006B75 RID: 27509
		internal static int __PropertyOffset_bIsDisableWuYinQuLayer;

		// Token: 0x04006B76 RID: 27510
		internal static byte __PropertyMask_bIsDisableWuYinQuLayer;

		// Token: 0x04006B77 RID: 27511
		internal static int __PropertyOffset_bOverride_IsDisableWetLayer;

		// Token: 0x04006B78 RID: 27512
		internal static byte __PropertyMask_bOverride_IsDisableWetLayer;

		// Token: 0x04006B79 RID: 27513
		internal static int __PropertyOffset_bIsDisableWetLayer;

		// Token: 0x04006B7A RID: 27514
		internal static byte __PropertyMask_bIsDisableWetLayer;

		// Token: 0x04006B7B RID: 27515
		internal static int __PropertyOffset_bOverride_IsNoWaterForToon;

		// Token: 0x04006B7C RID: 27516
		internal static byte __PropertyMask_bOverride_IsNoWaterForToon;

		// Token: 0x04006B7D RID: 27517
		internal static int __PropertyOffset_bIsNoWaterForToon;

		// Token: 0x04006B7E RID: 27518
		internal static byte __PropertyMask_bIsNoWaterForToon;

		// Token: 0x04006B7F RID: 27519
		internal static int __PropertyOffset_bOverride_UsedWithShadowSVT;

		// Token: 0x04006B80 RID: 27520
		internal static byte __PropertyMask_bOverride_UsedWithShadowSVT;

		// Token: 0x04006B81 RID: 27521
		internal static int __PropertyOffset_bUsedWithShadowSVT;

		// Token: 0x04006B82 RID: 27522
		internal static byte __PropertyMask_bUsedWithShadowSVT;

		// Token: 0x04006B83 RID: 27523
		internal static int __PropertyOffset_bOverride_StencilRefValue;

		// Token: 0x04006B84 RID: 27524
		internal static byte __PropertyMask_bOverride_StencilRefValue;

		// Token: 0x04006B85 RID: 27525
		internal static int __PropertyOffset_StencilRefValue;

		// Token: 0x04006B86 RID: 27526
		internal static int __PropertyOffset_bOverride_IsMobileOutputVelocity;

		// Token: 0x04006B87 RID: 27527
		internal static byte __PropertyMask_bOverride_IsMobileOutputVelocity;

		// Token: 0x04006B88 RID: 27528
		internal static int __PropertyOffset_bIsMobileOutputVelocity;

		// Token: 0x04006B89 RID: 27529
		internal static byte __PropertyMask_bIsMobileOutputVelocity;

		// Token: 0x04006B8A RID: 27530
		internal static int __PropertyOffset_bOverride_KuroBlendWaterTranslucency;

		// Token: 0x04006B8B RID: 27531
		internal static byte __PropertyMask_bOverride_KuroBlendWaterTranslucency;

		// Token: 0x04006B8C RID: 27532
		internal static int __PropertyOffset_bKuroBlendWaterTranslucency;

		// Token: 0x04006B8D RID: 27533
		internal static byte __PropertyMask_bKuroBlendWaterTranslucency;

		// Token: 0x04006B8E RID: 27534
		internal static int __PropertyOffset_bOverride_IsBackFace;

		// Token: 0x04006B8F RID: 27535
		internal static byte __PropertyMask_bOverride_IsBackFace;

		// Token: 0x04006B90 RID: 27536
		internal static int __PropertyOffset_bIsBackFace;

		// Token: 0x04006B91 RID: 27537
		internal static byte __PropertyMask_bIsBackFace;

		// Token: 0x04006B92 RID: 27538
		internal static int __PropertyOffset_bOverride_UseMobileDistortion;

		// Token: 0x04006B93 RID: 27539
		internal static byte __PropertyMask_bOverride_UseMobileDistortion;

		// Token: 0x04006B94 RID: 27540
		internal static int __PropertyOffset_bUseMobileDistortion;

		// Token: 0x04006B95 RID: 27541
		internal static byte __PropertyMask_bUseMobileDistortion;

		// Token: 0x04006B96 RID: 27542
		internal static int __PropertyOffset_bOverride_IsLGUIMaterial;

		// Token: 0x04006B97 RID: 27543
		internal static byte __PropertyMask_bOverride_IsLGUIMaterial;

		// Token: 0x04006B98 RID: 27544
		internal static int __PropertyOffset_bIsLGUIMaterial;

		// Token: 0x04006B99 RID: 27545
		internal static byte __PropertyMask_bIsLGUIMaterial;

		// Token: 0x04006B9A RID: 27546
		internal static int __PropertyOffset_bOverride_UseNormalDither;

		// Token: 0x04006B9B RID: 27547
		internal static byte __PropertyMask_bOverride_UseNormalDither;

		// Token: 0x04006B9C RID: 27548
		internal static int __PropertyOffset_bUseNormalDither;

		// Token: 0x04006B9D RID: 27549
		internal static byte __PropertyMask_bUseNormalDither;

		// Token: 0x04006B9E RID: 27550
		internal static int __PropertyOffset_bOverride_NormalDitherScale;

		// Token: 0x04006B9F RID: 27551
		internal static byte __PropertyMask_bOverride_NormalDitherScale;

		// Token: 0x04006BA0 RID: 27552
		internal static int __PropertyOffset_NormalDitherScale;

		// Token: 0x04006BA1 RID: 27553
		internal static int __PropertyOffset_bOverride_WPORTCullDistScale;

		// Token: 0x04006BA2 RID: 27554
		internal static byte __PropertyMask_bOverride_WPORTCullDistScale;

		// Token: 0x04006BA3 RID: 27555
		internal static int __PropertyOffset_WPORTCullDistScale;

		// Token: 0x04006BA4 RID: 27556
		internal static int __PropertyOffset_bOverride_ToonCustomStencilBit;

		// Token: 0x04006BA5 RID: 27557
		internal static byte __PropertyMask_bOverride_ToonCustomStencilBit;

		// Token: 0x04006BA6 RID: 27558
		internal static int __PropertyOffset_ToonCustomStencilBit;

		// Token: 0x04006BA7 RID: 27559
		internal static int __PropertyOffset_bOverride_RenderInKuroVolumetricLightColorMask;

		// Token: 0x04006BA8 RID: 27560
		internal static byte __PropertyMask_bOverride_RenderInKuroVolumetricLightColorMask;

		// Token: 0x04006BA9 RID: 27561
		internal static int __PropertyOffset_bRenderInKuroVolumetricLightColorMask;

		// Token: 0x04006BAA RID: 27562
		internal static int __PropertyOffset_bOverride_HasCustomWPOVariant;

		// Token: 0x04006BAB RID: 27563
		internal static byte __PropertyMask_bOverride_HasCustomWPOVariant;

		// Token: 0x04006BAC RID: 27564
		internal static int __PropertyOffset_bHasCustomWPOVariant;

		// Token: 0x04006BAD RID: 27565
		internal static int __PropertyOffset_bOverride_EffectSpaceWrite;

		// Token: 0x04006BAE RID: 27566
		internal static byte __PropertyMask_bOverride_EffectSpaceWrite;

		// Token: 0x04006BAF RID: 27567
		internal static int __PropertyOffset_bEffectSpaceWrite;

		// Token: 0x04006BB0 RID: 27568
		internal static int __PropertyOffset_bOverride_EffectSpaceRead;

		// Token: 0x04006BB1 RID: 27569
		internal static byte __PropertyMask_bOverride_EffectSpaceRead;

		// Token: 0x04006BB2 RID: 27570
		internal static int __PropertyOffset_bEffectSpaceRead;

		// Token: 0x04006BB3 RID: 27571
		internal static int __PropertyOffset_bOverride_XRayStencilWrite;

		// Token: 0x04006BB4 RID: 27572
		internal static byte __PropertyMask_bOverride_XRayStencilWrite;

		// Token: 0x04006BB5 RID: 27573
		internal static int __PropertyOffset_bXRayStencilWrite;

		// Token: 0x04006BB6 RID: 27574
		internal static int __PropertyOffset_bOverride_IsUsingCustomStencilTest;

		// Token: 0x04006BB7 RID: 27575
		internal static byte __PropertyMask_bOverride_IsUsingCustomStencilTest;

		// Token: 0x04006BB8 RID: 27576
		internal static int __PropertyOffset_bIsUsingCustomStencilTest;

		// Token: 0x04006BB9 RID: 27577
		internal static int __PropertyOffset_bOverride_IsUsingCustomStencilDepthTest;

		// Token: 0x04006BBA RID: 27578
		internal static byte __PropertyMask_bOverride_IsUsingCustomStencilDepthTest;

		// Token: 0x04006BBB RID: 27579
		internal static int __PropertyOffset_bIsUsingCustomStencilDepthTest;

		// Token: 0x04006BBC RID: 27580
		internal static int __PropertyOffset_bOverride_CustomStencilRefValue;

		// Token: 0x04006BBD RID: 27581
		internal static byte __PropertyMask_bOverride_CustomStencilRefValue;

		// Token: 0x04006BBE RID: 27582
		internal static int __PropertyOffset_CustomStencilRefValue;

		// Token: 0x04006BBF RID: 27583
		internal static int __PropertyOffset_bOverride_UseFullPrecision;

		// Token: 0x04006BC0 RID: 27584
		internal static byte __PropertyMask_bOverride_UseFullPrecision;

		// Token: 0x04006BC1 RID: 27585
		internal static int __PropertyOffset_bUseFullPrecision;

		// Token: 0x04006BC2 RID: 27586
		internal static byte __PropertyMask_bUseFullPrecision;

		// Token: 0x04006BC3 RID: 27587
		internal static int __PropertyOffset_bOverride_FullPrecisionPlatform;

		// Token: 0x04006BC4 RID: 27588
		internal static byte __PropertyMask_bOverride_FullPrecisionPlatform;

		// Token: 0x04006BC5 RID: 27589
		internal static int __PropertyOffset_FullPrecisionPlatform;

		// Token: 0x04006BC6 RID: 27590
		internal static int __PropertyOffset_bOverride_UseFullPrecisionParams;

		// Token: 0x04006BC7 RID: 27591
		internal static byte __PropertyMask_bOverride_UseFullPrecisionParams;

		// Token: 0x04006BC8 RID: 27592
		internal static int __PropertyOffset_bUseFullPrecisionParams;

		// Token: 0x04006BC9 RID: 27593
		internal static byte __PropertyMask_bUseFullPrecisionParams;

		// Token: 0x04006BCA RID: 27594
		internal static int __PropertyOffset_bOverride_FullPrecisionParamsPlatform;

		// Token: 0x04006BCB RID: 27595
		internal static byte __PropertyMask_bOverride_FullPrecisionParamsPlatform;

		// Token: 0x04006BCC RID: 27596
		internal static int __PropertyOffset_FullPrecisionParamsPlatform;
	}
}
