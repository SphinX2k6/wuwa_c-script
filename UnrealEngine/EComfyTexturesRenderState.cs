using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A3 RID: 1187
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComfyTextures.EComfyTexturesRenderState")]
	public enum EComfyTexturesRenderState : byte
	{
		// Token: 0x04001E2F RID: 7727
		Pending,
		// Token: 0x04001E30 RID: 7728
		Started,
		// Token: 0x04001E31 RID: 7729
		Finished,
		// Token: 0x04001E32 RID: 7730
		Failed,
		// Token: 0x04001E33 RID: 7731
		EComfyTexturesRenderState_MAX
	}
}
