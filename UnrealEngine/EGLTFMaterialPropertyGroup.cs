using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200143E RID: 5182
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFMaterialPropertyGroup")]
	public enum EGLTFMaterialPropertyGroup : byte
	{
		// Token: 0x0400A218 RID: 41496
		None,
		// Token: 0x0400A219 RID: 41497
		BaseColorOpacity,
		// Token: 0x0400A21A RID: 41498
		MetallicRoughness,
		// Token: 0x0400A21B RID: 41499
		EmissiveColor,
		// Token: 0x0400A21C RID: 41500
		Normal,
		// Token: 0x0400A21D RID: 41501
		AmbientOcclusion,
		// Token: 0x0400A21E RID: 41502
		ClearCoatRoughness,
		// Token: 0x0400A21F RID: 41503
		ClearCoatBottomNormal,
		// Token: 0x0400A220 RID: 41504
		EGLTFMaterialPropertyGroup_MAX
	}
}
