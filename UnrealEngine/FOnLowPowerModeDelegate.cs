using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F1A RID: 3866
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLowPowerModeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0E5 RID: 53477 RVA: 0x00131642 File Offset: 0x0012F842
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLowPowerModeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0E6 RID: 53478 RVA: 0x0013164E File Offset: 0x0012F84E
		private static IntPtr StaticFunctionPtr()
		{
			if (UApplicationLifecycleComponent.__OnLowPowerModeDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UApplicationLifecycleComponent.__OnLowPowerModeDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature");
			}
			return UApplicationLifecycleComponent.__OnLowPowerModeDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x00131671 File Offset: 0x0012F871
		public FOnLowPowerModeDelegate()
		{
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x00131679 File Offset: 0x0012F879
		[NullableContext(2)]
		public FOnLowPowerModeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x00131683 File Offset: 0x0012F883
		public FOnLowPowerModeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x0013168E File Offset: 0x0012F88E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x001316C0 File Offset: 0x0012F8C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnLowPowerModeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLowPowerModeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLowPowerModeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLowPowerModeDelegate.OnScriptCallback));
				}
				FOnLowPowerModeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLowPowerModeDelegate.RegisterId);
		}

		// Token: 0x0600D0EC RID: 53484 RVA: 0x001316FA File Offset: 0x0012F8FA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x00131704 File Offset: 0x0012F904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bInLowPowerMode)
		{
			FOnLowPowerModeDelegate.__FOnLowPowerModeDelegate_DelegateParams* ptr = stackalloc FOnLowPowerModeDelegate.__FOnLowPowerModeDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnLowPowerModeDelegate.__FOnLowPowerModeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnLowPowerModeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bInLowPowerMode = bInLowPowerMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x00131740 File Offset: 0x0012F940
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnLowPowerModeDelegate.__FOnLowPowerModeDelegate_DelegateParams*)__Parameters)->bInLowPowerMode);
		}

		// Token: 0x0400705D RID: 28765
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature";

		// Token: 0x0400705E RID: 28766
		private static int RegisterId;

		// Token: 0x02002D7D RID: 11645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnLowPowerModeDelegate_DelegateParams
		{
			// Token: 0x0401679E RID: 92062
			[FieldOffset(0)]
			public bool bInLowPowerMode;
		}

		// Token: 0x02002D7E RID: 11646
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401679F RID: 92063
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
