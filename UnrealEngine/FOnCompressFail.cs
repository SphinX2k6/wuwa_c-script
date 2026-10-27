using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001EE4 RID: 7908
	public sealed class FOnCompressFail : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E10B RID: 123147 RVA: 0x002CA07F File Offset: 0x002C827F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCompressFail.StaticFunctionPtr();
		}

		// Token: 0x0601E10C RID: 123148 RVA: 0x002CA08B File Offset: 0x002C828B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCompressFail._FunctionPtr == IntPtr.Zero)
			{
				FOnCompressFail._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnCompressFail__DelegateSignature");
			}
			return FOnCompressFail._FunctionPtr;
		}

		// Token: 0x0601E10D RID: 123149 RVA: 0x002CA0AE File Offset: 0x002C82AE
		public FOnCompressFail()
		{
		}

		// Token: 0x0601E10E RID: 123150 RVA: 0x002CA0B6 File Offset: 0x002C82B6
		[NullableContext(2)]
		public FOnCompressFail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E10F RID: 123151 RVA: 0x002CA0C0 File Offset: 0x002C82C0
		public FOnCompressFail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E110 RID: 123152 RVA: 0x002CA0CB File Offset: 0x002C82CB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E111 RID: 123153 RVA: 0x002CA0FD File Offset: 0x002C82FD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnCompressFail.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCompressFail.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCompressFail.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCompressFail.OnScriptCallback));
				}
				FOnCompressFail.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnCompressFail.RegisterId);
		}

		// Token: 0x0601E112 RID: 123154 RVA: 0x002CA137 File Offset: 0x002C8337
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601E113 RID: 123155 RVA: 0x002CA144 File Offset: 0x002C8344
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

		// Token: 0x04010406 RID: 66566
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010407 RID: 66567
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnCompressFail__DelegateSignature";

		// Token: 0x04010408 RID: 66568
		private static int RegisterId;

		// Token: 0x020033B1 RID: 13233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017365 RID: 95077
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
