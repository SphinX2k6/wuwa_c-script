using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000239 RID: 569
	[UnrealObjectPath("/Script/Engine.Material")]
	[UnrealStructLayout(4248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4248)]
	public class UMaterial : UMaterialInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002F4C RID: 12108 RVA: 0x00042395 File Offset: 0x00040595
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterial._ClassPtr;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000423A4 File Offset: 0x000405A4
		public UMaterial() : this(BuiltinUtils.AllocNativeUObject(UMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000423CC File Offset: 0x000405CC
		[NullableContext(1)]
		public UMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x000423FF File Offset: 0x000405FF
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00042413 File Offset: 0x00040613
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterial.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x00042428 File Offset: 0x00040628
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x00042462 File Offset: 0x00040662
		[Nullable(1)]
		public TFixedArray<UPhysicalMaterial> PhysicalMaterialMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterialMap) == null)
				{
					result = (this._PhysicalMaterialMap = new TFixedArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_PhysicalMaterialMap, 8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PhysicalMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x00042470 File Offset: 0x00040670
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x00042489 File Offset: 0x00040689
		public unsafe bool MaterialReceiveDecal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) & UMaterial.__PropertyMask_MaterialReceiveDecal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaterialReceiveDecal) & ~UMaterial.__PropertyMask_MaterialReceiveDecal) | (value ? UMaterial.__PropertyMask_MaterialReceiveDecal : 0));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x000424B9 File Offset: 0x000406B9
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x000424D2 File Offset: 0x000406D2
		public unsafe bool bCastDynamicShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) & UMaterial.__PropertyMask_bCastDynamicShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastDynamicShadowAsMasked) & ~UMaterial.__PropertyMask_bCastDynamicShadowAsMasked) | (value ? UMaterial.__PropertyMask_bCastDynamicShadowAsMasked : 0));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00042502 File Offset: 0x00040702
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x00042512 File Offset: 0x00040712
		public unsafe float OpacityMaskClipValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OpacityMaskClipValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OpacityMaskClipValue) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00042523 File Offset: 0x00040723
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x0004253C File Offset: 0x0004073C
		public unsafe bool bEnableSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) & UMaterial.__PropertyMask_bEnableSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableSeparateTranslucency) & ~UMaterial.__PropertyMask_bEnableSeparateTranslucency) | (value ? UMaterial.__PropertyMask_bEnableSeparateTranslucency : 0));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x0004256C File Offset: 0x0004076C
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00042585 File Offset: 0x00040785
		public unsafe bool bEnableResponsiveAA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) & UMaterial.__PropertyMask_bEnableResponsiveAA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableResponsiveAA) & ~UMaterial.__PropertyMask_bEnableResponsiveAA) | (value ? UMaterial.__PropertyMask_bEnableResponsiveAA : 0));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000425B5 File Offset: 0x000407B5
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x000425CE File Offset: 0x000407CE
		public unsafe bool bScreenSpaceReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) & UMaterial.__PropertyMask_bScreenSpaceReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bScreenSpaceReflections) & ~UMaterial.__PropertyMask_bScreenSpaceReflections) | (value ? UMaterial.__PropertyMask_bScreenSpaceReflections : 0));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000425FE File Offset: 0x000407FE
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00042617 File Offset: 0x00040817
		public unsafe bool bContactShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) & UMaterial.__PropertyMask_bContactShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bContactShadows) & ~UMaterial.__PropertyMask_bContactShadows) | (value ? UMaterial.__PropertyMask_bContactShadows : 0));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x00042647 File Offset: 0x00040847
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x00042660 File Offset: 0x00040860
		public unsafe bool bTranslucencyReceiveLightFunctionShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) & UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveLightFunctionShadow) & ~UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow) | (value ? UMaterial.__PropertyMask_bTranslucencyReceiveLightFunctionShadow : 0));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x00042690 File Offset: 0x00040890
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x000426A9 File Offset: 0x000408A9
		public unsafe bool TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) & UMaterial.__PropertyMask_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TwoSided) & ~UMaterial.__PropertyMask_TwoSided) | (value ? UMaterial.__PropertyMask_TwoSided : 0));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000426D9 File Offset: 0x000408D9
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x000426F2 File Offset: 0x000408F2
		public unsafe bool KuroWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) & UMaterial.__PropertyMask_KuroWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_KuroWater) & ~UMaterial.__PropertyMask_KuroWater) | (value ? UMaterial.__PropertyMask_KuroWater : 0));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x00042722 File Offset: 0x00040922
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x0004273B File Offset: 0x0004093B
		public unsafe bool BackFace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) & UMaterial.__PropertyMask_BackFace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BackFace) & ~UMaterial.__PropertyMask_BackFace) | (value ? UMaterial.__PropertyMask_BackFace : 0));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x0004276B File Offset: 0x0004096B
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x00042784 File Offset: 0x00040984
		public unsafe bool bSceneDissolveEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) & UMaterial.__PropertyMask_bSceneDissolveEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneDissolveEnable) & ~UMaterial.__PropertyMask_bSceneDissolveEnable) | (value ? UMaterial.__PropertyMask_bSceneDissolveEnable : 0));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000427B4 File Offset: 0x000409B4
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x000427CD File Offset: 0x000409CD
		public unsafe bool bSceneColorClearEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) & UMaterial.__PropertyMask_bSceneColorClearEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSceneColorClearEnable) & ~UMaterial.__PropertyMask_bSceneColorClearEnable) | (value ? UMaterial.__PropertyMask_bSceneColorClearEnable : 0));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000427FD File Offset: 0x000409FD
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x0004280D File Offset: 0x00040A0D
		public unsafe ushort RenderQueue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RenderQueue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RenderQueue) = (short)value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x0004281E File Offset: 0x00040A1E
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00042837 File Offset: 0x00040A37
		public unsafe bool bDisableShadowCacheForSPDO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) & UMaterial.__PropertyMask_bDisableShadowCacheForSPDO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableShadowCacheForSPDO) & ~UMaterial.__PropertyMask_bDisableShadowCacheForSPDO) | (value ? UMaterial.__PropertyMask_bDisableShadowCacheForSPDO : 0));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x00042867 File Offset: 0x00040A67
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00042880 File Offset: 0x00040A80
		public unsafe bool bSinglelayerWaterWriteDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) & UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSinglelayerWaterWriteDepth) & ~UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth) | (value ? UMaterial.__PropertyMask_bSinglelayerWaterWriteDepth : 0));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x000428B0 File Offset: 0x00040AB0
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x000428C9 File Offset: 0x00040AC9
		public unsafe bool bSingleLayerWaterMobileDesaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) & UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterMobileDesaturation) & ~UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterMobileDesaturation : 0));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000428F9 File Offset: 0x00040AF9
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00042912 File Offset: 0x00040B12
		public unsafe bool bDrawRTWithRGBA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) & UMaterial.__PropertyMask_bDrawRTWithRGBA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawRTWithRGBA) & ~UMaterial.__PropertyMask_bDrawRTWithRGBA) | (value ? UMaterial.__PropertyMask_bDrawRTWithRGBA : 0));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00042942 File Offset: 0x00040B42
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x0004295B File Offset: 0x00040B5B
		public unsafe bool bRenderInCustomCapturePass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) & UMaterial.__PropertyMask_bRenderInCustomCapturePass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInCustomCapturePass) & ~UMaterial.__PropertyMask_bRenderInCustomCapturePass) | (value ? UMaterial.__PropertyMask_bRenderInCustomCapturePass : 0));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x0004298B File Offset: 0x00040B8B
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x000429A4 File Offset: 0x00040BA4
		public unsafe bool bRenderInGodRayPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) & UMaterial.__PropertyMask_bRenderInGodRayPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInGodRayPass) & ~UMaterial.__PropertyMask_bRenderInGodRayPass) | (value ? UMaterial.__PropertyMask_bRenderInGodRayPass : 0));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x000429D4 File Offset: 0x00040BD4
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x000429ED File Offset: 0x00040BED
		public unsafe bool bMaskedRenderInPreDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) & UMaterial.__PropertyMask_bMaskedRenderInPreDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth) & ~UMaterial.__PropertyMask_bMaskedRenderInPreDepth) | (value ? UMaterial.__PropertyMask_bMaskedRenderInPreDepth : 0));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x00042A1D File Offset: 0x00040C1D
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x00042A36 File Offset: 0x00040C36
		public unsafe bool bMaskedRenderInPreDepth_PC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) & UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMaskedRenderInPreDepth_PC) & ~UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC) | (value ? UMaterial.__PropertyMask_bMaskedRenderInPreDepth_PC : 0));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00042A66 File Offset: 0x00040C66
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00042A7F File Offset: 0x00040C7F
		public unsafe bool bSupportMobileHighQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) & UMaterial.__PropertyMask_bSupportMobileHighQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportMobileHighQuality) & ~UMaterial.__PropertyMask_bSupportMobileHighQuality) | (value ? UMaterial.__PropertyMask_bSupportMobileHighQuality : 0));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00042AAF File Offset: 0x00040CAF
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x00042AC8 File Offset: 0x00040CC8
		public unsafe bool bCustomAlphaTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) & UMaterial.__PropertyMask_bCustomAlphaTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomAlphaTest) & ~UMaterial.__PropertyMask_bCustomAlphaTest) | (value ? UMaterial.__PropertyMask_bCustomAlphaTest : 0));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00042AF8 File Offset: 0x00040CF8
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x00042B11 File Offset: 0x00040D11
		public unsafe bool bEnableBattle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) & UMaterial.__PropertyMask_bEnableBattle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattle) & ~UMaterial.__PropertyMask_bEnableBattle) | (value ? UMaterial.__PropertyMask_bEnableBattle : 0));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00042B41 File Offset: 0x00040D41
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00042B5A File Offset: 0x00040D5A
		public unsafe bool bEnableBattleMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) & UMaterial.__PropertyMask_bEnableBattleMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableBattleMask) & ~UMaterial.__PropertyMask_bEnableBattleMask) | (value ? UMaterial.__PropertyMask_bEnableBattleMask : 0));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00042B8A File Offset: 0x00040D8A
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00042BA3 File Offset: 0x00040DA3
		public unsafe bool bIsCharacterHairMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) & UMaterial.__PropertyMask_bIsCharacterHairMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHairMat) & ~UMaterial.__PropertyMask_bIsCharacterHairMat) | (value ? UMaterial.__PropertyMask_bIsCharacterHairMat : 0));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00042BD3 File Offset: 0x00040DD3
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x00042BEC File Offset: 0x00040DEC
		public unsafe bool bIsCharacterHETMat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) & UMaterial.__PropertyMask_bIsCharacterHETMat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsCharacterHETMat) & ~UMaterial.__PropertyMask_bIsCharacterHETMat) | (value ? UMaterial.__PropertyMask_bIsCharacterHETMat : 0));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00042C1C File Offset: 0x00040E1C
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00042C2C File Offset: 0x00040E2C
		public unsafe bool bHETMatOnlyUsedPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHETMatOnlyUsedPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHETMatOnlyUsedPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00042C3D File Offset: 0x00040E3D
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00042C4D File Offset: 0x00040E4D
		public unsafe bool bIsUsedWithWriteStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsUsedWithWriteStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsUsedWithWriteStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00042C5E File Offset: 0x00040E5E
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00042C77 File Offset: 0x00040E77
		public unsafe bool bRenderToonFFT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) & UMaterial.__PropertyMask_bRenderToonFFT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderToonFFT) & ~UMaterial.__PropertyMask_bRenderToonFFT) | (value ? UMaterial.__PropertyMask_bRenderToonFFT : 0));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00042CA7 File Offset: 0x00040EA7
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x00042CC0 File Offset: 0x00040EC0
		public unsafe bool bRenderTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) & UMaterial.__PropertyMask_bRenderTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderTranslucentOpacity) & ~UMaterial.__PropertyMask_bRenderTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bRenderTranslucentOpacity : 0));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x00042CF0 File Offset: 0x00040EF0
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x00042D09 File Offset: 0x00040F09
		public unsafe bool bForceSceneTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) & UMaterial.__PropertyMask_bForceSceneTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceSceneTranslucentOpacity) & ~UMaterial.__PropertyMask_bForceSceneTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bForceSceneTranslucentOpacity : 0));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00042D39 File Offset: 0x00040F39
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00042D52 File Offset: 0x00040F52
		public unsafe bool bForceFightTranslucentOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) & UMaterial.__PropertyMask_bForceFightTranslucentOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForceFightTranslucentOpacity) & ~UMaterial.__PropertyMask_bForceFightTranslucentOpacity) | (value ? UMaterial.__PropertyMask_bForceFightTranslucentOpacity : 0));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x00042D82 File Offset: 0x00040F82
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00042D92 File Offset: 0x00040F92
		public unsafe float ExtendedHETDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ExtendedHETDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ExtendedHETDistance) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00042DA3 File Offset: 0x00040FA3
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x00042DBC File Offset: 0x00040FBC
		public unsafe bool bUseMobileDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) & UMaterial.__PropertyMask_bUseMobileDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMobileDistortion) & ~UMaterial.__PropertyMask_bUseMobileDistortion) | (value ? UMaterial.__PropertyMask_bUseMobileDistortion : 0));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x00042DEC File Offset: 0x00040FEC
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x00042E05 File Offset: 0x00041005
		public unsafe bool bLGUIMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) & UMaterial.__PropertyMask_bLGUIMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterial) & ~UMaterial.__PropertyMask_bLGUIMaterial) | (value ? UMaterial.__PropertyMask_bLGUIMaterial : 0));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00042E35 File Offset: 0x00041035
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x00042E4E File Offset: 0x0004104E
		public unsafe bool bLGUIMaterialDrawBeforeUpScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) & UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUIMaterialDrawBeforeUpScale) & ~UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale) | (value ? UMaterial.__PropertyMask_bLGUIMaterialDrawBeforeUpScale : 0));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x00042E7E File Offset: 0x0004107E
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00042E97 File Offset: 0x00041097
		public unsafe bool bLGUISkipDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) & UMaterial.__PropertyMask_bLGUISkipDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLGUISkipDepth) & ~UMaterial.__PropertyMask_bLGUISkipDepth) | (value ? UMaterial.__PropertyMask_bLGUISkipDepth : 0));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x00042EC7 File Offset: 0x000410C7
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x00042EE0 File Offset: 0x000410E0
		public unsafe bool bTranslucencyUse3xPCF
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) & UMaterial.__PropertyMask_bTranslucencyUse3xPCF) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyUse3xPCF) & ~UMaterial.__PropertyMask_bTranslucencyUse3xPCF) | (value ? UMaterial.__PropertyMask_bTranslucencyUse3xPCF : 0));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x00042F10 File Offset: 0x00041110
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00042F29 File Offset: 0x00041129
		public unsafe bool bTranslucencyIBLUseCustomdataRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) & UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyIBLUseCustomdataRoughness) & ~UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness) | (value ? UMaterial.__PropertyMask_bTranslucencyIBLUseCustomdataRoughness : 0));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x00042F59 File Offset: 0x00041159
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00042F72 File Offset: 0x00041172
		public unsafe bool bTranslucencyReceiveShadowMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) & UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucencyReceiveShadowMobile) & ~UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile) | (value ? UMaterial.__PropertyMask_bTranslucencyReceiveShadowMobile : 0));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x00042FA2 File Offset: 0x000411A2
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00042FBB File Offset: 0x000411BB
		public unsafe bool bVolumeDirectionalLightTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bVolumeDirectionalLightTint) & UMaterial.__PropertyMask_bVolumeDirectionalLightTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bVolumeDirectionalLightTint) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bVolumeDirectionalLightTint) & ~UMaterial.__PropertyMask_bVolumeDirectionalLightTint) | (value ? UMaterial.__PropertyMask_bVolumeDirectionalLightTint : 0));
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00042FEB File Offset: 0x000411EB
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x00043004 File Offset: 0x00041204
		public unsafe bool DitheredLODTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) & UMaterial.__PropertyMask_DitheredLODTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitheredLODTransition) & ~UMaterial.__PropertyMask_DitheredLODTransition) | (value ? UMaterial.__PropertyMask_DitheredLODTransition : 0));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x00043034 File Offset: 0x00041234
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0004304D File Offset: 0x0004124D
		public unsafe bool DitherOpacityMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) & UMaterial.__PropertyMask_DitherOpacityMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DitherOpacityMask) & ~UMaterial.__PropertyMask_DitherOpacityMask) | (value ? UMaterial.__PropertyMask_DitherOpacityMask : 0));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x0004307D File Offset: 0x0004127D
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x00043096 File Offset: 0x00041296
		public unsafe bool bAllowNegativeEmissiveColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) & UMaterial.__PropertyMask_bAllowNegativeEmissiveColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowNegativeEmissiveColor) & ~UMaterial.__PropertyMask_bAllowNegativeEmissiveColor) | (value ? UMaterial.__PropertyMask_bAllowNegativeEmissiveColor : 0));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x000430C6 File Offset: 0x000412C6
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x000430DF File Offset: 0x000412DF
		public unsafe bool bEnableMobileSeparateTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) & UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableMobileSeparateTranslucency) & ~UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency) | (value ? UMaterial.__PropertyMask_bEnableMobileSeparateTranslucency : 0));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x0004310F File Offset: 0x0004130F
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x00043128 File Offset: 0x00041328
		public unsafe bool bUseNormalDither
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) & UMaterial.__PropertyMask_bUseNormalDither) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseNormalDither) & ~UMaterial.__PropertyMask_bUseNormalDither) | (value ? UMaterial.__PropertyMask_bUseNormalDither : 0));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x00043158 File Offset: 0x00041358
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x00043168 File Offset: 0x00041368
		public unsafe float NormalDitherScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NormalDitherScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NormalDitherScale) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x00043179 File Offset: 0x00041379
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00043189 File Offset: 0x00041389
		public unsafe float WPORTCullDistScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WPORTCullDistScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WPORTCullDistScale) = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x0004319A File Offset: 0x0004139A
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x000431AA File Offset: 0x000413AA
		public unsafe int NumCustomizedUVs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NumCustomizedUVs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_NumCustomizedUVs) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x000431BB File Offset: 0x000413BB
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x000431CB File Offset: 0x000413CB
		public unsafe float TranslucencyDirectionalLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyDirectionalLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucencyDirectionalLightingIntensity) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000431DC File Offset: 0x000413DC
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x000431EC File Offset: 0x000413EC
		public unsafe float TranslucentShadowDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowDensityScale) = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000431FD File Offset: 0x000413FD
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x0004320D File Offset: 0x0004140D
		public unsafe float TranslucentSelfShadowDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowDensityScale) = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x0004321E File Offset: 0x0004141E
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x0004322E File Offset: 0x0004142E
		public unsafe float TranslucentSelfShadowSecondDensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondDensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondDensityScale) = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x0004323F File Offset: 0x0004143F
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x0004324F File Offset: 0x0004144F
		public unsafe float TranslucentSelfShadowSecondOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentSelfShadowSecondOpacity) = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00043260 File Offset: 0x00041460
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x00043270 File Offset: 0x00041470
		public unsafe float TranslucentBackscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentBackscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentBackscatteringExponent) = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x00043281 File Offset: 0x00041481
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00043295 File Offset: 0x00041495
		public unsafe FLinearColor TranslucentMultipleScatteringExtinction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentMultipleScatteringExtinction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentMultipleScatteringExtinction) = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000432AA File Offset: 0x000414AA
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x000432BA File Offset: 0x000414BA
		public unsafe float TranslucentShadowStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_TranslucentShadowStartOffset) = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x000432CB File Offset: 0x000414CB
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x000432E4 File Offset: 0x000414E4
		public unsafe bool bDisableDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) & UMaterial.__PropertyMask_bDisableDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableDepthTest) & ~UMaterial.__PropertyMask_bDisableDepthTest) | (value ? UMaterial.__PropertyMask_bDisableDepthTest : 0));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x00043314 File Offset: 0x00041514
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x0004332D File Offset: 0x0004152D
		public unsafe bool bWriteOnlyAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) & UMaterial.__PropertyMask_bWriteOnlyAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteOnlyAlpha) & ~UMaterial.__PropertyMask_bWriteOnlyAlpha) | (value ? UMaterial.__PropertyMask_bWriteOnlyAlpha : 0));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x0004335D File Offset: 0x0004155D
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x00043376 File Offset: 0x00041576
		public unsafe bool bGenerateSphericalParticleNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) & UMaterial.__PropertyMask_bGenerateSphericalParticleNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bGenerateSphericalParticleNormals) & ~UMaterial.__PropertyMask_bGenerateSphericalParticleNormals) | (value ? UMaterial.__PropertyMask_bGenerateSphericalParticleNormals : 0));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000433A6 File Offset: 0x000415A6
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x000433BF File Offset: 0x000415BF
		public unsafe bool bTangentSpaceNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) & UMaterial.__PropertyMask_bTangentSpaceNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTangentSpaceNormal) & ~UMaterial.__PropertyMask_bTangentSpaceNormal) | (value ? UMaterial.__PropertyMask_bTangentSpaceNormal : 0));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x000433EF File Offset: 0x000415EF
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x00043408 File Offset: 0x00041608
		public unsafe bool bUseEmissiveForDynamicAreaLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) & UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseEmissiveForDynamicAreaLighting) & ~UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting) | (value ? UMaterial.__PropertyMask_bUseEmissiveForDynamicAreaLighting : 0));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x00043438 File Offset: 0x00041638
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x00043451 File Offset: 0x00041651
		public unsafe bool bBlockGI
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) & UMaterial.__PropertyMask_bBlockGI) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBlockGI) & ~UMaterial.__PropertyMask_bBlockGI) | (value ? UMaterial.__PropertyMask_bBlockGI : 0));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x00043481 File Offset: 0x00041681
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x0004349A File Offset: 0x0004169A
		public unsafe bool bUsedAsSpecialEngineMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) & UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedAsSpecialEngineMaterial) & ~UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial) | (value ? UMaterial.__PropertyMask_bUsedAsSpecialEngineMaterial : 0));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x000434CA File Offset: 0x000416CA
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x000434E3 File Offset: 0x000416E3
		public unsafe bool bUsedWithSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) & UMaterial.__PropertyMask_bUsedWithSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSkeletalMesh) & ~UMaterial.__PropertyMask_bUsedWithSkeletalMesh) | (value ? UMaterial.__PropertyMask_bUsedWithSkeletalMesh : 0));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x00043513 File Offset: 0x00041713
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x0004352C File Offset: 0x0004172C
		public unsafe bool bUsedWithBakedBoneMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) & UMaterial.__PropertyMask_bUsedWithBakedBoneMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBakedBoneMesh) & ~UMaterial.__PropertyMask_bUsedWithBakedBoneMesh) | (value ? UMaterial.__PropertyMask_bUsedWithBakedBoneMesh : 0));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x0004355C File Offset: 0x0004175C
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x00043575 File Offset: 0x00041775
		public unsafe bool bUsedWithExpandedTexcoordsSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh) & ~UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh) | (value ? UMaterial.__PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh : 0));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x000435A5 File Offset: 0x000417A5
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x000435BE File Offset: 0x000417BE
		public unsafe bool bIsOnlyForSkeletalMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) & UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsOnlyForSkeletalMesh) & ~UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh) | (value ? UMaterial.__PropertyMask_bIsOnlyForSkeletalMesh : 0));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x000435EE File Offset: 0x000417EE
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x00043607 File Offset: 0x00041807
		public unsafe bool bIsDisableWuYinQuLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) & UMaterial.__PropertyMask_bIsDisableWuYinQuLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWuYinQuLayer) & ~UMaterial.__PropertyMask_bIsDisableWuYinQuLayer) | (value ? UMaterial.__PropertyMask_bIsDisableWuYinQuLayer : 0));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x00043637 File Offset: 0x00041837
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00043650 File Offset: 0x00041850
		public unsafe bool bIsDisableWetLayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) & UMaterial.__PropertyMask_bIsDisableWetLayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableWetLayer) & ~UMaterial.__PropertyMask_bIsDisableWetLayer) | (value ? UMaterial.__PropertyMask_bIsDisableWetLayer : 0));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x00043680 File Offset: 0x00041880
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00043699 File Offset: 0x00041899
		public unsafe bool bIsNoWaterForToon
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) & UMaterial.__PropertyMask_bIsNoWaterForToon) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsNoWaterForToon) & ~UMaterial.__PropertyMask_bIsNoWaterForToon) | (value ? UMaterial.__PropertyMask_bIsNoWaterForToon : 0));
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x000436C9 File Offset: 0x000418C9
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x000436E2 File Offset: 0x000418E2
		public unsafe bool bUsedWithShadowSVT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) & UMaterial.__PropertyMask_bUsedWithShadowSVT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithShadowSVT) & ~UMaterial.__PropertyMask_bUsedWithShadowSVT) | (value ? UMaterial.__PropertyMask_bUsedWithShadowSVT : 0));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x00043712 File Offset: 0x00041912
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x0004372B File Offset: 0x0004192B
		public unsafe bool bSingleLayerWaterRainDrop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) & UMaterial.__PropertyMask_bSingleLayerWaterRainDrop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterRainDrop) & ~UMaterial.__PropertyMask_bSingleLayerWaterRainDrop) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterRainDrop : 0));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x0004375B File Offset: 0x0004195B
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x00043774 File Offset: 0x00041974
		public unsafe bool bSingleLayerWaterSSRProxy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) & UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSingleLayerWaterSSRProxy) & ~UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy) | (value ? UMaterial.__PropertyMask_bSingleLayerWaterSSRProxy : 0));
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000437A4 File Offset: 0x000419A4
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x000437BD File Offset: 0x000419BD
		public unsafe bool bWriteDepthToGbuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) & UMaterial.__PropertyMask_bWriteDepthToGbuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bWriteDepthToGbuffer) & ~UMaterial.__PropertyMask_bWriteDepthToGbuffer) | (value ? UMaterial.__PropertyMask_bWriteDepthToGbuffer : 0));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000437ED File Offset: 0x000419ED
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x00043806 File Offset: 0x00041A06
		public unsafe bool bUseAnisotropy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) & UMaterial.__PropertyMask_bUseAnisotropy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAnisotropy) & ~UMaterial.__PropertyMask_bUseAnisotropy) | (value ? UMaterial.__PropertyMask_bUseAnisotropy : 0));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x00043836 File Offset: 0x00041A36
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x0004384F File Offset: 0x00041A4F
		public unsafe bool bKuroSceneTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) & UMaterial.__PropertyMask_bKuroSceneTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroSceneTranslucency) & ~UMaterial.__PropertyMask_bKuroSceneTranslucency) | (value ? UMaterial.__PropertyMask_bKuroSceneTranslucency : 0));
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x0004387F File Offset: 0x00041A7F
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x00043898 File Offset: 0x00041A98
		public unsafe bool bKuroTranslucencyWaterMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) & UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWaterMasked) & ~UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked) | (value ? UMaterial.__PropertyMask_bKuroTranslucencyWaterMasked : 0));
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x000438C8 File Offset: 0x00041AC8
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x000438E1 File Offset: 0x00041AE1
		public unsafe bool bKuroVolumeCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) & UMaterial.__PropertyMask_bKuroVolumeCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroVolumeCloud) & ~UMaterial.__PropertyMask_bKuroVolumeCloud) | (value ? UMaterial.__PropertyMask_bKuroVolumeCloud : 0));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x00043911 File Offset: 0x00041B11
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x0004392A File Offset: 0x00041B2A
		public unsafe bool bKuroDownsampleTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) & UMaterial.__PropertyMask_bKuroDownsampleTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroDownsampleTranslucency) & ~UMaterial.__PropertyMask_bKuroDownsampleTranslucency) | (value ? UMaterial.__PropertyMask_bKuroDownsampleTranslucency : 0));
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x0004395A File Offset: 0x00041B5A
		// (set) Token: 0x06002FF8 RID: 12280 RVA: 0x00043973 File Offset: 0x00041B73
		public unsafe bool bKuroTranslucencyWriteDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) & UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroTranslucencyWriteDepth) & ~UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth) | (value ? UMaterial.__PropertyMask_bKuroTranslucencyWriteDepth : 0));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002FF9 RID: 12281 RVA: 0x000439A3 File Offset: 0x00041BA3
		// (set) Token: 0x06002FFA RID: 12282 RVA: 0x000439BC File Offset: 0x00041BBC
		public unsafe bool bKuroFakeDecalStencil
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) & UMaterial.__PropertyMask_bKuroFakeDecalStencil) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroFakeDecalStencil) & ~UMaterial.__PropertyMask_bKuroFakeDecalStencil) | (value ? UMaterial.__PropertyMask_bKuroFakeDecalStencil : 0));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x000439EC File Offset: 0x00041BEC
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x00043A05 File Offset: 0x00041C05
		public unsafe bool bUsedWithOutline
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) & UMaterial.__PropertyMask_bUsedWithOutline) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithOutline) & ~UMaterial.__PropertyMask_bUsedWithOutline) | (value ? UMaterial.__PropertyMask_bUsedWithOutline : 0));
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x00043A35 File Offset: 0x00041C35
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x00043A4E File Offset: 0x00041C4E
		public unsafe bool bUsedWithStencilOnlyWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) & UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStencilOnlyWrite) & ~UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite) | (value ? UMaterial.__PropertyMask_bUsedWithStencilOnlyWrite : 0));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x00043A7E File Offset: 0x00041C7E
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x00043A97 File Offset: 0x00041C97
		public unsafe bool bUsedWithFaceShadowMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) & UMaterial.__PropertyMask_bUsedWithFaceShadowMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithFaceShadowMesh) & ~UMaterial.__PropertyMask_bUsedWithFaceShadowMesh) | (value ? UMaterial.__PropertyMask_bUsedWithFaceShadowMesh : 0));
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x00043AC7 File Offset: 0x00041CC7
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x00043AE0 File Offset: 0x00041CE0
		public unsafe bool bUsedWithEmpty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) & UMaterial.__PropertyMask_bUsedWithEmpty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEmpty) & ~UMaterial.__PropertyMask_bUsedWithEmpty) | (value ? UMaterial.__PropertyMask_bUsedWithEmpty : 0));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x00043B10 File Offset: 0x00041D10
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x00043B29 File Offset: 0x00041D29
		public unsafe bool bUsedForGenerate2DMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) & UMaterial.__PropertyMask_bUsedForGenerate2DMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedForGenerate2DMap) & ~UMaterial.__PropertyMask_bUsedForGenerate2DMap) | (value ? UMaterial.__PropertyMask_bUsedForGenerate2DMap : 0));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x00043B59 File Offset: 0x00041D59
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00043B69 File Offset: 0x00041D69
		public unsafe byte Generate2DMapStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Generate2DMapStencil);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Generate2DMapStencil) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x00043B7A File Offset: 0x00041D7A
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x00043B93 File Offset: 0x00041D93
		public unsafe bool bLandscapeMaterialWithHoles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) & UMaterial.__PropertyMask_bLandscapeMaterialWithHoles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bLandscapeMaterialWithHoles) & ~UMaterial.__PropertyMask_bLandscapeMaterialWithHoles) | (value ? UMaterial.__PropertyMask_bLandscapeMaterialWithHoles : 0));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x00043BC3 File Offset: 0x00041DC3
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x00043BDC File Offset: 0x00041DDC
		public unsafe bool bCompileRuntimeVirtualTextureVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCompileRuntimeVirtualTextureVariant) & ~UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant) | (value ? UMaterial.__PropertyMask_bCompileRuntimeVirtualTextureVariant : 0));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x00043C0C File Offset: 0x00041E0C
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x00043C25 File Offset: 0x00041E25
		public unsafe bool bBakeImposter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) & UMaterial.__PropertyMask_bBakeImposter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bBakeImposter) & ~UMaterial.__PropertyMask_bBakeImposter) | (value ? UMaterial.__PropertyMask_bBakeImposter : 0));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x00043C55 File Offset: 0x00041E55
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x00043C6E File Offset: 0x00041E6E
		public unsafe bool bUsedWithHLODVertexCompression
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) & UMaterial.__PropertyMask_bUsedWithHLODVertexCompression) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHLODVertexCompression) & ~UMaterial.__PropertyMask_bUsedWithHLODVertexCompression) | (value ? UMaterial.__PropertyMask_bUsedWithHLODVertexCompression : 0));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x00043C9E File Offset: 0x00041E9E
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x00043CB7 File Offset: 0x00041EB7
		public unsafe bool bHasPreDepthPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) & UMaterial.__PropertyMask_bHasPreDepthPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasPreDepthPass) & ~UMaterial.__PropertyMask_bHasPreDepthPass) | (value ? UMaterial.__PropertyMask_bHasPreDepthPass : 0));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x00043CE7 File Offset: 0x00041EE7
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x00043D00 File Offset: 0x00041F00
		public unsafe bool bMobileNoPreDepthPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) & UMaterial.__PropertyMask_bMobileNoPreDepthPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bMobileNoPreDepthPass) & ~UMaterial.__PropertyMask_bMobileNoPreDepthPass) | (value ? UMaterial.__PropertyMask_bMobileNoPreDepthPass : 0));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x00043D30 File Offset: 0x00041F30
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x00043D49 File Offset: 0x00041F49
		public unsafe bool bDrawPreDepthOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) & UMaterial.__PropertyMask_bDrawPreDepthOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDrawPreDepthOnly) & ~UMaterial.__PropertyMask_bDrawPreDepthOnly) | (value ? UMaterial.__PropertyMask_bDrawPreDepthOnly : 0));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x00043D79 File Offset: 0x00041F79
		// (set) Token: 0x06003016 RID: 12310 RVA: 0x00043D92 File Offset: 0x00041F92
		public unsafe bool bHasDataDistortionPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) & UMaterial.__PropertyMask_bHasDataDistortionPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasDataDistortionPass) & ~UMaterial.__PropertyMask_bHasDataDistortionPass) | (value ? UMaterial.__PropertyMask_bHasDataDistortionPass : 0));
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x00043DC2 File Offset: 0x00041FC2
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x00043DDB File Offset: 0x00041FDB
		public unsafe bool bHasCustomWPOVariant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) & UMaterial.__PropertyMask_bHasCustomWPOVariant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bHasCustomWPOVariant) & ~UMaterial.__PropertyMask_bHasCustomWPOVariant) | (value ? UMaterial.__PropertyMask_bHasCustomWPOVariant : 0));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x00043E0B File Offset: 0x0004200B
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x00043E24 File Offset: 0x00042024
		public unsafe bool DissolveInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) & UMaterial.__PropertyMask_DissolveInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DissolveInBurst) & ~UMaterial.__PropertyMask_DissolveInBurst) | (value ? UMaterial.__PropertyMask_DissolveInBurst : 0));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x00043E54 File Offset: 0x00042054
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x00043E6D File Offset: 0x0004206D
		public unsafe bool WaterDissolveInBurst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) & UMaterial.__PropertyMask_WaterDissolveInBurst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_WaterDissolveInBurst) & ~UMaterial.__PropertyMask_WaterDissolveInBurst) | (value ? UMaterial.__PropertyMask_WaterDissolveInBurst : 0));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x00043E9D File Offset: 0x0004209D
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x00043EAD File Offset: 0x000420AD
		public unsafe byte ToonCustomStencilTestBit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ToonCustomStencilTestBit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ToonCustomStencilTestBit) = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x00043EBE File Offset: 0x000420BE
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00043ED7 File Offset: 0x000420D7
		public unsafe bool bEffectSpaceWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) & UMaterial.__PropertyMask_bEffectSpaceWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceWrite) & ~UMaterial.__PropertyMask_bEffectSpaceWrite) | (value ? UMaterial.__PropertyMask_bEffectSpaceWrite : 0));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00043F07 File Offset: 0x00042107
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00043F20 File Offset: 0x00042120
		public unsafe bool bEffectSpaceRead
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) & UMaterial.__PropertyMask_bEffectSpaceRead) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEffectSpaceRead) & ~UMaterial.__PropertyMask_bEffectSpaceRead) | (value ? UMaterial.__PropertyMask_bEffectSpaceRead : 0));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00043F50 File Offset: 0x00042150
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x00043F69 File Offset: 0x00042169
		public unsafe bool bXRayBodyStencil
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) & UMaterial.__PropertyMask_bXRayBodyStencil) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bXRayBodyStencil) & ~UMaterial.__PropertyMask_bXRayBodyStencil) | (value ? UMaterial.__PropertyMask_bXRayBodyStencil : 0));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x00043F99 File Offset: 0x00042199
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x00043FB2 File Offset: 0x000421B2
		public unsafe bool bRenderInKuroVolumetricLightColorMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) & UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderInKuroVolumetricLightColorMask) & ~UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask) | (value ? UMaterial.__PropertyMask_bRenderInKuroVolumetricLightColorMask : 0));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x00043FE2 File Offset: 0x000421E2
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x00043FFB File Offset: 0x000421FB
		public unsafe bool bKuroBlendWaterTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) & UMaterial.__PropertyMask_bKuroBlendWaterTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bKuroBlendWaterTranslucency) & ~UMaterial.__PropertyMask_bKuroBlendWaterTranslucency) | (value ? UMaterial.__PropertyMask_bKuroBlendWaterTranslucency : 0));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x0004402B File Offset: 0x0004222B
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00044044 File Offset: 0x00042244
		public unsafe bool bSupportsUBInstancing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) & UMaterial.__PropertyMask_bSupportsUBInstancing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsUBInstancing) & ~UMaterial.__PropertyMask_bSupportsUBInstancing) | (value ? UMaterial.__PropertyMask_bSupportsUBInstancing : 0));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x00044074 File Offset: 0x00042274
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x0004408D File Offset: 0x0004228D
		public unsafe bool bSupportsDrawMaterialToRT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) & UMaterial.__PropertyMask_bSupportsDrawMaterialToRT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportsDrawMaterialToRT) & ~UMaterial.__PropertyMask_bSupportsDrawMaterialToRT) | (value ? UMaterial.__PropertyMask_bSupportsDrawMaterialToRT : 0));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000440BD File Offset: 0x000422BD
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x000440D6 File Offset: 0x000422D6
		public unsafe bool bUsedWithEditorCompositing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) & UMaterial.__PropertyMask_bUsedWithEditorCompositing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithEditorCompositing) & ~UMaterial.__PropertyMask_bUsedWithEditorCompositing) | (value ? UMaterial.__PropertyMask_bUsedWithEditorCompositing : 0));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00044106 File Offset: 0x00042306
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x0004411F File Offset: 0x0004231F
		public unsafe bool bUsedWithParticleSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) & UMaterial.__PropertyMask_bUsedWithParticleSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithParticleSprites) & ~UMaterial.__PropertyMask_bUsedWithParticleSprites) | (value ? UMaterial.__PropertyMask_bUsedWithParticleSprites : 0));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x0004414F File Offset: 0x0004234F
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00044168 File Offset: 0x00042368
		public unsafe bool bUsedWithBeamTrails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) & UMaterial.__PropertyMask_bUsedWithBeamTrails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithBeamTrails) & ~UMaterial.__PropertyMask_bUsedWithBeamTrails) | (value ? UMaterial.__PropertyMask_bUsedWithBeamTrails : 0));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00044198 File Offset: 0x00042398
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x000441B1 File Offset: 0x000423B1
		public unsafe bool bUsedWithMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) & UMaterial.__PropertyMask_bUsedWithMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMeshParticles) & ~UMaterial.__PropertyMask_bUsedWithMeshParticles) | (value ? UMaterial.__PropertyMask_bUsedWithMeshParticles : 0));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x000441E1 File Offset: 0x000423E1
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x000441FA File Offset: 0x000423FA
		public unsafe bool bUsedWithNiagaraSprites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) & UMaterial.__PropertyMask_bUsedWithNiagaraSprites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraSprites) & ~UMaterial.__PropertyMask_bUsedWithNiagaraSprites) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraSprites : 0));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x0004422A File Offset: 0x0004242A
		// (set) Token: 0x06003038 RID: 12344 RVA: 0x00044243 File Offset: 0x00042443
		public unsafe bool bUsedWithNiagaraRibbons
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) & UMaterial.__PropertyMask_bUsedWithNiagaraRibbons) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraRibbons) & ~UMaterial.__PropertyMask_bUsedWithNiagaraRibbons) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraRibbons : 0));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x00044273 File Offset: 0x00042473
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x0004428C File Offset: 0x0004248C
		public unsafe bool bUsedWithNiagaraMeshParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) & UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNiagaraMeshParticles) & ~UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles) | (value ? UMaterial.__PropertyMask_bUsedWithNiagaraMeshParticles : 0));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x000442BC File Offset: 0x000424BC
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x000442D5 File Offset: 0x000424D5
		public unsafe bool bUsedWithGeometryCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) & UMaterial.__PropertyMask_bUsedWithGeometryCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCache) & ~UMaterial.__PropertyMask_bUsedWithGeometryCache) | (value ? UMaterial.__PropertyMask_bUsedWithGeometryCache : 0));
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x00044305 File Offset: 0x00042505
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x0004431E File Offset: 0x0004251E
		public unsafe bool bUsedWithStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) & UMaterial.__PropertyMask_bUsedWithStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithStaticLighting) & ~UMaterial.__PropertyMask_bUsedWithStaticLighting) | (value ? UMaterial.__PropertyMask_bUsedWithStaticLighting : 0));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x0004434E File Offset: 0x0004254E
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x00044367 File Offset: 0x00042567
		public unsafe bool bUsedWithMorphTargets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) & UMaterial.__PropertyMask_bUsedWithMorphTargets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMorphTargets) & ~UMaterial.__PropertyMask_bUsedWithMorphTargets) | (value ? UMaterial.__PropertyMask_bUsedWithMorphTargets : 0));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x00044397 File Offset: 0x00042597
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x000443B0 File Offset: 0x000425B0
		public unsafe bool bUsedWithSplineMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) & UMaterial.__PropertyMask_bUsedWithSplineMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithSplineMeshes) & ~UMaterial.__PropertyMask_bUsedWithSplineMeshes) | (value ? UMaterial.__PropertyMask_bUsedWithSplineMeshes : 0));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x000443E0 File Offset: 0x000425E0
		// (set) Token: 0x06003044 RID: 12356 RVA: 0x000443F9 File Offset: 0x000425F9
		public unsafe bool bUsedWithInstancedStaticMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) & UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithInstancedStaticMeshes) & ~UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes) | (value ? UMaterial.__PropertyMask_bUsedWithInstancedStaticMeshes : 0));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x00044429 File Offset: 0x00042629
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x00044442 File Offset: 0x00042642
		public unsafe bool bUsedWithGeometryCollections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) & UMaterial.__PropertyMask_bUsedWithGeometryCollections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithGeometryCollections) & ~UMaterial.__PropertyMask_bUsedWithGeometryCollections) | (value ? UMaterial.__PropertyMask_bUsedWithGeometryCollections : 0));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x00044472 File Offset: 0x00042672
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x0004448B File Offset: 0x0004268B
		public unsafe bool bUsesDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) & UMaterial.__PropertyMask_bUsesDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsesDistortion) & ~UMaterial.__PropertyMask_bUsesDistortion) | (value ? UMaterial.__PropertyMask_bUsesDistortion : 0));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x000444BB File Offset: 0x000426BB
		// (set) Token: 0x0600304A RID: 12362 RVA: 0x000444D4 File Offset: 0x000426D4
		public unsafe bool bUsedWithClothing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) & UMaterial.__PropertyMask_bUsedWithClothing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithClothing) & ~UMaterial.__PropertyMask_bUsedWithClothing) | (value ? UMaterial.__PropertyMask_bUsedWithClothing : 0));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x00044504 File Offset: 0x00042704
		// (set) Token: 0x0600304C RID: 12364 RVA: 0x0004451D File Offset: 0x0004271D
		public unsafe bool bUsedWithWater
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) & UMaterial.__PropertyMask_bUsedWithWater) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithWater) & ~UMaterial.__PropertyMask_bUsedWithWater) | (value ? UMaterial.__PropertyMask_bUsedWithWater : 0));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x0004454D File Offset: 0x0004274D
		// (set) Token: 0x0600304E RID: 12366 RVA: 0x00044566 File Offset: 0x00042766
		public unsafe bool bUsedWithHairStrands
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) & UMaterial.__PropertyMask_bUsedWithHairStrands) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHairStrands) & ~UMaterial.__PropertyMask_bUsedWithHairStrands) | (value ? UMaterial.__PropertyMask_bUsedWithHairStrands : 0));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x00044596 File Offset: 0x00042796
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x000445AF File Offset: 0x000427AF
		public unsafe bool bUsedWithLidarPointCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) & UMaterial.__PropertyMask_bUsedWithLidarPointCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithLidarPointCloud) & ~UMaterial.__PropertyMask_bUsedWithLidarPointCloud) | (value ? UMaterial.__PropertyMask_bUsedWithLidarPointCloud : 0));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x000445DF File Offset: 0x000427DF
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x000445F8 File Offset: 0x000427F8
		public unsafe bool bUsedWithVirtualHeightfieldMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVirtualHeightfieldMesh) & ~UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh) | (value ? UMaterial.__PropertyMask_bUsedWithVirtualHeightfieldMesh : 0));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x00044628 File Offset: 0x00042828
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x00044641 File Offset: 0x00042841
		public unsafe bool bRemoveLocalVertexFactory
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) & UMaterial.__PropertyMask_bRemoveLocalVertexFactory) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRemoveLocalVertexFactory) & ~UMaterial.__PropertyMask_bRemoveLocalVertexFactory) | (value ? UMaterial.__PropertyMask_bRemoveLocalVertexFactory : 0));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x00044671 File Offset: 0x00042871
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x0004468A File Offset: 0x0004288A
		public unsafe bool bUsedWithMarchingCubes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) & UMaterial.__PropertyMask_bUsedWithMarchingCubes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithMarchingCubes) & ~UMaterial.__PropertyMask_bUsedWithMarchingCubes) | (value ? UMaterial.__PropertyMask_bUsedWithMarchingCubes : 0));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x000446BA File Offset: 0x000428BA
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x000446D3 File Offset: 0x000428D3
		public unsafe bool bUsedWithKuroCSInteractiveObject
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithKuroCSInteractiveObject) & ~UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject) | (value ? UMaterial.__PropertyMask_bUsedWithKuroCSInteractiveObject : 0));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x00044703 File Offset: 0x00042903
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x0004471C File Offset: 0x0004291C
		public unsafe bool bUsedWithNanite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) & UMaterial.__PropertyMask_bUsedWithNanite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithNanite) & ~UMaterial.__PropertyMask_bUsedWithNanite) | (value ? UMaterial.__PropertyMask_bUsedWithNanite : 0));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x0004474C File Offset: 0x0004294C
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x00044765 File Offset: 0x00042965
		public unsafe bool bUsedWithVolumetricCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) & UMaterial.__PropertyMask_bUsedWithVolumetricCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithVolumetricCloud) & ~UMaterial.__PropertyMask_bUsedWithVolumetricCloud) | (value ? UMaterial.__PropertyMask_bUsedWithVolumetricCloud : 0));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x00044795 File Offset: 0x00042995
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x000447AE File Offset: 0x000429AE
		public unsafe bool bUsedWithHeterogeneousVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) & UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithHeterogeneousVolumes) & ~UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes) | (value ? UMaterial.__PropertyMask_bUsedWithHeterogeneousVolumes : 0));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x000447DE File Offset: 0x000429DE
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x000447F7 File Offset: 0x000429F7
		public unsafe bool bUsedWithTransvoxel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) & UMaterial.__PropertyMask_bUsedWithTransvoxel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithTransvoxel) & ~UMaterial.__PropertyMask_bUsedWithTransvoxel) | (value ? UMaterial.__PropertyMask_bUsedWithTransvoxel : 0));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x00044827 File Offset: 0x00042A27
		// (set) Token: 0x06003062 RID: 12386 RVA: 0x00044840 File Offset: 0x00042A40
		public unsafe bool bUsedWithUI_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) & UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsedWithUI_DEPRECATED) & ~UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED) | (value ? UMaterial.__PropertyMask_bUsedWithUI_DEPRECATED : 0));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x00044870 File Offset: 0x00042A70
		// (set) Token: 0x06003064 RID: 12388 RVA: 0x00044889 File Offset: 0x00042A89
		public unsafe bool bAutomaticallySetUsageInEditor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) & UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutomaticallySetUsageInEditor) & ~UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor) | (value ? UMaterial.__PropertyMask_bAutomaticallySetUsageInEditor : 0));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000448B9 File Offset: 0x00042AB9
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x000448D2 File Offset: 0x00042AD2
		public unsafe bool bFullyRough
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) & UMaterial.__PropertyMask_bFullyRough) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bFullyRough) & ~UMaterial.__PropertyMask_bFullyRough) | (value ? UMaterial.__PropertyMask_bFullyRough : 0));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x00044902 File Offset: 0x00042B02
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x0004491B File Offset: 0x00042B1B
		public unsafe bool bUseFullPrecision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) & UMaterial.__PropertyMask_bUseFullPrecision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecision) & ~UMaterial.__PropertyMask_bUseFullPrecision) | (value ? UMaterial.__PropertyMask_bUseFullPrecision : 0));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0004494B File Offset: 0x00042B4B
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00044964 File Offset: 0x00042B64
		public unsafe bool bUseFullPrecisionParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) & UMaterial.__PropertyMask_bUseFullPrecisionParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseFullPrecisionParams) & ~UMaterial.__PropertyMask_bUseFullPrecisionParams) | (value ? UMaterial.__PropertyMask_bUseFullPrecisionParams : 0));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x00044994 File Offset: 0x00042B94
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x000449AD File Offset: 0x00042BAD
		public unsafe bool bUseHalfPrecisionVS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) & UMaterial.__PropertyMask_bUseHalfPrecisionVS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHalfPrecisionVS) & ~UMaterial.__PropertyMask_bUseHalfPrecisionVS) | (value ? UMaterial.__PropertyMask_bUseHalfPrecisionVS : 0));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000449DD File Offset: 0x00042BDD
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x000449F6 File Offset: 0x00042BF6
		public unsafe bool bUseLightmapDirectionality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) & UMaterial.__PropertyMask_bUseLightmapDirectionality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseLightmapDirectionality) & ~UMaterial.__PropertyMask_bUseLightmapDirectionality) | (value ? UMaterial.__PropertyMask_bUseLightmapDirectionality : 0));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x00044A26 File Offset: 0x00042C26
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x00044A3F File Offset: 0x00042C3F
		public unsafe bool bUseAlphaToCoverage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) & UMaterial.__PropertyMask_bUseAlphaToCoverage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAlphaToCoverage) & ~UMaterial.__PropertyMask_bUseAlphaToCoverage) | (value ? UMaterial.__PropertyMask_bUseAlphaToCoverage : 0));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x00044A6F File Offset: 0x00042C6F
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x00044A88 File Offset: 0x00042C88
		public unsafe bool bForwardRenderUsePreintegratedGFForSimpleIBL
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) & UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL) & ~UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL) | (value ? UMaterial.__PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL : 0));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x00044AB8 File Offset: 0x00042CB8
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x00044AD1 File Offset: 0x00042CD1
		public unsafe bool bUseHQForwardReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) & UMaterial.__PropertyMask_bUseHQForwardReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseHQForwardReflections) & ~UMaterial.__PropertyMask_bUseHQForwardReflections) | (value ? UMaterial.__PropertyMask_bUseHQForwardReflections : 0));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x00044B01 File Offset: 0x00042D01
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x00044B1A File Offset: 0x00042D1A
		public unsafe bool bUsePlanarForwardReflections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) & UMaterial.__PropertyMask_bUsePlanarForwardReflections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUsePlanarForwardReflections) & ~UMaterial.__PropertyMask_bUsePlanarForwardReflections) | (value ? UMaterial.__PropertyMask_bUsePlanarForwardReflections : 0));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x00044B4A File Offset: 0x00042D4A
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x00044B63 File Offset: 0x00042D63
		public unsafe bool bNormalCurvatureToRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) & UMaterial.__PropertyMask_bNormalCurvatureToRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bNormalCurvatureToRoughness) & ~UMaterial.__PropertyMask_bNormalCurvatureToRoughness) | (value ? UMaterial.__PropertyMask_bNormalCurvatureToRoughness : 0));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x00044B93 File Offset: 0x00042D93
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x00044BAC File Offset: 0x00042DAC
		public unsafe bool bEnableCrackFreeDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) & UMaterial.__PropertyMask_bEnableCrackFreeDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCrackFreeDisplacement) & ~UMaterial.__PropertyMask_bEnableCrackFreeDisplacement) | (value ? UMaterial.__PropertyMask_bEnableCrackFreeDisplacement : 0));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x00044BDC File Offset: 0x00042DDC
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x00044BF5 File Offset: 0x00042DF5
		public unsafe bool bEnableAdaptiveTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) & UMaterial.__PropertyMask_bEnableAdaptiveTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableAdaptiveTessellation) & ~UMaterial.__PropertyMask_bEnableAdaptiveTessellation) | (value ? UMaterial.__PropertyMask_bEnableAdaptiveTessellation : 0));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x00044C25 File Offset: 0x00042E25
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x00044C3E File Offset: 0x00042E3E
		public unsafe bool bDisableTessellationInShadowPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) & UMaterial.__PropertyMask_bDisableTessellationInShadowPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableTessellationInShadowPass) & ~UMaterial.__PropertyMask_bDisableTessellationInShadowPass) | (value ? UMaterial.__PropertyMask_bDisableTessellationInShadowPass : 0));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x00044C6E File Offset: 0x00042E6E
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x00044C87 File Offset: 0x00042E87
		public unsafe bool AllowTranslucentCustomDepthWrites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) & UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowTranslucentCustomDepthWrites) & ~UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites) | (value ? UMaterial.__PropertyMask_AllowTranslucentCustomDepthWrites : 0));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x00044CB7 File Offset: 0x00042EB7
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x00044CD0 File Offset: 0x00042ED0
		public unsafe bool AllowMobileSceneCustomDepthWrites
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) & UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_AllowMobileSceneCustomDepthWrites) & ~UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites) | (value ? UMaterial.__PropertyMask_AllowMobileSceneCustomDepthWrites : 0));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x00044D00 File Offset: 0x00042F00
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x00044D19 File Offset: 0x00042F19
		public unsafe bool bAllowFrontLayerTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) & UMaterial.__PropertyMask_bAllowFrontLayerTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowFrontLayerTranslucency) & ~UMaterial.__PropertyMask_bAllowFrontLayerTranslucency) | (value ? UMaterial.__PropertyMask_bAllowFrontLayerTranslucency : 0));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x00044D49 File Offset: 0x00042F49
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x00044D62 File Offset: 0x00042F62
		public unsafe bool Wireframe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) & UMaterial.__PropertyMask_Wireframe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_Wireframe) & ~UMaterial.__PropertyMask_Wireframe) | (value ? UMaterial.__PropertyMask_Wireframe : 0));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x00044D92 File Offset: 0x00042F92
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x00044DA6 File Offset: 0x00042FA6
		public unsafe TEnumAsByte<EMaterialShadingRate> ShadingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_ShadingRate) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x00044DBB File Offset: 0x00042FBB
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x00044DD4 File Offset: 0x00042FD4
		public unsafe bool bCanMaskedBeAssumedOpaque
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) & UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCanMaskedBeAssumedOpaque) & ~UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque) | (value ? UMaterial.__PropertyMask_bCanMaskedBeAssumedOpaque : 0));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x00044E04 File Offset: 0x00043004
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x00044E1D File Offset: 0x0004301D
		public unsafe bool bIsMasked_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) & UMaterial.__PropertyMask_bIsMasked_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMasked_DEPRECATED) & ~UMaterial.__PropertyMask_bIsMasked_DEPRECATED) | (value ? UMaterial.__PropertyMask_bIsMasked_DEPRECATED : 0));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x00044E4D File Offset: 0x0004304D
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x00044E66 File Offset: 0x00043066
		public unsafe bool bIsPreviewMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) & UMaterial.__PropertyMask_bIsPreviewMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsPreviewMaterial) & ~UMaterial.__PropertyMask_bIsPreviewMaterial) | (value ? UMaterial.__PropertyMask_bIsPreviewMaterial : 0));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x00044E96 File Offset: 0x00043096
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x00044EAF File Offset: 0x000430AF
		public unsafe bool bIsDebugMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) & UMaterial.__PropertyMask_bIsDebugMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDebugMaterial) & ~UMaterial.__PropertyMask_bIsDebugMaterial) | (value ? UMaterial.__PropertyMask_bIsDebugMaterial : 0));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x00044EDF File Offset: 0x000430DF
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x00044EF8 File Offset: 0x000430F8
		public unsafe bool bIsFunctionPreviewMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) & UMaterial.__PropertyMask_bIsFunctionPreviewMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsFunctionPreviewMaterial) & ~UMaterial.__PropertyMask_bIsFunctionPreviewMaterial) | (value ? UMaterial.__PropertyMask_bIsFunctionPreviewMaterial : 0));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x00044F28 File Offset: 0x00043128
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x00044F41 File Offset: 0x00043141
		public unsafe bool bUseMaterialAttributes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) & UMaterial.__PropertyMask_bUseMaterialAttributes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseMaterialAttributes) & ~UMaterial.__PropertyMask_bUseMaterialAttributes) | (value ? UMaterial.__PropertyMask_bUseMaterialAttributes : 0));
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x00044F71 File Offset: 0x00043171
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x00044F8A File Offset: 0x0004318A
		public unsafe bool bCastRayTracedShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) & UMaterial.__PropertyMask_bCastRayTracedShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRayTracedShadows) & ~UMaterial.__PropertyMask_bCastRayTracedShadows) | (value ? UMaterial.__PropertyMask_bCastRayTracedShadows : 0));
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x00044FBA File Offset: 0x000431BA
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x00044FD3 File Offset: 0x000431D3
		public unsafe bool bCastRasterShadowsInRaytracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) & UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCastRasterShadowsInRaytracing) & ~UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing) | (value ? UMaterial.__PropertyMask_bCastRasterShadowsInRaytracing : 0));
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x00045003 File Offset: 0x00043203
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x0004501C File Offset: 0x0004321C
		public unsafe bool bDisableCastDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) & UMaterial.__PropertyMask_bDisableCastDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bDisableCastDynamicShadows) & ~UMaterial.__PropertyMask_bDisableCastDynamicShadows) | (value ? UMaterial.__PropertyMask_bDisableCastDynamicShadows : 0));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x0004504C File Offset: 0x0004324C
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00045065 File Offset: 0x00043265
		public unsafe bool bUseShadowPixelDepthOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) & UMaterial.__PropertyMask_bUseShadowPixelDepthOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseShadowPixelDepthOffset) & ~UMaterial.__PropertyMask_bUseShadowPixelDepthOffset) | (value ? UMaterial.__PropertyMask_bUseShadowPixelDepthOffset : 0));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x00045095 File Offset: 0x00043295
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x000450AE File Offset: 0x000432AE
		public unsafe bool bUseTranslucencyVertexFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) & UMaterial.__PropertyMask_bUseTranslucencyVertexFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyVertexFog) & ~UMaterial.__PropertyMask_bUseTranslucencyVertexFog) | (value ? UMaterial.__PropertyMask_bUseTranslucencyVertexFog : 0));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000450DE File Offset: 0x000432DE
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x000450F7 File Offset: 0x000432F7
		public unsafe bool bUseTranslucencyEffectVertexFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) & UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseTranslucencyEffectVertexFog) & ~UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog) | (value ? UMaterial.__PropertyMask_bUseTranslucencyEffectVertexFog : 0));
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x00045127 File Offset: 0x00043327
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00045140 File Offset: 0x00043340
		public unsafe bool bApplyCloudFogging
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) & UMaterial.__PropertyMask_bApplyCloudFogging) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bApplyCloudFogging) & ~UMaterial.__PropertyMask_bApplyCloudFogging) | (value ? UMaterial.__PropertyMask_bApplyCloudFogging : 0));
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x00045170 File Offset: 0x00043370
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00045189 File Offset: 0x00043389
		public unsafe bool bIsSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) & UMaterial.__PropertyMask_bIsSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsSky) & ~UMaterial.__PropertyMask_bIsSky) | (value ? UMaterial.__PropertyMask_bIsSky : 0));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000451B9 File Offset: 0x000433B9
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x000451D2 File Offset: 0x000433D2
		public unsafe bool bSupportRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) & UMaterial.__PropertyMask_bSupportRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bSupportRayTracing) & ~UMaterial.__PropertyMask_bSupportRayTracing) | (value ? UMaterial.__PropertyMask_bSupportRayTracing : 0));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x00045202 File Offset: 0x00043402
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x0004521B File Offset: 0x0004341B
		public unsafe bool bAutoSupportRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) & UMaterial.__PropertyMask_bAutoSupportRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAutoSupportRayTracing) & ~UMaterial.__PropertyMask_bAutoSupportRayTracing) | (value ? UMaterial.__PropertyMask_bAutoSupportRayTracing : 0));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x0004524B File Offset: 0x0004344B
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00045264 File Offset: 0x00043464
		public unsafe bool DisableNPCOptimiAsRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) & UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_DisableNPCOptimiAsRayTracing) & ~UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing) | (value ? UMaterial.__PropertyMask_DisableNPCOptimiAsRayTracing : 0));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x00045294 File Offset: 0x00043494
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x000452AD File Offset: 0x000434AD
		public unsafe bool bUseAsRaytracedSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) & UMaterial.__PropertyMask_bUseAsRaytracedSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bUseAsRaytracedSky) & ~UMaterial.__PropertyMask_bUseAsRaytracedSky) | (value ? UMaterial.__PropertyMask_bUseAsRaytracedSky : 0));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000452DD File Offset: 0x000434DD
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x000452F6 File Offset: 0x000434F6
		public unsafe bool bComputeFogPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) & UMaterial.__PropertyMask_bComputeFogPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bComputeFogPerPixel) & ~UMaterial.__PropertyMask_bComputeFogPerPixel) | (value ? UMaterial.__PropertyMask_bComputeFogPerPixel : 0));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x00045326 File Offset: 0x00043526
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x0004533F File Offset: 0x0004353F
		public unsafe bool bOutputTranslucentVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) & UMaterial.__PropertyMask_bOutputTranslucentVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOutputTranslucentVelocity) & ~UMaterial.__PropertyMask_bOutputTranslucentVelocity) | (value ? UMaterial.__PropertyMask_bOutputTranslucentVelocity : 0));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0004536F File Offset: 0x0004356F
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00045388 File Offset: 0x00043588
		public unsafe bool bIsDisableOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) & UMaterial.__PropertyMask_bIsDisableOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsDisableOutputVelocity) & ~UMaterial.__PropertyMask_bIsDisableOutputVelocity) | (value ? UMaterial.__PropertyMask_bIsDisableOutputVelocity : 0));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000453B8 File Offset: 0x000435B8
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x000453D1 File Offset: 0x000435D1
		public unsafe bool bIsMobileOutputVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) & UMaterial.__PropertyMask_bIsMobileOutputVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMobileOutputVelocity) & ~UMaterial.__PropertyMask_bIsMobileOutputVelocity) | (value ? UMaterial.__PropertyMask_bIsMobileOutputVelocity : 0));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x00045401 File Offset: 0x00043601
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x0004541A File Offset: 0x0004361A
		public unsafe bool bAllowDevelopmentShaderCompile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) & UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAllowDevelopmentShaderCompile) & ~UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile) | (value ? UMaterial.__PropertyMask_bAllowDevelopmentShaderCompile : 0));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0004544A File Offset: 0x0004364A
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x00045463 File Offset: 0x00043663
		public unsafe bool bIsMaterialEditorStatsMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) & UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsMaterialEditorStatsMaterial) & ~UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial) | (value ? UMaterial.__PropertyMask_bIsMaterialEditorStatsMaterial : 0));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x00045493 File Offset: 0x00043693
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x000454AC File Offset: 0x000436AC
		public unsafe bool BlendableOutputAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) & UMaterial.__PropertyMask_BlendableOutputAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendableOutputAlpha) & ~UMaterial.__PropertyMask_BlendableOutputAlpha) | (value ? UMaterial.__PropertyMask_BlendableOutputAlpha : 0));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x000454DC File Offset: 0x000436DC
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x000454F5 File Offset: 0x000436F5
		public unsafe bool bAdditiveBlendToSceneColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) & UMaterial.__PropertyMask_bAdditiveBlendToSceneColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bAdditiveBlendToSceneColor) & ~UMaterial.__PropertyMask_bAdditiveBlendToSceneColor) | (value ? UMaterial.__PropertyMask_bAdditiveBlendToSceneColor : 0));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x00045525 File Offset: 0x00043725
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0004553E File Offset: 0x0004373E
		public unsafe bool bEnableStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) & UMaterial.__PropertyMask_bEnableStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableStencilTest) & ~UMaterial.__PropertyMask_bEnableStencilTest) | (value ? UMaterial.__PropertyMask_bEnableStencilTest : 0));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0004556E File Offset: 0x0004376E
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x0004557E File Offset: 0x0004377E
		public unsafe byte StencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StencilRefValue) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0004558F File Offset: 0x0004378F
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x000455A8 File Offset: 0x000437A8
		public unsafe bool bEnableOfficialCustomStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableOfficialCustomStencilTest) & UMaterial.__PropertyMask_bEnableOfficialCustomStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableOfficialCustomStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableOfficialCustomStencilTest) & ~UMaterial.__PropertyMask_bEnableOfficialCustomStencilTest) | (value ? UMaterial.__PropertyMask_bEnableOfficialCustomStencilTest : 0));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000455D8 File Offset: 0x000437D8
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x000455E8 File Offset: 0x000437E8
		public unsafe byte OfficialCustomStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OfficialCustomStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_OfficialCustomStencilValue) = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000455F9 File Offset: 0x000437F9
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00045612 File Offset: 0x00043812
		public unsafe bool bInvertOfficialCustomStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bInvertOfficialCustomStencilTest) & UMaterial.__PropertyMask_bInvertOfficialCustomStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bInvertOfficialCustomStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bInvertOfficialCustomStencilTest) & ~UMaterial.__PropertyMask_bInvertOfficialCustomStencilTest) | (value ? UMaterial.__PropertyMask_bInvertOfficialCustomStencilTest : 0));
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x00045642 File Offset: 0x00043842
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0004565B File Offset: 0x0004385B
		public unsafe bool bOfficialCustomStencilOnlyBehind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOfficialCustomStencilOnlyBehind) & UMaterial.__PropertyMask_bOfficialCustomStencilOnlyBehind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOfficialCustomStencilOnlyBehind) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bOfficialCustomStencilOnlyBehind) & ~UMaterial.__PropertyMask_bOfficialCustomStencilOnlyBehind) | (value ? UMaterial.__PropertyMask_bOfficialCustomStencilOnlyBehind : 0));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0004568B File Offset: 0x0004388B
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x000456A4 File Offset: 0x000438A4
		public unsafe bool bEnableCustomStencilTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) & UMaterial.__PropertyMask_bEnableCustomStencilTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilTest) & ~UMaterial.__PropertyMask_bEnableCustomStencilTest) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilTest : 0));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x000456D4 File Offset: 0x000438D4
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x000456ED File Offset: 0x000438ED
		public unsafe bool bEnableCustomStencilDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) & UMaterial.__PropertyMask_bEnableCustomStencilDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilDepthTest) & ~UMaterial.__PropertyMask_bEnableCustomStencilDepthTest) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilDepthTest : 0));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x0004571D File Offset: 0x0004391D
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x0004572D File Offset: 0x0004392D
		public unsafe byte CustomStencilRefValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilRefValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilRefValue) = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x0004573E File Offset: 0x0004393E
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x00045757 File Offset: 0x00043957
		public unsafe bool bEnableCustomStencilWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) & UMaterial.__PropertyMask_bEnableCustomStencilWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bEnableCustomStencilWrite) & ~UMaterial.__PropertyMask_bEnableCustomStencilWrite) | (value ? UMaterial.__PropertyMask_bEnableCustomStencilWrite : 0));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x00045787 File Offset: 0x00043987
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x00045797 File Offset: 0x00043997
		public unsafe byte CustomStencilWriteValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilWriteValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_CustomStencilWriteValue) = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x000457A8 File Offset: 0x000439A8
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x000457C1 File Offset: 0x000439C1
		public unsafe bool bCustomStencilWriteOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) & UMaterial.__PropertyMask_bCustomStencilWriteOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnly) & ~UMaterial.__PropertyMask_bCustomStencilWriteOnly) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteOnly : 0));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x000457F1 File Offset: 0x000439F1
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x0004580A File Offset: 0x00043A0A
		public unsafe bool bCustomStencilWriteOnlyEnableDepthWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) & UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite) & ~UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite : 0));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0004583A File Offset: 0x00043A3A
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00045853 File Offset: 0x00043A53
		public unsafe bool bCustomStencilWriteDisableDepthTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) & UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteDisableDepthTest) & ~UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteDisableDepthTest : 0));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x00045883 File Offset: 0x00043A83
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x0004589C File Offset: 0x00043A9C
		public unsafe bool bCustomStencilWriteRenderLast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) & UMaterial.__PropertyMask_bCustomStencilWriteRenderLast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bCustomStencilWriteRenderLast) & ~UMaterial.__PropertyMask_bCustomStencilWriteRenderLast) | (value ? UMaterial.__PropertyMask_bCustomStencilWriteRenderLast : 0));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000458CC File Offset: 0x00043ACC
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x000458E5 File Offset: 0x00043AE5
		public unsafe bool bRenderOnDepthTestFail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) & UMaterial.__PropertyMask_bRenderOnDepthTestFail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bRenderOnDepthTestFail) & ~UMaterial.__PropertyMask_bRenderOnDepthTestFail) | (value ? UMaterial.__PropertyMask_bRenderOnDepthTestFail : 0));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x00045915 File Offset: 0x00043B15
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x0004592E File Offset: 0x00043B2E
		public unsafe bool bTranslucentDepthWrite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) & UMaterial.__PropertyMask_bTranslucentDepthWrite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentDepthWrite) & ~UMaterial.__PropertyMask_bTranslucentDepthWrite) | (value ? UMaterial.__PropertyMask_bTranslucentDepthWrite : 0));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x0004595E File Offset: 0x00043B5E
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x00045977 File Offset: 0x00043B77
		public unsafe bool bTranslucentPixelClip
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) & UMaterial.__PropertyMask_bTranslucentPixelClip) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bTranslucentPixelClip) & ~UMaterial.__PropertyMask_bTranslucentPixelClip) | (value ? UMaterial.__PropertyMask_bTranslucentPixelClip : 0));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000459A7 File Offset: 0x00043BA7
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x000459B7 File Offset: 0x00043BB7
		public unsafe int BlendablePriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendablePriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_BlendablePriority) = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000459C8 File Offset: 0x00043BC8
		// (set) Token: 0x060030E4 RID: 12516 RVA: 0x000459E1 File Offset: 0x00043BE1
		public unsafe bool bIsBlendable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) & UMaterial.__PropertyMask_bIsBlendable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) = ((*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_bIsBlendable) & ~UMaterial.__PropertyMask_bIsBlendable) | (value ? UMaterial.__PropertyMask_bIsBlendable : 0));
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x00045A11 File Offset: 0x00043C11
		// (set) Token: 0x060030E6 RID: 12518 RVA: 0x00045A21 File Offset: 0x00043C21
		public unsafe uint UsageFlagWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_UsageFlagWarnings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_UsageFlagWarnings) = (int)value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x00045A32 File Offset: 0x00043C32
		// (set) Token: 0x060030E8 RID: 12520 RVA: 0x00045A42 File Offset: 0x00043C42
		public unsafe float RefractionDepthBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionDepthBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_RefractionDepthBias) = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x00045A53 File Offset: 0x00043C53
		// (set) Token: 0x060030EA RID: 12522 RVA: 0x00045A67 File Offset: 0x00043C67
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x00045A7C File Offset: 0x00043C7C
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x00045A8C File Offset: 0x00043C8C
		public unsafe float MaxDisplacement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaxDisplacement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterial.__PropertyOffset_MaxDisplacement) = value;
			}
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00045A9D File Offset: 0x00043C9D
		static UMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Material");
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x00045AAB File Offset: 0x00043CAB
		protected UMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000F31 RID: 3889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Material";

		// Token: 0x04000F32 RID: 3890
		private static IntPtr _ClassPtr;

		// Token: 0x04000F33 RID: 3891
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000F34 RID: 3892
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04000F35 RID: 3893
		internal static int __PropertyOffset_PhysicalMaterialMap;

		// Token: 0x04000F36 RID: 3894
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UPhysicalMaterial> _PhysicalMaterialMap;

		// Token: 0x04000F37 RID: 3895
		internal static int __PropertyOffset_MaterialReceiveDecal;

		// Token: 0x04000F38 RID: 3896
		internal static byte __PropertyMask_MaterialReceiveDecal;

		// Token: 0x04000F39 RID: 3897
		internal static int __PropertyOffset_bCastDynamicShadowAsMasked;

		// Token: 0x04000F3A RID: 3898
		internal static byte __PropertyMask_bCastDynamicShadowAsMasked;

		// Token: 0x04000F3B RID: 3899
		internal static int __PropertyOffset_OpacityMaskClipValue;

		// Token: 0x04000F3C RID: 3900
		internal static int __PropertyOffset_bEnableSeparateTranslucency;

		// Token: 0x04000F3D RID: 3901
		internal static byte __PropertyMask_bEnableSeparateTranslucency;

		// Token: 0x04000F3E RID: 3902
		internal static int __PropertyOffset_bEnableResponsiveAA;

		// Token: 0x04000F3F RID: 3903
		internal static byte __PropertyMask_bEnableResponsiveAA;

		// Token: 0x04000F40 RID: 3904
		internal static int __PropertyOffset_bScreenSpaceReflections;

		// Token: 0x04000F41 RID: 3905
		internal static byte __PropertyMask_bScreenSpaceReflections;

		// Token: 0x04000F42 RID: 3906
		internal static int __PropertyOffset_bContactShadows;

		// Token: 0x04000F43 RID: 3907
		internal static byte __PropertyMask_bContactShadows;

		// Token: 0x04000F44 RID: 3908
		internal static int __PropertyOffset_bTranslucencyReceiveLightFunctionShadow;

		// Token: 0x04000F45 RID: 3909
		internal static byte __PropertyMask_bTranslucencyReceiveLightFunctionShadow;

		// Token: 0x04000F46 RID: 3910
		internal static int __PropertyOffset_TwoSided;

		// Token: 0x04000F47 RID: 3911
		internal static byte __PropertyMask_TwoSided;

		// Token: 0x04000F48 RID: 3912
		internal static int __PropertyOffset_KuroWater;

		// Token: 0x04000F49 RID: 3913
		internal static byte __PropertyMask_KuroWater;

		// Token: 0x04000F4A RID: 3914
		internal static int __PropertyOffset_BackFace;

		// Token: 0x04000F4B RID: 3915
		internal static byte __PropertyMask_BackFace;

		// Token: 0x04000F4C RID: 3916
		internal static int __PropertyOffset_bSceneDissolveEnable;

		// Token: 0x04000F4D RID: 3917
		internal static byte __PropertyMask_bSceneDissolveEnable;

		// Token: 0x04000F4E RID: 3918
		internal static int __PropertyOffset_bSceneColorClearEnable;

		// Token: 0x04000F4F RID: 3919
		internal static byte __PropertyMask_bSceneColorClearEnable;

		// Token: 0x04000F50 RID: 3920
		internal static int __PropertyOffset_RenderQueue;

		// Token: 0x04000F51 RID: 3921
		internal static int __PropertyOffset_bDisableShadowCacheForSPDO;

		// Token: 0x04000F52 RID: 3922
		internal static byte __PropertyMask_bDisableShadowCacheForSPDO;

		// Token: 0x04000F53 RID: 3923
		internal static int __PropertyOffset_bSinglelayerWaterWriteDepth;

		// Token: 0x04000F54 RID: 3924
		internal static byte __PropertyMask_bSinglelayerWaterWriteDepth;

		// Token: 0x04000F55 RID: 3925
		internal static int __PropertyOffset_bSingleLayerWaterMobileDesaturation;

		// Token: 0x04000F56 RID: 3926
		internal static byte __PropertyMask_bSingleLayerWaterMobileDesaturation;

		// Token: 0x04000F57 RID: 3927
		internal static int __PropertyOffset_bDrawRTWithRGBA;

		// Token: 0x04000F58 RID: 3928
		internal static byte __PropertyMask_bDrawRTWithRGBA;

		// Token: 0x04000F59 RID: 3929
		internal static int __PropertyOffset_bRenderInCustomCapturePass;

		// Token: 0x04000F5A RID: 3930
		internal static byte __PropertyMask_bRenderInCustomCapturePass;

		// Token: 0x04000F5B RID: 3931
		internal static int __PropertyOffset_bRenderInGodRayPass;

		// Token: 0x04000F5C RID: 3932
		internal static byte __PropertyMask_bRenderInGodRayPass;

		// Token: 0x04000F5D RID: 3933
		internal static int __PropertyOffset_bMaskedRenderInPreDepth;

		// Token: 0x04000F5E RID: 3934
		internal static byte __PropertyMask_bMaskedRenderInPreDepth;

		// Token: 0x04000F5F RID: 3935
		internal static int __PropertyOffset_bMaskedRenderInPreDepth_PC;

		// Token: 0x04000F60 RID: 3936
		internal static byte __PropertyMask_bMaskedRenderInPreDepth_PC;

		// Token: 0x04000F61 RID: 3937
		internal static int __PropertyOffset_bSupportMobileHighQuality;

		// Token: 0x04000F62 RID: 3938
		internal static byte __PropertyMask_bSupportMobileHighQuality;

		// Token: 0x04000F63 RID: 3939
		internal static int __PropertyOffset_bCustomAlphaTest;

		// Token: 0x04000F64 RID: 3940
		internal static byte __PropertyMask_bCustomAlphaTest;

		// Token: 0x04000F65 RID: 3941
		internal static int __PropertyOffset_bEnableBattle;

		// Token: 0x04000F66 RID: 3942
		internal static byte __PropertyMask_bEnableBattle;

		// Token: 0x04000F67 RID: 3943
		internal static int __PropertyOffset_bEnableBattleMask;

		// Token: 0x04000F68 RID: 3944
		internal static byte __PropertyMask_bEnableBattleMask;

		// Token: 0x04000F69 RID: 3945
		internal static int __PropertyOffset_bIsCharacterHairMat;

		// Token: 0x04000F6A RID: 3946
		internal static byte __PropertyMask_bIsCharacterHairMat;

		// Token: 0x04000F6B RID: 3947
		internal static int __PropertyOffset_bIsCharacterHETMat;

		// Token: 0x04000F6C RID: 3948
		internal static byte __PropertyMask_bIsCharacterHETMat;

		// Token: 0x04000F6D RID: 3949
		internal static int __PropertyOffset_bHETMatOnlyUsedPlayer;

		// Token: 0x04000F6E RID: 3950
		internal static int __PropertyOffset_bIsUsedWithWriteStencil;

		// Token: 0x04000F6F RID: 3951
		internal static int __PropertyOffset_bRenderToonFFT;

		// Token: 0x04000F70 RID: 3952
		internal static byte __PropertyMask_bRenderToonFFT;

		// Token: 0x04000F71 RID: 3953
		internal static int __PropertyOffset_bRenderTranslucentOpacity;

		// Token: 0x04000F72 RID: 3954
		internal static byte __PropertyMask_bRenderTranslucentOpacity;

		// Token: 0x04000F73 RID: 3955
		internal static int __PropertyOffset_bForceSceneTranslucentOpacity;

		// Token: 0x04000F74 RID: 3956
		internal static byte __PropertyMask_bForceSceneTranslucentOpacity;

		// Token: 0x04000F75 RID: 3957
		internal static int __PropertyOffset_bForceFightTranslucentOpacity;

		// Token: 0x04000F76 RID: 3958
		internal static byte __PropertyMask_bForceFightTranslucentOpacity;

		// Token: 0x04000F77 RID: 3959
		internal static int __PropertyOffset_ExtendedHETDistance;

		// Token: 0x04000F78 RID: 3960
		internal static int __PropertyOffset_bUseMobileDistortion;

		// Token: 0x04000F79 RID: 3961
		internal static byte __PropertyMask_bUseMobileDistortion;

		// Token: 0x04000F7A RID: 3962
		internal static int __PropertyOffset_bLGUIMaterial;

		// Token: 0x04000F7B RID: 3963
		internal static byte __PropertyMask_bLGUIMaterial;

		// Token: 0x04000F7C RID: 3964
		internal static int __PropertyOffset_bLGUIMaterialDrawBeforeUpScale;

		// Token: 0x04000F7D RID: 3965
		internal static byte __PropertyMask_bLGUIMaterialDrawBeforeUpScale;

		// Token: 0x04000F7E RID: 3966
		internal static int __PropertyOffset_bLGUISkipDepth;

		// Token: 0x04000F7F RID: 3967
		internal static byte __PropertyMask_bLGUISkipDepth;

		// Token: 0x04000F80 RID: 3968
		internal static int __PropertyOffset_bTranslucencyUse3xPCF;

		// Token: 0x04000F81 RID: 3969
		internal static byte __PropertyMask_bTranslucencyUse3xPCF;

		// Token: 0x04000F82 RID: 3970
		internal static int __PropertyOffset_bTranslucencyIBLUseCustomdataRoughness;

		// Token: 0x04000F83 RID: 3971
		internal static byte __PropertyMask_bTranslucencyIBLUseCustomdataRoughness;

		// Token: 0x04000F84 RID: 3972
		internal static int __PropertyOffset_bTranslucencyReceiveShadowMobile;

		// Token: 0x04000F85 RID: 3973
		internal static byte __PropertyMask_bTranslucencyReceiveShadowMobile;

		// Token: 0x04000F86 RID: 3974
		internal static int __PropertyOffset_bVolumeDirectionalLightTint;

		// Token: 0x04000F87 RID: 3975
		internal static byte __PropertyMask_bVolumeDirectionalLightTint;

		// Token: 0x04000F88 RID: 3976
		internal static int __PropertyOffset_DitheredLODTransition;

		// Token: 0x04000F89 RID: 3977
		internal static byte __PropertyMask_DitheredLODTransition;

		// Token: 0x04000F8A RID: 3978
		internal static int __PropertyOffset_DitherOpacityMask;

		// Token: 0x04000F8B RID: 3979
		internal static byte __PropertyMask_DitherOpacityMask;

		// Token: 0x04000F8C RID: 3980
		internal static int __PropertyOffset_bAllowNegativeEmissiveColor;

		// Token: 0x04000F8D RID: 3981
		internal static byte __PropertyMask_bAllowNegativeEmissiveColor;

		// Token: 0x04000F8E RID: 3982
		internal static int __PropertyOffset_bEnableMobileSeparateTranslucency;

		// Token: 0x04000F8F RID: 3983
		internal static byte __PropertyMask_bEnableMobileSeparateTranslucency;

		// Token: 0x04000F90 RID: 3984
		internal static int __PropertyOffset_bUseNormalDither;

		// Token: 0x04000F91 RID: 3985
		internal static byte __PropertyMask_bUseNormalDither;

		// Token: 0x04000F92 RID: 3986
		internal static int __PropertyOffset_NormalDitherScale;

		// Token: 0x04000F93 RID: 3987
		internal static int __PropertyOffset_WPORTCullDistScale;

		// Token: 0x04000F94 RID: 3988
		internal static int __PropertyOffset_NumCustomizedUVs;

		// Token: 0x04000F95 RID: 3989
		internal static int __PropertyOffset_TranslucencyDirectionalLightingIntensity;

		// Token: 0x04000F96 RID: 3990
		internal static int __PropertyOffset_TranslucentShadowDensityScale;

		// Token: 0x04000F97 RID: 3991
		internal static int __PropertyOffset_TranslucentSelfShadowDensityScale;

		// Token: 0x04000F98 RID: 3992
		internal static int __PropertyOffset_TranslucentSelfShadowSecondDensityScale;

		// Token: 0x04000F99 RID: 3993
		internal static int __PropertyOffset_TranslucentSelfShadowSecondOpacity;

		// Token: 0x04000F9A RID: 3994
		internal static int __PropertyOffset_TranslucentBackscatteringExponent;

		// Token: 0x04000F9B RID: 3995
		internal static int __PropertyOffset_TranslucentMultipleScatteringExtinction;

		// Token: 0x04000F9C RID: 3996
		internal static int __PropertyOffset_TranslucentShadowStartOffset;

		// Token: 0x04000F9D RID: 3997
		internal static int __PropertyOffset_bDisableDepthTest;

		// Token: 0x04000F9E RID: 3998
		internal static byte __PropertyMask_bDisableDepthTest;

		// Token: 0x04000F9F RID: 3999
		internal static int __PropertyOffset_bWriteOnlyAlpha;

		// Token: 0x04000FA0 RID: 4000
		internal static byte __PropertyMask_bWriteOnlyAlpha;

		// Token: 0x04000FA1 RID: 4001
		internal static int __PropertyOffset_bGenerateSphericalParticleNormals;

		// Token: 0x04000FA2 RID: 4002
		internal static byte __PropertyMask_bGenerateSphericalParticleNormals;

		// Token: 0x04000FA3 RID: 4003
		internal static int __PropertyOffset_bTangentSpaceNormal;

		// Token: 0x04000FA4 RID: 4004
		internal static byte __PropertyMask_bTangentSpaceNormal;

		// Token: 0x04000FA5 RID: 4005
		internal static int __PropertyOffset_bUseEmissiveForDynamicAreaLighting;

		// Token: 0x04000FA6 RID: 4006
		internal static byte __PropertyMask_bUseEmissiveForDynamicAreaLighting;

		// Token: 0x04000FA7 RID: 4007
		internal static int __PropertyOffset_bBlockGI;

		// Token: 0x04000FA8 RID: 4008
		internal static byte __PropertyMask_bBlockGI;

		// Token: 0x04000FA9 RID: 4009
		internal static int __PropertyOffset_bUsedAsSpecialEngineMaterial;

		// Token: 0x04000FAA RID: 4010
		internal static byte __PropertyMask_bUsedAsSpecialEngineMaterial;

		// Token: 0x04000FAB RID: 4011
		internal static int __PropertyOffset_bUsedWithSkeletalMesh;

		// Token: 0x04000FAC RID: 4012
		internal static byte __PropertyMask_bUsedWithSkeletalMesh;

		// Token: 0x04000FAD RID: 4013
		internal static int __PropertyOffset_bUsedWithBakedBoneMesh;

		// Token: 0x04000FAE RID: 4014
		internal static byte __PropertyMask_bUsedWithBakedBoneMesh;

		// Token: 0x04000FAF RID: 4015
		internal static int __PropertyOffset_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04000FB0 RID: 4016
		internal static byte __PropertyMask_bUsedWithExpandedTexcoordsSkeletalMesh;

		// Token: 0x04000FB1 RID: 4017
		internal static int __PropertyOffset_bIsOnlyForSkeletalMesh;

		// Token: 0x04000FB2 RID: 4018
		internal static byte __PropertyMask_bIsOnlyForSkeletalMesh;

		// Token: 0x04000FB3 RID: 4019
		internal static int __PropertyOffset_bIsDisableWuYinQuLayer;

		// Token: 0x04000FB4 RID: 4020
		internal static byte __PropertyMask_bIsDisableWuYinQuLayer;

		// Token: 0x04000FB5 RID: 4021
		internal static int __PropertyOffset_bIsDisableWetLayer;

		// Token: 0x04000FB6 RID: 4022
		internal static byte __PropertyMask_bIsDisableWetLayer;

		// Token: 0x04000FB7 RID: 4023
		internal static int __PropertyOffset_bIsNoWaterForToon;

		// Token: 0x04000FB8 RID: 4024
		internal static byte __PropertyMask_bIsNoWaterForToon;

		// Token: 0x04000FB9 RID: 4025
		internal static int __PropertyOffset_bUsedWithShadowSVT;

		// Token: 0x04000FBA RID: 4026
		internal static byte __PropertyMask_bUsedWithShadowSVT;

		// Token: 0x04000FBB RID: 4027
		internal static int __PropertyOffset_bSingleLayerWaterRainDrop;

		// Token: 0x04000FBC RID: 4028
		internal static byte __PropertyMask_bSingleLayerWaterRainDrop;

		// Token: 0x04000FBD RID: 4029
		internal static int __PropertyOffset_bSingleLayerWaterSSRProxy;

		// Token: 0x04000FBE RID: 4030
		internal static byte __PropertyMask_bSingleLayerWaterSSRProxy;

		// Token: 0x04000FBF RID: 4031
		internal static int __PropertyOffset_bWriteDepthToGbuffer;

		// Token: 0x04000FC0 RID: 4032
		internal static byte __PropertyMask_bWriteDepthToGbuffer;

		// Token: 0x04000FC1 RID: 4033
		internal static int __PropertyOffset_bUseAnisotropy;

		// Token: 0x04000FC2 RID: 4034
		internal static byte __PropertyMask_bUseAnisotropy;

		// Token: 0x04000FC3 RID: 4035
		internal static int __PropertyOffset_bKuroSceneTranslucency;

		// Token: 0x04000FC4 RID: 4036
		internal static byte __PropertyMask_bKuroSceneTranslucency;

		// Token: 0x04000FC5 RID: 4037
		internal static int __PropertyOffset_bKuroTranslucencyWaterMasked;

		// Token: 0x04000FC6 RID: 4038
		internal static byte __PropertyMask_bKuroTranslucencyWaterMasked;

		// Token: 0x04000FC7 RID: 4039
		internal static int __PropertyOffset_bKuroVolumeCloud;

		// Token: 0x04000FC8 RID: 4040
		internal static byte __PropertyMask_bKuroVolumeCloud;

		// Token: 0x04000FC9 RID: 4041
		internal static int __PropertyOffset_bKuroDownsampleTranslucency;

		// Token: 0x04000FCA RID: 4042
		internal static byte __PropertyMask_bKuroDownsampleTranslucency;

		// Token: 0x04000FCB RID: 4043
		internal static int __PropertyOffset_bKuroTranslucencyWriteDepth;

		// Token: 0x04000FCC RID: 4044
		internal static byte __PropertyMask_bKuroTranslucencyWriteDepth;

		// Token: 0x04000FCD RID: 4045
		internal static int __PropertyOffset_bKuroFakeDecalStencil;

		// Token: 0x04000FCE RID: 4046
		internal static byte __PropertyMask_bKuroFakeDecalStencil;

		// Token: 0x04000FCF RID: 4047
		internal static int __PropertyOffset_bUsedWithOutline;

		// Token: 0x04000FD0 RID: 4048
		internal static byte __PropertyMask_bUsedWithOutline;

		// Token: 0x04000FD1 RID: 4049
		internal static int __PropertyOffset_bUsedWithStencilOnlyWrite;

		// Token: 0x04000FD2 RID: 4050
		internal static byte __PropertyMask_bUsedWithStencilOnlyWrite;

		// Token: 0x04000FD3 RID: 4051
		internal static int __PropertyOffset_bUsedWithFaceShadowMesh;

		// Token: 0x04000FD4 RID: 4052
		internal static byte __PropertyMask_bUsedWithFaceShadowMesh;

		// Token: 0x04000FD5 RID: 4053
		internal static int __PropertyOffset_bUsedWithEmpty;

		// Token: 0x04000FD6 RID: 4054
		internal static byte __PropertyMask_bUsedWithEmpty;

		// Token: 0x04000FD7 RID: 4055
		internal static int __PropertyOffset_bUsedForGenerate2DMap;

		// Token: 0x04000FD8 RID: 4056
		internal static byte __PropertyMask_bUsedForGenerate2DMap;

		// Token: 0x04000FD9 RID: 4057
		internal static int __PropertyOffset_Generate2DMapStencil;

		// Token: 0x04000FDA RID: 4058
		internal static int __PropertyOffset_bLandscapeMaterialWithHoles;

		// Token: 0x04000FDB RID: 4059
		internal static byte __PropertyMask_bLandscapeMaterialWithHoles;

		// Token: 0x04000FDC RID: 4060
		internal static int __PropertyOffset_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04000FDD RID: 4061
		internal static byte __PropertyMask_bCompileRuntimeVirtualTextureVariant;

		// Token: 0x04000FDE RID: 4062
		internal static int __PropertyOffset_bBakeImposter;

		// Token: 0x04000FDF RID: 4063
		internal static byte __PropertyMask_bBakeImposter;

		// Token: 0x04000FE0 RID: 4064
		internal static int __PropertyOffset_bUsedWithHLODVertexCompression;

		// Token: 0x04000FE1 RID: 4065
		internal static byte __PropertyMask_bUsedWithHLODVertexCompression;

		// Token: 0x04000FE2 RID: 4066
		internal static int __PropertyOffset_bHasPreDepthPass;

		// Token: 0x04000FE3 RID: 4067
		internal static byte __PropertyMask_bHasPreDepthPass;

		// Token: 0x04000FE4 RID: 4068
		internal static int __PropertyOffset_bMobileNoPreDepthPass;

		// Token: 0x04000FE5 RID: 4069
		internal static byte __PropertyMask_bMobileNoPreDepthPass;

		// Token: 0x04000FE6 RID: 4070
		internal static int __PropertyOffset_bDrawPreDepthOnly;

		// Token: 0x04000FE7 RID: 4071
		internal static byte __PropertyMask_bDrawPreDepthOnly;

		// Token: 0x04000FE8 RID: 4072
		internal static int __PropertyOffset_bHasDataDistortionPass;

		// Token: 0x04000FE9 RID: 4073
		internal static byte __PropertyMask_bHasDataDistortionPass;

		// Token: 0x04000FEA RID: 4074
		internal static int __PropertyOffset_bHasCustomWPOVariant;

		// Token: 0x04000FEB RID: 4075
		internal static byte __PropertyMask_bHasCustomWPOVariant;

		// Token: 0x04000FEC RID: 4076
		internal static int __PropertyOffset_DissolveInBurst;

		// Token: 0x04000FED RID: 4077
		internal static byte __PropertyMask_DissolveInBurst;

		// Token: 0x04000FEE RID: 4078
		internal static int __PropertyOffset_WaterDissolveInBurst;

		// Token: 0x04000FEF RID: 4079
		internal static byte __PropertyMask_WaterDissolveInBurst;

		// Token: 0x04000FF0 RID: 4080
		internal static int __PropertyOffset_ToonCustomStencilTestBit;

		// Token: 0x04000FF1 RID: 4081
		internal static int __PropertyOffset_bEffectSpaceWrite;

		// Token: 0x04000FF2 RID: 4082
		internal static byte __PropertyMask_bEffectSpaceWrite;

		// Token: 0x04000FF3 RID: 4083
		internal static int __PropertyOffset_bEffectSpaceRead;

		// Token: 0x04000FF4 RID: 4084
		internal static byte __PropertyMask_bEffectSpaceRead;

		// Token: 0x04000FF5 RID: 4085
		internal static int __PropertyOffset_bXRayBodyStencil;

		// Token: 0x04000FF6 RID: 4086
		internal static byte __PropertyMask_bXRayBodyStencil;

		// Token: 0x04000FF7 RID: 4087
		internal static int __PropertyOffset_bRenderInKuroVolumetricLightColorMask;

		// Token: 0x04000FF8 RID: 4088
		internal static byte __PropertyMask_bRenderInKuroVolumetricLightColorMask;

		// Token: 0x04000FF9 RID: 4089
		internal static int __PropertyOffset_bKuroBlendWaterTranslucency;

		// Token: 0x04000FFA RID: 4090
		internal static byte __PropertyMask_bKuroBlendWaterTranslucency;

		// Token: 0x04000FFB RID: 4091
		internal static int __PropertyOffset_bSupportsUBInstancing;

		// Token: 0x04000FFC RID: 4092
		internal static byte __PropertyMask_bSupportsUBInstancing;

		// Token: 0x04000FFD RID: 4093
		internal static int __PropertyOffset_bSupportsDrawMaterialToRT;

		// Token: 0x04000FFE RID: 4094
		internal static byte __PropertyMask_bSupportsDrawMaterialToRT;

		// Token: 0x04000FFF RID: 4095
		internal static int __PropertyOffset_bUsedWithEditorCompositing;

		// Token: 0x04001000 RID: 4096
		internal static byte __PropertyMask_bUsedWithEditorCompositing;

		// Token: 0x04001001 RID: 4097
		internal static int __PropertyOffset_bUsedWithParticleSprites;

		// Token: 0x04001002 RID: 4098
		internal static byte __PropertyMask_bUsedWithParticleSprites;

		// Token: 0x04001003 RID: 4099
		internal static int __PropertyOffset_bUsedWithBeamTrails;

		// Token: 0x04001004 RID: 4100
		internal static byte __PropertyMask_bUsedWithBeamTrails;

		// Token: 0x04001005 RID: 4101
		internal static int __PropertyOffset_bUsedWithMeshParticles;

		// Token: 0x04001006 RID: 4102
		internal static byte __PropertyMask_bUsedWithMeshParticles;

		// Token: 0x04001007 RID: 4103
		internal static int __PropertyOffset_bUsedWithNiagaraSprites;

		// Token: 0x04001008 RID: 4104
		internal static byte __PropertyMask_bUsedWithNiagaraSprites;

		// Token: 0x04001009 RID: 4105
		internal static int __PropertyOffset_bUsedWithNiagaraRibbons;

		// Token: 0x0400100A RID: 4106
		internal static byte __PropertyMask_bUsedWithNiagaraRibbons;

		// Token: 0x0400100B RID: 4107
		internal static int __PropertyOffset_bUsedWithNiagaraMeshParticles;

		// Token: 0x0400100C RID: 4108
		internal static byte __PropertyMask_bUsedWithNiagaraMeshParticles;

		// Token: 0x0400100D RID: 4109
		internal static int __PropertyOffset_bUsedWithGeometryCache;

		// Token: 0x0400100E RID: 4110
		internal static byte __PropertyMask_bUsedWithGeometryCache;

		// Token: 0x0400100F RID: 4111
		internal static int __PropertyOffset_bUsedWithStaticLighting;

		// Token: 0x04001010 RID: 4112
		internal static byte __PropertyMask_bUsedWithStaticLighting;

		// Token: 0x04001011 RID: 4113
		internal static int __PropertyOffset_bUsedWithMorphTargets;

		// Token: 0x04001012 RID: 4114
		internal static byte __PropertyMask_bUsedWithMorphTargets;

		// Token: 0x04001013 RID: 4115
		internal static int __PropertyOffset_bUsedWithSplineMeshes;

		// Token: 0x04001014 RID: 4116
		internal static byte __PropertyMask_bUsedWithSplineMeshes;

		// Token: 0x04001015 RID: 4117
		internal static int __PropertyOffset_bUsedWithInstancedStaticMeshes;

		// Token: 0x04001016 RID: 4118
		internal static byte __PropertyMask_bUsedWithInstancedStaticMeshes;

		// Token: 0x04001017 RID: 4119
		internal static int __PropertyOffset_bUsedWithGeometryCollections;

		// Token: 0x04001018 RID: 4120
		internal static byte __PropertyMask_bUsedWithGeometryCollections;

		// Token: 0x04001019 RID: 4121
		internal static int __PropertyOffset_bUsesDistortion;

		// Token: 0x0400101A RID: 4122
		internal static byte __PropertyMask_bUsesDistortion;

		// Token: 0x0400101B RID: 4123
		internal static int __PropertyOffset_bUsedWithClothing;

		// Token: 0x0400101C RID: 4124
		internal static byte __PropertyMask_bUsedWithClothing;

		// Token: 0x0400101D RID: 4125
		internal static int __PropertyOffset_bUsedWithWater;

		// Token: 0x0400101E RID: 4126
		internal static byte __PropertyMask_bUsedWithWater;

		// Token: 0x0400101F RID: 4127
		internal static int __PropertyOffset_bUsedWithHairStrands;

		// Token: 0x04001020 RID: 4128
		internal static byte __PropertyMask_bUsedWithHairStrands;

		// Token: 0x04001021 RID: 4129
		internal static int __PropertyOffset_bUsedWithLidarPointCloud;

		// Token: 0x04001022 RID: 4130
		internal static byte __PropertyMask_bUsedWithLidarPointCloud;

		// Token: 0x04001023 RID: 4131
		internal static int __PropertyOffset_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x04001024 RID: 4132
		internal static byte __PropertyMask_bUsedWithVirtualHeightfieldMesh;

		// Token: 0x04001025 RID: 4133
		internal static int __PropertyOffset_bRemoveLocalVertexFactory;

		// Token: 0x04001026 RID: 4134
		internal static byte __PropertyMask_bRemoveLocalVertexFactory;

		// Token: 0x04001027 RID: 4135
		internal static int __PropertyOffset_bUsedWithMarchingCubes;

		// Token: 0x04001028 RID: 4136
		internal static byte __PropertyMask_bUsedWithMarchingCubes;

		// Token: 0x04001029 RID: 4137
		internal static int __PropertyOffset_bUsedWithKuroCSInteractiveObject;

		// Token: 0x0400102A RID: 4138
		internal static byte __PropertyMask_bUsedWithKuroCSInteractiveObject;

		// Token: 0x0400102B RID: 4139
		internal static int __PropertyOffset_bUsedWithNanite;

		// Token: 0x0400102C RID: 4140
		internal static byte __PropertyMask_bUsedWithNanite;

		// Token: 0x0400102D RID: 4141
		internal static int __PropertyOffset_bUsedWithVolumetricCloud;

		// Token: 0x0400102E RID: 4142
		internal static byte __PropertyMask_bUsedWithVolumetricCloud;

		// Token: 0x0400102F RID: 4143
		internal static int __PropertyOffset_bUsedWithHeterogeneousVolumes;

		// Token: 0x04001030 RID: 4144
		internal static byte __PropertyMask_bUsedWithHeterogeneousVolumes;

		// Token: 0x04001031 RID: 4145
		internal static int __PropertyOffset_bUsedWithTransvoxel;

		// Token: 0x04001032 RID: 4146
		internal static byte __PropertyMask_bUsedWithTransvoxel;

		// Token: 0x04001033 RID: 4147
		internal static int __PropertyOffset_bUsedWithUI_DEPRECATED;

		// Token: 0x04001034 RID: 4148
		internal static byte __PropertyMask_bUsedWithUI_DEPRECATED;

		// Token: 0x04001035 RID: 4149
		internal static int __PropertyOffset_bAutomaticallySetUsageInEditor;

		// Token: 0x04001036 RID: 4150
		internal static byte __PropertyMask_bAutomaticallySetUsageInEditor;

		// Token: 0x04001037 RID: 4151
		internal static int __PropertyOffset_bFullyRough;

		// Token: 0x04001038 RID: 4152
		internal static byte __PropertyMask_bFullyRough;

		// Token: 0x04001039 RID: 4153
		internal static int __PropertyOffset_bUseFullPrecision;

		// Token: 0x0400103A RID: 4154
		internal static byte __PropertyMask_bUseFullPrecision;

		// Token: 0x0400103B RID: 4155
		internal static int __PropertyOffset_bUseFullPrecisionParams;

		// Token: 0x0400103C RID: 4156
		internal static byte __PropertyMask_bUseFullPrecisionParams;

		// Token: 0x0400103D RID: 4157
		internal static int __PropertyOffset_bUseHalfPrecisionVS;

		// Token: 0x0400103E RID: 4158
		internal static byte __PropertyMask_bUseHalfPrecisionVS;

		// Token: 0x0400103F RID: 4159
		internal static int __PropertyOffset_bUseLightmapDirectionality;

		// Token: 0x04001040 RID: 4160
		internal static byte __PropertyMask_bUseLightmapDirectionality;

		// Token: 0x04001041 RID: 4161
		internal static int __PropertyOffset_bUseAlphaToCoverage;

		// Token: 0x04001042 RID: 4162
		internal static byte __PropertyMask_bUseAlphaToCoverage;

		// Token: 0x04001043 RID: 4163
		internal static int __PropertyOffset_bForwardRenderUsePreintegratedGFForSimpleIBL;

		// Token: 0x04001044 RID: 4164
		internal static byte __PropertyMask_bForwardRenderUsePreintegratedGFForSimpleIBL;

		// Token: 0x04001045 RID: 4165
		internal static int __PropertyOffset_bUseHQForwardReflections;

		// Token: 0x04001046 RID: 4166
		internal static byte __PropertyMask_bUseHQForwardReflections;

		// Token: 0x04001047 RID: 4167
		internal static int __PropertyOffset_bUsePlanarForwardReflections;

		// Token: 0x04001048 RID: 4168
		internal static byte __PropertyMask_bUsePlanarForwardReflections;

		// Token: 0x04001049 RID: 4169
		internal static int __PropertyOffset_bNormalCurvatureToRoughness;

		// Token: 0x0400104A RID: 4170
		internal static byte __PropertyMask_bNormalCurvatureToRoughness;

		// Token: 0x0400104B RID: 4171
		internal static int __PropertyOffset_bEnableCrackFreeDisplacement;

		// Token: 0x0400104C RID: 4172
		internal static byte __PropertyMask_bEnableCrackFreeDisplacement;

		// Token: 0x0400104D RID: 4173
		internal static int __PropertyOffset_bEnableAdaptiveTessellation;

		// Token: 0x0400104E RID: 4174
		internal static byte __PropertyMask_bEnableAdaptiveTessellation;

		// Token: 0x0400104F RID: 4175
		internal static int __PropertyOffset_bDisableTessellationInShadowPass;

		// Token: 0x04001050 RID: 4176
		internal static byte __PropertyMask_bDisableTessellationInShadowPass;

		// Token: 0x04001051 RID: 4177
		internal static int __PropertyOffset_AllowTranslucentCustomDepthWrites;

		// Token: 0x04001052 RID: 4178
		internal static byte __PropertyMask_AllowTranslucentCustomDepthWrites;

		// Token: 0x04001053 RID: 4179
		internal static int __PropertyOffset_AllowMobileSceneCustomDepthWrites;

		// Token: 0x04001054 RID: 4180
		internal static byte __PropertyMask_AllowMobileSceneCustomDepthWrites;

		// Token: 0x04001055 RID: 4181
		internal static int __PropertyOffset_bAllowFrontLayerTranslucency;

		// Token: 0x04001056 RID: 4182
		internal static byte __PropertyMask_bAllowFrontLayerTranslucency;

		// Token: 0x04001057 RID: 4183
		internal static int __PropertyOffset_Wireframe;

		// Token: 0x04001058 RID: 4184
		internal static byte __PropertyMask_Wireframe;

		// Token: 0x04001059 RID: 4185
		internal static int __PropertyOffset_ShadingRate;

		// Token: 0x0400105A RID: 4186
		internal static int __PropertyOffset_bCanMaskedBeAssumedOpaque;

		// Token: 0x0400105B RID: 4187
		internal static byte __PropertyMask_bCanMaskedBeAssumedOpaque;

		// Token: 0x0400105C RID: 4188
		internal static int __PropertyOffset_bIsMasked_DEPRECATED;

		// Token: 0x0400105D RID: 4189
		internal static byte __PropertyMask_bIsMasked_DEPRECATED;

		// Token: 0x0400105E RID: 4190
		internal static int __PropertyOffset_bIsPreviewMaterial;

		// Token: 0x0400105F RID: 4191
		internal static byte __PropertyMask_bIsPreviewMaterial;

		// Token: 0x04001060 RID: 4192
		internal static int __PropertyOffset_bIsDebugMaterial;

		// Token: 0x04001061 RID: 4193
		internal static byte __PropertyMask_bIsDebugMaterial;

		// Token: 0x04001062 RID: 4194
		internal static int __PropertyOffset_bIsFunctionPreviewMaterial;

		// Token: 0x04001063 RID: 4195
		internal static byte __PropertyMask_bIsFunctionPreviewMaterial;

		// Token: 0x04001064 RID: 4196
		internal static int __PropertyOffset_bUseMaterialAttributes;

		// Token: 0x04001065 RID: 4197
		internal static byte __PropertyMask_bUseMaterialAttributes;

		// Token: 0x04001066 RID: 4198
		internal static int __PropertyOffset_bCastRayTracedShadows;

		// Token: 0x04001067 RID: 4199
		internal static byte __PropertyMask_bCastRayTracedShadows;

		// Token: 0x04001068 RID: 4200
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04001069 RID: 4201
		internal static byte __PropertyMask_bCastRasterShadowsInRaytracing;

		// Token: 0x0400106A RID: 4202
		internal static int __PropertyOffset_bDisableCastDynamicShadows;

		// Token: 0x0400106B RID: 4203
		internal static byte __PropertyMask_bDisableCastDynamicShadows;

		// Token: 0x0400106C RID: 4204
		internal static int __PropertyOffset_bUseShadowPixelDepthOffset;

		// Token: 0x0400106D RID: 4205
		internal static byte __PropertyMask_bUseShadowPixelDepthOffset;

		// Token: 0x0400106E RID: 4206
		internal static int __PropertyOffset_bUseTranslucencyVertexFog;

		// Token: 0x0400106F RID: 4207
		internal static byte __PropertyMask_bUseTranslucencyVertexFog;

		// Token: 0x04001070 RID: 4208
		internal static int __PropertyOffset_bUseTranslucencyEffectVertexFog;

		// Token: 0x04001071 RID: 4209
		internal static byte __PropertyMask_bUseTranslucencyEffectVertexFog;

		// Token: 0x04001072 RID: 4210
		internal static int __PropertyOffset_bApplyCloudFogging;

		// Token: 0x04001073 RID: 4211
		internal static byte __PropertyMask_bApplyCloudFogging;

		// Token: 0x04001074 RID: 4212
		internal static int __PropertyOffset_bIsSky;

		// Token: 0x04001075 RID: 4213
		internal static byte __PropertyMask_bIsSky;

		// Token: 0x04001076 RID: 4214
		internal static int __PropertyOffset_bSupportRayTracing;

		// Token: 0x04001077 RID: 4215
		internal static byte __PropertyMask_bSupportRayTracing;

		// Token: 0x04001078 RID: 4216
		internal static int __PropertyOffset_bAutoSupportRayTracing;

		// Token: 0x04001079 RID: 4217
		internal static byte __PropertyMask_bAutoSupportRayTracing;

		// Token: 0x0400107A RID: 4218
		internal static int __PropertyOffset_DisableNPCOptimiAsRayTracing;

		// Token: 0x0400107B RID: 4219
		internal static byte __PropertyMask_DisableNPCOptimiAsRayTracing;

		// Token: 0x0400107C RID: 4220
		internal static int __PropertyOffset_bUseAsRaytracedSky;

		// Token: 0x0400107D RID: 4221
		internal static byte __PropertyMask_bUseAsRaytracedSky;

		// Token: 0x0400107E RID: 4222
		internal static int __PropertyOffset_bComputeFogPerPixel;

		// Token: 0x0400107F RID: 4223
		internal static byte __PropertyMask_bComputeFogPerPixel;

		// Token: 0x04001080 RID: 4224
		internal static int __PropertyOffset_bOutputTranslucentVelocity;

		// Token: 0x04001081 RID: 4225
		internal static byte __PropertyMask_bOutputTranslucentVelocity;

		// Token: 0x04001082 RID: 4226
		internal static int __PropertyOffset_bIsDisableOutputVelocity;

		// Token: 0x04001083 RID: 4227
		internal static byte __PropertyMask_bIsDisableOutputVelocity;

		// Token: 0x04001084 RID: 4228
		internal static int __PropertyOffset_bIsMobileOutputVelocity;

		// Token: 0x04001085 RID: 4229
		internal static byte __PropertyMask_bIsMobileOutputVelocity;

		// Token: 0x04001086 RID: 4230
		internal static int __PropertyOffset_bAllowDevelopmentShaderCompile;

		// Token: 0x04001087 RID: 4231
		internal static byte __PropertyMask_bAllowDevelopmentShaderCompile;

		// Token: 0x04001088 RID: 4232
		internal static int __PropertyOffset_bIsMaterialEditorStatsMaterial;

		// Token: 0x04001089 RID: 4233
		internal static byte __PropertyMask_bIsMaterialEditorStatsMaterial;

		// Token: 0x0400108A RID: 4234
		internal static int __PropertyOffset_BlendableOutputAlpha;

		// Token: 0x0400108B RID: 4235
		internal static byte __PropertyMask_BlendableOutputAlpha;

		// Token: 0x0400108C RID: 4236
		internal static int __PropertyOffset_bAdditiveBlendToSceneColor;

		// Token: 0x0400108D RID: 4237
		internal static byte __PropertyMask_bAdditiveBlendToSceneColor;

		// Token: 0x0400108E RID: 4238
		internal static int __PropertyOffset_bEnableStencilTest;

		// Token: 0x0400108F RID: 4239
		internal static byte __PropertyMask_bEnableStencilTest;

		// Token: 0x04001090 RID: 4240
		internal static int __PropertyOffset_StencilRefValue;

		// Token: 0x04001091 RID: 4241
		internal static int __PropertyOffset_bEnableOfficialCustomStencilTest;

		// Token: 0x04001092 RID: 4242
		internal static byte __PropertyMask_bEnableOfficialCustomStencilTest;

		// Token: 0x04001093 RID: 4243
		internal static int __PropertyOffset_OfficialCustomStencilValue;

		// Token: 0x04001094 RID: 4244
		internal static int __PropertyOffset_bInvertOfficialCustomStencilTest;

		// Token: 0x04001095 RID: 4245
		internal static byte __PropertyMask_bInvertOfficialCustomStencilTest;

		// Token: 0x04001096 RID: 4246
		internal static int __PropertyOffset_bOfficialCustomStencilOnlyBehind;

		// Token: 0x04001097 RID: 4247
		internal static byte __PropertyMask_bOfficialCustomStencilOnlyBehind;

		// Token: 0x04001098 RID: 4248
		internal static int __PropertyOffset_bEnableCustomStencilTest;

		// Token: 0x04001099 RID: 4249
		internal static byte __PropertyMask_bEnableCustomStencilTest;

		// Token: 0x0400109A RID: 4250
		internal static int __PropertyOffset_bEnableCustomStencilDepthTest;

		// Token: 0x0400109B RID: 4251
		internal static byte __PropertyMask_bEnableCustomStencilDepthTest;

		// Token: 0x0400109C RID: 4252
		internal static int __PropertyOffset_CustomStencilRefValue;

		// Token: 0x0400109D RID: 4253
		internal static int __PropertyOffset_bEnableCustomStencilWrite;

		// Token: 0x0400109E RID: 4254
		internal static byte __PropertyMask_bEnableCustomStencilWrite;

		// Token: 0x0400109F RID: 4255
		internal static int __PropertyOffset_CustomStencilWriteValue;

		// Token: 0x040010A0 RID: 4256
		internal static int __PropertyOffset_bCustomStencilWriteOnly;

		// Token: 0x040010A1 RID: 4257
		internal static byte __PropertyMask_bCustomStencilWriteOnly;

		// Token: 0x040010A2 RID: 4258
		internal static int __PropertyOffset_bCustomStencilWriteOnlyEnableDepthWrite;

		// Token: 0x040010A3 RID: 4259
		internal static byte __PropertyMask_bCustomStencilWriteOnlyEnableDepthWrite;

		// Token: 0x040010A4 RID: 4260
		internal static int __PropertyOffset_bCustomStencilWriteDisableDepthTest;

		// Token: 0x040010A5 RID: 4261
		internal static byte __PropertyMask_bCustomStencilWriteDisableDepthTest;

		// Token: 0x040010A6 RID: 4262
		internal static int __PropertyOffset_bCustomStencilWriteRenderLast;

		// Token: 0x040010A7 RID: 4263
		internal static byte __PropertyMask_bCustomStencilWriteRenderLast;

		// Token: 0x040010A8 RID: 4264
		internal static int __PropertyOffset_bRenderOnDepthTestFail;

		// Token: 0x040010A9 RID: 4265
		internal static byte __PropertyMask_bRenderOnDepthTestFail;

		// Token: 0x040010AA RID: 4266
		internal static int __PropertyOffset_bTranslucentDepthWrite;

		// Token: 0x040010AB RID: 4267
		internal static byte __PropertyMask_bTranslucentDepthWrite;

		// Token: 0x040010AC RID: 4268
		internal static int __PropertyOffset_bTranslucentPixelClip;

		// Token: 0x040010AD RID: 4269
		internal static byte __PropertyMask_bTranslucentPixelClip;

		// Token: 0x040010AE RID: 4270
		internal static int __PropertyOffset_BlendablePriority;

		// Token: 0x040010AF RID: 4271
		internal static int __PropertyOffset_bIsBlendable;

		// Token: 0x040010B0 RID: 4272
		internal static byte __PropertyMask_bIsBlendable;

		// Token: 0x040010B1 RID: 4273
		internal static int __PropertyOffset_UsageFlagWarnings;

		// Token: 0x040010B2 RID: 4274
		internal static int __PropertyOffset_RefractionDepthBias;

		// Token: 0x040010B3 RID: 4275
		internal static int __PropertyOffset_StateId;

		// Token: 0x040010B4 RID: 4276
		internal static int __PropertyOffset_MaxDisplacement;
	}
}
