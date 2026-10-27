using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024AF RID: 9391
	[UnrealObjectPath("/Script/NavigationSystem.RecastNavMeshGenerationProperties")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FRecastNavMeshGenerationProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023295 RID: 144021 RVA: 0x003402F6 File Offset: 0x0033E4F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRecastNavMeshGenerationProperties._ScriptStructPtr != 0) ? FRecastNavMeshGenerationProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.RecastNavMeshGenerationProperties", ref FRecastNavMeshGenerationProperties._ScriptStructPtr);
		}

		// Token: 0x17008730 RID: 34608
		// (get) Token: 0x06023296 RID: 144022 RVA: 0x0034031A File Offset: 0x0033E51A
		// (set) Token: 0x06023297 RID: 144023 RVA: 0x0034032A File Offset: 0x0033E52A
		public unsafe int TilePoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TilePoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TilePoolSize) = value;
			}
		}

		// Token: 0x17008731 RID: 34609
		// (get) Token: 0x06023298 RID: 144024 RVA: 0x0034033B File Offset: 0x0033E53B
		// (set) Token: 0x06023299 RID: 144025 RVA: 0x0034034B File Offset: 0x0033E54B
		public unsafe float TileSizeUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TileSizeUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TileSizeUU) = value;
			}
		}

		// Token: 0x17008732 RID: 34610
		// (get) Token: 0x0602329A RID: 144026 RVA: 0x0034035C File Offset: 0x0033E55C
		// (set) Token: 0x0602329B RID: 144027 RVA: 0x0034036C File Offset: 0x0033E56C
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17008733 RID: 34611
		// (get) Token: 0x0602329C RID: 144028 RVA: 0x0034037D File Offset: 0x0033E57D
		// (set) Token: 0x0602329D RID: 144029 RVA: 0x0034038D File Offset: 0x0033E58D
		public unsafe float CellHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_CellHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_CellHeight) = value;
			}
		}

		// Token: 0x17008734 RID: 34612
		// (get) Token: 0x0602329E RID: 144030 RVA: 0x0034039E File Offset: 0x0033E59E
		// (set) Token: 0x0602329F RID: 144031 RVA: 0x003403AE File Offset: 0x0033E5AE
		public unsafe float AgentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentRadius) = value;
			}
		}

		// Token: 0x17008735 RID: 34613
		// (get) Token: 0x060232A0 RID: 144032 RVA: 0x003403BF File Offset: 0x0033E5BF
		// (set) Token: 0x060232A1 RID: 144033 RVA: 0x003403CF File Offset: 0x0033E5CF
		public unsafe float AgentHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentHeight) = value;
			}
		}

		// Token: 0x17008736 RID: 34614
		// (get) Token: 0x060232A2 RID: 144034 RVA: 0x003403E0 File Offset: 0x0033E5E0
		// (set) Token: 0x060232A3 RID: 144035 RVA: 0x003403F0 File Offset: 0x0033E5F0
		public unsafe float AgentMaxSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentMaxSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentMaxSlope) = value;
			}
		}

		// Token: 0x17008737 RID: 34615
		// (get) Token: 0x060232A4 RID: 144036 RVA: 0x00340401 File Offset: 0x0033E601
		// (set) Token: 0x060232A5 RID: 144037 RVA: 0x00340411 File Offset: 0x0033E611
		public unsafe float AgentMaxStepHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentMaxStepHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_AgentMaxStepHeight) = value;
			}
		}

		// Token: 0x17008738 RID: 34616
		// (get) Token: 0x060232A6 RID: 144038 RVA: 0x00340422 File Offset: 0x0033E622
		// (set) Token: 0x060232A7 RID: 144039 RVA: 0x00340432 File Offset: 0x0033E632
		public unsafe float MinRegionArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MinRegionArea);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MinRegionArea) = value;
			}
		}

		// Token: 0x17008739 RID: 34617
		// (get) Token: 0x060232A8 RID: 144040 RVA: 0x00340443 File Offset: 0x0033E643
		// (set) Token: 0x060232A9 RID: 144041 RVA: 0x00340453 File Offset: 0x0033E653
		public unsafe float MergeRegionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MergeRegionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MergeRegionSize) = value;
			}
		}

		// Token: 0x1700873A RID: 34618
		// (get) Token: 0x060232AA RID: 144042 RVA: 0x00340464 File Offset: 0x0033E664
		// (set) Token: 0x060232AB RID: 144043 RVA: 0x00340474 File Offset: 0x0033E674
		public unsafe float MaxSimplificationError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MaxSimplificationError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_MaxSimplificationError) = value;
			}
		}

		// Token: 0x1700873B RID: 34619
		// (get) Token: 0x060232AC RID: 144044 RVA: 0x00340485 File Offset: 0x0033E685
		// (set) Token: 0x060232AD RID: 144045 RVA: 0x00340495 File Offset: 0x0033E695
		public unsafe float DetailSampleDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_DetailSampleDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_DetailSampleDist) = value;
			}
		}

		// Token: 0x1700873C RID: 34620
		// (get) Token: 0x060232AE RID: 144046 RVA: 0x003404A6 File Offset: 0x0033E6A6
		// (set) Token: 0x060232AF RID: 144047 RVA: 0x003404B6 File Offset: 0x0033E6B6
		public unsafe int TileNumberHardLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TileNumberHardLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_TileNumberHardLimit) = value;
			}
		}

		// Token: 0x1700873D RID: 34621
		// (get) Token: 0x060232B0 RID: 144048 RVA: 0x003404C7 File Offset: 0x0033E6C7
		// (set) Token: 0x060232B1 RID: 144049 RVA: 0x003404DB File Offset: 0x0033E6DB
		public unsafe TEnumAsByte<ERecastPartitioning> RegionPartitioning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_RegionPartitioning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_RegionPartitioning) = value;
			}
		}

		// Token: 0x1700873E RID: 34622
		// (get) Token: 0x060232B2 RID: 144050 RVA: 0x003404F0 File Offset: 0x0033E6F0
		// (set) Token: 0x060232B3 RID: 144051 RVA: 0x00340504 File Offset: 0x0033E704
		public unsafe TEnumAsByte<ERecastPartitioning> LayerPartitioning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_LayerPartitioning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_LayerPartitioning) = value;
			}
		}

		// Token: 0x1700873F RID: 34623
		// (get) Token: 0x060232B4 RID: 144052 RVA: 0x00340519 File Offset: 0x0033E719
		// (set) Token: 0x060232B5 RID: 144053 RVA: 0x00340529 File Offset: 0x0033E729
		public unsafe int RegionChunkSplits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_RegionChunkSplits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_RegionChunkSplits) = value;
			}
		}

		// Token: 0x17008740 RID: 34624
		// (get) Token: 0x060232B6 RID: 144054 RVA: 0x0034053A File Offset: 0x0033E73A
		// (set) Token: 0x060232B7 RID: 144055 RVA: 0x0034054A File Offset: 0x0033E74A
		public unsafe int LayerChunkSplits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_LayerChunkSplits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_LayerChunkSplits) = value;
			}
		}

		// Token: 0x17008741 RID: 34625
		// (get) Token: 0x060232B8 RID: 144056 RVA: 0x0034055B File Offset: 0x0033E75B
		// (set) Token: 0x060232B9 RID: 144057 RVA: 0x00340574 File Offset: 0x0033E774
		public unsafe bool bSortNavigationAreasByCost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bSortNavigationAreasByCost) & FRecastNavMeshGenerationProperties.__PropertyMask_bSortNavigationAreasByCost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bSortNavigationAreasByCost) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bSortNavigationAreasByCost) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bSortNavigationAreasByCost) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bSortNavigationAreasByCost : 0));
			}
		}

		// Token: 0x17008742 RID: 34626
		// (get) Token: 0x060232BA RID: 144058 RVA: 0x003405A4 File Offset: 0x0033E7A4
		// (set) Token: 0x060232BB RID: 144059 RVA: 0x003405BD File Offset: 0x0033E7BD
		public unsafe bool bIsWorldPartitioned
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bIsWorldPartitioned) & FRecastNavMeshGenerationProperties.__PropertyMask_bIsWorldPartitioned) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bIsWorldPartitioned) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bIsWorldPartitioned) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bIsWorldPartitioned) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bIsWorldPartitioned : 0));
			}
		}

		// Token: 0x17008743 RID: 34627
		// (get) Token: 0x060232BC RID: 144060 RVA: 0x003405ED File Offset: 0x0033E7ED
		// (set) Token: 0x060232BD RID: 144061 RVA: 0x00340606 File Offset: 0x0033E806
		public unsafe bool bEnableTileVariants
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bEnableTileVariants) & FRecastNavMeshGenerationProperties.__PropertyMask_bEnableTileVariants) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bEnableTileVariants) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bEnableTileVariants) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bEnableTileVariants) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bEnableTileVariants : 0));
			}
		}

		// Token: 0x17008744 RID: 34628
		// (get) Token: 0x060232BE RID: 144062 RVA: 0x00340636 File Offset: 0x0033E836
		// (set) Token: 0x060232BF RID: 144063 RVA: 0x0034064F File Offset: 0x0033E84F
		public unsafe bool bPerformVoxelFiltering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bPerformVoxelFiltering) & FRecastNavMeshGenerationProperties.__PropertyMask_bPerformVoxelFiltering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bPerformVoxelFiltering) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bPerformVoxelFiltering) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bPerformVoxelFiltering) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bPerformVoxelFiltering : 0));
			}
		}

		// Token: 0x17008745 RID: 34629
		// (get) Token: 0x060232C0 RID: 144064 RVA: 0x0034067F File Offset: 0x0033E87F
		// (set) Token: 0x060232C1 RID: 144065 RVA: 0x00340698 File Offset: 0x0033E898
		public unsafe bool bMarkLowHeightAreas
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bMarkLowHeightAreas) & FRecastNavMeshGenerationProperties.__PropertyMask_bMarkLowHeightAreas) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bMarkLowHeightAreas) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bMarkLowHeightAreas) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bMarkLowHeightAreas) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bMarkLowHeightAreas : 0));
			}
		}

		// Token: 0x17008746 RID: 34630
		// (get) Token: 0x060232C2 RID: 144066 RVA: 0x003406C8 File Offset: 0x0033E8C8
		// (set) Token: 0x060232C3 RID: 144067 RVA: 0x003406E1 File Offset: 0x0033E8E1
		public unsafe bool bUseExtraTopCellWhenMarkingAreas
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) & FRecastNavMeshGenerationProperties.__PropertyMask_bUseExtraTopCellWhenMarkingAreas) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bUseExtraTopCellWhenMarkingAreas) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bUseExtraTopCellWhenMarkingAreas) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bUseExtraTopCellWhenMarkingAreas : 0));
			}
		}

		// Token: 0x17008747 RID: 34631
		// (get) Token: 0x060232C4 RID: 144068 RVA: 0x00340711 File Offset: 0x0033E911
		// (set) Token: 0x060232C5 RID: 144069 RVA: 0x0034072A File Offset: 0x0033E92A
		public unsafe bool bFilterLowSpanSequences
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanSequences) & FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanSequences) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanSequences) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanSequences) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanSequences) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanSequences : 0));
			}
		}

		// Token: 0x17008748 RID: 34632
		// (get) Token: 0x060232C6 RID: 144070 RVA: 0x0034075A File Offset: 0x0033E95A
		// (set) Token: 0x060232C7 RID: 144071 RVA: 0x00340773 File Offset: 0x0033E973
		public unsafe bool bFilterLowSpanFromTileCache
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanFromTileCache) & FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanFromTileCache) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanFromTileCache) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFilterLowSpanFromTileCache) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanFromTileCache) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bFilterLowSpanFromTileCache : 0));
			}
		}

		// Token: 0x17008749 RID: 34633
		// (get) Token: 0x060232C8 RID: 144072 RVA: 0x003407A3 File Offset: 0x0033E9A3
		// (set) Token: 0x060232C9 RID: 144073 RVA: 0x003407BC File Offset: 0x0033E9BC
		public unsafe bool bFixedTilePoolSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFixedTilePoolSize) & FRecastNavMeshGenerationProperties.__PropertyMask_bFixedTilePoolSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFixedTilePoolSize) = ((*(base.NativePtr + (IntPtr)FRecastNavMeshGenerationProperties.__PropertyOffset_bFixedTilePoolSize) & ~FRecastNavMeshGenerationProperties.__PropertyMask_bFixedTilePoolSize) | (value ? FRecastNavMeshGenerationProperties.__PropertyMask_bFixedTilePoolSize : 0));
			}
		}

		// Token: 0x060232CA RID: 144074 RVA: 0x003407EC File Offset: 0x0033E9EC
		public FRecastNavMeshGenerationProperties()
		{
		}

		// Token: 0x060232CB RID: 144075 RVA: 0x003407F4 File Offset: 0x0033E9F4
		public FRecastNavMeshGenerationProperties(int TilePoolSize, float TileSizeUU, float CellSize, float CellHeight, float AgentRadius, float AgentHeight, float AgentMaxSlope, float AgentMaxStepHeight, float MinRegionArea, float MergeRegionSize, float MaxSimplificationError, float DetailSampleDist, int TileNumberHardLimit, TEnumAsByte<ERecastPartitioning> RegionPartitioning, TEnumAsByte<ERecastPartitioning> LayerPartitioning, int RegionChunkSplits, int LayerChunkSplits, bool bSortNavigationAreasByCost, bool bIsWorldPartitioned, bool bEnableTileVariants, bool bPerformVoxelFiltering, bool bMarkLowHeightAreas, bool bUseExtraTopCellWhenMarkingAreas, bool bFilterLowSpanSequences, bool bFilterLowSpanFromTileCache, bool bFixedTilePoolSize)
		{
			this.TilePoolSize = TilePoolSize;
			this.TileSizeUU = TileSizeUU;
			this.CellSize = CellSize;
			this.CellHeight = CellHeight;
			this.AgentRadius = AgentRadius;
			this.AgentHeight = AgentHeight;
			this.AgentMaxSlope = AgentMaxSlope;
			this.AgentMaxStepHeight = AgentMaxStepHeight;
			this.MinRegionArea = MinRegionArea;
			this.MergeRegionSize = MergeRegionSize;
			this.MaxSimplificationError = MaxSimplificationError;
			this.DetailSampleDist = DetailSampleDist;
			this.TileNumberHardLimit = TileNumberHardLimit;
			this.RegionPartitioning = RegionPartitioning;
			this.LayerPartitioning = LayerPartitioning;
			this.RegionChunkSplits = RegionChunkSplits;
			this.LayerChunkSplits = LayerChunkSplits;
			this.bSortNavigationAreasByCost = bSortNavigationAreasByCost;
			this.bIsWorldPartitioned = bIsWorldPartitioned;
			this.bEnableTileVariants = bEnableTileVariants;
			this.bPerformVoxelFiltering = bPerformVoxelFiltering;
			this.bMarkLowHeightAreas = bMarkLowHeightAreas;
			this.bUseExtraTopCellWhenMarkingAreas = bUseExtraTopCellWhenMarkingAreas;
			this.bFilterLowSpanSequences = bFilterLowSpanSequences;
			this.bFilterLowSpanFromTileCache = bFilterLowSpanFromTileCache;
			this.bFixedTilePoolSize = bFixedTilePoolSize;
		}

		// Token: 0x060232CC RID: 144076 RVA: 0x003408D4 File Offset: 0x0033EAD4
		protected override IntPtr GetUStructPtr()
		{
			return FRecastNavMeshGenerationProperties.StaticStruct();
		}

		// Token: 0x060232CD RID: 144077 RVA: 0x003408E0 File Offset: 0x0033EAE0
		[NullableContext(2)]
		public FRecastNavMeshGenerationProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060232CE RID: 144078 RVA: 0x003408EA File Offset: 0x0033EAEA
		public FRecastNavMeshGenerationProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060232CF RID: 144079 RVA: 0x003408F5 File Offset: 0x0033EAF5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRecastNavMeshGenerationProperties(Pointer, false, true);
		}

		// Token: 0x060232D0 RID: 144080 RVA: 0x003408FF File Offset: 0x0033EAFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRecastNavMeshGenerationProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04012C75 RID: 76917
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.RecastNavMeshGenerationProperties";

		// Token: 0x04012C76 RID: 76918
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012C77 RID: 76919
		internal static int __PropertyOffset_TilePoolSize;

		// Token: 0x04012C78 RID: 76920
		internal static int __PropertyOffset_TileSizeUU;

		// Token: 0x04012C79 RID: 76921
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04012C7A RID: 76922
		internal static int __PropertyOffset_CellHeight;

		// Token: 0x04012C7B RID: 76923
		internal static int __PropertyOffset_AgentRadius;

		// Token: 0x04012C7C RID: 76924
		internal static int __PropertyOffset_AgentHeight;

		// Token: 0x04012C7D RID: 76925
		internal static int __PropertyOffset_AgentMaxSlope;

		// Token: 0x04012C7E RID: 76926
		internal static int __PropertyOffset_AgentMaxStepHeight;

		// Token: 0x04012C7F RID: 76927
		internal static int __PropertyOffset_MinRegionArea;

		// Token: 0x04012C80 RID: 76928
		internal static int __PropertyOffset_MergeRegionSize;

		// Token: 0x04012C81 RID: 76929
		internal static int __PropertyOffset_MaxSimplificationError;

		// Token: 0x04012C82 RID: 76930
		internal static int __PropertyOffset_DetailSampleDist;

		// Token: 0x04012C83 RID: 76931
		internal static int __PropertyOffset_TileNumberHardLimit;

		// Token: 0x04012C84 RID: 76932
		internal static int __PropertyOffset_RegionPartitioning;

		// Token: 0x04012C85 RID: 76933
		internal static int __PropertyOffset_LayerPartitioning;

		// Token: 0x04012C86 RID: 76934
		internal static int __PropertyOffset_RegionChunkSplits;

		// Token: 0x04012C87 RID: 76935
		internal static int __PropertyOffset_LayerChunkSplits;

		// Token: 0x04012C88 RID: 76936
		internal static int __PropertyOffset_bSortNavigationAreasByCost;

		// Token: 0x04012C89 RID: 76937
		internal static byte __PropertyMask_bSortNavigationAreasByCost;

		// Token: 0x04012C8A RID: 76938
		internal static int __PropertyOffset_bIsWorldPartitioned;

		// Token: 0x04012C8B RID: 76939
		internal static byte __PropertyMask_bIsWorldPartitioned;

		// Token: 0x04012C8C RID: 76940
		internal static int __PropertyOffset_bEnableTileVariants;

		// Token: 0x04012C8D RID: 76941
		internal static byte __PropertyMask_bEnableTileVariants;

		// Token: 0x04012C8E RID: 76942
		internal static int __PropertyOffset_bPerformVoxelFiltering;

		// Token: 0x04012C8F RID: 76943
		internal static byte __PropertyMask_bPerformVoxelFiltering;

		// Token: 0x04012C90 RID: 76944
		internal static int __PropertyOffset_bMarkLowHeightAreas;

		// Token: 0x04012C91 RID: 76945
		internal static byte __PropertyMask_bMarkLowHeightAreas;

		// Token: 0x04012C92 RID: 76946
		internal static int __PropertyOffset_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x04012C93 RID: 76947
		internal static byte __PropertyMask_bUseExtraTopCellWhenMarkingAreas;

		// Token: 0x04012C94 RID: 76948
		internal static int __PropertyOffset_bFilterLowSpanSequences;

		// Token: 0x04012C95 RID: 76949
		internal static byte __PropertyMask_bFilterLowSpanSequences;

		// Token: 0x04012C96 RID: 76950
		internal static int __PropertyOffset_bFilterLowSpanFromTileCache;

		// Token: 0x04012C97 RID: 76951
		internal static byte __PropertyMask_bFilterLowSpanFromTileCache;

		// Token: 0x04012C98 RID: 76952
		internal static int __PropertyOffset_bFixedTilePoolSize;

		// Token: 0x04012C99 RID: 76953
		internal static byte __PropertyMask_bFixedTilePoolSize;
	}
}
