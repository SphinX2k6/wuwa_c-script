using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A1 RID: 1185
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComfyTextures.EComfyTexturesEditMaskMode")]
	public enum EComfyTexturesEditMaskMode : byte
	{
		// Token: 0x04001E26 RID: 7718
		FromTexture,
		// Token: 0x04001E27 RID: 7719
		FromObject,
		// Token: 0x04001E28 RID: 7720
		EComfyTexturesEditMaskMode_MAX
	}
}
