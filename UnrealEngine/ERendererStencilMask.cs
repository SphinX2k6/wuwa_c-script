using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B44 RID: 2884
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERendererStencilMask")]
	public enum ERendererStencilMask : byte
	{
		// Token: 0x04004F6D RID: 20333
		ERSM_Default,
		// Token: 0x04004F6E RID: 20334
		ERSM_255,
		// Token: 0x04004F6F RID: 20335
		ERSM_1,
		// Token: 0x04004F70 RID: 20336
		ERSM_2,
		// Token: 0x04004F71 RID: 20337
		ERSM_4,
		// Token: 0x04004F72 RID: 20338
		ERSM_8,
		// Token: 0x04004F73 RID: 20339
		ERSM_16,
		// Token: 0x04004F74 RID: 20340
		ERSM_32,
		// Token: 0x04004F75 RID: 20341
		ERSM_64,
		// Token: 0x04004F76 RID: 20342
		ERSM_128,
		// Token: 0x04004F77 RID: 20343
		ERSM_MAX
	}
}
