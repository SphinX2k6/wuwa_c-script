using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001456 RID: 5206
	[UnrealObjectPath("/Script/GooglePAD.GooglePADFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013058 RID: 77912 RVA: 0x001BF702 File Offset: 0x001BD902
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGooglePADFunctionLibrary._ClassPtr;
		}

		// Token: 0x06013059 RID: 77913 RVA: 0x001BF710 File Offset: 0x001BD910
		public UGooglePADFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UGooglePADFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601305A RID: 77914 RVA: 0x001BF738 File Offset: 0x001BD938
		[NullableContext(1)]
		public UGooglePADFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGooglePADFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601305B RID: 77915 RVA: 0x001BF76C File Offset: 0x001BD96C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode ShowCellularDataConfirmation()
		{
			UGooglePADFunctionLibrary.__ShowCellularDataConfirmation_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__ShowCellularDataConfirmation_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__ShowCellularDataConfirmation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__ShowCellularDataConfirmation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__ShowCellularDataConfirmation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601305C RID: 77916 RVA: 0x001BF7B4 File Offset: 0x001BD9B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode RequestRemoval(string Name)
		{
			UGooglePADFunctionLibrary.__RequestRemoval_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__RequestRemoval_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__RequestRemoval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__RequestRemoval_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__RequestRemoval_NativeFunctionPtr, (void*)ptr, 0);
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__RequestRemoval_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601305D RID: 77917 RVA: 0x001BF818 File Offset: 0x001BDA18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode RequestInfo([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> AssetPacks)
		{
			UGooglePADFunctionLibrary.__RequestInfo_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__RequestInfo_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__RequestInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__RequestInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (AssetPacks != null)
			{
				AssetPacks.CopyTo(&ptr->AssetPacks, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__RequestInfo_NativeFunctionPtr, (void*)ptr, 0);
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__RequestInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601305E RID: 77918 RVA: 0x001BF888 File Offset: 0x001BDA88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode RequestDownload([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> AssetPacks)
		{
			UGooglePADFunctionLibrary.__RequestDownload_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__RequestDownload_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__RequestDownload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__RequestDownload_NativeFunctionPtr, (void*)ptr, 1);
			if (AssetPacks != null)
			{
				AssetPacks.CopyTo(&ptr->AssetPacks, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__RequestDownload_NativeFunctionPtr, (void*)ptr, 0);
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__RequestDownload_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601305F RID: 77919 RVA: 0x001BF8F8 File Offset: 0x001BDAF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReleaseDownloadState(int State)
		{
			UGooglePADFunctionLibrary.__ReleaseDownloadState_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__ReleaseDownloadState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__ReleaseDownloadState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__ReleaseDownloadState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__ReleaseDownloadState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013060 RID: 77920 RVA: 0x001BF940 File Offset: 0x001BDB40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ReleaseAssetPackLocation(int Location)
		{
			UGooglePADFunctionLibrary.__ReleaseAssetPackLocation_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__ReleaseAssetPackLocation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__ReleaseAssetPackLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__ReleaseAssetPackLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__ReleaseAssetPackLocation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06013061 RID: 77921 RVA: 0x001BF988 File Offset: 0x001BDB88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetTotalBytesToDownload(int State)
		{
			UGooglePADFunctionLibrary.__GetTotalBytesToDownload_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetTotalBytesToDownload_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetTotalBytesToDownload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetTotalBytesToDownload_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetTotalBytesToDownload_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013062 RID: 77922 RVA: 0x001BF9D4 File Offset: 0x001BDBD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADStorageMethod GetStorageMethod(int Location)
		{
			UGooglePADFunctionLibrary.__GetStorageMethod_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetStorageMethod_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetStorageMethod_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetStorageMethod_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetStorageMethod_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013063 RID: 77923 RVA: 0x001BFA20 File Offset: 0x001BDC20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode GetShowCellularDataConfirmationStatus(ref EGooglePADCellularDataConfirmStatus Status)
		{
			UGooglePADFunctionLibrary.__GetShowCellularDataConfirmationStatus_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetShowCellularDataConfirmationStatus_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetShowCellularDataConfirmationStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetShowCellularDataConfirmationStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Status = Status;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetShowCellularDataConfirmationStatus_NativeFunctionPtr, (void*)ptr, 0);
			Status = ptr->Status;
			return ptr->__Result;
		}

		// Token: 0x06013064 RID: 77924 RVA: 0x001BFA78 File Offset: 0x001BDC78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADDownloadStatus GetDownloadStatus(int State)
		{
			UGooglePADFunctionLibrary.__GetDownloadStatus_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetDownloadStatus_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetDownloadStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetDownloadStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetDownloadStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013065 RID: 77925 RVA: 0x001BFAC4 File Offset: 0x001BDCC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode GetDownloadState(string Name, ref int State)
		{
			UGooglePADFunctionLibrary.__GetDownloadState_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetDownloadState_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetDownloadState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetDownloadState_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetDownloadState_NativeFunctionPtr, (void*)ptr, 0);
			State = ptr->State;
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__GetDownloadState_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06013066 RID: 77926 RVA: 0x001BFB38 File Offset: 0x001BDD38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetBytesDownloaded(int State)
		{
			UGooglePADFunctionLibrary.__GetBytesDownloaded_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetBytesDownloaded_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetBytesDownloaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetBytesDownloaded_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetBytesDownloaded_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06013067 RID: 77927 RVA: 0x001BFB84 File Offset: 0x001BDD84
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAssetsPath(int Location)
		{
			UGooglePADFunctionLibrary.__GetAssetsPath_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetAssetsPath_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetAssetsPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetAssetsPath_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetAssetsPath_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__GetAssetsPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06013068 RID: 77928 RVA: 0x001BFBE8 File Offset: 0x001BDDE8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode GetAssetPackLocation(string Name, ref int Location)
		{
			UGooglePADFunctionLibrary.__GetAssetPackLocation_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__GetAssetPackLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__GetAssetPackLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__GetAssetPackLocation_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__GetAssetPackLocation_NativeFunctionPtr, (void*)ptr, 0);
			Location = ptr->Location;
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__GetAssetPackLocation_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06013069 RID: 77929 RVA: 0x001BFC5C File Offset: 0x001BDE5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EGooglePADErrorCode CancelDownload([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> AssetPacks)
		{
			UGooglePADFunctionLibrary.__CancelDownload_FunctionParams* ptr = stackalloc UGooglePADFunctionLibrary.__CancelDownload_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UGooglePADFunctionLibrary.__CancelDownload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGooglePADFunctionLibrary.__CancelDownload_NativeFunctionPtr, (void*)ptr, 1);
			if (AssetPacks != null)
			{
				AssetPacks.CopyTo(&ptr->AssetPacks, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UGooglePADFunctionLibrary._ClassDefaultObjectPtr, UGooglePADFunctionLibrary.__CancelDownload_NativeFunctionPtr, (void*)ptr, 0);
			EGooglePADErrorCode _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGooglePADFunctionLibrary.__CancelDownload_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601306A RID: 77930 RVA: 0x001BFCCB File Offset: 0x001BDECB
		static UGooglePADFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GooglePAD.GooglePADFunctionLibrary");
		}

		// Token: 0x0601306B RID: 77931 RVA: 0x001BFCD9 File Offset: 0x001BDED9
		protected UGooglePADFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2F0 RID: 41712
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GooglePAD.GooglePADFunctionLibrary";

		// Token: 0x0400A2F1 RID: 41713
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2F2 RID: 41714
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A2F3 RID: 41715
		private static IntPtr __ShowCellularDataConfirmation_NativeFunctionPtr;

		// Token: 0x0400A2F4 RID: 41716
		private static IntPtr __RequestRemoval_NativeFunctionPtr;

		// Token: 0x0400A2F5 RID: 41717
		private static IntPtr __RequestInfo_NativeFunctionPtr;

		// Token: 0x0400A2F6 RID: 41718
		private static IntPtr __RequestDownload_NativeFunctionPtr;

		// Token: 0x0400A2F7 RID: 41719
		private static IntPtr __ReleaseDownloadState_NativeFunctionPtr;

		// Token: 0x0400A2F8 RID: 41720
		private static IntPtr __ReleaseAssetPackLocation_NativeFunctionPtr;

		// Token: 0x0400A2F9 RID: 41721
		private static IntPtr __GetTotalBytesToDownload_NativeFunctionPtr;

		// Token: 0x0400A2FA RID: 41722
		private static IntPtr __GetStorageMethod_NativeFunctionPtr;

		// Token: 0x0400A2FB RID: 41723
		private static IntPtr __GetShowCellularDataConfirmationStatus_NativeFunctionPtr;

		// Token: 0x0400A2FC RID: 41724
		private static IntPtr __GetDownloadStatus_NativeFunctionPtr;

		// Token: 0x0400A2FD RID: 41725
		private static IntPtr __GetDownloadState_NativeFunctionPtr;

		// Token: 0x0400A2FE RID: 41726
		private static IntPtr __GetBytesDownloaded_NativeFunctionPtr;

		// Token: 0x0400A2FF RID: 41727
		private static IntPtr __GetAssetsPath_NativeFunctionPtr;

		// Token: 0x0400A300 RID: 41728
		private static IntPtr __GetAssetPackLocation_NativeFunctionPtr;

		// Token: 0x0400A301 RID: 41729
		private static IntPtr __CancelDownload_NativeFunctionPtr;

		// Token: 0x02002E98 RID: 11928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowCellularDataConfirmation_FunctionParams
		{
			// Token: 0x0401696F RID: 92527
			[FieldOffset(0)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002E99 RID: 11929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RequestRemoval_FunctionParams
		{
			// Token: 0x04016970 RID: 92528
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04016971 RID: 92529
			[FieldOffset(16)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002E9A RID: 11930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RequestInfo_FunctionParams
		{
			// Token: 0x04016972 RID: 92530
			[FieldOffset(0)]
			public byte AssetPacks;

			// Token: 0x04016973 RID: 92531
			[FieldOffset(16)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002E9B RID: 11931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RequestDownload_FunctionParams
		{
			// Token: 0x04016974 RID: 92532
			[FieldOffset(0)]
			public byte AssetPacks;

			// Token: 0x04016975 RID: 92533
			[FieldOffset(16)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002E9C RID: 11932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReleaseDownloadState_FunctionParams
		{
			// Token: 0x04016976 RID: 92534
			[FieldOffset(0)]
			public int State;
		}

		// Token: 0x02002E9D RID: 11933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReleaseAssetPackLocation_FunctionParams
		{
			// Token: 0x04016977 RID: 92535
			[FieldOffset(0)]
			public int Location;
		}

		// Token: 0x02002E9E RID: 11934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTotalBytesToDownload_FunctionParams
		{
			// Token: 0x04016978 RID: 92536
			[FieldOffset(0)]
			public int State;

			// Token: 0x04016979 RID: 92537
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02002E9F RID: 11935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStorageMethod_FunctionParams
		{
			// Token: 0x0401697A RID: 92538
			[FieldOffset(0)]
			public int Location;

			// Token: 0x0401697B RID: 92539
			[FieldOffset(4)]
			public EGooglePADStorageMethod __Result;
		}

		// Token: 0x02002EA0 RID: 11936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetShowCellularDataConfirmationStatus_FunctionParams
		{
			// Token: 0x0401697C RID: 92540
			[FieldOffset(0)]
			public EGooglePADCellularDataConfirmStatus Status;

			// Token: 0x0401697D RID: 92541
			[FieldOffset(1)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002EA1 RID: 11937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDownloadStatus_FunctionParams
		{
			// Token: 0x0401697E RID: 92542
			[FieldOffset(0)]
			public int State;

			// Token: 0x0401697F RID: 92543
			[FieldOffset(4)]
			public EGooglePADDownloadStatus __Result;
		}

		// Token: 0x02002EA2 RID: 11938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetDownloadState_FunctionParams
		{
			// Token: 0x04016980 RID: 92544
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04016981 RID: 92545
			[FieldOffset(16)]
			public int State;

			// Token: 0x04016982 RID: 92546
			[FieldOffset(20)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002EA3 RID: 11939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetBytesDownloaded_FunctionParams
		{
			// Token: 0x04016983 RID: 92547
			[FieldOffset(0)]
			public int State;

			// Token: 0x04016984 RID: 92548
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02002EA4 RID: 11940
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAssetsPath_FunctionParams
		{
			// Token: 0x04016985 RID: 92549
			[FieldOffset(0)]
			public int Location;

			// Token: 0x04016986 RID: 92550
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x02002EA5 RID: 11941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAssetPackLocation_FunctionParams
		{
			// Token: 0x04016987 RID: 92551
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04016988 RID: 92552
			[FieldOffset(16)]
			public int Location;

			// Token: 0x04016989 RID: 92553
			[FieldOffset(20)]
			public EGooglePADErrorCode __Result;
		}

		// Token: 0x02002EA6 RID: 11942
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CancelDownload_FunctionParams
		{
			// Token: 0x0401698A RID: 92554
			[FieldOffset(0)]
			public byte AssetPacks;

			// Token: 0x0401698B RID: 92555
			[FieldOffset(16)]
			public EGooglePADErrorCode __Result;
		}
	}
}
