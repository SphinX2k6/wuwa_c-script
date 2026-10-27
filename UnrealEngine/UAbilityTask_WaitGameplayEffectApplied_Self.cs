using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130C RID: 4876
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Self")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UAbilityTask_WaitGameplayEffectApplied_Self : UAbilityTask_WaitGameplayEffectApplied, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F9F RID: 73631 RVA: 0x001A61AF File Offset: 0x001A43AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectApplied_Self._ClassPtr;
		}

		// Token: 0x06011FA0 RID: 73632 RVA: 0x001A61BC File Offset: 0x001A43BC
		public UAbilityTask_WaitGameplayEffectApplied_Self() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied_Self.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FA1 RID: 73633 RVA: 0x001A61E4 File Offset: 0x001A43E4
		public UAbilityTask_WaitGameplayEffectApplied_Self(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied_Self.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x001A6218 File Offset: 0x001A4418
		// (set) Token: 0x06011FA3 RID: 73635 RVA: 0x001A6251 File Offset: 0x001A4451
		public FGameplayEffectAppliedSelfDelegate OnApplied
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAppliedSelfDelegate result;
				if ((result = this._OnApplied) == null)
				{
					result = (this._OnApplied = new FGameplayEffectAppliedSelfDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectApplied_Self.__PropertyOffset_OnApplied, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectApplied_Self.__PropertyOffset_OnApplied, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FA4 RID: 73636 RVA: 0x001A6274 File Offset: 0x001A4474
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectApplied_Self WaitGameplayEffectAppliedToSelf_Query(UGameplayAbility OwningAbility, FGameplayTargetDataFilterHandle SourceFilter, FGameplayTagQuery SourceTagQuery, FGameplayTagQuery TargetTagQuery, bool TriggerOnce = false, AActor OptionalExternalOwner = null, bool ListenForPeriodicEffect = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectApplied_Self>(UAbilityTask_WaitGameplayEffectApplied_Self.__WaitGameplayEffectAppliedToSelf_Query_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SourceFilter ?? new FGameplayTargetDataFilterHandle()).NativePtr, (SourceTagQuery ?? new FGameplayTagQuery()).NativePtr, (TargetTagQuery ?? new FGameplayTagQuery()).NativePtr, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero, ListenForPeriodicEffect));
		}

		// Token: 0x06011FA5 RID: 73637 RVA: 0x001A62E0 File Offset: 0x001A44E0
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectApplied_Self WaitGameplayEffectAppliedToSelf(UGameplayAbility OwningAbility, FGameplayTargetDataFilterHandle SourceFilter, FGameplayTagRequirements SourceTagRequirements, FGameplayTagRequirements TargetTagRequirements, bool TriggerOnce = false, AActor OptionalExternalOwner = null, bool ListenForPeriodicEffect = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectApplied_Self>(UAbilityTask_WaitGameplayEffectApplied_Self.__WaitGameplayEffectAppliedToSelf_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SourceFilter ?? new FGameplayTargetDataFilterHandle()).NativePtr, (SourceTagRequirements ?? new FGameplayTagRequirements()).NativePtr, (TargetTagRequirements ?? new FGameplayTagRequirements()).NativePtr, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero, ListenForPeriodicEffect));
		}

		// Token: 0x06011FA6 RID: 73638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEffectAppliedToSelf_Query_Internal(IntPtr OwningAbility, IntPtr SourceFilter, IntPtr SourceTagQuery, IntPtr TargetTagQuery, bool TriggerOnce, IntPtr OptionalExternalOwner, bool ListenForPeriodicEffect);

		// Token: 0x06011FA7 RID: 73639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEffectAppliedToSelf_Internal(IntPtr OwningAbility, IntPtr SourceFilter, IntPtr SourceTagRequirements, IntPtr TargetTagRequirements, bool TriggerOnce, IntPtr OptionalExternalOwner, bool ListenForPeriodicEffect);

		// Token: 0x06011FA8 RID: 73640 RVA: 0x001A634A File Offset: 0x001A454A
		static UAbilityTask_WaitGameplayEffectApplied_Self()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Self");
		}

		// Token: 0x06011FA9 RID: 73641 RVA: 0x001A6358 File Offset: 0x001A4558
		protected UAbilityTask_WaitGameplayEffectApplied_Self(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099B5 RID: 39349
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied_Self";

		// Token: 0x040099B6 RID: 39350
		private static IntPtr _ClassPtr;

		// Token: 0x040099B7 RID: 39351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099B8 RID: 39352
		internal static int __PropertyOffset_OnApplied;

		// Token: 0x040099B9 RID: 39353
		[Nullable(2)]
		private FGameplayEffectAppliedSelfDelegate _OnApplied;
	}
}
