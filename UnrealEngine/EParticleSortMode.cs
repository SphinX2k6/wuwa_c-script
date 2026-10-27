using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B10 RID: 2832
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSortMode")]
	public enum EParticleSortMode
	{
		// Token: 0x04004D93 RID: 19859
		PSORTMODE_None,
		// Token: 0x04004D94 RID: 19860
		PSORTMODE_ViewProjDepth,
		// Token: 0x04004D95 RID: 19861
		PSORTMODE_DistanceToView,
		// Token: 0x04004D96 RID: 19862
		PSORTMODE_Age_OldestFirst,
		// Token: 0x04004D97 RID: 19863
		PSORTMODE_Age_NewestFirst,
		// Token: 0x04004D98 RID: 19864
		PSORTMODE_MAX
	}
}
