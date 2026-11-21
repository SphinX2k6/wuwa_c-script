using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E9 RID: 489
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightQualityType")]
	public enum ELightQualityType
	{
		// Token: 0x04000C15 RID: 3093
		LightQualityExtremelyHigh,
		// Token: 0x04000C16 RID: 3094
		LightQualityHigh,
		// Token: 0x04000C17 RID: 3095
		LightQualityMiddle,
		// Token: 0x04000C18 RID: 3096
		LightQualityLow,
		// Token: 0x04000C19 RID: 3097
		LightQualityExtremelyLow,
		// Token: 0x04000C1A RID: 3098
		ELightQualityType_MAX
	}
}
