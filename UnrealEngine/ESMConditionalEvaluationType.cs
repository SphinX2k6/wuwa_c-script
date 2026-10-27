using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286A RID: 10346
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ESMConditionalEvaluationType")]
	public enum ESMConditionalEvaluationType : byte
	{
		// Token: 0x04015060 RID: 86112
		SM_Graph,
		// Token: 0x04015061 RID: 86113
		SM_NodeInstance,
		// Token: 0x04015062 RID: 86114
		SM_AlwaysFalse,
		// Token: 0x04015063 RID: 86115
		SM_AlwaysTrue,
		// Token: 0x04015064 RID: 86116
		SM_MAX
	}
}
