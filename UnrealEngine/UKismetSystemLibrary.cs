using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD6 RID: 3286
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetSystemLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetSystemLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABB6 RID: 43958 RVA: 0x000F15CC File Offset: 0x000EF7CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetSystemLibrary._ClassPtr;
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x000F15D8 File Offset: 0x000EF7D8
		public UKismetSystemLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetSystemLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x000F1600 File Offset: 0x000EF800
		[NullableContext(1)]
		public UKismetSystemLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetSystemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABB9 RID: 43961
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterForRemoteNotifications();

		// Token: 0x0600ABBA RID: 43962 RVA: 0x000F1633 File Offset: 0x000EF833
		public static void UnloadPrimaryAssetList([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetId> PrimaryAssetIdList)
		{
			UKismetSystemLibrary.__UnloadPrimaryAssetList_Internal((PrimaryAssetIdList ?? new TArray<FPrimaryAssetId>()).NativePtr);
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x000F164A File Offset: 0x000EF84A
		public static void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId)
		{
			UKismetSystemLibrary.__UnloadPrimaryAsset_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x000F1660 File Offset: 0x000EF860
		public static void TransactObject(UObject Object)
		{
			UKismetSystemLibrary.__TransactObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x000F1677 File Offset: 0x000EF877
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void StackTrace()
		{
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__StackTrace_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x000F168C File Offset: 0x000EF88C
		public static bool SphereTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceSingleForObjects_Internal(worldContextObject, Start, End, Radius, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x000F178C File Offset: 0x000EF98C
		public static bool SphereTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceSingleByProfile_Internal(worldContextObject, Start, End, Radius, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x000F187C File Offset: 0x000EFA7C
		public static bool SphereTraceSingle(UObject WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceSingle_Internal(worldContextObject, Start, End, Radius, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x000F1974 File Offset: 0x000EFB74
		public static bool SphereTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceMultiForObjects_Internal(worldContextObject, Start, End, Radius, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x000F1A74 File Offset: 0x000EFC74
		public static bool SphereTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceMultiByProfile_Internal(worldContextObject, Start, End, Radius, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x000F1B64 File Offset: 0x000EFD64
		public static bool SphereTraceMulti(UObject WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__SphereTraceMulti_Internal(worldContextObject, Start, End, Radius, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x000F1C5C File Offset: 0x000EFE5C
		public static bool SphereOverlapComponents(UObject WorldContextObject, FVector SpherePos, float SphereRadius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ComponentClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutComponents)
		{
			return UKismetSystemLibrary.__SphereOverlapComponents_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, SpherePos, SphereRadius, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ComponentClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x000F1CBC File Offset: 0x000EFEBC
		public static bool SphereOverlapActors(UObject WorldContextObject, FVector SpherePos, float SphereRadius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ActorClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			return UKismetSystemLibrary.__SphereOverlapActors_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, SpherePos, SphereRadius, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ActorClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x000F1D19 File Offset: 0x000EFF19
		public static void SnapshotObject(UObject Object)
		{
			UKismetSystemLibrary.__SnapshotObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x000F1D30 File Offset: 0x000EFF30
		[NullableContext(1)]
		public unsafe static void ShowPlatformSpecificLeaderboardScreen(string CategoryName)
		{
			FString fstring = FString.AllocTemp(CategoryName);
			UKismetSystemLibrary.__ShowPlatformSpecificLeaderboardScreen_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x000F1D54 File Offset: 0x000EFF54
		public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer)
		{
			UKismetSystemLibrary.__ShowPlatformSpecificAchievementsScreen_Internal((SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABC9 RID: 43977
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowInterstitialAd();

		// Token: 0x0600ABCA RID: 43978
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowAdBanner(int AdIdIndex, bool bShowOnBottomOfScreen);

		// Token: 0x0600ABCB RID: 43979 RVA: 0x000F1D6B File Offset: 0x000EFF6B
		[NullableContext(1)]
		public static void SetWindowTitle(in FText Title)
		{
			FText ftext = Title;
			UKismetSystemLibrary.__SetWindowTitle_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABCC RID: 43980
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetVolumeButtonsHandledBySystem(bool bEnabled);

		// Token: 0x0600ABCD RID: 43981 RVA: 0x000F1D84 File Offset: 0x000EFF84
		public static void SetVectorPropertyByName(UObject Object, FName PropertyName, in FVector Value)
		{
			UKismetSystemLibrary.__SetVectorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x000F1D9D File Offset: 0x000EFF9D
		public static void SetVectorDoublePropertyByName(UObject Object, FName PropertyName, in FVectorDouble Value)
		{
			UKismetSystemLibrary.__SetVectorDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x000F1DB6 File Offset: 0x000EFFB6
		public static void SetUserActivity(in FUserActivity UserActivity)
		{
			UKismetSystemLibrary.__SetUserActivity_Internal((UserActivity ?? new FUserActivity()).NativePtr);
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x000F1DD0 File Offset: 0x000EFFD0
		public unsafe static void SetTransformPropertyByName(UObject Object, FName PropertyName, in FTransform Value)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UKismetSystemLibrary.__SetTransformPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, ptr);
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x000F1E10 File Offset: 0x000F0010
		public unsafe static void SetTransformDoublePropertyByName(UObject Object, FName PropertyName, in FTransformDouble Value)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UKismetSystemLibrary.__SetTransformDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, ptr);
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x000F1E50 File Offset: 0x000F0050
		[NullableContext(1)]
		public static void SetTextPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in FText Value)
		{
			IntPtr @object = (Object != null) ? Object.NativePtr : IntPtr.Zero;
			FText ftext = Value;
			UKismetSystemLibrary.__SetTextPropertyByName_Internal(@object, PropertyName, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x000F1E7A File Offset: 0x000F007A
		public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject, bool bState)
		{
			UKismetSystemLibrary.__SetSuppressViewportTransitionMessage_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bState);
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x000F1E94 File Offset: 0x000F0094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetStructurePropertyByName(UObject Object, FName PropertyName, in FGenericStruct Value)
		{
			UKismetSystemLibrary.__SetStructurePropertyByName_FunctionParams* ptr = stackalloc UKismetSystemLibrary.__SetStructurePropertyByName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetSystemLibrary.__SetStructurePropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetSystemLibrary.__SetStructurePropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__SetStructurePropertyByName_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x000F1EFC File Offset: 0x000F00FC
		[NullableContext(1)]
		public unsafe static void SetStringPropertyByName([Nullable(2)] UObject Object, FName PropertyName, string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UKismetSystemLibrary.__SetStringPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x000F1F31 File Offset: 0x000F0131
		[NullableContext(1)]
		public static void SetSoftObjectPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in TSoftObjectPtr<UObject> Value)
		{
			UKismetSystemLibrary.__SetSoftObjectPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x000F1F59 File Offset: 0x000F0159
		[NullableContext(1)]
		public static void SetSoftClassPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in TSoftClassPtr<UObject> Value)
		{
			UKismetSystemLibrary.__SetSoftClassPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x000F1F81 File Offset: 0x000F0181
		public static void SetRotatorPropertyByName(UObject Object, FName PropertyName, in FRotator Value)
		{
			UKismetSystemLibrary.__SetRotatorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x000F1F9A File Offset: 0x000F019A
		public static void SetObjectPropertyByName(UObject Object, FName PropertyName, UObject Value)
		{
			UKismetSystemLibrary.__SetObjectPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x000F1FC4 File Offset: 0x000F01C4
		public unsafe static void SetNamePropertyByName(UObject Object, FName PropertyName, in FName Value)
		{
			fixed (FName* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				UKismetSystemLibrary.__SetNamePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
			}
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x000F1FF0 File Offset: 0x000F01F0
		public static void SetLinearColorPropertyByName(UObject Object, FName PropertyName, in FLinearColor Value)
		{
			UKismetSystemLibrary.__SetLinearColorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x000F2009 File Offset: 0x000F0209
		public static void SetIntPropertyByName(UObject Object, FName PropertyName, int Value)
		{
			UKismetSystemLibrary.__SetIntPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x000F2024 File Offset: 0x000F0224
		public unsafe static void SetInterfacePropertyByName(UObject Object, FName PropertyName, in FScriptInterface Value)
		{
			fixed (FScriptInterface* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				UKismetSystemLibrary.__SetInterfacePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
			}
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x000F2050 File Offset: 0x000F0250
		public static void SetInt64PropertyByName(UObject Object, FName PropertyName, long Value)
		{
			UKismetSystemLibrary.__SetInt64PropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABDF RID: 43999
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGamepadsBlockDeviceFeedback(bool bBlock);

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x000F2069 File Offset: 0x000F0269
		public static void SetFloatPropertyByName(UObject Object, FName PropertyName, float Value)
		{
			UKismetSystemLibrary.__SetFloatPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x000F2084 File Offset: 0x000F0284
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetFieldPathPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in Unusable Value)
		{
			UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams* ptr = stackalloc UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x000F20F9 File Offset: 0x000F02F9
		public static void SetDoublePropertyByName(UObject Object, FName PropertyName, double Value)
		{
			UKismetSystemLibrary.__SetDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x000F2112 File Offset: 0x000F0312
		public static void SetColorPropertyByName(UObject Object, FName PropertyName, in FColor Value)
		{
			UKismetSystemLibrary.__SetColorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x000F212C File Offset: 0x000F032C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCollisionProfileNameProperty(UObject Object, FName PropertyName, in FCollisionProfileName Value)
		{
			UKismetSystemLibrary.__SetCollisionProfileNameProperty_FunctionParams* ptr = stackalloc UKismetSystemLibrary.__SetCollisionProfileNameProperty_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKismetSystemLibrary.__SetCollisionProfileNameProperty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetSystemLibrary.__SetCollisionProfileNameProperty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			if (Value != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), &ptr->Value, Value.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__SetCollisionProfileNameProperty_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x000F21AC File Offset: 0x000F03AC
		public static void SetClassPropertyByName(UObject Object, FName PropertyName, UClassStackOnlyPtr Value)
		{
			UKismetSystemLibrary.__SetClassPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value._NativePtr);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x000F21CA File Offset: 0x000F03CA
		public static void SetBytePropertyByName(UObject Object, FName PropertyName, byte Value)
		{
			UKismetSystemLibrary.__SetBytePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x000F21E3 File Offset: 0x000F03E3
		public static void SetBoolPropertyByName(UObject Object, FName PropertyName, bool Value)
		{
			UKismetSystemLibrary.__SetBoolPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x000F21FC File Offset: 0x000F03FC
		public static bool SetAllChannels(ref FCollisionResponseContainer ResponseToChannels, ECollisionResponse NewResponse)
		{
			return UKismetSystemLibrary.__SetAllChannels_Internal((ResponseToChannels ?? new FCollisionResponseContainer()).NativePtr, NewResponse);
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x000F2219 File Offset: 0x000F0419
		[NullableContext(1)]
		public static string RHIName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__RHIName_Internal());
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x000F2225 File Offset: 0x000F0425
		public static void RetriggerableDelay(UObject WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
		{
			UKismetSystemLibrary.__RetriggerableDelay_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Duration, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600ABEB RID: 44011
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGamepadAssignmentToController(int ControllerId);

		// Token: 0x0600ABEC RID: 44012
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGamepadAssignments();

		// Token: 0x0600ABED RID: 44013
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterForRemoteNotifications();

		// Token: 0x0600ABEE RID: 44014 RVA: 0x000F224C File Offset: 0x000F044C
		public static void QuitGame(UObject WorldContextObject, APlayerController SpecificPlayer, EQuitPreference QuitPreference, bool bIgnorePlatformRestrictions)
		{
			UKismetSystemLibrary.__QuitGame_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero, QuitPreference, bIgnorePlatformRestrictions);
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x000F227C File Offset: 0x000F047C
		[NullableContext(1)]
		public unsafe static void PrintWarning(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			UKismetSystemLibrary.__PrintWarning_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x000F22A0 File Offset: 0x000F04A0
		[NullableContext(1)]
		public static void PrintText([Nullable(2)] UObject WorldContextObject, FText InText, bool bPrintToScreen = true, bool bPrintToLog = true, FLinearColor? TextColor = null, float Duration = 2f)
		{
			UKismetSystemLibrary.__PrintText_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InText != null) ? InText.NativePtr : IntPtr.Zero, bPrintToScreen, bPrintToLog, TextColor ?? new FLinearColor
			{
				R = 0f,
				G = 0.66f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x000F2324 File Offset: 0x000F0524
		[NullableContext(1)]
		public unsafe static void PrintString([Nullable(2)] UObject WorldContextObject, string InString = "Hello", bool bPrintToScreen = true, bool bPrintToLog = true, FLinearColor? TextColor = null, float Duration = 2f)
		{
			FString fstring = FString.AllocTemp(InString);
			UKismetSystemLibrary.__PrintString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, bPrintToScreen, bPrintToLog, TextColor ?? new FLinearColor
			{
				R = 0f,
				G = 0.66f,
				B = 1f,
				A = 1f
			}, Duration);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x000F23AC File Offset: 0x000F05AC
		[NullableContext(1)]
		public unsafe static bool ParseParamValue(string InString, string InParam, ref string OutValue)
		{
			FString fstring = FString.AllocTemp(InString);
			FString fstring2 = FString.AllocTemp(InParam);
			FString fstring3 = FString.AllocTemp(OutValue);
			bool result = UKismetSystemLibrary.__ParseParamValue_Internal(fstring, fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			OutValue = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x000F2400 File Offset: 0x000F0600
		[NullableContext(1)]
		public unsafe static bool ParseParam(string InString, string InParam)
		{
			FString fstring = FString.AllocTemp(InString);
			FString fstring2 = FString.AllocTemp(InParam);
			bool result = UKismetSystemLibrary.__ParseParam_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x000F2438 File Offset: 0x000F0638
		[NullableContext(1)]
		public unsafe static void ParseCommandLine(string InCmdLine, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutTokens, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutSwitches, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<string, string> OutParams)
		{
			FString fstring = FString.AllocTemp(InCmdLine);
			UKismetSystemLibrary.__ParseCommandLine_Internal(fstring, (OutTokens ?? new TArray<string>()).NativePtr, (OutSwitches ?? new TArray<string>()).NativePtr, (OutParams ?? new TMap<string, string>()).NativeMapPtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x000F248C File Offset: 0x000F068C
		[NullableContext(1)]
		public static bool NotEqual_SoftObjectReference(in TSoftObjectPtr<UObject> A, in TSoftObjectPtr<UObject> B)
		{
			return UKismetSystemLibrary.__NotEqual_SoftObjectReference_Internal((A ?? new TSoftObjectPtr<UObject>()).NativePtr, (B ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x000F24B3 File Offset: 0x000F06B3
		[NullableContext(1)]
		public static bool NotEqual_SoftClassReference(in TSoftClassPtr<UObject> A, in TSoftClassPtr<UObject> B)
		{
			return UKismetSystemLibrary.__NotEqual_SoftClassReference_Internal((A ?? new TSoftClassPtr<UObject>()).NativePtr, (B ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x000F24DA File Offset: 0x000F06DA
		public static bool NotEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			return UKismetSystemLibrary.__NotEqual_PrimaryAssetType_Internal((A ?? new FPrimaryAssetType()).NativePtr, (B ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x000F24FF File Offset: 0x000F06FF
		public static bool NotEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			return UKismetSystemLibrary.__NotEqual_PrimaryAssetId_Internal((A ?? new FPrimaryAssetId()).NativePtr, (B ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x000F2524 File Offset: 0x000F0724
		[NullableContext(1)]
		public unsafe static string NormalizeFilename(string InFilename)
		{
			FString fstring = FString.AllocTemp(InFilename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__NormalizeFilename_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x000F2550 File Offset: 0x000F0750
		public static void MoveComponentTo(USceneComponent Component, FVector TargetRelativeLocation, FRotator TargetRelativeRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, EMoveComponentAction MoveAction, FLatentActionInfo LatentInfo)
		{
			UKismetSystemLibrary.__MoveComponentTo_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, TargetRelativeLocation, TargetRelativeRotation, bEaseOut, bEaseIn, OverTime, bForceShortestRotationPath, MoveAction, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x000F2594 File Offset: 0x000F0794
		[NullableContext(1)]
		public unsafe static FTopLevelAssetPath MakeTopLevelAssetPath(string PackageName, string AssetName)
		{
			FString fstring = FString.AllocTemp(PackageName);
			FString fstring2 = FString.AllocTemp(AssetName);
			FTopLevelAssetPath result = new FTopLevelAssetPath(UKismetSystemLibrary.__MakeTopLevelAssetPath_Internal(fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x000F25D0 File Offset: 0x000F07D0
		[NullableContext(1)]
		public unsafe static FSoftObjectPath MakeSoftObjectPath(string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			FSoftObjectPath result = new FSoftObjectPath(UKismetSystemLibrary.__MakeSoftObjectPath_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x000F25FC File Offset: 0x000F07FC
		[NullableContext(1)]
		public unsafe static FSoftClassPath MakeSoftClassPath(string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			FSoftClassPath result = new FSoftClassPath(UKismetSystemLibrary.__MakeSoftClassPath_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x000F2626 File Offset: 0x000F0826
		[NullableContext(1)]
		public static FText MakeLiteralText(FText Value)
		{
			return new FText(UKismetSystemLibrary.__MakeLiteralText_Internal((Value != null) ? Value.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x000F2644 File Offset: 0x000F0844
		[NullableContext(1)]
		public unsafe static string MakeLiteralString(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__MakeLiteralString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC00 RID: 44032
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName MakeLiteralName(FName Value);

		// Token: 0x0600AC01 RID: 44033
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int MakeLiteralInt(int Value);

		// Token: 0x0600AC02 RID: 44034
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MakeLiteralFloat(float Value);

		// Token: 0x0600AC03 RID: 44035
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double MakeLiteralDouble(double Value);

		// Token: 0x0600AC04 RID: 44036
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte MakeLiteralByte(byte Value);

		// Token: 0x0600AC05 RID: 44037
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool MakeLiteralBool(bool Value);

		// Token: 0x0600AC06 RID: 44038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadInterstitialAd(int AdIdIndex);

		// Token: 0x0600AC07 RID: 44039 RVA: 0x000F266D File Offset: 0x000F086D
		[NullableContext(1)]
		public static UClassStackOnlyPtr LoadClassAsset_Blocking(TSoftClassPtr<UObject> AssetClass)
		{
			return UKismetSystemLibrary.__LoadClassAsset_Blocking_Internal((AssetClass ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600AC08 RID: 44040 RVA: 0x000F2688 File Offset: 0x000F0888
		public static void LoadAssetClass(UObject WorldContextObject, [Nullable(1)] TSoftClassPtr<UObject> AssetClass, FOnAssetClassLoaded OnLoaded, FLatentActionInfo LatentInfo)
		{
			UKismetSystemLibrary.__LoadAssetClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AssetClass ?? new TSoftClassPtr<UObject>()).NativePtr, (OnLoaded != null) ? OnLoaded.NativePtr : ((IntPtr)0), (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x000F26D5 File Offset: 0x000F08D5
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__LoadAsset_Blocking_Internal((Asset ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x000F26F0 File Offset: 0x000F08F0
		public static void LoadAsset(UObject WorldContextObject, [Nullable(1)] TSoftObjectPtr<UObject> Asset, FOnAssetLoaded OnLoaded, FLatentActionInfo LatentInfo)
		{
			UKismetSystemLibrary.__LoadAsset_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Asset ?? new TSoftObjectPtr<UObject>()).NativePtr, (OnLoaded != null) ? OnLoaded.NativePtr : ((IntPtr)0), (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x000F2740 File Offset: 0x000F0940
		public static bool LineTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceSingleForObjects_Internal(worldContextObject, Start, End, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x000F2840 File Offset: 0x000F0A40
		public static bool LineTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceSingleByProfile_Internal(worldContextObject, Start, End, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x000F2930 File Offset: 0x000F0B30
		public static bool LineTraceSingle(UObject WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceSingle_Internal(worldContextObject, Start, End, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x000F2A24 File Offset: 0x000F0C24
		public static bool LineTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceMultiForObjects_Internal(worldContextObject, Start, End, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x000F2B24 File Offset: 0x000F0D24
		public static bool LineTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceMultiByProfile_Internal(worldContextObject, Start, End, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x000F2C14 File Offset: 0x000F0E14
		public static bool LineTraceMulti(UObject WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__LineTraceMulti_Internal(worldContextObject, Start, End, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x000F2D08 File Offset: 0x000F0F08
		[NullableContext(1)]
		public unsafe static void LaunchURL(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			UKismetSystemLibrary.__LaunchURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x000F2D2C File Offset: 0x000F0F2C
		public static void K2_UnPauseTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			UKismetSystemLibrary.__K2_UnPauseTimerHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x000F2D52 File Offset: 0x000F0F52
		public static void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_UnPauseTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x000F2D68 File Offset: 0x000F0F68
		[NullableContext(1)]
		public unsafe static void K2_UnPauseTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_UnPauseTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x000F2D9C File Offset: 0x000F0F9C
		public static bool K2_TimerExistsHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_TimerExistsHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC16 RID: 44054 RVA: 0x000F2DC2 File Offset: 0x000F0FC2
		public static bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_TimerExistsDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC17 RID: 44055 RVA: 0x000F2DD8 File Offset: 0x000F0FD8
		[NullableContext(1)]
		public unsafe static bool K2_TimerExists([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_TimerExists_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC18 RID: 44056 RVA: 0x000F2E0C File Offset: 0x000F100C
		[NullableContext(1)]
		public static FTimerHandle K2_SetTimerDelegate([Nullable(2)] FTimerDynamicDelegate Delegate, float Time, bool bLooping, float InitialStartDelay = 0f, float InitialStartDelayVariance = 0f)
		{
			return new FTimerHandle(UKismetSystemLibrary.__K2_SetTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0), Time, bLooping, InitialStartDelay, InitialStartDelayVariance), null);
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x000F2E2C File Offset: 0x000F102C
		[NullableContext(1)]
		public unsafe static FTimerHandle K2_SetTimer([Nullable(2)] UObject Object, string FunctionName, float Time, bool bLooping, float InitialStartDelay = 0f, float InitialStartDelayVariance = 0f)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			FTimerHandle result = new FTimerHandle(UKismetSystemLibrary.__K2_SetTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring, Time, bLooping, InitialStartDelay, InitialStartDelayVariance), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x000F2E6C File Offset: 0x000F106C
		public static void K2_PauseTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			UKismetSystemLibrary.__K2_PauseTimerHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x000F2E92 File Offset: 0x000F1092
		public static void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_PauseTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x000F2EA8 File Offset: 0x000F10A8
		[NullableContext(1)]
		public unsafe static void K2_PauseTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_PauseTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC1D RID: 44061 RVA: 0x000F2EDC File Offset: 0x000F10DC
		public static bool K2_IsValidTimerHandle(FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_IsValidTimerHandle_Internal((Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x000F2EF2 File Offset: 0x000F10F2
		public static bool K2_IsTimerPausedHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_IsTimerPausedHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x000F2F18 File Offset: 0x000F1118
		public static bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_IsTimerPausedDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x000F2F2C File Offset: 0x000F112C
		[NullableContext(1)]
		public unsafe static bool K2_IsTimerPaused([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_IsTimerPaused_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x000F2F60 File Offset: 0x000F1160
		public static bool K2_IsTimerActiveHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_IsTimerActiveHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x000F2F86 File Offset: 0x000F1186
		public static bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_IsTimerActiveDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x000F2F9C File Offset: 0x000F119C
		[NullableContext(1)]
		public unsafe static bool K2_IsTimerActive([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_IsTimerActive_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x000F2FD0 File Offset: 0x000F11D0
		[NullableContext(1)]
		public static FTimerHandle K2_InvalidateTimerHandle([Nullable(2)] ref FTimerHandle Handle)
		{
			return new FTimerHandle(UKismetSystemLibrary.__K2_InvalidateTimerHandle_Internal((Handle ?? new FTimerHandle()).NativePtr), null);
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x000F2FED File Offset: 0x000F11ED
		public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_GetTimerRemainingTimeHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x000F3013 File Offset: 0x000F1213
		public static float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_GetTimerRemainingTimeDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x000F3028 File Offset: 0x000F1228
		[NullableContext(1)]
		public unsafe static float K2_GetTimerRemainingTime([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			float result = UKismetSystemLibrary.__K2_GetTimerRemainingTime_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x000F305C File Offset: 0x000F125C
		public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			return UKismetSystemLibrary.__K2_GetTimerElapsedTimeHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x000F3082 File Offset: 0x000F1282
		public static float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_GetTimerElapsedTimeDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x000F3098 File Offset: 0x000F1298
		[NullableContext(1)]
		public unsafe static float K2_GetTimerElapsedTime([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			float result = UKismetSystemLibrary.__K2_GetTimerElapsedTime_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x000F30CC File Offset: 0x000F12CC
		public static void K2_ClearTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			UKismetSystemLibrary.__K2_ClearTimerHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x000F30F2 File Offset: 0x000F12F2
		public static void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_ClearTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AC2D RID: 44077 RVA: 0x000F3108 File Offset: 0x000F1308
		[NullableContext(1)]
		public unsafe static void K2_ClearTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_ClearTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC2E RID: 44078 RVA: 0x000F313C File Offset: 0x000F133C
		public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject, ref FTimerHandle Handle)
		{
			UKismetSystemLibrary.__K2_ClearAndInvalidateTimerHandle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Handle ?? new FTimerHandle()).NativePtr);
		}

		// Token: 0x0600AC2F RID: 44079
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsVulkanAutoDetectMode();

		// Token: 0x0600AC30 RID: 44080 RVA: 0x000F3163 File Offset: 0x000F1363
		[NullableContext(1)]
		public static bool IsValidSoftObjectReference(in TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return UKismetSystemLibrary.__IsValidSoftObjectReference_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x000F317A File Offset: 0x000F137A
		[NullableContext(1)]
		public static bool IsValidSoftClassReference(in TSoftClassPtr<UObject> SoftClassReference)
		{
			return UKismetSystemLibrary.__IsValidSoftClassReference_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x000F3191 File Offset: 0x000F1391
		public static bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType)
		{
			return UKismetSystemLibrary.__IsValidPrimaryAssetType_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x000F31A7 File Offset: 0x000F13A7
		public static bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return UKismetSystemLibrary.__IsValidPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x0600AC34 RID: 44084
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidClass(UClassStackOnlyPtr Class);

		// Token: 0x0600AC35 RID: 44085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUnattended();

		// Token: 0x0600AC36 RID: 44086 RVA: 0x000F31BD File Offset: 0x000F13BD
		public static bool IsStandalone(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsStandalone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x000F31D4 File Offset: 0x000F13D4
		public static bool IsSplitScreen(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsSplitScreen_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x000F31EB File Offset: 0x000F13EB
		public static bool IsServer(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsServer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC39 RID: 44089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsScreensaverEnabled();

		// Token: 0x0600AC3A RID: 44090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPackagedForDistribution();

		// Token: 0x0600AC3B RID: 44091 RVA: 0x000F3202 File Offset: 0x000F1402
		public static bool IsLoggedIn(APlayerController SpecificPlayer)
		{
			return UKismetSystemLibrary.__IsLoggedIn_Internal((SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC3C RID: 44092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInterstitialAdRequested();

		// Token: 0x0600AC3D RID: 44093
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInterstitialAdAvailable();

		// Token: 0x0600AC3E RID: 44094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsGamepadAttached();

		// Token: 0x0600AC3F RID: 44095 RVA: 0x000F3219 File Offset: 0x000F1419
		public static bool IsDedicatedServer(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsDedicatedServer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC40 RID: 44096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsControllerAssignedToGamepad(int ControllerId);

		// Token: 0x0600AC41 RID: 44097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HideAdBanner();

		// Token: 0x0600AC42 RID: 44098 RVA: 0x000F3230 File Offset: 0x000F1430
		[NullableContext(1)]
		public static TArray<string> GetVulkanBlockedModels()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetVulkanBlockedModels_Internal(), null);
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x000F323D File Offset: 0x000F143D
		[NullableContext(1)]
		public static TArray<string> GetVulkanAllowedModels()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetVulkanAllowedModels_Internal(), null);
		}

		// Token: 0x0600AC44 RID: 44100
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetVolumeButtonsHandledBySystem();

		// Token: 0x0600AC45 RID: 44101 RVA: 0x000F324A File Offset: 0x000F144A
		[NullableContext(1)]
		public static string GetUniqueDeviceId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetUniqueDeviceId_Internal());
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x000F3256 File Offset: 0x000F1456
		[NullableContext(1)]
		public static string GetSystemPath([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetSystemPath_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x000F3272 File Offset: 0x000F1472
		public static bool GetSupportedFullscreenResolutions(ref TArray<FIntPoint> Resolutions)
		{
			return UKismetSystemLibrary.__GetSupportedFullscreenResolutions_Internal((Resolutions ?? new TArray<FIntPoint>()).NativePtr);
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x000F3289 File Offset: 0x000F1489
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__GetSoftObjectReferenceFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr), true, true);
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x000F32A6 File Offset: 0x000F14A6
		[NullableContext(1)]
		public static TSoftClassPtr<UObject> GetSoftClassReferenceFromPrimaryAssetId([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__GetSoftClassReferenceFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr), null);
		}

		// Token: 0x0600AC4A RID: 44106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRenderingMaterialQualityLevel();

		// Token: 0x0600AC4B RID: 44107
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRenderingDetailMode();

		// Token: 0x0600AC4C RID: 44108 RVA: 0x000F32C2 File Offset: 0x000F14C2
		[NullableContext(1)]
		public static string GetProjectSavedDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectSavedDirectory_Internal());
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x000F32CE File Offset: 0x000F14CE
		[NullableContext(1)]
		public static string GetProjectDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectDirectory_Internal());
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x000F32DA File Offset: 0x000F14DA
		[NullableContext(1)]
		public static string GetProjectContentDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectContentDirectory_Internal());
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x000F32E8 File Offset: 0x000F14E8
		public static void GetPrimaryAssetsWithBundleState(in TArray<FName> RequiredBundles, in TArray<FName> ExcludedBundles, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetType> ValidTypes, bool bForceCurrentState, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPrimaryAssetId> OutPrimaryAssetIdList)
		{
			UKismetSystemLibrary.__GetPrimaryAssetsWithBundleState_Internal((RequiredBundles ?? new TArray<FName>()).NativePtr, (ExcludedBundles ?? new TArray<FName>()).NativePtr, (ValidTypes ?? new TArray<FPrimaryAssetType>()).NativePtr, bForceCurrentState, (OutPrimaryAssetIdList ?? new TArray<FPrimaryAssetId>()).NativePtr);
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x000F333C File Offset: 0x000F153C
		public static void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPrimaryAssetId> OutPrimaryAssetIdList)
		{
			UKismetSystemLibrary.__GetPrimaryAssetIdList_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr, (OutPrimaryAssetIdList ?? new TArray<FPrimaryAssetId>()).NativePtr);
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x000F3362 File Offset: 0x000F1562
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromSoftObjectReference_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr), null);
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x000F337E File Offset: 0x000F157E
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftClassPtr<UObject> SoftClassReference)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromSoftClassReference_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr), null);
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x000F339A File Offset: 0x000F159A
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromObject([Nullable(2)] UObject Object)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x000F33B7 File Offset: 0x000F15B7
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromClass(UClassStackOnlyPtr Class)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromClass_Internal(Class._NativePtr), null);
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x000F33CA File Offset: 0x000F15CA
		[NullableContext(1)]
		public static TArray<string> GetPreferredLanguages()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetPreferredLanguages_Internal(), null);
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x000F33D7 File Offset: 0x000F15D7
		[NullableContext(1)]
		public static string GetPlatformUserName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPlatformUserName_Internal());
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x000F33E3 File Offset: 0x000F15E3
		[NullableContext(1)]
		public static string GetPlatformUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPlatformUserDir_Internal());
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x000F33EF File Offset: 0x000F15EF
		[NullableContext(1)]
		public static string GetPathName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPathName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x000F340B File Offset: 0x000F160B
		public static UObject GetOuterObject(UObject Object)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__GetOuterObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x000F3427 File Offset: 0x000F1627
		[NullableContext(1)]
		public static string GetObjectName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetObjectName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x000F3443 File Offset: 0x000F1643
		public static UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__GetObjectFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr));
		}

		// Token: 0x0600AC5C RID: 44124
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMinYResolutionForUI();

		// Token: 0x0600AC5D RID: 44125
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMinYResolutionFor3DView();

		// Token: 0x0600AC5E RID: 44126 RVA: 0x000F345E File Offset: 0x000F165E
		[NullableContext(1)]
		public static string GetLocalCurrencySymbol()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetLocalCurrencySymbol_Internal());
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x000F346A File Offset: 0x000F166A
		[NullableContext(1)]
		public static string GetLocalCurrencyCode()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetLocalCurrencyCode_Internal());
		}

		// Token: 0x0600AC60 RID: 44128 RVA: 0x000F3476 File Offset: 0x000F1676
		public static float GetGameTimeInSeconds(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__GetGameTimeInSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x000F348D File Offset: 0x000F168D
		[NullableContext(1)]
		public static string GetGamepadControllerName(int ControllerId)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGamepadControllerName_Internal(ControllerId));
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x000F349C File Offset: 0x000F169C
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UTexture2D GetGamepadButtonGlyph(string ButtonKey, int ControllerIndex)
		{
			FString fstring = FString.AllocTemp(ButtonKey);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetSystemLibrary.__GetGamepadButtonGlyph_Internal(fstring, ControllerIndex));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x000F34C6 File Offset: 0x000F16C6
		[NullableContext(1)]
		public static string GetGameName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGameName_Internal());
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x000F34D2 File Offset: 0x000F16D2
		[NullableContext(1)]
		public static string GetGameBundleId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGameBundleId_Internal());
		}

		// Token: 0x0600AC65 RID: 44133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetFrameCount();

		// Token: 0x0600AC66 RID: 44134 RVA: 0x000F34DE File Offset: 0x000F16DE
		[NullableContext(1)]
		public static string GetEngineVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetEngineVersion_Internal());
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x000F34EA File Offset: 0x000F16EA
		[NullableContext(1)]
		public static string GetDisplayName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDisplayName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x000F3506 File Offset: 0x000F1706
		[NullableContext(1)]
		public static string GetDeviceId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDeviceId_Internal());
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x000F3512 File Offset: 0x000F1712
		[NullableContext(1)]
		public static string GetDefaultLocale()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDefaultLocale_Internal());
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x000F351E File Offset: 0x000F171E
		[NullableContext(1)]
		public static string GetDefaultLanguage()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDefaultLanguage_Internal());
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x000F352A File Offset: 0x000F172A
		public static bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId, bool bForceCurrentState, ref TArray<FName> OutBundles)
		{
			return UKismetSystemLibrary.__GetCurrentBundleState_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr, bForceCurrentState, (OutBundles ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x000F3551 File Offset: 0x000F1751
		[NullableContext(1)]
		public static string GetCurrentActiveGamepadName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetCurrentActiveGamepadName_Internal());
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x000F355D File Offset: 0x000F175D
		public static bool GetConvenientWindowedResolutions(ref TArray<FIntPoint> Resolutions)
		{
			return UKismetSystemLibrary.__GetConvenientWindowedResolutions_Internal((Resolutions ?? new TArray<FIntPoint>()).NativePtr);
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x000F3574 File Offset: 0x000F1774
		[NullableContext(1)]
		public unsafe static int GetConsoleVariableIntValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			int result = UKismetSystemLibrary.__GetConsoleVariableIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x000F3598 File Offset: 0x000F1798
		[NullableContext(1)]
		public unsafe static float GetConsoleVariableFloatValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			float result = UKismetSystemLibrary.__GetConsoleVariableFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x000F35BC File Offset: 0x000F17BC
		[NullableContext(1)]
		public unsafe static bool GetConsoleVariableBoolValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			bool result = UKismetSystemLibrary.__GetConsoleVariableBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x000F35E0 File Offset: 0x000F17E0
		public unsafe static void GetComponentBounds(USceneComponent Component, ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius)
		{
			fixed (FVector* ptr = &Origin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoxExtent)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &SphereRadius)
					{
						void* ptr6 = (void*)ptr5;
						UKismetSystemLibrary.__GetComponentBounds_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, ref Origin, ref BoxExtent, ref SphereRadius);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x000F3623 File Offset: 0x000F1823
		[NullableContext(1)]
		public static string GetCommandLine()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetCommandLine_Internal());
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x000F362F File Offset: 0x000F182F
		public static UClassStackOnlyPtr GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return UKismetSystemLibrary.__GetClassFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x000F364A File Offset: 0x000F184A
		[NullableContext(1)]
		public static string GetClassDisplayName(UClassStackOnlyPtr Class)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetClassDisplayName_Internal(Class._NativePtr));
		}

		// Token: 0x0600AC75 RID: 44149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAdIDCount();

		// Token: 0x0600AC76 RID: 44150 RVA: 0x000F365C File Offset: 0x000F185C
		public static void GetActorListFromComponentList([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UPrimitiveComponent> ComponentList, UClassStackOnlyPtr ActorClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActorList)
		{
			UKismetSystemLibrary.__GetActorListFromComponentList_Internal((ComponentList ?? new TArray<UPrimitiveComponent>()).NativePtr, ActorClassFilter._NativePtr, (OutActorList ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x000F368C File Offset: 0x000F188C
		public unsafe static void GetActorBounds(AActor Actor, ref FVector Origin, ref FVector BoxExtent)
		{
			fixed (FVector* ptr = &Origin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoxExtent)
				{
					void* ptr4 = (void*)ptr3;
					UKismetSystemLibrary.__GetActorBounds_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref Origin, ref BoxExtent);
					ptr = null;
				}
			}
		}

		// Token: 0x0600AC78 RID: 44152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCloseAdBanner();

		// Token: 0x0600AC79 RID: 44153 RVA: 0x000F36C0 File Offset: 0x000F18C0
		public static void FlushPersistentDebugLines(UObject WorldContextObject)
		{
			UKismetSystemLibrary.__FlushPersistentDebugLines_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x000F36D7 File Offset: 0x000F18D7
		public static void FlushDebugStrings(UObject WorldContextObject)
		{
			UKismetSystemLibrary.__FlushDebugStrings_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x000F36F0 File Offset: 0x000F18F0
		public unsafe static void ExecuteConsoleCommandFromUserInput(UObject WorldContextObject, [Nullable(1)] string Command, APlayerController SpecificPlayer = null)
		{
			FString fstring = FString.AllocTemp(Command);
			UKismetSystemLibrary.__ExecuteConsoleCommandFromUserInput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x000F3734 File Offset: 0x000F1934
		public unsafe static void ExecuteConsoleCommand(UObject WorldContextObject, [Nullable(1)] string Command, APlayerController SpecificPlayer = null)
		{
			FString fstring = FString.AllocTemp(Command);
			UKismetSystemLibrary.__ExecuteConsoleCommand_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x000F3778 File Offset: 0x000F1978
		[NullableContext(1)]
		public static bool EqualEqual_SoftObjectReference(in TSoftObjectPtr<UObject> A, in TSoftObjectPtr<UObject> B)
		{
			return UKismetSystemLibrary.__EqualEqual_SoftObjectReference_Internal((A ?? new TSoftObjectPtr<UObject>()).NativePtr, (B ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x000F379F File Offset: 0x000F199F
		[NullableContext(1)]
		public static bool EqualEqual_SoftClassReference(in TSoftClassPtr<UObject> A, in TSoftClassPtr<UObject> B)
		{
			return UKismetSystemLibrary.__EqualEqual_SoftClassReference_Internal((A ?? new TSoftClassPtr<UObject>()).NativePtr, (B ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x000F37C6 File Offset: 0x000F19C6
		public static bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			return UKismetSystemLibrary.__EqualEqual_PrimaryAssetType_Internal((A ?? new FPrimaryAssetType()).NativePtr, (B ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x000F37EB File Offset: 0x000F19EB
		public static bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			return UKismetSystemLibrary.__EqualEqual_PrimaryAssetId_Internal((A ?? new FPrimaryAssetId()).NativePtr, (B ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x0600AC81 RID: 44161
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int EndTransaction();

		// Token: 0x0600AC82 RID: 44162 RVA: 0x000F3810 File Offset: 0x000F1A10
		[NullableContext(1)]
		public unsafe static void DynamicQueueSubtitles([Nullable(2)] UObject WorldContextObject, string InString = "Hello", float Duration = 2f, int FontSize = 18)
		{
			FString fstring = FString.AllocTemp(InString);
			UKismetSystemLibrary.__DynamicQueueSubtitles_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Duration, FontSize);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x000F3848 File Offset: 0x000F1A48
		public unsafe static void DrawDebugString(UObject WorldContextObject, FVector TextLocation, [Nullable(1)] string Text, AActor TestBaseActor = null, FLinearColor? TextColor = null, float Duration = 0f)
		{
			FString fstring = FString.AllocTemp(Text);
			UKismetSystemLibrary.__DrawDebugString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TextLocation, fstring, (TestBaseActor != null) ? TestBaseActor.NativePtr : IntPtr.Zero, TextColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x000F38DC File Offset: 0x000F1ADC
		public static void DrawDebugSphere(UObject WorldContextObject, FVector Center, float Radius = 100f, int Segments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugSphere_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Radius, Segments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x000F3952 File Offset: 0x000F1B52
		public static void DrawDebugPoint(UObject WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration = 0f)
		{
			UKismetSystemLibrary.__DrawDebugPoint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position, Size, PointColor, Duration);
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x000F3970 File Offset: 0x000F1B70
		public unsafe static void DrawDebugPlane(UObject WorldContextObject, in FPlane PlaneCoordinates, FVector Location, float Size, FLinearColor? PlaneColor = null, float Duration = 0f)
		{
			ref FPlane ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = PlaneCoordinates;
			UKismetSystemLibrary.__DrawDebugPlane_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr, Location, Size, PlaneColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x000F3A00 File Offset: 0x000F1C00
		public static void DrawDebugLine(UObject WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugLine_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, LineColor, Duration, Thickness);
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x000F3A20 File Offset: 0x000F1C20
		public unsafe static void DrawDebugFrustum(UObject WorldContextObject, in FTransform FrustumTransform, FLinearColor? FrustumColor = null, float Duration = 0f, float Thickness = 0f)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = FrustumTransform;
			UKismetSystemLibrary.__DrawDebugFrustum_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr, FrustumColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x000F3AB0 File Offset: 0x000F1CB0
		public unsafe static void DrawDebugFloatHistoryTransform(UObject WorldContextObject, in FDebugFloatHistory FloatHistory, in FTransform DrawTransform, FVector2D DrawSize, FLinearColor? DrawColor = null, float Duration = 0f)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DrawTransform;
			UKismetSystemLibrary.__DrawDebugFloatHistoryTransform_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FloatHistory ?? new FDebugFloatHistory()).NativePtr, ptr, DrawSize, DrawColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x000F3B50 File Offset: 0x000F1D50
		public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject, in FDebugFloatHistory FloatHistory, FVector DrawLocation, FVector2D DrawSize, FLinearColor? DrawColor = null, float Duration = 0f)
		{
			UKismetSystemLibrary.__DrawDebugFloatHistoryLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FloatHistory ?? new FDebugFloatHistory()).NativePtr, DrawLocation, DrawSize, DrawColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x000F3BD4 File Offset: 0x000F1DD4
		public static void DrawDebugCylinder(UObject WorldContextObject, FVector Start, FVector End, float Radius = 100f, int Segments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCylinder_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Start, End, Radius, Segments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x000F3C4C File Offset: 0x000F1E4C
		public static void DrawDebugCoordinateSystem(UObject WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale = 1f, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCoordinateSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AxisLoc, AxisRot, Scale, Duration, Thickness);
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x000F3C6C File Offset: 0x000F1E6C
		public static void DrawDebugConeInDegrees(UObject WorldContextObject, FVector Origin, FVector Direction, float Length = 100f, float AngleWidth = 45f, float AngleHeight = 45f, int NumSides = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugConeInDegrees_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600AC8E RID: 44174 RVA: 0x000F3CE8 File Offset: 0x000F1EE8
		public static void DrawDebugCone(UObject WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x000F3D1C File Offset: 0x000F1F1C
		public static void DrawDebugCircle(UObject WorldContextObject, FVector Center, float Radius, int NumSegments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f, FVector? YAxis = null, FVector? ZAxis = null, bool bDrawAxis = false)
		{
			UKismetSystemLibrary.__DrawDebugCircle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Radius, NumSegments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness, YAxis ?? new FVector(0f, 1f, 0f), ZAxis ?? new FVector(0f, 0f, 1f), bDrawAxis);
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x000F3DE8 File Offset: 0x000F1FE8
		public static void DrawDebugCapsule(UObject WorldContextObject, FVector Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCapsule_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, HalfHeight, Radius, Rotation, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x000F3E60 File Offset: 0x000F2060
		public static void DrawDebugCamera(ACameraActor CameraActor, FLinearColor? CameraColor = null, float Duration = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCamera_Internal((CameraActor != null) ? CameraActor.NativePtr : IntPtr.Zero, CameraColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x000F3ECF File Offset: 0x000F20CF
		public static void DrawDebugBox(UObject WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation = default(FRotator), float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugBox_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Extent, LineColor, Rotation, Duration, Thickness);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x000F3EEF File Offset: 0x000F20EF
		public static void DrawDebugArrow(UObject WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugArrow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x000F3F0F File Offset: 0x000F210F
		public static bool DoesImplementInterface(UObject TestObject, UClassStackOnlyPtr Interface)
		{
			return UKismetSystemLibrary.__DoesImplementInterface_Internal((TestObject != null) ? TestObject.NativePtr : IntPtr.Zero, Interface._NativePtr);
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x000F3F2C File Offset: 0x000F212C
		public static void Delay(UObject WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
		{
			UKismetSystemLibrary.__Delay_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Duration, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x000F3F54 File Offset: 0x000F2154
		public static bool D_SphereTraceSingleForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceSingleForObjects_Internal(worldContextObject, Start, End, Radius, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x000F4054 File Offset: 0x000F2254
		public static bool D_SphereTraceSingleByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceSingleByProfile_Internal(worldContextObject, Start, End, Radius, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x000F4144 File Offset: 0x000F2344
		public static bool D_SphereTraceSingle(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceSingle_Internal(worldContextObject, Start, End, Radius, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x000F423C File Offset: 0x000F243C
		public static bool D_SphereTraceMultiForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceMultiForObjects_Internal(worldContextObject, Start, End, Radius, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x000F433C File Offset: 0x000F253C
		public static bool D_SphereTraceMultiByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceMultiByProfile_Internal(worldContextObject, Start, End, Radius, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x000F442C File Offset: 0x000F262C
		public static bool D_SphereTraceMulti(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_SphereTraceMulti_Internal(worldContextObject, Start, End, Radius, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x000F4524 File Offset: 0x000F2724
		public static bool D_LineTraceSingleForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceSingleForObjects_Internal(worldContextObject, Start, End, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x000F4624 File Offset: 0x000F2824
		public static bool D_LineTraceSingleByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceSingleByProfile_Internal(worldContextObject, Start, End, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x000F4714 File Offset: 0x000F2914
		public static bool D_LineTraceSingle(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceSingle_Internal(worldContextObject, Start, End, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x000F4808 File Offset: 0x000F2A08
		public static bool D_LineTraceMultiForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceMultiForObjects_Internal(worldContextObject, Start, End, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x000F4908 File Offset: 0x000F2B08
		public static bool D_LineTraceMultiByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceMultiByProfile_Internal(worldContextObject, Start, End, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x000F49F8 File Offset: 0x000F2BF8
		public static bool D_LineTraceMulti(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_LineTraceMulti_Internal(worldContextObject, Start, End, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x000F4AEC File Offset: 0x000F2CEC
		public unsafe static void D_DrawDebugString(UObject WorldContextObject, FVectorDouble TextLocation, [Nullable(1)] string Text, AActor TestBaseActor = null, FLinearColor? TextColor = null, float Duration = 0f)
		{
			FString fstring = FString.AllocTemp(Text);
			UKismetSystemLibrary.__D_DrawDebugString_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TextLocation, fstring, (TestBaseActor != null) ? TestBaseActor.NativePtr : IntPtr.Zero, TextColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x000F4B80 File Offset: 0x000F2D80
		public static void D_DrawDebugSphere(UObject WorldContextObject, FVectorDouble Center, float Radius = 100f, int Segments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugSphere_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Radius, Segments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x000F4BF6 File Offset: 0x000F2DF6
		public static void D_DrawDebugPoint(UObject WorldContextObject, FVectorDouble Position, float Size, FLinearColor PointColor, float Duration = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugPoint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position, Size, PointColor, Duration);
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x000F4C14 File Offset: 0x000F2E14
		public unsafe static void D_DrawDebugPlane(UObject WorldContextObject, in FPlane PlaneCoordinates, FVectorDouble Location, float Size, FLinearColor? PlaneColor = null, float Duration = 0f)
		{
			ref FPlane ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = PlaneCoordinates;
			UKismetSystemLibrary.__D_DrawDebugPlane_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr, Location, Size, PlaneColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
		public static void D_DrawDebugLine(UObject WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugLine_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, LineColor, Duration, Thickness);
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x000F4CC4 File Offset: 0x000F2EC4
		public static void D_DrawDebugCylinder(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius = 100f, int Segments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCylinder_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Start, End, Radius, Segments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x000F4D3C File Offset: 0x000F2F3C
		public static void D_DrawDebugCoordinateSystem(UObject WorldContextObject, FVectorDouble AxisLoc, FRotator AxisRot, float Scale = 1f, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCoordinateSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AxisLoc, AxisRot, Scale, Duration, Thickness);
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x000F4D5C File Offset: 0x000F2F5C
		public static void D_DrawDebugConeInDegrees(UObject WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length = 100f, float AngleWidth = 45f, float AngleHeight = 45f, int NumSides = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugConeInDegrees_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x000F4DD8 File Offset: 0x000F2FD8
		public static void D_DrawDebugCone(UObject WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x000F4E0C File Offset: 0x000F300C
		public static void D_DrawDebugCircle(UObject WorldContextObject, FVectorDouble Center, float Radius, int NumSegments = 12, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f, FVectorDouble? YAxis = null, FVectorDouble? ZAxis = null, bool bDrawAxis = false)
		{
			UKismetSystemLibrary.__D_DrawDebugCircle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Radius, NumSegments, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness, YAxis ?? new FVectorDouble(0.0, 1.0, 0.0), ZAxis ?? new FVectorDouble(0.0, 0.0, 1.0), bDrawAxis);
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x000F4EF0 File Offset: 0x000F30F0
		public static void D_DrawDebugCapsule(UObject WorldContextObject, FVectorDouble Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor? LineColor = null, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCapsule_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, HalfHeight, Radius, Rotation, LineColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration, Thickness);
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x000F4F68 File Offset: 0x000F3168
		public static void D_DrawDebugBox(UObject WorldContextObject, FVectorDouble Center, FVectorDouble Extent, FLinearColor LineColor, FRotator Rotation = default(FRotator), float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugBox_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Extent, LineColor, Rotation, Duration, Thickness);
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x000F4F88 File Offset: 0x000F3188
		public static void D_DrawDebugArrow(UObject WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugArrow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x000F4FA8 File Offset: 0x000F31A8
		public static bool D_CapsuleTraceSingleForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceSingleForObjects_Internal(worldContextObject, Start, End, Radius, HalfHeight, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x000F50AC File Offset: 0x000F32AC
		public static bool D_CapsuleTraceSingleByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceSingleByProfile_Internal(worldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x000F51A0 File Offset: 0x000F33A0
		public static bool D_CapsuleTraceSingle(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceSingle_Internal(worldContextObject, Start, End, Radius, HalfHeight, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x000F5298 File Offset: 0x000F3498
		public static bool D_CapsuleTraceMultiForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceMultiForObjects_Internal(worldContextObject, Start, End, Radius, HalfHeight, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x000F539C File Offset: 0x000F359C
		public static bool D_CapsuleTraceMultiByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceMultiByProfile_Internal(worldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x000F5490 File Offset: 0x000F3690
		public static bool D_CapsuleTraceMulti(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_CapsuleTraceMulti_Internal(worldContextObject, Start, End, Radius, HalfHeight, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x000F5588 File Offset: 0x000F3788
		public static bool D_BoxTraceSingleForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceSingleForObjects_Internal(worldContextObject, Start, End, HalfSize, Orientation, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x000F568C File Offset: 0x000F388C
		public static bool D_BoxTraceSingleByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceSingleByProfile_Internal(worldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x000F5780 File Offset: 0x000F3980
		public static bool D_BoxTraceSingle(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceSingle_Internal(worldContextObject, Start, End, HalfSize, Orientation, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x000F5878 File Offset: 0x000F3A78
		public static bool D_BoxTraceMultiForObjects(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceMultiForObjects_Internal(worldContextObject, Start, End, HalfSize, Orientation, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x000F597C File Offset: 0x000F3B7C
		public static bool D_BoxTraceMultiByProfile(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceMultiByProfile_Internal(worldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x000F5A70 File Offset: 0x000F3C70
		public static bool D_BoxTraceMulti(UObject WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__D_BoxTraceMulti_Internal(worldContextObject, Start, End, HalfSize, Orientation, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x000F5B67 File Offset: 0x000F3D67
		public static void CreateCopyForUndoBuffer(UObject ObjectToModify)
		{
			UKismetSystemLibrary.__CreateCopyForUndoBuffer_Internal((ObjectToModify != null) ? ObjectToModify.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x000F5B80 File Offset: 0x000F3D80
		[NullableContext(1)]
		public unsafe static string ConvertToRelativePath(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__ConvertToRelativePath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x000F5BAC File Offset: 0x000F3DAC
		[NullableContext(1)]
		public unsafe static string ConvertToAbsolutePath(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__ConvertToAbsolutePath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x000F5BD5 File Offset: 0x000F3DD5
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef([Nullable(2)] in FSoftObjectPath SoftObjectPath)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__Conv_SoftObjPathToSoftObjRef_Internal((SoftObjectPath ?? new FSoftObjectPath()).NativePtr), true, true);
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x000F5BF3 File Offset: 0x000F3DF3
		[NullableContext(1)]
		public static string Conv_SoftObjectReferenceToString(in TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_SoftObjectReferenceToString_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x000F5C0F File Offset: 0x000F3E0F
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UObject Conv_SoftObjectReferenceToObject(in TSoftObjectPtr<UObject> SoftObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__Conv_SoftObjectReferenceToObject_Internal((SoftObject ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x000F5C2B File Offset: 0x000F3E2B
		[NullableContext(1)]
		public static string Conv_SoftClassReferenceToString(in TSoftClassPtr<UObject> SoftClassReference)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_SoftClassReferenceToString_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr));
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x000F5C47 File Offset: 0x000F3E47
		[NullableContext(1)]
		public static UClassStackOnlyPtr Conv_SoftClassReferenceToClass(in TSoftClassPtr<UObject> SoftClass)
		{
			return UKismetSystemLibrary.__Conv_SoftClassReferenceToClass_Internal((SoftClass ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x000F5C63 File Offset: 0x000F3E63
		[NullableContext(1)]
		public static TSoftClassPtr<UObject> Conv_SoftClassPathToSoftClassRef([Nullable(2)] in FSoftClassPath SoftClassPath)
		{
			return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__Conv_SoftClassPathToSoftClassRef_Internal((SoftClassPath ?? new FSoftClassPath()).NativePtr), null);
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x000F5C80 File Offset: 0x000F3E80
		[NullableContext(1)]
		public static string Conv_PrimaryAssetTypeToString([Nullable(2)] FPrimaryAssetType PrimaryAssetType)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_PrimaryAssetTypeToString_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr));
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x000F5C9B File Offset: 0x000F3E9B
		[NullableContext(1)]
		public static string Conv_PrimaryAssetIdToString([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_PrimaryAssetIdToString_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr));
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x000F5CB6 File Offset: 0x000F3EB6
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference([Nullable(2)] UObject Object)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__Conv_ObjectToSoftObjectReference_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero), true, true);
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x000F5CD4 File Offset: 0x000F3ED4
		public unsafe static UObject Conv_InterfaceToObject(in FScriptInterface Interface)
		{
			fixed (FScriptInterface* ptr = &Interface)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__Conv_InterfaceToObject_Internal(Interface));
			}
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x000F5CF4 File Offset: 0x000F3EF4
		[NullableContext(1)]
		public unsafe static TSoftClassPtr<UObject> Conv_ClassToSoftClassReference(in UClassStackOnlyPtr Class)
		{
			fixed (UClassStackOnlyPtr* ptr = &Class)
			{
				void* ptr2 = (void*)ptr;
				return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__Conv_ClassToSoftClassReference_Internal(Class._NativePtr), null);
			}
		}

		// Token: 0x0600ACC9 RID: 44233
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ControlScreensaver(bool bAllowScreenSaver);

		// Token: 0x0600ACCA RID: 44234 RVA: 0x000F5D18 File Offset: 0x000F3F18
		public unsafe static bool ComponentOverlapComponents(UPrimitiveComponent Component, in FTransform ComponentTransform, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ComponentClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutComponents)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = ComponentTransform;
			return UKismetSystemLibrary.__ComponentOverlapComponents_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, ptr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ComponentClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x000F5D90 File Offset: 0x000F3F90
		public unsafe static bool ComponentOverlapActors(UPrimitiveComponent Component, in FTransform ComponentTransform, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ActorClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = ComponentTransform;
			return UKismetSystemLibrary.__ComponentOverlapActors_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, ptr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ActorClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600ACCC RID: 44236
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CollectGarbage();

		// Token: 0x0600ACCD RID: 44237 RVA: 0x000F5E08 File Offset: 0x000F4008
		public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceSingleForObjects_Internal(worldContextObject, Start, End, Radius, HalfHeight, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x000F5F0C File Offset: 0x000F410C
		public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceSingleByProfile_Internal(worldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x000F6000 File Offset: 0x000F4200
		public static bool CapsuleTraceSingle(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceSingle_Internal(worldContextObject, Start, End, Radius, HalfHeight, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x000F60F8 File Offset: 0x000F42F8
		public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceMultiForObjects_Internal(worldContextObject, Start, End, Radius, HalfHeight, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x000F61FC File Offset: 0x000F43FC
		public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceMultiByProfile_Internal(worldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x000F62F0 File Offset: 0x000F44F0
		public static bool CapsuleTraceMulti(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__CapsuleTraceMulti_Internal(worldContextObject, Start, End, Radius, HalfHeight, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x000F63E8 File Offset: 0x000F45E8
		public static bool CapsuleOverlapComponents(UObject WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ComponentClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutComponents)
		{
			return UKismetSystemLibrary.__CapsuleOverlapComponents_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CapsulePos, Radius, HalfHeight, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ComponentClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x000F6448 File Offset: 0x000F4648
		public static bool CapsuleOverlapActors(UObject WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ActorClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			return UKismetSystemLibrary.__CapsuleOverlapActors_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CapsulePos, Radius, HalfHeight, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ActorClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x000F64A8 File Offset: 0x000F46A8
		[NullableContext(1)]
		public unsafe static bool CanLaunchURL(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			bool result = UKismetSystemLibrary.__CanLaunchURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ACD6 RID: 44246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelTransaction(int Index);

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x000F64CC File Offset: 0x000F46CC
		[NullableContext(1)]
		public unsafe static void BreakTopLevelAssetPath([Nullable(2)] in FTopLevelAssetPath TopLevelAssetPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakTopLevelAssetPath_Internal((TopLevelAssetPath ?? new FTopLevelAssetPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x000F650C File Offset: 0x000F470C
		[NullableContext(1)]
		public unsafe static void BreakSoftObjectPath([Nullable(2)] FSoftObjectPath InSoftObjectPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakSoftObjectPath_Internal((InSoftObjectPath ?? new FSoftObjectPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x000F654C File Offset: 0x000F474C
		[NullableContext(1)]
		public unsafe static void BreakSoftClassPath([Nullable(2)] FSoftClassPath InSoftClassPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakSoftClassPath_Internal((InSoftClassPath ?? new FSoftClassPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x000F658C File Offset: 0x000F478C
		public static bool BoxTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceSingleForObjects_Internal(worldContextObject, Start, End, HalfSize, Orientation, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x000F6690 File Offset: 0x000F4890
		public static bool BoxTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceSingleByProfile_Internal(worldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x000F6784 File Offset: 0x000F4984
		public static bool BoxTraceSingle(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHit ?? new FHitResult()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceSingle_Internal(worldContextObject, Start, End, HalfSize, Orientation, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x000F687C File Offset: 0x000F4A7C
		public static bool BoxTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr;
			IntPtr nativePtr2 = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr3 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceMultiForObjects_Internal(worldContextObject, Start, End, HalfSize, Orientation, nativePtr, bTraceComplex, nativePtr2, drawDebugType, nativePtr3, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x000F6980 File Offset: 0x000F4B80
		public static bool BoxTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceMultiByProfile_Internal(worldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x000F6A74 File Offset: 0x000F4C74
		public static bool BoxTraceMulti(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor? TraceColor = null, FLinearColor? TraceHitColor = null, float DrawTime = 5f)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			TEnumAsByte<ETraceTypeQuery> traceChannel = TraceChannel;
			IntPtr nativePtr = (ActorsToIgnore ?? new TArray<AActor>()).NativePtr;
			TEnumAsByte<EDrawDebugTrace> drawDebugType = DrawDebugType;
			IntPtr nativePtr2 = (OutHits ?? new TArray<FHitResult>()).NativePtr;
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
			return UKismetSystemLibrary.__BoxTraceMulti_Internal(worldContextObject, Start, End, HalfSize, Orientation, traceChannel, bTraceComplex, nativePtr, drawDebugType, nativePtr2, bIgnoreSelf, traceColor, traceHitColor, DrawTime);
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x000F6B6C File Offset: 0x000F4D6C
		public static bool BoxOverlapComponents(UObject WorldContextObject, FVector BoxPos, FVector Extent, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ComponentClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutComponents)
		{
			return UKismetSystemLibrary.__BoxOverlapComponents_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPos, Extent, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ComponentClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x000F6BCC File Offset: 0x000F4DCC
		public static bool BoxOverlapActors(UObject WorldContextObject, FVector BoxPos, FVector BoxExtent, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, UClassStackOnlyPtr ActorClassFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			return UKismetSystemLibrary.__BoxOverlapActors_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPos, BoxExtent, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, ActorClassFilter._NativePtr, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x000F6C2C File Offset: 0x000F4E2C
		[NullableContext(1)]
		public unsafe static int BeginTransaction(string Context, FText Description, [Nullable(2)] UObject PrimaryObject)
		{
			FString fstring = FString.AllocTemp(Context);
			int result = UKismetSystemLibrary.__BeginTransaction_Internal(fstring, (Description != null) ? Description.NativePtr : IntPtr.Zero, (PrimaryObject != null) ? PrimaryObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x000F6C70 File Offset: 0x000F4E70
		[NullableContext(1)]
		public static FDebugFloatHistory AddFloatHistorySample(float Value, [Nullable(2)] in FDebugFloatHistory FloatHistory)
		{
			return new FDebugFloatHistory(UKismetSystemLibrary.__AddFloatHistorySample_Internal(Value, (FloatHistory ?? new FDebugFloatHistory()).NativePtr), null);
		}

		// Token: 0x0600ACE4 RID: 44260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadPrimaryAssetList_Internal(IntPtr PrimaryAssetIdList);

		// Token: 0x0600ACE5 RID: 44261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadPrimaryAsset_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600ACE6 RID: 44262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransactObject_Internal(IntPtr Object);

		// Token: 0x0600ACE7 RID: 44263
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACE8 RID: 44264
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACE9 RID: 44265
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACEA RID: 44266
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACEB RID: 44267
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACEC RID: 44268
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ACED RID: 44269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereOverlapComponents_Internal(IntPtr WorldContextObject, FVector SpherePos, float SphereRadius, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x0600ACEE RID: 44270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereOverlapActors_Internal(IntPtr WorldContextObject, FVector SpherePos, float SphereRadius, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x0600ACEF RID: 44271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapshotObject_Internal(IntPtr Object);

		// Token: 0x0600ACF0 RID: 44272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowPlatformSpecificLeaderboardScreen_Internal(in FString CategoryName);

		// Token: 0x0600ACF1 RID: 44273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowPlatformSpecificAchievementsScreen_Internal(IntPtr SpecificPlayer);

		// Token: 0x0600ACF2 RID: 44274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowTitle_Internal(IntPtr Title);

		// Token: 0x0600ACF3 RID: 44275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FVector Value);

		// Token: 0x0600ACF4 RID: 44276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, in FVectorDouble Value);

		// Token: 0x0600ACF5 RID: 44277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserActivity_Internal(IntPtr UserActivity);

		// Token: 0x0600ACF6 RID: 44278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformPropertyByName_Internal(IntPtr Object, FName PropertyName, in FTransform Value);

		// Token: 0x0600ACF7 RID: 44279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, in FTransformDouble Value);

		// Token: 0x0600ACF8 RID: 44280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x0600ACF9 RID: 44281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSuppressViewportTransitionMessage_Internal(IntPtr WorldContextObject, bool bState);

		// Token: 0x0600ACFA RID: 44282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStringPropertyByName_Internal(IntPtr Object, FName PropertyName, in FString Value);

		// Token: 0x0600ACFB RID: 44283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftObjectPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x0600ACFC RID: 44284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftClassPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x0600ACFD RID: 44285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotatorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FRotator Value);

		// Token: 0x0600ACFE RID: 44286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x0600ACFF RID: 44287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNamePropertyByName_Internal(IntPtr Object, FName PropertyName, in FName Value);

		// Token: 0x0600AD00 RID: 44288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearColorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FLinearColor Value);

		// Token: 0x0600AD01 RID: 44289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntPropertyByName_Internal(IntPtr Object, FName PropertyName, int Value);

		// Token: 0x0600AD02 RID: 44290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInterfacePropertyByName_Internal(IntPtr Object, FName PropertyName, in FScriptInterface Value);

		// Token: 0x0600AD03 RID: 44291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt64PropertyByName_Internal(IntPtr Object, FName PropertyName, long Value);

		// Token: 0x0600AD04 RID: 44292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatPropertyByName_Internal(IntPtr Object, FName PropertyName, float Value);

		// Token: 0x0600AD05 RID: 44293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, double Value);

		// Token: 0x0600AD06 RID: 44294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FColor Value);

		// Token: 0x0600AD07 RID: 44295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClassPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x0600AD08 RID: 44296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBytePropertyByName_Internal(IntPtr Object, FName PropertyName, byte Value);

		// Token: 0x0600AD09 RID: 44297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolPropertyByName_Internal(IntPtr Object, FName PropertyName, bool Value);

		// Token: 0x0600AD0A RID: 44298
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAllChannels_Internal(IntPtr ResponseToChannels, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x0600AD0B RID: 44299
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RHIName_Internal();

		// Token: 0x0600AD0C RID: 44300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RetriggerableDelay_Internal(IntPtr WorldContextObject, float Duration, IntPtr LatentInfo);

		// Token: 0x0600AD0D RID: 44301
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __QuitGame_Internal(IntPtr WorldContextObject, IntPtr SpecificPlayer, TEnumAsByte<EQuitPreference> QuitPreference, bool bIgnorePlatformRestrictions);

		// Token: 0x0600AD0E RID: 44302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintWarning_Internal(in FString InString);

		// Token: 0x0600AD0F RID: 44303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintText_Internal(IntPtr WorldContextObject, IntPtr InText, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration);

		// Token: 0x0600AD10 RID: 44304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintString_Internal(IntPtr WorldContextObject, in FString InString, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration);

		// Token: 0x0600AD11 RID: 44305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ParseParamValue_Internal(in FString InString, in FString InParam, ref FString OutValue);

		// Token: 0x0600AD12 RID: 44306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ParseParam_Internal(in FString InString, in FString InParam);

		// Token: 0x0600AD13 RID: 44307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ParseCommandLine_Internal(in FString InCmdLine, IntPtr OutTokens, IntPtr OutSwitches, IntPtr OutParams);

		// Token: 0x0600AD14 RID: 44308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_SoftObjectReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD15 RID: 44309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_SoftClassReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD16 RID: 44310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_PrimaryAssetType_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD17 RID: 44311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_PrimaryAssetId_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD18 RID: 44312
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __NormalizeFilename_Internal(in FString InFilename);

		// Token: 0x0600AD19 RID: 44313
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveComponentTo_Internal(IntPtr Component, FVector TargetRelativeLocation, FRotator TargetRelativeRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, TEnumAsByte<EMoveComponentAction> MoveAction, IntPtr LatentInfo);

		// Token: 0x0600AD1A RID: 44314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTopLevelAssetPath_Internal(in FString PackageName, in FString AssetName);

		// Token: 0x0600AD1B RID: 44315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSoftObjectPath_Internal(in FString PathString);

		// Token: 0x0600AD1C RID: 44316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSoftClassPath_Internal(in FString PathString);

		// Token: 0x0600AD1D RID: 44317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeLiteralText_Internal(IntPtr Value);

		// Token: 0x0600AD1E RID: 44318
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __MakeLiteralString_Internal(in FString Value);

		// Token: 0x0600AD1F RID: 44319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadClassAsset_Blocking_Internal(IntPtr AssetClass);

		// Token: 0x0600AD20 RID: 44320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadAssetClass_Internal(IntPtr WorldContextObject, IntPtr AssetClass, IntPtr OnLoaded, IntPtr LatentInfo);

		// Token: 0x0600AD21 RID: 44321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadAsset_Blocking_Internal(IntPtr Asset);

		// Token: 0x0600AD22 RID: 44322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadAsset_Internal(IntPtr WorldContextObject, IntPtr Asset, IntPtr OnLoaded, IntPtr LatentInfo);

		// Token: 0x0600AD23 RID: 44323
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD24 RID: 44324
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD25 RID: 44325
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD26 RID: 44326
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD27 RID: 44327
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD28 RID: 44328
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD29 RID: 44329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchURL_Internal(in FString URL);

		// Token: 0x0600AD2A RID: 44330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UnPauseTimerHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD2B RID: 44331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UnPauseTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD2C RID: 44332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UnPauseTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD2D RID: 44333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TimerExistsHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD2E RID: 44334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TimerExistsDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD2F RID: 44335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TimerExists_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD30 RID: 44336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_SetTimerDelegate_Internal(IntPtr Delegate, float Time, bool bLooping, float InitialStartDelay, float InitialStartDelayVariance);

		// Token: 0x0600AD31 RID: 44337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_SetTimer_Internal(IntPtr Object, in FString FunctionName, float Time, bool bLooping, float InitialStartDelay, float InitialStartDelayVariance);

		// Token: 0x0600AD32 RID: 44338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PauseTimerHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD33 RID: 44339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PauseTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD34 RID: 44340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PauseTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD35 RID: 44341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsValidTimerHandle_Internal(IntPtr Handle);

		// Token: 0x0600AD36 RID: 44342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerPausedHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD37 RID: 44343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerPausedDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD38 RID: 44344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerPaused_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD39 RID: 44345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerActiveHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD3A RID: 44346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerActiveDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD3B RID: 44347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerActive_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD3C RID: 44348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_InvalidateTimerHandle_Internal(IntPtr Handle);

		// Token: 0x0600AD3D RID: 44349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerRemainingTimeHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD3E RID: 44350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerRemainingTimeDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD3F RID: 44351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerRemainingTime_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD40 RID: 44352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerElapsedTimeHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD41 RID: 44353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerElapsedTimeDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD42 RID: 44354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerElapsedTime_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD43 RID: 44355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearTimerHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD44 RID: 44356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600AD45 RID: 44357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x0600AD46 RID: 44358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearAndInvalidateTimerHandle_Internal(IntPtr WorldContextObject, IntPtr Handle);

		// Token: 0x0600AD47 RID: 44359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidSoftObjectReference_Internal(IntPtr SoftObjectReference);

		// Token: 0x0600AD48 RID: 44360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidSoftClassReference_Internal(IntPtr SoftClassReference);

		// Token: 0x0600AD49 RID: 44361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidPrimaryAssetType_Internal(IntPtr PrimaryAssetType);

		// Token: 0x0600AD4A RID: 44362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600AD4B RID: 44363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStandalone_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD4C RID: 44364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSplitScreen_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD4D RID: 44365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsServer_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD4E RID: 44366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoggedIn_Internal(IntPtr SpecificPlayer);

		// Token: 0x0600AD4F RID: 44367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDedicatedServer_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD50 RID: 44368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVulkanBlockedModels_Internal();

		// Token: 0x0600AD51 RID: 44369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVulkanAllowedModels_Internal();

		// Token: 0x0600AD52 RID: 44370
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUniqueDeviceId_Internal();

		// Token: 0x0600AD53 RID: 44371
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSystemPath_Internal(IntPtr Object);

		// Token: 0x0600AD54 RID: 44372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSupportedFullscreenResolutions_Internal(IntPtr Resolutions);

		// Token: 0x0600AD55 RID: 44373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSoftObjectReferenceFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600AD56 RID: 44374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSoftClassReferenceFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600AD57 RID: 44375
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectSavedDirectory_Internal();

		// Token: 0x0600AD58 RID: 44376
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectDirectory_Internal();

		// Token: 0x0600AD59 RID: 44377
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectContentDirectory_Internal();

		// Token: 0x0600AD5A RID: 44378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPrimaryAssetsWithBundleState_Internal(IntPtr RequiredBundles, IntPtr ExcludedBundles, IntPtr ValidTypes, bool bForceCurrentState, IntPtr OutPrimaryAssetIdList);

		// Token: 0x0600AD5B RID: 44379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPrimaryAssetIdList_Internal(IntPtr PrimaryAssetType, IntPtr OutPrimaryAssetIdList);

		// Token: 0x0600AD5C RID: 44380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromSoftObjectReference_Internal(IntPtr SoftObjectReference);

		// Token: 0x0600AD5D RID: 44381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromSoftClassReference_Internal(IntPtr SoftClassReference);

		// Token: 0x0600AD5E RID: 44382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromObject_Internal(IntPtr Object);

		// Token: 0x0600AD5F RID: 44383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromClass_Internal(IntPtr Class);

		// Token: 0x0600AD60 RID: 44384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPreferredLanguages_Internal();

		// Token: 0x0600AD61 RID: 44385
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformUserName_Internal();

		// Token: 0x0600AD62 RID: 44386
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformUserDir_Internal();

		// Token: 0x0600AD63 RID: 44387
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPathName_Internal(IntPtr Object);

		// Token: 0x0600AD64 RID: 44388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOuterObject_Internal(IntPtr Object);

		// Token: 0x0600AD65 RID: 44389
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetObjectName_Internal(IntPtr Object);

		// Token: 0x0600AD66 RID: 44390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600AD67 RID: 44391
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLocalCurrencySymbol_Internal();

		// Token: 0x0600AD68 RID: 44392
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLocalCurrencyCode_Internal();

		// Token: 0x0600AD69 RID: 44393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameTimeInSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD6A RID: 44394
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGamepadControllerName_Internal(int ControllerId);

		// Token: 0x0600AD6B RID: 44395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGamepadButtonGlyph_Internal(in FString ButtonKey, int ControllerIndex);

		// Token: 0x0600AD6C RID: 44396
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameName_Internal();

		// Token: 0x0600AD6D RID: 44397
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameBundleId_Internal();

		// Token: 0x0600AD6E RID: 44398
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetEngineVersion_Internal();

		// Token: 0x0600AD6F RID: 44399
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDisplayName_Internal(IntPtr Object);

		// Token: 0x0600AD70 RID: 44400
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal();

		// Token: 0x0600AD71 RID: 44401
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultLocale_Internal();

		// Token: 0x0600AD72 RID: 44402
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultLanguage_Internal();

		// Token: 0x0600AD73 RID: 44403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCurrentBundleState_Internal(IntPtr PrimaryAssetId, bool bForceCurrentState, IntPtr OutBundles);

		// Token: 0x0600AD74 RID: 44404
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentActiveGamepadName_Internal();

		// Token: 0x0600AD75 RID: 44405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConvenientWindowedResolutions_Internal(IntPtr Resolutions);

		// Token: 0x0600AD76 RID: 44406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetConsoleVariableIntValue_Internal(in FString VariableName);

		// Token: 0x0600AD77 RID: 44407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetConsoleVariableFloatValue_Internal(in FString VariableName);

		// Token: 0x0600AD78 RID: 44408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConsoleVariableBoolValue_Internal(in FString VariableName);

		// Token: 0x0600AD79 RID: 44409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetComponentBounds_Internal(IntPtr Component, ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius);

		// Token: 0x0600AD7A RID: 44410
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCommandLine_Internal();

		// Token: 0x0600AD7B RID: 44411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClassFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600AD7C RID: 44412
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetClassDisplayName_Internal(IntPtr Class);

		// Token: 0x0600AD7D RID: 44413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorListFromComponentList_Internal(IntPtr ComponentList, IntPtr ActorClassFilter, IntPtr OutActorList);

		// Token: 0x0600AD7E RID: 44414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorBounds_Internal(IntPtr Actor, ref FVector Origin, ref FVector BoxExtent);

		// Token: 0x0600AD7F RID: 44415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushPersistentDebugLines_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD80 RID: 44416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushDebugStrings_Internal(IntPtr WorldContextObject);

		// Token: 0x0600AD81 RID: 44417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteConsoleCommandFromUserInput_Internal(IntPtr WorldContextObject, in FString Command, IntPtr SpecificPlayer);

		// Token: 0x0600AD82 RID: 44418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteConsoleCommand_Internal(IntPtr WorldContextObject, in FString Command, IntPtr SpecificPlayer);

		// Token: 0x0600AD83 RID: 44419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_SoftObjectReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD84 RID: 44420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_SoftClassReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD85 RID: 44421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_PrimaryAssetType_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD86 RID: 44422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_PrimaryAssetId_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AD87 RID: 44423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicQueueSubtitles_Internal(IntPtr WorldContextObject, in FString InString, float Duration, int FontSize);

		// Token: 0x0600AD88 RID: 44424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugString_Internal(IntPtr WorldContextObject, FVector TextLocation, in FString Text, IntPtr TestBaseActor, FLinearColor TextColor, float Duration);

		// Token: 0x0600AD89 RID: 44425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugSphere_Internal(IntPtr WorldContextObject, FVector Center, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD8A RID: 44426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugPoint_Internal(IntPtr WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration);

		// Token: 0x0600AD8B RID: 44427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugPlane_Internal(IntPtr WorldContextObject, in FPlane PlaneCoordinates, FVector Location, float Size, FLinearColor PlaneColor, float Duration);

		// Token: 0x0600AD8C RID: 44428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugLine_Internal(IntPtr WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD8D RID: 44429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugFrustum_Internal(IntPtr WorldContextObject, in FTransform FrustumTransform, FLinearColor FrustumColor, float Duration, float Thickness);

		// Token: 0x0600AD8E RID: 44430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugFloatHistoryTransform_Internal(IntPtr WorldContextObject, IntPtr FloatHistory, in FTransform DrawTransform, FVector2D DrawSize, FLinearColor DrawColor, float Duration);

		// Token: 0x0600AD8F RID: 44431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugFloatHistoryLocation_Internal(IntPtr WorldContextObject, IntPtr FloatHistory, FVector DrawLocation, FVector2D DrawSize, FLinearColor DrawColor, float Duration);

		// Token: 0x0600AD90 RID: 44432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCylinder_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD91 RID: 44433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCoordinateSystem_Internal(IntPtr WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale, float Duration, float Thickness);

		// Token: 0x0600AD92 RID: 44434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugConeInDegrees_Internal(IntPtr WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD93 RID: 44435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCone_Internal(IntPtr WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD94 RID: 44436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCircle_Internal(IntPtr WorldContextObject, FVector Center, float Radius, int NumSegments, FLinearColor LineColor, float Duration, float Thickness, FVector YAxis, FVector ZAxis, bool bDrawAxis);

		// Token: 0x0600AD95 RID: 44437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCapsule_Internal(IntPtr WorldContextObject, FVector Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD96 RID: 44438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCamera_Internal(IntPtr CameraActor, FLinearColor CameraColor, float Duration);

		// Token: 0x0600AD97 RID: 44439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugBox_Internal(IntPtr WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation, float Duration, float Thickness);

		// Token: 0x0600AD98 RID: 44440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugArrow_Internal(IntPtr WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600AD99 RID: 44441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesImplementInterface_Internal(IntPtr TestObject, IntPtr Interface);

		// Token: 0x0600AD9A RID: 44442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Delay_Internal(IntPtr WorldContextObject, float Duration, IntPtr LatentInfo);

		// Token: 0x0600AD9B RID: 44443
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD9C RID: 44444
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD9D RID: 44445
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD9E RID: 44446
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600AD9F RID: 44447
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA0 RID: 44448
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA1 RID: 44449
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA2 RID: 44450
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA3 RID: 44451
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA4 RID: 44452
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA5 RID: 44453
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA6 RID: 44454
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADA7 RID: 44455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugString_Internal(IntPtr WorldContextObject, FVectorDouble TextLocation, in FString Text, IntPtr TestBaseActor, FLinearColor TextColor, float Duration);

		// Token: 0x0600ADA8 RID: 44456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugSphere_Internal(IntPtr WorldContextObject, FVectorDouble Center, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADA9 RID: 44457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugPoint_Internal(IntPtr WorldContextObject, FVectorDouble Position, float Size, FLinearColor PointColor, float Duration);

		// Token: 0x0600ADAA RID: 44458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugPlane_Internal(IntPtr WorldContextObject, in FPlane PlaneCoordinates, FVectorDouble Location, float Size, FLinearColor PlaneColor, float Duration);

		// Token: 0x0600ADAB RID: 44459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugLine_Internal(IntPtr WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADAC RID: 44460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCylinder_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADAD RID: 44461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCoordinateSystem_Internal(IntPtr WorldContextObject, FVectorDouble AxisLoc, FRotator AxisRot, float Scale, float Duration, float Thickness);

		// Token: 0x0600ADAE RID: 44462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugConeInDegrees_Internal(IntPtr WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADAF RID: 44463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCone_Internal(IntPtr WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADB0 RID: 44464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCircle_Internal(IntPtr WorldContextObject, FVectorDouble Center, float Radius, int NumSegments, FLinearColor LineColor, float Duration, float Thickness, FVectorDouble YAxis, FVectorDouble ZAxis, bool bDrawAxis);

		// Token: 0x0600ADB1 RID: 44465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCapsule_Internal(IntPtr WorldContextObject, FVectorDouble Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADB2 RID: 44466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugBox_Internal(IntPtr WorldContextObject, FVectorDouble Center, FVectorDouble Extent, FLinearColor LineColor, FRotator Rotation, float Duration, float Thickness);

		// Token: 0x0600ADB3 RID: 44467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugArrow_Internal(IntPtr WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, float ArrowSize, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x0600ADB4 RID: 44468
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADB5 RID: 44469
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADB6 RID: 44470
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADB7 RID: 44471
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADB8 RID: 44472
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADB9 RID: 44473
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBA RID: 44474
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBB RID: 44475
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBC RID: 44476
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBD RID: 44477
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBE RID: 44478
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADBF RID: 44479
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADC0 RID: 44480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateCopyForUndoBuffer_Internal(IntPtr ObjectToModify);

		// Token: 0x0600ADC1 RID: 44481
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToRelativePath_Internal(in FString Filename);

		// Token: 0x0600ADC2 RID: 44482
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToAbsolutePath_Internal(in FString Filename);

		// Token: 0x0600ADC3 RID: 44483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftObjPathToSoftObjRef_Internal(IntPtr SoftObjectPath);

		// Token: 0x0600ADC4 RID: 44484
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_SoftObjectReferenceToString_Internal(IntPtr SoftObjectReference);

		// Token: 0x0600ADC5 RID: 44485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftObjectReferenceToObject_Internal(IntPtr SoftObject);

		// Token: 0x0600ADC6 RID: 44486
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_SoftClassReferenceToString_Internal(IntPtr SoftClassReference);

		// Token: 0x0600ADC7 RID: 44487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftClassReferenceToClass_Internal(IntPtr SoftClass);

		// Token: 0x0600ADC8 RID: 44488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftClassPathToSoftClassRef_Internal(IntPtr SoftClassPath);

		// Token: 0x0600ADC9 RID: 44489
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_PrimaryAssetTypeToString_Internal(IntPtr PrimaryAssetType);

		// Token: 0x0600ADCA RID: 44490
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_PrimaryAssetIdToString_Internal(IntPtr PrimaryAssetId);

		// Token: 0x0600ADCB RID: 44491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ObjectToSoftObjectReference_Internal(IntPtr Object);

		// Token: 0x0600ADCC RID: 44492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_InterfaceToObject_Internal(in FScriptInterface Interface);

		// Token: 0x0600ADCD RID: 44493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ClassToSoftClassReference_Internal(in IntPtr Class);

		// Token: 0x0600ADCE RID: 44494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentOverlapComponents_Internal(IntPtr Component, in FTransform ComponentTransform, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x0600ADCF RID: 44495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentOverlapActors_Internal(IntPtr Component, in FTransform ComponentTransform, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x0600ADD0 RID: 44496
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD1 RID: 44497
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD2 RID: 44498
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD3 RID: 44499
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD4 RID: 44500
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD5 RID: 44501
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADD6 RID: 44502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleOverlapComponents_Internal(IntPtr WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x0600ADD7 RID: 44503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleOverlapActors_Internal(IntPtr WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x0600ADD8 RID: 44504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanLaunchURL_Internal(in FString URL);

		// Token: 0x0600ADD9 RID: 44505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTopLevelAssetPath_Internal(IntPtr TopLevelAssetPath, ref FString PathString);

		// Token: 0x0600ADDA RID: 44506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSoftObjectPath_Internal(IntPtr InSoftObjectPath, ref FString PathString);

		// Token: 0x0600ADDB RID: 44507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSoftClassPath_Internal(IntPtr InSoftClassPath, ref FString PathString);

		// Token: 0x0600ADDC RID: 44508
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADDD RID: 44509
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADDE RID: 44510
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADDF RID: 44511
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADE0 RID: 44512
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADE1 RID: 44513
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x0600ADE2 RID: 44514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapComponents_Internal(IntPtr WorldContextObject, FVector BoxPos, FVector Extent, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x0600ADE3 RID: 44515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapActors_Internal(IntPtr WorldContextObject, FVector BoxPos, FVector BoxExtent, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x0600ADE4 RID: 44516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __BeginTransaction_Internal(in FString Context, IntPtr Description, IntPtr PrimaryObject);

		// Token: 0x0600ADE5 RID: 44517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddFloatHistorySample_Internal(float Value, IntPtr FloatHistory);

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x000F6C8E File Offset: 0x000F4E8E
		static UKismetSystemLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetSystemLibrary");
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x000F6C9C File Offset: 0x000F4E9C
		protected UKismetSystemLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B49 RID: 23369
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetSystemLibrary";

		// Token: 0x04005B4A RID: 23370
		private static IntPtr _ClassPtr;

		// Token: 0x04005B4B RID: 23371
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005B4C RID: 23372
		public static IntPtr __OnAssetLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005B4D RID: 23373
		public static IntPtr __OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005B4E RID: 23374
		private static IntPtr __StackTrace_NativeFunctionPtr;

		// Token: 0x04005B4F RID: 23375
		private static IntPtr __SetStructurePropertyByName_NativeFunctionPtr;

		// Token: 0x04005B50 RID: 23376
		private static IntPtr __SetFieldPathPropertyByName_NativeFunctionPtr;

		// Token: 0x04005B51 RID: 23377
		private static IntPtr __SetCollisionProfileNameProperty_NativeFunctionPtr;

		// Token: 0x02002D34 RID: 11572
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetStructurePropertyByName_FunctionParams
		{
			// Token: 0x0401672E RID: 91950
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x0401672F RID: 91951
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x04016730 RID: 91952
			[FieldOffset(20)]
			public FGenericStruct Value;
		}

		// Token: 0x02002D35 RID: 11573
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetFieldPathPropertyByName_FunctionParams
		{
			// Token: 0x04016731 RID: 91953
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04016732 RID: 91954
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x04016733 RID: 91955
			[Nullable(1)]
			[FieldOffset(24)]
			public Unusable Value;
		}

		// Token: 0x02002D36 RID: 11574
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCollisionProfileNameProperty_FunctionParams
		{
			// Token: 0x04016734 RID: 91956
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04016735 RID: 91957
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x04016736 RID: 91958
			[FieldOffset(20)]
			public byte Value;
		}
	}
}
