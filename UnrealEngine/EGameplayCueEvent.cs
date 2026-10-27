using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001339 RID: 4921
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayCueEvent")]
	public enum EGameplayCueEvent
	{
		// Token: 0x04009ABF RID: 39615
		OnActive,
		// Token: 0x04009AC0 RID: 39616
		WhileActive,
		// Token: 0x04009AC1 RID: 39617
		Executed,
		// Token: 0x04009AC2 RID: 39618
		Removed,
		// Token: 0x04009AC3 RID: 39619
		EGameplayCueEvent_MAX
	}
}
