using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200202B RID: 8235
	public sealed class FLGUIButtonDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F18F RID: 127375 RVA: 0x002E35E4 File Offset: 0x002E17E4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F190 RID: 127376 RVA: 0x002E35F0 File Offset: 0x002E17F0
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonDynamicDelegate__DelegateSignature");
			}
			return FLGUIButtonDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F191 RID: 127377 RVA: 0x002E3613 File Offset: 0x002E1813
		public FLGUIButtonDynamicDelegate()
		{
		}

		// Token: 0x0601F192 RID: 127378 RVA: 0x002E361B File Offset: 0x002E181B
		[NullableContext(2)]
		public FLGUIButtonDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F193 RID: 127379 RVA: 0x002E3625 File Offset: 0x002E1825
		public FLGUIButtonDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F194 RID: 127380 RVA: 0x002E3630 File Offset: 0x002E1830
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F195 RID: 127381 RVA: 0x002E3662 File Offset: 0x002E1862
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUIButtonDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonDynamicDelegate.OnScriptCallback));
				}
				FLGUIButtonDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F196 RID: 127382 RVA: 0x002E369C File Offset: 0x002E189C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F197 RID: 127383 RVA: 0x002E36A8 File Offset: 0x002E18A8
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

		// Token: 0x04010DAE RID: 69038
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010DAF RID: 69039
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonDynamicDelegate__DelegateSignature";

		// Token: 0x04010DB0 RID: 69040
		private static int RegisterId;

		// Token: 0x02003439 RID: 13369
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017419 RID: 95257
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
