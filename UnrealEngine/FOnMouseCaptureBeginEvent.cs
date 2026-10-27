using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029AF RID: 10671
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMouseCaptureBeginEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027760 RID: 161632 RVA: 0x003C3436 File Offset: 0x003C1636
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMouseCaptureBeginEvent.StaticFunctionPtr();
		}

		// Token: 0x06027761 RID: 161633 RVA: 0x003C3442 File Offset: 0x003C1642
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMouseCaptureBeginEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMouseCaptureBeginEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature");
			}
			return FOnMouseCaptureBeginEvent._FunctionPtr;
		}

		// Token: 0x06027762 RID: 161634 RVA: 0x003C3465 File Offset: 0x003C1665
		public FOnMouseCaptureBeginEvent()
		{
		}

		// Token: 0x06027763 RID: 161635 RVA: 0x003C346D File Offset: 0x003C166D
		[NullableContext(2)]
		public FOnMouseCaptureBeginEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027764 RID: 161636 RVA: 0x003C3477 File Offset: 0x003C1677
		public FOnMouseCaptureBeginEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027765 RID: 161637 RVA: 0x003C3482 File Offset: 0x003C1682
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027766 RID: 161638 RVA: 0x003C34B4 File Offset: 0x003C16B4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMouseCaptureBeginEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMouseCaptureBeginEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMouseCaptureBeginEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMouseCaptureBeginEvent.OnScriptCallback));
				}
				FOnMouseCaptureBeginEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMouseCaptureBeginEvent.RegisterId);
		}

		// Token: 0x06027767 RID: 161639 RVA: 0x003C34EE File Offset: 0x003C16EE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027768 RID: 161640 RVA: 0x003C34F7 File Offset: 0x003C16F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027769 RID: 161641 RVA: 0x003C3504 File Offset: 0x003C1704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04015A6B RID: 88683
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A6C RID: 88684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature";

		// Token: 0x04015A6D RID: 88685
		private static int RegisterId;

		// Token: 0x02003BB5 RID: 15285
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D98 RID: 97688
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
