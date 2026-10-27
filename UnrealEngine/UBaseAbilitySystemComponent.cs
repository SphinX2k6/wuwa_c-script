using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195A RID: 6490
	[UnrealObjectPath("/Script/KuroGAS.BaseAbilitySystemComponent")]
	[UnrealStructLayout(5024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5024)]
	public class UBaseAbilitySystemComponent : UAbilitySystemComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060180B7 RID: 98487 RVA: 0x00235108 File Offset: 0x00233308
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseAbilitySystemComponent._ClassPtr;
		}

		// Token: 0x060180B8 RID: 98488 RVA: 0x00235114 File Offset: 0x00233314
		public UBaseAbilitySystemComponent() : this(BuiltinUtils.AllocNativeUObject(UBaseAbilitySystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060180B9 RID: 98489 RVA: 0x0023513C File Offset: 0x0023333C
		[NullableContext(1)]
		public UBaseAbilitySystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseAbilitySystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060180BA RID: 98490 RVA: 0x00235170 File Offset: 0x00233370
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UpdateActiveGameplayEffectDurationHandle(FActiveGameplayEffectHandle Handle, float DurationModifyValue)
		{
			UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->DurationModifyValue = DurationModifyValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060180BB RID: 98491 RVA: 0x002351E0 File Offset: 0x002333E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetDurationMagnitudeByTag(UGameplayEffect Ge, in FGameplayTag ModifierTag)
		{
			UBaseAbilitySystemComponent.__SetDurationMagnitudeByTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__SetDurationMagnitudeByTag_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__SetDurationMagnitudeByTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__SetDurationMagnitudeByTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->ModifierTag = ModifierTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__SetDurationMagnitudeByTag_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180BC RID: 98492 RVA: 0x00235244 File Offset: 0x00233444
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetDurationMagnitudeByAttributeId(UGameplayEffect Ge, EAttributeBasedFloatCalculationType CalculationType, int AttributeId, in FGameplayTag DataTag, in FGameplayTag DataTag2, EGameplayEffectAttributeCaptureSource InSource, bool InSnapShot)
		{
			UBaseAbilitySystemComponent.__SetDurationMagnitudeByAttributeId_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__SetDurationMagnitudeByAttributeId_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__SetDurationMagnitudeByAttributeId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__SetDurationMagnitudeByAttributeId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->CalculationType = CalculationType;
			ptr->AttributeId = AttributeId;
			ptr->DataTag = DataTag;
			ptr->DataTag2 = DataTag2;
			ptr->InSource = InSource;
			ptr->InSnapShot = InSnapShot;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__SetDurationMagnitudeByAttributeId_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180BD RID: 98493 RVA: 0x002352D4 File Offset: 0x002334D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ResetDilationForActiveEffects(float TimeDilation)
		{
			UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeDilation = TimeDilation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180BE RID: 98494 RVA: 0x0023531C File Offset: 0x0023351C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RemoveActiveEffectsByUniqueServerId(int GameplayEffectSpecServerId)
		{
			UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectSpecServerId = GameplayEffectSpecServerId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180BF RID: 98495 RVA: 0x00235364 File Offset: 0x00233564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int RemoveActiveEffectsById(long GeId, int StackCount = -1)
		{
			UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GeId = GeId;
			ptr->StackCount = StackCount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveActiveEffectsById_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060180C0 RID: 98496 RVA: 0x002353B8 File Offset: 0x002335B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RemoveAbility(in FGameplayAbilitySpecHandle Handle)
		{
			UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180C1 RID: 98497 RVA: 0x0023541C File Offset: 0x0023361C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void PauseAllActiveGameplayEffects(bool bPause)
		{
			UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bPause = bPause;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180C2 RID: 98498 RVA: 0x00235464 File Offset: 0x00233664
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void PauseActiveGameplayEffect(FActiveGameplayEffectHandle Handle, bool bPause)
		{
			UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->bPause = bPause;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180C3 RID: 98499 RVA: 0x002354D0 File Offset: 0x002336D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool OnAnyTagChangeInternal(in FGameplayTag GameplayTag, int NewTagCount)
		{
			UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			ptr->NewTagCount = NewTagCount;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060180C4 RID: 98500 RVA: 0x00235528 File Offset: 0x00233728
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(1)]
		public unsafe FGameplayEffectSpecHandle MakeRemoteDynamicOutgoingSpec(UGameplayEffect GameplayEffect, float Level, FGameplayEffectContextHandle Context, int GameplayEffectServerId, int InGeHandleId)
		{
			UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffect = ((GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero);
			ptr->Level = Level;
			if (Context != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), &ptr->Context, Context.NativePtr, 1, false);
			}
			ptr->GameplayEffectServerId = GameplayEffectServerId;
			ptr->InGeHandleId = InGeHandleId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 0);
			FGameplayEffectSpecHandle result = new FGameplayEffectSpecHandle(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__MakeRemoteDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060180C5 RID: 98501 RVA: 0x002355D8 File Offset: 0x002337D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(1)]
		public unsafe FGameplayEffectSpecHandle MakeDynamicOutgoingSpec(UGameplayEffect GameplayEffect, float Level, FGameplayEffectContextHandle Context, int GameplayEffectServerId)
		{
			UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffect = ((GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero);
			ptr->Level = Level;
			if (Context != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), &ptr->Context, Context.NativePtr, 1, false);
			}
			ptr->GameplayEffectServerId = GameplayEffectServerId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 0);
			FGameplayEffectSpecHandle result = new FGameplayEffectSpecHandle(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__MakeDynamicOutgoingSpec_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060180C6 RID: 98502 RVA: 0x00235680 File Offset: 0x00233880
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UGameplayEffect MakeDynamicGameplayEffect(FName GeName, long GeId)
		{
			UBaseAbilitySystemComponent.__MakeDynamicGameplayEffect_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__MakeDynamicGameplayEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__MakeDynamicGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__MakeDynamicGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GeName = GeName;
			ptr->GeId = GeId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__MakeDynamicGameplayEffect_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayEffect>(ptr->__Result);
		}

		// Token: 0x060180C7 RID: 98503 RVA: 0x002356DC File Offset: 0x002338DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InternalApplyModToAttribute(int AttributeId, EGameplayModOp ModifierOp, float ModifierMagnitude)
		{
			UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__InternalApplyModToAttribute_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeId = AttributeId;
			ptr->ModifierOp = ModifierOp;
			ptr->ModifierMagnitude = ModifierMagnitude;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__InternalApplyModToAttribute_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180C8 RID: 98504 RVA: 0x00235738 File Offset: 0x00233938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool HasGameplayTag(FGameplayTag GameplayTag)
		{
			UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasGameplayTag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060180C9 RID: 98505 RVA: 0x00235788 File Offset: 0x00233988
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool HasAnyGameplayTag(in FGameplayTagContainer GameplayTagContainer)
		{
			UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			if (GameplayTagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTagContainer, GameplayTagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060180CA RID: 98506 RVA: 0x00235804 File Offset: 0x00233A04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool HasAllGameplayTag(in FGameplayTagContainer GameplayTagContainer)
		{
			UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			if (GameplayTagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTagContainer, GameplayTagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060180CB RID: 98507 RVA: 0x00235880 File Offset: 0x00233A80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetGameplayEffectCountById(long GameplayEffectId, UAbilitySystemComponent OptionalInstigatorFilterComponent, bool bEnforceOnGoingCheck = true)
		{
			UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetGameplayEffectCountById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectId = GameplayEffectId;
			ptr->OptionalInstigatorFilterComponent = ((OptionalInstigatorFilterComponent != null) ? OptionalInstigatorFilterComponent.NativePtr : IntPtr.Zero);
			ptr->bEnforceOnGoingCheck = bEnforceOnGoingCheck;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetGameplayEffectCountById_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060180CC RID: 98508 RVA: 0x002358EC File Offset: 0x00233AEC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FActiveGameplayEffectHandle> GetActiveEffectsById(long GeId)
		{
			UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GeId = GeId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FActiveGameplayEffectHandle> result = new TArray<FActiveGameplayEffectHandle>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060180CD RID: 98509 RVA: 0x00235954 File Offset: 0x00233B54
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FActiveGameplayEffectHandle> GetActiveEffectsByGrantedTags(in FGameplayTag Tag)
		{
			UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FActiveGameplayEffectHandle> result = new TArray<FActiveGameplayEffectHandle>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060180CE RID: 98510 RVA: 0x002359C0 File Offset: 0x00233BC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetAbilityScopeLockCount()
		{
			UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060180CF RID: 98511 RVA: 0x00235A08 File Offset: 0x00233C08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FGameplayAbilitySpecHandle GetAbility([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<UGameplayAbility> Ability)
		{
			UBaseAbilitySystemComponent.__GetAbility_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetAbility_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ability = Ability;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetAbility_NativeFunctionPtr, (void*)ptr, 0);
			return new FGameplayAbilitySpecHandle(&ptr->__Result, true, true);
		}

		// Token: 0x060180D0 RID: 98512 RVA: 0x00235A64 File Offset: 0x00233C64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DestroyDynamicGameplayEffect(UGameplayEffect Ge)
		{
			UBaseAbilitySystemComponent.__DestroyDynamicGameplayEffect_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__DestroyDynamicGameplayEffect_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__DestroyDynamicGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__DestroyDynamicGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__DestroyDynamicGameplayEffect_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D1 RID: 98513 RVA: 0x00235ABC File Offset: 0x00233CBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void BP_InitAbilityActorInfo(FName AnimInstanceTag)
		{
			UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstanceTag = AnimInstanceTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D2 RID: 98514 RVA: 0x00235B04 File Offset: 0x00233D04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FActiveGameplayEffectHandle ApplyGeToSelfById(long GameplayEffectId, [Nullable(2)] in FGameplayEffectContextHandle Context, float Level, int ServerId)
		{
			UBaseAbilitySystemComponent.__ApplyGeToSelfById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__ApplyGeToSelfById_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__ApplyGeToSelfById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__ApplyGeToSelfById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectId = GameplayEffectId;
			if (Context != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), &ptr->Context, Context.NativePtr, 1, false);
			}
			ptr->Level = Level;
			ptr->ServerId = ServerId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UBaseAbilitySystemComponent.__ApplyGeToSelfById_NativeFunctionPtr, (void*)ptr);
			FActiveGameplayEffectHandle result = new FActiveGameplayEffectHandle(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__ApplyGeToSelfById_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060180D3 RID: 98515 RVA: 0x00235B9C File Offset: 0x00233D9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddGeModifierByTag(UGameplayEffect Ge, int ModifiedAttributeId, EGameplayModOp ModOp, in FGameplayTag ModifierTag)
		{
			UBaseAbilitySystemComponent.__AddGeModifierByTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__AddGeModifierByTag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__AddGeModifierByTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__AddGeModifierByTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->ModifiedAttributeId = ModifiedAttributeId;
			ptr->ModOp = ModOp;
			ptr->ModifierTag = ModifierTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__AddGeModifierByTag_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D4 RID: 98516 RVA: 0x00235C14 File Offset: 0x00233E14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddGeModifierByMMC(UGameplayEffect Ge, int ModifiedAttributeId, EGameplayModOp ModOp, [Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<UGameplayModMagnitudeCalculation> CalculationClassMagnitude)
		{
			UBaseAbilitySystemComponent.__AddGeModifierByMMC_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__AddGeModifierByMMC_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__AddGeModifierByMMC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__AddGeModifierByMMC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->ModifiedAttributeId = ModifiedAttributeId;
			ptr->ModOp = ModOp;
			ptr->CalculationClassMagnitude = CalculationClassMagnitude;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__AddGeModifierByMMC_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D5 RID: 98517 RVA: 0x00235C8C File Offset: 0x00233E8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddGeModifierByKey(UGameplayEffect Ge, int ModifiedAttributeId, EGameplayModOp ModOp, int ModifierKey)
		{
			UBaseAbilitySystemComponent.__AddGeModifierByKey_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__AddGeModifierByKey_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__AddGeModifierByKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__AddGeModifierByKey_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->ModifiedAttributeId = ModifiedAttributeId;
			ptr->ModOp = ModOp;
			ptr->ModifierKey = ModifierKey;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__AddGeModifierByKey_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D6 RID: 98518 RVA: 0x00235D00 File Offset: 0x00233F00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddGeModifierByAttributeId(UGameplayEffect Ge, int ModifiedAttributeId, EAttributeBasedFloatCalculationType CalculationType, EGameplayModOp ModOp, int AttributeId, in FGameplayTag DataTag, in FGameplayTag DataTag2, EGameplayEffectAttributeCaptureSource InSource, bool InSnapShot)
		{
			UBaseAbilitySystemComponent.__AddGeModifierByAttributeId_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__AddGeModifierByAttributeId_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__AddGeModifierByAttributeId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__AddGeModifierByAttributeId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->ModifiedAttributeId = ModifiedAttributeId;
			ptr->CalculationType = CalculationType;
			ptr->ModOp = ModOp;
			ptr->AttributeId = AttributeId;
			ptr->DataTag = DataTag;
			ptr->DataTag2 = DataTag2;
			ptr->InSource = InSource;
			ptr->InSnapShot = InSnapShot;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__AddGeModifierByAttributeId_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D7 RID: 98519 RVA: 0x00235DA4 File Offset: 0x00233FA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddGeGrantGa(UGameplayEffect Ge, [Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<UGameplayAbility> Ability, int level, EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy)
		{
			UBaseAbilitySystemComponent.__AddGeGrantGa_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__AddGeGrantGa_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__AddGeGrantGa_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__AddGeGrantGa_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ge = ((Ge != null) ? Ge.NativePtr : IntPtr.Zero);
			ptr->Ability = Ability;
			ptr->level = level;
			ptr->RemovalPolicy = RemovalPolicy;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__AddGeGrantGa_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060180D8 RID: 98520 RVA: 0x00235E15 File Offset: 0x00234015
		static UBaseAbilitySystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseAbilitySystemComponent");
		}

		// Token: 0x060180D9 RID: 98521 RVA: 0x00235E23 File Offset: 0x00234023
		protected UBaseAbilitySystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D032 RID: 53298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseAbilitySystemComponent";

		// Token: 0x0400D033 RID: 53299
		private static IntPtr _ClassPtr;

		// Token: 0x0400D034 RID: 53300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D035 RID: 53301
		private static IntPtr __UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr;

		// Token: 0x0400D036 RID: 53302
		private static IntPtr __SetDurationMagnitudeByTag_NativeFunctionPtr;

		// Token: 0x0400D037 RID: 53303
		private static IntPtr __SetDurationMagnitudeByAttributeId_NativeFunctionPtr;

		// Token: 0x0400D038 RID: 53304
		private static IntPtr __ResetDilationForActiveEffects_NativeFunctionPtr;

		// Token: 0x0400D039 RID: 53305
		private static IntPtr __RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr;

		// Token: 0x0400D03A RID: 53306
		private static IntPtr __RemoveActiveEffectsById_NativeFunctionPtr;

		// Token: 0x0400D03B RID: 53307
		private static IntPtr __RemoveAbility_NativeFunctionPtr;

		// Token: 0x0400D03C RID: 53308
		private static IntPtr __PauseAllActiveGameplayEffects_NativeFunctionPtr;

		// Token: 0x0400D03D RID: 53309
		private static IntPtr __PauseActiveGameplayEffect_NativeFunctionPtr;

		// Token: 0x0400D03E RID: 53310
		private static IntPtr __OnAnyTagChangeInternal_NativeFunctionPtr;

		// Token: 0x0400D03F RID: 53311
		private static IntPtr __MakeRemoteDynamicOutgoingSpec_NativeFunctionPtr;

		// Token: 0x0400D040 RID: 53312
		private static IntPtr __MakeDynamicOutgoingSpec_NativeFunctionPtr;

		// Token: 0x0400D041 RID: 53313
		private static IntPtr __MakeDynamicGameplayEffect_NativeFunctionPtr;

		// Token: 0x0400D042 RID: 53314
		private static IntPtr __InternalApplyModToAttribute_NativeFunctionPtr;

		// Token: 0x0400D043 RID: 53315
		private static IntPtr __HasGameplayTag_NativeFunctionPtr;

		// Token: 0x0400D044 RID: 53316
		private static IntPtr __HasAnyGameplayTag_NativeFunctionPtr;

		// Token: 0x0400D045 RID: 53317
		private static IntPtr __HasAllGameplayTag_NativeFunctionPtr;

		// Token: 0x0400D046 RID: 53318
		private static IntPtr __GetGameplayEffectCountById_NativeFunctionPtr;

		// Token: 0x0400D047 RID: 53319
		private static IntPtr __GetActiveEffectsById_NativeFunctionPtr;

		// Token: 0x0400D048 RID: 53320
		private static IntPtr __GetActiveEffectsByGrantedTags_NativeFunctionPtr;

		// Token: 0x0400D049 RID: 53321
		private static IntPtr __GetAbilityScopeLockCount_NativeFunctionPtr;

		// Token: 0x0400D04A RID: 53322
		private static IntPtr __GetAbility_NativeFunctionPtr;

		// Token: 0x0400D04B RID: 53323
		private static IntPtr __DestroyDynamicGameplayEffect_NativeFunctionPtr;

		// Token: 0x0400D04C RID: 53324
		private static IntPtr __BP_InitAbilityActorInfo_NativeFunctionPtr;

		// Token: 0x0400D04D RID: 53325
		private static IntPtr __ApplyGeToSelfById_NativeFunctionPtr;

		// Token: 0x0400D04E RID: 53326
		private static IntPtr __AddGeModifierByTag_NativeFunctionPtr;

		// Token: 0x0400D04F RID: 53327
		private static IntPtr __AddGeModifierByMMC_NativeFunctionPtr;

		// Token: 0x0400D050 RID: 53328
		private static IntPtr __AddGeModifierByKey_NativeFunctionPtr;

		// Token: 0x0400D051 RID: 53329
		private static IntPtr __AddGeModifierByAttributeId_NativeFunctionPtr;

		// Token: 0x0400D052 RID: 53330
		private static IntPtr __AddGeGrantGa_NativeFunctionPtr;

		// Token: 0x0200302F RID: 12335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateActiveGameplayEffectDurationHandle_FunctionParams
		{
			// Token: 0x04016CA7 RID: 93351
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016CA8 RID: 93352
			[FieldOffset(8)]
			public float DurationModifyValue;

			// Token: 0x04016CA9 RID: 93353
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02003030 RID: 12336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetDurationMagnitudeByTag_FunctionParams
		{
			// Token: 0x04016CAA RID: 93354
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CAB RID: 93355
			[FieldOffset(8)]
			public FGameplayTag ModifierTag;
		}

		// Token: 0x02003031 RID: 12337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetDurationMagnitudeByAttributeId_FunctionParams
		{
			// Token: 0x04016CAC RID: 93356
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CAD RID: 93357
			[FieldOffset(8)]
			public EAttributeBasedFloatCalculationType CalculationType;

			// Token: 0x04016CAE RID: 93358
			[FieldOffset(12)]
			public int AttributeId;

			// Token: 0x04016CAF RID: 93359
			[FieldOffset(16)]
			public FGameplayTag DataTag;

			// Token: 0x04016CB0 RID: 93360
			[FieldOffset(28)]
			public FGameplayTag DataTag2;

			// Token: 0x04016CB1 RID: 93361
			[FieldOffset(40)]
			public EGameplayEffectAttributeCaptureSource InSource;

			// Token: 0x04016CB2 RID: 93362
			[FieldOffset(41)]
			public bool InSnapShot;
		}

		// Token: 0x02003032 RID: 12338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ResetDilationForActiveEffects_FunctionParams
		{
			// Token: 0x04016CB3 RID: 93363
			[FieldOffset(0)]
			public float TimeDilation;
		}

		// Token: 0x02003033 RID: 12339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveActiveEffectsByUniqueServerId_FunctionParams
		{
			// Token: 0x04016CB4 RID: 93364
			[FieldOffset(0)]
			public int GameplayEffectSpecServerId;
		}

		// Token: 0x02003034 RID: 12340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveActiveEffectsById_FunctionParams
		{
			// Token: 0x04016CB5 RID: 93365
			[FieldOffset(0)]
			public long GeId;

			// Token: 0x04016CB6 RID: 93366
			[FieldOffset(8)]
			public int StackCount;

			// Token: 0x04016CB7 RID: 93367
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x02003035 RID: 12341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveAbility_FunctionParams
		{
			// Token: 0x04016CB8 RID: 93368
			[FieldOffset(0)]
			public byte Handle;
		}

		// Token: 0x02003036 RID: 12342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PauseAllActiveGameplayEffects_FunctionParams
		{
			// Token: 0x04016CB9 RID: 93369
			[FieldOffset(0)]
			public bool bPause;
		}

		// Token: 0x02003037 RID: 12343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __PauseActiveGameplayEffect_FunctionParams
		{
			// Token: 0x04016CBA RID: 93370
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016CBB RID: 93371
			[FieldOffset(8)]
			public bool bPause;
		}

		// Token: 0x02003038 RID: 12344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __OnAnyTagChangeInternal_FunctionParams
		{
			// Token: 0x04016CBC RID: 93372
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;

			// Token: 0x04016CBD RID: 93373
			[FieldOffset(12)]
			public int NewTagCount;

			// Token: 0x04016CBE RID: 93374
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003039 RID: 12345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __MakeRemoteDynamicOutgoingSpec_FunctionParams
		{
			// Token: 0x04016CBF RID: 93375
			[FieldOffset(0)]
			public IntPtr GameplayEffect;

			// Token: 0x04016CC0 RID: 93376
			[FieldOffset(8)]
			public float Level;

			// Token: 0x04016CC1 RID: 93377
			[FieldOffset(16)]
			public byte Context;

			// Token: 0x04016CC2 RID: 93378
			[FieldOffset(40)]
			public int GameplayEffectServerId;

			// Token: 0x04016CC3 RID: 93379
			[FieldOffset(44)]
			public int InGeHandleId;

			// Token: 0x04016CC4 RID: 93380
			[FieldOffset(48)]
			public byte __Result;
		}

		// Token: 0x0200303A RID: 12346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __MakeDynamicOutgoingSpec_FunctionParams
		{
			// Token: 0x04016CC5 RID: 93381
			[FieldOffset(0)]
			public IntPtr GameplayEffect;

			// Token: 0x04016CC6 RID: 93382
			[FieldOffset(8)]
			public float Level;

			// Token: 0x04016CC7 RID: 93383
			[FieldOffset(16)]
			public byte Context;

			// Token: 0x04016CC8 RID: 93384
			[FieldOffset(40)]
			public int GameplayEffectServerId;

			// Token: 0x04016CC9 RID: 93385
			[FieldOffset(48)]
			public byte __Result;
		}

		// Token: 0x0200303B RID: 12347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __MakeDynamicGameplayEffect_FunctionParams
		{
			// Token: 0x04016CCA RID: 93386
			[FieldOffset(0)]
			public FName GeName;

			// Token: 0x04016CCB RID: 93387
			[FieldOffset(16)]
			public long GeId;

			// Token: 0x04016CCC RID: 93388
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x0200303C RID: 12348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InternalApplyModToAttribute_FunctionParams
		{
			// Token: 0x04016CCD RID: 93389
			[FieldOffset(0)]
			public int AttributeId;

			// Token: 0x04016CCE RID: 93390
			[FieldOffset(4)]
			public TEnumAsByte<EGameplayModOp> ModifierOp;

			// Token: 0x04016CCF RID: 93391
			[FieldOffset(8)]
			public float ModifierMagnitude;
		}

		// Token: 0x0200303D RID: 12349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __HasGameplayTag_FunctionParams
		{
			// Token: 0x04016CD0 RID: 93392
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;

			// Token: 0x04016CD1 RID: 93393
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x0200303E RID: 12350
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAnyGameplayTag_FunctionParams
		{
			// Token: 0x04016CD2 RID: 93394
			[FieldOffset(0)]
			public byte GameplayTagContainer;

			// Token: 0x04016CD3 RID: 93395
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x0200303F RID: 12351
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAllGameplayTag_FunctionParams
		{
			// Token: 0x04016CD4 RID: 93396
			[FieldOffset(0)]
			public byte GameplayTagContainer;

			// Token: 0x04016CD5 RID: 93397
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02003040 RID: 12352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetGameplayEffectCountById_FunctionParams
		{
			// Token: 0x04016CD6 RID: 93398
			[FieldOffset(0)]
			public long GameplayEffectId;

			// Token: 0x04016CD7 RID: 93399
			[FieldOffset(8)]
			public IntPtr OptionalInstigatorFilterComponent;

			// Token: 0x04016CD8 RID: 93400
			[FieldOffset(16)]
			public bool bEnforceOnGoingCheck;

			// Token: 0x04016CD9 RID: 93401
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02003041 RID: 12353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetActiveEffectsById_FunctionParams
		{
			// Token: 0x04016CDA RID: 93402
			[FieldOffset(0)]
			public long GeId;

			// Token: 0x04016CDB RID: 93403
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02003042 RID: 12354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetActiveEffectsByGrantedTags_FunctionParams
		{
			// Token: 0x04016CDC RID: 93404
			[FieldOffset(0)]
			public FGameplayTag Tag;

			// Token: 0x04016CDD RID: 93405
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02003043 RID: 12355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAbilityScopeLockCount_FunctionParams
		{
			// Token: 0x04016CDE RID: 93406
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003044 RID: 12356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAbility_FunctionParams
		{
			// Token: 0x04016CDF RID: 93407
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<UGameplayAbility> Ability;

			// Token: 0x04016CE0 RID: 93408
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02003045 RID: 12357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyDynamicGameplayEffect_FunctionParams
		{
			// Token: 0x04016CE1 RID: 93409
			[FieldOffset(0)]
			public IntPtr Ge;
		}

		// Token: 0x02003046 RID: 12358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BP_InitAbilityActorInfo_FunctionParams
		{
			// Token: 0x04016CE2 RID: 93410
			[FieldOffset(0)]
			public FName AnimInstanceTag;
		}

		// Token: 0x02003047 RID: 12359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ApplyGeToSelfById_FunctionParams
		{
			// Token: 0x04016CE3 RID: 93411
			[FieldOffset(0)]
			public long GameplayEffectId;

			// Token: 0x04016CE4 RID: 93412
			[FieldOffset(8)]
			public byte Context;

			// Token: 0x04016CE5 RID: 93413
			[FieldOffset(32)]
			public float Level;

			// Token: 0x04016CE6 RID: 93414
			[FieldOffset(36)]
			public int ServerId;

			// Token: 0x04016CE7 RID: 93415
			[FieldOffset(40)]
			public byte __Result;
		}

		// Token: 0x02003048 RID: 12360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __AddGeModifierByTag_FunctionParams
		{
			// Token: 0x04016CE8 RID: 93416
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CE9 RID: 93417
			[FieldOffset(8)]
			public int ModifiedAttributeId;

			// Token: 0x04016CEA RID: 93418
			[FieldOffset(12)]
			public TEnumAsByte<EGameplayModOp> ModOp;

			// Token: 0x04016CEB RID: 93419
			[FieldOffset(16)]
			public FGameplayTag ModifierTag;
		}

		// Token: 0x02003049 RID: 12361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AddGeModifierByMMC_FunctionParams
		{
			// Token: 0x04016CEC RID: 93420
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CED RID: 93421
			[FieldOffset(8)]
			public int ModifiedAttributeId;

			// Token: 0x04016CEE RID: 93422
			[FieldOffset(12)]
			public TEnumAsByte<EGameplayModOp> ModOp;

			// Token: 0x04016CEF RID: 93423
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(16)]
			public TSubclassOf<UGameplayModMagnitudeCalculation> CalculationClassMagnitude;
		}

		// Token: 0x0200304A RID: 12362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AddGeModifierByKey_FunctionParams
		{
			// Token: 0x04016CF0 RID: 93424
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CF1 RID: 93425
			[FieldOffset(8)]
			public int ModifiedAttributeId;

			// Token: 0x04016CF2 RID: 93426
			[FieldOffset(12)]
			public TEnumAsByte<EGameplayModOp> ModOp;

			// Token: 0x04016CF3 RID: 93427
			[FieldOffset(16)]
			public int ModifierKey;
		}

		// Token: 0x0200304B RID: 12363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddGeModifierByAttributeId_FunctionParams
		{
			// Token: 0x04016CF4 RID: 93428
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CF5 RID: 93429
			[FieldOffset(8)]
			public int ModifiedAttributeId;

			// Token: 0x04016CF6 RID: 93430
			[FieldOffset(12)]
			public EAttributeBasedFloatCalculationType CalculationType;

			// Token: 0x04016CF7 RID: 93431
			[FieldOffset(13)]
			public TEnumAsByte<EGameplayModOp> ModOp;

			// Token: 0x04016CF8 RID: 93432
			[FieldOffset(16)]
			public int AttributeId;

			// Token: 0x04016CF9 RID: 93433
			[FieldOffset(20)]
			public FGameplayTag DataTag;

			// Token: 0x04016CFA RID: 93434
			[FieldOffset(32)]
			public FGameplayTag DataTag2;

			// Token: 0x04016CFB RID: 93435
			[FieldOffset(44)]
			public EGameplayEffectAttributeCaptureSource InSource;

			// Token: 0x04016CFC RID: 93436
			[FieldOffset(45)]
			public bool InSnapShot;
		}

		// Token: 0x0200304C RID: 12364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AddGeGrantGa_FunctionParams
		{
			// Token: 0x04016CFD RID: 93437
			[FieldOffset(0)]
			public IntPtr Ge;

			// Token: 0x04016CFE RID: 93438
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(8)]
			public TSubclassOf<UGameplayAbility> Ability;

			// Token: 0x04016CFF RID: 93439
			[FieldOffset(16)]
			public int level;

			// Token: 0x04016D00 RID: 93440
			[FieldOffset(20)]
			public EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy;
		}
	}
}
