using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002237 RID: 8759
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Localization.ELocalizationTargetConflictStatus")]
	public enum ELocalizationTargetConflictStatus : byte
	{
		// Token: 0x04011C60 RID: 72800
		Unknown,
		// Token: 0x04011C61 RID: 72801
		ConflictsPresent,
		// Token: 0x04011C62 RID: 72802
		Clear,
		// Token: 0x04011C63 RID: 72803
		ELocalizationTargetConflictStatus_MAX
	}
}
