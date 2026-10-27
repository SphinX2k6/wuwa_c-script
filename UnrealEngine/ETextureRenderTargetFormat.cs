using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8E RID: 2958
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureRenderTargetFormat")]
	public enum ETextureRenderTargetFormat
	{
		// Token: 0x04005166 RID: 20838
		RTF_R8,
		// Token: 0x04005167 RID: 20839
		RTF_RG8,
		// Token: 0x04005168 RID: 20840
		RTF_RGBA8,
		// Token: 0x04005169 RID: 20841
		RTF_RGBA8_SRGB,
		// Token: 0x0400516A RID: 20842
		RTF_R16f,
		// Token: 0x0400516B RID: 20843
		RTF_RG16f,
		// Token: 0x0400516C RID: 20844
		RTF_RGBA16f,
		// Token: 0x0400516D RID: 20845
		RTF_R32f,
		// Token: 0x0400516E RID: 20846
		RTF_RG32f,
		// Token: 0x0400516F RID: 20847
		RTF_RGBA32f,
		// Token: 0x04005170 RID: 20848
		RTF_RGB10A2,
		// Token: 0x04005171 RID: 20849
		RTF_MAX
	}
}
