using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002998 RID: 10648
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnControllerCaptureBeginEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602767D RID: 161405 RVA: 0x003C14DA File Offset: 0x003BF6DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnControllerCaptureBeginEvent.StaticFunctionPtr();
		}

		// Token: 0x0602767E RID: 161406 RVA: 0x003C14E6 File Offset: 0x003BF6E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnControllerCaptureBeginEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnControllerCaptureBeginEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnControllerCaptureBeginEvent__DelegateSignature");
			}
			return FOnControllerCaptureBeginEvent._FunctionPtr;
		}

		// Token: 0x0602767F RID: 161407 RVA: 0x003C1509 File Offset: 0x003BF709
		public FOnControllerCaptureBeginEvent()
		{
		}

		// Token: 0x06027680 RID: 161408 RVA: 0x003C1511 File Offset: 0x003BF711
		[NullableContext(2)]
		public FOnControllerCaptureBeginEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027681 RID: 161409 RVA: 0x003C151B File Offset: 0x003BF71B
		public FOnControllerCaptureBeginEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027682 RID: 161410 RVA: 0x003C1526 File Offset: 0x003BF726
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027683 RID: 161411 RVA: 0x003C1558 File Offset: 0x003BF758
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnControllerCaptureBeginEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnControllerCaptureBeginEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnControllerCaptureBeginEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnControllerCaptureBeginEvent.OnScriptCallback));
				}
				FOnControllerCaptureBeginEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnControllerCaptureBeginEvent.RegisterId);
		}

		// Token: 0x06027684 RID: 161412 RVA: 0x003C1592 File Offset: 0x003BF792
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027685 RID: 161413 RVA: 0x003C159B File Offset: 0x003BF79B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027686 RID: 161414 RVA: 0x003C15A8 File Offset: 0x003BF7A8
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

		// Token: 0x04015A2D RID: 88621
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A2E RID: 88622
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnControllerCaptureBeginEvent__DelegateSignature";

		// Token: 0x04015A2F RID: 88623
		private static int RegisterId;

		// Token: 0x02003B8B RID: 15243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D65 RID: 97637
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
