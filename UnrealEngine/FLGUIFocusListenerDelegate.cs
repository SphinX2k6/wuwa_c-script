using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002079 RID: 8313
	public sealed class FLGUIFocusListenerDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F5B7 RID: 128439 RVA: 0x002E93A2 File Offset: 0x002E75A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIFocusListenerDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x002E93AE File Offset: 0x002E75AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIFocusListenerDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIFocusListenerDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIFocusListenerDelegate__DelegateSignature");
			}
			return FLGUIFocusListenerDelegate._FunctionPtr;
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x002E93D1 File Offset: 0x002E75D1
		public FLGUIFocusListenerDelegate()
		{
		}

		// Token: 0x0601F5BA RID: 128442 RVA: 0x002E93D9 File Offset: 0x002E75D9
		[NullableContext(2)]
		public FLGUIFocusListenerDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5BB RID: 128443 RVA: 0x002E93E3 File Offset: 0x002E75E3
		public FLGUIFocusListenerDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5BC RID: 128444 RVA: 0x002E93EE File Offset: 0x002E75EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F5BD RID: 128445 RVA: 0x002E9420 File Offset: 0x002E7620
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIFocusListenerDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIFocusListenerDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIFocusListenerDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIFocusListenerDelegate.OnScriptCallback));
				}
				FLGUIFocusListenerDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIFocusListenerDelegate.RegisterId);
		}

		// Token: 0x0601F5BE RID: 128446 RVA: 0x002E945A File Offset: 0x002E765A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F5BF RID: 128447 RVA: 0x002E9468 File Offset: 0x002E7668
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

		// Token: 0x04010F14 RID: 69396
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F15 RID: 69397
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIFocusListenerDelegate__DelegateSignature";

		// Token: 0x04010F16 RID: 69398
		private static int RegisterId;

		// Token: 0x02003480 RID: 13440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401746C RID: 95340
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
