using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002D3 RID: 723
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KAMode")]
	public enum KAMode : byte
	{
		// Token: 0x04001F65 RID: 8037
		NORMAL,
		// Token: 0x04001F66 RID: 8038
		DEBUG,
		// Token: 0x04001F67 RID: 8039
		DEBUG_ONLY,
		// Token: 0x04001F68 RID: 8040
		KAMode_MAX
	}
}
