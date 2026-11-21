using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000602 RID: 1538
	public sealed class FOnXboxTokenAndSignatureResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087F1 RID: 34801 RVA: 0x000CC954 File Offset: 0x000CAB54
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxTokenAndSignatureResult.StaticFunctionPtr();
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x000CC960 File Offset: 0x000CAB60
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxTokenAndSignatureResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxTokenAndSignatureResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxTokenAndSignatureResult__DelegateSignature");
			}
			return FOnXboxTokenAndSignatureResult._FunctionPtr;
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x000CC983 File Offset: 0x000CAB83
		public FOnXboxTokenAndSignatureResult()
		{
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x000CC98B File Offset: 0x000CAB8B
		[NullableContext(2)]
		public FOnXboxTokenAndSignatureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x000CC995 File Offset: 0x000CAB95
		public FOnXboxTokenAndSignatureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x000CC9A0 File Offset: 0x000CABA0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxTokenAndSignatureResult>) ?? ((Action<FXboxTokenAndSignatureResult>)Delegate.CreateDelegate(typeof(Action<FXboxTokenAndSignatureResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x000CC9D2 File Offset: 0x000CABD2
		[NullableContext(1)]
		public void Bind(Action<FXboxTokenAndSignatureResult> Callback)
		{
			if (FOnXboxTokenAndSignatureResult.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnXboxTokenAndSignatureResult.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnXboxTokenAndSignatureResult.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnXboxTokenAndSignatureResult.OnScriptCallback));
				}
				FOnXboxTokenAndSignatureResult.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnXboxTokenAndSignatureResult.RegisterId);
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x000CCA0C File Offset: 0x000CAC0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(in FXboxTokenAndSignatureResult Result)
		{
			FOnXboxTokenAndSignatureResult.__FOnXboxTokenAndSignatureResult_DelegateParams* ptr = stackalloc FOnXboxTokenAndSignatureResult.__FOnXboxTokenAndSignatureResult_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FOnXboxTokenAndSignatureResult.__FOnXboxTokenAndSignatureResult_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnXboxTokenAndSignatureResult.StaticFunctionPtr(), (void*)ptr, 1);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXboxTokenAndSignatureResult.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnXboxTokenAndSignatureResult._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x000CCA78 File Offset: 0x000CAC78
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FXboxTokenAndSignatureResult> action = target as Action<FXboxTokenAndSignatureResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FXboxTokenAndSignatureResult obj = new FXboxTokenAndSignatureResult(&((FOnXboxTokenAndSignatureResult.__FOnXboxTokenAndSignatureResult_DelegateParams*)__Parameters)->Result, true, true);
			action(obj);
		}

		// Token: 0x04003B11 RID: 15121
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B12 RID: 15122
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxTokenAndSignatureResult__DelegateSignature";

		// Token: 0x04003B13 RID: 15123
		private static int RegisterId;

		// Token: 0x02000E24 RID: 3620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FOnXboxTokenAndSignatureResult_DelegateParams
		{
			// Token: 0x040061B9 RID: 25017
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02000E25 RID: 3621
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061BA RID: 25018
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
