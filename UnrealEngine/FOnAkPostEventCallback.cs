using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028B RID: 651
	public sealed class FOnAkPostEventCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600248F RID: 9359 RVA: 0x000362DB File Offset: 0x000344DB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAkPostEventCallback.StaticFunctionPtr();
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000362E7 File Offset: 0x000344E7
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAkPostEventCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnAkPostEventCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnAkPostEventCallback__DelegateSignature");
			}
			return FOnAkPostEventCallback._FunctionPtr;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0003630A File Offset: 0x0003450A
		public FOnAkPostEventCallback()
		{
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00036312 File Offset: 0x00034512
		[NullableContext(2)]
		public FOnAkPostEventCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0003631C File Offset: 0x0003451C
		public FOnAkPostEventCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00036327 File Offset: 0x00034527
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EAkCallbackType, UAkCallbackInfo>) ?? ((Action<EAkCallbackType, UAkCallbackInfo>)Delegate.CreateDelegate(typeof(Action<EAkCallbackType, UAkCallbackInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00036359 File Offset: 0x00034559
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06002496 RID: 9366 RVA: 0x00036394 File Offset: 0x00034594
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams* ptr = stackalloc FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAkPostEventCallback.__FOnAkPostEventCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAkPostEventCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CallbackType = CallbackType;
			ptr->CallbackInfo = ((CallbackInfo != null) ? CallbackInfo.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000363E8 File Offset: 0x000345E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000DEB RID: 3563
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DEC RID: 3564
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnAkPostEventCallback__DelegateSignature";

		// Token: 0x04000DED RID: 3565
		private static int RegisterId;

		// Token: 0x02002B8B RID: 11147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnAkPostEventCallback_DelegateParams
		{
			// Token: 0x0401641E RID: 91166
			[FieldOffset(0)]
			public EAkCallbackType CallbackType;

			// Token: 0x0401641F RID: 91167
			[FieldOffset(8)]
			public IntPtr CallbackInfo;
		}

		// Token: 0x02002B8C RID: 11148
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016420 RID: 91168
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
