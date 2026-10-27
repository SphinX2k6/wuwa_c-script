using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001600 RID: 5632
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnimEd.EKuroSlotBlendDebugDraw")]
	public enum EKuroSlotBlendDebugDraw : byte
	{
		// Token: 0x0400B06F RID: 45167
		None,
		// Token: 0x0400B070 RID: 45168
		Base,
		// Token: 0x0400B071 RID: 45169
		Slot,
		// Token: 0x0400B072 RID: 45170
		Blend,
		// Token: 0x0400B073 RID: 45171
		EKuroSlotBlendDebugDraw_MAX
	}
}
