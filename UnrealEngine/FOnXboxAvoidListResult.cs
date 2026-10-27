using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF1 RID: 7921
	public sealed class FOnXboxAvoidListResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E182 RID: 123266 RVA: 0x002CB3B2 File Offset: 0x002C95B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAvoidListResult.StaticFunctionPtr();
		}

		// Token: 0x0601E183 RID: 123267 RVA: 0x002CB3BE File Offset: 0x002C95BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAvoidListResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAvoidListResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAvoidListResult__DelegateSignature");
			}
			return FOnXboxAvoidListResult._FunctionPtr;
		}

		// Token: 0x0601E184 RID: 123268 RVA: 0x002CB3E1 File Offset: 0x002C95E1
		public FOnXboxAvoidListResult()
		{
		}

		// Token: 0x0601E185 RID: 123269 RVA: 0x002CB3E9 File Offset: 0x002C95E9
		[NullableContext(2)]
		public FOnXboxAvoidListResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E186 RID: 123270 RVA: 0x002CB3F3 File Offset: 0x002C95F3
		public FOnXboxAvoidListResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E187 RID: 123271 RVA: 0x002CB3FE File Offset: 0x002C95FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxAvoidListResult>) ?? ((Action<FXboxAvoidListResult>)Delegate.CreateDelegate(typeof(Action<FXboxAvoidListResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E188 RID: 123272 RVA: 0x002CB430 File Offset: 0x002C9630
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FXboxAvoidListResult> Callback)
		{
			if (FOnXboxAvoidListResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxAvoidListResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxAvoidListResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxAvoidListResult.OnScriptCallback));
				}
				FOnXboxAvoidListResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxAvoidListResult.RegisterId);
		}

		// Token: 0x0601E189 RID: 123273 RVA: 0x002CB46C File Offset: 0x002C966C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FXboxAvoidListResult Result)
		{
			FOnXboxAvoidListResult.__FOnXboxAvoidListResult_DelegateParams* ptr = stackalloc FOnXboxAvoidListResult.__FOnXboxAvoidListResult_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnXboxAvoidListResult.__FOnXboxAvoidListResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxAvoidListResult.StaticFunctionPtr(), (void*)ptr, 1);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXboxAvoidListResult.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnXboxAvoidListResult._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E18A RID: 123274 RVA: 0x002CB4D8 File Offset: 0x002C96D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FXboxAvoidListResult> action = target as Action<FXboxAvoidListResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FXboxAvoidListResult obj = new FXboxAvoidListResult(&((FOnXboxAvoidListResult.__FOnXboxAvoidListResult_DelegateParams*)__Parameters)->Result, true, true);
			action(obj);
		}

		// Token: 0x0401042D RID: 66605
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401042E RID: 66606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAvoidListResult__DelegateSignature";

		// Token: 0x0401042F RID: 66607
		private static int RegisterId;

		// Token: 0x020033CF RID: 13263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnXboxAvoidListResult_DelegateParams
		{
			// Token: 0x04017384 RID: 95108
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x020033D0 RID: 13264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017385 RID: 95109
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
