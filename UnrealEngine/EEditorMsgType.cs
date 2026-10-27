using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A43 RID: 6723
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EEditorMsgType")]
	public enum EEditorMsgType : byte
	{
		// Token: 0x0400D72A RID: 55082
		Ok,
		// Token: 0x0400D72B RID: 55083
		YesNo,
		// Token: 0x0400D72C RID: 55084
		OkCancel,
		// Token: 0x0400D72D RID: 55085
		YesNoCancel,
		// Token: 0x0400D72E RID: 55086
		CancelRetryContinue,
		// Token: 0x0400D72F RID: 55087
		YesNoYesAllNoAll,
		// Token: 0x0400D730 RID: 55088
		YesNoYesAllNoAllCancel,
		// Token: 0x0400D731 RID: 55089
		YesNoYesAll,
		// Token: 0x0400D732 RID: 55090
		EEditorMsgType_MAX
	}
}
