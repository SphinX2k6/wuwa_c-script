using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FA RID: 6650
	[UnrealObjectPath("/Script/KuroNetwork.KuroKcpTestWorker")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKuroKcpTestWorker : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A82 RID: 100994 RVA: 0x00245BC4 File Offset: 0x00243DC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroKcpTestWorker._ClassPtr;
		}

		// Token: 0x06018A83 RID: 100995 RVA: 0x00245BD0 File Offset: 0x00243DD0
		public UKuroKcpTestWorker() : this(BuiltinUtils.AllocNativeUObject(UKuroKcpTestWorker.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A84 RID: 100996 RVA: 0x00245BF8 File Offset: 0x00243DF8
		[NullableContext(1)]
		public UKuroKcpTestWorker(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroKcpTestWorker.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018A85 RID: 100997 RVA: 0x00245C2C File Offset: 0x00243E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnRecvResponse(int SeqNo, short RpcId, ushort MessageId, ref FArrayBuffer MessageBuff)
		{
			UKuroKcpTestWorker.__OnRecvResponse_FunctionParams* ptr = stackalloc UKuroKcpTestWorker.__OnRecvResponse_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroKcpTestWorker.__OnRecvResponse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroKcpTestWorker.__OnRecvResponse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->RpcId = RpcId;
			ptr->MessageId = MessageId;
			ptr->MessageBuff = MessageBuff;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroKcpTestWorker.__OnRecvResponse_NativeFunctionPtr, (void*)ptr, 0);
			MessageBuff = ptr->MessageBuff;
		}

		// Token: 0x06018A86 RID: 100998 RVA: 0x00245C9C File Offset: 0x00243E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnRecvPush(int SeqNo, ushort MessageId, ref FArrayBuffer MessageBuff)
		{
			UKuroKcpTestWorker.__OnRecvPush_FunctionParams* ptr = stackalloc UKuroKcpTestWorker.__OnRecvPush_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroKcpTestWorker.__OnRecvPush_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroKcpTestWorker.__OnRecvPush_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->MessageId = MessageId;
			ptr->MessageBuff = MessageBuff;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroKcpTestWorker.__OnRecvPush_NativeFunctionPtr, (void*)ptr, 0);
			MessageBuff = ptr->MessageBuff;
		}

		// Token: 0x06018A87 RID: 100999 RVA: 0x00245D04 File Offset: 0x00243F04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnRecvException(int SeqNo, short RpcId, int ErrorCode, ref FArrayBuffer MessageBuff)
		{
			UKuroKcpTestWorker.__OnRecvException_FunctionParams* ptr = stackalloc UKuroKcpTestWorker.__OnRecvException_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroKcpTestWorker.__OnRecvException_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroKcpTestWorker.__OnRecvException_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SeqNo = SeqNo;
			ptr->RpcId = RpcId;
			ptr->ErrorCode = ErrorCode;
			ptr->MessageBuff = MessageBuff;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroKcpTestWorker.__OnRecvException_NativeFunctionPtr, (void*)ptr, 0);
			MessageBuff = ptr->MessageBuff;
		}

		// Token: 0x06018A88 RID: 101000 RVA: 0x00245D73 File Offset: 0x00243F73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnConnectSuccess()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroKcpTestWorker.__OnConnectSuccess_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018A89 RID: 101001 RVA: 0x00245D88 File Offset: 0x00243F88
		static UKuroKcpTestWorker()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroKcpTestWorker");
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x00245D96 File Offset: 0x00243F96
		protected UKuroKcpTestWorker(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D52E RID: 54574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroKcpTestWorker";

		// Token: 0x0400D52F RID: 54575
		private static IntPtr _ClassPtr;

		// Token: 0x0400D530 RID: 54576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D531 RID: 54577
		private static IntPtr __OnRecvResponse_NativeFunctionPtr;

		// Token: 0x0400D532 RID: 54578
		private static IntPtr __OnRecvPush_NativeFunctionPtr;

		// Token: 0x0400D533 RID: 54579
		private static IntPtr __OnRecvException_NativeFunctionPtr;

		// Token: 0x0400D534 RID: 54580
		private static IntPtr __OnConnectSuccess_NativeFunctionPtr;

		// Token: 0x020030AD RID: 12461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnRecvResponse_FunctionParams
		{
			// Token: 0x04016DF1 RID: 93681
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016DF2 RID: 93682
			[FieldOffset(4)]
			public short RpcId;

			// Token: 0x04016DF3 RID: 93683
			[FieldOffset(6)]
			public ushort MessageId;

			// Token: 0x04016DF4 RID: 93684
			[FieldOffset(8)]
			public FArrayBuffer MessageBuff;
		}

		// Token: 0x020030AE RID: 12462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnRecvPush_FunctionParams
		{
			// Token: 0x04016DF5 RID: 93685
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016DF6 RID: 93686
			[FieldOffset(4)]
			public ushort MessageId;

			// Token: 0x04016DF7 RID: 93687
			[FieldOffset(8)]
			public FArrayBuffer MessageBuff;
		}

		// Token: 0x020030AF RID: 12463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnRecvException_FunctionParams
		{
			// Token: 0x04016DF8 RID: 93688
			[FieldOffset(0)]
			public int SeqNo;

			// Token: 0x04016DF9 RID: 93689
			[FieldOffset(4)]
			public short RpcId;

			// Token: 0x04016DFA RID: 93690
			[FieldOffset(8)]
			public int ErrorCode;

			// Token: 0x04016DFB RID: 93691
			[FieldOffset(16)]
			public FArrayBuffer MessageBuff;
		}
	}
}
