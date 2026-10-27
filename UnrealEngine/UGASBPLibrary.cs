using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001964 RID: 6500
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.GASBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGASBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018260 RID: 98912 RVA: 0x0023993E File Offset: 0x00237B3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGASBPLibrary._ClassPtr;
		}

		// Token: 0x06018261 RID: 98913 RVA: 0x0023994C File Offset: 0x00237B4C
		public UGASBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UGASBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018262 RID: 98914 RVA: 0x00239974 File Offset: 0x00237B74
		[NullableContext(1)]
		public UGASBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGASBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018263 RID: 98915 RVA: 0x002399A7 File Offset: 0x00237BA7
		public static bool SetRootComponent(AActor TargetActor, USceneComponent NewRootComponent)
		{
			return UGASBPLibrary.__SetRootComponent_Internal((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, (NewRootComponent != null) ? NewRootComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018264 RID: 98916 RVA: 0x002399CE File Offset: 0x00237BCE
		public static void SetNeedSyncAttributes(in TSet<int> SourceNeedSyncAttributes)
		{
			UGASBPLibrary.__SetNeedSyncAttributes_Internal((SourceNeedSyncAttributes ?? new TSet<int>()).NativeSetPtr);
		}

		// Token: 0x06018265 RID: 98917 RVA: 0x002399E8 File Offset: 0x00237BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetAttributeValue(UBaseAttributeSet AttributeSet, UStruct InStruct)
		{
			UGASBPLibrary.__SetAttributeValue_FunctionParams* ptr = stackalloc UGASBPLibrary.__SetAttributeValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGASBPLibrary.__SetAttributeValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__SetAttributeValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeSet = ((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
			ptr->InStruct = ((InStruct != null) ? InStruct.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__SetAttributeValue_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018266 RID: 98918 RVA: 0x00239A53 File Offset: 0x00237C53
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle ResetGameplayEffectSpecPeriod([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, float NewPeriod)
		{
			return new FGameplayEffectSpecHandle(UGASBPLibrary.__ResetGameplayEffectSpecPeriod_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, NewPeriod), null);
		}

		// Token: 0x06018267 RID: 98919 RVA: 0x00239A70 File Offset: 0x00237C70
		public static void RemoveTagFromActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			UGASBPLibrary.__RemoveTagFromActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x06018268 RID: 98920 RVA: 0x00239A89 File Offset: 0x00237C89
		public static void RemoveBuffByTagFromActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			UGASBPLibrary.__RemoveBuffByTagFromActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x06018269 RID: 98921 RVA: 0x00239AA2 File Offset: 0x00237CA2
		public static void RemoveAllGameplayEffects(UAbilitySystemComponent ASC)
		{
			UGASBPLibrary.__RemoveAllGameplayEffects_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601826A RID: 98922 RVA: 0x00239AB9 File Offset: 0x00237CB9
		public static void RemoveAllDurationGameplayEffects(UAbilitySystemComponent ASC)
		{
			UGASBPLibrary.__RemoveAllDurationGameplayEffects_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601826B RID: 98923 RVA: 0x00239AD0 File Offset: 0x00237CD0
		public static bool RemoveActiveBuff(UAbilitySystemComponent Asc, int HandleId, int StacksToRemove)
		{
			return UGASBPLibrary.__RemoveActiveBuff_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, HandleId, StacksToRemove);
		}

		// Token: 0x0601826C RID: 98924 RVA: 0x00239AE9 File Offset: 0x00237CE9
		[NullableContext(1)]
		public static FGameplayTagContainer MakeGameplayTagContainerFromTagHash(int TagHash)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__MakeGameplayTagContainerFromTagHash_Internal(TagHash), null);
		}

		// Token: 0x0601826D RID: 98925 RVA: 0x00239AF8 File Offset: 0x00237CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void IterateStructAndAssignAttributeSet(UBaseAttributeSet AttributeSet, UStruct Data)
		{
			UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams* ptr = stackalloc UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__IterateStructAndAssignAttributeSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeSet = ((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__IterateStructAndAssignAttributeSet_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601826E RID: 98926 RVA: 0x00239B63 File Offset: 0x00237D63
		public static bool IsActiveGameplayEffectInhibited(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__IsActiveGameplayEffectInhibited_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x0601826F RID: 98927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsActiveBuffInhibited(int HandleId);

		// Token: 0x06018270 RID: 98928 RVA: 0x00239B7C File Offset: 0x00237D7C
		[NullableContext(1)]
		public unsafe static string GetUglyTag(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			string result = FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetUglyTag_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018271 RID: 98929 RVA: 0x00239BA5 File Offset: 0x00237DA5
		public static void GetOwnedGameplayTags(UAbilitySystemComponent ASC, ref FGameplayTagContainer TargetContainer)
		{
			UGASBPLibrary.__GetOwnedGameplayTags_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero, (TargetContainer ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06018272 RID: 98930
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetNetworkGameplayTagNodeIndexHash();

		// Token: 0x06018273 RID: 98931 RVA: 0x00239BCC File Offset: 0x00237DCC
		public static void GetGameplayTags(ref TMap<int, FGameplayTag> Tags)
		{
			UGASBPLibrary.__GetGameplayTags_Internal((Tags ?? new TMap<int, FGameplayTag>()).NativeMapPtr);
		}

		// Token: 0x06018274 RID: 98932
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGameplayTagId(in FGameplayTag Tag);

		// Token: 0x06018275 RID: 98933
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGameplayTag GetGameplayTagFromTagHash(int TagHash);

		// Token: 0x06018276 RID: 98934 RVA: 0x00239BE3 File Offset: 0x00237DE3
		public static AActor GetGameplayEffectContextTarget(FGameplayEffectContextHandle handle)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGASBPLibrary.__GetGameplayEffectContextTarget_Internal((handle ?? new FGameplayEffectContextHandle()).NativePtr));
		}

		// Token: 0x06018277 RID: 98935 RVA: 0x00239BFE File Offset: 0x00237DFE
		public static void GetGameplayCueNotify(in FGameplayTag GameplayTag, ref FSoftObjectPath OutSoftObjectPath)
		{
			UGASBPLibrary.__GetGameplayCueNotify_Internal(GameplayTag, (OutSoftObjectPath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x06018278 RID: 98936 RVA: 0x00239C16 File Offset: 0x00237E16
		[NullableContext(1)]
		public static string GetGameplayAbilitySystemActivatableAbilitiesDebugString([Nullable(2)] UAbilitySystemComponent ASC)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetGameplayAbilitySystemActivatableAbilitiesDebugString_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06018279 RID: 98937 RVA: 0x00239C32 File Offset: 0x00237E32
		[NullableContext(1)]
		public static FActiveGameplayEffectHandle GetGameplayAbilitySourceGE([Nullable(2)] UGameplayAbility GameplayAbility)
		{
			return new FActiveGameplayEffectHandle(UGASBPLibrary.__GetGameplayAbilitySourceGE_Internal((GameplayAbility != null) ? GameplayAbility.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601827A RID: 98938 RVA: 0x00239C4F File Offset: 0x00237E4F
		public static FName GetAssetPath(UObject Object)
		{
			return UGASBPLibrary.__GetAssetPath_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601827B RID: 98939 RVA: 0x00239C66 File Offset: 0x00237E66
		public static void GetAllTagsByParentTags(UAbilitySystemComponent ASC, in FGameplayTag Query, ref FGameplayTagContainer Result)
		{
			UGASBPLibrary.__GetAllTagsByParentTags_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero, Query, (Result ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0601827C RID: 98940 RVA: 0x00239C8E File Offset: 0x00237E8E
		public static int GetActiveGameplayEffectServerId(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectServerId_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x0601827D RID: 98941 RVA: 0x00239CA4 File Offset: 0x00237EA4
		public static float GetActiveGameplayEffectPeriod(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectPeriod_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x0601827E RID: 98942 RVA: 0x00239CBA File Offset: 0x00237EBA
		[NullableContext(1)]
		public static TArray<FGameplayAttribute> GetActiveGameplayEffectModifiedAttributes([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return new TArray<FGameplayAttribute>(UGASBPLibrary.__GetActiveGameplayEffectModifiedAttributes_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x0601827F RID: 98943 RVA: 0x00239CD6 File Offset: 0x00237ED6
		public static float GetActiveGameplayEffectHandleLevel(in FActiveGameplayEffectHandle Handle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectHandleLevel_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06018280 RID: 98944 RVA: 0x00239CED File Offset: 0x00237EED
		public static AActor GetActiveGameplayEffectHandleInstigator(in FActiveGameplayEffectHandle Handle)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGASBPLibrary.__GetActiveGameplayEffectHandleInstigator_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06018281 RID: 98945 RVA: 0x00239D09 File Offset: 0x00237F09
		public static long GetActiveGameplayEffectHandleGeId(in FActiveGameplayEffectHandle Handle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectHandleGeId_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06018282 RID: 98946 RVA: 0x00239D20 File Offset: 0x00237F20
		[NullableContext(1)]
		public static FGameplayEffectContextHandle GetActiveGameplayEffectHandleEffectContext([Nullable(2)] in FActiveGameplayEffectHandle Handle)
		{
			return new FGameplayEffectContextHandle(UGASBPLibrary.__GetActiveGameplayEffectHandleEffectContext_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x06018283 RID: 98947 RVA: 0x00239D3D File Offset: 0x00237F3D
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveGameplayEffectGrantedTags([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveGameplayEffectGrantedTags_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x06018284 RID: 98948 RVA: 0x00239D59 File Offset: 0x00237F59
		[NullableContext(1)]
		public static string GetActiveGameplayEffectDebugString([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveGameplayEffectDebugString_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06018285 RID: 98949 RVA: 0x00239D74 File Offset: 0x00237F74
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveGameplayEffectAssetTags([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveGameplayEffectAssetTags_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x06018286 RID: 98950
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffTotalDuration(int HandleId);

		// Token: 0x06018287 RID: 98951
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveBuffStackCount(int HandleId);

		// Token: 0x06018288 RID: 98952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveBuffServerId(int HandleId);

		// Token: 0x06018289 RID: 98953
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffRemainingDuration(int HandleId);

		// Token: 0x0601828A RID: 98954
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffPeriod(int HandleId);

		// Token: 0x0601828B RID: 98955
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffLevel(int HandleId);

		// Token: 0x0601828C RID: 98956 RVA: 0x00239D90 File Offset: 0x00237F90
		public static AActor GetActiveBuffInstigator(int HandleId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGASBPLibrary.__GetActiveBuffInstigator_Internal(HandleId));
		}

		// Token: 0x0601828D RID: 98957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetActiveBuffId(int HandleId);

		// Token: 0x0601828E RID: 98958 RVA: 0x00239D9D File Offset: 0x00237F9D
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveBuffGrantedTags(int HandleId)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveBuffGrantedTags_Internal(HandleId), null);
		}

		// Token: 0x0601828F RID: 98959 RVA: 0x00239DAB File Offset: 0x00237FAB
		[NullableContext(1)]
		public static string GetActiveBuffDebugString(int HandleId)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveBuffDebugString_Internal(HandleId));
		}

		// Token: 0x06018290 RID: 98960 RVA: 0x00239DB8 File Offset: 0x00237FB8
		[NullableContext(1)]
		public static string GetActiveBuffDebugAttributeString(int HandleId)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveBuffDebugAttributeString_Internal(HandleId));
		}

		// Token: 0x06018291 RID: 98961 RVA: 0x00239DC5 File Offset: 0x00237FC5
		[NullableContext(1)]
		public static FGameplayEffectContextHandle GetActiveBuffContextHandle(int HandleId)
		{
			return new FGameplayEffectContextHandle(UGASBPLibrary.__GetActiveBuffContextHandle_Internal(HandleId), null);
		}

		// Token: 0x06018292 RID: 98962 RVA: 0x00239DD3 File Offset: 0x00237FD3
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveBuffAssetTags(int HandleId)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveBuffAssetTags_Internal(HandleId), null);
		}

		// Token: 0x06018293 RID: 98963 RVA: 0x00239DE4 File Offset: 0x00237FE4
		[NullableContext(1)]
		public unsafe static int FnvHash(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			int result = UGASBPLibrary.__FnvHash_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018294 RID: 98964 RVA: 0x00239E08 File Offset: 0x00238008
		[NullableContext(1)]
		public unsafe static TArray<FAssetData> FindAllBlueprintAsset(FName BaseClassName, string Path = "/Game")
		{
			FString fstring = FString.AllocTemp(Path);
			TArray<FAssetData> result = new TArray<FAssetData>(UGASBPLibrary.__FindAllBlueprintAsset_Internal(BaseClassName, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018295 RID: 98965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnsureGameplayTagDataTableLoaded();

		// Token: 0x06018296 RID: 98966 RVA: 0x00239E33 File Offset: 0x00238033
		public static int AddTagToActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			return UGASBPLibrary.__AddTagToActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x06018297 RID: 98967 RVA: 0x00239E4C File Offset: 0x0023804C
		[NullableContext(1)]
		public static FGameplayEffectSpecHandle AddGrantedTag([Nullable(2)] FGameplayEffectSpecHandle SpecHandle, int TagHash)
		{
			return new FGameplayEffectSpecHandle(UGASBPLibrary.__AddGrantedTag_Internal((SpecHandle ?? new FGameplayEffectSpecHandle()).NativePtr, TagHash), null);
		}

		// Token: 0x06018298 RID: 98968 RVA: 0x00239E69 File Offset: 0x00238069
		public static void AddGameplayTag(ref FGameplayTagContainer TagContainer, int TagHash)
		{
			UGASBPLibrary.__AddGameplayTag_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, TagHash);
		}

		// Token: 0x06018299 RID: 98969 RVA: 0x00239E81 File Offset: 0x00238081
		public static void AddEffectContextTarget(FGameplayEffectContextHandle EffectContext, AActor Actor)
		{
			UGASBPLibrary.__AddEffectContextTarget_Internal((EffectContext ?? new FGameplayEffectContextHandle()).NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601829A RID: 98970 RVA: 0x00239EA8 File Offset: 0x002380A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool AddDataTableRowByName_EditorOnly(UDataTable DataTable, FName Name, UStruct Data)
		{
			UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams* ptr = stackalloc UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__AddDataTableRowByName_EditorOnly_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DataTable = ((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
			ptr->Name = Name;
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__AddDataTableRowByName_EditorOnly_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601829B RID: 98971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetRootComponent_Internal(IntPtr TargetActor, IntPtr NewRootComponent);

		// Token: 0x0601829C RID: 98972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNeedSyncAttributes_Internal(IntPtr SourceNeedSyncAttributes);

		// Token: 0x0601829D RID: 98973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ResetGameplayEffectSpecPeriod_Internal(IntPtr SpecHandle, float NewPeriod);

		// Token: 0x0601829E RID: 98974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTagFromActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x0601829F RID: 98975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBuffByTagFromActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x060182A0 RID: 98976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllGameplayEffects_Internal(IntPtr ASC);

		// Token: 0x060182A1 RID: 98977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllDurationGameplayEffects_Internal(IntPtr ASC);

		// Token: 0x060182A2 RID: 98978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveActiveBuff_Internal(IntPtr Asc, int HandleId, int StacksToRemove);

		// Token: 0x060182A3 RID: 98979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayTagContainerFromTagHash_Internal(int TagHash);

		// Token: 0x060182A4 RID: 98980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActiveGameplayEffectInhibited_Internal(IntPtr ActiveHandle);

		// Token: 0x060182A5 RID: 98981
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUglyTag_Internal(in FString Str);

		// Token: 0x060182A6 RID: 98982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOwnedGameplayTags_Internal(IntPtr ASC, IntPtr TargetContainer);

		// Token: 0x060182A7 RID: 98983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGameplayTags_Internal(IntPtr Tags);

		// Token: 0x060182A8 RID: 98984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameplayEffectContextTarget_Internal(IntPtr handle);

		// Token: 0x060182A9 RID: 98985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGameplayCueNotify_Internal(in FGameplayTag GameplayTag, IntPtr OutSoftObjectPath);

		// Token: 0x060182AA RID: 98986
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameplayAbilitySystemActivatableAbilitiesDebugString_Internal(IntPtr ASC);

		// Token: 0x060182AB RID: 98987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameplayAbilitySourceGE_Internal(IntPtr GameplayAbility);

		// Token: 0x060182AC RID: 98988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAssetPath_Internal(IntPtr Object);

		// Token: 0x060182AD RID: 98989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllTagsByParentTags_Internal(IntPtr ASC, in FGameplayTag Query, IntPtr Result);

		// Token: 0x060182AE RID: 98990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectServerId_Internal(IntPtr ActiveHandle);

		// Token: 0x060182AF RID: 98991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectPeriod_Internal(IntPtr ActiveHandle);

		// Token: 0x060182B0 RID: 98992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectModifiedAttributes_Internal(IntPtr ActiveHandle);

		// Token: 0x060182B1 RID: 98993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectHandleLevel_Internal(IntPtr Handle);

		// Token: 0x060182B2 RID: 98994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectHandleInstigator_Internal(IntPtr Handle);

		// Token: 0x060182B3 RID: 98995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetActiveGameplayEffectHandleGeId_Internal(IntPtr Handle);

		// Token: 0x060182B4 RID: 98996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectHandleEffectContext_Internal(IntPtr Handle);

		// Token: 0x060182B5 RID: 98997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectGrantedTags_Internal(IntPtr ActiveHandle);

		// Token: 0x060182B6 RID: 98998
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveGameplayEffectDebugString_Internal(IntPtr ActiveHandle);

		// Token: 0x060182B7 RID: 98999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectAssetTags_Internal(IntPtr ActiveHandle);

		// Token: 0x060182B8 RID: 99000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffInstigator_Internal(int HandleId);

		// Token: 0x060182B9 RID: 99001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffGrantedTags_Internal(int HandleId);

		// Token: 0x060182BA RID: 99002
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveBuffDebugString_Internal(int HandleId);

		// Token: 0x060182BB RID: 99003
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveBuffDebugAttributeString_Internal(int HandleId);

		// Token: 0x060182BC RID: 99004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffContextHandle_Internal(int HandleId);

		// Token: 0x060182BD RID: 99005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffAssetTags_Internal(int HandleId);

		// Token: 0x060182BE RID: 99006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FnvHash_Internal(in FString Str);

		// Token: 0x060182BF RID: 99007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindAllBlueprintAsset_Internal(FName BaseClassName, in FString Path);

		// Token: 0x060182C0 RID: 99008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddTagToActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x060182C1 RID: 99009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddGrantedTag_Internal(IntPtr SpecHandle, int TagHash);

		// Token: 0x060182C2 RID: 99010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGameplayTag_Internal(IntPtr TagContainer, int TagHash);

		// Token: 0x060182C3 RID: 99011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddEffectContextTarget_Internal(IntPtr EffectContext, IntPtr Actor);

		// Token: 0x060182C4 RID: 99012 RVA: 0x00239F20 File Offset: 0x00238120
		static UGASBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.GASBPLibrary");
		}

		// Token: 0x060182C5 RID: 99013 RVA: 0x00239F2E File Offset: 0x0023812E
		protected UGASBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D19D RID: 53661
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.GASBPLibrary";

		// Token: 0x0400D19E RID: 53662
		private static IntPtr _ClassPtr;

		// Token: 0x0400D19F RID: 53663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D1A0 RID: 53664
		private static IntPtr __SetAttributeValue_NativeFunctionPtr;

		// Token: 0x0400D1A1 RID: 53665
		private static IntPtr __IterateStructAndAssignAttributeSet_NativeFunctionPtr;

		// Token: 0x0400D1A2 RID: 53666
		private static IntPtr __AddDataTableRowByName_EditorOnly_NativeFunctionPtr;

		// Token: 0x0200304F RID: 12367
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetAttributeValue_FunctionParams
		{
			// Token: 0x04016D0D RID: 93453
			[FieldOffset(0)]
			public IntPtr AttributeSet;

			// Token: 0x04016D0E RID: 93454
			[FieldOffset(8)]
			public IntPtr InStruct;
		}

		// Token: 0x02003050 RID: 12368
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IterateStructAndAssignAttributeSet_FunctionParams
		{
			// Token: 0x04016D0F RID: 93455
			[FieldOffset(0)]
			public IntPtr AttributeSet;

			// Token: 0x04016D10 RID: 93456
			[FieldOffset(8)]
			public IntPtr Data;
		}

		// Token: 0x02003051 RID: 12369
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddDataTableRowByName_EditorOnly_FunctionParams
		{
			// Token: 0x04016D11 RID: 93457
			[FieldOffset(0)]
			public IntPtr DataTable;

			// Token: 0x04016D12 RID: 93458
			[FieldOffset(8)]
			public FName Name;

			// Token: 0x04016D13 RID: 93459
			[FieldOffset(24)]
			public IntPtr Data;

			// Token: 0x04016D14 RID: 93460
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
