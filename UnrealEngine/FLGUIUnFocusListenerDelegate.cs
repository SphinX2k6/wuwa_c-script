using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020020DC RID: 8412
	public sealed class FLGUIUnFocusListenerDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FAD7 RID: 129751 RVA: 0x002F1E07 File Offset: 0x002F0007
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIUnFocusListenerDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FAD8 RID: 129752 RVA: 0x002F1E13 File Offset: 0x002F0013
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIUnFocusListenerDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIUnFocusListenerDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIUnFocusListenerDelegate__DelegateSignature");
			}
			return FLGUIUnFocusListenerDelegate._FunctionPtr;
		}

		// Token: 0x0601FAD9 RID: 129753 RVA: 0x002F1E36 File Offset: 0x002F0036
		public FLGUIUnFocusListenerDelegate()
		{
		}

		// Token: 0x0601FADA RID: 129754 RVA: 0x002F1E3E File Offset: 0x002F003E
		[NullableContext(2)]
		public FLGUIUnFocusListenerDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FADB RID: 129755 RVA: 0x002F1E48 File Offset: 0x002F0048
		public FLGUIUnFocusListenerDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FADC RID: 129756 RVA: 0x002F1E53 File Offset: 0x002F0053
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FADD RID: 129757 RVA: 0x002F1E85 File Offset: 0x002F0085
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FADE RID: 129758 RVA: 0x002F1EBF File Offset: 0x002F00BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601FADF RID: 129759 RVA: 0x002F1ECC File Offset: 0x002F00CC
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

		// Token: 0x04011174 RID: 70004
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011175 RID: 70005
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIUnFocusListenerDelegate__DelegateSignature";

		// Token: 0x04011176 RID: 70006
		private static int RegisterId;

		// Token: 0x020034D2 RID: 13522
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174DF RID: 95455
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
