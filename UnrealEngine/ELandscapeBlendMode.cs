using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F59 RID: 8025
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.ELandscapeBlendMode")]
	public enum ELandscapeBlendMode
	{
		// Token: 0x04010756 RID: 67414
		LSBM_AdditiveBlend,
		// Token: 0x04010757 RID: 67415
		LSBM_AlphaBlend,
		// Token: 0x04010758 RID: 67416
		LSBM_MAX
	}
}
