using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002294 RID: 8852
	[UnrealObjectPath("/Script/MediaAssets.MediaBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021A08 RID: 137736 RVA: 0x0031BF79 File Offset: 0x0031A179
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06021A09 RID: 137737 RVA: 0x0031BF88 File Offset: 0x0031A188
		public UMediaBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UMediaBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021A0A RID: 137738 RVA: 0x0031BFB0 File Offset: 0x0031A1B0
		[NullableContext(1)]
		public UMediaBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021A0B RID: 137739 RVA: 0x0031BFE4 File Offset: 0x0031A1E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnumerateWebcamCaptureDevices([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_FunctionParams* ptr = stackalloc UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FMediaCaptureDevice> tarray = OutDevices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutDevices);
			}
			ptr->Filter = Filter;
			UnrealReflectionUtils.CallUFunction(UMediaBlueprintFunctionLibrary._ClassDefaultObjectPtr, UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FMediaCaptureDevice> tarray2 = OutDevices;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutDevices);
			}
			UnrealReflectionUtils.DestroyStruct(UMediaBlueprintFunctionLibrary.__EnumerateWebcamCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021A0C RID: 137740 RVA: 0x0031C064 File Offset: 0x0031A264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnumerateVideoCaptureDevices([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_FunctionParams* ptr = stackalloc UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FMediaCaptureDevice> tarray = OutDevices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutDevices);
			}
			ptr->Filter = Filter;
			UnrealReflectionUtils.CallUFunction(UMediaBlueprintFunctionLibrary._ClassDefaultObjectPtr, UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FMediaCaptureDevice> tarray2 = OutDevices;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutDevices);
			}
			UnrealReflectionUtils.DestroyStruct(UMediaBlueprintFunctionLibrary.__EnumerateVideoCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021A0D RID: 137741 RVA: 0x0031C0E4 File Offset: 0x0031A2E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void EnumerateAudioCaptureDevices([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_FunctionParams* ptr = stackalloc UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FMediaCaptureDevice> tarray = OutDevices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutDevices);
			}
			ptr->Filter = Filter;
			UnrealReflectionUtils.CallUFunction(UMediaBlueprintFunctionLibrary._ClassDefaultObjectPtr, UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FMediaCaptureDevice> tarray2 = OutDevices;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutDevices);
			}
			UnrealReflectionUtils.DestroyStruct(UMediaBlueprintFunctionLibrary.__EnumerateAudioCaptureDevices_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021A0E RID: 137742 RVA: 0x0031C163 File Offset: 0x0031A363
		static UMediaBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaBlueprintFunctionLibrary");
		}

		// Token: 0x06021A0F RID: 137743 RVA: 0x0031C171 File Offset: 0x0031A371
		protected UMediaBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F65 RID: 73573
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaBlueprintFunctionLibrary";

		// Token: 0x04011F66 RID: 73574
		private static IntPtr _ClassPtr;

		// Token: 0x04011F67 RID: 73575
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F68 RID: 73576
		private static IntPtr __EnumerateWebcamCaptureDevices_NativeFunctionPtr;

		// Token: 0x04011F69 RID: 73577
		private static IntPtr __EnumerateVideoCaptureDevices_NativeFunctionPtr;

		// Token: 0x04011F6A RID: 73578
		private static IntPtr __EnumerateAudioCaptureDevices_NativeFunctionPtr;

		// Token: 0x0200360E RID: 13838
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EnumerateWebcamCaptureDevices_FunctionParams
		{
			// Token: 0x0401769B RID: 95899
			[FieldOffset(0)]
			public byte OutDevices;

			// Token: 0x0401769C RID: 95900
			[FieldOffset(16)]
			public int Filter;
		}

		// Token: 0x0200360F RID: 13839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EnumerateVideoCaptureDevices_FunctionParams
		{
			// Token: 0x0401769D RID: 95901
			[FieldOffset(0)]
			public byte OutDevices;

			// Token: 0x0401769E RID: 95902
			[FieldOffset(16)]
			public int Filter;
		}

		// Token: 0x02003610 RID: 13840
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EnumerateAudioCaptureDevices_FunctionParams
		{
			// Token: 0x0401769F RID: 95903
			[FieldOffset(0)]
			public byte OutDevices;

			// Token: 0x040176A0 RID: 95904
			[FieldOffset(16)]
			public int Filter;
		}
	}
}
