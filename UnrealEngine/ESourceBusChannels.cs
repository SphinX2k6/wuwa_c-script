using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B6E RID: 2926
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESourceBusChannels")]
	public enum ESourceBusChannels : byte
	{
		// Token: 0x040050A6 RID: 20646
		Mono,
		// Token: 0x040050A7 RID: 20647
		Stereo,
		// Token: 0x040050A8 RID: 20648
		ESourceBusChannels_MAX
	}
}
