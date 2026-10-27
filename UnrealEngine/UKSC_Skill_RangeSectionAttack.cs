using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E51 RID: 7761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_RangeSectionAttack")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKSC_Skill_RangeSectionAttack : UKSC_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8B7 RID: 121015 RVA: 0x002BA01B File Offset: 0x002B821B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_RangeSectionAttack._ClassPtr;
		}

		// Token: 0x0601D8B8 RID: 121016 RVA: 0x002BA028 File Offset: 0x002B8228
		public UKSC_Skill_RangeSectionAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeSectionAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8B9 RID: 121017 RVA: 0x002BA050 File Offset: 0x002B8250
		public UKSC_Skill_RangeSectionAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeSectionAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x0601D8BA RID: 121018 RVA: 0x002BA083 File Offset: 0x002B8283
		// (set) Token: 0x0601D8BB RID: 121019 RVA: 0x002BA097 File Offset: 0x002B8297
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_RangeSectionAttack DaSkillRangeSectionAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_RangeSectionAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeSectionAttack.__PropertyOffset_DaSkillRangeSectionAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeSectionAttack.__PropertyOffset_DaSkillRangeSectionAttack_, value);
			}
		}

		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x0601D8BC RID: 121020 RVA: 0x002BA0AC File Offset: 0x002B82AC
		// (set) Token: 0x0601D8BD RID: 121021 RVA: 0x002BA0E5 File Offset: 0x002B82E5
		public TSet<UKSC_SkillComp> ProcessedTargets_
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UKSC_SkillComp> result;
				if ((result = this._ProcessedTargets_) == null)
				{
					result = (this._ProcessedTargets_ = new TSet<UKSC_SkillComp>(base.NativePtr + (IntPtr)UKSC_Skill_RangeSectionAttack.__PropertyOffset_ProcessedTargets_, this));
				}
				return result;
			}
			set
			{
				this.ProcessedTargets_.CopyAssign(value);
			}
		}

		// Token: 0x0601D8BE RID: 121022 RVA: 0x002BA0F3 File Offset: 0x002B82F3
		static UKSC_Skill_RangeSectionAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_RangeSectionAttack");
		}

		// Token: 0x0601D8BF RID: 121023 RVA: 0x002BA101 File Offset: 0x002B8301
		protected UKSC_Skill_RangeSectionAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010043 RID: 65603
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_RangeSectionAttack";

		// Token: 0x04010044 RID: 65604
		private static IntPtr _ClassPtr;

		// Token: 0x04010045 RID: 65605
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010046 RID: 65606
		internal static int __PropertyOffset_DaSkillRangeSectionAttack_;

		// Token: 0x04010047 RID: 65607
		internal static int __PropertyOffset_ProcessedTargets_;

		// Token: 0x04010048 RID: 65608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKSC_SkillComp> _ProcessedTargets_;
	}
}
