using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4C RID: 7756
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_MultiAttack")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Skill_MultiAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D894 RID: 120980 RVA: 0x002B9CD4 File Offset: 0x002B7ED4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_MultiAttack._ClassPtr;
		}

		// Token: 0x0601D895 RID: 120981 RVA: 0x002B9CE0 File Offset: 0x002B7EE0
		public UKSC_Skill_MultiAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_MultiAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D896 RID: 120982 RVA: 0x002B9D08 File Offset: 0x002B7F08
		[NullableContext(1)]
		public UKSC_Skill_MultiAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_MultiAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x0601D897 RID: 120983 RVA: 0x002B9D3B File Offset: 0x002B7F3B
		// (set) Token: 0x0601D898 RID: 120984 RVA: 0x002B9D4F File Offset: 0x002B7F4F
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_MultiAttack DaSkillMultiAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_MultiAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_MultiAttack.__PropertyOffset_DaSkillMultiAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_MultiAttack.__PropertyOffset_DaSkillMultiAttack_, value);
			}
		}

		// Token: 0x0601D899 RID: 120985 RVA: 0x002B9D64 File Offset: 0x002B7F64
		static UKSC_Skill_MultiAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_MultiAttack");
		}

		// Token: 0x0601D89A RID: 120986 RVA: 0x002B9D72 File Offset: 0x002B7F72
		protected UKSC_Skill_MultiAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401002F RID: 65583
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_MultiAttack";

		// Token: 0x04010030 RID: 65584
		private static IntPtr _ClassPtr;

		// Token: 0x04010031 RID: 65585
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010032 RID: 65586
		internal static int __PropertyOffset_DaSkillMultiAttack_;
	}
}
