using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BBC RID: 7100
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyboxSetting")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FKuroSkyboxSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B304 RID: 111364 RVA: 0x00280D47 File Offset: 0x0027EF47
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkyboxSetting._ScriptStructPtr != 0) ? FKuroSkyboxSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyboxSetting", ref FKuroSkyboxSetting._ScriptStructPtr);
		}

		// Token: 0x17006D0C RID: 27916
		// (get) Token: 0x0601B305 RID: 111365 RVA: 0x00280D6B File Offset: 0x0027EF6B
		// (set) Token: 0x0601B306 RID: 111366 RVA: 0x00280D84 File Offset: 0x0027EF84
		public unsafe bool bOverride_ZenithColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ZenithColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_ZenithColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ZenithColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ZenithColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_ZenithColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_ZenithColor : 0));
			}
		}

		// Token: 0x17006D0D RID: 27917
		// (get) Token: 0x0601B307 RID: 111367 RVA: 0x00280DB4 File Offset: 0x0027EFB4
		// (set) Token: 0x0601B308 RID: 111368 RVA: 0x00280DCD File Offset: 0x0027EFCD
		public unsafe bool bOverride_NadirColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_NadirColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_NadirColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_NadirColor : 0));
			}
		}

		// Token: 0x17006D0E RID: 27918
		// (get) Token: 0x0601B309 RID: 111369 RVA: 0x00280DFD File Offset: 0x0027EFFD
		// (set) Token: 0x0601B30A RID: 111370 RVA: 0x00280E16 File Offset: 0x0027F016
		public unsafe bool bOverride_NadirFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff) & FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff : 0));
			}
		}

		// Token: 0x17006D0F RID: 27919
		// (get) Token: 0x0601B30B RID: 111371 RVA: 0x00280E46 File Offset: 0x0027F046
		// (set) Token: 0x0601B30C RID: 111372 RVA: 0x00280E5F File Offset: 0x0027F05F
		public unsafe bool bOverride_NadirFalloff_Mobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) & FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile : 0));
			}
		}

		// Token: 0x17006D10 RID: 27920
		// (get) Token: 0x0601B30D RID: 111373 RVA: 0x00280E8F File Offset: 0x0027F08F
		// (set) Token: 0x0601B30E RID: 111374 RVA: 0x00280EA8 File Offset: 0x0027F0A8
		public unsafe bool bOverride_HorizonColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonColor : 0));
			}
		}

		// Token: 0x17006D11 RID: 27921
		// (get) Token: 0x0601B30F RID: 111375 RVA: 0x00280ED8 File Offset: 0x0027F0D8
		// (set) Token: 0x0601B310 RID: 111376 RVA: 0x00280EF1 File Offset: 0x0027F0F1
		public unsafe bool bOverride_HorizonFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonFalloff) & FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonFalloff) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_HorizonFalloff) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonFalloff) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_HorizonFalloff : 0));
			}
		}

		// Token: 0x17006D12 RID: 27922
		// (get) Token: 0x0601B311 RID: 111377 RVA: 0x00280F21 File Offset: 0x0027F121
		// (set) Token: 0x0601B312 RID: 111378 RVA: 0x00280F3A File Offset: 0x0027F13A
		public unsafe bool bOverride_TopColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_TopColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_TopColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_TopColor : 0));
			}
		}

		// Token: 0x17006D13 RID: 27923
		// (get) Token: 0x0601B313 RID: 111379 RVA: 0x00280F6A File Offset: 0x0027F16A
		// (set) Token: 0x0601B314 RID: 111380 RVA: 0x00280F83 File Offset: 0x0027F183
		public unsafe bool bOverride_TopFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloff) & FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloff) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloff) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloff) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloff : 0));
			}
		}

		// Token: 0x17006D14 RID: 27924
		// (get) Token: 0x0601B315 RID: 111381 RVA: 0x00280FB3 File Offset: 0x0027F1B3
		// (set) Token: 0x0601B316 RID: 111382 RVA: 0x00280FCC File Offset: 0x0027F1CC
		public unsafe bool bOverride_TopColorMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColorMobile) & FKuroSkyboxSetting.__PropertyMask_bOverride_TopColorMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColorMobile) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopColorMobile) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_TopColorMobile) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_TopColorMobile : 0));
			}
		}

		// Token: 0x17006D15 RID: 27925
		// (get) Token: 0x0601B317 RID: 111383 RVA: 0x00280FFC File Offset: 0x0027F1FC
		// (set) Token: 0x0601B318 RID: 111384 RVA: 0x00281015 File Offset: 0x0027F215
		public unsafe bool bOverride_TopFalloffMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloffMobile) & FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloffMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloffMobile) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_TopFalloffMobile) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloffMobile) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_TopFalloffMobile : 0));
			}
		}

		// Token: 0x17006D16 RID: 27926
		// (get) Token: 0x0601B319 RID: 111385 RVA: 0x00281045 File Offset: 0x0027F245
		// (set) Token: 0x0601B31A RID: 111386 RVA: 0x0028105E File Offset: 0x0027F25E
		public unsafe bool bOverride_SunDiscColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunDiscColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunDiscColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunDiscColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunDiscColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunDiscColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunDiscColor : 0));
			}
		}

		// Token: 0x17006D17 RID: 27927
		// (get) Token: 0x0601B31B RID: 111387 RVA: 0x0028108E File Offset: 0x0027F28E
		// (set) Token: 0x0601B31C RID: 111388 RVA: 0x002810A7 File Offset: 0x0027F2A7
		public unsafe bool bOverride_SunScatterColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterColor : 0));
			}
		}

		// Token: 0x17006D18 RID: 27928
		// (get) Token: 0x0601B31D RID: 111389 RVA: 0x002810D7 File Offset: 0x0027F2D7
		// (set) Token: 0x0601B31E RID: 111390 RVA: 0x002810F0 File Offset: 0x0027F2F0
		public unsafe bool bOverride_SunSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunSize) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunSize) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunSize) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunSize) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunSize : 0));
			}
		}

		// Token: 0x17006D19 RID: 27929
		// (get) Token: 0x0601B31F RID: 111391 RVA: 0x00281120 File Offset: 0x0027F320
		// (set) Token: 0x0601B320 RID: 111392 RVA: 0x00281139 File Offset: 0x0027F339
		public unsafe bool bOverride_SunScatterSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterSize) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterSize) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunScatterSize) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterSize) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunScatterSize : 0));
			}
		}

		// Token: 0x17006D1A RID: 27930
		// (get) Token: 0x0601B321 RID: 111393 RVA: 0x00281169 File Offset: 0x0027F369
		// (set) Token: 0x0601B322 RID: 111394 RVA: 0x00281182 File Offset: 0x0027F382
		public unsafe bool bOverride_SunMeshScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshScale) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshScale) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshScale) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshScale) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshScale : 0));
			}
		}

		// Token: 0x17006D1B RID: 27931
		// (get) Token: 0x0601B323 RID: 111395 RVA: 0x002811B2 File Offset: 0x0027F3B2
		// (set) Token: 0x0601B324 RID: 111396 RVA: 0x002811CB File Offset: 0x0027F3CB
		public unsafe bool bOverride_SunMeshColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_SunMeshColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_SunMeshColor : 0));
			}
		}

		// Token: 0x17006D1C RID: 27932
		// (get) Token: 0x0601B325 RID: 111397 RVA: 0x002811FB File Offset: 0x0027F3FB
		// (set) Token: 0x0601B326 RID: 111398 RVA: 0x00281214 File Offset: 0x0027F414
		public unsafe bool bOverride_MoonTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonTexture) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonTexture) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonTexture) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonTexture) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonTexture : 0));
			}
		}

		// Token: 0x17006D1D RID: 27933
		// (get) Token: 0x0601B327 RID: 111399 RVA: 0x00281244 File Offset: 0x0027F444
		// (set) Token: 0x0601B328 RID: 111400 RVA: 0x0028125D File Offset: 0x0027F45D
		public unsafe bool bOverride_MoonPhase
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonPhase) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonPhase) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonPhase) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonPhase) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonPhase) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonPhase : 0));
			}
		}

		// Token: 0x17006D1E RID: 27934
		// (get) Token: 0x0601B329 RID: 111401 RVA: 0x0028128D File Offset: 0x0027F48D
		// (set) Token: 0x0601B32A RID: 111402 RVA: 0x002812A6 File Offset: 0x0027F4A6
		public unsafe bool bOverride_MoonDiscColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonDiscColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonDiscColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonDiscColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonDiscColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonDiscColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonDiscColor : 0));
			}
		}

		// Token: 0x17006D1F RID: 27935
		// (get) Token: 0x0601B32B RID: 111403 RVA: 0x002812D6 File Offset: 0x0027F4D6
		// (set) Token: 0x0601B32C RID: 111404 RVA: 0x002812EF File Offset: 0x0027F4EF
		public unsafe bool bOverride_MoonScatterColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterColor : 0));
			}
		}

		// Token: 0x17006D20 RID: 27936
		// (get) Token: 0x0601B32D RID: 111405 RVA: 0x0028131F File Offset: 0x0027F51F
		// (set) Token: 0x0601B32E RID: 111406 RVA: 0x00281338 File Offset: 0x0027F538
		public unsafe bool bOverride_MoonSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonSize) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonSize) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonSize) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonSize) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonSize : 0));
			}
		}

		// Token: 0x17006D21 RID: 27937
		// (get) Token: 0x0601B32F RID: 111407 RVA: 0x00281368 File Offset: 0x0027F568
		// (set) Token: 0x0601B330 RID: 111408 RVA: 0x00281381 File Offset: 0x0027F581
		public unsafe bool bOverride_MoonScatterSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterSize) & FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterSize) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_MoonScatterSize) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterSize) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_MoonScatterSize : 0));
			}
		}

		// Token: 0x17006D22 RID: 27938
		// (get) Token: 0x0601B331 RID: 111409 RVA: 0x002813B1 File Offset: 0x0027F5B1
		// (set) Token: 0x0601B332 RID: 111410 RVA: 0x002813CA File Offset: 0x0027F5CA
		public unsafe bool bOverride_ExtremeWeatherWeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) & FKuroSkyboxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight : 0));
			}
		}

		// Token: 0x17006D23 RID: 27939
		// (get) Token: 0x0601B333 RID: 111411 RVA: 0x002813FA File Offset: 0x0027F5FA
		// (set) Token: 0x0601B334 RID: 111412 RVA: 0x00281413 File Offset: 0x0027F613
		public unsafe bool bOverride_ST_TopColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopColor) & FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopColor) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopColor) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopColor : 0));
			}
		}

		// Token: 0x17006D24 RID: 27940
		// (get) Token: 0x0601B335 RID: 111413 RVA: 0x00281443 File Offset: 0x0027F643
		// (set) Token: 0x0601B336 RID: 111414 RVA: 0x0028145C File Offset: 0x0027F65C
		public unsafe bool bOverride_ST_DomeColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) & FKuroSkyboxSetting.__PropertyMask_bOverride_ST_DomeColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_ST_DomeColorTint) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_ST_DomeColorTint : 0));
			}
		}

		// Token: 0x17006D25 RID: 27941
		// (get) Token: 0x0601B337 RID: 111415 RVA: 0x0028148C File Offset: 0x0027F68C
		// (set) Token: 0x0601B338 RID: 111416 RVA: 0x002814A5 File Offset: 0x0027F6A5
		public unsafe bool bOverride_ST_TopWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopWidth) & FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopWidth) = ((*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_bOverride_ST_TopWidth) & ~FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopWidth) | (value ? FKuroSkyboxSetting.__PropertyMask_bOverride_ST_TopWidth : 0));
			}
		}

		// Token: 0x17006D26 RID: 27942
		// (get) Token: 0x0601B339 RID: 111417 RVA: 0x002814D5 File Offset: 0x0027F6D5
		// (set) Token: 0x0601B33A RID: 111418 RVA: 0x002814E9 File Offset: 0x0027F6E9
		public unsafe FLinearColor ZenithColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ZenithColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ZenithColor) = value;
			}
		}

		// Token: 0x17006D27 RID: 27943
		// (get) Token: 0x0601B33B RID: 111419 RVA: 0x002814FE File Offset: 0x0027F6FE
		// (set) Token: 0x0601B33C RID: 111420 RVA: 0x00281512 File Offset: 0x0027F712
		public unsafe FLinearColor NadirColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirColor) = value;
			}
		}

		// Token: 0x17006D28 RID: 27944
		// (get) Token: 0x0601B33D RID: 111421 RVA: 0x00281527 File Offset: 0x0027F727
		// (set) Token: 0x0601B33E RID: 111422 RVA: 0x00281537 File Offset: 0x0027F737
		public unsafe float NadirFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirFalloff) = value;
			}
		}

		// Token: 0x17006D29 RID: 27945
		// (get) Token: 0x0601B33F RID: 111423 RVA: 0x00281548 File Offset: 0x0027F748
		// (set) Token: 0x0601B340 RID: 111424 RVA: 0x00281558 File Offset: 0x0027F758
		public unsafe float NadirFalloff_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirFalloff_Mobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_NadirFalloff_Mobile) = value;
			}
		}

		// Token: 0x17006D2A RID: 27946
		// (get) Token: 0x0601B341 RID: 111425 RVA: 0x00281569 File Offset: 0x0027F769
		// (set) Token: 0x0601B342 RID: 111426 RVA: 0x0028157D File Offset: 0x0027F77D
		public unsafe FLinearColor HorizonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_HorizonColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_HorizonColor) = value;
			}
		}

		// Token: 0x17006D2B RID: 27947
		// (get) Token: 0x0601B343 RID: 111427 RVA: 0x00281592 File Offset: 0x0027F792
		// (set) Token: 0x0601B344 RID: 111428 RVA: 0x002815A2 File Offset: 0x0027F7A2
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_HorizonFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_HorizonFalloff) = value;
			}
		}

		// Token: 0x17006D2C RID: 27948
		// (get) Token: 0x0601B345 RID: 111429 RVA: 0x002815B3 File Offset: 0x0027F7B3
		// (set) Token: 0x0601B346 RID: 111430 RVA: 0x002815C7 File Offset: 0x0027F7C7
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopColor) = value;
			}
		}

		// Token: 0x17006D2D RID: 27949
		// (get) Token: 0x0601B347 RID: 111431 RVA: 0x002815DC File Offset: 0x0027F7DC
		// (set) Token: 0x0601B348 RID: 111432 RVA: 0x002815EC File Offset: 0x0027F7EC
		public unsafe float TopFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopFalloff) = value;
			}
		}

		// Token: 0x17006D2E RID: 27950
		// (get) Token: 0x0601B349 RID: 111433 RVA: 0x002815FD File Offset: 0x0027F7FD
		// (set) Token: 0x0601B34A RID: 111434 RVA: 0x00281611 File Offset: 0x0027F811
		public unsafe FLinearColor TopColorMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopColorMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopColorMobile) = value;
			}
		}

		// Token: 0x17006D2F RID: 27951
		// (get) Token: 0x0601B34B RID: 111435 RVA: 0x00281626 File Offset: 0x0027F826
		// (set) Token: 0x0601B34C RID: 111436 RVA: 0x00281636 File Offset: 0x0027F836
		public unsafe float TopFalloffMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopFalloffMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_TopFalloffMobile) = value;
			}
		}

		// Token: 0x17006D30 RID: 27952
		// (get) Token: 0x0601B34D RID: 111437 RVA: 0x00281647 File Offset: 0x0027F847
		// (set) Token: 0x0601B34E RID: 111438 RVA: 0x0028165B File Offset: 0x0027F85B
		public unsafe FLinearColor SunDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunDiscColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunDiscColor) = value;
			}
		}

		// Token: 0x17006D31 RID: 27953
		// (get) Token: 0x0601B34F RID: 111439 RVA: 0x00281670 File Offset: 0x0027F870
		// (set) Token: 0x0601B350 RID: 111440 RVA: 0x00281684 File Offset: 0x0027F884
		public unsafe FLinearColor SunScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunScatterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunScatterColor) = value;
			}
		}

		// Token: 0x17006D32 RID: 27954
		// (get) Token: 0x0601B351 RID: 111441 RVA: 0x00281699 File Offset: 0x0027F899
		// (set) Token: 0x0601B352 RID: 111442 RVA: 0x002816A9 File Offset: 0x0027F8A9
		public unsafe float SunSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunSize) = value;
			}
		}

		// Token: 0x17006D33 RID: 27955
		// (get) Token: 0x0601B353 RID: 111443 RVA: 0x002816BA File Offset: 0x0027F8BA
		// (set) Token: 0x0601B354 RID: 111444 RVA: 0x002816CA File Offset: 0x0027F8CA
		public unsafe float SunScatterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunScatterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunScatterSize) = value;
			}
		}

		// Token: 0x17006D34 RID: 27956
		// (get) Token: 0x0601B355 RID: 111445 RVA: 0x002816DB File Offset: 0x0027F8DB
		// (set) Token: 0x0601B356 RID: 111446 RVA: 0x002816EB File Offset: 0x0027F8EB
		public unsafe float SunMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunMeshScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunMeshScale) = value;
			}
		}

		// Token: 0x17006D35 RID: 27957
		// (get) Token: 0x0601B357 RID: 111447 RVA: 0x002816FC File Offset: 0x0027F8FC
		// (set) Token: 0x0601B358 RID: 111448 RVA: 0x00281710 File Offset: 0x0027F910
		public unsafe FLinearColor SunMeshColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunMeshColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_SunMeshColor) = value;
			}
		}

		// Token: 0x17006D36 RID: 27958
		// (get) Token: 0x0601B359 RID: 111449 RVA: 0x00281725 File Offset: 0x0027F925
		// (set) Token: 0x0601B35A RID: 111450 RVA: 0x00281739 File Offset: 0x0027F939
		public unsafe FLinearColor MoonDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonDiscColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonDiscColor) = value;
			}
		}

		// Token: 0x17006D37 RID: 27959
		// (get) Token: 0x0601B35B RID: 111451 RVA: 0x0028174E File Offset: 0x0027F94E
		// (set) Token: 0x0601B35C RID: 111452 RVA: 0x00281762 File Offset: 0x0027F962
		[Nullable(2)]
		public unsafe UTexture2D MoonTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyboxSetting.__PropertyOffset_MoonTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyboxSetting.__PropertyOffset_MoonTexture, value);
			}
		}

		// Token: 0x17006D38 RID: 27960
		// (get) Token: 0x0601B35D RID: 111453 RVA: 0x00281777 File Offset: 0x0027F977
		// (set) Token: 0x0601B35E RID: 111454 RVA: 0x00281787 File Offset: 0x0027F987
		public unsafe float MoonPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonPhase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonPhase) = value;
			}
		}

		// Token: 0x17006D39 RID: 27961
		// (get) Token: 0x0601B35F RID: 111455 RVA: 0x00281798 File Offset: 0x0027F998
		// (set) Token: 0x0601B360 RID: 111456 RVA: 0x002817AC File Offset: 0x0027F9AC
		public unsafe FLinearColor MoonScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonScatterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonScatterColor) = value;
			}
		}

		// Token: 0x17006D3A RID: 27962
		// (get) Token: 0x0601B361 RID: 111457 RVA: 0x002817C1 File Offset: 0x0027F9C1
		// (set) Token: 0x0601B362 RID: 111458 RVA: 0x002817D1 File Offset: 0x0027F9D1
		public unsafe float MoonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonSize) = value;
			}
		}

		// Token: 0x17006D3B RID: 27963
		// (get) Token: 0x0601B363 RID: 111459 RVA: 0x002817E2 File Offset: 0x0027F9E2
		// (set) Token: 0x0601B364 RID: 111460 RVA: 0x002817F2 File Offset: 0x0027F9F2
		public unsafe float MoonScatterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonScatterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_MoonScatterSize) = value;
			}
		}

		// Token: 0x17006D3C RID: 27964
		// (get) Token: 0x0601B365 RID: 111461 RVA: 0x00281803 File Offset: 0x0027FA03
		// (set) Token: 0x0601B366 RID: 111462 RVA: 0x00281813 File Offset: 0x0027FA13
		public unsafe float ExtremeWeatherWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ExtremeWeatherWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ExtremeWeatherWeight) = value;
			}
		}

		// Token: 0x17006D3D RID: 27965
		// (get) Token: 0x0601B367 RID: 111463 RVA: 0x00281824 File Offset: 0x0027FA24
		// (set) Token: 0x0601B368 RID: 111464 RVA: 0x00281838 File Offset: 0x0027FA38
		public unsafe FLinearColor ST_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_TopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_TopColor) = value;
			}
		}

		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x0601B369 RID: 111465 RVA: 0x0028184D File Offset: 0x0027FA4D
		// (set) Token: 0x0601B36A RID: 111466 RVA: 0x00281861 File Offset: 0x0027FA61
		public unsafe FLinearColor ST_DomeColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_DomeColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_DomeColorTint) = value;
			}
		}

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x0601B36B RID: 111467 RVA: 0x00281876 File Offset: 0x0027FA76
		// (set) Token: 0x0601B36C RID: 111468 RVA: 0x00281886 File Offset: 0x0027FA86
		public unsafe float ST_TopWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_TopWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyboxSetting.__PropertyOffset_ST_TopWidth) = value;
			}
		}

		// Token: 0x0601B36D RID: 111469 RVA: 0x00281897 File Offset: 0x0027FA97
		public FKuroSkyboxSetting()
		{
		}

		// Token: 0x0601B36E RID: 111470 RVA: 0x002818A0 File Offset: 0x0027FAA0
		[NullableContext(1)]
		public FKuroSkyboxSetting(bool bOverride_ZenithColor, bool bOverride_NadirColor, bool bOverride_NadirFalloff, bool bOverride_NadirFalloff_Mobile, bool bOverride_HorizonColor, bool bOverride_HorizonFalloff, bool bOverride_TopColor, bool bOverride_TopFalloff, bool bOverride_TopColorMobile, bool bOverride_TopFalloffMobile, bool bOverride_SunDiscColor, bool bOverride_SunScatterColor, bool bOverride_SunSize, bool bOverride_SunScatterSize, bool bOverride_SunMeshScale, bool bOverride_SunMeshColor, bool bOverride_MoonTexture, bool bOverride_MoonPhase, bool bOverride_MoonDiscColor, bool bOverride_MoonScatterColor, bool bOverride_MoonSize, bool bOverride_MoonScatterSize, bool bOverride_ExtremeWeatherWeight, bool bOverride_ST_TopColor, bool bOverride_ST_DomeColorTint, bool bOverride_ST_TopWidth, FLinearColor ZenithColor, FLinearColor NadirColor, float NadirFalloff, float NadirFalloff_Mobile, FLinearColor HorizonColor, float HorizonFalloff, FLinearColor TopColor, float TopFalloff, FLinearColor TopColorMobile, float TopFalloffMobile, FLinearColor SunDiscColor, FLinearColor SunScatterColor, float SunSize, float SunScatterSize, float SunMeshScale, FLinearColor SunMeshColor, FLinearColor MoonDiscColor, UTexture2D MoonTexture, float MoonPhase, FLinearColor MoonScatterColor, float MoonSize, float MoonScatterSize, float ExtremeWeatherWeight, FLinearColor ST_TopColor, FLinearColor ST_DomeColorTint, float ST_TopWidth)
		{
			this.bOverride_ZenithColor = bOverride_ZenithColor;
			this.bOverride_NadirColor = bOverride_NadirColor;
			this.bOverride_NadirFalloff = bOverride_NadirFalloff;
			this.bOverride_NadirFalloff_Mobile = bOverride_NadirFalloff_Mobile;
			this.bOverride_HorizonColor = bOverride_HorizonColor;
			this.bOverride_HorizonFalloff = bOverride_HorizonFalloff;
			this.bOverride_TopColor = bOverride_TopColor;
			this.bOverride_TopFalloff = bOverride_TopFalloff;
			this.bOverride_TopColorMobile = bOverride_TopColorMobile;
			this.bOverride_TopFalloffMobile = bOverride_TopFalloffMobile;
			this.bOverride_SunDiscColor = bOverride_SunDiscColor;
			this.bOverride_SunScatterColor = bOverride_SunScatterColor;
			this.bOverride_SunSize = bOverride_SunSize;
			this.bOverride_SunScatterSize = bOverride_SunScatterSize;
			this.bOverride_SunMeshScale = bOverride_SunMeshScale;
			this.bOverride_SunMeshColor = bOverride_SunMeshColor;
			this.bOverride_MoonTexture = bOverride_MoonTexture;
			this.bOverride_MoonPhase = bOverride_MoonPhase;
			this.bOverride_MoonDiscColor = bOverride_MoonDiscColor;
			this.bOverride_MoonScatterColor = bOverride_MoonScatterColor;
			this.bOverride_MoonSize = bOverride_MoonSize;
			this.bOverride_MoonScatterSize = bOverride_MoonScatterSize;
			this.bOverride_ExtremeWeatherWeight = bOverride_ExtremeWeatherWeight;
			this.bOverride_ST_TopColor = bOverride_ST_TopColor;
			this.bOverride_ST_DomeColorTint = bOverride_ST_DomeColorTint;
			this.bOverride_ST_TopWidth = bOverride_ST_TopWidth;
			this.ZenithColor = ZenithColor;
			this.NadirColor = NadirColor;
			this.NadirFalloff = NadirFalloff;
			this.NadirFalloff_Mobile = NadirFalloff_Mobile;
			this.HorizonColor = HorizonColor;
			this.HorizonFalloff = HorizonFalloff;
			this.TopColor = TopColor;
			this.TopFalloff = TopFalloff;
			this.TopColorMobile = TopColorMobile;
			this.TopFalloffMobile = TopFalloffMobile;
			this.SunDiscColor = SunDiscColor;
			this.SunScatterColor = SunScatterColor;
			this.SunSize = SunSize;
			this.SunScatterSize = SunScatterSize;
			this.SunMeshScale = SunMeshScale;
			this.SunMeshColor = SunMeshColor;
			this.MoonDiscColor = MoonDiscColor;
			this.MoonTexture = MoonTexture;
			this.MoonPhase = MoonPhase;
			this.MoonScatterColor = MoonScatterColor;
			this.MoonSize = MoonSize;
			this.MoonScatterSize = MoonScatterSize;
			this.ExtremeWeatherWeight = ExtremeWeatherWeight;
			this.ST_TopColor = ST_TopColor;
			this.ST_DomeColorTint = ST_DomeColorTint;
			this.ST_TopWidth = ST_TopWidth;
		}

		// Token: 0x0601B36F RID: 111471 RVA: 0x00281A50 File Offset: 0x0027FC50
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkyboxSetting.StaticStruct();
		}

		// Token: 0x0601B370 RID: 111472 RVA: 0x00281A5C File Offset: 0x0027FC5C
		[NullableContext(2)]
		public FKuroSkyboxSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B371 RID: 111473 RVA: 0x00281A66 File Offset: 0x0027FC66
		public FKuroSkyboxSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B372 RID: 111474 RVA: 0x00281A71 File Offset: 0x0027FC71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkyboxSetting(Pointer, false, true);
		}

		// Token: 0x0601B373 RID: 111475 RVA: 0x00281A7B File Offset: 0x0027FC7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkyboxSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EA31 RID: 59953
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSkyboxSetting";

		// Token: 0x0400EA32 RID: 59954
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EA33 RID: 59955
		internal static int __PropertyOffset_bOverride_ZenithColor;

		// Token: 0x0400EA34 RID: 59956
		internal static byte __PropertyMask_bOverride_ZenithColor;

		// Token: 0x0400EA35 RID: 59957
		internal static int __PropertyOffset_bOverride_NadirColor;

		// Token: 0x0400EA36 RID: 59958
		internal static byte __PropertyMask_bOverride_NadirColor;

		// Token: 0x0400EA37 RID: 59959
		internal static int __PropertyOffset_bOverride_NadirFalloff;

		// Token: 0x0400EA38 RID: 59960
		internal static byte __PropertyMask_bOverride_NadirFalloff;

		// Token: 0x0400EA39 RID: 59961
		internal static int __PropertyOffset_bOverride_NadirFalloff_Mobile;

		// Token: 0x0400EA3A RID: 59962
		internal static byte __PropertyMask_bOverride_NadirFalloff_Mobile;

		// Token: 0x0400EA3B RID: 59963
		internal static int __PropertyOffset_bOverride_HorizonColor;

		// Token: 0x0400EA3C RID: 59964
		internal static byte __PropertyMask_bOverride_HorizonColor;

		// Token: 0x0400EA3D RID: 59965
		internal static int __PropertyOffset_bOverride_HorizonFalloff;

		// Token: 0x0400EA3E RID: 59966
		internal static byte __PropertyMask_bOverride_HorizonFalloff;

		// Token: 0x0400EA3F RID: 59967
		internal static int __PropertyOffset_bOverride_TopColor;

		// Token: 0x0400EA40 RID: 59968
		internal static byte __PropertyMask_bOverride_TopColor;

		// Token: 0x0400EA41 RID: 59969
		internal static int __PropertyOffset_bOverride_TopFalloff;

		// Token: 0x0400EA42 RID: 59970
		internal static byte __PropertyMask_bOverride_TopFalloff;

		// Token: 0x0400EA43 RID: 59971
		internal static int __PropertyOffset_bOverride_TopColorMobile;

		// Token: 0x0400EA44 RID: 59972
		internal static byte __PropertyMask_bOverride_TopColorMobile;

		// Token: 0x0400EA45 RID: 59973
		internal static int __PropertyOffset_bOverride_TopFalloffMobile;

		// Token: 0x0400EA46 RID: 59974
		internal static byte __PropertyMask_bOverride_TopFalloffMobile;

		// Token: 0x0400EA47 RID: 59975
		internal static int __PropertyOffset_bOverride_SunDiscColor;

		// Token: 0x0400EA48 RID: 59976
		internal static byte __PropertyMask_bOverride_SunDiscColor;

		// Token: 0x0400EA49 RID: 59977
		internal static int __PropertyOffset_bOverride_SunScatterColor;

		// Token: 0x0400EA4A RID: 59978
		internal static byte __PropertyMask_bOverride_SunScatterColor;

		// Token: 0x0400EA4B RID: 59979
		internal static int __PropertyOffset_bOverride_SunSize;

		// Token: 0x0400EA4C RID: 59980
		internal static byte __PropertyMask_bOverride_SunSize;

		// Token: 0x0400EA4D RID: 59981
		internal static int __PropertyOffset_bOverride_SunScatterSize;

		// Token: 0x0400EA4E RID: 59982
		internal static byte __PropertyMask_bOverride_SunScatterSize;

		// Token: 0x0400EA4F RID: 59983
		internal static int __PropertyOffset_bOverride_SunMeshScale;

		// Token: 0x0400EA50 RID: 59984
		internal static byte __PropertyMask_bOverride_SunMeshScale;

		// Token: 0x0400EA51 RID: 59985
		internal static int __PropertyOffset_bOverride_SunMeshColor;

		// Token: 0x0400EA52 RID: 59986
		internal static byte __PropertyMask_bOverride_SunMeshColor;

		// Token: 0x0400EA53 RID: 59987
		internal static int __PropertyOffset_bOverride_MoonTexture;

		// Token: 0x0400EA54 RID: 59988
		internal static byte __PropertyMask_bOverride_MoonTexture;

		// Token: 0x0400EA55 RID: 59989
		internal static int __PropertyOffset_bOverride_MoonPhase;

		// Token: 0x0400EA56 RID: 59990
		internal static byte __PropertyMask_bOverride_MoonPhase;

		// Token: 0x0400EA57 RID: 59991
		internal static int __PropertyOffset_bOverride_MoonDiscColor;

		// Token: 0x0400EA58 RID: 59992
		internal static byte __PropertyMask_bOverride_MoonDiscColor;

		// Token: 0x0400EA59 RID: 59993
		internal static int __PropertyOffset_bOverride_MoonScatterColor;

		// Token: 0x0400EA5A RID: 59994
		internal static byte __PropertyMask_bOverride_MoonScatterColor;

		// Token: 0x0400EA5B RID: 59995
		internal static int __PropertyOffset_bOverride_MoonSize;

		// Token: 0x0400EA5C RID: 59996
		internal static byte __PropertyMask_bOverride_MoonSize;

		// Token: 0x0400EA5D RID: 59997
		internal static int __PropertyOffset_bOverride_MoonScatterSize;

		// Token: 0x0400EA5E RID: 59998
		internal static byte __PropertyMask_bOverride_MoonScatterSize;

		// Token: 0x0400EA5F RID: 59999
		internal static int __PropertyOffset_bOverride_ExtremeWeatherWeight;

		// Token: 0x0400EA60 RID: 60000
		internal static byte __PropertyMask_bOverride_ExtremeWeatherWeight;

		// Token: 0x0400EA61 RID: 60001
		internal static int __PropertyOffset_bOverride_ST_TopColor;

		// Token: 0x0400EA62 RID: 60002
		internal static byte __PropertyMask_bOverride_ST_TopColor;

		// Token: 0x0400EA63 RID: 60003
		internal static int __PropertyOffset_bOverride_ST_DomeColorTint;

		// Token: 0x0400EA64 RID: 60004
		internal static byte __PropertyMask_bOverride_ST_DomeColorTint;

		// Token: 0x0400EA65 RID: 60005
		internal static int __PropertyOffset_bOverride_ST_TopWidth;

		// Token: 0x0400EA66 RID: 60006
		internal static byte __PropertyMask_bOverride_ST_TopWidth;

		// Token: 0x0400EA67 RID: 60007
		internal static int __PropertyOffset_ZenithColor;

		// Token: 0x0400EA68 RID: 60008
		internal static int __PropertyOffset_NadirColor;

		// Token: 0x0400EA69 RID: 60009
		internal static int __PropertyOffset_NadirFalloff;

		// Token: 0x0400EA6A RID: 60010
		internal static int __PropertyOffset_NadirFalloff_Mobile;

		// Token: 0x0400EA6B RID: 60011
		internal static int __PropertyOffset_HorizonColor;

		// Token: 0x0400EA6C RID: 60012
		internal static int __PropertyOffset_HorizonFalloff;

		// Token: 0x0400EA6D RID: 60013
		internal static int __PropertyOffset_TopColor;

		// Token: 0x0400EA6E RID: 60014
		internal static int __PropertyOffset_TopFalloff;

		// Token: 0x0400EA6F RID: 60015
		internal static int __PropertyOffset_TopColorMobile;

		// Token: 0x0400EA70 RID: 60016
		internal static int __PropertyOffset_TopFalloffMobile;

		// Token: 0x0400EA71 RID: 60017
		internal static int __PropertyOffset_SunDiscColor;

		// Token: 0x0400EA72 RID: 60018
		internal static int __PropertyOffset_SunScatterColor;

		// Token: 0x0400EA73 RID: 60019
		internal static int __PropertyOffset_SunSize;

		// Token: 0x0400EA74 RID: 60020
		internal static int __PropertyOffset_SunScatterSize;

		// Token: 0x0400EA75 RID: 60021
		internal static int __PropertyOffset_SunMeshScale;

		// Token: 0x0400EA76 RID: 60022
		internal static int __PropertyOffset_SunMeshColor;

		// Token: 0x0400EA77 RID: 60023
		internal static int __PropertyOffset_MoonDiscColor;

		// Token: 0x0400EA78 RID: 60024
		internal static int __PropertyOffset_MoonTexture;

		// Token: 0x0400EA79 RID: 60025
		internal static int __PropertyOffset_MoonPhase;

		// Token: 0x0400EA7A RID: 60026
		internal static int __PropertyOffset_MoonScatterColor;

		// Token: 0x0400EA7B RID: 60027
		internal static int __PropertyOffset_MoonSize;

		// Token: 0x0400EA7C RID: 60028
		internal static int __PropertyOffset_MoonScatterSize;

		// Token: 0x0400EA7D RID: 60029
		internal static int __PropertyOffset_ExtremeWeatherWeight;

		// Token: 0x0400EA7E RID: 60030
		internal static int __PropertyOffset_ST_TopColor;

		// Token: 0x0400EA7F RID: 60031
		internal static int __PropertyOffset_ST_DomeColorTint;

		// Token: 0x0400EA80 RID: 60032
		internal static int __PropertyOffset_ST_TopWidth;
	}
}
