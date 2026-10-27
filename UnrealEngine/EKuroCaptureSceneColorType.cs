using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002687 RID: 9863
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Renderer.EKuroCaptureSceneColorType")]
	public enum EKuroCaptureSceneColorType : byte
	{
		// Token: 0x04013AF8 RID: 80632
		KCSCT_Default,
		// Token: 0x04013AF9 RID: 80633
		KCSCT_ShouAnRen,
		// Token: 0x04013AFA RID: 80634
		KCSCT_Chun,
		// Token: 0x04013AFB RID: 80635
		KCSCT_Tideng,
		// Token: 0x04013AFC RID: 80636
		KCSCT_MAX
	}
}
