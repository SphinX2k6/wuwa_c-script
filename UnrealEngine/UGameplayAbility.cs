using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C1 RID: 705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbility")]
	[UnrealStructLayout(960, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UGameplayAbility : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06004CFD RID: 19709 RVA: 0x0006BBCA File Offset: 0x00069DCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbility._ClassPtr;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x0006BBD6 File Offset: 0x00069DD6
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayAbility.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x0006BBE0 File Offset: 0x00069DE0
		public UGameplayAbility() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x0006BC08 File Offset: 0x00069E08
		public UGameplayAbility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x0006BC3C File Offset: 0x00069E3C
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x0006BC75 File Offset: 0x00069E75
		public FGameplayTagContainer AbilityTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AbilityTags) == null)
				{
					result = (this._AbilityTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_AbilityTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_AbilityTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x0006BC96 File Offset: 0x00069E96
		// (set) Token: 0x06004D04 RID: 19716 RVA: 0x0006BCA6 File Offset: 0x00069EA6
		public unsafe bool bReplicateInputDirectly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bReplicateInputDirectly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bReplicateInputDirectly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0006BCB7 File Offset: 0x00069EB7
		// (set) Token: 0x06004D06 RID: 19718 RVA: 0x0006BCC7 File Offset: 0x00069EC7
		public unsafe bool RemoteInstanceEnded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_RemoteInstanceEnded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_RemoteInstanceEnded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x0006BCD8 File Offset: 0x00069ED8
		// (set) Token: 0x06004D08 RID: 19720 RVA: 0x0006BCE8 File Offset: 0x00069EE8
		public unsafe bool bServerRespectsRemoteAbilityCancellation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bServerRespectsRemoteAbilityCancellation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bServerRespectsRemoteAbilityCancellation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x0006BCF9 File Offset: 0x00069EF9
		// (set) Token: 0x06004D0A RID: 19722 RVA: 0x0006BD09 File Offset: 0x00069F09
		public unsafe bool bRetriggerInstancedAbility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bRetriggerInstancedAbility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bRetriggerInstancedAbility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x0006BD1C File Offset: 0x00069F1C
		// (set) Token: 0x06004D0C RID: 19724 RVA: 0x0006BD55 File Offset: 0x00069F55
		public FGameplayEventData CurrentEventData
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEventData result;
				if ((result = this._CurrentEventData) == null)
				{
					result = (this._CurrentEventData = new FGameplayEventData(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CurrentEventData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CurrentEventData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x0006BD78 File Offset: 0x00069F78
		// (set) Token: 0x06004D0E RID: 19726 RVA: 0x0006BDB1 File Offset: 0x00069FB1
		public TArray<FAbilityTriggerData> AbilityTriggers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAbilityTriggerData> result;
				if ((result = this._AbilityTriggers) == null)
				{
					result = (this._AbilityTriggers = new TArray<FAbilityTriggerData>(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_AbilityTriggers, this));
				}
				return result;
			}
			set
			{
				this.AbilityTriggers.CopyAssign(value);
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		// (set) Token: 0x06004D10 RID: 19728 RVA: 0x0006BDF9 File Offset: 0x00069FF9
		public FGameplayTagContainer CancelAbilitiesWithTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CancelAbilitiesWithTag) == null)
				{
					result = (this._CancelAbilitiesWithTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CancelAbilitiesWithTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CancelAbilitiesWithTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x0006BE1C File Offset: 0x0006A01C
		// (set) Token: 0x06004D12 RID: 19730 RVA: 0x0006BE55 File Offset: 0x0006A055
		public FGameplayTagContainer BlockAbilitiesWithTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BlockAbilitiesWithTag) == null)
				{
					result = (this._BlockAbilitiesWithTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_BlockAbilitiesWithTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_BlockAbilitiesWithTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06004D13 RID: 19731 RVA: 0x0006BE78 File Offset: 0x0006A078
		// (set) Token: 0x06004D14 RID: 19732 RVA: 0x0006BEB1 File Offset: 0x0006A0B1
		public FGameplayTagContainer ActivationOwnedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivationOwnedTags) == null)
				{
					result = (this._ActivationOwnedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationOwnedTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationOwnedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x0006BED4 File Offset: 0x0006A0D4
		// (set) Token: 0x06004D16 RID: 19734 RVA: 0x0006BF0D File Offset: 0x0006A10D
		public FGameplayTagContainer ActivationRequiredTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivationRequiredTags) == null)
				{
					result = (this._ActivationRequiredTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationRequiredTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationRequiredTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x0006BF30 File Offset: 0x0006A130
		// (set) Token: 0x06004D18 RID: 19736 RVA: 0x0006BF69 File Offset: 0x0006A169
		public FGameplayTagContainer ActivationBlockedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivationBlockedTags) == null)
				{
					result = (this._ActivationBlockedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationBlockedTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActivationBlockedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x0006BF8C File Offset: 0x0006A18C
		// (set) Token: 0x06004D1A RID: 19738 RVA: 0x0006BFC5 File Offset: 0x0006A1C5
		public FGameplayTagContainer SourceRequiredTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._SourceRequiredTags) == null)
				{
					result = (this._SourceRequiredTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_SourceRequiredTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_SourceRequiredTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
		// (set) Token: 0x06004D1C RID: 19740 RVA: 0x0006C021 File Offset: 0x0006A221
		public FGameplayTagContainer SourceBlockedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._SourceBlockedTags) == null)
				{
					result = (this._SourceBlockedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_SourceBlockedTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_SourceBlockedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x0006C044 File Offset: 0x0006A244
		// (set) Token: 0x06004D1E RID: 19742 RVA: 0x0006C07D File Offset: 0x0006A27D
		public FGameplayTagContainer TargetRequiredTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetRequiredTags) == null)
				{
					result = (this._TargetRequiredTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_TargetRequiredTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_TargetRequiredTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06004D1F RID: 19743 RVA: 0x0006C0A0 File Offset: 0x0006A2A0
		// (set) Token: 0x06004D20 RID: 19744 RVA: 0x0006C0D9 File Offset: 0x0006A2D9
		public FGameplayTagContainer TargetBlockedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetBlockedTags) == null)
				{
					result = (this._TargetBlockedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_TargetBlockedTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_TargetBlockedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x0006C0FC File Offset: 0x0006A2FC
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x0006C135 File Offset: 0x0006A335
		public TArray<UGameplayTask> ActiveTasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayTask> result;
				if ((result = this._ActiveTasks) == null)
				{
					result = (this._ActiveTasks = new TArray<UGameplayTask>(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ActiveTasks, this));
				}
				return result;
			}
			set
			{
				this.ActiveTasks.CopyAssign(value);
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x0006C143 File Offset: 0x0006A343
		// (set) Token: 0x06004D24 RID: 19748 RVA: 0x0006C157 File Offset: 0x0006A357
		[Nullable(2)]
		public unsafe UAnimMontage CurrentMontage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayAbility.__PropertyOffset_CurrentMontage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameplayAbility.__PropertyOffset_CurrentMontage, value);
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x0006C16C File Offset: 0x0006A36C
		// (set) Token: 0x06004D26 RID: 19750 RVA: 0x0006C17C File Offset: 0x0006A37C
		public unsafe bool bIsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x0006C18D File Offset: 0x0006A38D
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x0006C19D File Offset: 0x0006A39D
		public unsafe bool bIsCancelable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsCancelable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsCancelable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x0006C1AE File Offset: 0x0006A3AE
		// (set) Token: 0x06004D2A RID: 19754 RVA: 0x0006C1BE File Offset: 0x0006A3BE
		public unsafe bool bIsBlockingOtherAbilities
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsBlockingOtherAbilities) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bIsBlockingOtherAbilities) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x0006C1CF File Offset: 0x0006A3CF
		// (set) Token: 0x06004D2C RID: 19756 RVA: 0x0006C1DF File Offset: 0x0006A3DF
		public unsafe bool bMarkPendingKillOnAbilityEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bMarkPendingKillOnAbilityEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_bMarkPendingKillOnAbilityEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
		public void SetShouldBlockOtherAbilities(bool bShouldBlockAbilities)
		{
			UGameplayAbility.__SetShouldBlockOtherAbilities_Internal(base.NativePtr, bShouldBlockAbilities);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0006C1FE File Offset: 0x0006A3FE
		public void SetCanBeCanceled(bool bCanBeCanceled)
		{
			UGameplayAbility.__SetCanBeCanceled_Internal(base.NativePtr, bCanBeCanceled);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0006C20C File Offset: 0x0006A40C
		[NullableContext(2)]
		public void SendGameplayEvent(FGameplayTag EventTag, FGameplayEventData Payload)
		{
			UGameplayAbility.__SendGameplayEvent_Internal(base.NativePtr, EventTag, (Payload ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x0006C229 File Offset: 0x0006A429
		public void RemoveGrantedByEffect()
		{
			UGameplayAbility.__RemoveGrantedByEffect_Internal(base.NativePtr);
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x0006C236 File Offset: 0x0006A436
		public void MontageStop(float OverrideBlendOutTime = -1f)
		{
			UGameplayAbility.__MontageStop_Internal(base.NativePtr, OverrideBlendOutTime);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x0006C244 File Offset: 0x0006A444
		public void MontageSetNextSectionName(FName FromSectionName, FName ToSectionName)
		{
			UGameplayAbility.__MontageSetNextSectionName_Internal(base.NativePtr, FromSectionName, ToSectionName);
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x0006C253 File Offset: 0x0006A453
		public void MontageJumpToSection(FName SectionName)
		{
			UGameplayAbility.__MontageJumpToSection_Internal(base.NativePtr, SectionName);
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x0006C261 File Offset: 0x0006A461
		public void K2_RemoveGameplayCue(FGameplayTag GameplayCueTag)
		{
			UGameplayAbility.__K2_RemoveGameplayCue_Internal(base.NativePtr, GameplayCueTag);
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x0006C26F File Offset: 0x0006A46F
		public virtual void K2_OnEndAbility(bool bWasCancelled)
		{
			UGameplayAbility.__K2_OnEndAbility_Internal(base.NativePtr, bWasCancelled);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x0006C27D File Offset: 0x0006A47D
		public bool K2_HasAuthority()
		{
			return UGameplayAbility.__K2_HasAuthority_Internal(base.NativePtr);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x0006C28A File Offset: 0x0006A48A
		public void K2_EndAbility()
		{
			UGameplayAbility.__K2_EndAbility_Internal(base.NativePtr);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x0006C297 File Offset: 0x0006A497
		public virtual void K2_CommitExecute()
		{
			UGameplayAbility.__K2_CommitExecute_Internal(base.NativePtr);
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		public bool K2_CommitAbilityCost(bool BroadcastCommitEvent = false)
		{
			return UGameplayAbility.__K2_CommitAbilityCost_Internal(base.NativePtr, BroadcastCommitEvent);
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x0006C2B2 File Offset: 0x0006A4B2
		public bool K2_CommitAbilityCooldown(bool BroadcastCommitEvent = false, bool ForceCooldown = false)
		{
			return UGameplayAbility.__K2_CommitAbilityCooldown_Internal(base.NativePtr, BroadcastCommitEvent, ForceCooldown);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x0006C2C1 File Offset: 0x0006A4C1
		public bool K2_CommitAbility()
		{
			return UGameplayAbility.__K2_CommitAbility_Internal(base.NativePtr);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x0006C2CE File Offset: 0x0006A4CE
		public bool K2_CheckAbilityCost()
		{
			return UGameplayAbility.__K2_CheckAbilityCost_Internal(base.NativePtr);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x0006C2DB File Offset: 0x0006A4DB
		public bool K2_CheckAbilityCooldown()
		{
			return UGameplayAbility.__K2_CheckAbilityCooldown_Internal(base.NativePtr);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x0006C2E8 File Offset: 0x0006A4E8
		public void K2_CancelAbility()
		{
			UGameplayAbility.__K2_CancelAbility_Internal(base.NativePtr);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x0006C2F5 File Offset: 0x0006A4F5
		[NullableContext(2)]
		public virtual void K2_ActivateAbilityFromEvent(in FGameplayEventData EventData)
		{
			UGameplayAbility.__K2_ActivateAbilityFromEvent_Internal(base.NativePtr, (EventData ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x0006C312 File Offset: 0x0006A512
		public virtual void K2_ActivateAbility()
		{
			UGameplayAbility.__K2_ActivateAbility_Internal(base.NativePtr);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x0006C31F File Offset: 0x0006A51F
		public bool IsLocallyControlled()
		{
			return UGameplayAbility.__IsLocallyControlled_Internal(base.NativePtr);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x0006C32C File Offset: 0x0006A52C
		public void InvalidateClientPredictionKey()
		{
			UGameplayAbility.__InvalidateClientPredictionKey_Internal(base.NativePtr);
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x0006C339 File Offset: 0x0006A539
		[NullableContext(2)]
		public USkeletalMeshComponent GetOwningComponentFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UGameplayAbility.__GetOwningComponentFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x0006C34B File Offset: 0x0006A54B
		[NullableContext(2)]
		public AActor GetOwningActorFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayAbility.__GetOwningActorFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x0006C35D File Offset: 0x0006A55D
		[NullableContext(2)]
		public UObject GetCurrentSourceObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UGameplayAbility.__GetCurrentSourceObject_Internal(base.NativePtr));
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x0006C36F File Offset: 0x0006A56F
		[NullableContext(2)]
		public UAnimMontage GetCurrentMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UGameplayAbility.__GetCurrentMontage_Internal(base.NativePtr));
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x0006C381 File Offset: 0x0006A581
		public float GetCooldownTimeRemaining()
		{
			return UGameplayAbility.__GetCooldownTimeRemaining_Internal(base.NativePtr);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x0006C38E File Offset: 0x0006A58E
		[NullableContext(2)]
		public AActor GetAvatarActorFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayAbility.__GetAvatarActorFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x0006C3A0 File Offset: 0x0006A5A0
		[NullableContext(2)]
		public UAbilitySystemComponent GetAbilitySystemComponentFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilitySystemComponent>(UGameplayAbility.__GetAbilitySystemComponentFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x0006C3B2 File Offset: 0x0006A5B2
		public int GetAbilityLevel()
		{
			return UGameplayAbility.__GetAbilityLevel_Internal(base.NativePtr);
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x0006C3BF File Offset: 0x0006A5BF
		public void EndTaskByInstanceName(FName InstanceName)
		{
			UGameplayAbility.__EndTaskByInstanceName_Internal(base.NativePtr, InstanceName);
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x0006C3CD File Offset: 0x0006A5CD
		public void EndAbilityState(FName OptionalStateNameToEnd)
		{
			UGameplayAbility.__EndAbilityState_Internal(base.NativePtr, OptionalStateNameToEnd);
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x0006C3DB File Offset: 0x0006A5DB
		public void ConfirmTaskByInstanceName(FName InstanceName, bool bEndTask)
		{
			UGameplayAbility.__ConfirmTaskByInstanceName_Internal(base.NativePtr, InstanceName, bEndTask);
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x0006C3EA File Offset: 0x0006A5EA
		public void CancelTaskByInstanceName(FName InstanceName)
		{
			UGameplayAbility.__CancelTaskByInstanceName_Internal(base.NativePtr, InstanceName);
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0006C3F8 File Offset: 0x0006A5F8
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithHandle(FActiveGameplayEffectHandle Handle, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithHandle_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, StacksToRemove);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0006C415 File Offset: 0x0006A615
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithGrantedTags(FGameplayTagContainer WithGrantedTags, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithGrantedTags_Internal(base.NativePtr, (WithGrantedTags ?? new FGameplayTagContainer()).NativePtr, StacksToRemove);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x0006C432 File Offset: 0x0006A632
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithAssetTags(FGameplayTagContainer WithAssetTags, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithAssetTags_Internal(base.NativePtr, (WithAssetTags ?? new FGameplayTagContainer()).NativePtr, StacksToRemove);
		}

		// Token: 0x06004D52 RID: 19794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBlockOtherAbilities_Internal(IntPtr @this, bool bShouldBlockAbilities);

		// Token: 0x06004D53 RID: 19795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanBeCanceled_Internal(IntPtr @this, bool bCanBeCanceled);

		// Token: 0x06004D54 RID: 19796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendGameplayEvent_Internal(IntPtr @this, FGameplayTag EventTag, IntPtr Payload);

		// Token: 0x06004D55 RID: 19797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveGrantedByEffect_Internal(IntPtr @this);

		// Token: 0x06004D56 RID: 19798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageStop_Internal(IntPtr @this, float OverrideBlendOutTime);

		// Token: 0x06004D57 RID: 19799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageSetNextSectionName_Internal(IntPtr @this, FName FromSectionName, FName ToSectionName);

		// Token: 0x06004D58 RID: 19800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageJumpToSection_Internal(IntPtr @this, FName SectionName);

		// Token: 0x06004D59 RID: 19801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_RemoveGameplayCue_Internal(IntPtr @this, FGameplayTag GameplayCueTag);

		// Token: 0x06004D5A RID: 19802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndAbility_Internal(IntPtr @this, bool bWasCancelled);

		// Token: 0x06004D5B RID: 19803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_HasAuthority_Internal(IntPtr @this);

		// Token: 0x06004D5C RID: 19804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_EndAbility_Internal(IntPtr @this);

		// Token: 0x06004D5D RID: 19805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CommitExecute_Internal(IntPtr @this);

		// Token: 0x06004D5E RID: 19806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbilityCost_Internal(IntPtr @this, bool BroadcastCommitEvent);

		// Token: 0x06004D5F RID: 19807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbilityCooldown_Internal(IntPtr @this, bool BroadcastCommitEvent, bool ForceCooldown);

		// Token: 0x06004D60 RID: 19808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbility_Internal(IntPtr @this);

		// Token: 0x06004D61 RID: 19809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CheckAbilityCost_Internal(IntPtr @this);

		// Token: 0x06004D62 RID: 19810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CheckAbilityCooldown_Internal(IntPtr @this);

		// Token: 0x06004D63 RID: 19811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CancelAbility_Internal(IntPtr @this);

		// Token: 0x06004D64 RID: 19812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ActivateAbilityFromEvent_Internal(IntPtr @this, IntPtr EventData);

		// Token: 0x06004D65 RID: 19813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ActivateAbility_Internal(IntPtr @this);

		// Token: 0x06004D66 RID: 19814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocallyControlled_Internal(IntPtr @this);

		// Token: 0x06004D67 RID: 19815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvalidateClientPredictionKey_Internal(IntPtr @this);

		// Token: 0x06004D68 RID: 19816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningComponentFromActorInfo_Internal(IntPtr @this);

		// Token: 0x06004D69 RID: 19817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningActorFromActorInfo_Internal(IntPtr @this);

		// Token: 0x06004D6A RID: 19818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentSourceObject_Internal(IntPtr @this);

		// Token: 0x06004D6B RID: 19819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentMontage_Internal(IntPtr @this);

		// Token: 0x06004D6C RID: 19820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCooldownTimeRemaining_Internal(IntPtr @this);

		// Token: 0x06004D6D RID: 19821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAvatarActorFromActorInfo_Internal(IntPtr @this);

		// Token: 0x06004D6E RID: 19822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAbilitySystemComponentFromActorInfo_Internal(IntPtr @this);

		// Token: 0x06004D6F RID: 19823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAbilityLevel_Internal(IntPtr @this);

		// Token: 0x06004D70 RID: 19824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTaskByInstanceName_Internal(IntPtr @this, FName InstanceName);

		// Token: 0x06004D71 RID: 19825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndAbilityState_Internal(IntPtr @this, FName OptionalStateNameToEnd);

		// Token: 0x06004D72 RID: 19826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmTaskByInstanceName_Internal(IntPtr @this, FName InstanceName, bool bEndTask);

		// Token: 0x06004D73 RID: 19827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelTaskByInstanceName_Internal(IntPtr @this, FName InstanceName);

		// Token: 0x06004D74 RID: 19828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithHandle_Internal(IntPtr @this, IntPtr Handle, int StacksToRemove);

		// Token: 0x06004D75 RID: 19829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithGrantedTags_Internal(IntPtr @this, IntPtr WithGrantedTags, int StacksToRemove);

		// Token: 0x06004D76 RID: 19830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithAssetTags_Internal(IntPtr @this, IntPtr WithAssetTags, int StacksToRemove);

		// Token: 0x06004D77 RID: 19831 RVA: 0x0006C44F File Offset: 0x0006A64F
		static UGameplayAbility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbility");
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x0006C45D File Offset: 0x0006A65D
		protected UGameplayAbility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001EC1 RID: 7873
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04001EC2 RID: 7874
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbility";

		// Token: 0x04001EC3 RID: 7875
		private static IntPtr _ClassPtr;

		// Token: 0x04001EC4 RID: 7876
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001EC5 RID: 7877
		internal static int __PropertyOffset_AbilityTags;

		// Token: 0x04001EC6 RID: 7878
		[Nullable(2)]
		private FGameplayTagContainer _AbilityTags;

		// Token: 0x04001EC7 RID: 7879
		internal static int __PropertyOffset_bReplicateInputDirectly;

		// Token: 0x04001EC8 RID: 7880
		internal static int __PropertyOffset_RemoteInstanceEnded;

		// Token: 0x04001EC9 RID: 7881
		internal static int __PropertyOffset_bServerRespectsRemoteAbilityCancellation;

		// Token: 0x04001ECA RID: 7882
		internal static int __PropertyOffset_bRetriggerInstancedAbility;

		// Token: 0x04001ECB RID: 7883
		internal static int __PropertyOffset_CurrentEventData;

		// Token: 0x04001ECC RID: 7884
		[Nullable(2)]
		private FGameplayEventData _CurrentEventData;

		// Token: 0x04001ECD RID: 7885
		internal static int __PropertyOffset_AbilityTriggers;

		// Token: 0x04001ECE RID: 7886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAbilityTriggerData> _AbilityTriggers;

		// Token: 0x04001ECF RID: 7887
		internal static int __PropertyOffset_CancelAbilitiesWithTag;

		// Token: 0x04001ED0 RID: 7888
		[Nullable(2)]
		private FGameplayTagContainer _CancelAbilitiesWithTag;

		// Token: 0x04001ED1 RID: 7889
		internal static int __PropertyOffset_BlockAbilitiesWithTag;

		// Token: 0x04001ED2 RID: 7890
		[Nullable(2)]
		private FGameplayTagContainer _BlockAbilitiesWithTag;

		// Token: 0x04001ED3 RID: 7891
		internal static int __PropertyOffset_ActivationOwnedTags;

		// Token: 0x04001ED4 RID: 7892
		[Nullable(2)]
		private FGameplayTagContainer _ActivationOwnedTags;

		// Token: 0x04001ED5 RID: 7893
		internal static int __PropertyOffset_ActivationRequiredTags;

		// Token: 0x04001ED6 RID: 7894
		[Nullable(2)]
		private FGameplayTagContainer _ActivationRequiredTags;

		// Token: 0x04001ED7 RID: 7895
		internal static int __PropertyOffset_ActivationBlockedTags;

		// Token: 0x04001ED8 RID: 7896
		[Nullable(2)]
		private FGameplayTagContainer _ActivationBlockedTags;

		// Token: 0x04001ED9 RID: 7897
		internal static int __PropertyOffset_SourceRequiredTags;

		// Token: 0x04001EDA RID: 7898
		[Nullable(2)]
		private FGameplayTagContainer _SourceRequiredTags;

		// Token: 0x04001EDB RID: 7899
		internal static int __PropertyOffset_SourceBlockedTags;

		// Token: 0x04001EDC RID: 7900
		[Nullable(2)]
		private FGameplayTagContainer _SourceBlockedTags;

		// Token: 0x04001EDD RID: 7901
		internal static int __PropertyOffset_TargetRequiredTags;

		// Token: 0x04001EDE RID: 7902
		[Nullable(2)]
		private FGameplayTagContainer _TargetRequiredTags;

		// Token: 0x04001EDF RID: 7903
		internal static int __PropertyOffset_TargetBlockedTags;

		// Token: 0x04001EE0 RID: 7904
		[Nullable(2)]
		private FGameplayTagContainer _TargetBlockedTags;

		// Token: 0x04001EE1 RID: 7905
		internal static int __PropertyOffset_ActiveTasks;

		// Token: 0x04001EE2 RID: 7906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _ActiveTasks;

		// Token: 0x04001EE3 RID: 7907
		internal static int __PropertyOffset_CurrentMontage;

		// Token: 0x04001EE4 RID: 7908
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x04001EE5 RID: 7909
		internal static int __PropertyOffset_bIsCancelable;

		// Token: 0x04001EE6 RID: 7910
		internal static int __PropertyOffset_bIsBlockingOtherAbilities;

		// Token: 0x04001EE7 RID: 7911
		internal static int __PropertyOffset_bMarkPendingKillOnAbilityEnd;

		// Token: 0x020009FA RID: 2554
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0400599F RID: 22943
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x020009FB RID: 2555
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __K2_ActivateAbilityFromEvent_FunctionParams
		{
			// Token: 0x040059A0 RID: 22944
			[FieldOffset(0)]
			public byte EventData;
		}
	}
}
