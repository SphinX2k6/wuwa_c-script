using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200134B RID: 4939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbility")]
	[UnrealStructLayout(960, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UGameplayAbility : UObject, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012147 RID: 74055 RVA: 0x001A8E79 File Offset: 0x001A7079
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbility._ClassPtr;
		}

		// Token: 0x06012148 RID: 74056 RVA: 0x001A8E85 File Offset: 0x001A7085
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return UGameplayAbility.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x06012149 RID: 74057 RVA: 0x001A8E8C File Offset: 0x001A708C
		public UGameplayAbility() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601214A RID: 74058 RVA: 0x001A8EB4 File Offset: 0x001A70B4
		public UGameplayAbility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x0601214B RID: 74059 RVA: 0x001A8EE8 File Offset: 0x001A70E8
		// (set) Token: 0x0601214C RID: 74060 RVA: 0x001A8F21 File Offset: 0x001A7121
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

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x0601214D RID: 74061 RVA: 0x001A8F42 File Offset: 0x001A7142
		// (set) Token: 0x0601214E RID: 74062 RVA: 0x001A8F52 File Offset: 0x001A7152
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

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x0601214F RID: 74063 RVA: 0x001A8F63 File Offset: 0x001A7163
		// (set) Token: 0x06012150 RID: 74064 RVA: 0x001A8F73 File Offset: 0x001A7173
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

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x06012151 RID: 74065 RVA: 0x001A8F84 File Offset: 0x001A7184
		// (set) Token: 0x06012152 RID: 74066 RVA: 0x001A8F98 File Offset: 0x001A7198
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayAbilityReplicationPolicy> ReplicationPolicy
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ReplicationPolicy);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_ReplicationPolicy) = value;
			}
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x06012153 RID: 74067 RVA: 0x001A8FAD File Offset: 0x001A71AD
		// (set) Token: 0x06012154 RID: 74068 RVA: 0x001A8FC1 File Offset: 0x001A71C1
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayAbilityInstancingPolicy> InstancingPolicy
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_InstancingPolicy);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_InstancingPolicy) = value;
			}
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x06012155 RID: 74069 RVA: 0x001A8FD6 File Offset: 0x001A71D6
		// (set) Token: 0x06012156 RID: 74070 RVA: 0x001A8FE6 File Offset: 0x001A71E6
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

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x06012157 RID: 74071 RVA: 0x001A8FF7 File Offset: 0x001A71F7
		// (set) Token: 0x06012158 RID: 74072 RVA: 0x001A9007 File Offset: 0x001A7207
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

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x06012159 RID: 74073 RVA: 0x001A9018 File Offset: 0x001A7218
		// (set) Token: 0x0601215A RID: 74074 RVA: 0x001A9051 File Offset: 0x001A7251
		public FGameplayAbilityActivationInfo CurrentActivationInfo
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityActivationInfo result;
				if ((result = this._CurrentActivationInfo) == null)
				{
					result = (this._CurrentActivationInfo = new FGameplayAbilityActivationInfo(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CurrentActivationInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActivationInfo.StaticStruct(), base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CurrentActivationInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x0601215B RID: 74075 RVA: 0x001A9074 File Offset: 0x001A7274
		// (set) Token: 0x0601215C RID: 74076 RVA: 0x001A90AD File Offset: 0x001A72AD
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

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x0601215D RID: 74077 RVA: 0x001A90CE File Offset: 0x001A72CE
		// (set) Token: 0x0601215E RID: 74078 RVA: 0x001A90E2 File Offset: 0x001A72E2
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayAbilityNetExecutionPolicy> NetExecutionPolicy
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_NetExecutionPolicy);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_NetExecutionPolicy) = value;
			}
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x0601215F RID: 74079 RVA: 0x001A90F7 File Offset: 0x001A72F7
		// (set) Token: 0x06012160 RID: 74080 RVA: 0x001A910B File Offset: 0x001A730B
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayAbilityNetSecurityPolicy> NetSecurityPolicy
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_NetSecurityPolicy);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_NetSecurityPolicy) = value;
			}
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x06012161 RID: 74081 RVA: 0x001A9120 File Offset: 0x001A7320
		// (set) Token: 0x06012162 RID: 74082 RVA: 0x001A9134 File Offset: 0x001A7334
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> CostGameplayEffectClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CostGameplayEffectClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CostGameplayEffectClass) = value;
			}
		}

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x06012163 RID: 74083 RVA: 0x001A914C File Offset: 0x001A734C
		// (set) Token: 0x06012164 RID: 74084 RVA: 0x001A9185 File Offset: 0x001A7385
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

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x06012165 RID: 74085 RVA: 0x001A9193 File Offset: 0x001A7393
		// (set) Token: 0x06012166 RID: 74086 RVA: 0x001A91A7 File Offset: 0x001A73A7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> CooldownGameplayEffectClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CooldownGameplayEffectClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayAbility.__PropertyOffset_CooldownGameplayEffectClass) = value;
			}
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x06012167 RID: 74087 RVA: 0x001A91BC File Offset: 0x001A73BC
		// (set) Token: 0x06012168 RID: 74088 RVA: 0x001A91F5 File Offset: 0x001A73F5
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

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x06012169 RID: 74089 RVA: 0x001A9218 File Offset: 0x001A7418
		// (set) Token: 0x0601216A RID: 74090 RVA: 0x001A9251 File Offset: 0x001A7451
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

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x0601216B RID: 74091 RVA: 0x001A9274 File Offset: 0x001A7474
		// (set) Token: 0x0601216C RID: 74092 RVA: 0x001A92AD File Offset: 0x001A74AD
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

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x0601216D RID: 74093 RVA: 0x001A92D0 File Offset: 0x001A74D0
		// (set) Token: 0x0601216E RID: 74094 RVA: 0x001A9309 File Offset: 0x001A7509
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

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x0601216F RID: 74095 RVA: 0x001A932C File Offset: 0x001A752C
		// (set) Token: 0x06012170 RID: 74096 RVA: 0x001A9365 File Offset: 0x001A7565
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

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x06012171 RID: 74097 RVA: 0x001A9388 File Offset: 0x001A7588
		// (set) Token: 0x06012172 RID: 74098 RVA: 0x001A93C1 File Offset: 0x001A75C1
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

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x06012173 RID: 74099 RVA: 0x001A93E4 File Offset: 0x001A75E4
		// (set) Token: 0x06012174 RID: 74100 RVA: 0x001A941D File Offset: 0x001A761D
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

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x06012175 RID: 74101 RVA: 0x001A9440 File Offset: 0x001A7640
		// (set) Token: 0x06012176 RID: 74102 RVA: 0x001A9479 File Offset: 0x001A7679
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

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x06012177 RID: 74103 RVA: 0x001A949C File Offset: 0x001A769C
		// (set) Token: 0x06012178 RID: 74104 RVA: 0x001A94D5 File Offset: 0x001A76D5
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

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x06012179 RID: 74105 RVA: 0x001A94F8 File Offset: 0x001A76F8
		// (set) Token: 0x0601217A RID: 74106 RVA: 0x001A9531 File Offset: 0x001A7731
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

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x0601217B RID: 74107 RVA: 0x001A953F File Offset: 0x001A773F
		// (set) Token: 0x0601217C RID: 74108 RVA: 0x001A9553 File Offset: 0x001A7753
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

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x0601217D RID: 74109 RVA: 0x001A9568 File Offset: 0x001A7768
		// (set) Token: 0x0601217E RID: 74110 RVA: 0x001A9578 File Offset: 0x001A7778
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

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0601217F RID: 74111 RVA: 0x001A9589 File Offset: 0x001A7789
		// (set) Token: 0x06012180 RID: 74112 RVA: 0x001A9599 File Offset: 0x001A7799
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

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x06012181 RID: 74113 RVA: 0x001A95AA File Offset: 0x001A77AA
		// (set) Token: 0x06012182 RID: 74114 RVA: 0x001A95BA File Offset: 0x001A77BA
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

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06012183 RID: 74115 RVA: 0x001A95CB File Offset: 0x001A77CB
		// (set) Token: 0x06012184 RID: 74116 RVA: 0x001A95DB File Offset: 0x001A77DB
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

		// Token: 0x06012185 RID: 74117 RVA: 0x001A95EC File Offset: 0x001A77EC
		public void SetShouldBlockOtherAbilities(bool bShouldBlockAbilities)
		{
			UGameplayAbility.__SetShouldBlockOtherAbilities_Internal(base.NativePtr, bShouldBlockAbilities);
		}

		// Token: 0x06012186 RID: 74118 RVA: 0x001A95FA File Offset: 0x001A77FA
		public void SetCanBeCanceled(bool bCanBeCanceled)
		{
			UGameplayAbility.__SetCanBeCanceled_Internal(base.NativePtr, bCanBeCanceled);
		}

		// Token: 0x06012187 RID: 74119 RVA: 0x001A9608 File Offset: 0x001A7808
		[NullableContext(2)]
		public void SendGameplayEvent(FGameplayTag EventTag, FGameplayEventData Payload)
		{
			UGameplayAbility.__SendGameplayEvent_Internal(base.NativePtr, EventTag, (Payload ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06012188 RID: 74120 RVA: 0x001A9625 File Offset: 0x001A7825
		public void RemoveGrantedByEffect()
		{
			UGameplayAbility.__RemoveGrantedByEffect_Internal(base.NativePtr);
		}

		// Token: 0x06012189 RID: 74121 RVA: 0x001A9632 File Offset: 0x001A7832
		public void MontageStop(float OverrideBlendOutTime = -1f)
		{
			UGameplayAbility.__MontageStop_Internal(base.NativePtr, OverrideBlendOutTime);
		}

		// Token: 0x0601218A RID: 74122 RVA: 0x001A9640 File Offset: 0x001A7840
		public void MontageSetNextSectionName(FName FromSectionName, FName ToSectionName)
		{
			UGameplayAbility.__MontageSetNextSectionName_Internal(base.NativePtr, FromSectionName, ToSectionName);
		}

		// Token: 0x0601218B RID: 74123 RVA: 0x001A964F File Offset: 0x001A784F
		public void MontageJumpToSection(FName SectionName)
		{
			UGameplayAbility.__MontageJumpToSection_Internal(base.NativePtr, SectionName);
		}

		// Token: 0x0601218C RID: 74124 RVA: 0x001A965D File Offset: 0x001A785D
		public FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerSkeletalMeshComponent(FName SocketName)
		{
			return new FGameplayAbilityTargetingLocationInfo(UGameplayAbility.__MakeTargetLocationInfoFromOwnerSkeletalMeshComponent_Internal(base.NativePtr, SocketName), null);
		}

		// Token: 0x0601218D RID: 74125 RVA: 0x001A9671 File Offset: 0x001A7871
		public FGameplayAbilityTargetingLocationInfo MakeTargetLocationInfoFromOwnerActor()
		{
			return new FGameplayAbilityTargetingLocationInfo(UGameplayAbility.__MakeTargetLocationInfoFromOwnerActor_Internal(base.NativePtr), null);
		}

		// Token: 0x0601218E RID: 74126 RVA: 0x001A9684 File Offset: 0x001A7884
		public FGameplayEffectSpecHandle MakeOutgoingGameplayEffectSpec([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, float Level = 1f)
		{
			return new FGameplayEffectSpecHandle(UGameplayAbility.__MakeOutgoingGameplayEffectSpec_Internal(base.NativePtr, GameplayEffectClass._NativePtr, Level), null);
		}

		// Token: 0x0601218F RID: 74127 RVA: 0x001A969E File Offset: 0x001A789E
		[NullableContext(2)]
		public virtual bool K2_ShouldAbilityRespondToEvent(FGameplayAbilityActorInfo ActorInfo, FGameplayEventData Payload)
		{
			return UGameplayAbility.__K2_ShouldAbilityRespondToEvent_Internal(base.NativePtr, (ActorInfo ?? new FGameplayAbilityActorInfo()).NativePtr, (Payload ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06012190 RID: 74128 RVA: 0x001A96C9 File Offset: 0x001A78C9
		public void K2_RemoveGameplayCue(FGameplayTag GameplayCueTag)
		{
			UGameplayAbility.__K2_RemoveGameplayCue_Internal(base.NativePtr, GameplayCueTag);
		}

		// Token: 0x06012191 RID: 74129 RVA: 0x001A96D7 File Offset: 0x001A78D7
		public virtual void K2_OnEndAbility(bool bWasCancelled)
		{
			UGameplayAbility.__K2_OnEndAbility_Internal(base.NativePtr, bWasCancelled);
		}

		// Token: 0x06012192 RID: 74130 RVA: 0x001A96E5 File Offset: 0x001A78E5
		public bool K2_HasAuthority()
		{
			return UGameplayAbility.__K2_HasAuthority_Internal(base.NativePtr);
		}

		// Token: 0x06012193 RID: 74131 RVA: 0x001A96F2 File Offset: 0x001A78F2
		[NullableContext(2)]
		public void K2_ExecuteGameplayCueWithParams(FGameplayTag GameplayCueTag, in FGameplayCueParameters GameplayCueParameters)
		{
			UGameplayAbility.__K2_ExecuteGameplayCueWithParams_Internal(base.NativePtr, GameplayCueTag, (GameplayCueParameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06012194 RID: 74132 RVA: 0x001A9710 File Offset: 0x001A7910
		[NullableContext(2)]
		public void K2_ExecuteGameplayCue(FGameplayTag GameplayCueTag, FGameplayEffectContextHandle Context)
		{
			UGameplayAbility.__K2_ExecuteGameplayCue_Internal(base.NativePtr, GameplayCueTag, (Context ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06012195 RID: 74133 RVA: 0x001A972D File Offset: 0x001A792D
		public void K2_EndAbility()
		{
			UGameplayAbility.__K2_EndAbility_Internal(base.NativePtr);
		}

		// Token: 0x06012196 RID: 74134 RVA: 0x001A973A File Offset: 0x001A793A
		public virtual void K2_CommitExecute()
		{
			UGameplayAbility.__K2_CommitExecute_Internal(base.NativePtr);
		}

		// Token: 0x06012197 RID: 74135 RVA: 0x001A9747 File Offset: 0x001A7947
		public bool K2_CommitAbilityCost(bool BroadcastCommitEvent = false)
		{
			return UGameplayAbility.__K2_CommitAbilityCost_Internal(base.NativePtr, BroadcastCommitEvent);
		}

		// Token: 0x06012198 RID: 74136 RVA: 0x001A9755 File Offset: 0x001A7955
		public bool K2_CommitAbilityCooldown(bool BroadcastCommitEvent = false, bool ForceCooldown = false)
		{
			return UGameplayAbility.__K2_CommitAbilityCooldown_Internal(base.NativePtr, BroadcastCommitEvent, ForceCooldown);
		}

		// Token: 0x06012199 RID: 74137 RVA: 0x001A9764 File Offset: 0x001A7964
		public bool K2_CommitAbility()
		{
			return UGameplayAbility.__K2_CommitAbility_Internal(base.NativePtr);
		}

		// Token: 0x0601219A RID: 74138 RVA: 0x001A9771 File Offset: 0x001A7971
		public bool K2_CheckAbilityCost()
		{
			return UGameplayAbility.__K2_CheckAbilityCost_Internal(base.NativePtr);
		}

		// Token: 0x0601219B RID: 74139 RVA: 0x001A977E File Offset: 0x001A797E
		public bool K2_CheckAbilityCooldown()
		{
			return UGameplayAbility.__K2_CheckAbilityCooldown_Internal(base.NativePtr);
		}

		// Token: 0x0601219C RID: 74140 RVA: 0x001A978B File Offset: 0x001A798B
		public void K2_CancelAbility()
		{
			UGameplayAbility.__K2_CancelAbility_Internal(base.NativePtr);
		}

		// Token: 0x0601219D RID: 74141 RVA: 0x001A9798 File Offset: 0x001A7998
		[NullableContext(2)]
		public virtual bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			return UGameplayAbility.__K2_CanActivateAbility_Internal(base.NativePtr, (ActorInfo ?? new FGameplayAbilityActorInfo()).NativePtr, (RelevantTags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0601219E RID: 74142 RVA: 0x001A97C4 File Offset: 0x001A79C4
		[NullableContext(2)]
		[return: Nullable(1)]
		public TArray<FActiveGameplayEffectHandle> K2_ApplyGameplayEffectSpecToTarget(FGameplayEffectSpecHandle EffectSpecHandle, FGameplayAbilityTargetDataHandle TargetData)
		{
			return new TArray<FActiveGameplayEffectHandle>(UGameplayAbility.__K2_ApplyGameplayEffectSpecToTarget_Internal(base.NativePtr, (EffectSpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr), null);
		}

		// Token: 0x0601219F RID: 74143 RVA: 0x001A97F5 File Offset: 0x001A79F5
		public FActiveGameplayEffectHandle K2_ApplyGameplayEffectSpecToOwner([Nullable(2)] FGameplayEffectSpecHandle EffectSpecHandle)
		{
			return new FActiveGameplayEffectHandle(UGameplayAbility.__K2_ApplyGameplayEffectSpecToOwner_Internal(base.NativePtr, (EffectSpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x060121A0 RID: 74144 RVA: 0x001A9817 File Offset: 0x001A7A17
		[NullableContext(2)]
		public void K2_AddGameplayCueWithParams(FGameplayTag GameplayCueTag, in FGameplayCueParameters GameplayCueParameter, bool bRemoveOnAbilityEnd = true)
		{
			UGameplayAbility.__K2_AddGameplayCueWithParams_Internal(base.NativePtr, GameplayCueTag, (GameplayCueParameter ?? new FGameplayCueParameters()).NativePtr, bRemoveOnAbilityEnd);
		}

		// Token: 0x060121A1 RID: 74145 RVA: 0x001A9836 File Offset: 0x001A7A36
		[NullableContext(2)]
		public void K2_AddGameplayCue(FGameplayTag GameplayCueTag, FGameplayEffectContextHandle Context, bool bRemoveOnAbilityEnd = true)
		{
			UGameplayAbility.__K2_AddGameplayCue_Internal(base.NativePtr, GameplayCueTag, (Context ?? new FGameplayEffectContextHandle()).NativePtr, bRemoveOnAbilityEnd);
		}

		// Token: 0x060121A2 RID: 74146 RVA: 0x001A9854 File Offset: 0x001A7A54
		[NullableContext(2)]
		public virtual void K2_ActivateAbilityFromEvent(in FGameplayEventData EventData)
		{
			UGameplayAbility.__K2_ActivateAbilityFromEvent_Internal(base.NativePtr, (EventData ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x060121A3 RID: 74147 RVA: 0x001A9871 File Offset: 0x001A7A71
		public virtual void K2_ActivateAbility()
		{
			UGameplayAbility.__K2_ActivateAbility_Internal(base.NativePtr);
		}

		// Token: 0x060121A4 RID: 74148 RVA: 0x001A987E File Offset: 0x001A7A7E
		public bool IsLocallyControlled()
		{
			return UGameplayAbility.__IsLocallyControlled_Internal(base.NativePtr);
		}

		// Token: 0x060121A5 RID: 74149 RVA: 0x001A988B File Offset: 0x001A7A8B
		public void InvalidateClientPredictionKey()
		{
			UGameplayAbility.__InvalidateClientPredictionKey_Internal(base.NativePtr);
		}

		// Token: 0x060121A6 RID: 74150 RVA: 0x001A9898 File Offset: 0x001A7A98
		[NullableContext(2)]
		public USkeletalMeshComponent GetOwningComponentFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UGameplayAbility.__GetOwningComponentFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x060121A7 RID: 74151 RVA: 0x001A98AA File Offset: 0x001A7AAA
		[NullableContext(2)]
		public AActor GetOwningActorFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayAbility.__GetOwningActorFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x060121A8 RID: 74152 RVA: 0x001A98BC File Offset: 0x001A7ABC
		public FGameplayEffectContextHandle GetGrantedByEffectContext()
		{
			return new FGameplayEffectContextHandle(UGameplayAbility.__GetGrantedByEffectContext_Internal(base.NativePtr), null);
		}

		// Token: 0x060121A9 RID: 74153 RVA: 0x001A98CF File Offset: 0x001A7ACF
		[NullableContext(2)]
		public UObject GetCurrentSourceObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UGameplayAbility.__GetCurrentSourceObject_Internal(base.NativePtr));
		}

		// Token: 0x060121AA RID: 74154 RVA: 0x001A98E1 File Offset: 0x001A7AE1
		[NullableContext(2)]
		public UAnimMontage GetCurrentMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(UGameplayAbility.__GetCurrentMontage_Internal(base.NativePtr));
		}

		// Token: 0x060121AB RID: 74155 RVA: 0x001A98F3 File Offset: 0x001A7AF3
		public float GetCooldownTimeRemaining()
		{
			return UGameplayAbility.__GetCooldownTimeRemaining_Internal(base.NativePtr);
		}

		// Token: 0x060121AC RID: 74156 RVA: 0x001A9900 File Offset: 0x001A7B00
		public FGameplayEffectContextHandle GetContextFromOwner([Nullable(2)] FGameplayAbilityTargetDataHandle OptionalTargetData)
		{
			return new FGameplayEffectContextHandle(UGameplayAbility.__GetContextFromOwner_Internal(base.NativePtr, (OptionalTargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr), null);
		}

		// Token: 0x060121AD RID: 74157 RVA: 0x001A9922 File Offset: 0x001A7B22
		[NullableContext(2)]
		public AActor GetAvatarActorFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayAbility.__GetAvatarActorFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x060121AE RID: 74158 RVA: 0x001A9934 File Offset: 0x001A7B34
		public FGameplayAbilityActorInfo GetActorInfo()
		{
			return new FGameplayAbilityActorInfo(UGameplayAbility.__GetActorInfo_Internal(base.NativePtr), null);
		}

		// Token: 0x060121AF RID: 74159 RVA: 0x001A9947 File Offset: 0x001A7B47
		[NullableContext(2)]
		public UAbilitySystemComponent GetAbilitySystemComponentFromActorInfo()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilitySystemComponent>(UGameplayAbility.__GetAbilitySystemComponentFromActorInfo_Internal(base.NativePtr));
		}

		// Token: 0x060121B0 RID: 74160 RVA: 0x001A9959 File Offset: 0x001A7B59
		public int GetAbilityLevel()
		{
			return UGameplayAbility.__GetAbilityLevel_Internal(base.NativePtr);
		}

		// Token: 0x060121B1 RID: 74161 RVA: 0x001A9966 File Offset: 0x001A7B66
		public void EndTaskByInstanceName(FName InstanceName)
		{
			UGameplayAbility.__EndTaskByInstanceName_Internal(base.NativePtr, InstanceName);
		}

		// Token: 0x060121B2 RID: 74162 RVA: 0x001A9974 File Offset: 0x001A7B74
		public void EndAbilityState(FName OptionalStateNameToEnd)
		{
			UGameplayAbility.__EndAbilityState_Internal(base.NativePtr, OptionalStateNameToEnd);
		}

		// Token: 0x060121B3 RID: 74163 RVA: 0x001A9982 File Offset: 0x001A7B82
		public void ConfirmTaskByInstanceName(FName InstanceName, bool bEndTask)
		{
			UGameplayAbility.__ConfirmTaskByInstanceName_Internal(base.NativePtr, InstanceName, bEndTask);
		}

		// Token: 0x060121B4 RID: 74164 RVA: 0x001A9991 File Offset: 0x001A7B91
		public void CancelTaskByInstanceName(FName InstanceName)
		{
			UGameplayAbility.__CancelTaskByInstanceName_Internal(base.NativePtr, InstanceName);
		}

		// Token: 0x060121B5 RID: 74165 RVA: 0x001A999F File Offset: 0x001A7B9F
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithHandle(FActiveGameplayEffectHandle Handle, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithHandle_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, StacksToRemove);
		}

		// Token: 0x060121B6 RID: 74166 RVA: 0x001A99BC File Offset: 0x001A7BBC
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithGrantedTags(FGameplayTagContainer WithGrantedTags, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithGrantedTags_Internal(base.NativePtr, (WithGrantedTags ?? new FGameplayTagContainer()).NativePtr, StacksToRemove);
		}

		// Token: 0x060121B7 RID: 74167 RVA: 0x001A99D9 File Offset: 0x001A7BD9
		[NullableContext(2)]
		public void BP_RemoveGameplayEffectFromOwnerWithAssetTags(FGameplayTagContainer WithAssetTags, int StacksToRemove = -1)
		{
			UGameplayAbility.__BP_RemoveGameplayEffectFromOwnerWithAssetTags_Internal(base.NativePtr, (WithAssetTags ?? new FGameplayTagContainer()).NativePtr, StacksToRemove);
		}

		// Token: 0x060121B8 RID: 74168 RVA: 0x001A99F6 File Offset: 0x001A7BF6
		public TArray<FActiveGameplayEffectHandle> BP_ApplyGameplayEffectToTarget([Nullable(2)] FGameplayAbilityTargetDataHandle TargetData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, int GameplayEffectLevel = 1, int Stacks = 1)
		{
			return new TArray<FActiveGameplayEffectHandle>(UGameplayAbility.__BP_ApplyGameplayEffectToTarget_Internal(base.NativePtr, (TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, GameplayEffectClass._NativePtr, GameplayEffectLevel, Stacks), null);
		}

		// Token: 0x060121B9 RID: 74169 RVA: 0x001A9A21 File Offset: 0x001A7C21
		public FActiveGameplayEffectHandle BP_ApplyGameplayEffectToOwner([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GameplayEffectClass, int GameplayEffectLevel = 1, int Stacks = 1)
		{
			return new FActiveGameplayEffectHandle(UGameplayAbility.__BP_ApplyGameplayEffectToOwner_Internal(base.NativePtr, GameplayEffectClass._NativePtr, GameplayEffectLevel, Stacks), null);
		}

		// Token: 0x060121BA RID: 74170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBlockOtherAbilities_Internal(IntPtr @this, bool bShouldBlockAbilities);

		// Token: 0x060121BB RID: 74171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanBeCanceled_Internal(IntPtr @this, bool bCanBeCanceled);

		// Token: 0x060121BC RID: 74172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendGameplayEvent_Internal(IntPtr @this, FGameplayTag EventTag, IntPtr Payload);

		// Token: 0x060121BD RID: 74173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveGrantedByEffect_Internal(IntPtr @this);

		// Token: 0x060121BE RID: 74174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageStop_Internal(IntPtr @this, float OverrideBlendOutTime);

		// Token: 0x060121BF RID: 74175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageSetNextSectionName_Internal(IntPtr @this, FName FromSectionName, FName ToSectionName);

		// Token: 0x060121C0 RID: 74176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MontageJumpToSection_Internal(IntPtr @this, FName SectionName);

		// Token: 0x060121C1 RID: 74177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTargetLocationInfoFromOwnerSkeletalMeshComponent_Internal(IntPtr @this, FName SocketName);

		// Token: 0x060121C2 RID: 74178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTargetLocationInfoFromOwnerActor_Internal(IntPtr @this);

		// Token: 0x060121C3 RID: 74179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeOutgoingGameplayEffectSpec_Internal(IntPtr @this, IntPtr GameplayEffectClass, float Level);

		// Token: 0x060121C4 RID: 74180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ShouldAbilityRespondToEvent_Internal(IntPtr @this, IntPtr ActorInfo, IntPtr Payload);

		// Token: 0x060121C5 RID: 74181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_RemoveGameplayCue_Internal(IntPtr @this, FGameplayTag GameplayCueTag);

		// Token: 0x060121C6 RID: 74182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndAbility_Internal(IntPtr @this, bool bWasCancelled);

		// Token: 0x060121C7 RID: 74183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_HasAuthority_Internal(IntPtr @this);

		// Token: 0x060121C8 RID: 74184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ExecuteGameplayCueWithParams_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr GameplayCueParameters);

		// Token: 0x060121C9 RID: 74185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ExecuteGameplayCue_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr Context);

		// Token: 0x060121CA RID: 74186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_EndAbility_Internal(IntPtr @this);

		// Token: 0x060121CB RID: 74187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CommitExecute_Internal(IntPtr @this);

		// Token: 0x060121CC RID: 74188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbilityCost_Internal(IntPtr @this, bool BroadcastCommitEvent);

		// Token: 0x060121CD RID: 74189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbilityCooldown_Internal(IntPtr @this, bool BroadcastCommitEvent, bool ForceCooldown);

		// Token: 0x060121CE RID: 74190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CommitAbility_Internal(IntPtr @this);

		// Token: 0x060121CF RID: 74191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CheckAbilityCost_Internal(IntPtr @this);

		// Token: 0x060121D0 RID: 74192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CheckAbilityCooldown_Internal(IntPtr @this);

		// Token: 0x060121D1 RID: 74193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CancelAbility_Internal(IntPtr @this);

		// Token: 0x060121D2 RID: 74194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_CanActivateAbility_Internal(IntPtr @this, IntPtr ActorInfo, IntPtr RelevantTags);

		// Token: 0x060121D3 RID: 74195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_ApplyGameplayEffectSpecToTarget_Internal(IntPtr @this, IntPtr EffectSpecHandle, IntPtr TargetData);

		// Token: 0x060121D4 RID: 74196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_ApplyGameplayEffectSpecToOwner_Internal(IntPtr @this, IntPtr EffectSpecHandle);

		// Token: 0x060121D5 RID: 74197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddGameplayCueWithParams_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr GameplayCueParameter, bool bRemoveOnAbilityEnd);

		// Token: 0x060121D6 RID: 74198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddGameplayCue_Internal(IntPtr @this, FGameplayTag GameplayCueTag, IntPtr Context, bool bRemoveOnAbilityEnd);

		// Token: 0x060121D7 RID: 74199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ActivateAbilityFromEvent_Internal(IntPtr @this, IntPtr EventData);

		// Token: 0x060121D8 RID: 74200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ActivateAbility_Internal(IntPtr @this);

		// Token: 0x060121D9 RID: 74201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocallyControlled_Internal(IntPtr @this);

		// Token: 0x060121DA RID: 74202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvalidateClientPredictionKey_Internal(IntPtr @this);

		// Token: 0x060121DB RID: 74203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningComponentFromActorInfo_Internal(IntPtr @this);

		// Token: 0x060121DC RID: 74204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningActorFromActorInfo_Internal(IntPtr @this);

		// Token: 0x060121DD RID: 74205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrantedByEffectContext_Internal(IntPtr @this);

		// Token: 0x060121DE RID: 74206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentSourceObject_Internal(IntPtr @this);

		// Token: 0x060121DF RID: 74207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentMontage_Internal(IntPtr @this);

		// Token: 0x060121E0 RID: 74208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCooldownTimeRemaining_Internal(IntPtr @this);

		// Token: 0x060121E1 RID: 74209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetContextFromOwner_Internal(IntPtr @this, IntPtr OptionalTargetData);

		// Token: 0x060121E2 RID: 74210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAvatarActorFromActorInfo_Internal(IntPtr @this);

		// Token: 0x060121E3 RID: 74211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorInfo_Internal(IntPtr @this);

		// Token: 0x060121E4 RID: 74212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAbilitySystemComponentFromActorInfo_Internal(IntPtr @this);

		// Token: 0x060121E5 RID: 74213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAbilityLevel_Internal(IntPtr @this);

		// Token: 0x060121E6 RID: 74214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTaskByInstanceName_Internal(IntPtr @this, FName InstanceName);

		// Token: 0x060121E7 RID: 74215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndAbilityState_Internal(IntPtr @this, FName OptionalStateNameToEnd);

		// Token: 0x060121E8 RID: 74216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmTaskByInstanceName_Internal(IntPtr @this, FName InstanceName, bool bEndTask);

		// Token: 0x060121E9 RID: 74217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelTaskByInstanceName_Internal(IntPtr @this, FName InstanceName);

		// Token: 0x060121EA RID: 74218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithHandle_Internal(IntPtr @this, IntPtr Handle, int StacksToRemove);

		// Token: 0x060121EB RID: 74219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithGrantedTags_Internal(IntPtr @this, IntPtr WithGrantedTags, int StacksToRemove);

		// Token: 0x060121EC RID: 74220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_RemoveGameplayEffectFromOwnerWithAssetTags_Internal(IntPtr @this, IntPtr WithAssetTags, int StacksToRemove);

		// Token: 0x060121ED RID: 74221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectToTarget_Internal(IntPtr @this, IntPtr TargetData, IntPtr GameplayEffectClass, int GameplayEffectLevel, int Stacks);

		// Token: 0x060121EE RID: 74222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_ApplyGameplayEffectToOwner_Internal(IntPtr @this, IntPtr GameplayEffectClass, int GameplayEffectLevel, int Stacks);

		// Token: 0x060121EF RID: 74223 RVA: 0x001A9A3C File Offset: 0x001A7C3C
		static UGameplayAbility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbility");
		}

		// Token: 0x060121F0 RID: 74224 RVA: 0x001A9A4A File Offset: 0x001A7C4A
		protected UGameplayAbility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009B24 RID: 39716
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04009B25 RID: 39717
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbility";

		// Token: 0x04009B26 RID: 39718
		private static IntPtr _ClassPtr;

		// Token: 0x04009B27 RID: 39719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009B28 RID: 39720
		internal static int __PropertyOffset_AbilityTags;

		// Token: 0x04009B29 RID: 39721
		[Nullable(2)]
		private FGameplayTagContainer _AbilityTags;

		// Token: 0x04009B2A RID: 39722
		internal static int __PropertyOffset_bReplicateInputDirectly;

		// Token: 0x04009B2B RID: 39723
		internal static int __PropertyOffset_RemoteInstanceEnded;

		// Token: 0x04009B2C RID: 39724
		internal static int __PropertyOffset_ReplicationPolicy;

		// Token: 0x04009B2D RID: 39725
		internal static int __PropertyOffset_InstancingPolicy;

		// Token: 0x04009B2E RID: 39726
		internal static int __PropertyOffset_bServerRespectsRemoteAbilityCancellation;

		// Token: 0x04009B2F RID: 39727
		internal static int __PropertyOffset_bRetriggerInstancedAbility;

		// Token: 0x04009B30 RID: 39728
		internal static int __PropertyOffset_CurrentActivationInfo;

		// Token: 0x04009B31 RID: 39729
		[Nullable(2)]
		private FGameplayAbilityActivationInfo _CurrentActivationInfo;

		// Token: 0x04009B32 RID: 39730
		internal static int __PropertyOffset_CurrentEventData;

		// Token: 0x04009B33 RID: 39731
		[Nullable(2)]
		private FGameplayEventData _CurrentEventData;

		// Token: 0x04009B34 RID: 39732
		internal static int __PropertyOffset_NetExecutionPolicy;

		// Token: 0x04009B35 RID: 39733
		internal static int __PropertyOffset_NetSecurityPolicy;

		// Token: 0x04009B36 RID: 39734
		internal static int __PropertyOffset_CostGameplayEffectClass;

		// Token: 0x04009B37 RID: 39735
		internal static int __PropertyOffset_AbilityTriggers;

		// Token: 0x04009B38 RID: 39736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAbilityTriggerData> _AbilityTriggers;

		// Token: 0x04009B39 RID: 39737
		internal static int __PropertyOffset_CooldownGameplayEffectClass;

		// Token: 0x04009B3A RID: 39738
		internal static int __PropertyOffset_CancelAbilitiesWithTag;

		// Token: 0x04009B3B RID: 39739
		[Nullable(2)]
		private FGameplayTagContainer _CancelAbilitiesWithTag;

		// Token: 0x04009B3C RID: 39740
		internal static int __PropertyOffset_BlockAbilitiesWithTag;

		// Token: 0x04009B3D RID: 39741
		[Nullable(2)]
		private FGameplayTagContainer _BlockAbilitiesWithTag;

		// Token: 0x04009B3E RID: 39742
		internal static int __PropertyOffset_ActivationOwnedTags;

		// Token: 0x04009B3F RID: 39743
		[Nullable(2)]
		private FGameplayTagContainer _ActivationOwnedTags;

		// Token: 0x04009B40 RID: 39744
		internal static int __PropertyOffset_ActivationRequiredTags;

		// Token: 0x04009B41 RID: 39745
		[Nullable(2)]
		private FGameplayTagContainer _ActivationRequiredTags;

		// Token: 0x04009B42 RID: 39746
		internal static int __PropertyOffset_ActivationBlockedTags;

		// Token: 0x04009B43 RID: 39747
		[Nullable(2)]
		private FGameplayTagContainer _ActivationBlockedTags;

		// Token: 0x04009B44 RID: 39748
		internal static int __PropertyOffset_SourceRequiredTags;

		// Token: 0x04009B45 RID: 39749
		[Nullable(2)]
		private FGameplayTagContainer _SourceRequiredTags;

		// Token: 0x04009B46 RID: 39750
		internal static int __PropertyOffset_SourceBlockedTags;

		// Token: 0x04009B47 RID: 39751
		[Nullable(2)]
		private FGameplayTagContainer _SourceBlockedTags;

		// Token: 0x04009B48 RID: 39752
		internal static int __PropertyOffset_TargetRequiredTags;

		// Token: 0x04009B49 RID: 39753
		[Nullable(2)]
		private FGameplayTagContainer _TargetRequiredTags;

		// Token: 0x04009B4A RID: 39754
		internal static int __PropertyOffset_TargetBlockedTags;

		// Token: 0x04009B4B RID: 39755
		[Nullable(2)]
		private FGameplayTagContainer _TargetBlockedTags;

		// Token: 0x04009B4C RID: 39756
		internal static int __PropertyOffset_ActiveTasks;

		// Token: 0x04009B4D RID: 39757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayTask> _ActiveTasks;

		// Token: 0x04009B4E RID: 39758
		internal static int __PropertyOffset_CurrentMontage;

		// Token: 0x04009B4F RID: 39759
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x04009B50 RID: 39760
		internal static int __PropertyOffset_bIsCancelable;

		// Token: 0x04009B51 RID: 39761
		internal static int __PropertyOffset_bIsBlockingOtherAbilities;

		// Token: 0x04009B52 RID: 39762
		internal static int __PropertyOffset_bMarkPendingKillOnAbilityEnd;

		// Token: 0x02002E2A RID: 11818
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __K2_ShouldAbilityRespondToEvent_FunctionParams
		{
			// Token: 0x040168C1 RID: 92353
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x040168C2 RID: 92354
			[FieldOffset(80)]
			public byte Payload;

			// Token: 0x040168C3 RID: 92355
			[FieldOffset(264)]
			public bool __Result;
		}

		// Token: 0x02002E2B RID: 11819
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040168C4 RID: 92356
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x02002E2C RID: 11820
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x040168C5 RID: 92357
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x040168C6 RID: 92358
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x040168C7 RID: 92359
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02002E2D RID: 11821
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __K2_ActivateAbilityFromEvent_FunctionParams
		{
			// Token: 0x040168C8 RID: 92360
			[FieldOffset(0)]
			public byte EventData;
		}
	}
}
