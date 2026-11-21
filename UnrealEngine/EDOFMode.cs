using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001DE RID: 478
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDOFMode")]
	public enum EDOFMode
	{
		// Token: 0x04000BCA RID: 3018
		Default,
		// Token: 0x04000BCB RID: 3019
		SixDOF,
		// Token: 0x04000BCC RID: 3020
		YZPlane,
		// Token: 0x04000BCD RID: 3021
		XZPlane,
		// Token: 0x04000BCE RID: 3022
		XYPlane,
		// Token: 0x04000BCF RID: 3023
		CustomPlane,
		// Token: 0x04000BD0 RID: 3024
		None,
		// Token: 0x04000BD1 RID: 3025
		EDOFMode_MAX
	}
}
