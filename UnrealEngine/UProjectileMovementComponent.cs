using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001040 RID: 4160
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ProjectileMovementComponent")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UProjectileMovementComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EC7C RID: 60540 RVA: 0x0015ECDC File Offset: 0x0015CEDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProjectileMovementComponent._ClassPtr;
		}

		// Token: 0x0600EC7D RID: 60541 RVA: 0x0015ECE8 File Offset: 0x0015CEE8
		public UProjectileMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UProjectileMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x0015ED10 File Offset: 0x0015CF10
		public UProjectileMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProjectileMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600EC7F RID: 60543 RVA: 0x0015ED43 File Offset: 0x0015CF43
		// (set) Token: 0x0600EC80 RID: 60544 RVA: 0x0015ED53 File Offset: 0x0015CF53
		public unsafe float InitialSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InitialSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InitialSpeed) = value;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600EC81 RID: 60545 RVA: 0x0015ED64 File Offset: 0x0015CF64
		// (set) Token: 0x0600EC82 RID: 60546 RVA: 0x0015ED74 File Offset: 0x0015CF74
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x0015ED85 File Offset: 0x0015CF85
		// (set) Token: 0x0600EC84 RID: 60548 RVA: 0x0015ED9E File Offset: 0x0015CF9E
		public unsafe bool bRotationFollowsVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationFollowsVelocity) & UProjectileMovementComponent.__PropertyMask_bRotationFollowsVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationFollowsVelocity) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationFollowsVelocity) & ~UProjectileMovementComponent.__PropertyMask_bRotationFollowsVelocity) | (value ? UProjectileMovementComponent.__PropertyMask_bRotationFollowsVelocity : 0));
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600EC85 RID: 60549 RVA: 0x0015EDCE File Offset: 0x0015CFCE
		// (set) Token: 0x0600EC86 RID: 60550 RVA: 0x0015EDE7 File Offset: 0x0015CFE7
		public unsafe bool bRotationRemainsVertical
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationRemainsVertical) & UProjectileMovementComponent.__PropertyMask_bRotationRemainsVertical) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationRemainsVertical) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bRotationRemainsVertical) & ~UProjectileMovementComponent.__PropertyMask_bRotationRemainsVertical) | (value ? UProjectileMovementComponent.__PropertyMask_bRotationRemainsVertical : 0));
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600EC87 RID: 60551 RVA: 0x0015EE17 File Offset: 0x0015D017
		// (set) Token: 0x0600EC88 RID: 60552 RVA: 0x0015EE30 File Offset: 0x0015D030
		public unsafe bool bShouldBounce
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bShouldBounce) & UProjectileMovementComponent.__PropertyMask_bShouldBounce) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bShouldBounce) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bShouldBounce) & ~UProjectileMovementComponent.__PropertyMask_bShouldBounce) | (value ? UProjectileMovementComponent.__PropertyMask_bShouldBounce : 0));
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600EC89 RID: 60553 RVA: 0x0015EE60 File Offset: 0x0015D060
		// (set) Token: 0x0600EC8A RID: 60554 RVA: 0x0015EE79 File Offset: 0x0015D079
		public unsafe bool bInitialVelocityInLocalSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInitialVelocityInLocalSpace) & UProjectileMovementComponent.__PropertyMask_bInitialVelocityInLocalSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInitialVelocityInLocalSpace) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInitialVelocityInLocalSpace) & ~UProjectileMovementComponent.__PropertyMask_bInitialVelocityInLocalSpace) | (value ? UProjectileMovementComponent.__PropertyMask_bInitialVelocityInLocalSpace : 0));
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600EC8B RID: 60555 RVA: 0x0015EEA9 File Offset: 0x0015D0A9
		// (set) Token: 0x0600EC8C RID: 60556 RVA: 0x0015EEC2 File Offset: 0x0015D0C2
		public unsafe bool bForceSubStepping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bForceSubStepping) & UProjectileMovementComponent.__PropertyMask_bForceSubStepping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bForceSubStepping) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bForceSubStepping) & ~UProjectileMovementComponent.__PropertyMask_bForceSubStepping) | (value ? UProjectileMovementComponent.__PropertyMask_bForceSubStepping : 0));
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x0015EEF2 File Offset: 0x0015D0F2
		// (set) Token: 0x0600EC8E RID: 60558 RVA: 0x0015EF0B File Offset: 0x0015D10B
		public unsafe bool bSimulationEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSimulationEnabled) & UProjectileMovementComponent.__PropertyMask_bSimulationEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSimulationEnabled) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSimulationEnabled) & ~UProjectileMovementComponent.__PropertyMask_bSimulationEnabled) | (value ? UProjectileMovementComponent.__PropertyMask_bSimulationEnabled : 0));
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600EC8F RID: 60559 RVA: 0x0015EF3B File Offset: 0x0015D13B
		// (set) Token: 0x0600EC90 RID: 60560 RVA: 0x0015EF54 File Offset: 0x0015D154
		public unsafe bool bSweepCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSweepCollision) & UProjectileMovementComponent.__PropertyMask_bSweepCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSweepCollision) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bSweepCollision) & ~UProjectileMovementComponent.__PropertyMask_bSweepCollision) | (value ? UProjectileMovementComponent.__PropertyMask_bSweepCollision : 0));
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x0015EF84 File Offset: 0x0015D184
		// (set) Token: 0x0600EC92 RID: 60562 RVA: 0x0015EF9D File Offset: 0x0015D19D
		public unsafe bool bIsHomingProjectile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsHomingProjectile) & UProjectileMovementComponent.__PropertyMask_bIsHomingProjectile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsHomingProjectile) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsHomingProjectile) & ~UProjectileMovementComponent.__PropertyMask_bIsHomingProjectile) | (value ? UProjectileMovementComponent.__PropertyMask_bIsHomingProjectile : 0));
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600EC93 RID: 60563 RVA: 0x0015EFCD File Offset: 0x0015D1CD
		// (set) Token: 0x0600EC94 RID: 60564 RVA: 0x0015EFE6 File Offset: 0x0015D1E6
		public unsafe bool bBounceAngleAffectsFriction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bBounceAngleAffectsFriction) & UProjectileMovementComponent.__PropertyMask_bBounceAngleAffectsFriction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bBounceAngleAffectsFriction) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bBounceAngleAffectsFriction) & ~UProjectileMovementComponent.__PropertyMask_bBounceAngleAffectsFriction) | (value ? UProjectileMovementComponent.__PropertyMask_bBounceAngleAffectsFriction : 0));
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600EC95 RID: 60565 RVA: 0x0015F016 File Offset: 0x0015D216
		// (set) Token: 0x0600EC96 RID: 60566 RVA: 0x0015F02F File Offset: 0x0015D22F
		public unsafe bool bIsSliding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsSliding) & UProjectileMovementComponent.__PropertyMask_bIsSliding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsSliding) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bIsSliding) & ~UProjectileMovementComponent.__PropertyMask_bIsSliding) | (value ? UProjectileMovementComponent.__PropertyMask_bIsSliding : 0));
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600EC97 RID: 60567 RVA: 0x0015F05F File Offset: 0x0015D25F
		// (set) Token: 0x0600EC98 RID: 60568 RVA: 0x0015F078 File Offset: 0x0015D278
		public unsafe bool bInterpMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpMovement) & UProjectileMovementComponent.__PropertyMask_bInterpMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpMovement) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpMovement) & ~UProjectileMovementComponent.__PropertyMask_bInterpMovement) | (value ? UProjectileMovementComponent.__PropertyMask_bInterpMovement : 0));
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600EC99 RID: 60569 RVA: 0x0015F0A8 File Offset: 0x0015D2A8
		// (set) Token: 0x0600EC9A RID: 60570 RVA: 0x0015F0C1 File Offset: 0x0015D2C1
		public unsafe bool bInterpRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpRotation) & UProjectileMovementComponent.__PropertyMask_bInterpRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpRotation) = ((*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_bInterpRotation) & ~UProjectileMovementComponent.__PropertyMask_bInterpRotation) | (value ? UProjectileMovementComponent.__PropertyMask_bInterpRotation : 0));
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x0015F0F1 File Offset: 0x0015D2F1
		// (set) Token: 0x0600EC9C RID: 60572 RVA: 0x0015F101 File Offset: 0x0015D301
		public unsafe float PreviousHitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_PreviousHitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_PreviousHitTime) = value;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600EC9D RID: 60573 RVA: 0x0015F112 File Offset: 0x0015D312
		// (set) Token: 0x0600EC9E RID: 60574 RVA: 0x0015F126 File Offset: 0x0015D326
		public unsafe FVector PreviousHitNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_PreviousHitNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_PreviousHitNormal) = value;
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x0015F13B File Offset: 0x0015D33B
		// (set) Token: 0x0600ECA0 RID: 60576 RVA: 0x0015F14B File Offset: 0x0015D34B
		public unsafe float ProjectileGravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_ProjectileGravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_ProjectileGravityScale) = value;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600ECA1 RID: 60577 RVA: 0x0015F15C File Offset: 0x0015D35C
		// (set) Token: 0x0600ECA2 RID: 60578 RVA: 0x0015F16C File Offset: 0x0015D36C
		public unsafe float Buoyancy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Buoyancy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Buoyancy) = value;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600ECA3 RID: 60579 RVA: 0x0015F17D File Offset: 0x0015D37D
		// (set) Token: 0x0600ECA4 RID: 60580 RVA: 0x0015F18D File Offset: 0x0015D38D
		public unsafe float Bounciness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Bounciness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Bounciness) = value;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600ECA5 RID: 60581 RVA: 0x0015F19E File Offset: 0x0015D39E
		// (set) Token: 0x0600ECA6 RID: 60582 RVA: 0x0015F1AE File Offset: 0x0015D3AE
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600ECA7 RID: 60583 RVA: 0x0015F1BF File Offset: 0x0015D3BF
		// (set) Token: 0x0600ECA8 RID: 60584 RVA: 0x0015F1CF File Offset: 0x0015D3CF
		public unsafe float BounceVelocityStopSimulatingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_BounceVelocityStopSimulatingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_BounceVelocityStopSimulatingThreshold) = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x0015F1E0 File Offset: 0x0015D3E0
		// (set) Token: 0x0600ECAA RID: 60586 RVA: 0x0015F1F0 File Offset: 0x0015D3F0
		public unsafe float MinFrictionFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MinFrictionFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MinFrictionFraction) = value;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x0015F204 File Offset: 0x0015D404
		// (set) Token: 0x0600ECAC RID: 60588 RVA: 0x0015F23D File Offset: 0x0015D43D
		public FOnProjectileBounceDelegate OnProjectileBounce
		{
			get
			{
				base.FastCheckIsValid();
				FOnProjectileBounceDelegate result;
				if ((result = this._OnProjectileBounce) == null)
				{
					result = (this._OnProjectileBounce = new FOnProjectileBounceDelegate(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_OnProjectileBounce, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_OnProjectileBounce, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600ECAD RID: 60589 RVA: 0x0015F260 File Offset: 0x0015D460
		// (set) Token: 0x0600ECAE RID: 60590 RVA: 0x0015F299 File Offset: 0x0015D499
		public FOnProjectileStopDelegate OnProjectileStop
		{
			get
			{
				base.FastCheckIsValid();
				FOnProjectileStopDelegate result;
				if ((result = this._OnProjectileStop) == null)
				{
					result = (this._OnProjectileStop = new FOnProjectileStopDelegate(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_OnProjectileStop, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_OnProjectileStop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600ECAF RID: 60591 RVA: 0x0015F2BA File Offset: 0x0015D4BA
		// (set) Token: 0x0600ECB0 RID: 60592 RVA: 0x0015F2CA File Offset: 0x0015D4CA
		public unsafe float HomingAccelerationMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_HomingAccelerationMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_HomingAccelerationMagnitude) = value;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x0015F2DB File Offset: 0x0015D4DB
		// (set) Token: 0x0600ECB2 RID: 60594 RVA: 0x0015F2EF File Offset: 0x0015D4EF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> HomingTargetComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_HomingTargetComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_HomingTargetComponent) = value;
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600ECB3 RID: 60595 RVA: 0x0015F304 File Offset: 0x0015D504
		// (set) Token: 0x0600ECB4 RID: 60596 RVA: 0x0015F314 File Offset: 0x0015D514
		public unsafe float MaxSimulationTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSimulationTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSimulationTimeStep) = value;
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600ECB5 RID: 60597 RVA: 0x0015F325 File Offset: 0x0015D525
		// (set) Token: 0x0600ECB6 RID: 60598 RVA: 0x0015F335 File Offset: 0x0015D535
		public unsafe int MaxSimulationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSimulationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_MaxSimulationIterations) = value;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600ECB7 RID: 60599 RVA: 0x0015F346 File Offset: 0x0015D546
		// (set) Token: 0x0600ECB8 RID: 60600 RVA: 0x0015F356 File Offset: 0x0015D556
		public unsafe int BounceAdditionalIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_BounceAdditionalIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_BounceAdditionalIterations) = value;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600ECB9 RID: 60601 RVA: 0x0015F367 File Offset: 0x0015D567
		// (set) Token: 0x0600ECBA RID: 60602 RVA: 0x0015F377 File Offset: 0x0015D577
		public unsafe float InterpLocationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationTime) = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x0015F388 File Offset: 0x0015D588
		// (set) Token: 0x0600ECBC RID: 60604 RVA: 0x0015F398 File Offset: 0x0015D598
		public unsafe float InterpRotationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpRotationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpRotationTime) = value;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600ECBD RID: 60605 RVA: 0x0015F3A9 File Offset: 0x0015D5A9
		// (set) Token: 0x0600ECBE RID: 60606 RVA: 0x0015F3B9 File Offset: 0x0015D5B9
		public unsafe float InterpLocationMaxLagDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationMaxLagDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationMaxLagDistance) = value;
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600ECBF RID: 60607 RVA: 0x0015F3CA File Offset: 0x0015D5CA
		// (set) Token: 0x0600ECC0 RID: 60608 RVA: 0x0015F3DA File Offset: 0x0015D5DA
		public unsafe float InterpLocationSnapToTargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationSnapToTargetDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProjectileMovementComponent.__PropertyOffset_InterpLocationSnapToTargetDistance) = value;
			}
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x0015F3EB File Offset: 0x0015D5EB
		[NullableContext(2)]
		public void StopSimulating(in FHitResult HitResult)
		{
			UProjectileMovementComponent.__StopSimulating_Internal(base.NativePtr, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600ECC2 RID: 60610 RVA: 0x0015F408 File Offset: 0x0015D608
		public void SetVelocityInLocalSpace(FVector NewVelocity)
		{
			UProjectileMovementComponent.__SetVelocityInLocalSpace_Internal(base.NativePtr, NewVelocity);
		}

		// Token: 0x0600ECC3 RID: 60611 RVA: 0x0015F416 File Offset: 0x0015D616
		[NullableContext(2)]
		public void SetInterpolatedComponent(USceneComponent Component)
		{
			UProjectileMovementComponent.__SetInterpolatedComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600ECC4 RID: 60612 RVA: 0x0015F433 File Offset: 0x0015D633
		public void ResetInterpolation()
		{
			UProjectileMovementComponent.__ResetInterpolation_Internal(base.NativePtr);
		}

		// Token: 0x0600ECC5 RID: 60613 RVA: 0x0015F440 File Offset: 0x0015D640
		public void MoveInterpolationTarget(in FVector NewLocation, in FRotator NewRotation)
		{
			UProjectileMovementComponent.__MoveInterpolationTarget_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x0600ECC6 RID: 60614 RVA: 0x0015F44F File Offset: 0x0015D64F
		public FVector LimitVelocity(FVector NewVelocity)
		{
			return UProjectileMovementComponent.__LimitVelocity_Internal(base.NativePtr, NewVelocity);
		}

		// Token: 0x0600ECC7 RID: 60615 RVA: 0x0015F45D File Offset: 0x0015D65D
		public bool IsVelocityUnderSimulationThreshold()
		{
			return UProjectileMovementComponent.__IsVelocityUnderSimulationThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600ECC8 RID: 60616 RVA: 0x0015F46A File Offset: 0x0015D66A
		public bool IsInterpolationComplete()
		{
			return UProjectileMovementComponent.__IsInterpolationComplete_Internal(base.NativePtr);
		}

		// Token: 0x0600ECC9 RID: 60617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulating_Internal(IntPtr @this, IntPtr HitResult);

		// Token: 0x0600ECCA RID: 60618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVelocityInLocalSpace_Internal(IntPtr @this, FVector NewVelocity);

		// Token: 0x0600ECCB RID: 60619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInterpolatedComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x0600ECCC RID: 60620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInterpolation_Internal(IntPtr @this);

		// Token: 0x0600ECCD RID: 60621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveInterpolationTarget_Internal(IntPtr @this, in FVector NewLocation, in FRotator NewRotation);

		// Token: 0x0600ECCE RID: 60622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __LimitVelocity_Internal(IntPtr @this, FVector NewVelocity);

		// Token: 0x0600ECCF RID: 60623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVelocityUnderSimulationThreshold_Internal(IntPtr @this);

		// Token: 0x0600ECD0 RID: 60624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInterpolationComplete_Internal(IntPtr @this);

		// Token: 0x0600ECD1 RID: 60625 RVA: 0x0015F477 File Offset: 0x0015D677
		static UProjectileMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ProjectileMovementComponent");
		}

		// Token: 0x0600ECD2 RID: 60626 RVA: 0x0015F485 File Offset: 0x0015D685
		protected UProjectileMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008005 RID: 32773
		public new const string __ObjectPath = "/Script/Engine.ProjectileMovementComponent";

		// Token: 0x04008006 RID: 32774
		private static IntPtr _ClassPtr;

		// Token: 0x04008007 RID: 32775
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008008 RID: 32776
		public static IntPtr __OnProjectileStopDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04008009 RID: 32777
		public static IntPtr __OnProjectileBounceDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400800A RID: 32778
		internal static int __PropertyOffset_InitialSpeed;

		// Token: 0x0400800B RID: 32779
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400800C RID: 32780
		internal static int __PropertyOffset_bRotationFollowsVelocity;

		// Token: 0x0400800D RID: 32781
		internal static byte __PropertyMask_bRotationFollowsVelocity;

		// Token: 0x0400800E RID: 32782
		internal static int __PropertyOffset_bRotationRemainsVertical;

		// Token: 0x0400800F RID: 32783
		internal static byte __PropertyMask_bRotationRemainsVertical;

		// Token: 0x04008010 RID: 32784
		internal static int __PropertyOffset_bShouldBounce;

		// Token: 0x04008011 RID: 32785
		internal static byte __PropertyMask_bShouldBounce;

		// Token: 0x04008012 RID: 32786
		internal static int __PropertyOffset_bInitialVelocityInLocalSpace;

		// Token: 0x04008013 RID: 32787
		internal static byte __PropertyMask_bInitialVelocityInLocalSpace;

		// Token: 0x04008014 RID: 32788
		internal static int __PropertyOffset_bForceSubStepping;

		// Token: 0x04008015 RID: 32789
		internal static byte __PropertyMask_bForceSubStepping;

		// Token: 0x04008016 RID: 32790
		internal static int __PropertyOffset_bSimulationEnabled;

		// Token: 0x04008017 RID: 32791
		internal static byte __PropertyMask_bSimulationEnabled;

		// Token: 0x04008018 RID: 32792
		internal static int __PropertyOffset_bSweepCollision;

		// Token: 0x04008019 RID: 32793
		internal static byte __PropertyMask_bSweepCollision;

		// Token: 0x0400801A RID: 32794
		internal static int __PropertyOffset_bIsHomingProjectile;

		// Token: 0x0400801B RID: 32795
		internal static byte __PropertyMask_bIsHomingProjectile;

		// Token: 0x0400801C RID: 32796
		internal static int __PropertyOffset_bBounceAngleAffectsFriction;

		// Token: 0x0400801D RID: 32797
		internal static byte __PropertyMask_bBounceAngleAffectsFriction;

		// Token: 0x0400801E RID: 32798
		internal static int __PropertyOffset_bIsSliding;

		// Token: 0x0400801F RID: 32799
		internal static byte __PropertyMask_bIsSliding;

		// Token: 0x04008020 RID: 32800
		internal static int __PropertyOffset_bInterpMovement;

		// Token: 0x04008021 RID: 32801
		internal static byte __PropertyMask_bInterpMovement;

		// Token: 0x04008022 RID: 32802
		internal static int __PropertyOffset_bInterpRotation;

		// Token: 0x04008023 RID: 32803
		internal static byte __PropertyMask_bInterpRotation;

		// Token: 0x04008024 RID: 32804
		internal static int __PropertyOffset_PreviousHitTime;

		// Token: 0x04008025 RID: 32805
		internal static int __PropertyOffset_PreviousHitNormal;

		// Token: 0x04008026 RID: 32806
		internal static int __PropertyOffset_ProjectileGravityScale;

		// Token: 0x04008027 RID: 32807
		internal static int __PropertyOffset_Buoyancy;

		// Token: 0x04008028 RID: 32808
		internal static int __PropertyOffset_Bounciness;

		// Token: 0x04008029 RID: 32809
		internal static int __PropertyOffset_Friction;

		// Token: 0x0400802A RID: 32810
		internal static int __PropertyOffset_BounceVelocityStopSimulatingThreshold;

		// Token: 0x0400802B RID: 32811
		internal static int __PropertyOffset_MinFrictionFraction;

		// Token: 0x0400802C RID: 32812
		internal static int __PropertyOffset_OnProjectileBounce;

		// Token: 0x0400802D RID: 32813
		[Nullable(2)]
		private FOnProjectileBounceDelegate _OnProjectileBounce;

		// Token: 0x0400802E RID: 32814
		internal static int __PropertyOffset_OnProjectileStop;

		// Token: 0x0400802F RID: 32815
		[Nullable(2)]
		private FOnProjectileStopDelegate _OnProjectileStop;

		// Token: 0x04008030 RID: 32816
		internal static int __PropertyOffset_HomingAccelerationMagnitude;

		// Token: 0x04008031 RID: 32817
		internal static int __PropertyOffset_HomingTargetComponent;

		// Token: 0x04008032 RID: 32818
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x04008033 RID: 32819
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x04008034 RID: 32820
		internal static int __PropertyOffset_BounceAdditionalIterations;

		// Token: 0x04008035 RID: 32821
		internal static int __PropertyOffset_InterpLocationTime;

		// Token: 0x04008036 RID: 32822
		internal static int __PropertyOffset_InterpRotationTime;

		// Token: 0x04008037 RID: 32823
		internal static int __PropertyOffset_InterpLocationMaxLagDistance;

		// Token: 0x04008038 RID: 32824
		internal static int __PropertyOffset_InterpLocationSnapToTargetDistance;
	}
}
