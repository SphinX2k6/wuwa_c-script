using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047C RID: 1148
	public sealed class FKuroHttpRequestHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006C98 RID: 27800 RVA: 0x0009E976 File Offset: 0x0009CB76
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroHttpRequestHandle.StaticFunctionPtr();
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x0009E982 File Offset: 0x0009CB82
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroHttpRequestHandle._FunctionPtr == IntPtr.Zero)
			{
				FKuroHttpRequestHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroHttpRequestHandle__DelegateSignature");
			}
			return FKuroHttpRequestHandle._FunctionPtr;
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x0009E9A5 File Offset: 0x0009CBA5
		public FKuroHttpRequestHandle()
		{
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x0009E9AD File Offset: 0x0009CBAD
		[NullableContext(2)]
		public FKuroHttpRequestHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x0009E9B7 File Offset: 0x0009CBB7
		public FKuroHttpRequestHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x0009E9C2 File Offset: 0x0009CBC2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, UKuroHttpServerRequestProxy>) ?? ((Action<string, UKuroHttpServerRequestProxy>)Delegate.CreateDelegate(typeof(Action<string, UKuroHttpServerRequestProxy>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x0009E9F4 File Offset: 0x0009CBF4
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

		// Token: 0x06006C9F RID: 27807 RVA: 0x0009EA30 File Offset: 0x0009CC30
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string ModuleName, [Nullable(2)] UKuroHttpServerRequestProxy RequestProxy)
		{
			FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams* ptr = stackalloc FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroHttpRequestHandle.__FKuroHttpRequestHandle_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroHttpRequestHandle.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ModuleName), ModuleName);
			ptr->RequestProxy = ((RequestProxy != null) ? RequestProxy.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroHttpRequestHandle._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x0009EA9C File Offset: 0x0009CC9C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002E69 RID: 11881
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E6A RID: 11882
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroHttpRequestHandle__DelegateSignature";

		// Token: 0x04002E6B RID: 11883
		private static int RegisterId;

		// Token: 0x02000B88 RID: 2952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroHttpRequestHandle_DelegateParams
		{
			// Token: 0x04005CF9 RID: 23801
			[FieldOffset(0)]
			public FString ModuleName;

			// Token: 0x04005CFA RID: 23802
			[FieldOffset(16)]
			public IntPtr RequestProxy;
		}

		// Token: 0x02000B89 RID: 2953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005CFB RID: 23803
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
