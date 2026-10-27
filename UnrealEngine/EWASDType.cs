using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A44 RID: 10820
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EWASDType")]
	public enum EWASDType
	{
		// Token: 0x04015ED7 RID: 89815
		WASD_Always,
		// Token: 0x04015ED8 RID: 89816
		WASD_RMBOnly,
		// Token: 0x04015ED9 RID: 89817
		WASD_Never,
		// Token: 0x04015EDA RID: 89818
		WASD_MAX
	}
}
