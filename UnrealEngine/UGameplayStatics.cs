using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000216 RID: 534
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameplayStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGameplayStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600228C RID: 8844 RVA: 0x0003276A File Offset: 0x0003096A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayStatics._ClassPtr;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00032778 File Offset: 0x00030978
		public UGameplayStatics() : this(BuiltinUtils.AllocNativeUObject(UGameplayStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000327A0 File Offset: 0x000309A0
		[NullableContext(1)]
		public UGameplayStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000327D4 File Offset: 0x000309D4
		[NullableContext(1)]
		public unsafe static void UpdatePostProcessVolumeDepthFile([Nullable(2)] UObject WorldContextObject, string TagName, float focalDepth = 212.8f, float focalOffset = 57.8f, float maxDepth = 65000f, float blurRadias = 2f, float edgeBias = 0f, float farTransition = 0f, float nearTransition = 0f)
		{
			FString fstring = FString.AllocTemp(TagName);
			UGameplayStatics.__UpdatePostProcessVolumeDepthFile_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, focalDepth, focalOffset, maxDepth, blurRadias, edgeBias, farTransition, nearTransition);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00032814 File Offset: 0x00030A14
		public unsafe static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject, ref FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ = 0f, float ArcParam = 0.5f)
		{
			fixed (FVector* ptr = &OutLaunchVelocity)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__SuggestProjectileVelocity_CustomArc_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref OutLaunchVelocity, StartPos, EndPos, OverrideGravityZ, ArcParam);
			}
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00032842 File Offset: 0x00030A42
		public static UObject SpawnObject(UClassStackOnlyPtr ObjectClass, UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UGameplayStatics.__SpawnObject_Internal(ObjectClass._NativePtr, (Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00032864 File Offset: 0x00030A64
		public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__SpawnForceFeedbackAttached_Internal((ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000328C4 File Offset: 0x00030AC4
		public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVector Location, FRotator Rotation = default(FRotator), bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__SpawnForceFeedbackAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Location, Rotation, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00032917 File Offset: 0x00030B17
		public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial, FVector DecalSize, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVector Location = default(FVector), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, float LifeSpan = 0f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDecalComponent>(UGameplayStatics.__SpawnDecalAttached_Internal((DecalMaterial != null) ? DecalMaterial.NativePtr : IntPtr.Zero, DecalSize, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, LifeSpan));
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00032954 File Offset: 0x00030B54
		public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject, UMaterialInterface DecalMaterial, FVector DecalSize, FVector Location, FRotator? Rotation = null, float LifeSpan = 0f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDecalComponent>(UGameplayStatics.__SpawnDecalAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (DecalMaterial != null) ? DecalMaterial.NativePtr : IntPtr.Zero, DecalSize, Location, Rotation ?? new FRotator(90f, 0f, 0f), LifeSpan));
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000329B8 File Offset: 0x00030BB8
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

		// Token: 0x06002297 RID: 8855 RVA: 0x00032A03 File Offset: 0x00030C03
		public static void SetWorldOriginLocation(UObject WorldContextObject, FIntVector NewLocation)
		{
			UGameplayStatics.__SetWorldOriginLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, NewLocation);
		}

		// Token: 0x06002298 RID: 8856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSubtitlesEnabled(bool bEnabled);

		// Token: 0x06002299 RID: 8857 RVA: 0x00032A1B File Offset: 0x00030C1B
		public static void SetPlayerControllerID(APlayerController Player, int ControllerId)
		{
			UGameplayStatics.__SetPlayerControllerID_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ControllerId);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00032A33 File Offset: 0x00030C33
		public static void SetMaxAudioChannelsScaled(UObject WorldContextObject, float MaxChannelCountScale)
		{
			UGameplayStatics.__SetMaxAudioChannelsScaled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, MaxChannelCountScale);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00032A4B File Offset: 0x00030C4B
		public static void SetGlobalTimeDilation(UObject WorldContextObject, float TimeDilation)
		{
			UGameplayStatics.__SetGlobalTimeDilation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TimeDilation);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00032A63 File Offset: 0x00030C63
		public static void SetGlobalPitchModulation(UObject WorldContextObject, float PitchModulation, float TimeSec)
		{
			UGameplayStatics.__SetGlobalPitchModulation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PitchModulation, TimeSec);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00032A7C File Offset: 0x00030C7C
		public static void SetGlobalListenerFocusParameters(UObject WorldContextObject, float FocusAzimuthScale = 1f, float NonFocusAzimuthScale = 1f, float FocusDistanceScale = 1f, float NonFocusDistanceScale = 1f, float FocusVolumeScale = 1f, float NonFocusVolumeScale = 1f, float FocusPriorityScale = 1f, float NonFocusPriorityScale = 1f)
		{
			UGameplayStatics.__SetGlobalListenerFocusParameters_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, FocusAzimuthScale, NonFocusAzimuthScale, FocusDistanceScale, NonFocusDistanceScale, FocusVolumeScale, NonFocusVolumeScale, FocusPriorityScale, NonFocusPriorityScale);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00032AAB File Offset: 0x00030CAB
		public static bool SetGamePaused(UObject WorldContextObject, bool bPaused)
		{
			return UGameplayStatics.__SetGamePaused_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bPaused);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00032AC3 File Offset: 0x00030CC3
		public static void SetForceDisableSplitscreen(UObject WorldContextObject, bool bDisable)
		{
			UGameplayStatics.__SetForceDisableSplitscreen_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bDisable);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00032ADB File Offset: 0x00030CDB
		public static void SetEnableWorldRendering(UObject WorldContextObject, bool bEnable)
		{
			UGameplayStatics.__SetEnableWorldRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bEnable);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00032AF3 File Offset: 0x00030CF3
		public static void RemovePlayer(APlayerController Player, bool bDestroyPawn)
		{
			UGameplayStatics.__RemovePlayer_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, bDestroyPawn);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00032B0B File Offset: 0x00030D0B
		public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject, FVector WorldLocation)
		{
			return UGameplayStatics.__RebaseZeroOriginOntoLocal_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldLocation);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00032B23 File Offset: 0x00030D23
		public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject, FVector WorldLocation)
		{
			return UGameplayStatics.__RebaseLocalOriginOntoZero_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldLocation);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00032B3C File Offset: 0x00030D3C
		public unsafe static bool ProjectWorldToScreen(APlayerController Player, in FVector WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__ProjectWorldToScreen_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, WorldPosition, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00032B68 File Offset: 0x00030D68
		public static void PlayWorldCameraShakeWithModifier(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false, float ShakeModifier = 1f, float TimeDilation = 1f)
		{
			UGameplayStatics.__PlayWorldCameraShakeWithModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter, ShakeModifier, TimeDilation);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00032B9C File Offset: 0x00030D9C
		public static void PlayWorldCameraShake(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false)
		{
			UGameplayStatics.__PlayWorldCameraShake_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00032BC4 File Offset: 0x00030DC4
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

		// Token: 0x060022A8 RID: 8872 RVA: 0x00032C00 File Offset: 0x00030E00
		[NullableContext(1)]
		public unsafe static void OpenLevelBySoftObjectPtr([Nullable(2)] UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, bool bAbsolute = true, string Options = "")
		{
			FString fstring = FString.AllocTemp(Options);
			UGameplayStatics.__OpenLevelBySoftObjectPtr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Level ?? new TSoftObjectPtr<UWorld>()).NativePtr, bAbsolute, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00032C44 File Offset: 0x00030E44
		[NullableContext(1)]
		public unsafe static void OpenLevel([Nullable(2)] UObject WorldContextObject, FName LevelName, bool bAbsolute = true, string Options = "")
		{
			FString fstring = FString.AllocTemp(Options);
			UGameplayStatics.__OpenLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelName, bAbsolute, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00032C7C File Offset: 0x00030E7C
		[return: Nullable(1)]
		public static FHitResult MakeHitResult(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, FVector Location, FVector ImpactPoint, FVector Normal, FVector ImpactNormal, UPhysicalMaterial PhysMat, AActor HitActor, UPrimitiveComponent HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVector TraceStart, FVector TraceEnd)
		{
			return new FHitResult(UGameplayStatics.__MakeHitResult_Internal(bBlockingHit, bInitialOverlap, Time, Distance, Location, ImpactPoint, Normal, ImpactNormal, (PhysMat != null) ? PhysMat.NativePtr : IntPtr.Zero, (HitActor != null) ? HitActor.NativePtr : IntPtr.Zero, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, HitBoneName, HitItem, FaceIndex, TraceStart, TraceEnd), null);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00032CE0 File Offset: 0x00030EE0
		public unsafe static bool KuroFindCollisionUV(in FHitResult Hit, int UVChannel, ref FVector2D UV)
		{
			fixed (FVector2D* ptr = &UV)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__KuroFindCollisionUV_Internal((Hit ?? new FHitResult()).NativePtr, UVChannel, ref UV);
			}
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00032D09 File Offset: 0x00030F09
		public static bool IsSplitscreenForceDisabled(UObject WorldContextObject)
		{
			return UGameplayStatics.__IsSplitscreenForceDisabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00032D20 File Offset: 0x00030F20
		public static bool IsGamePaused(UObject WorldContextObject)
		{
			return UGameplayStatics.__IsGamePaused_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00032D38 File Offset: 0x00030F38
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

		// Token: 0x060022AF RID: 8879 RVA: 0x00032D70 File Offset: 0x00030F70
		[NullableContext(1)]
		public unsafe static bool HasLaunchOption(string OptionToCheck)
		{
			FString fstring = FString.AllocTemp(OptionToCheck);
			bool result = UGameplayStatics.__HasLaunchOption_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00032D94 File Offset: 0x00030F94
		public static int GrassOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
		{
			return UGameplayStatics.__GrassOverlappingSphereCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, CenterPosition, Radius);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00032DBD File Offset: 0x00030FBD
		public static FIntVector GetWorldOriginLocation(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetWorldOriginLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00032DD4 File Offset: 0x00030FD4
		public static float GetWorldDeltaSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetWorldDeltaSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00032DEC File Offset: 0x00030FEC
		public unsafe static bool GetWorldCameraTransform(UWorld InWorld, ref FTransform OutCameraTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutCameraTransform;
			bool result = UGameplayStatics.__GetWorldCameraTransform_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref ptr);
			OutCameraTransform = ptr;
			return result;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00032E38 File Offset: 0x00031038
		public unsafe static bool GetWorldCameraLocation(UWorld InWorld, ref FVector OutCameraLocation)
		{
			fixed (FVector* ptr = &OutCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__GetWorldCameraLocation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref OutCameraLocation);
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00032E60 File Offset: 0x00031060
		public static float GetUnpausedTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetUnpausedTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00032E77 File Offset: 0x00031077
		public static float GetTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00032E8E File Offset: 0x0003108E
		[NullableContext(0)]
		public static TEnumAsByte<EPhysicalSurface> GetSurfaceType([Nullable(2)] in FHitResult Hit)
		{
			return UGameplayStatics.__GetSurfaceType_Internal((Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00032EA5 File Offset: 0x000310A5
		public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject, FName PackageName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreaming>(UGameplayStatics.__GetStreamingLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PackageName));
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00032EC2 File Offset: 0x000310C2
		public static float GetRealTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetRealTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00032ED9 File Offset: 0x000310D9
		public static APawn GetPlayerPawn(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UGameplayStatics.__GetPlayerPawn_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00032EF6 File Offset: 0x000310F6
		public static int GetPlayerControllerID(APlayerController Player)
		{
			return UGameplayStatics.__GetPlayerControllerID_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00032F0D File Offset: 0x0003110D
		public static APlayerController GetPlayerControllerFromID(UObject WorldContextObject, int ControllerID)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__GetPlayerControllerFromID_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControllerID));
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00032F2A File Offset: 0x0003112A
		public static APlayerController GetPlayerController(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__GetPlayerController_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00032F47 File Offset: 0x00031147
		public static ACharacter GetPlayerCharacter(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(UGameplayStatics.__GetPlayerCharacter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00032F64 File Offset: 0x00031164
		public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject, int PlayerIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(UGameplayStatics.__GetPlayerCameraManager_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex));
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00032F81 File Offset: 0x00031181
		[NullableContext(1)]
		public static string GetPlatformName()
		{
			return FString.ToStringAndDeleteNativePtr(UGameplayStatics.__GetPlatformName_Internal());
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00032F8D File Offset: 0x0003118D
		public static UClassStackOnlyPtr GetObjectClass(UObject Object)
		{
			return UGameplayStatics.__GetObjectClass_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00032FA9 File Offset: 0x000311A9
		public static int GetMaxAudioChannelCount(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetMaxAudioChannelCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00032FC0 File Offset: 0x000311C0
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

		// Token: 0x060022C4 RID: 8900 RVA: 0x0003301C File Offset: 0x0003121C
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

		// Token: 0x060022C5 RID: 8901 RVA: 0x00033053 File Offset: 0x00031253
		public static float GetGlobalTimeDilation(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetGlobalTimeDilation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0003306A File Offset: 0x0003126A
		public static float GetGamePlayTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetGamePlayTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00033081 File Offset: 0x00031281
		public static AGameModeBase GetGameMode(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AGameModeBase>(UGameplayStatics.__GetGameMode_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0003309D File Offset: 0x0003129D
		public static UGameInstance GetGameInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstance>(UGameplayStatics.__GetGameInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000330B9 File Offset: 0x000312B9
		public static bool GetEnableWorldRendering(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetEnableWorldRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000330D0 File Offset: 0x000312D0
		[NullableContext(1)]
		public static string GetCurrentLevelName([Nullable(2)] UObject WorldContextObject, bool bRemovePrefixString = true)
		{
			return FString.ToStringAndDeleteNativePtr(UGameplayStatics.__GetCurrentLevelName_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bRemovePrefixString));
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000330F0 File Offset: 0x000312F0
		public unsafe static bool GetClosestListenerLocation(UObject WorldContextObject, in FVector Location, float MaximumRange, bool bAllowAttenuationOverride, ref FVector ListenerPosition)
		{
			fixed (FVector* ptr = &ListenerPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__GetClosestListenerLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, MaximumRange, bAllowAttenuationOverride, ref ListenerPosition);
			}
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0003311D File Offset: 0x0003131D
		public static float GetAudioTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__GetAudioTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00033134 File Offset: 0x00031334
		public static void GetAllActorsWithTag(UObject WorldContextObject, FName Tag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsWithTag_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Tag, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0003315C File Offset: 0x0003135C
		public static void GetAllActorsWithInterface(UObject WorldContextObject, UClassStackOnlyPtr Interface, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UGameplayStatics.__GetAllActorsWithInterface_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Interface._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00033189 File Offset: 0x00031389
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

		// Token: 0x060022D0 RID: 8912 RVA: 0x000331B7 File Offset: 0x000313B7
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

		// Token: 0x060022D1 RID: 8913 RVA: 0x000331E4 File Offset: 0x000313E4
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

		// Token: 0x060022D2 RID: 8914 RVA: 0x00033223 File Offset: 0x00031423
		public static AActor GetActorOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__GetActorOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr));
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00033245 File Offset: 0x00031445
		public static int GetActorCountOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return UGameplayStatics.__GetActorCountOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00033264 File Offset: 0x00031464
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

		// Token: 0x060022D5 RID: 8917 RVA: 0x00033299 File Offset: 0x00031499
		public static FVector GetActorArrayAverageLocation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors)
		{
			return UGameplayStatics.__GetActorArrayAverageLocation_Internal((Actors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000332B0 File Offset: 0x000314B0
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

		// Token: 0x060022D7 RID: 8919 RVA: 0x000332E4 File Offset: 0x000314E4
		public static void FlushLevelStreaming(UObject WorldContextObject)
		{
			UGameplayStatics.__FlushLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000332FC File Offset: 0x000314FC
		public unsafe static AActor FinishSpawningActor(AActor Actor, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__FinishSpawningActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00033340 File Offset: 0x00031540
		public unsafe static bool FindCollisionUV(in FHitResult Hit, int UVChannel, ref FVector2D UV)
		{
			fixed (FVector2D* ptr = &UV)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__FindCollisionUV_Internal((Hit ?? new FHitResult()).NativePtr, UVChannel, ref UV);
			}
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0003336C File Offset: 0x0003156C
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

		// Token: 0x060022DB RID: 8923 RVA: 0x000333A4 File Offset: 0x000315A4
		[NullableContext(1)]
		public unsafe static bool ExportPngPhotoFromData([Nullable(2)] in TArray<byte> UserData, string Title)
		{
			FString fstring = FString.AllocTemp(Title);
			bool result = UGameplayStatics.__ExportPngPhotoFromData_Internal((UserData ?? new TArray<byte>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060022DC RID: 8924
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableLiveStreaming(bool Enable);

		// Token: 0x060022DD RID: 8925 RVA: 0x000333D8 File Offset: 0x000315D8
		[NullableContext(1)]
		public unsafe static bool DoesSaveGameExist(string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = UGameplayStatics.__DoesSaveGameExist_Internal(fstring, UserIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00033400 File Offset: 0x00031600
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

		// Token: 0x060022DF RID: 8927 RVA: 0x00033430 File Offset: 0x00031630
		[NullableContext(1)]
		public unsafe static bool DeleteGameInSlot(string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			bool result = UGameplayStatics.__DeleteGameInSlot_Internal(fstring, UserIndex);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00033455 File Offset: 0x00031655
		public static void DeactivateReverbEffect(UObject WorldContextObject, FName TagName)
		{
			UGameplayStatics.__DeactivateReverbEffect_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TagName);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00033470 File Offset: 0x00031670
		public static UForceFeedbackComponent D_SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect, USceneComponent AttachToComponent, FName AttachPointName = default(FName), FVectorDouble Location = default(FVectorDouble), FRotator Rotation = default(FRotator), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset, bool bStopWhenAttachedToDestroyed = false, bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__D_SpawnForceFeedbackAttached_Internal((ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttachPointName, Location, Rotation, LocationType, bStopWhenAttachedToDestroyed, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000334D0 File Offset: 0x000316D0
		public static UForceFeedbackComponent D_SpawnForceFeedbackAtLocation(UObject WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVectorDouble Location, FRotator Rotation = default(FRotator), bool bLooping = false, float IntensityMultiplier = 1f, float StartTime = 0f, UForceFeedbackAttenuation AttenuationSettings = null, bool bAutoDestroy = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(UGameplayStatics.__D_SpawnForceFeedbackAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Location, Rotation, bLooping, IntensityMultiplier, StartTime, (AttenuationSettings != null) ? AttenuationSettings.NativePtr : IntPtr.Zero, bAutoDestroy));
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00033524 File Offset: 0x00031724
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

		// Token: 0x060022E4 RID: 8932 RVA: 0x00033570 File Offset: 0x00031770
		public unsafe static bool D_ProjectWorldToScreen(APlayerController Player, in FVectorDouble WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__D_ProjectWorldToScreen_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, WorldPosition, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0003359C File Offset: 0x0003179C
		public static void D_PlayWorldCameraShakeWithModifier(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, FVectorDouble Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false, float ShakeModifier = 1f, float TimeDilation = 1f)
		{
			UGameplayStatics.__D_PlayWorldCameraShakeWithModifier_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Shake._NativePtr, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter, ShakeModifier, TimeDilation);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000335D0 File Offset: 0x000317D0
		public static double D_GetWorldDeltaSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetWorldDeltaSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000335E8 File Offset: 0x000317E8
		public unsafe static bool D_GetWorldCameraLocation(UWorld InWorld, ref FVectorDouble OutCameraLocation)
		{
			fixed (FVectorDouble* ptr = &OutCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				return UGameplayStatics.__D_GetWorldCameraLocation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ref OutCameraLocation);
			}
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00033610 File Offset: 0x00031810
		public static double D_GetTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00033627 File Offset: 0x00031827
		public static double D_GetGamePlayTimeSeconds(UObject WorldContextObject)
		{
			return UGameplayStatics.__D_GetGamePlayTimeSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00033640 File Offset: 0x00031840
		public unsafe static AActor D_FinishSpawningActor(AActor Actor, in FTransformDouble SpawnTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__D_FinishSpawningActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00033684 File Offset: 0x00031884
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

		// Token: 0x060022EC RID: 8940 RVA: 0x000336B4 File Offset: 0x000318B4
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

		// Token: 0x060022ED RID: 8941 RVA: 0x00033730 File Offset: 0x00031930
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

		// Token: 0x060022EE RID: 8942 RVA: 0x0003378D File Offset: 0x0003198D
		public static APlayerController CreatePlayer(UObject WorldContextObject, int ControllerId = -1, bool bSpawnPlayerController = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UGameplayStatics.__CreatePlayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControllerId, bSpawnPlayerController));
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000337AB File Offset: 0x000319AB
		public static void ClearSoundMixModifiers(UObject WorldContextObject)
		{
			UGameplayStatics.__ClearSoundMixModifiers_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060022F0 RID: 8944
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelAsyncLoading();

		// Token: 0x060022F1 RID: 8945 RVA: 0x000337C4 File Offset: 0x000319C4
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

		// Token: 0x060022F2 RID: 8946 RVA: 0x00033900 File Offset: 0x00031B00
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

		// Token: 0x060022F3 RID: 8947 RVA: 0x0003397C File Offset: 0x00031B7C
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

		// Token: 0x060022F4 RID: 8948 RVA: 0x000339FF File Offset: 0x00031BFF
		public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject, in FPredictProjectilePathParams PredictParams, ref FPredictProjectilePathResult PredictResult)
		{
			return UGameplayStatics.__Blueprint_PredictProjectilePath_Advanced_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PredictParams ?? new FPredictProjectilePathParams()).NativePtr, (PredictResult ?? new FPredictProjectilePathResult()).NativePtr);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00033A38 File Offset: 0x00031C38
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

		// Token: 0x060022F6 RID: 8950 RVA: 0x00033A98 File Offset: 0x00031C98
		public unsafe static AActor BeginSpawningActorFromBlueprint(UObject WorldContextObject, UBlueprint Blueprint, in FTransform SpawnTransform, bool bNoCollisionFail)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGameplayStatics.__BeginSpawningActorFromBlueprint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Blueprint != null) ? Blueprint.NativePtr : IntPtr.Zero, ptr, bNoCollisionFail));
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00033AF0 File Offset: 0x00031CF0
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

		// Token: 0x060022F8 RID: 8952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AreSubtitlesEnabled();

		// Token: 0x060022F9 RID: 8953 RVA: 0x00033B4D File Offset: 0x00031D4D
		public static bool AreAnyListenersWithinRange(UObject WorldContextObject, in FVector Location, float MaximumRange)
		{
			return UGameplayStatics.__AreAnyListenersWithinRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, MaximumRange);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00033B68 File Offset: 0x00031D68
		[NullableContext(1)]
		public unsafe static void AnnounceAccessibleString(string AnnouncementString)
		{
			FString fstring = FString.AllocTemp(AnnouncementString);
			UGameplayStatics.__AnnounceAccessibleString_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060022FB RID: 8955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePostProcessVolumeDepthFile_Internal(IntPtr WorldContextObject, in FString TagName, float focalDepth, float focalOffset, float maxDepth, float blurRadias, float edgeBias, float farTransition, float nearTransition);

		// Token: 0x060022FC RID: 8956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SuggestProjectileVelocity_CustomArc_Internal(IntPtr WorldContextObject, ref FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ, float ArcParam);

		// Token: 0x060022FD RID: 8957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnObject_Internal(IntPtr ObjectClass, IntPtr Outer);

		// Token: 0x060022FE RID: 8958
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnForceFeedbackAttached_Internal(IntPtr ForceFeedbackEffect, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x060022FF RID: 8959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnForceFeedbackAtLocation_Internal(IntPtr WorldContextObject, IntPtr ForceFeedbackEffect, FVector Location, FRotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x06002300 RID: 8960
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDecalAttached_Internal(IntPtr DecalMaterial, FVector DecalSize, IntPtr AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, float LifeSpan);

		// Token: 0x06002301 RID: 8961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDecalAtLocation_Internal(IntPtr WorldContextObject, IntPtr DecalMaterial, FVector DecalSize, FVector Location, FRotator Rotation, float LifeSpan);

		// Token: 0x06002302 RID: 8962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromClassInLevel_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride);

		// Token: 0x06002303 RID: 8963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOriginLocation_Internal(IntPtr WorldContextObject, FIntVector NewLocation);

		// Token: 0x06002304 RID: 8964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayerControllerID_Internal(IntPtr Player, int ControllerId);

		// Token: 0x06002305 RID: 8965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxAudioChannelsScaled_Internal(IntPtr WorldContextObject, float MaxChannelCountScale);

		// Token: 0x06002306 RID: 8966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalTimeDilation_Internal(IntPtr WorldContextObject, float TimeDilation);

		// Token: 0x06002307 RID: 8967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPitchModulation_Internal(IntPtr WorldContextObject, float PitchModulation, float TimeSec);

		// Token: 0x06002308 RID: 8968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalListenerFocusParameters_Internal(IntPtr WorldContextObject, float FocusAzimuthScale, float NonFocusAzimuthScale, float FocusDistanceScale, float NonFocusDistanceScale, float FocusVolumeScale, float NonFocusVolumeScale, float FocusPriorityScale, float NonFocusPriorityScale);

		// Token: 0x06002309 RID: 8969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetGamePaused_Internal(IntPtr WorldContextObject, bool bPaused);

		// Token: 0x0600230A RID: 8970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceDisableSplitscreen_Internal(IntPtr WorldContextObject, bool bDisable);

		// Token: 0x0600230B RID: 8971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableWorldRendering_Internal(IntPtr WorldContextObject, bool bEnable);

		// Token: 0x0600230C RID: 8972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePlayer_Internal(IntPtr Player, bool bDestroyPawn);

		// Token: 0x0600230D RID: 8973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __RebaseZeroOriginOntoLocal_Internal(IntPtr WorldContextObject, FVector WorldLocation);

		// Token: 0x0600230E RID: 8974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __RebaseLocalOriginOntoZero_Internal(IntPtr WorldContextObject, FVector WorldLocation);

		// Token: 0x0600230F RID: 8975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreen_Internal(IntPtr Player, in FVector WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x06002310 RID: 8976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWorldCameraShakeWithModifier_Internal(IntPtr WorldContextObject, IntPtr Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter, float ShakeModifier, float TimeDilation);

		// Token: 0x06002311 RID: 8977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWorldCameraShake_Internal(IntPtr WorldContextObject, IntPtr Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter);

		// Token: 0x06002312 RID: 8978
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ParseOption_Internal(in FString Options, in FString Key);

		// Token: 0x06002313 RID: 8979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenLevelBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, bool bAbsolute, in FString Options);

		// Token: 0x06002314 RID: 8980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenLevel_Internal(IntPtr WorldContextObject, FName LevelName, bool bAbsolute, in FString Options);

		// Token: 0x06002315 RID: 8981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeHitResult_Internal(bool bBlockingHit, bool bInitialOverlap, float Time, float Distance, FVector Location, FVector ImpactPoint, FVector Normal, FVector ImpactNormal, IntPtr PhysMat, IntPtr HitActor, IntPtr HitComponent, FName HitBoneName, int HitItem, int FaceIndex, FVector TraceStart, FVector TraceEnd);

		// Token: 0x06002316 RID: 8982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroFindCollisionUV_Internal(IntPtr Hit, int UVChannel, ref FVector2D UV);

		// Token: 0x06002317 RID: 8983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSplitscreenForceDisabled_Internal(IntPtr WorldContextObject);

		// Token: 0x06002318 RID: 8984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGamePaused_Internal(IntPtr WorldContextObject);

		// Token: 0x06002319 RID: 8985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasOption_Internal(in FString Options, in FString InKey);

		// Token: 0x0600231A RID: 8986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasLaunchOption_Internal(in FString OptionToCheck);

		// Token: 0x0600231B RID: 8987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GrassOverlappingSphereCount_Internal(IntPtr WorldContextObject, IntPtr StaticMesh, FVector CenterPosition, float Radius);

		// Token: 0x0600231C RID: 8988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector __GetWorldOriginLocation_Internal(IntPtr WorldContextObject);

		// Token: 0x0600231D RID: 8989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWorldDeltaSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x0600231E RID: 8990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldCameraTransform_Internal(IntPtr InWorld, ref FTransform OutCameraTransform);

		// Token: 0x0600231F RID: 8991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldCameraLocation_Internal(IntPtr InWorld, ref FVector OutCameraLocation);

		// Token: 0x06002320 RID: 8992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnpausedTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002321 RID: 8993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002322 RID: 8994
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPhysicalSurface> __GetSurfaceType_Internal(IntPtr Hit);

		// Token: 0x06002323 RID: 8995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStreamingLevel_Internal(IntPtr WorldContextObject, FName PackageName);

		// Token: 0x06002324 RID: 8996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRealTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002325 RID: 8997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerPawn_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x06002326 RID: 8998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlayerControllerID_Internal(IntPtr Player);

		// Token: 0x06002327 RID: 8999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerControllerFromID_Internal(IntPtr WorldContextObject, int ControllerID);

		// Token: 0x06002328 RID: 9000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerController_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x06002329 RID: 9001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCharacter_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x0600232A RID: 9002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCameraManager_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x0600232B RID: 9003
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformName_Internal();

		// Token: 0x0600232C RID: 9004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectClass_Internal(IntPtr Object);

		// Token: 0x0600232D RID: 9005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxAudioChannelCount_Internal(IntPtr WorldContextObject);

		// Token: 0x0600232E RID: 9006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetKeyValue_Internal(in FString Pair, ref FString Key, ref FString Value);

		// Token: 0x0600232F RID: 9007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntOption_Internal(in FString Options, in FString Key, int DefaultValue);

		// Token: 0x06002330 RID: 9008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalTimeDilation_Internal(IntPtr WorldContextObject);

		// Token: 0x06002331 RID: 9009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGamePlayTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002332 RID: 9010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameMode_Internal(IntPtr WorldContextObject);

		// Token: 0x06002333 RID: 9011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x06002334 RID: 9012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableWorldRendering_Internal(IntPtr WorldContextObject);

		// Token: 0x06002335 RID: 9013
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLevelName_Internal(IntPtr WorldContextObject, bool bRemovePrefixString);

		// Token: 0x06002336 RID: 9014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetClosestListenerLocation_Internal(IntPtr WorldContextObject, in FVector Location, float MaximumRange, bool bAllowAttenuationOverride, ref FVector ListenerPosition);

		// Token: 0x06002337 RID: 9015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAudioTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002338 RID: 9016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsWithTag_Internal(IntPtr WorldContextObject, FName Tag, IntPtr OutActors);

		// Token: 0x06002339 RID: 9017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsWithInterface_Internal(IntPtr WorldContextObject, IntPtr Interface, IntPtr OutActors);

		// Token: 0x0600233A RID: 9018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsOfClassWithTag_Internal(IntPtr WorldContextObject, IntPtr ActorClass, FName Tag, IntPtr OutActors);

		// Token: 0x0600233B RID: 9019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, IntPtr OutActors);

		// Token: 0x0600233C RID: 9020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClassWithName_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FString ActorName);

		// Token: 0x0600233D RID: 9021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x0600233E RID: 9022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActorCountOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x0600233F RID: 9023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorArrayBounds_Internal(IntPtr Actors, bool bOnlyCollidingComponents, ref FVector Center, ref FVector BoxExtent);

		// Token: 0x06002340 RID: 9024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorArrayAverageLocation_Internal(IntPtr Actors);

		// Token: 0x06002341 RID: 9025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAccurateRealTime_Internal(IntPtr WorldContextObject, ref int Seconds, ref float PartialSeconds);

		// Token: 0x06002342 RID: 9026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x06002343 RID: 9027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FinishSpawningActor_Internal(IntPtr Actor, in FTransform SpawnTransform);

		// Token: 0x06002344 RID: 9028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindCollisionUV_Internal(IntPtr Hit, int UVChannel, ref FVector2D UV);

		// Token: 0x06002345 RID: 9029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExportPngPhotoFromFile_Internal(in FString SourceFileName, in FString Title);

		// Token: 0x06002346 RID: 9030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExportPngPhotoFromData_Internal(IntPtr UserData, in FString Title);

		// Token: 0x06002347 RID: 9031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesSaveGameExist_Internal(in FString SlotName, int UserIndex);

		// Token: 0x06002348 RID: 9032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectScreenToWorld_Internal(IntPtr Player, in FVector2D ScreenPosition, ref FVector WorldPosition, ref FVector WorldDirection);

		// Token: 0x06002349 RID: 9033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteGameInSlot_Internal(in FString SlotName, int UserIndex);

		// Token: 0x0600234A RID: 9034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateReverbEffect_Internal(IntPtr WorldContextObject, FName TagName);

		// Token: 0x0600234B RID: 9035
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnForceFeedbackAttached_Internal(IntPtr ForceFeedbackEffect, IntPtr AttachToComponent, FName AttachPointName, FVectorDouble Location, FRotator Rotation, TEnumAsByte<EAttachLocation> LocationType, bool bStopWhenAttachedToDestroyed, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x0600234C RID: 9036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnForceFeedbackAtLocation_Internal(IntPtr WorldContextObject, IntPtr ForceFeedbackEffect, FVectorDouble Location, FRotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, IntPtr AttenuationSettings, bool bAutoDestroy);

		// Token: 0x0600234D RID: 9037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActorFromClassInLevel_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride);

		// Token: 0x0600234E RID: 9038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_ProjectWorldToScreen_Internal(IntPtr Player, in FVectorDouble WorldPosition, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x0600234F RID: 9039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_PlayWorldCameraShakeWithModifier_Internal(IntPtr WorldContextObject, IntPtr Shake, FVectorDouble Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bOrientShakeTowardsEpicenter, float ShakeModifier, float TimeDilation);

		// Token: 0x06002350 RID: 9040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetWorldDeltaSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002351 RID: 9041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetWorldCameraLocation_Internal(IntPtr InWorld, ref FVectorDouble OutCameraLocation);

		// Token: 0x06002352 RID: 9042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002353 RID: 9043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetGamePlayTimeSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002354 RID: 9044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_FinishSpawningActor_Internal(IntPtr Actor, in FTransformDouble SpawnTransform);

		// Token: 0x06002355 RID: 9045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_DeprojectScreenToWorld_Internal(IntPtr Player, in FVector2D ScreenPosition, ref FVectorDouble WorldPosition, ref FVector WorldDirection);

		// Token: 0x06002356 RID: 9046
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_Blueprint_PredictProjectilePath_ByTraceChannel_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVectorDouble OutLastTraceDestination, FVectorDouble StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x06002357 RID: 9047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_BeginDeferredActorSpawnFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner);

		// Token: 0x06002358 RID: 9048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePlayer_Internal(IntPtr WorldContextObject, int ControllerId, bool bSpawnPlayerController);

		// Token: 0x06002359 RID: 9049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSoundMixModifiers_Internal(IntPtr WorldContextObject);

		// Token: 0x0600235A RID: 9050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakHitResult_Internal(IntPtr Hit, ref bool bBlockingHit, ref bool bInitialOverlap, ref float Time, ref float Distance, ref FVector Location, ref FVector ImpactPoint, ref FVector Normal, ref FVector ImpactNormal, ref IntPtr PhysMat, ref IntPtr HitActor, ref IntPtr HitComponent, ref FName HitBoneName, ref int HitItem, ref int FaceIndex, ref FVector TraceStart, ref FVector TraceEnd);

		// Token: 0x0600235B RID: 9051
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_ByTraceChannel_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x0600235C RID: 9052
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_ByObjectType_Internal(IntPtr WorldContextObject, IntPtr OutHit, IntPtr OutPathPositions, ref FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, float SimFrequency, float MaxSimTime, float OverrideGravityZ);

		// Token: 0x0600235D RID: 9053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Blueprint_PredictProjectilePath_Advanced_Internal(IntPtr WorldContextObject, IntPtr PredictParams, IntPtr PredictResult);

		// Token: 0x0600235E RID: 9054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginSpawningActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, bool bNoCollisionFail, IntPtr Owner);

		// Token: 0x0600235F RID: 9055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginSpawningActorFromBlueprint_Internal(IntPtr WorldContextObject, IntPtr Blueprint, in FTransform SpawnTransform, bool bNoCollisionFail);

		// Token: 0x06002360 RID: 9056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BeginDeferredActorSpawnFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner);

		// Token: 0x06002361 RID: 9057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AreAnyListenersWithinRange_Internal(IntPtr WorldContextObject, in FVector Location, float MaximumRange);

		// Token: 0x06002362 RID: 9058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AnnounceAccessibleString_Internal(in FString AnnouncementString);

		// Token: 0x06002363 RID: 9059 RVA: 0x00033B8C File Offset: 0x00031D8C
		static UGameplayStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameplayStatics");
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00033B9A File Offset: 0x00031D9A
		protected UGameplayStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D6D RID: 3437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameplayStatics";

		// Token: 0x04000D6E RID: 3438
		private static IntPtr _ClassPtr;

		// Token: 0x04000D6F RID: 3439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
