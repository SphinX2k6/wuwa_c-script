using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001797 RID: 6039
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothDataAsset")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UKuroClothDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015C20 RID: 89120 RVA: 0x001FF6D8 File Offset: 0x001FD8D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroClothDataAsset._ClassPtr;
		}

		// Token: 0x06015C21 RID: 89121 RVA: 0x001FF6E4 File Offset: 0x001FD8E4
		public UKuroClothDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroClothDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015C22 RID: 89122 RVA: 0x001FF70C File Offset: 0x001FD90C
		public UKuroClothDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroClothDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x06015C23 RID: 89123 RVA: 0x001FF73F File Offset: 0x001FD93F
		// (set) Token: 0x06015C24 RID: 89124 RVA: 0x001FF74F File Offset: 0x001FD94F
		public unsafe int FormatVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_FormatVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_FormatVersion) = value;
			}
		}

		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x06015C25 RID: 89125 RVA: 0x001FF760 File Offset: 0x001FD960
		// (set) Token: 0x06015C26 RID: 89126 RVA: 0x001FF774 File Offset: 0x001FD974
		public unsafe string CoordinateSystem
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_CoordinateSystem)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_CoordinateSystem)), value);
			}
		}

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x06015C27 RID: 89127 RVA: 0x001FF789 File Offset: 0x001FD989
		// (set) Token: 0x06015C28 RID: 89128 RVA: 0x001FF79D File Offset: 0x001FD99D
		public unsafe string SourceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceName)), value);
			}
		}

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x06015C29 RID: 89129 RVA: 0x001FF7B2 File Offset: 0x001FD9B2
		// (set) Token: 0x06015C2A RID: 89130 RVA: 0x001FF7C6 File Offset: 0x001FD9C6
		public unsafe string SourceModelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceModelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceModelName)), value);
			}
		}

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x06015C2B RID: 89131 RVA: 0x001FF7DB File Offset: 0x001FD9DB
		// (set) Token: 0x06015C2C RID: 89132 RVA: 0x001FF7EF File Offset: 0x001FD9EF
		public unsafe string GenerationMode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_GenerationMode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroClothDataAsset.__PropertyOffset_GenerationMode)), value);
			}
		}

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x06015C2D RID: 89133 RVA: 0x001FF804 File Offset: 0x001FDA04
		// (set) Token: 0x06015C2E RID: 89134 RVA: 0x001FF83D File Offset: 0x001FDA3D
		public TArray<string> SelectedMaterialSlotNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SelectedMaterialSlotNames) == null)
				{
					result = (this._SelectedMaterialSlotNames = new TArray<string>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_SelectedMaterialSlotNames, this));
				}
				return result;
			}
			set
			{
				this.SelectedMaterialSlotNames.CopyAssign(value);
			}
		}

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x06015C2F RID: 89135 RVA: 0x001FF84B File Offset: 0x001FDA4B
		// (set) Token: 0x06015C30 RID: 89136 RVA: 0x001FF860 File Offset: 0x001FDA60
		public TSoftObjectPtr<UStaticMesh> SourceMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_SourceMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x06015C31 RID: 89137 RVA: 0x001FF885 File Offset: 0x001FDA85
		// (set) Token: 0x06015C32 RID: 89138 RVA: 0x001FF895 File Offset: 0x001FDA95
		public unsafe EKuroClothTopologyType TopologyType
		{
			get
			{
				return (EKuroClothTopologyType)(*(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_TopologyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_TopologyType) = (byte)value;
			}
		}

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x06015C33 RID: 89139 RVA: 0x001FF8A6 File Offset: 0x001FDAA6
		// (set) Token: 0x06015C34 RID: 89140 RVA: 0x001FF8B6 File Offset: 0x001FDAB6
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x06015C35 RID: 89141 RVA: 0x001FF8C7 File Offset: 0x001FDAC7
		// (set) Token: 0x06015C36 RID: 89142 RVA: 0x001FF8D7 File Offset: 0x001FDAD7
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x06015C37 RID: 89143 RVA: 0x001FF8E8 File Offset: 0x001FDAE8
		// (set) Token: 0x06015C38 RID: 89144 RVA: 0x001FF921 File Offset: 0x001FDB21
		public TArray<FKuroClothParticleData> Particles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroClothParticleData> result;
				if ((result = this._Particles) == null)
				{
					result = (this._Particles = new TArray<FKuroClothParticleData>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_Particles, this));
				}
				return result;
			}
			set
			{
				this.Particles.CopyAssign(value);
			}
		}

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x06015C39 RID: 89145 RVA: 0x001FF930 File Offset: 0x001FDB30
		// (set) Token: 0x06015C3A RID: 89146 RVA: 0x001FF969 File Offset: 0x001FDB69
		public TArray<FKuroClothDistanceConstraintData> DistanceConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroClothDistanceConstraintData> result;
				if ((result = this._DistanceConstraints) == null)
				{
					result = (this._DistanceConstraints = new TArray<FKuroClothDistanceConstraintData>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_DistanceConstraints, this));
				}
				return result;
			}
			set
			{
				this.DistanceConstraints.CopyAssign(value);
			}
		}

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x06015C3B RID: 89147 RVA: 0x001FF978 File Offset: 0x001FDB78
		// (set) Token: 0x06015C3C RID: 89148 RVA: 0x001FF9B1 File Offset: 0x001FDBB1
		public TArray<FKuroClothTriangleData> Triangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroClothTriangleData> result;
				if ((result = this._Triangles) == null)
				{
					result = (this._Triangles = new TArray<FKuroClothTriangleData>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_Triangles, this));
				}
				return result;
			}
			set
			{
				this.Triangles.CopyAssign(value);
			}
		}

		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x06015C3D RID: 89149 RVA: 0x001FF9C0 File Offset: 0x001FDBC0
		// (set) Token: 0x06015C3E RID: 89150 RVA: 0x001FF9F9 File Offset: 0x001FDBF9
		public TArray<FKuroClothDihedralConstraintData> DihedralConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroClothDihedralConstraintData> result;
				if ((result = this._DihedralConstraints) == null)
				{
					result = (this._DihedralConstraints = new TArray<FKuroClothDihedralConstraintData>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_DihedralConstraints, this));
				}
				return result;
			}
			set
			{
				this.DihedralConstraints.CopyAssign(value);
			}
		}

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x06015C3F RID: 89151 RVA: 0x001FFA08 File Offset: 0x001FDC08
		// (set) Token: 0x06015C40 RID: 89152 RVA: 0x001FFA41 File Offset: 0x001FDC41
		public FKuroClothSimulationConfig SimulationConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroClothSimulationConfig result;
				if ((result = this._SimulationConfig) == null)
				{
					result = (this._SimulationConfig = new FKuroClothSimulationConfig(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_SimulationConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroClothSimulationConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_SimulationConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x06015C41 RID: 89153 RVA: 0x001FFA64 File Offset: 0x001FDC64
		// (set) Token: 0x06015C42 RID: 89154 RVA: 0x001FFA9D File Offset: 0x001FDC9D
		public FKuroClothWilsonResponse WilsonResponse
		{
			get
			{
				base.FastCheckIsValid();
				FKuroClothWilsonResponse result;
				if ((result = this._WilsonResponse) == null)
				{
					result = (this._WilsonResponse = new FKuroClothWilsonResponse(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_WilsonResponse, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroClothWilsonResponse.StaticStruct(), base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_WilsonResponse, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x06015C43 RID: 89155 RVA: 0x001FFAC0 File Offset: 0x001FDCC0
		// (set) Token: 0x06015C44 RID: 89156 RVA: 0x001FFAF9 File Offset: 0x001FDCF9
		public TArray<FKuroClothLocalCollider> LocalColliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroClothLocalCollider> result;
				if ((result = this._LocalColliders) == null)
				{
					result = (this._LocalColliders = new TArray<FKuroClothLocalCollider>(base.NativePtr + (IntPtr)UKuroClothDataAsset.__PropertyOffset_LocalColliders, this));
				}
				return result;
			}
			set
			{
				this.LocalColliders.CopyAssign(value);
			}
		}

		// Token: 0x06015C45 RID: 89157 RVA: 0x001FFB07 File Offset: 0x001FDD07
		static UKuroClothDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroClothDataAsset");
		}

		// Token: 0x06015C46 RID: 89158 RVA: 0x001FFB15 File Offset: 0x001FDD15
		protected UKuroClothDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BDF9 RID: 48633
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroClothDataAsset";

		// Token: 0x0400BDFA RID: 48634
		private static IntPtr _ClassPtr;

		// Token: 0x0400BDFB RID: 48635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BDFC RID: 48636
		internal static int __PropertyOffset_FormatVersion;

		// Token: 0x0400BDFD RID: 48637
		internal static int __PropertyOffset_CoordinateSystem;

		// Token: 0x0400BDFE RID: 48638
		internal static int __PropertyOffset_SourceName;

		// Token: 0x0400BDFF RID: 48639
		internal static int __PropertyOffset_SourceModelName;

		// Token: 0x0400BE00 RID: 48640
		internal static int __PropertyOffset_GenerationMode;

		// Token: 0x0400BE01 RID: 48641
		internal static int __PropertyOffset_SelectedMaterialSlotNames;

		// Token: 0x0400BE02 RID: 48642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SelectedMaterialSlotNames;

		// Token: 0x0400BE03 RID: 48643
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400BE04 RID: 48644
		internal static int __PropertyOffset_TopologyType;

		// Token: 0x0400BE05 RID: 48645
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BE06 RID: 48646
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400BE07 RID: 48647
		internal static int __PropertyOffset_Particles;

		// Token: 0x0400BE08 RID: 48648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroClothParticleData> _Particles;

		// Token: 0x0400BE09 RID: 48649
		internal static int __PropertyOffset_DistanceConstraints;

		// Token: 0x0400BE0A RID: 48650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroClothDistanceConstraintData> _DistanceConstraints;

		// Token: 0x0400BE0B RID: 48651
		internal static int __PropertyOffset_Triangles;

		// Token: 0x0400BE0C RID: 48652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroClothTriangleData> _Triangles;

		// Token: 0x0400BE0D RID: 48653
		internal static int __PropertyOffset_DihedralConstraints;

		// Token: 0x0400BE0E RID: 48654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroClothDihedralConstraintData> _DihedralConstraints;

		// Token: 0x0400BE0F RID: 48655
		internal static int __PropertyOffset_SimulationConfig;

		// Token: 0x0400BE10 RID: 48656
		[Nullable(2)]
		private FKuroClothSimulationConfig _SimulationConfig;

		// Token: 0x0400BE11 RID: 48657
		internal static int __PropertyOffset_WilsonResponse;

		// Token: 0x0400BE12 RID: 48658
		[Nullable(2)]
		private FKuroClothWilsonResponse _WilsonResponse;

		// Token: 0x0400BE13 RID: 48659
		internal static int __PropertyOffset_LocalColliders;

		// Token: 0x0400BE14 RID: 48660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroClothLocalCollider> _LocalColliders;
	}
}
