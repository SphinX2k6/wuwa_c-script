using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B69 RID: 2921
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESoundDistanceCalc")]
	public enum ESoundDistanceCalc
	{
		// Token: 0x04005073 RID: 20595
		SOUNDDISTANCE_Normal,
		// Token: 0x04005074 RID: 20596
		SOUNDDISTANCE_InfiniteXYPlane,
		// Token: 0x04005075 RID: 20597
		SOUNDDISTANCE_InfiniteXZPlane,
		// Token: 0x04005076 RID: 20598
		SOUNDDISTANCE_InfiniteYZPlane,
		// Token: 0x04005077 RID: 20599
		SOUNDDISTANCE_MAX
	}
}
