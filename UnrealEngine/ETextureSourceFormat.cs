using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B90 RID: 2960
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureSourceFormat")]
	public enum ETextureSourceFormat
	{
		// Token: 0x04005179 RID: 20857
		TSF_Invalid,
		// Token: 0x0400517A RID: 20858
		TSF_G8,
		// Token: 0x0400517B RID: 20859
		TSF_BGRA8,
		// Token: 0x0400517C RID: 20860
		TSF_BGRE8,
		// Token: 0x0400517D RID: 20861
		TSF_RGBA16,
		// Token: 0x0400517E RID: 20862
		TSF_RGBA16F,
		// Token: 0x0400517F RID: 20863
		TSF_RGBA8,
		// Token: 0x04005180 RID: 20864
		TSF_RGBE8,
		// Token: 0x04005181 RID: 20865
		TSF_G16,
		// Token: 0x04005182 RID: 20866
		TSF_MAX
	}
}
