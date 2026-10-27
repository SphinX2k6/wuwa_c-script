using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A76 RID: 2678
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EGainParamMode")]
	public enum EGainParamMode : byte
	{
		// Token: 0x040047DC RID: 18396
		Linear,
		// Token: 0x040047DD RID: 18397
		Decibels,
		// Token: 0x040047DE RID: 18398
		EGainParamMode_MAX
	}
}
