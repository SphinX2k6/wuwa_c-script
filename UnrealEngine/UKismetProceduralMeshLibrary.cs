using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200265B RID: 9819
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetProceduralMeshLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060247C5 RID: 149445 RVA: 0x003602A6 File Offset: 0x0035E4A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetProceduralMeshLibrary._ClassPtr;
		}

		// Token: 0x060247C6 RID: 149446 RVA: 0x003602B4 File Offset: 0x0035E4B4
		public UKismetProceduralMeshLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetProceduralMeshLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247C7 RID: 149447 RVA: 0x003602DC File Offset: 0x0035E4DC
		[NullableContext(1)]
		public UKismetProceduralMeshLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetProceduralMeshLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060247C8 RID: 149448 RVA: 0x00360310 File Offset: 0x0035E510
		public static void SliceProceduralMesh(UProceduralMeshComponent InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, ref UProceduralMeshComponent OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, UMaterialInterface CapMaterial)
		{
			UProceduralMeshComponent uproceduralMeshComponent = OutOtherHalfProcMesh;
			IntPtr nativeObjectPtr = (uproceduralMeshComponent != null) ? uproceduralMeshComponent.NativePtr : IntPtr.Zero;
			UKismetProceduralMeshLibrary.__SliceProceduralMesh_Internal((InProcMesh != null) ? InProcMesh.NativePtr : IntPtr.Zero, PlanePosition, PlaneNormal, bCreateOtherHalf, ref nativeObjectPtr, CapOption, (CapMaterial != null) ? CapMaterial.NativePtr : IntPtr.Zero);
			OutOtherHalfProcMesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<UProceduralMeshComponent>(nativeObjectPtr);
		}

		// Token: 0x060247C9 RID: 149449 RVA: 0x00360368 File Offset: 0x0035E568
		public static void GetSectionFromStaticMesh(UStaticMesh InMesh, int LODIndex, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FProcMeshTangent> Tangents)
		{
			UKismetProceduralMeshLibrary.__GetSectionFromStaticMesh_Internal((InMesh != null) ? InMesh.NativePtr : IntPtr.Zero, LODIndex, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247CA RID: 149450 RVA: 0x003603E0 File Offset: 0x0035E5E0
		public static void GetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FProcMeshTangent> Tangents)
		{
			UKismetProceduralMeshLibrary.__GetSectionFromProceduralMesh_Internal((InProcMesh != null) ? InProcMesh.NativePtr : IntPtr.Zero, SectionIndex, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247CB RID: 149451 RVA: 0x00360458 File Offset: 0x0035E658
		public static void GenerateBoxMesh(FVector BoxRadius, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FProcMeshTangent> Tangents)
		{
			UKismetProceduralMeshLibrary.__GenerateBoxMesh_Internal(BoxRadius, (Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247CC RID: 149452 RVA: 0x003604BD File Offset: 0x0035E6BD
		public static void CreateGridMeshWelded(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, float GridSpacing = 16f)
		{
			UKismetProceduralMeshLibrary.__CreateGridMeshWelded_Internal(NumX, NumY, (Triangles ?? new TArray<int>()).NativePtr, (Vertices ?? new TArray<FVector>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, GridSpacing);
		}

		// Token: 0x060247CD RID: 149453 RVA: 0x003604F9 File Offset: 0x0035E6F9
		public static void CreateGridMeshTriangles(int NumX, int NumY, bool bWinding, ref TArray<int> Triangles)
		{
			UKismetProceduralMeshLibrary.__CreateGridMeshTriangles_Internal(NumX, NumY, bWinding, (Triangles ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060247CE RID: 149454 RVA: 0x00360514 File Offset: 0x0035E714
		public static void CreateGridMeshSplit(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, ref TArray<FVector2D> UV1s, float GridSpacing = 16f)
		{
			UKismetProceduralMeshLibrary.__CreateGridMeshSplit_Internal(NumX, NumY, (Triangles ?? new TArray<int>()).NativePtr, (Vertices ?? new TArray<FVector>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, (UV1s ?? new TArray<FVector2D>()).NativePtr, GridSpacing);
		}

		// Token: 0x060247CF RID: 149455 RVA: 0x0036056C File Offset: 0x0035E76C
		public static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent, int LODIndex, UProceduralMeshComponent ProcMeshComponent, bool bCreateCollision)
		{
			UKismetProceduralMeshLibrary.__CopyProceduralMeshFromStaticMeshComponent_Internal((StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero, LODIndex, (ProcMeshComponent != null) ? ProcMeshComponent.NativePtr : IntPtr.Zero, bCreateCollision);
		}

		// Token: 0x060247D0 RID: 149456 RVA: 0x00360595 File Offset: 0x0035E795
		public static void ConvertQuadToTriangles(ref TArray<int> Triangles, int Vert0, int Vert1, int Vert2, int Vert3)
		{
			UKismetProceduralMeshLibrary.__ConvertQuadToTriangles_Internal((Triangles ?? new TArray<int>()).NativePtr, Vert0, Vert1, Vert2, Vert3);
		}

		// Token: 0x060247D1 RID: 149457 RVA: 0x003605B4 File Offset: 0x0035E7B4
		public static void CalculateTangentsForMesh(in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector2D> UVs, ref TArray<FVector> Normals, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FProcMeshTangent> Tangents)
		{
			UKismetProceduralMeshLibrary.__CalculateTangentsForMesh_Internal((Vertices ?? new TArray<FVector>()).NativePtr, (Triangles ?? new TArray<int>()).NativePtr, (UVs ?? new TArray<FVector2D>()).NativePtr, (Normals ?? new TArray<FVector>()).NativePtr, (Tangents ?? new TArray<FProcMeshTangent>()).NativePtr);
		}

		// Token: 0x060247D2 RID: 149458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SliceProceduralMesh_Internal(IntPtr InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, ref IntPtr OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, IntPtr CapMaterial);

		// Token: 0x060247D3 RID: 149459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSectionFromStaticMesh_Internal(IntPtr InMesh, int LODIndex, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UVs, IntPtr Tangents);

		// Token: 0x060247D4 RID: 149460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSectionFromProceduralMesh_Internal(IntPtr InProcMesh, int SectionIndex, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UVs, IntPtr Tangents);

		// Token: 0x060247D5 RID: 149461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateBoxMesh_Internal(FVector BoxRadius, IntPtr Vertices, IntPtr Triangles, IntPtr Normals, IntPtr UVs, IntPtr Tangents);

		// Token: 0x060247D6 RID: 149462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateGridMeshWelded_Internal(int NumX, int NumY, IntPtr Triangles, IntPtr Vertices, IntPtr UVs, float GridSpacing);

		// Token: 0x060247D7 RID: 149463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateGridMeshTriangles_Internal(int NumX, int NumY, bool bWinding, IntPtr Triangles);

		// Token: 0x060247D8 RID: 149464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateGridMeshSplit_Internal(int NumX, int NumY, IntPtr Triangles, IntPtr Vertices, IntPtr UVs, IntPtr UV1s, float GridSpacing);

		// Token: 0x060247D9 RID: 149465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyProceduralMeshFromStaticMeshComponent_Internal(IntPtr StaticMeshComponent, int LODIndex, IntPtr ProcMeshComponent, bool bCreateCollision);

		// Token: 0x060247DA RID: 149466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConvertQuadToTriangles_Internal(IntPtr Triangles, int Vert0, int Vert1, int Vert2, int Vert3);

		// Token: 0x060247DB RID: 149467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateTangentsForMesh_Internal(IntPtr Vertices, IntPtr Triangles, IntPtr UVs, IntPtr Normals, IntPtr Tangents);

		// Token: 0x060247DC RID: 149468 RVA: 0x00360617 File Offset: 0x0035E817
		static UKismetProceduralMeshLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary");
		}

		// Token: 0x060247DD RID: 149469 RVA: 0x00360625 File Offset: 0x0035E825
		protected UKismetProceduralMeshLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040139A8 RID: 80296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary";

		// Token: 0x040139A9 RID: 80297
		private static IntPtr _ClassPtr;

		// Token: 0x040139AA RID: 80298
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
