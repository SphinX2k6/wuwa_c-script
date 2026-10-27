using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D0 RID: 5072
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.BlueprintGameplayTagLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601290C RID: 76044 RVA: 0x001B51C6 File Offset: 0x001B33C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintGameplayTagLibrary._ClassPtr;
		}

		// Token: 0x0601290D RID: 76045 RVA: 0x001B51D4 File Offset: 0x001B33D4
		public UBlueprintGameplayTagLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintGameplayTagLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601290E RID: 76046 RVA: 0x001B51FC File Offset: 0x001B33FC
		[NullableContext(1)]
		public UBlueprintGameplayTagLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintGameplayTagLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601290F RID: 76047 RVA: 0x001B522F File Offset: 0x001B342F
		public static bool RemoveGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
		{
			return UBlueprintGameplayTagLibrary.__RemoveGameplayTag_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, Tag);
		}

		// Token: 0x06012910 RID: 76048 RVA: 0x001B5248 File Offset: 0x001B3448
		[NullableContext(1)]
		public unsafe static bool NotEqual_TagTag(FGameplayTag A, string B)
		{
			FString fstring = FString.AllocTemp(B);
			bool result = UBlueprintGameplayTagLibrary.__NotEqual_TagTag_Internal(A, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06012911 RID: 76049 RVA: 0x001B5270 File Offset: 0x001B3470
		[NullableContext(1)]
		public unsafe static bool NotEqual_TagContainerTagContainer([Nullable(2)] FGameplayTagContainer A, string B)
		{
			FString fstring = FString.AllocTemp(B);
			bool result = UBlueprintGameplayTagLibrary.__NotEqual_TagContainerTagContainer_Internal((A ?? new FGameplayTagContainer()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06012912 RID: 76050 RVA: 0x001B52A3 File Offset: 0x001B34A3
		public static bool NotEqual_GameplayTagContainer(in FGameplayTagContainer A, in FGameplayTagContainer B)
		{
			return UBlueprintGameplayTagLibrary.__NotEqual_GameplayTagContainer_Internal((A ?? new FGameplayTagContainer()).NativePtr, (B ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06012913 RID: 76051
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_GameplayTag(FGameplayTag A, FGameplayTag B);

		// Token: 0x06012914 RID: 76052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool MatchesTag(FGameplayTag TagOne, FGameplayTag TagTwo, bool bExactMatch);

		// Token: 0x06012915 RID: 76053 RVA: 0x001B52CA File Offset: 0x001B34CA
		public static bool MatchesAnyTags(FGameplayTag TagOne, in FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			return UBlueprintGameplayTagLibrary.__MatchesAnyTags_Internal(TagOne, (OtherContainer ?? new FGameplayTagContainer()).NativePtr, bExactMatch);
		}

		// Token: 0x06012916 RID: 76054 RVA: 0x001B52E3 File Offset: 0x001B34E3
		[NullableContext(1)]
		public static FGameplayTagContainer MakeLiteralGameplayTagContainer([Nullable(2)] FGameplayTagContainer Value)
		{
			return new FGameplayTagContainer(UBlueprintGameplayTagLibrary.__MakeLiteralGameplayTagContainer_Internal((Value ?? new FGameplayTagContainer()).NativePtr), null);
		}

		// Token: 0x06012917 RID: 76055
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value);

		// Token: 0x06012918 RID: 76056 RVA: 0x001B52FF File Offset: 0x001B34FF
		[NullableContext(1)]
		public static FGameplayTagQuery MakeGameplayTagQuery([Nullable(2)] FGameplayTagQuery TagQuery)
		{
			return new FGameplayTagQuery(UBlueprintGameplayTagLibrary.__MakeGameplayTagQuery_Internal((TagQuery ?? new FGameplayTagQuery()).NativePtr), null);
		}

		// Token: 0x06012919 RID: 76057 RVA: 0x001B531B File Offset: 0x001B351B
		[NullableContext(1)]
		public static FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag)
		{
			return new FGameplayTagContainer(UBlueprintGameplayTagLibrary.__MakeGameplayTagContainerFromTag_Internal(SingleTag), null);
		}

		// Token: 0x0601291A RID: 76058 RVA: 0x001B5329 File Offset: 0x001B3529
		[NullableContext(1)]
		public static FGameplayTagContainer MakeGameplayTagContainerFromArray([Nullable(2)] in TArray<FGameplayTag> GameplayTags)
		{
			return new FGameplayTagContainer(UBlueprintGameplayTagLibrary.__MakeGameplayTagContainerFromArray_Internal((GameplayTags ?? new TArray<FGameplayTag>()).NativePtr), null);
		}

		// Token: 0x0601291B RID: 76059 RVA: 0x001B5346 File Offset: 0x001B3546
		public static bool IsTagQueryEmpty(in FGameplayTagQuery TagQuery)
		{
			return UBlueprintGameplayTagLibrary.__IsTagQueryEmpty_Internal((TagQuery ?? new FGameplayTagQuery()).NativePtr);
		}

		// Token: 0x0601291C RID: 76060
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsGameplayTagValid(FGameplayTag GameplayTag);

		// Token: 0x0601291D RID: 76061 RVA: 0x001B535D File Offset: 0x001B355D
		public static bool HasTag(in FGameplayTagContainer TagContainer, FGameplayTag Tag, bool bExactMatch)
		{
			return UBlueprintGameplayTagLibrary.__HasTag_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, Tag, bExactMatch);
		}

		// Token: 0x0601291E RID: 76062 RVA: 0x001B5376 File Offset: 0x001B3576
		public static bool HasAnyTags(in FGameplayTagContainer TagContainer, in FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			return UBlueprintGameplayTagLibrary.__HasAnyTags_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, (OtherContainer ?? new FGameplayTagContainer()).NativePtr, bExactMatch);
		}

		// Token: 0x0601291F RID: 76063 RVA: 0x001B539E File Offset: 0x001B359E
		public static bool HasAllTags(in FGameplayTagContainer TagContainer, in FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			return UBlueprintGameplayTagLibrary.__HasAllTags_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, (OtherContainer ?? new FGameplayTagContainer()).NativePtr, bExactMatch);
		}

		// Token: 0x06012920 RID: 76064 RVA: 0x001B53C8 File Offset: 0x001B35C8
		public static bool HasAllMatchingGameplayTags(IGameplayTagAssetInterface TagContainerInterface, in FGameplayTagContainer OtherContainer)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(TagContainerInterface, (TagContainerInterface != null) ? TagContainerInterface.InterfaceOffset() : 0);
			return UBlueprintGameplayTagLibrary.__HasAllMatchingGameplayTags_Internal(fscriptInterface, (OtherContainer ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06012921 RID: 76065
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetTagName(in FGameplayTag GameplayTag);

		// Token: 0x06012922 RID: 76066 RVA: 0x001B5400 File Offset: 0x001B3600
		public static int GetNumGameplayTagsInContainer(in FGameplayTagContainer TagContainer)
		{
			return UBlueprintGameplayTagLibrary.__GetNumGameplayTagsInContainer_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06012923 RID: 76067 RVA: 0x001B5417 File Offset: 0x001B3617
		[NullableContext(1)]
		public static string GetDebugStringFromGameplayTagContainer([Nullable(2)] in FGameplayTagContainer TagContainer)
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintGameplayTagLibrary.__GetDebugStringFromGameplayTagContainer_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr));
		}

		// Token: 0x06012924 RID: 76068 RVA: 0x001B5433 File Offset: 0x001B3633
		[NullableContext(1)]
		public static string GetDebugStringFromGameplayTag(FGameplayTag GameplayTag)
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintGameplayTagLibrary.__GetDebugStringFromGameplayTag_Internal(GameplayTag));
		}

		// Token: 0x06012925 RID: 76069 RVA: 0x001B5440 File Offset: 0x001B3640
		public static void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass, in FGameplayTagQuery GameplayTagQuery, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UBlueprintGameplayTagLibrary.__GetAllActorsOfClassMatchingTagQuery_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActorClass._NativePtr, (GameplayTagQuery ?? new FGameplayTagQuery()).NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06012926 RID: 76070 RVA: 0x001B547D File Offset: 0x001B367D
		public static bool EqualEqual_GameplayTagContainer(in FGameplayTagContainer A, in FGameplayTagContainer B)
		{
			return UBlueprintGameplayTagLibrary.__EqualEqual_GameplayTagContainer_Internal((A ?? new FGameplayTagContainer()).NativePtr, (B ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06012927 RID: 76071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_GameplayTag(FGameplayTag A, FGameplayTag B);

		// Token: 0x06012928 RID: 76072 RVA: 0x001B54A4 File Offset: 0x001B36A4
		public static bool DoesTagAssetInterfaceHaveTag(IGameplayTagAssetInterface TagContainerInterface, FGameplayTag Tag)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(TagContainerInterface, (TagContainerInterface != null) ? TagContainerInterface.InterfaceOffset() : 0);
			return UBlueprintGameplayTagLibrary.__DoesTagAssetInterfaceHaveTag_Internal(fscriptInterface, Tag);
		}

		// Token: 0x06012929 RID: 76073 RVA: 0x001B54CD File Offset: 0x001B36CD
		public static bool DoesContainerMatchTagQuery(in FGameplayTagContainer TagContainer, in FGameplayTagQuery TagQuery)
		{
			return UBlueprintGameplayTagLibrary.__DoesContainerMatchTagQuery_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, (TagQuery ?? new FGameplayTagQuery()).NativePtr);
		}

		// Token: 0x0601292A RID: 76074 RVA: 0x001B54F4 File Offset: 0x001B36F4
		public static void BreakGameplayTagContainer(in FGameplayTagContainer GameplayTagContainer, ref TArray<FGameplayTag> GameplayTags)
		{
			UBlueprintGameplayTagLibrary.__BreakGameplayTagContainer_Internal((GameplayTagContainer ?? new FGameplayTagContainer()).NativePtr, (GameplayTags ?? new TArray<FGameplayTag>()).NativePtr);
		}

		// Token: 0x0601292B RID: 76075 RVA: 0x001B551B File Offset: 0x001B371B
		public static void AppendGameplayTagContainers(ref FGameplayTagContainer InOutTagContainer, in FGameplayTagContainer InTagContainer)
		{
			UBlueprintGameplayTagLibrary.__AppendGameplayTagContainers_Internal((InOutTagContainer ?? new FGameplayTagContainer()).NativePtr, (InTagContainer ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0601292C RID: 76076 RVA: 0x001B5542 File Offset: 0x001B3742
		public static void AddGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
		{
			UBlueprintGameplayTagLibrary.__AddGameplayTag_Internal((TagContainer ?? new FGameplayTagContainer()).NativePtr, Tag);
		}

		// Token: 0x0601292D RID: 76077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveGameplayTag_Internal(IntPtr TagContainer, FGameplayTag Tag);

		// Token: 0x0601292E RID: 76078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_TagTag_Internal(FGameplayTag A, in FString B);

		// Token: 0x0601292F RID: 76079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_TagContainerTagContainer_Internal(IntPtr A, in FString B);

		// Token: 0x06012930 RID: 76080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_GameplayTagContainer_Internal(IntPtr A, IntPtr B);

		// Token: 0x06012931 RID: 76081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MatchesAnyTags_Internal(FGameplayTag TagOne, IntPtr OtherContainer, bool bExactMatch);

		// Token: 0x06012932 RID: 76082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeLiteralGameplayTagContainer_Internal(IntPtr Value);

		// Token: 0x06012933 RID: 76083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayTagQuery_Internal(IntPtr TagQuery);

		// Token: 0x06012934 RID: 76084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayTagContainerFromTag_Internal(FGameplayTag SingleTag);

		// Token: 0x06012935 RID: 76085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeGameplayTagContainerFromArray_Internal(IntPtr GameplayTags);

		// Token: 0x06012936 RID: 76086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTagQueryEmpty_Internal(IntPtr TagQuery);

		// Token: 0x06012937 RID: 76087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasTag_Internal(IntPtr TagContainer, FGameplayTag Tag, bool bExactMatch);

		// Token: 0x06012938 RID: 76088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyTags_Internal(IntPtr TagContainer, IntPtr OtherContainer, bool bExactMatch);

		// Token: 0x06012939 RID: 76089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAllTags_Internal(IntPtr TagContainer, IntPtr OtherContainer, bool bExactMatch);

		// Token: 0x0601293A RID: 76090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAllMatchingGameplayTags_Internal(in FScriptInterface TagContainerInterface, IntPtr OtherContainer);

		// Token: 0x0601293B RID: 76091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumGameplayTagsInContainer_Internal(IntPtr TagContainer);

		// Token: 0x0601293C RID: 76092
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugStringFromGameplayTagContainer_Internal(IntPtr TagContainer);

		// Token: 0x0601293D RID: 76093
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugStringFromGameplayTag_Internal(FGameplayTag GameplayTag);

		// Token: 0x0601293E RID: 76094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsOfClassMatchingTagQuery_Internal(IntPtr WorldContextObject, IntPtr ActorClass, IntPtr GameplayTagQuery, IntPtr OutActors);

		// Token: 0x0601293F RID: 76095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_GameplayTagContainer_Internal(IntPtr A, IntPtr B);

		// Token: 0x06012940 RID: 76096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesTagAssetInterfaceHaveTag_Internal(in FScriptInterface TagContainerInterface, FGameplayTag Tag);

		// Token: 0x06012941 RID: 76097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesContainerMatchTagQuery_Internal(IntPtr TagContainer, IntPtr TagQuery);

		// Token: 0x06012942 RID: 76098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakGameplayTagContainer_Internal(IntPtr GameplayTagContainer, IntPtr GameplayTags);

		// Token: 0x06012943 RID: 76099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AppendGameplayTagContainers_Internal(IntPtr InOutTagContainer, IntPtr InTagContainer);

		// Token: 0x06012944 RID: 76100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGameplayTag_Internal(IntPtr TagContainer, FGameplayTag Tag);

		// Token: 0x06012945 RID: 76101 RVA: 0x001B555A File Offset: 0x001B375A
		static UBlueprintGameplayTagLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.BlueprintGameplayTagLibrary");
		}

		// Token: 0x06012946 RID: 76102 RVA: 0x001B5568 File Offset: 0x001B3768
		protected UBlueprintGameplayTagLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EC3 RID: 40643
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTags.BlueprintGameplayTagLibrary";

		// Token: 0x04009EC4 RID: 40644
		private static IntPtr _ClassPtr;

		// Token: 0x04009EC5 RID: 40645
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
