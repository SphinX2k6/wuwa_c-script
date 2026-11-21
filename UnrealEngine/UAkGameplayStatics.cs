using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C3 RID: 195
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGameplayStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkGameplayStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x00016720 File Offset: 0x00014920
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGameplayStatics._ClassPtr;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0001672C File Offset: 0x0001492C
		public UAkGameplayStatics() : this(BuiltinUtils.AllocNativeUObject(UAkGameplayStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00016754 File Offset: 0x00014954
		[NullableContext(1)]
		public UAkGameplayStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkGameplayStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000E66 RID: 3686
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WakeupFromSuspend();

		// Token: 0x06000E67 RID: 3687 RVA: 0x00016787 File Offset: 0x00014987
		public static void UseReverbVolumes(bool inUseReverbVolumes, AActor Actor)
		{
			UAkGameplayStatics.__UseReverbVolumes_Internal(inUseReverbVolumes, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E68 RID: 3688
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnloadInitBank();

		// Token: 0x06000E69 RID: 3689 RVA: 0x000167A0 File Offset: 0x000149A0
		[NullableContext(1)]
		public unsafe static void UnloadBankByName(string BankName)
		{
			FString fstring = FString.AllocTemp(BankName);
			UAkGameplayStatics.__UnloadBankByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E6A RID: 3690
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Suspend(bool bValue);

		// Token: 0x06000E6B RID: 3691
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopProfilerCapture();

		// Token: 0x06000E6C RID: 3692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopOutputCapture();

		// Token: 0x06000E6D RID: 3693 RVA: 0x000167C4 File Offset: 0x000149C4
		public static void StopAllAmbientSounds(UObject WorldContextObject)
		{
			UAkGameplayStatics.__StopAllAmbientSounds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E6E RID: 3694
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopAll();

		// Token: 0x06000E6F RID: 3695 RVA: 0x000167DB File Offset: 0x000149DB
		public static void StopActor(AActor Actor)
		{
			UAkGameplayStatics.__StopActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000167F4 File Offset: 0x000149F4
		[NullableContext(1)]
		public unsafe static void StartProfilerCapture(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UAkGameplayStatics.__StartProfilerCapture_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00016818 File Offset: 0x00014A18
		[NullableContext(1)]
		public unsafe static void StartOutputCapture(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UAkGameplayStatics.__StartOutputCapture_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0001683C File Offset: 0x00014A3C
		public static void StartAllAmbientSounds(UObject WorldContextObject)
		{
			UAkGameplayStatics.__StartAllAmbientSounds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00016854 File Offset: 0x00014A54
		public unsafe static UAkComponent SpawnAkComponentAtLocation(UObject WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, bool AutoPost, [Nullable(1)] string EventName, bool AutoDestroy = true)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(UAkGameplayStatics.__SpawnAkComponentAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, AutoPost, fstring, AutoDestroy));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000168A4 File Offset: 0x00014AA4
		public static void SetSwitch(UAkSwitchValue SwitchValue, AActor Actor, FName SwitchGroup, FName SwitchState)
		{
			UAkGameplayStatics.__SetSwitch_Internal((SwitchValue != null) ? SwitchValue.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, SwitchGroup, SwitchState);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000168D0 File Offset: 0x00014AD0
		[NullableContext(1)]
		public unsafe static void SetSpeakerAngles([Nullable(2)] in TArray<float> SpeakerAngles, float HeightAngle, string DeviceShareSet = "")
		{
			FString fstring = FString.AllocTemp(DeviceShareSet);
			UAkGameplayStatics.__SetSpeakerAngles_Internal((SpeakerAngles ?? new TArray<float>()).NativePtr, HeightAngle, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00016905 File Offset: 0x00014B05
		public static void SetRTPCValue(UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, AActor Actor, FName RTPC)
		{
			UAkGameplayStatics.__SetRTPCValue_Internal((RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, Value, InterpolationTimeMs, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, RTPC);
		}

		// Token: 0x06000E77 RID: 3703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReflectionsOrder(int Order, bool RefreshPaths);

		// Token: 0x06000E78 RID: 3704 RVA: 0x00016930 File Offset: 0x00014B30
		public static void SetOutputBusVolume(float BusVolume, AActor Actor)
		{
			UAkGameplayStatics.__SetOutputBusVolume_Internal(BusVolume, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00016948 File Offset: 0x00014B48
		public static void SetMultiplePositions(UAkComponent GameObjectAkComponent, TArray<FTransform> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
		{
			UAkGameplayStatics.__SetMultiplePositions_Internal((GameObjectAkComponent != null) ? GameObjectAkComponent.NativePtr : IntPtr.Zero, (Positions ?? new TArray<FTransform>()).NativePtr, MultiPositionType);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0001696F File Offset: 0x00014B6F
		public static void SetDistanceProbe(AActor Listener, AActor DistanceProbe)
		{
			UAkGameplayStatics.__SetDistanceProbe_Internal((Listener != null) ? Listener.NativePtr : IntPtr.Zero, (DistanceProbe != null) ? DistanceProbe.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00016998 File Offset: 0x00014B98
		[NullableContext(1)]
		public unsafe static void SetCurrentAudioCultureAsync(string AudioCulture, [Nullable(2)] in FOnSetCurrentAudioCultureCallback Completed)
		{
			FString fstring = FString.AllocTemp(AudioCulture);
			FOnSetCurrentAudioCultureCallback fonSetCurrentAudioCultureCallback = Completed;
			UAkGameplayStatics.__SetCurrentAudioCultureAsync_Internal(fstring, (fonSetCurrentAudioCultureCallback != null) ? fonSetCurrentAudioCultureCallback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000169CB File Offset: 0x00014BCB
		public static void ResetRTPCValue(UAkRtpc RTPCValue, int InterpolationTimeMs, AActor Actor, FName RTPC)
		{
			UAkGameplayStatics.__ResetRTPCValue_Internal((RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, InterpolationTimeMs, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, RTPC);
		}

		// Token: 0x06000E7D RID: 3709
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RenderAudio();

		// Token: 0x06000E7E RID: 3710
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReloadAudioAssetData();

		// Token: 0x06000E7F RID: 3711 RVA: 0x000169F4 File Offset: 0x00014BF4
		[NullableContext(1)]
		public unsafe static void PostEventByName(string EventName, [Nullable(2)] AActor Actor, bool bStopWhenAttachedToDestroyed = false)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkGameplayStatics.__PostEventByName_Internal(fstring, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bStopWhenAttachedToDestroyed);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00016A29 File Offset: 0x00014C29
		public static int PostEventByDummyGameObj(UAkAudioEvent in_pAkEvent, in FOnAkPostEventCallback PostEventCallback)
		{
			IntPtr in_pAkEvent2 = (in_pAkEvent != null) ? in_pAkEvent.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			return UAkGameplayStatics.__PostEventByDummyGameObj_Internal(in_pAkEvent2, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00016A50 File Offset: 0x00014C50
		[NullableContext(1)]
		public unsafe static void PostEventAtLocationByName(string EventName, FVector Location, FRotator Orientation, [Nullable(2)] UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkGameplayStatics.__PostEventAtLocationByName_Internal(fstring, Location, Orientation, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00016A88 File Offset: 0x00014C88
		public unsafe static int PostEventAtLocation(UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, [Nullable(1)] string EventName, UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			int result = UAkGameplayStatics.__PostEventAtLocation_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, fstring, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00016AD0 File Offset: 0x00014CD0
		public unsafe static int PostEvent(UAkAudioEvent AkEvent, AActor Actor, int CallbackMask, in FOnAkPostEventCallback PostEventCallback, bool bStopWhenAttachedToDestroyed = false, [Nullable(1)] string EventName = "")
		{
			FString fstring = FString.AllocTemp(EventName);
			IntPtr akEvent = (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			int result = UAkGameplayStatics.__PostEvent_Internal(akEvent, actor, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), bStopWhenAttachedToDestroyed, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06000E84 RID: 3716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadInitBank();

		// Token: 0x06000E85 RID: 3717 RVA: 0x00016B28 File Offset: 0x00014D28
		[NullableContext(1)]
		public unsafe static void LoadBankByName(string BankName)
		{
			FString fstring = FString.AllocTemp(BankName);
			UAkGameplayStatics.__LoadBankByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00016B4C File Offset: 0x00014D4C
		public static bool IsGame(UObject WorldContextObject)
		{
			return UAkGameplayStatics.__IsGame_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E87 RID: 3719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEditor();

		// Token: 0x06000E88 RID: 3720 RVA: 0x00016B63 File Offset: 0x00014D63
		public static bool IsAudioEventActive(UAkAudioEvent AudioEvent)
		{
			return UAkGameplayStatics.__IsAudioEventActive_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00016B7C File Offset: 0x00014D7C
		[NullableContext(1)]
		public unsafe static void GetSpeakerAngles([Nullable(2)] ref TArray<float> SpeakerAngles, ref float HeightAngle, string DeviceShareSet = "")
		{
			FString fstring = FString.AllocTemp(DeviceShareSet);
			fixed (float* ptr = &HeightAngle)
			{
				void* ptr2 = (void*)ptr;
				UAkGameplayStatics.__GetSpeakerAngles_Internal((SpeakerAngles ?? new TArray<float>()).NativePtr, ref HeightAngle, fstring);
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06000E8A RID: 3722
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSourcePlayPosition(int PlayingID);

		// Token: 0x06000E8B RID: 3723 RVA: 0x00016BBC File Offset: 0x00014DBC
		public unsafe static void GetRTPCValue(UAkRtpc RTPCValue, int PlayingID, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, AActor Actor, FName RTPC)
		{
			fixed (float* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				fixed (ERTPCValueType* ptr3 = &OutputValueType)
				{
					void* ptr4 = (void*)ptr3;
					UAkGameplayStatics.__GetRTPCValue_Internal((RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, PlayingID, InputValueType, ref Value, ref OutputValueType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, RTPC);
					ptr = null;
				}
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00016C08 File Offset: 0x00014E08
		[NullableContext(1)]
		public static string GetCurrentAudioCulture()
		{
			return FString.ToStringAndDeleteNativePtr(UAkGameplayStatics.__GetCurrentAudioCulture_Internal());
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00016C14 File Offset: 0x00014E14
		[NullableContext(1)]
		public static TArray<string> GetAvailableAudioCultures()
		{
			return new TArray<string>(UAkGameplayStatics.__GetAvailableAudioCultures_Internal(), null);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00016C24 File Offset: 0x00014E24
		public unsafe static UAkComponent GetAkComponent(USceneComponent AttachToComponent, ref bool ComponentCreated, FName AttachPointName = default(FName), FVector Location = default(FVector), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset)
		{
			fixed (bool* ptr = &ComponentCreated)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(UAkGameplayStatics.__GetAkComponent_Internal((AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, ref ComponentCreated, AttachPointName, Location, LocationType));
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00016C5A File Offset: 0x00014E5A
		public static UObject GetAkAudioTypeUserData(UAkAudioType Instance, UClassStackOnlyPtr Type)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UAkGameplayStatics.__GetAkAudioTypeUserData_Internal((Instance != null) ? Instance.NativePtr : IntPtr.Zero, Type._NativePtr));
		}

		// Token: 0x06000E90 RID: 3728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteActionOnPlayingID(EAkActionOnEventType ActionType, int PlayingID, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear);

		// Token: 0x06000E91 RID: 3729 RVA: 0x00016C7C File Offset: 0x00014E7C
		public static void ExecuteActionOnEvent(UAkAudioEvent AkEvent, EAkActionOnEventType ActionType, AActor Actor, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear, int PlayingID = 0)
		{
			UAkGameplayStatics.__ExecuteActionOnEvent_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, FadeCurve, PlayingID);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00016CA9 File Offset: 0x00014EA9
		public static void D_SetMultiplePositions(UAkComponent GameObjectAkComponent, TArray<FTransformDouble> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
		{
			UAkGameplayStatics.__D_SetMultiplePositions_Internal((GameObjectAkComponent != null) ? GameObjectAkComponent.NativePtr : IntPtr.Zero, (Positions ?? new TArray<FTransformDouble>()).NativePtr, MultiPositionType);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00016CD0 File Offset: 0x00014ED0
		public unsafe static int D_PostEventAtLocation(UAkAudioEvent AkEvent, FVectorDouble Location, FRotator Orientation, [Nullable(1)] string EventName, UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			int result = UAkGameplayStatics.__D_PostEventAtLocation_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, fstring, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06000E94 RID: 3732
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearSoundBanksAndMedia();

		// Token: 0x06000E95 RID: 3733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearBanks();

		// Token: 0x06000E96 RID: 3734 RVA: 0x00016D18 File Offset: 0x00014F18
		public static void CancelEventCallback(in FOnAkPostEventCallback PostEventCallback)
		{
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			UAkGameplayStatics.__CancelEventCallback_Internal((fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00016D30 File Offset: 0x00014F30
		[NullableContext(1)]
		public unsafe static void AddOutputCaptureMarker(string MarkerText)
		{
			FString fstring = FString.AllocTemp(MarkerText);
			UAkGameplayStatics.__AddOutputCaptureMarker_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E98 RID: 3736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseReverbVolumes_Internal(bool inUseReverbVolumes, IntPtr Actor);

		// Token: 0x06000E99 RID: 3737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadBankByName_Internal(in FString BankName);

		// Token: 0x06000E9A RID: 3738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllAmbientSounds_Internal(IntPtr WorldContextObject);

		// Token: 0x06000E9B RID: 3739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopActor_Internal(IntPtr Actor);

		// Token: 0x06000E9C RID: 3740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartProfilerCapture_Internal(in FString Filename);

		// Token: 0x06000E9D RID: 3741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartOutputCapture_Internal(in FString Filename);

		// Token: 0x06000E9E RID: 3742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAllAmbientSounds_Internal(IntPtr WorldContextObject);

		// Token: 0x06000E9F RID: 3743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnAkComponentAtLocation_Internal(IntPtr WorldContextObject, IntPtr AkEvent, FVector Location, FRotator Orientation, bool AutoPost, in FString EventName, bool AutoDestroy);

		// Token: 0x06000EA0 RID: 3744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(IntPtr SwitchValue, IntPtr Actor, FName SwitchGroup, FName SwitchState);

		// Token: 0x06000EA1 RID: 3745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpeakerAngles_Internal(IntPtr SpeakerAngles, float HeightAngle, in FString DeviceShareSet);

		// Token: 0x06000EA2 RID: 3746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRTPCValue_Internal(IntPtr RTPCValue, float Value, int InterpolationTimeMs, IntPtr Actor, FName RTPC);

		// Token: 0x06000EA3 RID: 3747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutputBusVolume_Internal(float BusVolume, IntPtr Actor);

		// Token: 0x06000EA4 RID: 3748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMultiplePositions_Internal(IntPtr GameObjectAkComponent, IntPtr Positions, EAkMultiPositionType MultiPositionType);

		// Token: 0x06000EA5 RID: 3749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceProbe_Internal(IntPtr Listener, IntPtr DistanceProbe);

		// Token: 0x06000EA6 RID: 3750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentAudioCultureAsync_Internal(in FString AudioCulture, IntPtr Completed);

		// Token: 0x06000EA7 RID: 3751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRTPCValue_Internal(IntPtr RTPCValue, int InterpolationTimeMs, IntPtr Actor, FName RTPC);

		// Token: 0x06000EA8 RID: 3752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventByName_Internal(in FString EventName, IntPtr Actor, bool bStopWhenAttachedToDestroyed);

		// Token: 0x06000EA9 RID: 3753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEventByDummyGameObj_Internal(IntPtr in_pAkEvent, IntPtr PostEventCallback);

		// Token: 0x06000EAA RID: 3754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventAtLocationByName_Internal(in FString EventName, FVector Location, FRotator Orientation, IntPtr WorldContextObject);

		// Token: 0x06000EAB RID: 3755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEventAtLocation_Internal(IntPtr AkEvent, FVector Location, FRotator Orientation, in FString EventName, IntPtr WorldContextObject);

		// Token: 0x06000EAC RID: 3756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEvent_Internal(IntPtr AkEvent, IntPtr Actor, int CallbackMask, IntPtr PostEventCallback, bool bStopWhenAttachedToDestroyed, in FString EventName);

		// Token: 0x06000EAD RID: 3757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadBankByName_Internal(in FString BankName);

		// Token: 0x06000EAE RID: 3758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGame_Internal(IntPtr WorldContextObject);

		// Token: 0x06000EAF RID: 3759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAudioEventActive_Internal(IntPtr AudioEvent);

		// Token: 0x06000EB0 RID: 3760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpeakerAngles_Internal(IntPtr SpeakerAngles, ref float HeightAngle, in FString DeviceShareSet);

		// Token: 0x06000EB1 RID: 3761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRTPCValue_Internal(IntPtr RTPCValue, int PlayingID, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, IntPtr Actor, FName RTPC);

		// Token: 0x06000EB2 RID: 3762
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentAudioCulture_Internal();

		// Token: 0x06000EB3 RID: 3763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAvailableAudioCultures_Internal();

		// Token: 0x06000EB4 RID: 3764
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkComponent_Internal(IntPtr AttachToComponent, ref bool ComponentCreated, FName AttachPointName, FVector Location, TEnumAsByte<EAttachLocation> LocationType);

		// Token: 0x06000EB5 RID: 3765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkAudioTypeUserData_Internal(IntPtr Instance, IntPtr Type);

		// Token: 0x06000EB6 RID: 3766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEvent_Internal(IntPtr AkEvent, EAkActionOnEventType ActionType, IntPtr Actor, int TransitionDuration, EAkCurveInterpolation FadeCurve, int PlayingID);

		// Token: 0x06000EB7 RID: 3767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetMultiplePositions_Internal(IntPtr GameObjectAkComponent, IntPtr Positions, EAkMultiPositionType MultiPositionType);

		// Token: 0x06000EB8 RID: 3768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __D_PostEventAtLocation_Internal(IntPtr AkEvent, FVectorDouble Location, FRotator Orientation, in FString EventName, IntPtr WorldContextObject);

		// Token: 0x06000EB9 RID: 3769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelEventCallback_Internal(IntPtr PostEventCallback);

		// Token: 0x06000EBA RID: 3770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOutputCaptureMarker_Internal(in FString MarkerText);

		// Token: 0x06000EBB RID: 3771 RVA: 0x00016D54 File Offset: 0x00014F54
		static UAkGameplayStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGameplayStatics");
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00016D62 File Offset: 0x00014F62
		protected UAkGameplayStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002D3 RID: 723
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkGameplayStatics";

		// Token: 0x040002D4 RID: 724
		private static IntPtr _ClassPtr;

		// Token: 0x040002D5 RID: 725
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
