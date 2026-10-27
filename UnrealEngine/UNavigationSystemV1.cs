using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002497 RID: 9367
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationSystemV1")]
	[UnrealStructLayout(5904, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5904)]
	public class UNavigationSystemV1 : UNavigationSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023065 RID: 143461 RVA: 0x0033C956 File Offset: 0x0033AB56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemV1._ClassPtr;
		}

		// Token: 0x06023066 RID: 143462 RVA: 0x0033C964 File Offset: 0x0033AB64
		public UNavigationSystemV1() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemV1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023067 RID: 143463 RVA: 0x0033C98C File Offset: 0x0033AB8C
		[NullableContext(1)]
		public UNavigationSystemV1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemV1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700868D RID: 34445
		// (get) Token: 0x06023068 RID: 143464 RVA: 0x0033C9BF File Offset: 0x0033ABBF
		// (set) Token: 0x06023069 RID: 143465 RVA: 0x0033C9D3 File Offset: 0x0033ABD3
		public unsafe ANavigationData MainNavData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationData>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationSystemV1.__PropertyOffset_MainNavData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationSystemV1.__PropertyOffset_MainNavData, value);
			}
		}

		// Token: 0x1700868E RID: 34446
		// (get) Token: 0x0602306A RID: 143466 RVA: 0x0033C9E8 File Offset: 0x0033ABE8
		// (set) Token: 0x0602306B RID: 143467 RVA: 0x0033C9FC File Offset: 0x0033ABFC
		public unsafe ANavigationData AbstractNavData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationData>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationSystemV1.__PropertyOffset_AbstractNavData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationSystemV1.__PropertyOffset_AbstractNavData, value);
			}
		}

		// Token: 0x1700868F RID: 34447
		// (get) Token: 0x0602306C RID: 143468 RVA: 0x0033CA11 File Offset: 0x0033AC11
		// (set) Token: 0x0602306D RID: 143469 RVA: 0x0033CA25 File Offset: 0x0033AC25
		public unsafe FName DefaultAgentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DefaultAgentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DefaultAgentName) = value;
			}
		}

		// Token: 0x17008690 RID: 34448
		// (get) Token: 0x0602306E RID: 143470 RVA: 0x0033CA3A File Offset: 0x0033AC3A
		// (set) Token: 0x0602306F RID: 143471 RVA: 0x0033CA4E File Offset: 0x0033AC4E
		public unsafe FName WorldPartitionRecastFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_WorldPartitionRecastFolder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_WorldPartitionRecastFolder) = value;
			}
		}

		// Token: 0x17008691 RID: 34449
		// (get) Token: 0x06023070 RID: 143472 RVA: 0x0033CA63 File Offset: 0x0033AC63
		// (set) Token: 0x06023071 RID: 143473 RVA: 0x0033CA78 File Offset: 0x0033AC78
		[Nullable(1)]
		public TSoftClassPtr<UCrowdManagerBase> CrowdManagerClass
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<UCrowdManagerBase>(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_CrowdManagerClass, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_CrowdManagerClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008692 RID: 34450
		// (get) Token: 0x06023072 RID: 143474 RVA: 0x0033CA9D File Offset: 0x0033AC9D
		// (set) Token: 0x06023073 RID: 143475 RVA: 0x0033CAB6 File Offset: 0x0033ACB6
		public unsafe bool bAutoCreateNavigationData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAutoCreateNavigationData) & UNavigationSystemV1.__PropertyMask_bAutoCreateNavigationData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAutoCreateNavigationData) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAutoCreateNavigationData) & ~UNavigationSystemV1.__PropertyMask_bAutoCreateNavigationData) | (value ? UNavigationSystemV1.__PropertyMask_bAutoCreateNavigationData : 0));
			}
		}

		// Token: 0x17008693 RID: 34451
		// (get) Token: 0x06023074 RID: 143476 RVA: 0x0033CAE6 File Offset: 0x0033ACE6
		// (set) Token: 0x06023075 RID: 143477 RVA: 0x0033CAFF File Offset: 0x0033ACFF
		public unsafe bool bSpawnNavDataInNavBoundsLevel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) & UNavigationSystemV1.__PropertyMask_bSpawnNavDataInNavBoundsLevel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) & ~UNavigationSystemV1.__PropertyMask_bSpawnNavDataInNavBoundsLevel) | (value ? UNavigationSystemV1.__PropertyMask_bSpawnNavDataInNavBoundsLevel : 0));
			}
		}

		// Token: 0x17008694 RID: 34452
		// (get) Token: 0x06023076 RID: 143478 RVA: 0x0033CB2F File Offset: 0x0033AD2F
		// (set) Token: 0x06023077 RID: 143479 RVA: 0x0033CB48 File Offset: 0x0033AD48
		public unsafe bool bAllowClientSideNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAllowClientSideNavigation) & UNavigationSystemV1.__PropertyMask_bAllowClientSideNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAllowClientSideNavigation) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bAllowClientSideNavigation) & ~UNavigationSystemV1.__PropertyMask_bAllowClientSideNavigation) | (value ? UNavigationSystemV1.__PropertyMask_bAllowClientSideNavigation : 0));
			}
		}

		// Token: 0x17008695 RID: 34453
		// (get) Token: 0x06023078 RID: 143480 RVA: 0x0033CB78 File Offset: 0x0033AD78
		// (set) Token: 0x06023079 RID: 143481 RVA: 0x0033CB91 File Offset: 0x0033AD91
		public unsafe bool bShouldDiscardSubLevelNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bShouldDiscardSubLevelNavData) & UNavigationSystemV1.__PropertyMask_bShouldDiscardSubLevelNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bShouldDiscardSubLevelNavData) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bShouldDiscardSubLevelNavData) & ~UNavigationSystemV1.__PropertyMask_bShouldDiscardSubLevelNavData) | (value ? UNavigationSystemV1.__PropertyMask_bShouldDiscardSubLevelNavData : 0));
			}
		}

		// Token: 0x17008696 RID: 34454
		// (get) Token: 0x0602307A RID: 143482 RVA: 0x0033CBC1 File Offset: 0x0033ADC1
		// (set) Token: 0x0602307B RID: 143483 RVA: 0x0033CBDA File Offset: 0x0033ADDA
		public unsafe bool bTickWhilePaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bTickWhilePaused) & UNavigationSystemV1.__PropertyMask_bTickWhilePaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bTickWhilePaused) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bTickWhilePaused) & ~UNavigationSystemV1.__PropertyMask_bTickWhilePaused) | (value ? UNavigationSystemV1.__PropertyMask_bTickWhilePaused : 0));
			}
		}

		// Token: 0x17008697 RID: 34455
		// (get) Token: 0x0602307C RID: 143484 RVA: 0x0033CC0A File Offset: 0x0033AE0A
		// (set) Token: 0x0602307D RID: 143485 RVA: 0x0033CC23 File Offset: 0x0033AE23
		public unsafe bool bSupportRebuilding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSupportRebuilding) & UNavigationSystemV1.__PropertyMask_bSupportRebuilding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSupportRebuilding) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSupportRebuilding) & ~UNavigationSystemV1.__PropertyMask_bSupportRebuilding) | (value ? UNavigationSystemV1.__PropertyMask_bSupportRebuilding : 0));
			}
		}

		// Token: 0x17008698 RID: 34456
		// (get) Token: 0x0602307E RID: 143486 RVA: 0x0033CC53 File Offset: 0x0033AE53
		// (set) Token: 0x0602307F RID: 143487 RVA: 0x0033CC6C File Offset: 0x0033AE6C
		public unsafe bool bInitialBuildingLocked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bInitialBuildingLocked) & UNavigationSystemV1.__PropertyMask_bInitialBuildingLocked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bInitialBuildingLocked) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bInitialBuildingLocked) & ~UNavigationSystemV1.__PropertyMask_bInitialBuildingLocked) | (value ? UNavigationSystemV1.__PropertyMask_bInitialBuildingLocked : 0));
			}
		}

		// Token: 0x17008699 RID: 34457
		// (get) Token: 0x06023080 RID: 143488 RVA: 0x0033CC9C File Offset: 0x0033AE9C
		// (set) Token: 0x06023081 RID: 143489 RVA: 0x0033CCB5 File Offset: 0x0033AEB5
		public unsafe bool bSkipAgentHeightCheckWhenPickingNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSkipAgentHeightCheckWhenPickingNavData) & UNavigationSystemV1.__PropertyMask_bSkipAgentHeightCheckWhenPickingNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSkipAgentHeightCheckWhenPickingNavData) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bSkipAgentHeightCheckWhenPickingNavData) & ~UNavigationSystemV1.__PropertyMask_bSkipAgentHeightCheckWhenPickingNavData) | (value ? UNavigationSystemV1.__PropertyMask_bSkipAgentHeightCheckWhenPickingNavData : 0));
			}
		}

		// Token: 0x1700869A RID: 34458
		// (get) Token: 0x06023082 RID: 143490 RVA: 0x0033CCE5 File Offset: 0x0033AEE5
		// (set) Token: 0x06023083 RID: 143491 RVA: 0x0033CCFE File Offset: 0x0033AEFE
		public unsafe bool bGenerateNavigationOnlyAroundNavigationInvokers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bGenerateNavigationOnlyAroundNavigationInvokers) & UNavigationSystemV1.__PropertyMask_bGenerateNavigationOnlyAroundNavigationInvokers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bGenerateNavigationOnlyAroundNavigationInvokers) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bGenerateNavigationOnlyAroundNavigationInvokers) & ~UNavigationSystemV1.__PropertyMask_bGenerateNavigationOnlyAroundNavigationInvokers) | (value ? UNavigationSystemV1.__PropertyMask_bGenerateNavigationOnlyAroundNavigationInvokers : 0));
			}
		}

		// Token: 0x1700869B RID: 34459
		// (get) Token: 0x06023084 RID: 143492 RVA: 0x0033CD2E File Offset: 0x0033AF2E
		// (set) Token: 0x06023085 RID: 143493 RVA: 0x0033CD3E File Offset: 0x0033AF3E
		public unsafe float ActiveTilesUpdateInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_ActiveTilesUpdateInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_ActiveTilesUpdateInterval) = value;
			}
		}

		// Token: 0x1700869C RID: 34460
		// (get) Token: 0x06023086 RID: 143494 RVA: 0x0033CD4F File Offset: 0x0033AF4F
		// (set) Token: 0x06023087 RID: 143495 RVA: 0x0033CD5F File Offset: 0x0033AF5F
		public unsafe ENavDataGatheringModeConfig DataGatheringMode
		{
			get
			{
				return (ENavDataGatheringModeConfig)(*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DataGatheringMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DataGatheringMode) = (byte)value;
			}
		}

		// Token: 0x1700869D RID: 34461
		// (get) Token: 0x06023088 RID: 143496 RVA: 0x0033CD70 File Offset: 0x0033AF70
		// (set) Token: 0x06023089 RID: 143497 RVA: 0x0033CD80 File Offset: 0x0033AF80
		public unsafe float DirtyAreaWarningSizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DirtyAreaWarningSizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DirtyAreaWarningSizeThreshold) = value;
			}
		}

		// Token: 0x1700869E RID: 34462
		// (get) Token: 0x0602308A RID: 143498 RVA: 0x0033CD94 File Offset: 0x0033AF94
		// (set) Token: 0x0602308B RID: 143499 RVA: 0x0033CDCD File Offset: 0x0033AFCD
		[Nullable(1)]
		public TArray<FNavDataConfig> SupportedAgents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNavDataConfig> result;
				if ((result = this._SupportedAgents) == null)
				{
					result = (this._SupportedAgents = new TArray<FNavDataConfig>(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_SupportedAgents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SupportedAgents.CopyAssign(value);
			}
		}

		// Token: 0x1700869F RID: 34463
		// (get) Token: 0x0602308C RID: 143500 RVA: 0x0033CDDC File Offset: 0x0033AFDC
		// (set) Token: 0x0602308D RID: 143501 RVA: 0x0033CE15 File Offset: 0x0033B015
		[Nullable(1)]
		public FNavAgentSelector SupportedAgentsMask
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgentsMask) == null)
				{
					result = (this._SupportedAgentsMask = new FNavAgentSelector(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_SupportedAgentsMask, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_SupportedAgentsMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170086A0 RID: 34464
		// (get) Token: 0x0602308E RID: 143502 RVA: 0x0033CE36 File Offset: 0x0033B036
		// (set) Token: 0x0602308F RID: 143503 RVA: 0x0033CE4F File Offset: 0x0033B04F
		public unsafe bool bEnableNavMeshMultiPlatform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bEnableNavMeshMultiPlatform) & UNavigationSystemV1.__PropertyMask_bEnableNavMeshMultiPlatform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bEnableNavMeshMultiPlatform) = ((*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_bEnableNavMeshMultiPlatform) & ~UNavigationSystemV1.__PropertyMask_bEnableNavMeshMultiPlatform) | (value ? UNavigationSystemV1.__PropertyMask_bEnableNavMeshMultiPlatform : 0));
			}
		}

		// Token: 0x170086A1 RID: 34465
		// (get) Token: 0x06023090 RID: 143504 RVA: 0x0033CE7F File Offset: 0x0033B07F
		// (set) Token: 0x06023091 RID: 143505 RVA: 0x0033CE93 File Offset: 0x0033B093
		public unsafe FBox BuildBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_BuildBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_BuildBounds) = value;
			}
		}

		// Token: 0x170086A2 RID: 34466
		// (get) Token: 0x06023092 RID: 143506 RVA: 0x0033CEA8 File Offset: 0x0033B0A8
		// (set) Token: 0x06023093 RID: 143507 RVA: 0x0033CEE1 File Offset: 0x0033B0E1
		[Nullable(1)]
		public TArray<ANavigationData> NavDataSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ANavigationData> result;
				if ((result = this._NavDataSet) == null)
				{
					result = (this._NavDataSet = new TArray<ANavigationData>(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_NavDataSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NavDataSet.CopyAssign(value);
			}
		}

		// Token: 0x170086A3 RID: 34467
		// (get) Token: 0x06023094 RID: 143508 RVA: 0x0033CEF0 File Offset: 0x0033B0F0
		// (set) Token: 0x06023095 RID: 143509 RVA: 0x0033CF29 File Offset: 0x0033B129
		[Nullable(1)]
		public TArray<ANavigationData> NavDataRegistrationQueue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ANavigationData> result;
				if ((result = this._NavDataRegistrationQueue) == null)
				{
					result = (this._NavDataRegistrationQueue = new TArray<ANavigationData>(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_NavDataRegistrationQueue, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NavDataRegistrationQueue.CopyAssign(value);
			}
		}

		// Token: 0x170086A4 RID: 34468
		// (get) Token: 0x06023096 RID: 143510 RVA: 0x0033CF38 File Offset: 0x0033B138
		// (set) Token: 0x06023097 RID: 143511 RVA: 0x0033CF71 File Offset: 0x0033B171
		[Nullable(1)]
		public FOnNavDataGenericEvent OnNavDataRegisteredEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnNavDataGenericEvent result;
				if ((result = this._OnNavDataRegisteredEvent) == null)
				{
					result = (this._OnNavDataRegisteredEvent = new FOnNavDataGenericEvent(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnNavDataRegisteredEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnNavDataRegisteredEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170086A5 RID: 34469
		// (get) Token: 0x06023098 RID: 143512 RVA: 0x0033CF94 File Offset: 0x0033B194
		// (set) Token: 0x06023099 RID: 143513 RVA: 0x0033CFCD File Offset: 0x0033B1CD
		[Nullable(1)]
		public FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnNavDataGenericEvent result;
				if ((result = this._OnNavigationGenerationFinishedDelegate) == null)
				{
					result = (this._OnNavigationGenerationFinishedDelegate = new FOnNavDataGenericEvent(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnNavigationGenerationFinishedDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnNavigationGenerationFinishedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170086A6 RID: 34470
		// (get) Token: 0x0602309A RID: 143514 RVA: 0x0033CFF0 File Offset: 0x0033B1F0
		// (set) Token: 0x0602309B RID: 143515 RVA: 0x0033D029 File Offset: 0x0033B229
		[Nullable(1)]
		public FOnCustomNavigationInitDone OnCustomNavigationInitDone
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnCustomNavigationInitDone result;
				if ((result = this._OnCustomNavigationInitDone) == null)
				{
					result = (this._OnCustomNavigationInitDone = new FOnCustomNavigationInitDone(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnCustomNavigationInitDone, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OnCustomNavigationInitDone, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170086A7 RID: 34471
		// (get) Token: 0x0602309C RID: 143516 RVA: 0x0033D04A File Offset: 0x0033B24A
		// (set) Token: 0x0602309D RID: 143517 RVA: 0x0033D05A File Offset: 0x0033B25A
		public unsafe ENavMeshTargetPlatform SystemTargetPlatform
		{
			get
			{
				return (ENavMeshTargetPlatform)(*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_SystemTargetPlatform));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_SystemTargetPlatform) = (byte)value;
			}
		}

		// Token: 0x170086A8 RID: 34472
		// (get) Token: 0x0602309E RID: 143518 RVA: 0x0033D06B File Offset: 0x0033B26B
		// (set) Token: 0x0602309F RID: 143519 RVA: 0x0033D07B File Offset: 0x0033B27B
		public unsafe FNavigationSystemRunMode OperationMode
		{
			get
			{
				return (FNavigationSystemRunMode)(*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OperationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_OperationMode) = (byte)value;
			}
		}

		// Token: 0x170086A9 RID: 34473
		// (get) Token: 0x060230A0 RID: 143520 RVA: 0x0033D08C File Offset: 0x0033B28C
		// (set) Token: 0x060230A1 RID: 143521 RVA: 0x0033D09C File Offset: 0x0033B29C
		public unsafe float DirtyAreasUpdateFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DirtyAreasUpdateFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemV1.__PropertyOffset_DirtyAreasUpdateFreq) = value;
			}
		}

		// Token: 0x060230A2 RID: 143522 RVA: 0x0033D0AD File Offset: 0x0033B2AD
		public void UnregisterNavigationInvoker(AActor Invoker)
		{
			UNavigationSystemV1.__UnregisterNavigationInvoker_Internal(base.NativePtr, (Invoker != null) ? Invoker.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230A3 RID: 143523 RVA: 0x0033D0CA File Offset: 0x0033B2CA
		public static void SimpleMoveToLocation(AController Controller, in FVector Goal)
		{
			UNavigationSystemV1.__SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x060230A4 RID: 143524 RVA: 0x0033D0E2 File Offset: 0x0033B2E2
		public static void SimpleMoveToActor(AController Controller, AActor Goal)
		{
			UNavigationSystemV1.__SimpleMoveToActor_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Goal != null) ? Goal.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230A5 RID: 143525
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetNavigationInvokeMode(ENavigationSystemInvokeMode Mode);

		// Token: 0x060230A6 RID: 143526 RVA: 0x0033D109 File Offset: 0x0033B309
		public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
		{
			UNavigationSystemV1.__SetMaxSimultaneousTileGenerationJobsCount_Internal(base.NativePtr, MaxNumberOfJobs);
		}

		// Token: 0x060230A7 RID: 143527 RVA: 0x0033D117 File Offset: 0x0033B317
		public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)
		{
			UNavigationSystemV1.__SetGeometryGatheringMode_Internal(base.NativePtr, NewMode);
		}

		// Token: 0x060230A8 RID: 143528 RVA: 0x0033D125 File Offset: 0x0033B325
		public static void SetGameLoadingFlag(UObject WorldContextObject, bool bIsLoading)
		{
			UNavigationSystemV1.__SetGameLoadingFlag_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bIsLoading);
		}

		// Token: 0x060230A9 RID: 143529 RVA: 0x0033D13D File Offset: 0x0033B33D
		public void ResetMaxSimultaneousTileGenerationJobsCount()
		{
			UNavigationSystemV1.__ResetMaxSimultaneousTileGenerationJobsCount_Internal(base.NativePtr);
		}

		// Token: 0x060230AA RID: 143530 RVA: 0x0033D14A File Offset: 0x0033B34A
		public void RegisterNavigationInvoker(AActor Invoker, float TileGenerationRadius = 3000f, float TileRemovalRadius = 5000f)
		{
			UNavigationSystemV1.__RegisterNavigationInvoker_Internal(base.NativePtr, (Invoker != null) ? Invoker.NativePtr : IntPtr.Zero, TileGenerationRadius, TileRemovalRadius);
		}

		// Token: 0x060230AB RID: 143531 RVA: 0x0033D169 File Offset: 0x0033B369
		public static FVector ProjectPointToNavigation(UObject WorldContextObject, in FVector Point, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), FVector QueryExtent = default(FVector))
		{
			return UNavigationSystemV1.__ProjectPointToNavigation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent);
		}

		// Token: 0x060230AC RID: 143532 RVA: 0x0033D199 File Offset: 0x0033B399
		public void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume)
		{
			UNavigationSystemV1.__OnNavigationBoundsUpdated_Internal(base.NativePtr, (NavVolume != null) ? NavVolume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230AD RID: 143533 RVA: 0x0033D1B8 File Offset: 0x0033B3B8
		public unsafe static bool NavigationRaycast(UObject WorldContextObject, in FVector RayStart, in FVector RayEnd, ref FVector HitLocation, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), AController Querier = null)
		{
			fixed (FVector* ptr = &HitLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__NavigationRaycast_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, RayStart, RayEnd, ref HitLocation, FilterClass._NativePtr, (Querier != null) ? Querier.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x060230AE RID: 143534 RVA: 0x0033D1FC File Offset: 0x0033B3FC
		public unsafe static bool NavigationGetWaterDeep(UObject WorldContextObject, in FVector Pos, in FVector Extend, ref float WaterTop, ref float WaterBottom, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (float* ptr = &WaterTop)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &WaterBottom)
				{
					void* ptr4 = (void*)ptr3;
					return UNavigationSystemV1.__NavigationGetWaterDeep_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Pos, Extend, ref WaterTop, ref WaterBottom, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
				}
			}
		}

		// Token: 0x060230AF RID: 143535 RVA: 0x0033D247 File Offset: 0x0033B447
		public bool K2_ReplaceAreaInOctreeData(UObject Object, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> OldArea, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> NewArea)
		{
			return UNavigationSystemV1.__K2_ReplaceAreaInOctreeData_Internal(base.NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero, OldArea._NativePtr, NewArea._NativePtr);
		}

		// Token: 0x060230B0 RID: 143536 RVA: 0x0033D270 File Offset: 0x0033B470
		public unsafe static bool K2_ProjectPointToNavigation(UObject WorldContextObject, in FVector Point, ref FVector ProjectedLocation, ANavigationData NavData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent = default(FVector), float MaxError = -1f)
		{
			fixed (FVector* ptr = &ProjectedLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__K2_ProjectPointToNavigation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, ref ProjectedLocation, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent, MaxError);
			}
		}

		// Token: 0x060230B1 RID: 143537 RVA: 0x0033D2B4 File Offset: 0x0033B4B4
		public static bool K2_ProjectPointMulti(UObject WorldContextObject, in FVectorDouble Point, ref TArray<FVectorDouble> ProjectedLocations, double MinZ, double MaxZ, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), FVectorDouble QueryExtent = default(FVectorDouble))
		{
			return UNavigationSystemV1.__K2_ProjectPointMulti_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, (ProjectedLocations ?? new TArray<FVectorDouble>()).NativePtr, MinZ, MaxZ, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent);
		}

		// Token: 0x060230B2 RID: 143538 RVA: 0x0033D308 File Offset: 0x0033B508
		public unsafe static bool K2_GetRandomReachablePointInRadius(UObject WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (FVector* ptr = &RandomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__K2_GetRandomReachablePointInRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, ref RandomLocation, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230B3 RID: 143539 RVA: 0x0033D34C File Offset: 0x0033B54C
		public unsafe static bool K2_GetRandomPointInNavigableRadius(UObject WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (FVector* ptr = &RandomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__K2_GetRandomPointInNavigableRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, ref RandomLocation, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230B4 RID: 143540 RVA: 0x0033D390 File Offset: 0x0033B590
		public unsafe static bool K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (FVector* ptr = &RandomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__K2_GetRandomLocationInNavigableRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, ref RandomLocation, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230B5 RID: 143541 RVA: 0x0033D3D3 File Offset: 0x0033B5D3
		public static bool IsStraightReachable(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), in FVector FinderHalfExtent = null)
		{
			return UNavigationSystemV1.__IsStraightReachable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, FinderHalfExtent);
		}

		// Token: 0x060230B6 RID: 143542 RVA: 0x0033D405 File Offset: 0x0033B605
		public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsNavigationBeingBuiltOrLocked_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230B7 RID: 143543 RVA: 0x0033D41C File Offset: 0x0033B61C
		public static bool IsNavigationBeingBuilt(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsNavigationBeingBuilt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230B8 RID: 143544 RVA: 0x0033D433 File Offset: 0x0033B633
		public bool IsLevelInstanceNavDataEnabled()
		{
			return UNavigationSystemV1.__IsLevelInstanceNavDataEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060230B9 RID: 143545 RVA: 0x0033D440 File Offset: 0x0033B640
		public static bool IsGameLoading(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsGameLoading_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230BA RID: 143546 RVA: 0x0033D457 File Offset: 0x0033B657
		public static void ImportNavPartitionTilesForVisualization(UObject WorldContextObject)
		{
			UNavigationSystemV1.__ImportNavPartitionTilesForVisualization_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230BB RID: 143547 RVA: 0x0033D46E File Offset: 0x0033B66E
		public bool GetWorldInitDone()
		{
			return UNavigationSystemV1.__GetWorldInitDone_Internal(base.NativePtr);
		}

		// Token: 0x060230BC RID: 143548 RVA: 0x0033D47C File Offset: 0x0033B67C
		public unsafe bool GetWaterRegionInfoBelowLocation(in FVector Location, ref TArray<int> OutWaterBodyIds, ref FVector OutWaterBottomLocation, float QueryDownDistance = 5000f)
		{
			fixed (FVector* ptr = &OutWaterBottomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__GetWaterRegionInfoBelowLocation_Internal(base.NativePtr, Location, (OutWaterBodyIds ?? new TArray<int>()).NativePtr, ref OutWaterBottomLocation, QueryDownDistance);
			}
		}

		// Token: 0x060230BD RID: 143549 RVA: 0x0033D4B0 File Offset: 0x0033B6B0
		public unsafe bool GetWaterDepthAtLocation(in FVector Location, ref float OutWaterDepth, ref float OutWaterBottomDepth, float QueryDownDistance = 5000f)
		{
			fixed (float* ptr = &OutWaterDepth)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutWaterBottomDepth)
				{
					void* ptr4 = (void*)ptr3;
					return UNavigationSystemV1.__GetWaterDepthAtLocation_Internal(base.NativePtr, Location, ref OutWaterDepth, ref OutWaterBottomDepth, QueryDownDistance);
				}
			}
		}

		// Token: 0x060230BE RID: 143550 RVA: 0x0033D4D7 File Offset: 0x0033B6D7
		public static FVector GetRandomReachablePointInRadius(UObject WorldContextObject, in FVector Origin, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return UNavigationSystemV1.__GetRandomReachablePointInRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
		}

		// Token: 0x060230BF RID: 143551 RVA: 0x0033D507 File Offset: 0x0033B707
		public static FVector GetRandomPointInNavigableRadius(UObject WorldContextObject, in FVector Origin, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return UNavigationSystemV1.__GetRandomPointInNavigableRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
		}

		// Token: 0x060230C0 RID: 143552 RVA: 0x0033D538 File Offset: 0x0033B738
		[return: Nullable(0)]
		public unsafe static TEnumAsByte<ENavigationQueryResult> GetPathLength(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, ref float PathLength, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (float* ptr = &PathLength)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__GetPathLength_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, ref PathLength, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230C1 RID: 143553 RVA: 0x0033D57C File Offset: 0x0033B77C
		[return: Nullable(0)]
		public unsafe static TEnumAsByte<ENavigationQueryResult> GetPathCost(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, ref float PathCost, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (float* ptr = &PathCost)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__GetPathCost_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, ref PathCost, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230C2 RID: 143554 RVA: 0x0033D5BF File Offset: 0x0033B7BF
		public static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationSystemV1>(UNavigationSystemV1.__GetNavigationSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060230C3 RID: 143555
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ENavigationSystemInvokeMode GetNavigationInvokeMode();

		// Token: 0x060230C4 RID: 143556 RVA: 0x0033D5DB File Offset: 0x0033B7DB
		public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bReturnPartial = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, bReturnPartial));
		}

		// Token: 0x060230C5 RID: 143557 RVA: 0x0033D614 File Offset: 0x0033B814
		public static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject, in FVector PathStart, AActor GoalActor, float TetherDistance = 50f, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindPathToActorSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, (GoalActor != null) ? GoalActor.NativePtr : IntPtr.Zero, TetherDistance, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr));
		}

		// Token: 0x060230C6 RID: 143558 RVA: 0x0033D666 File Offset: 0x0033B866
		public static UNavigationPath FindLongPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindLongPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr));
		}

		// Token: 0x060230C7 RID: 143559 RVA: 0x0033D69B File Offset: 0x0033B89B
		public static bool DestroyStreamingDungeonNavSystem(UWorld WorldOwner)
		{
			return UNavigationSystemV1.__DestroyStreamingDungeonNavSystem_Internal((WorldOwner != null) ? WorldOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230C8 RID: 143560 RVA: 0x0033D6B4 File Offset: 0x0033B8B4
		public unsafe static bool D_NavigationGetWaterSurface(UObject WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), float WaterBottomTolerance = 150f)
		{
			fixed (float* ptr = &WaterTop)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__D_NavigationGetWaterSurface_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Pos, Extend, ref WaterTop, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, WaterBottomTolerance);
			}
		}

		// Token: 0x060230C9 RID: 143561 RVA: 0x0033D6FC File Offset: 0x0033B8FC
		public unsafe static bool D_NavigationGetWaterDeep(UObject WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, ref float WaterBottom, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (float* ptr = &WaterTop)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &WaterBottom)
				{
					void* ptr4 = (void*)ptr3;
					return UNavigationSystemV1.__D_NavigationGetWaterDeep_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Pos, Extend, ref WaterTop, ref WaterBottom, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
				}
			}
		}

		// Token: 0x060230CA RID: 143562 RVA: 0x0033D748 File Offset: 0x0033B948
		public unsafe static bool D_K2_ProjectPointToNavigation(UObject WorldContextObject, in FVectorDouble Point, ref FVectorDouble ProjectedLocation, ANavigationData NavData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass, FVectorDouble QueryExtent = default(FVectorDouble), double MaxError = -1.0)
		{
			fixed (FVectorDouble* ptr = &ProjectedLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__D_K2_ProjectPointToNavigation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, ref ProjectedLocation, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent, MaxError);
			}
		}

		// Token: 0x060230CB RID: 143563 RVA: 0x0033D78C File Offset: 0x0033B98C
		public unsafe static bool D_K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject, in FVectorDouble Origin, ref FVectorDouble RandomLocation, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			fixed (FVectorDouble* ptr = &RandomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__D_K2_GetRandomLocationInNavigableRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, ref RandomLocation, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
			}
		}

		// Token: 0x060230CC RID: 143564 RVA: 0x0033D7D0 File Offset: 0x0033B9D0
		public static bool D_K2_BatchProjectPointToNavigation(UObject WorldContextObject, in TArray<FVectorDouble> Points, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNavBatchProjectionResult> ProjectedLocationsResults, ANavigationData NavData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass, FVectorDouble QueryExtent = default(FVectorDouble), double MaxError = -1.0)
		{
			return UNavigationSystemV1.__D_K2_BatchProjectPointToNavigation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Points ?? new TArray<FVectorDouble>()).NativePtr, (ProjectedLocationsResults ?? new TArray<FNavBatchProjectionResult>()).NativePtr, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent, MaxError);
		}

		// Token: 0x060230CD RID: 143565 RVA: 0x0033D82D File Offset: 0x0033BA2D
		public static bool D_IsStraightReachable(UObject WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), in FVectorDouble FinderHalfExtent = null)
		{
			return UNavigationSystemV1.__D_IsStraightReachable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, FinderHalfExtent);
		}

		// Token: 0x060230CE RID: 143566 RVA: 0x0033D860 File Offset: 0x0033BA60
		public unsafe static bool D_GetNearestPolyAreaID(UObject WorldContextObject, in FVectorDouble Point, FVectorDouble QueryExtent, ref int AreaID, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), ANavigationData NavData = null, UObject Querier = null)
		{
			fixed (int* ptr = &AreaID)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__D_GetNearestPolyAreaID_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, QueryExtent, ref AreaID, FilterClass._NativePtr, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, (Querier != null) ? Querier.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x060230CF RID: 143567 RVA: 0x0033D8B5 File Offset: 0x0033BAB5
		public static UNavigationPath D_FindPathToLocationSynchronously(UObject WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bReturnPartial = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__D_FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, bReturnPartial));
		}

		// Token: 0x060230D0 RID: 143568 RVA: 0x0033D8EC File Offset: 0x0033BAEC
		public static bool CreateAndUseStreamingDungeonNavSystem(UWorld WPWorld, UWorld DungeonWorld, UNavigationSystemConfig NavigationSystemConfig)
		{
			return UNavigationSystemV1.__CreateAndUseStreamingDungeonNavSystem_Internal((WPWorld != null) ? WPWorld.NativePtr : IntPtr.Zero, (DungeonWorld != null) ? DungeonWorld.NativePtr : IntPtr.Zero, (NavigationSystemConfig != null) ? NavigationSystemConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060230D1 RID: 143569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterNavigationInvoker_Internal(IntPtr @this, IntPtr Invoker);

		// Token: 0x060230D2 RID: 143570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToLocation_Internal(IntPtr Controller, in FVector Goal);

		// Token: 0x060230D3 RID: 143571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToActor_Internal(IntPtr Controller, IntPtr Goal);

		// Token: 0x060230D4 RID: 143572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxSimultaneousTileGenerationJobsCount_Internal(IntPtr @this, int MaxNumberOfJobs);

		// Token: 0x060230D5 RID: 143573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGeometryGatheringMode_Internal(IntPtr @this, ENavDataGatheringModeConfig NewMode);

		// Token: 0x060230D6 RID: 143574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameLoadingFlag_Internal(IntPtr WorldContextObject, bool bIsLoading);

		// Token: 0x060230D7 RID: 143575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMaxSimultaneousTileGenerationJobsCount_Internal(IntPtr @this);

		// Token: 0x060230D8 RID: 143576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterNavigationInvoker_Internal(IntPtr @this, IntPtr Invoker, float TileGenerationRadius, float TileRemovalRadius);

		// Token: 0x060230D9 RID: 143577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVector Point, IntPtr NavData, IntPtr FilterClass, FVector QueryExtent);

		// Token: 0x060230DA RID: 143578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNavigationBoundsUpdated_Internal(IntPtr @this, IntPtr NavVolume);

		// Token: 0x060230DB RID: 143579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NavigationRaycast_Internal(IntPtr WorldContextObject, in FVector RayStart, in FVector RayEnd, ref FVector HitLocation, IntPtr FilterClass, IntPtr Querier);

		// Token: 0x060230DC RID: 143580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NavigationGetWaterDeep_Internal(IntPtr WorldContextObject, in FVector Pos, in FVector Extend, ref float WaterTop, ref float WaterBottom, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x060230DD RID: 143581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ReplaceAreaInOctreeData_Internal(IntPtr @this, IntPtr Object, IntPtr OldArea, IntPtr NewArea);

		// Token: 0x060230DE RID: 143582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVector Point, ref FVector ProjectedLocation, IntPtr NavData, IntPtr FilterClass, FVector QueryExtent, float MaxError);

		// Token: 0x060230DF RID: 143583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ProjectPointMulti_Internal(IntPtr WorldContextObject, in FVectorDouble Point, IntPtr ProjectedLocations, double MinZ, double MaxZ, IntPtr NavData, IntPtr FilterClass, FVectorDouble QueryExtent);

		// Token: 0x060230E0 RID: 143584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomReachablePointInRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230E1 RID: 143585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomPointInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230E2 RID: 143586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomLocationInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230E3 RID: 143587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStraightReachable_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, in FVector FinderHalfExtent);

		// Token: 0x060230E4 RID: 143588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationBeingBuiltOrLocked_Internal(IntPtr WorldContextObject);

		// Token: 0x060230E5 RID: 143589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationBeingBuilt_Internal(IntPtr WorldContextObject);

		// Token: 0x060230E6 RID: 143590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelInstanceNavDataEnabled_Internal(IntPtr @this);

		// Token: 0x060230E7 RID: 143591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGameLoading_Internal(IntPtr WorldContextObject);

		// Token: 0x060230E8 RID: 143592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ImportNavPartitionTilesForVisualization_Internal(IntPtr WorldContextObject);

		// Token: 0x060230E9 RID: 143593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldInitDone_Internal(IntPtr @this);

		// Token: 0x060230EA RID: 143594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWaterRegionInfoBelowLocation_Internal(IntPtr @this, in FVector Location, IntPtr OutWaterBodyIds, ref FVector OutWaterBottomLocation, float QueryDownDistance);

		// Token: 0x060230EB RID: 143595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWaterDepthAtLocation_Internal(IntPtr @this, in FVector Location, ref float OutWaterDepth, ref float OutWaterBottomDepth, float QueryDownDistance);

		// Token: 0x060230EC RID: 143596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRandomReachablePointInRadius_Internal(IntPtr WorldContextObject, in FVector Origin, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230ED RID: 143597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRandomPointInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230EE RID: 143598
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ENavigationQueryResult> __GetPathLength_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, ref float PathLength, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230EF RID: 143599
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ENavigationQueryResult> __GetPathCost_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, ref float PathCost, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230F0 RID: 143600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationSystem_Internal(IntPtr WorldContextObject);

		// Token: 0x060230F1 RID: 143601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, bool bReturnPartial);

		// Token: 0x060230F2 RID: 143602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPathToActorSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, IntPtr GoalActor, float TetherDistance, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x060230F3 RID: 143603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindLongPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x060230F4 RID: 143604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DestroyStreamingDungeonNavSystem_Internal(IntPtr WorldOwner);

		// Token: 0x060230F5 RID: 143605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_NavigationGetWaterSurface_Internal(IntPtr WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, IntPtr PathfindingContext, IntPtr FilterClass, float WaterBottomTolerance);

		// Token: 0x060230F6 RID: 143606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_NavigationGetWaterDeep_Internal(IntPtr WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, ref float WaterBottom, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x060230F7 RID: 143607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVectorDouble Point, ref FVectorDouble ProjectedLocation, IntPtr NavData, IntPtr FilterClass, FVectorDouble QueryExtent, double MaxError);

		// Token: 0x060230F8 RID: 143608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_GetRandomLocationInNavigableRadius_Internal(IntPtr WorldContextObject, in FVectorDouble Origin, ref FVectorDouble RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x060230F9 RID: 143609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_BatchProjectPointToNavigation_Internal(IntPtr WorldContextObject, IntPtr Points, IntPtr ProjectedLocationsResults, IntPtr NavData, IntPtr FilterClass, FVectorDouble QueryExtent, double MaxError);

		// Token: 0x060230FA RID: 143610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_IsStraightReachable_Internal(IntPtr WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, in FVectorDouble FinderHalfExtent);

		// Token: 0x060230FB RID: 143611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetNearestPolyAreaID_Internal(IntPtr WorldContextObject, in FVectorDouble Point, FVectorDouble QueryExtent, ref int AreaID, IntPtr FilterClass, IntPtr NavData, IntPtr Querier);

		// Token: 0x060230FC RID: 143612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, bool bReturnPartial);

		// Token: 0x060230FD RID: 143613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateAndUseStreamingDungeonNavSystem_Internal(IntPtr WPWorld, IntPtr DungeonWorld, IntPtr NavigationSystemConfig);

		// Token: 0x060230FE RID: 143614 RVA: 0x0033D923 File Offset: 0x0033BB23
		static UNavigationSystemV1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationSystemV1");
		}

		// Token: 0x060230FF RID: 143615 RVA: 0x0033D931 File Offset: 0x0033BB31
		protected UNavigationSystemV1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B38 RID: 76600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationSystemV1";

		// Token: 0x04012B39 RID: 76601
		private static IntPtr _ClassPtr;

		// Token: 0x04012B3A RID: 76602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B3B RID: 76603
		internal static int __PropertyOffset_MainNavData;

		// Token: 0x04012B3C RID: 76604
		internal static int __PropertyOffset_AbstractNavData;

		// Token: 0x04012B3D RID: 76605
		internal static int __PropertyOffset_DefaultAgentName;

		// Token: 0x04012B3E RID: 76606
		internal static int __PropertyOffset_WorldPartitionRecastFolder;

		// Token: 0x04012B3F RID: 76607
		internal static int __PropertyOffset_CrowdManagerClass;

		// Token: 0x04012B40 RID: 76608
		internal static int __PropertyOffset_bAutoCreateNavigationData;

		// Token: 0x04012B41 RID: 76609
		internal static byte __PropertyMask_bAutoCreateNavigationData;

		// Token: 0x04012B42 RID: 76610
		internal static int __PropertyOffset_bSpawnNavDataInNavBoundsLevel;

		// Token: 0x04012B43 RID: 76611
		internal static byte __PropertyMask_bSpawnNavDataInNavBoundsLevel;

		// Token: 0x04012B44 RID: 76612
		internal static int __PropertyOffset_bAllowClientSideNavigation;

		// Token: 0x04012B45 RID: 76613
		internal static byte __PropertyMask_bAllowClientSideNavigation;

		// Token: 0x04012B46 RID: 76614
		internal static int __PropertyOffset_bShouldDiscardSubLevelNavData;

		// Token: 0x04012B47 RID: 76615
		internal static byte __PropertyMask_bShouldDiscardSubLevelNavData;

		// Token: 0x04012B48 RID: 76616
		internal static int __PropertyOffset_bTickWhilePaused;

		// Token: 0x04012B49 RID: 76617
		internal static byte __PropertyMask_bTickWhilePaused;

		// Token: 0x04012B4A RID: 76618
		internal static int __PropertyOffset_bSupportRebuilding;

		// Token: 0x04012B4B RID: 76619
		internal static byte __PropertyMask_bSupportRebuilding;

		// Token: 0x04012B4C RID: 76620
		internal static int __PropertyOffset_bInitialBuildingLocked;

		// Token: 0x04012B4D RID: 76621
		internal static byte __PropertyMask_bInitialBuildingLocked;

		// Token: 0x04012B4E RID: 76622
		internal static int __PropertyOffset_bSkipAgentHeightCheckWhenPickingNavData;

		// Token: 0x04012B4F RID: 76623
		internal static byte __PropertyMask_bSkipAgentHeightCheckWhenPickingNavData;

		// Token: 0x04012B50 RID: 76624
		internal static int __PropertyOffset_bGenerateNavigationOnlyAroundNavigationInvokers;

		// Token: 0x04012B51 RID: 76625
		internal static byte __PropertyMask_bGenerateNavigationOnlyAroundNavigationInvokers;

		// Token: 0x04012B52 RID: 76626
		internal static int __PropertyOffset_ActiveTilesUpdateInterval;

		// Token: 0x04012B53 RID: 76627
		internal static int __PropertyOffset_DataGatheringMode;

		// Token: 0x04012B54 RID: 76628
		internal static int __PropertyOffset_DirtyAreaWarningSizeThreshold;

		// Token: 0x04012B55 RID: 76629
		internal static int __PropertyOffset_SupportedAgents;

		// Token: 0x04012B56 RID: 76630
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavDataConfig> _SupportedAgents;

		// Token: 0x04012B57 RID: 76631
		internal static int __PropertyOffset_SupportedAgentsMask;

		// Token: 0x04012B58 RID: 76632
		private FNavAgentSelector _SupportedAgentsMask;

		// Token: 0x04012B59 RID: 76633
		internal static int __PropertyOffset_bEnableNavMeshMultiPlatform;

		// Token: 0x04012B5A RID: 76634
		internal static byte __PropertyMask_bEnableNavMeshMultiPlatform;

		// Token: 0x04012B5B RID: 76635
		internal static int __PropertyOffset_BuildBounds;

		// Token: 0x04012B5C RID: 76636
		internal static int __PropertyOffset_NavDataSet;

		// Token: 0x04012B5D RID: 76637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANavigationData> _NavDataSet;

		// Token: 0x04012B5E RID: 76638
		internal static int __PropertyOffset_NavDataRegistrationQueue;

		// Token: 0x04012B5F RID: 76639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANavigationData> _NavDataRegistrationQueue;

		// Token: 0x04012B60 RID: 76640
		internal static int __PropertyOffset_OnNavDataRegisteredEvent;

		// Token: 0x04012B61 RID: 76641
		private FOnNavDataGenericEvent _OnNavDataRegisteredEvent;

		// Token: 0x04012B62 RID: 76642
		internal static int __PropertyOffset_OnNavigationGenerationFinishedDelegate;

		// Token: 0x04012B63 RID: 76643
		private FOnNavDataGenericEvent _OnNavigationGenerationFinishedDelegate;

		// Token: 0x04012B64 RID: 76644
		internal static int __PropertyOffset_OnCustomNavigationInitDone;

		// Token: 0x04012B65 RID: 76645
		private FOnCustomNavigationInitDone _OnCustomNavigationInitDone;

		// Token: 0x04012B66 RID: 76646
		internal static int __PropertyOffset_SystemTargetPlatform;

		// Token: 0x04012B67 RID: 76647
		internal static int __PropertyOffset_OperationMode;

		// Token: 0x04012B68 RID: 76648
		internal static int __PropertyOffset_DirtyAreasUpdateFreq;
	}
}
