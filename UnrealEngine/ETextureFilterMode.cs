using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E86 RID: 7814
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroTeaHelper.ETextureFilterMode")]
	public enum ETextureFilterMode : byte
	{
		// Token: 0x040101A0 RID: 65952
		Nearest,
		// Token: 0x040101A1 RID: 65953
		Bilinear,
		// Token: 0x040101A2 RID: 65954
		ETextureFilterMode_MAX
	}
}
