using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B34 RID: 2868
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EQuartzTimeSignatureQuantization")]
	public enum EQuartzTimeSignatureQuantization : byte
	{
		// Token: 0x04004F0B RID: 20235
		HalfNote,
		// Token: 0x04004F0C RID: 20236
		QuarterNote,
		// Token: 0x04004F0D RID: 20237
		EighthNote,
		// Token: 0x04004F0E RID: 20238
		SixteenthNote,
		// Token: 0x04004F0F RID: 20239
		ThirtySecondNote,
		// Token: 0x04004F10 RID: 20240
		Count,
		// Token: 0x04004F11 RID: 20241
		EQuartzTimeSignatureQuantization_MAX
	}
}
