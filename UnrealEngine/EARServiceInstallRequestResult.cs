using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F2 RID: 1010
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARServiceInstallRequestResult")]
	public enum EARServiceInstallRequestResult : byte
	{
		// Token: 0x040018BF RID: 6335
		Installed,
		// Token: 0x040018C0 RID: 6336
		DeviceNotCompatible,
		// Token: 0x040018C1 RID: 6337
		UserDeclinedInstallation,
		// Token: 0x040018C2 RID: 6338
		FatalError,
		// Token: 0x040018C3 RID: 6339
		EARServiceInstallRequestResult_MAX
	}
}
