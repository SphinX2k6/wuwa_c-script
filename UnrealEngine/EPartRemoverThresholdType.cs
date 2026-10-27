using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002799 RID: 10137
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EPartRemoverThresholdType")]
	public enum EPartRemoverThresholdType : byte
	{
		// Token: 0x04014A2B RID: 84523
		PhysicalSize,
		// Token: 0x04014A2C RID: 84524
		OnScreenSize,
		// Token: 0x04014A2D RID: 84525
		PercentageOfSceneDiameter,
		// Token: 0x04014A2E RID: 84526
		EPartRemoverThresholdType_MAX
	}
}
