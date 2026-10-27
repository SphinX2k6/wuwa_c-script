using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF5 RID: 7925
	public sealed class FOnXboxTokenAndSignatureResult : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E1A6 RID: 123302 RVA: 0x002CB950 File Offset: 0x002C9B50
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnXboxTokenAndSignatureResult.StaticFunctionPtr();
		}

		// Token: 0x0601E1A7 RID: 123303 RVA: 0x002CB95C File Offset: 0x002C9B5C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnXboxTokenAndSignatureResult._FunctionPtr == IntPtr.Zero)
			{
				FOnXboxTokenAndSignatureResult._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnXboxTokenAndSignatureResult__DelegateSignature");
			}
			return FOnXboxTokenAndSignatureResult._FunctionPtr;
		}

		// Token: 0x0601E1A8 RID: 123304 RVA: 0x002CB97F File Offset: 0x002C9B7F
		public FOnXboxTokenAndSignatureResult()
		{
		}

		// Token: 0x0601E1A9 RID: 123305 RVA: 0x002CB987 File Offset: 0x002C9B87
		[NullableContext(2)]
		public FOnXboxTokenAndSignatureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1AA RID: 123306 RVA: 0x002CB991 File Offset: 0x002C9B91
		public FOnXboxTokenAndSignatureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1AB RID: 123307 RVA: 0x002CB99C File Offset: 0x002C9B9C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FXboxTokenAndSignatureResult>) ?? ((Action<FXboxTokenAndSignatureResult>)Delegate.CreateDelegate(typeof(Action<FXboxTokenAndSignatureResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E1AC RID: 123308 RVA: 0x002CB9CE File Offset: 0x002C9BCE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E1AD RID: 123309 RVA: 0x002CBA08 File Offset: 0x002C9C08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E1AE RID: 123310 RVA: 0x002CBA74 File Offset: 0x002C9C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010439 RID: 66617
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401043A RID: 66618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnXboxTokenAndSignatureResult__DelegateSignature";

		// Token: 0x0401043B RID: 66619
		private static int RegisterId;

		// Token: 0x020033D7 RID: 13271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FOnXboxTokenAndSignatureResult_DelegateParams
		{
			// Token: 0x0401738C RID: 95116
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x020033D8 RID: 13272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401738D RID: 95117
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
