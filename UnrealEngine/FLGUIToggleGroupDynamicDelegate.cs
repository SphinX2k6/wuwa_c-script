using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020DA RID: 8410
	public sealed class FLGUIToggleGroupDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FAC5 RID: 129733 RVA: 0x002F1B3A File Offset: 0x002EFD3A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIToggleGroupDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FAC6 RID: 129734 RVA: 0x002F1B46 File Offset: 0x002EFD46
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIToggleGroupDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIToggleGroupDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIToggleGroupDynamicDelegate__DelegateSignature");
			}
			return FLGUIToggleGroupDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601FAC7 RID: 129735 RVA: 0x002F1B69 File Offset: 0x002EFD69
		public FLGUIToggleGroupDynamicDelegate()
		{
		}

		// Token: 0x0601FAC8 RID: 129736 RVA: 0x002F1B71 File Offset: 0x002EFD71
		[NullableContext(2)]
		public FLGUIToggleGroupDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FAC9 RID: 129737 RVA: 0x002F1B7B File Offset: 0x002EFD7B
		public FLGUIToggleGroupDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FACA RID: 129738 RVA: 0x002F1B86 File Offset: 0x002EFD86
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FACB RID: 129739 RVA: 0x002F1BB8 File Offset: 0x002EFDB8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FLGUIToggleGroupDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIToggleGroupDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIToggleGroupDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIToggleGroupDynamicDelegate.OnScriptCallback));
				}
				FLGUIToggleGroupDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIToggleGroupDynamicDelegate.RegisterId);
		}

		// Token: 0x0601FACC RID: 129740 RVA: 0x002F1BF4 File Offset: 0x002EFDF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Index)
		{
			FLGUIToggleGroupDynamicDelegate.__FLGUIToggleGroupDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIToggleGroupDynamicDelegate.__FLGUIToggleGroupDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIToggleGroupDynamicDelegate.__FLGUIToggleGroupDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIToggleGroupDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FACD RID: 129741 RVA: 0x002F1C34 File Offset: 0x002EFE34
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
			action(((FLGUIToggleGroupDynamicDelegate.__FLGUIToggleGroupDynamicDelegate_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x0401116E RID: 69998
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401116F RID: 69999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIToggleGroupDynamicDelegate__DelegateSignature";

		// Token: 0x04011170 RID: 70000
		private static int RegisterId;

		// Token: 0x020034CE RID: 13518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIToggleGroupDynamicDelegate_DelegateParams
		{
			// Token: 0x040174D9 RID: 95449
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x020034CF RID: 13519
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174DA RID: 95450
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
