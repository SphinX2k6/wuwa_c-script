using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200279A RID: 10138
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EReductionHeuristics")]
	public enum EReductionHeuristics : byte
	{
		// Token: 0x04014A30 RID: 84528
		Fast,
		// Token: 0x04014A31 RID: 84529
		Consistent,
		// Token: 0x04014A32 RID: 84530
		EReductionHeuristics_MAX
	}
}
