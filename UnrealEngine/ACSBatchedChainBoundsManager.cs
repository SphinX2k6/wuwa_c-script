using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001772 RID: 6002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.CSBatchedChainBoundsManager")]
	[UnrealStructLayout(2184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2184)]
	public class ACSBatchedChainBoundsManager : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015951 RID: 88401 RVA: 0x001FC063 File Offset: 0x001FA263
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACSBatchedChainBoundsManager._ClassPtr;
		}

		// Token: 0x06015952 RID: 88402 RVA: 0x001FC070 File Offset: 0x001FA270
		public ACSBatchedChainBoundsManager() : this(BuiltinUtils.AllocNativeUObject(ACSBatchedChainBoundsManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015953 RID: 88403 RVA: 0x001FC098 File Offset: 0x001FA298
		public ACSBatchedChainBoundsManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACSBatchedChainBoundsManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x06015954 RID: 88404 RVA: 0x001FC0CB File Offset: 0x001FA2CB
		// (set) Token: 0x06015955 RID: 88405 RVA: 0x001FC0DF File Offset: 0x001FA2DF
		[Nullable(2)]
		public unsafe UBoxComponent ManagementBounds
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACSBatchedChainBoundsManager.__PropertyOffset_ManagementBounds);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACSBatchedChainBoundsManager.__PropertyOffset_ManagementBounds, value);
			}
		}

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x06015956 RID: 88406 RVA: 0x001FC0F4 File Offset: 0x001FA2F4
		// (set) Token: 0x06015957 RID: 88407 RVA: 0x001FC108 File Offset: 0x001FA308
		[Nullable(2)]
		public unsafe UCSBatchedChainDataAsset ChainDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCSBatchedChainDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ACSBatchedChainBoundsManager.__PropertyOffset_ChainDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACSBatchedChainBoundsManager.__PropertyOffset_ChainDataAsset, value);
			}
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x06015958 RID: 88408 RVA: 0x001FC11D File Offset: 0x001FA31D
		// (set) Token: 0x06015959 RID: 88409 RVA: 0x001FC12D File Offset: 0x001FA32D
		public unsafe bool bPopulateOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bPopulateOnBeginPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bPopulateOnBeginPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x0601595A RID: 88410 RVA: 0x001FC13E File Offset: 0x001FA33E
		// (set) Token: 0x0601595B RID: 88411 RVA: 0x001FC14E File Offset: 0x001FA34E
		public unsafe bool bIncludeHiddenSourceMeshes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bIncludeHiddenSourceMeshes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bIncludeHiddenSourceMeshes) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x0601595C RID: 88412 RVA: 0x001FC160 File Offset: 0x001FA360
		// (set) Token: 0x0601595D RID: 88413 RVA: 0x001FC199 File Offset: 0x001FA399
		public FCollisionProfileName StaticFallbackCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._StaticFallbackCollisionProfile) == null)
				{
					result = (this._StaticFallbackCollisionProfile = new FCollisionProfileName(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_StaticFallbackCollisionProfile, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_StaticFallbackCollisionProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x0601595E RID: 88414 RVA: 0x001FC1BA File Offset: 0x001FA3BA
		// (set) Token: 0x0601595F RID: 88415 RVA: 0x001FC1CE File Offset: 0x001FA3CE
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionEnabled> StaticFallbackCollisionEnabled
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_StaticFallbackCollisionEnabled);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_StaticFallbackCollisionEnabled) = value;
			}
		}

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x06015960 RID: 88416 RVA: 0x001FC1E3 File Offset: 0x001FA3E3
		// (set) Token: 0x06015961 RID: 88417 RVA: 0x001FC1F3 File Offset: 0x001FA3F3
		public unsafe ECSBatchedChainBakeState BakeState
		{
			get
			{
				return (ECSBatchedChainBakeState)(*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakeState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakeState) = (byte)value;
			}
		}

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x06015962 RID: 88418 RVA: 0x001FC204 File Offset: 0x001FA404
		// (set) Token: 0x06015963 RID: 88419 RVA: 0x001FC214 File Offset: 0x001FA414
		public unsafe bool bHasValidBake
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bHasValidBake) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bHasValidBake) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x06015964 RID: 88420 RVA: 0x001FC225 File Offset: 0x001FA425
		// (set) Token: 0x06015965 RID: 88421 RVA: 0x001FC235 File Offset: 0x001FA435
		public unsafe int SimulationSubsteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationSubsteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationSubsteps) = value;
			}
		}

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x06015966 RID: 88422 RVA: 0x001FC246 File Offset: 0x001FA446
		// (set) Token: 0x06015967 RID: 88423 RVA: 0x001FC256 File Offset: 0x001FA456
		public unsafe int JacobiSolverIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_JacobiSolverIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_JacobiSolverIterations) = value;
			}
		}

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x06015968 RID: 88424 RVA: 0x001FC267 File Offset: 0x001FA467
		// (set) Token: 0x06015969 RID: 88425 RVA: 0x001FC277 File Offset: 0x001FA477
		public unsafe bool bEnableSimulationSleep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableSimulationSleep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableSimulationSleep) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x0601596A RID: 88426 RVA: 0x001FC288 File Offset: 0x001FA488
		// (set) Token: 0x0601596B RID: 88427 RVA: 0x001FC298 File Offset: 0x001FA498
		public unsafe float SimulationWakeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationWakeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationWakeDistance) = value;
			}
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x0601596C RID: 88428 RVA: 0x001FC2A9 File Offset: 0x001FA4A9
		// (set) Token: 0x0601596D RID: 88429 RVA: 0x001FC2B9 File Offset: 0x001FA4B9
		public unsafe float SimulationRecentlyRenderedTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationRecentlyRenderedTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationRecentlyRenderedTolerance) = value;
			}
		}

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x0601596E RID: 88430 RVA: 0x001FC2CA File Offset: 0x001FA4CA
		// (set) Token: 0x0601596F RID: 88431 RVA: 0x001FC2DA File Offset: 0x001FA4DA
		public unsafe int SimulationSleepCheckIntervalFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationSleepCheckIntervalFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SimulationSleepCheckIntervalFrames) = value;
			}
		}

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x06015970 RID: 88432 RVA: 0x001FC2EB File Offset: 0x001FA4EB
		// (set) Token: 0x06015971 RID: 88433 RVA: 0x001FC2FB File Offset: 0x001FA4FB
		public unsafe bool bSimulationSleeping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bSimulationSleeping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bSimulationSleeping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x06015972 RID: 88434 RVA: 0x001FC30C File Offset: 0x001FA50C
		// (set) Token: 0x06015973 RID: 88435 RVA: 0x001FC31C File Offset: 0x001FA51C
		public unsafe bool bCollectPerformanceDiagnostics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bCollectPerformanceDiagnostics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bCollectPerformanceDiagnostics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x06015974 RID: 88436 RVA: 0x001FC32D File Offset: 0x001FA52D
		// (set) Token: 0x06015975 RID: 88437 RVA: 0x001FC33D File Offset: 0x001FA53D
		public unsafe bool bEnableGpuTimestampQueries
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableGpuTimestampQueries) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableGpuTimestampQueries) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x06015976 RID: 88438 RVA: 0x001FC34E File Offset: 0x001FA54E
		// (set) Token: 0x06015977 RID: 88439 RVA: 0x001FC35E File Offset: 0x001FA55E
		public unsafe bool bDrawPerformancePanel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bDrawPerformancePanel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bDrawPerformancePanel) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x06015978 RID: 88440 RVA: 0x001FC36F File Offset: 0x001FA56F
		// (set) Token: 0x06015979 RID: 88441 RVA: 0x001FC37F File Offset: 0x001FA57F
		public unsafe bool bLogPerformanceSummary
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bLogPerformanceSummary) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bLogPerformanceSummary) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x0601597A RID: 88442 RVA: 0x001FC390 File Offset: 0x001FA590
		// (set) Token: 0x0601597B RID: 88443 RVA: 0x001FC3A0 File Offset: 0x001FA5A0
		public unsafe float PerformancePanelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelScale) = value;
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x0601597C RID: 88444 RVA: 0x001FC3B1 File Offset: 0x001FA5B1
		// (set) Token: 0x0601597D RID: 88445 RVA: 0x001FC3C1 File Offset: 0x001FA5C1
		public unsafe float PerformancePanelTextScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelTextScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelTextScale) = value;
			}
		}

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x0601597E RID: 88446 RVA: 0x001FC3D2 File Offset: 0x001FA5D2
		// (set) Token: 0x0601597F RID: 88447 RVA: 0x001FC3E2 File Offset: 0x001FA5E2
		public unsafe float PerformancePanelBackgroundOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelBackgroundOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelBackgroundOpacity) = value;
			}
		}

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x06015980 RID: 88448 RVA: 0x001FC3F3 File Offset: 0x001FA5F3
		// (set) Token: 0x06015981 RID: 88449 RVA: 0x001FC403 File Offset: 0x001FA603
		public unsafe int PerformancePanelMaxLegendEntries
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelMaxLegendEntries);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PerformancePanelMaxLegendEntries) = value;
			}
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x06015982 RID: 88450 RVA: 0x001FC414 File Offset: 0x001FA614
		// (set) Token: 0x06015983 RID: 88451 RVA: 0x001FC424 File Offset: 0x001FA624
		public unsafe bool bDrawGpuProxyDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bDrawGpuProxyDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bDrawGpuProxyDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x06015984 RID: 88452 RVA: 0x001FC435 File Offset: 0x001FA635
		// (set) Token: 0x06015985 RID: 88453 RVA: 0x001FC445 File Offset: 0x001FA645
		public unsafe float GpuProxyDebugPointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GpuProxyDebugPointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GpuProxyDebugPointSize) = value;
			}
		}

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x06015986 RID: 88454 RVA: 0x001FC456 File Offset: 0x001FA656
		// (set) Token: 0x06015987 RID: 88455 RVA: 0x001FC466 File Offset: 0x001FA666
		public unsafe float GpuProxyDebugLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GpuProxyDebugLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GpuProxyDebugLineThickness) = value;
			}
		}

		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x06015988 RID: 88456 RVA: 0x001FC477 File Offset: 0x001FA677
		// (set) Token: 0x06015989 RID: 88457 RVA: 0x001FC487 File Offset: 0x001FA687
		public unsafe bool bEnableRigidSpatialHashCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableRigidSpatialHashCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableRigidSpatialHashCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x0601598A RID: 88458 RVA: 0x001FC498 File Offset: 0x001FA698
		// (set) Token: 0x0601598B RID: 88459 RVA: 0x001FC4A8 File Offset: 0x001FA6A8
		public unsafe float RigidSpatialHashCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashCellSize) = value;
			}
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x0601598C RID: 88460 RVA: 0x001FC4B9 File Offset: 0x001FA6B9
		// (set) Token: 0x0601598D RID: 88461 RVA: 0x001FC4C9 File Offset: 0x001FA6C9
		public unsafe int RigidSpatialHashIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashIterations) = value;
			}
		}

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x0601598E RID: 88462 RVA: 0x001FC4DA File Offset: 0x001FA6DA
		// (set) Token: 0x0601598F RID: 88463 RVA: 0x001FC4EA File Offset: 0x001FA6EA
		public unsafe float RigidSpatialHashCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidSpatialHashCollisionStiffness) = value;
			}
		}

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x06015990 RID: 88464 RVA: 0x001FC4FB File Offset: 0x001FA6FB
		// (set) Token: 0x06015991 RID: 88465 RVA: 0x001FC50B File Offset: 0x001FA70B
		public unsafe float RigidContactDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactDamping) = value;
			}
		}

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x06015992 RID: 88466 RVA: 0x001FC51C File Offset: 0x001FA71C
		// (set) Token: 0x06015993 RID: 88467 RVA: 0x001FC52C File Offset: 0x001FA72C
		public unsafe float RigidContactStopDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactStopDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactStopDistance) = value;
			}
		}

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x06015994 RID: 88468 RVA: 0x001FC53D File Offset: 0x001FA73D
		// (set) Token: 0x06015995 RID: 88469 RVA: 0x001FC54D File Offset: 0x001FA74D
		public unsafe float RigidContactSlop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactSlop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidContactSlop) = value;
			}
		}

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x06015996 RID: 88470 RVA: 0x001FC55E File Offset: 0x001FA75E
		// (set) Token: 0x06015997 RID: 88471 RVA: 0x001FC56E File Offset: 0x001FA76E
		public unsafe float RigidMaxContactCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidMaxContactCorrection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RigidMaxContactCorrection) = value;
			}
		}

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x06015998 RID: 88472 RVA: 0x001FC57F File Offset: 0x001FA77F
		// (set) Token: 0x06015999 RID: 88473 RVA: 0x001FC58F File Offset: 0x001FA78F
		public unsafe bool bEnableGlobalDistanceFieldCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableGlobalDistanceFieldCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableGlobalDistanceFieldCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x0601599A RID: 88474 RVA: 0x001FC5A0 File Offset: 0x001FA7A0
		// (set) Token: 0x0601599B RID: 88475 RVA: 0x001FC5B0 File Offset: 0x001FA7B0
		public unsafe float GlobalDistanceFieldMinSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldMinSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldMinSafeDistance) = value;
			}
		}

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x0601599C RID: 88476 RVA: 0x001FC5C1 File Offset: 0x001FA7C1
		// (set) Token: 0x0601599D RID: 88477 RVA: 0x001FC5D1 File Offset: 0x001FA7D1
		public unsafe float GlobalDistanceFieldDynamicSafeDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor) = value;
			}
		}

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x0601599E RID: 88478 RVA: 0x001FC5E2 File Offset: 0x001FA7E2
		// (set) Token: 0x0601599F RID: 88479 RVA: 0x001FC5F2 File Offset: 0x001FA7F2
		public unsafe float GlobalDistanceFieldCorrectionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldCorrectionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldCorrectionStiffness) = value;
			}
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x060159A0 RID: 88480 RVA: 0x001FC603 File Offset: 0x001FA803
		// (set) Token: 0x060159A1 RID: 88481 RVA: 0x001FC613 File Offset: 0x001FA813
		public unsafe float GlobalDistanceFieldMaxCorrectionPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame) = value;
			}
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x060159A2 RID: 88482 RVA: 0x001FC624 File Offset: 0x001FA824
		// (set) Token: 0x060159A3 RID: 88483 RVA: 0x001FC634 File Offset: 0x001FA834
		public unsafe bool bEnablePlayerCapsuleInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnablePlayerCapsuleInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnablePlayerCapsuleInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x060159A4 RID: 88484 RVA: 0x001FC645 File Offset: 0x001FA845
		// (set) Token: 0x060159A5 RID: 88485 RVA: 0x001FC655 File Offset: 0x001FA855
		public unsafe int PlayerCapsuleContactIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCapsuleContactIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCapsuleContactIterations) = value;
			}
		}

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x060159A6 RID: 88486 RVA: 0x001FC666 File Offset: 0x001FA866
		// (set) Token: 0x060159A7 RID: 88487 RVA: 0x001FC676 File Offset: 0x001FA876
		public unsafe float PlayerCollisionSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCollisionSkin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCollisionSkin) = value;
			}
		}

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x060159A8 RID: 88488 RVA: 0x001FC687 File Offset: 0x001FA887
		// (set) Token: 0x060159A9 RID: 88489 RVA: 0x001FC697 File Offset: 0x001FA897
		public unsafe float SoftParticleCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SoftParticleCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_SoftParticleCollisionRadius) = value;
			}
		}

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x060159AA RID: 88490 RVA: 0x001FC6A8 File Offset: 0x001FA8A8
		// (set) Token: 0x060159AB RID: 88491 RVA: 0x001FC6B8 File Offset: 0x001FA8B8
		public unsafe float PlayerCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PlayerCollisionStiffness) = value;
			}
		}

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x060159AC RID: 88492 RVA: 0x001FC6C9 File Offset: 0x001FA8C9
		// (set) Token: 0x060159AD RID: 88493 RVA: 0x001FC6D9 File Offset: 0x001FA8D9
		public unsafe float MaxPlayerInteractionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_MaxPlayerInteractionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_MaxPlayerInteractionSpeed) = value;
			}
		}

		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x060159AE RID: 88494 RVA: 0x001FC6EA File Offset: 0x001FA8EA
		// (set) Token: 0x060159AF RID: 88495 RVA: 0x001FC6FA File Offset: 0x001FA8FA
		public unsafe bool bEnableOfflineWindAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableOfflineWindAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bEnableOfflineWindAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x060159B0 RID: 88496 RVA: 0x001FC70B File Offset: 0x001FA90B
		// (set) Token: 0x060159B1 RID: 88497 RVA: 0x001FC71B File Offset: 0x001FA91B
		public unsafe bool bLoopOfflineWindAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bLoopOfflineWindAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bLoopOfflineWindAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x060159B2 RID: 88498 RVA: 0x001FC72C File Offset: 0x001FA92C
		// (set) Token: 0x060159B3 RID: 88499 RVA: 0x001FC73C File Offset: 0x001FA93C
		public unsafe float OfflineWindPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_OfflineWindPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_OfflineWindPlayRate) = value;
			}
		}

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x060159B4 RID: 88500 RVA: 0x001FC750 File Offset: 0x001FA950
		// (set) Token: 0x060159B5 RID: 88501 RVA: 0x001FC789 File Offset: 0x001FA989
		public TArray<FCSBatchedChainBakedInstance> BakedInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCSBatchedChainBakedInstance> result;
				if ((result = this._BakedInstances) == null)
				{
					result = (this._BakedInstances = new TArray<FCSBatchedChainBakedInstance>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedInstances, this));
				}
				return result;
			}
			set
			{
				this.BakedInstances.CopyAssign(value);
			}
		}

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x060159B6 RID: 88502 RVA: 0x001FC797 File Offset: 0x001FA997
		// (set) Token: 0x060159B7 RID: 88503 RVA: 0x001FC7A7 File Offset: 0x001FA9A7
		public unsafe int BakedInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedInstanceCount) = value;
			}
		}

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x060159B8 RID: 88504 RVA: 0x001FC7B8 File Offset: 0x001FA9B8
		// (set) Token: 0x060159B9 RID: 88505 RVA: 0x001FC7C8 File Offset: 0x001FA9C8
		public unsafe int BakedUnmatchedMeshCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedUnmatchedMeshCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedUnmatchedMeshCount) = value;
			}
		}

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x060159BA RID: 88506 RVA: 0x001FC7DC File Offset: 0x001FA9DC
		// (set) Token: 0x060159BB RID: 88507 RVA: 0x001FC815 File Offset: 0x001FAA15
		public TArray<UJacobiChainPrebuiltData> PrebuiltMeshData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UJacobiChainPrebuiltData> result;
				if ((result = this._PrebuiltMeshData) == null)
				{
					result = (this._PrebuiltMeshData = new TArray<UJacobiChainPrebuiltData>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_PrebuiltMeshData, this));
				}
				return result;
			}
			set
			{
				this.PrebuiltMeshData.CopyAssign(value);
			}
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x060159BC RID: 88508 RVA: 0x001FC824 File Offset: 0x001FAA24
		// (set) Token: 0x060159BD RID: 88509 RVA: 0x001FC85D File Offset: 0x001FAA5D
		public TArray<UJacobiChainComponent> BakedRuntimeComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UJacobiChainComponent> result;
				if ((result = this._BakedRuntimeComponents) == null)
				{
					result = (this._BakedRuntimeComponents = new TArray<UJacobiChainComponent>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_BakedRuntimeComponents, this));
				}
				return result;
			}
			set
			{
				this.BakedRuntimeComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x060159BE RID: 88510 RVA: 0x001FC86C File Offset: 0x001FAA6C
		// (set) Token: 0x060159BF RID: 88511 RVA: 0x001FC8A5 File Offset: 0x001FAAA5
		public TArray<UCSBatchedChainEditableComponent> EditableComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCSBatchedChainEditableComponent> result;
				if ((result = this._EditableComponents) == null)
				{
					result = (this._EditableComponents = new TArray<UCSBatchedChainEditableComponent>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_EditableComponents, this));
				}
				return result;
			}
			set
			{
				this.EditableComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x060159C0 RID: 88512 RVA: 0x001FC8B3 File Offset: 0x001FAAB3
		// (set) Token: 0x060159C1 RID: 88513 RVA: 0x001FC8C3 File Offset: 0x001FAAC3
		public unsafe int ManagedWindChimeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_ManagedWindChimeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_ManagedWindChimeCount) = value;
			}
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x060159C2 RID: 88514 RVA: 0x001FC8D4 File Offset: 0x001FAAD4
		// (set) Token: 0x060159C3 RID: 88515 RVA: 0x001FC8E4 File Offset: 0x001FAAE4
		public unsafe int UnmatchedMeshCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_UnmatchedMeshCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_UnmatchedMeshCount) = value;
			}
		}

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x060159C4 RID: 88516 RVA: 0x001FC8F5 File Offset: 0x001FAAF5
		// (set) Token: 0x060159C5 RID: 88517 RVA: 0x001FC905 File Offset: 0x001FAB05
		public unsafe ECSBatchedChainRuntimeBackend RuntimeBackend
		{
			get
			{
				return (ECSBatchedChainRuntimeBackend)(*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RuntimeBackend));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RuntimeBackend) = (byte)value;
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x060159C6 RID: 88518 RVA: 0x001FC916 File Offset: 0x001FAB16
		// (set) Token: 0x060159C7 RID: 88519 RVA: 0x001FC926 File Offset: 0x001FAB26
		public unsafe float InitializationTimeBudgetMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_InitializationTimeBudgetMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_InitializationTimeBudgetMs) = value;
			}
		}

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x060159C8 RID: 88520 RVA: 0x001FC937 File Offset: 0x001FAB37
		// (set) Token: 0x060159C9 RID: 88521 RVA: 0x001FC947 File Offset: 0x001FAB47
		public unsafe bool bJacobiReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bJacobiReady) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_bJacobiReady) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x060159CA RID: 88522 RVA: 0x001FC958 File Offset: 0x001FAB58
		// (set) Token: 0x060159CB RID: 88523 RVA: 0x001FC991 File Offset: 0x001FAB91
		public TArray<UJacobiChainComponent> ManagedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UJacobiChainComponent> result;
				if ((result = this._ManagedComponents) == null)
				{
					result = (this._ManagedComponents = new TArray<UJacobiChainComponent>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_ManagedComponents, this));
				}
				return result;
			}
			set
			{
				this.ManagedComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x060159CC RID: 88524 RVA: 0x001FC9A0 File Offset: 0x001FABA0
		// (set) Token: 0x060159CD RID: 88525 RVA: 0x001FC9D9 File Offset: 0x001FABD9
		public TArray<UJacobiChainComponent> RuntimeJacobiComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UJacobiChainComponent> result;
				if ((result = this._RuntimeJacobiComponents) == null)
				{
					result = (this._RuntimeJacobiComponents = new TArray<UJacobiChainComponent>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RuntimeJacobiComponents, this));
				}
				return result;
			}
			set
			{
				this.RuntimeJacobiComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x060159CE RID: 88526 RVA: 0x001FC9E8 File Offset: 0x001FABE8
		// (set) Token: 0x060159CF RID: 88527 RVA: 0x001FCA21 File Offset: 0x001FAC21
		public TArray<UStaticMeshComponent> RuntimeStaticComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._RuntimeStaticComponents) == null)
				{
					result = (this._RuntimeStaticComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)ACSBatchedChainBoundsManager.__PropertyOffset_RuntimeStaticComponents, this));
				}
				return result;
			}
			set
			{
				this.RuntimeStaticComponents.CopyAssign(value);
			}
		}

		// Token: 0x060159D0 RID: 88528 RVA: 0x001FCA2F File Offset: 0x001FAC2F
		public void StopAllSimulations()
		{
			ACSBatchedChainBoundsManager.__StopAllSimulations_Internal(base.NativePtr);
		}

		// Token: 0x060159D1 RID: 88529 RVA: 0x001FCA3C File Offset: 0x001FAC3C
		public void StartAllSimulations()
		{
			ACSBatchedChainBoundsManager.__StartAllSimulations_Internal(base.NativePtr);
		}

		// Token: 0x060159D2 RID: 88530 RVA: 0x001FCA49 File Offset: 0x001FAC49
		public void SetSimulationEnabled(bool bEnabled)
		{
			ACSBatchedChainBoundsManager.__SetSimulationEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x060159D3 RID: 88531 RVA: 0x001FCA57 File Offset: 0x001FAC57
		public void ResetPerformanceDiagnostics()
		{
			ACSBatchedChainBoundsManager.__ResetPerformanceDiagnostics_Internal(base.NativePtr);
		}

		// Token: 0x060159D4 RID: 88532 RVA: 0x001FCA64 File Offset: 0x001FAC64
		public void ResetAllSimulations()
		{
			ACSBatchedChainBoundsManager.__ResetAllSimulations_Internal(base.NativePtr);
		}

		// Token: 0x060159D5 RID: 88533 RVA: 0x001FCA71 File Offset: 0x001FAC71
		public void PopulateManagedWindChimes()
		{
			ACSBatchedChainBoundsManager.__PopulateManagedWindChimes_Internal(base.NativePtr);
		}

		// Token: 0x060159D6 RID: 88534 RVA: 0x001FCA7E File Offset: 0x001FAC7E
		public void PlayAllOfflineWindAnimations()
		{
			ACSBatchedChainBoundsManager.__PlayAllOfflineWindAnimations_Internal(base.NativePtr);
		}

		// Token: 0x060159D7 RID: 88535 RVA: 0x001FCA8B File Offset: 0x001FAC8B
		public void PauseAllOfflineWindAnimations()
		{
			ACSBatchedChainBoundsManager.__PauseAllOfflineWindAnimations_Internal(base.NativePtr);
		}

		// Token: 0x060159D8 RID: 88536 RVA: 0x001FCA98 File Offset: 0x001FAC98
		public bool IsGpuJacobiSupported()
		{
			return ACSBatchedChainBoundsManager.__IsGpuJacobiSupported_Internal(base.NativePtr);
		}

		// Token: 0x060159D9 RID: 88537 RVA: 0x001FCAA5 File Offset: 0x001FACA5
		public void ClearManagedWindChimes()
		{
			ACSBatchedChainBoundsManager.__ClearManagedWindChimes_Internal(base.NativePtr);
		}

		// Token: 0x060159DA RID: 88538 RVA: 0x001FCAB2 File Offset: 0x001FACB2
		public void ChainTick(float DeltaSeconds, FVectorDouble PlayerAbsoluteWorldPositionCm)
		{
			ACSBatchedChainBoundsManager.__ChainTick_Internal(base.NativePtr, DeltaSeconds, PlayerAbsoluteWorldPositionCm);
		}

		// Token: 0x060159DB RID: 88539 RVA: 0x001FCAC1 File Offset: 0x001FACC1
		public void ChainConstruct()
		{
			ACSBatchedChainBoundsManager.__ChainConstruct_Internal(base.NativePtr);
		}

		// Token: 0x060159DC RID: 88540 RVA: 0x001FCACE File Offset: 0x001FACCE
		public void ChainBeginPlay(ECSBatchedChainRuntimeBackend SelectedRuntimeBackend)
		{
			ACSBatchedChainBoundsManager.__ChainBeginPlay_Internal(base.NativePtr, SelectedRuntimeBackend);
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x001FCADC File Offset: 0x001FACDC
		public void Bake()
		{
			ACSBatchedChainBoundsManager.__Bake_Internal(base.NativePtr);
		}

		// Token: 0x060159DE RID: 88542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllSimulations_Internal(IntPtr @this);

		// Token: 0x060159DF RID: 88543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAllSimulations_Internal(IntPtr @this);

		// Token: 0x060159E0 RID: 88544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSimulationEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x060159E1 RID: 88545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetPerformanceDiagnostics_Internal(IntPtr @this);

		// Token: 0x060159E2 RID: 88546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllSimulations_Internal(IntPtr @this);

		// Token: 0x060159E3 RID: 88547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PopulateManagedWindChimes_Internal(IntPtr @this);

		// Token: 0x060159E4 RID: 88548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAllOfflineWindAnimations_Internal(IntPtr @this);

		// Token: 0x060159E5 RID: 88549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseAllOfflineWindAnimations_Internal(IntPtr @this);

		// Token: 0x060159E6 RID: 88550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGpuJacobiSupported_Internal(IntPtr @this);

		// Token: 0x060159E7 RID: 88551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearManagedWindChimes_Internal(IntPtr @this);

		// Token: 0x060159E8 RID: 88552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChainTick_Internal(IntPtr @this, float DeltaSeconds, FVectorDouble PlayerAbsoluteWorldPositionCm);

		// Token: 0x060159E9 RID: 88553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChainConstruct_Internal(IntPtr @this);

		// Token: 0x060159EA RID: 88554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChainBeginPlay_Internal(IntPtr @this, ECSBatchedChainRuntimeBackend SelectedRuntimeBackend);

		// Token: 0x060159EB RID: 88555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Bake_Internal(IntPtr @this);

		// Token: 0x060159EC RID: 88556 RVA: 0x001FCAE9 File Offset: 0x001FACE9
		static ACSBatchedChainBoundsManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.CSBatchedChainBoundsManager");
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x001FCAF7 File Offset: 0x001FACF7
		protected ACSBatchedChainBoundsManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BC65 RID: 48229
		public new const string __ObjectPath = "/Script/KuroComputeShader.CSBatchedChainBoundsManager";

		// Token: 0x0400BC66 RID: 48230
		private static IntPtr _ClassPtr;

		// Token: 0x0400BC67 RID: 48231
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BC68 RID: 48232
		internal static int __PropertyOffset_ManagementBounds;

		// Token: 0x0400BC69 RID: 48233
		internal static int __PropertyOffset_ChainDataAsset;

		// Token: 0x0400BC6A RID: 48234
		internal static int __PropertyOffset_bPopulateOnBeginPlay;

		// Token: 0x0400BC6B RID: 48235
		internal static int __PropertyOffset_bIncludeHiddenSourceMeshes;

		// Token: 0x0400BC6C RID: 48236
		internal static int __PropertyOffset_StaticFallbackCollisionProfile;

		// Token: 0x0400BC6D RID: 48237
		[Nullable(2)]
		private FCollisionProfileName _StaticFallbackCollisionProfile;

		// Token: 0x0400BC6E RID: 48238
		internal static int __PropertyOffset_StaticFallbackCollisionEnabled;

		// Token: 0x0400BC6F RID: 48239
		internal static int __PropertyOffset_BakeState;

		// Token: 0x0400BC70 RID: 48240
		internal static int __PropertyOffset_bHasValidBake;

		// Token: 0x0400BC71 RID: 48241
		internal static int __PropertyOffset_SimulationSubsteps;

		// Token: 0x0400BC72 RID: 48242
		internal static int __PropertyOffset_JacobiSolverIterations;

		// Token: 0x0400BC73 RID: 48243
		internal static int __PropertyOffset_bEnableSimulationSleep;

		// Token: 0x0400BC74 RID: 48244
		internal static int __PropertyOffset_SimulationWakeDistance;

		// Token: 0x0400BC75 RID: 48245
		internal static int __PropertyOffset_SimulationRecentlyRenderedTolerance;

		// Token: 0x0400BC76 RID: 48246
		internal static int __PropertyOffset_SimulationSleepCheckIntervalFrames;

		// Token: 0x0400BC77 RID: 48247
		internal static int __PropertyOffset_bSimulationSleeping;

		// Token: 0x0400BC78 RID: 48248
		internal static int __PropertyOffset_bCollectPerformanceDiagnostics;

		// Token: 0x0400BC79 RID: 48249
		internal static int __PropertyOffset_bEnableGpuTimestampQueries;

		// Token: 0x0400BC7A RID: 48250
		internal static int __PropertyOffset_bDrawPerformancePanel;

		// Token: 0x0400BC7B RID: 48251
		internal static int __PropertyOffset_bLogPerformanceSummary;

		// Token: 0x0400BC7C RID: 48252
		internal static int __PropertyOffset_PerformancePanelScale;

		// Token: 0x0400BC7D RID: 48253
		internal static int __PropertyOffset_PerformancePanelTextScale;

		// Token: 0x0400BC7E RID: 48254
		internal static int __PropertyOffset_PerformancePanelBackgroundOpacity;

		// Token: 0x0400BC7F RID: 48255
		internal static int __PropertyOffset_PerformancePanelMaxLegendEntries;

		// Token: 0x0400BC80 RID: 48256
		internal static int __PropertyOffset_bDrawGpuProxyDebug;

		// Token: 0x0400BC81 RID: 48257
		internal static int __PropertyOffset_GpuProxyDebugPointSize;

		// Token: 0x0400BC82 RID: 48258
		internal static int __PropertyOffset_GpuProxyDebugLineThickness;

		// Token: 0x0400BC83 RID: 48259
		internal static int __PropertyOffset_bEnableRigidSpatialHashCollision;

		// Token: 0x0400BC84 RID: 48260
		internal static int __PropertyOffset_RigidSpatialHashCellSize;

		// Token: 0x0400BC85 RID: 48261
		internal static int __PropertyOffset_RigidSpatialHashIterations;

		// Token: 0x0400BC86 RID: 48262
		internal static int __PropertyOffset_RigidSpatialHashCollisionStiffness;

		// Token: 0x0400BC87 RID: 48263
		internal static int __PropertyOffset_RigidContactDamping;

		// Token: 0x0400BC88 RID: 48264
		internal static int __PropertyOffset_RigidContactStopDistance;

		// Token: 0x0400BC89 RID: 48265
		internal static int __PropertyOffset_RigidContactSlop;

		// Token: 0x0400BC8A RID: 48266
		internal static int __PropertyOffset_RigidMaxContactCorrection;

		// Token: 0x0400BC8B RID: 48267
		internal static int __PropertyOffset_bEnableGlobalDistanceFieldCollision;

		// Token: 0x0400BC8C RID: 48268
		internal static int __PropertyOffset_GlobalDistanceFieldMinSafeDistance;

		// Token: 0x0400BC8D RID: 48269
		internal static int __PropertyOffset_GlobalDistanceFieldDynamicSafeDistanceFactor;

		// Token: 0x0400BC8E RID: 48270
		internal static int __PropertyOffset_GlobalDistanceFieldCorrectionStiffness;

		// Token: 0x0400BC8F RID: 48271
		internal static int __PropertyOffset_GlobalDistanceFieldMaxCorrectionPerFrame;

		// Token: 0x0400BC90 RID: 48272
		internal static int __PropertyOffset_bEnablePlayerCapsuleInteraction;

		// Token: 0x0400BC91 RID: 48273
		internal static int __PropertyOffset_PlayerCapsuleContactIterations;

		// Token: 0x0400BC92 RID: 48274
		internal static int __PropertyOffset_PlayerCollisionSkin;

		// Token: 0x0400BC93 RID: 48275
		internal static int __PropertyOffset_SoftParticleCollisionRadius;

		// Token: 0x0400BC94 RID: 48276
		internal static int __PropertyOffset_PlayerCollisionStiffness;

		// Token: 0x0400BC95 RID: 48277
		internal static int __PropertyOffset_MaxPlayerInteractionSpeed;

		// Token: 0x0400BC96 RID: 48278
		internal static int __PropertyOffset_bEnableOfflineWindAnimation;

		// Token: 0x0400BC97 RID: 48279
		internal static int __PropertyOffset_bLoopOfflineWindAnimation;

		// Token: 0x0400BC98 RID: 48280
		internal static int __PropertyOffset_OfflineWindPlayRate;

		// Token: 0x0400BC99 RID: 48281
		internal static int __PropertyOffset_BakedInstances;

		// Token: 0x0400BC9A RID: 48282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCSBatchedChainBakedInstance> _BakedInstances;

		// Token: 0x0400BC9B RID: 48283
		internal static int __PropertyOffset_BakedInstanceCount;

		// Token: 0x0400BC9C RID: 48284
		internal static int __PropertyOffset_BakedUnmatchedMeshCount;

		// Token: 0x0400BC9D RID: 48285
		internal static int __PropertyOffset_PrebuiltMeshData;

		// Token: 0x0400BC9E RID: 48286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UJacobiChainPrebuiltData> _PrebuiltMeshData;

		// Token: 0x0400BC9F RID: 48287
		internal static int __PropertyOffset_BakedRuntimeComponents;

		// Token: 0x0400BCA0 RID: 48288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UJacobiChainComponent> _BakedRuntimeComponents;

		// Token: 0x0400BCA1 RID: 48289
		internal static int __PropertyOffset_EditableComponents;

		// Token: 0x0400BCA2 RID: 48290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCSBatchedChainEditableComponent> _EditableComponents;

		// Token: 0x0400BCA3 RID: 48291
		internal static int __PropertyOffset_ManagedWindChimeCount;

		// Token: 0x0400BCA4 RID: 48292
		internal static int __PropertyOffset_UnmatchedMeshCount;

		// Token: 0x0400BCA5 RID: 48293
		internal static int __PropertyOffset_RuntimeBackend;

		// Token: 0x0400BCA6 RID: 48294
		internal static int __PropertyOffset_InitializationTimeBudgetMs;

		// Token: 0x0400BCA7 RID: 48295
		internal static int __PropertyOffset_bJacobiReady;

		// Token: 0x0400BCA8 RID: 48296
		internal static int __PropertyOffset_ManagedComponents;

		// Token: 0x0400BCA9 RID: 48297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UJacobiChainComponent> _ManagedComponents;

		// Token: 0x0400BCAA RID: 48298
		internal static int __PropertyOffset_RuntimeJacobiComponents;

		// Token: 0x0400BCAB RID: 48299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UJacobiChainComponent> _RuntimeJacobiComponents;

		// Token: 0x0400BCAC RID: 48300
		internal static int __PropertyOffset_RuntimeStaticComponents;

		// Token: 0x0400BCAD RID: 48301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _RuntimeStaticComponents;
	}
}
