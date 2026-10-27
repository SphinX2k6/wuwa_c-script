using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001440 RID: 5184
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFTextureHDREncoding")]
	public enum EGLTFTextureHDREncoding : byte
	{
		// Token: 0x0400A227 RID: 41511
		None,
		// Token: 0x0400A228 RID: 41512
		RGBM,
		// Token: 0x0400A229 RID: 41513
		EGLTFTextureHDREncoding_MAX
	}
}
