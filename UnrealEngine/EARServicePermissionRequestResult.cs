using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F3 RID: 1011
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARServicePermissionRequestResult")]
	public enum EARServicePermissionRequestResult : byte
	{
		// Token: 0x040018C5 RID: 6341
		Granted,
		// Token: 0x040018C6 RID: 6342
		Denied,
		// Token: 0x040018C7 RID: 6343
		EARServicePermissionRequestResult_MAX
	}
}
