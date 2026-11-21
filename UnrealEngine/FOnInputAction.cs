using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000864 RID: 2148
	public sealed class FOnInputAction : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BADF RID: 47839 RVA: 0x0012B20A File Offset: 0x0012940A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInputAction.StaticFunctionPtr();
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x0012B216 File Offset: 0x00129416
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnInputAction._FunctionPtr == IntPtr.Zero)
			{
				FOnInputAction._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnInputAction__DelegateSignature");
			}
			return FOnInputAction._FunctionPtr;
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x0012B239 File Offset: 0x00129439
		public FOnInputAction()
		{
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x0012B241 File Offset: 0x00129441
		[NullableContext(2)]
		public FOnInputAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x0012B24B File Offset: 0x0012944B
		public FOnInputAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x0012B256 File Offset: 0x00129456
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x0012B288 File Offset: 0x00129488
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FOnInputAction.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInputAction.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInputAction.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInputAction.OnScriptCallback));
				}
				FOnInputAction.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnInputAction.RegisterId);
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x0012B2C2 File Offset: 0x001294C2
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600BAE7 RID: 47847 RVA: 0x0012B2D0 File Offset: 0x001294D0
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

		// Token: 0x040054B6 RID: 21686
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054B7 RID: 21687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnInputAction__DelegateSignature";

		// Token: 0x040054B8 RID: 21688
		private static int RegisterId;

		// Token: 0x020013FE RID: 5118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A8 RID: 26792
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
