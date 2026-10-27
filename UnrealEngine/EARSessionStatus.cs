using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F4 RID: 1012
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARSessionStatus")]
	public enum EARSessionStatus : byte
	{
		// Token: 0x040018C9 RID: 6345
		NotStarted,
		// Token: 0x040018CA RID: 6346
		Running,
		// Token: 0x040018CB RID: 6347
		NotSupported,
		// Token: 0x040018CC RID: 6348
		FatalError,
		// Token: 0x040018CD RID: 6349
		PermissionNotGranted,
		// Token: 0x040018CE RID: 6350
		UnsupportedConfiguration,
		// Token: 0x040018CF RID: 6351
		Other,
		// Token: 0x040018D0 RID: 6352
		EARSessionStatus_MAX
	}
}
