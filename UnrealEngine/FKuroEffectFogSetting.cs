using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AED RID: 6893
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectFogSetting")]
	[UnrealStructLayout(100, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 100)]
	public class FKuroEffectFogSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019B69 RID: 105321 RVA: 0x0025FB7B File Offset: 0x0025DD7B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectFogSetting._ScriptStructPtr != 0) ? FKuroEffectFogSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectFogSetting", ref FKuroEffectFogSetting._ScriptStructPtr);
		}

		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x06019B6A RID: 105322 RVA: 0x0025FB9F File Offset: 0x0025DD9F
		// (set) Token: 0x06019B6B RID: 105323 RVA: 0x0025FBB8 File Offset: 0x0025DDB8
		public unsafe bool bOverride_KuroEffectFogSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogSwitch) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogSwitch) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogSwitch) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogSwitch) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogSwitch : 0));
			}
		}

		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x06019B6C RID: 105324 RVA: 0x0025FBE8 File Offset: 0x0025DDE8
		// (set) Token: 0x06019B6D RID: 105325 RVA: 0x0025FC01 File Offset: 0x0025DE01
		public unsafe bool bOverride_KuroEffectFogBlendSceneFogMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBlendSceneFogMin) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBlendSceneFogMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBlendSceneFogMin) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBlendSceneFogMin) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBlendSceneFogMin) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBlendSceneFogMin : 0));
			}
		}

		// Token: 0x170066B4 RID: 26292
		// (get) Token: 0x06019B6E RID: 105326 RVA: 0x0025FC31 File Offset: 0x0025DE31
		// (set) Token: 0x06019B6F RID: 105327 RVA: 0x0025FC4A File Offset: 0x0025DE4A
		public unsafe bool bOverride_KuroEffectFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogDensity) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogDensity) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogDensity) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogDensity) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogDensity : 0));
			}
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x06019B70 RID: 105328 RVA: 0x0025FC7A File Offset: 0x0025DE7A
		// (set) Token: 0x06019B71 RID: 105329 RVA: 0x0025FC93 File Offset: 0x0025DE93
		public unsafe bool bOverride_KuroEffectFogFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloff) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloff) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloff) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloff) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloff : 0));
			}
		}

		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x06019B72 RID: 105330 RVA: 0x0025FCC3 File Offset: 0x0025DEC3
		// (set) Token: 0x06019B73 RID: 105331 RVA: 0x0025FCDC File Offset: 0x0025DEDC
		public unsafe bool bOverride_KuroEffectFogFalloffFarSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloffFarSky) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloffFarSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloffFarSky) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFalloffFarSky) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloffFarSky) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFalloffFarSky : 0));
			}
		}

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x06019B74 RID: 105332 RVA: 0x0025FD0C File Offset: 0x0025DF0C
		// (set) Token: 0x06019B75 RID: 105333 RVA: 0x0025FD25 File Offset: 0x0025DF25
		public unsafe bool bOverride_KuroEffectFogStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogStartDistance) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogStartDistance) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogStartDistance) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogStartDistance) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogStartDistance : 0));
			}
		}

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x06019B76 RID: 105334 RVA: 0x0025FD55 File Offset: 0x0025DF55
		// (set) Token: 0x06019B77 RID: 105335 RVA: 0x0025FD6E File Offset: 0x0025DF6E
		public unsafe bool bOverride_KuroEffectFogMaxOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMaxOpacity) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMaxOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMaxOpacity) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMaxOpacity) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMaxOpacity) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMaxOpacity : 0));
			}
		}

		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x06019B78 RID: 105336 RVA: 0x0025FD9E File Offset: 0x0025DF9E
		// (set) Token: 0x06019B79 RID: 105337 RVA: 0x0025FDB7 File Offset: 0x0025DFB7
		public unsafe bool bOverride_KuroEffectFogNearColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColor) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColor) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColor) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColor : 0));
			}
		}

		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x06019B7A RID: 105338 RVA: 0x0025FDE7 File Offset: 0x0025DFE7
		// (set) Token: 0x06019B7B RID: 105339 RVA: 0x0025FE00 File Offset: 0x0025E000
		public unsafe bool bOverride_KuroEffectFogFarColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColor) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColor) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColor) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColor : 0));
			}
		}

		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x06019B7C RID: 105340 RVA: 0x0025FE30 File Offset: 0x0025E030
		// (set) Token: 0x06019B7D RID: 105341 RVA: 0x0025FE49 File Offset: 0x0025E049
		public unsafe bool bOverride_KuroEffectFogBaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBaseColor) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBaseColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogBaseColor) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBaseColor) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogBaseColor : 0));
			}
		}

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x06019B7E RID: 105342 RVA: 0x0025FE79 File Offset: 0x0025E079
		// (set) Token: 0x06019B7F RID: 105343 RVA: 0x0025FE92 File Offset: 0x0025E092
		public unsafe bool bOverride_KuroEffectFogNearColorDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColorDistance) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColorDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColorDistance) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearColorDistance) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColorDistance) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearColorDistance : 0));
			}
		}

		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x06019B80 RID: 105344 RVA: 0x0025FEC2 File Offset: 0x0025E0C2
		// (set) Token: 0x06019B81 RID: 105345 RVA: 0x0025FEDB File Offset: 0x0025E0DB
		public unsafe bool bOverride_KuroEffectFogFarColorDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColorDistance) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColorDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColorDistance) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogFarColorDistance) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColorDistance) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogFarColorDistance : 0));
			}
		}

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x06019B82 RID: 105346 RVA: 0x0025FF0B File Offset: 0x0025E10B
		// (set) Token: 0x06019B83 RID: 105347 RVA: 0x0025FF24 File Offset: 0x0025E124
		public unsafe bool bOverride_KuroEffectFogNearFarColorRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearFarColorRatio) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearFarColorRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearFarColorRatio) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogNearFarColorRatio) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearFarColorRatio) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogNearFarColorRatio : 0));
			}
		}

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x06019B84 RID: 105348 RVA: 0x0025FF54 File Offset: 0x0025E154
		// (set) Token: 0x06019B85 RID: 105349 RVA: 0x0025FF6D File Offset: 0x0025E16D
		public unsafe bool bOverride_KuroEffectFogMixDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixDistance) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixDistance) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixDistance) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixDistance) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixDistance : 0));
			}
		}

		// Token: 0x170066C0 RID: 26304
		// (get) Token: 0x06019B86 RID: 105350 RVA: 0x0025FF9D File Offset: 0x0025E19D
		// (set) Token: 0x06019B87 RID: 105351 RVA: 0x0025FFB6 File Offset: 0x0025E1B6
		public unsafe bool bOverride_KuroEffectFogMixWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixWidth) & FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixWidth) = ((*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_bOverride_KuroEffectFogMixWidth) & ~FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixWidth) | (value ? FKuroEffectFogSetting.__PropertyMask_bOverride_KuroEffectFogMixWidth : 0));
			}
		}

		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x06019B88 RID: 105352 RVA: 0x0025FFE6 File Offset: 0x0025E1E6
		// (set) Token: 0x06019B89 RID: 105353 RVA: 0x0025FFF6 File Offset: 0x0025E1F6
		public unsafe float KuroEffectFogSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogSwitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogSwitch) = value;
			}
		}

		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x06019B8A RID: 105354 RVA: 0x00260007 File Offset: 0x0025E207
		// (set) Token: 0x06019B8B RID: 105355 RVA: 0x00260017 File Offset: 0x0025E217
		public unsafe float KuroEffectFogBlendSceneFogMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogBlendSceneFogMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogBlendSceneFogMin) = value;
			}
		}

		// Token: 0x170066C3 RID: 26307
		// (get) Token: 0x06019B8C RID: 105356 RVA: 0x00260028 File Offset: 0x0025E228
		// (set) Token: 0x06019B8D RID: 105357 RVA: 0x00260038 File Offset: 0x0025E238
		public unsafe float KuroEffectFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogDensity) = value;
			}
		}

		// Token: 0x170066C4 RID: 26308
		// (get) Token: 0x06019B8E RID: 105358 RVA: 0x00260049 File Offset: 0x0025E249
		// (set) Token: 0x06019B8F RID: 105359 RVA: 0x00260059 File Offset: 0x0025E259
		public unsafe float KuroEffectFogFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFalloff) = value;
			}
		}

		// Token: 0x170066C5 RID: 26309
		// (get) Token: 0x06019B90 RID: 105360 RVA: 0x0026006A File Offset: 0x0025E26A
		// (set) Token: 0x06019B91 RID: 105361 RVA: 0x0026007A File Offset: 0x0025E27A
		public unsafe float KuroEffectFogFalloffFarSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFalloffFarSky);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFalloffFarSky) = value;
			}
		}

		// Token: 0x170066C6 RID: 26310
		// (get) Token: 0x06019B92 RID: 105362 RVA: 0x0026008B File Offset: 0x0025E28B
		// (set) Token: 0x06019B93 RID: 105363 RVA: 0x0026009B File Offset: 0x0025E29B
		public unsafe float KuroEffectFogStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogStartDistance) = value;
			}
		}

		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x06019B94 RID: 105364 RVA: 0x002600AC File Offset: 0x0025E2AC
		// (set) Token: 0x06019B95 RID: 105365 RVA: 0x002600BC File Offset: 0x0025E2BC
		public unsafe float KuroEffectFogMaxOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMaxOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMaxOpacity) = value;
			}
		}

		// Token: 0x170066C8 RID: 26312
		// (get) Token: 0x06019B96 RID: 105366 RVA: 0x002600CD File Offset: 0x0025E2CD
		// (set) Token: 0x06019B97 RID: 105367 RVA: 0x002600E1 File Offset: 0x0025E2E1
		public unsafe FLinearColor KuroEffectFogNearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearColor) = value;
			}
		}

		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x06019B98 RID: 105368 RVA: 0x002600F6 File Offset: 0x0025E2F6
		// (set) Token: 0x06019B99 RID: 105369 RVA: 0x0026010A File Offset: 0x0025E30A
		public unsafe FLinearColor KuroEffectFogFarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFarColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFarColor) = value;
			}
		}

		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x06019B9A RID: 105370 RVA: 0x0026011F File Offset: 0x0025E31F
		// (set) Token: 0x06019B9B RID: 105371 RVA: 0x00260133 File Offset: 0x0025E333
		public unsafe FLinearColor KuroEffectFogBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogBaseColor) = value;
			}
		}

		// Token: 0x170066CB RID: 26315
		// (get) Token: 0x06019B9C RID: 105372 RVA: 0x00260148 File Offset: 0x0025E348
		// (set) Token: 0x06019B9D RID: 105373 RVA: 0x00260158 File Offset: 0x0025E358
		public unsafe float KuroEffectFogNearColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearColorDistance) = value;
			}
		}

		// Token: 0x170066CC RID: 26316
		// (get) Token: 0x06019B9E RID: 105374 RVA: 0x00260169 File Offset: 0x0025E369
		// (set) Token: 0x06019B9F RID: 105375 RVA: 0x00260179 File Offset: 0x0025E379
		public unsafe float KuroEffectFogFarColorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFarColorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogFarColorDistance) = value;
			}
		}

		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x06019BA0 RID: 105376 RVA: 0x0026018A File Offset: 0x0025E38A
		// (set) Token: 0x06019BA1 RID: 105377 RVA: 0x0026019A File Offset: 0x0025E39A
		public unsafe float KuroEffectFogNearFarColorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearFarColorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogNearFarColorRatio) = value;
			}
		}

		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x06019BA2 RID: 105378 RVA: 0x002601AB File Offset: 0x0025E3AB
		// (set) Token: 0x06019BA3 RID: 105379 RVA: 0x002601BB File Offset: 0x0025E3BB
		public unsafe float KuroEffectFogMixDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMixDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMixDistance) = value;
			}
		}

		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x06019BA4 RID: 105380 RVA: 0x002601CC File Offset: 0x0025E3CC
		// (set) Token: 0x06019BA5 RID: 105381 RVA: 0x002601DC File Offset: 0x0025E3DC
		public unsafe float KuroEffectFogMixWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMixWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectFogSetting.__PropertyOffset_KuroEffectFogMixWidth) = value;
			}
		}

		// Token: 0x06019BA6 RID: 105382 RVA: 0x002601ED File Offset: 0x0025E3ED
		public FKuroEffectFogSetting()
		{
		}

		// Token: 0x06019BA7 RID: 105383 RVA: 0x002601F8 File Offset: 0x0025E3F8
		public FKuroEffectFogSetting(bool bOverride_KuroEffectFogSwitch, bool bOverride_KuroEffectFogBlendSceneFogMin, bool bOverride_KuroEffectFogDensity, bool bOverride_KuroEffectFogFalloff, bool bOverride_KuroEffectFogFalloffFarSky, bool bOverride_KuroEffectFogStartDistance, bool bOverride_KuroEffectFogMaxOpacity, bool bOverride_KuroEffectFogNearColor, bool bOverride_KuroEffectFogFarColor, bool bOverride_KuroEffectFogBaseColor, bool bOverride_KuroEffectFogNearColorDistance, bool bOverride_KuroEffectFogFarColorDistance, bool bOverride_KuroEffectFogNearFarColorRatio, bool bOverride_KuroEffectFogMixDistance, bool bOverride_KuroEffectFogMixWidth, float KuroEffectFogSwitch, float KuroEffectFogBlendSceneFogMin, float KuroEffectFogDensity, float KuroEffectFogFalloff, float KuroEffectFogFalloffFarSky, float KuroEffectFogStartDistance, float KuroEffectFogMaxOpacity, FLinearColor KuroEffectFogNearColor, FLinearColor KuroEffectFogFarColor, FLinearColor KuroEffectFogBaseColor, float KuroEffectFogNearColorDistance, float KuroEffectFogFarColorDistance, float KuroEffectFogNearFarColorRatio, float KuroEffectFogMixDistance, float KuroEffectFogMixWidth)
		{
			this.bOverride_KuroEffectFogSwitch = bOverride_KuroEffectFogSwitch;
			this.bOverride_KuroEffectFogBlendSceneFogMin = bOverride_KuroEffectFogBlendSceneFogMin;
			this.bOverride_KuroEffectFogDensity = bOverride_KuroEffectFogDensity;
			this.bOverride_KuroEffectFogFalloff = bOverride_KuroEffectFogFalloff;
			this.bOverride_KuroEffectFogFalloffFarSky = bOverride_KuroEffectFogFalloffFarSky;
			this.bOverride_KuroEffectFogStartDistance = bOverride_KuroEffectFogStartDistance;
			this.bOverride_KuroEffectFogMaxOpacity = bOverride_KuroEffectFogMaxOpacity;
			this.bOverride_KuroEffectFogNearColor = bOverride_KuroEffectFogNearColor;
			this.bOverride_KuroEffectFogFarColor = bOverride_KuroEffectFogFarColor;
			this.bOverride_KuroEffectFogBaseColor = bOverride_KuroEffectFogBaseColor;
			this.bOverride_KuroEffectFogNearColorDistance = bOverride_KuroEffectFogNearColorDistance;
			this.bOverride_KuroEffectFogFarColorDistance = bOverride_KuroEffectFogFarColorDistance;
			this.bOverride_KuroEffectFogNearFarColorRatio = bOverride_KuroEffectFogNearFarColorRatio;
			this.bOverride_KuroEffectFogMixDistance = bOverride_KuroEffectFogMixDistance;
			this.bOverride_KuroEffectFogMixWidth = bOverride_KuroEffectFogMixWidth;
			this.KuroEffectFogSwitch = KuroEffectFogSwitch;
			this.KuroEffectFogBlendSceneFogMin = KuroEffectFogBlendSceneFogMin;
			this.KuroEffectFogDensity = KuroEffectFogDensity;
			this.KuroEffectFogFalloff = KuroEffectFogFalloff;
			this.KuroEffectFogFalloffFarSky = KuroEffectFogFalloffFarSky;
			this.KuroEffectFogStartDistance = KuroEffectFogStartDistance;
			this.KuroEffectFogMaxOpacity = KuroEffectFogMaxOpacity;
			this.KuroEffectFogNearColor = KuroEffectFogNearColor;
			this.KuroEffectFogFarColor = KuroEffectFogFarColor;
			this.KuroEffectFogBaseColor = KuroEffectFogBaseColor;
			this.KuroEffectFogNearColorDistance = KuroEffectFogNearColorDistance;
			this.KuroEffectFogFarColorDistance = KuroEffectFogFarColorDistance;
			this.KuroEffectFogNearFarColorRatio = KuroEffectFogNearFarColorRatio;
			this.KuroEffectFogMixDistance = KuroEffectFogMixDistance;
			this.KuroEffectFogMixWidth = KuroEffectFogMixWidth;
		}

		// Token: 0x06019BA8 RID: 105384 RVA: 0x002602F8 File Offset: 0x0025E4F8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectFogSetting.StaticStruct();
		}

		// Token: 0x06019BA9 RID: 105385 RVA: 0x00260304 File Offset: 0x0025E504
		[NullableContext(2)]
		public FKuroEffectFogSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019BAA RID: 105386 RVA: 0x0026030E File Offset: 0x0025E50E
		public FKuroEffectFogSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019BAB RID: 105387 RVA: 0x00260319 File Offset: 0x0025E519
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectFogSetting(Pointer, false, true);
		}

		// Token: 0x06019BAC RID: 105388 RVA: 0x00260323 File Offset: 0x0025E523
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectFogSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DFB3 RID: 57267
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectFogSetting";

		// Token: 0x0400DFB4 RID: 57268
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DFB5 RID: 57269
		internal static int __PropertyOffset_bOverride_KuroEffectFogSwitch;

		// Token: 0x0400DFB6 RID: 57270
		internal static byte __PropertyMask_bOverride_KuroEffectFogSwitch;

		// Token: 0x0400DFB7 RID: 57271
		internal static int __PropertyOffset_bOverride_KuroEffectFogBlendSceneFogMin;

		// Token: 0x0400DFB8 RID: 57272
		internal static byte __PropertyMask_bOverride_KuroEffectFogBlendSceneFogMin;

		// Token: 0x0400DFB9 RID: 57273
		internal static int __PropertyOffset_bOverride_KuroEffectFogDensity;

		// Token: 0x0400DFBA RID: 57274
		internal static byte __PropertyMask_bOverride_KuroEffectFogDensity;

		// Token: 0x0400DFBB RID: 57275
		internal static int __PropertyOffset_bOverride_KuroEffectFogFalloff;

		// Token: 0x0400DFBC RID: 57276
		internal static byte __PropertyMask_bOverride_KuroEffectFogFalloff;

		// Token: 0x0400DFBD RID: 57277
		internal static int __PropertyOffset_bOverride_KuroEffectFogFalloffFarSky;

		// Token: 0x0400DFBE RID: 57278
		internal static byte __PropertyMask_bOverride_KuroEffectFogFalloffFarSky;

		// Token: 0x0400DFBF RID: 57279
		internal static int __PropertyOffset_bOverride_KuroEffectFogStartDistance;

		// Token: 0x0400DFC0 RID: 57280
		internal static byte __PropertyMask_bOverride_KuroEffectFogStartDistance;

		// Token: 0x0400DFC1 RID: 57281
		internal static int __PropertyOffset_bOverride_KuroEffectFogMaxOpacity;

		// Token: 0x0400DFC2 RID: 57282
		internal static byte __PropertyMask_bOverride_KuroEffectFogMaxOpacity;

		// Token: 0x0400DFC3 RID: 57283
		internal static int __PropertyOffset_bOverride_KuroEffectFogNearColor;

		// Token: 0x0400DFC4 RID: 57284
		internal static byte __PropertyMask_bOverride_KuroEffectFogNearColor;

		// Token: 0x0400DFC5 RID: 57285
		internal static int __PropertyOffset_bOverride_KuroEffectFogFarColor;

		// Token: 0x0400DFC6 RID: 57286
		internal static byte __PropertyMask_bOverride_KuroEffectFogFarColor;

		// Token: 0x0400DFC7 RID: 57287
		internal static int __PropertyOffset_bOverride_KuroEffectFogBaseColor;

		// Token: 0x0400DFC8 RID: 57288
		internal static byte __PropertyMask_bOverride_KuroEffectFogBaseColor;

		// Token: 0x0400DFC9 RID: 57289
		internal static int __PropertyOffset_bOverride_KuroEffectFogNearColorDistance;

		// Token: 0x0400DFCA RID: 57290
		internal static byte __PropertyMask_bOverride_KuroEffectFogNearColorDistance;

		// Token: 0x0400DFCB RID: 57291
		internal static int __PropertyOffset_bOverride_KuroEffectFogFarColorDistance;

		// Token: 0x0400DFCC RID: 57292
		internal static byte __PropertyMask_bOverride_KuroEffectFogFarColorDistance;

		// Token: 0x0400DFCD RID: 57293
		internal static int __PropertyOffset_bOverride_KuroEffectFogNearFarColorRatio;

		// Token: 0x0400DFCE RID: 57294
		internal static byte __PropertyMask_bOverride_KuroEffectFogNearFarColorRatio;

		// Token: 0x0400DFCF RID: 57295
		internal static int __PropertyOffset_bOverride_KuroEffectFogMixDistance;

		// Token: 0x0400DFD0 RID: 57296
		internal static byte __PropertyMask_bOverride_KuroEffectFogMixDistance;

		// Token: 0x0400DFD1 RID: 57297
		internal static int __PropertyOffset_bOverride_KuroEffectFogMixWidth;

		// Token: 0x0400DFD2 RID: 57298
		internal static byte __PropertyMask_bOverride_KuroEffectFogMixWidth;

		// Token: 0x0400DFD3 RID: 57299
		internal static int __PropertyOffset_KuroEffectFogSwitch;

		// Token: 0x0400DFD4 RID: 57300
		internal static int __PropertyOffset_KuroEffectFogBlendSceneFogMin;

		// Token: 0x0400DFD5 RID: 57301
		internal static int __PropertyOffset_KuroEffectFogDensity;

		// Token: 0x0400DFD6 RID: 57302
		internal static int __PropertyOffset_KuroEffectFogFalloff;

		// Token: 0x0400DFD7 RID: 57303
		internal static int __PropertyOffset_KuroEffectFogFalloffFarSky;

		// Token: 0x0400DFD8 RID: 57304
		internal static int __PropertyOffset_KuroEffectFogStartDistance;

		// Token: 0x0400DFD9 RID: 57305
		internal static int __PropertyOffset_KuroEffectFogMaxOpacity;

		// Token: 0x0400DFDA RID: 57306
		internal static int __PropertyOffset_KuroEffectFogNearColor;

		// Token: 0x0400DFDB RID: 57307
		internal static int __PropertyOffset_KuroEffectFogFarColor;

		// Token: 0x0400DFDC RID: 57308
		internal static int __PropertyOffset_KuroEffectFogBaseColor;

		// Token: 0x0400DFDD RID: 57309
		internal static int __PropertyOffset_KuroEffectFogNearColorDistance;

		// Token: 0x0400DFDE RID: 57310
		internal static int __PropertyOffset_KuroEffectFogFarColorDistance;

		// Token: 0x0400DFDF RID: 57311
		internal static int __PropertyOffset_KuroEffectFogNearFarColorRatio;

		// Token: 0x0400DFE0 RID: 57312
		internal static int __PropertyOffset_KuroEffectFogMixDistance;

		// Token: 0x0400DFE1 RID: 57313
		internal static int __PropertyOffset_KuroEffectFogMixWidth;
	}
}
