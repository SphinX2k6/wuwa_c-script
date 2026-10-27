using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A2 RID: 1186
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComfyTextures.EComfyTexturesMode")]
	public enum EComfyTexturesMode : byte
	{
		// Token: 0x04001E2A RID: 7722
		Create,
		// Token: 0x04001E2B RID: 7723
		Edit,
		// Token: 0x04001E2C RID: 7724
		Refine,
		// Token: 0x04001E2D RID: 7725
		EComfyTexturesMode_MAX
	}
}
