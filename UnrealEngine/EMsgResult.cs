using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000371 RID: 881
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EMsgResult")]
	public enum EMsgResult : byte
	{
		// Token: 0x04002519 RID: 9497
		No,
		// Token: 0x0400251A RID: 9498
		Yes,
		// Token: 0x0400251B RID: 9499
		YesAll,
		// Token: 0x0400251C RID: 9500
		NoAll,
		// Token: 0x0400251D RID: 9501
		Cancel,
		// Token: 0x0400251E RID: 9502
		Ok,
		// Token: 0x0400251F RID: 9503
		Retry,
		// Token: 0x04002520 RID: 9504
		Continue,
		// Token: 0x04002521 RID: 9505
		Default = 0,
		// Token: 0x04002522 RID: 9506
		EMsgResult_MAX = 8
	}
}
