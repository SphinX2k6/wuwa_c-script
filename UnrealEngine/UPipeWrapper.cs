using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A62 RID: 10850
	[UnrealObjectPath("/Script/WeLingPipeSDK.PipeWrapper")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPipeWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060280B6 RID: 164022 RVA: 0x003CF372 File Offset: 0x003CD572
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPipeWrapper._ClassPtr;
		}

		// Token: 0x060280B7 RID: 164023 RVA: 0x003CF380 File Offset: 0x003CD580
		public UPipeWrapper() : this(BuiltinUtils.AllocNativeUObject(UPipeWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060280B8 RID: 164024 RVA: 0x003CF3A8 File Offset: 0x003CD5A8
		[NullableContext(1)]
		public UPipeWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPipeWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060280B9 RID: 164025 RVA: 0x003CF3DB File Offset: 0x003CD5DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Uninit()
		{
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__Uninit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060280BA RID: 164026 RVA: 0x003CF3F0 File Offset: 0x003CD5F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string TestString()
		{
			UPipeWrapper.__TestString_FunctionParams* ptr = stackalloc UPipeWrapper.__TestString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UPipeWrapper.__TestString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPipeWrapper.__TestString_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__TestString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UPipeWrapper.__TestString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060280BB RID: 164027 RVA: 0x003CF44C File Offset: 0x003CD64C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Test()
		{
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__Test_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060280BC RID: 164028 RVA: 0x003CF460 File Offset: 0x003CD660
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SendDataToPipeBinaryWithKeyEx(string key, [Nullable(2)] TArray<byte> data, string userid)
		{
			UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_FunctionParams* ptr = stackalloc UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			if (data != null)
			{
				data.CopyTo(&ptr->data, default(UScriptStructStackOnlyPtr));
			}
			FString.CopyFrom((void*)(&ptr->userid), userid);
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UPipeWrapper.__SendDataToPipeBinaryWithKeyEx_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060280BD RID: 164029 RVA: 0x003CF4EC File Offset: 0x003CD6EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SendDataToPipeBinaryWithKey(string key, [Nullable(2)] TArray<byte> data)
		{
			UPipeWrapper.__SendDataToPipeBinaryWithKey_FunctionParams* ptr = stackalloc UPipeWrapper.__SendDataToPipeBinaryWithKey_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UPipeWrapper.__SendDataToPipeBinaryWithKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPipeWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			if (data != null)
			{
				data.CopyTo(&ptr->data, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UPipeWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060280BE RID: 164030 RVA: 0x003CF568 File Offset: 0x003CD768
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SendDataToPipeBinary(TArray<byte> data)
		{
			UPipeWrapper.__SendDataToPipeBinary_FunctionParams* ptr = stackalloc UPipeWrapper.__SendDataToPipeBinary_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UPipeWrapper.__SendDataToPipeBinary_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPipeWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
			if (data != null)
			{
				data.CopyTo(&ptr->data, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UPipeWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060280BF RID: 164031 RVA: 0x003CF5D8 File Offset: 0x003CD7D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool InitPipe()
		{
			UPipeWrapper.__InitPipe_FunctionParams* ptr = stackalloc UPipeWrapper.__InitPipe_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UPipeWrapper.__InitPipe_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPipeWrapper.__InitPipe_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UPipeWrapper._ClassDefaultObjectPtr, UPipeWrapper.__InitPipe_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060280C0 RID: 164032 RVA: 0x003CF61D File Offset: 0x003CD81D
		static UPipeWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WeLingPipeSDK.PipeWrapper");
		}

		// Token: 0x060280C1 RID: 164033 RVA: 0x003CF62B File Offset: 0x003CD82B
		protected UPipeWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F73 RID: 89971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WeLingPipeSDK.PipeWrapper";

		// Token: 0x04015F74 RID: 89972
		private static IntPtr _ClassPtr;

		// Token: 0x04015F75 RID: 89973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F76 RID: 89974
		private static IntPtr __Uninit_NativeFunctionPtr;

		// Token: 0x04015F77 RID: 89975
		private static IntPtr __TestString_NativeFunctionPtr;

		// Token: 0x04015F78 RID: 89976
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x04015F79 RID: 89977
		private static IntPtr __SendDataToPipeBinaryWithKeyEx_NativeFunctionPtr;

		// Token: 0x04015F7A RID: 89978
		private static IntPtr __SendDataToPipeBinaryWithKey_NativeFunctionPtr;

		// Token: 0x04015F7B RID: 89979
		private static IntPtr __SendDataToPipeBinary_NativeFunctionPtr;

		// Token: 0x04015F7C RID: 89980
		private static IntPtr __InitPipe_NativeFunctionPtr;

		// Token: 0x02003C05 RID: 15365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TestString_FunctionParams
		{
			// Token: 0x04017E35 RID: 97845
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003C06 RID: 15366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SendDataToPipeBinaryWithKeyEx_FunctionParams
		{
			// Token: 0x04017E36 RID: 97846
			[FieldOffset(0)]
			public FString key;

			// Token: 0x04017E37 RID: 97847
			[FieldOffset(16)]
			public byte data;

			// Token: 0x04017E38 RID: 97848
			[FieldOffset(32)]
			public FString userid;

			// Token: 0x04017E39 RID: 97849
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02003C07 RID: 15367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SendDataToPipeBinaryWithKey_FunctionParams
		{
			// Token: 0x04017E3A RID: 97850
			[FieldOffset(0)]
			public FString key;

			// Token: 0x04017E3B RID: 97851
			[FieldOffset(16)]
			public byte data;

			// Token: 0x04017E3C RID: 97852
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02003C08 RID: 15368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SendDataToPipeBinary_FunctionParams
		{
			// Token: 0x04017E3D RID: 97853
			[FieldOffset(0)]
			public byte data;

			// Token: 0x04017E3E RID: 97854
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003C09 RID: 15369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InitPipe_FunctionParams
		{
			// Token: 0x04017E3F RID: 97855
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
