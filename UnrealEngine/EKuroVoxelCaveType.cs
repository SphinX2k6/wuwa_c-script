using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000639 RID: 1593
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVoxelRuntime.EKuroVoxelCaveType")]
	public enum EKuroVoxelCaveType : byte
	{
		// Token: 0x04003CC0 RID: 15552
		Cave,
		// Token: 0x04003CC1 RID: 15553
		Room,
		// Token: 0x04003CC2 RID: 15554
		Transition,
		// Token: 0x04003CC3 RID: 15555
		RoomTransition,
		// Token: 0x04003CC4 RID: 15556
		BigWorld = 254,
		// Token: 0x04003CC5 RID: 15557
		Default
	}
}
