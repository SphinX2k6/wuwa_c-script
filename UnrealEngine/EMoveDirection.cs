using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001644 RID: 5700
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EMoveDirection")]
	public enum EMoveDirection : byte
	{
		// Token: 0x0400B35C RID: 45916
		Forward,
		// Token: 0x0400B35D RID: 45917
		Backward,
		// Token: 0x0400B35E RID: 45918
		Left,
		// Token: 0x0400B35F RID: 45919
		Right,
		// Token: 0x0400B360 RID: 45920
		Stop,
		// Token: 0x0400B361 RID: 45921
		EMoveDirection_MAX
	}
}
