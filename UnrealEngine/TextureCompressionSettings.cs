using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020011D2 RID: 4562
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.TextureCompressionSettings")]
	public enum TextureCompressionSettings
	{
		// Token: 0x04008FCC RID: 36812
		TC_Default,
		// Token: 0x04008FCD RID: 36813
		TC_Normalmap,
		// Token: 0x04008FCE RID: 36814
		TC_Masks,
		// Token: 0x04008FCF RID: 36815
		TC_Grayscale,
		// Token: 0x04008FD0 RID: 36816
		TC_Displacementmap,
		// Token: 0x04008FD1 RID: 36817
		TC_VectorDisplacementmap,
		// Token: 0x04008FD2 RID: 36818
		TC_HDR,
		// Token: 0x04008FD3 RID: 36819
		TC_EditorIcon,
		// Token: 0x04008FD4 RID: 36820
		TC_Alpha,
		// Token: 0x04008FD5 RID: 36821
		TC_DistanceFieldFont,
		// Token: 0x04008FD6 RID: 36822
		TC_HDR_Compressed,
		// Token: 0x04008FD7 RID: 36823
		TC_BC7,
		// Token: 0x04008FD8 RID: 36824
		TC_HalfFloat,
		// Token: 0x04008FD9 RID: 36825
		TC_ReflectionCapture,
		// Token: 0x04008FDA RID: 36826
		TC_HDR_Compressed_Signed,
		// Token: 0x04008FDB RID: 36827
		TC_MAX
	}
}
