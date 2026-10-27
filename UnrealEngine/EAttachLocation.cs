using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F6 RID: 2550
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttachLocation")]
	public enum EAttachLocation
	{
		// Token: 0x04004463 RID: 17507
		KeepRelativeOffset,
		// Token: 0x04004464 RID: 17508
		KeepWorldPosition,
		// Token: 0x04004465 RID: 17509
		SnapToTarget,
		// Token: 0x04004466 RID: 17510
		SnapToTargetIncludingScale,
		// Token: 0x04004467 RID: 17511
		EAttachLocation_MAX
	}
}
