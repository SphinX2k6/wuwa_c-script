using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002291 RID: 8849
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaAssets.EMediaSoundChannels")]
	public enum EMediaSoundChannels
	{
		// Token: 0x04011F56 RID: 73558
		Mono,
		// Token: 0x04011F57 RID: 73559
		Stereo,
		// Token: 0x04011F58 RID: 73560
		Surround,
		// Token: 0x04011F59 RID: 73561
		EMediaSoundChannels_MAX
	}
}
