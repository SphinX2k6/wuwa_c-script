using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CE RID: 462
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAutoPossessAI")]
	public enum EAutoPossessAI : byte
	{
		// Token: 0x04000B46 RID: 2886
		Disabled,
		// Token: 0x04000B47 RID: 2887
		PlacedInWorld,
		// Token: 0x04000B48 RID: 2888
		Spawned,
		// Token: 0x04000B49 RID: 2889
		PlacedInWorldOrSpawned,
		// Token: 0x04000B4A RID: 2890
		EAutoPossessAI_MAX
	}
}
