using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F1 RID: 1009
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARServiceAvailability")]
	public enum EARServiceAvailability : byte
	{
		// Token: 0x040018B6 RID: 6326
		UnknownError,
		// Token: 0x040018B7 RID: 6327
		UnknownChecking,
		// Token: 0x040018B8 RID: 6328
		UnknownTimedOut,
		// Token: 0x040018B9 RID: 6329
		UnsupportedDeviceNotCapable,
		// Token: 0x040018BA RID: 6330
		SupportedNotInstalled,
		// Token: 0x040018BB RID: 6331
		SupportedVersionTooOld,
		// Token: 0x040018BC RID: 6332
		SupportedInstalled,
		// Token: 0x040018BD RID: 6333
		EARServiceAvailability_MAX
	}
}
