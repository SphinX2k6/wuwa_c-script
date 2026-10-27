using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200223E RID: 8766
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LTween.LTweenEase")]
	public enum LTweenEase : byte
	{
		// Token: 0x04011C7E RID: 72830
		Linear,
		// Token: 0x04011C7F RID: 72831
		InQuad,
		// Token: 0x04011C80 RID: 72832
		OutQuad,
		// Token: 0x04011C81 RID: 72833
		InOutQuad,
		// Token: 0x04011C82 RID: 72834
		InCubic,
		// Token: 0x04011C83 RID: 72835
		OutCubic,
		// Token: 0x04011C84 RID: 72836
		InOutCubic,
		// Token: 0x04011C85 RID: 72837
		InQuart,
		// Token: 0x04011C86 RID: 72838
		OutQuart,
		// Token: 0x04011C87 RID: 72839
		InOutQuart,
		// Token: 0x04011C88 RID: 72840
		InSine,
		// Token: 0x04011C89 RID: 72841
		OutSine,
		// Token: 0x04011C8A RID: 72842
		InOutSine,
		// Token: 0x04011C8B RID: 72843
		InExpo,
		// Token: 0x04011C8C RID: 72844
		OutExpo,
		// Token: 0x04011C8D RID: 72845
		InOutExpo,
		// Token: 0x04011C8E RID: 72846
		InCirc,
		// Token: 0x04011C8F RID: 72847
		OutCirc,
		// Token: 0x04011C90 RID: 72848
		InOutCirc,
		// Token: 0x04011C91 RID: 72849
		InElastic,
		// Token: 0x04011C92 RID: 72850
		OutElastic,
		// Token: 0x04011C93 RID: 72851
		InOutElastic,
		// Token: 0x04011C94 RID: 72852
		InBack,
		// Token: 0x04011C95 RID: 72853
		OutBack,
		// Token: 0x04011C96 RID: 72854
		InOutBack,
		// Token: 0x04011C97 RID: 72855
		InBounce,
		// Token: 0x04011C98 RID: 72856
		OutBounce,
		// Token: 0x04011C99 RID: 72857
		InOutBounce,
		// Token: 0x04011C9A RID: 72858
		CurveFloat,
		// Token: 0x04011C9B RID: 72859
		LTweenEase_MAX
	}
}
