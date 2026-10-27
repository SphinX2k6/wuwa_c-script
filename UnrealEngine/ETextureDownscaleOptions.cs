using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B89 RID: 2953
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureDownscaleOptions")]
	public enum ETextureDownscaleOptions : byte
	{
		// Token: 0x0400513B RID: 20795
		Default,
		// Token: 0x0400513C RID: 20796
		Unfiltered,
		// Token: 0x0400513D RID: 20797
		SimpleAverage,
		// Token: 0x0400513E RID: 20798
		Sharpen0,
		// Token: 0x0400513F RID: 20799
		Sharpen1,
		// Token: 0x04005140 RID: 20800
		Sharpen2,
		// Token: 0x04005141 RID: 20801
		Sharpen3,
		// Token: 0x04005142 RID: 20802
		Sharpen4,
		// Token: 0x04005143 RID: 20803
		Sharpen5,
		// Token: 0x04005144 RID: 20804
		Sharpen6,
		// Token: 0x04005145 RID: 20805
		Sharpen7,
		// Token: 0x04005146 RID: 20806
		Sharpen8,
		// Token: 0x04005147 RID: 20807
		Sharpen9,
		// Token: 0x04005148 RID: 20808
		Sharpen10,
		// Token: 0x04005149 RID: 20809
		ETextureDownscaleOptions_MAX
	}
}
