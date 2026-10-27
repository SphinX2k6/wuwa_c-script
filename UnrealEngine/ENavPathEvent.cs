using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE8 RID: 2792
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavPathEvent")]
	public enum ENavPathEvent
	{
		// Token: 0x04004B45 RID: 19269
		Cleared,
		// Token: 0x04004B46 RID: 19270
		NewPath,
		// Token: 0x04004B47 RID: 19271
		UpdatedDueToGoalMoved,
		// Token: 0x04004B48 RID: 19272
		UpdatedDueToNavigationChanged,
		// Token: 0x04004B49 RID: 19273
		Invalidated,
		// Token: 0x04004B4A RID: 19274
		RePathFailed,
		// Token: 0x04004B4B RID: 19275
		MetaPathUpdate,
		// Token: 0x04004B4C RID: 19276
		Custom,
		// Token: 0x04004B4D RID: 19277
		ENavPathEvent_MAX
	}
}
