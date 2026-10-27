using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002138 RID: 8504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UICustomMesh")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUICustomMesh : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602003F RID: 131135 RVA: 0x002F9B8B File Offset: 0x002F7D8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUICustomMesh._ClassPtr;
		}

		// Token: 0x06020040 RID: 131136 RVA: 0x002F9B98 File Offset: 0x002F7D98
		public UUICustomMesh() : this(BuiltinUtils.AllocNativeUObject(UUICustomMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020041 RID: 131137 RVA: 0x002F9BC0 File Offset: 0x002F7DC0
		public UUICustomMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUICustomMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DC4 RID: 32196
		// (get) Token: 0x06020042 RID: 131138 RVA: 0x002F9BF4 File Offset: 0x002F7DF4
		// (set) Token: 0x06020043 RID: 131139 RVA: 0x002F9C2D File Offset: 0x002F7E2D
		public TArray<FVector> originPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._originPositions) == null)
				{
					result = (this._originPositions = new TArray<FVector>(base.NativePtr + (IntPtr)UUICustomMesh.__PropertyOffset_originPositions, this));
				}
				return result;
			}
			set
			{
				this.originPositions.CopyAssign(value);
			}
		}

		// Token: 0x17007DC5 RID: 32197
		// (get) Token: 0x06020044 RID: 131140 RVA: 0x002F9C3C File Offset: 0x002F7E3C
		// (set) Token: 0x06020045 RID: 131141 RVA: 0x002F9C75 File Offset: 0x002F7E75
		public TArray<FVector> originNormals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._originNormals) == null)
				{
					result = (this._originNormals = new TArray<FVector>(base.NativePtr + (IntPtr)UUICustomMesh.__PropertyOffset_originNormals, this));
				}
				return result;
			}
			set
			{
				this.originNormals.CopyAssign(value);
			}
		}

		// Token: 0x17007DC6 RID: 32198
		// (get) Token: 0x06020046 RID: 131142 RVA: 0x002F9C84 File Offset: 0x002F7E84
		// (set) Token: 0x06020047 RID: 131143 RVA: 0x002F9CBD File Offset: 0x002F7EBD
		public TArray<FVector> originTangents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._originTangents) == null)
				{
					result = (this._originTangents = new TArray<FVector>(base.NativePtr + (IntPtr)UUICustomMesh.__PropertyOffset_originTangents, this));
				}
				return result;
			}
			set
			{
				this.originTangents.CopyAssign(value);
			}
		}

		// Token: 0x17007DC7 RID: 32199
		// (get) Token: 0x06020048 RID: 131144 RVA: 0x002F9CCC File Offset: 0x002F7ECC
		// (set) Token: 0x06020049 RID: 131145 RVA: 0x002F9D05 File Offset: 0x002F7F05
		public TArray<FVector2D> originUV0
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._originUV0) == null)
				{
					result = (this._originUV0 = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUICustomMesh.__PropertyOffset_originUV0, this));
				}
				return result;
			}
			set
			{
				this.originUV0.CopyAssign(value);
			}
		}

		// Token: 0x17007DC8 RID: 32200
		// (get) Token: 0x0602004A RID: 131146 RVA: 0x002F9D14 File Offset: 0x002F7F14
		// (set) Token: 0x0602004B RID: 131147 RVA: 0x002F9D4D File Offset: 0x002F7F4D
		public TArray<ushort> originTriangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._originTriangles) == null)
				{
					result = (this._originTriangles = new TArray<ushort>(base.NativePtr + (IntPtr)UUICustomMesh.__PropertyOffset_originTriangles, this));
				}
				return result;
			}
			set
			{
				this.originTriangles.CopyAssign(value);
			}
		}

		// Token: 0x17007DC9 RID: 32201
		// (get) Token: 0x0602004C RID: 131148 RVA: 0x002F9D5B File Offset: 0x002F7F5B
		// (set) Token: 0x0602004D RID: 131149 RVA: 0x002F9D6F File Offset: 0x002F7F6F
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UUICustomMesh.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUICustomMesh.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x0602004E RID: 131150 RVA: 0x002F9D84 File Offset: 0x002F7F84
		[NullableContext(2)]
		public void ReadStaticMeshData(UStaticMesh MeshComponent)
		{
			UUICustomMesh.__ReadStaticMeshData_Internal(base.NativePtr, (MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602004F RID: 131151 RVA: 0x002F9DA4 File Offset: 0x002F7FA4
		[NullableContext(2)]
		public void CreateMeshSection(int SectionIndex, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FVector2D> UV1, in TArray<FVector2D> UV2, in TArray<FVector2D> UV3, in TArray<FVector2D> UV4, in TArray<FVector2D> UV5, in TArray<FVector2D> UV6, in TArray<FVector2D> UV7, in TArray<FColor> VertexColors, in TArray<FVector> Tangents)
		{
			UUICustomMesh.__CreateMeshSection_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (UV1 ?? new TArray<FVector2D>()).NativePtr, (UV2 ?? new TArray<FVector2D>()).NativePtr, (UV3 ?? new TArray<FVector2D>()).NativePtr, (UV4 ?? new TArray<FVector2D>()).NativePtr, (UV5 ?? new TArray<FVector2D>()).NativePtr, (UV6 ?? new TArray<FVector2D>()).NativePtr, (UV7 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FColor>()).NativePtr, (Tangents ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06020050 RID: 131152 RVA: 0x002F9E98 File Offset: 0x002F8098
		public void CleanData()
		{
			UUICustomMesh.__CleanData_Internal(base.NativePtr);
		}

		// Token: 0x06020051 RID: 131153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReadStaticMeshData_Internal(IntPtr @this, IntPtr MeshComponent);

		// Token: 0x06020052 RID: 131154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateMeshSection_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UV0, IntPtr UV1, IntPtr UV2, IntPtr UV3, IntPtr UV4, IntPtr UV5, IntPtr UV6, IntPtr UV7, IntPtr VertexColors, IntPtr Tangents);

		// Token: 0x06020053 RID: 131155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanData_Internal(IntPtr @this);

		// Token: 0x06020054 RID: 131156 RVA: 0x002F9EA5 File Offset: 0x002F80A5
		static UUICustomMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UICustomMesh");
		}

		// Token: 0x06020055 RID: 131157 RVA: 0x002F9EB3 File Offset: 0x002F80B3
		protected UUICustomMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113C4 RID: 70596
		public new const string __ObjectPath = "/Script/LGUI.UICustomMesh";

		// Token: 0x040113C5 RID: 70597
		private static IntPtr _ClassPtr;

		// Token: 0x040113C6 RID: 70598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113C7 RID: 70599
		internal static int __PropertyOffset_originPositions;

		// Token: 0x040113C8 RID: 70600
		[Nullable(2)]
		private TArray<FVector> _originPositions;

		// Token: 0x040113C9 RID: 70601
		internal static int __PropertyOffset_originNormals;

		// Token: 0x040113CA RID: 70602
		[Nullable(2)]
		private TArray<FVector> _originNormals;

		// Token: 0x040113CB RID: 70603
		internal static int __PropertyOffset_originTangents;

		// Token: 0x040113CC RID: 70604
		[Nullable(2)]
		private TArray<FVector> _originTangents;

		// Token: 0x040113CD RID: 70605
		internal static int __PropertyOffset_originUV0;

		// Token: 0x040113CE RID: 70606
		[Nullable(2)]
		private TArray<FVector2D> _originUV0;

		// Token: 0x040113CF RID: 70607
		internal static int __PropertyOffset_originTriangles;

		// Token: 0x040113D0 RID: 70608
		[Nullable(2)]
		private TArray<ushort> _originTriangles;

		// Token: 0x040113D1 RID: 70609
		internal static int __PropertyOffset_StaticMesh;
	}
}
