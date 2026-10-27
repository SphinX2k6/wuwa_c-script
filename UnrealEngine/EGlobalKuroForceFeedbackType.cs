using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001993 RID: 6547
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroInput.EGlobalKuroForceFeedbackType")]
	public enum EGlobalKuroForceFeedbackType : byte
	{
		// Token: 0x0400D281 RID: 53889
		Always,
		// Token: 0x0400D282 RID: 53890
		Sometimes,
		// Token: 0x0400D283 RID: 53891
		Never,
		// Token: 0x0400D284 RID: 53892
		EGlobalKuroForceFeedbackType_MAX
	}
}
