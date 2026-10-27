using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FEB RID: 8171
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EOutOfBoundsType")]
	public enum EOutOfBoundsType : byte
	{
		// Token: 0x04010BBA RID: 68538
		NotOut,
		// Token: 0x04010BBB RID: 68539
		OutOfBegin,
		// Token: 0x04010BBC RID: 68540
		OutOfEnd,
		// Token: 0x04010BBD RID: 68541
		EOutOfBoundsType_MAX
	}
}
