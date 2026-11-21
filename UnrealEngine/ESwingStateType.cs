using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002EB RID: 747
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ESwingStateType")]
	public enum ESwingStateType : byte
	{
		// Token: 0x0400206E RID: 8302
		None,
		// Token: 0x0400206F RID: 8303
		EnterSwing,
		// Token: 0x04002070 RID: 8304
		LoopSwing,
		// Token: 0x04002071 RID: 8305
		LeftLoopSwing,
		// Token: 0x04002072 RID: 8306
		ExitSwing,
		// Token: 0x04002073 RID: 8307
		ESwingStateType_MAX
	}
}
