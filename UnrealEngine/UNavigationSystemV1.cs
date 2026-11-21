using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079A RID: 1946
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationSystemV1")]
	[UnrealStructLayout(5904, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5904)]
	public class UNavigationSystemV1 : UNavigationSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A7DA RID: 42970 RVA: 0x000F7BDD File Offset: 0x000F5DDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemV1._ClassPtr;
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x000F7BEC File Offset: 0x000F5DEC
		public UNavigationSystemV1() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemV1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x000F7C14 File Offset: 0x000F5E14
		[NullableContext(1)]
		public UNavigationSystemV1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemV1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x000F7C47 File Offset: 0x000F5E47
		// (set) Token: 0x0600A7DE RID: 42974 RVA: 0x000F7C5B File Offset: 0x000F5E5B
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600A7DF RID: 42975 RVA: 0x000F7C70 File Offset: 0x000F5E70
		// (set) Token: 0x0600A7E0 RID: 42976 RVA: 0x000F7C84 File Offset: 0x000F5E84
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

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x000F7C99 File Offset: 0x000F5E99
		// (set) Token: 0x0600A7E2 RID: 42978 RVA: 0x000F7CAD File Offset: 0x000F5EAD
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

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x000F7CC2 File Offset: 0x000F5EC2
		// (set) Token: 0x0600A7E4 RID: 42980 RVA: 0x000F7CD6 File Offset: 0x000F5ED6
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

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x000F7CEB File Offset: 0x000F5EEB
		// (set) Token: 0x0600A7E6 RID: 42982 RVA: 0x000F7D04 File Offset: 0x000F5F04
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

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x000F7D34 File Offset: 0x000F5F34
		// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x000F7D4D File Offset: 0x000F5F4D
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

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x000F7D7D File Offset: 0x000F5F7D
		// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x000F7D96 File Offset: 0x000F5F96
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

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x000F7DC6 File Offset: 0x000F5FC6
		// (set) Token: 0x0600A7EC RID: 42988 RVA: 0x000F7DDF File Offset: 0x000F5FDF
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

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x000F7E0F File Offset: 0x000F600F
		// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x000F7E28 File Offset: 0x000F6028
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x000F7E58 File Offset: 0x000F6058
		// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x000F7E71 File Offset: 0x000F6071
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

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x000F7EA1 File Offset: 0x000F60A1
		// (set) Token: 0x0600A7F2 RID: 42994 RVA: 0x000F7EBA File Offset: 0x000F60BA
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

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600A7F3 RID: 42995 RVA: 0x000F7EEA File Offset: 0x000F60EA
		// (set) Token: 0x0600A7F4 RID: 42996 RVA: 0x000F7F03 File Offset: 0x000F6103
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

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600A7F5 RID: 42997 RVA: 0x000F7F33 File Offset: 0x000F6133
		// (set) Token: 0x0600A7F6 RID: 42998 RVA: 0x000F7F4C File Offset: 0x000F614C
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

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x000F7F7C File Offset: 0x000F617C
		// (set) Token: 0x0600A7F8 RID: 43000 RVA: 0x000F7F8C File Offset: 0x000F618C
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

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x000F7F9D File Offset: 0x000F619D
		// (set) Token: 0x0600A7FA RID: 43002 RVA: 0x000F7FAD File Offset: 0x000F61AD
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

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x000F7FBE File Offset: 0x000F61BE
		// (set) Token: 0x0600A7FC RID: 43004 RVA: 0x000F7FD7 File Offset: 0x000F61D7
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x000F8007 File Offset: 0x000F6207
		// (set) Token: 0x0600A7FE RID: 43006 RVA: 0x000F801B File Offset: 0x000F621B
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

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x000F8030 File Offset: 0x000F6230
		// (set) Token: 0x0600A800 RID: 43008 RVA: 0x000F8069 File Offset: 0x000F6269
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

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600A801 RID: 43009 RVA: 0x000F8078 File Offset: 0x000F6278
		// (set) Token: 0x0600A802 RID: 43010 RVA: 0x000F80B1 File Offset: 0x000F62B1
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600A803 RID: 43011 RVA: 0x000F80C0 File Offset: 0x000F62C0
		// (set) Token: 0x0600A804 RID: 43012 RVA: 0x000F80F9 File Offset: 0x000F62F9
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

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600A805 RID: 43013 RVA: 0x000F811C File Offset: 0x000F631C
		// (set) Token: 0x0600A806 RID: 43014 RVA: 0x000F8155 File Offset: 0x000F6355
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

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x0600A807 RID: 43015 RVA: 0x000F8178 File Offset: 0x000F6378
		// (set) Token: 0x0600A808 RID: 43016 RVA: 0x000F81B1 File Offset: 0x000F63B1
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

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x000F81D2 File Offset: 0x000F63D2
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x000F81E2 File Offset: 0x000F63E2
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

		// Token: 0x0600A80B RID: 43019 RVA: 0x000F81F3 File Offset: 0x000F63F3
		public void UnregisterNavigationInvoker(AActor Invoker)
		{
			UNavigationSystemV1.__UnregisterNavigationInvoker_Internal(base.NativePtr, (Invoker != null) ? Invoker.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x000F8210 File Offset: 0x000F6410
		public static void SimpleMoveToLocation(AController Controller, in FVector Goal)
		{
			UNavigationSystemV1.__SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x000F8228 File Offset: 0x000F6428
		public static void SimpleMoveToActor(AController Controller, AActor Goal)
		{
			UNavigationSystemV1.__SimpleMoveToActor_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Goal != null) ? Goal.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x000F824F File Offset: 0x000F644F
		public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
		{
			UNavigationSystemV1.__SetMaxSimultaneousTileGenerationJobsCount_Internal(base.NativePtr, MaxNumberOfJobs);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x000F825D File Offset: 0x000F645D
		public static void SetGameLoadingFlag(UObject WorldContextObject, bool bIsLoading)
		{
			UNavigationSystemV1.__SetGameLoadingFlag_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bIsLoading);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x000F8275 File Offset: 0x000F6475
		public void ResetMaxSimultaneousTileGenerationJobsCount()
		{
			UNavigationSystemV1.__ResetMaxSimultaneousTileGenerationJobsCount_Internal(base.NativePtr);
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x000F8282 File Offset: 0x000F6482
		public void RegisterNavigationInvoker(AActor Invoker, float TileGenerationRadius = 3000f, float TileRemovalRadius = 5000f)
		{
			UNavigationSystemV1.__RegisterNavigationInvoker_Internal(base.NativePtr, (Invoker != null) ? Invoker.NativePtr : IntPtr.Zero, TileGenerationRadius, TileRemovalRadius);
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x000F82A1 File Offset: 0x000F64A1
		public static FVector ProjectPointToNavigation(UObject WorldContextObject, in FVector Point, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), FVector QueryExtent = default(FVector))
		{
			return UNavigationSystemV1.__ProjectPointToNavigation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x000F82D4 File Offset: 0x000F64D4
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

		// Token: 0x0600A814 RID: 43028 RVA: 0x000F8318 File Offset: 0x000F6518
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

		// Token: 0x0600A815 RID: 43029 RVA: 0x000F8364 File Offset: 0x000F6564
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

		// Token: 0x0600A816 RID: 43030 RVA: 0x000F83A8 File Offset: 0x000F65A8
		public static bool K2_ProjectPointMulti(UObject WorldContextObject, in FVectorDouble Point, ref TArray<FVectorDouble> ProjectedLocations, double MinZ, double MaxZ, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), FVectorDouble QueryExtent = default(FVectorDouble))
		{
			return UNavigationSystemV1.__K2_ProjectPointMulti_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Point, (ProjectedLocations ?? new TArray<FVectorDouble>()).NativePtr, MinZ, MaxZ, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr, QueryExtent);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x000F83FC File Offset: 0x000F65FC
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

		// Token: 0x0600A818 RID: 43032 RVA: 0x000F8440 File Offset: 0x000F6640
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

		// Token: 0x0600A819 RID: 43033 RVA: 0x000F8484 File Offset: 0x000F6684
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

		// Token: 0x0600A81A RID: 43034 RVA: 0x000F84C7 File Offset: 0x000F66C7
		public static bool IsStraightReachable(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), in FVector FinderHalfExtent = null)
		{
			return UNavigationSystemV1.__IsStraightReachable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, FinderHalfExtent);
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x000F84F9 File Offset: 0x000F66F9
		public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsNavigationBeingBuiltOrLocked_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x000F8510 File Offset: 0x000F6710
		public static bool IsNavigationBeingBuilt(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsNavigationBeingBuilt_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A81D RID: 43037 RVA: 0x000F8527 File Offset: 0x000F6727
		public bool IsLevelInstanceNavDataEnabled()
		{
			return UNavigationSystemV1.__IsLevelInstanceNavDataEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600A81E RID: 43038 RVA: 0x000F8534 File Offset: 0x000F6734
		public static bool IsGameLoading(UObject WorldContextObject)
		{
			return UNavigationSystemV1.__IsGameLoading_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A81F RID: 43039 RVA: 0x000F854B File Offset: 0x000F674B
		public static void ImportNavPartitionTilesForVisualization(UObject WorldContextObject)
		{
			UNavigationSystemV1.__ImportNavPartitionTilesForVisualization_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A820 RID: 43040 RVA: 0x000F8562 File Offset: 0x000F6762
		public bool GetWorldInitDone()
		{
			return UNavigationSystemV1.__GetWorldInitDone_Internal(base.NativePtr);
		}

		// Token: 0x0600A821 RID: 43041 RVA: 0x000F8570 File Offset: 0x000F6770
		public unsafe bool GetWaterRegionInfoBelowLocation(in FVector Location, ref TArray<int> OutWaterBodyIds, ref FVector OutWaterBottomLocation, float QueryDownDistance = 5000f)
		{
			fixed (FVector* ptr = &OutWaterBottomLocation)
			{
				void* ptr2 = (void*)ptr;
				return UNavigationSystemV1.__GetWaterRegionInfoBelowLocation_Internal(base.NativePtr, Location, (OutWaterBodyIds ?? new TArray<int>()).NativePtr, ref OutWaterBottomLocation, QueryDownDistance);
			}
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x000F85A4 File Offset: 0x000F67A4
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

		// Token: 0x0600A823 RID: 43043 RVA: 0x000F85CB File Offset: 0x000F67CB
		public static FVector GetRandomReachablePointInRadius(UObject WorldContextObject, in FVector Origin, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return UNavigationSystemV1.__GetRandomReachablePointInRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x000F85FB File Offset: 0x000F67FB
		public static FVector GetRandomPointInNavigableRadius(UObject WorldContextObject, in FVector Origin, float Radius, ANavigationData NavData = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return UNavigationSystemV1.__GetRandomPointInNavigableRadius_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Origin, Radius, (NavData != null) ? NavData.NativePtr : IntPtr.Zero, FilterClass._NativePtr);
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x000F862B File Offset: 0x000F682B
		public static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationSystemV1>(UNavigationSystemV1.__GetNavigationSystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600A826 RID: 43046 RVA: 0x000F8647 File Offset: 0x000F6847
		public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bReturnPartial = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, bReturnPartial));
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x000F8680 File Offset: 0x000F6880
		public static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject, in FVector PathStart, AActor GoalActor, float TetherDistance = 50f, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindPathToActorSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, (GoalActor != null) ? GoalActor.NativePtr : IntPtr.Zero, TetherDistance, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr));
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x000F86D2 File Offset: 0x000F68D2
		public static UNavigationPath FindLongPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__FindLongPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr));
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x000F8707 File Offset: 0x000F6907
		public static bool DestroyStreamingDungeonNavSystem(UWorld WorldOwner)
		{
			return UNavigationSystemV1.__DestroyStreamingDungeonNavSystem_Internal((WorldOwner != null) ? WorldOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x000F8720 File Offset: 0x000F6920
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

		// Token: 0x0600A82B RID: 43051 RVA: 0x000F8768 File Offset: 0x000F6968
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

		// Token: 0x0600A82C RID: 43052 RVA: 0x000F87B4 File Offset: 0x000F69B4
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

		// Token: 0x0600A82D RID: 43053 RVA: 0x000F87F8 File Offset: 0x000F69F8
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

		// Token: 0x0600A82E RID: 43054 RVA: 0x000F883B File Offset: 0x000F6A3B
		public static bool D_IsStraightReachable(UObject WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), in FVectorDouble FinderHalfExtent = null)
		{
			return UNavigationSystemV1.__D_IsStraightReachable_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, FinderHalfExtent);
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x000F8870 File Offset: 0x000F6A70
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

		// Token: 0x0600A830 RID: 43056 RVA: 0x000F88C5 File Offset: 0x000F6AC5
		public static UNavigationPath D_FindPathToLocationSynchronously(UObject WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, AActor PathfindingContext = null, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bReturnPartial = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UNavigationSystemV1.__D_FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd, (PathfindingContext != null) ? PathfindingContext.NativePtr : IntPtr.Zero, FilterClass._NativePtr, bReturnPartial));
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x000F88FC File Offset: 0x000F6AFC
		public static bool CreateAndUseStreamingDungeonNavSystem(UWorld WPWorld, UWorld DungeonWorld, UNavigationSystemConfig NavigationSystemConfig)
		{
			return UNavigationSystemV1.__CreateAndUseStreamingDungeonNavSystem_Internal((WPWorld != null) ? WPWorld.NativePtr : IntPtr.Zero, (DungeonWorld != null) ? DungeonWorld.NativePtr : IntPtr.Zero, (NavigationSystemConfig != null) ? NavigationSystemConfig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A832 RID: 43058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterNavigationInvoker_Internal(IntPtr @this, IntPtr Invoker);

		// Token: 0x0600A833 RID: 43059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToLocation_Internal(IntPtr Controller, in FVector Goal);

		// Token: 0x0600A834 RID: 43060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToActor_Internal(IntPtr Controller, IntPtr Goal);

		// Token: 0x0600A835 RID: 43061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxSimultaneousTileGenerationJobsCount_Internal(IntPtr @this, int MaxNumberOfJobs);

		// Token: 0x0600A836 RID: 43062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameLoadingFlag_Internal(IntPtr WorldContextObject, bool bIsLoading);

		// Token: 0x0600A837 RID: 43063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMaxSimultaneousTileGenerationJobsCount_Internal(IntPtr @this);

		// Token: 0x0600A838 RID: 43064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterNavigationInvoker_Internal(IntPtr @this, IntPtr Invoker, float TileGenerationRadius, float TileRemovalRadius);

		// Token: 0x0600A839 RID: 43065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVector Point, IntPtr NavData, IntPtr FilterClass, FVector QueryExtent);

		// Token: 0x0600A83A RID: 43066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NavigationRaycast_Internal(IntPtr WorldContextObject, in FVector RayStart, in FVector RayEnd, ref FVector HitLocation, IntPtr FilterClass, IntPtr Querier);

		// Token: 0x0600A83B RID: 43067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NavigationGetWaterDeep_Internal(IntPtr WorldContextObject, in FVector Pos, in FVector Extend, ref float WaterTop, ref float WaterBottom, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x0600A83C RID: 43068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVector Point, ref FVector ProjectedLocation, IntPtr NavData, IntPtr FilterClass, FVector QueryExtent, float MaxError);

		// Token: 0x0600A83D RID: 43069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ProjectPointMulti_Internal(IntPtr WorldContextObject, in FVectorDouble Point, IntPtr ProjectedLocations, double MinZ, double MaxZ, IntPtr NavData, IntPtr FilterClass, FVectorDouble QueryExtent);

		// Token: 0x0600A83E RID: 43070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomReachablePointInRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A83F RID: 43071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomPointInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A840 RID: 43072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetRandomLocationInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, ref FVector RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A841 RID: 43073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStraightReachable_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, in FVector FinderHalfExtent);

		// Token: 0x0600A842 RID: 43074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationBeingBuiltOrLocked_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A843 RID: 43075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNavigationBeingBuilt_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A844 RID: 43076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelInstanceNavDataEnabled_Internal(IntPtr @this);

		// Token: 0x0600A845 RID: 43077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGameLoading_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A846 RID: 43078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ImportNavPartitionTilesForVisualization_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A847 RID: 43079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldInitDone_Internal(IntPtr @this);

		// Token: 0x0600A848 RID: 43080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWaterRegionInfoBelowLocation_Internal(IntPtr @this, in FVector Location, IntPtr OutWaterBodyIds, ref FVector OutWaterBottomLocation, float QueryDownDistance);

		// Token: 0x0600A849 RID: 43081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWaterDepthAtLocation_Internal(IntPtr @this, in FVector Location, ref float OutWaterDepth, ref float OutWaterBottomDepth, float QueryDownDistance);

		// Token: 0x0600A84A RID: 43082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRandomReachablePointInRadius_Internal(IntPtr WorldContextObject, in FVector Origin, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A84B RID: 43083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRandomPointInNavigableRadius_Internal(IntPtr WorldContextObject, in FVector Origin, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A84C RID: 43084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationSystem_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A84D RID: 43085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, bool bReturnPartial);

		// Token: 0x0600A84E RID: 43086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPathToActorSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, IntPtr GoalActor, float TetherDistance, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x0600A84F RID: 43087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindLongPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x0600A850 RID: 43088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DestroyStreamingDungeonNavSystem_Internal(IntPtr WorldOwner);

		// Token: 0x0600A851 RID: 43089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_NavigationGetWaterSurface_Internal(IntPtr WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, IntPtr PathfindingContext, IntPtr FilterClass, float WaterBottomTolerance);

		// Token: 0x0600A852 RID: 43090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_NavigationGetWaterDeep_Internal(IntPtr WorldContextObject, in FVectorDouble Pos, in FVectorDouble Extend, ref float WaterTop, ref float WaterBottom, IntPtr PathfindingContext, IntPtr FilterClass);

		// Token: 0x0600A853 RID: 43091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_ProjectPointToNavigation_Internal(IntPtr WorldContextObject, in FVectorDouble Point, ref FVectorDouble ProjectedLocation, IntPtr NavData, IntPtr FilterClass, FVectorDouble QueryExtent, double MaxError);

		// Token: 0x0600A854 RID: 43092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_GetRandomLocationInNavigableRadius_Internal(IntPtr WorldContextObject, in FVectorDouble Origin, ref FVectorDouble RandomLocation, float Radius, IntPtr NavData, IntPtr FilterClass);

		// Token: 0x0600A855 RID: 43093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_IsStraightReachable_Internal(IntPtr WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, in FVectorDouble FinderHalfExtent);

		// Token: 0x0600A856 RID: 43094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetNearestPolyAreaID_Internal(IntPtr WorldContextObject, in FVectorDouble Point, FVectorDouble QueryExtent, ref int AreaID, IntPtr FilterClass, IntPtr NavData, IntPtr Querier);

		// Token: 0x0600A857 RID: 43095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVectorDouble PathStart, in FVectorDouble PathEnd, IntPtr PathfindingContext, IntPtr FilterClass, bool bReturnPartial);

		// Token: 0x0600A858 RID: 43096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateAndUseStreamingDungeonNavSystem_Internal(IntPtr WPWorld, IntPtr DungeonWorld, IntPtr NavigationSystemConfig);

		// Token: 0x0600A859 RID: 43097 RVA: 0x000F8933 File Offset: 0x000F6B33
		static UNavigationSystemV1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationSystemV1");
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x000F8941 File Offset: 0x000F6B41
		protected UNavigationSystemV1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047F1 RID: 18417
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationSystemV1";

		// Token: 0x040047F2 RID: 18418
		private static IntPtr _ClassPtr;

		// Token: 0x040047F3 RID: 18419
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047F4 RID: 18420
		internal static int __PropertyOffset_MainNavData;

		// Token: 0x040047F5 RID: 18421
		internal static int __PropertyOffset_AbstractNavData;

		// Token: 0x040047F6 RID: 18422
		internal static int __PropertyOffset_DefaultAgentName;

		// Token: 0x040047F7 RID: 18423
		internal static int __PropertyOffset_WorldPartitionRecastFolder;

		// Token: 0x040047F8 RID: 18424
		internal static int __PropertyOffset_bAutoCreateNavigationData;

		// Token: 0x040047F9 RID: 18425
		internal static byte __PropertyMask_bAutoCreateNavigationData;

		// Token: 0x040047FA RID: 18426
		internal static int __PropertyOffset_bSpawnNavDataInNavBoundsLevel;

		// Token: 0x040047FB RID: 18427
		internal static byte __PropertyMask_bSpawnNavDataInNavBoundsLevel;

		// Token: 0x040047FC RID: 18428
		internal static int __PropertyOffset_bAllowClientSideNavigation;

		// Token: 0x040047FD RID: 18429
		internal static byte __PropertyMask_bAllowClientSideNavigation;

		// Token: 0x040047FE RID: 18430
		internal static int __PropertyOffset_bShouldDiscardSubLevelNavData;

		// Token: 0x040047FF RID: 18431
		internal static byte __PropertyMask_bShouldDiscardSubLevelNavData;

		// Token: 0x04004800 RID: 18432
		internal static int __PropertyOffset_bTickWhilePaused;

		// Token: 0x04004801 RID: 18433
		internal static byte __PropertyMask_bTickWhilePaused;

		// Token: 0x04004802 RID: 18434
		internal static int __PropertyOffset_bSupportRebuilding;

		// Token: 0x04004803 RID: 18435
		internal static byte __PropertyMask_bSupportRebuilding;

		// Token: 0x04004804 RID: 18436
		internal static int __PropertyOffset_bInitialBuildingLocked;

		// Token: 0x04004805 RID: 18437
		internal static byte __PropertyMask_bInitialBuildingLocked;

		// Token: 0x04004806 RID: 18438
		internal static int __PropertyOffset_bSkipAgentHeightCheckWhenPickingNavData;

		// Token: 0x04004807 RID: 18439
		internal static byte __PropertyMask_bSkipAgentHeightCheckWhenPickingNavData;

		// Token: 0x04004808 RID: 18440
		internal static int __PropertyOffset_bGenerateNavigationOnlyAroundNavigationInvokers;

		// Token: 0x04004809 RID: 18441
		internal static byte __PropertyMask_bGenerateNavigationOnlyAroundNavigationInvokers;

		// Token: 0x0400480A RID: 18442
		internal static int __PropertyOffset_ActiveTilesUpdateInterval;

		// Token: 0x0400480B RID: 18443
		internal static int __PropertyOffset_DirtyAreaWarningSizeThreshold;

		// Token: 0x0400480C RID: 18444
		internal static int __PropertyOffset_bEnableNavMeshMultiPlatform;

		// Token: 0x0400480D RID: 18445
		internal static byte __PropertyMask_bEnableNavMeshMultiPlatform;

		// Token: 0x0400480E RID: 18446
		internal static int __PropertyOffset_BuildBounds;

		// Token: 0x0400480F RID: 18447
		internal static int __PropertyOffset_NavDataSet;

		// Token: 0x04004810 RID: 18448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANavigationData> _NavDataSet;

		// Token: 0x04004811 RID: 18449
		internal static int __PropertyOffset_NavDataRegistrationQueue;

		// Token: 0x04004812 RID: 18450
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANavigationData> _NavDataRegistrationQueue;

		// Token: 0x04004813 RID: 18451
		internal static int __PropertyOffset_OnNavDataRegisteredEvent;

		// Token: 0x04004814 RID: 18452
		private FOnNavDataGenericEvent _OnNavDataRegisteredEvent;

		// Token: 0x04004815 RID: 18453
		internal static int __PropertyOffset_OnNavigationGenerationFinishedDelegate;

		// Token: 0x04004816 RID: 18454
		private FOnNavDataGenericEvent _OnNavigationGenerationFinishedDelegate;

		// Token: 0x04004817 RID: 18455
		internal static int __PropertyOffset_OnCustomNavigationInitDone;

		// Token: 0x04004818 RID: 18456
		private FOnCustomNavigationInitDone _OnCustomNavigationInitDone;

		// Token: 0x04004819 RID: 18457
		internal static int __PropertyOffset_DirtyAreasUpdateFreq;
	}
}
