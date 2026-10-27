using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A7F RID: 6783
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroNpcBodyType")]
	public enum EKuroNpcBodyType : byte
	{
		// Token: 0x0400D9D0 RID: 55760
		Face,
		// Token: 0x0400D9D1 RID: 55761
		Hair,
		// Token: 0x0400D9D2 RID: 55762
		Body,
		// Token: 0x0400D9D3 RID: 55763
		BodyUp,
		// Token: 0x0400D9D4 RID: 55764
		BodyDown,
		// Token: 0x0400D9D5 RID: 55765
		Num,
		// Token: 0x0400D9D6 RID: 55766
		EKuroNpcBodyType_MAX
	}
}
