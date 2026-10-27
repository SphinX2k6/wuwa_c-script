using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A30 RID: 2608
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EComponentMobility")]
	public enum EComponentMobility
	{
		// Token: 0x040045CC RID: 17868
		Static,
		// Token: 0x040045CD RID: 17869
		Stationary,
		// Token: 0x040045CE RID: 17870
		Movable,
		// Token: 0x040045CF RID: 17871
		EComponentMobility_MAX
	}
}
