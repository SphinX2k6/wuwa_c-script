using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001307 RID: 4871
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitCancel")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAbilityTask_WaitCancel : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F62 RID: 73570 RVA: 0x001A5C28 File Offset: 0x001A3E28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitCancel._ClassPtr;
		}

		// Token: 0x06011F63 RID: 73571 RVA: 0x001A5C34 File Offset: 0x001A3E34
		public UAbilityTask_WaitCancel() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitCancel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F64 RID: 73572 RVA: 0x001A5C5C File Offset: 0x001A3E5C
		public UAbilityTask_WaitCancel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitCancel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06011F65 RID: 73573 RVA: 0x001A5C90 File Offset: 0x001A3E90
		// (set) Token: 0x06011F66 RID: 73574 RVA: 0x001A5CC9 File Offset: 0x001A3EC9
		public FWaitCancelDelegate OnCancel
		{
			get
			{
				base.FastCheckIsValid();
				FWaitCancelDelegate result;
				if ((result = this._OnCancel) == null)
				{
					result = (this._OnCancel = new FWaitCancelDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitCancel.__PropertyOffset_OnCancel, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitCancel.__PropertyOffset_OnCancel, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F67 RID: 73575 RVA: 0x001A5CEA File Offset: 0x001A3EEA
		[NullableContext(2)]
		public static UAbilityTask_WaitCancel WaitCancel(UGameplayAbility OwningAbility)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitCancel>(UAbilityTask_WaitCancel.__WaitCancel_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F68 RID: 73576 RVA: 0x001A5D06 File Offset: 0x001A3F06
		public void OnLocalCancelCallback()
		{
			UAbilityTask_WaitCancel.__OnLocalCancelCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F69 RID: 73577 RVA: 0x001A5D13 File Offset: 0x001A3F13
		public void OnCancelCallback()
		{
			UAbilityTask_WaitCancel.__OnCancelCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011F6A RID: 73578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitCancel_Internal(IntPtr OwningAbility);

		// Token: 0x06011F6B RID: 73579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLocalCancelCallback_Internal(IntPtr @this);

		// Token: 0x06011F6C RID: 73580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCancelCallback_Internal(IntPtr @this);

		// Token: 0x06011F6D RID: 73581 RVA: 0x001A5D20 File Offset: 0x001A3F20
		static UAbilityTask_WaitCancel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitCancel");
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x001A5D2E File Offset: 0x001A3F2E
		protected UAbilityTask_WaitCancel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400999B RID: 39323
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitCancel";

		// Token: 0x0400999C RID: 39324
		private static IntPtr _ClassPtr;

		// Token: 0x0400999D RID: 39325
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400999E RID: 39326
		internal static int __PropertyOffset_OnCancel;

		// Token: 0x0400999F RID: 39327
		[Nullable(2)]
		private FWaitCancelDelegate _OnCancel;
	}
}
