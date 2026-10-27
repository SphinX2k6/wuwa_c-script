using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DBF RID: 7615
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_BulletAttack")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_BulletAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1E8 RID: 119272 RVA: 0x002B0610 File Offset: 0x002AE810
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_BulletAttack._ClassPtr;
		}

		// Token: 0x0601D1E9 RID: 119273 RVA: 0x002B061C File Offset: 0x002AE81C
		public UKSC_DA_Skill_BulletAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_BulletAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1EA RID: 119274 RVA: 0x002B0644 File Offset: 0x002AE844
		[NullableContext(1)]
		public UKSC_DA_Skill_BulletAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_BulletAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700759B RID: 30107
		// (get) Token: 0x0601D1EB RID: 119275 RVA: 0x002B0677 File Offset: 0x002AE877
		// (set) Token: 0x0601D1EC RID: 119276 RVA: 0x002B068B File Offset: 0x002AE88B
		[Nullable(2)]
		public unsafe UKSC_DA_Bullet Bullet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Bullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_BulletAttack.__PropertyOffset_Bullet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_BulletAttack.__PropertyOffset_Bullet, value);
			}
		}

		// Token: 0x0601D1ED RID: 119277 RVA: 0x002B06A0 File Offset: 0x002AE8A0
		static UKSC_DA_Skill_BulletAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_BulletAttack");
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x002B06AE File Offset: 0x002AE8AE
		protected UKSC_DA_Skill_BulletAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCEE RID: 64750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_BulletAttack";

		// Token: 0x0400FCEF RID: 64751
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCF0 RID: 64752
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCF1 RID: 64753
		internal static int __PropertyOffset_Bullet;
	}
}
