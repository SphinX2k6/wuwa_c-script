using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000826 RID: 2086
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETakeControlType")]
	public enum ETakeControlType
	{
		// Token: 0x04005250 RID: 21072
		TakeControl_Default,
		// Token: 0x04005251 RID: 21073
		TakeControl_ReEnter,
		// Token: 0x04005252 RID: 21074
		TakeControl_MAX
	}
}
