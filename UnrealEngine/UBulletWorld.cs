using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CC RID: 5836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.BulletWorld")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class UBulletWorld : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015202 RID: 86530 RVA: 0x001F0FB8 File Offset: 0x001EF1B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletWorld._ClassPtr;
		}

		// Token: 0x06015203 RID: 86531 RVA: 0x001F0FC4 File Offset: 0x001EF1C4
		public UBulletWorld() : this(BuiltinUtils.AllocNativeUObject(UBulletWorld.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015204 RID: 86532 RVA: 0x001F0FEC File Offset: 0x001EF1EC
		public UBulletWorld(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletWorld.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x06015205 RID: 86533 RVA: 0x001F101F File Offset: 0x001EF21F
		// (set) Token: 0x06015206 RID: 86534 RVA: 0x001F1033 File Offset: 0x001EF233
		[Nullable(2)]
		public unsafe UTraceLineElement StickGroundLineTrace
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceLineElement>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_StickGroundLineTrace);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_StickGroundLineTrace, value);
			}
		}

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x06015207 RID: 86535 RVA: 0x001F1048 File Offset: 0x001EF248
		// (set) Token: 0x06015208 RID: 86536 RVA: 0x001F1058 File Offset: 0x001EF258
		public unsafe bool bFlatGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_bFlatGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_bFlatGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06015209 RID: 86537 RVA: 0x001F1069 File Offset: 0x001EF269
		// (set) Token: 0x0601520A RID: 86538 RVA: 0x001F1079 File Offset: 0x001EF279
		public unsafe double GroundZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_GroundZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_GroundZ) = value;
			}
		}

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x0601520B RID: 86539 RVA: 0x001F108A File Offset: 0x001EF28A
		// (set) Token: 0x0601520C RID: 86540 RVA: 0x001F109A File Offset: 0x001EF29A
		public unsafe bool ForceUpdateOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_ForceUpdateOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_ForceUpdateOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x0601520D RID: 86541 RVA: 0x001F10AC File Offset: 0x001EF2AC
		// (set) Token: 0x0601520E RID: 86542 RVA: 0x001F10E5 File Offset: 0x001EF2E5
		public FOnBulletModifyBuff OnBulletModifyBuff
		{
			get
			{
				base.FastCheckIsValid();
				FOnBulletModifyBuff result;
				if ((result = this._OnBulletModifyBuff) == null)
				{
					result = (this._OnBulletModifyBuff = new FOnBulletModifyBuff(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_OnBulletModifyBuff, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_OnBulletModifyBuff, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x0601520F RID: 86543 RVA: 0x001F1108 File Offset: 0x001EF308
		// (set) Token: 0x06015210 RID: 86544 RVA: 0x001F1141 File Offset: 0x001EF341
		public FOnBulletCameraShake OnBulletCameraShake
		{
			get
			{
				base.FastCheckIsValid();
				FOnBulletCameraShake result;
				if ((result = this._OnBulletCameraShake) == null)
				{
					result = (this._OnBulletCameraShake = new FOnBulletCameraShake(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_OnBulletCameraShake, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_OnBulletCameraShake, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x06015211 RID: 86545 RVA: 0x001F1162 File Offset: 0x001EF362
		// (set) Token: 0x06015212 RID: 86546 RVA: 0x001F1172 File Offset: 0x001EF372
		public unsafe bool EnableRecycledId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_EnableRecycledId) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_EnableRecycledId) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x06015213 RID: 86547 RVA: 0x001F1183 File Offset: 0x001EF383
		// (set) Token: 0x06015214 RID: 86548 RVA: 0x001F1193 File Offset: 0x001EF393
		public unsafe int MaxBulletCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_MaxBulletCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_MaxBulletCount) = value;
			}
		}

		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x06015215 RID: 86549 RVA: 0x001F11A4 File Offset: 0x001EF3A4
		// (set) Token: 0x06015216 RID: 86550 RVA: 0x001F11B4 File Offset: 0x001EF3B4
		public unsafe int CreateBulletBudgetPerSecondMicroseconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_CreateBulletBudgetPerSecondMicroseconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_CreateBulletBudgetPerSecondMicroseconds) = value;
			}
		}

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x06015217 RID: 86551 RVA: 0x001F11C5 File Offset: 0x001EF3C5
		// (set) Token: 0x06015218 RID: 86552 RVA: 0x001F11D5 File Offset: 0x001EF3D5
		public unsafe double CreateBulletBudgetBurstSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_CreateBulletBudgetBurstSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_CreateBulletBudgetBurstSeconds) = value;
			}
		}

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x06015219 RID: 86553 RVA: 0x001F11E6 File Offset: 0x001EF3E6
		// (set) Token: 0x0601521A RID: 86554 RVA: 0x001F11F6 File Offset: 0x001EF3F6
		public unsafe bool EnableBulletNoActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_EnableBulletNoActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_EnableBulletNoActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x0601521B RID: 86555 RVA: 0x001F1208 File Offset: 0x001EF408
		// (set) Token: 0x0601521C RID: 86556 RVA: 0x001F1241 File Offset: 0x001EF441
		public TArray<UDataTable> CommonBulletDataTableList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDataTable> result;
				if ((result = this._CommonBulletDataTableList) == null)
				{
					result = (this._CommonBulletDataTableList = new TArray<UDataTable>(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_CommonBulletDataTableList, this));
				}
				return result;
			}
			set
			{
				this.CommonBulletDataTableList.CopyAssign(value);
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x0601521D RID: 86557 RVA: 0x001F1250 File Offset: 0x001EF450
		// (set) Token: 0x0601521E RID: 86558 RVA: 0x001F1289 File Offset: 0x001EF489
		public TMap<int, UBulletEntity> BulletEntityMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UBulletEntity> result;
				if ((result = this._BulletEntityMap) == null)
				{
					result = (this._BulletEntityMap = new TMap<int, UBulletEntity>(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_BulletEntityMap, this));
				}
				return result;
			}
			set
			{
				this.BulletEntityMap.CopyAssign(value);
			}
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x0601521F RID: 86559 RVA: 0x001F1298 File Offset: 0x001EF498
		// (set) Token: 0x06015220 RID: 86560 RVA: 0x001F12D1 File Offset: 0x001EF4D1
		public TMap<int, UKuroBulletPattern> BulletPatternMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroBulletPattern> result;
				if ((result = this._BulletPatternMap) == null)
				{
					result = (this._BulletPatternMap = new TMap<int, UKuroBulletPattern>(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_BulletPatternMap, this));
				}
				return result;
			}
			set
			{
				this.BulletPatternMap.CopyAssign(value);
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x06015221 RID: 86561 RVA: 0x001F12DF File Offset: 0x001EF4DF
		// (set) Token: 0x06015222 RID: 86562 RVA: 0x001F12F3 File Offset: 0x001EF4F3
		[Nullable(2)]
		public unsafe UKuroBulletObstacle GroundObstacleObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletObstacle>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_GroundObstacleObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_GroundObstacleObject, value);
			}
		}

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x06015223 RID: 86563 RVA: 0x001F1308 File Offset: 0x001EF508
		// (set) Token: 0x06015224 RID: 86564 RVA: 0x001F1341 File Offset: 0x001EF541
		public TArray<UObject> ObjectHold
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjectHold) == null)
				{
					result = (this._ObjectHold = new TArray<UObject>(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_ObjectHold, this));
				}
				return result;
			}
			set
			{
				this.ObjectHold.CopyAssign(value);
			}
		}

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x06015225 RID: 86565 RVA: 0x001F1350 File Offset: 0x001EF550
		// (set) Token: 0x06015226 RID: 86566 RVA: 0x001F1389 File Offset: 0x001EF589
		public TArray<FDeferredBulletSpawn> DeferredSpawnQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDeferredBulletSpawn> result;
				if ((result = this._DeferredSpawnQueue) == null)
				{
					result = (this._DeferredSpawnQueue = new TArray<FDeferredBulletSpawn>(base.NativePtr + (IntPtr)UBulletWorld.__PropertyOffset_DeferredSpawnQueue, this));
				}
				return result;
			}
			set
			{
				this.DeferredSpawnQueue.CopyAssign(value);
			}
		}

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x06015227 RID: 86567 RVA: 0x001F1397 File Offset: 0x001EF597
		// (set) Token: 0x06015228 RID: 86568 RVA: 0x001F13AB File Offset: 0x001EF5AB
		[Nullable(2)]
		public unsafe UKuroFastCollisionAlgorithm KFCAlgorithm
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFastCollisionAlgorithm>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_KFCAlgorithm);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletWorld.__PropertyOffset_KFCAlgorithm, value);
			}
		}

		// Token: 0x06015229 RID: 86569 RVA: 0x001F13C0 File Offset: 0x001EF5C0
		[NullableContext(2)]
		public int SpawnPattern(IBulletContext PatternContext, UKuroBulletPatternDataAsset PatternDA)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(PatternContext, (PatternContext != null) ? PatternContext.InterfaceOffset() : 0);
			return UBulletWorld.__SpawnPattern_Internal(base.NativePtr, fscriptInterface, (PatternDA != null) ? PatternDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601522A RID: 86570 RVA: 0x001F13FE File Offset: 0x001EF5FE
		public void SetShowEmitterDebugDraw(bool Value)
		{
			UBulletWorld.__SetShowEmitterDebugDraw_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601522B RID: 86571 RVA: 0x001F140C File Offset: 0x001EF60C
		public void SetShowBulletCollision(bool Value)
		{
			UBulletWorld.__SetShowBulletCollision_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601522C RID: 86572 RVA: 0x001F141A File Offset: 0x001EF61A
		[NullableContext(2)]
		public void SetKFCAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UBulletWorld.__SetKFCAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x001F1437 File Offset: 0x001EF637
		public void SetCameraShakeCooldown(double Cooldown)
		{
			UBulletWorld.__SetCameraShakeCooldown_Internal(base.NativePtr, Cooldown);
		}

		// Token: 0x0601522E RID: 86574 RVA: 0x001F1445 File Offset: 0x001EF645
		public void SetBulletGroupMaxCountSingle(int GroupId, int MaxCount)
		{
			UBulletWorld.__SetBulletGroupMaxCountSingle_Internal(base.NativePtr, GroupId, MaxCount);
		}

		// Token: 0x0601522F RID: 86575 RVA: 0x001F1454 File Offset: 0x001EF654
		public unsafe void RegisterCameraShakeConfig(int ShakeKey, string ShakePath)
		{
			FString fstring = FString.AllocTemp(ShakePath);
			UBulletWorld.__RegisterCameraShakeConfig_Internal(base.NativePtr, ShakeKey, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06015230 RID: 86576 RVA: 0x001F147F File Offset: 0x001EF67F
		public void RegisterBulletLogicActionClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroBulletBpDataAsset> LogicAssetClass, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UBulletActionBase> ActionClass)
		{
			UBulletWorld.__RegisterBulletLogicActionClass_Internal(base.NativePtr, LogicAssetClass._NativePtr, ActionClass._NativePtr);
		}

		// Token: 0x06015231 RID: 86577 RVA: 0x001F1498 File Offset: 0x001EF698
		public void RegisterBulletActionClassByTag(FGameplayTag ActionTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UBulletActionBase> ActionClass)
		{
			UBulletWorld.__RegisterBulletActionClassByTag_Internal(base.NativePtr, ActionTag, ActionClass._NativePtr);
		}

		// Token: 0x06015232 RID: 86578 RVA: 0x001F14AC File Offset: 0x001EF6AC
		public void RegisterBulletActionClass(EKuroBulletCoreActionType ActionType, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UBulletActionBase> ActionClass)
		{
			UBulletWorld.__RegisterBulletActionClass_Internal(base.NativePtr, ActionType, ActionClass._NativePtr);
		}

		// Token: 0x06015233 RID: 86579 RVA: 0x001F14C0 File Offset: 0x001EF6C0
		[NullableContext(2)]
		public UObject PoolGet(UClassStackOnlyPtr Cls)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UBulletWorld.__PoolGet_Internal(base.NativePtr, Cls._NativePtr));
		}

		// Token: 0x06015234 RID: 86580 RVA: 0x001F14D8 File Offset: 0x001EF6D8
		[NullableContext(2)]
		public bool InitBulletConfig(UBulletEntity BulletEntity, long BulletConfigId, UDataTable OwnerBulletDataTable)
		{
			return UBulletWorld.__InitBulletConfig_Internal(base.NativePtr, (BulletEntity != null) ? BulletEntity.NativePtr : IntPtr.Zero, BulletConfigId, (OwnerBulletDataTable != null) ? OwnerBulletDataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015235 RID: 86581 RVA: 0x001F1506 File Offset: 0x001EF706
		public int GetBulletGroupActiveCount(int GroupId)
		{
			return UBulletWorld.__GetBulletGroupActiveCount_Internal(base.NativePtr, GroupId);
		}

		// Token: 0x06015236 RID: 86582 RVA: 0x001F1514 File Offset: 0x001EF714
		[NullableContext(2)]
		public UBulletEntity GetBulletEntity(int EntityId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletEntity>(UBulletWorld.__GetBulletEntity_Internal(base.NativePtr, EntityId));
		}

		// Token: 0x06015237 RID: 86583 RVA: 0x001F1527 File Offset: 0x001EF727
		[NullableContext(2)]
		public bool FindBulletConfig(long BulletConfigId, UDataTable OwnerBulletDataTable, ref FKuroBulletData OutRow)
		{
			return UBulletWorld.__FindBulletConfig_Internal(base.NativePtr, BulletConfigId, (OwnerBulletDataTable != null) ? OwnerBulletDataTable.NativePtr : IntPtr.Zero, (OutRow ?? new FKuroBulletData()).NativePtr);
		}

		// Token: 0x06015238 RID: 86584 RVA: 0x001F1555 File Offset: 0x001EF755
		public void EnableFlatGroundByAbovePoint(FVectorDouble AbovePoint)
		{
			UBulletWorld.__EnableFlatGroundByAbovePoint_Internal(base.NativePtr, AbovePoint);
		}

		// Token: 0x06015239 RID: 86585 RVA: 0x001F1563 File Offset: 0x001EF763
		public void EnableFlatGround(double Height)
		{
			UBulletWorld.__EnableFlatGround_Internal(base.NativePtr, Height);
		}

		// Token: 0x0601523A RID: 86586 RVA: 0x001F1571 File Offset: 0x001EF771
		public void DisableFlatGround()
		{
			UBulletWorld.__DisableFlatGround_Internal(base.NativePtr);
		}

		// Token: 0x0601523B RID: 86587 RVA: 0x001F157E File Offset: 0x001EF77E
		[NullableContext(2)]
		public void DestroyPatternsByOwner(AActor Owner)
		{
			UBulletWorld.__DestroyPatternsByOwner_Internal(base.NativePtr, (Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601523C RID: 86588 RVA: 0x001F159B File Offset: 0x001EF79B
		public void DestroyPattern(int PatternId)
		{
			UBulletWorld.__DestroyPattern_Internal(base.NativePtr, PatternId);
		}

		// Token: 0x0601523D RID: 86589 RVA: 0x001F15A9 File Offset: 0x001EF7A9
		public void DestroyBulletById(int BulletEntityId, bool ClearContext)
		{
			UBulletWorld.__DestroyBulletById_Internal(base.NativePtr, BulletEntityId, ClearContext);
		}

		// Token: 0x0601523E RID: 86590 RVA: 0x001F15B8 File Offset: 0x001EF7B8
		[NullableContext(2)]
		public void DestroyBullet(UBulletEntity BulletEntity, bool ClearContext)
		{
			UBulletWorld.__DestroyBullet_Internal(base.NativePtr, (BulletEntity != null) ? BulletEntity.NativePtr : IntPtr.Zero, ClearContext);
		}

		// Token: 0x0601523F RID: 86591 RVA: 0x001F15D6 File Offset: 0x001EF7D6
		public void DestroyAllPatterns()
		{
			UBulletWorld.__DestroyAllPatterns_Internal(base.NativePtr);
		}

		// Token: 0x06015240 RID: 86592 RVA: 0x001F15E3 File Offset: 0x001EF7E3
		[NullableContext(2)]
		public void DestroyAllBulletsByOwner(AActor Owner)
		{
			UBulletWorld.__DestroyAllBulletsByOwner_Internal(base.NativePtr, (Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015241 RID: 86593 RVA: 0x001F1600 File Offset: 0x001EF800
		[NullableContext(2)]
		public int CreateBullet(IBulletContext BulletContext, long BulletConfigId, in FBulletSpawnParams SpawnParams)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(BulletContext, (BulletContext != null) ? BulletContext.InterfaceOffset() : 0);
			return UBulletWorld.__CreateBullet_Internal(base.NativePtr, fscriptInterface, BulletConfigId, (SpawnParams ?? new FBulletSpawnParams()).NativePtr);
		}

		// Token: 0x06015242 RID: 86594 RVA: 0x001F163F File Offset: 0x001EF83F
		public void ClearCommonBulletDataTable()
		{
			UBulletWorld.__ClearCommonBulletDataTable_Internal(base.NativePtr);
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x001F164C File Offset: 0x001EF84C
		public void ClearCameraShakeConfig()
		{
			UBulletWorld.__ClearCameraShakeConfig_Internal(base.NativePtr);
		}

		// Token: 0x06015244 RID: 86596 RVA: 0x001F1659 File Offset: 0x001EF859
		[NullableContext(2)]
		public void AddCommonBulletDataTable(UDataTable DataTable)
		{
			UBulletWorld.__AddCommonBulletDataTable_Internal(base.NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015245 RID: 86597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnPattern_Internal(IntPtr @this, in FScriptInterface PatternContext, IntPtr PatternDA);

		// Token: 0x06015246 RID: 86598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowEmitterDebugDraw_Internal(IntPtr @this, bool Value);

		// Token: 0x06015247 RID: 86599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowBulletCollision_Internal(IntPtr @this, bool Value);

		// Token: 0x06015248 RID: 86600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKFCAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x06015249 RID: 86601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCameraShakeCooldown_Internal(IntPtr @this, double Cooldown);

		// Token: 0x0601524A RID: 86602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBulletGroupMaxCountSingle_Internal(IntPtr @this, int GroupId, int MaxCount);

		// Token: 0x0601524B RID: 86603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCameraShakeConfig_Internal(IntPtr @this, int ShakeKey, in FString ShakePath);

		// Token: 0x0601524C RID: 86604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBulletLogicActionClass_Internal(IntPtr @this, IntPtr LogicAssetClass, IntPtr ActionClass);

		// Token: 0x0601524D RID: 86605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBulletActionClassByTag_Internal(IntPtr @this, FGameplayTag ActionTag, IntPtr ActionClass);

		// Token: 0x0601524E RID: 86606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBulletActionClass_Internal(IntPtr @this, EKuroBulletCoreActionType ActionType, IntPtr ActionClass);

		// Token: 0x0601524F RID: 86607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PoolGet_Internal(IntPtr @this, IntPtr Cls);

		// Token: 0x06015250 RID: 86608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitBulletConfig_Internal(IntPtr @this, IntPtr BulletEntity, long BulletConfigId, IntPtr OwnerBulletDataTable);

		// Token: 0x06015251 RID: 86609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBulletGroupActiveCount_Internal(IntPtr @this, int GroupId);

		// Token: 0x06015252 RID: 86610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletEntity_Internal(IntPtr @this, int EntityId);

		// Token: 0x06015253 RID: 86611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindBulletConfig_Internal(IntPtr @this, long BulletConfigId, IntPtr OwnerBulletDataTable, IntPtr OutRow);

		// Token: 0x06015254 RID: 86612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFlatGroundByAbovePoint_Internal(IntPtr @this, FVectorDouble AbovePoint);

		// Token: 0x06015255 RID: 86613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFlatGround_Internal(IntPtr @this, double Height);

		// Token: 0x06015256 RID: 86614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableFlatGround_Internal(IntPtr @this);

		// Token: 0x06015257 RID: 86615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPatternsByOwner_Internal(IntPtr @this, IntPtr Owner);

		// Token: 0x06015258 RID: 86616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPattern_Internal(IntPtr @this, int PatternId);

		// Token: 0x06015259 RID: 86617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyBulletById_Internal(IntPtr @this, int BulletEntityId, bool ClearContext);

		// Token: 0x0601525A RID: 86618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyBullet_Internal(IntPtr @this, IntPtr BulletEntity, bool ClearContext);

		// Token: 0x0601525B RID: 86619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllPatterns_Internal(IntPtr @this);

		// Token: 0x0601525C RID: 86620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllBulletsByOwner_Internal(IntPtr @this, IntPtr Owner);

		// Token: 0x0601525D RID: 86621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateBullet_Internal(IntPtr @this, in FScriptInterface BulletContext, long BulletConfigId, IntPtr SpawnParams);

		// Token: 0x0601525E RID: 86622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCommonBulletDataTable_Internal(IntPtr @this);

		// Token: 0x0601525F RID: 86623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCameraShakeConfig_Internal(IntPtr @this);

		// Token: 0x06015260 RID: 86624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCommonBulletDataTable_Internal(IntPtr @this, IntPtr DataTable);

		// Token: 0x06015261 RID: 86625 RVA: 0x001F1676 File Offset: 0x001EF876
		static UBulletWorld()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletWorld");
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x001F1684 File Offset: 0x001EF884
		protected UBulletWorld(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7F8 RID: 47096
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld";

		// Token: 0x0400B7F9 RID: 47097
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7FA RID: 47098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B7FB RID: 47099
		public static IntPtr __OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400B7FC RID: 47100
		public static IntPtr __OnBulletCameraShake__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400B7FD RID: 47101
		internal static int __PropertyOffset_StickGroundLineTrace;

		// Token: 0x0400B7FE RID: 47102
		internal static int __PropertyOffset_bFlatGround;

		// Token: 0x0400B7FF RID: 47103
		internal static int __PropertyOffset_GroundZ;

		// Token: 0x0400B800 RID: 47104
		internal static int __PropertyOffset_ForceUpdateOverlap;

		// Token: 0x0400B801 RID: 47105
		internal static int __PropertyOffset_OnBulletModifyBuff;

		// Token: 0x0400B802 RID: 47106
		[Nullable(2)]
		private FOnBulletModifyBuff _OnBulletModifyBuff;

		// Token: 0x0400B803 RID: 47107
		internal static int __PropertyOffset_OnBulletCameraShake;

		// Token: 0x0400B804 RID: 47108
		[Nullable(2)]
		private FOnBulletCameraShake _OnBulletCameraShake;

		// Token: 0x0400B805 RID: 47109
		internal static int __PropertyOffset_EnableRecycledId;

		// Token: 0x0400B806 RID: 47110
		internal static int __PropertyOffset_MaxBulletCount;

		// Token: 0x0400B807 RID: 47111
		internal static int __PropertyOffset_CreateBulletBudgetPerSecondMicroseconds;

		// Token: 0x0400B808 RID: 47112
		internal static int __PropertyOffset_CreateBulletBudgetBurstSeconds;

		// Token: 0x0400B809 RID: 47113
		internal static int __PropertyOffset_EnableBulletNoActor;

		// Token: 0x0400B80A RID: 47114
		internal static int __PropertyOffset_CommonBulletDataTableList;

		// Token: 0x0400B80B RID: 47115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _CommonBulletDataTableList;

		// Token: 0x0400B80C RID: 47116
		internal static int __PropertyOffset_BulletEntityMap;

		// Token: 0x0400B80D RID: 47117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UBulletEntity> _BulletEntityMap;

		// Token: 0x0400B80E RID: 47118
		internal static int __PropertyOffset_BulletPatternMap;

		// Token: 0x0400B80F RID: 47119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroBulletPattern> _BulletPatternMap;

		// Token: 0x0400B810 RID: 47120
		internal static int __PropertyOffset_GroundObstacleObject;

		// Token: 0x0400B811 RID: 47121
		internal static int __PropertyOffset_ObjectHold;

		// Token: 0x0400B812 RID: 47122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectHold;

		// Token: 0x0400B813 RID: 47123
		internal static int __PropertyOffset_DeferredSpawnQueue;

		// Token: 0x0400B814 RID: 47124
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDeferredBulletSpawn> _DeferredSpawnQueue;

		// Token: 0x0400B815 RID: 47125
		internal static int __PropertyOffset_KFCAlgorithm;
	}
}
