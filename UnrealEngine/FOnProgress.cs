using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EEB RID: 7915
	public sealed class FOnProgress : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E14C RID: 123212 RVA: 0x002CAADF File Offset: 0x002C8CDF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProgress.StaticFunctionPtr();
		}

		// Token: 0x0601E14D RID: 123213 RVA: 0x002CAAEB File Offset: 0x002C8CEB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProgress._FunctionPtr == IntPtr.Zero)
			{
				FOnProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnProgress__DelegateSignature");
			}
			return FOnProgress._FunctionPtr;
		}

		// Token: 0x0601E14E RID: 123214 RVA: 0x002CAB0E File Offset: 0x002C8D0E
		public FOnProgress()
		{
		}

		// Token: 0x0601E14F RID: 123215 RVA: 0x002CAB16 File Offset: 0x002C8D16
		[NullableContext(2)]
		public FOnProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E150 RID: 123216 RVA: 0x002CAB20 File Offset: 0x002C8D20
		public FOnProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E151 RID: 123217 RVA: 0x002CAB2B File Offset: 0x002C8D2B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E152 RID: 123218 RVA: 0x002CAB5D File Offset: 0x002C8D5D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, float> Callback)
		{
			if (FOnProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProgress.OnScriptCallback));
				}
				FOnProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnProgress.RegisterId);
		}

		// Token: 0x0601E153 RID: 123219 RVA: 0x002CAB98 File Offset: 0x002C8D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int State, float Rate)
		{
			FOnProgress.__FOnProgress_DelegateParams* ptr = stackalloc FOnProgress.__FOnProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnProgress.__FOnProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->Rate = Rate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E154 RID: 123220 RVA: 0x002CABDC File Offset: 0x002C8DDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnProgress.__FOnProgress_DelegateParams*)__Parameters)->State, ((FOnProgress.__FOnProgress_DelegateParams*)__Parameters)->Rate);
		}

		// Token: 0x0401041B RID: 66587
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401041C RID: 66588
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnProgress__DelegateSignature";

		// Token: 0x0401041D RID: 66589
		private static int RegisterId;

		// Token: 0x020033C1 RID: 13249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnProgress_DelegateParams
		{
			// Token: 0x04017375 RID: 95093
			[FieldOffset(0)]
			public int State;

			// Token: 0x04017376 RID: 95094
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x020033C2 RID: 13250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017377 RID: 95095
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
