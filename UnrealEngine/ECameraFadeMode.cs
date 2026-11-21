using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CF RID: 463
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraFadeMode")]
	public enum ECameraFadeMode
	{
		// Token: 0x04000B4C RID: 2892
		CFM_Linear,
		// Token: 0x04000B4D RID: 2893
		CFM_Transient,
		// Token: 0x04000B4E RID: 2894
		CFM_InOutCubic,
		// Token: 0x04000B4F RID: 2895
		CFM_OutSine,
		// Token: 0x04000B50 RID: 2896
		CFM_OutQuart,
		// Token: 0x04000B51 RID: 2897
		CFM_MAX
	}
}
