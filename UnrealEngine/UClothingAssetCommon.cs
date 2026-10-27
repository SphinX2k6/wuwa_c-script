using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047F RID: 1151
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UClothingAssetCommon : UClothingAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003DE2 RID: 15842 RVA: 0x0005CFD1 File Offset: 0x0005B1D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingAssetCommon._ClassPtr;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x0005CFE0 File Offset: 0x0005B1E0
		public UClothingAssetCommon() : this(BuiltinUtils.AllocNativeUObject(UClothingAssetCommon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x0005D008 File Offset: 0x0005B208
		public UClothingAssetCommon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothingAssetCommon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x0005D03B File Offset: 0x0005B23B
		// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x0005D04F File Offset: 0x0005B24F
		[Nullable(2)]
		public unsafe UPhysicsAsset PhysicsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_PhysicsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_PhysicsAsset, value);
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06003DE7 RID: 15847 RVA: 0x0005D064 File Offset: 0x0005B264
		// (set) Token: 0x06003DE8 RID: 15848 RVA: 0x0005D09D File Offset: 0x0005B29D
		public TMap<FName, UClothConfigBase> ClothConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UClothConfigBase> result;
				if ((result = this._ClothConfigs) == null)
				{
					result = (this._ClothConfigs = new TMap<FName, UClothConfigBase>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ClothConfigs, this));
				}
				return result;
			}
			set
			{
				this.ClothConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x0005D0AB File Offset: 0x0005B2AB
		// (set) Token: 0x06003DEA RID: 15850 RVA: 0x0005D0BF File Offset: 0x0005B2BF
		[Nullable(2)]
		public unsafe UClothConfigBase ClothSharedSimConfig_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothConfigBase>(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ClothSharedSimConfig_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ClothSharedSimConfig_DEPRECATED, value);
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x0005D0D4 File Offset: 0x0005B2D4
		// (set) Token: 0x06003DEC RID: 15852 RVA: 0x0005D0E8 File Offset: 0x0005B2E8
		[Nullable(2)]
		public unsafe UClothConfigBase ClothSimConfig_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothConfigBase>(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ClothSimConfig_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ClothSimConfig_DEPRECATED, value);
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x0005D0FD File Offset: 0x0005B2FD
		// (set) Token: 0x06003DEE RID: 15854 RVA: 0x0005D111 File Offset: 0x0005B311
		[Nullable(2)]
		public unsafe UClothConfigBase ChaosClothSimConfig_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothConfigBase>(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ChaosClothSimConfig_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_ChaosClothSimConfig_DEPRECATED, value);
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x0005D128 File Offset: 0x0005B328
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x0005D161 File Offset: 0x0005B361
		public TArray<UClothLODDataCommon_Legacy> ClothLodData_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClothLODDataCommon_Legacy> result;
				if ((result = this._ClothLodData_DEPRECATED) == null)
				{
					result = (this._ClothLodData_DEPRECATED = new TArray<UClothLODDataCommon_Legacy>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ClothLodData_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.ClothLodData_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x0005D170 File Offset: 0x0005B370
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x0005D1A9 File Offset: 0x0005B3A9
		public TArray<FClothLODDataCommon> LodData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothLODDataCommon> result;
				if ((result = this._LodData) == null)
				{
					result = (this._LodData = new TArray<FClothLODDataCommon>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_LodData, this));
				}
				return result;
			}
			set
			{
				this.LodData.CopyAssign(value);
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x0005D1B8 File Offset: 0x0005B3B8
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x0005D1F1 File Offset: 0x0005B3F1
		public TArray<int> LodMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._LodMap) == null)
				{
					result = (this._LodMap = new TArray<int>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_LodMap, this));
				}
				return result;
			}
			set
			{
				this.LodMap.CopyAssign(value);
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x0005D200 File Offset: 0x0005B400
		// (set) Token: 0x06003DF6 RID: 15862 RVA: 0x0005D239 File Offset: 0x0005B439
		public TArray<FName> UsedBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._UsedBoneNames) == null)
				{
					result = (this._UsedBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_UsedBoneNames, this));
				}
				return result;
			}
			set
			{
				this.UsedBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x0005D248 File Offset: 0x0005B448
		// (set) Token: 0x06003DF8 RID: 15864 RVA: 0x0005D281 File Offset: 0x0005B481
		public TArray<int> UsedBoneIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._UsedBoneIndices) == null)
				{
					result = (this._UsedBoneIndices = new TArray<int>(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_UsedBoneIndices, this));
				}
				return result;
			}
			set
			{
				this.UsedBoneIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x0005D28F File Offset: 0x0005B48F
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x0005D29F File Offset: 0x0005B49F
		public unsafe int ReferenceBoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ReferenceBoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ReferenceBoneIndex) = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x0005D2B0 File Offset: 0x0005B4B0
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		[Nullable(2)]
		public unsafe UClothingAssetCustomData CustomData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothingAssetCustomData>(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_CustomData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothingAssetCommon.__PropertyOffset_CustomData, value);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x0005D2DC File Offset: 0x0005B4DC
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x0005D315 File Offset: 0x0005B515
		public FClothConfig_Legacy ClothConfig_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FClothConfig_Legacy result;
				if ((result = this._ClothConfig_DEPRECATED) == null)
				{
					result = (this._ClothConfig_DEPRECATED = new FClothConfig_Legacy(base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ClothConfig_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConfig_Legacy.StaticStruct(), base.NativePtr + (IntPtr)UClothingAssetCommon.__PropertyOffset_ClothConfig_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0005D336 File Offset: 0x0005B536
		static UClothingAssetCommon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon");
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x0005D344 File Offset: 0x0005B544
		protected UClothingAssetCommon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D0C RID: 7436
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon";

		// Token: 0x04001D0D RID: 7437
		private static IntPtr _ClassPtr;

		// Token: 0x04001D0E RID: 7438
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D0F RID: 7439
		internal static int __PropertyOffset_PhysicsAsset;

		// Token: 0x04001D10 RID: 7440
		internal static int __PropertyOffset_ClothConfigs;

		// Token: 0x04001D11 RID: 7441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UClothConfigBase> _ClothConfigs;

		// Token: 0x04001D12 RID: 7442
		internal static int __PropertyOffset_ClothSharedSimConfig_DEPRECATED;

		// Token: 0x04001D13 RID: 7443
		internal static int __PropertyOffset_ClothSimConfig_DEPRECATED;

		// Token: 0x04001D14 RID: 7444
		internal static int __PropertyOffset_ChaosClothSimConfig_DEPRECATED;

		// Token: 0x04001D15 RID: 7445
		internal static int __PropertyOffset_ClothLodData_DEPRECATED;

		// Token: 0x04001D16 RID: 7446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClothLODDataCommon_Legacy> _ClothLodData_DEPRECATED;

		// Token: 0x04001D17 RID: 7447
		internal static int __PropertyOffset_LodData;

		// Token: 0x04001D18 RID: 7448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothLODDataCommon> _LodData;

		// Token: 0x04001D19 RID: 7449
		internal static int __PropertyOffset_LodMap;

		// Token: 0x04001D1A RID: 7450
		[Nullable(2)]
		private TArray<int> _LodMap;

		// Token: 0x04001D1B RID: 7451
		internal static int __PropertyOffset_UsedBoneNames;

		// Token: 0x04001D1C RID: 7452
		[Nullable(2)]
		private TArray<FName> _UsedBoneNames;

		// Token: 0x04001D1D RID: 7453
		internal static int __PropertyOffset_UsedBoneIndices;

		// Token: 0x04001D1E RID: 7454
		[Nullable(2)]
		private TArray<int> _UsedBoneIndices;

		// Token: 0x04001D1F RID: 7455
		internal static int __PropertyOffset_ReferenceBoneIndex;

		// Token: 0x04001D20 RID: 7456
		internal static int __PropertyOffset_CustomData;

		// Token: 0x04001D21 RID: 7457
		internal static int __PropertyOffset_ClothConfig_DEPRECATED;

		// Token: 0x04001D22 RID: 7458
		[Nullable(2)]
		private FClothConfig_Legacy _ClothConfig_DEPRECATED;
	}
}
