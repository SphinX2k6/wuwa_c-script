using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C8 RID: 4808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageType")]
	[UnrealStructLayout(2472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2472)]
	public abstract class UFoliageType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011970 RID: 72048 RVA: 0x0019CD4B File Offset: 0x0019AF4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageType._ClassPtr;
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x06011971 RID: 72049 RVA: 0x0019CD57 File Offset: 0x0019AF57
		// (set) Token: 0x06011972 RID: 72050 RVA: 0x0019CD6B File Offset: 0x0019AF6B
		public unsafe FGuid UpdateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_UpdateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_UpdateGuid) = value;
			}
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x06011973 RID: 72051 RVA: 0x0019CD80 File Offset: 0x0019AF80
		// (set) Token: 0x06011974 RID: 72052 RVA: 0x0019CD90 File Offset: 0x0019AF90
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x06011975 RID: 72053 RVA: 0x0019CDA1 File Offset: 0x0019AFA1
		// (set) Token: 0x06011976 RID: 72054 RVA: 0x0019CDB1 File Offset: 0x0019AFB1
		public unsafe float DensityAdjustmentFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityAdjustmentFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityAdjustmentFactor) = value;
			}
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x06011977 RID: 72055 RVA: 0x0019CDC2 File Offset: 0x0019AFC2
		// (set) Token: 0x06011978 RID: 72056 RVA: 0x0019CDD2 File Offset: 0x0019AFD2
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x06011979 RID: 72057 RVA: 0x0019CDE3 File Offset: 0x0019AFE3
		// (set) Token: 0x0601197A RID: 72058 RVA: 0x0019CDF3 File Offset: 0x0019AFF3
		public unsafe bool bSingleInstanceModeOverrideRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bSingleInstanceModeOverrideRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bSingleInstanceModeOverrideRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x0601197B RID: 72059 RVA: 0x0019CE04 File Offset: 0x0019B004
		// (set) Token: 0x0601197C RID: 72060 RVA: 0x0019CE14 File Offset: 0x0019B014
		public unsafe float SingleInstanceModeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SingleInstanceModeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SingleInstanceModeRadius) = value;
			}
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x0601197D RID: 72061 RVA: 0x0019CE25 File Offset: 0x0019B025
		// (set) Token: 0x0601197E RID: 72062 RVA: 0x0019CE35 File Offset: 0x0019B035
		public unsafe EFoliageScaling Scaling
		{
			get
			{
				return (EFoliageScaling)(*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Scaling));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Scaling) = (byte)value;
			}
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x0601197F RID: 72063 RVA: 0x0019CE46 File Offset: 0x0019B046
		// (set) Token: 0x06011980 RID: 72064 RVA: 0x0019CE5A File Offset: 0x0019B05A
		public unsafe FFloatInterval ScaleX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleX) = value;
			}
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x06011981 RID: 72065 RVA: 0x0019CE6F File Offset: 0x0019B06F
		// (set) Token: 0x06011982 RID: 72066 RVA: 0x0019CE83 File Offset: 0x0019B083
		public unsafe FFloatInterval ScaleY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleY) = value;
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x06011983 RID: 72067 RVA: 0x0019CE98 File Offset: 0x0019B098
		// (set) Token: 0x06011984 RID: 72068 RVA: 0x0019CEAC File Offset: 0x0019B0AC
		public unsafe FFloatInterval ScaleZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleZ) = value;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x06011985 RID: 72069 RVA: 0x0019CEC4 File Offset: 0x0019B0C4
		// (set) Token: 0x06011986 RID: 72070 RVA: 0x0019CEFE File Offset: 0x0019B0FE
		public TFixedArray<FFoliageVertexColorChannelMask> VertexColorMaskByChannel
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FFoliageVertexColorChannelMask> result;
				if ((result = this._VertexColorMaskByChannel) == null)
				{
					result = (this._VertexColorMaskByChannel = new TFixedArray<FFoliageVertexColorChannelMask>(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskByChannel, 4, this));
				}
				return result;
			}
			set
			{
				this.VertexColorMaskByChannel.CopyAssign(value);
			}
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x06011987 RID: 72071 RVA: 0x0019CF0C File Offset: 0x0019B10C
		// (set) Token: 0x06011988 RID: 72072 RVA: 0x0019CF20 File Offset: 0x0019B120
		[Nullable(0)]
		public unsafe TEnumAsByte<FoliageVertexColorMask> VertexColorMask_DEPRECATED
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMask_DEPRECATED);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMask_DEPRECATED) = value;
			}
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x06011989 RID: 72073 RVA: 0x0019CF35 File Offset: 0x0019B135
		// (set) Token: 0x0601198A RID: 72074 RVA: 0x0019CF45 File Offset: 0x0019B145
		public unsafe float VertexColorMaskThreshold_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskThreshold_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskThreshold_DEPRECATED) = value;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x0601198B RID: 72075 RVA: 0x0019CF56 File Offset: 0x0019B156
		// (set) Token: 0x0601198C RID: 72076 RVA: 0x0019CF6F File Offset: 0x0019B16F
		public unsafe bool VertexColorMaskInvert_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskInvert_DEPRECATED) & UFoliageType.__PropertyMask_VertexColorMaskInvert_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskInvert_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VertexColorMaskInvert_DEPRECATED) & ~UFoliageType.__PropertyMask_VertexColorMaskInvert_DEPRECATED) | (value ? UFoliageType.__PropertyMask_VertexColorMaskInvert_DEPRECATED : 0));
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x0601198D RID: 72077 RVA: 0x0019CF9F File Offset: 0x0019B19F
		// (set) Token: 0x0601198E RID: 72078 RVA: 0x0019CFB3 File Offset: 0x0019B1B3
		public unsafe FFloatInterval ZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ZOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ZOffset) = value;
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x0601198F RID: 72079 RVA: 0x0019CFC8 File Offset: 0x0019B1C8
		// (set) Token: 0x06011990 RID: 72080 RVA: 0x0019CFE1 File Offset: 0x0019B1E1
		public unsafe bool AlignToNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AlignToNormal) & UFoliageType.__PropertyMask_AlignToNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AlignToNormal) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AlignToNormal) & ~UFoliageType.__PropertyMask_AlignToNormal) | (value ? UFoliageType.__PropertyMask_AlignToNormal : 0));
			}
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x06011991 RID: 72081 RVA: 0x0019D011 File Offset: 0x0019B211
		// (set) Token: 0x06011992 RID: 72082 RVA: 0x0019D02A File Offset: 0x0019B22A
		public unsafe bool AverageNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormal) & UFoliageType.__PropertyMask_AverageNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormal) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormal) & ~UFoliageType.__PropertyMask_AverageNormal) | (value ? UFoliageType.__PropertyMask_AverageNormal : 0));
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x06011993 RID: 72083 RVA: 0x0019D05A File Offset: 0x0019B25A
		// (set) Token: 0x06011994 RID: 72084 RVA: 0x0019D073 File Offset: 0x0019B273
		public unsafe bool AverageNormalSingleComponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormalSingleComponent) & UFoliageType.__PropertyMask_AverageNormalSingleComponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormalSingleComponent) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormalSingleComponent) & ~UFoliageType.__PropertyMask_AverageNormalSingleComponent) | (value ? UFoliageType.__PropertyMask_AverageNormalSingleComponent : 0));
			}
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x06011995 RID: 72085 RVA: 0x0019D0A3 File Offset: 0x0019B2A3
		// (set) Token: 0x06011996 RID: 72086 RVA: 0x0019D0B3 File Offset: 0x0019B2B3
		public unsafe float AlignMaxAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AlignMaxAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AlignMaxAngle) = value;
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x06011997 RID: 72087 RVA: 0x0019D0C4 File Offset: 0x0019B2C4
		// (set) Token: 0x06011998 RID: 72088 RVA: 0x0019D0DD File Offset: 0x0019B2DD
		public unsafe bool RandomYaw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYaw) & UFoliageType.__PropertyMask_RandomYaw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYaw) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYaw) & ~UFoliageType.__PropertyMask_RandomYaw) | (value ? UFoliageType.__PropertyMask_RandomYaw : 0));
			}
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x06011999 RID: 72089 RVA: 0x0019D10D File Offset: 0x0019B30D
		// (set) Token: 0x0601199A RID: 72090 RVA: 0x0019D11D File Offset: 0x0019B31D
		public unsafe float RandomYawAngleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYawAngleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYawAngleMin) = value;
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x0601199B RID: 72091 RVA: 0x0019D12E File Offset: 0x0019B32E
		// (set) Token: 0x0601199C RID: 72092 RVA: 0x0019D13E File Offset: 0x0019B33E
		public unsafe float RandomYawAngleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYawAngleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomYawAngleMax) = value;
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x0601199D RID: 72093 RVA: 0x0019D14F File Offset: 0x0019B34F
		// (set) Token: 0x0601199E RID: 72094 RVA: 0x0019D15F File Offset: 0x0019B35F
		public unsafe float RandomPitchAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomPitchAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RandomPitchAngle) = value;
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x0601199F RID: 72095 RVA: 0x0019D170 File Offset: 0x0019B370
		// (set) Token: 0x060119A0 RID: 72096 RVA: 0x0019D184 File Offset: 0x0019B384
		public unsafe FFloatInterval GroundSlopeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_GroundSlopeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_GroundSlopeAngle) = value;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x060119A1 RID: 72097 RVA: 0x0019D199 File Offset: 0x0019B399
		// (set) Token: 0x060119A2 RID: 72098 RVA: 0x0019D1AD File Offset: 0x0019B3AD
		public unsafe FFloatInterval Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x060119A3 RID: 72099 RVA: 0x0019D1C4 File Offset: 0x0019B3C4
		// (set) Token: 0x060119A4 RID: 72100 RVA: 0x0019D1FD File Offset: 0x0019B3FD
		public TArray<FName> LandscapeLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._LandscapeLayers) == null)
				{
					result = (this._LandscapeLayers = new TArray<FName>(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LandscapeLayers, this));
				}
				return result;
			}
			set
			{
				this.LandscapeLayers.CopyAssign(value);
			}
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x060119A5 RID: 72101 RVA: 0x0019D20B File Offset: 0x0019B40B
		// (set) Token: 0x060119A6 RID: 72102 RVA: 0x0019D21B File Offset: 0x0019B41B
		public unsafe float MinimumLayerWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MinimumLayerWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MinimumLayerWeight) = value;
			}
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x060119A7 RID: 72103 RVA: 0x0019D22C File Offset: 0x0019B42C
		// (set) Token: 0x060119A8 RID: 72104 RVA: 0x0019D265 File Offset: 0x0019B465
		public TArray<FName> ExclusionLandscapeLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExclusionLandscapeLayers) == null)
				{
					result = (this._ExclusionLandscapeLayers = new TArray<FName>(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ExclusionLandscapeLayers, this));
				}
				return result;
			}
			set
			{
				this.ExclusionLandscapeLayers.CopyAssign(value);
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x060119A9 RID: 72105 RVA: 0x0019D273 File Offset: 0x0019B473
		// (set) Token: 0x060119AA RID: 72106 RVA: 0x0019D283 File Offset: 0x0019B483
		public unsafe float MinimumExclusionLayerWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MinimumExclusionLayerWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MinimumExclusionLayerWeight) = value;
			}
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x060119AB RID: 72107 RVA: 0x0019D294 File Offset: 0x0019B494
		// (set) Token: 0x060119AC RID: 72108 RVA: 0x0019D2A8 File Offset: 0x0019B4A8
		public unsafe FName LandscapeLayer_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LandscapeLayer_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LandscapeLayer_DEPRECATED) = value;
			}
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x060119AD RID: 72109 RVA: 0x0019D2BD File Offset: 0x0019B4BD
		// (set) Token: 0x060119AE RID: 72110 RVA: 0x0019D2D6 File Offset: 0x0019B4D6
		public unsafe bool CollisionWithWorld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionWithWorld) & UFoliageType.__PropertyMask_CollisionWithWorld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionWithWorld) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionWithWorld) & ~UFoliageType.__PropertyMask_CollisionWithWorld) | (value ? UFoliageType.__PropertyMask_CollisionWithWorld : 0));
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x060119AF RID: 72111 RVA: 0x0019D306 File Offset: 0x0019B506
		// (set) Token: 0x060119B0 RID: 72112 RVA: 0x0019D31A File Offset: 0x0019B51A
		public unsafe FVector CollisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionScale) = value;
			}
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x060119B1 RID: 72113 RVA: 0x0019D32F File Offset: 0x0019B52F
		// (set) Token: 0x060119B2 RID: 72114 RVA: 0x0019D33F File Offset: 0x0019B53F
		public unsafe int AverageNormalSampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormalSampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageNormalSampleCount) = value;
			}
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x060119B3 RID: 72115 RVA: 0x0019D350 File Offset: 0x0019B550
		// (set) Token: 0x060119B4 RID: 72116 RVA: 0x0019D364 File Offset: 0x0019B564
		public unsafe FBoxSphereBounds MeshBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MeshBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MeshBounds) = value;
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x060119B5 RID: 72117 RVA: 0x0019D379 File Offset: 0x0019B579
		// (set) Token: 0x060119B6 RID: 72118 RVA: 0x0019D38D File Offset: 0x0019B58D
		public unsafe FVector LowBoundOriginRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LowBoundOriginRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LowBoundOriginRadius) = value;
			}
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x060119B7 RID: 72119 RVA: 0x0019D3A2 File Offset: 0x0019B5A2
		// (set) Token: 0x060119B8 RID: 72120 RVA: 0x0019D3B6 File Offset: 0x0019B5B6
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentMobility> Mobility
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Mobility);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_Mobility) = value;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x060119B9 RID: 72121 RVA: 0x0019D3CB File Offset: 0x0019B5CB
		// (set) Token: 0x060119BA RID: 72122 RVA: 0x0019D3DB File Offset: 0x0019B5DB
		public unsafe EKuroISMCullingType KuroFoliageCullType
		{
			get
			{
				return (EKuroISMCullingType)(*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageCullType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageCullType) = (byte)value;
			}
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x060119BB RID: 72123 RVA: 0x0019D3EC File Offset: 0x0019B5EC
		// (set) Token: 0x060119BC RID: 72124 RVA: 0x0019D405 File Offset: 0x0019B605
		public unsafe bool bOverride_KuroFoliageSplitNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroFoliageSplitNode) & UFoliageType.__PropertyMask_bOverride_KuroFoliageSplitNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroFoliageSplitNode) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroFoliageSplitNode) & ~UFoliageType.__PropertyMask_bOverride_KuroFoliageSplitNode) | (value ? UFoliageType.__PropertyMask_bOverride_KuroFoliageSplitNode : 0));
			}
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x060119BD RID: 72125 RVA: 0x0019D435 File Offset: 0x0019B635
		// (set) Token: 0x060119BE RID: 72126 RVA: 0x0019D44E File Offset: 0x0019B64E
		public unsafe bool bOverride_KuroMinVertsToSplitNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroMinVertsToSplitNode) & UFoliageType.__PropertyMask_bOverride_KuroMinVertsToSplitNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroMinVertsToSplitNode) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverride_KuroMinVertsToSplitNode) & ~UFoliageType.__PropertyMask_bOverride_KuroMinVertsToSplitNode) | (value ? UFoliageType.__PropertyMask_bOverride_KuroMinVertsToSplitNode : 0));
			}
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x060119BF RID: 72127 RVA: 0x0019D47E File Offset: 0x0019B67E
		// (set) Token: 0x060119C0 RID: 72128 RVA: 0x0019D48E File Offset: 0x0019B68E
		public unsafe float KuroFoliageSplitFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageSplitFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageSplitFactor) = value;
			}
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x060119C1 RID: 72129 RVA: 0x0019D49F File Offset: 0x0019B69F
		// (set) Token: 0x060119C2 RID: 72130 RVA: 0x0019D4AF File Offset: 0x0019B6AF
		public unsafe float KuroMinVertsToSplitNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroMinVertsToSplitNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroMinVertsToSplitNode) = value;
			}
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x060119C3 RID: 72131 RVA: 0x0019D4C0 File Offset: 0x0019B6C0
		// (set) Token: 0x060119C4 RID: 72132 RVA: 0x0019D4D0 File Offset: 0x0019B6D0
		public unsafe int KuroFoliageForceShadowLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageForceShadowLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_KuroFoliageForceShadowLOD) = value;
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x060119C5 RID: 72133 RVA: 0x0019D4E1 File Offset: 0x0019B6E1
		// (set) Token: 0x060119C6 RID: 72134 RVA: 0x0019D4F5 File Offset: 0x0019B6F5
		public unsafe FInt32Interval CullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CullDistance) = value;
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x060119C7 RID: 72135 RVA: 0x0019D50C File Offset: 0x0019B70C
		// (set) Token: 0x060119C8 RID: 72136 RVA: 0x0019D545 File Offset: 0x0019B745
		public FPerPlatformFloat FoliageDensityLow
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityLow) == null)
				{
					result = (this._FoliageDensityLow = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityLow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x060119C9 RID: 72137 RVA: 0x0019D568 File Offset: 0x0019B768
		// (set) Token: 0x060119CA RID: 72138 RVA: 0x0019D5A1 File Offset: 0x0019B7A1
		public FPerPlatformFloat FoliageDensityMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityMiddle) == null)
				{
					result = (this._FoliageDensityMiddle = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityMiddle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x060119CB RID: 72139 RVA: 0x0019D5C4 File Offset: 0x0019B7C4
		// (set) Token: 0x060119CC RID: 72140 RVA: 0x0019D5FD File Offset: 0x0019B7FD
		public FPerPlatformFloat FoliageDensityHigh
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityHigh) == null)
				{
					result = (this._FoliageDensityHigh = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityHigh, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityHigh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x060119CD RID: 72141 RVA: 0x0019D620 File Offset: 0x0019B820
		// (set) Token: 0x060119CE RID: 72142 RVA: 0x0019D659 File Offset: 0x0019B859
		public FPerPlatformFloat FoliageDensityLowLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityLowLOD) == null)
				{
					result = (this._FoliageDensityLowLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityLowLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityLowLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x060119CF RID: 72143 RVA: 0x0019D67C File Offset: 0x0019B87C
		// (set) Token: 0x060119D0 RID: 72144 RVA: 0x0019D6B5 File Offset: 0x0019B8B5
		public FPerPlatformFloat FoliageDensityMiddleLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityMiddleLOD) == null)
				{
					result = (this._FoliageDensityMiddleLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityMiddleLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityMiddleLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x060119D1 RID: 72145 RVA: 0x0019D6D8 File Offset: 0x0019B8D8
		// (set) Token: 0x060119D2 RID: 72146 RVA: 0x0019D711 File Offset: 0x0019B911
		public FPerPlatformFloat FoliageDensityHighLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityHighLOD) == null)
				{
					result = (this._FoliageDensityHighLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityHighLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityHighLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x060119D3 RID: 72147 RVA: 0x0019D734 File Offset: 0x0019B934
		// (set) Token: 0x060119D4 RID: 72148 RVA: 0x0019D76D File Offset: 0x0019B96D
		public FPerPlatformFloat FoliageDensityScaleLODDistanceLow
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceLow) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceLow = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceLow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x060119D5 RID: 72149 RVA: 0x0019D790 File Offset: 0x0019B990
		// (set) Token: 0x060119D6 RID: 72150 RVA: 0x0019D7C9 File Offset: 0x0019B9C9
		public FPerPlatformFloat FoliageDensityScaleLODDistanceMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceMiddle) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceMiddle = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x060119D7 RID: 72151 RVA: 0x0019D7EC File Offset: 0x0019B9EC
		// (set) Token: 0x060119D8 RID: 72152 RVA: 0x0019D825 File Offset: 0x0019BA25
		public FPerPlatformFloat FoliageDensityScaleLODDistanceHigh
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceHigh) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceHigh = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x060119D9 RID: 72153 RVA: 0x0019D846 File Offset: 0x0019BA46
		// (set) Token: 0x060119DA RID: 72154 RVA: 0x0019D85F File Offset: 0x0019BA5F
		public unsafe bool bEnableStaticLighting_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableStaticLighting_DEPRECATED) & UFoliageType.__PropertyMask_bEnableStaticLighting_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableStaticLighting_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableStaticLighting_DEPRECATED) & ~UFoliageType.__PropertyMask_bEnableStaticLighting_DEPRECATED) | (value ? UFoliageType.__PropertyMask_bEnableStaticLighting_DEPRECATED : 0));
			}
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x060119DB RID: 72155 RVA: 0x0019D88F File Offset: 0x0019BA8F
		// (set) Token: 0x060119DC RID: 72156 RVA: 0x0019D8A8 File Offset: 0x0019BAA8
		public unsafe bool CastShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadow) & UFoliageType.__PropertyMask_CastShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadow) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadow) & ~UFoliageType.__PropertyMask_CastShadow) | (value ? UFoliageType.__PropertyMask_CastShadow : 0));
			}
		}

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x060119DD RID: 72157 RVA: 0x0019D8D8 File Offset: 0x0019BAD8
		// (set) Token: 0x060119DE RID: 72158 RVA: 0x0019D8F1 File Offset: 0x0019BAF1
		public unsafe bool bAffectDynamicIndirectLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDynamicIndirectLighting) & UFoliageType.__PropertyMask_bAffectDynamicIndirectLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDynamicIndirectLighting) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDynamicIndirectLighting) & ~UFoliageType.__PropertyMask_bAffectDynamicIndirectLighting) | (value ? UFoliageType.__PropertyMask_bAffectDynamicIndirectLighting : 0));
			}
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x060119DF RID: 72159 RVA: 0x0019D921 File Offset: 0x0019BB21
		// (set) Token: 0x060119E0 RID: 72160 RVA: 0x0019D93A File Offset: 0x0019BB3A
		public unsafe bool bAffectDistanceFieldLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDistanceFieldLighting) & UFoliageType.__PropertyMask_bAffectDistanceFieldLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDistanceFieldLighting) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bAffectDistanceFieldLighting) & ~UFoliageType.__PropertyMask_bAffectDistanceFieldLighting) | (value ? UFoliageType.__PropertyMask_bAffectDistanceFieldLighting : 0));
			}
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x060119E1 RID: 72161 RVA: 0x0019D96A File Offset: 0x0019BB6A
		// (set) Token: 0x060119E2 RID: 72162 RVA: 0x0019D983 File Offset: 0x0019BB83
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastDynamicShadow) & UFoliageType.__PropertyMask_bCastDynamicShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastDynamicShadow) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastDynamicShadow) & ~UFoliageType.__PropertyMask_bCastDynamicShadow) | (value ? UFoliageType.__PropertyMask_bCastDynamicShadow : 0));
			}
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x060119E3 RID: 72163 RVA: 0x0019D9B3 File Offset: 0x0019BBB3
		// (set) Token: 0x060119E4 RID: 72164 RVA: 0x0019D9CC File Offset: 0x0019BBCC
		public unsafe bool bCastStaticShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastStaticShadow) & UFoliageType.__PropertyMask_bCastStaticShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastStaticShadow) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastStaticShadow) & ~UFoliageType.__PropertyMask_bCastStaticShadow) | (value ? UFoliageType.__PropertyMask_bCastStaticShadow : 0));
			}
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x060119E5 RID: 72165 RVA: 0x0019D9FC File Offset: 0x0019BBFC
		// (set) Token: 0x060119E6 RID: 72166 RVA: 0x0019DA15 File Offset: 0x0019BC15
		public unsafe bool bCastContactShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastContactShadow) & UFoliageType.__PropertyMask_bCastContactShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastContactShadow) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastContactShadow) & ~UFoliageType.__PropertyMask_bCastContactShadow) | (value ? UFoliageType.__PropertyMask_bCastContactShadow : 0));
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x060119E7 RID: 72167 RVA: 0x0019DA45 File Offset: 0x0019BC45
		// (set) Token: 0x060119E8 RID: 72168 RVA: 0x0019DA5E File Offset: 0x0019BC5E
		public unsafe bool bCastShadowAsTwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastShadowAsTwoSided) & UFoliageType.__PropertyMask_bCastShadowAsTwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastShadowAsTwoSided) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCastShadowAsTwoSided) & ~UFoliageType.__PropertyMask_bCastShadowAsTwoSided) | (value ? UFoliageType.__PropertyMask_bCastShadowAsTwoSided : 0));
			}
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x060119E9 RID: 72169 RVA: 0x0019DA8E File Offset: 0x0019BC8E
		// (set) Token: 0x060119EA RID: 72170 RVA: 0x0019DAA7 File Offset: 0x0019BCA7
		public unsafe bool CastShadowInCinematicQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadowInCinematicQuality) & UFoliageType.__PropertyMask_CastShadowInCinematicQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadowInCinematicQuality) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CastShadowInCinematicQuality) & ~UFoliageType.__PropertyMask_CastShadowInCinematicQuality) | (value ? UFoliageType.__PropertyMask_CastShadowInCinematicQuality : 0));
			}
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x060119EB RID: 72171 RVA: 0x0019DAD7 File Offset: 0x0019BCD7
		// (set) Token: 0x060119EC RID: 72172 RVA: 0x0019DAF0 File Offset: 0x0019BCF0
		public unsafe bool bReceivesDecals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bReceivesDecals) & UFoliageType.__PropertyMask_bReceivesDecals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bReceivesDecals) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bReceivesDecals) & ~UFoliageType.__PropertyMask_bReceivesDecals) | (value ? UFoliageType.__PropertyMask_bReceivesDecals : 0));
			}
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x060119ED RID: 72173 RVA: 0x0019DB20 File Offset: 0x0019BD20
		// (set) Token: 0x060119EE RID: 72174 RVA: 0x0019DB39 File Offset: 0x0019BD39
		public unsafe bool bOverrideLightMapRes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverrideLightMapRes) & UFoliageType.__PropertyMask_bOverrideLightMapRes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverrideLightMapRes) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bOverrideLightMapRes) & ~UFoliageType.__PropertyMask_bOverrideLightMapRes) | (value ? UFoliageType.__PropertyMask_bOverrideLightMapRes : 0));
			}
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x060119EF RID: 72175 RVA: 0x0019DB69 File Offset: 0x0019BD69
		// (set) Token: 0x060119F0 RID: 72176 RVA: 0x0019DB79 File Offset: 0x0019BD79
		public unsafe int OverriddenLightMapRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_OverriddenLightMapRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_OverriddenLightMapRes) = value;
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x060119F1 RID: 72177 RVA: 0x0019DB8A File Offset: 0x0019BD8A
		// (set) Token: 0x060119F2 RID: 72178 RVA: 0x0019DB9A File Offset: 0x0019BD9A
		public unsafe ELightmapType LightmapType
		{
			get
			{
				return (ELightmapType)(*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LightmapType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LightmapType) = (byte)value;
			}
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x060119F3 RID: 72179 RVA: 0x0019DBAB File Offset: 0x0019BDAB
		// (set) Token: 0x060119F4 RID: 72180 RVA: 0x0019DBC4 File Offset: 0x0019BDC4
		public unsafe bool bUseAsOccluder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bUseAsOccluder) & UFoliageType.__PropertyMask_bUseAsOccluder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bUseAsOccluder) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bUseAsOccluder) & ~UFoliageType.__PropertyMask_bUseAsOccluder) | (value ? UFoliageType.__PropertyMask_bUseAsOccluder : 0));
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x060119F5 RID: 72181 RVA: 0x0019DBF4 File Offset: 0x0019BDF4
		// (set) Token: 0x060119F6 RID: 72182 RVA: 0x0019DC0D File Offset: 0x0019BE0D
		public unsafe bool bVisibleInRayTracing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bVisibleInRayTracing) & UFoliageType.__PropertyMask_bVisibleInRayTracing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bVisibleInRayTracing) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bVisibleInRayTracing) & ~UFoliageType.__PropertyMask_bVisibleInRayTracing) | (value ? UFoliageType.__PropertyMask_bVisibleInRayTracing : 0));
			}
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x060119F7 RID: 72183 RVA: 0x0019DC3D File Offset: 0x0019BE3D
		// (set) Token: 0x060119F8 RID: 72184 RVA: 0x0019DC56 File Offset: 0x0019BE56
		public unsafe bool bEvaluateWorldPositionOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEvaluateWorldPositionOffset) & UFoliageType.__PropertyMask_bEvaluateWorldPositionOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEvaluateWorldPositionOffset) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEvaluateWorldPositionOffset) & ~UFoliageType.__PropertyMask_bEvaluateWorldPositionOffset) | (value ? UFoliageType.__PropertyMask_bEvaluateWorldPositionOffset : 0));
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x060119F9 RID: 72185 RVA: 0x0019DC88 File Offset: 0x0019BE88
		// (set) Token: 0x060119FA RID: 72186 RVA: 0x0019DCC1 File Offset: 0x0019BEC1
		public FBodyInstance BodyInstance
		{
			get
			{
				base.FastCheckIsValid();
				FBodyInstance result;
				if ((result = this._BodyInstance) == null)
				{
					result = (this._BodyInstance = new FBodyInstance(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_BodyInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBodyInstance.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_BodyInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x060119FB RID: 72187 RVA: 0x0019DCE2 File Offset: 0x0019BEE2
		// (set) Token: 0x060119FC RID: 72188 RVA: 0x0019DCF6 File Offset: 0x0019BEF6
		[Nullable(0)]
		public unsafe TEnumAsByte<EHasCustomNavigableGeometry> CustomNavigableGeometry
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomNavigableGeometry);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomNavigableGeometry) = value;
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x060119FD RID: 72189 RVA: 0x0019DD0C File Offset: 0x0019BF0C
		// (set) Token: 0x060119FE RID: 72190 RVA: 0x0019DD45 File Offset: 0x0019BF45
		public FLightingChannels LightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LightingChannels, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x060119FF RID: 72191 RVA: 0x0019DD66 File Offset: 0x0019BF66
		// (set) Token: 0x06011A00 RID: 72192 RVA: 0x0019DD7F File Offset: 0x0019BF7F
		public unsafe bool bRenderCustomDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bRenderCustomDepth) & UFoliageType.__PropertyMask_bRenderCustomDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bRenderCustomDepth) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bRenderCustomDepth) & ~UFoliageType.__PropertyMask_bRenderCustomDepth) | (value ? UFoliageType.__PropertyMask_bRenderCustomDepth : 0));
			}
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x06011A01 RID: 72193 RVA: 0x0019DDAF File Offset: 0x0019BFAF
		// (set) Token: 0x06011A02 RID: 72194 RVA: 0x0019DDBF File Offset: 0x0019BFBF
		public unsafe ERendererStencilMask CustomDepthStencilWriteMask
		{
			get
			{
				return (ERendererStencilMask)(*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomDepthStencilWriteMask));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomDepthStencilWriteMask) = (byte)value;
			}
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x06011A03 RID: 72195 RVA: 0x0019DDD0 File Offset: 0x0019BFD0
		// (set) Token: 0x06011A04 RID: 72196 RVA: 0x0019DDE0 File Offset: 0x0019BFE0
		public unsafe int CustomDepthStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomDepthStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CustomDepthStencilValue) = value;
			}
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x06011A05 RID: 72197 RVA: 0x0019DDF1 File Offset: 0x0019BFF1
		// (set) Token: 0x06011A06 RID: 72198 RVA: 0x0019DE01 File Offset: 0x0019C001
		public unsafe int TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_TranslucencySortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_TranslucencySortPriority) = value;
			}
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x06011A07 RID: 72199 RVA: 0x0019DE12 File Offset: 0x0019C012
		// (set) Token: 0x06011A08 RID: 72200 RVA: 0x0019DE22 File Offset: 0x0019C022
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_CollisionRadius) = value;
			}
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x06011A09 RID: 72201 RVA: 0x0019DE33 File Offset: 0x0019C033
		// (set) Token: 0x06011A0A RID: 72202 RVA: 0x0019DE43 File Offset: 0x0019C043
		public unsafe float ShadeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ShadeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ShadeRadius) = value;
			}
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06011A0B RID: 72203 RVA: 0x0019DE54 File Offset: 0x0019C054
		// (set) Token: 0x06011A0C RID: 72204 RVA: 0x0019DE64 File Offset: 0x0019C064
		public unsafe int NumSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_NumSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_NumSteps) = value;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x06011A0D RID: 72205 RVA: 0x0019DE75 File Offset: 0x0019C075
		// (set) Token: 0x06011A0E RID: 72206 RVA: 0x0019DE85 File Offset: 0x0019C085
		public unsafe float InitialSeedDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_InitialSeedDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_InitialSeedDensity) = value;
			}
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x06011A0F RID: 72207 RVA: 0x0019DE96 File Offset: 0x0019C096
		// (set) Token: 0x06011A10 RID: 72208 RVA: 0x0019DEA6 File Offset: 0x0019C0A6
		public unsafe float AverageSpreadDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageSpreadDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_AverageSpreadDistance) = value;
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x06011A11 RID: 72209 RVA: 0x0019DEB7 File Offset: 0x0019C0B7
		// (set) Token: 0x06011A12 RID: 72210 RVA: 0x0019DEC7 File Offset: 0x0019C0C7
		public unsafe float SpreadVariance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SpreadVariance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SpreadVariance) = value;
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x06011A13 RID: 72211 RVA: 0x0019DED8 File Offset: 0x0019C0D8
		// (set) Token: 0x06011A14 RID: 72212 RVA: 0x0019DEE8 File Offset: 0x0019C0E8
		public unsafe int SeedsPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SeedsPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_SeedsPerStep) = value;
			}
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x06011A15 RID: 72213 RVA: 0x0019DEF9 File Offset: 0x0019C0F9
		// (set) Token: 0x06011A16 RID: 72214 RVA: 0x0019DF09 File Offset: 0x0019C109
		public unsafe int DistributionSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DistributionSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DistributionSeed) = value;
			}
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x06011A17 RID: 72215 RVA: 0x0019DF1A File Offset: 0x0019C11A
		// (set) Token: 0x06011A18 RID: 72216 RVA: 0x0019DF2A File Offset: 0x0019C12A
		public unsafe float MaxInitialSeedOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxInitialSeedOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxInitialSeedOffset) = value;
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x06011A19 RID: 72217 RVA: 0x0019DF3B File Offset: 0x0019C13B
		// (set) Token: 0x06011A1A RID: 72218 RVA: 0x0019DF4B File Offset: 0x0019C14B
		public unsafe bool bCanGrowInShade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCanGrowInShade) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bCanGrowInShade) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x06011A1B RID: 72219 RVA: 0x0019DF5C File Offset: 0x0019C15C
		// (set) Token: 0x06011A1C RID: 72220 RVA: 0x0019DF6C File Offset: 0x0019C16C
		public unsafe bool bSpawnsInShade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bSpawnsInShade) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bSpawnsInShade) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x06011A1D RID: 72221 RVA: 0x0019DF7D File Offset: 0x0019C17D
		// (set) Token: 0x06011A1E RID: 72222 RVA: 0x0019DF8D File Offset: 0x0019C18D
		public unsafe float MaxInitialAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxInitialAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxInitialAge) = value;
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x06011A1F RID: 72223 RVA: 0x0019DF9E File Offset: 0x0019C19E
		// (set) Token: 0x06011A20 RID: 72224 RVA: 0x0019DFAE File Offset: 0x0019C1AE
		public unsafe float MaxAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_MaxAge) = value;
			}
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x06011A21 RID: 72225 RVA: 0x0019DFBF File Offset: 0x0019C1BF
		// (set) Token: 0x06011A22 RID: 72226 RVA: 0x0019DFCF File Offset: 0x0019C1CF
		public unsafe float OverlapPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_OverlapPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_OverlapPriority) = value;
			}
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x06011A23 RID: 72227 RVA: 0x0019DFE0 File Offset: 0x0019C1E0
		// (set) Token: 0x06011A24 RID: 72228 RVA: 0x0019DFF4 File Offset: 0x0019C1F4
		public unsafe FFloatInterval ProceduralScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ProceduralScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ProceduralScale) = value;
			}
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x06011A25 RID: 72229 RVA: 0x0019E00C File Offset: 0x0019C20C
		// (set) Token: 0x06011A26 RID: 72230 RVA: 0x0019E045 File Offset: 0x0019C245
		public FRuntimeFloatCurve ScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._ScaleCurve) == null)
				{
					result = (this._ScaleCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x06011A27 RID: 72231 RVA: 0x0019E068 File Offset: 0x0019C268
		// (set) Token: 0x06011A28 RID: 72232 RVA: 0x0019E0A1 File Offset: 0x0019C2A1
		public FFoliageDensityFalloff DensityFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FFoliageDensityFalloff result;
				if ((result = this._DensityFalloff) == null)
				{
					result = (this._DensityFalloff = new FFoliageDensityFalloff(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityFalloff, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFoliageDensityFalloff.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityFalloff, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x06011A29 RID: 72233 RVA: 0x0019E0C2 File Offset: 0x0019C2C2
		// (set) Token: 0x06011A2A RID: 72234 RVA: 0x0019E0D2 File Offset: 0x0019C2D2
		public unsafe int ChangeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ChangeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ChangeCount) = value;
			}
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x06011A2B RID: 72235 RVA: 0x0019E0E3 File Offset: 0x0019C2E3
		// (set) Token: 0x06011A2C RID: 72236 RVA: 0x0019E0FC File Offset: 0x0019C2FC
		public unsafe bool ReapplyDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyDensity) & UFoliageType.__PropertyMask_ReapplyDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyDensity) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyDensity) & ~UFoliageType.__PropertyMask_ReapplyDensity) | (value ? UFoliageType.__PropertyMask_ReapplyDensity : 0));
			}
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x06011A2D RID: 72237 RVA: 0x0019E12C File Offset: 0x0019C32C
		// (set) Token: 0x06011A2E RID: 72238 RVA: 0x0019E145 File Offset: 0x0019C345
		public unsafe bool ReapplyRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRadius) & UFoliageType.__PropertyMask_ReapplyRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRadius) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRadius) & ~UFoliageType.__PropertyMask_ReapplyRadius) | (value ? UFoliageType.__PropertyMask_ReapplyRadius : 0));
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x06011A2F RID: 72239 RVA: 0x0019E175 File Offset: 0x0019C375
		// (set) Token: 0x06011A30 RID: 72240 RVA: 0x0019E18E File Offset: 0x0019C38E
		public unsafe bool ReapplyAlignToNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyAlignToNormal) & UFoliageType.__PropertyMask_ReapplyAlignToNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyAlignToNormal) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyAlignToNormal) & ~UFoliageType.__PropertyMask_ReapplyAlignToNormal) | (value ? UFoliageType.__PropertyMask_ReapplyAlignToNormal : 0));
			}
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x06011A31 RID: 72241 RVA: 0x0019E1BE File Offset: 0x0019C3BE
		// (set) Token: 0x06011A32 RID: 72242 RVA: 0x0019E1D7 File Offset: 0x0019C3D7
		public unsafe bool ReapplyRandomYaw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomYaw) & UFoliageType.__PropertyMask_ReapplyRandomYaw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomYaw) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomYaw) & ~UFoliageType.__PropertyMask_ReapplyRandomYaw) | (value ? UFoliageType.__PropertyMask_ReapplyRandomYaw : 0));
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x06011A33 RID: 72243 RVA: 0x0019E207 File Offset: 0x0019C407
		// (set) Token: 0x06011A34 RID: 72244 RVA: 0x0019E220 File Offset: 0x0019C420
		public unsafe bool ReapplyScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaling) & UFoliageType.__PropertyMask_ReapplyScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaling) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaling) & ~UFoliageType.__PropertyMask_ReapplyScaling) | (value ? UFoliageType.__PropertyMask_ReapplyScaling : 0));
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x06011A35 RID: 72245 RVA: 0x0019E250 File Offset: 0x0019C450
		// (set) Token: 0x06011A36 RID: 72246 RVA: 0x0019E269 File Offset: 0x0019C469
		public unsafe bool ReapplyScaleX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleX) & UFoliageType.__PropertyMask_ReapplyScaleX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleX) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleX) & ~UFoliageType.__PropertyMask_ReapplyScaleX) | (value ? UFoliageType.__PropertyMask_ReapplyScaleX : 0));
			}
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x06011A37 RID: 72247 RVA: 0x0019E299 File Offset: 0x0019C499
		// (set) Token: 0x06011A38 RID: 72248 RVA: 0x0019E2B2 File Offset: 0x0019C4B2
		public unsafe bool ReapplyScaleY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleY) & UFoliageType.__PropertyMask_ReapplyScaleY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleY) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleY) & ~UFoliageType.__PropertyMask_ReapplyScaleY) | (value ? UFoliageType.__PropertyMask_ReapplyScaleY : 0));
			}
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x06011A39 RID: 72249 RVA: 0x0019E2E2 File Offset: 0x0019C4E2
		// (set) Token: 0x06011A3A RID: 72250 RVA: 0x0019E2FB File Offset: 0x0019C4FB
		public unsafe bool ReapplyScaleZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleZ) & UFoliageType.__PropertyMask_ReapplyScaleZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleZ) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyScaleZ) & ~UFoliageType.__PropertyMask_ReapplyScaleZ) | (value ? UFoliageType.__PropertyMask_ReapplyScaleZ : 0));
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x06011A3B RID: 72251 RVA: 0x0019E32B File Offset: 0x0019C52B
		// (set) Token: 0x06011A3C RID: 72252 RVA: 0x0019E344 File Offset: 0x0019C544
		public unsafe bool ReapplyRandomPitchAngle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomPitchAngle) & UFoliageType.__PropertyMask_ReapplyRandomPitchAngle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomPitchAngle) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyRandomPitchAngle) & ~UFoliageType.__PropertyMask_ReapplyRandomPitchAngle) | (value ? UFoliageType.__PropertyMask_ReapplyRandomPitchAngle : 0));
			}
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x06011A3D RID: 72253 RVA: 0x0019E374 File Offset: 0x0019C574
		// (set) Token: 0x06011A3E RID: 72254 RVA: 0x0019E38D File Offset: 0x0019C58D
		public unsafe bool ReapplyGroundSlope
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyGroundSlope) & UFoliageType.__PropertyMask_ReapplyGroundSlope) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyGroundSlope) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyGroundSlope) & ~UFoliageType.__PropertyMask_ReapplyGroundSlope) | (value ? UFoliageType.__PropertyMask_ReapplyGroundSlope : 0));
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x06011A3F RID: 72255 RVA: 0x0019E3BD File Offset: 0x0019C5BD
		// (set) Token: 0x06011A40 RID: 72256 RVA: 0x0019E3D6 File Offset: 0x0019C5D6
		public unsafe bool ReapplyHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyHeight) & UFoliageType.__PropertyMask_ReapplyHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyHeight) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyHeight) & ~UFoliageType.__PropertyMask_ReapplyHeight) | (value ? UFoliageType.__PropertyMask_ReapplyHeight : 0));
			}
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x06011A41 RID: 72257 RVA: 0x0019E406 File Offset: 0x0019C606
		// (set) Token: 0x06011A42 RID: 72258 RVA: 0x0019E41F File Offset: 0x0019C61F
		public unsafe bool ReapplyLandscapeLayers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyLandscapeLayers) & UFoliageType.__PropertyMask_ReapplyLandscapeLayers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyLandscapeLayers) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyLandscapeLayers) & ~UFoliageType.__PropertyMask_ReapplyLandscapeLayers) | (value ? UFoliageType.__PropertyMask_ReapplyLandscapeLayers : 0));
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x06011A43 RID: 72259 RVA: 0x0019E44F File Offset: 0x0019C64F
		// (set) Token: 0x06011A44 RID: 72260 RVA: 0x0019E468 File Offset: 0x0019C668
		public unsafe bool ReapplyZOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyZOffset) & UFoliageType.__PropertyMask_ReapplyZOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyZOffset) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyZOffset) & ~UFoliageType.__PropertyMask_ReapplyZOffset) | (value ? UFoliageType.__PropertyMask_ReapplyZOffset : 0));
			}
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x06011A45 RID: 72261 RVA: 0x0019E498 File Offset: 0x0019C698
		// (set) Token: 0x06011A46 RID: 72262 RVA: 0x0019E4B1 File Offset: 0x0019C6B1
		public unsafe bool ReapplyCollisionWithWorld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyCollisionWithWorld) & UFoliageType.__PropertyMask_ReapplyCollisionWithWorld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyCollisionWithWorld) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyCollisionWithWorld) & ~UFoliageType.__PropertyMask_ReapplyCollisionWithWorld) | (value ? UFoliageType.__PropertyMask_ReapplyCollisionWithWorld : 0));
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x06011A47 RID: 72263 RVA: 0x0019E4E1 File Offset: 0x0019C6E1
		// (set) Token: 0x06011A48 RID: 72264 RVA: 0x0019E4FA File Offset: 0x0019C6FA
		public unsafe bool ReapplyVertexColorMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyVertexColorMask) & UFoliageType.__PropertyMask_ReapplyVertexColorMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyVertexColorMask) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_ReapplyVertexColorMask) & ~UFoliageType.__PropertyMask_ReapplyVertexColorMask) | (value ? UFoliageType.__PropertyMask_ReapplyVertexColorMask : 0));
			}
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x06011A49 RID: 72265 RVA: 0x0019E52A File Offset: 0x0019C72A
		// (set) Token: 0x06011A4A RID: 72266 RVA: 0x0019E543 File Offset: 0x0019C743
		public unsafe bool bEnableDensityScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScaling) & UFoliageType.__PropertyMask_bEnableDensityScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScaling) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScaling) & ~UFoliageType.__PropertyMask_bEnableDensityScaling) | (value ? UFoliageType.__PropertyMask_bEnableDensityScaling : 0));
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x06011A4B RID: 72267 RVA: 0x0019E573 File Offset: 0x0019C773
		// (set) Token: 0x06011A4C RID: 72268 RVA: 0x0019E58C File Offset: 0x0019C78C
		public unsafe bool bEnableDensityScalingLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScalingLOD) & UFoliageType.__PropertyMask_bEnableDensityScalingLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScalingLOD) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityScalingLOD) & ~UFoliageType.__PropertyMask_bEnableDensityScalingLOD) | (value ? UFoliageType.__PropertyMask_bEnableDensityScalingLOD : 0));
			}
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x06011A4D RID: 72269 RVA: 0x0019E5BC File Offset: 0x0019C7BC
		// (set) Token: 0x06011A4E RID: 72270 RVA: 0x0019E5D5 File Offset: 0x0019C7D5
		public unsafe bool bEnableDensityLODInstScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityLODInstScale) & UFoliageType.__PropertyMask_bEnableDensityLODInstScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityLODInstScale) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDensityLODInstScale) & ~UFoliageType.__PropertyMask_bEnableDensityLODInstScale) | (value ? UFoliageType.__PropertyMask_bEnableDensityLODInstScale : 0));
			}
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x06011A4F RID: 72271 RVA: 0x0019E608 File Offset: 0x0019C808
		// (set) Token: 0x06011A50 RID: 72272 RVA: 0x0019E641 File Offset: 0x0019C841
		public FPerPlatformFloat DensityLODInstScaleIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._DensityLODInstScaleIntensity) == null)
				{
					result = (this._DensityLODInstScaleIntensity = new FPerPlatformFloat(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityLODInstScaleIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_DensityLODInstScaleIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x06011A51 RID: 72273 RVA: 0x0019E662 File Offset: 0x0019C862
		// (set) Token: 0x06011A52 RID: 72274 RVA: 0x0019E67B File Offset: 0x0019C87B
		public unsafe bool bEnableDiscardOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDiscardOnLoad) & UFoliageType.__PropertyMask_bEnableDiscardOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDiscardOnLoad) = ((*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_bEnableDiscardOnLoad) & ~UFoliageType.__PropertyMask_bEnableDiscardOnLoad) | (value ? UFoliageType.__PropertyMask_bEnableDiscardOnLoad : 0));
			}
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x06011A53 RID: 72275 RVA: 0x0019E6AC File Offset: 0x0019C8AC
		// (set) Token: 0x06011A54 RID: 72276 RVA: 0x0019E6E5 File Offset: 0x0019C8E5
		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URuntimeVirtualTexture> result;
				if ((result = this._RuntimeVirtualTextures) == null)
				{
					result = (this._RuntimeVirtualTextures = new TArray<URuntimeVirtualTexture>(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_RuntimeVirtualTextures, this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextures.CopyAssign(value);
			}
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x06011A55 RID: 72277 RVA: 0x0019E6F3 File Offset: 0x0019C8F3
		// (set) Token: 0x06011A56 RID: 72278 RVA: 0x0019E703 File Offset: 0x0019C903
		public unsafe int VirtualTextureCullMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VirtualTextureCullMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VirtualTextureCullMips) = value;
			}
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x06011A57 RID: 72279 RVA: 0x0019E714 File Offset: 0x0019C914
		// (set) Token: 0x06011A58 RID: 72280 RVA: 0x0019E724 File Offset: 0x0019C924
		public unsafe ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
		{
			get
			{
				return (ERuntimeVirtualTextureMainPassType)(*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VirtualTextureRenderPassType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType.__PropertyOffset_VirtualTextureRenderPassType) = (byte)value;
			}
		}

		// Token: 0x06011A59 RID: 72281 RVA: 0x0019E735 File Offset: 0x0019C935
		static UFoliageType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageType");
		}

		// Token: 0x06011A5A RID: 72282 RVA: 0x0019E744 File Offset: 0x0019C944
		protected UFoliageType() : this(BuiltinUtils.AllocNativeUObject(UFoliageType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011A5B RID: 72283 RVA: 0x0019E76C File Offset: 0x0019C96C
		protected UFoliageType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040096C3 RID: 38595
		public new const string __ObjectPath = "/Script/Foliage.FoliageType";

		// Token: 0x040096C4 RID: 38596
		private static IntPtr _ClassPtr;

		// Token: 0x040096C5 RID: 38597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040096C6 RID: 38598
		internal static int __PropertyOffset_UpdateGuid;

		// Token: 0x040096C7 RID: 38599
		internal static int __PropertyOffset_Density;

		// Token: 0x040096C8 RID: 38600
		internal static int __PropertyOffset_DensityAdjustmentFactor;

		// Token: 0x040096C9 RID: 38601
		internal static int __PropertyOffset_Radius;

		// Token: 0x040096CA RID: 38602
		internal static int __PropertyOffset_bSingleInstanceModeOverrideRadius;

		// Token: 0x040096CB RID: 38603
		internal static int __PropertyOffset_SingleInstanceModeRadius;

		// Token: 0x040096CC RID: 38604
		internal static int __PropertyOffset_Scaling;

		// Token: 0x040096CD RID: 38605
		internal static int __PropertyOffset_ScaleX;

		// Token: 0x040096CE RID: 38606
		internal static int __PropertyOffset_ScaleY;

		// Token: 0x040096CF RID: 38607
		internal static int __PropertyOffset_ScaleZ;

		// Token: 0x040096D0 RID: 38608
		internal static int __PropertyOffset_VertexColorMaskByChannel;

		// Token: 0x040096D1 RID: 38609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FFoliageVertexColorChannelMask> _VertexColorMaskByChannel;

		// Token: 0x040096D2 RID: 38610
		internal static int __PropertyOffset_VertexColorMask_DEPRECATED;

		// Token: 0x040096D3 RID: 38611
		internal static int __PropertyOffset_VertexColorMaskThreshold_DEPRECATED;

		// Token: 0x040096D4 RID: 38612
		internal static int __PropertyOffset_VertexColorMaskInvert_DEPRECATED;

		// Token: 0x040096D5 RID: 38613
		internal static byte __PropertyMask_VertexColorMaskInvert_DEPRECATED;

		// Token: 0x040096D6 RID: 38614
		internal static int __PropertyOffset_ZOffset;

		// Token: 0x040096D7 RID: 38615
		internal static int __PropertyOffset_AlignToNormal;

		// Token: 0x040096D8 RID: 38616
		internal static byte __PropertyMask_AlignToNormal;

		// Token: 0x040096D9 RID: 38617
		internal static int __PropertyOffset_AverageNormal;

		// Token: 0x040096DA RID: 38618
		internal static byte __PropertyMask_AverageNormal;

		// Token: 0x040096DB RID: 38619
		internal static int __PropertyOffset_AverageNormalSingleComponent;

		// Token: 0x040096DC RID: 38620
		internal static byte __PropertyMask_AverageNormalSingleComponent;

		// Token: 0x040096DD RID: 38621
		internal static int __PropertyOffset_AlignMaxAngle;

		// Token: 0x040096DE RID: 38622
		internal static int __PropertyOffset_RandomYaw;

		// Token: 0x040096DF RID: 38623
		internal static byte __PropertyMask_RandomYaw;

		// Token: 0x040096E0 RID: 38624
		internal static int __PropertyOffset_RandomYawAngleMin;

		// Token: 0x040096E1 RID: 38625
		internal static int __PropertyOffset_RandomYawAngleMax;

		// Token: 0x040096E2 RID: 38626
		internal static int __PropertyOffset_RandomPitchAngle;

		// Token: 0x040096E3 RID: 38627
		internal static int __PropertyOffset_GroundSlopeAngle;

		// Token: 0x040096E4 RID: 38628
		internal static int __PropertyOffset_Height;

		// Token: 0x040096E5 RID: 38629
		internal static int __PropertyOffset_LandscapeLayers;

		// Token: 0x040096E6 RID: 38630
		[Nullable(2)]
		private TArray<FName> _LandscapeLayers;

		// Token: 0x040096E7 RID: 38631
		internal static int __PropertyOffset_MinimumLayerWeight;

		// Token: 0x040096E8 RID: 38632
		internal static int __PropertyOffset_ExclusionLandscapeLayers;

		// Token: 0x040096E9 RID: 38633
		[Nullable(2)]
		private TArray<FName> _ExclusionLandscapeLayers;

		// Token: 0x040096EA RID: 38634
		internal static int __PropertyOffset_MinimumExclusionLayerWeight;

		// Token: 0x040096EB RID: 38635
		internal static int __PropertyOffset_LandscapeLayer_DEPRECATED;

		// Token: 0x040096EC RID: 38636
		internal static int __PropertyOffset_CollisionWithWorld;

		// Token: 0x040096ED RID: 38637
		internal static byte __PropertyMask_CollisionWithWorld;

		// Token: 0x040096EE RID: 38638
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x040096EF RID: 38639
		internal static int __PropertyOffset_AverageNormalSampleCount;

		// Token: 0x040096F0 RID: 38640
		internal static int __PropertyOffset_MeshBounds;

		// Token: 0x040096F1 RID: 38641
		internal static int __PropertyOffset_LowBoundOriginRadius;

		// Token: 0x040096F2 RID: 38642
		internal static int __PropertyOffset_Mobility;

		// Token: 0x040096F3 RID: 38643
		internal static int __PropertyOffset_KuroFoliageCullType;

		// Token: 0x040096F4 RID: 38644
		internal static int __PropertyOffset_bOverride_KuroFoliageSplitNode;

		// Token: 0x040096F5 RID: 38645
		internal static byte __PropertyMask_bOverride_KuroFoliageSplitNode;

		// Token: 0x040096F6 RID: 38646
		internal static int __PropertyOffset_bOverride_KuroMinVertsToSplitNode;

		// Token: 0x040096F7 RID: 38647
		internal static byte __PropertyMask_bOverride_KuroMinVertsToSplitNode;

		// Token: 0x040096F8 RID: 38648
		internal static int __PropertyOffset_KuroFoliageSplitFactor;

		// Token: 0x040096F9 RID: 38649
		internal static int __PropertyOffset_KuroMinVertsToSplitNode;

		// Token: 0x040096FA RID: 38650
		internal static int __PropertyOffset_KuroFoliageForceShadowLOD;

		// Token: 0x040096FB RID: 38651
		internal static int __PropertyOffset_CullDistance;

		// Token: 0x040096FC RID: 38652
		internal static int __PropertyOffset_FoliageDensityLow;

		// Token: 0x040096FD RID: 38653
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityLow;

		// Token: 0x040096FE RID: 38654
		internal static int __PropertyOffset_FoliageDensityMiddle;

		// Token: 0x040096FF RID: 38655
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityMiddle;

		// Token: 0x04009700 RID: 38656
		internal static int __PropertyOffset_FoliageDensityHigh;

		// Token: 0x04009701 RID: 38657
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityHigh;

		// Token: 0x04009702 RID: 38658
		internal static int __PropertyOffset_FoliageDensityLowLOD;

		// Token: 0x04009703 RID: 38659
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityLowLOD;

		// Token: 0x04009704 RID: 38660
		internal static int __PropertyOffset_FoliageDensityMiddleLOD;

		// Token: 0x04009705 RID: 38661
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityMiddleLOD;

		// Token: 0x04009706 RID: 38662
		internal static int __PropertyOffset_FoliageDensityHighLOD;

		// Token: 0x04009707 RID: 38663
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityHighLOD;

		// Token: 0x04009708 RID: 38664
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceLow;

		// Token: 0x04009709 RID: 38665
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceLow;

		// Token: 0x0400970A RID: 38666
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400970B RID: 38667
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400970C RID: 38668
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceHigh;

		// Token: 0x0400970D RID: 38669
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceHigh;

		// Token: 0x0400970E RID: 38670
		internal static int __PropertyOffset_bEnableStaticLighting_DEPRECATED;

		// Token: 0x0400970F RID: 38671
		internal static byte __PropertyMask_bEnableStaticLighting_DEPRECATED;

		// Token: 0x04009710 RID: 38672
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x04009711 RID: 38673
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x04009712 RID: 38674
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x04009713 RID: 38675
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x04009714 RID: 38676
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x04009715 RID: 38677
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x04009716 RID: 38678
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x04009717 RID: 38679
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x04009718 RID: 38680
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x04009719 RID: 38681
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x0400971A RID: 38682
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x0400971B RID: 38683
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x0400971C RID: 38684
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x0400971D RID: 38685
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x0400971E RID: 38686
		internal static int __PropertyOffset_CastShadowInCinematicQuality;

		// Token: 0x0400971F RID: 38687
		internal static byte __PropertyMask_CastShadowInCinematicQuality;

		// Token: 0x04009720 RID: 38688
		internal static int __PropertyOffset_bReceivesDecals;

		// Token: 0x04009721 RID: 38689
		internal static byte __PropertyMask_bReceivesDecals;

		// Token: 0x04009722 RID: 38690
		internal static int __PropertyOffset_bOverrideLightMapRes;

		// Token: 0x04009723 RID: 38691
		internal static byte __PropertyMask_bOverrideLightMapRes;

		// Token: 0x04009724 RID: 38692
		internal static int __PropertyOffset_OverriddenLightMapRes;

		// Token: 0x04009725 RID: 38693
		internal static int __PropertyOffset_LightmapType;

		// Token: 0x04009726 RID: 38694
		internal static int __PropertyOffset_bUseAsOccluder;

		// Token: 0x04009727 RID: 38695
		internal static byte __PropertyMask_bUseAsOccluder;

		// Token: 0x04009728 RID: 38696
		internal static int __PropertyOffset_bVisibleInRayTracing;

		// Token: 0x04009729 RID: 38697
		internal static byte __PropertyMask_bVisibleInRayTracing;

		// Token: 0x0400972A RID: 38698
		internal static int __PropertyOffset_bEvaluateWorldPositionOffset;

		// Token: 0x0400972B RID: 38699
		internal static byte __PropertyMask_bEvaluateWorldPositionOffset;

		// Token: 0x0400972C RID: 38700
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x0400972D RID: 38701
		[Nullable(2)]
		private FBodyInstance _BodyInstance;

		// Token: 0x0400972E RID: 38702
		internal static int __PropertyOffset_CustomNavigableGeometry;

		// Token: 0x0400972F RID: 38703
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x04009730 RID: 38704
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x04009731 RID: 38705
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x04009732 RID: 38706
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x04009733 RID: 38707
		internal static int __PropertyOffset_CustomDepthStencilWriteMask;

		// Token: 0x04009734 RID: 38708
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x04009735 RID: 38709
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x04009736 RID: 38710
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x04009737 RID: 38711
		internal static int __PropertyOffset_ShadeRadius;

		// Token: 0x04009738 RID: 38712
		internal static int __PropertyOffset_NumSteps;

		// Token: 0x04009739 RID: 38713
		internal static int __PropertyOffset_InitialSeedDensity;

		// Token: 0x0400973A RID: 38714
		internal static int __PropertyOffset_AverageSpreadDistance;

		// Token: 0x0400973B RID: 38715
		internal static int __PropertyOffset_SpreadVariance;

		// Token: 0x0400973C RID: 38716
		internal static int __PropertyOffset_SeedsPerStep;

		// Token: 0x0400973D RID: 38717
		internal static int __PropertyOffset_DistributionSeed;

		// Token: 0x0400973E RID: 38718
		internal static int __PropertyOffset_MaxInitialSeedOffset;

		// Token: 0x0400973F RID: 38719
		internal static int __PropertyOffset_bCanGrowInShade;

		// Token: 0x04009740 RID: 38720
		internal static int __PropertyOffset_bSpawnsInShade;

		// Token: 0x04009741 RID: 38721
		internal static int __PropertyOffset_MaxInitialAge;

		// Token: 0x04009742 RID: 38722
		internal static int __PropertyOffset_MaxAge;

		// Token: 0x04009743 RID: 38723
		internal static int __PropertyOffset_OverlapPriority;

		// Token: 0x04009744 RID: 38724
		internal static int __PropertyOffset_ProceduralScale;

		// Token: 0x04009745 RID: 38725
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x04009746 RID: 38726
		[Nullable(2)]
		private FRuntimeFloatCurve _ScaleCurve;

		// Token: 0x04009747 RID: 38727
		internal static int __PropertyOffset_DensityFalloff;

		// Token: 0x04009748 RID: 38728
		[Nullable(2)]
		private FFoliageDensityFalloff _DensityFalloff;

		// Token: 0x04009749 RID: 38729
		internal static int __PropertyOffset_ChangeCount;

		// Token: 0x0400974A RID: 38730
		internal static int __PropertyOffset_ReapplyDensity;

		// Token: 0x0400974B RID: 38731
		internal static byte __PropertyMask_ReapplyDensity;

		// Token: 0x0400974C RID: 38732
		internal static int __PropertyOffset_ReapplyRadius;

		// Token: 0x0400974D RID: 38733
		internal static byte __PropertyMask_ReapplyRadius;

		// Token: 0x0400974E RID: 38734
		internal static int __PropertyOffset_ReapplyAlignToNormal;

		// Token: 0x0400974F RID: 38735
		internal static byte __PropertyMask_ReapplyAlignToNormal;

		// Token: 0x04009750 RID: 38736
		internal static int __PropertyOffset_ReapplyRandomYaw;

		// Token: 0x04009751 RID: 38737
		internal static byte __PropertyMask_ReapplyRandomYaw;

		// Token: 0x04009752 RID: 38738
		internal static int __PropertyOffset_ReapplyScaling;

		// Token: 0x04009753 RID: 38739
		internal static byte __PropertyMask_ReapplyScaling;

		// Token: 0x04009754 RID: 38740
		internal static int __PropertyOffset_ReapplyScaleX;

		// Token: 0x04009755 RID: 38741
		internal static byte __PropertyMask_ReapplyScaleX;

		// Token: 0x04009756 RID: 38742
		internal static int __PropertyOffset_ReapplyScaleY;

		// Token: 0x04009757 RID: 38743
		internal static byte __PropertyMask_ReapplyScaleY;

		// Token: 0x04009758 RID: 38744
		internal static int __PropertyOffset_ReapplyScaleZ;

		// Token: 0x04009759 RID: 38745
		internal static byte __PropertyMask_ReapplyScaleZ;

		// Token: 0x0400975A RID: 38746
		internal static int __PropertyOffset_ReapplyRandomPitchAngle;

		// Token: 0x0400975B RID: 38747
		internal static byte __PropertyMask_ReapplyRandomPitchAngle;

		// Token: 0x0400975C RID: 38748
		internal static int __PropertyOffset_ReapplyGroundSlope;

		// Token: 0x0400975D RID: 38749
		internal static byte __PropertyMask_ReapplyGroundSlope;

		// Token: 0x0400975E RID: 38750
		internal static int __PropertyOffset_ReapplyHeight;

		// Token: 0x0400975F RID: 38751
		internal static byte __PropertyMask_ReapplyHeight;

		// Token: 0x04009760 RID: 38752
		internal static int __PropertyOffset_ReapplyLandscapeLayers;

		// Token: 0x04009761 RID: 38753
		internal static byte __PropertyMask_ReapplyLandscapeLayers;

		// Token: 0x04009762 RID: 38754
		internal static int __PropertyOffset_ReapplyZOffset;

		// Token: 0x04009763 RID: 38755
		internal static byte __PropertyMask_ReapplyZOffset;

		// Token: 0x04009764 RID: 38756
		internal static int __PropertyOffset_ReapplyCollisionWithWorld;

		// Token: 0x04009765 RID: 38757
		internal static byte __PropertyMask_ReapplyCollisionWithWorld;

		// Token: 0x04009766 RID: 38758
		internal static int __PropertyOffset_ReapplyVertexColorMask;

		// Token: 0x04009767 RID: 38759
		internal static byte __PropertyMask_ReapplyVertexColorMask;

		// Token: 0x04009768 RID: 38760
		internal static int __PropertyOffset_bEnableDensityScaling;

		// Token: 0x04009769 RID: 38761
		internal static byte __PropertyMask_bEnableDensityScaling;

		// Token: 0x0400976A RID: 38762
		internal static int __PropertyOffset_bEnableDensityScalingLOD;

		// Token: 0x0400976B RID: 38763
		internal static byte __PropertyMask_bEnableDensityScalingLOD;

		// Token: 0x0400976C RID: 38764
		internal static int __PropertyOffset_bEnableDensityLODInstScale;

		// Token: 0x0400976D RID: 38765
		internal static byte __PropertyMask_bEnableDensityLODInstScale;

		// Token: 0x0400976E RID: 38766
		internal static int __PropertyOffset_DensityLODInstScaleIntensity;

		// Token: 0x0400976F RID: 38767
		[Nullable(2)]
		private FPerPlatformFloat _DensityLODInstScaleIntensity;

		// Token: 0x04009770 RID: 38768
		internal static int __PropertyOffset_bEnableDiscardOnLoad;

		// Token: 0x04009771 RID: 38769
		internal static byte __PropertyMask_bEnableDiscardOnLoad;

		// Token: 0x04009772 RID: 38770
		internal static int __PropertyOffset_RuntimeVirtualTextures;

		// Token: 0x04009773 RID: 38771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URuntimeVirtualTexture> _RuntimeVirtualTextures;

		// Token: 0x04009774 RID: 38772
		internal static int __PropertyOffset_VirtualTextureCullMips;

		// Token: 0x04009775 RID: 38773
		internal static int __PropertyOffset_VirtualTextureRenderPassType;
	}
}
