using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200225A RID: 8794
	public sealed class FLTweenVector4SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060216B9 RID: 136889 RVA: 0x0031428A File Offset: 0x0031248A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector4SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x060216BA RID: 136890 RVA: 0x00314296 File Offset: 0x00312496
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector4SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector4SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector4SetterDynamic__DelegateSignature");
			}
			return FLTweenVector4SetterDynamic._FunctionPtr;
		}

		// Token: 0x060216BB RID: 136891 RVA: 0x003142B9 File Offset: 0x003124B9
		public FLTweenVector4SetterDynamic()
		{
		}

		// Token: 0x060216BC RID: 136892 RVA: 0x003142C1 File Offset: 0x003124C1
		[NullableContext(2)]
		public FLTweenVector4SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216BD RID: 136893 RVA: 0x003142CB File Offset: 0x003124CB
		public FLTweenVector4SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216BE RID: 136894 RVA: 0x003142D6 File Offset: 0x003124D6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector4>) ?? ((Action<FVector4>)Delegate.CreateDelegate(typeof(Action<FVector4>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216BF RID: 136895 RVA: 0x00314308 File Offset: 0x00312508
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector4> Callback)
		{
			if (FLTweenVector4SetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenVector4SetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenVector4SetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenVector4SetterDynamic.OnScriptCallback));
				}
				FLTweenVector4SetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenVector4SetterDynamic.RegisterId);
		}

		// Token: 0x060216C0 RID: 136896 RVA: 0x00314344 File Offset: 0x00312544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FVector4 value)
		{
			FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector4SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060216C1 RID: 136897 RVA: 0x00314388 File Offset: 0x00312588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector4> action = target as Action<FVector4>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CF6 RID: 72950
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CF7 RID: 72951
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector4SetterDynamic__DelegateSignature";

		// Token: 0x04011CF8 RID: 72952
		private static int RegisterId;

		// Token: 0x0200351D RID: 13597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLTweenVector4SetterDynamic_DelegateParams
		{
			// Token: 0x0401754F RID: 95567
			[FieldOffset(0)]
			public FVector4 value;
		}

		// Token: 0x0200351E RID: 13598
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017550 RID: 95568
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
