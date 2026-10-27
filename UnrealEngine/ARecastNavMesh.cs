using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024AD RID: 9389
	[UnrealObjectPath("/Script/NavigationSystem.RecastNavMesh")]
	[UnrealStructLayout(2096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2096)]
	public class ARecastNavMesh : ANavigationData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231FD RID: 143869 RVA: 0x0033F256 File Offset: 0x0033D456
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARecastNavMesh._ClassPtr;
		}

		// Token: 0x060231FE RID: 143870 RVA: 0x0033F264 File Offset: 0x0033D464
		public ARecastNavMesh() : this(BuiltinUtils.AllocNativeUObject(ARecastNavMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231FF RID: 143871 RVA: 0x0033F28C File Offset: 0x0033D48C
		[NullableContext(1)]
		public ARecastNavMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARecastNavMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086EA RID: 34538
		// (get) Token: 0x06023200 RID: 143872 RVA: 0x0033F2C0 File Offset: 0x0033D4C0
		// (set) Token: 0x06023201 RID: 143873 RVA: 0x0033F2F9 File Offset: 0x0033D4F9
		[Nullable(1)]
		public TMap<int, FName> WaterBodyIdToActorName
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.WaterBodyIdToActorName.CopyAssign(value);
			}
		}

		// Token: 0x170086EB RID: 34539
		// (get) Token: 0x06023202 RID: 143874 RVA: 0x0033F308 File Offset: 0x0033D508
		// (set) Token: 0x06023203 RID: 143875 RVA: 0x0033F341 File Offset: 0x0033D541
		[Nullable(1)]
		public TMap<FIntPoint, FWaterBasinThresholdRows> WaterBasinThresholds
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FIntPoint, FWaterBasinThresholdRows> result;
				if ((result = this._WaterBasinThresholds) == null)
				{
					result = (this._WaterBasinThresholds = new TMap<FIntPoint, FWaterBasinThresholdRows>(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_WaterBasinThresholds, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WaterBasinThresholds.CopyAssign(value);
			}
		}

		// Token: 0x170086EC RID: 34540
		// (get) Token: 0x06023204 RID: 143876 RVA: 0x0033F34F File Offset: 0x0033D54F
		// (set) Token: 0x06023205 RID: 143877 RVA: 0x0033F368 File Offset: 0x0033D568
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

		// Token: 0x170086ED RID: 34541
		// (get) Token: 0x06023206 RID: 143878 RVA: 0x0033F398 File Offset: 0x0033D598
		// (set) Token: 0x06023207 RID: 143879 RVA: 0x0033F3B1 File Offset: 0x0033D5B1
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

		// Token: 0x170086EE RID: 34542
		// (get) Token: 0x06023208 RID: 143880 RVA: 0x0033F3E1 File Offset: 0x0033D5E1
		// (set) Token: 0x06023209 RID: 143881 RVA: 0x0033F3FA File Offset: 0x0033D5FA
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

		// Token: 0x170086EF RID: 34543
		// (get) Token: 0x0602320A RID: 143882 RVA: 0x0033F42A File Offset: 0x0033D62A
		// (set) Token: 0x0602320B RID: 143883 RVA: 0x0033F443 File Offset: 0x0033D643
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

		// Token: 0x170086F0 RID: 34544
		// (get) Token: 0x0602320C RID: 143884 RVA: 0x0033F473 File Offset: 0x0033D673
		// (set) Token: 0x0602320D RID: 143885 RVA: 0x0033F48C File Offset: 0x0033D68C
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

		// Token: 0x170086F1 RID: 34545
		// (get) Token: 0x0602320E RID: 143886 RVA: 0x0033F4BC File Offset: 0x0033D6BC
		// (set) Token: 0x0602320F RID: 143887 RVA: 0x0033F4D5 File Offset: 0x0033D6D5
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

		// Token: 0x170086F2 RID: 34546
		// (get) Token: 0x06023210 RID: 143888 RVA: 0x0033F505 File Offset: 0x0033D705
		// (set) Token: 0x06023211 RID: 143889 RVA: 0x0033F51E File Offset: 0x0033D71E
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

		// Token: 0x170086F3 RID: 34547
		// (get) Token: 0x06023212 RID: 143890 RVA: 0x0033F54E File Offset: 0x0033D74E
		// (set) Token: 0x06023213 RID: 143891 RVA: 0x0033F567 File Offset: 0x0033D767
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

		// Token: 0x170086F4 RID: 34548
		// (get) Token: 0x06023214 RID: 143892 RVA: 0x0033F597 File Offset: 0x0033D797
		// (set) Token: 0x06023215 RID: 143893 RVA: 0x0033F5B0 File Offset: 0x0033D7B0
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

		// Token: 0x170086F5 RID: 34549
		// (get) Token: 0x06023216 RID: 143894 RVA: 0x0033F5E0 File Offset: 0x0033D7E0
		// (set) Token: 0x06023217 RID: 143895 RVA: 0x0033F5F9 File Offset: 0x0033D7F9
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

		// Token: 0x170086F6 RID: 34550
		// (get) Token: 0x06023218 RID: 143896 RVA: 0x0033F629 File Offset: 0x0033D829
		// (set) Token: 0x06023219 RID: 143897 RVA: 0x0033F642 File Offset: 0x0033D842
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

		// Token: 0x170086F7 RID: 34551
		// (get) Token: 0x0602321A RID: 143898 RVA: 0x0033F672 File Offset: 0x0033D872
		// (set) Token: 0x0602321B RID: 143899 RVA: 0x0033F68B File Offset: 0x0033D88B
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

		// Token: 0x170086F8 RID: 34552
		// (get) Token: 0x0602321C RID: 143900 RVA: 0x0033F6BB File Offset: 0x0033D8BB
		// (set) Token: 0x0602321D RID: 143901 RVA: 0x0033F6D4 File Offset: 0x0033D8D4
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

		// Token: 0x170086F9 RID: 34553
		// (get) Token: 0x0602321E RID: 143902 RVA: 0x0033F704 File Offset: 0x0033D904
		// (set) Token: 0x0602321F RID: 143903 RVA: 0x0033F71D File Offset: 0x0033D91D
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

		// Token: 0x170086FA RID: 34554
		// (get) Token: 0x06023220 RID: 143904 RVA: 0x0033F74D File Offset: 0x0033D94D
		// (set) Token: 0x06023221 RID: 143905 RVA: 0x0033F766 File Offset: 0x0033D966
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

		// Token: 0x170086FB RID: 34555
		// (get) Token: 0x06023222 RID: 143906 RVA: 0x0033F796 File Offset: 0x0033D996
		// (set) Token: 0x06023223 RID: 143907 RVA: 0x0033F7AF File Offset: 0x0033D9AF
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

		// Token: 0x170086FC RID: 34556
		// (get) Token: 0x06023224 RID: 143908 RVA: 0x0033F7DF File Offset: 0x0033D9DF
		// (set) Token: 0x06023225 RID: 143909 RVA: 0x0033F7F8 File Offset: 0x0033D9F8
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

		// Token: 0x170086FD RID: 34557
		// (get) Token: 0x06023226 RID: 143910 RVA: 0x0033F828 File Offset: 0x0033DA28
		// (set) Token: 0x06023227 RID: 143911 RVA: 0x0033F841 File Offset: 0x0033DA41
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

		// Token: 0x170086FE RID: 34558
		// (get) Token: 0x06023228 RID: 143912 RVA: 0x0033F871 File Offset: 0x0033DA71
		// (set) Token: 0x06023229 RID: 143913 RVA: 0x0033F88A File Offset: 0x0033DA8A
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

		// Token: 0x170086FF RID: 34559
		// (get) Token: 0x0602322A RID: 143914 RVA: 0x0033F8BA File Offset: 0x0033DABA
		// (set) Token: 0x0602322B RID: 143915 RVA: 0x0033F8D3 File Offset: 0x0033DAD3
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

		// Token: 0x17008700 RID: 34560
		// (get) Token: 0x0602322C RID: 143916 RVA: 0x0033F903 File Offset: 0x0033DB03
		// (set) Token: 0x0602322D RID: 143917 RVA: 0x0033F91C File Offset: 0x0033DB1C
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

		// Token: 0x17008701 RID: 34561
		// (get) Token: 0x0602322E RID: 143918 RVA: 0x0033F94C File Offset: 0x0033DB4C
		// (set) Token: 0x0602322F RID: 143919 RVA: 0x0033F95C File Offset: 0x0033DB5C
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

		// Token: 0x17008702 RID: 34562
		// (get) Token: 0x06023230 RID: 143920 RVA: 0x0033F96D File Offset: 0x0033DB6D
		// (set) Token: 0x06023231 RID: 143921 RVA: 0x0033F986 File Offset: 0x0033DB86
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

		// Token: 0x17008703 RID: 34563
		// (get) Token: 0x06023232 RID: 143922 RVA: 0x0033F9B6 File Offset: 0x0033DBB6
		// (set) Token: 0x06023233 RID: 143923 RVA: 0x0033F9C6 File Offset: 0x0033DBC6
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

		// Token: 0x17008704 RID: 34564
		// (get) Token: 0x06023234 RID: 143924 RVA: 0x0033F9D7 File Offset: 0x0033DBD7
		// (set) Token: 0x06023235 RID: 143925 RVA: 0x0033F9E7 File Offset: 0x0033DBE7
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

		// Token: 0x17008705 RID: 34565
		// (get) Token: 0x06023236 RID: 143926 RVA: 0x0033F9F8 File Offset: 0x0033DBF8
		// (set) Token: 0x06023237 RID: 143927 RVA: 0x0033FA08 File Offset: 0x0033DC08
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

		// Token: 0x17008706 RID: 34566
		// (get) Token: 0x06023238 RID: 143928 RVA: 0x0033FA19 File Offset: 0x0033DC19
		// (set) Token: 0x06023239 RID: 143929 RVA: 0x0033FA29 File Offset: 0x0033DC29
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

		// Token: 0x17008707 RID: 34567
		// (get) Token: 0x0602323A RID: 143930 RVA: 0x0033FA3A File Offset: 0x0033DC3A
		// (set) Token: 0x0602323B RID: 143931 RVA: 0x0033FA4A File Offset: 0x0033DC4A
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

		// Token: 0x17008708 RID: 34568
		// (get) Token: 0x0602323C RID: 143932 RVA: 0x0033FA5B File Offset: 0x0033DC5B
		// (set) Token: 0x0602323D RID: 143933 RVA: 0x0033FA6B File Offset: 0x0033DC6B
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

		// Token: 0x17008709 RID: 34569
		// (get) Token: 0x0602323E RID: 143934 RVA: 0x0033FA7C File Offset: 0x0033DC7C
		// (set) Token: 0x0602323F RID: 143935 RVA: 0x0033FA8C File Offset: 0x0033DC8C
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

		// Token: 0x1700870A RID: 34570
		// (get) Token: 0x06023240 RID: 143936 RVA: 0x0033FA9D File Offset: 0x0033DC9D
		// (set) Token: 0x06023241 RID: 143937 RVA: 0x0033FAAD File Offset: 0x0033DCAD
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

		// Token: 0x1700870B RID: 34571
		// (get) Token: 0x06023242 RID: 143938 RVA: 0x0033FABE File Offset: 0x0033DCBE
		// (set) Token: 0x06023243 RID: 143939 RVA: 0x0033FACE File Offset: 0x0033DCCE
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

		// Token: 0x1700870C RID: 34572
		// (get) Token: 0x06023244 RID: 143940 RVA: 0x0033FADF File Offset: 0x0033DCDF
		// (set) Token: 0x06023245 RID: 143941 RVA: 0x0033FAEF File Offset: 0x0033DCEF
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

		// Token: 0x1700870D RID: 34573
		// (get) Token: 0x06023246 RID: 143942 RVA: 0x0033FB00 File Offset: 0x0033DD00
		// (set) Token: 0x06023247 RID: 143943 RVA: 0x0033FB10 File Offset: 0x0033DD10
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

		// Token: 0x1700870E RID: 34574
		// (get) Token: 0x06023248 RID: 143944 RVA: 0x0033FB21 File Offset: 0x0033DD21
		// (set) Token: 0x06023249 RID: 143945 RVA: 0x0033FB31 File Offset: 0x0033DD31
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

		// Token: 0x1700870F RID: 34575
		// (get) Token: 0x0602324A RID: 143946 RVA: 0x0033FB42 File Offset: 0x0033DD42
		// (set) Token: 0x0602324B RID: 143947 RVA: 0x0033FB52 File Offset: 0x0033DD52
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

		// Token: 0x17008710 RID: 34576
		// (get) Token: 0x0602324C RID: 143948 RVA: 0x0033FB63 File Offset: 0x0033DD63
		// (set) Token: 0x0602324D RID: 143949 RVA: 0x0033FB73 File Offset: 0x0033DD73
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

		// Token: 0x17008711 RID: 34577
		// (get) Token: 0x0602324E RID: 143950 RVA: 0x0033FB84 File Offset: 0x0033DD84
		// (set) Token: 0x0602324F RID: 143951 RVA: 0x0033FB94 File Offset: 0x0033DD94
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

		// Token: 0x17008712 RID: 34578
		// (get) Token: 0x06023250 RID: 143952 RVA: 0x0033FBA5 File Offset: 0x0033DDA5
		// (set) Token: 0x06023251 RID: 143953 RVA: 0x0033FBB5 File Offset: 0x0033DDB5
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

		// Token: 0x17008713 RID: 34579
		// (get) Token: 0x06023252 RID: 143954 RVA: 0x0033FBC6 File Offset: 0x0033DDC6
		// (set) Token: 0x06023253 RID: 143955 RVA: 0x0033FBD6 File Offset: 0x0033DDD6
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

		// Token: 0x17008714 RID: 34580
		// (get) Token: 0x06023254 RID: 143956 RVA: 0x0033FBE7 File Offset: 0x0033DDE7
		// (set) Token: 0x06023255 RID: 143957 RVA: 0x0033FBFB File Offset: 0x0033DDFB
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

		// Token: 0x17008715 RID: 34581
		// (get) Token: 0x06023256 RID: 143958 RVA: 0x0033FC10 File Offset: 0x0033DE10
		// (set) Token: 0x06023257 RID: 143959 RVA: 0x0033FC29 File Offset: 0x0033DE29
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

		// Token: 0x17008716 RID: 34582
		// (get) Token: 0x06023258 RID: 143960 RVA: 0x0033FC59 File Offset: 0x0033DE59
		// (set) Token: 0x06023259 RID: 143961 RVA: 0x0033FC72 File Offset: 0x0033DE72
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

		// Token: 0x17008717 RID: 34583
		// (get) Token: 0x0602325A RID: 143962 RVA: 0x0033FCA2 File Offset: 0x0033DEA2
		// (set) Token: 0x0602325B RID: 143963 RVA: 0x0033FCBB File Offset: 0x0033DEBB
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

		// Token: 0x17008718 RID: 34584
		// (get) Token: 0x0602325C RID: 143964 RVA: 0x0033FCEB File Offset: 0x0033DEEB
		// (set) Token: 0x0602325D RID: 143965 RVA: 0x0033FD04 File Offset: 0x0033DF04
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

		// Token: 0x17008719 RID: 34585
		// (get) Token: 0x0602325E RID: 143966 RVA: 0x0033FD34 File Offset: 0x0033DF34
		// (set) Token: 0x0602325F RID: 143967 RVA: 0x0033FD44 File Offset: 0x0033DF44
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

		// Token: 0x1700871A RID: 34586
		// (get) Token: 0x06023260 RID: 143968 RVA: 0x0033FD55 File Offset: 0x0033DF55
		// (set) Token: 0x06023261 RID: 143969 RVA: 0x0033FD65 File Offset: 0x0033DF65
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

		// Token: 0x1700871B RID: 34587
		// (get) Token: 0x06023262 RID: 143970 RVA: 0x0033FD76 File Offset: 0x0033DF76
		// (set) Token: 0x06023263 RID: 143971 RVA: 0x0033FD86 File Offset: 0x0033DF86
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

		// Token: 0x1700871C RID: 34588
		// (get) Token: 0x06023264 RID: 143972 RVA: 0x0033FD97 File Offset: 0x0033DF97
		// (set) Token: 0x06023265 RID: 143973 RVA: 0x0033FDAB File Offset: 0x0033DFAB
		public unsafe TEnumAsByte<ERecastPartitioning> RegionPartitioning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_RegionPartitioning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_RegionPartitioning) = value;
			}
		}

		// Token: 0x1700871D RID: 34589
		// (get) Token: 0x06023266 RID: 143974 RVA: 0x0033FDC0 File Offset: 0x0033DFC0
		// (set) Token: 0x06023267 RID: 143975 RVA: 0x0033FDD4 File Offset: 0x0033DFD4
		public unsafe TEnumAsByte<ERecastPartitioning> LayerPartitioning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_LayerPartitioning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ARecastNavMesh.__PropertyOffset_LayerPartitioning) = value;
			}
		}

		// Token: 0x1700871E RID: 34590
		// (get) Token: 0x06023268 RID: 143976 RVA: 0x0033FDE9 File Offset: 0x0033DFE9
		// (set) Token: 0x06023269 RID: 143977 RVA: 0x0033FDF9 File Offset: 0x0033DFF9
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

		// Token: 0x1700871F RID: 34591
		// (get) Token: 0x0602326A RID: 143978 RVA: 0x0033FE0A File Offset: 0x0033E00A
		// (set) Token: 0x0602326B RID: 143979 RVA: 0x0033FE1A File Offset: 0x0033E01A
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

		// Token: 0x17008720 RID: 34592
		// (get) Token: 0x0602326C RID: 143980 RVA: 0x0033FE2B File Offset: 0x0033E02B
		// (set) Token: 0x0602326D RID: 143981 RVA: 0x0033FE44 File Offset: 0x0033E044
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

		// Token: 0x17008721 RID: 34593
		// (get) Token: 0x0602326E RID: 143982 RVA: 0x0033FE74 File Offset: 0x0033E074
		// (set) Token: 0x0602326F RID: 143983 RVA: 0x0033FE8D File Offset: 0x0033E08D
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

		// Token: 0x17008722 RID: 34594
		// (get) Token: 0x06023270 RID: 143984 RVA: 0x0033FEBD File Offset: 0x0033E0BD
		// (set) Token: 0x06023271 RID: 143985 RVA: 0x0033FED6 File Offset: 0x0033E0D6
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

		// Token: 0x17008723 RID: 34595
		// (get) Token: 0x06023272 RID: 143986 RVA: 0x0033FF06 File Offset: 0x0033E106
		// (set) Token: 0x06023273 RID: 143987 RVA: 0x0033FF1F File Offset: 0x0033E11F
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

		// Token: 0x17008724 RID: 34596
		// (get) Token: 0x06023274 RID: 143988 RVA: 0x0033FF4F File Offset: 0x0033E14F
		// (set) Token: 0x06023275 RID: 143989 RVA: 0x0033FF68 File Offset: 0x0033E168
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

		// Token: 0x17008725 RID: 34597
		// (get) Token: 0x06023276 RID: 143990 RVA: 0x0033FF98 File Offset: 0x0033E198
		// (set) Token: 0x06023277 RID: 143991 RVA: 0x0033FFB1 File Offset: 0x0033E1B1
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

		// Token: 0x17008726 RID: 34598
		// (get) Token: 0x06023278 RID: 143992 RVA: 0x0033FFE1 File Offset: 0x0033E1E1
		// (set) Token: 0x06023279 RID: 143993 RVA: 0x0033FFFA File Offset: 0x0033E1FA
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

		// Token: 0x17008727 RID: 34599
		// (get) Token: 0x0602327A RID: 143994 RVA: 0x0034002A File Offset: 0x0033E22A
		// (set) Token: 0x0602327B RID: 143995 RVA: 0x00340043 File Offset: 0x0033E243
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

		// Token: 0x17008728 RID: 34600
		// (get) Token: 0x0602327C RID: 143996 RVA: 0x00340073 File Offset: 0x0033E273
		// (set) Token: 0x0602327D RID: 143997 RVA: 0x0034008C File Offset: 0x0033E28C
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

		// Token: 0x17008729 RID: 34601
		// (get) Token: 0x0602327E RID: 143998 RVA: 0x003400BC File Offset: 0x0033E2BC
		// (set) Token: 0x0602327F RID: 143999 RVA: 0x003400D5 File Offset: 0x0033E2D5
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

		// Token: 0x1700872A RID: 34602
		// (get) Token: 0x06023280 RID: 144000 RVA: 0x00340105 File Offset: 0x0033E305
		// (set) Token: 0x06023281 RID: 144001 RVA: 0x0034011E File Offset: 0x0033E31E
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

		// Token: 0x1700872B RID: 34603
		// (get) Token: 0x06023282 RID: 144002 RVA: 0x0034014E File Offset: 0x0033E34E
		// (set) Token: 0x06023283 RID: 144003 RVA: 0x00340167 File Offset: 0x0033E367
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

		// Token: 0x1700872C RID: 34604
		// (get) Token: 0x06023284 RID: 144004 RVA: 0x00340197 File Offset: 0x0033E397
		// (set) Token: 0x06023285 RID: 144005 RVA: 0x003401A7 File Offset: 0x0033E3A7
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

		// Token: 0x1700872D RID: 34605
		// (get) Token: 0x06023286 RID: 144006 RVA: 0x003401B8 File Offset: 0x0033E3B8
		// (set) Token: 0x06023287 RID: 144007 RVA: 0x003401C8 File Offset: 0x0033E3C8
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

		// Token: 0x1700872E RID: 34606
		// (get) Token: 0x06023288 RID: 144008 RVA: 0x003401D9 File Offset: 0x0033E3D9
		// (set) Token: 0x06023289 RID: 144009 RVA: 0x003401E9 File Offset: 0x0033E3E9
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

		// Token: 0x0602328A RID: 144010 RVA: 0x003401FA File Offset: 0x0033E3FA
		public bool K2_ReplaceAreaInTileBounds(FBox Bounds, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> OldArea, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> NewArea, bool ReplaceLinks = true)
		{
			return ARecastNavMesh.__K2_ReplaceAreaInTileBounds_Internal(base.NativePtr, Bounds, OldArea._NativePtr, NewArea._NativePtr, ReplaceLinks);
		}

		// Token: 0x0602328B RID: 144011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ReplaceAreaInTileBounds_Internal(IntPtr @this, FBox Bounds, IntPtr OldArea, IntPtr NewArea, bool ReplaceLinks);

		// Token: 0x0602328C RID: 144012 RVA: 0x00340216 File Offset: 0x0033E416
		static ARecastNavMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.RecastNavMesh");
		}

		// Token: 0x0602328D RID: 144013 RVA: 0x00340224 File Offset: 0x0033E424
		protected ARecastNavMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C00 RID: 76800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.RecastNavMesh";

		// Token: 0x04012C01 RID: 76801
		private static IntPtr _ClassPtr;

		// Token: 0x04012C02 RID: 76802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C03 RID: 76803
		internal static int __PropertyOffset_WaterBodyIdToActorName;

		// Token: 0x04012C04 RID: 76804
		[Nullable(2)]
		private TMap<int, FName> _WaterBodyIdToActorName;

		// Token: 0x04012C05 RID: 76805
		internal static int __PropertyOffset_WaterBasinThresholds;

		// Token: 0x04012C06 RID: 76806
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FIntPoint, FWaterBasinThresholdRows> _WaterBasinThresholds;

		// Token: 0x04012C07 RID: 76807
		internal static int __PropertyOffset_bDrawTriangleEdges;

		// Token: 0x04012C08 RID: 76808
		internal static byte __PropertyMask_bDrawTriangleEdges;

		// Token: 0x04012C09 RID: 76809
		internal static int __PropertyOffset_bDrawPolyEdges;

		// Token: 0x04012C0A RID: 76810
		internal static byte __PropertyMask_bDrawPolyEdges;

		// Token: 0x04012C0B RID: 76811
		internal static int __PropertyOffset_bDrawFilledPolys;

		// Token: 0x04012C0C RID: 76812
		internal static byte __PropertyMask_bDrawFilledPolys;

		// Token: 0x04012C0D RID: 76813
		internal static int __PropertyOffset_bDrawNavMeshEdges;

		// Token: 0x04012C0E RID: 76814
		internal static byte __PropertyMask_bDrawNavMeshEdges;

		// Token: 0x04012C0F RID: 76815
		internal static int __PropertyOffset_bDrawTileBounds;

		// Token: 0x04012C10 RID: 76816
		internal static byte __PropertyMask_bDrawTileBounds;

		// Token: 0x04012C11 RID: 76817
		internal static int __PropertyOffset_bDrawPathCollidingGeometry;

		// Token: 0x04012C12 RID: 76818
		internal static byte __PropertyMask_bDrawPathCollidingGeometry;

		// Token: 0x04012C13 RID: 76819
		internal static int __PropertyOffset_bDrawTileLabels;

		// Token: 0x04012C14 RID: 76820
		internal static byte __PropertyMask_bDrawTileLabels;

		// Token: 0x04012C15 RID: 76821
		internal static int __PropertyOffset_bDrawPolygonLabels;

		// Token: 0x04012C16 RID: 76822
		internal static byte __PropertyMask_bDrawPolygonLabels;

		// Token: 0x04012C17 RID: 76823
		internal static int __PropertyOffset_bDrawDefaultPolygonCost;

		// Token: 0x04012C18 RID: 76824
		internal static byte __PropertyMask_bDrawDefaultPolygonCost;

		// Token: 0x04012C19 RID: 76825
		internal static int __PropertyOffset_bDrawLabelsOnPathNodes;

		// Token: 0x04012C1A RID: 76826
		internal static byte __PropertyMask_bDrawLabelsOnPathNodes;

		// Token: 0x04012C1B RID: 76827
		internal static int __PropertyOffset_bDrawNavLinks;

		// Token: 0x04012C1C RID: 76828
		internal static byte __PropertyMask_bDrawNavLinks;

		// Token: 0x04012C1D RID: 76829
		internal static int __PropertyOffset_bDrawFailedNavLinks;

		// Token: 0x04012C1E RID: 76830
		internal static byte __PropertyMask_bDrawFailedNavLinks;

		// Token: 0x04012C1F RID: 76831
		internal static int __PropertyOffset_bDrawClusters;

		// Token: 0x04012C20 RID: 76832
		internal static byte __PropertyMask_bDrawClusters;

		// Token: 0x04012C21 RID: 76833
		internal static int __PropertyOffset_bDrawOctree;

		// Token: 0x04012C22 RID: 76834
		internal static byte __PropertyMask_bDrawOctree;

		// Token: 0x04012C23 RID: 76835
		internal static int __PropertyOffset_bDrawOctreeDetails;

		// Token: 0x04012C24 RID: 76836
		internal static byte __PropertyMask_bDrawOctreeDetails;

		// Token: 0x04012C25 RID: 76837
		internal static int __PropertyOffset_bDrawMarkedForbiddenPolys;

		// Token: 0x04012C26 RID: 76838
		internal static byte __PropertyMask_bDrawMarkedForbiddenPolys;

		// Token: 0x04012C27 RID: 76839
		internal static int __PropertyOffset_bDrawRecastDebugData;

		// Token: 0x04012C28 RID: 76840
		internal static byte __PropertyMask_bDrawRecastDebugData;

		// Token: 0x04012C29 RID: 76841
		internal static int __PropertyOffset_bDrawEnclosedBoolean;

		// Token: 0x04012C2A RID: 76842
		internal static byte __PropertyMask_bDrawEnclosedBoolean;

		// Token: 0x04012C2B RID: 76843
		internal static int __PropertyOffset_bDrawWaterFlooded;

		// Token: 0x04012C2C RID: 76844
		internal static byte __PropertyMask_bDrawWaterFlooded;

		// Token: 0x04012C2D RID: 76845
		internal static int __PropertyOffset_bDrawWaterBasins;

		// Token: 0x04012C2E RID: 76846
		internal static byte __PropertyMask_bDrawWaterBasins;

		// Token: 0x04012C2F RID: 76847
		internal static int __PropertyOffset_bDistinctlyDrawTilesBeingBuilt;

		// Token: 0x04012C30 RID: 76848
		internal static byte __PropertyMask_bDistinctlyDrawTilesBeingBuilt;

		// Token: 0x04012C31 RID: 76849
		internal static int __PropertyOffset_DrawOffset;

		// Token: 0x04012C32 RID: 76850
		internal static int __PropertyOffset_bFixedTilePoolSize;

		// Token: 0x04012C33 RID: 76851
		internal static byte __PropertyMask_bFixedTilePoolSize;

		// Token: 0x04012C34 RID: 76852
		internal static int __PropertyOffset_TilePoolSize;

		// Token: 0x04012C35 RID: 76853
		internal static int __PropertyOffset_TileSizeUU;

		// Token: 0x04012C36 RID: 76854
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04012C37 RID: 76855
		internal static int __PropertyOffset_CellHeight;

		// Token: 0x04012C38 RID: 76856
		internal static int __PropertyOffset_AgentRadius;

		// Token: 0x04012C39 RID: 76857
		internal static int __PropertyOffset_AgentHeight;

		// Token: 0x04012C3A RID: 76858
		internal static int __PropertyOffset_AgentMaxSlope;

		// Token: 0x04012C3B RID: 76859
		internal static int __PropertyOffset_AgentMaxStepHeight;

		// Token: 0x04012C3C RID: 76860
		internal static int __PropertyOffset_MinRegionArea;

		// Token: 0x04012C3D RID: 76861
		internal static int __PropertyOffset_MergeRegionSize;

		// Token: 0x04012C3E RID: 76862
		internal static int __PropertyOffset_MaxSimplificationError;

		// Token: 0x04012C3F RID: 76863
		internal static int __PropertyOffset_DetailSampleDist;

		// Token: 0x04012C40 RID: 76864
		internal static int __PropertyOffset_MaxSimultaneousTileGenerationJobsCount;

		// Token: 0x04012C41 RID: 76865
		internal static int __PropertyOffset_TileNumberHardLimit;

		// Token: 0x04012C42 RID: 76866
		internal static int __PropertyOffset_PolyRefTileBits;

		// Token: 0x04012C43 RID: 76867
		internal static int __PropertyOffset_PolyRefNavPolyBits;

		// Token: 0x04012C44 RID: 76868
		internal static int __PropertyOffset_PolyRefSaltBits;

		// Token: 0x04012C45 RID: 76869
		internal static int __PropertyOffset_NavMeshOriginOffset;

		// Token: 0x04012C46 RID: 76870
		internal static int __PropertyOffset_bEnclosedSpaceTest;

		// Token: 0x04012C47 RID: 76871
		internal static byte __PropertyMask_bEnclosedSpaceTest;

		// Token: 0x04012C48 RID: 76872
		internal static int __PropertyOffset_bCullEnclosedSpace;

		// Token: 0x04012C49 RID: 76873
		internal static byte __PropertyMask_bCullEnclosedSpace;

		// Token: 0x04012C4A RID: 76874
		internal static int __PropertyOffset_bIsWorldPartitioned;

		// Token: 0x04012C4B RID: 76875
		internal static byte __PropertyMask_bIsWorldPartitioned;

		// Token: 0x04012C4C RID: 76876
		internal static int __PropertyOffset_bEnableTileVariants;

		// Token: 0x04012C4D RID: 76877
		internal static byte __PropertyMask_bEnableTileVariants;

		// Token: 0x04012C4E RID: 76878
		internal static int __PropertyOffset_DefaultDrawDistance;

		// Token: 0x04012C4F RID: 76879
		internal static int __PropertyOffset_DefaultMaxSearchNodes;

		// Token: 0x04012C50 RID: 76880
		internal static int __PropertyOffset_DefaultMaxHierarchicalSearchNodes;

		// Token: 0x04012C51 RID: 76881
		internal static int __PropertyOffset_RegionPartitioning;

		// Token: 0x04012C52 RID: 76882
		internal static int __PropertyOffset_LayerPartitioning;

		// Token: 0x04012C53 RID: 76883
		internal static int __PropertyOffset_RegionChunkSplits;

		// Token: 0x04012C54 RID: 76884
		internal static int __PropertyOffset_LayerChunkSplits;

		// Token: 0x04012C55 RID: 76885
		internal static int __PropertyOffset_bSortNavigationAreasByCost;

		// Token: 0x04012C56 RID: 76886
		internal static byte __PropertyMask_bSortNavigationAreasByCost;

		// Token: 0x04012C57 RID: 76887
		internal static int __PropertyOffset_bPerformVoxelFiltering;

		// Token: 0x04012C58 RID: 76888
		internal static byte __PropertyMask_bPerformVoxelFiltering;

		// Token: 0x04012C59 RID: 76889
		internal static int __PropertyOffset_bMarkLowHeightAreas;

		// Token: 0x04012C5A RID: 76890
		internal static byte __PropertyMask_bMarkLowHeightAreas;

		// Token: 0x04012C5B RID: 76891
		internal static int __PropertyOffset_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x04012C5C RID: 76892
		internal static byte __PropertyMask_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x04012C5D RID: 76893
		internal static int __PropertyOffset_bFilterLowSpanSequences;

		// Token: 0x04012C5E RID: 76894
		internal static byte __PropertyMask_bFilterLowSpanSequences;

		// Token: 0x04012C5F RID: 76895
		internal static int __PropertyOffset_bFilterLowSpanFromTileCache;

		// Token: 0x04012C60 RID: 76896
		internal static byte __PropertyMask_bFilterLowSpanFromTileCache;

		// Token: 0x04012C61 RID: 76897
		internal static int __PropertyOffset_bDoFullyAsyncNavDataGathering;

		// Token: 0x04012C62 RID: 76898
		internal static byte __PropertyMask_bDoFullyAsyncNavDataGathering;

		// Token: 0x04012C63 RID: 76899
		internal static int __PropertyOffset_bUseBetterOffsetsFromCorners;

		// Token: 0x04012C64 RID: 76900
		internal static byte __PropertyMask_bUseBetterOffsetsFromCorners;

		// Token: 0x04012C65 RID: 76901
		internal static int __PropertyOffset_bStoreEmptyTileLayers;

		// Token: 0x04012C66 RID: 76902
		internal static byte __PropertyMask_bStoreEmptyTileLayers;

		// Token: 0x04012C67 RID: 76903
		internal static int __PropertyOffset_bUseVirtualFilters;

		// Token: 0x04012C68 RID: 76904
		internal static byte __PropertyMask_bUseVirtualFilters;

		// Token: 0x04012C69 RID: 76905
		internal static int __PropertyOffset_bAllowNavLinkAsPathEnd;

		// Token: 0x04012C6A RID: 76906
		internal static byte __PropertyMask_bAllowNavLinkAsPathEnd;

		// Token: 0x04012C6B RID: 76907
		internal static int __PropertyOffset_bUseVoxelCache;

		// Token: 0x04012C6C RID: 76908
		internal static byte __PropertyMask_bUseVoxelCache;

		// Token: 0x04012C6D RID: 76909
		internal static int __PropertyOffset_TileSetUpdateInterval;

		// Token: 0x04012C6E RID: 76910
		internal static int __PropertyOffset_HeuristicScale;

		// Token: 0x04012C6F RID: 76911
		internal static int __PropertyOffset_VerticalDeviationFromGroundCompensation;
	}
}
