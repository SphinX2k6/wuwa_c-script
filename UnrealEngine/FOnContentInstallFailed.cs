using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F9 RID: 8953
	public sealed class FOnContentInstallFailed : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021EFA RID: 139002 RVA: 0x00322E35 File Offset: 0x00321035
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnContentInstallFailed.StaticFunctionPtr();
		}

		// Token: 0x06021EFB RID: 139003 RVA: 0x00322E41 File Offset: 0x00321041
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnContentInstallFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnContentInstallFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature");
			}
			return FOnContentInstallFailed._FunctionPtr;
		}

		// Token: 0x06021EFC RID: 139004 RVA: 0x00322E64 File Offset: 0x00321064
		public FOnContentInstallFailed()
		{
		}

		// Token: 0x06021EFD RID: 139005 RVA: 0x00322E6C File Offset: 0x0032106C
		[NullableContext(2)]
		public FOnContentInstallFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021EFE RID: 139006 RVA: 0x00322E76 File Offset: 0x00321076
		public FOnContentInstallFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021EFF RID: 139007 RVA: 0x00322E81 File Offset: 0x00321081
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FText, int>) ?? ((Action<FText, int>)Delegate.CreateDelegate(typeof(Action<FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021F00 RID: 139008 RVA: 0x00322EB3 File Offset: 0x003210B3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06021F01 RID: 139009 RVA: 0x00322EF0 File Offset: 0x003210F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FText ErrorText, int ErrorCode)
		{
			FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams* ptr = stackalloc FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnContentInstallFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->ErrorText), ErrorText.NativePtr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnContentInstallFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021F02 RID: 139010 RVA: 0x00322F54 File Offset: 0x00321154
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
			FText arg = new FText(&((FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams*)__Parameters)->ErrorText, true, true);
			action(arg, ((FOnContentInstallFailed.__FOnContentInstallFailed_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x040121A4 RID: 74148
		internal static IntPtr _FunctionPtr;

		// Token: 0x040121A5 RID: 74149
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MobilePatchingUtils.OnContentInstallFailed__DelegateSignature";

		// Token: 0x040121A6 RID: 74150
		private static int RegisterId;

		// Token: 0x0200363E RID: 13886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnContentInstallFailed_DelegateParams
		{
			// Token: 0x04017704 RID: 96004
			[FieldOffset(0)]
			public byte ErrorText;

			// Token: 0x04017705 RID: 96005
			[FieldOffset(24)]
			public int ErrorCode;
		}

		// Token: 0x0200363F RID: 13887
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017706 RID: 96006
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
