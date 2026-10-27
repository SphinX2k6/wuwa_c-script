using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9F RID: 7071
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroRenderingRuntimeBPPluginBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AEB2 RID: 110258 RVA: 0x0027AF3A File Offset: 0x0027913A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary._ClassPtr;
		}

		// Token: 0x0601AEB3 RID: 110259 RVA: 0x0027AF48 File Offset: 0x00279148
		public UKuroRenderingRuntimeBPPluginBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingRuntimeBPPluginBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AEB4 RID: 110260 RVA: 0x0027AF70 File Offset: 0x00279170
		[NullableContext(1)]
		public UKuroRenderingRuntimeBPPluginBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingRuntimeBPPluginBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AEB5 RID: 110261 RVA: 0x0027AFA3 File Offset: 0x002791A3
		public static void WriteRenderTargetColorEditorOnly(UTextureRenderTarget2D RT, in TArray<FLinearColor> Colors)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__WriteRenderTargetColorEditorOnly_Internal((RT != null) ? RT.NativePtr : IntPtr.Zero, (Colors ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x0601AEB6 RID: 110262 RVA: 0x0027AFCC File Offset: 0x002791CC
		public unsafe static void WpPEnterCaveOrRoom(UObject WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer)
		{
			fixed (FName* ptr = &EncloseDataLayer)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &EncloseSubDataLayer)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__WpPEnterCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, EncloseDataLayer, EncloseSubDataLayer);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AEB7 RID: 110263 RVA: 0x0027B000 File Offset: 0x00279200
		public unsafe static void WpLeaveCaveOrRoom(UObject WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer)
		{
			fixed (FName* ptr = &EncloseDataLayer)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &EncloseSubDataLayer)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__WpLeaveCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, EncloseDataLayer, EncloseSubDataLayer);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AEB8 RID: 110264 RVA: 0x0027B034 File Offset: 0x00279234
		public unsafe static void WpEnterCaveOrRoom(UObject WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer, float InAdjustValue = 1f, ECaveOrRoomLoadType LoadType = ECaveOrRoomLoadType.DoNothing, bool bUseCustomCoef = false)
		{
			fixed (FName* ptr = &EncloseDataLayer)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &EncloseSubDataLayer)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__WpEnterCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, EncloseDataLayer, EncloseSubDataLayer, InAdjustValue, LoadType, bUseCustomCoef);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AEB9 RID: 110265 RVA: 0x0027B06D File Offset: 0x0027926D
		public static void WpCancelAdjustLoadRange(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__WpCancelAdjustLoadRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AEBA RID: 110266 RVA: 0x0027B084 File Offset: 0x00279284
		public unsafe static void WpBeginLeaveCaveOrRoom(UObject WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer)
		{
			fixed (FName* ptr = &EncloseDataLayer)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &EncloseSubDataLayer)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__WpBeginLeaveCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, EncloseDataLayer, EncloseSubDataLayer);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AEBB RID: 110267 RVA: 0x0027B0B8 File Offset: 0x002792B8
		public unsafe static void WpBeginEnterCaveOrRoom(UObject WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer)
		{
			fixed (FName* ptr = &EncloseDataLayer)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &EncloseSubDataLayer)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__WpBeginEnterCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, EncloseDataLayer, EncloseSubDataLayer);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AEBC RID: 110268 RVA: 0x0027B0EC File Offset: 0x002792EC
		public static void WpBeginAdjustLoadRange(UObject WorldContextObject, float InAdjustValue = 1f, ECaveOrRoomLoadType InLoadType = ECaveOrRoomLoadType.DoNothing, bool bUseCustomCoef = false)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__WpBeginAdjustLoadRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InAdjustValue, InLoadType, bUseCustomCoef);
		}

		// Token: 0x0601AEBD RID: 110269 RVA: 0x0027B108 File Offset: 0x00279308
		[NullableContext(1)]
		public unsafe static void WeaponInteractCollisionAnyHit([Nullable(2)] UObject WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, ref string DebugInfo)
		{
			FString fstring = FString.AllocTemp(DebugInfo);
			fixed (bool* ptr = &HitBool)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &ValidBool)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &OutHitPoint)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &OutPos)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &OutPosPre)
							{
								void* ptr10 = (void*)ptr9;
								UKuroRenderingRuntimeBPPluginBPLibrary.__WeaponInteractCollisionAnyHit_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HitPos, WeaponTypeID, ref HitBool, ref ValidBool, ref OutHitPoint, ref OutPos, ref OutPosPre, ref fstring);
								DebugInfo = FString.ToString(fstring);
								FString.NativeDestruct(&fstring, 1);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x0601AEBE RID: 110270 RVA: 0x0027B190 File Offset: 0x00279390
		public unsafe static void WeaponInteractCollision(UObject WorldContextObject, FVector HitPos, int WeaponTypeID, UPrimitiveComponent HitComponent, float SweepRadius, float SpeedThreshold, float ValidTimeWindow, bool bShowTrace, float TraceDebugLifeTime, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, [Nullable(1)] ref string DebugInfo)
		{
			FString fstring = FString.AllocTemp(DebugInfo);
			fixed (bool* ptr = &HitBool)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &ValidBool)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &OutHitPoint)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &OutPos)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &OutPosPre)
							{
								void* ptr10 = (void*)ptr9;
								UKuroRenderingRuntimeBPPluginBPLibrary.__WeaponInteractCollision_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HitPos, WeaponTypeID, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, SweepRadius, SpeedThreshold, ValidTimeWindow, bShowTrace, TraceDebugLifeTime, ref HitBool, ref ValidBool, ref OutHitPoint, ref OutPos, ref OutPosPre, ref fstring);
								DebugInfo = FString.ToString(fstring);
								FString.NativeDestruct(&fstring, 1);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x0601AEBF RID: 110271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D VolumeSphereInWater(FVector Pos, float Radius, float WaterHeight);

		// Token: 0x0601AEC0 RID: 110272 RVA: 0x0027B234 File Offset: 0x00279434
		public static void UpdateOrAddCurveFloatValue(UCurveFloat Curve, float InTime, float InValue)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateOrAddCurveFloatValue_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, InTime, InValue);
		}

		// Token: 0x0601AEC1 RID: 110273 RVA: 0x0027B24D File Offset: 0x0027944D
		public static void UpdateOrAddCurveColorValue(UCurveLinearColor Curve, float InTime, FLinearColor InValue)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateOrAddCurveColorValue_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, InTime, InValue);
		}

		// Token: 0x0601AEC2 RID: 110274
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateMountainRowLoopLocation(in FVectorDouble BaseLocation, double OriginY, double TileLength, double Speed, double DeltaSeconds, ref double InOutFlowDistance, ref FVectorDouble OutLocation, ref double OutDeltaY, ref double OutLoopRelY);

		// Token: 0x0601AEC3 RID: 110275 RVA: 0x0027B266 File Offset: 0x00279466
		public static void UpdateFoliageDataLayer(UObject WorldContextObject, int InMobileLevel)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateFoliageDataLayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InMobileLevel);
		}

		// Token: 0x0601AEC4 RID: 110276 RVA: 0x0027B27E File Offset: 0x0027947E
		public static void UpdateEffectTransformLocation(bool ForceUpdate, USceneComponent SceneComponent, in FKuroCurveVector LocationCurve, float Time)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateEffectTransformLocation_Internal(ForceUpdate, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, (LocationCurve ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x0601AEC5 RID: 110277 RVA: 0x0027B2A8 File Offset: 0x002794A8
		public static void UpdateEffectTransform(bool ForceUpdate, USceneComponent SceneComponent, in FKuroCurveVector LocationCurve, in FKuroCurveVector RotationCurve, in FKuroCurveVector ScaleCurve, float Time)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateEffectTransform_Internal(ForceUpdate, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, (LocationCurve ?? new FKuroCurveVector()).NativePtr, (RotationCurve ?? new FKuroCurveVector()).NativePtr, (ScaleCurve ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x0601AEC6 RID: 110278 RVA: 0x0027B300 File Offset: 0x00279500
		public static void UpdateBridgeParticleConstraint(ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, float plankRestLength, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, int numIterations = 1)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateBridgeParticleConstraint_Internal((posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, plankRestLength, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, numIterations);
		}

		// Token: 0x0601AEC7 RID: 110279 RVA: 0x0027B358 File Offset: 0x00279558
		public static void UpdateBridgeFakeCollision(ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, in FVector cylinderCenter, in FVector cylinderAxis, float cylinderRadius, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, int numIterations = 1, in FVector playerPos = null, float playerCollisionRadius = 0f, float playerPushStrength = 30f)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateBridgeFakeCollision_Internal((posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, cylinderCenter, cylinderAxis, cylinderRadius, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, numIterations, playerPos, playerCollisionRadius, playerPushStrength);
		}

		// Token: 0x0601AEC8 RID: 110280 RVA: 0x0027B3B8 File Offset: 0x002795B8
		public static void UpdataPlaneList_PBD_WithChainState([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, FVector bridgeDir)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdataPlaneList_PBD_WithChainState_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, bridgeDir);
		}

		// Token: 0x0601AEC9 RID: 110281 RVA: 0x0027B41D File Offset: 0x0027961D
		public static void UpdataPlaneList_PBD([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, ref TArray<FVector> posArr, ref TArray<FVector> posArrR)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdataPlaneList_PBD_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (posArr ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0601AECA RID: 110282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor UnpackVector2DToLinearColorRGB(in FVector2D Vector2D);

		// Token: 0x0601AECB RID: 110283 RVA: 0x0027B454 File Offset: 0x00279654
		public static void UnFreezeWorldLevelStreaming(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UnFreezeWorldLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AECC RID: 110284 RVA: 0x0027B46B File Offset: 0x0027966B
		public static void SyncBridgeChainVelocityAfterPostSteps(ref TArray<FVector> posArr, in TArray<FVector> posFoeSnapshot, ref TArray<FVector> volArr, bool isFirstFrame, float volDamping, float dt)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SyncBridgeChainVelocityAfterPostSteps_Internal((posArr ?? new TArray<FVector>()).NativePtr, (posFoeSnapshot ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, isFirstFrame, volDamping, dt);
		}

		// Token: 0x0601AECD RID: 110285 RVA: 0x0027B4A8 File Offset: 0x002796A8
		public unsafe static bool SweptBladeTraceComponent(UObject WorldContextObject, UPrimitiveComponent TargetComponent, FVector PrevRootPoint, FVector CurrRootPoint, FVector PrevTipPoint, FVector CurrTipPoint, float SweepRadius, int MaxSampleCount, ref FHitResult OutHit, ref int ActualSampleCount, bool bShowTrace = false, bool bTraceComplex = false, bool bUseWorldSweepByChannel = false, ETraceTypeQuery TraceChannel = ETraceTypeQuery.TraceTypeQuery1, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null)
		{
			fixed (int* ptr = &ActualSampleCount)
			{
				void* ptr2 = (void*)ptr;
				IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
				IntPtr targetComponent = (TargetComponent != null) ? TargetComponent.NativePtr : IntPtr.Zero;
				IntPtr nativePtr = (OutHit ?? new FHitResult()).NativePtr;
				TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
				FLinearColor? flinearColor = TraceColor;
				FLinearColor traceColor;
				if (flinearColor == null)
				{
					FLinearColor flinearColor2 = new FLinearColor
					{
						R = 1f,
						G = 0f,
						B = 0f,
						A = 1f
					};
					traceColor = flinearColor2;
				}
				else
				{
					traceColor = flinearColor.GetValueOrDefault();
				}
				flinearColor = TraceHitColor;
				FLinearColor traceHitColor;
				if (flinearColor == null)
				{
					FLinearColor flinearColor2 = new FLinearColor
					{
						R = 0f,
						G = 1f,
						B = 0f,
						A = 1f
					};
					traceHitColor = flinearColor2;
				}
				else
				{
					traceHitColor = flinearColor.GetValueOrDefault();
				}
				return UKuroRenderingRuntimeBPPluginBPLibrary.__SweptBladeTraceComponent_Internal(worldContextObject, targetComponent, PrevRootPoint, CurrRootPoint, PrevTipPoint, CurrTipPoint, SweepRadius, MaxSampleCount, nativePtr, ref ActualSampleCount, bShowTrace, bTraceComplex, bUseWorldSweepByChannel, traceChannel, traceColor, traceHitColor);
			}
		}

		// Token: 0x0601AECE RID: 110286 RVA: 0x0027B5A4 File Offset: 0x002797A4
		public static void SuppressProceduralMeshLocalZAngularVelocity(UProceduralMeshComponent ProceduralMeshComp)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SuppressProceduralMeshLocalZAngularVelocity_Internal((ProceduralMeshComp != null) ? ProceduralMeshComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AECF RID: 110287
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportVulkan();

		// Token: 0x0601AED0 RID: 110288 RVA: 0x0027B5BB File Offset: 0x002797BB
		public static void StopSomeWeatherBeforeTeleport(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__StopSomeWeatherBeforeTeleport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AED1 RID: 110289
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType Type = EKuroCaptureSceneColorType.KCSCT_Default, float HoldSeconds = 2f);

		// Token: 0x0601AED2 RID: 110290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType Type = EKuroCaptureSceneColorType.KCSCT_Default);

		// Token: 0x0601AED3 RID: 110291 RVA: 0x0027B5D2 File Offset: 0x002797D2
		public static void SplineMover([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMoveData_splineMover> MoveStates, USplineComponent splineComp, float totalSplineLength, float moveSpeed, float deltaSeconds, float Tolerance)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SplineMover_Internal((MoveStates ?? new TArray<FMoveData_splineMover>()).NativePtr, (splineComp != null) ? splineComp.NativePtr : IntPtr.Zero, totalSplineLength, moveSpeed, deltaSeconds, Tolerance);
		}

		// Token: 0x0601AED4 RID: 110292 RVA: 0x0027B600 File Offset: 0x00279800
		public unsafe static AActor SpawnTransientActor(UObject WorldContextObject, in FName Name, in FName FolderPath)
		{
			fixed (FName* ptr = &Name)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &FolderPath)
				{
					void* ptr4 = (void*)ptr3;
					return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__SpawnTransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Name, FolderPath));
				}
			}
		}

		// Token: 0x0601AED5 RID: 110293 RVA: 0x0027B634 File Offset: 0x00279834
		public static void SpawnChunksForFullyDetachedBridgePlanks([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroBridgeChunkMeshList> chunkMeshLists, bool bHideOriginalPlank = true, float spawnProbability = 1f, int breakHitIndex = -1)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SpawnChunksForFullyDetachedBridgePlanks_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, (chunkMeshLists ?? new TArray<FKuroBridgeChunkMeshList>()).NativePtr, bHideOriginalPlank, spawnProbability, breakHitIndex);
		}

		// Token: 0x0601AED6 RID: 110294 RVA: 0x0027B68C File Offset: 0x0027988C
		public unsafe static AActor SpawnActorFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null, bool bTemporaryEditorActor = true)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__SpawnActorFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero, bTemporaryEditorActor));
		}

		// Token: 0x0601AED7 RID: 110295 RVA: 0x0027B6FD File Offset: 0x002798FD
		public static void SortStringArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InStringArray, ESearchCase SearchCase = ESearchCase.CaseSensitive, bool Descending = false)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SortStringArray_Internal((InStringArray ?? new TArray<string>()).NativePtr, SearchCase, Descending);
		}

		// Token: 0x0601AED8 RID: 110296 RVA: 0x0027B71B File Offset: 0x0027991B
		public static void SortStaticMeshComponentsByName([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> SortedComponents)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SortStaticMeshComponentsByName_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (SortedComponents ?? new TArray<UStaticMeshComponent>()).NativePtr);
		}

		// Token: 0x0601AED9 RID: 110297
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector solvenostretch(in FVector pos, in FVector linkPos, float targetLen, in FVector emiterOriginPos, bool isPinned);

		// Token: 0x0601AEDA RID: 110298
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector solve(in FVector pos, in FVector linkPos, float targetLen, in FVector emiterOriginPos, bool isPinned);

		// Token: 0x0601AEDB RID: 110299 RVA: 0x0027B742 File Offset: 0x00279942
		public static void SetWorldPartitionStreamingEnable(UObject WorldContextObject, bool bStreamingEnable)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionStreamingEnable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bStreamingEnable);
		}

		// Token: 0x0601AEDC RID: 110300 RVA: 0x0027B75A File Offset: 0x0027995A
		public static void SetWorldPartitionDataLayerState2(UObject WorldContextObject, FName DataLayerName, EDataLayerState NewState)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionDataLayerState2_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName, NewState);
		}

		// Token: 0x0601AEDD RID: 110301 RVA: 0x0027B773 File Offset: 0x00279973
		public static void SetWorldPartitionDataLayerState(UObject WorldContextObject, FName DataLayerName, bool IsActivate)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionDataLayerState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName, IsActivate);
		}

		// Token: 0x0601AEDE RID: 110302 RVA: 0x0027B78C File Offset: 0x0027998C
		public static void SetWorldOrigin(UObject WorldContextObject, in FVectorDouble InNewOrigin)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldOrigin_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InNewOrigin);
		}

		// Token: 0x0601AEDF RID: 110303
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetVulkanPromotion(bool promot);

		// Token: 0x0601AEE0 RID: 110304 RVA: 0x0027B7A4 File Offset: 0x002799A4
		public static void SetVolumertricCloudShadowColor(UVolumetricCloudComponent CloudComponent, FLinearColor Color)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetVolumertricCloudShadowColor_Internal((CloudComponent != null) ? CloudComponent.NativePtr : IntPtr.Zero, Color);
		}

		// Token: 0x0601AEE1 RID: 110305 RVA: 0x0027B7BC File Offset: 0x002799BC
		public static void SetVolumertricCloudLightColor(UVolumetricCloudComponent CloudComponent, FLinearColor Color)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetVolumertricCloudLightColor_Internal((CloudComponent != null) ? CloudComponent.NativePtr : IntPtr.Zero, Color);
		}

		// Token: 0x0601AEE2 RID: 110306 RVA: 0x0027B7D4 File Offset: 0x002799D4
		public static void SetVolumertricCloudCustomLighting(UVolumetricCloudComponent CloudComponent, float customLighting)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetVolumertricCloudCustomLighting_Internal((CloudComponent != null) ? CloudComponent.NativePtr : IntPtr.Zero, customLighting);
		}

		// Token: 0x0601AEE3 RID: 110307 RVA: 0x0027B7EC File Offset: 0x002799EC
		public unsafe static void SetVectorParameterValueRef(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, ref FLinearColor RefLinearColor)
		{
			fixed (FLinearColor* ptr = &RefLinearColor)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__SetVectorParameterValueRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ref RefLinearColor);
			}
		}

		// Token: 0x0601AEE4 RID: 110308 RVA: 0x0027B828 File Offset: 0x00279A28
		public static void SetUsingInCaveOrIndoorShadow(UDirectionalLightComponent LightComp, bool IsUsing, float MobileCSMDistanceOld, float MobileCSMDistanceNew)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetUsingInCaveOrIndoorShadow_Internal((LightComp != null) ? LightComp.NativePtr : IntPtr.Zero, IsUsing, MobileCSMDistanceOld, MobileCSMDistanceNew);
		}

		// Token: 0x0601AEE5 RID: 110309 RVA: 0x0027B842 File Offset: 0x00279A42
		public static void SetupVolumeSize(AVolume Volume, in FBox Bounds)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetupVolumeSize_Internal((Volume != null) ? Volume.NativePtr : IntPtr.Zero, Bounds);
		}

		// Token: 0x0601AEE6 RID: 110310 RVA: 0x0027B85A File Offset: 0x00279A5A
		public static void SetTransformLocationInArray(ref TArray<FTransform> TransformArray, int index, in FVector Location)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetTransformLocationInArray_Internal((TransformArray ?? new TArray<FTransform>()).NativePtr, index, Location);
		}

		// Token: 0x0601AEE7 RID: 110311 RVA: 0x0027B873 File Offset: 0x00279A73
		public static void SetSunLensflareEnabled(UObject WorldContextObject, bool bEnabled)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSunLensflareEnabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bEnabled);
		}

		// Token: 0x0601AEE8 RID: 110312 RVA: 0x0027B88C File Offset: 0x00279A8C
		[NullableContext(1)]
		public unsafe static void SetString([Nullable(2)] UObject WorldContextObject, string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601AEE9 RID: 110313 RVA: 0x0027B8D2 File Offset: 0x00279AD2
		public static void SetSceneRenderingState(UObject WorldContextObject, bool bSceneVisible)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneRenderingState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bSceneVisible);
		}

		// Token: 0x0601AEEA RID: 110314 RVA: 0x0027B8EA File Offset: 0x00279AEA
		public static void SetSceneKuroViewCenter(UObject WorldContextObject, FVector Location)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneKuroViewCenter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x0601AEEB RID: 110315 RVA: 0x0027B902 File Offset: 0x00279B02
		public static void SetSceneKuroMainPlayerLocation(UObject WorldContextObject, int PlayerIndex)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneKuroMainPlayerLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex);
		}

		// Token: 0x0601AEEC RID: 110316 RVA: 0x0027B91A File Offset: 0x00279B1A
		public static bool SetSceneCaptureOffAxisProjection(USceneCaptureComponent2D CaptureComponent, float Left, float Right, float Bottom, float Top, float NearPlane)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneCaptureOffAxisProjection_Internal((CaptureComponent != null) ? CaptureComponent.NativePtr : IntPtr.Zero, Left, Right, Bottom, Top, NearPlane);
		}

		// Token: 0x0601AEED RID: 110317
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRayTracingEnable(bool bEnable);

		// Token: 0x0601AEEE RID: 110318 RVA: 0x0027B938 File Offset: 0x00279B38
		public static void SetOtherCharacterFootWP(UObject WorldContextObject, UMaterialParameterCollection Collection, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> OtherCharacter, FVector CharacterPos)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetOtherCharacterFootWP_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (OtherCharacter ?? new TArray<AActor>()).NativePtr, CharacterPos);
		}

		// Token: 0x0601AEEF RID: 110319 RVA: 0x0027B96F File Offset: 0x00279B6F
		public static void SetObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x0601AEF0 RID: 110320 RVA: 0x0027B988 File Offset: 0x00279B88
		public unsafe static void SetNiagaraSplineComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USplineComponent SplineComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraSplineComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SplineComponent != null) ? SplineComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEF1 RID: 110321 RVA: 0x0027B9CC File Offset: 0x00279BCC
		public unsafe static void SetNiagaraSkeletalMeshComponentWithoutWarning(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraSkeletalMeshComponentWithoutWarning_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEF2 RID: 110322 RVA: 0x0027BA10 File Offset: 0x00279C10
		public unsafe static void SetNiagaraMultiSplineSource(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, AActor SourceActor)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraMultiSplineSource_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SourceActor != null) ? SourceActor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEF3 RID: 110323 RVA: 0x0027BA54 File Offset: 0x00279C54
		[NullableContext(1)]
		public unsafe static void SetNiagaraMultiSplineComponents([Nullable(2)] UNiagaraComponent NiagaraSystem, string OverrideName, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USplineComponent> SplineComponents)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraMultiSplineComponents_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SplineComponents ?? new TArray<USplineComponent>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEF4 RID: 110324 RVA: 0x0027BA98 File Offset: 0x00279C98
		public unsafe static bool SetNiagaraHoudiniPointDataCache(UNiagaraComponent NiagaraComponent, UHoudiniPointCache HPCA, [Nullable(1)] string ParameterName)
		{
			FString fstring = FString.AllocTemp(ParameterName);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraHoudiniPointDataCache_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, (HPCA != null) ? HPCA.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AEF5 RID: 110325 RVA: 0x0027BADC File Offset: 0x00279CDC
		public static bool SetLevelEditorCameraLocation(UObject WorldContextObject, FVector Position)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetLevelEditorCameraLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position);
		}

		// Token: 0x0601AEF6 RID: 110326 RVA: 0x0027BAF4 File Offset: 0x00279CF4
		public static void SetIsUsingInCaveOrIndoorShadow(UObject WorldContextObject, bool IsUsing, float MobileCSMDistanceInCave, float MobileCSMDistanceOutCave)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetIsUsingInCaveOrIndoorShadow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IsUsing, MobileCSMDistanceInCave, MobileCSMDistanceOutCave);
		}

		// Token: 0x0601AEF7 RID: 110327 RVA: 0x0027BB0E File Offset: 0x00279D0E
		public static void SetIntsDataToRenderTarget(UTextureRenderTarget2D TextureRenderTarget, TArray<int> WriteData)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetIntsDataToRenderTarget_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (WriteData ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0601AEF8 RID: 110328 RVA: 0x0027BB34 File Offset: 0x00279D34
		[NullableContext(1)]
		public unsafe static void SetInt([Nullable(2)] UObject WorldContextObject, string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetInt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEF9 RID: 110329 RVA: 0x0027BB69 File Offset: 0x00279D69
		public static bool SetGlobalGITime(UObject WorldContextObject, float Time)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetGlobalGITime_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x0601AEFA RID: 110330 RVA: 0x0027BB81 File Offset: 0x00279D81
		public static void SetGITransientActorAttachment(UObject WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetGITransientActorAttachment_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName, bAttachToPlayer, bAttachToEditorCamera);
		}

		// Token: 0x0601AEFB RID: 110331 RVA: 0x0027BB9C File Offset: 0x00279D9C
		[NullableContext(1)]
		public unsafe static void SetFloat([Nullable(2)] UObject WorldContextObject, string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetFloat_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEFC RID: 110332 RVA: 0x0027BBD1 File Offset: 0x00279DD1
		public static void SetDisableEffectPostProcessVolume(UObject WorldContextObject, bool bDisable, float ChangeSpeed)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetDisableEffectPostProcessVolume_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bDisable, ChangeSpeed);
		}

		// Token: 0x0601AEFD RID: 110333 RVA: 0x0027BBEC File Offset: 0x00279DEC
		[NullableContext(1)]
		public unsafe static void SetCVarInt32(string CVarKey, int Value)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCVarInt32_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEFE RID: 110334 RVA: 0x0027BC14 File Offset: 0x00279E14
		[NullableContext(1)]
		public unsafe static void SetCVarFloat(string CVarKey, float Value)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCVarFloat_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AEFF RID: 110335 RVA: 0x0027BC39 File Offset: 0x00279E39
		public static void SetClusteredStuffVisible(UObject WorldContextObject, bool Visible)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetClusteredStuffVisible_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Visible);
		}

		// Token: 0x0601AF00 RID: 110336 RVA: 0x0027BC51 File Offset: 0x00279E51
		public static void SetCharacterInBattle(UObject WorldContextObject, bool bInBattle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCharacterInBattle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bInBattle);
		}

		// Token: 0x0601AF01 RID: 110337 RVA: 0x0027BC69 File Offset: 0x00279E69
		public static FVector SetCharacterFootWP(UObject WorldContextObject, UMaterialParameterCollection Collection, USceneComponent CharacterMesh)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetCharacterFootWP_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (CharacterMesh != null) ? CharacterMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF02 RID: 110338
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAnisoLevel(int Level);

		// Token: 0x0601AF03 RID: 110339 RVA: 0x0027BCA0 File Offset: 0x00279EA0
		public static void SetActorUISceneRendering(AActor Actor, bool IsUISceneRendering)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetActorUISceneRendering_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, IsUISceneRendering);
		}

		// Token: 0x0601AF04 RID: 110340 RVA: 0x0027BCB8 File Offset: 0x00279EB8
		public static void Save(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__Save_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF05 RID: 110341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor RGB2HSP(FLinearColor rgb);

		// Token: 0x0601AF06 RID: 110342 RVA: 0x0027BCCF File Offset: 0x00279ECF
		public static void ResumeSomeWeatherAfterTeleport(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ResumeSomeWeatherAfterTeleport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF07 RID: 110343 RVA: 0x0027BCE6 File Offset: 0x00279EE6
		public static void ResizeRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget, int InSizeX, int InSizeY)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ResizeRenderTarget2D_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, InSizeX, InSizeY);
		}

		// Token: 0x0601AF08 RID: 110344 RVA: 0x0027BCFF File Offset: 0x00279EFF
		public static void ResetParticleSystem(UParticleSystemComponent ParticleSystemComponent)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ResetParticleSystem_Internal((ParticleSystemComponent != null) ? ParticleSystemComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF09 RID: 110345 RVA: 0x0027BD16 File Offset: 0x00279F16
		public static void RerunConstructionScripts(AActor Actor)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__RerunConstructionScripts_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF0A RID: 110346 RVA: 0x0027BD2D File Offset: 0x00279F2D
		public static void RemovePostprocessMaterial(UObject WorldContextObject, int Handle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__RemovePostprocessMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Handle);
		}

		// Token: 0x0601AF0B RID: 110347 RVA: 0x0027BD45 File Offset: 0x00279F45
		public static void RemoveAdditionalClusteredStuff(UObject WorldContextObject, UClusteredStuffDataAsset Asset)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__RemoveAdditionalClusteredStuff_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Asset != null) ? Asset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF0C RID: 110348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseGetSceneDepthShotBefore();

		// Token: 0x0601AF0D RID: 110349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseGetSceneColorShotBefore();

		// Token: 0x0601AF0E RID: 110350 RVA: 0x0027BD6C File Offset: 0x00279F6C
		public unsafe static bool ProjectWorldToScreenWithLevelEditorViewPortFloatRef(UObject WorldContextObject, in FVector WorldPosition, ref float ResultX, ref float ResultY, ref float ResultZ, ref float ResultW)
		{
			fixed (float* ptr = &ResultX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &ResultY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &ResultZ)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &ResultW)
						{
							void* ptr8 = (void*)ptr7;
							return UKuroRenderingRuntimeBPPluginBPLibrary.__ProjectWorldToScreenWithLevelEditorViewPortFloatRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, ref ResultX, ref ResultY, ref ResultZ, ref ResultW);
						}
					}
				}
			}
		}

		// Token: 0x0601AF0F RID: 110351 RVA: 0x0027BDB4 File Offset: 0x00279FB4
		public unsafe static bool ProjectWorldToScreenWithLevelEditorViewPort(UObject WorldContextObject, in FVector worldPosition, ref FVector4 result)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = result;
			bool result2 = UKuroRenderingRuntimeBPPluginBPLibrary.__ProjectWorldToScreenWithLevelEditorViewPort_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, worldPosition, ref ptr);
			result = ptr;
			return result2;
		}

		// Token: 0x0601AF10 RID: 110352 RVA: 0x0027BE00 File Offset: 0x0027A000
		public unsafe static void PBDQiuQian_MY([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FParticle_QiuQian> particleArr, float linkDis, in FVector startPos, in FVector endPos, in FVector accel_ext, float collisionR, float volDamping, float dt, in FVector playerPos, float pushStrength, bool isStandOnPlank, ref FVector leftPos, ref FVector rightPos, ref FVector leftNorm, ref FVector rightNorm)
		{
			fixed (FVector* ptr = &leftPos)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &rightPos)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &leftNorm)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &rightNorm)
						{
							void* ptr8 = (void*)ptr7;
							UKuroRenderingRuntimeBPPluginBPLibrary.__PBDQiuQian_MY_Internal((particleArr ?? new TArray<FParticle_QiuQian>()).NativePtr, linkDis, startPos, endPos, accel_ext, collisionR, volDamping, dt, playerPos, pushStrength, isStandOnPlank, ref leftPos, ref rightPos, ref leftNorm, ref rightNorm);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601AF11 RID: 110353 RVA: 0x0027BE6C File Offset: 0x0027A06C
		public unsafe static void PBDQiuQian_Broken([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FParticle_QiuQian> particleArr, float linkDis, in FVector startPos, in FVector endPos, in FVector accel_ext, float collisionR, float groundHeight, float volDamping, float dt, in FVector playerPos, float pushStrength, bool isStandOnPlank, ref FVector leftPos, ref FVector rightPos, ref FVector leftNorm, ref FVector rightNorm)
		{
			fixed (FVector* ptr = &leftPos)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &rightPos)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &leftNorm)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &rightNorm)
						{
							void* ptr8 = (void*)ptr7;
							UKuroRenderingRuntimeBPPluginBPLibrary.__PBDQiuQian_Broken_Internal((particleArr ?? new TArray<FParticle_QiuQian>()).NativePtr, linkDis, startPos, endPos, accel_ext, collisionR, groundHeight, volDamping, dt, playerPos, pushStrength, isStandOnPlank, ref leftPos, ref rightPos, ref leftNorm, ref rightNorm);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601AF12 RID: 110354 RVA: 0x0027BEDC File Offset: 0x0027A0DC
		public static void PBDChainParallel_MY(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, bool doParallel = true)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDChainParallel_MY_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, linkDis, emitterOriginPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, doParallel);
		}

		// Token: 0x0601AF13 RID: 110355 RVA: 0x0027BF30 File Offset: 0x0027A130
		public static void PBDChain_MY(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDChain_MY_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, linkDis, emitterOriginPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos);
		}

		// Token: 0x0601AF14 RID: 110356 RVA: 0x0027BF84 File Offset: 0x0027A184
		public static void PBDBridge_RealModelBroken(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, in TArray<float> foeDisList, in TArray<float> nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength, bool bBroken, int breakLeftIndex, ref TArray<byte> outParticleChainLinkMask, int breakExtraTowardStart = 0, int breakExtraTowardEnd = 0, float brokenDetachedEndsGravityAsym = 1f, float groundPlaneWorldZ = 0f, FVector? brokenSimAccelExt = null, float brokenSimVolDamping = 0.99f)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDBridge_RealModelBroken_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, (foeDisList ?? new TArray<float>()).NativePtr, (nxtDisList ?? new TArray<float>()).NativePtr, linkDisScale, startPinPos, endPinPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, bridgeDir, pushStrength, bBroken, breakLeftIndex, (outParticleChainLinkMask ?? new TArray<byte>()).NativePtr, breakExtraTowardStart, breakExtraTowardEnd, brokenDetachedEndsGravityAsym, groundPlaneWorldZ, brokenSimAccelExt ?? new FVector(0f, 0f), brokenSimVolDamping);
		}

		// Token: 0x0601AF15 RID: 110357 RVA: 0x0027C040 File Offset: 0x0027A240
		public static void PBDBridge_RealModel(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, in TArray<float> foeDisList, in TArray<float> nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDBridge_RealModel_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, (foeDisList ?? new TArray<float>()).NativePtr, (nxtDisList ?? new TArray<float>()).NativePtr, linkDisScale, startPinPos, endPinPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, bridgeDir, pushStrength);
		}

		// Token: 0x0601AF16 RID: 110358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D PackLinearColorRGBToVector2D(in FLinearColor Color);

		// Token: 0x0601AF17 RID: 110359 RVA: 0x0027C0B9 File Offset: 0x0027A2B9
		public static void MoveCurveFloatValueToOtherTime(UCurveFloat Curve, float SrcTime, float TargetTime)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MoveCurveFloatValueToOtherTime_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, SrcTime, TargetTime);
		}

		// Token: 0x0601AF18 RID: 110360 RVA: 0x0027C0D2 File Offset: 0x0027A2D2
		public static void MoveCurveColorValueToOtherTime(UCurveLinearColor Curve, float SrcTime, float TargetTime)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MoveCurveColorValueToOtherTime_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, SrcTime, TargetTime);
		}

		// Token: 0x0601AF19 RID: 110361 RVA: 0x0027C0EC File Offset: 0x0027A2EC
		[NullableContext(1)]
		public static void MessageNotify_EditorOnly(FText Message, FName? Tile = null)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MessageNotify_EditorOnly_Internal((Message != null) ? Message.NativePtr : IntPtr.Zero, Tile ?? new FName("MessageNotify"));
		}

		// Token: 0x0601AF1A RID: 110362 RVA: 0x0027C12C File Offset: 0x0027A32C
		[NullableContext(1)]
		public unsafe static bool MaterialHasParameter_EditorOnly([Nullable(2)] UMaterialInterface MaterialInterface, string ParameterName)
		{
			FString fstring = FString.AllocTemp(ParameterName);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__MaterialHasParameter_EditorOnly_Internal((MaterialInterface != null) ? MaterialInterface.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF1B RID: 110363 RVA: 0x0027C160 File Offset: 0x0027A360
		public static void MarkWorldPostProcessPriorityDirty(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MarkWorldPostProcessPriorityDirty_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF1C RID: 110364 RVA: 0x0027C177 File Offset: 0x0027A377
		public static UActorSequencePlayer MakeSequencePlayer(UActorSequenceComponent SequenceComponent, in FMovieSceneSequencePlaybackSettings PlaybackSettings)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorSequencePlayer>(UKuroRenderingRuntimeBPPluginBPLibrary.__MakeSequencePlayer_Internal((SequenceComponent != null) ? SequenceComponent.NativePtr : IntPtr.Zero, (PlaybackSettings ?? new FMovieSceneSequencePlaybackSettings()).NativePtr));
		}

		// Token: 0x0601AF1D RID: 110365 RVA: 0x0027C1A3 File Offset: 0x0027A3A3
		public static void LockProceduralMeshZRotation(UProceduralMeshComponent ProceduralMeshComp, bool bLock = true)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__LockProceduralMeshZRotation_Internal((ProceduralMeshComp != null) ? ProceduralMeshComp.NativePtr : IntPtr.Zero, bLock);
		}

		// Token: 0x0601AF1E RID: 110366 RVA: 0x0027C1BB File Offset: 0x0027A3BB
		[return: Nullable(1)]
		public static FKuroSkyVolumetricCloudSetting LerpSkyVolumetricCloudSetting(in FKuroSkyVolumetricCloudSetting Source, in FKuroSkyVolumetricCloudSetting Destination, float Weight, bool IgnoreOverride = false)
		{
			return new FKuroSkyVolumetricCloudSetting(UKuroRenderingRuntimeBPPluginBPLibrary.__LerpSkyVolumetricCloudSetting_Internal((Source ?? new FKuroSkyVolumetricCloudSetting()).NativePtr, (Destination ?? new FKuroSkyVolumetricCloudSetting()).NativePtr, Weight, IgnoreOverride), null);
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x0027C1EA File Offset: 0x0027A3EA
		public static void KuroMarkPackageDirty(UObject Object)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__KuroMarkPackageDirty_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF20 RID: 110368 RVA: 0x0027C204 File Offset: 0x0027A404
		public static FVector2D KuroBuoyancyCalculation(UStaticMeshComponent MeshComponent, in TArray<FVector4> SphereList, float WaterHeight, FVector? BuoyancyMagnitude = null)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__KuroBuoyancyCalculation_Internal((MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero, (SphereList ?? new TArray<FVector4>()).NativePtr, WaterHeight, BuoyancyMagnitude ?? new FVector(0f, 0f, 1f));
		}

		// Token: 0x0601AF21 RID: 110369 RVA: 0x0027C25F File Offset: 0x0027A45F
		public static bool IsWpPlayerInCaveOrRoom(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWpPlayerInCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF22 RID: 110370 RVA: 0x0027C276 File Offset: 0x0027A476
		public static bool IsWorldPartitionWorld(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldPartitionWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF23 RID: 110371 RVA: 0x0027C28D File Offset: 0x0027A48D
		public static bool IsWorldPartitionDataLayerEnable(UObject WorldContextObject, FName DataLayerName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldPartitionDataLayerEnable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName);
		}

		// Token: 0x0601AF24 RID: 110372 RVA: 0x0027C2A5 File Offset: 0x0027A4A5
		public static bool IsWorldOriginVisibilityRequestPending(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldOriginVisibilityRequestPending_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF25 RID: 110373 RVA: 0x0027C2BC File Offset: 0x0027A4BC
		public static bool IsWorldOriginFinish(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldOriginFinish_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF26 RID: 110374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUsingParallaxCorrect();

		// Token: 0x0601AF27 RID: 110375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUsingNotSeparateCache();

		// Token: 0x0601AF28 RID: 110376 RVA: 0x0027C2D3 File Offset: 0x0027A4D3
		public static bool IsUseVirtualTexturing(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsUseVirtualTexturing_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF29 RID: 110377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupportsMetalFx();

		// Token: 0x0601AF2A RID: 110378 RVA: 0x0027C2EA File Offset: 0x0027A4EA
		public static bool IsStreamingSourceInSide(UObject WorldContextObject, EStreamingSourcePriority StreamingSourcePriority, in FVector Origin, in FVector Extent)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsStreamingSourceInSide_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, StreamingSourcePriority, Origin, Extent);
		}

		// Token: 0x0601AF2B RID: 110379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSSDDevice();

		// Token: 0x0601AF2C RID: 110380 RVA: 0x0027C304 File Offset: 0x0027A504
		public static bool IsPostprocessMaterialActive(UObject WorldContextObject, int Handle)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsPostprocessMaterialActive_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Handle);
		}

		// Token: 0x0601AF2D RID: 110381 RVA: 0x0027C31C File Offset: 0x0027A51C
		public static bool IsPositionInCaveOrRoom(UObject WorldContextObject, in FVector InPoisition)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsPositionInCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InPoisition);
		}

		// Token: 0x0601AF2E RID: 110382 RVA: 0x0027C334 File Offset: 0x0027A534
		public static bool IsParticleComplete(UParticleSystemComponent ParticleSystemComponent)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsParticleComplete_Internal((ParticleSystemComponent != null) ? ParticleSystemComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF2F RID: 110383 RVA: 0x0027C34B File Offset: 0x0027A54B
		public static bool IsNiagaraComplete(UNiagaraComponent NiagaraComponent)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsNiagaraComplete_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF30 RID: 110384 RVA: 0x0027C362 File Offset: 0x0027A562
		public static bool IsEditorOnlyActor(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsEditorOnlyActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF31 RID: 110385 RVA: 0x0027C379 File Offset: 0x0027A579
		public static bool IsDistanceCull(UObject WorldContextObject, UNiagaraEffectType EffectType, in FVector Location)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsDistanceCull_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (EffectType != null) ? EffectType.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x0601AF32 RID: 110386 RVA: 0x0027C3A1 File Offset: 0x0027A5A1
		public static bool IsCurrentPlatformPC(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsCurrentPlatformPC_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF33 RID: 110387
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSP2RGB(FLinearColor hsp);

		// Token: 0x0601AF34 RID: 110388 RVA: 0x0027C3B8 File Offset: 0x0027A5B8
		[NullableContext(1)]
		public unsafe static bool HasKey([Nullable(2)] UObject WorldContextObject, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__HasKey_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF35 RID: 110389 RVA: 0x0027C3EC File Offset: 0x0027A5EC
		public static void HasAnyObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__HasAnyObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x0601AF36 RID: 110390 RVA: 0x0027C404 File Offset: 0x0027A604
		public static void HasAllObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__HasAllObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x0601AF37 RID: 110391 RVA: 0x0027C41C File Offset: 0x0027A61C
		public unsafe static void GetWpWorldBound(UObject WorldContextObject, ref FVector BoundMin, ref FVector BoundMax)
		{
			fixed (FVector* ptr = &BoundMin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoundMax)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__GetWpWorldBound_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref BoundMin, ref BoundMax);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AF38 RID: 110392 RVA: 0x0027C450 File Offset: 0x0027A650
		public static BP_EWorldType GetWorldType(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF39 RID: 110393 RVA: 0x0027C467 File Offset: 0x0027A667
		public static AWorldSettings GetWorldSetting(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AWorldSettings>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldSetting_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF3A RID: 110394 RVA: 0x0027C483 File Offset: 0x0027A683
		public static FVector GetWorldRebaseRelativePos(UObject WorldContextObject, in FVector InCurPos)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldRebaseRelativePos_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InCurPos);
		}

		// Token: 0x0601AF3B RID: 110395 RVA: 0x0027C49B File Offset: 0x0027A69B
		public static FVector GetWorldRebaseAbsoluePos(UObject WorldContextObject, in FVector InCurPos)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldRebaseAbsoluePos_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InCurPos);
		}

		// Token: 0x0601AF3C RID: 110396 RVA: 0x0027C4B3 File Offset: 0x0027A6B3
		[NullableContext(1)]
		public static TArray<string> GetWorldPartitionAllDataLayerNames([Nullable(2)] UObject WorldContextObject)
		{
			return new TArray<string>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldPartitionAllDataLayerNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601AF3D RID: 110397 RVA: 0x0027C4D0 File Offset: 0x0027A6D0
		public static UWorldPartition GetWorldPartition(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldPartition>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldPartition_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF3E RID: 110398 RVA: 0x0027C4EC File Offset: 0x0027A6EC
		public static KuroFeatureLevel GetWorldFeatureLevel(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldFeatureLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF3F RID: 110399 RVA: 0x0027C503 File Offset: 0x0027A703
		public static UWorld GetWorld(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF40 RID: 110400 RVA: 0x0027C51F File Offset: 0x0027A71F
		[NullableContext(1)]
		public static string GetWindowsVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWindowsVersion_Internal());
		}

		// Token: 0x0601AF41 RID: 110401 RVA: 0x0027C52B File Offset: 0x0027A72B
		public static UObject GetWeatherDataRef(UObject WorldContextObject, FName Identifier)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWeatherDataRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Identifier));
		}

		// Token: 0x0601AF42 RID: 110402
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVoltage();

		// Token: 0x0601AF43 RID: 110403 RVA: 0x0027C548 File Offset: 0x0027A748
		public unsafe static void GetViewportSizeInLink(UObject WorldContextObject, ref FVector2D ViewportSize)
		{
			fixed (FVector2D* ptr = &ViewportSize)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetViewportSizeInLink_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref ViewportSize);
			}
		}

		// Token: 0x0601AF44 RID: 110404 RVA: 0x0027C574 File Offset: 0x0027A774
		public unsafe static void GetVectorParameterValueRefRGBA(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, ref float RefLinearColorR, ref float RefLinearColorG, ref float RefLinearColorB, ref float RefLinearColorA)
		{
			fixed (float* ptr = &RefLinearColorR)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &RefLinearColorG)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &RefLinearColorB)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &RefLinearColorA)
						{
							void* ptr8 = (void*)ptr7;
							UKuroRenderingRuntimeBPPluginBPLibrary.__GetVectorParameterValueRefRGBA_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ref RefLinearColorR, ref RefLinearColorG, ref RefLinearColorB, ref RefLinearColorA);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601AF45 RID: 110405 RVA: 0x0027C5E0 File Offset: 0x0027A7E0
		public unsafe static void GetVectorParameterValueRef(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, ref FLinearColor RefLinearColor)
		{
			fixed (FLinearColor* ptr = &RefLinearColor)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetVectorParameterValueRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ref RefLinearColor);
			}
		}

		// Token: 0x0601AF46 RID: 110406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetSwapBufferTime();

		// Token: 0x0601AF47 RID: 110407 RVA: 0x0027C61C File Offset: 0x0027A81C
		[NullableContext(1)]
		public static TArray<int> GetSupportedRefreshRates()
		{
			return new TArray<int>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSupportedRefreshRates_Internal(), null);
		}

		// Token: 0x0601AF48 RID: 110408 RVA: 0x0027C629 File Offset: 0x0027A829
		public static UWorldSubsystem GetSubsystem(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UWorldSubsystem> WorldSubsystemClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldSubsystem>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSubsystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldSubsystemClass._NativePtr));
		}

		// Token: 0x0601AF49 RID: 110409 RVA: 0x0027C64C File Offset: 0x0027A84C
		[NullableContext(1)]
		public unsafe static string GetString([Nullable(2)] UObject WorldContextObject, string Key, string DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(DefaultValue);
			string result = FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601AF4A RID: 110410 RVA: 0x0027C698 File Offset: 0x0027A898
		[NullableContext(1)]
		public unsafe static bool GetStatGPUTimings([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroStatGPUTiming> OutTimings, ref string OutFailureReason)
		{
			FString fstring = FString.AllocTemp(OutFailureReason);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetStatGPUTimings_Internal((OutTimings ?? new TArray<FKuroStatGPUTiming>()).NativePtr, ref fstring);
			OutFailureReason = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF4B RID: 110411 RVA: 0x0027C6D8 File Offset: 0x0027A8D8
		[NullableContext(1)]
		public unsafe static bool GetSpaceStateByPosition([Nullable(2)] UObject WorldContextObject, in FVector InPoisition, ref ECaveOrRoom OutSpaceType, ref string OutEnClosetDataLayer, ref string OutEnCloseSubDataLayer)
		{
			FString fstring = FString.AllocTemp(OutEnClosetDataLayer);
			FString fstring2 = FString.AllocTemp(OutEnCloseSubDataLayer);
			fixed (ECaveOrRoom* ptr = &OutSpaceType)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetSpaceStateByPosition_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InPoisition, ref OutSpaceType, ref fstring, ref fstring2);
				OutEnClosetDataLayer = FString.ToString(fstring);
				FString.NativeDestruct(&fstring, 1);
				OutEnCloseSubDataLayer = FString.ToString(fstring2);
				FString.NativeDestruct(&fstring2, 1);
				return result;
			}
		}

		// Token: 0x0601AF4C RID: 110412 RVA: 0x0027C73B File Offset: 0x0027A93B
		[NullableContext(1)]
		public static string GetSkeletalMaterialSlotName([Nullable(2)] USkeletalMesh Skel, int MaterialIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialSlotName_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero, MaterialIndex));
		}

		// Token: 0x0601AF4D RID: 110413 RVA: 0x0027C758 File Offset: 0x0027A958
		public static UMaterialInterface GetSkeletalMaterialInterface(USkeletalMesh Skel, int MaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialInterface_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero, MaterialIndex));
		}

		// Token: 0x0601AF4E RID: 110414 RVA: 0x0027C775 File Offset: 0x0027A975
		public static int GetSkeletalMaterialCount(USkeletalMesh Skel)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialCount_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF4F RID: 110415 RVA: 0x0027C78C File Offset: 0x0027A98C
		public static AActor GetSceneInteractionLevelActor(ULevel InLevel)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSceneInteractionLevelActor_Internal((InLevel != null) ? InLevel.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF50 RID: 110416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneDepthShotNow();

		// Token: 0x0601AF51 RID: 110417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorShotNow();

		// Token: 0x0601AF52 RID: 110418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorShotBeforeTonemap(bool bRelease = false);

		// Token: 0x0601AF53 RID: 110419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorContainLGUIShotNow();

		// Token: 0x0601AF54 RID: 110420 RVA: 0x0027C7A8 File Offset: 0x0027A9A8
		[NullableContext(1)]
		public static string GetRHIVendorName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIVendorName_Internal());
		}

		// Token: 0x0601AF55 RID: 110421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRHIThreadTime();

		// Token: 0x0601AF56 RID: 110422 RVA: 0x0027C7B4 File Offset: 0x0027A9B4
		[NullableContext(1)]
		public static string GetRHIName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIName_Internal());
		}

		// Token: 0x0601AF57 RID: 110423 RVA: 0x0027C7C0 File Offset: 0x0027A9C0
		[NullableContext(1)]
		public static string GetRHIDriverVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDriverVersion_Internal());
		}

		// Token: 0x0601AF58 RID: 110424 RVA: 0x0027C7CC File Offset: 0x0027A9CC
		[NullableContext(1)]
		public static string GetRHIDriverDate()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDriverDate_Internal());
		}

		// Token: 0x0601AF59 RID: 110425 RVA: 0x0027C7D8 File Offset: 0x0027A9D8
		[NullableContext(1)]
		public static string GetRHIDeviceName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDeviceName_Internal());
		}

		// Token: 0x0601AF5A RID: 110426 RVA: 0x0027C7E4 File Offset: 0x0027A9E4
		[NullableContext(1)]
		public static string GetRHIAPIVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIAPIVersion_Internal());
		}

		// Token: 0x0601AF5B RID: 110427
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderThreadTime();

		// Token: 0x0601AF5C RID: 110428
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern URayTracingSupport GetRayTracingSupportedType();

		// Token: 0x0601AF5D RID: 110429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingSupported();

		// Token: 0x0601AF5E RID: 110430
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingShadowsSupported();

		// Token: 0x0601AF5F RID: 110431
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingShadowsEnable();

		// Token: 0x0601AF60 RID: 110432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingReflectionsSupported();

		// Token: 0x0601AF61 RID: 110433
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingReflectionsEnable();

		// Token: 0x0601AF62 RID: 110434
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingEnable();

		// Token: 0x0601AF63 RID: 110435
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetRandomPointInAnnulus2D(FVector2D InnerOuterRadius, int RandomSeed = 0);

		// Token: 0x0601AF64 RID: 110436 RVA: 0x0027C7F0 File Offset: 0x0027A9F0
		public static bool GetPostProcessGIDataNames(UObject WorldContextObject, FVector WorldPosition, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutDANames)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetPostProcessGIDataNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, (OutDANames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0601AF65 RID: 110437 RVA: 0x0027C818 File Offset: 0x0027AA18
		public static bool GetPostProcessGIDataDebugNames(UObject WorldContextObject, ref TArray<FName> OutDANames)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetPostProcessGIDataDebugNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutDANames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x0027C83F File Offset: 0x0027AA3F
		public static bool GetPostProcessGIDataDebugInfo(UObject WorldContextObject, FVector WorldPosition, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPostprocessGIDebugInfo> OutDAResult, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPostprocessGIDebugInfo> OutOverrideResult)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetPostProcessGIDataDebugInfo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, (OutDAResult ?? new TArray<FPostprocessGIDebugInfo>()).NativePtr, (OutOverrideResult ?? new TArray<FPostprocessGIDebugInfo>()).NativePtr);
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x0027C878 File Offset: 0x0027AA78
		public unsafe static bool GetPlayerOrEditorCameraTransform(UObject WorldContextObject, ref FTransform OutCameraTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutCameraTransform;
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetPlayerOrEditorCameraTransform_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref ptr);
			OutCameraTransform = ptr;
			return result;
		}

		// Token: 0x0601AF68 RID: 110440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPhysicalGBRam();

		// Token: 0x0601AF69 RID: 110441 RVA: 0x0027C8C4 File Offset: 0x0027AAC4
		public unsafe static void GetPcLightCullParameters(ULightComponent LightComponent, ref float LightMinDistance, ref float LightMaxDistance, ref float LightMinFade, ref float LightMaxFade)
		{
			fixed (float* ptr = &LightMinDistance)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LightMaxDistance)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &LightMinFade)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &LightMaxFade)
						{
							void* ptr8 = (void*)ptr7;
							UKuroRenderingRuntimeBPPluginBPLibrary.__GetPcLightCullParameters_Internal((LightComponent != null) ? LightComponent.NativePtr : IntPtr.Zero, ref LightMinDistance, ref LightMaxDistance, ref LightMinFade, ref LightMaxFade);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601AF6A RID: 110442 RVA: 0x0027C918 File Offset: 0x0027AB18
		public static int GetOverlappingBoxCountForAllFoliageActors(UObject WorldContextObject, UFoliageType FoliageType, in FBox Box, int Max)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetOverlappingBoxCountForAllFoliageActors_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FoliageType != null) ? FoliageType.NativePtr : IntPtr.Zero, Box, Max);
		}

		// Token: 0x0601AF6B RID: 110443 RVA: 0x0027C941 File Offset: 0x0027AB41
		public static int GetObjectMaskedFlags(UObject Object, int Mask)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetObjectMaskedFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, Mask);
		}

		// Token: 0x0601AF6C RID: 110444 RVA: 0x0027C959 File Offset: 0x0027AB59
		public static int GetObjectFilterStateID(UObject Object, int ExtraID = 0)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetObjectFilterStateID_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, ExtraID);
		}

		// Token: 0x0601AF6D RID: 110445 RVA: 0x0027C974 File Offset: 0x0027AB74
		public unsafe static void GetNiagaraParticleCount(UNiagaraComponent NiagaraComponent, ref int ActiveEmitters, ref int ActiveParticles)
		{
			fixed (int* ptr = &ActiveEmitters)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &ActiveParticles)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__GetNiagaraParticleCount_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, ref ActiveEmitters, ref ActiveParticles);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AF6E RID: 110446 RVA: 0x0027C9A8 File Offset: 0x0027ABA8
		[NullableContext(1)]
		public static string GetMobileDeviceModel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetMobileDeviceModel_Internal());
		}

		// Token: 0x0601AF6F RID: 110447 RVA: 0x0027C9B4 File Offset: 0x0027ABB4
		[NullableContext(1)]
		public static string GetMobileDeviceMake()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetMobileDeviceMake_Internal());
		}

		// Token: 0x0601AF70 RID: 110448
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxFps();

		// Token: 0x0601AF71 RID: 110449
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenReflectionsSupported();

		// Token: 0x0601AF72 RID: 110450
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenReflectionsEnable();

		// Token: 0x0601AF73 RID: 110451
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenGISupported();

		// Token: 0x0601AF74 RID: 110452
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenGIEnable();

		// Token: 0x0601AF75 RID: 110453 RVA: 0x0027C9C0 File Offset: 0x0027ABC0
		public static bool GetLumenDiffuseGIFeatureEnabled(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetLumenDiffuseGIFeatureEnabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF76 RID: 110454 RVA: 0x0027C9D8 File Offset: 0x0027ABD8
		public unsafe static bool GetLevelEditorViewPortSize(UObject WorldContextObject, ref FVector2D viewPortSize)
		{
			fixed (FVector2D* ptr = &viewPortSize)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevelEditorViewPortSize_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref viewPortSize);
			}
		}

		// Token: 0x0601AF77 RID: 110455 RVA: 0x0027CA00 File Offset: 0x0027AC00
		public unsafe static bool GetLevelEditorCameraLocationAndForward(UObject WorldContextObject, ref FVector Position, ref FRotator Rotation)
		{
			fixed (FVector* ptr = &Position)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Rotation)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevelEditorCameraLocationAndForward_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref Position, ref Rotation);
				}
			}
		}

		// Token: 0x0601AF78 RID: 110456 RVA: 0x0027CA2E File Offset: 0x0027AC2E
		[NullableContext(1)]
		public static TArray<AActor> GetLevelActors([Nullable(2)] ULevel InLevel)
		{
			return new TArray<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevelActors_Internal((InLevel != null) ? InLevel.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601AF79 RID: 110457 RVA: 0x0027CA4B File Offset: 0x0027AC4B
		public static ULevel GetLevel(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevel_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF7A RID: 110458 RVA: 0x0027CA67 File Offset: 0x0027AC67
		public static UKuroLandscapeParametersData GetKuroLandscapeParametersDataAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroLandscapeParametersData>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetKuroLandscapeParametersDataAsset_Internal());
		}

		// Token: 0x0601AF7B RID: 110459 RVA: 0x0027CA74 File Offset: 0x0027AC74
		[NullableContext(1)]
		public unsafe static int GetInt([Nullable(2)] UObject WorldContextObject, string Key, int DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			int result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetInt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF7C RID: 110460 RVA: 0x0027CAA9 File Offset: 0x0027ACA9
		public static AActor GetGlobalGIActor(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGlobalGIActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF7D RID: 110461 RVA: 0x0027CAC5 File Offset: 0x0027ACC5
		public static UPhysicalMaterial GetGlobalFootstepMaterial(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGlobalFootstepMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF7E RID: 110462 RVA: 0x0027CAE1 File Offset: 0x0027ACE1
		public static AActor GetGITransientActor(UObject WorldContextObject, FName IdName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName));
		}

		// Token: 0x0601AF7F RID: 110463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetGameViewportSize();

		// Token: 0x0601AF80 RID: 110464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameThreadTime();

		// Token: 0x0601AF81 RID: 110465
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetGameResolution();

		// Token: 0x0601AF82 RID: 110466 RVA: 0x0027CAFE File Offset: 0x0027ACFE
		public static float GetFloatGromGroup(ref FKuroCharMaterialControllerFloatGroup Target, float Factor, int Type)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetFloatGromGroup_Internal((Target ?? new FKuroCharMaterialControllerFloatGroup()).NativePtr, Factor, Type);
		}

		// Token: 0x0601AF83 RID: 110467 RVA: 0x0027CB18 File Offset: 0x0027AD18
		[NullableContext(1)]
		public unsafe static float GetFloat([Nullable(2)] UObject WorldContextObject, string Key, float DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			float result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetFloat_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF84 RID: 110468 RVA: 0x0027CB4D File Offset: 0x0027AD4D
		public static UEngineSubsystem GetEngineSubsystem([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEngineSubsystem> EngineSubsystem)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEngineSubsystem>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetEngineSubsystem_Internal(EngineSubsystem._NativePtr));
		}

		// Token: 0x0601AF85 RID: 110469
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetDriverValid();

		// Token: 0x0601AF86 RID: 110470 RVA: 0x0027CB5F File Offset: 0x0027AD5F
		public static bool GetDisableNPCOptAsRayTracing(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetDisableNPCOptAsRayTracing_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x0027CB76 File Offset: 0x0027AD76
		[NullableContext(1)]
		public static string GetDeviceProfileProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileProfileName_Internal());
		}

		// Token: 0x0601AF88 RID: 110472 RVA: 0x0027CB82 File Offset: 0x0027AD82
		[NullableContext(1)]
		public static string GetDeviceProfileDeviceType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileDeviceType_Internal());
		}

		// Token: 0x0601AF89 RID: 110473
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDeviceProfileDeviceScore();

		// Token: 0x0601AF8A RID: 110474 RVA: 0x0027CB8E File Offset: 0x0027AD8E
		[NullableContext(1)]
		public static string GetDeviceProfileBaseProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileBaseProfileName_Internal());
		}

		// Token: 0x0601AF8B RID: 110475
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDeviceHardwareLevel();

		// Token: 0x0601AF8C RID: 110476 RVA: 0x0027CB9C File Offset: 0x0027AD9C
		[NullableContext(1)]
		public unsafe static string GetCVarString(string CVarKey)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			string result = FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCVarString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF8D RID: 110477 RVA: 0x0027CBC8 File Offset: 0x0027ADC8
		[NullableContext(1)]
		public unsafe static float GetCVarFloat(string CVarKey)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			float result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetCVarFloat_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601AF8E RID: 110478
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentNow();

		// Token: 0x0601AF8F RID: 110479
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuUsage();

		// Token: 0x0601AF90 RID: 110480
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuTemperature();

		// Token: 0x0601AF91 RID: 110481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUFrequency();

		// Token: 0x0601AF92 RID: 110482
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuFreq(int core);

		// Token: 0x0601AF93 RID: 110483
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUCoresIncludingHyperthreads();

		// Token: 0x0601AF94 RID: 110484
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUCores();

		// Token: 0x0601AF95 RID: 110485 RVA: 0x0027CBEC File Offset: 0x0027ADEC
		[NullableContext(1)]
		public static string GetCPUBrand()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCPUBrand_Internal());
		}

		// Token: 0x0601AF96 RID: 110486 RVA: 0x0027CBF8 File Offset: 0x0027ADF8
		public static FTransform GetComponentToWorldNoWorldOffset(USceneComponent Component)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentToWorldNoWorldOffset_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF97 RID: 110487 RVA: 0x0027CC0F File Offset: 0x0027AE0F
		public static UPhysicalMaterial GetComponentPhysicalMaterial(UPrimitiveComponent Component)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentPhysicalMaterial_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AF98 RID: 110488 RVA: 0x0027CC2B File Offset: 0x0027AE2B
		public static FVector GetComponentLocationNoWorldOffset(USceneComponent Component)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentLocationNoWorldOffset_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF99 RID: 110489 RVA: 0x0027CC42 File Offset: 0x0027AE42
		public static FLinearColor GetColorFromGroup(ref FKuroCharMaterialControllerColorGroup Target, float Factor, int Type)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetColorFromGroup_Internal((Target ?? new FKuroCharMaterialControllerColorGroup()).NativePtr, Factor, Type);
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x0027CC5B File Offset: 0x0027AE5B
		public static int GetCharacterSectionMaterialIndex(USkeletalMesh SkeletalMesh, int SectionIndex)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionMaterialIndex_Internal((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero, SectionIndex);
		}

		// Token: 0x0601AF9B RID: 110491 RVA: 0x0027CC73 File Offset: 0x0027AE73
		[NullableContext(1)]
		public static TArray<int> GetCharacterSectionInfo([Nullable(2)] USkeletalMesh Mesh, int SectionIndex)
		{
			return new TArray<int>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionInfo_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, SectionIndex), null);
		}

		// Token: 0x0601AF9C RID: 110492 RVA: 0x0027CC91 File Offset: 0x0027AE91
		public static int GetCharacterSectionCount(USkeletalMesh Mesh)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionCount_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF9D RID: 110493 RVA: 0x0027CCA8 File Offset: 0x0027AEA8
		public static bool GetCharacterInBattle(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterInBattle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AF9E RID: 110494 RVA: 0x0027CCC0 File Offset: 0x0027AEC0
		[NullableContext(1)]
		public unsafe static bool GetCaveOrRoomState([Nullable(2)] UObject WorldContextObject, ref string EnClosetDataLayer, ref string EnCloseSubDataLayer, ref ECaveOrRoomLoadType OutLoadType, ref float OutLoadCoef)
		{
			FString fstring = FString.AllocTemp(EnClosetDataLayer);
			FString fstring2 = FString.AllocTemp(EnCloseSubDataLayer);
			fixed (ECaveOrRoomLoadType* ptr = &OutLoadType)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutLoadCoef)
				{
					void* ptr4 = (void*)ptr3;
					bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetCaveOrRoomState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref fstring, ref fstring2, ref OutLoadType, ref OutLoadCoef);
					EnClosetDataLayer = FString.ToString(fstring);
					FString.NativeDestruct(&fstring, 1);
					EnCloseSubDataLayer = FString.ToString(fstring2);
					FString.NativeDestruct(&fstring2, 1);
					return result;
				}
			}
		}

		// Token: 0x0601AF9F RID: 110495 RVA: 0x0027CD2C File Offset: 0x0027AF2C
		public static void GetCacheCameraInfo(APlayerCameraManager Owner, ref FMinimalViewInfo Inout)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__GetCacheCameraInfo_Internal((Owner != null) ? Owner.NativePtr : IntPtr.Zero, (Inout ?? new FMinimalViewInfo()).NativePtr);
		}

		// Token: 0x0601AFA0 RID: 110496 RVA: 0x0027CD53 File Offset: 0x0027AF53
		public static FQuat GetBoneDirection(USkeletalMeshComponent SkeletalMeshComponent, FName BoneName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetBoneDirection_Internal((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, BoneName);
		}

		// Token: 0x0601AFA1 RID: 110497
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetBatteryTemperature();

		// Token: 0x0601AFA2 RID: 110498 RVA: 0x0027CD6B File Offset: 0x0027AF6B
		[NullableContext(1)]
		public static TArray<FAssetData> GetAssetsByPath(FName PackagePath, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
		{
			return new TArray<FAssetData>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetAssetsByPath_Internal(PackagePath, bRecursive, bIncludeOnlyOnDiskAssets), null);
		}

		// Token: 0x0601AFA3 RID: 110499
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetAndroidRawResolution();

		// Token: 0x0601AFA4 RID: 110500 RVA: 0x0027CD7C File Offset: 0x0027AF7C
		public unsafe static float GetAndAddCurveFloatSampleTask(UObject WorldContextObject, long LastFrameHandle, in FKuroCurveFloat Curve, float Time, float Default, ref long OutHandle)
		{
			fixed (long* ptr = &OutHandle)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__GetAndAddCurveFloatSampleTask_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LastFrameHandle, (Curve ?? new FKuroCurveFloat()).NativePtr, Time, Default, ref OutHandle);
			}
		}

		// Token: 0x0601AFA5 RID: 110501 RVA: 0x0027CDBA File Offset: 0x0027AFBA
		[NullableContext(1)]
		public static string GetAdapterUserDriverVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetAdapterUserDriverVersion_Internal());
		}

		// Token: 0x0601AFA6 RID: 110502 RVA: 0x0027CDC6 File Offset: 0x0027AFC6
		public static FTransform GetActorTransformNoWorldOffset(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorTransformNoWorldOffset_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFA7 RID: 110503 RVA: 0x0027CDDD File Offset: 0x0027AFDD
		public static void GetActorsInLevel(ULevel InLevel, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorsInLevel_Internal((InLevel != null) ? InLevel.NativePtr : IntPtr.Zero, ActorClass._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0601AFA8 RID: 110504 RVA: 0x0027CE0A File Offset: 0x0027B00A
		public static AActor GetActorOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr));
		}

		// Token: 0x0601AFA9 RID: 110505 RVA: 0x0027CE2C File Offset: 0x0027B02C
		public unsafe static void GetActorLocationRefXYZ(AActor Actor, ref float X, ref float Y, ref float Z)
		{
			fixed (float* ptr = &X)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Z)
					{
						void* ptr6 = (void*)ptr5;
						UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorLocationRefXYZ_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref X, ref Y, ref Z);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0601AFAA RID: 110506 RVA: 0x0027CE70 File Offset: 0x0027B070
		public unsafe static void GetActorLocationRef(AActor Actor, ref FVector RefLocation)
		{
			fixed (FVector* ptr = &RefLocation)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorLocationRef_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref RefLocation);
			}
		}

		// Token: 0x0601AFAB RID: 110507 RVA: 0x0027CE9B File Offset: 0x0027B09B
		public static FVector GetActorLocationNoWorldOffset(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorLocationNoWorldOffset_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFAC RID: 110508 RVA: 0x0027CEB4 File Offset: 0x0027B0B4
		public unsafe static void GetActorForwardVectorRefXYZ(AActor Actor, ref float X, ref float Y, ref float Z)
		{
			fixed (float* ptr = &X)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Z)
					{
						void* ptr6 = (void*)ptr5;
						UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorForwardVectorRefXYZ_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref X, ref Y, ref Z);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0601AFAD RID: 110509 RVA: 0x0027CEF8 File Offset: 0x0027B0F8
		public unsafe static void GetActorForwardVectorRef(AActor Actor, ref FVector RefForwardVector)
		{
			fixed (FVector* ptr = &RefForwardVector)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorForwardVectorRef_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref RefForwardVector);
			}
		}

		// Token: 0x0601AFAE RID: 110510
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double FS_PointToIndex_Local_Double(in FVector OriginLocal, in FVector PointLocal, int N);

		// Token: 0x0601AFAF RID: 110511
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FS_PointToIndex_Local(in FVector OriginLocal, in FVector PointLocal, int N);

		// Token: 0x0601AFB0 RID: 110512
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FS_IsPointInTriangle_ZProjection(in FVector P, in FVector A, in FVector B, in FVector C, ref float OutDistance, float Epsilon = 1E-06f);

		// Token: 0x0601AFB1 RID: 110513
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FS_IsPointInTriangle(in FVector2D P, in FVector2D A, in FVector2D B, in FVector2D C);

		// Token: 0x0601AFB2 RID: 110514
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FS_IndexToAngle(int Index, int N);

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x0027CF24 File Offset: 0x0027B124
		public unsafe static bool FS_GetSegmentIntersection(in FVector2D RayStart, in FVector2D RayEnd, in FFS_Segment2D Seg, ref FVector2D OutPoint, ref float OutParamT)
		{
			fixed (FVector2D* ptr = &OutPoint)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutParamT)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_GetSegmentIntersection_Internal(RayStart, RayEnd, (Seg ?? new FFS_Segment2D()).NativePtr, ref OutPoint, ref OutParamT);
				}
			}
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x0027CF58 File Offset: 0x0027B158
		public unsafe static bool FS_GetCircleTangentPoints2(in FVector2D P, in FFS_Circle2D Circle, ref FVector2D OutTangent1, ref FVector2D OutTangent2, float Epsilon)
		{
			fixed (FVector2D* ptr = &OutTangent1)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector2D* ptr3 = &OutTangent2)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_GetCircleTangentPoints2_Internal(P, (Circle ?? new FFS_Circle2D()).NativePtr, ref OutTangent1, ref OutTangent2, Epsilon);
				}
			}
		}

		// Token: 0x0601AFB5 RID: 110517 RVA: 0x0027CF8C File Offset: 0x0027B18C
		public unsafe static bool FS_GetCircleTangentPoints(in FVector2D P, in FFS_Circle2D Circle, ref FVector2D OutTangent1, ref FVector2D OutTangent2)
		{
			fixed (FVector2D* ptr = &OutTangent1)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector2D* ptr3 = &OutTangent2)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_GetCircleTangentPoints_Internal(P, (Circle ?? new FFS_Circle2D()).NativePtr, ref OutTangent1, ref OutTangent2);
				}
			}
		}

		// Token: 0x0601AFB6 RID: 110518 RVA: 0x0027CFBC File Offset: 0x0027B1BC
		public unsafe static bool FS_GetCircleIntersection(in FVector2D RayStart, in FVector2D RayEnd, in FFS_Circle2D Circle, ref FVector2D OutPoint, ref float OutParamT)
		{
			fixed (FVector2D* ptr = &OutPoint)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutParamT)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_GetCircleIntersection_Internal(RayStart, RayEnd, (Circle ?? new FFS_Circle2D()).NativePtr, ref OutPoint, ref OutParamT);
				}
			}
		}

		// Token: 0x0601AFB7 RID: 110519 RVA: 0x0027CFF0 File Offset: 0x0027B1F0
		public unsafe static bool FS_DetectPlayer_Two(double Index, int ParticleCount, in TArray<float> Dis, in TArray<FVector> Dirs, in FVector PlayerPos, in FVector WorldPos, in FRotator Rotator, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_DetectPlayer_Two_Internal(Index, ParticleCount, (Dis ?? new TArray<float>()).NativePtr, (Dirs ?? new TArray<FVector>()).NativePtr, PlayerPos, WorldPos, Rotator, ref OutDistance);
			}
		}

		// Token: 0x0601AFB8 RID: 110520 RVA: 0x0027D034 File Offset: 0x0027B234
		public unsafe static bool FS_DetectPlayer(int Index, int ParticleCount, in TArray<FVector> EndPos, in FVector PlayerPos, in FVector WorldPos, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_DetectPlayer_Internal(Index, ParticleCount, (EndPos ?? new TArray<FVector>()).NativePtr, PlayerPos, WorldPos, ref OutDistance);
			}
		}

		// Token: 0x0601AFB9 RID: 110521 RVA: 0x0027D064 File Offset: 0x0027B264
		public static bool FS_ComputeVisibilityDebugPoints_Batch(FVector2D Origin, FVector2D PlayerPos, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Circle2D> FS_Circles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Segment2D> FS_Segments, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FFS_AngleHit> OutHits, ref TArray<FVector2D> OutHitsReal, float RayLength = 10000f, float AngleOffset = 0.0001f, float AngleOffset2 = 0.0001f, bool bUseInputCircles = true, bool bUseInputSegments = true, bool bDoParallel = false, int StartIndex = 0, int UpdateCount = 10)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_ComputeVisibilityDebugPoints_Batch_Internal(Origin, PlayerPos, (FS_Circles ?? new TArray<FFS_Circle2D>()).NativePtr, (FS_Segments ?? new TArray<FFS_Segment2D>()).NativePtr, (OutHits ?? new TArray<FFS_AngleHit>()).NativePtr, (OutHitsReal ?? new TArray<FVector2D>()).NativePtr, RayLength, AngleOffset, AngleOffset2, bUseInputCircles, bUseInputSegments, bDoParallel, StartIndex, UpdateCount);
		}

		// Token: 0x0601AFBA RID: 110522 RVA: 0x0027D0CC File Offset: 0x0027B2CC
		public static bool FS_ComputeVisibilityDebugPoints(FVector2D Origin, FVector2D PlayerPos, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Circle2D> Circles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Segment2D> Segments, ref TArray<FVector2D> OutHits, float RayLength = 10000f, float AngleOffset = 0.0001f, bool bUseInputCircles = true, bool bUseInputSegments = true, bool bDoParallel = false)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_ComputeVisibilityDebugPoints_Internal(Origin, PlayerPos, (Circles ?? new TArray<FFS_Circle2D>()).NativePtr, (Segments ?? new TArray<FFS_Segment2D>()).NativePtr, (OutHits ?? new TArray<FVector2D>()).NativePtr, RayLength, AngleOffset, bUseInputCircles, bUseInputSegments, bDoParallel);
		}

		// Token: 0x0601AFBB RID: 110523 RVA: 0x0027D11C File Offset: 0x0027B31C
		public unsafe static FRotator FS_ComputeTilt_ByHeightH2(ref FVectorDouble LastFrameNormal, in FTransform PlaneTransform, float RayCastingDetectRange, in FVector PlayerPos, double MaxDegreeAngle, float MinActiveRadius, float MaxActiveRadius, double FollowSpeedRate, double ReturnSpeedRate, bool bPlayerColliding, bool bNeedReturnOrNot, bool bLinear)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = PlaneTransform;
			fixed (FVectorDouble* ptr2 = &LastFrameNormal)
			{
				void* ptr3 = (void*)ptr2;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_ComputeTilt_ByHeightH2_Internal(ref LastFrameNormal, ptr, RayCastingDetectRange, PlayerPos, MaxDegreeAngle, MinActiveRadius, MaxActiveRadius, FollowSpeedRate, ReturnSpeedRate, bPlayerColliding, bNeedReturnOrNot, bLinear);
			}
		}

		// Token: 0x0601AFBC RID: 110524 RVA: 0x0027D164 File Offset: 0x0027B364
		public unsafe static FRotator FS_ComputeTilt_ByHeightH(in FTransform PlaneTransform, float Radius, in FVector PersonWorld, double H, double MaxDegreeAngle, double MinActiveRadius, double MaxActiveRadius, bool bPlayerColliding, double FollowSpeedDegPerSec, double ReturnSpeedDegPerSec, float DeltaSeconds, bool bNeedReturnOrNot)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = PlaneTransform;
			return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_ComputeTilt_ByHeightH_Internal(uintPtr, Radius, PersonWorld, H, MaxDegreeAngle, MinActiveRadius, MaxActiveRadius, bPlayerColliding, FollowSpeedDegPerSec, ReturnSpeedDegPerSec, DeltaSeconds, bNeedReturnOrNot);
		}

		// Token: 0x0601AFBD RID: 110525 RVA: 0x0027D1A4 File Offset: 0x0027B3A4
		public unsafe static void FS_CheckFrontObstacle2(float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<float> Dis, ref TArray<FName> ParamNames, UMaterialInstanceDynamic MID, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &OutNewCountIndex)
				{
					void* ptr4 = (void*)ptr3;
					UKuroRenderingRuntimeBPPluginBPLibrary.__FS_CheckFrontObstacle2_Internal(RayCastingDetectDis, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TraceChannel, Rotator, WorldPosition, ref OutDistance, (Dir ?? new TArray<FVector>()).NativePtr, (EndPos ?? new TArray<FVector>()).NativePtr, (Dis ?? new TArray<float>()).NativePtr, (ParamNames ?? new TArray<FName>()).NativePtr, (MID != null) ? MID.NativePtr : IntPtr.Zero, debugLine, CountIndex, BatchSize, ParticleCount, ref OutNewCountIndex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr);
					ptr = null;
				}
			}
		}

		// Token: 0x0601AFBE RID: 110526 RVA: 0x0027D258 File Offset: 0x0027B458
		public unsafe static void FS_CheckFrontObstacle(float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<FName> ParamNames, UMaterialInstanceDynamic MID, bool debugLine, int CountIndex)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__FS_CheckFrontObstacle_Internal(RayCastingDetectDis, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TraceChannel, Rotator, WorldPosition, ref OutDistance, (Dir ?? new TArray<FVector>()).NativePtr, (EndPos ?? new TArray<FVector>()).NativePtr, (ParamNames ?? new TArray<FName>()).NativePtr, (MID != null) ? MID.NativePtr : IntPtr.Zero, debugLine, CountIndex);
			}
		}

		// Token: 0x0601AFBF RID: 110527 RVA: 0x0027D2D8 File Offset: 0x0027B4D8
		public static void FS_AppendCandidateAngles(in FVector2D Origin, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Circle2D> InCircles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FFS_Segment2D> InSegments, ref TArray<float> Angles, float AngleOffset = 0.0001f)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__FS_AppendCandidateAngles_Internal(Origin, (InCircles ?? new TArray<FFS_Circle2D>()).NativePtr, (InSegments ?? new TArray<FFS_Segment2D>()).NativePtr, (Angles ?? new TArray<float>()).NativePtr, AngleOffset);
		}

		// Token: 0x0601AFC0 RID: 110528 RVA: 0x0027D312 File Offset: 0x0027B512
		public static void FreezeWorldLevelStreaming(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__FreezeWorldLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFC1 RID: 110529 RVA: 0x0027D32C File Offset: 0x0027B52C
		public unsafe static void FilterWeaponSweepPosition(UObject WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool ValidBool, int FilterStateID = 0, float ValidTimeWindow = 0.1f, float SpeedThreshold = 10f, float AlternatingPointTolerance = 1f, float ReverseDirectionDotThreshold = -0.85f)
		{
			fixed (bool* ptr = &ValidBool)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__FilterWeaponSweepPosition_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HitPos, WeaponTypeID, ref ValidBool, FilterStateID, ValidTimeWindow, SpeedThreshold, AlternatingPointTolerance, ReverseDirectionDotThreshold);
			}
		}

		// Token: 0x0601AFC2 RID: 110530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DoesDeviceSupportVariableRateShading();

		// Token: 0x0601AFC3 RID: 110531 RVA: 0x0027D363 File Offset: 0x0027B563
		public static void DestroyGITransientActor(UObject WorldContextObject, FName IdName)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__DestroyGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName);
		}

		// Token: 0x0601AFC4 RID: 110532 RVA: 0x0027D37C File Offset: 0x0027B57C
		[NullableContext(1)]
		public unsafe static void DeleteKey([Nullable(2)] UObject WorldContextObject, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__DeleteKey_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AFC5 RID: 110533 RVA: 0x0027D3B0 File Offset: 0x0027B5B0
		public static void DeleteAll(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__DeleteAll_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFC6 RID: 110534 RVA: 0x0027D3C8 File Offset: 0x0027B5C8
		public unsafe static AActor D_SpawnActorFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null, bool bTemporaryEditorActor = true)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__D_SpawnActorFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero, bTemporaryEditorActor));
		}

		// Token: 0x0601AFC7 RID: 110535 RVA: 0x0027D439 File Offset: 0x0027B639
		public static AActor CreateGITransientActor(UObject WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera, FName EditorFolderPath)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__CreateGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName, bAttachToPlayer, bAttachToEditorCamera, EditorFolderPath));
		}

		// Token: 0x0601AFC8 RID: 110536 RVA: 0x0027D45C File Offset: 0x0027B65C
		public static void CopyKuroCharLinearColorGroup(ref FKuroCharMaterialControllerColorGroup Target, in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharLinearColorGroup_Internal((Target ?? new FKuroCharMaterialControllerColorGroup()).NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601AFC9 RID: 110537 RVA: 0x0027D4B0 File Offset: 0x0027B6B0
		public unsafe static void CopyKuroCharFloatParameter(ref FKuroCharMaterialControllerFloatParameter Target, in FName ParameterName, in FKuroCurveFloat ParameterValue)
		{
			fixed (FName* ptr = &ParameterName)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharFloatParameter_Internal((Target ?? new FKuroCharMaterialControllerFloatParameter()).NativePtr, ParameterName, (ParameterValue ?? new FKuroCurveFloat()).NativePtr);
			}
		}

		// Token: 0x0601AFCA RID: 110538 RVA: 0x0027D4EC File Offset: 0x0027B6EC
		public static void CopyKuroCharFloatGroupArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCharMaterialControllerFloatGroup> Target, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> Start, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> Loop, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> End)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharFloatGroupArray_Internal((Target ?? new TArray<FKuroCharMaterialControllerFloatGroup>()).NativePtr, (Start ?? new TArray<FKuroCurveFloat>()).NativePtr, (Loop ?? new TArray<FKuroCurveFloat>()).NativePtr, (End ?? new TArray<FKuroCurveFloat>()).NativePtr);
		}

		// Token: 0x0601AFCB RID: 110539 RVA: 0x0027D53C File Offset: 0x0027B73C
		public static void CopyKuroCharFloatGroup(ref FKuroCharMaterialControllerFloatGroup Target, in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharFloatGroup_Internal((Target ?? new FKuroCharMaterialControllerFloatGroup()).NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601AFCC RID: 110540 RVA: 0x0027D590 File Offset: 0x0027B790
		public unsafe static void CopyKuroCharColorParameter(ref FKuroCharMaterialControllerColorParameter Target, in FName ParameterName, in FKuroCurveLinearColor ParameterValue)
		{
			fixed (FName* ptr = &ParameterName)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharColorParameter_Internal((Target ?? new FKuroCharMaterialControllerColorParameter()).NativePtr, ParameterName, (ParameterValue ?? new FKuroCurveLinearColor()).NativePtr);
			}
		}

		// Token: 0x0601AFCD RID: 110541 RVA: 0x0027D5CC File Offset: 0x0027B7CC
		public static void CopyKuroCharColorGroupArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCharMaterialControllerColorGroup> Target, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> Start, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> Loop, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> End)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CopyKuroCharColorGroupArray_Internal((Target ?? new TArray<FKuroCharMaterialControllerColorGroup>()).NativePtr, (Start ?? new TArray<FKuroCurveLinearColor>()).NativePtr, (Loop ?? new TArray<FKuroCurveLinearColor>()).NativePtr, (End ?? new TArray<FKuroCurveLinearColor>()).NativePtr);
		}

		// Token: 0x0601AFCE RID: 110542 RVA: 0x0027D61C File Offset: 0x0027B81C
		[NullableContext(1)]
		public unsafe static void ClipboardPaste_EditorOnly(ref string Dest)
		{
			FString fstring = FString.AllocTemp(Dest);
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClipboardPaste_EditorOnly_Internal(ref fstring);
			Dest = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AFCF RID: 110543 RVA: 0x0027D64C File Offset: 0x0027B84C
		[NullableContext(1)]
		public unsafe static void ClipboardCopy_EditorOnly(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClipboardCopy_EditorOnly_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601AFD0 RID: 110544 RVA: 0x0027D670 File Offset: 0x0027B870
		public static void ClearObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClearObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x0601AFD1 RID: 110545 RVA: 0x0027D688 File Offset: 0x0027B888
		public static void ClearKuroCellLayer(UObject WorldContextObject, EKuroCellLayerType ControlType)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClearKuroCellLayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControlType);
		}

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x0027D6A0 File Offset: 0x0027B8A0
		public static void CatmullRomPointsFromLists(TArray<FVectorDouble> PointList, ref TArray<FVector2D> CurveList, float alpha, float tension, int Step)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CatmullRomPointsFromLists_Internal((PointList ?? new TArray<FVectorDouble>()).NativePtr, (CurveList ?? new TArray<FVector2D>()).NativePtr, alpha, tension, Step);
		}

		// Token: 0x0601AFD3 RID: 110547 RVA: 0x0027D6CA File Offset: 0x0027B8CA
		public static void CatmullRomPoints(FVector2D P0, FVector2D P1, FVector2D P2, FVector2D P3, ref TArray<FVector2D> CurveList, float alpha = 0.5f, float tension = 0f, int Step = 4)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CatmullRomPoints_Internal(P0, P1, P2, P3, (CurveList ?? new TArray<FVector2D>()).NativePtr, alpha, tension, Step);
		}

		// Token: 0x0601AFD4 RID: 110548 RVA: 0x0027D6EC File Offset: 0x0027B8EC
		[NullableContext(1)]
		public unsafe static bool CaptureStatGPUTimingsToFile(FVector CapturePosition, string FileName, ref string OutFilePath, ref string OutFailureReason)
		{
			FString fstring = FString.AllocTemp(FileName);
			FString fstring2 = FString.AllocTemp(OutFilePath);
			FString fstring3 = FString.AllocTemp(OutFailureReason);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__CaptureStatGPUTimingsToFile_Internal(CapturePosition, fstring, ref fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			OutFilePath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			OutFailureReason = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0601AFD5 RID: 110549
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CanCutBelowLastHit(bool bHasLastCut, FVector LastHitPoint, FVector CurrentHitPoint, FVector BambooUpVector, FVector PlaneNormal, ref FVector OutCorrectedPlanePosition, ref FVector OutCorrectedPlaneNormal, ref float OutMaxAllowedHeightAlongUp, float MinCutDistance = 0f, float MaxPlaneNormalAngleFromUpDegrees = 60f);

		// Token: 0x0601AFD6 RID: 110550 RVA: 0x0027D74C File Offset: 0x0027B94C
		public unsafe static bool BuildDreamReflectionCaptureMatrixRows(USceneCaptureComponent2D CaptureComponent, UTextureRenderTarget2D RenderTarget, ref FLinearColor OutWorldToCaptureClipRow0, ref FLinearColor OutWorldToCaptureClipRow1, ref FLinearColor OutWorldToCaptureClipRow2, ref FLinearColor OutWorldToCaptureClipRow3)
		{
			fixed (FLinearColor* ptr = &OutWorldToCaptureClipRow0)
			{
				void* ptr2 = (void*)ptr;
				fixed (FLinearColor* ptr3 = &OutWorldToCaptureClipRow1)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FLinearColor* ptr5 = &OutWorldToCaptureClipRow2)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FLinearColor* ptr7 = &OutWorldToCaptureClipRow3)
						{
							void* ptr8 = (void*)ptr7;
							return UKuroRenderingRuntimeBPPluginBPLibrary.__BuildDreamReflectionCaptureMatrixRows_Internal((CaptureComponent != null) ? CaptureComponent.NativePtr : IntPtr.Zero, (RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, ref OutWorldToCaptureClipRow0, ref OutWorldToCaptureClipRow1, ref OutWorldToCaptureClipRow2, ref OutWorldToCaptureClipRow3);
						}
					}
				}
			}
		}

		// Token: 0x0601AFD7 RID: 110551 RVA: 0x0027D7A2 File Offset: 0x0027B9A2
		public static bool ApplyDreamReflectionCaptureParameters(USceneCaptureComponent2D CaptureComponent, UTextureRenderTarget2D RenderTarget, UMaterialInstanceDynamic MaterialInstance)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__ApplyDreamReflectionCaptureParameters_Internal((CaptureComponent != null) ? CaptureComponent.NativePtr : IntPtr.Zero, (RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, (MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFD8 RID: 110552 RVA: 0x0027D7D9 File Offset: 0x0027B9D9
		public static bool AddWeatherDataType(UObject WorldContextObject, FName Identifier, UClassStackOnlyPtr ClassType)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__AddWeatherDataType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Identifier, ClassType._NativePtr);
		}

		// Token: 0x0601AFD9 RID: 110553 RVA: 0x0027D7F7 File Offset: 0x0027B9F7
		public static int AddPostprocessMaterial(UObject WorldContextObject, UMaterialInterface Material, float Priority, bool bIsUiPostprocess = false)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__AddPostprocessMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero, Priority, bIsUiPostprocess);
		}

		// Token: 0x0601AFDA RID: 110554 RVA: 0x0027D820 File Offset: 0x0027BA20
		public unsafe static UActorComponent AddNamedComponent(AActor Actor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> Class, FName Name, bool bManualAttachment, in FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(UKuroRenderingRuntimeBPPluginBPLibrary.__AddNamedComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Class._NativePtr, Name, bManualAttachment, ptr));
		}

		// Token: 0x0601AFDB RID: 110555 RVA: 0x0027D86D File Offset: 0x0027BA6D
		public static void AddKuroCellLayer(UObject WorldContextObject, EKuroCellLayerType ControlType)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__AddKuroCellLayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ControlType);
		}

		// Token: 0x0601AFDC RID: 110556 RVA: 0x0027D885 File Offset: 0x0027BA85
		public static void AddAdditionalClusteredStuff(UObject WorldContextObject, UClusteredStuffDataAsset Asset)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__AddAdditionalClusteredStuff_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Asset != null) ? Asset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AFDD RID: 110557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteRenderTargetColorEditorOnly_Internal(IntPtr RT, IntPtr Colors);

		// Token: 0x0601AFDE RID: 110558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpPEnterCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x0601AFDF RID: 110559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpLeaveCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x0601AFE0 RID: 110560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpEnterCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer, float InAdjustValue, ECaveOrRoomLoadType LoadType, bool bUseCustomCoef);

		// Token: 0x0601AFE1 RID: 110561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpCancelAdjustLoadRange_Internal(IntPtr WorldContextObject);

		// Token: 0x0601AFE2 RID: 110562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpBeginLeaveCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x0601AFE3 RID: 110563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpBeginEnterCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x0601AFE4 RID: 110564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpBeginAdjustLoadRange_Internal(IntPtr WorldContextObject, float InAdjustValue, ECaveOrRoomLoadType InLoadType, bool bUseCustomCoef);

		// Token: 0x0601AFE5 RID: 110565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WeaponInteractCollisionAnyHit_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, ref FString DebugInfo);

		// Token: 0x0601AFE6 RID: 110566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WeaponInteractCollision_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, IntPtr HitComponent, float SweepRadius, float SpeedThreshold, float ValidTimeWindow, bool bShowTrace, float TraceDebugLifeTime, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, ref FString DebugInfo);

		// Token: 0x0601AFE7 RID: 110567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOrAddCurveFloatValue_Internal(IntPtr Curve, float InTime, float InValue);

		// Token: 0x0601AFE8 RID: 110568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOrAddCurveColorValue_Internal(IntPtr Curve, float InTime, FLinearColor InValue);

		// Token: 0x0601AFE9 RID: 110569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateFoliageDataLayer_Internal(IntPtr WorldContextObject, int InMobileLevel);

		// Token: 0x0601AFEA RID: 110570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectTransformLocation_Internal(bool ForceUpdate, IntPtr SceneComponent, IntPtr LocationCurve, float Time);

		// Token: 0x0601AFEB RID: 110571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectTransform_Internal(bool ForceUpdate, IntPtr SceneComponent, IntPtr LocationCurve, IntPtr RotationCurve, IntPtr ScaleCurve, float Time);

		// Token: 0x0601AFEC RID: 110572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBridgeParticleConstraint_Internal(IntPtr posArrL, IntPtr posArrR, float plankRestLength, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, int numIterations);

		// Token: 0x0601AFED RID: 110573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBridgeFakeCollision_Internal(IntPtr posArrL, IntPtr posArrR, in FVector cylinderCenter, in FVector cylinderAxis, float cylinderRadius, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, int numIterations, in FVector playerPos, float playerCollisionRadius, float playerPushStrength);

		// Token: 0x0601AFEE RID: 110574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdataPlaneList_PBD_WithChainState_Internal(IntPtr Components, IntPtr posArrL, IntPtr posArrR, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, FVector bridgeDir);

		// Token: 0x0601AFEF RID: 110575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdataPlaneList_PBD_Internal(IntPtr Components, IntPtr posArr, IntPtr posArrR);

		// Token: 0x0601AFF0 RID: 110576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnFreezeWorldLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x0601AFF1 RID: 110577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncBridgeChainVelocityAfterPostSteps_Internal(IntPtr posArr, IntPtr posFoeSnapshot, IntPtr volArr, bool isFirstFrame, float volDamping, float dt);

		// Token: 0x0601AFF2 RID: 110578
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SweptBladeTraceComponent_Internal(IntPtr WorldContextObject, IntPtr TargetComponent, FVector PrevRootPoint, FVector CurrRootPoint, FVector PrevTipPoint, FVector CurrTipPoint, float SweepRadius, int MaxSampleCount, IntPtr OutHit, ref int ActualSampleCount, bool bShowTrace, bool bTraceComplex, bool bUseWorldSweepByChannel, TEnumAsByte<ETraceTypeQuery> TraceChannel, FLinearColor TraceColor, FLinearColor TraceHitColor);

		// Token: 0x0601AFF3 RID: 110579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SuppressProceduralMeshLocalZAngularVelocity_Internal(IntPtr ProceduralMeshComp);

		// Token: 0x0601AFF4 RID: 110580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSomeWeatherBeforeTeleport_Internal(IntPtr WorldContextObject);

		// Token: 0x0601AFF5 RID: 110581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SplineMover_Internal(IntPtr MoveStates, IntPtr splineComp, float totalSplineLength, float moveSpeed, float deltaSeconds, float Tolerance);

		// Token: 0x0601AFF6 RID: 110582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnTransientActor_Internal(IntPtr WorldContextObject, in FName Name, in FName FolderPath);

		// Token: 0x0601AFF7 RID: 110583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnChunksForFullyDetachedBridgePlanks_Internal(IntPtr Components, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, IntPtr chunkMeshLists, bool bHideOriginalPlank, float spawnProbability, int breakHitIndex);

		// Token: 0x0601AFF8 RID: 110584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator, bool bTemporaryEditorActor);

		// Token: 0x0601AFF9 RID: 110585
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortStringArray_Internal(IntPtr InStringArray, TEnumAsByte<ESearchCase> SearchCase, bool Descending);

		// Token: 0x0601AFFA RID: 110586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortStaticMeshComponentsByName_Internal(IntPtr Components, IntPtr SortedComponents);

		// Token: 0x0601AFFB RID: 110587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionStreamingEnable_Internal(IntPtr WorldContextObject, bool bStreamingEnable);

		// Token: 0x0601AFFC RID: 110588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionDataLayerState2_Internal(IntPtr WorldContextObject, FName DataLayerName, EDataLayerState NewState);

		// Token: 0x0601AFFD RID: 110589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionDataLayerState_Internal(IntPtr WorldContextObject, FName DataLayerName, bool IsActivate);

		// Token: 0x0601AFFE RID: 110590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr WorldContextObject, in FVectorDouble InNewOrigin);

		// Token: 0x0601AFFF RID: 110591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumertricCloudShadowColor_Internal(IntPtr CloudComponent, FLinearColor Color);

		// Token: 0x0601B000 RID: 110592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumertricCloudLightColor_Internal(IntPtr CloudComponent, FLinearColor Color);

		// Token: 0x0601B001 RID: 110593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumertricCloudCustomLighting_Internal(IntPtr CloudComponent, float customLighting);

		// Token: 0x0601B002 RID: 110594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValueRef_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref FLinearColor RefLinearColor);

		// Token: 0x0601B003 RID: 110595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUsingInCaveOrIndoorShadow_Internal(IntPtr LightComp, bool IsUsing, float MobileCSMDistanceOld, float MobileCSMDistanceNew);

		// Token: 0x0601B004 RID: 110596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupVolumeSize_Internal(IntPtr Volume, in FBox Bounds);

		// Token: 0x0601B005 RID: 110597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformLocationInArray_Internal(IntPtr TransformArray, int index, in FVector Location);

		// Token: 0x0601B006 RID: 110598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSunLensflareEnabled_Internal(IntPtr WorldContextObject, bool bEnabled);

		// Token: 0x0601B007 RID: 110599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetString_Internal(IntPtr WorldContextObject, in FString Key, in FString Value);

		// Token: 0x0601B008 RID: 110600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneRenderingState_Internal(IntPtr WorldContextObject, bool bSceneVisible);

		// Token: 0x0601B009 RID: 110601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneKuroViewCenter_Internal(IntPtr WorldContextObject, FVector Location);

		// Token: 0x0601B00A RID: 110602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneKuroMainPlayerLocation_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x0601B00B RID: 110603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSceneCaptureOffAxisProjection_Internal(IntPtr CaptureComponent, float Left, float Right, float Bottom, float Top, float NearPlane);

		// Token: 0x0601B00C RID: 110604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOtherCharacterFootWP_Internal(IntPtr WorldContextObject, IntPtr Collection, IntPtr OtherCharacter, FVector CharacterPos);

		// Token: 0x0601B00D RID: 110605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0601B00E RID: 110606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSplineComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SplineComponent);

		// Token: 0x0601B00F RID: 110607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSkeletalMeshComponentWithoutWarning_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SkeletalMeshComponent);

		// Token: 0x0601B010 RID: 110608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraMultiSplineSource_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SourceActor);

		// Token: 0x0601B011 RID: 110609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraMultiSplineComponents_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SplineComponents);

		// Token: 0x0601B012 RID: 110610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraHoudiniPointDataCache_Internal(IntPtr NiagaraComponent, IntPtr HPCA, in FString ParameterName);

		// Token: 0x0601B013 RID: 110611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLevelEditorCameraLocation_Internal(IntPtr WorldContextObject, FVector Position);

		// Token: 0x0601B014 RID: 110612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUsingInCaveOrIndoorShadow_Internal(IntPtr WorldContextObject, bool IsUsing, float MobileCSMDistanceInCave, float MobileCSMDistanceOutCave);

		// Token: 0x0601B015 RID: 110613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntsDataToRenderTarget_Internal(IntPtr TextureRenderTarget, IntPtr WriteData);

		// Token: 0x0601B016 RID: 110614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt_Internal(IntPtr WorldContextObject, in FString Key, int Value);

		// Token: 0x0601B017 RID: 110615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetGlobalGITime_Internal(IntPtr WorldContextObject, float Time);

		// Token: 0x0601B018 RID: 110616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGITransientActorAttachment_Internal(IntPtr WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera);

		// Token: 0x0601B019 RID: 110617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloat_Internal(IntPtr WorldContextObject, in FString Key, float Value);

		// Token: 0x0601B01A RID: 110618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableEffectPostProcessVolume_Internal(IntPtr WorldContextObject, bool bDisable, float ChangeSpeed);

		// Token: 0x0601B01B RID: 110619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCVarInt32_Internal(in FString CVarKey, int Value);

		// Token: 0x0601B01C RID: 110620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCVarFloat_Internal(in FString CVarKey, float Value);

		// Token: 0x0601B01D RID: 110621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClusteredStuffVisible_Internal(IntPtr WorldContextObject, bool Visible);

		// Token: 0x0601B01E RID: 110622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterInBattle_Internal(IntPtr WorldContextObject, bool bInBattle);

		// Token: 0x0601B01F RID: 110623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __SetCharacterFootWP_Internal(IntPtr WorldContextObject, IntPtr Collection, IntPtr CharacterMesh);

		// Token: 0x0601B020 RID: 110624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorUISceneRendering_Internal(IntPtr Actor, bool IsUISceneRendering);

		// Token: 0x0601B021 RID: 110625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B022 RID: 110626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeSomeWeatherAfterTeleport_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B023 RID: 110627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResizeRenderTarget2D_Internal(IntPtr TextureRenderTarget, int InSizeX, int InSizeY);

		// Token: 0x0601B024 RID: 110628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetParticleSystem_Internal(IntPtr ParticleSystemComponent);

		// Token: 0x0601B025 RID: 110629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RerunConstructionScripts_Internal(IntPtr Actor);

		// Token: 0x0601B026 RID: 110630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePostprocessMaterial_Internal(IntPtr WorldContextObject, int Handle);

		// Token: 0x0601B027 RID: 110631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAdditionalClusteredStuff_Internal(IntPtr WorldContextObject, IntPtr Asset);

		// Token: 0x0601B028 RID: 110632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreenWithLevelEditorViewPortFloatRef_Internal(IntPtr WorldContextObject, in FVector WorldPosition, ref float ResultX, ref float ResultY, ref float ResultZ, ref float ResultW);

		// Token: 0x0601B029 RID: 110633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreenWithLevelEditorViewPort_Internal(IntPtr WorldContextObject, in FVector worldPosition, ref FVector4 result);

		// Token: 0x0601B02A RID: 110634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDQiuQian_MY_Internal(IntPtr particleArr, float linkDis, in FVector startPos, in FVector endPos, in FVector accel_ext, float collisionR, float volDamping, float dt, in FVector playerPos, float pushStrength, bool isStandOnPlank, ref FVector leftPos, ref FVector rightPos, ref FVector leftNorm, ref FVector rightNorm);

		// Token: 0x0601B02B RID: 110635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDQiuQian_Broken_Internal(IntPtr particleArr, float linkDis, in FVector startPos, in FVector endPos, in FVector accel_ext, float collisionR, float groundHeight, float volDamping, float dt, in FVector playerPos, float pushStrength, bool isStandOnPlank, ref FVector leftPos, ref FVector rightPos, ref FVector leftNorm, ref FVector rightNorm);

		// Token: 0x0601B02C RID: 110636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDChainParallel_MY_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, bool doParallel);

		// Token: 0x0601B02D RID: 110637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDChain_MY_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos);

		// Token: 0x0601B02E RID: 110638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDBridge_RealModelBroken_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, IntPtr foeDisList, IntPtr nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength, bool bBroken, int breakLeftIndex, IntPtr outParticleChainLinkMask, int breakExtraTowardStart, int breakExtraTowardEnd, float brokenDetachedEndsGravityAsym, float groundPlaneWorldZ, FVector brokenSimAccelExt, float brokenSimVolDamping);

		// Token: 0x0601B02F RID: 110639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDBridge_RealModel_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, IntPtr foeDisList, IntPtr nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength);

		// Token: 0x0601B030 RID: 110640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveCurveFloatValueToOtherTime_Internal(IntPtr Curve, float SrcTime, float TargetTime);

		// Token: 0x0601B031 RID: 110641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveCurveColorValueToOtherTime_Internal(IntPtr Curve, float SrcTime, float TargetTime);

		// Token: 0x0601B032 RID: 110642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MessageNotify_EditorOnly_Internal(IntPtr Message, FName Tile);

		// Token: 0x0601B033 RID: 110643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MaterialHasParameter_EditorOnly_Internal(IntPtr MaterialInterface, in FString ParameterName);

		// Token: 0x0601B034 RID: 110644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkWorldPostProcessPriorityDirty_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B035 RID: 110645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSequencePlayer_Internal(IntPtr SequenceComponent, IntPtr PlaybackSettings);

		// Token: 0x0601B036 RID: 110646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockProceduralMeshZRotation_Internal(IntPtr ProceduralMeshComp, bool bLock);

		// Token: 0x0601B037 RID: 110647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LerpSkyVolumetricCloudSetting_Internal(IntPtr Source, IntPtr Destination, float Weight, bool IgnoreOverride);

		// Token: 0x0601B038 RID: 110648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroMarkPackageDirty_Internal(IntPtr Object);

		// Token: 0x0601B039 RID: 110649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __KuroBuoyancyCalculation_Internal(IntPtr MeshComponent, IntPtr SphereList, float WaterHeight, FVector BuoyancyMagnitude);

		// Token: 0x0601B03A RID: 110650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWpPlayerInCaveOrRoom_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B03B RID: 110651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldPartitionWorld_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B03C RID: 110652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldPartitionDataLayerEnable_Internal(IntPtr WorldContextObject, FName DataLayerName);

		// Token: 0x0601B03D RID: 110653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldOriginVisibilityRequestPending_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B03E RID: 110654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldOriginFinish_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B03F RID: 110655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUseVirtualTexturing_Internal(IntPtr Actor);

		// Token: 0x0601B040 RID: 110656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingSourceInSide_Internal(IntPtr WorldContextObject, EStreamingSourcePriority StreamingSourcePriority, in FVector Origin, in FVector Extent);

		// Token: 0x0601B041 RID: 110657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPostprocessMaterialActive_Internal(IntPtr WorldContextObject, int Handle);

		// Token: 0x0601B042 RID: 110658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPositionInCaveOrRoom_Internal(IntPtr WorldContextObject, in FVector InPoisition);

		// Token: 0x0601B043 RID: 110659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsParticleComplete_Internal(IntPtr ParticleSystemComponent);

		// Token: 0x0601B044 RID: 110660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNiagaraComplete_Internal(IntPtr NiagaraComponent);

		// Token: 0x0601B045 RID: 110661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEditorOnlyActor_Internal(IntPtr Actor);

		// Token: 0x0601B046 RID: 110662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDistanceCull_Internal(IntPtr WorldContextObject, IntPtr EffectType, in FVector Location);

		// Token: 0x0601B047 RID: 110663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCurrentPlatformPC_Internal(IntPtr Actor);

		// Token: 0x0601B048 RID: 110664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKey_Internal(IntPtr WorldContextObject, in FString Key);

		// Token: 0x0601B049 RID: 110665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HasAnyObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0601B04A RID: 110666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HasAllObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0601B04B RID: 110667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetWpWorldBound_Internal(IntPtr WorldContextObject, ref FVector BoundMin, ref FVector BoundMax);

		// Token: 0x0601B04C RID: 110668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern BP_EWorldType __GetWorldType_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B04D RID: 110669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldSetting_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B04E RID: 110670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldRebaseRelativePos_Internal(IntPtr WorldContextObject, in FVector InCurPos);

		// Token: 0x0601B04F RID: 110671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldRebaseAbsoluePos_Internal(IntPtr WorldContextObject, in FVector InCurPos);

		// Token: 0x0601B050 RID: 110672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldPartitionAllDataLayerNames_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B051 RID: 110673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldPartition_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B052 RID: 110674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern KuroFeatureLevel __GetWorldFeatureLevel_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B053 RID: 110675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorld_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B054 RID: 110676
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWindowsVersion_Internal();

		// Token: 0x0601B055 RID: 110677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWeatherDataRef_Internal(IntPtr WorldContextObject, FName Identifier);

		// Token: 0x0601B056 RID: 110678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetViewportSizeInLink_Internal(IntPtr WorldContextObject, ref FVector2D ViewportSize);

		// Token: 0x0601B057 RID: 110679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVectorParameterValueRefRGBA_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref float RefLinearColorR, ref float RefLinearColorG, ref float RefLinearColorB, ref float RefLinearColorA);

		// Token: 0x0601B058 RID: 110680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVectorParameterValueRef_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref FLinearColor RefLinearColor);

		// Token: 0x0601B059 RID: 110681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedRefreshRates_Internal();

		// Token: 0x0601B05A RID: 110682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubsystem_Internal(IntPtr WorldContextObject, IntPtr WorldSubsystemClass);

		// Token: 0x0601B05B RID: 110683
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetString_Internal(IntPtr WorldContextObject, in FString Key, in FString DefaultValue);

		// Token: 0x0601B05C RID: 110684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStatGPUTimings_Internal(IntPtr OutTimings, ref FString OutFailureReason);

		// Token: 0x0601B05D RID: 110685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSpaceStateByPosition_Internal(IntPtr WorldContextObject, in FVector InPoisition, ref ECaveOrRoom OutSpaceType, ref FString OutEnClosetDataLayer, ref FString OutEnCloseSubDataLayer);

		// Token: 0x0601B05E RID: 110686
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSkeletalMaterialSlotName_Internal(IntPtr Skel, int MaterialIndex);

		// Token: 0x0601B05F RID: 110687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkeletalMaterialInterface_Internal(IntPtr Skel, int MaterialIndex);

		// Token: 0x0601B060 RID: 110688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSkeletalMaterialCount_Internal(IntPtr Skel);

		// Token: 0x0601B061 RID: 110689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneInteractionLevelActor_Internal(IntPtr InLevel);

		// Token: 0x0601B062 RID: 110690
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIVendorName_Internal();

		// Token: 0x0601B063 RID: 110691
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIName_Internal();

		// Token: 0x0601B064 RID: 110692
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDriverVersion_Internal();

		// Token: 0x0601B065 RID: 110693
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDriverDate_Internal();

		// Token: 0x0601B066 RID: 110694
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDeviceName_Internal();

		// Token: 0x0601B067 RID: 110695
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIAPIVersion_Internal();

		// Token: 0x0601B068 RID: 110696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPostProcessGIDataNames_Internal(IntPtr WorldContextObject, FVector WorldPosition, IntPtr OutDANames);

		// Token: 0x0601B069 RID: 110697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPostProcessGIDataDebugNames_Internal(IntPtr WorldContextObject, IntPtr OutDANames);

		// Token: 0x0601B06A RID: 110698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPostProcessGIDataDebugInfo_Internal(IntPtr WorldContextObject, FVector WorldPosition, IntPtr OutDAResult, IntPtr OutOverrideResult);

		// Token: 0x0601B06B RID: 110699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPlayerOrEditorCameraTransform_Internal(IntPtr WorldContextObject, ref FTransform OutCameraTransform);

		// Token: 0x0601B06C RID: 110700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPcLightCullParameters_Internal(IntPtr LightComponent, ref float LightMinDistance, ref float LightMaxDistance, ref float LightMinFade, ref float LightMaxFade);

		// Token: 0x0601B06D RID: 110701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOverlappingBoxCountForAllFoliageActors_Internal(IntPtr WorldContextObject, IntPtr FoliageType, in FBox Box, int Max);

		// Token: 0x0601B06E RID: 110702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetObjectMaskedFlags_Internal(IntPtr Object, int Mask);

		// Token: 0x0601B06F RID: 110703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetObjectFilterStateID_Internal(IntPtr Object, int ExtraID);

		// Token: 0x0601B070 RID: 110704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNiagaraParticleCount_Internal(IntPtr NiagaraComponent, ref int ActiveEmitters, ref int ActiveParticles);

		// Token: 0x0601B071 RID: 110705
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMobileDeviceModel_Internal();

		// Token: 0x0601B072 RID: 110706
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMobileDeviceMake_Internal();

		// Token: 0x0601B073 RID: 110707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLumenDiffuseGIFeatureEnabled_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B074 RID: 110708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLevelEditorViewPortSize_Internal(IntPtr WorldContextObject, ref FVector2D viewPortSize);

		// Token: 0x0601B075 RID: 110709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLevelEditorCameraLocationAndForward_Internal(IntPtr WorldContextObject, ref FVector Position, ref FRotator Rotation);

		// Token: 0x0601B076 RID: 110710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelActors_Internal(IntPtr InLevel);

		// Token: 0x0601B077 RID: 110711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevel_Internal(IntPtr World);

		// Token: 0x0601B078 RID: 110712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroLandscapeParametersDataAsset_Internal();

		// Token: 0x0601B079 RID: 110713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInt_Internal(IntPtr WorldContextObject, in FString Key, int DefaultValue);

		// Token: 0x0601B07A RID: 110714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalGIActor_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B07B RID: 110715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalFootstepMaterial_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B07C RID: 110716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGITransientActor_Internal(IntPtr WorldContextObject, FName IdName);

		// Token: 0x0601B07D RID: 110717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatGromGroup_Internal(IntPtr Target, float Factor, int Type);

		// Token: 0x0601B07E RID: 110718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloat_Internal(IntPtr WorldContextObject, in FString Key, float DefaultValue);

		// Token: 0x0601B07F RID: 110719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineSubsystem_Internal(IntPtr EngineSubsystem);

		// Token: 0x0601B080 RID: 110720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableNPCOptAsRayTracing_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B081 RID: 110721
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileProfileName_Internal();

		// Token: 0x0601B082 RID: 110722
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileDeviceType_Internal();

		// Token: 0x0601B083 RID: 110723
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileBaseProfileName_Internal();

		// Token: 0x0601B084 RID: 110724
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCVarString_Internal(in FString CVarKey);

		// Token: 0x0601B085 RID: 110725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCVarFloat_Internal(in FString CVarKey);

		// Token: 0x0601B086 RID: 110726
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCPUBrand_Internal();

		// Token: 0x0601B087 RID: 110727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetComponentToWorldNoWorldOffset_Internal(IntPtr Component);

		// Token: 0x0601B088 RID: 110728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentPhysicalMaterial_Internal(IntPtr Component);

		// Token: 0x0601B089 RID: 110729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetComponentLocationNoWorldOffset_Internal(IntPtr Component);

		// Token: 0x0601B08A RID: 110730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetColorFromGroup_Internal(IntPtr Target, float Factor, int Type);

		// Token: 0x0601B08B RID: 110731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterSectionMaterialIndex_Internal(IntPtr SkeletalMesh, int SectionIndex);

		// Token: 0x0601B08C RID: 110732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterSectionInfo_Internal(IntPtr Mesh, int SectionIndex);

		// Token: 0x0601B08D RID: 110733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterSectionCount_Internal(IntPtr Mesh);

		// Token: 0x0601B08E RID: 110734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCharacterInBattle_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B08F RID: 110735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCaveOrRoomState_Internal(IntPtr WorldContextObject, ref FString EnClosetDataLayer, ref FString EnCloseSubDataLayer, ref ECaveOrRoomLoadType OutLoadType, ref float OutLoadCoef);

		// Token: 0x0601B090 RID: 110736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCacheCameraInfo_Internal(IntPtr Owner, IntPtr Inout);

		// Token: 0x0601B091 RID: 110737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetBoneDirection_Internal(IntPtr SkeletalMeshComponent, FName BoneName);

		// Token: 0x0601B092 RID: 110738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAssetsByPath_Internal(FName PackagePath, bool bRecursive, bool bIncludeOnlyOnDiskAssets);

		// Token: 0x0601B093 RID: 110739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAndAddCurveFloatSampleTask_Internal(IntPtr WorldContextObject, long LastFrameHandle, IntPtr Curve, float Time, float Default, ref long OutHandle);

		// Token: 0x0601B094 RID: 110740
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAdapterUserDriverVersion_Internal();

		// Token: 0x0601B095 RID: 110741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetActorTransformNoWorldOffset_Internal(IntPtr Actor);

		// Token: 0x0601B096 RID: 110742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorsInLevel_Internal(IntPtr InLevel, IntPtr ActorClass, IntPtr OutActors);

		// Token: 0x0601B097 RID: 110743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x0601B098 RID: 110744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorLocationRefXYZ_Internal(IntPtr Actor, ref float X, ref float Y, ref float Z);

		// Token: 0x0601B099 RID: 110745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorLocationRef_Internal(IntPtr Actor, ref FVector RefLocation);

		// Token: 0x0601B09A RID: 110746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorLocationNoWorldOffset_Internal(IntPtr Actor);

		// Token: 0x0601B09B RID: 110747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorForwardVectorRefXYZ_Internal(IntPtr Actor, ref float X, ref float Y, ref float Z);

		// Token: 0x0601B09C RID: 110748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorForwardVectorRef_Internal(IntPtr Actor, ref FVector RefForwardVector);

		// Token: 0x0601B09D RID: 110749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_GetSegmentIntersection_Internal(in FVector2D RayStart, in FVector2D RayEnd, IntPtr Seg, ref FVector2D OutPoint, ref float OutParamT);

		// Token: 0x0601B09E RID: 110750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_GetCircleTangentPoints2_Internal(in FVector2D P, IntPtr Circle, ref FVector2D OutTangent1, ref FVector2D OutTangent2, float Epsilon);

		// Token: 0x0601B09F RID: 110751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_GetCircleTangentPoints_Internal(in FVector2D P, IntPtr Circle, ref FVector2D OutTangent1, ref FVector2D OutTangent2);

		// Token: 0x0601B0A0 RID: 110752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_GetCircleIntersection_Internal(in FVector2D RayStart, in FVector2D RayEnd, IntPtr Circle, ref FVector2D OutPoint, ref float OutParamT);

		// Token: 0x0601B0A1 RID: 110753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_DetectPlayer_Two_Internal(double Index, int ParticleCount, IntPtr Dis, IntPtr Dirs, in FVector PlayerPos, in FVector WorldPos, in FRotator Rotator, ref float OutDistance);

		// Token: 0x0601B0A2 RID: 110754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_DetectPlayer_Internal(int Index, int ParticleCount, IntPtr EndPos, in FVector PlayerPos, in FVector WorldPos, ref float OutDistance);

		// Token: 0x0601B0A3 RID: 110755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_ComputeVisibilityDebugPoints_Batch_Internal(FVector2D Origin, FVector2D PlayerPos, IntPtr FS_Circles, IntPtr FS_Segments, IntPtr OutHits, IntPtr OutHitsReal, float RayLength, float AngleOffset, float AngleOffset2, bool bUseInputCircles, bool bUseInputSegments, bool bDoParallel, int StartIndex, int UpdateCount);

		// Token: 0x0601B0A4 RID: 110756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_ComputeVisibilityDebugPoints_Internal(FVector2D Origin, FVector2D PlayerPos, IntPtr Circles, IntPtr Segments, IntPtr OutHits, float RayLength, float AngleOffset, bool bUseInputCircles, bool bUseInputSegments, bool bDoParallel);

		// Token: 0x0601B0A5 RID: 110757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FS_ComputeTilt_ByHeightH2_Internal(ref FVectorDouble LastFrameNormal, in FTransform PlaneTransform, float RayCastingDetectRange, in FVector PlayerPos, double MaxDegreeAngle, float MinActiveRadius, float MaxActiveRadius, double FollowSpeedRate, double ReturnSpeedRate, bool bPlayerColliding, bool bNeedReturnOrNot, bool bLinear);

		// Token: 0x0601B0A6 RID: 110758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FS_ComputeTilt_ByHeightH_Internal(in FTransform PlaneTransform, float Radius, in FVector PersonWorld, double H, double MaxDegreeAngle, double MinActiveRadius, double MaxActiveRadius, bool bPlayerColliding, double FollowSpeedDegPerSec, double ReturnSpeedDegPerSec, float DeltaSeconds, bool bNeedReturnOrNot);

		// Token: 0x0601B0A7 RID: 110759
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FS_CheckFrontObstacle2_Internal(float RayCastingDetectDis, IntPtr WorldContextObject, TEnumAsByte<ETraceTypeQuery> TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, IntPtr Dir, IntPtr EndPos, IntPtr Dis, IntPtr ParamNames, IntPtr MID, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, IntPtr ActorsToIgnore);

		// Token: 0x0601B0A8 RID: 110760
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FS_CheckFrontObstacle_Internal(float RayCastingDetectDis, IntPtr WorldContextObject, TEnumAsByte<ETraceTypeQuery> TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, IntPtr Dir, IntPtr EndPos, IntPtr ParamNames, IntPtr MID, bool debugLine, int CountIndex);

		// Token: 0x0601B0A9 RID: 110761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FS_AppendCandidateAngles_Internal(in FVector2D Origin, IntPtr InCircles, IntPtr InSegments, IntPtr Angles, float AngleOffset);

		// Token: 0x0601B0AA RID: 110762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeWorldLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B0AB RID: 110763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FilterWeaponSweepPosition_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool ValidBool, int FilterStateID, float ValidTimeWindow, float SpeedThreshold, float AlternatingPointTolerance, float ReverseDirectionDotThreshold);

		// Token: 0x0601B0AC RID: 110764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyGITransientActor_Internal(IntPtr WorldContextObject, FName IdName);

		// Token: 0x0601B0AD RID: 110765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteKey_Internal(IntPtr WorldContextObject, in FString Key);

		// Token: 0x0601B0AE RID: 110766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteAll_Internal(IntPtr WorldContextObject);

		// Token: 0x0601B0AF RID: 110767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator, bool bTemporaryEditorActor);

		// Token: 0x0601B0B0 RID: 110768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateGITransientActor_Internal(IntPtr WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera, FName EditorFolderPath);

		// Token: 0x0601B0B1 RID: 110769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharLinearColorGroup_Internal(IntPtr Target, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x0601B0B2 RID: 110770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharFloatParameter_Internal(IntPtr Target, in FName ParameterName, IntPtr ParameterValue);

		// Token: 0x0601B0B3 RID: 110771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharFloatGroupArray_Internal(IntPtr Target, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x0601B0B4 RID: 110772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharFloatGroup_Internal(IntPtr Target, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x0601B0B5 RID: 110773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharColorParameter_Internal(IntPtr Target, in FName ParameterName, IntPtr ParameterValue);

		// Token: 0x0601B0B6 RID: 110774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyKuroCharColorGroupArray_Internal(IntPtr Target, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x0601B0B7 RID: 110775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipboardPaste_EditorOnly_Internal(ref FString Dest);

		// Token: 0x0601B0B8 RID: 110776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipboardCopy_EditorOnly_Internal(in FString Str);

		// Token: 0x0601B0B9 RID: 110777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0601B0BA RID: 110778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKuroCellLayer_Internal(IntPtr WorldContextObject, EKuroCellLayerType ControlType);

		// Token: 0x0601B0BB RID: 110779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CatmullRomPointsFromLists_Internal(IntPtr PointList, IntPtr CurveList, float alpha, float tension, int Step);

		// Token: 0x0601B0BC RID: 110780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CatmullRomPoints_Internal(FVector2D P0, FVector2D P1, FVector2D P2, FVector2D P3, IntPtr CurveList, float alpha, float tension, int Step);

		// Token: 0x0601B0BD RID: 110781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CaptureStatGPUTimingsToFile_Internal(FVector CapturePosition, in FString FileName, ref FString OutFilePath, ref FString OutFailureReason);

		// Token: 0x0601B0BE RID: 110782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BuildDreamReflectionCaptureMatrixRows_Internal(IntPtr CaptureComponent, IntPtr RenderTarget, ref FLinearColor OutWorldToCaptureClipRow0, ref FLinearColor OutWorldToCaptureClipRow1, ref FLinearColor OutWorldToCaptureClipRow2, ref FLinearColor OutWorldToCaptureClipRow3);

		// Token: 0x0601B0BF RID: 110783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ApplyDreamReflectionCaptureParameters_Internal(IntPtr CaptureComponent, IntPtr RenderTarget, IntPtr MaterialInstance);

		// Token: 0x0601B0C0 RID: 110784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddWeatherDataType_Internal(IntPtr WorldContextObject, FName Identifier, IntPtr ClassType);

		// Token: 0x0601B0C1 RID: 110785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddPostprocessMaterial_Internal(IntPtr WorldContextObject, IntPtr Material, float Priority, bool bIsUiPostprocess);

		// Token: 0x0601B0C2 RID: 110786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddNamedComponent_Internal(IntPtr Actor, IntPtr Class, FName Name, bool bManualAttachment, in FTransform Transform);

		// Token: 0x0601B0C3 RID: 110787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKuroCellLayer_Internal(IntPtr WorldContextObject, EKuroCellLayerType ControlType);

		// Token: 0x0601B0C4 RID: 110788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAdditionalClusteredStuff_Internal(IntPtr WorldContextObject, IntPtr Asset);

		// Token: 0x0601B0C5 RID: 110789 RVA: 0x0027D8AC File Offset: 0x0027BAAC
		static UKuroRenderingRuntimeBPPluginBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary");
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x0027D8BA File Offset: 0x0027BABA
		protected UKuroRenderingRuntimeBPPluginBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E901 RID: 59649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary";

		// Token: 0x0400E902 RID: 59650
		private static IntPtr _ClassPtr;

		// Token: 0x0400E903 RID: 59651
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
