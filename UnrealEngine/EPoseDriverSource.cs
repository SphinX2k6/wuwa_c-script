using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000320 RID: 800
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EPoseDriverSource")]
	public enum EPoseDriverSource : byte
	{
		// Token: 0x04001322 RID: 4898
		Rotation,
		// Token: 0x04001323 RID: 4899
		Translation,
		// Token: 0x04001324 RID: 4900
		EPoseDriverSource_MAX
	}
}
