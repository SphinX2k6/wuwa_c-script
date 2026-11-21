using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079D RID: 1949
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.RecastNavMesh")]
	[UnrealStructLayout(2424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2424)]
	public class ARecastNavMesh : ANavigationData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A86F RID: 43119 RVA: 0x000F8BB9 File Offset: 0x000F6DB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARecastNavMesh._ClassPtr;
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x000F8BC8 File Offset: 0x000F6DC8
		public ARecastNavMesh() : this(BuiltinUtils.AllocNativeUObject(ARecastNavMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A871 RID: 43121 RVA: 0x000F8BF0 File Offset: 0x000F6DF0
		public ARecastNavMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARecastNavMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600A872 RID: 43122 RVA: 0x000F8C24 File Offset: 0x000F6E24
		// (set) Token: 0x0600A873 RID: 43123 RVA: 0x000F8C5D File Offset: 0x000F6E5D
		public TMap<int, FName> WaterBodyIdToActorName
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._WaterBodyIdToActorName) == null)
				{
					result = (this._WaterBodyIdToActorName = new TMap<int, FName>(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_WaterBodyIdToActorName, this));
				}
				return result;
			}
			set
			{
				this.WaterBodyIdToActorName.CopyAssign(value);
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x000F8C6B File Offset: 0x000F6E6B
		// (set) Token: 0x0600A875 RID: 43125 RVA: 0x000F8C84 File Offset: 0x000F6E84
		public unsafe bool bDrawTriangleEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTriangleEdges) & ARecastNavMesh.__PropertyMask_bDrawTriangleEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTriangleEdges) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTriangleEdges) & ~ARecastNavMesh.__PropertyMask_bDrawTriangleEdges) | (value ? ARecastNavMesh.__PropertyMask_bDrawTriangleEdges : 0));
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600A876 RID: 43126 RVA: 0x000F8CB4 File Offset: 0x000F6EB4
		// (set) Token: 0x0600A877 RID: 43127 RVA: 0x000F8CCD File Offset: 0x000F6ECD
		public unsafe bool bDrawPolyEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolyEdges) & ARecastNavMesh.__PropertyMask_bDrawPolyEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolyEdges) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolyEdges) & ~ARecastNavMesh.__PropertyMask_bDrawPolyEdges) | (value ? ARecastNavMesh.__PropertyMask_bDrawPolyEdges : 0));
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x000F8CFD File Offset: 0x000F6EFD
		// (set) Token: 0x0600A879 RID: 43129 RVA: 0x000F8D16 File Offset: 0x000F6F16
		public unsafe bool bDrawFilledPolys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFilledPolys) & ARecastNavMesh.__PropertyMask_bDrawFilledPolys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFilledPolys) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFilledPolys) & ~ARecastNavMesh.__PropertyMask_bDrawFilledPolys) | (value ? ARecastNavMesh.__PropertyMask_bDrawFilledPolys : 0));
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600A87A RID: 43130 RVA: 0x000F8D46 File Offset: 0x000F6F46
		// (set) Token: 0x0600A87B RID: 43131 RVA: 0x000F8D5F File Offset: 0x000F6F5F
		public unsafe bool bDrawNavMeshEdges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavMeshEdges) & ARecastNavMesh.__PropertyMask_bDrawNavMeshEdges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavMeshEdges) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavMeshEdges) & ~ARecastNavMesh.__PropertyMask_bDrawNavMeshEdges) | (value ? ARecastNavMesh.__PropertyMask_bDrawNavMeshEdges : 0));
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600A87C RID: 43132 RVA: 0x000F8D8F File Offset: 0x000F6F8F
		// (set) Token: 0x0600A87D RID: 43133 RVA: 0x000F8DA8 File Offset: 0x000F6FA8
		public unsafe bool bDrawTileBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileBounds) & ARecastNavMesh.__PropertyMask_bDrawTileBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileBounds) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileBounds) & ~ARecastNavMesh.__PropertyMask_bDrawTileBounds) | (value ? ARecastNavMesh.__PropertyMask_bDrawTileBounds : 0));
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x000F8DD8 File Offset: 0x000F6FD8
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x000F8DF1 File Offset: 0x000F6FF1
		public unsafe bool bDrawPathCollidingGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPathCollidingGeometry) & ARecastNavMesh.__PropertyMask_bDrawPathCollidingGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPathCollidingGeometry) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPathCollidingGeometry) & ~ARecastNavMesh.__PropertyMask_bDrawPathCollidingGeometry) | (value ? ARecastNavMesh.__PropertyMask_bDrawPathCollidingGeometry : 0));
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x000F8E21 File Offset: 0x000F7021
		// (set) Token: 0x0600A881 RID: 43137 RVA: 0x000F8E3A File Offset: 0x000F703A
		public unsafe bool bDrawTileLabels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileLabels) & ARecastNavMesh.__PropertyMask_bDrawTileLabels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileLabels) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawTileLabels) & ~ARecastNavMesh.__PropertyMask_bDrawTileLabels) | (value ? ARecastNavMesh.__PropertyMask_bDrawTileLabels : 0));
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x000F8E6A File Offset: 0x000F706A
		// (set) Token: 0x0600A883 RID: 43139 RVA: 0x000F8E83 File Offset: 0x000F7083
		public unsafe bool bDrawPolygonLabels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolygonLabels) & ARecastNavMesh.__PropertyMask_bDrawPolygonLabels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolygonLabels) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawPolygonLabels) & ~ARecastNavMesh.__PropertyMask_bDrawPolygonLabels) | (value ? ARecastNavMesh.__PropertyMask_bDrawPolygonLabels : 0));
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x000F8EB3 File Offset: 0x000F70B3
		// (set) Token: 0x0600A885 RID: 43141 RVA: 0x000F8ECC File Offset: 0x000F70CC
		public unsafe bool bDrawDefaultPolygonCost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawDefaultPolygonCost) & ARecastNavMesh.__PropertyMask_bDrawDefaultPolygonCost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawDefaultPolygonCost) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawDefaultPolygonCost) & ~ARecastNavMesh.__PropertyMask_bDrawDefaultPolygonCost) | (value ? ARecastNavMesh.__PropertyMask_bDrawDefaultPolygonCost : 0));
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x000F8EFC File Offset: 0x000F70FC
		// (set) Token: 0x0600A887 RID: 43143 RVA: 0x000F8F15 File Offset: 0x000F7115
		public unsafe bool bDrawLabelsOnPathNodes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawLabelsOnPathNodes) & ARecastNavMesh.__PropertyMask_bDrawLabelsOnPathNodes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawLabelsOnPathNodes) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawLabelsOnPathNodes) & ~ARecastNavMesh.__PropertyMask_bDrawLabelsOnPathNodes) | (value ? ARecastNavMesh.__PropertyMask_bDrawLabelsOnPathNodes : 0));
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x000F8F45 File Offset: 0x000F7145
		// (set) Token: 0x0600A889 RID: 43145 RVA: 0x000F8F5E File Offset: 0x000F715E
		public unsafe bool bDrawNavLinks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavLinks) & ARecastNavMesh.__PropertyMask_bDrawNavLinks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavLinks) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawNavLinks) & ~ARecastNavMesh.__PropertyMask_bDrawNavLinks) | (value ? ARecastNavMesh.__PropertyMask_bDrawNavLinks : 0));
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600A88A RID: 43146 RVA: 0x000F8F8E File Offset: 0x000F718E
		// (set) Token: 0x0600A88B RID: 43147 RVA: 0x000F8FA7 File Offset: 0x000F71A7
		public unsafe bool bDrawFailedNavLinks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFailedNavLinks) & ARecastNavMesh.__PropertyMask_bDrawFailedNavLinks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFailedNavLinks) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawFailedNavLinks) & ~ARecastNavMesh.__PropertyMask_bDrawFailedNavLinks) | (value ? ARecastNavMesh.__PropertyMask_bDrawFailedNavLinks : 0));
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600A88C RID: 43148 RVA: 0x000F8FD7 File Offset: 0x000F71D7
		// (set) Token: 0x0600A88D RID: 43149 RVA: 0x000F8FF0 File Offset: 0x000F71F0
		public unsafe bool bDrawClusters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawClusters) & ARecastNavMesh.__PropertyMask_bDrawClusters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawClusters) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawClusters) & ~ARecastNavMesh.__PropertyMask_bDrawClusters) | (value ? ARecastNavMesh.__PropertyMask_bDrawClusters : 0));
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x000F9020 File Offset: 0x000F7220
		// (set) Token: 0x0600A88F RID: 43151 RVA: 0x000F9039 File Offset: 0x000F7239
		public unsafe bool bDrawOctree
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctree) & ARecastNavMesh.__PropertyMask_bDrawOctree) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctree) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctree) & ~ARecastNavMesh.__PropertyMask_bDrawOctree) | (value ? ARecastNavMesh.__PropertyMask_bDrawOctree : 0));
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x000F9069 File Offset: 0x000F7269
		// (set) Token: 0x0600A891 RID: 43153 RVA: 0x000F9082 File Offset: 0x000F7282
		public unsafe bool bDrawOctreeDetails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctreeDetails) & ARecastNavMesh.__PropertyMask_bDrawOctreeDetails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctreeDetails) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawOctreeDetails) & ~ARecastNavMesh.__PropertyMask_bDrawOctreeDetails) | (value ? ARecastNavMesh.__PropertyMask_bDrawOctreeDetails : 0));
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x000F90B2 File Offset: 0x000F72B2
		// (set) Token: 0x0600A893 RID: 43155 RVA: 0x000F90CB File Offset: 0x000F72CB
		public unsafe bool bDrawMarkedForbiddenPolys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawMarkedForbiddenPolys) & ARecastNavMesh.__PropertyMask_bDrawMarkedForbiddenPolys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawMarkedForbiddenPolys) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawMarkedForbiddenPolys) & ~ARecastNavMesh.__PropertyMask_bDrawMarkedForbiddenPolys) | (value ? ARecastNavMesh.__PropertyMask_bDrawMarkedForbiddenPolys : 0));
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x000F90FB File Offset: 0x000F72FB
		// (set) Token: 0x0600A895 RID: 43157 RVA: 0x000F9114 File Offset: 0x000F7314
		public unsafe bool bDrawRecastDebugData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawRecastDebugData) & ARecastNavMesh.__PropertyMask_bDrawRecastDebugData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawRecastDebugData) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawRecastDebugData) & ~ARecastNavMesh.__PropertyMask_bDrawRecastDebugData) | (value ? ARecastNavMesh.__PropertyMask_bDrawRecastDebugData : 0));
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600A896 RID: 43158 RVA: 0x000F9144 File Offset: 0x000F7344
		// (set) Token: 0x0600A897 RID: 43159 RVA: 0x000F915D File Offset: 0x000F735D
		public unsafe bool bDrawEnclosedBoolean
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawEnclosedBoolean) & ARecastNavMesh.__PropertyMask_bDrawEnclosedBoolean) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawEnclosedBoolean) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawEnclosedBoolean) & ~ARecastNavMesh.__PropertyMask_bDrawEnclosedBoolean) | (value ? ARecastNavMesh.__PropertyMask_bDrawEnclosedBoolean : 0));
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x000F918D File Offset: 0x000F738D
		// (set) Token: 0x0600A899 RID: 43161 RVA: 0x000F91A6 File Offset: 0x000F73A6
		public unsafe bool bDrawWaterFlooded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterFlooded) & ARecastNavMesh.__PropertyMask_bDrawWaterFlooded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterFlooded) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterFlooded) & ~ARecastNavMesh.__PropertyMask_bDrawWaterFlooded) | (value ? ARecastNavMesh.__PropertyMask_bDrawWaterFlooded : 0));
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x000F91D6 File Offset: 0x000F73D6
		// (set) Token: 0x0600A89B RID: 43163 RVA: 0x000F91EF File Offset: 0x000F73EF
		public unsafe bool bDrawWaterBasins
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBasins) & ARecastNavMesh.__PropertyMask_bDrawWaterBasins) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBasins) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBasins) & ~ARecastNavMesh.__PropertyMask_bDrawWaterBasins) | (value ? ARecastNavMesh.__PropertyMask_bDrawWaterBasins : 0));
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600A89C RID: 43164 RVA: 0x000F921F File Offset: 0x000F741F
		// (set) Token: 0x0600A89D RID: 43165 RVA: 0x000F9238 File Offset: 0x000F7438
		public unsafe bool bDrawWaterThresholdRows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterThresholdRows) & ARecastNavMesh.__PropertyMask_bDrawWaterThresholdRows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterThresholdRows) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterThresholdRows) & ~ARecastNavMesh.__PropertyMask_bDrawWaterThresholdRows) | (value ? ARecastNavMesh.__PropertyMask_bDrawWaterThresholdRows : 0));
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x0600A89E RID: 43166 RVA: 0x000F9268 File Offset: 0x000F7468
		// (set) Token: 0x0600A89F RID: 43167 RVA: 0x000F9281 File Offset: 0x000F7481
		public unsafe bool bDrawWaterBodyIds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBodyIds) & ARecastNavMesh.__PropertyMask_bDrawWaterBodyIds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBodyIds) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDrawWaterBodyIds) & ~ARecastNavMesh.__PropertyMask_bDrawWaterBodyIds) | (value ? ARecastNavMesh.__PropertyMask_bDrawWaterBodyIds : 0));
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x0600A8A0 RID: 43168 RVA: 0x000F92B1 File Offset: 0x000F74B1
		// (set) Token: 0x0600A8A1 RID: 43169 RVA: 0x000F92CA File Offset: 0x000F74CA
		public unsafe bool bDistinctlyDrawTilesBeingBuilt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDistinctlyDrawTilesBeingBuilt) & ARecastNavMesh.__PropertyMask_bDistinctlyDrawTilesBeingBuilt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDistinctlyDrawTilesBeingBuilt) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDistinctlyDrawTilesBeingBuilt) & ~ARecastNavMesh.__PropertyMask_bDistinctlyDrawTilesBeingBuilt) | (value ? ARecastNavMesh.__PropertyMask_bDistinctlyDrawTilesBeingBuilt : 0));
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x0600A8A2 RID: 43170 RVA: 0x000F92FA File Offset: 0x000F74FA
		// (set) Token: 0x0600A8A3 RID: 43171 RVA: 0x000F930A File Offset: 0x000F750A
		public unsafe float DrawOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DrawOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DrawOffset) = value;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x0600A8A4 RID: 43172 RVA: 0x000F931B File Offset: 0x000F751B
		// (set) Token: 0x0600A8A5 RID: 43173 RVA: 0x000F9334 File Offset: 0x000F7534
		public unsafe bool bFixedTilePoolSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFixedTilePoolSize) & ARecastNavMesh.__PropertyMask_bFixedTilePoolSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFixedTilePoolSize) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFixedTilePoolSize) & ~ARecastNavMesh.__PropertyMask_bFixedTilePoolSize) | (value ? ARecastNavMesh.__PropertyMask_bFixedTilePoolSize : 0));
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x000F9364 File Offset: 0x000F7564
		// (set) Token: 0x0600A8A7 RID: 43175 RVA: 0x000F9374 File Offset: 0x000F7574
		public unsafe int TilePoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TilePoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TilePoolSize) = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x000F9385 File Offset: 0x000F7585
		// (set) Token: 0x0600A8A9 RID: 43177 RVA: 0x000F9395 File Offset: 0x000F7595
		public unsafe float TileSizeUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileSizeUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileSizeUU) = value;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x000F93A6 File Offset: 0x000F75A6
		// (set) Token: 0x0600A8AB RID: 43179 RVA: 0x000F93B6 File Offset: 0x000F75B6
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x000F93C7 File Offset: 0x000F75C7
		// (set) Token: 0x0600A8AD RID: 43181 RVA: 0x000F93D7 File Offset: 0x000F75D7
		public unsafe float CellHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_CellHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_CellHeight) = value;
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x0600A8AE RID: 43182 RVA: 0x000F93E8 File Offset: 0x000F75E8
		// (set) Token: 0x0600A8AF RID: 43183 RVA: 0x000F93F8 File Offset: 0x000F75F8
		public unsafe float AgentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentRadius) = value;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x000F9409 File Offset: 0x000F7609
		// (set) Token: 0x0600A8B1 RID: 43185 RVA: 0x000F9419 File Offset: 0x000F7619
		public unsafe float AgentHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentHeight) = value;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x0600A8B2 RID: 43186 RVA: 0x000F942A File Offset: 0x000F762A
		// (set) Token: 0x0600A8B3 RID: 43187 RVA: 0x000F943A File Offset: 0x000F763A
		public unsafe float AgentMaxSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentMaxSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentMaxSlope) = value;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600A8B4 RID: 43188 RVA: 0x000F944B File Offset: 0x000F764B
		// (set) Token: 0x0600A8B5 RID: 43189 RVA: 0x000F945B File Offset: 0x000F765B
		public unsafe float AgentMaxStepHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentMaxStepHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_AgentMaxStepHeight) = value;
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x0600A8B6 RID: 43190 RVA: 0x000F946C File Offset: 0x000F766C
		// (set) Token: 0x0600A8B7 RID: 43191 RVA: 0x000F947C File Offset: 0x000F767C
		public unsafe float MinRegionArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MinRegionArea);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MinRegionArea) = value;
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600A8B8 RID: 43192 RVA: 0x000F948D File Offset: 0x000F768D
		// (set) Token: 0x0600A8B9 RID: 43193 RVA: 0x000F949D File Offset: 0x000F769D
		public unsafe float MergeRegionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MergeRegionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MergeRegionSize) = value;
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600A8BA RID: 43194 RVA: 0x000F94AE File Offset: 0x000F76AE
		// (set) Token: 0x0600A8BB RID: 43195 RVA: 0x000F94BE File Offset: 0x000F76BE
		public unsafe float MaxSimplificationError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MaxSimplificationError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MaxSimplificationError) = value;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x000F94CF File Offset: 0x000F76CF
		// (set) Token: 0x0600A8BD RID: 43197 RVA: 0x000F94DF File Offset: 0x000F76DF
		public unsafe float DetailSampleDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DetailSampleDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DetailSampleDist) = value;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x0600A8BE RID: 43198 RVA: 0x000F94F0 File Offset: 0x000F76F0
		// (set) Token: 0x0600A8BF RID: 43199 RVA: 0x000F9500 File Offset: 0x000F7700
		public unsafe int MaxSimultaneousTileGenerationJobsCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MaxSimultaneousTileGenerationJobsCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_MaxSimultaneousTileGenerationJobsCount) = value;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x0600A8C0 RID: 43200 RVA: 0x000F9511 File Offset: 0x000F7711
		// (set) Token: 0x0600A8C1 RID: 43201 RVA: 0x000F9521 File Offset: 0x000F7721
		public unsafe int TileNumberHardLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileNumberHardLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileNumberHardLimit) = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x000F9532 File Offset: 0x000F7732
		// (set) Token: 0x0600A8C3 RID: 43203 RVA: 0x000F9542 File Offset: 0x000F7742
		public unsafe int PolyRefTileBits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefTileBits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefTileBits) = value;
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x000F9553 File Offset: 0x000F7753
		// (set) Token: 0x0600A8C5 RID: 43205 RVA: 0x000F9563 File Offset: 0x000F7763
		public unsafe int PolyRefNavPolyBits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefNavPolyBits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefNavPolyBits) = value;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x0600A8C6 RID: 43206 RVA: 0x000F9574 File Offset: 0x000F7774
		// (set) Token: 0x0600A8C7 RID: 43207 RVA: 0x000F9584 File Offset: 0x000F7784
		public unsafe int PolyRefSaltBits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefSaltBits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_PolyRefSaltBits) = value;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x000F9595 File Offset: 0x000F7795
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x000F95A9 File Offset: 0x000F77A9
		public unsafe FVector NavMeshOriginOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_NavMeshOriginOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_NavMeshOriginOffset) = value;
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x000F95BE File Offset: 0x000F77BE
		// (set) Token: 0x0600A8CB RID: 43211 RVA: 0x000F95D7 File Offset: 0x000F77D7
		public unsafe bool bEnclosedSpaceTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnclosedSpaceTest) & ARecastNavMesh.__PropertyMask_bEnclosedSpaceTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnclosedSpaceTest) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnclosedSpaceTest) & ~ARecastNavMesh.__PropertyMask_bEnclosedSpaceTest) | (value ? ARecastNavMesh.__PropertyMask_bEnclosedSpaceTest : 0));
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x000F9607 File Offset: 0x000F7807
		// (set) Token: 0x0600A8CD RID: 43213 RVA: 0x000F9620 File Offset: 0x000F7820
		public unsafe bool bCullEnclosedSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bCullEnclosedSpace) & ARecastNavMesh.__PropertyMask_bCullEnclosedSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bCullEnclosedSpace) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bCullEnclosedSpace) & ~ARecastNavMesh.__PropertyMask_bCullEnclosedSpace) | (value ? ARecastNavMesh.__PropertyMask_bCullEnclosedSpace : 0));
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x000F9650 File Offset: 0x000F7850
		// (set) Token: 0x0600A8CF RID: 43215 RVA: 0x000F9669 File Offset: 0x000F7869
		public unsafe bool bIsWorldPartitioned
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bIsWorldPartitioned) & ARecastNavMesh.__PropertyMask_bIsWorldPartitioned) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bIsWorldPartitioned) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bIsWorldPartitioned) & ~ARecastNavMesh.__PropertyMask_bIsWorldPartitioned) | (value ? ARecastNavMesh.__PropertyMask_bIsWorldPartitioned : 0));
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x000F9699 File Offset: 0x000F7899
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x000F96B2 File Offset: 0x000F78B2
		public unsafe bool bEnableTileVariants
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnableTileVariants) & ARecastNavMesh.__PropertyMask_bEnableTileVariants) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnableTileVariants) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bEnableTileVariants) & ~ARecastNavMesh.__PropertyMask_bEnableTileVariants) | (value ? ARecastNavMesh.__PropertyMask_bEnableTileVariants : 0));
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x000F96E2 File Offset: 0x000F78E2
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x000F96F2 File Offset: 0x000F78F2
		public unsafe float DefaultDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultDrawDistance) = value;
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x000F9703 File Offset: 0x000F7903
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x000F9713 File Offset: 0x000F7913
		public unsafe float DefaultMaxSearchNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultMaxSearchNodes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultMaxSearchNodes) = value;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x000F9724 File Offset: 0x000F7924
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x000F9734 File Offset: 0x000F7934
		public unsafe float DefaultMaxHierarchicalSearchNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultMaxHierarchicalSearchNodes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_DefaultMaxHierarchicalSearchNodes) = value;
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x000F9745 File Offset: 0x000F7945
		// (set) Token: 0x0600A8D9 RID: 43225 RVA: 0x000F9755 File Offset: 0x000F7955
		public unsafe int RegionChunkSplits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_RegionChunkSplits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_RegionChunkSplits) = value;
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600A8DA RID: 43226 RVA: 0x000F9766 File Offset: 0x000F7966
		// (set) Token: 0x0600A8DB RID: 43227 RVA: 0x000F9776 File Offset: 0x000F7976
		public unsafe int LayerChunkSplits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_LayerChunkSplits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_LayerChunkSplits) = value;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x000F9787 File Offset: 0x000F7987
		// (set) Token: 0x0600A8DD RID: 43229 RVA: 0x000F97A0 File Offset: 0x000F79A0
		public unsafe bool bSortNavigationAreasByCost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bSortNavigationAreasByCost) & ARecastNavMesh.__PropertyMask_bSortNavigationAreasByCost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bSortNavigationAreasByCost) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bSortNavigationAreasByCost) & ~ARecastNavMesh.__PropertyMask_bSortNavigationAreasByCost) | (value ? ARecastNavMesh.__PropertyMask_bSortNavigationAreasByCost : 0));
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x000F97D0 File Offset: 0x000F79D0
		// (set) Token: 0x0600A8DF RID: 43231 RVA: 0x000F97E9 File Offset: 0x000F79E9
		public unsafe bool bPerformVoxelFiltering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bPerformVoxelFiltering) & ARecastNavMesh.__PropertyMask_bPerformVoxelFiltering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bPerformVoxelFiltering) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bPerformVoxelFiltering) & ~ARecastNavMesh.__PropertyMask_bPerformVoxelFiltering) | (value ? ARecastNavMesh.__PropertyMask_bPerformVoxelFiltering : 0));
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x000F9819 File Offset: 0x000F7A19
		// (set) Token: 0x0600A8E1 RID: 43233 RVA: 0x000F9832 File Offset: 0x000F7A32
		public unsafe bool bMarkLowHeightAreas
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bMarkLowHeightAreas) & ARecastNavMesh.__PropertyMask_bMarkLowHeightAreas) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bMarkLowHeightAreas) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bMarkLowHeightAreas) & ~ARecastNavMesh.__PropertyMask_bMarkLowHeightAreas) | (value ? ARecastNavMesh.__PropertyMask_bMarkLowHeightAreas : 0));
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x000F9862 File Offset: 0x000F7A62
		// (set) Token: 0x0600A8E3 RID: 43235 RVA: 0x000F987B File Offset: 0x000F7A7B
		public unsafe bool bUseExtraTopCellWhenMarkingAreas
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) & ARecastNavMesh.__PropertyMask_bUseExtraTopCellWhenMarkingAreas) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) & ~ARecastNavMesh.__PropertyMask_bUseExtraTopCellWhenMarkingAreas) | (value ? ARecastNavMesh.__PropertyMask_bUseExtraTopCellWhenMarkingAreas : 0));
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x000F98AB File Offset: 0x000F7AAB
		// (set) Token: 0x0600A8E5 RID: 43237 RVA: 0x000F98C4 File Offset: 0x000F7AC4
		public unsafe bool bFilterLowSpanSequences
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanSequences) & ARecastNavMesh.__PropertyMask_bFilterLowSpanSequences) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanSequences) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanSequences) & ~ARecastNavMesh.__PropertyMask_bFilterLowSpanSequences) | (value ? ARecastNavMesh.__PropertyMask_bFilterLowSpanSequences : 0));
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600A8E6 RID: 43238 RVA: 0x000F98F4 File Offset: 0x000F7AF4
		// (set) Token: 0x0600A8E7 RID: 43239 RVA: 0x000F990D File Offset: 0x000F7B0D
		public unsafe bool bFilterLowSpanFromTileCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanFromTileCache) & ARecastNavMesh.__PropertyMask_bFilterLowSpanFromTileCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanFromTileCache) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bFilterLowSpanFromTileCache) & ~ARecastNavMesh.__PropertyMask_bFilterLowSpanFromTileCache) | (value ? ARecastNavMesh.__PropertyMask_bFilterLowSpanFromTileCache : 0));
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x000F993D File Offset: 0x000F7B3D
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x000F9956 File Offset: 0x000F7B56
		public unsafe bool bDoFullyAsyncNavDataGathering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDoFullyAsyncNavDataGathering) & ARecastNavMesh.__PropertyMask_bDoFullyAsyncNavDataGathering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDoFullyAsyncNavDataGathering) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bDoFullyAsyncNavDataGathering) & ~ARecastNavMesh.__PropertyMask_bDoFullyAsyncNavDataGathering) | (value ? ARecastNavMesh.__PropertyMask_bDoFullyAsyncNavDataGathering : 0));
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x000F9986 File Offset: 0x000F7B86
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x000F999F File Offset: 0x000F7B9F
		public unsafe bool bUseBetterOffsetsFromCorners
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseBetterOffsetsFromCorners) & ARecastNavMesh.__PropertyMask_bUseBetterOffsetsFromCorners) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseBetterOffsetsFromCorners) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseBetterOffsetsFromCorners) & ~ARecastNavMesh.__PropertyMask_bUseBetterOffsetsFromCorners) | (value ? ARecastNavMesh.__PropertyMask_bUseBetterOffsetsFromCorners : 0));
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x000F99CF File Offset: 0x000F7BCF
		// (set) Token: 0x0600A8ED RID: 43245 RVA: 0x000F99E8 File Offset: 0x000F7BE8
		public unsafe bool bStoreEmptyTileLayers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bStoreEmptyTileLayers) & ARecastNavMesh.__PropertyMask_bStoreEmptyTileLayers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bStoreEmptyTileLayers) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bStoreEmptyTileLayers) & ~ARecastNavMesh.__PropertyMask_bStoreEmptyTileLayers) | (value ? ARecastNavMesh.__PropertyMask_bStoreEmptyTileLayers : 0));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x000F9A18 File Offset: 0x000F7C18
		// (set) Token: 0x0600A8EF RID: 43247 RVA: 0x000F9A31 File Offset: 0x000F7C31
		public unsafe bool bUseVirtualFilters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVirtualFilters) & ARecastNavMesh.__PropertyMask_bUseVirtualFilters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVirtualFilters) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVirtualFilters) & ~ARecastNavMesh.__PropertyMask_bUseVirtualFilters) | (value ? ARecastNavMesh.__PropertyMask_bUseVirtualFilters : 0));
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600A8F0 RID: 43248 RVA: 0x000F9A61 File Offset: 0x000F7C61
		// (set) Token: 0x0600A8F1 RID: 43249 RVA: 0x000F9A7A File Offset: 0x000F7C7A
		public unsafe bool bAllowNavLinkAsPathEnd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bAllowNavLinkAsPathEnd) & ARecastNavMesh.__PropertyMask_bAllowNavLinkAsPathEnd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bAllowNavLinkAsPathEnd) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bAllowNavLinkAsPathEnd) & ~ARecastNavMesh.__PropertyMask_bAllowNavLinkAsPathEnd) | (value ? ARecastNavMesh.__PropertyMask_bAllowNavLinkAsPathEnd : 0));
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600A8F2 RID: 43250 RVA: 0x000F9AAA File Offset: 0x000F7CAA
		// (set) Token: 0x0600A8F3 RID: 43251 RVA: 0x000F9AC3 File Offset: 0x000F7CC3
		public unsafe bool bUseVoxelCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVoxelCache) & ARecastNavMesh.__PropertyMask_bUseVoxelCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVoxelCache) = ((*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_bUseVoxelCache) & ~ARecastNavMesh.__PropertyMask_bUseVoxelCache) | (value ? ARecastNavMesh.__PropertyMask_bUseVoxelCache : 0));
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x000F9AF3 File Offset: 0x000F7CF3
		// (set) Token: 0x0600A8F5 RID: 43253 RVA: 0x000F9B03 File Offset: 0x000F7D03
		public unsafe float TileSetUpdateInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileSetUpdateInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_TileSetUpdateInterval) = value;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x0600A8F6 RID: 43254 RVA: 0x000F9B14 File Offset: 0x000F7D14
		// (set) Token: 0x0600A8F7 RID: 43255 RVA: 0x000F9B24 File Offset: 0x000F7D24
		public unsafe float HeuristicScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_HeuristicScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_HeuristicScale) = value;
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x000F9B35 File Offset: 0x000F7D35
		// (set) Token: 0x0600A8F9 RID: 43257 RVA: 0x000F9B45 File Offset: 0x000F7D45
		public unsafe float VerticalDeviationFromGroundCompensation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_VerticalDeviationFromGroundCompensation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_VerticalDeviationFromGroundCompensation) = value;
			}
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x000F9B56 File Offset: 0x000F7D56
		static ARecastNavMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.RecastNavMesh");
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x000F9B64 File Offset: 0x000F7D64
		protected ARecastNavMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004820 RID: 18464
		public new const string __ObjectPath = "/Script/NavigationSystem.RecastNavMesh";

		// Token: 0x04004821 RID: 18465
		private static IntPtr _ClassPtr;

		// Token: 0x04004822 RID: 18466
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004823 RID: 18467
		internal static int __PropertyOffset_WaterBodyIdToActorName;

		// Token: 0x04004824 RID: 18468
		[Nullable(2)]
		private TMap<int, FName> _WaterBodyIdToActorName;

		// Token: 0x04004825 RID: 18469
		internal static int __PropertyOffset_bDrawTriangleEdges;

		// Token: 0x04004826 RID: 18470
		internal static byte __PropertyMask_bDrawTriangleEdges;

		// Token: 0x04004827 RID: 18471
		internal static int __PropertyOffset_bDrawPolyEdges;

		// Token: 0x04004828 RID: 18472
		internal static byte __PropertyMask_bDrawPolyEdges;

		// Token: 0x04004829 RID: 18473
		internal static int __PropertyOffset_bDrawFilledPolys;

		// Token: 0x0400482A RID: 18474
		internal static byte __PropertyMask_bDrawFilledPolys;

		// Token: 0x0400482B RID: 18475
		internal static int __PropertyOffset_bDrawNavMeshEdges;

		// Token: 0x0400482C RID: 18476
		internal static byte __PropertyMask_bDrawNavMeshEdges;

		// Token: 0x0400482D RID: 18477
		internal static int __PropertyOffset_bDrawTileBounds;

		// Token: 0x0400482E RID: 18478
		internal static byte __PropertyMask_bDrawTileBounds;

		// Token: 0x0400482F RID: 18479
		internal static int __PropertyOffset_bDrawPathCollidingGeometry;

		// Token: 0x04004830 RID: 18480
		internal static byte __PropertyMask_bDrawPathCollidingGeometry;

		// Token: 0x04004831 RID: 18481
		internal static int __PropertyOffset_bDrawTileLabels;

		// Token: 0x04004832 RID: 18482
		internal static byte __PropertyMask_bDrawTileLabels;

		// Token: 0x04004833 RID: 18483
		internal static int __PropertyOffset_bDrawPolygonLabels;

		// Token: 0x04004834 RID: 18484
		internal static byte __PropertyMask_bDrawPolygonLabels;

		// Token: 0x04004835 RID: 18485
		internal static int __PropertyOffset_bDrawDefaultPolygonCost;

		// Token: 0x04004836 RID: 18486
		internal static byte __PropertyMask_bDrawDefaultPolygonCost;

		// Token: 0x04004837 RID: 18487
		internal static int __PropertyOffset_bDrawLabelsOnPathNodes;

		// Token: 0x04004838 RID: 18488
		internal static byte __PropertyMask_bDrawLabelsOnPathNodes;

		// Token: 0x04004839 RID: 18489
		internal static int __PropertyOffset_bDrawNavLinks;

		// Token: 0x0400483A RID: 18490
		internal static byte __PropertyMask_bDrawNavLinks;

		// Token: 0x0400483B RID: 18491
		internal static int __PropertyOffset_bDrawFailedNavLinks;

		// Token: 0x0400483C RID: 18492
		internal static byte __PropertyMask_bDrawFailedNavLinks;

		// Token: 0x0400483D RID: 18493
		internal static int __PropertyOffset_bDrawClusters;

		// Token: 0x0400483E RID: 18494
		internal static byte __PropertyMask_bDrawClusters;

		// Token: 0x0400483F RID: 18495
		internal static int __PropertyOffset_bDrawOctree;

		// Token: 0x04004840 RID: 18496
		internal static byte __PropertyMask_bDrawOctree;

		// Token: 0x04004841 RID: 18497
		internal static int __PropertyOffset_bDrawOctreeDetails;

		// Token: 0x04004842 RID: 18498
		internal static byte __PropertyMask_bDrawOctreeDetails;

		// Token: 0x04004843 RID: 18499
		internal static int __PropertyOffset_bDrawMarkedForbiddenPolys;

		// Token: 0x04004844 RID: 18500
		internal static byte __PropertyMask_bDrawMarkedForbiddenPolys;

		// Token: 0x04004845 RID: 18501
		internal static int __PropertyOffset_bDrawRecastDebugData;

		// Token: 0x04004846 RID: 18502
		internal static byte __PropertyMask_bDrawRecastDebugData;

		// Token: 0x04004847 RID: 18503
		internal static int __PropertyOffset_bDrawEnclosedBoolean;

		// Token: 0x04004848 RID: 18504
		internal static byte __PropertyMask_bDrawEnclosedBoolean;

		// Token: 0x04004849 RID: 18505
		internal static int __PropertyOffset_bDrawWaterFlooded;

		// Token: 0x0400484A RID: 18506
		internal static byte __PropertyMask_bDrawWaterFlooded;

		// Token: 0x0400484B RID: 18507
		internal static int __PropertyOffset_bDrawWaterBasins;

		// Token: 0x0400484C RID: 18508
		internal static byte __PropertyMask_bDrawWaterBasins;

		// Token: 0x0400484D RID: 18509
		internal static int __PropertyOffset_bDrawWaterThresholdRows;

		// Token: 0x0400484E RID: 18510
		internal static byte __PropertyMask_bDrawWaterThresholdRows;

		// Token: 0x0400484F RID: 18511
		internal static int __PropertyOffset_bDrawWaterBodyIds;

		// Token: 0x04004850 RID: 18512
		internal static byte __PropertyMask_bDrawWaterBodyIds;

		// Token: 0x04004851 RID: 18513
		internal static int __PropertyOffset_bDistinctlyDrawTilesBeingBuilt;

		// Token: 0x04004852 RID: 18514
		internal static byte __PropertyMask_bDistinctlyDrawTilesBeingBuilt;

		// Token: 0x04004853 RID: 18515
		internal static int __PropertyOffset_DrawOffset;

		// Token: 0x04004854 RID: 18516
		internal static int __PropertyOffset_bFixedTilePoolSize;

		// Token: 0x04004855 RID: 18517
		internal static byte __PropertyMask_bFixedTilePoolSize;

		// Token: 0x04004856 RID: 18518
		internal static int __PropertyOffset_TilePoolSize;

		// Token: 0x04004857 RID: 18519
		internal static int __PropertyOffset_TileSizeUU;

		// Token: 0x04004858 RID: 18520
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04004859 RID: 18521
		internal static int __PropertyOffset_CellHeight;

		// Token: 0x0400485A RID: 18522
		internal static int __PropertyOffset_AgentRadius;

		// Token: 0x0400485B RID: 18523
		internal static int __PropertyOffset_AgentHeight;

		// Token: 0x0400485C RID: 18524
		internal static int __PropertyOffset_AgentMaxSlope;

		// Token: 0x0400485D RID: 18525
		internal static int __PropertyOffset_AgentMaxStepHeight;

		// Token: 0x0400485E RID: 18526
		internal static int __PropertyOffset_MinRegionArea;

		// Token: 0x0400485F RID: 18527
		internal static int __PropertyOffset_MergeRegionSize;

		// Token: 0x04004860 RID: 18528
		internal static int __PropertyOffset_MaxSimplificationError;

		// Token: 0x04004861 RID: 18529
		internal static int __PropertyOffset_DetailSampleDist;

		// Token: 0x04004862 RID: 18530
		internal static int __PropertyOffset_MaxSimultaneousTileGenerationJobsCount;

		// Token: 0x04004863 RID: 18531
		internal static int __PropertyOffset_TileNumberHardLimit;

		// Token: 0x04004864 RID: 18532
		internal static int __PropertyOffset_PolyRefTileBits;

		// Token: 0x04004865 RID: 18533
		internal static int __PropertyOffset_PolyRefNavPolyBits;

		// Token: 0x04004866 RID: 18534
		internal static int __PropertyOffset_PolyRefSaltBits;

		// Token: 0x04004867 RID: 18535
		internal static int __PropertyOffset_NavMeshOriginOffset;

		// Token: 0x04004868 RID: 18536
		internal static int __PropertyOffset_bEnclosedSpaceTest;

		// Token: 0x04004869 RID: 18537
		internal static byte __PropertyMask_bEnclosedSpaceTest;

		// Token: 0x0400486A RID: 18538
		internal static int __PropertyOffset_bCullEnclosedSpace;

		// Token: 0x0400486B RID: 18539
		internal static byte __PropertyMask_bCullEnclosedSpace;

		// Token: 0x0400486C RID: 18540
		internal static int __PropertyOffset_bIsWorldPartitioned;

		// Token: 0x0400486D RID: 18541
		internal static byte __PropertyMask_bIsWorldPartitioned;

		// Token: 0x0400486E RID: 18542
		internal static int __PropertyOffset_bEnableTileVariants;

		// Token: 0x0400486F RID: 18543
		internal static byte __PropertyMask_bEnableTileVariants;

		// Token: 0x04004870 RID: 18544
		internal static int __PropertyOffset_DefaultDrawDistance;

		// Token: 0x04004871 RID: 18545
		internal static int __PropertyOffset_DefaultMaxSearchNodes;

		// Token: 0x04004872 RID: 18546
		internal static int __PropertyOffset_DefaultMaxHierarchicalSearchNodes;

		// Token: 0x04004873 RID: 18547
		internal static int __PropertyOffset_RegionChunkSplits;

		// Token: 0x04004874 RID: 18548
		internal static int __PropertyOffset_LayerChunkSplits;

		// Token: 0x04004875 RID: 18549
		internal static int __PropertyOffset_bSortNavigationAreasByCost;

		// Token: 0x04004876 RID: 18550
		internal static byte __PropertyMask_bSortNavigationAreasByCost;

		// Token: 0x04004877 RID: 18551
		internal static int __PropertyOffset_bPerformVoxelFiltering;

		// Token: 0x04004878 RID: 18552
		internal static byte __PropertyMask_bPerformVoxelFiltering;

		// Token: 0x04004879 RID: 18553
		internal static int __PropertyOffset_bMarkLowHeightAreas;

		// Token: 0x0400487A RID: 18554
		internal static byte __PropertyMask_bMarkLowHeightAreas;

		// Token: 0x0400487B RID: 18555
		internal static int __PropertyOffset_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x0400487C RID: 18556
		internal static byte __PropertyMask_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x0400487D RID: 18557
		internal static int __PropertyOffset_bFilterLowSpanSequences;

		// Token: 0x0400487E RID: 18558
		internal static byte __PropertyMask_bFilterLowSpanSequences;

		// Token: 0x0400487F RID: 18559
		internal static int __PropertyOffset_bFilterLowSpanFromTileCache;

		// Token: 0x04004880 RID: 18560
		internal static byte __PropertyMask_bFilterLowSpanFromTileCache;

		// Token: 0x04004881 RID: 18561
		internal static int __PropertyOffset_bDoFullyAsyncNavDataGathering;

		// Token: 0x04004882 RID: 18562
		internal static byte __PropertyMask_bDoFullyAsyncNavDataGathering;

		// Token: 0x04004883 RID: 18563
		internal static int __PropertyOffset_bUseBetterOffsetsFromCorners;

		// Token: 0x04004884 RID: 18564
		internal static byte __PropertyMask_bUseBetterOffsetsFromCorners;

		// Token: 0x04004885 RID: 18565
		internal static int __PropertyOffset_bStoreEmptyTileLayers;

		// Token: 0x04004886 RID: 18566
		internal static byte __PropertyMask_bStoreEmptyTileLayers;

		// Token: 0x04004887 RID: 18567
		internal static int __PropertyOffset_bUseVirtualFilters;

		// Token: 0x04004888 RID: 18568
		internal static byte __PropertyMask_bUseVirtualFilters;

		// Token: 0x04004889 RID: 18569
		internal static int __PropertyOffset_bAllowNavLinkAsPathEnd;

		// Token: 0x0400488A RID: 18570
		internal static byte __PropertyMask_bAllowNavLinkAsPathEnd;

		// Token: 0x0400488B RID: 18571
		internal static int __PropertyOffset_bUseVoxelCache;

		// Token: 0x0400488C RID: 18572
		internal static byte __PropertyMask_bUseVoxelCache;

		// Token: 0x0400488D RID: 18573
		internal static int __PropertyOffset_TileSetUpdateInterval;

		// Token: 0x0400488E RID: 18574
		internal static int __PropertyOffset_HeuristicScale;

		// Token: 0x0400488F RID: 18575
		internal static int __PropertyOffset_VerticalDeviationFromGroundCompensation;
	}
}
