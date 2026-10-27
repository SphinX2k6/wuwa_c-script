using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001747 RID: 5959
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.KuroCollisionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCollisionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015702 RID: 87810 RVA: 0x001F81C2 File Offset: 0x001F63C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCollisionLibrary._ClassPtr;
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x001F81D0 File Offset: 0x001F63D0
		public UKuroCollisionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015704 RID: 87812 RVA: 0x001F81F8 File Offset: 0x001F63F8
		[NullableContext(1)]
		public UKuroCollisionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015705 RID: 87813 RVA: 0x001F822B File Offset: 0x001F642B
		public static void SetCollisionResponseToChannel(UPrimitiveComponent PrimitiveComponent, ECollisionChannel Channel, ECollisionResponse NewResponse, int InstanceIndex)
		{
			UKuroCollisionLibrary.__SetCollisionResponseToChannel_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Channel, NewResponse, InstanceIndex);
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x001F824F File Offset: 0x001F644F
		[NullableContext(1)]
		public static FWalkableSlopeOverride GetWalkableSlopeOverride([Nullable(2)] UPrimitiveComponent PrimitiveComponent, int InstanceIndex)
		{
			return new FWalkableSlopeOverride(UKuroCollisionLibrary.__GetWalkableSlopeOverride_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, InstanceIndex), null);
		}

		// Token: 0x06015707 RID: 87815 RVA: 0x001F826D File Offset: 0x001F646D
		public static void GetOverlappingComponents(UPrimitiveComponent PrimitiveComponent, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OutOverlappingComponents, ref TArray<int> OutOverlappingBodyIndices)
		{
			UKuroCollisionLibrary.__GetOverlappingComponents_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, (OutOverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr, (OutOverlappingBodyIndices ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06015708 RID: 87816 RVA: 0x001F82A4 File Offset: 0x001F64A4
		[NullableContext(1)]
		public static FBodyInstance GetHitResultBodyInstance([Nullable(2)] in FHitResult HitResult)
		{
			return new FBodyInstance(UKuroCollisionLibrary.__GetHitResultBodyInstance_Internal((HitResult ?? new FHitResult()).NativePtr), null);
		}

		// Token: 0x06015709 RID: 87817 RVA: 0x001F82C1 File Offset: 0x001F64C1
		[NullableContext(0)]
		public static TEnumAsByte<ECollisionResponse> GetCollisionResponseToChannel([Nullable(2)] UPrimitiveComponent PrimitiveComponent, ECollisionChannel Channel, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__GetCollisionResponseToChannel_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Channel, InstanceIndex);
		}

		// Token: 0x0601570A RID: 87818 RVA: 0x001F82DF File Offset: 0x001F64DF
		public static FName GetCollisionProfileName(UPrimitiveComponent PrimitiveComponent, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__GetCollisionProfileName_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x0601570B RID: 87819 RVA: 0x001F82F7 File Offset: 0x001F64F7
		[NullableContext(1)]
		public static FBodyInstance GetBodyInstance([Nullable(2)] UKuroHitResult HitResult, int HitIndex)
		{
			return new FBodyInstance(UKuroCollisionLibrary.__GetBodyInstance_Internal((HitResult != null) ? HitResult.NativePtr : IntPtr.Zero, HitIndex), null);
		}

		// Token: 0x0601570C RID: 87820 RVA: 0x001F8318 File Offset: 0x001F6518
		public unsafe static bool ComponentHasTag(UPrimitiveComponent PrimitiveComponent, in FName Tag, int InstanceIndex)
		{
			fixed (FName* ptr = &Tag)
			{
				void* ptr2 = (void*)ptr;
				return UKuroCollisionLibrary.__ComponentHasTag_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, Tag, InstanceIndex);
			}
		}

		// Token: 0x0601570D RID: 87821 RVA: 0x001F8341 File Offset: 0x001F6541
		public static bool CanCharacterStepUp(UPrimitiveComponent PrimitiveComponent, APawn Pawn, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__CanCharacterStepUp_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, (Pawn != null) ? Pawn.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x0601570E RID: 87822 RVA: 0x001F8369 File Offset: 0x001F6569
		public static bool CanCharacterStandOn(UPrimitiveComponent PrimitiveComponent, int InstanceIndex)
		{
			return UKuroCollisionLibrary.__CanCharacterStandOn_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, InstanceIndex);
		}

		// Token: 0x0601570F RID: 87823 RVA: 0x001F8384 File Offset: 0x001F6584
		public unsafe static bool ActorHasTag(AActor InActor, in FName Tag, int InstanceIndex)
		{
			fixed (FName* ptr = &Tag)
			{
				void* ptr2 = (void*)ptr;
				return UKuroCollisionLibrary.__ActorHasTag_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, Tag, InstanceIndex);
			}
		}

		// Token: 0x06015710 RID: 87824
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionResponseToChannel_Internal(IntPtr PrimitiveComponent, TEnumAsByte<ECollisionChannel> Channel, TEnumAsByte<ECollisionResponse> NewResponse, int InstanceIndex);

		// Token: 0x06015711 RID: 87825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWalkableSlopeOverride_Internal(IntPtr PrimitiveComponent, int InstanceIndex);

		// Token: 0x06015712 RID: 87826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr PrimitiveComponent, IntPtr OutOverlappingComponents, IntPtr OutOverlappingBodyIndices);

		// Token: 0x06015713 RID: 87827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHitResultBodyInstance_Internal(IntPtr HitResult);

		// Token: 0x06015714 RID: 87828
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ECollisionResponse> __GetCollisionResponseToChannel_Internal(IntPtr PrimitiveComponent, TEnumAsByte<ECollisionChannel> Channel, int InstanceIndex);

		// Token: 0x06015715 RID: 87829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCollisionProfileName_Internal(IntPtr PrimitiveComponent, int InstanceIndex);

		// Token: 0x06015716 RID: 87830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBodyInstance_Internal(IntPtr HitResult, int HitIndex);

		// Token: 0x06015717 RID: 87831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ComponentHasTag_Internal(IntPtr PrimitiveComponent, in FName Tag, int InstanceIndex);

		// Token: 0x06015718 RID: 87832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStepUp_Internal(IntPtr PrimitiveComponent, IntPtr Pawn, int InstanceIndex);

		// Token: 0x06015719 RID: 87833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCharacterStandOn_Internal(IntPtr PrimitiveComponent, int InstanceIndex);

		// Token: 0x0601571A RID: 87834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHasTag_Internal(IntPtr InActor, in FName Tag, int InstanceIndex);

		// Token: 0x0601571B RID: 87835 RVA: 0x001F83AD File Offset: 0x001F65AD
		static UKuroCollisionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroCollisionLibrary");
		}

		// Token: 0x0601571C RID: 87836 RVA: 0x001F83BB File Offset: 0x001F65BB
		protected UKuroCollisionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB04 RID: 47876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.KuroCollisionLibrary";

		// Token: 0x0400BB05 RID: 47877
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB06 RID: 47878
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
