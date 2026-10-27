using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200181B RID: 6171
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EMsgType")]
	public enum EMsgType : byte
	{
		// Token: 0x0400C622 RID: 50722
		Ok,
		// Token: 0x0400C623 RID: 50723
		YesNo,
		// Token: 0x0400C624 RID: 50724
		OkCancel,
		// Token: 0x0400C625 RID: 50725
		YesNoCancel,
		// Token: 0x0400C626 RID: 50726
		CancelRetryContinue,
		// Token: 0x0400C627 RID: 50727
		YesNoYesAllNoAll,
		// Token: 0x0400C628 RID: 50728
		YesNoYesAllNoAllCancel,
		// Token: 0x0400C629 RID: 50729
		YesNoYesAll,
		// Token: 0x0400C62A RID: 50730
		Default = 0,
		// Token: 0x0400C62B RID: 50731
		EMsgType_MAX = 8
	}
}
