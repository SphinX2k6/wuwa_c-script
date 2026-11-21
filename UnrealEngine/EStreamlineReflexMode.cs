using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000847 RID: 2119
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineReflexBlueprint.EStreamlineReflexMode")]
	public enum EStreamlineReflexMode : byte
	{
		// Token: 0x040053F6 RID: 21494
		Off,
		// Token: 0x040053F7 RID: 21495
		Enabled,
		// Token: 0x040053F8 RID: 21496
		Boost = 3,
		// Token: 0x040053F9 RID: 21497
		EStreamlineReflexMode_MAX
	}
}
