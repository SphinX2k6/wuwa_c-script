using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B06 RID: 2822
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPanningMethod")]
	public enum EPanningMethod : sbyte
	{
		// Token: 0x04004D51 RID: 19793
		Linear,
		// Token: 0x04004D52 RID: 19794
		EqualPower,
		// Token: 0x04004D53 RID: 19795
		EPanningMethod_MAX
	}
}
