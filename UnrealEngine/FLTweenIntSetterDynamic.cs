using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002253 RID: 8787
	public sealed class FLTweenIntSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021683 RID: 136835 RVA: 0x00313ADE File Offset: 0x00311CDE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenIntSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x06021684 RID: 136836 RVA: 0x00313AEA File Offset: 0x00311CEA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenIntSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenIntSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenIntSetterDynamic__DelegateSignature");
			}
			return FLTweenIntSetterDynamic._FunctionPtr;
		}

		// Token: 0x06021685 RID: 136837 RVA: 0x00313B0D File Offset: 0x00311D0D
		public FLTweenIntSetterDynamic()
		{
		}

		// Token: 0x06021686 RID: 136838 RVA: 0x00313B15 File Offset: 0x00311D15
		[NullableContext(2)]
		public FLTweenIntSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021687 RID: 136839 RVA: 0x00313B1F File Offset: 0x00311D1F
		public FLTweenIntSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021688 RID: 136840 RVA: 0x00313B2A File Offset: 0x00311D2A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021689 RID: 136841 RVA: 0x00313B5C File Offset: 0x00311D5C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FLTweenIntSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenIntSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenIntSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenIntSetterDynamic.OnScriptCallback));
				}
				FLTweenIntSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenIntSetterDynamic.RegisterId);
		}

		// Token: 0x0602168A RID: 136842 RVA: 0x00313B98 File Offset: 0x00311D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int value)
		{
			FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams* ptr = stackalloc FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenIntSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0602168B RID: 136843 RVA: 0x00313BD8 File Offset: 0x00311DD8
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
			action(((FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CDE RID: 72926
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CDF RID: 72927
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenIntSetterDynamic__DelegateSignature";

		// Token: 0x04011CE0 RID: 72928
		private static int RegisterId;

		// Token: 0x02003511 RID: 13585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLTweenIntSetterDynamic_DelegateParams
		{
			// Token: 0x04017543 RID: 95555
			[FieldOffset(0)]
			public int value;
		}

		// Token: 0x02003512 RID: 13586
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017544 RID: 95556
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
