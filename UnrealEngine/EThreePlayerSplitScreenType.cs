using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000797 RID: 1943
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EngineSettings.EThreePlayerSplitScreenType")]
	public enum EThreePlayerSplitScreenType
	{
		// Token: 0x0400310B RID: 12555
		FavorTop,
		// Token: 0x0400310C RID: 12556
		FavorBottom,
		// Token: 0x0400310D RID: 12557
		Vertical,
		// Token: 0x0400310E RID: 12558
		Horizontal,
		// Token: 0x0400310F RID: 12559
		EThreePlayerSplitScreenType_MAX
	}
}
