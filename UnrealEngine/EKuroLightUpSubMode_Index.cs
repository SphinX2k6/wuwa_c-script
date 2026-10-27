using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7B RID: 6779
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroLightUpSubMode_Index")]
	public enum EKuroLightUpSubMode_Index : byte
	{
		// Token: 0x0400D9B9 RID: 55737
		Sequential,
		// Token: 0x0400D9BA RID: 55738
		DoubleExtension,
		// Token: 0x0400D9BB RID: 55739
		Alternating,
		// Token: 0x0400D9BC RID: 55740
		EKuroLightUpSubMode_MAX
	}
}
