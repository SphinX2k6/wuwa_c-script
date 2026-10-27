using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE6 RID: 8166
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIScreenSpaceUIAntiAliasing")]
	public enum ELGUIScreenSpaceUIAntiAliasing : byte
	{
		// Token: 0x04010B94 RID: 68500
		Hidden,
		// Token: 0x04010B95 RID: 68501
		Disabled,
		// Token: 0x04010B96 RID: 68502
		SampleCount_2x,
		// Token: 0x04010B97 RID: 68503
		SampleCount_4x = 4,
		// Token: 0x04010B98 RID: 68504
		SampleCount_8x = 8,
		// Token: 0x04010B99 RID: 68505
		ELGUIScreenSpaceUIAntiAliasing_MAX
	}
}
