using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F28 RID: 7976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroVehicleMovementComponent")]
	[UnrealStructLayout(3488, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3488)]
	public class UKuroVehicleMovementComponent : UPawnMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E411 RID: 123921 RVA: 0x002CF659 File Offset: 0x002CD859
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVehicleMovementComponent._ClassPtr;
		}

		// Token: 0x0601E412 RID: 123922 RVA: 0x002CF668 File Offset: 0x002CD868
		public UKuroVehicleMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVehicleMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E413 RID: 123923 RVA: 0x002CF690 File Offset: 0x002CD890
		public UKuroVehicleMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVehicleMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007817 RID: 30743
		// (get) Token: 0x0601E414 RID: 123924 RVA: 0x002CF6C3 File Offset: 0x002CD8C3
		// (set) Token: 0x0601E415 RID: 123925 RVA: 0x002CF6D7 File Offset: 0x002CD8D7
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

		// Token: 0x17007818 RID: 30744
		// (get) Token: 0x0601E416 RID: 123926 RVA: 0x002CF6EC File Offset: 0x002CD8EC
		// (set) Token: 0x0601E417 RID: 123927 RVA: 0x002CF725 File Offset: 0x002CD925
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

		// Token: 0x17007819 RID: 30745
		// (get) Token: 0x0601E418 RID: 123928 RVA: 0x002CF733 File Offset: 0x002CD933
		// (set) Token: 0x0601E419 RID: 123929 RVA: 0x002CF747 File Offset: 0x002CD947
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

		// Token: 0x1700781A RID: 30746
		// (get) Token: 0x0601E41A RID: 123930 RVA: 0x002CF75C File Offset: 0x002CD95C
		// (set) Token: 0x0601E41B RID: 123931 RVA: 0x002CF770 File Offset: 0x002CD970
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

		// Token: 0x1700781B RID: 30747
		// (get) Token: 0x0601E41C RID: 123932 RVA: 0x002CF785 File Offset: 0x002CD985
		// (set) Token: 0x0601E41D RID: 123933 RVA: 0x002CF799 File Offset: 0x002CD999
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

		// Token: 0x1700781C RID: 30748
		// (get) Token: 0x0601E41E RID: 123934 RVA: 0x002CF7AE File Offset: 0x002CD9AE
		// (set) Token: 0x0601E41F RID: 123935 RVA: 0x002CF7BE File Offset: 0x002CD9BE
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

		// Token: 0x1700781D RID: 30749
		// (get) Token: 0x0601E420 RID: 123936 RVA: 0x002CF7CF File Offset: 0x002CD9CF
		// (set) Token: 0x0601E421 RID: 123937 RVA: 0x002CF7E8 File Offset: 0x002CD9E8
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

		// Token: 0x1700781E RID: 30750
		// (get) Token: 0x0601E422 RID: 123938 RVA: 0x002CF818 File Offset: 0x002CDA18
		// (set) Token: 0x0601E423 RID: 123939 RVA: 0x002CF831 File Offset: 0x002CDA31
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

		// Token: 0x1700781F RID: 30751
		// (get) Token: 0x0601E424 RID: 123940 RVA: 0x002CF861 File Offset: 0x002CDA61
		// (set) Token: 0x0601E425 RID: 123941 RVA: 0x002CF871 File Offset: 0x002CDA71
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

		// Token: 0x17007820 RID: 30752
		// (get) Token: 0x0601E426 RID: 123942 RVA: 0x002CF882 File Offset: 0x002CDA82
		// (set) Token: 0x0601E427 RID: 123943 RVA: 0x002CF892 File Offset: 0x002CDA92
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

		// Token: 0x17007821 RID: 30753
		// (get) Token: 0x0601E428 RID: 123944 RVA: 0x002CF8A3 File Offset: 0x002CDAA3
		// (set) Token: 0x0601E429 RID: 123945 RVA: 0x002CF8B3 File Offset: 0x002CDAB3
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

		// Token: 0x17007822 RID: 30754
		// (get) Token: 0x0601E42A RID: 123946 RVA: 0x002CF8C4 File Offset: 0x002CDAC4
		// (set) Token: 0x0601E42B RID: 123947 RVA: 0x002CF8D4 File Offset: 0x002CDAD4
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

		// Token: 0x17007823 RID: 30755
		// (get) Token: 0x0601E42C RID: 123948 RVA: 0x002CF8E5 File Offset: 0x002CDAE5
		// (set) Token: 0x0601E42D RID: 123949 RVA: 0x002CF8F5 File Offset: 0x002CDAF5
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

		// Token: 0x17007824 RID: 30756
		// (get) Token: 0x0601E42E RID: 123950 RVA: 0x002CF906 File Offset: 0x002CDB06
		// (set) Token: 0x0601E42F RID: 123951 RVA: 0x002CF916 File Offset: 0x002CDB16
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

		// Token: 0x17007825 RID: 30757
		// (get) Token: 0x0601E430 RID: 123952 RVA: 0x002CF927 File Offset: 0x002CDB27
		// (set) Token: 0x0601E431 RID: 123953 RVA: 0x002CF93B File Offset: 0x002CDB3B
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

		// Token: 0x17007826 RID: 30758
		// (get) Token: 0x0601E432 RID: 123954 RVA: 0x002CF950 File Offset: 0x002CDB50
		// (set) Token: 0x0601E433 RID: 123955 RVA: 0x002CF964 File Offset: 0x002CDB64
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

		// Token: 0x17007827 RID: 30759
		// (get) Token: 0x0601E434 RID: 123956 RVA: 0x002CF979 File Offset: 0x002CDB79
		// (set) Token: 0x0601E435 RID: 123957 RVA: 0x002CF989 File Offset: 0x002CDB89
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

		// Token: 0x17007828 RID: 30760
		// (get) Token: 0x0601E436 RID: 123958 RVA: 0x002CF99A File Offset: 0x002CDB9A
		// (set) Token: 0x0601E437 RID: 123959 RVA: 0x002CF9AA File Offset: 0x002CDBAA
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

		// Token: 0x17007829 RID: 30761
		// (get) Token: 0x0601E438 RID: 123960 RVA: 0x002CF9BB File Offset: 0x002CDBBB
		// (set) Token: 0x0601E439 RID: 123961 RVA: 0x002CF9CB File Offset: 0x002CDBCB
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

		// Token: 0x1700782A RID: 30762
		// (get) Token: 0x0601E43A RID: 123962 RVA: 0x002CF9DC File Offset: 0x002CDBDC
		// (set) Token: 0x0601E43B RID: 123963 RVA: 0x002CF9EC File Offset: 0x002CDBEC
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

		// Token: 0x1700782B RID: 30763
		// (get) Token: 0x0601E43C RID: 123964 RVA: 0x002CF9FD File Offset: 0x002CDBFD
		// (set) Token: 0x0601E43D RID: 123965 RVA: 0x002CFA0D File Offset: 0x002CDC0D
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

		// Token: 0x1700782C RID: 30764
		// (get) Token: 0x0601E43E RID: 123966 RVA: 0x002CFA1E File Offset: 0x002CDC1E
		// (set) Token: 0x0601E43F RID: 123967 RVA: 0x002CFA2E File Offset: 0x002CDC2E
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

		// Token: 0x1700782D RID: 30765
		// (get) Token: 0x0601E440 RID: 123968 RVA: 0x002CFA3F File Offset: 0x002CDC3F
		// (set) Token: 0x0601E441 RID: 123969 RVA: 0x002CFA4F File Offset: 0x002CDC4F
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

		// Token: 0x1700782E RID: 30766
		// (get) Token: 0x0601E442 RID: 123970 RVA: 0x002CFA60 File Offset: 0x002CDC60
		// (set) Token: 0x0601E443 RID: 123971 RVA: 0x002CFA70 File Offset: 0x002CDC70
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

		// Token: 0x1700782F RID: 30767
		// (get) Token: 0x0601E444 RID: 123972 RVA: 0x002CFA81 File Offset: 0x002CDC81
		// (set) Token: 0x0601E445 RID: 123973 RVA: 0x002CFA91 File Offset: 0x002CDC91
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

		// Token: 0x17007830 RID: 30768
		// (get) Token: 0x0601E446 RID: 123974 RVA: 0x002CFAA2 File Offset: 0x002CDCA2
		// (set) Token: 0x0601E447 RID: 123975 RVA: 0x002CFAB2 File Offset: 0x002CDCB2
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

		// Token: 0x17007831 RID: 30769
		// (get) Token: 0x0601E448 RID: 123976 RVA: 0x002CFAC3 File Offset: 0x002CDCC3
		// (set) Token: 0x0601E449 RID: 123977 RVA: 0x002CFAD3 File Offset: 0x002CDCD3
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

		// Token: 0x17007832 RID: 30770
		// (get) Token: 0x0601E44A RID: 123978 RVA: 0x002CFAE4 File Offset: 0x002CDCE4
		// (set) Token: 0x0601E44B RID: 123979 RVA: 0x002CFAF4 File Offset: 0x002CDCF4
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

		// Token: 0x17007833 RID: 30771
		// (get) Token: 0x0601E44C RID: 123980 RVA: 0x002CFB05 File Offset: 0x002CDD05
		// (set) Token: 0x0601E44D RID: 123981 RVA: 0x002CFB15 File Offset: 0x002CDD15
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

		// Token: 0x17007834 RID: 30772
		// (get) Token: 0x0601E44E RID: 123982 RVA: 0x002CFB26 File Offset: 0x002CDD26
		// (set) Token: 0x0601E44F RID: 123983 RVA: 0x002CFB36 File Offset: 0x002CDD36
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

		// Token: 0x17007835 RID: 30773
		// (get) Token: 0x0601E450 RID: 123984 RVA: 0x002CFB47 File Offset: 0x002CDD47
		// (set) Token: 0x0601E451 RID: 123985 RVA: 0x002CFB57 File Offset: 0x002CDD57
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

		// Token: 0x17007836 RID: 30774
		// (get) Token: 0x0601E452 RID: 123986 RVA: 0x002CFB68 File Offset: 0x002CDD68
		// (set) Token: 0x0601E453 RID: 123987 RVA: 0x002CFB78 File Offset: 0x002CDD78
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

		// Token: 0x17007837 RID: 30775
		// (get) Token: 0x0601E454 RID: 123988 RVA: 0x002CFB89 File Offset: 0x002CDD89
		// (set) Token: 0x0601E455 RID: 123989 RVA: 0x002CFB99 File Offset: 0x002CDD99
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

		// Token: 0x17007838 RID: 30776
		// (get) Token: 0x0601E456 RID: 123990 RVA: 0x002CFBAA File Offset: 0x002CDDAA
		// (set) Token: 0x0601E457 RID: 123991 RVA: 0x002CFBBA File Offset: 0x002CDDBA
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

		// Token: 0x17007839 RID: 30777
		// (get) Token: 0x0601E458 RID: 123992 RVA: 0x002CFBCB File Offset: 0x002CDDCB
		// (set) Token: 0x0601E459 RID: 123993 RVA: 0x002CFBDB File Offset: 0x002CDDDB
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

		// Token: 0x1700783A RID: 30778
		// (get) Token: 0x0601E45A RID: 123994 RVA: 0x002CFBEC File Offset: 0x002CDDEC
		// (set) Token: 0x0601E45B RID: 123995 RVA: 0x002CFBFC File Offset: 0x002CDDFC
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

		// Token: 0x1700783B RID: 30779
		// (get) Token: 0x0601E45C RID: 123996 RVA: 0x002CFC0D File Offset: 0x002CDE0D
		// (set) Token: 0x0601E45D RID: 123997 RVA: 0x002CFC1D File Offset: 0x002CDE1D
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

		// Token: 0x1700783C RID: 30780
		// (get) Token: 0x0601E45E RID: 123998 RVA: 0x002CFC2E File Offset: 0x002CDE2E
		// (set) Token: 0x0601E45F RID: 123999 RVA: 0x002CFC3E File Offset: 0x002CDE3E
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

		// Token: 0x1700783D RID: 30781
		// (get) Token: 0x0601E460 RID: 124000 RVA: 0x002CFC4F File Offset: 0x002CDE4F
		// (set) Token: 0x0601E461 RID: 124001 RVA: 0x002CFC5F File Offset: 0x002CDE5F
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

		// Token: 0x1700783E RID: 30782
		// (get) Token: 0x0601E462 RID: 124002 RVA: 0x002CFC70 File Offset: 0x002CDE70
		// (set) Token: 0x0601E463 RID: 124003 RVA: 0x002CFC80 File Offset: 0x002CDE80
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

		// Token: 0x1700783F RID: 30783
		// (get) Token: 0x0601E464 RID: 124004 RVA: 0x002CFC91 File Offset: 0x002CDE91
		// (set) Token: 0x0601E465 RID: 124005 RVA: 0x002CFCA1 File Offset: 0x002CDEA1
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

		// Token: 0x17007840 RID: 30784
		// (get) Token: 0x0601E466 RID: 124006 RVA: 0x002CFCB2 File Offset: 0x002CDEB2
		// (set) Token: 0x0601E467 RID: 124007 RVA: 0x002CFCC2 File Offset: 0x002CDEC2
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

		// Token: 0x17007841 RID: 30785
		// (get) Token: 0x0601E468 RID: 124008 RVA: 0x002CFCD3 File Offset: 0x002CDED3
		// (set) Token: 0x0601E469 RID: 124009 RVA: 0x002CFCE3 File Offset: 0x002CDEE3
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

		// Token: 0x17007842 RID: 30786
		// (get) Token: 0x0601E46A RID: 124010 RVA: 0x002CFCF4 File Offset: 0x002CDEF4
		// (set) Token: 0x0601E46B RID: 124011 RVA: 0x002CFD04 File Offset: 0x002CDF04
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

		// Token: 0x17007843 RID: 30787
		// (get) Token: 0x0601E46C RID: 124012 RVA: 0x002CFD15 File Offset: 0x002CDF15
		// (set) Token: 0x0601E46D RID: 124013 RVA: 0x002CFD25 File Offset: 0x002CDF25
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

		// Token: 0x17007844 RID: 30788
		// (get) Token: 0x0601E46E RID: 124014 RVA: 0x002CFD36 File Offset: 0x002CDF36
		// (set) Token: 0x0601E46F RID: 124015 RVA: 0x002CFD46 File Offset: 0x002CDF46
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

		// Token: 0x17007845 RID: 30789
		// (get) Token: 0x0601E470 RID: 124016 RVA: 0x002CFD57 File Offset: 0x002CDF57
		// (set) Token: 0x0601E471 RID: 124017 RVA: 0x002CFD67 File Offset: 0x002CDF67
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

		// Token: 0x17007846 RID: 30790
		// (get) Token: 0x0601E472 RID: 124018 RVA: 0x002CFD78 File Offset: 0x002CDF78
		// (set) Token: 0x0601E473 RID: 124019 RVA: 0x002CFD88 File Offset: 0x002CDF88
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

		// Token: 0x17007847 RID: 30791
		// (get) Token: 0x0601E474 RID: 124020 RVA: 0x002CFD99 File Offset: 0x002CDF99
		// (set) Token: 0x0601E475 RID: 124021 RVA: 0x002CFDAD File Offset: 0x002CDFAD
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

		// Token: 0x17007848 RID: 30792
		// (get) Token: 0x0601E476 RID: 124022 RVA: 0x002CFDC2 File Offset: 0x002CDFC2
		// (set) Token: 0x0601E477 RID: 124023 RVA: 0x002CFDDB File Offset: 0x002CDFDB
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

		// Token: 0x17007849 RID: 30793
		// (get) Token: 0x0601E478 RID: 124024 RVA: 0x002CFE0B File Offset: 0x002CE00B
		// (set) Token: 0x0601E479 RID: 124025 RVA: 0x002CFE24 File Offset: 0x002CE024
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

		// Token: 0x1700784A RID: 30794
		// (get) Token: 0x0601E47A RID: 124026 RVA: 0x002CFE54 File Offset: 0x002CE054
		// (set) Token: 0x0601E47B RID: 124027 RVA: 0x002CFE68 File Offset: 0x002CE068
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

		// Token: 0x1700784B RID: 30795
		// (get) Token: 0x0601E47C RID: 124028 RVA: 0x002CFE7D File Offset: 0x002CE07D
		// (set) Token: 0x0601E47D RID: 124029 RVA: 0x002CFE8D File Offset: 0x002CE08D
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

		// Token: 0x1700784C RID: 30796
		// (get) Token: 0x0601E47E RID: 124030 RVA: 0x002CFE9E File Offset: 0x002CE09E
		// (set) Token: 0x0601E47F RID: 124031 RVA: 0x002CFEB2 File Offset: 0x002CE0B2
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

		// Token: 0x1700784D RID: 30797
		// (get) Token: 0x0601E480 RID: 124032 RVA: 0x002CFEC7 File Offset: 0x002CE0C7
		// (set) Token: 0x0601E481 RID: 124033 RVA: 0x002CFEDB File Offset: 0x002CE0DB
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

		// Token: 0x1700784E RID: 30798
		// (get) Token: 0x0601E482 RID: 124034 RVA: 0x002CFEF0 File Offset: 0x002CE0F0
		// (set) Token: 0x0601E483 RID: 124035 RVA: 0x002CFF04 File Offset: 0x002CE104
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

		// Token: 0x1700784F RID: 30799
		// (get) Token: 0x0601E484 RID: 124036 RVA: 0x002CFF19 File Offset: 0x002CE119
		// (set) Token: 0x0601E485 RID: 124037 RVA: 0x002CFF2D File Offset: 0x002CE12D
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

		// Token: 0x17007850 RID: 30800
		// (get) Token: 0x0601E486 RID: 124038 RVA: 0x002CFF42 File Offset: 0x002CE142
		// (set) Token: 0x0601E487 RID: 124039 RVA: 0x002CFF56 File Offset: 0x002CE156
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

		// Token: 0x17007851 RID: 30801
		// (get) Token: 0x0601E488 RID: 124040 RVA: 0x002CFF6B File Offset: 0x002CE16B
		// (set) Token: 0x0601E489 RID: 124041 RVA: 0x002CFF7F File Offset: 0x002CE17F
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

		// Token: 0x17007852 RID: 30802
		// (get) Token: 0x0601E48A RID: 124042 RVA: 0x002CFF94 File Offset: 0x002CE194
		// (set) Token: 0x0601E48B RID: 124043 RVA: 0x002CFFA8 File Offset: 0x002CE1A8
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

		// Token: 0x17007853 RID: 30803
		// (get) Token: 0x0601E48C RID: 124044 RVA: 0x002CFFBD File Offset: 0x002CE1BD
		// (set) Token: 0x0601E48D RID: 124045 RVA: 0x002CFFD1 File Offset: 0x002CE1D1
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

		// Token: 0x17007854 RID: 30804
		// (get) Token: 0x0601E48E RID: 124046 RVA: 0x002CFFE6 File Offset: 0x002CE1E6
		// (set) Token: 0x0601E48F RID: 124047 RVA: 0x002CFFF6 File Offset: 0x002CE1F6
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

		// Token: 0x17007855 RID: 30805
		// (get) Token: 0x0601E490 RID: 124048 RVA: 0x002D0007 File Offset: 0x002CE207
		// (set) Token: 0x0601E491 RID: 124049 RVA: 0x002D0017 File Offset: 0x002CE217
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

		// Token: 0x17007856 RID: 30806
		// (get) Token: 0x0601E492 RID: 124050 RVA: 0x002D0028 File Offset: 0x002CE228
		// (set) Token: 0x0601E493 RID: 124051 RVA: 0x002D0038 File Offset: 0x002CE238
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

		// Token: 0x17007857 RID: 30807
		// (get) Token: 0x0601E494 RID: 124052 RVA: 0x002D0049 File Offset: 0x002CE249
		// (set) Token: 0x0601E495 RID: 124053 RVA: 0x002D0059 File Offset: 0x002CE259
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

		// Token: 0x17007858 RID: 30808
		// (get) Token: 0x0601E496 RID: 124054 RVA: 0x002D006A File Offset: 0x002CE26A
		// (set) Token: 0x0601E497 RID: 124055 RVA: 0x002D007A File Offset: 0x002CE27A
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

		// Token: 0x17007859 RID: 30809
		// (get) Token: 0x0601E498 RID: 124056 RVA: 0x002D008B File Offset: 0x002CE28B
		// (set) Token: 0x0601E499 RID: 124057 RVA: 0x002D009B File Offset: 0x002CE29B
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

		// Token: 0x1700785A RID: 30810
		// (get) Token: 0x0601E49A RID: 124058 RVA: 0x002D00AC File Offset: 0x002CE2AC
		// (set) Token: 0x0601E49B RID: 124059 RVA: 0x002D00BC File Offset: 0x002CE2BC
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

		// Token: 0x1700785B RID: 30811
		// (get) Token: 0x0601E49C RID: 124060 RVA: 0x002D00CD File Offset: 0x002CE2CD
		// (set) Token: 0x0601E49D RID: 124061 RVA: 0x002D00DD File Offset: 0x002CE2DD
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

		// Token: 0x1700785C RID: 30812
		// (get) Token: 0x0601E49E RID: 124062 RVA: 0x002D00F0 File Offset: 0x002CE2F0
		// (set) Token: 0x0601E49F RID: 124063 RVA: 0x002D0129 File Offset: 0x002CE329
		public FVehicleRootMotionSourceGroup CurrentRootMotion
		{
			get
			{
				base.FastCheckIsValid();
				FVehicleRootMotionSourceGroup result;
				if ((result = this._CurrentRootMotion) == null)
				{
					result = (this._CurrentRootMotion = new FVehicleRootMotionSourceGroup(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_CurrentRootMotion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVehicleRootMotionSourceGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_CurrentRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700785D RID: 30813
		// (get) Token: 0x0601E4A0 RID: 124064 RVA: 0x002D014C File Offset: 0x002CE34C
		// (set) Token: 0x0601E4A1 RID: 124065 RVA: 0x002D0185 File Offset: 0x002CE385
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

		// Token: 0x1700785E RID: 30814
		// (get) Token: 0x0601E4A2 RID: 124066 RVA: 0x002D01A6 File Offset: 0x002CE3A6
		// (set) Token: 0x0601E4A3 RID: 124067 RVA: 0x002D01BA File Offset: 0x002CE3BA
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

		// Token: 0x1700785F RID: 30815
		// (get) Token: 0x0601E4A4 RID: 124068 RVA: 0x002D01CF File Offset: 0x002CE3CF
		// (set) Token: 0x0601E4A5 RID: 124069 RVA: 0x002D01E8 File Offset: 0x002CE3E8
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

		// Token: 0x17007860 RID: 30816
		// (get) Token: 0x0601E4A6 RID: 124070 RVA: 0x002D0218 File Offset: 0x002CE418
		// (set) Token: 0x0601E4A7 RID: 124071 RVA: 0x002D022C File Offset: 0x002CE42C
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

		// Token: 0x17007861 RID: 30817
		// (get) Token: 0x0601E4A8 RID: 124072 RVA: 0x002D0241 File Offset: 0x002CE441
		// (set) Token: 0x0601E4A9 RID: 124073 RVA: 0x002D0251 File Offset: 0x002CE451
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

		// Token: 0x17007862 RID: 30818
		// (get) Token: 0x0601E4AA RID: 124074 RVA: 0x002D0262 File Offset: 0x002CE462
		// (set) Token: 0x0601E4AB RID: 124075 RVA: 0x002D027B File Offset: 0x002CE47B
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

		// Token: 0x17007863 RID: 30819
		// (get) Token: 0x0601E4AC RID: 124076 RVA: 0x002D02AB File Offset: 0x002CE4AB
		// (set) Token: 0x0601E4AD RID: 124077 RVA: 0x002D02BF File Offset: 0x002CE4BF
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

		// Token: 0x17007864 RID: 30820
		// (get) Token: 0x0601E4AE RID: 124078 RVA: 0x002D02D4 File Offset: 0x002CE4D4
		// (set) Token: 0x0601E4AF RID: 124079 RVA: 0x002D02E8 File Offset: 0x002CE4E8
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

		// Token: 0x17007865 RID: 30821
		// (get) Token: 0x0601E4B0 RID: 124080 RVA: 0x002D02FD File Offset: 0x002CE4FD
		// (set) Token: 0x0601E4B1 RID: 124081 RVA: 0x002D030D File Offset: 0x002CE50D
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

		// Token: 0x17007866 RID: 30822
		// (get) Token: 0x0601E4B2 RID: 124082 RVA: 0x002D031E File Offset: 0x002CE51E
		// (set) Token: 0x0601E4B3 RID: 124083 RVA: 0x002D032E File Offset: 0x002CE52E
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

		// Token: 0x17007867 RID: 30823
		// (get) Token: 0x0601E4B4 RID: 124084 RVA: 0x002D033F File Offset: 0x002CE53F
		// (set) Token: 0x0601E4B5 RID: 124085 RVA: 0x002D034F File Offset: 0x002CE54F
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

		// Token: 0x17007868 RID: 30824
		// (get) Token: 0x0601E4B6 RID: 124086 RVA: 0x002D0360 File Offset: 0x002CE560
		// (set) Token: 0x0601E4B7 RID: 124087 RVA: 0x002D0399 File Offset: 0x002CE599
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

		// Token: 0x17007869 RID: 30825
		// (get) Token: 0x0601E4B8 RID: 124088 RVA: 0x002D03BA File Offset: 0x002CE5BA
		// (set) Token: 0x0601E4B9 RID: 124089 RVA: 0x002D03CA File Offset: 0x002CE5CA
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

		// Token: 0x1700786A RID: 30826
		// (get) Token: 0x0601E4BA RID: 124090 RVA: 0x002D03DB File Offset: 0x002CE5DB
		// (set) Token: 0x0601E4BB RID: 124091 RVA: 0x002D03EB File Offset: 0x002CE5EB
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

		// Token: 0x1700786B RID: 30827
		// (get) Token: 0x0601E4BC RID: 124092 RVA: 0x002D03FC File Offset: 0x002CE5FC
		// (set) Token: 0x0601E4BD RID: 124093 RVA: 0x002D040C File Offset: 0x002CE60C
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

		// Token: 0x1700786C RID: 30828
		// (get) Token: 0x0601E4BE RID: 124094 RVA: 0x002D041D File Offset: 0x002CE61D
		// (set) Token: 0x0601E4BF RID: 124095 RVA: 0x002D0431 File Offset: 0x002CE631
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

		// Token: 0x1700786D RID: 30829
		// (get) Token: 0x0601E4C0 RID: 124096 RVA: 0x002D0446 File Offset: 0x002CE646
		// (set) Token: 0x0601E4C1 RID: 124097 RVA: 0x002D0456 File Offset: 0x002CE656
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

		// Token: 0x1700786E RID: 30830
		// (get) Token: 0x0601E4C2 RID: 124098 RVA: 0x002D0467 File Offset: 0x002CE667
		// (set) Token: 0x0601E4C3 RID: 124099 RVA: 0x002D047B File Offset: 0x002CE67B
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

		// Token: 0x1700786F RID: 30831
		// (get) Token: 0x0601E4C4 RID: 124100 RVA: 0x002D0490 File Offset: 0x002CE690
		// (set) Token: 0x0601E4C5 RID: 124101 RVA: 0x002D04C9 File Offset: 0x002CE6C9
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

		// Token: 0x17007870 RID: 30832
		// (get) Token: 0x0601E4C6 RID: 124102 RVA: 0x002D04EA File Offset: 0x002CE6EA
		// (set) Token: 0x0601E4C7 RID: 124103 RVA: 0x002D04FA File Offset: 0x002CE6FA
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

		// Token: 0x17007871 RID: 30833
		// (get) Token: 0x0601E4C8 RID: 124104 RVA: 0x002D050C File Offset: 0x002CE70C
		// (set) Token: 0x0601E4C9 RID: 124105 RVA: 0x002D0545 File Offset: 0x002CE745
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

		// Token: 0x17007872 RID: 30834
		// (get) Token: 0x0601E4CA RID: 124106 RVA: 0x002D0568 File Offset: 0x002CE768
		// (set) Token: 0x0601E4CB RID: 124107 RVA: 0x002D05A1 File Offset: 0x002CE7A1
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

		// Token: 0x17007873 RID: 30835
		// (get) Token: 0x0601E4CC RID: 124108 RVA: 0x002D05C4 File Offset: 0x002CE7C4
		// (set) Token: 0x0601E4CD RID: 124109 RVA: 0x002D05FD File Offset: 0x002CE7FD
		public FMotorContactPhysParams MotorBodyPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorBodyPhys) == null)
				{
					result = (this._MotorBodyPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBodyPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007874 RID: 30836
		// (get) Token: 0x0601E4CE RID: 124110 RVA: 0x002D0620 File Offset: 0x002CE820
		// (set) Token: 0x0601E4CF RID: 124111 RVA: 0x002D0659 File Offset: 0x002CE859
		public FMotorContactPhysParams MotorFrontWheelPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorFrontWheelPhys) == null)
				{
					result = (this._MotorFrontWheelPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorFrontWheelPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorFrontWheelPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007875 RID: 30837
		// (get) Token: 0x0601E4D0 RID: 124112 RVA: 0x002D067C File Offset: 0x002CE87C
		// (set) Token: 0x0601E4D1 RID: 124113 RVA: 0x002D06B5 File Offset: 0x002CE8B5
		public FMotorContactPhysParams MotorBackWheelPhys
		{
			get
			{
				base.FastCheckIsValid();
				FMotorContactPhysParams result;
				if ((result = this._MotorBackWheelPhys) == null)
				{
					result = (this._MotorBackWheelPhys = new FMotorContactPhysParams(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBackWheelPhys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorContactPhysParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBackWheelPhys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007876 RID: 30838
		// (get) Token: 0x0601E4D2 RID: 124114 RVA: 0x002D06D8 File Offset: 0x002CE8D8
		// (set) Token: 0x0601E4D3 RID: 124115 RVA: 0x002D0711 File Offset: 0x002CE911
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

		// Token: 0x17007877 RID: 30839
		// (get) Token: 0x0601E4D4 RID: 124116 RVA: 0x002D0734 File Offset: 0x002CE934
		// (set) Token: 0x0601E4D5 RID: 124117 RVA: 0x002D076D File Offset: 0x002CE96D
		public FMotorBoostConfig MotorBoostConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._MotorBoostConfig) == null)
				{
					result = (this._MotorBoostConfig = new FMotorBoostConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBoostConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBoostConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007878 RID: 30840
		// (get) Token: 0x0601E4D6 RID: 124118 RVA: 0x002D0790 File Offset: 0x002CE990
		// (set) Token: 0x0601E4D7 RID: 124119 RVA: 0x002D07C9 File Offset: 0x002CE9C9
		public FMotorBalanceConfig MotorBalanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBalanceConfig result;
				if ((result = this._MotorBalanceConfig) == null)
				{
					result = (this._MotorBalanceConfig = new FMotorBalanceConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBalanceConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBalanceConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBalanceConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007879 RID: 30841
		// (get) Token: 0x0601E4D8 RID: 124120 RVA: 0x002D07EC File Offset: 0x002CE9EC
		// (set) Token: 0x0601E4D9 RID: 124121 RVA: 0x002D0825 File Offset: 0x002CEA25
		public FMotorBrakingTurnConfig MotorBrakingTurnConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBrakingTurnConfig result;
				if ((result = this._MotorBrakingTurnConfig) == null)
				{
					result = (this._MotorBrakingTurnConfig = new FMotorBrakingTurnConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBrakingTurnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBrakingTurnConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorBrakingTurnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700787A RID: 30842
		// (get) Token: 0x0601E4DA RID: 124122 RVA: 0x002D0848 File Offset: 0x002CEA48
		// (set) Token: 0x0601E4DB RID: 124123 RVA: 0x002D0881 File Offset: 0x002CEA81
		public FMotorSoarConfig MotorSoarConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorSoarConfig result;
				if ((result = this._MotorSoarConfig) == null)
				{
					result = (this._MotorSoarConfig = new FMotorSoarConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorSoarConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorSoarConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorSoarConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700787B RID: 30843
		// (get) Token: 0x0601E4DC RID: 124124 RVA: 0x002D08A4 File Offset: 0x002CEAA4
		// (set) Token: 0x0601E4DD RID: 124125 RVA: 0x002D08DD File Offset: 0x002CEADD
		public FMotorNewDriftConfig MotorNewDriftConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorNewDriftConfig result;
				if ((result = this._MotorNewDriftConfig) == null)
				{
					result = (this._MotorNewDriftConfig = new FMotorNewDriftConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorNewDriftConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorNewDriftConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorNewDriftConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700787C RID: 30844
		// (get) Token: 0x0601E4DE RID: 124126 RVA: 0x002D0900 File Offset: 0x002CEB00
		// (set) Token: 0x0601E4DF RID: 124127 RVA: 0x002D0939 File Offset: 0x002CEB39
		public FMotorTurnConfig MotorTurnConfig
		{
			get
			{
				base.FastCheckIsValid();
				FMotorTurnConfig result;
				if ((result = this._MotorTurnConfig) == null)
				{
					result = (this._MotorTurnConfig = new FMotorTurnConfig(base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorTurnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorTurnConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroVehicleMovementComponent.__PropertyOffset_MotorTurnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700787D RID: 30845
		// (get) Token: 0x0601E4E0 RID: 124128 RVA: 0x002D095A File Offset: 0x002CEB5A
		// (set) Token: 0x0601E4E1 RID: 124129 RVA: 0x002D096A File Offset: 0x002CEB6A
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

		// Token: 0x1700787E RID: 30846
		// (get) Token: 0x0601E4E2 RID: 124130 RVA: 0x002D097B File Offset: 0x002CEB7B
		// (set) Token: 0x0601E4E3 RID: 124131 RVA: 0x002D098B File Offset: 0x002CEB8B
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

		// Token: 0x1700787F RID: 30847
		// (get) Token: 0x0601E4E4 RID: 124132 RVA: 0x002D099C File Offset: 0x002CEB9C
		// (set) Token: 0x0601E4E5 RID: 124133 RVA: 0x002D09B0 File Offset: 0x002CEBB0
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

		// Token: 0x17007880 RID: 30848
		// (get) Token: 0x0601E4E6 RID: 124134 RVA: 0x002D09C5 File Offset: 0x002CEBC5
		// (set) Token: 0x0601E4E7 RID: 124135 RVA: 0x002D09D5 File Offset: 0x002CEBD5
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

		// Token: 0x17007881 RID: 30849
		// (get) Token: 0x0601E4E8 RID: 124136 RVA: 0x002D09E8 File Offset: 0x002CEBE8
		// (set) Token: 0x0601E4E9 RID: 124137 RVA: 0x002D0A21 File Offset: 0x002CEC21
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

		// Token: 0x0601E4EA RID: 124138 RVA: 0x002D0A44 File Offset: 0x002CEC44
		public unsafe void UpdateMotorRailMoveTransform(float DeltaSeconds, FTransformDouble TargetTransform, bool bApplyRootMotion = true, bool bSweep = true)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = TargetTransform;
			UKuroVehicleMovementComponent.__UpdateMotorRailMoveTransform_Internal(base.NativePtr, DeltaSeconds, ptr, bApplyRootMotion, bSweep);
		}

		// Token: 0x0601E4EB RID: 124139 RVA: 0x002D0A78 File Offset: 0x002CEC78
		public void TryMotorcyclingOneStep(int Index)
		{
			UKuroVehicleMovementComponent.__TryMotorcyclingOneStep_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601E4EC RID: 124140 RVA: 0x002D0A86 File Offset: 0x002CEC86
		public void SetSimulatedMotorWheelInfos([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FMotorWheelDisplayInfo> In)
		{
			UKuroVehicleMovementComponent.__SetSimulatedMotorWheelInfos_Internal(base.NativePtr, (In ?? new TArray<FMotorWheelDisplayInfo>()).NativePtr);
		}

		// Token: 0x0601E4ED RID: 124141 RVA: 0x002D0AA3 File Offset: 0x002CECA3
		public void SetRecordTimeLengthAndPeriod(float InMaxTimeLength, float InPeriod)
		{
			UKuroVehicleMovementComponent.__SetRecordTimeLengthAndPeriod_Internal(base.NativePtr, InMaxTimeLength, InPeriod);
		}

		// Token: 0x0601E4EE RID: 124142 RVA: 0x002D0AB2 File Offset: 0x002CECB2
		public void SetMovementMode(EKuroVehicleMovementMode NewMovementMode, byte NewCustomMode = 0)
		{
			UKuroVehicleMovementComponent.__SetMovementMode_Internal(base.NativePtr, NewMovementMode, NewCustomMode);
		}

		// Token: 0x0601E4EF RID: 124143 RVA: 0x002D0AC6 File Offset: 0x002CECC6
		public void SetMotorSubState(EMotorSubState NewSubState)
		{
			UKuroVehicleMovementComponent.__SetMotorSubState_Internal(base.NativePtr, NewSubState);
		}

		// Token: 0x0601E4F0 RID: 124144 RVA: 0x002D0AD4 File Offset: 0x002CECD4
		public void SetMotorRotateSpeed(FVector Axis, float SpeedRad)
		{
			UKuroVehicleMovementComponent.__SetMotorRotateSpeed_Internal(base.NativePtr, Axis, SpeedRad);
		}

		// Token: 0x0601E4F1 RID: 124145 RVA: 0x002D0AE4 File Offset: 0x002CECE4
		public void SetMotorInput(FVector InputDirect, float FrontBraking = 0f, float BackBraking = 0f, FVector? AirRotateInput = null)
		{
			UKuroVehicleMovementComponent.__SetMotorInput_Internal(base.NativePtr, InputDirect, FrontBraking, BackBraking, AirRotateInput ?? new FVector(0f, 0f, 0f));
		}

		// Token: 0x0601E4F2 RID: 124146 RVA: 0x002D0B28 File Offset: 0x002CED28
		public void SetMotionLockMask(bool enable, byte Mask)
		{
			UKuroVehicleMovementComponent.__SetMotionLockMask_Internal(base.NativePtr, enable, Mask);
		}

		// Token: 0x0601E4F3 RID: 124147 RVA: 0x002D0B37 File Offset: 0x002CED37
		public void ResetMotorRailMoveData()
		{
			UKuroVehicleMovementComponent.__ResetMotorRailMoveData_Internal(base.NativePtr);
		}

		// Token: 0x0601E4F4 RID: 124148 RVA: 0x002D0B44 File Offset: 0x002CED44
		public void ResetMotorcycle()
		{
			UKuroVehicleMovementComponent.__ResetMotorcycle_Internal(base.NativePtr);
		}

		// Token: 0x0601E4F5 RID: 124149 RVA: 0x002D0B51 File Offset: 0x002CED51
		public void ResetBaseMovement()
		{
			UKuroVehicleMovementComponent.__ResetBaseMovement_Internal(base.NativePtr);
		}

		// Token: 0x0601E4F6 RID: 124150 RVA: 0x002D0B60 File Offset: 0x002CED60
		public unsafe float MoveMotorcycle(FVector LocationDelta, FQuat QuatDelta, bool bSweep = true)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = QuatDelta;
			return UKuroVehicleMovementComponent.__MoveMotorcycle_Internal(base.NativePtr, LocationDelta, ptr, bSweep);
		}

		// Token: 0x0601E4F7 RID: 124151 RVA: 0x002D0B92 File Offset: 0x002CED92
		public void MotorRemoveSubConfig(FName KeyName)
		{
			UKuroVehicleMovementComponent.__MotorRemoveSubConfig_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0601E4F8 RID: 124152 RVA: 0x002D0BA0 File Offset: 0x002CEDA0
		public void MotorRefreshSubConfig()
		{
			UKuroVehicleMovementComponent.__MotorRefreshSubConfig_Internal(base.NativePtr);
		}

		// Token: 0x0601E4F9 RID: 124153 RVA: 0x002D0BAD File Offset: 0x002CEDAD
		[NullableContext(2)]
		public void MotorInitBaseConfig(UMotorcycleConfigs BaseConfig)
		{
			UKuroVehicleMovementComponent.__MotorInitBaseConfig_Internal(base.NativePtr, (BaseConfig != null) ? BaseConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E4FA RID: 124154 RVA: 0x002D0BCA File Offset: 0x002CEDCA
		[NullableContext(2)]
		public void MotorAddSubConfig(FName KeyName, int Priority, TArray<FName> PropertyNames, UMotorcycleConfigs SubConfig)
		{
			UKuroVehicleMovementComponent.__MotorAddSubConfig_Internal(base.NativePtr, KeyName, Priority, (PropertyNames ?? new TArray<FName>()).NativePtr, (SubConfig != null) ? SubConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E4FB RID: 124155 RVA: 0x002D0BFC File Offset: 0x002CEDFC
		[NullableContext(2)]
		public void KuroShipping_HandlePassiveImpact(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			UKuroVehicleMovementComponent.__KuroShipping_HandlePassiveImpact_Internal(base.NativePtr, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0601E4FC RID: 124156 RVA: 0x002D0C57 File Offset: 0x002CEE57
		public void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UKuroVehicleMovementComponent.__Kuro_SetGravityDirect_Internal(base.NativePtr, InGravityDirect);
		}

		// Token: 0x0601E4FD RID: 124157 RVA: 0x002D0C65 File Offset: 0x002CEE65
		public FVector Kuro_GetGravityDirect()
		{
			return UKuroVehicleMovementComponent.__Kuro_GetGravityDirect_Internal(base.NativePtr);
		}

		// Token: 0x0601E4FE RID: 124158 RVA: 0x002D0C72 File Offset: 0x002CEE72
		public FVector Kuro_GetGravity()
		{
			return UKuroVehicleMovementComponent.__Kuro_GetGravity_Internal(base.NativePtr);
		}

		// Token: 0x0601E4FF RID: 124159 RVA: 0x002D0C80 File Offset: 0x002CEE80
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

		// Token: 0x0601E500 RID: 124160 RVA: 0x002D0CBF File Offset: 0x002CEEBF
		public void InitVehicleShapes()
		{
			UKuroVehicleMovementComponent.__InitVehicleShapes_Internal(base.NativePtr);
		}

		// Token: 0x0601E501 RID: 124161 RVA: 0x002D0CCC File Offset: 0x002CEECC
		public void IgnoreMoveFriction(float Duration)
		{
			UKuroVehicleMovementComponent.__IgnoreMoveFriction_Internal(base.NativePtr, Duration);
		}

		// Token: 0x0601E502 RID: 124162 RVA: 0x002D0CDC File Offset: 0x002CEEDC
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

		// Token: 0x0601E503 RID: 124163 RVA: 0x002D0D06 File Offset: 0x002CEF06
		public string GetRecordDataString(int Index)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroVehicleMovementComponent.__GetRecordDataString_Internal(base.NativePtr, Index));
		}

		// Token: 0x0601E504 RID: 124164 RVA: 0x002D0D19 File Offset: 0x002CEF19
		public FVector GetMotorNormal()
		{
			return UKuroVehicleMovementComponent.__GetMotorNormal_Internal(base.NativePtr);
		}

		// Token: 0x0601E505 RID: 124165 RVA: 0x002D0D26 File Offset: 0x002CEF26
		public FVector GetMotorInputDirect()
		{
			return UKuroVehicleMovementComponent.__GetMotorInputDirect_Internal(base.NativePtr);
		}

		// Token: 0x0601E506 RID: 124166 RVA: 0x002D0D33 File Offset: 0x002CEF33
		public float GetMaxAcceleration()
		{
			return UKuroVehicleMovementComponent.__GetMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x0601E507 RID: 124167 RVA: 0x002D0D40 File Offset: 0x002CEF40
		[NullableContext(2)]
		public bool GetFrontMotorHitResult(ref FHitResult OutHit)
		{
			return UKuroVehicleMovementComponent.__GetFrontMotorHitResult_Internal(base.NativePtr, (OutHit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0601E508 RID: 124168 RVA: 0x002D0D5D File Offset: 0x002CEF5D
		public FVector GetCurrentMotorRearPulling()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorRearPulling_Internal(base.NativePtr);
		}

		// Token: 0x0601E509 RID: 124169 RVA: 0x002D0D6A File Offset: 0x002CEF6A
		public float GetCurrentMotorPower()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorPower_Internal(base.NativePtr);
		}

		// Token: 0x0601E50A RID: 124170 RVA: 0x002D0D77 File Offset: 0x002CEF77
		public FVector GetCurrentMotorFrontPulling()
		{
			return UKuroVehicleMovementComponent.__GetCurrentMotorFrontPulling_Internal(base.NativePtr);
		}

		// Token: 0x0601E50B RID: 124171 RVA: 0x002D0D84 File Offset: 0x002CEF84
		public void GetBaseMovement([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> Out)
		{
			UKuroVehicleMovementComponent.__GetBaseMovement_Internal(base.NativePtr, (Out ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x0601E50C RID: 124172 RVA: 0x002D0DA1 File Offset: 0x002CEFA1
		[NullableContext(2)]
		public bool GetBackMotorHitResult(ref FHitResult OutHit)
		{
			return UKuroVehicleMovementComponent.__GetBackMotorHitResult_Internal(base.NativePtr, (OutHit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0601E50D RID: 124173 RVA: 0x002D0DBE File Offset: 0x002CEFBE
		public void EnableFixFlyMode(bool enable, EFixFlyModeType Type)
		{
			UKuroVehicleMovementComponent.__EnableFixFlyMode_Internal(base.NativePtr, enable, Type);
		}

		// Token: 0x0601E50E RID: 124174 RVA: 0x002D0DCD File Offset: 0x002CEFCD
		public void ClearAllMotorRecord()
		{
			UKuroVehicleMovementComponent.__ClearAllMotorRecord_Internal(base.NativePtr);
		}

		// Token: 0x0601E50F RID: 124175 RVA: 0x002D0DDA File Offset: 0x002CEFDA
		public float BackToRecordByTimeDelta(float DeltaTime)
		{
			return UKuroVehicleMovementComponent.__BackToRecordByTimeDelta_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601E510 RID: 124176 RVA: 0x002D0DE8 File Offset: 0x002CEFE8
		public void BackToRecord(int Index)
		{
			UKuroVehicleMovementComponent.__BackToRecord_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601E511 RID: 124177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMotorRailMoveTransform_Internal(IntPtr @this, float DeltaSeconds, in FTransformDouble TargetTransform, bool bApplyRootMotion, bool bSweep);

		// Token: 0x0601E512 RID: 124178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryMotorcyclingOneStep_Internal(IntPtr @this, int Index);

		// Token: 0x0601E513 RID: 124179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulatedMotorWheelInfos_Internal(IntPtr @this, IntPtr In);

		// Token: 0x0601E514 RID: 124180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRecordTimeLengthAndPeriod_Internal(IntPtr @this, float InMaxTimeLength, float InPeriod);

		// Token: 0x0601E515 RID: 124181
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementMode_Internal(IntPtr @this, TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode, byte NewCustomMode);

		// Token: 0x0601E516 RID: 124182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorSubState_Internal(IntPtr @this, EMotorSubState NewSubState);

		// Token: 0x0601E517 RID: 124183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorRotateSpeed_Internal(IntPtr @this, FVector Axis, float SpeedRad);

		// Token: 0x0601E518 RID: 124184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotorInput_Internal(IntPtr @this, FVector InputDirect, float FrontBraking, float BackBraking, FVector AirRotateInput);

		// Token: 0x0601E519 RID: 124185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotionLockMask_Internal(IntPtr @this, bool enable, byte Mask);

		// Token: 0x0601E51A RID: 124186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMotorRailMoveData_Internal(IntPtr @this);

		// Token: 0x0601E51B RID: 124187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMotorcycle_Internal(IntPtr @this);

		// Token: 0x0601E51C RID: 124188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBaseMovement_Internal(IntPtr @this);

		// Token: 0x0601E51D RID: 124189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __MoveMotorcycle_Internal(IntPtr @this, FVector LocationDelta, in FQuat QuatDelta, bool bSweep);

		// Token: 0x0601E51E RID: 124190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorRemoveSubConfig_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0601E51F RID: 124191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorRefreshSubConfig_Internal(IntPtr @this);

		// Token: 0x0601E520 RID: 124192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorInitBaseConfig_Internal(IntPtr @this, IntPtr BaseConfig);

		// Token: 0x0601E521 RID: 124193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MotorAddSubConfig_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyNames, IntPtr SubConfig);

		// Token: 0x0601E522 RID: 124194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroShipping_HandlePassiveImpact_Internal(IntPtr @this, IntPtr HitComponent, IntPtr OtherActor, IntPtr OtherComp, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x0601E523 RID: 124195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetGravityDirect_Internal(IntPtr @this, FVector InGravityDirect);

		// Token: 0x0601E524 RID: 124196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravityDirect_Internal(IntPtr @this);

		// Token: 0x0601E525 RID: 124197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravity_Internal(IntPtr @this);

		// Token: 0x0601E526 RID: 124198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValidTransform_Internal(IntPtr @this, in FTransformDouble Trans, IntPtr IgnoreActors);

		// Token: 0x0601E527 RID: 124199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitVehicleShapes_Internal(IntPtr @this);

		// Token: 0x0601E528 RID: 124200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreMoveFriction_Internal(IntPtr @this, float Duration);

		// Token: 0x0601E529 RID: 124201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRecordInfo_Internal(IntPtr @this, ref int CurrentIndex, ref int RecordLength);

		// Token: 0x0601E52A RID: 124202
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRecordDataString_Internal(IntPtr @this, int Index);

		// Token: 0x0601E52B RID: 124203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMotorNormal_Internal(IntPtr @this);

		// Token: 0x0601E52C RID: 124204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMotorInputDirect_Internal(IntPtr @this);

		// Token: 0x0601E52D RID: 124205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x0601E52E RID: 124206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFrontMotorHitResult_Internal(IntPtr @this, IntPtr OutHit);

		// Token: 0x0601E52F RID: 124207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentMotorRearPulling_Internal(IntPtr @this);

		// Token: 0x0601E530 RID: 124208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentMotorPower_Internal(IntPtr @this);

		// Token: 0x0601E531 RID: 124209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentMotorFrontPulling_Internal(IntPtr @this);

		// Token: 0x0601E532 RID: 124210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBaseMovement_Internal(IntPtr @this, IntPtr Out);

		// Token: 0x0601E533 RID: 124211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBackMotorHitResult_Internal(IntPtr @this, IntPtr OutHit);

		// Token: 0x0601E534 RID: 124212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFixFlyMode_Internal(IntPtr @this, bool enable, EFixFlyModeType Type);

		// Token: 0x0601E535 RID: 124213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllMotorRecord_Internal(IntPtr @this);

		// Token: 0x0601E536 RID: 124214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __BackToRecordByTimeDelta_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601E537 RID: 124215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BackToRecord_Internal(IntPtr @this, int Index);

		// Token: 0x0601E538 RID: 124216 RVA: 0x002D0DF6 File Offset: 0x002CEFF6
		static UKuroVehicleMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroVehicleMovementComponent");
		}

		// Token: 0x0601E539 RID: 124217 RVA: 0x002D0E04 File Offset: 0x002CF004
		protected UKuroVehicleMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010530 RID: 66864
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementComponent";

		// Token: 0x04010531 RID: 66865
		private static IntPtr _ClassPtr;

		// Token: 0x04010532 RID: 66866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010533 RID: 66867
		internal static int __PropertyOffset_VehicleOwner;

		// Token: 0x04010534 RID: 66868
		internal static int __PropertyOffset_VehicleShapes;

		// Token: 0x04010535 RID: 66869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UShapeComponent> _VehicleShapes;

		// Token: 0x04010536 RID: 66870
		internal static int __PropertyOffset_VehicleShapeBounds;

		// Token: 0x04010537 RID: 66871
		internal static int __PropertyOffset_VehicleShapeBoundsOffset;

		// Token: 0x04010538 RID: 66872
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x04010539 RID: 66873
		internal static int __PropertyOffset_CustomMovementMode;

		// Token: 0x0401053A RID: 66874
		internal static int __PropertyOffset_bEnableScopedMovementUpdates;

		// Token: 0x0401053B RID: 66875
		internal static byte __PropertyMask_bEnableScopedMovementUpdates;

		// Token: 0x0401053C RID: 66876
		internal static int __PropertyOffset_bRunPhysicsWithNoController;

		// Token: 0x0401053D RID: 66877
		internal static byte __PropertyMask_bRunPhysicsWithNoController;

		// Token: 0x0401053E RID: 66878
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x0401053F RID: 66879
		internal static int __PropertyOffset_MaxAcceleration;

		// Token: 0x04010540 RID: 66880
		internal static int __PropertyOffset_MinAcceleration;

		// Token: 0x04010541 RID: 66881
		internal static int __PropertyOffset_MaxBrakeAcceleration;

		// Token: 0x04010542 RID: 66882
		internal static int __PropertyOffset_MaxBackwardAcceleration;

		// Token: 0x04010543 RID: 66883
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x04010544 RID: 66884
		internal static int __PropertyOffset_RotationVelocity;

		// Token: 0x04010545 RID: 66885
		internal static int __PropertyOffset_RotationAcceleration;

		// Token: 0x04010546 RID: 66886
		internal static int __PropertyOffset_MaxFloatingSpeed;

		// Token: 0x04010547 RID: 66887
		internal static int __PropertyOffset_FloatingFrictionFactor;

		// Token: 0x04010548 RID: 66888
		internal static int __PropertyOffset_ForbidGravityDirectMove;

		// Token: 0x04010549 RID: 66889
		internal static int __PropertyOffset_BuoyancyBalanceRatio;

		// Token: 0x0401054A RID: 66890
		internal static int __PropertyOffset_StrandedWaterDepthThreshold;

		// Token: 0x0401054B RID: 66891
		internal static int __PropertyOffset_SafetyDepthTolerrance;

		// Token: 0x0401054C RID: 66892
		internal static int __PropertyOffset_bSafetyDepthCheck;

		// Token: 0x0401054D RID: 66893
		internal static int __PropertyOffset_MaxWaterDiveDist;

		// Token: 0x0401054E RID: 66894
		internal static int __PropertyOffset_MaxBackwardSpeed;

		// Token: 0x0401054F RID: 66895
		internal static int __PropertyOffset_MinFriction;

		// Token: 0x04010550 RID: 66896
		internal static int __PropertyOffset_MaxFriction;

		// Token: 0x04010551 RID: 66897
		internal static int __PropertyOffset_ExtraFrictionWhenExceedMaxSpeed;

		// Token: 0x04010552 RID: 66898
		internal static int __PropertyOffset_MaxRotationSpeed;

		// Token: 0x04010553 RID: 66899
		internal static int __PropertyOffset_MaxRotationYawAcceleration;

		// Token: 0x04010554 RID: 66900
		internal static int __PropertyOffset_MinRotationYawAcceleration;

		// Token: 0x04010555 RID: 66901
		internal static int __PropertyOffset_RotAngleCoef;

		// Token: 0x04010556 RID: 66902
		internal static int __PropertyOffset_RotSpeedCoef;

		// Token: 0x04010557 RID: 66903
		internal static int __PropertyOffset_RotConstCoef;

		// Token: 0x04010558 RID: 66904
		internal static int __PropertyOffset_RotFrictionFactor;

		// Token: 0x04010559 RID: 66905
		internal static int __PropertyOffset_StaticRotFriction;

		// Token: 0x0401055A RID: 66906
		internal static int __PropertyOffset_RotaryInertia;

		// Token: 0x0401055B RID: 66907
		internal static int __PropertyOffset_SpeedImpactFactor;

		// Token: 0x0401055C RID: 66908
		internal static int __PropertyOffset_SpeedImpactHorizontalFactor;

		// Token: 0x0401055D RID: 66909
		internal static int __PropertyOffset_RotationImpactFactor;

		// Token: 0x0401055E RID: 66910
		internal static int __PropertyOffset_MaxExtrutionDistance;

		// Token: 0x0401055F RID: 66911
		internal static int __PropertyOffset_ExtrusionSpeed;

		// Token: 0x04010560 RID: 66912
		internal static int __PropertyOffset_bEnableRotationExtrusion;

		// Token: 0x04010561 RID: 66913
		internal static int __PropertyOffset_RotationExtrusionSpeed;

		// Token: 0x04010562 RID: 66914
		internal static int __PropertyOffset_MaxSafeWaterGravityAngle;

		// Token: 0x04010563 RID: 66915
		internal static int __PropertyOffset_RotPitchFrictionRatio;

		// Token: 0x04010564 RID: 66916
		internal static int __PropertyOffset_MaxRotationPitchAcceleration;

		// Token: 0x04010565 RID: 66917
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x04010566 RID: 66918
		internal static int __PropertyOffset_WaterNormal;

		// Token: 0x04010567 RID: 66919
		internal static int __PropertyOffset_bOrientRotationToMovement;

		// Token: 0x04010568 RID: 66920
		internal static byte __PropertyMask_bOrientRotationToMovement;

		// Token: 0x04010569 RID: 66921
		internal static int __PropertyOffset_bUseControllerDesiredRotation;

		// Token: 0x0401056A RID: 66922
		internal static byte __PropertyMask_bUseControllerDesiredRotation;

		// Token: 0x0401056B RID: 66923
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x0401056C RID: 66924
		internal static int __PropertyOffset_UseNewRotCalculation;

		// Token: 0x0401056D RID: 66925
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0401056E RID: 66926
		internal static int __PropertyOffset_LastUpdateRotation;

		// Token: 0x0401056F RID: 66927
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x04010570 RID: 66928
		internal static int __PropertyOffset_LastUpdateVelocity;

		// Token: 0x04010571 RID: 66929
		internal static int __PropertyOffset_LastUpdateRotationVelocity;

		// Token: 0x04010572 RID: 66930
		internal static int __PropertyOffset_PendingImpulseToApply;

		// Token: 0x04010573 RID: 66931
		internal static int __PropertyOffset_PendingForceToApply;

		// Token: 0x04010574 RID: 66932
		internal static int __PropertyOffset_PendingRotImpluseToApply;

		// Token: 0x04010575 RID: 66933
		internal static int __PropertyOffset_AnalogInputModifier;

		// Token: 0x04010576 RID: 66934
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x04010577 RID: 66935
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x04010578 RID: 66936
		internal static int __PropertyOffset_MaxSimulationRotationIterations;

		// Token: 0x04010579 RID: 66937
		internal static int __PropertyOffset_MaxDepenetrationWithGeometry;

		// Token: 0x0401057A RID: 66938
		internal static int __PropertyOffset_MaxDepenetrationWithGeometryAsProxy;

		// Token: 0x0401057B RID: 66939
		internal static int __PropertyOffset_MaxDepenetrationWithPawn;

		// Token: 0x0401057C RID: 66940
		internal static int __PropertyOffset_MaxDepenetrationWithPawnAsProxy;

		// Token: 0x0401057D RID: 66941
		internal static int __PropertyOffset_CurrentRootMotion;

		// Token: 0x0401057E RID: 66942
		[Nullable(2)]
		private FVehicleRootMotionSourceGroup _CurrentRootMotion;

		// Token: 0x0401057F RID: 66943
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x04010580 RID: 66944
		[Nullable(2)]
		private FRootMotionMovementParams _RootMotionParams;

		// Token: 0x04010581 RID: 66945
		internal static int __PropertyOffset_AnimRootMotionVelocity;

		// Token: 0x04010582 RID: 66946
		internal static int __PropertyOffset_bDeferUpdateMoveComponent;

		// Token: 0x04010583 RID: 66947
		internal static byte __PropertyMask_bDeferUpdateMoveComponent;

		// Token: 0x04010584 RID: 66948
		internal static int __PropertyOffset_DeferredUpdatedMoveComponent;

		// Token: 0x04010585 RID: 66949
		internal static int __PropertyOffset_bForbiddenTickPose;

		// Token: 0x04010586 RID: 66950
		internal static int __PropertyOffset_bMovementInProgress;

		// Token: 0x04010587 RID: 66951
		internal static byte __PropertyMask_bMovementInProgress;

		// Token: 0x04010588 RID: 66952
		internal static int __PropertyOffset_MotorConfigDataTable;

		// Token: 0x04010589 RID: 66953
		internal static int __PropertyOffset_MotorConfigHelper;

		// Token: 0x0401058A RID: 66954
		internal static int __PropertyOffset_bDebugDraw;

		// Token: 0x0401058B RID: 66955
		internal static int __PropertyOffset_bDebugDrawWheel;

		// Token: 0x0401058C RID: 66956
		internal static int __PropertyOffset_bDebugDrawHang;

		// Token: 0x0401058D RID: 66957
		internal static int __PropertyOffset_MotorShapeConfig;

		// Token: 0x0401058E RID: 66958
		[Nullable(2)]
		private FMotorShapeConfig _MotorShapeConfig;

		// Token: 0x0401058F RID: 66959
		internal static int __PropertyOffset_MaxBaseMovementAccel;

		// Token: 0x04010590 RID: 66960
		internal static int __PropertyOffset_MaxBaseMovementRotateAccel;

		// Token: 0x04010591 RID: 66961
		internal static int __PropertyOffset_MotorAirFriction;

		// Token: 0x04010592 RID: 66962
		internal static int __PropertyOffset_UseComplexCollisionSpeedThreshold;

		// Token: 0x04010593 RID: 66963
		internal static int __PropertyOffset_MotorStuckRotateFriction;

		// Token: 0x04010594 RID: 66964
		internal static int __PropertyOffset_MotorBodyAngularLengths;

		// Token: 0x04010595 RID: 66965
		internal static int __PropertyOffset_MotorBodyAngularRateInHitSpeed;

		// Token: 0x04010596 RID: 66966
		[Nullable(2)]
		private FMotorFloatRange _MotorBodyAngularRateInHitSpeed;

		// Token: 0x04010597 RID: 66967
		internal static int __PropertyOffset_HangRotateWeakenWhenTwoWheelOnGroup;

		// Token: 0x04010598 RID: 66968
		internal static int __PropertyOffset_MotorFrontWheelHang;

		// Token: 0x04010599 RID: 66969
		[Nullable(2)]
		private FMotorHangConfigParams _MotorFrontWheelHang;

		// Token: 0x0401059A RID: 66970
		internal static int __PropertyOffset_MotorBackWheelHang;

		// Token: 0x0401059B RID: 66971
		[Nullable(2)]
		private FMotorHangConfigParams _MotorBackWheelHang;

		// Token: 0x0401059C RID: 66972
		internal static int __PropertyOffset_MotorBodyPhys;

		// Token: 0x0401059D RID: 66973
		[Nullable(2)]
		private FMotorContactPhysParams _MotorBodyPhys;

		// Token: 0x0401059E RID: 66974
		internal static int __PropertyOffset_MotorFrontWheelPhys;

		// Token: 0x0401059F RID: 66975
		[Nullable(2)]
		private FMotorContactPhysParams _MotorFrontWheelPhys;

		// Token: 0x040105A0 RID: 66976
		internal static int __PropertyOffset_MotorBackWheelPhys;

		// Token: 0x040105A1 RID: 66977
		[Nullable(2)]
		private FMotorContactPhysParams _MotorBackWheelPhys;

		// Token: 0x040105A2 RID: 66978
		internal static int __PropertyOffset_MotorAccelConfig;

		// Token: 0x040105A3 RID: 66979
		[Nullable(2)]
		private FMotorAccelConfig _MotorAccelConfig;

		// Token: 0x040105A4 RID: 66980
		internal static int __PropertyOffset_MotorBoostConfig;

		// Token: 0x040105A5 RID: 66981
		[Nullable(2)]
		private FMotorBoostConfig _MotorBoostConfig;

		// Token: 0x040105A6 RID: 66982
		internal static int __PropertyOffset_MotorBalanceConfig;

		// Token: 0x040105A7 RID: 66983
		[Nullable(2)]
		private FMotorBalanceConfig _MotorBalanceConfig;

		// Token: 0x040105A8 RID: 66984
		internal static int __PropertyOffset_MotorBrakingTurnConfig;

		// Token: 0x040105A9 RID: 66985
		[Nullable(2)]
		private FMotorBrakingTurnConfig _MotorBrakingTurnConfig;

		// Token: 0x040105AA RID: 66986
		internal static int __PropertyOffset_MotorSoarConfig;

		// Token: 0x040105AB RID: 66987
		[Nullable(2)]
		private FMotorSoarConfig _MotorSoarConfig;

		// Token: 0x040105AC RID: 66988
		internal static int __PropertyOffset_MotorNewDriftConfig;

		// Token: 0x040105AD RID: 66989
		[Nullable(2)]
		private FMotorNewDriftConfig _MotorNewDriftConfig;

		// Token: 0x040105AE RID: 66990
		internal static int __PropertyOffset_MotorTurnConfig;

		// Token: 0x040105AF RID: 66991
		[Nullable(2)]
		private FMotorTurnConfig _MotorTurnConfig;

		// Token: 0x040105B0 RID: 66992
		internal static int __PropertyOffset_RootMotionMask;

		// Token: 0x040105B1 RID: 66993
		internal static int __PropertyOffset_MotorSubState;

		// Token: 0x040105B2 RID: 66994
		internal static int __PropertyOffset_WheelDisplayInfosObj;

		// Token: 0x040105B3 RID: 66995
		internal static int __PropertyOffset_LastMotorHitPart;

		// Token: 0x040105B4 RID: 66996
		internal static int __PropertyOffset_AccumulatedRootMotionInMotorRailMove;

		// Token: 0x040105B5 RID: 66997
		[Nullable(2)]
		private FRootMotionMovementParams _AccumulatedRootMotionInMotorRailMove;
	}
}
