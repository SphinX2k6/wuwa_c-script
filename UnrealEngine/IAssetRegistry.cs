using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035D RID: 861
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistry")]
	public interface IAssetRegistry : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06002FC7 RID: 12231
		int InterfaceOffset();

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00049392 File Offset: 0x00047592
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void WaitForCompletion()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__WaitForCompletion_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x000493A8 File Offset: 0x000475A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__UseFilterToExcludeAssets_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = AssetDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetDataList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__UseFilterToExcludeAssets_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00049448 File Offset: 0x00047648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SearchAllAssets(bool bSynchronousSearch)
		{
			IAssetRegistry.__SearchAllAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__SearchAllAssets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IAssetRegistry.__SearchAllAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__SearchAllAssets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSynchronousSearch = bSynchronousSearch;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__SearchAllAssets_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00049490 File Offset: 0x00047690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanPathsSynchronous_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = InPaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InPaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanPathsSynchronous_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00049520 File Offset: 0x00047720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanModifiedAssetFiles_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = InFilePaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InFilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanModifiedAssetFiles_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0004959C File Offset: 0x0004779C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__ScanFilesSynchronous_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = InFilePaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InFilePaths);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__ScanFilesSynchronous_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0004961C File Offset: 0x0004781C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__RunAssetsThroughFilter_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = AssetDataList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetDataList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__RunAssetsThroughFilter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000496BC File Offset: 0x000478BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void PrioritizeSearchPath(string PathToPrioritize)
		{
			IAssetRegistry.__PrioritizeSearchPath_FunctionParams* ptr = stackalloc IAssetRegistry.__PrioritizeSearchPath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__PrioritizeSearchPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PathToPrioritize), PathToPrioritize);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__PrioritizeSearchPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0004971C File Offset: 0x0004791C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__K2_GetReferencers_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = OutReferencers;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutReferencers);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetReferencers_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000497C8 File Offset: 0x000479C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__K2_GetDependencies_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = OutDependencies;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutDependencies);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__K2_GetDependencies_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00049874 File Offset: 0x00047A74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsPathsForceScanned_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = InPaths;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InPaths);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathsForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000498F4 File Offset: 0x00047AF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsPathForceScanned(string InPath)
		{
			IAssetRegistry.__IsPathForceScanned_FunctionParams* ptr = stackalloc IAssetRegistry.__IsPathForceScanned_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__IsPathForceScanned_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InPath), InPath);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsPathForceScanned_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00049958 File Offset: 0x00047B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsLoadingAssets()
		{
			IAssetRegistry.__IsLoadingAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__IsLoadingAssets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IAssetRegistry.__IsLoadingAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsLoadingAssets_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsLoadingAssets_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x000499A0 File Offset: 0x00047BA0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsAssetPathLoaded(ref string Path)
		{
			IAssetRegistry.__IsAssetPathLoaded_FunctionParams* ptr = stackalloc IAssetRegistry.__IsAssetPathLoaded_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IAssetRegistry.__IsAssetPathLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr, 0);
			Path = FString.ToString((void*)(&ptr->Path));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__IsAssetPathLoaded_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00049A14 File Offset: 0x00047C14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasAssets(FName PackagePath, bool bRecursive = false)
		{
			IAssetRegistry.__HasAssets_FunctionParams* ptr = stackalloc IAssetRegistry.__HasAssets_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IAssetRegistry.__HasAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__HasAssets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PackagePath = PackagePath;
			ptr->bRecursive = bRecursive;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__HasAssets_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00049A68 File Offset: 0x00047C68
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetSubPaths_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutPathList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPathList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetSubPaths_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00049AF8 File Offset: 0x00047CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPath_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPath_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00049B90 File Offset: 0x00047D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPackageName_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByPackageName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00049C20 File Offset: 0x00047E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetsByClass_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetsByClass_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00049CB0 File Offset: 0x00047EB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssets_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssets_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00049D58 File Offset: 0x00047F58
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false)
		{
			IAssetRegistry.__GetAssetByObjectPath_FunctionParams* ptr = stackalloc IAssetRegistry.__GetAssetByObjectPath_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(IAssetRegistry.__GetAssetByObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ObjectPath = ObjectPath;
			ptr->bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			FAssetData result = new FAssetData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAssetByObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00049DC8 File Offset: 0x00047FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAllCachedPaths_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutPathList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPathList);
			}
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllCachedPaths_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00049E44 File Offset: 0x00048044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IAssetRegistry_ReflectionImplementationFields.__GetAllAssets_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAssetData> tarray2 = OutAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutAssetData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IAssetRegistry_ReflectionImplementationFields.__GetAllAssets_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x040014BE RID: 5310
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AssetRegistry.AssetRegistry";

		// Token: 0x02002BDB RID: 11227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __UseFilterToExcludeAssets_FunctionParams
		{
			// Token: 0x040164A7 RID: 91303
			[FieldOffset(0)]
			public byte AssetDataList;

			// Token: 0x040164A8 RID: 91304
			[FieldOffset(16)]
			public byte Filter;
		}

		// Token: 0x02002BDC RID: 11228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SearchAllAssets_FunctionParams
		{
			// Token: 0x040164A9 RID: 91305
			[FieldOffset(0)]
			public bool bSynchronousSearch;
		}

		// Token: 0x02002BDD RID: 11229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ScanPathsSynchronous_FunctionParams
		{
			// Token: 0x040164AA RID: 91306
			[FieldOffset(0)]
			public byte InPaths;

			// Token: 0x040164AB RID: 91307
			[FieldOffset(16)]
			public bool bForceRescan;

			// Token: 0x040164AC RID: 91308
			[FieldOffset(17)]
			public bool bIgnoreBlackListScanFilters;

			// Token: 0x040164AD RID: 91309
			[FieldOffset(18)]
			public bool bUseParallelScan;
		}

		// Token: 0x02002BDE RID: 11230
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ScanModifiedAssetFiles_FunctionParams
		{
			// Token: 0x040164AE RID: 91310
			[FieldOffset(0)]
			public byte InFilePaths;
		}

		// Token: 0x02002BDF RID: 11231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ScanFilesSynchronous_FunctionParams
		{
			// Token: 0x040164AF RID: 91311
			[FieldOffset(0)]
			public byte InFilePaths;

			// Token: 0x040164B0 RID: 91312
			[FieldOffset(16)]
			public bool bForceRescan;
		}

		// Token: 0x02002BE0 RID: 11232
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __RunAssetsThroughFilter_FunctionParams
		{
			// Token: 0x040164B1 RID: 91313
			[FieldOffset(0)]
			public byte AssetDataList;

			// Token: 0x040164B2 RID: 91314
			[FieldOffset(16)]
			public byte Filter;
		}

		// Token: 0x02002BE1 RID: 11233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PrioritizeSearchPath_FunctionParams
		{
			// Token: 0x040164B3 RID: 91315
			[FieldOffset(0)]
			public FString PathToPrioritize;
		}

		// Token: 0x02002BE2 RID: 11234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __K2_GetReferencers_FunctionParams
		{
			// Token: 0x040164B4 RID: 91316
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x040164B5 RID: 91317
			[FieldOffset(12)]
			public byte ReferenceOptions;

			// Token: 0x040164B6 RID: 91318
			[FieldOffset(24)]
			public byte OutReferencers;

			// Token: 0x040164B7 RID: 91319
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02002BE3 RID: 11235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __K2_GetDependencies_FunctionParams
		{
			// Token: 0x040164B8 RID: 91320
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x040164B9 RID: 91321
			[FieldOffset(12)]
			public byte DependencyOptions;

			// Token: 0x040164BA RID: 91322
			[FieldOffset(24)]
			public byte OutDependencies;

			// Token: 0x040164BB RID: 91323
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02002BE4 RID: 11236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsPathsForceScanned_FunctionParams
		{
			// Token: 0x040164BC RID: 91324
			[FieldOffset(0)]
			public byte InPaths;

			// Token: 0x040164BD RID: 91325
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002BE5 RID: 11237
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsPathForceScanned_FunctionParams
		{
			// Token: 0x040164BE RID: 91326
			[FieldOffset(0)]
			public FString InPath;

			// Token: 0x040164BF RID: 91327
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002BE6 RID: 11238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLoadingAssets_FunctionParams
		{
			// Token: 0x040164C0 RID: 91328
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002BE7 RID: 11239
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __IsAssetPathLoaded_FunctionParams
		{
			// Token: 0x040164C1 RID: 91329
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x040164C2 RID: 91330
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002BE8 RID: 11240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __HasAssets_FunctionParams
		{
			// Token: 0x040164C3 RID: 91331
			[FieldOffset(0)]
			public FName PackagePath;

			// Token: 0x040164C4 RID: 91332
			[FieldOffset(12)]
			public bool bRecursive;

			// Token: 0x040164C5 RID: 91333
			[FieldOffset(13)]
			public bool __Result;
		}

		// Token: 0x02002BE9 RID: 11241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetSubPaths_FunctionParams
		{
			// Token: 0x040164C6 RID: 91334
			[FieldOffset(0)]
			public FString InBasePath;

			// Token: 0x040164C7 RID: 91335
			[FieldOffset(16)]
			public byte OutPathList;

			// Token: 0x040164C8 RID: 91336
			[FieldOffset(32)]
			public bool bInRecurse;
		}

		// Token: 0x02002BEA RID: 11242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByPath_FunctionParams
		{
			// Token: 0x040164C9 RID: 91337
			[FieldOffset(0)]
			public FName PackagePath;

			// Token: 0x040164CA RID: 91338
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x040164CB RID: 91339
			[FieldOffset(32)]
			public bool bRecursive;

			// Token: 0x040164CC RID: 91340
			[FieldOffset(33)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x040164CD RID: 91341
			[FieldOffset(34)]
			public bool __Result;
		}

		// Token: 0x02002BEB RID: 11243
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByPackageName_FunctionParams
		{
			// Token: 0x040164CE RID: 91342
			[FieldOffset(0)]
			public FName PackageName;

			// Token: 0x040164CF RID: 91343
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x040164D0 RID: 91344
			[FieldOffset(32)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x040164D1 RID: 91345
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x02002BEC RID: 11244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetAssetsByClass_FunctionParams
		{
			// Token: 0x040164D2 RID: 91346
			[FieldOffset(0)]
			public FName ClassName;

			// Token: 0x040164D3 RID: 91347
			[FieldOffset(16)]
			public byte OutAssetData;

			// Token: 0x040164D4 RID: 91348
			[FieldOffset(32)]
			public bool bSearchSubClasses;

			// Token: 0x040164D5 RID: 91349
			[FieldOffset(33)]
			public bool __Result;
		}

		// Token: 0x02002BED RID: 11245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected ref struct __GetAssets_FunctionParams
		{
			// Token: 0x040164D6 RID: 91350
			[FieldOffset(0)]
			public byte Filter;

			// Token: 0x040164D7 RID: 91351
			[FieldOffset(240)]
			public byte OutAssetData;

			// Token: 0x040164D8 RID: 91352
			[FieldOffset(256)]
			public bool __Result;
		}

		// Token: 0x02002BEE RID: 11246
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetAssetByObjectPath_FunctionParams
		{
			// Token: 0x040164D9 RID: 91353
			[FieldOffset(0)]
			public FName ObjectPath;

			// Token: 0x040164DA RID: 91354
			[FieldOffset(12)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x040164DB RID: 91355
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02002BEF RID: 11247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllCachedPaths_FunctionParams
		{
			// Token: 0x040164DC RID: 91356
			[FieldOffset(0)]
			public byte OutPathList;
		}

		// Token: 0x02002BF0 RID: 11248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAllAssets_FunctionParams
		{
			// Token: 0x040164DD RID: 91357
			[FieldOffset(0)]
			public byte OutAssetData;

			// Token: 0x040164DE RID: 91358
			[FieldOffset(16)]
			public bool bIncludeOnlyOnDiskAssets;

			// Token: 0x040164DF RID: 91359
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
