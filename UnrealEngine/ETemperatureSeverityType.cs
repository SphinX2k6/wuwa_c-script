using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B85 RID: 2949
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETemperatureSeverityType")]
	public enum ETemperatureSeverityType : byte
	{
		// Token: 0x04005120 RID: 20768
		Unknown,
		// Token: 0x04005121 RID: 20769
		Good,
		// Token: 0x04005122 RID: 20770
		Bad,
		// Token: 0x04005123 RID: 20771
		Serious,
		// Token: 0x04005124 RID: 20772
		Critical,
		// Token: 0x04005125 RID: 20773
		NumSeverities,
		// Token: 0x04005126 RID: 20774
		ETemperatureSeverityType_MAX
	}
}
