using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002627 RID: 9767
	[UnrealObjectPath("/Script/OpenCVLensDistortion.OpenCVLensDistortionBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOpenCVLensDistortionBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024500 RID: 148736 RVA: 0x0035C36D File Offset: 0x0035A56D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpenCVLensDistortionBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06024501 RID: 148737 RVA: 0x0035C37C File Offset: 0x0035A57C
		public UOpenCVLensDistortionBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UOpenCVLensDistortionBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024502 RID: 148738 RVA: 0x0035C3A4 File Offset: 0x0035A5A4
		[NullableContext(1)]
		public UOpenCVLensDistortionBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpenCVLensDistortionBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024503 RID: 148739 RVA: 0x0035C3D8 File Offset: 0x0035A5D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool NotEqual_CompareLensDistortionModels(in FOpenCVLensDistortionParameters A, in FOpenCVLensDistortionParameters B)
		{
			UOpenCVLensDistortionBlueprintLibrary.__NotEqual_CompareLensDistortionModels_FunctionParams* ptr = stackalloc UOpenCVLensDistortionBlueprintLibrary.__NotEqual_CompareLensDistortionModels_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(UOpenCVLensDistortionBlueprintLibrary.__NotEqual_CompareLensDistortionModels_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensDistortionBlueprintLibrary.__NotEqual_CompareLensDistortionModels_NativeFunctionPtr, (void*)ptr, 1);
			if (A != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->A, A.NativePtr, 1, false);
			}
			if (B != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->B, B.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UOpenCVLensDistortionBlueprintLibrary._ClassDefaultObjectPtr, UOpenCVLensDistortionBlueprintLibrary.__NotEqual_CompareLensDistortionModels_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06024504 RID: 148740 RVA: 0x0035C468 File Offset: 0x0035A668
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool EqualEqual_CompareLensDistortionModels(in FOpenCVLensDistortionParameters A, in FOpenCVLensDistortionParameters B)
		{
			UOpenCVLensDistortionBlueprintLibrary.__EqualEqual_CompareLensDistortionModels_FunctionParams* ptr = stackalloc UOpenCVLensDistortionBlueprintLibrary.__EqualEqual_CompareLensDistortionModels_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(UOpenCVLensDistortionBlueprintLibrary.__EqualEqual_CompareLensDistortionModels_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensDistortionBlueprintLibrary.__EqualEqual_CompareLensDistortionModels_NativeFunctionPtr, (void*)ptr, 1);
			if (A != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->A, A.NativePtr, 1, false);
			}
			if (B != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->B, B.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UOpenCVLensDistortionBlueprintLibrary._ClassDefaultObjectPtr, UOpenCVLensDistortionBlueprintLibrary.__EqualEqual_CompareLensDistortionModels_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06024505 RID: 148741 RVA: 0x0035C4F8 File Offset: 0x0035A6F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DrawDisplacementMapToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D OutputRenderTarget, UTexture2D PreComputedUndistortDisplacementMap)
		{
			UOpenCVLensDistortionBlueprintLibrary.__DrawDisplacementMapToRenderTarget_FunctionParams* ptr = stackalloc UOpenCVLensDistortionBlueprintLibrary.__DrawDisplacementMapToRenderTarget_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UOpenCVLensDistortionBlueprintLibrary.__DrawDisplacementMapToRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensDistortionBlueprintLibrary.__DrawDisplacementMapToRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->OutputRenderTarget = ((OutputRenderTarget != null) ? OutputRenderTarget.NativePtr : IntPtr.Zero);
			ptr->PreComputedUndistortDisplacementMap = ((PreComputedUndistortDisplacementMap != null) ? PreComputedUndistortDisplacementMap.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UOpenCVLensDistortionBlueprintLibrary._ClassDefaultObjectPtr, UOpenCVLensDistortionBlueprintLibrary.__DrawDisplacementMapToRenderTarget_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024506 RID: 148742 RVA: 0x0035C57C File Offset: 0x0035A77C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UTexture2D CreateUndistortUVDisplacementMap(in FOpenCVLensDistortionParameters LensParameters, in FIntPoint ImageSize, float CroppingFactor, ref FOpenCVCameraViewInfo CameraViewInfo)
		{
			UOpenCVLensDistortionBlueprintLibrary.__CreateUndistortUVDisplacementMap_FunctionParams* ptr = stackalloc UOpenCVLensDistortionBlueprintLibrary.__CreateUndistortUVDisplacementMap_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UOpenCVLensDistortionBlueprintLibrary.__CreateUndistortUVDisplacementMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensDistortionBlueprintLibrary.__CreateUndistortUVDisplacementMap_NativeFunctionPtr, (void*)ptr, 1);
			if (LensParameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->LensParameters, LensParameters.NativePtr, 1, false);
			}
			ptr->ImageSize = ImageSize;
			ptr->CroppingFactor = CroppingFactor;
			if (CameraViewInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVCameraViewInfo.StaticStruct(), &ptr->CameraViewInfo, CameraViewInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UOpenCVLensDistortionBlueprintLibrary._ClassDefaultObjectPtr, UOpenCVLensDistortionBlueprintLibrary.__CreateUndistortUVDisplacementMap_NativeFunctionPtr, (void*)ptr, 0);
			if (CameraViewInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVCameraViewInfo.StaticStruct(), CameraViewInfo.NativePtr, &ptr->CameraViewInfo, 1, false);
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ptr->__Result);
		}

		// Token: 0x06024507 RID: 148743 RVA: 0x0035C645 File Offset: 0x0035A845
		static UOpenCVLensDistortionBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpenCVLensDistortion.OpenCVLensDistortionBlueprintLibrary");
		}

		// Token: 0x06024508 RID: 148744 RVA: 0x0035C653 File Offset: 0x0035A853
		protected UOpenCVLensDistortionBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040137AA RID: 79786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OpenCVLensDistortion.OpenCVLensDistortionBlueprintLibrary";

		// Token: 0x040137AB RID: 79787
		private static IntPtr _ClassPtr;

		// Token: 0x040137AC RID: 79788
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040137AD RID: 79789
		private static IntPtr __NotEqual_CompareLensDistortionModels_NativeFunctionPtr;

		// Token: 0x040137AE RID: 79790
		private static IntPtr __EqualEqual_CompareLensDistortionModels_NativeFunctionPtr;

		// Token: 0x040137AF RID: 79791
		private static IntPtr __DrawDisplacementMapToRenderTarget_NativeFunctionPtr;

		// Token: 0x040137B0 RID: 79792
		private static IntPtr __CreateUndistortUVDisplacementMap_NativeFunctionPtr;

		// Token: 0x02003685 RID: 13957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __NotEqual_CompareLensDistortionModels_FunctionParams
		{
			// Token: 0x04017768 RID: 96104
			[FieldOffset(0)]
			public byte A;

			// Token: 0x04017769 RID: 96105
			[FieldOffset(52)]
			public byte B;

			// Token: 0x0401776A RID: 96106
			[FieldOffset(104)]
			public bool __Result;
		}

		// Token: 0x02003686 RID: 13958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __EqualEqual_CompareLensDistortionModels_FunctionParams
		{
			// Token: 0x0401776B RID: 96107
			[FieldOffset(0)]
			public byte A;

			// Token: 0x0401776C RID: 96108
			[FieldOffset(52)]
			public byte B;

			// Token: 0x0401776D RID: 96109
			[FieldOffset(104)]
			public bool __Result;
		}

		// Token: 0x02003687 RID: 13959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __DrawDisplacementMapToRenderTarget_FunctionParams
		{
			// Token: 0x0401776E RID: 96110
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x0401776F RID: 96111
			[FieldOffset(8)]
			public IntPtr OutputRenderTarget;

			// Token: 0x04017770 RID: 96112
			[FieldOffset(16)]
			public IntPtr PreComputedUndistortDisplacementMap;
		}

		// Token: 0x02003688 RID: 13960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CreateUndistortUVDisplacementMap_FunctionParams
		{
			// Token: 0x04017771 RID: 96113
			[FieldOffset(0)]
			public byte LensParameters;

			// Token: 0x04017772 RID: 96114
			[FieldOffset(52)]
			public FIntPoint ImageSize;

			// Token: 0x04017773 RID: 96115
			[FieldOffset(60)]
			public float CroppingFactor;

			// Token: 0x04017774 RID: 96116
			[FieldOffset(64)]
			public byte CameraViewInfo;

			// Token: 0x04017775 RID: 96117
			[FieldOffset(80)]
			public IntPtr __Result;
		}
	}
}
