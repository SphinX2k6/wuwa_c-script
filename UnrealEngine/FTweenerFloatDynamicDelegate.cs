using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200225B RID: 8795
	public sealed class FTweenerFloatDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060216C2 RID: 136898 RVA: 0x003143D2 File Offset: 0x003125D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTweenerFloatDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060216C3 RID: 136899 RVA: 0x003143DE File Offset: 0x003125DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FTweenerFloatDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTweenerFloatDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.TweenerFloatDynamicDelegate__DelegateSignature");
			}
			return FTweenerFloatDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060216C4 RID: 136900 RVA: 0x00314401 File Offset: 0x00312601
		public FTweenerFloatDynamicDelegate()
		{
		}

		// Token: 0x060216C5 RID: 136901 RVA: 0x00314409 File Offset: 0x00312609
		[NullableContext(2)]
		public FTweenerFloatDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216C6 RID: 136902 RVA: 0x00314413 File Offset: 0x00312613
		public FTweenerFloatDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216C7 RID: 136903 RVA: 0x0031441E File Offset: 0x0031261E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216C8 RID: 136904 RVA: 0x00314450 File Offset: 0x00312650
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FTweenerFloatDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTweenerFloatDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTweenerFloatDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTweenerFloatDynamicDelegate.OnScriptCallback));
				}
				FTweenerFloatDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTweenerFloatDynamicDelegate.RegisterId);
		}

		// Token: 0x060216C9 RID: 136905 RVA: 0x0031448C File Offset: 0x0031268C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float InProgress)
		{
			FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams* ptr = stackalloc FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTweenerFloatDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InProgress = InProgress;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060216CA RID: 136906 RVA: 0x003144CC File Offset: 0x003126CC
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
			action(((FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams*)__Parameters)->InProgress);
		}

		// Token: 0x04011CF9 RID: 72953
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CFA RID: 72954
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.TweenerFloatDynamicDelegate__DelegateSignature";

		// Token: 0x04011CFB RID: 72955
		private static int RegisterId;

		// Token: 0x0200351F RID: 13599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FTweenerFloatDynamicDelegate_DelegateParams
		{
			// Token: 0x04017551 RID: 95569
			[FieldOffset(0)]
			public float InProgress;
		}

		// Token: 0x02003520 RID: 13600
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017552 RID: 95570
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
