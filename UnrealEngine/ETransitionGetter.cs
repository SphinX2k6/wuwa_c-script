using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200034A RID: 842
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraph.ETransitionGetter")]
	public enum ETransitionGetter
	{
		// Token: 0x04001420 RID: 5152
		AnimationAsset_GetCurrentTime,
		// Token: 0x04001421 RID: 5153
		AnimationAsset_GetLength,
		// Token: 0x04001422 RID: 5154
		AnimationAsset_GetCurrentTimeFraction,
		// Token: 0x04001423 RID: 5155
		AnimationAsset_GetTimeFromEnd,
		// Token: 0x04001424 RID: 5156
		AnimationAsset_GetTimeFromEndFraction,
		// Token: 0x04001425 RID: 5157
		CurrentState_ElapsedTime,
		// Token: 0x04001426 RID: 5158
		CurrentState_GetBlendWeight,
		// Token: 0x04001427 RID: 5159
		CurrentTransitionDuration,
		// Token: 0x04001428 RID: 5160
		ArbitraryState_GetBlendWeight,
		// Token: 0x04001429 RID: 5161
		ETransitionGetter_MAX
	}
}
