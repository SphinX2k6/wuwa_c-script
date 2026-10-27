using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A0F RID: 10767
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EBakedBoneMeshMergeResult")]
	public enum EBakedBoneMeshMergeResult : byte
	{
		// Token: 0x04015D7F RID: 89471
		Failed_NotMergeable,
		// Token: 0x04015D80 RID: 89472
		Succeed_NeedRemoveLOD,
		// Token: 0x04015D81 RID: 89473
		Succeed_NothingElse,
		// Token: 0x04015D82 RID: 89474
		EBakedBoneMeshMergeResult_MAX
	}
}
