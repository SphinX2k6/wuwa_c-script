using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D2D RID: 3373
	[UnrealObjectPath("/Script/Engine.LevelInstanceInterface")]
	public interface ILevelInstanceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600B4C5 RID: 46277
		int InterfaceOffset();

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x00101D2E File Offset: 0x000FFF2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void UnloadLevelInstance()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__UnloadLevelInstance_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x00101D44 File Offset: 0x000FFF44
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetWorldAsset(TSoftObjectPtr<UWorld> WorldAsset)
		{
			ILevelInstanceInterface.__SetWorldAsset_FunctionParams* ptr = stackalloc ILevelInstanceInterface.__SetWorldAsset_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(ILevelInstanceInterface.__SetWorldAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILevelInstanceInterface_ReflectionImplementationFields.__SetWorldAsset_NativeFunctionPtr, (void*)ptr, 1);
			if (WorldAsset != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->WorldAsset, WorldAsset.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__SetWorldAsset_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ILevelInstanceInterface_ReflectionImplementationFields.__SetWorldAsset_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00101DB7 File Offset: 0x000FFFB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void LoadLevelInstance()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__LoadLevelInstance_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00101DCC File Offset: 0x000FFFCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsLoaded()
		{
			ILevelInstanceInterface.__IsLoaded_FunctionParams* ptr = stackalloc ILevelInstanceInterface.__IsLoaded_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ILevelInstanceInterface.__IsLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILevelInstanceInterface_ReflectionImplementationFields.__IsLoaded_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__IsLoaded_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x00101E14 File Offset: 0x00100014
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe TSoftObjectPtr<UWorld> GetWorldAsset()
		{
			ILevelInstanceInterface.__GetWorldAsset_FunctionParams* ptr = stackalloc ILevelInstanceInterface.__GetWorldAsset_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ILevelInstanceInterface.__GetWorldAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILevelInstanceInterface_ReflectionImplementationFields.__GetWorldAsset_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__GetWorldAsset_NativeFunctionPtr, (void*)ptr, 0);
			TSoftObjectPtr<UWorld> result = new TSoftObjectPtr<UWorld>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(ILevelInstanceInterface_ReflectionImplementationFields.__GetWorldAsset_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x00101E74 File Offset: 0x00100074
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe ULevel GetLoadedLevel()
		{
			ILevelInstanceInterface.__GetLoadedLevel_FunctionParams* ptr = stackalloc ILevelInstanceInterface.__GetLoadedLevel_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ILevelInstanceInterface.__GetLoadedLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ILevelInstanceInterface_ReflectionImplementationFields.__GetLoadedLevel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ILevelInstanceInterface_ReflectionImplementationFields.__GetLoadedLevel_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(ptr->__Result);
		}

		// Token: 0x04005F0A RID: 24330
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelInstanceInterface";

		// Token: 0x02002D39 RID: 11577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetWorldAsset_FunctionParams
		{
			// Token: 0x0401673B RID: 91963
			[FieldOffset(0)]
			public byte WorldAsset;

			// Token: 0x0401673C RID: 91964
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02002D3A RID: 11578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLoaded_FunctionParams
		{
			// Token: 0x0401673D RID: 91965
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002D3B RID: 11579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetWorldAsset_FunctionParams
		{
			// Token: 0x0401673E RID: 91966
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02002D3C RID: 11580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetLoadedLevel_FunctionParams
		{
			// Token: 0x0401673F RID: 91967
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
