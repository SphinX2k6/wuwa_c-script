using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015BA RID: 5562
	public sealed class FOnProxyBpAsyncResolve : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601412C RID: 82220 RVA: 0x001D75CE File Offset: 0x001D57CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProxyBpAsyncResolve.StaticFunctionPtr();
		}

		// Token: 0x0601412D RID: 82221 RVA: 0x001D75DA File Offset: 0x001D57DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProxyBpAsyncResolve._FunctionPtr == IntPtr.Zero)
			{
				FOnProxyBpAsyncResolve._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/JsEnv.OnProxyBpAsyncResolve__DelegateSignature");
			}
			return FOnProxyBpAsyncResolve._FunctionPtr;
		}

		// Token: 0x0601412E RID: 82222 RVA: 0x001D75FD File Offset: 0x001D57FD
		public FOnProxyBpAsyncResolve()
		{
		}

		// Token: 0x0601412F RID: 82223 RVA: 0x001D7605 File Offset: 0x001D5805
		[NullableContext(2)]
		public FOnProxyBpAsyncResolve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014130 RID: 82224 RVA: 0x001D760F File Offset: 0x001D580F
		public FOnProxyBpAsyncResolve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014131 RID: 82225 RVA: 0x001D761A File Offset: 0x001D581A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014132 RID: 82226 RVA: 0x001D764C File Offset: 0x001D584C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06014133 RID: 82227 RVA: 0x001D7688 File Offset: 0x001D5888
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Result)
		{
			FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams* ptr = stackalloc FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProxyBpAsyncResolve.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnProxyBpAsyncResolve._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06014134 RID: 82228 RVA: 0x001D76DC File Offset: 0x001D58DC
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
			string obj = FString.ToString((void*)(&((FOnProxyBpAsyncResolve.__FOnProxyBpAsyncResolve_DelegateParams*)__Parameters)->Result));
			action(obj);
		}

		// Token: 0x0400AE9B RID: 44699
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400AE9C RID: 44700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/JsEnv.OnProxyBpAsyncResolve__DelegateSignature";

		// Token: 0x0400AE9D RID: 44701
		private static int RegisterId;

		// Token: 0x02002EC2 RID: 11970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnProxyBpAsyncResolve_DelegateParams
		{
			// Token: 0x040169BF RID: 92607
			[FieldOffset(0)]
			public FString Result;
		}

		// Token: 0x02002EC3 RID: 11971
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169C0 RID: 92608
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
