using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018ED RID: 6381
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLevelPlayLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017A94 RID: 96916 RVA: 0x0022ADAE File Offset: 0x00228FAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayLibrary._ClassPtr;
		}

		// Token: 0x06017A95 RID: 96917 RVA: 0x0022ADBC File Offset: 0x00228FBC
		public UKuroLevelPlayLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017A96 RID: 96918 RVA: 0x0022ADE4 File Offset: 0x00228FE4
		[NullableContext(1)]
		public UKuroLevelPlayLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017A97 RID: 96919 RVA: 0x0022AE18 File Offset: 0x00229018
		[NullableContext(1)]
		public unsafe static void RegisterBaseItemInfo(UClassStackOnlyPtr BaseItemClass, string EntityIdName)
		{
			FString fstring = FString.AllocTemp(EntityIdName);
			UKuroLevelPlayLibrary.__RegisterBaseItemInfo_Internal(BaseItemClass._NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06017A98 RID: 96920 RVA: 0x0022AE42 File Offset: 0x00229042
		public static bool IsSimulatePhysics(UPrimitiveComponent PrimitiveComponent)
		{
			return UKuroLevelPlayLibrary.__IsSimulatePhysics_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017A99 RID: 96921 RVA: 0x0022AE5C File Offset: 0x0022905C
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UWorld GetWorldInPackage(string PackageName)
		{
			FString fstring = FString.AllocTemp(PackageName);
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UKuroLevelPlayLibrary.__GetWorldInPackage_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06017A9A RID: 96922 RVA: 0x0022AE88 File Offset: 0x00229088
		[NullableContext(1)]
		public unsafe static void GetPersistentLevelActorsInPackage(string PackageName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutLevelActors)
		{
			FString fstring = FString.AllocTemp(PackageName);
			UKuroLevelPlayLibrary.__GetPersistentLevelActorsInPackage_Internal(fstring, (OutLevelActors ?? new TArray<AActor>()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06017A9B RID: 96923 RVA: 0x0022AEBC File Offset: 0x002290BC
		public static int GetEntityIdByBaseItem(AActor Actor)
		{
			return UKuroLevelPlayLibrary.__GetEntityIdByBaseItem_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017A9C RID: 96924 RVA: 0x0022AED3 File Offset: 0x002290D3
		[NullableContext(1)]
		public static string GetCurrentLevelRefPath([Nullable(2)] UObject WorldContextObject)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLevelPlayLibrary.__GetCurrentLevelRefPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06017A9D RID: 96925 RVA: 0x0022AEEF File Offset: 0x002290EF
		public static void GetAllActorsInPersistentLevel(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutLevelActors)
		{
			UKuroLevelPlayLibrary.__GetAllActorsInPersistentLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutLevelActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06017A9E RID: 96926 RVA: 0x0022AF18 File Offset: 0x00229118
		public unsafe static bool GetActorScreenBoundingBox(APlayerController PlayerController, AActor Actor, ref FVector2D ScreenMin, ref FVector2D ScreenMax)
		{
			fixed (FVector2D* ptr = &ScreenMin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector2D* ptr3 = &ScreenMax)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroLevelPlayLibrary.__GetActorScreenBoundingBox_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref ScreenMin, ref ScreenMax);
				}
			}
		}

		// Token: 0x06017A9F RID: 96927 RVA: 0x0022AF56 File Offset: 0x00229156
		public static FBox GetActorComponentsBoundingBox(AActor Actor, bool bNonColliding = false, bool bIncludeFromChildActors = false)
		{
			return UKuroLevelPlayLibrary.__GetActorComponentsBoundingBox_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bNonColliding, bIncludeFromChildActors);
		}

		// Token: 0x06017AA0 RID: 96928 RVA: 0x0022AF6F File Offset: 0x0022916F
		public static void FakeRemoveAlwaysLoadedActorsFromWorld(UWorld World)
		{
			UKuroLevelPlayLibrary.__FakeRemoveAlwaysLoadedActorsFromWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017AA1 RID: 96929 RVA: 0x0022AF86 File Offset: 0x00229186
		public static void FakeAddAlwaysLoadedActorsToWorld(UWorld World)
		{
			UKuroLevelPlayLibrary.__FakeAddAlwaysLoadedActorsToWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017AA2 RID: 96930 RVA: 0x0022AF9D File Offset: 0x0022919D
		public static void ApplyWorldOffset(USceneComponent SceneComponent, in FVector InWorldOffset, bool bWorldShift)
		{
			UKuroLevelPlayLibrary.__ApplyWorldOffset_Internal((SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, InWorldOffset, bWorldShift);
		}

		// Token: 0x06017AA3 RID: 96931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBaseItemInfo_Internal(IntPtr BaseItemClass, in FString EntityIdName);

		// Token: 0x06017AA4 RID: 96932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulatePhysics_Internal(IntPtr PrimitiveComponent);

		// Token: 0x06017AA5 RID: 96933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldInPackage_Internal(in FString PackageName);

		// Token: 0x06017AA6 RID: 96934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPersistentLevelActorsInPackage_Internal(in FString PackageName, IntPtr OutLevelActors);

		// Token: 0x06017AA7 RID: 96935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEntityIdByBaseItem_Internal(IntPtr Actor);

		// Token: 0x06017AA8 RID: 96936
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLevelRefPath_Internal(IntPtr WorldContextObject);

		// Token: 0x06017AA9 RID: 96937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsInPersistentLevel_Internal(IntPtr WorldContextObject, IntPtr OutLevelActors);

		// Token: 0x06017AAA RID: 96938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorScreenBoundingBox_Internal(IntPtr PlayerController, IntPtr Actor, ref FVector2D ScreenMin, ref FVector2D ScreenMax);

		// Token: 0x06017AAB RID: 96939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetActorComponentsBoundingBox_Internal(IntPtr Actor, bool bNonColliding, bool bIncludeFromChildActors);

		// Token: 0x06017AAC RID: 96940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FakeRemoveAlwaysLoadedActorsFromWorld_Internal(IntPtr World);

		// Token: 0x06017AAD RID: 96941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FakeAddAlwaysLoadedActorsToWorld_Internal(IntPtr World);

		// Token: 0x06017AAE RID: 96942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyWorldOffset_Internal(IntPtr SceneComponent, in FVector InWorldOffset, bool bWorldShift);

		// Token: 0x06017AAF RID: 96943 RVA: 0x0022AFB6 File Offset: 0x002291B6
		static UKuroLevelPlayLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayLibrary");
		}

		// Token: 0x06017AB0 RID: 96944 RVA: 0x0022AFC4 File Offset: 0x002291C4
		protected UKuroLevelPlayLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDA2 RID: 52642
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayLibrary";

		// Token: 0x0400CDA3 RID: 52643
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDA4 RID: 52644
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
