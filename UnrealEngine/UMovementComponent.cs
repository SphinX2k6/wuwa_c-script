using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EBE RID: 3774
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MovementComponent")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public abstract class UMovementComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CC1B RID: 52251 RVA: 0x001297EA File Offset: 0x001279EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovementComponent._ClassPtr;
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x001297F6 File Offset: 0x001279F6
		// (set) Token: 0x0600CC1D RID: 52253 RVA: 0x0012980A File Offset: 0x00127A0A
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

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600CC1E RID: 52254 RVA: 0x0012981F File Offset: 0x00127A1F
		// (set) Token: 0x0600CC1F RID: 52255 RVA: 0x00129833 File Offset: 0x00127A33
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

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600CC20 RID: 52256 RVA: 0x00129848 File Offset: 0x00127A48
		// (set) Token: 0x0600CC21 RID: 52257 RVA: 0x0012985C File Offset: 0x00127A5C
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

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600CC22 RID: 52258 RVA: 0x00129871 File Offset: 0x00127A71
		// (set) Token: 0x0600CC23 RID: 52259 RVA: 0x00129885 File Offset: 0x00127A85
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

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x0012989A File Offset: 0x00127A9A
		// (set) Token: 0x0600CC25 RID: 52261 RVA: 0x001298AE File Offset: 0x00127AAE
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

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x001298C3 File Offset: 0x00127AC3
		// (set) Token: 0x0600CC27 RID: 52263 RVA: 0x001298DC File Offset: 0x00127ADC
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

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x0012990C File Offset: 0x00127B0C
		// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x00129925 File Offset: 0x00127B25
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

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600CC2A RID: 52266 RVA: 0x00129955 File Offset: 0x00127B55
		// (set) Token: 0x0600CC2B RID: 52267 RVA: 0x0012996E File Offset: 0x00127B6E
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

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600CC2C RID: 52268 RVA: 0x0012999E File Offset: 0x00127B9E
		// (set) Token: 0x0600CC2D RID: 52269 RVA: 0x001299B7 File Offset: 0x00127BB7
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

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600CC2E RID: 52270 RVA: 0x001299E7 File Offset: 0x00127BE7
		// (set) Token: 0x0600CC2F RID: 52271 RVA: 0x00129A00 File Offset: 0x00127C00
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

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600CC30 RID: 52272 RVA: 0x00129A30 File Offset: 0x00127C30
		// (set) Token: 0x0600CC31 RID: 52273 RVA: 0x00129A49 File Offset: 0x00127C49
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

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600CC32 RID: 52274 RVA: 0x00129A79 File Offset: 0x00127C79
		// (set) Token: 0x0600CC33 RID: 52275 RVA: 0x00129A92 File Offset: 0x00127C92
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

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600CC34 RID: 52276 RVA: 0x00129AC2 File Offset: 0x00127CC2
		// (set) Token: 0x0600CC35 RID: 52277 RVA: 0x00129ADB File Offset: 0x00127CDB
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

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600CC36 RID: 52278 RVA: 0x00129B0B File Offset: 0x00127D0B
		// (set) Token: 0x0600CC37 RID: 52279 RVA: 0x00129B24 File Offset: 0x00127D24
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

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600CC38 RID: 52280 RVA: 0x00129B54 File Offset: 0x00127D54
		// (set) Token: 0x0600CC39 RID: 52281 RVA: 0x00129B64 File Offset: 0x00127D64
		public unsafe EPlaneConstraintAxisSetting PlaneConstraintAxisSetting
		{
			get
			{
				return (EPlaneConstraintAxisSetting)(*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintAxisSetting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovementComponent.__PropertyOffset_PlaneConstraintAxisSetting) = (byte)value;
			}
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x00129B75 File Offset: 0x00127D75
		public void StopMovementImmediately()
		{
			UMovementComponent.__StopMovementImmediately_Internal(base.NativePtr);
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x00129B82 File Offset: 0x00127D82
		public void SnapUpdatedComponentToPlane()
		{
			UMovementComponent.__SnapUpdatedComponentToPlane_Internal(base.NativePtr);
		}

		// Token: 0x0600CC3C RID: 52284 RVA: 0x00129B8F File Offset: 0x00127D8F
		public void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
		{
			UMovementComponent.__SetUpdatedComponent_Internal(base.NativePtr, (NewUpdatedComponent != null) ? NewUpdatedComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x00129BAC File Offset: 0x00127DAC
		public void SetPlaneConstraintOrigin(FVector PlaneOrigin)
		{
			UMovementComponent.__SetPlaneConstraintOrigin_Internal(base.NativePtr, PlaneOrigin);
		}

		// Token: 0x0600CC3E RID: 52286 RVA: 0x00129BBA File Offset: 0x00127DBA
		public void SetPlaneConstraintNormal(FVector PlaneNormal)
		{
			UMovementComponent.__SetPlaneConstraintNormal_Internal(base.NativePtr, PlaneNormal);
		}

		// Token: 0x0600CC3F RID: 52287 RVA: 0x00129BC8 File Offset: 0x00127DC8
		public void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
		{
			UMovementComponent.__SetPlaneConstraintFromVectors_Internal(base.NativePtr, Forward, Up);
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x00129BD7 File Offset: 0x00127DD7
		public void SetPlaneConstraintEnabled(bool bEnabled)
		{
			UMovementComponent.__SetPlaneConstraintEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x0600CC41 RID: 52289 RVA: 0x00129BE5 File Offset: 0x00127DE5
		public void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
		{
			UMovementComponent.__SetPlaneConstraintAxisSetting_Internal(base.NativePtr, NewAxisSetting);
		}

		// Token: 0x0600CC42 RID: 52290 RVA: 0x00129BF3 File Offset: 0x00127DF3
		public void PhysicsVolumeChanged(APhysicsVolume NewVolume)
		{
			UMovementComponent.__PhysicsVolumeChanged_Internal(base.NativePtr, (NewVolume != null) ? NewVolume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600CC43 RID: 52291 RVA: 0x00129C10 File Offset: 0x00127E10
		public bool K2_MoveUpdatedComponent(FVector Delta, FRotator NewRotation, ref FHitResult OutHit, bool bSweep = true, bool bTeleport = false)
		{
			return UMovementComponent.__K2_MoveUpdatedComponent_Internal(base.NativePtr, Delta, NewRotation, (OutHit ?? new FHitResult()).NativePtr, bSweep, bTeleport);
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x00129C33 File Offset: 0x00127E33
		public float K2_GetModifiedMaxSpeed()
		{
			return UMovementComponent.__K2_GetModifiedMaxSpeed_Internal(base.NativePtr);
		}

		// Token: 0x0600CC45 RID: 52293 RVA: 0x00129C40 File Offset: 0x00127E40
		public float K2_GetMaxSpeedModifier()
		{
			return UMovementComponent.__K2_GetMaxSpeedModifier_Internal(base.NativePtr);
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x00129C4D File Offset: 0x00127E4D
		public bool IsExceedingMaxSpeed(float MaxSpeed)
		{
			return UMovementComponent.__IsExceedingMaxSpeed_Internal(base.NativePtr, MaxSpeed);
		}

		// Token: 0x0600CC47 RID: 52295 RVA: 0x00129C5B File Offset: 0x00127E5B
		public FVector GetPlaneConstraintOrigin()
		{
			return UMovementComponent.__GetPlaneConstraintOrigin_Internal(base.NativePtr);
		}

		// Token: 0x0600CC48 RID: 52296 RVA: 0x00129C68 File Offset: 0x00127E68
		public FVector GetPlaneConstraintNormal()
		{
			return UMovementComponent.__GetPlaneConstraintNormal_Internal(base.NativePtr);
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x00129C75 File Offset: 0x00127E75
		public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
		{
			return UMovementComponent.__GetPlaneConstraintAxisSetting_Internal(base.NativePtr);
		}

		// Token: 0x0600CC4A RID: 52298 RVA: 0x00129C82 File Offset: 0x00127E82
		public APhysicsVolume GetPhysicsVolume()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APhysicsVolume>(UMovementComponent.__GetPhysicsVolume_Internal(base.NativePtr));
		}

		// Token: 0x0600CC4B RID: 52299 RVA: 0x00129C94 File Offset: 0x00127E94
		public float GetMaxSpeed()
		{
			return UMovementComponent.__GetMaxSpeed_Internal(base.NativePtr);
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x00129CA1 File Offset: 0x00127EA1
		public float GetGravityZ()
		{
			return UMovementComponent.__GetGravityZ_Internal(base.NativePtr);
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x00129CAE File Offset: 0x00127EAE
		public FVector ConstrainNormalToPlane(FVector Normal)
		{
			return UMovementComponent.__ConstrainNormalToPlane_Internal(base.NativePtr, Normal);
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x00129CBC File Offset: 0x00127EBC
		public FVector ConstrainLocationToPlane(FVector Location)
		{
			return UMovementComponent.__ConstrainLocationToPlane_Internal(base.NativePtr, Location);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x00129CCA File Offset: 0x00127ECA
		public FVector ConstrainDirectionToPlane(FVector Direction)
		{
			return UMovementComponent.__ConstrainDirectionToPlane_Internal(base.NativePtr, Direction);
		}

		// Token: 0x0600CC50 RID: 52304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovementImmediately_Internal(IntPtr @this);

		// Token: 0x0600CC51 RID: 52305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapUpdatedComponentToPlane_Internal(IntPtr @this);

		// Token: 0x0600CC52 RID: 52306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdatedComponent_Internal(IntPtr @this, IntPtr NewUpdatedComponent);

		// Token: 0x0600CC53 RID: 52307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintOrigin_Internal(IntPtr @this, FVector PlaneOrigin);

		// Token: 0x0600CC54 RID: 52308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintNormal_Internal(IntPtr @this, FVector PlaneNormal);

		// Token: 0x0600CC55 RID: 52309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintFromVectors_Internal(IntPtr @this, FVector Forward, FVector Up);

		// Token: 0x0600CC56 RID: 52310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x0600CC57 RID: 52311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaneConstraintAxisSetting_Internal(IntPtr @this, EPlaneConstraintAxisSetting NewAxisSetting);

		// Token: 0x0600CC58 RID: 52312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhysicsVolumeChanged_Internal(IntPtr @this, IntPtr NewVolume);

		// Token: 0x0600CC59 RID: 52313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_MoveUpdatedComponent_Internal(IntPtr @this, FVector Delta, FRotator NewRotation, IntPtr OutHit, bool bSweep, bool bTeleport);

		// Token: 0x0600CC5A RID: 52314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetModifiedMaxSpeed_Internal(IntPtr @this);

		// Token: 0x0600CC5B RID: 52315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetMaxSpeedModifier_Internal(IntPtr @this);

		// Token: 0x0600CC5C RID: 52316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsExceedingMaxSpeed_Internal(IntPtr @this, float MaxSpeed);

		// Token: 0x0600CC5D RID: 52317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPlaneConstraintOrigin_Internal(IntPtr @this);

		// Token: 0x0600CC5E RID: 52318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPlaneConstraintNormal_Internal(IntPtr @this);

		// Token: 0x0600CC5F RID: 52319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EPlaneConstraintAxisSetting __GetPlaneConstraintAxisSetting_Internal(IntPtr @this);

		// Token: 0x0600CC60 RID: 52320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPhysicsVolume_Internal(IntPtr @this);

		// Token: 0x0600CC61 RID: 52321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxSpeed_Internal(IntPtr @this);

		// Token: 0x0600CC62 RID: 52322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGravityZ_Internal(IntPtr @this);

		// Token: 0x0600CC63 RID: 52323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainNormalToPlane_Internal(IntPtr @this, FVector Normal);

		// Token: 0x0600CC64 RID: 52324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainLocationToPlane_Internal(IntPtr @this, FVector Location);

		// Token: 0x0600CC65 RID: 52325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConstrainDirectionToPlane_Internal(IntPtr @this, FVector Direction);

		// Token: 0x0600CC66 RID: 52326 RVA: 0x00129CD8 File Offset: 0x00127ED8
		static UMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MovementComponent");
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x00129CE8 File Offset: 0x00127EE8
		protected UMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00129D10 File Offset: 0x00127F10
		protected UMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DFB RID: 28155
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MovementComponent";

		// Token: 0x04006DFC RID: 28156
		private static IntPtr _ClassPtr;

		// Token: 0x04006DFD RID: 28157
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DFE RID: 28158
		internal static int __PropertyOffset_UpdatedComponent;

		// Token: 0x04006DFF RID: 28159
		internal static int __PropertyOffset_UpdatedPrimitive;

		// Token: 0x04006E00 RID: 28160
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04006E01 RID: 28161
		internal static int __PropertyOffset_PlaneConstraintNormal;

		// Token: 0x04006E02 RID: 28162
		internal static int __PropertyOffset_PlaneConstraintOrigin;

		// Token: 0x04006E03 RID: 28163
		internal static int __PropertyOffset_bUpdateOnlyIfRendered;

		// Token: 0x04006E04 RID: 28164
		internal static byte __PropertyMask_bUpdateOnlyIfRendered;

		// Token: 0x04006E05 RID: 28165
		internal static int __PropertyOffset_bAutoUpdateTickRegistration;

		// Token: 0x04006E06 RID: 28166
		internal static byte __PropertyMask_bAutoUpdateTickRegistration;

		// Token: 0x04006E07 RID: 28167
		internal static int __PropertyOffset_bTickBeforeOwner;

		// Token: 0x04006E08 RID: 28168
		internal static byte __PropertyMask_bTickBeforeOwner;

		// Token: 0x04006E09 RID: 28169
		internal static int __PropertyOffset_bAutoRegisterUpdatedComponent;

		// Token: 0x04006E0A RID: 28170
		internal static byte __PropertyMask_bAutoRegisterUpdatedComponent;

		// Token: 0x04006E0B RID: 28171
		internal static int __PropertyOffset_bConstrainToPlane;

		// Token: 0x04006E0C RID: 28172
		internal static byte __PropertyMask_bConstrainToPlane;

		// Token: 0x04006E0D RID: 28173
		internal static int __PropertyOffset_bSnapToPlaneAtStart;

		// Token: 0x04006E0E RID: 28174
		internal static byte __PropertyMask_bSnapToPlaneAtStart;

		// Token: 0x04006E0F RID: 28175
		internal static int __PropertyOffset_bAutoRegisterPhysicsVolumeUpdates;

		// Token: 0x04006E10 RID: 28176
		internal static byte __PropertyMask_bAutoRegisterPhysicsVolumeUpdates;

		// Token: 0x04006E11 RID: 28177
		internal static int __PropertyOffset_bComponentShouldUpdatePhysicsVolume;

		// Token: 0x04006E12 RID: 28178
		internal static byte __PropertyMask_bComponentShouldUpdatePhysicsVolume;

		// Token: 0x04006E13 RID: 28179
		internal static int __PropertyOffset_bEnableSweepWhenResolvePenetration;

		// Token: 0x04006E14 RID: 28180
		internal static byte __PropertyMask_bEnableSweepWhenResolvePenetration;

		// Token: 0x04006E15 RID: 28181
		internal static int __PropertyOffset_PlaneConstraintAxisSetting;
	}
}
