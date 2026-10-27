using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022FB RID: 8955
	public sealed class FOnRequestContentFailed : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021F0C RID: 139020 RVA: 0x003230B6 File Offset: 0x003212B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRequestContentFailed.StaticFunctionPtr();
		}

		// Token: 0x06021F0D RID: 139021 RVA: 0x003230C2 File Offset: 0x003212C2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRequestContentFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnRequestContentFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature");
			}
			return FOnRequestContentFailed._FunctionPtr;
		}

		// Token: 0x06021F0E RID: 139022 RVA: 0x003230E5 File Offset: 0x003212E5
		public FOnRequestContentFailed()
		{
		}

		// Token: 0x06021F0F RID: 139023 RVA: 0x003230ED File Offset: 0x003212ED
		[NullableContext(2)]
		public FOnRequestContentFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F10 RID: 139024 RVA: 0x003230F7 File Offset: 0x003212F7
		public FOnRequestContentFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F11 RID: 139025 RVA: 0x00323102 File Offset: 0x00321302
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FText, int>) ?? ((Action<FText, int>)Delegate.CreateDelegate(typeof(Action<FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021F12 RID: 139026 RVA: 0x00323134 File Offset: 0x00321334
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06021F13 RID: 139027 RVA: 0x00323170 File Offset: 0x00321370
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FText ErrorText, int ErrorCode)
		{
			FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams* ptr = stackalloc FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnRequestContentFailed.__FOnRequestContentFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRequestContentFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->ErrorText), ErrorText.NativePtr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnRequestContentFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021F14 RID: 139028 RVA: 0x003231D4 File Offset: 0x003213D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040121AA RID: 74154
		internal static IntPtr _FunctionPtr;

		// Token: 0x040121AB RID: 74155
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature";

		// Token: 0x040121AC RID: 74156
		private static int RegisterId;

		// Token: 0x02003641 RID: 13889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnRequestContentFailed_DelegateParams
		{
			// Token: 0x04017708 RID: 96008
			[FieldOffset(0)]
			public byte ErrorText;

			// Token: 0x04017709 RID: 96009
			[FieldOffset(24)]
			public int ErrorCode;
		}

		// Token: 0x02003642 RID: 13890
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401770A RID: 96010
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
