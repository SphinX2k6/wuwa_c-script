using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000327 RID: 807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.BulletWorld")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class UBulletWorld : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005487 RID: 21639 RVA: 0x0007665F File Offset: 0x0007485F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletWorld._ClassPtr;
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0007666C File Offset: 0x0007486C
		public UBulletWorld() : this(BuiltinUtils.AllocNativeUObject(UBulletWorld.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00076694 File Offset: 0x00074894
		public UBulletWorld(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletWorld.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x000766C7 File Offset: 0x000748C7
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x000766DB File Offset: 0x000748DB
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

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x000766F0 File Offset: 0x000748F0
		// (set) Token: 0x0600548D RID: 21645 RVA: 0x00076700 File Offset: 0x00074900
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

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x00076711 File Offset: 0x00074911
		// (set) Token: 0x0600548F RID: 21647 RVA: 0x00076721 File Offset: 0x00074921
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

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x00076732 File Offset: 0x00074932
		// (set) Token: 0x06005491 RID: 21649 RVA: 0x00076742 File Offset: 0x00074942
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

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x00076754 File Offset: 0x00074954
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x0007678D File Offset: 0x0007498D
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

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x000767B0 File Offset: 0x000749B0
		// (set) Token: 0x06005495 RID: 21653 RVA: 0x000767E9 File Offset: 0x000749E9
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

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x0007680A File Offset: 0x00074A0A
		// (set) Token: 0x06005497 RID: 21655 RVA: 0x0007681A File Offset: 0x00074A1A
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

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x0007682B File Offset: 0x00074A2B
		// (set) Token: 0x06005499 RID: 21657 RVA: 0x0007683B File Offset: 0x00074A3B
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

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600549A RID: 21658 RVA: 0x0007684C File Offset: 0x00074A4C
		// (set) Token: 0x0600549B RID: 21659 RVA: 0x0007685C File Offset: 0x00074A5C
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

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x0007686D File Offset: 0x00074A6D
		// (set) Token: 0x0600549D RID: 21661 RVA: 0x0007687D File Offset: 0x00074A7D
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x0007688E File Offset: 0x00074A8E
		// (set) Token: 0x0600549F RID: 21663 RVA: 0x0007689E File Offset: 0x00074A9E
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060054A0 RID: 21664 RVA: 0x000768B0 File Offset: 0x00074AB0
		// (set) Token: 0x060054A1 RID: 21665 RVA: 0x000768E9 File Offset: 0x00074AE9
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x000768F8 File Offset: 0x00074AF8
		// (set) Token: 0x060054A3 RID: 21667 RVA: 0x00076931 File Offset: 0x00074B31
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

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x00076940 File Offset: 0x00074B40
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x00076979 File Offset: 0x00074B79
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

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00076987 File Offset: 0x00074B87
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x0007699B File Offset: 0x00074B9B
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

		// Token: 0x060054A8 RID: 21672 RVA: 0x000769B0 File Offset: 0x00074BB0
		[NullableContext(2)]
		public int SpawnPattern(IBulletContext PatternContext, UKuroBulletPatternDataAsset PatternDA)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(PatternContext, (PatternContext != null) ? PatternContext.InterfaceOffset() : 0);
			return UBulletWorld.__SpawnPattern_Internal(base.NativePtr, fscriptInterface, (PatternDA != null) ? PatternDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x000769EE File Offset: 0x00074BEE
		public void SetShowEmitterDebugDraw(bool Value)
		{
			UBulletWorld.__SetShowEmitterDebugDraw_Internal(base.NativePtr, Value);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x000769FC File Offset: 0x00074BFC
		public void SetShowBulletCollision(bool Value)
		{
			UBulletWorld.__SetShowBulletCollision_Internal(base.NativePtr, Value);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00076A0A File Offset: 0x00074C0A
		[NullableContext(2)]
		public void SetKFCAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UBulletWorld.__SetKFCAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00076A27 File Offset: 0x00074C27
		public void SetCameraShakeCooldown(double Cooldown)
		{
			UBulletWorld.__SetCameraShakeCooldown_Internal(base.NativePtr, Cooldown);
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00076A35 File Offset: 0x00074C35
		public void SetBulletGroupMaxCountSingle(int GroupId, int MaxCount)
		{
			UBulletWorld.__SetBulletGroupMaxCountSingle_Internal(base.NativePtr, GroupId, MaxCount);
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00076A44 File Offset: 0x00074C44
		public unsafe void RegisterCameraShakeConfig(int ShakeKey, string ShakePath)
		{
			FString fstring = FString.AllocTemp(ShakePath);
			UBulletWorld.__RegisterCameraShakeConfig_Internal(base.NativePtr, ShakeKey, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00076A6F File Offset: 0x00074C6F
		public void RegisterBulletActionClassByTag(FGameplayTag ActionTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UBulletActionBase> ActionClass)
		{
			UBulletWorld.__RegisterBulletActionClassByTag_Internal(base.NativePtr, ActionTag, ActionClass._NativePtr);
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00076A83 File Offset: 0x00074C83
		[NullableContext(2)]
		public UObject PoolGet(UClassStackOnlyPtr Cls)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UBulletWorld.__PoolGet_Internal(base.NativePtr, Cls._NativePtr));
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00076A9B File Offset: 0x00074C9B
		[NullableContext(2)]
		public bool InitBulletConfig(UBulletEntity BulletEntity, long BulletConfigId, UDataTable OwnerBulletDataTable)
		{
			return UBulletWorld.__InitBulletConfig_Internal(base.NativePtr, (BulletEntity != null) ? BulletEntity.NativePtr : IntPtr.Zero, BulletConfigId, (OwnerBulletDataTable != null) ? OwnerBulletDataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00076AC9 File Offset: 0x00074CC9
		public int GetBulletGroupActiveCount(int GroupId)
		{
			return UBulletWorld.__GetBulletGroupActiveCount_Internal(base.NativePtr, GroupId);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00076AD7 File Offset: 0x00074CD7
		[NullableContext(2)]
		public UBulletEntity GetBulletEntity(int EntityId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletEntity>(UBulletWorld.__GetBulletEntity_Internal(base.NativePtr, EntityId));
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00076AEA File Offset: 0x00074CEA
		public void EnableFlatGroundByAbovePoint(FVectorDouble AbovePoint)
		{
			UBulletWorld.__EnableFlatGroundByAbovePoint_Internal(base.NativePtr, AbovePoint);
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00076AF8 File Offset: 0x00074CF8
		public void EnableFlatGround(double Height)
		{
			UBulletWorld.__EnableFlatGround_Internal(base.NativePtr, Height);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00076B06 File Offset: 0x00074D06
		public void DisableFlatGround()
		{
			UBulletWorld.__DisableFlatGround_Internal(base.NativePtr);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00076B13 File Offset: 0x00074D13
		[NullableContext(2)]
		public void DestroyPatternsByOwner(AActor Owner)
		{
			UBulletWorld.__DestroyPatternsByOwner_Internal(base.NativePtr, (Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00076B30 File Offset: 0x00074D30
		public void DestroyPattern(int PatternId)
		{
			UBulletWorld.__DestroyPattern_Internal(base.NativePtr, PatternId);
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00076B3E File Offset: 0x00074D3E
		public void DestroyBulletById(int BulletEntityId, bool ClearContext)
		{
			UBulletWorld.__DestroyBulletById_Internal(base.NativePtr, BulletEntityId, ClearContext);
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00076B4D File Offset: 0x00074D4D
		[NullableContext(2)]
		public void DestroyBullet(UBulletEntity BulletEntity, bool ClearContext)
		{
			UBulletWorld.__DestroyBullet_Internal(base.NativePtr, (BulletEntity != null) ? BulletEntity.NativePtr : IntPtr.Zero, ClearContext);
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00076B6B File Offset: 0x00074D6B
		public void DestroyAllPatterns()
		{
			UBulletWorld.__DestroyAllPatterns_Internal(base.NativePtr);
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00076B78 File Offset: 0x00074D78
		[NullableContext(2)]
		public void DestroyAllBulletsByOwner(AActor Owner)
		{
			UBulletWorld.__DestroyAllBulletsByOwner_Internal(base.NativePtr, (Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00076B98 File Offset: 0x00074D98
		[NullableContext(2)]
		public int CreateBullet(IBulletContext BulletContext, long BulletConfigId, in FBulletSpawnParams SpawnParams)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(BulletContext, (BulletContext != null) ? BulletContext.InterfaceOffset() : 0);
			return UBulletWorld.__CreateBullet_Internal(base.NativePtr, fscriptInterface, BulletConfigId, (SpawnParams ?? new FBulletSpawnParams()).NativePtr);
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00076BD7 File Offset: 0x00074DD7
		public void ClearCommonBulletDataTable()
		{
			UBulletWorld.__ClearCommonBulletDataTable_Internal(base.NativePtr);
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00076BE4 File Offset: 0x00074DE4
		public void ClearCameraShakeConfig()
		{
			UBulletWorld.__ClearCameraShakeConfig_Internal(base.NativePtr);
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00076BF1 File Offset: 0x00074DF1
		[NullableContext(2)]
		public void AddCommonBulletDataTable(UDataTable DataTable)
		{
			UBulletWorld.__AddCommonBulletDataTable_Internal(base.NativePtr, (DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054C1 RID: 21697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnPattern_Internal(IntPtr @this, in FScriptInterface PatternContext, IntPtr PatternDA);

		// Token: 0x060054C2 RID: 21698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowEmitterDebugDraw_Internal(IntPtr @this, bool Value);

		// Token: 0x060054C3 RID: 21699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowBulletCollision_Internal(IntPtr @this, bool Value);

		// Token: 0x060054C4 RID: 21700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKFCAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x060054C5 RID: 21701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCameraShakeCooldown_Internal(IntPtr @this, double Cooldown);

		// Token: 0x060054C6 RID: 21702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBulletGroupMaxCountSingle_Internal(IntPtr @this, int GroupId, int MaxCount);

		// Token: 0x060054C7 RID: 21703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterCameraShakeConfig_Internal(IntPtr @this, int ShakeKey, in FString ShakePath);

		// Token: 0x060054C8 RID: 21704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterBulletActionClassByTag_Internal(IntPtr @this, FGameplayTag ActionTag, IntPtr ActionClass);

		// Token: 0x060054C9 RID: 21705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PoolGet_Internal(IntPtr @this, IntPtr Cls);

		// Token: 0x060054CA RID: 21706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitBulletConfig_Internal(IntPtr @this, IntPtr BulletEntity, long BulletConfigId, IntPtr OwnerBulletDataTable);

		// Token: 0x060054CB RID: 21707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBulletGroupActiveCount_Internal(IntPtr @this, int GroupId);

		// Token: 0x060054CC RID: 21708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletEntity_Internal(IntPtr @this, int EntityId);

		// Token: 0x060054CD RID: 21709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFlatGroundByAbovePoint_Internal(IntPtr @this, FVectorDouble AbovePoint);

		// Token: 0x060054CE RID: 21710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableFlatGround_Internal(IntPtr @this, double Height);

		// Token: 0x060054CF RID: 21711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableFlatGround_Internal(IntPtr @this);

		// Token: 0x060054D0 RID: 21712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPatternsByOwner_Internal(IntPtr @this, IntPtr Owner);

		// Token: 0x060054D1 RID: 21713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPattern_Internal(IntPtr @this, int PatternId);

		// Token: 0x060054D2 RID: 21714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyBulletById_Internal(IntPtr @this, int BulletEntityId, bool ClearContext);

		// Token: 0x060054D3 RID: 21715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyBullet_Internal(IntPtr @this, IntPtr BulletEntity, bool ClearContext);

		// Token: 0x060054D4 RID: 21716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllPatterns_Internal(IntPtr @this);

		// Token: 0x060054D5 RID: 21717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllBulletsByOwner_Internal(IntPtr @this, IntPtr Owner);

		// Token: 0x060054D6 RID: 21718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateBullet_Internal(IntPtr @this, in FScriptInterface BulletContext, long BulletConfigId, IntPtr SpawnParams);

		// Token: 0x060054D7 RID: 21719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCommonBulletDataTable_Internal(IntPtr @this);

		// Token: 0x060054D8 RID: 21720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCameraShakeConfig_Internal(IntPtr @this);

		// Token: 0x060054D9 RID: 21721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCommonBulletDataTable_Internal(IntPtr @this, IntPtr DataTable);

		// Token: 0x060054DA RID: 21722 RVA: 0x00076C0E File Offset: 0x00074E0E
		static UBulletWorld()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletWorld");
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00076C1C File Offset: 0x00074E1C
		protected UBulletWorld(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400228F RID: 8847
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld";

		// Token: 0x04002290 RID: 8848
		private static IntPtr _ClassPtr;

		// Token: 0x04002291 RID: 8849
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002292 RID: 8850
		public static IntPtr __OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04002293 RID: 8851
		public static IntPtr __OnBulletCameraShake__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04002294 RID: 8852
		internal static int __PropertyOffset_StickGroundLineTrace;

		// Token: 0x04002295 RID: 8853
		internal static int __PropertyOffset_bFlatGround;

		// Token: 0x04002296 RID: 8854
		internal static int __PropertyOffset_GroundZ;

		// Token: 0x04002297 RID: 8855
		internal static int __PropertyOffset_ForceUpdateOverlap;

		// Token: 0x04002298 RID: 8856
		internal static int __PropertyOffset_OnBulletModifyBuff;

		// Token: 0x04002299 RID: 8857
		[Nullable(2)]
		private FOnBulletModifyBuff _OnBulletModifyBuff;

		// Token: 0x0400229A RID: 8858
		internal static int __PropertyOffset_OnBulletCameraShake;

		// Token: 0x0400229B RID: 8859
		[Nullable(2)]
		private FOnBulletCameraShake _OnBulletCameraShake;

		// Token: 0x0400229C RID: 8860
		internal static int __PropertyOffset_EnableRecycledId;

		// Token: 0x0400229D RID: 8861
		internal static int __PropertyOffset_MaxBulletCount;

		// Token: 0x0400229E RID: 8862
		internal static int __PropertyOffset_CreateBulletBudgetPerSecondMicroseconds;

		// Token: 0x0400229F RID: 8863
		internal static int __PropertyOffset_CreateBulletBudgetBurstSeconds;

		// Token: 0x040022A0 RID: 8864
		internal static int __PropertyOffset_EnableBulletNoActor;

		// Token: 0x040022A1 RID: 8865
		internal static int __PropertyOffset_CommonBulletDataTableList;

		// Token: 0x040022A2 RID: 8866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _CommonBulletDataTableList;

		// Token: 0x040022A3 RID: 8867
		internal static int __PropertyOffset_BulletEntityMap;

		// Token: 0x040022A4 RID: 8868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UBulletEntity> _BulletEntityMap;

		// Token: 0x040022A5 RID: 8869
		internal static int __PropertyOffset_ObjectHold;

		// Token: 0x040022A6 RID: 8870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectHold;

		// Token: 0x040022A7 RID: 8871
		internal static int __PropertyOffset_KFCAlgorithm;
	}
}
