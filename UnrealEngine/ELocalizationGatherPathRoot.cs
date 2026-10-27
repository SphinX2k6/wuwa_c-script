using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002236 RID: 8758
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Localization.ELocalizationGatherPathRoot")]
	public enum ELocalizationGatherPathRoot : byte
	{
		// Token: 0x04011C5B RID: 72795
		Auto,
		// Token: 0x04011C5C RID: 72796
		Engine,
		// Token: 0x04011C5D RID: 72797
		Project,
		// Token: 0x04011C5E RID: 72798
		ELocalizationGatherPathRoot_MAX
	}
}
