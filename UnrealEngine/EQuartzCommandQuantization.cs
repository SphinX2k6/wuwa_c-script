using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B33 RID: 2867
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EQuartzCommandQuantization")]
	public enum EQuartzCommandQuantization : byte
	{
		// Token: 0x04004EF6 RID: 20214
		Bar,
		// Token: 0x04004EF7 RID: 20215
		Beat,
		// Token: 0x04004EF8 RID: 20216
		ThirtySecondNote,
		// Token: 0x04004EF9 RID: 20217
		SixteenthNote,
		// Token: 0x04004EFA RID: 20218
		EighthNote,
		// Token: 0x04004EFB RID: 20219
		QuarterNote,
		// Token: 0x04004EFC RID: 20220
		HalfNote,
		// Token: 0x04004EFD RID: 20221
		WholeNote,
		// Token: 0x04004EFE RID: 20222
		DottedSixteenthNote,
		// Token: 0x04004EFF RID: 20223
		DottedEighthNote,
		// Token: 0x04004F00 RID: 20224
		DottedQuarterNote,
		// Token: 0x04004F01 RID: 20225
		DottedHalfNote,
		// Token: 0x04004F02 RID: 20226
		DottedWholeNote,
		// Token: 0x04004F03 RID: 20227
		SixteenthNoteTriplet,
		// Token: 0x04004F04 RID: 20228
		EighthNoteTriplet,
		// Token: 0x04004F05 RID: 20229
		QuarterNoteTriplet,
		// Token: 0x04004F06 RID: 20230
		HalfNoteTriplet,
		// Token: 0x04004F07 RID: 20231
		Tick,
		// Token: 0x04004F08 RID: 20232
		Count,
		// Token: 0x04004F09 RID: 20233
		EQuartzCommandQuantization_MAX
	}
}
