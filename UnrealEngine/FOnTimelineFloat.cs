using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F30 RID: 3888
	public sealed class FOnTimelineFloat : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1BB RID: 53691 RVA: 0x001334EE File Offset: 0x001316EE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimelineFloat.StaticFunctionPtr();
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x001334FA File Offset: 0x001316FA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimelineFloat._FunctionPtr == IntPtr.Zero)
			{
				FOnTimelineFloat._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnTimelineFloat__DelegateSignature");
			}
			return FOnTimelineFloat._FunctionPtr;
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x0013351D File Offset: 0x0013171D
		public FOnTimelineFloat()
		{
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x00133525 File Offset: 0x00131725
		[NullableContext(2)]
		public FOnTimelineFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1BF RID: 53695 RVA: 0x0013352F File Offset: 0x0013172F
		public FOnTimelineFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1C0 RID: 53696 RVA: 0x0013353A File Offset: 0x0013173A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x0013356C File Offset: 0x0013176C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FOnTimelineFloat.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTimelineFloat.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTimelineFloat.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTimelineFloat.OnScriptCallback));
				}
				FOnTimelineFloat.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTimelineFloat.RegisterId);
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x001335A8 File Offset: 0x001317A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float Output)
		{
			FOnTimelineFloat.__FOnTimelineFloat_DelegateParams* ptr = stackalloc FOnTimelineFloat.__FOnTimelineFloat_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnTimelineFloat.__FOnTimelineFloat_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTimelineFloat.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Output = Output;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x001335E8 File Offset: 0x001317E8
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
			action(((FOnTimelineFloat.__FOnTimelineFloat_DelegateParams*)__Parameters)->Output);
		}

		// Token: 0x0400709B RID: 28827
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400709C RID: 28828
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnTimelineFloat__DelegateSignature";

		// Token: 0x0400709D RID: 28829
		private static int RegisterId;

		// Token: 0x02002DAC RID: 11692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnTimelineFloat_DelegateParams
		{
			// Token: 0x040167D1 RID: 92113
			[FieldOffset(0)]
			public float Output;
		}

		// Token: 0x02002DAD RID: 11693
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D2 RID: 92114
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
