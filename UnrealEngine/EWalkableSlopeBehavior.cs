using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BBA RID: 3002
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWalkableSlopeBehavior")]
	public enum EWalkableSlopeBehavior
	{
		// Token: 0x040052AD RID: 21165
		WalkableSlope_Default,
		// Token: 0x040052AE RID: 21166
		WalkableSlope_Increase,
		// Token: 0x040052AF RID: 21167
		WalkableSlope_Decrease,
		// Token: 0x040052B0 RID: 21168
		WalkableSlope_Unwalkable,
		// Token: 0x040052B1 RID: 21169
		WalkableSlope_Max,
		// Token: 0x040052B2 RID: 21170
		WalkableSlope_MAX
	}
}
