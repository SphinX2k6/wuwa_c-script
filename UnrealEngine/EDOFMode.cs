using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A59 RID: 2649
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDOFMode")]
	public enum EDOFMode
	{
		// Token: 0x0400471D RID: 18205
		Default,
		// Token: 0x0400471E RID: 18206
		SixDOF,
		// Token: 0x0400471F RID: 18207
		YZPlane,
		// Token: 0x04004720 RID: 18208
		XZPlane,
		// Token: 0x04004721 RID: 18209
		XYPlane,
		// Token: 0x04004722 RID: 18210
		CustomPlane,
		// Token: 0x04004723 RID: 18211
		None,
		// Token: 0x04004724 RID: 18212
		EDOFMode_MAX
	}
}
