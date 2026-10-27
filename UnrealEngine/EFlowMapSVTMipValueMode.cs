using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6F RID: 2671
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFlowMapSVTMipValueMode")]
	public enum EFlowMapSVTMipValueMode
	{
		// Token: 0x040047AA RID: 18346
		FMSVTMVM_None,
		// Token: 0x040047AB RID: 18347
		FMSVTMVM_MipLevel,
		// Token: 0x040047AC RID: 18348
		FMSVTMVM_MipBias,
		// Token: 0x040047AD RID: 18349
		FMSVTMVM_MAX
	}
}
