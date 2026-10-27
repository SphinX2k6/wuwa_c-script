using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291E RID: 10526
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EDirectLightSampleMode")]
	public enum EDirectLightSampleMode
	{
		// Token: 0x04015686 RID: 87686
		DirectLightSampleMode_SampleMaterialOnly,
		// Token: 0x04015687 RID: 87687
		DirectLightSampleMode_SampleLightOnly,
		// Token: 0x04015688 RID: 87688
		DirectLightSampleMode_Mis,
		// Token: 0x04015689 RID: 87689
		DirectLightSampleMode_Max,
		// Token: 0x0401568A RID: 87690
		DirectLightSampleMode_MAX
	}
}
