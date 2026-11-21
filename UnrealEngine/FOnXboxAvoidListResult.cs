using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005FE RID: 1534
	public sealed class FOnXboxAvoidListResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087CD RID: 34765 RVA: 0x000CC3B6 File Offset: 0x000CA5B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxAvoidListResult.StaticFunctionPtr();
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x000CC3C2 File Offset: 0x000CA5C2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxAvoidListResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxAvoidListResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxAvoidListResult__DelegateSignature");
			}
			return FOnXboxAvoidListResult._FunctionPtr;
		}

		// Token: 0x060087CF RID: 34767 RVA: 0x000CC3E5 File Offset: 0x000CA5E5
		public FOnXboxAvoidListResult()
		{
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x000CC3ED File Offset: 0x000CA5ED
		[NullableContext(2)]
		public FOnXboxAvoidListResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x000CC3F7 File Offset: 0x000CA5F7
		public FOnXboxAvoidListResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x000CC402 File Offset: 0x000CA602
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxAvoidListResult>) ?? ((Action<FXboxAvoidListResult>)Delegate.CreateDelegate(typeof(Action<FXboxAvoidListResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x000CC434 File Offset: 0x000CA634
		[NullableContext(1)]
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

		// Token: 0x060087D4 RID: 34772 RVA: 0x000CC470 File Offset: 0x000CA670
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060087D5 RID: 34773 RVA: 0x000CC4DC File Offset: 0x000CA6DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003B05 RID: 15109
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B06 RID: 15110
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxAvoidListResult__DelegateSignature";

		// Token: 0x04003B07 RID: 15111
		private static int RegisterId;

		// Token: 0x02000E1C RID: 3612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnXboxAvoidListResult_DelegateParams
		{
			// Token: 0x040061B1 RID: 25009
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02000E1D RID: 3613
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061B2 RID: 25010
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
