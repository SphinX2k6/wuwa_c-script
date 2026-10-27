using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020017E6 RID: 6118
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCrowdAi.EKuroCrowdAiNotifyType")]
	public enum EKuroCrowdAiNotifyType : byte
	{
		// Token: 0x0400C448 RID: 50248
		AnimNotify,
		// Token: 0x0400C449 RID: 50249
		AnimNotifyState,
		// Token: 0x0400C44A RID: 50250
		EKuroCrowdAiNotifyType_MAX
	}
}
