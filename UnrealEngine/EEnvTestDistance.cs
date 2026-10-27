using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017F RID: 383
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestDistance")]
	public enum EEnvTestDistance
	{
		// Token: 0x040006A3 RID: 1699
		Distance3D,
		// Token: 0x040006A4 RID: 1700
		Distance2D,
		// Token: 0x040006A5 RID: 1701
		DistanceZ,
		// Token: 0x040006A6 RID: 1702
		DistanceAbsoluteZ,
		// Token: 0x040006A7 RID: 1703
		EEnvTestDistance_MAX
	}
}
