using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002993 RID: 10643
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnButtonClickedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602764B RID: 161355 RVA: 0x003C0F52 File Offset: 0x003BF152
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnButtonClickedEvent.StaticFunctionPtr();
		}

		// Token: 0x0602764C RID: 161356 RVA: 0x003C0F5E File Offset: 0x003BF15E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnButtonClickedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnButtonClickedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnButtonClickedEvent__DelegateSignature");
			}
			return FOnButtonClickedEvent._FunctionPtr;
		}

		// Token: 0x0602764D RID: 161357 RVA: 0x003C0F81 File Offset: 0x003BF181
		public FOnButtonClickedEvent()
		{
		}

		// Token: 0x0602764E RID: 161358 RVA: 0x003C0F89 File Offset: 0x003BF189
		[NullableContext(2)]
		public FOnButtonClickedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602764F RID: 161359 RVA: 0x003C0F93 File Offset: 0x003BF193
		public FOnButtonClickedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027650 RID: 161360 RVA: 0x003C0F9E File Offset: 0x003BF19E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027651 RID: 161361 RVA: 0x003C0FD0 File Offset: 0x003BF1D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnButtonClickedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnButtonClickedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnButtonClickedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnButtonClickedEvent.OnScriptCallback));
				}
				FOnButtonClickedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnButtonClickedEvent.RegisterId);
		}

		// Token: 0x06027652 RID: 161362 RVA: 0x003C100A File Offset: 0x003BF20A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027653 RID: 161363 RVA: 0x003C1013 File Offset: 0x003BF213
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027654 RID: 161364 RVA: 0x003C1020 File Offset: 0x003BF220
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

		// Token: 0x04015A1E RID: 88606
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A1F RID: 88607
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnButtonClickedEvent__DelegateSignature";

		// Token: 0x04015A20 RID: 88608
		private static int RegisterId;

		// Token: 0x02003B85 RID: 15237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D5F RID: 97631
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
