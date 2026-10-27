using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF6 RID: 8182
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ETextureTransitionType")]
	public enum ETextureTransitionType : byte
	{
		// Token: 0x04010C09 RID: 68617
		ESTT_ColorOnly,
		// Token: 0x04010C0A RID: 68618
		ESTT_ColorAndTexture,
		// Token: 0x04010C0B RID: 68619
		ESTT_MAX
	}
}
