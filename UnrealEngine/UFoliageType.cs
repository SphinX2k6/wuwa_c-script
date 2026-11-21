using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B8 RID: 696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageType")]
	[UnrealStructLayout(2472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2472)]
	public abstract class UFoliageType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004B8E RID: 19342 RVA: 0x00069C69 File Offset: 0x00067E69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageType._ClassPtr;
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x00069C75 File Offset: 0x00067E75
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x00069C89 File Offset: 0x00067E89
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

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x00069C9E File Offset: 0x00067E9E
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x00069CAE File Offset: 0x00067EAE
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x00069CBF File Offset: 0x00067EBF
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x00069CCF File Offset: 0x00067ECF
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

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x00069CE0 File Offset: 0x00067EE0
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x00069CF0 File Offset: 0x00067EF0
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x00069D01 File Offset: 0x00067F01
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x00069D11 File Offset: 0x00067F11
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x00069D22 File Offset: 0x00067F22
		// (set) Token: 0x06004B9A RID: 19354 RVA: 0x00069D32 File Offset: 0x00067F32
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x00069D43 File Offset: 0x00067F43
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x00069D57 File Offset: 0x00067F57
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

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x00069D6C File Offset: 0x00067F6C
		// (set) Token: 0x06004B9E RID: 19358 RVA: 0x00069D80 File Offset: 0x00067F80
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

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x00069D95 File Offset: 0x00067F95
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x00069DA9 File Offset: 0x00067FA9
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x00069DBE File Offset: 0x00067FBE
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x00069DCE File Offset: 0x00067FCE
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x00069DDF File Offset: 0x00067FDF
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x00069DF8 File Offset: 0x00067FF8
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

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x00069E28 File Offset: 0x00068028
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x00069E3C File Offset: 0x0006803C
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x00069E51 File Offset: 0x00068051
		// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x00069E6A File Offset: 0x0006806A
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

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x00069E9A File Offset: 0x0006809A
		// (set) Token: 0x06004BAA RID: 19370 RVA: 0x00069EB3 File Offset: 0x000680B3
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

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06004BAB RID: 19371 RVA: 0x00069EE3 File Offset: 0x000680E3
		// (set) Token: 0x06004BAC RID: 19372 RVA: 0x00069EFC File Offset: 0x000680FC
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

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x00069F2C File Offset: 0x0006812C
		// (set) Token: 0x06004BAE RID: 19374 RVA: 0x00069F3C File Offset: 0x0006813C
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

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x00069F4D File Offset: 0x0006814D
		// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x00069F66 File Offset: 0x00068166
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x00069F96 File Offset: 0x00068196
		// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x00069FA6 File Offset: 0x000681A6
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

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x00069FB7 File Offset: 0x000681B7
		// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x00069FC7 File Offset: 0x000681C7
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x00069FD8 File Offset: 0x000681D8
		// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x00069FE8 File Offset: 0x000681E8
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

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x00069FF9 File Offset: 0x000681F9
		// (set) Token: 0x06004BB8 RID: 19384 RVA: 0x0006A00D File Offset: 0x0006820D
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

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x0006A022 File Offset: 0x00068222
		// (set) Token: 0x06004BBA RID: 19386 RVA: 0x0006A036 File Offset: 0x00068236
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

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06004BBB RID: 19387 RVA: 0x0006A04C File Offset: 0x0006824C
		// (set) Token: 0x06004BBC RID: 19388 RVA: 0x0006A085 File Offset: 0x00068285
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

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06004BBD RID: 19389 RVA: 0x0006A093 File Offset: 0x00068293
		// (set) Token: 0x06004BBE RID: 19390 RVA: 0x0006A0A3 File Offset: 0x000682A3
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

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x0006A0B4 File Offset: 0x000682B4
		// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x0006A0ED File Offset: 0x000682ED
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

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x0006A0FB File Offset: 0x000682FB
		// (set) Token: 0x06004BC2 RID: 19394 RVA: 0x0006A10B File Offset: 0x0006830B
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

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x0006A11C File Offset: 0x0006831C
		// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x0006A130 File Offset: 0x00068330
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

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x0006A145 File Offset: 0x00068345
		// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x0006A15E File Offset: 0x0006835E
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

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x0006A18E File Offset: 0x0006838E
		// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x0006A1A2 File Offset: 0x000683A2
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

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x0006A1B7 File Offset: 0x000683B7
		// (set) Token: 0x06004BCA RID: 19402 RVA: 0x0006A1C7 File Offset: 0x000683C7
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

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x0006A1D8 File Offset: 0x000683D8
		// (set) Token: 0x06004BCC RID: 19404 RVA: 0x0006A1EC File Offset: 0x000683EC
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

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x0006A201 File Offset: 0x00068401
		// (set) Token: 0x06004BCE RID: 19406 RVA: 0x0006A215 File Offset: 0x00068415
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

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x0006A22A File Offset: 0x0006842A
		// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x0006A23E File Offset: 0x0006843E
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

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x0006A253 File Offset: 0x00068453
		// (set) Token: 0x06004BD2 RID: 19410 RVA: 0x0006A26C File Offset: 0x0006846C
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

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0006A29C File Offset: 0x0006849C
		// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x0006A2B5 File Offset: 0x000684B5
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

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0006A2E5 File Offset: 0x000684E5
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x0006A2F5 File Offset: 0x000684F5
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

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0006A306 File Offset: 0x00068506
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x0006A316 File Offset: 0x00068516
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

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x0006A327 File Offset: 0x00068527
		// (set) Token: 0x06004BDA RID: 19418 RVA: 0x0006A337 File Offset: 0x00068537
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x0006A348 File Offset: 0x00068548
		// (set) Token: 0x06004BDC RID: 19420 RVA: 0x0006A35C File Offset: 0x0006855C
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

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x0006A371 File Offset: 0x00068571
		// (set) Token: 0x06004BDE RID: 19422 RVA: 0x0006A38A File Offset: 0x0006858A
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

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x0006A3BA File Offset: 0x000685BA
		// (set) Token: 0x06004BE0 RID: 19424 RVA: 0x0006A3D3 File Offset: 0x000685D3
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

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x0006A403 File Offset: 0x00068603
		// (set) Token: 0x06004BE2 RID: 19426 RVA: 0x0006A41C File Offset: 0x0006861C
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x0006A44C File Offset: 0x0006864C
		// (set) Token: 0x06004BE4 RID: 19428 RVA: 0x0006A465 File Offset: 0x00068665
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x0006A495 File Offset: 0x00068695
		// (set) Token: 0x06004BE6 RID: 19430 RVA: 0x0006A4AE File Offset: 0x000686AE
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

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x0006A4DE File Offset: 0x000686DE
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x0006A4F7 File Offset: 0x000686F7
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x0006A527 File Offset: 0x00068727
		// (set) Token: 0x06004BEA RID: 19434 RVA: 0x0006A540 File Offset: 0x00068740
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

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x0006A570 File Offset: 0x00068770
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x0006A589 File Offset: 0x00068789
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

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x0006A5B9 File Offset: 0x000687B9
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x0006A5D2 File Offset: 0x000687D2
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

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x0006A602 File Offset: 0x00068802
		// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x0006A61B File Offset: 0x0006881B
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

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0006A64B File Offset: 0x0006884B
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x0006A664 File Offset: 0x00068864
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

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0006A694 File Offset: 0x00068894
		// (set) Token: 0x06004BF4 RID: 19444 RVA: 0x0006A6A4 File Offset: 0x000688A4
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0006A6B5 File Offset: 0x000688B5
		// (set) Token: 0x06004BF6 RID: 19446 RVA: 0x0006A6CE File Offset: 0x000688CE
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x0006A6FE File Offset: 0x000688FE
		// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x0006A717 File Offset: 0x00068917
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

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x0006A747 File Offset: 0x00068947
		// (set) Token: 0x06004BFA RID: 19450 RVA: 0x0006A760 File Offset: 0x00068960
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

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x0006A790 File Offset: 0x00068990
		// (set) Token: 0x06004BFC RID: 19452 RVA: 0x0006A7C9 File Offset: 0x000689C9
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

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x0006A7EA File Offset: 0x000689EA
		// (set) Token: 0x06004BFE RID: 19454 RVA: 0x0006A803 File Offset: 0x00068A03
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

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x0006A833 File Offset: 0x00068A33
		// (set) Token: 0x06004C00 RID: 19456 RVA: 0x0006A843 File Offset: 0x00068A43
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0006A854 File Offset: 0x00068A54
		// (set) Token: 0x06004C02 RID: 19458 RVA: 0x0006A864 File Offset: 0x00068A64
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

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x0006A875 File Offset: 0x00068A75
		// (set) Token: 0x06004C04 RID: 19460 RVA: 0x0006A885 File Offset: 0x00068A85
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

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x0006A896 File Offset: 0x00068A96
		// (set) Token: 0x06004C06 RID: 19462 RVA: 0x0006A8A6 File Offset: 0x00068AA6
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

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x0006A8B7 File Offset: 0x00068AB7
		// (set) Token: 0x06004C08 RID: 19464 RVA: 0x0006A8C7 File Offset: 0x00068AC7
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

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x0006A8D8 File Offset: 0x00068AD8
		// (set) Token: 0x06004C0A RID: 19466 RVA: 0x0006A8E8 File Offset: 0x00068AE8
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

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x0006A8F9 File Offset: 0x00068AF9
		// (set) Token: 0x06004C0C RID: 19468 RVA: 0x0006A909 File Offset: 0x00068B09
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

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x0006A91A File Offset: 0x00068B1A
		// (set) Token: 0x06004C0E RID: 19470 RVA: 0x0006A92A File Offset: 0x00068B2A
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x0006A93B File Offset: 0x00068B3B
		// (set) Token: 0x06004C10 RID: 19472 RVA: 0x0006A94B File Offset: 0x00068B4B
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

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0006A95C File Offset: 0x00068B5C
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x0006A96C File Offset: 0x00068B6C
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0006A97D File Offset: 0x00068B7D
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x0006A98D File Offset: 0x00068B8D
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

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0006A99E File Offset: 0x00068B9E
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x0006A9AE File Offset: 0x00068BAE
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

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0006A9BF File Offset: 0x00068BBF
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x0006A9CF File Offset: 0x00068BCF
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

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0006A9E0 File Offset: 0x00068BE0
		// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0006A9F0 File Offset: 0x00068BF0
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0006AA01 File Offset: 0x00068C01
		// (set) Token: 0x06004C1C RID: 19484 RVA: 0x0006AA11 File Offset: 0x00068C11
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

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x0006AA22 File Offset: 0x00068C22
		// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0006AA32 File Offset: 0x00068C32
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

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x0006AA43 File Offset: 0x00068C43
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x0006AA57 File Offset: 0x00068C57
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0006AA6C File Offset: 0x00068C6C
		// (set) Token: 0x06004C22 RID: 19490 RVA: 0x0006AA7C File Offset: 0x00068C7C
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

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x0006AA8D File Offset: 0x00068C8D
		// (set) Token: 0x06004C24 RID: 19492 RVA: 0x0006AAA6 File Offset: 0x00068CA6
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

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x0006AAD6 File Offset: 0x00068CD6
		// (set) Token: 0x06004C26 RID: 19494 RVA: 0x0006AAEF File Offset: 0x00068CEF
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

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x0006AB1F File Offset: 0x00068D1F
		// (set) Token: 0x06004C28 RID: 19496 RVA: 0x0006AB38 File Offset: 0x00068D38
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

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06004C29 RID: 19497 RVA: 0x0006AB68 File Offset: 0x00068D68
		// (set) Token: 0x06004C2A RID: 19498 RVA: 0x0006AB81 File Offset: 0x00068D81
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

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x0006ABB1 File Offset: 0x00068DB1
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x0006ABCA File Offset: 0x00068DCA
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

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x0006ABFA File Offset: 0x00068DFA
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x0006AC13 File Offset: 0x00068E13
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

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0006AC43 File Offset: 0x00068E43
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x0006AC5C File Offset: 0x00068E5C
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

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x0006AC8C File Offset: 0x00068E8C
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x0006ACA5 File Offset: 0x00068EA5
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

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x0006ACD5 File Offset: 0x00068ED5
		// (set) Token: 0x06004C34 RID: 19508 RVA: 0x0006ACEE File Offset: 0x00068EEE
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

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06004C35 RID: 19509 RVA: 0x0006AD1E File Offset: 0x00068F1E
		// (set) Token: 0x06004C36 RID: 19510 RVA: 0x0006AD37 File Offset: 0x00068F37
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

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06004C37 RID: 19511 RVA: 0x0006AD67 File Offset: 0x00068F67
		// (set) Token: 0x06004C38 RID: 19512 RVA: 0x0006AD80 File Offset: 0x00068F80
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x0006ADB0 File Offset: 0x00068FB0
		// (set) Token: 0x06004C3A RID: 19514 RVA: 0x0006ADC9 File Offset: 0x00068FC9
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

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x0006ADF9 File Offset: 0x00068FF9
		// (set) Token: 0x06004C3C RID: 19516 RVA: 0x0006AE12 File Offset: 0x00069012
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

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x0006AE42 File Offset: 0x00069042
		// (set) Token: 0x06004C3E RID: 19518 RVA: 0x0006AE5B File Offset: 0x0006905B
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

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x0006AE8B File Offset: 0x0006908B
		// (set) Token: 0x06004C40 RID: 19520 RVA: 0x0006AEA4 File Offset: 0x000690A4
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

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x0006AED4 File Offset: 0x000690D4
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x0006AEED File Offset: 0x000690ED
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x0006AF1D File Offset: 0x0006911D
		// (set) Token: 0x06004C44 RID: 19524 RVA: 0x0006AF36 File Offset: 0x00069136
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

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06004C45 RID: 19525 RVA: 0x0006AF66 File Offset: 0x00069166
		// (set) Token: 0x06004C46 RID: 19526 RVA: 0x0006AF7F File Offset: 0x0006917F
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

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x0006AFAF File Offset: 0x000691AF
		// (set) Token: 0x06004C48 RID: 19528 RVA: 0x0006AFC8 File Offset: 0x000691C8
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

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x0006AFF8 File Offset: 0x000691F8
		// (set) Token: 0x06004C4A RID: 19530 RVA: 0x0006B008 File Offset: 0x00069208
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

		// Token: 0x06004C4B RID: 19531 RVA: 0x0006B019 File Offset: 0x00069219
		static UFoliageType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageType");
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x0006B028 File Offset: 0x00069228
		protected UFoliageType() : this(BuiltinUtils.AllocNativeUObject(UFoliageType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x0006B050 File Offset: 0x00069250
		protected UFoliageType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DF5 RID: 7669
		public new const string __ObjectPath = "/Script/Foliage.FoliageType";

		// Token: 0x04001DF6 RID: 7670
		private static IntPtr _ClassPtr;

		// Token: 0x04001DF7 RID: 7671
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001DF8 RID: 7672
		internal static int __PropertyOffset_UpdateGuid;

		// Token: 0x04001DF9 RID: 7673
		internal static int __PropertyOffset_Density;

		// Token: 0x04001DFA RID: 7674
		internal static int __PropertyOffset_DensityAdjustmentFactor;

		// Token: 0x04001DFB RID: 7675
		internal static int __PropertyOffset_Radius;

		// Token: 0x04001DFC RID: 7676
		internal static int __PropertyOffset_bSingleInstanceModeOverrideRadius;

		// Token: 0x04001DFD RID: 7677
		internal static int __PropertyOffset_SingleInstanceModeRadius;

		// Token: 0x04001DFE RID: 7678
		internal static int __PropertyOffset_ScaleX;

		// Token: 0x04001DFF RID: 7679
		internal static int __PropertyOffset_ScaleY;

		// Token: 0x04001E00 RID: 7680
		internal static int __PropertyOffset_ScaleZ;

		// Token: 0x04001E01 RID: 7681
		internal static int __PropertyOffset_VertexColorMaskThreshold_DEPRECATED;

		// Token: 0x04001E02 RID: 7682
		internal static int __PropertyOffset_VertexColorMaskInvert_DEPRECATED;

		// Token: 0x04001E03 RID: 7683
		internal static byte __PropertyMask_VertexColorMaskInvert_DEPRECATED;

		// Token: 0x04001E04 RID: 7684
		internal static int __PropertyOffset_ZOffset;

		// Token: 0x04001E05 RID: 7685
		internal static int __PropertyOffset_AlignToNormal;

		// Token: 0x04001E06 RID: 7686
		internal static byte __PropertyMask_AlignToNormal;

		// Token: 0x04001E07 RID: 7687
		internal static int __PropertyOffset_AverageNormal;

		// Token: 0x04001E08 RID: 7688
		internal static byte __PropertyMask_AverageNormal;

		// Token: 0x04001E09 RID: 7689
		internal static int __PropertyOffset_AverageNormalSingleComponent;

		// Token: 0x04001E0A RID: 7690
		internal static byte __PropertyMask_AverageNormalSingleComponent;

		// Token: 0x04001E0B RID: 7691
		internal static int __PropertyOffset_AlignMaxAngle;

		// Token: 0x04001E0C RID: 7692
		internal static int __PropertyOffset_RandomYaw;

		// Token: 0x04001E0D RID: 7693
		internal static byte __PropertyMask_RandomYaw;

		// Token: 0x04001E0E RID: 7694
		internal static int __PropertyOffset_RandomYawAngleMin;

		// Token: 0x04001E0F RID: 7695
		internal static int __PropertyOffset_RandomYawAngleMax;

		// Token: 0x04001E10 RID: 7696
		internal static int __PropertyOffset_RandomPitchAngle;

		// Token: 0x04001E11 RID: 7697
		internal static int __PropertyOffset_GroundSlopeAngle;

		// Token: 0x04001E12 RID: 7698
		internal static int __PropertyOffset_Height;

		// Token: 0x04001E13 RID: 7699
		internal static int __PropertyOffset_LandscapeLayers;

		// Token: 0x04001E14 RID: 7700
		[Nullable(2)]
		private TArray<FName> _LandscapeLayers;

		// Token: 0x04001E15 RID: 7701
		internal static int __PropertyOffset_MinimumLayerWeight;

		// Token: 0x04001E16 RID: 7702
		internal static int __PropertyOffset_ExclusionLandscapeLayers;

		// Token: 0x04001E17 RID: 7703
		[Nullable(2)]
		private TArray<FName> _ExclusionLandscapeLayers;

		// Token: 0x04001E18 RID: 7704
		internal static int __PropertyOffset_MinimumExclusionLayerWeight;

		// Token: 0x04001E19 RID: 7705
		internal static int __PropertyOffset_LandscapeLayer_DEPRECATED;

		// Token: 0x04001E1A RID: 7706
		internal static int __PropertyOffset_CollisionWithWorld;

		// Token: 0x04001E1B RID: 7707
		internal static byte __PropertyMask_CollisionWithWorld;

		// Token: 0x04001E1C RID: 7708
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x04001E1D RID: 7709
		internal static int __PropertyOffset_AverageNormalSampleCount;

		// Token: 0x04001E1E RID: 7710
		internal static int __PropertyOffset_MeshBounds;

		// Token: 0x04001E1F RID: 7711
		internal static int __PropertyOffset_LowBoundOriginRadius;

		// Token: 0x04001E20 RID: 7712
		internal static int __PropertyOffset_Mobility;

		// Token: 0x04001E21 RID: 7713
		internal static int __PropertyOffset_bOverride_KuroFoliageSplitNode;

		// Token: 0x04001E22 RID: 7714
		internal static byte __PropertyMask_bOverride_KuroFoliageSplitNode;

		// Token: 0x04001E23 RID: 7715
		internal static int __PropertyOffset_bOverride_KuroMinVertsToSplitNode;

		// Token: 0x04001E24 RID: 7716
		internal static byte __PropertyMask_bOverride_KuroMinVertsToSplitNode;

		// Token: 0x04001E25 RID: 7717
		internal static int __PropertyOffset_KuroFoliageSplitFactor;

		// Token: 0x04001E26 RID: 7718
		internal static int __PropertyOffset_KuroMinVertsToSplitNode;

		// Token: 0x04001E27 RID: 7719
		internal static int __PropertyOffset_KuroFoliageForceShadowLOD;

		// Token: 0x04001E28 RID: 7720
		internal static int __PropertyOffset_CullDistance;

		// Token: 0x04001E29 RID: 7721
		internal static int __PropertyOffset_bEnableStaticLighting_DEPRECATED;

		// Token: 0x04001E2A RID: 7722
		internal static byte __PropertyMask_bEnableStaticLighting_DEPRECATED;

		// Token: 0x04001E2B RID: 7723
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x04001E2C RID: 7724
		internal static byte __PropertyMask_CastShadow;

		// Token: 0x04001E2D RID: 7725
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x04001E2E RID: 7726
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x04001E2F RID: 7727
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x04001E30 RID: 7728
		internal static byte __PropertyMask_bAffectDistanceFieldLighting;

		// Token: 0x04001E31 RID: 7729
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x04001E32 RID: 7730
		internal static byte __PropertyMask_bCastDynamicShadow;

		// Token: 0x04001E33 RID: 7731
		internal static int __PropertyOffset_bCastStaticShadow;

		// Token: 0x04001E34 RID: 7732
		internal static byte __PropertyMask_bCastStaticShadow;

		// Token: 0x04001E35 RID: 7733
		internal static int __PropertyOffset_bCastContactShadow;

		// Token: 0x04001E36 RID: 7734
		internal static byte __PropertyMask_bCastContactShadow;

		// Token: 0x04001E37 RID: 7735
		internal static int __PropertyOffset_bCastShadowAsTwoSided;

		// Token: 0x04001E38 RID: 7736
		internal static byte __PropertyMask_bCastShadowAsTwoSided;

		// Token: 0x04001E39 RID: 7737
		internal static int __PropertyOffset_CastShadowInCinematicQuality;

		// Token: 0x04001E3A RID: 7738
		internal static byte __PropertyMask_CastShadowInCinematicQuality;

		// Token: 0x04001E3B RID: 7739
		internal static int __PropertyOffset_bReceivesDecals;

		// Token: 0x04001E3C RID: 7740
		internal static byte __PropertyMask_bReceivesDecals;

		// Token: 0x04001E3D RID: 7741
		internal static int __PropertyOffset_bOverrideLightMapRes;

		// Token: 0x04001E3E RID: 7742
		internal static byte __PropertyMask_bOverrideLightMapRes;

		// Token: 0x04001E3F RID: 7743
		internal static int __PropertyOffset_OverriddenLightMapRes;

		// Token: 0x04001E40 RID: 7744
		internal static int __PropertyOffset_bUseAsOccluder;

		// Token: 0x04001E41 RID: 7745
		internal static byte __PropertyMask_bUseAsOccluder;

		// Token: 0x04001E42 RID: 7746
		internal static int __PropertyOffset_bVisibleInRayTracing;

		// Token: 0x04001E43 RID: 7747
		internal static byte __PropertyMask_bVisibleInRayTracing;

		// Token: 0x04001E44 RID: 7748
		internal static int __PropertyOffset_bEvaluateWorldPositionOffset;

		// Token: 0x04001E45 RID: 7749
		internal static byte __PropertyMask_bEvaluateWorldPositionOffset;

		// Token: 0x04001E46 RID: 7750
		internal static int __PropertyOffset_BodyInstance;

		// Token: 0x04001E47 RID: 7751
		[Nullable(2)]
		private FBodyInstance _BodyInstance;

		// Token: 0x04001E48 RID: 7752
		internal static int __PropertyOffset_bRenderCustomDepth;

		// Token: 0x04001E49 RID: 7753
		internal static byte __PropertyMask_bRenderCustomDepth;

		// Token: 0x04001E4A RID: 7754
		internal static int __PropertyOffset_CustomDepthStencilValue;

		// Token: 0x04001E4B RID: 7755
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x04001E4C RID: 7756
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x04001E4D RID: 7757
		internal static int __PropertyOffset_ShadeRadius;

		// Token: 0x04001E4E RID: 7758
		internal static int __PropertyOffset_NumSteps;

		// Token: 0x04001E4F RID: 7759
		internal static int __PropertyOffset_InitialSeedDensity;

		// Token: 0x04001E50 RID: 7760
		internal static int __PropertyOffset_AverageSpreadDistance;

		// Token: 0x04001E51 RID: 7761
		internal static int __PropertyOffset_SpreadVariance;

		// Token: 0x04001E52 RID: 7762
		internal static int __PropertyOffset_SeedsPerStep;

		// Token: 0x04001E53 RID: 7763
		internal static int __PropertyOffset_DistributionSeed;

		// Token: 0x04001E54 RID: 7764
		internal static int __PropertyOffset_MaxInitialSeedOffset;

		// Token: 0x04001E55 RID: 7765
		internal static int __PropertyOffset_bCanGrowInShade;

		// Token: 0x04001E56 RID: 7766
		internal static int __PropertyOffset_bSpawnsInShade;

		// Token: 0x04001E57 RID: 7767
		internal static int __PropertyOffset_MaxInitialAge;

		// Token: 0x04001E58 RID: 7768
		internal static int __PropertyOffset_MaxAge;

		// Token: 0x04001E59 RID: 7769
		internal static int __PropertyOffset_OverlapPriority;

		// Token: 0x04001E5A RID: 7770
		internal static int __PropertyOffset_ProceduralScale;

		// Token: 0x04001E5B RID: 7771
		internal static int __PropertyOffset_ChangeCount;

		// Token: 0x04001E5C RID: 7772
		internal static int __PropertyOffset_ReapplyDensity;

		// Token: 0x04001E5D RID: 7773
		internal static byte __PropertyMask_ReapplyDensity;

		// Token: 0x04001E5E RID: 7774
		internal static int __PropertyOffset_ReapplyRadius;

		// Token: 0x04001E5F RID: 7775
		internal static byte __PropertyMask_ReapplyRadius;

		// Token: 0x04001E60 RID: 7776
		internal static int __PropertyOffset_ReapplyAlignToNormal;

		// Token: 0x04001E61 RID: 7777
		internal static byte __PropertyMask_ReapplyAlignToNormal;

		// Token: 0x04001E62 RID: 7778
		internal static int __PropertyOffset_ReapplyRandomYaw;

		// Token: 0x04001E63 RID: 7779
		internal static byte __PropertyMask_ReapplyRandomYaw;

		// Token: 0x04001E64 RID: 7780
		internal static int __PropertyOffset_ReapplyScaling;

		// Token: 0x04001E65 RID: 7781
		internal static byte __PropertyMask_ReapplyScaling;

		// Token: 0x04001E66 RID: 7782
		internal static int __PropertyOffset_ReapplyScaleX;

		// Token: 0x04001E67 RID: 7783
		internal static byte __PropertyMask_ReapplyScaleX;

		// Token: 0x04001E68 RID: 7784
		internal static int __PropertyOffset_ReapplyScaleY;

		// Token: 0x04001E69 RID: 7785
		internal static byte __PropertyMask_ReapplyScaleY;

		// Token: 0x04001E6A RID: 7786
		internal static int __PropertyOffset_ReapplyScaleZ;

		// Token: 0x04001E6B RID: 7787
		internal static byte __PropertyMask_ReapplyScaleZ;

		// Token: 0x04001E6C RID: 7788
		internal static int __PropertyOffset_ReapplyRandomPitchAngle;

		// Token: 0x04001E6D RID: 7789
		internal static byte __PropertyMask_ReapplyRandomPitchAngle;

		// Token: 0x04001E6E RID: 7790
		internal static int __PropertyOffset_ReapplyGroundSlope;

		// Token: 0x04001E6F RID: 7791
		internal static byte __PropertyMask_ReapplyGroundSlope;

		// Token: 0x04001E70 RID: 7792
		internal static int __PropertyOffset_ReapplyHeight;

		// Token: 0x04001E71 RID: 7793
		internal static byte __PropertyMask_ReapplyHeight;

		// Token: 0x04001E72 RID: 7794
		internal static int __PropertyOffset_ReapplyLandscapeLayers;

		// Token: 0x04001E73 RID: 7795
		internal static byte __PropertyMask_ReapplyLandscapeLayers;

		// Token: 0x04001E74 RID: 7796
		internal static int __PropertyOffset_ReapplyZOffset;

		// Token: 0x04001E75 RID: 7797
		internal static byte __PropertyMask_ReapplyZOffset;

		// Token: 0x04001E76 RID: 7798
		internal static int __PropertyOffset_ReapplyCollisionWithWorld;

		// Token: 0x04001E77 RID: 7799
		internal static byte __PropertyMask_ReapplyCollisionWithWorld;

		// Token: 0x04001E78 RID: 7800
		internal static int __PropertyOffset_ReapplyVertexColorMask;

		// Token: 0x04001E79 RID: 7801
		internal static byte __PropertyMask_ReapplyVertexColorMask;

		// Token: 0x04001E7A RID: 7802
		internal static int __PropertyOffset_bEnableDensityScaling;

		// Token: 0x04001E7B RID: 7803
		internal static byte __PropertyMask_bEnableDensityScaling;

		// Token: 0x04001E7C RID: 7804
		internal static int __PropertyOffset_bEnableDensityScalingLOD;

		// Token: 0x04001E7D RID: 7805
		internal static byte __PropertyMask_bEnableDensityScalingLOD;

		// Token: 0x04001E7E RID: 7806
		internal static int __PropertyOffset_bEnableDensityLODInstScale;

		// Token: 0x04001E7F RID: 7807
		internal static byte __PropertyMask_bEnableDensityLODInstScale;

		// Token: 0x04001E80 RID: 7808
		internal static int __PropertyOffset_bEnableDiscardOnLoad;

		// Token: 0x04001E81 RID: 7809
		internal static byte __PropertyMask_bEnableDiscardOnLoad;

		// Token: 0x04001E82 RID: 7810
		internal static int __PropertyOffset_VirtualTextureCullMips;
	}
}
