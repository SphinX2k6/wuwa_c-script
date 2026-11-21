using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000CF RID: 207
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkActionOnEventType")]
	public enum EAkActionOnEventType : byte
	{
		// Token: 0x04000314 RID: 788
		Stop,
		// Token: 0x04000315 RID: 789
		Pause,
		// Token: 0x04000316 RID: 790
		Resume,
		// Token: 0x04000317 RID: 791
		Break,
		// Token: 0x04000318 RID: 792
		ReleaseEnvelope,
		// Token: 0x04000319 RID: 793
		EAkActionOnEventType_MAX
	}
}
