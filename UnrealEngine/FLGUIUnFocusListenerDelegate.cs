using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006C9 RID: 1737
	public sealed class FLGUIUnFocusListenerDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009436 RID: 37942 RVA: 0x000DFA0B File Offset: 0x000DDC0B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIUnFocusListenerDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x000DFA17 File Offset: 0x000DDC17
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIUnFocusListenerDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIUnFocusListenerDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIUnFocusListenerDelegate__DelegateSignature");
			}
			return FLGUIUnFocusListenerDelegate._FunctionPtr;
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x000DFA3A File Offset: 0x000DDC3A
		public FLGUIUnFocusListenerDelegate()
		{
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x000DFA42 File Offset: 0x000DDC42
		[NullableContext(2)]
		public FLGUIUnFocusListenerDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x000DFA4C File Offset: 0x000DDC4C
		public FLGUIUnFocusListenerDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x000DFA57 File Offset: 0x000DDC57
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x000DFA89 File Offset: 0x000DDC89
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIUnFocusListenerDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIUnFocusListenerDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIUnFocusListenerDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIUnFocusListenerDelegate.OnScriptCallback));
				}
				FLGUIUnFocusListenerDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIUnFocusListenerDelegate.RegisterId);
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x000DFAC3 File Offset: 0x000DDCC3
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x000DFAD0 File Offset: 0x000DDCD0
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

		// Token: 0x04004090 RID: 16528
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004091 RID: 16529
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIUnFocusListenerDelegate__DelegateSignature";

		// Token: 0x04004092 RID: 16530
		private static int RegisterId;

		// Token: 0x02000EFE RID: 3838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062C4 RID: 25284
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
