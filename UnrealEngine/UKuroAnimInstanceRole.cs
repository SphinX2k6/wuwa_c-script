using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F1 RID: 753
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceRole")]
	[UnrealStructLayout(3856, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3856)]
	public class UKuroAnimInstanceRole : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060050B7 RID: 20663 RVA: 0x0007162A File Offset: 0x0006F82A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceRole._ClassPtr;
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00071638 File Offset: 0x0006F838
		public UKuroAnimInstanceRole() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00071660 File Offset: 0x0006F860
		[NullableContext(1)]
		public UKuroAnimInstanceRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x060050BA RID: 20666 RVA: 0x00071694 File Offset: 0x0006F894
		// (set) Token: 0x060050BB RID: 20667 RVA: 0x000716CD File Offset: 0x0006F8CD
		[Nullable(1)]
		public TArray<int> ValidPerformanceIndexes
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.ValidPerformanceIndexes.CopyAssign(value);
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x000716DB File Offset: 0x0006F8DB
		// (set) Token: 0x060050BD RID: 20669 RVA: 0x000716EB File Offset: 0x0006F8EB
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x060050BE RID: 20670 RVA: 0x000716FC File Offset: 0x0006F8FC
		// (set) Token: 0x060050BF RID: 20671 RVA: 0x0007170C File Offset: 0x0006F90C
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x0007171D File Offset: 0x0006F91D
		// (set) Token: 0x060050C1 RID: 20673 RVA: 0x0007172D File Offset: 0x0006F92D
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

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x0007173E File Offset: 0x0006F93E
		// (set) Token: 0x060050C3 RID: 20675 RVA: 0x0007174E File Offset: 0x0006F94E
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

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x0007175F File Offset: 0x0006F95F
		// (set) Token: 0x060050C5 RID: 20677 RVA: 0x0007176F File Offset: 0x0006F96F
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x00071780 File Offset: 0x0006F980
		// (set) Token: 0x060050C7 RID: 20679 RVA: 0x00071790 File Offset: 0x0006F990
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

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x000717A1 File Offset: 0x0006F9A1
		// (set) Token: 0x060050C9 RID: 20681 RVA: 0x000717B1 File Offset: 0x0006F9B1
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

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x000717C2 File Offset: 0x0006F9C2
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x000717D2 File Offset: 0x0006F9D2
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

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x000717E3 File Offset: 0x0006F9E3
		// (set) Token: 0x060050CD RID: 20685 RVA: 0x000717F3 File Offset: 0x0006F9F3
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

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x00071804 File Offset: 0x0006FA04
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00071818 File Offset: 0x0006FA18
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

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x0007182D File Offset: 0x0006FA2D
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x0007183D File Offset: 0x0006FA3D
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

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x0007184E File Offset: 0x0006FA4E
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x00071862 File Offset: 0x0006FA62
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

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x00071877 File Offset: 0x0006FA77
		// (set) Token: 0x060050D5 RID: 20693 RVA: 0x0007188B File Offset: 0x0006FA8B
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

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x000718A0 File Offset: 0x0006FAA0
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x000718B0 File Offset: 0x0006FAB0
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

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x000718C1 File Offset: 0x0006FAC1
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x000718D1 File Offset: 0x0006FAD1
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

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x000718E2 File Offset: 0x0006FAE2
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x000718F2 File Offset: 0x0006FAF2
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

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x00071903 File Offset: 0x0006FB03
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x00071917 File Offset: 0x0006FB17
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

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x0007192C File Offset: 0x0006FB2C
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x0007193C File Offset: 0x0006FB3C
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

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x0007194D File Offset: 0x0006FB4D
		// (set) Token: 0x060050E1 RID: 20705 RVA: 0x0007195D File Offset: 0x0006FB5D
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

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060050E2 RID: 20706 RVA: 0x0007196E File Offset: 0x0006FB6E
		// (set) Token: 0x060050E3 RID: 20707 RVA: 0x0007197E File Offset: 0x0006FB7E
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

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x0007198F File Offset: 0x0006FB8F
		// (set) Token: 0x060050E5 RID: 20709 RVA: 0x000719A3 File Offset: 0x0006FBA3
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x000719B8 File Offset: 0x0006FBB8
		// (set) Token: 0x060050E7 RID: 20711 RVA: 0x000719C8 File Offset: 0x0006FBC8
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

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x000719D9 File Offset: 0x0006FBD9
		// (set) Token: 0x060050E9 RID: 20713 RVA: 0x000719E9 File Offset: 0x0006FBE9
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x000719FA File Offset: 0x0006FBFA
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x00071A0A File Offset: 0x0006FC0A
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x00071A1B File Offset: 0x0006FC1B
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x00071A2B File Offset: 0x0006FC2B
		public unsafe bool bNeedUpdateStandTurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bNeedUpdateStandTurnAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_bNeedUpdateStandTurnAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x00071A3C File Offset: 0x0006FC3C
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x00071A4C File Offset: 0x0006FC4C
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x00071A5D File Offset: 0x0006FC5D
		// (set) Token: 0x060050F1 RID: 20721 RVA: 0x00071A6D File Offset: 0x0006FC6D
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

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x00071A7E File Offset: 0x0006FC7E
		// (set) Token: 0x060050F3 RID: 20723 RVA: 0x00071A8E File Offset: 0x0006FC8E
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

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060050F4 RID: 20724 RVA: 0x00071A9F File Offset: 0x0006FC9F
		// (set) Token: 0x060050F5 RID: 20725 RVA: 0x00071AB3 File Offset: 0x0006FCB3
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

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x00071AC8 File Offset: 0x0006FCC8
		// (set) Token: 0x060050F7 RID: 20727 RVA: 0x00071AD8 File Offset: 0x0006FCD8
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

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x00071AE9 File Offset: 0x0006FCE9
		// (set) Token: 0x060050F9 RID: 20729 RVA: 0x00071AFD File Offset: 0x0006FCFD
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

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x00071B12 File Offset: 0x0006FD12
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x00071B22 File Offset: 0x0006FD22
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

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x00071B33 File Offset: 0x0006FD33
		// (set) Token: 0x060050FD RID: 20733 RVA: 0x00071B47 File Offset: 0x0006FD47
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

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x00071B5C File Offset: 0x0006FD5C
		// (set) Token: 0x060050FF RID: 20735 RVA: 0x00071B70 File Offset: 0x0006FD70
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

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x00071B85 File Offset: 0x0006FD85
		// (set) Token: 0x06005101 RID: 20737 RVA: 0x00071B95 File Offset: 0x0006FD95
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

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x00071BA6 File Offset: 0x0006FDA6
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x00071BB6 File Offset: 0x0006FDB6
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

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x00071BC7 File Offset: 0x0006FDC7
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x00071BDB File Offset: 0x0006FDDB
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

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x00071C04 File Offset: 0x0006FE04
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

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00071C19 File Offset: 0x0006FE19
		// (set) Token: 0x06005109 RID: 20745 RVA: 0x00071C29 File Offset: 0x0006FE29
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

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00071C3A File Offset: 0x0006FE3A
		// (set) Token: 0x0600510B RID: 20747 RVA: 0x00071C4A File Offset: 0x0006FE4A
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

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00071C5B File Offset: 0x0006FE5B
		// (set) Token: 0x0600510D RID: 20749 RVA: 0x00071C6B File Offset: 0x0006FE6B
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

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x00071C7C File Offset: 0x0006FE7C
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x00071C8C File Offset: 0x0006FE8C
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

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00071C9D File Offset: 0x0006FE9D
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x00071CAD File Offset: 0x0006FEAD
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x00071CBE File Offset: 0x0006FEBE
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x00071CCE File Offset: 0x0006FECE
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

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x00071CDF File Offset: 0x0006FEDF
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x00071CEF File Offset: 0x0006FEEF
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

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x00071D00 File Offset: 0x0006FF00
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x00071D10 File Offset: 0x0006FF10
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

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x00071D21 File Offset: 0x0006FF21
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x00071D31 File Offset: 0x0006FF31
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

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x00071D42 File Offset: 0x0006FF42
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x00071D52 File Offset: 0x0006FF52
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

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x00071D63 File Offset: 0x0006FF63
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x00071D73 File Offset: 0x0006FF73
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

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x00071D84 File Offset: 0x0006FF84
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x00071D98 File Offset: 0x0006FF98
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

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00071DAD File Offset: 0x0006FFAD
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x00071DC1 File Offset: 0x0006FFC1
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x00071DD6 File Offset: 0x0006FFD6
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x00071DEA File Offset: 0x0006FFEA
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

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00071DFF File Offset: 0x0006FFFF
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x00071E0F File Offset: 0x0007000F
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

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00071E20 File Offset: 0x00070020
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x00071E34 File Offset: 0x00070034
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

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00071E49 File Offset: 0x00070049
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x00071E59 File Offset: 0x00070059
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x00071E6A File Offset: 0x0007006A
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x00071E7A File Offset: 0x0007007A
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

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x00071E8B File Offset: 0x0007008B
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00071E9B File Offset: 0x0007009B
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

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x00071EAC File Offset: 0x000700AC
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x00071EBC File Offset: 0x000700BC
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

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x00071ECD File Offset: 0x000700CD
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x00071EDD File Offset: 0x000700DD
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x00071EEE File Offset: 0x000700EE
		// (set) Token: 0x06005133 RID: 20787 RVA: 0x00071EFE File Offset: 0x000700FE
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

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x00071F0F File Offset: 0x0007010F
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x00071F1F File Offset: 0x0007011F
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x00071F30 File Offset: 0x00070130
		// (set) Token: 0x06005137 RID: 20791 RVA: 0x00071F40 File Offset: 0x00070140
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x00071F51 File Offset: 0x00070151
		// (set) Token: 0x06005139 RID: 20793 RVA: 0x00071F61 File Offset: 0x00070161
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x00071F72 File Offset: 0x00070172
		// (set) Token: 0x0600513B RID: 20795 RVA: 0x00071F82 File Offset: 0x00070182
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x00071F93 File Offset: 0x00070193
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x00071FA3 File Offset: 0x000701A3
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

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x00071FB4 File Offset: 0x000701B4
		// (set) Token: 0x0600513F RID: 20799 RVA: 0x00071FC4 File Offset: 0x000701C4
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

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00071FD5 File Offset: 0x000701D5
		// (set) Token: 0x06005141 RID: 20801 RVA: 0x00071FE5 File Offset: 0x000701E5
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

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x00071FF6 File Offset: 0x000701F6
		// (set) Token: 0x06005143 RID: 20803 RVA: 0x00072006 File Offset: 0x00070206
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

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x00072017 File Offset: 0x00070217
		// (set) Token: 0x06005145 RID: 20805 RVA: 0x00072027 File Offset: 0x00070227
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

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x00072038 File Offset: 0x00070238
		// (set) Token: 0x06005147 RID: 20807 RVA: 0x00072048 File Offset: 0x00070248
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

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x00072059 File Offset: 0x00070259
		// (set) Token: 0x06005149 RID: 20809 RVA: 0x00072069 File Offset: 0x00070269
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

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x0007207A File Offset: 0x0007027A
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x0007208A File Offset: 0x0007028A
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

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x0007209B File Offset: 0x0007029B
		// (set) Token: 0x0600514D RID: 20813 RVA: 0x000720AB File Offset: 0x000702AB
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

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x000720BC File Offset: 0x000702BC
		// (set) Token: 0x0600514F RID: 20815 RVA: 0x000720CC File Offset: 0x000702CC
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

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x000720DD File Offset: 0x000702DD
		// (set) Token: 0x06005151 RID: 20817 RVA: 0x000720ED File Offset: 0x000702ED
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

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x000720FE File Offset: 0x000702FE
		// (set) Token: 0x06005153 RID: 20819 RVA: 0x0007210E File Offset: 0x0007030E
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

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x0007211F File Offset: 0x0007031F
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x0007212F File Offset: 0x0007032F
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

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x00072140 File Offset: 0x00070340
		// (set) Token: 0x06005157 RID: 20823 RVA: 0x00072150 File Offset: 0x00070350
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

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x00072161 File Offset: 0x00070361
		// (set) Token: 0x06005159 RID: 20825 RVA: 0x00072171 File Offset: 0x00070371
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x00072182 File Offset: 0x00070382
		// (set) Token: 0x0600515B RID: 20827 RVA: 0x00072192 File Offset: 0x00070392
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

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x000721A3 File Offset: 0x000703A3
		// (set) Token: 0x0600515D RID: 20829 RVA: 0x000721B3 File Offset: 0x000703B3
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

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x000721C4 File Offset: 0x000703C4
		// (set) Token: 0x0600515F RID: 20831 RVA: 0x000721D4 File Offset: 0x000703D4
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x000721E5 File Offset: 0x000703E5
		// (set) Token: 0x06005161 RID: 20833 RVA: 0x000721F5 File Offset: 0x000703F5
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

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x00072206 File Offset: 0x00070406
		// (set) Token: 0x06005163 RID: 20835 RVA: 0x00072216 File Offset: 0x00070416
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

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x00072227 File Offset: 0x00070427
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x00072237 File Offset: 0x00070437
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x00072248 File Offset: 0x00070448
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x00072258 File Offset: 0x00070458
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x00072269 File Offset: 0x00070469
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x00072279 File Offset: 0x00070479
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

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x0007228A File Offset: 0x0007048A
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x0007229A File Offset: 0x0007049A
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

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x000722AB File Offset: 0x000704AB
		// (set) Token: 0x0600516D RID: 20845 RVA: 0x000722BB File Offset: 0x000704BB
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

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x000722CC File Offset: 0x000704CC
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x000722DC File Offset: 0x000704DC
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06005170 RID: 20848 RVA: 0x000722ED File Offset: 0x000704ED
		// (set) Token: 0x06005171 RID: 20849 RVA: 0x000722FD File Offset: 0x000704FD
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

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x0007230E File Offset: 0x0007050E
		// (set) Token: 0x06005173 RID: 20851 RVA: 0x0007231E File Offset: 0x0007051E
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

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x0007232F File Offset: 0x0007052F
		// (set) Token: 0x06005175 RID: 20853 RVA: 0x0007233F File Offset: 0x0007053F
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

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x00072350 File Offset: 0x00070550
		// (set) Token: 0x06005177 RID: 20855 RVA: 0x00072360 File Offset: 0x00070560
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

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x00072371 File Offset: 0x00070571
		// (set) Token: 0x06005179 RID: 20857 RVA: 0x00072381 File Offset: 0x00070581
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

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600517A RID: 20858 RVA: 0x00072392 File Offset: 0x00070592
		// (set) Token: 0x0600517B RID: 20859 RVA: 0x000723A2 File Offset: 0x000705A2
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

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x000723B3 File Offset: 0x000705B3
		// (set) Token: 0x0600517D RID: 20861 RVA: 0x000723C3 File Offset: 0x000705C3
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

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x000723D4 File Offset: 0x000705D4
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x000723E4 File Offset: 0x000705E4
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

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x000723F5 File Offset: 0x000705F5
		// (set) Token: 0x06005181 RID: 20865 RVA: 0x00072405 File Offset: 0x00070605
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

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x00072416 File Offset: 0x00070616
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x00072426 File Offset: 0x00070626
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

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x00072437 File Offset: 0x00070637
		// (set) Token: 0x06005185 RID: 20869 RVA: 0x00072447 File Offset: 0x00070647
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

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x00072458 File Offset: 0x00070658
		// (set) Token: 0x06005187 RID: 20871 RVA: 0x00072468 File Offset: 0x00070668
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

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x00072479 File Offset: 0x00070679
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x00072489 File Offset: 0x00070689
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

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x0007249A File Offset: 0x0007069A
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x000724AA File Offset: 0x000706AA
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

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x000724BB File Offset: 0x000706BB
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x000724CB File Offset: 0x000706CB
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

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x000724DC File Offset: 0x000706DC
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x000724EC File Offset: 0x000706EC
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

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x000724FD File Offset: 0x000706FD
		// (set) Token: 0x06005191 RID: 20881 RVA: 0x0007250D File Offset: 0x0007070D
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

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x0007251E File Offset: 0x0007071E
		// (set) Token: 0x06005193 RID: 20883 RVA: 0x0007252E File Offset: 0x0007072E
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

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x0007253F File Offset: 0x0007073F
		// (set) Token: 0x06005195 RID: 20885 RVA: 0x0007254F File Offset: 0x0007074F
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

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x00072560 File Offset: 0x00070760
		// (set) Token: 0x06005197 RID: 20887 RVA: 0x00072570 File Offset: 0x00070770
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

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x00072581 File Offset: 0x00070781
		// (set) Token: 0x06005199 RID: 20889 RVA: 0x00072591 File Offset: 0x00070791
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

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x000725A2 File Offset: 0x000707A2
		// (set) Token: 0x0600519B RID: 20891 RVA: 0x000725B2 File Offset: 0x000707B2
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

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x000725C3 File Offset: 0x000707C3
		// (set) Token: 0x0600519D RID: 20893 RVA: 0x000725D3 File Offset: 0x000707D3
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x000725E4 File Offset: 0x000707E4
		// (set) Token: 0x0600519F RID: 20895 RVA: 0x000725F4 File Offset: 0x000707F4
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x00072605 File Offset: 0x00070805
		// (set) Token: 0x060051A1 RID: 20897 RVA: 0x00072615 File Offset: 0x00070815
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x00072626 File Offset: 0x00070826
		// (set) Token: 0x060051A3 RID: 20899 RVA: 0x00072636 File Offset: 0x00070836
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x00072647 File Offset: 0x00070847
		// (set) Token: 0x060051A5 RID: 20901 RVA: 0x00072657 File Offset: 0x00070857
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x00072668 File Offset: 0x00070868
		// (set) Token: 0x060051A7 RID: 20903 RVA: 0x00072678 File Offset: 0x00070878
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x00072689 File Offset: 0x00070889
		// (set) Token: 0x060051A9 RID: 20905 RVA: 0x00072699 File Offset: 0x00070899
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

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x000726AA File Offset: 0x000708AA
		// (set) Token: 0x060051AB RID: 20907 RVA: 0x000726BA File Offset: 0x000708BA
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x000726CB File Offset: 0x000708CB
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x000726DB File Offset: 0x000708DB
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

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x000726EC File Offset: 0x000708EC
		// (set) Token: 0x060051AF RID: 20911 RVA: 0x000726FC File Offset: 0x000708FC
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

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0007270D File Offset: 0x0007090D
		// (set) Token: 0x060051B1 RID: 20913 RVA: 0x0007271D File Offset: 0x0007091D
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x0007272E File Offset: 0x0007092E
		// (set) Token: 0x060051B3 RID: 20915 RVA: 0x0007273E File Offset: 0x0007093E
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

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x0007274F File Offset: 0x0007094F
		// (set) Token: 0x060051B5 RID: 20917 RVA: 0x0007275F File Offset: 0x0007095F
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

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x00072770 File Offset: 0x00070970
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x00072780 File Offset: 0x00070980
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

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x00072791 File Offset: 0x00070991
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x000727A1 File Offset: 0x000709A1
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x000727B2 File Offset: 0x000709B2
		// (set) Token: 0x060051BB RID: 20923 RVA: 0x000727C2 File Offset: 0x000709C2
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x000727D3 File Offset: 0x000709D3
		// (set) Token: 0x060051BD RID: 20925 RVA: 0x000727E3 File Offset: 0x000709E3
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

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x000727F4 File Offset: 0x000709F4
		// (set) Token: 0x060051BF RID: 20927 RVA: 0x00072804 File Offset: 0x00070A04
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

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x00072815 File Offset: 0x00070A15
		// (set) Token: 0x060051C1 RID: 20929 RVA: 0x00072825 File Offset: 0x00070A25
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

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00072836 File Offset: 0x00070A36
		// (set) Token: 0x060051C3 RID: 20931 RVA: 0x00072846 File Offset: 0x00070A46
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

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00072857 File Offset: 0x00070A57
		// (set) Token: 0x060051C5 RID: 20933 RVA: 0x00072867 File Offset: 0x00070A67
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

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x00072878 File Offset: 0x00070A78
		// (set) Token: 0x060051C7 RID: 20935 RVA: 0x00072888 File Offset: 0x00070A88
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

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x00072899 File Offset: 0x00070A99
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x000728A9 File Offset: 0x00070AA9
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

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x000728BA File Offset: 0x00070ABA
		// (set) Token: 0x060051CB RID: 20939 RVA: 0x000728CA File Offset: 0x00070ACA
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

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x000728DB File Offset: 0x00070ADB
		// (set) Token: 0x060051CD RID: 20941 RVA: 0x000728EB File Offset: 0x00070AEB
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

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x000728FC File Offset: 0x00070AFC
		// (set) Token: 0x060051CF RID: 20943 RVA: 0x0007290C File Offset: 0x00070B0C
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

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x0007291D File Offset: 0x00070B1D
		// (set) Token: 0x060051D1 RID: 20945 RVA: 0x0007292D File Offset: 0x00070B2D
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x0007293E File Offset: 0x00070B3E
		// (set) Token: 0x060051D3 RID: 20947 RVA: 0x0007294E File Offset: 0x00070B4E
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x00072960 File Offset: 0x00070B60
		// (set) Token: 0x060051D5 RID: 20949 RVA: 0x00072999 File Offset: 0x00070B99
		[Nullable(1)]
		public TMap<string, float> SizeToCharHeightMap
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.SizeToCharHeightMap.CopyAssign(value);
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x000729A7 File Offset: 0x00070BA7
		// (set) Token: 0x060051D7 RID: 20951 RVA: 0x000729BB File Offset: 0x00070BBB
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

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x000729D0 File Offset: 0x00070BD0
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x000729E0 File Offset: 0x00070BE0
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

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x000729F1 File Offset: 0x00070BF1
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x00072A01 File Offset: 0x00070C01
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

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x00072A12 File Offset: 0x00070C12
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x00072A22 File Offset: 0x00070C22
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

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x00072A33 File Offset: 0x00070C33
		// (set) Token: 0x060051DF RID: 20959 RVA: 0x00072A43 File Offset: 0x00070C43
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

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x00072A54 File Offset: 0x00070C54
		// (set) Token: 0x060051E1 RID: 20961 RVA: 0x00072A64 File Offset: 0x00070C64
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

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x00072A75 File Offset: 0x00070C75
		// (set) Token: 0x060051E3 RID: 20963 RVA: 0x00072A85 File Offset: 0x00070C85
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

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x00072A96 File Offset: 0x00070C96
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x00072AA6 File Offset: 0x00070CA6
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

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x00072AB7 File Offset: 0x00070CB7
		// (set) Token: 0x060051E7 RID: 20967 RVA: 0x00072AC7 File Offset: 0x00070CC7
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

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x00072AD8 File Offset: 0x00070CD8
		// (set) Token: 0x060051E9 RID: 20969 RVA: 0x00072AE8 File Offset: 0x00070CE8
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

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x00072AF9 File Offset: 0x00070CF9
		// (set) Token: 0x060051EB RID: 20971 RVA: 0x00072B0D File Offset: 0x00070D0D
		public unsafe UCurveFloat StandWalkStepCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandWalkStepCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandWalkStepCurve, value);
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x00072B22 File Offset: 0x00070D22
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x00072B36 File Offset: 0x00070D36
		public unsafe UCurveFloat StandRunStepCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandRunStepCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_StandRunStepCurve, value);
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x00072B4B File Offset: 0x00070D4B
		// (set) Token: 0x060051EF RID: 20975 RVA: 0x00072B5F File Offset: 0x00070D5F
		public unsafe UCurveFloat ForecastLandCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_ForecastLandCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_ForecastLandCurve, value);
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x00072B74 File Offset: 0x00070D74
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x00072B88 File Offset: 0x00070D88
		public unsafe UCurveFloat RelativeSpeedBlendCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_RelativeSpeedBlendCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_RelativeSpeedBlendCurve, value);
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00072B9D File Offset: 0x00070D9D
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x00072BB1 File Offset: 0x00070DB1
		public unsafe UCurveFloat AirLeanCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AirLeanCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AirLeanCurve, value);
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x00072BC6 File Offset: 0x00070DC6
		// (set) Token: 0x060051F5 RID: 20981 RVA: 0x00072BDA File Offset: 0x00070DDA
		public unsafe UCurveFloat AngelToStepLengthCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngelToStepLengthCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngelToStepLengthCurve, value);
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x00072BEF File Offset: 0x00070DEF
		// (set) Token: 0x060051F7 RID: 20983 RVA: 0x00072C03 File Offset: 0x00070E03
		public unsafe UCurveFloat AngleToStepFrequencyCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngleToStepFrequencyCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_AngleToStepFrequencyCurve, value);
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x00072C18 File Offset: 0x00070E18
		// (set) Token: 0x060051F9 RID: 20985 RVA: 0x00072C2C File Offset: 0x00070E2C
		public unsafe UDataAsset FkMaterialControllerData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_FkMaterialControllerData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAnimInstanceRole.__PropertyOffset_FkMaterialControllerData, value);
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00072C41 File Offset: 0x00070E41
		// (set) Token: 0x060051FB RID: 20987 RVA: 0x00072C51 File Offset: 0x00070E51
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

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x00072C62 File Offset: 0x00070E62
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x00072C72 File Offset: 0x00070E72
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x00072C83 File Offset: 0x00070E83
		// (set) Token: 0x060051FF RID: 20991 RVA: 0x00072C93 File Offset: 0x00070E93
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x00072CA4 File Offset: 0x00070EA4
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x00072CB4 File Offset: 0x00070EB4
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

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x00072CC5 File Offset: 0x00070EC5
		// (set) Token: 0x06005203 RID: 20995 RVA: 0x00072CD5 File Offset: 0x00070ED5
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

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00072CE6 File Offset: 0x00070EE6
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x00072CF6 File Offset: 0x00070EF6
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

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x00072D07 File Offset: 0x00070F07
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00072D17 File Offset: 0x00070F17
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x00072D28 File Offset: 0x00070F28
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00072D38 File Offset: 0x00070F38
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

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00072D49 File Offset: 0x00070F49
		// (set) Token: 0x0600520B RID: 21003 RVA: 0x00072D59 File Offset: 0x00070F59
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

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x00072D6A File Offset: 0x00070F6A
		// (set) Token: 0x0600520D RID: 21005 RVA: 0x00072D7A File Offset: 0x00070F7A
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x00072D8B File Offset: 0x00070F8B
		// (set) Token: 0x0600520F RID: 21007 RVA: 0x00072D9F File Offset: 0x00070F9F
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

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x00072DB4 File Offset: 0x00070FB4
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x00072DC8 File Offset: 0x00070FC8
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x00072DDD File Offset: 0x00070FDD
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x00072DED File Offset: 0x00070FED
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

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x00072DFE File Offset: 0x00070FFE
		// (set) Token: 0x06005215 RID: 21013 RVA: 0x00072E0E File Offset: 0x0007100E
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

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x00072E1F File Offset: 0x0007101F
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x00072E2F File Offset: 0x0007102F
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

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x00072E40 File Offset: 0x00071040
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x00072E50 File Offset: 0x00071050
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

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00072E61 File Offset: 0x00071061
		// (set) Token: 0x0600521B RID: 21019 RVA: 0x00072E75 File Offset: 0x00071075
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

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x00072E8A File Offset: 0x0007108A
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x00072E9A File Offset: 0x0007109A
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

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x00072EAB File Offset: 0x000710AB
		// (set) Token: 0x0600521F RID: 21023 RVA: 0x00072EBB File Offset: 0x000710BB
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

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x00072ECC File Offset: 0x000710CC
		// (set) Token: 0x06005221 RID: 21025 RVA: 0x00072EDC File Offset: 0x000710DC
		public unsafe float StartWalkBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StartWalkBlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StartWalkBlendTime) = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00072EED File Offset: 0x000710ED
		// (set) Token: 0x06005223 RID: 21027 RVA: 0x00072EFD File Offset: 0x000710FD
		public unsafe float StartRunBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StartRunBlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceRole.__PropertyOffset_StartRunBlendTime) = value;
			}
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00072F0E File Offset: 0x0007110E
		static UKuroAnimInstanceRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceRole");
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00072F1C File Offset: 0x0007111C
		protected UKuroAnimInstanceRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040020C0 RID: 8384
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceRole";

		// Token: 0x040020C1 RID: 8385
		private static IntPtr _ClassPtr;

		// Token: 0x040020C2 RID: 8386
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040020C3 RID: 8387
		internal static int __PropertyOffset_ValidPerformanceIndexes;

		// Token: 0x040020C4 RID: 8388
		private TArray<int> _ValidPerformanceIndexes;

		// Token: 0x040020C5 RID: 8389
		internal static int __PropertyOffset_FloorSpeed;

		// Token: 0x040020C6 RID: 8390
		internal static int __PropertyOffset_bCanbeInterrupt;

		// Token: 0x040020C7 RID: 8391
		internal static int __PropertyOffset_bMoveBlock;

		// Token: 0x040020C8 RID: 8392
		internal static int __PropertyOffset_TimeSeconds;

		// Token: 0x040020C9 RID: 8393
		internal static int __PropertyOffset_bIsNotNPC;

		// Token: 0x040020CA RID: 8394
		internal static int __PropertyOffset_ChangeRoleCount;

		// Token: 0x040020CB RID: 8395
		internal static int __PropertyOffset_bHasNPCTag;

		// Token: 0x040020CC RID: 8396
		internal static int __PropertyOffset_bIsGoingToMove;

		// Token: 0x040020CD RID: 8397
		internal static int __PropertyOffset_TurnMix;

		// Token: 0x040020CE RID: 8398
		internal static int __PropertyOffset_SpeedMix;

		// Token: 0x040020CF RID: 8399
		internal static int __PropertyOffset_LerpSpeedAlpha;

		// Token: 0x040020D0 RID: 8400
		internal static int __PropertyOffset_AimMoveMix;

		// Token: 0x040020D1 RID: 8401
		internal static int __PropertyOffset_LocalAccel;

		// Token: 0x040020D2 RID: 8402
		internal static int __PropertyOffset_GroundMovePlayRate;

		// Token: 0x040020D3 RID: 8403
		internal static int __PropertyOffset_WalkRunMix;

		// Token: 0x040020D4 RID: 8404
		internal static int __PropertyOffset_StepSizeMix;

		// Token: 0x040020D5 RID: 8405
		internal static int __PropertyOffset_AccelLerpMix;

		// Token: 0x040020D6 RID: 8406
		internal static int __PropertyOffset_AimYaw;

		// Token: 0x040020D7 RID: 8407
		internal static int __PropertyOffset_AimPitch;

		// Token: 0x040020D8 RID: 8408
		internal static int __PropertyOffset_bIsFightStand;

		// Token: 0x040020D9 RID: 8409
		internal static int __PropertyOffset_MoveMix;

		// Token: 0x040020DA RID: 8410
		internal static int __PropertyOffset_CachePercentLR;

		// Token: 0x040020DB RID: 8411
		internal static int __PropertyOffset_CachePercentFB;

		// Token: 0x040020DC RID: 8412
		internal static int __PropertyOffset_StandTurnAngle;

		// Token: 0x040020DD RID: 8413
		internal static int __PropertyOffset_bNeedUpdateStandTurnAngle;

		// Token: 0x040020DE RID: 8414
		internal static int __PropertyOffset_LandSpeedIndex;

		// Token: 0x040020DF RID: 8415
		internal static int __PropertyOffset_FallingSpeed;

		// Token: 0x040020E0 RID: 8416
		internal static int __PropertyOffset_ForecastLandWeight;

		// Token: 0x040020E1 RID: 8417
		internal static int __PropertyOffset_AirVelocity;

		// Token: 0x040020E2 RID: 8418
		internal static int __PropertyOffset_AirTargetYaw;

		// Token: 0x040020E3 RID: 8419
		internal static int __PropertyOffset_GlideMix;

		// Token: 0x040020E4 RID: 8420
		internal static int __PropertyOffset_SlideMix;

		// Token: 0x040020E5 RID: 8421
		internal static int __PropertyOffset_AirSlideMix;

		// Token: 0x040020E6 RID: 8422
		internal static int __PropertyOffset_HookRopeMix;

		// Token: 0x040020E7 RID: 8423
		internal static int __PropertyOffset_HookRopeSucceedSpeed;

		// Token: 0x040020E8 RID: 8424
		internal static int __PropertyOffset_JumpMix;

		// Token: 0x040020E9 RID: 8425
		internal static int __PropertyOffset_AirRelativeVelocity;

		// Token: 0x040020EA RID: 8426
		internal static int __PropertyOffset_SwimRootOffset;

		// Token: 0x040020EB RID: 8427
		internal static int __PropertyOffset_SwimAccelOffset;

		// Token: 0x040020EC RID: 8428
		internal static int __PropertyOffset_SwimAccelOffsetReal;

		// Token: 0x040020ED RID: 8429
		internal static int __PropertyOffset_SwimMix;

		// Token: 0x040020EE RID: 8430
		internal static int __PropertyOffset_FastClimbMix;

		// Token: 0x040020EF RID: 8431
		internal static int __PropertyOffset_ClimbBrakeMix;

		// Token: 0x040020F0 RID: 8432
		internal static int __PropertyOffset_bIsClimbMoving;

		// Token: 0x040020F1 RID: 8433
		internal static int __PropertyOffset_ClimbRadius;

		// Token: 0x040020F2 RID: 8434
		internal static int __PropertyOffset_ClimbDirection;

		// Token: 0x040020F3 RID: 8435
		internal static int __PropertyOffset_ValidClimbDirection;

		// Token: 0x040020F4 RID: 8436
		internal static int __PropertyOffset_IKMode;

		// Token: 0x040020F5 RID: 8437
		internal static int __PropertyOffset_bIKNoLerp;

		// Token: 0x040020F6 RID: 8438
		internal static int __PropertyOffset_ComprehensiveRotator;

		// Token: 0x040020F7 RID: 8439
		internal static int __PropertyOffset_BeHitStandardizedDirect;

		// Token: 0x040020F8 RID: 8440
		internal static int __PropertyOffset_BeHitSocketLocation;

		// Token: 0x040020F9 RID: 8441
		internal static int __PropertyOffset_SightLockAlpha;

		// Token: 0x040020FA RID: 8442
		internal static int __PropertyOffset_SightLockDirect;

		// Token: 0x040020FB RID: 8443
		internal static int __PropertyOffset_bInAimShotEnd;

		// Token: 0x040020FC RID: 8444
		internal static int __PropertyOffset_AimYawMix;

		// Token: 0x040020FD RID: 8445
		internal static int __PropertyOffset_FreezeCountDown;

		// Token: 0x040020FE RID: 8446
		internal static int __PropertyOffset_bStateStop;

		// Token: 0x040020FF RID: 8447
		internal static int __PropertyOffset_bStateSprintStop;

		// Token: 0x04002100 RID: 8448
		internal static int __PropertyOffset_bStateRunStop;

		// Token: 0x04002101 RID: 8449
		internal static int __PropertyOffset_bStateWalkStop;

		// Token: 0x04002102 RID: 8450
		internal static int __PropertyOffset_bStateGround;

		// Token: 0x04002103 RID: 8451
		internal static int __PropertyOffset_bStateStand;

		// Token: 0x04002104 RID: 8452
		internal static int __PropertyOffset_bStateGroundSprint;

		// Token: 0x04002105 RID: 8453
		internal static int __PropertyOffset_bStateGroundRun;

		// Token: 0x04002106 RID: 8454
		internal static int __PropertyOffset_bStateGroundWalk;

		// Token: 0x04002107 RID: 8455
		internal static int __PropertyOffset_bStateClimb;

		// Token: 0x04002108 RID: 8456
		internal static int __PropertyOffset_bStateAir;

		// Token: 0x04002109 RID: 8457
		internal static int __PropertyOffset_bStateSki;

		// Token: 0x0400210A RID: 8458
		internal static int __PropertyOffset_bStateNormalSki;

		// Token: 0x0400210B RID: 8459
		internal static int __PropertyOffset_bStateAirSlide;

		// Token: 0x0400210C RID: 8460
		internal static int __PropertyOffset_bStateAirGlide;

		// Token: 0x0400210D RID: 8461
		internal static int __PropertyOffset_bStateAirKite;

		// Token: 0x0400210E RID: 8462
		internal static int __PropertyOffset_bStateWater;

		// Token: 0x0400210F RID: 8463
		internal static int __PropertyOffset_bStateSkill;

		// Token: 0x04002110 RID: 8464
		internal static int __PropertyOffset_bStateLockDirection;

		// Token: 0x04002111 RID: 8465
		internal static int __PropertyOffset_bStateAimDirection;

		// Token: 0x04002112 RID: 8466
		internal static int __PropertyOffset_bStateFaceDirection;

		// Token: 0x04002113 RID: 8467
		internal static int __PropertyOffset_bStateBeHit;

		// Token: 0x04002114 RID: 8468
		internal static int __PropertyOffset_bStateHitPush;

		// Token: 0x04002115 RID: 8469
		internal static int __PropertyOffset_bStateBeHitFly;

		// Token: 0x04002116 RID: 8470
		internal static int __PropertyOffset_bStateDying;

		// Token: 0x04002117 RID: 8471
		internal static int __PropertyOffset_bStateDrown;

		// Token: 0x04002118 RID: 8472
		internal static int __PropertyOffset_bStateInBattle;

		// Token: 0x04002119 RID: 8473
		internal static int __PropertyOffset_bStateEnterBattle;

		// Token: 0x0400211A RID: 8474
		internal static int __PropertyOffset_bStateKeepSprint;

		// Token: 0x0400211B RID: 8475
		internal static int __PropertyOffset_bStateFastSwim;

		// Token: 0x0400211C RID: 8476
		internal static int __PropertyOffset_bStateSit;

		// Token: 0x0400211D RID: 8477
		internal static int __PropertyOffset_bStateXA;

		// Token: 0x0400211E RID: 8478
		internal static int __PropertyOffset_bStateAreaSportMode;

		// Token: 0x0400211F RID: 8479
		internal static int __PropertyOffset_bStateAreaSportModeKeep;

		// Token: 0x04002120 RID: 8480
		internal static int __PropertyOffset_bStateVehicleDriveMoto;

		// Token: 0x04002121 RID: 8481
		internal static int __PropertyOffset_bCharacterStateAreaSportMode;

		// Token: 0x04002122 RID: 8482
		internal static int __PropertyOffset_bStateOverlapBaseAnim;

		// Token: 0x04002123 RID: 8483
		internal static int __PropertyOffset_bUseAdditive;

		// Token: 0x04002124 RID: 8484
		internal static int __PropertyOffset_bUseOverlapLayerAdditive;

		// Token: 0x04002125 RID: 8485
		internal static int __PropertyOffset_bStateLowerRightTurnBlending;

		// Token: 0x04002126 RID: 8486
		internal static int __PropertyOffset_bStateLowerBlending;

		// Token: 0x04002127 RID: 8487
		internal static int __PropertyOffset_bStateWholeBodyBlend;

		// Token: 0x04002128 RID: 8488
		internal static int __PropertyOffset_bStateUseSpecialStateMachine;

		// Token: 0x04002129 RID: 8489
		internal static int __PropertyOffset_bStateFastBlend;

		// Token: 0x0400212A RID: 8490
		internal static int __PropertyOffset_bUseArmAdditive;

		// Token: 0x0400212B RID: 8491
		internal static int __PropertyOffset_bStateLeftArmBlend;

		// Token: 0x0400212C RID: 8492
		internal static int __PropertyOffset_bStateRightArmBlend;

		// Token: 0x0400212D RID: 8493
		internal static int __PropertyOffset_LowerBlendAlpha;

		// Token: 0x0400212E RID: 8494
		internal static int __PropertyOffset_bStateCast;

		// Token: 0x0400212F RID: 8495
		internal static int __PropertyOffset_bStateCastThrowing;

		// Token: 0x04002130 RID: 8496
		internal static int __PropertyOffset_bStateCastSelecting;

		// Token: 0x04002131 RID: 8497
		internal static int __PropertyOffset_bStateCastCasting;

		// Token: 0x04002132 RID: 8498
		internal static int __PropertyOffset_bStateMoveShot;

		// Token: 0x04002133 RID: 8499
		internal static int __PropertyOffset_bStateHoldShot;

		// Token: 0x04002134 RID: 8500
		internal static int __PropertyOffset_bStateAiming;

		// Token: 0x04002135 RID: 8501
		internal static int __PropertyOffset_bStateGeneralAiming;

		// Token: 0x04002136 RID: 8502
		internal static int __PropertyOffset_bStateShotNotify;

		// Token: 0x04002137 RID: 8503
		internal static int __PropertyOffset_bStateFixHook;

		// Token: 0x04002138 RID: 8504
		internal static int __PropertyOffset_bStateAirNormalShot;

		// Token: 0x04002139 RID: 8505
		internal static int __PropertyOffset_bStateAirNormalShotLeft;

		// Token: 0x0400213A RID: 8506
		internal static int __PropertyOffset_bStateAirNormalShotRight;

		// Token: 0x0400213B RID: 8507
		internal static int __PropertyOffset_bStateAirNormalShotFall;

		// Token: 0x0400213C RID: 8508
		internal static int __PropertyOffset_bStateBurst;

		// Token: 0x0400213D RID: 8509
		internal static int __PropertyOffset_bStateInBurst;

		// Token: 0x0400213E RID: 8510
		internal static int __PropertyOffset_bStateLimitForward;

		// Token: 0x0400213F RID: 8511
		internal static int __PropertyOffset_bStateLimitBackward;

		// Token: 0x04002140 RID: 8512
		internal static int __PropertyOffset_bLandRollWhenDying;

		// Token: 0x04002141 RID: 8513
		internal static int __PropertyOffset_bCaught;

		// Token: 0x04002142 RID: 8514
		internal static int __PropertyOffset_bRagDollQuit;

		// Token: 0x04002143 RID: 8515
		internal static int __PropertyOffset_bDisablePerformance;

		// Token: 0x04002144 RID: 8516
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04002145 RID: 8517
		internal static int __PropertyOffset_bEpresion;

		// Token: 0x04002146 RID: 8518
		internal static int __PropertyOffset_PerformanceCountDown;

		// Token: 0x04002147 RID: 8519
		internal static int __PropertyOffset_bPerformance;

		// Token: 0x04002148 RID: 8520
		internal static int __PropertyOffset_PerformanceIndex;

		// Token: 0x04002149 RID: 8521
		internal static int __PropertyOffset_bAllowPerformance;

		// Token: 0x0400214A RID: 8522
		internal static int __PropertyOffset_bAllowManualPerformance;

		// Token: 0x0400214B RID: 8523
		internal static int __PropertyOffset_AllowManualPerformanceIndex;

		// Token: 0x0400214C RID: 8524
		internal static int __PropertyOffset_bAllowManualPerformanceLoop;

		// Token: 0x0400214D RID: 8525
		internal static int __PropertyOffset_bAcceptNewSkill;

		// Token: 0x0400214E RID: 8526
		internal static int __PropertyOffset_bStageMotionSki;

		// Token: 0x0400214F RID: 8527
		internal static int __PropertyOffset_bHugeItemPull;

		// Token: 0x04002150 RID: 8528
		internal static int __PropertyOffset_bHugeItemPullAngle;

		// Token: 0x04002151 RID: 8529
		internal static int __PropertyOffset_SizeToCharHeightMap;

		// Token: 0x04002152 RID: 8530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _SizeToCharHeightMap;

		// Token: 0x04002153 RID: 8531
		internal static int __PropertyOffset_LandSpeedThresholds;

		// Token: 0x04002154 RID: 8532
		internal static int __PropertyOffset_SpeedMixLerp;

		// Token: 0x04002155 RID: 8533
		internal static int __PropertyOffset_GroundLeanLerp;

		// Token: 0x04002156 RID: 8534
		internal static int __PropertyOffset_AnimWalkSpeed;

		// Token: 0x04002157 RID: 8535
		internal static int __PropertyOffset_AnimRunSpeed;

		// Token: 0x04002158 RID: 8536
		internal static int __PropertyOffset_AnimSprintSpeed;

		// Token: 0x04002159 RID: 8537
		internal static int __PropertyOffset_AirLeanLerp;

		// Token: 0x0400215A RID: 8538
		internal static int __PropertyOffset_JumpMixLerp;

		// Token: 0x0400215B RID: 8539
		internal static int __PropertyOffset_SlideRotateLerp;

		// Token: 0x0400215C RID: 8540
		internal static int __PropertyOffset_SlideRotateLerp2;

		// Token: 0x0400215D RID: 8541
		internal static int __PropertyOffset_StandWalkStepCurve;

		// Token: 0x0400215E RID: 8542
		internal static int __PropertyOffset_StandRunStepCurve;

		// Token: 0x0400215F RID: 8543
		internal static int __PropertyOffset_ForecastLandCurve;

		// Token: 0x04002160 RID: 8544
		internal static int __PropertyOffset_RelativeSpeedBlendCurve;

		// Token: 0x04002161 RID: 8545
		internal static int __PropertyOffset_AirLeanCurve;

		// Token: 0x04002162 RID: 8546
		internal static int __PropertyOffset_AngelToStepLengthCurve;

		// Token: 0x04002163 RID: 8547
		internal static int __PropertyOffset_AngleToStepFrequencyCurve;

		// Token: 0x04002164 RID: 8548
		internal static int __PropertyOffset_FkMaterialControllerData;

		// Token: 0x04002165 RID: 8549
		internal static int __PropertyOffset_XAUDBlend;

		// Token: 0x04002166 RID: 8550
		internal static int __PropertyOffset_XARLBlend;

		// Token: 0x04002167 RID: 8551
		internal static int __PropertyOffset_bMovingPlatformMoving;

		// Token: 0x04002168 RID: 8552
		internal static int __PropertyOffset_MovingPlatIKAlpha;

		// Token: 0x04002169 RID: 8553
		internal static int __PropertyOffset_UphillLeanForward;

		// Token: 0x0400216A RID: 8554
		internal static int __PropertyOffset_UphillIKDiminish;

		// Token: 0x0400216B RID: 8555
		internal static int __PropertyOffset_bIsVehicleImpact;

		// Token: 0x0400216C RID: 8556
		internal static int __PropertyOffset_VehicleCollisionAlpha;

		// Token: 0x0400216D RID: 8557
		internal static int __PropertyOffset_VehicleCollisionAngle;

		// Token: 0x0400216E RID: 8558
		internal static int __PropertyOffset_VehicleCollisionStrength;

		// Token: 0x0400216F RID: 8559
		internal static int __PropertyOffset_VehicleCollisionMix;

		// Token: 0x04002170 RID: 8560
		internal static int __PropertyOffset_VehicleSeatRot;

		// Token: 0x04002171 RID: 8561
		internal static int __PropertyOffset_bIsGondolaClimbWaterfall;

		// Token: 0x04002172 RID: 8562
		internal static int __PropertyOffset_bIsSuddenStop;

		// Token: 0x04002173 RID: 8563
		internal static int __PropertyOffset_bIsSuddenMove;

		// Token: 0x04002174 RID: 8564
		internal static int __PropertyOffset_SuddenMoveCd;

		// Token: 0x04002175 RID: 8565
		internal static int __PropertyOffset_VehicleSuddenMoveMix;

		// Token: 0x04002176 RID: 8566
		internal static int __PropertyOffset_LastForwardSpeed;

		// Token: 0x04002177 RID: 8567
		internal static int __PropertyOffset_CurForwardSpeed;

		// Token: 0x04002178 RID: 8568
		internal static int __PropertyOffset_StartWalkBlendTime;

		// Token: 0x04002179 RID: 8569
		internal static int __PropertyOffset_StartRunBlendTime;
	}
}
