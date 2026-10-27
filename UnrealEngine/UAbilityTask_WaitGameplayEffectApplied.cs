using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130B RID: 4875
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UAbilityTask_WaitGameplayEffectApplied : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F96 RID: 73622 RVA: 0x001A60CA File Offset: 0x001A42CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectApplied._ClassPtr;
		}

		// Token: 0x06011F97 RID: 73623 RVA: 0x001A60D8 File Offset: 0x001A42D8
		public UAbilityTask_WaitGameplayEffectApplied() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x001A6100 File Offset: 0x001A4300
		[NullableContext(1)]
		public UAbilityTask_WaitGameplayEffectApplied(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectApplied.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x06011F99 RID: 73625 RVA: 0x001A6133 File Offset: 0x001A4333
		// (set) Token: 0x06011F9A RID: 73626 RVA: 0x001A6147 File Offset: 0x001A4347
		public unsafe UAbilitySystemComponent ExternalOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEffectApplied.__PropertyOffset_ExternalOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEffectApplied.__PropertyOffset_ExternalOwner, value);
			}
		}

		// Token: 0x06011F9B RID: 73627 RVA: 0x001A615C File Offset: 0x001A435C
		public void OnApplyGameplayEffectCallback(UAbilitySystemComponent Target, in FGameplayEffectSpec SpecApplied, FActiveGameplayEffectHandle ActiveHandle)
		{
			UAbilityTask_WaitGameplayEffectApplied.__OnApplyGameplayEffectCallback_Internal(base.NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero, (SpecApplied ?? new FGameplayEffectSpec()).NativePtr, (ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011F9C RID: 73628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnApplyGameplayEffectCallback_Internal(IntPtr @this, IntPtr Target, IntPtr SpecApplied, IntPtr ActiveHandle);

		// Token: 0x06011F9D RID: 73629 RVA: 0x001A6198 File Offset: 0x001A4398
		static UAbilityTask_WaitGameplayEffectApplied()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied");
		}

		// Token: 0x06011F9E RID: 73630 RVA: 0x001A61A6 File Offset: 0x001A43A6
		protected UAbilityTask_WaitGameplayEffectApplied(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099B1 RID: 39345
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectApplied";

		// Token: 0x040099B2 RID: 39346
		private static IntPtr _ClassPtr;

		// Token: 0x040099B3 RID: 39347
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099B4 RID: 39348
		internal static int __PropertyOffset_ExternalOwner;
	}
}
