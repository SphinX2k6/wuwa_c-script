using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001635 RID: 5685
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharPositionStateType")]
	public enum ECharPositionStateType : byte
	{
		// Token: 0x0400B300 RID: 45824
		Ground,
		// Token: 0x0400B301 RID: 45825
		Climb,
		// Token: 0x0400B302 RID: 45826
		Air,
		// Token: 0x0400B303 RID: 45827
		Water,
		// Token: 0x0400B304 RID: 45828
		Ski,
		// Token: 0x0400B305 RID: 45829
		Ride,
		// Token: 0x0400B306 RID: 45830
		ECharPositionStateType_MAX
	}
}
