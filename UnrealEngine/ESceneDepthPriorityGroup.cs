using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B5C RID: 2908
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneDepthPriorityGroup")]
	public enum ESceneDepthPriorityGroup
	{
		// Token: 0x04005009 RID: 20489
		SDPG_World,
		// Token: 0x0400500A RID: 20490
		SDPG_Foreground,
		// Token: 0x0400500B RID: 20491
		SDPG_MAX
	}
}
