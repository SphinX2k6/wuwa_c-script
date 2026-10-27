using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E42 RID: 7746
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Attack")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Skill_Attack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D848 RID: 120904 RVA: 0x002B95EF File Offset: 0x002B77EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Attack._ClassPtr;
		}

		// Token: 0x0601D849 RID: 120905 RVA: 0x002B95FC File Offset: 0x002B77FC
		public UKSC_Skill_Attack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D84A RID: 120906 RVA: 0x002B9624 File Offset: 0x002B7824
		[NullableContext(1)]
		public UKSC_Skill_Attack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x0601D84B RID: 120907 RVA: 0x002B9657 File Offset: 0x002B7857
		// (set) Token: 0x0601D84C RID: 120908 RVA: 0x002B966B File Offset: 0x002B786B
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Attack DaSkillAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Attack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack.__PropertyOffset_DaSkillAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack.__PropertyOffset_DaSkillAttack_, value);
			}
		}

		// Token: 0x0601D84D RID: 120909 RVA: 0x002B9680 File Offset: 0x002B7880
		static UKSC_Skill_Attack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Attack");
		}

		// Token: 0x0601D84E RID: 120910 RVA: 0x002B968E File Offset: 0x002B788E
		protected UKSC_Skill_Attack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010007 RID: 65543
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Attack";

		// Token: 0x04010008 RID: 65544
		private static IntPtr _ClassPtr;

		// Token: 0x04010009 RID: 65545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401000A RID: 65546
		internal static int __PropertyOffset_DaSkillAttack_;
	}
}
