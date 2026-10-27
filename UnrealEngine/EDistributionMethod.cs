using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027E7 RID: 10215
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Simplygon.EDistributionMethod")]
	public enum EDistributionMethod
	{
		// Token: 0x04014CC8 RID: 85192
		SimplygonGrid,
		// Token: 0x04014CC9 RID: 85193
		FastBuild,
		// Token: 0x04014CCA RID: 85194
		Incredibuild,
		// Token: 0x04014CCB RID: 85195
		EDistributionMethod_MAX
	}
}
