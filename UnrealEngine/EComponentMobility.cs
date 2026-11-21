using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D9 RID: 473
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EComponentMobility")]
	public enum EComponentMobility
	{
		// Token: 0x04000B9E RID: 2974
		Static,
		// Token: 0x04000B9F RID: 2975
		Stationary,
		// Token: 0x04000BA0 RID: 2976
		Movable,
		// Token: 0x04000BA1 RID: 2977
		EComponentMobility_MAX
	}
}
