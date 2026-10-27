using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001306 RID: 4870
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeThreshold")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UAbilityTask_WaitAttributeChangeThreshold : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F57 RID: 73559 RVA: 0x001A5AD4 File Offset: 0x001A3CD4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitAttributeChangeThreshold._ClassPtr;
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x001A5AE0 File Offset: 0x001A3CE0
		public UAbilityTask_WaitAttributeChangeThreshold() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChangeThreshold.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x001A5B08 File Offset: 0x001A3D08
		public UAbilityTask_WaitAttributeChangeThreshold(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAttributeChangeThreshold.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x06011F5A RID: 73562 RVA: 0x001A5B3C File Offset: 0x001A3D3C
		// (set) Token: 0x06011F5B RID: 73563 RVA: 0x001A5B75 File Offset: 0x001A3D75
		public FWaitAttributeChangeThresholdDelegate OnChange
		{
			get
			{
				base.FastCheckIsValid();
				FWaitAttributeChangeThresholdDelegate result;
				if ((result = this._OnChange) == null)
				{
					result = (this._OnChange = new FWaitAttributeChangeThresholdDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChangeThreshold.__PropertyOffset_OnChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitAttributeChangeThreshold.__PropertyOffset_OnChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06011F5C RID: 73564 RVA: 0x001A5B96 File Offset: 0x001A3D96
		// (set) Token: 0x06011F5D RID: 73565 RVA: 0x001A5BAA File Offset: 0x001A3DAA
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ExternalOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChangeThreshold.__PropertyOffset_ExternalOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitAttributeChangeThreshold.__PropertyOffset_ExternalOwner, value);
			}
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x001A5BC0 File Offset: 0x001A3DC0
		[NullableContext(2)]
		public static UAbilityTask_WaitAttributeChangeThreshold WaitForAttributeChangeThreshold(UGameplayAbility OwningAbility, FGameplayAttribute Attribute, EWaitAttributeChangeComparison ComparisonType, float ComparisonValue, bool bTriggerOnce, AActor OptionalExternalOwner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAttributeChangeThreshold>(UAbilityTask_WaitAttributeChangeThreshold.__WaitForAttributeChangeThreshold_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, ComparisonType, ComparisonValue, bTriggerOnce, (OptionalExternalOwner != null) ? OptionalExternalOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F5F RID: 73567
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAttributeChangeThreshold_Internal(IntPtr OwningAbility, IntPtr Attribute, TEnumAsByte<EWaitAttributeChangeComparison> ComparisonType, float ComparisonValue, bool bTriggerOnce, IntPtr OptionalExternalOwner);

		// Token: 0x06011F60 RID: 73568 RVA: 0x001A5C11 File Offset: 0x001A3E11
		static UAbilityTask_WaitAttributeChangeThreshold()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeThreshold");
		}

		// Token: 0x06011F61 RID: 73569 RVA: 0x001A5C1F File Offset: 0x001A3E1F
		protected UAbilityTask_WaitAttributeChangeThreshold(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009995 RID: 39317
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitAttributeChangeThreshold";

		// Token: 0x04009996 RID: 39318
		private static IntPtr _ClassPtr;

		// Token: 0x04009997 RID: 39319
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009998 RID: 39320
		internal static int __PropertyOffset_OnChange;

		// Token: 0x04009999 RID: 39321
		[Nullable(2)]
		private FWaitAttributeChangeThresholdDelegate _OnChange;

		// Token: 0x0400999A RID: 39322
		internal static int __PropertyOffset_ExternalOwner;
	}
}
