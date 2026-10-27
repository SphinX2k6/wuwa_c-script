using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000868 RID: 2152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioComponent")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UAudioComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007437 RID: 29751 RVA: 0x000A6B28 File Offset: 0x000A4D28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioComponent._ClassPtr;
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x000A6B34 File Offset: 0x000A4D34
		public UAudioComponent() : this(BuiltinUtils.AllocNativeUObject(UAudioComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x000A6B5C File Offset: 0x000A4D5C
		public UAudioComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600743A RID: 29754 RVA: 0x000A6B8F File Offset: 0x000A4D8F
		// (set) Token: 0x0600743B RID: 29755 RVA: 0x000A6BA3 File Offset: 0x000A4DA3
		[Nullable(2)]
		public unsafe USoundBase Sound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_Sound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600743C RID: 29756 RVA: 0x000A6BB8 File Offset: 0x000A4DB8
		// (set) Token: 0x0600743D RID: 29757 RVA: 0x000A6BF1 File Offset: 0x000A4DF1
		public TArray<FAudioComponentParam> InstanceParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAudioComponentParam> result;
				if ((result = this._InstanceParameters) == null)
				{
					result = (this._InstanceParameters = new TArray<FAudioComponentParam>(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_InstanceParameters, this));
				}
				return result;
			}
			set
			{
				this.InstanceParameters.CopyAssign(value);
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x000A6BFF File Offset: 0x000A4DFF
		// (set) Token: 0x0600743F RID: 29759 RVA: 0x000A6C13 File Offset: 0x000A4E13
		[Nullable(2)]
		public unsafe USoundClass SoundClassOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_SoundClassOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_SoundClassOverride, value);
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06007440 RID: 29760 RVA: 0x000A6C28 File Offset: 0x000A4E28
		// (set) Token: 0x06007441 RID: 29761 RVA: 0x000A6C41 File Offset: 0x000A4E41
		public unsafe bool bAutoDestroy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoDestroy) & UAudioComponent.__PropertyMask_bAutoDestroy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoDestroy) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoDestroy) & ~UAudioComponent.__PropertyMask_bAutoDestroy) | (value ? UAudioComponent.__PropertyMask_bAutoDestroy : 0));
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x000A6C71 File Offset: 0x000A4E71
		// (set) Token: 0x06007443 RID: 29763 RVA: 0x000A6C8A File Offset: 0x000A4E8A
		public unsafe bool bStopWhenOwnerDestroyed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & UAudioComponent.__PropertyMask_bStopWhenOwnerDestroyed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bStopWhenOwnerDestroyed) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & ~UAudioComponent.__PropertyMask_bStopWhenOwnerDestroyed) | (value ? UAudioComponent.__PropertyMask_bStopWhenOwnerDestroyed : 0));
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06007444 RID: 29764 RVA: 0x000A6CBA File Offset: 0x000A4EBA
		// (set) Token: 0x06007445 RID: 29765 RVA: 0x000A6CD3 File Offset: 0x000A4ED3
		public unsafe bool bShouldRemainActiveIfDropped
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bShouldRemainActiveIfDropped) & UAudioComponent.__PropertyMask_bShouldRemainActiveIfDropped) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bShouldRemainActiveIfDropped) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bShouldRemainActiveIfDropped) & ~UAudioComponent.__PropertyMask_bShouldRemainActiveIfDropped) | (value ? UAudioComponent.__PropertyMask_bShouldRemainActiveIfDropped : 0));
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x000A6D03 File Offset: 0x000A4F03
		// (set) Token: 0x06007447 RID: 29767 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		public unsafe bool bAllowSpatialization
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAllowSpatialization) & UAudioComponent.__PropertyMask_bAllowSpatialization) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAllowSpatialization) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAllowSpatialization) & ~UAudioComponent.__PropertyMask_bAllowSpatialization) | (value ? UAudioComponent.__PropertyMask_bAllowSpatialization : 0));
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x000A6D4C File Offset: 0x000A4F4C
		// (set) Token: 0x06007449 RID: 29769 RVA: 0x000A6D65 File Offset: 0x000A4F65
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideAttenuation) & UAudioComponent.__PropertyMask_bOverrideAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideAttenuation) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideAttenuation) & ~UAudioComponent.__PropertyMask_bOverrideAttenuation) | (value ? UAudioComponent.__PropertyMask_bOverrideAttenuation : 0));
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600744A RID: 29770 RVA: 0x000A6D95 File Offset: 0x000A4F95
		// (set) Token: 0x0600744B RID: 29771 RVA: 0x000A6DAE File Offset: 0x000A4FAE
		public unsafe bool bOverrideSubtitlePriority
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideSubtitlePriority) & UAudioComponent.__PropertyMask_bOverrideSubtitlePriority) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideSubtitlePriority) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverrideSubtitlePriority) & ~UAudioComponent.__PropertyMask_bOverrideSubtitlePriority) | (value ? UAudioComponent.__PropertyMask_bOverrideSubtitlePriority : 0));
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x0600744C RID: 29772 RVA: 0x000A6DDE File Offset: 0x000A4FDE
		// (set) Token: 0x0600744D RID: 29773 RVA: 0x000A6DF7 File Offset: 0x000A4FF7
		public unsafe bool bIsUISound
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bIsUISound) & UAudioComponent.__PropertyMask_bIsUISound) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bIsUISound) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bIsUISound) & ~UAudioComponent.__PropertyMask_bIsUISound) | (value ? UAudioComponent.__PropertyMask_bIsUISound : 0));
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x000A6E27 File Offset: 0x000A5027
		// (set) Token: 0x0600744F RID: 29775 RVA: 0x000A6E40 File Offset: 0x000A5040
		public unsafe bool bEnableLowPassFilter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bEnableLowPassFilter) & UAudioComponent.__PropertyMask_bEnableLowPassFilter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bEnableLowPassFilter) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bEnableLowPassFilter) & ~UAudioComponent.__PropertyMask_bEnableLowPassFilter) | (value ? UAudioComponent.__PropertyMask_bEnableLowPassFilter : 0));
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06007450 RID: 29776 RVA: 0x000A6E70 File Offset: 0x000A5070
		// (set) Token: 0x06007451 RID: 29777 RVA: 0x000A6E89 File Offset: 0x000A5089
		public unsafe bool bOverridePriority
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverridePriority) & UAudioComponent.__PropertyMask_bOverridePriority) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverridePriority) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bOverridePriority) & ~UAudioComponent.__PropertyMask_bOverridePriority) | (value ? UAudioComponent.__PropertyMask_bOverridePriority : 0));
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x000A6EB9 File Offset: 0x000A50B9
		// (set) Token: 0x06007453 RID: 29779 RVA: 0x000A6ED2 File Offset: 0x000A50D2
		public unsafe bool bSuppressSubtitles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bSuppressSubtitles) & UAudioComponent.__PropertyMask_bSuppressSubtitles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bSuppressSubtitles) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bSuppressSubtitles) & ~UAudioComponent.__PropertyMask_bSuppressSubtitles) | (value ? UAudioComponent.__PropertyMask_bSuppressSubtitles : 0));
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x000A6F02 File Offset: 0x000A5102
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x000A6F1B File Offset: 0x000A511B
		public unsafe bool bAutoManageAttachment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoManageAttachment) & UAudioComponent.__PropertyMask_bAutoManageAttachment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoManageAttachment) = ((*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_bAutoManageAttachment) & ~UAudioComponent.__PropertyMask_bAutoManageAttachment) | (value ? UAudioComponent.__PropertyMask_bAutoManageAttachment : 0));
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x000A6F4B File Offset: 0x000A514B
		// (set) Token: 0x06007457 RID: 29783 RVA: 0x000A6F5F File Offset: 0x000A515F
		public unsafe FName AudioComponentUserID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AudioComponentUserID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AudioComponentUserID) = value;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x000A6F74 File Offset: 0x000A5174
		// (set) Token: 0x06007459 RID: 29785 RVA: 0x000A6F84 File Offset: 0x000A5184
		public unsafe float PitchModulationMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchModulationMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchModulationMin) = value;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x000A6F95 File Offset: 0x000A5195
		// (set) Token: 0x0600745B RID: 29787 RVA: 0x000A6FA5 File Offset: 0x000A51A5
		public unsafe float PitchModulationMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchModulationMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchModulationMax) = value;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600745C RID: 29788 RVA: 0x000A6FB6 File Offset: 0x000A51B6
		// (set) Token: 0x0600745D RID: 29789 RVA: 0x000A6FC6 File Offset: 0x000A51C6
		public unsafe float VolumeModulationMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeModulationMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeModulationMin) = value;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x0600745E RID: 29790 RVA: 0x000A6FD7 File Offset: 0x000A51D7
		// (set) Token: 0x0600745F RID: 29791 RVA: 0x000A6FE7 File Offset: 0x000A51E7
		public unsafe float VolumeModulationMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeModulationMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeModulationMax) = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06007460 RID: 29792 RVA: 0x000A6FF8 File Offset: 0x000A51F8
		// (set) Token: 0x06007461 RID: 29793 RVA: 0x000A7008 File Offset: 0x000A5208
		public unsafe float VolumeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_VolumeMultiplier) = value;
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06007462 RID: 29794 RVA: 0x000A7019 File Offset: 0x000A5219
		// (set) Token: 0x06007463 RID: 29795 RVA: 0x000A7029 File Offset: 0x000A5229
		public unsafe int EnvelopeFollowerAttackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_EnvelopeFollowerAttackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_EnvelopeFollowerAttackTime) = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06007464 RID: 29796 RVA: 0x000A703A File Offset: 0x000A523A
		// (set) Token: 0x06007465 RID: 29797 RVA: 0x000A704A File Offset: 0x000A524A
		public unsafe int EnvelopeFollowerReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_EnvelopeFollowerReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_EnvelopeFollowerReleaseTime) = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x000A705B File Offset: 0x000A525B
		// (set) Token: 0x06007467 RID: 29799 RVA: 0x000A706B File Offset: 0x000A526B
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x000A707C File Offset: 0x000A527C
		// (set) Token: 0x06007469 RID: 29801 RVA: 0x000A708C File Offset: 0x000A528C
		public unsafe float SubtitlePriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_SubtitlePriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_SubtitlePriority) = value;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x000A709D File Offset: 0x000A529D
		// (set) Token: 0x0600746B RID: 29803 RVA: 0x000A70B1 File Offset: 0x000A52B1
		[Nullable(2)]
		public unsafe USoundEffectSourcePresetChain SourceEffectChain
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSourcePresetChain>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_SourceEffectChain);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_SourceEffectChain, value);
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x000A70C6 File Offset: 0x000A52C6
		// (set) Token: 0x0600746D RID: 29805 RVA: 0x000A70D6 File Offset: 0x000A52D6
		public unsafe float PitchMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_PitchMultiplier) = value;
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600746E RID: 29806 RVA: 0x000A70E7 File Offset: 0x000A52E7
		// (set) Token: 0x0600746F RID: 29807 RVA: 0x000A70F7 File Offset: 0x000A52F7
		public unsafe float LowPassFilterFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_LowPassFilterFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_LowPassFilterFrequency) = value;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06007470 RID: 29808 RVA: 0x000A7108 File Offset: 0x000A5308
		// (set) Token: 0x06007471 RID: 29809 RVA: 0x000A711C File Offset: 0x000A531C
		[Nullable(2)]
		public unsafe USoundAttenuation AttenuationSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_AttenuationSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x000A7134 File Offset: 0x000A5334
		// (set) Token: 0x06007473 RID: 29811 RVA: 0x000A716D File Offset: 0x000A536D
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationSettings result;
				if ((result = this._AttenuationOverrides) == null)
				{
					result = (this._AttenuationOverrides = new FSoundAttenuationSettings(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AttenuationOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AttenuationOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x000A718E File Offset: 0x000A538E
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x000A71A2 File Offset: 0x000A53A2
		[Nullable(2)]
		public unsafe USoundConcurrency ConcurrencySettings_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundConcurrency>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_ConcurrencySettings_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioComponent.__PropertyOffset_ConcurrencySettings_DEPRECATED, value);
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x000A71B8 File Offset: 0x000A53B8
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x000A71F1 File Offset: 0x000A53F1
		public TSet<USoundConcurrency> ConcurrencySet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<USoundConcurrency> result;
				if ((result = this._ConcurrencySet) == null)
				{
					result = (this._ConcurrencySet = new TSet<USoundConcurrency>(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_ConcurrencySet, this));
				}
				return result;
			}
			set
			{
				this.ConcurrencySet.CopyAssign(value);
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06007478 RID: 29816 RVA: 0x000A71FF File Offset: 0x000A53FF
		// (set) Token: 0x06007479 RID: 29817 RVA: 0x000A720F File Offset: 0x000A540F
		public unsafe EAttachmentRule AutoAttachLocationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachLocationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachLocationRule) = (byte)value;
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x000A7220 File Offset: 0x000A5420
		// (set) Token: 0x0600747B RID: 29819 RVA: 0x000A7230 File Offset: 0x000A5430
		public unsafe EAttachmentRule AutoAttachRotationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachRotationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachRotationRule) = (byte)value;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x000A7241 File Offset: 0x000A5441
		// (set) Token: 0x0600747D RID: 29821 RVA: 0x000A7251 File Offset: 0x000A5451
		public unsafe EAttachmentRule AutoAttachScaleRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachScaleRule) = (byte)value;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x000A7264 File Offset: 0x000A5464
		// (set) Token: 0x0600747F RID: 29823 RVA: 0x000A729D File Offset: 0x000A549D
		public FSoundModulationDefaultRoutingSettings ModulationRouting
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDefaultRoutingSettings result;
				if ((result = this._ModulationRouting) == null)
				{
					result = (this._ModulationRouting = new FSoundModulationDefaultRoutingSettings(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_ModulationRouting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDefaultRoutingSettings.StaticStruct(), base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_ModulationRouting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06007480 RID: 29824 RVA: 0x000A72C0 File Offset: 0x000A54C0
		// (set) Token: 0x06007481 RID: 29825 RVA: 0x000A72F9 File Offset: 0x000A54F9
		public FOnAudioPlayStateChanged OnAudioPlayStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioPlayStateChanged result;
				if ((result = this._OnAudioPlayStateChanged) == null)
				{
					result = (this._OnAudioPlayStateChanged = new FOnAudioPlayStateChanged(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioPlayStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioPlayStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x000A731C File Offset: 0x000A551C
		// (set) Token: 0x06007483 RID: 29827 RVA: 0x000A7355 File Offset: 0x000A5555
		public FOnAudioVirtualizationChanged OnAudioVirtualizationChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioVirtualizationChanged result;
				if ((result = this._OnAudioVirtualizationChanged) == null)
				{
					result = (this._OnAudioVirtualizationChanged = new FOnAudioVirtualizationChanged(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioVirtualizationChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioVirtualizationChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x000A7378 File Offset: 0x000A5578
		// (set) Token: 0x06007485 RID: 29829 RVA: 0x000A73B1 File Offset: 0x000A55B1
		public FOnAudioFinished OnAudioFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioFinished result;
				if ((result = this._OnAudioFinished) == null)
				{
					result = (this._OnAudioFinished = new FOnAudioFinished(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x000A73D4 File Offset: 0x000A55D4
		// (set) Token: 0x06007487 RID: 29831 RVA: 0x000A740D File Offset: 0x000A560D
		public FOnAudioPlaybackPercent OnAudioPlaybackPercent
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioPlaybackPercent result;
				if ((result = this._OnAudioPlaybackPercent) == null)
				{
					result = (this._OnAudioPlaybackPercent = new FOnAudioPlaybackPercent(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioPlaybackPercent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioPlaybackPercent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x000A7430 File Offset: 0x000A5630
		// (set) Token: 0x06007489 RID: 29833 RVA: 0x000A7469 File Offset: 0x000A5669
		public FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioSingleEnvelopeValue result;
				if ((result = this._OnAudioSingleEnvelopeValue) == null)
				{
					result = (this._OnAudioSingleEnvelopeValue = new FOnAudioSingleEnvelopeValue(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioSingleEnvelopeValue, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioSingleEnvelopeValue, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x000A748C File Offset: 0x000A568C
		// (set) Token: 0x0600748B RID: 29835 RVA: 0x000A74C5 File Offset: 0x000A56C5
		public FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioMultiEnvelopeValue result;
				if ((result = this._OnAudioMultiEnvelopeValue) == null)
				{
					result = (this._OnAudioMultiEnvelopeValue = new FOnAudioMultiEnvelopeValue(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioMultiEnvelopeValue, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnAudioMultiEnvelopeValue, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x000A74E8 File Offset: 0x000A56E8
		// (set) Token: 0x0600748D RID: 29837 RVA: 0x000A7521 File Offset: 0x000A5721
		public FOnQueueSubtitles OnQueueSubtitles
		{
			get
			{
				base.FastCheckIsValid();
				FOnQueueSubtitles result;
				if ((result = this._OnQueueSubtitles) == null)
				{
					result = (this._OnQueueSubtitles = new FOnQueueSubtitles(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnQueueSubtitles, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_OnQueueSubtitles, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x000A7542 File Offset: 0x000A5742
		// (set) Token: 0x0600748F RID: 29839 RVA: 0x000A7556 File Offset: 0x000A5756
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> AutoAttachParent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachParent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachParent) = value;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x000A756B File Offset: 0x000A576B
		// (set) Token: 0x06007491 RID: 29841 RVA: 0x000A757F File Offset: 0x000A577F
		public unsafe FName AutoAttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioComponent.__PropertyOffset_AutoAttachSocketName) = value;
			}
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x000A7594 File Offset: 0x000A5794
		public void StopDelayed(float DelayTime)
		{
			UAudioComponent.__StopDelayed_Internal(base.NativePtr, DelayTime);
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x000A75A2 File Offset: 0x000A57A2
		public void Stop()
		{
			UAudioComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x000A75AF File Offset: 0x000A57AF
		[NullableContext(2)]
		public void SetWaveParameter(FName InName, USoundWave InWave)
		{
			UAudioComponent.__SetWaveParameter_Internal(base.NativePtr, InName, (InWave != null) ? InWave.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x000A75CD File Offset: 0x000A57CD
		public void SetVolumeMultiplier(float NewVolumeMultiplier)
		{
			UAudioComponent.__SetVolumeMultiplier_Internal(base.NativePtr, NewVolumeMultiplier);
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x000A75DB File Offset: 0x000A57DB
		public void SetUISound(bool bInUISound)
		{
			UAudioComponent.__SetUISound_Internal(base.NativePtr, bInUISound);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x000A75E9 File Offset: 0x000A57E9
		[NullableContext(2)]
		public void SetSubmixSend(USoundSubmixBase Submix, float SendLevel)
		{
			UAudioComponent.__SetSubmixSend_Internal(base.NativePtr, (Submix != null) ? Submix.NativePtr : IntPtr.Zero, SendLevel);
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x000A7607 File Offset: 0x000A5807
		[NullableContext(2)]
		public void SetSourceBusSendPreEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
		{
			UAudioComponent.__SetSourceBusSendPreEffect_Internal(base.NativePtr, (SoundSourceBus != null) ? SoundSourceBus.NativePtr : IntPtr.Zero, SourceBusSendLevel);
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x000A7625 File Offset: 0x000A5825
		[NullableContext(2)]
		public void SetSourceBusSendPostEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
		{
			UAudioComponent.__SetSourceBusSendPostEffect_Internal(base.NativePtr, (SoundSourceBus != null) ? SoundSourceBus.NativePtr : IntPtr.Zero, SourceBusSendLevel);
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x000A7643 File Offset: 0x000A5843
		[NullableContext(2)]
		public void SetSound(USoundBase NewSound)
		{
			UAudioComponent.__SetSound_Internal(base.NativePtr, (NewSound != null) ? NewSound.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x000A7660 File Offset: 0x000A5860
		public void SetPitchMultiplier(float NewPitchMultiplier)
		{
			UAudioComponent.__SetPitchMultiplier_Internal(base.NativePtr, NewPitchMultiplier);
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x000A766E File Offset: 0x000A586E
		public void SetPaused(bool bPause)
		{
			UAudioComponent.__SetPaused_Internal(base.NativePtr, bPause);
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x000A767C File Offset: 0x000A587C
		public void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
		{
			UAudioComponent.__SetLowPassFilterFrequency_Internal(base.NativePtr, InLowPassFilterFrequency);
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x000A768A File Offset: 0x000A588A
		public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
		{
			UAudioComponent.__SetLowPassFilterEnabled_Internal(base.NativePtr, InLowPassFilterEnabled);
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x000A7698 File Offset: 0x000A5898
		public void SetIntParameter(FName InName, int InInt)
		{
			UAudioComponent.__SetIntParameter_Internal(base.NativePtr, InName, InInt);
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x000A76A7 File Offset: 0x000A58A7
		public void SetFloatParameter(FName InName, float InFloat)
		{
			UAudioComponent.__SetFloatParameter_Internal(base.NativePtr, InName, InFloat);
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x000A76B6 File Offset: 0x000A58B6
		public void SetBoolParameter(FName InName, bool InBool)
		{
			UAudioComponent.__SetBoolParameter_Internal(base.NativePtr, InName, InBool);
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x000A76C5 File Offset: 0x000A58C5
		[NullableContext(2)]
		public void SetAudioBusSendPreEffect(UAudioBus AudioBus, float AudioBusSendLevel)
		{
			UAudioComponent.__SetAudioBusSendPreEffect_Internal(base.NativePtr, (AudioBus != null) ? AudioBus.NativePtr : IntPtr.Zero, AudioBusSendLevel);
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x000A76E3 File Offset: 0x000A58E3
		[NullableContext(2)]
		public void SetAudioBusSendPostEffect(UAudioBus AudioBus, float SourceBusSendLevel)
		{
			UAudioComponent.__SetAudioBusSendPostEffect_Internal(base.NativePtr, (AudioBus != null) ? AudioBus.NativePtr : IntPtr.Zero, SourceBusSendLevel);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x000A7704 File Offset: 0x000A5904
		[NullableContext(2)]
		public void PlayQuantized(UObject WorldContextObject, ref UQuartzClockHandle InClockHandle, ref FQuartzQuantizationBoundary InQuantizationBoundary, in FOnQuartzCommandEventBP InDelegate, float InStartTime = 0f, float InFadeInDuration = 0f, float InFadeVolumeLevel = 1f, EAudioFaderCurve InFadeCurve = EAudioFaderCurve.Linear)
		{
			UQuartzClockHandle uquartzClockHandle = InClockHandle;
			IntPtr nativeObjectPtr = (uquartzClockHandle != null) ? uquartzClockHandle.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (InQuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = InDelegate;
			UAudioComponent.__PlayQuantized_Internal(nativePtr, worldContextObject, ref nativeObjectPtr, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), InStartTime, InFadeInDuration, InFadeVolumeLevel, InFadeCurve);
			InClockHandle = BuiltinUtils.GetOrCreateUObjectByNativePointer<UQuartzClockHandle>(nativeObjectPtr);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x000A7771 File Offset: 0x000A5971
		public void Play(float StartTime = 0f)
		{
			UAudioComponent.__Play_Internal(base.NativePtr, StartTime);
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x000A777F File Offset: 0x000A597F
		public bool IsVirtualized()
		{
			return UAudioComponent.__IsVirtualized_Internal(base.NativePtr);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x000A778C File Offset: 0x000A598C
		public bool IsPlaying()
		{
			return UAudioComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x000A7799 File Offset: 0x000A5999
		public bool HasCookedFFTData()
		{
			return UAudioComponent.__HasCookedFFTData_Internal(base.NativePtr);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x000A77A6 File Offset: 0x000A59A6
		public bool HasCookedAmplitudeEnvelopeData()
		{
			return UAudioComponent.__HasCookedAmplitudeEnvelopeData_Internal(base.NativePtr);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x000A77B3 File Offset: 0x000A59B3
		public EAudioComponentPlayState GetPlayState()
		{
			return UAudioComponent.__GetPlayState_Internal(base.NativePtr);
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x000A77C0 File Offset: 0x000A59C0
		public bool GetCookedFFTDataForAllPlayingSounds([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoundWaveSpectralDataPerSound> OutSoundWaveSpectralData)
		{
			return UAudioComponent.__GetCookedFFTDataForAllPlayingSounds_Internal(base.NativePtr, (OutSoundWaveSpectralData ?? new TArray<FSoundWaveSpectralDataPerSound>()).NativePtr);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x000A77DD File Offset: 0x000A59DD
		[NullableContext(2)]
		public bool GetCookedFFTData(in TArray<float> FrequenciesToGet, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoundWaveSpectralData> OutSoundWaveSpectralData)
		{
			return UAudioComponent.__GetCookedFFTData_Internal(base.NativePtr, (FrequenciesToGet ?? new TArray<float>()).NativePtr, (OutSoundWaveSpectralData ?? new TArray<FSoundWaveSpectralData>()).NativePtr);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x000A780A File Offset: 0x000A5A0A
		public bool GetCookedEnvelopeDataForAllPlayingSounds([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoundWaveEnvelopeDataPerSound> OutEnvelopeData)
		{
			return UAudioComponent.__GetCookedEnvelopeDataForAllPlayingSounds_Internal(base.NativePtr, (OutEnvelopeData ?? new TArray<FSoundWaveEnvelopeDataPerSound>()).NativePtr);
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x000A7828 File Offset: 0x000A5A28
		public unsafe bool GetCookedEnvelopeData(ref float OutEnvelopeData)
		{
			fixed (float* ptr = &OutEnvelopeData)
			{
				void* ptr2 = (void*)ptr;
				return UAudioComponent.__GetCookedEnvelopeData_Internal(base.NativePtr, ref OutEnvelopeData);
			}
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x000A7846 File Offset: 0x000A5A46
		public void FadeOut(float FadeOutDuration, float FadeVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			UAudioComponent.__FadeOut_Internal(base.NativePtr, FadeOutDuration, FadeVolumeLevel, FadeCurve);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x000A7856 File Offset: 0x000A5A56
		public void FadeIn(float FadeInDuration, float FadeVolumeLevel = 1f, float StartTime = 0f, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			UAudioComponent.__FadeIn_Internal(base.NativePtr, FadeInDuration, FadeVolumeLevel, StartTime, FadeCurve);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x000A7868 File Offset: 0x000A5A68
		[NullableContext(2)]
		public bool BP_GetAttenuationSettingsToApply(ref FSoundAttenuationSettings OutAttenuationSettings)
		{
			return UAudioComponent.__BP_GetAttenuationSettingsToApply_Internal(base.NativePtr, (OutAttenuationSettings ?? new FSoundAttenuationSettings()).NativePtr);
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x000A7885 File Offset: 0x000A5A85
		public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			UAudioComponent.__AdjustVolume_Internal(base.NativePtr, AdjustVolumeDuration, AdjustVolumeLevel, FadeCurve);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x000A7895 File Offset: 0x000A5A95
		[NullableContext(2)]
		public void AdjustAttenuation(in FSoundAttenuationSettings InAttenuationSettings)
		{
			UAudioComponent.__AdjustAttenuation_Internal(base.NativePtr, (InAttenuationSettings ?? new FSoundAttenuationSettings()).NativePtr);
		}

		// Token: 0x060074B4 RID: 29876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopDelayed_Internal(IntPtr @this, float DelayTime);

		// Token: 0x060074B5 RID: 29877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060074B6 RID: 29878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWaveParameter_Internal(IntPtr @this, FName InName, IntPtr InWave);

		// Token: 0x060074B7 RID: 29879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumeMultiplier_Internal(IntPtr @this, float NewVolumeMultiplier);

		// Token: 0x060074B8 RID: 29880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUISound_Internal(IntPtr @this, bool bInUISound);

		// Token: 0x060074B9 RID: 29881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubmixSend_Internal(IntPtr @this, IntPtr Submix, float SendLevel);

		// Token: 0x060074BA RID: 29882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceBusSendPreEffect_Internal(IntPtr @this, IntPtr SoundSourceBus, float SourceBusSendLevel);

		// Token: 0x060074BB RID: 29883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceBusSendPostEffect_Internal(IntPtr @this, IntPtr SoundSourceBus, float SourceBusSendLevel);

		// Token: 0x060074BC RID: 29884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSound_Internal(IntPtr @this, IntPtr NewSound);

		// Token: 0x060074BD RID: 29885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPitchMultiplier_Internal(IntPtr @this, float NewPitchMultiplier);

		// Token: 0x060074BE RID: 29886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPaused_Internal(IntPtr @this, bool bPause);

		// Token: 0x060074BF RID: 29887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowPassFilterFrequency_Internal(IntPtr @this, float InLowPassFilterFrequency);

		// Token: 0x060074C0 RID: 29888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowPassFilterEnabled_Internal(IntPtr @this, bool InLowPassFilterEnabled);

		// Token: 0x060074C1 RID: 29889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntParameter_Internal(IntPtr @this, FName InName, int InInt);

		// Token: 0x060074C2 RID: 29890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, FName InName, float InFloat);

		// Token: 0x060074C3 RID: 29891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolParameter_Internal(IntPtr @this, FName InName, bool InBool);

		// Token: 0x060074C4 RID: 29892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioBusSendPreEffect_Internal(IntPtr @this, IntPtr AudioBus, float AudioBusSendLevel);

		// Token: 0x060074C5 RID: 29893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioBusSendPostEffect_Internal(IntPtr @this, IntPtr AudioBus, float SourceBusSendLevel);

		// Token: 0x060074C6 RID: 29894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayQuantized_Internal(IntPtr @this, IntPtr WorldContextObject, ref IntPtr InClockHandle, IntPtr InQuantizationBoundary, IntPtr InDelegate, float InStartTime, float InFadeInDuration, float InFadeVolumeLevel, EAudioFaderCurve InFadeCurve);

		// Token: 0x060074C7 RID: 29895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, float StartTime);

		// Token: 0x060074C8 RID: 29896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVirtualized_Internal(IntPtr @this);

		// Token: 0x060074C9 RID: 29897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x060074CA RID: 29898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasCookedFFTData_Internal(IntPtr @this);

		// Token: 0x060074CB RID: 29899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasCookedAmplitudeEnvelopeData_Internal(IntPtr @this);

		// Token: 0x060074CC RID: 29900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EAudioComponentPlayState __GetPlayState_Internal(IntPtr @this);

		// Token: 0x060074CD RID: 29901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCookedFFTDataForAllPlayingSounds_Internal(IntPtr @this, IntPtr OutSoundWaveSpectralData);

		// Token: 0x060074CE RID: 29902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCookedFFTData_Internal(IntPtr @this, IntPtr FrequenciesToGet, IntPtr OutSoundWaveSpectralData);

		// Token: 0x060074CF RID: 29903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCookedEnvelopeDataForAllPlayingSounds_Internal(IntPtr @this, IntPtr OutEnvelopeData);

		// Token: 0x060074D0 RID: 29904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCookedEnvelopeData_Internal(IntPtr @this, ref float OutEnvelopeData);

		// Token: 0x060074D1 RID: 29905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FadeOut_Internal(IntPtr @this, float FadeOutDuration, float FadeVolumeLevel, EAudioFaderCurve FadeCurve);

		// Token: 0x060074D2 RID: 29906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FadeIn_Internal(IntPtr @this, float FadeInDuration, float FadeVolumeLevel, float StartTime, EAudioFaderCurve FadeCurve);

		// Token: 0x060074D3 RID: 29907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_GetAttenuationSettingsToApply_Internal(IntPtr @this, IntPtr OutAttenuationSettings);

		// Token: 0x060074D4 RID: 29908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustVolume_Internal(IntPtr @this, float AdjustVolumeDuration, float AdjustVolumeLevel, EAudioFaderCurve FadeCurve);

		// Token: 0x060074D5 RID: 29909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustAttenuation_Internal(IntPtr @this, IntPtr InAttenuationSettings);

		// Token: 0x060074D6 RID: 29910 RVA: 0x000A78B2 File Offset: 0x000A5AB2
		static UAudioComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AudioComponent");
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x000A78C0 File Offset: 0x000A5AC0
		protected UAudioComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037E9 RID: 14313
		public new const string __ObjectPath = "/Script/Engine.AudioComponent";

		// Token: 0x040037EA RID: 14314
		private static IntPtr _ClassPtr;

		// Token: 0x040037EB RID: 14315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037EC RID: 14316
		internal static int __PropertyOffset_Sound;

		// Token: 0x040037ED RID: 14317
		internal static int __PropertyOffset_InstanceParameters;

		// Token: 0x040037EE RID: 14318
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAudioComponentParam> _InstanceParameters;

		// Token: 0x040037EF RID: 14319
		internal static int __PropertyOffset_SoundClassOverride;

		// Token: 0x040037F0 RID: 14320
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x040037F1 RID: 14321
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x040037F2 RID: 14322
		internal static int __PropertyOffset_bStopWhenOwnerDestroyed;

		// Token: 0x040037F3 RID: 14323
		internal static byte __PropertyMask_bStopWhenOwnerDestroyed;

		// Token: 0x040037F4 RID: 14324
		internal static int __PropertyOffset_bShouldRemainActiveIfDropped;

		// Token: 0x040037F5 RID: 14325
		internal static byte __PropertyMask_bShouldRemainActiveIfDropped;

		// Token: 0x040037F6 RID: 14326
		internal static int __PropertyOffset_bAllowSpatialization;

		// Token: 0x040037F7 RID: 14327
		internal static byte __PropertyMask_bAllowSpatialization;

		// Token: 0x040037F8 RID: 14328
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x040037F9 RID: 14329
		internal static byte __PropertyMask_bOverrideAttenuation;

		// Token: 0x040037FA RID: 14330
		internal static int __PropertyOffset_bOverrideSubtitlePriority;

		// Token: 0x040037FB RID: 14331
		internal static byte __PropertyMask_bOverrideSubtitlePriority;

		// Token: 0x040037FC RID: 14332
		internal static int __PropertyOffset_bIsUISound;

		// Token: 0x040037FD RID: 14333
		internal static byte __PropertyMask_bIsUISound;

		// Token: 0x040037FE RID: 14334
		internal static int __PropertyOffset_bEnableLowPassFilter;

		// Token: 0x040037FF RID: 14335
		internal static byte __PropertyMask_bEnableLowPassFilter;

		// Token: 0x04003800 RID: 14336
		internal static int __PropertyOffset_bOverridePriority;

		// Token: 0x04003801 RID: 14337
		internal static byte __PropertyMask_bOverridePriority;

		// Token: 0x04003802 RID: 14338
		internal static int __PropertyOffset_bSuppressSubtitles;

		// Token: 0x04003803 RID: 14339
		internal static byte __PropertyMask_bSuppressSubtitles;

		// Token: 0x04003804 RID: 14340
		internal static int __PropertyOffset_bAutoManageAttachment;

		// Token: 0x04003805 RID: 14341
		internal static byte __PropertyMask_bAutoManageAttachment;

		// Token: 0x04003806 RID: 14342
		internal static int __PropertyOffset_AudioComponentUserID;

		// Token: 0x04003807 RID: 14343
		internal static int __PropertyOffset_PitchModulationMin;

		// Token: 0x04003808 RID: 14344
		internal static int __PropertyOffset_PitchModulationMax;

		// Token: 0x04003809 RID: 14345
		internal static int __PropertyOffset_VolumeModulationMin;

		// Token: 0x0400380A RID: 14346
		internal static int __PropertyOffset_VolumeModulationMax;

		// Token: 0x0400380B RID: 14347
		internal static int __PropertyOffset_VolumeMultiplier;

		// Token: 0x0400380C RID: 14348
		internal static int __PropertyOffset_EnvelopeFollowerAttackTime;

		// Token: 0x0400380D RID: 14349
		internal static int __PropertyOffset_EnvelopeFollowerReleaseTime;

		// Token: 0x0400380E RID: 14350
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400380F RID: 14351
		internal static int __PropertyOffset_SubtitlePriority;

		// Token: 0x04003810 RID: 14352
		internal static int __PropertyOffset_SourceEffectChain;

		// Token: 0x04003811 RID: 14353
		internal static int __PropertyOffset_PitchMultiplier;

		// Token: 0x04003812 RID: 14354
		internal static int __PropertyOffset_LowPassFilterFrequency;

		// Token: 0x04003813 RID: 14355
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04003814 RID: 14356
		internal static int __PropertyOffset_AttenuationOverrides;

		// Token: 0x04003815 RID: 14357
		[Nullable(2)]
		private FSoundAttenuationSettings _AttenuationOverrides;

		// Token: 0x04003816 RID: 14358
		internal static int __PropertyOffset_ConcurrencySettings_DEPRECATED;

		// Token: 0x04003817 RID: 14359
		internal static int __PropertyOffset_ConcurrencySet;

		// Token: 0x04003818 RID: 14360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USoundConcurrency> _ConcurrencySet;

		// Token: 0x04003819 RID: 14361
		internal static int __PropertyOffset_AutoAttachLocationRule;

		// Token: 0x0400381A RID: 14362
		internal static int __PropertyOffset_AutoAttachRotationRule;

		// Token: 0x0400381B RID: 14363
		internal static int __PropertyOffset_AutoAttachScaleRule;

		// Token: 0x0400381C RID: 14364
		internal static int __PropertyOffset_ModulationRouting;

		// Token: 0x0400381D RID: 14365
		[Nullable(2)]
		private FSoundModulationDefaultRoutingSettings _ModulationRouting;

		// Token: 0x0400381E RID: 14366
		internal static int __PropertyOffset_OnAudioPlayStateChanged;

		// Token: 0x0400381F RID: 14367
		[Nullable(2)]
		private FOnAudioPlayStateChanged _OnAudioPlayStateChanged;

		// Token: 0x04003820 RID: 14368
		internal static int __PropertyOffset_OnAudioVirtualizationChanged;

		// Token: 0x04003821 RID: 14369
		[Nullable(2)]
		private FOnAudioVirtualizationChanged _OnAudioVirtualizationChanged;

		// Token: 0x04003822 RID: 14370
		internal static int __PropertyOffset_OnAudioFinished;

		// Token: 0x04003823 RID: 14371
		[Nullable(2)]
		private FOnAudioFinished _OnAudioFinished;

		// Token: 0x04003824 RID: 14372
		internal static int __PropertyOffset_OnAudioPlaybackPercent;

		// Token: 0x04003825 RID: 14373
		[Nullable(2)]
		private FOnAudioPlaybackPercent _OnAudioPlaybackPercent;

		// Token: 0x04003826 RID: 14374
		internal static int __PropertyOffset_OnAudioSingleEnvelopeValue;

		// Token: 0x04003827 RID: 14375
		[Nullable(2)]
		private FOnAudioSingleEnvelopeValue _OnAudioSingleEnvelopeValue;

		// Token: 0x04003828 RID: 14376
		internal static int __PropertyOffset_OnAudioMultiEnvelopeValue;

		// Token: 0x04003829 RID: 14377
		[Nullable(2)]
		private FOnAudioMultiEnvelopeValue _OnAudioMultiEnvelopeValue;

		// Token: 0x0400382A RID: 14378
		internal static int __PropertyOffset_OnQueueSubtitles;

		// Token: 0x0400382B RID: 14379
		[Nullable(2)]
		private FOnQueueSubtitles _OnQueueSubtitles;

		// Token: 0x0400382C RID: 14380
		internal static int __PropertyOffset_AutoAttachParent;

		// Token: 0x0400382D RID: 14381
		internal static int __PropertyOffset_AutoAttachSocketName;
	}
}
