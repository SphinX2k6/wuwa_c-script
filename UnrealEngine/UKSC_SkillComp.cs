using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E3F RID: 7743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SkillComp")]
	[UnrealStructLayout(2120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2120)]
	public class UKSC_SkillComp : UKSC_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D80B RID: 120843 RVA: 0x002B8EF5 File Offset: 0x002B70F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_SkillComp._ClassPtr;
		}

		// Token: 0x0601D80C RID: 120844 RVA: 0x002B8F04 File Offset: 0x002B7104
		public UKSC_SkillComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_SkillComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D80D RID: 120845 RVA: 0x002B8F2C File Offset: 0x002B712C
		public UKSC_SkillComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_SkillComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076DD RID: 30429
		// (get) Token: 0x0601D80E RID: 120846 RVA: 0x002B8F5F File Offset: 0x002B715F
		// (set) Token: 0x0601D80F RID: 120847 RVA: 0x002B8F73 File Offset: 0x002B7173
		[Nullable(2)]
		public unsafe UKSC_AttrSet AttrSet_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_AttrSet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_AttrSet_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_AttrSet_, value);
			}
		}

		// Token: 0x170076DE RID: 30430
		// (get) Token: 0x0601D810 RID: 120848 RVA: 0x002B8F88 File Offset: 0x002B7188
		// (set) Token: 0x0601D811 RID: 120849 RVA: 0x002B8FC1 File Offset: 0x002B71C1
		public TMap<UKSC_DA_Skill, UKSC_Skill> SkillMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Skill, UKSC_Skill> result;
				if ((result = this._SkillMap) == null)
				{
					result = (this._SkillMap = new TMap<UKSC_DA_Skill, UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_SkillMap, this));
				}
				return result;
			}
			set
			{
				this.SkillMap.CopyAssign(value);
			}
		}

		// Token: 0x170076DF RID: 30431
		// (get) Token: 0x0601D812 RID: 120850 RVA: 0x002B8FD0 File Offset: 0x002B71D0
		// (set) Token: 0x0601D813 RID: 120851 RVA: 0x002B9009 File Offset: 0x002B7209
		public TArray<UKSC_Skill> Skills_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Skill> result;
				if ((result = this._Skills_) == null)
				{
					result = (this._Skills_ = new TArray<UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_Skills_, this));
				}
				return result;
			}
			set
			{
				this.Skills_.CopyAssign(value);
			}
		}

		// Token: 0x170076E0 RID: 30432
		// (get) Token: 0x0601D814 RID: 120852 RVA: 0x002B9018 File Offset: 0x002B7218
		// (set) Token: 0x0601D815 RID: 120853 RVA: 0x002B9051 File Offset: 0x002B7251
		public TSet<UKSC_Skill> ToActiveSkills_
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UKSC_Skill> result;
				if ((result = this._ToActiveSkills_) == null)
				{
					result = (this._ToActiveSkills_ = new TSet<UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToActiveSkills_, this));
				}
				return result;
			}
			set
			{
				this.ToActiveSkills_.CopyAssign(value);
			}
		}

		// Token: 0x170076E1 RID: 30433
		// (get) Token: 0x0601D816 RID: 120854 RVA: 0x002B9060 File Offset: 0x002B7260
		// (set) Token: 0x0601D817 RID: 120855 RVA: 0x002B9099 File Offset: 0x002B7299
		public TMap<UKSC_Bullet, UKSC_Skill> Bullets_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_Bullet, UKSC_Skill> result;
				if ((result = this._Bullets_) == null)
				{
					result = (this._Bullets_ = new TMap<UKSC_Bullet, UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_Bullets_, this));
				}
				return result;
			}
			set
			{
				this.Bullets_.CopyAssign(value);
			}
		}

		// Token: 0x170076E2 RID: 30434
		// (get) Token: 0x0601D818 RID: 120856 RVA: 0x002B90A8 File Offset: 0x002B72A8
		// (set) Token: 0x0601D819 RID: 120857 RVA: 0x002B90E1 File Offset: 0x002B72E1
		public TArray<UKSC_Bullet> ToRemoveBullets_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Bullet> result;
				if ((result = this._ToRemoveBullets_) == null)
				{
					result = (this._ToRemoveBullets_ = new TArray<UKSC_Bullet>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToRemoveBullets_, this));
				}
				return result;
			}
			set
			{
				this.ToRemoveBullets_.CopyAssign(value);
			}
		}

		// Token: 0x170076E3 RID: 30435
		// (get) Token: 0x0601D81A RID: 120858 RVA: 0x002B90F0 File Offset: 0x002B72F0
		// (set) Token: 0x0601D81B RID: 120859 RVA: 0x002B9129 File Offset: 0x002B7329
		public TMap<UKSC_DA_Buff, UKSC_Buff> Buffs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, UKSC_Buff> result;
				if ((result = this._Buffs_) == null)
				{
					result = (this._Buffs_ = new TMap<UKSC_DA_Buff, UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_Buffs_, this));
				}
				return result;
			}
			set
			{
				this.Buffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E4 RID: 30436
		// (get) Token: 0x0601D81C RID: 120860 RVA: 0x002B9138 File Offset: 0x002B7338
		// (set) Token: 0x0601D81D RID: 120861 RVA: 0x002B9171 File Offset: 0x002B7371
		public TMap<UKSC_DA_Buff, UKSC_Buff> ToAddBuffs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, UKSC_Buff> result;
				if ((result = this._ToAddBuffs_) == null)
				{
					result = (this._ToAddBuffs_ = new TMap<UKSC_DA_Buff, UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToAddBuffs_, this));
				}
				return result;
			}
			set
			{
				this.ToAddBuffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E5 RID: 30437
		// (get) Token: 0x0601D81E RID: 120862 RVA: 0x002B9180 File Offset: 0x002B7380
		// (set) Token: 0x0601D81F RID: 120863 RVA: 0x002B91B9 File Offset: 0x002B73B9
		public TMap<UKSC_DA_Buff, UKSC_Buff> ToRemoveBuffs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, UKSC_Buff> result;
				if ((result = this._ToRemoveBuffs_) == null)
				{
					result = (this._ToRemoveBuffs_ = new TMap<UKSC_DA_Buff, UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToRemoveBuffs_, this));
				}
				return result;
			}
			set
			{
				this.ToRemoveBuffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E6 RID: 30438
		// (get) Token: 0x0601D820 RID: 120864 RVA: 0x002B91C8 File Offset: 0x002B73C8
		// (set) Token: 0x0601D821 RID: 120865 RVA: 0x002B9201 File Offset: 0x002B7401
		public TMap<UKSC_DA_Buff, UKSC_Buff> UnEndRemoveBuffs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Buff, UKSC_Buff> result;
				if ((result = this._UnEndRemoveBuffs_) == null)
				{
					result = (this._UnEndRemoveBuffs_ = new TMap<UKSC_DA_Buff, UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_UnEndRemoveBuffs_, this));
				}
				return result;
			}
			set
			{
				this.UnEndRemoveBuffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E7 RID: 30439
		// (get) Token: 0x0601D822 RID: 120866 RVA: 0x002B9210 File Offset: 0x002B7410
		// (set) Token: 0x0601D823 RID: 120867 RVA: 0x002B9249 File Offset: 0x002B7449
		public TArray<UKSC_Buff> InstantBuffs_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Buff> result;
				if ((result = this._InstantBuffs_) == null)
				{
					result = (this._InstantBuffs_ = new TArray<UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_InstantBuffs_, this));
				}
				return result;
			}
			set
			{
				this.InstantBuffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E8 RID: 30440
		// (get) Token: 0x0601D824 RID: 120868 RVA: 0x002B9258 File Offset: 0x002B7458
		// (set) Token: 0x0601D825 RID: 120869 RVA: 0x002B9291 File Offset: 0x002B7491
		public TArray<UKSC_Buff> ToAddInstantBuffs_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Buff> result;
				if ((result = this._ToAddInstantBuffs_) == null)
				{
					result = (this._ToAddInstantBuffs_ = new TArray<UKSC_Buff>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToAddInstantBuffs_, this));
				}
				return result;
			}
			set
			{
				this.ToAddInstantBuffs_.CopyAssign(value);
			}
		}

		// Token: 0x170076E9 RID: 30441
		// (get) Token: 0x0601D826 RID: 120870 RVA: 0x002B929F File Offset: 0x002B749F
		// (set) Token: 0x0601D827 RID: 120871 RVA: 0x002B92B3 File Offset: 0x002B74B3
		[Nullable(2)]
		public unsafe UKSC_DA_SkillComp DA_SkillComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_DA_SkillComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_DA_SkillComp, value);
			}
		}

		// Token: 0x170076EA RID: 30442
		// (get) Token: 0x0601D828 RID: 120872 RVA: 0x002B92C8 File Offset: 0x002B74C8
		// (set) Token: 0x0601D829 RID: 120873 RVA: 0x002B9301 File Offset: 0x002B7501
		public FOnKSCBuffChange OnKSCBuffChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCBuffChange result;
				if ((result = this._OnKSCBuffChange) == null)
				{
					result = (this._OnKSCBuffChange = new FOnKSCBuffChange(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_OnKSCBuffChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_OnKSCBuffChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170076EB RID: 30443
		// (get) Token: 0x0601D82A RID: 120874 RVA: 0x002B9324 File Offset: 0x002B7524
		// (set) Token: 0x0601D82B RID: 120875 RVA: 0x002B935D File Offset: 0x002B755D
		public TSet<UObject> StopCastSkill
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._StopCastSkill) == null)
				{
					result = (this._StopCastSkill = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_StopCastSkill, this));
				}
				return result;
			}
			set
			{
				this.StopCastSkill.CopyAssign(value);
			}
		}

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x0601D82C RID: 120876 RVA: 0x002B936C File Offset: 0x002B756C
		// (set) Token: 0x0601D82D RID: 120877 RVA: 0x002B93A5 File Offset: 0x002B75A5
		public TMap<UObject, FGameplayTagContainer> InvisibleTagMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, FGameplayTagContainer> result;
				if ((result = this._InvisibleTagMap) == null)
				{
					result = (this._InvisibleTagMap = new TMap<UObject, FGameplayTagContainer>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_InvisibleTagMap, this));
				}
				return result;
			}
			set
			{
				this.InvisibleTagMap.CopyAssign(value);
			}
		}

		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x0601D82E RID: 120878 RVA: 0x002B93B4 File Offset: 0x002B75B4
		// (set) Token: 0x0601D82F RID: 120879 RVA: 0x002B93ED File Offset: 0x002B75ED
		public TSet<UObject> UnattackableSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._UnattackableSet) == null)
				{
					result = (this._UnattackableSet = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_UnattackableSet, this));
				}
				return result;
			}
			set
			{
				this.UnattackableSet.CopyAssign(value);
			}
		}

		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x0601D830 RID: 120880 RVA: 0x002B93FC File Offset: 0x002B75FC
		// (set) Token: 0x0601D831 RID: 120881 RVA: 0x002B9435 File Offset: 0x002B7635
		public TMap<UObject, FGameplayTagContainer> ImmuneBuffMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, FGameplayTagContainer> result;
				if ((result = this._ImmuneBuffMap) == null)
				{
					result = (this._ImmuneBuffMap = new TMap<UObject, FGameplayTagContainer>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ImmuneBuffMap, this));
				}
				return result;
			}
			set
			{
				this.ImmuneBuffMap.CopyAssign(value);
			}
		}

		// Token: 0x0601D832 RID: 120882 RVA: 0x002B9443 File Offset: 0x002B7643
		public float GetSkillCollDown()
		{
			return UKSC_SkillComp.__GetSkillCollDown_Internal(base.NativePtr);
		}

		// Token: 0x0601D833 RID: 120883 RVA: 0x002B9450 File Offset: 0x002B7650
		public void GetAllBuffs([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UKSC_DA_Buff, int> OutBuffs)
		{
			UKSC_SkillComp.__GetAllBuffs_Internal(base.NativePtr, (OutBuffs ?? new TMap<UKSC_DA_Buff, int>()).NativeMapPtr);
		}

		// Token: 0x0601D834 RID: 120884 RVA: 0x002B946D File Offset: 0x002B766D
		public void Debug_GetAllBuffInfo([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutBuffs)
		{
			UKSC_SkillComp.__Debug_GetAllBuffInfo_Internal(base.NativePtr, (OutBuffs ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0601D835 RID: 120885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCollDown_Internal(IntPtr @this);

		// Token: 0x0601D836 RID: 120886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllBuffs_Internal(IntPtr @this, IntPtr OutBuffs);

		// Token: 0x0601D837 RID: 120887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Debug_GetAllBuffInfo_Internal(IntPtr @this, IntPtr OutBuffs);

		// Token: 0x0601D838 RID: 120888 RVA: 0x002B948A File Offset: 0x002B768A
		static UKSC_SkillComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SkillComp");
		}

		// Token: 0x0601D839 RID: 120889 RVA: 0x002B9498 File Offset: 0x002B7698
		protected UKSC_SkillComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFDA RID: 65498
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SkillComp";

		// Token: 0x0400FFDB RID: 65499
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFDC RID: 65500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFDD RID: 65501
		internal static int __PropertyOffset_AttrSet_;

		// Token: 0x0400FFDE RID: 65502
		internal static int __PropertyOffset_SkillMap;

		// Token: 0x0400FFDF RID: 65503
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Skill, UKSC_Skill> _SkillMap;

		// Token: 0x0400FFE0 RID: 65504
		internal static int __PropertyOffset_Skills_;

		// Token: 0x0400FFE1 RID: 65505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Skill> _Skills_;

		// Token: 0x0400FFE2 RID: 65506
		internal static int __PropertyOffset_ToActiveSkills_;

		// Token: 0x0400FFE3 RID: 65507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKSC_Skill> _ToActiveSkills_;

		// Token: 0x0400FFE4 RID: 65508
		internal static int __PropertyOffset_Bullets_;

		// Token: 0x0400FFE5 RID: 65509
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_Bullet, UKSC_Skill> _Bullets_;

		// Token: 0x0400FFE6 RID: 65510
		internal static int __PropertyOffset_ToRemoveBullets_;

		// Token: 0x0400FFE7 RID: 65511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Bullet> _ToRemoveBullets_;

		// Token: 0x0400FFE8 RID: 65512
		internal static int __PropertyOffset_Buffs_;

		// Token: 0x0400FFE9 RID: 65513
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Buff, UKSC_Buff> _Buffs_;

		// Token: 0x0400FFEA RID: 65514
		internal static int __PropertyOffset_ToAddBuffs_;

		// Token: 0x0400FFEB RID: 65515
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Buff, UKSC_Buff> _ToAddBuffs_;

		// Token: 0x0400FFEC RID: 65516
		internal static int __PropertyOffset_ToRemoveBuffs_;

		// Token: 0x0400FFED RID: 65517
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Buff, UKSC_Buff> _ToRemoveBuffs_;

		// Token: 0x0400FFEE RID: 65518
		internal static int __PropertyOffset_UnEndRemoveBuffs_;

		// Token: 0x0400FFEF RID: 65519
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Buff, UKSC_Buff> _UnEndRemoveBuffs_;

		// Token: 0x0400FFF0 RID: 65520
		internal static int __PropertyOffset_InstantBuffs_;

		// Token: 0x0400FFF1 RID: 65521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Buff> _InstantBuffs_;

		// Token: 0x0400FFF2 RID: 65522
		internal static int __PropertyOffset_ToAddInstantBuffs_;

		// Token: 0x0400FFF3 RID: 65523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Buff> _ToAddInstantBuffs_;

		// Token: 0x0400FFF4 RID: 65524
		internal static int __PropertyOffset_DA_SkillComp;

		// Token: 0x0400FFF5 RID: 65525
		internal static int __PropertyOffset_OnKSCBuffChange;

		// Token: 0x0400FFF6 RID: 65526
		[Nullable(2)]
		private FOnKSCBuffChange _OnKSCBuffChange;

		// Token: 0x0400FFF7 RID: 65527
		internal static int __PropertyOffset_StopCastSkill;

		// Token: 0x0400FFF8 RID: 65528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _StopCastSkill;

		// Token: 0x0400FFF9 RID: 65529
		internal static int __PropertyOffset_InvisibleTagMap;

		// Token: 0x0400FFFA RID: 65530
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, FGameplayTagContainer> _InvisibleTagMap;

		// Token: 0x0400FFFB RID: 65531
		internal static int __PropertyOffset_UnattackableSet;

		// Token: 0x0400FFFC RID: 65532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _UnattackableSet;

		// Token: 0x0400FFFD RID: 65533
		internal static int __PropertyOffset_ImmuneBuffMap;

		// Token: 0x0400FFFE RID: 65534
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, FGameplayTagContainer> _ImmuneBuffMap;
	}
}
