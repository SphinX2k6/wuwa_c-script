using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B5A RID: 2906
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneCapturePrimitiveRenderMode")]
	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		// Token: 0x04004FF5 RID: 20469
		PRM_LegacySceneCapture,
		// Token: 0x04004FF6 RID: 20470
		PRM_RenderScenePrimitives,
		// Token: 0x04004FF7 RID: 20471
		PRM_UseShowOnlyList,
		// Token: 0x04004FF8 RID: 20472
		PRM_MAX
	}
}
