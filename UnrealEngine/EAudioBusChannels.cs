using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009FB RID: 2555
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAudioBusChannels")]
	public enum EAudioBusChannels : byte
	{
		// Token: 0x04004480 RID: 17536
		Mono,
		// Token: 0x04004481 RID: 17537
		Stereo,
		// Token: 0x04004482 RID: 17538
		EAudioBusChannels_MAX
	}
}
