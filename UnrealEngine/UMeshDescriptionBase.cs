using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022CA RID: 8906
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshDescription.MeshDescriptionBase")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UMeshDescriptionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D06 RID: 138502 RVA: 0x0031FB56 File Offset: 0x0031DD56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshDescriptionBase._ClassPtr;
		}

		// Token: 0x06021D07 RID: 138503 RVA: 0x0031FB64 File Offset: 0x0031DD64
		public UMeshDescriptionBase() : this(BuiltinUtils.AllocNativeUObject(UMeshDescriptionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D08 RID: 138504 RVA: 0x0031FB8C File Offset: 0x0031DD8C
		[NullableContext(1)]
		public UMeshDescriptionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshDescriptionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021D09 RID: 138505 RVA: 0x0031FBBF File Offset: 0x0031DDBF
		public void SetVertexPosition(FVertexID VertexID, in FVector Position)
		{
			UMeshDescriptionBase.__SetVertexPosition_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, Position);
		}

		// Token: 0x06021D0A RID: 138506 RVA: 0x0031FBDC File Offset: 0x0031DDDC
		public void SetPolygonVertexInstance(FPolygonID PolygonID, int PerimeterIndex, FVertexInstanceID VertexInstanceID)
		{
			UMeshDescriptionBase.__SetPolygonVertexInstance_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, PerimeterIndex, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr);
		}

		// Token: 0x06021D0B RID: 138507 RVA: 0x0031FC08 File Offset: 0x0031DE08
		public void SetPolygonPolygonGroup(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID)
		{
			UMeshDescriptionBase.__SetPolygonPolygonGroup_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr);
		}

		// Token: 0x06021D0C RID: 138508 RVA: 0x0031FC33 File Offset: 0x0031DE33
		public void ReversePolygonFacing(FPolygonID PolygonID)
		{
			UMeshDescriptionBase.__ReversePolygonFacing_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D0D RID: 138509 RVA: 0x0031FC4F File Offset: 0x0031DE4F
		public void ReserveNewVertices(int NumberOfNewVertices)
		{
			UMeshDescriptionBase.__ReserveNewVertices_Internal(base.NativePtr, NumberOfNewVertices);
		}

		// Token: 0x06021D0E RID: 138510 RVA: 0x0031FC5D File Offset: 0x0031DE5D
		public void ReserveNewVertexInstances(int NumberOfNewVertexInstances)
		{
			UMeshDescriptionBase.__ReserveNewVertexInstances_Internal(base.NativePtr, NumberOfNewVertexInstances);
		}

		// Token: 0x06021D0F RID: 138511 RVA: 0x0031FC6B File Offset: 0x0031DE6B
		public void ReserveNewTriangles(int NumberOfNewTriangles)
		{
			UMeshDescriptionBase.__ReserveNewTriangles_Internal(base.NativePtr, NumberOfNewTriangles);
		}

		// Token: 0x06021D10 RID: 138512 RVA: 0x0031FC79 File Offset: 0x0031DE79
		public void ReserveNewPolygons(int NumberOfNewPolygons)
		{
			UMeshDescriptionBase.__ReserveNewPolygons_Internal(base.NativePtr, NumberOfNewPolygons);
		}

		// Token: 0x06021D11 RID: 138513 RVA: 0x0031FC87 File Offset: 0x0031DE87
		public void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups)
		{
			UMeshDescriptionBase.__ReserveNewPolygonGroups_Internal(base.NativePtr, NumberOfNewPolygonGroups);
		}

		// Token: 0x06021D12 RID: 138514 RVA: 0x0031FC95 File Offset: 0x0031DE95
		public void ReserveNewEdges(int NumberOfNewEdges)
		{
			UMeshDescriptionBase.__ReserveNewEdges_Internal(base.NativePtr, NumberOfNewEdges);
		}

		// Token: 0x06021D13 RID: 138515 RVA: 0x0031FCA3 File Offset: 0x0031DEA3
		public bool IsVertexValid(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__IsVertexValid_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D14 RID: 138516 RVA: 0x0031FCBF File Offset: 0x0031DEBF
		public bool IsVertexOrphaned(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__IsVertexOrphaned_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D15 RID: 138517 RVA: 0x0031FCDB File Offset: 0x0031DEDB
		public bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID)
		{
			return UMeshDescriptionBase.__IsVertexInstanceValid_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr);
		}

		// Token: 0x06021D16 RID: 138518 RVA: 0x0031FCF7 File Offset: 0x0031DEF7
		public bool IsTriangleValid(FTriangleID TriangleID)
		{
			return UMeshDescriptionBase.__IsTriangleValid_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr);
		}

		// Token: 0x06021D17 RID: 138519 RVA: 0x0031FD13 File Offset: 0x0031DF13
		public bool IsTrianglePartOfNgon(FTriangleID TriangleID)
		{
			return UMeshDescriptionBase.__IsTrianglePartOfNgon_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr);
		}

		// Token: 0x06021D18 RID: 138520 RVA: 0x0031FD2F File Offset: 0x0031DF2F
		public bool IsPolygonValid(FPolygonID PolygonID)
		{
			return UMeshDescriptionBase.__IsPolygonValid_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D19 RID: 138521 RVA: 0x0031FD4B File Offset: 0x0031DF4B
		public bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID)
		{
			return UMeshDescriptionBase.__IsPolygonGroupValid_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr);
		}

		// Token: 0x06021D1A RID: 138522 RVA: 0x0031FD67 File Offset: 0x0031DF67
		public bool IsEmpty()
		{
			return UMeshDescriptionBase.__IsEmpty_Internal(base.NativePtr);
		}

		// Token: 0x06021D1B RID: 138523 RVA: 0x0031FD74 File Offset: 0x0031DF74
		public bool IsEdgeValid(FEdgeID EdgeID)
		{
			return UMeshDescriptionBase.__IsEdgeValid_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr);
		}

		// Token: 0x06021D1C RID: 138524 RVA: 0x0031FD90 File Offset: 0x0031DF90
		public bool IsEdgeInternalToPolygon(FEdgeID EdgeID, FPolygonID PolygonID)
		{
			return UMeshDescriptionBase.__IsEdgeInternalToPolygon_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D1D RID: 138525 RVA: 0x0031FDBB File Offset: 0x0031DFBB
		public bool IsEdgeInternal(FEdgeID EdgeID)
		{
			return UMeshDescriptionBase.__IsEdgeInternal_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr);
		}

		// Token: 0x06021D1E RID: 138526 RVA: 0x0031FDD7 File Offset: 0x0031DFD7
		public void GetVertexVertexInstances(FVertexID VertexID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			UMeshDescriptionBase.__GetVertexVertexInstances_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, (OutVertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr);
		}

		// Token: 0x06021D1F RID: 138527 RVA: 0x0031FE03 File Offset: 0x0031E003
		public FVector GetVertexPosition(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__GetVertexPosition_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D20 RID: 138528 RVA: 0x0031FE1F File Offset: 0x0031E01F
		[return: Nullable(1)]
		public FEdgeID GetVertexPairEdge(FVertexID VertexID0, FVertexID VertexID1)
		{
			return new FEdgeID(UMeshDescriptionBase.__GetVertexPairEdge_Internal(base.NativePtr, (VertexID0 ?? new FVertexID()).NativePtr, (VertexID1 ?? new FVertexID()).NativePtr), null);
		}

		// Token: 0x06021D21 RID: 138529 RVA: 0x0031FE50 File Offset: 0x0031E050
		[NullableContext(1)]
		public FVertexID GetVertexInstanceVertex([Nullable(2)] FVertexInstanceID VertexInstanceID)
		{
			return new FVertexID(UMeshDescriptionBase.__GetVertexInstanceVertex_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr), null);
		}

		// Token: 0x06021D22 RID: 138530 RVA: 0x0031FE72 File Offset: 0x0031E072
		[return: Nullable(1)]
		public FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0, FVertexInstanceID VertexInstanceID1)
		{
			return new FEdgeID(UMeshDescriptionBase.__GetVertexInstancePairEdge_Internal(base.NativePtr, (VertexInstanceID0 ?? new FVertexInstanceID()).NativePtr, (VertexInstanceID1 ?? new FVertexInstanceID()).NativePtr), null);
		}

		// Token: 0x06021D23 RID: 138531 RVA: 0x0031FEA3 File Offset: 0x0031E0A3
		[return: Nullable(1)]
		public FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID, FVertexID VertexID)
		{
			return new FVertexInstanceID(UMeshDescriptionBase.__GetVertexInstanceForTriangleVertex_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (VertexID ?? new FVertexID()).NativePtr), null);
		}

		// Token: 0x06021D24 RID: 138532 RVA: 0x0031FED4 File Offset: 0x0031E0D4
		[return: Nullable(1)]
		public FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID, FVertexID VertexID)
		{
			return new FVertexInstanceID(UMeshDescriptionBase.__GetVertexInstanceForPolygonVertex_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (VertexID ?? new FVertexID()).NativePtr), null);
		}

		// Token: 0x06021D25 RID: 138533 RVA: 0x0031FF05 File Offset: 0x0031E105
		public void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			UMeshDescriptionBase.__GetVertexInstanceConnectedTriangles_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, (OutConnectedTriangleIDs ?? new TArray<FTriangleID>()).NativePtr);
		}

		// Token: 0x06021D26 RID: 138534 RVA: 0x0031FF31 File Offset: 0x0031E131
		public void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			UMeshDescriptionBase.__GetVertexInstanceConnectedPolygons_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, (OutConnectedPolygonIDs ?? new TArray<FPolygonID>()).NativePtr);
		}

		// Token: 0x06021D27 RID: 138535 RVA: 0x0031FF5D File Offset: 0x0031E15D
		public void GetVertexConnectedTriangles(FVertexID VertexID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			UMeshDescriptionBase.__GetVertexConnectedTriangles_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, (OutConnectedTriangleIDs ?? new TArray<FTriangleID>()).NativePtr);
		}

		// Token: 0x06021D28 RID: 138536 RVA: 0x0031FF89 File Offset: 0x0031E189
		public void GetVertexConnectedPolygons(FVertexID VertexID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			UMeshDescriptionBase.__GetVertexConnectedPolygons_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, (OutConnectedPolygonIDs ?? new TArray<FPolygonID>()).NativePtr);
		}

		// Token: 0x06021D29 RID: 138537 RVA: 0x0031FFB5 File Offset: 0x0031E1B5
		public void GetVertexConnectedEdges(FVertexID VertexID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OutEdgeIDs)
		{
			UMeshDescriptionBase.__GetVertexConnectedEdges_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, (OutEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D2A RID: 138538 RVA: 0x0031FFE1 File Offset: 0x0031E1E1
		public void GetVertexAdjacentVertices(FVertexID VertexID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OutAdjacentVertexIDs)
		{
			UMeshDescriptionBase.__GetVertexAdjacentVertices_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr, (OutAdjacentVertexIDs ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D2B RID: 138539 RVA: 0x0032000D File Offset: 0x0031E20D
		public void GetTriangleVertices(FTriangleID TriangleID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OutVertexIDs)
		{
			UMeshDescriptionBase.__GetTriangleVertices_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (OutVertexIDs ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D2C RID: 138540 RVA: 0x00320039 File Offset: 0x0031E239
		public void GetTriangleVertexInstances(FTriangleID TriangleID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			UMeshDescriptionBase.__GetTriangleVertexInstances_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (OutVertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr);
		}

		// Token: 0x06021D2D RID: 138541 RVA: 0x00320065 File Offset: 0x0031E265
		[NullableContext(1)]
		public FVertexInstanceID GetTriangleVertexInstance([Nullable(2)] FTriangleID TriangleID, int Index)
		{
			return new FVertexInstanceID(UMeshDescriptionBase.__GetTriangleVertexInstance_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, Index), null);
		}

		// Token: 0x06021D2E RID: 138542 RVA: 0x00320088 File Offset: 0x0031E288
		[NullableContext(1)]
		public FPolygonGroupID GetTrianglePolygonGroup([Nullable(2)] FTriangleID TriangleID)
		{
			return new FPolygonGroupID(UMeshDescriptionBase.__GetTrianglePolygonGroup_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr), null);
		}

		// Token: 0x06021D2F RID: 138543 RVA: 0x003200AA File Offset: 0x0031E2AA
		[NullableContext(1)]
		public FPolygonID GetTrianglePolygon([Nullable(2)] FTriangleID TriangleID)
		{
			return new FPolygonID(UMeshDescriptionBase.__GetTrianglePolygon_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr), null);
		}

		// Token: 0x06021D30 RID: 138544 RVA: 0x003200CC File Offset: 0x0031E2CC
		public void GetTriangleEdges(FTriangleID TriangleID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OutEdgeIDs)
		{
			UMeshDescriptionBase.__GetTriangleEdges_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (OutEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D31 RID: 138545 RVA: 0x003200F8 File Offset: 0x0031E2F8
		public void GetTriangleAdjacentTriangles(FTriangleID TriangleID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FTriangleID> OutTriangleIDs)
		{
			UMeshDescriptionBase.__GetTriangleAdjacentTriangles_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (OutTriangleIDs ?? new TArray<FTriangleID>()).NativePtr);
		}

		// Token: 0x06021D32 RID: 138546 RVA: 0x00320124 File Offset: 0x0031E324
		public void GetPolygonVertices(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OutVertexIDs)
		{
			UMeshDescriptionBase.__GetPolygonVertices_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutVertexIDs ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D33 RID: 138547 RVA: 0x00320150 File Offset: 0x0031E350
		public void GetPolygonVertexInstances(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			UMeshDescriptionBase.__GetPolygonVertexInstances_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutVertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr);
		}

		// Token: 0x06021D34 RID: 138548 RVA: 0x0032017C File Offset: 0x0031E37C
		public void GetPolygonTriangles(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FTriangleID> OutTriangleIDs)
		{
			UMeshDescriptionBase.__GetPolygonTriangles_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutTriangleIDs ?? new TArray<FTriangleID>()).NativePtr);
		}

		// Token: 0x06021D35 RID: 138549 RVA: 0x003201A8 File Offset: 0x0031E3A8
		[NullableContext(1)]
		public FPolygonGroupID GetPolygonPolygonGroup([Nullable(2)] FPolygonID PolygonID)
		{
			return new FPolygonGroupID(UMeshDescriptionBase.__GetPolygonPolygonGroup_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr), null);
		}

		// Token: 0x06021D36 RID: 138550 RVA: 0x003201CA File Offset: 0x0031E3CA
		public void GetPolygonPerimeterEdges(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OutEdgeIDs)
		{
			UMeshDescriptionBase.__GetPolygonPerimeterEdges_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D37 RID: 138551 RVA: 0x003201F6 File Offset: 0x0031E3F6
		public void GetPolygonInternalEdges(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OutEdgeIDs)
		{
			UMeshDescriptionBase.__GetPolygonInternalEdges_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D38 RID: 138552 RVA: 0x00320222 File Offset: 0x0031E422
		public void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonID> OutPolygonIDs)
		{
			UMeshDescriptionBase.__GetPolygonGroupPolygons_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, (OutPolygonIDs ?? new TArray<FPolygonID>()).NativePtr);
		}

		// Token: 0x06021D39 RID: 138553 RVA: 0x0032024E File Offset: 0x0031E44E
		public void GetPolygonAdjacentPolygons(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonID> OutPolygonIDs)
		{
			UMeshDescriptionBase.__GetPolygonAdjacentPolygons_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OutPolygonIDs ?? new TArray<FPolygonID>()).NativePtr);
		}

		// Token: 0x06021D3A RID: 138554 RVA: 0x0032027A File Offset: 0x0031E47A
		public int GetNumVertexVertexInstances(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__GetNumVertexVertexInstances_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D3B RID: 138555 RVA: 0x00320296 File Offset: 0x0031E496
		public int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID)
		{
			return UMeshDescriptionBase.__GetNumVertexInstanceConnectedTriangles_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr);
		}

		// Token: 0x06021D3C RID: 138556 RVA: 0x003202B2 File Offset: 0x0031E4B2
		public int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID)
		{
			return UMeshDescriptionBase.__GetNumVertexInstanceConnectedPolygons_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr);
		}

		// Token: 0x06021D3D RID: 138557 RVA: 0x003202CE File Offset: 0x0031E4CE
		public int GetNumVertexConnectedTriangles(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__GetNumVertexConnectedTriangles_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D3E RID: 138558 RVA: 0x003202EA File Offset: 0x0031E4EA
		public int GetNumVertexConnectedPolygons(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__GetNumVertexConnectedPolygons_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D3F RID: 138559 RVA: 0x00320306 File Offset: 0x0031E506
		public int GetNumVertexConnectedEdges(FVertexID VertexID)
		{
			return UMeshDescriptionBase.__GetNumVertexConnectedEdges_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D40 RID: 138560 RVA: 0x00320322 File Offset: 0x0031E522
		public int GetNumPolygonVertices(FPolygonID PolygonID)
		{
			return UMeshDescriptionBase.__GetNumPolygonVertices_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D41 RID: 138561 RVA: 0x0032033E File Offset: 0x0031E53E
		public int GetNumPolygonTriangles(FPolygonID PolygonID)
		{
			return UMeshDescriptionBase.__GetNumPolygonTriangles_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D42 RID: 138562 RVA: 0x0032035A File Offset: 0x0031E55A
		public int GetNumPolygonInternalEdges(FPolygonID PolygonID)
		{
			return UMeshDescriptionBase.__GetNumPolygonInternalEdges_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D43 RID: 138563 RVA: 0x00320376 File Offset: 0x0031E576
		public int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID)
		{
			return UMeshDescriptionBase.__GetNumPolygonGroupPolygons_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr);
		}

		// Token: 0x06021D44 RID: 138564 RVA: 0x00320392 File Offset: 0x0031E592
		public int GetNumEdgeConnectedTriangles(FEdgeID EdgeID)
		{
			return UMeshDescriptionBase.__GetNumEdgeConnectedTriangles_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr);
		}

		// Token: 0x06021D45 RID: 138565 RVA: 0x003203AE File Offset: 0x0031E5AE
		public int GetNumEdgeConnectedPolygons(FEdgeID EdgeID)
		{
			return UMeshDescriptionBase.__GetNumEdgeConnectedPolygons_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr);
		}

		// Token: 0x06021D46 RID: 138566 RVA: 0x003203CA File Offset: 0x0031E5CA
		public void GetEdgeVertices(FEdgeID EdgeID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OutVertexIDs)
		{
			UMeshDescriptionBase.__GetEdgeVertices_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (OutVertexIDs ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D47 RID: 138567 RVA: 0x003203F6 File Offset: 0x0031E5F6
		[NullableContext(1)]
		public FVertexID GetEdgeVertex([Nullable(2)] FEdgeID EdgeID, int VertexNumber)
		{
			return new FVertexID(UMeshDescriptionBase.__GetEdgeVertex_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, VertexNumber), null);
		}

		// Token: 0x06021D48 RID: 138568 RVA: 0x00320419 File Offset: 0x0031E619
		public void GetEdgeConnectedTriangles(FEdgeID EdgeID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			UMeshDescriptionBase.__GetEdgeConnectedTriangles_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (OutConnectedTriangleIDs ?? new TArray<FTriangleID>()).NativePtr);
		}

		// Token: 0x06021D49 RID: 138569 RVA: 0x00320445 File Offset: 0x0031E645
		public void GetEdgeConnectedPolygons(FEdgeID EdgeID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			UMeshDescriptionBase.__GetEdgeConnectedPolygons_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (OutConnectedPolygonIDs ?? new TArray<FPolygonID>()).NativePtr);
		}

		// Token: 0x06021D4A RID: 138570 RVA: 0x00320471 File Offset: 0x0031E671
		public void Empty()
		{
			UMeshDescriptionBase.__Empty_Internal(base.NativePtr);
		}

		// Token: 0x06021D4B RID: 138571 RVA: 0x0032047E File Offset: 0x0031E67E
		public void DeleteVertexInstance(FVertexInstanceID VertexInstanceID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OrphanedVertices)
		{
			UMeshDescriptionBase.__DeleteVertexInstance_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, (OrphanedVertices ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D4C RID: 138572 RVA: 0x003204AA File Offset: 0x0031E6AA
		public void DeleteVertex(FVertexID VertexID)
		{
			UMeshDescriptionBase.__DeleteVertex_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D4D RID: 138573 RVA: 0x003204C8 File Offset: 0x0031E6C8
		public void DeleteTriangle(FTriangleID TriangleID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OrphanedEdges, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> OrphanedVertexInstances, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonGroupID> OrphanedPolygonGroupsPtr)
		{
			UMeshDescriptionBase.__DeleteTriangle_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (OrphanedEdges ?? new TArray<FEdgeID>()).NativePtr, (OrphanedVertexInstances ?? new TArray<FVertexInstanceID>()).NativePtr, (OrphanedPolygonGroupsPtr ?? new TArray<FPolygonGroupID>()).NativePtr);
		}

		// Token: 0x06021D4E RID: 138574 RVA: 0x00320520 File Offset: 0x0031E720
		public void DeletePolygonGroup(FPolygonGroupID PolygonGroupID)
		{
			UMeshDescriptionBase.__DeletePolygonGroup_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr);
		}

		// Token: 0x06021D4F RID: 138575 RVA: 0x0032053C File Offset: 0x0031E73C
		public void DeletePolygon(FPolygonID PolygonID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> OrphanedEdges, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> OrphanedVertexInstances, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FPolygonGroupID> OrphanedPolygonGroups)
		{
			UMeshDescriptionBase.__DeletePolygon_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (OrphanedEdges ?? new TArray<FEdgeID>()).NativePtr, (OrphanedVertexInstances ?? new TArray<FVertexInstanceID>()).NativePtr, (OrphanedPolygonGroups ?? new TArray<FPolygonGroupID>()).NativePtr);
		}

		// Token: 0x06021D50 RID: 138576 RVA: 0x00320594 File Offset: 0x0031E794
		public void DeleteEdge(FEdgeID EdgeID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexID> OrphanedVertices)
		{
			UMeshDescriptionBase.__DeleteEdge_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (OrphanedVertices ?? new TArray<FVertexID>()).NativePtr);
		}

		// Token: 0x06021D51 RID: 138577 RVA: 0x003205C0 File Offset: 0x0031E7C0
		public void CreateVertexWithID(FVertexID VertexID)
		{
			UMeshDescriptionBase.__CreateVertexWithID_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D52 RID: 138578 RVA: 0x003205DC File Offset: 0x0031E7DC
		public void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID, FVertexID VertexID)
		{
			UMeshDescriptionBase.__CreateVertexInstanceWithID_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, (VertexID ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D53 RID: 138579 RVA: 0x00320607 File Offset: 0x0031E807
		[NullableContext(1)]
		public FVertexInstanceID CreateVertexInstance([Nullable(2)] FVertexID VertexID)
		{
			return new FVertexInstanceID(UMeshDescriptionBase.__CreateVertexInstance_Internal(base.NativePtr, (VertexID ?? new FVertexID()).NativePtr), null);
		}

		// Token: 0x06021D54 RID: 138580 RVA: 0x00320629 File Offset: 0x0031E829
		[NullableContext(1)]
		public FVertexID CreateVertex()
		{
			return new FVertexID(UMeshDescriptionBase.__CreateVertex_Internal(base.NativePtr), null);
		}

		// Token: 0x06021D55 RID: 138581 RVA: 0x0032063C File Offset: 0x0031E83C
		public void CreateTriangleWithID(FTriangleID TriangleID, FPolygonGroupID PolygonGroupID, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FVertexInstanceID> VertexInstanceIDs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> NewEdgeIDs)
		{
			UMeshDescriptionBase.__CreateTriangleWithID_Internal(base.NativePtr, (TriangleID ?? new FTriangleID()).NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, (VertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr, (NewEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D56 RID: 138582 RVA: 0x00320694 File Offset: 0x0031E894
		[NullableContext(1)]
		public FTriangleID CreateTriangle([Nullable(2)] FPolygonGroupID PolygonGroupID, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FVertexInstanceID> VertexInstanceIDs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> NewEdgeIDs)
		{
			return new FTriangleID(UMeshDescriptionBase.__CreateTriangle_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, (VertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr, (NewEdgeIDs ?? new TArray<FEdgeID>()).NativePtr), null);
		}

		// Token: 0x06021D57 RID: 138583 RVA: 0x003206E4 File Offset: 0x0031E8E4
		public void CreatePolygonWithID(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> VertexInstanceIDs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> NewEdgeIDs)
		{
			UMeshDescriptionBase.__CreatePolygonWithID_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, (VertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr, (NewEdgeIDs ?? new TArray<FEdgeID>()).NativePtr);
		}

		// Token: 0x06021D58 RID: 138584 RVA: 0x0032073B File Offset: 0x0031E93B
		public void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID)
		{
			UMeshDescriptionBase.__CreatePolygonGroupWithID_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr);
		}

		// Token: 0x06021D59 RID: 138585 RVA: 0x00320757 File Offset: 0x0031E957
		[NullableContext(1)]
		public FPolygonGroupID CreatePolygonGroup()
		{
			return new FPolygonGroupID(UMeshDescriptionBase.__CreatePolygonGroup_Internal(base.NativePtr), null);
		}

		// Token: 0x06021D5A RID: 138586 RVA: 0x0032076C File Offset: 0x0031E96C
		[NullableContext(1)]
		public FPolygonID CreatePolygon([Nullable(2)] FPolygonGroupID PolygonGroupID, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FVertexInstanceID> VertexInstanceIDs, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FEdgeID> NewEdgeIDs)
		{
			return new FPolygonID(UMeshDescriptionBase.__CreatePolygon_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, (VertexInstanceIDs ?? new TArray<FVertexInstanceID>()).NativePtr, (NewEdgeIDs ?? new TArray<FEdgeID>()).NativePtr), null);
		}

		// Token: 0x06021D5B RID: 138587 RVA: 0x003207B9 File Offset: 0x0031E9B9
		public void CreateEdgeWithID(FEdgeID EdgeID, FVertexID VertexID0, FVertexID VertexID1)
		{
			UMeshDescriptionBase.__CreateEdgeWithID_Internal(base.NativePtr, (EdgeID ?? new FEdgeID()).NativePtr, (VertexID0 ?? new FVertexID()).NativePtr, (VertexID1 ?? new FVertexID()).NativePtr);
		}

		// Token: 0x06021D5C RID: 138588 RVA: 0x003207F3 File Offset: 0x0031E9F3
		[return: Nullable(1)]
		public FEdgeID CreateEdge(FVertexID VertexID0, FVertexID VertexID1)
		{
			return new FEdgeID(UMeshDescriptionBase.__CreateEdge_Internal(base.NativePtr, (VertexID0 ?? new FVertexID()).NativePtr, (VertexID1 ?? new FVertexID()).NativePtr), null);
		}

		// Token: 0x06021D5D RID: 138589 RVA: 0x00320824 File Offset: 0x0031EA24
		public void ComputePolygonTriangulation(FPolygonID PolygonID)
		{
			UMeshDescriptionBase.__ComputePolygonTriangulation_Internal(base.NativePtr, (PolygonID ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06021D5E RID: 138590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexPosition_Internal(IntPtr @this, IntPtr VertexID, in FVector Position);

		// Token: 0x06021D5F RID: 138591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPolygonVertexInstance_Internal(IntPtr @this, IntPtr PolygonID, int PerimeterIndex, IntPtr VertexInstanceID);

		// Token: 0x06021D60 RID: 138592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPolygonPolygonGroup_Internal(IntPtr @this, IntPtr PolygonID, IntPtr PolygonGroupID);

		// Token: 0x06021D61 RID: 138593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReversePolygonFacing_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D62 RID: 138594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewVertices_Internal(IntPtr @this, int NumberOfNewVertices);

		// Token: 0x06021D63 RID: 138595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewVertexInstances_Internal(IntPtr @this, int NumberOfNewVertexInstances);

		// Token: 0x06021D64 RID: 138596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewTriangles_Internal(IntPtr @this, int NumberOfNewTriangles);

		// Token: 0x06021D65 RID: 138597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewPolygons_Internal(IntPtr @this, int NumberOfNewPolygons);

		// Token: 0x06021D66 RID: 138598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewPolygonGroups_Internal(IntPtr @this, int NumberOfNewPolygonGroups);

		// Token: 0x06021D67 RID: 138599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReserveNewEdges_Internal(IntPtr @this, int NumberOfNewEdges);

		// Token: 0x06021D68 RID: 138600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVertexValid_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D69 RID: 138601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVertexOrphaned_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D6A RID: 138602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVertexInstanceValid_Internal(IntPtr @this, IntPtr VertexInstanceID);

		// Token: 0x06021D6B RID: 138603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTriangleValid_Internal(IntPtr @this, IntPtr TriangleID);

		// Token: 0x06021D6C RID: 138604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTrianglePartOfNgon_Internal(IntPtr @this, IntPtr TriangleID);

		// Token: 0x06021D6D RID: 138605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPolygonValid_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D6E RID: 138606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPolygonGroupValid_Internal(IntPtr @this, IntPtr PolygonGroupID);

		// Token: 0x06021D6F RID: 138607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEmpty_Internal(IntPtr @this);

		// Token: 0x06021D70 RID: 138608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEdgeValid_Internal(IntPtr @this, IntPtr EdgeID);

		// Token: 0x06021D71 RID: 138609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEdgeInternalToPolygon_Internal(IntPtr @this, IntPtr EdgeID, IntPtr PolygonID);

		// Token: 0x06021D72 RID: 138610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEdgeInternal_Internal(IntPtr @this, IntPtr EdgeID);

		// Token: 0x06021D73 RID: 138611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexVertexInstances_Internal(IntPtr @this, IntPtr VertexID, IntPtr OutVertexInstanceIDs);

		// Token: 0x06021D74 RID: 138612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVertexPosition_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D75 RID: 138613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexPairEdge_Internal(IntPtr @this, IntPtr VertexID0, IntPtr VertexID1);

		// Token: 0x06021D76 RID: 138614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceVertex_Internal(IntPtr @this, IntPtr VertexInstanceID);

		// Token: 0x06021D77 RID: 138615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstancePairEdge_Internal(IntPtr @this, IntPtr VertexInstanceID0, IntPtr VertexInstanceID1);

		// Token: 0x06021D78 RID: 138616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceForTriangleVertex_Internal(IntPtr @this, IntPtr TriangleID, IntPtr VertexID);

		// Token: 0x06021D79 RID: 138617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexInstanceForPolygonVertex_Internal(IntPtr @this, IntPtr PolygonID, IntPtr VertexID);

		// Token: 0x06021D7A RID: 138618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexInstanceConnectedTriangles_Internal(IntPtr @this, IntPtr VertexInstanceID, IntPtr OutConnectedTriangleIDs);

		// Token: 0x06021D7B RID: 138619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexInstanceConnectedPolygons_Internal(IntPtr @this, IntPtr VertexInstanceID, IntPtr OutConnectedPolygonIDs);

		// Token: 0x06021D7C RID: 138620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexConnectedTriangles_Internal(IntPtr @this, IntPtr VertexID, IntPtr OutConnectedTriangleIDs);

		// Token: 0x06021D7D RID: 138621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexConnectedPolygons_Internal(IntPtr @this, IntPtr VertexID, IntPtr OutConnectedPolygonIDs);

		// Token: 0x06021D7E RID: 138622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexConnectedEdges_Internal(IntPtr @this, IntPtr VertexID, IntPtr OutEdgeIDs);

		// Token: 0x06021D7F RID: 138623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetVertexAdjacentVertices_Internal(IntPtr @this, IntPtr VertexID, IntPtr OutAdjacentVertexIDs);

		// Token: 0x06021D80 RID: 138624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTriangleVertices_Internal(IntPtr @this, IntPtr TriangleID, IntPtr OutVertexIDs);

		// Token: 0x06021D81 RID: 138625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTriangleVertexInstances_Internal(IntPtr @this, IntPtr TriangleID, IntPtr OutVertexInstanceIDs);

		// Token: 0x06021D82 RID: 138626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTriangleVertexInstance_Internal(IntPtr @this, IntPtr TriangleID, int Index);

		// Token: 0x06021D83 RID: 138627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrianglePolygonGroup_Internal(IntPtr @this, IntPtr TriangleID);

		// Token: 0x06021D84 RID: 138628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrianglePolygon_Internal(IntPtr @this, IntPtr TriangleID);

		// Token: 0x06021D85 RID: 138629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTriangleEdges_Internal(IntPtr @this, IntPtr TriangleID, IntPtr OutEdgeIDs);

		// Token: 0x06021D86 RID: 138630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTriangleAdjacentTriangles_Internal(IntPtr @this, IntPtr TriangleID, IntPtr OutTriangleIDs);

		// Token: 0x06021D87 RID: 138631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonVertices_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutVertexIDs);

		// Token: 0x06021D88 RID: 138632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonVertexInstances_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutVertexInstanceIDs);

		// Token: 0x06021D89 RID: 138633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonTriangles_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutTriangleIDs);

		// Token: 0x06021D8A RID: 138634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPolygonPolygonGroup_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D8B RID: 138635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonPerimeterEdges_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutEdgeIDs);

		// Token: 0x06021D8C RID: 138636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonInternalEdges_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutEdgeIDs);

		// Token: 0x06021D8D RID: 138637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonGroupPolygons_Internal(IntPtr @this, IntPtr PolygonGroupID, IntPtr OutPolygonIDs);

		// Token: 0x06021D8E RID: 138638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPolygonAdjacentPolygons_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OutPolygonIDs);

		// Token: 0x06021D8F RID: 138639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexVertexInstances_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D90 RID: 138640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexInstanceConnectedTriangles_Internal(IntPtr @this, IntPtr VertexInstanceID);

		// Token: 0x06021D91 RID: 138641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexInstanceConnectedPolygons_Internal(IntPtr @this, IntPtr VertexInstanceID);

		// Token: 0x06021D92 RID: 138642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexConnectedTriangles_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D93 RID: 138643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexConnectedPolygons_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D94 RID: 138644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumVertexConnectedEdges_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021D95 RID: 138645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPolygonVertices_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D96 RID: 138646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPolygonTriangles_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D97 RID: 138647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPolygonInternalEdges_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021D98 RID: 138648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPolygonGroupPolygons_Internal(IntPtr @this, IntPtr PolygonGroupID);

		// Token: 0x06021D99 RID: 138649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumEdgeConnectedTriangles_Internal(IntPtr @this, IntPtr EdgeID);

		// Token: 0x06021D9A RID: 138650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumEdgeConnectedPolygons_Internal(IntPtr @this, IntPtr EdgeID);

		// Token: 0x06021D9B RID: 138651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetEdgeVertices_Internal(IntPtr @this, IntPtr EdgeID, IntPtr OutVertexIDs);

		// Token: 0x06021D9C RID: 138652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEdgeVertex_Internal(IntPtr @this, IntPtr EdgeID, int VertexNumber);

		// Token: 0x06021D9D RID: 138653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetEdgeConnectedTriangles_Internal(IntPtr @this, IntPtr EdgeID, IntPtr OutConnectedTriangleIDs);

		// Token: 0x06021D9E RID: 138654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetEdgeConnectedPolygons_Internal(IntPtr @this, IntPtr EdgeID, IntPtr OutConnectedPolygonIDs);

		// Token: 0x06021D9F RID: 138655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Empty_Internal(IntPtr @this);

		// Token: 0x06021DA0 RID: 138656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteVertexInstance_Internal(IntPtr @this, IntPtr VertexInstanceID, IntPtr OrphanedVertices);

		// Token: 0x06021DA1 RID: 138657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteVertex_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021DA2 RID: 138658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteTriangle_Internal(IntPtr @this, IntPtr TriangleID, IntPtr OrphanedEdges, IntPtr OrphanedVertexInstances, IntPtr OrphanedPolygonGroupsPtr);

		// Token: 0x06021DA3 RID: 138659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeletePolygonGroup_Internal(IntPtr @this, IntPtr PolygonGroupID);

		// Token: 0x06021DA4 RID: 138660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeletePolygon_Internal(IntPtr @this, IntPtr PolygonID, IntPtr OrphanedEdges, IntPtr OrphanedVertexInstances, IntPtr OrphanedPolygonGroups);

		// Token: 0x06021DA5 RID: 138661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteEdge_Internal(IntPtr @this, IntPtr EdgeID, IntPtr OrphanedVertices);

		// Token: 0x06021DA6 RID: 138662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateVertexWithID_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021DA7 RID: 138663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateVertexInstanceWithID_Internal(IntPtr @this, IntPtr VertexInstanceID, IntPtr VertexID);

		// Token: 0x06021DA8 RID: 138664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateVertexInstance_Internal(IntPtr @this, IntPtr VertexID);

		// Token: 0x06021DA9 RID: 138665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateVertex_Internal(IntPtr @this);

		// Token: 0x06021DAA RID: 138666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateTriangleWithID_Internal(IntPtr @this, IntPtr TriangleID, IntPtr PolygonGroupID, IntPtr VertexInstanceIDs, IntPtr NewEdgeIDs);

		// Token: 0x06021DAB RID: 138667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTriangle_Internal(IntPtr @this, IntPtr PolygonGroupID, IntPtr VertexInstanceIDs, IntPtr NewEdgeIDs);

		// Token: 0x06021DAC RID: 138668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreatePolygonWithID_Internal(IntPtr @this, IntPtr PolygonID, IntPtr PolygonGroupID, IntPtr VertexInstanceIDs, IntPtr NewEdgeIDs);

		// Token: 0x06021DAD RID: 138669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreatePolygonGroupWithID_Internal(IntPtr @this, IntPtr PolygonGroupID);

		// Token: 0x06021DAE RID: 138670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygonGroup_Internal(IntPtr @this);

		// Token: 0x06021DAF RID: 138671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygon_Internal(IntPtr @this, IntPtr PolygonGroupID, IntPtr VertexInstanceIDs, IntPtr NewEdgeIDs);

		// Token: 0x06021DB0 RID: 138672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateEdgeWithID_Internal(IntPtr @this, IntPtr EdgeID, IntPtr VertexID0, IntPtr VertexID1);

		// Token: 0x06021DB1 RID: 138673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateEdge_Internal(IntPtr @this, IntPtr VertexID0, IntPtr VertexID1);

		// Token: 0x06021DB2 RID: 138674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ComputePolygonTriangulation_Internal(IntPtr @this, IntPtr PolygonID);

		// Token: 0x06021DB3 RID: 138675 RVA: 0x00320840 File Offset: 0x0031EA40
		static UMeshDescriptionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshDescription.MeshDescriptionBase");
		}

		// Token: 0x06021DB4 RID: 138676 RVA: 0x0032084E File Offset: 0x0031EA4E
		protected UMeshDescriptionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040120A1 RID: 73889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.MeshDescriptionBase";

		// Token: 0x040120A2 RID: 73890
		private static IntPtr _ClassPtr;

		// Token: 0x040120A3 RID: 73891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
