using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200229D RID: 8861
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaAssets.MediaTextureOrientation")]
	public enum MediaTextureOrientation
	{
		// Token: 0x04011FBF RID: 73663
		MTORI_Original,
		// Token: 0x04011FC0 RID: 73664
		MTORI_CW90,
		// Token: 0x04011FC1 RID: 73665
		MTORI_CW180,
		// Token: 0x04011FC2 RID: 73666
		MTORI_CW270,
		// Token: 0x04011FC3 RID: 73667
		MTORI_MAX
	}
}
