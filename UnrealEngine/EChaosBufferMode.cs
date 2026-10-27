using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000458 RID: 1112
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EChaosBufferMode")]
	public enum EChaosBufferMode : byte
	{
		// Token: 0x04001BB8 RID: 7096
		Double,
		// Token: 0x04001BB9 RID: 7097
		Triple,
		// Token: 0x04001BBA RID: 7098
		Num,
		// Token: 0x04001BBB RID: 7099
		Invalid,
		// Token: 0x04001BBC RID: 7100
		EChaosBufferMode_MAX
	}
}
