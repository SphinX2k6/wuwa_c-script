using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130D RID: 4877
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Target")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UAbilityTask_WaitGameplayEffectApplied_Target : UAbilityTask_WaitGameplayEffectApplied, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FAA RID: 73642 RVA: 0x001A6361 File Offset: 0x001A4561
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectApplied_Target._ClassPtr;
		}

		// Token: 0x06011FAB RID: 73643 RVA: 0x001A6370 File Offset: 0x001A4570
		public UAbilityTask_WaitGameplayEffectApplied_Target() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied_Target.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FAC RID: 73644 RVA: 0x001A6398 File Offset: 0x001A4598
		public UAbilityTask_WaitGameplayEffectApplied_Target(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied_Target.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x06011FAD RID: 73645 RVA: 0x001A63CC File Offset: 0x001A45CC
		// (set) Token: 0x06011FAE RID: 73646 RVA: 0x001A6405 File Offset: 0x001A4605
		public FGameplayEffectAppliedTargetDelegate OnApplied
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAppliedTargetDelegate result;
				if ((result = this._OnApplied) == null)
				{
					result = (this._OnApplied = new FGameplayEffectAppliedTargetDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectApplied_Target.__PropertyOffset_OnApplied, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectApplied_Target.__PropertyOffset_OnApplied, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FAF RID: 73647 RVA: 0x001A6428 File Offset: 0x001A4628
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget_Query(UGameplayAbility OwningAbility, FGameplayTargetDataFilterHandle SourceFilter, FGameplayTagQuery SourceTagQuery, FGameplayTagQuery TargetTagQuery, bool TriggerOnce = false, AActor OptionalExternalOwner = null, bool ListenForPeriodicEffect = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectApplied_Target>(UAbilityTask_WaitGameplayEffectApplied_Target.__WaitGameplayEffectAppliedToTarget_Query_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SourceFilter ?? new FGameplayTargetDataFilterHandle()).NativePtr, (SourceTagQuery ?? new FGameplayTagQuery()).NativePtr, (TargetTagQuery ?? new FGameplayTagQuery()).NativePtr, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero, ListenForPeriodicEffect));
		}

		// Token: 0x06011FB0 RID: 73648 RVA: 0x001A6494 File Offset: 0x001A4694
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectApplied_Target WaitGameplayEffectAppliedToTarget(UGameplayAbility OwningAbility, FGameplayTargetDataFilterHandle TargetFilter, FGameplayTagRequirements SourceTagRequirements, FGameplayTagRequirements TargetTagRequirements, bool TriggerOnce = false, AActor OptionalExternalOwner = null, bool ListenForPeriodicEffects = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectApplied_Target>(UAbilityTask_WaitGameplayEffectApplied_Target.__WaitGameplayEffectAppliedToTarget_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TargetFilter ?? new FGameplayTargetDataFilterHandle()).NativePtr, (SourceTagRequirements ?? new FGameplayTagRequirements()).NativePtr, (TargetTagRequirements ?? new FGameplayTagRequirements()).NativePtr, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero, ListenForPeriodicEffects));
		}

		// Token: 0x06011FB1 RID: 73649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEffectAppliedToTarget_Query_Internal(IntPtr OwningAbility, IntPtr SourceFilter, IntPtr SourceTagQuery, IntPtr TargetTagQuery, bool TriggerOnce, IntPtr OptionalExternalOwner, bool ListenForPeriodicEffect);

		// Token: 0x06011FB2 RID: 73650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEffectAppliedToTarget_Internal(IntPtr OwningAbility, IntPtr TargetFilter, IntPtr SourceTagRequirements, IntPtr TargetTagRequirements, bool TriggerOnce, IntPtr OptionalExternalOwner, bool ListenForPeriodicEffects);

		// Token: 0x06011FB3 RID: 73651 RVA: 0x001A64FE File Offset: 0x001A46FE
		static UAbilityTask_WaitGameplayEffectApplied_Target()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Target");
		}

		// Token: 0x06011FB4 RID: 73652 RVA: 0x001A650C File Offset: 0x001A470C
		protected UAbilityTask_WaitGameplayEffectApplied_Target(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099BA RID: 39354
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Target";

		// Token: 0x040099BB RID: 39355
		private static IntPtr _ClassPtr;

		// Token: 0x040099BC RID: 39356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099BD RID: 39357
		internal static int __PropertyOffset_OnApplied;

		// Token: 0x040099BE RID: 39358
		[Nullable(2)]
		private FGameplayEffectAppliedTargetDelegate _OnApplied;
	}
}
