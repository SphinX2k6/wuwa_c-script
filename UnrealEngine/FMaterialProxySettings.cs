using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E95 RID: 3733
	[UnrealObjectPath("/Script/Engine.MaterialProxySettings")]
	[UnrealStructLayout(136, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMaterialProxySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C8CE RID: 51406 RVA: 0x001244B8 File Offset: 0x001226B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialProxySettings._ScriptStructPtr != 0) ? FMaterialProxySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialProxySettings", ref FMaterialProxySettings._ScriptStructPtr);
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600C8CF RID: 51407 RVA: 0x001244DC File Offset: 0x001226DC
		// (set) Token: 0x0600C8D0 RID: 51408 RVA: 0x001244F0 File Offset: 0x001226F0
		public unsafe FIntPoint TextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TextureSize) = value;
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x00124505 File Offset: 0x00122705
		// (set) Token: 0x0600C8D2 RID: 51410 RVA: 0x00124515 File Offset: 0x00122715
		public unsafe float GutterSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_GutterSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_GutterSpace) = value;
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x00124526 File Offset: 0x00122726
		// (set) Token: 0x0600C8D4 RID: 51412 RVA: 0x00124536 File Offset: 0x00122736
		public unsafe float MetallicConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MetallicConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MetallicConstant) = value;
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x00124547 File Offset: 0x00122747
		// (set) Token: 0x0600C8D6 RID: 51414 RVA: 0x00124557 File Offset: 0x00122757
		public unsafe float RoughnessConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_RoughnessConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_RoughnessConstant) = value;
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600C8D7 RID: 51415 RVA: 0x00124568 File Offset: 0x00122768
		// (set) Token: 0x0600C8D8 RID: 51416 RVA: 0x00124578 File Offset: 0x00122778
		public unsafe float AnisotropyConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AnisotropyConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AnisotropyConstant) = value;
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600C8D9 RID: 51417 RVA: 0x00124589 File Offset: 0x00122789
		// (set) Token: 0x0600C8DA RID: 51418 RVA: 0x00124599 File Offset: 0x00122799
		public unsafe float SpecularConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_SpecularConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_SpecularConstant) = value;
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600C8DB RID: 51419 RVA: 0x001245AA File Offset: 0x001227AA
		// (set) Token: 0x0600C8DC RID: 51420 RVA: 0x001245BA File Offset: 0x001227BA
		public unsafe float OpacityConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityConstant) = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x001245CB File Offset: 0x001227CB
		// (set) Token: 0x0600C8DE RID: 51422 RVA: 0x001245DB File Offset: 0x001227DB
		public unsafe float OpacityMaskConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityMaskConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityMaskConstant) = value;
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600C8DF RID: 51423 RVA: 0x001245EC File Offset: 0x001227EC
		// (set) Token: 0x0600C8E0 RID: 51424 RVA: 0x001245FC File Offset: 0x001227FC
		public unsafe float AmbientOcclusionConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AmbientOcclusionConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AmbientOcclusionConstant) = value;
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600C8E1 RID: 51425 RVA: 0x0012460D File Offset: 0x0012280D
		// (set) Token: 0x0600C8E2 RID: 51426 RVA: 0x00124621 File Offset: 0x00122821
		public unsafe TEnumAsByte<ETextureSizingType> TextureSizingType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TextureSizingType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TextureSizingType) = value;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600C8E3 RID: 51427 RVA: 0x00124636 File Offset: 0x00122836
		// (set) Token: 0x0600C8E4 RID: 51428 RVA: 0x0012464A File Offset: 0x0012284A
		public unsafe TEnumAsByte<EMaterialMergeType> MaterialMergeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MaterialMergeType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MaterialMergeType) = value;
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600C8E5 RID: 51429 RVA: 0x0012465F File Offset: 0x0012285F
		// (set) Token: 0x0600C8E6 RID: 51430 RVA: 0x00124673 File Offset: 0x00122873
		public unsafe TEnumAsByte<EBlendMode> BlendMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_BlendMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_BlendMode) = value;
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600C8E7 RID: 51431 RVA: 0x00124688 File Offset: 0x00122888
		// (set) Token: 0x0600C8E8 RID: 51432 RVA: 0x001246A1 File Offset: 0x001228A1
		public unsafe bool bAllowTwoSidedMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAllowTwoSidedMaterial) & FMaterialProxySettings.__PropertyMask_bAllowTwoSidedMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAllowTwoSidedMaterial) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAllowTwoSidedMaterial) & ~FMaterialProxySettings.__PropertyMask_bAllowTwoSidedMaterial) | (value ? FMaterialProxySettings.__PropertyMask_bAllowTwoSidedMaterial : 0));
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x001246D1 File Offset: 0x001228D1
		// (set) Token: 0x0600C8EA RID: 51434 RVA: 0x001246EA File Offset: 0x001228EA
		public unsafe bool bNormalMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bNormalMap) & FMaterialProxySettings.__PropertyMask_bNormalMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bNormalMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bNormalMap) & ~FMaterialProxySettings.__PropertyMask_bNormalMap) | (value ? FMaterialProxySettings.__PropertyMask_bNormalMap : 0));
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600C8EB RID: 51435 RVA: 0x0012471A File Offset: 0x0012291A
		// (set) Token: 0x0600C8EC RID: 51436 RVA: 0x00124733 File Offset: 0x00122933
		public unsafe bool bTangentMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bTangentMap) & FMaterialProxySettings.__PropertyMask_bTangentMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bTangentMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bTangentMap) & ~FMaterialProxySettings.__PropertyMask_bTangentMap) | (value ? FMaterialProxySettings.__PropertyMask_bTangentMap : 0));
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600C8ED RID: 51437 RVA: 0x00124763 File Offset: 0x00122963
		// (set) Token: 0x0600C8EE RID: 51438 RVA: 0x0012477C File Offset: 0x0012297C
		public unsafe bool bMetallicMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bMetallicMap) & FMaterialProxySettings.__PropertyMask_bMetallicMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bMetallicMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bMetallicMap) & ~FMaterialProxySettings.__PropertyMask_bMetallicMap) | (value ? FMaterialProxySettings.__PropertyMask_bMetallicMap : 0));
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600C8EF RID: 51439 RVA: 0x001247AC File Offset: 0x001229AC
		// (set) Token: 0x0600C8F0 RID: 51440 RVA: 0x001247C5 File Offset: 0x001229C5
		public unsafe bool bRoughnessMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bRoughnessMap) & FMaterialProxySettings.__PropertyMask_bRoughnessMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bRoughnessMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bRoughnessMap) & ~FMaterialProxySettings.__PropertyMask_bRoughnessMap) | (value ? FMaterialProxySettings.__PropertyMask_bRoughnessMap : 0));
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600C8F1 RID: 51441 RVA: 0x001247F5 File Offset: 0x001229F5
		// (set) Token: 0x0600C8F2 RID: 51442 RVA: 0x0012480E File Offset: 0x00122A0E
		public unsafe bool bAnisotropyMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAnisotropyMap) & FMaterialProxySettings.__PropertyMask_bAnisotropyMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAnisotropyMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAnisotropyMap) & ~FMaterialProxySettings.__PropertyMask_bAnisotropyMap) | (value ? FMaterialProxySettings.__PropertyMask_bAnisotropyMap : 0));
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600C8F3 RID: 51443 RVA: 0x0012483E File Offset: 0x00122A3E
		// (set) Token: 0x0600C8F4 RID: 51444 RVA: 0x00124857 File Offset: 0x00122A57
		public unsafe bool bSpecularMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bSpecularMap) & FMaterialProxySettings.__PropertyMask_bSpecularMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bSpecularMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bSpecularMap) & ~FMaterialProxySettings.__PropertyMask_bSpecularMap) | (value ? FMaterialProxySettings.__PropertyMask_bSpecularMap : 0));
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600C8F5 RID: 51445 RVA: 0x00124887 File Offset: 0x00122A87
		// (set) Token: 0x0600C8F6 RID: 51446 RVA: 0x001248A0 File Offset: 0x00122AA0
		public unsafe bool bEmissiveMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bEmissiveMap) & FMaterialProxySettings.__PropertyMask_bEmissiveMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bEmissiveMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bEmissiveMap) & ~FMaterialProxySettings.__PropertyMask_bEmissiveMap) | (value ? FMaterialProxySettings.__PropertyMask_bEmissiveMap : 0));
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600C8F7 RID: 51447 RVA: 0x001248D0 File Offset: 0x00122AD0
		// (set) Token: 0x0600C8F8 RID: 51448 RVA: 0x001248E9 File Offset: 0x00122AE9
		public unsafe bool bOpacityMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMap) & FMaterialProxySettings.__PropertyMask_bOpacityMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMap) & ~FMaterialProxySettings.__PropertyMask_bOpacityMap) | (value ? FMaterialProxySettings.__PropertyMask_bOpacityMap : 0));
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600C8F9 RID: 51449 RVA: 0x00124919 File Offset: 0x00122B19
		// (set) Token: 0x0600C8FA RID: 51450 RVA: 0x00124932 File Offset: 0x00122B32
		public unsafe bool bOpacityMaskMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMaskMap) & FMaterialProxySettings.__PropertyMask_bOpacityMaskMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMaskMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bOpacityMaskMap) & ~FMaterialProxySettings.__PropertyMask_bOpacityMaskMap) | (value ? FMaterialProxySettings.__PropertyMask_bOpacityMaskMap : 0));
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600C8FB RID: 51451 RVA: 0x00124962 File Offset: 0x00122B62
		// (set) Token: 0x0600C8FC RID: 51452 RVA: 0x0012497B File Offset: 0x00122B7B
		public unsafe bool bAmbientOcclusionMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAmbientOcclusionMap) & FMaterialProxySettings.__PropertyMask_bAmbientOcclusionMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAmbientOcclusionMap) = ((*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_bAmbientOcclusionMap) & ~FMaterialProxySettings.__PropertyMask_bAmbientOcclusionMap) | (value ? FMaterialProxySettings.__PropertyMask_bAmbientOcclusionMap : 0));
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600C8FD RID: 51453 RVA: 0x001249AB File Offset: 0x00122BAB
		// (set) Token: 0x0600C8FE RID: 51454 RVA: 0x001249BF File Offset: 0x00122BBF
		public unsafe FIntPoint DiffuseTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_DiffuseTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_DiffuseTextureSize) = value;
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600C8FF RID: 51455 RVA: 0x001249D4 File Offset: 0x00122BD4
		// (set) Token: 0x0600C900 RID: 51456 RVA: 0x001249E8 File Offset: 0x00122BE8
		public unsafe FIntPoint NormalTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_NormalTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_NormalTextureSize) = value;
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600C901 RID: 51457 RVA: 0x001249FD File Offset: 0x00122BFD
		// (set) Token: 0x0600C902 RID: 51458 RVA: 0x00124A11 File Offset: 0x00122C11
		public unsafe FIntPoint TangentTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TangentTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_TangentTextureSize) = value;
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600C903 RID: 51459 RVA: 0x00124A26 File Offset: 0x00122C26
		// (set) Token: 0x0600C904 RID: 51460 RVA: 0x00124A3A File Offset: 0x00122C3A
		public unsafe FIntPoint MetallicTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MetallicTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_MetallicTextureSize) = value;
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600C905 RID: 51461 RVA: 0x00124A4F File Offset: 0x00122C4F
		// (set) Token: 0x0600C906 RID: 51462 RVA: 0x00124A63 File Offset: 0x00122C63
		public unsafe FIntPoint RoughnessTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_RoughnessTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_RoughnessTextureSize) = value;
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600C907 RID: 51463 RVA: 0x00124A78 File Offset: 0x00122C78
		// (set) Token: 0x0600C908 RID: 51464 RVA: 0x00124A8C File Offset: 0x00122C8C
		public unsafe FIntPoint AnisotropyTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AnisotropyTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AnisotropyTextureSize) = value;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600C909 RID: 51465 RVA: 0x00124AA1 File Offset: 0x00122CA1
		// (set) Token: 0x0600C90A RID: 51466 RVA: 0x00124AB5 File Offset: 0x00122CB5
		public unsafe FIntPoint SpecularTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_SpecularTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_SpecularTextureSize) = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600C90B RID: 51467 RVA: 0x00124ACA File Offset: 0x00122CCA
		// (set) Token: 0x0600C90C RID: 51468 RVA: 0x00124ADE File Offset: 0x00122CDE
		public unsafe FIntPoint EmissiveTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_EmissiveTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_EmissiveTextureSize) = value;
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600C90D RID: 51469 RVA: 0x00124AF3 File Offset: 0x00122CF3
		// (set) Token: 0x0600C90E RID: 51470 RVA: 0x00124B07 File Offset: 0x00122D07
		public unsafe FIntPoint OpacityTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityTextureSize) = value;
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600C90F RID: 51471 RVA: 0x00124B1C File Offset: 0x00122D1C
		// (set) Token: 0x0600C910 RID: 51472 RVA: 0x00124B30 File Offset: 0x00122D30
		public unsafe FIntPoint OpacityMaskTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityMaskTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_OpacityMaskTextureSize) = value;
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600C911 RID: 51473 RVA: 0x00124B45 File Offset: 0x00122D45
		// (set) Token: 0x0600C912 RID: 51474 RVA: 0x00124B59 File Offset: 0x00122D59
		public unsafe FIntPoint AmbientOcclusionTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AmbientOcclusionTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialProxySettings.__PropertyOffset_AmbientOcclusionTextureSize) = value;
			}
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x00124B6E File Offset: 0x00122D6E
		public FMaterialProxySettings()
		{
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x00124B78 File Offset: 0x00122D78
		public FMaterialProxySettings(FIntPoint TextureSize, float GutterSpace, float MetallicConstant, float RoughnessConstant, float AnisotropyConstant, float SpecularConstant, float OpacityConstant, float OpacityMaskConstant, float AmbientOcclusionConstant, TEnumAsByte<ETextureSizingType> TextureSizingType, TEnumAsByte<EMaterialMergeType> MaterialMergeType, TEnumAsByte<EBlendMode> BlendMode, bool bAllowTwoSidedMaterial, bool bNormalMap, bool bTangentMap, bool bMetallicMap, bool bRoughnessMap, bool bAnisotropyMap, bool bSpecularMap, bool bEmissiveMap, bool bOpacityMap, bool bOpacityMaskMap, bool bAmbientOcclusionMap, FIntPoint DiffuseTextureSize, FIntPoint NormalTextureSize, FIntPoint TangentTextureSize, FIntPoint MetallicTextureSize, FIntPoint RoughnessTextureSize, FIntPoint AnisotropyTextureSize, FIntPoint SpecularTextureSize, FIntPoint EmissiveTextureSize, FIntPoint OpacityTextureSize, FIntPoint OpacityMaskTextureSize, FIntPoint AmbientOcclusionTextureSize)
		{
			this.TextureSize = TextureSize;
			this.GutterSpace = GutterSpace;
			this.MetallicConstant = MetallicConstant;
			this.RoughnessConstant = RoughnessConstant;
			this.AnisotropyConstant = AnisotropyConstant;
			this.SpecularConstant = SpecularConstant;
			this.OpacityConstant = OpacityConstant;
			this.OpacityMaskConstant = OpacityMaskConstant;
			this.AmbientOcclusionConstant = AmbientOcclusionConstant;
			this.TextureSizingType = TextureSizingType;
			this.MaterialMergeType = MaterialMergeType;
			this.BlendMode = BlendMode;
			this.bAllowTwoSidedMaterial = bAllowTwoSidedMaterial;
			this.bNormalMap = bNormalMap;
			this.bTangentMap = bTangentMap;
			this.bMetallicMap = bMetallicMap;
			this.bRoughnessMap = bRoughnessMap;
			this.bAnisotropyMap = bAnisotropyMap;
			this.bSpecularMap = bSpecularMap;
			this.bEmissiveMap = bEmissiveMap;
			this.bOpacityMap = bOpacityMap;
			this.bOpacityMaskMap = bOpacityMaskMap;
			this.bAmbientOcclusionMap = bAmbientOcclusionMap;
			this.DiffuseTextureSize = DiffuseTextureSize;
			this.NormalTextureSize = NormalTextureSize;
			this.TangentTextureSize = TangentTextureSize;
			this.MetallicTextureSize = MetallicTextureSize;
			this.RoughnessTextureSize = RoughnessTextureSize;
			this.AnisotropyTextureSize = AnisotropyTextureSize;
			this.SpecularTextureSize = SpecularTextureSize;
			this.EmissiveTextureSize = EmissiveTextureSize;
			this.OpacityTextureSize = OpacityTextureSize;
			this.OpacityMaskTextureSize = OpacityMaskTextureSize;
			this.AmbientOcclusionTextureSize = AmbientOcclusionTextureSize;
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x00124C98 File Offset: 0x00122E98
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialProxySettings.StaticStruct();
		}

		// Token: 0x0600C916 RID: 51478 RVA: 0x00124CA4 File Offset: 0x00122EA4
		[NullableContext(2)]
		public FMaterialProxySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x00124CAE File Offset: 0x00122EAE
		public FMaterialProxySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C918 RID: 51480 RVA: 0x00124CB9 File Offset: 0x00122EB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialProxySettings(Pointer, false, true);
		}

		// Token: 0x0600C919 RID: 51481 RVA: 0x00124CC3 File Offset: 0x00122EC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialProxySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006C0B RID: 27659
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialProxySettings";

		// Token: 0x04006C0C RID: 27660
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C0D RID: 27661
		internal static int __PropertyOffset_TextureSize;

		// Token: 0x04006C0E RID: 27662
		internal static int __PropertyOffset_GutterSpace;

		// Token: 0x04006C0F RID: 27663
		internal static int __PropertyOffset_MetallicConstant;

		// Token: 0x04006C10 RID: 27664
		internal static int __PropertyOffset_RoughnessConstant;

		// Token: 0x04006C11 RID: 27665
		internal static int __PropertyOffset_AnisotropyConstant;

		// Token: 0x04006C12 RID: 27666
		internal static int __PropertyOffset_SpecularConstant;

		// Token: 0x04006C13 RID: 27667
		internal static int __PropertyOffset_OpacityConstant;

		// Token: 0x04006C14 RID: 27668
		internal static int __PropertyOffset_OpacityMaskConstant;

		// Token: 0x04006C15 RID: 27669
		internal static int __PropertyOffset_AmbientOcclusionConstant;

		// Token: 0x04006C16 RID: 27670
		internal static int __PropertyOffset_TextureSizingType;

		// Token: 0x04006C17 RID: 27671
		internal static int __PropertyOffset_MaterialMergeType;

		// Token: 0x04006C18 RID: 27672
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x04006C19 RID: 27673
		internal static int __PropertyOffset_bAllowTwoSidedMaterial;

		// Token: 0x04006C1A RID: 27674
		internal static byte __PropertyMask_bAllowTwoSidedMaterial;

		// Token: 0x04006C1B RID: 27675
		internal static int __PropertyOffset_bNormalMap;

		// Token: 0x04006C1C RID: 27676
		internal static byte __PropertyMask_bNormalMap;

		// Token: 0x04006C1D RID: 27677
		internal static int __PropertyOffset_bTangentMap;

		// Token: 0x04006C1E RID: 27678
		internal static byte __PropertyMask_bTangentMap;

		// Token: 0x04006C1F RID: 27679
		internal static int __PropertyOffset_bMetallicMap;

		// Token: 0x04006C20 RID: 27680
		internal static byte __PropertyMask_bMetallicMap;

		// Token: 0x04006C21 RID: 27681
		internal static int __PropertyOffset_bRoughnessMap;

		// Token: 0x04006C22 RID: 27682
		internal static byte __PropertyMask_bRoughnessMap;

		// Token: 0x04006C23 RID: 27683
		internal static int __PropertyOffset_bAnisotropyMap;

		// Token: 0x04006C24 RID: 27684
		internal static byte __PropertyMask_bAnisotropyMap;

		// Token: 0x04006C25 RID: 27685
		internal static int __PropertyOffset_bSpecularMap;

		// Token: 0x04006C26 RID: 27686
		internal static byte __PropertyMask_bSpecularMap;

		// Token: 0x04006C27 RID: 27687
		internal static int __PropertyOffset_bEmissiveMap;

		// Token: 0x04006C28 RID: 27688
		internal static byte __PropertyMask_bEmissiveMap;

		// Token: 0x04006C29 RID: 27689
		internal static int __PropertyOffset_bOpacityMap;

		// Token: 0x04006C2A RID: 27690
		internal static byte __PropertyMask_bOpacityMap;

		// Token: 0x04006C2B RID: 27691
		internal static int __PropertyOffset_bOpacityMaskMap;

		// Token: 0x04006C2C RID: 27692
		internal static byte __PropertyMask_bOpacityMaskMap;

		// Token: 0x04006C2D RID: 27693
		internal static int __PropertyOffset_bAmbientOcclusionMap;

		// Token: 0x04006C2E RID: 27694
		internal static byte __PropertyMask_bAmbientOcclusionMap;

		// Token: 0x04006C2F RID: 27695
		internal static int __PropertyOffset_DiffuseTextureSize;

		// Token: 0x04006C30 RID: 27696
		internal static int __PropertyOffset_NormalTextureSize;

		// Token: 0x04006C31 RID: 27697
		internal static int __PropertyOffset_TangentTextureSize;

		// Token: 0x04006C32 RID: 27698
		internal static int __PropertyOffset_MetallicTextureSize;

		// Token: 0x04006C33 RID: 27699
		internal static int __PropertyOffset_RoughnessTextureSize;

		// Token: 0x04006C34 RID: 27700
		internal static int __PropertyOffset_AnisotropyTextureSize;

		// Token: 0x04006C35 RID: 27701
		internal static int __PropertyOffset_SpecularTextureSize;

		// Token: 0x04006C36 RID: 27702
		internal static int __PropertyOffset_EmissiveTextureSize;

		// Token: 0x04006C37 RID: 27703
		internal static int __PropertyOffset_OpacityTextureSize;

		// Token: 0x04006C38 RID: 27704
		internal static int __PropertyOffset_OpacityMaskTextureSize;

		// Token: 0x04006C39 RID: 27705
		internal static int __PropertyOffset_AmbientOcclusionTextureSize;
	}
}
