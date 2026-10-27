using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F6D RID: 8045
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeComponent")]
	[UnrealStructLayout(2880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class ULandscapeComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E821 RID: 124961 RVA: 0x002D5901 File Offset: 0x002D3B01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeComponent._ClassPtr;
		}

		// Token: 0x0601E822 RID: 124962 RVA: 0x002D5910 File Offset: 0x002D3B10
		public ULandscapeComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E823 RID: 124963 RVA: 0x002D5938 File Offset: 0x002D3B38
		[NullableContext(1)]
		public ULandscapeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700794C RID: 31052
		// (get) Token: 0x0601E824 RID: 124964 RVA: 0x002D596B File Offset: 0x002D3B6B
		// (set) Token: 0x0601E825 RID: 124965 RVA: 0x002D597B File Offset: 0x002D3B7B
		public unsafe int SectionBaseX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SectionBaseX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SectionBaseX) = value;
			}
		}

		// Token: 0x1700794D RID: 31053
		// (get) Token: 0x0601E826 RID: 124966 RVA: 0x002D598C File Offset: 0x002D3B8C
		// (set) Token: 0x0601E827 RID: 124967 RVA: 0x002D599C File Offset: 0x002D3B9C
		public unsafe int SectionBaseY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SectionBaseY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SectionBaseY) = value;
			}
		}

		// Token: 0x1700794E RID: 31054
		// (get) Token: 0x0601E828 RID: 124968 RVA: 0x002D59AD File Offset: 0x002D3BAD
		// (set) Token: 0x0601E829 RID: 124969 RVA: 0x002D59BD File Offset: 0x002D3BBD
		public unsafe int ComponentSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_ComponentSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_ComponentSizeQuads) = value;
			}
		}

		// Token: 0x1700794F RID: 31055
		// (get) Token: 0x0601E82A RID: 124970 RVA: 0x002D59CE File Offset: 0x002D3BCE
		// (set) Token: 0x0601E82B RID: 124971 RVA: 0x002D59DE File Offset: 0x002D3BDE
		public unsafe int SubsectionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SubsectionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SubsectionSizeQuads) = value;
			}
		}

		// Token: 0x17007950 RID: 31056
		// (get) Token: 0x0601E82C RID: 124972 RVA: 0x002D59EF File Offset: 0x002D3BEF
		// (set) Token: 0x0601E82D RID: 124973 RVA: 0x002D59FF File Offset: 0x002D3BFF
		public unsafe int NumSubsections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_NumSubsections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_NumSubsections) = value;
			}
		}

		// Token: 0x17007951 RID: 31057
		// (get) Token: 0x0601E82E RID: 124974 RVA: 0x002D5A10 File Offset: 0x002D3C10
		// (set) Token: 0x0601E82F RID: 124975 RVA: 0x002D5A24 File Offset: 0x002D3C24
		public unsafe UMaterialInterface OverrideMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_OverrideMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_OverrideMaterial, value);
			}
		}

		// Token: 0x17007952 RID: 31058
		// (get) Token: 0x0601E830 RID: 124976 RVA: 0x002D5A39 File Offset: 0x002D3C39
		// (set) Token: 0x0601E831 RID: 124977 RVA: 0x002D5A4D File Offset: 0x002D3C4D
		public unsafe UMaterialInterface OverrideHoleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_OverrideHoleMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_OverrideHoleMaterial, value);
			}
		}

		// Token: 0x17007953 RID: 31059
		// (get) Token: 0x0601E832 RID: 124978 RVA: 0x002D5A64 File Offset: 0x002D3C64
		// (set) Token: 0x0601E833 RID: 124979 RVA: 0x002D5A9D File Offset: 0x002D3C9D
		[Nullable(1)]
		public TArray<FLandscapeComponentMaterialOverride> OverrideMaterials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeComponentMaterialOverride> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<FLandscapeComponentMaterialOverride>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007954 RID: 31060
		// (get) Token: 0x0601E834 RID: 124980 RVA: 0x002D5AAC File Offset: 0x002D3CAC
		// (set) Token: 0x0601E835 RID: 124981 RVA: 0x002D5AE5 File Offset: 0x002D3CE5
		[Nullable(1)]
		public TArray<UMaterialInstanceConstant> MaterialInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._MaterialInstances) == null)
				{
					result = (this._MaterialInstances = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MaterialInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstances.CopyAssign(value);
			}
		}

		// Token: 0x17007955 RID: 31061
		// (get) Token: 0x0601E836 RID: 124982 RVA: 0x002D5AF4 File Offset: 0x002D3CF4
		// (set) Token: 0x0601E837 RID: 124983 RVA: 0x002D5B2D File Offset: 0x002D3D2D
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> MaterialInstancesDynamic
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstancesDynamic) == null)
				{
					result = (this._MaterialInstancesDynamic = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MaterialInstancesDynamic, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstancesDynamic.CopyAssign(value);
			}
		}

		// Token: 0x17007956 RID: 31062
		// (get) Token: 0x0601E838 RID: 124984 RVA: 0x002D5B3C File Offset: 0x002D3D3C
		// (set) Token: 0x0601E839 RID: 124985 RVA: 0x002D5B75 File Offset: 0x002D3D75
		[Nullable(1)]
		public TArray<sbyte> LODIndexToMaterialIndex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._LODIndexToMaterialIndex) == null)
				{
					result = (this._LODIndexToMaterialIndex = new TArray<sbyte>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_LODIndexToMaterialIndex, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LODIndexToMaterialIndex.CopyAssign(value);
			}
		}

		// Token: 0x17007957 RID: 31063
		// (get) Token: 0x0601E83A RID: 124986 RVA: 0x002D5B84 File Offset: 0x002D3D84
		// (set) Token: 0x0601E83B RID: 124987 RVA: 0x002D5BBD File Offset: 0x002D3DBD
		[Nullable(1)]
		public TArray<sbyte> MaterialIndexToDisabledTessellationMaterial
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._MaterialIndexToDisabledTessellationMaterial) == null)
				{
					result = (this._MaterialIndexToDisabledTessellationMaterial = new TArray<sbyte>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MaterialIndexToDisabledTessellationMaterial, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialIndexToDisabledTessellationMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17007958 RID: 31064
		// (get) Token: 0x0601E83C RID: 124988 RVA: 0x002D5BCB File Offset: 0x002D3DCB
		// (set) Token: 0x0601E83D RID: 124989 RVA: 0x002D5BDF File Offset: 0x002D3DDF
		public unsafe UTexture2D IndexmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexmapTexture, value);
			}
		}

		// Token: 0x17007959 RID: 31065
		// (get) Token: 0x0601E83E RID: 124990 RVA: 0x002D5BF4 File Offset: 0x002D3DF4
		// (set) Token: 0x0601E83F RID: 124991 RVA: 0x002D5C08 File Offset: 0x002D3E08
		public unsafe UTexture2D BlendmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_BlendmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_BlendmapTexture, value);
			}
		}

		// Token: 0x1700795A RID: 31066
		// (get) Token: 0x0601E840 RID: 124992 RVA: 0x002D5C1D File Offset: 0x002D3E1D
		// (set) Token: 0x0601E841 RID: 124993 RVA: 0x002D5C31 File Offset: 0x002D3E31
		public unsafe UTexture2D IndexWeightsTexture_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexWeightsTexture_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexWeightsTexture_DEPRECATED, value);
			}
		}

		// Token: 0x1700795B RID: 31067
		// (get) Token: 0x0601E842 RID: 124994 RVA: 0x002D5C46 File Offset: 0x002D3E46
		// (set) Token: 0x0601E843 RID: 124995 RVA: 0x002D5C5A File Offset: 0x002D3E5A
		public unsafe UTexture2D IndexWeightsTexture2_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexWeightsTexture2_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_IndexWeightsTexture2_DEPRECATED, value);
			}
		}

		// Token: 0x1700795C RID: 31068
		// (get) Token: 0x0601E844 RID: 124996 RVA: 0x002D5C6F File Offset: 0x002D3E6F
		// (set) Token: 0x0601E845 RID: 124997 RVA: 0x002D5C83 File Offset: 0x002D3E83
		public unsafe UTexture2D XYOffsetmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_XYOffsetmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_XYOffsetmapTexture, value);
			}
		}

		// Token: 0x1700795D RID: 31069
		// (get) Token: 0x0601E846 RID: 124998 RVA: 0x002D5C98 File Offset: 0x002D3E98
		// (set) Token: 0x0601E847 RID: 124999 RVA: 0x002D5CAC File Offset: 0x002D3EAC
		public unsafe FVector4 WeightmapScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapScaleBias) = value;
			}
		}

		// Token: 0x1700795E RID: 31070
		// (get) Token: 0x0601E848 RID: 125000 RVA: 0x002D5CC1 File Offset: 0x002D3EC1
		// (set) Token: 0x0601E849 RID: 125001 RVA: 0x002D5CD1 File Offset: 0x002D3ED1
		public unsafe float WeightmapSubsectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapSubsectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapSubsectionOffset) = value;
			}
		}

		// Token: 0x1700795F RID: 31071
		// (get) Token: 0x0601E84A RID: 125002 RVA: 0x002D5CE2 File Offset: 0x002D3EE2
		// (set) Token: 0x0601E84B RID: 125003 RVA: 0x002D5CF6 File Offset: 0x002D3EF6
		public unsafe FVector4 HeightmapScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_HeightmapScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_HeightmapScaleBias) = value;
			}
		}

		// Token: 0x17007960 RID: 31072
		// (get) Token: 0x0601E84C RID: 125004 RVA: 0x002D5D0B File Offset: 0x002D3F0B
		// (set) Token: 0x0601E84D RID: 125005 RVA: 0x002D5D1F File Offset: 0x002D3F1F
		public unsafe FBox CachedLocalBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CachedLocalBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CachedLocalBox) = value;
			}
		}

		// Token: 0x17007961 RID: 31073
		// (get) Token: 0x0601E84E RID: 125006 RVA: 0x002D5D34 File Offset: 0x002D3F34
		// (set) Token: 0x0601E84F RID: 125007 RVA: 0x002D5D48 File Offset: 0x002D3F48
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CollisionComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CollisionComponent) = value;
			}
		}

		// Token: 0x17007962 RID: 31074
		// (get) Token: 0x0601E850 RID: 125008 RVA: 0x002D5D5D File Offset: 0x002D3F5D
		// (set) Token: 0x0601E851 RID: 125009 RVA: 0x002D5D71 File Offset: 0x002D3F71
		public unsafe UTexture2D HeightmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_HeightmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_HeightmapTexture, value);
			}
		}

		// Token: 0x17007963 RID: 31075
		// (get) Token: 0x0601E852 RID: 125010 RVA: 0x002D5D88 File Offset: 0x002D3F88
		// (set) Token: 0x0601E853 RID: 125011 RVA: 0x002D5DC1 File Offset: 0x002D3FC1
		[Nullable(1)]
		public TArray<FWeightmapLayerAllocationInfo> WeightmapLayerAllocations
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FWeightmapLayerAllocationInfo> result;
				if ((result = this._WeightmapLayerAllocations) == null)
				{
					result = (this._WeightmapLayerAllocations = new TArray<FWeightmapLayerAllocationInfo>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapLayerAllocations, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WeightmapLayerAllocations.CopyAssign(value);
			}
		}

		// Token: 0x17007964 RID: 31076
		// (get) Token: 0x0601E854 RID: 125012 RVA: 0x002D5DD0 File Offset: 0x002D3FD0
		// (set) Token: 0x0601E855 RID: 125013 RVA: 0x002D5E09 File Offset: 0x002D4009
		[Nullable(1)]
		public TArray<UTexture2D> WeightmapTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._WeightmapTextures) == null)
				{
					result = (this._WeightmapTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_WeightmapTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WeightmapTextures.CopyAssign(value);
			}
		}

		// Token: 0x17007965 RID: 31077
		// (get) Token: 0x0601E856 RID: 125014 RVA: 0x002D5E17 File Offset: 0x002D4017
		// (set) Token: 0x0601E857 RID: 125015 RVA: 0x002D5E2B File Offset: 0x002D402B
		public unsafe ULandscapeLODStreamingProxy LODStreamingProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeLODStreamingProxy>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_LODStreamingProxy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_LODStreamingProxy, value);
			}
		}

		// Token: 0x17007966 RID: 31078
		// (get) Token: 0x0601E858 RID: 125016 RVA: 0x002D5E40 File Offset: 0x002D4040
		// (set) Token: 0x0601E859 RID: 125017 RVA: 0x002D5E54 File Offset: 0x002D4054
		public unsafe FGuid MapBuildDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MapBuildDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MapBuildDataId) = value;
			}
		}

		// Token: 0x17007967 RID: 31079
		// (get) Token: 0x0601E85A RID: 125018 RVA: 0x002D5E6C File Offset: 0x002D406C
		// (set) Token: 0x0601E85B RID: 125019 RVA: 0x002D5EA5 File Offset: 0x002D40A5
		[Nullable(1)]
		public TArray<FGuid> IrrelevantLights_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._IrrelevantLights_DEPRECATED) == null)
				{
					result = (this._IrrelevantLights_DEPRECATED = new TArray<FGuid>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_IrrelevantLights_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IrrelevantLights_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17007968 RID: 31080
		// (get) Token: 0x0601E85C RID: 125020 RVA: 0x002D5EB3 File Offset: 0x002D40B3
		// (set) Token: 0x0601E85D RID: 125021 RVA: 0x002D5EC3 File Offset: 0x002D40C3
		public unsafe int CollisionMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CollisionMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_CollisionMipLevel) = value;
			}
		}

		// Token: 0x17007969 RID: 31081
		// (get) Token: 0x0601E85E RID: 125022 RVA: 0x002D5ED4 File Offset: 0x002D40D4
		// (set) Token: 0x0601E85F RID: 125023 RVA: 0x002D5EE4 File Offset: 0x002D40E4
		public unsafe int SimpleCollisionMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SimpleCollisionMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SimpleCollisionMipLevel) = value;
			}
		}

		// Token: 0x1700796A RID: 31082
		// (get) Token: 0x0601E860 RID: 125024 RVA: 0x002D5EF5 File Offset: 0x002D40F5
		// (set) Token: 0x0601E861 RID: 125025 RVA: 0x002D5F05 File Offset: 0x002D4105
		public unsafe float NegativeZBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_NegativeZBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_NegativeZBoundsExtension) = value;
			}
		}

		// Token: 0x1700796B RID: 31083
		// (get) Token: 0x0601E862 RID: 125026 RVA: 0x002D5F16 File Offset: 0x002D4116
		// (set) Token: 0x0601E863 RID: 125027 RVA: 0x002D5F26 File Offset: 0x002D4126
		public unsafe float PositiveZBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_PositiveZBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_PositiveZBoundsExtension) = value;
			}
		}

		// Token: 0x1700796C RID: 31084
		// (get) Token: 0x0601E864 RID: 125028 RVA: 0x002D5F37 File Offset: 0x002D4137
		// (set) Token: 0x0601E865 RID: 125029 RVA: 0x002D5F47 File Offset: 0x002D4147
		public unsafe float StaticLightingResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_StaticLightingResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_StaticLightingResolution) = value;
			}
		}

		// Token: 0x1700796D RID: 31085
		// (get) Token: 0x0601E866 RID: 125030 RVA: 0x002D5F58 File Offset: 0x002D4158
		// (set) Token: 0x0601E867 RID: 125031 RVA: 0x002D5F68 File Offset: 0x002D4168
		public unsafe int ForcedLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_ForcedLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_ForcedLOD) = value;
			}
		}

		// Token: 0x1700796E RID: 31086
		// (get) Token: 0x0601E868 RID: 125032 RVA: 0x002D5F79 File Offset: 0x002D4179
		// (set) Token: 0x0601E869 RID: 125033 RVA: 0x002D5F89 File Offset: 0x002D4189
		public unsafe int LODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_LODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_LODBias) = value;
			}
		}

		// Token: 0x1700796F RID: 31087
		// (get) Token: 0x0601E86A RID: 125034 RVA: 0x002D5F9A File Offset: 0x002D419A
		// (set) Token: 0x0601E86B RID: 125035 RVA: 0x002D5FAA File Offset: 0x002D41AA
		public unsafe int KuroRenderingLODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_KuroRenderingLODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_KuroRenderingLODBias) = value;
			}
		}

		// Token: 0x17007970 RID: 31088
		// (get) Token: 0x0601E86C RID: 125036 RVA: 0x002D5FBB File Offset: 0x002D41BB
		// (set) Token: 0x0601E86D RID: 125037 RVA: 0x002D5FCB File Offset: 0x002D41CB
		public unsafe bool bLimitMaxKuroFOVFactorForLODCalculation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_bLimitMaxKuroFOVFactorForLODCalculation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_bLimitMaxKuroFOVFactorForLODCalculation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007971 RID: 31089
		// (get) Token: 0x0601E86E RID: 125038 RVA: 0x002D5FDC File Offset: 0x002D41DC
		// (set) Token: 0x0601E86F RID: 125039 RVA: 0x002D5FEC File Offset: 0x002D41EC
		public unsafe bool bDisableSubsectionFrustumCull
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_bDisableSubsectionFrustumCull) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_bDisableSubsectionFrustumCull) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007972 RID: 31090
		// (get) Token: 0x0601E870 RID: 125040 RVA: 0x002D5FFD File Offset: 0x002D41FD
		// (set) Token: 0x0601E871 RID: 125041 RVA: 0x002D6011 File Offset: 0x002D4211
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17007973 RID: 31091
		// (get) Token: 0x0601E872 RID: 125042 RVA: 0x002D6026 File Offset: 0x002D4226
		// (set) Token: 0x0601E873 RID: 125043 RVA: 0x002D603A File Offset: 0x002D423A
		public unsafe FGuid BakedTextureMaterialGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_BakedTextureMaterialGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_BakedTextureMaterialGuid) = value;
			}
		}

		// Token: 0x17007974 RID: 31092
		// (get) Token: 0x0601E874 RID: 125044 RVA: 0x002D604F File Offset: 0x002D424F
		// (set) Token: 0x0601E875 RID: 125045 RVA: 0x002D6063 File Offset: 0x002D4263
		public unsafe UTexture2D GIBakedBaseColorTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_GIBakedBaseColorTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_GIBakedBaseColorTexture, value);
			}
		}

		// Token: 0x17007975 RID: 31093
		// (get) Token: 0x0601E876 RID: 125046 RVA: 0x002D6078 File Offset: 0x002D4278
		// (set) Token: 0x0601E877 RID: 125047 RVA: 0x002D6088 File Offset: 0x002D4288
		public unsafe byte MobileBlendableLayerMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MobileBlendableLayerMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MobileBlendableLayerMask) = value;
			}
		}

		// Token: 0x17007976 RID: 31094
		// (get) Token: 0x0601E878 RID: 125048 RVA: 0x002D6099 File Offset: 0x002D4299
		// (set) Token: 0x0601E879 RID: 125049 RVA: 0x002D60AD File Offset: 0x002D42AD
		public unsafe UMaterialInterface MobileMaterialInterface_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_MobileMaterialInterface_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeComponent.__PropertyOffset_MobileMaterialInterface_DEPRECATED, value);
			}
		}

		// Token: 0x17007977 RID: 31095
		// (get) Token: 0x0601E87A RID: 125050 RVA: 0x002D60C4 File Offset: 0x002D42C4
		// (set) Token: 0x0601E87B RID: 125051 RVA: 0x002D60FD File Offset: 0x002D42FD
		[Nullable(1)]
		public TArray<UMaterialInterface> MobileMaterialInterfaces
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MobileMaterialInterfaces) == null)
				{
					result = (this._MobileMaterialInterfaces = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MobileMaterialInterfaces, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MobileMaterialInterfaces.CopyAssign(value);
			}
		}

		// Token: 0x17007978 RID: 31096
		// (get) Token: 0x0601E87C RID: 125052 RVA: 0x002D610C File Offset: 0x002D430C
		// (set) Token: 0x0601E87D RID: 125053 RVA: 0x002D6145 File Offset: 0x002D4345
		[Nullable(1)]
		public TArray<UTexture2D> MobileWeightmapTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._MobileWeightmapTextures) == null)
				{
					result = (this._MobileWeightmapTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_MobileWeightmapTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MobileWeightmapTextures.CopyAssign(value);
			}
		}

		// Token: 0x17007979 RID: 31097
		// (get) Token: 0x0601E87E RID: 125054 RVA: 0x002D6153 File Offset: 0x002D4353
		// (set) Token: 0x0601E87F RID: 125055 RVA: 0x002D6167 File Offset: 0x002D4367
		public unsafe FVector4 LocalHeightDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_LocalHeightDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_LocalHeightDelta) = value;
			}
		}

		// Token: 0x1700797A RID: 31098
		// (get) Token: 0x0601E880 RID: 125056 RVA: 0x002D617C File Offset: 0x002D437C
		// (set) Token: 0x0601E881 RID: 125057 RVA: 0x002D61B5 File Offset: 0x002D43B5
		[Nullable(1)]
		public TArray<FBox> SubSectionLocalBoxes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FBox> result;
				if ((result = this._SubSectionLocalBoxes) == null)
				{
					result = (this._SubSectionLocalBoxes = new TArray<FBox>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SubSectionLocalBoxes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SubSectionLocalBoxes.CopyAssign(value);
			}
		}

		// Token: 0x1700797B RID: 31099
		// (get) Token: 0x0601E882 RID: 125058 RVA: 0x002D61C4 File Offset: 0x002D43C4
		// (set) Token: 0x0601E883 RID: 125059 RVA: 0x002D61FD File Offset: 0x002D43FD
		[Nullable(1)]
		public TArray<FBox> SubSectionLocalBoxes_AllVertices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FBox> result;
				if ((result = this._SubSectionLocalBoxes_AllVertices) == null)
				{
					result = (this._SubSectionLocalBoxes_AllVertices = new TArray<FBox>(base.NativePtr + (IntPtr)ULandscapeComponent.__PropertyOffset_SubSectionLocalBoxes_AllVertices, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SubSectionLocalBoxes_AllVertices.CopyAssign(value);
			}
		}

		// Token: 0x0601E884 RID: 125060 RVA: 0x002D620C File Offset: 0x002D440C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UMaterialInstanceDynamic GetMaterialInstanceDynamic(int InIndex)
		{
			ULandscapeComponent.__GetMaterialInstanceDynamic_FunctionParams* ptr = stackalloc ULandscapeComponent.__GetMaterialInstanceDynamic_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ULandscapeComponent.__GetMaterialInstanceDynamic_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ULandscapeComponent.__GetMaterialInstanceDynamic_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InIndex = InIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ULandscapeComponent.__GetMaterialInstanceDynamic_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->__Result);
		}

		// Token: 0x0601E885 RID: 125061 RVA: 0x002D625E File Offset: 0x002D445E
		public float EditorGetPaintLayerWeightByNameAtLocation(in FVector InLocation, FName InPaintLayerName)
		{
			return ULandscapeComponent.__EditorGetPaintLayerWeightByNameAtLocation_Internal(base.NativePtr, InLocation, InPaintLayerName);
		}

		// Token: 0x0601E886 RID: 125062 RVA: 0x002D626D File Offset: 0x002D446D
		public float EditorGetPaintLayerWeightAtLocation(in FVector InLocation, ULandscapeLayerInfoObject PaintLayer)
		{
			return ULandscapeComponent.__EditorGetPaintLayerWeightAtLocation_Internal(base.NativePtr, InLocation, (PaintLayer != null) ? PaintLayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E887 RID: 125063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __EditorGetPaintLayerWeightByNameAtLocation_Internal(IntPtr @this, in FVector InLocation, FName InPaintLayerName);

		// Token: 0x0601E888 RID: 125064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __EditorGetPaintLayerWeightAtLocation_Internal(IntPtr @this, in FVector InLocation, IntPtr PaintLayer);

		// Token: 0x0601E889 RID: 125065 RVA: 0x002D628B File Offset: 0x002D448B
		static ULandscapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeComponent");
		}

		// Token: 0x0601E88A RID: 125066 RVA: 0x002D6299 File Offset: 0x002D4499
		protected ULandscapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107CA RID: 67530
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeComponent";

		// Token: 0x040107CB RID: 67531
		private static IntPtr _ClassPtr;

		// Token: 0x040107CC RID: 67532
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107CD RID: 67533
		internal static int __PropertyOffset_SectionBaseX;

		// Token: 0x040107CE RID: 67534
		internal static int __PropertyOffset_SectionBaseY;

		// Token: 0x040107CF RID: 67535
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x040107D0 RID: 67536
		internal static int __PropertyOffset_SubsectionSizeQuads;

		// Token: 0x040107D1 RID: 67537
		internal static int __PropertyOffset_NumSubsections;

		// Token: 0x040107D2 RID: 67538
		internal static int __PropertyOffset_OverrideMaterial;

		// Token: 0x040107D3 RID: 67539
		internal static int __PropertyOffset_OverrideHoleMaterial;

		// Token: 0x040107D4 RID: 67540
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x040107D5 RID: 67541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeComponentMaterialOverride> _OverrideMaterials;

		// Token: 0x040107D6 RID: 67542
		internal static int __PropertyOffset_MaterialInstances;

		// Token: 0x040107D7 RID: 67543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _MaterialInstances;

		// Token: 0x040107D8 RID: 67544
		internal static int __PropertyOffset_MaterialInstancesDynamic;

		// Token: 0x040107D9 RID: 67545
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstancesDynamic;

		// Token: 0x040107DA RID: 67546
		internal static int __PropertyOffset_LODIndexToMaterialIndex;

		// Token: 0x040107DB RID: 67547
		private TArray<sbyte> _LODIndexToMaterialIndex;

		// Token: 0x040107DC RID: 67548
		internal static int __PropertyOffset_MaterialIndexToDisabledTessellationMaterial;

		// Token: 0x040107DD RID: 67549
		private TArray<sbyte> _MaterialIndexToDisabledTessellationMaterial;

		// Token: 0x040107DE RID: 67550
		internal static int __PropertyOffset_IndexmapTexture;

		// Token: 0x040107DF RID: 67551
		internal static int __PropertyOffset_BlendmapTexture;

		// Token: 0x040107E0 RID: 67552
		internal static int __PropertyOffset_IndexWeightsTexture_DEPRECATED;

		// Token: 0x040107E1 RID: 67553
		internal static int __PropertyOffset_IndexWeightsTexture2_DEPRECATED;

		// Token: 0x040107E2 RID: 67554
		internal static int __PropertyOffset_XYOffsetmapTexture;

		// Token: 0x040107E3 RID: 67555
		internal static int __PropertyOffset_WeightmapScaleBias;

		// Token: 0x040107E4 RID: 67556
		internal static int __PropertyOffset_WeightmapSubsectionOffset;

		// Token: 0x040107E5 RID: 67557
		internal static int __PropertyOffset_HeightmapScaleBias;

		// Token: 0x040107E6 RID: 67558
		internal static int __PropertyOffset_CachedLocalBox;

		// Token: 0x040107E7 RID: 67559
		internal static int __PropertyOffset_CollisionComponent;

		// Token: 0x040107E8 RID: 67560
		internal static int __PropertyOffset_HeightmapTexture;

		// Token: 0x040107E9 RID: 67561
		internal static int __PropertyOffset_WeightmapLayerAllocations;

		// Token: 0x040107EA RID: 67562
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWeightmapLayerAllocationInfo> _WeightmapLayerAllocations;

		// Token: 0x040107EB RID: 67563
		internal static int __PropertyOffset_WeightmapTextures;

		// Token: 0x040107EC RID: 67564
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _WeightmapTextures;

		// Token: 0x040107ED RID: 67565
		internal static int __PropertyOffset_LODStreamingProxy;

		// Token: 0x040107EE RID: 67566
		internal static int __PropertyOffset_MapBuildDataId;

		// Token: 0x040107EF RID: 67567
		internal static int __PropertyOffset_IrrelevantLights_DEPRECATED;

		// Token: 0x040107F0 RID: 67568
		private TArray<FGuid> _IrrelevantLights_DEPRECATED;

		// Token: 0x040107F1 RID: 67569
		internal static int __PropertyOffset_CollisionMipLevel;

		// Token: 0x040107F2 RID: 67570
		internal static int __PropertyOffset_SimpleCollisionMipLevel;

		// Token: 0x040107F3 RID: 67571
		internal static int __PropertyOffset_NegativeZBoundsExtension;

		// Token: 0x040107F4 RID: 67572
		internal static int __PropertyOffset_PositiveZBoundsExtension;

		// Token: 0x040107F5 RID: 67573
		internal static int __PropertyOffset_StaticLightingResolution;

		// Token: 0x040107F6 RID: 67574
		internal static int __PropertyOffset_ForcedLOD;

		// Token: 0x040107F7 RID: 67575
		internal static int __PropertyOffset_LODBias;

		// Token: 0x040107F8 RID: 67576
		internal static int __PropertyOffset_KuroRenderingLODBias;

		// Token: 0x040107F9 RID: 67577
		internal static int __PropertyOffset_bLimitMaxKuroFOVFactorForLODCalculation;

		// Token: 0x040107FA RID: 67578
		internal static int __PropertyOffset_bDisableSubsectionFrustumCull;

		// Token: 0x040107FB RID: 67579
		internal static int __PropertyOffset_StateId;

		// Token: 0x040107FC RID: 67580
		internal static int __PropertyOffset_BakedTextureMaterialGuid;

		// Token: 0x040107FD RID: 67581
		internal static int __PropertyOffset_GIBakedBaseColorTexture;

		// Token: 0x040107FE RID: 67582
		internal static int __PropertyOffset_MobileBlendableLayerMask;

		// Token: 0x040107FF RID: 67583
		internal static int __PropertyOffset_MobileMaterialInterface_DEPRECATED;

		// Token: 0x04010800 RID: 67584
		internal static int __PropertyOffset_MobileMaterialInterfaces;

		// Token: 0x04010801 RID: 67585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MobileMaterialInterfaces;

		// Token: 0x04010802 RID: 67586
		internal static int __PropertyOffset_MobileWeightmapTextures;

		// Token: 0x04010803 RID: 67587
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _MobileWeightmapTextures;

		// Token: 0x04010804 RID: 67588
		internal static int __PropertyOffset_LocalHeightDelta;

		// Token: 0x04010805 RID: 67589
		internal static int __PropertyOffset_SubSectionLocalBoxes;

		// Token: 0x04010806 RID: 67590
		private TArray<FBox> _SubSectionLocalBoxes;

		// Token: 0x04010807 RID: 67591
		internal static int __PropertyOffset_SubSectionLocalBoxes_AllVertices;

		// Token: 0x04010808 RID: 67592
		private TArray<FBox> _SubSectionLocalBoxes_AllVertices;

		// Token: 0x04010809 RID: 67593
		private static IntPtr __GetMaterialInstanceDynamic_NativeFunctionPtr;

		// Token: 0x0200340D RID: 13325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMaterialInstanceDynamic_FunctionParams
		{
			// Token: 0x040173D7 RID: 95191
			[FieldOffset(0)]
			public int InIndex;

			// Token: 0x040173D8 RID: 95192
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
