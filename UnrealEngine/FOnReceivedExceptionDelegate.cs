using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000489 RID: 1161
	public sealed class FOnReceivedExceptionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D5B RID: 27995 RVA: 0x0009FD9E File Offset: 0x0009DF9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedExceptionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x0009FDAA File Offset: 0x0009DFAA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedExceptionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedExceptionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedExceptionDelegate__DelegateSignature");
			}
			return FOnReceivedExceptionDelegate._FunctionPtr;
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x0009FDCD File Offset: 0x0009DFCD
		public FOnReceivedExceptionDelegate()
		{
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x0009FDD5 File Offset: 0x0009DFD5
		[NullableContext(2)]
		public FOnReceivedExceptionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x0009FDDF File Offset: 0x0009DFDF
		public FOnReceivedExceptionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0009FDEA File Offset: 0x0009DFEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, short, uint, FArrayBuffer>) ?? ((Action<int, short, uint, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, short, uint, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0009FE1C File Offset: 0x0009E01C
		[NullableContext(1)]
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

		// Token: 0x06006D62 RID: 28002 RVA: 0x0009FE58 File Offset: 0x0009E058
		[SkipLocalsInit]
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

		// Token: 0x06006D63 RID: 28003 RVA: 0x0009FEAC File Offset: 0x0009E0AC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, short, uint, FArrayBuffer> action = target as Action<int, short, uint, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->RpdId, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->ErrorCode, ((FOnReceivedExceptionDelegate.__FOnReceivedExceptionDelegate_DelegateParams*)__Parameters)->StringBuffer);
		}

		// Token: 0x04002EAC RID: 11948
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EAD RID: 11949
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedExceptionDelegate__DelegateSignature";

		// Token: 0x04002EAE RID: 11950
		private static int RegisterId;

		// Token: 0x02000B94 RID: 2964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnReceivedExceptionDelegate_DelegateParams
		{
			// Token: 0x04005D0D RID: 23821
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04005D0E RID: 23822
			[FieldOffset(4)]
			public short RpdId;

			// Token: 0x04005D0F RID: 23823
			[FieldOffset(8)]
			public uint ErrorCode;

			// Token: 0x04005D10 RID: 23824
			[FieldOffset(16)]
			public FArrayBuffer StringBuffer;
		}

		// Token: 0x02000B95 RID: 2965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D11 RID: 23825
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
