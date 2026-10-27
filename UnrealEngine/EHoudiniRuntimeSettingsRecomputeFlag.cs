using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001496 RID: 5270
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniRuntimeSettingsRecomputeFlag")]
	public enum EHoudiniRuntimeSettingsRecomputeFlag
	{
		// Token: 0x0400A4E6 RID: 42214
		HRSRF_Always,
		// Token: 0x0400A4E7 RID: 42215
		HRSRF_OnlyIfMissing,
		// Token: 0x0400A4E8 RID: 42216
		HRSRF_Never,
		// Token: 0x0400A4E9 RID: 42217
		HRSRF_MAX
	}
}
