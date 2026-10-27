using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001442 RID: 5186
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFVariantSetsMode")]
	public enum EGLTFVariantSetsMode : byte
	{
		// Token: 0x0400A230 RID: 41520
		None,
		// Token: 0x0400A231 RID: 41521
		Khronos,
		// Token: 0x0400A232 RID: 41522
		Epic,
		// Token: 0x0400A233 RID: 41523
		EGLTFVariantSetsMode_MAX
	}
}
