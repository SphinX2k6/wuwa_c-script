using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E2 RID: 2530
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EActorUpdateOverlapsMethod")]
	public enum EActorUpdateOverlapsMethod : byte
	{
		// Token: 0x040043EC RID: 17388
		UseConfigDefault,
		// Token: 0x040043ED RID: 17389
		AlwaysUpdate,
		// Token: 0x040043EE RID: 17390
		OnlyUpdateMovable,
		// Token: 0x040043EF RID: 17391
		NeverUpdate,
		// Token: 0x040043F0 RID: 17392
		EActorUpdateOverlapsMethod_MAX
	}
}
