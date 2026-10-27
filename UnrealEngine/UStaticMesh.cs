using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001191 RID: 4497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMesh")]
	[UnrealStructLayout(4032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public class UStaticMesh : UStreamableRenderAsset, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface, IInterface_AssetUserData
	{
		// Token: 0x0601083F RID: 67647 RVA: 0x00183FF5 File Offset: 0x001821F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMesh._ClassPtr;
		}

		// Token: 0x06010840 RID: 67648 RVA: 0x00184001 File Offset: 0x00182201
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UStaticMesh.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x06010841 RID: 67649 RVA: 0x00184008 File Offset: 0x00182208
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UStaticMesh.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x06010842 RID: 67650 RVA: 0x00184010 File Offset: 0x00182210
		public UStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010843 RID: 67651 RVA: 0x00184038 File Offset: 0x00182238
		public UStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x06010844 RID: 67652 RVA: 0x0018406C File Offset: 0x0018226C
		// (set) Token: 0x06010845 RID: 67653 RVA: 0x001840A5 File Offset: 0x001822A5
		public FPerPlatformInt MinLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinLOD) == null)
				{
					result = (this._MinLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_MinLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_MinLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06010846 RID: 67654 RVA: 0x001840C6 File Offset: 0x001822C6
		// (set) Token: 0x06010847 RID: 67655 RVA: 0x001840D6 File Offset: 0x001822D6
		public unsafe bool bUseKuroLODDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseKuroLODDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseKuroLODDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x06010848 RID: 67656 RVA: 0x001840E7 File Offset: 0x001822E7
		// (set) Token: 0x06010849 RID: 67657 RVA: 0x001840F7 File Offset: 0x001822F7
		public unsafe bool bBakeImposter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBakeImposter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBakeImposter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0601084A RID: 67658 RVA: 0x00184108 File Offset: 0x00182308
		// (set) Token: 0x0601084B RID: 67659 RVA: 0x00184118 File Offset: 0x00182318
		public unsafe int BakeImposterType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_BakeImposterType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_BakeImposterType) = value;
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0601084C RID: 67660 RVA: 0x0018412C File Offset: 0x0018232C
		// (set) Token: 0x0601084D RID: 67661 RVA: 0x00184165 File Offset: 0x00182365
		public FPerPlatformFloat KuroImposterScreenSizeScaleLod0
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroImposterScreenSizeScaleLod0) == null)
				{
					result = (this._KuroImposterScreenSizeScaleLod0 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_KuroImposterScreenSizeScaleLod0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_KuroImposterScreenSizeScaleLod0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0601084E RID: 67662 RVA: 0x00184188 File Offset: 0x00182388
		// (set) Token: 0x0601084F RID: 67663 RVA: 0x001841C1 File Offset: 0x001823C1
		public FPerPlatformFloat KuroImposterScreenSizeScaleLod1
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroImposterScreenSizeScaleLod1) == null)
				{
					result = (this._KuroImposterScreenSizeScaleLod1 = new FPerPlatformFloat(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_KuroImposterScreenSizeScaleLod1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_KuroImposterScreenSizeScaleLod1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x06010850 RID: 67664 RVA: 0x001841E2 File Offset: 0x001823E2
		// (set) Token: 0x06010851 RID: 67665 RVA: 0x001841F2 File Offset: 0x001823F2
		public unsafe bool bCastRasterShadowsInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bCastRasterShadowsInRaytracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bCastRasterShadowsInRaytracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x06010852 RID: 67666 RVA: 0x00184203 File Offset: 0x00182403
		// (set) Token: 0x06010853 RID: 67667 RVA: 0x00184213 File Offset: 0x00182413
		public unsafe bool bUseCustomDataForWorldMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseCustomDataForWorldMap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseCustomDataForWorldMap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x06010854 RID: 67668 RVA: 0x00184224 File Offset: 0x00182424
		// (set) Token: 0x06010855 RID: 67669 RVA: 0x00184234 File Offset: 0x00182434
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x06010856 RID: 67670 RVA: 0x00184248 File Offset: 0x00182448
		// (set) Token: 0x06010857 RID: 67671 RVA: 0x00184281 File Offset: 0x00182481
		public FPerPlatformInt ShadowLodBias
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._ShadowLodBias) == null)
				{
					result = (this._ShadowLodBias = new FPerPlatformInt(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ShadowLodBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ShadowLodBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x06010858 RID: 67672 RVA: 0x001842A4 File Offset: 0x001824A4
		// (set) Token: 0x06010859 RID: 67673 RVA: 0x001842DD File Offset: 0x001824DD
		public TArray<FName> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x0601085A RID: 67674 RVA: 0x001842EC File Offset: 0x001824EC
		// (set) Token: 0x0601085B RID: 67675 RVA: 0x00184325 File Offset: 0x00182525
		public TArray<UKuroMaterialVariationCollection> KuroMaterialVariationAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroMaterialVariationCollection> result;
				if ((result = this._KuroMaterialVariationAssets) == null)
				{
					result = (this._KuroMaterialVariationAssets = new TArray<UKuroMaterialVariationCollection>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_KuroMaterialVariationAssets, this));
				}
				return result;
			}
			set
			{
				this.KuroMaterialVariationAssets.CopyAssign(value);
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x0601085C RID: 67676 RVA: 0x00184333 File Offset: 0x00182533
		// (set) Token: 0x0601085D RID: 67677 RVA: 0x00184347 File Offset: 0x00182547
		[Nullable(2)]
		public unsafe UKuroMaterialVariationData KuroMaterialVariationData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialVariationData>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_KuroMaterialVariationData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_KuroMaterialVariationData, value);
			}
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0601085E RID: 67678 RVA: 0x0018435C File Offset: 0x0018255C
		// (set) Token: 0x0601085F RID: 67679 RVA: 0x0018436C File Offset: 0x0018256C
		public unsafe float LpvBiasMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LpvBiasMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LpvBiasMultiplier) = value;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x06010860 RID: 67680 RVA: 0x00184380 File Offset: 0x00182580
		// (set) Token: 0x06010861 RID: 67681 RVA: 0x001843B9 File Offset: 0x001825B9
		public TArray<FStaticMaterial> StaticMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticMaterial> result;
				if ((result = this._StaticMaterials) == null)
				{
					result = (this._StaticMaterials = new TArray<FStaticMaterial>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_StaticMaterials, this));
				}
				return result;
			}
			set
			{
				this.StaticMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x06010862 RID: 67682 RVA: 0x001843C7 File Offset: 0x001825C7
		// (set) Token: 0x06010863 RID: 67683 RVA: 0x001843D7 File Offset: 0x001825D7
		public unsafe float LightmapUVDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightmapUVDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightmapUVDensity) = value;
			}
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x06010864 RID: 67684 RVA: 0x001843E8 File Offset: 0x001825E8
		// (set) Token: 0x06010865 RID: 67685 RVA: 0x001843F8 File Offset: 0x001825F8
		public unsafe int LightMapResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapResolution) = value;
			}
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x06010866 RID: 67686 RVA: 0x00184409 File Offset: 0x00182609
		// (set) Token: 0x06010867 RID: 67687 RVA: 0x00184419 File Offset: 0x00182619
		public unsafe int LightMapCoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapCoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LightMapCoordinateIndex) = value;
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x06010868 RID: 67688 RVA: 0x0018442A File Offset: 0x0018262A
		// (set) Token: 0x06010869 RID: 67689 RVA: 0x0018443A File Offset: 0x0018263A
		public unsafe float DistanceFieldSelfShadowBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_DistanceFieldSelfShadowBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_DistanceFieldSelfShadowBias) = value;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x0601086A RID: 67690 RVA: 0x0018444B File Offset: 0x0018264B
		// (set) Token: 0x0601086B RID: 67691 RVA: 0x0018445F File Offset: 0x0018265F
		[Nullable(2)]
		public unsafe UBodySetup BodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_BodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x0601086C RID: 67692 RVA: 0x00184474 File Offset: 0x00182674
		// (set) Token: 0x0601086D RID: 67693 RVA: 0x00184484 File Offset: 0x00182684
		public unsafe int LODForCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LODForCollision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_LODForCollision) = value;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x0601086E RID: 67694 RVA: 0x00184495 File Offset: 0x00182695
		// (set) Token: 0x0601086F RID: 67695 RVA: 0x001844A9 File Offset: 0x001826A9
		[Nullable(2)]
		public unsafe UBodySetup StandaloneBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_StandaloneBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_StandaloneBodySetup, value);
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x06010870 RID: 67696 RVA: 0x001844BE File Offset: 0x001826BE
		// (set) Token: 0x06010871 RID: 67697 RVA: 0x001844D7 File Offset: 0x001826D7
		public unsafe bool bUseStandaloneBodySetup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) & UStaticMesh.__PropertyMask_bUseStandaloneBodySetup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseStandaloneBodySetup) & ~UStaticMesh.__PropertyMask_bUseStandaloneBodySetup) | (value ? UStaticMesh.__PropertyMask_bUseStandaloneBodySetup : 0));
			}
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x06010872 RID: 67698 RVA: 0x00184507 File Offset: 0x00182707
		// (set) Token: 0x06010873 RID: 67699 RVA: 0x00184520 File Offset: 0x00182720
		public unsafe bool bGenerateMeshDistanceField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) & UStaticMesh.__PropertyMask_bGenerateMeshDistanceField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bGenerateMeshDistanceField) & ~UStaticMesh.__PropertyMask_bGenerateMeshDistanceField) | (value ? UStaticMesh.__PropertyMask_bGenerateMeshDistanceField : 0));
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x06010874 RID: 67700 RVA: 0x00184550 File Offset: 0x00182750
		// (set) Token: 0x06010875 RID: 67701 RVA: 0x00184569 File Offset: 0x00182769
		public unsafe bool bStripComplexCollisionForConsole_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) & UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED) & ~UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED) | (value ? UStaticMesh.__PropertyMask_bStripComplexCollisionForConsole_DEPRECATED : 0));
			}
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x06010876 RID: 67702 RVA: 0x00184599 File Offset: 0x00182799
		// (set) Token: 0x06010877 RID: 67703 RVA: 0x001845B2 File Offset: 0x001827B2
		public unsafe bool bHasNavigationData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) & UStaticMesh.__PropertyMask_bHasNavigationData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bHasNavigationData) & ~UStaticMesh.__PropertyMask_bHasNavigationData) | (value ? UStaticMesh.__PropertyMask_bHasNavigationData : 0));
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x06010878 RID: 67704 RVA: 0x001845E2 File Offset: 0x001827E2
		// (set) Token: 0x06010879 RID: 67705 RVA: 0x001845FB File Offset: 0x001827FB
		public unsafe bool bSupportUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) & UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportUniformlyDistributedSampling) & ~UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling) | (value ? UStaticMesh.__PropertyMask_bSupportUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0601087A RID: 67706 RVA: 0x0018462B File Offset: 0x0018282B
		// (set) Token: 0x0601087B RID: 67707 RVA: 0x00184644 File Offset: 0x00182844
		public unsafe bool bSupportPhysicalMaterialMasks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) & UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportPhysicalMaterialMasks) & ~UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks) | (value ? UStaticMesh.__PropertyMask_bSupportPhysicalMaterialMasks : 0));
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0601087C RID: 67708 RVA: 0x00184674 File Offset: 0x00182874
		// (set) Token: 0x0601087D RID: 67709 RVA: 0x0018468D File Offset: 0x0018288D
		public unsafe bool bIsBuiltAtRuntime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) & UStaticMesh.__PropertyMask_bIsBuiltAtRuntime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bIsBuiltAtRuntime) & ~UStaticMesh.__PropertyMask_bIsBuiltAtRuntime) | (value ? UStaticMesh.__PropertyMask_bIsBuiltAtRuntime : 0));
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0601087E RID: 67710 RVA: 0x001846BD File Offset: 0x001828BD
		// (set) Token: 0x0601087F RID: 67711 RVA: 0x001846D6 File Offset: 0x001828D6
		public unsafe bool bAllowCPUAccess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) & UStaticMesh.__PropertyMask_bAllowCPUAccess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowCPUAccess) & ~UStaticMesh.__PropertyMask_bAllowCPUAccess) | (value ? UStaticMesh.__PropertyMask_bAllowCPUAccess : 0));
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x06010880 RID: 67712 RVA: 0x00184706 File Offset: 0x00182906
		// (set) Token: 0x06010881 RID: 67713 RVA: 0x0018471F File Offset: 0x0018291F
		public unsafe bool bSupportGpuUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) & UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bSupportGpuUniformlyDistributedSampling) & ~UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling) | (value ? UStaticMesh.__PropertyMask_bSupportGpuUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06010882 RID: 67714 RVA: 0x0018474F File Offset: 0x0018294F
		// (set) Token: 0x06010883 RID: 67715 RVA: 0x00184768 File Offset: 0x00182968
		public unsafe bool bAllowVertexCompress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) & UStaticMesh.__PropertyMask_bAllowVertexCompress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAllowVertexCompress) & ~UStaticMesh.__PropertyMask_bAllowVertexCompress) | (value ? UStaticMesh.__PropertyMask_bAllowVertexCompress : 0));
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x06010884 RID: 67716 RVA: 0x00184798 File Offset: 0x00182998
		// (set) Token: 0x06010885 RID: 67717 RVA: 0x001847B1 File Offset: 0x001829B1
		public unsafe bool bPreviewVertexCompressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) & UStaticMesh.__PropertyMask_bPreviewVertexCompressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bPreviewVertexCompressed) & ~UStaticMesh.__PropertyMask_bPreviewVertexCompressed) | (value ? UStaticMesh.__PropertyMask_bPreviewVertexCompressed : 0));
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x06010886 RID: 67718 RVA: 0x001847E1 File Offset: 0x001829E1
		// (set) Token: 0x06010887 RID: 67719 RVA: 0x001847FA File Offset: 0x001829FA
		public unsafe bool bAfterVertexCompress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) & UStaticMesh.__PropertyMask_bAfterVertexCompress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bAfterVertexCompress) & ~UStaticMesh.__PropertyMask_bAfterVertexCompress) | (value ? UStaticMesh.__PropertyMask_bAfterVertexCompress : 0));
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x06010888 RID: 67720 RVA: 0x0018482A File Offset: 0x00182A2A
		// (set) Token: 0x06010889 RID: 67721 RVA: 0x00184843 File Offset: 0x00182A43
		public unsafe bool bBasePassVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) & UStaticMesh.__PropertyMask_bBasePassVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) = ((*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bBasePassVelocity) & ~UStaticMesh.__PropertyMask_bBasePassVelocity) | (value ? UStaticMesh.__PropertyMask_bBasePassVelocity : 0));
			}
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0601088A RID: 67722 RVA: 0x00184874 File Offset: 0x00182A74
		// (set) Token: 0x0601088B RID: 67723 RVA: 0x001848AD File Offset: 0x00182AAD
		public TArray<UStaticMeshSocket> Sockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshSocket> result;
				if ((result = this._Sockets) == null)
				{
					result = (this._Sockets = new TArray<UStaticMeshSocket>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_Sockets, this));
				}
				return result;
			}
			set
			{
				this.Sockets.CopyAssign(value);
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0601088C RID: 67724 RVA: 0x001848BB File Offset: 0x00182ABB
		// (set) Token: 0x0601088D RID: 67725 RVA: 0x001848CF File Offset: 0x00182ACF
		public unsafe FVector PositiveBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_PositiveBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_PositiveBoundsExtension) = value;
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0601088E RID: 67726 RVA: 0x001848E4 File Offset: 0x00182AE4
		// (set) Token: 0x0601088F RID: 67727 RVA: 0x001848F8 File Offset: 0x00182AF8
		public unsafe FVector NegativeBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_NegativeBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_NegativeBoundsExtension) = value;
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x06010890 RID: 67728 RVA: 0x0018490D File Offset: 0x00182B0D
		// (set) Token: 0x06010891 RID: 67729 RVA: 0x00184921 File Offset: 0x00182B21
		public unsafe FBoxSphereBounds ExtendedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ExtendedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ExtendedBounds) = value;
			}
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x06010892 RID: 67730 RVA: 0x00184936 File Offset: 0x00182B36
		// (set) Token: 0x06010893 RID: 67731 RVA: 0x00184946 File Offset: 0x00182B46
		public unsafe int ElementToIgnoreForTexFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ElementToIgnoreForTexFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_ElementToIgnoreForTexFactor) = value;
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x06010894 RID: 67732 RVA: 0x00184958 File Offset: 0x00182B58
		// (set) Token: 0x06010895 RID: 67733 RVA: 0x00184991 File Offset: 0x00182B91
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x06010896 RID: 67734 RVA: 0x0018499F File Offset: 0x00182B9F
		// (set) Token: 0x06010897 RID: 67735 RVA: 0x001849B3 File Offset: 0x00182BB3
		[Nullable(2)]
		public unsafe UObject EditableMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_EditableMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_EditableMesh, value);
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x06010898 RID: 67736 RVA: 0x001849C8 File Offset: 0x00182BC8
		// (set) Token: 0x06010899 RID: 67737 RVA: 0x001849D8 File Offset: 0x00182BD8
		public unsafe bool bUseSpecialBodySetup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseSpecialBodySetup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bUseSpecialBodySetup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0601089A RID: 67738 RVA: 0x001849E9 File Offset: 0x00182BE9
		// (set) Token: 0x0601089B RID: 67739 RVA: 0x001849F9 File Offset: 0x00182BF9
		public unsafe bool bOnlyUseSimpleCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bOnlyUseSimpleCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bOnlyUseSimpleCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x0601089C RID: 67740 RVA: 0x00184A0A File Offset: 0x00182C0A
		// (set) Token: 0x0601089D RID: 67741 RVA: 0x00184A1E File Offset: 0x00182C1E
		[Nullable(2)]
		public unsafe UNavCollisionBase NavCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavCollisionBase>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_NavCollision);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMesh.__PropertyOffset_NavCollision, value);
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0601089E RID: 67742 RVA: 0x00184A33 File Offset: 0x00182C33
		// (set) Token: 0x0601089F RID: 67743 RVA: 0x00184A43 File Offset: 0x00182C43
		public unsafe bool bKuroAutoReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bKuroAutoReduce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMesh.__PropertyOffset_bKuroAutoReduce) = (value ? 1 : 0);
			}
		}

		// Token: 0x060108A0 RID: 67744 RVA: 0x00184A54 File Offset: 0x00182C54
		[NullableContext(2)]
		public void RemoveSocket(UStaticMeshSocket Socket)
		{
			UStaticMesh.__RemoveSocket_Internal(base.NativePtr, (Socket != null) ? Socket.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060108A1 RID: 67745 RVA: 0x00184A74 File Offset: 0x00182C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FStaticMaterial> GetStaticMaterials()
		{
			UStaticMesh.__GetStaticMaterials_FunctionParams* ptr = stackalloc UStaticMesh.__GetStaticMaterials_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStaticMesh.__GetStaticMaterials_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStaticMesh.__GetStaticMaterials_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UStaticMesh.__GetStaticMaterials_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FStaticMaterial> result = new TArray<FStaticMaterial>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UStaticMesh.__GetStaticMaterials_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060108A2 RID: 67746 RVA: 0x00184AD3 File Offset: 0x00182CD3
		public int GetNumTriangles(int LODIndex)
		{
			return UStaticMesh.__GetNumTriangles_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x060108A3 RID: 67747 RVA: 0x00184AE1 File Offset: 0x00182CE1
		public int GetNumSections(int InLOD)
		{
			return UStaticMesh.__GetNumSections_Internal(base.NativePtr, InLOD);
		}

		// Token: 0x060108A4 RID: 67748 RVA: 0x00184AEF File Offset: 0x00182CEF
		public int GetNumLODs()
		{
			return UStaticMesh.__GetNumLODs_Internal(base.NativePtr);
		}

		// Token: 0x060108A5 RID: 67749 RVA: 0x00184AFC File Offset: 0x00182CFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetMinimumLODForPlatforms(ref TMap<FName, int> PlatformMinimumLODs)
		{
			UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams* ptr = stackalloc UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UStaticMesh.__GetMinimumLODForPlatforms_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = PlatformMinimumLODs;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->PlatformMinimumLODs);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> tmap2 = PlatformMinimumLODs;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->PlatformMinimumLODs);
			}
			UnrealReflectionUtils.DestroyStruct(UStaticMesh.__GetMinimumLODForPlatforms_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060108A6 RID: 67750 RVA: 0x00184B78 File Offset: 0x00182D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetMinimumLODForPlatform(in FName PlatformName)
		{
			UStaticMesh.__GetMinimumLODForPlatform_FunctionParams* ptr = stackalloc UStaticMesh.__GetMinimumLODForPlatform_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UStaticMesh.__GetMinimumLODForPlatform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UStaticMesh.__GetMinimumLODForPlatform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlatformName = PlatformName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UStaticMesh.__GetMinimumLODForPlatform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060108A7 RID: 67751 RVA: 0x00184BCC File Offset: 0x00182DCC
		public unsafe int GetMaterialIndexByDisplayName(string DiaplayName)
		{
			FString fstring = FString.AllocTemp(DiaplayName);
			int result = UStaticMesh.__GetMaterialIndexByDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060108A8 RID: 67752 RVA: 0x00184BF6 File Offset: 0x00182DF6
		public int GetMaterialIndex(FName MaterialSlotName)
		{
			return UStaticMesh.__GetMaterialIndex_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x060108A9 RID: 67753 RVA: 0x00184C04 File Offset: 0x00182E04
		[NullableContext(2)]
		public UMaterialInterface GetMaterial(int MaterialIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UStaticMesh.__GetMaterial_Internal(base.NativePtr, MaterialIndex));
		}

		// Token: 0x060108AA RID: 67754 RVA: 0x00184C17 File Offset: 0x00182E17
		public FBoxSphereBounds GetBounds()
		{
			return UStaticMesh.__GetBounds_Internal(base.NativePtr);
		}

		// Token: 0x060108AB RID: 67755 RVA: 0x00184C24 File Offset: 0x00182E24
		public FBox GetBoundingBox()
		{
			return UStaticMesh.__GetBoundingBox_Internal(base.NativePtr);
		}

		// Token: 0x060108AC RID: 67756 RVA: 0x00184C31 File Offset: 0x00182E31
		public bool GetAllowVertexCompress()
		{
			return UStaticMesh.__GetAllowVertexCompress_Internal(base.NativePtr);
		}

		// Token: 0x060108AD RID: 67757 RVA: 0x00184C3E File Offset: 0x00182E3E
		[NullableContext(2)]
		public UStaticMeshSocket FindSocket(FName InSocketName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshSocket>(UStaticMesh.__FindSocket_Internal(base.NativePtr, InSocketName));
		}

		// Token: 0x060108AE RID: 67758 RVA: 0x00184C51 File Offset: 0x00182E51
		[NullableContext(2)]
		public static UStaticMeshDescription CreateStaticMeshDescription(UObject Outer = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshDescription>(UStaticMesh.__CreateStaticMeshDescription_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060108AF RID: 67759 RVA: 0x00184C6D File Offset: 0x00182E6D
		public void BuildFromStaticMeshDescriptions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMeshDescription> StaticMeshDescriptions, bool bBuildSimpleCollision = false)
		{
			UStaticMesh.__BuildFromStaticMeshDescriptions_Internal(base.NativePtr, (StaticMeshDescriptions ?? new TArray<UStaticMeshDescription>()).NativePtr, bBuildSimpleCollision);
		}

		// Token: 0x060108B0 RID: 67760 RVA: 0x00184C8B File Offset: 0x00182E8B
		[NullableContext(2)]
		public void AddSocket(UStaticMeshSocket Socket)
		{
			UStaticMesh.__AddSocket_Internal(base.NativePtr, (Socket != null) ? Socket.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060108B1 RID: 67761 RVA: 0x00184CA8 File Offset: 0x00182EA8
		[NullableContext(2)]
		public FName AddMaterial(UMaterialInterface Material)
		{
			return UStaticMesh.__AddMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060108B2 RID: 67762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSocket_Internal(IntPtr @this, IntPtr Socket);

		// Token: 0x060108B3 RID: 67763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTriangles_Internal(IntPtr @this, int LODIndex);

		// Token: 0x060108B4 RID: 67764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this, int InLOD);

		// Token: 0x060108B5 RID: 67765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumLODs_Internal(IntPtr @this);

		// Token: 0x060108B6 RID: 67766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndexByDisplayName_Internal(IntPtr @this, in FString DiaplayName);

		// Token: 0x060108B7 RID: 67767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndex_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x060108B8 RID: 67768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterial_Internal(IntPtr @this, int MaterialIndex);

		// Token: 0x060108B9 RID: 67769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds __GetBounds_Internal(IntPtr @this);

		// Token: 0x060108BA RID: 67770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetBoundingBox_Internal(IntPtr @this);

		// Token: 0x060108BB RID: 67771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowVertexCompress_Internal(IntPtr @this);

		// Token: 0x060108BC RID: 67772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindSocket_Internal(IntPtr @this, FName InSocketName);

		// Token: 0x060108BD RID: 67773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateStaticMeshDescription_Internal(IntPtr Outer);

		// Token: 0x060108BE RID: 67774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildFromStaticMeshDescriptions_Internal(IntPtr @this, IntPtr StaticMeshDescriptions, bool bBuildSimpleCollision);

		// Token: 0x060108BF RID: 67775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSocket_Internal(IntPtr @this, IntPtr Socket);

		// Token: 0x060108C0 RID: 67776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __AddMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x060108C1 RID: 67777 RVA: 0x00184CC5 File Offset: 0x00182EC5
		static UStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMesh");
		}

		// Token: 0x060108C2 RID: 67778 RVA: 0x00184CD3 File Offset: 0x00182ED3
		protected UStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D52 RID: 36178
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04008D53 RID: 36179
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04008D54 RID: 36180
		public new const string __ObjectPath = "/Script/Engine.StaticMesh";

		// Token: 0x04008D55 RID: 36181
		private static IntPtr _ClassPtr;

		// Token: 0x04008D56 RID: 36182
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008D57 RID: 36183
		internal static int __PropertyOffset_MinLOD;

		// Token: 0x04008D58 RID: 36184
		[Nullable(2)]
		private FPerPlatformInt _MinLOD;

		// Token: 0x04008D59 RID: 36185
		internal static int __PropertyOffset_bUseKuroLODDistance;

		// Token: 0x04008D5A RID: 36186
		internal static int __PropertyOffset_bBakeImposter;

		// Token: 0x04008D5B RID: 36187
		internal static int __PropertyOffset_BakeImposterType;

		// Token: 0x04008D5C RID: 36188
		internal static int __PropertyOffset_KuroImposterScreenSizeScaleLod0;

		// Token: 0x04008D5D RID: 36189
		[Nullable(2)]
		private FPerPlatformFloat _KuroImposterScreenSizeScaleLod0;

		// Token: 0x04008D5E RID: 36190
		internal static int __PropertyOffset_KuroImposterScreenSizeScaleLod1;

		// Token: 0x04008D5F RID: 36191
		[Nullable(2)]
		private FPerPlatformFloat _KuroImposterScreenSizeScaleLod1;

		// Token: 0x04008D60 RID: 36192
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04008D61 RID: 36193
		internal static int __PropertyOffset_bUseCustomDataForWorldMap;

		// Token: 0x04008D62 RID: 36194
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04008D63 RID: 36195
		internal static int __PropertyOffset_ShadowLodBias;

		// Token: 0x04008D64 RID: 36196
		[Nullable(2)]
		private FPerPlatformInt _ShadowLodBias;

		// Token: 0x04008D65 RID: 36197
		internal static int __PropertyOffset_Tags;

		// Token: 0x04008D66 RID: 36198
		[Nullable(2)]
		private TArray<FName> _Tags;

		// Token: 0x04008D67 RID: 36199
		internal static int __PropertyOffset_KuroMaterialVariationAssets;

		// Token: 0x04008D68 RID: 36200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroMaterialVariationCollection> _KuroMaterialVariationAssets;

		// Token: 0x04008D69 RID: 36201
		internal static int __PropertyOffset_KuroMaterialVariationData;

		// Token: 0x04008D6A RID: 36202
		internal static int __PropertyOffset_LpvBiasMultiplier;

		// Token: 0x04008D6B RID: 36203
		internal static int __PropertyOffset_StaticMaterials;

		// Token: 0x04008D6C RID: 36204
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticMaterial> _StaticMaterials;

		// Token: 0x04008D6D RID: 36205
		internal static int __PropertyOffset_LightmapUVDensity;

		// Token: 0x04008D6E RID: 36206
		internal static int __PropertyOffset_LightMapResolution;

		// Token: 0x04008D6F RID: 36207
		internal static int __PropertyOffset_LightMapCoordinateIndex;

		// Token: 0x04008D70 RID: 36208
		internal static int __PropertyOffset_DistanceFieldSelfShadowBias;

		// Token: 0x04008D71 RID: 36209
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04008D72 RID: 36210
		internal static int __PropertyOffset_LODForCollision;

		// Token: 0x04008D73 RID: 36211
		internal static int __PropertyOffset_StandaloneBodySetup;

		// Token: 0x04008D74 RID: 36212
		internal static int __PropertyOffset_bUseStandaloneBodySetup;

		// Token: 0x04008D75 RID: 36213
		internal static byte __PropertyMask_bUseStandaloneBodySetup;

		// Token: 0x04008D76 RID: 36214
		internal static int __PropertyOffset_bGenerateMeshDistanceField;

		// Token: 0x04008D77 RID: 36215
		internal static byte __PropertyMask_bGenerateMeshDistanceField;

		// Token: 0x04008D78 RID: 36216
		internal static int __PropertyOffset_bStripComplexCollisionForConsole_DEPRECATED;

		// Token: 0x04008D79 RID: 36217
		internal static byte __PropertyMask_bStripComplexCollisionForConsole_DEPRECATED;

		// Token: 0x04008D7A RID: 36218
		internal static int __PropertyOffset_bHasNavigationData;

		// Token: 0x04008D7B RID: 36219
		internal static byte __PropertyMask_bHasNavigationData;

		// Token: 0x04008D7C RID: 36220
		internal static int __PropertyOffset_bSupportUniformlyDistributedSampling;

		// Token: 0x04008D7D RID: 36221
		internal static byte __PropertyMask_bSupportUniformlyDistributedSampling;

		// Token: 0x04008D7E RID: 36222
		internal static int __PropertyOffset_bSupportPhysicalMaterialMasks;

		// Token: 0x04008D7F RID: 36223
		internal static byte __PropertyMask_bSupportPhysicalMaterialMasks;

		// Token: 0x04008D80 RID: 36224
		internal static int __PropertyOffset_bIsBuiltAtRuntime;

		// Token: 0x04008D81 RID: 36225
		internal static byte __PropertyMask_bIsBuiltAtRuntime;

		// Token: 0x04008D82 RID: 36226
		internal static int __PropertyOffset_bAllowCPUAccess;

		// Token: 0x04008D83 RID: 36227
		internal static byte __PropertyMask_bAllowCPUAccess;

		// Token: 0x04008D84 RID: 36228
		internal static int __PropertyOffset_bSupportGpuUniformlyDistributedSampling;

		// Token: 0x04008D85 RID: 36229
		internal static byte __PropertyMask_bSupportGpuUniformlyDistributedSampling;

		// Token: 0x04008D86 RID: 36230
		internal static int __PropertyOffset_bAllowVertexCompress;

		// Token: 0x04008D87 RID: 36231
		internal static byte __PropertyMask_bAllowVertexCompress;

		// Token: 0x04008D88 RID: 36232
		internal static int __PropertyOffset_bPreviewVertexCompressed;

		// Token: 0x04008D89 RID: 36233
		internal static byte __PropertyMask_bPreviewVertexCompressed;

		// Token: 0x04008D8A RID: 36234
		internal static int __PropertyOffset_bAfterVertexCompress;

		// Token: 0x04008D8B RID: 36235
		internal static byte __PropertyMask_bAfterVertexCompress;

		// Token: 0x04008D8C RID: 36236
		internal static int __PropertyOffset_bBasePassVelocity;

		// Token: 0x04008D8D RID: 36237
		internal static byte __PropertyMask_bBasePassVelocity;

		// Token: 0x04008D8E RID: 36238
		internal static int __PropertyOffset_Sockets;

		// Token: 0x04008D8F RID: 36239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshSocket> _Sockets;

		// Token: 0x04008D90 RID: 36240
		internal static int __PropertyOffset_PositiveBoundsExtension;

		// Token: 0x04008D91 RID: 36241
		internal static int __PropertyOffset_NegativeBoundsExtension;

		// Token: 0x04008D92 RID: 36242
		internal static int __PropertyOffset_ExtendedBounds;

		// Token: 0x04008D93 RID: 36243
		internal static int __PropertyOffset_ElementToIgnoreForTexFactor;

		// Token: 0x04008D94 RID: 36244
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04008D95 RID: 36245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x04008D96 RID: 36246
		internal static int __PropertyOffset_EditableMesh;

		// Token: 0x04008D97 RID: 36247
		internal static int __PropertyOffset_bUseSpecialBodySetup;

		// Token: 0x04008D98 RID: 36248
		internal static int __PropertyOffset_bOnlyUseSimpleCollision;

		// Token: 0x04008D99 RID: 36249
		internal static int __PropertyOffset_NavCollision;

		// Token: 0x04008D9A RID: 36250
		internal static int __PropertyOffset_bKuroAutoReduce;

		// Token: 0x04008D9B RID: 36251
		private static IntPtr __GetStaticMaterials_NativeFunctionPtr;

		// Token: 0x04008D9C RID: 36252
		private static IntPtr __GetMinimumLODForPlatforms_NativeFunctionPtr;

		// Token: 0x04008D9D RID: 36253
		private static IntPtr __GetMinimumLODForPlatform_NativeFunctionPtr;

		// Token: 0x02002DE6 RID: 11750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStaticMaterials_FunctionParams
		{
			// Token: 0x04016829 RID: 92201
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02002DE7 RID: 11751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetMinimumLODForPlatforms_FunctionParams
		{
			// Token: 0x0401682A RID: 92202
			[FieldOffset(0)]
			public byte PlatformMinimumLODs;
		}

		// Token: 0x02002DE8 RID: 11752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMinimumLODForPlatform_FunctionParams
		{
			// Token: 0x0401682B RID: 92203
			[FieldOffset(0)]
			public FName PlatformName;

			// Token: 0x0401682C RID: 92204
			[FieldOffset(12)]
			public int __Result;
		}
	}
}
