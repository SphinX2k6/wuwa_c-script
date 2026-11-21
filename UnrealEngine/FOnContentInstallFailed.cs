using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075A RID: 1882
	public sealed class FOnContentInstallFailed : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A42E RID: 42030 RVA: 0x000F2555 File Offset: 0x000F0755
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnContentInstallFailed.StaticFunctionPtr();
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x000F2561 File Offset: 0x000F0761
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnContentInstallFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnContentInstallFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature");
			}
			return FOnContentInstallFailed._FunctionPtr;
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x000F2584 File Offset: 0x000F0784
		public FOnContentInstallFailed()
		{
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x000F258C File Offset: 0x000F078C
		[NullableContext(2)]
		public FOnContentInstallFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x000F2596 File Offset: 0x000F0796
		public FOnContentInstallFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x000F25A1 File Offset: 0x000F07A1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FText, int>) ?? ((Action<FText, int>)Delegate.CreateDelegate(typeof(Action<FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x000F25D3 File Offset: 0x000F07D3
		[NullableContext(1)]
		public void Bind(Action<FText, int> Callback)
		{
			if (FOnContentInstallFailed.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnContentInstallFailed.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnContentInstallFailed.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnContentInstallFailed.OnScriptCallback));
				}
				FOnContentInstallFailed.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnContentInstallFailed.RegisterId);
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x000F2610 File Offset: 0x000F0810
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(FText ErrorText, int ErrorCode)
		{
			FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams* ptr = stackalloc FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnContentInstallFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->ErrorText), ErrorText.NativePtr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnContentInstallFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x000F2674 File Offset: 0x000F0874
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FText, int> action = target as Action<FText, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams*)__Parameters)->ErrorText, true, true);
			action(arg, ((FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x040045FF RID: 17919
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004600 RID: 17920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature";

		// Token: 0x04004601 RID: 17921
		private static int RegisterId;

		// Token: 0x02000F44 RID: 3908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnContentInstallFailed_DelegateParams
		{
			// Token: 0x04006318 RID: 25368
			[FieldOffset(0)]
			public byte ErrorText;

			// Token: 0x04006319 RID: 25369
			[FieldOffset(24)]
			public int ErrorCode;
		}

		// Token: 0x02000F45 RID: 3909
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400631A RID: 25370
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
