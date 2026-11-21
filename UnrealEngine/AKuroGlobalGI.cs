using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CB RID: 1227
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI")]
	[UnrealStructLayout(16176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16176)]
	public class AKuroGlobalGI : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007158 RID: 29016 RVA: 0x000A7145 File Offset: 0x000A5345
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGlobalGI._ClassPtr;
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x000A7154 File Offset: 0x000A5354
		public AKuroGlobalGI() : this(BuiltinUtils.AllocNativeUObject(AKuroGlobalGI.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x000A717C File Offset: 0x000A537C
		[NullableContext(1)]
		public AKuroGlobalGI(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGlobalGI.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x0600715B RID: 29019 RVA: 0x000A71AF File Offset: 0x000A53AF
		// (set) Token: 0x0600715C RID: 29020 RVA: 0x000A71BF File Offset: 0x000A53BF
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

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x0600715D RID: 29021 RVA: 0x000A71D0 File Offset: 0x000A53D0
		// (set) Token: 0x0600715E RID: 29022 RVA: 0x000A71E0 File Offset: 0x000A53E0
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

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x000A71F1 File Offset: 0x000A53F1
		// (set) Token: 0x06007160 RID: 29024 RVA: 0x000A7201 File Offset: 0x000A5401
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

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06007161 RID: 29025 RVA: 0x000A7212 File Offset: 0x000A5412
		// (set) Token: 0x06007162 RID: 29026 RVA: 0x000A7222 File Offset: 0x000A5422
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

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06007163 RID: 29027 RVA: 0x000A7233 File Offset: 0x000A5433
		// (set) Token: 0x06007164 RID: 29028 RVA: 0x000A7247 File Offset: 0x000A5447
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

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06007165 RID: 29029 RVA: 0x000A725C File Offset: 0x000A545C
		// (set) Token: 0x06007166 RID: 29030 RVA: 0x000A726C File Offset: 0x000A546C
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

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x000A727D File Offset: 0x000A547D
		// (set) Token: 0x06007168 RID: 29032 RVA: 0x000A728D File Offset: 0x000A548D
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

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06007169 RID: 29033 RVA: 0x000A729E File Offset: 0x000A549E
		// (set) Token: 0x0600716A RID: 29034 RVA: 0x000A72AE File Offset: 0x000A54AE
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

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x000A72BF File Offset: 0x000A54BF
		// (set) Token: 0x0600716C RID: 29036 RVA: 0x000A72CF File Offset: 0x000A54CF
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

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x000A72E0 File Offset: 0x000A54E0
		// (set) Token: 0x0600716E RID: 29038 RVA: 0x000A72F0 File Offset: 0x000A54F0
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

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x000A7301 File Offset: 0x000A5501
		// (set) Token: 0x06007170 RID: 29040 RVA: 0x000A7311 File Offset: 0x000A5511
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

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06007171 RID: 29041 RVA: 0x000A7322 File Offset: 0x000A5522
		// (set) Token: 0x06007172 RID: 29042 RVA: 0x000A7332 File Offset: 0x000A5532
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

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06007173 RID: 29043 RVA: 0x000A7343 File Offset: 0x000A5543
		// (set) Token: 0x06007174 RID: 29044 RVA: 0x000A7353 File Offset: 0x000A5553
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

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06007175 RID: 29045 RVA: 0x000A7364 File Offset: 0x000A5564
		// (set) Token: 0x06007176 RID: 29046 RVA: 0x000A7378 File Offset: 0x000A5578
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

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06007177 RID: 29047 RVA: 0x000A7390 File Offset: 0x000A5590
		// (set) Token: 0x06007178 RID: 29048 RVA: 0x000A73C9 File Offset: 0x000A55C9
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

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x000A73EA File Offset: 0x000A55EA
		// (set) Token: 0x0600717A RID: 29050 RVA: 0x000A73FA File Offset: 0x000A55FA
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

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x0600717B RID: 29051 RVA: 0x000A740B File Offset: 0x000A560B
		// (set) Token: 0x0600717C RID: 29052 RVA: 0x000A741B File Offset: 0x000A561B
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

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x000A742C File Offset: 0x000A562C
		// (set) Token: 0x0600717E RID: 29054 RVA: 0x000A743C File Offset: 0x000A563C
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

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x0600717F RID: 29055 RVA: 0x000A744D File Offset: 0x000A564D
		// (set) Token: 0x06007180 RID: 29056 RVA: 0x000A745D File Offset: 0x000A565D
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

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x000A746E File Offset: 0x000A566E
		// (set) Token: 0x06007182 RID: 29058 RVA: 0x000A747E File Offset: 0x000A567E
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

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06007183 RID: 29059 RVA: 0x000A748F File Offset: 0x000A568F
		// (set) Token: 0x06007184 RID: 29060 RVA: 0x000A749F File Offset: 0x000A569F
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

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x000A74B0 File Offset: 0x000A56B0
		// (set) Token: 0x06007186 RID: 29062 RVA: 0x000A74C0 File Offset: 0x000A56C0
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

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06007187 RID: 29063 RVA: 0x000A74D1 File Offset: 0x000A56D1
		// (set) Token: 0x06007188 RID: 29064 RVA: 0x000A74E1 File Offset: 0x000A56E1
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

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x000A74F2 File Offset: 0x000A56F2
		// (set) Token: 0x0600718A RID: 29066 RVA: 0x000A7502 File Offset: 0x000A5702
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

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x000A7513 File Offset: 0x000A5713
		// (set) Token: 0x0600718C RID: 29068 RVA: 0x000A7527 File Offset: 0x000A5727
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

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0600718D RID: 29069 RVA: 0x000A753C File Offset: 0x000A573C
		// (set) Token: 0x0600718E RID: 29070 RVA: 0x000A7550 File Offset: 0x000A5750
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

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600718F RID: 29071 RVA: 0x000A7565 File Offset: 0x000A5765
		// (set) Token: 0x06007190 RID: 29072 RVA: 0x000A7575 File Offset: 0x000A5775
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

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x000A7586 File Offset: 0x000A5786
		// (set) Token: 0x06007192 RID: 29074 RVA: 0x000A7596 File Offset: 0x000A5796
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

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x000A75A7 File Offset: 0x000A57A7
		// (set) Token: 0x06007194 RID: 29076 RVA: 0x000A75B7 File Offset: 0x000A57B7
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

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x000A75C8 File Offset: 0x000A57C8
		// (set) Token: 0x06007196 RID: 29078 RVA: 0x000A75D8 File Offset: 0x000A57D8
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

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x000A75E9 File Offset: 0x000A57E9
		// (set) Token: 0x06007198 RID: 29080 RVA: 0x000A75F9 File Offset: 0x000A57F9
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

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x000A760A File Offset: 0x000A580A
		// (set) Token: 0x0600719A RID: 29082 RVA: 0x000A761A File Offset: 0x000A581A
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

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0600719B RID: 29083 RVA: 0x000A762B File Offset: 0x000A582B
		// (set) Token: 0x0600719C RID: 29084 RVA: 0x000A763B File Offset: 0x000A583B
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

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x000A764C File Offset: 0x000A584C
		// (set) Token: 0x0600719E RID: 29086 RVA: 0x000A765C File Offset: 0x000A585C
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

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x000A766D File Offset: 0x000A586D
		// (set) Token: 0x060071A0 RID: 29088 RVA: 0x000A767D File Offset: 0x000A587D
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

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x000A768E File Offset: 0x000A588E
		// (set) Token: 0x060071A2 RID: 29090 RVA: 0x000A76A2 File Offset: 0x000A58A2
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

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x000A76B7 File Offset: 0x000A58B7
		// (set) Token: 0x060071A4 RID: 29092 RVA: 0x000A76CB File Offset: 0x000A58CB
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

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x000A76E0 File Offset: 0x000A58E0
		// (set) Token: 0x060071A6 RID: 29094 RVA: 0x000A76F4 File Offset: 0x000A58F4
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

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x000A7709 File Offset: 0x000A5909
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x000A771D File Offset: 0x000A591D
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

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x000A7732 File Offset: 0x000A5932
		// (set) Token: 0x060071AA RID: 29098 RVA: 0x000A7746 File Offset: 0x000A5946
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x000A775B File Offset: 0x000A595B
		// (set) Token: 0x060071AC RID: 29100 RVA: 0x000A776F File Offset: 0x000A596F
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

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x000A7784 File Offset: 0x000A5984
		// (set) Token: 0x060071AE RID: 29102 RVA: 0x000A7794 File Offset: 0x000A5994
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x000A77A5 File Offset: 0x000A59A5
		// (set) Token: 0x060071B0 RID: 29104 RVA: 0x000A77B5 File Offset: 0x000A59B5
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

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060071B1 RID: 29105 RVA: 0x000A77C6 File Offset: 0x000A59C6
		// (set) Token: 0x060071B2 RID: 29106 RVA: 0x000A77D6 File Offset: 0x000A59D6
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

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060071B3 RID: 29107 RVA: 0x000A77E7 File Offset: 0x000A59E7
		// (set) Token: 0x060071B4 RID: 29108 RVA: 0x000A77FB File Offset: 0x000A59FB
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

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x000A7810 File Offset: 0x000A5A10
		// (set) Token: 0x060071B6 RID: 29110 RVA: 0x000A7824 File Offset: 0x000A5A24
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x000A7839 File Offset: 0x000A5A39
		// (set) Token: 0x060071B8 RID: 29112 RVA: 0x000A7849 File Offset: 0x000A5A49
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

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060071B9 RID: 29113 RVA: 0x000A785A File Offset: 0x000A5A5A
		// (set) Token: 0x060071BA RID: 29114 RVA: 0x000A786E File Offset: 0x000A5A6E
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x000A7883 File Offset: 0x000A5A83
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x000A7893 File Offset: 0x000A5A93
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

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x000A78A4 File Offset: 0x000A5AA4
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x000A78B8 File Offset: 0x000A5AB8
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

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x000A78CD File Offset: 0x000A5ACD
		// (set) Token: 0x060071C0 RID: 29120 RVA: 0x000A78E1 File Offset: 0x000A5AE1
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

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x000A78F6 File Offset: 0x000A5AF6
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x000A790A File Offset: 0x000A5B0A
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

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x000A791F File Offset: 0x000A5B1F
		// (set) Token: 0x060071C4 RID: 29124 RVA: 0x000A792F File Offset: 0x000A5B2F
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

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x000A7940 File Offset: 0x000A5B40
		// (set) Token: 0x060071C6 RID: 29126 RVA: 0x000A7950 File Offset: 0x000A5B50
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

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x000A7961 File Offset: 0x000A5B61
		// (set) Token: 0x060071C8 RID: 29128 RVA: 0x000A7971 File Offset: 0x000A5B71
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

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x000A7982 File Offset: 0x000A5B82
		// (set) Token: 0x060071CA RID: 29130 RVA: 0x000A7992 File Offset: 0x000A5B92
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x000A79A3 File Offset: 0x000A5BA3
		// (set) Token: 0x060071CC RID: 29132 RVA: 0x000A79B3 File Offset: 0x000A5BB3
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

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060071CD RID: 29133 RVA: 0x000A79C4 File Offset: 0x000A5BC4
		// (set) Token: 0x060071CE RID: 29134 RVA: 0x000A79D8 File Offset: 0x000A5BD8
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

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x000A79F0 File Offset: 0x000A5BF0
		// (set) Token: 0x060071D0 RID: 29136 RVA: 0x000A7A29 File Offset: 0x000A5C29
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

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060071D1 RID: 29137 RVA: 0x000A7A4A File Offset: 0x000A5C4A
		// (set) Token: 0x060071D2 RID: 29138 RVA: 0x000A7A5E File Offset: 0x000A5C5E
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

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x000A7A73 File Offset: 0x000A5C73
		// (set) Token: 0x060071D4 RID: 29140 RVA: 0x000A7A87 File Offset: 0x000A5C87
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

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x000A7A9C File Offset: 0x000A5C9C
		// (set) Token: 0x060071D6 RID: 29142 RVA: 0x000A7AB0 File Offset: 0x000A5CB0
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

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x000A7AC5 File Offset: 0x000A5CC5
		// (set) Token: 0x060071D8 RID: 29144 RVA: 0x000A7AD9 File Offset: 0x000A5CD9
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x000A7AEE File Offset: 0x000A5CEE
		// (set) Token: 0x060071DA RID: 29146 RVA: 0x000A7AFE File Offset: 0x000A5CFE
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

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x000A7B0F File Offset: 0x000A5D0F
		// (set) Token: 0x060071DC RID: 29148 RVA: 0x000A7B1F File Offset: 0x000A5D1F
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

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x000A7B30 File Offset: 0x000A5D30
		// (set) Token: 0x060071DE RID: 29150 RVA: 0x000A7B40 File Offset: 0x000A5D40
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

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x000A7B51 File Offset: 0x000A5D51
		// (set) Token: 0x060071E0 RID: 29152 RVA: 0x000A7B61 File Offset: 0x000A5D61
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

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x000A7B72 File Offset: 0x000A5D72
		// (set) Token: 0x060071E2 RID: 29154 RVA: 0x000A7B86 File Offset: 0x000A5D86
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

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x060071E3 RID: 29155 RVA: 0x000A7B9B File Offset: 0x000A5D9B
		// (set) Token: 0x060071E4 RID: 29156 RVA: 0x000A7BAF File Offset: 0x000A5DAF
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

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x000A7BC4 File Offset: 0x000A5DC4
		// (set) Token: 0x060071E6 RID: 29158 RVA: 0x000A7BD8 File Offset: 0x000A5DD8
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

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x000A7BED File Offset: 0x000A5DED
		// (set) Token: 0x060071E8 RID: 29160 RVA: 0x000A7C01 File Offset: 0x000A5E01
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

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x000A7C16 File Offset: 0x000A5E16
		// (set) Token: 0x060071EA RID: 29162 RVA: 0x000A7C2A File Offset: 0x000A5E2A
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

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x000A7C3F File Offset: 0x000A5E3F
		// (set) Token: 0x060071EC RID: 29164 RVA: 0x000A7C53 File Offset: 0x000A5E53
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

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x000A7C68 File Offset: 0x000A5E68
		// (set) Token: 0x060071EE RID: 29166 RVA: 0x000A7C7C File Offset: 0x000A5E7C
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

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x000A7C91 File Offset: 0x000A5E91
		// (set) Token: 0x060071F0 RID: 29168 RVA: 0x000A7CA1 File Offset: 0x000A5EA1
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

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x060071F1 RID: 29169 RVA: 0x000A7CB2 File Offset: 0x000A5EB2
		// (set) Token: 0x060071F2 RID: 29170 RVA: 0x000A7CC2 File Offset: 0x000A5EC2
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

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x000A7CD3 File Offset: 0x000A5ED3
		// (set) Token: 0x060071F4 RID: 29172 RVA: 0x000A7CE3 File Offset: 0x000A5EE3
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

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x000A7CF4 File Offset: 0x000A5EF4
		// (set) Token: 0x060071F6 RID: 29174 RVA: 0x000A7D04 File Offset: 0x000A5F04
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x000A7D15 File Offset: 0x000A5F15
		// (set) Token: 0x060071F8 RID: 29176 RVA: 0x000A7D25 File Offset: 0x000A5F25
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

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x060071F9 RID: 29177 RVA: 0x000A7D36 File Offset: 0x000A5F36
		// (set) Token: 0x060071FA RID: 29178 RVA: 0x000A7D4A File Offset: 0x000A5F4A
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

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x060071FB RID: 29179 RVA: 0x000A7D5F File Offset: 0x000A5F5F
		// (set) Token: 0x060071FC RID: 29180 RVA: 0x000A7D73 File Offset: 0x000A5F73
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

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x000A7D88 File Offset: 0x000A5F88
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x000A7D9C File Offset: 0x000A5F9C
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

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x000A7DB1 File Offset: 0x000A5FB1
		// (set) Token: 0x06007200 RID: 29184 RVA: 0x000A7DC5 File Offset: 0x000A5FC5
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

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x000A7DDA File Offset: 0x000A5FDA
		// (set) Token: 0x06007202 RID: 29186 RVA: 0x000A7DEE File Offset: 0x000A5FEE
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

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x000A7E03 File Offset: 0x000A6003
		// (set) Token: 0x06007204 RID: 29188 RVA: 0x000A7E17 File Offset: 0x000A6017
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

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x000A7E2C File Offset: 0x000A602C
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x000A7E40 File Offset: 0x000A6040
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

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x000A7E55 File Offset: 0x000A6055
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x000A7E69 File Offset: 0x000A6069
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

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x000A7E7E File Offset: 0x000A607E
		// (set) Token: 0x0600720A RID: 29194 RVA: 0x000A7E92 File Offset: 0x000A6092
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

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x000A7EA7 File Offset: 0x000A60A7
		// (set) Token: 0x0600720C RID: 29196 RVA: 0x000A7EBB File Offset: 0x000A60BB
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

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x000A7ED0 File Offset: 0x000A60D0
		// (set) Token: 0x0600720E RID: 29198 RVA: 0x000A7EE0 File Offset: 0x000A60E0
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

		// Token: 0x0600720F RID: 29199 RVA: 0x000A7EF1 File Offset: 0x000A60F1
		public void UpdateTODData(UObject WorldContextObject, FVector WorldPosition, float TimeSecnod)
		{
			AKuroGlobalGI.__UpdateTODData_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, TimeSecnod);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x000A7F10 File Offset: 0x000A6110
		public void UpdatePostProcessSettingData(UObject WorldContextObject, float CurTime, bool bSkipLerpData = false, bool bEnableLumen = false)
		{
			AKuroGlobalGI.__UpdatePostProcessSettingData_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CurTime, bSkipLerpData, bEnableLumen);
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x000A7F31 File Offset: 0x000A6131
		public void UpdateKuroTrailSystem(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateKuroTrailSystem_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x000A7F5E File Offset: 0x000A615E
		public void UpdateCharPosition(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateCharPosition_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x000A7F8B File Offset: 0x000A618B
		public void UpdateCharLightHorizontal(UObject WorldContextObject, in FRotator SceneLightRot, UMaterialParameterCollection Collection, bool bDebugCharLightHorizontal = false, float DebugCharLightHorizontal = 0f, float DebugCharLightVertical = 0f)
		{
			AKuroGlobalGI.__UpdateCharLightHorizontal_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, SceneLightRot, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, bDebugCharLightHorizontal, DebugCharLightHorizontal, DebugCharLightVertical);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x000A7FBF File Offset: 0x000A61BF
		public void UpdateAndApplyWind(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__UpdateAndApplyWind_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x000A7FEC File Offset: 0x000A61EC
		public void UpdateAndApplyWeather()
		{
			AKuroGlobalGI.__UpdateAndApplyWeather_Internal(base.NativePtr);
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x000A7FF9 File Offset: 0x000A61F9
		public void TickWeatherTransitionData(float DeltaTime)
		{
			AKuroGlobalGI.__TickWeatherTransitionData_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x000A8007 File Offset: 0x000A6207
		public void SetSunLensflareEnabled(bool bEnable)
		{
			AKuroGlobalGI.__SetSunLensflareEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x000A8015 File Offset: 0x000A6215
		public void SetGlobalTimeDilation(float TimeDilation)
		{
			AKuroGlobalGI.__SetGlobalTimeDilation_Internal(base.NativePtr, TimeDilation);
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x000A8023 File Offset: 0x000A6223
		public void SetGITime(float Time)
		{
			AKuroGlobalGI.__SetGITime_Internal(base.NativePtr, Time);
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x000A8031 File Offset: 0x000A6231
		public virtual void OnPostProcessCustomTagsUpdated()
		{
			AKuroGlobalGI.__OnPostProcessCustomTagsUpdated_Internal(base.NativePtr);
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x000A803E File Offset: 0x000A623E
		public virtual void OnKuroTickEditor(float DeltaTime)
		{
			AKuroGlobalGI.__OnKuroTickEditor_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x000A804C File Offset: 0x000A624C
		public virtual void OnKuroTick(float DeltaTime)
		{
			AKuroGlobalGI.__OnKuroTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x000A805C File Offset: 0x000A625C
		[NullableContext(1)]
		public unsafe virtual void OnKuroStartUiScene(string InName, [Nullable(2)] ULevel InUILevel)
		{
			FString fstring = FString.AllocTemp(InName);
			AKuroGlobalGI.__OnKuroStartUiScene_Internal(base.NativePtr, fstring, (InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x000A8098 File Offset: 0x000A6298
		[NullableContext(1)]
		public unsafe virtual void OnKuroStartUI(string InName, [Nullable(2)] ULevel InUILevel)
		{
			FString fstring = FString.AllocTemp(InName);
			AKuroGlobalGI.__OnKuroStartUI_Internal(base.NativePtr, fstring, (InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x000A80D2 File Offset: 0x000A62D2
		public virtual void OnKuroSetRuntimeTime(float CurrentTime)
		{
			AKuroGlobalGI.__OnKuroSetRuntimeTime_Internal(base.NativePtr, CurrentTime);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x000A80E0 File Offset: 0x000A62E0
		public virtual void OnKuroRuntimeDestroy()
		{
			AKuroGlobalGI.__OnKuroRuntimeDestroy_Internal(base.NativePtr);
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x000A80ED File Offset: 0x000A62ED
		public virtual void OnKuroInit()
		{
			AKuroGlobalGI.__OnKuroInit_Internal(base.NativePtr);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x000A80FA File Offset: 0x000A62FA
		public virtual void OnKuroEndUiScene()
		{
			AKuroGlobalGI.__OnKuroEndUiScene_Internal(base.NativePtr);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x000A8107 File Offset: 0x000A6307
		public virtual void OnKuroEndUI()
		{
			AKuroGlobalGI.__OnKuroEndUI_Internal(base.NativePtr);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x000A8114 File Offset: 0x000A6314
		public bool K2_IsInPersistentLevel()
		{
			return AKuroGlobalGI.__K2_IsInPersistentLevel_Internal(base.NativePtr);
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x000A8121 File Offset: 0x000A6321
		public float GetPostProcessVolumeWeight(AKuroPostProcessVolume InPostProcessVolume)
		{
			return AKuroGlobalGI.__GetPostProcessVolumeWeight_Internal(base.NativePtr, (InPostProcessVolume != null) ? InPostProcessVolume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x000A813E File Offset: 0x000A633E
		public float GetGITime()
		{
			return AKuroGlobalGI.__GetGITime_Internal(base.NativePtr);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x000A814B File Offset: 0x000A634B
		public UKuroGISystem GetCachedGISystem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGISystem>(AKuroGlobalGI.__GetCachedGISystem_Internal(base.NativePtr));
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x000A815D File Offset: 0x000A635D
		public void ClearLensflare()
		{
			AKuroGlobalGI.__ClearLensflare_Internal(base.NativePtr);
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x000A816C File Offset: 0x000A636C
		public unsafe void CalLightDirectionWithLimit(float Time, float LightAngleLimit, ref FRotator LightRotation)
		{
			fixed (FRotator* ptr = &LightRotation)
			{
				void* ptr2 = (void*)ptr;
				AKuroGlobalGI.__CalLightDirectionWithLimit_Internal(base.NativePtr, Time, LightAngleLimit, ref LightRotation);
			}
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x000A818F File Offset: 0x000A638F
		public float CalcTODTimeFactor(float StartTime, float EndTime, float CurrTime)
		{
			return AKuroGlobalGI.__CalcTODTimeFactor_Internal(base.NativePtr, StartTime, EndTime, CurrTime);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x000A819F File Offset: 0x000A639F
		public static void BindEventGlobalFootstepMaterialUpdate(FOnGlobalFootstepMaterialUpdateDelegate InDelegate)
		{
			AKuroGlobalGI.__BindEventGlobalFootstepMaterialUpdate_Internal((InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x000A81B3 File Offset: 0x000A63B3
		public static void BindEventForbidWeatherStateChanged(FOnForbidWeatherStateChangedDelegate InDelegate)
		{
			AKuroGlobalGI.__BindEventForbidWeatherStateChanged_Internal((InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x000A81C7 File Offset: 0x000A63C7
		public void ApplyStarsParameters(UMaterialInstance StarMaterial, UStaticMeshComponent StarMeshComponent, float Time, UMaterialInstance StarMaterial_V2)
		{
			AKuroGlobalGI.__ApplyStarsParameters_Internal(base.NativePtr, (StarMaterial != null) ? StarMaterial.NativePtr : IntPtr.Zero, (StarMeshComponent != null) ? StarMeshComponent.NativePtr : IntPtr.Zero, Time, (StarMaterial_V2 != null) ? StarMaterial_V2.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x000A8207 File Offset: 0x000A6407
		public void ApplySkyVolumetricCloudMPC(UMaterialParameterCollection MPC)
		{
			AKuroGlobalGI.__ApplySkyVolumetricCloudMPC_Internal(base.NativePtr, (MPC != null) ? MPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x000A8224 File Offset: 0x000A6424
		public void ApplySkyEffectsParameters(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplySkyEffectsParameters_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x000A8254 File Offset: 0x000A6454
		public void ApplySkyBoxSetting(UObject WorldContextObject, UMaterialParameterCollection Collection, UMaterialInstance SkyBoxMaterial, UStaticMeshComponent SkyBoxMeshComponent, float Time)
		{
			AKuroGlobalGI.__ApplySkyBoxSetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (SkyBoxMaterial != null) ? SkyBoxMaterial.NativePtr : IntPtr.Zero, (SkyBoxMeshComponent != null) ? SkyBoxMeshComponent.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x000A82B0 File Offset: 0x000A64B0
		public void ApplyMultipleLayerSkySetting(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyMultipleLayerSkySetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x000A82DD File Offset: 0x000A64DD
		public void ApplyMilkyWayParameters(UMaterialInstance MilkyWayMaterial, UStaticMeshComponent MilkyWayMeshComponent, float Time)
		{
			AKuroGlobalGI.__ApplyMilkyWayParameters_Internal(base.NativePtr, (MilkyWayMaterial != null) ? MilkyWayMaterial.NativePtr : IntPtr.Zero, (MilkyWayMeshComponent != null) ? MilkyWayMeshComponent.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x000A830B File Offset: 0x000A650B
		public void ApplyMeshBlend()
		{
			AKuroGlobalGI.__ApplyMeshBlend_Internal(base.NativePtr);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x000A8318 File Offset: 0x000A6518
		public void ApplyLensflare(float DeltaTime, in FVector SunForward, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyLensflare_Internal(base.NativePtr, DeltaTime, SunForward, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x000A8337 File Offset: 0x000A6537
		public void ApplyKuroOceanMPC(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyKuroOceanMPC_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x000A8364 File Offset: 0x000A6564
		public void ApplyGodRay(UPostProcessComponent PostProcessVolume, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyGodRay_Internal(base.NativePtr, (PostProcessVolume != null) ? PostProcessVolume.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x000A8391 File Offset: 0x000A6591
		public void ApplyGlobalShaderParameters(UObject WorldContextObject, UMaterialParameterCollection Collection)
		{
			AKuroGlobalGI.__ApplyGlobalShaderParameters_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x000A83BE File Offset: 0x000A65BE
		public void ApplyGlobalGIRenderQuality()
		{
			AKuroGlobalGI.__ApplyGlobalGIRenderQuality_Internal(base.NativePtr);
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x000A83CB File Offset: 0x000A65CB
		public void ApplyGIMPC()
		{
			AKuroGlobalGI.__ApplyGIMPC_Internal(base.NativePtr);
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x000A83D8 File Offset: 0x000A65D8
		public void ApplyExtendedMPCs()
		{
			AKuroGlobalGI.__ApplyExtendedMPCs_Internal(base.NativePtr);
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x000A83E5 File Offset: 0x000A65E5
		public void ApplyEffectMisc()
		{
			AKuroGlobalGI.__ApplyEffectMisc_Internal(base.NativePtr);
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x000A83F2 File Offset: 0x000A65F2
		public void ApplyClusteredStuff()
		{
			AKuroGlobalGI.__ApplyClusteredStuff_Internal(base.NativePtr);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x000A83FF File Offset: 0x000A65FF
		public void ApplyCloudCardSetting(UObject WorldContextObject, UMaterialParameterCollection Collection, bool bEnableLumen)
		{
			AKuroGlobalGI.__ApplyCloudCardSetting_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, bEnableLumen);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x000A842D File Offset: 0x000A662D
		public void ApplyAndUpdateDayNightDataLayer(float TimeOfDay, float TODLightLoadingWait = 5f)
		{
			AKuroGlobalGI.__ApplyAndUpdateDayNightDataLayer_Internal(base.NativePtr, TimeOfDay, TODLightLoadingWait);
		}

		// Token: 0x0600723F RID: 29247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateTODData_Internal(IntPtr @this, IntPtr WorldContextObject, FVector WorldPosition, float TimeSecnod);

		// Token: 0x06007240 RID: 29248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePostProcessSettingData_Internal(IntPtr @this, IntPtr WorldContextObject, float CurTime, bool bSkipLerpData, bool bEnableLumen);

		// Token: 0x06007241 RID: 29249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateKuroTrailSystem_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007242 RID: 29250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharPosition_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007243 RID: 29251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharLightHorizontal_Internal(IntPtr @this, IntPtr WorldContextObject, in FRotator SceneLightRot, IntPtr Collection, bool bDebugCharLightHorizontal, float DebugCharLightHorizontal, float DebugCharLightVertical);

		// Token: 0x06007244 RID: 29252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAndApplyWind_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007245 RID: 29253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAndApplyWeather_Internal(IntPtr @this);

		// Token: 0x06007246 RID: 29254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickWeatherTransitionData_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06007247 RID: 29255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSunLensflareEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06007248 RID: 29256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalTimeDilation_Internal(IntPtr @this, float TimeDilation);

		// Token: 0x06007249 RID: 29257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGITime_Internal(IntPtr @this, float Time);

		// Token: 0x0600724A RID: 29258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostProcessCustomTagsUpdated_Internal(IntPtr @this);

		// Token: 0x0600724B RID: 29259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroTickEditor_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0600724C RID: 29260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0600724D RID: 29261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroStartUiScene_Internal(IntPtr @this, in FString InName, IntPtr InUILevel);

		// Token: 0x0600724E RID: 29262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroStartUI_Internal(IntPtr @this, in FString InName, IntPtr InUILevel);

		// Token: 0x0600724F RID: 29263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroSetRuntimeTime_Internal(IntPtr @this, float CurrentTime);

		// Token: 0x06007250 RID: 29264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroRuntimeDestroy_Internal(IntPtr @this);

		// Token: 0x06007251 RID: 29265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroInit_Internal(IntPtr @this);

		// Token: 0x06007252 RID: 29266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroEndUiScene_Internal(IntPtr @this);

		// Token: 0x06007253 RID: 29267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKuroEndUI_Internal(IntPtr @this);

		// Token: 0x06007254 RID: 29268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsInPersistentLevel_Internal(IntPtr @this);

		// Token: 0x06007255 RID: 29269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPostProcessVolumeWeight_Internal(IntPtr @this, IntPtr InPostProcessVolume);

		// Token: 0x06007256 RID: 29270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGITime_Internal(IntPtr @this);

		// Token: 0x06007257 RID: 29271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCachedGISystem_Internal(IntPtr @this);

		// Token: 0x06007258 RID: 29272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearLensflare_Internal(IntPtr @this);

		// Token: 0x06007259 RID: 29273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalLightDirectionWithLimit_Internal(IntPtr @this, float Time, float LightAngleLimit, ref FRotator LightRotation);

		// Token: 0x0600725A RID: 29274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalcTODTimeFactor_Internal(IntPtr @this, float StartTime, float EndTime, float CurrTime);

		// Token: 0x0600725B RID: 29275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEventGlobalFootstepMaterialUpdate_Internal(IntPtr InDelegate);

		// Token: 0x0600725C RID: 29276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEventForbidWeatherStateChanged_Internal(IntPtr InDelegate);

		// Token: 0x0600725D RID: 29277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyStarsParameters_Internal(IntPtr @this, IntPtr StarMaterial, IntPtr StarMeshComponent, float Time, IntPtr StarMaterial_V2);

		// Token: 0x0600725E RID: 29278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyVolumetricCloudMPC_Internal(IntPtr @this, IntPtr MPC);

		// Token: 0x0600725F RID: 29279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyEffectsParameters_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007260 RID: 29280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySkyBoxSetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, IntPtr SkyBoxMaterial, IntPtr SkyBoxMeshComponent, float Time);

		// Token: 0x06007261 RID: 29281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMultipleLayerSkySetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007262 RID: 29282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMilkyWayParameters_Internal(IntPtr @this, IntPtr MilkyWayMaterial, IntPtr MilkyWayMeshComponent, float Time);

		// Token: 0x06007263 RID: 29283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMeshBlend_Internal(IntPtr @this);

		// Token: 0x06007264 RID: 29284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyLensflare_Internal(IntPtr @this, float DeltaTime, in FVector SunForward, IntPtr Collection);

		// Token: 0x06007265 RID: 29285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyKuroOceanMPC_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007266 RID: 29286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGodRay_Internal(IntPtr @this, IntPtr PostProcessVolume, IntPtr Collection);

		// Token: 0x06007267 RID: 29287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGlobalShaderParameters_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection);

		// Token: 0x06007268 RID: 29288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGlobalGIRenderQuality_Internal(IntPtr @this);

		// Token: 0x06007269 RID: 29289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGIMPC_Internal(IntPtr @this);

		// Token: 0x0600726A RID: 29290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyExtendedMPCs_Internal(IntPtr @this);

		// Token: 0x0600726B RID: 29291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEffectMisc_Internal(IntPtr @this);

		// Token: 0x0600726C RID: 29292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyClusteredStuff_Internal(IntPtr @this);

		// Token: 0x0600726D RID: 29293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyCloudCardSetting_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr Collection, bool bEnableLumen);

		// Token: 0x0600726E RID: 29294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAndUpdateDayNightDataLayer_Internal(IntPtr @this, float TimeOfDay, float TODLightLoadingWait);

		// Token: 0x0600726F RID: 29295 RVA: 0x000A843C File Offset: 0x000A663C
		static AKuroGlobalGI()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI");
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x000A844A File Offset: 0x000A664A
		protected AKuroGlobalGI(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030EA RID: 12522
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI";

		// Token: 0x040030EB RID: 12523
		private static IntPtr _ClassPtr;

		// Token: 0x040030EC RID: 12524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030ED RID: 12525
		public static IntPtr __OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040030EE RID: 12526
		public static IntPtr __OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040030EF RID: 12527
		internal static int __PropertyOffset_TickInEditor;

		// Token: 0x040030F0 RID: 12528
		internal static int __PropertyOffset_IsPersistentLevelGI;

		// Token: 0x040030F1 RID: 12529
		internal static int __PropertyOffset_bPostProcessVolumeChanged;

		// Token: 0x040030F2 RID: 12530
		internal static int __PropertyOffset_TickDeltaTime;

		// Token: 0x040030F3 RID: 12531
		internal static int __PropertyOffset_ViewLocation;

		// Token: 0x040030F4 RID: 12532
		internal static int __PropertyOffset_DisableGlobalGITransition;

		// Token: 0x040030F5 RID: 12533
		internal static int __PropertyOffset_DisableSkyBlendingSkip;

		// Token: 0x040030F6 RID: 12534
		internal static int __PropertyOffset_DisableFixedTimeState;

		// Token: 0x040030F7 RID: 12535
		internal static int __PropertyOffset_SunHorizonAngle;

		// Token: 0x040030F8 RID: 12536
		internal static int __PropertyOffset_SunVerticalAngle;

		// Token: 0x040030F9 RID: 12537
		internal static int __PropertyOffset_IsReversed;

		// Token: 0x040030FA RID: 12538
		internal static int __PropertyOffset_ReverseZCenter;

		// Token: 0x040030FB RID: 12539
		internal static int __PropertyOffset_bLockSceneLightVerticalAngle;

		// Token: 0x040030FC RID: 12540
		internal static int __PropertyOffset_SceneLightVerticalAngleRange;

		// Token: 0x040030FD RID: 12541
		internal static int __PropertyOffset_LerpPostProcessSetting;

		// Token: 0x040030FE RID: 12542
		private FPostProcessSettings _LerpPostProcessSetting;

		// Token: 0x040030FF RID: 12543
		internal static int __PropertyOffset_bContrlTODTime;

		// Token: 0x04003100 RID: 12544
		internal static int __PropertyOffset_bSeqControlClouds;

		// Token: 0x04003101 RID: 12545
		internal static int __PropertyOffset_CurTimeAfterLerp;

		// Token: 0x04003102 RID: 12546
		internal static int __PropertyOffset_LerpSunHorizonAngle;

		// Token: 0x04003103 RID: 12547
		internal static int __PropertyOffset_LerpSunVerticalAngle;

		// Token: 0x04003104 RID: 12548
		internal static int __PropertyOffset_GlobalWindSpeed;

		// Token: 0x04003105 RID: 12549
		internal static int __PropertyOffset_GlobalWindSpeedWithoutTimeDilation;

		// Token: 0x04003106 RID: 12550
		internal static int __PropertyOffset_GlobalWindPower;

		// Token: 0x04003107 RID: 12551
		internal static int __PropertyOffset_GlobalTimeDilation;

		// Token: 0x04003108 RID: 12552
		internal static int __PropertyOffset_GlobalWindForwardDrection;

		// Token: 0x04003109 RID: 12553
		internal static int __PropertyOffset_WindTextureOffset;

		// Token: 0x0400310A RID: 12554
		internal static int __PropertyOffset_bIsDayTime;

		// Token: 0x0400310B RID: 12555
		internal static int __PropertyOffset_bDayNightEmssiveFactor;

		// Token: 0x0400310C RID: 12556
		internal static int __PropertyOffset_DayNightEmssiveSmoothFactor;

		// Token: 0x0400310D RID: 12557
		internal static int __PropertyOffset_TODNightLightLoadingTime;

		// Token: 0x0400310E RID: 12558
		internal static int __PropertyOffset_TODDayLightLoadingTime;

		// Token: 0x0400310F RID: 12559
		internal static int __PropertyOffset_TODEmssiveCloseLerpFade;

		// Token: 0x04003110 RID: 12560
		internal static int __PropertyOffset_NowGlobalLightIntensity;

		// Token: 0x04003111 RID: 12561
		internal static int __PropertyOffset_bRainAffectPointLight;

		// Token: 0x04003112 RID: 12562
		internal static int __PropertyOffset_CharLightHorizontal;

		// Token: 0x04003113 RID: 12563
		internal static int __PropertyOffset_CharDebugLightDirection;

		// Token: 0x04003114 RID: 12564
		internal static int __PropertyOffset_CharDebugLightDirectionZero;

		// Token: 0x04003115 RID: 12565
		internal static int __PropertyOffset_AtmosphereSunRotation;

		// Token: 0x04003116 RID: 12566
		internal static int __PropertyOffset_AtmosphereSunForward;

		// Token: 0x04003117 RID: 12567
		internal static int __PropertyOffset_AtmosphereMoonRotation;

		// Token: 0x04003118 RID: 12568
		internal static int __PropertyOffset_AtmosphereMoonForward;

		// Token: 0x04003119 RID: 12569
		internal static int __PropertyOffset_KuroViewCenterPlayerIndex;

		// Token: 0x0400311A RID: 12570
		internal static int __PropertyOffset_KuroViewCenterHeightOffset;

		// Token: 0x0400311B RID: 12571
		internal static int __PropertyOffset_bEnableCustomKuroViewCenter;

		// Token: 0x0400311C RID: 12572
		internal static int __PropertyOffset_CustomKuroViewCenter;

		// Token: 0x0400311D RID: 12573
		internal static int __PropertyOffset_CurrentKuroViewCenter;

		// Token: 0x0400311E RID: 12574
		internal static int __PropertyOffset_KuroTrailSystemEnable;

		// Token: 0x0400311F RID: 12575
		internal static int __PropertyOffset_KuroTrailNoiseTexutre;

		// Token: 0x04003120 RID: 12576
		internal static int __PropertyOffset_UpdatePostProcessDataThreshold;

		// Token: 0x04003121 RID: 12577
		internal static int __PropertyOffset_KuroSkyLightCubemap1;

		// Token: 0x04003122 RID: 12578
		internal static int __PropertyOffset_KuroSkyLightCubemap2;

		// Token: 0x04003123 RID: 12579
		internal static int __PropertyOffset_KuroSkyLightCubemap3;

		// Token: 0x04003124 RID: 12580
		internal static int __PropertyOffset_KuroCubemapBlend12;

		// Token: 0x04003125 RID: 12581
		internal static int __PropertyOffset_KuroCubemapBlend23;

		// Token: 0x04003126 RID: 12582
		internal static int __PropertyOffset_KuroGlobalGIIndex;

		// Token: 0x04003127 RID: 12583
		internal static int __PropertyOffset_GIID;

		// Token: 0x04003128 RID: 12584
		internal static int __PropertyOffset_IsKuroInit;

		// Token: 0x04003129 RID: 12585
		internal static int __PropertyOffset_GIMPC;

		// Token: 0x0400312A RID: 12586
		internal static int __PropertyOffset_FogTime;

		// Token: 0x0400312B RID: 12587
		private FKuroCurveFloat _FogTime;

		// Token: 0x0400312C RID: 12588
		internal static int __PropertyOffset_DefaultSunLensflareConfig;

		// Token: 0x0400312D RID: 12589
		internal static int __PropertyOffset_StarsMat;

		// Token: 0x0400312E RID: 12590
		internal static int __PropertyOffset_MilkyWayMat;

		// Token: 0x0400312F RID: 12591
		internal static int __PropertyOffset_SkyBoxMat;

		// Token: 0x04003130 RID: 12592
		internal static int __PropertyOffset_bPlayerInCave;

		// Token: 0x04003131 RID: 12593
		internal static int __PropertyOffset_bPlayerInGrass;

		// Token: 0x04003132 RID: 12594
		internal static int __PropertyOffset_bForbidWeather;

		// Token: 0x04003133 RID: 12595
		internal static int __PropertyOffset_GlobalPointCloudStreamingDistance;

		// Token: 0x04003134 RID: 12596
		internal static int __PropertyOffset_TODDataAsset;

		// Token: 0x04003135 RID: 12597
		internal static int __PropertyOffset_CachedGISystem;

		// Token: 0x04003136 RID: 12598
		internal static int __PropertyOffset_LightFunctionMaterialDynamic;

		// Token: 0x04003137 RID: 12599
		internal static int __PropertyOffset_LightFunctionMIPerformance;

		// Token: 0x04003138 RID: 12600
		internal static int __PropertyOffset_LightFunctionMIDefault;

		// Token: 0x04003139 RID: 12601
		internal static int __PropertyOffset_VolumetricLightFunctionMI;

		// Token: 0x0400313A RID: 12602
		internal static int __PropertyOffset_LastFrameGlobalFootstepMaterial;

		// Token: 0x0400313B RID: 12603
		internal static int __PropertyOffset_FinalRoughnessDensity;

		// Token: 0x0400313C RID: 12604
		internal static int __PropertyOffset_FinalRainDensityValue;

		// Token: 0x0400313D RID: 12605
		internal static int __PropertyOffset_FinalSnowCoverIntensityValue;

		// Token: 0x0400313E RID: 12606
		internal static int __PropertyOffset_FinalRainGravityValue;

		// Token: 0x0400313F RID: 12607
		internal static int __PropertyOffset_RainGravityStepSpeed;

		// Token: 0x04003140 RID: 12608
		internal static int __PropertyOffset_TargetLightFunctionMap_Texture;

		// Token: 0x04003141 RID: 12609
		internal static int __PropertyOffset_FinalLightFunctionMap_Texture;

		// Token: 0x04003142 RID: 12610
		internal static int __PropertyOffset_TargetLightFunctionPerShadowMap_Texture;

		// Token: 0x04003143 RID: 12611
		internal static int __PropertyOffset_FinalLightFunctionPerShadowMap_Texture;

		// Token: 0x04003144 RID: 12612
		internal static int __PropertyOffset_TargetMilkyWayTexture;

		// Token: 0x04003145 RID: 12613
		internal static int __PropertyOffset_FinalMilkyWayTexture;

		// Token: 0x04003146 RID: 12614
		internal static int __PropertyOffset_TargetMilkyWayDistortionTexture;

		// Token: 0x04003147 RID: 12615
		internal static int __PropertyOffset_FinalMilkyWayDistortionTexture;

		// Token: 0x04003148 RID: 12616
		internal static int __PropertyOffset_TargetMilkyWayStarTexture;

		// Token: 0x04003149 RID: 12617
		internal static int __PropertyOffset_FinalMilkyWayStarTexture;

		// Token: 0x0400314A RID: 12618
		internal static int __PropertyOffset_bDisableWeatherTemporalLerp;

		// Token: 0x02000C0E RID: 3086
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x04005E43 RID: 24131
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000C0F RID: 3087
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x04005E44 RID: 24132
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000C10 RID: 3088
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x04005E45 RID: 24133
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04005E46 RID: 24134
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}

		// Token: 0x02000C11 RID: 3089
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnKuroStartUI_FunctionParams
		{
			// Token: 0x04005E47 RID: 24135
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04005E48 RID: 24136
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}

		// Token: 0x02000C12 RID: 3090
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x04005E49 RID: 24137
			[FieldOffset(0)]
			public float CurrentTime;
		}
	}
}
