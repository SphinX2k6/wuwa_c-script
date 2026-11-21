using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033F RID: 831
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.KuroCollisionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCollisionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060055E4 RID: 21988 RVA: 0x000785F9 File Offset: 0x000767F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCollisionLibrary._ClassPtr;
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00078608 File Offset: 0x00076808
		public UKuroCollisionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00078630 File Offset: 0x00076830
		[NullableContext(1)]
		public UKuroCollisionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00078663 File Offset: 0x00076863
		public static void SetCollisionResponseToChannel(UPrimitiveComponent PrimitiveComponent, ECollisionChannel Channel, ECollisionResponse NewResponse, int InstanceIndex)
		{
			UKuroCollisionLibrary.__SetCollisionResponseToChannel_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Channel, NewResponse, InstanceIndex);
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00078687 File Offset: 0x00076887
		public static void GetOverlappingComponents(UPrimitiveComponent PrimitiveComponent, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutOverlappingComponents, ref TArray<int> OutOverlappingBodyIndices)
		{
			UKuroCollisionLibrary.__GetOverlappingComponents_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, (OutOverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr, (OutOverlappingBodyIndices ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x000786BE File Offset: 0x000768BE
		[NullableContext(1)]
		public static FBodyInstance GetHitResultBodyInstance([Nullable(2)] in FHitResult HitResult)
		{
			return new FBodyInstance(UKuroCollisionLibrary.__GetHitResultBodyInstance_Internal((HitResult ?? new FHitResult()).NativePtr), null);
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x000786DB File Offset: 0x000768DB
		[NullableContext(0)]
		public static TEnumAsByte<ECollisionResponse> GetCollisionResponseToChannel([Nullable(2)] UPrimitiveComponent PrimitiveComponent, ECollisionChannel Channel, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__GetCollisionResponseToChannel_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Channel, InstanceIndex);
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x000786F9 File Offset: 0x000768F9
		public static FName GetCollisionProfileName(UPrimitiveComponent PrimitiveComponent, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__GetCollisionProfileName_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00078711 File Offset: 0x00076911
		[NullableContext(1)]
		public static FBodyInstance GetBodyInstance([Nullable(2)] UKuroHitResult HitResult, int HitIndex)
		{
			return new FBodyInstance(UKuroCollisionLibrary.__GetBodyInstance_Internal((HitResult != null) ? HitResult.NativePtr : IntPtr.Zero, HitIndex), null);
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00078730 File Offset: 0x00076930
		public unsafe static bool ComponentHasTag(UPrimitiveComponent PrimitiveComponent, in FName Tag, int InstanceIndex)
		{
			fixed (FName* ptr = &Tag)
			{
				void* ptr2 = (void*)ptr;
				return UKuroCollisionLibrary.__ComponentHasTag_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Tag, InstanceIndex);
			}
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00078759 File Offset: 0x00076959
		public static bool CanCharacterStepUp(UPrimitiveComponent PrimitiveComponent, APawn Pawn, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__CanCharacterStepUp_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, (Pawn != null) ? Pawn.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00078781 File Offset: 0x00076981
		public static bool CanCharacterStandOn(UPrimitiveComponent PrimitiveComponent, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__CanCharacterStandOn_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0007879C File Offset: 0x0007699C
		public unsafe static bool ActorHasTag(AActor InActor, in FName Tag, int InstanceIndex)
		{
			fixed (FName* ptr = &Tag)
			{
				void* ptr2 = (void*)ptr;
				return UKuroCollisionLibrary.__ActorHasTag_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, Tag, InstanceIndex);
			}
		}

		// Token: 0x060055F1 RID: 22001
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannel_Internal(IntPtr PrimitiveComponent, TEnumAsByte<ECollisionChannel> Channel, TEnumAsByte<ECollisionResponse> NewResponse, int InstanceIndex);

		// Token: 0x060055F2 RID: 22002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr PrimitiveComponent, IntPtr OutOverlappingComponents, IntPtr OutOverlappingBodyIndices);

		// Token: 0x060055F3 RID: 22003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHitResultBodyInstance_Internal(IntPtr HitResult);

		// Token: 0x060055F4 RID: 22004
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionResponse> __GetCollisionResponseToChannel_Internal(IntPtr PrimitiveComponent, TEnumAsByte<ECollisionChannel> Channel, int InstanceIndex);

		// Token: 0x060055F5 RID: 22005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCollisionProfileName_Internal(IntPtr PrimitiveComponent, int InstanceIndex);

		// Token: 0x060055F6 RID: 22006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBodyInstance_Internal(IntPtr HitResult, int HitIndex);

		// Token: 0x060055F7 RID: 22007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentHasTag_Internal(IntPtr PrimitiveComponent, in FName Tag, int InstanceIndex);

		// Token: 0x060055F8 RID: 22008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStepUp_Internal(IntPtr PrimitiveComponent, IntPtr Pawn, int InstanceIndex);

		// Token: 0x060055F9 RID: 22009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStandOn_Internal(IntPtr PrimitiveComponent, int InstanceIndex);

		// Token: 0x060055FA RID: 22010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHasTag_Internal(IntPtr InActor, in FName Tag, int InstanceIndex);

		// Token: 0x060055FB RID: 22011 RVA: 0x000787C5 File Offset: 0x000769C5
		static UKuroCollisionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroCollisionLibrary");
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x000787D3 File Offset: 0x000769D3
		protected UKuroCollisionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400232B RID: 9003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.KuroCollisionLibrary";

		// Token: 0x0400232C RID: 9004
		private static IntPtr _ClassPtr;

		// Token: 0x0400232D RID: 9005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
