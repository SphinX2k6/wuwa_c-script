using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001654 RID: 5716
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimIKMode")]
	public enum KuroAnimIKMode : byte
	{
		// Token: 0x0400B3BA RID: 46010
		DeltaPositionMode,
		// Token: 0x0400B3BB RID: 46011
		LocalPositionMode,
		// Token: 0x0400B3BC RID: 46012
		DeltaPositionFromCurveMode,
		// Token: 0x0400B3BD RID: 46013
		KuroAnimIKMode_MAX
	}
}
