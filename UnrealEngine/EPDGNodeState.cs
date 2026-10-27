using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200149D RID: 5277
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EPDGNodeState")]
	public enum EPDGNodeState : byte
	{
		// Token: 0x0400A50A RID: 42250
		None,
		// Token: 0x0400A50B RID: 42251
		Dirtied,
		// Token: 0x0400A50C RID: 42252
		Dirtying,
		// Token: 0x0400A50D RID: 42253
		Cooking,
		// Token: 0x0400A50E RID: 42254
		Cook_Complete,
		// Token: 0x0400A50F RID: 42255
		Cook_Failed,
		// Token: 0x0400A510 RID: 42256
		EPDGNodeState_MAX
	}
}
