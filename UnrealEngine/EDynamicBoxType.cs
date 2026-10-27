using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002957 RID: 10583
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EDynamicBoxType")]
	public enum EDynamicBoxType : byte
	{
		// Token: 0x04015888 RID: 88200
		Horizontal,
		// Token: 0x04015889 RID: 88201
		Vertical,
		// Token: 0x0401588A RID: 88202
		Wrap,
		// Token: 0x0401588B RID: 88203
		VerticalWrap,
		// Token: 0x0401588C RID: 88204
		Radial,
		// Token: 0x0401588D RID: 88205
		Overlay,
		// Token: 0x0401588E RID: 88206
		EDynamicBoxType_MAX
	}
}
