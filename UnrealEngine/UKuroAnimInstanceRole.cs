using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165A RID: 5722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceRole")]
	[UnrealStructLayout(3744, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3744)]
	public class UKuroAnimInstanceRole : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014A42 RID: 84546 RVA: 0x001E6286 File Offset: 0x001E4486
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceRole._ClassPtr;
		}

		// Token: 0x06014A43 RID: 84547 RVA: 0x001E6294 File Offset: 0x001E4494
		public UKuroAnimInstanceRole() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014A44 RID: 84548 RVA: 0x001E62BC File Offset: 0x001E44BC
		public UKuroAnimInstanceRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x06014A45 RID: 84549 RVA: 0x001E62F0 File Offset: 0x001E44F0
		// (set) Token: 0x06014A46 RID: 84550 RVA: 0x001E6329 File Offset: 0x001E4529
		public TArray<int> ValidPerformanceIndexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ValidPerformanceIndexes) == null)
				{
					result = (this._ValidPerformanceIndexes = new TArray<int>(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ValidPerformanceIndexes, this));
				}
				return result;
			}
			set
			{
				this.ValidPerformanceIndexes.CopyAssign(value);
			}
		}

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x06014A47 RID: 84551 RVA: 0x001E6337 File Offset: 0x001E4537
		// (set) Token: 0x06014A48 RID: 84552 RVA: 0x001E6347 File Offset: 0x001E4547
		public unsafe float FloorSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FloorSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FloorSpeed) = value;
			}
		}

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x06014A49 RID: 84553 RVA: 0x001E6358 File Offset: 0x001E4558
		// (set) Token: 0x06014A4A RID: 84554 RVA: 0x001E6368 File Offset: 0x001E4568
		public unsafe bool bCanbeInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCanbeInterrupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCanbeInterrupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x06014A4B RID: 84555 RVA: 0x001E6379 File Offset: 0x001E4579
		// (set) Token: 0x06014A4C RID: 84556 RVA: 0x001E6389 File Offset: 0x001E4589
		public unsafe bool bMoveBlock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bMoveBlock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bMoveBlock) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x06014A4D RID: 84557 RVA: 0x001E639A File Offset: 0x001E459A
		// (set) Token: 0x06014A4E RID: 84558 RVA: 0x001E63AA File Offset: 0x001E45AA
		public unsafe float TimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_TimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_TimeSeconds) = value;
			}
		}

		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x06014A4F RID: 84559 RVA: 0x001E63BB File Offset: 0x001E45BB
		// (set) Token: 0x06014A50 RID: 84560 RVA: 0x001E63CB File Offset: 0x001E45CB
		public unsafe bool bIsNotNPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsNotNPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsNotNPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x06014A51 RID: 84561 RVA: 0x001E63DC File Offset: 0x001E45DC
		// (set) Token: 0x06014A52 RID: 84562 RVA: 0x001E63EC File Offset: 0x001E45EC
		public unsafe int ChangeRoleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ChangeRoleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ChangeRoleCount) = value;
			}
		}

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x06014A53 RID: 84563 RVA: 0x001E63FD File Offset: 0x001E45FD
		// (set) Token: 0x06014A54 RID: 84564 RVA: 0x001E640D File Offset: 0x001E460D
		public unsafe bool bHasNPCTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHasNPCTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHasNPCTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x06014A55 RID: 84565 RVA: 0x001E641E File Offset: 0x001E461E
		// (set) Token: 0x06014A56 RID: 84566 RVA: 0x001E642E File Offset: 0x001E462E
		public unsafe bool bIsGoingToMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsGoingToMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsGoingToMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x06014A57 RID: 84567 RVA: 0x001E643F File Offset: 0x001E463F
		// (set) Token: 0x06014A58 RID: 84568 RVA: 0x001E644F File Offset: 0x001E464F
		public unsafe float TurnMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_TurnMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_TurnMix) = value;
			}
		}

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x06014A59 RID: 84569 RVA: 0x001E6460 File Offset: 0x001E4660
		// (set) Token: 0x06014A5A RID: 84570 RVA: 0x001E6474 File Offset: 0x001E4674
		public unsafe FVeloctiyBlend SpeedMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SpeedMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SpeedMix) = value;
			}
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x06014A5B RID: 84571 RVA: 0x001E6489 File Offset: 0x001E4689
		// (set) Token: 0x06014A5C RID: 84572 RVA: 0x001E6499 File Offset: 0x001E4699
		public unsafe float LerpSpeedAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LerpSpeedAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LerpSpeedAlpha) = value;
			}
		}

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x06014A5D RID: 84573 RVA: 0x001E64AA File Offset: 0x001E46AA
		// (set) Token: 0x06014A5E RID: 84574 RVA: 0x001E64BE File Offset: 0x001E46BE
		public unsafe FVector2D AimMoveMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimMoveMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimMoveMix) = value;
			}
		}

		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x06014A5F RID: 84575 RVA: 0x001E64D3 File Offset: 0x001E46D3
		// (set) Token: 0x06014A60 RID: 84576 RVA: 0x001E64E7 File Offset: 0x001E46E7
		public unsafe FVector LocalAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LocalAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LocalAccel) = value;
			}
		}

		// Token: 0x17005159 RID: 20825
		// (get) Token: 0x06014A61 RID: 84577 RVA: 0x001E64FC File Offset: 0x001E46FC
		// (set) Token: 0x06014A62 RID: 84578 RVA: 0x001E6535 File Offset: 0x001E4735
		public FLeanAmount LeanAmount
		{
			get
			{
				base.FastCheckIsValid();
				FLeanAmount result;
				if ((result = this._LeanAmount) == null)
				{
					result = (this._LeanAmount = new FLeanAmount(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LeanAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLeanAmount.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LeanAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x06014A63 RID: 84579 RVA: 0x001E6556 File Offset: 0x001E4756
		// (set) Token: 0x06014A64 RID: 84580 RVA: 0x001E6566 File Offset: 0x001E4766
		public unsafe EMoveDirection MoveDirection
		{
			get
			{
				return (EMoveDirection)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MoveDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MoveDirection) = (byte)value;
			}
		}

		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x06014A65 RID: 84581 RVA: 0x001E6577 File Offset: 0x001E4777
		// (set) Token: 0x06014A66 RID: 84582 RVA: 0x001E6587 File Offset: 0x001E4787
		public unsafe float GroundMovePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GroundMovePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GroundMovePlayRate) = value;
			}
		}

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x06014A67 RID: 84583 RVA: 0x001E6598 File Offset: 0x001E4798
		// (set) Token: 0x06014A68 RID: 84584 RVA: 0x001E65A8 File Offset: 0x001E47A8
		public unsafe float WalkRunMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_WalkRunMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_WalkRunMix) = value;
			}
		}

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x06014A69 RID: 84585 RVA: 0x001E65B9 File Offset: 0x001E47B9
		// (set) Token: 0x06014A6A RID: 84586 RVA: 0x001E65C9 File Offset: 0x001E47C9
		public unsafe float StepSizeMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StepSizeMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StepSizeMix) = value;
			}
		}

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x06014A6B RID: 84587 RVA: 0x001E65DA File Offset: 0x001E47DA
		// (set) Token: 0x06014A6C RID: 84588 RVA: 0x001E65EE File Offset: 0x001E47EE
		public unsafe FVeloctiyBlend AccelLerpMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AccelLerpMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AccelLerpMix) = value;
			}
		}

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x06014A6D RID: 84589 RVA: 0x001E6603 File Offset: 0x001E4803
		// (set) Token: 0x06014A6E RID: 84590 RVA: 0x001E6613 File Offset: 0x001E4813
		public unsafe float AimYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimYaw) = value;
			}
		}

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x06014A6F RID: 84591 RVA: 0x001E6624 File Offset: 0x001E4824
		// (set) Token: 0x06014A70 RID: 84592 RVA: 0x001E6634 File Offset: 0x001E4834
		public unsafe float AimPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimPitch) = value;
			}
		}

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x06014A71 RID: 84593 RVA: 0x001E6645 File Offset: 0x001E4845
		// (set) Token: 0x06014A72 RID: 84594 RVA: 0x001E6655 File Offset: 0x001E4855
		public unsafe bool bIsFightStand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsFightStand) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsFightStand) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x06014A73 RID: 84595 RVA: 0x001E6666 File Offset: 0x001E4866
		// (set) Token: 0x06014A74 RID: 84596 RVA: 0x001E667A File Offset: 0x001E487A
		public unsafe FVector2D MoveMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MoveMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MoveMix) = value;
			}
		}

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x06014A75 RID: 84597 RVA: 0x001E668F File Offset: 0x001E488F
		// (set) Token: 0x06014A76 RID: 84598 RVA: 0x001E669F File Offset: 0x001E489F
		public unsafe float CachePercentLR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CachePercentLR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CachePercentLR) = value;
			}
		}

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x06014A77 RID: 84599 RVA: 0x001E66B0 File Offset: 0x001E48B0
		// (set) Token: 0x06014A78 RID: 84600 RVA: 0x001E66C0 File Offset: 0x001E48C0
		public unsafe float CachePercentFB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CachePercentFB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CachePercentFB) = value;
			}
		}

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x06014A79 RID: 84601 RVA: 0x001E66D1 File Offset: 0x001E48D1
		// (set) Token: 0x06014A7A RID: 84602 RVA: 0x001E66E1 File Offset: 0x001E48E1
		public unsafe EStandTurnType StandTurnType
		{
			get
			{
				return (EStandTurnType)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StandTurnType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StandTurnType) = (byte)value;
			}
		}

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x06014A7B RID: 84603 RVA: 0x001E66F2 File Offset: 0x001E48F2
		// (set) Token: 0x06014A7C RID: 84604 RVA: 0x001E6702 File Offset: 0x001E4902
		public unsafe float StandTurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StandTurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StandTurnAngle) = value;
			}
		}

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x06014A7D RID: 84605 RVA: 0x001E6713 File Offset: 0x001E4913
		// (set) Token: 0x06014A7E RID: 84606 RVA: 0x001E6723 File Offset: 0x001E4923
		public unsafe int LandSpeedIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LandSpeedIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LandSpeedIndex) = value;
			}
		}

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x06014A7F RID: 84607 RVA: 0x001E6734 File Offset: 0x001E4934
		// (set) Token: 0x06014A80 RID: 84608 RVA: 0x001E6744 File Offset: 0x001E4944
		public unsafe float FallingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FallingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FallingSpeed) = value;
			}
		}

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x06014A81 RID: 84609 RVA: 0x001E6755 File Offset: 0x001E4955
		// (set) Token: 0x06014A82 RID: 84610 RVA: 0x001E6765 File Offset: 0x001E4965
		public unsafe float ForecastLandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ForecastLandWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ForecastLandWeight) = value;
			}
		}

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x06014A83 RID: 84611 RVA: 0x001E6776 File Offset: 0x001E4976
		// (set) Token: 0x06014A84 RID: 84612 RVA: 0x001E678A File Offset: 0x001E498A
		public unsafe FVector AirVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirVelocity) = value;
			}
		}

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x06014A85 RID: 84613 RVA: 0x001E679F File Offset: 0x001E499F
		// (set) Token: 0x06014A86 RID: 84614 RVA: 0x001E67AF File Offset: 0x001E49AF
		public unsafe float AirTargetYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirTargetYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirTargetYaw) = value;
			}
		}

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x06014A87 RID: 84615 RVA: 0x001E67C0 File Offset: 0x001E49C0
		// (set) Token: 0x06014A88 RID: 84616 RVA: 0x001E67D4 File Offset: 0x001E49D4
		public unsafe FVector GlideMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GlideMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GlideMix) = value;
			}
		}

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x06014A89 RID: 84617 RVA: 0x001E67E9 File Offset: 0x001E49E9
		// (set) Token: 0x06014A8A RID: 84618 RVA: 0x001E67F9 File Offset: 0x001E49F9
		public unsafe float SlideMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideMix) = value;
			}
		}

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x06014A8B RID: 84619 RVA: 0x001E680A File Offset: 0x001E4A0A
		// (set) Token: 0x06014A8C RID: 84620 RVA: 0x001E681E File Offset: 0x001E4A1E
		public unsafe FVector AirSlideMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirSlideMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirSlideMix) = value;
			}
		}

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x06014A8D RID: 84621 RVA: 0x001E6833 File Offset: 0x001E4A33
		// (set) Token: 0x06014A8E RID: 84622 RVA: 0x001E6847 File Offset: 0x001E4A47
		public unsafe FVector HookRopeMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_HookRopeMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_HookRopeMix) = value;
			}
		}

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x06014A8F RID: 84623 RVA: 0x001E685C File Offset: 0x001E4A5C
		// (set) Token: 0x06014A90 RID: 84624 RVA: 0x001E686C File Offset: 0x001E4A6C
		public unsafe bool HookRopeSucceedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_HookRopeSucceedSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_HookRopeSucceedSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x06014A91 RID: 84625 RVA: 0x001E687D File Offset: 0x001E4A7D
		// (set) Token: 0x06014A92 RID: 84626 RVA: 0x001E688D File Offset: 0x001E4A8D
		public unsafe float JumpMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_JumpMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_JumpMix) = value;
			}
		}

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x06014A93 RID: 84627 RVA: 0x001E689E File Offset: 0x001E4A9E
		// (set) Token: 0x06014A94 RID: 84628 RVA: 0x001E68B2 File Offset: 0x001E4AB2
		public unsafe FVector AirRelativeVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirRelativeVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirRelativeVelocity) = value;
			}
		}

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x06014A95 RID: 84629 RVA: 0x001E68C7 File Offset: 0x001E4AC7
		// (set) Token: 0x06014A96 RID: 84630 RVA: 0x001E68DB File Offset: 0x001E4ADB
		public unsafe FVector SwimRootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimRootOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimRootOffset) = value;
			}
		}

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x06014A97 RID: 84631 RVA: 0x001E68F0 File Offset: 0x001E4AF0
		// (set) Token: 0x06014A98 RID: 84632 RVA: 0x001E6900 File Offset: 0x001E4B00
		public unsafe float SwimAccelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimAccelOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimAccelOffset) = value;
			}
		}

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x06014A99 RID: 84633 RVA: 0x001E6911 File Offset: 0x001E4B11
		// (set) Token: 0x06014A9A RID: 84634 RVA: 0x001E6921 File Offset: 0x001E4B21
		public unsafe float SwimAccelOffsetReal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimAccelOffsetReal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimAccelOffsetReal) = value;
			}
		}

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x06014A9B RID: 84635 RVA: 0x001E6932 File Offset: 0x001E4B32
		// (set) Token: 0x06014A9C RID: 84636 RVA: 0x001E6942 File Offset: 0x001E4B42
		public unsafe float SwimMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SwimMix) = value;
			}
		}

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x06014A9D RID: 84637 RVA: 0x001E6953 File Offset: 0x001E4B53
		// (set) Token: 0x06014A9E RID: 84638 RVA: 0x001E6963 File Offset: 0x001E4B63
		public unsafe float FastClimbMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FastClimbMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FastClimbMix) = value;
			}
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x06014A9F RID: 84639 RVA: 0x001E6974 File Offset: 0x001E4B74
		// (set) Token: 0x06014AA0 RID: 84640 RVA: 0x001E6984 File Offset: 0x001E4B84
		public unsafe float ClimbBrakeMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbBrakeMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbBrakeMix) = value;
			}
		}

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x06014AA1 RID: 84641 RVA: 0x001E6995 File Offset: 0x001E4B95
		// (set) Token: 0x06014AA2 RID: 84642 RVA: 0x001E69A5 File Offset: 0x001E4BA5
		public unsafe bool bIsClimbMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsClimbMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsClimbMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x06014AA3 RID: 84643 RVA: 0x001E69B6 File Offset: 0x001E4BB6
		// (set) Token: 0x06014AA4 RID: 84644 RVA: 0x001E69C6 File Offset: 0x001E4BC6
		public unsafe float ClimbRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbRadius) = value;
			}
		}

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x06014AA5 RID: 84645 RVA: 0x001E69D7 File Offset: 0x001E4BD7
		// (set) Token: 0x06014AA6 RID: 84646 RVA: 0x001E69E7 File Offset: 0x001E4BE7
		public unsafe int ClimbDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ClimbDirection) = value;
			}
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x06014AA7 RID: 84647 RVA: 0x001E69F8 File Offset: 0x001E4BF8
		// (set) Token: 0x06014AA8 RID: 84648 RVA: 0x001E6A08 File Offset: 0x001E4C08
		public unsafe int ValidClimbDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ValidClimbDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ValidClimbDirection) = value;
			}
		}

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x06014AA9 RID: 84649 RVA: 0x001E6A19 File Offset: 0x001E4C19
		// (set) Token: 0x06014AAA RID: 84650 RVA: 0x001E6A29 File Offset: 0x001E4C29
		public unsafe KuroHumanIKMode IKMode
		{
			get
			{
				return (KuroHumanIKMode)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_IKMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_IKMode) = (byte)value;
			}
		}

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x06014AAB RID: 84651 RVA: 0x001E6A3A File Offset: 0x001E4C3A
		// (set) Token: 0x06014AAC RID: 84652 RVA: 0x001E6A4A File Offset: 0x001E4C4A
		public unsafe bool bIKNoLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIKNoLerp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIKNoLerp) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x06014AAD RID: 84653 RVA: 0x001E6A5B File Offset: 0x001E4C5B
		// (set) Token: 0x06014AAE RID: 84654 RVA: 0x001E6A6F File Offset: 0x001E4C6F
		public unsafe FRotator ComprehensiveRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ComprehensiveRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ComprehensiveRotator) = value;
			}
		}

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x06014AAF RID: 84655 RVA: 0x001E6A84 File Offset: 0x001E4C84
		// (set) Token: 0x06014AB0 RID: 84656 RVA: 0x001E6A98 File Offset: 0x001E4C98
		public unsafe FVector BeHitStandardizedDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BeHitStandardizedDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BeHitStandardizedDirect) = value;
			}
		}

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x06014AB1 RID: 84657 RVA: 0x001E6AAD File Offset: 0x001E4CAD
		// (set) Token: 0x06014AB2 RID: 84658 RVA: 0x001E6AC1 File Offset: 0x001E4CC1
		public unsafe FVector BeHitSocketLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BeHitSocketLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BeHitSocketLocation) = value;
			}
		}

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x06014AB3 RID: 84659 RVA: 0x001E6AD6 File Offset: 0x001E4CD6
		// (set) Token: 0x06014AB4 RID: 84660 RVA: 0x001E6AE6 File Offset: 0x001E4CE6
		public unsafe float SightLockAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SightLockAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SightLockAlpha) = value;
			}
		}

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x06014AB5 RID: 84661 RVA: 0x001E6AF7 File Offset: 0x001E4CF7
		// (set) Token: 0x06014AB6 RID: 84662 RVA: 0x001E6B0B File Offset: 0x001E4D0B
		public unsafe FVector SightLockDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SightLockDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SightLockDirect) = value;
			}
		}

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x06014AB7 RID: 84663 RVA: 0x001E6B20 File Offset: 0x001E4D20
		// (set) Token: 0x06014AB8 RID: 84664 RVA: 0x001E6B30 File Offset: 0x001E4D30
		public unsafe bool bInAimShotEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bInAimShotEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bInAimShotEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x06014AB9 RID: 84665 RVA: 0x001E6B41 File Offset: 0x001E4D41
		// (set) Token: 0x06014ABA RID: 84666 RVA: 0x001E6B51 File Offset: 0x001E4D51
		public unsafe float AimYawMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimYawMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AimYawMix) = value;
			}
		}

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x06014ABB RID: 84667 RVA: 0x001E6B62 File Offset: 0x001E4D62
		// (set) Token: 0x06014ABC RID: 84668 RVA: 0x001E6B72 File Offset: 0x001E4D72
		public unsafe int FreezeCountDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FreezeCountDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_FreezeCountDown) = value;
			}
		}

		// Token: 0x17005187 RID: 20871
		// (get) Token: 0x06014ABD RID: 84669 RVA: 0x001E6B83 File Offset: 0x001E4D83
		// (set) Token: 0x06014ABE RID: 84670 RVA: 0x001E6B93 File Offset: 0x001E4D93
		public unsafe bool bStateStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005188 RID: 20872
		// (get) Token: 0x06014ABF RID: 84671 RVA: 0x001E6BA4 File Offset: 0x001E4DA4
		// (set) Token: 0x06014AC0 RID: 84672 RVA: 0x001E6BB4 File Offset: 0x001E4DB4
		public unsafe bool bStateSprintStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSprintStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSprintStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x06014AC1 RID: 84673 RVA: 0x001E6BC5 File Offset: 0x001E4DC5
		// (set) Token: 0x06014AC2 RID: 84674 RVA: 0x001E6BD5 File Offset: 0x001E4DD5
		public unsafe bool bStateRunStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateRunStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateRunStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x06014AC3 RID: 84675 RVA: 0x001E6BE6 File Offset: 0x001E4DE6
		// (set) Token: 0x06014AC4 RID: 84676 RVA: 0x001E6BF6 File Offset: 0x001E4DF6
		public unsafe bool bStateWalkStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWalkStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWalkStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x06014AC5 RID: 84677 RVA: 0x001E6C07 File Offset: 0x001E4E07
		// (set) Token: 0x06014AC6 RID: 84678 RVA: 0x001E6C17 File Offset: 0x001E4E17
		public unsafe bool bStateGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x06014AC7 RID: 84679 RVA: 0x001E6C28 File Offset: 0x001E4E28
		// (set) Token: 0x06014AC8 RID: 84680 RVA: 0x001E6C38 File Offset: 0x001E4E38
		public unsafe bool bStateStand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateStand) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateStand) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x06014AC9 RID: 84681 RVA: 0x001E6C49 File Offset: 0x001E4E49
		// (set) Token: 0x06014ACA RID: 84682 RVA: 0x001E6C59 File Offset: 0x001E4E59
		public unsafe bool bStateGroundSprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundSprint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundSprint) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x06014ACB RID: 84683 RVA: 0x001E6C6A File Offset: 0x001E4E6A
		// (set) Token: 0x06014ACC RID: 84684 RVA: 0x001E6C7A File Offset: 0x001E4E7A
		public unsafe bool bStateGroundRun
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundRun) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundRun) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x06014ACD RID: 84685 RVA: 0x001E6C8B File Offset: 0x001E4E8B
		// (set) Token: 0x06014ACE RID: 84686 RVA: 0x001E6C9B File Offset: 0x001E4E9B
		public unsafe bool bStateGroundWalk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundWalk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGroundWalk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x06014ACF RID: 84687 RVA: 0x001E6CAC File Offset: 0x001E4EAC
		// (set) Token: 0x06014AD0 RID: 84688 RVA: 0x001E6CBC File Offset: 0x001E4EBC
		public unsafe bool bStateClimb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateClimb) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateClimb) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x06014AD1 RID: 84689 RVA: 0x001E6CCD File Offset: 0x001E4ECD
		// (set) Token: 0x06014AD2 RID: 84690 RVA: 0x001E6CDD File Offset: 0x001E4EDD
		public unsafe bool bStateAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAir) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x06014AD3 RID: 84691 RVA: 0x001E6CEE File Offset: 0x001E4EEE
		// (set) Token: 0x06014AD4 RID: 84692 RVA: 0x001E6CFE File Offset: 0x001E4EFE
		public unsafe bool bStateSki
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSki) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSki) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x06014AD5 RID: 84693 RVA: 0x001E6D0F File Offset: 0x001E4F0F
		// (set) Token: 0x06014AD6 RID: 84694 RVA: 0x001E6D1F File Offset: 0x001E4F1F
		public unsafe bool bStateNormalSki
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateNormalSki) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateNormalSki) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x06014AD7 RID: 84695 RVA: 0x001E6D30 File Offset: 0x001E4F30
		// (set) Token: 0x06014AD8 RID: 84696 RVA: 0x001E6D40 File Offset: 0x001E4F40
		public unsafe bool bStateAirSlide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirSlide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirSlide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x06014AD9 RID: 84697 RVA: 0x001E6D51 File Offset: 0x001E4F51
		// (set) Token: 0x06014ADA RID: 84698 RVA: 0x001E6D61 File Offset: 0x001E4F61
		public unsafe bool bStateAirGlide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirGlide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirGlide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x06014ADB RID: 84699 RVA: 0x001E6D72 File Offset: 0x001E4F72
		// (set) Token: 0x06014ADC RID: 84700 RVA: 0x001E6D82 File Offset: 0x001E4F82
		public unsafe bool bStateAirKite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirKite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirKite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x06014ADD RID: 84701 RVA: 0x001E6D93 File Offset: 0x001E4F93
		// (set) Token: 0x06014ADE RID: 84702 RVA: 0x001E6DA3 File Offset: 0x001E4FA3
		public unsafe bool bStateWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWater) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWater) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x06014ADF RID: 84703 RVA: 0x001E6DB4 File Offset: 0x001E4FB4
		// (set) Token: 0x06014AE0 RID: 84704 RVA: 0x001E6DC4 File Offset: 0x001E4FC4
		public unsafe bool bStateSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x06014AE1 RID: 84705 RVA: 0x001E6DD5 File Offset: 0x001E4FD5
		// (set) Token: 0x06014AE2 RID: 84706 RVA: 0x001E6DE5 File Offset: 0x001E4FE5
		public unsafe bool bStateLockDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLockDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLockDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x06014AE3 RID: 84707 RVA: 0x001E6DF6 File Offset: 0x001E4FF6
		// (set) Token: 0x06014AE4 RID: 84708 RVA: 0x001E6E06 File Offset: 0x001E5006
		public unsafe bool bStateAimDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAimDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAimDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x06014AE5 RID: 84709 RVA: 0x001E6E17 File Offset: 0x001E5017
		// (set) Token: 0x06014AE6 RID: 84710 RVA: 0x001E6E27 File Offset: 0x001E5027
		public unsafe bool bStateFaceDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFaceDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFaceDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x06014AE7 RID: 84711 RVA: 0x001E6E38 File Offset: 0x001E5038
		// (set) Token: 0x06014AE8 RID: 84712 RVA: 0x001E6E48 File Offset: 0x001E5048
		public unsafe bool bStateBeHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBeHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBeHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x06014AE9 RID: 84713 RVA: 0x001E6E59 File Offset: 0x001E5059
		// (set) Token: 0x06014AEA RID: 84714 RVA: 0x001E6E69 File Offset: 0x001E5069
		public unsafe bool bStateHitPush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateHitPush) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateHitPush) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x06014AEB RID: 84715 RVA: 0x001E6E7A File Offset: 0x001E507A
		// (set) Token: 0x06014AEC RID: 84716 RVA: 0x001E6E8A File Offset: 0x001E508A
		public unsafe bool bStateBeHitFly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBeHitFly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBeHitFly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x06014AED RID: 84717 RVA: 0x001E6E9B File Offset: 0x001E509B
		// (set) Token: 0x06014AEE RID: 84718 RVA: 0x001E6EAB File Offset: 0x001E50AB
		public unsafe bool bStateDying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateDying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateDying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x06014AEF RID: 84719 RVA: 0x001E6EBC File Offset: 0x001E50BC
		// (set) Token: 0x06014AF0 RID: 84720 RVA: 0x001E6ECC File Offset: 0x001E50CC
		public unsafe bool bStateDrown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateDrown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateDrown) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x06014AF1 RID: 84721 RVA: 0x001E6EDD File Offset: 0x001E50DD
		// (set) Token: 0x06014AF2 RID: 84722 RVA: 0x001E6EED File Offset: 0x001E50ED
		public unsafe bool bStateInBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateInBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateInBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x06014AF3 RID: 84723 RVA: 0x001E6EFE File Offset: 0x001E50FE
		// (set) Token: 0x06014AF4 RID: 84724 RVA: 0x001E6F0E File Offset: 0x001E510E
		public unsafe bool bStateEnterBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateEnterBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateEnterBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x06014AF5 RID: 84725 RVA: 0x001E6F1F File Offset: 0x001E511F
		// (set) Token: 0x06014AF6 RID: 84726 RVA: 0x001E6F2F File Offset: 0x001E512F
		public unsafe bool bStateKeepSprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateKeepSprint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateKeepSprint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x06014AF7 RID: 84727 RVA: 0x001E6F40 File Offset: 0x001E5140
		// (set) Token: 0x06014AF8 RID: 84728 RVA: 0x001E6F50 File Offset: 0x001E5150
		public unsafe bool bStateFastSwim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFastSwim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFastSwim) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x06014AF9 RID: 84729 RVA: 0x001E6F61 File Offset: 0x001E5161
		// (set) Token: 0x06014AFA RID: 84730 RVA: 0x001E6F71 File Offset: 0x001E5171
		public unsafe bool bStateSit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateSit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x06014AFB RID: 84731 RVA: 0x001E6F82 File Offset: 0x001E5182
		// (set) Token: 0x06014AFC RID: 84732 RVA: 0x001E6F92 File Offset: 0x001E5192
		public unsafe bool bStateXA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateXA) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateXA) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x06014AFD RID: 84733 RVA: 0x001E6FA3 File Offset: 0x001E51A3
		// (set) Token: 0x06014AFE RID: 84734 RVA: 0x001E6FB3 File Offset: 0x001E51B3
		public unsafe bool bStateAreaSportMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAreaSportMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAreaSportMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x06014AFF RID: 84735 RVA: 0x001E6FC4 File Offset: 0x001E51C4
		// (set) Token: 0x06014B00 RID: 84736 RVA: 0x001E6FD4 File Offset: 0x001E51D4
		public unsafe bool bStateAreaSportModeKeep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAreaSportModeKeep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAreaSportModeKeep) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051A9 RID: 20905
		// (get) Token: 0x06014B01 RID: 84737 RVA: 0x001E6FE5 File Offset: 0x001E51E5
		// (set) Token: 0x06014B02 RID: 84738 RVA: 0x001E6FF5 File Offset: 0x001E51F5
		public unsafe bool bStateVehicleDriveMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateVehicleDriveMoto) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateVehicleDriveMoto) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AA RID: 20906
		// (get) Token: 0x06014B03 RID: 84739 RVA: 0x001E7006 File Offset: 0x001E5206
		// (set) Token: 0x06014B04 RID: 84740 RVA: 0x001E7016 File Offset: 0x001E5216
		public unsafe bool bCharacterStateAreaSportMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCharacterStateAreaSportMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCharacterStateAreaSportMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AB RID: 20907
		// (get) Token: 0x06014B05 RID: 84741 RVA: 0x001E7027 File Offset: 0x001E5227
		// (set) Token: 0x06014B06 RID: 84742 RVA: 0x001E7037 File Offset: 0x001E5237
		public unsafe bool bStateOverlapBaseAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateOverlapBaseAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateOverlapBaseAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AC RID: 20908
		// (get) Token: 0x06014B07 RID: 84743 RVA: 0x001E7048 File Offset: 0x001E5248
		// (set) Token: 0x06014B08 RID: 84744 RVA: 0x001E7058 File Offset: 0x001E5258
		public unsafe bool bUseAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x06014B09 RID: 84745 RVA: 0x001E7069 File Offset: 0x001E5269
		// (set) Token: 0x06014B0A RID: 84746 RVA: 0x001E7079 File Offset: 0x001E5279
		public unsafe bool bUseOverlapLayerAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseOverlapLayerAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseOverlapLayerAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x06014B0B RID: 84747 RVA: 0x001E708A File Offset: 0x001E528A
		// (set) Token: 0x06014B0C RID: 84748 RVA: 0x001E709A File Offset: 0x001E529A
		public unsafe bool bStateLowerRightTurnBlending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLowerRightTurnBlending) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLowerRightTurnBlending) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x06014B0D RID: 84749 RVA: 0x001E70AB File Offset: 0x001E52AB
		// (set) Token: 0x06014B0E RID: 84750 RVA: 0x001E70BB File Offset: 0x001E52BB
		public unsafe bool bStateLowerBlending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLowerBlending) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLowerBlending) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x06014B0F RID: 84751 RVA: 0x001E70CC File Offset: 0x001E52CC
		// (set) Token: 0x06014B10 RID: 84752 RVA: 0x001E70DC File Offset: 0x001E52DC
		public unsafe bool bStateWholeBodyBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWholeBodyBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateWholeBodyBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x06014B11 RID: 84753 RVA: 0x001E70ED File Offset: 0x001E52ED
		// (set) Token: 0x06014B12 RID: 84754 RVA: 0x001E70FD File Offset: 0x001E52FD
		public unsafe bool bStateUseSpecialStateMachine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateUseSpecialStateMachine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateUseSpecialStateMachine) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x06014B13 RID: 84755 RVA: 0x001E710E File Offset: 0x001E530E
		// (set) Token: 0x06014B14 RID: 84756 RVA: 0x001E711E File Offset: 0x001E531E
		public unsafe bool bStateFastBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFastBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFastBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x06014B15 RID: 84757 RVA: 0x001E712F File Offset: 0x001E532F
		// (set) Token: 0x06014B16 RID: 84758 RVA: 0x001E713F File Offset: 0x001E533F
		public unsafe bool bUseArmAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseArmAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bUseArmAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06014B17 RID: 84759 RVA: 0x001E7150 File Offset: 0x001E5350
		// (set) Token: 0x06014B18 RID: 84760 RVA: 0x001E7160 File Offset: 0x001E5360
		public unsafe bool bStateLeftArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLeftArmBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLeftArmBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06014B19 RID: 84761 RVA: 0x001E7171 File Offset: 0x001E5371
		// (set) Token: 0x06014B1A RID: 84762 RVA: 0x001E7181 File Offset: 0x001E5381
		public unsafe bool bStateRightArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateRightArmBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateRightArmBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x06014B1B RID: 84763 RVA: 0x001E7192 File Offset: 0x001E5392
		// (set) Token: 0x06014B1C RID: 84764 RVA: 0x001E71A2 File Offset: 0x001E53A2
		public unsafe float LowerBlendAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LowerBlendAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LowerBlendAlpha) = value;
			}
		}

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x06014B1D RID: 84765 RVA: 0x001E71B4 File Offset: 0x001E53B4
		// (set) Token: 0x06014B1E RID: 84766 RVA: 0x001E71ED File Offset: 0x001E53ED
		public FAdditiveBlendAlpha BlendAlphaPelvis
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaPelvis) == null)
				{
					result = (this._BlendAlphaPelvis = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaPelvis, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaPelvis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x06014B1F RID: 84767 RVA: 0x001E7210 File Offset: 0x001E5410
		// (set) Token: 0x06014B20 RID: 84768 RVA: 0x001E7249 File Offset: 0x001E5449
		public FAdditiveBlendAlpha BlendAlphaSpine
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaSpine) == null)
				{
					result = (this._BlendAlphaSpine = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x06014B21 RID: 84769 RVA: 0x001E726C File Offset: 0x001E546C
		// (set) Token: 0x06014B22 RID: 84770 RVA: 0x001E72A5 File Offset: 0x001E54A5
		public FAdditiveBlendAlpha BlendAlphaSpine1
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaSpine1) == null)
				{
					result = (this._BlendAlphaSpine1 = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x06014B23 RID: 84771 RVA: 0x001E72C8 File Offset: 0x001E54C8
		// (set) Token: 0x06014B24 RID: 84772 RVA: 0x001E7301 File Offset: 0x001E5501
		public FAdditiveBlendAlpha BlendAlphaSpine2
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaSpine2) == null)
				{
					result = (this._BlendAlphaSpine2 = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaSpine2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x06014B25 RID: 84773 RVA: 0x001E7324 File Offset: 0x001E5524
		// (set) Token: 0x06014B26 RID: 84774 RVA: 0x001E735D File Offset: 0x001E555D
		public FAdditiveBlendAlpha BlendAlphaHead
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaHead) == null)
				{
					result = (this._BlendAlphaHead = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaHead, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaHead, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x06014B27 RID: 84775 RVA: 0x001E7380 File Offset: 0x001E5580
		// (set) Token: 0x06014B28 RID: 84776 RVA: 0x001E73B9 File Offset: 0x001E55B9
		public FAdditiveBlendAlpha BlendAlphaArmL
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaArmL) == null)
				{
					result = (this._BlendAlphaArmL = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaArmL, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaArmL, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x06014B29 RID: 84777 RVA: 0x001E73DC File Offset: 0x001E55DC
		// (set) Token: 0x06014B2A RID: 84778 RVA: 0x001E7415 File Offset: 0x001E5615
		public FAdditiveBlendAlpha BlendAlphaArmR
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaArmR) == null)
				{
					result = (this._BlendAlphaArmR = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaArmR, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaArmR, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x06014B2B RID: 84779 RVA: 0x001E7438 File Offset: 0x001E5638
		// (set) Token: 0x06014B2C RID: 84780 RVA: 0x001E7471 File Offset: 0x001E5671
		public FAdditiveBlendAlpha BlendAlphaLeg
		{
			get
			{
				base.FastCheckIsValid();
				FAdditiveBlendAlpha result;
				if ((result = this._BlendAlphaLeg) == null)
				{
					result = (this._BlendAlphaLeg = new FAdditiveBlendAlpha(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaLeg, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAdditiveBlendAlpha.StaticStruct(), base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_BlendAlphaLeg, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x06014B2D RID: 84781 RVA: 0x001E7492 File Offset: 0x001E5692
		// (set) Token: 0x06014B2E RID: 84782 RVA: 0x001E74A2 File Offset: 0x001E56A2
		public unsafe bool bStateCast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCast) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x06014B2F RID: 84783 RVA: 0x001E74B3 File Offset: 0x001E56B3
		// (set) Token: 0x06014B30 RID: 84784 RVA: 0x001E74C3 File Offset: 0x001E56C3
		public unsafe bool bStateCastThrowing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastThrowing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastThrowing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06014B31 RID: 84785 RVA: 0x001E74D4 File Offset: 0x001E56D4
		// (set) Token: 0x06014B32 RID: 84786 RVA: 0x001E74E4 File Offset: 0x001E56E4
		public unsafe bool bStateCastSelecting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastSelecting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastSelecting) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x06014B33 RID: 84787 RVA: 0x001E74F5 File Offset: 0x001E56F5
		// (set) Token: 0x06014B34 RID: 84788 RVA: 0x001E7505 File Offset: 0x001E5705
		public unsafe bool bStateCastCasting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastCasting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateCastCasting) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x06014B35 RID: 84789 RVA: 0x001E7516 File Offset: 0x001E5716
		// (set) Token: 0x06014B36 RID: 84790 RVA: 0x001E7526 File Offset: 0x001E5726
		public unsafe bool bStateMoveShot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateMoveShot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateMoveShot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x06014B37 RID: 84791 RVA: 0x001E7537 File Offset: 0x001E5737
		// (set) Token: 0x06014B38 RID: 84792 RVA: 0x001E7547 File Offset: 0x001E5747
		public unsafe bool bStateHoldShot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateHoldShot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateHoldShot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x06014B39 RID: 84793 RVA: 0x001E7558 File Offset: 0x001E5758
		// (set) Token: 0x06014B3A RID: 84794 RVA: 0x001E7568 File Offset: 0x001E5768
		public unsafe bool bStateAiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAiming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAiming) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C6 RID: 20934
		// (get) Token: 0x06014B3B RID: 84795 RVA: 0x001E7579 File Offset: 0x001E5779
		// (set) Token: 0x06014B3C RID: 84796 RVA: 0x001E7589 File Offset: 0x001E5789
		public unsafe bool bStateGeneralAiming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGeneralAiming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateGeneralAiming) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C7 RID: 20935
		// (get) Token: 0x06014B3D RID: 84797 RVA: 0x001E759A File Offset: 0x001E579A
		// (set) Token: 0x06014B3E RID: 84798 RVA: 0x001E75AA File Offset: 0x001E57AA
		public unsafe bool bStateShotNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateShotNotify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateShotNotify) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x06014B3F RID: 84799 RVA: 0x001E75BB File Offset: 0x001E57BB
		// (set) Token: 0x06014B40 RID: 84800 RVA: 0x001E75CB File Offset: 0x001E57CB
		public unsafe bool bStateFixHook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFixHook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateFixHook) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x06014B41 RID: 84801 RVA: 0x001E75DC File Offset: 0x001E57DC
		// (set) Token: 0x06014B42 RID: 84802 RVA: 0x001E75EC File Offset: 0x001E57EC
		public unsafe bool bStateAirNormalShot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x06014B43 RID: 84803 RVA: 0x001E75FD File Offset: 0x001E57FD
		// (set) Token: 0x06014B44 RID: 84804 RVA: 0x001E760D File Offset: 0x001E580D
		public unsafe bool bStateAirNormalShotLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x06014B45 RID: 84805 RVA: 0x001E761E File Offset: 0x001E581E
		// (set) Token: 0x06014B46 RID: 84806 RVA: 0x001E762E File Offset: 0x001E582E
		public unsafe bool bStateAirNormalShotRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotRight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotRight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x06014B47 RID: 84807 RVA: 0x001E763F File Offset: 0x001E583F
		// (set) Token: 0x06014B48 RID: 84808 RVA: 0x001E764F File Offset: 0x001E584F
		public unsafe bool bStateAirNormalShotFall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotFall) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateAirNormalShotFall) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x06014B49 RID: 84809 RVA: 0x001E7660 File Offset: 0x001E5860
		// (set) Token: 0x06014B4A RID: 84810 RVA: 0x001E7670 File Offset: 0x001E5870
		public unsafe bool bStateBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x06014B4B RID: 84811 RVA: 0x001E7681 File Offset: 0x001E5881
		// (set) Token: 0x06014B4C RID: 84812 RVA: 0x001E7691 File Offset: 0x001E5891
		public unsafe bool bStateInBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateInBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateInBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x06014B4D RID: 84813 RVA: 0x001E76A2 File Offset: 0x001E58A2
		// (set) Token: 0x06014B4E RID: 84814 RVA: 0x001E76B2 File Offset: 0x001E58B2
		public unsafe bool bStateLimitForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLimitForward) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLimitForward) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x06014B4F RID: 84815 RVA: 0x001E76C3 File Offset: 0x001E58C3
		// (set) Token: 0x06014B50 RID: 84816 RVA: 0x001E76D3 File Offset: 0x001E58D3
		public unsafe bool bStateLimitBackward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLimitBackward) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStateLimitBackward) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x06014B51 RID: 84817 RVA: 0x001E76E4 File Offset: 0x001E58E4
		// (set) Token: 0x06014B52 RID: 84818 RVA: 0x001E76F4 File Offset: 0x001E58F4
		public unsafe bool bLandRollWhenDying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bLandRollWhenDying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bLandRollWhenDying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x06014B53 RID: 84819 RVA: 0x001E7705 File Offset: 0x001E5905
		// (set) Token: 0x06014B54 RID: 84820 RVA: 0x001E7715 File Offset: 0x001E5915
		public unsafe bool bCaught
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCaught) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bCaught) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x06014B55 RID: 84821 RVA: 0x001E7726 File Offset: 0x001E5926
		// (set) Token: 0x06014B56 RID: 84822 RVA: 0x001E7736 File Offset: 0x001E5936
		public unsafe bool bRagDollQuit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bRagDollQuit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bRagDollQuit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x06014B57 RID: 84823 RVA: 0x001E7747 File Offset: 0x001E5947
		// (set) Token: 0x06014B58 RID: 84824 RVA: 0x001E7757 File Offset: 0x001E5957
		public unsafe bool bDisablePerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bDisablePerformance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bDisablePerformance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x06014B59 RID: 84825 RVA: 0x001E7768 File Offset: 0x001E5968
		// (set) Token: 0x06014B5A RID: 84826 RVA: 0x001E7778 File Offset: 0x001E5978
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x06014B5B RID: 84827 RVA: 0x001E7789 File Offset: 0x001E5989
		// (set) Token: 0x06014B5C RID: 84828 RVA: 0x001E7799 File Offset: 0x001E5999
		public unsafe bool bEpresion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bEpresion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bEpresion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x06014B5D RID: 84829 RVA: 0x001E77AA File Offset: 0x001E59AA
		// (set) Token: 0x06014B5E RID: 84830 RVA: 0x001E77BA File Offset: 0x001E59BA
		public unsafe float PerformanceCountDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_PerformanceCountDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_PerformanceCountDown) = value;
			}
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x06014B5F RID: 84831 RVA: 0x001E77CB File Offset: 0x001E59CB
		// (set) Token: 0x06014B60 RID: 84832 RVA: 0x001E77DB File Offset: 0x001E59DB
		public unsafe bool bPerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bPerformance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bPerformance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x06014B61 RID: 84833 RVA: 0x001E77EC File Offset: 0x001E59EC
		// (set) Token: 0x06014B62 RID: 84834 RVA: 0x001E77FC File Offset: 0x001E59FC
		public unsafe int PerformanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_PerformanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_PerformanceIndex) = value;
			}
		}

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x06014B63 RID: 84835 RVA: 0x001E780D File Offset: 0x001E5A0D
		// (set) Token: 0x06014B64 RID: 84836 RVA: 0x001E781D File Offset: 0x001E5A1D
		public unsafe bool bAllowPerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowPerformance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowPerformance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x06014B65 RID: 84837 RVA: 0x001E782E File Offset: 0x001E5A2E
		// (set) Token: 0x06014B66 RID: 84838 RVA: 0x001E783E File Offset: 0x001E5A3E
		public unsafe bool bAllowManualPerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowManualPerformance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowManualPerformance) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x06014B67 RID: 84839 RVA: 0x001E784F File Offset: 0x001E5A4F
		// (set) Token: 0x06014B68 RID: 84840 RVA: 0x001E785F File Offset: 0x001E5A5F
		public unsafe int AllowManualPerformanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AllowManualPerformanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AllowManualPerformanceIndex) = value;
			}
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x06014B69 RID: 84841 RVA: 0x001E7870 File Offset: 0x001E5A70
		// (set) Token: 0x06014B6A RID: 84842 RVA: 0x001E7880 File Offset: 0x001E5A80
		public unsafe bool bAllowManualPerformanceLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowManualPerformanceLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAllowManualPerformanceLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x06014B6B RID: 84843 RVA: 0x001E7891 File Offset: 0x001E5A91
		// (set) Token: 0x06014B6C RID: 84844 RVA: 0x001E78A1 File Offset: 0x001E5AA1
		public unsafe bool bAcceptNewSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAcceptNewSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bAcceptNewSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x06014B6D RID: 84845 RVA: 0x001E78B2 File Offset: 0x001E5AB2
		// (set) Token: 0x06014B6E RID: 84846 RVA: 0x001E78C2 File Offset: 0x001E5AC2
		public unsafe bool bStageMotionSki
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStageMotionSki) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bStageMotionSki) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x06014B6F RID: 84847 RVA: 0x001E78D3 File Offset: 0x001E5AD3
		// (set) Token: 0x06014B70 RID: 84848 RVA: 0x001E78E3 File Offset: 0x001E5AE3
		public unsafe bool bHugeItemPull
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHugeItemPull) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHugeItemPull) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x06014B71 RID: 84849 RVA: 0x001E78F4 File Offset: 0x001E5AF4
		// (set) Token: 0x06014B72 RID: 84850 RVA: 0x001E7904 File Offset: 0x001E5B04
		public unsafe bool bHugeItemPullAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHugeItemPullAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bHugeItemPullAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x06014B73 RID: 84851 RVA: 0x001E7918 File Offset: 0x001E5B18
		// (set) Token: 0x06014B74 RID: 84852 RVA: 0x001E7951 File Offset: 0x001E5B51
		public TMap<string, float> SizeToCharHeightMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._SizeToCharHeightMap) == null)
				{
					result = (this._SizeToCharHeightMap = new TMap<string, float>(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SizeToCharHeightMap, this));
				}
				return result;
			}
			set
			{
				this.SizeToCharHeightMap.CopyAssign(value);
			}
		}

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x06014B75 RID: 84853 RVA: 0x001E795F File Offset: 0x001E5B5F
		// (set) Token: 0x06014B76 RID: 84854 RVA: 0x001E7973 File Offset: 0x001E5B73
		public unsafe FVector2D LandSpeedThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LandSpeedThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LandSpeedThresholds) = value;
			}
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x06014B77 RID: 84855 RVA: 0x001E7988 File Offset: 0x001E5B88
		// (set) Token: 0x06014B78 RID: 84856 RVA: 0x001E7998 File Offset: 0x001E5B98
		public unsafe float SpeedMixLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SpeedMixLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SpeedMixLerp) = value;
			}
		}

		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x06014B79 RID: 84857 RVA: 0x001E79A9 File Offset: 0x001E5BA9
		// (set) Token: 0x06014B7A RID: 84858 RVA: 0x001E79B9 File Offset: 0x001E5BB9
		public unsafe float GroundLeanLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GroundLeanLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_GroundLeanLerp) = value;
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x06014B7B RID: 84859 RVA: 0x001E79CA File Offset: 0x001E5BCA
		// (set) Token: 0x06014B7C RID: 84860 RVA: 0x001E79DA File Offset: 0x001E5BDA
		public unsafe float AnimWalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimWalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimWalkSpeed) = value;
			}
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x06014B7D RID: 84861 RVA: 0x001E79EB File Offset: 0x001E5BEB
		// (set) Token: 0x06014B7E RID: 84862 RVA: 0x001E79FB File Offset: 0x001E5BFB
		public unsafe float AnimRunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimRunSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimRunSpeed) = value;
			}
		}

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x06014B7F RID: 84863 RVA: 0x001E7A0C File Offset: 0x001E5C0C
		// (set) Token: 0x06014B80 RID: 84864 RVA: 0x001E7A1C File Offset: 0x001E5C1C
		public unsafe float AnimSprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimSprintSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AnimSprintSpeed) = value;
			}
		}

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x06014B81 RID: 84865 RVA: 0x001E7A2D File Offset: 0x001E5C2D
		// (set) Token: 0x06014B82 RID: 84866 RVA: 0x001E7A3D File Offset: 0x001E5C3D
		public unsafe float AirLeanLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirLeanLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_AirLeanLerp) = value;
			}
		}

		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x06014B83 RID: 84867 RVA: 0x001E7A4E File Offset: 0x001E5C4E
		// (set) Token: 0x06014B84 RID: 84868 RVA: 0x001E7A5E File Offset: 0x001E5C5E
		public unsafe float JumpMixLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_JumpMixLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_JumpMixLerp) = value;
			}
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x06014B85 RID: 84869 RVA: 0x001E7A6F File Offset: 0x001E5C6F
		// (set) Token: 0x06014B86 RID: 84870 RVA: 0x001E7A7F File Offset: 0x001E5C7F
		public unsafe float SlideRotateLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideRotateLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideRotateLerp) = value;
			}
		}

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x06014B87 RID: 84871 RVA: 0x001E7A90 File Offset: 0x001E5C90
		// (set) Token: 0x06014B88 RID: 84872 RVA: 0x001E7AA0 File Offset: 0x001E5CA0
		public unsafe float SlideRotateLerp2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideRotateLerp2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SlideRotateLerp2) = value;
			}
		}

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x06014B89 RID: 84873 RVA: 0x001E7AB1 File Offset: 0x001E5CB1
		// (set) Token: 0x06014B8A RID: 84874 RVA: 0x001E7AC5 File Offset: 0x001E5CC5
		[Nullable(2)]
		public unsafe UCurveFloat StandWalkStepCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandWalkStepCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandWalkStepCurve, value);
			}
		}

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x06014B8B RID: 84875 RVA: 0x001E7ADA File Offset: 0x001E5CDA
		// (set) Token: 0x06014B8C RID: 84876 RVA: 0x001E7AEE File Offset: 0x001E5CEE
		[Nullable(2)]
		public unsafe UCurveFloat StandRunStepCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandRunStepCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandRunStepCurve, value);
			}
		}

		// Token: 0x170051EF RID: 20975
		// (get) Token: 0x06014B8D RID: 84877 RVA: 0x001E7B03 File Offset: 0x001E5D03
		// (set) Token: 0x06014B8E RID: 84878 RVA: 0x001E7B17 File Offset: 0x001E5D17
		[Nullable(2)]
		public unsafe UCurveFloat ForecastLandCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_ForecastLandCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_ForecastLandCurve, value);
			}
		}

		// Token: 0x170051F0 RID: 20976
		// (get) Token: 0x06014B8F RID: 84879 RVA: 0x001E7B2C File Offset: 0x001E5D2C
		// (set) Token: 0x06014B90 RID: 84880 RVA: 0x001E7B40 File Offset: 0x001E5D40
		[Nullable(2)]
		public unsafe UCurveFloat RelativeSpeedBlendCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_RelativeSpeedBlendCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_RelativeSpeedBlendCurve, value);
			}
		}

		// Token: 0x170051F1 RID: 20977
		// (get) Token: 0x06014B91 RID: 84881 RVA: 0x001E7B55 File Offset: 0x001E5D55
		// (set) Token: 0x06014B92 RID: 84882 RVA: 0x001E7B69 File Offset: 0x001E5D69
		[Nullable(2)]
		public unsafe UCurveFloat AirLeanCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AirLeanCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AirLeanCurve, value);
			}
		}

		// Token: 0x170051F2 RID: 20978
		// (get) Token: 0x06014B93 RID: 84883 RVA: 0x001E7B7E File Offset: 0x001E5D7E
		// (set) Token: 0x06014B94 RID: 84884 RVA: 0x001E7B92 File Offset: 0x001E5D92
		[Nullable(2)]
		public unsafe UCurveFloat AngelToStepLengthCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngelToStepLengthCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngelToStepLengthCurve, value);
			}
		}

		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x06014B95 RID: 84885 RVA: 0x001E7BA7 File Offset: 0x001E5DA7
		// (set) Token: 0x06014B96 RID: 84886 RVA: 0x001E7BBB File Offset: 0x001E5DBB
		[Nullable(2)]
		public unsafe UCurveFloat AngleToStepFrequencyCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngleToStepFrequencyCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngleToStepFrequencyCurve, value);
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x06014B97 RID: 84887 RVA: 0x001E7BD0 File Offset: 0x001E5DD0
		// (set) Token: 0x06014B98 RID: 84888 RVA: 0x001E7BE4 File Offset: 0x001E5DE4
		[Nullable(2)]
		public unsafe UDataAsset FkMaterialControllerData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_FkMaterialControllerData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_FkMaterialControllerData, value);
			}
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x06014B99 RID: 84889 RVA: 0x001E7BF9 File Offset: 0x001E5DF9
		// (set) Token: 0x06014B9A RID: 84890 RVA: 0x001E7C09 File Offset: 0x001E5E09
		public unsafe float XAUDBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_XAUDBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_XAUDBlend) = value;
			}
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x06014B9B RID: 84891 RVA: 0x001E7C1A File Offset: 0x001E5E1A
		// (set) Token: 0x06014B9C RID: 84892 RVA: 0x001E7C2A File Offset: 0x001E5E2A
		public unsafe float XARLBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_XARLBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_XARLBlend) = value;
			}
		}

		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x06014B9D RID: 84893 RVA: 0x001E7C3B File Offset: 0x001E5E3B
		// (set) Token: 0x06014B9E RID: 84894 RVA: 0x001E7C4B File Offset: 0x001E5E4B
		public unsafe bool bMovingPlatformMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bMovingPlatformMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bMovingPlatformMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x06014B9F RID: 84895 RVA: 0x001E7C5C File Offset: 0x001E5E5C
		// (set) Token: 0x06014BA0 RID: 84896 RVA: 0x001E7C6C File Offset: 0x001E5E6C
		public unsafe float MovingPlatIKAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MovingPlatIKAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_MovingPlatIKAlpha) = value;
			}
		}

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x06014BA1 RID: 84897 RVA: 0x001E7C7D File Offset: 0x001E5E7D
		// (set) Token: 0x06014BA2 RID: 84898 RVA: 0x001E7C8D File Offset: 0x001E5E8D
		public unsafe float UphillLeanForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_UphillLeanForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_UphillLeanForward) = value;
			}
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x06014BA3 RID: 84899 RVA: 0x001E7C9E File Offset: 0x001E5E9E
		// (set) Token: 0x06014BA4 RID: 84900 RVA: 0x001E7CAE File Offset: 0x001E5EAE
		public unsafe float UphillIKDiminish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_UphillIKDiminish);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_UphillIKDiminish) = value;
			}
		}

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x06014BA5 RID: 84901 RVA: 0x001E7CBF File Offset: 0x001E5EBF
		// (set) Token: 0x06014BA6 RID: 84902 RVA: 0x001E7CCF File Offset: 0x001E5ECF
		public unsafe bool bIsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsVehicleImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsVehicleImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x06014BA7 RID: 84903 RVA: 0x001E7CE0 File Offset: 0x001E5EE0
		// (set) Token: 0x06014BA8 RID: 84904 RVA: 0x001E7CF0 File Offset: 0x001E5EF0
		public unsafe float VehicleCollisionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionAlpha) = value;
			}
		}

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x06014BA9 RID: 84905 RVA: 0x001E7D01 File Offset: 0x001E5F01
		// (set) Token: 0x06014BAA RID: 84906 RVA: 0x001E7D11 File Offset: 0x001E5F11
		public unsafe float VehicleCollisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionAngle) = value;
			}
		}

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06014BAB RID: 84907 RVA: 0x001E7D22 File Offset: 0x001E5F22
		// (set) Token: 0x06014BAC RID: 84908 RVA: 0x001E7D32 File Offset: 0x001E5F32
		public unsafe float VehicleCollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionStrength) = value;
			}
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x06014BAD RID: 84909 RVA: 0x001E7D43 File Offset: 0x001E5F43
		// (set) Token: 0x06014BAE RID: 84910 RVA: 0x001E7D57 File Offset: 0x001E5F57
		public unsafe FVector4 VehicleCollisionMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleCollisionMix) = value;
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x06014BAF RID: 84911 RVA: 0x001E7D6C File Offset: 0x001E5F6C
		// (set) Token: 0x06014BB0 RID: 84912 RVA: 0x001E7D80 File Offset: 0x001E5F80
		public unsafe FRotator VehicleSeatRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleSeatRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleSeatRot) = value;
			}
		}

		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x06014BB1 RID: 84913 RVA: 0x001E7D95 File Offset: 0x001E5F95
		// (set) Token: 0x06014BB2 RID: 84914 RVA: 0x001E7DA5 File Offset: 0x001E5FA5
		public unsafe bool bIsGondolaClimbWaterfall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsGondolaClimbWaterfall) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsGondolaClimbWaterfall) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x06014BB3 RID: 84915 RVA: 0x001E7DB6 File Offset: 0x001E5FB6
		// (set) Token: 0x06014BB4 RID: 84916 RVA: 0x001E7DC6 File Offset: 0x001E5FC6
		public unsafe bool bIsSuddenStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsSuddenStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsSuddenStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x06014BB5 RID: 84917 RVA: 0x001E7DD7 File Offset: 0x001E5FD7
		// (set) Token: 0x06014BB6 RID: 84918 RVA: 0x001E7DE7 File Offset: 0x001E5FE7
		public unsafe bool bIsSuddenMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsSuddenMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bIsSuddenMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x06014BB7 RID: 84919 RVA: 0x001E7DF8 File Offset: 0x001E5FF8
		// (set) Token: 0x06014BB8 RID: 84920 RVA: 0x001E7E08 File Offset: 0x001E6008
		public unsafe float SuddenMoveCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SuddenMoveCd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_SuddenMoveCd) = value;
			}
		}

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x06014BB9 RID: 84921 RVA: 0x001E7E19 File Offset: 0x001E6019
		// (set) Token: 0x06014BBA RID: 84922 RVA: 0x001E7E2D File Offset: 0x001E602D
		public unsafe FVector4 VehicleSuddenMoveMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleSuddenMoveMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_VehicleSuddenMoveMix) = value;
			}
		}

		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x06014BBB RID: 84923 RVA: 0x001E7E42 File Offset: 0x001E6042
		// (set) Token: 0x06014BBC RID: 84924 RVA: 0x001E7E52 File Offset: 0x001E6052
		public unsafe float LastForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LastForwardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_LastForwardSpeed) = value;
			}
		}

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x06014BBD RID: 84925 RVA: 0x001E7E63 File Offset: 0x001E6063
		// (set) Token: 0x06014BBE RID: 84926 RVA: 0x001E7E73 File Offset: 0x001E6073
		public unsafe float CurForwardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CurForwardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_CurForwardSpeed) = value;
			}
		}

		// Token: 0x06014BBF RID: 84927 RVA: 0x001E7E84 File Offset: 0x001E6084
		static UKuroAnimInstanceRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceRole");
		}

		// Token: 0x06014BC0 RID: 84928 RVA: 0x001E7E92 File Offset: 0x001E6092
		protected UKuroAnimInstanceRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B41C RID: 46108
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceRole";

		// Token: 0x0400B41D RID: 46109
		private static IntPtr _ClassPtr;

		// Token: 0x0400B41E RID: 46110
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B41F RID: 46111
		internal static int __PropertyOffset_ValidPerformanceIndexes;

		// Token: 0x0400B420 RID: 46112
		[Nullable(2)]
		private TArray<int> _ValidPerformanceIndexes;

		// Token: 0x0400B421 RID: 46113
		internal static int __PropertyOffset_FloorSpeed;

		// Token: 0x0400B422 RID: 46114
		internal static int __PropertyOffset_bCanbeInterrupt;

		// Token: 0x0400B423 RID: 46115
		internal static int __PropertyOffset_bMoveBlock;

		// Token: 0x0400B424 RID: 46116
		internal static int __PropertyOffset_TimeSeconds;

		// Token: 0x0400B425 RID: 46117
		internal static int __PropertyOffset_bIsNotNPC;

		// Token: 0x0400B426 RID: 46118
		internal static int __PropertyOffset_ChangeRoleCount;

		// Token: 0x0400B427 RID: 46119
		internal static int __PropertyOffset_bHasNPCTag;

		// Token: 0x0400B428 RID: 46120
		internal static int __PropertyOffset_bIsGoingToMove;

		// Token: 0x0400B429 RID: 46121
		internal static int __PropertyOffset_TurnMix;

		// Token: 0x0400B42A RID: 46122
		internal static int __PropertyOffset_SpeedMix;

		// Token: 0x0400B42B RID: 46123
		internal static int __PropertyOffset_LerpSpeedAlpha;

		// Token: 0x0400B42C RID: 46124
		internal static int __PropertyOffset_AimMoveMix;

		// Token: 0x0400B42D RID: 46125
		internal static int __PropertyOffset_LocalAccel;

		// Token: 0x0400B42E RID: 46126
		internal static int __PropertyOffset_LeanAmount;

		// Token: 0x0400B42F RID: 46127
		[Nullable(2)]
		private FLeanAmount _LeanAmount;

		// Token: 0x0400B430 RID: 46128
		internal static int __PropertyOffset_MoveDirection;

		// Token: 0x0400B431 RID: 46129
		internal static int __PropertyOffset_GroundMovePlayRate;

		// Token: 0x0400B432 RID: 46130
		internal static int __PropertyOffset_WalkRunMix;

		// Token: 0x0400B433 RID: 46131
		internal static int __PropertyOffset_StepSizeMix;

		// Token: 0x0400B434 RID: 46132
		internal static int __PropertyOffset_AccelLerpMix;

		// Token: 0x0400B435 RID: 46133
		internal static int __PropertyOffset_AimYaw;

		// Token: 0x0400B436 RID: 46134
		internal static int __PropertyOffset_AimPitch;

		// Token: 0x0400B437 RID: 46135
		internal static int __PropertyOffset_bIsFightStand;

		// Token: 0x0400B438 RID: 46136
		internal static int __PropertyOffset_MoveMix;

		// Token: 0x0400B439 RID: 46137
		internal static int __PropertyOffset_CachePercentLR;

		// Token: 0x0400B43A RID: 46138
		internal static int __PropertyOffset_CachePercentFB;

		// Token: 0x0400B43B RID: 46139
		internal static int __PropertyOffset_StandTurnType;

		// Token: 0x0400B43C RID: 46140
		internal static int __PropertyOffset_StandTurnAngle;

		// Token: 0x0400B43D RID: 46141
		internal static int __PropertyOffset_LandSpeedIndex;

		// Token: 0x0400B43E RID: 46142
		internal static int __PropertyOffset_FallingSpeed;

		// Token: 0x0400B43F RID: 46143
		internal static int __PropertyOffset_ForecastLandWeight;

		// Token: 0x0400B440 RID: 46144
		internal static int __PropertyOffset_AirVelocity;

		// Token: 0x0400B441 RID: 46145
		internal static int __PropertyOffset_AirTargetYaw;

		// Token: 0x0400B442 RID: 46146
		internal static int __PropertyOffset_GlideMix;

		// Token: 0x0400B443 RID: 46147
		internal static int __PropertyOffset_SlideMix;

		// Token: 0x0400B444 RID: 46148
		internal static int __PropertyOffset_AirSlideMix;

		// Token: 0x0400B445 RID: 46149
		internal static int __PropertyOffset_HookRopeMix;

		// Token: 0x0400B446 RID: 46150
		internal static int __PropertyOffset_HookRopeSucceedSpeed;

		// Token: 0x0400B447 RID: 46151
		internal static int __PropertyOffset_JumpMix;

		// Token: 0x0400B448 RID: 46152
		internal static int __PropertyOffset_AirRelativeVelocity;

		// Token: 0x0400B449 RID: 46153
		internal static int __PropertyOffset_SwimRootOffset;

		// Token: 0x0400B44A RID: 46154
		internal static int __PropertyOffset_SwimAccelOffset;

		// Token: 0x0400B44B RID: 46155
		internal static int __PropertyOffset_SwimAccelOffsetReal;

		// Token: 0x0400B44C RID: 46156
		internal static int __PropertyOffset_SwimMix;

		// Token: 0x0400B44D RID: 46157
		internal static int __PropertyOffset_FastClimbMix;

		// Token: 0x0400B44E RID: 46158
		internal static int __PropertyOffset_ClimbBrakeMix;

		// Token: 0x0400B44F RID: 46159
		internal static int __PropertyOffset_bIsClimbMoving;

		// Token: 0x0400B450 RID: 46160
		internal static int __PropertyOffset_ClimbRadius;

		// Token: 0x0400B451 RID: 46161
		internal static int __PropertyOffset_ClimbDirection;

		// Token: 0x0400B452 RID: 46162
		internal static int __PropertyOffset_ValidClimbDirection;

		// Token: 0x0400B453 RID: 46163
		internal static int __PropertyOffset_IKMode;

		// Token: 0x0400B454 RID: 46164
		internal static int __PropertyOffset_bIKNoLerp;

		// Token: 0x0400B455 RID: 46165
		internal static int __PropertyOffset_ComprehensiveRotator;

		// Token: 0x0400B456 RID: 46166
		internal static int __PropertyOffset_BeHitStandardizedDirect;

		// Token: 0x0400B457 RID: 46167
		internal static int __PropertyOffset_BeHitSocketLocation;

		// Token: 0x0400B458 RID: 46168
		internal static int __PropertyOffset_SightLockAlpha;

		// Token: 0x0400B459 RID: 46169
		internal static int __PropertyOffset_SightLockDirect;

		// Token: 0x0400B45A RID: 46170
		internal static int __PropertyOffset_bInAimShotEnd;

		// Token: 0x0400B45B RID: 46171
		internal static int __PropertyOffset_AimYawMix;

		// Token: 0x0400B45C RID: 46172
		internal static int __PropertyOffset_FreezeCountDown;

		// Token: 0x0400B45D RID: 46173
		internal static int __PropertyOffset_bStateStop;

		// Token: 0x0400B45E RID: 46174
		internal static int __PropertyOffset_bStateSprintStop;

		// Token: 0x0400B45F RID: 46175
		internal static int __PropertyOffset_bStateRunStop;

		// Token: 0x0400B460 RID: 46176
		internal static int __PropertyOffset_bStateWalkStop;

		// Token: 0x0400B461 RID: 46177
		internal static int __PropertyOffset_bStateGround;

		// Token: 0x0400B462 RID: 46178
		internal static int __PropertyOffset_bStateStand;

		// Token: 0x0400B463 RID: 46179
		internal static int __PropertyOffset_bStateGroundSprint;

		// Token: 0x0400B464 RID: 46180
		internal static int __PropertyOffset_bStateGroundRun;

		// Token: 0x0400B465 RID: 46181
		internal static int __PropertyOffset_bStateGroundWalk;

		// Token: 0x0400B466 RID: 46182
		internal static int __PropertyOffset_bStateClimb;

		// Token: 0x0400B467 RID: 46183
		internal static int __PropertyOffset_bStateAir;

		// Token: 0x0400B468 RID: 46184
		internal static int __PropertyOffset_bStateSki;

		// Token: 0x0400B469 RID: 46185
		internal static int __PropertyOffset_bStateNormalSki;

		// Token: 0x0400B46A RID: 46186
		internal static int __PropertyOffset_bStateAirSlide;

		// Token: 0x0400B46B RID: 46187
		internal static int __PropertyOffset_bStateAirGlide;

		// Token: 0x0400B46C RID: 46188
		internal static int __PropertyOffset_bStateAirKite;

		// Token: 0x0400B46D RID: 46189
		internal static int __PropertyOffset_bStateWater;

		// Token: 0x0400B46E RID: 46190
		internal static int __PropertyOffset_bStateSkill;

		// Token: 0x0400B46F RID: 46191
		internal static int __PropertyOffset_bStateLockDirection;

		// Token: 0x0400B470 RID: 46192
		internal static int __PropertyOffset_bStateAimDirection;

		// Token: 0x0400B471 RID: 46193
		internal static int __PropertyOffset_bStateFaceDirection;

		// Token: 0x0400B472 RID: 46194
		internal static int __PropertyOffset_bStateBeHit;

		// Token: 0x0400B473 RID: 46195
		internal static int __PropertyOffset_bStateHitPush;

		// Token: 0x0400B474 RID: 46196
		internal static int __PropertyOffset_bStateBeHitFly;

		// Token: 0x0400B475 RID: 46197
		internal static int __PropertyOffset_bStateDying;

		// Token: 0x0400B476 RID: 46198
		internal static int __PropertyOffset_bStateDrown;

		// Token: 0x0400B477 RID: 46199
		internal static int __PropertyOffset_bStateInBattle;

		// Token: 0x0400B478 RID: 46200
		internal static int __PropertyOffset_bStateEnterBattle;

		// Token: 0x0400B479 RID: 46201
		internal static int __PropertyOffset_bStateKeepSprint;

		// Token: 0x0400B47A RID: 46202
		internal static int __PropertyOffset_bStateFastSwim;

		// Token: 0x0400B47B RID: 46203
		internal static int __PropertyOffset_bStateSit;

		// Token: 0x0400B47C RID: 46204
		internal static int __PropertyOffset_bStateXA;

		// Token: 0x0400B47D RID: 46205
		internal static int __PropertyOffset_bStateAreaSportMode;

		// Token: 0x0400B47E RID: 46206
		internal static int __PropertyOffset_bStateAreaSportModeKeep;

		// Token: 0x0400B47F RID: 46207
		internal static int __PropertyOffset_bStateVehicleDriveMoto;

		// Token: 0x0400B480 RID: 46208
		internal static int __PropertyOffset_bCharacterStateAreaSportMode;

		// Token: 0x0400B481 RID: 46209
		internal static int __PropertyOffset_bStateOverlapBaseAnim;

		// Token: 0x0400B482 RID: 46210
		internal static int __PropertyOffset_bUseAdditive;

		// Token: 0x0400B483 RID: 46211
		internal static int __PropertyOffset_bUseOverlapLayerAdditive;

		// Token: 0x0400B484 RID: 46212
		internal static int __PropertyOffset_bStateLowerRightTurnBlending;

		// Token: 0x0400B485 RID: 46213
		internal static int __PropertyOffset_bStateLowerBlending;

		// Token: 0x0400B486 RID: 46214
		internal static int __PropertyOffset_bStateWholeBodyBlend;

		// Token: 0x0400B487 RID: 46215
		internal static int __PropertyOffset_bStateUseSpecialStateMachine;

		// Token: 0x0400B488 RID: 46216
		internal static int __PropertyOffset_bStateFastBlend;

		// Token: 0x0400B489 RID: 46217
		internal static int __PropertyOffset_bUseArmAdditive;

		// Token: 0x0400B48A RID: 46218
		internal static int __PropertyOffset_bStateLeftArmBlend;

		// Token: 0x0400B48B RID: 46219
		internal static int __PropertyOffset_bStateRightArmBlend;

		// Token: 0x0400B48C RID: 46220
		internal static int __PropertyOffset_LowerBlendAlpha;

		// Token: 0x0400B48D RID: 46221
		internal static int __PropertyOffset_BlendAlphaPelvis;

		// Token: 0x0400B48E RID: 46222
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaPelvis;

		// Token: 0x0400B48F RID: 46223
		internal static int __PropertyOffset_BlendAlphaSpine;

		// Token: 0x0400B490 RID: 46224
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaSpine;

		// Token: 0x0400B491 RID: 46225
		internal static int __PropertyOffset_BlendAlphaSpine1;

		// Token: 0x0400B492 RID: 46226
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaSpine1;

		// Token: 0x0400B493 RID: 46227
		internal static int __PropertyOffset_BlendAlphaSpine2;

		// Token: 0x0400B494 RID: 46228
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaSpine2;

		// Token: 0x0400B495 RID: 46229
		internal static int __PropertyOffset_BlendAlphaHead;

		// Token: 0x0400B496 RID: 46230
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaHead;

		// Token: 0x0400B497 RID: 46231
		internal static int __PropertyOffset_BlendAlphaArmL;

		// Token: 0x0400B498 RID: 46232
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaArmL;

		// Token: 0x0400B499 RID: 46233
		internal static int __PropertyOffset_BlendAlphaArmR;

		// Token: 0x0400B49A RID: 46234
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaArmR;

		// Token: 0x0400B49B RID: 46235
		internal static int __PropertyOffset_BlendAlphaLeg;

		// Token: 0x0400B49C RID: 46236
		[Nullable(2)]
		private FAdditiveBlendAlpha _BlendAlphaLeg;

		// Token: 0x0400B49D RID: 46237
		internal static int __PropertyOffset_bStateCast;

		// Token: 0x0400B49E RID: 46238
		internal static int __PropertyOffset_bStateCastThrowing;

		// Token: 0x0400B49F RID: 46239
		internal static int __PropertyOffset_bStateCastSelecting;

		// Token: 0x0400B4A0 RID: 46240
		internal static int __PropertyOffset_bStateCastCasting;

		// Token: 0x0400B4A1 RID: 46241
		internal static int __PropertyOffset_bStateMoveShot;

		// Token: 0x0400B4A2 RID: 46242
		internal static int __PropertyOffset_bStateHoldShot;

		// Token: 0x0400B4A3 RID: 46243
		internal static int __PropertyOffset_bStateAiming;

		// Token: 0x0400B4A4 RID: 46244
		internal static int __PropertyOffset_bStateGeneralAiming;

		// Token: 0x0400B4A5 RID: 46245
		internal static int __PropertyOffset_bStateShotNotify;

		// Token: 0x0400B4A6 RID: 46246
		internal static int __PropertyOffset_bStateFixHook;

		// Token: 0x0400B4A7 RID: 46247
		internal static int __PropertyOffset_bStateAirNormalShot;

		// Token: 0x0400B4A8 RID: 46248
		internal static int __PropertyOffset_bStateAirNormalShotLeft;

		// Token: 0x0400B4A9 RID: 46249
		internal static int __PropertyOffset_bStateAirNormalShotRight;

		// Token: 0x0400B4AA RID: 46250
		internal static int __PropertyOffset_bStateAirNormalShotFall;

		// Token: 0x0400B4AB RID: 46251
		internal static int __PropertyOffset_bStateBurst;

		// Token: 0x0400B4AC RID: 46252
		internal static int __PropertyOffset_bStateInBurst;

		// Token: 0x0400B4AD RID: 46253
		internal static int __PropertyOffset_bStateLimitForward;

		// Token: 0x0400B4AE RID: 46254
		internal static int __PropertyOffset_bStateLimitBackward;

		// Token: 0x0400B4AF RID: 46255
		internal static int __PropertyOffset_bLandRollWhenDying;

		// Token: 0x0400B4B0 RID: 46256
		internal static int __PropertyOffset_bCaught;

		// Token: 0x0400B4B1 RID: 46257
		internal static int __PropertyOffset_bRagDollQuit;

		// Token: 0x0400B4B2 RID: 46258
		internal static int __PropertyOffset_bDisablePerformance;

		// Token: 0x0400B4B3 RID: 46259
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x0400B4B4 RID: 46260
		internal static int __PropertyOffset_bEpresion;

		// Token: 0x0400B4B5 RID: 46261
		internal static int __PropertyOffset_PerformanceCountDown;

		// Token: 0x0400B4B6 RID: 46262
		internal static int __PropertyOffset_bPerformance;

		// Token: 0x0400B4B7 RID: 46263
		internal static int __PropertyOffset_PerformanceIndex;

		// Token: 0x0400B4B8 RID: 46264
		internal static int __PropertyOffset_bAllowPerformance;

		// Token: 0x0400B4B9 RID: 46265
		internal static int __PropertyOffset_bAllowManualPerformance;

		// Token: 0x0400B4BA RID: 46266
		internal static int __PropertyOffset_AllowManualPerformanceIndex;

		// Token: 0x0400B4BB RID: 46267
		internal static int __PropertyOffset_bAllowManualPerformanceLoop;

		// Token: 0x0400B4BC RID: 46268
		internal static int __PropertyOffset_bAcceptNewSkill;

		// Token: 0x0400B4BD RID: 46269
		internal static int __PropertyOffset_bStageMotionSki;

		// Token: 0x0400B4BE RID: 46270
		internal static int __PropertyOffset_bHugeItemPull;

		// Token: 0x0400B4BF RID: 46271
		internal static int __PropertyOffset_bHugeItemPullAngle;

		// Token: 0x0400B4C0 RID: 46272
		internal static int __PropertyOffset_SizeToCharHeightMap;

		// Token: 0x0400B4C1 RID: 46273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _SizeToCharHeightMap;

		// Token: 0x0400B4C2 RID: 46274
		internal static int __PropertyOffset_LandSpeedThresholds;

		// Token: 0x0400B4C3 RID: 46275
		internal static int __PropertyOffset_SpeedMixLerp;

		// Token: 0x0400B4C4 RID: 46276
		internal static int __PropertyOffset_GroundLeanLerp;

		// Token: 0x0400B4C5 RID: 46277
		internal static int __PropertyOffset_AnimWalkSpeed;

		// Token: 0x0400B4C6 RID: 46278
		internal static int __PropertyOffset_AnimRunSpeed;

		// Token: 0x0400B4C7 RID: 46279
		internal static int __PropertyOffset_AnimSprintSpeed;

		// Token: 0x0400B4C8 RID: 46280
		internal static int __PropertyOffset_AirLeanLerp;

		// Token: 0x0400B4C9 RID: 46281
		internal static int __PropertyOffset_JumpMixLerp;

		// Token: 0x0400B4CA RID: 46282
		internal static int __PropertyOffset_SlideRotateLerp;

		// Token: 0x0400B4CB RID: 46283
		internal static int __PropertyOffset_SlideRotateLerp2;

		// Token: 0x0400B4CC RID: 46284
		internal static int __PropertyOffset_StandWalkStepCurve;

		// Token: 0x0400B4CD RID: 46285
		internal static int __PropertyOffset_StandRunStepCurve;

		// Token: 0x0400B4CE RID: 46286
		internal static int __PropertyOffset_ForecastLandCurve;

		// Token: 0x0400B4CF RID: 46287
		internal static int __PropertyOffset_RelativeSpeedBlendCurve;

		// Token: 0x0400B4D0 RID: 46288
		internal static int __PropertyOffset_AirLeanCurve;

		// Token: 0x0400B4D1 RID: 46289
		internal static int __PropertyOffset_AngelToStepLengthCurve;

		// Token: 0x0400B4D2 RID: 46290
		internal static int __PropertyOffset_AngleToStepFrequencyCurve;

		// Token: 0x0400B4D3 RID: 46291
		internal static int __PropertyOffset_FkMaterialControllerData;

		// Token: 0x0400B4D4 RID: 46292
		internal static int __PropertyOffset_XAUDBlend;

		// Token: 0x0400B4D5 RID: 46293
		internal static int __PropertyOffset_XARLBlend;

		// Token: 0x0400B4D6 RID: 46294
		internal static int __PropertyOffset_bMovingPlatformMoving;

		// Token: 0x0400B4D7 RID: 46295
		internal static int __PropertyOffset_MovingPlatIKAlpha;

		// Token: 0x0400B4D8 RID: 46296
		internal static int __PropertyOffset_UphillLeanForward;

		// Token: 0x0400B4D9 RID: 46297
		internal static int __PropertyOffset_UphillIKDiminish;

		// Token: 0x0400B4DA RID: 46298
		internal static int __PropertyOffset_bIsVehicleImpact;

		// Token: 0x0400B4DB RID: 46299
		internal static int __PropertyOffset_VehicleCollisionAlpha;

		// Token: 0x0400B4DC RID: 46300
		internal static int __PropertyOffset_VehicleCollisionAngle;

		// Token: 0x0400B4DD RID: 46301
		internal static int __PropertyOffset_VehicleCollisionStrength;

		// Token: 0x0400B4DE RID: 46302
		internal static int __PropertyOffset_VehicleCollisionMix;

		// Token: 0x0400B4DF RID: 46303
		internal static int __PropertyOffset_VehicleSeatRot;

		// Token: 0x0400B4E0 RID: 46304
		internal static int __PropertyOffset_bIsGondolaClimbWaterfall;

		// Token: 0x0400B4E1 RID: 46305
		internal static int __PropertyOffset_bIsSuddenStop;

		// Token: 0x0400B4E2 RID: 46306
		internal static int __PropertyOffset_bIsSuddenMove;

		// Token: 0x0400B4E3 RID: 46307
		internal static int __PropertyOffset_SuddenMoveCd;

		// Token: 0x0400B4E4 RID: 46308
		internal static int __PropertyOffset_VehicleSuddenMoveMix;

		// Token: 0x0400B4E5 RID: 46309
		internal static int __PropertyOffset_LastForwardSpeed;

		// Token: 0x0400B4E6 RID: 46310
		internal static int __PropertyOffset_CurForwardSpeed;
	}
}
