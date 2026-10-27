using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002090 RID: 8336
	public sealed class FLGUINavigationChangeDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F70C RID: 128780 RVA: 0x002EB587 File Offset: 0x002E9787
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUINavigationChangeDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F70D RID: 128781 RVA: 0x002EB593 File Offset: 0x002E9793
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUINavigationChangeDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUINavigationChangeDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUINavigationChangeDynamicDelegate__DelegateSignature");
			}
			return FLGUINavigationChangeDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F70E RID: 128782 RVA: 0x002EB5B6 File Offset: 0x002E97B6
		public FLGUINavigationChangeDynamicDelegate()
		{
		}

		// Token: 0x0601F70F RID: 128783 RVA: 0x002EB5BE File Offset: 0x002E97BE
		[NullableContext(2)]
		public FLGUINavigationChangeDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F710 RID: 128784 RVA: 0x002EB5C8 File Offset: 0x002E97C8
		public FLGUINavigationChangeDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F711 RID: 128785 RVA: 0x002EB5D3 File Offset: 0x002E97D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool>) ?? ((Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool>)Delegate.CreateDelegate(typeof(Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F712 RID: 128786 RVA: 0x002EB605 File Offset: 0x002E9805
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool> Callback)
		{
			if (FLGUINavigationChangeDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUINavigationChangeDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUINavigationChangeDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUINavigationChangeDynamicDelegate.OnScriptCallback));
				}
				FLGUINavigationChangeDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUINavigationChangeDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F713 RID: 128787 RVA: 0x002EB640 File Offset: 0x002E9840
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(NavigationComponentState State, USceneComponent CursorComponent, ELGUIPointerInputType InputType, bool bForceNavigation)
		{
			FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams* ptr = stackalloc FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUINavigationChangeDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->CursorComponent = ((CursorComponent != null) ? CursorComponent.NativePtr : IntPtr.Zero);
			ptr->InputType = InputType;
			ptr->bForceNavigation = bForceNavigation;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F714 RID: 128788 RVA: 0x002EB6A4 File Offset: 0x002E98A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool> action = target as Action<NavigationComponentState, USceneComponent, ELGUIPointerInputType, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams*)__Parameters)->CursorComponent);
			action(((FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams*)__Parameters)->State, orCreateUObjectByNativePointer, ((FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams*)__Parameters)->InputType, ((FLGUINavigationChangeDynamicDelegate.__FLGUINavigationChangeDynamicDelegate_DelegateParams*)__Parameters)->bForceNavigation);
		}

		// Token: 0x04010FAC RID: 69548
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FAD RID: 69549
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUINavigationChangeDynamicDelegate__DelegateSignature";

		// Token: 0x04010FAE RID: 69550
		private static int RegisterId;

		// Token: 0x02003494 RID: 13460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUINavigationChangeDynamicDelegate_DelegateParams
		{
			// Token: 0x04017489 RID: 95369
			[FieldOffset(0)]
			public NavigationComponentState State;

			// Token: 0x0401748A RID: 95370
			[FieldOffset(8)]
			public IntPtr CursorComponent;

			// Token: 0x0401748B RID: 95371
			[FieldOffset(16)]
			public ELGUIPointerInputType InputType;

			// Token: 0x0401748C RID: 95372
			[FieldOffset(17)]
			public bool bForceNavigation;
		}

		// Token: 0x02003495 RID: 13461
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401748D RID: 95373
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
