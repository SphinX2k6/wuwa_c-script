using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A6C RID: 6764
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ECurveSourceType")]
	public enum ECurveSourceType : byte
	{
		// Token: 0x0400D8D5 RID: 55509
		Function,
		// Token: 0x0400D8D6 RID: 55510
		CurveFloat,
		// Token: 0x0400D8D7 RID: 55511
		ECurveSourceType_MAX
	}
}
