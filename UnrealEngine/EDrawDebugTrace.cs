using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A5B RID: 2651
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDrawDebugTrace")]
	public enum EDrawDebugTrace
	{
		// Token: 0x0400472E RID: 18222
		None,
		// Token: 0x0400472F RID: 18223
		ForOneFrame,
		// Token: 0x04004730 RID: 18224
		ForDuration,
		// Token: 0x04004731 RID: 18225
		Persistent,
		// Token: 0x04004732 RID: 18226
		EDrawDebugTrace_MAX
	}
}
