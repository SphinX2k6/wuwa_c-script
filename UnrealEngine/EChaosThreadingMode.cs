using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045A RID: 1114
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EChaosThreadingMode")]
	public enum EChaosThreadingMode : byte
	{
		// Token: 0x04001BC4 RID: 7108
		DedicatedThread,
		// Token: 0x04001BC5 RID: 7109
		TaskGraph,
		// Token: 0x04001BC6 RID: 7110
		SingleThread,
		// Token: 0x04001BC7 RID: 7111
		Num,
		// Token: 0x04001BC8 RID: 7112
		Invalid,
		// Token: 0x04001BC9 RID: 7113
		EChaosThreadingMode_MAX
	}
}
