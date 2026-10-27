using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C5D RID: 7261
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmJudgeUpgradeLimitedSkillEffect")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroRhythmJudgeUpgradeLimitedSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C2CD RID: 115405 RVA: 0x00298686 File Offset: 0x00296886
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmJudgeUpgradeLimitedSkillEffect._ClassPtr;
		}

		// Token: 0x0601C2CE RID: 115406 RVA: 0x00298694 File Offset: 0x00296894
		public UKuroRhythmJudgeUpgradeLimitedSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeUpgradeLimitedSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C2CF RID: 115407 RVA: 0x002986BC File Offset: 0x002968BC
		[NullableContext(1)]
		public UKuroRhythmJudgeUpgradeLimitedSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeUpgradeLimitedSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C2D0 RID: 115408 RVA: 0x002986EF File Offset: 0x002968EF
		static UKuroRhythmJudgeUpgradeLimitedSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmJudgeUpgradeLimitedSkillEffect");
		}

		// Token: 0x0601C2D1 RID: 115409 RVA: 0x002986FD File Offset: 0x002968FD
		protected UKuroRhythmJudgeUpgradeLimitedSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F298 RID: 62104
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmJudgeUpgradeLimitedSkillEffect";

		// Token: 0x0400F299 RID: 62105
		private static IntPtr _ClassPtr;

		// Token: 0x0400F29A RID: 62106
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
