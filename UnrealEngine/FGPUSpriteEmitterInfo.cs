using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C0D RID: 3085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GPUSpriteEmitterInfo")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 640)]
	public class FGPUSpriteEmitterInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009B64 RID: 39780 RVA: 0x000DCC7F File Offset: 0x000DAE7F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGPUSpriteEmitterInfo._ScriptStructPtr != 0) ? FGPUSpriteEmitterInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GPUSpriteEmitterInfo", ref FGPUSpriteEmitterInfo._ScriptStructPtr);
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x000DCCA3 File Offset: 0x000DAEA3
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x000DCCB7 File Offset: 0x000DAEB7
		[Nullable(2)]
		public unsafe UParticleModuleRequired RequiredModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleRequired>(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_RequiredModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_RequiredModule, value);
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x000DCCCC File Offset: 0x000DAECC
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x000DCCE0 File Offset: 0x000DAEE0
		[Nullable(2)]
		public unsafe UParticleModuleSpawn SpawnModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleSpawn>(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_SpawnModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_SpawnModule, value);
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x000DCCF5 File Offset: 0x000DAEF5
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x000DCD09 File Offset: 0x000DAF09
		[Nullable(2)]
		public unsafe UParticleModuleSpawnPerUnit SpawnPerUnitModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleSpawnPerUnit>(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_SpawnPerUnitModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGPUSpriteEmitterInfo.__PropertyOffset_SpawnPerUnitModule, value);
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x000DCD20 File Offset: 0x000DAF20
		// (set) Token: 0x06009B6C RID: 39788 RVA: 0x000DCD63 File Offset: 0x000DAF63
		public TArray<UParticleModule> SpawnModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModule> result;
				if ((result = this._SpawnModules) == null)
				{
					result = (this._SpawnModules = new TArray<UParticleModule>(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_SpawnModules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpawnModules.CopyAssign(value);
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x000DCD74 File Offset: 0x000DAF74
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x000DCDB7 File Offset: 0x000DAFB7
		public FGPUSpriteLocalVectorFieldInfo LocalVectorField
		{
			get
			{
				base.FastCheckIsValid();
				FGPUSpriteLocalVectorFieldInfo result;
				if ((result = this._LocalVectorField) == null)
				{
					result = (this._LocalVectorField = new FGPUSpriteLocalVectorFieldInfo(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_LocalVectorField, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGPUSpriteLocalVectorFieldInfo.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_LocalVectorField, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x000DCDD8 File Offset: 0x000DAFD8
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x000DCE1B File Offset: 0x000DB01B
		public FFloatDistribution VectorFieldScale
		{
			get
			{
				base.FastCheckIsValid();
				FFloatDistribution result;
				if ((result = this._VectorFieldScale) == null)
				{
					result = (this._VectorFieldScale = new FFloatDistribution(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_VectorFieldScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFloatDistribution.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_VectorFieldScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06009B71 RID: 39793 RVA: 0x000DCE3C File Offset: 0x000DB03C
		// (set) Token: 0x06009B72 RID: 39794 RVA: 0x000DCE7F File Offset: 0x000DB07F
		public FFloatDistribution DragCoefficient
		{
			get
			{
				base.FastCheckIsValid();
				FFloatDistribution result;
				if ((result = this._DragCoefficient) == null)
				{
					result = (this._DragCoefficient = new FFloatDistribution(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DragCoefficient, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFloatDistribution.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DragCoefficient, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06009B73 RID: 39795 RVA: 0x000DCEA0 File Offset: 0x000DB0A0
		// (set) Token: 0x06009B74 RID: 39796 RVA: 0x000DCEE3 File Offset: 0x000DB0E3
		public FFloatDistribution PointAttractorStrength
		{
			get
			{
				base.FastCheckIsValid();
				FFloatDistribution result;
				if ((result = this._PointAttractorStrength) == null)
				{
					result = (this._PointAttractorStrength = new FFloatDistribution(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorStrength, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFloatDistribution.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06009B75 RID: 39797 RVA: 0x000DCF04 File Offset: 0x000DB104
		// (set) Token: 0x06009B76 RID: 39798 RVA: 0x000DCF47 File Offset: 0x000DB147
		public FFloatDistribution Resilience
		{
			get
			{
				base.FastCheckIsValid();
				FFloatDistribution result;
				if ((result = this._Resilience) == null)
				{
					result = (this._Resilience = new FFloatDistribution(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_Resilience, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFloatDistribution.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_Resilience, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x000DCF68 File Offset: 0x000DB168
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x000DCF7C File Offset: 0x000DB17C
		public unsafe FVector ConstantAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_ConstantAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_ConstantAcceleration) = value;
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x000DCF91 File Offset: 0x000DB191
		// (set) Token: 0x06009B7A RID: 39802 RVA: 0x000DCFA5 File Offset: 0x000DB1A5
		public unsafe FVector PointAttractorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorPosition) = value;
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06009B7B RID: 39803 RVA: 0x000DCFBA File Offset: 0x000DB1BA
		// (set) Token: 0x06009B7C RID: 39804 RVA: 0x000DCFCA File Offset: 0x000DB1CA
		public unsafe float PointAttractorRadiusSq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorRadiusSq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_PointAttractorRadiusSq) = value;
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x000DCFDB File Offset: 0x000DB1DB
		// (set) Token: 0x06009B7E RID: 39806 RVA: 0x000DCFEF File Offset: 0x000DB1EF
		public unsafe FVector OrbitOffsetBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_OrbitOffsetBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_OrbitOffsetBase) = value;
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06009B7F RID: 39807 RVA: 0x000DD004 File Offset: 0x000DB204
		// (set) Token: 0x06009B80 RID: 39808 RVA: 0x000DD018 File Offset: 0x000DB218
		public unsafe FVector OrbitOffsetRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_OrbitOffsetRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_OrbitOffsetRange) = value;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x000DD02D File Offset: 0x000DB22D
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x000DD041 File Offset: 0x000DB241
		public unsafe FVector2D InvMaxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_InvMaxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_InvMaxSize) = value;
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x000DD056 File Offset: 0x000DB256
		// (set) Token: 0x06009B84 RID: 39812 RVA: 0x000DD066 File Offset: 0x000DB266
		public unsafe float InvRotationRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_InvRotationRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_InvRotationRateScale) = value;
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x06009B85 RID: 39813 RVA: 0x000DD077 File Offset: 0x000DB277
		// (set) Token: 0x06009B86 RID: 39814 RVA: 0x000DD087 File Offset: 0x000DB287
		public unsafe float MaxLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxLifetime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxLifetime) = value;
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x000DD098 File Offset: 0x000DB298
		// (set) Token: 0x06009B88 RID: 39816 RVA: 0x000DD0A8 File Offset: 0x000DB2A8
		public unsafe int MaxParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxParticleCount) = value;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06009B89 RID: 39817 RVA: 0x000DD0B9 File Offset: 0x000DB2B9
		// (set) Token: 0x06009B8A RID: 39818 RVA: 0x000DD0CD File Offset: 0x000DB2CD
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleScreenAlignment> ScreenAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_ScreenAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_ScreenAlignment) = value;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x000DD0E2 File Offset: 0x000DB2E2
		// (set) Token: 0x06009B8C RID: 39820 RVA: 0x000DD0F6 File Offset: 0x000DB2F6
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleAxisLock> LockAxisFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_LockAxisFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_LockAxisFlag) = value;
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x000DD10B File Offset: 0x000DB30B
		// (set) Token: 0x06009B8E RID: 39822 RVA: 0x000DD124 File Offset: 0x000DB324
		public unsafe bool bEnableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bEnableCollision) & FGPUSpriteEmitterInfo.__PropertyMask_bEnableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bEnableCollision) = ((*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bEnableCollision) & ~FGPUSpriteEmitterInfo.__PropertyMask_bEnableCollision) | (value ? FGPUSpriteEmitterInfo.__PropertyMask_bEnableCollision : 0));
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x000DD154 File Offset: 0x000DB354
		// (set) Token: 0x06009B90 RID: 39824 RVA: 0x000DD168 File Offset: 0x000DB368
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleCollisionMode> CollisionMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_CollisionMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_CollisionMode) = value;
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06009B91 RID: 39825 RVA: 0x000DD17D File Offset: 0x000DB37D
		// (set) Token: 0x06009B92 RID: 39826 RVA: 0x000DD196 File Offset: 0x000DB396
		public unsafe bool bRemoveHMDRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bRemoveHMDRoll) & FGPUSpriteEmitterInfo.__PropertyMask_bRemoveHMDRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bRemoveHMDRoll) = ((*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_bRemoveHMDRoll) & ~FGPUSpriteEmitterInfo.__PropertyMask_bRemoveHMDRoll) | (value ? FGPUSpriteEmitterInfo.__PropertyMask_bRemoveHMDRoll : 0));
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06009B93 RID: 39827 RVA: 0x000DD1C6 File Offset: 0x000DB3C6
		// (set) Token: 0x06009B94 RID: 39828 RVA: 0x000DD1D6 File Offset: 0x000DB3D6
		public unsafe float MinFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MinFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MinFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06009B95 RID: 39829 RVA: 0x000DD1E7 File Offset: 0x000DB3E7
		// (set) Token: 0x06009B96 RID: 39830 RVA: 0x000DD1F7 File Offset: 0x000DB3F7
		public unsafe float MaxFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_MaxFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06009B97 RID: 39831 RVA: 0x000DD208 File Offset: 0x000DB408
		// (set) Token: 0x06009B98 RID: 39832 RVA: 0x000DD24B File Offset: 0x000DB44B
		public FRawDistributionVector DynamicColor
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._DynamicColor) == null)
				{
					result = (this._DynamicColor = new FRawDistributionVector(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06009B99 RID: 39833 RVA: 0x000DD26C File Offset: 0x000DB46C
		// (set) Token: 0x06009B9A RID: 39834 RVA: 0x000DD2AF File Offset: 0x000DB4AF
		public FRawDistributionFloat DynamicAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._DynamicAlpha) == null)
				{
					result = (this._DynamicAlpha = new FRawDistributionFloat(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicAlpha, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicAlpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06009B9B RID: 39835 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
		// (set) Token: 0x06009B9C RID: 39836 RVA: 0x000DD313 File Offset: 0x000DB513
		public FRawDistributionVector DynamicColorScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._DynamicColorScale) == null)
				{
					result = (this._DynamicColorScale = new FRawDistributionVector(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicColorScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicColorScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x000DD334 File Offset: 0x000DB534
		// (set) Token: 0x06009B9E RID: 39838 RVA: 0x000DD377 File Offset: 0x000DB577
		public FRawDistributionFloat DynamicAlphaScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._DynamicAlphaScale) == null)
				{
					result = (this._DynamicAlphaScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicAlphaScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)FGPUSpriteEmitterInfo.__PropertyOffset_DynamicAlphaScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x000DD398 File Offset: 0x000DB598
		public FGPUSpriteEmitterInfo()
		{
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x000DD3A0 File Offset: 0x000DB5A0
		public FGPUSpriteEmitterInfo(UParticleModuleRequired RequiredModule, UParticleModuleSpawn SpawnModule, UParticleModuleSpawnPerUnit SpawnPerUnitModule, TArray<UParticleModule> SpawnModules, FGPUSpriteLocalVectorFieldInfo LocalVectorField, FFloatDistribution VectorFieldScale, FFloatDistribution DragCoefficient, FFloatDistribution PointAttractorStrength, FFloatDistribution Resilience, FVector ConstantAcceleration, FVector PointAttractorPosition, float PointAttractorRadiusSq, FVector OrbitOffsetBase, FVector OrbitOffsetRange, FVector2D InvMaxSize, float InvRotationRateScale, float MaxLifetime, int MaxParticleCount, [Nullable(0)] TEnumAsByte<EParticleScreenAlignment> ScreenAlignment, [Nullable(0)] TEnumAsByte<EParticleAxisLock> LockAxisFlag, bool bEnableCollision, [Nullable(0)] TEnumAsByte<EParticleCollisionMode> CollisionMode, bool bRemoveHMDRoll, float MinFacingCameraBlendDistance, float MaxFacingCameraBlendDistance, FRawDistributionVector DynamicColor, FRawDistributionFloat DynamicAlpha, FRawDistributionVector DynamicColorScale, FRawDistributionFloat DynamicAlphaScale)
		{
			this.RequiredModule = RequiredModule;
			this.SpawnModule = SpawnModule;
			this.SpawnPerUnitModule = SpawnPerUnitModule;
			this.SpawnModules = SpawnModules;
			this.LocalVectorField = LocalVectorField;
			this.VectorFieldScale = VectorFieldScale;
			this.DragCoefficient = DragCoefficient;
			this.PointAttractorStrength = PointAttractorStrength;
			this.Resilience = Resilience;
			this.ConstantAcceleration = ConstantAcceleration;
			this.PointAttractorPosition = PointAttractorPosition;
			this.PointAttractorRadiusSq = PointAttractorRadiusSq;
			this.OrbitOffsetBase = OrbitOffsetBase;
			this.OrbitOffsetRange = OrbitOffsetRange;
			this.InvMaxSize = InvMaxSize;
			this.InvRotationRateScale = InvRotationRateScale;
			this.MaxLifetime = MaxLifetime;
			this.MaxParticleCount = MaxParticleCount;
			this.ScreenAlignment = ScreenAlignment;
			this.LockAxisFlag = LockAxisFlag;
			this.bEnableCollision = bEnableCollision;
			this.CollisionMode = CollisionMode;
			this.bRemoveHMDRoll = bRemoveHMDRoll;
			this.MinFacingCameraBlendDistance = MinFacingCameraBlendDistance;
			this.MaxFacingCameraBlendDistance = MaxFacingCameraBlendDistance;
			this.DynamicColor = DynamicColor;
			this.DynamicAlpha = DynamicAlpha;
			this.DynamicColorScale = DynamicColorScale;
			this.DynamicAlphaScale = DynamicAlphaScale;
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x000DD498 File Offset: 0x000DB698
		protected override IntPtr GetUStructPtr()
		{
			return FGPUSpriteEmitterInfo.StaticStruct();
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x000DD4A4 File Offset: 0x000DB6A4
		[NullableContext(2)]
		public FGPUSpriteEmitterInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009BA3 RID: 39843 RVA: 0x000DD4AE File Offset: 0x000DB6AE
		public FGPUSpriteEmitterInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x000DD4B9 File Offset: 0x000DB6B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGPUSpriteEmitterInfo(Pointer, false, true);
		}

		// Token: 0x06009BA5 RID: 39845 RVA: 0x000DD4C3 File Offset: 0x000DB6C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGPUSpriteEmitterInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040055C4 RID: 21956
		public const string __ObjectPath = "/Script/Engine.GPUSpriteEmitterInfo";

		// Token: 0x040055C5 RID: 21957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040055C6 RID: 21958
		internal static int __PropertyOffset_RequiredModule;

		// Token: 0x040055C7 RID: 21959
		internal static int __PropertyOffset_SpawnModule;

		// Token: 0x040055C8 RID: 21960
		internal static int __PropertyOffset_SpawnPerUnitModule;

		// Token: 0x040055C9 RID: 21961
		internal static int __PropertyOffset_SpawnModules;

		// Token: 0x040055CA RID: 21962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModule> _SpawnModules;

		// Token: 0x040055CB RID: 21963
		internal static int __PropertyOffset_LocalVectorField;

		// Token: 0x040055CC RID: 21964
		[Nullable(2)]
		private FGPUSpriteLocalVectorFieldInfo _LocalVectorField;

		// Token: 0x040055CD RID: 21965
		internal static int __PropertyOffset_VectorFieldScale;

		// Token: 0x040055CE RID: 21966
		[Nullable(2)]
		private FFloatDistribution _VectorFieldScale;

		// Token: 0x040055CF RID: 21967
		internal static int __PropertyOffset_DragCoefficient;

		// Token: 0x040055D0 RID: 21968
		[Nullable(2)]
		private FFloatDistribution _DragCoefficient;

		// Token: 0x040055D1 RID: 21969
		internal static int __PropertyOffset_PointAttractorStrength;

		// Token: 0x040055D2 RID: 21970
		[Nullable(2)]
		private FFloatDistribution _PointAttractorStrength;

		// Token: 0x040055D3 RID: 21971
		internal static int __PropertyOffset_Resilience;

		// Token: 0x040055D4 RID: 21972
		[Nullable(2)]
		private FFloatDistribution _Resilience;

		// Token: 0x040055D5 RID: 21973
		internal static int __PropertyOffset_ConstantAcceleration;

		// Token: 0x040055D6 RID: 21974
		internal static int __PropertyOffset_PointAttractorPosition;

		// Token: 0x040055D7 RID: 21975
		internal static int __PropertyOffset_PointAttractorRadiusSq;

		// Token: 0x040055D8 RID: 21976
		internal static int __PropertyOffset_OrbitOffsetBase;

		// Token: 0x040055D9 RID: 21977
		internal static int __PropertyOffset_OrbitOffsetRange;

		// Token: 0x040055DA RID: 21978
		internal static int __PropertyOffset_InvMaxSize;

		// Token: 0x040055DB RID: 21979
		internal static int __PropertyOffset_InvRotationRateScale;

		// Token: 0x040055DC RID: 21980
		internal static int __PropertyOffset_MaxLifetime;

		// Token: 0x040055DD RID: 21981
		internal static int __PropertyOffset_MaxParticleCount;

		// Token: 0x040055DE RID: 21982
		internal static int __PropertyOffset_ScreenAlignment;

		// Token: 0x040055DF RID: 21983
		internal static int __PropertyOffset_LockAxisFlag;

		// Token: 0x040055E0 RID: 21984
		internal static int __PropertyOffset_bEnableCollision;

		// Token: 0x040055E1 RID: 21985
		internal static byte __PropertyMask_bEnableCollision;

		// Token: 0x040055E2 RID: 21986
		internal static int __PropertyOffset_CollisionMode;

		// Token: 0x040055E3 RID: 21987
		internal static int __PropertyOffset_bRemoveHMDRoll;

		// Token: 0x040055E4 RID: 21988
		internal static byte __PropertyMask_bRemoveHMDRoll;

		// Token: 0x040055E5 RID: 21989
		internal static int __PropertyOffset_MinFacingCameraBlendDistance;

		// Token: 0x040055E6 RID: 21990
		internal static int __PropertyOffset_MaxFacingCameraBlendDistance;

		// Token: 0x040055E7 RID: 21991
		internal static int __PropertyOffset_DynamicColor;

		// Token: 0x040055E8 RID: 21992
		[Nullable(2)]
		private FRawDistributionVector _DynamicColor;

		// Token: 0x040055E9 RID: 21993
		internal static int __PropertyOffset_DynamicAlpha;

		// Token: 0x040055EA RID: 21994
		[Nullable(2)]
		private FRawDistributionFloat _DynamicAlpha;

		// Token: 0x040055EB RID: 21995
		internal static int __PropertyOffset_DynamicColorScale;

		// Token: 0x040055EC RID: 21996
		[Nullable(2)]
		private FRawDistributionVector _DynamicColorScale;

		// Token: 0x040055ED RID: 21997
		internal static int __PropertyOffset_DynamicAlphaScale;

		// Token: 0x040055EE RID: 21998
		[Nullable(2)]
		private FRawDistributionFloat _DynamicAlphaScale;
	}
}
