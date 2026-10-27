using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000207 RID: 519
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGameplayStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkGameplayStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E7A RID: 7802 RVA: 0x0002D32C File Offset: 0x0002B52C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGameplayStatics._ClassPtr;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0002D338 File Offset: 0x0002B538
		public UAkGameplayStatics() : this(BuiltinUtils.AllocNativeUObject(UAkGameplayStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0002D360 File Offset: 0x0002B560
		[NullableContext(1)]
		public UAkGameplayStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkGameplayStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001E7D RID: 7805
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WakeupFromSuspend();

		// Token: 0x06001E7E RID: 7806 RVA: 0x0002D393 File Offset: 0x0002B593
		public static void UseReverbVolumes(bool inUseReverbVolumes, AActor Actor)
		{
			UAkGameplayStatics.__UseReverbVolumes_Internal(inUseReverbVolumes, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0002D3AC File Offset: 0x0002B5AC
		public unsafe static void UseEarlyReflections(AActor Actor, UAkAuxBus AuxBus, int Order = 1, float BusSendGain = 1f, float MaxPathLength = 100000f, bool SpotReflectors = false, [Nullable(1)] string AuxBusName = "")
		{
			FString fstring = FString.AllocTemp(AuxBusName);
			UAkGameplayStatics.__UseEarlyReflections_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (AuxBus != null) ? AuxBus.NativePtr : IntPtr.Zero, Order, BusSendGain, MaxPathLength, SpotReflectors, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E80 RID: 7808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnloadInitBank();

		// Token: 0x06001E81 RID: 7809 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		[NullableContext(1)]
		public unsafe static void UnloadBankByName(string BankName)
		{
			FString fstring = FString.AllocTemp(BankName);
			UAkGameplayStatics.__UnloadBankByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E82 RID: 7810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Suspend(bool bValue);

		// Token: 0x06001E83 RID: 7811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopProfilerCapture();

		// Token: 0x06001E84 RID: 7812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopOutputCapture();

		// Token: 0x06001E85 RID: 7813 RVA: 0x0002D41C File Offset: 0x0002B61C
		public static void StopAllAmbientSounds(UObject WorldContextObject)
		{
			UAkGameplayStatics.__StopAllAmbientSounds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E86 RID: 7814
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopAll();

		// Token: 0x06001E87 RID: 7815 RVA: 0x0002D433 File Offset: 0x0002B633
		public static void StopActor(AActor Actor)
		{
			UAkGameplayStatics.__StopActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0002D44C File Offset: 0x0002B64C
		[NullableContext(1)]
		public unsafe static void StartProfilerCapture(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UAkGameplayStatics.__StartProfilerCapture_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0002D470 File Offset: 0x0002B670
		[NullableContext(1)]
		public unsafe static void StartOutputCapture(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UAkGameplayStatics.__StartOutputCapture_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0002D494 File Offset: 0x0002B694
		public static void StartAllAmbientSounds(UObject WorldContextObject)
		{
			UAkGameplayStatics.__StartAllAmbientSounds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		public unsafe static UAkComponent SpawnAkComponentAtLocation(UObject WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, bool AutoPost, [Nullable(1)] string EventName, bool AutoDestroy = true)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(UAkGameplayStatics.__SpawnAkComponentAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, AutoPost, fstring, AutoDestroy));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		public static void SetSwitch(UAkSwitchValue SwitchValue, AActor Actor, FName SwitchGroup, FName SwitchState)
		{
			UAkGameplayStatics.__SetSwitch_Internal((SwitchValue != null) ? SwitchValue.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, SwitchGroup, SwitchState);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0002D525 File Offset: 0x0002B725
		public static void SetState(UAkStateValue StateValue, FName StateGroup, FName State)
		{
			UAkGameplayStatics.__SetState_Internal((StateValue != null) ? StateValue.NativePtr : IntPtr.Zero, StateGroup, State);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0002D540 File Offset: 0x0002B740
		[NullableContext(1)]
		public unsafe static void SetSpeakerAngles([Nullable(2)] in TArray<float> SpeakerAngles, float HeightAngle, string DeviceShareSet = "")
		{
			FString fstring = FString.AllocTemp(DeviceShareSet);
			UAkGameplayStatics.__SetSpeakerAngles_Internal((SpeakerAngles ?? new TArray<float>()).NativePtr, HeightAngle, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0002D575 File Offset: 0x0002B775
		public static void SetRTPCValue(UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, AActor Actor, FName RTPC)
		{
			UAkGameplayStatics.__SetRTPCValue_Internal((RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, Value, InterpolationTimeMs, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, RTPC);
		}

		// Token: 0x06001E90 RID: 7824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReflectionsOrder(int Order, bool RefreshPaths);

		// Token: 0x06001E91 RID: 7825 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		public static void SetPortalToPortalObstruction(UAkPortalComponent PortalComponent0, UAkPortalComponent PortalComponent1, float ObstructionValue)
		{
			UAkGameplayStatics.__SetPortalToPortalObstruction_Internal((PortalComponent0 != null) ? PortalComponent0.NativePtr : IntPtr.Zero, (PortalComponent1 != null) ? PortalComponent1.NativePtr : IntPtr.Zero, ObstructionValue);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		public static void SetPortalObstructionAndOcclusion(UAkPortalComponent PortalComponent, float ObstructionValue, float OcclusionValue)
		{
			UAkGameplayStatics.__SetPortalObstructionAndOcclusion_Internal((PortalComponent != null) ? PortalComponent.NativePtr : IntPtr.Zero, ObstructionValue, OcclusionValue);
		}

		// Token: 0x06001E93 RID: 7827
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPanningRule(PanningRule PanRule);

		// Token: 0x06001E94 RID: 7828 RVA: 0x0002D5E1 File Offset: 0x0002B7E1
		public static bool SetOutputDeviceEffect(FAkOutputDeviceID InDeviceID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
		{
			return UAkGameplayStatics.__SetOutputDeviceEffect_Internal((InDeviceID ?? new FAkOutputDeviceID()).NativePtr, InEffectIndex, (InEffectShareSet != null) ? InEffectShareSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0002D608 File Offset: 0x0002B808
		public static void SetOutputBusVolume(float BusVolume, AActor Actor)
		{
			UAkGameplayStatics.__SetOutputBusVolume_Internal(BusVolume, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0002D620 File Offset: 0x0002B820
		public static void SetMultiplePositions(UAkComponent GameObjectAkComponent, TArray<FTransform> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
		{
			UAkGameplayStatics.__SetMultiplePositions_Internal((GameObjectAkComponent != null) ? GameObjectAkComponent.NativePtr : IntPtr.Zero, (Positions ?? new TArray<FTransform>()).NativePtr, MultiPositionType);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0002D647 File Offset: 0x0002B847
		public static void SetGameObjectToPortalObstruction(UAkComponent GameObjectAkComponent, UAkPortalComponent PortalComponent, float ObstructionValue)
		{
			UAkGameplayStatics.__SetGameObjectToPortalObstruction_Internal((GameObjectAkComponent != null) ? GameObjectAkComponent.NativePtr : IntPtr.Zero, (PortalComponent != null) ? PortalComponent.NativePtr : IntPtr.Zero, ObstructionValue);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0002D66F File Offset: 0x0002B86F
		public static void SetDistanceProbe(AActor Listener, AActor DistanceProbe)
		{
			UAkGameplayStatics.__SetDistanceProbe_Internal((Listener != null) ? Listener.NativePtr : IntPtr.Zero, (DistanceProbe != null) ? DistanceProbe.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0002D698 File Offset: 0x0002B898
		[NullableContext(1)]
		public unsafe static void SetCurrentAudioCultureAsync(string AudioCulture, [Nullable(2)] in FOnSetCurrentAudioCultureCallback Completed)
		{
			FString fstring = FString.AllocTemp(AudioCulture);
			FOnSetCurrentAudioCultureCallback fonSetCurrentAudioCultureCallback = Completed;
			UAkGameplayStatics.__SetCurrentAudioCultureAsync_Internal(fstring, (fonSetCurrentAudioCultureCallback != null) ? fonSetCurrentAudioCultureCallback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0002D6CC File Offset: 0x0002B8CC
		public unsafe static void SetCurrentAudioCulture([Nullable(1)] string AudioCulture, FLatentActionInfo LatentInfo, UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(AudioCulture);
			UAkGameplayStatics.__SetCurrentAudioCulture_Internal(fstring, (LatentInfo ?? new FLatentActionInfo()).NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0002D710 File Offset: 0x0002B910
		[NullableContext(1)]
		public unsafe static bool SetBusEffectByName(string InBusName, int InEffectIndex, [Nullable(2)] UAkEffectShareSet InEffectShareSet)
		{
			FString fstring = FString.AllocTemp(InBusName);
			bool result = UAkGameplayStatics.__SetBusEffectByName_Internal(fstring, InEffectIndex, (InEffectShareSet != null) ? InEffectShareSet.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0002D745 File Offset: 0x0002B945
		public static bool SetBusEffectByID(FAkUniqueID InBusID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
		{
			return UAkGameplayStatics.__SetBusEffectByID_Internal((InBusID ?? new FAkUniqueID()).NativePtr, InEffectIndex, (InEffectShareSet != null) ? InEffectShareSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0002D76C File Offset: 0x0002B96C
		[NullableContext(1)]
		public unsafe static void SetBusConfig(string BusName, EAkChannelConfiguration ChannelConfiguration)
		{
			FString fstring = FString.AllocTemp(BusName);
			UAkGameplayStatics.__SetBusConfig_Internal(fstring, ChannelConfiguration);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0002D791 File Offset: 0x0002B991
		public static bool SetAuxBusEffect(UAkAuxBus InAuxBus, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
		{
			return UAkGameplayStatics.__SetAuxBusEffect_Internal((InAuxBus != null) ? InAuxBus.NativePtr : IntPtr.Zero, InEffectIndex, (InEffectShareSet != null) ? InEffectShareSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0002D7B9 File Offset: 0x0002B9B9
		public static bool SetActorMixerEffect(FAkUniqueID InAudioNodeID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
		{
			return UAkGameplayStatics.__SetActorMixerEffect_Internal((InAudioNodeID ?? new FAkUniqueID()).NativePtr, InEffectIndex, (InEffectShareSet != null) ? InEffectShareSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		public static void ResetRTPCValue(UAkRtpc RTPCValue, int InterpolationTimeMs, AActor Actor, FName RTPC)
		{
			UAkGameplayStatics.__ResetRTPCValue_Internal((RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, InterpolationTimeMs, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, RTPC);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0002D809 File Offset: 0x0002BA09
		public static void ReplaceMainOutput(in FAkOutputSettings MainOutputSettings)
		{
			UAkGameplayStatics.__ReplaceMainOutput_Internal((MainOutputSettings ?? new FAkOutputSettings()).NativePtr);
		}

		// Token: 0x06001EA2 RID: 7842
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RenderAudio();

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0002D820 File Offset: 0x0002BA20
		public static void RemoveOutput(FAkOutputDeviceID in_OutputDeviceId)
		{
			UAkGameplayStatics.__RemoveOutput_Internal((in_OutputDeviceId ?? new FAkOutputDeviceID()).NativePtr);
		}

		// Token: 0x06001EA4 RID: 7844
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReloadAudioAssetData();

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0002D836 File Offset: 0x0002BA36
		public static void PostTrigger(UAkTrigger TriggerValue, AActor Actor, FName Trigger)
		{
			UAkGameplayStatics.__PostTrigger_Internal((TriggerValue != null) ? TriggerValue.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Trigger);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0002D860 File Offset: 0x0002BA60
		[NullableContext(1)]
		public unsafe static void PostEventByName(string EventName, [Nullable(2)] AActor Actor, bool bStopWhenAttachedToDestroyed = false)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkGameplayStatics.__PostEventByName_Internal(fstring, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bStopWhenAttachedToDestroyed);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0002D895 File Offset: 0x0002BA95
		public static int PostEventByDummyGameObj(UAkAudioEvent in_pAkEvent, in FOnAkPostEventCallback PostEventCallback)
		{
			IntPtr in_pAkEvent2 = (in_pAkEvent != null) ? in_pAkEvent.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			return UAkGameplayStatics.__PostEventByDummyGameObj_Internal(in_pAkEvent2, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0002D8BC File Offset: 0x0002BABC
		[NullableContext(1)]
		public unsafe static void PostEventAtLocationByName(string EventName, FVector Location, FRotator Orientation, [Nullable(2)] UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			UAkGameplayStatics.__PostEventAtLocationByName_Internal(fstring, Location, Orientation, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		public unsafe static int PostEventAtLocation(UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, [Nullable(1)] string EventName, UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			int result = UAkGameplayStatics.__PostEventAtLocation_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, fstring, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0002D93C File Offset: 0x0002BB3C
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

		// Token: 0x06001EAB RID: 7851 RVA: 0x0002D994 File Offset: 0x0002BB94
		public unsafe static void PostAndWaitForEndOfEventAsync(UAkAudioEvent AkEvent, AActor Actor, ref int PlayingID, bool bStopWhenAttachedToDestroyed, FLatentActionInfo LatentInfo)
		{
			fixed (int* ptr = &PlayingID)
			{
				void* ptr2 = (void*)ptr;
				UAkGameplayStatics.__PostAndWaitForEndOfEventAsync_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref PlayingID, bStopWhenAttachedToDestroyed, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
		public static int PostAndWaitForEndOfEvent(UAkAudioEvent AkEvent, AActor Actor, bool bStopWhenAttachedToDestroyed, FLatentActionInfo LatentInfo)
		{
			return UAkGameplayStatics.__PostAndWaitForEndOfEvent_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bStopWhenAttachedToDestroyed, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x06001EAD RID: 7853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadInitBank();

		// Token: 0x06001EAE RID: 7854 RVA: 0x0002DA18 File Offset: 0x0002BC18
		[NullableContext(1)]
		public unsafe static void LoadBankByName(string BankName)
		{
			FString fstring = FString.AllocTemp(BankName);
			UAkGameplayStatics.__LoadBankByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		public static bool IsGame(UObject WorldContextObject)
		{
			return UAkGameplayStatics.__IsGame_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001EB0 RID: 7856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEditor();

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0002DA53 File Offset: 0x0002BC53
		public static bool IsAudioEventActive(UAkAudioEvent AudioEvent)
		{
			return UAkGameplayStatics.__IsAudioEventActive_Internal((AudioEvent != null) ? AudioEvent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0002DA6C File Offset: 0x0002BC6C
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

		// Token: 0x06001EB3 RID: 7859
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSourcePlayPosition(int PlayingID);

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0002DAAC File Offset: 0x0002BCAC
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

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[NullableContext(1)]
		public static string GetCurrentAudioCulture()
		{
			return FString.ToStringAndDeleteNativePtr(UAkGameplayStatics.__GetCurrentAudioCulture_Internal());
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0002DB04 File Offset: 0x0002BD04
		[NullableContext(1)]
		public static TArray<string> GetAvailableAudioCultures()
		{
			return new TArray<string>(UAkGameplayStatics.__GetAvailableAudioCultures_Internal(), null);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0002DB14 File Offset: 0x0002BD14
		public unsafe static UAkComponent GetAkComponent(USceneComponent AttachToComponent, ref bool ComponentCreated, FName AttachPointName = default(FName), FVector Location = default(FVector), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset)
		{
			fixed (bool* ptr = &ComponentCreated)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(UAkGameplayStatics.__GetAkComponent_Internal((AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, ref ComponentCreated, AttachPointName, Location, LocationType));
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0002DB4A File Offset: 0x0002BD4A
		public static UObject GetAkAudioTypeUserData(UAkAudioType Instance, UClassStackOnlyPtr Type)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UAkGameplayStatics.__GetAkAudioTypeUserData_Internal((Instance != null) ? Instance.NativePtr : IntPtr.Zero, Type._NativePtr));
		}

		// Token: 0x06001EB9 RID: 7865
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteActionOnPlayingID(EAkActionOnEventType ActionType, int PlayingID, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear);

		// Token: 0x06001EBA RID: 7866 RVA: 0x0002DB6C File Offset: 0x0002BD6C
		public static void ExecuteActionOnEvent(UAkAudioEvent AkEvent, EAkActionOnEventType ActionType, AActor Actor, int TransitionDuration = 0, EAkCurveInterpolation FadeCurve = EAkCurveInterpolation.Linear, int PlayingID = 0)
		{
			UAkGameplayStatics.__ExecuteActionOnEvent_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, ActionType, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, TransitionDuration, FadeCurve, PlayingID);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0002DB99 File Offset: 0x0002BD99
		public static void D_SetMultiplePositions(UAkComponent GameObjectAkComponent, TArray<FTransformDouble> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
		{
			UAkGameplayStatics.__D_SetMultiplePositions_Internal((GameObjectAkComponent != null) ? GameObjectAkComponent.NativePtr : IntPtr.Zero, (Positions ?? new TArray<FTransformDouble>()).NativePtr, MultiPositionType);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
		public unsafe static int D_PostEventAtLocation(UAkAudioEvent AkEvent, FVectorDouble Location, FRotator Orientation, [Nullable(1)] string EventName, UObject WorldContextObject)
		{
			FString fstring = FString.AllocTemp(EventName);
			int result = UAkGameplayStatics.__D_PostEventAtLocation_Internal((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation, fstring, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001EBD RID: 7869
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearSoundBanksAndMedia();

		// Token: 0x06001EBE RID: 7870
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearBanks();

		// Token: 0x06001EBF RID: 7871 RVA: 0x0002DC08 File Offset: 0x0002BE08
		public static void CancelEventCallback(in FOnAkPostEventCallback PostEventCallback)
		{
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			UAkGameplayStatics.__CancelEventCallback_Internal((fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0002DC20 File Offset: 0x0002BE20
		[NullableContext(1)]
		public unsafe static void AddOutputCaptureMarker(string MarkerText)
		{
			FString fstring = FString.AllocTemp(MarkerText);
			UAkGameplayStatics.__AddOutputCaptureMarker_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0002DC44 File Offset: 0x0002BE44
		public static void AddOutput(in FAkOutputSettings in_Settings, ref FAkOutputDeviceID out_DeviceID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAkComponent> in_ListenerIDs)
		{
			UAkGameplayStatics.__AddOutput_Internal((in_Settings ?? new FAkOutputSettings()).NativePtr, (out_DeviceID ?? new FAkOutputDeviceID()).NativePtr, (in_ListenerIDs ?? new TArray<UAkComponent>()).NativePtr);
		}

		// Token: 0x06001EC2 RID: 7874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseReverbVolumes_Internal(bool inUseReverbVolumes, IntPtr Actor);

		// Token: 0x06001EC3 RID: 7875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseEarlyReflections_Internal(IntPtr Actor, IntPtr AuxBus, int Order, float BusSendGain, float MaxPathLength, bool SpotReflectors, in FString AuxBusName);

		// Token: 0x06001EC4 RID: 7876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadBankByName_Internal(in FString BankName);

		// Token: 0x06001EC5 RID: 7877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllAmbientSounds_Internal(IntPtr WorldContextObject);

		// Token: 0x06001EC6 RID: 7878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopActor_Internal(IntPtr Actor);

		// Token: 0x06001EC7 RID: 7879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartProfilerCapture_Internal(in FString Filename);

		// Token: 0x06001EC8 RID: 7880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartOutputCapture_Internal(in FString Filename);

		// Token: 0x06001EC9 RID: 7881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAllAmbientSounds_Internal(IntPtr WorldContextObject);

		// Token: 0x06001ECA RID: 7882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnAkComponentAtLocation_Internal(IntPtr WorldContextObject, IntPtr AkEvent, FVector Location, FRotator Orientation, bool AutoPost, in FString EventName, bool AutoDestroy);

		// Token: 0x06001ECB RID: 7883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(IntPtr SwitchValue, IntPtr Actor, FName SwitchGroup, FName SwitchState);

		// Token: 0x06001ECC RID: 7884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(IntPtr StateValue, FName StateGroup, FName State);

		// Token: 0x06001ECD RID: 7885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpeakerAngles_Internal(IntPtr SpeakerAngles, float HeightAngle, in FString DeviceShareSet);

		// Token: 0x06001ECE RID: 7886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRTPCValue_Internal(IntPtr RTPCValue, float Value, int InterpolationTimeMs, IntPtr Actor, FName RTPC);

		// Token: 0x06001ECF RID: 7887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPortalToPortalObstruction_Internal(IntPtr PortalComponent0, IntPtr PortalComponent1, float ObstructionValue);

		// Token: 0x06001ED0 RID: 7888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPortalObstructionAndOcclusion_Internal(IntPtr PortalComponent, float ObstructionValue, float OcclusionValue);

		// Token: 0x06001ED1 RID: 7889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetOutputDeviceEffect_Internal(IntPtr InDeviceID, int InEffectIndex, IntPtr InEffectShareSet);

		// Token: 0x06001ED2 RID: 7890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutputBusVolume_Internal(float BusVolume, IntPtr Actor);

		// Token: 0x06001ED3 RID: 7891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMultiplePositions_Internal(IntPtr GameObjectAkComponent, IntPtr Positions, EAkMultiPositionType MultiPositionType);

		// Token: 0x06001ED4 RID: 7892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameObjectToPortalObstruction_Internal(IntPtr GameObjectAkComponent, IntPtr PortalComponent, float ObstructionValue);

		// Token: 0x06001ED5 RID: 7893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceProbe_Internal(IntPtr Listener, IntPtr DistanceProbe);

		// Token: 0x06001ED6 RID: 7894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentAudioCultureAsync_Internal(in FString AudioCulture, IntPtr Completed);

		// Token: 0x06001ED7 RID: 7895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentAudioCulture_Internal(in FString AudioCulture, IntPtr LatentInfo, IntPtr WorldContextObject);

		// Token: 0x06001ED8 RID: 7896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBusEffectByName_Internal(in FString InBusName, int InEffectIndex, IntPtr InEffectShareSet);

		// Token: 0x06001ED9 RID: 7897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBusEffectByID_Internal(IntPtr InBusID, int InEffectIndex, IntPtr InEffectShareSet);

		// Token: 0x06001EDA RID: 7898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBusConfig_Internal(in FString BusName, EAkChannelConfiguration ChannelConfiguration);

		// Token: 0x06001EDB RID: 7899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAuxBusEffect_Internal(IntPtr InAuxBus, int InEffectIndex, IntPtr InEffectShareSet);

		// Token: 0x06001EDC RID: 7900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorMixerEffect_Internal(IntPtr InAudioNodeID, int InEffectIndex, IntPtr InEffectShareSet);

		// Token: 0x06001EDD RID: 7901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRTPCValue_Internal(IntPtr RTPCValue, int InterpolationTimeMs, IntPtr Actor, FName RTPC);

		// Token: 0x06001EDE RID: 7902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplaceMainOutput_Internal(IntPtr MainOutputSettings);

		// Token: 0x06001EDF RID: 7903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveOutput_Internal(IntPtr in_OutputDeviceId);

		// Token: 0x06001EE0 RID: 7904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostTrigger_Internal(IntPtr TriggerValue, IntPtr Actor, FName Trigger);

		// Token: 0x06001EE1 RID: 7905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventByName_Internal(in FString EventName, IntPtr Actor, bool bStopWhenAttachedToDestroyed);

		// Token: 0x06001EE2 RID: 7906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEventByDummyGameObj_Internal(IntPtr in_pAkEvent, IntPtr PostEventCallback);

		// Token: 0x06001EE3 RID: 7907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEventAtLocationByName_Internal(in FString EventName, FVector Location, FRotator Orientation, IntPtr WorldContextObject);

		// Token: 0x06001EE4 RID: 7908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEventAtLocation_Internal(IntPtr AkEvent, FVector Location, FRotator Orientation, in FString EventName, IntPtr WorldContextObject);

		// Token: 0x06001EE5 RID: 7909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostEvent_Internal(IntPtr AkEvent, IntPtr Actor, int CallbackMask, IntPtr PostEventCallback, bool bStopWhenAttachedToDestroyed, in FString EventName);

		// Token: 0x06001EE6 RID: 7910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostAndWaitForEndOfEventAsync_Internal(IntPtr AkEvent, IntPtr Actor, ref int PlayingID, bool bStopWhenAttachedToDestroyed, IntPtr LatentInfo);

		// Token: 0x06001EE7 RID: 7911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAndWaitForEndOfEvent_Internal(IntPtr AkEvent, IntPtr Actor, bool bStopWhenAttachedToDestroyed, IntPtr LatentInfo);

		// Token: 0x06001EE8 RID: 7912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadBankByName_Internal(in FString BankName);

		// Token: 0x06001EE9 RID: 7913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGame_Internal(IntPtr WorldContextObject);

		// Token: 0x06001EEA RID: 7914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAudioEventActive_Internal(IntPtr AudioEvent);

		// Token: 0x06001EEB RID: 7915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpeakerAngles_Internal(IntPtr SpeakerAngles, ref float HeightAngle, in FString DeviceShareSet);

		// Token: 0x06001EEC RID: 7916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRTPCValue_Internal(IntPtr RTPCValue, int PlayingID, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, IntPtr Actor, FName RTPC);

		// Token: 0x06001EED RID: 7917
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentAudioCulture_Internal();

		// Token: 0x06001EEE RID: 7918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAvailableAudioCultures_Internal();

		// Token: 0x06001EEF RID: 7919
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkComponent_Internal(IntPtr AttachToComponent, ref bool ComponentCreated, FName AttachPointName, FVector Location, TEnumAsByte<EAttachLocation> LocationType);

		// Token: 0x06001EF0 RID: 7920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAkAudioTypeUserData_Internal(IntPtr Instance, IntPtr Type);

		// Token: 0x06001EF1 RID: 7921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteActionOnEvent_Internal(IntPtr AkEvent, EAkActionOnEventType ActionType, IntPtr Actor, int TransitionDuration, EAkCurveInterpolation FadeCurve, int PlayingID);

		// Token: 0x06001EF2 RID: 7922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetMultiplePositions_Internal(IntPtr GameObjectAkComponent, IntPtr Positions, EAkMultiPositionType MultiPositionType);

		// Token: 0x06001EF3 RID: 7923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __D_PostEventAtLocation_Internal(IntPtr AkEvent, FVectorDouble Location, FRotator Orientation, in FString EventName, IntPtr WorldContextObject);

		// Token: 0x06001EF4 RID: 7924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelEventCallback_Internal(IntPtr PostEventCallback);

		// Token: 0x06001EF5 RID: 7925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOutputCaptureMarker_Internal(in FString MarkerText);

		// Token: 0x06001EF6 RID: 7926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOutput_Internal(IntPtr in_Settings, IntPtr out_DeviceID, IntPtr in_ListenerIDs);

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0002DC7B File Offset: 0x0002BE7B
		static UAkGameplayStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGameplayStatics");
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0002DC89 File Offset: 0x0002BE89
		protected UAkGameplayStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A20 RID: 2592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkGameplayStatics";

		// Token: 0x04000A21 RID: 2593
		private static IntPtr _ClassPtr;

		// Token: 0x04000A22 RID: 2594
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
