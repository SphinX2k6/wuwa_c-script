using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005B4 RID: 1460
	public sealed class FAndroidScreenChangeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600832A RID: 33578 RVA: 0x000C206A File Offset: 0x000C026A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAndroidScreenChangeHandler.StaticFunctionPtr();
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x000C2076 File Offset: 0x000C0276
		private static IntPtr StaticFunctionPtr()
		{
			if (FAndroidScreenChangeHandler._FunctionPtr == IntPtr.Zero)
			{
				FAndroidScreenChangeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.AndroidScreenChangeHandler__DelegateSignature");
			}
			return FAndroidScreenChangeHandler._FunctionPtr;
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x000C2099 File Offset: 0x000C0299
		public FAndroidScreenChangeHandler()
		{
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x000C20A1 File Offset: 0x000C02A1
		[NullableContext(2)]
		public FAndroidScreenChangeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x000C20AB File Offset: 0x000C02AB
		public FAndroidScreenChangeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x000C20B6 File Offset: 0x000C02B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x000C20E8 File Offset: 0x000C02E8
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FAndroidScreenChangeHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAndroidScreenChangeHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAndroidScreenChangeHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAndroidScreenChangeHandler.OnScriptCallback));
				}
				FAndroidScreenChangeHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAndroidScreenChangeHandler.RegisterId);
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x000C2122 File Offset: 0x000C0322
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x000C2130 File Offset: 0x000C0330
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

		// Token: 0x0400390D RID: 14605
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400390E RID: 14606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.AndroidScreenChangeHandler__DelegateSignature";

		// Token: 0x0400390F RID: 14607
		private static int RegisterId;

		// Token: 0x02000D36 RID: 3382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FD0 RID: 24528
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
