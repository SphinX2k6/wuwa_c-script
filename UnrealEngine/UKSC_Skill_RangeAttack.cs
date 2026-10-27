using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4E RID: 7758
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_RangeAttack")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKSC_Skill_RangeAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8A2 RID: 120994 RVA: 0x002B9E23 File Offset: 0x002B8023
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_RangeAttack._ClassPtr;
		}

		// Token: 0x0601D8A3 RID: 120995 RVA: 0x002B9E30 File Offset: 0x002B8030
		public UKSC_Skill_RangeAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8A4 RID: 120996 RVA: 0x002B9E58 File Offset: 0x002B8058
		[NullableContext(1)]
		public UKSC_Skill_RangeAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangeAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x0601D8A5 RID: 120997 RVA: 0x002B9E8B File Offset: 0x002B808B
		// (set) Token: 0x0601D8A6 RID: 120998 RVA: 0x002B9E9F File Offset: 0x002B809F
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_RangeAttack DaSkillRangeAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_RangeAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeAttack.__PropertyOffset_DaSkillRangeAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangeAttack.__PropertyOffset_DaSkillRangeAttack_, value);
			}
		}

		// Token: 0x0601D8A7 RID: 120999 RVA: 0x002B9EB4 File Offset: 0x002B80B4
		static UKSC_Skill_RangeAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_RangeAttack");
		}

		// Token: 0x0601D8A8 RID: 121000 RVA: 0x002B9EC2 File Offset: 0x002B80C2
		protected UKSC_Skill_RangeAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010037 RID: 65591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_RangeAttack";

		// Token: 0x04010038 RID: 65592
		private static IntPtr _ClassPtr;

		// Token: 0x04010039 RID: 65593
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401003A RID: 65594
		internal static int __PropertyOffset_DaSkillRangeAttack_;
	}
}
