using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001309 RID: 4873
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitConfirmCancel")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UAbilityTask_WaitConfirmCancel : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F7A RID: 73594 RVA: 0x001A5E4A File Offset: 0x001A404A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitConfirmCancel._ClassPtr;
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x001A5E58 File Offset: 0x001A4058
		public UAbilityTask_WaitConfirmCancel() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitConfirmCancel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x001A5E80 File Offset: 0x001A4080
		public UAbilityTask_WaitConfirmCancel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitConfirmCancel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x06011F7D RID: 73597 RVA: 0x001A5EB4 File Offset: 0x001A40B4
		// (set) Token: 0x06011F7E RID: 73598 RVA: 0x001A5EED File Offset: 0x001A40ED
		public FWaitConfirmCancelDelegate OnConfirm
		{
			get
			{
				base.FastCheckIsValid();
				FWaitConfirmCancelDelegate result;
				if ((result = this._OnConfirm) == null)
				{
					result = (this._OnConfirm = new FWaitConfirmCancelDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirmCancel.__PropertyOffset_OnConfirm, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirmCancel.__PropertyOffset_OnConfirm, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x06011F7F RID: 73599 RVA: 0x001A5F10 File Offset: 0x001A4110
		// (set) Token: 0x06011F80 RID: 73600 RVA: 0x001A5F49 File Offset: 0x001A4149
		public FWaitConfirmCancelDelegate OnCancel
		{
			get
			{
				base.FastCheckIsValid();
				FWaitConfirmCancelDelegate result;
				if ((result = this._OnCancel) == null)
				{
					result = (this._OnCancel = new FWaitConfirmCancelDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirmCancel.__PropertyOffset_OnCancel, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirmCancel.__PropertyOffset_OnCancel, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x001A5F6A File Offset: 0x001A416A
		[NullableContext(2)]
		public static UAbilityTask_WaitConfirmCancel WaitConfirmCancel(UGameplayAbility OwningAbility)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitConfirmCancel>(UAbilityTask_WaitConfirmCancel.__WaitConfirmCancel_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F82 RID: 73602 RVA: 0x001A5F86 File Offset: 0x001A4186
		public void OnLocalConfirmCallback()
		{
			UAbilityTask_WaitConfirmCancel.__OnLocalConfirmCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F83 RID: 73603 RVA: 0x001A5F93 File Offset: 0x001A4193
		public void OnLocalCancelCallback()
		{
			UAbilityTask_WaitConfirmCancel.__OnLocalCancelCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F84 RID: 73604 RVA: 0x001A5FA0 File Offset: 0x001A41A0
		public void OnConfirmCallback()
		{
			UAbilityTask_WaitConfirmCancel.__OnConfirmCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F85 RID: 73605 RVA: 0x001A5FAD File Offset: 0x001A41AD
		public void OnCancelCallback()
		{
			UAbilityTask_WaitConfirmCancel.__OnCancelCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F86 RID: 73606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitConfirmCancel_Internal(IntPtr OwningAbility);

		// Token: 0x06011F87 RID: 73607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLocalConfirmCallback_Internal(IntPtr @this);

		// Token: 0x06011F88 RID: 73608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLocalCancelCallback_Internal(IntPtr @this);

		// Token: 0x06011F89 RID: 73609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnConfirmCallback_Internal(IntPtr @this);

		// Token: 0x06011F8A RID: 73610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCancelCallback_Internal(IntPtr @this);

		// Token: 0x06011F8B RID: 73611 RVA: 0x001A5FBA File Offset: 0x001A41BA
		static UAbilityTask_WaitConfirmCancel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitConfirmCancel");
		}

		// Token: 0x06011F8C RID: 73612 RVA: 0x001A5FC8 File Offset: 0x001A41C8
		protected UAbilityTask_WaitConfirmCancel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099A5 RID: 39333
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitConfirmCancel";

		// Token: 0x040099A6 RID: 39334
		private static IntPtr _ClassPtr;

		// Token: 0x040099A7 RID: 39335
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099A8 RID: 39336
		internal static int __PropertyOffset_OnConfirm;

		// Token: 0x040099A9 RID: 39337
		[Nullable(2)]
		private FWaitConfirmCancelDelegate _OnConfirm;

		// Token: 0x040099AA RID: 39338
		internal static int __PropertyOffset_OnCancel;

		// Token: 0x040099AB RID: 39339
		[Nullable(2)]
		private FWaitConfirmCancelDelegate _OnCancel;
	}
}
