using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001781 RID: 6017
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EReadbackChannel")]
	public enum EReadbackChannel : byte
	{
		// Token: 0x0400BCF1 RID: 48369
		R,
		// Token: 0x0400BCF2 RID: 48370
		G,
		// Token: 0x0400BCF3 RID: 48371
		B,
		// Token: 0x0400BCF4 RID: 48372
		A,
		// Token: 0x0400BCF5 RID: 48373
		EReadbackChannel_MAX
	}
}
