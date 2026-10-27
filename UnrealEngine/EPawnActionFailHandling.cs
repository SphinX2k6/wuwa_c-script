using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BD RID: 445
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPawnActionFailHandling")]
	public enum EPawnActionFailHandling
	{
		// Token: 0x04000863 RID: 2147
		RequireSuccess,
		// Token: 0x04000864 RID: 2148
		IgnoreFailure,
		// Token: 0x04000865 RID: 2149
		EPawnActionFailHandling_MAX
	}
}
