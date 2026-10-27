using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C3 RID: 8387
	public sealed class FLGUIShowVirtualKeyboard : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F992 RID: 129426 RVA: 0x002EFA96 File Offset: 0x002EDC96
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIShowVirtualKeyboard.StaticFunctionPtr();
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x002EFAA2 File Offset: 0x002EDCA2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIShowVirtualKeyboard._FunctionPtr == IntPtr.Zero)
			{
				FLGUIShowVirtualKeyboard._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIShowVirtualKeyboard__DelegateSignature");
			}
			return FLGUIShowVirtualKeyboard._FunctionPtr;
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x002EFAC5 File Offset: 0x002EDCC5
		public FLGUIShowVirtualKeyboard()
		{
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x002EFACD File Offset: 0x002EDCCD
		[NullableContext(2)]
		public FLGUIShowVirtualKeyboard(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F996 RID: 129430 RVA: 0x002EFAD7 File Offset: 0x002EDCD7
		public FLGUIShowVirtualKeyboard(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F997 RID: 129431 RVA: 0x002EFAE2 File Offset: 0x002EDCE2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F998 RID: 129432 RVA: 0x002EFB14 File Offset: 0x002EDD14
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIShowVirtualKeyboard.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIShowVirtualKeyboard.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIShowVirtualKeyboard.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIShowVirtualKeyboard.OnScriptCallback));
				}
				FLGUIShowVirtualKeyboard.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIShowVirtualKeyboard.RegisterId);
		}

		// Token: 0x0601F999 RID: 129433 RVA: 0x002EFB50 File Offset: 0x002EDD50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool state)
		{
			FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams* ptr = stackalloc FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIShowVirtualKeyboard.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->state = state;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F99A RID: 129434 RVA: 0x002EFB90 File Offset: 0x002EDD90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIShowVirtualKeyboard.__FLGUIShowVirtualKeyboard_DelegateParams*)__Parameters)->state);
		}

		// Token: 0x040110E4 RID: 69860
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110E5 RID: 69861
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIShowVirtualKeyboard__DelegateSignature";

		// Token: 0x040110E6 RID: 69862
		private static int RegisterId;

		// Token: 0x020034BA RID: 13498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIShowVirtualKeyboard_DelegateParams
		{
			// Token: 0x040174C3 RID: 95427
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x020034BB RID: 13499
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C4 RID: 95428
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
