using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001494 RID: 5268
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniProxyRefineResult")]
	public enum EHoudiniProxyRefineResult : byte
	{
		// Token: 0x0400A4D6 RID: 42198
		Invalid,
		// Token: 0x0400A4D7 RID: 42199
		Failed,
		// Token: 0x0400A4D8 RID: 42200
		Success,
		// Token: 0x0400A4D9 RID: 42201
		Skipped,
		// Token: 0x0400A4DA RID: 42202
		EHoudiniProxyRefineResult_MAX
	}
}
