using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A42 RID: 6722
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EEditorMsgReturnType")]
	public enum EEditorMsgReturnType : byte
	{
		// Token: 0x0400D720 RID: 55072
		No,
		// Token: 0x0400D721 RID: 55073
		Yes,
		// Token: 0x0400D722 RID: 55074
		YesAll,
		// Token: 0x0400D723 RID: 55075
		NoAll,
		// Token: 0x0400D724 RID: 55076
		Cancel,
		// Token: 0x0400D725 RID: 55077
		Ok,
		// Token: 0x0400D726 RID: 55078
		Retry,
		// Token: 0x0400D727 RID: 55079
		Continue,
		// Token: 0x0400D728 RID: 55080
		EEditorMsgReturnType_MAX
	}
}
