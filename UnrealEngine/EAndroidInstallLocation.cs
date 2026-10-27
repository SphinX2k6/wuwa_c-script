using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002AE RID: 686
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.EAndroidInstallLocation")]
	public enum EAndroidInstallLocation
	{
		// Token: 0x04000F05 RID: 3845
		InternalOnly,
		// Token: 0x04000F06 RID: 3846
		PreferExternal,
		// Token: 0x04000F07 RID: 3847
		Auto,
		// Token: 0x04000F08 RID: 3848
		EAndroidInstallLocation_MAX
	}
}
