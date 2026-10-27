using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C3C RID: 7228
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroResourceCheckTool.EKuroMemQualityTier")]
	public enum EKuroMemQualityTier : byte
	{
		// Token: 0x0400F0F4 RID: 61684
		ExtraHigh,
		// Token: 0x0400F0F5 RID: 61685
		High,
		// Token: 0x0400F0F6 RID: 61686
		Middle,
		// Token: 0x0400F0F7 RID: 61687
		Low,
		// Token: 0x0400F0F8 RID: 61688
		ExtraLow,
		// Token: 0x0400F0F9 RID: 61689
		EKuroMemQualityTier_MAX
	}
}
