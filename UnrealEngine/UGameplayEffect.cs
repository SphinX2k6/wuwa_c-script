using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137B RID: 4987
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffect")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class UGameplayEffect : UObject, IUnrealUObject, IUnrealObject, IGameplayTagAssetInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060124BC RID: 74940 RVA: 0x001ADAC6 File Offset: 0x001ABCC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffect._ClassPtr;
		}

		// Token: 0x060124BD RID: 74941 RVA: 0x001ADAD2 File Offset: 0x001ABCD2
		int IGameplayTagAssetInterface.InterfaceOffset()
		{
			return UGameplayEffect.__InterfaceOffset_IGameplayTagAssetInterface;
		}

		// Token: 0x060124BE RID: 74942 RVA: 0x001ADADC File Offset: 0x001ABCDC
		public UGameplayEffect() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060124BF RID: 74943 RVA: 0x001ADB04 File Offset: 0x001ABD04
		public UGameplayEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x060124C0 RID: 74944 RVA: 0x001ADB37 File Offset: 0x001ABD37
		// (set) Token: 0x060124C1 RID: 74945 RVA: 0x001ADB47 File Offset: 0x001ABD47
		public unsafe long GameplayEffectId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GameplayEffectId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GameplayEffectId) = value;
			}
		}

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x060124C2 RID: 74946 RVA: 0x001ADB58 File Offset: 0x001ABD58
		// (set) Token: 0x060124C3 RID: 74947 RVA: 0x001ADB91 File Offset: 0x001ABD91
		public TArray<long> OverflowEffectIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._OverflowEffectIds) == null)
				{
					result = (this._OverflowEffectIds = new TArray<long>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_OverflowEffectIds, this));
				}
				return result;
			}
			set
			{
				this.OverflowEffectIds.CopyAssign(value);
			}
		}

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x060124C4 RID: 74948 RVA: 0x001ADBA0 File Offset: 0x001ABDA0
		// (set) Token: 0x060124C5 RID: 74949 RVA: 0x001ADBD9 File Offset: 0x001ABDD9
		public TArray<long> PrematureExpirationEffectClassIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._PrematureExpirationEffectClassIds) == null)
				{
					result = (this._PrematureExpirationEffectClassIds = new TArray<long>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_PrematureExpirationEffectClassIds, this));
				}
				return result;
			}
			set
			{
				this.PrematureExpirationEffectClassIds.CopyAssign(value);
			}
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x060124C6 RID: 74950 RVA: 0x001ADBE8 File Offset: 0x001ABDE8
		// (set) Token: 0x060124C7 RID: 74951 RVA: 0x001ADC21 File Offset: 0x001ABE21
		public TArray<long> RoutineExpirationEffectClassIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._RoutineExpirationEffectClassIds) == null)
				{
					result = (this._RoutineExpirationEffectClassIds = new TArray<long>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RoutineExpirationEffectClassIds, this));
				}
				return result;
			}
			set
			{
				this.RoutineExpirationEffectClassIds.CopyAssign(value);
			}
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x060124C8 RID: 74952 RVA: 0x001ADC2F File Offset: 0x001ABE2F
		// (set) Token: 0x060124C9 RID: 74953 RVA: 0x001ADC3F File Offset: 0x001ABE3F
		public unsafe EGameplayEffectDurationType DurationPolicy
		{
			get
			{
				return (EGameplayEffectDurationType)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_DurationPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_DurationPolicy) = (byte)value;
			}
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x060124CA RID: 74954 RVA: 0x001ADC50 File Offset: 0x001ABE50
		// (set) Token: 0x060124CB RID: 74955 RVA: 0x001ADC89 File Offset: 0x001ABE89
		public FGameplayEffectModifierMagnitude DurationMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectModifierMagnitude result;
				if ((result = this._DurationMagnitude) == null)
				{
					result = (this._DurationMagnitude = new FGameplayEffectModifierMagnitude(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_DurationMagnitude, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectModifierMagnitude.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_DurationMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x060124CC RID: 74956 RVA: 0x001ADCAC File Offset: 0x001ABEAC
		// (set) Token: 0x060124CD RID: 74957 RVA: 0x001ADCE5 File Offset: 0x001ABEE5
		public FScalableFloat Period
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._Period) == null)
				{
					result = (this._Period = new FScalableFloat(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_Period, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_Period, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x060124CE RID: 74958 RVA: 0x001ADD06 File Offset: 0x001ABF06
		// (set) Token: 0x060124CF RID: 74959 RVA: 0x001ADD16 File Offset: 0x001ABF16
		public unsafe bool bExecutePeriodicEffectOnApplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bExecutePeriodicEffectOnApplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bExecutePeriodicEffectOnApplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x060124D0 RID: 74960 RVA: 0x001ADD27 File Offset: 0x001ABF27
		// (set) Token: 0x060124D1 RID: 74961 RVA: 0x001ADD37 File Offset: 0x001ABF37
		public unsafe EGameplayEffectPeriodInhibitionRemovedPolicy PeriodicInhibitionPolicy
		{
			get
			{
				return (EGameplayEffectPeriodInhibitionRemovedPolicy)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_PeriodicInhibitionPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_PeriodicInhibitionPolicy) = (byte)value;
			}
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x060124D2 RID: 74962 RVA: 0x001ADD48 File Offset: 0x001ABF48
		// (set) Token: 0x060124D3 RID: 74963 RVA: 0x001ADD81 File Offset: 0x001ABF81
		public TArray<FGameplayModifierInfo> Modifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayModifierInfo> result;
				if ((result = this._Modifiers) == null)
				{
					result = (this._Modifiers = new TArray<FGameplayModifierInfo>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_Modifiers, this));
				}
				return result;
			}
			set
			{
				this.Modifiers.CopyAssign(value);
			}
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x060124D4 RID: 74964 RVA: 0x001ADD90 File Offset: 0x001ABF90
		// (set) Token: 0x060124D5 RID: 74965 RVA: 0x001ADDC9 File Offset: 0x001ABFC9
		public TArray<FGameplayEffectExecutionDefinition> Executions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectExecutionDefinition> result;
				if ((result = this._Executions) == null)
				{
					result = (this._Executions = new TArray<FGameplayEffectExecutionDefinition>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_Executions, this));
				}
				return result;
			}
			set
			{
				this.Executions.CopyAssign(value);
			}
		}

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x060124D6 RID: 74966 RVA: 0x001ADDD8 File Offset: 0x001ABFD8
		// (set) Token: 0x060124D7 RID: 74967 RVA: 0x001ADE11 File Offset: 0x001AC011
		public FScalableFloat ChanceToApplyToTarget
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._ChanceToApplyToTarget) == null)
				{
					result = (this._ChanceToApplyToTarget = new FScalableFloat(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ChanceToApplyToTarget, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ChanceToApplyToTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x060124D8 RID: 74968 RVA: 0x001ADE34 File Offset: 0x001AC034
		// (set) Token: 0x060124D9 RID: 74969 RVA: 0x001ADE6D File Offset: 0x001AC06D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffectCustomApplicationRequirement>> ApplicationRequirements
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffectCustomApplicationRequirement>> result;
				if ((result = this._ApplicationRequirements) == null)
				{
					result = (this._ApplicationRequirements = new TArray<TSubclassOf<UGameplayEffectCustomApplicationRequirement>>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ApplicationRequirements, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ApplicationRequirements.CopyAssign(value);
			}
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x060124DA RID: 74970 RVA: 0x001ADE7C File Offset: 0x001AC07C
		// (set) Token: 0x060124DB RID: 74971 RVA: 0x001ADEB5 File Offset: 0x001AC0B5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> TargetEffectClasses_DEPRECATED
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._TargetEffectClasses_DEPRECATED) == null)
				{
					result = (this._TargetEffectClasses_DEPRECATED = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_TargetEffectClasses_DEPRECATED, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.TargetEffectClasses_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x060124DC RID: 74972 RVA: 0x001ADEC4 File Offset: 0x001AC0C4
		// (set) Token: 0x060124DD RID: 74973 RVA: 0x001ADEFD File Offset: 0x001AC0FD
		public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConditionalGameplayEffect> result;
				if ((result = this._ConditionalGameplayEffects) == null)
				{
					result = (this._ConditionalGameplayEffects = new TArray<FConditionalGameplayEffect>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ConditionalGameplayEffects, this));
				}
				return result;
			}
			set
			{
				this.ConditionalGameplayEffects.CopyAssign(value);
			}
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x060124DE RID: 74974 RVA: 0x001ADF0C File Offset: 0x001AC10C
		// (set) Token: 0x060124DF RID: 74975 RVA: 0x001ADF45 File Offset: 0x001AC145
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> OverflowEffects
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._OverflowEffects) == null)
				{
					result = (this._OverflowEffects = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_OverflowEffects, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.OverflowEffects.CopyAssign(value);
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x060124E0 RID: 74976 RVA: 0x001ADF53 File Offset: 0x001AC153
		// (set) Token: 0x060124E1 RID: 74977 RVA: 0x001ADF63 File Offset: 0x001AC163
		public unsafe bool bDenyOverflowApplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bDenyOverflowApplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bDenyOverflowApplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x060124E2 RID: 74978 RVA: 0x001ADF74 File Offset: 0x001AC174
		// (set) Token: 0x060124E3 RID: 74979 RVA: 0x001ADF84 File Offset: 0x001AC184
		public unsafe bool bClearStackOnOverflow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bClearStackOnOverflow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bClearStackOnOverflow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x060124E4 RID: 74980 RVA: 0x001ADF98 File Offset: 0x001AC198
		// (set) Token: 0x060124E5 RID: 74981 RVA: 0x001ADFD1 File Offset: 0x001AC1D1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> PrematureExpirationEffectClasses
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._PrematureExpirationEffectClasses) == null)
				{
					result = (this._PrematureExpirationEffectClasses = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_PrematureExpirationEffectClasses, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.PrematureExpirationEffectClasses.CopyAssign(value);
			}
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x060124E6 RID: 74982 RVA: 0x001ADFE0 File Offset: 0x001AC1E0
		// (set) Token: 0x060124E7 RID: 74983 RVA: 0x001AE019 File Offset: 0x001AC219
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> RoutineExpirationEffectClasses
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._RoutineExpirationEffectClasses) == null)
				{
					result = (this._RoutineExpirationEffectClasses = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RoutineExpirationEffectClasses, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.RoutineExpirationEffectClasses.CopyAssign(value);
			}
		}

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x060124E8 RID: 74984 RVA: 0x001AE027 File Offset: 0x001AC227
		// (set) Token: 0x060124E9 RID: 74985 RVA: 0x001AE037 File Offset: 0x001AC237
		public unsafe bool bRequireModifierSuccessToTriggerCues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bRequireModifierSuccessToTriggerCues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bRequireModifierSuccessToTriggerCues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x060124EA RID: 74986 RVA: 0x001AE048 File Offset: 0x001AC248
		// (set) Token: 0x060124EB RID: 74987 RVA: 0x001AE058 File Offset: 0x001AC258
		public unsafe bool bSuppressStackingCues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bSuppressStackingCues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_bSuppressStackingCues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x060124EC RID: 74988 RVA: 0x001AE06C File Offset: 0x001AC26C
		// (set) Token: 0x060124ED RID: 74989 RVA: 0x001AE0A5 File Offset: 0x001AC2A5
		public TArray<FGameplayEffectCue> GameplayCues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectCue> result;
				if ((result = this._GameplayCues) == null)
				{
					result = (this._GameplayCues = new TArray<FGameplayEffectCue>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GameplayCues, this));
				}
				return result;
			}
			set
			{
				this.GameplayCues.CopyAssign(value);
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x060124EE RID: 74990 RVA: 0x001AE0B4 File Offset: 0x001AC2B4
		// (set) Token: 0x060124EF RID: 74991 RVA: 0x001AE0ED File Offset: 0x001AC2ED
		public TArray<long> GameplayCueIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._GameplayCueIds) == null)
				{
					result = (this._GameplayCueIds = new TArray<long>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GameplayCueIds, this));
				}
				return result;
			}
			set
			{
				this.GameplayCueIds.CopyAssign(value);
			}
		}

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x060124F0 RID: 74992 RVA: 0x001AE0FB File Offset: 0x001AC2FB
		// (set) Token: 0x060124F1 RID: 74993 RVA: 0x001AE10F File Offset: 0x001AC30F
		[Nullable(2)]
		public unsafe UGameplayEffectUIData UIData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayEffectUIData>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayEffect.__PropertyOffset_UIData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayEffect.__PropertyOffset_UIData, value);
			}
		}

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x060124F2 RID: 74994 RVA: 0x001AE124 File Offset: 0x001AC324
		// (set) Token: 0x060124F3 RID: 74995 RVA: 0x001AE15D File Offset: 0x001AC35D
		public FInheritedTagContainer InheritableGameplayEffectTags
		{
			get
			{
				base.FastCheckIsValid();
				FInheritedTagContainer result;
				if ((result = this._InheritableGameplayEffectTags) == null)
				{
					result = (this._InheritableGameplayEffectTags = new FInheritedTagContainer(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_InheritableGameplayEffectTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInheritedTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_InheritableGameplayEffectTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x060124F4 RID: 74996 RVA: 0x001AE180 File Offset: 0x001AC380
		// (set) Token: 0x060124F5 RID: 74997 RVA: 0x001AE1B9 File Offset: 0x001AC3B9
		public FInheritedTagContainer InheritableOwnedTagsContainer
		{
			get
			{
				base.FastCheckIsValid();
				FInheritedTagContainer result;
				if ((result = this._InheritableOwnedTagsContainer) == null)
				{
					result = (this._InheritableOwnedTagsContainer = new FInheritedTagContainer(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_InheritableOwnedTagsContainer, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInheritedTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_InheritableOwnedTagsContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x060124F6 RID: 74998 RVA: 0x001AE1DC File Offset: 0x001AC3DC
		// (set) Token: 0x060124F7 RID: 74999 RVA: 0x001AE215 File Offset: 0x001AC415
		public FGameplayTagRequirements OngoingTagRequirements
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._OngoingTagRequirements) == null)
				{
					result = (this._OngoingTagRequirements = new FGameplayTagRequirements(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_OngoingTagRequirements, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_OngoingTagRequirements, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x060124F8 RID: 75000 RVA: 0x001AE238 File Offset: 0x001AC438
		// (set) Token: 0x060124F9 RID: 75001 RVA: 0x001AE271 File Offset: 0x001AC471
		public FGameplayTagRequirements ApplicationSourceTagRequirements
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._ApplicationSourceTagRequirements) == null)
				{
					result = (this._ApplicationSourceTagRequirements = new FGameplayTagRequirements(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ApplicationSourceTagRequirements, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ApplicationSourceTagRequirements, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x060124FA RID: 75002 RVA: 0x001AE294 File Offset: 0x001AC494
		// (set) Token: 0x060124FB RID: 75003 RVA: 0x001AE2CD File Offset: 0x001AC4CD
		public FGameplayTagRequirements ApplicationTagRequirements
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._ApplicationTagRequirements) == null)
				{
					result = (this._ApplicationTagRequirements = new FGameplayTagRequirements(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ApplicationTagRequirements, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_ApplicationTagRequirements, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x060124FC RID: 75004 RVA: 0x001AE2F0 File Offset: 0x001AC4F0
		// (set) Token: 0x060124FD RID: 75005 RVA: 0x001AE329 File Offset: 0x001AC529
		public FGameplayTagRequirements RemovalTagRequirements
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._RemovalTagRequirements) == null)
				{
					result = (this._RemovalTagRequirements = new FGameplayTagRequirements(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemovalTagRequirements, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemovalTagRequirements, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x060124FE RID: 75006 RVA: 0x001AE34C File Offset: 0x001AC54C
		// (set) Token: 0x060124FF RID: 75007 RVA: 0x001AE385 File Offset: 0x001AC585
		public FInheritedTagContainer RemoveGameplayEffectsWithTags
		{
			get
			{
				base.FastCheckIsValid();
				FInheritedTagContainer result;
				if ((result = this._RemoveGameplayEffectsWithTags) == null)
				{
					result = (this._RemoveGameplayEffectsWithTags = new FInheritedTagContainer(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemoveGameplayEffectsWithTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInheritedTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemoveGameplayEffectsWithTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x06012500 RID: 75008 RVA: 0x001AE3A8 File Offset: 0x001AC5A8
		// (set) Token: 0x06012501 RID: 75009 RVA: 0x001AE3E1 File Offset: 0x001AC5E1
		public FGameplayTagRequirements GrantedApplicationImmunityTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._GrantedApplicationImmunityTags) == null)
				{
					result = (this._GrantedApplicationImmunityTags = new FGameplayTagRequirements(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GrantedApplicationImmunityTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GrantedApplicationImmunityTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x06012502 RID: 75010 RVA: 0x001AE404 File Offset: 0x001AC604
		// (set) Token: 0x06012503 RID: 75011 RVA: 0x001AE43D File Offset: 0x001AC63D
		public FGameplayEffectQuery GrantedApplicationImmunityQuery
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectQuery result;
				if ((result = this._GrantedApplicationImmunityQuery) == null)
				{
					result = (this._GrantedApplicationImmunityQuery = new FGameplayEffectQuery(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GrantedApplicationImmunityQuery, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectQuery.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GrantedApplicationImmunityQuery, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x06012504 RID: 75012 RVA: 0x001AE460 File Offset: 0x001AC660
		// (set) Token: 0x06012505 RID: 75013 RVA: 0x001AE499 File Offset: 0x001AC699
		public FGameplayEffectQuery RemoveGameplayEffectQuery
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectQuery result;
				if ((result = this._RemoveGameplayEffectQuery) == null)
				{
					result = (this._RemoveGameplayEffectQuery = new FGameplayEffectQuery(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemoveGameplayEffectQuery, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectQuery.StaticStruct(), base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_RemoveGameplayEffectQuery, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x06012506 RID: 75014 RVA: 0x001AE4BA File Offset: 0x001AC6BA
		// (set) Token: 0x06012507 RID: 75015 RVA: 0x001AE4CA File Offset: 0x001AC6CA
		public unsafe EGameplayEffectStackingType StackingType
		{
			get
			{
				return (EGameplayEffectStackingType)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackingType) = (byte)value;
			}
		}

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x06012508 RID: 75016 RVA: 0x001AE4DB File Offset: 0x001AC6DB
		// (set) Token: 0x06012509 RID: 75017 RVA: 0x001AE4EB File Offset: 0x001AC6EB
		public unsafe int StackLimitCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackLimitCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackLimitCount) = value;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x0601250A RID: 75018 RVA: 0x001AE4FC File Offset: 0x001AC6FC
		// (set) Token: 0x0601250B RID: 75019 RVA: 0x001AE50C File Offset: 0x001AC70C
		public unsafe int StackAppendCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackAppendCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackAppendCount) = value;
			}
		}

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x0601250C RID: 75020 RVA: 0x001AE51D File Offset: 0x001AC71D
		// (set) Token: 0x0601250D RID: 75021 RVA: 0x001AE52D File Offset: 0x001AC72D
		public unsafe EGameplayEffectStackingDurationPolicy StackDurationRefreshPolicy
		{
			get
			{
				return (EGameplayEffectStackingDurationPolicy)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackDurationRefreshPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackDurationRefreshPolicy) = (byte)value;
			}
		}

		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x0601250E RID: 75022 RVA: 0x001AE53E File Offset: 0x001AC73E
		// (set) Token: 0x0601250F RID: 75023 RVA: 0x001AE54E File Offset: 0x001AC74E
		public unsafe EGameplayEffectStackingPeriodPolicy StackPeriodResetPolicy
		{
			get
			{
				return (EGameplayEffectStackingPeriodPolicy)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackPeriodResetPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackPeriodResetPolicy) = (byte)value;
			}
		}

		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x06012510 RID: 75024 RVA: 0x001AE55F File Offset: 0x001AC75F
		// (set) Token: 0x06012511 RID: 75025 RVA: 0x001AE56F File Offset: 0x001AC76F
		public unsafe EGameplayEffectStackingExpirationPolicy StackExpirationPolicy
		{
			get
			{
				return (EGameplayEffectStackingExpirationPolicy)(*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackExpirationPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackExpirationPolicy) = (byte)value;
			}
		}

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x06012512 RID: 75026 RVA: 0x001AE580 File Offset: 0x001AC780
		// (set) Token: 0x06012513 RID: 75027 RVA: 0x001AE590 File Offset: 0x001AC790
		public unsafe int StackExpirationRemoveNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackExpirationRemoveNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_StackExpirationRemoveNumber) = value;
			}
		}

		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x06012514 RID: 75028 RVA: 0x001AE5A4 File Offset: 0x001AC7A4
		// (set) Token: 0x06012515 RID: 75029 RVA: 0x001AE5DD File Offset: 0x001AC7DD
		public TArray<FGameplayAbilitySpecDef> GrantedAbilities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayAbilitySpecDef> result;
				if ((result = this._GrantedAbilities) == null)
				{
					result = (this._GrantedAbilities = new TArray<FGameplayAbilitySpecDef>(base.NativePtr + (IntPtr)UGameplayEffect.__PropertyOffset_GrantedAbilities, this));
				}
				return result;
			}
			set
			{
				this.GrantedAbilities.CopyAssign(value);
			}
		}

		// Token: 0x06012516 RID: 75030 RVA: 0x001AE5EB File Offset: 0x001AC7EB
		static UGameplayEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffect");
		}

		// Token: 0x06012517 RID: 75031 RVA: 0x001AE5F9 File Offset: 0x001AC7F9
		protected UGameplayEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009CAA RID: 40106
		internal static int __InterfaceOffset_IGameplayTagAssetInterface;

		// Token: 0x04009CAB RID: 40107
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffect";

		// Token: 0x04009CAC RID: 40108
		private static IntPtr _ClassPtr;

		// Token: 0x04009CAD RID: 40109
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009CAE RID: 40110
		internal static int __PropertyOffset_GameplayEffectId;

		// Token: 0x04009CAF RID: 40111
		internal static int __PropertyOffset_OverflowEffectIds;

		// Token: 0x04009CB0 RID: 40112
		[Nullable(2)]
		private TArray<long> _OverflowEffectIds;

		// Token: 0x04009CB1 RID: 40113
		internal static int __PropertyOffset_PrematureExpirationEffectClassIds;

		// Token: 0x04009CB2 RID: 40114
		[Nullable(2)]
		private TArray<long> _PrematureExpirationEffectClassIds;

		// Token: 0x04009CB3 RID: 40115
		internal static int __PropertyOffset_RoutineExpirationEffectClassIds;

		// Token: 0x04009CB4 RID: 40116
		[Nullable(2)]
		private TArray<long> _RoutineExpirationEffectClassIds;

		// Token: 0x04009CB5 RID: 40117
		internal static int __PropertyOffset_DurationPolicy;

		// Token: 0x04009CB6 RID: 40118
		internal static int __PropertyOffset_DurationMagnitude;

		// Token: 0x04009CB7 RID: 40119
		[Nullable(2)]
		private FGameplayEffectModifierMagnitude _DurationMagnitude;

		// Token: 0x04009CB8 RID: 40120
		internal static int __PropertyOffset_Period;

		// Token: 0x04009CB9 RID: 40121
		[Nullable(2)]
		private FScalableFloat _Period;

		// Token: 0x04009CBA RID: 40122
		internal static int __PropertyOffset_bExecutePeriodicEffectOnApplication;

		// Token: 0x04009CBB RID: 40123
		internal static int __PropertyOffset_PeriodicInhibitionPolicy;

		// Token: 0x04009CBC RID: 40124
		internal static int __PropertyOffset_Modifiers;

		// Token: 0x04009CBD RID: 40125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayModifierInfo> _Modifiers;

		// Token: 0x04009CBE RID: 40126
		internal static int __PropertyOffset_Executions;

		// Token: 0x04009CBF RID: 40127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectExecutionDefinition> _Executions;

		// Token: 0x04009CC0 RID: 40128
		internal static int __PropertyOffset_ChanceToApplyToTarget;

		// Token: 0x04009CC1 RID: 40129
		[Nullable(2)]
		private FScalableFloat _ChanceToApplyToTarget;

		// Token: 0x04009CC2 RID: 40130
		internal static int __PropertyOffset_ApplicationRequirements;

		// Token: 0x04009CC3 RID: 40131
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffectCustomApplicationRequirement>> _ApplicationRequirements;

		// Token: 0x04009CC4 RID: 40132
		internal static int __PropertyOffset_TargetEffectClasses_DEPRECATED;

		// Token: 0x04009CC5 RID: 40133
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _TargetEffectClasses_DEPRECATED;

		// Token: 0x04009CC6 RID: 40134
		internal static int __PropertyOffset_ConditionalGameplayEffects;

		// Token: 0x04009CC7 RID: 40135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConditionalGameplayEffect> _ConditionalGameplayEffects;

		// Token: 0x04009CC8 RID: 40136
		internal static int __PropertyOffset_OverflowEffects;

		// Token: 0x04009CC9 RID: 40137
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _OverflowEffects;

		// Token: 0x04009CCA RID: 40138
		internal static int __PropertyOffset_bDenyOverflowApplication;

		// Token: 0x04009CCB RID: 40139
		internal static int __PropertyOffset_bClearStackOnOverflow;

		// Token: 0x04009CCC RID: 40140
		internal static int __PropertyOffset_PrematureExpirationEffectClasses;

		// Token: 0x04009CCD RID: 40141
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _PrematureExpirationEffectClasses;

		// Token: 0x04009CCE RID: 40142
		internal static int __PropertyOffset_RoutineExpirationEffectClasses;

		// Token: 0x04009CCF RID: 40143
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _RoutineExpirationEffectClasses;

		// Token: 0x04009CD0 RID: 40144
		internal static int __PropertyOffset_bRequireModifierSuccessToTriggerCues;

		// Token: 0x04009CD1 RID: 40145
		internal static int __PropertyOffset_bSuppressStackingCues;

		// Token: 0x04009CD2 RID: 40146
		internal static int __PropertyOffset_GameplayCues;

		// Token: 0x04009CD3 RID: 40147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectCue> _GameplayCues;

		// Token: 0x04009CD4 RID: 40148
		internal static int __PropertyOffset_GameplayCueIds;

		// Token: 0x04009CD5 RID: 40149
		[Nullable(2)]
		private TArray<long> _GameplayCueIds;

		// Token: 0x04009CD6 RID: 40150
		internal static int __PropertyOffset_UIData;

		// Token: 0x04009CD7 RID: 40151
		internal static int __PropertyOffset_InheritableGameplayEffectTags;

		// Token: 0x04009CD8 RID: 40152
		[Nullable(2)]
		private FInheritedTagContainer _InheritableGameplayEffectTags;

		// Token: 0x04009CD9 RID: 40153
		internal static int __PropertyOffset_InheritableOwnedTagsContainer;

		// Token: 0x04009CDA RID: 40154
		[Nullable(2)]
		private FInheritedTagContainer _InheritableOwnedTagsContainer;

		// Token: 0x04009CDB RID: 40155
		internal static int __PropertyOffset_OngoingTagRequirements;

		// Token: 0x04009CDC RID: 40156
		[Nullable(2)]
		private FGameplayTagRequirements _OngoingTagRequirements;

		// Token: 0x04009CDD RID: 40157
		internal static int __PropertyOffset_ApplicationSourceTagRequirements;

		// Token: 0x04009CDE RID: 40158
		[Nullable(2)]
		private FGameplayTagRequirements _ApplicationSourceTagRequirements;

		// Token: 0x04009CDF RID: 40159
		internal static int __PropertyOffset_ApplicationTagRequirements;

		// Token: 0x04009CE0 RID: 40160
		[Nullable(2)]
		private FGameplayTagRequirements _ApplicationTagRequirements;

		// Token: 0x04009CE1 RID: 40161
		internal static int __PropertyOffset_RemovalTagRequirements;

		// Token: 0x04009CE2 RID: 40162
		[Nullable(2)]
		private FGameplayTagRequirements _RemovalTagRequirements;

		// Token: 0x04009CE3 RID: 40163
		internal static int __PropertyOffset_RemoveGameplayEffectsWithTags;

		// Token: 0x04009CE4 RID: 40164
		[Nullable(2)]
		private FInheritedTagContainer _RemoveGameplayEffectsWithTags;

		// Token: 0x04009CE5 RID: 40165
		internal static int __PropertyOffset_GrantedApplicationImmunityTags;

		// Token: 0x04009CE6 RID: 40166
		[Nullable(2)]
		private FGameplayTagRequirements _GrantedApplicationImmunityTags;

		// Token: 0x04009CE7 RID: 40167
		internal static int __PropertyOffset_GrantedApplicationImmunityQuery;

		// Token: 0x04009CE8 RID: 40168
		[Nullable(2)]
		private FGameplayEffectQuery _GrantedApplicationImmunityQuery;

		// Token: 0x04009CE9 RID: 40169
		internal static int __PropertyOffset_RemoveGameplayEffectQuery;

		// Token: 0x04009CEA RID: 40170
		[Nullable(2)]
		private FGameplayEffectQuery _RemoveGameplayEffectQuery;

		// Token: 0x04009CEB RID: 40171
		internal static int __PropertyOffset_StackingType;

		// Token: 0x04009CEC RID: 40172
		internal static int __PropertyOffset_StackLimitCount;

		// Token: 0x04009CED RID: 40173
		internal static int __PropertyOffset_StackAppendCount;

		// Token: 0x04009CEE RID: 40174
		internal static int __PropertyOffset_StackDurationRefreshPolicy;

		// Token: 0x04009CEF RID: 40175
		internal static int __PropertyOffset_StackPeriodResetPolicy;

		// Token: 0x04009CF0 RID: 40176
		internal static int __PropertyOffset_StackExpirationPolicy;

		// Token: 0x04009CF1 RID: 40177
		internal static int __PropertyOffset_StackExpirationRemoveNumber;

		// Token: 0x04009CF2 RID: 40178
		internal static int __PropertyOffset_GrantedAbilities;

		// Token: 0x04009CF3 RID: 40179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayAbilitySpecDef> _GrantedAbilities;
	}
}
