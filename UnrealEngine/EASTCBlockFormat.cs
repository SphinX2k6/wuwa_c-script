using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F5 RID: 2549
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EASTCBlockFormat")]
	public enum EASTCBlockFormat
	{
		// Token: 0x0400445B RID: 17499
		ABF_Default,
		// Token: 0x0400445C RID: 17500
		ABF_4x4,
		// Token: 0x0400445D RID: 17501
		ABF_6x6,
		// Token: 0x0400445E RID: 17502
		ABF_8x8,
		// Token: 0x0400445F RID: 17503
		ABF_10x10,
		// Token: 0x04004460 RID: 17504
		ABF_12x12,
		// Token: 0x04004461 RID: 17505
		ABF_MAX
	}
}
