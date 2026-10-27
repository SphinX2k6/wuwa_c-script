using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001319 RID: 4889
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitTargetData")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UAbilityTask_WaitTargetData : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601202C RID: 73772 RVA: 0x001A71EA File Offset: 0x001A53EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitTargetData._ClassPtr;
		}

		// Token: 0x0601202D RID: 73773 RVA: 0x001A71F8 File Offset: 0x001A53F8
		public UAbilityTask_WaitTargetData() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitTargetData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601202E RID: 73774 RVA: 0x001A7220 File Offset: 0x001A5420
		[NullableContext(1)]
		public UAbilityTask_WaitTargetData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitTargetData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x0601202F RID: 73775 RVA: 0x001A7254 File Offset: 0x001A5454
		// (set) Token: 0x06012030 RID: 73776 RVA: 0x001A728D File Offset: 0x001A548D
		[Nullable(1)]
		public FWaitTargetDataDelegate ValidData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWaitTargetDataDelegate result;
				if ((result = this._ValidData) == null)
				{
					result = (this._ValidData = new FWaitTargetDataDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_ValidData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_ValidData, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x06012031 RID: 73777 RVA: 0x001A72B0 File Offset: 0x001A54B0
		// (set) Token: 0x06012032 RID: 73778 RVA: 0x001A72E9 File Offset: 0x001A54E9
		[Nullable(1)]
		public FWaitTargetDataDelegate Cancelled
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWaitTargetDataDelegate result;
				if ((result = this._Cancelled) == null)
				{
					result = (this._Cancelled = new FWaitTargetDataDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_Cancelled, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_Cancelled, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x06012033 RID: 73779 RVA: 0x001A730A File Offset: 0x001A550A
		// (set) Token: 0x06012034 RID: 73780 RVA: 0x001A731E File Offset: 0x001A551E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameplayAbilityTargetActor> TargetClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_TargetClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_WaitTargetData.__PropertyOffset_TargetClass) = value;
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x06012035 RID: 73781 RVA: 0x001A7333 File Offset: 0x001A5533
		// (set) Token: 0x06012036 RID: 73782 RVA: 0x001A7347 File Offset: 0x001A5547
		public unsafe AGameplayAbilityTargetActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameplayAbilityTargetActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitTargetData.__PropertyOffset_TargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitTargetData.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x06012037 RID: 73783 RVA: 0x001A735C File Offset: 0x001A555C
		public static UAbilityTask_WaitTargetData WaitTargetDataUsingActor(UGameplayAbility OwningAbility, FName TaskInstanceName, EGameplayTargetingConfirmation ConfirmationType, AGameplayAbilityTargetActor TargetActor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitTargetData>(UAbilityTask_WaitTargetData.__WaitTargetDataUsingActor_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, ConfirmationType, (TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06012038 RID: 73784 RVA: 0x001A738F File Offset: 0x001A558F
		public static UAbilityTask_WaitTargetData WaitTargetData(UGameplayAbility OwningAbility, FName TaskInstanceName, EGameplayTargetingConfirmation ConfirmationType, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AGameplayAbilityTargetActor> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitTargetData>(UAbilityTask_WaitTargetData.__WaitTargetData_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, ConfirmationType, Class._NativePtr));
		}

		// Token: 0x06012039 RID: 73785 RVA: 0x001A73B8 File Offset: 0x001A55B8
		public void OnTargetDataReplicatedCancelledCallback()
		{
			UAbilityTask_WaitTargetData.__OnTargetDataReplicatedCancelledCallback_Internal(base.NativePtr);
		}

		// Token: 0x0601203A RID: 73786 RVA: 0x001A73C5 File Offset: 0x001A55C5
		public void OnTargetDataReplicatedCallback(in FGameplayAbilityTargetDataHandle Data, FGameplayTag ActivationTag)
		{
			UAbilityTask_WaitTargetData.__OnTargetDataReplicatedCallback_Internal(base.NativePtr, (Data ?? new FGameplayAbilityTargetDataHandle()).NativePtr, ActivationTag);
		}

		// Token: 0x0601203B RID: 73787 RVA: 0x001A73E3 File Offset: 0x001A55E3
		public void OnTargetDataReadyCallback(in FGameplayAbilityTargetDataHandle Data)
		{
			UAbilityTask_WaitTargetData.__OnTargetDataReadyCallback_Internal(base.NativePtr, (Data ?? new FGameplayAbilityTargetDataHandle()).NativePtr);
		}

		// Token: 0x0601203C RID: 73788 RVA: 0x001A7400 File Offset: 0x001A5600
		public void OnTargetDataCancelledCallback(in FGameplayAbilityTargetDataHandle Data)
		{
			UAbilityTask_WaitTargetData.__OnTargetDataCancelledCallback_Internal(base.NativePtr, (Data ?? new FGameplayAbilityTargetDataHandle()).NativePtr);
		}

		// Token: 0x0601203D RID: 73789 RVA: 0x001A741D File Offset: 0x001A561D
		public void FinishSpawningActor(UGameplayAbility OwningAbility, AGameplayAbilityTargetActor SpawnedActor)
		{
			UAbilityTask_WaitTargetData.__FinishSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601203E RID: 73790 RVA: 0x001A744C File Offset: 0x001A564C
		public bool BeginSpawningActor(UGameplayAbility OwningAbility, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AGameplayAbilityTargetActor> Class, ref AGameplayAbilityTargetActor SpawnedActor)
		{
			AGameplayAbilityTargetActor agameplayAbilityTargetActor = SpawnedActor;
			IntPtr nativeObjectPtr = (agameplayAbilityTargetActor != null) ? agameplayAbilityTargetActor.NativePtr : IntPtr.Zero;
			bool result = UAbilityTask_WaitTargetData.__BeginSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Class._NativePtr, ref nativeObjectPtr);
			SpawnedActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AGameplayAbilityTargetActor>(nativeObjectPtr);
			return result;
		}

		// Token: 0x0601203F RID: 73791
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitTargetDataUsingActor_Internal(IntPtr OwningAbility, FName TaskInstanceName, TEnumAsByte<EGameplayTargetingConfirmation> ConfirmationType, IntPtr TargetActor);

		// Token: 0x06012040 RID: 73792
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitTargetData_Internal(IntPtr OwningAbility, FName TaskInstanceName, TEnumAsByte<EGameplayTargetingConfirmation> ConfirmationType, IntPtr Class);

		// Token: 0x06012041 RID: 73793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetDataReplicatedCancelledCallback_Internal(IntPtr @this);

		// Token: 0x06012042 RID: 73794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetDataReplicatedCallback_Internal(IntPtr @this, IntPtr Data, FGameplayTag ActivationTag);

		// Token: 0x06012043 RID: 73795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetDataReadyCallback_Internal(IntPtr @this, IntPtr Data);

		// Token: 0x06012044 RID: 73796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetDataCancelledCallback_Internal(IntPtr @this, IntPtr Data);

		// Token: 0x06012045 RID: 73797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr SpawnedActor);

		// Token: 0x06012046 RID: 73798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BeginSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr Class, ref IntPtr SpawnedActor);

		// Token: 0x06012047 RID: 73799 RVA: 0x001A7497 File Offset: 0x001A5697
		static UAbilityTask_WaitTargetData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitTargetData");
		}

		// Token: 0x06012048 RID: 73800 RVA: 0x001A74A5 File Offset: 0x001A56A5
		protected UAbilityTask_WaitTargetData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099FB RID: 39419
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitTargetData";

		// Token: 0x040099FC RID: 39420
		private static IntPtr _ClassPtr;

		// Token: 0x040099FD RID: 39421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099FE RID: 39422
		internal static int __PropertyOffset_ValidData;

		// Token: 0x040099FF RID: 39423
		private FWaitTargetDataDelegate _ValidData;

		// Token: 0x04009A00 RID: 39424
		internal static int __PropertyOffset_Cancelled;

		// Token: 0x04009A01 RID: 39425
		private FWaitTargetDataDelegate _Cancelled;

		// Token: 0x04009A02 RID: 39426
		internal static int __PropertyOffset_TargetClass;

		// Token: 0x04009A03 RID: 39427
		internal static int __PropertyOffset_TargetActor;
	}
}
