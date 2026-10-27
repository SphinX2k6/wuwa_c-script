using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E50 RID: 7760
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_RangePersistentAttack")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_Skill_RangePersistentAttack : UKSC_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8B0 RID: 121008 RVA: 0x002B9F73 File Offset: 0x002B8173
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_RangePersistentAttack._ClassPtr;
		}

		// Token: 0x0601D8B1 RID: 121009 RVA: 0x002B9F80 File Offset: 0x002B8180
		public UKSC_Skill_RangePersistentAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangePersistentAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8B2 RID: 121010 RVA: 0x002B9FA8 File Offset: 0x002B81A8
		[NullableContext(1)]
		public UKSC_Skill_RangePersistentAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_RangePersistentAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FE RID: 30462
		// (get) Token: 0x0601D8B3 RID: 121011 RVA: 0x002B9FDB File Offset: 0x002B81DB
		// (set) Token: 0x0601D8B4 RID: 121012 RVA: 0x002B9FEF File Offset: 0x002B81EF
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_RangePersistentAttack DaSkillRangePersistentAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_RangePersistentAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangePersistentAttack.__PropertyOffset_DaSkillRangePersistentAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_RangePersistentAttack.__PropertyOffset_DaSkillRangePersistentAttack_, value);
			}
		}

		// Token: 0x0601D8B5 RID: 121013 RVA: 0x002BA004 File Offset: 0x002B8204
		static UKSC_Skill_RangePersistentAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_RangePersistentAttack");
		}

		// Token: 0x0601D8B6 RID: 121014 RVA: 0x002BA012 File Offset: 0x002B8212
		protected UKSC_Skill_RangePersistentAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401003F RID: 65599
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_RangePersistentAttack";

		// Token: 0x04010040 RID: 65600
		private static IntPtr _ClassPtr;

		// Token: 0x04010041 RID: 65601
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010042 RID: 65602
		internal static int __PropertyOffset_DaSkillRangePersistentAttack_;
	}
}
