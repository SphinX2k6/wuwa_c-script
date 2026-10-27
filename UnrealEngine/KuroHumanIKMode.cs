using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001663 RID: 5731
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.KuroHumanIKMode")]
	public enum KuroHumanIKMode : byte
	{
		// Token: 0x0400B50C RID: 46348
		None,
		// Token: 0x0400B50D RID: 46349
		GroundMode,
		// Token: 0x0400B50E RID: 46350
		ClimbMode,
		// Token: 0x0400B50F RID: 46351
		SlideMode,
		// Token: 0x0400B510 RID: 46352
		RideMode,
		// Token: 0x0400B511 RID: 46353
		KuroHumanIKMode_MAX
	}
}
