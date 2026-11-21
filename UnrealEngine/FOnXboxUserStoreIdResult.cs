using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000603 RID: 1539
	public sealed class FOnXboxUserStoreIdResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087FA RID: 34810 RVA: 0x000CCACC File Offset: 0x000CACCC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxUserStoreIdResult.StaticFunctionPtr();
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x000CCAD8 File Offset: 0x000CACD8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxUserStoreIdResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxUserStoreIdResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxUserStoreIdResult__DelegateSignature");
			}
			return FOnXboxUserStoreIdResult._FunctionPtr;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x000CCAFB File Offset: 0x000CACFB
		public FOnXboxUserStoreIdResult()
		{
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x000CCB03 File Offset: 0x000CAD03
		[NullableContext(2)]
		public FOnXboxUserStoreIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x000CCB0D File Offset: 0x000CAD0D
		public FOnXboxUserStoreIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x000CCB18 File Offset: 0x000CAD18
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxUserStoreIdResult>) ?? ((Action<FXboxUserStoreIdResult>)Delegate.CreateDelegate(typeof(Action<FXboxUserStoreIdResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x000CCB4A File Offset: 0x000CAD4A
		[NullableContext(1)]
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

		// Token: 0x06008801 RID: 34817 RVA: 0x000CCB84 File Offset: 0x000CAD84
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06008802 RID: 34818 RVA: 0x000CCBF0 File Offset: 0x000CADF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003B14 RID: 15124
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B15 RID: 15125
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxUserStoreIdResult__DelegateSignature";

		// Token: 0x04003B16 RID: 15126
		private static int RegisterId;

		// Token: 0x02000E26 RID: 3622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnXboxUserStoreIdResult_DelegateParams
		{
			// Token: 0x040061BB RID: 25019
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02000E27 RID: 3623
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061BC RID: 25020
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
