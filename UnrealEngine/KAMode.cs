using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015DF RID: 5599
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KAMode")]
	public enum KAMode : byte
	{
		// Token: 0x0400AFBB RID: 44987
		NORMAL,
		// Token: 0x0400AFBC RID: 44988
		DEBUG,
		// Token: 0x0400AFBD RID: 44989
		DEBUG_ONLY,
		// Token: 0x0400AFBE RID: 44990
		KAMode_MAX
	}
}
