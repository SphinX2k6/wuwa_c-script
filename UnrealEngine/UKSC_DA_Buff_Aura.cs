using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D57 RID: 7511
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Aura")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKSC_DA_Buff_Aura : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC1E RID: 117790 RVA: 0x002A816C File Offset: 0x002A636C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Aura._ClassPtr;
		}

		// Token: 0x0601CC1F RID: 117791 RVA: 0x002A8178 File Offset: 0x002A6378
		public UKSC_DA_Buff_Aura() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Aura.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC20 RID: 117792 RVA: 0x002A81A0 File Offset: 0x002A63A0
		public UKSC_DA_Buff_Aura(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Aura.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073B9 RID: 29625
		// (get) Token: 0x0601CC21 RID: 117793 RVA: 0x002A81D3 File Offset: 0x002A63D3
		// (set) Token: 0x0601CC22 RID: 117794 RVA: 0x002A81E3 File Offset: 0x002A63E3
		public unsafe float UpdateFeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_UpdateFeq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_UpdateFeq) = value;
			}
		}

		// Token: 0x170073BA RID: 29626
		// (get) Token: 0x0601CC23 RID: 117795 RVA: 0x002A81F4 File Offset: 0x002A63F4
		// (set) Token: 0x0601CC24 RID: 117796 RVA: 0x002A8204 File Offset: 0x002A6404
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x170073BB RID: 29627
		// (get) Token: 0x0601CC25 RID: 117797 RVA: 0x002A8215 File Offset: 0x002A6415
		// (set) Token: 0x0601CC26 RID: 117798 RVA: 0x002A8225 File Offset: 0x002A6425
		public unsafe float MaxRangeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_MaxRangeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_MaxRangeOffset) = value;
			}
		}

		// Token: 0x170073BC RID: 29628
		// (get) Token: 0x0601CC27 RID: 117799 RVA: 0x002A8236 File Offset: 0x002A6436
		// (set) Token: 0x0601CC28 RID: 117800 RVA: 0x002A8246 File Offset: 0x002A6446
		public unsafe EKSC_Buff_Aura_AttrEffectType AttrEffectType
		{
			get
			{
				return (EKSC_Buff_Aura_AttrEffectType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_AttrEffectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_AttrEffectType) = (byte)value;
			}
		}

		// Token: 0x170073BD RID: 29629
		// (get) Token: 0x0601CC29 RID: 117801 RVA: 0x002A8257 File Offset: 0x002A6457
		// (set) Token: 0x0601CC2A RID: 117802 RVA: 0x002A8267 File Offset: 0x002A6467
		public unsafe EKSC_AttrType AttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_AttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_AttrType) = (byte)value;
			}
		}

		// Token: 0x170073BE RID: 29630
		// (get) Token: 0x0601CC2B RID: 117803 RVA: 0x002A8278 File Offset: 0x002A6478
		// (set) Token: 0x0601CC2C RID: 117804 RVA: 0x002A8288 File Offset: 0x002A6488
		public unsafe bool bLimitAuraEffectCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_bLimitAuraEffectCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_bLimitAuraEffectCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073BF RID: 29631
		// (get) Token: 0x0601CC2D RID: 117805 RVA: 0x002A8299 File Offset: 0x002A6499
		// (set) Token: 0x0601CC2E RID: 117806 RVA: 0x002A82A9 File Offset: 0x002A64A9
		public unsafe int MaxAuraCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_MaxAuraCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_MaxAuraCount) = value;
			}
		}

		// Token: 0x170073C0 RID: 29632
		// (get) Token: 0x0601CC2F RID: 117807 RVA: 0x002A82BA File Offset: 0x002A64BA
		// (set) Token: 0x0601CC30 RID: 117808 RVA: 0x002A82CA File Offset: 0x002A64CA
		public unsafe EKSC_Buff_Aura_TargetType TargetType
		{
			get
			{
				return (EKSC_Buff_Aura_TargetType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_TargetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_TargetType) = (byte)value;
			}
		}

		// Token: 0x170073C1 RID: 29633
		// (get) Token: 0x0601CC31 RID: 117809 RVA: 0x002A82DB File Offset: 0x002A64DB
		// (set) Token: 0x0601CC32 RID: 117810 RVA: 0x002A82EB File Offset: 0x002A64EB
		public unsafe EKSC_Faction SelectFaction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_SelectFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_SelectFaction) = (byte)value;
			}
		}

		// Token: 0x170073C2 RID: 29634
		// (get) Token: 0x0601CC33 RID: 117811 RVA: 0x002A82FC File Offset: 0x002A64FC
		// (set) Token: 0x0601CC34 RID: 117812 RVA: 0x002A830C File Offset: 0x002A650C
		public unsafe EKSC_Buff_Aura_EnableType EnableType
		{
			get
			{
				return (EKSC_Buff_Aura_EnableType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_EnableType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_EnableType) = (byte)value;
			}
		}

		// Token: 0x170073C3 RID: 29635
		// (get) Token: 0x0601CC35 RID: 117813 RVA: 0x002A8320 File Offset: 0x002A6520
		// (set) Token: 0x0601CC36 RID: 117814 RVA: 0x002A8359 File Offset: 0x002A6559
		public FKSC_TagFilter EnableTypeTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._EnableTypeTagFilter) == null)
				{
					result = (this._EnableTypeTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_EnableTypeTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_EnableTypeTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073C4 RID: 29636
		// (get) Token: 0x0601CC37 RID: 117815 RVA: 0x002A837C File Offset: 0x002A657C
		// (set) Token: 0x0601CC38 RID: 117816 RVA: 0x002A83B5 File Offset: 0x002A65B5
		public TArray<UKSC_DA_Buff> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_AddBuffs, this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x170073C5 RID: 29637
		// (get) Token: 0x0601CC39 RID: 117817 RVA: 0x002A83C3 File Offset: 0x002A65C3
		// (set) Token: 0x0601CC3A RID: 117818 RVA: 0x002A83D3 File Offset: 0x002A65D3
		public unsafe bool ApplyDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_ApplyDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_ApplyDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073C6 RID: 29638
		// (get) Token: 0x0601CC3B RID: 117819 RVA: 0x002A83E4 File Offset: 0x002A65E4
		// (set) Token: 0x0601CC3C RID: 117820 RVA: 0x002A841D File Offset: 0x002A661D
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073C7 RID: 29639
		// (get) Token: 0x0601CC3D RID: 117821 RVA: 0x002A843E File Offset: 0x002A663E
		// (set) Token: 0x0601CC3E RID: 117822 RVA: 0x002A844E File Offset: 0x002A664E
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x170073C8 RID: 29640
		// (get) Token: 0x0601CC3F RID: 117823 RVA: 0x002A845F File Offset: 0x002A665F
		// (set) Token: 0x0601CC40 RID: 117824 RVA: 0x002A8473 File Offset: 0x002A6673
		[Nullable(2)]
		public unsafe UEffectModelBase BuffFX_Check
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_Check);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_Check, value);
			}
		}

		// Token: 0x170073C9 RID: 29641
		// (get) Token: 0x0601CC41 RID: 117825 RVA: 0x002A8488 File Offset: 0x002A6688
		// (set) Token: 0x0601CC42 RID: 117826 RVA: 0x002A849C File Offset: 0x002A669C
		public unsafe FTransform BuffFX_Offset_Check
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_Offset_Check);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_Offset_Check) = value;
			}
		}

		// Token: 0x170073CA RID: 29642
		// (get) Token: 0x0601CC43 RID: 117827 RVA: 0x002A84B1 File Offset: 0x002A66B1
		// (set) Token: 0x0601CC44 RID: 117828 RVA: 0x002A84C5 File Offset: 0x002A66C5
		public unsafe FName Socket_Check
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Socket_Check);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_Socket_Check) = value;
			}
		}

		// Token: 0x170073CB RID: 29643
		// (get) Token: 0x0601CC45 RID: 117829 RVA: 0x002A84DA File Offset: 0x002A66DA
		// (set) Token: 0x0601CC46 RID: 117830 RVA: 0x002A84EA File Offset: 0x002A66EA
		public unsafe bool BuffFX_AttackLocation_Check
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackLocation_Check) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackLocation_Check) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073CC RID: 29644
		// (get) Token: 0x0601CC47 RID: 117831 RVA: 0x002A84FB File Offset: 0x002A66FB
		// (set) Token: 0x0601CC48 RID: 117832 RVA: 0x002A850B File Offset: 0x002A670B
		public unsafe bool BuffFX_AttackRotation_Check
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackRotation_Check) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackRotation_Check) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073CD RID: 29645
		// (get) Token: 0x0601CC49 RID: 117833 RVA: 0x002A851C File Offset: 0x002A671C
		// (set) Token: 0x0601CC4A RID: 117834 RVA: 0x002A852C File Offset: 0x002A672C
		public unsafe bool BuffFX_AttackScale_Check
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackScale_Check) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Aura.__PropertyOffset_BuffFX_AttackScale_Check) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CC4B RID: 117835 RVA: 0x002A853D File Offset: 0x002A673D
		static UKSC_DA_Buff_Aura()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Aura");
		}

		// Token: 0x0601CC4C RID: 117836 RVA: 0x002A854B File Offset: 0x002A674B
		protected UKSC_DA_Buff_Aura(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F97D RID: 63869
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Aura";

		// Token: 0x0400F97E RID: 63870
		private static IntPtr _ClassPtr;

		// Token: 0x0400F97F RID: 63871
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F980 RID: 63872
		internal static int __PropertyOffset_UpdateFeq;

		// Token: 0x0400F981 RID: 63873
		internal static int __PropertyOffset_Range;

		// Token: 0x0400F982 RID: 63874
		internal static int __PropertyOffset_MaxRangeOffset;

		// Token: 0x0400F983 RID: 63875
		internal static int __PropertyOffset_AttrEffectType;

		// Token: 0x0400F984 RID: 63876
		internal static int __PropertyOffset_AttrType;

		// Token: 0x0400F985 RID: 63877
		internal static int __PropertyOffset_bLimitAuraEffectCount;

		// Token: 0x0400F986 RID: 63878
		internal static int __PropertyOffset_MaxAuraCount;

		// Token: 0x0400F987 RID: 63879
		internal static int __PropertyOffset_TargetType;

		// Token: 0x0400F988 RID: 63880
		internal static int __PropertyOffset_SelectFaction;

		// Token: 0x0400F989 RID: 63881
		internal static int __PropertyOffset_EnableType;

		// Token: 0x0400F98A RID: 63882
		internal static int __PropertyOffset_EnableTypeTagFilter;

		// Token: 0x0400F98B RID: 63883
		[Nullable(2)]
		private FKSC_TagFilter _EnableTypeTagFilter;

		// Token: 0x0400F98C RID: 63884
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x0400F98D RID: 63885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddBuffs;

		// Token: 0x0400F98E RID: 63886
		internal static int __PropertyOffset_ApplyDamage;

		// Token: 0x0400F98F RID: 63887
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400F990 RID: 63888
		[Nullable(2)]
		private FKSCDamage _Damage;

		// Token: 0x0400F991 RID: 63889
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400F992 RID: 63890
		internal static int __PropertyOffset_BuffFX_Check;

		// Token: 0x0400F993 RID: 63891
		internal static int __PropertyOffset_BuffFX_Offset_Check;

		// Token: 0x0400F994 RID: 63892
		internal static int __PropertyOffset_Socket_Check;

		// Token: 0x0400F995 RID: 63893
		internal static int __PropertyOffset_BuffFX_AttackLocation_Check;

		// Token: 0x0400F996 RID: 63894
		internal static int __PropertyOffset_BuffFX_AttackRotation_Check;

		// Token: 0x0400F997 RID: 63895
		internal static int __PropertyOffset_BuffFX_AttackScale_Check;
	}
}
