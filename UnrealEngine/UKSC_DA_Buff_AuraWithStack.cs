using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D58 RID: 7512
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AuraWithStack")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKSC_DA_Buff_AuraWithStack : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC4D RID: 117837 RVA: 0x002A8554 File Offset: 0x002A6754
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AuraWithStack._ClassPtr;
		}

		// Token: 0x0601CC4E RID: 117838 RVA: 0x002A8560 File Offset: 0x002A6760
		public UKSC_DA_Buff_AuraWithStack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AuraWithStack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC4F RID: 117839 RVA: 0x002A8588 File Offset: 0x002A6788
		public UKSC_DA_Buff_AuraWithStack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AuraWithStack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073CE RID: 29646
		// (get) Token: 0x0601CC50 RID: 117840 RVA: 0x002A85BB File Offset: 0x002A67BB
		// (set) Token: 0x0601CC51 RID: 117841 RVA: 0x002A85CB File Offset: 0x002A67CB
		public unsafe float UpdateFeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_UpdateFeq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_UpdateFeq) = value;
			}
		}

		// Token: 0x170073CF RID: 29647
		// (get) Token: 0x0601CC52 RID: 117842 RVA: 0x002A85DC File Offset: 0x002A67DC
		// (set) Token: 0x0601CC53 RID: 117843 RVA: 0x002A85EC File Offset: 0x002A67EC
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x170073D0 RID: 29648
		// (get) Token: 0x0601CC54 RID: 117844 RVA: 0x002A85FD File Offset: 0x002A67FD
		// (set) Token: 0x0601CC55 RID: 117845 RVA: 0x002A860D File Offset: 0x002A680D
		public unsafe float MaxRangeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_MaxRangeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_MaxRangeOffset) = value;
			}
		}

		// Token: 0x170073D1 RID: 29649
		// (get) Token: 0x0601CC56 RID: 117846 RVA: 0x002A861E File Offset: 0x002A681E
		// (set) Token: 0x0601CC57 RID: 117847 RVA: 0x002A862E File Offset: 0x002A682E
		public unsafe bool bLimitAuraEffectCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_bLimitAuraEffectCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_bLimitAuraEffectCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073D2 RID: 29650
		// (get) Token: 0x0601CC58 RID: 117848 RVA: 0x002A863F File Offset: 0x002A683F
		// (set) Token: 0x0601CC59 RID: 117849 RVA: 0x002A864F File Offset: 0x002A684F
		public unsafe int MaxAuraCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_MaxAuraCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_MaxAuraCount) = value;
			}
		}

		// Token: 0x170073D3 RID: 29651
		// (get) Token: 0x0601CC5A RID: 117850 RVA: 0x002A8660 File Offset: 0x002A6860
		// (set) Token: 0x0601CC5B RID: 117851 RVA: 0x002A8670 File Offset: 0x002A6870
		public unsafe EKSC_Buff_Aura_TargetType TargetType
		{
			get
			{
				return (EKSC_Buff_Aura_TargetType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_TargetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_TargetType) = (byte)value;
			}
		}

		// Token: 0x170073D4 RID: 29652
		// (get) Token: 0x0601CC5C RID: 117852 RVA: 0x002A8681 File Offset: 0x002A6881
		// (set) Token: 0x0601CC5D RID: 117853 RVA: 0x002A8691 File Offset: 0x002A6891
		public unsafe EKSC_Faction SelectFaction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_SelectFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_SelectFaction) = (byte)value;
			}
		}

		// Token: 0x170073D5 RID: 29653
		// (get) Token: 0x0601CC5E RID: 117854 RVA: 0x002A86A2 File Offset: 0x002A68A2
		// (set) Token: 0x0601CC5F RID: 117855 RVA: 0x002A86B2 File Offset: 0x002A68B2
		public unsafe EKSC_Buff_Aura_EnableType EnableType
		{
			get
			{
				return (EKSC_Buff_Aura_EnableType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_EnableType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_EnableType) = (byte)value;
			}
		}

		// Token: 0x170073D6 RID: 29654
		// (get) Token: 0x0601CC60 RID: 117856 RVA: 0x002A86C4 File Offset: 0x002A68C4
		// (set) Token: 0x0601CC61 RID: 117857 RVA: 0x002A86FD File Offset: 0x002A68FD
		public FKSC_TagFilter EnableTypeTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._EnableTypeTagFilter) == null)
				{
					result = (this._EnableTypeTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_EnableTypeTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_EnableTypeTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073D7 RID: 29655
		// (get) Token: 0x0601CC62 RID: 117858 RVA: 0x002A8720 File Offset: 0x002A6920
		// (set) Token: 0x0601CC63 RID: 117859 RVA: 0x002A8759 File Offset: 0x002A6959
		public TArray<UKSC_DA_Buff> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_AddBuffs, this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x170073D8 RID: 29656
		// (get) Token: 0x0601CC64 RID: 117860 RVA: 0x002A8767 File Offset: 0x002A6967
		// (set) Token: 0x0601CC65 RID: 117861 RVA: 0x002A8777 File Offset: 0x002A6977
		public unsafe bool ApplyDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_ApplyDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_ApplyDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073D9 RID: 29657
		// (get) Token: 0x0601CC66 RID: 117862 RVA: 0x002A8788 File Offset: 0x002A6988
		// (set) Token: 0x0601CC67 RID: 117863 RVA: 0x002A87C1 File Offset: 0x002A69C1
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073DA RID: 29658
		// (get) Token: 0x0601CC68 RID: 117864 RVA: 0x002A87E2 File Offset: 0x002A69E2
		// (set) Token: 0x0601CC69 RID: 117865 RVA: 0x002A87F2 File Offset: 0x002A69F2
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x170073DB RID: 29659
		// (get) Token: 0x0601CC6A RID: 117866 RVA: 0x002A8803 File Offset: 0x002A6A03
		// (set) Token: 0x0601CC6B RID: 117867 RVA: 0x002A8813 File Offset: 0x002A6A13
		public unsafe float RangeIncreasePerStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_RangeIncreasePerStack);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AuraWithStack.__PropertyOffset_RangeIncreasePerStack) = value;
			}
		}

		// Token: 0x0601CC6C RID: 117868 RVA: 0x002A8824 File Offset: 0x002A6A24
		static UKSC_DA_Buff_AuraWithStack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AuraWithStack");
		}

		// Token: 0x0601CC6D RID: 117869 RVA: 0x002A8832 File Offset: 0x002A6A32
		protected UKSC_DA_Buff_AuraWithStack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F998 RID: 63896
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AuraWithStack";

		// Token: 0x0400F999 RID: 63897
		private static IntPtr _ClassPtr;

		// Token: 0x0400F99A RID: 63898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F99B RID: 63899
		internal static int __PropertyOffset_UpdateFeq;

		// Token: 0x0400F99C RID: 63900
		internal static int __PropertyOffset_Range;

		// Token: 0x0400F99D RID: 63901
		internal static int __PropertyOffset_MaxRangeOffset;

		// Token: 0x0400F99E RID: 63902
		internal static int __PropertyOffset_bLimitAuraEffectCount;

		// Token: 0x0400F99F RID: 63903
		internal static int __PropertyOffset_MaxAuraCount;

		// Token: 0x0400F9A0 RID: 63904
		internal static int __PropertyOffset_TargetType;

		// Token: 0x0400F9A1 RID: 63905
		internal static int __PropertyOffset_SelectFaction;

		// Token: 0x0400F9A2 RID: 63906
		internal static int __PropertyOffset_EnableType;

		// Token: 0x0400F9A3 RID: 63907
		internal static int __PropertyOffset_EnableTypeTagFilter;

		// Token: 0x0400F9A4 RID: 63908
		[Nullable(2)]
		private FKSC_TagFilter _EnableTypeTagFilter;

		// Token: 0x0400F9A5 RID: 63909
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x0400F9A6 RID: 63910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _AddBuffs;

		// Token: 0x0400F9A7 RID: 63911
		internal static int __PropertyOffset_ApplyDamage;

		// Token: 0x0400F9A8 RID: 63912
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400F9A9 RID: 63913
		[Nullable(2)]
		private FKSCDamage _Damage;

		// Token: 0x0400F9AA RID: 63914
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400F9AB RID: 63915
		internal static int __PropertyOffset_RangeIncreasePerStack;
	}
}
