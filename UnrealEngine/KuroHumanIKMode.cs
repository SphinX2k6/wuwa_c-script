using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002FB RID: 763
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.KuroHumanIKMode")]
	public enum KuroHumanIKMode : byte
	{
		// Token: 0x040021A3 RID: 8611
		None,
		// Token: 0x040021A4 RID: 8612
		GroundMode,
		// Token: 0x040021A5 RID: 8613
		ClimbMode,
		// Token: 0x040021A6 RID: 8614
		SlideMode,
		// Token: 0x040021A7 RID: 8615
		RideMode,
		// Token: 0x040021A8 RID: 8616
		KuroHumanIKMode_MAX
	}
}
