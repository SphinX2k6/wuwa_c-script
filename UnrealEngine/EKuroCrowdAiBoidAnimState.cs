using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000356 RID: 854
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroCrowdAi.EKuroCrowdAiBoidAnimState")]
	public enum EKuroCrowdAiBoidAnimState : byte
	{
		// Token: 0x040023EC RID: 9196
		Idle,
		// Token: 0x040023ED RID: 9197
		Walking,
		// Token: 0x040023EE RID: 9198
		Born,
		// Token: 0x040023EF RID: 9199
		Destroy,
		// Token: 0x040023F0 RID: 9200
		Perform,
		// Token: 0x040023F1 RID: 9201
		EKuroCrowdAiBoidAnimState_MAX
	}
}
