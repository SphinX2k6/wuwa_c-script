using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E9B RID: 7835
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxAchievementType")]
	public enum EXboxAchievementType : byte
	{
		// Token: 0x040101F9 RID: 66041
		Unknown,
		// Token: 0x040101FA RID: 66042
		All,
		// Token: 0x040101FB RID: 66043
		Persistent,
		// Token: 0x040101FC RID: 66044
		Challenge,
		// Token: 0x040101FD RID: 66045
		EXboxAchievementType_MAX
	}
}
