using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E0 RID: 480
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEasingFunc")]
	public enum EEasingFunc
	{
		// Token: 0x04000BD9 RID: 3033
		Linear,
		// Token: 0x04000BDA RID: 3034
		Step,
		// Token: 0x04000BDB RID: 3035
		SinusoidalIn,
		// Token: 0x04000BDC RID: 3036
		SinusoidalOut,
		// Token: 0x04000BDD RID: 3037
		SinusoidalInOut,
		// Token: 0x04000BDE RID: 3038
		EaseIn,
		// Token: 0x04000BDF RID: 3039
		EaseOut,
		// Token: 0x04000BE0 RID: 3040
		EaseInOut,
		// Token: 0x04000BE1 RID: 3041
		ExpoIn,
		// Token: 0x04000BE2 RID: 3042
		ExpoOut,
		// Token: 0x04000BE3 RID: 3043
		ExpoInOut,
		// Token: 0x04000BE4 RID: 3044
		CircularIn,
		// Token: 0x04000BE5 RID: 3045
		CircularOut,
		// Token: 0x04000BE6 RID: 3046
		CircularInOut,
		// Token: 0x04000BE7 RID: 3047
		EEasingFunc_MAX
	}
}
