using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CC RID: 460
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttachLocation")]
	public enum EAttachLocation
	{
		// Token: 0x04000B3B RID: 2875
		KeepRelativeOffset,
		// Token: 0x04000B3C RID: 2876
		KeepWorldPosition,
		// Token: 0x04000B3D RID: 2877
		SnapToTarget,
		// Token: 0x04000B3E RID: 2878
		SnapToTargetIncludingScale,
		// Token: 0x04000B3F RID: 2879
		EAttachLocation_MAX
	}
}
