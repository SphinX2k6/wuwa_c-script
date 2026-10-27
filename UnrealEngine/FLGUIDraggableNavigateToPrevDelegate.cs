using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200203A RID: 8250
	public sealed class FLGUIDraggableNavigateToPrevDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F33C RID: 127804 RVA: 0x002E543E File Offset: 0x002E363E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNavigateToPrevDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F33D RID: 127805 RVA: 0x002E544A File Offset: 0x002E364A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNavigateToPrevDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNavigateToPrevDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNavigateToPrevDelegate__DelegateSignature");
			}
			return FLGUIDraggableNavigateToPrevDelegate._FunctionPtr;
		}

		// Token: 0x0601F33E RID: 127806 RVA: 0x002E546D File Offset: 0x002E366D
		public FLGUIDraggableNavigateToPrevDelegate()
		{
		}

		// Token: 0x0601F33F RID: 127807 RVA: 0x002E5475 File Offset: 0x002E3675
		[NullableContext(2)]
		public FLGUIDraggableNavigateToPrevDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F340 RID: 127808 RVA: 0x002E547F File Offset: 0x002E367F
		public FLGUIDraggableNavigateToPrevDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F341 RID: 127809 RVA: 0x002E548A File Offset: 0x002E368A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F342 RID: 127810 RVA: 0x002E54BC File Offset: 0x002E36BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIDraggableNavigateToPrevDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableNavigateToPrevDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableNavigateToPrevDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableNavigateToPrevDelegate.OnScriptCallback));
				}
				FLGUIDraggableNavigateToPrevDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableNavigateToPrevDelegate.RegisterId);
		}

		// Token: 0x0601F343 RID: 127811 RVA: 0x002E54F6 File Offset: 0x002E36F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F344 RID: 127812 RVA: 0x002E5504 File Offset: 0x002E3704
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

		// Token: 0x04010E2F RID: 69167
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E30 RID: 69168
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNavigateToPrevDelegate__DelegateSignature";

		// Token: 0x04010E31 RID: 69169
		private static int RegisterId;

		// Token: 0x02003445 RID: 13381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017428 RID: 95272
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
