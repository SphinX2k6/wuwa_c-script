using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001305 RID: 4869
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeRatioThreshold")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UAbilityTask_WaitAttributeChangeRatioThreshold : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F4C RID: 73548 RVA: 0x001A596F File Offset: 0x001A3B6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitAttributeChangeRatioThreshold._ClassPtr;
		}

		// Token: 0x06011F4D RID: 73549 RVA: 0x001A597C File Offset: 0x001A3B7C
		public UAbilityTask_WaitAttributeChangeRatioThreshold() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChangeRatioThreshold.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F4E RID: 73550 RVA: 0x001A59A4 File Offset: 0x001A3BA4
		public UAbilityTask_WaitAttributeChangeRatioThreshold(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChangeRatioThreshold.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x06011F4F RID: 73551 RVA: 0x001A59D8 File Offset: 0x001A3BD8
		// (set) Token: 0x06011F50 RID: 73552 RVA: 0x001A5A11 File Offset: 0x001A3C11
		public FWaitAttributeChangeRatioThresholdDelegate OnChange
		{
			get
			{
				base.FastCheckIsValid();
				FWaitAttributeChangeRatioThresholdDelegate result;
				if ((result = this._OnChange) == null)
				{
					result = (this._OnChange = new FWaitAttributeChangeRatioThresholdDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChangeRatioThreshold.__PropertyOffset_OnChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChangeRatioThreshold.__PropertyOffset_OnChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06011F51 RID: 73553 RVA: 0x001A5A32 File Offset: 0x001A3C32
		// (set) Token: 0x06011F52 RID: 73554 RVA: 0x001A5A46 File Offset: 0x001A3C46
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ExternalOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChangeRatioThreshold.__PropertyOffset_ExternalOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChangeRatioThreshold.__PropertyOffset_ExternalOwner, value);
			}
		}

		// Token: 0x06011F53 RID: 73555 RVA: 0x001A5A5C File Offset: 0x001A3C5C
		[NullableContext(2)]
		public static UAbilityTask_WaitAttributeChangeRatioThreshold WaitForAttributeChangeRatioThreshold(UGameplayAbility OwningAbility, FGameplayAttribute AttributeNumerator, FGameplayAttribute AttributeDenominator, EWaitAttributeChangeComparison ComparisonType, float ComparisonValue, bool bTriggerOnce, AActor OptionalExternalOwner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAttributeChangeRatioThreshold>(UAbilityTask_WaitAttributeChangeRatioThreshold.__WaitForAttributeChangeRatioThreshold_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (AttributeNumerator ?? new FGameplayAttribute()).NativePtr, (AttributeDenominator ?? new FGameplayAttribute()).NativePtr, ComparisonType, ComparisonValue, bTriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F54 RID: 73556
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAttributeChangeRatioThreshold_Internal(IntPtr OwningAbility, IntPtr AttributeNumerator, IntPtr AttributeDenominator, TEnumAsByte<EWaitAttributeChangeComparison> ComparisonType, float ComparisonValue, bool bTriggerOnce, IntPtr OptionalExternalOwner);

		// Token: 0x06011F55 RID: 73557 RVA: 0x001A5ABD File Offset: 0x001A3CBD
		static UAbilityTask_WaitAttributeChangeRatioThreshold()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeRatioThreshold");
		}

		// Token: 0x06011F56 RID: 73558 RVA: 0x001A5ACB File Offset: 0x001A3CCB
		protected UAbilityTask_WaitAttributeChangeRatioThreshold(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400998F RID: 39311
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeRatioThreshold";

		// Token: 0x04009990 RID: 39312
		private static IntPtr _ClassPtr;

		// Token: 0x04009991 RID: 39313
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009992 RID: 39314
		internal static int __PropertyOffset_OnChange;

		// Token: 0x04009993 RID: 39315
		[Nullable(2)]
		private FWaitAttributeChangeRatioThresholdDelegate _OnChange;

		// Token: 0x04009994 RID: 39316
		internal static int __PropertyOffset_ExternalOwner;
	}
}
