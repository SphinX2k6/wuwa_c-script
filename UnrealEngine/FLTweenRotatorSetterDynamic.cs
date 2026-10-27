using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002257 RID: 8791
	public sealed class FLTweenRotatorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602169E RID: 136862 RVA: 0x00313EB2 File Offset: 0x003120B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenRotatorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0602169F RID: 136863 RVA: 0x00313EBE File Offset: 0x003120BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenRotatorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenRotatorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenRotatorSetterDynamic__DelegateSignature");
			}
			return FLTweenRotatorSetterDynamic._FunctionPtr;
		}

		// Token: 0x060216A0 RID: 136864 RVA: 0x00313EE1 File Offset: 0x003120E1
		public FLTweenRotatorSetterDynamic()
		{
		}

		// Token: 0x060216A1 RID: 136865 RVA: 0x00313EE9 File Offset: 0x003120E9
		[NullableContext(2)]
		public FLTweenRotatorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216A2 RID: 136866 RVA: 0x00313EF3 File Offset: 0x003120F3
		public FLTweenRotatorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216A3 RID: 136867 RVA: 0x00313EFE File Offset: 0x003120FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FRotator>) ?? ((Action<FRotator>)Delegate.CreateDelegate(typeof(Action<FRotator>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216A4 RID: 136868 RVA: 0x00313F30 File Offset: 0x00312130
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FRotator> Callback)
		{
			if (FLTweenRotatorSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenRotatorSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenRotatorSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenRotatorSetterDynamic.OnScriptCallback));
				}
				FLTweenRotatorSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenRotatorSetterDynamic.RegisterId);
		}

		// Token: 0x060216A5 RID: 136869 RVA: 0x00313F6C File Offset: 0x0031216C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FRotator value)
		{
			FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenRotatorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060216A6 RID: 136870 RVA: 0x00313FB0 File Offset: 0x003121B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FRotator> action = target as Action<FRotator>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CED RID: 72941
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CEE RID: 72942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenRotatorSetterDynamic__DelegateSignature";

		// Token: 0x04011CEF RID: 72943
		private static int RegisterId;

		// Token: 0x02003517 RID: 13591
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FLTweenRotatorSetterDynamic_DelegateParams
		{
			// Token: 0x04017549 RID: 95561
			[FieldOffset(0)]
			public FRotator value;
		}

		// Token: 0x02003518 RID: 13592
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401754A RID: 95562
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
