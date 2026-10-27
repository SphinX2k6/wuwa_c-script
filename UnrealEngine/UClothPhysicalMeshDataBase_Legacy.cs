using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000492 RID: 1170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothPhysicalMeshDataBase_Legacy")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UClothPhysicalMeshDataBase_Legacy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x0005E5D9 File Offset: 0x0005C7D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothPhysicalMeshDataBase_Legacy._ClassPtr;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0005E5E8 File Offset: 0x0005C7E8
		public UClothPhysicalMeshDataBase_Legacy() : this(BuiltinUtils.AllocNativeUObject(UClothPhysicalMeshDataBase_Legacy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0005E610 File Offset: 0x0005C810
		public UClothPhysicalMeshDataBase_Legacy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothPhysicalMeshDataBase_Legacy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06003ED7 RID: 16087 RVA: 0x0005E644 File Offset: 0x0005C844
		// (set) Token: 0x06003ED8 RID: 16088 RVA: 0x0005E67D File Offset: 0x0005C87D
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x0005E68C File Offset: 0x0005C88C
		// (set) Token: 0x06003EDA RID: 16090 RVA: 0x0005E6C5 File Offset: 0x0005C8C5
		public TArray<FVector> Normals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Normals) == null)
				{
					result = (this._Normals = new TArray<FVector>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_Normals, this));
				}
				return result;
			}
			set
			{
				this.Normals.CopyAssign(value);
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x0005E70D File Offset: 0x0005C90D
		public TArray<uint> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<uint>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_Indices, this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x0005E71C File Offset: 0x0005C91C
		// (set) Token: 0x06003EDE RID: 16094 RVA: 0x0005E755 File Offset: 0x0005C955
		public TArray<float> InverseMasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._InverseMasses) == null)
				{
					result = (this._InverseMasses = new TArray<float>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_InverseMasses, this));
				}
				return result;
			}
			set
			{
				this.InverseMasses.CopyAssign(value);
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x0005E764 File Offset: 0x0005C964
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x0005E79D File Offset: 0x0005C99D
		public TArray<FClothVertBoneData> BoneData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothVertBoneData> result;
				if ((result = this._BoneData) == null)
				{
					result = (this._BoneData = new TArray<FClothVertBoneData>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_BoneData, this));
				}
				return result;
			}
			set
			{
				this.BoneData.CopyAssign(value);
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x0005E7AB File Offset: 0x0005C9AB
		// (set) Token: 0x06003EE2 RID: 16098 RVA: 0x0005E7BB File Offset: 0x0005C9BB
		public unsafe int NumFixedVerts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_NumFixedVerts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_NumFixedVerts) = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x0005E7CC File Offset: 0x0005C9CC
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x0005E7DC File Offset: 0x0005C9DC
		public unsafe int MaxBoneWeights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_MaxBoneWeights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_MaxBoneWeights) = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06003EE5 RID: 16101 RVA: 0x0005E7F0 File Offset: 0x0005C9F0
		// (set) Token: 0x06003EE6 RID: 16102 RVA: 0x0005E829 File Offset: 0x0005CA29
		public TArray<uint> SelfCollisionIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._SelfCollisionIndices) == null)
				{
					result = (this._SelfCollisionIndices = new TArray<uint>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataBase_Legacy.__PropertyOffset_SelfCollisionIndices, this));
				}
				return result;
			}
			set
			{
				this.SelfCollisionIndices.CopyAssign(value);
			}
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0005E837 File Offset: 0x0005CA37
		static UClothPhysicalMeshDataBase_Legacy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothPhysicalMeshDataBase_Legacy");
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0005E845 File Offset: 0x0005CA45
		protected UClothPhysicalMeshDataBase_Legacy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D99 RID: 7577
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothPhysicalMeshDataBase_Legacy";

		// Token: 0x04001D9A RID: 7578
		private static IntPtr _ClassPtr;

		// Token: 0x04001D9B RID: 7579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D9C RID: 7580
		internal static int __PropertyOffset_Vertices;

		// Token: 0x04001D9D RID: 7581
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x04001D9E RID: 7582
		internal static int __PropertyOffset_Normals;

		// Token: 0x04001D9F RID: 7583
		[Nullable(2)]
		private TArray<FVector> _Normals;

		// Token: 0x04001DA0 RID: 7584
		internal static int __PropertyOffset_Indices;

		// Token: 0x04001DA1 RID: 7585
		[Nullable(2)]
		private TArray<uint> _Indices;

		// Token: 0x04001DA2 RID: 7586
		internal static int __PropertyOffset_InverseMasses;

		// Token: 0x04001DA3 RID: 7587
		[Nullable(2)]
		private TArray<float> _InverseMasses;

		// Token: 0x04001DA4 RID: 7588
		internal static int __PropertyOffset_BoneData;

		// Token: 0x04001DA5 RID: 7589
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothVertBoneData> _BoneData;

		// Token: 0x04001DA6 RID: 7590
		internal static int __PropertyOffset_NumFixedVerts;

		// Token: 0x04001DA7 RID: 7591
		internal static int __PropertyOffset_MaxBoneWeights;

		// Token: 0x04001DA8 RID: 7592
		internal static int __PropertyOffset_SelfCollisionIndices;

		// Token: 0x04001DA9 RID: 7593
		[Nullable(2)]
		private TArray<uint> _SelfCollisionIndices;
	}
}
