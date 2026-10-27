using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0B RID: 6667
	public sealed class FRptResponseHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B3E RID: 101182 RVA: 0x00247152 File Offset: 0x00245352
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRptResponseHandle.StaticFunctionPtr();
		}

		// Token: 0x06018B3F RID: 101183 RVA: 0x0024715E File Offset: 0x0024535E
		private static IntPtr StaticFunctionPtr()
		{
			if (FRptResponseHandle._FunctionPtr == IntPtr.Zero)
			{
				FRptResponseHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.RptResponseHandle__DelegateSignature");
			}
			return FRptResponseHandle._FunctionPtr;
		}

		// Token: 0x06018B40 RID: 101184 RVA: 0x00247181 File Offset: 0x00245381
		public FRptResponseHandle()
		{
		}

		// Token: 0x06018B41 RID: 101185 RVA: 0x00247189 File Offset: 0x00245389
		[NullableContext(2)]
		public FRptResponseHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B42 RID: 101186 RVA: 0x00247193 File Offset: 0x00245393
		public FRptResponseHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B43 RID: 101187 RVA: 0x0024719E File Offset: 0x0024539E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, int, int, int, bool>) ?? ((Action<string, int, int, int, bool>)Delegate.CreateDelegate(typeof(Action<string, int, int, int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B44 RID: 101188 RVA: 0x002471D0 File Offset: 0x002453D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, int, int, int, bool> Callback)
		{
			if (FRptResponseHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FRptResponseHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FRptResponseHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FRptResponseHandle.OnScriptCallback));
				}
				FRptResponseHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FRptResponseHandle.RegisterId);
		}

		// Token: 0x06018B45 RID: 101189 RVA: 0x0024720C File Offset: 0x0024540C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Data, int LocalErrorCode, int RemoteErrorCode, int HttpResponseCode, bool bConnectedSuccessfully)
		{
			FRptResponseHandle.__FRptResponseHandle_DelegateParams* ptr = stackalloc FRptResponseHandle.__FRptResponseHandle_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FRptResponseHandle.__FRptResponseHandle_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRptResponseHandle.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			ptr->LocalErrorCode = LocalErrorCode;
			ptr->RemoteErrorCode = RemoteErrorCode;
			ptr->HttpResponseCode = HttpResponseCode;
			ptr->bConnectedSuccessfully = bConnectedSuccessfully;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FRptResponseHandle._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018B46 RID: 101190 RVA: 0x00247280 File Offset: 0x00245480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, int, int, int, bool> action = target as Action<string, int, int, int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->Data));
			action(arg, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->LocalErrorCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->RemoteErrorCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->HttpResponseCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->bConnectedSuccessfully);
		}

		// Token: 0x0400D571 RID: 54641
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D572 RID: 54642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.RptResponseHandle__DelegateSignature";

		// Token: 0x0400D573 RID: 54643
		private static int RegisterId;

		// Token: 0x020030C1 RID: 12481
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FRptResponseHandle_DelegateParams
		{
			// Token: 0x04016E19 RID: 93721
			[FieldOffset(0)]
			public FString Data;

			// Token: 0x04016E1A RID: 93722
			[FieldOffset(16)]
			public int LocalErrorCode;

			// Token: 0x04016E1B RID: 93723
			[FieldOffset(20)]
			public int RemoteErrorCode;

			// Token: 0x04016E1C RID: 93724
			[FieldOffset(24)]
			public int HttpResponseCode;

			// Token: 0x04016E1D RID: 93725
			[FieldOffset(28)]
			public bool bConnectedSuccessfully;
		}

		// Token: 0x020030C2 RID: 12482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E1E RID: 93726
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
