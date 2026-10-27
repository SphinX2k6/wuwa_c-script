using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FD5 RID: 8149
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EAnimationPlayMode")]
	public enum EAnimationPlayMode : byte
	{
		// Token: 0x04010B2D RID: 68397
		EMOM_None,
		// Token: 0x04010B2E RID: 68398
		EMOM_ReverseAnimation,
		// Token: 0x04010B2F RID: 68399
		EMOM_CustomAnimation,
		// Token: 0x04010B30 RID: 68400
		EMOM_MAX
	}
}
