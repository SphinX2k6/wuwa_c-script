using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031A RID: 794
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EEasingFuncType")]
	public enum EEasingFuncType : byte
	{
		// Token: 0x040012F3 RID: 4851
		Linear,
		// Token: 0x040012F4 RID: 4852
		Sinusoidal,
		// Token: 0x040012F5 RID: 4853
		Cubic,
		// Token: 0x040012F6 RID: 4854
		QuadraticInOut,
		// Token: 0x040012F7 RID: 4855
		CubicInOut,
		// Token: 0x040012F8 RID: 4856
		HermiteCubic,
		// Token: 0x040012F9 RID: 4857
		QuarticInOut,
		// Token: 0x040012FA RID: 4858
		QuinticInOut,
		// Token: 0x040012FB RID: 4859
		CircularIn,
		// Token: 0x040012FC RID: 4860
		CircularOut,
		// Token: 0x040012FD RID: 4861
		CircularInOut,
		// Token: 0x040012FE RID: 4862
		ExpIn,
		// Token: 0x040012FF RID: 4863
		ExpOut,
		// Token: 0x04001300 RID: 4864
		ExpInOut,
		// Token: 0x04001301 RID: 4865
		CustomCurve,
		// Token: 0x04001302 RID: 4866
		EEasingFuncType_MAX
	}
}
