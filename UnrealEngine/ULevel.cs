using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D23 RID: 3363
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Level")]
	[UnrealStructLayout(2400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2400)]
	public class ULevel : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B444 RID: 46148 RVA: 0x0010109A File Offset: 0x000FF29A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevel._ClassPtr;
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x001010A6 File Offset: 0x000FF2A6
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return ULevel.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x001010B0 File Offset: 0x000FF2B0
		public ULevel() : this(BuiltinUtils.AllocNativeUObject(ULevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x001010D8 File Offset: 0x000FF2D8
		[NullableContext(1)]
		public ULevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600B448 RID: 46152 RVA: 0x0010110B File Offset: 0x000FF30B
		// (set) Token: 0x0600B449 RID: 46153 RVA: 0x0010111F File Offset: 0x000FF31F
		public unsafe UWorld OwningWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_OwningWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_OwningWorld, value);
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600B44A RID: 46154 RVA: 0x00101134 File Offset: 0x000FF334
		// (set) Token: 0x0600B44B RID: 46155 RVA: 0x00101148 File Offset: 0x000FF348
		public unsafe FIntVector LastWorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LastWorldOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LastWorldOrigin) = value;
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x0010115D File Offset: 0x000FF35D
		// (set) Token: 0x0600B44D RID: 46157 RVA: 0x00101171 File Offset: 0x000FF371
		public unsafe UModel Model
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UModel>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_Model);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_Model, value);
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x00101188 File Offset: 0x000FF388
		// (set) Token: 0x0600B44F RID: 46159 RVA: 0x001011C1 File Offset: 0x000FF3C1
		[Nullable(1)]
		public TArray<UModelComponent> ModelComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UModelComponent> result;
				if ((result = this._ModelComponents) == null)
				{
					result = (this._ModelComponents = new TArray<UModelComponent>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_ModelComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ModelComponents.CopyAssign(value);
			}
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x001011CF File Offset: 0x000FF3CF
		// (set) Token: 0x0600B451 RID: 46161 RVA: 0x001011E3 File Offset: 0x000FF3E3
		public unsafe ULevelActorContainer ActorCluster
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelActorContainer>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_ActorCluster);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_ActorCluster, value);
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x001011F8 File Offset: 0x000FF3F8
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x00101208 File Offset: 0x000FF408
		public unsafe int NumTextureStreamingUnbuiltComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingUnbuiltComponents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingUnbuiltComponents) = value;
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x00101219 File Offset: 0x000FF419
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x00101229 File Offset: 0x000FF429
		public unsafe int NumTextureStreamingDirtyResources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingDirtyResources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingDirtyResources) = value;
			}
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x0010123A File Offset: 0x000FF43A
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x0010124E File Offset: 0x000FF44E
		public unsafe ALevelScriptActor LevelScriptActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelScriptActor>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_LevelScriptActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_LevelScriptActor, value);
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x00101263 File Offset: 0x000FF463
		// (set) Token: 0x0600B459 RID: 46169 RVA: 0x00101277 File Offset: 0x000FF477
		public unsafe ANavigationObjectBase NavListStart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationObjectBase>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListStart);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListStart, value);
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x0010128C File Offset: 0x000FF48C
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x001012A0 File Offset: 0x000FF4A0
		public unsafe ANavigationObjectBase NavListEnd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationObjectBase>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListEnd);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListEnd, value);
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x001012B8 File Offset: 0x000FF4B8
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x001012F1 File Offset: 0x000FF4F1
		[Nullable(1)]
		public TArray<UNavigationDataChunk> NavDataChunks
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNavigationDataChunk> result;
				if ((result = this._NavDataChunks) == null)
				{
					result = (this._NavDataChunks = new TArray<UNavigationDataChunk>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NavDataChunks, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NavDataChunks.CopyAssign(value);
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x001012FF File Offset: 0x000FF4FF
		// (set) Token: 0x0600B45F RID: 46175 RVA: 0x0010130F File Offset: 0x000FF50F
		public unsafe float LightmapTotalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightmapTotalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightmapTotalSize) = value;
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600B460 RID: 46176 RVA: 0x00101320 File Offset: 0x000FF520
		// (set) Token: 0x0600B461 RID: 46177 RVA: 0x00101330 File Offset: 0x000FF530
		public unsafe float ShadowmapTotalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_ShadowmapTotalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_ShadowmapTotalSize) = value;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x00101344 File Offset: 0x000FF544
		// (set) Token: 0x0600B463 RID: 46179 RVA: 0x0010137D File Offset: 0x000FF57D
		[Nullable(1)]
		public TArray<FVector> StaticNavigableGeometry
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._StaticNavigableGeometry) == null)
				{
					result = (this._StaticNavigableGeometry = new TArray<FVector>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_StaticNavigableGeometry, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticNavigableGeometry.CopyAssign(value);
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x0010138C File Offset: 0x000FF58C
		// (set) Token: 0x0600B465 RID: 46181 RVA: 0x001013C5 File Offset: 0x000FF5C5
		[Nullable(1)]
		public TArray<FGuid> StreamingTextureGuids
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._StreamingTextureGuids) == null)
				{
					result = (this._StreamingTextureGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_StreamingTextureGuids, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingTextureGuids.CopyAssign(value);
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600B466 RID: 46182 RVA: 0x001013D3 File Offset: 0x000FF5D3
		// (set) Token: 0x0600B467 RID: 46183 RVA: 0x001013E7 File Offset: 0x000FF5E7
		public unsafe FGuid LevelBuildDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LevelBuildDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LevelBuildDataId) = value;
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x001013FC File Offset: 0x000FF5FC
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x00101410 File Offset: 0x000FF610
		public unsafe UMapBuildDataRegistry MapBuildData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMapBuildDataRegistry>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_MapBuildData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_MapBuildData, value);
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x00101425 File Offset: 0x000FF625
		// (set) Token: 0x0600B46B RID: 46187 RVA: 0x00101439 File Offset: 0x000FF639
		public unsafe FIntVector LightBuildLevelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightBuildLevelOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightBuildLevelOffset) = value;
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x0010144E File Offset: 0x000FF64E
		// (set) Token: 0x0600B46D RID: 46189 RVA: 0x00101467 File Offset: 0x000FF667
		public unsafe bool bIsLightingScenario
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) & ULevel.__PropertyMask_bIsLightingScenario) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) & ~ULevel.__PropertyMask_bIsLightingScenario) | (value ? ULevel.__PropertyMask_bIsLightingScenario : 0));
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600B46E RID: 46190 RVA: 0x00101497 File Offset: 0x000FF697
		// (set) Token: 0x0600B46F RID: 46191 RVA: 0x001014B0 File Offset: 0x000FF6B0
		public unsafe bool bTextureStreamingRotationChanged
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) & ULevel.__PropertyMask_bTextureStreamingRotationChanged) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) & ~ULevel.__PropertyMask_bTextureStreamingRotationChanged) | (value ? ULevel.__PropertyMask_bTextureStreamingRotationChanged : 0));
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x001014E0 File Offset: 0x000FF6E0
		// (set) Token: 0x0600B471 RID: 46193 RVA: 0x001014F9 File Offset: 0x000FF6F9
		public unsafe bool bStaticComponentsRegisteredInStreamingManager
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) & ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) & ~ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager) | (value ? ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager : 0));
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600B472 RID: 46194 RVA: 0x00101529 File Offset: 0x000FF729
		// (set) Token: 0x0600B473 RID: 46195 RVA: 0x00101542 File Offset: 0x000FF742
		public unsafe bool bIsVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) & ULevel.__PropertyMask_bIsVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) & ~ULevel.__PropertyMask_bIsVisible) | (value ? ULevel.__PropertyMask_bIsVisible : 0));
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x00101572 File Offset: 0x000FF772
		// (set) Token: 0x0600B475 RID: 46197 RVA: 0x0010158B File Offset: 0x000FF78B
		public unsafe bool bIsPartitioned
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) & ULevel.__PropertyMask_bIsPartitioned) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) & ~ULevel.__PropertyMask_bIsPartitioned) | (value ? ULevel.__PropertyMask_bIsPartitioned : 0));
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600B476 RID: 46198 RVA: 0x001015BB File Offset: 0x000FF7BB
		// (set) Token: 0x0600B477 RID: 46199 RVA: 0x001015D4 File Offset: 0x000FF7D4
		public unsafe bool bTickEvenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) & ULevel.__PropertyMask_bTickEvenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) & ~ULevel.__PropertyMask_bTickEvenPaused) | (value ? ULevel.__PropertyMask_bTickEvenPaused : 0));
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x00101604 File Offset: 0x000FF804
		// (set) Token: 0x0600B479 RID: 46201 RVA: 0x00101618 File Offset: 0x000FF818
		public unsafe AWorldSettings WorldSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AWorldSettings>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldSettings, value);
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x0600B47A RID: 46202 RVA: 0x0010162D File Offset: 0x000FF82D
		// (set) Token: 0x0600B47B RID: 46203 RVA: 0x00101641 File Offset: 0x000FF841
		public unsafe AWorldDataLayers WorldDataLayers
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AWorldDataLayers>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldDataLayers);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldDataLayers, value);
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600B47C RID: 46204 RVA: 0x00101656 File Offset: 0x000FF856
		// (set) Token: 0x0600B47D RID: 46205 RVA: 0x0010166B File Offset: 0x000FF86B
		[Nullable(1)]
		public TSoftObjectPtr<UWorldPartitionRuntimeCell> WorldPartitionRuntimeCell
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_WorldPartitionRuntimeCell, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_WorldPartitionRuntimeCell, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600B47E RID: 46206 RVA: 0x00101690 File Offset: 0x000FF890
		// (set) Token: 0x0600B47F RID: 46207 RVA: 0x001016C9 File Offset: 0x000FF8C9
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
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600B480 RID: 46208 RVA: 0x001016D8 File Offset: 0x000FF8D8
		// (set) Token: 0x0600B481 RID: 46209 RVA: 0x00101711 File Offset: 0x000FF911
		[Nullable(1)]
		public TArray<FReplicatedStaticActorDestructionInfo> DestroyedReplicatedStaticActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FReplicatedStaticActorDestructionInfo> result;
				if ((result = this._DestroyedReplicatedStaticActors) == null)
				{
					result = (this._DestroyedReplicatedStaticActors = new TArray<FReplicatedStaticActorDestructionInfo>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_DestroyedReplicatedStaticActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DestroyedReplicatedStaticActors.CopyAssign(value);
			}
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x0010171F File Offset: 0x000FF91F
		static ULevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Level");
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x0010172D File Offset: 0x000FF92D
		protected ULevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005EB8 RID: 24248
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04005EB9 RID: 24249
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Level";

		// Token: 0x04005EBA RID: 24250
		private static IntPtr _ClassPtr;

		// Token: 0x04005EBB RID: 24251
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005EBC RID: 24252
		internal static int __PropertyOffset_OwningWorld;

		// Token: 0x04005EBD RID: 24253
		internal static int __PropertyOffset_LastWorldOrigin;

		// Token: 0x04005EBE RID: 24254
		internal static int __PropertyOffset_Model;

		// Token: 0x04005EBF RID: 24255
		internal static int __PropertyOffset_ModelComponents;

		// Token: 0x04005EC0 RID: 24256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UModelComponent> _ModelComponents;

		// Token: 0x04005EC1 RID: 24257
		internal static int __PropertyOffset_ActorCluster;

		// Token: 0x04005EC2 RID: 24258
		internal static int __PropertyOffset_NumTextureStreamingUnbuiltComponents;

		// Token: 0x04005EC3 RID: 24259
		internal static int __PropertyOffset_NumTextureStreamingDirtyResources;

		// Token: 0x04005EC4 RID: 24260
		internal static int __PropertyOffset_LevelScriptActor;

		// Token: 0x04005EC5 RID: 24261
		internal static int __PropertyOffset_NavListStart;

		// Token: 0x04005EC6 RID: 24262
		internal static int __PropertyOffset_NavListEnd;

		// Token: 0x04005EC7 RID: 24263
		internal static int __PropertyOffset_NavDataChunks;

		// Token: 0x04005EC8 RID: 24264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNavigationDataChunk> _NavDataChunks;

		// Token: 0x04005EC9 RID: 24265
		internal static int __PropertyOffset_LightmapTotalSize;

		// Token: 0x04005ECA RID: 24266
		internal static int __PropertyOffset_ShadowmapTotalSize;

		// Token: 0x04005ECB RID: 24267
		internal static int __PropertyOffset_StaticNavigableGeometry;

		// Token: 0x04005ECC RID: 24268
		private TArray<FVector> _StaticNavigableGeometry;

		// Token: 0x04005ECD RID: 24269
		internal static int __PropertyOffset_StreamingTextureGuids;

		// Token: 0x04005ECE RID: 24270
		private TArray<FGuid> _StreamingTextureGuids;

		// Token: 0x04005ECF RID: 24271
		internal static int __PropertyOffset_LevelBuildDataId;

		// Token: 0x04005ED0 RID: 24272
		internal static int __PropertyOffset_MapBuildData;

		// Token: 0x04005ED1 RID: 24273
		internal static int __PropertyOffset_LightBuildLevelOffset;

		// Token: 0x04005ED2 RID: 24274
		internal static int __PropertyOffset_bIsLightingScenario;

		// Token: 0x04005ED3 RID: 24275
		internal static byte __PropertyMask_bIsLightingScenario;

		// Token: 0x04005ED4 RID: 24276
		internal static int __PropertyOffset_bTextureStreamingRotationChanged;

		// Token: 0x04005ED5 RID: 24277
		internal static byte __PropertyMask_bTextureStreamingRotationChanged;

		// Token: 0x04005ED6 RID: 24278
		internal static int __PropertyOffset_bStaticComponentsRegisteredInStreamingManager;

		// Token: 0x04005ED7 RID: 24279
		internal static byte __PropertyMask_bStaticComponentsRegisteredInStreamingManager;

		// Token: 0x04005ED8 RID: 24280
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x04005ED9 RID: 24281
		internal static byte __PropertyMask_bIsVisible;

		// Token: 0x04005EDA RID: 24282
		internal static int __PropertyOffset_bIsPartitioned;

		// Token: 0x04005EDB RID: 24283
		internal static byte __PropertyMask_bIsPartitioned;

		// Token: 0x04005EDC RID: 24284
		internal static int __PropertyOffset_bTickEvenPaused;

		// Token: 0x04005EDD RID: 24285
		internal static byte __PropertyMask_bTickEvenPaused;

		// Token: 0x04005EDE RID: 24286
		internal static int __PropertyOffset_WorldSettings;

		// Token: 0x04005EDF RID: 24287
		internal static int __PropertyOffset_WorldDataLayers;

		// Token: 0x04005EE0 RID: 24288
		internal static int __PropertyOffset_WorldPartitionRuntimeCell;

		// Token: 0x04005EE1 RID: 24289
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04005EE2 RID: 24290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;

		// Token: 0x04005EE3 RID: 24291
		internal static int __PropertyOffset_DestroyedReplicatedStaticActors;

		// Token: 0x04005EE4 RID: 24292
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FReplicatedStaticActorDestructionInfo> _DestroyedReplicatedStaticActors;
	}
}
