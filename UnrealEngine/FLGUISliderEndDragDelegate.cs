using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020020C5 RID: 8389
	public sealed class FLGUISliderEndDragDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F9A4 RID: 129444 RVA: 0x002EFD1E File Offset: 0x002EDF1E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderEndDragDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F9A5 RID: 129445 RVA: 0x002EFD2A File Offset: 0x002EDF2A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderEndDragDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderEndDragDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderEndDragDelegate__DelegateSignature");
			}
			return FLGUISliderEndDragDelegate._FunctionPtr;
		}

		// Token: 0x0601F9A6 RID: 129446 RVA: 0x002EFD4D File Offset: 0x002EDF4D
		public FLGUISliderEndDragDelegate()
		{
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x002EFD55 File Offset: 0x002EDF55
		[NullableContext(2)]
		public FLGUISliderEndDragDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x002EFD5F File Offset: 0x002EDF5F
		public FLGUISliderEndDragDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9A9 RID: 129449 RVA: 0x002EFD6A File Offset: 0x002EDF6A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F9AA RID: 129450 RVA: 0x002EFD9C File Offset: 0x002EDF9C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUISliderEndDragDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISliderEndDragDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISliderEndDragDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISliderEndDragDelegate.OnScriptCallback));
				}
				FLGUISliderEndDragDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISliderEndDragDelegate.RegisterId);
		}

		// Token: 0x0601F9AB RID: 129451 RVA: 0x002EFDD6 File Offset: 0x002EDFD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601F9AC RID: 129452 RVA: 0x002EFDE4 File Offset: 0x002EDFE4
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

		// Token: 0x040110EA RID: 69866
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110EB RID: 69867
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderEndDragDelegate__DelegateSignature";

		// Token: 0x040110EC RID: 69868
		private static int RegisterId;

		// Token: 0x020034BE RID: 13502
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C7 RID: 95431
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
