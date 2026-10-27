using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A2A RID: 10794
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ELoadLevelAtStartup")]
	public enum ELoadLevelAtStartup
	{
		// Token: 0x04015E39 RID: 89657
		None,
		// Token: 0x04015E3A RID: 89658
		ProjectDefault,
		// Token: 0x04015E3B RID: 89659
		LastOpened,
		// Token: 0x04015E3C RID: 89660
		ELoadLevelAtStartup_MAX
	}
}
