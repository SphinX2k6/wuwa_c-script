using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A48 RID: 6728
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroRHIFeatureLevel")]
	public enum EKuroRHIFeatureLevel : byte
	{
		// Token: 0x0400D747 RID: 55111
		KURO_ES2_REMOVED,
		// Token: 0x0400D748 RID: 55112
		KURO_ES3_1,
		// Token: 0x0400D749 RID: 55113
		KURO_SM4_REMOVED,
		// Token: 0x0400D74A RID: 55114
		KURO_SM5,
		// Token: 0x0400D74B RID: 55115
		KURO_SM6,
		// Token: 0x0400D74C RID: 55116
		MAXNum,
		// Token: 0x0400D74D RID: 55117
		EKuroRHIFeatureLevel_MAX
	}
}
