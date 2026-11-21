using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001EA RID: 490
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialShadingRate")]
	public enum EMaterialShadingRate
	{
		// Token: 0x04000C1C RID: 3100
		MSR_1x1,
		// Token: 0x04000C1D RID: 3101
		MSR_2x1,
		// Token: 0x04000C1E RID: 3102
		MSR_1x2,
		// Token: 0x04000C1F RID: 3103
		MSR_2x2,
		// Token: 0x04000C20 RID: 3104
		MSR_4x2,
		// Token: 0x04000C21 RID: 3105
		MSR_2x4,
		// Token: 0x04000C22 RID: 3106
		MSR_4x4,
		// Token: 0x04000C23 RID: 3107
		MSR_Count,
		// Token: 0x04000C24 RID: 3108
		MSR_MAX
	}
}
