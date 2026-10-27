using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019DD RID: 6621
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EMoveSlideType")]
	public enum EMoveSlideType : byte
	{
		// Token: 0x0400D488 RID: 54408
		Free,
		// Token: 0x0400D489 RID: 54409
		Planar,
		// Token: 0x0400D48A RID: 54410
		RemovePositive,
		// Token: 0x0400D48B RID: 54411
		NoSlide,
		// Token: 0x0400D48C RID: 54412
		EMoveSlideType_MAX
	}
}
