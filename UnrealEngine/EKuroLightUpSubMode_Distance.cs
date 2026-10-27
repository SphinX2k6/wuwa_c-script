using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7A RID: 6778
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroLightUpSubMode_Distance")]
	public enum EKuroLightUpSubMode_Distance : byte
	{
		// Token: 0x0400D9B5 RID: 55733
		Range,
		// Token: 0x0400D9B6 RID: 55734
		Sorted,
		// Token: 0x0400D9B7 RID: 55735
		EKuroLightUpSubMode_MAX
	}
}
