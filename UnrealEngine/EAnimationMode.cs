using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001C9 RID: 457
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimationMode")]
	public enum EAnimationMode
	{
		// Token: 0x04000B29 RID: 2857
		AnimationBlueprint,
		// Token: 0x04000B2A RID: 2858
		AnimationSingleNode,
		// Token: 0x04000B2B RID: 2859
		AnimationCustomMode,
		// Token: 0x04000B2C RID: 2860
		EAnimationMode_MAX
	}
}
