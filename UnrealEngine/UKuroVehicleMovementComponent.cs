using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200062F RID: 1583
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroVehicleMovementComponent")]
	[UnrealStructLayout(3488, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3488)]
	public class UKuroVehicleMovementComponent : UPawnMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089FC RID: 35324 RVA: 0x000CFE37 File Offset: 0x000CE037
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVehicleMovementComponent._ClassPtr;
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x000CFE44 File Offset: 0x000CE044
		public UKuroVehicleMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVehicleMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x000CFE6C File Offset: 0x000CE06C
		public UKuroVehicleMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVehicleMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x060089FF RID: 35327 RVA: 0x000CFE9F File Offset: 0x000CE09F
		// (set) Token: 0x06008A00 RID: 35328 RVA: 0x000CFEB3 File Offset: 0x000CE0B3
		[Nullable(2)]
		public unsafe AKuroBaseVehicle VehicleOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_VehicleOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_VehicleOwner, value);
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x000CFEC8 File Offset: 0x000CE0C8
		// (set) Token: 0x06008A02 RID: 35330 RVA: 0x000CFF01 File Offset: 0x000CE101
		public TArray<UShapeComponent> VehicleShapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UShapeComponent> result;
				if ((result = this._VehicleShapes) == null)
				{
					result = (this._VehicleShapes = new TArray<UShapeComponent>(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_VehicleShapes, this));
				}
				return result;
			}
			set
			{
				this.VehicleShapes.CopyAssign(value);
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06008A03 RID: 35331 RVA: 0x000CFF0F File Offset: 0x000CE10F
		// (set) Token: 0x06008A04 RID: 35332 RVA: 0x000CFF23 File Offset: 0x000CE123
		public unsafe FBoxSphereBounds VehicleShapeBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_VehicleShapeBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_VehicleShapeBounds) = value;
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x000CFF38 File Offset: 0x000CE138
		// (set) Token: 0x06008A06 RID: 35334 RVA: 0x000CFF4C File Offset: 0x000CE14C
		public unsafe FVector VehicleShapeBoundsOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_VehicleShapeBoundsOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_VehicleShapeBoundsOffset) = value;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x000CFF61 File Offset: 0x000CE161
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x000CFF75 File Offset: 0x000CE175
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroVehicleMovementMode> MovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MovementMode) = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x000CFF8A File Offset: 0x000CE18A
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x000CFF9A File Offset: 0x000CE19A
		public unsafe byte CustomMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_CustomMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_CustomMovementMode) = value;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x000CFFAB File Offset: 0x000CE1AB
		// (set) Token: 0x06008A0C RID: 35340 RVA: 0x000CFFC4 File Offset: 0x000CE1C4
		public unsafe bool bEnableScopedMovementUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) & UKuroVehicleMovementComponent.__PropertyMask_bEnableScopedMovementUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) & ~UKuroVehicleMovementComponent.__PropertyMask_bEnableScopedMovementUpdates) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bEnableScopedMovementUpdates : 0));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06008A0D RID: 35341 RVA: 0x000CFFF4 File Offset: 0x000CE1F4
		// (set) Token: 0x06008A0E RID: 35342 RVA: 0x000D000D File Offset: 0x000CE20D
		public unsafe bool bRunPhysicsWithNoController
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) & UKuroVehicleMovementComponent.__PropertyMask_bRunPhysicsWithNoController) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) & ~UKuroVehicleMovementComponent.__PropertyMask_bRunPhysicsWithNoController) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bRunPhysicsWithNoController : 0));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06008A0F RID: 35343 RVA: 0x000D003D File Offset: 0x000CE23D
		// (set) Token: 0x06008A10 RID: 35344 RVA: 0x000D004D File Offset: 0x000CE24D
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x000D005E File Offset: 0x000CE25E
		// (set) Token: 0x06008A12 RID: 35346 RVA: 0x000D006E File Offset: 0x000CE26E
		public unsafe float MaxAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxAcceleration) = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06008A13 RID: 35347 RVA: 0x000D007F File Offset: 0x000CE27F
		// (set) Token: 0x06008A14 RID: 35348 RVA: 0x000D008F File Offset: 0x000CE28F
		public unsafe float MinAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinAcceleration) = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06008A15 RID: 35349 RVA: 0x000D00A0 File Offset: 0x000CE2A0
		// (set) Token: 0x06008A16 RID: 35350 RVA: 0x000D00B0 File Offset: 0x000CE2B0
		public unsafe float MaxBrakeAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBrakeAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBrakeAcceleration) = value;
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06008A17 RID: 35351 RVA: 0x000D00C1 File Offset: 0x000CE2C1
		// (set) Token: 0x06008A18 RID: 35352 RVA: 0x000D00D1 File Offset: 0x000CE2D1
		public unsafe float MaxBackwardAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBackwardAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBackwardAcceleration) = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06008A19 RID: 35353 RVA: 0x000D00E2 File Offset: 0x000CE2E2
		// (set) Token: 0x06008A1A RID: 35354 RVA: 0x000D00F2 File Offset: 0x000CE2F2
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x000D0103 File Offset: 0x000CE303
		// (set) Token: 0x06008A1C RID: 35356 RVA: 0x000D0117 File Offset: 0x000CE317
		public unsafe FRotator RotationVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationVelocity) = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06008A1D RID: 35357 RVA: 0x000D012C File Offset: 0x000CE32C
		// (set) Token: 0x06008A1E RID: 35358 RVA: 0x000D0140 File Offset: 0x000CE340
		public unsafe FRotator RotationAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationAcceleration) = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x000D0155 File Offset: 0x000CE355
		// (set) Token: 0x06008A20 RID: 35360 RVA: 0x000D0165 File Offset: 0x000CE365
		public unsafe float MaxFloatingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxFloatingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxFloatingSpeed) = value;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06008A21 RID: 35361 RVA: 0x000D0176 File Offset: 0x000CE376
		// (set) Token: 0x06008A22 RID: 35362 RVA: 0x000D0186 File Offset: 0x000CE386
		public unsafe float FloatingFrictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_FloatingFrictionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_FloatingFrictionFactor) = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x000D0197 File Offset: 0x000CE397
		// (set) Token: 0x06008A24 RID: 35364 RVA: 0x000D01A7 File Offset: 0x000CE3A7
		public unsafe bool ForbidGravityDirectMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ForbidGravityDirectMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ForbidGravityDirectMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x000D01B8 File Offset: 0x000CE3B8
		// (set) Token: 0x06008A26 RID: 35366 RVA: 0x000D01C8 File Offset: 0x000CE3C8
		public unsafe float BuoyancyBalanceRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_BuoyancyBalanceRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_BuoyancyBalanceRatio) = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x000D01D9 File Offset: 0x000CE3D9
		// (set) Token: 0x06008A28 RID: 35368 RVA: 0x000D01E9 File Offset: 0x000CE3E9
		public unsafe float StrandedWaterDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_StrandedWaterDepthThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_StrandedWaterDepthThreshold) = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06008A29 RID: 35369 RVA: 0x000D01FA File Offset: 0x000CE3FA
		// (set) Token: 0x06008A2A RID: 35370 RVA: 0x000D020A File Offset: 0x000CE40A
		public unsafe float SafetyDepthTolerrance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SafetyDepthTolerrance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SafetyDepthTolerrance) = value;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06008A2B RID: 35371 RVA: 0x000D021B File Offset: 0x000CE41B
		// (set) Token: 0x06008A2C RID: 35372 RVA: 0x000D022B File Offset: 0x000CE42B
		public unsafe bool bSafetyDepthCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bSafetyDepthCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bSafetyDepthCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x000D023C File Offset: 0x000CE43C
		// (set) Token: 0x06008A2E RID: 35374 RVA: 0x000D024C File Offset: 0x000CE44C
		public unsafe float MaxWaterDiveDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxWaterDiveDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxWaterDiveDist) = value;
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x000D025D File Offset: 0x000CE45D
		// (set) Token: 0x06008A30 RID: 35376 RVA: 0x000D026D File Offset: 0x000CE46D
		public unsafe float MaxBackwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBackwardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBackwardSpeed) = value;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06008A31 RID: 35377 RVA: 0x000D027E File Offset: 0x000CE47E
		// (set) Token: 0x06008A32 RID: 35378 RVA: 0x000D028E File Offset: 0x000CE48E
		public unsafe float MinFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinFriction) = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06008A33 RID: 35379 RVA: 0x000D029F File Offset: 0x000CE49F
		// (set) Token: 0x06008A34 RID: 35380 RVA: 0x000D02AF File Offset: 0x000CE4AF
		public unsafe float MaxFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxFriction) = value;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06008A35 RID: 35381 RVA: 0x000D02C0 File Offset: 0x000CE4C0
		// (set) Token: 0x06008A36 RID: 35382 RVA: 0x000D02D0 File Offset: 0x000CE4D0
		public unsafe float ExtraFrictionWhenExceedMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ExtraFrictionWhenExceedMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ExtraFrictionWhenExceedMaxSpeed) = value;
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06008A37 RID: 35383 RVA: 0x000D02E1 File Offset: 0x000CE4E1
		// (set) Token: 0x06008A38 RID: 35384 RVA: 0x000D02F1 File Offset: 0x000CE4F1
		public unsafe float MaxRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationSpeed) = value;
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06008A39 RID: 35385 RVA: 0x000D0302 File Offset: 0x000CE502
		// (set) Token: 0x06008A3A RID: 35386 RVA: 0x000D0312 File Offset: 0x000CE512
		public unsafe float MaxRotationYawAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationYawAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationYawAcceleration) = value;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06008A3B RID: 35387 RVA: 0x000D0323 File Offset: 0x000CE523
		// (set) Token: 0x06008A3C RID: 35388 RVA: 0x000D0333 File Offset: 0x000CE533
		public unsafe float MinRotationYawAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinRotationYawAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MinRotationYawAcceleration) = value;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06008A3D RID: 35389 RVA: 0x000D0344 File Offset: 0x000CE544
		// (set) Token: 0x06008A3E RID: 35390 RVA: 0x000D0354 File Offset: 0x000CE554
		public unsafe float RotAngleCoef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotAngleCoef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotAngleCoef) = value;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06008A3F RID: 35391 RVA: 0x000D0365 File Offset: 0x000CE565
		// (set) Token: 0x06008A40 RID: 35392 RVA: 0x000D0375 File Offset: 0x000CE575
		public unsafe float RotSpeedCoef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotSpeedCoef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotSpeedCoef) = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06008A41 RID: 35393 RVA: 0x000D0386 File Offset: 0x000CE586
		// (set) Token: 0x06008A42 RID: 35394 RVA: 0x000D0396 File Offset: 0x000CE596
		public unsafe float RotConstCoef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotConstCoef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotConstCoef) = value;
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06008A43 RID: 35395 RVA: 0x000D03A7 File Offset: 0x000CE5A7
		// (set) Token: 0x06008A44 RID: 35396 RVA: 0x000D03B7 File Offset: 0x000CE5B7
		public unsafe float RotFrictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotFrictionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotFrictionFactor) = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x000D03C8 File Offset: 0x000CE5C8
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x000D03D8 File Offset: 0x000CE5D8
		public unsafe float StaticRotFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_StaticRotFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_StaticRotFriction) = value;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06008A47 RID: 35399 RVA: 0x000D03E9 File Offset: 0x000CE5E9
		// (set) Token: 0x06008A48 RID: 35400 RVA: 0x000D03F9 File Offset: 0x000CE5F9
		public unsafe float RotaryInertia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotaryInertia);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotaryInertia) = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06008A49 RID: 35401 RVA: 0x000D040A File Offset: 0x000CE60A
		// (set) Token: 0x06008A4A RID: 35402 RVA: 0x000D041A File Offset: 0x000CE61A
		public unsafe float SpeedImpactFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SpeedImpactFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SpeedImpactFactor) = value;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x000D042B File Offset: 0x000CE62B
		// (set) Token: 0x06008A4C RID: 35404 RVA: 0x000D043B File Offset: 0x000CE63B
		public unsafe float SpeedImpactHorizontalFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SpeedImpactHorizontalFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_SpeedImpactHorizontalFactor) = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x000D044C File Offset: 0x000CE64C
		// (set) Token: 0x06008A4E RID: 35406 RVA: 0x000D045C File Offset: 0x000CE65C
		public unsafe float RotationImpactFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationImpactFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationImpactFactor) = value;
			}
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x000D046D File Offset: 0x000CE66D
		// (set) Token: 0x06008A50 RID: 35408 RVA: 0x000D047D File Offset: 0x000CE67D
		public unsafe float MaxExtrutionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxExtrutionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxExtrutionDistance) = value;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x000D048E File Offset: 0x000CE68E
		// (set) Token: 0x06008A52 RID: 35410 RVA: 0x000D049E File Offset: 0x000CE69E
		public unsafe float ExtrusionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ExtrusionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_ExtrusionSpeed) = value;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x000D04AF File Offset: 0x000CE6AF
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x000D04BF File Offset: 0x000CE6BF
		public unsafe bool bEnableRotationExtrusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bEnableRotationExtrusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bEnableRotationExtrusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x000D04D0 File Offset: 0x000CE6D0
		// (set) Token: 0x06008A56 RID: 35414 RVA: 0x000D04E0 File Offset: 0x000CE6E0
		public unsafe float RotationExtrusionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationExtrusionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationExtrusionSpeed) = value;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06008A57 RID: 35415 RVA: 0x000D04F1 File Offset: 0x000CE6F1
		// (set) Token: 0x06008A58 RID: 35416 RVA: 0x000D0501 File Offset: 0x000CE701
		public unsafe float MaxSafeWaterGravityAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSafeWaterGravityAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSafeWaterGravityAngle) = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x000D0512 File Offset: 0x000CE712
		// (set) Token: 0x06008A5A RID: 35418 RVA: 0x000D0522 File Offset: 0x000CE722
		public unsafe float RotPitchFrictionRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotPitchFrictionRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotPitchFrictionRatio) = value;
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x000D0533 File Offset: 0x000CE733
		// (set) Token: 0x06008A5C RID: 35420 RVA: 0x000D0543 File Offset: 0x000CE743
		public unsafe float MaxRotationPitchAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationPitchAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxRotationPitchAcceleration) = value;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x000D0554 File Offset: 0x000CE754
		// (set) Token: 0x06008A5E RID: 35422 RVA: 0x000D0564 File Offset: 0x000CE764
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_WaterDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_WaterDepth) = value;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06008A5F RID: 35423 RVA: 0x000D0575 File Offset: 0x000CE775
		// (set) Token: 0x06008A60 RID: 35424 RVA: 0x000D0589 File Offset: 0x000CE789
		public unsafe FVector WaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_WaterNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_WaterNormal) = value;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06008A61 RID: 35425 RVA: 0x000D059E File Offset: 0x000CE79E
		// (set) Token: 0x06008A62 RID: 35426 RVA: 0x000D05B7 File Offset: 0x000CE7B7
		public unsafe bool bOrientRotationToMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bOrientRotationToMovement) & UKuroVehicleMovementComponent.__PropertyMask_bOrientRotationToMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bOrientRotationToMovement) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bOrientRotationToMovement) & ~UKuroVehicleMovementComponent.__PropertyMask_bOrientRotationToMovement) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bOrientRotationToMovement : 0));
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x000D05E7 File Offset: 0x000CE7E7
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x000D0600 File Offset: 0x000CE800
		public unsafe bool bUseControllerDesiredRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) & UKuroVehicleMovementComponent.__PropertyMask_bUseControllerDesiredRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) & ~UKuroVehicleMovementComponent.__PropertyMask_bUseControllerDesiredRotation) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bUseControllerDesiredRotation : 0));
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x000D0630 File Offset: 0x000CE830
		// (set) Token: 0x06008A66 RID: 35430 RVA: 0x000D0644 File Offset: 0x000CE844
		public unsafe FRotator RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x000D0659 File Offset: 0x000CE859
		// (set) Token: 0x06008A68 RID: 35432 RVA: 0x000D0669 File Offset: 0x000CE869
		public unsafe bool UseNewRotCalculation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_UseNewRotCalculation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_UseNewRotCalculation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x000D067A File Offset: 0x000CE87A
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x000D068E File Offset: 0x000CE88E
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x000D06A3 File Offset: 0x000CE8A3
		// (set) Token: 0x06008A6C RID: 35436 RVA: 0x000D06B7 File Offset: 0x000CE8B7
		public unsafe FQuat LastUpdateRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateRotation) = value;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06008A6D RID: 35437 RVA: 0x000D06CC File Offset: 0x000CE8CC
		// (set) Token: 0x06008A6E RID: 35438 RVA: 0x000D06E0 File Offset: 0x000CE8E0
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateLocation) = value;
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x000D06F5 File Offset: 0x000CE8F5
		// (set) Token: 0x06008A70 RID: 35440 RVA: 0x000D0709 File Offset: 0x000CE909
		public unsafe FVector LastUpdateVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateVelocity) = value;
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06008A71 RID: 35441 RVA: 0x000D071E File Offset: 0x000CE91E
		// (set) Token: 0x06008A72 RID: 35442 RVA: 0x000D0732 File Offset: 0x000CE932
		public unsafe FRotator LastUpdateRotationVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateRotationVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastUpdateRotationVelocity) = value;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06008A73 RID: 35443 RVA: 0x000D0747 File Offset: 0x000CE947
		// (set) Token: 0x06008A74 RID: 35444 RVA: 0x000D075B File Offset: 0x000CE95B
		public unsafe FVector PendingImpulseToApply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingImpulseToApply);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingImpulseToApply) = value;
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x000D0770 File Offset: 0x000CE970
		// (set) Token: 0x06008A76 RID: 35446 RVA: 0x000D0784 File Offset: 0x000CE984
		public unsafe FVector PendingForceToApply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingForceToApply);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingForceToApply) = value;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x000D0799 File Offset: 0x000CE999
		// (set) Token: 0x06008A78 RID: 35448 RVA: 0x000D07AD File Offset: 0x000CE9AD
		public unsafe FRotator PendingRotImpluseToApply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingRotImpluseToApply);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_PendingRotImpluseToApply) = value;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x000D07C2 File Offset: 0x000CE9C2
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x000D07D2 File Offset: 0x000CE9D2
		public unsafe float AnalogInputModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AnalogInputModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AnalogInputModifier) = value;
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06008A7B RID: 35451 RVA: 0x000D07E3 File Offset: 0x000CE9E3
		// (set) Token: 0x06008A7C RID: 35452 RVA: 0x000D07F3 File Offset: 0x000CE9F3
		public unsafe float MaxSimulationTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationTimeStep) = value;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06008A7D RID: 35453 RVA: 0x000D0804 File Offset: 0x000CEA04
		// (set) Token: 0x06008A7E RID: 35454 RVA: 0x000D0814 File Offset: 0x000CEA14
		public unsafe int MaxSimulationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationIterations) = value;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x000D0825 File Offset: 0x000CEA25
		// (set) Token: 0x06008A80 RID: 35456 RVA: 0x000D0835 File Offset: 0x000CEA35
		public unsafe int MaxSimulationRotationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationRotationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxSimulationRotationIterations) = value;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x000D0846 File Offset: 0x000CEA46
		// (set) Token: 0x06008A82 RID: 35458 RVA: 0x000D0856 File Offset: 0x000CEA56
		public unsafe float MaxDepenetrationWithGeometry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometry);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometry) = value;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x000D0867 File Offset: 0x000CEA67
		// (set) Token: 0x06008A84 RID: 35460 RVA: 0x000D0877 File Offset: 0x000CEA77
		public unsafe float MaxDepenetrationWithGeometryAsProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometryAsProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometryAsProxy) = value;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06008A85 RID: 35461 RVA: 0x000D0888 File Offset: 0x000CEA88
		// (set) Token: 0x06008A86 RID: 35462 RVA: 0x000D0898 File Offset: 0x000CEA98
		public unsafe float MaxDepenetrationWithPawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithPawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithPawn) = value;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x000D08A9 File Offset: 0x000CEAA9
		// (set) Token: 0x06008A88 RID: 35464 RVA: 0x000D08B9 File Offset: 0x000CEAB9
		public unsafe float MaxDepenetrationWithPawnAsProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithPawnAsProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxDepenetrationWithPawnAsProxy) = value;
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x000D08CC File Offset: 0x000CEACC
		// (set) Token: 0x06008A8A RID: 35466 RVA: 0x000D0905 File Offset: 0x000CEB05
		public FRootMotionMovementParams RootMotionParams
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionMovementParams result;
				if ((result = this._RootMotionParams) == null)
				{
					result = (this._RootMotionParams = new FRootMotionMovementParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RootMotionParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06008A8B RID: 35467 RVA: 0x000D0926 File Offset: 0x000CEB26
		// (set) Token: 0x06008A8C RID: 35468 RVA: 0x000D093A File Offset: 0x000CEB3A
		public unsafe FVector AnimRootMotionVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AnimRootMotionVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AnimRootMotionVelocity) = value;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x000D094F File Offset: 0x000CEB4F
		// (set) Token: 0x06008A8E RID: 35470 RVA: 0x000D0968 File Offset: 0x000CEB68
		public unsafe bool bDeferUpdateMoveComponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) & UKuroVehicleMovementComponent.__PropertyMask_bDeferUpdateMoveComponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) & ~UKuroVehicleMovementComponent.__PropertyMask_bDeferUpdateMoveComponent) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bDeferUpdateMoveComponent : 0));
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06008A8F RID: 35471 RVA: 0x000D0998 File Offset: 0x000CEB98
		// (set) Token: 0x06008A90 RID: 35472 RVA: 0x000D09AC File Offset: 0x000CEBAC
		[Nullable(2)]
		public unsafe USceneComponent DeferredUpdatedMoveComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent, value);
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06008A91 RID: 35473 RVA: 0x000D09C1 File Offset: 0x000CEBC1
		// (set) Token: 0x06008A92 RID: 35474 RVA: 0x000D09D1 File Offset: 0x000CEBD1
		public unsafe bool bForbiddenTickPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bForbiddenTickPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bForbiddenTickPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x000D09E2 File Offset: 0x000CEBE2
		// (set) Token: 0x06008A94 RID: 35476 RVA: 0x000D09FB File Offset: 0x000CEBFB
		public unsafe bool bMovementInProgress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bMovementInProgress) & UKuroVehicleMovementComponent.__PropertyMask_bMovementInProgress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bMovementInProgress) = ((*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bMovementInProgress) & ~UKuroVehicleMovementComponent.__PropertyMask_bMovementInProgress) | (value ? UKuroVehicleMovementComponent.__PropertyMask_bMovementInProgress : 0));
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06008A95 RID: 35477 RVA: 0x000D0A2B File Offset: 0x000CEC2B
		// (set) Token: 0x06008A96 RID: 35478 RVA: 0x000D0A3F File Offset: 0x000CEC3F
		[Nullable(2)]
		public unsafe UDataTable MotorConfigDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_MotorConfigDataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_MotorConfigDataTable, value);
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06008A97 RID: 35479 RVA: 0x000D0A54 File Offset: 0x000CEC54
		// (set) Token: 0x06008A98 RID: 35480 RVA: 0x000D0A68 File Offset: 0x000CEC68
		[Nullable(2)]
		public unsafe UKuroConfigHelper MotorConfigHelper
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroConfigHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_MotorConfigHelper);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_MotorConfigHelper, value);
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06008A99 RID: 35481 RVA: 0x000D0A7D File Offset: 0x000CEC7D
		// (set) Token: 0x06008A9A RID: 35482 RVA: 0x000D0A8D File Offset: 0x000CEC8D
		public unsafe bool bDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06008A9B RID: 35483 RVA: 0x000D0A9E File Offset: 0x000CEC9E
		// (set) Token: 0x06008A9C RID: 35484 RVA: 0x000D0AAE File Offset: 0x000CECAE
		public unsafe bool bDebugDrawWheel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDrawWheel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDrawWheel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06008A9D RID: 35485 RVA: 0x000D0ABF File Offset: 0x000CECBF
		// (set) Token: 0x06008A9E RID: 35486 RVA: 0x000D0ACF File Offset: 0x000CECCF
		public unsafe bool bDebugDrawHang
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDrawHang) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_bDebugDrawHang) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x000D0AE0 File Offset: 0x000CECE0
		// (set) Token: 0x06008AA0 RID: 35488 RVA: 0x000D0B19 File Offset: 0x000CED19
		public FMotorShapeConfig MotorShapeConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorShapeConfig result;
				if ((result = this._MotorShapeConfig) == null)
				{
					result = (this._MotorShapeConfig = new FMotorShapeConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorShapeConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorShapeConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorShapeConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06008AA1 RID: 35489 RVA: 0x000D0B3A File Offset: 0x000CED3A
		// (set) Token: 0x06008AA2 RID: 35490 RVA: 0x000D0B4A File Offset: 0x000CED4A
		public unsafe float MaxBaseMovementAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBaseMovementAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBaseMovementAccel) = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x000D0B5B File Offset: 0x000CED5B
		// (set) Token: 0x06008AA4 RID: 35492 RVA: 0x000D0B6B File Offset: 0x000CED6B
		public unsafe float MaxBaseMovementRotateAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBaseMovementRotateAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MaxBaseMovementRotateAccel) = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x000D0B7C File Offset: 0x000CED7C
		// (set) Token: 0x06008AA6 RID: 35494 RVA: 0x000D0B8C File Offset: 0x000CED8C
		public unsafe float MotorAirFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorAirFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorAirFriction) = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06008AA7 RID: 35495 RVA: 0x000D0B9D File Offset: 0x000CED9D
		// (set) Token: 0x06008AA8 RID: 35496 RVA: 0x000D0BB1 File Offset: 0x000CEDB1
		public unsafe FFloatRange UseComplexCollisionSpeedThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_UseComplexCollisionSpeedThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_UseComplexCollisionSpeedThreshold) = value;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x000D0BC6 File Offset: 0x000CEDC6
		// (set) Token: 0x06008AAA RID: 35498 RVA: 0x000D0BD6 File Offset: 0x000CEDD6
		public unsafe float MotorStuckRotateFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorStuckRotateFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorStuckRotateFriction) = value;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x000D0BE7 File Offset: 0x000CEDE7
		// (set) Token: 0x06008AAC RID: 35500 RVA: 0x000D0BFB File Offset: 0x000CEDFB
		public unsafe FVector MotorBodyAngularLengths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyAngularLengths);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyAngularLengths) = value;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x000D0C10 File Offset: 0x000CEE10
		// (set) Token: 0x06008AAE RID: 35502 RVA: 0x000D0C49 File Offset: 0x000CEE49
		public FMotorFloatRange MotorBodyAngularRateInHitSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._MotorBodyAngularRateInHitSpeed) == null)
				{
					result = (this._MotorBodyAngularRateInHitSpeed = new FMotorFloatRange(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyAngularRateInHitSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyAngularRateInHitSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06008AAF RID: 35503 RVA: 0x000D0C6A File Offset: 0x000CEE6A
		// (set) Token: 0x06008AB0 RID: 35504 RVA: 0x000D0C7A File Offset: 0x000CEE7A
		public unsafe float HangRotateWeakenWhenTwoWheelOnGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup) = value;
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06008AB1 RID: 35505 RVA: 0x000D0C8C File Offset: 0x000CEE8C
		// (set) Token: 0x06008AB2 RID: 35506 RVA: 0x000D0CC5 File Offset: 0x000CEEC5
		public FMotorHangConfigParams MotorFrontWheelHang
		{
			get
			{
				base.FastCheckIsValid();
				FMotorHangConfigParams result;
				if ((result = this._MotorFrontWheelHang) == null)
				{
					result = (this._MotorFrontWheelHang = new FMotorHangConfigParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorFrontWheelHang, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorHangConfigParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorFrontWheelHang, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06008AB3 RID: 35507 RVA: 0x000D0CE8 File Offset: 0x000CEEE8
		// (set) Token: 0x06008AB4 RID: 35508 RVA: 0x000D0D21 File Offset: 0x000CEF21
		public FMotorHangConfigParams MotorBackWheelHang
		{
			get
			{
				base.FastCheckIsValid();
				FMotorHangConfigParams result;
				if ((result = this._MotorBackWheelHang) == null)
				{
					result = (this._MotorBackWheelHang = new FMotorHangConfigParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBackWheelHang, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorHangConfigParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBackWheelHang, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x000D0D44 File Offset: 0x000CEF44
		// (set) Token: 0x06008AB6 RID: 35510 RVA: 0x000D0D7D File Offset: 0x000CEF7D
		public FMotorAccelConfig MotorAccelConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorAccelConfig result;
				if ((result = this._MotorAccelConfig) == null)
				{
					result = (this._MotorAccelConfig = new FMotorAccelConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorAccelConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorAccelConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorAccelConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x000D0D9E File Offset: 0x000CEF9E
		// (set) Token: 0x06008AB8 RID: 35512 RVA: 0x000D0DAE File Offset: 0x000CEFAE
		public unsafe byte RootMotionMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RootMotionMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_RootMotionMask) = value;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x000D0DBF File Offset: 0x000CEFBF
		// (set) Token: 0x06008ABA RID: 35514 RVA: 0x000D0DCF File Offset: 0x000CEFCF
		public unsafe EMotorSubState MotorSubState
		{
			get
			{
				return (EMotorSubState)(*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorSubState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorSubState) = (byte)value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06008ABB RID: 35515 RVA: 0x000D0DE0 File Offset: 0x000CEFE0
		// (set) Token: 0x06008ABC RID: 35516 RVA: 0x000D0DF4 File Offset: 0x000CEFF4
		[Nullable(2)]
		public unsafe UMotorWheelDisplayInfoObject WheelDisplayInfosObj
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMotorWheelDisplayInfoObject>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_WheelDisplayInfosObj);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroVehicleMovementComponent.__PropertyOffset_WheelDisplayInfosObj, value);
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06008ABD RID: 35517 RVA: 0x000D0E09 File Offset: 0x000CF009
		// (set) Token: 0x06008ABE RID: 35518 RVA: 0x000D0E19 File Offset: 0x000CF019
		public unsafe EMotorPart LastMotorHitPart
		{
			get
			{
				return (EMotorPart)(*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastMotorHitPart));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_LastMotorHitPart) = (byte)value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06008ABF RID: 35519 RVA: 0x000D0E2C File Offset: 0x000CF02C
		// (set) Token: 0x06008AC0 RID: 35520 RVA: 0x000D0E65 File Offset: 0x000CF065
		public FRootMotionMovementParams AccumulatedRootMotionInMotorRailMove
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionMovementParams result;
				if ((result = this._AccumulatedRootMotionInMotorRailMove) == null)
				{
					result = (this._AccumulatedRootMotionInMotorRailMove = new FRootMotionMovementParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AccumulatedRootMotionInMotorRailMove, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_AccumulatedRootMotionInMotorRailMove, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x000D0E88 File Offset: 0x000CF088
		public unsafe void UpdateMotorRailMoveTransform(float DeltaSeconds, FTransformDouble TargetTransform, bool bApplyRootMotion = true, bool bSweep = true)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = TargetTransform;
			UKuroVehicleMovementComponent.__UpdateMotorRailMoveTransform_Internal(base.NativePtr, DeltaSeconds, ptr, bApplyRootMotion, bSweep);
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x000D0EBC File Offset: 0x000CF0BC
		public void TryMotorcyclingOneStep(int Index)
		{
			UKuroVehicleMovementComponent.__TryMotorcyclingOneStep_Internal(base.NativePtr, Index);
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x000D0ECA File Offset: 0x000CF0CA
		public void SetSimulatedMotorWheelInfos([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMotorWheelDisplayInfo> In)
		{
			UKuroVehicleMovementComponent.__SetSimulatedMotorWheelInfos_Internal(base.NativePtr, (In ?? new TArray<FMotorWheelDisplayInfo>()).NativePtr);
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x000D0EE7 File Offset: 0x000CF0E7
		public void SetRecordTimeLengthAndPeriod(float InMaxTimeLength, float InPeriod)
		{
			UKuroVehicleMovementComponent.__SetRecordTimeLengthAndPeriod_Internal(base.NativePtr, InMaxTimeLength, InPeriod);
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x000D0EF6 File Offset: 0x000CF0F6
		public void SetMovementMode(EKuroVehicleMovementMode NewMovementMode, byte NewCustomMode = 0)
		{
			UKuroVehicleMovementComponent.__SetMovementMode_Internal(base.NativePtr, NewMovementMode, NewCustomMode);
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x000D0F0A File Offset: 0x000CF10A
		public void SetMotorSubState(EMotorSubState NewSubState)
		{
			UKuroVehicleMovementComponent.__SetMotorSubState_Internal(base.NativePtr, NewSubState);
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x000D0F18 File Offset: 0x000CF118
		public void SetMotorRotateSpeed(FVector Axis, float SpeedRad)
		{
			UKuroVehicleMovementComponent.__SetMotorRotateSpeed_Internal(base.NativePtr, Axis, SpeedRad);
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x000D0F28 File Offset: 0x000CF128
		public void SetMotorInput(FVector InputDirect, float FrontBraking = 0f, float BackBraking = 0f, FVector? AirRotateInput = null)
		{
			UKuroVehicleMovementComponent.__SetMotorInput_Internal(base.NativePtr, InputDirect, FrontBraking, BackBraking, AirRotateInput ?? new FVector(0f, 0f, 0f));
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x000D0F6C File Offset: 0x000CF16C
		public void SetMotionLockMask(bool enable, byte Mask)
		{
			UKuroVehicleMovementComponent.__SetMotionLockMask_Internal(base.NativePtr, enable, Mask);
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x000D0F7B File Offset: 0x000CF17B
		public void ResetMotorRailMoveData()
		{
			UKuroVehicleMovementComponent.__ResetMotorRailMoveData_Internal(base.NativePtr);
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x000D0F88 File Offset: 0x000CF188
		public void ResetMotorcycle()
		{
			UKuroVehicleMovementComponent.__ResetMotorcycle_Internal(base.NativePtr);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x000D0F95 File Offset: 0x000CF195
		public void ResetBaseMovement()
		{
			UKuroVehicleMovementComponent.__ResetBaseMovement_Internal(base.NativePtr);
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x000D0FA4 File Offset: 0x000CF1A4
		public unsafe float MoveMotorcycle(FVector LocationDelta, FQuat QuatDelta, bool bSweep = true)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = QuatDelta;
			return UKuroVehicleMovementComponent.__MoveMotorcycle_Internal(base.NativePtr, LocationDelta, ptr, bSweep);
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x000D0FD6 File Offset: 0x000CF1D6
		public void MotorRemoveSubConfig(FName KeyName)
		{
			UKuroVehicleMovementComponent.__MotorRemoveSubConfig_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x000D0FE4 File Offset: 0x000CF1E4
		public void MotorRefreshSubConfig()
		{
			UKuroVehicleMovementComponent.__MotorRefreshSubConfig_Internal(base.NativePtr);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x000D0FF1 File Offset: 0x000CF1F1
		[NullableContext(2)]
		public void MotorInitBaseConfig(UMotorcycleConfigs BaseConfig)
		{
			UKuroVehicleMovementComponent.__MotorInitBaseConfig_Internal(base.NativePtr, (BaseConfig != null) ? BaseConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x000D100E File Offset: 0x000CF20E
		[NullableContext(2)]
		public void MotorAddSubConfig(FName KeyName, int Priority, TArray<FName> PropertyNames, UMotorcycleConfigs SubConfig)
		{
			UKuroVehicleMovementComponent.__MotorAddSubConfig_Internal(base.NativePtr, KeyName, Priority, (PropertyNames ?? new TArray<FName>()).NativePtr, (SubConfig != null) ? SubConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x000D1040 File Offset: 0x000CF240
		[NullableContext(2)]
		public void KuroShipping_HandlePassiveImpact(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			UKuroVehicleMovementComponent.__KuroShipping_HandlePassiveImpact_Internal(base.NativePtr, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x000D109B File Offset: 0x000CF29B
		public void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UKuroVehicleMovementComponent.__Kuro_SetGravityDirect_Internal(base.NativePtr, InGravityDirect);
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x000D10A9 File Offset: 0x000CF2A9
		public FVector Kuro_GetGravityDirect()
		{
			return UKuroVehicleMovementComponent.__Kuro_GetGravityDirect_Internal(base.NativePtr);
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x000D10B6 File Offset: 0x000CF2B6
		public FVector Kuro_GetGravity()
		{
			return UKuroVehicleMovementComponent.__Kuro_GetGravity_Internal(base.NativePtr);
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x000D10C4 File Offset: 0x000CF2C4
		public unsafe bool IsValidTransform(FTransformDouble Trans, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> IgnoreActors)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Trans;
			return UKuroVehicleMovementComponent.__IsValidTransform_Internal(base.NativePtr, ptr, (IgnoreActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x000D1103 File Offset: 0x000CF303
		public void InitVehicleShapes()
		{
			UKuroVehicleMovementComponent.__InitVehicleShapes_Internal(base.NativePtr);
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x000D1110 File Offset: 0x000CF310
		public void IgnoreMoveFriction(float Duration)
		{
			UKuroVehicleMovementComponent.__IgnoreMoveFriction_Internal(base.NativePtr, Duration);
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x000D1120 File Offset: 0x000CF320
		public unsafe void GetRecordInfo(ref int CurrentIndex, ref int RecordLength)
		{
			fixed (int* ptr = &CurrentIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &RecordLength)
				{
					void* ptr4 = (void*)ptr3;
					UKuroVehicleMovementComponent.__GetRecordInfo_Internal(base.NativePtr, ref CurrentIndex, ref RecordLength);
					ptr = null;
				}
			}
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x000D114A File Offset: 0x000CF34A
		public string GetRecordDataString(int Index)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroVehicleMovementComponent.__GetRecordDataString_Internal(base.NativePtr, Index));
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x000D115D File Offset: 0x000CF35D
		public FVector GetMotorNormal()
		{
			return UKuroVehicleMovementComponent.__GetMotorNormal_Internal(base.NativePtr);
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x000D116A File Offset: 0x000CF36A
		public FVector GetMotorInputDirect()
		{
			return UKuroVehicleMovementComponent.__GetMotorInputDirect_Internal(base.NativePtr);
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x000D1177 File Offset: 0x000CF377
		public float GetMaxAcceleration()
		{
			return UKuroVehicleMovementComponent.__GetMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x000D1184 File Offset: 0x000CF384
		[NullableContext(2)]
		public bool GetFrontMotorHitResult(ref FHitResult OutHit)
		{
			return UKuroVehicleMovementComponent.__GetFrontMotorHitResult_Internal(base.NativePtr, (OutHit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x000D11A1 File Offset: 0x000CF3A1
		public FVector GetCurrentMotorRearPulling()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorRearPulling_Internal(base.NativePtr);
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x000D11AE File Offset: 0x000CF3AE
		public float GetCurrentMotorPower()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorPower_Internal(base.NativePtr);
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x000D11BB File Offset: 0x000CF3BB
		public FVector GetCurrentMotorFrontPulling()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorFrontPulling_Internal(base.NativePtr);
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x000D11C8 File Offset: 0x000CF3C8
		public void GetBaseMovement([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> Out)
		{
			UKuroVehicleMovementComponent.__GetBaseMovement_Internal(base.NativePtr, (Out ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x000D11E5 File Offset: 0x000CF3E5
		[NullableContext(2)]
		public bool GetBackMotorHitResult(ref FHitResult OutHit)
		{
			return UKuroVehicleMovementComponent.__GetBackMotorHitResult_Internal(base.NativePtr, (OutHit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x000D1202 File Offset: 0x000CF402
		public void EnableFixFlyMode(bool enable, EFixFlyModeType Type)
		{
			UKuroVehicleMovementComponent.__EnableFixFlyMode_Internal(base.NativePtr, enable, Type);
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x000D1211 File Offset: 0x000CF411
		public void ClearAllMotorRecord()
		{
			UKuroVehicleMovementComponent.__ClearAllMotorRecord_Internal(base.NativePtr);
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x000D121E File Offset: 0x000CF41E
		public float BackToRecordByTimeDelta(float DeltaTime)
		{
			return UKuroVehicleMovementComponent.__BackToRecordByTimeDelta_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x000D122C File Offset: 0x000CF42C
		public void BackToRecord(int Index)
		{
			UKuroVehicleMovementComponent.__BackToRecord_Internal(base.NativePtr, Index);
		}

		// Token: 0x06008AE8 RID: 35560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMotorRailMoveTransform_Internal(IntPtr @this, float DeltaSeconds, in FTransformDouble TargetTransform, bool bApplyRootMotion, bool bSweep);

		// Token: 0x06008AE9 RID: 35561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryMotorcyclingOneStep_Internal(IntPtr @this, int Index);

		// Token: 0x06008AEA RID: 35562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulatedMotorWheelInfos_Internal(IntPtr @this, IntPtr In);

		// Token: 0x06008AEB RID: 35563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRecordTimeLengthAndPeriod_Internal(IntPtr @this, float InMaxTimeLength, float InPeriod);

		// Token: 0x06008AEC RID: 35564
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementMode_Internal(IntPtr @this, TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode, byte NewCustomMode);

		// Token: 0x06008AED RID: 35565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorSubState_Internal(IntPtr @this, EMotorSubState NewSubState);

		// Token: 0x06008AEE RID: 35566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorRotateSpeed_Internal(IntPtr @this, FVector Axis, float SpeedRad);

		// Token: 0x06008AEF RID: 35567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorInput_Internal(IntPtr @this, FVector InputDirect, float FrontBraking, float BackBraking, FVector AirRotateInput);

		// Token: 0x06008AF0 RID: 35568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotionLockMask_Internal(IntPtr @this, bool enable, byte Mask);

		// Token: 0x06008AF1 RID: 35569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMotorRailMoveData_Internal(IntPtr @this);

		// Token: 0x06008AF2 RID: 35570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMotorcycle_Internal(IntPtr @this);

		// Token: 0x06008AF3 RID: 35571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBaseMovement_Internal(IntPtr @this);

		// Token: 0x06008AF4 RID: 35572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __MoveMotorcycle_Internal(IntPtr @this, FVector LocationDelta, in FQuat QuatDelta, bool bSweep);

		// Token: 0x06008AF5 RID: 35573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorRemoveSubConfig_Internal(IntPtr @this, FName KeyName);

		// Token: 0x06008AF6 RID: 35574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorRefreshSubConfig_Internal(IntPtr @this);

		// Token: 0x06008AF7 RID: 35575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorInitBaseConfig_Internal(IntPtr @this, IntPtr BaseConfig);

		// Token: 0x06008AF8 RID: 35576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorAddSubConfig_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyNames, IntPtr SubConfig);

		// Token: 0x06008AF9 RID: 35577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroShipping_HandlePassiveImpact_Internal(IntPtr @this, IntPtr HitComponent, IntPtr OtherActor, IntPtr OtherComp, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x06008AFA RID: 35578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetGravityDirect_Internal(IntPtr @this, FVector InGravityDirect);

		// Token: 0x06008AFB RID: 35579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravityDirect_Internal(IntPtr @this);

		// Token: 0x06008AFC RID: 35580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravity_Internal(IntPtr @this);

		// Token: 0x06008AFD RID: 35581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidTransform_Internal(IntPtr @this, in FTransformDouble Trans, IntPtr IgnoreActors);

		// Token: 0x06008AFE RID: 35582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitVehicleShapes_Internal(IntPtr @this);

		// Token: 0x06008AFF RID: 35583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreMoveFriction_Internal(IntPtr @this, float Duration);

		// Token: 0x06008B00 RID: 35584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRecordInfo_Internal(IntPtr @this, ref int CurrentIndex, ref int RecordLength);

		// Token: 0x06008B01 RID: 35585
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRecordDataString_Internal(IntPtr @this, int Index);

		// Token: 0x06008B02 RID: 35586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMotorNormal_Internal(IntPtr @this);

		// Token: 0x06008B03 RID: 35587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMotorInputDirect_Internal(IntPtr @this);

		// Token: 0x06008B04 RID: 35588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x06008B05 RID: 35589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFrontMotorHitResult_Internal(IntPtr @this, IntPtr OutHit);

		// Token: 0x06008B06 RID: 35590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentMotorRearPulling_Internal(IntPtr @this);

		// Token: 0x06008B07 RID: 35591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentMotorPower_Internal(IntPtr @this);

		// Token: 0x06008B08 RID: 35592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentMotorFrontPulling_Internal(IntPtr @this);

		// Token: 0x06008B09 RID: 35593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBaseMovement_Internal(IntPtr @this, IntPtr Out);

		// Token: 0x06008B0A RID: 35594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBackMotorHitResult_Internal(IntPtr @this, IntPtr OutHit);

		// Token: 0x06008B0B RID: 35595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFixFlyMode_Internal(IntPtr @this, bool enable, EFixFlyModeType Type);

		// Token: 0x06008B0C RID: 35596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllMotorRecord_Internal(IntPtr @this);

		// Token: 0x06008B0D RID: 35597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __BackToRecordByTimeDelta_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06008B0E RID: 35598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BackToRecord_Internal(IntPtr @this, int Index);

		// Token: 0x06008B0F RID: 35599 RVA: 0x000D123A File Offset: 0x000CF43A
		static UKuroVehicleMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroVehicleMovementComponent");
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x000D1248 File Offset: 0x000CF448
		protected UKuroVehicleMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BE8 RID: 15336
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementComponent";

		// Token: 0x04003BE9 RID: 15337
		private static IntPtr _ClassPtr;

		// Token: 0x04003BEA RID: 15338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BEB RID: 15339
		internal static int __PropertyOffset_VehicleOwner;

		// Token: 0x04003BEC RID: 15340
		internal static int __PropertyOffset_VehicleShapes;

		// Token: 0x04003BED RID: 15341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UShapeComponent> _VehicleShapes;

		// Token: 0x04003BEE RID: 15342
		internal static int __PropertyOffset_VehicleShapeBounds;

		// Token: 0x04003BEF RID: 15343
		internal static int __PropertyOffset_VehicleShapeBoundsOffset;

		// Token: 0x04003BF0 RID: 15344
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x04003BF1 RID: 15345
		internal static int __PropertyOffset_CustomMovementMode;

		// Token: 0x04003BF2 RID: 15346
		internal static int __PropertyOffset_bEnableScopedMovementUpdates;

		// Token: 0x04003BF3 RID: 15347
		internal static byte __PropertyMask_bEnableScopedMovementUpdates;

		// Token: 0x04003BF4 RID: 15348
		internal static int __PropertyOffset_bRunPhysicsWithNoController;

		// Token: 0x04003BF5 RID: 15349
		internal static byte __PropertyMask_bRunPhysicsWithNoController;

		// Token: 0x04003BF6 RID: 15350
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04003BF7 RID: 15351
		internal static int __PropertyOffset_MaxAcceleration;

		// Token: 0x04003BF8 RID: 15352
		internal static int __PropertyOffset_MinAcceleration;

		// Token: 0x04003BF9 RID: 15353
		internal static int __PropertyOffset_MaxBrakeAcceleration;

		// Token: 0x04003BFA RID: 15354
		internal static int __PropertyOffset_MaxBackwardAcceleration;

		// Token: 0x04003BFB RID: 15355
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x04003BFC RID: 15356
		internal static int __PropertyOffset_RotationVelocity;

		// Token: 0x04003BFD RID: 15357
		internal static int __PropertyOffset_RotationAcceleration;

		// Token: 0x04003BFE RID: 15358
		internal static int __PropertyOffset_MaxFloatingSpeed;

		// Token: 0x04003BFF RID: 15359
		internal static int __PropertyOffset_FloatingFrictionFactor;

		// Token: 0x04003C00 RID: 15360
		internal static int __PropertyOffset_ForbidGravityDirectMove;

		// Token: 0x04003C01 RID: 15361
		internal static int __PropertyOffset_BuoyancyBalanceRatio;

		// Token: 0x04003C02 RID: 15362
		internal static int __PropertyOffset_StrandedWaterDepthThreshold;

		// Token: 0x04003C03 RID: 15363
		internal static int __PropertyOffset_SafetyDepthTolerrance;

		// Token: 0x04003C04 RID: 15364
		internal static int __PropertyOffset_bSafetyDepthCheck;

		// Token: 0x04003C05 RID: 15365
		internal static int __PropertyOffset_MaxWaterDiveDist;

		// Token: 0x04003C06 RID: 15366
		internal static int __PropertyOffset_MaxBackwardSpeed;

		// Token: 0x04003C07 RID: 15367
		internal static int __PropertyOffset_MinFriction;

		// Token: 0x04003C08 RID: 15368
		internal static int __PropertyOffset_MaxFriction;

		// Token: 0x04003C09 RID: 15369
		internal static int __PropertyOffset_ExtraFrictionWhenExceedMaxSpeed;

		// Token: 0x04003C0A RID: 15370
		internal static int __PropertyOffset_MaxRotationSpeed;

		// Token: 0x04003C0B RID: 15371
		internal static int __PropertyOffset_MaxRotationYawAcceleration;

		// Token: 0x04003C0C RID: 15372
		internal static int __PropertyOffset_MinRotationYawAcceleration;

		// Token: 0x04003C0D RID: 15373
		internal static int __PropertyOffset_RotAngleCoef;

		// Token: 0x04003C0E RID: 15374
		internal static int __PropertyOffset_RotSpeedCoef;

		// Token: 0x04003C0F RID: 15375
		internal static int __PropertyOffset_RotConstCoef;

		// Token: 0x04003C10 RID: 15376
		internal static int __PropertyOffset_RotFrictionFactor;

		// Token: 0x04003C11 RID: 15377
		internal static int __PropertyOffset_StaticRotFriction;

		// Token: 0x04003C12 RID: 15378
		internal static int __PropertyOffset_RotaryInertia;

		// Token: 0x04003C13 RID: 15379
		internal static int __PropertyOffset_SpeedImpactFactor;

		// Token: 0x04003C14 RID: 15380
		internal static int __PropertyOffset_SpeedImpactHorizontalFactor;

		// Token: 0x04003C15 RID: 15381
		internal static int __PropertyOffset_RotationImpactFactor;

		// Token: 0x04003C16 RID: 15382
		internal static int __PropertyOffset_MaxExtrutionDistance;

		// Token: 0x04003C17 RID: 15383
		internal static int __PropertyOffset_ExtrusionSpeed;

		// Token: 0x04003C18 RID: 15384
		internal static int __PropertyOffset_bEnableRotationExtrusion;

		// Token: 0x04003C19 RID: 15385
		internal static int __PropertyOffset_RotationExtrusionSpeed;

		// Token: 0x04003C1A RID: 15386
		internal static int __PropertyOffset_MaxSafeWaterGravityAngle;

		// Token: 0x04003C1B RID: 15387
		internal static int __PropertyOffset_RotPitchFrictionRatio;

		// Token: 0x04003C1C RID: 15388
		internal static int __PropertyOffset_MaxRotationPitchAcceleration;

		// Token: 0x04003C1D RID: 15389
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x04003C1E RID: 15390
		internal static int __PropertyOffset_WaterNormal;

		// Token: 0x04003C1F RID: 15391
		internal static int __PropertyOffset_bOrientRotationToMovement;

		// Token: 0x04003C20 RID: 15392
		internal static byte __PropertyMask_bOrientRotationToMovement;

		// Token: 0x04003C21 RID: 15393
		internal static int __PropertyOffset_bUseControllerDesiredRotation;

		// Token: 0x04003C22 RID: 15394
		internal static byte __PropertyMask_bUseControllerDesiredRotation;

		// Token: 0x04003C23 RID: 15395
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x04003C24 RID: 15396
		internal static int __PropertyOffset_UseNewRotCalculation;

		// Token: 0x04003C25 RID: 15397
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04003C26 RID: 15398
		internal static int __PropertyOffset_LastUpdateRotation;

		// Token: 0x04003C27 RID: 15399
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x04003C28 RID: 15400
		internal static int __PropertyOffset_LastUpdateVelocity;

		// Token: 0x04003C29 RID: 15401
		internal static int __PropertyOffset_LastUpdateRotationVelocity;

		// Token: 0x04003C2A RID: 15402
		internal static int __PropertyOffset_PendingImpulseToApply;

		// Token: 0x04003C2B RID: 15403
		internal static int __PropertyOffset_PendingForceToApply;

		// Token: 0x04003C2C RID: 15404
		internal static int __PropertyOffset_PendingRotImpluseToApply;

		// Token: 0x04003C2D RID: 15405
		internal static int __PropertyOffset_AnalogInputModifier;

		// Token: 0x04003C2E RID: 15406
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x04003C2F RID: 15407
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x04003C30 RID: 15408
		internal static int __PropertyOffset_MaxSimulationRotationIterations;

		// Token: 0x04003C31 RID: 15409
		internal static int __PropertyOffset_MaxDepenetrationWithGeometry;

		// Token: 0x04003C32 RID: 15410
		internal static int __PropertyOffset_MaxDepenetrationWithGeometryAsProxy;

		// Token: 0x04003C33 RID: 15411
		internal static int __PropertyOffset_MaxDepenetrationWithPawn;

		// Token: 0x04003C34 RID: 15412
		internal static int __PropertyOffset_MaxDepenetrationWithPawnAsProxy;

		// Token: 0x04003C35 RID: 15413
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x04003C36 RID: 15414
		[Nullable(2)]
		private FRootMotionMovementParams _RootMotionParams;

		// Token: 0x04003C37 RID: 15415
		internal static int __PropertyOffset_AnimRootMotionVelocity;

		// Token: 0x04003C38 RID: 15416
		internal static int __PropertyOffset_bDeferUpdateMoveComponent;

		// Token: 0x04003C39 RID: 15417
		internal static byte __PropertyMask_bDeferUpdateMoveComponent;

		// Token: 0x04003C3A RID: 15418
		internal static int __PropertyOffset_DeferredUpdatedMoveComponent;

		// Token: 0x04003C3B RID: 15419
		internal static int __PropertyOffset_bForbiddenTickPose;

		// Token: 0x04003C3C RID: 15420
		internal static int __PropertyOffset_bMovementInProgress;

		// Token: 0x04003C3D RID: 15421
		internal static byte __PropertyMask_bMovementInProgress;

		// Token: 0x04003C3E RID: 15422
		internal static int __PropertyOffset_MotorConfigDataTable;

		// Token: 0x04003C3F RID: 15423
		internal static int __PropertyOffset_MotorConfigHelper;

		// Token: 0x04003C40 RID: 15424
		internal static int __PropertyOffset_bDebugDraw;

		// Token: 0x04003C41 RID: 15425
		internal static int __PropertyOffset_bDebugDrawWheel;

		// Token: 0x04003C42 RID: 15426
		internal static int __PropertyOffset_bDebugDrawHang;

		// Token: 0x04003C43 RID: 15427
		internal static int __PropertyOffset_MotorShapeConfig;

		// Token: 0x04003C44 RID: 15428
		[Nullable(2)]
		private FMotorShapeConfig _MotorShapeConfig;

		// Token: 0x04003C45 RID: 15429
		internal static int __PropertyOffset_MaxBaseMovementAccel;

		// Token: 0x04003C46 RID: 15430
		internal static int __PropertyOffset_MaxBaseMovementRotateAccel;

		// Token: 0x04003C47 RID: 15431
		internal static int __PropertyOffset_MotorAirFriction;

		// Token: 0x04003C48 RID: 15432
		internal static int __PropertyOffset_UseComplexCollisionSpeedThreshold;

		// Token: 0x04003C49 RID: 15433
		internal static int __PropertyOffset_MotorStuckRotateFriction;

		// Token: 0x04003C4A RID: 15434
		internal static int __PropertyOffset_MotorBodyAngularLengths;

		// Token: 0x04003C4B RID: 15435
		internal static int __PropertyOffset_MotorBodyAngularRateInHitSpeed;

		// Token: 0x04003C4C RID: 15436
		[Nullable(2)]
		private FMotorFloatRange _MotorBodyAngularRateInHitSpeed;

		// Token: 0x04003C4D RID: 15437
		internal static int __PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup;

		// Token: 0x04003C4E RID: 15438
		internal static int __PropertyOffset_MotorFrontWheelHang;

		// Token: 0x04003C4F RID: 15439
		[Nullable(2)]
		private FMotorHangConfigParams _MotorFrontWheelHang;

		// Token: 0x04003C50 RID: 15440
		internal static int __PropertyOffset_MotorBackWheelHang;

		// Token: 0x04003C51 RID: 15441
		[Nullable(2)]
		private FMotorHangConfigParams _MotorBackWheelHang;

		// Token: 0x04003C52 RID: 15442
		internal static int __PropertyOffset_MotorAccelConfig;

		// Token: 0x04003C53 RID: 15443
		[Nullable(2)]
		private FMotorAccelConfig _MotorAccelConfig;

		// Token: 0x04003C54 RID: 15444
		internal static int __PropertyOffset_RootMotionMask;

		// Token: 0x04003C55 RID: 15445
		internal static int __PropertyOffset_MotorSubState;

		// Token: 0x04003C56 RID: 15446
		internal static int __PropertyOffset_WheelDisplayInfosObj;

		// Token: 0x04003C57 RID: 15447
		internal static int __PropertyOffset_LastMotorHitPart;

		// Token: 0x04003C58 RID: 15448
		internal static int __PropertyOffset_AccumulatedRootMotionInMotorRailMove;

		// Token: 0x04003C59 RID: 15449
		[Nullable(2)]
		private FRootMotionMovementParams _AccumulatedRootMotionInMotorRailMove;
	}
}
