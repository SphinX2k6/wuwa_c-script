using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001290 RID: 4752
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldSettings")]
	[UnrealStructLayout(4000, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4000)]
	public class AWorldSettings : AInfo, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06011699 RID: 71321 RVA: 0x00198F4C File Offset: 0x0019714C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldSettings._ClassPtr;
		}

		// Token: 0x0601169A RID: 71322 RVA: 0x00198F58 File Offset: 0x00197158
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return AWorldSettings.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x0601169B RID: 71323 RVA: 0x00198F60 File Offset: 0x00197160
		public AWorldSettings() : this(BuiltinUtils.AllocNativeUObject(AWorldSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601169C RID: 71324 RVA: 0x00198F88 File Offset: 0x00197188
		[NullableContext(1)]
		public AWorldSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x0601169D RID: 71325 RVA: 0x00198FBB File Offset: 0x001971BB
		// (set) Token: 0x0601169E RID: 71326 RVA: 0x00198FCB File Offset: 0x001971CB
		public unsafe int VisibilityCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_VisibilityCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_VisibilityCellSize) = value;
			}
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0601169F RID: 71327 RVA: 0x00198FDC File Offset: 0x001971DC
		// (set) Token: 0x060116A0 RID: 71328 RVA: 0x00198FF0 File Offset: 0x001971F0
		[Nullable(0)]
		public unsafe TEnumAsByte<EVisibilityAggressiveness> VisibilityAggressiveness
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_VisibilityAggressiveness);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_VisibilityAggressiveness) = value;
			}
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x060116A1 RID: 71329 RVA: 0x00199005 File Offset: 0x00197205
		// (set) Token: 0x060116A2 RID: 71330 RVA: 0x0019901E File Offset: 0x0019721E
		public unsafe bool bPrecomputeVisibility
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrecomputeVisibility) & AWorldSettings.__PropertyMask_bPrecomputeVisibility) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrecomputeVisibility) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrecomputeVisibility) & ~AWorldSettings.__PropertyMask_bPrecomputeVisibility) | (value ? AWorldSettings.__PropertyMask_bPrecomputeVisibility : 0));
			}
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x060116A3 RID: 71331 RVA: 0x0019904E File Offset: 0x0019724E
		// (set) Token: 0x060116A4 RID: 71332 RVA: 0x00199067 File Offset: 0x00197267
		public unsafe bool bPlaceCellsOnlyAlongCameraTracks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPlaceCellsOnlyAlongCameraTracks) & AWorldSettings.__PropertyMask_bPlaceCellsOnlyAlongCameraTracks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPlaceCellsOnlyAlongCameraTracks) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPlaceCellsOnlyAlongCameraTracks) & ~AWorldSettings.__PropertyMask_bPlaceCellsOnlyAlongCameraTracks) | (value ? AWorldSettings.__PropertyMask_bPlaceCellsOnlyAlongCameraTracks : 0));
			}
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x060116A5 RID: 71333 RVA: 0x00199097 File Offset: 0x00197297
		// (set) Token: 0x060116A6 RID: 71334 RVA: 0x001990B0 File Offset: 0x001972B0
		public unsafe bool bEnableWorldBoundsChecks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldBoundsChecks) & AWorldSettings.__PropertyMask_bEnableWorldBoundsChecks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldBoundsChecks) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldBoundsChecks) & ~AWorldSettings.__PropertyMask_bEnableWorldBoundsChecks) | (value ? AWorldSettings.__PropertyMask_bEnableWorldBoundsChecks : 0));
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x060116A7 RID: 71335 RVA: 0x001990E0 File Offset: 0x001972E0
		// (set) Token: 0x060116A8 RID: 71336 RVA: 0x001990F9 File Offset: 0x001972F9
		public unsafe bool bEnableNavigationSystem
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavigationSystem) & AWorldSettings.__PropertyMask_bEnableNavigationSystem) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavigationSystem) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavigationSystem) & ~AWorldSettings.__PropertyMask_bEnableNavigationSystem) | (value ? AWorldSettings.__PropertyMask_bEnableNavigationSystem : 0));
			}
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x060116A9 RID: 71337 RVA: 0x00199129 File Offset: 0x00197329
		// (set) Token: 0x060116AA RID: 71338 RVA: 0x00199142 File Offset: 0x00197342
		public unsafe bool bEnableAISystem
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableAISystem) & AWorldSettings.__PropertyMask_bEnableAISystem) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableAISystem) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableAISystem) & ~AWorldSettings.__PropertyMask_bEnableAISystem) | (value ? AWorldSettings.__PropertyMask_bEnableAISystem : 0));
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x060116AB RID: 71339 RVA: 0x00199172 File Offset: 0x00197372
		// (set) Token: 0x060116AC RID: 71340 RVA: 0x0019918B File Offset: 0x0019738B
		public unsafe bool bEnableWorldComposition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldComposition) & AWorldSettings.__PropertyMask_bEnableWorldComposition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldComposition) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldComposition) & ~AWorldSettings.__PropertyMask_bEnableWorldComposition) | (value ? AWorldSettings.__PropertyMask_bEnableWorldComposition : 0));
			}
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x060116AD RID: 71341 RVA: 0x001991BB File Offset: 0x001973BB
		// (set) Token: 0x060116AE RID: 71342 RVA: 0x001991D4 File Offset: 0x001973D4
		public unsafe bool bEnableWorldPartition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldPartition) & AWorldSettings.__PropertyMask_bEnableWorldPartition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldPartition) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldPartition) & ~AWorldSettings.__PropertyMask_bEnableWorldPartition) | (value ? AWorldSettings.__PropertyMask_bEnableWorldPartition : 0));
			}
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x060116AF RID: 71343 RVA: 0x00199204 File Offset: 0x00197404
		// (set) Token: 0x060116B0 RID: 71344 RVA: 0x0019921D File Offset: 0x0019741D
		public unsafe bool bTestWpMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bTestWpMap) & AWorldSettings.__PropertyMask_bTestWpMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bTestWpMap) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bTestWpMap) & ~AWorldSettings.__PropertyMask_bTestWpMap) | (value ? AWorldSettings.__PropertyMask_bTestWpMap : 0));
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x060116B1 RID: 71345 RVA: 0x0019924D File Offset: 0x0019744D
		// (set) Token: 0x060116B2 RID: 71346 RVA: 0x00199266 File Offset: 0x00197466
		public unsafe bool bDisableCookHLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bDisableCookHLOD) & AWorldSettings.__PropertyMask_bDisableCookHLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bDisableCookHLOD) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bDisableCookHLOD) & ~AWorldSettings.__PropertyMask_bDisableCookHLOD) | (value ? AWorldSettings.__PropertyMask_bDisableCookHLOD : 0));
			}
		}

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x060116B3 RID: 71347 RVA: 0x00199296 File Offset: 0x00197496
		// (set) Token: 0x060116B4 RID: 71348 RVA: 0x001992AF File Offset: 0x001974AF
		public unsafe bool bEnableNavPartition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavPartition) & AWorldSettings.__PropertyMask_bEnableNavPartition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavPartition) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavPartition) & ~AWorldSettings.__PropertyMask_bEnableNavPartition) | (value ? AWorldSettings.__PropertyMask_bEnableNavPartition : 0));
			}
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x060116B5 RID: 71349 RVA: 0x001992DF File Offset: 0x001974DF
		// (set) Token: 0x060116B6 RID: 71350 RVA: 0x001992F8 File Offset: 0x001974F8
		public unsafe bool bSupportLevelInstanceNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bSupportLevelInstanceNavData) & AWorldSettings.__PropertyMask_bSupportLevelInstanceNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bSupportLevelInstanceNavData) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bSupportLevelInstanceNavData) & ~AWorldSettings.__PropertyMask_bSupportLevelInstanceNavData) | (value ? AWorldSettings.__PropertyMask_bSupportLevelInstanceNavData : 0));
			}
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x060116B7 RID: 71351 RVA: 0x00199328 File Offset: 0x00197528
		// (set) Token: 0x060116B8 RID: 71352 RVA: 0x00199341 File Offset: 0x00197541
		public unsafe bool bApplyLevelInstancePivotOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bApplyLevelInstancePivotOffset) & AWorldSettings.__PropertyMask_bApplyLevelInstancePivotOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bApplyLevelInstancePivotOffset) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bApplyLevelInstancePivotOffset) & ~AWorldSettings.__PropertyMask_bApplyLevelInstancePivotOffset) | (value ? AWorldSettings.__PropertyMask_bApplyLevelInstancePivotOffset : 0));
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x060116B9 RID: 71353 RVA: 0x00199371 File Offset: 0x00197571
		// (set) Token: 0x060116BA RID: 71354 RVA: 0x00199385 File Offset: 0x00197585
		public unsafe FVector LevelInstancePivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_LevelInstancePivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_LevelInstancePivotOffset) = value;
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x060116BB RID: 71355 RVA: 0x0019939A File Offset: 0x0019759A
		// (set) Token: 0x060116BC RID: 71356 RVA: 0x001993B3 File Offset: 0x001975B3
		public unsafe bool bUseClientSideLevelStreamingVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUseClientSideLevelStreamingVolumes) & AWorldSettings.__PropertyMask_bUseClientSideLevelStreamingVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUseClientSideLevelStreamingVolumes) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUseClientSideLevelStreamingVolumes) & ~AWorldSettings.__PropertyMask_bUseClientSideLevelStreamingVolumes) | (value ? AWorldSettings.__PropertyMask_bUseClientSideLevelStreamingVolumes : 0));
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x060116BD RID: 71357 RVA: 0x001993E3 File Offset: 0x001975E3
		// (set) Token: 0x060116BE RID: 71358 RVA: 0x001993FC File Offset: 0x001975FC
		public unsafe bool bEnableWorldOriginRebasing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldOriginRebasing) & AWorldSettings.__PropertyMask_bEnableWorldOriginRebasing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldOriginRebasing) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableWorldOriginRebasing) & ~AWorldSettings.__PropertyMask_bEnableWorldOriginRebasing) | (value ? AWorldSettings.__PropertyMask_bEnableWorldOriginRebasing : 0));
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x060116BF RID: 71359 RVA: 0x0019942C File Offset: 0x0019762C
		// (set) Token: 0x060116C0 RID: 71360 RVA: 0x00199445 File Offset: 0x00197645
		public unsafe bool bWorldGravitySet
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bWorldGravitySet) & AWorldSettings.__PropertyMask_bWorldGravitySet) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bWorldGravitySet) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bWorldGravitySet) & ~AWorldSettings.__PropertyMask_bWorldGravitySet) | (value ? AWorldSettings.__PropertyMask_bWorldGravitySet : 0));
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x060116C1 RID: 71361 RVA: 0x00199475 File Offset: 0x00197675
		// (set) Token: 0x060116C2 RID: 71362 RVA: 0x0019948E File Offset: 0x0019768E
		public unsafe bool bGlobalGravitySet
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bGlobalGravitySet) & AWorldSettings.__PropertyMask_bGlobalGravitySet) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bGlobalGravitySet) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bGlobalGravitySet) & ~AWorldSettings.__PropertyMask_bGlobalGravitySet) | (value ? AWorldSettings.__PropertyMask_bGlobalGravitySet : 0));
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x060116C3 RID: 71363 RVA: 0x001994BE File Offset: 0x001976BE
		// (set) Token: 0x060116C4 RID: 71364 RVA: 0x001994D7 File Offset: 0x001976D7
		public unsafe bool bMinimizeBSPSections
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bMinimizeBSPSections) & AWorldSettings.__PropertyMask_bMinimizeBSPSections) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bMinimizeBSPSections) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bMinimizeBSPSections) & ~AWorldSettings.__PropertyMask_bMinimizeBSPSections) | (value ? AWorldSettings.__PropertyMask_bMinimizeBSPSections : 0));
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x060116C5 RID: 71365 RVA: 0x00199507 File Offset: 0x00197707
		// (set) Token: 0x060116C6 RID: 71366 RVA: 0x00199520 File Offset: 0x00197720
		public unsafe bool bForceNoPrecomputedLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bForceNoPrecomputedLighting) & AWorldSettings.__PropertyMask_bForceNoPrecomputedLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bForceNoPrecomputedLighting) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bForceNoPrecomputedLighting) & ~AWorldSettings.__PropertyMask_bForceNoPrecomputedLighting) | (value ? AWorldSettings.__PropertyMask_bForceNoPrecomputedLighting : 0));
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x060116C7 RID: 71367 RVA: 0x00199550 File Offset: 0x00197750
		// (set) Token: 0x060116C8 RID: 71368 RVA: 0x00199569 File Offset: 0x00197769
		public unsafe bool bHighPriorityLoading
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoading) & AWorldSettings.__PropertyMask_bHighPriorityLoading) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoading) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoading) & ~AWorldSettings.__PropertyMask_bHighPriorityLoading) | (value ? AWorldSettings.__PropertyMask_bHighPriorityLoading : 0));
			}
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x060116C9 RID: 71369 RVA: 0x00199599 File Offset: 0x00197799
		// (set) Token: 0x060116CA RID: 71370 RVA: 0x001995B2 File Offset: 0x001977B2
		public unsafe bool bHighPriorityLoadingLocal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoadingLocal) & AWorldSettings.__PropertyMask_bHighPriorityLoadingLocal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoadingLocal) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bHighPriorityLoadingLocal) & ~AWorldSettings.__PropertyMask_bHighPriorityLoadingLocal) | (value ? AWorldSettings.__PropertyMask_bHighPriorityLoadingLocal : 0));
			}
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x060116CB RID: 71371 RVA: 0x001995E2 File Offset: 0x001977E2
		// (set) Token: 0x060116CC RID: 71372 RVA: 0x001995FB File Offset: 0x001977FB
		public unsafe bool bOverrideDefaultBroadphaseSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bOverrideDefaultBroadphaseSettings) & AWorldSettings.__PropertyMask_bOverrideDefaultBroadphaseSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bOverrideDefaultBroadphaseSettings) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bOverrideDefaultBroadphaseSettings) & ~AWorldSettings.__PropertyMask_bOverrideDefaultBroadphaseSettings) | (value ? AWorldSettings.__PropertyMask_bOverrideDefaultBroadphaseSettings : 0));
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x060116CD RID: 71373 RVA: 0x0019962B File Offset: 0x0019782B
		// (set) Token: 0x060116CE RID: 71374 RVA: 0x0019963F File Offset: 0x0019783F
		public unsafe UNavigationSystemConfig NavigationSystemConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_NavigationSystemConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_NavigationSystemConfig, value);
			}
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x060116CF RID: 71375 RVA: 0x00199654 File Offset: 0x00197854
		// (set) Token: 0x060116D0 RID: 71376 RVA: 0x00199668 File Offset: 0x00197868
		public unsafe UNavigationSystemConfig NavigationSystemConfigOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_NavigationSystemConfigOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_NavigationSystemConfigOverride, value);
			}
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x060116D1 RID: 71377 RVA: 0x0019967D File Offset: 0x0019787D
		// (set) Token: 0x060116D2 RID: 71378 RVA: 0x00199691 File Offset: 0x00197891
		public unsafe UWorldPartition WorldPartition
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartition>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_WorldPartition);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_WorldPartition, value);
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x060116D3 RID: 71379 RVA: 0x001996A6 File Offset: 0x001978A6
		// (set) Token: 0x060116D4 RID: 71380 RVA: 0x001996B6 File Offset: 0x001978B6
		public unsafe uint InstancedFoliageGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_InstancedFoliageGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_InstancedFoliageGridSize) = (int)value;
			}
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x060116D5 RID: 71381 RVA: 0x001996C7 File Offset: 0x001978C7
		// (set) Token: 0x060116D6 RID: 71382 RVA: 0x001996D7 File Offset: 0x001978D7
		public unsafe float WorldToMeters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_WorldToMeters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_WorldToMeters) = value;
			}
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x060116D7 RID: 71383 RVA: 0x001996E8 File Offset: 0x001978E8
		// (set) Token: 0x060116D8 RID: 71384 RVA: 0x001996F8 File Offset: 0x001978F8
		public unsafe float KillZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KillZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KillZ) = value;
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x060116D9 RID: 71385 RVA: 0x00199709 File Offset: 0x00197909
		// (set) Token: 0x060116DA RID: 71386 RVA: 0x0019971D File Offset: 0x0019791D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UDamageType> KillZDamageType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KillZDamageType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KillZDamageType) = value;
			}
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x060116DB RID: 71387 RVA: 0x00199732 File Offset: 0x00197932
		// (set) Token: 0x060116DC RID: 71388 RVA: 0x00199742 File Offset: 0x00197942
		public unsafe float WorldGravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_WorldGravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_WorldGravityZ) = value;
			}
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x060116DD RID: 71389 RVA: 0x00199753 File Offset: 0x00197953
		// (set) Token: 0x060116DE RID: 71390 RVA: 0x00199763 File Offset: 0x00197963
		public unsafe float GlobalGravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GlobalGravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GlobalGravityZ) = value;
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x060116DF RID: 71391 RVA: 0x00199774 File Offset: 0x00197974
		// (set) Token: 0x060116E0 RID: 71392 RVA: 0x00199788 File Offset: 0x00197988
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ADefaultPhysicsVolume> DefaultPhysicsVolumeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultPhysicsVolumeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultPhysicsVolumeClass) = value;
			}
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x060116E1 RID: 71393 RVA: 0x0019979D File Offset: 0x0019799D
		// (set) Token: 0x060116E2 RID: 71394 RVA: 0x001997B1 File Offset: 0x001979B1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UPhysicsCollisionHandler> PhysicsCollisionHandlerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PhysicsCollisionHandlerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PhysicsCollisionHandlerClass) = value;
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x060116E3 RID: 71395 RVA: 0x001997C6 File Offset: 0x001979C6
		// (set) Token: 0x060116E4 RID: 71396 RVA: 0x001997DA File Offset: 0x001979DA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameModeBase> DefaultGameMode
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultGameMode);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultGameMode) = value;
			}
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x060116E5 RID: 71397 RVA: 0x001997EF File Offset: 0x001979EF
		// (set) Token: 0x060116E6 RID: 71398 RVA: 0x00199803 File Offset: 0x00197A03
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameNetworkManager> GameNetworkManagerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GameNetworkManagerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GameNetworkManagerClass) = value;
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x060116E7 RID: 71399 RVA: 0x00199818 File Offset: 0x00197A18
		// (set) Token: 0x060116E8 RID: 71400 RVA: 0x00199828 File Offset: 0x00197A28
		public unsafe int PackedLightAndShadowMapTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PackedLightAndShadowMapTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PackedLightAndShadowMapTextureSize) = value;
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x060116E9 RID: 71401 RVA: 0x00199839 File Offset: 0x00197A39
		// (set) Token: 0x060116EA RID: 71402 RVA: 0x0019984D File Offset: 0x00197A4D
		public unsafe FVector DefaultColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultColorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultColorScale) = value;
			}
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x060116EB RID: 71403 RVA: 0x00199862 File Offset: 0x00197A62
		// (set) Token: 0x060116EC RID: 71404 RVA: 0x00199872 File Offset: 0x00197A72
		public unsafe float DefaultMaxDistanceFieldOcclusionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultMaxDistanceFieldOcclusionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultMaxDistanceFieldOcclusionDistance) = value;
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x060116ED RID: 71405 RVA: 0x00199883 File Offset: 0x00197A83
		// (set) Token: 0x060116EE RID: 71406 RVA: 0x00199893 File Offset: 0x00197A93
		public unsafe float GlobalDistanceFieldViewDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GlobalDistanceFieldViewDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_GlobalDistanceFieldViewDistance) = value;
			}
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x060116EF RID: 71407 RVA: 0x001998A4 File Offset: 0x00197AA4
		// (set) Token: 0x060116F0 RID: 71408 RVA: 0x001998B4 File Offset: 0x00197AB4
		public unsafe float DynamicIndirectShadowsSelfShadowingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DynamicIndirectShadowsSelfShadowingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DynamicIndirectShadowsSelfShadowingIntensity) = value;
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x060116F1 RID: 71409 RVA: 0x001998C5 File Offset: 0x00197AC5
		// (set) Token: 0x060116F2 RID: 71410 RVA: 0x001998DE File Offset: 0x00197ADE
		public unsafe bool bUpdateStaticMeshVertexBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUpdateStaticMeshVertexBounds) & AWorldSettings.__PropertyMask_bUpdateStaticMeshVertexBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUpdateStaticMeshVertexBounds) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bUpdateStaticMeshVertexBounds) & ~AWorldSettings.__PropertyMask_bUpdateStaticMeshVertexBounds) | (value ? AWorldSettings.__PropertyMask_bUpdateStaticMeshVertexBounds : 0));
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x060116F3 RID: 71411 RVA: 0x0019990E File Offset: 0x00197B0E
		// (set) Token: 0x060116F4 RID: 71412 RVA: 0x00199927 File Offset: 0x00197B27
		public unsafe bool bPrtEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrtEnabled) & AWorldSettings.__PropertyMask_bPrtEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrtEnabled) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bPrtEnabled) & ~AWorldSettings.__PropertyMask_bPrtEnabled) | (value ? AWorldSettings.__PropertyMask_bPrtEnabled : 0));
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x060116F5 RID: 71413 RVA: 0x00199957 File Offset: 0x00197B57
		// (set) Token: 0x060116F6 RID: 71414 RVA: 0x0019996B File Offset: 0x00197B6B
		[Nullable(0)]
		public unsafe TEnumAsByte<EPrtMethod> PrtMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PrtMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PrtMethod) = value;
			}
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x060116F7 RID: 71415 RVA: 0x00199980 File Offset: 0x00197B80
		// (set) Token: 0x060116F8 RID: 71416 RVA: 0x00199990 File Offset: 0x00197B90
		public unsafe float PrtLQBakedAOScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PrtLQBakedAOScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_PrtLQBakedAOScale) = value;
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x060116F9 RID: 71417 RVA: 0x001999A1 File Offset: 0x00197BA1
		// (set) Token: 0x060116FA RID: 71418 RVA: 0x001999BA File Offset: 0x00197BBA
		public unsafe bool bClvEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvEnabled) & AWorldSettings.__PropertyMask_bClvEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvEnabled) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvEnabled) & ~AWorldSettings.__PropertyMask_bClvEnabled) | (value ? AWorldSettings.__PropertyMask_bClvEnabled : 0));
			}
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x060116FB RID: 71419 RVA: 0x001999EA File Offset: 0x00197BEA
		// (set) Token: 0x060116FC RID: 71420 RVA: 0x00199A03 File Offset: 0x00197C03
		public unsafe bool bClvHasInteriorVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvHasInteriorVolume) & AWorldSettings.__PropertyMask_bClvHasInteriorVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvHasInteriorVolume) = ((*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bClvHasInteriorVolume) & ~AWorldSettings.__PropertyMask_bClvHasInteriorVolume) | (value ? AWorldSettings.__PropertyMask_bClvHasInteriorVolume : 0));
			}
		}

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x060116FD RID: 71421 RVA: 0x00199A33 File Offset: 0x00197C33
		// (set) Token: 0x060116FE RID: 71422 RVA: 0x00199A47 File Offset: 0x00197C47
		[Nullable(0)]
		public unsafe TEnumAsByte<EOlvMethod> OlvMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_OlvMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_OlvMethod) = value;
			}
		}

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x060116FF RID: 71423 RVA: 0x00199A5C File Offset: 0x00197C5C
		// (set) Token: 0x06011700 RID: 71424 RVA: 0x00199A95 File Offset: 0x00197C95
		[Nullable(1)]
		public FReverbSettings DefaultReverbSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FReverbSettings result;
				if ((result = this._DefaultReverbSettings) == null)
				{
					result = (this._DefaultReverbSettings = new FReverbSettings(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultReverbSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReverbSettings.StaticStruct(), base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultReverbSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x06011701 RID: 71425 RVA: 0x00199AB8 File Offset: 0x00197CB8
		// (set) Token: 0x06011702 RID: 71426 RVA: 0x00199AF1 File Offset: 0x00197CF1
		[Nullable(1)]
		public FInteriorSettings DefaultAmbientZoneSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInteriorSettings result;
				if ((result = this._DefaultAmbientZoneSettings) == null)
				{
					result = (this._DefaultAmbientZoneSettings = new FInteriorSettings(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultAmbientZoneSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInteriorSettings.StaticStruct(), base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultAmbientZoneSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x06011703 RID: 71427 RVA: 0x00199B12 File Offset: 0x00197D12
		// (set) Token: 0x06011704 RID: 71428 RVA: 0x00199B22 File Offset: 0x00197D22
		public unsafe float MonoCullingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MonoCullingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MonoCullingDistance) = value;
			}
		}

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x06011705 RID: 71429 RVA: 0x00199B33 File Offset: 0x00197D33
		// (set) Token: 0x06011706 RID: 71430 RVA: 0x00199B47 File Offset: 0x00197D47
		public unsafe USoundMix DefaultBaseSoundMix
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundMix>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_DefaultBaseSoundMix);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_DefaultBaseSoundMix, value);
			}
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x06011707 RID: 71431 RVA: 0x00199B5C File Offset: 0x00197D5C
		// (set) Token: 0x06011708 RID: 71432 RVA: 0x00199B6C File Offset: 0x00197D6C
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x06011709 RID: 71433 RVA: 0x00199B7D File Offset: 0x00197D7D
		// (set) Token: 0x0601170A RID: 71434 RVA: 0x00199B8D File Offset: 0x00197D8D
		public unsafe float MatineeTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MatineeTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MatineeTimeDilation) = value;
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x0601170B RID: 71435 RVA: 0x00199B9E File Offset: 0x00197D9E
		// (set) Token: 0x0601170C RID: 71436 RVA: 0x00199BAE File Offset: 0x00197DAE
		public unsafe float DemoPlayTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DemoPlayTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DemoPlayTimeDilation) = value;
			}
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x0601170D RID: 71437 RVA: 0x00199BBF File Offset: 0x00197DBF
		// (set) Token: 0x0601170E RID: 71438 RVA: 0x00199BCF File Offset: 0x00197DCF
		public unsafe float MinGlobalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MinGlobalTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MinGlobalTimeDilation) = value;
			}
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x0601170F RID: 71439 RVA: 0x00199BE0 File Offset: 0x00197DE0
		// (set) Token: 0x06011710 RID: 71440 RVA: 0x00199BF0 File Offset: 0x00197DF0
		public unsafe float MaxGlobalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxGlobalTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxGlobalTimeDilation) = value;
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x06011711 RID: 71441 RVA: 0x00199C01 File Offset: 0x00197E01
		// (set) Token: 0x06011712 RID: 71442 RVA: 0x00199C11 File Offset: 0x00197E11
		public unsafe float MinUndilatedFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MinUndilatedFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MinUndilatedFrameTime) = value;
			}
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x06011713 RID: 71443 RVA: 0x00199C22 File Offset: 0x00197E22
		// (set) Token: 0x06011714 RID: 71444 RVA: 0x00199C32 File Offset: 0x00197E32
		public unsafe float MaxUndilatedFrameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxUndilatedFrameTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxUndilatedFrameTime) = value;
			}
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x06011715 RID: 71445 RVA: 0x00199C44 File Offset: 0x00197E44
		// (set) Token: 0x06011716 RID: 71446 RVA: 0x00199C7D File Offset: 0x00197E7D
		[Nullable(1)]
		public FBroadphaseSettings BroadphaseSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBroadphaseSettings result;
				if ((result = this._BroadphaseSettings) == null)
				{
					result = (this._BroadphaseSettings = new FBroadphaseSettings(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_BroadphaseSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBroadphaseSettings.StaticStruct(), base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_BroadphaseSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x06011717 RID: 71447 RVA: 0x00199C9E File Offset: 0x00197E9E
		// (set) Token: 0x06011718 RID: 71448 RVA: 0x00199CB2 File Offset: 0x00197EB2
		public unsafe APlayerState Pauser
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_Pauser);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_Pauser, value);
			}
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x06011719 RID: 71449 RVA: 0x00199CC8 File Offset: 0x00197EC8
		// (set) Token: 0x0601171A RID: 71450 RVA: 0x00199D01 File Offset: 0x00197F01
		[Nullable(1)]
		public TArray<FNetViewer> ReplicationViewers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNetViewer> result;
				if ((result = this._ReplicationViewers) == null)
				{
					result = (this._ReplicationViewers = new TArray<FNetViewer>(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_ReplicationViewers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ReplicationViewers.CopyAssign(value);
			}
		}

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x0601171B RID: 71451 RVA: 0x00199D0F File Offset: 0x00197F0F
		// (set) Token: 0x0601171C RID: 71452 RVA: 0x00199D1F File Offset: 0x00197F1F
		public unsafe bool bEnableUE5NavigationPartitionSystem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableUE5NavigationPartitionSystem) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableUE5NavigationPartitionSystem) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x0601171D RID: 71453 RVA: 0x00199D30 File Offset: 0x00197F30
		// (set) Token: 0x0601171E RID: 71454 RVA: 0x00199D40 File Offset: 0x00197F40
		public unsafe bool bEnableNavMeshTileVariants
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavMeshTileVariants) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bEnableNavMeshTileVariants) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x0601171F RID: 71455 RVA: 0x00199D51 File Offset: 0x00197F51
		// (set) Token: 0x06011720 RID: 71456 RVA: 0x00199D61 File Offset: 0x00197F61
		public unsafe uint NavigationDataChunkGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_NavigationDataChunkGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_NavigationDataChunkGridSize) = (int)value;
			}
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x06011721 RID: 71457 RVA: 0x00199D72 File Offset: 0x00197F72
		// (set) Token: 0x06011722 RID: 71458 RVA: 0x00199D82 File Offset: 0x00197F82
		public unsafe uint NavigationDataBuilderLoadingCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_NavigationDataBuilderLoadingCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_NavigationDataBuilderLoadingCellSize) = (int)value;
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x06011723 RID: 71459 RVA: 0x00199D94 File Offset: 0x00197F94
		// (set) Token: 0x06011724 RID: 71460 RVA: 0x00199DCD File Offset: 0x00197FCD
		[Nullable(1)]
		public TArray<UAssetUserData> AssetUserData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x06011725 RID: 71461 RVA: 0x00199DDB File Offset: 0x00197FDB
		// (set) Token: 0x06011726 RID: 71462 RVA: 0x00199DEF File Offset: 0x00197FEF
		public unsafe APlayerState PauserPlayerState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_PauserPlayerState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldSettings.__PropertyOffset_PauserPlayerState, value);
			}
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x06011727 RID: 71463 RVA: 0x00199E04 File Offset: 0x00198004
		// (set) Token: 0x06011728 RID: 71464 RVA: 0x00199E14 File Offset: 0x00198014
		public unsafe int MaxNumberOfBookmarks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxNumberOfBookmarks);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_MaxNumberOfBookmarks) = value;
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x06011729 RID: 71465 RVA: 0x00199E25 File Offset: 0x00198025
		// (set) Token: 0x0601172A RID: 71466 RVA: 0x00199E39 File Offset: 0x00198039
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UBookmarkBase> DefaultBookmarkClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultBookmarkClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_DefaultBookmarkClass) = value;
			}
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x0601172B RID: 71467 RVA: 0x00199E50 File Offset: 0x00198050
		// (set) Token: 0x0601172C RID: 71468 RVA: 0x00199E89 File Offset: 0x00198089
		[Nullable(1)]
		public TArray<UBookmarkBase> BookmarkArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBookmarkBase> result;
				if ((result = this._BookmarkArray) == null)
				{
					result = (this._BookmarkArray = new TArray<UBookmarkBase>(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_BookmarkArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BookmarkArray.CopyAssign(value);
			}
		}

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x0601172D RID: 71469 RVA: 0x00199E97 File Offset: 0x00198097
		// (set) Token: 0x0601172E RID: 71470 RVA: 0x00199EAB File Offset: 0x001980AB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UBookmarkBase> LastBookmarkClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_LastBookmarkClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_LastBookmarkClass) = value;
			}
		}

		// Token: 0x0601172F RID: 71471 RVA: 0x00199EC0 File Offset: 0x001980C0
		public void OnRep_WorldGravityZ()
		{
			AWorldSettings.__OnRep_WorldGravityZ_Internal(base.NativePtr);
		}

		// Token: 0x06011730 RID: 71472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_WorldGravityZ_Internal(IntPtr @this);

		// Token: 0x06011731 RID: 71473 RVA: 0x00199ECD File Offset: 0x001980CD
		static AWorldSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldSettings");
		}

		// Token: 0x06011732 RID: 71474 RVA: 0x00199EDB File Offset: 0x001980DB
		protected AWorldSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400950C RID: 38156
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x0400950D RID: 38157
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldSettings";

		// Token: 0x0400950E RID: 38158
		private static IntPtr _ClassPtr;

		// Token: 0x0400950F RID: 38159
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009510 RID: 38160
		internal static int __PropertyOffset_VisibilityCellSize;

		// Token: 0x04009511 RID: 38161
		internal static int __PropertyOffset_VisibilityAggressiveness;

		// Token: 0x04009512 RID: 38162
		internal static int __PropertyOffset_bPrecomputeVisibility;

		// Token: 0x04009513 RID: 38163
		internal static byte __PropertyMask_bPrecomputeVisibility;

		// Token: 0x04009514 RID: 38164
		internal static int __PropertyOffset_bPlaceCellsOnlyAlongCameraTracks;

		// Token: 0x04009515 RID: 38165
		internal static byte __PropertyMask_bPlaceCellsOnlyAlongCameraTracks;

		// Token: 0x04009516 RID: 38166
		internal static int __PropertyOffset_bEnableWorldBoundsChecks;

		// Token: 0x04009517 RID: 38167
		internal static byte __PropertyMask_bEnableWorldBoundsChecks;

		// Token: 0x04009518 RID: 38168
		internal static int __PropertyOffset_bEnableNavigationSystem;

		// Token: 0x04009519 RID: 38169
		internal static byte __PropertyMask_bEnableNavigationSystem;

		// Token: 0x0400951A RID: 38170
		internal static int __PropertyOffset_bEnableAISystem;

		// Token: 0x0400951B RID: 38171
		internal static byte __PropertyMask_bEnableAISystem;

		// Token: 0x0400951C RID: 38172
		internal static int __PropertyOffset_bEnableWorldComposition;

		// Token: 0x0400951D RID: 38173
		internal static byte __PropertyMask_bEnableWorldComposition;

		// Token: 0x0400951E RID: 38174
		internal static int __PropertyOffset_bEnableWorldPartition;

		// Token: 0x0400951F RID: 38175
		internal static byte __PropertyMask_bEnableWorldPartition;

		// Token: 0x04009520 RID: 38176
		internal static int __PropertyOffset_bTestWpMap;

		// Token: 0x04009521 RID: 38177
		internal static byte __PropertyMask_bTestWpMap;

		// Token: 0x04009522 RID: 38178
		internal static int __PropertyOffset_bDisableCookHLOD;

		// Token: 0x04009523 RID: 38179
		internal static byte __PropertyMask_bDisableCookHLOD;

		// Token: 0x04009524 RID: 38180
		internal static int __PropertyOffset_bEnableNavPartition;

		// Token: 0x04009525 RID: 38181
		internal static byte __PropertyMask_bEnableNavPartition;

		// Token: 0x04009526 RID: 38182
		internal static int __PropertyOffset_bSupportLevelInstanceNavData;

		// Token: 0x04009527 RID: 38183
		internal static byte __PropertyMask_bSupportLevelInstanceNavData;

		// Token: 0x04009528 RID: 38184
		internal static int __PropertyOffset_bApplyLevelInstancePivotOffset;

		// Token: 0x04009529 RID: 38185
		internal static byte __PropertyMask_bApplyLevelInstancePivotOffset;

		// Token: 0x0400952A RID: 38186
		internal static int __PropertyOffset_LevelInstancePivotOffset;

		// Token: 0x0400952B RID: 38187
		internal static int __PropertyOffset_bUseClientSideLevelStreamingVolumes;

		// Token: 0x0400952C RID: 38188
		internal static byte __PropertyMask_bUseClientSideLevelStreamingVolumes;

		// Token: 0x0400952D RID: 38189
		internal static int __PropertyOffset_bEnableWorldOriginRebasing;

		// Token: 0x0400952E RID: 38190
		internal static byte __PropertyMask_bEnableWorldOriginRebasing;

		// Token: 0x0400952F RID: 38191
		internal static int __PropertyOffset_bWorldGravitySet;

		// Token: 0x04009530 RID: 38192
		internal static byte __PropertyMask_bWorldGravitySet;

		// Token: 0x04009531 RID: 38193
		internal static int __PropertyOffset_bGlobalGravitySet;

		// Token: 0x04009532 RID: 38194
		internal static byte __PropertyMask_bGlobalGravitySet;

		// Token: 0x04009533 RID: 38195
		internal static int __PropertyOffset_bMinimizeBSPSections;

		// Token: 0x04009534 RID: 38196
		internal static byte __PropertyMask_bMinimizeBSPSections;

		// Token: 0x04009535 RID: 38197
		internal static int __PropertyOffset_bForceNoPrecomputedLighting;

		// Token: 0x04009536 RID: 38198
		internal static byte __PropertyMask_bForceNoPrecomputedLighting;

		// Token: 0x04009537 RID: 38199
		internal static int __PropertyOffset_bHighPriorityLoading;

		// Token: 0x04009538 RID: 38200
		internal static byte __PropertyMask_bHighPriorityLoading;

		// Token: 0x04009539 RID: 38201
		internal static int __PropertyOffset_bHighPriorityLoadingLocal;

		// Token: 0x0400953A RID: 38202
		internal static byte __PropertyMask_bHighPriorityLoadingLocal;

		// Token: 0x0400953B RID: 38203
		internal static int __PropertyOffset_bOverrideDefaultBroadphaseSettings;

		// Token: 0x0400953C RID: 38204
		internal static byte __PropertyMask_bOverrideDefaultBroadphaseSettings;

		// Token: 0x0400953D RID: 38205
		internal static int __PropertyOffset_NavigationSystemConfig;

		// Token: 0x0400953E RID: 38206
		internal static int __PropertyOffset_NavigationSystemConfigOverride;

		// Token: 0x0400953F RID: 38207
		internal static int __PropertyOffset_WorldPartition;

		// Token: 0x04009540 RID: 38208
		internal static int __PropertyOffset_InstancedFoliageGridSize;

		// Token: 0x04009541 RID: 38209
		internal static int __PropertyOffset_WorldToMeters;

		// Token: 0x04009542 RID: 38210
		internal static int __PropertyOffset_KillZ;

		// Token: 0x04009543 RID: 38211
		internal static int __PropertyOffset_KillZDamageType;

		// Token: 0x04009544 RID: 38212
		internal static int __PropertyOffset_WorldGravityZ;

		// Token: 0x04009545 RID: 38213
		internal static int __PropertyOffset_GlobalGravityZ;

		// Token: 0x04009546 RID: 38214
		internal static int __PropertyOffset_DefaultPhysicsVolumeClass;

		// Token: 0x04009547 RID: 38215
		internal static int __PropertyOffset_PhysicsCollisionHandlerClass;

		// Token: 0x04009548 RID: 38216
		internal static int __PropertyOffset_DefaultGameMode;

		// Token: 0x04009549 RID: 38217
		internal static int __PropertyOffset_GameNetworkManagerClass;

		// Token: 0x0400954A RID: 38218
		internal static int __PropertyOffset_PackedLightAndShadowMapTextureSize;

		// Token: 0x0400954B RID: 38219
		internal static int __PropertyOffset_DefaultColorScale;

		// Token: 0x0400954C RID: 38220
		internal static int __PropertyOffset_DefaultMaxDistanceFieldOcclusionDistance;

		// Token: 0x0400954D RID: 38221
		internal static int __PropertyOffset_GlobalDistanceFieldViewDistance;

		// Token: 0x0400954E RID: 38222
		internal static int __PropertyOffset_DynamicIndirectShadowsSelfShadowingIntensity;

		// Token: 0x0400954F RID: 38223
		internal static int __PropertyOffset_bUpdateStaticMeshVertexBounds;

		// Token: 0x04009550 RID: 38224
		internal static byte __PropertyMask_bUpdateStaticMeshVertexBounds;

		// Token: 0x04009551 RID: 38225
		internal static int __PropertyOffset_bPrtEnabled;

		// Token: 0x04009552 RID: 38226
		internal static byte __PropertyMask_bPrtEnabled;

		// Token: 0x04009553 RID: 38227
		internal static int __PropertyOffset_PrtMethod;

		// Token: 0x04009554 RID: 38228
		internal static int __PropertyOffset_PrtLQBakedAOScale;

		// Token: 0x04009555 RID: 38229
		internal static int __PropertyOffset_bClvEnabled;

		// Token: 0x04009556 RID: 38230
		internal static byte __PropertyMask_bClvEnabled;

		// Token: 0x04009557 RID: 38231
		internal static int __PropertyOffset_bClvHasInteriorVolume;

		// Token: 0x04009558 RID: 38232
		internal static byte __PropertyMask_bClvHasInteriorVolume;

		// Token: 0x04009559 RID: 38233
		internal static int __PropertyOffset_OlvMethod;

		// Token: 0x0400955A RID: 38234
		internal static int __PropertyOffset_DefaultReverbSettings;

		// Token: 0x0400955B RID: 38235
		private FReverbSettings _DefaultReverbSettings;

		// Token: 0x0400955C RID: 38236
		internal static int __PropertyOffset_DefaultAmbientZoneSettings;

		// Token: 0x0400955D RID: 38237
		private FInteriorSettings _DefaultAmbientZoneSettings;

		// Token: 0x0400955E RID: 38238
		internal static int __PropertyOffset_MonoCullingDistance;

		// Token: 0x0400955F RID: 38239
		internal static int __PropertyOffset_DefaultBaseSoundMix;

		// Token: 0x04009560 RID: 38240
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04009561 RID: 38241
		internal static int __PropertyOffset_MatineeTimeDilation;

		// Token: 0x04009562 RID: 38242
		internal static int __PropertyOffset_DemoPlayTimeDilation;

		// Token: 0x04009563 RID: 38243
		internal static int __PropertyOffset_MinGlobalTimeDilation;

		// Token: 0x04009564 RID: 38244
		internal static int __PropertyOffset_MaxGlobalTimeDilation;

		// Token: 0x04009565 RID: 38245
		internal static int __PropertyOffset_MinUndilatedFrameTime;

		// Token: 0x04009566 RID: 38246
		internal static int __PropertyOffset_MaxUndilatedFrameTime;

		// Token: 0x04009567 RID: 38247
		internal static int __PropertyOffset_BroadphaseSettings;

		// Token: 0x04009568 RID: 38248
		private FBroadphaseSettings _BroadphaseSettings;

		// Token: 0x04009569 RID: 38249
		internal static int __PropertyOffset_Pauser;

		// Token: 0x0400956A RID: 38250
		internal static int __PropertyOffset_ReplicationViewers;

		// Token: 0x0400956B RID: 38251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNetViewer> _ReplicationViewers;

		// Token: 0x0400956C RID: 38252
		internal static int __PropertyOffset_bEnableUE5NavigationPartitionSystem;

		// Token: 0x0400956D RID: 38253
		internal static int __PropertyOffset_bEnableNavMeshTileVariants;

		// Token: 0x0400956E RID: 38254
		internal static int __PropertyOffset_NavigationDataChunkGridSize;

		// Token: 0x0400956F RID: 38255
		internal static int __PropertyOffset_NavigationDataBuilderLoadingCellSize;

		// Token: 0x04009570 RID: 38256
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04009571 RID: 38257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x04009572 RID: 38258
		internal static int __PropertyOffset_PauserPlayerState;

		// Token: 0x04009573 RID: 38259
		internal static int __PropertyOffset_MaxNumberOfBookmarks;

		// Token: 0x04009574 RID: 38260
		internal static int __PropertyOffset_DefaultBookmarkClass;

		// Token: 0x04009575 RID: 38261
		internal static int __PropertyOffset_BookmarkArray;

		// Token: 0x04009576 RID: 38262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBookmarkBase> _BookmarkArray;

		// Token: 0x04009577 RID: 38263
		internal static int __PropertyOffset_LastBookmarkClass;
	}
}
