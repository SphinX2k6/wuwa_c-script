using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B65 RID: 2917
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESkinCacheUsage")]
	public enum ESkinCacheUsage : byte
	{
		// Token: 0x0400505E RID: 20574
		Auto,
		// Token: 0x0400505F RID: 20575
		Disabled = 255,
		// Token: 0x04005060 RID: 20576
		Enabled = 1
	}
}
