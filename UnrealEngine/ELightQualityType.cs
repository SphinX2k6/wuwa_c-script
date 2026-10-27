using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA6 RID: 2726
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightQualityType")]
	public enum ELightQualityType
	{
		// Token: 0x0400493E RID: 18750
		LightQualityExtremelyHigh,
		// Token: 0x0400493F RID: 18751
		LightQualityHigh,
		// Token: 0x04004940 RID: 18752
		LightQualityMiddle,
		// Token: 0x04004941 RID: 18753
		LightQualityLow,
		// Token: 0x04004942 RID: 18754
		LightQualityExtremelyLow,
		// Token: 0x04004943 RID: 18755
		ELightQualityType_MAX
	}
}
