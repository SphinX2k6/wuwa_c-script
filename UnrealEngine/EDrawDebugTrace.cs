using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001DF RID: 479
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDrawDebugTrace")]
	public enum EDrawDebugTrace
	{
		// Token: 0x04000BD3 RID: 3027
		None,
		// Token: 0x04000BD4 RID: 3028
		ForOneFrame,
		// Token: 0x04000BD5 RID: 3029
		ForDuration,
		// Token: 0x04000BD6 RID: 3030
		Persistent,
		// Token: 0x04000BD7 RID: 3031
		EDrawDebugTrace_MAX
	}
}
