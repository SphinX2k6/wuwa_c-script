using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002258 RID: 8792
	public sealed class FLTweenVector2SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060216A7 RID: 136871 RVA: 0x00313FFA File Offset: 0x003121FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector2SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x060216A8 RID: 136872 RVA: 0x00314006 File Offset: 0x00312206
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector2SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector2SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector2SetterDynamic__DelegateSignature");
			}
			return FLTweenVector2SetterDynamic._FunctionPtr;
		}

		// Token: 0x060216A9 RID: 136873 RVA: 0x00314029 File Offset: 0x00312229
		public FLTweenVector2SetterDynamic()
		{
		}

		// Token: 0x060216AA RID: 136874 RVA: 0x00314031 File Offset: 0x00312231
		[NullableContext(2)]
		public FLTweenVector2SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216AB RID: 136875 RVA: 0x0031403B File Offset: 0x0031223B
		public FLTweenVector2SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216AC RID: 136876 RVA: 0x00314046 File Offset: 0x00312246
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216AD RID: 136877 RVA: 0x00314078 File Offset: 0x00312278
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector2D> Callback)
		{
			if (FLTweenVector2SetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenVector2SetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenVector2SetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenVector2SetterDynamic.OnScriptCallback));
				}
				FLTweenVector2SetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenVector2SetterDynamic.RegisterId);
		}

		// Token: 0x060216AE RID: 136878 RVA: 0x003140B4 File Offset: 0x003122B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FVector2D value)
		{
			FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector2SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060216AF RID: 136879 RVA: 0x003140F8 File Offset: 0x003122F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CF0 RID: 72944
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CF1 RID: 72945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector2SetterDynamic__DelegateSignature";

		// Token: 0x04011CF2 RID: 72946
		private static int RegisterId;

		// Token: 0x02003519 RID: 13593
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLTweenVector2SetterDynamic_DelegateParams
		{
			// Token: 0x0401754B RID: 95563
			[FieldOffset(0)]
			public FVector2D value;
		}

		// Token: 0x0200351A RID: 13594
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401754C RID: 95564
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
