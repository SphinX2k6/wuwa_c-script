using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F6 RID: 6646
	public sealed class FKuroHttpRequestHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018A1B RID: 100891 RVA: 0x00245173 File Offset: 0x00243373
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroHttpRequestHandle.StaticFunctionPtr();
		}

		// Token: 0x06018A1C RID: 100892 RVA: 0x0024517F File Offset: 0x0024337F
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroHttpRequestHandle._FunctionPtr == IntPtr.Zero)
			{
				FKuroHttpRequestHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroHttpRequestHandle__DelegateSignature");
			}
			return FKuroHttpRequestHandle._FunctionPtr;
		}

		// Token: 0x06018A1D RID: 100893 RVA: 0x002451A2 File Offset: 0x002433A2
		public FKuroHttpRequestHandle()
		{
		}

		// Token: 0x06018A1E RID: 100894 RVA: 0x002451AA File Offset: 0x002433AA
		[NullableContext(2)]
		public FKuroHttpRequestHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x002451B4 File Offset: 0x002433B4
		public FKuroHttpRequestHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x002451BF File Offset: 0x002433BF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, UKuroHttpServerRequestProxy>) ?? ((Action<string, UKuroHttpServerRequestProxy>)Delegate.CreateDelegate(typeof(Action<string, UKuroHttpServerRequestProxy>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x002451F1 File Offset: 0x002433F1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<string, UKuroHttpServerRequestProxy> Callback)
		{
			if (FKuroHttpRequestHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroHttpRequestHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroHttpRequestHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroHttpRequestHandle.OnScriptCallback));
				}
				FKuroHttpRequestHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroHttpRequestHandle.RegisterId);
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x0024522C File Offset: 0x0024342C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string ModuleName, [Nullable(2)] UKuroHttpServerRequestProxy RequestProxy)
		{
			FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams* ptr = stackalloc FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroHttpRequestHandle.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ModuleName), ModuleName);
			ptr->RequestProxy = ((RequestProxy != null) ? RequestProxy.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroHttpRequestHandle._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018A23 RID: 100899 RVA: 0x00245298 File Offset: 0x00243498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, UKuroHttpServerRequestProxy> action = target as Action<string, UKuroHttpServerRequestProxy>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams*)__Parameters)->ModuleName));
			UKuroHttpServerRequestProxy orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroHttpServerRequestProxy>(((FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams*)__Parameters)->RequestProxy);
			action(arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400D507 RID: 54535
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D508 RID: 54536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroHttpRequestHandle__DelegateSignature";

		// Token: 0x0400D509 RID: 54537
		private static int RegisterId;

		// Token: 0x020030A8 RID: 12456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroHttpRequestHandle_DelegateParams
		{
			// Token: 0x04016DE8 RID: 93672
			[FieldOffset(0)]
			public FString ModuleName;

			// Token: 0x04016DE9 RID: 93673
			[FieldOffset(16)]
			public IntPtr RequestProxy;
		}

		// Token: 0x020030A9 RID: 12457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DEA RID: 93674
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
