using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E44 RID: 7748
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent_Cannon")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UKSC_Skill_Attack_Persistent_Cannon : UKSC_Skill_Attack_Persistent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D856 RID: 120918 RVA: 0x002B973F File Offset: 0x002B793F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Attack_Persistent_Cannon._ClassPtr;
		}

		// Token: 0x0601D857 RID: 120919 RVA: 0x002B974C File Offset: 0x002B794C
		public UKSC_Skill_Attack_Persistent_Cannon() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack_Persistent_Cannon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D858 RID: 120920 RVA: 0x002B9774 File Offset: 0x002B7974
		[NullableContext(1)]
		public UKSC_Skill_Attack_Persistent_Cannon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Attack_Persistent_Cannon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x0601D859 RID: 120921 RVA: 0x002B97A7 File Offset: 0x002B79A7
		// (set) Token: 0x0601D85A RID: 120922 RVA: 0x002B97BB File Offset: 0x002B79BB
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Attack_Persistent_Cannon DaSkillAttackPersistentCannon_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Attack_Persistent_Cannon>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack_Persistent_Cannon.__PropertyOffset_DaSkillAttackPersistentCannon_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Attack_Persistent_Cannon.__PropertyOffset_DaSkillAttackPersistentCannon_, value);
			}
		}

		// Token: 0x0601D85B RID: 120923 RVA: 0x002B97D0 File Offset: 0x002B79D0
		static UKSC_Skill_Attack_Persistent_Cannon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent_Cannon");
		}

		// Token: 0x0601D85C RID: 120924 RVA: 0x002B97DE File Offset: 0x002B79DE
		protected UKSC_Skill_Attack_Persistent_Cannon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401000F RID: 65551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Attack_Persistent_Cannon";

		// Token: 0x04010010 RID: 65552
		private static IntPtr _ClassPtr;

		// Token: 0x04010011 RID: 65553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010012 RID: 65554
		internal static int __PropertyOffset_DaSkillAttackPersistentCannon_;
	}
}
