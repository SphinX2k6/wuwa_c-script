using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200149E RID: 5278
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EPDGWorkResultState")]
	public enum EPDGWorkResultState : byte
	{
		// Token: 0x0400A512 RID: 42258
		None,
		// Token: 0x0400A513 RID: 42259
		ToLoad,
		// Token: 0x0400A514 RID: 42260
		Loading,
		// Token: 0x0400A515 RID: 42261
		Loaded,
		// Token: 0x0400A516 RID: 42262
		ToDelete,
		// Token: 0x0400A517 RID: 42263
		Deleting,
		// Token: 0x0400A518 RID: 42264
		Deleted,
		// Token: 0x0400A519 RID: 42265
		NotLoaded,
		// Token: 0x0400A51A RID: 42266
		EPDGWorkResultState_MAX
	}
}
