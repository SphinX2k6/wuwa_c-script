using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002252 RID: 8786
	public sealed class FLTweenFloatSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602167A RID: 136826 RVA: 0x0031399A File Offset: 0x00311B9A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenFloatSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0602167B RID: 136827 RVA: 0x003139A6 File Offset: 0x00311BA6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenFloatSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenFloatSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenFloatSetterDynamic__DelegateSignature");
			}
			return FLTweenFloatSetterDynamic._FunctionPtr;
		}

		// Token: 0x0602167C RID: 136828 RVA: 0x003139C9 File Offset: 0x00311BC9
		public FLTweenFloatSetterDynamic()
		{
		}

		// Token: 0x0602167D RID: 136829 RVA: 0x003139D1 File Offset: 0x00311BD1
		[NullableContext(2)]
		public FLTweenFloatSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602167E RID: 136830 RVA: 0x003139DB File Offset: 0x00311BDB
		public FLTweenFloatSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602167F RID: 136831 RVA: 0x003139E6 File Offset: 0x00311BE6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021680 RID: 136832 RVA: 0x00313A18 File Offset: 0x00311C18
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FLTweenFloatSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenFloatSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenFloatSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenFloatSetterDynamic.OnScriptCallback));
				}
				FLTweenFloatSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenFloatSetterDynamic.RegisterId);
		}

		// Token: 0x06021681 RID: 136833 RVA: 0x00313A54 File Offset: 0x00311C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float value)
		{
			FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams* ptr = stackalloc FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenFloatSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06021682 RID: 136834 RVA: 0x00313A94 File Offset: 0x00311C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CDB RID: 72923
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CDC RID: 72924
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenFloatSetterDynamic__DelegateSignature";

		// Token: 0x04011CDD RID: 72925
		private static int RegisterId;

		// Token: 0x0200350F RID: 13583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLTweenFloatSetterDynamic_DelegateParams
		{
			// Token: 0x04017541 RID: 95553
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x02003510 RID: 13584
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017542 RID: 95554
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
