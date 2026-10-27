using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002039 RID: 8249
	public sealed class FLGUIDraggableNavigateToNextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F333 RID: 127795 RVA: 0x002E5338 File Offset: 0x002E3538
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableNavigateToNextDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F334 RID: 127796 RVA: 0x002E5344 File Offset: 0x002E3544
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableNavigateToNextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableNavigateToNextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableNavigateToNextDelegate__DelegateSignature");
			}
			return FLGUIDraggableNavigateToNextDelegate._FunctionPtr;
		}

		// Token: 0x0601F335 RID: 127797 RVA: 0x002E5367 File Offset: 0x002E3567
		public FLGUIDraggableNavigateToNextDelegate()
		{
		}

		// Token: 0x0601F336 RID: 127798 RVA: 0x002E536F File Offset: 0x002E356F
		[NullableContext(2)]
		public FLGUIDraggableNavigateToNextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F337 RID: 127799 RVA: 0x002E5379 File Offset: 0x002E3579
		public FLGUIDraggableNavigateToNextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F338 RID: 127800 RVA: 0x002E5384 File Offset: 0x002E3584
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F339 RID: 127801 RVA: 0x002E53B6 File Offset: 0x002E35B6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIDraggableNavigateToNextDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableNavigateToNextDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableNavigateToNextDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableNavigateToNextDelegate.OnScriptCallback));
				}
				FLGUIDraggableNavigateToNextDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableNavigateToNextDelegate.RegisterId);
		}

		// Token: 0x0601F33A RID: 127802 RVA: 0x002E53F0 File Offset: 0x002E35F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F33B RID: 127803 RVA: 0x002E53FC File Offset: 0x002E35FC
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

		// Token: 0x04010E2C RID: 69164
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E2D RID: 69165
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableNavigateToNextDelegate__DelegateSignature";

		// Token: 0x04010E2E RID: 69166
		private static int RegisterId;

		// Token: 0x02003444 RID: 13380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017427 RID: 95271
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
