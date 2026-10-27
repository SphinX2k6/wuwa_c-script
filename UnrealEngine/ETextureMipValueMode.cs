using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8C RID: 2956
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureMipValueMode")]
	public enum ETextureMipValueMode
	{
		// Token: 0x04005159 RID: 20825
		TMVM_None,
		// Token: 0x0400515A RID: 20826
		TMVM_MipLevel,
		// Token: 0x0400515B RID: 20827
		TMVM_MipBias,
		// Token: 0x0400515C RID: 20828
		TMVM_Derivative,
		// Token: 0x0400515D RID: 20829
		TMVM_MAX
	}
}
