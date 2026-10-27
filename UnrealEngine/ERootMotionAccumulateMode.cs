using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B4C RID: 2892
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERootMotionAccumulateMode")]
	public enum ERootMotionAccumulateMode : byte
	{
		// Token: 0x04004FA4 RID: 20388
		Override,
		// Token: 0x04004FA5 RID: 20389
		Additive,
		// Token: 0x04004FA6 RID: 20390
		ERootMotionAccumulateMode_MAX
	}
}
