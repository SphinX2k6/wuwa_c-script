using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E46 RID: 7750
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_BulletPierceAttack")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKSC_Skill_BulletPierceAttack : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D866 RID: 120934 RVA: 0x002B98AC File Offset: 0x002B7AAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_BulletPierceAttack._ClassPtr;
		}

		// Token: 0x0601D867 RID: 120935 RVA: 0x002B98B8 File Offset: 0x002B7AB8
		public UKSC_Skill_BulletPierceAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_BulletPierceAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D868 RID: 120936 RVA: 0x002B98E0 File Offset: 0x002B7AE0
		[NullableContext(1)]
		public UKSC_Skill_BulletPierceAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_BulletPierceAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x0601D869 RID: 120937 RVA: 0x002B9913 File Offset: 0x002B7B13
		// (set) Token: 0x0601D86A RID: 120938 RVA: 0x002B9927 File Offset: 0x002B7B27
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_BulletPierceAttack DaSkillBulletPierceAttack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_BulletPierceAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_BulletPierceAttack.__PropertyOffset_DaSkillBulletPierceAttack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_BulletPierceAttack.__PropertyOffset_DaSkillBulletPierceAttack_, value);
			}
		}

		// Token: 0x0601D86B RID: 120939 RVA: 0x002B993C File Offset: 0x002B7B3C
		public void OnBulletHits([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UKSC_SkillComp> Hits)
		{
			UKSC_Skill_BulletPierceAttack.__OnBulletHits_Internal(base.NativePtr, (Hits ?? new TArray<UKSC_SkillComp>()).NativePtr);
		}

		// Token: 0x0601D86C RID: 120940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBulletHits_Internal(IntPtr @this, IntPtr Hits);

		// Token: 0x0601D86D RID: 120941 RVA: 0x002B9959 File Offset: 0x002B7B59
		static UKSC_Skill_BulletPierceAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_BulletPierceAttack");
		}

		// Token: 0x0601D86E RID: 120942 RVA: 0x002B9967 File Offset: 0x002B7B67
		protected UKSC_Skill_BulletPierceAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010017 RID: 65559
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_BulletPierceAttack";

		// Token: 0x04010018 RID: 65560
		private static IntPtr _ClassPtr;

		// Token: 0x04010019 RID: 65561
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401001A RID: 65562
		internal static int __PropertyOffset_DaSkillBulletPierceAttack_;
	}
}
