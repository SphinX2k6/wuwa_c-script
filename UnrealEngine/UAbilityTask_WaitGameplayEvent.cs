using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001311 RID: 4881
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEvent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_WaitGameplayEvent : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FDA RID: 73690 RVA: 0x001A6974 File Offset: 0x001A4B74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEvent._ClassPtr;
		}

		// Token: 0x06011FDB RID: 73691 RVA: 0x001A6980 File Offset: 0x001A4B80
		public UAbilityTask_WaitGameplayEvent() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FDC RID: 73692 RVA: 0x001A69A8 File Offset: 0x001A4BA8
		public UAbilityTask_WaitGameplayEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x06011FDD RID: 73693 RVA: 0x001A69DC File Offset: 0x001A4BDC
		// (set) Token: 0x06011FDE RID: 73694 RVA: 0x001A6A15 File Offset: 0x001A4C15
		public FWaitGameplayEventDelegate EventReceived
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEventDelegate result;
				if ((result = this._EventReceived) == null)
				{
					result = (this._EventReceived = new FWaitGameplayEventDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEvent.__PropertyOffset_EventReceived, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEvent.__PropertyOffset_EventReceived, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x06011FDF RID: 73695 RVA: 0x001A6A36 File Offset: 0x001A4C36
		// (set) Token: 0x06011FE0 RID: 73696 RVA: 0x001A6A4A File Offset: 0x001A4C4A
		[Nullable(2)]
		public unsafe UAbilitySystemComponent OptionalExternalTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEvent.__PropertyOffset_OptionalExternalTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitGameplayEvent.__PropertyOffset_OptionalExternalTarget, value);
			}
		}

		// Token: 0x06011FE1 RID: 73697 RVA: 0x001A6A5F File Offset: 0x001A4C5F
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEvent WaitGameplayEvent(UGameplayAbility OwningAbility, FGameplayTag EventTag, AActor OptionalExternalTarget = null, bool OnlyTriggerOnce = false, bool OnlyMatchExact = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEvent>(UAbilityTask_WaitGameplayEvent.__WaitGameplayEvent_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, EventTag, (OptionalExternalTarget != null) ? OptionalExternalTarget.NativePtr : IntPtr.Zero, OnlyTriggerOnce, OnlyMatchExact));
		}

		// Token: 0x06011FE2 RID: 73698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayEvent_Internal(IntPtr OwningAbility, FGameplayTag EventTag, IntPtr OptionalExternalTarget, bool OnlyTriggerOnce, bool OnlyMatchExact);

		// Token: 0x06011FE3 RID: 73699 RVA: 0x001A6A8F File Offset: 0x001A4C8F
		static UAbilityTask_WaitGameplayEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEvent");
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x001A6A9D File Offset: 0x001A4C9D
		protected UAbilityTask_WaitGameplayEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099D3 RID: 39379
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEvent";

		// Token: 0x040099D4 RID: 39380
		private static IntPtr _ClassPtr;

		// Token: 0x040099D5 RID: 39381
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099D6 RID: 39382
		internal static int __PropertyOffset_EventReceived;

		// Token: 0x040099D7 RID: 39383
		[Nullable(2)]
		private FWaitGameplayEventDelegate _EventReceived;

		// Token: 0x040099D8 RID: 39384
		internal static int __PropertyOffset_OptionalExternalTarget;
	}
}
