using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020002A3 RID: 675
	public sealed class FTimerDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060049F2 RID: 18930 RVA: 0x000678FC File Offset: 0x00065AFC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTimerDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00067908 File Offset: 0x00065B08
		private static IntPtr StaticFunctionPtr()
		{
			if (FTimerDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTimerDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.TimerDynamicDelegate__DelegateSignature");
			}
			return FTimerDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0006792B File Offset: 0x00065B2B
		public FTimerDynamicDelegate()
		{
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00067933 File Offset: 0x00065B33
		[NullableContext(2)]
		public FTimerDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x0006793D File Offset: 0x00065B3D
		public FTimerDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x00067948 File Offset: 0x00065B48
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0006797A File Offset: 0x00065B7A
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FTimerDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTimerDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTimerDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTimerDynamicDelegate.OnScriptCallback));
				}
				FTimerDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTimerDynamicDelegate.RegisterId);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x000679B4 File Offset: 0x00065BB4
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x000679C0 File Offset: 0x00065BC0
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

		// Token: 0x04001D17 RID: 7447
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001D18 RID: 7448
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TimerDynamicDelegate__DelegateSignature";

		// Token: 0x04001D19 RID: 7449
		private static int RegisterId;

		// Token: 0x020009F5 RID: 2549
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400599A RID: 22938
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
