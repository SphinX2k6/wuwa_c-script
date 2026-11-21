using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000654 RID: 1620
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleChangeStateResult")]
	public enum EToggleChangeStateResult : byte
	{
		// Token: 0x04003DF7 RID: 15863
		ECS_Success,
		// Token: 0x04003DF8 RID: 15864
		ECS_FailBySameResult,
		// Token: 0x04003DF9 RID: 15865
		ECS_FailByCanExecuteChange,
		// Token: 0x04003DFA RID: 15866
		ECS_MAX
	}
}
