using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200295C RID: 10588
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EUMGSequencePlayMode")]
	public enum EUMGSequencePlayMode
	{
		// Token: 0x040158A7 RID: 88231
		Forward,
		// Token: 0x040158A8 RID: 88232
		Reverse,
		// Token: 0x040158A9 RID: 88233
		PingPong,
		// Token: 0x040158AA RID: 88234
		EUMGSequencePlayMode_MAX
	}
}
