using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CF RID: 719
	public sealed class FOnProxyBpAsyncReject : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004E01 RID: 19969 RVA: 0x0006D009 File Offset: 0x0006B209
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProxyBpAsyncReject.StaticFunctionPtr();
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x0006D015 File Offset: 0x0006B215
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProxyBpAsyncReject._FunctionPtr == IntPtr.Zero)
			{
				FOnProxyBpAsyncReject._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/JsEnv.OnProxyBpAsyncReject__DelegateSignature");
			}
			return FOnProxyBpAsyncReject._FunctionPtr;
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x0006D038 File Offset: 0x0006B238
		public FOnProxyBpAsyncReject()
		{
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x0006D040 File Offset: 0x0006B240
		[NullableContext(2)]
		public FOnProxyBpAsyncReject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x0006D04A File Offset: 0x0006B24A
		public FOnProxyBpAsyncReject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x0006D055 File Offset: 0x0006B255
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x0006D087 File Offset: 0x0006B287
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FOnProxyBpAsyncReject.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProxyBpAsyncReject.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProxyBpAsyncReject.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProxyBpAsyncReject.OnScriptCallback));
				}
				FOnProxyBpAsyncReject.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnProxyBpAsyncReject.RegisterId);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x0006D0C4 File Offset: 0x0006B2C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Reason)
		{
			FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams* ptr = stackalloc FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProxyBpAsyncReject.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnProxyBpAsyncReject._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x0006D118 File Offset: 0x0006B318
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams*)__Parameters)->Reason));
			action(obj);
		}

		// Token: 0x04001F3B RID: 7995
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F3C RID: 7996
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.OnProxyBpAsyncReject__DelegateSignature";

		// Token: 0x04001F3D RID: 7997
		private static int RegisterId;

		// Token: 0x020009FE RID: 2558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnProxyBpAsyncReject_DelegateParams
		{
			// Token: 0x040059A5 RID: 22949
			[FieldOffset(0)]
			public FString Reason;
		}

		// Token: 0x020009FF RID: 2559
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059A6 RID: 22950
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
