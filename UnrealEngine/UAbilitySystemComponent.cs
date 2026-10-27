using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012EC RID: 4844
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemComponent")]
	[UnrealStructLayout(5024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5024)]
	public class UAbilitySystemComponent : UGameplayTasksComponent, IUnrealUObject, IUnrealObject, IGameplayTagAssetInterface, IUnrealNativeInterface, IUnrealInterface, IAbilitySystemReplicationProxyInterface
	{
		// Token: 0x06011C9C RID: 72860 RVA: 0x001A19C2 File Offset: 0x0019FBC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemComponent._ClassPtr;
		}

		// Token: 0x06011C9D RID: 72861 RVA: 0x001A19CE File Offset: 0x0019FBCE
		int IGameplayTagAssetInterface.InterfaceOffset()
		{
			return UAbilitySystemComponent.__InterfaceOffset_IGameplayTagAssetInterface;
		}

		// Token: 0x06011C9E RID: 72862 RVA: 0x001A19D5 File Offset: 0x0019FBD5
		int IAbilitySystemReplicationProxyInterface.InterfaceOffset()
		{
			return UAbilitySystemComponent.__InterfaceOffset_IAbilitySystemReplicationProxyInterface;
		}

		// Token: 0x06011C9F RID: 72863 RVA: 0x001A19DC File Offset: 0x0019FBDC
		public UAbilitySystemComponent() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011CA0 RID: 72864 RVA: 0x001A1A04 File Offset: 0x0019FC04
		[NullableContext(1)]
		public UAbilitySystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x06011CA1 RID: 72865 RVA: 0x001A1A38 File Offset: 0x0019FC38
		// (set) Token: 0x06011CA2 RID: 72866 RVA: 0x001A1A71 File Offset: 0x0019FC71
		[Nullable(1)]
		public TArray<FAttributeDefaults> DefaultStartingData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FAttributeDefaults> result;
				if ((result = this._DefaultStartingData) == null)
				{
					result = (this._DefaultStartingData = new TArray<FAttributeDefaults>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_DefaultStartingData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DefaultStartingData.CopyAssign(value);
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x06011CA3 RID: 72867 RVA: 0x001A1A80 File Offset: 0x0019FC80
		// (set) Token: 0x06011CA4 RID: 72868 RVA: 0x001A1AB9 File Offset: 0x0019FCB9
		[Nullable(1)]
		public TArray<UAttributeSet> SpawnedAttributes
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.SpawnedAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x06011CA5 RID: 72869 RVA: 0x001A1AC7 File Offset: 0x0019FCC7
		// (set) Token: 0x06011CA6 RID: 72870 RVA: 0x001A1ADB File Offset: 0x0019FCDB
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

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x06011CA7 RID: 72871 RVA: 0x001A1AF0 File Offset: 0x0019FCF0
		// (set) Token: 0x06011CA8 RID: 72872 RVA: 0x001A1B00 File Offset: 0x0019FD00
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

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x06011CA9 RID: 72873 RVA: 0x001A1B11 File Offset: 0x0019FD11
		// (set) Token: 0x06011CAA RID: 72874 RVA: 0x001A1B21 File Offset: 0x0019FD21
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

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x06011CAB RID: 72875 RVA: 0x001A1B34 File Offset: 0x0019FD34
		// (set) Token: 0x06011CAC RID: 72876 RVA: 0x001A1B6D File Offset: 0x0019FD6D
		[Nullable(1)]
		public TArray<string> ClientDebugStrings
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.ClientDebugStrings.CopyAssign(value);
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x06011CAD RID: 72877 RVA: 0x001A1B7C File Offset: 0x0019FD7C
		// (set) Token: 0x06011CAE RID: 72878 RVA: 0x001A1BB5 File Offset: 0x0019FDB5
		[Nullable(1)]
		public TArray<string> ServerDebugStrings
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.ServerDebugStrings.CopyAssign(value);
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x06011CAF RID: 72879 RVA: 0x001A1BC3 File Offset: 0x0019FDC3
		// (set) Token: 0x06011CB0 RID: 72880 RVA: 0x001A1BD3 File Offset: 0x0019FDD3
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

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x06011CB1 RID: 72881 RVA: 0x001A1BE4 File Offset: 0x0019FDE4
		// (set) Token: 0x06011CB2 RID: 72882 RVA: 0x001A1BF4 File Offset: 0x0019FDF4
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

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x06011CB3 RID: 72883 RVA: 0x001A1C05 File Offset: 0x0019FE05
		// (set) Token: 0x06011CB4 RID: 72884 RVA: 0x001A1C15 File Offset: 0x0019FE15
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

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x06011CB5 RID: 72885 RVA: 0x001A1C26 File Offset: 0x0019FE26
		// (set) Token: 0x06011CB6 RID: 72886 RVA: 0x001A1C36 File Offset: 0x0019FE36
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

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x06011CB7 RID: 72887 RVA: 0x001A1C48 File Offset: 0x0019FE48
		// (set) Token: 0x06011CB8 RID: 72888 RVA: 0x001A1C81 File Offset: 0x0019FE81
		[Nullable(1)]
		public TArray<AGameplayAbilityTargetActor> SpawnedTargetActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AGameplayAbilityTargetActor> result;
				if ((result = this._SpawnedTargetActors) == null)
				{
					result = (this._SpawnedTargetActors = new TArray<AGameplayAbilityTargetActor>(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_SpawnedTargetActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SpawnedTargetActors.CopyAssign(value);
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x06011CB9 RID: 72889 RVA: 0x001A1C8F File Offset: 0x0019FE8F
		// (set) Token: 0x06011CBA RID: 72890 RVA: 0x001A1CA3 File Offset: 0x0019FEA3
		public unsafe AActor OwnerActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_OwnerActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_OwnerActor, value);
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x06011CBB RID: 72891 RVA: 0x001A1CB8 File Offset: 0x0019FEB8
		// (set) Token: 0x06011CBC RID: 72892 RVA: 0x001A1CCC File Offset: 0x0019FECC
		public unsafe AActor AvatarActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_AvatarActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemComponent.__PropertyOffset_AvatarActor, value);
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x06011CBD RID: 72893 RVA: 0x001A1CE4 File Offset: 0x0019FEE4
		// (set) Token: 0x06011CBE RID: 72894 RVA: 0x001A1D1D File Offset: 0x0019FF1D
		[Nullable(1)]
		public FGameplayAbilitySpecContainer ActivatableAbilities
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecContainer result;
				if ((result = this._ActivatableAbilities) == null)
				{
					result = (this._ActivatableAbilities = new FGameplayAbilitySpecContainer(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActivatableAbilities, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecContainer.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActivatableAbilities, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06011CBF RID: 72895 RVA: 0x001A1D40 File Offset: 0x0019FF40
		// (set) Token: 0x06011CC0 RID: 72896 RVA: 0x001A1D79 File Offset: 0x0019FF79
		[Nullable(1)]
		public TArray<UGameplayAbility> AllReplicatedInstancedAbilities
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.AllReplicatedInstancedAbilities.CopyAssign(value);
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x06011CC1 RID: 72897 RVA: 0x001A1D88 File Offset: 0x0019FF88
		// (set) Token: 0x06011CC2 RID: 72898 RVA: 0x001A1DC1 File Offset: 0x0019FFC1
		[Nullable(1)]
		public FGameplayAbilityRepAnimMontage RepAnimMontageInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityRepAnimMontage result;
				if ((result = this._RepAnimMontageInfo) == null)
				{
					result = (this._RepAnimMontageInfo = new FGameplayAbilityRepAnimMontage(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_RepAnimMontageInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityRepAnimMontage.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_RepAnimMontageInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x06011CC3 RID: 72899 RVA: 0x001A1DE2 File Offset: 0x0019FFE2
		// (set) Token: 0x06011CC4 RID: 72900 RVA: 0x001A1DF2 File Offset: 0x0019FFF2
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

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x06011CC5 RID: 72901 RVA: 0x001A1E03 File Offset: 0x001A0003
		// (set) Token: 0x06011CC6 RID: 72902 RVA: 0x001A1E13 File Offset: 0x001A0013
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

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06011CC7 RID: 72903 RVA: 0x001A1E24 File Offset: 0x001A0024
		// (set) Token: 0x06011CC8 RID: 72904 RVA: 0x001A1E5D File Offset: 0x001A005D
		[Nullable(1)]
		public FGameplayAbilityLocalAnimMontage LocalAnimMontageInfo
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityLocalAnimMontage.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_LocalAnimMontageInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06011CC9 RID: 72905 RVA: 0x001A1E80 File Offset: 0x001A0080
		// (set) Token: 0x06011CCA RID: 72906 RVA: 0x001A1EB9 File Offset: 0x001A00B9
		[Nullable(1)]
		public FActiveGameplayEffectsContainer ActiveGameplayEffects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayEffectsContainer result;
				if ((result = this._ActiveGameplayEffects) == null)
				{
					result = (this._ActiveGameplayEffects = new FActiveGameplayEffectsContainer(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActiveGameplayEffects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectsContainer.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActiveGameplayEffects, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x06011CCB RID: 72907 RVA: 0x001A1EDC File Offset: 0x001A00DC
		// (set) Token: 0x06011CCC RID: 72908 RVA: 0x001A1F15 File Offset: 0x001A0115
		[Nullable(1)]
		public FActiveGameplayCueContainer ActiveGameplayCues
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayCueContainer result;
				if ((result = this._ActiveGameplayCues) == null)
				{
					result = (this._ActiveGameplayCues = new FActiveGameplayCueContainer(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActiveGameplayCues, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayCueContainer.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ActiveGameplayCues, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x06011CCD RID: 72909 RVA: 0x001A1F38 File Offset: 0x001A0138
		// (set) Token: 0x06011CCE RID: 72910 RVA: 0x001A1F71 File Offset: 0x001A0171
		[Nullable(1)]
		public FActiveGameplayCueContainer MinimalReplicationGameplayCues
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayCueContainer result;
				if ((result = this._MinimalReplicationGameplayCues) == null)
				{
					result = (this._MinimalReplicationGameplayCues = new FActiveGameplayCueContainer(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_MinimalReplicationGameplayCues, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayCueContainer.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_MinimalReplicationGameplayCues, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x06011CCF RID: 72911 RVA: 0x001A1F94 File Offset: 0x001A0194
		// (set) Token: 0x06011CD0 RID: 72912 RVA: 0x001A1FCD File Offset: 0x001A01CD
		[Nullable(1)]
		public TArray<byte> BlockedAbilityBindings
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.BlockedAbilityBindings.CopyAssign(value);
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x06011CD1 RID: 72913 RVA: 0x001A1FDC File Offset: 0x001A01DC
		// (set) Token: 0x06011CD2 RID: 72914 RVA: 0x001A2015 File Offset: 0x001A0215
		[Nullable(1)]
		public FMinimalReplicationTagCountMap MinimalReplicationTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMinimalReplicationTagCountMap result;
				if ((result = this._MinimalReplicationTags) == null)
				{
					result = (this._MinimalReplicationTags = new FMinimalReplicationTagCountMap(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_MinimalReplicationTags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMinimalReplicationTagCountMap.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_MinimalReplicationTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06011CD3 RID: 72915 RVA: 0x001A2038 File Offset: 0x001A0238
		// (set) Token: 0x06011CD4 RID: 72916 RVA: 0x001A2071 File Offset: 0x001A0271
		[Nullable(1)]
		public FReplicatedPredictionKeyMap ReplicatedPredictionKeyMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FReplicatedPredictionKeyMap result;
				if ((result = this._ReplicatedPredictionKeyMap) == null)
				{
					result = (this._ReplicatedPredictionKeyMap = new FReplicatedPredictionKeyMap(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ReplicatedPredictionKeyMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReplicatedPredictionKeyMap.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_ReplicatedPredictionKeyMap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06011CD5 RID: 72917 RVA: 0x001A2094 File Offset: 0x001A0294
		// (set) Token: 0x06011CD6 RID: 72918 RVA: 0x001A20CD File Offset: 0x001A02CD
		[Nullable(1)]
		public FTagUpdated TagUpdated
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilitySystemComponent.__PropertyOffset_TagUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011CD7 RID: 72919 RVA: 0x001A20EE File Offset: 0x001A02EE
		public void UpdateTagMap(in FGameplayTag BaseTag, int CountDelta)
		{
			UAbilitySystemComponent.__UpdateTagMap_Internal(base.NativePtr, BaseTag, CountDelta);
		}

		// Token: 0x06011CD8 RID: 72920 RVA: 0x001A20FD File Offset: 0x001A02FD
		public bool TryActivateAbilityByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayAbility> InAbilityToActivate, bool bAllowRemoteActivation = true)
		{
			return UAbilitySystemComponent.__TryActivateAbilityByClass_Internal(base.NativePtr, InAbilityToActivate._NativePtr, bAllowRemoteActivation);
		}

		// Token: 0x06011CD9 RID: 72921 RVA: 0x001A2111 File Offset: 0x001A0311
		public bool TryActivateAbilitiesByTag(in FGameplayTagContainer GameplayTagContainer, bool bAllowRemoteActivation = true)
		{
			return UAbilitySystemComponent.__TryActivateAbilitiesByTag_Internal(base.NativePtr, (GameplayTagContainer ?? new FGameplayTagContainer()).NativePtr, bAllowRemoteActivation);
		}

		// Token: 0x06011CDA RID: 72922 RVA: 0x001A212F File Offset: 0x001A032F
		public void TargetConfirm()
		{
			UAbilitySystemComponent.__TargetConfirm_Internal(base.NativePtr);
		}

		// Token: 0x06011CDB RID: 72923 RVA: 0x001A213C File Offset: 0x001A033C
		public void TargetCancel()
		{
			UAbilitySystemComponent.__TargetCancel_Internal(base.NativePtr);
		}

		// Token: 0x06011CDC RID: 72924 RVA: 0x001A2149 File Offset: 0x001A0349
		public void SetUserAbilityActivationInhibited(bool NewInhibit)
		{
			UAbilitySystemComponent.__SetUserAbilityActivationInhibited_Internal(base.NativePtr, NewInhibit);
		}

		// Token: 0x06011CDD RID: 72925 RVA: 0x001A2157 File Offset: 0x001A0357
		public void SetTagMapCount(in FGameplayTag Tag, int NewCount, bool NeedNotify = true)
		{
			UAbilitySystemComponent.__SetTagMapCount_Internal(base.NativePtr, Tag, NewCount, NeedNotify);
		}

		// Token: 0x06011CDE RID: 72926 RVA: 0x001A2167 File Offset: 0x001A0367
		public void SetRemoteGameplayEffectInhibition(int HandleId, bool bShouldBeInhibited)
		{
			UAbilitySystemComponent.__SetRemoteGameplayEffectInhibition_Internal(base.NativePtr, HandleId, bShouldBeInhibited);
		}

		// Token: 0x06011CDF RID: 72927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGeHandleStart(int HandleIdStart);

		// Token: 0x06011CE0 RID: 72928
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGeHandleIdPrefix(int InHandleIdPrefix);

		// Token: 0x06011CE1 RID: 72929 RVA: 0x001A2176 File Offset: 0x001A0376
		public void SetActiveGameplayEffectLevelUsingQuery(FGameplayEffectQuery Query, int NewLevel)
		{
			UAbilitySystemComponent.__SetActiveGameplayEffectLevelUsingQuery_Internal(base.NativePtr, (Query ?? new FGameplayEffectQuery()).NativePtr, NewLevel);
		}

		// Token: 0x06011CE2 RID: 72930 RVA: 0x001A2193 File Offset: 0x001A0393
		public void SetActiveGameplayEffectLevel(FActiveGameplayEffectHandle ActiveHandle, int NewLevel)
		{
			UAbilitySystemComponent.__SetActiveGameplayEffectLevel_Internal(base.NativePtr, (ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr, NewLevel);
		}

		// Token: 0x06011CE3 RID: 72931 RVA: 0x001A21B0 File Offset: 0x001A03B0
		public void ServerTryActivateAbilityWithEventData(FGameplayAbilitySpecHandle AbilityToActivate, bool InputPressed, FPredictionKey PredictionKey, FGameplayEventData TriggerEventData)
		{
			UAbilitySystemComponent.__ServerTryActivateAbilityWithEventData_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, InputPressed, (PredictionKey ?? new FPredictionKey()).NativePtr, (TriggerEventData ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06011CE4 RID: 72932 RVA: 0x001A21EC File Offset: 0x001A03EC
		public void ServerTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate, bool InputPressed, FPredictionKey PredictionKey)
		{
			UAbilitySystemComponent.__ServerTryActivateAbility_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, InputPressed, (PredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011CE5 RID: 72933 RVA: 0x001A2218 File Offset: 0x001A0418
		public void ServerSetReplicatedTargetDataCancelled(FGameplayAbilitySpecHandle AbilityHandle, FPredictionKey AbilityOriginalPredictionKey, FPredictionKey CurrentPredictionKey)
		{
			UAbilitySystemComponent.__ServerSetReplicatedTargetDataCancelled_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr, (AbilityOriginalPredictionKey ?? new FPredictionKey()).NativePtr, (CurrentPredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011CE6 RID: 72934 RVA: 0x001A2254 File Offset: 0x001A0454
		public void ServerSetReplicatedTargetData(FGameplayAbilitySpecHandle AbilityHandle, FPredictionKey AbilityOriginalPredictionKey, in FGameplayAbilityTargetDataHandle ReplicatedTargetDataHandle, FGameplayTag ApplicationTag, FPredictionKey CurrentPredictionKey)
		{
			UAbilitySystemComponent.__ServerSetReplicatedTargetData_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr, (AbilityOriginalPredictionKey ?? new FPredictionKey()).NativePtr, (ReplicatedTargetDataHandle ?? new FGameplayAbilityTargetDataHandle()).NativePtr, ApplicationTag, (CurrentPredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011CE7 RID: 72935 RVA: 0x001A22AC File Offset: 0x001A04AC
		public void ServerSetReplicatedEventWithPayload(EAbilityGenericReplicatedEvent EventType, FGameplayAbilitySpecHandle AbilityHandle, FPredictionKey AbilityOriginalPredictionKey, FPredictionKey CurrentPredictionKey, FVector_NetQuantize100 VectorPayload)
		{
			UAbilitySystemComponent.__ServerSetReplicatedEventWithPayload_Internal(base.NativePtr, EventType, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr, (AbilityOriginalPredictionKey ?? new FPredictionKey()).NativePtr, (CurrentPredictionKey ?? new FPredictionKey()).NativePtr, VectorPayload);
		}

		// Token: 0x06011CE8 RID: 72936 RVA: 0x001A22FC File Offset: 0x001A04FC
		public void ServerSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType, FGameplayAbilitySpecHandle AbilityHandle, FPredictionKey AbilityOriginalPredictionKey, FPredictionKey CurrentPredictionKey)
		{
			UAbilitySystemComponent.__ServerSetReplicatedEvent_Internal(base.NativePtr, EventType, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr, (AbilityOriginalPredictionKey ?? new FPredictionKey()).NativePtr, (CurrentPredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011CE9 RID: 72937 RVA: 0x001A2348 File Offset: 0x001A0548
		public void ServerSetInputReleased(FGameplayAbilitySpecHandle AbilityHandle)
		{
			UAbilitySystemComponent.__ServerSetInputReleased_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06011CEA RID: 72938 RVA: 0x001A2364 File Offset: 0x001A0564
		public void ServerSetInputPressed(FGameplayAbilitySpecHandle AbilityHandle)
		{
			UAbilitySystemComponent.__ServerSetInputPressed_Internal(base.NativePtr, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06011CEB RID: 72939 RVA: 0x001A2380 File Offset: 0x001A0580
		public void ServerPrintDebug_RequestWithStrings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Strings)
		{
			UAbilitySystemComponent.__ServerPrintDebug_RequestWithStrings_Internal(base.NativePtr, (Strings ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06011CEC RID: 72940 RVA: 0x001A239D File Offset: 0x001A059D
		public void ServerPrintDebug_Request()
		{
			UAbilitySystemComponent.__ServerPrintDebug_Request_Internal(base.NativePtr);
		}

		// Token: 0x06011CED RID: 72941 RVA: 0x001A23AA File Offset: 0x001A05AA
		public void ServerEndAbility(FGameplayAbilitySpecHandle AbilityToEnd, FGameplayAbilityActivationInfo ActivationInfo, FPredictionKey PredictionKey)
		{
			UAbilitySystemComponent.__ServerEndAbility_Internal(base.NativePtr, (AbilityToEnd ?? new FGameplayAbilitySpecHandle()).NativePtr, (ActivationInfo ?? new FGameplayAbilityActivationInfo()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011CEE RID: 72942 RVA: 0x001A23E4 File Offset: 0x001A05E4
		public void ServerCurrentMontageSetPlayRate(UAnimMontage ClientAnimMontage, float InPlayRate)
		{
			UAbilitySystemComponent.__ServerCurrentMontageSetPlayRate_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, InPlayRate);
		}

		// Token: 0x06011CEF RID: 72943 RVA: 0x001A2402 File Offset: 0x001A0602
		public void ServerCurrentMontageSetNextSectionName(UAnimMontage ClientAnimMontage, float ClientPosition, FName SectionName, FName NextSectionName)
		{
			UAbilitySystemComponent.__ServerCurrentMontageSetNextSectionName_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, ClientPosition, SectionName, NextSectionName);
		}

		// Token: 0x06011CF0 RID: 72944 RVA: 0x001A2423 File Offset: 0x001A0623
		public void ServerCurrentMontageJumpToSectionName(UAnimMontage ClientAnimMontage, FName SectionName)
		{
			UAbilitySystemComponent.__ServerCurrentMontageJumpToSectionName_Internal(base.NativePtr, (ClientAnimMontage != null) ? ClientAnimMontage.NativePtr : IntPtr.Zero, SectionName);
		}

		// Token: 0x06011CF1 RID: 72945 RVA: 0x001A2441 File Offset: 0x001A0641
		public void ServerCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel, FGameplayAbilityActivationInfo ActivationInfo)
		{
			UAbilitySystemComponent.__ServerCancelAbility_Internal(base.NativePtr, (AbilityToCancel ?? new FGameplayAbilitySpecHandle()).NativePtr, (ActivationInfo ?? new FGameplayAbilityActivationInfo()).NativePtr);
		}

		// Token: 0x06011CF2 RID: 72946 RVA: 0x001A246C File Offset: 0x001A066C
		public void ServerAbilityRPCBatch(FServerAbilityRPCBatch BatchInfo)
		{
			UAbilitySystemComponent.__ServerAbilityRPCBatch_Internal(base.NativePtr, (BatchInfo ?? new FServerAbilityRPCBatch()).NativePtr);
		}

		// Token: 0x06011CF3 RID: 72947 RVA: 0x001A2488 File Offset: 0x001A0688
		public void ResetTagMap()
		{
			UAbilitySystemComponent.__ResetTagMap_Internal(base.NativePtr);
		}

		// Token: 0x06011CF4 RID: 72948 RVA: 0x001A2495 File Offset: 0x001A0695
		public void RemoveActiveGameplayEffectBySourceEffect([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffect, UAbilitySystemComponent InstigatorAbilitySystemComponent, int StacksToRemove = -1)
		{
			UAbilitySystemComponent.__RemoveActiveGameplayEffectBySourceEffect_Internal(base.NativePtr, GameplayEffect._NativePtr, (InstigatorAbilitySystemComponent != null) ? InstigatorAbilitySystemComponent.NativePtr : IntPtr.Zero, StacksToRemove);
		}

		// Token: 0x06011CF5 RID: 72949 RVA: 0x001A24B9 File Offset: 0x001A06B9
		public bool RemoveActiveGameplayEffect(FActiveGameplayEffectHandle Handle, int StacksToRemove = -1)
		{
			return UAbilitySystemComponent.__RemoveActiveGameplayEffect_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, StacksToRemove);
		}

		// Token: 0x06011CF6 RID: 72950 RVA: 0x001A24D6 File Offset: 0x001A06D6
		public int RemoveActiveEffectsWithTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06011CF7 RID: 72951 RVA: 0x001A24F2 File Offset: 0x001A06F2
		public int RemoveActiveEffectsWithSourceTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithSourceTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06011CF8 RID: 72952 RVA: 0x001A250E File Offset: 0x001A070E
		public int RemoveActiveEffectsWithGrantedTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithGrantedTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06011CF9 RID: 72953 RVA: 0x001A252A File Offset: 0x001A072A
		public int RemoveActiveEffectsWithAppliedTags(FGameplayTagContainer Tags)
		{
			return UAbilitySystemComponent.__RemoveActiveEffectsWithAppliedTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06011CFA RID: 72954 RVA: 0x001A2546 File Offset: 0x001A0746
		public void OnTagUpdated(in FGameplayTag Tag, bool TagExists, int CountDelta)
		{
			UAbilitySystemComponent.__OnTagUpdated_Internal(base.NativePtr, Tag, TagExists, CountDelta);
		}

		// Token: 0x06011CFB RID: 72955 RVA: 0x001A2556 File Offset: 0x001A0756
		public void OnRep_ServerDebugString()
		{
			UAbilitySystemComponent.__OnRep_ServerDebugString_Internal(base.NativePtr);
		}

		// Token: 0x06011CFC RID: 72956 RVA: 0x001A2563 File Offset: 0x001A0763
		public void OnRep_ReplicatedAnimMontage()
		{
			UAbilitySystemComponent.__OnRep_ReplicatedAnimMontage_Internal(base.NativePtr);
		}

		// Token: 0x06011CFD RID: 72957 RVA: 0x001A2570 File Offset: 0x001A0770
		public void OnRep_OwningActor()
		{
			UAbilitySystemComponent.__OnRep_OwningActor_Internal(base.NativePtr);
		}

		// Token: 0x06011CFE RID: 72958 RVA: 0x001A257D File Offset: 0x001A077D
		public void OnRep_ClientDebugString()
		{
			UAbilitySystemComponent.__OnRep_ClientDebugString_Internal(base.NativePtr);
		}

		// Token: 0x06011CFF RID: 72959 RVA: 0x001A258A File Offset: 0x001A078A
		public void OnRep_ActivateAbilities()
		{
			UAbilitySystemComponent.__OnRep_ActivateAbilities_Internal(base.NativePtr);
		}

		// Token: 0x06011D00 RID: 72960 RVA: 0x001A2597 File Offset: 0x001A0797
		public void NetMulticast_InvokeGameplayCuesExecuted_WithParams(FGameplayTagContainer GameplayCueTags, FPredictionKey PredictionKey, FGameplayCueParameters GameplayCueParameters)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCuesExecuted_WithParams_Internal(base.NativePtr, (GameplayCueTags ?? new FGameplayTagContainer()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr, (GameplayCueParameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011D01 RID: 72961 RVA: 0x001A25D1 File Offset: 0x001A07D1
		public void NetMulticast_InvokeGameplayCuesExecuted(FGameplayTagContainer GameplayCueTags, FPredictionKey PredictionKey, FGameplayEffectContextHandle EffectContext)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCuesExecuted_Internal(base.NativePtr, (GameplayCueTags ?? new FGameplayTagContainer()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011D02 RID: 72962 RVA: 0x001A260B File Offset: 0x001A080B
		public void NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams(FGameplayTagContainer GameplayCueTags, FPredictionKey PredictionKey, FGameplayCueParameters GameplayCueParameters)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams_Internal(base.NativePtr, (GameplayCueTags ?? new FGameplayTagContainer()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr, (GameplayCueParameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011D03 RID: 72963 RVA: 0x001A2645 File Offset: 0x001A0845
		public void NetMulticast_InvokeGameplayCueExecuted_WithParams(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayCueParameters GameplayCueParameters)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueExecuted_WithParams_Internal(base.NativePtr, GameplayCueTag, (PredictionKey ?? new FPredictionKey()).NativePtr, (GameplayCueParameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011D04 RID: 72964 RVA: 0x001A2671 File Offset: 0x001A0871
		public void NetMulticast_InvokeGameplayCueExecuted_FromSpec(FGameplayEffectSpecForRPC Spec, FPredictionKey PredictionKey)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueExecuted_FromSpec_Internal(base.NativePtr, (Spec ?? new FGameplayEffectSpecForRPC()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011D05 RID: 72965 RVA: 0x001A269C File Offset: 0x001A089C
		public void NetMulticast_InvokeGameplayCueExecuted(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayEffectContextHandle EffectContext)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueExecuted_Internal(base.NativePtr, GameplayCueTag, (PredictionKey ?? new FPredictionKey()).NativePtr, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011D06 RID: 72966 RVA: 0x001A26C8 File Offset: 0x001A08C8
		public void NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayCueParameters GameplayCueParameters)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams_Internal(base.NativePtr, GameplayCueTag, (PredictionKey ?? new FPredictionKey()).NativePtr, (GameplayCueParameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011D07 RID: 72967 RVA: 0x001A26F4 File Offset: 0x001A08F4
		public void NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec(in FGameplayEffectSpecForRPC Spec, FPredictionKey PredictionKey)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec_Internal(base.NativePtr, (Spec ?? new FGameplayEffectSpecForRPC()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011D08 RID: 72968 RVA: 0x001A2720 File Offset: 0x001A0920
		public void NetMulticast_InvokeGameplayCueAdded_WithParams(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayCueParameters Parameters)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueAdded_WithParams_Internal(base.NativePtr, GameplayCueTag, (PredictionKey ?? new FPredictionKey()).NativePtr, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011D09 RID: 72969 RVA: 0x001A274C File Offset: 0x001A094C
		public void NetMulticast_InvokeGameplayCueAdded(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayEffectContextHandle EffectContext)
		{
			UAbilitySystemComponent.__NetMulticast_InvokeGameplayCueAdded_Internal(base.NativePtr, GameplayCueTag, (PredictionKey ?? new FPredictionKey()).NativePtr, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011D0A RID: 72970 RVA: 0x001A2778 File Offset: 0x001A0978
		[NullableContext(1)]
		public FGameplayEffectSpecHandle MakeOutgoingSpec([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, float Level, [Nullable(2)] FGameplayEffectContextHandle Context)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemComponent.__MakeOutgoingSpec_Internal(base.NativePtr, GameplayEffectClass._NativePtr, Level, (Context ?? new FGameplayEffectContextHandle()).NativePtr), null);
		}

		// Token: 0x06011D0B RID: 72971 RVA: 0x001A27A1 File Offset: 0x001A09A1
		[NullableContext(1)]
		public FGameplayEffectContextHandle MakeEffectContext()
		{
			return new FGameplayEffectContextHandle(UAbilitySystemComponent.__MakeEffectContext_Internal(base.NativePtr), null);
		}

		// Token: 0x06011D0C RID: 72972 RVA: 0x001A27B4 File Offset: 0x001A09B4
		public void K2_InitStats([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAttributeSet> Attributes, UDataTable DataTable)
		{
			UAbilitySystemComponent.__K2_InitStats_Internal(base.NativePtr, Attributes._NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011D0D RID: 72973 RVA: 0x001A27D7 File Offset: 0x001A09D7
		public bool IsGameplayCueActive(FGameplayTag GameplayCueTag)
		{
			return UAbilitySystemComponent.__IsGameplayCueActive_Internal(base.NativePtr, GameplayCueTag);
		}

		// Token: 0x06011D0E RID: 72974 RVA: 0x001A27E5 File Offset: 0x001A09E5
		public bool GetUserAbilityActivationInhibited()
		{
			return UAbilitySystemComponent.__GetUserAbilityActivationInhibited_Internal(base.NativePtr);
		}

		// Token: 0x06011D0F RID: 72975 RVA: 0x001A27F2 File Offset: 0x001A09F2
		public int GetTagCount(FGameplayTag TagToCheck)
		{
			return UAbilitySystemComponent.__GetTagCount_Internal(base.NativePtr, TagToCheck);
		}

		// Token: 0x06011D10 RID: 72976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGeHandleIdPrefix();

		// Token: 0x06011D11 RID: 72977 RVA: 0x001A2800 File Offset: 0x001A0A00
		public float GetGameplayEffectMagnitude(FActiveGameplayEffectHandle Handle, FGameplayAttribute Attribute)
		{
			return UAbilitySystemComponent.__GetGameplayEffectMagnitude_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, (Attribute ?? new FGameplayAttribute()).NativePtr);
		}

		// Token: 0x06011D12 RID: 72978 RVA: 0x001A282B File Offset: 0x001A0A2B
		public int GetGameplayEffectCount([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> SourceGameplayEffect, UAbilitySystemComponent OptionalInstigatorFilterComponent, bool bEnforceOnGoingCheck = true)
		{
			return UAbilitySystemComponent.__GetGameplayEffectCount_Internal(base.NativePtr, SourceGameplayEffect._NativePtr, (OptionalInstigatorFilterComponent != null) ? OptionalInstigatorFilterComponent.NativePtr : IntPtr.Zero, bEnforceOnGoingCheck);
		}

		// Token: 0x06011D13 RID: 72979 RVA: 0x001A284F File Offset: 0x001A0A4F
		[NullableContext(1)]
		public TArray<FActiveGameplayEffectHandle> GetActiveEffectsWithAllTags([Nullable(2)] FGameplayTagContainer Tags)
		{
			return new TArray<FActiveGameplayEffectHandle>(UAbilitySystemComponent.__GetActiveEffectsWithAllTags_Internal(base.NativePtr, (Tags ?? new FGameplayTagContainer()).NativePtr), null);
		}

		// Token: 0x06011D14 RID: 72980 RVA: 0x001A2871 File Offset: 0x001A0A71
		[NullableContext(1)]
		public TArray<FActiveGameplayEffectHandle> GetActiveEffects([Nullable(2)] in FGameplayEffectQuery Query)
		{
			return new TArray<FActiveGameplayEffectHandle>(UAbilitySystemComponent.__GetActiveEffects_Internal(base.NativePtr, (Query ?? new FGameplayEffectQuery()).NativePtr), null);
		}

		// Token: 0x06011D15 RID: 72981 RVA: 0x001A2894 File Offset: 0x001A0A94
		public void ClientTryActivateAbility(FGameplayAbilitySpecHandle AbilityToActivate)
		{
			UAbilitySystemComponent.__ClientTryActivateAbility_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr);
		}

		// Token: 0x06011D16 RID: 72982 RVA: 0x001A28B0 File Offset: 0x001A0AB0
		public void ClientSetReplicatedEvent(EAbilityGenericReplicatedEvent EventType, FGameplayAbilitySpecHandle AbilityHandle, FPredictionKey AbilityOriginalPredictionKey)
		{
			UAbilitySystemComponent.__ClientSetReplicatedEvent_Internal(base.NativePtr, EventType, (AbilityHandle ?? new FGameplayAbilitySpecHandle()).NativePtr, (AbilityOriginalPredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011D17 RID: 72983 RVA: 0x001A28E1 File Offset: 0x001A0AE1
		public void ClientPrintDebug_Response([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Strings, int GameFlags)
		{
			UAbilitySystemComponent.__ClientPrintDebug_Response_Internal(base.NativePtr, (Strings ?? new TArray<string>()).NativePtr, GameFlags);
		}

		// Token: 0x06011D18 RID: 72984 RVA: 0x001A28FF File Offset: 0x001A0AFF
		public void ClientEndAbility(FGameplayAbilitySpecHandle AbilityToEnd, FGameplayAbilityActivationInfo ActivationInfo)
		{
			UAbilitySystemComponent.__ClientEndAbility_Internal(base.NativePtr, (AbilityToEnd ?? new FGameplayAbilitySpecHandle()).NativePtr, (ActivationInfo ?? new FGameplayAbilityActivationInfo()).NativePtr);
		}

		// Token: 0x06011D19 RID: 72985 RVA: 0x001A292A File Offset: 0x001A0B2A
		public void ClientCancelAbility(FGameplayAbilitySpecHandle AbilityToCancel, FGameplayAbilityActivationInfo ActivationInfo)
		{
			UAbilitySystemComponent.__ClientCancelAbility_Internal(base.NativePtr, (AbilityToCancel ?? new FGameplayAbilitySpecHandle()).NativePtr, (ActivationInfo ?? new FGameplayAbilityActivationInfo()).NativePtr);
		}

		// Token: 0x06011D1A RID: 72986 RVA: 0x001A2955 File Offset: 0x001A0B55
		public void ClientActivateAbilitySucceedWithEventData(FGameplayAbilitySpecHandle AbilityToActivate, FPredictionKey PredictionKey, FGameplayEventData TriggerEventData)
		{
			UAbilitySystemComponent.__ClientActivateAbilitySucceedWithEventData_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr, (TriggerEventData ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06011D1B RID: 72987 RVA: 0x001A298F File Offset: 0x001A0B8F
		public void ClientActivateAbilitySucceed(FGameplayAbilitySpecHandle AbilityToActivate, FPredictionKey PredictionKey)
		{
			UAbilitySystemComponent.__ClientActivateAbilitySucceed_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, (PredictionKey ?? new FPredictionKey()).NativePtr);
		}

		// Token: 0x06011D1C RID: 72988 RVA: 0x001A29BA File Offset: 0x001A0BBA
		public void ClientActivateAbilityFailed(FGameplayAbilitySpecHandle AbilityToActivate, short PredictionKey)
		{
			UAbilitySystemComponent.__ClientActivateAbilityFailed_Internal(base.NativePtr, (AbilityToActivate ?? new FGameplayAbilitySpecHandle()).NativePtr, PredictionKey);
		}

		// Token: 0x06011D1D RID: 72989 RVA: 0x001A29D7 File Offset: 0x001A0BD7
		[return: Nullable(1)]
		public FActiveGameplayEffectHandle BP_ApplyGameplayEffectToTarget([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, UAbilitySystemComponent Target, float Level, FGameplayEffectContextHandle Context)
		{
			return new FActiveGameplayEffectHandle(UAbilitySystemComponent.__BP_ApplyGameplayEffectToTarget_Internal(base.NativePtr, GameplayEffectClass._NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero, Level, (Context ?? new FGameplayEffectContextHandle()).NativePtr), null);
		}

		// Token: 0x06011D1E RID: 72990 RVA: 0x001A2A11 File Offset: 0x001A0C11
		[NullableContext(1)]
		public FActiveGameplayEffectHandle BP_ApplyGameplayEffectToSelf([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, float Level, [Nullable(2)] FGameplayEffectContextHandle EffectContext)
		{
			return new FActiveGameplayEffectHandle(UAbilitySystemComponent.__BP_ApplyGameplayEffectToSelf_Internal(base.NativePtr, GameplayEffectClass._NativePtr, Level, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr), null);
		}

		// Token: 0x06011D1F RID: 72991 RVA: 0x001A2A3A File Offset: 0x001A0C3A
		[return: Nullable(1)]
		public FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToTarget(in FGameplayEffectSpecHandle SpecHandle, UAbilitySystemComponent Target)
		{
			return new FActiveGameplayEffectHandle(UAbilitySystemComponent.__BP_ApplyGameplayEffectSpecToTarget_Internal(base.NativePtr, (SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06011D20 RID: 72992 RVA: 0x001A2A6D File Offset: 0x001A0C6D
		[NullableContext(1)]
		public FActiveGameplayEffectHandle BP_ApplyGameplayEffectSpecToSelf([Nullable(2)] in FGameplayEffectSpecHandle SpecHandle)
		{
			return new FActiveGameplayEffectHandle(UAbilitySystemComponent.__BP_ApplyGameplayEffectSpecToSelf_Internal(base.NativePtr, (SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011D21 RID: 72993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateTagMap_Internal(IntPtr @this, in FGameplayTag BaseTag, int CountDelta);

		// Token: 0x06011D22 RID: 72994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryActivateAbilityByClass_Internal(IntPtr @this, IntPtr InAbilityToActivate, bool bAllowRemoteActivation);

		// Token: 0x06011D23 RID: 72995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryActivateAbilitiesByTag_Internal(IntPtr @this, IntPtr GameplayTagContainer, bool bAllowRemoteActivation);

		// Token: 0x06011D24 RID: 72996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TargetConfirm_Internal(IntPtr @this);

		// Token: 0x06011D25 RID: 72997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TargetCancel_Internal(IntPtr @this);

		// Token: 0x06011D26 RID: 72998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserAbilityActivationInhibited_Internal(IntPtr @this, bool NewInhibit);

		// Token: 0x06011D27 RID: 72999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTagMapCount_Internal(IntPtr @this, in FGameplayTag Tag, int NewCount, bool NeedNotify);

		// Token: 0x06011D28 RID: 73000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRemoteGameplayEffectInhibition_Internal(IntPtr @this, int HandleId, bool bShouldBeInhibited);

		// Token: 0x06011D29 RID: 73001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActiveGameplayEffectLevelUsingQuery_Internal(IntPtr @this, IntPtr Query, int NewLevel);

		// Token: 0x06011D2A RID: 73002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActiveGameplayEffectLevel_Internal(IntPtr @this, IntPtr ActiveHandle, int NewLevel);

		// Token: 0x06011D2B RID: 73003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerTryActivateAbilityWithEventData_Internal(IntPtr @this, IntPtr AbilityToActivate, bool InputPressed, IntPtr PredictionKey, IntPtr TriggerEventData);

		// Token: 0x06011D2C RID: 73004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerTryActivateAbility_Internal(IntPtr @this, IntPtr AbilityToActivate, bool InputPressed, IntPtr PredictionKey);

		// Token: 0x06011D2D RID: 73005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetReplicatedTargetDataCancelled_Internal(IntPtr @this, IntPtr AbilityHandle, IntPtr AbilityOriginalPredictionKey, IntPtr CurrentPredictionKey);

		// Token: 0x06011D2E RID: 73006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetReplicatedTargetData_Internal(IntPtr @this, IntPtr AbilityHandle, IntPtr AbilityOriginalPredictionKey, IntPtr ReplicatedTargetDataHandle, FGameplayTag ApplicationTag, IntPtr CurrentPredictionKey);

		// Token: 0x06011D2F RID: 73007
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetReplicatedEventWithPayload_Internal(IntPtr @this, TEnumAsByte<EAbilityGenericReplicatedEvent> EventType, IntPtr AbilityHandle, IntPtr AbilityOriginalPredictionKey, IntPtr CurrentPredictionKey, FVector_NetQuantize100 VectorPayload);

		// Token: 0x06011D30 RID: 73008
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetReplicatedEvent_Internal(IntPtr @this, TEnumAsByte<EAbilityGenericReplicatedEvent> EventType, IntPtr AbilityHandle, IntPtr AbilityOriginalPredictionKey, IntPtr CurrentPredictionKey);

		// Token: 0x06011D31 RID: 73009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetInputReleased_Internal(IntPtr @this, IntPtr AbilityHandle);

		// Token: 0x06011D32 RID: 73010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetInputPressed_Internal(IntPtr @this, IntPtr AbilityHandle);

		// Token: 0x06011D33 RID: 73011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPrintDebug_RequestWithStrings_Internal(IntPtr @this, IntPtr Strings);

		// Token: 0x06011D34 RID: 73012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPrintDebug_Request_Internal(IntPtr @this);

		// Token: 0x06011D35 RID: 73013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerEndAbility_Internal(IntPtr @this, IntPtr AbilityToEnd, IntPtr ActivationInfo, IntPtr PredictionKey);

		// Token: 0x06011D36 RID: 73014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageSetPlayRate_Internal(IntPtr @this, IntPtr ClientAnimMontage, float InPlayRate);

		// Token: 0x06011D37 RID: 73015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageSetNextSectionName_Internal(IntPtr @this, IntPtr ClientAnimMontage, float ClientPosition, FName SectionName, FName NextSectionName);

		// Token: 0x06011D38 RID: 73016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCurrentMontageJumpToSectionName_Internal(IntPtr @this, IntPtr ClientAnimMontage, FName SectionName);

		// Token: 0x06011D39 RID: 73017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCancelAbility_Internal(IntPtr @this, IntPtr AbilityToCancel, IntPtr ActivationInfo);

		// Token: 0x06011D3A RID: 73018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerAbilityRPCBatch_Internal(IntPtr @this, IntPtr BatchInfo);

		// Token: 0x06011D3B RID: 73019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetTagMap_Internal(IntPtr @this);

		// Token: 0x06011D3C RID: 73020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActiveGameplayEffectBySourceEffect_Internal(IntPtr @this, IntPtr GameplayEffect, IntPtr InstigatorAbilitySystemComponent, int StacksToRemove);

		// Token: 0x06011D3D RID: 73021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveActiveGameplayEffect_Internal(IntPtr @this, IntPtr Handle, int StacksToRemove);

		// Token: 0x06011D3E RID: 73022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06011D3F RID: 73023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithSourceTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06011D40 RID: 73024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithGrantedTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06011D41 RID: 73025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RemoveActiveEffectsWithAppliedTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06011D42 RID: 73026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagUpdated_Internal(IntPtr @this, in FGameplayTag Tag, bool TagExists, int CountDelta);

		// Token: 0x06011D43 RID: 73027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ServerDebugString_Internal(IntPtr @this);

		// Token: 0x06011D44 RID: 73028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedAnimMontage_Internal(IntPtr @this);

		// Token: 0x06011D45 RID: 73029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_OwningActor_Internal(IntPtr @this);

		// Token: 0x06011D46 RID: 73030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ClientDebugString_Internal(IntPtr @this);

		// Token: 0x06011D47 RID: 73031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ActivateAbilities_Internal(IntPtr @this);

		// Token: 0x06011D48 RID: 73032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCuesExecuted_WithParams_Internal(IntPtr @this, IntPtr GameplayCueTags, IntPtr PredictionKey, IntPtr GameplayCueParameters);

		// Token: 0x06011D49 RID: 73033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCuesExecuted_Internal(IntPtr @this, IntPtr GameplayCueTags, IntPtr PredictionKey, IntPtr EffectContext);

		// Token: 0x06011D4A RID: 73034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCuesAddedAndWhileActive_WithParams_Internal(IntPtr @this, IntPtr GameplayCueTags, IntPtr PredictionKey, IntPtr GameplayCueParameters);

		// Token: 0x06011D4B RID: 73035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueExecuted_WithParams_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr PredictionKey, IntPtr GameplayCueParameters);

		// Token: 0x06011D4C RID: 73036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueExecuted_FromSpec_Internal(IntPtr @this, IntPtr Spec, IntPtr PredictionKey);

		// Token: 0x06011D4D RID: 73037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueExecuted_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr PredictionKey, IntPtr EffectContext);

		// Token: 0x06011D4E RID: 73038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueAddedAndWhileActive_WithParams_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr PredictionKey, IntPtr GameplayCueParameters);

		// Token: 0x06011D4F RID: 73039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueAddedAndWhileActive_FromSpec_Internal(IntPtr @this, IntPtr Spec, IntPtr PredictionKey);

		// Token: 0x06011D50 RID: 73040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueAdded_WithParams_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr PredictionKey, IntPtr Parameters);

		// Token: 0x06011D51 RID: 73041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NetMulticast_InvokeGameplayCueAdded_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr PredictionKey, IntPtr EffectContext);

		// Token: 0x06011D52 RID: 73042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeOutgoingSpec_Internal(IntPtr @this, IntPtr GameplayEffectClass, float Level, IntPtr Context);

		// Token: 0x06011D53 RID: 73043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeEffectContext_Internal(IntPtr @this);

		// Token: 0x06011D54 RID: 73044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_InitStats_Internal(IntPtr @this, IntPtr Attributes, IntPtr DataTable);

		// Token: 0x06011D55 RID: 73045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGameplayCueActive_Internal(IntPtr @this, FGameplayTag GameplayCueTag);

		// Token: 0x06011D56 RID: 73046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUserAbilityActivationInhibited_Internal(IntPtr @this);

		// Token: 0x06011D57 RID: 73047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTagCount_Internal(IntPtr @this, FGameplayTag TagToCheck);

		// Token: 0x06011D58 RID: 73048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameplayEffectMagnitude_Internal(IntPtr @this, IntPtr Handle, IntPtr Attribute);

		// Token: 0x06011D59 RID: 73049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGameplayEffectCount_Internal(IntPtr @this, IntPtr SourceGameplayEffect, IntPtr OptionalInstigatorFilterComponent, bool bEnforceOnGoingCheck);

		// Token: 0x06011D5A RID: 73050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveEffectsWithAllTags_Internal(IntPtr @this, IntPtr Tags);

		// Token: 0x06011D5B RID: 73051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveEffects_Internal(IntPtr @this, IntPtr Query);

		// Token: 0x06011D5C RID: 73052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTryActivateAbility_Internal(IntPtr @this, IntPtr AbilityToActivate);

		// Token: 0x06011D5D RID: 73053
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetReplicatedEvent_Internal(IntPtr @this, TEnumAsByte<EAbilityGenericReplicatedEvent> EventType, IntPtr AbilityHandle, IntPtr AbilityOriginalPredictionKey);

		// Token: 0x06011D5E RID: 73054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrintDebug_Response_Internal(IntPtr @this, IntPtr Strings, int GameFlags);

		// Token: 0x06011D5F RID: 73055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientEndAbility_Internal(IntPtr @this, IntPtr AbilityToEnd, IntPtr ActivationInfo);

		// Token: 0x06011D60 RID: 73056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCancelAbility_Internal(IntPtr @this, IntPtr AbilityToCancel, IntPtr ActivationInfo);

		// Token: 0x06011D61 RID: 73057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientActivateAbilitySucceedWithEventData_Internal(IntPtr @this, IntPtr AbilityToActivate, IntPtr PredictionKey, IntPtr TriggerEventData);

		// Token: 0x06011D62 RID: 73058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientActivateAbilitySucceed_Internal(IntPtr @this, IntPtr AbilityToActivate, IntPtr PredictionKey);

		// Token: 0x06011D63 RID: 73059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientActivateAbilityFailed_Internal(IntPtr @this, IntPtr AbilityToActivate, short PredictionKey);

		// Token: 0x06011D64 RID: 73060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectToTarget_Internal(IntPtr @this, IntPtr GameplayEffectClass, IntPtr Target, float Level, IntPtr Context);

		// Token: 0x06011D65 RID: 73061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectToSelf_Internal(IntPtr @this, IntPtr GameplayEffectClass, float Level, IntPtr EffectContext);

		// Token: 0x06011D66 RID: 73062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectSpecToTarget_Internal(IntPtr @this, IntPtr SpecHandle, IntPtr Target);

		// Token: 0x06011D67 RID: 73063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectSpecToSelf_Internal(IntPtr @this, IntPtr SpecHandle);

		// Token: 0x06011D68 RID: 73064 RVA: 0x001A2A90 File Offset: 0x001A0C90
		static UAbilitySystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemComponent");
		}

		// Token: 0x06011D69 RID: 73065 RVA: 0x001A2A9E File Offset: 0x001A0C9E
		protected UAbilitySystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009867 RID: 39015
		internal static int __InterfaceOffset_IGameplayTagAssetInterface;

		// Token: 0x04009868 RID: 39016
		internal static int __InterfaceOffset_IAbilitySystemReplicationProxyInterface;

		// Token: 0x04009869 RID: 39017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemComponent";

		// Token: 0x0400986A RID: 39018
		private static IntPtr _ClassPtr;

		// Token: 0x0400986B RID: 39019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400986C RID: 39020
		public static IntPtr __AbilityConfirmOrCancel__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400986D RID: 39021
		public static IntPtr __AbilityAbilityKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400986E RID: 39022
		internal static int __PropertyOffset_DefaultStartingData;

		// Token: 0x0400986F RID: 39023
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAttributeDefaults> _DefaultStartingData;

		// Token: 0x04009870 RID: 39024
		internal static int __PropertyOffset_SpawnedAttributes;

		// Token: 0x04009871 RID: 39025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAttributeSet> _SpawnedAttributes;

		// Token: 0x04009872 RID: 39026
		internal static int __PropertyOffset_AffectedAnimInstanceTag;

		// Token: 0x04009873 RID: 39027
		internal static int __PropertyOffset_OutgoingDuration;

		// Token: 0x04009874 RID: 39028
		internal static int __PropertyOffset_IncomingDuration;

		// Token: 0x04009875 RID: 39029
		internal static int __PropertyOffset_ClientDebugStrings;

		// Token: 0x04009876 RID: 39030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ClientDebugStrings;

		// Token: 0x04009877 RID: 39031
		internal static int __PropertyOffset_ServerDebugStrings;

		// Token: 0x04009878 RID: 39032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ServerDebugStrings;

		// Token: 0x04009879 RID: 39033
		internal static int __PropertyOffset_UserAbilityActivationInhibited;

		// Token: 0x0400987A RID: 39034
		internal static int __PropertyOffset_ReplicationProxyEnabled;

		// Token: 0x0400987B RID: 39035
		internal static int __PropertyOffset_bSuppressGrantAbility;

		// Token: 0x0400987C RID: 39036
		internal static int __PropertyOffset_bSuppressGameplayCues;

		// Token: 0x0400987D RID: 39037
		internal static int __PropertyOffset_SpawnedTargetActors;

		// Token: 0x0400987E RID: 39038
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AGameplayAbilityTargetActor> _SpawnedTargetActors;

		// Token: 0x0400987F RID: 39039
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x04009880 RID: 39040
		internal static int __PropertyOffset_AvatarActor;

		// Token: 0x04009881 RID: 39041
		internal static int __PropertyOffset_ActivatableAbilities;

		// Token: 0x04009882 RID: 39042
		private FGameplayAbilitySpecContainer _ActivatableAbilities;

		// Token: 0x04009883 RID: 39043
		internal static int __PropertyOffset_AllReplicatedInstancedAbilities;

		// Token: 0x04009884 RID: 39044
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayAbility> _AllReplicatedInstancedAbilities;

		// Token: 0x04009885 RID: 39045
		internal static int __PropertyOffset_RepAnimMontageInfo;

		// Token: 0x04009886 RID: 39046
		private FGameplayAbilityRepAnimMontage _RepAnimMontageInfo;

		// Token: 0x04009887 RID: 39047
		internal static int __PropertyOffset_bCachedIsNetSimulated;

		// Token: 0x04009888 RID: 39048
		internal static int __PropertyOffset_bPendingMontageRep;

		// Token: 0x04009889 RID: 39049
		internal static int __PropertyOffset_LocalAnimMontageInfo;

		// Token: 0x0400988A RID: 39050
		private FGameplayAbilityLocalAnimMontage _LocalAnimMontageInfo;

		// Token: 0x0400988B RID: 39051
		internal static int __PropertyOffset_ActiveGameplayEffects;

		// Token: 0x0400988C RID: 39052
		private FActiveGameplayEffectsContainer _ActiveGameplayEffects;

		// Token: 0x0400988D RID: 39053
		internal static int __PropertyOffset_ActiveGameplayCues;

		// Token: 0x0400988E RID: 39054
		private FActiveGameplayCueContainer _ActiveGameplayCues;

		// Token: 0x0400988F RID: 39055
		internal static int __PropertyOffset_MinimalReplicationGameplayCues;

		// Token: 0x04009890 RID: 39056
		private FActiveGameplayCueContainer _MinimalReplicationGameplayCues;

		// Token: 0x04009891 RID: 39057
		internal static int __PropertyOffset_BlockedAbilityBindings;

		// Token: 0x04009892 RID: 39058
		private TArray<byte> _BlockedAbilityBindings;

		// Token: 0x04009893 RID: 39059
		internal static int __PropertyOffset_MinimalReplicationTags;

		// Token: 0x04009894 RID: 39060
		private FMinimalReplicationTagCountMap _MinimalReplicationTags;

		// Token: 0x04009895 RID: 39061
		internal static int __PropertyOffset_ReplicatedPredictionKeyMap;

		// Token: 0x04009896 RID: 39062
		private FReplicatedPredictionKeyMap _ReplicatedPredictionKeyMap;

		// Token: 0x04009897 RID: 39063
		internal static int __PropertyOffset_TagUpdated;

		// Token: 0x04009898 RID: 39064
		private FTagUpdated _TagUpdated;
	}
}
