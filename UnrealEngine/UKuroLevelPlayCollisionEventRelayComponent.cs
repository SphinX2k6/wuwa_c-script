using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E6 RID: 6374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayCollisionEventRelayComponent")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroLevelPlayCollisionEventRelayComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017A16 RID: 96790 RVA: 0x0022A0D4 File Offset: 0x002282D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayCollisionEventRelayComponent._ClassPtr;
		}

		// Token: 0x06017A17 RID: 96791 RVA: 0x0022A0E0 File Offset: 0x002282E0
		public UKuroLevelPlayCollisionEventRelayComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCollisionEventRelayComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017A18 RID: 96792 RVA: 0x0022A108 File Offset: 0x00228308
		public UKuroLevelPlayCollisionEventRelayComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCollisionEventRelayComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x06017A19 RID: 96793 RVA: 0x0022A13C File Offset: 0x0022833C
		// (set) Token: 0x06017A1A RID: 96794 RVA: 0x0022A175 File Offset: 0x00228375
		public FGameplayTagContainer HitTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._HitTags) == null)
				{
					result = (this._HitTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_HitTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_HitTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x06017A1B RID: 96795 RVA: 0x0022A198 File Offset: 0x00228398
		// (set) Token: 0x06017A1C RID: 96796 RVA: 0x0022A1D1 File Offset: 0x002283D1
		public FGameplayTagContainer OverlapTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._OverlapTags) == null)
				{
					result = (this._OverlapTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_OverlapTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_OverlapTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x06017A1D RID: 96797 RVA: 0x0022A1F4 File Offset: 0x002283F4
		// (set) Token: 0x06017A1E RID: 96798 RVA: 0x0022A22D File Offset: 0x0022842D
		public FGameplayTagContainer RestrictTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._RestrictTags) == null)
				{
					result = (this._RestrictTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_RestrictTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_RestrictTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x06017A1F RID: 96799 RVA: 0x0022A24E File Offset: 0x0022844E
		// (set) Token: 0x06017A20 RID: 96800 RVA: 0x0022A267 File Offset: 0x00228467
		public unsafe bool bStartRelayAtBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bStartRelayAtBeginPlay) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bStartRelayAtBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bStartRelayAtBeginPlay) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bStartRelayAtBeginPlay) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bStartRelayAtBeginPlay) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bStartRelayAtBeginPlay : 0));
			}
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x06017A21 RID: 96801 RVA: 0x0022A297 File Offset: 0x00228497
		// (set) Token: 0x06017A22 RID: 96802 RVA: 0x0022A2B0 File Offset: 0x002284B0
		public unsafe bool bListenHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenHit) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenHit) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenHit) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenHit) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenHit : 0));
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x06017A23 RID: 96803 RVA: 0x0022A2E0 File Offset: 0x002284E0
		// (set) Token: 0x06017A24 RID: 96804 RVA: 0x0022A2F9 File Offset: 0x002284F9
		public unsafe bool bListenOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenOverlap) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenOverlap) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bListenOverlap) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenOverlap) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bListenOverlap : 0));
			}
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x06017A25 RID: 96805 RVA: 0x0022A329 File Offset: 0x00228529
		// (set) Token: 0x06017A26 RID: 96806 RVA: 0x0022A342 File Offset: 0x00228542
		public unsafe bool bForceListenHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenHit) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenHit) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenHit) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenHit) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenHit : 0));
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x06017A27 RID: 96807 RVA: 0x0022A372 File Offset: 0x00228572
		// (set) Token: 0x06017A28 RID: 96808 RVA: 0x0022A38B File Offset: 0x0022858B
		public unsafe bool bForceListenOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenOverlap) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenOverlap) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bForceListenOverlap) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenOverlap) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bForceListenOverlap : 0));
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x06017A29 RID: 96809 RVA: 0x0022A3BB File Offset: 0x002285BB
		// (set) Token: 0x06017A2A RID: 96810 RVA: 0x0022A3D4 File Offset: 0x002285D4
		public unsafe bool bUseRestrictTags
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bUseRestrictTags) & UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bUseRestrictTags) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bUseRestrictTags) = ((*(base.NativePtr + (IntPtr)UKuroLevelPlayCollisionEventRelayComponent.__PropertyOffset_bUseRestrictTags) & ~UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bUseRestrictTags) | (value ? UKuroLevelPlayCollisionEventRelayComponent.__PropertyMask_bUseRestrictTags : 0));
			}
		}

		// Token: 0x06017A2B RID: 96811 RVA: 0x0022A404 File Offset: 0x00228604
		[NullableContext(2)]
		public void TryStartRelayOwnerCollisionEvent(in FGameplayTagContainer GameplayTags)
		{
			UKuroLevelPlayCollisionEventRelayComponent.__TryStartRelayOwnerCollisionEvent_Internal(base.NativePtr, (GameplayTags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06017A2C RID: 96812 RVA: 0x0022A421 File Offset: 0x00228621
		[NullableContext(2)]
		public void TryEndRelayOwnerCollisionEvent(in FGameplayTagContainer GameplayTags)
		{
			UKuroLevelPlayCollisionEventRelayComponent.__TryEndRelayOwnerCollisionEvent_Internal(base.NativePtr, (GameplayTags ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x06017A2D RID: 96813 RVA: 0x0022A43E File Offset: 0x0022863E
		[NullableContext(2)]
		public void OnActorHit(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, in FHitResult Hit)
		{
			UKuroLevelPlayCollisionEventRelayComponent.__OnActorHit_Internal(base.NativePtr, (SelfActor != null) ? SelfActor.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06017A2E RID: 96814 RVA: 0x0022A47D File Offset: 0x0022867D
		[NullableContext(2)]
		public void OnActorBeginOverlap(AActor OverlappedActor, AActor OtherActor)
		{
			UKuroLevelPlayCollisionEventRelayComponent.__OnActorBeginOverlap_Internal(base.NativePtr, (OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017A2F RID: 96815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryStartRelayOwnerCollisionEvent_Internal(IntPtr @this, IntPtr GameplayTags);

		// Token: 0x06017A30 RID: 96816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryEndRelayOwnerCollisionEvent_Internal(IntPtr @this, IntPtr GameplayTags);

		// Token: 0x06017A31 RID: 96817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnActorHit_Internal(IntPtr @this, IntPtr SelfActor, IntPtr OtherActor, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x06017A32 RID: 96818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnActorBeginOverlap_Internal(IntPtr @this, IntPtr OverlappedActor, IntPtr OtherActor);

		// Token: 0x06017A33 RID: 96819 RVA: 0x0022A4AA File Offset: 0x002286AA
		static UKuroLevelPlayCollisionEventRelayComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayCollisionEventRelayComponent");
		}

		// Token: 0x06017A34 RID: 96820 RVA: 0x0022A4B8 File Offset: 0x002286B8
		protected UKuroLevelPlayCollisionEventRelayComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CD5B RID: 52571
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayCollisionEventRelayComponent";

		// Token: 0x0400CD5C RID: 52572
		private static IntPtr _ClassPtr;

		// Token: 0x0400CD5D RID: 52573
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CD5E RID: 52574
		internal static int __PropertyOffset_HitTags;

		// Token: 0x0400CD5F RID: 52575
		[Nullable(2)]
		private FGameplayTagContainer _HitTags;

		// Token: 0x0400CD60 RID: 52576
		internal static int __PropertyOffset_OverlapTags;

		// Token: 0x0400CD61 RID: 52577
		[Nullable(2)]
		private FGameplayTagContainer _OverlapTags;

		// Token: 0x0400CD62 RID: 52578
		internal static int __PropertyOffset_RestrictTags;

		// Token: 0x0400CD63 RID: 52579
		[Nullable(2)]
		private FGameplayTagContainer _RestrictTags;

		// Token: 0x0400CD64 RID: 52580
		internal static int __PropertyOffset_bStartRelayAtBeginPlay;

		// Token: 0x0400CD65 RID: 52581
		internal static byte __PropertyMask_bStartRelayAtBeginPlay;

		// Token: 0x0400CD66 RID: 52582
		internal static int __PropertyOffset_bListenHit;

		// Token: 0x0400CD67 RID: 52583
		internal static byte __PropertyMask_bListenHit;

		// Token: 0x0400CD68 RID: 52584
		internal static int __PropertyOffset_bListenOverlap;

		// Token: 0x0400CD69 RID: 52585
		internal static byte __PropertyMask_bListenOverlap;

		// Token: 0x0400CD6A RID: 52586
		internal static int __PropertyOffset_bForceListenHit;

		// Token: 0x0400CD6B RID: 52587
		internal static byte __PropertyMask_bForceListenHit;

		// Token: 0x0400CD6C RID: 52588
		internal static int __PropertyOffset_bForceListenOverlap;

		// Token: 0x0400CD6D RID: 52589
		internal static byte __PropertyMask_bForceListenOverlap;

		// Token: 0x0400CD6E RID: 52590
		internal static int __PropertyOffset_bUseRestrictTags;

		// Token: 0x0400CD6F RID: 52591
		internal static byte __PropertyMask_bUseRestrictTags;
	}
}
