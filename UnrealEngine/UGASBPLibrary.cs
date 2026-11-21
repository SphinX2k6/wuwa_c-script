using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000433 RID: 1075
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.GASBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGASBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006845 RID: 26693 RVA: 0x000983F2 File Offset: 0x000965F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGASBPLibrary._ClassPtr;
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00098400 File Offset: 0x00096600
		public UGASBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UGASBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00098428 File Offset: 0x00096628
		[NullableContext(1)]
		public UGASBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGASBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x0009845B File Offset: 0x0009665B
		public static bool SetRootComponent(AActor TargetActor, USceneComponent NewRootComponent)
		{
			return UGASBPLibrary.__SetRootComponent_Internal((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, (NewRootComponent != null) ? NewRootComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00098482 File Offset: 0x00096682
		public static void SetNeedSyncAttributes(in TSet<int> SourceNeedSyncAttributes)
		{
			UGASBPLibrary.__SetNeedSyncAttributes_Internal((SourceNeedSyncAttributes ?? new TSet<int>()).NativeSetPtr);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x0009849C File Offset: 0x0009669C
		[SkipLocalsInit]
		public unsafe static void SetAttributeValue(UBaseAttributeSet AttributeSet, UStruct InStruct)
		{
			UGASBPLibrary.__SetAttributeValue_FunctionParams* ptr = stackalloc UGASBPLibrary.__SetAttributeValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGASBPLibrary.__SetAttributeValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__SetAttributeValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeSet = ((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
			ptr->InStruct = ((InStruct != null) ? InStruct.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__SetAttributeValue_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00098506 File Offset: 0x00096706
		public static void RemoveTagFromActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			UGASBPLibrary.__RemoveTagFromActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x0009851F File Offset: 0x0009671F
		public static void RemoveBuffByTagFromActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			UGASBPLibrary.__RemoveBuffByTagFromActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00098538 File Offset: 0x00096738
		public static void RemoveAllGameplayEffects(UAbilitySystemComponent ASC)
		{
			UGASBPLibrary.__RemoveAllGameplayEffects_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x0009854F File Offset: 0x0009674F
		public static void RemoveAllDurationGameplayEffects(UAbilitySystemComponent ASC)
		{
			UGASBPLibrary.__RemoveAllDurationGameplayEffects_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x00098566 File Offset: 0x00096766
		public static bool RemoveActiveBuff(UAbilitySystemComponent Asc, int HandleId, int StacksToRemove)
		{
			return UGASBPLibrary.__RemoveActiveBuff_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, HandleId, StacksToRemove);
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x0009857F File Offset: 0x0009677F
		[NullableContext(1)]
		public static FGameplayTagContainer MakeGameplayTagContainerFromTagHash(int TagHash)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__MakeGameplayTagContainerFromTagHash_Internal(TagHash), null);
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00098590 File Offset: 0x00096790
		[SkipLocalsInit]
		public unsafe static void IterateStructAndAssignAttributeSet(UBaseAttributeSet AttributeSet, UStruct Data)
		{
			UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams* ptr = stackalloc UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGASBPLibrary.__IterateStructAndAssignAttributeSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__IterateStructAndAssignAttributeSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttributeSet = ((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__IterateStructAndAssignAttributeSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x000985FA File Offset: 0x000967FA
		public static bool IsActiveGameplayEffectInhibited(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__IsActiveGameplayEffectInhibited_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06006853 RID: 26707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsActiveBuffInhibited(int HandleId);

		// Token: 0x06006854 RID: 26708 RVA: 0x00098610 File Offset: 0x00096810
		[NullableContext(1)]
		public unsafe static string GetUglyTag(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			string result = FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetUglyTag_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00098639 File Offset: 0x00096839
		public static void GetOwnedGameplayTags(UAbilitySystemComponent ASC, ref FGameplayTagContainer TargetContainer)
		{
			UGASBPLibrary.__GetOwnedGameplayTags_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero, (TargetContainer ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06006856 RID: 26710
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetNetworkGameplayTagNodeIndexHash();

		// Token: 0x06006857 RID: 26711 RVA: 0x00098660 File Offset: 0x00096860
		public static void GetGameplayTags(ref TMap<int, FGameplayTag> Tags)
		{
			UGASBPLibrary.__GetGameplayTags_Internal((Tags ?? new TMap<int, FGameplayTag>()).NativeMapPtr);
		}

		// Token: 0x06006858 RID: 26712
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGameplayTagId(in FGameplayTag Tag);

		// Token: 0x06006859 RID: 26713
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGameplayTag GetGameplayTagFromTagHash(int TagHash);

		// Token: 0x0600685A RID: 26714 RVA: 0x00098677 File Offset: 0x00096877
		public static void GetGameplayCueNotify(in FGameplayTag GameplayTag, ref FSoftObjectPath OutSoftObjectPath)
		{
			UGASBPLibrary.__GetGameplayCueNotify_Internal(GameplayTag, (OutSoftObjectPath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x0009868F File Offset: 0x0009688F
		[NullableContext(1)]
		public static string GetGameplayAbilitySystemActivatableAbilitiesDebugString([Nullable(2)] UAbilitySystemComponent ASC)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetGameplayAbilitySystemActivatableAbilitiesDebugString_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x000986AB File Offset: 0x000968AB
		[NullableContext(1)]
		public static FActiveGameplayEffectHandle GetGameplayAbilitySourceGE([Nullable(2)] UGameplayAbility GameplayAbility)
		{
			return new FActiveGameplayEffectHandle(UGASBPLibrary.__GetGameplayAbilitySourceGE_Internal((GameplayAbility != null) ? GameplayAbility.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x000986C8 File Offset: 0x000968C8
		public static FName GetAssetPath(UObject Object)
		{
			return UGASBPLibrary.__GetAssetPath_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x000986DF File Offset: 0x000968DF
		public static void GetAllTagsByParentTags(UAbilitySystemComponent ASC, in FGameplayTag Query, ref FGameplayTagContainer Result)
		{
			UGASBPLibrary.__GetAllTagsByParentTags_Internal((ASC != null) ? ASC.NativePtr : IntPtr.Zero, Query, (Result ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00098707 File Offset: 0x00096907
		public static int GetActiveGameplayEffectServerId(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectServerId_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x0009871D File Offset: 0x0009691D
		public static float GetActiveGameplayEffectPeriod(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectPeriod_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00098733 File Offset: 0x00096933
		public static float GetActiveGameplayEffectHandleLevel(in FActiveGameplayEffectHandle Handle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectHandleLevel_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x0009874A File Offset: 0x0009694A
		public static AActor GetActiveGameplayEffectHandleInstigator(in FActiveGameplayEffectHandle Handle)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGASBPLibrary.__GetActiveGameplayEffectHandleInstigator_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00098766 File Offset: 0x00096966
		public static long GetActiveGameplayEffectHandleGeId(in FActiveGameplayEffectHandle Handle)
		{
			return UGASBPLibrary.__GetActiveGameplayEffectHandleGeId_Internal((Handle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x0009877D File Offset: 0x0009697D
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveGameplayEffectGrantedTags([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveGameplayEffectGrantedTags_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00098799 File Offset: 0x00096999
		[NullableContext(1)]
		public static string GetActiveGameplayEffectDebugString([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveGameplayEffectDebugString_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x000987B4 File Offset: 0x000969B4
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveGameplayEffectAssetTags([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveGameplayEffectAssetTags_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr), null);
		}

		// Token: 0x06006867 RID: 26727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffTotalDuration(int HandleId);

		// Token: 0x06006868 RID: 26728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveBuffStackCount(int HandleId);

		// Token: 0x06006869 RID: 26729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveBuffServerId(int HandleId);

		// Token: 0x0600686A RID: 26730
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffRemainingDuration(int HandleId);

		// Token: 0x0600686B RID: 26731
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffPeriod(int HandleId);

		// Token: 0x0600686C RID: 26732
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetActiveBuffLevel(int HandleId);

		// Token: 0x0600686D RID: 26733 RVA: 0x000987D0 File Offset: 0x000969D0
		public static AActor GetActiveBuffInstigator(int HandleId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UGASBPLibrary.__GetActiveBuffInstigator_Internal(HandleId));
		}

		// Token: 0x0600686E RID: 26734
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetActiveBuffId(int HandleId);

		// Token: 0x0600686F RID: 26735 RVA: 0x000987DD File Offset: 0x000969DD
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveBuffGrantedTags(int HandleId)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveBuffGrantedTags_Internal(HandleId), null);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x000987EB File Offset: 0x000969EB
		[NullableContext(1)]
		public static string GetActiveBuffDebugString(int HandleId)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveBuffDebugString_Internal(HandleId));
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x000987F8 File Offset: 0x000969F8
		[NullableContext(1)]
		public static string GetActiveBuffDebugAttributeString(int HandleId)
		{
			return FString.ToStringAndDeleteNativePtr(UGASBPLibrary.__GetActiveBuffDebugAttributeString_Internal(HandleId));
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00098805 File Offset: 0x00096A05
		[NullableContext(1)]
		public static FGameplayTagContainer GetActiveBuffAssetTags(int HandleId)
		{
			return new FGameplayTagContainer(UGASBPLibrary.__GetActiveBuffAssetTags_Internal(HandleId), null);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00098814 File Offset: 0x00096A14
		[NullableContext(1)]
		public unsafe static int FnvHash(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			int result = UGASBPLibrary.__FnvHash_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00098838 File Offset: 0x00096A38
		[NullableContext(1)]
		public unsafe static TArray<FAssetData> FindAllBlueprintAsset(FName BaseClassName, string Path = "/Game")
		{
			FString fstring = FString.AllocTemp(Path);
			TArray<FAssetData> result = new TArray<FAssetData>(UGASBPLibrary.__FindAllBlueprintAsset_Internal(BaseClassName, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006875 RID: 26741
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnsureGameplayTagDataTableLoaded();

		// Token: 0x06006876 RID: 26742 RVA: 0x00098863 File Offset: 0x00096A63
		public static int AddTagToActor(UAbilitySystemComponent Asc, int InTagHash, int MarkTagHash)
		{
			return UGASBPLibrary.__AddTagToActor_Internal((Asc != null) ? Asc.NativePtr : IntPtr.Zero, InTagHash, MarkTagHash);
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x0009887C File Offset: 0x00096A7C
		public static void AddGameplayTag(ref FGameplayTagContainer TagContainer, int TagHash)
		{
			UGASBPLibrary.__AddGameplayTag_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, TagHash);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00098894 File Offset: 0x00096A94
		[SkipLocalsInit]
		public unsafe static bool AddDataTableRowByName_EditorOnly(UDataTable DataTable, FName Name, UStruct Data)
		{
			UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams* ptr = stackalloc UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UGASBPLibrary.__AddDataTableRowByName_EditorOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGASBPLibrary.__AddDataTableRowByName_EditorOnly_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DataTable = ((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
			ptr->Name = Name;
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UGASBPLibrary._ClassDefaultObjectPtr, UGASBPLibrary.__AddDataTableRowByName_EditorOnly_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006879 RID: 26745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetRootComponent_Internal(IntPtr TargetActor, IntPtr NewRootComponent);

		// Token: 0x0600687A RID: 26746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNeedSyncAttributes_Internal(IntPtr SourceNeedSyncAttributes);

		// Token: 0x0600687B RID: 26747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTagFromActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x0600687C RID: 26748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBuffByTagFromActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x0600687D RID: 26749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllGameplayEffects_Internal(IntPtr ASC);

		// Token: 0x0600687E RID: 26750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllDurationGameplayEffects_Internal(IntPtr ASC);

		// Token: 0x0600687F RID: 26751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveActiveBuff_Internal(IntPtr Asc, int HandleId, int StacksToRemove);

		// Token: 0x06006880 RID: 26752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayTagContainerFromTagHash_Internal(int TagHash);

		// Token: 0x06006881 RID: 26753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActiveGameplayEffectInhibited_Internal(IntPtr ActiveHandle);

		// Token: 0x06006882 RID: 26754
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUglyTag_Internal(in FString Str);

		// Token: 0x06006883 RID: 26755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOwnedGameplayTags_Internal(IntPtr ASC, IntPtr TargetContainer);

		// Token: 0x06006884 RID: 26756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGameplayTags_Internal(IntPtr Tags);

		// Token: 0x06006885 RID: 26757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetGameplayCueNotify_Internal(in FGameplayTag GameplayTag, IntPtr OutSoftObjectPath);

		// Token: 0x06006886 RID: 26758
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameplayAbilitySystemActivatableAbilitiesDebugString_Internal(IntPtr ASC);

		// Token: 0x06006887 RID: 26759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameplayAbilitySourceGE_Internal(IntPtr GameplayAbility);

		// Token: 0x06006888 RID: 26760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAssetPath_Internal(IntPtr Object);

		// Token: 0x06006889 RID: 26761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllTagsByParentTags_Internal(IntPtr ASC, in FGameplayTag Query, IntPtr Result);

		// Token: 0x0600688A RID: 26762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectServerId_Internal(IntPtr ActiveHandle);

		// Token: 0x0600688B RID: 26763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectPeriod_Internal(IntPtr ActiveHandle);

		// Token: 0x0600688C RID: 26764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectHandleLevel_Internal(IntPtr Handle);

		// Token: 0x0600688D RID: 26765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectHandleInstigator_Internal(IntPtr Handle);

		// Token: 0x0600688E RID: 26766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetActiveGameplayEffectHandleGeId_Internal(IntPtr Handle);

		// Token: 0x0600688F RID: 26767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectGrantedTags_Internal(IntPtr ActiveHandle);

		// Token: 0x06006890 RID: 26768
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveGameplayEffectDebugString_Internal(IntPtr ActiveHandle);

		// Token: 0x06006891 RID: 26769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveGameplayEffectAssetTags_Internal(IntPtr ActiveHandle);

		// Token: 0x06006892 RID: 26770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffInstigator_Internal(int HandleId);

		// Token: 0x06006893 RID: 26771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffGrantedTags_Internal(int HandleId);

		// Token: 0x06006894 RID: 26772
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveBuffDebugString_Internal(int HandleId);

		// Token: 0x06006895 RID: 26773
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveBuffDebugAttributeString_Internal(int HandleId);

		// Token: 0x06006896 RID: 26774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveBuffAssetTags_Internal(int HandleId);

		// Token: 0x06006897 RID: 26775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FnvHash_Internal(in FString Str);

		// Token: 0x06006898 RID: 26776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindAllBlueprintAsset_Internal(FName BaseClassName, in FString Path);

		// Token: 0x06006899 RID: 26777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddTagToActor_Internal(IntPtr Asc, int InTagHash, int MarkTagHash);

		// Token: 0x0600689A RID: 26778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGameplayTag_Internal(IntPtr TagContainer, int TagHash);

		// Token: 0x0600689B RID: 26779 RVA: 0x0009890B File Offset: 0x00096B0B
		static UGASBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.GASBPLibrary");
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00098919 File Offset: 0x00096B19
		protected UGASBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002C95 RID: 11413
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.GASBPLibrary";

		// Token: 0x04002C96 RID: 11414
		private static IntPtr _ClassPtr;

		// Token: 0x04002C97 RID: 11415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002C98 RID: 11416
		private static IntPtr __SetAttributeValue_NativeFunctionPtr;

		// Token: 0x04002C99 RID: 11417
		private static IntPtr __IterateStructAndAssignAttributeSet_NativeFunctionPtr;

		// Token: 0x04002C9A RID: 11418
		private static IntPtr __AddDataTableRowByName_EditorOnly_NativeFunctionPtr;

		// Token: 0x02000B4D RID: 2893
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetAttributeValue_FunctionParams
		{
			// Token: 0x04005C5B RID: 23643
			[FieldOffset(0)]
			public IntPtr AttributeSet;

			// Token: 0x04005C5C RID: 23644
			[FieldOffset(8)]
			public IntPtr InStruct;
		}

		// Token: 0x02000B4E RID: 2894
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IterateStructAndAssignAttributeSet_FunctionParams
		{
			// Token: 0x04005C5D RID: 23645
			[FieldOffset(0)]
			public IntPtr AttributeSet;

			// Token: 0x04005C5E RID: 23646
			[FieldOffset(8)]
			public IntPtr Data;
		}

		// Token: 0x02000B4F RID: 2895
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddDataTableRowByName_EditorOnly_FunctionParams
		{
			// Token: 0x04005C5F RID: 23647
			[FieldOffset(0)]
			public IntPtr DataTable;

			// Token: 0x04005C60 RID: 23648
			[FieldOffset(8)]
			public FName Name;

			// Token: 0x04005C61 RID: 23649
			[FieldOffset(24)]
			public IntPtr Data;

			// Token: 0x04005C62 RID: 23650
			[FieldOffset(32)]
			public bool __Result;
		}
	}
}
