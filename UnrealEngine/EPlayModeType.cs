using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A33 RID: 10803
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPlayModeType")]
	public enum EPlayModeType
	{
		// Token: 0x04015E6C RID: 89708
		PlayMode_InViewPort,
		// Token: 0x04015E6D RID: 89709
		PlayMode_InEditorFloating,
		// Token: 0x04015E6E RID: 89710
		PlayMode_InMobilePreview,
		// Token: 0x04015E6F RID: 89711
		PlayMode_InTargetedMobilePreview,
		// Token: 0x04015E70 RID: 89712
		PlayMode_InVulkanPreview,
		// Token: 0x04015E71 RID: 89713
		PlayMode_InNewProcess,
		// Token: 0x04015E72 RID: 89714
		PlayMode_InVR,
		// Token: 0x04015E73 RID: 89715
		PlayMode_Simulate,
		// Token: 0x04015E74 RID: 89716
		PlayMode_Count,
		// Token: 0x04015E75 RID: 89717
		PlayMode_MAX
	}
}
