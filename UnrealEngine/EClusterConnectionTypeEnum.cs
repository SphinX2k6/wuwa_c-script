using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000455 RID: 1109
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.EClusterConnectionTypeEnum")]
	public enum EClusterConnectionTypeEnum : byte
	{
		// Token: 0x04001B96 RID: 7062
		Chaos_PointImplicit,
		// Token: 0x04001B97 RID: 7063
		Chaos_DelaunayTriangulation,
		// Token: 0x04001B98 RID: 7064
		Chaos_MinimalSpanningSubsetDelaunayTriangulation,
		// Token: 0x04001B99 RID: 7065
		Chaos_PointImplicitAugmentedWithMinimalDelaunay,
		// Token: 0x04001B9A RID: 7066
		Chaos_None,
		// Token: 0x04001B9B RID: 7067
		Chaos_EClsuterCreationParameters_Max,
		// Token: 0x04001B9C RID: 7068
		Chaos_MAX
	}
}
