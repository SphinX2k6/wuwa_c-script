using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000844 RID: 2116
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineBlueprint.EStreamlineFeatureSupport")]
	public enum EStreamlineFeatureSupport : byte
	{
		// Token: 0x040053DF RID: 21471
		Supported,
		// Token: 0x040053E0 RID: 21472
		NotSupported,
		// Token: 0x040053E1 RID: 21473
		NotSupportedIncompatibleHardware,
		// Token: 0x040053E2 RID: 21474
		NotSupportedDriverOutOfDate,
		// Token: 0x040053E3 RID: 21475
		NotSupportedOperatingSystemOutOfDate,
		// Token: 0x040053E4 RID: 21476
		NotSupportedHardewareSchedulingDisabled,
		// Token: 0x040053E5 RID: 21477
		NotSupportedByRHI,
		// Token: 0x040053E6 RID: 21478
		NotSupportedByPlatformAtBuildTime,
		// Token: 0x040053E7 RID: 21479
		NotSupportedIncompatibleAPICaptureToolActive,
		// Token: 0x040053E8 RID: 21480
		EStreamlineFeatureSupport_MAX
	}
}
