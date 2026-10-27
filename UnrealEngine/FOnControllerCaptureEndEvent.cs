using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002999 RID: 10649
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnControllerCaptureEndEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027687 RID: 161415 RVA: 0x003C15EA File Offset: 0x003BF7EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnControllerCaptureEndEvent.StaticFunctionPtr();
		}

		// Token: 0x06027688 RID: 161416 RVA: 0x003C15F6 File Offset: 0x003BF7F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnControllerCaptureEndEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnControllerCaptureEndEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnControllerCaptureEndEvent__DelegateSignature");
			}
			return FOnControllerCaptureEndEvent._FunctionPtr;
		}

		// Token: 0x06027689 RID: 161417 RVA: 0x003C1619 File Offset: 0x003BF819
		public FOnControllerCaptureEndEvent()
		{
		}

		// Token: 0x0602768A RID: 161418 RVA: 0x003C1621 File Offset: 0x003BF821
		[NullableContext(2)]
		public FOnControllerCaptureEndEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602768B RID: 161419 RVA: 0x003C162B File Offset: 0x003BF82B
		public FOnControllerCaptureEndEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602768C RID: 161420 RVA: 0x003C1636 File Offset: 0x003BF836
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602768D RID: 161421 RVA: 0x003C1668 File Offset: 0x003BF868
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnControllerCaptureEndEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnControllerCaptureEndEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnControllerCaptureEndEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnControllerCaptureEndEvent.OnScriptCallback));
				}
				FOnControllerCaptureEndEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnControllerCaptureEndEvent.RegisterId);
		}

		// Token: 0x0602768E RID: 161422 RVA: 0x003C16A2 File Offset: 0x003BF8A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602768F RID: 161423 RVA: 0x003C16AB File Offset: 0x003BF8AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027690 RID: 161424 RVA: 0x003C16B8 File Offset: 0x003BF8B8
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

		// Token: 0x04015A30 RID: 88624
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A31 RID: 88625
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnControllerCaptureEndEvent__DelegateSignature";

		// Token: 0x04015A32 RID: 88626
		private static int RegisterId;

		// Token: 0x02003B8C RID: 15244
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D66 RID: 97638
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
