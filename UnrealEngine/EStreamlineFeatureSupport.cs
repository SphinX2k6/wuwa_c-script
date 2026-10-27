using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028C7 RID: 10439
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineBlueprint.EStreamlineFeatureSupport")]
	public enum EStreamlineFeatureSupport : byte
	{
		// Token: 0x04015449 RID: 87113
		Supported,
		// Token: 0x0401544A RID: 87114
		NotSupported,
		// Token: 0x0401544B RID: 87115
		NotSupportedIncompatibleHardware,
		// Token: 0x0401544C RID: 87116
		NotSupportedDriverOutOfDate,
		// Token: 0x0401544D RID: 87117
		NotSupportedOperatingSystemOutOfDate,
		// Token: 0x0401544E RID: 87118
		NotSupportedHardewareSchedulingDisabled,
		// Token: 0x0401544F RID: 87119
		NotSupportedByRHI,
		// Token: 0x04015450 RID: 87120
		NotSupportedByPlatformAtBuildTime,
		// Token: 0x04015451 RID: 87121
		NotSupportedIncompatibleAPICaptureToolActive,
		// Token: 0x04015452 RID: 87122
		EStreamlineFeatureSupport_MAX
	}
}
