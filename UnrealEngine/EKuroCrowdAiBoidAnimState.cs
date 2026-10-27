using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020017E5 RID: 6117
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCrowdAi.EKuroCrowdAiBoidAnimState")]
	public enum EKuroCrowdAiBoidAnimState : byte
	{
		// Token: 0x0400C441 RID: 50241
		Idle,
		// Token: 0x0400C442 RID: 50242
		Walking,
		// Token: 0x0400C443 RID: 50243
		Born,
		// Token: 0x0400C444 RID: 50244
		Destroy,
		// Token: 0x0400C445 RID: 50245
		Perform,
		// Token: 0x0400C446 RID: 50246
		EKuroCrowdAiBoidAnimState_MAX
	}
}
