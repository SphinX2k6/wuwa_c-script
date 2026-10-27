using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF9 RID: 8185
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleChangeStateResult")]
	public enum EToggleChangeStateResult : byte
	{
		// Token: 0x04010C2A RID: 68650
		ECS_Success,
		// Token: 0x04010C2B RID: 68651
		ECS_FailBySameResult,
		// Token: 0x04010C2C RID: 68652
		ECS_FailByCanExecuteChange,
		// Token: 0x04010C2D RID: 68653
		ECS_MAX
	}
}
