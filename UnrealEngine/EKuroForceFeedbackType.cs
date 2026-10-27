using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001995 RID: 6549
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroInput.EKuroForceFeedbackType")]
	public enum EKuroForceFeedbackType : byte
	{
		// Token: 0x0400D28B RID: 53899
		Always,
		// Token: 0x0400D28C RID: 53900
		Limit,
		// Token: 0x0400D28D RID: 53901
		EKuroForceFeedbackType_MAX
	}
}
