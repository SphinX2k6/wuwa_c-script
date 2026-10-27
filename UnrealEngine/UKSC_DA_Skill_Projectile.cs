using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC7 RID: 7623
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_Projectile")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Skill_Projectile : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D264 RID: 119396 RVA: 0x002B1067 File Offset: 0x002AF267
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_Projectile._ClassPtr;
		}

		// Token: 0x0601D265 RID: 119397 RVA: 0x002B1074 File Offset: 0x002AF274
		public UKSC_DA_Skill_Projectile() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Projectile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D266 RID: 119398 RVA: 0x002B109C File Offset: 0x002AF29C
		[NullableContext(1)]
		public UKSC_DA_Skill_Projectile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_Projectile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x0601D267 RID: 119399 RVA: 0x002B10CF File Offset: 0x002AF2CF
		// (set) Token: 0x0601D268 RID: 119400 RVA: 0x002B10E3 File Offset: 0x002AF2E3
		[Nullable(2)]
		public unsafe UKSC_DA_Entity_Projectile Projectile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity_Projectile>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_Projectile.__PropertyOffset_Projectile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_Projectile.__PropertyOffset_Projectile, value);
			}
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x002B10F8 File Offset: 0x002AF2F8
		static UKSC_DA_Skill_Projectile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_Projectile");
		}

		// Token: 0x0601D26A RID: 119402 RVA: 0x002B1106 File Offset: 0x002AF306
		protected UKSC_DA_Skill_Projectile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD33 RID: 64819
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_Projectile";

		// Token: 0x0400FD34 RID: 64820
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD35 RID: 64821
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD36 RID: 64822
		internal static int __PropertyOffset_Projectile;
	}
}
