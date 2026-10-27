using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000479 RID: 1145
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CinematicCamera.ECameraFocusMethod")]
	public enum ECameraFocusMethod : byte
	{
		// Token: 0x04001CD3 RID: 7379
		DoNotOverride,
		// Token: 0x04001CD4 RID: 7380
		Manual,
		// Token: 0x04001CD5 RID: 7381
		Tracking,
		// Token: 0x04001CD6 RID: 7382
		Disable,
		// Token: 0x04001CD7 RID: 7383
		MAX
	}
}
