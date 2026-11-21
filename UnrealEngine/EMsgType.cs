using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000372 RID: 882
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EMsgType")]
	public enum EMsgType : byte
	{
		// Token: 0x04002524 RID: 9508
		Ok,
		// Token: 0x04002525 RID: 9509
		YesNo,
		// Token: 0x04002526 RID: 9510
		OkCancel,
		// Token: 0x04002527 RID: 9511
		YesNoCancel,
		// Token: 0x04002528 RID: 9512
		CancelRetryContinue,
		// Token: 0x04002529 RID: 9513
		YesNoYesAllNoAll,
		// Token: 0x0400252A RID: 9514
		YesNoYesAllNoAllCancel,
		// Token: 0x0400252B RID: 9515
		YesNoYesAll,
		// Token: 0x0400252C RID: 9516
		Default = 0,
		// Token: 0x0400252D RID: 9517
		EMsgType_MAX = 8
	}
}
