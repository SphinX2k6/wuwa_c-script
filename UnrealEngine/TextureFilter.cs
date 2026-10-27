using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020011D4 RID: 4564
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.TextureFilter")]
	public enum TextureFilter
	{
		// Token: 0x04008FE0 RID: 36832
		TF_Nearest,
		// Token: 0x04008FE1 RID: 36833
		TF_Bilinear,
		// Token: 0x04008FE2 RID: 36834
		TF_Trilinear,
		// Token: 0x04008FE3 RID: 36835
		TF_Default,
		// Token: 0x04008FE4 RID: 36836
		TF_MAX
	}
}
