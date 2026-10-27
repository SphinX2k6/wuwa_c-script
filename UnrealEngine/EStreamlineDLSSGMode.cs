using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028CD RID: 10445
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineDLSSGBlueprint.EStreamlineDLSSGMode")]
	public enum EStreamlineDLSSGMode : byte
	{
		// Token: 0x0401546F RID: 87151
		Off,
		// Token: 0x04015470 RID: 87152
		Auto = 251,
		// Token: 0x04015471 RID: 87153
		On2X = 17,
		// Token: 0x04015472 RID: 87154
		On3X = 23,
		// Token: 0x04015473 RID: 87155
		On4X = 31,
		// Token: 0x04015474 RID: 87156
		On5X = 37,
		// Token: 0x04015475 RID: 87157
		On6X = 59,
		// Token: 0x04015476 RID: 87158
		EStreamlineDLSSGMode_MAX = 252
	}
}
