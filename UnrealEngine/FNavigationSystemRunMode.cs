using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BE1 RID: 3041
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.FNavigationSystemRunMode")]
	public enum FNavigationSystemRunMode : byte
	{
		// Token: 0x040053EC RID: 21484
		InvalidMode,
		// Token: 0x040053ED RID: 21485
		GameMode,
		// Token: 0x040053EE RID: 21486
		EditorMode,
		// Token: 0x040053EF RID: 21487
		SimulationMode,
		// Token: 0x040053F0 RID: 21488
		PIEMode,
		// Token: 0x040053F1 RID: 21489
		InferFromWorldMode,
		// Token: 0x040053F2 RID: 21490
		EditorWorldPartitionBuildMode,
		// Token: 0x040053F3 RID: 21491
		FNavigationSystemRunMode_MAX
	}
}
