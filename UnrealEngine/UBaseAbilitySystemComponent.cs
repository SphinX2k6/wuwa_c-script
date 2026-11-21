using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042F RID: 1071
	[UnrealObjectPath("/Script/KuroGAS.BaseAbilitySystemComponent")]
	[UnrealStructLayout(5024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5024)]
	public class UBaseAbilitySystemComponent : UAbilitySystemComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060066C6 RID: 26310 RVA: 0x00094546 File Offset: 0x00092746
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseAbilitySystemComponent._ClassPtr;
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00094554 File Offset: 0x00092754
		public UBaseAbilitySystemComponent() : this(BuiltinUtils.AllocNativeUObject(UBaseAbilitySystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x0009457C File Offset: 0x0009277C
		[NullableContext(1)]
		public UBaseAbilitySystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseAbilitySystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x000945B0 File Offset: 0x000927B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool UpdateActiveGameplayEffectDurationHandle(FActiveGameplayEffectHandle Handle, float DurationModifyValue)
		{
			UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->DurationModifyValue = DurationModifyValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x00094620 File Offset: 0x00092820
		[SkipLocalsInit]
		public unsafe void ResetDilationForActiveEffects(float TimeDilation)
		{
			UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeDilation = TimeDilation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__ResetDilationForActiveEffects_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x00094668 File Offset: 0x00092868
		[SkipLocalsInit]
		public unsafe void RemoveActiveEffectsByUniqueServerId(int GameplayEffectSpecServerId)
		{
			UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectSpecServerId = GameplayEffectSpecServerId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x000946B0 File Offset: 0x000928B0
		[SkipLocalsInit]
		public unsafe int RemoveActiveEffectsById(long GeId, int StackCount = -1)
		{
			UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveActiveEffectsById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GeId = GeId;
			ptr->StackCount = StackCount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveActiveEffectsById_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00094704 File Offset: 0x00092904
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void RemoveAbility(in FGameplayAbilitySpecHandle Handle)
		{
			UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__RemoveAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__RemoveAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__RemoveAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00094768 File Offset: 0x00092968
		[SkipLocalsInit]
		public unsafe void PauseAllActiveGameplayEffects(bool bPause)
		{
			UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bPause = bPause;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__PauseAllActiveGameplayEffects_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x000947B0 File Offset: 0x000929B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void PauseActiveGameplayEffect(FActiveGameplayEffectHandle Handle, bool bPause)
		{
			UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->bPause = bPause;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__PauseActiveGameplayEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00094818 File Offset: 0x00092A18
		[SkipLocalsInit]
		public unsafe virtual bool OnAnyTagChangeInternal(in FGameplayTag GameplayTag, int NewTagCount)
		{
			UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			ptr->NewTagCount = NewTagCount;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UBaseAbilitySystemComponent.__OnAnyTagChangeInternal_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00094870 File Offset: 0x00092A70
		[SkipLocalsInit]
		public unsafe void InternalApplyModToAttribute(int AttributeId, EGameplayModOp ModifierOp, float ModifierMagnitude)
		{
			UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__InternalApplyModToAttribute_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__InternalApplyModToAttribute_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeId = AttributeId;
			ptr->ModifierOp = ModifierOp;
			ptr->ModifierMagnitude = ModifierMagnitude;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__InternalApplyModToAttribute_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x000948CC File Offset: 0x00092ACC
		[SkipLocalsInit]
		public unsafe bool HasGameplayTag(FGameplayTag GameplayTag)
		{
			UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasGameplayTag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00094918 File Offset: 0x00092B18
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool HasAnyGameplayTag(in FGameplayTagContainer GameplayTagContainer)
		{
			UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasAnyGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			if (GameplayTagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTagContainer, GameplayTagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__HasAnyGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00094994 File Offset: 0x00092B94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool HasAllGameplayTag(in FGameplayTagContainer GameplayTagContainer)
		{
			UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__HasAllGameplayTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			if (GameplayTagContainer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTagContainer, GameplayTagContainer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__HasAllGameplayTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00094A10 File Offset: 0x00092C10
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe int GetGameplayEffectCountById(long GameplayEffectId, UAbilitySystemComponent OptionalInstigatorFilterComponent, bool bEnforceOnGoingCheck = true)
		{
			UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetGameplayEffectCountById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetGameplayEffectCountById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectId = GameplayEffectId;
			ptr->OptionalInstigatorFilterComponent = ((OptionalInstigatorFilterComponent != null) ? OptionalInstigatorFilterComponent.NativePtr : IntPtr.Zero);
			ptr->bEnforceOnGoingCheck = bEnforceOnGoingCheck;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetGameplayEffectCountById_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00094A7C File Offset: 0x00092C7C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FActiveGameplayEffectHandle> GetActiveEffectsById(long GeId)
		{
			UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetActiveEffectsById_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GeId = GeId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr);
			TArray<FActiveGameplayEffectHandle> result = new TArray<FActiveGameplayEffectHandle>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__GetActiveEffectsById_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00094AE4 File Offset: 0x00092CE4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FActiveGameplayEffectHandle> GetActiveEffectsByGrantedTags(in FGameplayTag Tag)
		{
			UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr);
			TArray<FActiveGameplayEffectHandle> result = new TArray<FActiveGameplayEffectHandle>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UBaseAbilitySystemComponent.__GetActiveEffectsByGrantedTags_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00094B50 File Offset: 0x00092D50
		[SkipLocalsInit]
		public unsafe int GetAbilityScopeLockCount()
		{
			UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetAbilityScopeLockCount_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00094B98 File Offset: 0x00092D98
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FGameplayAbilitySpecHandle GetAbility([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<UGameplayAbility> Ability)
		{
			UBaseAbilitySystemComponent.__GetAbility_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__GetAbility_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__GetAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__GetAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ability = Ability;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__GetAbility_NativeFunctionPtr, (void*)ptr);
			return new FGameplayAbilitySpecHandle(&ptr->__Result, true, true);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x00094BF4 File Offset: 0x00092DF4
		[SkipLocalsInit]
		public unsafe void BP_InitAbilityActorInfo(FName AnimInstanceTag)
		{
			UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams* ptr = stackalloc UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstanceTag = AnimInstanceTag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UBaseAbilitySystemComponent.__BP_InitAbilityActorInfo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00094C3A File Offset: 0x00092E3A
		static UBaseAbilitySystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseAbilitySystemComponent");
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00094C48 File Offset: 0x00092E48
		protected UBaseAbilitySystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B50 RID: 11088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseAbilitySystemComponent";

		// Token: 0x04002B51 RID: 11089
		private static IntPtr _ClassPtr;

		// Token: 0x04002B52 RID: 11090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B53 RID: 11091
		private static IntPtr __UpdateActiveGameplayEffectDurationHandle_NativeFunctionPtr;

		// Token: 0x04002B54 RID: 11092
		private static IntPtr __ResetDilationForActiveEffects_NativeFunctionPtr;

		// Token: 0x04002B55 RID: 11093
		private static IntPtr __RemoveActiveEffectsByUniqueServerId_NativeFunctionPtr;

		// Token: 0x04002B56 RID: 11094
		private static IntPtr __RemoveActiveEffectsById_NativeFunctionPtr;

		// Token: 0x04002B57 RID: 11095
		private static IntPtr __RemoveAbility_NativeFunctionPtr;

		// Token: 0x04002B58 RID: 11096
		private static IntPtr __PauseAllActiveGameplayEffects_NativeFunctionPtr;

		// Token: 0x04002B59 RID: 11097
		private static IntPtr __PauseActiveGameplayEffect_NativeFunctionPtr;

		// Token: 0x04002B5A RID: 11098
		private static IntPtr __OnAnyTagChangeInternal_NativeFunctionPtr;

		// Token: 0x04002B5B RID: 11099
		private static IntPtr __InternalApplyModToAttribute_NativeFunctionPtr;

		// Token: 0x04002B5C RID: 11100
		private static IntPtr __HasGameplayTag_NativeFunctionPtr;

		// Token: 0x04002B5D RID: 11101
		private static IntPtr __HasAnyGameplayTag_NativeFunctionPtr;

		// Token: 0x04002B5E RID: 11102
		private static IntPtr __HasAllGameplayTag_NativeFunctionPtr;

		// Token: 0x04002B5F RID: 11103
		private static IntPtr __GetGameplayEffectCountById_NativeFunctionPtr;

		// Token: 0x04002B60 RID: 11104
		private static IntPtr __GetActiveEffectsById_NativeFunctionPtr;

		// Token: 0x04002B61 RID: 11105
		private static IntPtr __GetActiveEffectsByGrantedTags_NativeFunctionPtr;

		// Token: 0x04002B62 RID: 11106
		private static IntPtr __GetAbilityScopeLockCount_NativeFunctionPtr;

		// Token: 0x04002B63 RID: 11107
		private static IntPtr __GetAbility_NativeFunctionPtr;

		// Token: 0x04002B64 RID: 11108
		private static IntPtr __BP_InitAbilityActorInfo_NativeFunctionPtr;

		// Token: 0x02000B3B RID: 2875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateActiveGameplayEffectDurationHandle_FunctionParams
		{
			// Token: 0x04005C37 RID: 23607
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04005C38 RID: 23608
			[FieldOffset(8)]
			public float DurationModifyValue;

			// Token: 0x04005C39 RID: 23609
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000B3C RID: 2876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ResetDilationForActiveEffects_FunctionParams
		{
			// Token: 0x04005C3A RID: 23610
			[FieldOffset(0)]
			public float TimeDilation;
		}

		// Token: 0x02000B3D RID: 2877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveActiveEffectsByUniqueServerId_FunctionParams
		{
			// Token: 0x04005C3B RID: 23611
			[FieldOffset(0)]
			public int GameplayEffectSpecServerId;
		}

		// Token: 0x02000B3E RID: 2878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveActiveEffectsById_FunctionParams
		{
			// Token: 0x04005C3C RID: 23612
			[FieldOffset(0)]
			public long GeId;

			// Token: 0x04005C3D RID: 23613
			[FieldOffset(8)]
			public int StackCount;

			// Token: 0x04005C3E RID: 23614
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x02000B3F RID: 2879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveAbility_FunctionParams
		{
			// Token: 0x04005C3F RID: 23615
			[FieldOffset(0)]
			public byte Handle;
		}

		// Token: 0x02000B40 RID: 2880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PauseAllActiveGameplayEffects_FunctionParams
		{
			// Token: 0x04005C40 RID: 23616
			[FieldOffset(0)]
			public bool bPause;
		}

		// Token: 0x02000B41 RID: 2881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __PauseActiveGameplayEffect_FunctionParams
		{
			// Token: 0x04005C41 RID: 23617
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04005C42 RID: 23618
			[FieldOffset(8)]
			public bool bPause;
		}

		// Token: 0x02000B42 RID: 2882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __OnAnyTagChangeInternal_FunctionParams
		{
			// Token: 0x04005C43 RID: 23619
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;

			// Token: 0x04005C44 RID: 23620
			[FieldOffset(12)]
			public int NewTagCount;

			// Token: 0x04005C45 RID: 23621
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000B43 RID: 2883
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InternalApplyModToAttribute_FunctionParams
		{
			// Token: 0x04005C46 RID: 23622
			[FieldOffset(0)]
			public int AttributeId;

			// Token: 0x04005C47 RID: 23623
			[FieldOffset(4)]
			public TEnumAsByte<EGameplayModOp> ModifierOp;

			// Token: 0x04005C48 RID: 23624
			[FieldOffset(8)]
			public float ModifierMagnitude;
		}

		// Token: 0x02000B44 RID: 2884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __HasGameplayTag_FunctionParams
		{
			// Token: 0x04005C49 RID: 23625
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;

			// Token: 0x04005C4A RID: 23626
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000B45 RID: 2885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAnyGameplayTag_FunctionParams
		{
			// Token: 0x04005C4B RID: 23627
			[FieldOffset(0)]
			public byte GameplayTagContainer;

			// Token: 0x04005C4C RID: 23628
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02000B46 RID: 2886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __HasAllGameplayTag_FunctionParams
		{
			// Token: 0x04005C4D RID: 23629
			[FieldOffset(0)]
			public byte GameplayTagContainer;

			// Token: 0x04005C4E RID: 23630
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02000B47 RID: 2887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetGameplayEffectCountById_FunctionParams
		{
			// Token: 0x04005C4F RID: 23631
			[FieldOffset(0)]
			public long GameplayEffectId;

			// Token: 0x04005C50 RID: 23632
			[FieldOffset(8)]
			public IntPtr OptionalInstigatorFilterComponent;

			// Token: 0x04005C51 RID: 23633
			[FieldOffset(16)]
			public bool bEnforceOnGoingCheck;

			// Token: 0x04005C52 RID: 23634
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000B48 RID: 2888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetActiveEffectsById_FunctionParams
		{
			// Token: 0x04005C53 RID: 23635
			[FieldOffset(0)]
			public long GeId;

			// Token: 0x04005C54 RID: 23636
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000B49 RID: 2889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetActiveEffectsByGrantedTags_FunctionParams
		{
			// Token: 0x04005C55 RID: 23637
			[FieldOffset(0)]
			public FGameplayTag Tag;

			// Token: 0x04005C56 RID: 23638
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02000B4A RID: 2890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAbilityScopeLockCount_FunctionParams
		{
			// Token: 0x04005C57 RID: 23639
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000B4B RID: 2891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAbility_FunctionParams
		{
			// Token: 0x04005C58 RID: 23640
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<UGameplayAbility> Ability;

			// Token: 0x04005C59 RID: 23641
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000B4C RID: 2892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BP_InitAbilityActorInfo_FunctionParams
		{
			// Token: 0x04005C5A RID: 23642
			[FieldOffset(0)]
			public FName AnimInstanceTag;
		}
	}
}
