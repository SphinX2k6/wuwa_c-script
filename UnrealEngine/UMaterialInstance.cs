using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E89 RID: 3721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialInstance")]
	[UnrealStructLayout(1864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1864)]
	public abstract class UMaterialInstance : UMaterialInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C690 RID: 50832 RVA: 0x0011FB2F File Offset: 0x0011DD2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstance._ClassPtr;
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600C691 RID: 50833 RVA: 0x0011FB3B File Offset: 0x0011DD3B
		// (set) Token: 0x0600C692 RID: 50834 RVA: 0x0011FB4F File Offset: 0x0011DD4F
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600C693 RID: 50835 RVA: 0x0011FB64 File Offset: 0x0011DD64
		// (set) Token: 0x0600C694 RID: 50836 RVA: 0x0011FB9E File Offset: 0x0011DD9E
		public TFixedArray<UPhysicalMaterial> PhysicalMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterialMap) == null)
				{
					result = (this._PhysicalMaterialMap = new TFixedArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_PhysicalMaterialMap, 8, this));
				}
				return result;
			}
			set
			{
				this.PhysicalMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600C695 RID: 50837 RVA: 0x0011FBAC File Offset: 0x0011DDAC
		// (set) Token: 0x0600C696 RID: 50838 RVA: 0x0011FBC0 File Offset: 0x0011DDC0
		[Nullable(2)]
		public unsafe UMaterialInterface Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600C697 RID: 50839 RVA: 0x0011FBD5 File Offset: 0x0011DDD5
		// (set) Token: 0x0600C698 RID: 50840 RVA: 0x0011FBEE File Offset: 0x0011DDEE
		public unsafe bool bHasStaticPermutationResource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) & UMaterialInstance.__PropertyMask_bHasStaticPermutationResource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) = ((*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) & ~UMaterialInstance.__PropertyMask_bHasStaticPermutationResource) | (value ? UMaterialInstance.__PropertyMask_bHasStaticPermutationResource : 0));
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600C699 RID: 50841 RVA: 0x0011FC1E File Offset: 0x0011DE1E
		// (set) Token: 0x0600C69A RID: 50842 RVA: 0x0011FC37 File Offset: 0x0011DE37
		public unsafe bool bOverrideSubsurfaceProfile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) & UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) = ((*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) & ~UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile) | (value ? UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile : 0));
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600C69B RID: 50843 RVA: 0x0011FC68 File Offset: 0x0011DE68
		// (set) Token: 0x0600C69C RID: 50844 RVA: 0x0011FCA1 File Offset: 0x0011DEA1
		public TArray<FScalarParameterValue> ScalarParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FScalarParameterValue> result;
				if ((result = this._ScalarParameterValues) == null)
				{
					result = (this._ScalarParameterValues = new TArray<FScalarParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_ScalarParameterValues, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600C69D RID: 50845 RVA: 0x0011FCB0 File Offset: 0x0011DEB0
		// (set) Token: 0x0600C69E RID: 50846 RVA: 0x0011FCE9 File Offset: 0x0011DEE9
		public TArray<FVectorParameterValue> VectorParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorParameterValue> result;
				if ((result = this._VectorParameterValues) == null)
				{
					result = (this._VectorParameterValues = new TArray<FVectorParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_VectorParameterValues, this));
				}
				return result;
			}
			set
			{
				this.VectorParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600C69F RID: 50847 RVA: 0x0011FCF8 File Offset: 0x0011DEF8
		// (set) Token: 0x0600C6A0 RID: 50848 RVA: 0x0011FD31 File Offset: 0x0011DF31
		public TArray<FTextureParameterValue> TextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTextureParameterValue> result;
				if ((result = this._TextureParameterValues) == null)
				{
					result = (this._TextureParameterValues = new TArray<FTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_TextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.TextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600C6A1 RID: 50849 RVA: 0x0011FD40 File Offset: 0x0011DF40
		// (set) Token: 0x0600C6A2 RID: 50850 RVA: 0x0011FD79 File Offset: 0x0011DF79
		public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimeVirtualTextureParameterValue> result;
				if ((result = this._RuntimeVirtualTextureParameterValues) == null)
				{
					result = (this._RuntimeVirtualTextureParameterValues = new TArray<FRuntimeVirtualTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_RuntimeVirtualTextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600C6A3 RID: 50851 RVA: 0x0011FD88 File Offset: 0x0011DF88
		// (set) Token: 0x0600C6A4 RID: 50852 RVA: 0x0011FDC1 File Offset: 0x0011DFC1
		public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSparseVolumeTextureParameterValue> result;
				if ((result = this._SparseVolumeTextureParameterValues) == null)
				{
					result = (this._SparseVolumeTextureParameterValues = new TArray<FSparseVolumeTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_SparseVolumeTextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.SparseVolumeTextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600C6A5 RID: 50853 RVA: 0x0011FDD0 File Offset: 0x0011DFD0
		// (set) Token: 0x0600C6A6 RID: 50854 RVA: 0x0011FE09 File Offset: 0x0011E009
		public TArray<FFontParameterValue> FontParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFontParameterValue> result;
				if ((result = this._FontParameterValues) == null)
				{
					result = (this._FontParameterValues = new TArray<FFontParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_FontParameterValues, this));
				}
				return result;
			}
			set
			{
				this.FontParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600C6A7 RID: 50855 RVA: 0x0011FE18 File Offset: 0x0011E018
		// (set) Token: 0x0600C6A8 RID: 50856 RVA: 0x0011FE51 File Offset: 0x0011E051
		public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialInstanceBasePropertyOverrides result;
				if ((result = this._BasePropertyOverrides) == null)
				{
					result = (this._BasePropertyOverrides = new FMaterialInstanceBasePropertyOverrides(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_BasePropertyOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialInstanceBasePropertyOverrides.StaticStruct(), base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_BasePropertyOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600C6A9 RID: 50857 RVA: 0x0011FE74 File Offset: 0x0011E074
		// (set) Token: 0x0600C6AA RID: 50858 RVA: 0x0011FEAD File Offset: 0x0011E0AD
		public FStaticParameterSet StaticParameters
		{
			get
			{
				base.FastCheckIsValid();
				FStaticParameterSet result;
				if ((result = this._StaticParameters) == null)
				{
					result = (this._StaticParameters = new FStaticParameterSet(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_StaticParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStaticParameterSet.StaticStruct(), base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_StaticParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600C6AB RID: 50859 RVA: 0x0011FED0 File Offset: 0x0011E0D0
		// (set) Token: 0x0600C6AC RID: 50860 RVA: 0x0011FF09 File Offset: 0x0011E109
		public FMaterialCachedParameters CachedLayerParameters
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialCachedParameters result;
				if ((result = this._CachedLayerParameters) == null)
				{
					result = (this._CachedLayerParameters = new FMaterialCachedParameters(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CachedLayerParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialCachedParameters.StaticStruct(), base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CachedLayerParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600C6AD RID: 50861 RVA: 0x0011FF2A File Offset: 0x0011E12A
		// (set) Token: 0x0600C6AE RID: 50862 RVA: 0x0011FF3A File Offset: 0x0011E13A
		public unsafe int SubMaterialCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_SubMaterialCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_SubMaterialCount) = value;
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600C6AF RID: 50863 RVA: 0x0011FF4B File Offset: 0x0011E14B
		// (set) Token: 0x0600C6B0 RID: 50864 RVA: 0x0011FF5F File Offset: 0x0011E15F
		public unsafe FIntPoint CombineAtlasSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CombineAtlasSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CombineAtlasSize) = value;
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600C6B1 RID: 50865 RVA: 0x0011FF74 File Offset: 0x0011E174
		// (set) Token: 0x0600C6B2 RID: 50866 RVA: 0x0011FFAD File Offset: 0x0011E1AD
		public TArray<int> ScalarParameterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ScalarParameterOffsets) == null)
				{
					result = (this._ScalarParameterOffsets = new TArray<int>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_ScalarParameterOffsets, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600C6B3 RID: 50867 RVA: 0x0011FFBC File Offset: 0x0011E1BC
		// (set) Token: 0x0600C6B4 RID: 50868 RVA: 0x0011FFF5 File Offset: 0x0011E1F5
		public TArray<int> VectorParameterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._VectorParameterOffsets) == null)
				{
					result = (this._VectorParameterOffsets = new TArray<int>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_VectorParameterOffsets, this));
				}
				return result;
			}
			set
			{
				this.VectorParameterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600C6B5 RID: 50869 RVA: 0x00120004 File Offset: 0x0011E204
		// (set) Token: 0x0600C6B6 RID: 50870 RVA: 0x0012003D File Offset: 0x0011E23D
		public TArray<FVector4> UVScaleOffsetInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._UVScaleOffsetInfos) == null)
				{
					result = (this._UVScaleOffsetInfos = new TArray<FVector4>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UVScaleOffsetInfos, this));
				}
				return result;
			}
			set
			{
				this.UVScaleOffsetInfos.CopyAssign(value);
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x0012004B File Offset: 0x0011E24B
		// (set) Token: 0x0600C6B8 RID: 50872 RVA: 0x0012005B File Offset: 0x0011E25B
		public unsafe uint UsageFlagWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UsageFlagWarnings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UsageFlagWarnings) = (int)value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x0012006C File Offset: 0x0011E26C
		// (set) Token: 0x0600C6BA RID: 50874 RVA: 0x001200A5 File Offset: 0x0011E2A5
		public TArray<UObject> CachedReferencedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._CachedReferencedTextures) == null)
				{
					result = (this._CachedReferencedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CachedReferencedTextures, this));
				}
				return result;
			}
			set
			{
				this.CachedReferencedTextures.CopyAssign(value);
			}
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x001200B3 File Offset: 0x0011E2B3
		static UMaterialInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstance");
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x001200C4 File Offset: 0x0011E2C4
		protected UMaterialInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x001200EC File Offset: 0x0011E2EC
		protected UMaterialInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A4F RID: 27215
		public new const string __ObjectPath = "/Script/Engine.MaterialInstance";

		// Token: 0x04006A50 RID: 27216
		private static IntPtr _ClassPtr;

		// Token: 0x04006A51 RID: 27217
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A52 RID: 27218
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04006A53 RID: 27219
		internal static int __PropertyOffset_PhysicalMaterialMap;

		// Token: 0x04006A54 RID: 27220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UPhysicalMaterial> _PhysicalMaterialMap;

		// Token: 0x04006A55 RID: 27221
		internal static int __PropertyOffset_Parent;

		// Token: 0x04006A56 RID: 27222
		internal static int __PropertyOffset_bHasStaticPermutationResource;

		// Token: 0x04006A57 RID: 27223
		internal static byte __PropertyMask_bHasStaticPermutationResource;

		// Token: 0x04006A58 RID: 27224
		internal static int __PropertyOffset_bOverrideSubsurfaceProfile;

		// Token: 0x04006A59 RID: 27225
		internal static byte __PropertyMask_bOverrideSubsurfaceProfile;

		// Token: 0x04006A5A RID: 27226
		internal static int __PropertyOffset_ScalarParameterValues;

		// Token: 0x04006A5B RID: 27227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FScalarParameterValue> _ScalarParameterValues;

		// Token: 0x04006A5C RID: 27228
		internal static int __PropertyOffset_VectorParameterValues;

		// Token: 0x04006A5D RID: 27229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVectorParameterValue> _VectorParameterValues;

		// Token: 0x04006A5E RID: 27230
		internal static int __PropertyOffset_TextureParameterValues;

		// Token: 0x04006A5F RID: 27231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTextureParameterValue> _TextureParameterValues;

		// Token: 0x04006A60 RID: 27232
		internal static int __PropertyOffset_RuntimeVirtualTextureParameterValues;

		// Token: 0x04006A61 RID: 27233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimeVirtualTextureParameterValue> _RuntimeVirtualTextureParameterValues;

		// Token: 0x04006A62 RID: 27234
		internal static int __PropertyOffset_SparseVolumeTextureParameterValues;

		// Token: 0x04006A63 RID: 27235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSparseVolumeTextureParameterValue> _SparseVolumeTextureParameterValues;

		// Token: 0x04006A64 RID: 27236
		internal static int __PropertyOffset_FontParameterValues;

		// Token: 0x04006A65 RID: 27237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFontParameterValue> _FontParameterValues;

		// Token: 0x04006A66 RID: 27238
		internal static int __PropertyOffset_BasePropertyOverrides;

		// Token: 0x04006A67 RID: 27239
		[Nullable(2)]
		private FMaterialInstanceBasePropertyOverrides _BasePropertyOverrides;

		// Token: 0x04006A68 RID: 27240
		internal static int __PropertyOffset_StaticParameters;

		// Token: 0x04006A69 RID: 27241
		[Nullable(2)]
		private FStaticParameterSet _StaticParameters;

		// Token: 0x04006A6A RID: 27242
		internal static int __PropertyOffset_CachedLayerParameters;

		// Token: 0x04006A6B RID: 27243
		[Nullable(2)]
		private FMaterialCachedParameters _CachedLayerParameters;

		// Token: 0x04006A6C RID: 27244
		internal static int __PropertyOffset_SubMaterialCount;

		// Token: 0x04006A6D RID: 27245
		internal static int __PropertyOffset_CombineAtlasSize;

		// Token: 0x04006A6E RID: 27246
		internal static int __PropertyOffset_ScalarParameterOffsets;

		// Token: 0x04006A6F RID: 27247
		[Nullable(2)]
		private TArray<int> _ScalarParameterOffsets;

		// Token: 0x04006A70 RID: 27248
		internal static int __PropertyOffset_VectorParameterOffsets;

		// Token: 0x04006A71 RID: 27249
		[Nullable(2)]
		private TArray<int> _VectorParameterOffsets;

		// Token: 0x04006A72 RID: 27250
		internal static int __PropertyOffset_UVScaleOffsetInfos;

		// Token: 0x04006A73 RID: 27251
		[Nullable(2)]
		private TArray<FVector4> _UVScaleOffsetInfos;

		// Token: 0x04006A74 RID: 27252
		internal static int __PropertyOffset_UsageFlagWarnings;

		// Token: 0x04006A75 RID: 27253
		internal static int __PropertyOffset_CachedReferencedTextures;

		// Token: 0x04006A76 RID: 27254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CachedReferencedTextures;
	}
}
