using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000781 RID: 1921
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DLSSBlueprint.UDLSSSupport")]
	public enum UDLSSSupport : byte
	{
		// Token: 0x04003044 RID: 12356
		Supported,
		// Token: 0x04003045 RID: 12357
		NotSupported,
		// Token: 0x04003046 RID: 12358
		NotSupportedIncompatibleHardware,
		// Token: 0x04003047 RID: 12359
		NotSupportedDriverOutOfDate,
		// Token: 0x04003048 RID: 12360
		NotSupportedOperatingSystemOutOfDate,
		// Token: 0x04003049 RID: 12361
		NotSupportedByPlatformAtBuildTime,
		// Token: 0x0400304A RID: 12362
		NotSupportedIncompatibleAPICaptureToolActive,
		// Token: 0x0400304B RID: 12363
		UDLSSSupport_MAX
	}
}
