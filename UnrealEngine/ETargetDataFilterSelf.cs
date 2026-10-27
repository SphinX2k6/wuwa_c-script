using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001349 RID: 4937
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.ETargetDataFilterSelf")]
	public enum ETargetDataFilterSelf
	{
		// Token: 0x04009B17 RID: 39703
		TDFS_Any,
		// Token: 0x04009B18 RID: 39704
		TDFS_NoSelf,
		// Token: 0x04009B19 RID: 39705
		TDFS_NoOthers,
		// Token: 0x04009B1A RID: 39706
		TDFS_MAX
	}
}
