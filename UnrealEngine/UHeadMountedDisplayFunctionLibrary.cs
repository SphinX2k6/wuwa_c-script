using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001469 RID: 5225
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.HeadMountedDisplayFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013094 RID: 77972 RVA: 0x001C029D File Offset: 0x001BE49D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHeadMountedDisplayFunctionLibrary._ClassPtr;
		}

		// Token: 0x06013095 RID: 77973 RVA: 0x001C02AC File Offset: 0x001BE4AC
		public UHeadMountedDisplayFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UHeadMountedDisplayFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013096 RID: 77974 RVA: 0x001C02D4 File Offset: 0x001BE4D4
		[NullableContext(1)]
		public UHeadMountedDisplayFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHeadMountedDisplayFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013097 RID: 77975 RVA: 0x001C0308 File Offset: 0x001BE508
		public unsafe static void UpdateExternalTrackingHMDPosition(in FTransform ExternalTrackingTransform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = ExternalTrackingTransform;
			UHeadMountedDisplayFunctionLibrary.__UpdateExternalTrackingHMDPosition_Internal(uintPtr);
		}

		// Token: 0x06013098 RID: 77976 RVA: 0x001C0338 File Offset: 0x001BE538
		public unsafe static void SetXRTimedInputActionDelegate(in FName ActionName, in FXRTimedInputActionDelegate InDelegate)
		{
			fixed (FName* ptr = &ActionName)
			{
				void* ptr2 = (void*)ptr;
				FXRTimedInputActionDelegate fxrtimedInputActionDelegate = InDelegate;
				UHeadMountedDisplayFunctionLibrary.__SetXRTimedInputActionDelegate_Internal(ActionName, (fxrtimedInputActionDelegate != null) ? fxrtimedInputActionDelegate.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06013099 RID: 77977 RVA: 0x001C0362 File Offset: 0x001BE562
		public static void SetXRDisconnectDelegate(in FXRDeviceOnDisconnectDelegate InDisconnectedDelegate)
		{
			FXRDeviceOnDisconnectDelegate fxrdeviceOnDisconnectDelegate = InDisconnectedDelegate;
			UHeadMountedDisplayFunctionLibrary.__SetXRDisconnectDelegate_Internal((fxrdeviceOnDisconnectDelegate != null) ? fxrdeviceOnDisconnectDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601309A RID: 77978 RVA: 0x001C0378 File Offset: 0x001BE578
		public static void SetWorldToMetersScale(UObject WorldContext, float NewScale = 100f)
		{
			UHeadMountedDisplayFunctionLibrary.__SetWorldToMetersScale_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, NewScale);
		}

		// Token: 0x0601309B RID: 77979
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTrackingOrigin(EHMDTrackingOrigin Origin);

		// Token: 0x0601309C RID: 77980 RVA: 0x001C0390 File Offset: 0x001BE590
		public static void SetSpectatorScreenTexture(UTexture InTexture)
		{
			UHeadMountedDisplayFunctionLibrary.__SetSpectatorScreenTexture_Internal((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601309D RID: 77981
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin, FVector2D EyeRectMax, FVector2D TextureRectMin, FVector2D TextureRectMax, bool bDrawEyeFirst = true, bool bClearBlack = false, bool bUseAlpha = false);

		// Token: 0x0601309E RID: 77982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSpectatorScreenMode(ESpectatorScreenMode Mode);

		// Token: 0x0601309F RID: 77983
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetClippingPlanes(float Near, float Far);

		// Token: 0x060130A0 RID: 77984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetOrientationAndPosition(float Yaw = 0f, EOrientPositionSelector Options = EOrientPositionSelector.OrientationAndPosition);

		// Token: 0x060130A1 RID: 77985
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSpectatorScreenModeControllable();

		// Token: 0x060130A2 RID: 77986
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInLowPersistenceMode();

		// Token: 0x060130A3 RID: 77987
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsHeadMountedDisplayEnabled();

		// Token: 0x060130A4 RID: 77988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsHeadMountedDisplayConnected();

		// Token: 0x060130A5 RID: 77989 RVA: 0x001C03A7 File Offset: 0x001BE5A7
		public static bool IsDeviceTracking(in FXRDeviceId XRDeviceId)
		{
			return UHeadMountedDisplayFunctionLibrary.__IsDeviceTracking_Internal((XRDeviceId ?? new FXRDeviceId()).NativePtr);
		}

		// Token: 0x060130A6 RID: 77990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasValidTrackingPosition();

		// Token: 0x060130A7 RID: 77991
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetXRSystemFlags();

		// Token: 0x060130A8 RID: 77992 RVA: 0x001C03BE File Offset: 0x001BE5BE
		public static float GetWorldToMetersScale(UObject WorldContext)
		{
			return UHeadMountedDisplayFunctionLibrary.__GetWorldToMetersScale_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060130A9 RID: 77993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetVRFocusState(ref bool bUseFocus, ref bool bHasFocus);

		// Token: 0x060130AA RID: 77994 RVA: 0x001C03D5 File Offset: 0x001BE5D5
		[NullableContext(1)]
		public static string GetVersionString()
		{
			return FString.ToStringAndDeleteNativePtr(UHeadMountedDisplayFunctionLibrary.__GetVersionString_Internal());
		}

		// Token: 0x060130AB RID: 77995 RVA: 0x001C03E1 File Offset: 0x001BE5E1
		public static FTransform GetTrackingToWorldTransform(UObject WorldContext)
		{
			return UHeadMountedDisplayFunctionLibrary.__GetTrackingToWorldTransform_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060130AC RID: 77996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetTrackingSensorParameters(ref FVector Origin, ref FRotator Rotation, ref float LeftFOV, ref float RightFOV, ref float TopFOV, ref float BottomFOV, ref float Distance, ref float NearPlane, ref float FarPlane, ref bool IsActive, int Index = 0);

		// Token: 0x060130AD RID: 77997
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EHMDTrackingOrigin> GetTrackingOrigin();

		// Token: 0x060130AE RID: 77998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetScreenPercentage();

		// Token: 0x060130AF RID: 77999
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetPositionalTrackingCameraParameters(ref FVector CameraOrigin, ref FRotator CameraRotation, ref float HFOV, ref float VFOV, ref float CameraDistance, ref float NearPlane, ref float FarPlane);

		// Token: 0x060130B0 RID: 78000
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPixelDensity();

		// Token: 0x060130B1 RID: 78001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetOrientationAndPosition(ref FRotator DeviceRotation, ref FVector DevicePosition);

		// Token: 0x060130B2 RID: 78002
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumOfTrackingSensors();

		// Token: 0x060130B3 RID: 78003 RVA: 0x001C03F8 File Offset: 0x001BE5F8
		public static void GetMotionControllerData(UObject WorldContext, EControllerHand Hand, ref FXRMotionControllerData MotionControllerData)
		{
			UHeadMountedDisplayFunctionLibrary.__GetMotionControllerData_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, Hand, (MotionControllerData ?? new FXRMotionControllerData()).NativePtr);
		}

		// Token: 0x060130B4 RID: 78004
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EHMDWornState> GetHMDWornState();

		// Token: 0x060130B5 RID: 78005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetHMDDeviceName();

		// Token: 0x060130B6 RID: 78006 RVA: 0x001C0420 File Offset: 0x001BE620
		public static void GetHMDData(UObject WorldContext, ref FXRHMDData HMDData)
		{
			UHeadMountedDisplayFunctionLibrary.__GetHMDData_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (HMDData ?? new FXRHMDData()).NativePtr);
		}

		// Token: 0x060130B7 RID: 78007 RVA: 0x001C0448 File Offset: 0x001BE648
		public unsafe static void GetDeviceWorldPose(UObject WorldContext, in FXRDeviceId XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position)
		{
			fixed (bool* ptr = &bIsTracked)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Orientation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bHasPositionalTracking)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &Position)
						{
							void* ptr8 = (void*)ptr7;
							UHeadMountedDisplayFunctionLibrary.__GetDeviceWorldPose_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (XRDeviceId ?? new FXRDeviceId()).NativePtr, ref bIsTracked, ref Orientation, ref bHasPositionalTracking, ref Position);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060130B8 RID: 78008 RVA: 0x001C04B0 File Offset: 0x001BE6B0
		public unsafe static void GetDevicePose(in FXRDeviceId XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position)
		{
			fixed (bool* ptr = &bIsTracked)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Orientation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bHasPositionalTracking)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &Position)
						{
							void* ptr8 = (void*)ptr7;
							UHeadMountedDisplayFunctionLibrary.__GetDevicePose_Internal((XRDeviceId ?? new FXRDeviceId()).NativePtr, ref bIsTracked, ref Orientation, ref bHasPositionalTracking, ref Position);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060130B9 RID: 78009 RVA: 0x001C0504 File Offset: 0x001BE704
		public unsafe static bool GetControllerTransformForTime(UObject WorldContext, int ControllerIndex, FName MotionSource, FTimespan Time, ref bool bTimeWasUsed, ref FRotator Orientation, ref FVector Position, ref bool bProvidedLinearVelocity, ref FVector LinearVelocity, ref bool bProvidedAngularVelocity, ref FVector AngularVelocityRadPerSec)
		{
			fixed (bool* ptr = &bTimeWasUsed)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Orientation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Position)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &bProvidedLinearVelocity)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &LinearVelocity)
							{
								void* ptr10 = (void*)ptr9;
								fixed (bool* ptr11 = &bProvidedAngularVelocity)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &AngularVelocityRadPerSec)
									{
										void* ptr14 = (void*)ptr13;
										return UHeadMountedDisplayFunctionLibrary.__GetControllerTransformForTime_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, ControllerIndex, MotionSource, (Time ?? new FTimespan()).NativePtr, ref bTimeWasUsed, ref Orientation, ref Position, ref bProvidedLinearVelocity, ref LinearVelocity, ref bProvidedAngularVelocity, ref AngularVelocityRadPerSec);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060130BA RID: 78010 RVA: 0x001C0580 File Offset: 0x001BE780
		[NullableContext(1)]
		public static TArray<FXRDeviceId> EnumerateTrackedDevices(FName SystemId = default(FName), EXRTrackedDeviceType DeviceType = EXRTrackedDeviceType.Any)
		{
			return new TArray<FXRDeviceId>(UHeadMountedDisplayFunctionLibrary.__EnumerateTrackedDevices_Internal(SystemId, DeviceType), null);
		}

		// Token: 0x060130BB RID: 78011
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableLowPersistenceMode(bool bEnable);

		// Token: 0x060130BC RID: 78012
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EnableHMD(bool bEnable);

		// Token: 0x060130BD RID: 78013
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisconnectRemoteXRDevice();

		// Token: 0x060130BE RID: 78014 RVA: 0x001C0590 File Offset: 0x001BE790
		[NullableContext(0)]
		public unsafe static TEnumAsByte<EXRDeviceConnectionResult> ConnectRemoteXRDevice([Nullable(1)] string IpAddress, int BitRate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			TEnumAsByte<EXRDeviceConnectionResult> result = UHeadMountedDisplayFunctionLibrary.__ConnectRemoteXRDevice_Internal(fstring, BitRate);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060130BF RID: 78015 RVA: 0x001C05B5 File Offset: 0x001BE7B5
		public static bool ConfigureGestures(in FXRGestureConfig GestureConfig)
		{
			return UHeadMountedDisplayFunctionLibrary.__ConfigureGestures_Internal((GestureConfig ?? new FXRGestureConfig()).NativePtr);
		}

		// Token: 0x060130C0 RID: 78016
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearXRTimedInputActionDelegate(in FName ActionPath);

		// Token: 0x060130C1 RID: 78017 RVA: 0x001C05CC File Offset: 0x001BE7CC
		public unsafe static void CalibrateExternalTrackingToHMD(in FTransform ExternalTrackingTransform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = ExternalTrackingTransform;
			UHeadMountedDisplayFunctionLibrary.__CalibrateExternalTrackingToHMD_Internal(uintPtr);
		}

		// Token: 0x060130C2 RID: 78018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateExternalTrackingHMDPosition_Internal(in FTransform ExternalTrackingTransform);

		// Token: 0x060130C3 RID: 78019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetXRTimedInputActionDelegate_Internal(in FName ActionName, IntPtr InDelegate);

		// Token: 0x060130C4 RID: 78020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetXRDisconnectDelegate_Internal(IntPtr InDisconnectedDelegate);

		// Token: 0x060130C5 RID: 78021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldToMetersScale_Internal(IntPtr WorldContext, float NewScale);

		// Token: 0x060130C6 RID: 78022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpectatorScreenTexture_Internal(IntPtr InTexture);

		// Token: 0x060130C7 RID: 78023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDeviceTracking_Internal(IntPtr XRDeviceId);

		// Token: 0x060130C8 RID: 78024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWorldToMetersScale_Internal(IntPtr WorldContext);

		// Token: 0x060130C9 RID: 78025
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetVersionString_Internal();

		// Token: 0x060130CA RID: 78026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTrackingToWorldTransform_Internal(IntPtr WorldContext);

		// Token: 0x060130CB RID: 78027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMotionControllerData_Internal(IntPtr WorldContext, EControllerHand Hand, IntPtr MotionControllerData);

		// Token: 0x060130CC RID: 78028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetHMDData_Internal(IntPtr WorldContext, IntPtr HMDData);

		// Token: 0x060130CD RID: 78029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDeviceWorldPose_Internal(IntPtr WorldContext, IntPtr XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position);

		// Token: 0x060130CE RID: 78030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDevicePose_Internal(IntPtr XRDeviceId, ref bool bIsTracked, ref FRotator Orientation, ref bool bHasPositionalTracking, ref FVector Position);

		// Token: 0x060130CF RID: 78031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControllerTransformForTime_Internal(IntPtr WorldContext, int ControllerIndex, FName MotionSource, IntPtr Time, ref bool bTimeWasUsed, ref FRotator Orientation, ref FVector Position, ref bool bProvidedLinearVelocity, ref FVector LinearVelocity, ref bool bProvidedAngularVelocity, ref FVector AngularVelocityRadPerSec);

		// Token: 0x060130D0 RID: 78032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EnumerateTrackedDevices_Internal(FName SystemId, EXRTrackedDeviceType DeviceType);

		// Token: 0x060130D1 RID: 78033
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EXRDeviceConnectionResult> __ConnectRemoteXRDevice_Internal(in FString IpAddress, int BitRate);

		// Token: 0x060130D2 RID: 78034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ConfigureGestures_Internal(IntPtr GestureConfig);

		// Token: 0x060130D3 RID: 78035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalibrateExternalTrackingToHMD_Internal(in FTransform ExternalTrackingTransform);

		// Token: 0x060130D4 RID: 78036 RVA: 0x001C05F9 File Offset: 0x001BE7F9
		static UHeadMountedDisplayFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.HeadMountedDisplayFunctionLibrary");
		}

		// Token: 0x060130D5 RID: 78037 RVA: 0x001C0607 File Offset: 0x001BE807
		protected UHeadMountedDisplayFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A37D RID: 41853
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.HeadMountedDisplayFunctionLibrary";

		// Token: 0x0400A37E RID: 41854
		private static IntPtr _ClassPtr;

		// Token: 0x0400A37F RID: 41855
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
