using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A66 RID: 10854
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WindowsDeviceProfileSelector.EDataSourceType")]
	public enum EDataSourceType
	{
		// Token: 0x04015FA0 RID: 90016
		WDST_PreviousRegexMatch,
		// Token: 0x04015FA1 RID: 90017
		WDST_CPUBrand,
		// Token: 0x04015FA2 RID: 90018
		WDST_GPUBrand,
		// Token: 0x04015FA3 RID: 90019
		WDST_MAX
	}
}
