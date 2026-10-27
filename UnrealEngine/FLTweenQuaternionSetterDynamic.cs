using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002256 RID: 8790
	public sealed class FLTweenQuaternionSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021695 RID: 136853 RVA: 0x00313D6A File Offset: 0x00311F6A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenQuaternionSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x06021696 RID: 136854 RVA: 0x00313D76 File Offset: 0x00311F76
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenQuaternionSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenQuaternionSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenQuaternionSetterDynamic__DelegateSignature");
			}
			return FLTweenQuaternionSetterDynamic._FunctionPtr;
		}

		// Token: 0x06021697 RID: 136855 RVA: 0x00313D99 File Offset: 0x00311F99
		public FLTweenQuaternionSetterDynamic()
		{
		}

		// Token: 0x06021698 RID: 136856 RVA: 0x00313DA1 File Offset: 0x00311FA1
		[NullableContext(2)]
		public FLTweenQuaternionSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021699 RID: 136857 RVA: 0x00313DAB File Offset: 0x00311FAB
		public FLTweenQuaternionSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602169A RID: 136858 RVA: 0x00313DB6 File Offset: 0x00311FB6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FQuat>) ?? ((Action<FQuat>)Delegate.CreateDelegate(typeof(Action<FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602169B RID: 136859 RVA: 0x00313DE8 File Offset: 0x00311FE8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FQuat> Callback)
		{
			if (FLTweenQuaternionSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenQuaternionSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenQuaternionSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenQuaternionSetterDynamic.OnScriptCallback));
				}
				FLTweenQuaternionSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenQuaternionSetterDynamic.RegisterId);
		}

		// Token: 0x0602169C RID: 136860 RVA: 0x00313E24 File Offset: 0x00312024
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FQuat value)
		{
			FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams* ptr = stackalloc FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenQuaternionSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0602169D RID: 136861 RVA: 0x00313E68 File Offset: 0x00312068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FQuat> action = target as Action<FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CEA RID: 72938
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CEB RID: 72939
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenQuaternionSetterDynamic__DelegateSignature";

		// Token: 0x04011CEC RID: 72940
		private static int RegisterId;

		// Token: 0x02003515 RID: 13589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLTweenQuaternionSetterDynamic_DelegateParams
		{
			// Token: 0x04017547 RID: 95559
			[FieldOffset(0)]
			public FQuat value;
		}

		// Token: 0x02003516 RID: 13590
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017548 RID: 95560
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
