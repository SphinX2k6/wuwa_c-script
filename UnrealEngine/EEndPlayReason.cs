using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A63 RID: 2659
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEndPlayReason")]
	public enum EEndPlayReason
	{
		// Token: 0x04004767 RID: 18279
		Destroyed,
		// Token: 0x04004768 RID: 18280
		LevelTransition,
		// Token: 0x04004769 RID: 18281
		EndPlayInEditor,
		// Token: 0x0400476A RID: 18282
		RemovedFromWorld,
		// Token: 0x0400476B RID: 18283
		Quit,
		// Token: 0x0400476C RID: 18284
		EEndPlayReason_MAX
	}
}
