using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075C RID: 1884
	public sealed class FOnRequestContentFailed : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A440 RID: 42048 RVA: 0x000F27D6 File Offset: 0x000F09D6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRequestContentFailed.StaticFunctionPtr();
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x000F27E2 File Offset: 0x000F09E2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRequestContentFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnRequestContentFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature");
			}
			return FOnRequestContentFailed._FunctionPtr;
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x000F2805 File Offset: 0x000F0A05
		public FOnRequestContentFailed()
		{
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x000F280D File Offset: 0x000F0A0D
		[NullableContext(2)]
		public FOnRequestContentFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x000F2817 File Offset: 0x000F0A17
		public FOnRequestContentFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x000F2822 File Offset: 0x000F0A22
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FText, int>) ?? ((Action<FText, int>)Delegate.CreateDelegate(typeof(Action<FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x000F2854 File Offset: 0x000F0A54
		[NullableContext(1)]
		public void Bind(Action<FText, int> Callback)
		{
			if (FOnRequestContentFailed.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRequestContentFailed.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRequestContentFailed.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRequestContentFailed.OnScriptCallback));
				}
				FOnRequestContentFailed.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnRequestContentFailed.RegisterId);
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x000F2890 File Offset: 0x000F0A90
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(FText ErrorText, int ErrorCode)
		{
			FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams* ptr = stackalloc FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRequestContentFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->ErrorText), ErrorText.NativePtr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnRequestContentFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x000F28F4 File Offset: 0x000F0AF4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FText, int> action = target as Action<FText, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams*)__Parameters)->ErrorText, true, true);
			action(arg, ((FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x04004605 RID: 17925
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004606 RID: 17926
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature";

		// Token: 0x04004607 RID: 17927
		private static int RegisterId;

		// Token: 0x02000F47 RID: 3911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnRequestContentFailed_DelegateParams
		{
			// Token: 0x0400631C RID: 25372
			[FieldOffset(0)]
			public byte ErrorText;

			// Token: 0x0400631D RID: 25373
			[FieldOffset(24)]
			public int ErrorCode;
		}

		// Token: 0x02000F48 RID: 3912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400631E RID: 25374
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
