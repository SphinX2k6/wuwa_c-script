using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBA RID: 7610
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SkillComp")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKSC_DA_SkillComp : UKSC_DA_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1AB RID: 119211 RVA: 0x002B0071 File Offset: 0x002AE271
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SkillComp._ClassPtr;
		}

		// Token: 0x0601D1AC RID: 119212 RVA: 0x002B0080 File Offset: 0x002AE280
		public UKSC_DA_SkillComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SkillComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1AD RID: 119213 RVA: 0x002B00A8 File Offset: 0x002AE2A8
		public UKSC_DA_SkillComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SkillComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007589 RID: 30089
		// (get) Token: 0x0601D1AE RID: 119214 RVA: 0x002B00DB File Offset: 0x002AE2DB
		// (set) Token: 0x0601D1AF RID: 119215 RVA: 0x002B00EF File Offset: 0x002AE2EF
		[Nullable(2)]
		public unsafe UKSC_DA_AttrSet AttrSet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AttrSet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_SkillComp.__PropertyOffset_AttrSet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_SkillComp.__PropertyOffset_AttrSet, value);
			}
		}

		// Token: 0x1700758A RID: 30090
		// (get) Token: 0x0601D1B0 RID: 119216 RVA: 0x002B0104 File Offset: 0x002AE304
		// (set) Token: 0x0601D1B1 RID: 119217 RVA: 0x002B0114 File Offset: 0x002AE314
		public unsafe EKSC_SkillCastMode SkillCastMode
		{
			get
			{
				return (EKSC_SkillCastMode)(*(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_SkillCastMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_SkillCastMode) = (byte)value;
			}
		}

		// Token: 0x1700758B RID: 30091
		// (get) Token: 0x0601D1B2 RID: 119218 RVA: 0x002B0128 File Offset: 0x002AE328
		// (set) Token: 0x0601D1B3 RID: 119219 RVA: 0x002B0161 File Offset: 0x002AE361
		public TArray<UKSC_DA_Skill> Skills
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Skill> result;
				if ((result = this._Skills) == null)
				{
					result = (this._Skills = new TArray<UKSC_DA_Skill>(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_Skills, this));
				}
				return result;
			}
			set
			{
				this.Skills.CopyAssign(value);
			}
		}

		// Token: 0x1700758C RID: 30092
		// (get) Token: 0x0601D1B4 RID: 119220 RVA: 0x002B0170 File Offset: 0x002AE370
		// (set) Token: 0x0601D1B5 RID: 119221 RVA: 0x002B01A9 File Offset: 0x002AE3A9
		public TArray<UKSC_DA_Buff> Buffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._Buffs) == null)
				{
					result = (this._Buffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_Buffs, this));
				}
				return result;
			}
			set
			{
				this.Buffs.CopyAssign(value);
			}
		}

		// Token: 0x1700758D RID: 30093
		// (get) Token: 0x0601D1B6 RID: 119222 RVA: 0x002B01B8 File Offset: 0x002AE3B8
		// (set) Token: 0x0601D1B7 RID: 119223 RVA: 0x002B01F1 File Offset: 0x002AE3F1
		public FGameplayTagContainer Tags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700758E RID: 30094
		// (get) Token: 0x0601D1B8 RID: 119224 RVA: 0x002B0212 File Offset: 0x002AE412
		// (set) Token: 0x0601D1B9 RID: 119225 RVA: 0x002B0222 File Offset: 0x002AE422
		public unsafe bool bAddHitInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_bAddHitInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_bAddHitInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700758F RID: 30095
		// (get) Token: 0x0601D1BA RID: 119226 RVA: 0x002B0233 File Offset: 0x002AE433
		// (set) Token: 0x0601D1BB RID: 119227 RVA: 0x002B0243 File Offset: 0x002AE443
		public unsafe EKSC_AttrType DodgeAttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_DodgeAttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SkillComp.__PropertyOffset_DodgeAttrType) = (byte)value;
			}
		}

		// Token: 0x0601D1BC RID: 119228 RVA: 0x002B0254 File Offset: 0x002AE454
		static UKSC_DA_SkillComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SkillComp");
		}

		// Token: 0x0601D1BD RID: 119229 RVA: 0x002B0262 File Offset: 0x002AE462
		protected UKSC_DA_SkillComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCC9 RID: 64713
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SkillComp";

		// Token: 0x0400FCCA RID: 64714
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCCB RID: 64715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCCC RID: 64716
		internal static int __PropertyOffset_AttrSet;

		// Token: 0x0400FCCD RID: 64717
		internal static int __PropertyOffset_SkillCastMode;

		// Token: 0x0400FCCE RID: 64718
		internal static int __PropertyOffset_Skills;

		// Token: 0x0400FCCF RID: 64719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Skill> _Skills;

		// Token: 0x0400FCD0 RID: 64720
		internal static int __PropertyOffset_Buffs;

		// Token: 0x0400FCD1 RID: 64721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _Buffs;

		// Token: 0x0400FCD2 RID: 64722
		internal static int __PropertyOffset_Tags;

		// Token: 0x0400FCD3 RID: 64723
		[Nullable(2)]
		private FGameplayTagContainer _Tags;

		// Token: 0x0400FCD4 RID: 64724
		internal static int __PropertyOffset_bAddHitInfo;

		// Token: 0x0400FCD5 RID: 64725
		internal static int __PropertyOffset_DodgeAttrType;
	}
}
