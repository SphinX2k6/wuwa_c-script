using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200015D RID: 349
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DLSSBlueprint.UDLSSSupport")]
	public enum UDLSSSupport : byte
	{
		// Token: 0x0400063F RID: 1599
		Supported,
		// Token: 0x04000640 RID: 1600
		NotSupported,
		// Token: 0x04000641 RID: 1601
		NotSupportedIncompatibleHardware,
		// Token: 0x04000642 RID: 1602
		NotSupportedDriverOutOfDate,
		// Token: 0x04000643 RID: 1603
		NotSupportedOperatingSystemOutOfDate,
		// Token: 0x04000644 RID: 1604
		NotSupportedByPlatformAtBuildTime,
		// Token: 0x04000645 RID: 1605
		NotSupportedIncompatibleAPICaptureToolActive,
		// Token: 0x04000646 RID: 1606
		UDLSSSupport_MAX
	}
}
