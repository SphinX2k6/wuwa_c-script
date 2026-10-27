using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A3B RID: 10811
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EReloadPackagesInteractionMode")]
	public enum EReloadPackagesInteractionMode : byte
	{
		// Token: 0x04015EA2 RID: 89762
		Interactive,
		// Token: 0x04015EA3 RID: 89763
		AssumePositive,
		// Token: 0x04015EA4 RID: 89764
		AssumeNegative,
		// Token: 0x04015EA5 RID: 89765
		EReloadPackagesInteractionMode_MAX
	}
}
