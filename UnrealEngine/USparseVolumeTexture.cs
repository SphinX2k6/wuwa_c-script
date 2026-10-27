using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001163 RID: 4451
	[UnrealObjectPath("/Script/Engine.SparseVolumeTexture")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USparseVolumeTexture : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601043E RID: 66622 RVA: 0x0017F5BC File Offset: 0x0017D7BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USparseVolumeTexture._ClassPtr;
		}

		// Token: 0x0601043F RID: 66623 RVA: 0x0017F5C8 File Offset: 0x0017D7C8
		public USparseVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010440 RID: 66624 RVA: 0x0017F5F0 File Offset: 0x0017D7F0
		[NullableContext(1)]
		public USparseVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010441 RID: 66625 RVA: 0x0017F624 File Offset: 0x0017D824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetSizeZ()
		{
			USparseVolumeTexture.__GetSizeZ_FunctionParams* ptr = stackalloc USparseVolumeTexture.__GetSizeZ_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USparseVolumeTexture.__GetSizeZ_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USparseVolumeTexture.__GetSizeZ_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USparseVolumeTexture.__GetSizeZ_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010442 RID: 66626 RVA: 0x0017F66C File Offset: 0x0017D86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetSizeY()
		{
			USparseVolumeTexture.__GetSizeY_FunctionParams* ptr = stackalloc USparseVolumeTexture.__GetSizeY_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USparseVolumeTexture.__GetSizeY_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USparseVolumeTexture.__GetSizeY_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USparseVolumeTexture.__GetSizeY_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010443 RID: 66627 RVA: 0x0017F6B4 File Offset: 0x0017D8B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetSizeX()
		{
			USparseVolumeTexture.__GetSizeX_FunctionParams* ptr = stackalloc USparseVolumeTexture.__GetSizeX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USparseVolumeTexture.__GetSizeX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USparseVolumeTexture.__GetSizeX_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USparseVolumeTexture.__GetSizeX_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010444 RID: 66628 RVA: 0x0017F6FC File Offset: 0x0017D8FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetNumMipLevels()
		{
			USparseVolumeTexture.__GetNumMipLevels_FunctionParams* ptr = stackalloc USparseVolumeTexture.__GetNumMipLevels_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USparseVolumeTexture.__GetNumMipLevels_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USparseVolumeTexture.__GetNumMipLevels_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USparseVolumeTexture.__GetNumMipLevels_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010445 RID: 66629 RVA: 0x0017F744 File Offset: 0x0017D944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetNumFrames()
		{
			USparseVolumeTexture.__GetNumFrames_FunctionParams* ptr = stackalloc USparseVolumeTexture.__GetNumFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USparseVolumeTexture.__GetNumFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USparseVolumeTexture.__GetNumFrames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USparseVolumeTexture.__GetNumFrames_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06010446 RID: 66630 RVA: 0x0017F78A File Offset: 0x0017D98A
		static USparseVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SparseVolumeTexture");
		}

		// Token: 0x06010447 RID: 66631 RVA: 0x0017F798 File Offset: 0x0017D998
		protected USparseVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008BFE RID: 35838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SparseVolumeTexture";

		// Token: 0x04008BFF RID: 35839
		private static IntPtr _ClassPtr;

		// Token: 0x04008C00 RID: 35840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C01 RID: 35841
		private static IntPtr __GetSizeZ_NativeFunctionPtr;

		// Token: 0x04008C02 RID: 35842
		private static IntPtr __GetSizeY_NativeFunctionPtr;

		// Token: 0x04008C03 RID: 35843
		private static IntPtr __GetSizeX_NativeFunctionPtr;

		// Token: 0x04008C04 RID: 35844
		private static IntPtr __GetNumMipLevels_NativeFunctionPtr;

		// Token: 0x04008C05 RID: 35845
		private static IntPtr __GetNumFrames_NativeFunctionPtr;

		// Token: 0x02002DDF RID: 11743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSizeZ_FunctionParams
		{
			// Token: 0x04016822 RID: 92194
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DE0 RID: 11744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSizeY_FunctionParams
		{
			// Token: 0x04016823 RID: 92195
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DE1 RID: 11745
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSizeX_FunctionParams
		{
			// Token: 0x04016824 RID: 92196
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DE2 RID: 11746
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetNumMipLevels_FunctionParams
		{
			// Token: 0x04016825 RID: 92197
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DE3 RID: 11747
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetNumFrames_FunctionParams
		{
			// Token: 0x04016826 RID: 92198
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
