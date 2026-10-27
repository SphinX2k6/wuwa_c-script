using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E0 RID: 10464
	[UnrealObjectPath("/Script/TapCommon.TapCommonBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTapCommonBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026D19 RID: 159001 RVA: 0x003B3352 File Offset: 0x003B1552
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapCommonBPLibrary._ClassPtr;
		}

		// Token: 0x06026D1A RID: 159002 RVA: 0x003B3360 File Offset: 0x003B1560
		public UTapCommonBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UTapCommonBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026D1B RID: 159003 RVA: 0x003B3388 File Offset: 0x003B1588
		[NullableContext(1)]
		public UTapCommonBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapCommonBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026D1C RID: 159004 RVA: 0x003B33BC File Offset: 0x003B15BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<string> RemoveEmptyString([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> stringArray)
		{
			UTapCommonBPLibrary.__RemoveEmptyString_FunctionParams* ptr = stackalloc UTapCommonBPLibrary.__RemoveEmptyString_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTapCommonBPLibrary.__RemoveEmptyString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapCommonBPLibrary.__RemoveEmptyString_NativeFunctionPtr, (void*)ptr, 1);
			if (stringArray != null)
			{
				stringArray.CopyTo(&ptr->stringArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UTapCommonBPLibrary._ClassDefaultObjectPtr, UTapCommonBPLibrary.__RemoveEmptyString_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTapCommonBPLibrary.__RemoveEmptyString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026D1D RID: 159005 RVA: 0x003B3434 File Offset: 0x003B1634
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TMap<string, string> RemoveEmptyKey([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TMap<string, string> stringMap)
		{
			UTapCommonBPLibrary.__RemoveEmptyKey_FunctionParams* ptr = stackalloc UTapCommonBPLibrary.__RemoveEmptyKey_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(UTapCommonBPLibrary.__RemoveEmptyKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapCommonBPLibrary.__RemoveEmptyKey_NativeFunctionPtr, (void*)ptr, 1);
			if (stringMap != null)
			{
				stringMap.CopyTo(&ptr->stringMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UTapCommonBPLibrary._ClassDefaultObjectPtr, UTapCommonBPLibrary.__RemoveEmptyKey_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, string> result = new TMap<string, string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTapCommonBPLibrary.__RemoveEmptyKey_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026D1E RID: 159006 RVA: 0x003B34B0 File Offset: 0x003B16B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Register(string serviceClz, string serviceImpl)
		{
			UTapCommonBPLibrary.__Register_FunctionParams* ptr = stackalloc UTapCommonBPLibrary.__Register_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTapCommonBPLibrary.__Register_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapCommonBPLibrary.__Register_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->serviceClz), serviceClz);
			FString.CopyFrom((void*)(&ptr->serviceImpl), serviceImpl);
			UnrealReflectionUtils.CallUFunction(UTapCommonBPLibrary._ClassDefaultObjectPtr, UTapCommonBPLibrary.__Register_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTapCommonBPLibrary.__Register_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026D1F RID: 159007 RVA: 0x003B351C File Offset: 0x003B171C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CallHandler(string command)
		{
			UTapCommonBPLibrary.__CallHandler_FunctionParams* ptr = stackalloc UTapCommonBPLibrary.__CallHandler_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTapCommonBPLibrary.__CallHandler_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapCommonBPLibrary.__CallHandler_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->command), command);
			UnrealReflectionUtils.CallUFunction(UTapCommonBPLibrary._ClassDefaultObjectPtr, UTapCommonBPLibrary.__CallHandler_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTapCommonBPLibrary.__CallHandler_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026D20 RID: 159008 RVA: 0x003B3579 File Offset: 0x003B1779
		static UTapCommonBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapCommonBPLibrary");
		}

		// Token: 0x06026D21 RID: 159009 RVA: 0x003B3587 File Offset: 0x003B1787
		protected UTapCommonBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040154FE RID: 87294
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TapCommonBPLibrary";

		// Token: 0x040154FF RID: 87295
		private static IntPtr _ClassPtr;

		// Token: 0x04015500 RID: 87296
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015501 RID: 87297
		private static IntPtr __RemoveEmptyString_NativeFunctionPtr;

		// Token: 0x04015502 RID: 87298
		private static IntPtr __RemoveEmptyKey_NativeFunctionPtr;

		// Token: 0x04015503 RID: 87299
		private static IntPtr __Register_NativeFunctionPtr;

		// Token: 0x04015504 RID: 87300
		private static IntPtr __CallHandler_NativeFunctionPtr;

		// Token: 0x02003B4F RID: 15183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RemoveEmptyString_FunctionParams
		{
			// Token: 0x04017CF4 RID: 97524
			[FieldOffset(0)]
			public byte stringArray;

			// Token: 0x04017CF5 RID: 97525
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02003B50 RID: 15184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __RemoveEmptyKey_FunctionParams
		{
			// Token: 0x04017CF6 RID: 97526
			[FieldOffset(0)]
			public byte stringMap;

			// Token: 0x04017CF7 RID: 97527
			[FieldOffset(80)]
			public byte __Result;
		}

		// Token: 0x02003B51 RID: 15185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Register_FunctionParams
		{
			// Token: 0x04017CF8 RID: 97528
			[FieldOffset(0)]
			public FString serviceClz;

			// Token: 0x04017CF9 RID: 97529
			[FieldOffset(16)]
			public FString serviceImpl;
		}

		// Token: 0x02003B52 RID: 15186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CallHandler_FunctionParams
		{
			// Token: 0x04017CFA RID: 97530
			[FieldOffset(0)]
			public FString command;
		}
	}
}
