using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF3 RID: 8179
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ESpriteTransitionType")]
	public enum ESpriteTransitionType : byte
	{
		// Token: 0x04010BF6 RID: 68598
		ESTT_ColorOnly,
		// Token: 0x04010BF7 RID: 68599
		ESTT_ColorAndSprite,
		// Token: 0x04010BF8 RID: 68600
		ESTT_MAX
	}
}
