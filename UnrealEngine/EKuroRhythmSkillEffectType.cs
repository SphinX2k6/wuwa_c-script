using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C43 RID: 7235
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmSkillEffectType")]
	public enum EKuroRhythmSkillEffectType : byte
	{
		// Token: 0x0400F133 RID: 61747
		None,
		// Token: 0x0400F134 RID: 61748
		AutoJudgeModifier,
		// Token: 0x0400F135 RID: 61749
		JudgeUpgradeLimited,
		// Token: 0x0400F136 RID: 61750
		JudgeScoreAdjust,
		// Token: 0x0400F137 RID: 61751
		JudgeTimeModifier,
		// Token: 0x0400F138 RID: 61752
		FeverJudgeScoreModifier,
		// Token: 0x0400F139 RID: 61753
		FeverDurationExtend,
		// Token: 0x0400F13A RID: 61754
		FeverDisableAutoJudge,
		// Token: 0x0400F13B RID: 61755
		DisableRecordUpLoad,
		// Token: 0x0400F13C RID: 61756
		AutoInputHold,
		// Token: 0x0400F13D RID: 61757
		EKuroRhythmSkillEffectType_MAX
	}
}
