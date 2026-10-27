using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000710 RID: 1808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAppMsgType")]
	public enum EAppMsgType
	{
		// Token: 0x04002DAE RID: 11694
		Ok,
		// Token: 0x04002DAF RID: 11695
		YesNo,
		// Token: 0x04002DB0 RID: 11696
		OkCancel,
		// Token: 0x04002DB1 RID: 11697
		YesNoCancel,
		// Token: 0x04002DB2 RID: 11698
		CancelRetryContinue,
		// Token: 0x04002DB3 RID: 11699
		YesNoYesAllNoAll,
		// Token: 0x04002DB4 RID: 11700
		YesNoYesAllNoAllCancel,
		// Token: 0x04002DB5 RID: 11701
		YesNoYesAll,
		// Token: 0x04002DB6 RID: 11702
		EAppMsgType_MAX
	}
}
