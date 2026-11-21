using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000FB RID: 251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAppMsgType")]
	public enum EAppMsgType
	{
		// Token: 0x0400043D RID: 1085
		Ok,
		// Token: 0x0400043E RID: 1086
		YesNo,
		// Token: 0x0400043F RID: 1087
		OkCancel,
		// Token: 0x04000440 RID: 1088
		YesNoCancel,
		// Token: 0x04000441 RID: 1089
		CancelRetryContinue,
		// Token: 0x04000442 RID: 1090
		YesNoYesAllNoAll,
		// Token: 0x04000443 RID: 1091
		YesNoYesAllNoAllCancel,
		// Token: 0x04000444 RID: 1092
		YesNoYesAll,
		// Token: 0x04000445 RID: 1093
		EAppMsgType_MAX
	}
}
