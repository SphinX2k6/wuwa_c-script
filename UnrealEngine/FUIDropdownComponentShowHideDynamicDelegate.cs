using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213F RID: 8511
	public sealed class FUIDropdownComponentShowHideDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060200E8 RID: 131304 RVA: 0x002FAC1E File Offset: 0x002F8E1E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIDropdownComponentShowHideDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060200E9 RID: 131305 RVA: 0x002FAC2A File Offset: 0x002F8E2A
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIDropdownComponentShowHideDynamicDelegate__DelegateSignature");
			}
			return FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060200EA RID: 131306 RVA: 0x002FAC4D File Offset: 0x002F8E4D
		public FUIDropdownComponentShowHideDynamicDelegate()
		{
		}

		// Token: 0x060200EB RID: 131307 RVA: 0x002FAC55 File Offset: 0x002F8E55
		[NullableContext(2)]
		public FUIDropdownComponentShowHideDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060200EC RID: 131308 RVA: 0x002FAC5F File Offset: 0x002F8E5F
		public FUIDropdownComponentShowHideDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060200ED RID: 131309 RVA: 0x002FAC6A File Offset: 0x002F8E6A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060200EE RID: 131310 RVA: 0x002FAC9C File Offset: 0x002F8E9C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FUIDropdownComponentShowHideDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIDropdownComponentShowHideDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIDropdownComponentShowHideDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIDropdownComponentShowHideDynamicDelegate.OnScriptCallback));
				}
				FUIDropdownComponentShowHideDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIDropdownComponentShowHideDynamicDelegate.RegisterId);
		}

		// Token: 0x060200EF RID: 131311 RVA: 0x002FACD8 File Offset: 0x002F8ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool IsShow)
		{
			FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams* ptr = stackalloc FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIDropdownComponentShowHideDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsShow = IsShow;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060200F0 RID: 131312 RVA: 0x002FAD18 File Offset: 0x002F8F18
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
			action(((FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams*)__Parameters)->IsShow);
		}

		// Token: 0x0401141B RID: 70683
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401141C RID: 70684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIDropdownComponentShowHideDynamicDelegate__DelegateSignature";

		// Token: 0x0401141D RID: 70685
		private static int RegisterId;

		// Token: 0x020034F5 RID: 13557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FUIDropdownComponentShowHideDynamicDelegate_DelegateParams
		{
			// Token: 0x04017519 RID: 95513
			[FieldOffset(0)]
			public bool IsShow;
		}

		// Token: 0x020034F6 RID: 13558
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401751A RID: 95514
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
