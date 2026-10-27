using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D59 RID: 7513
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ChainLightning")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UKSC_DA_Buff_ChainLightning : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC6E RID: 117870 RVA: 0x002A883B File Offset: 0x002A6A3B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ChainLightning._ClassPtr;
		}

		// Token: 0x0601CC6F RID: 117871 RVA: 0x002A8848 File Offset: 0x002A6A48
		public UKSC_DA_Buff_ChainLightning() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ChainLightning.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC70 RID: 117872 RVA: 0x002A8870 File Offset: 0x002A6A70
		[NullableContext(1)]
		public UKSC_DA_Buff_ChainLightning(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ChainLightning.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073DC RID: 29660
		// (get) Token: 0x0601CC71 RID: 117873 RVA: 0x002A88A3 File Offset: 0x002A6AA3
		// (set) Token: 0x0601CC72 RID: 117874 RVA: 0x002A88B3 File Offset: 0x002A6AB3
		public unsafe float AttackRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AttackRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AttackRange) = value;
			}
		}

		// Token: 0x170073DD RID: 29661
		// (get) Token: 0x0601CC73 RID: 117875 RVA: 0x002A88C4 File Offset: 0x002A6AC4
		// (set) Token: 0x0601CC74 RID: 117876 RVA: 0x002A88D4 File Offset: 0x002A6AD4
		public unsafe int ChainkNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_ChainkNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_ChainkNum) = value;
			}
		}

		// Token: 0x170073DE RID: 29662
		// (get) Token: 0x0601CC75 RID: 117877 RVA: 0x002A88E8 File Offset: 0x002A6AE8
		// (set) Token: 0x0601CC76 RID: 117878 RVA: 0x002A8921 File Offset: 0x002A6B21
		[Nullable(1)]
		public FKSCDamage BaseDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._BaseDamage) == null)
				{
					result = (this._BaseDamage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_BaseDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_BaseDamage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073DF RID: 29663
		// (get) Token: 0x0601CC77 RID: 117879 RVA: 0x002A8942 File Offset: 0x002A6B42
		// (set) Token: 0x0601CC78 RID: 117880 RVA: 0x002A8952 File Offset: 0x002A6B52
		public unsafe int BaseDamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_BaseDamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_BaseDamageID) = value;
			}
		}

		// Token: 0x170073E0 RID: 29664
		// (get) Token: 0x0601CC79 RID: 117881 RVA: 0x002A8964 File Offset: 0x002A6B64
		// (set) Token: 0x0601CC7A RID: 117882 RVA: 0x002A899D File Offset: 0x002A6B9D
		[Nullable(1)]
		public FKSC_TagFilter TargetTagFilter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._TargetTagFilter) == null)
				{
					result = (this._TargetTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_TargetTagFilter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_TargetTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073E1 RID: 29665
		// (get) Token: 0x0601CC7B RID: 117883 RVA: 0x002A89BE File Offset: 0x002A6BBE
		// (set) Token: 0x0601CC7C RID: 117884 RVA: 0x002A89CE File Offset: 0x002A6BCE
		public unsafe EKSC_Faction TargetFaction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_TargetFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_TargetFaction) = (byte)value;
			}
		}

		// Token: 0x170073E2 RID: 29666
		// (get) Token: 0x0601CC7D RID: 117885 RVA: 0x002A89DF File Offset: 0x002A6BDF
		// (set) Token: 0x0601CC7E RID: 117886 RVA: 0x002A89EF File Offset: 0x002A6BEF
		public unsafe bool ListenZeroDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_ListenZeroDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_ListenZeroDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073E3 RID: 29667
		// (get) Token: 0x0601CC7F RID: 117887 RVA: 0x002A8A00 File Offset: 0x002A6C00
		// (set) Token: 0x0601CC80 RID: 117888 RVA: 0x002A8A14 File Offset: 0x002A6C14
		public unsafe UKSC_DA_Buff AddBuffHitBefore
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_AddBuffHitBefore);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_AddBuffHitBefore, value);
			}
		}

		// Token: 0x170073E4 RID: 29668
		// (get) Token: 0x0601CC81 RID: 117889 RVA: 0x002A8A29 File Offset: 0x002A6C29
		// (set) Token: 0x0601CC82 RID: 117890 RVA: 0x002A8A3D File Offset: 0x002A6C3D
		public unsafe UKSC_DA_Buff AddBuffHitAfter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_AddBuffHitAfter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_AddBuffHitAfter, value);
			}
		}

		// Token: 0x170073E5 RID: 29669
		// (get) Token: 0x0601CC83 RID: 117891 RVA: 0x002A8A52 File Offset: 0x002A6C52
		// (set) Token: 0x0601CC84 RID: 117892 RVA: 0x002A8A62 File Offset: 0x002A6C62
		public unsafe int MinCheckHP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_MinCheckHP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_MinCheckHP) = value;
			}
		}

		// Token: 0x170073E6 RID: 29670
		// (get) Token: 0x0601CC85 RID: 117893 RVA: 0x002A8A74 File Offset: 0x002A6C74
		// (set) Token: 0x0601CC86 RID: 117894 RVA: 0x002A8AAD File Offset: 0x002A6CAD
		[Nullable(1)]
		public FKSCDamage AdditionalDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._AdditionalDamage) == null)
				{
					result = (this._AdditionalDamage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AdditionalDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AdditionalDamage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073E7 RID: 29671
		// (get) Token: 0x0601CC87 RID: 117895 RVA: 0x002A8ACE File Offset: 0x002A6CCE
		// (set) Token: 0x0601CC88 RID: 117896 RVA: 0x002A8ADE File Offset: 0x002A6CDE
		public unsafe int AdditionalDamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AdditionalDamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_AdditionalDamageID) = value;
			}
		}

		// Token: 0x170073E8 RID: 29672
		// (get) Token: 0x0601CC89 RID: 117897 RVA: 0x002A8AEF File Offset: 0x002A6CEF
		// (set) Token: 0x0601CC8A RID: 117898 RVA: 0x002A8B03 File Offset: 0x002A6D03
		public unsafe UEffectModelBase KuroCastFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroCastFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroCastFX, value);
			}
		}

		// Token: 0x170073E9 RID: 29673
		// (get) Token: 0x0601CC8B RID: 117899 RVA: 0x002A8B18 File Offset: 0x002A6D18
		// (set) Token: 0x0601CC8C RID: 117900 RVA: 0x002A8B2C File Offset: 0x002A6D2C
		public unsafe FTransform KuroCastFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroCastFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroCastFX_Offset) = value;
			}
		}

		// Token: 0x170073EA RID: 29674
		// (get) Token: 0x0601CC8D RID: 117901 RVA: 0x002A8B41 File Offset: 0x002A6D41
		// (set) Token: 0x0601CC8E RID: 117902 RVA: 0x002A8B51 File Offset: 0x002A6D51
		public unsafe int KuroHitFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX_MaxNum) = value;
			}
		}

		// Token: 0x170073EB RID: 29675
		// (get) Token: 0x0601CC8F RID: 117903 RVA: 0x002A8B62 File Offset: 0x002A6D62
		// (set) Token: 0x0601CC90 RID: 117904 RVA: 0x002A8B76 File Offset: 0x002A6D76
		public unsafe UEffectModelBase KuroHitFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX, value);
			}
		}

		// Token: 0x170073EC RID: 29676
		// (get) Token: 0x0601CC91 RID: 117905 RVA: 0x002A8B8B File Offset: 0x002A6D8B
		// (set) Token: 0x0601CC92 RID: 117906 RVA: 0x002A8B9F File Offset: 0x002A6D9F
		public unsafe FTransform KuroHitFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ChainLightning.__PropertyOffset_KuroHitFX_Offset) = value;
			}
		}

		// Token: 0x0601CC93 RID: 117907 RVA: 0x002A8BB4 File Offset: 0x002A6DB4
		static UKSC_DA_Buff_ChainLightning()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ChainLightning");
		}

		// Token: 0x0601CC94 RID: 117908 RVA: 0x002A8BC2 File Offset: 0x002A6DC2
		protected UKSC_DA_Buff_ChainLightning(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9AC RID: 63916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ChainLightning";

		// Token: 0x0400F9AD RID: 63917
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9AE RID: 63918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9AF RID: 63919
		internal static int __PropertyOffset_AttackRange;

		// Token: 0x0400F9B0 RID: 63920
		internal static int __PropertyOffset_ChainkNum;

		// Token: 0x0400F9B1 RID: 63921
		internal static int __PropertyOffset_BaseDamage;

		// Token: 0x0400F9B2 RID: 63922
		private FKSCDamage _BaseDamage;

		// Token: 0x0400F9B3 RID: 63923
		internal static int __PropertyOffset_BaseDamageID;

		// Token: 0x0400F9B4 RID: 63924
		internal static int __PropertyOffset_TargetTagFilter;

		// Token: 0x0400F9B5 RID: 63925
		private FKSC_TagFilter _TargetTagFilter;

		// Token: 0x0400F9B6 RID: 63926
		internal static int __PropertyOffset_TargetFaction;

		// Token: 0x0400F9B7 RID: 63927
		internal static int __PropertyOffset_ListenZeroDamage;

		// Token: 0x0400F9B8 RID: 63928
		internal static int __PropertyOffset_AddBuffHitBefore;

		// Token: 0x0400F9B9 RID: 63929
		internal static int __PropertyOffset_AddBuffHitAfter;

		// Token: 0x0400F9BA RID: 63930
		internal static int __PropertyOffset_MinCheckHP;

		// Token: 0x0400F9BB RID: 63931
		internal static int __PropertyOffset_AdditionalDamage;

		// Token: 0x0400F9BC RID: 63932
		private FKSCDamage _AdditionalDamage;

		// Token: 0x0400F9BD RID: 63933
		internal static int __PropertyOffset_AdditionalDamageID;

		// Token: 0x0400F9BE RID: 63934
		internal static int __PropertyOffset_KuroCastFX;

		// Token: 0x0400F9BF RID: 63935
		internal static int __PropertyOffset_KuroCastFX_Offset;

		// Token: 0x0400F9C0 RID: 63936
		internal static int __PropertyOffset_KuroHitFX_MaxNum;

		// Token: 0x0400F9C1 RID: 63937
		internal static int __PropertyOffset_KuroHitFX;

		// Token: 0x0400F9C2 RID: 63938
		internal static int __PropertyOffset_KuroHitFX_Offset;
	}
}
