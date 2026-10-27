using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200042D RID: 1069
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/BlueprintGraph.ESaveOnCompile")]
	public enum ESaveOnCompile
	{
		// Token: 0x04001A27 RID: 6695
		SoC_Never,
		// Token: 0x04001A28 RID: 6696
		SoC_SuccessOnly,
		// Token: 0x04001A29 RID: 6697
		SoC_Always,
		// Token: 0x04001A2A RID: 6698
		SoC_MAX
	}
}
