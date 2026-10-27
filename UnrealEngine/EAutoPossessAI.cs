using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A05 RID: 2565
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAutoPossessAI")]
	public enum EAutoPossessAI : byte
	{
		// Token: 0x040044B5 RID: 17589
		Disabled,
		// Token: 0x040044B6 RID: 17590
		PlacedInWorld,
		// Token: 0x040044B7 RID: 17591
		Spawned,
		// Token: 0x040044B8 RID: 17592
		PlacedInWorldOrSpawned,
		// Token: 0x040044B9 RID: 17593
		EAutoPossessAI_MAX
	}
}
