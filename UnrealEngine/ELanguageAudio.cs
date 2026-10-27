using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026DD RID: 9949
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SequenceDialogue.ELanguageAudio")]
	public enum ELanguageAudio : byte
	{
		// Token: 0x04013E2E RID: 81454
		All,
		// Token: 0x04013E2F RID: 81455
		zh,
		// Token: 0x04013E30 RID: 81456
		en,
		// Token: 0x04013E31 RID: 81457
		ja,
		// Token: 0x04013E32 RID: 81458
		ko,
		// Token: 0x04013E33 RID: 81459
		Count,
		// Token: 0x04013E34 RID: 81460
		ELanguageAudio_MAX
	}
}
