using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002498 RID: 9368
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationTestingActor")]
	[UnrealStructLayout(1328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1328)]
	public class ANavigationTestingActor : AActor, IUnrealUObject, IUnrealObject, INavAgentInterface, IUnrealNativeInterface, IUnrealInterface, INavPathObserverInterface
	{
		// Token: 0x06023100 RID: 143616 RVA: 0x0033D93A File Offset: 0x0033BB3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationTestingActor._ClassPtr;
		}

		// Token: 0x06023101 RID: 143617 RVA: 0x0033D946 File Offset: 0x0033BB46
		int INavAgentInterface.InterfaceOffset()
		{
			return ANavigationTestingActor.__InterfaceOffset_INavAgentInterface;
		}

		// Token: 0x06023102 RID: 143618 RVA: 0x0033D94D File Offset: 0x0033BB4D
		int INavPathObserverInterface.InterfaceOffset()
		{
			return ANavigationTestingActor.__InterfaceOffset_INavPathObserverInterface;
		}

		// Token: 0x06023103 RID: 143619 RVA: 0x0033D954 File Offset: 0x0033BB54
		public ANavigationTestingActor() : this(BuiltinUtils.AllocNativeUObject(ANavigationTestingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023104 RID: 143620 RVA: 0x0033D97C File Offset: 0x0033BB7C
		[NullableContext(1)]
		public ANavigationTestingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavigationTestingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086AA RID: 34474
		// (get) Token: 0x06023105 RID: 143621 RVA: 0x0033D9AF File Offset: 0x0033BBAF
		// (set) Token: 0x06023106 RID: 143622 RVA: 0x0033D9C3 File Offset: 0x0033BBC3
		public unsafe UCapsuleComponent CapsuleComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_CapsuleComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_CapsuleComponent, value);
			}
		}

		// Token: 0x170086AB RID: 34475
		// (get) Token: 0x06023107 RID: 143623 RVA: 0x0033D9D8 File Offset: 0x0033BBD8
		// (set) Token: 0x06023108 RID: 143624 RVA: 0x0033D9EC File Offset: 0x0033BBEC
		public unsafe UNavigationInvokerComponent InvokerComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationInvokerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_InvokerComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_InvokerComponent, value);
			}
		}

		// Token: 0x170086AC RID: 34476
		// (get) Token: 0x06023109 RID: 143625 RVA: 0x0033DA01 File Offset: 0x0033BC01
		// (set) Token: 0x0602310A RID: 143626 RVA: 0x0033DA1A File Offset: 0x0033BC1A
		public unsafe bool bActAsNavigationInvoker
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bActAsNavigationInvoker) & ANavigationTestingActor.__PropertyMask_bActAsNavigationInvoker) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bActAsNavigationInvoker) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bActAsNavigationInvoker) & ~ANavigationTestingActor.__PropertyMask_bActAsNavigationInvoker) | (value ? ANavigationTestingActor.__PropertyMask_bActAsNavigationInvoker : 0));
			}
		}

		// Token: 0x170086AD RID: 34477
		// (get) Token: 0x0602310B RID: 143627 RVA: 0x0033DA4C File Offset: 0x0033BC4C
		// (set) Token: 0x0602310C RID: 143628 RVA: 0x0033DA85 File Offset: 0x0033BC85
		[Nullable(1)]
		public FNavAgentProperties NavAgentProps
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAgentProperties result;
				if ((result = this._NavAgentProps) == null)
				{
					result = (this._NavAgentProps = new FNavAgentProperties(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_NavAgentProps, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentProperties.StaticStruct(), base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_NavAgentProps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170086AE RID: 34478
		// (get) Token: 0x0602310D RID: 143629 RVA: 0x0033DAA6 File Offset: 0x0033BCA6
		// (set) Token: 0x0602310E RID: 143630 RVA: 0x0033DABA File Offset: 0x0033BCBA
		public unsafe FVector QueryingExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_QueryingExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_QueryingExtent) = value;
			}
		}

		// Token: 0x170086AF RID: 34479
		// (get) Token: 0x0602310F RID: 143631 RVA: 0x0033DACF File Offset: 0x0033BCCF
		// (set) Token: 0x06023110 RID: 143632 RVA: 0x0033DAE3 File Offset: 0x0033BCE3
		public unsafe ANavigationData MyNavData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationData>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_MyNavData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_MyNavData, value);
			}
		}

		// Token: 0x170086B0 RID: 34480
		// (get) Token: 0x06023111 RID: 143633 RVA: 0x0033DAF8 File Offset: 0x0033BCF8
		// (set) Token: 0x06023112 RID: 143634 RVA: 0x0033DB0C File Offset: 0x0033BD0C
		public unsafe FVector ProjectedLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_ProjectedLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_ProjectedLocation) = value;
			}
		}

		// Token: 0x170086B1 RID: 34481
		// (get) Token: 0x06023113 RID: 143635 RVA: 0x0033DB21 File Offset: 0x0033BD21
		// (set) Token: 0x06023114 RID: 143636 RVA: 0x0033DB3A File Offset: 0x0033BD3A
		public unsafe bool bProjectedLocationValid
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bProjectedLocationValid) & ANavigationTestingActor.__PropertyMask_bProjectedLocationValid) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bProjectedLocationValid) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bProjectedLocationValid) & ~ANavigationTestingActor.__PropertyMask_bProjectedLocationValid) | (value ? ANavigationTestingActor.__PropertyMask_bProjectedLocationValid : 0));
			}
		}

		// Token: 0x170086B2 RID: 34482
		// (get) Token: 0x06023115 RID: 143637 RVA: 0x0033DB6A File Offset: 0x0033BD6A
		// (set) Token: 0x06023116 RID: 143638 RVA: 0x0033DB83 File Offset: 0x0033BD83
		public unsafe bool bSearchStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bSearchStart) & ANavigationTestingActor.__PropertyMask_bSearchStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bSearchStart) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bSearchStart) & ~ANavigationTestingActor.__PropertyMask_bSearchStart) | (value ? ANavigationTestingActor.__PropertyMask_bSearchStart : 0));
			}
		}

		// Token: 0x170086B3 RID: 34483
		// (get) Token: 0x06023117 RID: 143639 RVA: 0x0033DBB3 File Offset: 0x0033BDB3
		// (set) Token: 0x06023118 RID: 143640 RVA: 0x0033DBC3 File Offset: 0x0033BDC3
		public unsafe float CostLimitFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_CostLimitFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_CostLimitFactor) = value;
			}
		}

		// Token: 0x170086B4 RID: 34484
		// (get) Token: 0x06023119 RID: 143641 RVA: 0x0033DBD4 File Offset: 0x0033BDD4
		// (set) Token: 0x0602311A RID: 143642 RVA: 0x0033DBE4 File Offset: 0x0033BDE4
		public unsafe float MinimumCostLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_MinimumCostLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_MinimumCostLimit) = value;
			}
		}

		// Token: 0x170086B5 RID: 34485
		// (get) Token: 0x0602311B RID: 143643 RVA: 0x0033DBF5 File Offset: 0x0033BDF5
		// (set) Token: 0x0602311C RID: 143644 RVA: 0x0033DC0E File Offset: 0x0033BE0E
		public unsafe bool bBacktracking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bBacktracking) & ANavigationTestingActor.__PropertyMask_bBacktracking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bBacktracking) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bBacktracking) & ~ANavigationTestingActor.__PropertyMask_bBacktracking) | (value ? ANavigationTestingActor.__PropertyMask_bBacktracking : 0));
			}
		}

		// Token: 0x170086B6 RID: 34486
		// (get) Token: 0x0602311D RID: 143645 RVA: 0x0033DC3E File Offset: 0x0033BE3E
		// (set) Token: 0x0602311E RID: 143646 RVA: 0x0033DC57 File Offset: 0x0033BE57
		public unsafe bool bUseHierarchicalPathfinding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bUseHierarchicalPathfinding) & ANavigationTestingActor.__PropertyMask_bUseHierarchicalPathfinding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bUseHierarchicalPathfinding) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bUseHierarchicalPathfinding) & ~ANavigationTestingActor.__PropertyMask_bUseHierarchicalPathfinding) | (value ? ANavigationTestingActor.__PropertyMask_bUseHierarchicalPathfinding : 0));
			}
		}

		// Token: 0x170086B7 RID: 34487
		// (get) Token: 0x0602311F RID: 143647 RVA: 0x0033DC87 File Offset: 0x0033BE87
		// (set) Token: 0x06023120 RID: 143648 RVA: 0x0033DCA0 File Offset: 0x0033BEA0
		public unsafe bool bGatherDetailedInfo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bGatherDetailedInfo) & ANavigationTestingActor.__PropertyMask_bGatherDetailedInfo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bGatherDetailedInfo) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bGatherDetailedInfo) & ~ANavigationTestingActor.__PropertyMask_bGatherDetailedInfo) | (value ? ANavigationTestingActor.__PropertyMask_bGatherDetailedInfo : 0));
			}
		}

		// Token: 0x170086B8 RID: 34488
		// (get) Token: 0x06023121 RID: 143649 RVA: 0x0033DCD0 File Offset: 0x0033BED0
		// (set) Token: 0x06023122 RID: 143650 RVA: 0x0033DCE9 File Offset: 0x0033BEE9
		public unsafe bool bDrawDistanceToWall
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bDrawDistanceToWall) & ANavigationTestingActor.__PropertyMask_bDrawDistanceToWall) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bDrawDistanceToWall) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bDrawDistanceToWall) & ~ANavigationTestingActor.__PropertyMask_bDrawDistanceToWall) | (value ? ANavigationTestingActor.__PropertyMask_bDrawDistanceToWall : 0));
			}
		}

		// Token: 0x170086B9 RID: 34489
		// (get) Token: 0x06023123 RID: 143651 RVA: 0x0033DD19 File Offset: 0x0033BF19
		// (set) Token: 0x06023124 RID: 143652 RVA: 0x0033DD32 File Offset: 0x0033BF32
		public unsafe bool bShowNodePool
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowNodePool) & ANavigationTestingActor.__PropertyMask_bShowNodePool) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowNodePool) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowNodePool) & ~ANavigationTestingActor.__PropertyMask_bShowNodePool) | (value ? ANavigationTestingActor.__PropertyMask_bShowNodePool : 0));
			}
		}

		// Token: 0x170086BA RID: 34490
		// (get) Token: 0x06023125 RID: 143653 RVA: 0x0033DD62 File Offset: 0x0033BF62
		// (set) Token: 0x06023126 RID: 143654 RVA: 0x0033DD7B File Offset: 0x0033BF7B
		public unsafe bool bShowBestPath
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowBestPath) & ANavigationTestingActor.__PropertyMask_bShowBestPath) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowBestPath) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowBestPath) & ~ANavigationTestingActor.__PropertyMask_bShowBestPath) | (value ? ANavigationTestingActor.__PropertyMask_bShowBestPath : 0));
			}
		}

		// Token: 0x170086BB RID: 34491
		// (get) Token: 0x06023127 RID: 143655 RVA: 0x0033DDAB File Offset: 0x0033BFAB
		// (set) Token: 0x06023128 RID: 143656 RVA: 0x0033DDC4 File Offset: 0x0033BFC4
		public unsafe bool bShowDiffWithPreviousStep
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowDiffWithPreviousStep) & ANavigationTestingActor.__PropertyMask_bShowDiffWithPreviousStep) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowDiffWithPreviousStep) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShowDiffWithPreviousStep) & ~ANavigationTestingActor.__PropertyMask_bShowDiffWithPreviousStep) | (value ? ANavigationTestingActor.__PropertyMask_bShowDiffWithPreviousStep : 0));
			}
		}

		// Token: 0x170086BC RID: 34492
		// (get) Token: 0x06023129 RID: 143657 RVA: 0x0033DDF4 File Offset: 0x0033BFF4
		// (set) Token: 0x0602312A RID: 143658 RVA: 0x0033DE0D File Offset: 0x0033C00D
		public unsafe bool bShouldBeVisibleInGame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShouldBeVisibleInGame) & ANavigationTestingActor.__PropertyMask_bShouldBeVisibleInGame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShouldBeVisibleInGame) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bShouldBeVisibleInGame) & ~ANavigationTestingActor.__PropertyMask_bShouldBeVisibleInGame) | (value ? ANavigationTestingActor.__PropertyMask_bShouldBeVisibleInGame : 0));
			}
		}

		// Token: 0x170086BD RID: 34493
		// (get) Token: 0x0602312B RID: 143659 RVA: 0x0033DE3D File Offset: 0x0033C03D
		// (set) Token: 0x0602312C RID: 143660 RVA: 0x0033DE51 File Offset: 0x0033C051
		[Nullable(0)]
		public unsafe TEnumAsByte<ENavCostDisplay> CostDisplayMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_CostDisplayMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_CostDisplayMode) = value;
			}
		}

		// Token: 0x170086BE RID: 34494
		// (get) Token: 0x0602312D RID: 143661 RVA: 0x0033DE66 File Offset: 0x0033C066
		// (set) Token: 0x0602312E RID: 143662 RVA: 0x0033DE7A File Offset: 0x0033C07A
		public unsafe FVector2D TextCanvasOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_TextCanvasOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_TextCanvasOffset) = value;
			}
		}

		// Token: 0x170086BF RID: 34495
		// (get) Token: 0x0602312F RID: 143663 RVA: 0x0033DE8F File Offset: 0x0033C08F
		// (set) Token: 0x06023130 RID: 143664 RVA: 0x0033DEA8 File Offset: 0x0033C0A8
		public unsafe bool bPathExist
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathExist) & ANavigationTestingActor.__PropertyMask_bPathExist) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathExist) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathExist) & ~ANavigationTestingActor.__PropertyMask_bPathExist) | (value ? ANavigationTestingActor.__PropertyMask_bPathExist : 0));
			}
		}

		// Token: 0x170086C0 RID: 34496
		// (get) Token: 0x06023131 RID: 143665 RVA: 0x0033DED8 File Offset: 0x0033C0D8
		// (set) Token: 0x06023132 RID: 143666 RVA: 0x0033DEF1 File Offset: 0x0033C0F1
		public unsafe bool bPathIsPartial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathIsPartial) & ANavigationTestingActor.__PropertyMask_bPathIsPartial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathIsPartial) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathIsPartial) & ~ANavigationTestingActor.__PropertyMask_bPathIsPartial) | (value ? ANavigationTestingActor.__PropertyMask_bPathIsPartial : 0));
			}
		}

		// Token: 0x170086C1 RID: 34497
		// (get) Token: 0x06023133 RID: 143667 RVA: 0x0033DF21 File Offset: 0x0033C121
		// (set) Token: 0x06023134 RID: 143668 RVA: 0x0033DF3A File Offset: 0x0033C13A
		public unsafe bool bPathSearchOutOfNodes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathSearchOutOfNodes) & ANavigationTestingActor.__PropertyMask_bPathSearchOutOfNodes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathSearchOutOfNodes) = ((*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_bPathSearchOutOfNodes) & ~ANavigationTestingActor.__PropertyMask_bPathSearchOutOfNodes) | (value ? ANavigationTestingActor.__PropertyMask_bPathSearchOutOfNodes : 0));
			}
		}

		// Token: 0x170086C2 RID: 34498
		// (get) Token: 0x06023135 RID: 143669 RVA: 0x0033DF6A File Offset: 0x0033C16A
		// (set) Token: 0x06023136 RID: 143670 RVA: 0x0033DF7A File Offset: 0x0033C17A
		public unsafe float PathfindingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathfindingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathfindingTime) = value;
			}
		}

		// Token: 0x170086C3 RID: 34499
		// (get) Token: 0x06023137 RID: 143671 RVA: 0x0033DF8B File Offset: 0x0033C18B
		// (set) Token: 0x06023138 RID: 143672 RVA: 0x0033DF9B File Offset: 0x0033C19B
		public unsafe float PathCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathCost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathCost) = value;
			}
		}

		// Token: 0x170086C4 RID: 34500
		// (get) Token: 0x06023139 RID: 143673 RVA: 0x0033DFAC File Offset: 0x0033C1AC
		// (set) Token: 0x0602313A RID: 143674 RVA: 0x0033DFBC File Offset: 0x0033C1BC
		public unsafe int PathfindingSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathfindingSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_PathfindingSteps) = value;
			}
		}

		// Token: 0x170086C5 RID: 34501
		// (get) Token: 0x0602313B RID: 143675 RVA: 0x0033DFCD File Offset: 0x0033C1CD
		// (set) Token: 0x0602313C RID: 143676 RVA: 0x0033DFE1 File Offset: 0x0033C1E1
		public unsafe ANavigationTestingActor OtherActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationTestingActor>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_OtherActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationTestingActor.__PropertyOffset_OtherActor, value);
			}
		}

		// Token: 0x170086C6 RID: 34502
		// (get) Token: 0x0602313D RID: 143677 RVA: 0x0033DFF6 File Offset: 0x0033C1F6
		// (set) Token: 0x0602313E RID: 143678 RVA: 0x0033E00A File Offset: 0x0033C20A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> FilterClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_FilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_FilterClass) = value;
			}
		}

		// Token: 0x170086C7 RID: 34503
		// (get) Token: 0x0602313F RID: 143679 RVA: 0x0033E01F File Offset: 0x0033C21F
		// (set) Token: 0x06023140 RID: 143680 RVA: 0x0033E02F File Offset: 0x0033C22F
		public unsafe int ShowStepIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_ShowStepIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_ShowStepIndex) = value;
			}
		}

		// Token: 0x170086C8 RID: 34504
		// (get) Token: 0x06023141 RID: 143681 RVA: 0x0033E040 File Offset: 0x0033C240
		// (set) Token: 0x06023142 RID: 143682 RVA: 0x0033E050 File Offset: 0x0033C250
		public unsafe float OffsetFromCornersDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_OffsetFromCornersDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationTestingActor.__PropertyOffset_OffsetFromCornersDistance) = value;
			}
		}

		// Token: 0x06023143 RID: 143683 RVA: 0x0033E061 File Offset: 0x0033C261
		static ANavigationTestingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationTestingActor");
		}

		// Token: 0x06023144 RID: 143684 RVA: 0x0033E06F File Offset: 0x0033C26F
		protected ANavigationTestingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B69 RID: 76649
		internal static int __InterfaceOffset_INavAgentInterface;

		// Token: 0x04012B6A RID: 76650
		internal static int __InterfaceOffset_INavPathObserverInterface;

		// Token: 0x04012B6B RID: 76651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationTestingActor";

		// Token: 0x04012B6C RID: 76652
		private static IntPtr _ClassPtr;

		// Token: 0x04012B6D RID: 76653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B6E RID: 76654
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x04012B6F RID: 76655
		internal static int __PropertyOffset_InvokerComponent;

		// Token: 0x04012B70 RID: 76656
		internal static int __PropertyOffset_bActAsNavigationInvoker;

		// Token: 0x04012B71 RID: 76657
		internal static byte __PropertyMask_bActAsNavigationInvoker;

		// Token: 0x04012B72 RID: 76658
		internal static int __PropertyOffset_NavAgentProps;

		// Token: 0x04012B73 RID: 76659
		private FNavAgentProperties _NavAgentProps;

		// Token: 0x04012B74 RID: 76660
		internal static int __PropertyOffset_QueryingExtent;

		// Token: 0x04012B75 RID: 76661
		internal static int __PropertyOffset_MyNavData;

		// Token: 0x04012B76 RID: 76662
		internal static int __PropertyOffset_ProjectedLocation;

		// Token: 0x04012B77 RID: 76663
		internal static int __PropertyOffset_bProjectedLocationValid;

		// Token: 0x04012B78 RID: 76664
		internal static byte __PropertyMask_bProjectedLocationValid;

		// Token: 0x04012B79 RID: 76665
		internal static int __PropertyOffset_bSearchStart;

		// Token: 0x04012B7A RID: 76666
		internal static byte __PropertyMask_bSearchStart;

		// Token: 0x04012B7B RID: 76667
		internal static int __PropertyOffset_CostLimitFactor;

		// Token: 0x04012B7C RID: 76668
		internal static int __PropertyOffset_MinimumCostLimit;

		// Token: 0x04012B7D RID: 76669
		internal static int __PropertyOffset_bBacktracking;

		// Token: 0x04012B7E RID: 76670
		internal static byte __PropertyMask_bBacktracking;

		// Token: 0x04012B7F RID: 76671
		internal static int __PropertyOffset_bUseHierarchicalPathfinding;

		// Token: 0x04012B80 RID: 76672
		internal static byte __PropertyMask_bUseHierarchicalPathfinding;

		// Token: 0x04012B81 RID: 76673
		internal static int __PropertyOffset_bGatherDetailedInfo;

		// Token: 0x04012B82 RID: 76674
		internal static byte __PropertyMask_bGatherDetailedInfo;

		// Token: 0x04012B83 RID: 76675
		internal static int __PropertyOffset_bDrawDistanceToWall;

		// Token: 0x04012B84 RID: 76676
		internal static byte __PropertyMask_bDrawDistanceToWall;

		// Token: 0x04012B85 RID: 76677
		internal static int __PropertyOffset_bShowNodePool;

		// Token: 0x04012B86 RID: 76678
		internal static byte __PropertyMask_bShowNodePool;

		// Token: 0x04012B87 RID: 76679
		internal static int __PropertyOffset_bShowBestPath;

		// Token: 0x04012B88 RID: 76680
		internal static byte __PropertyMask_bShowBestPath;

		// Token: 0x04012B89 RID: 76681
		internal static int __PropertyOffset_bShowDiffWithPreviousStep;

		// Token: 0x04012B8A RID: 76682
		internal static byte __PropertyMask_bShowDiffWithPreviousStep;

		// Token: 0x04012B8B RID: 76683
		internal static int __PropertyOffset_bShouldBeVisibleInGame;

		// Token: 0x04012B8C RID: 76684
		internal static byte __PropertyMask_bShouldBeVisibleInGame;

		// Token: 0x04012B8D RID: 76685
		internal static int __PropertyOffset_CostDisplayMode;

		// Token: 0x04012B8E RID: 76686
		internal static int __PropertyOffset_TextCanvasOffset;

		// Token: 0x04012B8F RID: 76687
		internal static int __PropertyOffset_bPathExist;

		// Token: 0x04012B90 RID: 76688
		internal static byte __PropertyMask_bPathExist;

		// Token: 0x04012B91 RID: 76689
		internal static int __PropertyOffset_bPathIsPartial;

		// Token: 0x04012B92 RID: 76690
		internal static byte __PropertyMask_bPathIsPartial;

		// Token: 0x04012B93 RID: 76691
		internal static int __PropertyOffset_bPathSearchOutOfNodes;

		// Token: 0x04012B94 RID: 76692
		internal static byte __PropertyMask_bPathSearchOutOfNodes;

		// Token: 0x04012B95 RID: 76693
		internal static int __PropertyOffset_PathfindingTime;

		// Token: 0x04012B96 RID: 76694
		internal static int __PropertyOffset_PathCost;

		// Token: 0x04012B97 RID: 76695
		internal static int __PropertyOffset_PathfindingSteps;

		// Token: 0x04012B98 RID: 76696
		internal static int __PropertyOffset_OtherActor;

		// Token: 0x04012B99 RID: 76697
		internal static int __PropertyOffset_FilterClass;

		// Token: 0x04012B9A RID: 76698
		internal static int __PropertyOffset_ShowStepIndex;

		// Token: 0x04012B9B RID: 76699
		internal static int __PropertyOffset_OffsetFromCornersDistance;
	}
}
