using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006AB RID: 1707
	public sealed class FLGUIPlayTweenCompleteDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060092AF RID: 37551 RVA: 0x000DCFB5 File Offset: 0x000DB1B5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIPlayTweenCompleteDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x000DCFC1 File Offset: 0x000DB1C1
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIPlayTweenCompleteDynamicDelegate__DelegateSignature");
			}
			return FLGUIPlayTweenCompleteDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x000DCFE4 File Offset: 0x000DB1E4
		public FLGUIPlayTweenCompleteDynamicDelegate()
		{
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x000DCFEC File Offset: 0x000DB1EC
		[NullableContext(2)]
		public FLGUIPlayTweenCompleteDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x000DCFF6 File Offset: 0x000DB1F6
		public FLGUIPlayTweenCompleteDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x000DD001 File Offset: 0x000DB201
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x000DD033 File Offset: 0x000DB233
		[NullableContext(1)]
		public void Bind(Action Callback)
		{
			if (FLGUIPlayTweenCompleteDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIPlayTweenCompleteDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIPlayTweenCompleteDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIPlayTweenCompleteDynamicDelegate.OnScriptCallback));
				}
				FLGUIPlayTweenCompleteDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIPlayTweenCompleteDynamicDelegate.RegisterId);
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x000DD06D File Offset: 0x000DB26D
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x000DD078 File Offset: 0x000DB278
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

		// Token: 0x04003FF1 RID: 16369
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FF2 RID: 16370
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPlayTweenCompleteDynamicDelegate__DelegateSignature";

		// Token: 0x04003FF3 RID: 16371
		private static int RegisterId;

		// Token: 0x02000ED7 RID: 3799
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006297 RID: 25239
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
