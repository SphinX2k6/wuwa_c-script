using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F2 RID: 1010
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLevelPlayLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006358 RID: 25432 RVA: 0x0008E14B File Offset: 0x0008C34B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayLibrary._ClassPtr;
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x0008E158 File Offset: 0x0008C358
		public UKuroLevelPlayLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x0008E180 File Offset: 0x0008C380
		[NullableContext(1)]
		public UKuroLevelPlayLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x0008E1B4 File Offset: 0x0008C3B4
		[NullableContext(1)]
		public unsafe static void RegisterBaseItemInfo(UClassStackOnlyPtr BaseItemClass, string EntityIdName)
		{
			FString fstring = FString.AllocTemp(EntityIdName);
			UKuroLevelPlayLibrary.__RegisterBaseItemInfo_Internal(BaseItemClass._NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x0008E1DE File Offset: 0x0008C3DE
		public static bool IsSimulatePhysics(UPrimitiveComponent PrimitiveComponent)
		{
			return UKuroLevelPlayLibrary.__IsSimulatePhysics_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x0008E1F8 File Offset: 0x0008C3F8
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UWorld GetWorldInPackage(string PackageName)
		{
			FString fstring = FString.AllocTemp(PackageName);
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UKuroLevelPlayLibrary.__GetWorldInPackage_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x0008E224 File Offset: 0x0008C424
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

		// Token: 0x0600635F RID: 25439 RVA: 0x0008E258 File Offset: 0x0008C458
		public static int GetEntityIdByBaseItem(AActor Actor)
		{
			return UKuroLevelPlayLibrary.__GetEntityIdByBaseItem_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x0008E26F File Offset: 0x0008C46F
		[NullableContext(1)]
		public static string GetCurrentLevelRefPath([Nullable(2)] UObject WorldContextObject)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLevelPlayLibrary.__GetCurrentLevelRefPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x0008E28B File Offset: 0x0008C48B
		public static void GetAllActorsInPersistentLevel(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutLevelActors)
		{
			UKuroLevelPlayLibrary.__GetAllActorsInPersistentLevel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutLevelActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
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

		// Token: 0x06006363 RID: 25443 RVA: 0x0008E2F2 File Offset: 0x0008C4F2
		public static FBox GetActorComponentsBoundingBox(AActor Actor, bool bNonColliding = false, bool bIncludeFromChildActors = false)
		{
			return UKuroLevelPlayLibrary.__GetActorComponentsBoundingBox_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bNonColliding, bIncludeFromChildActors);
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x0008E30B File Offset: 0x0008C50B
		public static void FakeRemoveAlwaysLoadedActorsFromWorld(UWorld World)
		{
			UKuroLevelPlayLibrary.__FakeRemoveAlwaysLoadedActorsFromWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0008E322 File Offset: 0x0008C522
		public static void FakeAddAlwaysLoadedActorsToWorld(UWorld World)
		{
			UKuroLevelPlayLibrary.__FakeAddAlwaysLoadedActorsToWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x0008E339 File Offset: 0x0008C539
		public static void ApplyWorldOffset(USceneComponent SceneComponent, in FVector InWorldOffset, bool bWorldShift)
		{
			UKuroLevelPlayLibrary.__ApplyWorldOffset_Internal((SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, InWorldOffset, bWorldShift);
		}

		// Token: 0x06006367 RID: 25447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBaseItemInfo_Internal(IntPtr BaseItemClass, in FString EntityIdName);

		// Token: 0x06006368 RID: 25448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSimulatePhysics_Internal(IntPtr PrimitiveComponent);

		// Token: 0x06006369 RID: 25449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldInPackage_Internal(in FString PackageName);

		// Token: 0x0600636A RID: 25450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPersistentLevelActorsInPackage_Internal(in FString PackageName, IntPtr OutLevelActors);

		// Token: 0x0600636B RID: 25451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEntityIdByBaseItem_Internal(IntPtr Actor);

		// Token: 0x0600636C RID: 25452
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLevelRefPath_Internal(IntPtr WorldContextObject);

		// Token: 0x0600636D RID: 25453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllActorsInPersistentLevel_Internal(IntPtr WorldContextObject, IntPtr OutLevelActors);

		// Token: 0x0600636E RID: 25454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorScreenBoundingBox_Internal(IntPtr PlayerController, IntPtr Actor, ref FVector2D ScreenMin, ref FVector2D ScreenMax);

		// Token: 0x0600636F RID: 25455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetActorComponentsBoundingBox_Internal(IntPtr Actor, bool bNonColliding, bool bIncludeFromChildActors);

		// Token: 0x06006370 RID: 25456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FakeRemoveAlwaysLoadedActorsFromWorld_Internal(IntPtr World);

		// Token: 0x06006371 RID: 25457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FakeAddAlwaysLoadedActorsToWorld_Internal(IntPtr World);

		// Token: 0x06006372 RID: 25458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyWorldOffset_Internal(IntPtr SceneComponent, in FVector InWorldOffset, bool bWorldShift);

		// Token: 0x06006373 RID: 25459 RVA: 0x0008E352 File Offset: 0x0008C552
		static UKuroLevelPlayLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayLibrary");
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x0008E360 File Offset: 0x0008C560
		protected UKuroLevelPlayLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A05 RID: 10757
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayLibrary";

		// Token: 0x04002A06 RID: 10758
		private static IntPtr _ClassPtr;

		// Token: 0x04002A07 RID: 10759
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
