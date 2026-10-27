using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A13 RID: 10771
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ECookProgressDisplayMode")]
	public enum ECookProgressDisplayMode
	{
		// Token: 0x04015D93 RID: 89491
		Nothing,
		// Token: 0x04015D94 RID: 89492
		RemainingPackages,
		// Token: 0x04015D95 RID: 89493
		PackageNames,
		// Token: 0x04015D96 RID: 89494
		NamesAndRemainingPackages,
		// Token: 0x04015D97 RID: 89495
		Max,
		// Token: 0x04015D98 RID: 89496
		ECookProgressDisplayMode_MAX
	}
}
