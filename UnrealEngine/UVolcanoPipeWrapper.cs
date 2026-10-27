using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A55 RID: 10837
	[UnrealObjectPath("/Script/VolcanoMsgChannel.VolcanoPipeWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UVolcanoPipeWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028077 RID: 163959 RVA: 0x003CED93 File Offset: 0x003CCF93
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVolcanoPipeWrapper._ClassPtr;
		}

		// Token: 0x06028078 RID: 163960 RVA: 0x003CEDA0 File Offset: 0x003CCFA0
		public UVolcanoPipeWrapper() : this(BuiltinUtils.AllocNativeUObject(UVolcanoPipeWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028079 RID: 163961 RVA: 0x003CEDC8 File Offset: 0x003CCFC8
		[NullableContext(1)]
		public UVolcanoPipeWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVolcanoPipeWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602807A RID: 163962 RVA: 0x003CEDFC File Offset: 0x003CCFFC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMcString(string msg)
		{
			UVolcanoPipeWrapper.__SendMcString_FunctionParams* ptr = stackalloc UVolcanoPipeWrapper.__SendMcString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UVolcanoPipeWrapper.__SendMcString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVolcanoPipeWrapper.__SendMcString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->msg), msg);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UVolcanoPipeWrapper.__SendMcString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UVolcanoPipeWrapper.__SendMcString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602807B RID: 163963 RVA: 0x003CEE5C File Offset: 0x003CD05C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMcBinaryWithKey(string Key, [Nullable(2)] in TArray<byte> bin)
		{
			UVolcanoPipeWrapper.__SendMcBinaryWithKey_FunctionParams* ptr = stackalloc UVolcanoPipeWrapper.__SendMcBinaryWithKey_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UVolcanoPipeWrapper.__SendMcBinaryWithKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVolcanoPipeWrapper.__SendMcBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			TArray<byte> tarray = bin;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->bin);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UVolcanoPipeWrapper.__SendMcBinaryWithKey_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = bin;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->bin);
			}
			UnrealReflectionUtils.DestroyStruct(UVolcanoPipeWrapper.__SendMcBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602807C RID: 163964 RVA: 0x003CEEE4 File Offset: 0x003CD0E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMcBinary(in TArray<byte> bin)
		{
			UVolcanoPipeWrapper.__SendMcBinary_FunctionParams* ptr = stackalloc UVolcanoPipeWrapper.__SendMcBinary_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UVolcanoPipeWrapper.__SendMcBinary_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVolcanoPipeWrapper.__SendMcBinary_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = bin;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->bin);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UVolcanoPipeWrapper.__SendMcBinary_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = bin;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->bin);
			}
			UnrealReflectionUtils.DestroyStruct(UVolcanoPipeWrapper.__SendMcBinary_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602807D RID: 163965 RVA: 0x003CEF5D File Offset: 0x003CD15D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitSDK()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UVolcanoPipeWrapper.__InitSDK_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602807E RID: 163966 RVA: 0x003CEF72 File Offset: 0x003CD172
		static UVolcanoPipeWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/VolcanoMsgChannel.VolcanoPipeWrapper");
		}

		// Token: 0x0602807F RID: 163967 RVA: 0x003CEF80 File Offset: 0x003CD180
		protected UVolcanoPipeWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F34 RID: 89908
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/VolcanoMsgChannel.VolcanoPipeWrapper";

		// Token: 0x04015F35 RID: 89909
		private static IntPtr _ClassPtr;

		// Token: 0x04015F36 RID: 89910
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F37 RID: 89911
		private static IntPtr __SendMcString_NativeFunctionPtr;

		// Token: 0x04015F38 RID: 89912
		private static IntPtr __SendMcBinaryWithKey_NativeFunctionPtr;

		// Token: 0x04015F39 RID: 89913
		private static IntPtr __SendMcBinary_NativeFunctionPtr;

		// Token: 0x04015F3A RID: 89914
		private static IntPtr __InitSDK_NativeFunctionPtr;

		// Token: 0x02003C02 RID: 15362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SendMcString_FunctionParams
		{
			// Token: 0x04017E31 RID: 97841
			[FieldOffset(0)]
			public FString msg;
		}

		// Token: 0x02003C03 RID: 15363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SendMcBinaryWithKey_FunctionParams
		{
			// Token: 0x04017E32 RID: 97842
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04017E33 RID: 97843
			[FieldOffset(16)]
			public byte bin;
		}

		// Token: 0x02003C04 RID: 15364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SendMcBinary_FunctionParams
		{
			// Token: 0x04017E34 RID: 97844
			[FieldOffset(0)]
			public byte bin;
		}
	}
}
