using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001337 RID: 4919
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityTargetingLocationType")]
	public enum EGameplayAbilityTargetingLocationType
	{
		// Token: 0x04009AB5 RID: 39605
		LiteralTransform,
		// Token: 0x04009AB6 RID: 39606
		ActorTransform,
		// Token: 0x04009AB7 RID: 39607
		SocketTransform,
		// Token: 0x04009AB8 RID: 39608
		EGameplayAbilityTargetingLocationType_MAX
	}
}
