using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000E9 RID: 233
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CinematicCamera.ECameraFocusMethod")]
	public enum ECameraFocusMethod : byte
	{
		// Token: 0x040003E4 RID: 996
		DoNotOverride,
		// Token: 0x040003E5 RID: 997
		Manual,
		// Token: 0x040003E6 RID: 998
		Tracking,
		// Token: 0x040003E7 RID: 999
		Disable,
		// Token: 0x040003E8 RID: 1000
		MAX
	}
}
