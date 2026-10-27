using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000397 RID: 919
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UARBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003277 RID: 12919 RVA: 0x0004DC98 File Offset: 0x0004BE98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		public UARBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UARBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0004DCCC File Offset: 0x0004BECC
		public UARBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0004DCFF File Offset: 0x0004BEFF
		[NullableContext(2)]
		public static void UnpinComponent(USceneComponent ComponentToUnpin)
		{
			UARBlueprintLibrary.__UnpinComponent_Internal((ComponentToUnpin != null) ? ComponentToUnpin.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600327B RID: 12923
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ToggleARCapture(bool bOnOff, EARCaptureType CaptureType);

		// Token: 0x0600327C RID: 12924
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopARSession();

		// Token: 0x0600327D RID: 12925 RVA: 0x0004DD16 File Offset: 0x0004BF16
		[NullableContext(2)]
		public static void StartARSession(UARSessionConfig SessionConfig)
		{
			UARBlueprintLibrary.__StartARSession_Internal((SessionConfig != null) ? SessionConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600327E RID: 12926
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEnabledXRCamera(bool bOnOff);

		// Token: 0x0600327F RID: 12927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetARWorldScale(float InWorldScale);

		// Token: 0x06003280 RID: 12928
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetARWorldOriginLocationAndRotation(FVector OriginLocation, FRotator OriginRotation, bool bIsTransformInWorldSpace = true, bool bMaintainUpDirection = true);

		// Token: 0x06003281 RID: 12929 RVA: 0x0004DD30 File Offset: 0x0004BF30
		public unsafe static void SetAlignmentTransform(in FTransform InAlignmentTransform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InAlignmentTransform;
			UARBlueprintLibrary.__SetAlignmentTransform_Internal(uintPtr);
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x0004DD5D File Offset: 0x0004BF5D
		[NullableContext(2)]
		public static bool SaveARPinToLocalStore(FName InSaveName, UARPin InPin)
		{
			return UARBlueprintLibrary.__SaveARPinToLocalStore_Internal(InSaveName, (InPin != null) ? InPin.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003283 RID: 12931
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint ResizeXRCamera(in FIntPoint InSize);

		// Token: 0x06003284 RID: 12932 RVA: 0x0004DD75 File Offset: 0x0004BF75
		[NullableContext(2)]
		public static void RemovePin(UARPin PinToRemove)
		{
			UARBlueprintLibrary.__RemovePin_Internal((PinToRemove != null) ? PinToRemove.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003285 RID: 12933
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemoveARPinFromLocalStore(FName InSaveName);

		// Token: 0x06003286 RID: 12934
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemoveAllARPinsFromLocalStore();

		// Token: 0x06003287 RID: 12935 RVA: 0x0004DD8C File Offset: 0x0004BF8C
		[NullableContext(2)]
		public static UARPin PinComponentToTraceResult(USceneComponent ComponentToPin, in FARTraceResult TraceResult, FName DebugName = default(FName))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARPin>(UARBlueprintLibrary.__PinComponentToTraceResult_Internal((ComponentToPin != null) ? ComponentToPin.NativePtr : IntPtr.Zero, (TraceResult ?? new FARTraceResult()).NativePtr, DebugName));
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x0004DDB9 File Offset: 0x0004BFB9
		[NullableContext(2)]
		public static bool PinComponentToARPin(USceneComponent ComponentToPin, UARPin Pin)
		{
			return UARBlueprintLibrary.__PinComponentToARPin_Internal((ComponentToPin != null) ? ComponentToPin.NativePtr : IntPtr.Zero, (Pin != null) ? Pin.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		[NullableContext(2)]
		public unsafe static UARPin PinComponent(USceneComponent ComponentToPin, in FTransform PinToWorldTransform, UARTrackedGeometry TrackedGeometry = null, FName DebugName = default(FName))
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = PinToWorldTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARPin>(UARBlueprintLibrary.__PinComponent_Internal((ComponentToPin != null) ? ComponentToPin.NativePtr : IntPtr.Zero, ptr, (TrackedGeometry != null) ? TrackedGeometry.NativePtr : IntPtr.Zero, DebugName));
		}

		// Token: 0x0600328A RID: 12938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PauseARSession();

		// Token: 0x0600328B RID: 12939 RVA: 0x0004DE35 File Offset: 0x0004C035
		public static TMap<FName, UARPin> LoadARPinsFromLocalStore()
		{
			return new TMap<FName, UARPin>(UARBlueprintLibrary.__LoadARPinsFromLocalStore_Internal(), null);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x0004DE42 File Offset: 0x0004C042
		public static TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start, FVector End, bool bTestFeaturePoints = true, bool bTestGroundPlane = true, bool bTestPlaneExtents = true, bool bTestPlaneBoundaryPolygon = true)
		{
			return new TArray<FARTraceResult>(UARBlueprintLibrary.__LineTraceTrackedObjects3D_Internal(Start, End, bTestFeaturePoints, bTestGroundPlane, bTestPlaneExtents, bTestPlaneBoundaryPolygon), null);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0004DE57 File Offset: 0x0004C057
		public static TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord, bool bTestFeaturePoints = true, bool bTestGroundPlane = true, bool bTestPlaneExtents = true, bool bTestPlaneBoundaryPolygon = true)
		{
			return new TArray<FARTraceResult>(UARBlueprintLibrary.__LineTraceTrackedObjects_Internal(ScreenCoord, bTestFeaturePoints, bTestGroundPlane, bTestPlaneExtents, bTestPlaneBoundaryPolygon), null);
		}

		// Token: 0x0600328E RID: 12942
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSessionTypeSupported(EARSessionType SessionType);

		// Token: 0x0600328F RID: 12943
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSessionTrackingFeatureSupported(EARSessionType SessionType, EARSessionTrackingFeature SessionTrackingFeature);

		// Token: 0x06003290 RID: 12944
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSceneReconstructionSupported(EARSessionType SessionType, EARSceneReconstruction SceneReconstructionMethod);

		// Token: 0x06003291 RID: 12945
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsARSupported();

		// Token: 0x06003292 RID: 12946
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsARPinLocalStoreSupported();

		// Token: 0x06003293 RID: 12947
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsARPinLocalStoreReady();

		// Token: 0x06003294 RID: 12948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EARWorldMappingState GetWorldMappingStatus();

		// Token: 0x06003295 RID: 12949
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EARTrackingQualityReason GetTrackingQualityReason();

		// Token: 0x06003296 RID: 12950
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EARTrackingQuality GetTrackingQuality();

		// Token: 0x06003297 RID: 12951 RVA: 0x0004DE6A File Offset: 0x0004C06A
		public static TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType)
		{
			return new TArray<FARVideoFormat>(UARBlueprintLibrary.__GetSupportedVideoFormats_Internal(SessionType), null);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x0004DE78 File Offset: 0x0004C078
		[NullableContext(2)]
		public static UARSessionConfig GetSessionConfig()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARSessionConfig>(UARBlueprintLibrary.__GetSessionConfig_Internal());
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x0004DE84 File Offset: 0x0004C084
		public static TArray<FVector> GetPointCloud()
		{
			return new TArray<FVector>(UARBlueprintLibrary.__GetPointCloud_Internal(), null);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0004DE91 File Offset: 0x0004C091
		[NullableContext(2)]
		public static UARTexture GetPersonSegmentationImage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTexture>(UARBlueprintLibrary.__GetPersonSegmentationImage_Internal());
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x0004DE9D File Offset: 0x0004C09D
		[NullableContext(2)]
		public static UARTexture GetPersonSegmentationDepthImage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTexture>(UARBlueprintLibrary.__GetPersonSegmentationDepthImage_Internal());
		}

		// Token: 0x0600329C RID: 12956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetObjectClassificationAtLocation(in FVector InWorldLocation, ref EARObjectClassification OutClassification, ref FVector OutClassificationLocation, float MaxLocationDiff = 10f);

		// Token: 0x0600329D RID: 12957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumberOfTrackedFacesSupported();

		// Token: 0x0600329E RID: 12958 RVA: 0x0004DEA9 File Offset: 0x0004C0A9
		[NullableContext(2)]
		public static UARLightEstimate GetCurrentLightEstimate()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARLightEstimate>(UARBlueprintLibrary.__GetCurrentLightEstimate_Internal());
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x0004DEB5 File Offset: 0x0004C0B5
		[NullableContext(2)]
		public static bool GetCameraIntrinsics(ref FARCameraIntrinsics OutCameraIntrinsics)
		{
			return UARBlueprintLibrary.__GetCameraIntrinsics_Internal((OutCameraIntrinsics ?? new FARCameraIntrinsics()).NativePtr);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x0004DECC File Offset: 0x0004C0CC
		[NullableContext(2)]
		public static UARTextureCameraImage GetCameraImage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTextureCameraImage>(UARBlueprintLibrary.__GetCameraImage_Internal());
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x0004DED8 File Offset: 0x0004C0D8
		[NullableContext(2)]
		public static UARTextureCameraDepth GetCameraDepth()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTextureCameraDepth>(UARBlueprintLibrary.__GetCameraDepth_Internal());
		}

		// Token: 0x060032A2 RID: 12962
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetARWorldScale();

		// Token: 0x060032A3 RID: 12963 RVA: 0x0004DEE4 File Offset: 0x0004C0E4
		[NullableContext(2)]
		public static UARTexture GetARTexture(EARTextureType TextureType)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTexture>(UARBlueprintLibrary.__GetARTexture_Internal(TextureType));
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x0004DEF1 File Offset: 0x0004C0F1
		public static FARSessionStatus GetARSessionStatus()
		{
			return new FARSessionStatus(UARBlueprintLibrary.__GetARSessionStatus_Internal(), null);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x0004DEFE File Offset: 0x0004C0FE
		public static TArray<UARTrackedPose> GetAllTrackedPoses()
		{
			return new TArray<UARTrackedPose>(UARBlueprintLibrary.__GetAllTrackedPoses_Internal(), null);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x0004DF0B File Offset: 0x0004C10B
		public static TArray<UARTrackedPoint> GetAllTrackedPoints()
		{
			return new TArray<UARTrackedPoint>(UARBlueprintLibrary.__GetAllTrackedPoints_Internal(), null);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0004DF18 File Offset: 0x0004C118
		public static TArray<UARPlaneGeometry> GetAllTrackedPlanes()
		{
			return new TArray<UARPlaneGeometry>(UARBlueprintLibrary.__GetAllTrackedPlanes_Internal(), null);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0004DF25 File Offset: 0x0004C125
		public static TArray<UARTrackedImage> GetAllTrackedImages()
		{
			return new TArray<UARTrackedImage>(UARBlueprintLibrary.__GetAllTrackedImages_Internal(), null);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0004DF32 File Offset: 0x0004C132
		public static TArray<UAREnvironmentCaptureProbe> GetAllTrackedEnvironmentCaptureProbes()
		{
			return new TArray<UAREnvironmentCaptureProbe>(UARBlueprintLibrary.__GetAllTrackedEnvironmentCaptureProbes_Internal(), null);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x0004DF3F File Offset: 0x0004C13F
		public static TArray<FARPose2D> GetAllTracked2DPoses()
		{
			return new TArray<FARPose2D>(UARBlueprintLibrary.__GetAllTracked2DPoses_Internal(), null);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x0004DF4C File Offset: 0x0004C14C
		public static TArray<UARPin> GetAllPins()
		{
			return new TArray<UARPin>(UARBlueprintLibrary.__GetAllPins_Internal(), null);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0004DF59 File Offset: 0x0004C159
		public static TArray<UARTrackedGeometry> GetAllGeometriesByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UARTrackedGeometry> GeometryClass)
		{
			return new TArray<UARTrackedGeometry>(UARBlueprintLibrary.__GetAllGeometriesByClass_Internal(GeometryClass._NativePtr), null);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0004DF6C File Offset: 0x0004C16C
		public static TArray<UARTrackedGeometry> GetAllGeometries()
		{
			return new TArray<UARTrackedGeometry>(UARBlueprintLibrary.__GetAllGeometries_Internal(), null);
		}

		// Token: 0x060032AE RID: 12974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform GetAlignmentTransform();

		// Token: 0x060032AF RID: 12975 RVA: 0x0004DF7C File Offset: 0x0004C17C
		public unsafe static TArray<UARTrackedPoint> FindTrackedPointsByName(string PointName)
		{
			FString fstring = FString.AllocTemp(PointName);
			TArray<UARTrackedPoint> result = new TArray<UARTrackedPoint>(UARBlueprintLibrary.__FindTrackedPointsByName_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
		[NullableContext(2)]
		public static void DebugDrawTrackedGeometry(UARTrackedGeometry TrackedGeometry, UObject WorldContextObject, FLinearColor? Color = null, float OutlineThickness = 5f, float PersistForSeconds = 0f)
		{
			UARBlueprintLibrary.__DebugDrawTrackedGeometry_Internal((TrackedGeometry != null) ? TrackedGeometry.NativePtr : IntPtr.Zero, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Color ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 0f,
				A = 0.75f
			}, OutlineThickness, PersistForSeconds);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x0004E02C File Offset: 0x0004C22C
		[NullableContext(2)]
		public static void DebugDrawPin(UARPin ARPin, UObject WorldContextObject, FLinearColor? Color = null, float Scale = 5f, float PersistForSeconds = 0f)
		{
			UARBlueprintLibrary.__DebugDrawPin_Internal((ARPin != null) ? ARPin.NativePtr : IntPtr.Zero, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Color ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 0f,
				A = 0.75f
			}, Scale, PersistForSeconds);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
		[NullableContext(2)]
		public unsafe static void CalculateClosestIntersection(in TArray<FVector> StartPoints, in TArray<FVector> EndPoints, ref FVector ClosestIntersection)
		{
			fixed (FVector* ptr = &ClosestIntersection)
			{
				void* ptr2 = (void*)ptr;
				UARBlueprintLibrary.__CalculateClosestIntersection_Internal((StartPoints ?? new TArray<FVector>()).NativePtr, (EndPoints ?? new TArray<FVector>()).NativePtr, ref ClosestIntersection);
			}
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0004E0EC File Offset: 0x0004C2EC
		public unsafe static void CalculateAlignmentTransform(in FTransform TransformInFirstCoordinateSystem, in FTransform TransformInSecondCoordinateSystem, ref FTransform AlignmentTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = TransformInFirstCoordinateSystem;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = TransformInSecondCoordinateSystem;
			ref FTransform ptr3 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr3 = AlignmentTransform;
			UARBlueprintLibrary.__CalculateAlignmentTransform_Internal(ptr, ptr2, ref ptr3);
			AlignmentTransform = ptr3;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0004E164 File Offset: 0x0004C364
		public unsafe static bool AddTrackedPointWithName(in FTransform WorldTransform, string PointName, bool bDeletePointsWithSameName = true)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = WorldTransform;
			FString fstring = FString.AllocTemp(PointName);
			bool result = UARBlueprintLibrary.__AddTrackedPointWithName_Internal(uintPtr, fstring, bDeletePointsWithSameName);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0004E1A4 File Offset: 0x0004C3A4
		[NullableContext(2)]
		public unsafe static UARCandidateImage AddRuntimeCandidateImage(UARSessionConfig SessionConfig, UTexture2D CandidateTexture, [Nullable(1)] string FriendlyName, float PhysicalWidth)
		{
			FString fstring = FString.AllocTemp(FriendlyName);
			UARCandidateImage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARCandidateImage>(UARBlueprintLibrary.__AddRuntimeCandidateImage_Internal((SessionConfig != null) ? SessionConfig.NativePtr : IntPtr.Zero, (CandidateTexture != null) ? CandidateTexture.NativePtr : IntPtr.Zero, fstring, PhysicalWidth));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060032B6 RID: 12982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AddManualEnvironmentCaptureProbe(FVector Location, FVector Extent);

		// Token: 0x060032B7 RID: 12983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnpinComponent_Internal(IntPtr ComponentToUnpin);

		// Token: 0x060032B8 RID: 12984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartARSession_Internal(IntPtr SessionConfig);

		// Token: 0x060032B9 RID: 12985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignmentTransform_Internal(in FTransform InAlignmentTransform);

		// Token: 0x060032BA RID: 12986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveARPinToLocalStore_Internal(FName InSaveName, IntPtr InPin);

		// Token: 0x060032BB RID: 12987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePin_Internal(IntPtr PinToRemove);

		// Token: 0x060032BC RID: 12988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PinComponentToTraceResult_Internal(IntPtr ComponentToPin, IntPtr TraceResult, FName DebugName);

		// Token: 0x060032BD RID: 12989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PinComponentToARPin_Internal(IntPtr ComponentToPin, IntPtr Pin);

		// Token: 0x060032BE RID: 12990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PinComponent_Internal(IntPtr ComponentToPin, in FTransform PinToWorldTransform, IntPtr TrackedGeometry, FName DebugName);

		// Token: 0x060032BF RID: 12991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadARPinsFromLocalStore_Internal();

		// Token: 0x060032C0 RID: 12992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LineTraceTrackedObjects3D_Internal(FVector Start, FVector End, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon);

		// Token: 0x060032C1 RID: 12993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LineTraceTrackedObjects_Internal(FVector2D ScreenCoord, bool bTestFeaturePoints, bool bTestGroundPlane, bool bTestPlaneExtents, bool bTestPlaneBoundaryPolygon);

		// Token: 0x060032C2 RID: 12994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedVideoFormats_Internal(EARSessionType SessionType);

		// Token: 0x060032C3 RID: 12995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSessionConfig_Internal();

		// Token: 0x060032C4 RID: 12996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointCloud_Internal();

		// Token: 0x060032C5 RID: 12997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPersonSegmentationImage_Internal();

		// Token: 0x060032C6 RID: 12998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPersonSegmentationDepthImage_Internal();

		// Token: 0x060032C7 RID: 12999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentLightEstimate_Internal();

		// Token: 0x060032C8 RID: 13000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCameraIntrinsics_Internal(IntPtr OutCameraIntrinsics);

		// Token: 0x060032C9 RID: 13001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCameraImage_Internal();

		// Token: 0x060032CA RID: 13002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCameraDepth_Internal();

		// Token: 0x060032CB RID: 13003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetARTexture_Internal(EARTextureType TextureType);

		// Token: 0x060032CC RID: 13004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetARSessionStatus_Internal();

		// Token: 0x060032CD RID: 13005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTrackedPoses_Internal();

		// Token: 0x060032CE RID: 13006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTrackedPoints_Internal();

		// Token: 0x060032CF RID: 13007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTrackedPlanes_Internal();

		// Token: 0x060032D0 RID: 13008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTrackedImages_Internal();

		// Token: 0x060032D1 RID: 13009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTrackedEnvironmentCaptureProbes_Internal();

		// Token: 0x060032D2 RID: 13010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllTracked2DPoses_Internal();

		// Token: 0x060032D3 RID: 13011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllPins_Internal();

		// Token: 0x060032D4 RID: 13012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllGeometriesByClass_Internal(IntPtr GeometryClass);

		// Token: 0x060032D5 RID: 13013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllGeometries_Internal();

		// Token: 0x060032D6 RID: 13014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindTrackedPointsByName_Internal(in FString PointName);

		// Token: 0x060032D7 RID: 13015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugDrawTrackedGeometry_Internal(IntPtr TrackedGeometry, IntPtr WorldContextObject, FLinearColor Color, float OutlineThickness, float PersistForSeconds);

		// Token: 0x060032D8 RID: 13016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugDrawPin_Internal(IntPtr ARPin, IntPtr WorldContextObject, FLinearColor Color, float Scale, float PersistForSeconds);

		// Token: 0x060032D9 RID: 13017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateClosestIntersection_Internal(IntPtr StartPoints, IntPtr EndPoints, ref FVector ClosestIntersection);

		// Token: 0x060032DA RID: 13018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateAlignmentTransform_Internal(in FTransform TransformInFirstCoordinateSystem, in FTransform TransformInSecondCoordinateSystem, ref FTransform AlignmentTransform);

		// Token: 0x060032DB RID: 13019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddTrackedPointWithName_Internal(in FTransform WorldTransform, in FString PointName, bool bDeletePointsWithSameName);

		// Token: 0x060032DC RID: 13020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddRuntimeCandidateImage_Internal(IntPtr SessionConfig, IntPtr CandidateTexture, in FString FriendlyName, float PhysicalWidth);

		// Token: 0x060032DD RID: 13021 RVA: 0x0004E1EE File Offset: 0x0004C3EE
		static UARBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARBlueprintLibrary");
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0004E1FC File Offset: 0x0004C3FC
		protected UARBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001624 RID: 5668
		public new const string __ObjectPath = "/Script/AugmentedReality.ARBlueprintLibrary";

		// Token: 0x04001625 RID: 5669
		private static IntPtr _ClassPtr;

		// Token: 0x04001626 RID: 5670
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
