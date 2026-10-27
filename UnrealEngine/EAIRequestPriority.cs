using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200016E RID: 366
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EAIRequestPriority")]
	public enum EAIRequestPriority
	{
		// Token: 0x04000646 RID: 1606
		SoftScript,
		// Token: 0x04000647 RID: 1607
		Logic,
		// Token: 0x04000648 RID: 1608
		HardScript,
		// Token: 0x04000649 RID: 1609
		Reaction,
		// Token: 0x0400064A RID: 1610
		Ultimate,
		// Token: 0x0400064B RID: 1611
		MAX
	}
}
