using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001691 RID: 5777
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAudio.EKuroAudioVolumeChannel")]
	public enum EKuroAudioVolumeChannel : byte
	{
		// Token: 0x0400B6B4 RID: 46772
		Default,
		// Token: 0x0400B6B5 RID: 46773
		Music,
		// Token: 0x0400B6B6 RID: 46774
		Count,
		// Token: 0x0400B6B7 RID: 46775
		EKuroAudioVolumeChannel_MAX
	}
}
