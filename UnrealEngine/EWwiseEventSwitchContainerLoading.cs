using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A7D RID: 10877
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.EWwiseEventSwitchContainerLoading")]
	public enum EWwiseEventSwitchContainerLoading : byte
	{
		// Token: 0x04016018 RID: 90136
		AlwaysLoad,
		// Token: 0x04016019 RID: 90137
		LoadOnReference,
		// Token: 0x0401601A RID: 90138
		EWwiseEventSwitchContainerLoading_MAX
	}
}
