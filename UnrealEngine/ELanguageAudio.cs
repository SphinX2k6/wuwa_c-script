using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007C6 RID: 1990
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SequenceDialogue.ELanguageAudio")]
	public enum ELanguageAudio : byte
	{
		// Token: 0x040049F6 RID: 18934
		All,
		// Token: 0x040049F7 RID: 18935
		zh,
		// Token: 0x040049F8 RID: 18936
		en,
		// Token: 0x040049F9 RID: 18937
		ja,
		// Token: 0x040049FA RID: 18938
		ko,
		// Token: 0x040049FB RID: 18939
		Count,
		// Token: 0x040049FC RID: 18940
		ELanguageAudio_MAX
	}
}
