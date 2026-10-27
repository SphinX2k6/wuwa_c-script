using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F3E RID: 7998
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVoxelRuntime.EKuroVoxelCaveType")]
	public enum EKuroVoxelCaveType : byte
	{
		// Token: 0x040106BC RID: 67260
		Cave,
		// Token: 0x040106BD RID: 67261
		Room,
		// Token: 0x040106BE RID: 67262
		Transition,
		// Token: 0x040106BF RID: 67263
		RoomTransition,
		// Token: 0x040106C0 RID: 67264
		BigWorld = 254,
		// Token: 0x040106C1 RID: 67265
		Default
	}
}
