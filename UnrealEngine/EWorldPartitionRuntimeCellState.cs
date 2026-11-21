using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200020A RID: 522
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionRuntimeCellState")]
	public enum EWorldPartitionRuntimeCellState : byte
	{
		// Token: 0x04000D1A RID: 3354
		Unloaded,
		// Token: 0x04000D1B RID: 3355
		Loaded,
		// Token: 0x04000D1C RID: 3356
		Activated,
		// Token: 0x04000D1D RID: 3357
		EWorldPartitionRuntimeCellState_MAX
	}
}
