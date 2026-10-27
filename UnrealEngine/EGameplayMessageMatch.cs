using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013CC RID: 5068
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayMessageRuntime.EGameplayMessageMatch")]
	public enum EGameplayMessageMatch : byte
	{
		// Token: 0x04009EB5 RID: 40629
		ExactMatch,
		// Token: 0x04009EB6 RID: 40630
		PartialMatch,
		// Token: 0x04009EB7 RID: 40631
		EGameplayMessageMatch_MAX
	}
}
