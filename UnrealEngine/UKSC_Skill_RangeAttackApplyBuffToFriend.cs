using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4F RID: 7759
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_RangeAttackApplyBuffToFriend")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKSC_Skill_RangeAttackApplyBuffToFriend : UKSC_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8A9 RID: 121001 RVA: 0x002B9ECB File Offset: 0x002B80CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_RangeAttackApplyBuffToFriend._ClassPtr;
		}

		// Token: 0x0601D8AA RID: 121002 RVA: 0x002B9ED8 File Offset: 0x002B80D8
		public UKSC_Skill_RangeAttackApplyBuffToFriend() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeAttackApplyBuffToFriend.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8AB RID: 121003 RVA: 0x002B9F00 File Offset: 0x002B8100
		[NullableContext(1)]
		public UKSC_Skill_RangeAttackApplyBuffToFriend(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeAttackApplyBuffToFriend.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x0601D8AC RID: 121004 RVA: 0x002B9F33 File Offset: 0x002B8133
		// (set) Token: 0x0601D8AD RID: 121005 RVA: 0x002B9F47 File Offset: 0x002B8147
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_RangeAttackApplyBuffToFriend DaSkillRangeAttackApplyBuffToFaction_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_RangeAttackApplyBuffToFriend>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeAttackApplyBuffToFriend.__PropertyOffset_DaSkillRangeAttackApplyBuffToFaction_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeAttackApplyBuffToFriend.__PropertyOffset_DaSkillRangeAttackApplyBuffToFaction_, value);
			}
		}

		// Token: 0x0601D8AE RID: 121006 RVA: 0x002B9F5C File Offset: 0x002B815C
		static UKSC_Skill_RangeAttackApplyBuffToFriend()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_RangeAttackApplyBuffToFriend");
		}

		// Token: 0x0601D8AF RID: 121007 RVA: 0x002B9F6A File Offset: 0x002B816A
		protected UKSC_Skill_RangeAttackApplyBuffToFriend(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401003B RID: 65595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_RangeAttackApplyBuffToFriend";

		// Token: 0x0401003C RID: 65596
		private static IntPtr _ClassPtr;

		// Token: 0x0401003D RID: 65597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401003E RID: 65598
		internal static int __PropertyOffset_DaSkillRangeAttackApplyBuffToFaction_;
	}
}
