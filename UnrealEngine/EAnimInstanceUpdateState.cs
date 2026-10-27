using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009ED RID: 2541
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimInstanceUpdateState")]
	public enum EAnimInstanceUpdateState : byte
	{
		// Token: 0x04004432 RID: 17458
		NotStart,
		// Token: 0x04004433 RID: 17459
		Updating,
		// Token: 0x04004434 RID: 17460
		Loading,
		// Token: 0x04004435 RID: 17461
		Evaluating,
		// Token: 0x04004436 RID: 17462
		Complete,
		// Token: 0x04004437 RID: 17463
		EAnimInstanceUpdateState_MAX
	}
}
