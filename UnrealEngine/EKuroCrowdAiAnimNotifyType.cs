using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020017E4 RID: 6116
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCrowdAi.EKuroCrowdAiAnimNotifyType")]
	public enum EKuroCrowdAiAnimNotifyType : byte
	{
		// Token: 0x0400C43C RID: 50236
		None,
		// Token: 0x0400C43D RID: 50237
		AnimNotifyEffect,
		// Token: 0x0400C43E RID: 50238
		AnimNotifyAudioEvent,
		// Token: 0x0400C43F RID: 50239
		EKuroCrowdAiAnimNotifyType_MAX
	}
}
