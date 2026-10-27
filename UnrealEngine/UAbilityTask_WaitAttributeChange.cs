using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001304 RID: 4868
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitAttributeChange")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAbilityTask_WaitAttributeChange : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F3F RID: 73535 RVA: 0x001A57C5 File Offset: 0x001A39C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitAttributeChange._ClassPtr;
		}

		// Token: 0x06011F40 RID: 73536 RVA: 0x001A57D4 File Offset: 0x001A39D4
		public UAbilityTask_WaitAttributeChange() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F41 RID: 73537 RVA: 0x001A57FC File Offset: 0x001A39FC
		[NullableContext(1)]
		public UAbilityTask_WaitAttributeChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06011F42 RID: 73538 RVA: 0x001A5830 File Offset: 0x001A3A30
		// (set) Token: 0x06011F43 RID: 73539 RVA: 0x001A5869 File Offset: 0x001A3A69
		[Nullable(1)]
		public FWaitAttributeChangeDelegate OnChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWaitAttributeChangeDelegate result;
				if ((result = this._OnChange) == null)
				{
					result = (this._OnChange = new FWaitAttributeChangeDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChange.__PropertyOffset_OnChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChange.__PropertyOffset_OnChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06011F44 RID: 73540 RVA: 0x001A588A File Offset: 0x001A3A8A
		// (set) Token: 0x06011F45 RID: 73541 RVA: 0x001A589E File Offset: 0x001A3A9E
		public unsafe UAbilitySystemComponent ExternalOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChange.__PropertyOffset_ExternalOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChange.__PropertyOffset_ExternalOwner, value);
			}
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x001A58B4 File Offset: 0x001A3AB4
		public static UAbilityTask_WaitAttributeChange WaitForAttributeChangeWithComparison(UGameplayAbility OwningAbility, FGameplayAttribute InAttribute, FGameplayTag InWithTag, FGameplayTag InWithoutTag, EWaitAttributeChangeComparison InComparisonType, float InComparisonValue, bool TriggerOnce = true, AActor OptionalExternalOwner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAttributeChange>(UAbilityTask_WaitAttributeChange.__WaitForAttributeChangeWithComparison_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (InAttribute ?? new FGameplayAttribute()).NativePtr, InWithTag, InWithoutTag, InComparisonType, InComparisonValue, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x001A590C File Offset: 0x001A3B0C
		public static UAbilityTask_WaitAttributeChange WaitForAttributeChange(UGameplayAbility OwningAbility, FGameplayAttribute Attribute, FGameplayTag WithSrcTag, FGameplayTag WithoutSrcTag, bool TriggerOnce = true, AActor OptionalExternalOwner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAttributeChange>(UAbilityTask_WaitAttributeChange.__WaitForAttributeChange_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, WithSrcTag, WithoutSrcTag, TriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F48 RID: 73544
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAttributeChangeWithComparison_Internal(IntPtr OwningAbility, IntPtr InAttribute, FGameplayTag InWithTag, FGameplayTag InWithoutTag, TEnumAsByte<EWaitAttributeChangeComparison> InComparisonType, float InComparisonValue, bool TriggerOnce, IntPtr OptionalExternalOwner);

		// Token: 0x06011F49 RID: 73545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAttributeChange_Internal(IntPtr OwningAbility, IntPtr Attribute, FGameplayTag WithSrcTag, FGameplayTag WithoutSrcTag, bool TriggerOnce, IntPtr OptionalExternalOwner);

		// Token: 0x06011F4A RID: 73546 RVA: 0x001A5958 File Offset: 0x001A3B58
		static UAbilityTask_WaitAttributeChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitAttributeChange");
		}

		// Token: 0x06011F4B RID: 73547 RVA: 0x001A5966 File Offset: 0x001A3B66
		protected UAbilityTask_WaitAttributeChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009989 RID: 39305
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitAttributeChange";

		// Token: 0x0400998A RID: 39306
		private static IntPtr _ClassPtr;

		// Token: 0x0400998B RID: 39307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400998C RID: 39308
		internal static int __PropertyOffset_OnChange;

		// Token: 0x0400998D RID: 39309
		private FWaitAttributeChangeDelegate _OnChange;

		// Token: 0x0400998E RID: 39310
		internal static int __PropertyOffset_ExternalOwner;
	}
}
