using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013DC RID: 5084
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagAssetInterface")]
	public interface IGameplayTagAssetInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06012987 RID: 76167
		int InterfaceOffset();

		// Token: 0x06012988 RID: 76168 RVA: 0x001B5C68 File Offset: 0x001B3E68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasMatchingGameplayTag(FGameplayTag TagToCheck)
		{
			IGameplayTagAssetInterface.__HasMatchingGameplayTag_FunctionParams* ptr = stackalloc IGameplayTagAssetInterface.__HasMatchingGameplayTag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IGameplayTagAssetInterface.__HasMatchingGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__HasMatchingGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TagToCheck = TagToCheck;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGameplayTagAssetInterface_ReflectionImplementationFields.__HasMatchingGameplayTag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x001B5CB8 File Offset: 0x001B3EB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasAnyMatchingGameplayTags(in FGameplayTagContainer TagContainer)
		{
			IGameplayTagAssetInterface.__HasAnyMatchingGameplayTags_FunctionParams* ptr = stackalloc IGameplayTagAssetInterface.__HasAnyMatchingGameplayTags_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IGameplayTagAssetInterface.__HasAnyMatchingGameplayTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAnyMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
			if (TagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->TagContainer, TagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAnyMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAnyMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601298A RID: 76170 RVA: 0x001B5D34 File Offset: 0x001B3F34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool HasAllMatchingGameplayTags(in FGameplayTagContainer TagContainer)
		{
			IGameplayTagAssetInterface.__HasAllMatchingGameplayTags_FunctionParams* ptr = stackalloc IGameplayTagAssetInterface.__HasAllMatchingGameplayTags_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(IGameplayTagAssetInterface.__HasAllMatchingGameplayTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAllMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
			if (TagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->TagContainer, TagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAllMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__HasAllMatchingGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601298B RID: 76171 RVA: 0x001B5DB0 File Offset: 0x001B3FB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetOwnedGameplayTags(ref FGameplayTagContainer TagContainer)
		{
			IGameplayTagAssetInterface.__GetOwnedGameplayTags_FunctionParams* ptr = stackalloc IGameplayTagAssetInterface.__GetOwnedGameplayTags_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IGameplayTagAssetInterface.__GetOwnedGameplayTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__GetOwnedGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
			if (TagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->TagContainer, TagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IGameplayTagAssetInterface_ReflectionImplementationFields.__GetOwnedGameplayTags_NativeFunctionPtr, (void*)ptr, 0);
			if (TagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), TagContainer.NativePtr, &ptr->TagContainer, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(IGameplayTagAssetInterface_ReflectionImplementationFields.__GetOwnedGameplayTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x04009EFE RID: 40702
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagAssetInterface";

		// Token: 0x02002E6F RID: 11887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __HasMatchingGameplayTag_FunctionParams
		{
			// Token: 0x04016933 RID: 92467
			[FieldOffset(0)]
			public FGameplayTag TagToCheck;

			// Token: 0x04016934 RID: 92468
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02002E70 RID: 11888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAnyMatchingGameplayTags_FunctionParams
		{
			// Token: 0x04016935 RID: 92469
			[FieldOffset(0)]
			public byte TagContainer;

			// Token: 0x04016936 RID: 92470
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02002E71 RID: 11889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAllMatchingGameplayTags_FunctionParams
		{
			// Token: 0x04016937 RID: 92471
			[FieldOffset(0)]
			public byte TagContainer;

			// Token: 0x04016938 RID: 92472
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02002E72 RID: 11890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetOwnedGameplayTags_FunctionParams
		{
			// Token: 0x04016939 RID: 92473
			[FieldOffset(0)]
			public byte TagContainer;
		}
	}
}
