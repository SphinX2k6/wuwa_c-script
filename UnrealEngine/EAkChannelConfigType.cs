using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000271 RID: 625
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkChannelConfigType")]
	public enum EAkChannelConfigType
	{
		// Token: 0x04000CBF RID: 3263
		Anonymous,
		// Token: 0x04000CC0 RID: 3264
		Standard,
		// Token: 0x04000CC1 RID: 3265
		Ambisonic,
		// Token: 0x04000CC2 RID: 3266
		EAkChannelConfigType_MAX
	}
}
