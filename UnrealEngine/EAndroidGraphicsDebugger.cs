using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002AD RID: 685
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.EAndroidGraphicsDebugger")]
	public enum EAndroidGraphicsDebugger
	{
		// Token: 0x04000F00 RID: 3840
		None,
		// Token: 0x04000F01 RID: 3841
		Mali,
		// Token: 0x04000F02 RID: 3842
		Adreno,
		// Token: 0x04000F03 RID: 3843
		EAndroidGraphicsDebugger_MAX
	}
}
