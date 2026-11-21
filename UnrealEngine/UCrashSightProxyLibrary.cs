using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000159 RID: 345
	[UnrealObjectPath("/Script/CrashSight.CrashSightProxyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UCrashSightProxyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x0001E6F6 File Offset: 0x0001C8F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrashSightProxyLibrary._ClassPtr;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0001E704 File Offset: 0x0001C904
		public UCrashSightProxyLibrary() : this(BuiltinUtils.AllocNativeUObject(UCrashSightProxyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0001E72C File Offset: 0x0001C92C
		[NullableContext(1)]
		public UCrashSightProxyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCrashSightProxyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0001E75F File Offset: 0x0001C95F
		[SkipLocalsInit]
		public static void TestCriticalError()
		{
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__TestCriticalError_NativeFunctionPtr, null);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0001E772 File Offset: 0x0001C972
		[SkipLocalsInit]
		public static void Test()
		{
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__Test_NativeFunctionPtr, null);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0001E788 File Offset: 0x0001C988
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetUserId(string UserId)
		{
			UCrashSightProxyLibrary.__SetUserId_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->UserId), UserId);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetCustomDataCache(string Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomDataCache_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomDataCache_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0001E850 File Offset: 0x0001CA50
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetCustomDataByFName(in FName Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomDataByFName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Key = Key;
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomDataByFName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetCustomData(string Key, string Value)
		{
			UCrashSightProxyLibrary.__SetCustomData_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetCustomData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetCustomData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetCustomData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0001E924 File Offset: 0x0001CB24
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetBranchInfo(string Stream, string Changelist)
		{
			UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UCrashSightProxyLibrary.__SetBranchInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Stream), Stream);
			FString.CopyFrom((void*)(&ptr->Changelist), Changelist);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__SetBranchInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0001E990 File Offset: 0x0001CB90
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__ReportException_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__ReportException_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0001EA34 File Offset: 0x0001CC34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetSdkDeviceId()
		{
			UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams* ptr = stackalloc UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UCrashSightProxyLibrary.__GetSdkDeviceId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UCrashSightProxyLibrary._ClassDefaultObjectPtr, UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UCrashSightProxyLibrary.__GetSdkDeviceId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0001EA8F File Offset: 0x0001CC8F
		static UCrashSightProxyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CrashSight.CrashSightProxyLibrary");
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0001EA9D File Offset: 0x0001CC9D
		protected UCrashSightProxyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000622 RID: 1570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CrashSight.CrashSightProxyLibrary";

		// Token: 0x04000623 RID: 1571
		private static IntPtr _ClassPtr;

		// Token: 0x04000624 RID: 1572
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000625 RID: 1573
		private static IntPtr __TestCriticalError_NativeFunctionPtr;

		// Token: 0x04000626 RID: 1574
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x04000627 RID: 1575
		private static IntPtr __SetUserId_NativeFunctionPtr;

		// Token: 0x04000628 RID: 1576
		private static IntPtr __SetCustomDataCache_NativeFunctionPtr;

		// Token: 0x04000629 RID: 1577
		private static IntPtr __SetCustomDataByFName_NativeFunctionPtr;

		// Token: 0x0400062A RID: 1578
		private static IntPtr __SetCustomData_NativeFunctionPtr;

		// Token: 0x0400062B RID: 1579
		private static IntPtr __SetBranchInfo_NativeFunctionPtr;

		// Token: 0x0400062C RID: 1580
		private static IntPtr __ReportException_NativeFunctionPtr;

		// Token: 0x0400062D RID: 1581
		private static IntPtr __GetSdkDeviceId_NativeFunctionPtr;

		// Token: 0x02000930 RID: 2352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetUserId_FunctionParams
		{
			// Token: 0x0400583D RID: 22589
			[FieldOffset(0)]
			public FString UserId;
		}

		// Token: 0x02000931 RID: 2353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomDataCache_FunctionParams
		{
			// Token: 0x0400583E RID: 22590
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x0400583F RID: 22591
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02000932 RID: 2354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomDataByFName_FunctionParams
		{
			// Token: 0x04005840 RID: 22592
			[FieldOffset(0)]
			public FName Key;

			// Token: 0x04005841 RID: 22593
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02000933 RID: 2355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCustomData_FunctionParams
		{
			// Token: 0x04005842 RID: 22594
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04005843 RID: 22595
			[FieldOffset(16)]
			public FString Value;
		}

		// Token: 0x02000934 RID: 2356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetBranchInfo_FunctionParams
		{
			// Token: 0x04005844 RID: 22596
			[FieldOffset(0)]
			public FString Stream;

			// Token: 0x04005845 RID: 22597
			[FieldOffset(16)]
			public FString Changelist;
		}

		// Token: 0x02000935 RID: 2357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __ReportException_FunctionParams
		{
			// Token: 0x04005846 RID: 22598
			[FieldOffset(0)]
			public int Type;

			// Token: 0x04005847 RID: 22599
			[FieldOffset(8)]
			public FString Name;

			// Token: 0x04005848 RID: 22600
			[FieldOffset(24)]
			public FString Message;

			// Token: 0x04005849 RID: 22601
			[FieldOffset(40)]
			public FString Stack;

			// Token: 0x0400584A RID: 22602
			[FieldOffset(56)]
			public FString Extras;

			// Token: 0x0400584B RID: 22603
			[FieldOffset(72)]
			public bool Async;

			// Token: 0x0400584C RID: 22604
			[FieldOffset(73)]
			public bool Quit;

			// Token: 0x0400584D RID: 22605
			[FieldOffset(76)]
			public int DumpNativeType;
		}

		// Token: 0x02000936 RID: 2358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkDeviceId_FunctionParams
		{
			// Token: 0x0400584E RID: 22606
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
