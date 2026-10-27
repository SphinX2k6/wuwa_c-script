using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000465 RID: 1125
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EInitialVelocityTypeEnum")]
	public enum EInitialVelocityTypeEnum : byte
	{
		// Token: 0x04001C1B RID: 7195
		Chaos_Initial_Velocity_User_Defined,
		// Token: 0x04001C1C RID: 7196
		Chaos_Initial_Velocity_None,
		// Token: 0x04001C1D RID: 7197
		Chaos_Max,
		// Token: 0x04001C1E RID: 7198
		Chaos_MAX
	}
}
