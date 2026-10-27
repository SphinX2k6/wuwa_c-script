using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ACB RID: 2763
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMeshFeatureImportance")]
	public enum EMeshFeatureImportance
	{
		// Token: 0x04004A8D RID: 19085
		Off,
		// Token: 0x04004A8E RID: 19086
		Lowest,
		// Token: 0x04004A8F RID: 19087
		Low,
		// Token: 0x04004A90 RID: 19088
		Normal,
		// Token: 0x04004A91 RID: 19089
		High,
		// Token: 0x04004A92 RID: 19090
		Highest,
		// Token: 0x04004A93 RID: 19091
		EMeshFeatureImportance_MAX
	}
}
