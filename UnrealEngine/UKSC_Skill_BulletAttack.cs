using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E45 RID: 7749
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_BulletAttack")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKSC_Skill_BulletAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D85D RID: 120925 RVA: 0x002B97E7 File Offset: 0x002B79E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_BulletAttack._ClassPtr;
		}

		// Token: 0x0601D85E RID: 120926 RVA: 0x002B97F4 File Offset: 0x002B79F4
		public UKSC_Skill_BulletAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_BulletAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D85F RID: 120927 RVA: 0x002B981C File Offset: 0x002B7A1C
		[NullableContext(1)]
		public UKSC_Skill_BulletAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_BulletAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x0601D860 RID: 120928 RVA: 0x002B984F File Offset: 0x002B7A4F
		// (set) Token: 0x0601D861 RID: 120929 RVA: 0x002B9863 File Offset: 0x002B7A63
		public unsafe UKSC_DA_Skill_BulletAttack DaSkillBulletAttack_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_BulletAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_BulletAttack.__PropertyOffset_DaSkillBulletAttack_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_BulletAttack.__PropertyOffset_DaSkillBulletAttack_, value);
			}
		}

		// Token: 0x0601D862 RID: 120930 RVA: 0x002B9878 File Offset: 0x002B7A78
		public void OnBulletHit(in FKSC_BulletTargetContext TargetContext)
		{
			UKSC_Skill_BulletAttack.__OnBulletHit_Internal(base.NativePtr, (TargetContext ?? new FKSC_BulletTargetContext()).NativePtr);
		}

		// Token: 0x0601D863 RID: 120931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBulletHit_Internal(IntPtr @this, IntPtr TargetContext);

		// Token: 0x0601D864 RID: 120932 RVA: 0x002B9895 File Offset: 0x002B7A95
		static UKSC_Skill_BulletAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_BulletAttack");
		}

		// Token: 0x0601D865 RID: 120933 RVA: 0x002B98A3 File Offset: 0x002B7AA3
		protected UKSC_Skill_BulletAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010013 RID: 65555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_BulletAttack";

		// Token: 0x04010014 RID: 65556
		private static IntPtr _ClassPtr;

		// Token: 0x04010015 RID: 65557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010016 RID: 65558
		internal static int __PropertyOffset_DaSkillBulletAttack_;
	}
}
