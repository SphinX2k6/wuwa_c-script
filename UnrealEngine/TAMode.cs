using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200084E RID: 2126
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TASdkPlugin.TAMode")]
	public enum TAMode : byte
	{
		// Token: 0x0400542C RID: 21548
		NORMAL,
		// Token: 0x0400542D RID: 21549
		DEBUG,
		// Token: 0x0400542E RID: 21550
		DEBUG_ONLY,
		// Token: 0x0400542F RID: 21551
		TAMode_MAX
	}
}
