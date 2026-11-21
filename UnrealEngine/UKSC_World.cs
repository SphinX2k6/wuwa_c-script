using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000594 RID: 1428
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_World")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class UKSC_World : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600813D RID: 33085 RVA: 0x000BEC04 File Offset: 0x000BCE04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_World._ClassPtr;
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x000BEC10 File Offset: 0x000BCE10
		public UKSC_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x000BEC38 File Offset: 0x000BCE38
		public UKSC_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x000BEC6C File Offset: 0x000BCE6C
		// (set) Token: 0x06008141 RID: 33089 RVA: 0x000BECA5 File Offset: 0x000BCEA5
		public TArray<AKSC_Entity> Entities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._Entities_) == null)
				{
					result = (this._Entities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_Entities_, this));
				}
				return result;
			}
			set
			{
				this.Entities_.CopyAssign(value);
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06008142 RID: 33090 RVA: 0x000BECB4 File Offset: 0x000BCEB4
		// (set) Token: 0x06008143 RID: 33091 RVA: 0x000BECED File Offset: 0x000BCEED
		public TMap<int, AKSC_Entity> EntityIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, AKSC_Entity> result;
				if ((result = this._EntityIdMap) == null)
				{
					result = (this._EntityIdMap = new TMap<int, AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_EntityIdMap, this));
				}
				return result;
			}
			set
			{
				this.EntityIdMap.CopyAssign(value);
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x000BECFC File Offset: 0x000BCEFC
		// (set) Token: 0x06008145 RID: 33093 RVA: 0x000BED35 File Offset: 0x000BCF35
		public TArray<AKSC_Entity> DeadEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._DeadEntities_) == null)
				{
					result = (this._DeadEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_DeadEntities_, this));
				}
				return result;
			}
			set
			{
				this.DeadEntities_.CopyAssign(value);
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x000BED44 File Offset: 0x000BCF44
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x000BED7D File Offset: 0x000BCF7D
		public TArray<AKSC_Entity> ShowHeadUIEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ShowHeadUIEntities_) == null)
				{
					result = (this._ShowHeadUIEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ShowHeadUIEntities_, this));
				}
				return result;
			}
			set
			{
				this.ShowHeadUIEntities_.CopyAssign(value);
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x000BED8C File Offset: 0x000BCF8C
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x000BEDC5 File Offset: 0x000BCFC5
		public TArray<AKSC_Entity> ToRemoveEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ToRemoveEntities_) == null)
				{
					result = (this._ToRemoveEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToRemoveEntities_, this));
				}
				return result;
			}
			set
			{
				this.ToRemoveEntities_.CopyAssign(value);
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
		// (set) Token: 0x0600814B RID: 33099 RVA: 0x000BEE0D File Offset: 0x000BD00D
		public TArray<AKSC_Entity> ToAddEntities_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_Entity> result;
				if ((result = this._ToAddEntities_) == null)
				{
					result = (this._ToAddEntities_ = new TArray<AKSC_Entity>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToAddEntities_, this));
				}
				return result;
			}
			set
			{
				this.ToAddEntities_.CopyAssign(value);
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600814C RID: 33100 RVA: 0x000BEE1C File Offset: 0x000BD01C
		// (set) Token: 0x0600814D RID: 33101 RVA: 0x000BEE55 File Offset: 0x000BD055
		public TArray<FKSC_LandFireContext> ToAddLandFire_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_LandFireContext> result;
				if ((result = this._ToAddLandFire_) == null)
				{
					result = (this._ToAddLandFire_ = new TArray<FKSC_LandFireContext>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_ToAddLandFire_, this));
				}
				return result;
			}
			set
			{
				this.ToAddLandFire_.CopyAssign(value);
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x000BEE64 File Offset: 0x000BD064
		// (set) Token: 0x0600814F RID: 33103 RVA: 0x000BEE9D File Offset: 0x000BD09D
		public TMap<AKSC_Entity, AActor> RenderActorMap_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKSC_Entity, AActor> result;
				if ((result = this._RenderActorMap_) == null)
				{
					result = (this._RenderActorMap_ = new TMap<AKSC_Entity, AActor>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_RenderActorMap_, this));
				}
				return result;
			}
			set
			{
				this.RenderActorMap_.CopyAssign(value);
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06008150 RID: 33104 RVA: 0x000BEEAC File Offset: 0x000BD0AC
		// (set) Token: 0x06008151 RID: 33105 RVA: 0x000BEEE5 File Offset: 0x000BD0E5
		public TMap<EKSC_AttrType, EKSC_AttrType> AttributeIdsWithMax
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, EKSC_AttrType> result;
				if ((result = this._AttributeIdsWithMax) == null)
				{
					result = (this._AttributeIdsWithMax = new TMap<EKSC_AttrType, EKSC_AttrType>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_AttributeIdsWithMax, this));
				}
				return result;
			}
			set
			{
				this.AttributeIdsWithMax.CopyAssign(value);
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06008152 RID: 33106 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		// (set) Token: 0x06008153 RID: 33107 RVA: 0x000BEF2D File Offset: 0x000BD12D
		public TMap<EKSC_AttrType, int> AttributeEffectiveDamageType
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._AttributeEffectiveDamageType) == null)
				{
					result = (this._AttributeEffectiveDamageType = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_AttributeEffectiveDamageType, this));
				}
				return result;
			}
			set
			{
				this.AttributeEffectiveDamageType.CopyAssign(value);
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06008154 RID: 33108 RVA: 0x000BEF3C File Offset: 0x000BD13C
		// (set) Token: 0x06008155 RID: 33109 RVA: 0x000BEF75 File Offset: 0x000BD175
		public FOnKSCBatchRemoveAfter OnKSCBatchRemoveAfter
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCBatchRemoveAfter result;
				if ((result = this._OnKSCBatchRemoveAfter) == null)
				{
					result = (this._OnKSCBatchRemoveAfter = new FOnKSCBatchRemoveAfter(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCBatchRemoveAfter, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCBatchRemoveAfter, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x000BEF98 File Offset: 0x000BD198
		// (set) Token: 0x06008157 RID: 33111 RVA: 0x000BEFD1 File Offset: 0x000BD1D1
		public FOnKSCLandFireSpawn OnKSCLandFireSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCLandFireSpawn result;
				if ((result = this._OnKSCLandFireSpawn) == null)
				{
					result = (this._OnKSCLandFireSpawn = new FOnKSCLandFireSpawn(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCLandFireSpawn, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCLandFireSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06008158 RID: 33112 RVA: 0x000BEFF4 File Offset: 0x000BD1F4
		// (set) Token: 0x06008159 RID: 33113 RVA: 0x000BF02D File Offset: 0x000BD22D
		public FOnKSCEntitySpawn OnKSCEntitySpawn
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCEntitySpawn result;
				if ((result = this._OnKSCEntitySpawn) == null)
				{
					result = (this._OnKSCEntitySpawn = new FOnKSCEntitySpawn(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySpawn, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x000BF050 File Offset: 0x000BD250
		// (set) Token: 0x0600815B RID: 33115 RVA: 0x000BF089 File Offset: 0x000BD289
		public FOnKSCEntitySummon OnKSCEntitySummon
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCEntitySummon result;
				if ((result = this._OnKSCEntitySummon) == null)
				{
					result = (this._OnKSCEntitySummon = new FOnKSCEntitySummon(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySummon, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_OnKSCEntitySummon, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x000BF0AC File Offset: 0x000BD2AC
		// (set) Token: 0x0600815D RID: 33117 RVA: 0x000BF0E5 File Offset: 0x000BD2E5
		public TMap<EKSC_HeadUiType, UClass> HeadUiHandleClassMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_HeadUiType, UClass> result;
				if ((result = this._HeadUiHandleClassMap) == null)
				{
					result = (this._HeadUiHandleClassMap = new TMap<EKSC_HeadUiType, UClass>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_HeadUiHandleClassMap, this));
				}
				return result;
			}
			set
			{
				this.HeadUiHandleClassMap.CopyAssign(value);
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x0600815E RID: 33118 RVA: 0x000BF0F3 File Offset: 0x000BD2F3
		// (set) Token: 0x0600815F RID: 33119 RVA: 0x000BF107 File Offset: 0x000BD307
		[Nullable(2)]
		public unsafe UKSC_DamageHandler DamageHandler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DamageHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageHandler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageHandler, value);
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x000BF11C File Offset: 0x000BD31C
		// (set) Token: 0x06008161 RID: 33121 RVA: 0x000BF155 File Offset: 0x000BD355
		public TSet<UObject> PoolHelper_
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._PoolHelper_) == null)
				{
					result = (this._PoolHelper_ = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_PoolHelper_, this));
				}
				return result;
			}
			set
			{
				this.PoolHelper_.CopyAssign(value);
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06008162 RID: 33122 RVA: 0x000BF164 File Offset: 0x000BD364
		// (set) Token: 0x06008163 RID: 33123 RVA: 0x000BF19D File Offset: 0x000BD39D
		public TMap<UKSC_DA_Buff, int> LoadedBuffDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, int> result;
				if ((result = this._LoadedBuffDa) == null)
				{
					result = (this._LoadedBuffDa = new TMap<UKSC_DA_Buff, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedBuffDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedBuffDa.CopyAssign(value);
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x000BF1AC File Offset: 0x000BD3AC
		// (set) Token: 0x06008165 RID: 33125 RVA: 0x000BF1E5 File Offset: 0x000BD3E5
		public TMap<UKSC_DA_Entity, int> LoadedEntityDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Entity, int> result;
				if ((result = this._LoadedEntityDa) == null)
				{
					result = (this._LoadedEntityDa = new TMap<UKSC_DA_Entity, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedEntityDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedEntityDa.CopyAssign(value);
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x000BF1F4 File Offset: 0x000BD3F4
		// (set) Token: 0x06008167 RID: 33127 RVA: 0x000BF22D File Offset: 0x000BD42D
		public TMap<UKSC_DA_Skill, int> LoadedSkillDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Skill, int> result;
				if ((result = this._LoadedSkillDa) == null)
				{
					result = (this._LoadedSkillDa = new TMap<UKSC_DA_Skill, int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_LoadedSkillDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedSkillDa.CopyAssign(value);
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06008168 RID: 33128 RVA: 0x000BF23B File Offset: 0x000BD43B
		// (set) Token: 0x06008169 RID: 33129 RVA: 0x000BF24F File Offset: 0x000BD44F
		[Nullable(2)]
		public unsafe UKSC_DamageId DamageData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DamageId>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_DamageData, value);
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600816A RID: 33130 RVA: 0x000BF264 File Offset: 0x000BD464
		// (set) Token: 0x0600816B RID: 33131 RVA: 0x000BF278 File Offset: 0x000BD478
		[Nullable(2)]
		public unsafe UKSC_BuffId BuffData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_BuffId>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_BuffData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_BuffData, value);
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x000BF290 File Offset: 0x000BD490
		// (set) Token: 0x0600816D RID: 33133 RVA: 0x000BF2C9 File Offset: 0x000BD4C9
		public TSet<int> BroadcastBuffIdSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._BroadcastBuffIdSet) == null)
				{
					result = (this._BroadcastBuffIdSet = new TSet<int>(base.NativePtr + (IntPtr)UKSC_World.__PropertyOffset_BroadcastBuffIdSet, this));
				}
				return result;
			}
			set
			{
				this.BroadcastBuffIdSet.CopyAssign(value);
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x000BF2D7 File Offset: 0x000BD4D7
		// (set) Token: 0x0600816F RID: 33135 RVA: 0x000BF2EB File Offset: 0x000BD4EB
		[Nullable(2)]
		public unsafe UKSC_SceneMovement SceneMovement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SceneMovement>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_SceneMovement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_SceneMovement, value);
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06008170 RID: 33136 RVA: 0x000BF300 File Offset: 0x000BD500
		// (set) Token: 0x06008171 RID: 33137 RVA: 0x000BF314 File Offset: 0x000BD514
		[Nullable(2)]
		public unsafe UKuroFastCollisionAlgorithm KFCAlgorithm
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFastCollisionAlgorithm>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_KFCAlgorithm);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_World.__PropertyOffset_KFCAlgorithm, value);
			}
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x000BF329 File Offset: 0x000BD529
		public void SetWorldTimeDilation(float NewTimeDilation)
		{
			UKSC_World.__SetWorldTimeDilation_Internal(base.NativePtr, NewTimeDilation);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x000BF337 File Offset: 0x000BD537
		[NullableContext(2)]
		public void SetWorldBounds(UKSC_DA_WorldBounds DAWorldBounds)
		{
			UKSC_World.__SetWorldBounds_Internal(base.NativePtr, (DAWorldBounds != null) ? DAWorldBounds.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x000BF354 File Offset: 0x000BD554
		public void SetWorldAttr(EKSC_WorldAttrType Type, int Value)
		{
			UKSC_World.__SetWorldAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x000BF363 File Offset: 0x000BD563
		public void SetObstacleSegments([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKSC_Segment> InObstacleSegments)
		{
			UKSC_World.__SetObstacleSegments_Internal(base.NativePtr, (InObstacleSegments ?? new TArray<FKSC_Segment>()).NativePtr);
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x000BF37F File Offset: 0x000BD57F
		[NullableContext(2)]
		public void SetKFCAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UKSC_World.__SetKFCAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x000BF39C File Offset: 0x000BD59C
		[NullableContext(2)]
		public void SetHitContextTextData(UKSC_DA_HitContextText InDataAsset)
		{
			UKSC_World.__SetHitContextTextData_Internal(base.NativePtr, (InDataAsset != null) ? InDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x000BF3B9 File Offset: 0x000BD5B9
		public void SetDamageHandler([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKSC_DamageHandler> HandlerClass)
		{
			UKSC_World.__SetDamageHandler_Internal(base.NativePtr, HandlerClass._NativePtr);
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x000BF3CC File Offset: 0x000BD5CC
		[NullableContext(2)]
		public void SetBroadcastBuffIdList(in TArray<int> InBuffIdList)
		{
			UKSC_World.__SetBroadcastBuffIdList_Internal(base.NativePtr, (InBuffIdList ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x000BF3E9 File Offset: 0x000BD5E9
		[NullableContext(2)]
		public void RemoveWorldAttrListen(EKSC_WorldAttrType Id, in FDOnKSCWorldAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FDOnKSCWorldAttrChange fdonKSCWorldAttrChange = InDelegate;
			UKSC_World.__RemoveWorldAttrListen_Internal(nativePtr, Id, (fdonKSCWorldAttrChange != null) ? fdonKSCWorldAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x000BF406 File Offset: 0x000BD606
		[NullableContext(2)]
		public void RemoveEntityReason(AKSC_Entity Entity, FName Reason)
		{
			UKSC_World.__RemoveEntityReason_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero, Reason);
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x000BF424 File Offset: 0x000BD624
		[NullableContext(2)]
		public void RemoveEntity(AKSC_Entity Entity)
		{
			UKSC_World.__RemoveEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x000BF441 File Offset: 0x000BD641
		public void ModifyWorldAttr(EKSC_WorldAttrType Type, int Value)
		{
			UKSC_World.__ModifyWorldAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x000BF450 File Offset: 0x000BD650
		public void InitHeadUiClassMap()
		{
			UKSC_World.__InitHeadUiClassMap_Internal(base.NativePtr);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x000BF45D File Offset: 0x000BD65D
		public int GetWorldAttr(EKSC_WorldAttrType Type)
		{
			return UKSC_World.__GetWorldAttr_Internal(base.NativePtr, Type);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x000BF46B File Offset: 0x000BD66B
		public void GetHeadHpInfos([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_HeadHpContext> HpInfos)
		{
			UKSC_World.__GetHeadHpInfos_Internal(base.NativePtr, (HpInfos ?? new TArray<FKSC_HeadHpContext>()).NativePtr);
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x000BF488 File Offset: 0x000BD688
		public void GetEntityPositionsEx([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKSC_MiniMapContext> EntityPositions)
		{
			UKSC_World.__GetEntityPositionsEx_Internal(base.NativePtr, (EntityPositions ?? new TArray<FKSC_MiniMapContext>()).NativePtr);
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x000BF4A5 File Offset: 0x000BD6A5
		[NullableContext(2)]
		public AKSC_Entity GetEntityById(int EntityId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__GetEntityById_Internal(base.NativePtr, EntityId));
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
		[NullableContext(2)]
		public UKSC_BuffId GetBuffData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_BuffId>(UKSC_World.__GetBuffData_Internal(base.NativePtr));
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x000BF4CA File Offset: 0x000BD6CA
		public bool Debug_SetEntityTag(int EntityId, in FGameplayTag Attr, int TagCount)
		{
			return UKSC_World.__Debug_SetEntityTag_Internal(base.NativePtr, EntityId, Attr, TagCount);
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x000BF4DC File Offset: 0x000BD6DC
		public unsafe bool Debug_SetEntityAttr(int EntityId, in EKSC_AttrType Attr, int Value)
		{
			fixed (EKSC_AttrType* ptr = &Attr)
			{
				void* ptr2 = (void*)ptr;
				return UKSC_World.__Debug_SetEntityAttr_Internal(base.NativePtr, EntityId, Attr, Value);
			}
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x000BF4FC File Offset: 0x000BD6FC
		public bool Debug_IsEntityAlive(int EntityId)
		{
			return UKSC_World.__Debug_IsEntityAlive_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x000BF50A File Offset: 0x000BD70A
		[NullableContext(2)]
		public bool Debug_GetWorldAttr(ref TMap<EKSC_WorldAttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetWorldAttr_Internal(base.NativePtr, (Attr ?? new TMap<EKSC_WorldAttrType, int>()).NativeMapPtr);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x000BF528 File Offset: 0x000BD728
		public unsafe string Debug_GetOriginalTagName(in FName TagName)
		{
			fixed (FName* ptr = &TagName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(UKSC_World.__Debug_GetOriginalTagName_Internal(base.NativePtr, TagName));
			}
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x000BF54B File Offset: 0x000BD74B
		[NullableContext(2)]
		public bool Debug_GetEntityTags(int EntityId, ref TMap<FGameplayTag, int> Tags)
		{
			return UKSC_World.__Debug_GetEntityTags_Internal(base.NativePtr, EntityId, (Tags ?? new TMap<FGameplayTag, int>()).NativeMapPtr);
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x000BF569 File Offset: 0x000BD769
		[NullableContext(2)]
		public bool Debug_GetEntityLockedAttr(int EntityId, ref TMap<EKSC_AttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetEntityLockedAttr_Internal(base.NativePtr, EntityId, (Attr ?? new TMap<EKSC_AttrType, int>()).NativeMapPtr);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x000BF587 File Offset: 0x000BD787
		public bool Debug_GetEntityBuffs(int EntityId, [Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UKSC_DA_Buff, int> Buffs)
		{
			return UKSC_World.__Debug_GetEntityBuffs_Internal(base.NativePtr, EntityId, (Buffs ?? new TMap<UKSC_DA_Buff, int>()).NativeMapPtr);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x000BF5A5 File Offset: 0x000BD7A5
		[NullableContext(2)]
		public bool Debug_GetEntityAttr(int EntityId, ref TMap<EKSC_AttrType, int> Attr)
		{
			return UKSC_World.__Debug_GetEntityAttr_Internal(base.NativePtr, EntityId, (Attr ?? new TMap<EKSC_AttrType, int>()).NativeMapPtr);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x000BF5C4 File Offset: 0x000BD7C4
		[NullableContext(2)]
		public unsafe AKSC_Entity D_AddDaEntity(UKSC_DA_Entity DaEntity, in FTransformDouble Transform, bool InIsPreview = false, int CreatureId = 0)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__D_AddDaEntity_Internal(base.NativePtr, (DaEntity != null) ? DaEntity.NativePtr : IntPtr.Zero, ptr, InIsPreview, CreatureId));
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x000BF611 File Offset: 0x000BD811
		public void ClearDecorator()
		{
			UKSC_World.__ClearDecorator_Internal(base.NativePtr);
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x000BF61E File Offset: 0x000BD81E
		[NullableContext(2)]
		public void AssignWorldAttrListen(EKSC_WorldAttrType Id, in FDOnKSCWorldAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FDOnKSCWorldAttrChange fdonKSCWorldAttrChange = InDelegate;
			UKSC_World.__AssignWorldAttrListen_Internal(nativePtr, Id, (fdonKSCWorldAttrChange != null) ? fdonKSCWorldAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x000BF63B File Offset: 0x000BD83B
		[NullableContext(2)]
		public void AssignLandFireSpawnDelegate(in FOnKSCLandFireSpawn InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCLandFireSpawn fonKSCLandFireSpawn = InDelegate;
			UKSC_World.__AssignLandFireSpawnDelegate_Internal(nativePtr, (fonKSCLandFireSpawn != null) ? fonKSCLandFireSpawn.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x000BF657 File Offset: 0x000BD857
		[NullableContext(2)]
		public void AssignKSCEntitySummon(in FOnKSCEntitySummon InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCEntitySummon fonKSCEntitySummon = InDelegate;
			UKSC_World.__AssignKSCEntitySummon_Internal(nativePtr, (fonKSCEntitySummon != null) ? fonKSCEntitySummon.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x000BF673 File Offset: 0x000BD873
		[NullableContext(2)]
		public void AssignKSCEntitySpawn(in FOnKSCEntitySpawn InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCEntitySpawn fonKSCEntitySpawn = InDelegate;
			UKSC_World.__AssignKSCEntitySpawn_Internal(nativePtr, (fonKSCEntitySpawn != null) ? fonKSCEntitySpawn.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x000BF68F File Offset: 0x000BD88F
		[NullableContext(2)]
		public void AssignBatchRemoveDelegate(in FOnKSCBatchRemoveAfter InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCBatchRemoveAfter fonKSCBatchRemoveAfter = InDelegate;
			UKSC_World.__AssignBatchRemoveDelegate_Internal(nativePtr, (fonKSCBatchRemoveAfter != null) ? fonKSCBatchRemoveAfter.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x000BF6AC File Offset: 0x000BD8AC
		[NullableContext(2)]
		public unsafe AKSC_Entity AddDaEntity(UKSC_DA_Entity DaEntity, in FTransform Transform, bool IsPreview = false, int CreatureId = 0)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKSC_Entity>(UKSC_World.__AddDaEntity_Internal(base.NativePtr, (DaEntity != null) ? DaEntity.NativePtr : IntPtr.Zero, ptr, IsPreview, CreatureId));
		}

		// Token: 0x06008195 RID: 33173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldTimeDilation_Internal(IntPtr @this, float NewTimeDilation);

		// Token: 0x06008196 RID: 33174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldBounds_Internal(IntPtr @this, IntPtr DAWorldBounds);

		// Token: 0x06008197 RID: 33175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type, int Value);

		// Token: 0x06008198 RID: 33176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObstacleSegments_Internal(IntPtr @this, IntPtr InObstacleSegments);

		// Token: 0x06008199 RID: 33177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKFCAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x0600819A RID: 33178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHitContextTextData_Internal(IntPtr @this, IntPtr InDataAsset);

		// Token: 0x0600819B RID: 33179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDamageHandler_Internal(IntPtr @this, IntPtr HandlerClass);

		// Token: 0x0600819C RID: 33180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBroadcastBuffIdList_Internal(IntPtr @this, IntPtr InBuffIdList);

		// Token: 0x0600819D RID: 33181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveWorldAttrListen_Internal(IntPtr @this, EKSC_WorldAttrType Id, IntPtr InDelegate);

		// Token: 0x0600819E RID: 33182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEntityReason_Internal(IntPtr @this, IntPtr Entity, FName Reason);

		// Token: 0x0600819F RID: 33183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x060081A0 RID: 33184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ModifyWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type, int Value);

		// Token: 0x060081A1 RID: 33185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitHeadUiClassMap_Internal(IntPtr @this);

		// Token: 0x060081A2 RID: 33186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWorldAttr_Internal(IntPtr @this, EKSC_WorldAttrType Type);

		// Token: 0x060081A3 RID: 33187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetHeadHpInfos_Internal(IntPtr @this, IntPtr HpInfos);

		// Token: 0x060081A4 RID: 33188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetEntityPositionsEx_Internal(IntPtr @this, IntPtr EntityPositions);

		// Token: 0x060081A5 RID: 33189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEntityById_Internal(IntPtr @this, int EntityId);

		// Token: 0x060081A6 RID: 33190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBuffData_Internal(IntPtr @this);

		// Token: 0x060081A7 RID: 33191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_SetEntityTag_Internal(IntPtr @this, int EntityId, in FGameplayTag Attr, int TagCount);

		// Token: 0x060081A8 RID: 33192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_SetEntityAttr_Internal(IntPtr @this, int EntityId, in EKSC_AttrType Attr, int Value);

		// Token: 0x060081A9 RID: 33193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_IsEntityAlive_Internal(IntPtr @this, int EntityId);

		// Token: 0x060081AA RID: 33194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetWorldAttr_Internal(IntPtr @this, IntPtr Attr);

		// Token: 0x060081AB RID: 33195
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Debug_GetOriginalTagName_Internal(IntPtr @this, in FName TagName);

		// Token: 0x060081AC RID: 33196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityTags_Internal(IntPtr @this, int EntityId, IntPtr Tags);

		// Token: 0x060081AD RID: 33197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityLockedAttr_Internal(IntPtr @this, int EntityId, IntPtr Attr);

		// Token: 0x060081AE RID: 33198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityBuffs_Internal(IntPtr @this, int EntityId, IntPtr Buffs);

		// Token: 0x060081AF RID: 33199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Debug_GetEntityAttr_Internal(IntPtr @this, int EntityId, IntPtr Attr);

		// Token: 0x060081B0 RID: 33200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_AddDaEntity_Internal(IntPtr @this, IntPtr DaEntity, in FTransformDouble Transform, bool InIsPreview, int CreatureId);

		// Token: 0x060081B1 RID: 33201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDecorator_Internal(IntPtr @this);

		// Token: 0x060081B2 RID: 33202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignWorldAttrListen_Internal(IntPtr @this, EKSC_WorldAttrType Id, IntPtr InDelegate);

		// Token: 0x060081B3 RID: 33203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignLandFireSpawnDelegate_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060081B4 RID: 33204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignKSCEntitySummon_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060081B5 RID: 33205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignKSCEntitySpawn_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060081B6 RID: 33206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignBatchRemoveDelegate_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060081B7 RID: 33207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddDaEntity_Internal(IntPtr @this, IntPtr DaEntity, in FTransform Transform, bool IsPreview, int CreatureId);

		// Token: 0x060081B8 RID: 33208 RVA: 0x000BF6F9 File Offset: 0x000BD8F9
		static UKSC_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_World");
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x000BF707 File Offset: 0x000BD907
		protected UKSC_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400386C RID: 14444
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_World";

		// Token: 0x0400386D RID: 14445
		private static IntPtr _ClassPtr;

		// Token: 0x0400386E RID: 14446
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400386F RID: 14447
		internal static int __PropertyOffset_Entities_;

		// Token: 0x04003870 RID: 14448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _Entities_;

		// Token: 0x04003871 RID: 14449
		internal static int __PropertyOffset_EntityIdMap;

		// Token: 0x04003872 RID: 14450
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, AKSC_Entity> _EntityIdMap;

		// Token: 0x04003873 RID: 14451
		internal static int __PropertyOffset_DeadEntities_;

		// Token: 0x04003874 RID: 14452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _DeadEntities_;

		// Token: 0x04003875 RID: 14453
		internal static int __PropertyOffset_ShowHeadUIEntities_;

		// Token: 0x04003876 RID: 14454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ShowHeadUIEntities_;

		// Token: 0x04003877 RID: 14455
		internal static int __PropertyOffset_ToRemoveEntities_;

		// Token: 0x04003878 RID: 14456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ToRemoveEntities_;

		// Token: 0x04003879 RID: 14457
		internal static int __PropertyOffset_ToAddEntities_;

		// Token: 0x0400387A RID: 14458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_Entity> _ToAddEntities_;

		// Token: 0x0400387B RID: 14459
		internal static int __PropertyOffset_ToAddLandFire_;

		// Token: 0x0400387C RID: 14460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_LandFireContext> _ToAddLandFire_;

		// Token: 0x0400387D RID: 14461
		internal static int __PropertyOffset_RenderActorMap_;

		// Token: 0x0400387E RID: 14462
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AKSC_Entity, AActor> _RenderActorMap_;

		// Token: 0x0400387F RID: 14463
		internal static int __PropertyOffset_AttributeIdsWithMax;

		// Token: 0x04003880 RID: 14464
		[Nullable(2)]
		private TMap<EKSC_AttrType, EKSC_AttrType> _AttributeIdsWithMax;

		// Token: 0x04003881 RID: 14465
		internal static int __PropertyOffset_AttributeEffectiveDamageType;

		// Token: 0x04003882 RID: 14466
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttributeEffectiveDamageType;

		// Token: 0x04003883 RID: 14467
		internal static int __PropertyOffset_OnKSCBatchRemoveAfter;

		// Token: 0x04003884 RID: 14468
		[Nullable(2)]
		private FOnKSCBatchRemoveAfter _OnKSCBatchRemoveAfter;

		// Token: 0x04003885 RID: 14469
		internal static int __PropertyOffset_OnKSCLandFireSpawn;

		// Token: 0x04003886 RID: 14470
		[Nullable(2)]
		private FOnKSCLandFireSpawn _OnKSCLandFireSpawn;

		// Token: 0x04003887 RID: 14471
		internal static int __PropertyOffset_OnKSCEntitySpawn;

		// Token: 0x04003888 RID: 14472
		[Nullable(2)]
		private FOnKSCEntitySpawn _OnKSCEntitySpawn;

		// Token: 0x04003889 RID: 14473
		internal static int __PropertyOffset_OnKSCEntitySummon;

		// Token: 0x0400388A RID: 14474
		[Nullable(2)]
		private FOnKSCEntitySummon _OnKSCEntitySummon;

		// Token: 0x0400388B RID: 14475
		internal static int __PropertyOffset_HeadUiHandleClassMap;

		// Token: 0x0400388C RID: 14476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_HeadUiType, UClass> _HeadUiHandleClassMap;

		// Token: 0x0400388D RID: 14477
		internal static int __PropertyOffset_DamageHandler;

		// Token: 0x0400388E RID: 14478
		internal static int __PropertyOffset_PoolHelper_;

		// Token: 0x0400388F RID: 14479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _PoolHelper_;

		// Token: 0x04003890 RID: 14480
		internal static int __PropertyOffset_LoadedBuffDa;

		// Token: 0x04003891 RID: 14481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Buff, int> _LoadedBuffDa;

		// Token: 0x04003892 RID: 14482
		internal static int __PropertyOffset_LoadedEntityDa;

		// Token: 0x04003893 RID: 14483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Entity, int> _LoadedEntityDa;

		// Token: 0x04003894 RID: 14484
		internal static int __PropertyOffset_LoadedSkillDa;

		// Token: 0x04003895 RID: 14485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_Skill, int> _LoadedSkillDa;

		// Token: 0x04003896 RID: 14486
		internal static int __PropertyOffset_DamageData;

		// Token: 0x04003897 RID: 14487
		internal static int __PropertyOffset_BuffData;

		// Token: 0x04003898 RID: 14488
		internal static int __PropertyOffset_BroadcastBuffIdSet;

		// Token: 0x04003899 RID: 14489
		[Nullable(2)]
		private TSet<int> _BroadcastBuffIdSet;

		// Token: 0x0400389A RID: 14490
		internal static int __PropertyOffset_SceneMovement;

		// Token: 0x0400389B RID: 14491
		internal static int __PropertyOffset_KFCAlgorithm;
	}
}
