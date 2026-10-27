using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A08 RID: 6664
	public sealed class FOnReceivedResponseDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B23 RID: 101155 RVA: 0x00246D62 File Offset: 0x00244F62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedResponseDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B24 RID: 101156 RVA: 0x00246D6E File Offset: 0x00244F6E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedResponseDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedResponseDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedResponseDelegate__DelegateSignature");
			}
			return FOnReceivedResponseDelegate._FunctionPtr;
		}

		// Token: 0x06018B25 RID: 101157 RVA: 0x00246D91 File Offset: 0x00244F91
		public FOnReceivedResponseDelegate()
		{
		}

		// Token: 0x06018B26 RID: 101158 RVA: 0x00246D99 File Offset: 0x00244F99
		[NullableContext(2)]
		public FOnReceivedResponseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B27 RID: 101159 RVA: 0x00246DA3 File Offset: 0x00244FA3
		public FOnReceivedResponseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B28 RID: 101160 RVA: 0x00246DAE File Offset: 0x00244FAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, short, ushort, FArrayBuffer>) ?? ((Action<int, short, ushort, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, short, ushort, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B29 RID: 101161 RVA: 0x00246DE0 File Offset: 0x00244FE0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, short, ushort, FArrayBuffer> Callback)
		{
			if (FOnReceivedResponseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedResponseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedResponseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedResponseDelegate.OnScriptCallback));
				}
				FOnReceivedResponseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedResponseDelegate.RegisterId);
		}

		// Token: 0x06018B2A RID: 101162 RVA: 0x00246E1C File Offset: 0x0024501C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int SeqNo, short RpdId, ushort MessageId, FArrayBuffer MessageBuffer)
		{
			FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams* ptr = stackalloc FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedResponseDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->RpdId = RpdId;
			ptr->MessageId = MessageId;
			ptr->MessageBuffer = MessageBuffer;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B2B RID: 101163 RVA: 0x00246E70 File Offset: 0x00245070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, short, ushort, FArrayBuffer> action = target as Action<int, short, ushort, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->RpdId, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->MessageId, ((FOnReceivedResponseDelegate.__FOnReceivedResponseDelegate_DelegateParams*)__Parameters)->MessageBuffer);
		}

		// Token: 0x0400D568 RID: 54632
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D569 RID: 54633
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedResponseDelegate__DelegateSignature";

		// Token: 0x0400D56A RID: 54634
		private static int RegisterId;

		// Token: 0x020030BB RID: 12475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnReceivedResponseDelegate_DelegateParams
		{
			// Token: 0x04016E10 RID: 93712
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016E11 RID: 93713
			[FieldOffset(4)]
			public short RpdId;

			// Token: 0x04016E12 RID: 93714
			[FieldOffset(6)]
			public ushort MessageId;

			// Token: 0x04016E13 RID: 93715
			[FieldOffset(8)]
			public FArrayBuffer MessageBuffer;
		}

		// Token: 0x020030BC RID: 12476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E14 RID: 93716
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
