using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D8 RID: 216
	public sealed class FOnAkPostEventCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x00017B01 File Offset: 0x00015D01
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAkPostEventCallback.StaticFunctionPtr();
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00017B0D File Offset: 0x00015D0D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAkPostEventCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnAkPostEventCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnAkPostEventCallback__DelegateSignature");
			}
			return FOnAkPostEventCallback._FunctionPtr;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00017B30 File Offset: 0x00015D30
		public FOnAkPostEventCallback()
		{
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00017B38 File Offset: 0x00015D38
		[NullableContext(2)]
		public FOnAkPostEventCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00017B42 File Offset: 0x00015D42
		public FOnAkPostEventCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00017B4D File Offset: 0x00015D4D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EAkCallbackType, UAkCallbackInfo>) ?? ((Action<EAkCallbackType, UAkCallbackInfo>)Delegate.CreateDelegate(typeof(Action<EAkCallbackType, UAkCallbackInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00017B7F File Offset: 0x00015D7F
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<EAkCallbackType, UAkCallbackInfo> Callback)
		{
			if (FOnAkPostEventCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAkPostEventCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAkPostEventCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAkPostEventCallback.OnScriptCallback));
				}
				FOnAkPostEventCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnAkPostEventCallback.RegisterId);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00017BBC File Offset: 0x00015DBC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams* ptr = stackalloc FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAkPostEventCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CallbackType = CallbackType;
			ptr->CallbackInfo = ((CallbackInfo != null) ? CallbackInfo.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00017C10 File Offset: 0x00015E10
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EAkCallbackType, UAkCallbackInfo> action = target as Action<EAkCallbackType, UAkCallbackInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAkCallbackInfo orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkCallbackInfo>(((FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams*)__Parameters)->CallbackInfo);
			action(((FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams*)__Parameters)->CallbackType, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000367 RID: 871
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000368 RID: 872
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnAkPostEventCallback__DelegateSignature";

		// Token: 0x04000369 RID: 873
		private static int RegisterId;

		// Token: 0x02000905 RID: 2309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnAkPostEventCallback_DelegateParams
		{
			// Token: 0x040057DE RID: 22494
			[FieldOffset(0)]
			public EAkCallbackType CallbackType;

			// Token: 0x040057DF RID: 22495
			[FieldOffset(8)]
			public IntPtr CallbackInfo;
		}

		// Token: 0x02000906 RID: 2310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040057E0 RID: 22496
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
