using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D0 RID: 720
	public sealed class FOnProxyBpAsyncResolve : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004E0A RID: 19978 RVA: 0x0006D16A File Offset: 0x0006B36A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProxyBpAsyncResolve.StaticFunctionPtr();
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x0006D176 File Offset: 0x0006B376
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProxyBpAsyncResolve._FunctionPtr == IntPtr.Zero)
			{
				FOnProxyBpAsyncResolve._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/JsEnv.OnProxyBpAsyncResolve__DelegateSignature");
			}
			return FOnProxyBpAsyncResolve._FunctionPtr;
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x0006D199 File Offset: 0x0006B399
		public FOnProxyBpAsyncResolve()
		{
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x0006D1A1 File Offset: 0x0006B3A1
		[NullableContext(2)]
		public FOnProxyBpAsyncResolve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x0006D1AB File Offset: 0x0006B3AB
		public FOnProxyBpAsyncResolve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x0006D1B6 File Offset: 0x0006B3B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x0006D1E8 File Offset: 0x0006B3E8
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FOnProxyBpAsyncResolve.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProxyBpAsyncResolve.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProxyBpAsyncResolve.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProxyBpAsyncResolve.OnScriptCallback));
				}
				FOnProxyBpAsyncResolve.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnProxyBpAsyncResolve.RegisterId);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x0006D224 File Offset: 0x0006B424
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Result)
		{
			FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams* ptr = stackalloc FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProxyBpAsyncResolve.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnProxyBpAsyncResolve._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x0006D278 File Offset: 0x0006B478
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams*)__Parameters)->Result));
			action(obj);
		}

		// Token: 0x04001F3E RID: 7998
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F3F RID: 7999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.OnProxyBpAsyncResolve__DelegateSignature";

		// Token: 0x04001F40 RID: 8000
		private static int RegisterId;

		// Token: 0x02000A00 RID: 2560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnProxyBpAsyncResolve_DelegateParams
		{
			// Token: 0x040059A7 RID: 22951
			[FieldOffset(0)]
			public FString Result;
		}

		// Token: 0x02000A01 RID: 2561
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059A8 RID: 22952
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
