using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A1E RID: 2590
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraFadeMode")]
	public enum ECameraFadeMode
	{
		// Token: 0x0400454D RID: 17741
		CFM_Linear,
		// Token: 0x0400454E RID: 17742
		CFM_Transient,
		// Token: 0x0400454F RID: 17743
		CFM_InOutCubic,
		// Token: 0x04004550 RID: 17744
		CFM_OutSine,
		// Token: 0x04004551 RID: 17745
		CFM_OutQuart,
		// Token: 0x04004552 RID: 17746
		CFM_MAX
	}
}
