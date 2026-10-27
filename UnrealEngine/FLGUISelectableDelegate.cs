using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BF RID: 8383
	public sealed class FLGUISelectableDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F930 RID: 129328 RVA: 0x002EF0CA File Offset: 0x002ED2CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISelectableDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F931 RID: 129329 RVA: 0x002EF0D6 File Offset: 0x002ED2D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISelectableDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISelectableDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISelectableDelegate__DelegateSignature");
			}
			return FLGUISelectableDelegate._FunctionPtr;
		}

		// Token: 0x0601F932 RID: 129330 RVA: 0x002EF0F9 File Offset: 0x002ED2F9
		public FLGUISelectableDelegate()
		{
		}

		// Token: 0x0601F933 RID: 129331 RVA: 0x002EF101 File Offset: 0x002ED301
		[NullableContext(2)]
		public FLGUISelectableDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F934 RID: 129332 RVA: 0x002EF10B File Offset: 0x002ED30B
		public FLGUISelectableDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F935 RID: 129333 RVA: 0x002EF116 File Offset: 0x002ED316
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUISelectableComponent, bool>) ?? ((Action<UUISelectableComponent, bool>)Delegate.CreateDelegate(typeof(Action<UUISelectableComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F936 RID: 129334 RVA: 0x002EF148 File Offset: 0x002ED348
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUISelectableComponent, bool> Callback)
		{
			if (FLGUISelectableDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISelectableDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISelectableDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISelectableDelegate.OnScriptCallback));
				}
				FLGUISelectableDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISelectableDelegate.RegisterId);
		}

		// Token: 0x0601F937 RID: 129335 RVA: 0x002EF184 File Offset: 0x002ED384
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUISelectableComponent SelectableComponent, bool bCreate)
		{
			FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams* ptr = stackalloc FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISelectableDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SelectableComponent = ((SelectableComponent != null) ? SelectableComponent.NativePtr : IntPtr.Zero);
			ptr->bCreate = bCreate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F938 RID: 129336 RVA: 0x002EF1D8 File Offset: 0x002ED3D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUISelectableComponent, bool> action = target as Action<UUISelectableComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUISelectableComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(((FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams*)__Parameters)->SelectableComponent);
			action(orCreateUObjectByNativePointer, ((FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams*)__Parameters)->bCreate);
		}

		// Token: 0x040110B0 RID: 69808
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110B1 RID: 69809
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISelectableDelegate__DelegateSignature";

		// Token: 0x040110B2 RID: 69810
		private static int RegisterId;

		// Token: 0x020034B6 RID: 13494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUISelectableDelegate_DelegateParams
		{
			// Token: 0x040174BE RID: 95422
			[FieldOffset(0)]
			public IntPtr SelectableComponent;

			// Token: 0x040174BF RID: 95423
			[FieldOffset(8)]
			public bool bCreate;
		}

		// Token: 0x020034B7 RID: 13495
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C0 RID: 95424
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
