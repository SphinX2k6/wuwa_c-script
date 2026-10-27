using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A07 RID: 6663
	public sealed class FOnReceivedPushDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B1A RID: 101146 RVA: 0x00246C08 File Offset: 0x00244E08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedPushDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B1B RID: 101147 RVA: 0x00246C14 File Offset: 0x00244E14
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedPushDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedPushDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedPushDelegate__DelegateSignature");
			}
			return FOnReceivedPushDelegate._FunctionPtr;
		}

		// Token: 0x06018B1C RID: 101148 RVA: 0x00246C37 File Offset: 0x00244E37
		public FOnReceivedPushDelegate()
		{
		}

		// Token: 0x06018B1D RID: 101149 RVA: 0x00246C3F File Offset: 0x00244E3F
		[NullableContext(2)]
		public FOnReceivedPushDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B1E RID: 101150 RVA: 0x00246C49 File Offset: 0x00244E49
		public FOnReceivedPushDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B1F RID: 101151 RVA: 0x00246C54 File Offset: 0x00244E54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, ushort, FArrayBuffer>) ?? ((Action<int, ushort, FArrayBuffer>)Delegate.CreateDelegate(typeof(Action<int, ushort, FArrayBuffer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B20 RID: 101152 RVA: 0x00246C86 File Offset: 0x00244E86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, ushort, FArrayBuffer> Callback)
		{
			if (FOnReceivedPushDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedPushDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedPushDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedPushDelegate.OnScriptCallback));
				}
				FOnReceivedPushDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedPushDelegate.RegisterId);
		}

		// Token: 0x06018B21 RID: 101153 RVA: 0x00246CC0 File Offset: 0x00244EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int SeqNo, ushort MessageId, FArrayBuffer MessageBuffer)
		{
			FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams* ptr = stackalloc FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedPushDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->MessageId = MessageId;
			ptr->MessageBuffer = MessageBuffer;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018B22 RID: 101154 RVA: 0x00246D0C File Offset: 0x00244F0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, ushort, FArrayBuffer> action = target as Action<int, ushort, FArrayBuffer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->SeqNo, ((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->MessageId, ((FOnReceivedPushDelegate.__FOnReceivedPushDelegate_DelegateParams*)__Parameters)->MessageBuffer);
		}

		// Token: 0x0400D565 RID: 54629
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D566 RID: 54630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedPushDelegate__DelegateSignature";

		// Token: 0x0400D567 RID: 54631
		private static int RegisterId;

		// Token: 0x020030B9 RID: 12473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnReceivedPushDelegate_DelegateParams
		{
			// Token: 0x04016E0C RID: 93708
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016E0D RID: 93709
			[FieldOffset(4)]
			public ushort MessageId;

			// Token: 0x04016E0E RID: 93710
			[FieldOffset(8)]
			public FArrayBuffer MessageBuffer;
		}

		// Token: 0x020030BA RID: 12474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E0F RID: 93711
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
