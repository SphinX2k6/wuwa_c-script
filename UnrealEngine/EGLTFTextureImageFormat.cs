using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001441 RID: 5185
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFTextureImageFormat")]
	public enum EGLTFTextureImageFormat : byte
	{
		// Token: 0x0400A22B RID: 41515
		None,
		// Token: 0x0400A22C RID: 41516
		PNG,
		// Token: 0x0400A22D RID: 41517
		JPEG,
		// Token: 0x0400A22E RID: 41518
		EGLTFTextureImageFormat_MAX
	}
}
