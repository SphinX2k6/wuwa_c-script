using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001353 RID: 4947
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpec")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FGameplayAbilitySpec : FFastArraySerializerItem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601225F RID: 74335 RVA: 0x001AA47E File Offset: 0x001A867E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpec._ScriptStructPtr != 0) ? FGameplayAbilitySpec._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpec", ref FGameplayAbilitySpec._ScriptStructPtr);
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x06012260 RID: 74336 RVA: 0x001AA4A4 File Offset: 0x001A86A4
		// (set) Token: 0x06012261 RID: 74337 RVA: 0x001AA4E7 File Offset: 0x001A86E7
		public FGameplayAbilitySpecHandle Handle
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecHandle result;
				if ((result = this._Handle) == null)
				{
					result = (this._Handle = new FGameplayAbilitySpecHandle(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_Handle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_Handle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x06012262 RID: 74338 RVA: 0x001AA508 File Offset: 0x001A8708
		// (set) Token: 0x06012263 RID: 74339 RVA: 0x001AA51C File Offset: 0x001A871C
		[Nullable(2)]
		public unsafe UGameplayAbility Ability
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpec.__PropertyOffset_Ability);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpec.__PropertyOffset_Ability, value);
			}
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x06012264 RID: 74340 RVA: 0x001AA531 File Offset: 0x001A8731
		// (set) Token: 0x06012265 RID: 74341 RVA: 0x001AA541 File Offset: 0x001A8741
		public unsafe int Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x06012266 RID: 74342 RVA: 0x001AA552 File Offset: 0x001A8752
		// (set) Token: 0x06012267 RID: 74343 RVA: 0x001AA562 File Offset: 0x001A8762
		public unsafe int InputID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_InputID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_InputID) = value;
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x06012268 RID: 74344 RVA: 0x001AA573 File Offset: 0x001A8773
		// (set) Token: 0x06012269 RID: 74345 RVA: 0x001AA587 File Offset: 0x001A8787
		[Nullable(2)]
		public unsafe UObject SourceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpec.__PropertyOffset_SourceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpec.__PropertyOffset_SourceObject, value);
			}
		}

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x0601226A RID: 74346 RVA: 0x001AA59C File Offset: 0x001A879C
		// (set) Token: 0x0601226B RID: 74347 RVA: 0x001AA5AC File Offset: 0x001A87AC
		public unsafe byte ActiveCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_ActiveCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_ActiveCount) = value;
			}
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x0601226C RID: 74348 RVA: 0x001AA5BD File Offset: 0x001A87BD
		// (set) Token: 0x0601226D RID: 74349 RVA: 0x001AA5D6 File Offset: 0x001A87D6
		public unsafe bool InputPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_InputPressed) & FGameplayAbilitySpec.__PropertyMask_InputPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_InputPressed) = ((*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_InputPressed) & ~FGameplayAbilitySpec.__PropertyMask_InputPressed) | (value ? FGameplayAbilitySpec.__PropertyMask_InputPressed : 0));
			}
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x0601226E RID: 74350 RVA: 0x001AA606 File Offset: 0x001A8806
		// (set) Token: 0x0601226F RID: 74351 RVA: 0x001AA61F File Offset: 0x001A881F
		public unsafe bool RemoveAfterActivation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_RemoveAfterActivation) & FGameplayAbilitySpec.__PropertyMask_RemoveAfterActivation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_RemoveAfterActivation) = ((*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_RemoveAfterActivation) & ~FGameplayAbilitySpec.__PropertyMask_RemoveAfterActivation) | (value ? FGameplayAbilitySpec.__PropertyMask_RemoveAfterActivation : 0));
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x06012270 RID: 74352 RVA: 0x001AA64F File Offset: 0x001A884F
		// (set) Token: 0x06012271 RID: 74353 RVA: 0x001AA668 File Offset: 0x001A8868
		public unsafe bool PendingRemove
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_PendingRemove) & FGameplayAbilitySpec.__PropertyMask_PendingRemove) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_PendingRemove) = ((*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_PendingRemove) & ~FGameplayAbilitySpec.__PropertyMask_PendingRemove) | (value ? FGameplayAbilitySpec.__PropertyMask_PendingRemove : 0));
			}
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x06012272 RID: 74354 RVA: 0x001AA698 File Offset: 0x001A8898
		// (set) Token: 0x06012273 RID: 74355 RVA: 0x001AA6B1 File Offset: 0x001A88B1
		public unsafe bool bActivateOnce
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_bActivateOnce) & FGameplayAbilitySpec.__PropertyMask_bActivateOnce) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_bActivateOnce) = ((*(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_bActivateOnce) & ~FGameplayAbilitySpec.__PropertyMask_bActivateOnce) | (value ? FGameplayAbilitySpec.__PropertyMask_bActivateOnce : 0));
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x06012274 RID: 74356 RVA: 0x001AA6E4 File Offset: 0x001A88E4
		// (set) Token: 0x06012275 RID: 74357 RVA: 0x001AA727 File Offset: 0x001A8927
		public FGameplayAbilityActivationInfo ActivationInfo
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityActivationInfo result;
				if ((result = this._ActivationInfo) == null)
				{
					result = (this._ActivationInfo = new FGameplayAbilityActivationInfo(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_ActivationInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActivationInfo.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_ActivationInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x06012276 RID: 74358 RVA: 0x001AA748 File Offset: 0x001A8948
		// (set) Token: 0x06012277 RID: 74359 RVA: 0x001AA78B File Offset: 0x001A898B
		public FGameplayTagContainer DynamicAbilityTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DynamicAbilityTags) == null)
				{
					result = (this._DynamicAbilityTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_DynamicAbilityTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_DynamicAbilityTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x06012278 RID: 74360 RVA: 0x001AA7AC File Offset: 0x001A89AC
		// (set) Token: 0x06012279 RID: 74361 RVA: 0x001AA7EF File Offset: 0x001A89EF
		public TArray<UGameplayAbility> NonReplicatedInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayAbility> result;
				if ((result = this._NonReplicatedInstances) == null)
				{
					result = (this._NonReplicatedInstances = new TArray<UGameplayAbility>(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_NonReplicatedInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NonReplicatedInstances.CopyAssign(value);
			}
		}

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x0601227A RID: 74362 RVA: 0x001AA800 File Offset: 0x001A8A00
		// (set) Token: 0x0601227B RID: 74363 RVA: 0x001AA843 File Offset: 0x001A8A43
		public TArray<UGameplayAbility> ReplicatedInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGameplayAbility> result;
				if ((result = this._ReplicatedInstances) == null)
				{
					result = (this._ReplicatedInstances = new TArray<UGameplayAbility>(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_ReplicatedInstances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplicatedInstances.CopyAssign(value);
			}
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x0601227C RID: 74364 RVA: 0x001AA854 File Offset: 0x001A8A54
		// (set) Token: 0x0601227D RID: 74365 RVA: 0x001AA897 File Offset: 0x001A8A97
		public FActiveGameplayEffectHandle GameplayEffectHandle
		{
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayEffectHandle result;
				if ((result = this._GameplayEffectHandle) == null)
				{
					result = (this._GameplayEffectHandle = new FActiveGameplayEffectHandle(base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_GameplayEffectHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpec.__PropertyOffset_GameplayEffectHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601227E RID: 74366 RVA: 0x001AA8B8 File Offset: 0x001A8AB8
		public FGameplayAbilitySpec()
		{
		}

		// Token: 0x0601227F RID: 74367 RVA: 0x001AA8C0 File Offset: 0x001A8AC0
		public FGameplayAbilitySpec(FGameplayAbilitySpecHandle Handle, UGameplayAbility Ability, int Level, int InputID, UObject SourceObject, byte ActiveCount, bool InputPressed, bool RemoveAfterActivation, bool PendingRemove, bool bActivateOnce, FGameplayAbilityActivationInfo ActivationInfo, FGameplayTagContainer DynamicAbilityTags, TArray<UGameplayAbility> NonReplicatedInstances, TArray<UGameplayAbility> ReplicatedInstances, FActiveGameplayEffectHandle GameplayEffectHandle, int ReplicationID, int ReplicationKey, int MostRecentArrayReplicationKey)
		{
			this.Handle = Handle;
			this.Ability = Ability;
			this.Level = Level;
			this.InputID = InputID;
			this.SourceObject = SourceObject;
			this.ActiveCount = ActiveCount;
			this.InputPressed = InputPressed;
			this.RemoveAfterActivation = RemoveAfterActivation;
			this.PendingRemove = PendingRemove;
			this.bActivateOnce = bActivateOnce;
			this.ActivationInfo = ActivationInfo;
			this.DynamicAbilityTags = DynamicAbilityTags;
			this.NonReplicatedInstances = NonReplicatedInstances;
			this.ReplicatedInstances = ReplicatedInstances;
			this.GameplayEffectHandle = GameplayEffectHandle;
			base.ReplicationID = ReplicationID;
			base.ReplicationKey = ReplicationKey;
			base.MostRecentArrayReplicationKey = MostRecentArrayReplicationKey;
		}

		// Token: 0x06012280 RID: 74368 RVA: 0x001AA960 File Offset: 0x001A8B60
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpec.StaticStruct();
		}

		// Token: 0x06012281 RID: 74369 RVA: 0x001AA96C File Offset: 0x001A8B6C
		[NullableContext(2)]
		public FGameplayAbilitySpec(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012282 RID: 74370 RVA: 0x001AA976 File Offset: 0x001A8B76
		public FGameplayAbilitySpec(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012283 RID: 74371 RVA: 0x001AA981 File Offset: 0x001A8B81
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpec(Pointer, false, true);
		}

		// Token: 0x06012284 RID: 74372 RVA: 0x001AA98B File Offset: 0x001A8B8B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpec(Pointer, MemoryOwner);
		}

		// Token: 0x04009B8B RID: 39819
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpec";

		// Token: 0x04009B8C RID: 39820
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B8D RID: 39821
		internal static int __PropertyOffset_Handle;

		// Token: 0x04009B8E RID: 39822
		[Nullable(2)]
		private FGameplayAbilitySpecHandle _Handle;

		// Token: 0x04009B8F RID: 39823
		internal static int __PropertyOffset_Ability;

		// Token: 0x04009B90 RID: 39824
		internal static int __PropertyOffset_Level;

		// Token: 0x04009B91 RID: 39825
		internal static int __PropertyOffset_InputID;

		// Token: 0x04009B92 RID: 39826
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04009B93 RID: 39827
		internal static int __PropertyOffset_ActiveCount;

		// Token: 0x04009B94 RID: 39828
		internal static int __PropertyOffset_InputPressed;

		// Token: 0x04009B95 RID: 39829
		internal static byte __PropertyMask_InputPressed;

		// Token: 0x04009B96 RID: 39830
		internal static int __PropertyOffset_RemoveAfterActivation;

		// Token: 0x04009B97 RID: 39831
		internal static byte __PropertyMask_RemoveAfterActivation;

		// Token: 0x04009B98 RID: 39832
		internal static int __PropertyOffset_PendingRemove;

		// Token: 0x04009B99 RID: 39833
		internal static byte __PropertyMask_PendingRemove;

		// Token: 0x04009B9A RID: 39834
		internal static int __PropertyOffset_bActivateOnce;

		// Token: 0x04009B9B RID: 39835
		internal static byte __PropertyMask_bActivateOnce;

		// Token: 0x04009B9C RID: 39836
		internal static int __PropertyOffset_ActivationInfo;

		// Token: 0x04009B9D RID: 39837
		[Nullable(2)]
		private FGameplayAbilityActivationInfo _ActivationInfo;

		// Token: 0x04009B9E RID: 39838
		internal static int __PropertyOffset_DynamicAbilityTags;

		// Token: 0x04009B9F RID: 39839
		[Nullable(2)]
		private FGameplayTagContainer _DynamicAbilityTags;

		// Token: 0x04009BA0 RID: 39840
		internal static int __PropertyOffset_NonReplicatedInstances;

		// Token: 0x04009BA1 RID: 39841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayAbility> _NonReplicatedInstances;

		// Token: 0x04009BA2 RID: 39842
		internal static int __PropertyOffset_ReplicatedInstances;

		// Token: 0x04009BA3 RID: 39843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGameplayAbility> _ReplicatedInstances;

		// Token: 0x04009BA4 RID: 39844
		internal static int __PropertyOffset_GameplayEffectHandle;

		// Token: 0x04009BA5 RID: 39845
		[Nullable(2)]
		private FActiveGameplayEffectHandle _GameplayEffectHandle;
	}
}
