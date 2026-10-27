using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF0 RID: 8176
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EScrollItemState")]
	public enum EScrollItemState : byte
	{
		// Token: 0x04010BE7 RID: 68583
		DeActive,
		// Token: 0x04010BE8 RID: 68584
		Updating,
		// Token: 0x04010BE9 RID: 68585
		Completed,
		// Token: 0x04010BEA RID: 68586
		EScrollItemState_MAX
	}
}
