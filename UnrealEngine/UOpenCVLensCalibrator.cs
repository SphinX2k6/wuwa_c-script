using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002625 RID: 9765
	[UnrealObjectPath("/Script/OpenCVLensCalibration.OpenCVLensCalibrator")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UOpenCVLensCalibrator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060244E5 RID: 148709 RVA: 0x0035BFAB File Offset: 0x0035A1AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpenCVLensCalibrator._ClassPtr;
		}

		// Token: 0x060244E6 RID: 148710 RVA: 0x0035BFB8 File Offset: 0x0035A1B8
		public UOpenCVLensCalibrator() : this(BuiltinUtils.AllocNativeUObject(UOpenCVLensCalibrator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060244E7 RID: 148711 RVA: 0x0035BFE0 File Offset: 0x0035A1E0
		[NullableContext(1)]
		public UOpenCVLensCalibrator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpenCVLensCalibrator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BCF RID: 35791
		// (get) Token: 0x060244E8 RID: 148712 RVA: 0x0035C013 File Offset: 0x0035A213
		// (set) Token: 0x060244E9 RID: 148713 RVA: 0x0035C027 File Offset: 0x0035A227
		public unsafe FVector2D MinimumCornerCoordinates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenCVLensCalibrator.__PropertyOffset_MinimumCornerCoordinates);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenCVLensCalibrator.__PropertyOffset_MinimumCornerCoordinates) = value;
			}
		}

		// Token: 0x17008BD0 RID: 35792
		// (get) Token: 0x060244EA RID: 148714 RVA: 0x0035C03C File Offset: 0x0035A23C
		// (set) Token: 0x060244EB RID: 148715 RVA: 0x0035C050 File Offset: 0x0035A250
		public unsafe FVector2D MaximumCornerCoordinates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpenCVLensCalibrator.__PropertyOffset_MaximumCornerCoordinates);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpenCVLensCalibrator.__PropertyOffset_MaximumCornerCoordinates) = value;
			}
		}

		// Token: 0x060244EC RID: 148716 RVA: 0x0035C068 File Offset: 0x0035A268
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool FeedRenderTarget(UTextureRenderTarget2D TextureRenderTarget)
		{
			UOpenCVLensCalibrator.__FeedRenderTarget_FunctionParams* ptr = stackalloc UOpenCVLensCalibrator.__FeedRenderTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UOpenCVLensCalibrator.__FeedRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensCalibrator.__FeedRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TextureRenderTarget = ((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UOpenCVLensCalibrator.__FeedRenderTarget_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060244ED RID: 148717 RVA: 0x0035C0C4 File Offset: 0x0035A2C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool FeedImage(string FilePath)
		{
			UOpenCVLensCalibrator.__FeedImage_FunctionParams* ptr = stackalloc UOpenCVLensCalibrator.__FeedImage_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UOpenCVLensCalibrator.__FeedImage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensCalibrator.__FeedImage_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UOpenCVLensCalibrator.__FeedImage_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UOpenCVLensCalibrator.__FeedImage_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060244EE RID: 148718 RVA: 0x0035C128 File Offset: 0x0035A328
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UOpenCVLensCalibrator CreateCalibrator(int BoardWidth = 7, int BoardHeight = 5, float SquareSize = 3f, bool bUseFisheyeModel = false)
		{
			UOpenCVLensCalibrator.__CreateCalibrator_FunctionParams* ptr = stackalloc UOpenCVLensCalibrator.__CreateCalibrator_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UOpenCVLensCalibrator.__CreateCalibrator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensCalibrator.__CreateCalibrator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoardWidth = BoardWidth;
			ptr->BoardHeight = BoardHeight;
			ptr->SquareSize = SquareSize;
			ptr->bUseFisheyeModel = bUseFisheyeModel;
			UnrealReflectionUtils.CallUFunction(UOpenCVLensCalibrator._ClassDefaultObjectPtr, UOpenCVLensCalibrator.__CreateCalibrator_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOpenCVLensCalibrator>(ptr->__Result);
		}

		// Token: 0x060244EF RID: 148719 RVA: 0x0035C190 File Offset: 0x0035A390
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool CalculateLensParameters(ref FOpenCVLensDistortionParameters LensDistortionParameters, ref float MarginOfError, ref FOpenCVCameraViewInfo CameraViewInfo)
		{
			UOpenCVLensCalibrator.__CalculateLensParameters_FunctionParams* ptr = stackalloc UOpenCVLensCalibrator.__CalculateLensParameters_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UOpenCVLensCalibrator.__CalculateLensParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOpenCVLensCalibrator.__CalculateLensParameters_NativeFunctionPtr, (void*)ptr, 1);
			if (LensDistortionParameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), &ptr->LensDistortionParameters, LensDistortionParameters.NativePtr, 1, false);
			}
			ptr->MarginOfError = MarginOfError;
			if (CameraViewInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVCameraViewInfo.StaticStruct(), &ptr->CameraViewInfo, CameraViewInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UOpenCVLensCalibrator.__CalculateLensParameters_NativeFunctionPtr, (void*)ptr, 0);
			if (LensDistortionParameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVLensDistortionParameters.StaticStruct(), LensDistortionParameters.NativePtr, &ptr->LensDistortionParameters, 1, false);
			}
			MarginOfError = ptr->MarginOfError;
			if (CameraViewInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpenCVCameraViewInfo.StaticStruct(), CameraViewInfo.NativePtr, &ptr->CameraViewInfo, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x060244F0 RID: 148720 RVA: 0x0035C276 File Offset: 0x0035A476
		static UOpenCVLensCalibrator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpenCVLensCalibration.OpenCVLensCalibrator");
		}

		// Token: 0x060244F1 RID: 148721 RVA: 0x0035C284 File Offset: 0x0035A484
		protected UOpenCVLensCalibrator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401379C RID: 79772
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OpenCVLensCalibration.OpenCVLensCalibrator";

		// Token: 0x0401379D RID: 79773
		private static IntPtr _ClassPtr;

		// Token: 0x0401379E RID: 79774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401379F RID: 79775
		internal static int __PropertyOffset_MinimumCornerCoordinates;

		// Token: 0x040137A0 RID: 79776
		internal static int __PropertyOffset_MaximumCornerCoordinates;

		// Token: 0x040137A1 RID: 79777
		private static IntPtr __FeedRenderTarget_NativeFunctionPtr;

		// Token: 0x040137A2 RID: 79778
		private static IntPtr __FeedImage_NativeFunctionPtr;

		// Token: 0x040137A3 RID: 79779
		private static IntPtr __CreateCalibrator_NativeFunctionPtr;

		// Token: 0x040137A4 RID: 79780
		private static IntPtr __CalculateLensParameters_NativeFunctionPtr;

		// Token: 0x02003681 RID: 13953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FeedRenderTarget_FunctionParams
		{
			// Token: 0x0401775B RID: 96091
			[FieldOffset(0)]
			public IntPtr TextureRenderTarget;

			// Token: 0x0401775C RID: 96092
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02003682 RID: 13954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FeedImage_FunctionParams
		{
			// Token: 0x0401775D RID: 96093
			[FieldOffset(0)]
			public FString FilePath;

			// Token: 0x0401775E RID: 96094
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003683 RID: 13955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CreateCalibrator_FunctionParams
		{
			// Token: 0x0401775F RID: 96095
			[FieldOffset(0)]
			public int BoardWidth;

			// Token: 0x04017760 RID: 96096
			[FieldOffset(4)]
			public int BoardHeight;

			// Token: 0x04017761 RID: 96097
			[FieldOffset(8)]
			public float SquareSize;

			// Token: 0x04017762 RID: 96098
			[FieldOffset(12)]
			public bool bUseFisheyeModel;

			// Token: 0x04017763 RID: 96099
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003684 RID: 13956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __CalculateLensParameters_FunctionParams
		{
			// Token: 0x04017764 RID: 96100
			[FieldOffset(0)]
			public byte LensDistortionParameters;

			// Token: 0x04017765 RID: 96101
			[FieldOffset(52)]
			public float MarginOfError;

			// Token: 0x04017766 RID: 96102
			[FieldOffset(56)]
			public byte CameraViewInfo;

			// Token: 0x04017767 RID: 96103
			[FieldOffset(68)]
			public bool __Result;
		}
	}
}
