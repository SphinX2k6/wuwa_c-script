using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200110B RID: 4363
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshTerminationCriterion")]
	public enum SkeletalMeshTerminationCriterion
	{
		// Token: 0x04008872 RID: 34930
		SMTC_NumOfTriangles,
		// Token: 0x04008873 RID: 34931
		SMTC_NumOfVerts,
		// Token: 0x04008874 RID: 34932
		SMTC_TriangleOrVert,
		// Token: 0x04008875 RID: 34933
		SMTC_AbsNumOfTriangles,
		// Token: 0x04008876 RID: 34934
		SMTC_AbsNumOfVerts,
		// Token: 0x04008877 RID: 34935
		SMTC_AbsTriangleOrVert,
		// Token: 0x04008878 RID: 34936
		SMTC_MAX
	}
}
