using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001EC RID: 492
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMontagePlayReturnType")]
	public enum EMontagePlayReturnType : byte
	{
		// Token: 0x04000C2A RID: 3114
		MontageLength,
		// Token: 0x04000C2B RID: 3115
		Duration,
		// Token: 0x04000C2C RID: 3116
		EMontagePlayReturnType_MAX
	}
}
