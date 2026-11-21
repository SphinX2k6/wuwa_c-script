using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000449 RID: 1097
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroInput.EGlobalKuroForceFeedbackType")]
	public enum EGlobalKuroForceFeedbackType : byte
	{
		// Token: 0x04002CF7 RID: 11511
		Always,
		// Token: 0x04002CF8 RID: 11512
		Sometimes,
		// Token: 0x04002CF9 RID: 11513
		Never,
		// Token: 0x04002CFA RID: 11514
		EGlobalKuroForceFeedbackType_MAX
	}
}
