using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002857 RID: 10327
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EVirtualKeyboardDismissAction")]
	public enum EVirtualKeyboardDismissAction : byte
	{
		// Token: 0x04015009 RID: 86025
		TextChangeOnDismiss,
		// Token: 0x0401500A RID: 86026
		TextCommitOnAccept,
		// Token: 0x0401500B RID: 86027
		TextCommitOnDismiss,
		// Token: 0x0401500C RID: 86028
		EVirtualKeyboardDismissAction_MAX
	}
}
