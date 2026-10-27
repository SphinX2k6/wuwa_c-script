using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003EC RID: 1004
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARLineTraceChannels")]
	public enum EARLineTraceChannels : byte
	{
		// Token: 0x04001890 RID: 6288
		None,
		// Token: 0x04001891 RID: 6289
		FeaturePoint,
		// Token: 0x04001892 RID: 6290
		GroundPlane,
		// Token: 0x04001893 RID: 6291
		PlaneUsingExtent = 4,
		// Token: 0x04001894 RID: 6292
		PlaneUsingBoundaryPolygon = 8,
		// Token: 0x04001895 RID: 6293
		EARLineTraceChannels_MAX
	}
}
