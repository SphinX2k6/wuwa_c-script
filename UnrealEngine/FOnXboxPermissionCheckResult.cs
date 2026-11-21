using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000601 RID: 1537
	public sealed class FOnXboxPermissionCheckResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087E8 RID: 34792 RVA: 0x000CC7EC File Offset: 0x000CA9EC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxPermissionCheckResult.StaticFunctionPtr();
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x000CC7F8 File Offset: 0x000CA9F8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxPermissionCheckResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxPermissionCheckResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxPermissionCheckResult__DelegateSignature");
			}
			return FOnXboxPermissionCheckResult._FunctionPtr;
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x000CC81B File Offset: 0x000CAA1B
		public FOnXboxPermissionCheckResult()
		{
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x000CC823 File Offset: 0x000CAA23
		[NullableContext(2)]
		public FOnXboxPermissionCheckResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x000CC82D File Offset: 0x000CAA2D
		public FOnXboxPermissionCheckResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x000CC838 File Offset: 0x000CAA38
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxPermissionCheckResult>) ?? ((Action<FXboxPermissionCheckResult>)Delegate.CreateDelegate(typeof(Action<FXboxPermissionCheckResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x000CC86A File Offset: 0x000CAA6A
		[NullableContext(1)]
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

		// Token: 0x060087EF RID: 34799 RVA: 0x000CC8A4 File Offset: 0x000CAAA4
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060087F0 RID: 34800 RVA: 0x000CC900 File Offset: 0x000CAB00
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003B0E RID: 15118
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B0F RID: 15119
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxPermissionCheckResult__DelegateSignature";

		// Token: 0x04003B10 RID: 15120
		private static int RegisterId;

		// Token: 0x02000E22 RID: 3618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnXboxPermissionCheckResult_DelegateParams
		{
			// Token: 0x040061B7 RID: 25015
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02000E23 RID: 3619
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061B8 RID: 25016
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
