using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A34 RID: 10804
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPlayNetMode")]
	public enum EPlayNetMode
	{
		// Token: 0x04015E77 RID: 89719
		PIE_Standalone,
		// Token: 0x04015E78 RID: 89720
		PIE_ListenServer,
		// Token: 0x04015E79 RID: 89721
		PIE_Client,
		// Token: 0x04015E7A RID: 89722
		PIE_MAX
	}
}
