using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002964 RID: 10596
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EWidgetTickFrequency")]
	public enum EWidgetTickFrequency : byte
	{
		// Token: 0x040158CD RID: 88269
		Never,
		// Token: 0x040158CE RID: 88270
		Auto,
		// Token: 0x040158CF RID: 88271
		EWidgetTickFrequency_MAX
	}
}
