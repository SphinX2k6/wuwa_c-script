using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001249 RID: 4681
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.World")]
	[UnrealStructLayout(2592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2592)]
	public class UWorld : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011340 RID: 70464 RVA: 0x00193C72 File Offset: 0x00191E72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorld._ClassPtr;
		}

		// Token: 0x06011341 RID: 70465 RVA: 0x00193C80 File Offset: 0x00191E80
		public UWorld() : this(BuiltinUtils.AllocNativeUObject(UWorld.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011342 RID: 70466 RVA: 0x00193CA8 File Offset: 0x00191EA8
		[NullableContext(1)]
		public UWorld(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorld.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x06011343 RID: 70467 RVA: 0x00193CDB File Offset: 0x00191EDB
		// (set) Token: 0x06011344 RID: 70468 RVA: 0x00193CEF File Offset: 0x00191EEF
		public unsafe ULevel PersistentLevel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLevel);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLevel, value);
			}
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x06011345 RID: 70469 RVA: 0x00193D04 File Offset: 0x00191F04
		// (set) Token: 0x06011346 RID: 70470 RVA: 0x00193D18 File Offset: 0x00191F18
		public unsafe UNetDriver NetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NetDriver, value);
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x06011347 RID: 70471 RVA: 0x00193D2D File Offset: 0x00191F2D
		// (set) Token: 0x06011348 RID: 70472 RVA: 0x00193D41 File Offset: 0x00191F41
		public unsafe ULineBatchComponent LineBatcher
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULineBatchComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_LineBatcher);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_LineBatcher, value);
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x06011349 RID: 70473 RVA: 0x00193D56 File Offset: 0x00191F56
		// (set) Token: 0x0601134A RID: 70474 RVA: 0x00193D6A File Offset: 0x00191F6A
		public unsafe ULineBatchComponent PersistentLineBatcher
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULineBatchComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLineBatcher);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLineBatcher, value);
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x0601134B RID: 70475 RVA: 0x00193D7F File Offset: 0x00191F7F
		// (set) Token: 0x0601134C RID: 70476 RVA: 0x00193D93 File Offset: 0x00191F93
		public unsafe ULineBatchComponent ForegroundLineBatcher
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULineBatchComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_ForegroundLineBatcher);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_ForegroundLineBatcher, value);
			}
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x0601134D RID: 70477 RVA: 0x00193DA8 File Offset: 0x00191FA8
		// (set) Token: 0x0601134E RID: 70478 RVA: 0x00193DBC File Offset: 0x00191FBC
		public unsafe AGameNetworkManager NetworkManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameNetworkManager>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NetworkManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NetworkManager, value);
			}
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0601134F RID: 70479 RVA: 0x00193DD1 File Offset: 0x00191FD1
		// (set) Token: 0x06011350 RID: 70480 RVA: 0x00193DE5 File Offset: 0x00191FE5
		public unsafe UPhysicsCollisionHandler PhysicsCollisionHandler
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsCollisionHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PhysicsCollisionHandler);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PhysicsCollisionHandler, value);
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x06011351 RID: 70481 RVA: 0x00193DFC File Offset: 0x00191FFC
		// (set) Token: 0x06011352 RID: 70482 RVA: 0x00193E35 File Offset: 0x00192035
		[Nullable(1)]
		public TArray<UObject> ExtraReferencedObjects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ExtraReferencedObjects) == null)
				{
					result = (this._ExtraReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ExtraReferencedObjects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ExtraReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x06011353 RID: 70483 RVA: 0x00193E44 File Offset: 0x00192044
		// (set) Token: 0x06011354 RID: 70484 RVA: 0x00193E7D File Offset: 0x0019207D
		[Nullable(1)]
		public TArray<UObject> PerModuleDataObjects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._PerModuleDataObjects) == null)
				{
					result = (this._PerModuleDataObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_PerModuleDataObjects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PerModuleDataObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x06011355 RID: 70485 RVA: 0x00193E8C File Offset: 0x0019208C
		// (set) Token: 0x06011356 RID: 70486 RVA: 0x00193EC5 File Offset: 0x001920C5
		[Nullable(1)]
		public TArray<ULevelStreaming> StreamingLevels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelStreaming> result;
				if ((result = this._StreamingLevels) == null)
				{
					result = (this._StreamingLevels = new TArray<ULevelStreaming>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_StreamingLevels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingLevels.CopyAssign(value);
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x06011357 RID: 70487 RVA: 0x00193ED4 File Offset: 0x001920D4
		// (set) Token: 0x06011358 RID: 70488 RVA: 0x00193F0D File Offset: 0x0019210D
		[Nullable(1)]
		public FStreamingLevelsToConsider StreamingLevelsToConsider
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FStreamingLevelsToConsider result;
				if ((result = this._StreamingLevelsToConsider) == null)
				{
					result = (this._StreamingLevelsToConsider = new FStreamingLevelsToConsider(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_StreamingLevelsToConsider, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStreamingLevelsToConsider.StaticStruct(), base.NativePtr + (IntPtr)UWorld.__PropertyOffset_StreamingLevelsToConsider, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x06011359 RID: 70489 RVA: 0x00193F2E File Offset: 0x0019212E
		// (set) Token: 0x0601135A RID: 70490 RVA: 0x00193F42 File Offset: 0x00192142
		[Nullable(1)]
		public unsafe string StreamingLevelsPrefix
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UWorld.__PropertyOffset_StreamingLevelsPrefix)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UWorld.__PropertyOffset_StreamingLevelsPrefix)), value);
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x0601135B RID: 70491 RVA: 0x00193F57 File Offset: 0x00192157
		// (set) Token: 0x0601135C RID: 70492 RVA: 0x00193F6B File Offset: 0x0019216B
		public unsafe ULevel CurrentLevelPendingVisibility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingVisibility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingVisibility, value);
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x0601135D RID: 70493 RVA: 0x00193F80 File Offset: 0x00192180
		// (set) Token: 0x0601135E RID: 70494 RVA: 0x00193F94 File Offset: 0x00192194
		public unsafe ULevel CurrentLevelPendingInvisibility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingInvisibility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingInvisibility, value);
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x0601135F RID: 70495 RVA: 0x00193FA9 File Offset: 0x001921A9
		// (set) Token: 0x06011360 RID: 70496 RVA: 0x00193FBD File Offset: 0x001921BD
		public unsafe UDemoNetDriver DemoNetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDemoNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_DemoNetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_DemoNetDriver, value);
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x06011361 RID: 70497 RVA: 0x00193FD2 File Offset: 0x001921D2
		// (set) Token: 0x06011362 RID: 70498 RVA: 0x00193FE6 File Offset: 0x001921E6
		public unsafe AParticleEventManager MyParticleEventManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AParticleEventManager>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_MyParticleEventManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_MyParticleEventManager, value);
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x06011363 RID: 70499 RVA: 0x00193FFB File Offset: 0x001921FB
		// (set) Token: 0x06011364 RID: 70500 RVA: 0x0019400F File Offset: 0x0019220F
		public unsafe APhysicsVolume DefaultPhysicsVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APhysicsVolume>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_DefaultPhysicsVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_DefaultPhysicsVolume, value);
			}
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x06011365 RID: 70501 RVA: 0x00194024 File Offset: 0x00192224
		// (set) Token: 0x06011366 RID: 70502 RVA: 0x0019403D File Offset: 0x0019223D
		public unsafe bool bAreConstraintsDirty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) & UWorld.__PropertyMask_bAreConstraintsDirty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) = ((*(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) & ~UWorld.__PropertyMask_bAreConstraintsDirty) | (value ? UWorld.__PropertyMask_bAreConstraintsDirty : 0));
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x06011367 RID: 70503 RVA: 0x0019406D File Offset: 0x0019226D
		// (set) Token: 0x06011368 RID: 70504 RVA: 0x00194081 File Offset: 0x00192281
		public unsafe UNavigationSystemBase NavigationSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationSystem, value);
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x06011369 RID: 70505 RVA: 0x00194096 File Offset: 0x00192296
		// (set) Token: 0x0601136A RID: 70506 RVA: 0x001940AA File Offset: 0x001922AA
		public unsafe UNavigationSystemBase StreamingDungeonNavSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_StreamingDungeonNavSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_StreamingDungeonNavSystem, value);
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x0601136B RID: 70507 RVA: 0x001940BF File Offset: 0x001922BF
		// (set) Token: 0x0601136C RID: 70508 RVA: 0x001940D3 File Offset: 0x001922D3
		public unsafe UNavigationPartitionSystemBase NavigationPartitionSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationPartitionSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationPartitionSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationPartitionSystem, value);
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x0601136D RID: 70509 RVA: 0x001940E8 File Offset: 0x001922E8
		// (set) Token: 0x0601136E RID: 70510 RVA: 0x001940FC File Offset: 0x001922FC
		public unsafe URoadNetNavigationSystemBase RoadNetNavigationSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URoadNetNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_RoadNetNavigationSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_RoadNetNavigationSystem, value);
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x0601136F RID: 70511 RVA: 0x00194111 File Offset: 0x00192311
		// (set) Token: 0x06011370 RID: 70512 RVA: 0x00194125 File Offset: 0x00192325
		public unsafe UAudioGlobalSystemBase AudioGlobalSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioGlobalSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AudioGlobalSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AudioGlobalSystem, value);
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x06011371 RID: 70513 RVA: 0x0019413A File Offset: 0x0019233A
		// (set) Token: 0x06011372 RID: 70514 RVA: 0x0019414E File Offset: 0x0019234E
		public unsafe AGameModeBase AuthorityGameMode
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameModeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AuthorityGameMode);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AuthorityGameMode, value);
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x06011373 RID: 70515 RVA: 0x00194163 File Offset: 0x00192363
		// (set) Token: 0x06011374 RID: 70516 RVA: 0x00194177 File Offset: 0x00192377
		public unsafe AGameStateBase GameState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameStateBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_GameState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_GameState, value);
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x06011375 RID: 70517 RVA: 0x0019418C File Offset: 0x0019238C
		// (set) Token: 0x06011376 RID: 70518 RVA: 0x001941A0 File Offset: 0x001923A0
		public unsafe UAISystemBase AISystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAISystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AISystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AISystem, value);
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x06011377 RID: 70519 RVA: 0x001941B5 File Offset: 0x001923B5
		// (set) Token: 0x06011378 RID: 70520 RVA: 0x001941C9 File Offset: 0x001923C9
		public unsafe UAvoidanceManager AvoidanceManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAvoidanceManager>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AvoidanceManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AvoidanceManager, value);
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x06011379 RID: 70521 RVA: 0x001941E0 File Offset: 0x001923E0
		// (set) Token: 0x0601137A RID: 70522 RVA: 0x00194219 File Offset: 0x00192419
		[Nullable(1)]
		public TArray<ULevel> Levels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULevel> result;
				if ((result = this._Levels) == null)
				{
					result = (this._Levels = new TArray<ULevel>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_Levels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Levels.CopyAssign(value);
			}
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x0601137B RID: 70523 RVA: 0x00194228 File Offset: 0x00192428
		// (set) Token: 0x0601137C RID: 70524 RVA: 0x00194261 File Offset: 0x00192461
		[Nullable(1)]
		public TArray<FLevelCollection> LevelCollections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelCollection> result;
				if ((result = this._LevelCollections) == null)
				{
					result = (this._LevelCollections = new TArray<FLevelCollection>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_LevelCollections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LevelCollections.CopyAssign(value);
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x0601137D RID: 70525 RVA: 0x0019426F File Offset: 0x0019246F
		// (set) Token: 0x0601137E RID: 70526 RVA: 0x00194283 File Offset: 0x00192483
		public unsafe UGameInstance OwningGameInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_OwningGameInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_OwningGameInstance, value);
			}
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x0601137F RID: 70527 RVA: 0x00194298 File Offset: 0x00192498
		// (set) Token: 0x06011380 RID: 70528 RVA: 0x001942D1 File Offset: 0x001924D1
		[Nullable(1)]
		public TArray<UMaterialParameterCollectionInstance> ParameterCollectionInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialParameterCollectionInstance> result;
				if ((result = this._ParameterCollectionInstances) == null)
				{
					result = (this._ParameterCollectionInstances = new TArray<UMaterialParameterCollectionInstance>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ParameterCollectionInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParameterCollectionInstances.CopyAssign(value);
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x06011381 RID: 70529 RVA: 0x001942DF File Offset: 0x001924DF
		// (set) Token: 0x06011382 RID: 70530 RVA: 0x001942F3 File Offset: 0x001924F3
		public unsafe UCanvas CanvasForRenderingToTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCanvas>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CanvasForRenderingToTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CanvasForRenderingToTarget, value);
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x06011383 RID: 70531 RVA: 0x00194308 File Offset: 0x00192508
		// (set) Token: 0x06011384 RID: 70532 RVA: 0x0019431C File Offset: 0x0019251C
		public unsafe UCanvas CanvasForDrawMaterialToRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCanvas>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CanvasForDrawMaterialToRenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CanvasForDrawMaterialToRenderTarget, value);
			}
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x06011385 RID: 70533 RVA: 0x00194334 File Offset: 0x00192534
		// (set) Token: 0x06011386 RID: 70534 RVA: 0x0019436D File Offset: 0x0019256D
		[Nullable(1)]
		public TSet<UActorComponent> ComponentsThatNeedPreEndOfFrameSync
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UActorComponent> result;
				if ((result = this._ComponentsThatNeedPreEndOfFrameSync) == null)
				{
					result = (this._ComponentsThatNeedPreEndOfFrameSync = new TSet<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedPreEndOfFrameSync, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentsThatNeedPreEndOfFrameSync.CopyAssign(value);
			}
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x06011387 RID: 70535 RVA: 0x0019437C File Offset: 0x0019257C
		// (set) Token: 0x06011388 RID: 70536 RVA: 0x001943B5 File Offset: 0x001925B5
		[Nullable(1)]
		public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentsThatNeedEndOfFrameUpdate) == null)
				{
					result = (this._ComponentsThatNeedEndOfFrameUpdate = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedEndOfFrameUpdate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentsThatNeedEndOfFrameUpdate.CopyAssign(value);
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x06011389 RID: 70537 RVA: 0x001943C4 File Offset: 0x001925C4
		// (set) Token: 0x0601138A RID: 70538 RVA: 0x001943FD File Offset: 0x001925FD
		[Nullable(1)]
		public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate_OnGameThread
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentsThatNeedEndOfFrameUpdate_OnGameThread) == null)
				{
					result = (this._ComponentsThatNeedEndOfFrameUpdate_OnGameThread = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedEndOfFrameUpdate_OnGameThread, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentsThatNeedEndOfFrameUpdate_OnGameThread.CopyAssign(value);
			}
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x0601138B RID: 70539 RVA: 0x0019440B File Offset: 0x0019260B
		// (set) Token: 0x0601138C RID: 70540 RVA: 0x0019441F File Offset: 0x0019261F
		public unsafe UWorldComposition WorldComposition
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldComposition>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_WorldComposition);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_WorldComposition, value);
			}
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x0601138D RID: 70541 RVA: 0x00194434 File Offset: 0x00192634
		// (set) Token: 0x0601138E RID: 70542 RVA: 0x0019446D File Offset: 0x0019266D
		[Nullable(1)]
		public FWorldPSCPool PSCPool
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWorldPSCPool result;
				if ((result = this._PSCPool) == null)
				{
					result = (this._PSCPool = new FWorldPSCPool(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_PSCPool, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPSCPool.StaticStruct(), base.NativePtr + (IntPtr)UWorld.__PropertyOffset_PSCPool, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601138F RID: 70543 RVA: 0x0019448E File Offset: 0x0019268E
		public void SetSeamlessTravelMidpointPause(bool bNowPaused)
		{
			UWorld.__SetSeamlessTravelMidpointPause_Internal(base.NativePtr, bNowPaused);
		}

		// Token: 0x06011390 RID: 70544 RVA: 0x0019449C File Offset: 0x0019269C
		public void ResetAllTimeSeconds(float Seconds)
		{
			UWorld.__ResetAllTimeSeconds_Internal(base.NativePtr, Seconds);
		}

		// Token: 0x06011391 RID: 70545 RVA: 0x001944AA File Offset: 0x001926AA
		public AWorldSettings K2_GetWorldSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AWorldSettings>(UWorld.__K2_GetWorldSettings_Internal(base.NativePtr));
		}

		// Token: 0x06011392 RID: 70546 RVA: 0x001944BC File Offset: 0x001926BC
		public void HandleTimelineScrubbed()
		{
			UWorld.__HandleTimelineScrubbed_Internal(base.NativePtr);
		}

		// Token: 0x06011393 RID: 70547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeamlessTravelMidpointPause_Internal(IntPtr @this, bool bNowPaused);

		// Token: 0x06011394 RID: 70548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllTimeSeconds_Internal(IntPtr @this, float Seconds);

		// Token: 0x06011395 RID: 70549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetWorldSettings_Internal(IntPtr @this);

		// Token: 0x06011396 RID: 70550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTimelineScrubbed_Internal(IntPtr @this);

		// Token: 0x06011397 RID: 70551 RVA: 0x001944C9 File Offset: 0x001926C9
		static UWorld()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.World");
		}

		// Token: 0x06011398 RID: 70552 RVA: 0x001944D7 File Offset: 0x001926D7
		protected UWorld(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400932A RID: 37674
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.World";

		// Token: 0x0400932B RID: 37675
		private static IntPtr _ClassPtr;

		// Token: 0x0400932C RID: 37676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400932D RID: 37677
		internal static int __PropertyOffset_PersistentLevel;

		// Token: 0x0400932E RID: 37678
		internal static int __PropertyOffset_NetDriver;

		// Token: 0x0400932F RID: 37679
		internal static int __PropertyOffset_LineBatcher;

		// Token: 0x04009330 RID: 37680
		internal static int __PropertyOffset_PersistentLineBatcher;

		// Token: 0x04009331 RID: 37681
		internal static int __PropertyOffset_ForegroundLineBatcher;

		// Token: 0x04009332 RID: 37682
		internal static int __PropertyOffset_NetworkManager;

		// Token: 0x04009333 RID: 37683
		internal static int __PropertyOffset_PhysicsCollisionHandler;

		// Token: 0x04009334 RID: 37684
		internal static int __PropertyOffset_ExtraReferencedObjects;

		// Token: 0x04009335 RID: 37685
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ExtraReferencedObjects;

		// Token: 0x04009336 RID: 37686
		internal static int __PropertyOffset_PerModuleDataObjects;

		// Token: 0x04009337 RID: 37687
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _PerModuleDataObjects;

		// Token: 0x04009338 RID: 37688
		internal static int __PropertyOffset_StreamingLevels;

		// Token: 0x04009339 RID: 37689
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelStreaming> _StreamingLevels;

		// Token: 0x0400933A RID: 37690
		internal static int __PropertyOffset_StreamingLevelsToConsider;

		// Token: 0x0400933B RID: 37691
		private FStreamingLevelsToConsider _StreamingLevelsToConsider;

		// Token: 0x0400933C RID: 37692
		internal static int __PropertyOffset_StreamingLevelsPrefix;

		// Token: 0x0400933D RID: 37693
		internal static int __PropertyOffset_CurrentLevelPendingVisibility;

		// Token: 0x0400933E RID: 37694
		internal static int __PropertyOffset_CurrentLevelPendingInvisibility;

		// Token: 0x0400933F RID: 37695
		internal static int __PropertyOffset_DemoNetDriver;

		// Token: 0x04009340 RID: 37696
		internal static int __PropertyOffset_MyParticleEventManager;

		// Token: 0x04009341 RID: 37697
		internal static int __PropertyOffset_DefaultPhysicsVolume;

		// Token: 0x04009342 RID: 37698
		internal static int __PropertyOffset_bAreConstraintsDirty;

		// Token: 0x04009343 RID: 37699
		internal static byte __PropertyMask_bAreConstraintsDirty;

		// Token: 0x04009344 RID: 37700
		internal static int __PropertyOffset_NavigationSystem;

		// Token: 0x04009345 RID: 37701
		internal static int __PropertyOffset_StreamingDungeonNavSystem;

		// Token: 0x04009346 RID: 37702
		internal static int __PropertyOffset_NavigationPartitionSystem;

		// Token: 0x04009347 RID: 37703
		internal static int __PropertyOffset_RoadNetNavigationSystem;

		// Token: 0x04009348 RID: 37704
		internal static int __PropertyOffset_AudioGlobalSystem;

		// Token: 0x04009349 RID: 37705
		internal static int __PropertyOffset_AuthorityGameMode;

		// Token: 0x0400934A RID: 37706
		internal static int __PropertyOffset_GameState;

		// Token: 0x0400934B RID: 37707
		internal static int __PropertyOffset_AISystem;

		// Token: 0x0400934C RID: 37708
		internal static int __PropertyOffset_AvoidanceManager;

		// Token: 0x0400934D RID: 37709
		internal static int __PropertyOffset_Levels;

		// Token: 0x0400934E RID: 37710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevel> _Levels;

		// Token: 0x0400934F RID: 37711
		internal static int __PropertyOffset_LevelCollections;

		// Token: 0x04009350 RID: 37712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelCollection> _LevelCollections;

		// Token: 0x04009351 RID: 37713
		internal static int __PropertyOffset_OwningGameInstance;

		// Token: 0x04009352 RID: 37714
		internal static int __PropertyOffset_ParameterCollectionInstances;

		// Token: 0x04009353 RID: 37715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialParameterCollectionInstance> _ParameterCollectionInstances;

		// Token: 0x04009354 RID: 37716
		internal static int __PropertyOffset_CanvasForRenderingToTarget;

		// Token: 0x04009355 RID: 37717
		internal static int __PropertyOffset_CanvasForDrawMaterialToRenderTarget;

		// Token: 0x04009356 RID: 37718
		internal static int __PropertyOffset_ComponentsThatNeedPreEndOfFrameSync;

		// Token: 0x04009357 RID: 37719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _ComponentsThatNeedPreEndOfFrameSync;

		// Token: 0x04009358 RID: 37720
		internal static int __PropertyOffset_ComponentsThatNeedEndOfFrameUpdate;

		// Token: 0x04009359 RID: 37721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentsThatNeedEndOfFrameUpdate;

		// Token: 0x0400935A RID: 37722
		internal static int __PropertyOffset_ComponentsThatNeedEndOfFrameUpdate_OnGameThread;

		// Token: 0x0400935B RID: 37723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentsThatNeedEndOfFrameUpdate_OnGameThread;

		// Token: 0x0400935C RID: 37724
		internal static int __PropertyOffset_WorldComposition;

		// Token: 0x0400935D RID: 37725
		internal static int __PropertyOffset_PSCPool;

		// Token: 0x0400935E RID: 37726
		private FWorldPSCPool _PSCPool;
	}
}
