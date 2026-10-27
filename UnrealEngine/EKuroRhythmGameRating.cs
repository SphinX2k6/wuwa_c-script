using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C42 RID: 7234
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameRating")]
	public enum EKuroRhythmGameRating : byte
	{
		// Token: 0x0400F12C RID: 61740
		Perfect,
		// Token: 0x0400F12D RID: 61741
		Great,
		// Token: 0x0400F12E RID: 61742
		Good,
		// Token: 0x0400F12F RID: 61743
		Bad,
		// Token: 0x0400F130 RID: 61744
		Miss,
		// Token: 0x0400F131 RID: 61745
		EKuroRhythmGameRating_MAX
	}
}
