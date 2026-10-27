using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177B RID: 6011
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroClothBendingTopology")]
	public enum EKuroClothBendingTopology : byte
	{
		// Token: 0x0400BCD6 RID: 48342
		Full,
		// Token: 0x0400BCD7 RID: 48343
		Structural,
		// Token: 0x0400BCD8 RID: 48344
		RowEdgesOnly,
		// Token: 0x0400BCD9 RID: 48345
		EKuroClothBendingTopology_MAX
	}
}
