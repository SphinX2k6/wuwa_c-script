using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003D6 RID: 982
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameplay.EKuroEasingFuncType")]
	public enum EKuroEasingFuncType : byte
	{
		// Token: 0x04002942 RID: 10562
		KEF_Linear,
		// Token: 0x04002943 RID: 10563
		KEF_EaseIn,
		// Token: 0x04002944 RID: 10564
		KEF_EaseOut,
		// Token: 0x04002945 RID: 10565
		KEF_EaseInOut,
		// Token: 0x04002946 RID: 10566
		KEF_SinIn,
		// Token: 0x04002947 RID: 10567
		KEF_SinOut,
		// Token: 0x04002948 RID: 10568
		KEF_SinInOut,
		// Token: 0x04002949 RID: 10569
		KEF_ExpoIn,
		// Token: 0x0400294A RID: 10570
		KEF_ExpoOut,
		// Token: 0x0400294B RID: 10571
		KEF_ExpoInOut,
		// Token: 0x0400294C RID: 10572
		KEF_CircularIn,
		// Token: 0x0400294D RID: 10573
		KEF_CircularOut,
		// Token: 0x0400294E RID: 10574
		KEF_CircularInOut,
		// Token: 0x0400294F RID: 10575
		KEF_FloatCurve,
		// Token: 0x04002950 RID: 10576
		KEF_CustomFunc,
		// Token: 0x04002951 RID: 10577
		KEF_MAX
	}
}
