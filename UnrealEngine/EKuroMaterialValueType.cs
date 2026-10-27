using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001458 RID: 5208
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GraphEditor.EKuroMaterialValueType")]
	public enum EKuroMaterialValueType : byte
	{
		// Token: 0x0400A308 RID: 41736
		KMCT_None,
		// Token: 0x0400A309 RID: 41737
		KMCT_Float1,
		// Token: 0x0400A30A RID: 41738
		KMCT_Float2,
		// Token: 0x0400A30B RID: 41739
		KMCT_Float3,
		// Token: 0x0400A30C RID: 41740
		KMCT_Float4,
		// Token: 0x0400A30D RID: 41741
		KMCT_Float,
		// Token: 0x0400A30E RID: 41742
		KMCT_Texture2D,
		// Token: 0x0400A30F RID: 41743
		KMCT_TextureCube,
		// Token: 0x0400A310 RID: 41744
		KMCT_Texture2DArray,
		// Token: 0x0400A311 RID: 41745
		KMCT_VolumeTexture,
		// Token: 0x0400A312 RID: 41746
		KMCT_StaticBool,
		// Token: 0x0400A313 RID: 41747
		KMCT_Unknown,
		// Token: 0x0400A314 RID: 41748
		KMCT_MaterialAttributes,
		// Token: 0x0400A315 RID: 41749
		KMCT_TextureExternal,
		// Token: 0x0400A316 RID: 41750
		KMCT_TextureVirtual,
		// Token: 0x0400A317 RID: 41751
		KMCT_Texture,
		// Token: 0x0400A318 RID: 41752
		KMCT_VTPageTableResult,
		// Token: 0x0400A319 RID: 41753
		KMCT_ShadingModel,
		// Token: 0x0400A31A RID: 41754
		KMCT_MAX
	}
}
