using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020005BF RID: 1471
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxAchievementType")]
	public enum EXboxAchievementType : byte
	{
		// Token: 0x04003935 RID: 14645
		Unknown,
		// Token: 0x04003936 RID: 14646
		All,
		// Token: 0x04003937 RID: 14647
		Persistent,
		// Token: 0x04003938 RID: 14648
		Challenge,
		// Token: 0x04003939 RID: 14649
		EXboxAchievementType_MAX
	}
}
