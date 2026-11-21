using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FC RID: 1276
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameRating")]
	public enum EKuroRhythmGameRating : byte
	{
		// Token: 0x04003283 RID: 12931
		Perfect,
		// Token: 0x04003284 RID: 12932
		Great,
		// Token: 0x04003285 RID: 12933
		Good,
		// Token: 0x04003286 RID: 12934
		Bad,
		// Token: 0x04003287 RID: 12935
		Miss,
		// Token: 0x04003288 RID: 12936
		EKuroRhythmGameRating_MAX
	}
}
