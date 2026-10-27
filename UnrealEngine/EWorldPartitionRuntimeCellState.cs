using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BC0 RID: 3008
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionRuntimeCellState")]
	public enum EWorldPartitionRuntimeCellState : byte
	{
		// Token: 0x040052CA RID: 21194
		Unloaded,
		// Token: 0x040052CB RID: 21195
		Loaded,
		// Token: 0x040052CC RID: 21196
		Activated,
		// Token: 0x040052CD RID: 21197
		EWorldPartitionRuntimeCellState_MAX
	}
}
