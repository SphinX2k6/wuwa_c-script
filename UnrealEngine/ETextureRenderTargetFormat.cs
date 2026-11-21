using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000203 RID: 515
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureRenderTargetFormat")]
	public enum ETextureRenderTargetFormat
	{
		// Token: 0x04000CCE RID: 3278
		RTF_R8,
		// Token: 0x04000CCF RID: 3279
		RTF_RG8,
		// Token: 0x04000CD0 RID: 3280
		RTF_RGBA8,
		// Token: 0x04000CD1 RID: 3281
		RTF_RGBA8_SRGB,
		// Token: 0x04000CD2 RID: 3282
		RTF_R16f,
		// Token: 0x04000CD3 RID: 3283
		RTF_RG16f,
		// Token: 0x04000CD4 RID: 3284
		RTF_RGBA16f,
		// Token: 0x04000CD5 RID: 3285
		RTF_R32f,
		// Token: 0x04000CD6 RID: 3286
		RTF_RG32f,
		// Token: 0x04000CD7 RID: 3287
		RTF_RGBA32f,
		// Token: 0x04000CD8 RID: 3288
		RTF_RGB10A2,
		// Token: 0x04000CD9 RID: 3289
		RTF_MAX
	}
}
