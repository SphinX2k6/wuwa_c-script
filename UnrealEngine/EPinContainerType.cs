using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B1A RID: 2842
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPinContainerType")]
	public enum EPinContainerType : byte
	{
		// Token: 0x04004DD2 RID: 19922
		None,
		// Token: 0x04004DD3 RID: 19923
		Array,
		// Token: 0x04004DD4 RID: 19924
		Set,
		// Token: 0x04004DD5 RID: 19925
		Map,
		// Token: 0x04004DD6 RID: 19926
		EPinContainerType_MAX
	}
}
