using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020DB RID: 8411
	public sealed class FLGUITryFindNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FACE RID: 129742 RVA: 0x002F1C7E File Offset: 0x002EFE7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITryFindNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FACF RID: 129743 RVA: 0x002F1C8A File Offset: 0x002EFE8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITryFindNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITryFindNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITryFindNavigationDelegate__DelegateSignature");
			}
			return FLGUITryFindNavigationDelegate._FunctionPtr;
		}

		// Token: 0x0601FAD0 RID: 129744 RVA: 0x002F1CAD File Offset: 0x002EFEAD
		public FLGUITryFindNavigationDelegate()
		{
		}

		// Token: 0x0601FAD1 RID: 129745 RVA: 0x002F1CB5 File Offset: 0x002EFEB5
		[NullableContext(2)]
		public FLGUITryFindNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FAD2 RID: 129746 RVA: 0x002F1CBF File Offset: 0x002EFEBF
		public FLGUITryFindNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FAD3 RID: 129747 RVA: 0x002F1CCA File Offset: 0x002EFECA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>) ?? ((Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>)Delegate.CreateDelegate(typeof(Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FAD4 RID: 129748 RVA: 0x002F1CFC File Offset: 0x002EFEFC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> Callback)
		{
			if (FLGUITryFindNavigationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITryFindNavigationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITryFindNavigationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITryFindNavigationDelegate.OnScriptCallback));
				}
				FLGUITryFindNavigationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITryFindNavigationDelegate.RegisterId);
		}

		// Token: 0x0601FAD5 RID: 129749 RVA: 0x002F1D38 File Offset: 0x002EFF38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USceneComponent Execute(ELGUINavigationDirection direction, UUISelectableComponent SelectableComponent)
		{
			FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams* ptr = stackalloc FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITryFindNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->direction = direction;
			ptr->SelectableComponent = ((SelectableComponent != null) ? SelectableComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ptr->__Result);
		}

		// Token: 0x0601FAD6 RID: 129750 RVA: 0x002F1D98 File Offset: 0x002EFF98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> func = target as Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUISelectableComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->SelectableComponent);
			USceneComponent usceneComponent = func(((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->direction, orCreateUObjectByNativePointer);
			((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->__Result = ((usceneComponent != null) ? usceneComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04011171 RID: 70001
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011172 RID: 70002
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITryFindNavigationDelegate__DelegateSignature";

		// Token: 0x04011173 RID: 70003
		private static int RegisterId;

		// Token: 0x020034D0 RID: 13520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUITryFindNavigationDelegate_DelegateParams
		{
			// Token: 0x040174DB RID: 95451
			[FieldOffset(0)]
			public ELGUINavigationDirection direction;

			// Token: 0x040174DC RID: 95452
			[FieldOffset(8)]
			public IntPtr SelectableComponent;

			// Token: 0x040174DD RID: 95453
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020034D1 RID: 13521
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174DE RID: 95454
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
