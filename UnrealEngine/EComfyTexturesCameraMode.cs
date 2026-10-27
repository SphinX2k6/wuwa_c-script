using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A0 RID: 1184
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComfyTextures.EComfyTexturesCameraMode")]
	public enum EComfyTexturesCameraMode : byte
	{
		// Token: 0x04001E22 RID: 7714
		EditorCamera,
		// Token: 0x04001E23 RID: 7715
		ExistingCamera,
		// Token: 0x04001E24 RID: 7716
		EComfyTexturesCameraMode_MAX
	}
}
