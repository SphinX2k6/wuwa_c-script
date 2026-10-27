using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020018B4 RID: 6324
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameplay.EKuroEasingFuncType")]
	public enum EKuroEasingFuncType : byte
	{
		// Token: 0x0400CB83 RID: 52099
		KEF_Linear,
		// Token: 0x0400CB84 RID: 52100
		KEF_EaseIn,
		// Token: 0x0400CB85 RID: 52101
		KEF_EaseOut,
		// Token: 0x0400CB86 RID: 52102
		KEF_EaseInOut,
		// Token: 0x0400CB87 RID: 52103
		KEF_SinIn,
		// Token: 0x0400CB88 RID: 52104
		KEF_SinOut,
		// Token: 0x0400CB89 RID: 52105
		KEF_SinInOut,
		// Token: 0x0400CB8A RID: 52106
		KEF_ExpoIn,
		// Token: 0x0400CB8B RID: 52107
		KEF_ExpoOut,
		// Token: 0x0400CB8C RID: 52108
		KEF_ExpoInOut,
		// Token: 0x0400CB8D RID: 52109
		KEF_CircularIn,
		// Token: 0x0400CB8E RID: 52110
		KEF_CircularOut,
		// Token: 0x0400CB8F RID: 52111
		KEF_CircularInOut,
		// Token: 0x0400CB90 RID: 52112
		KEF_FloatCurve,
		// Token: 0x0400CB91 RID: 52113
		KEF_CustomFunc,
		// Token: 0x0400CB92 RID: 52114
		KEF_MAX
	}
}
