using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BF RID: 447
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPointOnCircleSpacingMethod")]
	public enum EPointOnCircleSpacingMethod : byte
	{
		// Token: 0x0400086E RID: 2158
		BySpaceBetween,
		// Token: 0x0400086F RID: 2159
		ByNumberOfPoints,
		// Token: 0x04000870 RID: 2160
		EPointOnCircleSpacingMethod_MAX
	}
}
