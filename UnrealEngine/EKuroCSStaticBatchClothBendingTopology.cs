using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001780 RID: 6016
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroCSStaticBatchClothBendingTopology")]
	public enum EKuroCSStaticBatchClothBendingTopology : byte
	{
		// Token: 0x0400BCEC RID: 48364
		Full,
		// Token: 0x0400BCED RID: 48365
		Structural,
		// Token: 0x0400BCEE RID: 48366
		RowEdgesOnly,
		// Token: 0x0400BCEF RID: 48367
		EKuroCSStaticBatchClothBendingTopology_MAX
	}
}
