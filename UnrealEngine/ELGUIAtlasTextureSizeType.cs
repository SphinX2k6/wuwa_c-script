using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FDD RID: 8157
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIAtlasTextureSizeType")]
	public enum ELGUIAtlasTextureSizeType : byte
	{
		// Token: 0x04010B5D RID: 68445
		SIZE_256x256,
		// Token: 0x04010B5E RID: 68446
		SIZE_512x512,
		// Token: 0x04010B5F RID: 68447
		SIZE_1024x1024,
		// Token: 0x04010B60 RID: 68448
		SIZE_2048x2048,
		// Token: 0x04010B61 RID: 68449
		SIZE_4096x4096,
		// Token: 0x04010B62 RID: 68450
		SIZE_8192x8192,
		// Token: 0x04010B63 RID: 68451
		SIZE_MAX
	}
}
