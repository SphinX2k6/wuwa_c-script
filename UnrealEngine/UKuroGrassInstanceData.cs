using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B19 RID: 6937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceData")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UKuroGrassInstanceData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A198 RID: 106904 RVA: 0x0026849A File Offset: 0x0026669A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGrassInstanceData._ClassPtr;
		}

		// Token: 0x0601A199 RID: 106905 RVA: 0x002684A8 File Offset: 0x002666A8
		public UKuroGrassInstanceData() : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInstanceData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A19A RID: 106906 RVA: 0x002684D0 File Offset: 0x002666D0
		public UKuroGrassInstanceData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInstanceData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068C8 RID: 26824
		// (get) Token: 0x0601A19B RID: 106907 RVA: 0x00268504 File Offset: 0x00266704
		// (set) Token: 0x0601A19C RID: 106908 RVA: 0x0026853D File Offset: 0x0026673D
		public TArray<FKuroGrassInstanceInfo> InstanceInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroGrassInstanceInfo> result;
				if ((result = this._InstanceInfos) == null)
				{
					result = (this._InstanceInfos = new TArray<FKuroGrassInstanceInfo>(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_InstanceInfos, this));
				}
				return result;
			}
			set
			{
				this.InstanceInfos.CopyAssign(value);
			}
		}

		// Token: 0x170068C9 RID: 26825
		// (get) Token: 0x0601A19D RID: 106909 RVA: 0x0026854B File Offset: 0x0026674B
		// (set) Token: 0x0601A19E RID: 106910 RVA: 0x00268560 File Offset: 0x00266760
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_StaticMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170068CA RID: 26826
		// (get) Token: 0x0601A19F RID: 106911 RVA: 0x00268588 File Offset: 0x00266788
		// (set) Token: 0x0601A1A0 RID: 106912 RVA: 0x002685C1 File Offset: 0x002667C1
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x170068CB RID: 26827
		// (get) Token: 0x0601A1A1 RID: 106913 RVA: 0x002685CF File Offset: 0x002667CF
		// (set) Token: 0x0601A1A2 RID: 106914 RVA: 0x002685DF File Offset: 0x002667DF
		public unsafe bool bUseCustomRandomValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_bUseCustomRandomValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_bUseCustomRandomValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CC RID: 26828
		// (get) Token: 0x0601A1A3 RID: 106915 RVA: 0x002685F0 File Offset: 0x002667F0
		// (set) Token: 0x0601A1A4 RID: 106916 RVA: 0x00268600 File Offset: 0x00266800
		public unsafe float BaseRandomValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_BaseRandomValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_BaseRandomValue) = value;
			}
		}

		// Token: 0x170068CD RID: 26829
		// (get) Token: 0x0601A1A5 RID: 106917 RVA: 0x00268611 File Offset: 0x00266811
		// (set) Token: 0x0601A1A6 RID: 106918 RVA: 0x00268625 File Offset: 0x00266825
		public unsafe FTransform SourceHISMWorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_SourceHISMWorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_SourceHISMWorldTransform) = value;
			}
		}

		// Token: 0x170068CE RID: 26830
		// (get) Token: 0x0601A1A7 RID: 106919 RVA: 0x0026863A File Offset: 0x0026683A
		// (set) Token: 0x0601A1A8 RID: 106920 RVA: 0x0026864A File Offset: 0x0026684A
		public unsafe bool bCastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_bCastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_bCastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068CF RID: 26831
		// (get) Token: 0x0601A1A9 RID: 106921 RVA: 0x0026865C File Offset: 0x0026685C
		// (set) Token: 0x0601A1AA RID: 106922 RVA: 0x00268695 File Offset: 0x00266895
		public FPerPlatformFloat FoliageDensityLowLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityLowLOD) == null)
				{
					result = (this._FoliageDensityLowLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityLowLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityLowLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068D0 RID: 26832
		// (get) Token: 0x0601A1AB RID: 106923 RVA: 0x002686B8 File Offset: 0x002668B8
		// (set) Token: 0x0601A1AC RID: 106924 RVA: 0x002686F1 File Offset: 0x002668F1
		public FPerPlatformFloat FoliageDensityMiddleLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityMiddleLOD) == null)
				{
					result = (this._FoliageDensityMiddleLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityMiddleLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityMiddleLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068D1 RID: 26833
		// (get) Token: 0x0601A1AD RID: 106925 RVA: 0x00268714 File Offset: 0x00266914
		// (set) Token: 0x0601A1AE RID: 106926 RVA: 0x0026874D File Offset: 0x0026694D
		public FPerPlatformFloat FoliageDensityHighLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityHighLOD) == null)
				{
					result = (this._FoliageDensityHighLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityHighLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityHighLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068D2 RID: 26834
		// (get) Token: 0x0601A1AF RID: 106927 RVA: 0x00268770 File Offset: 0x00266970
		// (set) Token: 0x0601A1B0 RID: 106928 RVA: 0x002687A9 File Offset: 0x002669A9
		public FPerPlatformFloat FoliageDensityScaleLODDistanceLow
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceLow) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceLow = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceLow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068D3 RID: 26835
		// (get) Token: 0x0601A1B1 RID: 106929 RVA: 0x002687CC File Offset: 0x002669CC
		// (set) Token: 0x0601A1B2 RID: 106930 RVA: 0x00268805 File Offset: 0x00266A05
		public FPerPlatformFloat FoliageDensityScaleLODDistanceMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceMiddle) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceMiddle = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170068D4 RID: 26836
		// (get) Token: 0x0601A1B3 RID: 106931 RVA: 0x00268828 File Offset: 0x00266A28
		// (set) Token: 0x0601A1B4 RID: 106932 RVA: 0x00268861 File Offset: 0x00266A61
		public FPerPlatformFloat FoliageDensityScaleLODDistanceHigh
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceHigh) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceHigh = new FPerPlatformFloat(base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGrassInstanceData.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A1B5 RID: 106933 RVA: 0x00268882 File Offset: 0x00266A82
		static UKuroGrassInstanceData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceData");
		}

		// Token: 0x0601A1B6 RID: 106934 RVA: 0x00268890 File Offset: 0x00266A90
		protected UKuroGrassInstanceData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2BD RID: 58045
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceData";

		// Token: 0x0400E2BE RID: 58046
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2BF RID: 58047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2C0 RID: 58048
		internal static int __PropertyOffset_InstanceInfos;

		// Token: 0x0400E2C1 RID: 58049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroGrassInstanceInfo> _InstanceInfos;

		// Token: 0x0400E2C2 RID: 58050
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400E2C3 RID: 58051
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400E2C4 RID: 58052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400E2C5 RID: 58053
		internal static int __PropertyOffset_bUseCustomRandomValue;

		// Token: 0x0400E2C6 RID: 58054
		internal static int __PropertyOffset_BaseRandomValue;

		// Token: 0x0400E2C7 RID: 58055
		internal static int __PropertyOffset_SourceHISMWorldTransform;

		// Token: 0x0400E2C8 RID: 58056
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x0400E2C9 RID: 58057
		internal static int __PropertyOffset_FoliageDensityLowLOD;

		// Token: 0x0400E2CA RID: 58058
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityLowLOD;

		// Token: 0x0400E2CB RID: 58059
		internal static int __PropertyOffset_FoliageDensityMiddleLOD;

		// Token: 0x0400E2CC RID: 58060
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityMiddleLOD;

		// Token: 0x0400E2CD RID: 58061
		internal static int __PropertyOffset_FoliageDensityHighLOD;

		// Token: 0x0400E2CE RID: 58062
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityHighLOD;

		// Token: 0x0400E2CF RID: 58063
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceLow;

		// Token: 0x0400E2D0 RID: 58064
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceLow;

		// Token: 0x0400E2D1 RID: 58065
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400E2D2 RID: 58066
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400E2D3 RID: 58067
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceHigh;

		// Token: 0x0400E2D4 RID: 58068
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceHigh;
	}
}
