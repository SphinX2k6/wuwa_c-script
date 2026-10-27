using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A79 RID: 6777
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroHourglassVolumeResolution")]
	public enum EKuroHourglassVolumeResolution : byte
	{
		// Token: 0x0400D9B0 RID: 55728
		Low64,
		// Token: 0x0400D9B1 RID: 55729
		Medium80,
		// Token: 0x0400D9B2 RID: 55730
		High96,
		// Token: 0x0400D9B3 RID: 55731
		EKuroHourglassVolumeResolution_MAX
	}
}
