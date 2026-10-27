using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F3 RID: 2547
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EApplicationState")]
	public enum EApplicationState
	{
		// Token: 0x04004450 RID: 17488
		Unknown,
		// Token: 0x04004451 RID: 17489
		Inactive,
		// Token: 0x04004452 RID: 17490
		Background,
		// Token: 0x04004453 RID: 17491
		Active,
		// Token: 0x04004454 RID: 17492
		EApplicationState_MAX
	}
}
