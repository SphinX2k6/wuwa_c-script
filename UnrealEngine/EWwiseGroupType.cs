using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A7E RID: 10878
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.EWwiseGroupType")]
	public enum EWwiseGroupType : byte
	{
		// Token: 0x0401601C RID: 90140
		Switch,
		// Token: 0x0401601D RID: 90141
		State,
		// Token: 0x0401601E RID: 90142
		Unknown = 255
	}
}
