using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E9A RID: 7834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxAchievementOrderBy")]
	public enum EXboxAchievementOrderBy : byte
	{
		// Token: 0x040101F4 RID: 66036
		DefaultOrder,
		// Token: 0x040101F5 RID: 66037
		TitleId,
		// Token: 0x040101F6 RID: 66038
		UnlockTime,
		// Token: 0x040101F7 RID: 66039
		EXboxAchievementOrderBy_MAX
	}
}
