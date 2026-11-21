using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005BD RID: 1469
	public sealed class FEndLoadTransitionMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008377 RID: 33655 RVA: 0x000C2A42 File Offset: 0x000C0C42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEndLoadTransitionMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x000C2A4E File Offset: 0x000C0C4E
		private static IntPtr StaticFunctionPtr()
		{
			if (FEndLoadTransitionMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FEndLoadTransitionMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.EndLoadTransitionMapDelegate__DelegateSignature");
			}
			return FEndLoadTransitionMapDelegate._FunctionPtr;
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x000C2A71 File Offset: 0x000C0C71
		public FEndLoadTransitionMapDelegate()
		{
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x000C2A79 File Offset: 0x000C0C79
		[NullableContext(2)]
		public FEndLoadTransitionMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x000C2A83 File Offset: 0x000C0C83
		public FEndLoadTransitionMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x000C2A8E File Offset: 0x000C0C8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x000C2AC0 File Offset: 0x000C0CC0
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FEndLoadTransitionMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEndLoadTransitionMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEndLoadTransitionMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEndLoadTransitionMapDelegate.OnScriptCallback));
				}
				FEndLoadTransitionMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEndLoadTransitionMapDelegate.RegisterId);
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x000C2AFA File Offset: 0x000C0CFA
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x000C2B08 File Offset: 0x000C0D08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400392C RID: 14636
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400392D RID: 14637
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.EndLoadTransitionMapDelegate__DelegateSignature";

		// Token: 0x0400392E RID: 14638
		private static int RegisterId;

		// Token: 0x02000D42 RID: 3394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FDF RID: 24543
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
