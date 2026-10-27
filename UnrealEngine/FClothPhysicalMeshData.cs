using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000484 RID: 1156
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothPhysicalMeshData")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FClothPhysicalMeshData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E34 RID: 15924 RVA: 0x0005D81F File Offset: 0x0005BA1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothPhysicalMeshData._ScriptStructPtr != 0) ? FClothPhysicalMeshData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.ClothPhysicalMeshData", ref FClothPhysicalMeshData._ScriptStructPtr);
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003E35 RID: 15925 RVA: 0x0005D844 File Offset: 0x0005BA44
		// (set) Token: 0x06003E36 RID: 15926 RVA: 0x0005D887 File Offset: 0x0005BA87
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_Vertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003E37 RID: 15927 RVA: 0x0005D898 File Offset: 0x0005BA98
		// (set) Token: 0x06003E38 RID: 15928 RVA: 0x0005D8DB File Offset: 0x0005BADB
		public TArray<FVector> Normals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Normals) == null)
				{
					result = (this._Normals = new TArray<FVector>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_Normals, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Normals.CopyAssign(value);
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x0005D8EC File Offset: 0x0005BAEC
		// (set) Token: 0x06003E3A RID: 15930 RVA: 0x0005D92F File Offset: 0x0005BB2F
		public TArray<uint> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<uint>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_Indices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x0005D940 File Offset: 0x0005BB40
		// (set) Token: 0x06003E3C RID: 15932 RVA: 0x0005D983 File Offset: 0x0005BB83
		public TMap<uint, FPointWeightMap> WeightMaps
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, FPointWeightMap> result;
				if ((result = this._WeightMaps) == null)
				{
					result = (this._WeightMaps = new TMap<uint, FPointWeightMap>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_WeightMaps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeightMaps.CopyAssign(value);
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003E3D RID: 15933 RVA: 0x0005D994 File Offset: 0x0005BB94
		// (set) Token: 0x06003E3E RID: 15934 RVA: 0x0005D9D7 File Offset: 0x0005BBD7
		public TArray<float> InverseMasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._InverseMasses) == null)
				{
					result = (this._InverseMasses = new TArray<float>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_InverseMasses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InverseMasses.CopyAssign(value);
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x0005D9E8 File Offset: 0x0005BBE8
		// (set) Token: 0x06003E40 RID: 15936 RVA: 0x0005DA2B File Offset: 0x0005BC2B
		public TArray<FClothVertBoneData> BoneData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothVertBoneData> result;
				if ((result = this._BoneData) == null)
				{
					result = (this._BoneData = new TArray<FClothVertBoneData>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_BoneData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003E41 RID: 15937 RVA: 0x0005DA39 File Offset: 0x0005BC39
		// (set) Token: 0x06003E42 RID: 15938 RVA: 0x0005DA49 File Offset: 0x0005BC49
		public unsafe int MaxBoneWeights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_MaxBoneWeights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_MaxBoneWeights) = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06003E43 RID: 15939 RVA: 0x0005DA5A File Offset: 0x0005BC5A
		// (set) Token: 0x06003E44 RID: 15940 RVA: 0x0005DA6A File Offset: 0x0005BC6A
		public unsafe int NumFixedVerts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_NumFixedVerts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_NumFixedVerts) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		// (set) Token: 0x06003E46 RID: 15942 RVA: 0x0005DABF File Offset: 0x0005BCBF
		public TArray<uint> SelfCollisionIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._SelfCollisionIndices) == null)
				{
					result = (this._SelfCollisionIndices = new TArray<uint>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_SelfCollisionIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SelfCollisionIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x0005DB13 File Offset: 0x0005BD13
		public TArray<float> MaxDistances_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._MaxDistances_DEPRECATED) == null)
				{
					result = (this._MaxDistances_DEPRECATED = new TArray<float>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_MaxDistances_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaxDistances_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0005DB24 File Offset: 0x0005BD24
		// (set) Token: 0x06003E4A RID: 15946 RVA: 0x0005DB67 File Offset: 0x0005BD67
		public TArray<float> BackstopDistances_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BackstopDistances_DEPRECATED) == null)
				{
					result = (this._BackstopDistances_DEPRECATED = new TArray<float>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_BackstopDistances_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BackstopDistances_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x0005DB78 File Offset: 0x0005BD78
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x0005DBBB File Offset: 0x0005BDBB
		public TArray<float> BackstopRadiuses_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BackstopRadiuses_DEPRECATED) == null)
				{
					result = (this._BackstopRadiuses_DEPRECATED = new TArray<float>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_BackstopRadiuses_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BackstopRadiuses_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x0005DBCC File Offset: 0x0005BDCC
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x0005DC0F File Offset: 0x0005BE0F
		public TArray<float> AnimDriveMultipliers_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AnimDriveMultipliers_DEPRECATED) == null)
				{
					result = (this._AnimDriveMultipliers_DEPRECATED = new TArray<float>(base.NativePtr + (IntPtr)FClothPhysicalMeshData.__PropertyOffset_AnimDriveMultipliers_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimDriveMultipliers_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0005DC1D File Offset: 0x0005BE1D
		public FClothPhysicalMeshData()
		{
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0005DC28 File Offset: 0x0005BE28
		public FClothPhysicalMeshData(TArray<FVector> Vertices, TArray<FVector> Normals, TArray<FColor> VertexColors, TArray<uint> Indices, TMap<uint, FPointWeightMap> WeightMaps, TArray<float> InverseMasses, TArray<FClothVertBoneData> BoneData, int MaxBoneWeights, int NumFixedVerts, TArray<uint> SelfCollisionIndices, TArray<float> MaxDistances_DEPRECATED, TArray<float> BackstopDistances_DEPRECATED, TArray<float> BackstopRadiuses_DEPRECATED, TArray<float> AnimDriveMultipliers_DEPRECATED)
		{
			this.Vertices = Vertices;
			this.Normals = Normals;
			this.Indices = Indices;
			this.WeightMaps = WeightMaps;
			this.InverseMasses = InverseMasses;
			this.BoneData = BoneData;
			this.MaxBoneWeights = MaxBoneWeights;
			this.NumFixedVerts = NumFixedVerts;
			this.SelfCollisionIndices = SelfCollisionIndices;
			this.MaxDistances_DEPRECATED = MaxDistances_DEPRECATED;
			this.BackstopDistances_DEPRECATED = BackstopDistances_DEPRECATED;
			this.BackstopRadiuses_DEPRECATED = BackstopRadiuses_DEPRECATED;
			this.AnimDriveMultipliers_DEPRECATED = AnimDriveMultipliers_DEPRECATED;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0005DCA1 File Offset: 0x0005BEA1
		protected override IntPtr GetUStructPtr()
		{
			return FClothPhysicalMeshData.StaticStruct();
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0005DCAD File Offset: 0x0005BEAD
		[NullableContext(2)]
		public FClothPhysicalMeshData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0005DCB7 File Offset: 0x0005BEB7
		public FClothPhysicalMeshData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0005DCC2 File Offset: 0x0005BEC2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothPhysicalMeshData(Pointer, false, true);
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x0005DCCC File Offset: 0x0005BECC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothPhysicalMeshData(Pointer, MemoryOwner);
		}

		// Token: 0x04001D3F RID: 7487
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothPhysicalMeshData";

		// Token: 0x04001D40 RID: 7488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D41 RID: 7489
		internal static int __PropertyOffset_Vertices;

		// Token: 0x04001D42 RID: 7490
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x04001D43 RID: 7491
		internal static int __PropertyOffset_Normals;

		// Token: 0x04001D44 RID: 7492
		[Nullable(2)]
		private TArray<FVector> _Normals;

		// Token: 0x04001D45 RID: 7493
		internal static int __PropertyOffset_Indices;

		// Token: 0x04001D46 RID: 7494
		[Nullable(2)]
		private TArray<uint> _Indices;

		// Token: 0x04001D47 RID: 7495
		internal static int __PropertyOffset_WeightMaps;

		// Token: 0x04001D48 RID: 7496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<uint, FPointWeightMap> _WeightMaps;

		// Token: 0x04001D49 RID: 7497
		internal static int __PropertyOffset_InverseMasses;

		// Token: 0x04001D4A RID: 7498
		[Nullable(2)]
		private TArray<float> _InverseMasses;

		// Token: 0x04001D4B RID: 7499
		internal static int __PropertyOffset_BoneData;

		// Token: 0x04001D4C RID: 7500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothVertBoneData> _BoneData;

		// Token: 0x04001D4D RID: 7501
		internal static int __PropertyOffset_MaxBoneWeights;

		// Token: 0x04001D4E RID: 7502
		internal static int __PropertyOffset_NumFixedVerts;

		// Token: 0x04001D4F RID: 7503
		internal static int __PropertyOffset_SelfCollisionIndices;

		// Token: 0x04001D50 RID: 7504
		[Nullable(2)]
		private TArray<uint> _SelfCollisionIndices;

		// Token: 0x04001D51 RID: 7505
		internal static int __PropertyOffset_MaxDistances_DEPRECATED;

		// Token: 0x04001D52 RID: 7506
		[Nullable(2)]
		private TArray<float> _MaxDistances_DEPRECATED;

		// Token: 0x04001D53 RID: 7507
		internal static int __PropertyOffset_BackstopDistances_DEPRECATED;

		// Token: 0x04001D54 RID: 7508
		[Nullable(2)]
		private TArray<float> _BackstopDistances_DEPRECATED;

		// Token: 0x04001D55 RID: 7509
		internal static int __PropertyOffset_BackstopRadiuses_DEPRECATED;

		// Token: 0x04001D56 RID: 7510
		[Nullable(2)]
		private TArray<float> _BackstopRadiuses_DEPRECATED;

		// Token: 0x04001D57 RID: 7511
		internal static int __PropertyOffset_AnimDriveMultipliers_DEPRECATED;

		// Token: 0x04001D58 RID: 7512
		[Nullable(2)]
		private TArray<float> _AnimDriveMultipliers_DEPRECATED;
	}
}
