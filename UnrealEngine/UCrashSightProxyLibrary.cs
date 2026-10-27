using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000773 RID: 1907
	[UnrealObjectPath("/Script/CrashSight.CrashSightProxyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UCrashSightProxyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063F0 RID: 25584 RVA: 0x0008F81A File Offset: 0x0008DA1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrashSightProxyLibrary._ClassPtr;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0008F828 File Offset: 0x0008DA28
		public UCrashSightProxyLibrary() : this(BuiltinUtils.AllocNativeUObject(UCrashSightProxyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0008F850 File Offset: 0x0008DA50
		[NullableContext(1)]
		public UCrashSightProxyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCrashSightProxyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x0008F883 File Offset: 0x0008DA83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void TestCriticalError()
		{
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__TestCriticalError_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0008F897 File Offset: 0x0008DA97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Test()
		{
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__Test_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x0008F8AC File Offset: 0x0008DAAC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetUserId(string UserId)
		{
			UCrashSightProxyLibrary.__SetUserId_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->UserId), UserId);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0008F90C File Offset: 0x0008DB0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCustomDataCache(string Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0008F978 File Offset: 0x0008DB78
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCustomDataByFName(in FName Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Key = Key;
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0008F9E4 File Offset: 0x0008DBE4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCustomData(string Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomData_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0008FA50 File Offset: 0x0008DC50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetBranchInfo(string Stream, string Changelist)
		{
			UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Stream), Stream);
			FString.CopyFrom((void*)(&ptr->Changelist), Changelist);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0008FABC File Offset: 0x0008DCBC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReportException(int Type, string Name, string Message, string Stack, string Extras, bool Async, bool Quit, int DumpNativeType)
		{
			UCrashSightProxyLibrary.__ReportException_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__ReportException_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UCrashSightProxyLibrary.__ReportException_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__ReportException_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Type = Type;
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Message), Message);
			FString.CopyFrom((void*)(&ptr->Stack), Stack);
			FString.CopyFrom((void*)(&ptr->Extras), Extras);
			ptr->Async = Async;
			ptr->Quit = Quit;
			ptr->DumpNativeType = DumpNativeType;
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__ReportException_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__ReportException_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0008FB60 File Offset: 0x0008DD60
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetSdkDeviceId()
		{
			UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0008FBBC File Offset: 0x0008DDBC
		static UCrashSightProxyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CrashSight.CrashSightProxyLibrary");
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0008FBCA File Offset: 0x0008DDCA
		protected UCrashSightProxyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CrashSight.CrashSightProxyLibrary";

		// Token: 0x04002FED RID: 12269
		private static IntPtr _ClassPtr;

		// Token: 0x04002FEE RID: 12270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002FEF RID: 12271
		private static IntPtr __TestCriticalError_NativeFunctionPtr;

		// Token: 0x04002FF0 RID: 12272
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x04002FF1 RID: 12273
		private static IntPtr __SetUserId_NativeFunctionPtr;

		// Token: 0x04002FF2 RID: 12274
		private static IntPtr __SetCustomDataCache_NativeFunctionPtr;

		// Token: 0x04002FF3 RID: 12275
		private static IntPtr __SetCustomDataByFName_NativeFunctionPtr;

		// Token: 0x04002FF4 RID: 12276
		private static IntPtr __SetCustomData_NativeFunctionPtr;

		// Token: 0x04002FF5 RID: 12277
		private static IntPtr __SetBranchInfo_NativeFunctionPtr;

		// Token: 0x04002FF6 RID: 12278
		private static IntPtr __ReportException_NativeFunctionPtr;

		// Token: 0x04002FF7 RID: 12279
		private static IntPtr __GetSdkDeviceId_NativeFunctionPtr;

		// Token: 0x02002C4A RID: 11338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetUserId_FunctionParams
		{
			// Token: 0x04016553 RID: 91475
			[FieldOffset(0)]
			public FString UserId;
		}

		// Token: 0x02002C4B RID: 11339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomDataCache_FunctionParams
		{
			// Token: 0x04016554 RID: 91476
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04016555 RID: 91477
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02002C4C RID: 11340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomDataByFName_FunctionParams
		{
			// Token: 0x04016556 RID: 91478
			[FieldOffset(0)]
			public FName Key;

			// Token: 0x04016557 RID: 91479
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02002C4D RID: 11341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomData_FunctionParams
		{
			// Token: 0x04016558 RID: 91480
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04016559 RID: 91481
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02002C4E RID: 11342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetBranchInfo_FunctionParams
		{
			// Token: 0x0401655A RID: 91482
			[FieldOffset(0)]
			public FString Stream;

			// Token: 0x0401655B RID: 91483
			[FieldOffset(16)]
			public FString Changelist;
		}

		// Token: 0x02002C4F RID: 11343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __ReportException_FunctionParams
		{
			// Token: 0x0401655C RID: 91484
			[FieldOffset(0)]
			public int Type;

			// Token: 0x0401655D RID: 91485
			[FieldOffset(8)]
			public FString Name;

			// Token: 0x0401655E RID: 91486
			[FieldOffset(24)]
			public FString Message;

			// Token: 0x0401655F RID: 91487
			[FieldOffset(40)]
			public FString Stack;

			// Token: 0x04016560 RID: 91488
			[FieldOffset(56)]
			public FString Extras;

			// Token: 0x04016561 RID: 91489
			[FieldOffset(72)]
			public bool Async;

			// Token: 0x04016562 RID: 91490
			[FieldOffset(73)]
			public bool Quit;

			// Token: 0x04016563 RID: 91491
			[FieldOffset(76)]
			public int DumpNativeType;
		}

		// Token: 0x02002C50 RID: 11344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkDeviceId_FunctionParams
		{
			// Token: 0x04016564 RID: 91492
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
