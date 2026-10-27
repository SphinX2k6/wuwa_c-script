using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009EA RID: 2538
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimationMode")]
	public enum EAnimationMode
	{
		// Token: 0x04004420 RID: 17440
		AnimationBlueprint,
		// Token: 0x04004421 RID: 17441
		AnimationSingleNode,
		// Token: 0x04004422 RID: 17442
		AnimationCustomMode,
		// Token: 0x04004423 RID: 17443
		EAnimationMode_MAX
	}
}
