using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012EB RID: 4843
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011BF9 RID: 72697 RVA: 0x001A0CD2 File Offset: 0x0019EED2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06011BFA RID: 72698 RVA: 0x001A0CE0 File Offset: 0x0019EEE0
		public UAbilitySystemBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011BFB RID: 72699 RVA: 0x001A0D08 File Offset: 0x0019EF08
		[NullableContext(1)]
		public UAbilitySystemBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011BFC RID: 72700 RVA: 0x001A0D3B File Offset: 0x0019EF3B
		public static bool TargetDataHasOrigin(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__TargetDataHasOrigin_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011BFD RID: 72701 RVA: 0x001A0D53 File Offset: 0x0019EF53
		public static bool TargetDataHasHitResult(in FGameplayAbilityTargetDataHandle HitResult, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__TargetDataHasHitResult_Internal((HitResult ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011BFE RID: 72702 RVA: 0x001A0D6B File Offset: 0x0019EF6B
		public static bool TargetDataHasEndPoint(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__TargetDataHasEndPoint_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011BFF RID: 72703 RVA: 0x001A0D83 File Offset: 0x0019EF83
		public static bool TargetDataHasActor(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__TargetDataHasActor_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011C00 RID: 72704 RVA: 0x001A0D9B File Offset: 0x0019EF9B
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle SetStackCountToMax([Nullable(2)] FGameplayEffectSpecHandle SpecHandle)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__SetStackCountToMax_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011C01 RID: 72705 RVA: 0x001A0DB7 File Offset: 0x0019EFB7
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle SetStackCount([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, int StackCount)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__SetStackCount_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, StackCount), null);
		}

		// Token: 0x06011C02 RID: 72706 RVA: 0x001A0DD4 File Offset: 0x0019EFD4
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle SetDuration([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, float Duration)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__SetDuration_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, Duration), null);
		}

		// Token: 0x06011C03 RID: 72707 RVA: 0x001A0DF1 File Offset: 0x0019EFF1
		public static void SendGameplayEventToActor(AActor Actor, FGameplayTag EventTag, FGameplayEventData Payload)
		{
			UAbilitySystemBlueprintLibrary.__SendGameplayEventToActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, EventTag, (Payload ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06011C04 RID: 72708 RVA: 0x001A0E18 File Offset: 0x0019F018
		public static bool NotEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA, FGameplayAttribute AttributeB)
		{
			return UAbilitySystemBlueprintLibrary.__NotEqual_GameplayAttributeGameplayAttribute_Internal((AttributeA ?? new FGameplayAttribute()).NativePtr, (AttributeB ?? new FGameplayAttribute()).NativePtr);
		}

		// Token: 0x06011C05 RID: 72709 RVA: 0x001A0E3D File Offset: 0x0019F03D
		[return: Nullable(1)]
		public static FGameplayEffectSpecHandle MakeSpecHandle(UGameplayEffect InGameplayEffect, AActor InInstigator, AActor InEffectCauser, float InLevel = 1f)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__MakeSpecHandle_Internal((InGameplayEffect != null) ? InGameplayEffect.NativePtr : IntPtr.Zero, (InInstigator != null) ? InInstigator.NativePtr : IntPtr.Zero, (InEffectCauser != null) ? InEffectCauser.NativePtr : IntPtr.Zero, InLevel), null);
		}

		// Token: 0x06011C06 RID: 72710 RVA: 0x001A0E7C File Offset: 0x0019F07C
		[return: Nullable(1)]
		public static FGameplayCueParameters MakeGameplayCueParameters(float NormalizedMagnitude, float RawMagnitude, FGameplayEffectContextHandle EffectContext, FGameplayTag MatchedTagName, FGameplayTag OriginalTag, FGameplayTagContainer AggregatedSourceTags, FGameplayTagContainer AggregatedTargetTags, FVector Location, FVector Normal, AActor Instigator, AActor EffectCauser, UObject SourceObject, UPhysicalMaterial PhysicalMaterial, int GameplayEffectLevel, int AbilityLevel, USceneComponent TargetAttachComponent)
		{
			return new FGameplayCueParameters(UAbilitySystemBlueprintLibrary.__MakeGameplayCueParameters_Internal(NormalizedMagnitude, RawMagnitude, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr, MatchedTagName, OriginalTag, (AggregatedSourceTags ?? new FGameplayTagContainer()).NativePtr, (AggregatedTargetTags ?? new FGameplayTagContainer()).NativePtr, Location, Normal, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero, (EffectCauser != null) ? EffectCauser.NativePtr : IntPtr.Zero, (SourceObject != null) ? SourceObject.NativePtr : IntPtr.Zero, (PhysicalMaterial != null) ? PhysicalMaterial.NativePtr : IntPtr.Zero, GameplayEffectLevel, AbilityLevel, (TargetAttachComponent != null) ? TargetAttachComponent.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06011C07 RID: 72711 RVA: 0x001A0F2A File Offset: 0x0019F12A
		[return: Nullable(1)]
		public static FGameplayTargetDataFilterHandle MakeFilterHandle(FGameplayTargetDataFilter Filter, AActor FilterActor)
		{
			return new FGameplayTargetDataFilterHandle(UAbilitySystemBlueprintLibrary.__MakeFilterHandle_Internal((Filter ?? new FGameplayTargetDataFilter()).NativePtr, (FilterActor != null) ? FilterActor.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06011C08 RID: 72712 RVA: 0x001A0F56 File Offset: 0x0019F156
		public static bool IsValid(FGameplayAttribute Attribute)
		{
			return UAbilitySystemBlueprintLibrary.__IsValid_Internal((Attribute ?? new FGameplayAttribute()).NativePtr);
		}

		// Token: 0x06011C09 RID: 72713 RVA: 0x001A0F6C File Offset: 0x0019F16C
		public static bool IsInstigatorLocallyControlledPlayer(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__IsInstigatorLocallyControlledPlayer_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C0A RID: 72714 RVA: 0x001A0F82 File Offset: 0x0019F182
		public static bool IsInstigatorLocallyControlled(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__IsInstigatorLocallyControlled_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C0B RID: 72715 RVA: 0x001A0F98 File Offset: 0x0019F198
		public static bool HasHitResult(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__HasHitResult_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C0C RID: 72716 RVA: 0x001A0FAE File Offset: 0x0019F1AE
		public static FTransform GetTargetDataOrigin(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__GetTargetDataOrigin_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011C0D RID: 72717 RVA: 0x001A0FC6 File Offset: 0x0019F1C6
		public static FTransform GetTargetDataEndPointTransform(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__GetTargetDataEndPointTransform_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011C0E RID: 72718 RVA: 0x001A0FDE File Offset: 0x0019F1DE
		public static FVector GetTargetDataEndPoint(in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return UAbilitySystemBlueprintLibrary.__GetTargetDataEndPoint_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index);
		}

		// Token: 0x06011C0F RID: 72719 RVA: 0x001A0FF6 File Offset: 0x0019F1F6
		public static FVector GetOrigin(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__GetOrigin_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C10 RID: 72720 RVA: 0x001A100C File Offset: 0x0019F20C
		public static float GetModifiedAttributeMagnitude(FGameplayEffectSpecHandle SpecHandle, FGameplayAttribute Attribute)
		{
			return UAbilitySystemBlueprintLibrary.__GetModifiedAttributeMagnitude_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (Attribute ?? new FGameplayAttribute()).NativePtr);
		}

		// Token: 0x06011C11 RID: 72721 RVA: 0x001A1031 File Offset: 0x0019F231
		public static FTransform GetInstigatorTransform(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__GetInstigatorTransform_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C12 RID: 72722 RVA: 0x001A1047 File Offset: 0x0019F247
		public static AActor GetInstigatorActor(FGameplayCueParameters Parameters)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAbilitySystemBlueprintLibrary.__GetInstigatorActor_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr));
		}

		// Token: 0x06011C13 RID: 72723 RVA: 0x001A1062 File Offset: 0x0019F262
		[NullableContext(1)]
		public static FHitResult GetHitResultFromTargetData([Nullable(2)] in FGameplayAbilityTargetDataHandle HitResult, int Index)
		{
			return new FHitResult(UAbilitySystemBlueprintLibrary.__GetHitResultFromTargetData_Internal((HitResult ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index), null);
		}

		// Token: 0x06011C14 RID: 72724 RVA: 0x001A1080 File Offset: 0x0019F280
		[NullableContext(1)]
		public static FHitResult GetHitResult([Nullable(2)] FGameplayCueParameters Parameters)
		{
			return new FHitResult(UAbilitySystemBlueprintLibrary.__GetHitResult_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr), null);
		}

		// Token: 0x06011C15 RID: 72725 RVA: 0x001A109C File Offset: 0x0019F29C
		public unsafe static bool GetGameplayCueEndLocationAndNormal(AActor TargetActor, FGameplayCueParameters Parameters, ref FVector Location, ref FVector Normal)
		{
			fixed (FVector* ptr = &Location)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Normal)
				{
					void* ptr4 = (void*)ptr3;
					return UAbilitySystemBlueprintLibrary.__GetGameplayCueEndLocationAndNormal_Internal((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr, ref Location, ref Normal);
				}
			}
		}

		// Token: 0x06011C16 RID: 72726 RVA: 0x001A10DC File Offset: 0x0019F2DC
		public unsafe static bool GetGameplayCueDirection(AActor TargetActor, FGameplayCueParameters Parameters, ref FVector Direction)
		{
			fixed (FVector* ptr = &Direction)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__GetGameplayCueDirection_Internal((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, (Parameters ?? new FGameplayCueParameters()).NativePtr, ref Direction);
			}
		}

		// Token: 0x06011C17 RID: 72727 RVA: 0x001A1114 File Offset: 0x0019F314
		public unsafe static float GetFloatAttributeFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystem, FGameplayAttribute Attribute, ref bool bSuccessfullyFoundAttribute)
		{
			fixed (bool* ptr = &bSuccessfullyFoundAttribute)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__GetFloatAttributeFromAbilitySystemComponent_Internal((AbilitySystem != null) ? AbilitySystem.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, ref bSuccessfullyFoundAttribute);
			}
		}

		// Token: 0x06011C18 RID: 72728 RVA: 0x001A114C File Offset: 0x0019F34C
		public unsafe static float GetFloatAttributeBaseFromAbilitySystemComponent(UAbilitySystemComponent AbilitySystemComponent, FGameplayAttribute Attribute, ref bool bSuccessfullyFoundAttribute)
		{
			fixed (bool* ptr = &bSuccessfullyFoundAttribute)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__GetFloatAttributeBaseFromAbilitySystemComponent_Internal((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, ref bSuccessfullyFoundAttribute);
			}
		}

		// Token: 0x06011C19 RID: 72729 RVA: 0x001A1184 File Offset: 0x0019F384
		public unsafe static float GetFloatAttributeBase(AActor Actor, FGameplayAttribute Attribute, ref bool bSuccessfullyFoundAttribute)
		{
			fixed (bool* ptr = &bSuccessfullyFoundAttribute)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__GetFloatAttributeBase_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, ref bSuccessfullyFoundAttribute);
			}
		}

		// Token: 0x06011C1A RID: 72730 RVA: 0x001A11BC File Offset: 0x0019F3BC
		public unsafe static float GetFloatAttribute(AActor Actor, FGameplayAttribute Attribute, ref bool bSuccessfullyFoundAttribute)
		{
			fixed (bool* ptr = &bSuccessfullyFoundAttribute)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__GetFloatAttribute_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, ref bSuccessfullyFoundAttribute);
			}
		}

		// Token: 0x06011C1B RID: 72731 RVA: 0x001A11F3 File Offset: 0x0019F3F3
		[NullableContext(1)]
		public static FGameplayEffectContextHandle GetEffectContext([Nullable(2)] FGameplayEffectSpecHandle SpecHandle)
		{
			return new FGameplayEffectContextHandle(UAbilitySystemBlueprintLibrary.__GetEffectContext_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011C1C RID: 72732 RVA: 0x001A120F File Offset: 0x0019F40F
		public static int GetDataCountFromTargetData(in FGameplayAbilityTargetDataHandle TargetData)
		{
			return UAbilitySystemBlueprintLibrary.__GetDataCountFromTargetData_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr);
		}

		// Token: 0x06011C1D RID: 72733 RVA: 0x001A1226 File Offset: 0x0019F426
		[NullableContext(1)]
		public static TArray<FGameplayEffectSpecHandle> GetAllLinkedGameplayEffectSpecHandles([Nullable(2)] FGameplayEffectSpecHandle SpecHandle)
		{
			return new TArray<FGameplayEffectSpecHandle>(UAbilitySystemBlueprintLibrary.__GetAllLinkedGameplayEffectSpecHandles_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011C1E RID: 72734 RVA: 0x001A1242 File Offset: 0x0019F442
		[NullableContext(1)]
		public static TArray<AActor> GetAllActorsFromTargetData([Nullable(2)] in FGameplayAbilityTargetDataHandle TargetData)
		{
			return new TArray<AActor>(UAbilitySystemBlueprintLibrary.__GetAllActorsFromTargetData_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr), null);
		}

		// Token: 0x06011C1F RID: 72735 RVA: 0x001A125F File Offset: 0x0019F45F
		[NullableContext(1)]
		public static TArray<AActor> GetActorsFromTargetData([Nullable(2)] in FGameplayAbilityTargetDataHandle TargetData, int Index)
		{
			return new TArray<AActor>(UAbilitySystemBlueprintLibrary.__GetActorsFromTargetData_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index), null);
		}

		// Token: 0x06011C20 RID: 72736 RVA: 0x001A127D File Offset: 0x0019F47D
		public static int GetActorCount(FGameplayCueParameters Parameters)
		{
			return UAbilitySystemBlueprintLibrary.__GetActorCount_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C21 RID: 72737 RVA: 0x001A1293 File Offset: 0x0019F493
		public static AActor GetActorByIndex(FGameplayCueParameters Parameters, int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAbilitySystemBlueprintLibrary.__GetActorByIndex_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr, Index));
		}

		// Token: 0x06011C22 RID: 72738 RVA: 0x001A12AF File Offset: 0x0019F4AF
		public static float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectTotalDuration_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C23 RID: 72739 RVA: 0x001A12C5 File Offset: 0x0019F4C5
		public static float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStartTime_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C24 RID: 72740 RVA: 0x001A12DB File Offset: 0x0019F4DB
		public static int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStackLimitCount_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C25 RID: 72741 RVA: 0x001A12F1 File Offset: 0x0019F4F1
		public static int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStackCount_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C26 RID: 72742 RVA: 0x001A1307 File Offset: 0x0019F507
		public static float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject, FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectRemainingDuration_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C27 RID: 72743 RVA: 0x001A132D File Offset: 0x0019F52D
		public static float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectExpectedEndTime_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06011C28 RID: 72744 RVA: 0x001A1343 File Offset: 0x0019F543
		[NullableContext(1)]
		public static string GetActiveGameplayEffectDebugString([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return FString.ToStringAndDeleteNativePtr(UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectDebugString_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06011C29 RID: 72745 RVA: 0x001A135E File Offset: 0x0019F55E
		public static UAbilitySystemComponent GetAbilitySystemComponent(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilitySystemComponent>(UAbilitySystemBlueprintLibrary.__GetAbilitySystemComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011C2A RID: 72746 RVA: 0x001A137C File Offset: 0x0019F57C
		public static void ForwardGameplayCueToTarget(IGameplayCueInterface TargetCueInterface, EGameplayCueEvent EventType, FGameplayCueParameters Parameters)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(TargetCueInterface, (TargetCueInterface != null) ? TargetCueInterface.InterfaceOffset() : 0);
			UAbilitySystemBlueprintLibrary.__ForwardGameplayCueToTarget_Internal(fscriptInterface, EventType, (Parameters ?? new FGameplayCueParameters()).NativePtr);
		}

		// Token: 0x06011C2B RID: 72747 RVA: 0x001A13B9 File Offset: 0x0019F5B9
		[return: Nullable(1)]
		public static FGameplayAbilityTargetDataHandle FilterTargetData(in FGameplayAbilityTargetDataHandle TargetDataHandle, FGameplayTargetDataFilterHandle ActorFilterClass)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__FilterTargetData_Internal((TargetDataHandle ?? new FGameplayAbilityTargetDataHandle()).NativePtr, (ActorFilterClass ?? new FGameplayTargetDataFilterHandle()).NativePtr), null);
		}

		// Token: 0x06011C2C RID: 72748 RVA: 0x001A13E8 File Offset: 0x0019F5E8
		public unsafe static float EvaluateAttributeValueWithTagsAndBase(UAbilitySystemComponent AbilitySystem, FGameplayAttribute Attribute, in FGameplayTagContainer SourceTags, in FGameplayTagContainer TargetTags, float BaseValue, ref bool bSuccess)
		{
			fixed (bool* ptr = &bSuccess)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__EvaluateAttributeValueWithTagsAndBase_Internal((AbilitySystem != null) ? AbilitySystem.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, (SourceTags ?? new FGameplayTagContainer()).NativePtr, (TargetTags ?? new FGameplayTagContainer()).NativePtr, BaseValue, ref bSuccess);
			}
		}

		// Token: 0x06011C2D RID: 72749 RVA: 0x001A1444 File Offset: 0x0019F644
		public unsafe static float EvaluateAttributeValueWithTags(UAbilitySystemComponent AbilitySystem, FGameplayAttribute Attribute, in FGameplayTagContainer SourceTags, in FGameplayTagContainer TargetTags, ref bool bSuccess)
		{
			fixed (bool* ptr = &bSuccess)
			{
				void* ptr2 = (void*)ptr;
				return UAbilitySystemBlueprintLibrary.__EvaluateAttributeValueWithTags_Internal((AbilitySystem != null) ? AbilitySystem.NativePtr : IntPtr.Zero, (Attribute ?? new FGameplayAttribute()).NativePtr, (SourceTags ?? new FGameplayTagContainer()).NativePtr, (TargetTags ?? new FGameplayTagContainer()).NativePtr, ref bSuccess);
			}
		}

		// Token: 0x06011C2E RID: 72750 RVA: 0x001A149D File Offset: 0x0019F69D
		public static bool EqualEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA, FGameplayAttribute AttributeB)
		{
			return UAbilitySystemBlueprintLibrary.__EqualEqual_GameplayAttributeGameplayAttribute_Internal((AttributeA ?? new FGameplayAttribute()).NativePtr, (AttributeB ?? new FGameplayAttribute()).NativePtr);
		}

		// Token: 0x06011C2F RID: 72751 RVA: 0x001A14C2 File Offset: 0x0019F6C2
		public static void EffectContextSetOrigin(FGameplayEffectContextHandle EffectContext, FVector Origin)
		{
			UAbilitySystemBlueprintLibrary.__EffectContextSetOrigin_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr, Origin);
		}

		// Token: 0x06011C30 RID: 72752 RVA: 0x001A14D9 File Offset: 0x0019F6D9
		public static bool EffectContextIsValid(FGameplayEffectContextHandle EffectContext)
		{
			return UAbilitySystemBlueprintLibrary.__EffectContextIsValid_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011C31 RID: 72753 RVA: 0x001A14EF File Offset: 0x0019F6EF
		public static bool EffectContextIsInstigatorLocallyControlled(FGameplayEffectContextHandle EffectContext)
		{
			return UAbilitySystemBlueprintLibrary.__EffectContextIsInstigatorLocallyControlled_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011C32 RID: 72754 RVA: 0x001A1505 File Offset: 0x0019F705
		public static bool EffectContextHasHitResult(FGameplayEffectContextHandle EffectContext)
		{
			return UAbilitySystemBlueprintLibrary.__EffectContextHasHitResult_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011C33 RID: 72755 RVA: 0x001A151B File Offset: 0x0019F71B
		public static UObject EffectContextGetSourceObject(FGameplayEffectContextHandle EffectContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UAbilitySystemBlueprintLibrary.__EffectContextGetSourceObject_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr));
		}

		// Token: 0x06011C34 RID: 72756 RVA: 0x001A1536 File Offset: 0x0019F736
		public static AActor EffectContextGetOriginalInstigatorActor(FGameplayEffectContextHandle EffectContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAbilitySystemBlueprintLibrary.__EffectContextGetOriginalInstigatorActor_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr));
		}

		// Token: 0x06011C35 RID: 72757 RVA: 0x001A1551 File Offset: 0x0019F751
		public static FVector EffectContextGetOrigin(FGameplayEffectContextHandle EffectContext)
		{
			return UAbilitySystemBlueprintLibrary.__EffectContextGetOrigin_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr);
		}

		// Token: 0x06011C36 RID: 72758 RVA: 0x001A1567 File Offset: 0x0019F767
		public static AActor EffectContextGetInstigatorActor(FGameplayEffectContextHandle EffectContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAbilitySystemBlueprintLibrary.__EffectContextGetInstigatorActor_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr));
		}

		// Token: 0x06011C37 RID: 72759 RVA: 0x001A1582 File Offset: 0x0019F782
		[NullableContext(1)]
		public static FHitResult EffectContextGetHitResult([Nullable(2)] FGameplayEffectContextHandle EffectContext)
		{
			return new FHitResult(UAbilitySystemBlueprintLibrary.__EffectContextGetHitResult_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr), null);
		}

		// Token: 0x06011C38 RID: 72760 RVA: 0x001A159E File Offset: 0x0019F79E
		public static AActor EffectContextGetEffectCauser(FGameplayEffectContextHandle EffectContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UAbilitySystemBlueprintLibrary.__EffectContextGetEffectCauser_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr));
		}

		// Token: 0x06011C39 RID: 72761 RVA: 0x001A15B9 File Offset: 0x0019F7B9
		public static void EffectContextAddHitResult(FGameplayEffectContextHandle EffectContext, FHitResult HitResult, bool bReset)
		{
			UAbilitySystemBlueprintLibrary.__EffectContextAddHitResult_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr, (HitResult ?? new FHitResult()).NativePtr, bReset);
		}

		// Token: 0x06011C3A RID: 72762 RVA: 0x001A15DF File Offset: 0x0019F7DF
		public static bool DoesTargetDataContainActor(in FGameplayAbilityTargetDataHandle TargetData, int Index, AActor Actor)
		{
			return UAbilitySystemBlueprintLibrary.__DoesTargetDataContainActor_Internal((TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Index, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011C3B RID: 72763 RVA: 0x001A1607 File Offset: 0x0019F807
		public static bool DoesGameplayCueMeetTagRequirements(FGameplayCueParameters Parameters, in FGameplayTagRequirements SourceTagReqs, in FGameplayTagRequirements TargetTagReqs)
		{
			return UAbilitySystemBlueprintLibrary.__DoesGameplayCueMeetTagRequirements_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr, (SourceTagReqs ?? new FGameplayTagRequirements()).NativePtr, (TargetTagReqs ?? new FGameplayTagRequirements()).NativePtr);
		}

		// Token: 0x06011C3C RID: 72764 RVA: 0x001A163D File Offset: 0x0019F83D
		[return: Nullable(1)]
		public static FGameplayEffectSpecHandle CloneSpecHandle(AActor InNewInstigator, AActor InEffectCauser, FGameplayEffectSpecHandle GameplayEffectSpecHandle_Clone)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__CloneSpecHandle_Internal((InNewInstigator != null) ? InNewInstigator.NativePtr : IntPtr.Zero, (InEffectCauser != null) ? InEffectCauser.NativePtr : IntPtr.Zero, (GameplayEffectSpecHandle_Clone ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011C3D RID: 72765 RVA: 0x001A167C File Offset: 0x0019F87C
		public unsafe static void BreakGameplayCueParameters(in FGameplayCueParameters Parameters, ref float NormalizedMagnitude, ref float RawMagnitude, ref FGameplayEffectContextHandle EffectContext, ref FGameplayTag MatchedTagName, ref FGameplayTag OriginalTag, ref FGameplayTagContainer AggregatedSourceTags, ref FGameplayTagContainer AggregatedTargetTags, ref FVector Location, ref FVector Normal, ref AActor Instigator, ref AActor EffectCauser, ref UObject SourceObject, ref UPhysicalMaterial PhysicalMaterial, ref int GameplayEffectLevel, ref int AbilityLevel, ref USceneComponent TargetAttachComponent)
		{
			AActor aactor = Instigator;
			IntPtr nativeObjectPtr = (aactor != null) ? aactor.NativePtr : IntPtr.Zero;
			AActor aactor2 = EffectCauser;
			IntPtr nativeObjectPtr2 = (aactor2 != null) ? aactor2.NativePtr : IntPtr.Zero;
			UObject uobject = SourceObject;
			IntPtr nativeObjectPtr3 = (uobject != null) ? uobject.NativePtr : IntPtr.Zero;
			UPhysicalMaterial uphysicalMaterial = PhysicalMaterial;
			IntPtr nativeObjectPtr4 = (uphysicalMaterial != null) ? uphysicalMaterial.NativePtr : IntPtr.Zero;
			USceneComponent usceneComponent = TargetAttachComponent;
			IntPtr nativeObjectPtr5 = (usceneComponent != null) ? usceneComponent.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &NormalizedMagnitude)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &RawMagnitude)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FGameplayTag* ptr5 = &MatchedTagName)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FGameplayTag* ptr7 = &OriginalTag)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &Location)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &Normal)
								{
									void* ptr12 = (void*)ptr11;
									fixed (int* ptr13 = &GameplayEffectLevel)
									{
										void* ptr14 = (void*)ptr13;
										fixed (int* ptr15 = &AbilityLevel)
										{
											void* ptr16 = (void*)ptr15;
											UAbilitySystemBlueprintLibrary.__BreakGameplayCueParameters_Internal((Parameters ?? new FGameplayCueParameters()).NativePtr, ref NormalizedMagnitude, ref RawMagnitude, (EffectContext ?? new FGameplayEffectContextHandle()).NativePtr, ref MatchedTagName, ref OriginalTag, (AggregatedSourceTags ?? new FGameplayTagContainer()).NativePtr, (AggregatedTargetTags ?? new FGameplayTagContainer()).NativePtr, ref Location, ref Normal, ref nativeObjectPtr, ref nativeObjectPtr2, ref nativeObjectPtr3, ref nativeObjectPtr4, ref GameplayEffectLevel, ref AbilityLevel, ref nativeObjectPtr5);
											Instigator = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr);
											EffectCauser = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr2);
											SourceObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(nativeObjectPtr3);
											PhysicalMaterial = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(nativeObjectPtr4);
											TargetAttachComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(nativeObjectPtr5);
											ptr = null;
											ptr3 = null;
											ptr5 = null;
											ptr7 = null;
											ptr9 = null;
											ptr11 = null;
											ptr13 = null;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06011C3E RID: 72766 RVA: 0x001A17E1 File Offset: 0x0019F9E1
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AssignTagSetByCallerMagnitude([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, FGameplayTag DataTag, float Magnitude)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AssignTagSetByCallerMagnitude_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, DataTag, Magnitude), null);
		}

		// Token: 0x06011C3F RID: 72767 RVA: 0x001A17FF File Offset: 0x0019F9FF
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AssignSetByCallerMagnitude([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, int Key, float Magnitude)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AssignSetByCallerMagnitude_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, Key, Magnitude), null);
		}

		// Token: 0x06011C40 RID: 72768 RVA: 0x001A181D File Offset: 0x0019FA1D
		[return: Nullable(1)]
		public static FGameplayAbilityTargetDataHandle AppendTargetDataHandle(FGameplayAbilityTargetDataHandle TargetHandle, in FGameplayAbilityTargetDataHandle HandleToAdd)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__AppendTargetDataHandle_Internal((TargetHandle ?? new FGameplayAbilityTargetDataHandle()).NativePtr, (HandleToAdd ?? new FGameplayAbilityTargetDataHandle()).NativePtr), null);
		}

		// Token: 0x06011C41 RID: 72769 RVA: 0x001A1849 File Offset: 0x0019FA49
		[return: Nullable(1)]
		public static FGameplayEffectSpecHandle AddLinkedGameplayEffectSpec(FGameplayEffectSpecHandle SpecHandle, FGameplayEffectSpecHandle LinkedGameplayEffectSpec)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddLinkedGameplayEffectSpec_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (LinkedGameplayEffectSpec ?? new FGameplayEffectSpecHandle()).NativePtr), null);
		}

		// Token: 0x06011C42 RID: 72770 RVA: 0x001A1874 File Offset: 0x0019FA74
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AddLinkedGameplayEffect([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> LinkedGameplayEffect)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddLinkedGameplayEffect_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, LinkedGameplayEffect._NativePtr), null);
		}

		// Token: 0x06011C43 RID: 72771 RVA: 0x001A1896 File Offset: 0x0019FA96
		[return: Nullable(1)]
		public static FGameplayEffectSpecHandle AddGrantedTags(FGameplayEffectSpecHandle SpecHandle, FGameplayTagContainer NewGameplayTags)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddGrantedTags_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (NewGameplayTags ?? new FGameplayTagContainer()).NativePtr), null);
		}

		// Token: 0x06011C44 RID: 72772 RVA: 0x001A18C1 File Offset: 0x0019FAC1
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AddGrantedTag([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, FGameplayTag NewGameplayTag)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddGrantedTag_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, NewGameplayTag), null);
		}

		// Token: 0x06011C45 RID: 72773 RVA: 0x001A18DE File Offset: 0x0019FADE
		[return: Nullable(1)]
		public static FGameplayEffectSpecHandle AddAssetTags(FGameplayEffectSpecHandle SpecHandle, FGameplayTagContainer NewGameplayTags)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddAssetTags_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, (NewGameplayTags ?? new FGameplayTagContainer()).NativePtr), null);
		}

		// Token: 0x06011C46 RID: 72774 RVA: 0x001A1909 File Offset: 0x0019FB09
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AddAssetTag([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, FGameplayTag NewGameplayTag)
		{
			return new FGameplayEffectSpecHandle(UAbilitySystemBlueprintLibrary.__AddAssetTag_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, NewGameplayTag), null);
		}

		// Token: 0x06011C47 RID: 72775 RVA: 0x001A1926 File Offset: 0x0019FB26
		[return: Nullable(1)]
		public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromLocations(in FGameplayAbilityTargetingLocationInfo SourceLocation, in FGameplayAbilityTargetingLocationInfo TargetLocation)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__AbilityTargetDataFromLocations_Internal((SourceLocation ?? new FGameplayAbilityTargetingLocationInfo()).NativePtr, (TargetLocation ?? new FGameplayAbilityTargetingLocationInfo()).NativePtr), null);
		}

		// Token: 0x06011C48 RID: 72776 RVA: 0x001A1953 File Offset: 0x0019FB53
		[NullableContext(1)]
		public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromHitResult([Nullable(2)] in FHitResult HitResult)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__AbilityTargetDataFromHitResult_Internal((HitResult ?? new FHitResult()).NativePtr), null);
		}

		// Token: 0x06011C49 RID: 72777 RVA: 0x001A1970 File Offset: 0x0019FB70
		[NullableContext(1)]
		public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActorArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorArray, bool OneTargetPerHandle)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__AbilityTargetDataFromActorArray_Internal((ActorArray ?? new TArray<AActor>()).NativePtr, OneTargetPerHandle), null);
		}

		// Token: 0x06011C4A RID: 72778 RVA: 0x001A198E File Offset: 0x0019FB8E
		[NullableContext(1)]
		public static FGameplayAbilityTargetDataHandle AbilityTargetDataFromActor([Nullable(2)] AActor Actor)
		{
			return new FGameplayAbilityTargetDataHandle(UAbilitySystemBlueprintLibrary.__AbilityTargetDataFromActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06011C4B RID: 72779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TargetDataHasOrigin_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C4C RID: 72780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TargetDataHasHitResult_Internal(IntPtr HitResult, int Index);

		// Token: 0x06011C4D RID: 72781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TargetDataHasEndPoint_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C4E RID: 72782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TargetDataHasActor_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C4F RID: 72783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetStackCountToMax_Internal(IntPtr SpecHandle);

		// Token: 0x06011C50 RID: 72784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetStackCount_Internal(IntPtr SpecHandle, int StackCount);

		// Token: 0x06011C51 RID: 72785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetDuration_Internal(IntPtr SpecHandle, float Duration);

		// Token: 0x06011C52 RID: 72786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendGameplayEventToActor_Internal(IntPtr Actor, FGameplayTag EventTag, IntPtr Payload);

		// Token: 0x06011C53 RID: 72787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_GameplayAttributeGameplayAttribute_Internal(IntPtr AttributeA, IntPtr AttributeB);

		// Token: 0x06011C54 RID: 72788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSpecHandle_Internal(IntPtr InGameplayEffect, IntPtr InInstigator, IntPtr InEffectCauser, float InLevel);

		// Token: 0x06011C55 RID: 72789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayCueParameters_Internal(float NormalizedMagnitude, float RawMagnitude, IntPtr EffectContext, FGameplayTag MatchedTagName, FGameplayTag OriginalTag, IntPtr AggregatedSourceTags, IntPtr AggregatedTargetTags, FVector Location, FVector Normal, IntPtr Instigator, IntPtr EffectCauser, IntPtr SourceObject, IntPtr PhysicalMaterial, int GameplayEffectLevel, int AbilityLevel, IntPtr TargetAttachComponent);

		// Token: 0x06011C56 RID: 72790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeFilterHandle_Internal(IntPtr Filter, IntPtr FilterActor);

		// Token: 0x06011C57 RID: 72791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValid_Internal(IntPtr Attribute);

		// Token: 0x06011C58 RID: 72792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInstigatorLocallyControlledPlayer_Internal(IntPtr Parameters);

		// Token: 0x06011C59 RID: 72793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInstigatorLocallyControlled_Internal(IntPtr Parameters);

		// Token: 0x06011C5A RID: 72794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasHitResult_Internal(IntPtr Parameters);

		// Token: 0x06011C5B RID: 72795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTargetDataOrigin_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C5C RID: 72796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTargetDataEndPointTransform_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C5D RID: 72797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTargetDataEndPoint_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C5E RID: 72798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetOrigin_Internal(IntPtr Parameters);

		// Token: 0x06011C5F RID: 72799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetModifiedAttributeMagnitude_Internal(IntPtr SpecHandle, IntPtr Attribute);

		// Token: 0x06011C60 RID: 72800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetInstigatorTransform_Internal(IntPtr Parameters);

		// Token: 0x06011C61 RID: 72801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstigatorActor_Internal(IntPtr Parameters);

		// Token: 0x06011C62 RID: 72802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHitResultFromTargetData_Internal(IntPtr HitResult, int Index);

		// Token: 0x06011C63 RID: 72803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHitResult_Internal(IntPtr Parameters);

		// Token: 0x06011C64 RID: 72804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGameplayCueEndLocationAndNormal_Internal(IntPtr TargetActor, IntPtr Parameters, ref FVector Location, ref FVector Normal);

		// Token: 0x06011C65 RID: 72805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGameplayCueDirection_Internal(IntPtr TargetActor, IntPtr Parameters, ref FVector Direction);

		// Token: 0x06011C66 RID: 72806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatAttributeFromAbilitySystemComponent_Internal(IntPtr AbilitySystem, IntPtr Attribute, ref bool bSuccessfullyFoundAttribute);

		// Token: 0x06011C67 RID: 72807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatAttributeBaseFromAbilitySystemComponent_Internal(IntPtr AbilitySystemComponent, IntPtr Attribute, ref bool bSuccessfullyFoundAttribute);

		// Token: 0x06011C68 RID: 72808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatAttributeBase_Internal(IntPtr Actor, IntPtr Attribute, ref bool bSuccessfullyFoundAttribute);

		// Token: 0x06011C69 RID: 72809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatAttribute_Internal(IntPtr Actor, IntPtr Attribute, ref bool bSuccessfullyFoundAttribute);

		// Token: 0x06011C6A RID: 72810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEffectContext_Internal(IntPtr SpecHandle);

		// Token: 0x06011C6B RID: 72811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDataCountFromTargetData_Internal(IntPtr TargetData);

		// Token: 0x06011C6C RID: 72812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllLinkedGameplayEffectSpecHandles_Internal(IntPtr SpecHandle);

		// Token: 0x06011C6D RID: 72813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllActorsFromTargetData_Internal(IntPtr TargetData);

		// Token: 0x06011C6E RID: 72814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorsFromTargetData_Internal(IntPtr TargetData, int Index);

		// Token: 0x06011C6F RID: 72815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActorCount_Internal(IntPtr Parameters);

		// Token: 0x06011C70 RID: 72816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorByIndex_Internal(IntPtr Parameters, int Index);

		// Token: 0x06011C71 RID: 72817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectTotalDuration_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C72 RID: 72818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectStartTime_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C73 RID: 72819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectStackLimitCount_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C74 RID: 72820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectStackCount_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C75 RID: 72821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectRemainingDuration_Internal(IntPtr WorldContextObject, IntPtr ActiveHandle);

		// Token: 0x06011C76 RID: 72822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectExpectedEndTime_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C77 RID: 72823
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveGameplayEffectDebugString_Internal(IntPtr ActiveHandle);

		// Token: 0x06011C78 RID: 72824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAbilitySystemComponent_Internal(IntPtr Actor);

		// Token: 0x06011C79 RID: 72825
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForwardGameplayCueToTarget_Internal(in FScriptInterface TargetCueInterface, TEnumAsByte<EGameplayCueEvent> EventType, IntPtr Parameters);

		// Token: 0x06011C7A RID: 72826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FilterTargetData_Internal(IntPtr TargetDataHandle, IntPtr ActorFilterClass);

		// Token: 0x06011C7B RID: 72827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __EvaluateAttributeValueWithTagsAndBase_Internal(IntPtr AbilitySystem, IntPtr Attribute, IntPtr SourceTags, IntPtr TargetTags, float BaseValue, ref bool bSuccess);

		// Token: 0x06011C7C RID: 72828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __EvaluateAttributeValueWithTags_Internal(IntPtr AbilitySystem, IntPtr Attribute, IntPtr SourceTags, IntPtr TargetTags, ref bool bSuccess);

		// Token: 0x06011C7D RID: 72829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_GameplayAttributeGameplayAttribute_Internal(IntPtr AttributeA, IntPtr AttributeB);

		// Token: 0x06011C7E RID: 72830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EffectContextSetOrigin_Internal(IntPtr EffectContext, FVector Origin);

		// Token: 0x06011C7F RID: 72831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EffectContextIsValid_Internal(IntPtr EffectContext);

		// Token: 0x06011C80 RID: 72832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EffectContextIsInstigatorLocallyControlled_Internal(IntPtr EffectContext);

		// Token: 0x06011C81 RID: 72833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EffectContextHasHitResult_Internal(IntPtr EffectContext);

		// Token: 0x06011C82 RID: 72834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EffectContextGetSourceObject_Internal(IntPtr EffectContext);

		// Token: 0x06011C83 RID: 72835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EffectContextGetOriginalInstigatorActor_Internal(IntPtr EffectContext);

		// Token: 0x06011C84 RID: 72836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __EffectContextGetOrigin_Internal(IntPtr EffectContext);

		// Token: 0x06011C85 RID: 72837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EffectContextGetInstigatorActor_Internal(IntPtr EffectContext);

		// Token: 0x06011C86 RID: 72838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EffectContextGetHitResult_Internal(IntPtr EffectContext);

		// Token: 0x06011C87 RID: 72839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EffectContextGetEffectCauser_Internal(IntPtr EffectContext);

		// Token: 0x06011C88 RID: 72840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EffectContextAddHitResult_Internal(IntPtr EffectContext, IntPtr HitResult, bool bReset);

		// Token: 0x06011C89 RID: 72841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesTargetDataContainActor_Internal(IntPtr TargetData, int Index, IntPtr Actor);

		// Token: 0x06011C8A RID: 72842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesGameplayCueMeetTagRequirements_Internal(IntPtr Parameters, IntPtr SourceTagReqs, IntPtr TargetTagReqs);

		// Token: 0x06011C8B RID: 72843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CloneSpecHandle_Internal(IntPtr InNewInstigator, IntPtr InEffectCauser, IntPtr GameplayEffectSpecHandle_Clone);

		// Token: 0x06011C8C RID: 72844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakGameplayCueParameters_Internal(IntPtr Parameters, ref float NormalizedMagnitude, ref float RawMagnitude, IntPtr EffectContext, ref FGameplayTag MatchedTagName, ref FGameplayTag OriginalTag, IntPtr AggregatedSourceTags, IntPtr AggregatedTargetTags, ref FVector Location, ref FVector Normal, ref IntPtr Instigator, ref IntPtr EffectCauser, ref IntPtr SourceObject, ref IntPtr PhysicalMaterial, ref int GameplayEffectLevel, ref int AbilityLevel, ref IntPtr TargetAttachComponent);

		// Token: 0x06011C8D RID: 72845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AssignTagSetByCallerMagnitude_Internal(IntPtr SpecHandle, FGameplayTag DataTag, float Magnitude);

		// Token: 0x06011C8E RID: 72846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AssignSetByCallerMagnitude_Internal(IntPtr SpecHandle, int Key, float Magnitude);

		// Token: 0x06011C8F RID: 72847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AppendTargetDataHandle_Internal(IntPtr TargetHandle, IntPtr HandleToAdd);

		// Token: 0x06011C90 RID: 72848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddLinkedGameplayEffectSpec_Internal(IntPtr SpecHandle, IntPtr LinkedGameplayEffectSpec);

		// Token: 0x06011C91 RID: 72849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddLinkedGameplayEffect_Internal(IntPtr SpecHandle, IntPtr LinkedGameplayEffect);

		// Token: 0x06011C92 RID: 72850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddGrantedTags_Internal(IntPtr SpecHandle, IntPtr NewGameplayTags);

		// Token: 0x06011C93 RID: 72851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddGrantedTag_Internal(IntPtr SpecHandle, FGameplayTag NewGameplayTag);

		// Token: 0x06011C94 RID: 72852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddAssetTags_Internal(IntPtr SpecHandle, IntPtr NewGameplayTags);

		// Token: 0x06011C95 RID: 72853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddAssetTag_Internal(IntPtr SpecHandle, FGameplayTag NewGameplayTag);

		// Token: 0x06011C96 RID: 72854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AbilityTargetDataFromLocations_Internal(IntPtr SourceLocation, IntPtr TargetLocation);

		// Token: 0x06011C97 RID: 72855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AbilityTargetDataFromHitResult_Internal(IntPtr HitResult);

		// Token: 0x06011C98 RID: 72856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AbilityTargetDataFromActorArray_Internal(IntPtr ActorArray, bool OneTargetPerHandle);

		// Token: 0x06011C99 RID: 72857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AbilityTargetDataFromActor_Internal(IntPtr Actor);

		// Token: 0x06011C9A RID: 72858 RVA: 0x001A19AB File Offset: 0x0019FBAB
		static UAbilitySystemBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemBlueprintLibrary");
		}

		// Token: 0x06011C9B RID: 72859 RVA: 0x001A19B9 File Offset: 0x0019FBB9
		protected UAbilitySystemBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009864 RID: 39012
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemBlueprintLibrary";

		// Token: 0x04009865 RID: 39013
		private static IntPtr _ClassPtr;

		// Token: 0x04009866 RID: 39014
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
