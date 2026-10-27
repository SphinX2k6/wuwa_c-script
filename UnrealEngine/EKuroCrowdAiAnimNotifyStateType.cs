using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020017E3 RID: 6115
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCrowdAi.EKuroCrowdAiAnimNotifyStateType")]
	public enum EKuroCrowdAiAnimNotifyStateType : byte
	{
		// Token: 0x0400C435 RID: 50229
		None,
		// Token: 0x0400C436 RID: 50230
		AnimNotifyStateAddMaterial,
		// Token: 0x0400C437 RID: 50231
		AnimNotifyStateHideMesh,
		// Token: 0x0400C438 RID: 50232
		AnimNotifyStateChangeRadius,
		// Token: 0x0400C439 RID: 50233
		AnimNotifyStateAudioEvent,
		// Token: 0x0400C43A RID: 50234
		EKuroCrowdAiAnimNotifyStateType_MAX
	}
}
