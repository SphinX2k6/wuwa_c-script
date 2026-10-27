using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A4 RID: 1188
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComfyTextures.EComfyTexturesState")]
	public enum EComfyTexturesState : byte
	{
		// Token: 0x04001E35 RID: 7733
		Disconnected,
		// Token: 0x04001E36 RID: 7734
		Reconnecting,
		// Token: 0x04001E37 RID: 7735
		Idle,
		// Token: 0x04001E38 RID: 7736
		Rendering,
		// Token: 0x04001E39 RID: 7737
		Processing,
		// Token: 0x04001E3A RID: 7738
		EComfyTexturesState_MAX
	}
}
