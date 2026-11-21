using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F9 RID: 505
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneCapturePrimitiveRenderMode")]
	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		// Token: 0x04000C90 RID: 3216
		PRM_LegacySceneCapture,
		// Token: 0x04000C91 RID: 3217
		PRM_RenderScenePrimitives,
		// Token: 0x04000C92 RID: 3218
		PRM_UseShowOnlyList,
		// Token: 0x04000C93 RID: 3219
		PRM_MAX
	}
}
