using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A08 RID: 2568
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBakedBoneSplitResourceLifetimeMode")]
	public enum EBakedBoneSplitResourceLifetimeMode : byte
	{
		// Token: 0x040044CF RID: 17615
		ComponentLifetime,
		// Token: 0x040044D0 RID: 17616
		OnDemand,
		// Token: 0x040044D1 RID: 17617
		EBakedBoneSplitResourceLifetimeMode_MAX
	}
}
