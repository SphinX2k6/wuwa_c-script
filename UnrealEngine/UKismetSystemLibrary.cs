using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000227 RID: 551
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetSystemLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetSystemLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002AAA RID: 10922 RVA: 0x0003A081 File Offset: 0x00038281
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetSystemLibrary._ClassPtr;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0003A090 File Offset: 0x00038290
		public UKismetSystemLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetSystemLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0003A0B8 File Offset: 0x000382B8
		[NullableContext(1)]
		public UKismetSystemLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetSystemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002AAD RID: 10925
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterForRemoteNotifications();

		// Token: 0x06002AAE RID: 10926 RVA: 0x0003A0EB File Offset: 0x000382EB
		public static void UnloadPrimaryAssetList([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetId> PrimaryAssetIdList)
		{
			UKismetSystemLibrary.__UnloadPrimaryAssetList_Internal((PrimaryAssetIdList ?? new TArray<FPrimaryAssetId>()).NativePtr);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0003A102 File Offset: 0x00038302
		public static void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId)
		{
			UKismetSystemLibrary.__UnloadPrimaryAsset_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0003A118 File Offset: 0x00038318
		public static void TransactObject(UObject Object)
		{
			UKismetSystemLibrary.__TransactObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0003A12F File Offset: 0x0003832F
		[SkipLocalsInit]
		public static void StackTrace()
		{
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__StackTrace_NativeFunctionPtr, null);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0003A144 File Offset: 0x00038344
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

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0003A244 File Offset: 0x00038444
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

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0003A334 File Offset: 0x00038534
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

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0003A42C File Offset: 0x0003862C
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

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0003A52C File Offset: 0x0003872C
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

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0003A61C File Offset: 0x0003881C
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

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0003A714 File Offset: 0x00038914
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

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0003A774 File Offset: 0x00038974
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

		// Token: 0x06002ABA RID: 10938 RVA: 0x0003A7D1 File Offset: 0x000389D1
		public static void SnapshotObject(UObject Object)
		{
			UKismetSystemLibrary.__SnapshotObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0003A7E8 File Offset: 0x000389E8
		[NullableContext(1)]
		public unsafe static void ShowPlatformSpecificLeaderboardScreen(string CategoryName)
		{
			FString fstring = FString.AllocTemp(CategoryName);
			UKismetSystemLibrary.__ShowPlatformSpecificLeaderboardScreen_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0003A80C File Offset: 0x00038A0C
		public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer)
		{
			UKismetSystemLibrary.__ShowPlatformSpecificAchievementsScreen_Internal((SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002ABD RID: 10941
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowInterstitialAd();

		// Token: 0x06002ABE RID: 10942
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowAdBanner(int AdIdIndex, bool bShowOnBottomOfScreen);

		// Token: 0x06002ABF RID: 10943 RVA: 0x0003A823 File Offset: 0x00038A23
		[NullableContext(1)]
		public static void SetWindowTitle(in FText Title)
		{
			FText ftext = Title;
			UKismetSystemLibrary.__SetWindowTitle_Internal((ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002AC0 RID: 10944
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetVolumeButtonsHandledBySystem(bool bEnabled);

		// Token: 0x06002AC1 RID: 10945 RVA: 0x0003A83C File Offset: 0x00038A3C
		public static void SetVectorPropertyByName(UObject Object, FName PropertyName, in FVector Value)
		{
			UKismetSystemLibrary.__SetVectorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0003A855 File Offset: 0x00038A55
		public static void SetVectorDoublePropertyByName(UObject Object, FName PropertyName, in FVectorDouble Value)
		{
			UKismetSystemLibrary.__SetVectorDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x0003A870 File Offset: 0x00038A70
		public unsafe static void SetTransformPropertyByName(UObject Object, FName PropertyName, in FTransform Value)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UKismetSystemLibrary.__SetTransformPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, ptr);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x0003A8B0 File Offset: 0x00038AB0
		public unsafe static void SetTransformDoublePropertyByName(UObject Object, FName PropertyName, in FTransformDouble Value)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UKismetSystemLibrary.__SetTransformDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, ptr);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0003A8F0 File Offset: 0x00038AF0
		[NullableContext(1)]
		public static void SetTextPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in FText Value)
		{
			IntPtr @object = (Object != null) ? Object.NativePtr : IntPtr.Zero;
			FText ftext = Value;
			UKismetSystemLibrary.__SetTextPropertyByName_Internal(@object, PropertyName, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0003A91A File Offset: 0x00038B1A
		public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject, bool bState)
		{
			UKismetSystemLibrary.__SetSuppressViewportTransitionMessage_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bState);
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0003A934 File Offset: 0x00038B34
		[NullableContext(1)]
		public unsafe static void SetStringPropertyByName([Nullable(2)] UObject Object, FName PropertyName, string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UKismetSystemLibrary.__SetStringPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0003A969 File Offset: 0x00038B69
		[NullableContext(1)]
		public static void SetSoftObjectPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in TSoftObjectPtr<UObject> Value)
		{
			UKismetSystemLibrary.__SetSoftObjectPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0003A991 File Offset: 0x00038B91
		[NullableContext(1)]
		public static void SetSoftClassPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in TSoftClassPtr<UObject> Value)
		{
			UKismetSystemLibrary.__SetSoftClassPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x0003A9B9 File Offset: 0x00038BB9
		public static void SetRotatorPropertyByName(UObject Object, FName PropertyName, in FRotator Value)
		{
			UKismetSystemLibrary.__SetRotatorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0003A9D2 File Offset: 0x00038BD2
		public static void SetObjectPropertyByName(UObject Object, FName PropertyName, UObject Value)
		{
			UKismetSystemLibrary.__SetObjectPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0003A9FC File Offset: 0x00038BFC
		public unsafe static void SetNamePropertyByName(UObject Object, FName PropertyName, in FName Value)
		{
			fixed (FName* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				UKismetSystemLibrary.__SetNamePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0003AA28 File Offset: 0x00038C28
		public static void SetLinearColorPropertyByName(UObject Object, FName PropertyName, in FLinearColor Value)
		{
			UKismetSystemLibrary.__SetLinearColorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0003AA41 File Offset: 0x00038C41
		public static void SetIntPropertyByName(UObject Object, FName PropertyName, int Value)
		{
			UKismetSystemLibrary.__SetIntPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public unsafe static void SetInterfacePropertyByName(UObject Object, FName PropertyName, in FScriptInterface Value)
		{
			fixed (FScriptInterface* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				UKismetSystemLibrary.__SetInterfacePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x0003AA88 File Offset: 0x00038C88
		public static void SetInt64PropertyByName(UObject Object, FName PropertyName, long Value)
		{
			UKismetSystemLibrary.__SetInt64PropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AD1 RID: 10961
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGamepadsBlockDeviceFeedback(bool bBlock);

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0003AAA1 File Offset: 0x00038CA1
		public static void SetFloatPropertyByName(UObject Object, FName PropertyName, float Value)
		{
			UKismetSystemLibrary.__SetFloatPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0003AABC File Offset: 0x00038CBC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetFieldPathPropertyByName([Nullable(2)] UObject Object, FName PropertyName, in Unusable Value)
		{
			UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams* ptr = stackalloc UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKismetSystemLibrary.__SetFieldPathPropertyByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKismetSystemLibrary.__SetFieldPathPropertyByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0003AB30 File Offset: 0x00038D30
		public static void SetDoublePropertyByName(UObject Object, FName PropertyName, double Value)
		{
			UKismetSystemLibrary.__SetDoublePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x0003AB49 File Offset: 0x00038D49
		public static void SetColorPropertyByName(UObject Object, FName PropertyName, in FColor Value)
		{
			UKismetSystemLibrary.__SetColorPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0003AB64 File Offset: 0x00038D64
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKismetSystemLibrary._ClassDefaultObjectPtr, UKismetSystemLibrary.__SetCollisionProfileNameProperty_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0003ABE3 File Offset: 0x00038DE3
		public static void SetClassPropertyByName(UObject Object, FName PropertyName, UClassStackOnlyPtr Value)
		{
			UKismetSystemLibrary.__SetClassPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value._NativePtr);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0003AC01 File Offset: 0x00038E01
		public static void SetBytePropertyByName(UObject Object, FName PropertyName, byte Value)
		{
			UKismetSystemLibrary.__SetBytePropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0003AC1A File Offset: 0x00038E1A
		public static void SetBoolPropertyByName(UObject Object, FName PropertyName, bool Value)
		{
			UKismetSystemLibrary.__SetBoolPropertyByName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName, Value);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0003AC33 File Offset: 0x00038E33
		public static bool SetAllChannels(ref FCollisionResponseContainer ResponseToChannels, ECollisionResponse NewResponse)
		{
			return UKismetSystemLibrary.__SetAllChannels_Internal((ResponseToChannels ?? new FCollisionResponseContainer()).NativePtr, NewResponse);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x0003AC50 File Offset: 0x00038E50
		[NullableContext(1)]
		public static string RHIName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__RHIName_Internal());
		}

		// Token: 0x06002ADC RID: 10972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGamepadAssignmentToController(int ControllerId);

		// Token: 0x06002ADD RID: 10973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGamepadAssignments();

		// Token: 0x06002ADE RID: 10974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterForRemoteNotifications();

		// Token: 0x06002ADF RID: 10975 RVA: 0x0003AC5C File Offset: 0x00038E5C
		public static void QuitGame(UObject WorldContextObject, APlayerController SpecificPlayer, EQuitPreference QuitPreference, bool bIgnorePlatformRestrictions)
		{
			UKismetSystemLibrary.__QuitGame_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero, QuitPreference, bIgnorePlatformRestrictions);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0003AC8C File Offset: 0x00038E8C
		[NullableContext(1)]
		public unsafe static void PrintWarning(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			UKismetSystemLibrary.__PrintWarning_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0003ACB0 File Offset: 0x00038EB0
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

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0003AD34 File Offset: 0x00038F34
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

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0003ADBC File Offset: 0x00038FBC
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

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0003AE10 File Offset: 0x00039010
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

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0003AE48 File Offset: 0x00039048
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

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0003AE9C File Offset: 0x0003909C
		[NullableContext(1)]
		public static bool NotEqual_SoftObjectReference(in TSoftObjectPtr<UObject> A, in TSoftObjectPtr<UObject> B)
		{
			return UKismetSystemLibrary.__NotEqual_SoftObjectReference_Internal((A ?? new TSoftObjectPtr<UObject>()).NativePtr, (B ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0003AEC3 File Offset: 0x000390C3
		[NullableContext(1)]
		public static bool NotEqual_SoftClassReference(in TSoftClassPtr<UObject> A, in TSoftClassPtr<UObject> B)
		{
			return UKismetSystemLibrary.__NotEqual_SoftClassReference_Internal((A ?? new TSoftClassPtr<UObject>()).NativePtr, (B ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x0003AEEA File Offset: 0x000390EA
		public static bool NotEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			return UKismetSystemLibrary.__NotEqual_PrimaryAssetType_Internal((A ?? new FPrimaryAssetType()).NativePtr, (B ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x0003AF0F File Offset: 0x0003910F
		public static bool NotEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			return UKismetSystemLibrary.__NotEqual_PrimaryAssetId_Internal((A ?? new FPrimaryAssetId()).NativePtr, (B ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0003AF34 File Offset: 0x00039134
		[NullableContext(1)]
		public unsafe static string NormalizeFilename(string InFilename)
		{
			FString fstring = FString.AllocTemp(InFilename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__NormalizeFilename_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x0003AF60 File Offset: 0x00039160
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

		// Token: 0x06002AEC RID: 10988 RVA: 0x0003AF9C File Offset: 0x0003919C
		[NullableContext(1)]
		public unsafe static FSoftObjectPath MakeSoftObjectPath(string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			FSoftObjectPath result = new FSoftObjectPath(UKismetSystemLibrary.__MakeSoftObjectPath_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0003AFC8 File Offset: 0x000391C8
		[NullableContext(1)]
		public unsafe static FSoftClassPath MakeSoftClassPath(string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			FSoftClassPath result = new FSoftClassPath(UKismetSystemLibrary.__MakeSoftClassPath_Internal(fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0003AFF2 File Offset: 0x000391F2
		[NullableContext(1)]
		public static FText MakeLiteralText(FText Value)
		{
			return new FText(UKismetSystemLibrary.__MakeLiteralText_Internal((Value != null) ? Value.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0003B010 File Offset: 0x00039210
		[NullableContext(1)]
		public unsafe static string MakeLiteralString(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__MakeLiteralString_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002AF0 RID: 10992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName MakeLiteralName(FName Value);

		// Token: 0x06002AF1 RID: 10993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int MakeLiteralInt(int Value);

		// Token: 0x06002AF2 RID: 10994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MakeLiteralFloat(float Value);

		// Token: 0x06002AF3 RID: 10995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double MakeLiteralDouble(double Value);

		// Token: 0x06002AF4 RID: 10996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte MakeLiteralByte(byte Value);

		// Token: 0x06002AF5 RID: 10997
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool MakeLiteralBool(bool Value);

		// Token: 0x06002AF6 RID: 10998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadInterstitialAd(int AdIdIndex);

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0003B039 File Offset: 0x00039239
		[NullableContext(1)]
		public static UClassStackOnlyPtr LoadClassAsset_Blocking(TSoftClassPtr<UObject> AssetClass)
		{
			return UKismetSystemLibrary.__LoadClassAsset_Blocking_Internal((AssetClass ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0003B054 File Offset: 0x00039254
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__LoadAsset_Blocking_Internal((Asset ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0003B070 File Offset: 0x00039270
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

		// Token: 0x06002AFA RID: 11002 RVA: 0x0003B170 File Offset: 0x00039370
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

		// Token: 0x06002AFB RID: 11003 RVA: 0x0003B260 File Offset: 0x00039460
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x0003B354 File Offset: 0x00039554
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

		// Token: 0x06002AFD RID: 11005 RVA: 0x0003B454 File Offset: 0x00039654
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

		// Token: 0x06002AFE RID: 11006 RVA: 0x0003B544 File Offset: 0x00039744
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

		// Token: 0x06002AFF RID: 11007 RVA: 0x0003B638 File Offset: 0x00039838
		[NullableContext(1)]
		public unsafe static void LaunchURL(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			UKismetSystemLibrary.__LaunchURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0003B65C File Offset: 0x0003985C
		public static void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_UnPauseTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0003B670 File Offset: 0x00039870
		[NullableContext(1)]
		public unsafe static void K2_UnPauseTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_UnPauseTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x0003B6A4 File Offset: 0x000398A4
		public static bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_TimerExistsDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0003B6B8 File Offset: 0x000398B8
		[NullableContext(1)]
		public unsafe static bool K2_TimerExists([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_TimerExists_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0003B6EC File Offset: 0x000398EC
		public static void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_PauseTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0003B700 File Offset: 0x00039900
		[NullableContext(1)]
		public unsafe static void K2_PauseTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_PauseTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0003B734 File Offset: 0x00039934
		public static bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_IsTimerPausedDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0003B748 File Offset: 0x00039948
		[NullableContext(1)]
		public unsafe static bool K2_IsTimerPaused([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_IsTimerPaused_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0003B77C File Offset: 0x0003997C
		public static bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_IsTimerActiveDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x0003B790 File Offset: 0x00039990
		[NullableContext(1)]
		public unsafe static bool K2_IsTimerActive([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			bool result = UKismetSystemLibrary.__K2_IsTimerActive_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x0003B7C4 File Offset: 0x000399C4
		public static float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_GetTimerRemainingTimeDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x0003B7D8 File Offset: 0x000399D8
		[NullableContext(1)]
		public unsafe static float K2_GetTimerRemainingTime([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			float result = UKismetSystemLibrary.__K2_GetTimerRemainingTime_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x0003B80C File Offset: 0x00039A0C
		public static float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			return UKismetSystemLibrary.__K2_GetTimerElapsedTimeDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0003B820 File Offset: 0x00039A20
		[NullableContext(1)]
		public unsafe static float K2_GetTimerElapsedTime([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			float result = UKismetSystemLibrary.__K2_GetTimerElapsedTime_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0003B854 File Offset: 0x00039A54
		public static void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			UKismetSystemLibrary.__K2_ClearTimerDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0003B868 File Offset: 0x00039A68
		[NullableContext(1)]
		public unsafe static void K2_ClearTimer([Nullable(2)] UObject Object, string FunctionName)
		{
			FString fstring = FString.AllocTemp(FunctionName);
			UKismetSystemLibrary.__K2_ClearTimer_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B10 RID: 11024
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsVulkanAutoDetectMode();

		// Token: 0x06002B11 RID: 11025 RVA: 0x0003B89C File Offset: 0x00039A9C
		[NullableContext(1)]
		public static bool IsValidSoftObjectReference(in TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return UKismetSystemLibrary.__IsValidSoftObjectReference_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0003B8B3 File Offset: 0x00039AB3
		[NullableContext(1)]
		public static bool IsValidSoftClassReference(in TSoftClassPtr<UObject> SoftClassReference)
		{
			return UKismetSystemLibrary.__IsValidSoftClassReference_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0003B8CA File Offset: 0x00039ACA
		public static bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType)
		{
			return UKismetSystemLibrary.__IsValidPrimaryAssetType_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		public static bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return UKismetSystemLibrary.__IsValidPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x06002B15 RID: 11029
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidClass(UClassStackOnlyPtr Class);

		// Token: 0x06002B16 RID: 11030
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsUnattended();

		// Token: 0x06002B17 RID: 11031 RVA: 0x0003B8F6 File Offset: 0x00039AF6
		public static bool IsStandalone(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsStandalone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0003B90D File Offset: 0x00039B0D
		public static bool IsSplitScreen(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsSplitScreen_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0003B924 File Offset: 0x00039B24
		public static bool IsServer(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsServer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B1A RID: 11034
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsScreensaverEnabled();

		// Token: 0x06002B1B RID: 11035
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPackagedForDistribution();

		// Token: 0x06002B1C RID: 11036 RVA: 0x0003B93B File Offset: 0x00039B3B
		public static bool IsLoggedIn(APlayerController SpecificPlayer)
		{
			return UKismetSystemLibrary.__IsLoggedIn_Internal((SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B1D RID: 11037
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInterstitialAdRequested();

		// Token: 0x06002B1E RID: 11038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInterstitialAdAvailable();

		// Token: 0x06002B1F RID: 11039
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsGamepadAttached();

		// Token: 0x06002B20 RID: 11040 RVA: 0x0003B952 File Offset: 0x00039B52
		public static bool IsDedicatedServer(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__IsDedicatedServer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B21 RID: 11041
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsControllerAssignedToGamepad(int ControllerId);

		// Token: 0x06002B22 RID: 11042
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HideAdBanner();

		// Token: 0x06002B23 RID: 11043 RVA: 0x0003B969 File Offset: 0x00039B69
		[NullableContext(1)]
		public static TArray<string> GetVulkanBlockedModels()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetVulkanBlockedModels_Internal(), null);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0003B976 File Offset: 0x00039B76
		[NullableContext(1)]
		public static TArray<string> GetVulkanAllowedModels()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetVulkanAllowedModels_Internal(), null);
		}

		// Token: 0x06002B25 RID: 11045
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetVolumeButtonsHandledBySystem();

		// Token: 0x06002B26 RID: 11046 RVA: 0x0003B983 File Offset: 0x00039B83
		[NullableContext(1)]
		public static string GetUniqueDeviceId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetUniqueDeviceId_Internal());
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x0003B98F File Offset: 0x00039B8F
		[NullableContext(1)]
		public static string GetSystemPath([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetSystemPath_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0003B9AB File Offset: 0x00039BAB
		public static bool GetSupportedFullscreenResolutions(ref TArray<FIntPoint> Resolutions)
		{
			return UKismetSystemLibrary.__GetSupportedFullscreenResolutions_Internal((Resolutions ?? new TArray<FIntPoint>()).NativePtr);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0003B9C2 File Offset: 0x00039BC2
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__GetSoftObjectReferenceFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr), true, true);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x0003B9DF File Offset: 0x00039BDF
		[NullableContext(1)]
		public static TSoftClassPtr<UObject> GetSoftClassReferenceFromPrimaryAssetId([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__GetSoftClassReferenceFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr), null);
		}

		// Token: 0x06002B2B RID: 11051
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRenderingMaterialQualityLevel();

		// Token: 0x06002B2C RID: 11052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRenderingDetailMode();

		// Token: 0x06002B2D RID: 11053 RVA: 0x0003B9FB File Offset: 0x00039BFB
		[NullableContext(1)]
		public static string GetProjectSavedDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectSavedDirectory_Internal());
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0003BA07 File Offset: 0x00039C07
		[NullableContext(1)]
		public static string GetProjectDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectDirectory_Internal());
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0003BA13 File Offset: 0x00039C13
		[NullableContext(1)]
		public static string GetProjectContentDirectory()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetProjectContentDirectory_Internal());
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0003BA20 File Offset: 0x00039C20
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

		// Token: 0x06002B31 RID: 11057 RVA: 0x0003BA74 File Offset: 0x00039C74
		public static void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPrimaryAssetId> OutPrimaryAssetIdList)
		{
			UKismetSystemLibrary.__GetPrimaryAssetIdList_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr, (OutPrimaryAssetIdList ?? new TArray<FPrimaryAssetId>()).NativePtr);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x0003BA9A File Offset: 0x00039C9A
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromSoftObjectReference_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr), null);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x0003BAB6 File Offset: 0x00039CB6
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftClassPtr<UObject> SoftClassReference)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromSoftClassReference_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr), null);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x0003BAD2 File Offset: 0x00039CD2
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromObject([Nullable(2)] UObject Object)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0003BAEF File Offset: 0x00039CEF
		[NullableContext(1)]
		public static FPrimaryAssetId GetPrimaryAssetIdFromClass(UClassStackOnlyPtr Class)
		{
			return new FPrimaryAssetId(UKismetSystemLibrary.__GetPrimaryAssetIdFromClass_Internal(Class._NativePtr), null);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0003BB02 File Offset: 0x00039D02
		[NullableContext(1)]
		public static TArray<string> GetPreferredLanguages()
		{
			return new TArray<string>(UKismetSystemLibrary.__GetPreferredLanguages_Internal(), null);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0003BB0F File Offset: 0x00039D0F
		[NullableContext(1)]
		public static string GetPlatformUserName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPlatformUserName_Internal());
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0003BB1B File Offset: 0x00039D1B
		[NullableContext(1)]
		public static string GetPlatformUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPlatformUserDir_Internal());
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0003BB27 File Offset: 0x00039D27
		[NullableContext(1)]
		public static string GetPathName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetPathName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0003BB43 File Offset: 0x00039D43
		public static UObject GetOuterObject(UObject Object)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__GetOuterObject_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x0003BB5F File Offset: 0x00039D5F
		[NullableContext(1)]
		public static string GetObjectName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetObjectName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0003BB7B File Offset: 0x00039D7B
		public static UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__GetObjectFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr));
		}

		// Token: 0x06002B3D RID: 11069
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMinYResolutionForUI();

		// Token: 0x06002B3E RID: 11070
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetMinYResolutionFor3DView();

		// Token: 0x06002B3F RID: 11071 RVA: 0x0003BB96 File Offset: 0x00039D96
		[NullableContext(1)]
		public static string GetLocalCurrencySymbol()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetLocalCurrencySymbol_Internal());
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0003BBA2 File Offset: 0x00039DA2
		[NullableContext(1)]
		public static string GetLocalCurrencyCode()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetLocalCurrencyCode_Internal());
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0003BBAE File Offset: 0x00039DAE
		public static float GetGameTimeInSeconds(UObject WorldContextObject)
		{
			return UKismetSystemLibrary.__GetGameTimeInSeconds_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0003BBC5 File Offset: 0x00039DC5
		[NullableContext(1)]
		public static string GetGamepadControllerName(int ControllerId)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGamepadControllerName_Internal(ControllerId));
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0003BBD4 File Offset: 0x00039DD4
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UTexture2D GetGamepadButtonGlyph(string ButtonKey, int ControllerIndex)
		{
			FString fstring = FString.AllocTemp(ButtonKey);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetSystemLibrary.__GetGamepadButtonGlyph_Internal(fstring, ControllerIndex));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0003BBFE File Offset: 0x00039DFE
		[NullableContext(1)]
		public static string GetGameName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGameName_Internal());
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0003BC0A File Offset: 0x00039E0A
		[NullableContext(1)]
		public static string GetGameBundleId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetGameBundleId_Internal());
		}

		// Token: 0x06002B46 RID: 11078
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetFrameCount();

		// Token: 0x06002B47 RID: 11079 RVA: 0x0003BC16 File Offset: 0x00039E16
		[NullableContext(1)]
		public static string GetEngineVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetEngineVersion_Internal());
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x0003BC22 File Offset: 0x00039E22
		[NullableContext(1)]
		public static string GetDisplayName([Nullable(2)] UObject Object)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDisplayName_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x0003BC3E File Offset: 0x00039E3E
		[NullableContext(1)]
		public static string GetDeviceId()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDeviceId_Internal());
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0003BC4A File Offset: 0x00039E4A
		[NullableContext(1)]
		public static string GetDefaultLocale()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDefaultLocale_Internal());
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x0003BC56 File Offset: 0x00039E56
		[NullableContext(1)]
		public static string GetDefaultLanguage()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetDefaultLanguage_Internal());
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0003BC62 File Offset: 0x00039E62
		public static bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId, bool bForceCurrentState, ref TArray<FName> OutBundles)
		{
			return UKismetSystemLibrary.__GetCurrentBundleState_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr, bForceCurrentState, (OutBundles ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0003BC89 File Offset: 0x00039E89
		[NullableContext(1)]
		public static string GetCurrentActiveGamepadName()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetCurrentActiveGamepadName_Internal());
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0003BC95 File Offset: 0x00039E95
		public static bool GetConvenientWindowedResolutions(ref TArray<FIntPoint> Resolutions)
		{
			return UKismetSystemLibrary.__GetConvenientWindowedResolutions_Internal((Resolutions ?? new TArray<FIntPoint>()).NativePtr);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0003BCAC File Offset: 0x00039EAC
		[NullableContext(1)]
		public unsafe static int GetConsoleVariableIntValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			int result = UKismetSystemLibrary.__GetConsoleVariableIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		[NullableContext(1)]
		public unsafe static float GetConsoleVariableFloatValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			float result = UKismetSystemLibrary.__GetConsoleVariableFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		[NullableContext(1)]
		public unsafe static bool GetConsoleVariableBoolValue(string VariableName)
		{
			FString fstring = FString.AllocTemp(VariableName);
			bool result = UKismetSystemLibrary.__GetConsoleVariableBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x0003BD18 File Offset: 0x00039F18
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

		// Token: 0x06002B53 RID: 11091 RVA: 0x0003BD5B File Offset: 0x00039F5B
		[NullableContext(1)]
		public static string GetCommandLine()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetCommandLine_Internal());
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0003BD67 File Offset: 0x00039F67
		public static UClassStackOnlyPtr GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			return UKismetSystemLibrary.__GetClassFromPrimaryAssetId_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0003BD82 File Offset: 0x00039F82
		[NullableContext(1)]
		public static string GetClassDisplayName(UClassStackOnlyPtr Class)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__GetClassDisplayName_Internal(Class._NativePtr));
		}

		// Token: 0x06002B56 RID: 11094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAdIDCount();

		// Token: 0x06002B57 RID: 11095 RVA: 0x0003BD94 File Offset: 0x00039F94
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

		// Token: 0x06002B58 RID: 11096 RVA: 0x0003BDC4 File Offset: 0x00039FC4
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

		// Token: 0x06002B59 RID: 11097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCloseAdBanner();

		// Token: 0x06002B5A RID: 11098 RVA: 0x0003BDF8 File Offset: 0x00039FF8
		public static void FlushPersistentDebugLines(UObject WorldContextObject)
		{
			UKismetSystemLibrary.__FlushPersistentDebugLines_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0003BE0F File Offset: 0x0003A00F
		public static void FlushDebugStrings(UObject WorldContextObject)
		{
			UKismetSystemLibrary.__FlushDebugStrings_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0003BE28 File Offset: 0x0003A028
		public unsafe static void ExecuteConsoleCommandFromUserInput(UObject WorldContextObject, [Nullable(1)] string Command, APlayerController SpecificPlayer = null)
		{
			FString fstring = FString.AllocTemp(Command);
			UKismetSystemLibrary.__ExecuteConsoleCommandFromUserInput_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0003BE6C File Offset: 0x0003A06C
		public unsafe static void ExecuteConsoleCommand(UObject WorldContextObject, [Nullable(1)] string Command, APlayerController SpecificPlayer = null)
		{
			FString fstring = FString.AllocTemp(Command);
			UKismetSystemLibrary.__ExecuteConsoleCommand_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, (SpecificPlayer != null) ? SpecificPlayer.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		[NullableContext(1)]
		public static bool EqualEqual_SoftObjectReference(in TSoftObjectPtr<UObject> A, in TSoftObjectPtr<UObject> B)
		{
			return UKismetSystemLibrary.__EqualEqual_SoftObjectReference_Internal((A ?? new TSoftObjectPtr<UObject>()).NativePtr, (B ?? new TSoftObjectPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x0003BED7 File Offset: 0x0003A0D7
		[NullableContext(1)]
		public static bool EqualEqual_SoftClassReference(in TSoftClassPtr<UObject> A, in TSoftClassPtr<UObject> B)
		{
			return UKismetSystemLibrary.__EqualEqual_SoftClassReference_Internal((A ?? new TSoftClassPtr<UObject>()).NativePtr, (B ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x0003BEFE File Offset: 0x0003A0FE
		public static bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			return UKismetSystemLibrary.__EqualEqual_PrimaryAssetType_Internal((A ?? new FPrimaryAssetType()).NativePtr, (B ?? new FPrimaryAssetType()).NativePtr);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0003BF23 File Offset: 0x0003A123
		public static bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			return UKismetSystemLibrary.__EqualEqual_PrimaryAssetId_Internal((A ?? new FPrimaryAssetId()).NativePtr, (B ?? new FPrimaryAssetId()).NativePtr);
		}

		// Token: 0x06002B62 RID: 11106
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int EndTransaction();

		// Token: 0x06002B63 RID: 11107 RVA: 0x0003BF48 File Offset: 0x0003A148
		[NullableContext(1)]
		public unsafe static void DynamicQueueSubtitles([Nullable(2)] UObject WorldContextObject, string InString = "Hello", float Duration = 2f, int FontSize = 18)
		{
			FString fstring = FString.AllocTemp(InString);
			UKismetSystemLibrary.__DynamicQueueSubtitles_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Duration, FontSize);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x0003BF80 File Offset: 0x0003A180
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

		// Token: 0x06002B65 RID: 11109 RVA: 0x0003C014 File Offset: 0x0003A214
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

		// Token: 0x06002B66 RID: 11110 RVA: 0x0003C08A File Offset: 0x0003A28A
		public static void DrawDebugPoint(UObject WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration = 0f)
		{
			UKismetSystemLibrary.__DrawDebugPoint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position, Size, PointColor, Duration);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0003C0A8 File Offset: 0x0003A2A8
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

		// Token: 0x06002B68 RID: 11112 RVA: 0x0003C138 File Offset: 0x0003A338
		public static void DrawDebugLine(UObject WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugLine_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0003C158 File Offset: 0x0003A358
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

		// Token: 0x06002B6A RID: 11114 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
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

		// Token: 0x06002B6B RID: 11115 RVA: 0x0003C260 File Offset: 0x0003A460
		public static void DrawDebugCoordinateSystem(UObject WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale = 1f, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCoordinateSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AxisLoc, AxisRot, Scale, Duration, Thickness);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x0003C280 File Offset: 0x0003A480
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

		// Token: 0x06002B6D RID: 11117 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		public static void DrawDebugCone(UObject WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugCone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0003C330 File Offset: 0x0003A530
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

		// Token: 0x06002B6F RID: 11119 RVA: 0x0003C3FC File Offset: 0x0003A5FC
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

		// Token: 0x06002B70 RID: 11120 RVA: 0x0003C474 File Offset: 0x0003A674
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

		// Token: 0x06002B71 RID: 11121 RVA: 0x0003C4E3 File Offset: 0x0003A6E3
		public static void DrawDebugBox(UObject WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation = default(FRotator), float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugBox_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Extent, LineColor, Rotation, Duration, Thickness);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0003C503 File Offset: 0x0003A703
		public static void DrawDebugArrow(UObject WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__DrawDebugArrow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0003C523 File Offset: 0x0003A723
		public static bool DoesImplementInterface(UObject TestObject, UClassStackOnlyPtr Interface)
		{
			return UKismetSystemLibrary.__DoesImplementInterface_Internal((TestObject != null) ? TestObject.NativePtr : IntPtr.Zero, Interface._NativePtr);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0003C540 File Offset: 0x0003A740
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

		// Token: 0x06002B75 RID: 11125 RVA: 0x0003C640 File Offset: 0x0003A840
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

		// Token: 0x06002B76 RID: 11126 RVA: 0x0003C730 File Offset: 0x0003A930
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

		// Token: 0x06002B77 RID: 11127 RVA: 0x0003C828 File Offset: 0x0003AA28
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

		// Token: 0x06002B78 RID: 11128 RVA: 0x0003C928 File Offset: 0x0003AB28
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

		// Token: 0x06002B79 RID: 11129 RVA: 0x0003CA18 File Offset: 0x0003AC18
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x0003CB10 File Offset: 0x0003AD10
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

		// Token: 0x06002B7B RID: 11131 RVA: 0x0003CC10 File Offset: 0x0003AE10
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

		// Token: 0x06002B7C RID: 11132 RVA: 0x0003CD00 File Offset: 0x0003AF00
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

		// Token: 0x06002B7D RID: 11133 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
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

		// Token: 0x06002B7E RID: 11134 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
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

		// Token: 0x06002B7F RID: 11135 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
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

		// Token: 0x06002B80 RID: 11136 RVA: 0x0003D0D8 File Offset: 0x0003B2D8
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

		// Token: 0x06002B81 RID: 11137 RVA: 0x0003D16C File Offset: 0x0003B36C
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

		// Token: 0x06002B82 RID: 11138 RVA: 0x0003D1E2 File Offset: 0x0003B3E2
		public static void D_DrawDebugPoint(UObject WorldContextObject, FVectorDouble Position, float Size, FLinearColor PointColor, float Duration = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugPoint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Position, Size, PointColor, Duration);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x0003D200 File Offset: 0x0003B400
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

		// Token: 0x06002B84 RID: 11140 RVA: 0x0003D290 File Offset: 0x0003B490
		public static void D_DrawDebugLine(UObject WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugLine_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
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

		// Token: 0x06002B86 RID: 11142 RVA: 0x0003D328 File Offset: 0x0003B528
		public static void D_DrawDebugCoordinateSystem(UObject WorldContextObject, FVectorDouble AxisLoc, FRotator AxisRot, float Scale = 1f, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCoordinateSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AxisLoc, AxisRot, Scale, Duration, Thickness);
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0003D348 File Offset: 0x0003B548
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

		// Token: 0x06002B88 RID: 11144 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		public static void D_DrawDebugCone(UObject WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugCone_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
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

		// Token: 0x06002B8A RID: 11146 RVA: 0x0003D4DC File Offset: 0x0003B6DC
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

		// Token: 0x06002B8B RID: 11147 RVA: 0x0003D554 File Offset: 0x0003B754
		public static void D_DrawDebugBox(UObject WorldContextObject, FVectorDouble Center, FVectorDouble Extent, FLinearColor LineColor, FRotator Rotation = default(FRotator), float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugBox_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Center, Extent, LineColor, Rotation, Duration, Thickness);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0003D574 File Offset: 0x0003B774
		public static void D_DrawDebugArrow(UObject WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
		{
			UKismetSystemLibrary.__D_DrawDebugArrow_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0003D594 File Offset: 0x0003B794
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

		// Token: 0x06002B8E RID: 11150 RVA: 0x0003D698 File Offset: 0x0003B898
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

		// Token: 0x06002B8F RID: 11151 RVA: 0x0003D78C File Offset: 0x0003B98C
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

		// Token: 0x06002B90 RID: 11152 RVA: 0x0003D884 File Offset: 0x0003BA84
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

		// Token: 0x06002B91 RID: 11153 RVA: 0x0003D988 File Offset: 0x0003BB88
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

		// Token: 0x06002B92 RID: 11154 RVA: 0x0003DA7C File Offset: 0x0003BC7C
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

		// Token: 0x06002B93 RID: 11155 RVA: 0x0003DB74 File Offset: 0x0003BD74
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

		// Token: 0x06002B94 RID: 11156 RVA: 0x0003DC78 File Offset: 0x0003BE78
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

		// Token: 0x06002B95 RID: 11157 RVA: 0x0003DD6C File Offset: 0x0003BF6C
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

		// Token: 0x06002B96 RID: 11158 RVA: 0x0003DE64 File Offset: 0x0003C064
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

		// Token: 0x06002B97 RID: 11159 RVA: 0x0003DF68 File Offset: 0x0003C168
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

		// Token: 0x06002B98 RID: 11160 RVA: 0x0003E05C File Offset: 0x0003C25C
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

		// Token: 0x06002B99 RID: 11161 RVA: 0x0003E153 File Offset: 0x0003C353
		public static void CreateCopyForUndoBuffer(UObject ObjectToModify)
		{
			UKismetSystemLibrary.__CreateCopyForUndoBuffer_Internal((ObjectToModify != null) ? ObjectToModify.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0003E16C File Offset: 0x0003C36C
		[NullableContext(1)]
		public unsafe static string ConvertToRelativePath(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__ConvertToRelativePath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0003E198 File Offset: 0x0003C398
		[NullableContext(1)]
		public unsafe static string ConvertToAbsolutePath(string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			string result = FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__ConvertToAbsolutePath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0003E1C1 File Offset: 0x0003C3C1
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef([Nullable(2)] in FSoftObjectPath SoftObjectPath)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__Conv_SoftObjPathToSoftObjRef_Internal((SoftObjectPath ?? new FSoftObjectPath()).NativePtr), true, true);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x0003E1DF File Offset: 0x0003C3DF
		[NullableContext(1)]
		public static string Conv_SoftObjectReferenceToString(in TSoftObjectPtr<UObject> SoftObjectReference)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_SoftObjectReferenceToString_Internal((SoftObjectReference ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0003E1FB File Offset: 0x0003C3FB
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UObject Conv_SoftObjectReferenceToObject(in TSoftObjectPtr<UObject> SoftObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__Conv_SoftObjectReferenceToObject_Internal((SoftObject ?? new TSoftObjectPtr<UObject>()).NativePtr));
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0003E217 File Offset: 0x0003C417
		[NullableContext(1)]
		public static string Conv_SoftClassReferenceToString(in TSoftClassPtr<UObject> SoftClassReference)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_SoftClassReferenceToString_Internal((SoftClassReference ?? new TSoftClassPtr<UObject>()).NativePtr));
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x0003E233 File Offset: 0x0003C433
		[NullableContext(1)]
		public static UClassStackOnlyPtr Conv_SoftClassReferenceToClass(in TSoftClassPtr<UObject> SoftClass)
		{
			return UKismetSystemLibrary.__Conv_SoftClassReferenceToClass_Internal((SoftClass ?? new TSoftClassPtr<UObject>()).NativePtr);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0003E24F File Offset: 0x0003C44F
		[NullableContext(1)]
		public static TSoftClassPtr<UObject> Conv_SoftClassPathToSoftClassRef([Nullable(2)] in FSoftClassPath SoftClassPath)
		{
			return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__Conv_SoftClassPathToSoftClassRef_Internal((SoftClassPath ?? new FSoftClassPath()).NativePtr), null);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0003E26C File Offset: 0x0003C46C
		[NullableContext(1)]
		public static string Conv_PrimaryAssetTypeToString([Nullable(2)] FPrimaryAssetType PrimaryAssetType)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_PrimaryAssetTypeToString_Internal((PrimaryAssetType ?? new FPrimaryAssetType()).NativePtr));
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x0003E287 File Offset: 0x0003C487
		[NullableContext(1)]
		public static string Conv_PrimaryAssetIdToString([Nullable(2)] FPrimaryAssetId PrimaryAssetId)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetSystemLibrary.__Conv_PrimaryAssetIdToString_Internal((PrimaryAssetId ?? new FPrimaryAssetId()).NativePtr));
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x0003E2A2 File Offset: 0x0003C4A2
		[NullableContext(1)]
		public static TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference([Nullable(2)] UObject Object)
		{
			return new TSoftObjectPtr<UObject>(UKismetSystemLibrary.__Conv_ObjectToSoftObjectReference_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero), true, true);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x0003E2C0 File Offset: 0x0003C4C0
		public unsafe static UObject Conv_InterfaceToObject(in FScriptInterface Interface)
		{
			fixed (FScriptInterface* ptr = &Interface)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetSystemLibrary.__Conv_InterfaceToObject_Internal(Interface));
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0003E2E0 File Offset: 0x0003C4E0
		[NullableContext(1)]
		public unsafe static TSoftClassPtr<UObject> Conv_ClassToSoftClassReference(in UClassStackOnlyPtr Class)
		{
			fixed (UClassStackOnlyPtr* ptr = &Class)
			{
				void* ptr2 = (void*)ptr;
				return new TSoftClassPtr<UObject>(UKismetSystemLibrary.__Conv_ClassToSoftClassReference_Internal(Class._NativePtr), null);
			}
		}

		// Token: 0x06002BA7 RID: 11175
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ControlScreensaver(bool bAllowScreenSaver);

		// Token: 0x06002BA8 RID: 11176 RVA: 0x0003E304 File Offset: 0x0003C504
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

		// Token: 0x06002BA9 RID: 11177 RVA: 0x0003E37C File Offset: 0x0003C57C
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

		// Token: 0x06002BAA RID: 11178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CollectGarbage();

		// Token: 0x06002BAB RID: 11179 RVA: 0x0003E3F4 File Offset: 0x0003C5F4
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

		// Token: 0x06002BAC RID: 11180 RVA: 0x0003E4F8 File Offset: 0x0003C6F8
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

		// Token: 0x06002BAD RID: 11181 RVA: 0x0003E5EC File Offset: 0x0003C7EC
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

		// Token: 0x06002BAE RID: 11182 RVA: 0x0003E6E4 File Offset: 0x0003C8E4
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

		// Token: 0x06002BAF RID: 11183 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
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

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0003E8DC File Offset: 0x0003CADC
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

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0003E9D4 File Offset: 0x0003CBD4
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

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0003EA34 File Offset: 0x0003CC34
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

		// Token: 0x06002BB3 RID: 11187 RVA: 0x0003EA94 File Offset: 0x0003CC94
		[NullableContext(1)]
		public unsafe static bool CanLaunchURL(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			bool result = UKismetSystemLibrary.__CanLaunchURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002BB4 RID: 11188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelTransaction(int Index);

		// Token: 0x06002BB5 RID: 11189 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
		[NullableContext(1)]
		public unsafe static void BreakTopLevelAssetPath([Nullable(2)] in FTopLevelAssetPath TopLevelAssetPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakTopLevelAssetPath_Internal((TopLevelAssetPath ?? new FTopLevelAssetPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		[NullableContext(1)]
		public unsafe static void BreakSoftObjectPath([Nullable(2)] FSoftObjectPath InSoftObjectPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakSoftObjectPath_Internal((InSoftObjectPath ?? new FSoftObjectPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0003EB38 File Offset: 0x0003CD38
		[NullableContext(1)]
		public unsafe static void BreakSoftClassPath([Nullable(2)] FSoftClassPath InSoftClassPath, ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			UKismetSystemLibrary.__BreakSoftClassPath_Internal((InSoftClassPath ?? new FSoftClassPath()).NativePtr, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0003EB78 File Offset: 0x0003CD78
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

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0003EC7C File Offset: 0x0003CE7C
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

		// Token: 0x06002BBA RID: 11194 RVA: 0x0003ED70 File Offset: 0x0003CF70
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

		// Token: 0x06002BBB RID: 11195 RVA: 0x0003EE68 File Offset: 0x0003D068
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

		// Token: 0x06002BBC RID: 11196 RVA: 0x0003EF6C File Offset: 0x0003D16C
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

		// Token: 0x06002BBD RID: 11197 RVA: 0x0003F060 File Offset: 0x0003D260
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

		// Token: 0x06002BBE RID: 11198 RVA: 0x0003F158 File Offset: 0x0003D358
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

		// Token: 0x06002BBF RID: 11199 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
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

		// Token: 0x06002BC0 RID: 11200 RVA: 0x0003F218 File Offset: 0x0003D418
		[NullableContext(1)]
		public unsafe static int BeginTransaction(string Context, FText Description, [Nullable(2)] UObject PrimaryObject)
		{
			FString fstring = FString.AllocTemp(Context);
			int result = UKismetSystemLibrary.__BeginTransaction_Internal(fstring, (Description != null) ? Description.NativePtr : IntPtr.Zero, (PrimaryObject != null) ? PrimaryObject.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002BC1 RID: 11201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadPrimaryAssetList_Internal(IntPtr PrimaryAssetIdList);

		// Token: 0x06002BC2 RID: 11202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnloadPrimaryAsset_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002BC3 RID: 11203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TransactObject_Internal(IntPtr Object);

		// Token: 0x06002BC4 RID: 11204
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BC5 RID: 11205
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BC6 RID: 11206
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BC7 RID: 11207
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BC8 RID: 11208
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BC9 RID: 11209
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BCA RID: 11210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereOverlapComponents_Internal(IntPtr WorldContextObject, FVector SpherePos, float SphereRadius, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x06002BCB RID: 11211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereOverlapActors_Internal(IntPtr WorldContextObject, FVector SpherePos, float SphereRadius, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x06002BCC RID: 11212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapshotObject_Internal(IntPtr Object);

		// Token: 0x06002BCD RID: 11213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowPlatformSpecificLeaderboardScreen_Internal(in FString CategoryName);

		// Token: 0x06002BCE RID: 11214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowPlatformSpecificAchievementsScreen_Internal(IntPtr SpecificPlayer);

		// Token: 0x06002BCF RID: 11215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowTitle_Internal(IntPtr Title);

		// Token: 0x06002BD0 RID: 11216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FVector Value);

		// Token: 0x06002BD1 RID: 11217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, in FVectorDouble Value);

		// Token: 0x06002BD2 RID: 11218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformPropertyByName_Internal(IntPtr Object, FName PropertyName, in FTransform Value);

		// Token: 0x06002BD3 RID: 11219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, in FTransformDouble Value);

		// Token: 0x06002BD4 RID: 11220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x06002BD5 RID: 11221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSuppressViewportTransitionMessage_Internal(IntPtr WorldContextObject, bool bState);

		// Token: 0x06002BD6 RID: 11222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStringPropertyByName_Internal(IntPtr Object, FName PropertyName, in FString Value);

		// Token: 0x06002BD7 RID: 11223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftObjectPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x06002BD8 RID: 11224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSoftClassPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x06002BD9 RID: 11225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotatorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FRotator Value);

		// Token: 0x06002BDA RID: 11226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x06002BDB RID: 11227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNamePropertyByName_Internal(IntPtr Object, FName PropertyName, in FName Value);

		// Token: 0x06002BDC RID: 11228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearColorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FLinearColor Value);

		// Token: 0x06002BDD RID: 11229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntPropertyByName_Internal(IntPtr Object, FName PropertyName, int Value);

		// Token: 0x06002BDE RID: 11230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInterfacePropertyByName_Internal(IntPtr Object, FName PropertyName, in FScriptInterface Value);

		// Token: 0x06002BDF RID: 11231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInt64PropertyByName_Internal(IntPtr Object, FName PropertyName, long Value);

		// Token: 0x06002BE0 RID: 11232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatPropertyByName_Internal(IntPtr Object, FName PropertyName, float Value);

		// Token: 0x06002BE1 RID: 11233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDoublePropertyByName_Internal(IntPtr Object, FName PropertyName, double Value);

		// Token: 0x06002BE2 RID: 11234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorPropertyByName_Internal(IntPtr Object, FName PropertyName, in FColor Value);

		// Token: 0x06002BE3 RID: 11235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClassPropertyByName_Internal(IntPtr Object, FName PropertyName, IntPtr Value);

		// Token: 0x06002BE4 RID: 11236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBytePropertyByName_Internal(IntPtr Object, FName PropertyName, byte Value);

		// Token: 0x06002BE5 RID: 11237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolPropertyByName_Internal(IntPtr Object, FName PropertyName, bool Value);

		// Token: 0x06002BE6 RID: 11238
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetAllChannels_Internal(IntPtr ResponseToChannels, TEnumAsByte<ECollisionResponse> NewResponse);

		// Token: 0x06002BE7 RID: 11239
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RHIName_Internal();

		// Token: 0x06002BE8 RID: 11240
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __QuitGame_Internal(IntPtr WorldContextObject, IntPtr SpecificPlayer, TEnumAsByte<EQuitPreference> QuitPreference, bool bIgnorePlatformRestrictions);

		// Token: 0x06002BE9 RID: 11241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintWarning_Internal(in FString InString);

		// Token: 0x06002BEA RID: 11242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintText_Internal(IntPtr WorldContextObject, IntPtr InText, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration);

		// Token: 0x06002BEB RID: 11243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintString_Internal(IntPtr WorldContextObject, in FString InString, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration);

		// Token: 0x06002BEC RID: 11244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ParseParamValue_Internal(in FString InString, in FString InParam, ref FString OutValue);

		// Token: 0x06002BED RID: 11245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ParseParam_Internal(in FString InString, in FString InParam);

		// Token: 0x06002BEE RID: 11246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ParseCommandLine_Internal(in FString InCmdLine, IntPtr OutTokens, IntPtr OutSwitches, IntPtr OutParams);

		// Token: 0x06002BEF RID: 11247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_SoftObjectReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002BF0 RID: 11248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_SoftClassReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002BF1 RID: 11249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_PrimaryAssetType_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002BF2 RID: 11250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_PrimaryAssetId_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002BF3 RID: 11251
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __NormalizeFilename_Internal(in FString InFilename);

		// Token: 0x06002BF4 RID: 11252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTopLevelAssetPath_Internal(in FString PackageName, in FString AssetName);

		// Token: 0x06002BF5 RID: 11253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSoftObjectPath_Internal(in FString PathString);

		// Token: 0x06002BF6 RID: 11254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSoftClassPath_Internal(in FString PathString);

		// Token: 0x06002BF7 RID: 11255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeLiteralText_Internal(IntPtr Value);

		// Token: 0x06002BF8 RID: 11256
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __MakeLiteralString_Internal(in FString Value);

		// Token: 0x06002BF9 RID: 11257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadClassAsset_Blocking_Internal(IntPtr AssetClass);

		// Token: 0x06002BFA RID: 11258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadAsset_Blocking_Internal(IntPtr Asset);

		// Token: 0x06002BFB RID: 11259
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BFC RID: 11260
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BFD RID: 11261
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BFE RID: 11262
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002BFF RID: 11263
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C00 RID: 11264
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C01 RID: 11265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchURL_Internal(in FString URL);

		// Token: 0x06002C02 RID: 11266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UnPauseTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C03 RID: 11267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UnPauseTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C04 RID: 11268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TimerExistsDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C05 RID: 11269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TimerExists_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C06 RID: 11270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PauseTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C07 RID: 11271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PauseTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C08 RID: 11272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerPausedDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C09 RID: 11273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerPaused_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C0A RID: 11274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerActiveDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C0B RID: 11275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_IsTimerActive_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C0C RID: 11276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerRemainingTimeDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C0D RID: 11277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerRemainingTime_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C0E RID: 11278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerElapsedTimeDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C0F RID: 11279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetTimerElapsedTime_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C10 RID: 11280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearTimerDelegate_Internal(IntPtr Delegate);

		// Token: 0x06002C11 RID: 11281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearTimer_Internal(IntPtr Object, in FString FunctionName);

		// Token: 0x06002C12 RID: 11282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidSoftObjectReference_Internal(IntPtr SoftObjectReference);

		// Token: 0x06002C13 RID: 11283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidSoftClassReference_Internal(IntPtr SoftClassReference);

		// Token: 0x06002C14 RID: 11284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidPrimaryAssetType_Internal(IntPtr PrimaryAssetType);

		// Token: 0x06002C15 RID: 11285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C16 RID: 11286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStandalone_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C17 RID: 11287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSplitScreen_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C18 RID: 11288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsServer_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C19 RID: 11289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLoggedIn_Internal(IntPtr SpecificPlayer);

		// Token: 0x06002C1A RID: 11290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDedicatedServer_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C1B RID: 11291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVulkanBlockedModels_Internal();

		// Token: 0x06002C1C RID: 11292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVulkanAllowedModels_Internal();

		// Token: 0x06002C1D RID: 11293
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUniqueDeviceId_Internal();

		// Token: 0x06002C1E RID: 11294
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSystemPath_Internal(IntPtr Object);

		// Token: 0x06002C1F RID: 11295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSupportedFullscreenResolutions_Internal(IntPtr Resolutions);

		// Token: 0x06002C20 RID: 11296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSoftObjectReferenceFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C21 RID: 11297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSoftClassReferenceFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C22 RID: 11298
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectSavedDirectory_Internal();

		// Token: 0x06002C23 RID: 11299
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectDirectory_Internal();

		// Token: 0x06002C24 RID: 11300
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectContentDirectory_Internal();

		// Token: 0x06002C25 RID: 11301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPrimaryAssetsWithBundleState_Internal(IntPtr RequiredBundles, IntPtr ExcludedBundles, IntPtr ValidTypes, bool bForceCurrentState, IntPtr OutPrimaryAssetIdList);

		// Token: 0x06002C26 RID: 11302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPrimaryAssetIdList_Internal(IntPtr PrimaryAssetType, IntPtr OutPrimaryAssetIdList);

		// Token: 0x06002C27 RID: 11303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromSoftObjectReference_Internal(IntPtr SoftObjectReference);

		// Token: 0x06002C28 RID: 11304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromSoftClassReference_Internal(IntPtr SoftClassReference);

		// Token: 0x06002C29 RID: 11305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromObject_Internal(IntPtr Object);

		// Token: 0x06002C2A RID: 11306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimaryAssetIdFromClass_Internal(IntPtr Class);

		// Token: 0x06002C2B RID: 11307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPreferredLanguages_Internal();

		// Token: 0x06002C2C RID: 11308
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformUserName_Internal();

		// Token: 0x06002C2D RID: 11309
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlatformUserDir_Internal();

		// Token: 0x06002C2E RID: 11310
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPathName_Internal(IntPtr Object);

		// Token: 0x06002C2F RID: 11311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOuterObject_Internal(IntPtr Object);

		// Token: 0x06002C30 RID: 11312
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetObjectName_Internal(IntPtr Object);

		// Token: 0x06002C31 RID: 11313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C32 RID: 11314
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLocalCurrencySymbol_Internal();

		// Token: 0x06002C33 RID: 11315
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLocalCurrencyCode_Internal();

		// Token: 0x06002C34 RID: 11316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameTimeInSeconds_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C35 RID: 11317
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGamepadControllerName_Internal(int ControllerId);

		// Token: 0x06002C36 RID: 11318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGamepadButtonGlyph_Internal(in FString ButtonKey, int ControllerIndex);

		// Token: 0x06002C37 RID: 11319
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameName_Internal();

		// Token: 0x06002C38 RID: 11320
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameBundleId_Internal();

		// Token: 0x06002C39 RID: 11321
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetEngineVersion_Internal();

		// Token: 0x06002C3A RID: 11322
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDisplayName_Internal(IntPtr Object);

		// Token: 0x06002C3B RID: 11323
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal();

		// Token: 0x06002C3C RID: 11324
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultLocale_Internal();

		// Token: 0x06002C3D RID: 11325
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultLanguage_Internal();

		// Token: 0x06002C3E RID: 11326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCurrentBundleState_Internal(IntPtr PrimaryAssetId, bool bForceCurrentState, IntPtr OutBundles);

		// Token: 0x06002C3F RID: 11327
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentActiveGamepadName_Internal();

		// Token: 0x06002C40 RID: 11328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConvenientWindowedResolutions_Internal(IntPtr Resolutions);

		// Token: 0x06002C41 RID: 11329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetConsoleVariableIntValue_Internal(in FString VariableName);

		// Token: 0x06002C42 RID: 11330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetConsoleVariableFloatValue_Internal(in FString VariableName);

		// Token: 0x06002C43 RID: 11331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConsoleVariableBoolValue_Internal(in FString VariableName);

		// Token: 0x06002C44 RID: 11332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetComponentBounds_Internal(IntPtr Component, ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius);

		// Token: 0x06002C45 RID: 11333
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCommandLine_Internal();

		// Token: 0x06002C46 RID: 11334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClassFromPrimaryAssetId_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C47 RID: 11335
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetClassDisplayName_Internal(IntPtr Class);

		// Token: 0x06002C48 RID: 11336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorListFromComponentList_Internal(IntPtr ComponentList, IntPtr ActorClassFilter, IntPtr OutActorList);

		// Token: 0x06002C49 RID: 11337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorBounds_Internal(IntPtr Actor, ref FVector Origin, ref FVector BoxExtent);

		// Token: 0x06002C4A RID: 11338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushPersistentDebugLines_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C4B RID: 11339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushDebugStrings_Internal(IntPtr WorldContextObject);

		// Token: 0x06002C4C RID: 11340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteConsoleCommandFromUserInput_Internal(IntPtr WorldContextObject, in FString Command, IntPtr SpecificPlayer);

		// Token: 0x06002C4D RID: 11341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteConsoleCommand_Internal(IntPtr WorldContextObject, in FString Command, IntPtr SpecificPlayer);

		// Token: 0x06002C4E RID: 11342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_SoftObjectReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002C4F RID: 11343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_SoftClassReference_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002C50 RID: 11344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_PrimaryAssetType_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002C51 RID: 11345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_PrimaryAssetId_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002C52 RID: 11346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicQueueSubtitles_Internal(IntPtr WorldContextObject, in FString InString, float Duration, int FontSize);

		// Token: 0x06002C53 RID: 11347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugString_Internal(IntPtr WorldContextObject, FVector TextLocation, in FString Text, IntPtr TestBaseActor, FLinearColor TextColor, float Duration);

		// Token: 0x06002C54 RID: 11348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugSphere_Internal(IntPtr WorldContextObject, FVector Center, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C55 RID: 11349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugPoint_Internal(IntPtr WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration);

		// Token: 0x06002C56 RID: 11350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugPlane_Internal(IntPtr WorldContextObject, in FPlane PlaneCoordinates, FVector Location, float Size, FLinearColor PlaneColor, float Duration);

		// Token: 0x06002C57 RID: 11351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugLine_Internal(IntPtr WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C58 RID: 11352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugFrustum_Internal(IntPtr WorldContextObject, in FTransform FrustumTransform, FLinearColor FrustumColor, float Duration, float Thickness);

		// Token: 0x06002C59 RID: 11353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCylinder_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C5A RID: 11354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCoordinateSystem_Internal(IntPtr WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale, float Duration, float Thickness);

		// Token: 0x06002C5B RID: 11355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugConeInDegrees_Internal(IntPtr WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C5C RID: 11356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCone_Internal(IntPtr WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C5D RID: 11357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCircle_Internal(IntPtr WorldContextObject, FVector Center, float Radius, int NumSegments, FLinearColor LineColor, float Duration, float Thickness, FVector YAxis, FVector ZAxis, bool bDrawAxis);

		// Token: 0x06002C5E RID: 11358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCapsule_Internal(IntPtr WorldContextObject, FVector Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C5F RID: 11359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugCamera_Internal(IntPtr CameraActor, FLinearColor CameraColor, float Duration);

		// Token: 0x06002C60 RID: 11360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugBox_Internal(IntPtr WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation, float Duration, float Thickness);

		// Token: 0x06002C61 RID: 11361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugArrow_Internal(IntPtr WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C62 RID: 11362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesImplementInterface_Internal(IntPtr TestObject, IntPtr Interface);

		// Token: 0x06002C63 RID: 11363
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C64 RID: 11364
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C65 RID: 11365
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C66 RID: 11366
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C67 RID: 11367
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C68 RID: 11368
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_SphereTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C69 RID: 11369
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6A RID: 11370
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6B RID: 11371
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6C RID: 11372
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6D RID: 11373
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6E RID: 11374
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_LineTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C6F RID: 11375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugString_Internal(IntPtr WorldContextObject, FVectorDouble TextLocation, in FString Text, IntPtr TestBaseActor, FLinearColor TextColor, float Duration);

		// Token: 0x06002C70 RID: 11376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugSphere_Internal(IntPtr WorldContextObject, FVectorDouble Center, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C71 RID: 11377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugPoint_Internal(IntPtr WorldContextObject, FVectorDouble Position, float Size, FLinearColor PointColor, float Duration);

		// Token: 0x06002C72 RID: 11378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugPlane_Internal(IntPtr WorldContextObject, in FPlane PlaneCoordinates, FVectorDouble Location, float Size, FLinearColor PlaneColor, float Duration);

		// Token: 0x06002C73 RID: 11379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugLine_Internal(IntPtr WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C74 RID: 11380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCylinder_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C75 RID: 11381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCoordinateSystem_Internal(IntPtr WorldContextObject, FVectorDouble AxisLoc, FRotator AxisRot, float Scale, float Duration, float Thickness);

		// Token: 0x06002C76 RID: 11382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugConeInDegrees_Internal(IntPtr WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C77 RID: 11383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCone_Internal(IntPtr WorldContextObject, FVectorDouble Origin, FVectorDouble Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C78 RID: 11384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCircle_Internal(IntPtr WorldContextObject, FVectorDouble Center, float Radius, int NumSegments, FLinearColor LineColor, float Duration, float Thickness, FVectorDouble YAxis, FVectorDouble ZAxis, bool bDrawAxis);

		// Token: 0x06002C79 RID: 11385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugCapsule_Internal(IntPtr WorldContextObject, FVectorDouble Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C7A RID: 11386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugBox_Internal(IntPtr WorldContextObject, FVectorDouble Center, FVectorDouble Extent, FLinearColor LineColor, FRotator Rotation, float Duration, float Thickness);

		// Token: 0x06002C7B RID: 11387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_DrawDebugArrow_Internal(IntPtr WorldContextObject, FVectorDouble LineStart, FVectorDouble LineEnd, float ArrowSize, FLinearColor LineColor, float Duration, float Thickness);

		// Token: 0x06002C7C RID: 11388
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C7D RID: 11389
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C7E RID: 11390
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C7F RID: 11391
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C80 RID: 11392
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C81 RID: 11393
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_CapsuleTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C82 RID: 11394
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C83 RID: 11395
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C84 RID: 11396
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceSingle_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C85 RID: 11397
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C86 RID: 11398
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C87 RID: 11399
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_BoxTraceMulti_Internal(IntPtr WorldContextObject, FVectorDouble Start, FVectorDouble End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C88 RID: 11400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateCopyForUndoBuffer_Internal(IntPtr ObjectToModify);

		// Token: 0x06002C89 RID: 11401
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToRelativePath_Internal(in FString Filename);

		// Token: 0x06002C8A RID: 11402
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToAbsolutePath_Internal(in FString Filename);

		// Token: 0x06002C8B RID: 11403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftObjPathToSoftObjRef_Internal(IntPtr SoftObjectPath);

		// Token: 0x06002C8C RID: 11404
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_SoftObjectReferenceToString_Internal(IntPtr SoftObjectReference);

		// Token: 0x06002C8D RID: 11405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftObjectReferenceToObject_Internal(IntPtr SoftObject);

		// Token: 0x06002C8E RID: 11406
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_SoftClassReferenceToString_Internal(IntPtr SoftClassReference);

		// Token: 0x06002C8F RID: 11407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftClassReferenceToClass_Internal(IntPtr SoftClass);

		// Token: 0x06002C90 RID: 11408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_SoftClassPathToSoftClassRef_Internal(IntPtr SoftClassPath);

		// Token: 0x06002C91 RID: 11409
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_PrimaryAssetTypeToString_Internal(IntPtr PrimaryAssetType);

		// Token: 0x06002C92 RID: 11410
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_PrimaryAssetIdToString_Internal(IntPtr PrimaryAssetId);

		// Token: 0x06002C93 RID: 11411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ObjectToSoftObjectReference_Internal(IntPtr Object);

		// Token: 0x06002C94 RID: 11412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_InterfaceToObject_Internal(in FScriptInterface Interface);

		// Token: 0x06002C95 RID: 11413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ClassToSoftClassReference_Internal(in IntPtr Class);

		// Token: 0x06002C96 RID: 11414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentOverlapComponents_Internal(IntPtr Component, in FTransform ComponentTransform, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x06002C97 RID: 11415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentOverlapActors_Internal(IntPtr Component, in FTransform ComponentTransform, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x06002C98 RID: 11416
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C99 RID: 11417
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C9A RID: 11418
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C9B RID: 11419
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C9C RID: 11420
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C9D RID: 11421
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002C9E RID: 11422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleOverlapComponents_Internal(IntPtr WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x06002C9F RID: 11423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleOverlapActors_Internal(IntPtr WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x06002CA0 RID: 11424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanLaunchURL_Internal(in FString URL);

		// Token: 0x06002CA1 RID: 11425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTopLevelAssetPath_Internal(IntPtr TopLevelAssetPath, ref FString PathString);

		// Token: 0x06002CA2 RID: 11426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSoftObjectPath_Internal(IntPtr InSoftObjectPath, ref FString PathString);

		// Token: 0x06002CA3 RID: 11427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSoftClassPath_Internal(IntPtr InSoftClassPath, ref FString PathString);

		// Token: 0x06002CA4 RID: 11428
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingleForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CA5 RID: 11429
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingleByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CA6 RID: 11430
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceSingle_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CA7 RID: 11431
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMultiForObjects_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CA8 RID: 11432
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMultiByProfile_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CA9 RID: 11433
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTraceMulti_Internal(IntPtr WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr ActorsToIgnore, TEnumAsByte<EDrawDebugTrace> DrawDebugType, IntPtr OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime);

		// Token: 0x06002CAA RID: 11434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapComponents_Internal(IntPtr WorldContextObject, FVector BoxPos, FVector Extent, IntPtr ObjectTypes, IntPtr ComponentClassFilter, IntPtr ActorsToIgnore, IntPtr OutComponents);

		// Token: 0x06002CAB RID: 11435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapActors_Internal(IntPtr WorldContextObject, FVector BoxPos, FVector BoxExtent, IntPtr ObjectTypes, IntPtr ActorClassFilter, IntPtr ActorsToIgnore, IntPtr OutActors);

		// Token: 0x06002CAC RID: 11436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __BeginTransaction_Internal(in FString Context, IntPtr Description, IntPtr PrimaryObject);

		// Token: 0x06002CAD RID: 11437 RVA: 0x0003F25C File Offset: 0x0003D45C
		static UKismetSystemLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetSystemLibrary");
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0003F26A File Offset: 0x0003D46A
		protected UKismetSystemLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E1D RID: 3613
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetSystemLibrary";

		// Token: 0x04000E1E RID: 3614
		private static IntPtr _ClassPtr;

		// Token: 0x04000E1F RID: 3615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E20 RID: 3616
		public static IntPtr __OnAssetLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000E21 RID: 3617
		public static IntPtr __OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000E22 RID: 3618
		private static IntPtr __StackTrace_NativeFunctionPtr;

		// Token: 0x04000E23 RID: 3619
		private static IntPtr __SetFieldPathPropertyByName_NativeFunctionPtr;

		// Token: 0x04000E24 RID: 3620
		private static IntPtr __SetCollisionProfileNameProperty_NativeFunctionPtr;

		// Token: 0x020009B4 RID: 2484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetFieldPathPropertyByName_FunctionParams
		{
			// Token: 0x04005935 RID: 22837
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04005936 RID: 22838
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x04005937 RID: 22839
			[Nullable(1)]
			[FieldOffset(24)]
			public Unusable Value;
		}

		// Token: 0x020009B5 RID: 2485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetCollisionProfileNameProperty_FunctionParams
		{
			// Token: 0x04005938 RID: 22840
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04005939 RID: 22841
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x0400593A RID: 22842
			[FieldOffset(20)]
			public byte Value;
		}
	}
}
