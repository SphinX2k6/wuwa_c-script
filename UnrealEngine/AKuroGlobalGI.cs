using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0F RID: 6927
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI")]
	[UnrealStructLayout(16016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16016)]
	public class AKuroGlobalGI : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019F7C RID: 106364 RVA: 0x00265B86 File Offset: 0x00263D86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGlobalGI._ClassPtr;
		}

		// Token: 0x06019F7D RID: 106365 RVA: 0x00265B94 File Offset: 0x00263D94
		public AKuroGlobalGI() : this(BuiltinUtils.AllocNativeUObject(AKuroGlobalGI.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019F7E RID: 106366 RVA: 0x00265BBC File Offset: 0x00263DBC
		[NullableContext(1)]
		public AKuroGlobalGI(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGlobalGI.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x06019F7F RID: 106367 RVA: 0x00265BEF File Offset: 0x00263DEF
		// (set) Token: 0x06019F80 RID: 106368 RVA: 0x00265BFF File Offset: 0x00263DFF
		public unsafe bool TickInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TickInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TickInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700681F RID: 26655
		// (get) Token: 0x06019F81 RID: 106369 RVA: 0x00265C10 File Offset: 0x00263E10
		// (set) Token: 0x06019F82 RID: 106370 RVA: 0x00265C20 File Offset: 0x00263E20
		public unsafe bool IsPersistentLevelGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsPersistentLevelGI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsPersistentLevelGI) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x06019F83 RID: 106371 RVA: 0x00265C31 File Offset: 0x00263E31
		// (set) Token: 0x06019F84 RID: 106372 RVA: 0x00265C41 File Offset: 0x00263E41
		public unsafe bool bPostProcessVolumeChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPostProcessVolumeChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPostProcessVolumeChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x06019F85 RID: 106373 RVA: 0x00265C52 File Offset: 0x00263E52
		// (set) Token: 0x06019F86 RID: 106374 RVA: 0x00265C62 File Offset: 0x00263E62
		public unsafe float TickDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TickDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TickDeltaTime) = value;
			}
		}

		// Token: 0x17006822 RID: 26658
		// (get) Token: 0x06019F87 RID: 106375 RVA: 0x00265C73 File Offset: 0x00263E73
		// (set) Token: 0x06019F88 RID: 106376 RVA: 0x00265C87 File Offset: 0x00263E87
		public unsafe FVector ViewLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ViewLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ViewLocation) = value;
			}
		}

		// Token: 0x17006823 RID: 26659
		// (get) Token: 0x06019F89 RID: 106377 RVA: 0x00265C9C File Offset: 0x00263E9C
		// (set) Token: 0x06019F8A RID: 106378 RVA: 0x00265CAC File Offset: 0x00263EAC
		public unsafe bool DisableGlobalGITransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableGlobalGITransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableGlobalGITransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x06019F8B RID: 106379 RVA: 0x00265CBD File Offset: 0x00263EBD
		// (set) Token: 0x06019F8C RID: 106380 RVA: 0x00265CCD File Offset: 0x00263ECD
		public unsafe bool DisableSkyBlendingSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableSkyBlendingSkip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableSkyBlendingSkip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x06019F8D RID: 106381 RVA: 0x00265CDE File Offset: 0x00263EDE
		// (set) Token: 0x06019F8E RID: 106382 RVA: 0x00265CEE File Offset: 0x00263EEE
		public unsafe bool DisableFixedTimeState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableFixedTimeState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DisableFixedTimeState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x06019F8F RID: 106383 RVA: 0x00265CFF File Offset: 0x00263EFF
		// (set) Token: 0x06019F90 RID: 106384 RVA: 0x00265D0F File Offset: 0x00263F0F
		public unsafe float SunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SunHorizonAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SunHorizonAngle) = value;
			}
		}

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x06019F91 RID: 106385 RVA: 0x00265D20 File Offset: 0x00263F20
		// (set) Token: 0x06019F92 RID: 106386 RVA: 0x00265D30 File Offset: 0x00263F30
		public unsafe float SunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SunVerticalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SunVerticalAngle) = value;
			}
		}

		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x06019F93 RID: 106387 RVA: 0x00265D41 File Offset: 0x00263F41
		// (set) Token: 0x06019F94 RID: 106388 RVA: 0x00265D51 File Offset: 0x00263F51
		public unsafe bool IsReversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsReversed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsReversed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x06019F95 RID: 106389 RVA: 0x00265D62 File Offset: 0x00263F62
		// (set) Token: 0x06019F96 RID: 106390 RVA: 0x00265D72 File Offset: 0x00263F72
		public unsafe float ReverseZCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ReverseZCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ReverseZCenter) = value;
			}
		}

		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x06019F97 RID: 106391 RVA: 0x00265D83 File Offset: 0x00263F83
		// (set) Token: 0x06019F98 RID: 106392 RVA: 0x00265D93 File Offset: 0x00263F93
		public unsafe bool bLockSceneLightVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bLockSceneLightVerticalAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bLockSceneLightVerticalAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x06019F99 RID: 106393 RVA: 0x00265DA4 File Offset: 0x00263FA4
		// (set) Token: 0x06019F9A RID: 106394 RVA: 0x00265DB8 File Offset: 0x00263FB8
		public unsafe FVector2D SceneLightVerticalAngleRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SceneLightVerticalAngleRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_SceneLightVerticalAngleRange) = value;
			}
		}

		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x06019F9B RID: 106395 RVA: 0x00265DD0 File Offset: 0x00263FD0
		// (set) Token: 0x06019F9C RID: 106396 RVA: 0x00265E09 File Offset: 0x00264009
		[Nullable(1)]
		public FKuroGISetting LerpGISetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroGISetting result;
				if ((result = this._LerpGISetting) == null)
				{
					result = (this._LerpGISetting = new FKuroGISetting(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpGISetting, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGISetting.StaticStruct(), base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpGISetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x06019F9D RID: 106397 RVA: 0x00265E2C File Offset: 0x0026402C
		// (set) Token: 0x06019F9E RID: 106398 RVA: 0x00265E65 File Offset: 0x00264065
		[Nullable(1)]
		public FKuroGISetting TempGISetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroGISetting result;
				if ((result = this._TempGISetting) == null)
				{
					result = (this._TempGISetting = new FKuroGISetting(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TempGISetting, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGISetting.StaticStruct(), base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TempGISetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x06019F9F RID: 106399 RVA: 0x00265E88 File Offset: 0x00264088
		// (set) Token: 0x06019FA0 RID: 106400 RVA: 0x00265EC1 File Offset: 0x002640C1
		[Nullable(1)]
		public FPostProcessSettings LerpPostProcessSetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._LerpPostProcessSetting) == null)
				{
					result = (this._LerpPostProcessSetting = new FPostProcessSettings(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpPostProcessSetting, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpPostProcessSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x06019FA1 RID: 106401 RVA: 0x00265EE2 File Offset: 0x002640E2
		// (set) Token: 0x06019FA2 RID: 106402 RVA: 0x00265EF2 File Offset: 0x002640F2
		public unsafe bool bContrlTODTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bContrlTODTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bContrlTODTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x06019FA3 RID: 106403 RVA: 0x00265F03 File Offset: 0x00264103
		// (set) Token: 0x06019FA4 RID: 106404 RVA: 0x00265F13 File Offset: 0x00264113
		public unsafe bool bSeqControlClouds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bSeqControlClouds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bSeqControlClouds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x06019FA5 RID: 106405 RVA: 0x00265F24 File Offset: 0x00264124
		// (set) Token: 0x06019FA6 RID: 106406 RVA: 0x00265F34 File Offset: 0x00264134
		public unsafe float CurTimeAfterLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CurTimeAfterLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CurTimeAfterLerp) = value;
			}
		}

		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x06019FA7 RID: 106407 RVA: 0x00265F45 File Offset: 0x00264145
		// (set) Token: 0x06019FA8 RID: 106408 RVA: 0x00265F55 File Offset: 0x00264155
		public unsafe float LerpSunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpSunHorizonAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpSunHorizonAngle) = value;
			}
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x06019FA9 RID: 106409 RVA: 0x00265F66 File Offset: 0x00264166
		// (set) Token: 0x06019FAA RID: 106410 RVA: 0x00265F76 File Offset: 0x00264176
		public unsafe float LerpSunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpSunVerticalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_LerpSunVerticalAngle) = value;
			}
		}

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x06019FAB RID: 106411 RVA: 0x00265F87 File Offset: 0x00264187
		// (set) Token: 0x06019FAC RID: 106412 RVA: 0x00265F97 File Offset: 0x00264197
		public unsafe float GlobalWindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindSpeed) = value;
			}
		}

		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x06019FAD RID: 106413 RVA: 0x00265FA8 File Offset: 0x002641A8
		// (set) Token: 0x06019FAE RID: 106414 RVA: 0x00265FB8 File Offset: 0x002641B8
		public unsafe float GlobalWindSpeedWithoutTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindSpeedWithoutTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindSpeedWithoutTimeDilation) = value;
			}
		}

		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x06019FAF RID: 106415 RVA: 0x00265FC9 File Offset: 0x002641C9
		// (set) Token: 0x06019FB0 RID: 106416 RVA: 0x00265FD9 File Offset: 0x002641D9
		public unsafe float GlobalWindPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindPower) = value;
			}
		}

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x06019FB1 RID: 106417 RVA: 0x00265FEA File Offset: 0x002641EA
		// (set) Token: 0x06019FB2 RID: 106418 RVA: 0x00265FFA File Offset: 0x002641FA
		public unsafe float GlobalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalTimeDilation) = value;
			}
		}

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x06019FB3 RID: 106419 RVA: 0x0026600B File Offset: 0x0026420B
		// (set) Token: 0x06019FB4 RID: 106420 RVA: 0x0026601F File Offset: 0x0026421F
		public unsafe FVector GlobalWindForwardDrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindForwardDrection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalWindForwardDrection) = value;
			}
		}

		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x06019FB5 RID: 106421 RVA: 0x00266034 File Offset: 0x00264234
		// (set) Token: 0x06019FB6 RID: 106422 RVA: 0x00266048 File Offset: 0x00264248
		public unsafe FVector WindTextureOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_WindTextureOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_WindTextureOffset) = value;
			}
		}

		// Token: 0x1700683A RID: 26682
		// (get) Token: 0x06019FB7 RID: 106423 RVA: 0x0026605D File Offset: 0x0026425D
		// (set) Token: 0x06019FB8 RID: 106424 RVA: 0x0026606D File Offset: 0x0026426D
		public unsafe bool bIsDayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bIsDayTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bIsDayTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x06019FB9 RID: 106425 RVA: 0x0026607E File Offset: 0x0026427E
		// (set) Token: 0x06019FBA RID: 106426 RVA: 0x0026608E File Offset: 0x0026428E
		public unsafe bool bDayNightEmssiveFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bDayNightEmssiveFactor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bDayNightEmssiveFactor) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x06019FBB RID: 106427 RVA: 0x0026609F File Offset: 0x0026429F
		// (set) Token: 0x06019FBC RID: 106428 RVA: 0x002660AF File Offset: 0x002642AF
		public unsafe float DayNightEmssiveSmoothFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DayNightEmssiveSmoothFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_DayNightEmssiveSmoothFactor) = value;
			}
		}

		// Token: 0x1700683D RID: 26685
		// (get) Token: 0x06019FBD RID: 106429 RVA: 0x002660C0 File Offset: 0x002642C0
		// (set) Token: 0x06019FBE RID: 106430 RVA: 0x002660D0 File Offset: 0x002642D0
		public unsafe float TODNightLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODNightLightLoadingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODNightLightLoadingTime) = value;
			}
		}

		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x06019FBF RID: 106431 RVA: 0x002660E1 File Offset: 0x002642E1
		// (set) Token: 0x06019FC0 RID: 106432 RVA: 0x002660F1 File Offset: 0x002642F1
		public unsafe float TODDayLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODDayLightLoadingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODDayLightLoadingTime) = value;
			}
		}

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x06019FC1 RID: 106433 RVA: 0x00266102 File Offset: 0x00264302
		// (set) Token: 0x06019FC2 RID: 106434 RVA: 0x00266112 File Offset: 0x00264312
		public unsafe float TODEmssiveCloseLerpFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODEmssiveCloseLerpFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_TODEmssiveCloseLerpFade) = value;
			}
		}

		// Token: 0x17006840 RID: 26688
		// (get) Token: 0x06019FC3 RID: 106435 RVA: 0x00266123 File Offset: 0x00264323
		// (set) Token: 0x06019FC4 RID: 106436 RVA: 0x00266133 File Offset: 0x00264333
		public unsafe float NowGlobalLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_NowGlobalLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_NowGlobalLightIntensity) = value;
			}
		}

		// Token: 0x17006841 RID: 26689
		// (get) Token: 0x06019FC5 RID: 106437 RVA: 0x00266144 File Offset: 0x00264344
		// (set) Token: 0x06019FC6 RID: 106438 RVA: 0x00266154 File Offset: 0x00264354
		public unsafe bool bRainAffectPointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bRainAffectPointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bRainAffectPointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x06019FC7 RID: 106439 RVA: 0x00266165 File Offset: 0x00264365
		// (set) Token: 0x06019FC8 RID: 106440 RVA: 0x00266175 File Offset: 0x00264375
		public unsafe float CharLightHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharLightHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharLightHorizontal) = value;
			}
		}

		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x06019FC9 RID: 106441 RVA: 0x00266186 File Offset: 0x00264386
		// (set) Token: 0x06019FCA RID: 106442 RVA: 0x0026619A File Offset: 0x0026439A
		public unsafe FVector CharDebugLightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharDebugLightDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharDebugLightDirection) = value;
			}
		}

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x06019FCB RID: 106443 RVA: 0x002661AF File Offset: 0x002643AF
		// (set) Token: 0x06019FCC RID: 106444 RVA: 0x002661C3 File Offset: 0x002643C3
		public unsafe FVector CharDebugLightDirectionZero
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharDebugLightDirectionZero);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CharDebugLightDirectionZero) = value;
			}
		}

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x06019FCD RID: 106445 RVA: 0x002661D8 File Offset: 0x002643D8
		// (set) Token: 0x06019FCE RID: 106446 RVA: 0x002661EC File Offset: 0x002643EC
		public unsafe FRotator AtmosphereSunRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereSunRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereSunRotation) = value;
			}
		}

		// Token: 0x17006846 RID: 26694
		// (get) Token: 0x06019FCF RID: 106447 RVA: 0x00266201 File Offset: 0x00264401
		// (set) Token: 0x06019FD0 RID: 106448 RVA: 0x00266215 File Offset: 0x00264415
		public unsafe FVector AtmosphereSunForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereSunForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereSunForward) = value;
			}
		}

		// Token: 0x17006847 RID: 26695
		// (get) Token: 0x06019FD1 RID: 106449 RVA: 0x0026622A File Offset: 0x0026442A
		// (set) Token: 0x06019FD2 RID: 106450 RVA: 0x0026623E File Offset: 0x0026443E
		public unsafe FRotator AtmosphereMoonRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereMoonRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereMoonRotation) = value;
			}
		}

		// Token: 0x17006848 RID: 26696
		// (get) Token: 0x06019FD3 RID: 106451 RVA: 0x00266253 File Offset: 0x00264453
		// (set) Token: 0x06019FD4 RID: 106452 RVA: 0x00266267 File Offset: 0x00264467
		public unsafe FVector AtmosphereMoonForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereMoonForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AtmosphereMoonForward) = value;
			}
		}

		// Token: 0x17006849 RID: 26697
		// (get) Token: 0x06019FD5 RID: 106453 RVA: 0x0026627C File Offset: 0x0026447C
		// (set) Token: 0x06019FD6 RID: 106454 RVA: 0x0026628C File Offset: 0x0026448C
		public unsafe int KuroViewCenterPlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroViewCenterPlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroViewCenterPlayerIndex) = value;
			}
		}

		// Token: 0x1700684A RID: 26698
		// (get) Token: 0x06019FD7 RID: 106455 RVA: 0x0026629D File Offset: 0x0026449D
		// (set) Token: 0x06019FD8 RID: 106456 RVA: 0x002662AD File Offset: 0x002644AD
		public unsafe float KuroViewCenterHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroViewCenterHeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroViewCenterHeightOffset) = value;
			}
		}

		// Token: 0x1700684B RID: 26699
		// (get) Token: 0x06019FD9 RID: 106457 RVA: 0x002662BE File Offset: 0x002644BE
		// (set) Token: 0x06019FDA RID: 106458 RVA: 0x002662CE File Offset: 0x002644CE
		public unsafe bool bEnableCustomKuroViewCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bEnableCustomKuroViewCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bEnableCustomKuroViewCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700684C RID: 26700
		// (get) Token: 0x06019FDB RID: 106459 RVA: 0x002662DF File Offset: 0x002644DF
		// (set) Token: 0x06019FDC RID: 106460 RVA: 0x002662F3 File Offset: 0x002644F3
		public unsafe FVector CustomKuroViewCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CustomKuroViewCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CustomKuroViewCenter) = value;
			}
		}

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x06019FDD RID: 106461 RVA: 0x00266308 File Offset: 0x00264508
		// (set) Token: 0x06019FDE RID: 106462 RVA: 0x0026631C File Offset: 0x0026451C
		public unsafe FVector CurrentKuroViewCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CurrentKuroViewCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CurrentKuroViewCenter) = value;
			}
		}

		// Token: 0x1700684E RID: 26702
		// (get) Token: 0x06019FDF RID: 106463 RVA: 0x00266331 File Offset: 0x00264531
		// (set) Token: 0x06019FE0 RID: 106464 RVA: 0x00266341 File Offset: 0x00264541
		public unsafe float KuroTrailSystemEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroTrailSystemEnable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroTrailSystemEnable) = value;
			}
		}

		// Token: 0x1700684F RID: 26703
		// (get) Token: 0x06019FE1 RID: 106465 RVA: 0x00266352 File Offset: 0x00264552
		// (set) Token: 0x06019FE2 RID: 106466 RVA: 0x00266366 File Offset: 0x00264566
		public unsafe UTexture2D KuroTrailNoiseTexutre
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroTrailNoiseTexutre);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroTrailNoiseTexutre, value);
			}
		}

		// Token: 0x17006850 RID: 26704
		// (get) Token: 0x06019FE3 RID: 106467 RVA: 0x0026637B File Offset: 0x0026457B
		// (set) Token: 0x06019FE4 RID: 106468 RVA: 0x0026638B File Offset: 0x0026458B
		public unsafe float UpdatePostProcessDataThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_UpdatePostProcessDataThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_UpdatePostProcessDataThreshold) = value;
			}
		}

		// Token: 0x17006851 RID: 26705
		// (get) Token: 0x06019FE5 RID: 106469 RVA: 0x0026639C File Offset: 0x0026459C
		// (set) Token: 0x06019FE6 RID: 106470 RVA: 0x002663B0 File Offset: 0x002645B0
		public unsafe UTextureCube KuroSkyLightCubemap1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap1, value);
			}
		}

		// Token: 0x17006852 RID: 26706
		// (get) Token: 0x06019FE7 RID: 106471 RVA: 0x002663C5 File Offset: 0x002645C5
		// (set) Token: 0x06019FE8 RID: 106472 RVA: 0x002663D9 File Offset: 0x002645D9
		public unsafe UTextureCube KuroSkyLightCubemap2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap2, value);
			}
		}

		// Token: 0x17006853 RID: 26707
		// (get) Token: 0x06019FE9 RID: 106473 RVA: 0x002663EE File Offset: 0x002645EE
		// (set) Token: 0x06019FEA RID: 106474 RVA: 0x00266402 File Offset: 0x00264602
		public unsafe UTextureCube KuroSkyLightCubemap3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_KuroSkyLightCubemap3, value);
			}
		}

		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x06019FEB RID: 106475 RVA: 0x00266417 File Offset: 0x00264617
		// (set) Token: 0x06019FEC RID: 106476 RVA: 0x00266427 File Offset: 0x00264627
		public unsafe float KuroCubemapBlend12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroCubemapBlend12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroCubemapBlend12) = value;
			}
		}

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x06019FED RID: 106477 RVA: 0x00266438 File Offset: 0x00264638
		// (set) Token: 0x06019FEE RID: 106478 RVA: 0x00266448 File Offset: 0x00264648
		public unsafe float KuroCubemapBlend23
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroCubemapBlend23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroCubemapBlend23) = value;
			}
		}

		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x06019FEF RID: 106479 RVA: 0x00266459 File Offset: 0x00264659
		// (set) Token: 0x06019FF0 RID: 106480 RVA: 0x00266469 File Offset: 0x00264669
		public unsafe int KuroGlobalGIIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroGlobalGIIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_KuroGlobalGIIndex) = value;
			}
		}

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x06019FF1 RID: 106481 RVA: 0x0026647A File Offset: 0x0026467A
		// (set) Token: 0x06019FF2 RID: 106482 RVA: 0x0026648A File Offset: 0x0026468A
		public unsafe int GIID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GIID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GIID) = value;
			}
		}

		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x06019FF3 RID: 106483 RVA: 0x0026649B File Offset: 0x0026469B
		// (set) Token: 0x06019FF4 RID: 106484 RVA: 0x002664AB File Offset: 0x002646AB
		public unsafe bool IsKuroInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsKuroInit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_IsKuroInit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x06019FF5 RID: 106485 RVA: 0x002664BC File Offset: 0x002646BC
		// (set) Token: 0x06019FF6 RID: 106486 RVA: 0x002664D0 File Offset: 0x002646D0
		public unsafe UMaterialParameterCollection GIMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_GIMPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_GIMPC, value);
			}
		}

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x06019FF7 RID: 106487 RVA: 0x002664E8 File Offset: 0x002646E8
		// (set) Token: 0x06019FF8 RID: 106488 RVA: 0x00266521 File Offset: 0x00264721
		[Nullable(1)]
		public FKuroCurveFloat FogTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogTime) == null)
				{
					result = (this._FogTime = new FKuroCurveFloat(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FogTime, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FogTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x06019FF9 RID: 106489 RVA: 0x00266544 File Offset: 0x00264744
		// (set) Token: 0x06019FFA RID: 106490 RVA: 0x0026657D File Offset: 0x0026477D
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		public TMap<UClusteredStuffDataAsset, TWeakObjectPtr<AKuroRuntimeTransientActor>> ClusteredStuffTransientActors
		{
			[return: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<UClusteredStuffDataAsset, TWeakObjectPtr<AKuroRuntimeTransientActor>> result;
				if ((result = this._ClusteredStuffTransientActors) == null)
				{
					result = (this._ClusteredStuffTransientActors = new TMap<UClusteredStuffDataAsset, TWeakObjectPtr<AKuroRuntimeTransientActor>>(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ClusteredStuffTransientActors, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			set
			{
				this.ClusteredStuffTransientActors.CopyAssign(value);
			}
		}

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x06019FFB RID: 106491 RVA: 0x0026658C File Offset: 0x0026478C
		// (set) Token: 0x06019FFC RID: 106492 RVA: 0x002665C5 File Offset: 0x002647C5
		[Nullable(1)]
		public TSet<UClusteredStuffDataAsset> ClusteredStuffActive
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UClusteredStuffDataAsset> result;
				if ((result = this._ClusteredStuffActive) == null)
				{
					result = (this._ClusteredStuffActive = new TSet<UClusteredStuffDataAsset>(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_ClusteredStuffActive, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClusteredStuffActive.CopyAssign(value);
			}
		}

		// Token: 0x1700685D RID: 26717
		// (get) Token: 0x06019FFD RID: 106493 RVA: 0x002665D4 File Offset: 0x002647D4
		// (set) Token: 0x06019FFE RID: 106494 RVA: 0x0026660D File Offset: 0x0026480D
		[Nullable(1)]
		public TArray<UClusteredStuffDataAsset> AdditionalClusteredStuff
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UClusteredStuffDataAsset> result;
				if ((result = this._AdditionalClusteredStuff) == null)
				{
					result = (this._AdditionalClusteredStuff = new TArray<UClusteredStuffDataAsset>(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_AdditionalClusteredStuff, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AdditionalClusteredStuff.CopyAssign(value);
			}
		}

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x06019FFF RID: 106495 RVA: 0x0026661B File Offset: 0x0026481B
		// (set) Token: 0x0601A000 RID: 106496 RVA: 0x0026662F File Offset: 0x0026482F
		public unsafe UClusteredStuffDataAsset DefaultAutoGrassData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_DefaultAutoGrassData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_DefaultAutoGrassData, value);
			}
		}

		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x0601A001 RID: 106497 RVA: 0x00266644 File Offset: 0x00264844
		// (set) Token: 0x0601A002 RID: 106498 RVA: 0x00266658 File Offset: 0x00264858
		public unsafe USunLensFlareConfig DefaultSunLensflareConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USunLensFlareConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_DefaultSunLensflareConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_DefaultSunLensflareConfig, value);
			}
		}

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x0601A003 RID: 106499 RVA: 0x0026666D File Offset: 0x0026486D
		// (set) Token: 0x0601A004 RID: 106500 RVA: 0x00266681 File Offset: 0x00264881
		public unsafe UMaterialInstanceDynamic StarsMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_StarsMat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_StarsMat, value);
			}
		}

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x0601A005 RID: 106501 RVA: 0x00266696 File Offset: 0x00264896
		// (set) Token: 0x0601A006 RID: 106502 RVA: 0x002666AA File Offset: 0x002648AA
		public unsafe UMaterialInstanceDynamic MilkyWayMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_MilkyWayMat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_MilkyWayMat, value);
			}
		}

		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x0601A007 RID: 106503 RVA: 0x002666BF File Offset: 0x002648BF
		// (set) Token: 0x0601A008 RID: 106504 RVA: 0x002666D3 File Offset: 0x002648D3
		public unsafe UMaterialInstanceDynamic SkyBoxMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_SkyBoxMat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_SkyBoxMat, value);
			}
		}

		// Token: 0x17006863 RID: 26723
		// (get) Token: 0x0601A009 RID: 106505 RVA: 0x002666E8 File Offset: 0x002648E8
		// (set) Token: 0x0601A00A RID: 106506 RVA: 0x002666F8 File Offset: 0x002648F8
		public unsafe bool bPlayerInCave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPlayerInCave) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPlayerInCave) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006864 RID: 26724
		// (get) Token: 0x0601A00B RID: 106507 RVA: 0x00266709 File Offset: 0x00264909
		// (set) Token: 0x0601A00C RID: 106508 RVA: 0x00266719 File Offset: 0x00264919
		public unsafe bool bPlayerInGrass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPlayerInGrass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bPlayerInGrass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x0601A00D RID: 106509 RVA: 0x0026672A File Offset: 0x0026492A
		// (set) Token: 0x0601A00E RID: 106510 RVA: 0x0026673A File Offset: 0x0026493A
		public unsafe bool bForbidWeather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bForbidWeather) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bForbidWeather) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x0601A00F RID: 106511 RVA: 0x0026674B File Offset: 0x0026494B
		// (set) Token: 0x0601A010 RID: 106512 RVA: 0x0026675F File Offset: 0x0026495F
		public unsafe UKuroPointCloudStreamingConfig GlobalPointCloudStreamingConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudStreamingConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_GlobalPointCloudStreamingConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_GlobalPointCloudStreamingConfig, value);
			}
		}

		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x0601A011 RID: 106513 RVA: 0x00266774 File Offset: 0x00264974
		// (set) Token: 0x0601A012 RID: 106514 RVA: 0x00266784 File Offset: 0x00264984
		public unsafe float GlobalPointCloudStreamingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalPointCloudStreamingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_GlobalPointCloudStreamingDistance) = value;
			}
		}

		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x0601A013 RID: 106515 RVA: 0x00266795 File Offset: 0x00264995
		// (set) Token: 0x0601A014 RID: 106516 RVA: 0x002667A9 File Offset: 0x002649A9
		public unsafe UKuroTODData TODDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTODData>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TODDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TODDataAsset, value);
			}
		}

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x0601A015 RID: 106517 RVA: 0x002667BE File Offset: 0x002649BE
		// (set) Token: 0x0601A016 RID: 106518 RVA: 0x002667D2 File Offset: 0x002649D2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UKuroGISystem> CachedGISystem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CachedGISystem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_CachedGISystem) = value;
			}
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x0601A017 RID: 106519 RVA: 0x002667E7 File Offset: 0x002649E7
		// (set) Token: 0x0601A018 RID: 106520 RVA: 0x002667FB File Offset: 0x002649FB
		public unsafe UMaterialInstanceDynamic LightFunctionMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMaterialDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMaterialDynamic, value);
			}
		}

		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x0601A019 RID: 106521 RVA: 0x00266810 File Offset: 0x00264A10
		// (set) Token: 0x0601A01A RID: 106522 RVA: 0x00266824 File Offset: 0x00264A24
		public unsafe UMaterialInstanceDynamic LightFunctionMIPerformance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMIPerformance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMIPerformance, value);
			}
		}

		// Token: 0x1700686C RID: 26732
		// (get) Token: 0x0601A01B RID: 106523 RVA: 0x00266839 File Offset: 0x00264A39
		// (set) Token: 0x0601A01C RID: 106524 RVA: 0x0026684D File Offset: 0x00264A4D
		public unsafe UMaterialInstanceDynamic LightFunctionMIDefault
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMIDefault);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LightFunctionMIDefault, value);
			}
		}

		// Token: 0x1700686D RID: 26733
		// (get) Token: 0x0601A01D RID: 106525 RVA: 0x00266862 File Offset: 0x00264A62
		// (set) Token: 0x0601A01E RID: 106526 RVA: 0x00266876 File Offset: 0x00264A76
		public unsafe UMaterialInstanceDynamic VolumetricLightFunctionMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_VolumetricLightFunctionMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_VolumetricLightFunctionMI, value);
			}
		}

		// Token: 0x1700686E RID: 26734
		// (get) Token: 0x0601A01F RID: 106527 RVA: 0x0026688B File Offset: 0x00264A8B
		// (set) Token: 0x0601A020 RID: 106528 RVA: 0x0026689F File Offset: 0x00264A9F
		public unsafe UPhysicalMaterial LastFrameGlobalFootstepMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LastFrameGlobalFootstepMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_LastFrameGlobalFootstepMaterial, value);
			}
		}

		// Token: 0x1700686F RID: 26735
		// (get) Token: 0x0601A021 RID: 106529 RVA: 0x002668B4 File Offset: 0x00264AB4
		// (set) Token: 0x0601A022 RID: 106530 RVA: 0x002668C4 File Offset: 0x00264AC4
		public unsafe float FinalRoughnessDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRoughnessDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRoughnessDensity) = value;
			}
		}

		// Token: 0x17006870 RID: 26736
		// (get) Token: 0x0601A023 RID: 106531 RVA: 0x002668D5 File Offset: 0x00264AD5
		// (set) Token: 0x0601A024 RID: 106532 RVA: 0x002668E5 File Offset: 0x00264AE5
		public unsafe float FinalRainDensityValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRainDensityValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRainDensityValue) = value;
			}
		}

		// Token: 0x17006871 RID: 26737
		// (get) Token: 0x0601A025 RID: 106533 RVA: 0x002668F6 File Offset: 0x00264AF6
		// (set) Token: 0x0601A026 RID: 106534 RVA: 0x00266906 File Offset: 0x00264B06
		public unsafe float FinalSnowCoverIntensityValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalSnowCoverIntensityValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalSnowCoverIntensityValue) = value;
			}
		}

		// Token: 0x17006872 RID: 26738
		// (get) Token: 0x0601A027 RID: 106535 RVA: 0x00266917 File Offset: 0x00264B17
		// (set) Token: 0x0601A028 RID: 106536 RVA: 0x00266927 File Offset: 0x00264B27
		public unsafe float FinalRainGravityValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRainGravityValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_FinalRainGravityValue) = value;
			}
		}

		// Token: 0x17006873 RID: 26739
		// (get) Token: 0x0601A029 RID: 106537 RVA: 0x00266938 File Offset: 0x00264B38
		// (set) Token: 0x0601A02A RID: 106538 RVA: 0x00266948 File Offset: 0x00264B48
		public unsafe float RainGravityStepSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_RainGravityStepSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_RainGravityStepSpeed) = value;
			}
		}

		// Token: 0x17006874 RID: 26740
		// (get) Token: 0x0601A02B RID: 106539 RVA: 0x00266959 File Offset: 0x00264B59
		// (set) Token: 0x0601A02C RID: 106540 RVA: 0x0026696D File Offset: 0x00264B6D
		public unsafe UTexture TargetLightFunctionMap_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetLightFunctionMap_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetLightFunctionMap_Texture, value);
			}
		}

		// Token: 0x17006875 RID: 26741
		// (get) Token: 0x0601A02D RID: 106541 RVA: 0x00266982 File Offset: 0x00264B82
		// (set) Token: 0x0601A02E RID: 106542 RVA: 0x00266996 File Offset: 0x00264B96
		public unsafe UTexture FinalLightFunctionMap_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalLightFunctionMap_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalLightFunctionMap_Texture, value);
			}
		}

		// Token: 0x17006876 RID: 26742
		// (get) Token: 0x0601A02F RID: 106543 RVA: 0x002669AB File Offset: 0x00264BAB
		// (set) Token: 0x0601A030 RID: 106544 RVA: 0x002669BF File Offset: 0x00264BBF
		public unsafe UTexture TargetLightFunctionPerShadowMap_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetLightFunctionPerShadowMap_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetLightFunctionPerShadowMap_Texture, value);
			}
		}

		// Token: 0x17006877 RID: 26743
		// (get) Token: 0x0601A031 RID: 106545 RVA: 0x002669D4 File Offset: 0x00264BD4
		// (set) Token: 0x0601A032 RID: 106546 RVA: 0x002669E8 File Offset: 0x00264BE8
		public unsafe UTexture FinalLightFunctionPerShadowMap_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalLightFunctionPerShadowMap_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalLightFunctionPerShadowMap_Texture, value);
			}
		}

		// Token: 0x17006878 RID: 26744
		// (get) Token: 0x0601A033 RID: 106547 RVA: 0x002669FD File Offset: 0x00264BFD
		// (set) Token: 0x0601A034 RID: 106548 RVA: 0x00266A11 File Offset: 0x00264C11
		public unsafe UTexture TargetMilkyWayTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayTexture, value);
			}
		}

		// Token: 0x17006879 RID: 26745
		// (get) Token: 0x0601A035 RID: 106549 RVA: 0x00266A26 File Offset: 0x00264C26
		// (set) Token: 0x0601A036 RID: 106550 RVA: 0x00266A3A File Offset: 0x00264C3A
		public unsafe UTexture FinalMilkyWayTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayTexture, value);
			}
		}

		// Token: 0x1700687A RID: 26746
		// (get) Token: 0x0601A037 RID: 106551 RVA: 0x00266A4F File Offset: 0x00264C4F
		// (set) Token: 0x0601A038 RID: 106552 RVA: 0x00266A63 File Offset: 0x00264C63
		public unsafe UTexture TargetMilkyWayDistortionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayDistortionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayDistortionTexture, value);
			}
		}

		// Token: 0x1700687B RID: 26747
		// (get) Token: 0x0601A039 RID: 106553 RVA: 0x00266A78 File Offset: 0x00264C78
		// (set) Token: 0x0601A03A RID: 106554 RVA: 0x00266A8C File Offset: 0x00264C8C
		public unsafe UTexture FinalMilkyWayDistortionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayDistortionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayDistortionTexture, value);
			}
		}

		// Token: 0x1700687C RID: 26748
		// (get) Token: 0x0601A03B RID: 106555 RVA: 0x00266AA1 File Offset: 0x00264CA1
		// (set) Token: 0x0601A03C RID: 106556 RVA: 0x00266AB5 File Offset: 0x00264CB5
		public unsafe UTexture TargetMilkyWayStarTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayStarTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_TargetMilkyWayStarTexture, value);
			}
		}

		// Token: 0x1700687D RID: 26749
		// (get) Token: 0x0601A03D RID: 106557 RVA: 0x00266ACA File Offset: 0x00264CCA
		// (set) Token: 0x0601A03E RID: 106558 RVA: 0x00266ADE File Offset: 0x00264CDE
		public unsafe UTexture FinalMilkyWayStarTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayStarTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_FinalMilkyWayStarTexture, value);
			}
		}

		// Token: 0x1700687E RID: 26750
		// (get) Token: 0x0601A03F RID: 106559 RVA: 0x00266AF3 File Offset: 0x00264CF3
		// (set) Token: 0x0601A040 RID: 106560 RVA: 0x00266B07 File Offset: 0x00264D07
		public unsafe UDirectionalLightComponent AtmosphereSunLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_AtmosphereSunLight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_AtmosphereSunLight, value);
			}
		}

		// Token: 0x1700687F RID: 26751
		// (get) Token: 0x0601A041 RID: 106561 RVA: 0x00266B1C File Offset: 0x00264D1C
		// (set) Token: 0x0601A042 RID: 106562 RVA: 0x00266B30 File Offset: 0x00264D30
		public unsafe UDirectionalLightComponent AtmosphereMoonLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_AtmosphereMoonLight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGlobalGI.__PropertyOffset_AtmosphereMoonLight, value);
			}
		}

		// Token: 0x17006880 RID: 26752
		// (get) Token: 0x0601A043 RID: 106563 RVA: 0x00266B45 File Offset: 0x00264D45
		// (set) Token: 0x0601A044 RID: 106564 RVA: 0x00266B55 File Offset: 0x00264D55
		public unsafe bool bDisableWeatherTemporalLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bDisableWeatherTemporalLerp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_bDisableWeatherTemporalLerp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006881 RID: 26753
		// (get) Token: 0x0601A045 RID: 106565 RVA: 0x00266B68 File Offset: 0x00264D68
		// (set) Token: 0x0601A046 RID: 106566 RVA: 0x00266BA1 File Offset: 0x00264DA1
		[Nullable(1)]
		public TMap<FName, FKuroGICustomTag> PostProcessCustomTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroGICustomTag> result;
				if ((result = this._PostProcessCustomTags) == null)
				{
					result = (this._PostProcessCustomTags = new TMap<FName, FKuroGICustomTag>(base.NativePtr + (IntPtr)AKuroGlobalGI.__PropertyOffset_PostProcessCustomTags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PostProcessCustomTags.CopyAssign(value);
			}
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x00266BAF File Offset: 0x00264DAF
		public void UpdateTODData(UObject WorldContextObject, FVector WorldPosition, float TimeSecnod)
		{
			AKuroGlobalGI.__UpdateTODData_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, TimeSecnod);
		}

		// Token: 0x0601A048 RID: 106568 RVA: 0x00266BCE File Offset: 0x00264DCE
		public void UpdatePostProcessSettingData(UObject WorldContextObject, float CurTime, bool bSkipLerpData = false, bool bEnableLumen = false)
		{
			AKuroGlobalGI.__UpdatePostProcessSettingData_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CurTime, bSkipLerpData, bEnableLumen);
		}

		// Token: 0x0601A049 RID: 106569 RVA: 0x00266BEF File Offset: 0x00264DEF
		public void UpdateLightEnableCastShadow(UObject WorldContextObject, UDirectionalLightComponent SceneLight)
		{
			AKuroGlobalGI.__UpdateLightEnableCastShadow_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SceneLight != null) ? SceneLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A04A RID: 106570 RVA: 0x00266C1C File Offset: 0x00264E1C
		public void UpdateLightDirection(UObject WorldContextObject, UDirectionalLightComponent AtmoSunLight, UDirectionalLightComponent AtmoMoonLight)
		{
			AKuroGlobalGI.__UpdateLightDirection_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AtmoSunLight != null) ? AtmoSunLight.NativePtr : IntPtr.Zero, (AtmoMoonLight != null) ? AtmoMoonLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A04B RID: 106571 RVA: 0x00266C59 File Offset: 0x00264E59
		public void UpdateKuroTrailSystem(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateKuroTrailSystem_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A04C RID: 106572 RVA: 0x00266C86 File Offset: 0x00264E86
		public void UpdateCharPosition(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateCharPosition_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A04D RID: 106573 RVA: 0x00266CB3 File Offset: 0x00264EB3
		public void UpdateCharLightHorizontal(UObject WorldContextObject, in FRotator SceneLightRot, UMaterialParameterCollection Collection, bool bDebugCharLightHorizontal = false, float DebugCharLightHorizontal = 0f, float DebugCharLightVertical = 0f)
		{
			AKuroGlobalGI.__UpdateCharLightHorizontal_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, SceneLightRot, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, bDebugCharLightHorizontal, DebugCharLightHorizontal, DebugCharLightVertical);
		}

		// Token: 0x0601A04E RID: 106574 RVA: 0x00266CE7 File Offset: 0x00264EE7
		public void UpdateAndApplyWind(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateAndApplyWind_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A04F RID: 106575 RVA: 0x00266D14 File Offset: 0x00264F14
		public void UpdateAndApplyWeather()
		{
			AKuroGlobalGI.__UpdateAndApplyWeather_Internal(base.NativePtr);
		}

		// Token: 0x0601A050 RID: 106576 RVA: 0x00266D21 File Offset: 0x00264F21
		public void TickWeatherTransitionData(float DeltaTime)
		{
			AKuroGlobalGI.__TickWeatherTransitionData_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601A051 RID: 106577 RVA: 0x00266D2F File Offset: 0x00264F2F
		public void SetSunLensflareEnabled(bool bEnable)
		{
			AKuroGlobalGI.__SetSunLensflareEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0601A052 RID: 106578 RVA: 0x00266D3D File Offset: 0x00264F3D
		public void SetGlobalTimeDilation(float TimeDilation)
		{
			AKuroGlobalGI.__SetGlobalTimeDilation_Internal(base.NativePtr, TimeDilation);
		}

		// Token: 0x0601A053 RID: 106579 RVA: 0x00266D4B File Offset: 0x00264F4B
		public void SetGITime(float Time)
		{
			AKuroGlobalGI.__SetGITime_Internal(base.NativePtr, Time);
		}

		// Token: 0x0601A054 RID: 106580 RVA: 0x00266D59 File Offset: 0x00264F59
		public virtual void OnPostProcessCustomTagsUpdated()
		{
			AKuroGlobalGI.__OnPostProcessCustomTagsUpdated_Internal(base.NativePtr);
		}

		// Token: 0x0601A055 RID: 106581 RVA: 0x00266D66 File Offset: 0x00264F66
		public virtual void OnKuroTickEditor(float DeltaTime)
		{
			AKuroGlobalGI.__OnKuroTickEditor_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601A056 RID: 106582 RVA: 0x00266D74 File Offset: 0x00264F74
		public virtual void OnKuroTick(float DeltaTime)
		{
			AKuroGlobalGI.__OnKuroTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601A057 RID: 106583 RVA: 0x00266D84 File Offset: 0x00264F84
		[NullableContext(1)]
		public unsafe virtual void OnKuroStartUiScene(string InName, [Nullable(2)] ULevel InUILevel)
		{
			FString fstring = FString.AllocTemp(InName);
			AKuroGlobalGI.__OnKuroStartUiScene_Internal(base.NativePtr, fstring, (InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A058 RID: 106584 RVA: 0x00266DC0 File Offset: 0x00264FC0
		[NullableContext(1)]
		public unsafe virtual void OnKuroStartUI(string InName, [Nullable(2)] ULevel InUILevel)
		{
			FString fstring = FString.AllocTemp(InName);
			AKuroGlobalGI.__OnKuroStartUI_Internal(base.NativePtr, fstring, (InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A059 RID: 106585 RVA: 0x00266DFA File Offset: 0x00264FFA
		public virtual void OnKuroSetRuntimeTime(float CurrentTime)
		{
			AKuroGlobalGI.__OnKuroSetRuntimeTime_Internal(base.NativePtr, CurrentTime);
		}

		// Token: 0x0601A05A RID: 106586 RVA: 0x00266E08 File Offset: 0x00265008
		public virtual void OnKuroRuntimeDestroy()
		{
			AKuroGlobalGI.__OnKuroRuntimeDestroy_Internal(base.NativePtr);
		}

		// Token: 0x0601A05B RID: 106587 RVA: 0x00266E15 File Offset: 0x00265015
		public virtual void OnKuroInit()
		{
			AKuroGlobalGI.__OnKuroInit_Internal(base.NativePtr);
		}

		// Token: 0x0601A05C RID: 106588 RVA: 0x00266E22 File Offset: 0x00265022
		public virtual void OnKuroEndUiScene()
		{
			AKuroGlobalGI.__OnKuroEndUiScene_Internal(base.NativePtr);
		}

		// Token: 0x0601A05D RID: 106589 RVA: 0x00266E2F File Offset: 0x0026502F
		public virtual void OnKuroEndUI()
		{
			AKuroGlobalGI.__OnKuroEndUI_Internal(base.NativePtr);
		}

		// Token: 0x0601A05E RID: 106590 RVA: 0x00266E3C File Offset: 0x0026503C
		public bool K2_IsInPersistentLevel()
		{
			return AKuroGlobalGI.__K2_IsInPersistentLevel_Internal(base.NativePtr);
		}

		// Token: 0x0601A05F RID: 106591 RVA: 0x00266E49 File Offset: 0x00265049
		public float GetPostProcessVolumeWeight(AKuroPostProcessVolume InPostProcessVolume)
		{
			return AKuroGlobalGI.__GetPostProcessVolumeWeight_Internal(base.NativePtr, (InPostProcessVolume != null) ? InPostProcessVolume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A060 RID: 106592 RVA: 0x00266E66 File Offset: 0x00265066
		public float GetGITime()
		{
			return AKuroGlobalGI.__GetGITime_Internal(base.NativePtr);
		}

		// Token: 0x0601A061 RID: 106593 RVA: 0x00266E73 File Offset: 0x00265073
		public UKuroGISystem GetCachedGISystem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGISystem>(AKuroGlobalGI.__GetCachedGISystem_Internal(base.NativePtr));
		}

		// Token: 0x0601A062 RID: 106594 RVA: 0x00266E85 File Offset: 0x00265085
		public void ClearLensflare()
		{
			AKuroGlobalGI.__ClearLensflare_Internal(base.NativePtr);
		}

		// Token: 0x0601A063 RID: 106595 RVA: 0x00266E94 File Offset: 0x00265094
		public unsafe void CalLightDirectionWithLimit(float Time, float LightAngleLimit, ref FRotator LightRotation)
		{
			fixed (FRotator* ptr = &LightRotation)
			{
				void* ptr2 = (void*)ptr;
				AKuroGlobalGI.__CalLightDirectionWithLimit_Internal(base.NativePtr, Time, LightAngleLimit, ref LightRotation);
			}
		}

		// Token: 0x0601A064 RID: 106596 RVA: 0x00266EB7 File Offset: 0x002650B7
		public float CalcTODTimeFactor(float StartTime, float EndTime, float CurrTime)
		{
			return AKuroGlobalGI.__CalcTODTimeFactor_Internal(base.NativePtr, StartTime, EndTime, CurrTime);
		}

		// Token: 0x0601A065 RID: 106597 RVA: 0x00266EC7 File Offset: 0x002650C7
		public static void BindEventGlobalFootstepMaterialUpdate(FOnGlobalFootstepMaterialUpdateDelegate InDelegate)
		{
			AKuroGlobalGI.__BindEventGlobalFootstepMaterialUpdate_Internal((InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601A066 RID: 106598 RVA: 0x00266EDB File Offset: 0x002650DB
		public static void BindEventForbidWeatherStateChanged(FOnForbidWeatherStateChangedDelegate InDelegate)
		{
			AKuroGlobalGI.__BindEventForbidWeatherStateChanged_Internal((InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601A067 RID: 106599 RVA: 0x00266EEF File Offset: 0x002650EF
		public void ApplyVolumeCloudGodRay(UDirectionalLightComponent SunLight, UDirectionalLightComponent MoonLight, bool bIsDay)
		{
			AKuroGlobalGI.__ApplyVolumeCloudGodRay_Internal(base.NativePtr, (SunLight != null) ? SunLight.NativePtr : IntPtr.Zero, (MoonLight != null) ? MoonLight.NativePtr : IntPtr.Zero, bIsDay);
		}

		// Token: 0x0601A068 RID: 106600 RVA: 0x00266F1D File Offset: 0x0026511D
		public void ApplyStarsParameters(UMaterialInstance StarMaterial, UStaticMeshComponent StarMeshComponent, float Time, UMaterialInstance StarMaterial_V2)
		{
			AKuroGlobalGI.__ApplyStarsParameters_Internal(base.NativePtr, (StarMaterial != null) ? StarMaterial.NativePtr : IntPtr.Zero, (StarMeshComponent != null) ? StarMeshComponent.NativePtr : IntPtr.Zero, Time, (StarMaterial_V2 != null) ? StarMaterial_V2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A069 RID: 106601 RVA: 0x00266F5D File Offset: 0x0026515D
		public void ApplySkyVolumetricCloudMPC(UMaterialParameterCollection MPC)
		{
			AKuroGlobalGI.__ApplySkyVolumetricCloudMPC_Internal(base.NativePtr, (MPC != null) ? MPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A06A RID: 106602 RVA: 0x00266F7A File Offset: 0x0026517A
		public void ApplySkyEffectsParameters(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplySkyEffectsParameters_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A06B RID: 106603 RVA: 0x00266FA8 File Offset: 0x002651A8
		public void ApplySkyBoxSetting(UObject WorldContextObject, UMaterialParameterCollection Collection, UMaterialInstance SkyBoxMaterial, UStaticMeshComponent SkyBoxMeshComponent, float Time)
		{
			AKuroGlobalGI.__ApplySkyBoxSetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (SkyBoxMaterial != null) ? SkyBoxMaterial.NativePtr : IntPtr.Zero, (SkyBoxMeshComponent != null) ? SkyBoxMeshComponent.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x0601A06C RID: 106604 RVA: 0x00267004 File Offset: 0x00265204
		public void ApplyRainOverrider(AKuroWorldRainGlobalOverrider Overrider)
		{
			AKuroGlobalGI.__ApplyRainOverrider_Internal(base.NativePtr, (Overrider != null) ? Overrider.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A06D RID: 106605 RVA: 0x00267024 File Offset: 0x00265224
		public unsafe void ApplyOriginSkyAtmosphere(USkyAtmosphereComponent SkyAtm, UExponentialHeightFogComponent HeightFog, ref float SkyAtmosAffectSkyBox)
		{
			fixed (float* ptr = &SkyAtmosAffectSkyBox)
			{
				void* ptr2 = (void*)ptr;
				AKuroGlobalGI.__ApplyOriginSkyAtmosphere_Internal(base.NativePtr, (SkyAtm != null) ? SkyAtm.NativePtr : IntPtr.Zero, (HeightFog != null) ? HeightFog.NativePtr : IntPtr.Zero, ref SkyAtmosAffectSkyBox);
			}
		}

		// Token: 0x0601A06E RID: 106606 RVA: 0x00267065 File Offset: 0x00265265
		public void ApplyMultipleLayerSkySetting(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyMultipleLayerSkySetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A06F RID: 106607 RVA: 0x00267092 File Offset: 0x00265292
		public void ApplyMilkyWayParameters(UMaterialInstance MilkyWayMaterial, UStaticMeshComponent MilkyWayMeshComponent, float Time)
		{
			AKuroGlobalGI.__ApplyMilkyWayParameters_Internal(base.NativePtr, (MilkyWayMaterial != null) ? MilkyWayMaterial.NativePtr : IntPtr.Zero, (MilkyWayMeshComponent != null) ? MilkyWayMeshComponent.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x0601A070 RID: 106608 RVA: 0x002670C0 File Offset: 0x002652C0
		public void ApplyMeshBlend()
		{
			AKuroGlobalGI.__ApplyMeshBlend_Internal(base.NativePtr);
		}

		// Token: 0x0601A071 RID: 106609 RVA: 0x002670CD File Offset: 0x002652CD
		public void ApplyLightShaft(UDirectionalLightComponent SceneLight)
		{
			AKuroGlobalGI.__ApplyLightShaft_Internal(base.NativePtr, (SceneLight != null) ? SceneLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A072 RID: 106610 RVA: 0x002670EC File Offset: 0x002652EC
		public unsafe void ApplyLightParameters_Conch(UObject WorldContextObject, UMaterialParameterCollection Collection, UDirectionalLightComponent SceneLight, bool bEnableLumen, ref FRotator SceneLightRotation)
		{
			fixed (FRotator* ptr = &SceneLightRotation)
			{
				void* ptr2 = (void*)ptr;
				AKuroGlobalGI.__ApplyLightParameters_Conch_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (SceneLight != null) ? SceneLight.NativePtr : IntPtr.Zero, bEnableLumen, ref SceneLightRotation);
			}
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x00267141 File Offset: 0x00265341
		public void ApplyLightParameters(UObject WorldContextObject, UMaterialParameterCollection Collection, UDirectionalLightComponent SceneLight, bool bEnableLumen)
		{
			AKuroGlobalGI.__ApplyLightParameters_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (SceneLight != null) ? SceneLight.NativePtr : IntPtr.Zero, bEnableLumen);
		}

		// Token: 0x0601A074 RID: 106612 RVA: 0x00267180 File Offset: 0x00265380
		public void ApplyLightFunctionSetting(UTexture DefaultLightFucntionTexture, UDirectionalLightComponent SceneLight, UMaterialInstance LightFunctionMaterial, UMaterialInstance LightFunctionPerShadowMaterial, UMaterialInstance VolumetricLightFunctionMaterial)
		{
			AKuroGlobalGI.__ApplyLightFunctionSetting_Internal(base.NativePtr, (DefaultLightFucntionTexture != null) ? DefaultLightFucntionTexture.NativePtr : IntPtr.Zero, (SceneLight != null) ? SceneLight.NativePtr : IntPtr.Zero, (LightFunctionMaterial != null) ? LightFunctionMaterial.NativePtr : IntPtr.Zero, (LightFunctionPerShadowMaterial != null) ? LightFunctionPerShadowMaterial.NativePtr : IntPtr.Zero, (VolumetricLightFunctionMaterial != null) ? VolumetricLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A075 RID: 106613 RVA: 0x002671EC File Offset: 0x002653EC
		public void ApplyLensflare(float DeltaTime, in FVector SunForward, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyLensflare_Internal(base.NativePtr, DeltaTime, SunForward, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A076 RID: 106614 RVA: 0x0026720B File Offset: 0x0026540B
		public void ApplyKuroSkyLight(USkyLightComponent SkyLight, float TimeOfDay, float DefaultShadowSupplement, float DefaultReflectionAddIntensity, bool bEnableLumen)
		{
			AKuroGlobalGI.__ApplyKuroSkyLight_Internal(base.NativePtr, (SkyLight != null) ? SkyLight.NativePtr : IntPtr.Zero, TimeOfDay, DefaultShadowSupplement, DefaultReflectionAddIntensity, bEnableLumen);
		}

		// Token: 0x0601A077 RID: 106615 RVA: 0x0026722E File Offset: 0x0026542E
		public void ApplyKuroOceanMPC(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyKuroOceanMPC_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A078 RID: 106616 RVA: 0x0026725B File Offset: 0x0026545B
		public void ApplyGodRay(UPostProcessComponent PostProcessVolume, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyGodRay_Internal(base.NativePtr, (PostProcessVolume != null) ? PostProcessVolume.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A079 RID: 106617 RVA: 0x00267288 File Offset: 0x00265488
		public void ApplyGlobalShaderParameters(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyGlobalShaderParameters_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A07A RID: 106618 RVA: 0x002672B5 File Offset: 0x002654B5
		public void ApplyGlobalGIRenderQuality()
		{
			AKuroGlobalGI.__ApplyGlobalGIRenderQuality_Internal(base.NativePtr);
		}

		// Token: 0x0601A07B RID: 106619 RVA: 0x002672C2 File Offset: 0x002654C2
		public void ApplyGIMPC()
		{
			AKuroGlobalGI.__ApplyGIMPC_Internal(base.NativePtr);
		}

		// Token: 0x0601A07C RID: 106620 RVA: 0x002672D0 File Offset: 0x002654D0
		public unsafe void ApplyFog(UObject WorldContextObject, UExponentialHeightFogComponent HeightFog, UMaterialParameterCollection Collection, float WorldZOffset, UStaticMeshComponent CloudOcean, ref bool bVolumeCloudNotAffectedByVRS, UStaticMeshComponent VolumeCloudMesh = null, USceneComponent VolumeCloud = null, USceneComponent VolumeCloudRange = null)
		{
			fixed (bool* ptr = &bVolumeCloudNotAffectedByVRS)
			{
				void* ptr2 = (void*)ptr;
				AKuroGlobalGI.__ApplyFog_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (HeightFog != null) ? HeightFog.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, WorldZOffset, (CloudOcean != null) ? CloudOcean.NativePtr : IntPtr.Zero, ref bVolumeCloudNotAffectedByVRS, (VolumeCloudMesh != null) ? VolumeCloudMesh.NativePtr : IntPtr.Zero, (VolumeCloud != null) ? VolumeCloud.NativePtr : IntPtr.Zero, (VolumeCloudRange != null) ? VolumeCloudRange.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x0601A07D RID: 106621 RVA: 0x0026736D File Offset: 0x0026556D
		public void ApplyExtendedMPCs()
		{
			AKuroGlobalGI.__ApplyExtendedMPCs_Internal(base.NativePtr);
		}

		// Token: 0x0601A07E RID: 106622 RVA: 0x0026737A File Offset: 0x0026557A
		public void ApplyEffectMisc()
		{
			AKuroGlobalGI.__ApplyEffectMisc_Internal(base.NativePtr);
		}

		// Token: 0x0601A07F RID: 106623 RVA: 0x00267387 File Offset: 0x00265587
		public void ApplyClusteredStuff()
		{
			AKuroGlobalGI.__ApplyClusteredStuff_Internal(base.NativePtr);
		}

		// Token: 0x0601A080 RID: 106624 RVA: 0x00267394 File Offset: 0x00265594
		public void ApplyCloudCardSetting(UObject WorldContextObject, UMaterialParameterCollection Collection, bool bEnableLumen)
		{
			AKuroGlobalGI.__ApplyCloudCardSetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, bEnableLumen);
		}

		// Token: 0x0601A081 RID: 106625 RVA: 0x002673C2 File Offset: 0x002655C2
		public void ApplyAtmosLight(UDirectionalLightComponent SunLight, UDirectionalLightComponent MoonLight)
		{
			AKuroGlobalGI.__ApplyAtmosLight_Internal(base.NativePtr, (SunLight != null) ? SunLight.NativePtr : IntPtr.Zero, (MoonLight != null) ? MoonLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A082 RID: 106626 RVA: 0x002673EF File Offset: 0x002655EF
		public void ApplyAndUpdateDayNightDataLayer(float TimeOfDay, float TODLightLoadingWait = 5f)
		{
			AKuroGlobalGI.__ApplyAndUpdateDayNightDataLayer_Internal(base.NativePtr, TimeOfDay, TODLightLoadingWait);
		}

		// Token: 0x0601A083 RID: 106627 RVA: 0x002673FE File Offset: 0x002655FE
		public void Apply3DUISceneSkyLight(USkyLightComponent SkyLight)
		{
			AKuroGlobalGI.__Apply3DUISceneSkyLight_Internal(base.NativePtr, (SkyLight != null) ? SkyLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A084 RID: 106628 RVA: 0x0026741B File Offset: 0x0026561B
		public void ApplayShadowTintRampOffset(USkyLightComponent SkyLight)
		{
			AKuroGlobalGI.__ApplayShadowTintRampOffset_Internal(base.NativePtr, (SkyLight != null) ? SkyLight.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A085 RID: 106629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateTODData_Internal(IntPtr @this, IntPtr WorldContextObject, FVector WorldPosition, float TimeSecnod);

		// Token: 0x0601A086 RID: 106630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePostProcessSettingData_Internal(IntPtr @this, IntPtr WorldContextObject, float CurTime, bool bSkipLerpData, bool bEnableLumen);

		// Token: 0x0601A087 RID: 106631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLightEnableCastShadow_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr SceneLight);

		// Token: 0x0601A088 RID: 106632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLightDirection_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr AtmoSunLight, IntPtr AtmoMoonLight);

		// Token: 0x0601A089 RID: 106633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateKuroTrailSystem_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A08A RID: 106634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharPosition_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A08B RID: 106635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharLightHorizontal_Internal(IntPtr @this, IntPtr WorldContextObject, in FRotator SceneLightRot, IntPtr Collection, bool bDebugCharLightHorizontal, float DebugCharLightHorizontal, float DebugCharLightVertical);

		// Token: 0x0601A08C RID: 106636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAndApplyWind_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A08D RID: 106637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAndApplyWeather_Internal(IntPtr @this);

		// Token: 0x0601A08E RID: 106638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickWeatherTransitionData_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601A08F RID: 106639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSunLensflareEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0601A090 RID: 106640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalTimeDilation_Internal(IntPtr @this, float TimeDilation);

		// Token: 0x0601A091 RID: 106641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGITime_Internal(IntPtr @this, float Time);

		// Token: 0x0601A092 RID: 106642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostProcessCustomTagsUpdated_Internal(IntPtr @this);

		// Token: 0x0601A093 RID: 106643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroTickEditor_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601A094 RID: 106644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601A095 RID: 106645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroStartUiScene_Internal(IntPtr @this, in FString InName, IntPtr InUILevel);

		// Token: 0x0601A096 RID: 106646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroStartUI_Internal(IntPtr @this, in FString InName, IntPtr InUILevel);

		// Token: 0x0601A097 RID: 106647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroSetRuntimeTime_Internal(IntPtr @this, float CurrentTime);

		// Token: 0x0601A098 RID: 106648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroRuntimeDestroy_Internal(IntPtr @this);

		// Token: 0x0601A099 RID: 106649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroInit_Internal(IntPtr @this);

		// Token: 0x0601A09A RID: 106650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroEndUiScene_Internal(IntPtr @this);

		// Token: 0x0601A09B RID: 106651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroEndUI_Internal(IntPtr @this);

		// Token: 0x0601A09C RID: 106652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsInPersistentLevel_Internal(IntPtr @this);

		// Token: 0x0601A09D RID: 106653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPostProcessVolumeWeight_Internal(IntPtr @this, IntPtr InPostProcessVolume);

		// Token: 0x0601A09E RID: 106654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGITime_Internal(IntPtr @this);

		// Token: 0x0601A09F RID: 106655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCachedGISystem_Internal(IntPtr @this);

		// Token: 0x0601A0A0 RID: 106656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearLensflare_Internal(IntPtr @this);

		// Token: 0x0601A0A1 RID: 106657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalLightDirectionWithLimit_Internal(IntPtr @this, float Time, float LightAngleLimit, ref FRotator LightRotation);

		// Token: 0x0601A0A2 RID: 106658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalcTODTimeFactor_Internal(IntPtr @this, float StartTime, float EndTime, float CurrTime);

		// Token: 0x0601A0A3 RID: 106659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEventGlobalFootstepMaterialUpdate_Internal(IntPtr InDelegate);

		// Token: 0x0601A0A4 RID: 106660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEventForbidWeatherStateChanged_Internal(IntPtr InDelegate);

		// Token: 0x0601A0A5 RID: 106661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyVolumeCloudGodRay_Internal(IntPtr @this, IntPtr SunLight, IntPtr MoonLight, bool bIsDay);

		// Token: 0x0601A0A6 RID: 106662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyStarsParameters_Internal(IntPtr @this, IntPtr StarMaterial, IntPtr StarMeshComponent, float Time, IntPtr StarMaterial_V2);

		// Token: 0x0601A0A7 RID: 106663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyVolumetricCloudMPC_Internal(IntPtr @this, IntPtr MPC);

		// Token: 0x0601A0A8 RID: 106664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyEffectsParameters_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A0A9 RID: 106665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyBoxSetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, IntPtr SkyBoxMaterial, IntPtr SkyBoxMeshComponent, float Time);

		// Token: 0x0601A0AA RID: 106666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRainOverrider_Internal(IntPtr @this, IntPtr Overrider);

		// Token: 0x0601A0AB RID: 106667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyOriginSkyAtmosphere_Internal(IntPtr @this, IntPtr SkyAtm, IntPtr HeightFog, ref float SkyAtmosAffectSkyBox);

		// Token: 0x0601A0AC RID: 106668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMultipleLayerSkySetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A0AD RID: 106669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMilkyWayParameters_Internal(IntPtr @this, IntPtr MilkyWayMaterial, IntPtr MilkyWayMeshComponent, float Time);

		// Token: 0x0601A0AE RID: 106670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMeshBlend_Internal(IntPtr @this);

		// Token: 0x0601A0AF RID: 106671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightShaft_Internal(IntPtr @this, IntPtr SceneLight);

		// Token: 0x0601A0B0 RID: 106672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightParameters_Conch_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, IntPtr SceneLight, bool bEnableLumen, ref FRotator SceneLightRotation);

		// Token: 0x0601A0B1 RID: 106673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightParameters_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, IntPtr SceneLight, bool bEnableLumen);

		// Token: 0x0601A0B2 RID: 106674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLightFunctionSetting_Internal(IntPtr @this, IntPtr DefaultLightFucntionTexture, IntPtr SceneLight, IntPtr LightFunctionMaterial, IntPtr LightFunctionPerShadowMaterial, IntPtr VolumetricLightFunctionMaterial);

		// Token: 0x0601A0B3 RID: 106675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLensflare_Internal(IntPtr @this, float DeltaTime, in FVector SunForward, IntPtr Collection);

		// Token: 0x0601A0B4 RID: 106676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyKuroSkyLight_Internal(IntPtr @this, IntPtr SkyLight, float TimeOfDay, float DefaultShadowSupplement, float DefaultReflectionAddIntensity, bool bEnableLumen);

		// Token: 0x0601A0B5 RID: 106677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyKuroOceanMPC_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A0B6 RID: 106678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGodRay_Internal(IntPtr @this, IntPtr PostProcessVolume, IntPtr Collection);

		// Token: 0x0601A0B7 RID: 106679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGlobalShaderParameters_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x0601A0B8 RID: 106680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGlobalGIRenderQuality_Internal(IntPtr @this);

		// Token: 0x0601A0B9 RID: 106681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGIMPC_Internal(IntPtr @this);

		// Token: 0x0601A0BA RID: 106682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyFog_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr HeightFog, IntPtr Collection, float WorldZOffset, IntPtr CloudOcean, ref bool bVolumeCloudNotAffectedByVRS, IntPtr VolumeCloudMesh, IntPtr VolumeCloud, IntPtr VolumeCloudRange);

		// Token: 0x0601A0BB RID: 106683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyExtendedMPCs_Internal(IntPtr @this);

		// Token: 0x0601A0BC RID: 106684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEffectMisc_Internal(IntPtr @this);

		// Token: 0x0601A0BD RID: 106685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyClusteredStuff_Internal(IntPtr @this);

		// Token: 0x0601A0BE RID: 106686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyCloudCardSetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, bool bEnableLumen);

		// Token: 0x0601A0BF RID: 106687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAtmosLight_Internal(IntPtr @this, IntPtr SunLight, IntPtr MoonLight);

		// Token: 0x0601A0C0 RID: 106688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAndUpdateDayNightDataLayer_Internal(IntPtr @this, float TimeOfDay, float TODLightLoadingWait);

		// Token: 0x0601A0C1 RID: 106689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Apply3DUISceneSkyLight_Internal(IntPtr @this, IntPtr SkyLight);

		// Token: 0x0601A0C2 RID: 106690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplayShadowTintRampOffset_Internal(IntPtr @this, IntPtr SkyLight);

		// Token: 0x0601A0C3 RID: 106691 RVA: 0x00267438 File Offset: 0x00265638
		static AKuroGlobalGI()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI");
		}

		// Token: 0x0601A0C4 RID: 106692 RVA: 0x00267446 File Offset: 0x00265646
		protected AKuroGlobalGI(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E1E5 RID: 57829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI";

		// Token: 0x0400E1E6 RID: 57830
		private static IntPtr _ClassPtr;

		// Token: 0x0400E1E7 RID: 57831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E1E8 RID: 57832
		public static IntPtr __OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400E1E9 RID: 57833
		public static IntPtr __OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400E1EA RID: 57834
		internal static int __PropertyOffset_TickInEditor;

		// Token: 0x0400E1EB RID: 57835
		internal static int __PropertyOffset_IsPersistentLevelGI;

		// Token: 0x0400E1EC RID: 57836
		internal static int __PropertyOffset_bPostProcessVolumeChanged;

		// Token: 0x0400E1ED RID: 57837
		internal static int __PropertyOffset_TickDeltaTime;

		// Token: 0x0400E1EE RID: 57838
		internal static int __PropertyOffset_ViewLocation;

		// Token: 0x0400E1EF RID: 57839
		internal static int __PropertyOffset_DisableGlobalGITransition;

		// Token: 0x0400E1F0 RID: 57840
		internal static int __PropertyOffset_DisableSkyBlendingSkip;

		// Token: 0x0400E1F1 RID: 57841
		internal static int __PropertyOffset_DisableFixedTimeState;

		// Token: 0x0400E1F2 RID: 57842
		internal static int __PropertyOffset_SunHorizonAngle;

		// Token: 0x0400E1F3 RID: 57843
		internal static int __PropertyOffset_SunVerticalAngle;

		// Token: 0x0400E1F4 RID: 57844
		internal static int __PropertyOffset_IsReversed;

		// Token: 0x0400E1F5 RID: 57845
		internal static int __PropertyOffset_ReverseZCenter;

		// Token: 0x0400E1F6 RID: 57846
		internal static int __PropertyOffset_bLockSceneLightVerticalAngle;

		// Token: 0x0400E1F7 RID: 57847
		internal static int __PropertyOffset_SceneLightVerticalAngleRange;

		// Token: 0x0400E1F8 RID: 57848
		internal static int __PropertyOffset_LerpGISetting;

		// Token: 0x0400E1F9 RID: 57849
		private FKuroGISetting _LerpGISetting;

		// Token: 0x0400E1FA RID: 57850
		internal static int __PropertyOffset_TempGISetting;

		// Token: 0x0400E1FB RID: 57851
		private FKuroGISetting _TempGISetting;

		// Token: 0x0400E1FC RID: 57852
		internal static int __PropertyOffset_LerpPostProcessSetting;

		// Token: 0x0400E1FD RID: 57853
		private FPostProcessSettings _LerpPostProcessSetting;

		// Token: 0x0400E1FE RID: 57854
		internal static int __PropertyOffset_bContrlTODTime;

		// Token: 0x0400E1FF RID: 57855
		internal static int __PropertyOffset_bSeqControlClouds;

		// Token: 0x0400E200 RID: 57856
		internal static int __PropertyOffset_CurTimeAfterLerp;

		// Token: 0x0400E201 RID: 57857
		internal static int __PropertyOffset_LerpSunHorizonAngle;

		// Token: 0x0400E202 RID: 57858
		internal static int __PropertyOffset_LerpSunVerticalAngle;

		// Token: 0x0400E203 RID: 57859
		internal static int __PropertyOffset_GlobalWindSpeed;

		// Token: 0x0400E204 RID: 57860
		internal static int __PropertyOffset_GlobalWindSpeedWithoutTimeDilation;

		// Token: 0x0400E205 RID: 57861
		internal static int __PropertyOffset_GlobalWindPower;

		// Token: 0x0400E206 RID: 57862
		internal static int __PropertyOffset_GlobalTimeDilation;

		// Token: 0x0400E207 RID: 57863
		internal static int __PropertyOffset_GlobalWindForwardDrection;

		// Token: 0x0400E208 RID: 57864
		internal static int __PropertyOffset_WindTextureOffset;

		// Token: 0x0400E209 RID: 57865
		internal static int __PropertyOffset_bIsDayTime;

		// Token: 0x0400E20A RID: 57866
		internal static int __PropertyOffset_bDayNightEmssiveFactor;

		// Token: 0x0400E20B RID: 57867
		internal static int __PropertyOffset_DayNightEmssiveSmoothFactor;

		// Token: 0x0400E20C RID: 57868
		internal static int __PropertyOffset_TODNightLightLoadingTime;

		// Token: 0x0400E20D RID: 57869
		internal static int __PropertyOffset_TODDayLightLoadingTime;

		// Token: 0x0400E20E RID: 57870
		internal static int __PropertyOffset_TODEmssiveCloseLerpFade;

		// Token: 0x0400E20F RID: 57871
		internal static int __PropertyOffset_NowGlobalLightIntensity;

		// Token: 0x0400E210 RID: 57872
		internal static int __PropertyOffset_bRainAffectPointLight;

		// Token: 0x0400E211 RID: 57873
		internal static int __PropertyOffset_CharLightHorizontal;

		// Token: 0x0400E212 RID: 57874
		internal static int __PropertyOffset_CharDebugLightDirection;

		// Token: 0x0400E213 RID: 57875
		internal static int __PropertyOffset_CharDebugLightDirectionZero;

		// Token: 0x0400E214 RID: 57876
		internal static int __PropertyOffset_AtmosphereSunRotation;

		// Token: 0x0400E215 RID: 57877
		internal static int __PropertyOffset_AtmosphereSunForward;

		// Token: 0x0400E216 RID: 57878
		internal static int __PropertyOffset_AtmosphereMoonRotation;

		// Token: 0x0400E217 RID: 57879
		internal static int __PropertyOffset_AtmosphereMoonForward;

		// Token: 0x0400E218 RID: 57880
		internal static int __PropertyOffset_KuroViewCenterPlayerIndex;

		// Token: 0x0400E219 RID: 57881
		internal static int __PropertyOffset_KuroViewCenterHeightOffset;

		// Token: 0x0400E21A RID: 57882
		internal static int __PropertyOffset_bEnableCustomKuroViewCenter;

		// Token: 0x0400E21B RID: 57883
		internal static int __PropertyOffset_CustomKuroViewCenter;

		// Token: 0x0400E21C RID: 57884
		internal static int __PropertyOffset_CurrentKuroViewCenter;

		// Token: 0x0400E21D RID: 57885
		internal static int __PropertyOffset_KuroTrailSystemEnable;

		// Token: 0x0400E21E RID: 57886
		internal static int __PropertyOffset_KuroTrailNoiseTexutre;

		// Token: 0x0400E21F RID: 57887
		internal static int __PropertyOffset_UpdatePostProcessDataThreshold;

		// Token: 0x0400E220 RID: 57888
		internal static int __PropertyOffset_KuroSkyLightCubemap1;

		// Token: 0x0400E221 RID: 57889
		internal static int __PropertyOffset_KuroSkyLightCubemap2;

		// Token: 0x0400E222 RID: 57890
		internal static int __PropertyOffset_KuroSkyLightCubemap3;

		// Token: 0x0400E223 RID: 57891
		internal static int __PropertyOffset_KuroCubemapBlend12;

		// Token: 0x0400E224 RID: 57892
		internal static int __PropertyOffset_KuroCubemapBlend23;

		// Token: 0x0400E225 RID: 57893
		internal static int __PropertyOffset_KuroGlobalGIIndex;

		// Token: 0x0400E226 RID: 57894
		internal static int __PropertyOffset_GIID;

		// Token: 0x0400E227 RID: 57895
		internal static int __PropertyOffset_IsKuroInit;

		// Token: 0x0400E228 RID: 57896
		internal static int __PropertyOffset_GIMPC;

		// Token: 0x0400E229 RID: 57897
		internal static int __PropertyOffset_FogTime;

		// Token: 0x0400E22A RID: 57898
		private FKuroCurveFloat _FogTime;

		// Token: 0x0400E22B RID: 57899
		internal static int __PropertyOffset_ClusteredStuffTransientActors;

		// Token: 0x0400E22C RID: 57900
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1
		})]
		private TMap<UClusteredStuffDataAsset, TWeakObjectPtr<AKuroRuntimeTransientActor>> _ClusteredStuffTransientActors;

		// Token: 0x0400E22D RID: 57901
		internal static int __PropertyOffset_ClusteredStuffActive;

		// Token: 0x0400E22E RID: 57902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClusteredStuffDataAsset> _ClusteredStuffActive;

		// Token: 0x0400E22F RID: 57903
		internal static int __PropertyOffset_AdditionalClusteredStuff;

		// Token: 0x0400E230 RID: 57904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClusteredStuffDataAsset> _AdditionalClusteredStuff;

		// Token: 0x0400E231 RID: 57905
		internal static int __PropertyOffset_DefaultAutoGrassData;

		// Token: 0x0400E232 RID: 57906
		internal static int __PropertyOffset_DefaultSunLensflareConfig;

		// Token: 0x0400E233 RID: 57907
		internal static int __PropertyOffset_StarsMat;

		// Token: 0x0400E234 RID: 57908
		internal static int __PropertyOffset_MilkyWayMat;

		// Token: 0x0400E235 RID: 57909
		internal static int __PropertyOffset_SkyBoxMat;

		// Token: 0x0400E236 RID: 57910
		internal static int __PropertyOffset_bPlayerInCave;

		// Token: 0x0400E237 RID: 57911
		internal static int __PropertyOffset_bPlayerInGrass;

		// Token: 0x0400E238 RID: 57912
		internal static int __PropertyOffset_bForbidWeather;

		// Token: 0x0400E239 RID: 57913
		internal static int __PropertyOffset_GlobalPointCloudStreamingConfig;

		// Token: 0x0400E23A RID: 57914
		internal static int __PropertyOffset_GlobalPointCloudStreamingDistance;

		// Token: 0x0400E23B RID: 57915
		internal static int __PropertyOffset_TODDataAsset;

		// Token: 0x0400E23C RID: 57916
		internal static int __PropertyOffset_CachedGISystem;

		// Token: 0x0400E23D RID: 57917
		internal static int __PropertyOffset_LightFunctionMaterialDynamic;

		// Token: 0x0400E23E RID: 57918
		internal static int __PropertyOffset_LightFunctionMIPerformance;

		// Token: 0x0400E23F RID: 57919
		internal static int __PropertyOffset_LightFunctionMIDefault;

		// Token: 0x0400E240 RID: 57920
		internal static int __PropertyOffset_VolumetricLightFunctionMI;

		// Token: 0x0400E241 RID: 57921
		internal static int __PropertyOffset_LastFrameGlobalFootstepMaterial;

		// Token: 0x0400E242 RID: 57922
		internal static int __PropertyOffset_FinalRoughnessDensity;

		// Token: 0x0400E243 RID: 57923
		internal static int __PropertyOffset_FinalRainDensityValue;

		// Token: 0x0400E244 RID: 57924
		internal static int __PropertyOffset_FinalSnowCoverIntensityValue;

		// Token: 0x0400E245 RID: 57925
		internal static int __PropertyOffset_FinalRainGravityValue;

		// Token: 0x0400E246 RID: 57926
		internal static int __PropertyOffset_RainGravityStepSpeed;

		// Token: 0x0400E247 RID: 57927
		internal static int __PropertyOffset_TargetLightFunctionMap_Texture;

		// Token: 0x0400E248 RID: 57928
		internal static int __PropertyOffset_FinalLightFunctionMap_Texture;

		// Token: 0x0400E249 RID: 57929
		internal static int __PropertyOffset_TargetLightFunctionPerShadowMap_Texture;

		// Token: 0x0400E24A RID: 57930
		internal static int __PropertyOffset_FinalLightFunctionPerShadowMap_Texture;

		// Token: 0x0400E24B RID: 57931
		internal static int __PropertyOffset_TargetMilkyWayTexture;

		// Token: 0x0400E24C RID: 57932
		internal static int __PropertyOffset_FinalMilkyWayTexture;

		// Token: 0x0400E24D RID: 57933
		internal static int __PropertyOffset_TargetMilkyWayDistortionTexture;

		// Token: 0x0400E24E RID: 57934
		internal static int __PropertyOffset_FinalMilkyWayDistortionTexture;

		// Token: 0x0400E24F RID: 57935
		internal static int __PropertyOffset_TargetMilkyWayStarTexture;

		// Token: 0x0400E250 RID: 57936
		internal static int __PropertyOffset_FinalMilkyWayStarTexture;

		// Token: 0x0400E251 RID: 57937
		internal static int __PropertyOffset_AtmosphereSunLight;

		// Token: 0x0400E252 RID: 57938
		internal static int __PropertyOffset_AtmosphereMoonLight;

		// Token: 0x0400E253 RID: 57939
		internal static int __PropertyOffset_bDisableWeatherTemporalLerp;

		// Token: 0x0400E254 RID: 57940
		internal static int __PropertyOffset_PostProcessCustomTags;

		// Token: 0x0400E255 RID: 57941
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroGICustomTag> _PostProcessCustomTags;

		// Token: 0x02003142 RID: 12610
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x04016F52 RID: 94034
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003143 RID: 12611
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x04016F53 RID: 94035
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003144 RID: 12612
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x04016F54 RID: 94036
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04016F55 RID: 94037
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}

		// Token: 0x02003145 RID: 12613
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnKuroStartUI_FunctionParams
		{
			// Token: 0x04016F56 RID: 94038
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04016F57 RID: 94039
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}

		// Token: 0x02003146 RID: 12614
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x04016F58 RID: 94040
			[FieldOffset(0)]
			public float CurrentTime;
		}
	}
}
