using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B5F RID: 2911
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESendLevelControlMethod")]
	public enum ESendLevelControlMethod : byte
	{
		// Token: 0x0400503E RID: 20542
		Linear,
		// Token: 0x0400503F RID: 20543
		CustomCurve,
		// Token: 0x04005040 RID: 20544
		Manual,
		// Token: 0x04005041 RID: 20545
		ESendLevelControlMethod_MAX
	}
}
