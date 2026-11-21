using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000244 RID: 580
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MovementComponent")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public abstract class UMovementComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031D7 RID: 12759 RVA: 0x00046F3F File Offset: 0x0004513F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovementComponent._ClassPtr;
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x00046F4B File Offset: 0x0004514B
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00046F5F File Offset: 0x0004515F
		public unsafe USceneComponent UpdatedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovementComponent.__PropertyOffset_UpdatedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovementComponent.__PropertyOffset_UpdatedComponent, value);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00046F74 File Offset: 0x00045174
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x00046F88 File Offset: 0x00045188
		public unsafe UPrimitiveComponent UpdatedPrimitive
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovementComponent.__PropertyOffset_UpdatedPrimitive);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovementComponent.__PropertyOffset_UpdatedPrimitive, value);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x00046F9D File Offset: 0x0004519D
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x00046FB1 File Offset: 0x000451B1
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x00046FC6 File Offset: 0x000451C6
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x00046FDA File Offset: 0x000451DA
		public unsafe FVector PlaneConstraintNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintNormal) = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x00046FEF File Offset: 0x000451EF
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00047003 File Offset: 0x00045203
		public unsafe FVector PlaneConstraintOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintOrigin) = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x00047018 File Offset: 0x00045218
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00047031 File Offset: 0x00045231
		public unsafe bool bUpdateOnlyIfRendered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bUpdateOnlyIfRendered) & UMovementComponent.__PropertyMask_bUpdateOnlyIfRendered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bUpdateOnlyIfRendered) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bUpdateOnlyIfRendered) & ~UMovementComponent.__PropertyMask_bUpdateOnlyIfRendered) | (value ? UMovementComponent.__PropertyMask_bUpdateOnlyIfRendered : 0));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x00047061 File Offset: 0x00045261
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x0004707A File Offset: 0x0004527A
		public unsafe bool bAutoUpdateTickRegistration
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoUpdateTickRegistration) & UMovementComponent.__PropertyMask_bAutoUpdateTickRegistration) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoUpdateTickRegistration) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoUpdateTickRegistration) & ~UMovementComponent.__PropertyMask_bAutoUpdateTickRegistration) | (value ? UMovementComponent.__PropertyMask_bAutoUpdateTickRegistration : 0));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000470AA File Offset: 0x000452AA
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x000470C3 File Offset: 0x000452C3
		public unsafe bool bTickBeforeOwner
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bTickBeforeOwner) & UMovementComponent.__PropertyMask_bTickBeforeOwner) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bTickBeforeOwner) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bTickBeforeOwner) & ~UMovementComponent.__PropertyMask_bTickBeforeOwner) | (value ? UMovementComponent.__PropertyMask_bTickBeforeOwner : 0));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x000470F3 File Offset: 0x000452F3
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x0004710C File Offset: 0x0004530C
		public unsafe bool bAutoRegisterUpdatedComponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterUpdatedComponent) & UMovementComponent.__PropertyMask_bAutoRegisterUpdatedComponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterUpdatedComponent) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterUpdatedComponent) & ~UMovementComponent.__PropertyMask_bAutoRegisterUpdatedComponent) | (value ? UMovementComponent.__PropertyMask_bAutoRegisterUpdatedComponent : 0));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x0004713C File Offset: 0x0004533C
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x00047155 File Offset: 0x00045355
		public unsafe bool bConstrainToPlane
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bConstrainToPlane) & UMovementComponent.__PropertyMask_bConstrainToPlane) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bConstrainToPlane) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bConstrainToPlane) & ~UMovementComponent.__PropertyMask_bConstrainToPlane) | (value ? UMovementComponent.__PropertyMask_bConstrainToPlane : 0));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x00047185 File Offset: 0x00045385
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x0004719E File Offset: 0x0004539E
		public unsafe bool bSnapToPlaneAtStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bSnapToPlaneAtStart) & UMovementComponent.__PropertyMask_bSnapToPlaneAtStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bSnapToPlaneAtStart) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bSnapToPlaneAtStart) & ~UMovementComponent.__PropertyMask_bSnapToPlaneAtStart) | (value ? UMovementComponent.__PropertyMask_bSnapToPlaneAtStart : 0));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x000471CE File Offset: 0x000453CE
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x000471E7 File Offset: 0x000453E7
		public unsafe bool bAutoRegisterPhysicsVolumeUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterPhysicsVolumeUpdates) & UMovementComponent.__PropertyMask_bAutoRegisterPhysicsVolumeUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterPhysicsVolumeUpdates) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bAutoRegisterPhysicsVolumeUpdates) & ~UMovementComponent.__PropertyMask_bAutoRegisterPhysicsVolumeUpdates) | (value ? UMovementComponent.__PropertyMask_bAutoRegisterPhysicsVolumeUpdates : 0));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x00047217 File Offset: 0x00045417
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00047230 File Offset: 0x00045430
		public unsafe bool bComponentShouldUpdatePhysicsVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bComponentShouldUpdatePhysicsVolume) & UMovementComponent.__PropertyMask_bComponentShouldUpdatePhysicsVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bComponentShouldUpdatePhysicsVolume) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bComponentShouldUpdatePhysicsVolume) & ~UMovementComponent.__PropertyMask_bComponentShouldUpdatePhysicsVolume) | (value ? UMovementComponent.__PropertyMask_bComponentShouldUpdatePhysicsVolume : 0));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x00047260 File Offset: 0x00045460
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x00047279 File Offset: 0x00045479
		public unsafe bool bEnableSweepWhenResolvePenetration
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bEnableSweepWhenResolvePenetration) & UMovementComponent.__PropertyMask_bEnableSweepWhenResolvePenetration) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bEnableSweepWhenResolvePenetration) = ((*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_bEnableSweepWhenResolvePenetration) & ~UMovementComponent.__PropertyMask_bEnableSweepWhenResolvePenetration) | (value ? UMovementComponent.__PropertyMask_bEnableSweepWhenResolvePenetration : 0));
			}
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000472A9 File Offset: 0x000454A9
		public void StopMovementImmediately()
		{
			UMovementComponent.__StopMovementImmediately_Internal(base.NativePtr);
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000472B6 File Offset: 0x000454B6
		public void SnapUpdatedComponentToPlane()
		{
			UMovementComponent.__SnapUpdatedComponentToPlane_Internal(base.NativePtr);
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000472C3 File Offset: 0x000454C3
		public void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
		{
			UMovementComponent.__SetUpdatedComponent_Internal(base.NativePtr, (NewUpdatedComponent != null) ? NewUpdatedComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000472E0 File Offset: 0x000454E0
		public void SetPlaneConstraintOrigin(FVector PlaneOrigin)
		{
			UMovementComponent.__SetPlaneConstraintOrigin_Internal(base.NativePtr, PlaneOrigin);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000472EE File Offset: 0x000454EE
		public void SetPlaneConstraintNormal(FVector PlaneNormal)
		{
			UMovementComponent.__SetPlaneConstraintNormal_Internal(base.NativePtr, PlaneNormal);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000472FC File Offset: 0x000454FC
		public void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
		{
			UMovementComponent.__SetPlaneConstraintFromVectors_Internal(base.NativePtr, Forward, Up);
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0004730B File Offset: 0x0004550B
		public void SetPlaneConstraintEnabled(bool bEnabled)
		{
			UMovementComponent.__SetPlaneConstraintEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00047319 File Offset: 0x00045519
		public bool K2_MoveUpdatedComponent(FVector Delta, FRotator NewRotation, ref FHitResult OutHit, bool bSweep = true, bool bTeleport = false)
		{
			return UMovementComponent.__K2_MoveUpdatedComponent_Internal(base.NativePtr, Delta, NewRotation, (OutHit ?? new FHitResult()).NativePtr, bSweep, bTeleport);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0004733C File Offset: 0x0004553C
		public float K2_GetModifiedMaxSpeed()
		{
			return UMovementComponent.__K2_GetModifiedMaxSpeed_Internal(base.NativePtr);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00047349 File Offset: 0x00045549
		public float K2_GetMaxSpeedModifier()
		{
			return UMovementComponent.__K2_GetMaxSpeedModifier_Internal(base.NativePtr);
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00047356 File Offset: 0x00045556
		public bool IsExceedingMaxSpeed(float MaxSpeed)
		{
			return UMovementComponent.__IsExceedingMaxSpeed_Internal(base.NativePtr, MaxSpeed);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00047364 File Offset: 0x00045564
		public FVector GetPlaneConstraintOrigin()
		{
			return UMovementComponent.__GetPlaneConstraintOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00047371 File Offset: 0x00045571
		public FVector GetPlaneConstraintNormal()
		{
			return UMovementComponent.__GetPlaneConstraintNormal_Internal(base.NativePtr);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0004737E File Offset: 0x0004557E
		public float GetMaxSpeed()
		{
			return UMovementComponent.__GetMaxSpeed_Internal(base.NativePtr);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0004738B File Offset: 0x0004558B
		public float GetGravityZ()
		{
			return UMovementComponent.__GetGravityZ_Internal(base.NativePtr);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00047398 File Offset: 0x00045598
		public FVector ConstrainNormalToPlane(FVector Normal)
		{
			return UMovementComponent.__ConstrainNormalToPlane_Internal(base.NativePtr, Normal);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000473A6 File Offset: 0x000455A6
		public FVector ConstrainLocationToPlane(FVector Location)
		{
			return UMovementComponent.__ConstrainLocationToPlane_Internal(base.NativePtr, Location);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000473B4 File Offset: 0x000455B4
		public FVector ConstrainDirectionToPlane(FVector Direction)
		{
			return UMovementComponent.__ConstrainDirectionToPlane_Internal(base.NativePtr, Direction);
		}

		// Token: 0x06003206 RID: 12806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovementImmediately_Internal(IntPtr @this);

		// Token: 0x06003207 RID: 12807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapUpdatedComponentToPlane_Internal(IntPtr @this);

		// Token: 0x06003208 RID: 12808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdatedComponent_Internal(IntPtr @this, IntPtr NewUpdatedComponent);

		// Token: 0x06003209 RID: 12809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintOrigin_Internal(IntPtr @this, FVector PlaneOrigin);

		// Token: 0x0600320A RID: 12810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintNormal_Internal(IntPtr @this, FVector PlaneNormal);

		// Token: 0x0600320B RID: 12811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintFromVectors_Internal(IntPtr @this, FVector Forward, FVector Up);

		// Token: 0x0600320C RID: 12812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x0600320D RID: 12813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_MoveUpdatedComponent_Internal(IntPtr @this, FVector Delta, FRotator NewRotation, IntPtr OutHit, bool bSweep, bool bTeleport);

		// Token: 0x0600320E RID: 12814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetModifiedMaxSpeed_Internal(IntPtr @this);

		// Token: 0x0600320F RID: 12815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetMaxSpeedModifier_Internal(IntPtr @this);

		// Token: 0x06003210 RID: 12816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsExceedingMaxSpeed_Internal(IntPtr @this, float MaxSpeed);

		// Token: 0x06003211 RID: 12817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPlaneConstraintOrigin_Internal(IntPtr @this);

		// Token: 0x06003212 RID: 12818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPlaneConstraintNormal_Internal(IntPtr @this);

		// Token: 0x06003213 RID: 12819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxSpeed_Internal(IntPtr @this);

		// Token: 0x06003214 RID: 12820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGravityZ_Internal(IntPtr @this);

		// Token: 0x06003215 RID: 12821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainNormalToPlane_Internal(IntPtr @this, FVector Normal);

		// Token: 0x06003216 RID: 12822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainLocationToPlane_Internal(IntPtr @this, FVector Location);

		// Token: 0x06003217 RID: 12823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainDirectionToPlane_Internal(IntPtr @this, FVector Direction);

		// Token: 0x06003218 RID: 12824 RVA: 0x000473C2 File Offset: 0x000455C2
		static UMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MovementComponent");
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000473D0 File Offset: 0x000455D0
		protected UMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000473F8 File Offset: 0x000455F8
		protected UMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001130 RID: 4400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MovementComponent";

		// Token: 0x04001131 RID: 4401
		private static IntPtr _ClassPtr;

		// Token: 0x04001132 RID: 4402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001133 RID: 4403
		internal static int __PropertyOffset_UpdatedComponent;

		// Token: 0x04001134 RID: 4404
		internal static int __PropertyOffset_UpdatedPrimitive;

		// Token: 0x04001135 RID: 4405
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001136 RID: 4406
		internal static int __PropertyOffset_PlaneConstraintNormal;

		// Token: 0x04001137 RID: 4407
		internal static int __PropertyOffset_PlaneConstraintOrigin;

		// Token: 0x04001138 RID: 4408
		internal static int __PropertyOffset_bUpdateOnlyIfRendered;

		// Token: 0x04001139 RID: 4409
		internal static byte __PropertyMask_bUpdateOnlyIfRendered;

		// Token: 0x0400113A RID: 4410
		internal static int __PropertyOffset_bAutoUpdateTickRegistration;

		// Token: 0x0400113B RID: 4411
		internal static byte __PropertyMask_bAutoUpdateTickRegistration;

		// Token: 0x0400113C RID: 4412
		internal static int __PropertyOffset_bTickBeforeOwner;

		// Token: 0x0400113D RID: 4413
		internal static byte __PropertyMask_bTickBeforeOwner;

		// Token: 0x0400113E RID: 4414
		internal static int __PropertyOffset_bAutoRegisterUpdatedComponent;

		// Token: 0x0400113F RID: 4415
		internal static byte __PropertyMask_bAutoRegisterUpdatedComponent;

		// Token: 0x04001140 RID: 4416
		internal static int __PropertyOffset_bConstrainToPlane;

		// Token: 0x04001141 RID: 4417
		internal static byte __PropertyMask_bConstrainToPlane;

		// Token: 0x04001142 RID: 4418
		internal static int __PropertyOffset_bSnapToPlaneAtStart;

		// Token: 0x04001143 RID: 4419
		internal static byte __PropertyMask_bSnapToPlaneAtStart;

		// Token: 0x04001144 RID: 4420
		internal static int __PropertyOffset_bAutoRegisterPhysicsVolumeUpdates;

		// Token: 0x04001145 RID: 4421
		internal static byte __PropertyMask_bAutoRegisterPhysicsVolumeUpdates;

		// Token: 0x04001146 RID: 4422
		internal static int __PropertyOffset_bComponentShouldUpdatePhysicsVolume;

		// Token: 0x04001147 RID: 4423
		internal static byte __PropertyMask_bComponentShouldUpdatePhysicsVolume;

		// Token: 0x04001148 RID: 4424
		internal static int __PropertyOffset_bEnableSweepWhenResolvePenetration;

		// Token: 0x04001149 RID: 4425
		internal static byte __PropertyMask_bEnableSweepWhenResolvePenetration;
	}
}
