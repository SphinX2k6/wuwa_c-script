using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E43 RID: 7747
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Skill_Attack_Persistent : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D84F RID: 120911 RVA: 0x002B9697 File Offset: 0x002B7897
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Attack_Persistent._ClassPtr;
		}

		// Token: 0x0601D850 RID: 120912 RVA: 0x002B96A4 File Offset: 0x002B78A4
		public UKSC_Skill_Attack_Persistent() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack_Persistent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D851 RID: 120913 RVA: 0x002B96CC File Offset: 0x002B78CC
		[NullableContext(1)]
		public UKSC_Skill_Attack_Persistent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack_Persistent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x0601D852 RID: 120914 RVA: 0x002B96FF File Offset: 0x002B78FF
		// (set) Token: 0x0601D853 RID: 120915 RVA: 0x002B9713 File Offset: 0x002B7913
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Attack_Persistent DaSkillAttackPersistent_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Attack_Persistent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack_Persistent.__PropertyOffset_DaSkillAttackPersistent_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack_Persistent.__PropertyOffset_DaSkillAttackPersistent_, value);
			}
		}

		// Token: 0x0601D854 RID: 120916 RVA: 0x002B9728 File Offset: 0x002B7928
		static UKSC_Skill_Attack_Persistent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent");
		}

		// Token: 0x0601D855 RID: 120917 RVA: 0x002B9736 File Offset: 0x002B7936
		protected UKSC_Skill_Attack_Persistent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401000B RID: 65547
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent";

		// Token: 0x0401000C RID: 65548
		private static IntPtr _ClassPtr;

		// Token: 0x0401000D RID: 65549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401000E RID: 65550
		internal static int __PropertyOffset_DaSkillAttackPersistent_;
	}
}
