using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A13 RID: 2579
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlueprintStatus")]
	public enum EBlueprintStatus
	{
		// Token: 0x0400450B RID: 17675
		BS_Unknown,
		// Token: 0x0400450C RID: 17676
		BS_Dirty,
		// Token: 0x0400450D RID: 17677
		BS_Error,
		// Token: 0x0400450E RID: 17678
		BS_UpToDate,
		// Token: 0x0400450F RID: 17679
		BS_BeingCreated,
		// Token: 0x04004510 RID: 17680
		BS_UpToDateWithWarnings,
		// Token: 0x04004511 RID: 17681
		BS_MAX
	}
}
