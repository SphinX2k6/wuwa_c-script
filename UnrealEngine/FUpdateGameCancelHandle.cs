using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200084A RID: 2122
	public sealed class FUpdateGameCancelHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B8F1 RID: 47345 RVA: 0x001281B4 File Offset: 0x001263B4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUpdateGameCancelHandle.StaticFunctionPtr();
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x001281C0 File Offset: 0x001263C0
		private static IntPtr StaticFunctionPtr()
		{
			if (FUpdateGameCancelHandle._FunctionPtr == IntPtr.Zero)
			{
				FUpdateGameCancelHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/TapUpdate.UpdateGameCancelHandle__DelegateSignature");
			}
			return FUpdateGameCancelHandle._FunctionPtr;
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x001281E3 File Offset: 0x001263E3
		public FUpdateGameCancelHandle()
		{
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x001281EB File Offset: 0x001263EB
		[NullableContext(2)]
		public FUpdateGameCancelHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x001281F5 File Offset: 0x001263F5
		public FUpdateGameCancelHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x00128200 File Offset: 0x00126400
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x00128232 File Offset: 0x00126432
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FUpdateGameCancelHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUpdateGameCancelHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUpdateGameCancelHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUpdateGameCancelHandle.OnScriptCallback));
				}
				FUpdateGameCancelHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUpdateGameCancelHandle.RegisterId);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x0012826C File Offset: 0x0012646C
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x00128278 File Offset: 0x00126478
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

		// Token: 0x04005402 RID: 21506
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005403 RID: 21507
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TapUpdate.UpdateGameCancelHandle__DelegateSignature";

		// Token: 0x04005404 RID: 21508
		private static int RegisterId;

		// Token: 0x020013DA RID: 5082
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006846 RID: 26694
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
