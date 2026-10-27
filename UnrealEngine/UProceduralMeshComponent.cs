using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200265C RID: 9820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.ProceduralMeshComponent")]
	[UnrealStructLayout(1728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1728)]
	public class UProceduralMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060247DE RID: 149470 RVA: 0x0036062E File Offset: 0x0035E82E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProceduralMeshComponent._ClassPtr;
		}

		// Token: 0x060247DF RID: 149471 RVA: 0x0036063A File Offset: 0x0035E83A
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UProceduralMeshComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x060247E0 RID: 149472 RVA: 0x00360644 File Offset: 0x0035E844
		public UProceduralMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UProceduralMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247E1 RID: 149473 RVA: 0x0036066C File Offset: 0x0035E86C
		public UProceduralMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProceduralMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008CA5 RID: 36005
		// (get) Token: 0x060247E2 RID: 149474 RVA: 0x0036069F File Offset: 0x0035E89F
		// (set) Token: 0x060247E3 RID: 149475 RVA: 0x003606AF File Offset: 0x0035E8AF
		public unsafe bool bUseComplexAsSimpleCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseComplexAsSimpleCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseComplexAsSimpleCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CA6 RID: 36006
		// (get) Token: 0x060247E4 RID: 149476 RVA: 0x003606C0 File Offset: 0x0035E8C0
		// (set) Token: 0x060247E5 RID: 149477 RVA: 0x003606D0 File Offset: 0x0035E8D0
		public unsafe bool bUseAsyncCooking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseAsyncCooking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_bUseAsyncCooking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CA7 RID: 36007
		// (get) Token: 0x060247E6 RID: 149478 RVA: 0x003606E1 File Offset: 0x0035E8E1
		// (set) Token: 0x060247E7 RID: 149479 RVA: 0x003606F5 File Offset: 0x0035E8F5
		[Nullable(2)]
		public unsafe UBodySetup ProcMeshBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralMeshComponent.__PropertyOffset_ProcMeshBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralMeshComponent.__PropertyOffset_ProcMeshBodySetup, value);
			}
		}

		// Token: 0x17008CA8 RID: 36008
		// (get) Token: 0x060247E8 RID: 149480 RVA: 0x0036070C File Offset: 0x0035E90C
		// (set) Token: 0x060247E9 RID: 149481 RVA: 0x00360745 File Offset: 0x0035E945
		public TArray<FProcMeshSection> ProcMeshSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FProcMeshSection> result;
				if ((result = this._ProcMeshSections) == null)
				{
					result = (this._ProcMeshSections = new TArray<FProcMeshSection>(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_ProcMeshSections, this));
				}
				return result;
			}
			set
			{
				this.ProcMeshSections.CopyAssign(value);
			}
		}

		// Token: 0x17008CA9 RID: 36009
		// (get) Token: 0x060247EA RID: 149482 RVA: 0x00360754 File Offset: 0x0035E954
		// (set) Token: 0x060247EB RID: 149483 RVA: 0x0036078D File Offset: 0x0035E98D
		public TArray<FKConvexElem> CollisionConvexElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKConvexElem> result;
				if ((result = this._CollisionConvexElems) == null)
				{
					result = (this._CollisionConvexElems = new TArray<FKConvexElem>(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_CollisionConvexElems, this));
				}
				return result;
			}
			set
			{
				this.CollisionConvexElems.CopyAssign(value);
			}
		}

		// Token: 0x17008CAA RID: 36010
		// (get) Token: 0x060247EC RID: 149484 RVA: 0x0036079B File Offset: 0x0035E99B
		// (set) Token: 0x060247ED RID: 149485 RVA: 0x003607AF File Offset: 0x0035E9AF
		public unsafe FBoxSphereBounds LocalBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_LocalBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_LocalBounds) = value;
			}
		}

		// Token: 0x17008CAB RID: 36011
		// (get) Token: 0x060247EE RID: 149486 RVA: 0x003607C4 File Offset: 0x0035E9C4
		// (set) Token: 0x060247EF RID: 149487 RVA: 0x003607FD File Offset: 0x0035E9FD
		public TArray<UBodySetup> AsyncBodySetupQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._AsyncBodySetupQueue) == null)
				{
					result = (this._AsyncBodySetupQueue = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UProceduralMeshComponent.__PropertyOffset_AsyncBodySetupQueue, this));
				}
				return result;
			}
			set
			{
				this.AsyncBodySetupQueue.CopyAssign(value);
			}
		}

		// Token: 0x060247F0 RID: 149488 RVA: 0x0036080C File Offset: 0x0035EA0C
		[NullableContext(2)]
		public void UpdateMeshSection_LinearColor(int SectionIndex, in TArray<FVector> Vertices, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FVector2D> UV1, in TArray<FVector2D> UV2, in TArray<FVector2D> UV3, in TArray<FLinearColor> VertexColors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FProcMeshTangent> Tangents)
		{
			UProceduralMeshComponent.__UpdateMeshSection_LinearColor_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (UV1 ?? new TArray<FVector2D>()).NativePtr, (UV2 ?? new TArray<FVector2D>()).NativePtr, (UV3 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FLinearColor>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247F1 RID: 149489 RVA: 0x003608AC File Offset: 0x0035EAAC
		[NullableContext(2)]
		public void UpdateMeshSection(int SectionIndex, in TArray<FVector> Vertices, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FColor> VertexColors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FProcMeshTangent> Tangents)
		{
			UProceduralMeshComponent.__UpdateMeshSection_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FColor>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247F2 RID: 149490 RVA: 0x00360918 File Offset: 0x0035EB18
		public void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)
		{
			UProceduralMeshComponent.__SetMeshSectionVisible_Internal(base.NativePtr, SectionIndex, bNewVisibility);
		}

		// Token: 0x060247F3 RID: 149491 RVA: 0x00360928 File Offset: 0x0035EB28
		[NullableContext(2)]
		public void KuroCreateMeshSection(int SectionIndex, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FVector2D> UV1, in TArray<FVector2D> UV2, in TArray<FVector2D> UV3, in TArray<FVector2D> UV4, in TArray<FVector2D> UV5, in TArray<FVector2D> UV6, in TArray<FVector2D> UV7, in TArray<FColor> VertexColors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
		{
			UProceduralMeshComponent.__KuroCreateMeshSection_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (UV1 ?? new TArray<FVector2D>()).NativePtr, (UV2 ?? new TArray<FVector2D>()).NativePtr, (UV3 ?? new TArray<FVector2D>()).NativePtr, (UV4 ?? new TArray<FVector2D>()).NativePtr, (UV5 ?? new TArray<FVector2D>()).NativePtr, (UV6 ?? new TArray<FVector2D>()).NativePtr, (UV7 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FColor>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr, bCreateCollision);
		}

		// Token: 0x060247F4 RID: 149492 RVA: 0x00360A1E File Offset: 0x0035EC1E
		public bool IsMeshSectionVisible(int SectionIndex)
		{
			return UProceduralMeshComponent.__IsMeshSectionVisible_Internal(base.NativePtr, SectionIndex);
		}

		// Token: 0x060247F5 RID: 149493 RVA: 0x00360A2C File Offset: 0x0035EC2C
		public int GetNumSections()
		{
			return UProceduralMeshComponent.__GetNumSections_Internal(base.NativePtr);
		}

		// Token: 0x060247F6 RID: 149494 RVA: 0x00360A3C File Offset: 0x0035EC3C
		[NullableContext(2)]
		public void CreateMeshSection_LinearColor(int SectionIndex, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FVector2D> UV1, in TArray<FVector2D> UV2, in TArray<FVector2D> UV3, in TArray<FLinearColor> VertexColors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
		{
			UProceduralMeshComponent.__CreateMeshSection_LinearColor_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (UV1 ?? new TArray<FVector2D>()).NativePtr, (UV2 ?? new TArray<FVector2D>()).NativePtr, (UV3 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FLinearColor>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr, bCreateCollision);
		}

		// Token: 0x060247F7 RID: 149495 RVA: 0x00360AF0 File Offset: 0x0035ECF0
		[NullableContext(2)]
		public void CreateMeshSection(int SectionIndex, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<FVector2D> UV0, in TArray<FColor> VertexColors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
		{
			UProceduralMeshComponent.__CreateMeshSection_Internal(base.NativePtr, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UV0 ?? new TArray<FVector2D>()).NativePtr, (VertexColors ?? new TArray<FColor>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr, bCreateCollision);
		}

		// Token: 0x060247F8 RID: 149496 RVA: 0x00360B6F File Offset: 0x0035ED6F
		public void ClearMeshSection(int SectionIndex)
		{
			UProceduralMeshComponent.__ClearMeshSection_Internal(base.NativePtr, SectionIndex);
		}

		// Token: 0x060247F9 RID: 149497 RVA: 0x00360B7D File Offset: 0x0035ED7D
		public void ClearCollisionConvexMeshes()
		{
			UProceduralMeshComponent.__ClearCollisionConvexMeshes_Internal(base.NativePtr);
		}

		// Token: 0x060247FA RID: 149498 RVA: 0x00360B8A File Offset: 0x0035ED8A
		public void ClearAllMeshSections()
		{
			UProceduralMeshComponent.__ClearAllMeshSections_Internal(base.NativePtr);
		}

		// Token: 0x060247FB RID: 149499 RVA: 0x00360B97 File Offset: 0x0035ED97
		[NullableContext(2)]
		public void AddCollisionConvexMesh(TArray<FVector> ConvexVerts)
		{
			UProceduralMeshComponent.__AddCollisionConvexMesh_Internal(base.NativePtr, (ConvexVerts ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x060247FC RID: 149500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMeshSection_LinearColor_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Normals, IntPtr UV0, IntPtr UV1, IntPtr UV2, IntPtr UV3, IntPtr VertexColors, IntPtr Tangents);

		// Token: 0x060247FD RID: 149501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMeshSection_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Normals, IntPtr UV0, IntPtr VertexColors, IntPtr Tangents);

		// Token: 0x060247FE RID: 149502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMeshSectionVisible_Internal(IntPtr @this, int SectionIndex, bool bNewVisibility);

		// Token: 0x060247FF RID: 149503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroCreateMeshSection_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UV0, IntPtr UV1, IntPtr UV2, IntPtr UV3, IntPtr UV4, IntPtr UV5, IntPtr UV6, IntPtr UV7, IntPtr VertexColors, IntPtr Tangents, bool bCreateCollision);

		// Token: 0x06024800 RID: 149504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMeshSectionVisible_Internal(IntPtr @this, int SectionIndex);

		// Token: 0x06024801 RID: 149505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSections_Internal(IntPtr @this);

		// Token: 0x06024802 RID: 149506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateMeshSection_LinearColor_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UV0, IntPtr UV1, IntPtr UV2, IntPtr UV3, IntPtr VertexColors, IntPtr Tangents, bool bCreateCollision);

		// Token: 0x06024803 RID: 149507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateMeshSection_Internal(IntPtr @this, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UV0, IntPtr VertexColors, IntPtr Tangents, bool bCreateCollision);

		// Token: 0x06024804 RID: 149508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMeshSection_Internal(IntPtr @this, int SectionIndex);

		// Token: 0x06024805 RID: 149509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCollisionConvexMeshes_Internal(IntPtr @this);

		// Token: 0x06024806 RID: 149510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllMeshSections_Internal(IntPtr @this);

		// Token: 0x06024807 RID: 149511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCollisionConvexMesh_Internal(IntPtr @this, IntPtr ConvexVerts);

		// Token: 0x06024808 RID: 149512 RVA: 0x00360BB3 File Offset: 0x0035EDB3
		static UProceduralMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ProceduralMeshComponent.ProceduralMeshComponent");
		}

		// Token: 0x06024809 RID: 149513 RVA: 0x00360BC1 File Offset: 0x0035EDC1
		protected UProceduralMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040139AB RID: 80299
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x040139AC RID: 80300
		public new const string __ObjectPath = "/Script/ProceduralMeshComponent.ProceduralMeshComponent";

		// Token: 0x040139AD RID: 80301
		private static IntPtr _ClassPtr;

		// Token: 0x040139AE RID: 80302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040139AF RID: 80303
		internal static int __PropertyOffset_bUseComplexAsSimpleCollision;

		// Token: 0x040139B0 RID: 80304
		internal static int __PropertyOffset_bUseAsyncCooking;

		// Token: 0x040139B1 RID: 80305
		internal static int __PropertyOffset_ProcMeshBodySetup;

		// Token: 0x040139B2 RID: 80306
		internal static int __PropertyOffset_ProcMeshSections;

		// Token: 0x040139B3 RID: 80307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProcMeshSection> _ProcMeshSections;

		// Token: 0x040139B4 RID: 80308
		internal static int __PropertyOffset_CollisionConvexElems;

		// Token: 0x040139B5 RID: 80309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKConvexElem> _CollisionConvexElems;

		// Token: 0x040139B6 RID: 80310
		internal static int __PropertyOffset_LocalBounds;

		// Token: 0x040139B7 RID: 80311
		internal static int __PropertyOffset_AsyncBodySetupQueue;

		// Token: 0x040139B8 RID: 80312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _AsyncBodySetupQueue;
	}
}
