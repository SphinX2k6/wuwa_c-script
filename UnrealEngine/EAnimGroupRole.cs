using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009EC RID: 2540
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimGroupRole")]
	public enum EAnimGroupRole
	{
		// Token: 0x0400442B RID: 17451
		CanBeLeader,
		// Token: 0x0400442C RID: 17452
		AlwaysFollower,
		// Token: 0x0400442D RID: 17453
		AlwaysLeader,
		// Token: 0x0400442E RID: 17454
		TransitionLeader,
		// Token: 0x0400442F RID: 17455
		TransitionFollower,
		// Token: 0x04004430 RID: 17456
		EAnimGroupRole_MAX
	}
}
