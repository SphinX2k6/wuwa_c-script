using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6B RID: 2667
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFFTSize")]
	public enum EFFTSize : byte
	{
		// Token: 0x0400478F RID: 18319
		DefaultSize,
		// Token: 0x04004790 RID: 18320
		Min,
		// Token: 0x04004791 RID: 18321
		Small,
		// Token: 0x04004792 RID: 18322
		Medium,
		// Token: 0x04004793 RID: 18323
		Large,
		// Token: 0x04004794 RID: 18324
		VeryLarge,
		// Token: 0x04004795 RID: 18325
		Max,
		// Token: 0x04004796 RID: 18326
		EFFTSize_MAX
	}
}
