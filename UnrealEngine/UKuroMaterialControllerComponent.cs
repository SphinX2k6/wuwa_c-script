using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CE RID: 1230
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKuroMaterialControllerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007281 RID: 29313 RVA: 0x000A85BB File Offset: 0x000A67BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerComponent._ClassPtr;
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x000A85C8 File Offset: 0x000A67C8
		public UKuroMaterialControllerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x000A85F0 File Offset: 0x000A67F0
		[NullableContext(1)]
		public UKuroMaterialControllerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06007284 RID: 29316 RVA: 0x000A8623 File Offset: 0x000A6823
		// (set) Token: 0x06007285 RID: 29317 RVA: 0x000A8633 File Offset: 0x000A6833
		public unsafe bool bInitTakeOver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerComponent.__PropertyOffset_bInitTakeOver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerComponent.__PropertyOffset_bInitTakeOver) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x000A8644 File Offset: 0x000A6844
		public void UpdateEffects()
		{
			UKuroMaterialControllerComponent.__UpdateEffects_Internal(base.NativePtr);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x000A8651 File Offset: 0x000A6851
		public void UnregisterEffectKey(FName KeyName)
		{
			UKuroMaterialControllerComponent.__UnregisterEffectKey_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x000A865F File Offset: 0x000A685F
		public void SetUpdateForce(bool bInUpdateForce)
		{
			UKuroMaterialControllerComponent.__SetUpdateForce_Internal(base.NativePtr, bInUpdateForce);
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x000A866D File Offset: 0x000A686D
		public void SetToonCustomStencilValue(int Value)
		{
			UKuroMaterialControllerComponent.__SetToonCustomStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x000A867B File Offset: 0x000A687B
		public void SetSkeletalMeshComponentUpdateGroup(FName BodyName, FName NewUpdateGroupId)
		{
			UKuroMaterialControllerComponent.__SetSkeletalMeshComponentUpdateGroup_Internal(base.NativePtr, BodyName, NewUpdateGroupId);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x000A868A File Offset: 0x000A688A
		public void SetInitTakeOver(bool InTakeOver)
		{
			UKuroMaterialControllerComponent.__SetInitTakeOver_Internal(base.NativePtr, InTakeOver);
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x000A8698 File Offset: 0x000A6898
		public void SetHandlePause(int HandleId, bool bPause)
		{
			UKuroMaterialControllerComponent.__SetHandlePause_Internal(base.NativePtr, HandleId, bPause);
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x000A86A7 File Offset: 0x000A68A7
		public void SetHandleLoop(int HandleId, bool bLoop, bool bSeekToEnd = false, int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__SetHandleLoop_Internal(base.NativePtr, HandleId, bLoop, bSeekToEnd, InstanceIndex);
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x000A86B9 File Offset: 0x000A68B9
		public void SetHandleEnabled(int HandleId, bool bEnabled)
		{
			UKuroMaterialControllerComponent.__SetHandleEnabled_Internal(base.NativePtr, HandleId, bEnabled);
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x000A86C8 File Offset: 0x000A68C8
		[NullableContext(1)]
		public unsafe void SetExternalMaterialReplaceCustom([Nullable(2)] UMaterialInterface Mat, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceCustom_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x000A8705 File Offset: 0x000A6905
		public void SetExternalMaterialReplaceCommon(UMaterialInterface Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceCommon_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyType, SlotType);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x000A8724 File Offset: 0x000A6924
		public void SetExternalMaterialReplaceByIndex(UMaterialInterface Mat, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceByIndex_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x000A8743 File Offset: 0x000A6943
		public void SetExternalMaterialReplace(UMaterialInterface Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplace_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyType, SlotType, MeshPart);
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x000A8764 File Offset: 0x000A6964
		public void SetBaseMaterialByIndex(UMaterialInterface Mat, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__SetBaseMaterialByIndex_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x000A8783 File Offset: 0x000A6983
		public void SetAllBodyNoWater(bool bNoWater)
		{
			UKuroMaterialControllerComponent.__SetAllBodyNoWater_Internal(base.NativePtr, bNoWater);
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x000A8791 File Offset: 0x000A6991
		public void SeekHandleFactor(int HandleId, float AbsoluteFactor)
		{
			UKuroMaterialControllerComponent.__SeekHandleFactor_Internal(base.NativePtr, HandleId, AbsoluteFactor);
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x000A87A0 File Offset: 0x000A69A0
		public void SeekFactor(float AbsoluteFactor, bool bIncludePaused = false)
		{
			UKuroMaterialControllerComponent.__SeekFactor_Internal(base.NativePtr, AbsoluteFactor, bIncludePaused);
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x000A87AF File Offset: 0x000A69AF
		public void ResetAllBodyInfo()
		{
			UKuroMaterialControllerComponent.__ResetAllBodyInfo_Internal(base.NativePtr);
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x000A87BC File Offset: 0x000A69BC
		[NullableContext(1)]
		public unsafe void RemoveTextureUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x000A87EA File Offset: 0x000A69EA
		public void RemoveTextureUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x000A87FA File Offset: 0x000A69FA
		public void RemoveTextureUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x000A880A File Offset: 0x000A6A0A
		public void RemoveTextureUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x000A881C File Offset: 0x000A6A1C
		public void RemoveSkeletalMeshComponent(FName BodyName)
		{
			UKuroMaterialControllerComponent.__RemoveSkeletalMeshComponent_Internal(base.NativePtr, BodyName);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x000A882C File Offset: 0x000A6A2C
		[NullableContext(1)]
		public unsafe void RemoveFloatUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x000A885A File Offset: 0x000A6A5A
		public void RemoveFloatUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x000A886A File Offset: 0x000A6A6A
		public void RemoveFloatUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x000A887A File Offset: 0x000A6A7A
		public void RemoveFloatUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x000A888C File Offset: 0x000A6A8C
		public void RemoveExternalOutlineStencilTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalOutlineStencilTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x000A889C File Offset: 0x000A6A9C
		[NullableContext(1)]
		public unsafe void RemoveExternalMaterialReplaceCustom(FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceCustom_Internal(base.NativePtr, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x000A88C8 File Offset: 0x000A6AC8
		public void RemoveExternalMaterialReplaceCommon(EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceCommon_Internal(base.NativePtr, BodyType, SlotType);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x000A88D7 File Offset: 0x000A6AD7
		public void RemoveExternalMaterialReplaceByIndex(FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceByIndex_Internal(base.NativePtr, BodyName, MaterialIndex);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x000A88E6 File Offset: 0x000A6AE6
		public void RemoveExternalMaterialReplace(EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplace_Internal(base.NativePtr, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x000A88F6 File Offset: 0x000A6AF6
		public void RemoveExternalBattleRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalBattleRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x000A8904 File Offset: 0x000A6B04
		public void RemoveExternalBattleMaskRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalBattleMaskRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x000A8912 File Offset: 0x000A6B12
		public void RemoveExternalAlphaTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalAlphaTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x000A8920 File Offset: 0x000A6B20
		public void RemoveEffect(int HandleId, int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__RemoveEffect_Internal(base.NativePtr, HandleId, InstanceIndex);
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x000A892F File Offset: 0x000A6B2F
		[NullableContext(1)]
		public TArray<int> RemoveDeadEffects()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__RemoveDeadEffects_Internal(base.NativePtr), null);
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x000A8944 File Offset: 0x000A6B44
		[NullableContext(1)]
		public unsafe void RemoveColorUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x000A8972 File Offset: 0x000A6B72
		public void RemoveColorUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x000A8982 File Offset: 0x000A6B82
		public void RemoveColorUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x000A8992 File Offset: 0x000A6B92
		public void RemoveColorUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x000A89A4 File Offset: 0x000A6BA4
		[NullableContext(1)]
		public TArray<int> RemoveAllUnloopedEffects()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__RemoveAllUnloopedEffects_Internal(base.NativePtr), null);
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x000A89B7 File Offset: 0x000A6BB7
		public void RemoveAllEffects(int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__RemoveAllEffects_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x000A89C5 File Offset: 0x000A6BC5
		public void RegisterPreBodyInfoRuntimeInitEvent(in FKuroMaterialControllerPreBodyInfoRuntimeReInit Event)
		{
			IntPtr nativePtr = base.NativePtr;
			FKuroMaterialControllerPreBodyInfoRuntimeReInit fkuroMaterialControllerPreBodyInfoRuntimeReInit = Event;
			UKuroMaterialControllerComponent.__RegisterPreBodyInfoRuntimeInitEvent_Internal(nativePtr, (fkuroMaterialControllerPreBodyInfoRuntimeReInit != null) ? fkuroMaterialControllerPreBodyInfoRuntimeReInit.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x000A89E1 File Offset: 0x000A6BE1
		public void RegisterPostBodyInfoRuntimeInitEvent(in FKuroMaterialControllerPostBodyInfoRuntimeReInit Event)
		{
			IntPtr nativePtr = base.NativePtr;
			FKuroMaterialControllerPostBodyInfoRuntimeReInit fkuroMaterialControllerPostBodyInfoRuntimeReInit = Event;
			UKuroMaterialControllerComponent.__RegisterPostBodyInfoRuntimeInitEvent_Internal(nativePtr, (fkuroMaterialControllerPostBodyInfoRuntimeReInit != null) ? fkuroMaterialControllerPostBodyInfoRuntimeReInit.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x000A89FD File Offset: 0x000A6BFD
		public void RegisterEffectKey(FName KeyName, int HandleId)
		{
			UKuroMaterialControllerComponent.__RegisterEffectKey_Internal(base.NativePtr, KeyName, HandleId);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x000A8A0C File Offset: 0x000A6C0C
		public void RefreshFilter(int HandleId)
		{
			UKuroMaterialControllerComponent.__RefreshFilter_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x000A8A1A File Offset: 0x000A6C1A
		public void PostComponentsVisibilityChanged()
		{
			UKuroMaterialControllerComponent.__PostComponentsVisibilityChanged_Internal(base.NativePtr);
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x000A8A27 File Offset: 0x000A6C27
		public void MarkForceUpdateAllOnce()
		{
			UKuroMaterialControllerComponent.__MarkForceUpdateAllOnce_Internal(base.NativePtr);
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x000A8A34 File Offset: 0x000A6C34
		public void ManualTick(float DeltaSeconds, bool bIncludePaused = false, bool bIncludeNewEffects = true, float LogicalTimeDilation = 1f)
		{
			UKuroMaterialControllerComponent.__ManualTick_Internal(base.NativePtr, DeltaSeconds, bIncludePaused, bIncludeNewEffects, LogicalTimeDilation);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x000A8A46 File Offset: 0x000A6C46
		public void InitFromOwner()
		{
			UKuroMaterialControllerComponent.__InitFromOwner_Internal(base.NativePtr);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x000A8A53 File Offset: 0x000A6C53
		public bool HasSkeletalMeshComponentName(FName BodyName)
		{
			return UKuroMaterialControllerComponent.__HasSkeletalMeshComponentName_Internal(base.NativePtr, BodyName);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x000A8A61 File Offset: 0x000A6C61
		public bool HasSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComponent)
		{
			return UKuroMaterialControllerComponent.__HasSkeletalMeshComponent_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x000A8A7E File Offset: 0x000A6C7E
		public FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent SkeletalMeshComponent)
		{
			return UKuroMaterialControllerComponent.__GetSkeletalMeshComponentBodyName_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x000A8A9B File Offset: 0x000A6C9B
		public USkeletalMeshComponent GetRegisteredSkeletalMeshComponent(FName BodyName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UKuroMaterialControllerComponent.__GetRegisteredSkeletalMeshComponent_Internal(base.NativePtr, BodyName));
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x000A8AAE File Offset: 0x000A6CAE
		[NullableContext(1)]
		public TArray<float> GetInstanceUpdateParams(int InstanceIndex = -1)
		{
			return new TArray<float>(UKuroMaterialControllerComponent.__GetInstanceUpdateParams_Internal(base.NativePtr, InstanceIndex), null);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x000A8AC2 File Offset: 0x000A6CC2
		public bool GetHandleLoop(int HandleId, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__GetHandleLoop_Internal(base.NativePtr, HandleId, InstanceIndex);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x000A8AD1 File Offset: 0x000A6CD1
		public int GetEffectKey(FName KeyName)
		{
			return UKuroMaterialControllerComponent.__GetEffectKey_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x000A8ADF File Offset: 0x000A6CDF
		public float GetBodyOpacity()
		{
			return UKuroMaterialControllerComponent.__GetBodyOpacity_Internal(base.NativePtr);
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x000A8AEC File Offset: 0x000A6CEC
		public bool GetAnyUnloopEffect()
		{
			return UKuroMaterialControllerComponent.__GetAnyUnloopEffect_Internal(base.NativePtr);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x000A8AF9 File Offset: 0x000A6CF9
		[NullableContext(1)]
		public TArray<FName> GetAllRegisteredBodyNames()
		{
			return new TArray<FName>(UKuroMaterialControllerComponent.__GetAllRegisteredBodyNames_Internal(base.NativePtr), null);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x000A8B0C File Offset: 0x000A6D0C
		[NullableContext(1)]
		public TArray<int> GetAllInstanceUpdateParamIndices()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__GetAllInstanceUpdateParamIndices_Internal(base.NativePtr), null);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x000A8B1F File Offset: 0x000A6D1F
		[NullableContext(1)]
		public TArray<int> GetAllHandles(int InstanceIndex = -1)
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__GetAllHandles_Internal(base.NativePtr, InstanceIndex), null);
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x000A8B33 File Offset: 0x000A6D33
		public bool CheckInit()
		{
			return UKuroMaterialControllerComponent.__CheckInit_Internal(base.NativePtr);
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x000A8B40 File Offset: 0x000A6D40
		[NullableContext(1)]
		public unsafe void AddTextureUpdateParamPermanentCustom(FName Name, [Nullable(2)] UTexture Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentCustom_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x000A8B7F File Offset: 0x000A6D7F
		public void AddTextureUpdateParamPermanentCommon(FName Name, UTexture Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentCommon_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyType, SlotType);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x000A8BA0 File Offset: 0x000A6DA0
		public void AddTextureUpdateParamPermanentByIndex(FName Name, UTexture Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x000A8BC1 File Offset: 0x000A6DC1
		public void AddTextureUpdateParamPermanent(FName Name, UTexture Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanent_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x000A8BE4 File Offset: 0x000A6DE4
		public void AddSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComponent, FName BodyName, bool bUseEmptyMaterial = false)
		{
			UKuroMaterialControllerComponent.__AddSkeletalMeshComponent_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, BodyName, bUseEmptyMaterial);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x000A8C03 File Offset: 0x000A6E03
		public static UKuroMaterialControllerComponent AddOrGetMaterialControllerComponentFromActorWithoutInit(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroMaterialControllerComponent.__AddOrGetMaterialControllerComponentFromActorWithoutInit_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x000A8C1F File Offset: 0x000A6E1F
		public static UKuroMaterialControllerComponent AddOrGetMaterialControllerComponentFromActor(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroMaterialControllerComponent.__AddOrGetMaterialControllerComponentFromActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		[NullableContext(1)]
		public unsafe void AddFloatUpdateParamPermanentCustom(FName Name, float Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentCustom_Internal(base.NativePtr, Name, Value, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x000A8C6C File Offset: 0x000A6E6C
		public void AddFloatUpdateParamPermanentCommon(FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentCommon_Internal(base.NativePtr, Name, Value, BodyType, SlotType);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x000A8C7E File Offset: 0x000A6E7E
		public void AddFloatUpdateParamPermanentByIndex(FName Name, float Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, Value, BodyName, MaterialIndex);
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x000A8C90 File Offset: 0x000A6E90
		public void AddFloatUpdateParamPermanent(FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanent_Internal(base.NativePtr, Name, Value, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x000A8CA4 File Offset: 0x000A6EA4
		public void AddExternalOutlineStencilTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalOutlineStencilTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x000A8CB2 File Offset: 0x000A6EB2
		public void AddExternalBattleRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalBattleRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
		public void AddExternalBattleMaskRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalBattleMaskRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x000A8CCE File Offset: 0x000A6ECE
		public void AddExternalAlphaTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalAlphaTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x000A8CDC File Offset: 0x000A6EDC
		public int AddEffect_Ex(UKuroMaterialControllerDataAsset DataAsset, bool bLoop = true, bool bPause = false, USkeletalMeshComponent AnimObject = null, bool bHiddenOnRemove = false, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__AddEffect_Ex_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero, bLoop, bPause, (AnimObject != null) ? AnimObject.NativePtr : IntPtr.Zero, bHiddenOnRemove, InstanceIndex);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x000A8D11 File Offset: 0x000A6F11
		public int AddEffect(UKuroMaterialControllerDataAsset DataAsset, bool bLoop = true, bool bPause = false, USkeletalMeshComponent AnimObject = null, bool bHiddenOnRemove = false, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__AddEffect_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero, bLoop, bPause, (AnimObject != null) ? AnimObject.NativePtr : IntPtr.Zero, bHiddenOnRemove, InstanceIndex);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x000A8D48 File Offset: 0x000A6F48
		[NullableContext(1)]
		public unsafe void AddColorUpdateParamPermanentCustom(FName Name, FLinearColor Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentCustom_Internal(base.NativePtr, Name, Value, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x000A8D78 File Offset: 0x000A6F78
		public void AddColorUpdateParamPermanentCommon(FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentCommon_Internal(base.NativePtr, Name, Value, BodyType, SlotType);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x000A8D8A File Offset: 0x000A6F8A
		public void AddColorUpdateParamPermanentByIndex(FName Name, FLinearColor Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, Value, BodyName, MaterialIndex);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x000A8D9C File Offset: 0x000A6F9C
		public void AddColorUpdateParamPermanent(FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanent_Internal(base.NativePtr, Name, Value, BodyType, SlotType, MeshPart);
		}

		// Token: 0x060072DB RID: 29403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffects_Internal(IntPtr @this);

		// Token: 0x060072DC RID: 29404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterEffectKey_Internal(IntPtr @this, FName KeyName);

		// Token: 0x060072DD RID: 29405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateForce_Internal(IntPtr @this, bool bInUpdateForce);

		// Token: 0x060072DE RID: 29406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonCustomStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x060072DF RID: 29407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshComponentUpdateGroup_Internal(IntPtr @this, FName BodyName, FName NewUpdateGroupId);

		// Token: 0x060072E0 RID: 29408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitTakeOver_Internal(IntPtr @this, bool InTakeOver);

		// Token: 0x060072E1 RID: 29409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandlePause_Internal(IntPtr @this, int HandleId, bool bPause);

		// Token: 0x060072E2 RID: 29410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandleLoop_Internal(IntPtr @this, int HandleId, bool bLoop, bool bSeekToEnd, int InstanceIndex);

		// Token: 0x060072E3 RID: 29411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandleEnabled_Internal(IntPtr @this, int HandleId, bool bEnabled);

		// Token: 0x060072E4 RID: 29412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceCustom_Internal(IntPtr @this, IntPtr Mat, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x060072E5 RID: 29413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceCommon_Internal(IntPtr @this, IntPtr Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x060072E6 RID: 29414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceByIndex_Internal(IntPtr @this, IntPtr Mat, FName BodyName, int MaterialIndex);

		// Token: 0x060072E7 RID: 29415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplace_Internal(IntPtr @this, IntPtr Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x060072E8 RID: 29416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseMaterialByIndex_Internal(IntPtr @this, IntPtr Mat, FName BodyName, int MaterialIndex);

		// Token: 0x060072E9 RID: 29417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodyNoWater_Internal(IntPtr @this, bool bNoWater);

		// Token: 0x060072EA RID: 29418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekHandleFactor_Internal(IntPtr @this, int HandleId, float AbsoluteFactor);

		// Token: 0x060072EB RID: 29419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekFactor_Internal(IntPtr @this, float AbsoluteFactor, bool bIncludePaused);

		// Token: 0x060072EC RID: 29420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllBodyInfo_Internal(IntPtr @this);

		// Token: 0x060072ED RID: 29421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x060072EE RID: 29422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x060072EF RID: 29423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x060072F0 RID: 29424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x060072F1 RID: 29425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSkeletalMeshComponent_Internal(IntPtr @this, FName BodyName);

		// Token: 0x060072F2 RID: 29426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x060072F3 RID: 29427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x060072F4 RID: 29428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x060072F5 RID: 29429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x060072F6 RID: 29430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalOutlineStencilTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x060072F7 RID: 29431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceCustom_Internal(IntPtr @this, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x060072F8 RID: 29432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceCommon_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x060072F9 RID: 29433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceByIndex_Internal(IntPtr @this, FName BodyName, int MaterialIndex);

		// Token: 0x060072FA RID: 29434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplace_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x060072FB RID: 29435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalBattleRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x060072FC RID: 29436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalBattleMaskRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x060072FD RID: 29437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalAlphaTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x060072FE RID: 29438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEffect_Internal(IntPtr @this, int HandleId, int InstanceIndex);

		// Token: 0x060072FF RID: 29439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RemoveDeadEffects_Internal(IntPtr @this);

		// Token: 0x06007300 RID: 29440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x06007301 RID: 29441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x06007302 RID: 29442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x06007303 RID: 29443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x06007304 RID: 29444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RemoveAllUnloopedEffects_Internal(IntPtr @this);

		// Token: 0x06007305 RID: 29445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllEffects_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x06007306 RID: 29446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPreBodyInfoRuntimeInitEvent_Internal(IntPtr @this, IntPtr Event);

		// Token: 0x06007307 RID: 29447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPostBodyInfoRuntimeInitEvent_Internal(IntPtr @this, IntPtr Event);

		// Token: 0x06007308 RID: 29448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEffectKey_Internal(IntPtr @this, FName KeyName, int HandleId);

		// Token: 0x06007309 RID: 29449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshFilter_Internal(IntPtr @this, int HandleId);

		// Token: 0x0600730A RID: 29450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostComponentsVisibilityChanged_Internal(IntPtr @this);

		// Token: 0x0600730B RID: 29451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkForceUpdateAllOnce_Internal(IntPtr @this);

		// Token: 0x0600730C RID: 29452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualTick_Internal(IntPtr @this, float DeltaSeconds, bool bIncludePaused, bool bIncludeNewEffects, float LogicalTimeDilation);

		// Token: 0x0600730D RID: 29453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitFromOwner_Internal(IntPtr @this);

		// Token: 0x0600730E RID: 29454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshComponentName_Internal(IntPtr @this, FName BodyName);

		// Token: 0x0600730F RID: 29455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshComponent_Internal(IntPtr @this, IntPtr SkeletalMeshComponent);

		// Token: 0x06007310 RID: 29456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetSkeletalMeshComponentBodyName_Internal(IntPtr @this, IntPtr SkeletalMeshComponent);

		// Token: 0x06007311 RID: 29457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredSkeletalMeshComponent_Internal(IntPtr @this, FName BodyName);

		// Token: 0x06007312 RID: 29458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstanceUpdateParams_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x06007313 RID: 29459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHandleLoop_Internal(IntPtr @this, int HandleId, int InstanceIndex);

		// Token: 0x06007314 RID: 29460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectKey_Internal(IntPtr @this, FName KeyName);

		// Token: 0x06007315 RID: 29461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBodyOpacity_Internal(IntPtr @this);

		// Token: 0x06007316 RID: 29462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnyUnloopEffect_Internal(IntPtr @this);

		// Token: 0x06007317 RID: 29463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllRegisteredBodyNames_Internal(IntPtr @this);

		// Token: 0x06007318 RID: 29464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllInstanceUpdateParamIndices_Internal(IntPtr @this);

		// Token: 0x06007319 RID: 29465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllHandles_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0600731A RID: 29466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckInit_Internal(IntPtr @this);

		// Token: 0x0600731B RID: 29467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, IntPtr Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0600731C RID: 29468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, IntPtr Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0600731D RID: 29469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, IntPtr Value, FName BodyName, int MaterialIndex);

		// Token: 0x0600731E RID: 29470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanent_Internal(IntPtr @this, FName Name, IntPtr Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0600731F RID: 29471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSkeletalMeshComponent_Internal(IntPtr @this, IntPtr SkeletalMeshComponent, FName BodyName, bool bUseEmptyMaterial);

		// Token: 0x06007320 RID: 29472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddOrGetMaterialControllerComponentFromActorWithoutInit_Internal(IntPtr Actor);

		// Token: 0x06007321 RID: 29473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddOrGetMaterialControllerComponentFromActor_Internal(IntPtr Actor);

		// Token: 0x06007322 RID: 29474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, float Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x06007323 RID: 29475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x06007324 RID: 29476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, float Value, FName BodyName, int MaterialIndex);

		// Token: 0x06007325 RID: 29477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanent_Internal(IntPtr @this, FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x06007326 RID: 29478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalOutlineStencilTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x06007327 RID: 29479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalBattleRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x06007328 RID: 29480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalBattleMaskRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x06007329 RID: 29481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalAlphaTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0600732A RID: 29482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddEffect_Ex_Internal(IntPtr @this, IntPtr DataAsset, bool bLoop, bool bPause, IntPtr AnimObject, bool bHiddenOnRemove, int InstanceIndex);

		// Token: 0x0600732B RID: 29483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddEffect_Internal(IntPtr @this, IntPtr DataAsset, bool bLoop, bool bPause, IntPtr AnimObject, bool bHiddenOnRemove, int InstanceIndex);

		// Token: 0x0600732C RID: 29484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FLinearColor Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0600732D RID: 29485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0600732E RID: 29486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FLinearColor Value, FName BodyName, int MaterialIndex);

		// Token: 0x0600732F RID: 29487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanent_Internal(IntPtr @this, FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x06007330 RID: 29488 RVA: 0x000A8DB0 File Offset: 0x000A6FB0
		static UKuroMaterialControllerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent");
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x000A8DBE File Offset: 0x000A6FBE
		protected UKuroMaterialControllerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003154 RID: 12628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent";

		// Token: 0x04003155 RID: 12629
		private static IntPtr _ClassPtr;

		// Token: 0x04003156 RID: 12630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003157 RID: 12631
		internal static int __PropertyOffset_bInitTakeOver;
	}
}
