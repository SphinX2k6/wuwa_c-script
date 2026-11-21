using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002BB RID: 699
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemComponent")]
	[UnrealStructLayout(5024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5024)]
	public class UAbilitySystemComponent : UGameplayTasksComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004C6E RID: 19566 RVA: 0x0006B2BC File Offset: 0x000694BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemComponent._ClassPtr;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x0006B2C8 File Offset: 0x000694C8
		public UAbilitySystemComponent() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x0006B2F0 File Offset: 0x000694F0
		public UAbilitySystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x0006B324 File Offset: 0x00069524
		// (set) Token: 0x06004C72 RID: 19570 RVA: 0x0006B35D File Offset: 0x0006955D
		public TArray<UAttributeSet> SpawnedAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAttributeSet> result;
				if ((result = this._SpawnedAttributes) == null)
				{
					result = (this._SpawnedAttributes = new TArray<UAttributeSet>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_SpawnedAttributes, this));
				}
				return result;
			}
			set
			{
				this.SpawnedAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x0006B36B File Offset: 0x0006956B
		// (set) Token: 0x06004C74 RID: 19572 RVA: 0x0006B37F File Offset: 0x0006957F
		public unsafe FName AffectedAnimInstanceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_AffectedAnimInstanceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_AffectedAnimInstanceTag) = value;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x0006B394 File Offset: 0x00069594
		// (set) Token: 0x06004C76 RID: 19574 RVA: 0x0006B3A4 File Offset: 0x000695A4
		public unsafe float OutgoingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_OutgoingDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_OutgoingDuration) = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x0006B3B5 File Offset: 0x000695B5
		// (set) Token: 0x06004C78 RID: 19576 RVA: 0x0006B3C5 File Offset: 0x000695C5
		public unsafe float IncomingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_IncomingDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_IncomingDuration) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x0006B3D8 File Offset: 0x000695D8
		// (set) Token: 0x06004C7A RID: 19578 RVA: 0x0006B411 File Offset: 0x00069611
		public TArray<string> ClientDebugStrings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ClientDebugStrings) == null)
				{
					result = (this._ClientDebugStrings = new TArray<string>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ClientDebugStrings, this));
				}
				return result;
			}
			set
			{
				this.ClientDebugStrings.CopyAssign(value);
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x0006B420 File Offset: 0x00069620
		// (set) Token: 0x06004C7C RID: 19580 RVA: 0x0006B459 File Offset: 0x00069659
		public TArray<string> ServerDebugStrings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ServerDebugStrings) == null)
				{
					result = (this._ServerDebugStrings = new TArray<string>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ServerDebugStrings, this));
				}
				return result;
			}
			set
			{
				this.ServerDebugStrings.CopyAssign(value);
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x0006B467 File Offset: 0x00069667
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x0006B477 File Offset: 0x00069677
		public unsafe bool UserAbilityActivationInhibited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_UserAbilityActivationInhibited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_UserAbilityActivationInhibited) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x0006B488 File Offset: 0x00069688
		// (set) Token: 0x06004C80 RID: 19584 RVA: 0x0006B498 File Offset: 0x00069698
		public unsafe bool ReplicationProxyEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ReplicationProxyEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ReplicationProxyEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x0006B4A9 File Offset: 0x000696A9
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x0006B4B9 File Offset: 0x000696B9
		public unsafe bool bSuppressGrantAbility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bSuppressGrantAbility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bSuppressGrantAbility) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x0006B4CA File Offset: 0x000696CA
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x0006B4DA File Offset: 0x000696DA
		public unsafe bool bSuppressGameplayCues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bSuppressGameplayCues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bSuppressGameplayCues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x0006B4EB File Offset: 0x000696EB
		// (set) Token: 0x06004C86 RID: 19590 RVA: 0x0006B4FF File Offset: 0x000696FF
		[Nullable(2)]
		public unsafe AActor OwnerActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_OwnerActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_OwnerActor, value);
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x0006B514 File Offset: 0x00069714
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x0006B528 File Offset: 0x00069728
		[Nullable(2)]
		public unsafe AActor AvatarActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_AvatarActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_AvatarActor, value);
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x0006B540 File Offset: 0x00069740
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x0006B579 File Offset: 0x00069779
		public TArray<UGameplayAbility> AllReplicatedInstancedAbilities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayAbility> result;
				if ((result = this._AllReplicatedInstancedAbilities) == null)
				{
					result = (this._AllReplicatedInstancedAbilities = new TArray<UGameplayAbility>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_AllReplicatedInstancedAbilities, this));
				}
				return result;
			}
			set
			{
				this.AllReplicatedInstancedAbilities.CopyAssign(value);
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x0006B587 File Offset: 0x00069787
		// (set) Token: 0x06004C8C RID: 19596 RVA: 0x0006B597 File Offset: 0x00069797
		public unsafe bool bCachedIsNetSimulated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bCachedIsNetSimulated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bCachedIsNetSimulated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06004C8D RID: 19597 RVA: 0x0006B5A8 File Offset: 0x000697A8
		// (set) Token: 0x06004C8E RID: 19598 RVA: 0x0006B5B8 File Offset: 0x000697B8
		public unsafe bool bPendingMontageRep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bPendingMontageRep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_bPendingMontageRep) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x0006B5CC File Offset: 0x000697CC
		// (set) Token: 0x06004C90 RID: 19600 RVA: 0x0006B605 File Offset: 0x00069805
		public FGameplayAbilityLocalAnimMontage LocalAnimMontageInfo
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityLocalAnimMontage result;
				if ((result = this._LocalAnimMontageInfo) == null)
				{
					result = (this._LocalAnimMontageInfo = new FGameplayAbilityLocalAnimMontage(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_LocalAnimMontageInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityLocalAnimMontage.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_LocalAnimMontageInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x0006B628 File Offset: 0x00069828
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x0006B661 File Offset: 0x00069861
		public TArray<byte> BlockedAbilityBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BlockedAbilityBindings) == null)
				{
					result = (this._BlockedAbilityBindings = new TArray<byte>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_BlockedAbilityBindings, this));
				}
				return result;
			}
			set
			{
				this.BlockedAbilityBindings.CopyAssign(value);
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x0006B670 File Offset: 0x00069870
		// (set) Token: 0x06004C94 RID: 19604 RVA: 0x0006B6A9 File Offset: 0x000698A9
		public FTagUpdated TagUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FTagUpdated result;
				if ((result = this._TagUpdated) == null)
				{
					result = (this._TagUpdated = new FTagUpdated(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_TagUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_TagUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x0006B6CA File Offset: 0x000698CA
		public void UpdateTagMap(in FGameplayTag BaseTag, int CountDelta)
		{
			UAbilitySystemComponent.__UpdateTagMap_Internal(base.NativePtr, BaseTag, CountDelta);
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x0006B6D9 File Offset: 0x000698D9
		public bool TryActivateAbilityByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayAbility> InAbilityToActivate, bool bAllowRemoteActivation = true)
		{
			return UAbilitySystemComponent.__TryActivateAbilityByClass_Internal(base.NativePtr, InAbilityToActivate._NativePtr, bAllowRemoteActivation);
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x0006B6ED File Offset: 0x000698ED
		[NullableContext(2)]
		public bool TryActivateAbilitiesByTag(in FGameplayTagContainer GameplayTagContainer, bool bAllowRemoteActivation = true)
		{
			return UAbilitySystemComponent.__TryActivateAbilitiesByTag_Internal(base.NativePtr, (GameplayTagContainer ?? new FGameplayTagContainer()).NativePtr, bAllowRemoteActivation);
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x0006B70B File Offset: 0x0006990B
		public void TargetConfirm()
		{
			UAbilitySystemComponent.__TargetConfirm_Internal(base.NativePtr);
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x0006B718 File Offset: 0x00069918
		public void TargetCancel()
		{
			UAbilitySystemComponent.__TargetCancel_Internal(base.NativePtr);
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x0006B725 File Offset: 0x00069925
		public void SetUserAbilityActivationInhibited(bool NewInhibit)
		{
			UAbilitySystemComponent.__SetUserAbilityActivationInhibited_Internal(base.NativePtr, NewInhibit);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x0006B733 File Offset: 0x00069933
		public void SetTagMapCount(in FGameplayTag Tag, int NewCount, bool NeedNotify = true)
		{
			UAbilitySystemComponent.__SetTagMapCount_Internal(base.NativePtr, Tag, NewCount, NeedNotify);
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x0006B743 File Offset: 0x00069943
		public void SetRemoteGameplayEffectInhibition(int HandleId, bool bShouldBeInhibited)
		{
			UAbilitySystemComponent.__SetRemoteGameplayEffectInhibition_Internal(base.NativePtr, HandleId, bShouldBeInhibited);
		}

		// Token: 0x06004C9D RID: 19613
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGeHandleStart(int HandleIdStart);

		// Token: 0x06004C9E RID: 19614
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGeHandleIdPrefix(int InHandleIdPrefix);

		// Token: 0x06004C9F RID: 19615 RVA: 0x0006B752 File Offset: 0x00069952
		[NullableContext(2)]
		public void SetActiveGameplayEffectLevel(FActiveGameplayEffectHandle ActiveHandle, int NewLevel)
		{
			UAbilitySystemComponent.__SetActiveGameplayEffectLevel_Internal(base.NativePtr, (ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr, NewLevel);
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x0006B76F File Offset: 0x0006996F
		[NullableContext(2)]
		public void ServerSetInputReleased(FGameplayAbilitySpecHandle AbilityHandle)
		{
			UAbilitySystemComponent.__ServerSetInputReleased_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x0006B78B File Offset: 0x0006998B
		[NullableContext(2)]
		public void ServerSetInputPressed(FGameplayAbilitySpecHandle AbilityHandle)
		{
			UAbilitySystemComponent.__ServerSetInputPressed_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x0006B7A7 File Offset: 0x000699A7
		public void ServerPrintDebug_RequestWithStrings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Strings)
		{
			UAbilitySystemComponent.__ServerPrintDebug_RequestWithStrings_Internal(base.NativePtr, (Strings ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x0006B7C4 File Offset: 0x000699C4
		public void ServerPrintDebug_Request()
		{
			UAbilitySystemComponent.__ServerPrintDebug_Request_Internal(base.NativePtr);
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x0006B7D1 File Offset: 0x000699D1
		[NullableContext(2)]
		public void ServerCurrentMontageSetPlayRate(UAnimMontage ClientAnimMontage, float InPlayRate)
		{
			UAbilitySystemComponent.__ServerCurrentMontageSetPlayRate_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, InPlayRate);
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x0006B7EF File Offset: 0x000699EF
		[NullableContext(2)]
		public void ServerCurrentMontageSetNextSectionName(UAnimMontage ClientAnimMontage, float ClientPosition, FName SectionName, FName NextSectionName)
		{
			UAbilitySystemComponent.__ServerCurrentMontageSetNextSectionName_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, ClientPosition, SectionName, NextSectionName);
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x0006B810 File Offset: 0x00069A10
		[NullableContext(2)]
		public void ServerCurrentMontageJumpToSectionName(UAnimMontage ClientAnimMontage, FName SectionName)
		{
			UAbilitySystemComponent.__ServerCurrentMontageJumpToSectionName_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, SectionName);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x0006B82E File Offset: 0x00069A2E
		public void ResetTagMap()
		{
			UAbilitySystemComponent.__ResetTagMap_Internal(base.NativePtr);
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x0006B83B File Offset: 0x00069A3B
		[NullableContext(2)]
		public bool RemoveActiveGameplayEffect(FActiveGameplayEffectHandle Handle, int StacksToRemove = -1)
		{
			return UAbilitySystemComponent.__RemoveActiveGameplayEffect_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, StacksToRemove);
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x0006B858 File Offset: 0x00069A58
		[NullableContext(2)]
		public int RemoveActiveEffectsWithTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x0006B874 File Offset: 0x00069A74
		[NullableContext(2)]
		public int RemoveActiveEffectsWithSourceTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithSourceTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x0006B890 File Offset: 0x00069A90
		[NullableContext(2)]
		public int RemoveActiveEffectsWithGrantedTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithGrantedTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x0006B8AC File Offset: 0x00069AAC
		[NullableContext(2)]
		public int RemoveActiveEffectsWithAppliedTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithAppliedTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		public void OnTagUpdated(in FGameplayTag Tag, bool TagExists, int CountDelta)
		{
			UAbilitySystemComponent.__OnTagUpdated_Internal(base.NativePtr, Tag, TagExists, CountDelta);
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x0006B8D8 File Offset: 0x00069AD8
		public void OnRep_ServerDebugString()
		{
			UAbilitySystemComponent.__OnRep_ServerDebugString_Internal(base.NativePtr);
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x0006B8E5 File Offset: 0x00069AE5
		public void OnRep_ReplicatedAnimMontage()
		{
			UAbilitySystemComponent.__OnRep_ReplicatedAnimMontage_Internal(base.NativePtr);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x0006B8F2 File Offset: 0x00069AF2
		public void OnRep_OwningActor()
		{
			UAbilitySystemComponent.__OnRep_OwningActor_Internal(base.NativePtr);
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x0006B8FF File Offset: 0x00069AFF
		public void OnRep_ClientDebugString()
		{
			UAbilitySystemComponent.__OnRep_ClientDebugString_Internal(base.NativePtr);
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x0006B90C File Offset: 0x00069B0C
		public void OnRep_ActivateAbilities()
		{
			UAbilitySystemComponent.__OnRep_ActivateAbilities_Internal(base.NativePtr);
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x0006B919 File Offset: 0x00069B19
		[NullableContext(2)]
		public void K2_InitStats([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAttributeSet> Attributes, UDataTable DataTable)
		{
			UAbilitySystemComponent.__K2_InitStats_Internal(base.NativePtr, Attributes._NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x0006B93C File Offset: 0x00069B3C
		public bool IsGameplayCueActive(FGameplayTag GameplayCueTag)
		{
			return UAbilitySystemComponent.__IsGameplayCueActive_Internal(base.NativePtr, GameplayCueTag);
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x0006B94A File Offset: 0x00069B4A
		public bool GetUserAbilityActivationInhibited()
		{
			return UAbilitySystemComponent.__GetUserAbilityActivationInhibited_Internal(base.NativePtr);
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x0006B957 File Offset: 0x00069B57
		public int GetTagCount(FGameplayTag TagToCheck)
		{
			return UAbilitySystemComponent.__GetTagCount_Internal(base.NativePtr, TagToCheck);
		}

		// Token: 0x06004CB7 RID: 19639
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGeHandleIdPrefix();

		// Token: 0x06004CB8 RID: 19640 RVA: 0x0006B965 File Offset: 0x00069B65
		public TArray<FActiveGameplayEffectHandle> GetActiveEffectsWithAllTags([Nullable(2)] FGameplayTagContainer Tags)
		{
			return new TArray<FActiveGameplayEffectHandle>(UAbilitySystemComponent.__GetActiveEffectsWithAllTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr), null);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x0006B987 File Offset: 0x00069B87
		[NullableContext(2)]
		public void ClientTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate)
		{
			UAbilitySystemComponent.__ClientTryActivateAbility_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x0006B9A3 File Offset: 0x00069BA3
		public void ClientPrintDebug_Response([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Strings, int GameFlags)
		{
			UAbilitySystemComponent.__ClientPrintDebug_Response_Internal(base.NativePtr, (Strings ?? new TArray<string>()).NativePtr, GameFlags);
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x0006B9C1 File Offset: 0x00069BC1
		[NullableContext(2)]
		public void ClientActivateAbilityFailed(FGameplayAbilitySpecHandle AbilityToActivate, short PredictionKey)
		{
			UAbilitySystemComponent.__ClientActivateAbilityFailed_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, PredictionKey);
		}

		// Token: 0x06004CBC RID: 19644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateTagMap_Internal(IntPtr @this, in FGameplayTag BaseTag, int CountDelta);

		// Token: 0x06004CBD RID: 19645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryActivateAbilityByClass_Internal(IntPtr @this, IntPtr InAbilityToActivate, bool bAllowRemoteActivation);

		// Token: 0x06004CBE RID: 19646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryActivateAbilitiesByTag_Internal(IntPtr @this, IntPtr GameplayTagContainer, bool bAllowRemoteActivation);

		// Token: 0x06004CBF RID: 19647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TargetConfirm_Internal(IntPtr @this);

		// Token: 0x06004CC0 RID: 19648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TargetCancel_Internal(IntPtr @this);

		// Token: 0x06004CC1 RID: 19649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserAbilityActivationInhibited_Internal(IntPtr @this, bool NewInhibit);

		// Token: 0x06004CC2 RID: 19650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTagMapCount_Internal(IntPtr @this, in FGameplayTag Tag, int NewCount, bool NeedNotify);

		// Token: 0x06004CC3 RID: 19651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRemoteGameplayEffectInhibition_Internal(IntPtr @this, int HandleId, bool bShouldBeInhibited);

		// Token: 0x06004CC4 RID: 19652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActiveGameplayEffectLevel_Internal(IntPtr @this, IntPtr ActiveHandle, int NewLevel);

		// Token: 0x06004CC5 RID: 19653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetInputReleased_Internal(IntPtr @this, IntPtr AbilityHandle);

		// Token: 0x06004CC6 RID: 19654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetInputPressed_Internal(IntPtr @this, IntPtr AbilityHandle);

		// Token: 0x06004CC7 RID: 19655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPrintDebug_RequestWithStrings_Internal(IntPtr @this, IntPtr Strings);

		// Token: 0x06004CC8 RID: 19656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPrintDebug_Request_Internal(IntPtr @this);

		// Token: 0x06004CC9 RID: 19657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageSetPlayRate_Internal(IntPtr @this, IntPtr ClientAnimMontage, float InPlayRate);

		// Token: 0x06004CCA RID: 19658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageSetNextSectionName_Internal(IntPtr @this, IntPtr ClientAnimMontage, float ClientPosition, FName SectionName, FName NextSectionName);

		// Token: 0x06004CCB RID: 19659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageJumpToSectionName_Internal(IntPtr @this, IntPtr ClientAnimMontage, FName SectionName);

		// Token: 0x06004CCC RID: 19660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetTagMap_Internal(IntPtr @this);

		// Token: 0x06004CCD RID: 19661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveActiveGameplayEffect_Internal(IntPtr @this, IntPtr Handle, int StacksToRemove);

		// Token: 0x06004CCE RID: 19662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06004CCF RID: 19663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithSourceTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06004CD0 RID: 19664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithGrantedTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06004CD1 RID: 19665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithAppliedTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06004CD2 RID: 19666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagUpdated_Internal(IntPtr @this, in FGameplayTag Tag, bool TagExists, int CountDelta);

		// Token: 0x06004CD3 RID: 19667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ServerDebugString_Internal(IntPtr @this);

		// Token: 0x06004CD4 RID: 19668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedAnimMontage_Internal(IntPtr @this);

		// Token: 0x06004CD5 RID: 19669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_OwningActor_Internal(IntPtr @this);

		// Token: 0x06004CD6 RID: 19670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ClientDebugString_Internal(IntPtr @this);

		// Token: 0x06004CD7 RID: 19671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ActivateAbilities_Internal(IntPtr @this);

		// Token: 0x06004CD8 RID: 19672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_InitStats_Internal(IntPtr @this, IntPtr Attributes, IntPtr DataTable);

		// Token: 0x06004CD9 RID: 19673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGameplayCueActive_Internal(IntPtr @this, FGameplayTag GameplayCueTag);

		// Token: 0x06004CDA RID: 19674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUserAbilityActivationInhibited_Internal(IntPtr @this);

		// Token: 0x06004CDB RID: 19675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTagCount_Internal(IntPtr @this, FGameplayTag TagToCheck);

		// Token: 0x06004CDC RID: 19676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveEffectsWithAllTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06004CDD RID: 19677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTryActivateAbility_Internal(IntPtr @this, IntPtr AbilityToActivate);

		// Token: 0x06004CDE RID: 19678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrintDebug_Response_Internal(IntPtr @this, IntPtr Strings, int GameFlags);

		// Token: 0x06004CDF RID: 19679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientActivateAbilityFailed_Internal(IntPtr @this, IntPtr AbilityToActivate, short PredictionKey);

		// Token: 0x06004CE0 RID: 19680 RVA: 0x0006B9DE File Offset: 0x00069BDE
		static UAbilitySystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemComponent");
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x0006B9EC File Offset: 0x00069BEC
		protected UAbilitySystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E8C RID: 7820
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemComponent";

		// Token: 0x04001E8D RID: 7821
		private static IntPtr _ClassPtr;

		// Token: 0x04001E8E RID: 7822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001E8F RID: 7823
		public static IntPtr __AbilityConfirmOrCancel__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04001E90 RID: 7824
		public static IntPtr __AbilityAbilityKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04001E91 RID: 7825
		internal static int __PropertyOffset_SpawnedAttributes;

		// Token: 0x04001E92 RID: 7826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAttributeSet> _SpawnedAttributes;

		// Token: 0x04001E93 RID: 7827
		internal static int __PropertyOffset_AffectedAnimInstanceTag;

		// Token: 0x04001E94 RID: 7828
		internal static int __PropertyOffset_OutgoingDuration;

		// Token: 0x04001E95 RID: 7829
		internal static int __PropertyOffset_IncomingDuration;

		// Token: 0x04001E96 RID: 7830
		internal static int __PropertyOffset_ClientDebugStrings;

		// Token: 0x04001E97 RID: 7831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ClientDebugStrings;

		// Token: 0x04001E98 RID: 7832
		internal static int __PropertyOffset_ServerDebugStrings;

		// Token: 0x04001E99 RID: 7833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ServerDebugStrings;

		// Token: 0x04001E9A RID: 7834
		internal static int __PropertyOffset_UserAbilityActivationInhibited;

		// Token: 0x04001E9B RID: 7835
		internal static int __PropertyOffset_ReplicationProxyEnabled;

		// Token: 0x04001E9C RID: 7836
		internal static int __PropertyOffset_bSuppressGrantAbility;

		// Token: 0x04001E9D RID: 7837
		internal static int __PropertyOffset_bSuppressGameplayCues;

		// Token: 0x04001E9E RID: 7838
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x04001E9F RID: 7839
		internal static int __PropertyOffset_AvatarActor;

		// Token: 0x04001EA0 RID: 7840
		internal static int __PropertyOffset_AllReplicatedInstancedAbilities;

		// Token: 0x04001EA1 RID: 7841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayAbility> _AllReplicatedInstancedAbilities;

		// Token: 0x04001EA2 RID: 7842
		internal static int __PropertyOffset_bCachedIsNetSimulated;

		// Token: 0x04001EA3 RID: 7843
		internal static int __PropertyOffset_bPendingMontageRep;

		// Token: 0x04001EA4 RID: 7844
		internal static int __PropertyOffset_LocalAnimMontageInfo;

		// Token: 0x04001EA5 RID: 7845
		[Nullable(2)]
		private FGameplayAbilityLocalAnimMontage _LocalAnimMontageInfo;

		// Token: 0x04001EA6 RID: 7846
		internal static int __PropertyOffset_BlockedAbilityBindings;

		// Token: 0x04001EA7 RID: 7847
		[Nullable(2)]
		private TArray<byte> _BlockedAbilityBindings;

		// Token: 0x04001EA8 RID: 7848
		internal static int __PropertyOffset_TagUpdated;

		// Token: 0x04001EA9 RID: 7849
		[Nullable(2)]
		private FTagUpdated _TagUpdated;
	}
}
