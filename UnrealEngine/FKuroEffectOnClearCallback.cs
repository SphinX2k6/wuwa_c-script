using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020018CC RID: 6348
	public sealed class FKuroEffectOnClearCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601776A RID: 96106 RVA: 0x0022513A File Offset: 0x0022333A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectOnClearCallback.StaticFunctionPtr();
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x00225146 File Offset: 0x00223346
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectOnClearCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectOnClearCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectOnClearCallback__DelegateSignature");
			}
			return FKuroEffectOnClearCallback._FunctionPtr;
		}

		// Token: 0x0601776C RID: 96108 RVA: 0x00225169 File Offset: 0x00223369
		public FKuroEffectOnClearCallback()
		{
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x00225171 File Offset: 0x00223371
		[NullableContext(2)]
		public FKuroEffectOnClearCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x0022517B File Offset: 0x0022337B
		public FKuroEffectOnClearCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x00225186 File Offset: 0x00223386
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017770 RID: 96112 RVA: 0x002251B8 File Offset: 0x002233B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FKuroEffectOnClearCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectOnClearCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectOnClearCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectOnClearCallback.OnScriptCallback));
				}
				FKuroEffectOnClearCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectOnClearCallback.RegisterId);
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x002251F2 File Offset: 0x002233F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x00225200 File Offset: 0x00223400
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

		// Token: 0x0400CC0E RID: 52238
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CC0F RID: 52239
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectOnClearCallback__DelegateSignature";

		// Token: 0x0400CC10 RID: 52240
		private static int RegisterId;

		// Token: 0x02002FB8 RID: 12216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B9C RID: 93084
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
