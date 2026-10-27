using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019BF RID: 6591
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EEasingType")]
	public enum EEasingType : byte
	{
		// Token: 0x0400D3CE RID: 54222
		Linear,
		// Token: 0x0400D3CF RID: 54223
		EaseInSine,
		// Token: 0x0400D3D0 RID: 54224
		EaseOutSine,
		// Token: 0x0400D3D1 RID: 54225
		EaseInOutSine,
		// Token: 0x0400D3D2 RID: 54226
		EaseInQuad,
		// Token: 0x0400D3D3 RID: 54227
		EaseOutQuad,
		// Token: 0x0400D3D4 RID: 54228
		EaseInOutQuad,
		// Token: 0x0400D3D5 RID: 54229
		EaseInCubic,
		// Token: 0x0400D3D6 RID: 54230
		EaseOutCubic,
		// Token: 0x0400D3D7 RID: 54231
		EaseInOutCubic,
		// Token: 0x0400D3D8 RID: 54232
		EaseInQuart,
		// Token: 0x0400D3D9 RID: 54233
		EaseOutQuart,
		// Token: 0x0400D3DA RID: 54234
		EaseInOutQuart,
		// Token: 0x0400D3DB RID: 54235
		EaseInQuint,
		// Token: 0x0400D3DC RID: 54236
		EaseOutQuint,
		// Token: 0x0400D3DD RID: 54237
		EaseInOutQuint,
		// Token: 0x0400D3DE RID: 54238
		EaseInExpo,
		// Token: 0x0400D3DF RID: 54239
		EaseOutExpo,
		// Token: 0x0400D3E0 RID: 54240
		EaseInOutExpo,
		// Token: 0x0400D3E1 RID: 54241
		EaseInCirc,
		// Token: 0x0400D3E2 RID: 54242
		EaseOutCirc,
		// Token: 0x0400D3E3 RID: 54243
		EaseInOutCirc,
		// Token: 0x0400D3E4 RID: 54244
		EaseInBack,
		// Token: 0x0400D3E5 RID: 54245
		EaseOutBack,
		// Token: 0x0400D3E6 RID: 54246
		EaseInOutBack,
		// Token: 0x0400D3E7 RID: 54247
		EaseInElastic,
		// Token: 0x0400D3E8 RID: 54248
		EaseOutElastic,
		// Token: 0x0400D3E9 RID: 54249
		EaseInOutElastic,
		// Token: 0x0400D3EA RID: 54250
		EaseInBounce,
		// Token: 0x0400D3EB RID: 54251
		EaseOutBounce,
		// Token: 0x0400D3EC RID: 54252
		EaseInOutBounce,
		// Token: 0x0400D3ED RID: 54253
		EEasingType_MAX
	}
}
