using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FA RID: 1274
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameNoteType")]
	public enum EKuroRhythmGameNoteType : byte
	{
		// Token: 0x04003269 RID: 12905
		None,
		// Token: 0x0400326A RID: 12906
		KuroTapA,
		// Token: 0x0400326B RID: 12907
		KuroTapB,
		// Token: 0x0400326C RID: 12908
		KuroTapLeft,
		// Token: 0x0400326D RID: 12909
		KuroTapRight,
		// Token: 0x0400326E RID: 12910
		KuroFlickLeft,
		// Token: 0x0400326F RID: 12911
		KuroFlickRight,
		// Token: 0x04003270 RID: 12912
		Kuro3DFlickLeft,
		// Token: 0x04003271 RID: 12913
		Kuro3DFlickRight,
		// Token: 0x04003272 RID: 12914
		KuroLine,
		// Token: 0x04003273 RID: 12915
		KuroLineHold,
		// Token: 0x04003274 RID: 12916
		KuroLineHit,
		// Token: 0x04003275 RID: 12917
		KuroEvent,
		// Token: 0x04003276 RID: 12918
		EKuroRhythmGameNoteType_MAX
	}
}
