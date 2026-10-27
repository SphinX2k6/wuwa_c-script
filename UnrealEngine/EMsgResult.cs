using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200181A RID: 6170
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EMsgResult")]
	public enum EMsgResult : byte
	{
		// Token: 0x0400C617 RID: 50711
		No,
		// Token: 0x0400C618 RID: 50712
		Yes,
		// Token: 0x0400C619 RID: 50713
		YesAll,
		// Token: 0x0400C61A RID: 50714
		NoAll,
		// Token: 0x0400C61B RID: 50715
		Cancel,
		// Token: 0x0400C61C RID: 50716
		Ok,
		// Token: 0x0400C61D RID: 50717
		Retry,
		// Token: 0x0400C61E RID: 50718
		Continue,
		// Token: 0x0400C61F RID: 50719
		Default = 0,
		// Token: 0x0400C620 RID: 50720
		EMsgResult_MAX = 8
	}
}
