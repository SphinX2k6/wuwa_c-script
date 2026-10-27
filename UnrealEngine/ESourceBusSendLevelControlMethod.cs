using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B6F RID: 2927
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESourceBusSendLevelControlMethod")]
	public enum ESourceBusSendLevelControlMethod : byte
	{
		// Token: 0x040050AA RID: 20650
		Linear,
		// Token: 0x040050AB RID: 20651
		CustomCurve,
		// Token: 0x040050AC RID: 20652
		Manual,
		// Token: 0x040050AD RID: 20653
		ESourceBusSendLevelControlMethod_MAX
	}
}
