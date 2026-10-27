using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC5 RID: 7621
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_ManualBulletAttack")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Skill_ManualBulletAttack : UKSC_DA_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D24C RID: 119372 RVA: 0x002B0E7A File Offset: 0x002AF07A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_ManualBulletAttack._ClassPtr;
		}

		// Token: 0x0601D24D RID: 119373 RVA: 0x002B0E88 File Offset: 0x002AF088
		public UKSC_DA_Skill_ManualBulletAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_ManualBulletAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D24E RID: 119374 RVA: 0x002B0EB0 File Offset: 0x002AF0B0
		[NullableContext(1)]
		public UKSC_DA_Skill_ManualBulletAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_ManualBulletAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075BE RID: 30142
		// (get) Token: 0x0601D24F RID: 119375 RVA: 0x002B0EE3 File Offset: 0x002AF0E3
		// (set) Token: 0x0601D250 RID: 119376 RVA: 0x002B0EF7 File Offset: 0x002AF0F7
		[Nullable(2)]
		public unsafe UKSC_DA_Bullet Bullet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Bullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_Bullet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_Bullet, value);
			}
		}

		// Token: 0x170075BF RID: 30143
		// (get) Token: 0x0601D251 RID: 119377 RVA: 0x002B0F0C File Offset: 0x002AF10C
		// (set) Token: 0x0601D252 RID: 119378 RVA: 0x002B0F1C File Offset: 0x002AF11C
		public unsafe float AttackDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_AttackDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_AttackDist) = value;
			}
		}

		// Token: 0x170075C0 RID: 30144
		// (get) Token: 0x0601D253 RID: 119379 RVA: 0x002B0F2D File Offset: 0x002AF12D
		// (set) Token: 0x0601D254 RID: 119380 RVA: 0x002B0F3D File Offset: 0x002AF13D
		public unsafe float TraceAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_TraceAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_TraceAngle) = value;
			}
		}

		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x0601D255 RID: 119381 RVA: 0x002B0F4E File Offset: 0x002AF14E
		// (set) Token: 0x0601D256 RID: 119382 RVA: 0x002B0F5E File Offset: 0x002AF15E
		public unsafe EKSC_LockTarget LockTargetType
		{
			get
			{
				return (EKSC_LockTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_LockTargetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_LockTargetType) = (byte)value;
			}
		}

		// Token: 0x170075C2 RID: 30146
		// (get) Token: 0x0601D257 RID: 119383 RVA: 0x002B0F6F File Offset: 0x002AF16F
		// (set) Token: 0x0601D258 RID: 119384 RVA: 0x002B0F7F File Offset: 0x002AF17F
		public unsafe EKSC_ManualSkillAttack AttackType
		{
			get
			{
				return (EKSC_ManualSkillAttack)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_AttackType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_AttackType) = (byte)value;
			}
		}

		// Token: 0x170075C3 RID: 30147
		// (get) Token: 0x0601D259 RID: 119385 RVA: 0x002B0F90 File Offset: 0x002AF190
		// (set) Token: 0x0601D25A RID: 119386 RVA: 0x002B0FA0 File Offset: 0x002AF1A0
		public unsafe EKSC_Faction SelectTargetFaction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_SelectTargetFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_ManualBulletAttack.__PropertyOffset_SelectTargetFaction) = (byte)value;
			}
		}

		// Token: 0x0601D25B RID: 119387 RVA: 0x002B0FB1 File Offset: 0x002AF1B1
		static UKSC_DA_Skill_ManualBulletAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_ManualBulletAttack");
		}

		// Token: 0x0601D25C RID: 119388 RVA: 0x002B0FBF File Offset: 0x002AF1BF
		protected UKSC_DA_Skill_ManualBulletAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD26 RID: 64806
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_ManualBulletAttack";

		// Token: 0x0400FD27 RID: 64807
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD28 RID: 64808
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD29 RID: 64809
		internal static int __PropertyOffset_Bullet;

		// Token: 0x0400FD2A RID: 64810
		internal static int __PropertyOffset_AttackDist;

		// Token: 0x0400FD2B RID: 64811
		internal static int __PropertyOffset_TraceAngle;

		// Token: 0x0400FD2C RID: 64812
		internal static int __PropertyOffset_LockTargetType;

		// Token: 0x0400FD2D RID: 64813
		internal static int __PropertyOffset_AttackType;

		// Token: 0x0400FD2E RID: 64814
		internal static int __PropertyOffset_SelectTargetFaction;
	}
}
