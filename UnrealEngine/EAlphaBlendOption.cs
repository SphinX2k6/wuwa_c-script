using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E6 RID: 2534
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAlphaBlendOption")]
	public enum EAlphaBlendOption : byte
	{
		// Token: 0x04004401 RID: 17409
		Linear,
		// Token: 0x04004402 RID: 17410
		Cubic,
		// Token: 0x04004403 RID: 17411
		HermiteCubic,
		// Token: 0x04004404 RID: 17412
		Sinusoidal,
		// Token: 0x04004405 RID: 17413
		QuadraticInOut,
		// Token: 0x04004406 RID: 17414
		CubicInOut,
		// Token: 0x04004407 RID: 17415
		QuarticInOut,
		// Token: 0x04004408 RID: 17416
		QuinticInOut,
		// Token: 0x04004409 RID: 17417
		CircularIn,
		// Token: 0x0400440A RID: 17418
		CircularOut,
		// Token: 0x0400440B RID: 17419
		CircularInOut,
		// Token: 0x0400440C RID: 17420
		ExpIn,
		// Token: 0x0400440D RID: 17421
		ExpOut,
		// Token: 0x0400440E RID: 17422
		ExpInOut,
		// Token: 0x0400440F RID: 17423
		Custom,
		// Token: 0x04004410 RID: 17424
		EAlphaBlendOption_MAX
	}
}
