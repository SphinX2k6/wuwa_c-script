using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F58 RID: 8024
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.EKuroIndexmapMipOption")]
	public enum EKuroIndexmapMipOption : byte
	{
		// Token: 0x04010751 RID: 67409
		KuroIndexmapMipOption_Default,
		// Token: 0x04010752 RID: 67410
		KuroIndexmapMipOption_NoMips,
		// Token: 0x04010753 RID: 67411
		KuroIndexmapMipOption_UseMips,
		// Token: 0x04010754 RID: 67412
		KuroIndexmapMipOption_MAX
	}
}
