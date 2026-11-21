using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DB RID: 1243
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroRenderingRuntimeBPPluginBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073F4 RID: 29684 RVA: 0x000A9EBD File Offset: 0x000A80BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary._ClassPtr;
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x000A9ECC File Offset: 0x000A80CC
		public UKuroRenderingRuntimeBPPluginBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingRuntimeBPPluginBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x000A9EF4 File Offset: 0x000A80F4
		[NullableContext(1)]
		public UKuroRenderingRuntimeBPPluginBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingRuntimeBPPluginBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x000A9F27 File Offset: 0x000A8127
		public static void WriteRenderTargetColorEditorOnly(UTextureRenderTarget2D RT, in TArray<FLinearColor> Colors)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__WriteRenderTargetColorEditorOnly_Internal((RT != null) ? RT.NativePtr : IntPtr.Zero, (Colors ?? new TArray<FLinearColor>()).NativePtr);
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x000A9F50 File Offset: 0x000A8150
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

		// Token: 0x060073F9 RID: 29689 RVA: 0x000A9F84 File Offset: 0x000A8184
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

		// Token: 0x060073FA RID: 29690 RVA: 0x000A9FB8 File Offset: 0x000A81B8
		public static void WpCancelAdjustLoadRange(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__WpCancelAdjustLoadRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x000A9FD0 File Offset: 0x000A81D0
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

		// Token: 0x060073FC RID: 29692 RVA: 0x000AA004 File Offset: 0x000A8204
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

		// Token: 0x060073FD RID: 29693 RVA: 0x000AA038 File Offset: 0x000A8238
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

		// Token: 0x060073FE RID: 29694 RVA: 0x000AA0C0 File Offset: 0x000A82C0
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

		// Token: 0x060073FF RID: 29695
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D VolumeSphereInWater(FVector Pos, float Radius, float WaterHeight);

		// Token: 0x06007400 RID: 29696 RVA: 0x000AA164 File Offset: 0x000A8364
		public static void UpdateOrAddCurveFloatValue(UCurveFloat Curve, float InTime, float InValue)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateOrAddCurveFloatValue_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, InTime, InValue);
		}

		// Token: 0x06007401 RID: 29697
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateMountainRowLoopLocation(in FVectorDouble BaseLocation, double OriginY, double TileLength, double Speed, double DeltaSeconds, ref double InOutFlowDistance, ref FVectorDouble OutLocation, ref double OutDeltaY, ref double OutLoopRelY);

		// Token: 0x06007402 RID: 29698 RVA: 0x000AA17D File Offset: 0x000A837D
		public static void UpdateFoliageDataLayer(UObject WorldContextObject, int InMobileLevel)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateFoliageDataLayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InMobileLevel);
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x000AA195 File Offset: 0x000A8395
		public static void UpdateEffectTransformLocation(bool ForceUpdate, USceneComponent SceneComponent, in FKuroCurveVector LocationCurve, float Time)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateEffectTransformLocation_Internal(ForceUpdate, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, (LocationCurve ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x000AA1C0 File Offset: 0x000A83C0
		public static void UpdateEffectTransform(bool ForceUpdate, USceneComponent SceneComponent, in FKuroCurveVector LocationCurve, in FKuroCurveVector RotationCurve, in FKuroCurveVector ScaleCurve, float Time)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateEffectTransform_Internal(ForceUpdate, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, (LocationCurve ?? new FKuroCurveVector()).NativePtr, (RotationCurve ?? new FKuroCurveVector()).NativePtr, (ScaleCurve ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x000AA218 File Offset: 0x000A8418
		public static void UpdateBridgeParticleConstraint(ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, float plankRestLength, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, int numIterations = 1)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateBridgeParticleConstraint_Internal((posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, plankRestLength, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, numIterations);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x000AA270 File Offset: 0x000A8470
		public static void UpdateBridgeFakeCollision(ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, in FVector cylinderCenter, in FVector cylinderAxis, float cylinderRadius, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, int numIterations = 1, in FVector playerPos = null, float playerCollisionRadius = 0f, float playerPushStrength = 30f)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdateBridgeFakeCollision_Internal((posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, cylinderCenter, cylinderAxis, cylinderRadius, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, numIterations, playerPos, playerCollisionRadius, playerPushStrength);
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		public static void UpdataPlaneList_PBD_WithChainState([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, ref TArray<FVector> posArrL, ref TArray<FVector> posArrR, in TArray<byte> chainLinkMaskL, in TArray<byte> chainLinkMaskR, FVector bridgeDir)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdataPlaneList_PBD_WithChainState_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (posArrL ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr, (chainLinkMaskL ?? new TArray<byte>()).NativePtr, (chainLinkMaskR ?? new TArray<byte>()).NativePtr, bridgeDir);
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x000AA335 File Offset: 0x000A8535
		public static void UpdataPlaneList_PBD([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UStaticMeshComponent> Components, ref TArray<FVector> posArr, ref TArray<FVector> posArrR)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UpdataPlaneList_PBD_Internal((Components ?? new TArray<UStaticMeshComponent>()).NativePtr, (posArr ?? new TArray<FVector>()).NativePtr, (posArrR ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06007409 RID: 29705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor UnpackVector2DToLinearColorRGB(in FVector2D Vector2D);

		// Token: 0x0600740A RID: 29706 RVA: 0x000AA36C File Offset: 0x000A856C
		public static void UnFreezeWorldLevelStreaming(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__UnFreezeWorldLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x000AA383 File Offset: 0x000A8583
		public static void SyncBridgeChainVelocityAfterPostSteps(ref TArray<FVector> posArr, in TArray<FVector> posFoeSnapshot, ref TArray<FVector> volArr, bool isFirstFrame, float volDamping, float dt)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SyncBridgeChainVelocityAfterPostSteps_Internal((posArr ?? new TArray<FVector>()).NativePtr, (posFoeSnapshot ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, isFirstFrame, volDamping, dt);
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x000AA3C0 File Offset: 0x000A85C0
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

		// Token: 0x0600740D RID: 29709 RVA: 0x000AA4BC File Offset: 0x000A86BC
		public static void SuppressProceduralMeshLocalZAngularVelocity(UProceduralMeshComponent ProceduralMeshComp)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SuppressProceduralMeshLocalZAngularVelocity_Internal((ProceduralMeshComp != null) ? ProceduralMeshComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600740E RID: 29710
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportVulkan();

		// Token: 0x0600740F RID: 29711 RVA: 0x000AA4D3 File Offset: 0x000A86D3
		public static void StopSomeWeatherBeforeTeleport(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__StopSomeWeatherBeforeTeleport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007410 RID: 29712
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType Type = EKuroCaptureSceneColorType.KCSCT_Default, float HoldSeconds = 2f);

		// Token: 0x06007411 RID: 29713
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType Type = EKuroCaptureSceneColorType.KCSCT_Default);

		// Token: 0x06007412 RID: 29714 RVA: 0x000AA4EC File Offset: 0x000A86EC
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

		// Token: 0x06007413 RID: 29715 RVA: 0x000AA520 File Offset: 0x000A8720
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

		// Token: 0x06007414 RID: 29716 RVA: 0x000AA591 File Offset: 0x000A8791
		public static void SortStringArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InStringArray, ESearchCase SearchCase = ESearchCase.CaseSensitive, bool Descending = false)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SortStringArray_Internal((InStringArray ?? new TArray<string>()).NativePtr, SearchCase, Descending);
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x000AA5AF File Offset: 0x000A87AF
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

		// Token: 0x06007416 RID: 29718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector solvenostretch(in FVector pos, in FVector linkPos, float targetLen, in FVector emiterOriginPos, bool isPinned);

		// Token: 0x06007417 RID: 29719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector solve(in FVector pos, in FVector linkPos, float targetLen, in FVector emiterOriginPos, bool isPinned);

		// Token: 0x06007418 RID: 29720 RVA: 0x000AA5D6 File Offset: 0x000A87D6
		public static void SetWorldPartitionStreamingEnable(UObject WorldContextObject, bool bStreamingEnable)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionStreamingEnable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bStreamingEnable);
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x000AA5EE File Offset: 0x000A87EE
		public static void SetWorldPartitionDataLayerState2(UObject WorldContextObject, FName DataLayerName, EDataLayerState NewState)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionDataLayerState2_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName, NewState);
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x000AA607 File Offset: 0x000A8807
		public static void SetWorldPartitionDataLayerState(UObject WorldContextObject, FName DataLayerName, bool IsActivate)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldPartitionDataLayerState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName, IsActivate);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x000AA620 File Offset: 0x000A8820
		public static void SetWorldOrigin(UObject WorldContextObject, in FVectorDouble InNewOrigin)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetWorldOrigin_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InNewOrigin);
		}

		// Token: 0x0600741C RID: 29724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetVulkanPromotion(bool promot);

		// Token: 0x0600741D RID: 29725 RVA: 0x000AA638 File Offset: 0x000A8838
		public unsafe static void SetVectorParameterValueRef(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, ref FLinearColor RefLinearColor)
		{
			fixed (FLinearColor* ptr = &RefLinearColor)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__SetVectorParameterValueRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ref RefLinearColor);
			}
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x000AA674 File Offset: 0x000A8874
		public static void SetupVolumeSize(AVolume Volume, in FBox Bounds)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetupVolumeSize_Internal((Volume != null) ? Volume.NativePtr : IntPtr.Zero, Bounds);
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x000AA68C File Offset: 0x000A888C
		public static void SetTransformLocationInArray(ref TArray<FTransform> TransformArray, int index, in FVector Location)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetTransformLocationInArray_Internal((TransformArray ?? new TArray<FTransform>()).NativePtr, index, Location);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x000AA6A5 File Offset: 0x000A88A5
		public static void SetSunLensflareEnabled(UObject WorldContextObject, bool bEnabled)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSunLensflareEnabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bEnabled);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x000AA6C0 File Offset: 0x000A88C0
		[NullableContext(1)]
		public unsafe static void SetString([Nullable(2)] UObject WorldContextObject, string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x000AA706 File Offset: 0x000A8906
		public static void SetSceneRenderingState(UObject WorldContextObject, bool bSceneVisible)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneRenderingState_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bSceneVisible);
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x000AA71E File Offset: 0x000A891E
		public static void SetSceneKuroViewCenter(UObject WorldContextObject, FVector Location)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneKuroViewCenter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x000AA736 File Offset: 0x000A8936
		public static void SetSceneKuroMainPlayerLocation(UObject WorldContextObject, int PlayerIndex)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneKuroMainPlayerLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PlayerIndex);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x000AA74E File Offset: 0x000A894E
		public static bool SetSceneCaptureOffAxisProjection(USceneCaptureComponent2D CaptureComponent, float Left, float Right, float Bottom, float Top, float NearPlane)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetSceneCaptureOffAxisProjection_Internal((CaptureComponent != null) ? CaptureComponent.NativePtr : IntPtr.Zero, Left, Right, Bottom, Top, NearPlane);
		}

		// Token: 0x06007426 RID: 29734
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRayTracingEnable(bool bEnable);

		// Token: 0x06007427 RID: 29735 RVA: 0x000AA76C File Offset: 0x000A896C
		public static void SetOtherCharacterFootWP(UObject WorldContextObject, UMaterialParameterCollection Collection, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> OtherCharacter, FVector CharacterPos)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetOtherCharacterFootWP_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (OtherCharacter ?? new TArray<AActor>()).NativePtr, CharacterPos);
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x000AA7A3 File Offset: 0x000A89A3
		public static void SetObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x000AA7BC File Offset: 0x000A89BC
		public unsafe static void SetNiagaraSplineComponent(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USplineComponent SplineComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraSplineComponent_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SplineComponent != null) ? SplineComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x000AA800 File Offset: 0x000A8A00
		public unsafe static void SetNiagaraSkeletalMeshComponentWithoutWarning(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraSkeletalMeshComponentWithoutWarning_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x000AA844 File Offset: 0x000A8A44
		public unsafe static void SetNiagaraMultiSplineSource(UNiagaraComponent NiagaraSystem, [Nullable(1)] string OverrideName, AActor SourceActor)
		{
			FString fstring = FString.AllocTemp(OverrideName);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetNiagaraMultiSplineSource_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero, fstring, (SourceActor != null) ? SourceActor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x000AA888 File Offset: 0x000A8A88
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

		// Token: 0x0600742D RID: 29741 RVA: 0x000AA8CC File Offset: 0x000A8ACC
		public static bool SetLevelEditorCameraLocation(UObject WorldContextObject, FVector Position)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetLevelEditorCameraLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position);
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
		public static void SetIsUsingInCaveOrIndoorShadow(UObject WorldContextObject, bool IsUsing, float MobileCSMDistanceInCave, float MobileCSMDistanceOutCave)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetIsUsingInCaveOrIndoorShadow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IsUsing, MobileCSMDistanceInCave, MobileCSMDistanceOutCave);
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x000AA8FE File Offset: 0x000A8AFE
		public static void SetIntsDataToRenderTarget(UTextureRenderTarget2D TextureRenderTarget, TArray<int> WriteData)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetIntsDataToRenderTarget_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (WriteData ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x000AA924 File Offset: 0x000A8B24
		[NullableContext(1)]
		public unsafe static void SetInt([Nullable(2)] UObject WorldContextObject, string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetInt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x000AA959 File Offset: 0x000A8B59
		public static bool SetGlobalGITime(UObject WorldContextObject, float Time)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetGlobalGITime_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Time);
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x000AA971 File Offset: 0x000A8B71
		public static void SetGITransientActorAttachment(UObject WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetGITransientActorAttachment_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName, bAttachToPlayer, bAttachToEditorCamera);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x000AA98C File Offset: 0x000A8B8C
		[NullableContext(1)]
		public unsafe static void SetFloat([Nullable(2)] UObject WorldContextObject, string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetFloat_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x000AA9C1 File Offset: 0x000A8BC1
		public static void SetDisableEffectPostProcessVolume(UObject WorldContextObject, bool bDisable, float ChangeSpeed)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetDisableEffectPostProcessVolume_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bDisable, ChangeSpeed);
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x000AA9DC File Offset: 0x000A8BDC
		[NullableContext(1)]
		public unsafe static void SetCVarInt32(string CVarKey, int Value)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCVarInt32_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x000AAA04 File Offset: 0x000A8C04
		[NullableContext(1)]
		public unsafe static void SetCVarFloat(string CVarKey, float Value)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCVarFloat_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x000AAA29 File Offset: 0x000A8C29
		public static void SetClusteredStuffVisible(UObject WorldContextObject, bool Visible)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetClusteredStuffVisible_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Visible);
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x000AAA41 File Offset: 0x000A8C41
		public static void SetCharacterInBattle(UObject WorldContextObject, bool bInBattle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetCharacterInBattle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bInBattle);
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x000AAA59 File Offset: 0x000A8C59
		public static FVector SetCharacterFootWP(UObject WorldContextObject, UMaterialParameterCollection Collection, USceneComponent CharacterMesh)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__SetCharacterFootWP_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, (CharacterMesh != null) ? CharacterMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600743A RID: 29754
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAnisoLevel(int Level);

		// Token: 0x0600743B RID: 29755 RVA: 0x000AAA90 File Offset: 0x000A8C90
		public static void SetActorUISceneRendering(AActor Actor, bool IsUISceneRendering)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__SetActorUISceneRendering_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, IsUISceneRendering);
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x000AAAA8 File Offset: 0x000A8CA8
		public static void Save(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__Save_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600743D RID: 29757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor RGB2HSP(FLinearColor rgb);

		// Token: 0x0600743E RID: 29758 RVA: 0x000AAABF File Offset: 0x000A8CBF
		public static void ResumeSomeWeatherAfterTeleport(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ResumeSomeWeatherAfterTeleport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x000AAAD6 File Offset: 0x000A8CD6
		public static void ResizeRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget, int InSizeX, int InSizeY)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ResizeRenderTarget2D_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, InSizeX, InSizeY);
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x000AAAEF File Offset: 0x000A8CEF
		public static void RerunConstructionScripts(AActor Actor)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__RerunConstructionScripts_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x000AAB06 File Offset: 0x000A8D06
		public static void RemovePostprocessMaterial(UObject WorldContextObject, int Handle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__RemovePostprocessMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Handle);
		}

		// Token: 0x06007442 RID: 29762
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseGetSceneDepthShotBefore();

		// Token: 0x06007443 RID: 29763
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseGetSceneColorShotBefore();

		// Token: 0x06007444 RID: 29764 RVA: 0x000AAB20 File Offset: 0x000A8D20
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

		// Token: 0x06007445 RID: 29765 RVA: 0x000AAB68 File Offset: 0x000A8D68
		public unsafe static bool ProjectWorldToScreenWithLevelEditorViewPort(UObject WorldContextObject, in FVector worldPosition, ref FVector4 result)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = result;
			bool result2 = UKuroRenderingRuntimeBPPluginBPLibrary.__ProjectWorldToScreenWithLevelEditorViewPort_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, worldPosition, ref ptr);
			result = ptr;
			return result2;
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x000AABB4 File Offset: 0x000A8DB4
		public static void PBDChainParallel_MY(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, bool doParallel = true)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDChainParallel_MY_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, linkDis, emitterOriginPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, doParallel);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x000AAC08 File Offset: 0x000A8E08
		public static void PBDChain_MY(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDChain_MY_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, linkDis, emitterOriginPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos);
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x000AAC5C File Offset: 0x000A8E5C
		public static void PBDBridge_RealModelBroken(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, in TArray<float> foeDisList, in TArray<float> nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength, bool bBroken, int breakLeftIndex, ref TArray<byte> outParticleChainLinkMask, int breakExtraTowardStart = 0, int breakExtraTowardEnd = 0, float brokenDetachedEndsGravityAsym = 1f, float groundPlaneWorldZ = 0f, FVector? brokenSimAccelExt = null, float brokenSimVolDamping = 0.99f)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDBridge_RealModelBroken_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, (foeDisList ?? new TArray<float>()).NativePtr, (nxtDisList ?? new TArray<float>()).NativePtr, linkDisScale, startPinPos, endPinPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, bridgeDir, pushStrength, bBroken, breakLeftIndex, (outParticleChainLinkMask ?? new TArray<byte>()).NativePtr, breakExtraTowardStart, breakExtraTowardEnd, brokenDetachedEndsGravityAsym, groundPlaneWorldZ, brokenSimAccelExt ?? new FVector(0f, 0f), brokenSimVolDamping);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x000AAD18 File Offset: 0x000A8F18
		public static void PBDBridge_RealModel(ref TArray<FVector> posArr, ref TArray<FVector> volArr, ref TArray<FVector> posArrFoe, in TArray<float> foeDisList, in TArray<float> nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__PBDBridge_RealModel_Internal((posArr ?? new TArray<FVector>()).NativePtr, (volArr ?? new TArray<FVector>()).NativePtr, (posArrFoe ?? new TArray<FVector>()).NativePtr, (foeDisList ?? new TArray<float>()).NativePtr, (nxtDisList ?? new TArray<float>()).NativePtr, linkDisScale, startPinPos, endPinPos, accel_ext, collisionR, isFirstFrame, volDamping, dt, playerPos, bridgeDir, pushStrength);
		}

		// Token: 0x0600744A RID: 29770
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D PackLinearColorRGBToVector2D(in FLinearColor Color);

		// Token: 0x0600744B RID: 29771 RVA: 0x000AAD91 File Offset: 0x000A8F91
		public static void MoveCurveFloatValueToOtherTime(UCurveFloat Curve, float SrcTime, float TargetTime)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MoveCurveFloatValueToOtherTime_Internal((Curve != null) ? Curve.NativePtr : IntPtr.Zero, SrcTime, TargetTime);
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x000AADAC File Offset: 0x000A8FAC
		[NullableContext(1)]
		public static void MessageNotify_EditorOnly(FText Message, FName? Tile = null)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MessageNotify_EditorOnly_Internal((Message != null) ? Message.NativePtr : IntPtr.Zero, Tile ?? new FName("MessageNotify"));
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x000AADEC File Offset: 0x000A8FEC
		[NullableContext(1)]
		public unsafe static bool MaterialHasParameter_EditorOnly([Nullable(2)] UMaterialInterface MaterialInterface, string ParameterName)
		{
			FString fstring = FString.AllocTemp(ParameterName);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__MaterialHasParameter_EditorOnly_Internal((MaterialInterface != null) ? MaterialInterface.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x000AAE20 File Offset: 0x000A9020
		public static void MarkWorldPostProcessPriorityDirty(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__MarkWorldPostProcessPriorityDirty_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x000AAE37 File Offset: 0x000A9037
		public static void LockProceduralMeshZRotation(UProceduralMeshComponent ProceduralMeshComp, bool bLock = true)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__LockProceduralMeshZRotation_Internal((ProceduralMeshComp != null) ? ProceduralMeshComp.NativePtr : IntPtr.Zero, bLock);
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x000AAE4F File Offset: 0x000A904F
		public static void KuroMarkPackageDirty(UObject Object)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__KuroMarkPackageDirty_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x000AAE68 File Offset: 0x000A9068
		public static FVector2D KuroBuoyancyCalculation(UStaticMeshComponent MeshComponent, in TArray<FVector4> SphereList, float WaterHeight, FVector? BuoyancyMagnitude = null)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__KuroBuoyancyCalculation_Internal((MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero, (SphereList ?? new TArray<FVector4>()).NativePtr, WaterHeight, BuoyancyMagnitude ?? new FVector(0f, 0f, 1f));
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x000AAEC3 File Offset: 0x000A90C3
		public static bool IsWpPlayerInCaveOrRoom(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWpPlayerInCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x000AAEDA File Offset: 0x000A90DA
		public static bool IsWorldPartitionWorld(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldPartitionWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x000AAEF1 File Offset: 0x000A90F1
		public static bool IsWorldPartitionDataLayerEnable(UObject WorldContextObject, FName DataLayerName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldPartitionDataLayerEnable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, DataLayerName);
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x000AAF09 File Offset: 0x000A9109
		public static bool IsWorldOriginVisibilityRequestPending(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldOriginVisibilityRequestPending_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x000AAF20 File Offset: 0x000A9120
		public static bool IsWorldOriginFinish(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsWorldOriginFinish_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007457 RID: 29783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUsingParallaxCorrect();

		// Token: 0x06007458 RID: 29784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUsingNotSeparateCache();

		// Token: 0x06007459 RID: 29785 RVA: 0x000AAF37 File Offset: 0x000A9137
		public static bool IsUseVirtualTexturing(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsUseVirtualTexturing_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600745A RID: 29786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupportsMetalFx();

		// Token: 0x0600745B RID: 29787 RVA: 0x000AAF4E File Offset: 0x000A914E
		public static bool IsStreamingSourceInSide(UObject WorldContextObject, EStreamingSourcePriority StreamingSourcePriority, in FVector Origin, in FVector Extent)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsStreamingSourceInSide_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, StreamingSourcePriority, Origin, Extent);
		}

		// Token: 0x0600745C RID: 29788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSSDDevice();

		// Token: 0x0600745D RID: 29789 RVA: 0x000AAF68 File Offset: 0x000A9168
		public static bool IsPostprocessMaterialActive(UObject WorldContextObject, int Handle)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsPostprocessMaterialActive_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Handle);
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x000AAF80 File Offset: 0x000A9180
		public static bool IsPositionInCaveOrRoom(UObject WorldContextObject, in FVector InPoisition)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsPositionInCaveOrRoom_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InPoisition);
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x000AAF98 File Offset: 0x000A9198
		public static bool IsNiagaraComplete(UNiagaraComponent NiagaraComponent)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsNiagaraComplete_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x000AAFAF File Offset: 0x000A91AF
		public static bool IsEditorOnlyActor(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsEditorOnlyActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x000AAFC6 File Offset: 0x000A91C6
		public static bool IsDistanceCull(UObject WorldContextObject, UNiagaraEffectType EffectType, in FVector Location)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsDistanceCull_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (EffectType != null) ? EffectType.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x000AAFEE File Offset: 0x000A91EE
		public static bool IsCurrentPlatformPC(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__IsCurrentPlatformPC_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007463 RID: 29795
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSP2RGB(FLinearColor hsp);

		// Token: 0x06007464 RID: 29796 RVA: 0x000AB008 File Offset: 0x000A9208
		[NullableContext(1)]
		public unsafe static bool HasKey([Nullable(2)] UObject WorldContextObject, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__HasKey_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x000AB03C File Offset: 0x000A923C
		public static void HasAnyObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__HasAnyObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x000AB054 File Offset: 0x000A9254
		public static void HasAllObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__HasAllObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x000AB06C File Offset: 0x000A926C
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

		// Token: 0x06007468 RID: 29800 RVA: 0x000AB0A0 File Offset: 0x000A92A0
		public static BP_EWorldType GetWorldType(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x000AB0B7 File Offset: 0x000A92B7
		public static AWorldSettings GetWorldSetting(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AWorldSettings>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldSetting_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x000AB0D3 File Offset: 0x000A92D3
		public static FVector GetWorldRebaseRelativePos(UObject WorldContextObject, in FVector InCurPos)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldRebaseRelativePos_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InCurPos);
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x000AB0EB File Offset: 0x000A92EB
		public static FVector GetWorldRebaseAbsoluePos(UObject WorldContextObject, in FVector InCurPos)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldRebaseAbsoluePos_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InCurPos);
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x000AB103 File Offset: 0x000A9303
		[NullableContext(1)]
		public static TArray<string> GetWorldPartitionAllDataLayerNames([Nullable(2)] UObject WorldContextObject)
		{
			return new TArray<string>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldPartitionAllDataLayerNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x000AB120 File Offset: 0x000A9320
		public static KuroFeatureLevel GetWorldFeatureLevel(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorldFeatureLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x000AB137 File Offset: 0x000A9337
		public static UWorld GetWorld(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x000AB153 File Offset: 0x000A9353
		[NullableContext(1)]
		public static string GetWindowsVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWindowsVersion_Internal());
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x000AB15F File Offset: 0x000A935F
		public static UObject GetWeatherDataRef(UObject WorldContextObject, FName Identifier)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetWeatherDataRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Identifier));
		}

		// Token: 0x06007471 RID: 29809
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVoltage();

		// Token: 0x06007472 RID: 29810 RVA: 0x000AB17C File Offset: 0x000A937C
		public unsafe static void GetViewportSizeInLink(UObject WorldContextObject, ref FVector2D ViewportSize)
		{
			fixed (FVector2D* ptr = &ViewportSize)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetViewportSizeInLink_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref ViewportSize);
			}
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x000AB1A8 File Offset: 0x000A93A8
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

		// Token: 0x06007474 RID: 29812 RVA: 0x000AB214 File Offset: 0x000A9414
		public unsafe static void GetVectorParameterValueRef(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, ref FLinearColor RefLinearColor)
		{
			fixed (FLinearColor* ptr = &RefLinearColor)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetVectorParameterValueRef_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, ref RefLinearColor);
			}
		}

		// Token: 0x06007475 RID: 29813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetSwapBufferTime();

		// Token: 0x06007476 RID: 29814 RVA: 0x000AB250 File Offset: 0x000A9450
		[NullableContext(1)]
		public static TArray<int> GetSupportedRefreshRates()
		{
			return new TArray<int>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSupportedRefreshRates_Internal(), null);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x000AB25D File Offset: 0x000A945D
		public static UWorldSubsystem GetSubsystem(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UWorldSubsystem> WorldSubsystemClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldSubsystem>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSubsystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldSubsystemClass._NativePtr));
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x000AB280 File Offset: 0x000A9480
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

		// Token: 0x06007479 RID: 29817 RVA: 0x000AB2CB File Offset: 0x000A94CB
		[NullableContext(1)]
		public static string GetSkeletalMaterialSlotName([Nullable(2)] USkeletalMesh Skel, int MaterialIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialSlotName_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero, MaterialIndex));
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x000AB2E8 File Offset: 0x000A94E8
		public static UMaterialInterface GetSkeletalMaterialInterface(USkeletalMesh Skel, int MaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialInterface_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero, MaterialIndex));
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x000AB305 File Offset: 0x000A9505
		public static int GetSkeletalMaterialCount(USkeletalMesh Skel)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetSkeletalMaterialCount_Internal((Skel != null) ? Skel.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x000AB31C File Offset: 0x000A951C
		public static AActor GetSceneInteractionLevelActor(ULevel InLevel)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetSceneInteractionLevelActor_Internal((InLevel != null) ? InLevel.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600747D RID: 29821
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneDepthShotNow();

		// Token: 0x0600747E RID: 29822
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorShotNow();

		// Token: 0x0600747F RID: 29823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorShotBeforeTonemap(bool bRelease = false);

		// Token: 0x06007480 RID: 29824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSceneColorContainLGUIShotNow();

		// Token: 0x06007481 RID: 29825 RVA: 0x000AB338 File Offset: 0x000A9538
		[NullableContext(1)]
		public static string GetRHIVendorName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIVendorName_Internal());
		}

		// Token: 0x06007482 RID: 29826
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRHIThreadTime();

		// Token: 0x06007483 RID: 29827 RVA: 0x000AB344 File Offset: 0x000A9544
		[NullableContext(1)]
		public static string GetRHIName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIName_Internal());
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x000AB350 File Offset: 0x000A9550
		[NullableContext(1)]
		public static string GetRHIDriverVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDriverVersion_Internal());
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x000AB35C File Offset: 0x000A955C
		[NullableContext(1)]
		public static string GetRHIDriverDate()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDriverDate_Internal());
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x000AB368 File Offset: 0x000A9568
		[NullableContext(1)]
		public static string GetRHIDeviceName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIDeviceName_Internal());
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x000AB374 File Offset: 0x000A9574
		[NullableContext(1)]
		public static string GetRHIAPIVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetRHIAPIVersion_Internal());
		}

		// Token: 0x06007488 RID: 29832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderThreadTime();

		// Token: 0x06007489 RID: 29833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern URayTracingSupport GetRayTracingSupportedType();

		// Token: 0x0600748A RID: 29834
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingSupported();

		// Token: 0x0600748B RID: 29835
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingShadowsSupported();

		// Token: 0x0600748C RID: 29836
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingShadowsEnable();

		// Token: 0x0600748D RID: 29837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingReflectionsSupported();

		// Token: 0x0600748E RID: 29838
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingReflectionsEnable();

		// Token: 0x0600748F RID: 29839
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetRayTracingEnable();

		// Token: 0x06007490 RID: 29840
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetRandomPointInAnnulus2D(FVector2D InnerOuterRadius, int RandomSeed = 0);

		// Token: 0x06007491 RID: 29841 RVA: 0x000AB380 File Offset: 0x000A9580
		public static bool GetPostProcessGIDataNames(UObject WorldContextObject, FVector WorldPosition, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutDANames)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetPostProcessGIDataNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition, (OutDANames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x000AB3A8 File Offset: 0x000A95A8
		public static bool GetPostProcessGIDataDebugNames(UObject WorldContextObject, ref TArray<FName> OutDANames)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetPostProcessGIDataDebugNames_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutDANames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x000AB3D0 File Offset: 0x000A95D0
		public unsafe static bool GetPlayerOrEditorCameraTransform(UObject WorldContextObject, ref FTransform OutCameraTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutCameraTransform;
			bool result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetPlayerOrEditorCameraTransform_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref ptr);
			OutCameraTransform = ptr;
			return result;
		}

		// Token: 0x06007494 RID: 29844
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPhysicalGBRam();

		// Token: 0x06007495 RID: 29845 RVA: 0x000AB41C File Offset: 0x000A961C
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

		// Token: 0x06007496 RID: 29846 RVA: 0x000AB470 File Offset: 0x000A9670
		public static int GetOverlappingBoxCountForAllFoliageActors(UObject WorldContextObject, UFoliageType FoliageType, in FBox Box, int Max)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetOverlappingBoxCountForAllFoliageActors_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FoliageType != null) ? FoliageType.NativePtr : IntPtr.Zero, Box, Max);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x000AB499 File Offset: 0x000A9699
		public static int GetObjectMaskedFlags(UObject Object, int Mask)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetObjectMaskedFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, Mask);
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x000AB4B1 File Offset: 0x000A96B1
		public static int GetObjectFilterStateID(UObject Object, int ExtraID = 0)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetObjectFilterStateID_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, ExtraID);
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x000AB4CC File Offset: 0x000A96CC
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

		// Token: 0x0600749A RID: 29850 RVA: 0x000AB500 File Offset: 0x000A9700
		[NullableContext(1)]
		public static string GetMobileDeviceModel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetMobileDeviceModel_Internal());
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x000AB50C File Offset: 0x000A970C
		[NullableContext(1)]
		public static string GetMobileDeviceMake()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetMobileDeviceMake_Internal());
		}

		// Token: 0x0600749C RID: 29852
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMaxFps();

		// Token: 0x0600749D RID: 29853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenReflectionsSupported();

		// Token: 0x0600749E RID: 29854
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenReflectionsEnable();

		// Token: 0x0600749F RID: 29855
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenGISupported();

		// Token: 0x060074A0 RID: 29856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLumenGIEnable();

		// Token: 0x060074A1 RID: 29857 RVA: 0x000AB518 File Offset: 0x000A9718
		public static bool GetLumenDiffuseGIFeatureEnabled(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetLumenDiffuseGIFeatureEnabled_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x000AB530 File Offset: 0x000A9730
		public unsafe static bool GetLevelEditorViewPortSize(UObject WorldContextObject, ref FVector2D viewPortSize)
		{
			fixed (FVector2D* ptr = &viewPortSize)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevelEditorViewPortSize_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref viewPortSize);
			}
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x000AB558 File Offset: 0x000A9758
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

		// Token: 0x060074A4 RID: 29860 RVA: 0x000AB586 File Offset: 0x000A9786
		[NullableContext(1)]
		public static TArray<AActor> GetLevelActors([Nullable(2)] ULevel InLevel)
		{
			return new TArray<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevelActors_Internal((InLevel != null) ? InLevel.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x000AB5A3 File Offset: 0x000A97A3
		public static ULevel GetLevel(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetLevel_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x000AB5C0 File Offset: 0x000A97C0
		[NullableContext(1)]
		public unsafe static int GetInt([Nullable(2)] UObject WorldContextObject, string Key, int DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			int result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetInt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x000AB5F5 File Offset: 0x000A97F5
		public static AActor GetGlobalGIActor(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGlobalGIActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x000AB611 File Offset: 0x000A9811
		public static UPhysicalMaterial GetGlobalFootstepMaterial(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGlobalFootstepMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x000AB62D File Offset: 0x000A982D
		public static AActor GetGITransientActor(UObject WorldContextObject, FName IdName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName));
		}

		// Token: 0x060074AA RID: 29866
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetGameViewportSize();

		// Token: 0x060074AB RID: 29867
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameThreadTime();

		// Token: 0x060074AC RID: 29868
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetGameResolution();

		// Token: 0x060074AD RID: 29869 RVA: 0x000AB64C File Offset: 0x000A984C
		[NullableContext(1)]
		public unsafe static float GetFloat([Nullable(2)] UObject WorldContextObject, string Key, float DefaultValue)
		{
			FString fstring = FString.AllocTemp(Key);
			float result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetFloat_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, DefaultValue);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x000AB681 File Offset: 0x000A9881
		public static UEngineSubsystem GetEngineSubsystem([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEngineSubsystem> EngineSubsystem)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEngineSubsystem>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetEngineSubsystem_Internal(EngineSubsystem._NativePtr));
		}

		// Token: 0x060074AF RID: 29871
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetDriverValid();

		// Token: 0x060074B0 RID: 29872 RVA: 0x000AB693 File Offset: 0x000A9893
		public static bool GetDisableNPCOptAsRayTracing(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetDisableNPCOptAsRayTracing_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x000AB6AA File Offset: 0x000A98AA
		[NullableContext(1)]
		public static string GetDeviceProfileProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileProfileName_Internal());
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x000AB6B6 File Offset: 0x000A98B6
		[NullableContext(1)]
		public static string GetDeviceProfileDeviceType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileDeviceType_Internal());
		}

		// Token: 0x060074B3 RID: 29875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDeviceProfileDeviceScore();

		// Token: 0x060074B4 RID: 29876 RVA: 0x000AB6C2 File Offset: 0x000A98C2
		[NullableContext(1)]
		public static string GetDeviceProfileBaseProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetDeviceProfileBaseProfileName_Internal());
		}

		// Token: 0x060074B5 RID: 29877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDeviceHardwareLevel();

		// Token: 0x060074B6 RID: 29878 RVA: 0x000AB6D0 File Offset: 0x000A98D0
		[NullableContext(1)]
		public unsafe static string GetCVarString(string CVarKey)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			string result = FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCVarString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x000AB6FC File Offset: 0x000A98FC
		[NullableContext(1)]
		public unsafe static float GetCVarFloat(string CVarKey)
		{
			FString fstring = FString.AllocTemp(CVarKey);
			float result = UKuroRenderingRuntimeBPPluginBPLibrary.__GetCVarFloat_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060074B8 RID: 29880
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentNow();

		// Token: 0x060074B9 RID: 29881
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuUsage();

		// Token: 0x060074BA RID: 29882
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuTemperature();

		// Token: 0x060074BB RID: 29883
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUFrequency();

		// Token: 0x060074BC RID: 29884
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCpuFreq(int core);

		// Token: 0x060074BD RID: 29885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUCoresIncludingHyperthreads();

		// Token: 0x060074BE RID: 29886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCPUCores();

		// Token: 0x060074BF RID: 29887 RVA: 0x000AB720 File Offset: 0x000A9920
		[NullableContext(1)]
		public static string GetCPUBrand()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCPUBrand_Internal());
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x000AB72C File Offset: 0x000A992C
		public static FTransform GetComponentToWorldNoWorldOffset(USceneComponent Component)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentToWorldNoWorldOffset_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x000AB743 File Offset: 0x000A9943
		public static UPhysicalMaterial GetComponentPhysicalMaterial(UPrimitiveComponent Component)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentPhysicalMaterial_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x000AB75F File Offset: 0x000A995F
		public static FVector GetComponentLocationNoWorldOffset(USceneComponent Component)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetComponentLocationNoWorldOffset_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x000AB776 File Offset: 0x000A9976
		public static int GetCharacterSectionMaterialIndex(USkeletalMesh SkeletalMesh, int SectionIndex)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionMaterialIndex_Internal((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero, SectionIndex);
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x000AB78E File Offset: 0x000A998E
		[NullableContext(1)]
		public static TArray<int> GetCharacterSectionInfo([Nullable(2)] USkeletalMesh Mesh, int SectionIndex)
		{
			return new TArray<int>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionInfo_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero, SectionIndex), null);
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x000AB7AC File Offset: 0x000A99AC
		public static int GetCharacterSectionCount(USkeletalMesh Mesh)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterSectionCount_Internal((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x000AB7C3 File Offset: 0x000A99C3
		public static bool GetCharacterInBattle(UObject WorldContextObject)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetCharacterInBattle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x000AB7DA File Offset: 0x000A99DA
		public static FQuat GetBoneDirection(USkeletalMeshComponent SkeletalMeshComponent, FName BoneName)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetBoneDirection_Internal((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, BoneName);
		}

		// Token: 0x060074C8 RID: 29896
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetBatteryTemperature();

		// Token: 0x060074C9 RID: 29897 RVA: 0x000AB7F2 File Offset: 0x000A99F2
		[NullableContext(1)]
		public static TArray<FAssetData> GetAssetsByPath(FName PackagePath, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
		{
			return new TArray<FAssetData>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetAssetsByPath_Internal(PackagePath, bRecursive, bIncludeOnlyOnDiskAssets), null);
		}

		// Token: 0x060074CA RID: 29898
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetAndroidRawResolution();

		// Token: 0x060074CB RID: 29899 RVA: 0x000AB804 File Offset: 0x000A9A04
		public unsafe static float GetAndAddCurveFloatSampleTask(UObject WorldContextObject, long LastFrameHandle, in FKuroCurveFloat Curve, float Time, float Default, ref long OutHandle)
		{
			fixed (long* ptr = &OutHandle)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__GetAndAddCurveFloatSampleTask_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LastFrameHandle, (Curve ?? new FKuroCurveFloat()).NativePtr, Time, Default, ref OutHandle);
			}
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x000AB842 File Offset: 0x000A9A42
		[NullableContext(1)]
		public static string GetAdapterUserDriverVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroRenderingRuntimeBPPluginBPLibrary.__GetAdapterUserDriverVersion_Internal());
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x000AB84E File Offset: 0x000A9A4E
		public static FTransform GetActorTransformNoWorldOffset(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorTransformNoWorldOffset_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x000AB865 File Offset: 0x000A9A65
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

		// Token: 0x060074CF RID: 29903 RVA: 0x000AB892 File Offset: 0x000A9A92
		public static AActor GetActorOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr));
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x000AB8B4 File Offset: 0x000A9AB4
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

		// Token: 0x060074D1 RID: 29905 RVA: 0x000AB8F8 File Offset: 0x000A9AF8
		public unsafe static void GetActorLocationRef(AActor Actor, ref FVector RefLocation)
		{
			fixed (FVector* ptr = &RefLocation)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorLocationRef_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref RefLocation);
			}
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x000AB923 File Offset: 0x000A9B23
		public static FVector GetActorLocationNoWorldOffset(AActor Actor)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorLocationNoWorldOffset_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x000AB93C File Offset: 0x000A9B3C
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

		// Token: 0x060074D4 RID: 29908 RVA: 0x000AB980 File Offset: 0x000A9B80
		public unsafe static void GetActorForwardVectorRef(AActor Actor, ref FVector RefForwardVector)
		{
			fixed (FVector* ptr = &RefForwardVector)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__GetActorForwardVectorRef_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref RefForwardVector);
			}
		}

		// Token: 0x060074D5 RID: 29909
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double FS_PointToIndex_Local_Double(in FVector OriginLocal, in FVector PointLocal, int N);

		// Token: 0x060074D6 RID: 29910
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FS_PointToIndex_Local(in FVector OriginLocal, in FVector PointLocal, int N);

		// Token: 0x060074D7 RID: 29911
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FS_IsPointInTriangle_ZProjection(in FVector P, in FVector A, in FVector B, in FVector C, ref float OutDistance, float Epsilon = 1E-06f);

		// Token: 0x060074D8 RID: 29912
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FS_IsPointInTriangle(in FVector2D P, in FVector2D A, in FVector2D B, in FVector2D C);

		// Token: 0x060074D9 RID: 29913
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FS_IndexToAngle(int Index, int N);

		// Token: 0x060074DA RID: 29914 RVA: 0x000AB9AC File Offset: 0x000A9BAC
		public unsafe static bool FS_DetectPlayer_Two(double Index, int ParticleCount, in TArray<float> Dis, in TArray<FVector> Dirs, in FVector PlayerPos, in FVector WorldPos, in FRotator Rotator, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_DetectPlayer_Two_Internal(Index, ParticleCount, (Dis ?? new TArray<float>()).NativePtr, (Dirs ?? new TArray<FVector>()).NativePtr, PlayerPos, WorldPos, Rotator, ref OutDistance);
			}
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x000AB9F0 File Offset: 0x000A9BF0
		public unsafe static bool FS_DetectPlayer(int Index, int ParticleCount, in TArray<FVector> EndPos, in FVector PlayerPos, in FVector WorldPos, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_DetectPlayer_Internal(Index, ParticleCount, (EndPos ?? new TArray<FVector>()).NativePtr, PlayerPos, WorldPos, ref OutDistance);
			}
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x000ABA20 File Offset: 0x000A9C20
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

		// Token: 0x060074DD RID: 29917 RVA: 0x000ABA68 File Offset: 0x000A9C68
		public unsafe static FRotator FS_ComputeTilt_ByHeightH(in FTransform PlaneTransform, float Radius, in FVector PersonWorld, double H, double MaxDegreeAngle, double MinActiveRadius, double MaxActiveRadius, bool bPlayerColliding, double FollowSpeedDegPerSec, double ReturnSpeedDegPerSec, float DeltaSeconds, bool bNeedReturnOrNot)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = PlaneTransform;
			return UKuroRenderingRuntimeBPPluginBPLibrary.__FS_ComputeTilt_ByHeightH_Internal(uintPtr, Radius, PersonWorld, H, MaxDegreeAngle, MinActiveRadius, MaxActiveRadius, bPlayerColliding, FollowSpeedDegPerSec, ReturnSpeedDegPerSec, DeltaSeconds, bNeedReturnOrNot);
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x000ABAA8 File Offset: 0x000A9CA8
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

		// Token: 0x060074DF RID: 29919 RVA: 0x000ABB5C File Offset: 0x000A9D5C
		public unsafe static void FS_CheckFrontObstacle(float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<FName> ParamNames, UMaterialInstanceDynamic MID, bool debugLine, int CountIndex)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__FS_CheckFrontObstacle_Internal(RayCastingDetectDis, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TraceChannel, Rotator, WorldPosition, ref OutDistance, (Dir ?? new TArray<FVector>()).NativePtr, (EndPos ?? new TArray<FVector>()).NativePtr, (ParamNames ?? new TArray<FName>()).NativePtr, (MID != null) ? MID.NativePtr : IntPtr.Zero, debugLine, CountIndex);
			}
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x000ABBDC File Offset: 0x000A9DDC
		public static void FreezeWorldLevelStreaming(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__FreezeWorldLevelStreaming_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x000ABBF4 File Offset: 0x000A9DF4
		public unsafe static void FilterWeaponSweepPosition(UObject WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool ValidBool, int FilterStateID = 0, float ValidTimeWindow = 0.1f, float SpeedThreshold = 10f, float AlternatingPointTolerance = 1f, float ReverseDirectionDotThreshold = -0.85f)
		{
			fixed (bool* ptr = &ValidBool)
			{
				void* ptr2 = (void*)ptr;
				UKuroRenderingRuntimeBPPluginBPLibrary.__FilterWeaponSweepPosition_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HitPos, WeaponTypeID, ref ValidBool, FilterStateID, ValidTimeWindow, SpeedThreshold, AlternatingPointTolerance, ReverseDirectionDotThreshold);
			}
		}

		// Token: 0x060074E2 RID: 29922
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DoesDeviceSupportVariableRateShading();

		// Token: 0x060074E3 RID: 29923 RVA: 0x000ABC2B File Offset: 0x000A9E2B
		public static void DestroyGITransientActor(UObject WorldContextObject, FName IdName)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__DestroyGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName);
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x000ABC44 File Offset: 0x000A9E44
		[NullableContext(1)]
		public unsafe static void DeleteKey([Nullable(2)] UObject WorldContextObject, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UKuroRenderingRuntimeBPPluginBPLibrary.__DeleteKey_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x000ABC78 File Offset: 0x000A9E78
		public static void DeleteAll(UObject WorldContextObject)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__DeleteAll_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x000ABC90 File Offset: 0x000A9E90
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

		// Token: 0x060074E7 RID: 29927 RVA: 0x000ABD01 File Offset: 0x000A9F01
		public static AActor CreateGITransientActor(UObject WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera, FName EditorFolderPath)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroRenderingRuntimeBPPluginBPLibrary.__CreateGITransientActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, IdName, bAttachToPlayer, bAttachToEditorCamera, EditorFolderPath));
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x000ABD24 File Offset: 0x000A9F24
		[NullableContext(1)]
		public unsafe static void ClipboardPaste_EditorOnly(ref string Dest)
		{
			FString fstring = FString.AllocTemp(Dest);
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClipboardPaste_EditorOnly_Internal(ref fstring);
			Dest = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x000ABD54 File Offset: 0x000A9F54
		[NullableContext(1)]
		public unsafe static void ClipboardCopy_EditorOnly(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClipboardCopy_EditorOnly_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x000ABD78 File Offset: 0x000A9F78
		public static void ClearObjectFlags(UObject Object, int flags)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__ClearObjectFlags_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, flags);
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x000ABD90 File Offset: 0x000A9F90
		public static void CatmullRomPointsFromLists(TArray<FVectorDouble> PointList, ref TArray<FVector2D> CurveList, float alpha, float tension, int Step)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CatmullRomPointsFromLists_Internal((PointList ?? new TArray<FVectorDouble>()).NativePtr, (CurveList ?? new TArray<FVector2D>()).NativePtr, alpha, tension, Step);
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x000ABDBA File Offset: 0x000A9FBA
		public static void CatmullRomPoints(FVector2D P0, FVector2D P1, FVector2D P2, FVector2D P3, ref TArray<FVector2D> CurveList, float alpha = 0.5f, float tension = 0f, int Step = 4)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.__CatmullRomPoints_Internal(P0, P1, P2, P3, (CurveList ?? new TArray<FVector2D>()).NativePtr, alpha, tension, Step);
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x000ABDDC File Offset: 0x000A9FDC
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

		// Token: 0x060074EE RID: 29934
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CanCutBelowLastHit(bool bHasLastCut, FVector LastHitPoint, FVector CurrentHitPoint, FVector BambooUpVector, FVector PlaneNormal, ref FVector OutCorrectedPlanePosition, ref FVector OutCorrectedPlaneNormal, ref float OutMaxAllowedHeightAlongUp, float MinCutDistance = 0f, float MaxPlaneNormalAngleFromUpDegrees = 60f);

		// Token: 0x060074EF RID: 29935 RVA: 0x000ABE3C File Offset: 0x000AA03C
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

		// Token: 0x060074F0 RID: 29936 RVA: 0x000ABE92 File Offset: 0x000AA092
		public static bool ApplyDreamReflectionCaptureParameters(USceneCaptureComponent2D CaptureComponent, UTextureRenderTarget2D RenderTarget, UMaterialInstanceDynamic MaterialInstance)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__ApplyDreamReflectionCaptureParameters_Internal((CaptureComponent != null) ? CaptureComponent.NativePtr : IntPtr.Zero, (RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, (MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x000ABEC9 File Offset: 0x000AA0C9
		public static bool AddWeatherDataType(UObject WorldContextObject, FName Identifier, UClassStackOnlyPtr ClassType)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__AddWeatherDataType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Identifier, ClassType._NativePtr);
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x000ABEE7 File Offset: 0x000AA0E7
		public static int AddPostprocessMaterial(UObject WorldContextObject, UMaterialInterface Material, float Priority, bool bIsUiPostprocess = false)
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.__AddPostprocessMaterial_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero, Priority, bIsUiPostprocess);
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x000ABF10 File Offset: 0x000AA110
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

		// Token: 0x060074F4 RID: 29940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteRenderTargetColorEditorOnly_Internal(IntPtr RT, IntPtr Colors);

		// Token: 0x060074F5 RID: 29941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpPEnterCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x060074F6 RID: 29942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpLeaveCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x060074F7 RID: 29943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpCancelAdjustLoadRange_Internal(IntPtr WorldContextObject);

		// Token: 0x060074F8 RID: 29944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpBeginLeaveCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x060074F9 RID: 29945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WpBeginEnterCaveOrRoom_Internal(IntPtr WorldContextObject, in FName EncloseDataLayer, in FName EncloseSubDataLayer);

		// Token: 0x060074FA RID: 29946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WeaponInteractCollisionAnyHit_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, ref FString DebugInfo);

		// Token: 0x060074FB RID: 29947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WeaponInteractCollision_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, IntPtr HitComponent, float SweepRadius, float SpeedThreshold, float ValidTimeWindow, bool bShowTrace, float TraceDebugLifeTime, ref bool HitBool, ref bool ValidBool, ref FVector OutHitPoint, ref FVector OutPos, ref FVector OutPosPre, ref FString DebugInfo);

		// Token: 0x060074FC RID: 29948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateOrAddCurveFloatValue_Internal(IntPtr Curve, float InTime, float InValue);

		// Token: 0x060074FD RID: 29949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateFoliageDataLayer_Internal(IntPtr WorldContextObject, int InMobileLevel);

		// Token: 0x060074FE RID: 29950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectTransformLocation_Internal(bool ForceUpdate, IntPtr SceneComponent, IntPtr LocationCurve, float Time);

		// Token: 0x060074FF RID: 29951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectTransform_Internal(bool ForceUpdate, IntPtr SceneComponent, IntPtr LocationCurve, IntPtr RotationCurve, IntPtr ScaleCurve, float Time);

		// Token: 0x06007500 RID: 29952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBridgeParticleConstraint_Internal(IntPtr posArrL, IntPtr posArrR, float plankRestLength, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, int numIterations);

		// Token: 0x06007501 RID: 29953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBridgeFakeCollision_Internal(IntPtr posArrL, IntPtr posArrR, in FVector cylinderCenter, in FVector cylinderAxis, float cylinderRadius, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, int numIterations, in FVector playerPos, float playerCollisionRadius, float playerPushStrength);

		// Token: 0x06007502 RID: 29954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdataPlaneList_PBD_WithChainState_Internal(IntPtr Components, IntPtr posArrL, IntPtr posArrR, IntPtr chainLinkMaskL, IntPtr chainLinkMaskR, FVector bridgeDir);

		// Token: 0x06007503 RID: 29955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdataPlaneList_PBD_Internal(IntPtr Components, IntPtr posArr, IntPtr posArrR);

		// Token: 0x06007504 RID: 29956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnFreezeWorldLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x06007505 RID: 29957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncBridgeChainVelocityAfterPostSteps_Internal(IntPtr posArr, IntPtr posFoeSnapshot, IntPtr volArr, bool isFirstFrame, float volDamping, float dt);

		// Token: 0x06007506 RID: 29958
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SweptBladeTraceComponent_Internal(IntPtr WorldContextObject, IntPtr TargetComponent, FVector PrevRootPoint, FVector CurrRootPoint, FVector PrevTipPoint, FVector CurrTipPoint, float SweepRadius, int MaxSampleCount, IntPtr OutHit, ref int ActualSampleCount, bool bShowTrace, bool bTraceComplex, bool bUseWorldSweepByChannel, TEnumAsByte<ETraceTypeQuery> TraceChannel, FLinearColor TraceColor, FLinearColor TraceHitColor);

		// Token: 0x06007507 RID: 29959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SuppressProceduralMeshLocalZAngularVelocity_Internal(IntPtr ProceduralMeshComp);

		// Token: 0x06007508 RID: 29960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSomeWeatherBeforeTeleport_Internal(IntPtr WorldContextObject);

		// Token: 0x06007509 RID: 29961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnTransientActor_Internal(IntPtr WorldContextObject, in FName Name, in FName FolderPath);

		// Token: 0x0600750A RID: 29962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator, bool bTemporaryEditorActor);

		// Token: 0x0600750B RID: 29963
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortStringArray_Internal(IntPtr InStringArray, TEnumAsByte<ESearchCase> SearchCase, bool Descending);

		// Token: 0x0600750C RID: 29964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortStaticMeshComponentsByName_Internal(IntPtr Components, IntPtr SortedComponents);

		// Token: 0x0600750D RID: 29965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionStreamingEnable_Internal(IntPtr WorldContextObject, bool bStreamingEnable);

		// Token: 0x0600750E RID: 29966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionDataLayerState2_Internal(IntPtr WorldContextObject, FName DataLayerName, EDataLayerState NewState);

		// Token: 0x0600750F RID: 29967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldPartitionDataLayerState_Internal(IntPtr WorldContextObject, FName DataLayerName, bool IsActivate);

		// Token: 0x06007510 RID: 29968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr WorldContextObject, in FVectorDouble InNewOrigin);

		// Token: 0x06007511 RID: 29969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValueRef_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref FLinearColor RefLinearColor);

		// Token: 0x06007512 RID: 29970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupVolumeSize_Internal(IntPtr Volume, in FBox Bounds);

		// Token: 0x06007513 RID: 29971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformLocationInArray_Internal(IntPtr TransformArray, int index, in FVector Location);

		// Token: 0x06007514 RID: 29972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSunLensflareEnabled_Internal(IntPtr WorldContextObject, bool bEnabled);

		// Token: 0x06007515 RID: 29973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetString_Internal(IntPtr WorldContextObject, in FString Key, in FString Value);

		// Token: 0x06007516 RID: 29974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneRenderingState_Internal(IntPtr WorldContextObject, bool bSceneVisible);

		// Token: 0x06007517 RID: 29975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneKuroViewCenter_Internal(IntPtr WorldContextObject, FVector Location);

		// Token: 0x06007518 RID: 29976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneKuroMainPlayerLocation_Internal(IntPtr WorldContextObject, int PlayerIndex);

		// Token: 0x06007519 RID: 29977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetSceneCaptureOffAxisProjection_Internal(IntPtr CaptureComponent, float Left, float Right, float Bottom, float Top, float NearPlane);

		// Token: 0x0600751A RID: 29978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOtherCharacterFootWP_Internal(IntPtr WorldContextObject, IntPtr Collection, IntPtr OtherCharacter, FVector CharacterPos);

		// Token: 0x0600751B RID: 29979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0600751C RID: 29980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSplineComponent_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SplineComponent);

		// Token: 0x0600751D RID: 29981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSkeletalMeshComponentWithoutWarning_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SkeletalMeshComponent);

		// Token: 0x0600751E RID: 29982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraMultiSplineSource_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SourceActor);

		// Token: 0x0600751F RID: 29983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraMultiSplineComponents_Internal(IntPtr NiagaraSystem, in FString OverrideName, IntPtr SplineComponents);

		// Token: 0x06007520 RID: 29984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLevelEditorCameraLocation_Internal(IntPtr WorldContextObject, FVector Position);

		// Token: 0x06007521 RID: 29985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUsingInCaveOrIndoorShadow_Internal(IntPtr WorldContextObject, bool IsUsing, float MobileCSMDistanceInCave, float MobileCSMDistanceOutCave);

		// Token: 0x06007522 RID: 29986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntsDataToRenderTarget_Internal(IntPtr TextureRenderTarget, IntPtr WriteData);

		// Token: 0x06007523 RID: 29987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt_Internal(IntPtr WorldContextObject, in FString Key, int Value);

		// Token: 0x06007524 RID: 29988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetGlobalGITime_Internal(IntPtr WorldContextObject, float Time);

		// Token: 0x06007525 RID: 29989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGITransientActorAttachment_Internal(IntPtr WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera);

		// Token: 0x06007526 RID: 29990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloat_Internal(IntPtr WorldContextObject, in FString Key, float Value);

		// Token: 0x06007527 RID: 29991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableEffectPostProcessVolume_Internal(IntPtr WorldContextObject, bool bDisable, float ChangeSpeed);

		// Token: 0x06007528 RID: 29992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCVarInt32_Internal(in FString CVarKey, int Value);

		// Token: 0x06007529 RID: 29993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCVarFloat_Internal(in FString CVarKey, float Value);

		// Token: 0x0600752A RID: 29994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClusteredStuffVisible_Internal(IntPtr WorldContextObject, bool Visible);

		// Token: 0x0600752B RID: 29995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterInBattle_Internal(IntPtr WorldContextObject, bool bInBattle);

		// Token: 0x0600752C RID: 29996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __SetCharacterFootWP_Internal(IntPtr WorldContextObject, IntPtr Collection, IntPtr CharacterMesh);

		// Token: 0x0600752D RID: 29997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorUISceneRendering_Internal(IntPtr Actor, bool IsUISceneRendering);

		// Token: 0x0600752E RID: 29998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(IntPtr WorldContextObject);

		// Token: 0x0600752F RID: 29999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeSomeWeatherAfterTeleport_Internal(IntPtr WorldContextObject);

		// Token: 0x06007530 RID: 30000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResizeRenderTarget2D_Internal(IntPtr TextureRenderTarget, int InSizeX, int InSizeY);

		// Token: 0x06007531 RID: 30001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RerunConstructionScripts_Internal(IntPtr Actor);

		// Token: 0x06007532 RID: 30002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePostprocessMaterial_Internal(IntPtr WorldContextObject, int Handle);

		// Token: 0x06007533 RID: 30003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreenWithLevelEditorViewPortFloatRef_Internal(IntPtr WorldContextObject, in FVector WorldPosition, ref float ResultX, ref float ResultY, ref float ResultZ, ref float ResultW);

		// Token: 0x06007534 RID: 30004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToScreenWithLevelEditorViewPort_Internal(IntPtr WorldContextObject, in FVector worldPosition, ref FVector4 result);

		// Token: 0x06007535 RID: 30005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDChainParallel_MY_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, bool doParallel);

		// Token: 0x06007536 RID: 30006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDChain_MY_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, float linkDis, in FVector emitterOriginPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos);

		// Token: 0x06007537 RID: 30007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDBridge_RealModelBroken_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, IntPtr foeDisList, IntPtr nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength, bool bBroken, int breakLeftIndex, IntPtr outParticleChainLinkMask, int breakExtraTowardStart, int breakExtraTowardEnd, float brokenDetachedEndsGravityAsym, float groundPlaneWorldZ, FVector brokenSimAccelExt, float brokenSimVolDamping);

		// Token: 0x06007538 RID: 30008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PBDBridge_RealModel_Internal(IntPtr posArr, IntPtr volArr, IntPtr posArrFoe, IntPtr foeDisList, IntPtr nxtDisList, float linkDisScale, in FVector startPinPos, in FVector endPinPos, in FVector accel_ext, float collisionR, bool isFirstFrame, float volDamping, float dt, in FVector playerPos, in FVector bridgeDir, float pushStrength);

		// Token: 0x06007539 RID: 30009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveCurveFloatValueToOtherTime_Internal(IntPtr Curve, float SrcTime, float TargetTime);

		// Token: 0x0600753A RID: 30010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MessageNotify_EditorOnly_Internal(IntPtr Message, FName Tile);

		// Token: 0x0600753B RID: 30011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MaterialHasParameter_EditorOnly_Internal(IntPtr MaterialInterface, in FString ParameterName);

		// Token: 0x0600753C RID: 30012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkWorldPostProcessPriorityDirty_Internal(IntPtr WorldContextObject);

		// Token: 0x0600753D RID: 30013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockProceduralMeshZRotation_Internal(IntPtr ProceduralMeshComp, bool bLock);

		// Token: 0x0600753E RID: 30014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroMarkPackageDirty_Internal(IntPtr Object);

		// Token: 0x0600753F RID: 30015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __KuroBuoyancyCalculation_Internal(IntPtr MeshComponent, IntPtr SphereList, float WaterHeight, FVector BuoyancyMagnitude);

		// Token: 0x06007540 RID: 30016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWpPlayerInCaveOrRoom_Internal(IntPtr WorldContextObject);

		// Token: 0x06007541 RID: 30017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldPartitionWorld_Internal(IntPtr WorldContextObject);

		// Token: 0x06007542 RID: 30018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldPartitionDataLayerEnable_Internal(IntPtr WorldContextObject, FName DataLayerName);

		// Token: 0x06007543 RID: 30019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldOriginVisibilityRequestPending_Internal(IntPtr WorldContextObject);

		// Token: 0x06007544 RID: 30020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldOriginFinish_Internal(IntPtr WorldContextObject);

		// Token: 0x06007545 RID: 30021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUseVirtualTexturing_Internal(IntPtr Actor);

		// Token: 0x06007546 RID: 30022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingSourceInSide_Internal(IntPtr WorldContextObject, EStreamingSourcePriority StreamingSourcePriority, in FVector Origin, in FVector Extent);

		// Token: 0x06007547 RID: 30023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPostprocessMaterialActive_Internal(IntPtr WorldContextObject, int Handle);

		// Token: 0x06007548 RID: 30024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPositionInCaveOrRoom_Internal(IntPtr WorldContextObject, in FVector InPoisition);

		// Token: 0x06007549 RID: 30025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNiagaraComplete_Internal(IntPtr NiagaraComponent);

		// Token: 0x0600754A RID: 30026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEditorOnlyActor_Internal(IntPtr Actor);

		// Token: 0x0600754B RID: 30027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDistanceCull_Internal(IntPtr WorldContextObject, IntPtr EffectType, in FVector Location);

		// Token: 0x0600754C RID: 30028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCurrentPlatformPC_Internal(IntPtr Actor);

		// Token: 0x0600754D RID: 30029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKey_Internal(IntPtr WorldContextObject, in FString Key);

		// Token: 0x0600754E RID: 30030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HasAnyObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x0600754F RID: 30031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HasAllObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x06007550 RID: 30032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetWpWorldBound_Internal(IntPtr WorldContextObject, ref FVector BoundMin, ref FVector BoundMax);

		// Token: 0x06007551 RID: 30033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern BP_EWorldType __GetWorldType_Internal(IntPtr WorldContextObject);

		// Token: 0x06007552 RID: 30034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldSetting_Internal(IntPtr WorldContextObject);

		// Token: 0x06007553 RID: 30035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldRebaseRelativePos_Internal(IntPtr WorldContextObject, in FVector InCurPos);

		// Token: 0x06007554 RID: 30036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldRebaseAbsoluePos_Internal(IntPtr WorldContextObject, in FVector InCurPos);

		// Token: 0x06007555 RID: 30037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldPartitionAllDataLayerNames_Internal(IntPtr WorldContextObject);

		// Token: 0x06007556 RID: 30038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern KuroFeatureLevel __GetWorldFeatureLevel_Internal(IntPtr WorldContextObject);

		// Token: 0x06007557 RID: 30039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorld_Internal(IntPtr WorldContextObject);

		// Token: 0x06007558 RID: 30040
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWindowsVersion_Internal();

		// Token: 0x06007559 RID: 30041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWeatherDataRef_Internal(IntPtr WorldContextObject, FName Identifier);

		// Token: 0x0600755A RID: 30042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetViewportSizeInLink_Internal(IntPtr WorldContextObject, ref FVector2D ViewportSize);

		// Token: 0x0600755B RID: 30043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVectorParameterValueRefRGBA_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref float RefLinearColorR, ref float RefLinearColorG, ref float RefLinearColorB, ref float RefLinearColorA);

		// Token: 0x0600755C RID: 30044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVectorParameterValueRef_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, ref FLinearColor RefLinearColor);

		// Token: 0x0600755D RID: 30045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedRefreshRates_Internal();

		// Token: 0x0600755E RID: 30046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubsystem_Internal(IntPtr WorldContextObject, IntPtr WorldSubsystemClass);

		// Token: 0x0600755F RID: 30047
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetString_Internal(IntPtr WorldContextObject, in FString Key, in FString DefaultValue);

		// Token: 0x06007560 RID: 30048
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSkeletalMaterialSlotName_Internal(IntPtr Skel, int MaterialIndex);

		// Token: 0x06007561 RID: 30049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkeletalMaterialInterface_Internal(IntPtr Skel, int MaterialIndex);

		// Token: 0x06007562 RID: 30050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSkeletalMaterialCount_Internal(IntPtr Skel);

		// Token: 0x06007563 RID: 30051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneInteractionLevelActor_Internal(IntPtr InLevel);

		// Token: 0x06007564 RID: 30052
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIVendorName_Internal();

		// Token: 0x06007565 RID: 30053
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIName_Internal();

		// Token: 0x06007566 RID: 30054
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDriverVersion_Internal();

		// Token: 0x06007567 RID: 30055
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDriverDate_Internal();

		// Token: 0x06007568 RID: 30056
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIDeviceName_Internal();

		// Token: 0x06007569 RID: 30057
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRHIAPIVersion_Internal();

		// Token: 0x0600756A RID: 30058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPostProcessGIDataNames_Internal(IntPtr WorldContextObject, FVector WorldPosition, IntPtr OutDANames);

		// Token: 0x0600756B RID: 30059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPostProcessGIDataDebugNames_Internal(IntPtr WorldContextObject, IntPtr OutDANames);

		// Token: 0x0600756C RID: 30060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPlayerOrEditorCameraTransform_Internal(IntPtr WorldContextObject, ref FTransform OutCameraTransform);

		// Token: 0x0600756D RID: 30061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPcLightCullParameters_Internal(IntPtr LightComponent, ref float LightMinDistance, ref float LightMaxDistance, ref float LightMinFade, ref float LightMaxFade);

		// Token: 0x0600756E RID: 30062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOverlappingBoxCountForAllFoliageActors_Internal(IntPtr WorldContextObject, IntPtr FoliageType, in FBox Box, int Max);

		// Token: 0x0600756F RID: 30063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetObjectMaskedFlags_Internal(IntPtr Object, int Mask);

		// Token: 0x06007570 RID: 30064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetObjectFilterStateID_Internal(IntPtr Object, int ExtraID);

		// Token: 0x06007571 RID: 30065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNiagaraParticleCount_Internal(IntPtr NiagaraComponent, ref int ActiveEmitters, ref int ActiveParticles);

		// Token: 0x06007572 RID: 30066
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMobileDeviceModel_Internal();

		// Token: 0x06007573 RID: 30067
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMobileDeviceMake_Internal();

		// Token: 0x06007574 RID: 30068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLumenDiffuseGIFeatureEnabled_Internal(IntPtr WorldContextObject);

		// Token: 0x06007575 RID: 30069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLevelEditorViewPortSize_Internal(IntPtr WorldContextObject, ref FVector2D viewPortSize);

		// Token: 0x06007576 RID: 30070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLevelEditorCameraLocationAndForward_Internal(IntPtr WorldContextObject, ref FVector Position, ref FRotator Rotation);

		// Token: 0x06007577 RID: 30071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelActors_Internal(IntPtr InLevel);

		// Token: 0x06007578 RID: 30072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevel_Internal(IntPtr World);

		// Token: 0x06007579 RID: 30073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInt_Internal(IntPtr WorldContextObject, in FString Key, int DefaultValue);

		// Token: 0x0600757A RID: 30074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalGIActor_Internal(IntPtr WorldContextObject);

		// Token: 0x0600757B RID: 30075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGlobalFootstepMaterial_Internal(IntPtr WorldContextObject);

		// Token: 0x0600757C RID: 30076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGITransientActor_Internal(IntPtr WorldContextObject, FName IdName);

		// Token: 0x0600757D RID: 30077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloat_Internal(IntPtr WorldContextObject, in FString Key, float DefaultValue);

		// Token: 0x0600757E RID: 30078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineSubsystem_Internal(IntPtr EngineSubsystem);

		// Token: 0x0600757F RID: 30079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableNPCOptAsRayTracing_Internal(IntPtr WorldContextObject);

		// Token: 0x06007580 RID: 30080
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileProfileName_Internal();

		// Token: 0x06007581 RID: 30081
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileDeviceType_Internal();

		// Token: 0x06007582 RID: 30082
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceProfileBaseProfileName_Internal();

		// Token: 0x06007583 RID: 30083
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCVarString_Internal(in FString CVarKey);

		// Token: 0x06007584 RID: 30084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCVarFloat_Internal(in FString CVarKey);

		// Token: 0x06007585 RID: 30085
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCPUBrand_Internal();

		// Token: 0x06007586 RID: 30086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetComponentToWorldNoWorldOffset_Internal(IntPtr Component);

		// Token: 0x06007587 RID: 30087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentPhysicalMaterial_Internal(IntPtr Component);

		// Token: 0x06007588 RID: 30088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetComponentLocationNoWorldOffset_Internal(IntPtr Component);

		// Token: 0x06007589 RID: 30089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterSectionMaterialIndex_Internal(IntPtr SkeletalMesh, int SectionIndex);

		// Token: 0x0600758A RID: 30090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterSectionInfo_Internal(IntPtr Mesh, int SectionIndex);

		// Token: 0x0600758B RID: 30091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharacterSectionCount_Internal(IntPtr Mesh);

		// Token: 0x0600758C RID: 30092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCharacterInBattle_Internal(IntPtr WorldContextObject);

		// Token: 0x0600758D RID: 30093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetBoneDirection_Internal(IntPtr SkeletalMeshComponent, FName BoneName);

		// Token: 0x0600758E RID: 30094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAssetsByPath_Internal(FName PackagePath, bool bRecursive, bool bIncludeOnlyOnDiskAssets);

		// Token: 0x0600758F RID: 30095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAndAddCurveFloatSampleTask_Internal(IntPtr WorldContextObject, long LastFrameHandle, IntPtr Curve, float Time, float Default, ref long OutHandle);

		// Token: 0x06007590 RID: 30096
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAdapterUserDriverVersion_Internal();

		// Token: 0x06007591 RID: 30097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetActorTransformNoWorldOffset_Internal(IntPtr Actor);

		// Token: 0x06007592 RID: 30098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorsInLevel_Internal(IntPtr InLevel, IntPtr ActorClass, IntPtr OutActors);

		// Token: 0x06007593 RID: 30099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorOfClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass);

		// Token: 0x06007594 RID: 30100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorLocationRefXYZ_Internal(IntPtr Actor, ref float X, ref float Y, ref float Z);

		// Token: 0x06007595 RID: 30101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorLocationRef_Internal(IntPtr Actor, ref FVector RefLocation);

		// Token: 0x06007596 RID: 30102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorLocationNoWorldOffset_Internal(IntPtr Actor);

		// Token: 0x06007597 RID: 30103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorForwardVectorRefXYZ_Internal(IntPtr Actor, ref float X, ref float Y, ref float Z);

		// Token: 0x06007598 RID: 30104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorForwardVectorRef_Internal(IntPtr Actor, ref FVector RefForwardVector);

		// Token: 0x06007599 RID: 30105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_DetectPlayer_Two_Internal(double Index, int ParticleCount, IntPtr Dis, IntPtr Dirs, in FVector PlayerPos, in FVector WorldPos, in FRotator Rotator, ref float OutDistance);

		// Token: 0x0600759A RID: 30106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FS_DetectPlayer_Internal(int Index, int ParticleCount, IntPtr EndPos, in FVector PlayerPos, in FVector WorldPos, ref float OutDistance);

		// Token: 0x0600759B RID: 30107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FS_ComputeTilt_ByHeightH2_Internal(ref FVectorDouble LastFrameNormal, in FTransform PlaneTransform, float RayCastingDetectRange, in FVector PlayerPos, double MaxDegreeAngle, float MinActiveRadius, float MaxActiveRadius, double FollowSpeedRate, double ReturnSpeedRate, bool bPlayerColliding, bool bNeedReturnOrNot, bool bLinear);

		// Token: 0x0600759C RID: 30108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FS_ComputeTilt_ByHeightH_Internal(in FTransform PlaneTransform, float Radius, in FVector PersonWorld, double H, double MaxDegreeAngle, double MinActiveRadius, double MaxActiveRadius, bool bPlayerColliding, double FollowSpeedDegPerSec, double ReturnSpeedDegPerSec, float DeltaSeconds, bool bNeedReturnOrNot);

		// Token: 0x0600759D RID: 30109
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FS_CheckFrontObstacle2_Internal(float RayCastingDetectDis, IntPtr WorldContextObject, TEnumAsByte<ETraceTypeQuery> TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, IntPtr Dir, IntPtr EndPos, IntPtr Dis, IntPtr ParamNames, IntPtr MID, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, IntPtr ActorsToIgnore);

		// Token: 0x0600759E RID: 30110
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FS_CheckFrontObstacle_Internal(float RayCastingDetectDis, IntPtr WorldContextObject, TEnumAsByte<ETraceTypeQuery> TraceChannel, in FRotator Rotator, FVectorDouble WorldPosition, ref float OutDistance, IntPtr Dir, IntPtr EndPos, IntPtr ParamNames, IntPtr MID, bool debugLine, int CountIndex);

		// Token: 0x0600759F RID: 30111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeWorldLevelStreaming_Internal(IntPtr WorldContextObject);

		// Token: 0x060075A0 RID: 30112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FilterWeaponSweepPosition_Internal(IntPtr WorldContextObject, FVector HitPos, int WeaponTypeID, ref bool ValidBool, int FilterStateID, float ValidTimeWindow, float SpeedThreshold, float AlternatingPointTolerance, float ReverseDirectionDotThreshold);

		// Token: 0x060075A1 RID: 30113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyGITransientActor_Internal(IntPtr WorldContextObject, FName IdName);

		// Token: 0x060075A2 RID: 30114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteKey_Internal(IntPtr WorldContextObject, in FString Key);

		// Token: 0x060075A3 RID: 30115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteAll_Internal(IntPtr WorldContextObject);

		// Token: 0x060075A4 RID: 30116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActorFromClass_Internal(IntPtr WorldContextObject, IntPtr ActorClass, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator, bool bTemporaryEditorActor);

		// Token: 0x060075A5 RID: 30117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateGITransientActor_Internal(IntPtr WorldContextObject, FName IdName, bool bAttachToPlayer, bool bAttachToEditorCamera, FName EditorFolderPath);

		// Token: 0x060075A6 RID: 30118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipboardPaste_EditorOnly_Internal(ref FString Dest);

		// Token: 0x060075A7 RID: 30119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipboardCopy_EditorOnly_Internal(in FString Str);

		// Token: 0x060075A8 RID: 30120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearObjectFlags_Internal(IntPtr Object, int flags);

		// Token: 0x060075A9 RID: 30121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CatmullRomPointsFromLists_Internal(IntPtr PointList, IntPtr CurveList, float alpha, float tension, int Step);

		// Token: 0x060075AA RID: 30122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CatmullRomPoints_Internal(FVector2D P0, FVector2D P1, FVector2D P2, FVector2D P3, IntPtr CurveList, float alpha, float tension, int Step);

		// Token: 0x060075AB RID: 30123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CaptureStatGPUTimingsToFile_Internal(FVector CapturePosition, in FString FileName, ref FString OutFilePath, ref FString OutFailureReason);

		// Token: 0x060075AC RID: 30124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BuildDreamReflectionCaptureMatrixRows_Internal(IntPtr CaptureComponent, IntPtr RenderTarget, ref FLinearColor OutWorldToCaptureClipRow0, ref FLinearColor OutWorldToCaptureClipRow1, ref FLinearColor OutWorldToCaptureClipRow2, ref FLinearColor OutWorldToCaptureClipRow3);

		// Token: 0x060075AD RID: 30125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ApplyDreamReflectionCaptureParameters_Internal(IntPtr CaptureComponent, IntPtr RenderTarget, IntPtr MaterialInstance);

		// Token: 0x060075AE RID: 30126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddWeatherDataType_Internal(IntPtr WorldContextObject, FName Identifier, IntPtr ClassType);

		// Token: 0x060075AF RID: 30127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddPostprocessMaterial_Internal(IntPtr WorldContextObject, IntPtr Material, float Priority, bool bIsUiPostprocess);

		// Token: 0x060075B0 RID: 30128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddNamedComponent_Internal(IntPtr Actor, IntPtr Class, FName Name, bool bManualAttachment, in FTransform Transform);

		// Token: 0x060075B1 RID: 30129 RVA: 0x000ABF5D File Offset: 0x000AA15D
		static UKuroRenderingRuntimeBPPluginBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary");
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x000ABF6B File Offset: 0x000AA16B
		protected UKuroRenderingRuntimeBPPluginBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031A5 RID: 12709
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingRuntimeBPPluginBPLibrary";

		// Token: 0x040031A6 RID: 12710
		private static IntPtr _ClassPtr;

		// Token: 0x040031A7 RID: 12711
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
