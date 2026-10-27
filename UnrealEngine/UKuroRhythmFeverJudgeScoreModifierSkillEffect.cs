using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C4B RID: 7243
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmFeverJudgeScoreModifierSkillEffect")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroRhythmFeverJudgeScoreModifierSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C0DB RID: 114907 RVA: 0x00294936 File Offset: 0x00292B36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmFeverJudgeScoreModifierSkillEffect._ClassPtr;
		}

		// Token: 0x0601C0DC RID: 114908 RVA: 0x00294944 File Offset: 0x00292B44
		public UKuroRhythmFeverJudgeScoreModifierSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverJudgeScoreModifierSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0DD RID: 114909 RVA: 0x0029496C File Offset: 0x00292B6C
		[NullableContext(1)]
		public UKuroRhythmFeverJudgeScoreModifierSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverJudgeScoreModifierSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0DE RID: 114910 RVA: 0x0029499F File Offset: 0x00292B9F
		static UKuroRhythmFeverJudgeScoreModifierSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmFeverJudgeScoreModifierSkillEffect");
		}

		// Token: 0x0601C0DF RID: 114911 RVA: 0x002949AD File Offset: 0x00292BAD
		protected UKuroRhythmFeverJudgeScoreModifierSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F15D RID: 61789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmFeverJudgeScoreModifierSkillEffect";

		// Token: 0x0400F15E RID: 61790
		private static IntPtr _ClassPtr;

		// Token: 0x0400F15F RID: 61791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
