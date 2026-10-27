using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002254 RID: 8788
	public sealed class FLTweenLinearColorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602168C RID: 136844 RVA: 0x00313C22 File Offset: 0x00311E22
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenLinearColorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0602168D RID: 136845 RVA: 0x00313C2E File Offset: 0x00311E2E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenLinearColorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenLinearColorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenLinearColorSetterDynamic__DelegateSignature");
			}
			return FLTweenLinearColorSetterDynamic._FunctionPtr;
		}

		// Token: 0x0602168E RID: 136846 RVA: 0x00313C51 File Offset: 0x00311E51
		public FLTweenLinearColorSetterDynamic()
		{
		}

		// Token: 0x0602168F RID: 136847 RVA: 0x00313C59 File Offset: 0x00311E59
		[NullableContext(2)]
		public FLTweenLinearColorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021690 RID: 136848 RVA: 0x00313C63 File Offset: 0x00311E63
		public FLTweenLinearColorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021691 RID: 136849 RVA: 0x00313C6E File Offset: 0x00311E6E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FLinearColor>) ?? ((Action<FLinearColor>)Delegate.CreateDelegate(typeof(Action<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021692 RID: 136850 RVA: 0x00313CA0 File Offset: 0x00311EA0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FLinearColor> Callback)
		{
			if (FLTweenLinearColorSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenLinearColorSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenLinearColorSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenLinearColorSetterDynamic.OnScriptCallback));
				}
				FLTweenLinearColorSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenLinearColorSetterDynamic.RegisterId);
		}

		// Token: 0x06021693 RID: 136851 RVA: 0x00313CDC File Offset: 0x00311EDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FLinearColor value)
		{
			FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenLinearColorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06021694 RID: 136852 RVA: 0x00313D20 File Offset: 0x00311F20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLinearColor> action = target as Action<FLinearColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CE1 RID: 72929
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CE2 RID: 72930
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenLinearColorSetterDynamic__DelegateSignature";

		// Token: 0x04011CE3 RID: 72931
		private static int RegisterId;

		// Token: 0x02003513 RID: 13587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLTweenLinearColorSetterDynamic_DelegateParams
		{
			// Token: 0x04017545 RID: 95557
			[FieldOffset(0)]
			public FLinearColor value;
		}

		// Token: 0x02003514 RID: 13588
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017546 RID: 95558
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
