using System;

namespace UnrealEngine
{
	// Token: 0x0200005F RID: 95
	public enum ETickingGroup
	{
		// Token: 0x0400016D RID: 365
		TG_PrePhysics,
		// Token: 0x0400016E RID: 366
		TG_StartPhysics,
		// Token: 0x0400016F RID: 367
		TG_DuringPhysics,
		// Token: 0x04000170 RID: 368
		TG_EndPhysics,
		// Token: 0x04000171 RID: 369
		TG_PostPhysics,
		// Token: 0x04000172 RID: 370
		TG_PostUpdateWork,
		// Token: 0x04000173 RID: 371
		TG_LastDemotable,
		// Token: 0x04000174 RID: 372
		TG_NewlySpawned,
		// Token: 0x04000175 RID: 373
		TG_MAX
	}
}
