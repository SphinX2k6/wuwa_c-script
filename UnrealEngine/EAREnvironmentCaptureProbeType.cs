using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E0 RID: 992
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EAREnvironmentCaptureProbeType")]
	public enum EAREnvironmentCaptureProbeType : byte
	{
		// Token: 0x04001816 RID: 6166
		None,
		// Token: 0x04001817 RID: 6167
		Manual,
		// Token: 0x04001818 RID: 6168
		Automatic,
		// Token: 0x04001819 RID: 6169
		EAREnvironmentCaptureProbeType_MAX
	}
}
