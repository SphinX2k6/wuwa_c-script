using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130E RID: 4878
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectBlockedImmunity")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UAbilityTask_WaitGameplayEffectBlockedImmunity : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FB5 RID: 73653 RVA: 0x001A6515 File Offset: 0x001A4715
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectBlockedImmunity._ClassPtr;
		}

		// Token: 0x06011FB6 RID: 73654 RVA: 0x001A6524 File Offset: 0x001A4724
		public UAbilityTask_WaitGameplayEffectBlockedImmunity() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectBlockedImmunity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FB7 RID: 73655 RVA: 0x001A654C File Offset: 0x001A474C
		public UAbilityTask_WaitGameplayEffectBlockedImmunity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectBlockedImmunity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x06011FB8 RID: 73656 RVA: 0x001A6580 File Offset: 0x001A4780
		// (set) Token: 0x06011FB9 RID: 73657 RVA: 0x001A65B9 File Offset: 0x001A47B9
		public FGameplayEffectBlockedDelegate Blocked
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectBlockedDelegate result;
				if ((result = this._Blocked) == null)
				{
					result = (this._Blocked = new FGameplayEffectBlockedDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectBlockedImmunity.__PropertyOffset_Blocked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectBlockedImmunity.__PropertyOffset_Blocked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x06011FBA RID: 73658 RVA: 0x001A65DA File Offset: 0x001A47DA
		// (set) Token: 0x06011FBB RID: 73659 RVA: 0x001A65EE File Offset: 0x001A47EE
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ExternalOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEffectBlockedImmunity.__PropertyOffset_ExternalOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEffectBlockedImmunity.__PropertyOffset_ExternalOwner, value);
			}
		}

		// Token: 0x06011FBC RID: 73660 RVA: 0x001A6604 File Offset: 0x001A4804
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectBlockedImmunity WaitGameplayEffectBlockedByImmunity(UGameplayAbility OwningAbility, FGameplayTagRequirements SourceTagRequirements, FGameplayTagRequirements TargetTagRequirements, AActor OptionalExternalTarget = null, bool OnlyTriggerOnce = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectBlockedImmunity>(UAbilityTask_WaitGameplayEffectBlockedImmunity.__WaitGameplayEffectBlockedByImmunity_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SourceTagRequirements ?? new FGameplayTagRequirements()).NativePtr, (TargetTagRequirements ?? new FGameplayTagRequirements()).NativePtr, (OptionalExternalTarget != null) ? OptionalExternalTarget.NativePtr : IntPtr.Zero, OnlyTriggerOnce));
		}

		// Token: 0x06011FBD RID: 73661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEffectBlockedByImmunity_Internal(IntPtr OwningAbility, IntPtr SourceTagRequirements, IntPtr TargetTagRequirements, IntPtr OptionalExternalTarget, bool OnlyTriggerOnce);

		// Token: 0x06011FBE RID: 73662 RVA: 0x001A665B File Offset: 0x001A485B
		static UAbilityTask_WaitGameplayEffectBlockedImmunity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectBlockedImmunity");
		}

		// Token: 0x06011FBF RID: 73663 RVA: 0x001A6669 File Offset: 0x001A4869
		protected UAbilityTask_WaitGameplayEffectBlockedImmunity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099BF RID: 39359
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectBlockedImmunity";

		// Token: 0x040099C0 RID: 39360
		private static IntPtr _ClassPtr;

		// Token: 0x040099C1 RID: 39361
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099C2 RID: 39362
		internal static int __PropertyOffset_Blocked;

		// Token: 0x040099C3 RID: 39363
		[Nullable(2)]
		private FGameplayEffectBlockedDelegate _Blocked;

		// Token: 0x040099C4 RID: 39364
		internal static int __PropertyOffset_ExternalOwner;
	}
}
