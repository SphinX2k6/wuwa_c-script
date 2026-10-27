using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B39 RID: 6969
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKuroMaterialControllerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A56A RID: 107882 RVA: 0x0026DD0C File Offset: 0x0026BF0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerComponent._ClassPtr;
		}

		// Token: 0x0601A56B RID: 107883 RVA: 0x0026DD18 File Offset: 0x0026BF18
		public UKuroMaterialControllerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A56C RID: 107884 RVA: 0x0026DD40 File Offset: 0x0026BF40
		[NullableContext(1)]
		public UKuroMaterialControllerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A09 RID: 27145
		// (get) Token: 0x0601A56D RID: 107885 RVA: 0x0026DD73 File Offset: 0x0026BF73
		// (set) Token: 0x0601A56E RID: 107886 RVA: 0x0026DD83 File Offset: 0x0026BF83
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

		// Token: 0x0601A56F RID: 107887 RVA: 0x0026DD94 File Offset: 0x0026BF94
		public void UpdateEffects()
		{
			UKuroMaterialControllerComponent.__UpdateEffects_Internal(base.NativePtr);
		}

		// Token: 0x0601A570 RID: 107888 RVA: 0x0026DDA1 File Offset: 0x0026BFA1
		public void UnregisterEffectKey(FName KeyName)
		{
			UKuroMaterialControllerComponent.__UnregisterEffectKey_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0601A571 RID: 107889 RVA: 0x0026DDAF File Offset: 0x0026BFAF
		public void SetUpdateForce(bool bInUpdateForce)
		{
			UKuroMaterialControllerComponent.__SetUpdateForce_Internal(base.NativePtr, bInUpdateForce);
		}

		// Token: 0x0601A572 RID: 107890 RVA: 0x0026DDBD File Offset: 0x0026BFBD
		public void SetToonCustomStencilValue(int Value)
		{
			UKuroMaterialControllerComponent.__SetToonCustomStencilValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601A573 RID: 107891 RVA: 0x0026DDCB File Offset: 0x0026BFCB
		public void SetSkeletalMeshComponentUpdateGroup(FName BodyName, FName NewUpdateGroupId)
		{
			UKuroMaterialControllerComponent.__SetSkeletalMeshComponentUpdateGroup_Internal(base.NativePtr, BodyName, NewUpdateGroupId);
		}

		// Token: 0x0601A574 RID: 107892 RVA: 0x0026DDDA File Offset: 0x0026BFDA
		public void SetInitTakeOver(bool InTakeOver)
		{
			UKuroMaterialControllerComponent.__SetInitTakeOver_Internal(base.NativePtr, InTakeOver);
		}

		// Token: 0x0601A575 RID: 107893 RVA: 0x0026DDE8 File Offset: 0x0026BFE8
		public void SetHandlePause(int HandleId, bool bPause)
		{
			UKuroMaterialControllerComponent.__SetHandlePause_Internal(base.NativePtr, HandleId, bPause);
		}

		// Token: 0x0601A576 RID: 107894 RVA: 0x0026DDF7 File Offset: 0x0026BFF7
		public void SetHandleLoop(int HandleId, bool bLoop, bool bSeekToEnd = false, int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__SetHandleLoop_Internal(base.NativePtr, HandleId, bLoop, bSeekToEnd, InstanceIndex);
		}

		// Token: 0x0601A577 RID: 107895 RVA: 0x0026DE09 File Offset: 0x0026C009
		public void SetHandleEnabled(int HandleId, bool bEnabled)
		{
			UKuroMaterialControllerComponent.__SetHandleEnabled_Internal(base.NativePtr, HandleId, bEnabled);
		}

		// Token: 0x0601A578 RID: 107896 RVA: 0x0026DE18 File Offset: 0x0026C018
		[NullableContext(1)]
		public unsafe void SetExternalMaterialReplaceCustom([Nullable(2)] UMaterialInterface Mat, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceCustom_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A579 RID: 107897 RVA: 0x0026DE55 File Offset: 0x0026C055
		public void SetExternalMaterialReplaceCommon(UMaterialInterface Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceCommon_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyType, SlotType);
		}

		// Token: 0x0601A57A RID: 107898 RVA: 0x0026DE74 File Offset: 0x0026C074
		public void SetExternalMaterialReplaceByIndex(UMaterialInterface Mat, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplaceByIndex_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x0601A57B RID: 107899 RVA: 0x0026DE93 File Offset: 0x0026C093
		public void SetExternalMaterialReplace(UMaterialInterface Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__SetExternalMaterialReplace_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A57C RID: 107900 RVA: 0x0026DEB4 File Offset: 0x0026C0B4
		public void SetBaseMaterialByIndex(UMaterialInterface Mat, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__SetBaseMaterialByIndex_Internal(base.NativePtr, (Mat != null) ? Mat.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x0601A57D RID: 107901 RVA: 0x0026DED3 File Offset: 0x0026C0D3
		public void SetAllBodyNoWater(bool bNoWater)
		{
			UKuroMaterialControllerComponent.__SetAllBodyNoWater_Internal(base.NativePtr, bNoWater);
		}

		// Token: 0x0601A57E RID: 107902 RVA: 0x0026DEE1 File Offset: 0x0026C0E1
		public void SeekHandleFactor(int HandleId, float AbsoluteFactor)
		{
			UKuroMaterialControllerComponent.__SeekHandleFactor_Internal(base.NativePtr, HandleId, AbsoluteFactor);
		}

		// Token: 0x0601A57F RID: 107903 RVA: 0x0026DEF0 File Offset: 0x0026C0F0
		public void SeekFactor(float AbsoluteFactor, bool bIncludePaused = false)
		{
			UKuroMaterialControllerComponent.__SeekFactor_Internal(base.NativePtr, AbsoluteFactor, bIncludePaused);
		}

		// Token: 0x0601A580 RID: 107904 RVA: 0x0026DEFF File Offset: 0x0026C0FF
		public void ResetAllBodyInfo()
		{
			UKuroMaterialControllerComponent.__ResetAllBodyInfo_Internal(base.NativePtr);
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x0026DF0C File Offset: 0x0026C10C
		[NullableContext(1)]
		public unsafe void RemoveTextureUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x0026DF3A File Offset: 0x0026C13A
		public void RemoveTextureUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x0601A583 RID: 107907 RVA: 0x0026DF4A File Offset: 0x0026C14A
		public void RemoveTextureUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x0601A584 RID: 107908 RVA: 0x0026DF5A File Offset: 0x0026C15A
		public void RemoveTextureUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveTextureUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A585 RID: 107909 RVA: 0x0026DF6C File Offset: 0x0026C16C
		public void RemoveSkeletalMeshComponent(FName BodyName)
		{
			UKuroMaterialControllerComponent.__RemoveSkeletalMeshComponent_Internal(base.NativePtr, BodyName);
		}

		// Token: 0x0601A586 RID: 107910 RVA: 0x0026DF7C File Offset: 0x0026C17C
		[NullableContext(1)]
		public unsafe void RemoveFloatUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A587 RID: 107911 RVA: 0x0026DFAA File Offset: 0x0026C1AA
		public void RemoveFloatUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x0601A588 RID: 107912 RVA: 0x0026DFBA File Offset: 0x0026C1BA
		public void RemoveFloatUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x0601A589 RID: 107913 RVA: 0x0026DFCA File Offset: 0x0026C1CA
		public void RemoveFloatUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveFloatUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A58A RID: 107914 RVA: 0x0026DFDC File Offset: 0x0026C1DC
		public void RemoveExternalOutlineStencilTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalOutlineStencilTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A58B RID: 107915 RVA: 0x0026DFEC File Offset: 0x0026C1EC
		[NullableContext(1)]
		public unsafe void RemoveExternalMaterialReplaceCustom(FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceCustom_Internal(base.NativePtr, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A58C RID: 107916 RVA: 0x0026E018 File Offset: 0x0026C218
		public void RemoveExternalMaterialReplaceCommon(EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceCommon_Internal(base.NativePtr, BodyType, SlotType);
		}

		// Token: 0x0601A58D RID: 107917 RVA: 0x0026E027 File Offset: 0x0026C227
		public void RemoveExternalMaterialReplaceByIndex(FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplaceByIndex_Internal(base.NativePtr, BodyName, MaterialIndex);
		}

		// Token: 0x0601A58E RID: 107918 RVA: 0x0026E036 File Offset: 0x0026C236
		public void RemoveExternalMaterialReplace(EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveExternalMaterialReplace_Internal(base.NativePtr, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A58F RID: 107919 RVA: 0x0026E046 File Offset: 0x0026C246
		public void RemoveExternalBattleRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalBattleRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A590 RID: 107920 RVA: 0x0026E054 File Offset: 0x0026C254
		public void RemoveExternalBattleMaskRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalBattleMaskRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A591 RID: 107921 RVA: 0x0026E062 File Offset: 0x0026C262
		public void RemoveExternalAlphaTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__RemoveExternalAlphaTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A592 RID: 107922 RVA: 0x0026E070 File Offset: 0x0026C270
		public void RemoveEffect(int HandleId, int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__RemoveEffect_Internal(base.NativePtr, HandleId, InstanceIndex);
		}

		// Token: 0x0601A593 RID: 107923 RVA: 0x0026E07F File Offset: 0x0026C27F
		[NullableContext(1)]
		public TArray<int> RemoveDeadEffects()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__RemoveDeadEffects_Internal(base.NativePtr), null);
		}

		// Token: 0x0601A594 RID: 107924 RVA: 0x0026E094 File Offset: 0x0026C294
		[NullableContext(1)]
		public unsafe void RemoveColorUpdateParamPermanentCustom(FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentCustom_Internal(base.NativePtr, Name, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A595 RID: 107925 RVA: 0x0026E0C2 File Offset: 0x0026C2C2
		public void RemoveColorUpdateParamPermanentCommon(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentCommon_Internal(base.NativePtr, Name, BodyType, SlotType);
		}

		// Token: 0x0601A596 RID: 107926 RVA: 0x0026E0D2 File Offset: 0x0026C2D2
		public void RemoveColorUpdateParamPermanentByIndex(FName Name, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, BodyName, MaterialIndex);
		}

		// Token: 0x0601A597 RID: 107927 RVA: 0x0026E0E2 File Offset: 0x0026C2E2
		public void RemoveColorUpdateParamPermanent(FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__RemoveColorUpdateParamPermanent_Internal(base.NativePtr, Name, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A598 RID: 107928 RVA: 0x0026E0F4 File Offset: 0x0026C2F4
		[NullableContext(1)]
		public TArray<int> RemoveAllUnloopedEffects()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__RemoveAllUnloopedEffects_Internal(base.NativePtr), null);
		}

		// Token: 0x0601A599 RID: 107929 RVA: 0x0026E107 File Offset: 0x0026C307
		public void RemoveAllEffects(int InstanceIndex = -1)
		{
			UKuroMaterialControllerComponent.__RemoveAllEffects_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x0601A59A RID: 107930 RVA: 0x0026E115 File Offset: 0x0026C315
		public void RegisterPreBodyInfoRuntimeInitEvent(in FKuroMaterialControllerPreBodyInfoRuntimeReInit Event)
		{
			IntPtr nativePtr = base.NativePtr;
			FKuroMaterialControllerPreBodyInfoRuntimeReInit fkuroMaterialControllerPreBodyInfoRuntimeReInit = Event;
			UKuroMaterialControllerComponent.__RegisterPreBodyInfoRuntimeInitEvent_Internal(nativePtr, (fkuroMaterialControllerPreBodyInfoRuntimeReInit != null) ? fkuroMaterialControllerPreBodyInfoRuntimeReInit.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601A59B RID: 107931 RVA: 0x0026E131 File Offset: 0x0026C331
		public void RegisterPostBodyInfoRuntimeInitEvent(in FKuroMaterialControllerPostBodyInfoRuntimeReInit Event)
		{
			IntPtr nativePtr = base.NativePtr;
			FKuroMaterialControllerPostBodyInfoRuntimeReInit fkuroMaterialControllerPostBodyInfoRuntimeReInit = Event;
			UKuroMaterialControllerComponent.__RegisterPostBodyInfoRuntimeInitEvent_Internal(nativePtr, (fkuroMaterialControllerPostBodyInfoRuntimeReInit != null) ? fkuroMaterialControllerPostBodyInfoRuntimeReInit.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601A59C RID: 107932 RVA: 0x0026E14D File Offset: 0x0026C34D
		public void RegisterEffectKey(FName KeyName, int HandleId)
		{
			UKuroMaterialControllerComponent.__RegisterEffectKey_Internal(base.NativePtr, KeyName, HandleId);
		}

		// Token: 0x0601A59D RID: 107933 RVA: 0x0026E15C File Offset: 0x0026C35C
		public void RefreshFilter(int HandleId)
		{
			UKuroMaterialControllerComponent.__RefreshFilter_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x0601A59E RID: 107934 RVA: 0x0026E16A File Offset: 0x0026C36A
		public void PostComponentsVisibilityChanged()
		{
			UKuroMaterialControllerComponent.__PostComponentsVisibilityChanged_Internal(base.NativePtr);
		}

		// Token: 0x0601A59F RID: 107935 RVA: 0x0026E177 File Offset: 0x0026C377
		public void MarkForceUpdateAllOnce()
		{
			UKuroMaterialControllerComponent.__MarkForceUpdateAllOnce_Internal(base.NativePtr);
		}

		// Token: 0x0601A5A0 RID: 107936 RVA: 0x0026E184 File Offset: 0x0026C384
		public void ManualTick(float DeltaSeconds, bool bIncludePaused = false, bool bIncludeNewEffects = true, float LogicalTimeDilation = 1f)
		{
			UKuroMaterialControllerComponent.__ManualTick_Internal(base.NativePtr, DeltaSeconds, bIncludePaused, bIncludeNewEffects, LogicalTimeDilation);
		}

		// Token: 0x0601A5A1 RID: 107937 RVA: 0x0026E196 File Offset: 0x0026C396
		public void InitFromOwner()
		{
			UKuroMaterialControllerComponent.__InitFromOwner_Internal(base.NativePtr);
		}

		// Token: 0x0601A5A2 RID: 107938 RVA: 0x0026E1A3 File Offset: 0x0026C3A3
		public bool HasSkeletalMeshComponentName(FName BodyName)
		{
			return UKuroMaterialControllerComponent.__HasSkeletalMeshComponentName_Internal(base.NativePtr, BodyName);
		}

		// Token: 0x0601A5A3 RID: 107939 RVA: 0x0026E1B1 File Offset: 0x0026C3B1
		public bool HasSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComponent)
		{
			return UKuroMaterialControllerComponent.__HasSkeletalMeshComponent_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A5A4 RID: 107940 RVA: 0x0026E1CE File Offset: 0x0026C3CE
		public FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent SkeletalMeshComponent)
		{
			return UKuroMaterialControllerComponent.__GetSkeletalMeshComponentBodyName_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A5A5 RID: 107941 RVA: 0x0026E1EB File Offset: 0x0026C3EB
		public USkeletalMeshComponent GetRegisteredSkeletalMeshComponentByType(EKuroCharBodyType BodyType, int Index = 0)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UKuroMaterialControllerComponent.__GetRegisteredSkeletalMeshComponentByType_Internal(base.NativePtr, BodyType, Index));
		}

		// Token: 0x0601A5A6 RID: 107942 RVA: 0x0026E1FF File Offset: 0x0026C3FF
		public USkeletalMeshComponent GetRegisteredSkeletalMeshComponent(FName BodyName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(UKuroMaterialControllerComponent.__GetRegisteredSkeletalMeshComponent_Internal(base.NativePtr, BodyName));
		}

		// Token: 0x0601A5A7 RID: 107943 RVA: 0x0026E212 File Offset: 0x0026C412
		[NullableContext(1)]
		public TArray<float> GetInstanceUpdateParams(int InstanceIndex = -1)
		{
			return new TArray<float>(UKuroMaterialControllerComponent.__GetInstanceUpdateParams_Internal(base.NativePtr, InstanceIndex), null);
		}

		// Token: 0x0601A5A8 RID: 107944 RVA: 0x0026E226 File Offset: 0x0026C426
		public bool GetHandleLoop(int HandleId, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__GetHandleLoop_Internal(base.NativePtr, HandleId, InstanceIndex);
		}

		// Token: 0x0601A5A9 RID: 107945 RVA: 0x0026E235 File Offset: 0x0026C435
		public int GetEffectKey(FName KeyName)
		{
			return UKuroMaterialControllerComponent.__GetEffectKey_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0601A5AA RID: 107946 RVA: 0x0026E243 File Offset: 0x0026C443
		public float GetBodyOpacity()
		{
			return UKuroMaterialControllerComponent.__GetBodyOpacity_Internal(base.NativePtr);
		}

		// Token: 0x0601A5AB RID: 107947 RVA: 0x0026E250 File Offset: 0x0026C450
		public bool GetAnyUnloopEffect()
		{
			return UKuroMaterialControllerComponent.__GetAnyUnloopEffect_Internal(base.NativePtr);
		}

		// Token: 0x0601A5AC RID: 107948 RVA: 0x0026E25D File Offset: 0x0026C45D
		[NullableContext(1)]
		public TArray<FName> GetAllRegisteredBodyNames()
		{
			return new TArray<FName>(UKuroMaterialControllerComponent.__GetAllRegisteredBodyNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0601A5AD RID: 107949 RVA: 0x0026E270 File Offset: 0x0026C470
		[NullableContext(1)]
		public TArray<int> GetAllInstanceUpdateParamIndices()
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__GetAllInstanceUpdateParamIndices_Internal(base.NativePtr), null);
		}

		// Token: 0x0601A5AE RID: 107950 RVA: 0x0026E283 File Offset: 0x0026C483
		[NullableContext(1)]
		public TArray<int> GetAllHandles(int InstanceIndex = -1)
		{
			return new TArray<int>(UKuroMaterialControllerComponent.__GetAllHandles_Internal(base.NativePtr, InstanceIndex), null);
		}

		// Token: 0x0601A5AF RID: 107951 RVA: 0x0026E297 File Offset: 0x0026C497
		public bool CheckInit()
		{
			return UKuroMaterialControllerComponent.__CheckInit_Internal(base.NativePtr);
		}

		// Token: 0x0601A5B0 RID: 107952 RVA: 0x0026E2A4 File Offset: 0x0026C4A4
		[NullableContext(1)]
		public unsafe void AddTextureUpdateParamPermanentCustom(FName Name, [Nullable(2)] UTexture Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentCustom_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A5B1 RID: 107953 RVA: 0x0026E2E3 File Offset: 0x0026C4E3
		public void AddTextureUpdateParamPermanentCommon(FName Name, UTexture Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentCommon_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyType, SlotType);
		}

		// Token: 0x0601A5B2 RID: 107954 RVA: 0x0026E304 File Offset: 0x0026C504
		public void AddTextureUpdateParamPermanentByIndex(FName Name, UTexture Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyName, MaterialIndex);
		}

		// Token: 0x0601A5B3 RID: 107955 RVA: 0x0026E325 File Offset: 0x0026C525
		public void AddTextureUpdateParamPermanent(FName Name, UTexture Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddTextureUpdateParamPermanent_Internal(base.NativePtr, Name, (Value != null) ? Value.NativePtr : IntPtr.Zero, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A5B4 RID: 107956 RVA: 0x0026E348 File Offset: 0x0026C548
		public void AddSkeletalMeshComponent(USkeletalMeshComponent SkeletalMeshComponent, FName BodyName, bool bUseEmptyMaterial = false)
		{
			UKuroMaterialControllerComponent.__AddSkeletalMeshComponent_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, BodyName, bUseEmptyMaterial);
		}

		// Token: 0x0601A5B5 RID: 107957 RVA: 0x0026E367 File Offset: 0x0026C567
		public static UKuroMaterialControllerComponent AddOrGetMaterialControllerComponentFromActorWithoutInit(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroMaterialControllerComponent.__AddOrGetMaterialControllerComponentFromActorWithoutInit_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A5B6 RID: 107958 RVA: 0x0026E383 File Offset: 0x0026C583
		public static UKuroMaterialControllerComponent AddOrGetMaterialControllerComponentFromActor(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroMaterialControllerComponent.__AddOrGetMaterialControllerComponentFromActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A5B7 RID: 107959 RVA: 0x0026E3A0 File Offset: 0x0026C5A0
		[NullableContext(1)]
		public unsafe void AddFloatUpdateParamPermanentCustom(FName Name, float Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentCustom_Internal(base.NativePtr, Name, Value, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A5B8 RID: 107960 RVA: 0x0026E3D0 File Offset: 0x0026C5D0
		public void AddFloatUpdateParamPermanentCommon(FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentCommon_Internal(base.NativePtr, Name, Value, BodyType, SlotType);
		}

		// Token: 0x0601A5B9 RID: 107961 RVA: 0x0026E3E2 File Offset: 0x0026C5E2
		public void AddFloatUpdateParamPermanentByIndex(FName Name, float Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, Value, BodyName, MaterialIndex);
		}

		// Token: 0x0601A5BA RID: 107962 RVA: 0x0026E3F4 File Offset: 0x0026C5F4
		public void AddFloatUpdateParamPermanent(FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddFloatUpdateParamPermanent_Internal(base.NativePtr, Name, Value, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A5BB RID: 107963 RVA: 0x0026E408 File Offset: 0x0026C608
		public void AddExternalOutlineStencilTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalOutlineStencilTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A5BC RID: 107964 RVA: 0x0026E416 File Offset: 0x0026C616
		public void AddExternalBattleRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalBattleRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A5BD RID: 107965 RVA: 0x0026E424 File Offset: 0x0026C624
		public void AddExternalBattleMaskRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalBattleMaskRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A5BE RID: 107966 RVA: 0x0026E432 File Offset: 0x0026C632
		public void AddExternalAlphaTestRefCount(EKuroCharBodySpecifiedType BodyType)
		{
			UKuroMaterialControllerComponent.__AddExternalAlphaTestRefCount_Internal(base.NativePtr, BodyType);
		}

		// Token: 0x0601A5BF RID: 107967 RVA: 0x0026E440 File Offset: 0x0026C640
		public int AddEffectRaw(UKuroMaterialContainerDataCache DataCache, bool bLoop = true, bool bPause = false, USkeletalMeshComponent AnimObject = null, bool bHiddenOnRemove = false, int InstanceIndex = -1, bool bReceiveLogicalTimeDilation = false)
		{
			return UKuroMaterialControllerComponent.__AddEffectRaw_Internal(base.NativePtr, (DataCache != null) ? DataCache.NativePtr : IntPtr.Zero, bLoop, bPause, (AnimObject != null) ? AnimObject.NativePtr : IntPtr.Zero, bHiddenOnRemove, InstanceIndex, bReceiveLogicalTimeDilation);
		}

		// Token: 0x0601A5C0 RID: 107968 RVA: 0x0026E477 File Offset: 0x0026C677
		public int AddEffect_Ex(UKuroMaterialControllerDataAsset DataAsset, bool bLoop = true, bool bPause = false, USkeletalMeshComponent AnimObject = null, bool bHiddenOnRemove = false, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__AddEffect_Ex_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero, bLoop, bPause, (AnimObject != null) ? AnimObject.NativePtr : IntPtr.Zero, bHiddenOnRemove, InstanceIndex);
		}

		// Token: 0x0601A5C1 RID: 107969 RVA: 0x0026E4AC File Offset: 0x0026C6AC
		public int AddEffect(UKuroMaterialControllerDataAsset DataAsset, bool bLoop = true, bool bPause = false, USkeletalMeshComponent AnimObject = null, bool bHiddenOnRemove = false, int InstanceIndex = -1)
		{
			return UKuroMaterialControllerComponent.__AddEffect_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero, bLoop, bPause, (AnimObject != null) ? AnimObject.NativePtr : IntPtr.Zero, bHiddenOnRemove, InstanceIndex);
		}

		// Token: 0x0601A5C2 RID: 107970 RVA: 0x0026E4E4 File Offset: 0x0026C6E4
		[NullableContext(1)]
		public unsafe void AddColorUpdateParamPermanentCustom(FName Name, FLinearColor Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, string CustomPartName)
		{
			FString fstring = FString.AllocTemp(CustomPartName);
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentCustom_Internal(base.NativePtr, Name, Value, BodyName, SlotType, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601A5C3 RID: 107971 RVA: 0x0026E514 File Offset: 0x0026C714
		public void AddColorUpdateParamPermanentCommon(FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentCommon_Internal(base.NativePtr, Name, Value, BodyType, SlotType);
		}

		// Token: 0x0601A5C4 RID: 107972 RVA: 0x0026E526 File Offset: 0x0026C726
		public void AddColorUpdateParamPermanentByIndex(FName Name, FLinearColor Value, FName BodyName, int MaterialIndex)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanentByIndex_Internal(base.NativePtr, Name, Value, BodyName, MaterialIndex);
		}

		// Token: 0x0601A5C5 RID: 107973 RVA: 0x0026E538 File Offset: 0x0026C738
		public void AddColorUpdateParamPermanent(FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart)
		{
			UKuroMaterialControllerComponent.__AddColorUpdateParamPermanent_Internal(base.NativePtr, Name, Value, BodyType, SlotType, MeshPart);
		}

		// Token: 0x0601A5C6 RID: 107974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffects_Internal(IntPtr @this);

		// Token: 0x0601A5C7 RID: 107975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterEffectKey_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0601A5C8 RID: 107976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateForce_Internal(IntPtr @this, bool bInUpdateForce);

		// Token: 0x0601A5C9 RID: 107977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonCustomStencilValue_Internal(IntPtr @this, int Value);

		// Token: 0x0601A5CA RID: 107978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshComponentUpdateGroup_Internal(IntPtr @this, FName BodyName, FName NewUpdateGroupId);

		// Token: 0x0601A5CB RID: 107979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitTakeOver_Internal(IntPtr @this, bool InTakeOver);

		// Token: 0x0601A5CC RID: 107980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandlePause_Internal(IntPtr @this, int HandleId, bool bPause);

		// Token: 0x0601A5CD RID: 107981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandleLoop_Internal(IntPtr @this, int HandleId, bool bLoop, bool bSeekToEnd, int InstanceIndex);

		// Token: 0x0601A5CE RID: 107982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHandleEnabled_Internal(IntPtr @this, int HandleId, bool bEnabled);

		// Token: 0x0601A5CF RID: 107983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceCustom_Internal(IntPtr @this, IntPtr Mat, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A5D0 RID: 107984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceCommon_Internal(IntPtr @this, IntPtr Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A5D1 RID: 107985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplaceByIndex_Internal(IntPtr @this, IntPtr Mat, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5D2 RID: 107986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalMaterialReplace_Internal(IntPtr @this, IntPtr Mat, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A5D3 RID: 107987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseMaterialByIndex_Internal(IntPtr @this, IntPtr Mat, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5D4 RID: 107988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodyNoWater_Internal(IntPtr @this, bool bNoWater);

		// Token: 0x0601A5D5 RID: 107989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekHandleFactor_Internal(IntPtr @this, int HandleId, float AbsoluteFactor);

		// Token: 0x0601A5D6 RID: 107990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekFactor_Internal(IntPtr @this, float AbsoluteFactor, bool bIncludePaused);

		// Token: 0x0601A5D7 RID: 107991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllBodyInfo_Internal(IntPtr @this);

		// Token: 0x0601A5D8 RID: 107992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A5D9 RID: 107993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A5DA RID: 107994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5DB RID: 107995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTextureUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A5DC RID: 107996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSkeletalMeshComponent_Internal(IntPtr @this, FName BodyName);

		// Token: 0x0601A5DD RID: 107997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A5DE RID: 107998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A5DF RID: 107999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5E0 RID: 108000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFloatUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A5E1 RID: 108001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalOutlineStencilTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A5E2 RID: 108002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceCustom_Internal(IntPtr @this, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A5E3 RID: 108003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceCommon_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A5E4 RID: 108004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplaceByIndex_Internal(IntPtr @this, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5E5 RID: 108005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalMaterialReplace_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A5E6 RID: 108006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalBattleRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A5E7 RID: 108007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalBattleMaskRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A5E8 RID: 108008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveExternalAlphaTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A5E9 RID: 108009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEffect_Internal(IntPtr @this, int HandleId, int InstanceIndex);

		// Token: 0x0601A5EA RID: 108010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RemoveDeadEffects_Internal(IntPtr @this);

		// Token: 0x0601A5EB RID: 108011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A5EC RID: 108012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A5ED RID: 108013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FName BodyName, int MaterialIndex);

		// Token: 0x0601A5EE RID: 108014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveColorUpdateParamPermanent_Internal(IntPtr @this, FName Name, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A5EF RID: 108015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RemoveAllUnloopedEffects_Internal(IntPtr @this);

		// Token: 0x0601A5F0 RID: 108016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllEffects_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0601A5F1 RID: 108017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPreBodyInfoRuntimeInitEvent_Internal(IntPtr @this, IntPtr Event);

		// Token: 0x0601A5F2 RID: 108018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterPostBodyInfoRuntimeInitEvent_Internal(IntPtr @this, IntPtr Event);

		// Token: 0x0601A5F3 RID: 108019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEffectKey_Internal(IntPtr @this, FName KeyName, int HandleId);

		// Token: 0x0601A5F4 RID: 108020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshFilter_Internal(IntPtr @this, int HandleId);

		// Token: 0x0601A5F5 RID: 108021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostComponentsVisibilityChanged_Internal(IntPtr @this);

		// Token: 0x0601A5F6 RID: 108022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkForceUpdateAllOnce_Internal(IntPtr @this);

		// Token: 0x0601A5F7 RID: 108023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualTick_Internal(IntPtr @this, float DeltaSeconds, bool bIncludePaused, bool bIncludeNewEffects, float LogicalTimeDilation);

		// Token: 0x0601A5F8 RID: 108024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitFromOwner_Internal(IntPtr @this);

		// Token: 0x0601A5F9 RID: 108025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshComponentName_Internal(IntPtr @this, FName BodyName);

		// Token: 0x0601A5FA RID: 108026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshComponent_Internal(IntPtr @this, IntPtr SkeletalMeshComponent);

		// Token: 0x0601A5FB RID: 108027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetSkeletalMeshComponentBodyName_Internal(IntPtr @this, IntPtr SkeletalMeshComponent);

		// Token: 0x0601A5FC RID: 108028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredSkeletalMeshComponentByType_Internal(IntPtr @this, EKuroCharBodyType BodyType, int Index);

		// Token: 0x0601A5FD RID: 108029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredSkeletalMeshComponent_Internal(IntPtr @this, FName BodyName);

		// Token: 0x0601A5FE RID: 108030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstanceUpdateParams_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0601A5FF RID: 108031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHandleLoop_Internal(IntPtr @this, int HandleId, int InstanceIndex);

		// Token: 0x0601A600 RID: 108032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectKey_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0601A601 RID: 108033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBodyOpacity_Internal(IntPtr @this);

		// Token: 0x0601A602 RID: 108034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAnyUnloopEffect_Internal(IntPtr @this);

		// Token: 0x0601A603 RID: 108035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllRegisteredBodyNames_Internal(IntPtr @this);

		// Token: 0x0601A604 RID: 108036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllInstanceUpdateParamIndices_Internal(IntPtr @this);

		// Token: 0x0601A605 RID: 108037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllHandles_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0601A606 RID: 108038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckInit_Internal(IntPtr @this);

		// Token: 0x0601A607 RID: 108039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, IntPtr Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A608 RID: 108040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, IntPtr Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A609 RID: 108041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, IntPtr Value, FName BodyName, int MaterialIndex);

		// Token: 0x0601A60A RID: 108042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTextureUpdateParamPermanent_Internal(IntPtr @this, FName Name, IntPtr Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A60B RID: 108043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSkeletalMeshComponent_Internal(IntPtr @this, IntPtr SkeletalMeshComponent, FName BodyName, bool bUseEmptyMaterial);

		// Token: 0x0601A60C RID: 108044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddOrGetMaterialControllerComponentFromActorWithoutInit_Internal(IntPtr Actor);

		// Token: 0x0601A60D RID: 108045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddOrGetMaterialControllerComponentFromActor_Internal(IntPtr Actor);

		// Token: 0x0601A60E RID: 108046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, float Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A60F RID: 108047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A610 RID: 108048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, float Value, FName BodyName, int MaterialIndex);

		// Token: 0x0601A611 RID: 108049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatUpdateParamPermanent_Internal(IntPtr @this, FName Name, float Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A612 RID: 108050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalOutlineStencilTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A613 RID: 108051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalBattleRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A614 RID: 108052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalBattleMaskRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A615 RID: 108053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddExternalAlphaTestRefCount_Internal(IntPtr @this, EKuroCharBodySpecifiedType BodyType);

		// Token: 0x0601A616 RID: 108054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddEffectRaw_Internal(IntPtr @this, IntPtr DataCache, bool bLoop, bool bPause, IntPtr AnimObject, bool bHiddenOnRemove, int InstanceIndex, bool bReceiveLogicalTimeDilation);

		// Token: 0x0601A617 RID: 108055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddEffect_Ex_Internal(IntPtr @this, IntPtr DataAsset, bool bLoop, bool bPause, IntPtr AnimObject, bool bHiddenOnRemove, int InstanceIndex);

		// Token: 0x0601A618 RID: 108056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddEffect_Internal(IntPtr @this, IntPtr DataAsset, bool bLoop, bool bPause, IntPtr AnimObject, bool bHiddenOnRemove, int InstanceIndex);

		// Token: 0x0601A619 RID: 108057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentCustom_Internal(IntPtr @this, FName Name, FLinearColor Value, FName BodyName, EKuroCharSlotSpecifiedType SlotType, in FString CustomPartName);

		// Token: 0x0601A61A RID: 108058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentCommon_Internal(IntPtr @this, FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType);

		// Token: 0x0601A61B RID: 108059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanentByIndex_Internal(IntPtr @this, FName Name, FLinearColor Value, FName BodyName, int MaterialIndex);

		// Token: 0x0601A61C RID: 108060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColorUpdateParamPermanent_Internal(IntPtr @this, FName Name, FLinearColor Value, EKuroCharBodySpecifiedType BodyType, EKuroCharSlotSpecifiedType SlotType, EKuroCharMeshPart MeshPart);

		// Token: 0x0601A61D RID: 108061 RVA: 0x0026E54C File Offset: 0x0026C74C
		static UKuroMaterialControllerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent");
		}

		// Token: 0x0601A61E RID: 108062 RVA: 0x0026E55A File Offset: 0x0026C75A
		protected UKuroMaterialControllerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E4B7 RID: 58551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponent";

		// Token: 0x0400E4B8 RID: 58552
		private static IntPtr _ClassPtr;

		// Token: 0x0400E4B9 RID: 58553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E4BA RID: 58554
		internal static int __PropertyOffset_bInitTakeOver;
	}
}
