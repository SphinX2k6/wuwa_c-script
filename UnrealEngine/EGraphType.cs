using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7A RID: 2682
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EGraphType")]
	public enum EGraphType
	{
		// Token: 0x040047F0 RID: 18416
		GT_Function,
		// Token: 0x040047F1 RID: 18417
		GT_Ubergraph,
		// Token: 0x040047F2 RID: 18418
		GT_Macro,
		// Token: 0x040047F3 RID: 18419
		GT_Animation,
		// Token: 0x040047F4 RID: 18420
		GT_StateMachine,
		// Token: 0x040047F5 RID: 18421
		GT_MAX
	}
}
