using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003DF RID: 991
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARDepthQuality")]
	public enum EARDepthQuality : byte
	{
		// Token: 0x04001811 RID: 6161
		Unkown,
		// Token: 0x04001812 RID: 6162
		Low,
		// Token: 0x04001813 RID: 6163
		High,
		// Token: 0x04001814 RID: 6164
		EARDepthQuality_MAX
	}
}
