using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020005BE RID: 1470
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxAchievementOrderBy")]
	public enum EXboxAchievementOrderBy : byte
	{
		// Token: 0x04003930 RID: 14640
		DefaultOrder,
		// Token: 0x04003931 RID: 14641
		TitleId,
		// Token: 0x04003932 RID: 14642
		UnlockTime,
		// Token: 0x04003933 RID: 14643
		EXboxAchievementOrderBy_MAX
	}
}
