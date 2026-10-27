using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C3F RID: 7231
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameInputType")]
	public enum EKuroRhythmGameInputType : byte
	{
		// Token: 0x0400F10B RID: 61707
		TapLeft,
		// Token: 0x0400F10C RID: 61708
		TapRight,
		// Token: 0x0400F10D RID: 61709
		FlickLeft,
		// Token: 0x0400F10E RID: 61710
		FlickRight,
		// Token: 0x0400F10F RID: 61711
		Line,
		// Token: 0x0400F110 RID: 61712
		EKuroRhythmGameInputType_MAX
	}
}
