using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF4 RID: 7924
	public sealed class FOnXboxPermissionCheckResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E19D RID: 123293 RVA: 0x002CB7E8 File Offset: 0x002C99E8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxPermissionCheckResult.StaticFunctionPtr();
		}

		// Token: 0x0601E19E RID: 123294 RVA: 0x002CB7F4 File Offset: 0x002C99F4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxPermissionCheckResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxPermissionCheckResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxPermissionCheckResult__DelegateSignature");
			}
			return FOnXboxPermissionCheckResult._FunctionPtr;
		}

		// Token: 0x0601E19F RID: 123295 RVA: 0x002CB817 File Offset: 0x002C9A17
		public FOnXboxPermissionCheckResult()
		{
		}

		// Token: 0x0601E1A0 RID: 123296 RVA: 0x002CB81F File Offset: 0x002C9A1F
		[NullableContext(2)]
		public FOnXboxPermissionCheckResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1A1 RID: 123297 RVA: 0x002CB829 File Offset: 0x002C9A29
		public FOnXboxPermissionCheckResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1A2 RID: 123298 RVA: 0x002CB834 File Offset: 0x002C9A34
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxPermissionCheckResult>) ?? ((Action<FXboxPermissionCheckResult>)Delegate.CreateDelegate(typeof(Action<FXboxPermissionCheckResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1A3 RID: 123299 RVA: 0x002CB866 File Offset: 0x002C9A66
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FXboxPermissionCheckResult> Callback)
		{
			if (FOnXboxPermissionCheckResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxPermissionCheckResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxPermissionCheckResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxPermissionCheckResult.OnScriptCallback));
				}
				FOnXboxPermissionCheckResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxPermissionCheckResult.RegisterId);
		}

		// Token: 0x0601E1A4 RID: 123300 RVA: 0x002CB8A0 File Offset: 0x002C9AA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FXboxPermissionCheckResult Result)
		{
			FOnXboxPermissionCheckResult.__FOnXboxPermissionCheckResult_DelegateParams* ptr = stackalloc FOnXboxPermissionCheckResult.__FOnXboxPermissionCheckResult_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnXboxPermissionCheckResult.__FOnXboxPermissionCheckResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxPermissionCheckResult.StaticFunctionPtr(), (void*)ptr, 1);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXboxPermissionCheckResult.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E1A5 RID: 123301 RVA: 0x002CB8FC File Offset: 0x002C9AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FXboxPermissionCheckResult> action = target as Action<FXboxPermissionCheckResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FXboxPermissionCheckResult obj = new FXboxPermissionCheckResult(&((FOnXboxPermissionCheckResult.__FOnXboxPermissionCheckResult_DelegateParams*)__Parameters)->Result, true, true);
			action(obj);
		}

		// Token: 0x04010436 RID: 66614
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010437 RID: 66615
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxPermissionCheckResult__DelegateSignature";

		// Token: 0x04010438 RID: 66616
		private static int RegisterId;

		// Token: 0x020033D5 RID: 13269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnXboxPermissionCheckResult_DelegateParams
		{
			// Token: 0x0401738A RID: 95114
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x020033D6 RID: 13270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401738B RID: 95115
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
