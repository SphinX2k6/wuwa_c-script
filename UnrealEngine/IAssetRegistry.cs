using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DD RID: 221
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistry")]
	public interface IAssetRegistry : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06000F83 RID: 3971
		int InterfaceOffset();

		// Token: 0x06000F84 RID: 3972 RVA: 0x0001813B File Offset: 0x0001633B
		[SkipLocalsInit]
		void WaitForCompletion()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__WaitForCompletion_NativeFunctionPtr, null);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00018150 File Offset: 0x00016350
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void UseFilterToExcludeAssets([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> AssetDataList, in FARFilter Filter)
		{
			IAssetRegistry.__UseFilterToExcludeAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__UseFilterToExcludeAssets_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(IAssetRegistry.__UseFilterToExcludeAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__UseFilterToExcludeAssets_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FAssetData> tarray = AssetDataList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AssetDataList);
			}
			if (Filter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FARFilter.StaticStruct(), &ptr->Filter, Filter.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__UseFilterToExcludeAssets_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = AssetDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetDataList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__UseFilterToExcludeAssets_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000181F0 File Offset: 0x000163F0
		[SkipLocalsInit]
		unsafe void SearchAllAssets(bool bSynchronousSearch)
		{
			IAssetRegistry.__SearchAllAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__SearchAllAssets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IAssetRegistry.__SearchAllAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__SearchAllAssets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSynchronousSearch = bSynchronousSearch;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__SearchAllAssets_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00018238 File Offset: 0x00016438
		[SkipLocalsInit]
		unsafe void ScanPathsSynchronous([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InPaths, bool bForceRescan = false, bool bIgnoreBlackListScanFilters = false, bool bUseParallelScan = false)
		{
			IAssetRegistry.__ScanPathsSynchronous_FunctionParams* ptr = stackalloc IAssetRegistry.__ScanPathsSynchronous_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__ScanPathsSynchronous_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__ScanPathsSynchronous_NativeFunctionPtr, (void*)ptr, 1);
			object obj = InPaths;
			if (obj != null)
			{
				obj.MoveTo(&ptr->InPaths);
			}
			ptr->bForceRescan = bForceRescan;
			ptr->bIgnoreBlackListScanFilters = bIgnoreBlackListScanFilters;
			ptr->bUseParallelScan = bUseParallelScan;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanPathsSynchronous_NativeFunctionPtr, (void*)ptr);
			object obj2 = InPaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InPaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanPathsSynchronous_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000182C8 File Offset: 0x000164C8
		[SkipLocalsInit]
		unsafe void ScanModifiedAssetFiles([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InFilePaths)
		{
			IAssetRegistry.__ScanModifiedAssetFiles_FunctionParams* ptr = stackalloc IAssetRegistry.__ScanModifiedAssetFiles_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__ScanModifiedAssetFiles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__ScanModifiedAssetFiles_NativeFunctionPtr, (void*)ptr, 1);
			object obj = InFilePaths;
			if (obj != null)
			{
				obj.MoveTo(&ptr->InFilePaths);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanModifiedAssetFiles_NativeFunctionPtr, (void*)ptr);
			object obj2 = InFilePaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InFilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanModifiedAssetFiles_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00018340 File Offset: 0x00016540
		[SkipLocalsInit]
		unsafe void ScanFilesSynchronous([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InFilePaths, bool bForceRescan = false)
		{
			IAssetRegistry.__ScanFilesSynchronous_FunctionParams* ptr = stackalloc IAssetRegistry.__ScanFilesSynchronous_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__ScanFilesSynchronous_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__ScanFilesSynchronous_NativeFunctionPtr, (void*)ptr, 1);
			object obj = InFilePaths;
			if (obj != null)
			{
				obj.MoveTo(&ptr->InFilePaths);
			}
			ptr->bForceRescan = bForceRescan;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanFilesSynchronous_NativeFunctionPtr, (void*)ptr);
			object obj2 = InFilePaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InFilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanFilesSynchronous_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000183C0 File Offset: 0x000165C0
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void RunAssetsThroughFilter([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> AssetDataList, in FARFilter Filter)
		{
			IAssetRegistry.__RunAssetsThroughFilter_FunctionParams* ptr = stackalloc IAssetRegistry.__RunAssetsThroughFilter_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(IAssetRegistry.__RunAssetsThroughFilter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__RunAssetsThroughFilter_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FAssetData> tarray = AssetDataList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AssetDataList);
			}
			if (Filter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FARFilter.StaticStruct(), &ptr->Filter, Filter.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__RunAssetsThroughFilter_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = AssetDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetDataList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__RunAssetsThroughFilter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00018460 File Offset: 0x00016660
		[NullableContext(1)]
		[SkipLocalsInit]
		unsafe void PrioritizeSearchPath(string PathToPrioritize)
		{
			IAssetRegistry.__PrioritizeSearchPath_FunctionParams* ptr = stackalloc IAssetRegistry.__PrioritizeSearchPath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__PrioritizeSearchPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PathToPrioritize), PathToPrioritize);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000184C0 File Offset: 0x000166C0
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe bool K2_GetReferencers(FName PackageName, in FAssetRegistryDependencyOptions ReferenceOptions, ref TArray<FName> OutReferencers)
		{
			IAssetRegistry.__K2_GetReferencers_FunctionParams* ptr = stackalloc IAssetRegistry.__K2_GetReferencers_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IAssetRegistry.__K2_GetReferencers_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetReferencers_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackageName = PackageName;
			if (ReferenceOptions != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetRegistryDependencyOptions.StaticStruct(), &ptr->ReferenceOptions, ReferenceOptions.NativePtr, 1, false);
			}
			TArray<FName> tarray = OutReferencers;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutReferencers);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__K2_GetReferencers_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = OutReferencers;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutReferencers);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetReferencers_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0001856C File Offset: 0x0001676C
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe bool K2_GetDependencies(FName PackageName, in FAssetRegistryDependencyOptions DependencyOptions, ref TArray<FName> OutDependencies)
		{
			IAssetRegistry.__K2_GetDependencies_FunctionParams* ptr = stackalloc IAssetRegistry.__K2_GetDependencies_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IAssetRegistry.__K2_GetDependencies_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetDependencies_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackageName = PackageName;
			if (DependencyOptions != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetRegistryDependencyOptions.StaticStruct(), &ptr->DependencyOptions, DependencyOptions.NativePtr, 1, false);
			}
			TArray<FName> tarray = OutDependencies;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutDependencies);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__K2_GetDependencies_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = OutDependencies;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutDependencies);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetDependencies_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00018618 File Offset: 0x00016818
		[SkipLocalsInit]
		unsafe bool IsPathsForceScanned([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InPaths)
		{
			IAssetRegistry.__IsPathsForceScanned_FunctionParams* ptr = stackalloc IAssetRegistry.__IsPathsForceScanned_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__IsPathsForceScanned_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathsForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			object obj = InPaths;
			if (obj != null)
			{
				obj.MoveTo(&ptr->InPaths);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsPathsForceScanned_NativeFunctionPtr, (void*)ptr);
			object obj2 = InPaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InPaths);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathsForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00018698 File Offset: 0x00016898
		[NullableContext(1)]
		[SkipLocalsInit]
		unsafe bool IsPathForceScanned(string InPath)
		{
			IAssetRegistry.__IsPathForceScanned_FunctionParams* ptr = stackalloc IAssetRegistry.__IsPathForceScanned_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__IsPathForceScanned_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InPath), InPath);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000186FC File Offset: 0x000168FC
		[SkipLocalsInit]
		unsafe bool IsLoadingAssets()
		{
			IAssetRegistry.__IsLoadingAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__IsLoadingAssets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IAssetRegistry.__IsLoadingAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsLoadingAssets_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsLoadingAssets_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00018744 File Offset: 0x00016944
		[NullableContext(1)]
		[SkipLocalsInit]
		unsafe bool IsAssetPathLoaded(ref string Path)
		{
			IAssetRegistry.__IsAssetPathLoaded_FunctionParams* ptr = stackalloc IAssetRegistry.__IsAssetPathLoaded_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__IsAssetPathLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr);
			Path = FString.ToString((void*)(&ptr->Path));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000187B8 File Offset: 0x000169B8
		[SkipLocalsInit]
		unsafe bool HasAssets(FName PackagePath, bool bRecursive = false)
		{
			IAssetRegistry.__HasAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__HasAssets_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__HasAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__HasAssets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackagePath = PackagePath;
			ptr->bRecursive = bRecursive;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__HasAssets_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0001880C File Offset: 0x00016A0C
		[NullableContext(1)]
		[SkipLocalsInit]
		unsafe void GetSubPaths(string InBasePath, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutPathList, bool bInRecurse)
		{
			IAssetRegistry.__GetSubPaths_FunctionParams* ptr = stackalloc IAssetRegistry.__GetSubPaths_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IAssetRegistry.__GetSubPaths_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetSubPaths_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InBasePath), InBasePath);
			TArray<string> tarray = OutPathList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutPathList);
			}
			ptr->bInRecurse = bInRecurse;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetSubPaths_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = OutPathList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPathList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetSubPaths_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00018898 File Offset: 0x00016A98
		[SkipLocalsInit]
		unsafe bool GetAssetsByPath(FName PackagePath, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> OutAssetData, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
		{
			IAssetRegistry.__GetAssetsByPath_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssetsByPath_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IAssetRegistry.__GetAssetsByPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPath_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackagePath = PackagePath;
			TArray<FAssetData> tarray = OutAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutAssetData);
			}
			ptr->bRecursive = bRecursive;
			ptr->bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPath_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPath_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0001892C File Offset: 0x00016B2C
		[SkipLocalsInit]
		unsafe bool GetAssetsByPackageName(FName PackageName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false)
		{
			IAssetRegistry.__GetAssetsByPackageName_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssetsByPackageName_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IAssetRegistry.__GetAssetsByPackageName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPackageName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackageName = PackageName;
			TArray<FAssetData> tarray = OutAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutAssetData);
			}
			ptr->bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPackageName_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPackageName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000189B8 File Offset: 0x00016BB8
		[SkipLocalsInit]
		unsafe bool GetAssetsByClass(FName ClassName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> OutAssetData, bool bSearchSubClasses = false)
		{
			IAssetRegistry.__GetAssetsByClass_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssetsByClass_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IAssetRegistry.__GetAssetsByClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ClassName = ClassName;
			TArray<FAssetData> tarray = OutAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutAssetData);
			}
			ptr->bSearchSubClasses = bSearchSubClasses;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByClass_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByClass_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00018A44 File Offset: 0x00016C44
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe bool GetAssets(in FARFilter Filter, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> OutAssetData)
		{
			IAssetRegistry.__GetAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssets_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(IAssetRegistry.__GetAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssets_NativeFunctionPtr, (void*)ptr, 1);
			if (Filter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FARFilter.StaticStruct(), &ptr->Filter, Filter.NativePtr, 1, false);
			}
			TArray<FAssetData> tarray = OutAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutAssetData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssets_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssets_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00018AEC File Offset: 0x00016CEC
		[NullableContext(1)]
		[SkipLocalsInit]
		unsafe FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false)
		{
			IAssetRegistry.__GetAssetByObjectPath_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssetByObjectPath_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(IAssetRegistry.__GetAssetByObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ObjectPath = ObjectPath;
			ptr->bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr);
			FAssetData result = new FAssetData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00018B5C File Offset: 0x00016D5C
		[SkipLocalsInit]
		unsafe void GetAllCachedPaths([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutPathList)
		{
			IAssetRegistry.__GetAllCachedPaths_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAllCachedPaths_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__GetAllCachedPaths_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllCachedPaths_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = OutPathList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutPathList);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAllCachedPaths_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = OutPathList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPathList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllCachedPaths_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00018BD4 File Offset: 0x00016DD4
		[SkipLocalsInit]
		unsafe bool GetAllAssets([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false)
		{
			IAssetRegistry.__GetAllAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAllAssets_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__GetAllAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllAssets_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FAssetData> tarray = OutAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutAssetData);
			}
			ptr->bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAllAssets_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllAssets_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x04000378 RID: 888
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AssetRegistry.AssetRegistry";

		// Token: 0x0200090C RID: 2316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __UseFilterToExcludeAssets_FunctionParams
		{
			// Token: 0x040057E6 RID: 22502
			[FieldOffset(0)]
			public byte AssetDataList;

			// Token: 0x040057E7 RID: 22503
			[FieldOffset(16)]
			public byte Filter;
		}

		// Token: 0x0200090D RID: 2317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SearchAllAssets_FunctionParams
		{
			// Token: 0x040057E8 RID: 22504
			[FieldOffset(0)]
			public bool bSynchronousSearch;
		}

		// Token: 0x0200090E RID: 2318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ScanPathsSynchronous_FunctionParams
		{
			// Token: 0x040057E9 RID: 22505
			[FieldOffset(0)]
			public byte InPaths;

			// Token: 0x040057EA RID: 22506
			[FieldOffset(16)]
			public bool bForceRescan;

			// Token: 0x040057EB RID: 22507
			[FieldOffset(17)]
			public bool bIgnoreBlackListScanFilters;

			// Token: 0x040057EC RID: 22508
			[FieldOffset(18)]
			public bool bUseParallelScan;
		}

		// Token: 0x0200090F RID: 2319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ScanModifiedAssetFiles_FunctionParams
		{
			// Token: 0x040057ED RID: 22509
			[FieldOffset(0)]
			public byte InFilePaths;
		}

		// Token: 0x02000910 RID: 2320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ScanFilesSynchronous_FunctionParams
		{
			// Token: 0x040057EE RID: 22510
			[FieldOffset(0)]
			public byte InFilePaths;

			// Token: 0x040057EF RID: 22511
			[FieldOffset(16)]
			public bool bForceRescan;
		}

		// Token: 0x02000911 RID: 2321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __RunAssetsThroughFilter_FunctionParams
		{
			// Token: 0x040057F0 RID: 22512
			[FieldOffset(0)]
			public byte AssetDataList;

			// Token: 0x040057F1 RID: 22513
			[FieldOffset(16)]
			public byte Filter;
		}

		// Token: 0x02000912 RID: 2322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PrioritizeSearchPath_FunctionParams
		{
			// Token: 0x040057F2 RID: 22514
			[FieldOffset(0)]
			public FString PathToPrioritize;
		}

		// Token: 0x02000913 RID: 2323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __K2_GetReferencers_FunctionParams
		{
			// Token: 0x040057F3 RID: 22515
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x040057F4 RID: 22516
			[FieldOffset(12)]
			public byte ReferenceOptions;

			// Token: 0x040057F5 RID: 22517
			[FieldOffset(24)]
			public byte OutReferencers;

			// Token: 0x040057F6 RID: 22518
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000914 RID: 2324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __K2_GetDependencies_FunctionParams
		{
			// Token: 0x040057F7 RID: 22519
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x040057F8 RID: 22520
			[FieldOffset(12)]
			public byte DependencyOptions;

			// Token: 0x040057F9 RID: 22521
			[FieldOffset(24)]
			public byte OutDependencies;

			// Token: 0x040057FA RID: 22522
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000915 RID: 2325
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsPathsForceScanned_FunctionParams
		{
			// Token: 0x040057FB RID: 22523
			[FieldOffset(0)]
			public byte InPaths;

			// Token: 0x040057FC RID: 22524
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000916 RID: 2326
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsPathForceScanned_FunctionParams
		{
			// Token: 0x040057FD RID: 22525
			[FieldOffset(0)]
			public FString InPath;

			// Token: 0x040057FE RID: 22526
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000917 RID: 2327
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLoadingAssets_FunctionParams
		{
			// Token: 0x040057FF RID: 22527
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000918 RID: 2328
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsAssetPathLoaded_FunctionParams
		{
			// Token: 0x04005800 RID: 22528
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x04005801 RID: 22529
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000919 RID: 2329
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __HasAssets_FunctionParams
		{
			// Token: 0x04005802 RID: 22530
			[FieldOffset(0)]
			public FName PackagePath;

			// Token: 0x04005803 RID: 22531
			[FieldOffset(12)]
			public bool bRecursive;

			// Token: 0x04005804 RID: 22532
			[FieldOffset(13)]
			public bool __Result;
		}

		// Token: 0x0200091A RID: 2330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetSubPaths_FunctionParams
		{
			// Token: 0x04005805 RID: 22533
			[FieldOffset(0)]
			public FString InBasePath;

			// Token: 0x04005806 RID: 22534
			[FieldOffset(16)]
			public byte OutPathList;

			// Token: 0x04005807 RID: 22535
			[FieldOffset(32)]
			public bool bInRecurse;
		}

		// Token: 0x0200091B RID: 2331
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByPath_FunctionParams
		{
			// Token: 0x04005808 RID: 22536
			[FieldOffset(0)]
			public FName PackagePath;

			// Token: 0x04005809 RID: 22537
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x0400580A RID: 22538
			[FieldOffset(32)]
			public bool bRecursive;

			// Token: 0x0400580B RID: 22539
			[FieldOffset(33)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x0400580C RID: 22540
			[FieldOffset(34)]
			public bool __Result;
		}

		// Token: 0x0200091C RID: 2332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByPackageName_FunctionParams
		{
			// Token: 0x0400580D RID: 22541
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x0400580E RID: 22542
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x0400580F RID: 22543
			[FieldOffset(32)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x04005810 RID: 22544
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x0200091D RID: 2333
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByClass_FunctionParams
		{
			// Token: 0x04005811 RID: 22545
			[FieldOffset(0)]
			public FName ClassName;

			// Token: 0x04005812 RID: 22546
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x04005813 RID: 22547
			[FieldOffset(32)]
			public bool bSearchSubClasses;

			// Token: 0x04005814 RID: 22548
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x0200091E RID: 2334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected ref struct __GetAssets_FunctionParams
		{
			// Token: 0x04005815 RID: 22549
			[FieldOffset(0)]
			public byte Filter;

			// Token: 0x04005816 RID: 22550
			[FieldOffset(240)]
			public byte OutAssetData;

			// Token: 0x04005817 RID: 22551
			[FieldOffset(256)]
			public bool __Result;
		}

		// Token: 0x0200091F RID: 2335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetAssetByObjectPath_FunctionParams
		{
			// Token: 0x04005818 RID: 22552
			[FieldOffset(0)]
			public FName ObjectPath;

			// Token: 0x04005819 RID: 22553
			[FieldOffset(12)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x0400581A RID: 22554
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02000920 RID: 2336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllCachedPaths_FunctionParams
		{
			// Token: 0x0400581B RID: 22555
			[FieldOffset(0)]
			public byte OutPathList;
		}

		// Token: 0x02000921 RID: 2337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllAssets_FunctionParams
		{
			// Token: 0x0400581C RID: 22556
			[FieldOffset(0)]
			public byte OutAssetData;

			// Token: 0x0400581D RID: 22557
			[FieldOffset(16)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x0400581E RID: 22558
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
