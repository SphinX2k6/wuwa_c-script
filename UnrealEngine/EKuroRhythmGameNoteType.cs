using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C40 RID: 7232
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameNoteType")]
	public enum EKuroRhythmGameNoteType : byte
	{
		// Token: 0x0400F112 RID: 61714
		None,
		// Token: 0x0400F113 RID: 61715
		KuroTapA,
		// Token: 0x0400F114 RID: 61716
		KuroTapB,
		// Token: 0x0400F115 RID: 61717
		KuroTapLeft,
		// Token: 0x0400F116 RID: 61718
		KuroTapRight,
		// Token: 0x0400F117 RID: 61719
		KuroFlickLeft,
		// Token: 0x0400F118 RID: 61720
		KuroFlickRight,
		// Token: 0x0400F119 RID: 61721
		Kuro3DFlickLeft,
		// Token: 0x0400F11A RID: 61722
		Kuro3DFlickRight,
		// Token: 0x0400F11B RID: 61723
		KuroLine,
		// Token: 0x0400F11C RID: 61724
		KuroLineHold,
		// Token: 0x0400F11D RID: 61725
		KuroLineHit,
		// Token: 0x0400F11E RID: 61726
		KuroEvent,
		// Token: 0x0400F11F RID: 61727
		EKuroRhythmGameNoteType_MAX
	}
}
