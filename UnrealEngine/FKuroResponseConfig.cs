using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E60 RID: 7776
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KuroResponseConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FKuroResponseConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DA1A RID: 121370 RVA: 0x002BBF1B File Offset: 0x002BA11B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroResponseConfig._ScriptStructPtr != 0) ? FKuroResponseConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KuroResponseConfig", ref FKuroResponseConfig._ScriptStructPtr);
		}

		// Token: 0x17007759 RID: 30553
		// (get) Token: 0x0601DA1B RID: 121371 RVA: 0x002BBF40 File Offset: 0x002BA140
		// (set) Token: 0x0601DA1C RID: 121372 RVA: 0x002BBF83 File Offset: 0x002BA183
		public FKSC_TagFilter CheckTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._CheckTagFilter) == null)
				{
					result = (this._CheckTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_CheckTagFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_CheckTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700775A RID: 30554
		// (get) Token: 0x0601DA1D RID: 121373 RVA: 0x002BBFA4 File Offset: 0x002BA1A4
		// (set) Token: 0x0601DA1E RID: 121374 RVA: 0x002BBFB4 File Offset: 0x002BA1B4
		public unsafe int Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x1700775B RID: 30555
		// (get) Token: 0x0601DA1F RID: 121375 RVA: 0x002BBFC5 File Offset: 0x002BA1C5
		// (set) Token: 0x0601DA20 RID: 121376 RVA: 0x002BBFD5 File Offset: 0x002BA1D5
		public unsafe int ResponseCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseCount) = value;
			}
		}

		// Token: 0x1700775C RID: 30556
		// (get) Token: 0x0601DA21 RID: 121377 RVA: 0x002BBFE6 File Offset: 0x002BA1E6
		// (set) Token: 0x0601DA22 RID: 121378 RVA: 0x002BBFF6 File Offset: 0x002BA1F6
		public unsafe EKSC_Buff_ListenEvent_Response ResponseType
		{
			get
			{
				return (EKSC_Buff_ListenEvent_Response)(*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseType) = (byte)value;
			}
		}

		// Token: 0x1700775D RID: 30557
		// (get) Token: 0x0601DA23 RID: 121379 RVA: 0x002BC008 File Offset: 0x002BA208
		// (set) Token: 0x0601DA24 RID: 121380 RVA: 0x002BC04B File Offset: 0x002BA24B
		public FGameplayTagContainer ResponseTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ResponseTag) == null)
				{
					result = (this._ResponseTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ResponseTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700775E RID: 30558
		// (get) Token: 0x0601DA25 RID: 121381 RVA: 0x002BC06C File Offset: 0x002BA26C
		// (set) Token: 0x0601DA26 RID: 121382 RVA: 0x002BC080 File Offset: 0x002BA280
		[Nullable(2)]
		public unsafe UKSC_DA_Buff AddBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroResponseConfig.__PropertyOffset_AddBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroResponseConfig.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x1700775F RID: 30559
		// (get) Token: 0x0601DA27 RID: 121383 RVA: 0x002BC098 File Offset: 0x002BA298
		// (set) Token: 0x0601DA28 RID: 121384 RVA: 0x002BC0DB File Offset: 0x002BA2DB
		public TArray<UKSC_DA_Buff> AddMultiBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddMultiBuff) == null)
				{
					result = (this._AddMultiBuff = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_AddMultiBuff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddMultiBuff.CopyAssign(value);
			}
		}

		// Token: 0x17007760 RID: 30560
		// (get) Token: 0x0601DA29 RID: 121385 RVA: 0x002BC0E9 File Offset: 0x002BA2E9
		// (set) Token: 0x0601DA2A RID: 121386 RVA: 0x002BC0F9 File Offset: 0x002BA2F9
		public unsafe int BuffStackNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_BuffStackNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_BuffStackNum) = value;
			}
		}

		// Token: 0x17007761 RID: 30561
		// (get) Token: 0x0601DA2B RID: 121387 RVA: 0x002BC10A File Offset: 0x002BA30A
		// (set) Token: 0x0601DA2C RID: 121388 RVA: 0x002BC11E File Offset: 0x002BA31E
		[Nullable(2)]
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroResponseConfig.__PropertyOffset_AdditionalAttack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroResponseConfig.__PropertyOffset_AdditionalAttack, value);
			}
		}

		// Token: 0x17007762 RID: 30562
		// (get) Token: 0x0601DA2D RID: 121389 RVA: 0x002BC134 File Offset: 0x002BA334
		// (set) Token: 0x0601DA2E RID: 121390 RVA: 0x002BC177 File Offset: 0x002BA377
		public TArray<FKSC_SpawnEntity> SpawnEntity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpawnEntity> result;
				if ((result = this._SpawnEntity) == null)
				{
					result = (this._SpawnEntity = new TArray<FKSC_SpawnEntity>(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_SpawnEntity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpawnEntity.CopyAssign(value);
			}
		}

		// Token: 0x17007763 RID: 30563
		// (get) Token: 0x0601DA2F RID: 121391 RVA: 0x002BC188 File Offset: 0x002BA388
		// (set) Token: 0x0601DA30 RID: 121392 RVA: 0x002BC1CB File Offset: 0x002BA3CB
		public TArray<int> SkillIndexTryStart
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkillIndexTryStart) == null)
				{
					result = (this._SkillIndexTryStart = new TArray<int>(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_SkillIndexTryStart, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillIndexTryStart.CopyAssign(value);
			}
		}

		// Token: 0x17007764 RID: 30564
		// (get) Token: 0x0601DA31 RID: 121393 RVA: 0x002BC1D9 File Offset: 0x002BA3D9
		// (set) Token: 0x0601DA32 RID: 121394 RVA: 0x002BC1E9 File Offset: 0x002BA3E9
		public unsafe int MoveStageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_MoveStageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_MoveStageIndex) = value;
			}
		}

		// Token: 0x17007765 RID: 30565
		// (get) Token: 0x0601DA33 RID: 121395 RVA: 0x002BC1FA File Offset: 0x002BA3FA
		// (set) Token: 0x0601DA34 RID: 121396 RVA: 0x002BC20A File Offset: 0x002BA40A
		public unsafe bool UseAttrProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_UseAttrProbability) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_UseAttrProbability) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007766 RID: 30566
		// (get) Token: 0x0601DA35 RID: 121397 RVA: 0x002BC21B File Offset: 0x002BA41B
		// (set) Token: 0x0601DA36 RID: 121398 RVA: 0x002BC22B File Offset: 0x002BA42B
		public unsafe EKSC_AttrType ProbabilityAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ProbabilityAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResponseConfig.__PropertyOffset_ProbabilityAttr) = (byte)value;
			}
		}

		// Token: 0x0601DA37 RID: 121399 RVA: 0x002BC23C File Offset: 0x002BA43C
		public FKuroResponseConfig()
		{
		}

		// Token: 0x0601DA38 RID: 121400 RVA: 0x002BC244 File Offset: 0x002BA444
		public FKuroResponseConfig(FKSC_TagFilter CheckTagFilter, int Probability, int ResponseCount, EKSC_Buff_ListenEvent_Response ResponseType, FGameplayTagContainer ResponseTag, UKSC_DA_Buff AddBuff, TArray<UKSC_DA_Buff> AddMultiBuff, int BuffStackNum, UKSC_DA_AdditionalAttack AdditionalAttack, TArray<FKSC_SpawnEntity> SpawnEntity, TArray<int> SkillIndexTryStart, int MoveStageIndex, bool UseAttrProbability, EKSC_AttrType ProbabilityAttr)
		{
			this.CheckTagFilter = CheckTagFilter;
			this.Probability = Probability;
			this.ResponseCount = ResponseCount;
			this.ResponseType = ResponseType;
			this.ResponseTag = ResponseTag;
			this.AddBuff = AddBuff;
			this.AddMultiBuff = AddMultiBuff;
			this.BuffStackNum = BuffStackNum;
			this.AdditionalAttack = AdditionalAttack;
			this.SpawnEntity = SpawnEntity;
			this.SkillIndexTryStart = SkillIndexTryStart;
			this.MoveStageIndex = MoveStageIndex;
			this.UseAttrProbability = UseAttrProbability;
			this.ProbabilityAttr = ProbabilityAttr;
		}

		// Token: 0x0601DA39 RID: 121401 RVA: 0x002BC2C4 File Offset: 0x002BA4C4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroResponseConfig.StaticStruct();
		}

		// Token: 0x0601DA3A RID: 121402 RVA: 0x002BC2D0 File Offset: 0x002BA4D0
		[NullableContext(2)]
		public FKuroResponseConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA3B RID: 121403 RVA: 0x002BC2DA File Offset: 0x002BA4DA
		public FKuroResponseConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA3C RID: 121404 RVA: 0x002BC2E5 File Offset: 0x002BA4E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroResponseConfig(Pointer, false, true);
		}

		// Token: 0x0601DA3D RID: 121405 RVA: 0x002BC2EF File Offset: 0x002BA4EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroResponseConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040100EB RID: 65771
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KuroResponseConfig";

		// Token: 0x040100EC RID: 65772
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040100ED RID: 65773
		internal static int __PropertyOffset_CheckTagFilter;

		// Token: 0x040100EE RID: 65774
		[Nullable(2)]
		private FKSC_TagFilter _CheckTagFilter;

		// Token: 0x040100EF RID: 65775
		internal static int __PropertyOffset_Probability;

		// Token: 0x040100F0 RID: 65776
		internal static int __PropertyOffset_ResponseCount;

		// Token: 0x040100F1 RID: 65777
		internal static int __PropertyOffset_ResponseType;

		// Token: 0x040100F2 RID: 65778
		internal static int __PropertyOffset_ResponseTag;

		// Token: 0x040100F3 RID: 65779
		[Nullable(2)]
		private FGameplayTagContainer _ResponseTag;

		// Token: 0x040100F4 RID: 65780
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x040100F5 RID: 65781
		internal static int __PropertyOffset_AddMultiBuff;

		// Token: 0x040100F6 RID: 65782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddMultiBuff;

		// Token: 0x040100F7 RID: 65783
		internal static int __PropertyOffset_BuffStackNum;

		// Token: 0x040100F8 RID: 65784
		internal static int __PropertyOffset_AdditionalAttack;

		// Token: 0x040100F9 RID: 65785
		internal static int __PropertyOffset_SpawnEntity;

		// Token: 0x040100FA RID: 65786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpawnEntity> _SpawnEntity;

		// Token: 0x040100FB RID: 65787
		internal static int __PropertyOffset_SkillIndexTryStart;

		// Token: 0x040100FC RID: 65788
		[Nullable(2)]
		private TArray<int> _SkillIndexTryStart;

		// Token: 0x040100FD RID: 65789
		internal static int __PropertyOffset_MoveStageIndex;

		// Token: 0x040100FE RID: 65790
		internal static int __PropertyOffset_UseAttrProbability;

		// Token: 0x040100FF RID: 65791
		internal static int __PropertyOffset_ProbabilityAttr;
	}
}
