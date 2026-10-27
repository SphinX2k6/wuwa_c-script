using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A51 RID: 2641
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDistributionVectorLockFlags")]
	public enum EDistributionVectorLockFlags
	{
		// Token: 0x040046E9 RID: 18153
		EDVLF_None,
		// Token: 0x040046EA RID: 18154
		EDVLF_XY,
		// Token: 0x040046EB RID: 18155
		EDVLF_XZ,
		// Token: 0x040046EC RID: 18156
		EDVLF_YZ,
		// Token: 0x040046ED RID: 18157
		EDVLF_XYZ,
		// Token: 0x040046EE RID: 18158
		EDVLF_MAX
	}
}
