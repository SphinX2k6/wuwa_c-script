using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045B RID: 1115
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EClusterUnionMethod")]
	public enum EClusterUnionMethod : byte
	{
		// Token: 0x04001BCB RID: 7115
		PointImplicit,
		// Token: 0x04001BCC RID: 7116
		DelaunayTriangulation,
		// Token: 0x04001BCD RID: 7117
		MinimalSpanningSubsetDelaunayTriangulation,
		// Token: 0x04001BCE RID: 7118
		PointImplicitAugmentedWithMinimalDelaunay,
		// Token: 0x04001BCF RID: 7119
		None,
		// Token: 0x04001BD0 RID: 7120
		EClusterUnionMethod_MAX
	}
}
