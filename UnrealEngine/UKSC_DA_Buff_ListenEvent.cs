using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D67 RID: 7527
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ListenEvent")]
	[UnrealStructLayout(864, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public class UKSC_DA_Buff_ListenEvent : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD36 RID: 118070 RVA: 0x002A9BA5 File Offset: 0x002A7DA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ListenEvent._ClassPtr;
		}

		// Token: 0x0601CD37 RID: 118071 RVA: 0x002A9BB4 File Offset: 0x002A7DB4
		public UKSC_DA_Buff_ListenEvent() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ListenEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD38 RID: 118072 RVA: 0x002A9BDC File Offset: 0x002A7DDC
		public UKSC_DA_Buff_ListenEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ListenEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700741D RID: 29725
		// (get) Token: 0x0601CD39 RID: 118073 RVA: 0x002A9C0F File Offset: 0x002A7E0F
		// (set) Token: 0x0601CD3A RID: 118074 RVA: 0x002A9C1F File Offset: 0x002A7E1F
		public unsafe float ListenEventCoolDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEventCoolDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEventCoolDown) = value;
			}
		}

		// Token: 0x1700741E RID: 29726
		// (get) Token: 0x0601CD3B RID: 118075 RVA: 0x002A9C30 File Offset: 0x002A7E30
		// (set) Token: 0x0601CD3C RID: 118076 RVA: 0x002A9C40 File Offset: 0x002A7E40
		public unsafe EKSC_Buff_ListenEvent_ListenType ListenEvent
		{
			get
			{
				return (EKSC_Buff_ListenEvent_ListenType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEvent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEvent) = (byte)value;
			}
		}

		// Token: 0x1700741F RID: 29727
		// (get) Token: 0x0601CD3D RID: 118077 RVA: 0x002A9C51 File Offset: 0x002A7E51
		// (set) Token: 0x0601CD3E RID: 118078 RVA: 0x002A9C61 File Offset: 0x002A7E61
		public unsafe EKSC_Buff_ListenEvent_ListenTarget ListenTarget
		{
			get
			{
				return (EKSC_Buff_ListenEvent_ListenTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTarget) = (byte)value;
			}
		}

		// Token: 0x17007420 RID: 29728
		// (get) Token: 0x0601CD3F RID: 118079 RVA: 0x002A9C72 File Offset: 0x002A7E72
		// (set) Token: 0x0601CD40 RID: 118080 RVA: 0x002A9C82 File Offset: 0x002A7E82
		public unsafe bool IsFinishAfterResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_IsFinishAfterResponse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_IsFinishAfterResponse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007421 RID: 29729
		// (get) Token: 0x0601CD41 RID: 118081 RVA: 0x002A9C94 File Offset: 0x002A7E94
		// (set) Token: 0x0601CD42 RID: 118082 RVA: 0x002A9CCD File Offset: 0x002A7ECD
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007422 RID: 29730
		// (get) Token: 0x0601CD43 RID: 118083 RVA: 0x002A9CEE File Offset: 0x002A7EEE
		// (set) Token: 0x0601CD44 RID: 118084 RVA: 0x002A9CFE File Offset: 0x002A7EFE
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x17007423 RID: 29731
		// (get) Token: 0x0601CD45 RID: 118085 RVA: 0x002A9D0F File Offset: 0x002A7F0F
		// (set) Token: 0x0601CD46 RID: 118086 RVA: 0x002A9D1F File Offset: 0x002A7F1F
		public unsafe bool ListenZeroDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenZeroDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenZeroDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007424 RID: 29732
		// (get) Token: 0x0601CD47 RID: 118087 RVA: 0x002A9D30 File Offset: 0x002A7F30
		// (set) Token: 0x0601CD48 RID: 118088 RVA: 0x002A9D40 File Offset: 0x002A7F40
		public unsafe long CheckBulletConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckBulletConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckBulletConfigId) = value;
			}
		}

		// Token: 0x17007425 RID: 29733
		// (get) Token: 0x0601CD49 RID: 118089 RVA: 0x002A9D54 File Offset: 0x002A7F54
		// (set) Token: 0x0601CD4A RID: 118090 RVA: 0x002A9D8D File Offset: 0x002A7F8D
		public FKSC_TagFilter KillTargetTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._KillTargetTagFilter) == null)
				{
					result = (this._KillTargetTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_KillTargetTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_KillTargetTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007426 RID: 29734
		// (get) Token: 0x0601CD4B RID: 118091 RVA: 0x002A9DAE File Offset: 0x002A7FAE
		// (set) Token: 0x0601CD4C RID: 118092 RVA: 0x002A9DC2 File Offset: 0x002A7FC2
		public unsafe FGameplayTag ListenTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTag) = value;
			}
		}

		// Token: 0x17007427 RID: 29735
		// (get) Token: 0x0601CD4D RID: 118093 RVA: 0x002A9DD7 File Offset: 0x002A7FD7
		// (set) Token: 0x0601CD4E RID: 118094 RVA: 0x002A9DE7 File Offset: 0x002A7FE7
		public unsafe int ListenTagCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTagCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenTagCount) = value;
			}
		}

		// Token: 0x17007428 RID: 29736
		// (get) Token: 0x0601CD4F RID: 118095 RVA: 0x002A9DF8 File Offset: 0x002A7FF8
		// (set) Token: 0x0601CD50 RID: 118096 RVA: 0x002A9E08 File Offset: 0x002A8008
		public unsafe bool ClearListenTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ClearListenTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ClearListenTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007429 RID: 29737
		// (get) Token: 0x0601CD51 RID: 118097 RVA: 0x002A9E19 File Offset: 0x002A8019
		// (set) Token: 0x0601CD52 RID: 118098 RVA: 0x002A9E29 File Offset: 0x002A8029
		public unsafe bool CheckOnBeginBuff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckOnBeginBuff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_CheckOnBeginBuff) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700742A RID: 29738
		// (get) Token: 0x0601CD53 RID: 118099 RVA: 0x002A9E3A File Offset: 0x002A803A
		// (set) Token: 0x0601CD54 RID: 118100 RVA: 0x002A9E4A File Offset: 0x002A804A
		public unsafe float LifeChangeDownValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_LifeChangeDownValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_LifeChangeDownValue) = value;
			}
		}

		// Token: 0x1700742B RID: 29739
		// (get) Token: 0x0601CD55 RID: 118101 RVA: 0x002A9E5B File Offset: 0x002A805B
		// (set) Token: 0x0601CD56 RID: 118102 RVA: 0x002A9E6B File Offset: 0x002A806B
		public unsafe EKSC_Buff_ListenEvent_Response ListenEvent_Response
		{
			get
			{
				return (EKSC_Buff_ListenEvent_Response)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEvent_Response));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenEvent_Response) = (byte)value;
			}
		}

		// Token: 0x1700742C RID: 29740
		// (get) Token: 0x0601CD57 RID: 118103 RVA: 0x002A9E7C File Offset: 0x002A807C
		// (set) Token: 0x0601CD58 RID: 118104 RVA: 0x002A9EB5 File Offset: 0x002A80B5
		public FKSC_TagFilter ResponseCheckTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._ResponseCheckTagFilter) == null)
				{
					result = (this._ResponseCheckTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseCheckTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseCheckTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700742D RID: 29741
		// (get) Token: 0x0601CD59 RID: 118105 RVA: 0x002A9ED6 File Offset: 0x002A80D6
		// (set) Token: 0x0601CD5A RID: 118106 RVA: 0x002A9EE6 File Offset: 0x002A80E6
		public unsafe int Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x1700742E RID: 29742
		// (get) Token: 0x0601CD5B RID: 118107 RVA: 0x002A9EF7 File Offset: 0x002A80F7
		// (set) Token: 0x0601CD5C RID: 118108 RVA: 0x002A9F07 File Offset: 0x002A8107
		public unsafe bool UseAttrProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_UseAttrProbability) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_UseAttrProbability) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700742F RID: 29743
		// (get) Token: 0x0601CD5D RID: 118109 RVA: 0x002A9F18 File Offset: 0x002A8118
		// (set) Token: 0x0601CD5E RID: 118110 RVA: 0x002A9F28 File Offset: 0x002A8128
		public unsafe EKSC_AttrType ProbabilityAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ProbabilityAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ProbabilityAttr) = (byte)value;
			}
		}

		// Token: 0x17007430 RID: 29744
		// (get) Token: 0x0601CD5F RID: 118111 RVA: 0x002A9F39 File Offset: 0x002A8139
		// (set) Token: 0x0601CD60 RID: 118112 RVA: 0x002A9F49 File Offset: 0x002A8149
		public unsafe int ResponseCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseCount) = value;
			}
		}

		// Token: 0x17007431 RID: 29745
		// (get) Token: 0x0601CD61 RID: 118113 RVA: 0x002A9F5C File Offset: 0x002A815C
		// (set) Token: 0x0601CD62 RID: 118114 RVA: 0x002A9F95 File Offset: 0x002A8195
		public FGameplayTagContainer ResponseTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ResponseTag) == null)
				{
					result = (this._ResponseTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ResponseTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007432 RID: 29746
		// (get) Token: 0x0601CD63 RID: 118115 RVA: 0x002A9FB6 File Offset: 0x002A81B6
		// (set) Token: 0x0601CD64 RID: 118116 RVA: 0x002A9FCA File Offset: 0x002A81CA
		[Nullable(2)]
		public unsafe UKSC_DA_Buff AddBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_AddBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x17007433 RID: 29747
		// (get) Token: 0x0601CD65 RID: 118117 RVA: 0x002A9FE0 File Offset: 0x002A81E0
		// (set) Token: 0x0601CD66 RID: 118118 RVA: 0x002AA019 File Offset: 0x002A8219
		public TArray<UKSC_DA_Buff> AddMultiBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddMultiBuff) == null)
				{
					result = (this._AddMultiBuff = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_AddMultiBuff, this));
				}
				return result;
			}
			set
			{
				this.AddMultiBuff.CopyAssign(value);
			}
		}

		// Token: 0x17007434 RID: 29748
		// (get) Token: 0x0601CD67 RID: 118119 RVA: 0x002AA027 File Offset: 0x002A8227
		// (set) Token: 0x0601CD68 RID: 118120 RVA: 0x002AA037 File Offset: 0x002A8237
		public unsafe int BuffStackNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_BuffStackNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_BuffStackNum) = value;
			}
		}

		// Token: 0x17007435 RID: 29749
		// (get) Token: 0x0601CD69 RID: 118121 RVA: 0x002AA048 File Offset: 0x002A8248
		// (set) Token: 0x0601CD6A RID: 118122 RVA: 0x002AA05C File Offset: 0x002A825C
		[Nullable(2)]
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_AdditionalAttack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_AdditionalAttack, value);
			}
		}

		// Token: 0x17007436 RID: 29750
		// (get) Token: 0x0601CD6B RID: 118123 RVA: 0x002AA074 File Offset: 0x002A8274
		// (set) Token: 0x0601CD6C RID: 118124 RVA: 0x002AA0AD File Offset: 0x002A82AD
		public TArray<FKSC_SpawnEntity> SpawnEntity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpawnEntity> result;
				if ((result = this._SpawnEntity) == null)
				{
					result = (this._SpawnEntity = new TArray<FKSC_SpawnEntity>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_SpawnEntity, this));
				}
				return result;
			}
			set
			{
				this.SpawnEntity.CopyAssign(value);
			}
		}

		// Token: 0x17007437 RID: 29751
		// (get) Token: 0x0601CD6D RID: 118125 RVA: 0x002AA0BC File Offset: 0x002A82BC
		// (set) Token: 0x0601CD6E RID: 118126 RVA: 0x002AA0F5 File Offset: 0x002A82F5
		public TArray<int> SkillIndexTryStart
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkillIndexTryStart) == null)
				{
					result = (this._SkillIndexTryStart = new TArray<int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_SkillIndexTryStart, this));
				}
				return result;
			}
			set
			{
				this.SkillIndexTryStart.CopyAssign(value);
			}
		}

		// Token: 0x17007438 RID: 29752
		// (get) Token: 0x0601CD6F RID: 118127 RVA: 0x002AA103 File Offset: 0x002A8303
		// (set) Token: 0x0601CD70 RID: 118128 RVA: 0x002AA113 File Offset: 0x002A8313
		public unsafe int MoveStageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_MoveStageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_MoveStageIndex) = value;
			}
		}

		// Token: 0x17007439 RID: 29753
		// (get) Token: 0x0601CD71 RID: 118129 RVA: 0x002AA124 File Offset: 0x002A8324
		// (set) Token: 0x0601CD72 RID: 118130 RVA: 0x002AA134 File Offset: 0x002A8334
		public unsafe int HealFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX_MaxNum) = value;
			}
		}

		// Token: 0x1700743A RID: 29754
		// (get) Token: 0x0601CD73 RID: 118131 RVA: 0x002AA145 File Offset: 0x002A8345
		// (set) Token: 0x0601CD74 RID: 118132 RVA: 0x002AA159 File Offset: 0x002A8359
		[Nullable(2)]
		public unsafe UEffectModelBase HealFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX, value);
			}
		}

		// Token: 0x1700743B RID: 29755
		// (get) Token: 0x0601CD75 RID: 118133 RVA: 0x002AA16E File Offset: 0x002A836E
		// (set) Token: 0x0601CD76 RID: 118134 RVA: 0x002AA182 File Offset: 0x002A8382
		public unsafe FTransform HealFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_HealFX_Offset) = value;
			}
		}

		// Token: 0x1700743C RID: 29756
		// (get) Token: 0x0601CD77 RID: 118135 RVA: 0x002AA198 File Offset: 0x002A8398
		// (set) Token: 0x0601CD78 RID: 118136 RVA: 0x002AA1D1 File Offset: 0x002A83D1
		public FKSC_ListenAttrEventBuff ListenAttrChanged
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_ListenAttrEventBuff result;
				if ((result = this._ListenAttrChanged) == null)
				{
					result = (this._ListenAttrChanged = new FKSC_ListenAttrEventBuff(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenAttrChanged, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_ListenAttrEventBuff.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenAttrChanged, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700743D RID: 29757
		// (get) Token: 0x0601CD79 RID: 118137 RVA: 0x002AA1F2 File Offset: 0x002A83F2
		// (set) Token: 0x0601CD7A RID: 118138 RVA: 0x002AA202 File Offset: 0x002A8402
		public unsafe float DelayTimeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_DelayTimeSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_DelayTimeSec) = value;
			}
		}

		// Token: 0x1700743E RID: 29758
		// (get) Token: 0x0601CD7B RID: 118139 RVA: 0x002AA214 File Offset: 0x002A8414
		// (set) Token: 0x0601CD7C RID: 118140 RVA: 0x002AA24D File Offset: 0x002A844D
		public FGameplayTagContainer ListenAddOrRemoveTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ListenAddOrRemoveTags) == null)
				{
					result = (this._ListenAddOrRemoveTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenAddOrRemoveTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenEvent.__PropertyOffset_ListenAddOrRemoveTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CD7D RID: 118141 RVA: 0x002AA26E File Offset: 0x002A846E
		static UKSC_DA_Buff_ListenEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ListenEvent");
		}

		// Token: 0x0601CD7E RID: 118142 RVA: 0x002AA27C File Offset: 0x002A847C
		protected UKSC_DA_Buff_ListenEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA29 RID: 64041
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ListenEvent";

		// Token: 0x0400FA2A RID: 64042
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA2B RID: 64043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA2C RID: 64044
		internal static int __PropertyOffset_ListenEventCoolDown;

		// Token: 0x0400FA2D RID: 64045
		internal static int __PropertyOffset_ListenEvent;

		// Token: 0x0400FA2E RID: 64046
		internal static int __PropertyOffset_ListenTarget;

		// Token: 0x0400FA2F RID: 64047
		internal static int __PropertyOffset_IsFinishAfterResponse;

		// Token: 0x0400FA30 RID: 64048
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400FA31 RID: 64049
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400FA32 RID: 64050
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400FA33 RID: 64051
		internal static int __PropertyOffset_ListenZeroDamage;

		// Token: 0x0400FA34 RID: 64052
		internal static int __PropertyOffset_CheckBulletConfigId;

		// Token: 0x0400FA35 RID: 64053
		internal static int __PropertyOffset_KillTargetTagFilter;

		// Token: 0x0400FA36 RID: 64054
		[Nullable(2)]
		private FKSC_TagFilter _KillTargetTagFilter;

		// Token: 0x0400FA37 RID: 64055
		internal static int __PropertyOffset_ListenTag;

		// Token: 0x0400FA38 RID: 64056
		internal static int __PropertyOffset_ListenTagCount;

		// Token: 0x0400FA39 RID: 64057
		internal static int __PropertyOffset_ClearListenTag;

		// Token: 0x0400FA3A RID: 64058
		internal static int __PropertyOffset_CheckOnBeginBuff;

		// Token: 0x0400FA3B RID: 64059
		internal static int __PropertyOffset_LifeChangeDownValue;

		// Token: 0x0400FA3C RID: 64060
		internal static int __PropertyOffset_ListenEvent_Response;

		// Token: 0x0400FA3D RID: 64061
		internal static int __PropertyOffset_ResponseCheckTagFilter;

		// Token: 0x0400FA3E RID: 64062
		[Nullable(2)]
		private FKSC_TagFilter _ResponseCheckTagFilter;

		// Token: 0x0400FA3F RID: 64063
		internal static int __PropertyOffset_Probability;

		// Token: 0x0400FA40 RID: 64064
		internal static int __PropertyOffset_UseAttrProbability;

		// Token: 0x0400FA41 RID: 64065
		internal static int __PropertyOffset_ProbabilityAttr;

		// Token: 0x0400FA42 RID: 64066
		internal static int __PropertyOffset_ResponseCount;

		// Token: 0x0400FA43 RID: 64067
		internal static int __PropertyOffset_ResponseTag;

		// Token: 0x0400FA44 RID: 64068
		[Nullable(2)]
		private FGameplayTagContainer _ResponseTag;

		// Token: 0x0400FA45 RID: 64069
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x0400FA46 RID: 64070
		internal static int __PropertyOffset_AddMultiBuff;

		// Token: 0x0400FA47 RID: 64071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddMultiBuff;

		// Token: 0x0400FA48 RID: 64072
		internal static int __PropertyOffset_BuffStackNum;

		// Token: 0x0400FA49 RID: 64073
		internal static int __PropertyOffset_AdditionalAttack;

		// Token: 0x0400FA4A RID: 64074
		internal static int __PropertyOffset_SpawnEntity;

		// Token: 0x0400FA4B RID: 64075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpawnEntity> _SpawnEntity;

		// Token: 0x0400FA4C RID: 64076
		internal static int __PropertyOffset_SkillIndexTryStart;

		// Token: 0x0400FA4D RID: 64077
		[Nullable(2)]
		private TArray<int> _SkillIndexTryStart;

		// Token: 0x0400FA4E RID: 64078
		internal static int __PropertyOffset_MoveStageIndex;

		// Token: 0x0400FA4F RID: 64079
		internal static int __PropertyOffset_HealFX_MaxNum;

		// Token: 0x0400FA50 RID: 64080
		internal static int __PropertyOffset_HealFX;

		// Token: 0x0400FA51 RID: 64081
		internal static int __PropertyOffset_HealFX_Offset;

		// Token: 0x0400FA52 RID: 64082
		internal static int __PropertyOffset_ListenAttrChanged;

		// Token: 0x0400FA53 RID: 64083
		[Nullable(2)]
		private FKSC_ListenAttrEventBuff _ListenAttrChanged;

		// Token: 0x0400FA54 RID: 64084
		internal static int __PropertyOffset_DelayTimeSec;

		// Token: 0x0400FA55 RID: 64085
		internal static int __PropertyOffset_ListenAddOrRemoveTags;

		// Token: 0x0400FA56 RID: 64086
		[Nullable(2)]
		private FGameplayTagContainer _ListenAddOrRemoveTags;
	}
}
