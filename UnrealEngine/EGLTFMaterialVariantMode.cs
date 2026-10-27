using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200143F RID: 5183
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFMaterialVariantMode")]
	public enum EGLTFMaterialVariantMode : byte
	{
		// Token: 0x0400A222 RID: 41506
		None,
		// Token: 0x0400A223 RID: 41507
		Simple,
		// Token: 0x0400A224 RID: 41508
		UseMeshData,
		// Token: 0x0400A225 RID: 41509
		EGLTFMaterialVariantMode_MAX
	}
}
