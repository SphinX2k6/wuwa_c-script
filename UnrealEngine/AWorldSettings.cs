using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B6 RID: 694
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldSettings")]
	[UnrealStructLayout(4080, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4080)]
	public class AWorldSettings : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004B09 RID: 19209 RVA: 0x00068FA1 File Offset: 0x000671A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldSettings._ClassPtr;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00068FB0 File Offset: 0x000671B0
		public AWorldSettings() : this(BuiltinUtils.AllocNativeUObject(AWorldSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00068FD8 File Offset: 0x000671D8
		[NullableContext(1)]
		public AWorldSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x0006900B File Offset: 0x0006720B
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x0006901B File Offset: 0x0006721B
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0006902C File Offset: 0x0006722C
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00069045 File Offset: 0x00067245
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x00069075 File Offset: 0x00067275
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x0006908E File Offset: 0x0006728E
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

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x000690BE File Offset: 0x000672BE
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x000690D7 File Offset: 0x000672D7
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

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x00069107 File Offset: 0x00067307
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x00069120 File Offset: 0x00067320
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

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x00069150 File Offset: 0x00067350
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x00069169 File Offset: 0x00067369
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x00069199 File Offset: 0x00067399
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x000691B2 File Offset: 0x000673B2
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

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x000691E2 File Offset: 0x000673E2
		// (set) Token: 0x06004B1B RID: 19227 RVA: 0x000691FB File Offset: 0x000673FB
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

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x0006922B File Offset: 0x0006742B
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x00069244 File Offset: 0x00067444
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

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x00069274 File Offset: 0x00067474
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x0006928D File Offset: 0x0006748D
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x000692BD File Offset: 0x000674BD
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x000692D6 File Offset: 0x000674D6
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x00069306 File Offset: 0x00067506
		// (set) Token: 0x06004B23 RID: 19235 RVA: 0x0006931F File Offset: 0x0006751F
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

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x0006934F File Offset: 0x0006754F
		// (set) Token: 0x06004B25 RID: 19237 RVA: 0x00069368 File Offset: 0x00067568
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x00069398 File Offset: 0x00067598
		// (set) Token: 0x06004B27 RID: 19239 RVA: 0x000693AC File Offset: 0x000675AC
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x000693C1 File Offset: 0x000675C1
		// (set) Token: 0x06004B29 RID: 19241 RVA: 0x000693DA File Offset: 0x000675DA
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

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x0006940A File Offset: 0x0006760A
		// (set) Token: 0x06004B2B RID: 19243 RVA: 0x00069423 File Offset: 0x00067623
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004B2C RID: 19244 RVA: 0x00069453 File Offset: 0x00067653
		// (set) Token: 0x06004B2D RID: 19245 RVA: 0x0006946C File Offset: 0x0006766C
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

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x0006949C File Offset: 0x0006769C
		// (set) Token: 0x06004B2F RID: 19247 RVA: 0x000694B5 File Offset: 0x000676B5
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

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x000694E5 File Offset: 0x000676E5
		// (set) Token: 0x06004B31 RID: 19249 RVA: 0x000694FE File Offset: 0x000676FE
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

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004B32 RID: 19250 RVA: 0x0006952E File Offset: 0x0006772E
		// (set) Token: 0x06004B33 RID: 19251 RVA: 0x00069547 File Offset: 0x00067747
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

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x00069577 File Offset: 0x00067777
		// (set) Token: 0x06004B35 RID: 19253 RVA: 0x00069590 File Offset: 0x00067790
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

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x000695C0 File Offset: 0x000677C0
		// (set) Token: 0x06004B37 RID: 19255 RVA: 0x000695D9 File Offset: 0x000677D9
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

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x00069609 File Offset: 0x00067809
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x00069622 File Offset: 0x00067822
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

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x00069652 File Offset: 0x00067852
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x00069666 File Offset: 0x00067866
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

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x0006967B File Offset: 0x0006787B
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x0006968F File Offset: 0x0006788F
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x000696A4 File Offset: 0x000678A4
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x000696B4 File Offset: 0x000678B4
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x000696C5 File Offset: 0x000678C5
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x000696D5 File Offset: 0x000678D5
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

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x000696E6 File Offset: 0x000678E6
		// (set) Token: 0x06004B43 RID: 19267 RVA: 0x000696F6 File Offset: 0x000678F6
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

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x00069707 File Offset: 0x00067907
		// (set) Token: 0x06004B45 RID: 19269 RVA: 0x00069717 File Offset: 0x00067917
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x00069728 File Offset: 0x00067928
		// (set) Token: 0x06004B47 RID: 19271 RVA: 0x00069738 File Offset: 0x00067938
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

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x00069749 File Offset: 0x00067949
		// (set) Token: 0x06004B49 RID: 19273 RVA: 0x0006975D File Offset: 0x0006795D
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

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x00069772 File Offset: 0x00067972
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x00069782 File Offset: 0x00067982
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

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x00069793 File Offset: 0x00067993
		// (set) Token: 0x06004B4D RID: 19277 RVA: 0x000697A7 File Offset: 0x000679A7
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

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x000697BC File Offset: 0x000679BC
		// (set) Token: 0x06004B4F RID: 19279 RVA: 0x000697CC File Offset: 0x000679CC
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

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x000697DD File Offset: 0x000679DD
		// (set) Token: 0x06004B51 RID: 19281 RVA: 0x000697ED File Offset: 0x000679ED
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x000697FE File Offset: 0x000679FE
		// (set) Token: 0x06004B53 RID: 19283 RVA: 0x0006980E File Offset: 0x00067A0E
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

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x0006981F File Offset: 0x00067A1F
		// (set) Token: 0x06004B55 RID: 19285 RVA: 0x0006982F File Offset: 0x00067A2F
		public unsafe float KuroPlanarReflectionMaxScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMaxScreenPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMaxScreenPercentage) = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x00069840 File Offset: 0x00067A40
		// (set) Token: 0x06004B57 RID: 19287 RVA: 0x00069850 File Offset: 0x00067A50
		public unsafe float KuroPlanarReflectionMinCaptureInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMinCaptureInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMinCaptureInterval) = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x00069861 File Offset: 0x00067A61
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x00069871 File Offset: 0x00067A71
		public unsafe int KuroPlanarReflectionMaxCapturesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMaxCapturesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMaxCapturesPerFrame) = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x00069882 File Offset: 0x00067A82
		// (set) Token: 0x06004B5B RID: 19291 RVA: 0x00069892 File Offset: 0x00067A92
		public unsafe float KuroPlanarReflectionMinActiveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMinActiveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionMinActiveTime) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x000698A3 File Offset: 0x00067AA3
		// (set) Token: 0x06004B5D RID: 19293 RVA: 0x000698B3 File Offset: 0x00067AB3
		public unsafe float KuroPlanarReflectionSwitchAreaRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionSwitchAreaRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionSwitchAreaRatio) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x000698C4 File Offset: 0x00067AC4
		// (set) Token: 0x06004B5F RID: 19295 RVA: 0x000698D4 File Offset: 0x00067AD4
		public unsafe bool bKuroPlanarReflectionDynamicResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bKuroPlanarReflectionDynamicResolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_bKuroPlanarReflectionDynamicResolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x000698E5 File Offset: 0x00067AE5
		// (set) Token: 0x06004B61 RID: 19297 RVA: 0x000698F5 File Offset: 0x00067AF5
		public unsafe float KuroPlanarReflectionDynamicResolutionMaxScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionDynamicResolutionMaxScreenPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldSettings.__PropertyOffset_KuroPlanarReflectionDynamicResolutionMaxScreenPercentage) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x00069906 File Offset: 0x00067B06
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x0006991F File Offset: 0x00067B1F
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

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x0006994F File Offset: 0x00067B4F
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x00069968 File Offset: 0x00067B68
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x00069998 File Offset: 0x00067B98
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x000699A8 File Offset: 0x00067BA8
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

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x000699B9 File Offset: 0x00067BB9
		// (set) Token: 0x06004B69 RID: 19305 RVA: 0x000699D2 File Offset: 0x00067BD2
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x00069A02 File Offset: 0x00067C02
		// (set) Token: 0x06004B6B RID: 19307 RVA: 0x00069A1B File Offset: 0x00067C1B
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

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x00069A4B File Offset: 0x00067C4B
		// (set) Token: 0x06004B6D RID: 19309 RVA: 0x00069A5B File Offset: 0x00067C5B
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

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x00069A6C File Offset: 0x00067C6C
		// (set) Token: 0x06004B6F RID: 19311 RVA: 0x00069A7C File Offset: 0x00067C7C
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

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x00069A8D File Offset: 0x00067C8D
		// (set) Token: 0x06004B71 RID: 19313 RVA: 0x00069A9D File Offset: 0x00067C9D
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

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x00069AAE File Offset: 0x00067CAE
		// (set) Token: 0x06004B73 RID: 19315 RVA: 0x00069ABE File Offset: 0x00067CBE
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

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x00069ACF File Offset: 0x00067CCF
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x00069ADF File Offset: 0x00067CDF
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

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x00069AF0 File Offset: 0x00067CF0
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x00069B00 File Offset: 0x00067D00
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

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x00069B11 File Offset: 0x00067D11
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x00069B21 File Offset: 0x00067D21
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x00069B32 File Offset: 0x00067D32
		// (set) Token: 0x06004B7B RID: 19323 RVA: 0x00069B42 File Offset: 0x00067D42
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

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x00069B53 File Offset: 0x00067D53
		// (set) Token: 0x06004B7D RID: 19325 RVA: 0x00069B63 File Offset: 0x00067D63
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

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x00069B74 File Offset: 0x00067D74
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x00069B84 File Offset: 0x00067D84
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

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x00069B95 File Offset: 0x00067D95
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x00069BA5 File Offset: 0x00067DA5
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

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x00069BB6 File Offset: 0x00067DB6
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x00069BC6 File Offset: 0x00067DC6
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

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06004B84 RID: 19332 RVA: 0x00069BD7 File Offset: 0x00067DD7
		// (set) Token: 0x06004B85 RID: 19333 RVA: 0x00069BE7 File Offset: 0x00067DE7
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

		// Token: 0x06004B86 RID: 19334 RVA: 0x00069BF8 File Offset: 0x00067DF8
		public void OnRep_WorldGravityZ()
		{
			AWorldSettings.__OnRep_WorldGravityZ_Internal(base.NativePtr);
		}

		// Token: 0x06004B87 RID: 19335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_WorldGravityZ_Internal(IntPtr @this);

		// Token: 0x06004B88 RID: 19336 RVA: 0x00069C05 File Offset: 0x00067E05
		static AWorldSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldSettings");
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00069C13 File Offset: 0x00067E13
		protected AWorldSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D99 RID: 7577
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldSettings";

		// Token: 0x04001D9A RID: 7578
		private static IntPtr _ClassPtr;

		// Token: 0x04001D9B RID: 7579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D9C RID: 7580
		internal static int __PropertyOffset_VisibilityCellSize;

		// Token: 0x04001D9D RID: 7581
		internal static int __PropertyOffset_bPrecomputeVisibility;

		// Token: 0x04001D9E RID: 7582
		internal static byte __PropertyMask_bPrecomputeVisibility;

		// Token: 0x04001D9F RID: 7583
		internal static int __PropertyOffset_bPlaceCellsOnlyAlongCameraTracks;

		// Token: 0x04001DA0 RID: 7584
		internal static byte __PropertyMask_bPlaceCellsOnlyAlongCameraTracks;

		// Token: 0x04001DA1 RID: 7585
		internal static int __PropertyOffset_bEnableWorldBoundsChecks;

		// Token: 0x04001DA2 RID: 7586
		internal static byte __PropertyMask_bEnableWorldBoundsChecks;

		// Token: 0x04001DA3 RID: 7587
		internal static int __PropertyOffset_bEnableNavigationSystem;

		// Token: 0x04001DA4 RID: 7588
		internal static byte __PropertyMask_bEnableNavigationSystem;

		// Token: 0x04001DA5 RID: 7589
		internal static int __PropertyOffset_bEnableAISystem;

		// Token: 0x04001DA6 RID: 7590
		internal static byte __PropertyMask_bEnableAISystem;

		// Token: 0x04001DA7 RID: 7591
		internal static int __PropertyOffset_bEnableWorldComposition;

		// Token: 0x04001DA8 RID: 7592
		internal static byte __PropertyMask_bEnableWorldComposition;

		// Token: 0x04001DA9 RID: 7593
		internal static int __PropertyOffset_bEnableWorldPartition;

		// Token: 0x04001DAA RID: 7594
		internal static byte __PropertyMask_bEnableWorldPartition;

		// Token: 0x04001DAB RID: 7595
		internal static int __PropertyOffset_bTestWpMap;

		// Token: 0x04001DAC RID: 7596
		internal static byte __PropertyMask_bTestWpMap;

		// Token: 0x04001DAD RID: 7597
		internal static int __PropertyOffset_bDisableCookHLOD;

		// Token: 0x04001DAE RID: 7598
		internal static byte __PropertyMask_bDisableCookHLOD;

		// Token: 0x04001DAF RID: 7599
		internal static int __PropertyOffset_bEnableNavPartition;

		// Token: 0x04001DB0 RID: 7600
		internal static byte __PropertyMask_bEnableNavPartition;

		// Token: 0x04001DB1 RID: 7601
		internal static int __PropertyOffset_bSupportLevelInstanceNavData;

		// Token: 0x04001DB2 RID: 7602
		internal static byte __PropertyMask_bSupportLevelInstanceNavData;

		// Token: 0x04001DB3 RID: 7603
		internal static int __PropertyOffset_bApplyLevelInstancePivotOffset;

		// Token: 0x04001DB4 RID: 7604
		internal static byte __PropertyMask_bApplyLevelInstancePivotOffset;

		// Token: 0x04001DB5 RID: 7605
		internal static int __PropertyOffset_LevelInstancePivotOffset;

		// Token: 0x04001DB6 RID: 7606
		internal static int __PropertyOffset_bUseClientSideLevelStreamingVolumes;

		// Token: 0x04001DB7 RID: 7607
		internal static byte __PropertyMask_bUseClientSideLevelStreamingVolumes;

		// Token: 0x04001DB8 RID: 7608
		internal static int __PropertyOffset_bEnableWorldOriginRebasing;

		// Token: 0x04001DB9 RID: 7609
		internal static byte __PropertyMask_bEnableWorldOriginRebasing;

		// Token: 0x04001DBA RID: 7610
		internal static int __PropertyOffset_bWorldGravitySet;

		// Token: 0x04001DBB RID: 7611
		internal static byte __PropertyMask_bWorldGravitySet;

		// Token: 0x04001DBC RID: 7612
		internal static int __PropertyOffset_bGlobalGravitySet;

		// Token: 0x04001DBD RID: 7613
		internal static byte __PropertyMask_bGlobalGravitySet;

		// Token: 0x04001DBE RID: 7614
		internal static int __PropertyOffset_bMinimizeBSPSections;

		// Token: 0x04001DBF RID: 7615
		internal static byte __PropertyMask_bMinimizeBSPSections;

		// Token: 0x04001DC0 RID: 7616
		internal static int __PropertyOffset_bForceNoPrecomputedLighting;

		// Token: 0x04001DC1 RID: 7617
		internal static byte __PropertyMask_bForceNoPrecomputedLighting;

		// Token: 0x04001DC2 RID: 7618
		internal static int __PropertyOffset_bHighPriorityLoading;

		// Token: 0x04001DC3 RID: 7619
		internal static byte __PropertyMask_bHighPriorityLoading;

		// Token: 0x04001DC4 RID: 7620
		internal static int __PropertyOffset_bHighPriorityLoadingLocal;

		// Token: 0x04001DC5 RID: 7621
		internal static byte __PropertyMask_bHighPriorityLoadingLocal;

		// Token: 0x04001DC6 RID: 7622
		internal static int __PropertyOffset_bOverrideDefaultBroadphaseSettings;

		// Token: 0x04001DC7 RID: 7623
		internal static byte __PropertyMask_bOverrideDefaultBroadphaseSettings;

		// Token: 0x04001DC8 RID: 7624
		internal static int __PropertyOffset_NavigationSystemConfig;

		// Token: 0x04001DC9 RID: 7625
		internal static int __PropertyOffset_NavigationSystemConfigOverride;

		// Token: 0x04001DCA RID: 7626
		internal static int __PropertyOffset_InstancedFoliageGridSize;

		// Token: 0x04001DCB RID: 7627
		internal static int __PropertyOffset_WorldToMeters;

		// Token: 0x04001DCC RID: 7628
		internal static int __PropertyOffset_KillZ;

		// Token: 0x04001DCD RID: 7629
		internal static int __PropertyOffset_WorldGravityZ;

		// Token: 0x04001DCE RID: 7630
		internal static int __PropertyOffset_GlobalGravityZ;

		// Token: 0x04001DCF RID: 7631
		internal static int __PropertyOffset_DefaultGameMode;

		// Token: 0x04001DD0 RID: 7632
		internal static int __PropertyOffset_PackedLightAndShadowMapTextureSize;

		// Token: 0x04001DD1 RID: 7633
		internal static int __PropertyOffset_DefaultColorScale;

		// Token: 0x04001DD2 RID: 7634
		internal static int __PropertyOffset_DefaultMaxDistanceFieldOcclusionDistance;

		// Token: 0x04001DD3 RID: 7635
		internal static int __PropertyOffset_GlobalDistanceFieldViewDistance;

		// Token: 0x04001DD4 RID: 7636
		internal static int __PropertyOffset_DynamicIndirectShadowsSelfShadowingIntensity;

		// Token: 0x04001DD5 RID: 7637
		internal static int __PropertyOffset_KuroPlanarReflectionMaxScreenPercentage;

		// Token: 0x04001DD6 RID: 7638
		internal static int __PropertyOffset_KuroPlanarReflectionMinCaptureInterval;

		// Token: 0x04001DD7 RID: 7639
		internal static int __PropertyOffset_KuroPlanarReflectionMaxCapturesPerFrame;

		// Token: 0x04001DD8 RID: 7640
		internal static int __PropertyOffset_KuroPlanarReflectionMinActiveTime;

		// Token: 0x04001DD9 RID: 7641
		internal static int __PropertyOffset_KuroPlanarReflectionSwitchAreaRatio;

		// Token: 0x04001DDA RID: 7642
		internal static int __PropertyOffset_bKuroPlanarReflectionDynamicResolution;

		// Token: 0x04001DDB RID: 7643
		internal static int __PropertyOffset_KuroPlanarReflectionDynamicResolutionMaxScreenPercentage;

		// Token: 0x04001DDC RID: 7644
		internal static int __PropertyOffset_bUpdateStaticMeshVertexBounds;

		// Token: 0x04001DDD RID: 7645
		internal static byte __PropertyMask_bUpdateStaticMeshVertexBounds;

		// Token: 0x04001DDE RID: 7646
		internal static int __PropertyOffset_bPrtEnabled;

		// Token: 0x04001DDF RID: 7647
		internal static byte __PropertyMask_bPrtEnabled;

		// Token: 0x04001DE0 RID: 7648
		internal static int __PropertyOffset_PrtLQBakedAOScale;

		// Token: 0x04001DE1 RID: 7649
		internal static int __PropertyOffset_bClvEnabled;

		// Token: 0x04001DE2 RID: 7650
		internal static byte __PropertyMask_bClvEnabled;

		// Token: 0x04001DE3 RID: 7651
		internal static int __PropertyOffset_bClvHasInteriorVolume;

		// Token: 0x04001DE4 RID: 7652
		internal static byte __PropertyMask_bClvHasInteriorVolume;

		// Token: 0x04001DE5 RID: 7653
		internal static int __PropertyOffset_MonoCullingDistance;

		// Token: 0x04001DE6 RID: 7654
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04001DE7 RID: 7655
		internal static int __PropertyOffset_MatineeTimeDilation;

		// Token: 0x04001DE8 RID: 7656
		internal static int __PropertyOffset_DemoPlayTimeDilation;

		// Token: 0x04001DE9 RID: 7657
		internal static int __PropertyOffset_MinGlobalTimeDilation;

		// Token: 0x04001DEA RID: 7658
		internal static int __PropertyOffset_MaxGlobalTimeDilation;

		// Token: 0x04001DEB RID: 7659
		internal static int __PropertyOffset_MinUndilatedFrameTime;

		// Token: 0x04001DEC RID: 7660
		internal static int __PropertyOffset_MaxUndilatedFrameTime;

		// Token: 0x04001DED RID: 7661
		internal static int __PropertyOffset_bEnableUE5NavigationPartitionSystem;

		// Token: 0x04001DEE RID: 7662
		internal static int __PropertyOffset_bEnableNavMeshTileVariants;

		// Token: 0x04001DEF RID: 7663
		internal static int __PropertyOffset_NavigationDataChunkGridSize;

		// Token: 0x04001DF0 RID: 7664
		internal static int __PropertyOffset_NavigationDataBuilderLoadingCellSize;

		// Token: 0x04001DF1 RID: 7665
		internal static int __PropertyOffset_MaxNumberOfBookmarks;
	}
}
