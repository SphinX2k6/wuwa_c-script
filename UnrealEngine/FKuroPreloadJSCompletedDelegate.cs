using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020015B7 RID: 5559
	public sealed class FKuroPreloadJSCompletedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014111 RID: 82193 RVA: 0x001D7231 File Offset: 0x001D5431
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroPreloadJSCompletedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06014112 RID: 82194 RVA: 0x001D723D File Offset: 0x001D543D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroPreloadJSCompletedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroPreloadJSCompletedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/JsEnv.KuroPreloadJSCompletedDelegate__DelegateSignature");
			}
			return FKuroPreloadJSCompletedDelegate._FunctionPtr;
		}

		// Token: 0x06014113 RID: 82195 RVA: 0x001D7260 File Offset: 0x001D5460
		public FKuroPreloadJSCompletedDelegate()
		{
		}

		// Token: 0x06014114 RID: 82196 RVA: 0x001D7268 File Offset: 0x001D5468
		[NullableContext(2)]
		public FKuroPreloadJSCompletedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014115 RID: 82197 RVA: 0x001D7272 File Offset: 0x001D5472
		public FKuroPreloadJSCompletedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014116 RID: 82198 RVA: 0x001D727D File Offset: 0x001D547D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014117 RID: 82199 RVA: 0x001D72AF File Offset: 0x001D54AF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FKuroPreloadJSCompletedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroPreloadJSCompletedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroPreloadJSCompletedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroPreloadJSCompletedDelegate.OnScriptCallback));
				}
				FKuroPreloadJSCompletedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroPreloadJSCompletedDelegate.RegisterId);
		}

		// Token: 0x06014118 RID: 82200 RVA: 0x001D72E9 File Offset: 0x001D54E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06014119 RID: 82201 RVA: 0x001D72F4 File Offset: 0x001D54F4
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

		// Token: 0x0400AE8E RID: 44686
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400AE8F RID: 44687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.KuroPreloadJSCompletedDelegate__DelegateSignature";

		// Token: 0x0400AE90 RID: 44688
		private static int RegisterId;

		// Token: 0x02002EBF RID: 11967
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169BC RID: 92604
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
