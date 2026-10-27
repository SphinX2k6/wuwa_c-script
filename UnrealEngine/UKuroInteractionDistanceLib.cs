using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B28 RID: 6952
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionDistanceLib")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInteractionDistanceLib : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A3AF RID: 107439 RVA: 0x0026B70B File Offset: 0x0026990B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInteractionDistanceLib._ClassPtr;
		}

		// Token: 0x0601A3B0 RID: 107440 RVA: 0x0026B718 File Offset: 0x00269918
		public UKuroInteractionDistanceLib() : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionDistanceLib.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A3B1 RID: 107441 RVA: 0x0026B740 File Offset: 0x00269940
		[NullableContext(1)]
		public UKuroInteractionDistanceLib(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionDistanceLib.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A3B2 RID: 107442 RVA: 0x0026B773 File Offset: 0x00269973
		[NullableContext(1)]
		public static TArray<AActor> SortActorsByDistance([Nullable(2)] AActor SourceActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bUse2D = false)
		{
			return new TArray<AActor>(UKuroInteractionDistanceLib.__SortActorsByDistance_Internal((SourceActor != null) ? SourceActor.NativePtr : IntPtr.Zero, (Actors ?? new TArray<AActor>()).NativePtr, bUse2D), null);
		}

		// Token: 0x0601A3B3 RID: 107443
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SmoothInterpTo(float Current, float Target, float DeltaTime, float InterpSpeed, float Tolerance = 0.01f);

		// Token: 0x0601A3B4 RID: 107444 RVA: 0x0026B7A1 File Offset: 0x002699A1
		public static void SetMPCVectorParameter(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, FLinearColor Value)
		{
			UKuroInteractionDistanceLib.__SetMPCVectorParameter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, Value);
		}

		// Token: 0x0601A3B5 RID: 107445 RVA: 0x0026B7CA File Offset: 0x002699CA
		public static void SetMPCScalarParameter(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float Value, bool bForceUpdate = false)
		{
			UKuroInteractionDistanceLib.__SetMPCScalarParameter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName, Value, bForceUpdate);
		}

		// Token: 0x0601A3B6 RID: 107446
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NormalizeDistance(float Distance, float MinDistance, float MaxDistance, bool bClamp = true);

		// Token: 0x0601A3B7 RID: 107447 RVA: 0x0026B7F8 File Offset: 0x002699F8
		public unsafe static bool IsActorWithinLocationDistance2D(AActor Actor, FVector Location, float Distance, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroInteractionDistanceLib.__IsActorWithinLocationDistance2D_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Location, Distance, ref OutDistance);
			}
		}

		// Token: 0x0601A3B8 RID: 107448 RVA: 0x0026B824 File Offset: 0x00269A24
		public unsafe static bool IsActorWithinLocationDistance(AActor Actor, FVector Location, float Distance, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroInteractionDistanceLib.__IsActorWithinLocationDistance_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Location, Distance, ref OutDistance);
			}
		}

		// Token: 0x0601A3B9 RID: 107449 RVA: 0x0026B850 File Offset: 0x00269A50
		public unsafe static bool IsActorWithinDistance2D(AActor ActorA, AActor ActorB, float Distance, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroInteractionDistanceLib.__IsActorWithinDistance2D_Internal((ActorA != null) ? ActorA.NativePtr : IntPtr.Zero, (ActorB != null) ? ActorB.NativePtr : IntPtr.Zero, Distance, ref OutDistance);
			}
		}

		// Token: 0x0601A3BA RID: 107450 RVA: 0x0026B88C File Offset: 0x00269A8C
		public unsafe static bool IsActorWithinDistance(AActor ActorA, AActor ActorB, float Distance, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroInteractionDistanceLib.__IsActorWithinDistance_Internal((ActorA != null) ? ActorA.NativePtr : IntPtr.Zero, (ActorB != null) ? ActorB.NativePtr : IntPtr.Zero, Distance, ref OutDistance);
			}
		}

		// Token: 0x0601A3BB RID: 107451 RVA: 0x0026B8C5 File Offset: 0x00269AC5
		public static float GetMPCScalarParameter(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
		{
			return UKuroInteractionDistanceLib.__GetMPCScalarParameter_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Collection != null) ? Collection.NativePtr : IntPtr.Zero, ParameterName);
		}

		// Token: 0x0601A3BC RID: 107452
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDistanceBetweenLocations2D(FVector LocationA, FVector LocationB);

		// Token: 0x0601A3BD RID: 107453
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDistanceBetweenLocations(FVector LocationA, FVector LocationB);

		// Token: 0x0601A3BE RID: 107454 RVA: 0x0026B8ED File Offset: 0x00269AED
		public static float GetDistanceBetweenActors2D(AActor ActorA, AActor ActorB)
		{
			return UKuroInteractionDistanceLib.__GetDistanceBetweenActors2D_Internal((ActorA != null) ? ActorA.NativePtr : IntPtr.Zero, (ActorB != null) ? ActorB.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A3BF RID: 107455 RVA: 0x0026B914 File Offset: 0x00269B14
		public static float GetDistanceBetweenActors(AActor ActorA, AActor ActorB)
		{
			return UKuroInteractionDistanceLib.__GetDistanceBetweenActors_Internal((ActorA != null) ? ActorA.NativePtr : IntPtr.Zero, (ActorB != null) ? ActorB.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A3C0 RID: 107456 RVA: 0x0026B93B File Offset: 0x00269B3B
		public static float GetDistanceActorToLocation2D(AActor Actor, FVector Location)
		{
			return UKuroInteractionDistanceLib.__GetDistanceActorToLocation2D_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x0601A3C1 RID: 107457 RVA: 0x0026B953 File Offset: 0x00269B53
		public static float GetDistanceActorToLocation(AActor Actor, FVector Location)
		{
			return UKuroInteractionDistanceLib.__GetDistanceActorToLocation_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Location);
		}

		// Token: 0x0601A3C2 RID: 107458 RVA: 0x0026B96B File Offset: 0x00269B6B
		[NullableContext(1)]
		public static TArray<AActor> GetActorsWithinDistance([Nullable(2)] AActor SourceActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, float MaxDistance, bool bUse2D = false)
		{
			return new TArray<AActor>(UKuroInteractionDistanceLib.__GetActorsWithinDistance_Internal((SourceActor != null) ? SourceActor.NativePtr : IntPtr.Zero, (Actors ?? new TArray<AActor>()).NativePtr, MaxDistance, bUse2D), null);
		}

		// Token: 0x0601A3C3 RID: 107459 RVA: 0x0026B99C File Offset: 0x00269B9C
		public unsafe static bool FindClosestActor(AActor SourceActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, ref AActor OutClosestActor, ref float OutDistance, bool bUse2D = false)
		{
			AActor aactor = OutClosestActor;
			IntPtr nativeObjectPtr = (aactor != null) ? aactor.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroInteractionDistanceLib.__FindClosestActor_Internal((SourceActor != null) ? SourceActor.NativePtr : IntPtr.Zero, (Actors ?? new TArray<AActor>()).NativePtr, ref nativeObjectPtr, ref OutDistance, bUse2D);
				OutClosestActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr);
				return result;
			}
		}

		// Token: 0x0601A3C4 RID: 107460
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CalculateSquaredFalloff(float Distance, float MaxDistance);

		// Token: 0x0601A3C5 RID: 107461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CalculateLinearFalloff(float Distance, float MaxDistance);

		// Token: 0x0601A3C6 RID: 107462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CalculateExponentialFalloff(float Distance, float MaxDistance, float Exponent = 2f);

		// Token: 0x0601A3C7 RID: 107463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AreLocationsWithinDistance2D(FVector LocationA, FVector LocationB, float Distance);

		// Token: 0x0601A3C8 RID: 107464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool AreLocationsWithinDistance(FVector LocationA, FVector LocationB, float Distance);

		// Token: 0x0601A3C9 RID: 107465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SortActorsByDistance_Internal(IntPtr SourceActor, IntPtr Actors, bool bUse2D);

		// Token: 0x0601A3CA RID: 107466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMPCVectorParameter_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, FLinearColor Value);

		// Token: 0x0601A3CB RID: 107467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMPCScalarParameter_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName, float Value, bool bForceUpdate);

		// Token: 0x0601A3CC RID: 107468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorWithinLocationDistance2D_Internal(IntPtr Actor, FVector Location, float Distance, ref float OutDistance);

		// Token: 0x0601A3CD RID: 107469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorWithinLocationDistance_Internal(IntPtr Actor, FVector Location, float Distance, ref float OutDistance);

		// Token: 0x0601A3CE RID: 107470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorWithinDistance2D_Internal(IntPtr ActorA, IntPtr ActorB, float Distance, ref float OutDistance);

		// Token: 0x0601A3CF RID: 107471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorWithinDistance_Internal(IntPtr ActorA, IntPtr ActorB, float Distance, ref float OutDistance);

		// Token: 0x0601A3D0 RID: 107472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMPCScalarParameter_Internal(IntPtr WorldContextObject, IntPtr Collection, FName ParameterName);

		// Token: 0x0601A3D1 RID: 107473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceBetweenActors2D_Internal(IntPtr ActorA, IntPtr ActorB);

		// Token: 0x0601A3D2 RID: 107474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceBetweenActors_Internal(IntPtr ActorA, IntPtr ActorB);

		// Token: 0x0601A3D3 RID: 107475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceActorToLocation2D_Internal(IntPtr Actor, FVector Location);

		// Token: 0x0601A3D4 RID: 107476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceActorToLocation_Internal(IntPtr Actor, FVector Location);

		// Token: 0x0601A3D5 RID: 107477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorsWithinDistance_Internal(IntPtr SourceActor, IntPtr Actors, float MaxDistance, bool bUse2D);

		// Token: 0x0601A3D6 RID: 107478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindClosestActor_Internal(IntPtr SourceActor, IntPtr Actors, ref IntPtr OutClosestActor, ref float OutDistance, bool bUse2D);

		// Token: 0x0601A3D7 RID: 107479 RVA: 0x0026B9F3 File Offset: 0x00269BF3
		static UKuroInteractionDistanceLib()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionDistanceLib");
		}

		// Token: 0x0601A3D8 RID: 107480 RVA: 0x0026BA01 File Offset: 0x00269C01
		protected UKuroInteractionDistanceLib(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E3E9 RID: 58345
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionDistanceLib";

		// Token: 0x0400E3EA RID: 58346
		private static IntPtr _ClassPtr;

		// Token: 0x0400E3EB RID: 58347
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
