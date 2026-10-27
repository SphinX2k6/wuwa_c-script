using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002262 RID: 8802
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EMagtThreadPriority")]
	public enum EMagtThreadPriority : byte
	{
		// Token: 0x04011D9A RID: 73114
		Normal,
		// Token: 0x04011D9B RID: 73115
		VIPLow,
		// Token: 0x04011D9C RID: 73116
		VIPMid,
		// Token: 0x04011D9D RID: 73117
		VIPHigh,
		// Token: 0x04011D9E RID: 73118
		VIPTop,
		// Token: 0x04011D9F RID: 73119
		EMagtThreadPriority_MAX
	}
}
