using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200264C RID: 9804
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PortalServices.EEntitlementCacheLevelRetrieved")]
	public enum EEntitlementCacheLevelRetrieved : byte
	{
		// Token: 0x04013924 RID: 80164
		None,
		// Token: 0x04013925 RID: 80165
		Memory,
		// Token: 0x04013926 RID: 80166
		Disk,
		// Token: 0x04013927 RID: 80167
		EEntitlementCacheLevelRetrieved_MAX
	}
}
