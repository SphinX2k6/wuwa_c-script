using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A46 RID: 6726
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroMaterialQualityLevel")]
	public enum EKuroMaterialQualityLevel : byte
	{
		// Token: 0x0400D73B RID: 55099
		Low,
		// Token: 0x0400D73C RID: 55100
		High,
		// Token: 0x0400D73D RID: 55101
		Medium,
		// Token: 0x0400D73E RID: 55102
		Epic,
		// Token: 0x0400D73F RID: 55103
		DefaultLevel,
		// Token: 0x0400D740 RID: 55104
		EKuroMaterialQualityLevel_MAX
	}
}
