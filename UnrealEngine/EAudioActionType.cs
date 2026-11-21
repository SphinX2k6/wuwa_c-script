using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200030B RID: 779
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAudio.EAudioActionType")]
	public enum EAudioActionType : byte
	{
		// Token: 0x040021FD RID: 8701
		Stop,
		// Token: 0x040021FE RID: 8702
		Pause,
		// Token: 0x040021FF RID: 8703
		Resume,
		// Token: 0x04002200 RID: 8704
		Break,
		// Token: 0x04002201 RID: 8705
		ReleaseEnvelope,
		// Token: 0x04002202 RID: 8706
		EAudioActionType_MAX
	}
}
