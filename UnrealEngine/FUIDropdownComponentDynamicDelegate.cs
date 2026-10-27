using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213E RID: 8510
	public sealed class FUIDropdownComponentDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060200DF RID: 131295 RVA: 0x002FAADC File Offset: 0x002F8CDC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIDropdownComponentDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060200E0 RID: 131296 RVA: 0x002FAAE8 File Offset: 0x002F8CE8
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIDropdownComponentDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIDropdownComponentDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIDropdownComponentDynamicDelegate__DelegateSignature");
			}
			return FUIDropdownComponentDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060200E1 RID: 131297 RVA: 0x002FAB0B File Offset: 0x002F8D0B
		public FUIDropdownComponentDynamicDelegate()
		{
		}

		// Token: 0x060200E2 RID: 131298 RVA: 0x002FAB13 File Offset: 0x002F8D13
		[NullableContext(2)]
		public FUIDropdownComponentDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060200E3 RID: 131299 RVA: 0x002FAB1D File Offset: 0x002F8D1D
		public FUIDropdownComponentDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060200E4 RID: 131300 RVA: 0x002FAB28 File Offset: 0x002F8D28
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060200E5 RID: 131301 RVA: 0x002FAB5A File Offset: 0x002F8D5A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FUIDropdownComponentDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIDropdownComponentDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIDropdownComponentDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIDropdownComponentDynamicDelegate.OnScriptCallback));
				}
				FUIDropdownComponentDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIDropdownComponentDynamicDelegate.RegisterId);
		}

		// Token: 0x060200E6 RID: 131302 RVA: 0x002FAB94 File Offset: 0x002F8D94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int InSelectIndex)
		{
			FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams* ptr = stackalloc FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIDropdownComponentDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InSelectIndex = InSelectIndex;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060200E7 RID: 131303 RVA: 0x002FABD4 File Offset: 0x002F8DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams*)__Parameters)->InSelectIndex);
		}

		// Token: 0x04011418 RID: 70680
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011419 RID: 70681
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIDropdownComponentDynamicDelegate__DelegateSignature";

		// Token: 0x0401141A RID: 70682
		private static int RegisterId;

		// Token: 0x020034F3 RID: 13555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FUIDropdownComponentDynamicDelegate_DelegateParams
		{
			// Token: 0x04017517 RID: 95511
			[FieldOffset(0)]
			public int InSelectIndex;
		}

		// Token: 0x020034F4 RID: 13556
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017518 RID: 95512
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
