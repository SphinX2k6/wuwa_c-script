using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028C6 RID: 10438
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineBlueprint.EStreamlineFeatureRequirementsFlags")]
	public enum EStreamlineFeatureRequirementsFlags : byte
	{
		// Token: 0x04015441 RID: 87105
		None,
		// Token: 0x04015442 RID: 87106
		D3D11Supported,
		// Token: 0x04015443 RID: 87107
		D3D12Supported,
		// Token: 0x04015444 RID: 87108
		VulkanSupported = 4,
		// Token: 0x04015445 RID: 87109
		VSyncOffRequired = 8,
		// Token: 0x04015446 RID: 87110
		HardwareSchedulingRequired = 16,
		// Token: 0x04015447 RID: 87111
		EStreamlineFeatureRequirementsFlags_MAX
	}
}
