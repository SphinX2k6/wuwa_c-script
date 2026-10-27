using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF6 RID: 7926
	public sealed class FOnXboxUserStoreIdResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1AF RID: 123311 RVA: 0x002CBAC8 File Offset: 0x002C9CC8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxUserStoreIdResult.StaticFunctionPtr();
		}

		// Token: 0x0601E1B0 RID: 123312 RVA: 0x002CBAD4 File Offset: 0x002C9CD4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxUserStoreIdResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxUserStoreIdResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxUserStoreIdResult__DelegateSignature");
			}
			return FOnXboxUserStoreIdResult._FunctionPtr;
		}

		// Token: 0x0601E1B1 RID: 123313 RVA: 0x002CBAF7 File Offset: 0x002C9CF7
		public FOnXboxUserStoreIdResult()
		{
		}

		// Token: 0x0601E1B2 RID: 123314 RVA: 0x002CBAFF File Offset: 0x002C9CFF
		[NullableContext(2)]
		public FOnXboxUserStoreIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1B3 RID: 123315 RVA: 0x002CBB09 File Offset: 0x002C9D09
		public FOnXboxUserStoreIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1B4 RID: 123316 RVA: 0x002CBB14 File Offset: 0x002C9D14
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxUserStoreIdResult>) ?? ((Action<FXboxUserStoreIdResult>)Delegate.CreateDelegate(typeof(Action<FXboxUserStoreIdResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1B5 RID: 123317 RVA: 0x002CBB46 File Offset: 0x002C9D46
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FXboxUserStoreIdResult> Callback)
		{
			if (FOnXboxUserStoreIdResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxUserStoreIdResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxUserStoreIdResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxUserStoreIdResult.OnScriptCallback));
				}
				FOnXboxUserStoreIdResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxUserStoreIdResult.RegisterId);
		}

		// Token: 0x0601E1B6 RID: 123318 RVA: 0x002CBB80 File Offset: 0x002C9D80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FXboxUserStoreIdResult Result)
		{
			FOnXboxUserStoreIdResult.__FOnXboxUserStoreIdResult_DelegateParams* ptr = stackalloc FOnXboxUserStoreIdResult.__FOnXboxUserStoreIdResult_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnXboxUserStoreIdResult.__FOnXboxUserStoreIdResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxUserStoreIdResult.StaticFunctionPtr(), (void*)ptr, 1);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXboxUserStoreIdResult.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnXboxUserStoreIdResult._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E1B7 RID: 123319 RVA: 0x002CBBEC File Offset: 0x002C9DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FXboxUserStoreIdResult> action = target as Action<FXboxUserStoreIdResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FXboxUserStoreIdResult obj = new FXboxUserStoreIdResult(&((FOnXboxUserStoreIdResult.__FOnXboxUserStoreIdResult_DelegateParams*)__Parameters)->Result, true, true);
			action(obj);
		}

		// Token: 0x0401043C RID: 66620
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401043D RID: 66621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxUserStoreIdResult__DelegateSignature";

		// Token: 0x0401043E RID: 66622
		private static int RegisterId;

		// Token: 0x020033D9 RID: 13273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnXboxUserStoreIdResult_DelegateParams
		{
			// Token: 0x0401738E RID: 95118
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x020033DA RID: 13274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401738F RID: 95119
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
