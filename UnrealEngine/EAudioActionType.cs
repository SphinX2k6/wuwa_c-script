using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200168F RID: 5775
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAudio.EAudioActionType")]
	public enum EAudioActionType : byte
	{
		// Token: 0x0400B6A2 RID: 46754
		Stop,
		// Token: 0x0400B6A3 RID: 46755
		Pause,
		// Token: 0x0400B6A4 RID: 46756
		Resume,
		// Token: 0x0400B6A5 RID: 46757
		Break,
		// Token: 0x0400B6A6 RID: 46758
		ReleaseEnvelope,
		// Token: 0x0400B6A7 RID: 46759
		EAudioActionType_MAX
	}
}
