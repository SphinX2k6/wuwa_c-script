using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286E RID: 10350
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETakeControlType")]
	public enum ETakeControlType
	{
		// Token: 0x0401507A RID: 86138
		TakeControl_Default,
		// Token: 0x0401507B RID: 86139
		TakeControl_ReEnter,
		// Token: 0x0401507C RID: 86140
		TakeControl_MAX
	}
}
