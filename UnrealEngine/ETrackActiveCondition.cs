using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B97 RID: 2967
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETrackActiveCondition")]
	public enum ETrackActiveCondition
	{
		// Token: 0x040051BE RID: 20926
		ETAC_Always,
		// Token: 0x040051BF RID: 20927
		ETAC_GoreEnabled,
		// Token: 0x040051C0 RID: 20928
		ETAC_GoreDisabled,
		// Token: 0x040051C1 RID: 20929
		ETAC_MAX
	}
}
