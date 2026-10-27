using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A5E RID: 2654
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEasingFunc")]
	public enum EEasingFunc
	{
		// Token: 0x0400473F RID: 18239
		Linear,
		// Token: 0x04004740 RID: 18240
		Step,
		// Token: 0x04004741 RID: 18241
		SinusoidalIn,
		// Token: 0x04004742 RID: 18242
		SinusoidalOut,
		// Token: 0x04004743 RID: 18243
		SinusoidalInOut,
		// Token: 0x04004744 RID: 18244
		EaseIn,
		// Token: 0x04004745 RID: 18245
		EaseOut,
		// Token: 0x04004746 RID: 18246
		EaseInOut,
		// Token: 0x04004747 RID: 18247
		ExpoIn,
		// Token: 0x04004748 RID: 18248
		ExpoOut,
		// Token: 0x04004749 RID: 18249
		ExpoInOut,
		// Token: 0x0400474A RID: 18250
		CircularIn,
		// Token: 0x0400474B RID: 18251
		CircularOut,
		// Token: 0x0400474C RID: 18252
		CircularInOut,
		// Token: 0x0400474D RID: 18253
		EEasingFunc_MAX
	}
}
