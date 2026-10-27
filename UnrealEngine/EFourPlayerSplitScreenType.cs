using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000796 RID: 1942
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EngineSettings.EFourPlayerSplitScreenType")]
	public enum EFourPlayerSplitScreenType : byte
	{
		// Token: 0x04003106 RID: 12550
		Grid,
		// Token: 0x04003107 RID: 12551
		Vertical,
		// Token: 0x04003108 RID: 12552
		Horizontal,
		// Token: 0x04003109 RID: 12553
		EFourPlayerSplitScreenType_MAX
	}
}
