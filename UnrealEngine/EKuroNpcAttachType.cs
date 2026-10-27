using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7E RID: 6782
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroNpcAttachType")]
	public enum EKuroNpcAttachType : byte
	{
		// Token: 0x0400D9C7 RID: 55751
		Face,
		// Token: 0x0400D9C8 RID: 55752
		Hair,
		// Token: 0x0400D9C9 RID: 55753
		Body,
		// Token: 0x0400D9CA RID: 55754
		BodyUp,
		// Token: 0x0400D9CB RID: 55755
		BodyDown,
		// Token: 0x0400D9CC RID: 55756
		Auto,
		// Token: 0x0400D9CD RID: 55757
		Num,
		// Token: 0x0400D9CE RID: 55758
		EKuroNpcAttachType_MAX
	}
}
