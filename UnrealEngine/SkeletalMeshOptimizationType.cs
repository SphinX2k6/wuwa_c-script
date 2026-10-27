using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001101 RID: 4353
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshOptimizationType")]
	public enum SkeletalMeshOptimizationType
	{
		// Token: 0x0400883C RID: 34876
		SMOT_NumOfTriangles,
		// Token: 0x0400883D RID: 34877
		SMOT_MaxDeviation,
		// Token: 0x0400883E RID: 34878
		SMOT_TriangleOrDeviation,
		// Token: 0x0400883F RID: 34879
		SMOT_MAX
	}
}
