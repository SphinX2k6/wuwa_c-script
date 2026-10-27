using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED7 RID: 7895
	[UnrealObjectPath("/Script/KuroUtility.KuroTencentCOSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTencentCOSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E05E RID: 122974 RVA: 0x002C8AC8 File Offset: 0x002C6CC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTencentCOSLibrary._ClassPtr;
		}

		// Token: 0x0601E05F RID: 122975 RVA: 0x002C8AD4 File Offset: 0x002C6CD4
		public UKuroTencentCOSLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTencentCOSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E060 RID: 122976 RVA: 0x002C8AFC File Offset: 0x002C6CFC
		[NullableContext(1)]
		public UKuroTencentCOSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTencentCOSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E061 RID: 122977 RVA: 0x002C8B30 File Offset: 0x002C6D30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSendLogZipName(string ZipFileName)
		{
			UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ZipFileName), ZipFileName);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E062 RID: 122978 RVA: 0x002C8B90 File Offset: 0x002C6D90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSendLogConfig(string SecretID, string SecretKey, string BucketName, string Region)
		{
			UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SecretID), SecretID);
			FString.CopyFrom((void*)(&ptr->SecretKey), SecretKey);
			FString.CopyFrom((void*)(&ptr->BucketName), BucketName);
			FString.CopyFrom((void*)(&ptr->Region), Region);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E063 RID: 122979 RVA: 0x002C8C14 File Offset: 0x002C6E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetIsAutoSend(bool bIsAutoSend)
		{
			UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetIsAutoSend_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsAutoSend = bIsAutoSend;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetIsAutoSend_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601E064 RID: 122980 RVA: 0x002C8C5C File Offset: 0x002C6E5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetHandleFunc(in FOnPrepareSendDelegate PrepareFunc, in FOnPostSended PostSend)
		{
			UKuroTencentCOSLibrary.__SetHandleFunc_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetHandleFunc_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetHandleFunc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetHandleFunc_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->PrepareFunc;
			FOnPrepareSendDelegate fonPrepareSendDelegate = PrepareFunc;
			FScriptDelegate.NativeCopy(dest, (fonPrepareSendDelegate != null) ? fonPrepareSendDelegate.NativePtr : ((IntPtr)0));
			IntPtr dest2 = &ptr->PostSend;
			FOnPostSended fonPostSended = PostSend;
			FScriptDelegate.NativeCopy(dest2, (fonPostSended != null) ? fonPostSended.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetHandleFunc_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetHandleFunc_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E065 RID: 122981 RVA: 0x002C8CE4 File Offset: 0x002C6EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetFilesToSend([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> FilePaths)
		{
			UKuroTencentCOSLibrary.__SetFilesToSend_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetFilesToSend_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetFilesToSend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetFilesToSend_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = FilePaths;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FilePaths);
			}
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetFilesToSend_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = FilePaths;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetFilesToSend_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E066 RID: 122982 RVA: 0x002C8D5C File Offset: 0x002C6F5C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCloudPath(string Name)
		{
			UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E067 RID: 122983 RVA: 0x002C8DBC File Offset: 0x002C6FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetAdmissibleValue(int SingleLogSizeInMb)
		{
			UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetAdmissibleValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SingleLogSizeInMb = SingleLogSizeInMb;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetAdmissibleValue_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601E068 RID: 122984 RVA: 0x002C8E04 File Offset: 0x002C7004
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendLogToTencentCOS(in FOnProgress OnProgress)
		{
			UKuroTencentCOSLibrary.__SendLogToTencentCOS_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SendLogToTencentCOS_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SendLogToTencentCOS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SendLogToTencentCOS_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->OnProgress;
			FOnProgress fonProgress = OnProgress;
			FScriptDelegate.NativeCopy(dest, (fonProgress != null) ? fonProgress.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SendLogToTencentCOS_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SendLogToTencentCOS_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E069 RID: 122985 RVA: 0x002C8E70 File Offset: 0x002C7070
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendFileToTencentCOS(string Path, string RemoteURI, string SecretID, string SecretKey, string BucketName, string Region)
		{
			UKuroTencentCOSLibrary.__SendFileToTencentCOS_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SendFileToTencentCOS_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SendFileToTencentCOS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SendFileToTencentCOS_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			FString.CopyFrom((void*)(&ptr->RemoteURI), RemoteURI);
			FString.CopyFrom((void*)(&ptr->SecretID), SecretID);
			FString.CopyFrom((void*)(&ptr->SecretKey), SecretKey);
			FString.CopyFrom((void*)(&ptr->BucketName), BucketName);
			FString.CopyFrom((void*)(&ptr->Region), Region);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SendFileToTencentCOS_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SendFileToTencentCOS_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E06A RID: 122986 RVA: 0x002C8F10 File Offset: 0x002C7110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsSending()
		{
			UKuroTencentCOSLibrary.__IsSending_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__IsSending_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__IsSending_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__IsSending_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__IsSending_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E06B RID: 122987 RVA: 0x002C8F58 File Offset: 0x002C7158
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsAutoSendWhenExitRunning()
		{
			UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E06C RID: 122988 RVA: 0x002C8F9D File Offset: 0x002C719D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void InterruptSending()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__InterruptSending_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E06D RID: 122989 RVA: 0x002C8FB4 File Offset: 0x002C71B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetSendedFileNum()
		{
			UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__GetSendedFileNum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__GetSendedFileNum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E06E RID: 122990 RVA: 0x002C8FFC File Offset: 0x002C71FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetAllFileNumNeedToSend()
		{
			UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E06F RID: 122991 RVA: 0x002C9041 File Offset: 0x002C7241
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void EnableAutoSendWhenExit()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__EnableAutoSendWhenExit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E070 RID: 122992 RVA: 0x002C9058 File Offset: 0x002C7258
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnableAuthorization(bool Enable)
		{
			UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__EnableAuthorization_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__EnableAuthorization_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601E071 RID: 122993 RVA: 0x002C909E File Offset: 0x002C729E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearAllProgressCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__ClearAllProgressCallback_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E072 RID: 122994 RVA: 0x002C90B2 File Offset: 0x002C72B2
		static UKuroTencentCOSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTencentCOSLibrary");
		}

		// Token: 0x0601E073 RID: 122995 RVA: 0x002C90C0 File Offset: 0x002C72C0
		protected UKuroTencentCOSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103C7 RID: 66503
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTencentCOSLibrary";

		// Token: 0x040103C8 RID: 66504
		private static IntPtr _ClassPtr;

		// Token: 0x040103C9 RID: 66505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103CA RID: 66506
		private static IntPtr __SetSendLogZipName_NativeFunctionPtr;

		// Token: 0x040103CB RID: 66507
		private static IntPtr __SetSendLogConfig_NativeFunctionPtr;

		// Token: 0x040103CC RID: 66508
		private static IntPtr __SetIsAutoSend_NativeFunctionPtr;

		// Token: 0x040103CD RID: 66509
		private static IntPtr __SetHandleFunc_NativeFunctionPtr;

		// Token: 0x040103CE RID: 66510
		private static IntPtr __SetFilesToSend_NativeFunctionPtr;

		// Token: 0x040103CF RID: 66511
		private static IntPtr __SetCloudPath_NativeFunctionPtr;

		// Token: 0x040103D0 RID: 66512
		private static IntPtr __SetAdmissibleValue_NativeFunctionPtr;

		// Token: 0x040103D1 RID: 66513
		private static IntPtr __SendLogToTencentCOS_NativeFunctionPtr;

		// Token: 0x040103D2 RID: 66514
		private static IntPtr __SendFileToTencentCOS_NativeFunctionPtr;

		// Token: 0x040103D3 RID: 66515
		private static IntPtr __IsSending_NativeFunctionPtr;

		// Token: 0x040103D4 RID: 66516
		private static IntPtr __IsAutoSendWhenExitRunning_NativeFunctionPtr;

		// Token: 0x040103D5 RID: 66517
		private static IntPtr __InterruptSending_NativeFunctionPtr;

		// Token: 0x040103D6 RID: 66518
		private static IntPtr __GetSendedFileNum_NativeFunctionPtr;

		// Token: 0x040103D7 RID: 66519
		private static IntPtr __GetAllFileNumNeedToSend_NativeFunctionPtr;

		// Token: 0x040103D8 RID: 66520
		private static IntPtr __EnableAutoSendWhenExit_NativeFunctionPtr;

		// Token: 0x040103D9 RID: 66521
		private static IntPtr __EnableAuthorization_NativeFunctionPtr;

		// Token: 0x040103DA RID: 66522
		private static IntPtr __ClearAllProgressCallback_NativeFunctionPtr;

		// Token: 0x02003396 RID: 13206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSendLogZipName_FunctionParams
		{
			// Token: 0x0401733E RID: 95038
			[FieldOffset(0)]
			public FString ZipFileName;
		}

		// Token: 0x02003397 RID: 13207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSendLogConfig_FunctionParams
		{
			// Token: 0x0401733F RID: 95039
			[FieldOffset(0)]
			public FString SecretID;

			// Token: 0x04017340 RID: 95040
			[FieldOffset(16)]
			public FString SecretKey;

			// Token: 0x04017341 RID: 95041
			[FieldOffset(32)]
			public FString BucketName;

			// Token: 0x04017342 RID: 95042
			[FieldOffset(48)]
			public FString Region;
		}

		// Token: 0x02003398 RID: 13208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsAutoSend_FunctionParams
		{
			// Token: 0x04017343 RID: 95043
			[FieldOffset(0)]
			public bool bIsAutoSend;
		}

		// Token: 0x02003399 RID: 13209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetHandleFunc_FunctionParams
		{
			// Token: 0x04017344 RID: 95044
			[FieldOffset(0)]
			public byte PrepareFunc;

			// Token: 0x04017345 RID: 95045
			[FieldOffset(40)]
			public byte PostSend;
		}

		// Token: 0x0200339A RID: 13210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetFilesToSend_FunctionParams
		{
			// Token: 0x04017346 RID: 95046
			[FieldOffset(0)]
			public byte FilePaths;
		}

		// Token: 0x0200339B RID: 13211
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetCloudPath_FunctionParams
		{
			// Token: 0x04017347 RID: 95047
			[FieldOffset(0)]
			public FString Name;
		}

		// Token: 0x0200339C RID: 13212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAdmissibleValue_FunctionParams
		{
			// Token: 0x04017348 RID: 95048
			[FieldOffset(0)]
			public int SingleLogSizeInMb;
		}

		// Token: 0x0200339D RID: 13213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SendLogToTencentCOS_FunctionParams
		{
			// Token: 0x04017349 RID: 95049
			[FieldOffset(0)]
			public byte OnProgress;
		}

		// Token: 0x0200339E RID: 13214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SendFileToTencentCOS_FunctionParams
		{
			// Token: 0x0401734A RID: 95050
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x0401734B RID: 95051
			[FieldOffset(16)]
			public FString RemoteURI;

			// Token: 0x0401734C RID: 95052
			[FieldOffset(32)]
			public FString SecretID;

			// Token: 0x0401734D RID: 95053
			[FieldOffset(48)]
			public FString SecretKey;

			// Token: 0x0401734E RID: 95054
			[FieldOffset(64)]
			public FString BucketName;

			// Token: 0x0401734F RID: 95055
			[FieldOffset(80)]
			public FString Region;
		}

		// Token: 0x0200339F RID: 13215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsSending_FunctionParams
		{
			// Token: 0x04017350 RID: 95056
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020033A0 RID: 13216
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsAutoSendWhenExitRunning_FunctionParams
		{
			// Token: 0x04017351 RID: 95057
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020033A1 RID: 13217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSendedFileNum_FunctionParams
		{
			// Token: 0x04017352 RID: 95058
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020033A2 RID: 13218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAllFileNumNeedToSend_FunctionParams
		{
			// Token: 0x04017353 RID: 95059
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020033A3 RID: 13219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableAuthorization_FunctionParams
		{
			// Token: 0x04017354 RID: 95060
			[FieldOffset(0)]
			public bool Enable;
		}
	}
}
