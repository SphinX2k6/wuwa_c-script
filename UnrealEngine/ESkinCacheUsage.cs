using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001FB RID: 507
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESkinCacheUsage")]
	public enum ESkinCacheUsage : byte
	{
		// Token: 0x04000CA4 RID: 3236
		Auto,
		// Token: 0x04000CA5 RID: 3237
		Disabled = 255,
		// Token: 0x04000CA6 RID: 3238
		Enabled = 1
	}
}
