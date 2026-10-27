using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012A0 RID: 4768
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FFMPEGMediaFactory.ESynchronizationType")]
	public enum ESynchronizationType : byte
	{
		// Token: 0x040095BE RID: 38334
		AudioMaster,
		// Token: 0x040095BF RID: 38335
		VideoMaster,
		// Token: 0x040095C0 RID: 38336
		ExternalClock,
		// Token: 0x040095C1 RID: 38337
		ESynchronizationType_MAX
	}
}
