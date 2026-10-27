using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200132F RID: 4911
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EAbilityTaskNetSyncType")]
	public enum EAbilityTaskNetSyncType : byte
	{
		// Token: 0x04009A83 RID: 39555
		BothWait,
		// Token: 0x04009A84 RID: 39556
		OnlyServerWait,
		// Token: 0x04009A85 RID: 39557
		OnlyClientWait,
		// Token: 0x04009A86 RID: 39558
		EAbilityTaskNetSyncType_MAX
	}
}
