using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A06 RID: 6662
	public sealed class FOnReceivedExceptionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B11 RID: 101137 RVA: 0x00246A9E File Offset: 0x00244C9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedExceptionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x00246AAA File Offset: 0x00244CAA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedExceptionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedExceptionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedExceptionDelegate__DelegateSignature");
			}
			return FOnReceivedExceptionDelegate._FunctionPtr;
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x00246ACD File Offset: 0x00244CCD
		public FOnReceivedExceptionDelegate()
		{
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x00246AD5 File Offset: 0x00244CD5
		[NullableContext(2)]
		public FOnReceivedExceptionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B15 RID: 101141 RVA: 0x00246ADF File Offset: 0x00244CDF
		public FOnReceivedExceptionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B16 RID: 101142 RVA: 0x00246AEA File Offset: 0x00244CEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, short, uint, FArrayBuffer>) ?? ((Action<int, short, uint, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, short, uint, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B17 RID: 101143 RVA: 0x00246B1C File Offset: 0x00244D1C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, short, uint, FArrayBuffer> Callback)
		{
			if (FOnReceivedExceptionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedExceptionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedExceptionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedExceptionDelegate.OnScriptCallback));
				}
				FOnReceivedExceptionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedExceptionDelegate.RegisterId);
		}

		// Token: 0x06018B18 RID: 101144 RVA: 0x00246B58 File Offset: 0x00244D58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int SeqNo, short RpdId, uint ErrorCode, FArrayBuffer StringBuffer)
		{
			FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams* ptr = stackalloc FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedExceptionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->RpdId = RpdId;
			ptr->ErrorCode = ErrorCode;
			ptr->StringBuffer = StringBuffer;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B19 RID: 101145 RVA: 0x00246BAC File Offset: 0x00244DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, short, uint, FArrayBuffer> action = target as Action<int, short, uint, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->RpdId, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->ErrorCode, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->StringBuffer);
		}

		// Token: 0x0400D562 RID: 54626
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D563 RID: 54627
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedExceptionDelegate__DelegateSignature";

		// Token: 0x0400D564 RID: 54628
		private static int RegisterId;

		// Token: 0x020030B7 RID: 12471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnReceivedExceptionDelegate_DelegateParams
		{
			// Token: 0x04016E07 RID: 93703
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016E08 RID: 93704
			[FieldOffset(4)]
			public short RpdId;

			// Token: 0x04016E09 RID: 93705
			[FieldOffset(8)]
			public uint ErrorCode;

			// Token: 0x04016E0A RID: 93706
			[FieldOffset(16)]
			public FArrayBuffer StringBuffer;
		}

		// Token: 0x020030B8 RID: 12472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E0B RID: 93707
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
