using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005EB RID: 1515
	[UnrealObjectPath("/Script/KuroUtility.KuroTencentCOSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTencentCOSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060086E1 RID: 34529 RVA: 0x000CA23C File Offset: 0x000C843C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTencentCOSLibrary._ClassPtr;
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x000CA248 File Offset: 0x000C8448
		public UKuroTencentCOSLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTencentCOSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x000CA270 File Offset: 0x000C8470
		[NullableContext(1)]
		public UKuroTencentCOSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTencentCOSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x000CA2A4 File Offset: 0x000C84A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSendLogZipName(string ZipFileName)
		{
			UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetSendLogZipName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ZipFileName), ZipFileName);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetSendLogZipName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x000CA300 File Offset: 0x000C8500
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSendLogConfig(string SecretID, string SecretKey, string BucketName, string Region)
		{
			UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetSendLogConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SecretID), SecretID);
			FString.CopyFrom((void*)(&ptr->SecretKey), SecretKey);
			FString.CopyFrom((void*)(&ptr->BucketName), BucketName);
			FString.CopyFrom((void*)(&ptr->Region), Region);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetSendLogConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x000CA384 File Offset: 0x000C8584
		[SkipLocalsInit]
		public unsafe static void SetIsAutoSend(bool bIsAutoSend)
		{
			UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetIsAutoSend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetIsAutoSend_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsAutoSend = bIsAutoSend;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetIsAutoSend_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x000CA3CC File Offset: 0x000C85CC
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetHandleFunc_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetHandleFunc_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x000CA454 File Offset: 0x000C8654
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetFilesToSend_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = FilePaths;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetFilesToSend_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x000CA4CC File Offset: 0x000C86CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetCloudPath(string Name)
		{
			UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetCloudPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SetCloudPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x000CA528 File Offset: 0x000C8728
		[SkipLocalsInit]
		public unsafe static void SetAdmissibleValue(int SingleLogSizeInMb)
		{
			UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__SetAdmissibleValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__SetAdmissibleValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SingleLogSizeInMb = SingleLogSizeInMb;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SetAdmissibleValue_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x000CA56D File Offset: 0x000C876D
		[NullableContext(2)]
		public static void SendLogToTencentCOS(in FOnProgress OnProgress)
		{
			FOnProgress fonProgress = OnProgress;
			UKuroTencentCOSLibrary.__SendLogToTencentCOS_Internal((fonProgress != null) ? fonProgress.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x000CA584 File Offset: 0x000C8784
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__SendFileToTencentCOS_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__SendFileToTencentCOS_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x000CA624 File Offset: 0x000C8824
		[SkipLocalsInit]
		public unsafe static bool IsSending()
		{
			UKuroTencentCOSLibrary.__IsSending_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__IsSending_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__IsSending_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__IsSending_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__IsSending_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x000CA668 File Offset: 0x000C8868
		[SkipLocalsInit]
		public unsafe static bool IsAutoSendWhenExitRunning()
		{
			UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__IsAutoSendWhenExitRunning_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x000CA6AC File Offset: 0x000C88AC
		[SkipLocalsInit]
		public static void InterruptSending()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__InterruptSending_NativeFunctionPtr, null);
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x000CA6C0 File Offset: 0x000C88C0
		[SkipLocalsInit]
		public unsafe static int GetSendedFileNum()
		{
			UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__GetSendedFileNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__GetSendedFileNum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__GetSendedFileNum_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x000CA704 File Offset: 0x000C8904
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetEngineIniPath()
		{
			UKuroTencentCOSLibrary.__GetEngineIniPath_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__GetEngineIniPath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__GetEngineIniPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__GetEngineIniPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__GetEngineIniPath_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroTencentCOSLibrary.__GetEngineIniPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x000CA760 File Offset: 0x000C8960
		[SkipLocalsInit]
		public unsafe static int GetAllFileNumNeedToSend()
		{
			UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__GetAllFileNumNeedToSend_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x000CA7A4 File Offset: 0x000C89A4
		[SkipLocalsInit]
		public static void EnableAutoSendWhenExit()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__EnableAutoSendWhenExit_NativeFunctionPtr, null);
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x000CA7B8 File Offset: 0x000C89B8
		[SkipLocalsInit]
		public unsafe static void EnableAuthorization(bool Enable)
		{
			UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams* ptr = stackalloc UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroTencentCOSLibrary.__EnableAuthorization_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroTencentCOSLibrary.__EnableAuthorization_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__EnableAuthorization_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x000CA7FD File Offset: 0x000C89FD
		[SkipLocalsInit]
		public static void ClearAllProgressCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroTencentCOSLibrary._ClassDefaultObjectPtr, UKuroTencentCOSLibrary.__ClearAllProgressCallback_NativeFunctionPtr, null);
		}

		// Token: 0x060086F6 RID: 34550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendLogToTencentCOS_Internal(IntPtr OnProgress);

		// Token: 0x060086F7 RID: 34551 RVA: 0x000CA810 File Offset: 0x000C8A10
		static UKuroTencentCOSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTencentCOSLibrary");
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x000CA81E File Offset: 0x000C8A1E
		protected UKuroTencentCOSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AB5 RID: 15029
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTencentCOSLibrary";

		// Token: 0x04003AB6 RID: 15030
		private static IntPtr _ClassPtr;

		// Token: 0x04003AB7 RID: 15031
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003AB8 RID: 15032
		private static IntPtr __SetSendLogZipName_NativeFunctionPtr;

		// Token: 0x04003AB9 RID: 15033
		private static IntPtr __SetSendLogConfig_NativeFunctionPtr;

		// Token: 0x04003ABA RID: 15034
		private static IntPtr __SetIsAutoSend_NativeFunctionPtr;

		// Token: 0x04003ABB RID: 15035
		private static IntPtr __SetHandleFunc_NativeFunctionPtr;

		// Token: 0x04003ABC RID: 15036
		private static IntPtr __SetFilesToSend_NativeFunctionPtr;

		// Token: 0x04003ABD RID: 15037
		private static IntPtr __SetCloudPath_NativeFunctionPtr;

		// Token: 0x04003ABE RID: 15038
		private static IntPtr __SetAdmissibleValue_NativeFunctionPtr;

		// Token: 0x04003ABF RID: 15039
		private static IntPtr __SendFileToTencentCOS_NativeFunctionPtr;

		// Token: 0x04003AC0 RID: 15040
		private static IntPtr __IsSending_NativeFunctionPtr;

		// Token: 0x04003AC1 RID: 15041
		private static IntPtr __IsAutoSendWhenExitRunning_NativeFunctionPtr;

		// Token: 0x04003AC2 RID: 15042
		private static IntPtr __InterruptSending_NativeFunctionPtr;

		// Token: 0x04003AC3 RID: 15043
		private static IntPtr __GetSendedFileNum_NativeFunctionPtr;

		// Token: 0x04003AC4 RID: 15044
		private static IntPtr __GetEngineIniPath_NativeFunctionPtr;

		// Token: 0x04003AC5 RID: 15045
		private static IntPtr __GetAllFileNumNeedToSend_NativeFunctionPtr;

		// Token: 0x04003AC6 RID: 15046
		private static IntPtr __EnableAutoSendWhenExit_NativeFunctionPtr;

		// Token: 0x04003AC7 RID: 15047
		private static IntPtr __EnableAuthorization_NativeFunctionPtr;

		// Token: 0x04003AC8 RID: 15048
		private static IntPtr __ClearAllProgressCallback_NativeFunctionPtr;

		// Token: 0x02000DEB RID: 3563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSendLogZipName_FunctionParams
		{
			// Token: 0x04006173 RID: 24947
			[FieldOffset(0)]
			public FString ZipFileName;
		}

		// Token: 0x02000DEC RID: 3564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSendLogConfig_FunctionParams
		{
			// Token: 0x04006174 RID: 24948
			[FieldOffset(0)]
			public FString SecretID;

			// Token: 0x04006175 RID: 24949
			[FieldOffset(16)]
			public FString SecretKey;

			// Token: 0x04006176 RID: 24950
			[FieldOffset(32)]
			public FString BucketName;

			// Token: 0x04006177 RID: 24951
			[FieldOffset(48)]
			public FString Region;
		}

		// Token: 0x02000DED RID: 3565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsAutoSend_FunctionParams
		{
			// Token: 0x04006178 RID: 24952
			[FieldOffset(0)]
			public bool bIsAutoSend;
		}

		// Token: 0x02000DEE RID: 3566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetHandleFunc_FunctionParams
		{
			// Token: 0x04006179 RID: 24953
			[FieldOffset(0)]
			public byte PrepareFunc;

			// Token: 0x0400617A RID: 24954
			[FieldOffset(40)]
			public byte PostSend;
		}

		// Token: 0x02000DEF RID: 3567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetFilesToSend_FunctionParams
		{
			// Token: 0x0400617B RID: 24955
			[FieldOffset(0)]
			public byte FilePaths;
		}

		// Token: 0x02000DF0 RID: 3568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetCloudPath_FunctionParams
		{
			// Token: 0x0400617C RID: 24956
			[FieldOffset(0)]
			public FString Name;
		}

		// Token: 0x02000DF1 RID: 3569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAdmissibleValue_FunctionParams
		{
			// Token: 0x0400617D RID: 24957
			[FieldOffset(0)]
			public int SingleLogSizeInMb;
		}

		// Token: 0x02000DF2 RID: 3570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SendFileToTencentCOS_FunctionParams
		{
			// Token: 0x0400617E RID: 24958
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x0400617F RID: 24959
			[FieldOffset(16)]
			public FString RemoteURI;

			// Token: 0x04006180 RID: 24960
			[FieldOffset(32)]
			public FString SecretID;

			// Token: 0x04006181 RID: 24961
			[FieldOffset(48)]
			public FString SecretKey;

			// Token: 0x04006182 RID: 24962
			[FieldOffset(64)]
			public FString BucketName;

			// Token: 0x04006183 RID: 24963
			[FieldOffset(80)]
			public FString Region;
		}

		// Token: 0x02000DF3 RID: 3571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsSending_FunctionParams
		{
			// Token: 0x04006184 RID: 24964
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000DF4 RID: 3572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsAutoSendWhenExitRunning_FunctionParams
		{
			// Token: 0x04006185 RID: 24965
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000DF5 RID: 3573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSendedFileNum_FunctionParams
		{
			// Token: 0x04006186 RID: 24966
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000DF6 RID: 3574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEngineIniPath_FunctionParams
		{
			// Token: 0x04006187 RID: 24967
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000DF7 RID: 3575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAllFileNumNeedToSend_FunctionParams
		{
			// Token: 0x04006188 RID: 24968
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000DF8 RID: 3576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableAuthorization_FunctionParams
		{
			// Token: 0x04006189 RID: 24969
			[FieldOffset(0)]
			public bool Enable;
		}
	}
}
