using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A49 RID: 10825
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDClasses.EUsdDuplicateType")]
	public enum EUsdDuplicateType : byte
	{
		// Token: 0x04015EF3 RID: 89843
		FlattenComposedPrim,
		// Token: 0x04015EF4 RID: 89844
		SingleLayerSpecs,
		// Token: 0x04015EF5 RID: 89845
		AllLocalLayerSpecs,
		// Token: 0x04015EF6 RID: 89846
		EUsdDuplicateType_MAX
	}
}
