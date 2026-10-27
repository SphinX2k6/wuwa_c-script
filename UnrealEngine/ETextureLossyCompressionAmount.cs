using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8A RID: 2954
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureLossyCompressionAmount")]
	public enum ETextureLossyCompressionAmount
	{
		// Token: 0x0400514B RID: 20811
		TLCA_Default,
		// Token: 0x0400514C RID: 20812
		TLCA_None,
		// Token: 0x0400514D RID: 20813
		TLCA_Lowest,
		// Token: 0x0400514E RID: 20814
		TLCA_Low,
		// Token: 0x0400514F RID: 20815
		TLCA_Medium,
		// Token: 0x04005150 RID: 20816
		TLCA_High,
		// Token: 0x04005151 RID: 20817
		TLCA_Highest,
		// Token: 0x04005152 RID: 20818
		TLCA_MAX
	}
}
