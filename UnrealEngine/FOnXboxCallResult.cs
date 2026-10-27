using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF2 RID: 7922
	public sealed class FOnXboxCallResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E18B RID: 123275 RVA: 0x002CB52C File Offset: 0x002C972C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxCallResult.StaticFunctionPtr();
		}

		// Token: 0x0601E18C RID: 123276 RVA: 0x002CB538 File Offset: 0x002C9738
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxCallResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxCallResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxCallResult__DelegateSignature");
			}
			return FOnXboxCallResult._FunctionPtr;
		}

		// Token: 0x0601E18D RID: 123277 RVA: 0x002CB55B File Offset: 0x002C975B
		public FOnXboxCallResult()
		{
		}

		// Token: 0x0601E18E RID: 123278 RVA: 0x002CB563 File Offset: 0x002C9763
		[NullableContext(2)]
		public FOnXboxCallResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E18F RID: 123279 RVA: 0x002CB56D File Offset: 0x002C976D
		public FOnXboxCallResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E190 RID: 123280 RVA: 0x002CB578 File Offset: 0x002C9778
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E191 RID: 123281 RVA: 0x002CB5AA File Offset: 0x002C97AA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnXboxCallResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxCallResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxCallResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxCallResult.OnScriptCallback));
				}
				FOnXboxCallResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxCallResult.RegisterId);
		}

		// Token: 0x0601E192 RID: 123282 RVA: 0x002CB5E4 File Offset: 0x002C97E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bSuccess)
		{
			FOnXboxCallResult.__FOnXboxCallResult_DelegateParams* ptr = stackalloc FOnXboxCallResult.__FOnXboxCallResult_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnXboxCallResult.__FOnXboxCallResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxCallResult.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E193 RID: 123283 RVA: 0x002CB624 File Offset: 0x002C9824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnXboxCallResult.__FOnXboxCallResult_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x04010430 RID: 66608
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010431 RID: 66609
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxCallResult__DelegateSignature";

		// Token: 0x04010432 RID: 66610
		private static int RegisterId;

		// Token: 0x020033D1 RID: 13265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnXboxCallResult_DelegateParams
		{
			// Token: 0x04017386 RID: 95110
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x020033D2 RID: 13266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017387 RID: 95111
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
