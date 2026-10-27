using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A36 RID: 10806
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPlayOnLaunchConfiguration")]
	public enum EPlayOnLaunchConfiguration
	{
		// Token: 0x04015E82 RID: 89730
		LaunchConfig_Default,
		// Token: 0x04015E83 RID: 89731
		LaunchConfig_Debug,
		// Token: 0x04015E84 RID: 89732
		LaunchConfig_Development,
		// Token: 0x04015E85 RID: 89733
		LaunchConfig_Test,
		// Token: 0x04015E86 RID: 89734
		LaunchConfig_Shipping,
		// Token: 0x04015E87 RID: 89735
		LaunchConfig_MAX
	}
}
