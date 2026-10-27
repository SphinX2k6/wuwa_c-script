using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028FB RID: 10491
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TASdkPlugin.TAMode")]
	public enum TAMode : byte
	{
		// Token: 0x040155CB RID: 87499
		NORMAL,
		// Token: 0x040155CC RID: 87500
		DEBUG,
		// Token: 0x040155CD RID: 87501
		DEBUG_ONLY,
		// Token: 0x040155CE RID: 87502
		TAMode_MAX
	}
}
