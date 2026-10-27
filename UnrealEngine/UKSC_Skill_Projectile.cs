using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E4D RID: 7757
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Projectile")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Skill_Projectile : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D89B RID: 120987 RVA: 0x002B9D7B File Offset: 0x002B7F7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Projectile._ClassPtr;
		}

		// Token: 0x0601D89C RID: 120988 RVA: 0x002B9D88 File Offset: 0x002B7F88
		public UKSC_Skill_Projectile() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Projectile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D89D RID: 120989 RVA: 0x002B9DB0 File Offset: 0x002B7FB0
		[NullableContext(1)]
		public UKSC_Skill_Projectile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Projectile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x0601D89E RID: 120990 RVA: 0x002B9DE3 File Offset: 0x002B7FE3
		// (set) Token: 0x0601D89F RID: 120991 RVA: 0x002B9DF7 File Offset: 0x002B7FF7
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Projectile DaSkillProjectile_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Projectile>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Projectile.__PropertyOffset_DaSkillProjectile_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Projectile.__PropertyOffset_DaSkillProjectile_, value);
			}
		}

		// Token: 0x0601D8A0 RID: 120992 RVA: 0x002B9E0C File Offset: 0x002B800C
		static UKSC_Skill_Projectile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Projectile");
		}

		// Token: 0x0601D8A1 RID: 120993 RVA: 0x002B9E1A File Offset: 0x002B801A
		protected UKSC_Skill_Projectile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010033 RID: 65587
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Projectile";

		// Token: 0x04010034 RID: 65588
		private static IntPtr _ClassPtr;

		// Token: 0x04010035 RID: 65589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010036 RID: 65590
		internal static int __PropertyOffset_DaSkillProjectile_;
	}
}
