using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B20 RID: 6944
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHeightFogSetting")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FKuroHeightFogSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A1FD RID: 107005 RVA: 0x002690B1 File Offset: 0x002672B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHeightFogSetting._ScriptStructPtr != 0) ? FKuroHeightFogSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroHeightFogSetting", ref FKuroHeightFogSetting._ScriptStructPtr);
		}

		// Token: 0x170068E0 RID: 26848
		// (get) Token: 0x0601A1FE RID: 107006 RVA: 0x002690D5 File Offset: 0x002672D5
		// (set) Token: 0x0601A1FF RID: 107007 RVA: 0x002690EE File Offset: 0x002672EE
		public unsafe bool bOverride_DirectionalInscatteringAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringAmount) & FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringAmount) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringAmount) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringAmount) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringAmount : 0));
			}
		}

		// Token: 0x170068E1 RID: 26849
		// (get) Token: 0x0601A200 RID: 107008 RVA: 0x0026911E File Offset: 0x0026731E
		// (set) Token: 0x0601A201 RID: 107009 RVA: 0x00269137 File Offset: 0x00267337
		public unsafe bool bOverride_DirectionalInscatteringExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringExponent) & FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringExponent) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringExponent) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringExponent) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringExponent : 0));
			}
		}

		// Token: 0x170068E2 RID: 26850
		// (get) Token: 0x0601A202 RID: 107010 RVA: 0x00269167 File Offset: 0x00267367
		// (set) Token: 0x0601A203 RID: 107011 RVA: 0x00269180 File Offset: 0x00267380
		public unsafe bool bOverride_DirectionalInscatteringStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringStartDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringStartDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringStartDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringStartDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringStartDistance : 0));
			}
		}

		// Token: 0x170068E3 RID: 26851
		// (get) Token: 0x0601A204 RID: 107012 RVA: 0x002691B0 File Offset: 0x002673B0
		// (set) Token: 0x0601A205 RID: 107013 RVA: 0x002691C9 File Offset: 0x002673C9
		public unsafe bool bOverride_DirectionalInscatteringColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringColor) & FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringColor) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_DirectionalInscatteringColor) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringColor) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_DirectionalInscatteringColor : 0));
			}
		}

		// Token: 0x170068E4 RID: 26852
		// (get) Token: 0x0601A206 RID: 107014 RVA: 0x002691F9 File Offset: 0x002673F9
		// (set) Token: 0x0601A207 RID: 107015 RVA: 0x00269212 File Offset: 0x00267412
		public unsafe bool bOverride_Fog1Density
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Density) & FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Density) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Density) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Density) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Density) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Density : 0));
			}
		}

		// Token: 0x170068E5 RID: 26853
		// (get) Token: 0x0601A208 RID: 107016 RVA: 0x00269242 File Offset: 0x00267442
		// (set) Token: 0x0601A209 RID: 107017 RVA: 0x0026925B File Offset: 0x0026745B
		public unsafe bool bOverride_Fog1HeightOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1HeightOffset) & FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1HeightOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1HeightOffset) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1HeightOffset) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1HeightOffset) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1HeightOffset : 0));
			}
		}

		// Token: 0x170068E6 RID: 26854
		// (get) Token: 0x0601A20A RID: 107018 RVA: 0x0026928B File Offset: 0x0026748B
		// (set) Token: 0x0601A20B RID: 107019 RVA: 0x002692A4 File Offset: 0x002674A4
		public unsafe bool bOverride_Fog1Falloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Falloff) & FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Falloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Falloff) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1Falloff) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Falloff) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1Falloff : 0));
			}
		}

		// Token: 0x170068E7 RID: 26855
		// (get) Token: 0x0601A20C RID: 107020 RVA: 0x002692D4 File Offset: 0x002674D4
		// (set) Token: 0x0601A20D RID: 107021 RVA: 0x002692ED File Offset: 0x002674ED
		public unsafe bool bOverride_Fog1FalloffFarSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1FalloffFarSky) & FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1FalloffFarSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1FalloffFarSky) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_Fog1FalloffFarSky) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1FalloffFarSky) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_Fog1FalloffFarSky : 0));
			}
		}

		// Token: 0x170068E8 RID: 26856
		// (get) Token: 0x0601A20E RID: 107022 RVA: 0x0026931D File Offset: 0x0026751D
		// (set) Token: 0x0601A20F RID: 107023 RVA: 0x00269336 File Offset: 0x00267536
		public unsafe bool bOverride_StartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_StartDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_StartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_StartDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_StartDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_StartDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_StartDistance : 0));
			}
		}

		// Token: 0x170068E9 RID: 26857
		// (get) Token: 0x0601A210 RID: 107024 RVA: 0x00269366 File Offset: 0x00267566
		// (set) Token: 0x0601A211 RID: 107025 RVA: 0x0026937F File Offset: 0x0026757F
		public unsafe bool bOverride_MaxOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_MaxOpacity) & FKuroHeightFogSetting.__PropertyMask_bOverride_MaxOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_MaxOpacity) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_MaxOpacity) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_MaxOpacity) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_MaxOpacity : 0));
			}
		}

		// Token: 0x170068EA RID: 26858
		// (get) Token: 0x0601A212 RID: 107026 RVA: 0x002693AF File Offset: 0x002675AF
		// (set) Token: 0x0601A213 RID: 107027 RVA: 0x002693C8 File Offset: 0x002675C8
		public unsafe bool bOverride_FogNearColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColor) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColor) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColor) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColor) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColor : 0));
			}
		}

		// Token: 0x170068EB RID: 26859
		// (get) Token: 0x0601A214 RID: 107028 RVA: 0x002693F8 File Offset: 0x002675F8
		// (set) Token: 0x0601A215 RID: 107029 RVA: 0x00269411 File Offset: 0x00267611
		public unsafe bool bOverride_FogFarColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColor) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColor) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColor) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColor) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColor : 0));
			}
		}

		// Token: 0x170068EC RID: 26860
		// (get) Token: 0x0601A216 RID: 107030 RVA: 0x00269441 File Offset: 0x00267641
		// (set) Token: 0x0601A217 RID: 107031 RVA: 0x0026945A File Offset: 0x0026765A
		public unsafe bool bOverride_FogBaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogBaseColor) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogBaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogBaseColor) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogBaseColor) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogBaseColor) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogBaseColor : 0));
			}
		}

		// Token: 0x170068ED RID: 26861
		// (get) Token: 0x0601A218 RID: 107032 RVA: 0x0026948A File Offset: 0x0026768A
		// (set) Token: 0x0601A219 RID: 107033 RVA: 0x002694A3 File Offset: 0x002676A3
		public unsafe bool bOverride_FogNearColorDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColorDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColorDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColorDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearColorDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColorDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearColorDistance : 0));
			}
		}

		// Token: 0x170068EE RID: 26862
		// (get) Token: 0x0601A21A RID: 107034 RVA: 0x002694D3 File Offset: 0x002676D3
		// (set) Token: 0x0601A21B RID: 107035 RVA: 0x002694EC File Offset: 0x002676EC
		public unsafe bool bOverride_FogFarColorDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColorDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColorDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColorDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogFarColorDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColorDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogFarColorDistance : 0));
			}
		}

		// Token: 0x170068EF RID: 26863
		// (get) Token: 0x0601A21C RID: 107036 RVA: 0x0026951C File Offset: 0x0026771C
		// (set) Token: 0x0601A21D RID: 107037 RVA: 0x00269535 File Offset: 0x00267735
		public unsafe bool bOverride_FogNearFarColorRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearFarColorRatio) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearFarColorRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearFarColorRatio) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogNearFarColorRatio) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearFarColorRatio) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogNearFarColorRatio : 0));
			}
		}

		// Token: 0x170068F0 RID: 26864
		// (get) Token: 0x0601A21E RID: 107038 RVA: 0x00269565 File Offset: 0x00267765
		// (set) Token: 0x0601A21F RID: 107039 RVA: 0x0026957E File Offset: 0x0026777E
		public unsafe bool bOverride_FogMixDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixDistance : 0));
			}
		}

		// Token: 0x170068F1 RID: 26865
		// (get) Token: 0x0601A220 RID: 107040 RVA: 0x002695AE File Offset: 0x002677AE
		// (set) Token: 0x0601A221 RID: 107041 RVA: 0x002695C7 File Offset: 0x002677C7
		public unsafe bool bOverride_FogMixWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixWidth) & FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixWidth) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_FogMixWidth) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixWidth) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_FogMixWidth : 0));
			}
		}

		// Token: 0x170068F2 RID: 26866
		// (get) Token: 0x0601A222 RID: 107042 RVA: 0x002695F7 File Offset: 0x002677F7
		// (set) Token: 0x0601A223 RID: 107043 RVA: 0x00269610 File Offset: 0x00267810
		public unsafe bool bOverride_LowPoint1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowPoint1) & FKuroHeightFogSetting.__PropertyMask_bOverride_LowPoint1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowPoint1) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowPoint1) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_LowPoint1) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_LowPoint1 : 0));
			}
		}

		// Token: 0x170068F3 RID: 26867
		// (get) Token: 0x0601A224 RID: 107044 RVA: 0x00269640 File Offset: 0x00267840
		// (set) Token: 0x0601A225 RID: 107045 RVA: 0x00269659 File Offset: 0x00267859
		public unsafe bool bOverride_HighPoint1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_HighPoint1) & FKuroHeightFogSetting.__PropertyMask_bOverride_HighPoint1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_HighPoint1) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_HighPoint1) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_HighPoint1) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_HighPoint1 : 0));
			}
		}

		// Token: 0x170068F4 RID: 26868
		// (get) Token: 0x0601A226 RID: 107046 RVA: 0x00269689 File Offset: 0x00267889
		// (set) Token: 0x0601A227 RID: 107047 RVA: 0x002696A2 File Offset: 0x002678A2
		public unsafe bool bOverride_LowFalloff1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowFalloff1) & FKuroHeightFogSetting.__PropertyMask_bOverride_LowFalloff1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowFalloff1) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowFalloff1) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_LowFalloff1) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_LowFalloff1 : 0));
			}
		}

		// Token: 0x170068F5 RID: 26869
		// (get) Token: 0x0601A228 RID: 107048 RVA: 0x002696D2 File Offset: 0x002678D2
		// (set) Token: 0x0601A229 RID: 107049 RVA: 0x002696EB File Offset: 0x002678EB
		public unsafe bool bOverride_LowSkyFalloff1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowSkyFalloff1) & FKuroHeightFogSetting.__PropertyMask_bOverride_LowSkyFalloff1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowSkyFalloff1) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowSkyFalloff1) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_LowSkyFalloff1) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_LowSkyFalloff1 : 0));
			}
		}

		// Token: 0x170068F6 RID: 26870
		// (get) Token: 0x0601A22A RID: 107050 RVA: 0x0026971B File Offset: 0x0026791B
		// (set) Token: 0x0601A22B RID: 107051 RVA: 0x00269734 File Offset: 0x00267934
		public unsafe bool bOverride_LowHighOffset1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowHighOffset1) & FKuroHeightFogSetting.__PropertyMask_bOverride_LowHighOffset1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowHighOffset1) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_LowHighOffset1) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_LowHighOffset1) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_LowHighOffset1 : 0));
			}
		}

		// Token: 0x170068F7 RID: 26871
		// (get) Token: 0x0601A22C RID: 107052 RVA: 0x00269764 File Offset: 0x00267964
		// (set) Token: 0x0601A22D RID: 107053 RVA: 0x0026977D File Offset: 0x0026797D
		public unsafe bool bOverride_SingleCloudOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_SingleCloudOpacity) & FKuroHeightFogSetting.__PropertyMask_bOverride_SingleCloudOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_SingleCloudOpacity) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_SingleCloudOpacity) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_SingleCloudOpacity) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_SingleCloudOpacity : 0));
			}
		}

		// Token: 0x170068F8 RID: 26872
		// (get) Token: 0x0601A22E RID: 107054 RVA: 0x002697AD File Offset: 0x002679AD
		// (set) Token: 0x0601A22F RID: 107055 RVA: 0x002697C6 File Offset: 0x002679C6
		public unsafe bool bOverride_CloudOceanHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanHeight) & FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanHeight) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanHeight) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanHeight) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanHeight : 0));
			}
		}

		// Token: 0x170068F9 RID: 26873
		// (get) Token: 0x0601A230 RID: 107056 RVA: 0x002697F6 File Offset: 0x002679F6
		// (set) Token: 0x0601A231 RID: 107057 RVA: 0x0026980F File Offset: 0x00267A0F
		public unsafe bool bOverride_CloudOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOpacity) & FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOpacity) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOpacity) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOpacity) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOpacity : 0));
			}
		}

		// Token: 0x170068FA RID: 26874
		// (get) Token: 0x0601A232 RID: 107058 RVA: 0x0026983F File Offset: 0x00267A3F
		// (set) Token: 0x0601A233 RID: 107059 RVA: 0x00269858 File Offset: 0x00267A58
		public unsafe bool bOverride_CloudOceanMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanMaterial) & FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanMaterial) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_CloudOceanMaterial) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanMaterial) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_CloudOceanMaterial : 0));
			}
		}

		// Token: 0x170068FB RID: 26875
		// (get) Token: 0x0601A234 RID: 107060 RVA: 0x00269888 File Offset: 0x00267A88
		// (set) Token: 0x0601A235 RID: 107061 RVA: 0x002698A1 File Offset: 0x00267AA1
		public unsafe bool bOverride_VolumeCloudPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudPosition) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudPosition) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudPosition) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudPosition) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudPosition : 0));
			}
		}

		// Token: 0x170068FC RID: 26876
		// (get) Token: 0x0601A236 RID: 107062 RVA: 0x002698D1 File Offset: 0x00267AD1
		// (set) Token: 0x0601A237 RID: 107063 RVA: 0x002698EA File Offset: 0x00267AEA
		public unsafe bool bOverride_VolumeCloudScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudScale) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudScale) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudScale) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudScale) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudScale : 0));
			}
		}

		// Token: 0x170068FD RID: 26877
		// (get) Token: 0x0601A238 RID: 107064 RVA: 0x0026991A File Offset: 0x00267B1A
		// (set) Token: 0x0601A239 RID: 107065 RVA: 0x00269933 File Offset: 0x00267B33
		public unsafe bool bOverride_VolumeCloudRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRange) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRange) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRange) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRange) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRange : 0));
			}
		}

		// Token: 0x170068FE RID: 26878
		// (get) Token: 0x0601A23A RID: 107066 RVA: 0x00269963 File Offset: 0x00267B63
		// (set) Token: 0x0601A23B RID: 107067 RVA: 0x0026997C File Offset: 0x00267B7C
		public unsafe bool bOverride_VolumeCloudRangeZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRangeZ) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRangeZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRangeZ) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudRangeZ) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRangeZ) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudRangeZ : 0));
			}
		}

		// Token: 0x170068FF RID: 26879
		// (get) Token: 0x0601A23C RID: 107068 RVA: 0x002699AC File Offset: 0x00267BAC
		// (set) Token: 0x0601A23D RID: 107069 RVA: 0x002699C5 File Offset: 0x00267BC5
		public unsafe bool bOverride_VolumeCloudOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudOpacity) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudOpacity) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudOpacity) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudOpacity) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudOpacity : 0));
			}
		}

		// Token: 0x17006900 RID: 26880
		// (get) Token: 0x0601A23E RID: 107070 RVA: 0x002699F5 File Offset: 0x00267BF5
		// (set) Token: 0x0601A23F RID: 107071 RVA: 0x00269A0E File Offset: 0x00267C0E
		public unsafe bool bOverride_VolumeCloudMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudMaterial) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudMaterial) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudMaterial) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudMaterial) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudMaterial : 0));
			}
		}

		// Token: 0x17006901 RID: 26881
		// (get) Token: 0x0601A240 RID: 107072 RVA: 0x00269A3E File Offset: 0x00267C3E
		// (set) Token: 0x0601A241 RID: 107073 RVA: 0x00269A57 File Offset: 0x00267C57
		public unsafe bool bOverride_bUseVolumeCloudInsteadOfCloudOcean
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bUseVolumeCloudInsteadOfCloudOcean) & FKuroHeightFogSetting.__PropertyMask_bOverride_bUseVolumeCloudInsteadOfCloudOcean) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bUseVolumeCloudInsteadOfCloudOcean) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bUseVolumeCloudInsteadOfCloudOcean) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_bUseVolumeCloudInsteadOfCloudOcean) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_bUseVolumeCloudInsteadOfCloudOcean : 0));
			}
		}

		// Token: 0x17006902 RID: 26882
		// (get) Token: 0x0601A242 RID: 107074 RVA: 0x00269A87 File Offset: 0x00267C87
		// (set) Token: 0x0601A243 RID: 107075 RVA: 0x00269AA0 File Offset: 0x00267CA0
		public unsafe bool bOverride_VolumeCloudCustomLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudCustomLighting) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudCustomLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudCustomLighting) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudCustomLighting) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudCustomLighting) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudCustomLighting : 0));
			}
		}

		// Token: 0x17006903 RID: 26883
		// (get) Token: 0x0601A244 RID: 107076 RVA: 0x00269AD0 File Offset: 0x00267CD0
		// (set) Token: 0x0601A245 RID: 107077 RVA: 0x00269AE9 File Offset: 0x00267CE9
		public unsafe bool bOverride_VolumeCloudLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudLight) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudLight) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudLight) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudLight) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudLight : 0));
			}
		}

		// Token: 0x17006904 RID: 26884
		// (get) Token: 0x0601A246 RID: 107078 RVA: 0x00269B19 File Offset: 0x00267D19
		// (set) Token: 0x0601A247 RID: 107079 RVA: 0x00269B32 File Offset: 0x00267D32
		public unsafe bool bOverride_VolumeCloudShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudShadow) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudShadow) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudShadow) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudShadow) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudShadow : 0));
			}
		}

		// Token: 0x17006905 RID: 26885
		// (get) Token: 0x0601A248 RID: 107080 RVA: 0x00269B62 File Offset: 0x00267D62
		// (set) Token: 0x0601A249 RID: 107081 RVA: 0x00269B7B File Offset: 0x00267D7B
		public unsafe bool bOverride_VolumeCloudSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudSpeed) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudSpeed) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudSpeed) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudSpeed) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudSpeed : 0));
			}
		}

		// Token: 0x17006906 RID: 26886
		// (get) Token: 0x0601A24A RID: 107082 RVA: 0x00269BAB File Offset: 0x00267DAB
		// (set) Token: 0x0601A24B RID: 107083 RVA: 0x00269BC4 File Offset: 0x00267DC4
		public unsafe bool bOverride_VolumeCloudNearFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudNearFadeDistance) & FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudNearFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudNearFadeDistance) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_VolumeCloudNearFadeDistance) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudNearFadeDistance) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_VolumeCloudNearFadeDistance : 0));
			}
		}

		// Token: 0x17006907 RID: 26887
		// (get) Token: 0x0601A24C RID: 107084 RVA: 0x00269BF4 File Offset: 0x00267DF4
		// (set) Token: 0x0601A24D RID: 107085 RVA: 0x00269C0D File Offset: 0x00267E0D
		public unsafe bool bOverride_bVolumeCloudJustForVRS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudJustForVRS) & FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudJustForVRS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudJustForVRS) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudJustForVRS) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudJustForVRS) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudJustForVRS : 0));
			}
		}

		// Token: 0x17006908 RID: 26888
		// (get) Token: 0x0601A24E RID: 107086 RVA: 0x00269C3D File Offset: 0x00267E3D
		// (set) Token: 0x0601A24F RID: 107087 RVA: 0x00269C56 File Offset: 0x00267E56
		public unsafe bool bOverride_bVolumeCloudNotAffectedByVRS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudNotAffectedByVRS) & FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudNotAffectedByVRS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudNotAffectedByVRS) = ((*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bOverride_bVolumeCloudNotAffectedByVRS) & ~FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudNotAffectedByVRS) | (value ? FKuroHeightFogSetting.__PropertyMask_bOverride_bVolumeCloudNotAffectedByVRS : 0));
			}
		}

		// Token: 0x17006909 RID: 26889
		// (get) Token: 0x0601A250 RID: 107088 RVA: 0x00269C86 File Offset: 0x00267E86
		// (set) Token: 0x0601A251 RID: 107089 RVA: 0x00269C96 File Offset: 0x00267E96
		public unsafe float DirectionalInscatteringAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringAmount) = value;
			}
		}

		// Token: 0x1700690A RID: 26890
		// (get) Token: 0x0601A252 RID: 107090 RVA: 0x00269CA7 File Offset: 0x00267EA7
		// (set) Token: 0x0601A253 RID: 107091 RVA: 0x00269CB7 File Offset: 0x00267EB7
		public unsafe float DirectionalInscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringExponent) = value;
			}
		}

		// Token: 0x1700690B RID: 26891
		// (get) Token: 0x0601A254 RID: 107092 RVA: 0x00269CC8 File Offset: 0x00267EC8
		// (set) Token: 0x0601A255 RID: 107093 RVA: 0x00269CD8 File Offset: 0x00267ED8
		public unsafe float DirectionalInscatteringStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringStartDistance) = value;
			}
		}

		// Token: 0x1700690C RID: 26892
		// (get) Token: 0x0601A256 RID: 107094 RVA: 0x00269CE9 File Offset: 0x00267EE9
		// (set) Token: 0x0601A257 RID: 107095 RVA: 0x00269CFD File Offset: 0x00267EFD
		public unsafe FLinearColor DirectionalInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_DirectionalInscatteringColor) = value;
			}
		}

		// Token: 0x1700690D RID: 26893
		// (get) Token: 0x0601A258 RID: 107096 RVA: 0x00269D12 File Offset: 0x00267F12
		// (set) Token: 0x0601A259 RID: 107097 RVA: 0x00269D22 File Offset: 0x00267F22
		public unsafe float Fog1Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1Density) = value;
			}
		}

		// Token: 0x1700690E RID: 26894
		// (get) Token: 0x0601A25A RID: 107098 RVA: 0x00269D33 File Offset: 0x00267F33
		// (set) Token: 0x0601A25B RID: 107099 RVA: 0x00269D43 File Offset: 0x00267F43
		public unsafe float Fog1HeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1HeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1HeightOffset) = value;
			}
		}

		// Token: 0x1700690F RID: 26895
		// (get) Token: 0x0601A25C RID: 107100 RVA: 0x00269D54 File Offset: 0x00267F54
		// (set) Token: 0x0601A25D RID: 107101 RVA: 0x00269D64 File Offset: 0x00267F64
		public unsafe float Fog1Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1Falloff) = value;
			}
		}

		// Token: 0x17006910 RID: 26896
		// (get) Token: 0x0601A25E RID: 107102 RVA: 0x00269D75 File Offset: 0x00267F75
		// (set) Token: 0x0601A25F RID: 107103 RVA: 0x00269D85 File Offset: 0x00267F85
		public unsafe float Fog1FalloffFarSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1FalloffFarSky);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_Fog1FalloffFarSky) = value;
			}
		}

		// Token: 0x17006911 RID: 26897
		// (get) Token: 0x0601A260 RID: 107104 RVA: 0x00269D96 File Offset: 0x00267F96
		// (set) Token: 0x0601A261 RID: 107105 RVA: 0x00269DA6 File Offset: 0x00267FA6
		public unsafe float StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_StartDistance) = value;
			}
		}

		// Token: 0x17006912 RID: 26898
		// (get) Token: 0x0601A262 RID: 107106 RVA: 0x00269DB7 File Offset: 0x00267FB7
		// (set) Token: 0x0601A263 RID: 107107 RVA: 0x00269DC7 File Offset: 0x00267FC7
		public unsafe float MaxOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_MaxOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_MaxOpacity) = value;
			}
		}

		// Token: 0x17006913 RID: 26899
		// (get) Token: 0x0601A264 RID: 107108 RVA: 0x00269DD8 File Offset: 0x00267FD8
		// (set) Token: 0x0601A265 RID: 107109 RVA: 0x00269DEC File Offset: 0x00267FEC
		public unsafe FLinearColor FogNearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearColor) = value;
			}
		}

		// Token: 0x17006914 RID: 26900
		// (get) Token: 0x0601A266 RID: 107110 RVA: 0x00269E01 File Offset: 0x00268001
		// (set) Token: 0x0601A267 RID: 107111 RVA: 0x00269E15 File Offset: 0x00268015
		public unsafe FLinearColor FogFarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogFarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogFarColor) = value;
			}
		}

		// Token: 0x17006915 RID: 26901
		// (get) Token: 0x0601A268 RID: 107112 RVA: 0x00269E2A File Offset: 0x0026802A
		// (set) Token: 0x0601A269 RID: 107113 RVA: 0x00269E3E File Offset: 0x0026803E
		public unsafe FLinearColor FogBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogBaseColor) = value;
			}
		}

		// Token: 0x17006916 RID: 26902
		// (get) Token: 0x0601A26A RID: 107114 RVA: 0x00269E53 File Offset: 0x00268053
		// (set) Token: 0x0601A26B RID: 107115 RVA: 0x00269E63 File Offset: 0x00268063
		public unsafe float FogNearColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearColorDistance) = value;
			}
		}

		// Token: 0x17006917 RID: 26903
		// (get) Token: 0x0601A26C RID: 107116 RVA: 0x00269E74 File Offset: 0x00268074
		// (set) Token: 0x0601A26D RID: 107117 RVA: 0x00269E84 File Offset: 0x00268084
		public unsafe float FogFarColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogFarColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogFarColorDistance) = value;
			}
		}

		// Token: 0x17006918 RID: 26904
		// (get) Token: 0x0601A26E RID: 107118 RVA: 0x00269E95 File Offset: 0x00268095
		// (set) Token: 0x0601A26F RID: 107119 RVA: 0x00269EA5 File Offset: 0x002680A5
		public unsafe float FogNearFarColorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearFarColorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogNearFarColorRatio) = value;
			}
		}

		// Token: 0x17006919 RID: 26905
		// (get) Token: 0x0601A270 RID: 107120 RVA: 0x00269EB6 File Offset: 0x002680B6
		// (set) Token: 0x0601A271 RID: 107121 RVA: 0x00269EC6 File Offset: 0x002680C6
		public unsafe float FogMixDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogMixDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogMixDistance) = value;
			}
		}

		// Token: 0x1700691A RID: 26906
		// (get) Token: 0x0601A272 RID: 107122 RVA: 0x00269ED7 File Offset: 0x002680D7
		// (set) Token: 0x0601A273 RID: 107123 RVA: 0x00269EE7 File Offset: 0x002680E7
		public unsafe float FogMixWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogMixWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_FogMixWidth) = value;
			}
		}

		// Token: 0x1700691B RID: 26907
		// (get) Token: 0x0601A274 RID: 107124 RVA: 0x00269EF8 File Offset: 0x002680F8
		// (set) Token: 0x0601A275 RID: 107125 RVA: 0x00269F08 File Offset: 0x00268108
		public unsafe float LowPoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowPoint1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowPoint1) = value;
			}
		}

		// Token: 0x1700691C RID: 26908
		// (get) Token: 0x0601A276 RID: 107126 RVA: 0x00269F19 File Offset: 0x00268119
		// (set) Token: 0x0601A277 RID: 107127 RVA: 0x00269F29 File Offset: 0x00268129
		public unsafe float HighPoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_HighPoint1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_HighPoint1) = value;
			}
		}

		// Token: 0x1700691D RID: 26909
		// (get) Token: 0x0601A278 RID: 107128 RVA: 0x00269F3A File Offset: 0x0026813A
		// (set) Token: 0x0601A279 RID: 107129 RVA: 0x00269F4A File Offset: 0x0026814A
		public unsafe float LowFalloff1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowFalloff1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowFalloff1) = value;
			}
		}

		// Token: 0x1700691E RID: 26910
		// (get) Token: 0x0601A27A RID: 107130 RVA: 0x00269F5B File Offset: 0x0026815B
		// (set) Token: 0x0601A27B RID: 107131 RVA: 0x00269F6B File Offset: 0x0026816B
		public unsafe float LowSkyFalloff1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowSkyFalloff1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowSkyFalloff1) = value;
			}
		}

		// Token: 0x1700691F RID: 26911
		// (get) Token: 0x0601A27C RID: 107132 RVA: 0x00269F7C File Offset: 0x0026817C
		// (set) Token: 0x0601A27D RID: 107133 RVA: 0x00269F8C File Offset: 0x0026818C
		public unsafe float LowHighOffset1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowHighOffset1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_LowHighOffset1) = value;
			}
		}

		// Token: 0x17006920 RID: 26912
		// (get) Token: 0x0601A27E RID: 107134 RVA: 0x00269F9D File Offset: 0x0026819D
		// (set) Token: 0x0601A27F RID: 107135 RVA: 0x00269FAD File Offset: 0x002681AD
		public unsafe float SingleCloudOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_SingleCloudOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_SingleCloudOpacity) = value;
			}
		}

		// Token: 0x17006921 RID: 26913
		// (get) Token: 0x0601A280 RID: 107136 RVA: 0x00269FBE File Offset: 0x002681BE
		// (set) Token: 0x0601A281 RID: 107137 RVA: 0x00269FCE File Offset: 0x002681CE
		public unsafe float CloudOceanHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_CloudOceanHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_CloudOceanHeight) = value;
			}
		}

		// Token: 0x17006922 RID: 26914
		// (get) Token: 0x0601A282 RID: 107138 RVA: 0x00269FDF File Offset: 0x002681DF
		// (set) Token: 0x0601A283 RID: 107139 RVA: 0x00269FEF File Offset: 0x002681EF
		public unsafe float CloudOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_CloudOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_CloudOpacity) = value;
			}
		}

		// Token: 0x17006923 RID: 26915
		// (get) Token: 0x0601A284 RID: 107140 RVA: 0x0026A000 File Offset: 0x00268200
		// (set) Token: 0x0601A285 RID: 107141 RVA: 0x0026A014 File Offset: 0x00268214
		public unsafe UMaterialInterface CloudOceanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroHeightFogSetting.__PropertyOffset_CloudOceanMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroHeightFogSetting.__PropertyOffset_CloudOceanMaterial, value);
			}
		}

		// Token: 0x17006924 RID: 26916
		// (get) Token: 0x0601A286 RID: 107142 RVA: 0x0026A029 File Offset: 0x00268229
		// (set) Token: 0x0601A287 RID: 107143 RVA: 0x0026A03D File Offset: 0x0026823D
		public unsafe FVector VolumeCloudPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudPosition) = value;
			}
		}

		// Token: 0x17006925 RID: 26917
		// (get) Token: 0x0601A288 RID: 107144 RVA: 0x0026A052 File Offset: 0x00268252
		// (set) Token: 0x0601A289 RID: 107145 RVA: 0x0026A066 File Offset: 0x00268266
		public unsafe FVector VolumeCloudScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudScale) = value;
			}
		}

		// Token: 0x17006926 RID: 26918
		// (get) Token: 0x0601A28A RID: 107146 RVA: 0x0026A07B File Offset: 0x0026827B
		// (set) Token: 0x0601A28B RID: 107147 RVA: 0x0026A08F File Offset: 0x0026828F
		public unsafe FVector2D VolumeCloudRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudRange) = value;
			}
		}

		// Token: 0x17006927 RID: 26919
		// (get) Token: 0x0601A28C RID: 107148 RVA: 0x0026A0A4 File Offset: 0x002682A4
		// (set) Token: 0x0601A28D RID: 107149 RVA: 0x0026A0B4 File Offset: 0x002682B4
		public unsafe float VolumeCloudRangeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudRangeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudRangeZ) = value;
			}
		}

		// Token: 0x17006928 RID: 26920
		// (get) Token: 0x0601A28E RID: 107150 RVA: 0x0026A0C5 File Offset: 0x002682C5
		// (set) Token: 0x0601A28F RID: 107151 RVA: 0x0026A0D5 File Offset: 0x002682D5
		public unsafe float VolumeCloudOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudOpacity) = value;
			}
		}

		// Token: 0x17006929 RID: 26921
		// (get) Token: 0x0601A290 RID: 107152 RVA: 0x0026A0E6 File Offset: 0x002682E6
		// (set) Token: 0x0601A291 RID: 107153 RVA: 0x0026A0FA File Offset: 0x002682FA
		public unsafe UMaterialInterface VolumeCloudMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroHeightFogSetting.__PropertyOffset_VolumeCloudMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroHeightFogSetting.__PropertyOffset_VolumeCloudMaterial, value);
			}
		}

		// Token: 0x1700692A RID: 26922
		// (get) Token: 0x0601A292 RID: 107154 RVA: 0x0026A10F File Offset: 0x0026830F
		// (set) Token: 0x0601A293 RID: 107155 RVA: 0x0026A11F File Offset: 0x0026831F
		public unsafe bool bUseVolumeCloudInsteadOfCloudOcean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bUseVolumeCloudInsteadOfCloudOcean) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bUseVolumeCloudInsteadOfCloudOcean) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700692B RID: 26923
		// (get) Token: 0x0601A294 RID: 107156 RVA: 0x0026A130 File Offset: 0x00268330
		// (set) Token: 0x0601A295 RID: 107157 RVA: 0x0026A140 File Offset: 0x00268340
		public unsafe float VolumeCloudCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudCustomLighting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudCustomLighting) = value;
			}
		}

		// Token: 0x1700692C RID: 26924
		// (get) Token: 0x0601A296 RID: 107158 RVA: 0x0026A151 File Offset: 0x00268351
		// (set) Token: 0x0601A297 RID: 107159 RVA: 0x0026A165 File Offset: 0x00268365
		public unsafe FLinearColor VolumeCloudLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudLight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudLight) = value;
			}
		}

		// Token: 0x1700692D RID: 26925
		// (get) Token: 0x0601A298 RID: 107160 RVA: 0x0026A17A File Offset: 0x0026837A
		// (set) Token: 0x0601A299 RID: 107161 RVA: 0x0026A18E File Offset: 0x0026838E
		public unsafe FLinearColor VolumeCloudShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudShadow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudShadow) = value;
			}
		}

		// Token: 0x1700692E RID: 26926
		// (get) Token: 0x0601A29A RID: 107162 RVA: 0x0026A1A3 File Offset: 0x002683A3
		// (set) Token: 0x0601A29B RID: 107163 RVA: 0x0026A1B7 File Offset: 0x002683B7
		public unsafe FLinearColor VolumeCloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudSpeed) = value;
			}
		}

		// Token: 0x1700692F RID: 26927
		// (get) Token: 0x0601A29C RID: 107164 RVA: 0x0026A1CC File Offset: 0x002683CC
		// (set) Token: 0x0601A29D RID: 107165 RVA: 0x0026A1DC File Offset: 0x002683DC
		public unsafe float VolumeCloudNearFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudNearFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_VolumeCloudNearFadeDistance) = value;
			}
		}

		// Token: 0x17006930 RID: 26928
		// (get) Token: 0x0601A29E RID: 107166 RVA: 0x0026A1ED File Offset: 0x002683ED
		// (set) Token: 0x0601A29F RID: 107167 RVA: 0x0026A1FD File Offset: 0x002683FD
		public unsafe bool bVolumeCloudJustForVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bVolumeCloudJustForVRS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bVolumeCloudJustForVRS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006931 RID: 26929
		// (get) Token: 0x0601A2A0 RID: 107168 RVA: 0x0026A20E File Offset: 0x0026840E
		// (set) Token: 0x0601A2A1 RID: 107169 RVA: 0x0026A21E File Offset: 0x0026841E
		public unsafe bool bVolumeCloudNotAffectedByVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bVolumeCloudNotAffectedByVRS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightFogSetting.__PropertyOffset_bVolumeCloudNotAffectedByVRS) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x0026A22F File Offset: 0x0026842F
		public FKuroHeightFogSetting()
		{
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x0026A238 File Offset: 0x00268438
		[NullableContext(1)]
		public FKuroHeightFogSetting(bool bOverride_DirectionalInscatteringAmount, bool bOverride_DirectionalInscatteringExponent, bool bOverride_DirectionalInscatteringStartDistance, bool bOverride_DirectionalInscatteringColor, bool bOverride_Fog1Density, bool bOverride_Fog1HeightOffset, bool bOverride_Fog1Falloff, bool bOverride_Fog1FalloffFarSky, bool bOverride_StartDistance, bool bOverride_MaxOpacity, bool bOverride_FogNearColor, bool bOverride_FogFarColor, bool bOverride_FogBaseColor, bool bOverride_FogNearColorDistance, bool bOverride_FogFarColorDistance, bool bOverride_FogNearFarColorRatio, bool bOverride_FogMixDistance, bool bOverride_FogMixWidth, bool bOverride_LowPoint1, bool bOverride_HighPoint1, bool bOverride_LowFalloff1, bool bOverride_LowSkyFalloff1, bool bOverride_LowHighOffset1, bool bOverride_SingleCloudOpacity, bool bOverride_CloudOceanHeight, bool bOverride_CloudOpacity, bool bOverride_CloudOceanMaterial, bool bOverride_VolumeCloudPosition, bool bOverride_VolumeCloudScale, bool bOverride_VolumeCloudRange, bool bOverride_VolumeCloudRangeZ, bool bOverride_VolumeCloudOpacity, bool bOverride_VolumeCloudMaterial, bool bOverride_bUseVolumeCloudInsteadOfCloudOcean, bool bOverride_VolumeCloudCustomLighting, bool bOverride_VolumeCloudLight, bool bOverride_VolumeCloudShadow, bool bOverride_VolumeCloudSpeed, bool bOverride_VolumeCloudNearFadeDistance, bool bOverride_bVolumeCloudJustForVRS, bool bOverride_bVolumeCloudNotAffectedByVRS, float DirectionalInscatteringAmount, float DirectionalInscatteringExponent, float DirectionalInscatteringStartDistance, FLinearColor DirectionalInscatteringColor, float Fog1Density, float Fog1HeightOffset, float Fog1Falloff, float Fog1FalloffFarSky, float StartDistance, float MaxOpacity, FLinearColor FogNearColor, FLinearColor FogFarColor, FLinearColor FogBaseColor, float FogNearColorDistance, float FogFarColorDistance, float FogNearFarColorRatio, float FogMixDistance, float FogMixWidth, float LowPoint1, float HighPoint1, float LowFalloff1, float LowSkyFalloff1, float LowHighOffset1, float SingleCloudOpacity, float CloudOceanHeight, float CloudOpacity, UMaterialInterface CloudOceanMaterial, FVector VolumeCloudPosition, FVector VolumeCloudScale, FVector2D VolumeCloudRange, float VolumeCloudRangeZ, float VolumeCloudOpacity, UMaterialInterface VolumeCloudMaterial, bool bUseVolumeCloudInsteadOfCloudOcean, float VolumeCloudCustomLighting, FLinearColor VolumeCloudLight, FLinearColor VolumeCloudShadow, FLinearColor VolumeCloudSpeed, float VolumeCloudNearFadeDistance, bool bVolumeCloudJustForVRS, bool bVolumeCloudNotAffectedByVRS)
		{
			this.bOverride_DirectionalInscatteringAmount = bOverride_DirectionalInscatteringAmount;
			this.bOverride_DirectionalInscatteringExponent = bOverride_DirectionalInscatteringExponent;
			this.bOverride_DirectionalInscatteringStartDistance = bOverride_DirectionalInscatteringStartDistance;
			this.bOverride_DirectionalInscatteringColor = bOverride_DirectionalInscatteringColor;
			this.bOverride_Fog1Density = bOverride_Fog1Density;
			this.bOverride_Fog1HeightOffset = bOverride_Fog1HeightOffset;
			this.bOverride_Fog1Falloff = bOverride_Fog1Falloff;
			this.bOverride_Fog1FalloffFarSky = bOverride_Fog1FalloffFarSky;
			this.bOverride_StartDistance = bOverride_StartDistance;
			this.bOverride_MaxOpacity = bOverride_MaxOpacity;
			this.bOverride_FogNearColor = bOverride_FogNearColor;
			this.bOverride_FogFarColor = bOverride_FogFarColor;
			this.bOverride_FogBaseColor = bOverride_FogBaseColor;
			this.bOverride_FogNearColorDistance = bOverride_FogNearColorDistance;
			this.bOverride_FogFarColorDistance = bOverride_FogFarColorDistance;
			this.bOverride_FogNearFarColorRatio = bOverride_FogNearFarColorRatio;
			this.bOverride_FogMixDistance = bOverride_FogMixDistance;
			this.bOverride_FogMixWidth = bOverride_FogMixWidth;
			this.bOverride_LowPoint1 = bOverride_LowPoint1;
			this.bOverride_HighPoint1 = bOverride_HighPoint1;
			this.bOverride_LowFalloff1 = bOverride_LowFalloff1;
			this.bOverride_LowSkyFalloff1 = bOverride_LowSkyFalloff1;
			this.bOverride_LowHighOffset1 = bOverride_LowHighOffset1;
			this.bOverride_SingleCloudOpacity = bOverride_SingleCloudOpacity;
			this.bOverride_CloudOceanHeight = bOverride_CloudOceanHeight;
			this.bOverride_CloudOpacity = bOverride_CloudOpacity;
			this.bOverride_CloudOceanMaterial = bOverride_CloudOceanMaterial;
			this.bOverride_VolumeCloudPosition = bOverride_VolumeCloudPosition;
			this.bOverride_VolumeCloudScale = bOverride_VolumeCloudScale;
			this.bOverride_VolumeCloudRange = bOverride_VolumeCloudRange;
			this.bOverride_VolumeCloudRangeZ = bOverride_VolumeCloudRangeZ;
			this.bOverride_VolumeCloudOpacity = bOverride_VolumeCloudOpacity;
			this.bOverride_VolumeCloudMaterial = bOverride_VolumeCloudMaterial;
			this.bOverride_bUseVolumeCloudInsteadOfCloudOcean = bOverride_bUseVolumeCloudInsteadOfCloudOcean;
			this.bOverride_VolumeCloudCustomLighting = bOverride_VolumeCloudCustomLighting;
			this.bOverride_VolumeCloudLight = bOverride_VolumeCloudLight;
			this.bOverride_VolumeCloudShadow = bOverride_VolumeCloudShadow;
			this.bOverride_VolumeCloudSpeed = bOverride_VolumeCloudSpeed;
			this.bOverride_VolumeCloudNearFadeDistance = bOverride_VolumeCloudNearFadeDistance;
			this.bOverride_bVolumeCloudJustForVRS = bOverride_bVolumeCloudJustForVRS;
			this.bOverride_bVolumeCloudNotAffectedByVRS = bOverride_bVolumeCloudNotAffectedByVRS;
			this.DirectionalInscatteringAmount = DirectionalInscatteringAmount;
			this.DirectionalInscatteringExponent = DirectionalInscatteringExponent;
			this.DirectionalInscatteringStartDistance = DirectionalInscatteringStartDistance;
			this.DirectionalInscatteringColor = DirectionalInscatteringColor;
			this.Fog1Density = Fog1Density;
			this.Fog1HeightOffset = Fog1HeightOffset;
			this.Fog1Falloff = Fog1Falloff;
			this.Fog1FalloffFarSky = Fog1FalloffFarSky;
			this.StartDistance = StartDistance;
			this.MaxOpacity = MaxOpacity;
			this.FogNearColor = FogNearColor;
			this.FogFarColor = FogFarColor;
			this.FogBaseColor = FogBaseColor;
			this.FogNearColorDistance = FogNearColorDistance;
			this.FogFarColorDistance = FogFarColorDistance;
			this.FogNearFarColorRatio = FogNearFarColorRatio;
			this.FogMixDistance = FogMixDistance;
			this.FogMixWidth = FogMixWidth;
			this.LowPoint1 = LowPoint1;
			this.HighPoint1 = HighPoint1;
			this.LowFalloff1 = LowFalloff1;
			this.LowSkyFalloff1 = LowSkyFalloff1;
			this.LowHighOffset1 = LowHighOffset1;
			this.SingleCloudOpacity = SingleCloudOpacity;
			this.CloudOceanHeight = CloudOceanHeight;
			this.CloudOpacity = CloudOpacity;
			this.CloudOceanMaterial = CloudOceanMaterial;
			this.VolumeCloudPosition = VolumeCloudPosition;
			this.VolumeCloudScale = VolumeCloudScale;
			this.VolumeCloudRange = VolumeCloudRange;
			this.VolumeCloudRangeZ = VolumeCloudRangeZ;
			this.VolumeCloudOpacity = VolumeCloudOpacity;
			this.VolumeCloudMaterial = VolumeCloudMaterial;
			this.bUseVolumeCloudInsteadOfCloudOcean = bUseVolumeCloudInsteadOfCloudOcean;
			this.VolumeCloudCustomLighting = VolumeCloudCustomLighting;
			this.VolumeCloudLight = VolumeCloudLight;
			this.VolumeCloudShadow = VolumeCloudShadow;
			this.VolumeCloudSpeed = VolumeCloudSpeed;
			this.VolumeCloudNearFadeDistance = VolumeCloudNearFadeDistance;
			this.bVolumeCloudJustForVRS = bVolumeCloudJustForVRS;
			this.bVolumeCloudNotAffectedByVRS = bVolumeCloudNotAffectedByVRS;
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x0026A4D8 File Offset: 0x002686D8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHeightFogSetting.StaticStruct();
		}

		// Token: 0x0601A2A5 RID: 107173 RVA: 0x0026A4E4 File Offset: 0x002686E4
		public FKuroHeightFogSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A2A6 RID: 107174 RVA: 0x0026A4EE File Offset: 0x002686EE
		public FKuroHeightFogSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A2A7 RID: 107175 RVA: 0x0026A4F9 File Offset: 0x002686F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHeightFogSetting(Pointer, false, true);
		}

		// Token: 0x0601A2A8 RID: 107176 RVA: 0x0026A503 File Offset: 0x00268703
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHeightFogSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E2FD RID: 58109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHeightFogSetting";

		// Token: 0x0400E2FE RID: 58110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E2FF RID: 58111
		internal static int __PropertyOffset_bOverride_DirectionalInscatteringAmount;

		// Token: 0x0400E300 RID: 58112
		internal static byte __PropertyMask_bOverride_DirectionalInscatteringAmount;

		// Token: 0x0400E301 RID: 58113
		internal static int __PropertyOffset_bOverride_DirectionalInscatteringExponent;

		// Token: 0x0400E302 RID: 58114
		internal static byte __PropertyMask_bOverride_DirectionalInscatteringExponent;

		// Token: 0x0400E303 RID: 58115
		internal static int __PropertyOffset_bOverride_DirectionalInscatteringStartDistance;

		// Token: 0x0400E304 RID: 58116
		internal static byte __PropertyMask_bOverride_DirectionalInscatteringStartDistance;

		// Token: 0x0400E305 RID: 58117
		internal static int __PropertyOffset_bOverride_DirectionalInscatteringColor;

		// Token: 0x0400E306 RID: 58118
		internal static byte __PropertyMask_bOverride_DirectionalInscatteringColor;

		// Token: 0x0400E307 RID: 58119
		internal static int __PropertyOffset_bOverride_Fog1Density;

		// Token: 0x0400E308 RID: 58120
		internal static byte __PropertyMask_bOverride_Fog1Density;

		// Token: 0x0400E309 RID: 58121
		internal static int __PropertyOffset_bOverride_Fog1HeightOffset;

		// Token: 0x0400E30A RID: 58122
		internal static byte __PropertyMask_bOverride_Fog1HeightOffset;

		// Token: 0x0400E30B RID: 58123
		internal static int __PropertyOffset_bOverride_Fog1Falloff;

		// Token: 0x0400E30C RID: 58124
		internal static byte __PropertyMask_bOverride_Fog1Falloff;

		// Token: 0x0400E30D RID: 58125
		internal static int __PropertyOffset_bOverride_Fog1FalloffFarSky;

		// Token: 0x0400E30E RID: 58126
		internal static byte __PropertyMask_bOverride_Fog1FalloffFarSky;

		// Token: 0x0400E30F RID: 58127
		internal static int __PropertyOffset_bOverride_StartDistance;

		// Token: 0x0400E310 RID: 58128
		internal static byte __PropertyMask_bOverride_StartDistance;

		// Token: 0x0400E311 RID: 58129
		internal static int __PropertyOffset_bOverride_MaxOpacity;

		// Token: 0x0400E312 RID: 58130
		internal static byte __PropertyMask_bOverride_MaxOpacity;

		// Token: 0x0400E313 RID: 58131
		internal static int __PropertyOffset_bOverride_FogNearColor;

		// Token: 0x0400E314 RID: 58132
		internal static byte __PropertyMask_bOverride_FogNearColor;

		// Token: 0x0400E315 RID: 58133
		internal static int __PropertyOffset_bOverride_FogFarColor;

		// Token: 0x0400E316 RID: 58134
		internal static byte __PropertyMask_bOverride_FogFarColor;

		// Token: 0x0400E317 RID: 58135
		internal static int __PropertyOffset_bOverride_FogBaseColor;

		// Token: 0x0400E318 RID: 58136
		internal static byte __PropertyMask_bOverride_FogBaseColor;

		// Token: 0x0400E319 RID: 58137
		internal static int __PropertyOffset_bOverride_FogNearColorDistance;

		// Token: 0x0400E31A RID: 58138
		internal static byte __PropertyMask_bOverride_FogNearColorDistance;

		// Token: 0x0400E31B RID: 58139
		internal static int __PropertyOffset_bOverride_FogFarColorDistance;

		// Token: 0x0400E31C RID: 58140
		internal static byte __PropertyMask_bOverride_FogFarColorDistance;

		// Token: 0x0400E31D RID: 58141
		internal static int __PropertyOffset_bOverride_FogNearFarColorRatio;

		// Token: 0x0400E31E RID: 58142
		internal static byte __PropertyMask_bOverride_FogNearFarColorRatio;

		// Token: 0x0400E31F RID: 58143
		internal static int __PropertyOffset_bOverride_FogMixDistance;

		// Token: 0x0400E320 RID: 58144
		internal static byte __PropertyMask_bOverride_FogMixDistance;

		// Token: 0x0400E321 RID: 58145
		internal static int __PropertyOffset_bOverride_FogMixWidth;

		// Token: 0x0400E322 RID: 58146
		internal static byte __PropertyMask_bOverride_FogMixWidth;

		// Token: 0x0400E323 RID: 58147
		internal static int __PropertyOffset_bOverride_LowPoint1;

		// Token: 0x0400E324 RID: 58148
		internal static byte __PropertyMask_bOverride_LowPoint1;

		// Token: 0x0400E325 RID: 58149
		internal static int __PropertyOffset_bOverride_HighPoint1;

		// Token: 0x0400E326 RID: 58150
		internal static byte __PropertyMask_bOverride_HighPoint1;

		// Token: 0x0400E327 RID: 58151
		internal static int __PropertyOffset_bOverride_LowFalloff1;

		// Token: 0x0400E328 RID: 58152
		internal static byte __PropertyMask_bOverride_LowFalloff1;

		// Token: 0x0400E329 RID: 58153
		internal static int __PropertyOffset_bOverride_LowSkyFalloff1;

		// Token: 0x0400E32A RID: 58154
		internal static byte __PropertyMask_bOverride_LowSkyFalloff1;

		// Token: 0x0400E32B RID: 58155
		internal static int __PropertyOffset_bOverride_LowHighOffset1;

		// Token: 0x0400E32C RID: 58156
		internal static byte __PropertyMask_bOverride_LowHighOffset1;

		// Token: 0x0400E32D RID: 58157
		internal static int __PropertyOffset_bOverride_SingleCloudOpacity;

		// Token: 0x0400E32E RID: 58158
		internal static byte __PropertyMask_bOverride_SingleCloudOpacity;

		// Token: 0x0400E32F RID: 58159
		internal static int __PropertyOffset_bOverride_CloudOceanHeight;

		// Token: 0x0400E330 RID: 58160
		internal static byte __PropertyMask_bOverride_CloudOceanHeight;

		// Token: 0x0400E331 RID: 58161
		internal static int __PropertyOffset_bOverride_CloudOpacity;

		// Token: 0x0400E332 RID: 58162
		internal static byte __PropertyMask_bOverride_CloudOpacity;

		// Token: 0x0400E333 RID: 58163
		internal static int __PropertyOffset_bOverride_CloudOceanMaterial;

		// Token: 0x0400E334 RID: 58164
		internal static byte __PropertyMask_bOverride_CloudOceanMaterial;

		// Token: 0x0400E335 RID: 58165
		internal static int __PropertyOffset_bOverride_VolumeCloudPosition;

		// Token: 0x0400E336 RID: 58166
		internal static byte __PropertyMask_bOverride_VolumeCloudPosition;

		// Token: 0x0400E337 RID: 58167
		internal static int __PropertyOffset_bOverride_VolumeCloudScale;

		// Token: 0x0400E338 RID: 58168
		internal static byte __PropertyMask_bOverride_VolumeCloudScale;

		// Token: 0x0400E339 RID: 58169
		internal static int __PropertyOffset_bOverride_VolumeCloudRange;

		// Token: 0x0400E33A RID: 58170
		internal static byte __PropertyMask_bOverride_VolumeCloudRange;

		// Token: 0x0400E33B RID: 58171
		internal static int __PropertyOffset_bOverride_VolumeCloudRangeZ;

		// Token: 0x0400E33C RID: 58172
		internal static byte __PropertyMask_bOverride_VolumeCloudRangeZ;

		// Token: 0x0400E33D RID: 58173
		internal static int __PropertyOffset_bOverride_VolumeCloudOpacity;

		// Token: 0x0400E33E RID: 58174
		internal static byte __PropertyMask_bOverride_VolumeCloudOpacity;

		// Token: 0x0400E33F RID: 58175
		internal static int __PropertyOffset_bOverride_VolumeCloudMaterial;

		// Token: 0x0400E340 RID: 58176
		internal static byte __PropertyMask_bOverride_VolumeCloudMaterial;

		// Token: 0x0400E341 RID: 58177
		internal static int __PropertyOffset_bOverride_bUseVolumeCloudInsteadOfCloudOcean;

		// Token: 0x0400E342 RID: 58178
		internal static byte __PropertyMask_bOverride_bUseVolumeCloudInsteadOfCloudOcean;

		// Token: 0x0400E343 RID: 58179
		internal static int __PropertyOffset_bOverride_VolumeCloudCustomLighting;

		// Token: 0x0400E344 RID: 58180
		internal static byte __PropertyMask_bOverride_VolumeCloudCustomLighting;

		// Token: 0x0400E345 RID: 58181
		internal static int __PropertyOffset_bOverride_VolumeCloudLight;

		// Token: 0x0400E346 RID: 58182
		internal static byte __PropertyMask_bOverride_VolumeCloudLight;

		// Token: 0x0400E347 RID: 58183
		internal static int __PropertyOffset_bOverride_VolumeCloudShadow;

		// Token: 0x0400E348 RID: 58184
		internal static byte __PropertyMask_bOverride_VolumeCloudShadow;

		// Token: 0x0400E349 RID: 58185
		internal static int __PropertyOffset_bOverride_VolumeCloudSpeed;

		// Token: 0x0400E34A RID: 58186
		internal static byte __PropertyMask_bOverride_VolumeCloudSpeed;

		// Token: 0x0400E34B RID: 58187
		internal static int __PropertyOffset_bOverride_VolumeCloudNearFadeDistance;

		// Token: 0x0400E34C RID: 58188
		internal static byte __PropertyMask_bOverride_VolumeCloudNearFadeDistance;

		// Token: 0x0400E34D RID: 58189
		internal static int __PropertyOffset_bOverride_bVolumeCloudJustForVRS;

		// Token: 0x0400E34E RID: 58190
		internal static byte __PropertyMask_bOverride_bVolumeCloudJustForVRS;

		// Token: 0x0400E34F RID: 58191
		internal static int __PropertyOffset_bOverride_bVolumeCloudNotAffectedByVRS;

		// Token: 0x0400E350 RID: 58192
		internal static byte __PropertyMask_bOverride_bVolumeCloudNotAffectedByVRS;

		// Token: 0x0400E351 RID: 58193
		internal static int __PropertyOffset_DirectionalInscatteringAmount;

		// Token: 0x0400E352 RID: 58194
		internal static int __PropertyOffset_DirectionalInscatteringExponent;

		// Token: 0x0400E353 RID: 58195
		internal static int __PropertyOffset_DirectionalInscatteringStartDistance;

		// Token: 0x0400E354 RID: 58196
		internal static int __PropertyOffset_DirectionalInscatteringColor;

		// Token: 0x0400E355 RID: 58197
		internal static int __PropertyOffset_Fog1Density;

		// Token: 0x0400E356 RID: 58198
		internal static int __PropertyOffset_Fog1HeightOffset;

		// Token: 0x0400E357 RID: 58199
		internal static int __PropertyOffset_Fog1Falloff;

		// Token: 0x0400E358 RID: 58200
		internal static int __PropertyOffset_Fog1FalloffFarSky;

		// Token: 0x0400E359 RID: 58201
		internal static int __PropertyOffset_StartDistance;

		// Token: 0x0400E35A RID: 58202
		internal static int __PropertyOffset_MaxOpacity;

		// Token: 0x0400E35B RID: 58203
		internal static int __PropertyOffset_FogNearColor;

		// Token: 0x0400E35C RID: 58204
		internal static int __PropertyOffset_FogFarColor;

		// Token: 0x0400E35D RID: 58205
		internal static int __PropertyOffset_FogBaseColor;

		// Token: 0x0400E35E RID: 58206
		internal static int __PropertyOffset_FogNearColorDistance;

		// Token: 0x0400E35F RID: 58207
		internal static int __PropertyOffset_FogFarColorDistance;

		// Token: 0x0400E360 RID: 58208
		internal static int __PropertyOffset_FogNearFarColorRatio;

		// Token: 0x0400E361 RID: 58209
		internal static int __PropertyOffset_FogMixDistance;

		// Token: 0x0400E362 RID: 58210
		internal static int __PropertyOffset_FogMixWidth;

		// Token: 0x0400E363 RID: 58211
		internal static int __PropertyOffset_LowPoint1;

		// Token: 0x0400E364 RID: 58212
		internal static int __PropertyOffset_HighPoint1;

		// Token: 0x0400E365 RID: 58213
		internal static int __PropertyOffset_LowFalloff1;

		// Token: 0x0400E366 RID: 58214
		internal static int __PropertyOffset_LowSkyFalloff1;

		// Token: 0x0400E367 RID: 58215
		internal static int __PropertyOffset_LowHighOffset1;

		// Token: 0x0400E368 RID: 58216
		internal static int __PropertyOffset_SingleCloudOpacity;

		// Token: 0x0400E369 RID: 58217
		internal static int __PropertyOffset_CloudOceanHeight;

		// Token: 0x0400E36A RID: 58218
		internal static int __PropertyOffset_CloudOpacity;

		// Token: 0x0400E36B RID: 58219
		internal static int __PropertyOffset_CloudOceanMaterial;

		// Token: 0x0400E36C RID: 58220
		internal static int __PropertyOffset_VolumeCloudPosition;

		// Token: 0x0400E36D RID: 58221
		internal static int __PropertyOffset_VolumeCloudScale;

		// Token: 0x0400E36E RID: 58222
		internal static int __PropertyOffset_VolumeCloudRange;

		// Token: 0x0400E36F RID: 58223
		internal static int __PropertyOffset_VolumeCloudRangeZ;

		// Token: 0x0400E370 RID: 58224
		internal static int __PropertyOffset_VolumeCloudOpacity;

		// Token: 0x0400E371 RID: 58225
		internal static int __PropertyOffset_VolumeCloudMaterial;

		// Token: 0x0400E372 RID: 58226
		internal static int __PropertyOffset_bUseVolumeCloudInsteadOfCloudOcean;

		// Token: 0x0400E373 RID: 58227
		internal static int __PropertyOffset_VolumeCloudCustomLighting;

		// Token: 0x0400E374 RID: 58228
		internal static int __PropertyOffset_VolumeCloudLight;

		// Token: 0x0400E375 RID: 58229
		internal static int __PropertyOffset_VolumeCloudShadow;

		// Token: 0x0400E376 RID: 58230
		internal static int __PropertyOffset_VolumeCloudSpeed;

		// Token: 0x0400E377 RID: 58231
		internal static int __PropertyOffset_VolumeCloudNearFadeDistance;

		// Token: 0x0400E378 RID: 58232
		internal static int __PropertyOffset_bVolumeCloudJustForVRS;

		// Token: 0x0400E379 RID: 58233
		internal static int __PropertyOffset_bVolumeCloudNotAffectedByVRS;
	}
}
