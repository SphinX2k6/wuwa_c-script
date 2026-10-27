using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C00 RID: 3072
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameplayStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGameplayStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600988A RID: 39050 RVA: 0x000D91F6 File Offset: 0x000D73F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayStatics._ClassPtr;
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x000D9204 File Offset: 0x000D7404
		public UGameplayStatics() : this(BuiltinUtils.AllocNativeUObject(UGameplayStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x000D922C File Offset: 0x000D742C
		[NullableContext(1)]
		public UGameplayStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x000D9260 File Offset: 0x000D7460
		[NullableContext(1)]
		public unsafe static void UpdatePostProcessVolumeDepthFile([Nullable(2)] UObject WorldContextObject, string TagName, float focalDepth = 212.8f, float focalOffset = 57.8f, float maxDepth = 65000f, float blurRadias = 2f, float edgeBias = 0f, float farTransition = 0f, float nearTransition = 0f)
		{
			FString fstring = FString.AllocTemp(TagName);
			UGameplayStatics.__UpdatePostProcessVolumeDepthFile_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, focalDepth, focalOffset, maxDepth, blurRadias, edgeBias, farTransition, nearTransition);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x000D92A0 File Offset: 0x000D74A0
		public static void UnloadStreamLevelRecursively(UObject WorldContextObject, FName LevelName, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
		{
			UGameplayStatics.__UnloadStreamLevelRecursively_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, (LatentInfo ?? new FLatentActionInfo()).NativePtr, bShouldBlockOnUnload);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x000D92C8 File Offset: 0x000D74C8
		public static void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject, [Nullable(1)] TSoftObjectPtr<UWorld> Level, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
		{
			UGameplayStatics.__UnloadStreamLevelBySoftObjectPtr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Level ?? new TSoftObjectPtr<UWorld>()).NativePtr, (LatentInfo ?? new FLatentActionInfo()).NativePtr, bShouldBlockOnUnload);
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x000D92FE File Offset: 0x000D74FE
		public static void UnloadStreamLevel(UObject WorldContextObject, FName LevelName, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
		{
			UGameplayStatics.__UnloadStreamLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, (LatentInfo ?? new FLatentActionInfo()).NativePtr, bShouldBlockOnUnload);
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x000D9328 File Offset: 0x000D7528
		public unsafe static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject, ref FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ = 0f, float ArcParam = 0.5f)
		{
			fixed (FVector* ptr = &OutLaunchVelocity)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__SuggestProjectileVelocity_CustomArc_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref OutLaunchVelocity, StartPos, EndPos, OverrideGravityZ, ArcParam);
			}
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x000D9358 File Offset: 0x000D7558
		public static UAudioComponent SpawnSoundAttached(USoundBase Sound, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnSoundAttached_Internal((Sound != null) ? Sound.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x000D93C8 File Offset: 0x000D75C8
		public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation = default(FRotator), float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnSoundAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x000D9430 File Offset: 0x000D7630
		public static UAudioComponent SpawnSound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundConcurrency ConcurrencySettings = null, bool bPersistAcrossLevelTransition = false, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnSound2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, VolumeMultiplier, PitchMultiplier, StartTime, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, bPersistAcrossLevelTransition, bAutoDestroy));
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x000D9481 File Offset: 0x000D7681
		public static UObject SpawnObject(UClassStackOnlyPtr ObjectClass, UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UGameplayStatics.__SpawnObject_Internal(ObjectClass._NativePtr, (Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x000D94A4 File Offset: 0x000D76A4
		public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__SpawnForceFeedbackAttached_Internal((ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x000D9504 File Offset: 0x000D7704
		public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVector Location, FRotator Rotation = default(FRotator), bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__SpawnForceFeedbackAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Location, Rotation, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x000D9558 File Offset: 0x000D7758
		public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), FVector? Scale = null, EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bAutoDestroy = true, EPSCPoolMethod PoolingMethod = EPSCPoolMethod.None, bool bAutoActivate = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UParticleSystemComponent>(UGameplayStatics.__SpawnEmitterAttached_Internal((EmitterTemplate != null) ? EmitterTemplate.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, Scale ?? new FVector(1f, 1f, 1f), LocationType, bAutoDestroy, PoolingMethod, bAutoActivate));
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x000D95CC File Offset: 0x000D77CC
		public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject, UParticleSystem EmitterTemplate, FVector Location, FRotator Rotation = default(FRotator), FVector? Scale = null, bool bAutoDestroy = true, EPSCPoolMethod PoolingMethod = EPSCPoolMethod.None, bool bAutoActivateSystem = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UParticleSystemComponent>(UGameplayStatics.__SpawnEmitterAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (EmitterTemplate != null) ? EmitterTemplate.NativePtr : IntPtr.Zero, Location, Rotation, Scale ?? new FVector(1f, 1f, 1f), bAutoDestroy, PoolingMethod, bAutoActivateSystem));
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x000D9634 File Offset: 0x000D7834
		public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue, in FDialogueContext Context, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnDialogueAttached_Internal((Dialogue != null) ? Dialogue.NativePtr : IntPtr.Zero, (Context ?? new FDialogueContext()).NativePtr, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x000D96A4 File Offset: 0x000D78A4
		public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject, UDialogueWave Dialogue, in FDialogueContext Context, FVector Location, FRotator Rotation = default(FRotator), float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnDialogueAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Dialogue != null) ? Dialogue.NativePtr : IntPtr.Zero, (Context ?? new FDialogueContext()).NativePtr, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x000D9708 File Offset: 0x000D7908
		public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject, UDialogueWave Dialogue, in FDialogueContext Context, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__SpawnDialogue2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Dialogue != null) ? Dialogue.NativePtr : IntPtr.Zero, (Context ?? new FDialogueContext()).NativePtr, VolumeMultiplier, PitchMultiplier, StartTime, bAutoDestroy));
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x000D9756 File Offset: 0x000D7956
		public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial, FVector DecalSize, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, float LifeSpan = 0f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDecalComponent>(UGameplayStatics.__SpawnDecalAttached_Internal((DecalMaterial != null) ? DecalMaterial.NativePtr : IntPtr.Zero, DecalSize, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, LifeSpan));
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x000D9794 File Offset: 0x000D7994
		public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject, UMaterialInterface DecalMaterial, FVector DecalSize, FVector Location, FRotator? Rotation = null, float LifeSpan = 0f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDecalComponent>(UGameplayStatics.__SpawnDecalAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (DecalMaterial != null) ? DecalMaterial.NativePtr : IntPtr.Zero, DecalSize, Location, Rotation ?? new FRotator(90f, 0f, 0f), LifeSpan));
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x000D97F8 File Offset: 0x000D79F8
		public unsafe static AActor SpawnActorFromClassInLevel(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__SpawnActorFromClassInLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride));
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x000D9843 File Offset: 0x000D7A43
		public static void SetWorldOriginLocation(UObject WorldContextObject, FIntVector NewLocation)
		{
			UGameplayStatics.__SetWorldOriginLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, NewLocation);
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x000D985B File Offset: 0x000D7A5B
		public static void SetViewportMouseCaptureMode(UObject WorldContextObject, EMouseCaptureMode MouseCaptureMode)
		{
			UGameplayStatics.__SetViewportMouseCaptureMode_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, MouseCaptureMode);
		}

		// Token: 0x060098A2 RID: 39074
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSubtitlesEnabled(bool bEnabled);

		// Token: 0x060098A3 RID: 39075 RVA: 0x000D9873 File Offset: 0x000D7A73
		public static void SetSoundMixClassOverride(UObject WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float Volume = 1f, float Pitch = 1f, float FadeInTime = 1f, bool bApplyToChildren = true)
		{
			UGameplayStatics.__SetSoundMixClassOverride_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundMixModifier != null) ? InSoundMixModifier.NativePtr : IntPtr.Zero, (InSoundClass != null) ? InSoundClass.NativePtr : IntPtr.Zero, Volume, Pitch, FadeInTime, bApplyToChildren);
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x000D98B1 File Offset: 0x000D7AB1
		public static void SetSoundClassDistanceScale(UObject WorldContextObject, USoundClass SoundClass, float DistanceAttenuationScale, float TimeSec = 0f)
		{
			UGameplayStatics.__SetSoundClassDistanceScale_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SoundClass != null) ? SoundClass.NativePtr : IntPtr.Zero, DistanceAttenuationScale, TimeSec);
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x000D98DA File Offset: 0x000D7ADA
		public static void SetPlayerControllerID(APlayerController Player, int ControllerId)
		{
			UGameplayStatics.__SetPlayerControllerID_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ControllerId);
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x000D98F2 File Offset: 0x000D7AF2
		public static void SetMaxAudioChannelsScaled(UObject WorldContextObject, float MaxChannelCountScale)
		{
			UGameplayStatics.__SetMaxAudioChannelsScaled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, MaxChannelCountScale);
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x000D990A File Offset: 0x000D7B0A
		public static void SetGlobalTimeDilation(UObject WorldContextObject, float TimeDilation)
		{
			UGameplayStatics.__SetGlobalTimeDilation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TimeDilation);
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x000D9922 File Offset: 0x000D7B22
		public static void SetGlobalPitchModulation(UObject WorldContextObject, float PitchModulation, float TimeSec)
		{
			UGameplayStatics.__SetGlobalPitchModulation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PitchModulation, TimeSec);
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x000D993C File Offset: 0x000D7B3C
		public static void SetGlobalListenerFocusParameters(UObject WorldContextObject, float FocusAzimuthScale = 1f, float NonFocusAzimuthScale = 1f, float FocusDistanceScale = 1f, float NonFocusDistanceScale = 1f, float FocusVolumeScale = 1f, float NonFocusVolumeScale = 1f, float FocusPriorityScale = 1f, float NonFocusPriorityScale = 1f)
		{
			UGameplayStatics.__SetGlobalListenerFocusParameters_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, FocusAzimuthScale, NonFocusAzimuthScale, FocusDistanceScale, NonFocusDistanceScale, FocusVolumeScale, NonFocusVolumeScale, FocusPriorityScale, NonFocusPriorityScale);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x000D996B File Offset: 0x000D7B6B
		public static bool SetGamePaused(UObject WorldContextObject, bool bPaused)
		{
			return UGameplayStatics.__SetGamePaused_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bPaused);
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x000D9983 File Offset: 0x000D7B83
		public static void SetForceDisableSplitscreen(UObject WorldContextObject, bool bDisable)
		{
			UGameplayStatics.__SetForceDisableSplitscreen_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bDisable);
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x000D999B File Offset: 0x000D7B9B
		public static void SetEnableWorldRendering(UObject WorldContextObject, bool bEnable)
		{
			UGameplayStatics.__SetEnableWorldRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bEnable);
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x000D99B3 File Offset: 0x000D7BB3
		public static void SetBaseSoundMix(UObject WorldContextObject, USoundMix InSoundMix)
		{
			UGameplayStatics.__SetBaseSoundMix_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundMix != null) ? InSoundMix.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x000D99DC File Offset: 0x000D7BDC
		[NullableContext(1)]
		public unsafe static bool SaveGameToSlot([Nullable(2)] USaveGame SaveGameObject, string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = UGameplayStatics.__SaveGameToSlot_Internal((SaveGameObject != null) ? SaveGameObject.NativePtr : IntPtr.Zero, fstring, UserIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x000D9A11 File Offset: 0x000D7C11
		public static void RemovePlayer(APlayerController Player, bool bDestroyPawn)
		{
			UGameplayStatics.__RemovePlayer_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, bDestroyPawn);
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x000D9A29 File Offset: 0x000D7C29
		public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject, FVector WorldLocation)
		{
			return UGameplayStatics.__RebaseZeroOriginOntoLocal_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldLocation);
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x000D9A41 File Offset: 0x000D7C41
		public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject, FVector WorldLocation)
		{
			return UGameplayStatics.__RebaseLocalOriginOntoZero_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldLocation);
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x000D9A59 File Offset: 0x000D7C59
		public static void PushSoundMixModifier(UObject WorldContextObject, USoundMix InSoundMixModifier)
		{
			UGameplayStatics.__PushSoundMixModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundMixModifier != null) ? InSoundMixModifier.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x000D9A80 File Offset: 0x000D7C80
		public unsafe static bool ProjectWorldToScreen(APlayerController Player, in FVector WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__ProjectWorldToScreen_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, WorldPosition, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x000D9AAA File Offset: 0x000D7CAA
		public static void PrimeSound(USoundBase InSound)
		{
			UGameplayStatics.__PrimeSound_Internal((InSound != null) ? InSound.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x000D9AC1 File Offset: 0x000D7CC1
		public static void PopSoundMixModifier(UObject WorldContextObject, USoundMix InSoundMixModifier)
		{
			UGameplayStatics.__PopSoundMixModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundMixModifier != null) ? InSoundMixModifier.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x000D9AE8 File Offset: 0x000D7CE8
		public static void PlayWorldCameraShakeWithModifier(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false, float ShakeModifier = 1f, float TimeDilation = 1f)
		{
			UGameplayStatics.__PlayWorldCameraShakeWithModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter, ShakeModifier, TimeDilation);
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x000D9B1C File Offset: 0x000D7D1C
		public static void PlayWorldCameraShake(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false)
		{
			UGameplayStatics.__PlayWorldCameraShake_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x000D9B44 File Offset: 0x000D7D44
		public static void PlaySoundAtLocation(UObject WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null, USoundConcurrency ConcurrencySettings = null, AActor OwningActor = null)
		{
			UGameplayStatics.__PlaySoundAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, (OwningActor != null) ? OwningActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x000D9BB4 File Offset: 0x000D7DB4
		public static void PlaySound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundConcurrency ConcurrencySettings = null, AActor OwningActor = null, bool bIsUISound = true)
		{
			UGameplayStatics.__PlaySound2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, VolumeMultiplier, PitchMultiplier, StartTime, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, (OwningActor != null) ? OwningActor.NativePtr : IntPtr.Zero, bIsUISound);
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x000D9C10 File Offset: 0x000D7E10
		public static void PlayDialogueAtLocation(UObject WorldContextObject, UDialogueWave Dialogue, in FDialogueContext Context, FVector Location, FRotator Rotation, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundAttenuation AttenuationSettings = null)
		{
			UGameplayStatics.__PlayDialogueAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Dialogue != null) ? Dialogue.NativePtr : IntPtr.Zero, (Context ?? new FDialogueContext()).NativePtr, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x000D9C6D File Offset: 0x000D7E6D
		public static void PlayDialogue2D(UObject WorldContextObject, UDialogueWave Dialogue, in FDialogueContext Context, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f)
		{
			UGameplayStatics.__PlayDialogue2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Dialogue != null) ? Dialogue.NativePtr : IntPtr.Zero, (Context ?? new FDialogueContext()).NativePtr, VolumeMultiplier, PitchMultiplier, StartTime);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x000D9CAC File Offset: 0x000D7EAC
		[NullableContext(1)]
		public unsafe static string ParseOption(string Options, string Key)
		{
			FString fstring = FString.AllocTemp(Options);
			FString fstring2 = FString.AllocTemp(Key);
			string result = FString.ToStringAndDeleteNativePtr(UGameplayStatics.__ParseOption_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x000D9CE8 File Offset: 0x000D7EE8
		[NullableContext(1)]
		public unsafe static void OpenLevelBySoftObjectPtr([Nullable(2)] UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, bool bAbsolute = true, string Options = "")
		{
			FString fstring = FString.AllocTemp(Options);
			UGameplayStatics.__OpenLevelBySoftObjectPtr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Level ?? new TSoftObjectPtr<UWorld>()).NativePtr, bAbsolute, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x000D9D2C File Offset: 0x000D7F2C
		[NullableContext(1)]
		public unsafe static void OpenLevel([Nullable(2)] UObject WorldContextObject, FName LevelName, bool bAbsolute = true, string Options = "")
		{
			FString fstring = FString.AllocTemp(Options);
			UGameplayStatics.__OpenLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, bAbsolute, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x000D9D64 File Offset: 0x000D7F64
		[return: Nullable(1)]
		public static FHitResultDouble MakeHitResultDouble(bool bBlockingHit, bool bInitialOverlap, float Time, double Distance, FVectorDouble Location, FVectorDouble ImpactPoint, FVectorDouble Normal, FVectorDouble ImpactNormal, UPhysicalMaterial PhysMat, AActor HitActor, UPrimitiveComponent HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVectorDouble TraceStart, FVectorDouble TraceEnd)
		{
			return new FHitResultDouble(UGameplayStatics.__MakeHitResultDouble_Internal(bBlockingHit, bInitialOverlap, Time, Distance, Location, ImpactPoint, Normal, ImpactNormal, (PhysMat != null) ? PhysMat.NativePtr : IntPtr.Zero, (HitActor != null) ? HitActor.NativePtr : IntPtr.Zero, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, HitBoneName, HitItem, FaceIndex, TraceStart, TraceEnd), null);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x000D9DC8 File Offset: 0x000D7FC8
		[return: Nullable(1)]
		public static FHitResult MakeHitResult(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, FVector Location, FVector ImpactPoint, FVector Normal, FVector ImpactNormal, UPhysicalMaterial PhysMat, AActor HitActor, UPrimitiveComponent HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVector TraceStart, FVector TraceEnd)
		{
			return new FHitResult(UGameplayStatics.__MakeHitResult_Internal(bBlockingHit, bInitialOverlap, Time, Distance, Location, ImpactPoint, Normal, ImpactNormal, (PhysMat != null) ? PhysMat.NativePtr : IntPtr.Zero, (HitActor != null) ? HitActor.NativePtr : IntPtr.Zero, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, HitBoneName, HitItem, FaceIndex, TraceStart, TraceEnd), null);
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x000D9E2C File Offset: 0x000D802C
		public static void LoadStreamLevelRecursively(UObject WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
		{
			UGameplayStatics.__LoadStreamLevelRecursively_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, bMakeVisibleAfterLoad, bShouldBlockOnLoad, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x000D9E56 File Offset: 0x000D8056
		public static void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject, [Nullable(1)] TSoftObjectPtr<UWorld> Level, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
		{
			UGameplayStatics.__LoadStreamLevelBySoftObjectPtr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Level ?? new TSoftObjectPtr<UWorld>()).NativePtr, bMakeVisibleAfterLoad, bShouldBlockOnLoad, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x000D9E8E File Offset: 0x000D808E
		public static void LoadStreamLevel(UObject WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
		{
			UGameplayStatics.__LoadStreamLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, bMakeVisibleAfterLoad, bShouldBlockOnLoad, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x000D9EB8 File Offset: 0x000D80B8
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static USaveGame LoadGameFromSlot(string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			USaveGame orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USaveGame>(UGameplayStatics.__LoadGameFromSlot_Internal(fstring, UserIndex));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x000D9EE4 File Offset: 0x000D80E4
		public unsafe static bool KuroFindCollisionUV(in FHitResult Hit, int UVChannel, ref FVector2D UV)
		{
			fixed (FVector2D* ptr = &UV)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__KuroFindCollisionUV_Internal((Hit ?? new FHitResult()).NativePtr, UVChannel, ref UV);
			}
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x000D9F0D File Offset: 0x000D810D
		public static bool IsSplitscreenForceDisabled(UObject WorldContextObject)
		{
			return UGameplayStatics.__IsSplitscreenForceDisabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x000D9F24 File Offset: 0x000D8124
		public static bool IsGamePaused(UObject WorldContextObject)
		{
			return UGameplayStatics.__IsGamePaused_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x000D9F3C File Offset: 0x000D813C
		[NullableContext(1)]
		public unsafe static bool HasOption(string Options, string InKey)
		{
			FString fstring = FString.AllocTemp(Options);
			FString fstring2 = FString.AllocTemp(InKey);
			bool result = UGameplayStatics.__HasOption_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x000D9F74 File Offset: 0x000D8174
		[NullableContext(1)]
		public unsafe static bool HasLaunchOption(string OptionToCheck)
		{
			FString fstring = FString.AllocTemp(OptionToCheck);
			bool result = UGameplayStatics.__HasLaunchOption_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x000D9F98 File Offset: 0x000D8198
		public static int GrassOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
		{
			return UGameplayStatics.__GrassOverlappingSphereCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, CenterPosition, Radius);
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x000D9FC1 File Offset: 0x000D81C1
		public static FIntVector GetWorldOriginLocation(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetWorldOriginLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x000D9FD8 File Offset: 0x000D81D8
		public static float GetWorldDeltaSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetWorldDeltaSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x000D9FF0 File Offset: 0x000D81F0
		public unsafe static bool GetWorldCameraTransform(UWorld InWorld, ref FTransform OutCameraTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutCameraTransform;
			bool result = UGameplayStatics.__GetWorldCameraTransform_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref ptr);
			OutCameraTransform = ptr;
			return result;
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x000DA03C File Offset: 0x000D823C
		public unsafe static bool GetWorldCameraLocation(UWorld InWorld, ref FVector OutCameraLocation)
		{
			fixed (FVector* ptr = &OutCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__GetWorldCameraLocation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref OutCameraLocation);
			}
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x000DA064 File Offset: 0x000D8264
		public unsafe static void GetViewProjectionMatrix(FMinimalViewInfo DesiredView, ref FMatrix ViewMatrix, ref FMatrix ProjectionMatrix, ref FMatrix ViewProjectionMatrix)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = ViewMatrix;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = ProjectionMatrix;
			ref FMatrix ptr3 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr3 = ViewProjectionMatrix;
			UGameplayStatics.__GetViewProjectionMatrix_Internal((DesiredView ?? new FMinimalViewInfo()).NativePtr, ref ptr, ref ptr2, ref ptr3);
			ViewMatrix = ptr;
			ProjectionMatrix = ptr2;
			ViewProjectionMatrix = ptr3;
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x000DA100 File Offset: 0x000D8300
		public static EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetViewportMouseCaptureMode_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x000DA117 File Offset: 0x000D8317
		public static float GetUnpausedTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetUnpausedTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x000DA12E File Offset: 0x000D832E
		public static float GetTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x000DA145 File Offset: 0x000D8345
		[NullableContext(0)]
		public static TEnumAsByte<EPhysicalSurface> GetSurfaceType([Nullable(2)] in FHitResult Hit)
		{
			return UGameplayStatics.__GetSurfaceType_Internal((Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x000DA15C File Offset: 0x000D835C
		public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject, FName PackageName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreaming>(UGameplayStatics.__GetStreamingLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PackageName));
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x000DA179 File Offset: 0x000D8379
		public static float GetRealTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetRealTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x000DA190 File Offset: 0x000D8390
		public static APawn GetPlayerPawn(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UGameplayStatics.__GetPlayerPawn_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x000DA1AD File Offset: 0x000D83AD
		public static int GetPlayerControllerID(APlayerController Player)
		{
			return UGameplayStatics.__GetPlayerControllerID_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x000DA1C4 File Offset: 0x000D83C4
		public static APlayerController GetPlayerControllerFromID(UObject WorldContextObject, int ControllerID)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__GetPlayerControllerFromID_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControllerID));
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x000DA1E1 File Offset: 0x000D83E1
		public static APlayerController GetPlayerController(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__GetPlayerController_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060098DA RID: 39130 RVA: 0x000DA1FE File Offset: 0x000D83FE
		public static ACharacter GetPlayerCharacter(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(UGameplayStatics.__GetPlayerCharacter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x000DA21B File Offset: 0x000D841B
		public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(UGameplayStatics.__GetPlayerCameraManager_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x000DA238 File Offset: 0x000D8438
		[NullableContext(1)]
		public static string GetPlatformName()
		{
			return FString.ToStringAndDeleteNativePtr(UGameplayStatics.__GetPlatformName_Internal());
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x000DA244 File Offset: 0x000D8444
		public static UClassStackOnlyPtr GetObjectClass(UObject Object)
		{
			return UGameplayStatics.__GetObjectClass_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x000DA260 File Offset: 0x000D8460
		public static int GetMaxAudioChannelCount(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetMaxAudioChannelCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x000DA278 File Offset: 0x000D8478
		[NullableContext(1)]
		public unsafe static void GetKeyValue(string Pair, ref string Key, ref string Value)
		{
			FString fstring = FString.AllocTemp(Pair);
			FString fstring2 = FString.AllocTemp(Key);
			FString fstring3 = FString.AllocTemp(Value);
			UGameplayStatics.__GetKeyValue_Internal(fstring, ref fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			Key = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			Value = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x000DA2D4 File Offset: 0x000D84D4
		[NullableContext(1)]
		public unsafe static int GetIntOption(string Options, string Key, int DefaultValue)
		{
			FString fstring = FString.AllocTemp(Options);
			FString fstring2 = FString.AllocTemp(Key);
			int result = UGameplayStatics.__GetIntOption_Internal(fstring, fstring2, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x000DA30B File Offset: 0x000D850B
		public static float GetGlobalTimeDilation(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetGlobalTimeDilation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x000DA322 File Offset: 0x000D8522
		public static AGameStateBase GetGameState(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AGameStateBase>(UGameplayStatics.__GetGameState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x000DA33E File Offset: 0x000D853E
		public static float GetGamePlayTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetGamePlayTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x000DA355 File Offset: 0x000D8555
		public static AGameModeBase GetGameMode(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AGameModeBase>(UGameplayStatics.__GetGameMode_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x000DA371 File Offset: 0x000D8571
		public static UGameInstance GetGameInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstance>(UGameplayStatics.__GetGameInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x000DA38D File Offset: 0x000D858D
		public static bool GetEnableWorldRendering(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetEnableWorldRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x000DA3A4 File Offset: 0x000D85A4
		public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UReverbEffect>(UGameplayStatics.__GetCurrentReverbEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x000DA3C0 File Offset: 0x000D85C0
		[NullableContext(1)]
		public static string GetCurrentLevelName([Nullable(2)] UObject WorldContextObject, bool bRemovePrefixString = true)
		{
			return FString.ToStringAndDeleteNativePtr(UGameplayStatics.__GetCurrentLevelName_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bRemovePrefixString));
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x000DA3E0 File Offset: 0x000D85E0
		public unsafe static bool GetClosestListenerLocation(UObject WorldContextObject, in FVector Location, float MaximumRange, bool bAllowAttenuationOverride, ref FVector ListenerPosition)
		{
			fixed (FVector* ptr = &ListenerPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__GetClosestListenerLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, MaximumRange, bAllowAttenuationOverride, ref ListenerPosition);
			}
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x000DA40D File Offset: 0x000D860D
		public static float GetAudioTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetAudioTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x000DA424 File Offset: 0x000D8624
		public static void GetAllActorsWithTag(UObject WorldContextObject, FName Tag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsWithTag_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Tag, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x000DA44C File Offset: 0x000D864C
		public static void GetAllActorsWithInterface(UObject WorldContextObject, UClassStackOnlyPtr Interface, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsWithInterface_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Interface._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x000DA479 File Offset: 0x000D8679
		public static void GetAllActorsOfClassWithTag(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, FName Tag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsOfClassWithTag_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, Tag, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x000DA4A7 File Offset: 0x000D86A7
		public static void GetAllActorsOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x000DA4D4 File Offset: 0x000D86D4
		public unsafe static AActor GetActorOfClassWithName(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, [Nullable(1)] string ActorName)
		{
			FString fstring = FString.AllocTemp(ActorName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__GetActorOfClassWithName_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x000DA513 File Offset: 0x000D8713
		public static AActor GetActorOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__GetActorOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr));
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x000DA535 File Offset: 0x000D8735
		public static int GetActorCountOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return UGameplayStatics.__GetActorCountOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr);
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x000DA554 File Offset: 0x000D8754
		public unsafe static void GetActorArrayBounds([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bOnlyCollidingComponents, ref FVector Center, ref FVector BoxExtent)
		{
			fixed (FVector* ptr = &Center)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoxExtent)
				{
					void* ptr4 = (void*)ptr3;
					UGameplayStatics.__GetActorArrayBounds_Internal((Actors ?? new TArray<AActor>()).NativePtr, bOnlyCollidingComponents, ref Center, ref BoxExtent);
					ptr = null;
				}
			}
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x000DA589 File Offset: 0x000D8789
		public static FVector GetActorArrayAverageLocation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors)
		{
			return UGameplayStatics.__GetActorArrayAverageLocation_Internal((Actors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x000DA5A0 File Offset: 0x000D87A0
		public unsafe static void GetAccurateRealTime(UObject WorldContextObject, ref int Seconds, ref float PartialSeconds)
		{
			fixed (int* ptr = &Seconds)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &PartialSeconds)
				{
					void* ptr4 = (void*)ptr3;
					UGameplayStatics.__GetAccurateRealTime_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref Seconds, ref PartialSeconds);
					ptr = null;
				}
			}
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x000DA5D4 File Offset: 0x000D87D4
		public static void FlushLevelStreaming(UObject WorldContextObject)
		{
			UGameplayStatics.__FlushLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x000DA5EC File Offset: 0x000D87EC
		public unsafe static AActor FinishSpawningActor(AActor Actor, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__FinishSpawningActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x000DA630 File Offset: 0x000D8830
		public unsafe static bool FindCollisionUV(in FHitResult Hit, int UVChannel, ref FVector2D UV)
		{
			fixed (FVector2D* ptr = &UV)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__FindCollisionUV_Internal((Hit ?? new FHitResult()).NativePtr, UVChannel, ref UV);
			}
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x000DA65C File Offset: 0x000D885C
		[NullableContext(1)]
		public unsafe static bool ExportPngPhotoFromFile(string SourceFileName, string Title)
		{
			FString fstring = FString.AllocTemp(SourceFileName);
			FString fstring2 = FString.AllocTemp(Title);
			bool result = UGameplayStatics.__ExportPngPhotoFromFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x000DA694 File Offset: 0x000D8894
		[NullableContext(1)]
		public unsafe static bool ExportPngPhotoFromData([Nullable(2)] in TArray<byte> UserData, string Title)
		{
			FString fstring = FString.AllocTemp(Title);
			bool result = UGameplayStatics.__ExportPngPhotoFromData_Internal((UserData ?? new TArray<byte>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060098FA RID: 39162
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableLiveStreaming(bool Enable);

		// Token: 0x060098FB RID: 39163 RVA: 0x000DA6C8 File Offset: 0x000D88C8
		[NullableContext(1)]
		public unsafe static bool DoesSaveGameExist(string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = UGameplayStatics.__DoesSaveGameExist_Internal(fstring, UserIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x000DA6F0 File Offset: 0x000D88F0
		public unsafe static bool DeprojectScreenToWorld(APlayerController Player, in FVector2D ScreenPosition, ref FVector WorldPosition, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return UGameplayStatics.__DeprojectScreenToWorld_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ScreenPosition, ref WorldPosition, ref WorldDirection);
				}
			}
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x000DA720 File Offset: 0x000D8920
		[NullableContext(1)]
		public unsafe static bool DeleteGameInSlot(string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = UGameplayStatics.__DeleteGameInSlot_Internal(fstring, UserIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x000DA745 File Offset: 0x000D8945
		public static void DeactivateReverbEffect(UObject WorldContextObject, FName TagName)
		{
			UGameplayStatics.__DeactivateReverbEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TagName);
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x000DA760 File Offset: 0x000D8960
		public static UForceFeedbackComponent D_SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVectorDouble Location = default(FVectorDouble), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__D_SpawnForceFeedbackAttached_Internal((ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x000DA7C0 File Offset: 0x000D89C0
		public static UForceFeedbackComponent D_SpawnForceFeedbackAtLocation(UObject WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVectorDouble Location, FRotator Rotation = default(FRotator), bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__D_SpawnForceFeedbackAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Location, Rotation, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x000DA814 File Offset: 0x000D8A14
		public unsafe static AActor D_SpawnActorFromClassInLevel(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__D_SpawnActorFromClassInLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride));
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x000DA860 File Offset: 0x000D8A60
		public unsafe static bool D_ProjectWorldToScreen(APlayerController Player, in FVectorDouble WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__D_ProjectWorldToScreen_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, WorldPosition, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x000DA88C File Offset: 0x000D8A8C
		public static void D_PlayWorldCameraShakeWithModifier(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVectorDouble Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false, float ShakeModifier = 1f, float TimeDilation = 1f)
		{
			UGameplayStatics.__D_PlayWorldCameraShakeWithModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter, ShakeModifier, TimeDilation);
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x000DA8C0 File Offset: 0x000D8AC0
		public static double D_GetWorldDeltaSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetWorldDeltaSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x000DA8D8 File Offset: 0x000D8AD8
		public unsafe static bool D_GetWorldCameraLocation(UWorld InWorld, ref FVectorDouble OutCameraLocation)
		{
			fixed (FVectorDouble* ptr = &OutCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__D_GetWorldCameraLocation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref OutCameraLocation);
			}
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x000DA900 File Offset: 0x000D8B00
		public static double D_GetTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x000DA917 File Offset: 0x000D8B17
		public static double D_GetGamePlayTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetGamePlayTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x000DA930 File Offset: 0x000D8B30
		public unsafe static AActor D_FinishSpawningActor(AActor Actor, in FTransformDouble SpawnTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__D_FinishSpawningActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x000DA974 File Offset: 0x000D8B74
		public unsafe static bool D_DeprojectScreenToWorld(APlayerController Player, in FVector2D ScreenPosition, ref FVectorDouble WorldPosition, ref FVector WorldDirection)
		{
			fixed (FVectorDouble* ptr = &WorldPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return UGameplayStatics.__D_DeprojectScreenToWorld_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ScreenPosition, ref WorldPosition, ref WorldDirection);
				}
			}
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x000DA9A4 File Offset: 0x000D8BA4
		public unsafe static bool D_Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject, ref FHitResult OutHit, ref TArray<FVectorDouble> OutPathPositions, ref FVectorDouble OutLastTraceDestination, FVectorDouble StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, ECollisionChannel TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency = 15f, float MaxSimTime = 2f, float OverrideGravityZ = 0f)
		{
			fixed (FVectorDouble* ptr = &OutLastTraceDestination)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__D_Blueprint_PredictProjectilePath_ByTraceChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutHit ?? new FHitResult()).NativePtr, (OutPathPositions ?? new TArray<FVectorDouble>()).NativePtr, ref OutLastTraceDestination, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, TraceChannel, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);
			}
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x000DAA20 File Offset: 0x000D8C20
		public unsafe static AActor D_BeginDeferredActorSpawnFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__D_BeginDeferredActorSpawnFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x000DAA80 File Offset: 0x000D8C80
		public static UAudioComponent CreateSound2D(UObject WorldContextObject, USoundBase Sound, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, USoundConcurrency ConcurrencySettings = null, bool bPersistAcrossLevelTransition = false, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAudioComponent>(UGameplayStatics.__CreateSound2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, VolumeMultiplier, PitchMultiplier, StartTime, (ConcurrencySettings != null) ? ConcurrencySettings.NativePtr : IntPtr.Zero, bPersistAcrossLevelTransition, bAutoDestroy));
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x000DAAD1 File Offset: 0x000D8CD1
		public static USaveGame CreateSaveGameObject([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USaveGame> SaveGameClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USaveGame>(UGameplayStatics.__CreateSaveGameObject_Internal(SaveGameClass._NativePtr));
		}

		// Token: 0x0600990E RID: 39182 RVA: 0x000DAAE3 File Offset: 0x000D8CE3
		public static APlayerController CreatePlayer(UObject WorldContextObject, int ControllerId = -1, bool bSpawnPlayerController = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__CreatePlayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControllerId, bSpawnPlayerController));
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x000DAB01 File Offset: 0x000D8D01
		public static void ClearSoundMixModifiers(UObject WorldContextObject)
		{
			UGameplayStatics.__ClearSoundMixModifiers_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x000DAB18 File Offset: 0x000D8D18
		public static void ClearSoundMixClassOverride(UObject WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float FadeOutTime = 1f)
		{
			UGameplayStatics.__ClearSoundMixClassOverride_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InSoundMixModifier != null) ? InSoundMixModifier.NativePtr : IntPtr.Zero, (InSoundClass != null) ? InSoundClass.NativePtr : IntPtr.Zero, FadeOutTime);
		}

		// Token: 0x06009911 RID: 39185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelAsyncLoading();

		// Token: 0x06009912 RID: 39186 RVA: 0x000DAB50 File Offset: 0x000D8D50
		public unsafe static void BreakHitResultDouble(in FHitResultDouble Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref double Distance, ref FVectorDouble Location, ref FVectorDouble ImpactPoint, ref FVectorDouble Normal, ref FVectorDouble ImpactNormal, ref UPhysicalMaterial PhysMat, ref AActor HitActor, ref UPrimitiveComponent HitComponent, ref FName HitBoneName, ref int HitItem, ref int FaceIndex, ref FVectorDouble TraceStart, ref FVectorDouble TraceEnd)
		{
			UPhysicalMaterial uphysicalMaterial = PhysMat;
			IntPtr nativeObjectPtr = (uphysicalMaterial != null) ? uphysicalMaterial.NativePtr : IntPtr.Zero;
			AActor aactor = HitActor;
			IntPtr nativeObjectPtr2 = (aactor != null) ? aactor.NativePtr : IntPtr.Zero;
			UPrimitiveComponent uprimitiveComponent = HitComponent;
			IntPtr nativeObjectPtr3 = (uprimitiveComponent != null) ? uprimitiveComponent.NativePtr : IntPtr.Zero;
			fixed (bool* ptr = &bBlockingHit)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bInitialOverlap)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Time)
					{
						void* ptr6 = (void*)ptr5;
						fixed (double* ptr7 = &Distance)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVectorDouble* ptr9 = &Location)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVectorDouble* ptr11 = &ImpactPoint)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVectorDouble* ptr13 = &Normal)
									{
										void* ptr14 = (void*)ptr13;
										fixed (FVectorDouble* ptr15 = &ImpactNormal)
										{
											void* ptr16 = (void*)ptr15;
											fixed (FName* ptr17 = &HitBoneName)
											{
												void* ptr18 = (void*)ptr17;
												fixed (int* ptr19 = &HitItem)
												{
													void* ptr20 = (void*)ptr19;
													fixed (int* ptr21 = &FaceIndex)
													{
														void* ptr22 = (void*)ptr21;
														fixed (FVectorDouble* ptr23 = &TraceStart)
														{
															void* ptr24 = (void*)ptr23;
															fixed (FVectorDouble* ptr25 = &TraceEnd)
															{
																void* ptr26 = (void*)ptr25;
																UGameplayStatics.__BreakHitResultDouble_Internal((Hit ?? new FHitResultDouble()).NativePtr, ref bBlockingHit, ref bInitialOverlap, ref Time, ref Distance, ref Location, ref ImpactPoint, ref Normal, ref ImpactNormal, ref nativeObjectPtr, ref nativeObjectPtr2, ref nativeObjectPtr3, ref HitBoneName, ref HitItem, ref FaceIndex, ref TraceStart, ref TraceEnd);
																PhysMat = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(nativeObjectPtr);
																HitActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr2);
																HitComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(nativeObjectPtr3);
																ptr = null;
																ptr3 = null;
																ptr5 = null;
																ptr7 = null;
																ptr9 = null;
																ptr11 = null;
																ptr13 = null;
																ptr15 = null;
																ptr17 = null;
																ptr19 = null;
																ptr21 = null;
																ptr23 = null;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x000DAC8C File Offset: 0x000D8E8C
		public unsafe static void BreakHitResult(in FHitResult Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref float Distance, ref FVector Location, ref FVector ImpactPoint, ref FVector Normal, ref FVector ImpactNormal, ref UPhysicalMaterial PhysMat, ref AActor HitActor, ref UPrimitiveComponent HitComponent, ref FName HitBoneName, ref int HitItem, ref int FaceIndex, ref FVector TraceStart, ref FVector TraceEnd)
		{
			UPhysicalMaterial uphysicalMaterial = PhysMat;
			IntPtr nativeObjectPtr = (uphysicalMaterial != null) ? uphysicalMaterial.NativePtr : IntPtr.Zero;
			AActor aactor = HitActor;
			IntPtr nativeObjectPtr2 = (aactor != null) ? aactor.NativePtr : IntPtr.Zero;
			UPrimitiveComponent uprimitiveComponent = HitComponent;
			IntPtr nativeObjectPtr3 = (uprimitiveComponent != null) ? uprimitiveComponent.NativePtr : IntPtr.Zero;
			fixed (bool* ptr = &bBlockingHit)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bInitialOverlap)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Time)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &Distance)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &Location)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &ImpactPoint)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &Normal)
									{
										void* ptr14 = (void*)ptr13;
										fixed (FVector* ptr15 = &ImpactNormal)
										{
											void* ptr16 = (void*)ptr15;
											fixed (FName* ptr17 = &HitBoneName)
											{
												void* ptr18 = (void*)ptr17;
												fixed (int* ptr19 = &HitItem)
												{
													void* ptr20 = (void*)ptr19;
													fixed (int* ptr21 = &FaceIndex)
													{
														void* ptr22 = (void*)ptr21;
														fixed (FVector* ptr23 = &TraceStart)
														{
															void* ptr24 = (void*)ptr23;
															fixed (FVector* ptr25 = &TraceEnd)
															{
																void* ptr26 = (void*)ptr25;
																UGameplayStatics.__BreakHitResult_Internal((Hit ?? new FHitResult()).NativePtr, ref bBlockingHit, ref bInitialOverlap, ref Time, ref Distance, ref Location, ref ImpactPoint, ref Normal, ref ImpactNormal, ref nativeObjectPtr, ref nativeObjectPtr2, ref nativeObjectPtr3, ref HitBoneName, ref HitItem, ref FaceIndex, ref TraceStart, ref TraceEnd);
																PhysMat = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(nativeObjectPtr);
																HitActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr2);
																HitComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(nativeObjectPtr3);
																ptr = null;
																ptr3 = null;
																ptr5 = null;
																ptr7 = null;
																ptr9 = null;
																ptr11 = null;
																ptr13 = null;
																ptr15 = null;
																ptr17 = null;
																ptr19 = null;
																ptr21 = null;
																ptr23 = null;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x000DADC8 File Offset: 0x000D8FC8
		public unsafe static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject, ref FVector TossVelocity, FVector StartLocation, FVector EndLocation, float LaunchSpeed, float OverrideGravityZ, ESuggestProjVelocityTraceOption TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug)
		{
			fixed (FVector* ptr = &TossVelocity)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__BlueprintSuggestProjectileVelocity_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref TossVelocity, StartLocation, EndLocation, LaunchSpeed, OverrideGravityZ, TraceOption, CollisionRadius, bFavorHighArc, bDrawDebug);
			}
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x000DAE04 File Offset: 0x000D9004
		public unsafe static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject, ref FHitResult OutHit, ref TArray<FVector> OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, ECollisionChannel TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency = 15f, float MaxSimTime = 2f, float OverrideGravityZ = 0f)
		{
			fixed (FVector* ptr = &OutLastTraceDestination)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__Blueprint_PredictProjectilePath_ByTraceChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutHit ?? new FHitResult()).NativePtr, (OutPathPositions ?? new TArray<FVector>()).NativePtr, ref OutLastTraceDestination, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, TraceChannel, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);
			}
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x000DAE80 File Offset: 0x000D9080
		public unsafe static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject, ref FHitResult OutHit, ref TArray<FVector> OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency = 15f, float MaxSimTime = 2f, float OverrideGravityZ = 0f)
		{
			fixed (FVector* ptr = &OutLastTraceDestination)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__Blueprint_PredictProjectilePath_ByObjectType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutHit ?? new FHitResult()).NativePtr, (OutPathPositions ?? new TArray<FVector>()).NativePtr, ref OutLastTraceDestination, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);
			}
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x000DAF03 File Offset: 0x000D9103
		public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject, in FPredictProjectilePathParams PredictParams, ref FPredictProjectilePathResult PredictResult)
		{
			return UGameplayStatics.__Blueprint_PredictProjectilePath_Advanced_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PredictParams ?? new FPredictProjectilePathParams()).NativePtr, (PredictResult ?? new FPredictProjectilePathResult()).NativePtr);
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x000DAF3C File Offset: 0x000D913C
		public unsafe static AActor BeginSpawningActorFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransform SpawnTransform, bool bNoCollisionFail = false, AActor Owner = null)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__BeginSpawningActorFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, bNoCollisionFail, (Owner != null) ? Owner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x000DAF9C File Offset: 0x000D919C
		public unsafe static AActor BeginSpawningActorFromBlueprint(UObject WorldContextObject, UBlueprint Blueprint, in FTransform SpawnTransform, bool bNoCollisionFail)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__BeginSpawningActorFromBlueprint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Blueprint != null) ? Blueprint.NativePtr : IntPtr.Zero, ptr, bNoCollisionFail));
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x000DAFF4 File Offset: 0x000D91F4
		public unsafe static AActor BeginDeferredActorSpawnFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__BeginDeferredActorSpawnFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600991B RID: 39195
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AreSubtitlesEnabled();

		// Token: 0x0600991C RID: 39196 RVA: 0x000DB051 File Offset: 0x000D9251
		public static bool AreAnyListenersWithinRange(UObject WorldContextObject, in FVector Location, float MaximumRange)
		{
			return UGameplayStatics.__AreAnyListenersWithinRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, MaximumRange);
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x000DB06C File Offset: 0x000D926C
		public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject, float BaseDamage, float MinimumDamage, in FVector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> IgnoreActors, AActor DamageCauser = null, AController InstigatedByController = null, ECollisionChannel DamagePreventionChannel = ECollisionChannel.ECC_Visibility)
		{
			return UGameplayStatics.__ApplyRadialDamageWithFalloff_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BaseDamage, MinimumDamage, Origin, DamageInnerRadius, DamageOuterRadius, DamageFalloff, DamageTypeClass._NativePtr, (IgnoreActors ?? new TArray<AActor>()).NativePtr, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero, (InstigatedByController != null) ? InstigatedByController.NativePtr : IntPtr.Zero, DamagePreventionChannel);
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x000DB0DC File Offset: 0x000D92DC
		public static bool ApplyRadialDamage(UObject WorldContextObject, float BaseDamage, in FVector Origin, float DamageRadius, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> IgnoreActors, AActor DamageCauser = null, AController InstigatedByController = null, bool bDoFullDamage = false, ECollisionChannel DamagePreventionChannel = ECollisionChannel.ECC_Visibility)
		{
			return UGameplayStatics.__ApplyRadialDamage_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BaseDamage, Origin, DamageRadius, DamageTypeClass._NativePtr, (IgnoreActors ?? new TArray<AActor>()).NativePtr, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero, (InstigatedByController != null) ? InstigatedByController.NativePtr : IntPtr.Zero, bDoFullDamage, DamagePreventionChannel);
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x000DB148 File Offset: 0x000D9348
		public static float ApplyPointDamage(AActor DamagedActor, float BaseDamage, in FVector HitFromDirection, in FHitResult HitInfo, AController EventInstigator, AActor DamageCauser, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass)
		{
			return UGameplayStatics.__ApplyPointDamage_Internal((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero, BaseDamage, HitFromDirection, (HitInfo ?? new FHitResult()).NativePtr, (EventInstigator != null) ? EventInstigator.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero, DamageTypeClass._NativePtr);
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x000DB1A7 File Offset: 0x000D93A7
		public static float ApplyDamage(AActor DamagedActor, float BaseDamage, AController EventInstigator, AActor DamageCauser, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass)
		{
			return UGameplayStatics.__ApplyDamage_Internal((DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero, BaseDamage, (EventInstigator != null) ? EventInstigator.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero, DamageTypeClass._NativePtr);
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x000DB1E8 File Offset: 0x000D93E8
		[NullableContext(1)]
		public unsafe static void AnnounceAccessibleString(string AnnouncementString)
		{
			FString fstring = FString.AllocTemp(AnnouncementString);
			UGameplayStatics.__AnnounceAccessibleString_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x000DB20C File Offset: 0x000D940C
		public static void ActivateReverbEffect(UObject WorldContextObject, UReverbEffect ReverbEffect, FName TagName, float Priority = 0f, float Volume = 0.5f, float FadeTime = 2f)
		{
			UGameplayStatics.__ActivateReverbEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ReverbEffect != null) ? ReverbEffect.NativePtr : IntPtr.Zero, TagName, Priority, Volume, FadeTime);
		}

		// Token: 0x06009923 RID: 39203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePostProcessVolumeDepthFile_Internal(IntPtr WorldContextObject, in FString TagName, float focalDepth, float focalOffset, float maxDepth, float blurRadias, float edgeBias, float farTransition, float nearTransition);

		// Token: 0x06009924 RID: 39204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadStreamLevelRecursively_Internal(IntPtr WorldContextObject, FName LevelName, IntPtr LatentInfo, bool bShouldBlockOnUnload);

		// Token: 0x06009925 RID: 39205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadStreamLevelBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, IntPtr LatentInfo, bool bShouldBlockOnUnload);

		// Token: 0x06009926 RID: 39206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadStreamLevel_Internal(IntPtr WorldContextObject, FName LevelName, IntPtr LatentInfo, bool bShouldBlockOnUnload);

		// Token: 0x06009927 RID: 39207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SuggestProjectileVelocity_CustomArc_Internal(IntPtr WorldContextObject, ref FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ, float ArcParam);

		// Token: 0x06009928 RID: 39208
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnSoundAttached_Internal(IntPtr Sound, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings, IntPtr ConcurrencySettings, bool bAutoDestroy);

		// Token: 0x06009929 RID: 39209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnSoundAtLocation_Internal(IntPtr WorldContextObject, IntPtr Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings, IntPtr ConcurrencySettings, bool bAutoDestroy);

		// Token: 0x0600992A RID: 39210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnSound2D_Internal(IntPtr WorldContextObject, IntPtr Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy);

		// Token: 0x0600992B RID: 39211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnObject_Internal(IntPtr ObjectClass, IntPtr Outer);

		// Token: 0x0600992C RID: 39212
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnForceFeedbackAttached_Internal(IntPtr ForceFeedbackEffect, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x0600992D RID: 39213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnForceFeedbackAtLocation_Internal(IntPtr WorldContextObject, IntPtr ForceFeedbackEffect, FVector Location, FRotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x0600992E RID: 39214
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnEmitterAttached_Internal(IntPtr EmitterTemplate, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, FVector Scale, TEnumAsByte<EAttachLocation> LocationType, bool bAutoDestroy, EPSCPoolMethod PoolingMethod, bool bAutoActivate);

		// Token: 0x0600992F RID: 39215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnEmitterAtLocation_Internal(IntPtr WorldContextObject, IntPtr EmitterTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, EPSCPoolMethod PoolingMethod, bool bAutoActivateSystem);

		// Token: 0x06009930 RID: 39216
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDialogueAttached_Internal(IntPtr Dialogue, IntPtr Context, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x06009931 RID: 39217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDialogueAtLocation_Internal(IntPtr WorldContextObject, IntPtr Dialogue, IntPtr Context, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x06009932 RID: 39218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDialogue2D_Internal(IntPtr WorldContextObject, IntPtr Dialogue, IntPtr Context, float VolumeMultiplier, float PitchMultiplier, float StartTime, bool bAutoDestroy);

		// Token: 0x06009933 RID: 39219
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDecalAttached_Internal(IntPtr DecalMaterial, FVector DecalSize, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, float LifeSpan);

		// Token: 0x06009934 RID: 39220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDecalAtLocation_Internal(IntPtr WorldContextObject, IntPtr DecalMaterial, FVector DecalSize, FVector Location, FRotator Rotation, float LifeSpan);

		// Token: 0x06009935 RID: 39221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromClassInLevel_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride);

		// Token: 0x06009936 RID: 39222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOriginLocation_Internal(IntPtr WorldContextObject, FIntVector NewLocation);

		// Token: 0x06009937 RID: 39223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewportMouseCaptureMode_Internal(IntPtr WorldContextObject, EMouseCaptureMode MouseCaptureMode);

		// Token: 0x06009938 RID: 39224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoundMixClassOverride_Internal(IntPtr WorldContextObject, IntPtr InSoundMixModifier, IntPtr InSoundClass, float Volume, float Pitch, float FadeInTime, bool bApplyToChildren);

		// Token: 0x06009939 RID: 39225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoundClassDistanceScale_Internal(IntPtr WorldContextObject, IntPtr SoundClass, float DistanceAttenuationScale, float TimeSec);

		// Token: 0x0600993A RID: 39226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayerControllerID_Internal(IntPtr Player, int ControllerId);

		// Token: 0x0600993B RID: 39227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxAudioChannelsScaled_Internal(IntPtr WorldContextObject, float MaxChannelCountScale);

		// Token: 0x0600993C RID: 39228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalTimeDilation_Internal(IntPtr WorldContextObject, float TimeDilation);

		// Token: 0x0600993D RID: 39229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPitchModulation_Internal(IntPtr WorldContextObject, float PitchModulation, float TimeSec);

		// Token: 0x0600993E RID: 39230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalListenerFocusParameters_Internal(IntPtr WorldContextObject, float FocusAzimuthScale, float NonFocusAzimuthScale, float FocusDistanceScale, float NonFocusDistanceScale, float FocusVolumeScale, float NonFocusVolumeScale, float FocusPriorityScale, float NonFocusPriorityScale);

		// Token: 0x0600993F RID: 39231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetGamePaused_Internal(IntPtr WorldContextObject, bool bPaused);

		// Token: 0x06009940 RID: 39232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceDisableSplitscreen_Internal(IntPtr WorldContextObject, bool bDisable);

		// Token: 0x06009941 RID: 39233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableWorldRendering_Internal(IntPtr WorldContextObject, bool bEnable);

		// Token: 0x06009942 RID: 39234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseSoundMix_Internal(IntPtr WorldContextObject, IntPtr InSoundMix);

		// Token: 0x06009943 RID: 39235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveGameToSlot_Internal(IntPtr SaveGameObject, in FString SlotName, int UserIndex);

		// Token: 0x06009944 RID: 39236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePlayer_Internal(IntPtr Player, bool bDestroyPawn);

		// Token: 0x06009945 RID: 39237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __RebaseZeroOriginOntoLocal_Internal(IntPtr WorldContextObject, FVector WorldLocation);

		// Token: 0x06009946 RID: 39238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __RebaseLocalOriginOntoZero_Internal(IntPtr WorldContextObject, FVector WorldLocation);

		// Token: 0x06009947 RID: 39239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PushSoundMixModifier_Internal(IntPtr WorldContextObject, IntPtr InSoundMixModifier);

		// Token: 0x06009948 RID: 39240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreen_Internal(IntPtr Player, in FVector WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x06009949 RID: 39241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrimeSound_Internal(IntPtr InSound);

		// Token: 0x0600994A RID: 39242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PopSoundMixModifier_Internal(IntPtr WorldContextObject, IntPtr InSoundMixModifier);

		// Token: 0x0600994B RID: 39243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWorldCameraShakeWithModifier_Internal(IntPtr WorldContextObject, IntPtr Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter, float ShakeModifier, float TimeDilation);

		// Token: 0x0600994C RID: 39244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWorldCameraShake_Internal(IntPtr WorldContextObject, IntPtr Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter);

		// Token: 0x0600994D RID: 39245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlaySoundAtLocation_Internal(IntPtr WorldContextObject, IntPtr Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings, IntPtr ConcurrencySettings, IntPtr OwningActor);

		// Token: 0x0600994E RID: 39246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlaySound2D_Internal(IntPtr WorldContextObject, IntPtr Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr ConcurrencySettings, IntPtr OwningActor, bool bIsUISound);

		// Token: 0x0600994F RID: 39247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayDialogueAtLocation_Internal(IntPtr WorldContextObject, IntPtr Dialogue, IntPtr Context, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr AttenuationSettings);

		// Token: 0x06009950 RID: 39248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayDialogue2D_Internal(IntPtr WorldContextObject, IntPtr Dialogue, IntPtr Context, float VolumeMultiplier, float PitchMultiplier, float StartTime);

		// Token: 0x06009951 RID: 39249
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ParseOption_Internal(in FString Options, in FString Key);

		// Token: 0x06009952 RID: 39250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenLevelBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, bool bAbsolute, in FString Options);

		// Token: 0x06009953 RID: 39251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenLevel_Internal(IntPtr WorldContextObject, FName LevelName, bool bAbsolute, in FString Options);

		// Token: 0x06009954 RID: 39252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeHitResultDouble_Internal(bool bBlockingHit, bool bInitialOverlap, float Time, double Distance, FVectorDouble Location, FVectorDouble ImpactPoint, FVectorDouble Normal, FVectorDouble ImpactNormal, IntPtr PhysMat, IntPtr HitActor, IntPtr HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVectorDouble TraceStart, FVectorDouble TraceEnd);

		// Token: 0x06009955 RID: 39253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeHitResult_Internal(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, FVector Location, FVector ImpactPoint, FVector Normal, FVector ImpactNormal, IntPtr PhysMat, IntPtr HitActor, IntPtr HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVector TraceStart, FVector TraceEnd);

		// Token: 0x06009956 RID: 39254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadStreamLevelRecursively_Internal(IntPtr WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, IntPtr LatentInfo);

		// Token: 0x06009957 RID: 39255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadStreamLevelBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, IntPtr LatentInfo);

		// Token: 0x06009958 RID: 39256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadStreamLevel_Internal(IntPtr WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, IntPtr LatentInfo);

		// Token: 0x06009959 RID: 39257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadGameFromSlot_Internal(in FString SlotName, int UserIndex);

		// Token: 0x0600995A RID: 39258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroFindCollisionUV_Internal(IntPtr Hit, int UVChannel, ref FVector2D UV);

		// Token: 0x0600995B RID: 39259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSplitscreenForceDisabled_Internal(IntPtr WorldContextObject);

		// Token: 0x0600995C RID: 39260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGamePaused_Internal(IntPtr WorldContextObject);

		// Token: 0x0600995D RID: 39261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasOption_Internal(in FString Options, in FString InKey);

		// Token: 0x0600995E RID: 39262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasLaunchOption_Internal(in FString OptionToCheck);

		// Token: 0x0600995F RID: 39263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GrassOverlappingSphereCount_Internal(IntPtr WorldContextObject, IntPtr StaticMesh, FVector CenterPosition, float Radius);

		// Token: 0x06009960 RID: 39264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector __GetWorldOriginLocation_Internal(IntPtr WorldContextObject);

		// Token: 0x06009961 RID: 39265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWorldDeltaSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009962 RID: 39266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldCameraTransform_Internal(IntPtr InWorld, ref FTransform OutCameraTransform);

		// Token: 0x06009963 RID: 39267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldCameraLocation_Internal(IntPtr InWorld, ref FVector OutCameraLocation);

		// Token: 0x06009964 RID: 39268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetViewProjectionMatrix_Internal(IntPtr DesiredView, ref FMatrix ViewMatrix, ref FMatrix ProjectionMatrix, ref FMatrix ViewProjectionMatrix);

		// Token: 0x06009965 RID: 39269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EMouseCaptureMode __GetViewportMouseCaptureMode_Internal(IntPtr WorldContextObject);

		// Token: 0x06009966 RID: 39270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnpausedTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009967 RID: 39271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009968 RID: 39272
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPhysicalSurface> __GetSurfaceType_Internal(IntPtr Hit);

		// Token: 0x06009969 RID: 39273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStreamingLevel_Internal(IntPtr WorldContextObject, FName PackageName);

		// Token: 0x0600996A RID: 39274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRealTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x0600996B RID: 39275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerPawn_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x0600996C RID: 39276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlayerControllerID_Internal(IntPtr Player);

		// Token: 0x0600996D RID: 39277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerControllerFromID_Internal(IntPtr WorldContextObject, int ControllerID);

		// Token: 0x0600996E RID: 39278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerController_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x0600996F RID: 39279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCharacter_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x06009970 RID: 39280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCameraManager_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x06009971 RID: 39281
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformName_Internal();

		// Token: 0x06009972 RID: 39282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectClass_Internal(IntPtr Object);

		// Token: 0x06009973 RID: 39283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxAudioChannelCount_Internal(IntPtr WorldContextObject);

		// Token: 0x06009974 RID: 39284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetKeyValue_Internal(in FString Pair, ref FString Key, ref FString Value);

		// Token: 0x06009975 RID: 39285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntOption_Internal(in FString Options, in FString Key, int DefaultValue);

		// Token: 0x06009976 RID: 39286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalTimeDilation_Internal(IntPtr WorldContextObject);

		// Token: 0x06009977 RID: 39287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameState_Internal(IntPtr WorldContextObject);

		// Token: 0x06009978 RID: 39288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGamePlayTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009979 RID: 39289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameMode_Internal(IntPtr WorldContextObject);

		// Token: 0x0600997A RID: 39290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x0600997B RID: 39291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableWorldRendering_Internal(IntPtr WorldContextObject);

		// Token: 0x0600997C RID: 39292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentReverbEffect_Internal(IntPtr WorldContextObject);

		// Token: 0x0600997D RID: 39293
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLevelName_Internal(IntPtr WorldContextObject, bool bRemovePrefixString);

		// Token: 0x0600997E RID: 39294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetClosestListenerLocation_Internal(IntPtr WorldContextObject, in FVector Location, float MaximumRange, bool bAllowAttenuationOverride, ref FVector ListenerPosition);

		// Token: 0x0600997F RID: 39295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAudioTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009980 RID: 39296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsWithTag_Internal(IntPtr WorldContextObject, FName Tag, IntPtr OutActors);

		// Token: 0x06009981 RID: 39297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsWithInterface_Internal(IntPtr WorldContextObject, IntPtr Interface, IntPtr OutActors);

		// Token: 0x06009982 RID: 39298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsOfClassWithTag_Internal(IntPtr WorldContextObject, IntPtr ActorClass, FName Tag, IntPtr OutActors);

		// Token: 0x06009983 RID: 39299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, IntPtr OutActors);

		// Token: 0x06009984 RID: 39300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClassWithName_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FString ActorName);

		// Token: 0x06009985 RID: 39301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x06009986 RID: 39302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActorCountOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x06009987 RID: 39303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorArrayBounds_Internal(IntPtr Actors, bool bOnlyCollidingComponents, ref FVector Center, ref FVector BoxExtent);

		// Token: 0x06009988 RID: 39304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorArrayAverageLocation_Internal(IntPtr Actors);

		// Token: 0x06009989 RID: 39305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAccurateRealTime_Internal(IntPtr WorldContextObject, ref int Seconds, ref float PartialSeconds);

		// Token: 0x0600998A RID: 39306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x0600998B RID: 39307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FinishSpawningActor_Internal(IntPtr Actor, in FTransform SpawnTransform);

		// Token: 0x0600998C RID: 39308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindCollisionUV_Internal(IntPtr Hit, int UVChannel, ref FVector2D UV);

		// Token: 0x0600998D RID: 39309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExportPngPhotoFromFile_Internal(in FString SourceFileName, in FString Title);

		// Token: 0x0600998E RID: 39310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExportPngPhotoFromData_Internal(IntPtr UserData, in FString Title);

		// Token: 0x0600998F RID: 39311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesSaveGameExist_Internal(in FString SlotName, int UserIndex);

		// Token: 0x06009990 RID: 39312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectScreenToWorld_Internal(IntPtr Player, in FVector2D ScreenPosition, ref FVector WorldPosition, ref FVector WorldDirection);

		// Token: 0x06009991 RID: 39313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteGameInSlot_Internal(in FString SlotName, int UserIndex);

		// Token: 0x06009992 RID: 39314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateReverbEffect_Internal(IntPtr WorldContextObject, FName TagName);

		// Token: 0x06009993 RID: 39315
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnForceFeedbackAttached_Internal(IntPtr ForceFeedbackEffect, IntPtr AttachToComponent, FName AttachPointName, FVectorDouble Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x06009994 RID: 39316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnForceFeedbackAtLocation_Internal(IntPtr WorldContextObject, IntPtr ForceFeedbackEffect, FVectorDouble Location, FRotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x06009995 RID: 39317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActorFromClassInLevel_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride);

		// Token: 0x06009996 RID: 39318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_ProjectWorldToScreen_Internal(IntPtr Player, in FVectorDouble WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x06009997 RID: 39319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_PlayWorldCameraShakeWithModifier_Internal(IntPtr WorldContextObject, IntPtr Shake, FVectorDouble Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter, float ShakeModifier, float TimeDilation);

		// Token: 0x06009998 RID: 39320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetWorldDeltaSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06009999 RID: 39321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetWorldCameraLocation_Internal(IntPtr InWorld, ref FVectorDouble OutCameraLocation);

		// Token: 0x0600999A RID: 39322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x0600999B RID: 39323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetGamePlayTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x0600999C RID: 39324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_FinishSpawningActor_Internal(IntPtr Actor, in FTransformDouble SpawnTransform);

		// Token: 0x0600999D RID: 39325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_DeprojectScreenToWorld_Internal(IntPtr Player, in FVector2D ScreenPosition, ref FVectorDouble WorldPosition, ref FVector WorldDirection);

		// Token: 0x0600999E RID: 39326
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_Blueprint_PredictProjectilePath_ByTraceChannel_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVectorDouble OutLastTraceDestination, FVectorDouble StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x0600999F RID: 39327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_BeginDeferredActorSpawnFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner);

		// Token: 0x060099A0 RID: 39328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateSound2D_Internal(IntPtr WorldContextObject, IntPtr Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, IntPtr ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy);

		// Token: 0x060099A1 RID: 39329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateSaveGameObject_Internal(IntPtr SaveGameClass);

		// Token: 0x060099A2 RID: 39330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePlayer_Internal(IntPtr WorldContextObject, int ControllerId, bool bSpawnPlayerController);

		// Token: 0x060099A3 RID: 39331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSoundMixModifiers_Internal(IntPtr WorldContextObject);

		// Token: 0x060099A4 RID: 39332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSoundMixClassOverride_Internal(IntPtr WorldContextObject, IntPtr InSoundMixModifier, IntPtr InSoundClass, float FadeOutTime);

		// Token: 0x060099A5 RID: 39333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakHitResultDouble_Internal(IntPtr Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref double Distance, ref FVectorDouble Location, ref FVectorDouble ImpactPoint, ref FVectorDouble Normal, ref FVectorDouble ImpactNormal, ref IntPtr PhysMat, ref IntPtr HitActor, ref IntPtr HitComponent, ref FName HitBoneName, ref int HitItem, ref int FaceIndex, ref FVectorDouble TraceStart, ref FVectorDouble TraceEnd);

		// Token: 0x060099A6 RID: 39334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakHitResult_Internal(IntPtr Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref float Distance, ref FVector Location, ref FVector ImpactPoint, ref FVector Normal, ref FVector ImpactNormal, ref IntPtr PhysMat, ref IntPtr HitActor, ref IntPtr HitComponent, ref FName HitBoneName, ref int HitItem, ref int FaceIndex, ref FVector TraceStart, ref FVector TraceEnd);

		// Token: 0x060099A7 RID: 39335
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BlueprintSuggestProjectileVelocity_Internal(IntPtr WorldContextObject, ref FVector TossVelocity, FVector StartLocation, FVector EndLocation, float LaunchSpeed, float OverrideGravityZ, TEnumAsByte<ESuggestProjVelocityTraceOption> TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug);

		// Token: 0x060099A8 RID: 39336
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_ByTraceChannel_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x060099A9 RID: 39337
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_ByObjectType_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x060099AA RID: 39338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_Advanced_Internal(IntPtr WorldContextObject, IntPtr PredictParams, IntPtr PredictResult);

		// Token: 0x060099AB RID: 39339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginSpawningActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, bool bNoCollisionFail, IntPtr Owner);

		// Token: 0x060099AC RID: 39340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginSpawningActorFromBlueprint_Internal(IntPtr WorldContextObject, IntPtr Blueprint, in FTransform SpawnTransform, bool bNoCollisionFail);

		// Token: 0x060099AD RID: 39341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginDeferredActorSpawnFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner);

		// Token: 0x060099AE RID: 39342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AreAnyListenersWithinRange_Internal(IntPtr WorldContextObject, in FVector Location, float MaximumRange);

		// Token: 0x060099AF RID: 39343
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ApplyRadialDamageWithFalloff_Internal(IntPtr WorldContextObject, float BaseDamage, float MinimumDamage, in FVector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, IntPtr DamageTypeClass, IntPtr IgnoreActors, IntPtr DamageCauser, IntPtr InstigatedByController, TEnumAsByte<ECollisionChannel> DamagePreventionChannel);

		// Token: 0x060099B0 RID: 39344
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ApplyRadialDamage_Internal(IntPtr WorldContextObject, float BaseDamage, in FVector Origin, float DamageRadius, IntPtr DamageTypeClass, IntPtr IgnoreActors, IntPtr DamageCauser, IntPtr InstigatedByController, bool bDoFullDamage, TEnumAsByte<ECollisionChannel> DamagePreventionChannel);

		// Token: 0x060099B1 RID: 39345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __ApplyPointDamage_Internal(IntPtr DamagedActor, float BaseDamage, in FVector HitFromDirection, IntPtr HitInfo, IntPtr EventInstigator, IntPtr DamageCauser, IntPtr DamageTypeClass);

		// Token: 0x060099B2 RID: 39346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __ApplyDamage_Internal(IntPtr DamagedActor, float BaseDamage, IntPtr EventInstigator, IntPtr DamageCauser, IntPtr DamageTypeClass);

		// Token: 0x060099B3 RID: 39347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AnnounceAccessibleString_Internal(in FString AnnouncementString);

		// Token: 0x060099B4 RID: 39348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateReverbEffect_Internal(IntPtr WorldContextObject, IntPtr ReverbEffect, FName TagName, float Priority, float Volume, float FadeTime);

		// Token: 0x060099B5 RID: 39349 RVA: 0x000DB239 File Offset: 0x000D9439
		static UGameplayStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameplayStatics");
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x000DB247 File Offset: 0x000D9447
		protected UGameplayStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005535 RID: 21813
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameplayStatics";

		// Token: 0x04005536 RID: 21814
		private static IntPtr _ClassPtr;

		// Token: 0x04005537 RID: 21815
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
