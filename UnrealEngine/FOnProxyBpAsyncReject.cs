using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B9 RID: 5561
	public sealed class FOnProxyBpAsyncReject : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014123 RID: 82211 RVA: 0x001D746D File Offset: 0x001D566D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProxyBpAsyncReject.StaticFunctionPtr();
		}

		// Token: 0x06014124 RID: 82212 RVA: 0x001D7479 File Offset: 0x001D5679
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProxyBpAsyncReject._FunctionPtr == IntPtr.Zero)
			{
				FOnProxyBpAsyncReject._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/JsEnv.OnProxyBpAsyncReject__DelegateSignature");
			}
			return FOnProxyBpAsyncReject._FunctionPtr;
		}

		// Token: 0x06014125 RID: 82213 RVA: 0x001D749C File Offset: 0x001D569C
		public FOnProxyBpAsyncReject()
		{
		}

		// Token: 0x06014126 RID: 82214 RVA: 0x001D74A4 File Offset: 0x001D56A4
		[NullableContext(2)]
		public FOnProxyBpAsyncReject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014127 RID: 82215 RVA: 0x001D74AE File Offset: 0x001D56AE
		public FOnProxyBpAsyncReject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014128 RID: 82216 RVA: 0x001D74B9 File Offset: 0x001D56B9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014129 RID: 82217 RVA: 0x001D74EB File Offset: 0x001D56EB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601412A RID: 82218 RVA: 0x001D7528 File Offset: 0x001D5728
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Reason)
		{
			FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams* ptr = stackalloc FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnProxyBpAsyncReject.__FOnProxyBpAsyncReject_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProxyBpAsyncReject.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnProxyBpAsyncReject._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601412B RID: 82219 RVA: 0x001D757C File Offset: 0x001D577C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400AE98 RID: 44696
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400AE99 RID: 44697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.OnProxyBpAsyncReject__DelegateSignature";

		// Token: 0x0400AE9A RID: 44698
		private static int RegisterId;

		// Token: 0x02002EC0 RID: 11968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnProxyBpAsyncReject_DelegateParams
		{
			// Token: 0x040169BD RID: 92605
			[FieldOffset(0)]
			public FString Reason;
		}

		// Token: 0x02002EC1 RID: 11969
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169BE RID: 92606
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
