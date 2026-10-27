using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003E5 RID: 997
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARFaceTransformMixing")]
	public enum EARFaceTransformMixing : byte
	{
		// Token: 0x04001866 RID: 6246
		ComponentOnly,
		// Token: 0x04001867 RID: 6247
		ComponentLocationTrackedRotation,
		// Token: 0x04001868 RID: 6248
		ComponentWithTracked,
		// Token: 0x04001869 RID: 6249
		TrackingOnly,
		// Token: 0x0400186A RID: 6250
		EARFaceTransformMixing_MAX
	}
}
