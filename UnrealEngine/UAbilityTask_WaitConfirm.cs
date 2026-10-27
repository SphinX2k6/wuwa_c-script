using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001308 RID: 4872
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitConfirm")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAbilityTask_WaitConfirm : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F6F RID: 73583 RVA: 0x001A5D37 File Offset: 0x001A3F37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitConfirm._ClassPtr;
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x001A5D44 File Offset: 0x001A3F44
		public UAbilityTask_WaitConfirm() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitConfirm.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x001A5D6C File Offset: 0x001A3F6C
		public UAbilityTask_WaitConfirm(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitConfirm.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x06011F72 RID: 73586 RVA: 0x001A5DA0 File Offset: 0x001A3FA0
		// (set) Token: 0x06011F73 RID: 73587 RVA: 0x001A5DD9 File Offset: 0x001A3FD9
		public FGenericGameplayTaskDelegate OnConfirm
		{
			get
			{
				base.FastCheckIsValid();
				FGenericGameplayTaskDelegate result;
				if ((result = this._OnConfirm) == null)
				{
					result = (this._OnConfirm = new FGenericGameplayTaskDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirm.__PropertyOffset_OnConfirm, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitConfirm.__PropertyOffset_OnConfirm, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x001A5DFA File Offset: 0x001A3FFA
		[NullableContext(2)]
		public static UAbilityTask_WaitConfirm WaitConfirm(UGameplayAbility OwningAbility)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitConfirm>(UAbilityTask_WaitConfirm.__WaitConfirm_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x001A5E16 File Offset: 0x001A4016
		[NullableContext(2)]
		public void OnConfirmCallback(UGameplayAbility InAbility)
		{
			UAbilityTask_WaitConfirm.__OnConfirmCallback_Internal(base.NativePtr, (InAbility != null) ? InAbility.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011F76 RID: 73590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitConfirm_Internal(IntPtr OwningAbility);

		// Token: 0x06011F77 RID: 73591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnConfirmCallback_Internal(IntPtr @this, IntPtr InAbility);

		// Token: 0x06011F78 RID: 73592 RVA: 0x001A5E33 File Offset: 0x001A4033
		static UAbilityTask_WaitConfirm()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitConfirm");
		}

		// Token: 0x06011F79 RID: 73593 RVA: 0x001A5E41 File Offset: 0x001A4041
		protected UAbilityTask_WaitConfirm(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099A0 RID: 39328
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitConfirm";

		// Token: 0x040099A1 RID: 39329
		private static IntPtr _ClassPtr;

		// Token: 0x040099A2 RID: 39330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099A3 RID: 39331
		internal static int __PropertyOffset_OnConfirm;

		// Token: 0x040099A4 RID: 39332
		[Nullable(2)]
		private FGenericGameplayTaskDelegate _OnConfirm;
	}
}
