using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC0 RID: 7616
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_BulletPierceAttack")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Skill_BulletPierceAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D1EF RID: 119279 RVA: 0x002B06B7 File Offset: 0x002AE8B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_BulletPierceAttack._ClassPtr;
		}

		// Token: 0x0601D1F0 RID: 119280 RVA: 0x002B06C4 File Offset: 0x002AE8C4
		public UKSC_DA_Skill_BulletPierceAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_BulletPierceAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D1F1 RID: 119281 RVA: 0x002B06EC File Offset: 0x002AE8EC
		[NullableContext(1)]
		public UKSC_DA_Skill_BulletPierceAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_BulletPierceAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700759C RID: 30108
		// (get) Token: 0x0601D1F2 RID: 119282 RVA: 0x002B071F File Offset: 0x002AE91F
		// (set) Token: 0x0601D1F3 RID: 119283 RVA: 0x002B0733 File Offset: 0x002AE933
		[Nullable(2)]
		public unsafe UKSC_DA_BulletPierce Bullet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_BulletPierce>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_Bullet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_Bullet, value);
			}
		}

		// Token: 0x1700759D RID: 30109
		// (get) Token: 0x0601D1F4 RID: 119284 RVA: 0x002B0748 File Offset: 0x002AE948
		// (set) Token: 0x0601D1F5 RID: 119285 RVA: 0x002B0758 File Offset: 0x002AE958
		public unsafe float BulletRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_BulletRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_BulletRadius) = value;
			}
		}

		// Token: 0x1700759E RID: 30110
		// (get) Token: 0x0601D1F6 RID: 119286 RVA: 0x002B0769 File Offset: 0x002AE969
		// (set) Token: 0x0601D1F7 RID: 119287 RVA: 0x002B0779 File Offset: 0x002AE979
		public unsafe int PierceNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_PierceNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_PierceNum) = value;
			}
		}

		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x0601D1F8 RID: 119288 RVA: 0x002B078A File Offset: 0x002AE98A
		// (set) Token: 0x0601D1F9 RID: 119289 RVA: 0x002B079A File Offset: 0x002AE99A
		public unsafe float PierceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_PierceRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_BulletPierceAttack.__PropertyOffset_PierceRange) = value;
			}
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x002B07AB File Offset: 0x002AE9AB
		static UKSC_DA_Skill_BulletPierceAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_BulletPierceAttack");
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x002B07B9 File Offset: 0x002AE9B9
		protected UKSC_DA_Skill_BulletPierceAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCF2 RID: 64754
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_BulletPierceAttack";

		// Token: 0x0400FCF3 RID: 64755
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCF4 RID: 64756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCF5 RID: 64757
		internal static int __PropertyOffset_Bullet;

		// Token: 0x0400FCF6 RID: 64758
		internal static int __PropertyOffset_BulletRadius;

		// Token: 0x0400FCF7 RID: 64759
		internal static int __PropertyOffset_PierceNum;

		// Token: 0x0400FCF8 RID: 64760
		internal static int __PropertyOffset_PierceRange;
	}
}
