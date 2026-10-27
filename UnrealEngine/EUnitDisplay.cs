using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A42 RID: 10818
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EUnitDisplay")]
	public enum EUnitDisplay : byte
	{
		// Token: 0x04015ECC RID: 89804
		None,
		// Token: 0x04015ECD RID: 89805
		Metric,
		// Token: 0x04015ECE RID: 89806
		Imperial,
		// Token: 0x04015ECF RID: 89807
		Invalid,
		// Token: 0x04015ED0 RID: 89808
		EUnitDisplay_MAX
	}
}
