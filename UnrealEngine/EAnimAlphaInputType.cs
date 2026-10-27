using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E9 RID: 2537
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimAlphaInputType")]
	public enum EAnimAlphaInputType : byte
	{
		// Token: 0x0400441B RID: 17435
		Float,
		// Token: 0x0400441C RID: 17436
		Bool,
		// Token: 0x0400441D RID: 17437
		Curve,
		// Token: 0x0400441E RID: 17438
		EAnimAlphaInputType_MAX
	}
}
