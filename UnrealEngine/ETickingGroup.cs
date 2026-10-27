using System;

namespace UnrealEngine
{
	// Token: 0x0200007A RID: 122
	public enum ETickingGroup
	{
		// Token: 0x040001B4 RID: 436
		TG_PrePhysics,
		// Token: 0x040001B5 RID: 437
		TG_StartPhysics,
		// Token: 0x040001B6 RID: 438
		TG_DuringPhysics,
		// Token: 0x040001B7 RID: 439
		TG_EndPhysics,
		// Token: 0x040001B8 RID: 440
		TG_PostPhysics,
		// Token: 0x040001B9 RID: 441
		TG_PostUpdateWork,
		// Token: 0x040001BA RID: 442
		TG_LastDemotable,
		// Token: 0x040001BB RID: 443
		TG_NewlySpawned,
		// Token: 0x040001BC RID: 444
		TG_MAX
	}
}
