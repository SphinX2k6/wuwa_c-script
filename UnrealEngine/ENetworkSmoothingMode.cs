using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AEF RID: 2799
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENetworkSmoothingMode")]
	public enum ENetworkSmoothingMode : byte
	{
		// Token: 0x04004B75 RID: 19317
		Disabled,
		// Token: 0x04004B76 RID: 19318
		Linear,
		// Token: 0x04004B77 RID: 19319
		Exponential,
		// Token: 0x04004B78 RID: 19320
		Replay,
		// Token: 0x04004B79 RID: 19321
		Predicting,
		// Token: 0x04004B7A RID: 19322
		KuroReplay,
		// Token: 0x04004B7B RID: 19323
		ENetworkSmoothingMode_MAX
	}
}
