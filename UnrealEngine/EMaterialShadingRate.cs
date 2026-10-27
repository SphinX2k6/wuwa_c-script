using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC0 RID: 2752
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialShadingRate")]
	public enum EMaterialShadingRate
	{
		// Token: 0x04004A14 RID: 18964
		MSR_1x1,
		// Token: 0x04004A15 RID: 18965
		MSR_2x1,
		// Token: 0x04004A16 RID: 18966
		MSR_1x2,
		// Token: 0x04004A17 RID: 18967
		MSR_2x2,
		// Token: 0x04004A18 RID: 18968
		MSR_4x2,
		// Token: 0x04004A19 RID: 18969
		MSR_2x4,
		// Token: 0x04004A1A RID: 18970
		MSR_4x4,
		// Token: 0x04004A1B RID: 18971
		MSR_Count,
		// Token: 0x04004A1C RID: 18972
		MSR_MAX
	}
}
