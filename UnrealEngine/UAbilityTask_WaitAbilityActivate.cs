using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001302 RID: 4866
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitAbilityActivate")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UAbilityTask_WaitAbilityActivate : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F23 RID: 73507 RVA: 0x001A550E File Offset: 0x001A370E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitAbilityActivate._ClassPtr;
		}

		// Token: 0x06011F24 RID: 73508 RVA: 0x001A551C File Offset: 0x001A371C
		public UAbilityTask_WaitAbilityActivate() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAbilityActivate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F25 RID: 73509 RVA: 0x001A5544 File Offset: 0x001A3744
		public UAbilityTask_WaitAbilityActivate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAbilityActivate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x06011F26 RID: 73510 RVA: 0x001A5578 File Offset: 0x001A3778
		// (set) Token: 0x06011F27 RID: 73511 RVA: 0x001A55B1 File Offset: 0x001A37B1
		public FWaitAbilityActivateDelegate OnActivate
		{
			get
			{
				base.FastCheckIsValid();
				FWaitAbilityActivateDelegate result;
				if ((result = this._OnActivate) == null)
				{
					result = (this._OnActivate = new FWaitAbilityActivateDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitAbilityActivate.__PropertyOffset_OnActivate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitAbilityActivate.__PropertyOffset_OnActivate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F28 RID: 73512 RVA: 0x001A55D2 File Offset: 0x001A37D2
		[NullableContext(2)]
		public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivateWithTagRequirements(UGameplayAbility OwningAbility, FGameplayTagRequirements TagRequirements, bool IncludeTriggeredAbilities = false, bool TriggerOnce = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAbilityActivate>(UAbilityTask_WaitAbilityActivate.__WaitForAbilityActivateWithTagRequirements_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TagRequirements ?? new FGameplayTagRequirements()).NativePtr, IncludeTriggeredAbilities, TriggerOnce));
		}

		// Token: 0x06011F29 RID: 73513 RVA: 0x001A55FF File Offset: 0x001A37FF
		[NullableContext(2)]
		public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate_Query(UGameplayAbility OwningAbility, FGameplayTagQuery Query, bool IncludeTriggeredAbilities = false, bool TriggerOnce = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAbilityActivate>(UAbilityTask_WaitAbilityActivate.__WaitForAbilityActivate_Query_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Query ?? new FGameplayTagQuery()).NativePtr, IncludeTriggeredAbilities, TriggerOnce));
		}

		// Token: 0x06011F2A RID: 73514 RVA: 0x001A562C File Offset: 0x001A382C
		[NullableContext(2)]
		public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate(UGameplayAbility OwningAbility, FGameplayTag WithTag, FGameplayTag WithoutTag, bool IncludeTriggeredAbilities = false, bool TriggerOnce = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAbilityActivate>(UAbilityTask_WaitAbilityActivate.__WaitForAbilityActivate_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, WithTag, WithoutTag, IncludeTriggeredAbilities, TriggerOnce));
		}

		// Token: 0x06011F2B RID: 73515 RVA: 0x001A564D File Offset: 0x001A384D
		[NullableContext(2)]
		public void OnAbilityActivate(UGameplayAbility ActivatedAbility)
		{
			UAbilityTask_WaitAbilityActivate.__OnAbilityActivate_Internal(base.NativePtr, (ActivatedAbility != null) ? ActivatedAbility.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011F2C RID: 73516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAbilityActivateWithTagRequirements_Internal(IntPtr OwningAbility, IntPtr TagRequirements, bool IncludeTriggeredAbilities, bool TriggerOnce);

		// Token: 0x06011F2D RID: 73517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAbilityActivate_Query_Internal(IntPtr OwningAbility, IntPtr Query, bool IncludeTriggeredAbilities, bool TriggerOnce);

		// Token: 0x06011F2E RID: 73518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAbilityActivate_Internal(IntPtr OwningAbility, FGameplayTag WithTag, FGameplayTag WithoutTag, bool IncludeTriggeredAbilities, bool TriggerOnce);

		// Token: 0x06011F2F RID: 73519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAbilityActivate_Internal(IntPtr @this, IntPtr ActivatedAbility);

		// Token: 0x06011F30 RID: 73520 RVA: 0x001A566A File Offset: 0x001A386A
		static UAbilityTask_WaitAbilityActivate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitAbilityActivate");
		}

		// Token: 0x06011F31 RID: 73521 RVA: 0x001A5678 File Offset: 0x001A3878
		protected UAbilityTask_WaitAbilityActivate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400997F RID: 39295
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitAbilityActivate";

		// Token: 0x04009980 RID: 39296
		private static IntPtr _ClassPtr;

		// Token: 0x04009981 RID: 39297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009982 RID: 39298
		internal static int __PropertyOffset_OnActivate;

		// Token: 0x04009983 RID: 39299
		[Nullable(2)]
		private FWaitAbilityActivateDelegate _OnActivate;
	}
}
